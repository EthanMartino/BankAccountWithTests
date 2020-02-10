using Microsoft.VisualStudio.TestTools.UnitTesting;
using BankAccountWithTests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountWithTests.Tests
{
    [TestClass()]
    public class BankAccountTests
    {
        [DataRow("123")]
        [DataRow("A")]
        [DataRow("1234567890")]
        [DataRow("A1B2C3")]
        [DataRow("A1!B2@C3#")]
        [DataRow("😁")]
        [TestMethod()]
        public void Constructor_ValidAccountNum_SetsAccountNumber(string accNum)
        {
            // Arrange => Act
            BankAccount acc = new BankAccount(accNum);

            // Assert
            Assert.AreEqual(accNum, acc.AccountNumber);
        }

        [DataRow("")]
        [DataRow(" ")]
        [DataRow(null)]
        [TestMethod()]
        public void Constructor_InvalidAccountNum_ThrowsArgumentException(string accNum)
        {
            // Arrange => Act => Assert
            Assert.ThrowsException<ArgumentException>( () => new BankAccount(accNum) );
          //Assert                                     Act   Arrange         
        }

        [TestMethod()]
        public void Deposit_PositiveValue_AddsToBalance()
        {
            // Arrange - Get Objects/Variables set up
            BankAccount acc = new BankAccount("123456");
            double depositAmount = 100.00;
            double initialBalance = 0.00;
            double expectedBalance = initialBalance + depositAmount;

            // Act - Call the method under test (Deposit() in this case)
            acc.Deposit(depositAmount);

            // Assert - Check for appropriate results
            Assert.AreEqual(expectedBalance, acc.Balance);
        }

        [TestMethod()]
        public void Deposit_PositiveAmountWithCents_AddsToBalance()
        {
            // Arrange
            BankAccount acc = new BankAccount("12345");
            double depositAmount = 10.55;
            double expectedBalance = 10.55;

            // Act
            acc.Deposit(depositAmount);

            // Assert
            Assert.AreEqual(expectedBalance, acc.Balance);
        }

        [DataRow(100)]
        [DataRow(100.99)]
        [DataRow(0.01)]
        [DataRow(999999.99)]
        [TestMethod()]
        public void Deposit_PositiveAmount_ReturnsUpdatedBalance(double depositAmount)
        {
            // Arrange
            BankAccount acc = new BankAccount("1234");
            double initialBalance = 0.0;
            double expectedBalance = initialBalance + depositAmount;

            // Act
            double returnedBalance = acc.Deposit(depositAmount);

            // Assert
            Assert.AreEqual(expectedBalance, returnedBalance);
            Assert.AreEqual(expectedBalance, acc.Balance);
        }

        [DataRow(0)]
        [DataRow(-10000.01)]
        [DataRow(-.01)]
        [TestMethod()]
        public void Deposit_NegativeAmount_ThrowsArgumentException(double depositAmount)
        {
            // Arrange
            BankAccount acc = new BankAccount("1234");

            // Act => Assert
            Assert.ThrowsException<ArgumentOutOfRangeException>( () => acc.Deposit(depositAmount) );
        }
    }
}