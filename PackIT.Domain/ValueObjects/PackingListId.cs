using PackIT.Domain.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PackIT.Domain.ValueObjects
{
    public record PackingListId
    {
        public Guid Value { get; set; }

        public PackingListId(Guid id)
        {
            if(id == Guid.Empty)
            {
                throw new EmptyGuidException();
            }

            Value = id; 
        }

        public static implicit operator Guid(PackingListId value) => value.Value;

        public static implicit operator PackingListId(Guid name) => new(name);
    }
}
