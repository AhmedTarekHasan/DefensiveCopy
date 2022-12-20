using BenchmarkDotNet.Attributes;

namespace DefensiveCopy.Benchmarks
{
    public struct Num
    {
        // Fields to just make the struct bigger
        private long Field1, Field2, Field3, Field4;

        public long Value { get; }

        public Num(long value) : this()
        {
            Value = value;
        }
    }

    [MemoryDiagnoser]
    [RankColumn]
    public class Benchmarker1
    {
        private const int Count = 1000_000;
        private Num _number = new Num(1);
        private readonly Num _readonlyNumber = new Num(1);

        [Benchmark(Baseline = true)]
        public long UsingField()
        {
            long total = 0;

            for (var i = 0; i < Count; i++)
            {
                total += _number.Value;
            }

            return total;
        }

        [Benchmark]
        public long UsingReadonlyField()
        {
            long total = 0;

            for (var i = 0; i < Count; i++)
            {
                total += _readonlyNumber.Value;
            }

            return total;
        }
    }
}