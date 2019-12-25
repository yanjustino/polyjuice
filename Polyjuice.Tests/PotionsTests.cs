using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using NUnit.Framework;
using Polyjuice.Potions;
using Polyjuice.Tests.Models;
using static Polyjuice.Tests.TestHelper;

namespace Polyjuice.Tests
{
    public class PotionsTests
    {
        [SetUp]
        public void Setup()
        {
            Ergo<PersonConference>.Current[typeof(PersonConference), "default"] = new PersonConference
            {
                Language = Locale.Language,
                LanguageCode = Locale.LanguageCode,
                Title = Conference.Title
            };            
            
            Ergo<List<PersonProduct>>.Current[nameof(PersonProduct)] = new List<PersonProduct>
            {
                new PersonProduct {Name = Product.Name, Price = Price.Value},
                new PersonProduct {Name = Product.Name, Price = Price.Value},
                new PersonProduct {Name = Product.Name, Price = Price.Value},
                new PersonProduct {Name = Product.Name, Price = Price.Value},
                new PersonProduct {Name = Product.Name, Price = Price.Value},
            };
            
            Ergo<PersonJob>.Current[nameof(PersonJob)] = new PersonJob
            {
                JobTitle = Job.Title,
                Company = Company.CompanyName
            };            
            
            Ergo<Person>.Current[nameof(Person)] = new Person
            {
                FirstName = Name.FirstName,
                LastName = Name.LastName,
                FullName = Name.FullName ,
                NameWithPrefix = Name.NameWithPrefix,
                Gender = Gender.Random,
                Birthday = DateAndTime.Birthday 
            };
            
            Ergo<PersonContacts>.Current[nameof(PersonContacts)] = new PersonContacts
            {
                Email = Internet.Email("admin"),
                Website = Internet.Uri("http"),
                WebsiteIp = Internet.IpV4,
                HomePhone = Phone.Number,
                CellPhone = Phone.ShortPhoneNumber
            };    
            
            Ergo<PersonBankAccount>.Current[nameof(PersonBankAccount)] = new PersonBankAccount
            {
                CardNumber = Bank.CardNumber,
                CardExpiryDate = Bank.CardExpiryDate,
                CardType = Bank.CardType,
                Iban = Bank.Iban()
            };             
            
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
            
            Ergo<PersonId>.Current[nameof(PersonId)] = new PersonId
            {
                DriversLicense = Identification.DriversLicense,
                Ssn = Identification.Ssn,
                Ethnicity = Identification.Ethnicity
            };   
            
            Ergo<PersonVehicle>.Current[nameof(PersonVehicle)] = new PersonVehicle
            {
                Make = Vehicle.Make,
                Model = Vehicle.Model,
                Trim = Vehicle.Trim
            };             
        }

        [Test]
        public void TestPerson()
        {
            Match("\\w", Ergo<Person>.Current[nameof(Person)].FirstName);
            Match("\\w", Ergo<Person>.Current[nameof(Person)].LastName);
            Match("\\w\\s\\w", Ergo<Person>.Current[nameof(Person)].FullName);
            Match("(Mr.|Ms.\\s\\w*\\s\\w*)", Ergo<Person>.Current[nameof(Person)].NameWithPrefix);
            Match("(male|female|non-binary|agender|androgyne|bi-gender|pan-gender)", Ergo<Person>.Current[nameof(Person)].Gender);
            Console.WriteLine(Ergo<Person>.Current[nameof(Person)].Birthday);
        }
        
        [Test]
        public void TestPersonConference()
        {
            var conference = Ergo<PersonConference>.Current[typeof(PersonConference), "default"];
            
            Match("\\w", conference.Language);
            Match("\\w{2}", conference.LanguageCode);
            Match("(\\w*(\\s|.|,))", conference.Title);
        }   
        
        [Test]
        public void TestPersonJob()
        {
            Match("(\\w*(\\s|.|,))", Ergo<PersonJob>.Current[nameof(PersonJob)].Company);
            Match("(\\w*(\\s|.|,))", Ergo<PersonJob>.Current[nameof(PersonJob)].JobTitle);
        }  
        
        [Test]
        public void TestPersonContacts()
        {
            Match("(\\w*@\\w*.com)", Ergo<PersonContacts>.Current[nameof(PersonContacts)].Email);
            Match("((http:\\/\\/)\\w*.\\w{2,3}.\\w{0,3})", Ergo<PersonContacts>.Current[nameof(PersonContacts)].Website);
            Match("\\(\\d*\\){0,1}(\\d*-\\d*)*|(\\d*-\\d*)*", Ergo<PersonContacts>.Current[nameof(PersonContacts)].CellPhone);
            Match("\\(\\d*\\){0,1}(\\d*-\\d*)*|(\\d*-\\d*)*", Ergo<PersonContacts>.Current[nameof(PersonContacts)].HomePhone);
            Match("(\\d{1,3}\\.\\d{1,3}\\.\\d{1,3}\\.\\d{1,3})", Ergo<PersonContacts>.Current[nameof(PersonContacts)].WebsiteIp);
        }   
        
        [Test]
        public void TestPersonAddress()
        {
            Match("(\\w*(\\s|.|,))", Ergo<PersonAddress>.Current[nameof(PersonAddress)].City);
            Match("(\\w*(\\s|.|,))", Ergo<PersonAddress>.Current[nameof(PersonAddress)].Country);
            Match("(\\w*(\\s|.|,))", Ergo<PersonAddress>.Current[nameof(PersonAddress)].Location);
            Match("(\\w*(\\s|.|,))", Ergo<PersonAddress>.Current[nameof(PersonAddress)].State);
            Match("(\\w*(\\s|.|,))", Ergo<PersonAddress>.Current[nameof(PersonAddress)].BuildingNumber);
            Match("(\\w*(\\s|.|,))", Ergo<PersonAddress>.Current[nameof(PersonAddress)].CountryCode);
            Match("(\\w*(\\s|.|,))", Ergo<PersonAddress>.Current[nameof(PersonAddress)].StateAbbr);
            Match("(\\w*(\\s|.|,))", Ergo<PersonAddress>.Current[nameof(PersonAddress)].StreetName);
            Match("(\\w*(\\s|.|,))", Ergo<PersonAddress>.Current[nameof(PersonAddress)].ZipCode);
            Match("(\\w*(\\s|.|,))", Ergo<PersonAddress>.Current[nameof(PersonAddress)].Latitude.ToString());
            Match("(\\w*(\\s|.|,))", Ergo<PersonAddress>.Current[nameof(PersonAddress)].Longitude.ToString());
        }     
        
        [Test]
        public void TestPersonId()
        {
            Match("((\\d*-)\\d*)", Ergo<PersonId>.Current[nameof(PersonId)].Ssn);
            Match("((\\d*-)\\d*)", Ergo<PersonId>.Current[nameof(PersonId)].DriversLicense);
            Match("(\\w*(\\s|.|,))", Ergo<PersonId>.Current[nameof(PersonId)].Ethnicity);
        }  
        
        [Test]
        public void TestPersonVehicle()
        {
            Match("(\\w*(\\s|.|,))", Ergo<PersonVehicle>.Current[nameof(PersonVehicle)].Make);
            Match("(\\w*(\\s|.|,))", Ergo<PersonVehicle>.Current[nameof(PersonVehicle)].Model);
            Match("(\\w*(\\s|.|,))", Ergo<PersonVehicle>.Current[nameof(PersonVehicle)].Trim);        
        }         
        
        [Test]
        public void TestPersonProduct()
        {
            var products = Ergo<List<PersonProduct>>.Current[nameof(PersonProduct)];

            foreach (var product in products)
            {
                Match("(\\w*(\\s|.|,))", product.Name);
                Assert.Greater(product.Price, 0);
            }
        }               
    }
}