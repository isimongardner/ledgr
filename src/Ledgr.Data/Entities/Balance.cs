using System;

namespace Ledgr.Entities
{
    public class Balance
    {
        public int Id { get; set; }
        public Account Account { get; set; }
        public DateTime Created { get; set; }
        public Guid Identifier { get; set; }
        public decimal Amount { get; set; }
    }
}