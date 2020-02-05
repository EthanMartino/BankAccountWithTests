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
        [TestMethod()]
        public void Deposit_PositiveValue_AddsToBalance()
        {
            // Arrange - Get Objects/Variables set up
            BankAccount acc = new BankAccount("123456");
            double depositAmount = 100.00;
            double initialBalance = 0.00;
            double expectedBalance = 100.00;

            // Act - Call the method under test (Deposit() in this case)
            acc.Deposit(depositAmount);

            // Assert - Check for appropriate results
            Assert.AreEqual(expectedBalance, acc.Balance);
        }
    }
}