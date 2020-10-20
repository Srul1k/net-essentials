using System;
using System.Collections.Generic;
using System.Linq;

namespace CacheLibrary
{
    public class Cashe<TKey, TValue> : ICache<TKey, TValue> 
        where TKey : struct 
        where TValue : class
    {
        private struct CasheItem
        {
            public TKey Key { get; }
            public TValue Value { get; }
            public DateTime ExpiresOn { get; }

            public CasheItem(TKey key, TValue value, DateTime expiresOn)
            {
                Key = key;
                Value = value;
                ExpiresOn = expiresOn;
            }
        }

        private List<CasheItem> items;

        public Cashe() => items = new List<CasheItem>();

        public void AddOrUpdate(TKey key, TValue value, DateTime expiresOn)
        {
            var selectedItem = items.FirstOrDefault(i => i.Key.Equals(key));
            if (selectedItem.Equals(null))
            {
                items.Remove(selectedItem);
            }
            
            items.Add(new CasheItem(key, value, expiresOn));
        }

        public TValue Get(TKey key)
        {
            var selectedItem = items.FirstOrDefault(i => i.Key.Equals(key));
            if (selectedItem.Equals(null))
            {
                return selectedItem.ExpiresOn > DateTime.Now ? selectedItem.Value : null;
            }

            return null;
        }

        public bool Remove(TKey key)
        {
            var selectedItem = items.FirstOrDefault(i => i.Key.Equals(key));
            if (selectedItem.Equals(null))
            {
                items.Remove(selectedItem);
                return true;
            }

            return false;
        }
    }
}
