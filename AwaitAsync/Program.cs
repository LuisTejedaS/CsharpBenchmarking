using System;
using System.Collections.Generic;
using System.Linq;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;

namespace MyBenchmarks
{
    [CoreJob]
    [RPlotExporter, RankColumn]
    public class Md5VsSha256
    {
 
        private List<int> data;

        [Params(1000, 10000)]
        public int N;

        [GlobalSetup]
        public void Setup()
        {

            data = new List<int>();

            for (int i = 0; i < N; i++)
            {
                data.Add(i);
            } 
        }

        //[Benchmark]
        //public byte[] Sha256() => sha256.ComputeHash(data);

        //[Benchmark]
        //public byte[] Md5() => md5.ComputeHash(data);

        [Benchmark]
        public int SumCicle() => Program.SumCicle(data);

        [Benchmark]
        public int SumLinq() => Program.SumLinq(data);
    }

    public class Program
    {
        public static void Main(string[] args)
        {
             var summary = BenchmarkRunner.Run<Md5VsSha256>();

            
        }

         
        public static int SumCicle(List<int> data)
        {
            var sum = 0;
            for (int i = 0; i < data.Count; i++)
            {
                Math.Sqrt(i);
                Math.Sqrt(i);
                Math.Sqrt(i);
                Math.Sqrt(i);
                Math.Sqrt(i);
                Math.Sqrt(i);
                Math.Sqrt(i);
                Math.Sqrt(i);
                Math.Sqrt(i);
                Math.Sqrt(i);
                Math.Sqrt(i);
                Math.Sqrt(i);
                Math.Sqrt(i);
                Math.Sqrt(i);
                Math.Sqrt(i);
                Math.Sqrt(i);
                Math.Sqrt(i);
                sum += data[i];
            }
            return sum;
        }
         
        public static int SumLinq(List<int> data)
        {
            return data.Sum();
        }
    }
}