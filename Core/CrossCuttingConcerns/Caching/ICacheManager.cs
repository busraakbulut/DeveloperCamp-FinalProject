using System;
using System.Collections.Generic;
using System.Text;

namespace Core.CrossCuttingConcerns.Caching
{
    public interface ICacheManager
    { // daha önce yapılmış işlemleri direkt cacheden çağırıp veritabanına gitmiyoruz.
        T Get<T>(string key) ;
        object Get(string key);
        void Add(string key, object value, int duration);
        bool IsAdd(string key);
        void Remove(string key);
        void RemoveByPattern(string pattern);
    }
}
