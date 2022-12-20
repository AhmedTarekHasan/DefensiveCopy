using System;

namespace DefensiveCopy.Steps.Step2
{
    public class Step2
    {
        private readonly Num _number = new Num(1);

        public void Run()
        {
            Console.WriteLine("Before Increment: " + _number.ToString());
            _number.Increment();
            Console.WriteLine("After Increment: " + _number.ToString());
        }
    }

    public struct Num
    {
        public int Value;

        public Num(int value)
        {
            Value = value;
        }

        public void Increment()
        {
            Value++;
        }

        public override string ToString() => $"Value = {Value.ToString()}";
    }
}