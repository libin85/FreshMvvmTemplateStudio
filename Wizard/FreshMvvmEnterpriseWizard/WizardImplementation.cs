using EnvDTE;
using FreshMvvmEnterpriseWizard.Core;
using FreshMvvmEnterpriseWizard.Models;
using FreshMvvmEnterpriseWizard.Services;
using FreshMvvmEnterpriseWizard.Views;
using Microsoft.VisualStudio.TemplateWizard;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FreshMvvmEnterpriseWizard
{
    public class WizardImplementation : IWizard, IContextProvider
    {
        private WizardPage wizardPage;
        private string customMessage;
        private Dictionary<string, string> _replacementsDictionary;
        public string ProjectName => _replacementsDictionary["$projectname$"];

        public string SafeProjectName => throw new NotImplementedException();

        public string GenerationOutputPath => throw new NotImplementedException();

        public string DestinationPath => throw new NotImplementedException();

        public List<string> FilesToOpen => throw new NotImplementedException();

        // This method is called before opening any item that
        // has the OpenInEditor attribute.
        public void BeforeOpeningFile(ProjectItem projectItem)
        {
        }

        public void ProjectFinishedGenerating(Project project)
        {
        }

        // This method is only called for item templates,
        // not for project templates.
        public void ProjectItemFinishedGenerating(ProjectItem
            projectItem)
        {
        }

        // This method is called after the project is created.
        public void RunFinished()
        {
        }

        public void RunStarted(object automationObject,
            Dictionary<string, string> replacementsDictionary,
            WizardRunKind runKind, object[] customParams)
        {
            try
            {
                // Display a form to the user. The form collects
                // input for the custom message.
                wizardPage = new WizardPage(  new VSStyleValuesProvider());
                _replacementsDictionary = replacementsDictionary;
                ProjectContextService.Current = this;
                ProjectDetail.Title = replacementsDictionary["$projectname$"];
                wizardPage.ShowDialog();
                
               customMessage = wizardPage.Result;

                // Add custom parameters.
                replacementsDictionary.Add("$custommessage$",
                    customMessage);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        // This method is only called for item templates,
        // not for project templates.
        public bool ShouldAddProjectItem(string filePath)
        {
            return true;
        }
    }

}

