using System;

namespace Polyjuice.Tests.Models
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName { get; set; }
        public string NameWithPrefix { get; set; }
        public string Gender { get; set; }
        public DateTime Birthday { get; set; }
    }

    public class PersonConference
    {
        public string Language { get; set; }
        public string LanguageCode { get; set; }
        public string Title { get; set; }
    }
    
    public class PersonProduct
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
    }    
    
    public class PersonJob
    {
        public string JobTitle { get; set; }
        public string Company { get; set; }
    }    

    public class PersonContacts
    {
        public string Email { get; set; }
        public string Website { get; set; }
        public string WebsiteIp { get; set; }
        public string HomePhone { get; set; }
        public string CellPhone { get; set; }
    }

    public class PersonBankAccount
    {
        public string CardNumber { get; set; }
        public string CardExpiryDate { get; set; }
        public string CardType { get; set; }
        public string Iban { get; set; }
    }

    public class PersonAddress
    {
        public string State { get; set; }
        public string StateAbbr { get; set; }
        public string ZipCode { get; set; }
        public string BuildingNumber { get; set; }
        public string Location { get; set; }
        public string StreetName { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string CountryCode { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }        
    }

    public class PersonId
    {
        public string DriversLicense { get; set; }
        public string Ssn { get; set; }
        public string Ethnicity { get; set; }
    }
    
    public class PersonVehicle
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public string Trim { get; set; }
    }    
}