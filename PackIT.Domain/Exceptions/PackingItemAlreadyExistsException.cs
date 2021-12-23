using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PackIT.Domain.Exceptions
{
    internal class PackingItemAlreadyExistsException : PackItException
    {
        public PackingItemAlreadyExistsException(string listName, string itemName) 
            : base($"Item with name {itemName} and already exists in the list {listName}")
        {
        }
    }
}
