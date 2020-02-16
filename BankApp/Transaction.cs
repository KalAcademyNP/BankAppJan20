﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BankApp
{
    enum TypeOfTransaction
    {
        Credit,
        Debit
    }
    class Transaction
    {
        public int TransactionId { get; set; }
        public DateTime TransactionDate { get; set; }
        public string Description { get; set; }

        public TypeOfTransaction TransactionType { get; set; }
        public decimal Amount { get; set; }

        public int AccountNumber { get; set; }
        public Account Account { get; set; }

    }
}
