#if (Caching == monkeycachesqlite)
using FreshMvvmTemplate.Core.Data.Cache;
#endif
using System;

namespace FreshMvvmTemplate.Core.Services
{
    public class BaseService : IDisposable
    {
    #if (Caching == monkeycachesqlite)
        private readonly ICache _cache;
    #endif

    #if (Caching == monkeycachesqlite)
        public BaseService(ICache cache)
        {
           _cache = cache;
        }
    #endif
        public BaseService()
        {
        }
        //TODO Proper implementation 
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        protected virtual void Dispose(bool disposing)
        {
        }

        ~BaseService()
        {
            Dispose(false);
        }
    }
}
