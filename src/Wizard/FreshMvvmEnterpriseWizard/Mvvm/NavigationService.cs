using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace FreshMvvmEnterpriseWizard.Mvvm
{
    public static class NavigationService
    {
        private static Frame _mainFrame;

        public static bool CanGoBackMainFrame => _mainFrame.CanGoBack;


        public static void InitializeMainFrame(Frame mainFrame, object content)
        {
            _mainFrame = mainFrame;
            _mainFrame.Content = content;
        }


        public static bool NavigateMainFrame(object content) => _mainFrame.Navigate(content);


        public static void GoBackMainFrame() => _mainFrame.GoBack();

    }
}
