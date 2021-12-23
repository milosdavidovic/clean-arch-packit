using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PackIT.Domain.Exceptions
{
    internal class EmptyPackingListNameException : PackItException
    {
        public EmptyPackingListNameException() : base("Packing name is empty")
        {
        }
    }
}
