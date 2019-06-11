using Ledgr.Types;
using System;

namespace Ledgr.Entities
{
    public class Account
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public AccountType Type { get; set; }
        public DateTime Created { get; set; }
        public Guid Identifier { get; set; }
    }
}