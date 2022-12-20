using System;

namespace DefensiveCopy.Steps.Step4
{
    public class Step4
    {
        private Num _number = new Num(1);

        public void Run()
        {
            ref readonly Num number = ref _number;

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