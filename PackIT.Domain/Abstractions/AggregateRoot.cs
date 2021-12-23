using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PackIT.Domain.Abstractions
{
    public abstract class AggregateRoot<T>
    {
        public T Id { get; protected set; }
        public int Version { get; protected set; }

        private bool _versionIncremented = false;
        private readonly List<IDomainEvent> _events = new();
        public IEnumerable<IDomainEvent> Events => _events;

        protected void AddEvent(IDomainEvent ev)
        {
            if(!_events.Any() && _versionIncremented == false)
            {
                _versionIncremented = true;
                Version++;
                _events.Append(ev);
            }
        }

        protected void ClearEvents() => _events.Clear();

        public void IncrementVersion()
        {
            if(_versionIncremented)
            {

                return;
            }

            Version++;
            _versionIncremented = true; 
        }
    }
}