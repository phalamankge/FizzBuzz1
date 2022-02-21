using System;
using Xunit;
using FizzBuzz1;

namespace FizzBuzz1
{
    public class FizzBuzzersd
    {
        [Fact]
        public void Print1To100()
        {
            FizzBuzzer fizzBuzzer = new FizzBuzzer();
            bool FizzerBuzzerState = false;
            FizzerBuzzerState =  FizzBuzzer.Print1To100();

            Assert.True(FizzerBuzzerState == true);
        }
        [Fact]
        public void MultiplesOfThree()
        {
            FizzBuzzer fizzBuzzer = new FizzBuzzer();
            bool FizzerBuzzerState = false;
            FizzerBuzzerState = FizzBuzzer.MultiplesOfThree();

            Assert.True(FizzerBuzzerState == true);
        }
    }
}