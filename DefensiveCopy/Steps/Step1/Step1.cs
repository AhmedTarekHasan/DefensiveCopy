using System;

namespace DefensiveCopy.Steps.Step1
{
    public class Step1
    {
        private Num _number = new Num(1);

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