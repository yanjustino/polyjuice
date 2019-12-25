![](https://github.com/emergingcode/polyjuice/blob/master/docs/logo.png)

# Status
![](https://travis-ci.com/emergingcode/polyjuice.svg?branch=master)


# Polyjuice
It's amazing library to improve your stubs tests. Based on FFaker, a great Ruby test tool, Polyjuice bring the same experiênce to **C# developers**. Also, [Polyjuice is a "dotnet-core" modernization of 'Fact' library](https://github.com/ycodeteam/fact).

## Install
[NuGet](https://www.nuget.org/packages/Polyjuice/)

Polyjuice is avaliable on [Nuget](https://www.nuget.org/packages/Polyjuice). NuGet is the package manager for .NET. The NuGet client tools provide the ability to produce and consume packages. The NuGet Gallery is the central package repository used by all package authors and consumers. To install use the options bellow:


```shell
# Package Manager
> Install-Package Polyjuice
```

```shell
# Package Manager
> dotnet add package Polyjuice
```

```xml
<!-- *.cproj file -->
<PackageReference Include="Polyjuice" Version="{VERSION}" />
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

## Using Ergon
Ergon is an amazing feature of Polyjuice. With Ergon you can register your stubs and use then when necessary. See how use Ergon bellow:

### Ergon with default model
Describes a default stub model.
```csharp

/// Setup
Ergo<Person>.Current.SetDefault(new Person
{
    FirstName = Name.FirstName,
    LastName = Name.LastName,
    FullName = Name.FullName ,
    NameWithPrefix = Name.NameWithPrefix,
    Gender = Gender.Random,
    Birthday = DateAndTime.Birthday 
});

[Test]
public void TestPersonA()
{
    var person = Ergo<Person>.Current.GetDefault()
    ...
}

[Test]
public void TestPersonB()
{
    var person = Ergo<Person>.Current.GetDefault()
    ...
}

```


### Ergon with context
Describes a contextualized stub model.

```csharp

/// Setup
Ergo<Person>.Current["Regular Customer"] = new Person
{
    FirstName = Name.FirstName,
    LastName = Name.LastName,
    FullName = Name.FullName ,
    NameWithPrefix = Name.NameWithPrefix,
    Gender = Gender.Random,
    Birthday = DateAndTime.Birthday 
};

[Test]
public void TestPersonA()
{
    var stub = Ergo<Person>.Current["Regular Customer"];
    ...
}

[Test]
public void TestPersonB()
{
    var stub = Ergo<Person>.Current["Regular Customer"];
    ...
}

```

# Guide to contributing to a GitHub project
This is a guide to contributing to this open source project that uses GitHub. It’s mostly based on how many open sorce projects operate. That’s all there is to it. The fundamentals are:

* Fork the project & clone locally.
* Create an upstream remote and sync your local copy before you branch.
* Branch for each separate piece of work.
* Do the work, write good commit messages, and read the CONTRIBUTING file if there is one.
* Push to your origin repository.
* Create a new PR in GitHub.
* Respond to any code review feedback.

If you want to contribute to an open source project, the best one to pick is one that you are using yourself. The maintainers will appreciate it!

## Locales Avaliables
Polyjuice is avaliable in PT-BR and Generic Values. New versions will bring more locale values. Help us!

# Roadmap



| Feature       | Date          | 
| ------------- |:-------------:|
| Ergo Sum      | 2020 - firstQ |
| More locales  | 2020          |

* Ergo Sum - It's a feature to auto fill Models.
* More locales - USA, 
