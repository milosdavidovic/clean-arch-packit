using PackIT.Domain.Abstractions;
using PackIT.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PackIT.Domain.Events
{
    internal record PackingItemAddedEvent(PackingList list, PackingItem item): IDomainEvent
    {

    }
}
