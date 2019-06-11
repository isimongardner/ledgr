using System;

namespace Ledgr.Entities
{
    public class Debit
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Created { get; set; }
        public decimal Amount { get; set; }
        public int RecurringDay { get; set; }
        public Guid Identifier { get; set; }
    }
}