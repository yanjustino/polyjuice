using System;
using NUnit.Framework;
using Polyjuice.Potions;

namespace Polyjuice.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestAddress()
        {
            Assert.IsNotEmpty(Address.Location);
        }
        
        [Test]
        public void TestBank()
        {
            var iban = Bank.Iban();
            var card = Bank.CardNumber;
            var type = Bank.CardType;
            var date = Bank.CardExpiryDate;
            
            Console.WriteLine(iban);
            Console.WriteLine(card);
            Console.WriteLine(type);
            Console.WriteLine(date);
            
            Assert.IsNotEmpty(iban);
            Assert.IsNotEmpty(card);
            Assert.IsNotEmpty(type);
            Assert.IsNotEmpty(date);
        }        
    }
}