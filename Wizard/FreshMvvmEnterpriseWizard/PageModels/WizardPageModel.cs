using FreshMvvmEnterpriseWizard.Models;
using FreshMvvmEnterpriseWizard.Mvvm;
using FreshMvvmEnterpriseWizard.Pages;
using FreshMvvmEnterpriseWizard.Services;
using FreshMvvmEnterpriseWizard.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace FreshMvvmEnterpriseWizard.PageModels
{
    public class WizardPageModel : BasePageModel
    {
        //pub Dictionary<string, string> replacementsDictionary
        public VisualStudioUIService StylesService { get; set; }

        public ProjectDetail ProjectDetail { get; set; }

        public List<int> AndroidVersions { get; set; } = new List<int>(new int[] { 4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,25,26,27,28 });

        public List<UnitTestType> UnitTestTypes { get; set; } = new List<UnitTestType>(); 

        public override void Init(object initData)
        {
            StylesService = (VisualStudioUIService)initData;
            base.Init(initData);
            SetTragetPlatforms();
            RaisePropertyChanged(nameof(TargetProjectList));
            SetItemSourceFromEnum<UnitTestType>(UnitTestTypes);

        }

        public ICommand _closeCommand;
        public ICommand CloseCommand => _closeCommand ?? (_closeCommand = new RelayCommand(OnCancel));

        public ICommand _navigationTypePageCommand;
        public ICommand NavigationTypePageCommand => _navigationTypePageCommand ?? (_navigationTypePageCommand = new RelayCommand(NavigateToNavigationTypePage));

        public ICommand _pageOneNavigateCommand;
        public ICommand PageOneNavigateCommand => _pageOneNavigateCommand ?? (_pageOneNavigateCommand = new RelayCommand(NavigateToPageOne));



        private void OnCancel()
        {
            WizardPage.Current.Close();
        }

        private void NavigateToNavigationTypePage()
        {
            NavigationService.NavigateMainFrame(new NavigationTypePage());
        }

        private void NavigateToPageOne()
        {
            NavigationService.NavigateMainFrame(new MainPage());
        }

        public ObservableCollection<TargetProject> TargetProjectList { get; set; } = new ObservableCollection<TargetProject>();

        private void SetTragetPlatforms()
        {
            TargetProjectList.Add(new TargetProject {TargetName="Android", TargetDescription="This project adds an Android project to you Xamarin forms project", IsSelected=true });
            TargetProjectList.Add(new TargetProject { TargetName = "iOS", TargetDescription = "This project adds an iOS project to you Xamarin forms project", IsSelected = true });
        }

        private List<T> SetItemSourceFromEnum<T>(List<T> itemSource)
        {
            foreach (var item in Enum.GetValues(typeof(T)))
            {
                itemSource.Add((T)item);
            }
            return itemSource;
        }

    }

    public  class TargetProject
    {
        public string TargetName { get; set; }
        public string TargetDescription { get; set; }
       // public string  TargetImage { get; set; }
        public bool IsSelected { get; set; }
    }
}

