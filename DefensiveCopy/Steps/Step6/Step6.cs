using System;

namespace DefensiveCopy.Steps.Step6
{
    public class Step6
    {
        private readonly Num _number = new Num(1);

        public void Run()
        {
            Console.WriteLine("Before Increment: " + _number.ToString());
            _number.Increment();
            Console.WriteLine("After Increment: " + _number.ToString());
        }
    }

    public readonly struct Num
    {
        public readonly int Value;

        public Num(int value)
        {
            Value = value;
        }

        public Num Increment()
        {
            return new Num(Value + 1);
        }

        public override string ToString() => $"Value = {Value.ToString()}";
    }
}