using MonkeyCache;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FreshMvvmTemplate.Core.Data.Cache
{
    public interface ICache
    {
        Task<T> Get<T>(string key);
        Task<bool> Save<T>(string key, T data, int expiryInMinutes);
        void DeleteAll();
        void Delete(List<string> key);
        void DeleteAllExpired();
        Task<bool> IsExpired(string key);
        Task<IEnumerable<string>> GetKeys(CacheState state = CacheState.Active);
        Task<bool> KeyExists(string key);
    }
}
