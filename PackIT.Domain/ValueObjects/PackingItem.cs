using PackIT.Domain.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PackIT.Domain.ValueObjects
{
    public record PackingItem
    {
        public string Name { get; }
        public ushort Quantity { get; }
        public bool IsPacked { get; init; }

        public PackingItem(string name, ushort quantity, bool isPacked)
        {
            if (String.IsNullOrEmpty(name))
            {
                throw new EmptyPackingItemNameException();
            }
            Name = name;
            Quantity = quantity;    
            IsPacked = isPacked;
        }
    }
}
