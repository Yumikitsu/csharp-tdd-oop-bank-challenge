﻿using Boolean.CSharp.Main.BankAndAccounts;
using Boolean.CSharp.Main.Branches;
using Boolean.CSharp.Main.Customers;
using NUnit.Framework;

/*
## User Stories

```
As a customer,
So I can safely store use my money,
I want to create a current account.

As a customer,
So I can save for a rainy day,
I want to create a savings account.

As a customer,
So I can keep a record of my finances,
I want to generate bank statements with transaction dates, amounts, and balance at the time of transaction.

As a customer,
So I can use my account,
I want to deposit and withdraw funds.
```
*/

namespace Boolean.CSharp.Test
{
    public class CoreTests
    {
        [Test]
        public void CreateCurrentAccountTest()
        {
            //Arrange
            Bank bank = new Bank();
            Joaquin joaquin = new Joaquin();
            MasterCard mastercard = new MasterCard();

            //Act
            bool result = bank.CreateCurrent(joaquin, mastercard);
            bool duplicate = bank.CreateCurrent(joaquin, mastercard);

            //Assert
            Assert.That(result, Is.True);
            Assert.That(duplicate, Is.False);
        }

        [Test]
        public void CreateSavingAccountTest()
        {
            //Arrange
            Bank bank = new Bank();
            Joaquin joaquin = new Joaquin();
            MasterCard mastercard = new MasterCard();

            //Act
            bool result = bank.CreateSaving(joaquin, mastercard);
            bool duplicate = bank.CreateSaving(joaquin, mastercard);

            //Assert
            Assert.That(result, Is.True);
            Assert.That(duplicate, Is.False);
        }

    }
}