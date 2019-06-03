using FreshMvvm;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FreshMvvmTemplate.Proxies
{
    public class Dependency
    {
        public void RegisterInterface<I, T>() where T : class, I
                                                           where I : class
        {
            FreshIOC.Container.Register<I, T>();
        }

        public Task<T> ResolveInterface<I, T>() where T : class, I
                                                           where I : class
        {
           var implemntedClass = FreshIOC.Container.Resolve<I>() as T;
            return Task.FromResult<T>(implemntedClass);
        }
    }
}
