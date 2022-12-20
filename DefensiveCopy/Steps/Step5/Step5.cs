using System;

namespace DefensiveCopy.Steps.Step5
{
    public class Step5
    {
        public void Run(in Num number)
        {
            Console.WriteLine("Before Increment: " + number.ToString());
            number.Increment();
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