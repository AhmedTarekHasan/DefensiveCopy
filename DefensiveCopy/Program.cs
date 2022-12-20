using System;
using BenchmarkDotNet.Running;
using DefensiveCopy.Benchmarks;
using DefensiveCopy.Steps.Step1;
using DefensiveCopy.Steps.Step2;
using DefensiveCopy.Steps.Step3;
using DefensiveCopy.Steps.Step4;
using DefensiveCopy.Steps.Step5;
using DefensiveCopy.Steps.Step6;

namespace DefensiveCopy
{
    public class Program
    {
        static void Main(string[] args)
        {
            //new Step1().Run();

            //new Step2().Run();

            //new Step3().Run();

            //new Step4().Run();

            /*var inputNum = new Num5(1);
            new Step5().Run(in inputNum);*/

            //new Step6().Run();

            //new Step7().Run();

            //BenchmarkRunner.Run<Benchmarker1>();

            //BenchmarkRunner.Run<Benchmarker2>();

            Console.ReadLine();
        }
    }
}