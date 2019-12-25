![](https://github.com/emergingcode/polyjuice/blob/master/docs/logo.png)

# Polyjuice
It's amazing library to improve your stubs tests. Based on FFaker, a great Ruby test tool, Polyjuice bring the same experiênce to **C# developers**. Also, [Polyjuice is a "dotnet-core" modernization of 'Fact' library](https://github.com/ycodeteam/fact).

## Install
Polyjuice is avaliable on [Nuget](https://www.nuget.org/packages/Polyjuice). NuGet is the package manager for .NET. The NuGet client tools provide the ability to produce and consume packages. The NuGet Gallery is the central package repository used by all package authors and consumers. To install use the options bellow:


```shell
# Package Manager
> Install-Package Polyjuice -Version 1.0.1
```

```shell
# Package Manager
> dotnet add package Polyjuice --version 1.0.1
```

```xml
<!-- *.cproj file -->
<PackageReference Include="Polyjuice" Version="1.0.1" />
```


## Using Polyjuice Fakers
The fakers are little [potions](./Polyjuice/Potions) that provides values to objects attributes. You can use Fakers to build `Address`, `Bank`, `Company`, `Conference`, `Country`, `DateAndTime`, `Gender`, `Geolocation`, `Identification`, `Internet`, `Job`, `Locale`, `Name`, `Phone`, `Price`, `Product` and `Vehicle` attributes. The code 1 shown how use the fakers on models

.
.
```csharp

var person = new Person
{
    FirstName = Name.FirstName,
    LastName = Name.LastName,
    FullName = Name.FullName ,
    NameWithPrefix = Name.NameWithPrefix,
    Gender = Gender.Random,
    Birthday = DateAndTime.Birthday 
};


var account = new BankAccount
{
    CardNumber = Bank.CardNumber,
    CardExpiryDate = Bank.CardExpiryDate,
    CardType = Bank.CardType,
    Iban = Bank.Iban()
};   
```
> **code 1 - using fakers on models**
