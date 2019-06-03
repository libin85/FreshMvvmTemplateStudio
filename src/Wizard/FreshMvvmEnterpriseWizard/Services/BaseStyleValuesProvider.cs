using System;
using System.Windows.Media;

namespace FreshMvvmEnterpriseWizard.Services
{
    public abstract class BaseStyleValuesProvider
    {
        public abstract Brush GetColor(string className, string memberName);

        public abstract System.Drawing.Color GetThemedColor(string className, string memberName);

        public abstract double GetFontSize(string fontSizeResourceKey);

        public abstract FontFamily GetFontFamily();

        public abstract event EventHandler ThemeChanged;

        public virtual void UnsubscribeEventHandlers()
        {
        }
    }
}
