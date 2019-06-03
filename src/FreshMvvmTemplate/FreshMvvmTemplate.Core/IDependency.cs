using System;
using System.Collections.Generic;
using System.Text;

namespace FreshMvvmTemplate.Core
{
    public interface IDependency
    {
        void RegisterInterface<I, T>() where T : class, I
                                   where I : class;
    }
}
