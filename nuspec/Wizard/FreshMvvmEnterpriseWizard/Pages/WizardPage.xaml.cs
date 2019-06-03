using FreshMvvmEnterpriseWizard.Mvvm;
using FreshMvvmEnterpriseWizard.PageModels;
using FreshMvvmEnterpriseWizard.Pages;
using FreshMvvmEnterpriseWizard.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace FreshMvvmEnterpriseWizard.Views
{
    /// <summary>
    /// Interaction logic for WizardPage.xaml
    /// </summary>
    public partial class WizardPage : Window
    {
        
        public string Result { get; set; }
        public static WizardPage Current { get; private set; }
        public WizardPageModel PageModel { get; }
        
        public VisualStudioUIService StylesService { get; }

        public WizardPage( BaseStyleValuesProvider provider)
        {
            try
            {
                Current = this;
                StylesService = new VisualStudioUIService(provider);
                PageModel = new WizardPageModel();
                DataContext = PageModel;
                InitializeComponent();
            }
            catch(Exception ex)
            {
                throw ex;
            }
           
            //NavigationService.InitializeMainFrame(mainFrame, new MainPage());

        }
        
        private void CreateButton_Click(object sender, RoutedEventArgs e)
        {
            Result = "None";

          
            this.Close();
        }

        private void OnLoaded(object sender, RoutedEventArgs e)
        {
            PageModel.Init(StylesService);
        }

       
    }
}
