using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using FreshMvvmTemplate.Core.Logging;
using MonkeyCache;
using MonkeyCache.FileStore;
using Splat;

namespace FreshMvvmTemplate.Core.Data.Cache
{
    public class MonkeyCacheInstance : ICache
    {
        private readonly ReaderWriterLockSlim _indexLocker;
        private readonly Logging.ILogger _logger;

        /// <summary>
        /// Contructor
        /// </summary>
        public MonkeyCacheInstance()
        {
            _indexLocker = new ReaderWriterLockSlim();
            _logger = Locator.Current.GetService<Logging.ILogger>();
        }

        /// <summary>
        /// Initialise Monkey Cache instance.
        /// </summary>
        public static void Init()
        {
            Barrel.ApplicationId = "FreshMvvmTemplateCache";
        }

        /// <summary>
        /// Delete a record from the cache with the corresponding key.
        /// </summary>
        /// <param name="keys"></param>
        public void Delete(List<string> keys)
        {
            _indexLocker.EnterWriteLock();
            try
            {
                foreach (var key in keys)
                {
                    Barrel.Current.Empty(key);
                }
            }
            catch(Exception ex)
            {
                _logger?.Exception(ex, "Delete cache failed");
            }
            finally
            {
                _indexLocker.ExitWriteLock();
            }
            
        }

        /// <summary>
        /// Deletes all records from cache.
        /// </summary>
        public void DeleteAll()
        {
            _indexLocker.EnterWriteLock();
            try
            {
                Barrel.Current.EmptyAll();
            }
            catch(Exception ex)
            {
                _logger?.Exception(ex, "Delete all cache failed");
            }
            finally
            {
                _indexLocker.ExitWriteLock();
            }
            
        }

        /// <summary>
        /// Deletes all records from cache that are expired.
        /// </summary>
        public void DeleteAllExpired()
        {
            _indexLocker.EnterWriteLock();
            try
            {
                Barrel.Current.EmptyExpired();
            }
            catch(Exception ex)
            {
                _logger?.Exception(ex, "Delete all expired cache failed");
            }
            finally
            {
                _indexLocker.ExitWriteLock();
            }
        }

        /// <summary>
        /// Gets the record from cache with the give key.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="key"></param>
        /// <returns></returns>
        public Task<T> Get<T>(string key)
        {
            if (string.IsNullOrWhiteSpace(key))
                return Task.FromResult(default(T));

            _indexLocker.EnterReadLock();
            try
            {
                var result = Barrel.Current.Get<T>(key);
                return Task.FromResult<T>(result);
            }
            catch (Exception ex)
            {
                _logger?.Exception(ex, "get cached record failed");
                return Task.FromResult(default(T));
            }
            finally
            {
                _indexLocker.ExitReadLock();
            }
            
        }

        /// <summary>
        /// Gets all the key from cache with the given state.
        /// </summary>
        /// <param name="state"></param>
        /// <returns></returns>
        public Task<IEnumerable<string>> GetKeys(CacheState state = CacheState.Active)
        {
            _indexLocker.EnterReadLock();
            try
            {
                var result = Barrel.Current.GetKeys(state);
                return Task.FromResult<IEnumerable<string>>(result);
            }
            catch (Exception ex)
            {
                _logger?.Exception(ex, "Delete cache keys failed");
                return Task.FromResult(default(IEnumerable<string>));
            }
            finally
            {
                _indexLocker.ExitReadLock();
            }
        }

        /// <summary>
        /// Checks if the record with the given key has expired or not.
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public Task<bool> IsExpired(string key)
        {
            if (string.IsNullOrWhiteSpace(key))
                return Task.FromResult(false);

            _indexLocker.EnterReadLock();
            try
            {
                var result = Barrel.Current.IsExpired(key);
                return Task.FromResult<bool>(result);
            }
            catch(Exception ex)
            {
                _logger?.Exception(ex, "Failed to read if cached key has expired");
                return Task.FromResult(false);
            }
            finally
            {
                _indexLocker.ExitReadLock();
            } 
        }

        /// <summary>
        /// Checks if there is a record wit the given key.
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public Task<bool> KeyExists(string key)
        {
            if (string.IsNullOrWhiteSpace(key))
                return Task.FromResult(false);

            _indexLocker.EnterReadLock();
            try
            {
                var result = Barrel.Current.Exists(key);
                return Task.FromResult<bool>(result);
            }
            catch (Exception ex)
            {
                _logger?.Exception(ex, "Failed to check if cache key exists");
                return Task.FromResult(false);
            }
            finally
            {
                _indexLocker.ExitReadLock();
            }
            
        }

        /// <summary>
        /// Saves a record with in the cache with given key and timespan
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="key"></param>
        /// <param name="data"></param>
        /// <param name="expiryInMinutes"></param>
        /// <returns></returns>
        public Task<bool> Save<T>(string key, T data, int expiryInMinutes = 15)
        {
            _indexLocker.EnterWriteLock();
            try
            {
                if (string.IsNullOrWhiteSpace(key))
                    return Task.FromResult<bool>(false);

                if (data == null)
                    return Task.FromResult<bool>(false);

                Barrel.Current.Add(key, data, TimeSpan.FromMinutes(expiryInMinutes));
                return Task.FromResult<bool>(true);
            }
            catch (Exception ex)
            {
                _logger?.Exception(ex, "Failed to save data to the cache.");
                return Task.FromResult<bool>(false);
            }
            finally
            {
                _indexLocker.ExitWriteLock();
            }
        }
    }
}
