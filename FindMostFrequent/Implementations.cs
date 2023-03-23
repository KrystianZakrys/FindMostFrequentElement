using BenchmarkDotNet.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMostFrequent
{
    [MemoryDiagnoser]
    [Orderer(BenchmarkDotNet.Order.SummaryOrderPolicy.FastestToSlowest)]
    [RankColumn]
    public class Implementations
    {
        List<int> dataSet = new List<int>();

        [GlobalSetup]
        public void GlobalSetup()
        {
            Random rnd = new Random();

            for(int i = 0; i < 5000000; i++)
            {
                dataSet.Add(rnd.Next());
            }
        }

        //TODO: Separate implementations from this class;
        [Benchmark]   
        public int? GetMostFrequentWithLinq()
        {
            int? result = null;
            try
            {
                result = dataSet.GroupBy(x => x).OrderByDescending(x => x.Count()).SingleOrDefault()?.Key;
            }
            catch (Exception)
            {

                return null;
            }

            return result;
        }

        [Benchmark]
        public int? GetMostFrequentWithDictionary()
        {
            if (dataSet == null || dataSet.Count() == 0) 
                return null;  

            int? mostCounted = null; 
            int biggestCount = 0; 
            Dictionary<int, int> dict = new Dictionary<int, int>(); 

            foreach (var value in dataSet) 
            { 
                if (!dict.TryGetValue(value, out int foundValue)) 
                { 
                    dict[value] = 1; 
                } 
                else
                { 
                    dict[value] = foundValue++; 
                } 

                if (dict[value] > biggestCount)
                { 
                    biggestCount = dict[value]; 
                    mostCounted = value; 
                } 
            }

            if (dict.Any(x => x.Key != mostCounted && x.Value == biggestCount))
                return null; 

            return mostCounted;
        }

        [Benchmark]
        public int? GetMostFrequentWithLinqMixedWithDictionary()
        {
            var dict = dataSet.ToLookup(x => x);

            if (dict.Count == 0)
                return null;

            var maxCount = dict.Max(x => x.Count());

            try
            {
                return dict.Where(x => x.Count() == maxCount).Select(x => x.Key).SingleOrDefault();
            }
            catch (Exception)
            {

                return null;
            }

        }


        //[Benchmark]
        //public static int? GetMostFrequentWithStackoverflowSolution(IEnumerable<int> dataSet)
        //{

        //}
    }
}
