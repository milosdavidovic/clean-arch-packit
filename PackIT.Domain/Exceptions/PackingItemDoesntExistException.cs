using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PackIT.Domain.Exceptions
{
    internal class PackingItemDoesntExistException : PackItException
    {
        public PackingItemDoesntExistException() : base("Packing item not found")
        {
        }
    }
}
