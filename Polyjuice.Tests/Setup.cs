using System.Collections.Generic;
using Polyjuice.Potions;
using Polyjuice.Tests.Models;

namespace Polyjuice.Tests
{
    internal static class PersonSetup
    {
        public static void Start()
        {
            SetupJob();            
            SetupPerson();
            SetupContacts();    
            SetupConference();            
            SetupPersonProduct();
            SetupAccountBank();             
            SetupAddress();      
            SetupIdentification();   
            SetupVehicle();              
        }

        private static void SetupVehicle()
        {
            Ergo<PersonVehicle>.Current[nameof(PersonVehicle)] = new PersonVehicle
            {
                Make = Vehicle.Make,
                Model = Vehicle.Model,
                Trim = Vehicle.Trim
            };
        }

        private static void SetupIdentification()
        {
            Ergo<PersonId>.Current[nameof(PersonId)] = new PersonId
            {
                DriversLicense = Identification.DriversLicense,
                Ssn = Identification.Ssn,
                Ethnicity = Identification.Ethnicity
            };
        }

        private static void SetupAddress()
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

        private static void SetupAccountBank()
        {
            Ergo<PersonBankAccount>.Current[nameof(PersonBankAccount)] = new PersonBankAccount
            {
                CardNumber = Bank.CardNumber,
                CardExpiryDate = Bank.CardExpiryDate,
                CardType = Bank.CardType,
                Iban = Bank.Iban()
            };
        }

        private static void SetupContacts()
        {
            Ergo<PersonContacts>.Current[nameof(PersonContacts)] = new PersonContacts
            {
                Email = Internet.Email("admin"),
                Website = Internet.Uri("http"),
                WebsiteIp = Internet.IpV4,
                HomePhone = Phone.Number,
                CellPhone = Phone.ShortPhoneNumber
            };
        }

        private static void SetupPerson()
        {
            Ergo<Person>.Current.SetDefault(new Person
            {
                FirstName = Name.FirstName,
                LastName = Name.LastName,
                FullName = Name.FullName,
                NameWithPrefix = Name.NameWithPrefix,
                Gender = Gender.Random,
                Birthday = DateAndTime.Birthday
            });
        }

        private static void SetupJob()
        {
            Ergo<PersonJob>.Current[nameof(PersonJob)] = new PersonJob
            {
                JobTitle = Job.Title,
                Company = Company.CompanyName
            };
        }

        private static void SetupPersonProduct()
        {
            Ergo<List<PersonProduct>>.Current[nameof(PersonProduct)] = new List<PersonProduct>
            {
                new PersonProduct {Name = Product.Name, Price = Price.Value},
                new PersonProduct {Name = Product.Name, Price = Price.Value},
                new PersonProduct {Name = Product.Name, Price = Price.Value},
                new PersonProduct {Name = Product.Name, Price = Price.Value},
                new PersonProduct {Name = Product.Name, Price = Price.Value},
            };
        }

        private static void SetupConference()
        {
            Ergo<PersonConference>.Current[nameof(PersonConference)] = new PersonConference
            {
                Language = Locale.Language,
                LanguageCode = Locale.LanguageCode,
                Title = Conference.Title
            };
        }
        
    }
}