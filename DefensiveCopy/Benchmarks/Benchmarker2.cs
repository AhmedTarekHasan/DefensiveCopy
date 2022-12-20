using BenchmarkDotNet.Attributes;

namespace DefensiveCopy.Benchmarks
{
    public readonly struct ReadOnlyNum
    {
        // Fields to just make the struct bigger
        private readonly long Field1, Field2, Field3, Field4;

        public long Value { get; }

        public ReadOnlyNum(long value) : this()
        {
            Value = value;
        }
    }

    [MemoryDiagnoser]
    [RankColumn]
    public class Benchmarker2
    {
        private const int Count = 1000_000;
        private ReadOnlyNum _number = new ReadOnlyNum(1);
        private readonly ReadOnlyNum _readonlyNumber = new ReadOnlyNum(1);

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