using Ledgr.Types;
using System;
using System.Collections.Generic;


namespace Ledgr.Entities
{
    public class Ledger
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public LedgerType Type { get; set; }
        public DateTime Created { get; set; }
        public Guid Identifier { get; set; }
        public virtual ICollection<Transaction> Transactions { get; set; }
    }
}
