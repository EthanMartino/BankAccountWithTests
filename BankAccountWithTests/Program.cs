﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountWithTests
{
    class Program
    {
        static void Main(string[] args)
        {
            var acc = new BankAccount("12345");
            double balance = acc.Deposit(2);
        }
    }
}
