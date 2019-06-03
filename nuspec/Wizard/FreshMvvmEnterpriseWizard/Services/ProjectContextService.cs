using FreshMvvmEnterpriseWizard.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreshMvvmEnterpriseWizard.Core
{
    public class ProjectContextService
    {
        private static IContextProvider _currentContext;
        public static IContextProvider Current
        {
            get
            {
                if (_currentContext == null)
                {
                    throw new InvalidOperationException("Unable to get the current Visual Studio context. Cannot proceed further.");
                }
                return _currentContext;
            }
            set
            {
                _currentContext = value;
            }
        }
    }
}
