using PackIT.Domain.Abstractions;

namespace PackIT.Domain.Events
{
    public class ItemPackedEvent : IDomainEvent
    {
        private PackingList packingList;
        private string itemName;

        public ItemPackedEvent(PackingList packingList, string itemName)
        {
            this.packingList = packingList;
            this.itemName = itemName;
        }
    }
}