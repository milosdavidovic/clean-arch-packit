using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PackIT.Domain.Exceptions
{
    internal class EmptyGuidException : PackItException
    {
        public EmptyGuidException() : base("Guid must not be empty")
        {
        }
    }
}
