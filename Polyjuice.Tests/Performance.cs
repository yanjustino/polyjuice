using System;
using System.Diagnostics;
using NUnit.Framework;
using Polyjuice.Potions;
using Polyjuice.Tests.Models;
using static Polyjuice.Tests.TestHelper;

namespace Polyjuice.Tests
{
    public class Performance
    {
        [SetUp]
        public void Setup()
        {
            SetupAddressFromFile();
            SetupAddressFromStaticFile();
        }    
        
        private void SetupAddressFromFile()
        {
            Ergo<PersonAddress>.Current[nameof(PersonAddress)] = new PersonAddress
            {
                State = AddressNew.State,
                StateAbbr = AddressNew.StateAbbr,
                ZipCode = AddressNew.ZipCode,
                BuildingNumber = AddressNew.BuildingNumber,
                Location = AddressNew.Location,
                StreetName = AddressNew.StreetName,
                City = AddressNew.City,
                Country = Country.Name,
                CountryCode = Country.Code,
                Latitude = Geolocation.Latitude,
                Longitude = Geolocation.Latitude
            };
        }
        
        private void SetupAddressFromStaticFile()
        {
            Ergo<PersonAddress>.Current[nameof(PersonAddress)] = new PersonAddress
            {
                State = Address.State,
                StateAbbr = Address.StateAbbr,
                ZipCode = Address.ZipCode,
                BuildingNumber = Address.BuildingNumber,
                Location = Address.Location,
                StreetName = Address.StreetName,
                City = Address.City,
                Country = Country.Name,
                CountryCode = Country.Code,
                Latitude = Geolocation.Latitude,
                Longitude = Geolocation.Latitude
            };
        }        
        
        [Test]
        public void Test()
        {
            Stopwatch stopWatch1 = new Stopwatch();
            Stopwatch stopWatch2 = new Stopwatch();
            
            stopWatch1.Start();
            SetupAddressFromFile();
            stopWatch1.Stop();
            
            stopWatch2.Start();
            SetupAddressFromStaticFile();
            stopWatch2.Stop();
            
            Console.WriteLine(stopWatch1.ElapsedMilliseconds);
            Console.WriteLine(stopWatch2.ElapsedMilliseconds);
            
            Assert.LessOrEqual(stopWatch1.ElapsedMilliseconds, stopWatch2.ElapsedMilliseconds);

        }     

    }
}