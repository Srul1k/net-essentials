using System;
using System.Collections.Generic;

namespace CacheLibrary
{
    public class Cashe<TKey, TValue> : ICache<TKey, TValue> 
        where TKey : struct 
        where TValue : class
    {
        private struct CasheItem
        {
            public TKey Key { get; set; }
            public TValue Value { get; set; }
            public DateTime ExpiresOn { get; set; }

            public CasheItem(TKey key, TValue value, DateTime expiresOn)
            {
                Key = key;
                Value = value;
                ExpiresOn = expiresOn;
            }
        }

        private List<CasheItem> items;

        public Cashe() { items = new List<CasheItem>(); }

        public void AddOrUpdate(TKey key, TValue value, DateTime expiresOn)
        {
            foreach (var item in items)
            {
                if (item.Key.Equals(key))
                {
                    items.Remove(item);
                }
            }
            
            items.Add(new CasheItem(key, value, expiresOn));
        }

        public TValue Get(TKey key)
        {
            foreach (var item in items)
            {
                if (item.Key.Equals(key))
                {
                    return item.ExpiresOn > DateTime.Now ? item.Value : null;
                }
            }

            return null;
        }

        public bool Remove(TKey key)
        {
            foreach (var item in items)
            {
                if (item.Key.Equals(key))
                {
                    items.Remove(item);
                    return true;
                }
            }

            return false;
        }
    }
}
