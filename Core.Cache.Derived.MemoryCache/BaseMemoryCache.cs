using Core.Cache.Infrastructure;
using Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Caching;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Core.Cache.Derived.MemoryCache
{
    public abstract class BaseMemoryCache : ICache
    {
        protected ObjectCache Cache
        {
            get
            {
                return System.Runtime.Caching.MemoryCache.Default;
            }
        }

        public T Get<T>(string key)
        {
            return (T)Cache[key];
        }

        public void Set(string key, object data, int cacheTime)
        {
            if (data == null)
                return;

            var policy = new CacheItemPolicy();
            policy.AbsoluteExpiration = DateTime.Now + TimeSpan.FromMinutes(cacheTime);
            Cache.Add(new CacheItem(key, data), policy);
        }


        public bool IsSet(string key)
        {
            return (Cache.Contains(key));
        }


        public void Remove(string key)
        {
            Cache.Remove(key);
        }


        public void RemoveByPattern(string pattern)
        {
            var regex = new Regex(pattern, RegexOptions.Singleline | RegexOptions.Compiled | RegexOptions.IgnoreCase);
            var keysToRemove = new List<String>();

            foreach (var item in Cache)
                if (regex.IsMatch(item.Key))
                    keysToRemove.Add(item.Key);

            foreach (string key in keysToRemove)
            {
                Remove(key);
            }
        }

        public void Clear()
        {
            foreach (var item in Cache)
                Remove(item.Key);
        }
    }
}
