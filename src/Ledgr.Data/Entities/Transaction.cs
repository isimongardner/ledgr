using System;
using Ledgr.Types;

namespace Ledgr.Entities
{
    public class Transaction
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public TransactionType Type { get; set; }
        public DateTime Created { get; set; }
        public decimal Amount { get; set; }
        public Account Account { get; set; }
        public Guid Identifier { get; set; }
    }
}