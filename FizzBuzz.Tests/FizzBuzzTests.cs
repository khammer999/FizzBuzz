using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz.Tests
{
    [TestFixture]
    public class FizzBuzzTests
    {
        FizzBuzzer fizzBuzzer;

        [SetUp]
        public void Setuo()
        {
            fizzBuzzer = new FizzBuzzer();
        }


        [Test]
        public void Get_Returns_1_For_1()
        {
            // Assert.That(true, Is.EqualTo`(false));
            //FizzBuzzer fizzBuzzer = new FizzBuzzer();

            string result = fizzBuzzer.Get(1);

            Assert.That(result, Is.EqualTo("1"));
        }
        [Test]
        public void Get_Returns_2For_2()
        {
            FizzBuzzer fizzBuzzer = new FizzBuzzer();
            string result = fizzBuzzer.Get(2);

            Assert.That(result, Is.EqualTo("2"));
        }
        [Test]
        public void Get_Returns_Fizz_For_3()
        {
            FizzBuzzer fizzBuzzer = new FizzBuzzer();
            string result = fizzBuzzer.Get(3);
            Assert.That(result, Is.EqualTo("Fizz"));
        }
        [Test]
        public void Get_Returns_Fizz_For_6()
        {
            string result = fizzBuzzer.Get(6);
            Assert.That(result, Is.EqualTo("Fizz"));
        }

        [Test]
        public void Get_Returns_Buzz_For_5()
        {
            string result = fizzBuzzer.Get(5);
            Assert.That(result, Is.EqualTo("Buzz"));
        }


        [Test]
        public void Get_Returns_Buzz_For_10()
        {
            string result = fizzBuzzer.Get(10);
            Assert.That(result, Is.EqualTo("Buzz"));
        }

        [TestCase(5,"Buzz")]
        [TestCase(10,"Buzz")]
        [TestCase(15, "FizzBuzz")]
        [TestCase(30, "FizzBuzz")]





        public void Get_Returns_Expected(int input, string output)
        {
            //int input = 10;
            //string output = "Buzz";
            string result = fizzBuzzer.Get(input);
            Assert.That(result, Is.EqualTo(output));
        }






    }
}
