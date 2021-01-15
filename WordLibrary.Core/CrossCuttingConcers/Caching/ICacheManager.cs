using System;
using System.Collections.Generic;
using System.Text;

namespace WordLibrary.Core.CrossCuttingConcers.Caching
{
    public interface ICacheManager
    {
        T Get<T>(string key);
        void Add(string key, object data, int cacheTime);
        bool IsAdd(string key);
        void Remove(string key);
        void RemoveBypattern(string pattern);
        void Clear();
    }
}
