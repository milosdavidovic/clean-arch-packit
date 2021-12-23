using PackIT.Domain.Abstractions;
using PackIT.Domain.Events;
using PackIT.Domain.Exceptions;
using PackIT.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PackIT.Domain
{
    public class PackingList: AggregateRoot<PackingListId>
    {
        private PackingListName _name;
        private Localization _localization;
        private readonly LinkedList<PackingItem> _items = new();

        internal PackingList(PackingListId id, PackingListName name, Localization localization, LinkedList<PackingItem> items)
        {
            Id = id;
            _name = name;
            _localization = localization;
            _items = items;


        }

        public void AddItem(PackingItem item)
        {
            var alreadyExists = _items.Any(i => i.Name == item.Name);

            if (alreadyExists)
            {
                throw new PackingItemAlreadyExistsException(this._name, item.Name);
            }

            _items.AddLast(item);
            AddEvent(new PackingItemAddedEvent(this, item));
        }

        public void RemoveItem(string itemName )
        {
            var item = GetItem(itemName);

            _items.Remove(item);

            AddEvent(new ItemRemovedEvent(this, item));
        }

        public void AddItems(IEnumerable<PackingItem> items)
        {
            foreach (var item in items) 
            {
                AddItem(item);
            }
        }

        public void PackItem(string itemName)
        {
            var item = GetItem(itemName);
            var packedItem = item with { IsPacked = true };

            _items.Find(item).Value = packedItem;
            AddEvent(new ItemPackedEvent(this, itemName));
        }

        public PackingItem GetItem(string itemName)
        {
            var item = _items.SingleOrDefault(i => i.Name == itemName);

            if(item == null)
            {
                throw new PackingItemDoesntExistException();
            }

            return item;
        }

    }
}
