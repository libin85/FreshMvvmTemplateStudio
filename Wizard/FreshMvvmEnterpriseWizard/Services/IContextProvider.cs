using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreshMvvmEnterpriseWizard.Services
{
    public interface IContextProvider
    {
        string ProjectName { get; }

        string SafeProjectName { get; }

        string GenerationOutputPath { get; }

        string DestinationPath { get; }

        List<string> FilesToOpen { get; }
    }
}
