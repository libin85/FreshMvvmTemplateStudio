using FreshMvvmEnterpriseWizard.Core;
using FreshMvvmEnterpriseWizard.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace FreshMvvmEnterpriseWizard.PageModels
{
    public class BasePageModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public string ProjectTitle { get; set; }

        protected void RaisePropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public  virtual void Init(object initData)
        {
            ProjectTitle = ProjectContextService.Current.ProjectName;
            RaisePropertyChanged(nameof(ProjectTitle));
        }
    }
}
