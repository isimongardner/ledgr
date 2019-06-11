using System;

namespace Ledgr.Entities
{
    public class Agreement
    {
        public int Id { get; set; }
        public Account Account { get; set; }
        public Debit Debit { get; set; }
        public DateTime Created { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
        public Guid Identifier { get; set; }
    }
}
