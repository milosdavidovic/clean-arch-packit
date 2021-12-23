using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PackIT.Domain.Exceptions
{
    internal class EmptyPackingItemNameException : PackItException
    {
        public EmptyPackingItemNameException() : base("name cant be empty")
        {
        }
    }
}
