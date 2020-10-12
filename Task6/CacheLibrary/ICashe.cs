using System;

namespace CacheLibrary
{
   public interface ICache<TKey, TValue>
    where TKey : struct
    where TValue : class
    {
        // Adds an item with specified key and value to the cache.
        // Updates the item value and expiresOn date if the item with the key already exists in cache.
        void AddOrUpdate(TKey key, TValue value, DateTime expiresOn);


        // Returns the value associated with the specified key.
        // Returns null if DateTime.Now less than expiresOn date.
        // Returns null if there is no value associated with the specified key.
        TValue Get(TKey key);

        // Removes the value with the specified key from the cache.
        // Returns true if the value with the specified key is removed.
        // Returns false if there is no value associated with the specified key.
        bool Remove(TKey key);
    }
}
