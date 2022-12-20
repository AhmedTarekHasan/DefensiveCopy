using System;

namespace DefensiveCopy.Steps.Step3
{
    public class Step3
    {
        private readonly Num _number = new Num(1);

        public void Run()
        {
            var number = _number;
            Console.WriteLine("Before Increment: " + number.ToString());

            number = _number;
            number.Increment();

            number = _number;
            Console.WriteLine("After Increment: " + number.ToString());
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