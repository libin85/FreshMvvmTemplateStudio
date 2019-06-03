
using System.Windows.Media;
using System.Windows;

namespace FreshMvvmEnterpriseWizard.Services
{
    public class VisualStudioUIService : DependencyObject
    {
        private BaseStyleValuesProvider _stylesProvider;

        public static VisualStudioUIService Instance { get; private set; }

        public VisualStudioUIService(BaseStyleValuesProvider stylesProvider)
        {
            Instance = this;
            _stylesProvider = stylesProvider;
            _stylesProvider.ThemeChanged += StylesProvider_ThemeChanged;
            SetStyles();
        }

        public void UnsubscribeEventHandlers()
        {
            _stylesProvider.ThemeChanged -= StylesProvider_ThemeChanged;
            _stylesProvider.UnsubscribeEventHandlers();
        }

        private void StylesProvider_ThemeChanged(object sender, System.EventArgs e)
        {
            SetStyles();
        }

        private void SetStyles()
        {
            // VS Colors
            SetCommonDocumentColors();
            SetCommonControlColors();
            SetEnvironmentColors();
            SetInfoBarColors();

            // New Color additions
            SetFreshTemplateBuilderColors();

            // Font Sizes and Font Family
            SetFontProperties();
        }

        // VS Colors
        private void SetCommonDocumentColors()
        {
            ListItemText = _stylesProvider.GetColor("CommonDocument", "ListItemText");
            ListItemTextDisabled = _stylesProvider.GetColor("CommonDocument", "ListItemTextDisabled");
        }

        private void SetCommonControlColors()
        {
            Button = _stylesProvider.GetColor("CommonControls", "Button");
            ButtonText = _stylesProvider.GetColor("CommonControls", "ButtonText");
            ButtonBorder = _stylesProvider.GetColor("CommonControls", "ButtonBorder");

            ButtonDefault = _stylesProvider.GetColor("CommonControls", "ButtonDefault");
            ButtonDefaultText = _stylesProvider.GetColor("CommonControls", "ButtonDefaultText");
            ButtonBorderDefault = _stylesProvider.GetColor("CommonControls", "ButtonBorderDefault");

            ButtonDisabled = _stylesProvider.GetColor("CommonControls", "ButtonDisabled");
            ButtonDisabledText = _stylesProvider.GetColor("CommonControls", "ButtonDisabledText");
            ButtonBorderDisabled = _stylesProvider.GetColor("CommonControls", "ButtonBorderDisabled");

            ButtonFocused = _stylesProvider.GetColor("CommonControls", "ButtonFocused");
            ButtonFocusedText = _stylesProvider.GetColor("CommonControls", "ButtonFocusedText");
            ButtonBorderFocused = _stylesProvider.GetColor("CommonControls", "ButtonBorderFocused");

            ButtonHover = _stylesProvider.GetColor("CommonControls", "ButtonHover");
            ButtonHoverText = _stylesProvider.GetColor("CommonControls", "ButtonHoverText");
            ButtonBorderHover = _stylesProvider.GetColor("CommonControls", "ButtonBorderHover");

            ButtonPressed = _stylesProvider.GetColor("CommonControls", "ButtonPressed");
            ButtonPressedText = _stylesProvider.GetColor("CommonControls", "ButtonPressedText");
            ButtonBorderPressed = _stylesProvider.GetColor("CommonControls", "ButtonBorderPressed");

            ////ComboBox Colors
            ComboBoxBackground = _stylesProvider.GetColor("CommonControls", "ComboBoxBackground");
            ComboBoxBackgroundDisabled = _stylesProvider.GetColor("CommonControls", "ComboBoxBackgroundDisabled");
            ComboBoxBackgroundFocused = _stylesProvider.GetColor("CommonControls", "ComboBoxBackgroundFocused");
            ComboBoxBackgroundHover = _stylesProvider.GetColor("CommonControls", "ComboBoxBackgroundHover");
            ComboBoxBackgroundPressed = _stylesProvider.GetColor("CommonControls", "ComboBoxBackgroundPressed");

            ComboBoxBorder = _stylesProvider.GetColor("CommonControls", "ComboBoxBorder");
            ComboBoxBorderDisabled = _stylesProvider.GetColor("CommonControls", "ComboBoxBorderDisabled");
            ComboBoxBorderFocused = _stylesProvider.GetColor("CommonControls", "ComboBoxBorderFocused");
            ComboBoxBorderHover = _stylesProvider.GetColor("CommonControls", "ComboBoxBorderHover");
            ComboBoxBorderPressed = _stylesProvider.GetColor("CommonControls", "ComboBoxBorderPressed");

            ComboBoxGlyph = _stylesProvider.GetColor("CommonControls", "ComboBoxGlyph");
            ComboBoxGlyphBackground = _stylesProvider.GetColor("CommonControls", "ComboBoxGlyphBackground");
            ComboBoxGlyphBackgroundDisabled = _stylesProvider.GetColor("CommonControls", "ComboBoxGlyphBackgroundDisabled");
            ComboBoxGlyphBackgroundFocused = _stylesProvider.GetColor("CommonControls", "ComboBoxGlyphBackgroundFocused");
            ComboBoxGlyphBackgroundHover = _stylesProvider.GetColor("CommonControls", "ComboBoxGlyphBackgroundHover");
            ComboBoxGlyphBackgroundPressed = _stylesProvider.GetColor("CommonControls", "ComboBoxGlyphBackgroundPressed");
            ComboBoxGlyphDisabled = _stylesProvider.GetColor("CommonControls", "ComboBoxGlyphDisabled");
            ComboBoxGlyphFocused = _stylesProvider.GetColor("CommonControls", "ComboBoxGlyphFocused");
            ComboBoxGlyphHover = _stylesProvider.GetColor("CommonControls", "ComboBoxGlyphHover");
            ComboBoxGlyphPressed = _stylesProvider.GetColor("CommonControls", "ComboBoxGlyphPressed");

            ComboBoxListBackground = _stylesProvider.GetColor("CommonControls", "ComboBoxListBackground");
            ComboBoxListBackgroundShadow = _stylesProvider.GetColor("CommonControls", "ComboBoxListBackgroundShadow");
            ComboBoxListBorder = _stylesProvider.GetColor("CommonControls", "ComboBoxListBorder");

            ComboBoxListItemBackgroundHover = _stylesProvider.GetColor("CommonControls", "ComboBoxListItemBackgroundHover");
            ComboBoxListItemBorderHover = _stylesProvider.GetColor("CommonControls", "ComboBoxListItemBorderHover");
            ComboBoxListItemText = _stylesProvider.GetColor("CommonControls", "ComboBoxListItemText");
            ComboBoxListItemTextHover = _stylesProvider.GetColor("CommonControls", "ComboBoxListItemTextHover");

            ComboBoxSelection = _stylesProvider.GetColor("CommonControls", "ComboBoxSelection");

            ComboBoxSeparator = _stylesProvider.GetColor("CommonControls", "ComboBoxSeparator");
            ComboBoxSeparatorDisabled = _stylesProvider.GetColor("CommonControls", "ComboBoxSeparatorDisabled");
            ComboBoxSeparatorFocused = _stylesProvider.GetColor("CommonControls", "ComboBoxSeparatorFocused");
            ComboBoxSeparatorHover = _stylesProvider.GetColor("CommonControls", "ComboBoxSeparatorHover");
            ComboBoxSeparatorPressed = _stylesProvider.GetColor("CommonControls", "ComboBoxSeparatorPressed");

            ComboBoxText = _stylesProvider.GetColor("CommonControls", "ComboBoxText");
            ComboBoxTextDisabled = _stylesProvider.GetColor("CommonControls", "ComboBoxTextDisabled");
            ComboBoxTextFocused = _stylesProvider.GetColor("CommonControls", "ComboBoxTextFocused");
            ComboBoxTextHover = _stylesProvider.GetColor("CommonControls", "ComboBoxTextHover");
            ComboBoxTextInputSelection = _stylesProvider.GetColor("CommonControls", "ComboBoxTextInputSelection");
            ComboBoxTextPressed = _stylesProvider.GetColor("CommonControls", "ComboBoxTextPressed");

            TextBoxBackground = _stylesProvider.GetColor("CommonControls", "TextBoxBackground");
            TextBoxText = _stylesProvider.GetColor("CommonControls", "TextBoxText");
            TextBoxBorder = _stylesProvider.GetColor("CommonControls", "TextBoxBorder");

            TextBoxBackgroundDisabled = _stylesProvider.GetColor("CommonControls", "TextBoxBackgroundDisabled");
            TextBoxBorderDisabled = _stylesProvider.GetColor("CommonControls", "TextBoxBorderDisabled");
            TextBoxTextDisabled = _stylesProvider.GetColor("CommonControls", "TextBoxTextDisabled");

            TextBoxBackgroundFocused = _stylesProvider.GetColor("CommonControls", "TextBoxBackgroundFocused");
            TextBoxBorderFocused = _stylesProvider.GetColor("CommonControls", "TextBoxBorderFocused");
            TextBoxTextFocused = _stylesProvider.GetColor("CommonControls", "TextBoxTextFocused");

            CheckBoxBackground = _stylesProvider.GetColor("CommonControls", "CheckBoxBackground");
            CheckBoxBackgroundDisabled = _stylesProvider.GetColor("CommonControls", "CheckBoxBackgroundDisabled");
            CheckBoxBackgroundFocused = _stylesProvider.GetColor("CommonControls", "CheckBoxBackgroundFocused");
            CheckBoxBackgroundHover = _stylesProvider.GetColor("CommonControls", "CheckBoxBackgroundHover");
            CheckBoxBackgroundPressed = _stylesProvider.GetColor("CommonControls", "CheckBoxBackgroundPressed");
            CheckBoxGlyph = _stylesProvider.GetColor("CommonControls", "CheckBoxGlyph");
            CheckBoxGlyphDisabled = _stylesProvider.GetColor("CommonControls", "CheckBoxGlyphDisabled");
            CheckBoxGlyphFocused = _stylesProvider.GetColor("CommonControls", "CheckBoxGlyphFocused");
            CheckBoxGlyphHover = _stylesProvider.GetColor("CommonControls", "CheckBoxGlyphHover");
            CheckBoxGlyphPressed = _stylesProvider.GetColor("CommonControls", "CheckBoxGlyphPressed");
            CheckBoxBorder = _stylesProvider.GetColor("CommonControls", "CheckBoxBorder");
            CheckBoxBorderDisabled = _stylesProvider.GetColor("CommonControls", "CheckBoxBorderDisabled");
            CheckBoxBorderFocused = _stylesProvider.GetColor("CommonControls", "CheckBoxBorderFocused");
            CheckBoxBorderHover = _stylesProvider.GetColor("CommonControls", "CheckBoxBorderHover");
            CheckBoxBorderPressed = _stylesProvider.GetColor("CommonControls", "CheckBoxBorderPressed");
            CheckBoxText = _stylesProvider.GetColor("CommonControls", "CheckBoxText");
            CheckBoxTextDisabled = _stylesProvider.GetColor("CommonControls", "CheckBoxTextDisabled");
            CheckBoxTextFocused = _stylesProvider.GetColor("CommonControls", "CheckBoxTextFocused");
            CheckBoxTextHover = _stylesProvider.GetColor("CommonControls", "CheckBoxTextHover");
            CheckBoxTextPressed = _stylesProvider.GetColor("CommonControls", "CheckBoxTextPressed");
        }

        private void SetEnvironmentColors()
        {
            PageSideBarExpanderBody = _stylesProvider.GetColor("Environment", "PageSideBarExpanderBody");
            PageSideBarExpanderChevron = _stylesProvider.GetColor("Environment", "PageSideBarExpanderChevron");
            PageSideBarExpanderHeader = _stylesProvider.GetColor("Environment", "PageSideBarExpanderHeader");
            PageSideBarExpanderHeaderHover = _stylesProvider.GetColor("Environment", "PageSideBarExpanderHeaderHover");
            PageSideBarExpanderHeaderPressed = _stylesProvider.GetColor("Environment", "PageSideBarExpanderHeaderPressed");
            PageSideBarExpanderSeparator = _stylesProvider.GetColor("Environment", "PageSideBarExpanderSeparator");
            PageSideBarExpanderText = _stylesProvider.GetColor("Environment", "PageSideBarExpanderText");

            ScrollBarArrowBackground = _stylesProvider.GetColor("Environment", "ScrollBarArrowBackground");
            ScrollBarArrowDisabledBackground = _stylesProvider.GetColor("Environment", "ScrollBarArrowDisabledBackground");
            ScrollBarArrowGlyph = _stylesProvider.GetColor("Environment", "ScrollBarArrowGlyph"); // Used
            ScrollBarArrowGlyphDisabled = _stylesProvider.GetColor("Environment", "ScrollBarArrowGlyphDisabled"); // Used
            ScrollBarArrowGlyphMouseOver = _stylesProvider.GetColor("Environment", "ScrollBarArrowGlyphMouseOver"); // Used
            ScrollBarArrowGlyphPressed = _stylesProvider.GetColor("Environment", "ScrollBarArrowGlyphPressed"); // Used
            ScrollBarArrowMouseOverBackground = _stylesProvider.GetColor("Environment", "ScrollBarArrowMouseOverBackground");
            ScrollBarArrowPressedBackground = _stylesProvider.GetColor("Environment", "ScrollBarArrowPressedBackground");
            ScrollBarBackground = _stylesProvider.GetColor("Environment", "ScrollBarBackground"); // Used
            ScrollBarBorder = _stylesProvider.GetColor("Environment", "ScrollBarBorder"); // Used
            ScrollBarDisabledBackground = _stylesProvider.GetColor("Environment", "ScrollBarDisabledBackground");

            ScrollBarThumbBackground = _stylesProvider.GetColor("Environment", "ScrollBarThumbBackground"); // Used
            ScrollBarThumbBorder = _stylesProvider.GetColor("Environment", "ScrollBarThumbBorder");
            ScrollBarThumbDisabled = _stylesProvider.GetColor("Environment", "ScrollBarThumbDisabled");
            ScrollBarThumbGlyph = _stylesProvider.GetColor("Environment", "ScrollBarThumbGlyph");
            ScrollBarThumbGlyphMouseOverBorder = _stylesProvider.GetColor("Environment", "ScrollBarThumbGlyphMouseOverBorder");
            ScrollBarThumbGlyphPressedBorder = _stylesProvider.GetColor("Environment", "ScrollBarThumbGlyphPressedBorder");
            ScrollBarThumbMouseOverBackground = _stylesProvider.GetColor("Environment", "ScrollBarThumbMouseOverBackground"); // Used
            ScrollBarThumbMouseOverBorder = _stylesProvider.GetColor("Environment", "ScrollBarThumbMouseOverBorder");
            ScrollBarThumbPressedBackground = _stylesProvider.GetColor("Environment", "ScrollBarThumbPressedBackground"); // Used
            ScrollBarThumbPressedBorder = _stylesProvider.GetColor("Environment", "ScrollBarThumbPressedBorder");
        }

        private void SetInfoBarColors()
        {
            IBButton = _stylesProvider.GetColor("InfoBar", "Button");
            IBButtonBorder = _stylesProvider.GetColor("InfoBar", "ButtonBorder");
            IBButtonDisabled = _stylesProvider.GetColor("InfoBar", "ButtonDisabled");
            IBButtonDisabledBorder = _stylesProvider.GetColor("InfoBar", "ButtonDisabledBorder");
            IBButtonFocus = _stylesProvider.GetColor("InfoBar", "ButtonFocus");
            IBButtonFocusBorder = _stylesProvider.GetColor("InfoBar", "ButtonFocusBorder");
            IBButtonMouseDown = _stylesProvider.GetColor("InfoBar", "ButtonMouseDown");
            IBButtonMouseDownBorder = _stylesProvider.GetColor("InfoBar", "ButtonMouseDownBorder");
            IBButtonMouseOver = _stylesProvider.GetColor("InfoBar", "ButtonMouseOver");
            IBButtonMouseOverBorder = _stylesProvider.GetColor("InfoBar", "ButtonMouseOverBorder");
            IBCloseButton = _stylesProvider.GetColor("InfoBar", "CloseButton");
            IBCloseButtonBorder = _stylesProvider.GetColor("InfoBar", "CloseButtonBorder");
            IBCloseButtonDown = _stylesProvider.GetColor("InfoBar", "CloseButtonDown");
            IBCloseButtonDownBorder = _stylesProvider.GetColor("InfoBar", "CloseButtonDownBorder");
            IBCloseButtonDownGlyph = _stylesProvider.GetColor("InfoBar", "CloseButtonDownGlyph");
            IBCloseButtonGlyph = _stylesProvider.GetColor("InfoBar", "CloseButtonGlyph");
            IBCloseButtonHover = _stylesProvider.GetColor("InfoBar", "CloseButtonHover");
            IBCloseButtonHoverBorder = _stylesProvider.GetColor("InfoBar", "CloseButtonHoverBorder");
            IBCloseButtonHoverGlyph = _stylesProvider.GetColor("InfoBar", "CloseButtonHoverGlyph");
            IBInfoBarBackground = _stylesProvider.GetColor("InfoBar", "InfoBarBackground");
            IBInfoBarBackgroundText = _stylesProvider.GetColor("InfoBar", "InfoBarBackgroundText");
            IBInfoBarBorder = _stylesProvider.GetColor("InfoBar", "InfoBarBorder");
        }

        // New Color additions
        private void SetFreshTemplateBuilderColors()
        {
            CardBackgroundDefault = _stylesProvider.GetColor("FreshTemplateBuilder", "CardBackgroundDefault");
            CardBackgroundDisabled = _stylesProvider.GetColor("FreshTemplateBuilder", "CardBackgroundDisabled");
            CardBackgroundHover = _stylesProvider.GetColor("FreshTemplateBuilder", "CardBackgroundHover");
            CardBackgroundSelected = _stylesProvider.GetColor("FreshTemplateBuilder", "CardBackgroundSelected");
            CardBorderDefault = _stylesProvider.GetColor("FreshTemplateBuilder", "CardBorderDefault");
            CardBorderDisabled = _stylesProvider.GetColor("FreshTemplateBuilder", "CardBorderDisabled");
            CardBorderHover = _stylesProvider.GetColor("FreshTemplateBuilder", "CardBorderHover");
            CardBorderSelected = _stylesProvider.GetColor("FreshTemplateBuilder", "CardBorderSelected");
            CardDescriptionText = _stylesProvider.GetColor("FreshTemplateBuilder", "CardDescriptionText");
            CardFooterText = _stylesProvider.GetColor("FreshTemplateBuilder", "CardFooterText");
            CardIcon = _stylesProvider.GetColor("FreshTemplateBuilder", "CardIcon");
            CardTitleText = _stylesProvider.GetColor("FreshTemplateBuilder", "CardTitleText");
            ChangesSummaryDetailFileHeader = _stylesProvider.GetColor("FreshTemplateBuilder", "ChangesSummaryDetailFileHeader");
            ChangesSummaryDetailFileHeaderText = _stylesProvider.GetColor("FreshTemplateBuilder", "ChangesSummaryDetailFileHeaderText");
            DeleteTemplateIcon = _stylesProvider.GetColor("FreshTemplateBuilder", "DeleteTemplateIcon");
            GridHeadingBackground = _stylesProvider.GetColor("FreshTemplateBuilder", "GridHeadingBackground");
            GridHeadingHoverBackground = _stylesProvider.GetColor("FreshTemplateBuilder", "GridHeadingHoverBackground");
            GridHeadingHoverText = _stylesProvider.GetColor("FreshTemplateBuilder", "GridHeadingHoverText");
            GridHeadingText = _stylesProvider.GetColor("FreshTemplateBuilder", "GridHeadingText");
            GridLine = _stylesProvider.GetColor("FreshTemplateBuilder", "GridLine");
            HeaderText = _stylesProvider.GetColor("FreshTemplateBuilder", "HeaderText");
            HeaderTextSecondary = _stylesProvider.GetColor("FreshTemplateBuilder", "HeaderTextSecondary");
            Hyperlink = _stylesProvider.GetColor("FreshTemplateBuilder", "Hyperlink");
            HyperlinkDisabled = _stylesProvider.GetColor("FreshTemplateBuilder", "HyperlinkDisabled");
            HyperlinkHover = _stylesProvider.GetColor("FreshTemplateBuilder", "HyperlinkHover");
            ListItemDisabledText = _stylesProvider.GetColor("FreshTemplateBuilder", "ListItemDisabledText");
            ListItemMouseOver = _stylesProvider.GetColor("FreshTemplateBuilder", "ListItemMouseOver");
            ListItemMouseOverText = _stylesProvider.GetColor("FreshTemplateBuilder", "ListItemMouseOverText");
            NewItemFileStatusConflictingFile = _stylesProvider.GetColor("FreshTemplateBuilder", "NewItemFileStatusConflictingFile");
            NewItemFileStatusConflictingStylesFile = _stylesProvider.GetColor("FreshTemplateBuilder", "NewItemFileStatusConflictingStylesFile");
            NewItemFileStatusModifiedFile = _stylesProvider.GetColor("FreshTemplateBuilder", "NewItemFileStatusModifiedFile");
            NewItemFileStatusNewFile = _stylesProvider.GetColor("FreshTemplateBuilder", "NewItemFileStatusNewFile");
            NewItemFileStatusUnchangedFile = _stylesProvider.GetColor("FreshTemplateBuilder", "NewItemFileStatusUnchangedFile");
            NewItemFileStatusWarningFile = _stylesProvider.GetColor("FreshTemplateBuilder", "NewItemFileStatusWarningFile");
            SavedTemplateBackgroundHover = _stylesProvider.GetColor("FreshTemplateBuilder", "SavedTemplateBackgroundHover");
            SectionDivider = _stylesProvider.GetColor("FreshTemplateBuilder", "SectionDivider");
            SelectedItemActive = _stylesProvider.GetColor("FreshTemplateBuilder", "SelectedItemActive");
            SelectedItemActiveText = _stylesProvider.GetColor("FreshTemplateBuilder", "SelectedItemActiveText");
            SelectedItemInactive = _stylesProvider.GetColor("FreshTemplateBuilder", "SelectedItemInactive");
            SelectedItemInactiveText = _stylesProvider.GetColor("FreshTemplateBuilder", "SelectedItemInactiveText");
            TemplateInfoPageDescription = _stylesProvider.GetColor("FreshTemplateBuilder", "TemplateInfoPageDescription");
            WindowBorder = _stylesProvider.GetColor("FreshTemplateBuilder", "WindowBorder");
            WindowPanel = _stylesProvider.GetColor("FreshTemplateBuilder", "WindowPanel");
            WindowPanelColor = _stylesProvider.GetThemedColor("FreshTemplateBuilder", "WindowPanel");
            WindowPanelText = _stylesProvider.GetColor("FreshTemplateBuilder", "WindowPanelText");
            WindowPanelTextColor = _stylesProvider.GetThemedColor("FreshTemplateBuilder", "WindowPanelText");
            WizardFooter = _stylesProvider.GetColor("FreshTemplateBuilder", "WizardFooter");
            WizardFooterText = _stylesProvider.GetColor("FreshTemplateBuilder", "WizardFooterText");
        }

        // Font Sizes and Font Family
        private void SetFontProperties()
        {
            // FontSizes
            Environment100PercentFontSize = _stylesProvider.GetFontSize("Environment100PercentFontSize");
            Environment111PercentFontSize = _stylesProvider.GetFontSize("Environment111PercentFontSize");
            Environment122PercentFontSize = _stylesProvider.GetFontSize("Environment122PercentFontSize");
            Environment133PercentFontSize = _stylesProvider.GetFontSize("Environment133PercentFontSize");
            Environment155PercentFontSize = _stylesProvider.GetFontSize("Environment155PercentFontSize");
            Environment200PercentFontSize = _stylesProvider.GetFontSize("Environment200PercentFontSize");
            Environment310PercentFontSize = _stylesProvider.GetFontSize("Environment310PercentFontSize");
            Environment330PercentFontSize = _stylesProvider.GetFontSize("Environment330PercentFontSize");
            Environment375PercentFontSize = _stylesProvider.GetFontSize("Environment375PercentFontSize");

            // Font Family
           // EnvironmentFontFamily = _stylesProvider.GetFontFamily();
        }


        public static readonly DependencyProperty ButtonProperty = DependencyProperty.Register("Button", typeof(Brush), typeof(VisualStudioUIService), new PropertyMetadata(null));

        public Brush Button
        {
            get { return (Brush)GetValue(ButtonProperty); }
            set { SetValue(ButtonProperty, value); }
        }

        public static readonly DependencyProperty ButtonTextProperty = DependencyProperty.Register("ButtonText", typeof(Brush), typeof(VisualStudioUIService), new PropertyMetadata(null));

        public Brush ButtonText
        {
            get { return (Brush)GetValue(ButtonTextProperty); }
            set { SetValue(ButtonTextProperty, value); }
        }

        public static readonly DependencyProperty ButtonBorderProperty = DependencyProperty.Register("ButtonBorder", typeof(Brush), typeof(VisualStudioUIService), new PropertyMetadata(null));

        public Brush ButtonBorder
        {
            get { return (Brush)GetValue(ButtonBorderProperty); }
            set { SetValue(ButtonBorderProperty, value); }
        }

        // Button Default Colors
        public static readonly DependencyProperty ButtonDefaultProperty = DependencyProperty.Register("ButtonDefault", typeof(Brush), typeof(VisualStudioUIService), new PropertyMetadata(null));

        public Brush ButtonDefault
        {
            get { return (Brush)GetValue(ButtonDefaultProperty); }
            set { SetValue(ButtonDefaultProperty, value); }
        }

        public static readonly DependencyProperty ButtonDefaultTextProperty = DependencyProperty.Register("ButtonDefaultText", typeof(Brush), typeof(VisualStudioUIService), new PropertyMetadata(null));

        public Brush ButtonDefaultText
        {
            get { return (Brush)GetValue(ButtonDefaultTextProperty); }
            set { SetValue(ButtonDefaultTextProperty, value); }
        }

        public static readonly DependencyProperty ButtonBorderDefaultProperty = DependencyProperty.Register("ButtonBorderDefault", typeof(Brush), typeof(VisualStudioUIService), new PropertyMetadata(null));

        public Brush ButtonBorderDefault
        {
            get { return (Brush)GetValue(ButtonBorderDefaultProperty); }
            set { SetValue(ButtonBorderDefaultProperty, value); }
        }

        public static readonly DependencyProperty ButtonDisabledProperty = DependencyProperty.Register("ButtonDisabled", typeof(Brush), typeof(VisualStudioUIService), new PropertyMetadata(null));

        // Button Disabled Colors
        public Brush ButtonDisabled
        {
            get { return (Brush)GetValue(ButtonDisabledProperty); }
            set { SetValue(ButtonDisabledProperty, value); }
        }

        public static readonly DependencyProperty ButtonDisabledTextProperty = DependencyProperty.Register("ButtonDisabledText", typeof(Brush), typeof(VisualStudioUIService), new PropertyMetadata(null));

        public Brush ButtonDisabledText
        {
            get { return (Brush)GetValue(ButtonDisabledTextProperty); }
            set { SetValue(ButtonDisabledTextProperty, value); }
        }

        public static readonly DependencyProperty ButtonBorderDisabledProperty = DependencyProperty.Register("ButtonBorderDisabled", typeof(Brush), typeof(VisualStudioUIService), new PropertyMetadata(null));

        public Brush ButtonBorderDisabled
        {
            get { return (Brush)GetValue(ButtonBorderDisabledProperty); }
            set { SetValue(ButtonBorderDisabledProperty, value); }
        }

        // Button Focused Colors
        public static readonly DependencyProperty ButtonFocusedProperty = DependencyProperty.Register("ButtonFocused", typeof(Brush), typeof(VisualStudioUIService), new PropertyMetadata(null));

        public Brush ButtonFocused
        {
            get { return (Brush)GetValue(ButtonFocusedProperty); }
            set { SetValue(ButtonFocusedProperty, value); }
        }

        public static readonly DependencyProperty ButtonFocusedTextProperty = DependencyProperty.Register("ButtonFocusedText", typeof(Brush), typeof(VisualStudioUIService), new PropertyMetadata(null));

        public Brush ButtonFocusedText
        {
            get { return (Brush)GetValue(ButtonFocusedTextProperty); }
            set { SetValue(ButtonFocusedTextProperty, value); }
        }

        public static readonly DependencyProperty ButtonBorderFocusedProperty = DependencyProperty.Register("ButtonBorderFocused", typeof(Brush), typeof(VisualStudioUIService), new PropertyMetadata(null));

        public Brush ButtonBorderFocused
        {
            get { return (Brush)GetValue(ButtonBorderFocusedProperty); }
            set { SetValue(ButtonBorderFocusedProperty, value); }
        }

        // Button Hover Colors
        public static readonly DependencyProperty ButtonHoverProperty = DependencyProperty.Register("ButtonHover", typeof(Brush), typeof(VisualStudioUIService), new PropertyMetadata(null));

        public Brush ButtonHover
        {
            get { return (Brush)GetValue(ButtonHoverProperty); }
            set { SetValue(ButtonHoverProperty, value); }
        }

        public static readonly DependencyProperty ButtonHoverTextProperty = DependencyProperty.Register("ButtonHoverText", typeof(Brush), typeof(VisualStudioUIService), new PropertyMetadata(null));

        public Brush ButtonHoverText
        {
            get { return (Brush)GetValue(ButtonHoverTextProperty); }
            set { SetValue(ButtonHoverTextProperty, value); }
        }

        public static readonly DependencyProperty ButtonBorderHoverProperty = DependencyProperty.Register("ButtonBorderHover", typeof(Brush), typeof(VisualStudioUIService), new PropertyMetadata(null));

        public Brush ButtonBorderHover
        {
            get { return (Brush)GetValue(ButtonBorderHoverProperty); }
            set { SetValue(ButtonBorderHoverProperty, value); }
        }

        // Button Pressed Colors
        public static readonly DependencyProperty ButtonPressedProperty = DependencyProperty.Register("ButtonPressed", typeof(Brush), typeof(VisualStudioUIService), new PropertyMetadata(null));

        public Brush ButtonPressed
        {
            get { return (Brush)GetValue(ButtonPressedProperty); }
            set { SetValue(ButtonPressedProperty, value); }
        }

        public static readonly DependencyProperty ButtonPressedTextProperty = DependencyProperty.Register("ButtonPressedText", typeof(Brush), typeof(VisualStudioUIService), new PropertyMetadata(null));

        public Brush ButtonPressedText
        {
            get { return (Brush)GetValue(ButtonPressedTextProperty); }
            set { SetValue(ButtonPressedTextProperty, value); }
        }

        public static readonly DependencyProperty ButtonBorderPressedProperty = DependencyProperty.Register("ButtonBorderPressed", typeof(Brush), typeof(VisualStudioUIService), new PropertyMetadata(null));

        public Brush ButtonBorderPressed
        {
            get { return (Brush)GetValue(ButtonBorderPressedProperty); }
            set { SetValue(ButtonBorderPressedProperty, value); }
        }

        // ComboBox Colors
        public static readonly DependencyProperty ComboBoxBackgroundProperty = DependencyProperty.Register("ComboBoxBackground", typeof(Brush), typeof(VisualStudioUIService), new PropertyMetadata(null));

        public Brush ComboBoxBackground
        {
            get { return (Brush)GetValue(ComboBoxBackgroundProperty); }
            set { SetValue(ComboBoxBackgroundProperty, value); }
        }

        public static readonly DependencyProperty ComboBoxBackgroundDisabledProperty = DependencyProperty.Register("ComboBoxBackgroundDisabled", typeof(Brush), typeof(VisualStudioUIService), new PropertyMetadata(null));

        public Brush ComboBoxBackgroundDisabled
        {
            get { return (Brush)GetValue(ComboBoxBackgroundDisabledProperty); }
            set { SetValue(ComboBoxBackgroundDisabledProperty, value); }
        }

        public static readonly DependencyProperty ComboBoxBackgroundFocusedProperty = DependencyProperty.Register("ComboBoxBackgroundFocused", typeof(Brush), typeof(VisualStudioUIService), new PropertyMetadata(null));

        public Brush ComboBoxBackgroundFocused
        {
            get { return (Brush)GetValue(ComboBoxBackgroundFocusedProperty); }
            set { SetValue(ComboBoxBackgroundFocusedProperty, value); }
        }

        public static readonly DependencyProperty ComboBoxBackgroundHoverProperty = DependencyProperty.Register("ComboBoxBackgroundHover", typeof(Brush), typeof(VisualStudioUIService), new PropertyMetadata(null));

        public Brush ComboBoxBackgroundHover
        {
            get { return (Brush)GetValue(ComboBoxBackgroundHoverProperty); }
            set { SetValue(ComboBoxBackgroundHoverProperty, value); }
        }

        public static readonly DependencyProperty ComboBoxBackgroundPressedProperty = DependencyProperty.Register("ComboBoxBackgroundPressed", typeof(Brush), typeof(VisualStudioUIService), new PropertyMetadata(null));

        public Brush ComboBoxBackgroundPressed
        {
            get { return (Brush)GetValue(ComboBoxBackgroundPressedProperty); }
            set { SetValue(ComboBoxBackgroundPressedProperty, value); }
        }

        public static readonly DependencyProperty ComboBoxBorderProperty = DependencyProperty.Register("ComboBoxBorder", typeof(Brush), typeof(VisualStudioUIService), new PropertyMetadata(null));

        public Brush ComboBoxBorder
        {
            get { return (Brush)GetValue(ComboBoxBorderProperty); }
            set { SetValue(ComboBoxBorderProperty, value); }
        }

        public static readonly DependencyProperty ComboBoxBorderDisabledProperty = DependencyProperty.Register("ComboBoxBorderDisabled", typeof(Brush), typeof(VisualStudioUIService), new PropertyMetadata(null));

        public Brush ComboBoxBorderDisabled
        {
            get { return (Brush)GetValue(ComboBoxBorderDisabledProperty); }
            set { SetValue(ComboBoxBorderDisabledProperty, value); }
        }

        public static readonly DependencyProperty ComboBoxBorderFocusedProperty = DependencyProperty.Register("ComboBoxBorderFocused", typeof(Brush), typeof(VisualStudioUIService), new PropertyMetadata(null));

        public Brush ComboBoxBorderFocused
        {
            get { return (Brush)GetValue(ComboBoxBorderFocusedProperty); }
            set { SetValue(ComboBoxBorderFocusedProperty, value); }
        }

        public static readonly DependencyProperty ComboBoxBorderHoverProperty = DependencyProperty.Register("ComboBoxBorderHover", typeof(Brush), typeof(VisualStudioUIService), new PropertyMetadata(null));

        public Brush ComboBoxBorderHover
        {
            get { return (Brush)GetValue(ComboBoxBorderHoverProperty); }
            set { SetValue(ComboBoxBorderHoverProperty, value); }
        }

        public static readonly DependencyProperty ComboBoxBorderPressedProperty = DependencyProperty.Register("ComboBoxBorderPressed", typeof(Brush), typeof(VisualStudioUIService), new PropertyMetadata(null));

        public Brush ComboBoxBorderPressed
        {
            get { return (Brush)GetValue(ComboBoxBorderPressedProperty); }
            set { SetValue(ComboBoxBorderPressedProperty, value); }
        }

        public static readonly DependencyProperty ComboBoxGlyphProperty = DependencyProperty.Register("ComboBoxGlyph", typeof(Brush), typeof(VisualStudioUIService), new PropertyMetadata(null));

        public Brush ComboBoxGlyph
        {
            get { return (Brush)GetValue(ComboBoxGlyphProperty); }
            set { SetValue(ComboBoxGlyphProperty, value); }
        }

        public static readonly DependencyProperty ComboBoxGlyphBackgroundProperty = DependencyProperty.Register("ComboBoxGlyphBackground", typeof(Brush), typeof(VisualStudioUIService), new PropertyMetadata(null));

        public Brush ComboBoxGlyphBackground
        {
            get { return (Brush)GetValue(ComboBoxGlyphBackgroundProperty); }
            set { SetValue(ComboBoxGlyphBackgroundProperty, value); }
        }

        public static readonly DependencyProperty ComboBoxGlyphBackgroundDisabledProperty = DependencyProperty.Register("ComboBoxGlyphBackgroundDisabled", typeof(Brush), typeof(VisualStudioUIService), new PropertyMetadata(null));

        public Brush ComboBoxGlyphBackgroundDisabled
        {
            get { return (Brush)GetValue(ComboBoxGlyphBackgroundDisabledProperty); }
            set { SetValue(ComboBoxGlyphBackgroundDisabledProperty, value); }
        }

        public static readonly DependencyProperty ComboBoxGlyphBackgroundFocusedProperty = DependencyProperty.Register("ComboBoxGlyphBackgroundFocused", typeof(Brush), typeof(VisualStudioUIService), new PropertyMetadata(null));

        public Brush ComboBoxGlyphBackgroundFocused
        {
            get { return (Brush)GetValue(ComboBoxGlyphBackgroundFocusedProperty); }
            set { SetValue(ComboBoxGlyphBackgroundFocusedProperty, value); }
        }

        public static readonly DependencyProperty ComboBoxGlyphBackgroundHoverProperty = DependencyProperty.Register("ComboBoxGlyphBackgroundHover", typeof(Brush), typeof(VisualStudioUIService), new PropertyMetadata(null));

        public Brush ComboBoxGlyphBackgroundHover
        {
            get { return (Brush)GetValue(ComboBoxGlyphBackgroundHoverProperty); }
            set { SetValue(ComboBoxGlyphBackgroundHoverProperty, value); }
        }

        public static readonly DependencyProperty ComboBoxGlyphBackgroundPressedProperty = DependencyProperty.Register("ComboBoxGlyphBackgroundPressed", typeof(Brush), typeof(VisualStudioUIService), new PropertyMetadata(null));

        public Brush ComboBoxGlyphBackgroundPressed
        {
            get { return (Brush)GetValue(ComboBoxGlyphBackgroundPressedProperty); }
            set { SetValue(ComboBoxGlyphBackgroundPressedProperty, value); }
        }

        public static readonly DependencyProperty ComboBoxGlyphDisabledProperty = DependencyProperty.Register("ComboBoxGlyphDisabled", typeof(Brush), typeof(VisualStudioUIService), new PropertyMetadata(null));

        public Brush ComboBoxGlyphDisabled
        {
            get { return (Brush)GetValue(ComboBoxGlyphDisabledProperty); }
            set { SetValue(ComboBoxGlyphDisabledProperty, value); }
        }

        public static readonly DependencyProperty ComboBoxGlyphFocusedProperty = DependencyProperty.Register("ComboBoxGlyphFocused", typeof(Brush), typeof(VisualStudioUIService), new PropertyMetadata(null));

        public Brush ComboBoxGlyphFocused
        {
            get { return (Brush)GetValue(ComboBoxGlyphFocusedProperty); }
            set { SetValue(ComboBoxGlyphFocusedProperty, value); }
        }

        public static readonly DependencyProperty ComboBoxGlyphHoverProperty = DependencyProperty.Register("ComboBoxGlyphHover", typeof(Brush), typeof(VisualStudioUIService), new PropertyMetadata(null));

        public Brush ComboBoxGlyphHover
        {
            get { return (Brush)GetValue(ComboBoxGlyphHoverProperty); }
            set { SetValue(ComboBoxGlyphHoverProperty, value); }
        }

        public static readonly DependencyProperty ComboBoxGlyphPressedProperty = DependencyProperty.Register("ComboBoxGlyphPressed", typeof(Brush), typeof(VisualStudioUIService), new PropertyMetadata(null));

        public Brush ComboBoxGlyphPressed
        {
            get { return (Brush)GetValue(ComboBoxGlyphPressedProperty); }
            set { SetValue(ComboBoxGlyphPressedProperty, value); }
        }

        public static readonly DependencyProperty ComboBoxListBackgroundProperty = DependencyProperty.Register("ComboBoxListBackground", typeof(Brush), typeof(VisualStudioUIService), new PropertyMetadata(null));

        public Brush ComboBoxListBackground
        {
            get { return (Brush)GetValue(ComboBoxListBackgroundProperty); }
            set { SetValue(ComboBoxListBackgroundProperty, value); }
        }

        public static readonly DependencyProperty ComboBoxListBackgroundShadowProperty = DependencyProperty.Register("ComboBoxListBackgroundShadow", typeof(Brush), typeof(VisualStudioUIService), new PropertyMetadata(null));

        public Brush ComboBoxListBackgroundShadow
        {
            get { return (Brush)GetValue(ComboBoxListBackgroundShadowProperty); }
            set { SetValue(ComboBoxListBackgroundShadowProperty, value); }
        }

        public static readonly DependencyProperty ComboBoxListBorderProperty = DependencyProperty.Register("ComboBoxListBorder", typeof(Brush), typeof(VisualStudioUIService), new PropertyMetadata(null));

        public Brush ComboBoxListBorder
        {
            get { return (Brush)GetValue(ComboBoxListBorderProperty); }
            set { SetValue(ComboBoxListBorderProperty, value); }
        }

        public static readonly DependencyProperty ComboBoxListItemBackgroundHoverProperty = DependencyProperty.Register("ComboBoxListItemBackgroundHover", typeof(Brush), typeof(VisualStudioUIService), new PropertyMetadata(null));

        public Brush ComboBoxListItemBackgroundHover
        {
            get { return (Brush)GetValue(ComboBoxListItemBackgroundHoverProperty); }
            set { SetValue(ComboBoxListItemBackgroundHoverProperty, value); }
        }

        public static readonly DependencyProperty ComboBoxListItemBorderHoverProperty = DependencyProperty.Register("ComboBoxListItemBorderHover", typeof(Brush), typeof(VisualStudioUIService), new PropertyMetadata(null));

        public Brush ComboBoxListItemBorderHover
        {
            get { return (Brush)GetValue(ComboBoxListItemBorderHoverProperty); }
            set { SetValue(ComboBoxListItemBorderHoverProperty, value); }
        }

        public static readonly DependencyProperty ComboBoxListItemTextProperty = DependencyProperty.Register("ComboBoxListItemText", typeof(Brush), typeof(VisualStudioUIService), new PropertyMetadata(null));

        public Brush ComboBoxListItemText
        {
            get { return (Brush)GetValue(ComboBoxListItemTextProperty); }
            set { SetValue(ComboBoxListItemTextProperty, value); }
        }

        public static readonly DependencyProperty ComboBoxListItemTextHoverProperty = DependencyProperty.Register("ComboBoxListItemTextHover", typeof(Brush), typeof(VisualStudioUIService), new PropertyMetadata(null));

        public Brush ComboBoxListItemTextHover
        {
            get { return (Brush)GetValue(ComboBoxListItemTextHoverProperty); }
            set { SetValue(ComboBoxListItemTextHoverProperty, value); }
        }

        public static readonly DependencyProperty ComboBoxSelectionProperty = DependencyProperty.Register("ComboBoxSelection", typeof(Brush), typeof(VisualStudioUIService), new PropertyMetadata(null));

        public Brush ComboBoxSelection
        {
            get { return (Brush)GetValue(ComboBoxSelectionProperty); }
            set { SetValue(ComboBoxSelectionProperty, value); }
        }

        public static readonly DependencyProperty ComboBoxSeparatorProperty = DependencyProperty.Register("ComboBoxSeparator", typeof(Brush), typeof(VisualStudioUIService), new PropertyMetadata(null));

        public Brush ComboBoxSeparator
        {
            get { return (Brush)GetValue(ComboBoxSeparatorProperty); }
            set { SetValue(ComboBoxSeparatorProperty, value); }
        }

        public static readonly DependencyProperty ComboBoxSeparatorDisabledProperty = DependencyProperty.Register("ComboBoxSeparatorDisabled", typeof(Brush), typeof(VisualStudioUIService), new PropertyMetadata(null));

        public Brush ComboBoxSeparatorDisabled
        {
            get { return (Brush)GetValue(ComboBoxSeparatorDisabledProperty); }
            set { SetValue(ComboBoxSeparatorDisabledProperty, value); }
        }

        public static readonly DependencyProperty ComboBoxSeparatorFocusedProperty = DependencyProperty.Register("ComboBoxSeparatorFocused", typeof(Brush), typeof(VisualStudioUIService), new PropertyMetadata(null));

        public Brush ComboBoxSeparatorFocused
        {
            get { return (Brush)GetValue(ComboBoxSeparatorFocusedProperty); }
            set { SetValue(ComboBoxSeparatorFocusedProperty, value); }
        }

        public static readonly DependencyProperty ComboBoxSeparatorHoverProperty = DependencyProperty.Register("ComboBoxSeparatorHover", typeof(Brush), typeof(VisualStudioUIService), new PropertyMetadata(null));

        public Brush ComboBoxSeparatorHover
        {
            get { return (Brush)GetValue(ComboBoxSeparatorHoverProperty); }
            set { SetValue(ComboBoxSeparatorHoverProperty, value); }
        }

        public static readonly DependencyProperty ComboBoxSeparatorPressedProperty = DependencyProperty.Register("ComboBoxSeparatorPressed", typeof(Brush), typeof(VisualStudioUIService), new PropertyMetadata(null));

        public Brush ComboBoxSeparatorPressed
        {
            get { return (Brush)GetValue(ComboBoxSeparatorPressedProperty); }
            set { SetValue(ComboBoxSeparatorPressedProperty, value); }
        }

        public static readonly DependencyProperty ComboBoxTextProperty = DependencyProperty.Register("ComboBoxText", typeof(Brush), typeof(VisualStudioUIService), new PropertyMetadata(null));

        public Brush ComboBoxText
        {
            get { return (Brush)GetValue(ComboBoxTextProperty); }
            set { SetValue(ComboBoxTextProperty, value); }
        }

        public static readonly DependencyProperty ComboBoxTextDisabledProperty = DependencyProperty.Register("ComboBoxTextDisabled", typeof(Brush), typeof(VisualStudioUIService), new PropertyMetadata(null));

        public Brush ComboBoxTextDisabled
        {
            get { return (Brush)GetValue(ComboBoxTextDisabledProperty); }
            set { SetValue(ComboBoxTextDisabledProperty, value); }
        }

        public static readonly DependencyProperty ComboBoxTextFocusedProperty = DependencyProperty.Register("ComboBoxTextFocused", typeof(Brush), typeof(VisualStudioUIService), new PropertyMetadata(null));

        public Brush ComboBoxTextFocused
        {
            get { return (Brush)GetValue(ComboBoxTextFocusedProperty); }
            set { SetValue(ComboBoxTextFocusedProperty, value); }
        }

        public static readonly DependencyProperty ComboBoxTextHoverProperty = DependencyProperty.Register("ComboBoxTextHover", typeof(Brush), typeof(VisualStudioUIService), new PropertyMetadata(null));

        public Brush ComboBoxTextHover
        {
            get { return (Brush)GetValue(ComboBoxTextHoverProperty); }
            set { SetValue(ComboBoxTextHoverProperty, value); }
        }

        public static readonly DependencyProperty ComboBoxTextInputSelectionProperty = DependencyProperty.Register("ComboBoxTextInputSelection", typeof(Brush), typeof(VisualStudioUIService), new PropertyMetadata(null));

        public Brush ComboBoxTextInputSelection
        {
            get { return (Brush)GetValue(ComboBoxTextInputSelectionProperty); }
            set { SetValue(ComboBoxTextInputSelectionProperty, value); }
        }

        public static readonly DependencyProperty ComboBoxTextPressedProperty = DependencyProperty.Register("ComboBoxTextPressed", typeof(Brush), typeof(VisualStudioUIService), new PropertyMetadata(null));

        public Brush ComboBoxTextPressed
        {
            get { return (Brush)GetValue(ComboBoxTextPressedProperty); }
            set { SetValue(ComboBoxTextPressedProperty, value); }
        }

        // TextBox Colors
        public static readonly DependencyProperty TextBoxBackgroundProperty = DependencyProperty.Register("TextBoxBackground", typeof(Brush), typeof(VisualStudioUIService), new PropertyMetadata(null));

        public Brush TextBoxBackground
        {
            get { return (Brush)GetValue(TextBoxBackgroundProperty); }
            set { SetValue(TextBoxBackgroundProperty, value); }
        }

        public static readonly DependencyProperty TextBoxTextProperty = DependencyProperty.Register("TextBoxText", typeof(Brush), typeof(VisualStudioUIService), new PropertyMetadata(null));

        public Brush TextBoxText
        {
            get { return (Brush)GetValue(TextBoxTextProperty); }
            set { SetValue(TextBoxTextProperty, value); }
        }

        public static readonly DependencyProperty TextBoxBorderProperty = DependencyProperty.Register("TextBoxBorder", typeof(Brush), typeof(VisualStudioUIService), new PropertyMetadata(null));

        public Brush TextBoxBorder
        {
            get { return (Brush)GetValue(TextBoxBorderProperty); }
            set { SetValue(TextBoxBorderProperty, value); }
        }

        // TextBox Disabled Colors
        public static readonly DependencyProperty TextBoxBackgroundDisabledProperty = DependencyProperty.Register("TextBoxBackgroundDisabled", typeof(Brush), typeof(VisualStudioUIService), new PropertyMetadata(null));

        public Brush TextBoxBackgroundDisabled
        {
            get { return (Brush)GetValue(TextBoxBackgroundDisabledProperty); }
            set { SetValue(TextBoxBackgroundDisabledProperty, value); }
        }

        public static readonly DependencyProperty TextBoxBorderDisabledProperty = DependencyProperty.Register("TextBoxBorderDisabled", typeof(Brush), typeof(VisualStudioUIService), new PropertyMetadata(null));

        public Brush TextBoxBorderDisabled
        {
            get { return (Brush)GetValue(TextBoxBorderDisabledProperty); }
            set { SetValue(TextBoxBorderDisabledProperty, value); }
        }

        public static readonly DependencyProperty TextBoxTextDisabledProperty = DependencyProperty.Register("TextBoxTextDisabled", typeof(Brush), typeof(VisualStudioUIService), new PropertyMetadata(null));

        public Brush TextBoxTextDisabled
        {
            get { return (Brush)GetValue(TextBoxTextDisabledProperty); }
            set { SetValue(TextBoxTextDisabledProperty, value); }
        }

        // TextBox Focused Colors
        public static readonly DependencyProperty TextBoxBackgroundFocusedProperty = DependencyProperty.Register("TextBoxBackgroundFocused", typeof(Brush), typeof(VisualStudioUIService), new PropertyMetadata(null));

        public Brush TextBoxBackgroundFocused
        {
            get { return (Brush)GetValue(TextBoxBackgroundFocusedProperty); }
            set { SetValue(TextBoxBackgroundFocusedProperty, value); }
        }

        public static readonly DependencyProperty TextBoxBorderFocusedProperty = DependencyProperty.Register("TextBoxBorderFocused", typeof(Brush), typeof(VisualStudioUIService), new PropertyMetadata(null));

        public Brush TextBoxBorderFocused
        {
            get { return (Brush)GetValue(TextBoxBorderFocusedProperty); }
            set { SetValue(TextBoxBorderFocusedProperty, value); }
        }

        public static readonly DependencyProperty TextBoxTextFocusedProperty = DependencyProperty.Register("TextBoxTextFocused", typeof(Brush), typeof(VisualStudioUIService), new PropertyMetadata(null));

        public Brush TextBoxTextFocused
        {
            get { return (Brush)GetValue(TextBoxTextFocusedProperty); }
            set { SetValue(TextBoxTextFocusedProperty, value); }
        }

        public static readonly DependencyProperty CheckBoxGlyphProperty = DependencyProperty.Register("CheckBoxGlyph", typeof(Brush), typeof(VisualStudioUIService), new PropertyMetadata(null));

        public Brush CheckBoxGlyph
        {
            get { return (Brush)GetValue(CheckBoxGlyphProperty); }
            set { SetValue(CheckBoxGlyphProperty, value); }
        }

        public static readonly DependencyProperty CheckBoxGlyphDisabledProperty = DependencyProperty.Register("CheckBoxGlyphDisabled", typeof(Brush), typeof(VisualStudioUIService), new PropertyMetadata(null));

        public Brush CheckBoxGlyphDisabled
        {
            get { return (Brush)GetValue(CheckBoxGlyphDisabledProperty); }
            set { SetValue(CheckBoxGlyphDisabledProperty, value); }
        }

        public static readonly DependencyProperty CheckBoxGlyphFocusedProperty = DependencyProperty.Register("CheckBoxGlyphFocused", typeof(Brush), typeof(VisualStudioUIService), new PropertyMetadata(null));

        public Brush CheckBoxGlyphFocused
        {
            get { return (Brush)GetValue(CheckBoxGlyphFocusedProperty); }
            set { SetValue(CheckBoxGlyphFocusedProperty, value); }
        }

        public static readonly DependencyProperty CheckBoxGlyphHoverProperty = DependencyProperty.Register("CheckBoxGlyphHover", typeof(Brush), typeof(VisualStudioUIService), new PropertyMetadata(null));

        public Brush CheckBoxGlyphHover
        {
            get { return (Brush)GetValue(CheckBoxGlyphHoverProperty); }
            set { SetValue(CheckBoxGlyphHoverProperty, value); }
        }

        public static readonly DependencyProperty CheckBoxGlyphPressedProperty = DependencyProperty.Register("CheckBoxGlyphPressed", typeof(Brush), typeof(VisualStudioUIService), new PropertyMetadata(null));

        public Brush CheckBoxGlyphPressed
        {
            get { return (Brush)GetValue(CheckBoxGlyphPressedProperty); }
            set { SetValue(CheckBoxGlyphPressedProperty, value); }
        }

        public static readonly DependencyProperty CheckBoxBackgroundProperty = DependencyProperty.Register("CheckBoxBackground", typeof(Brush), typeof(VisualStudioUIService), new PropertyMetadata(null));

        public Brush CheckBoxBackground
        {
            get { return (Brush)GetValue(CheckBoxBackgroundProperty); }
            set { SetValue(CheckBoxBackgroundProperty, value); }
        }

        public static readonly DependencyProperty CheckBoxBackgroundDisabledProperty = DependencyProperty.Register("CheckBoxBackgroundDisabled", typeof(Brush), typeof(VisualStudioUIService), new PropertyMetadata(null));

        public Brush CheckBoxBackgroundDisabled
        {
            get { return (Brush)GetValue(CheckBoxBackgroundDisabledProperty); }
            set { SetValue(CheckBoxBackgroundDisabledProperty, value); }
        }

        public static readonly DependencyProperty CheckBoxBackgroundFocusedProperty = DependencyProperty.Register("CheckBoxBackgroundFocused", typeof(Brush), typeof(VisualStudioUIService), new PropertyMetadata(null));

        public Brush CheckBoxBackgroundFocused
        {
            get { return (Brush)GetValue(CheckBoxBackgroundFocusedProperty); }
            set { SetValue(CheckBoxBackgroundFocusedProperty, value); }
        }

        public static readonly DependencyProperty CheckBoxBackgroundHoverProperty = DependencyProperty.Register("CheckBoxBackgroundHover", typeof(Brush), typeof(VisualStudioUIService), new PropertyMetadata(null));

        public Brush CheckBoxBackgroundHover
        {
            get { return (Brush)GetValue(CheckBoxBackgroundHoverProperty); }
            set { SetValue(CheckBoxBackgroundHoverProperty, value); }
        }

        public static readonly DependencyProperty CheckBoxBackgroundPressedProperty = DependencyProperty.Register("CheckBoxBackgroundPressed", typeof(Brush), typeof(VisualStudioUIService), new PropertyMetadata(null));

        public Brush CheckBoxBackgroundPressed
        {
            get { return (Brush)GetValue(CheckBoxBackgroundPressedProperty); }
            set { SetValue(CheckBoxBackgroundPressedProperty, value); }
        }

        public static readonly DependencyProperty CheckBoxBorderProperty = DependencyProperty.Register("CheckBoxBorder", typeof(Brush), typeof(VisualStudioUIService), new PropertyMetadata(null));

        public Brush CheckBoxBorder
        {
            get { return (Brush)GetValue(CheckBoxBorderProperty); }
            set { SetValue(CheckBoxBorderProperty, value); }
        }

        public static readonly DependencyProperty CheckBoxBorderDisabledProperty = DependencyProperty.Register("CheckBoxBorderDisabled", typeof(Brush), typeof(VisualStudioUIService), new PropertyMetadata(null));

        public Brush CheckBoxBorderDisabled
        {
            get { return (Brush)GetValue(CheckBoxBorderDisabledProperty); }
            set { SetValue(CheckBoxBorderDisabledProperty, value); }
        }

        public static readonly DependencyProperty CheckBoxBorderFocusedProperty = DependencyProperty.Register("CheckBoxBorderFocused", typeof(Brush), typeof(VisualStudioUIService), new PropertyMetadata(null));

        public Brush CheckBoxBorderFocused
        {
            get { return (Brush)GetValue(CheckBoxBorderFocusedProperty); }
            set { SetValue(CheckBoxBorderFocusedProperty, value); }
        }

        public static readonly DependencyProperty CheckBoxBorderHoverProperty = DependencyProperty.Register("CheckBoxBorderHover", typeof(Brush), typeof(VisualStudioUIService), new PropertyMetadata(null));

        public Brush CheckBoxBorderHover
        {
            get { return (Brush)GetValue(CheckBoxBorderHoverProperty); }
            set { SetValue(CheckBoxBorderHoverProperty, value); }
        }

        public static readonly DependencyProperty CheckBoxBorderPressedProperty = DependencyProperty.Register("CheckBoxBorderPressed", typeof(Brush), typeof(VisualStudioUIService), new PropertyMetadata(null));

        public Brush CheckBoxBorderPressed
        {
            get { return (Brush)GetValue(CheckBoxBorderPressedProperty); }
            set { SetValue(CheckBoxBorderPressedProperty, value); }
        }

        public static readonly DependencyProperty CheckBoxTextProperty = DependencyProperty.Register("CheckBoxText", typeof(Brush), typeof(VisualStudioUIService), new PropertyMetadata(null));

        public Brush CheckBoxText
        {
            get { return (Brush)GetValue(CheckBoxTextProperty); }
            set { SetValue(CheckBoxTextProperty, value); }
        }

        public static readonly DependencyProperty CheckBoxTextDisabledProperty = DependencyProperty.Register("CheckBoxTextDisabled", typeof(Brush), typeof(VisualStudioUIService), new PropertyMetadata(null));

        public Brush CheckBoxTextDisabled
        {
            get { return (Brush)GetValue(CheckBoxTextDisabledProperty); }
            set { SetValue(CheckBoxTextDisabledProperty, value); }
        }

        public static readonly DependencyProperty CheckBoxTextFocusedProperty = DependencyProperty.Register("CheckBoxTextFocused", typeof(Brush), typeof(VisualStudioUIService), new PropertyMetadata(null));

        public Brush CheckBoxTextFocused
        {
            get { return (Brush)GetValue(CheckBoxTextFocusedProperty); }
            set { SetValue(CheckBoxTextFocusedProperty, value); }
        }

        public static readonly DependencyProperty CheckBoxTextHoverProperty = DependencyProperty.Register("CheckBoxTextHover", typeof(Brush), typeof(VisualStudioUIService), new PropertyMetadata(null));

        public Brush CheckBoxTextHover
        {
            get { return (Brush)GetValue(CheckBoxTextHoverProperty); }
            set { SetValue(CheckBoxTextHoverProperty, value); }
        }

        public static readonly DependencyProperty CheckBoxTextPressedProperty = DependencyProperty.Register("CheckBoxTextPressed", typeof(Brush), typeof(VisualStudioUIService), new PropertyMetadata(null));

        public Brush CheckBoxTextPressed
        {
            get { return (Brush)GetValue(CheckBoxTextPressedProperty); }
            set { SetValue(CheckBoxTextPressedProperty, value); }
        }

        public static readonly DependencyProperty PageSideBarExpanderBodyProperty = DependencyProperty.Register("PageSideBarExpanderBody", typeof(Brush), typeof(VisualStudioUIService), new PropertyMetadata(null));

        public Brush PageSideBarExpanderBody
        {
            get { return (Brush)GetValue(PageSideBarExpanderBodyProperty); }
            set { SetValue(PageSideBarExpanderBodyProperty, value); }
        }

        public static readonly DependencyProperty PageSideBarExpanderChevronProperty = DependencyProperty.Register("PageSideBarExpanderChevron", typeof(Brush), typeof(VisualStudioUIService), new PropertyMetadata(null));

        public Brush PageSideBarExpanderChevron
        {
            get { return (Brush)GetValue(PageSideBarExpanderChevronProperty); }
            set { SetValue(PageSideBarExpanderChevronProperty, value); }
        }

        public static readonly DependencyProperty PageSideBarExpanderHeaderProperty = DependencyProperty.Register("PageSideBarExpanderHeader", typeof(Brush), typeof(VisualStudioUIService), new PropertyMetadata(null));

        public Brush PageSideBarExpanderHeader
        {
            get { return (Brush)GetValue(PageSideBarExpanderHeaderProperty); }
            set { SetValue(PageSideBarExpanderHeaderProperty, value); }
        }

        public static readonly DependencyProperty PageSideBarExpanderHeaderHoverProperty = DependencyProperty.Register("PageSideBarExpanderHeaderHover", typeof(Brush), typeof(VisualStudioUIService), new PropertyMetadata(null));

        public Brush PageSideBarExpanderHeaderHover
        {
            get { return (Brush)GetValue(PageSideBarExpanderHeaderHoverProperty); }
            set { SetValue(PageSideBarExpanderHeaderHoverProperty, value); }
        }

        public static readonly DependencyProperty PageSideBarExpanderHeaderPressedProperty = DependencyProperty.Register("PageSideBarExpanderHeaderPressed", typeof(Brush), typeof(VisualStudioUIService), new PropertyMetadata(null));

        public Brush PageSideBarExpanderHeaderPressed
        {
            get { return (Brush)GetValue(PageSideBarExpanderHeaderPressedProperty); }
            set { SetValue(PageSideBarExpanderHeaderPressedProperty, value); }
        }

        public static readonly DependencyProperty PageSideBarExpanderSeparatorProperty = DependencyProperty.Register("PageSideBarExpanderSeparator", typeof(Brush), typeof(VisualStudioUIService), new PropertyMetadata(null));

        public Brush PageSideBarExpanderSeparator
        {
            get { return (Brush)GetValue(PageSideBarExpanderSeparatorProperty); }
            set { SetValue(PageSideBarExpanderSeparatorProperty, value); }
        }

        public static readonly DependencyProperty PageSideBarExpanderTextProperty = DependencyProperty.Register("PageSideBarExpanderText", typeof(Brush), typeof(VisualStudioUIService), new PropertyMetadata(null));

        public Brush PageSideBarExpanderText
        {
            get { return (Brush)GetValue(PageSideBarExpanderTextProperty); }
            set { SetValue(PageSideBarExpanderTextProperty, value); }
        }

        public static readonly DependencyProperty ScrollBarArrowBackgroundProperty = DependencyProperty.Register("ScrollBarArrowBackground", typeof(Brush), typeof(VisualStudioUIService), new PropertyMetadata(null));

        public Brush ScrollBarArrowBackground
        {
            get { return (Brush)GetValue(ScrollBarArrowBackgroundProperty); }
            set { SetValue(ScrollBarArrowBackgroundProperty, value); }
        }

        public static readonly DependencyProperty ScrollBarArrowDisabledBackgroundProperty = DependencyProperty.Register("ScrollBarArrowDisabledBackground", typeof(Brush), typeof(VisualStudioUIService), new PropertyMetadata(null));

        public Brush ScrollBarArrowDisabledBackground
        {
            get { return (Brush)GetValue(ScrollBarArrowDisabledBackgroundProperty); }
            set { SetValue(ScrollBarArrowDisabledBackgroundProperty, value); }
        }

        public static readonly DependencyProperty ScrollBarArrowGlyphProperty = DependencyProperty.Register("ScrollBarArrowGlyph", typeof(Brush), typeof(VisualStudioUIService), new PropertyMetadata(null));

        public Brush ScrollBarArrowGlyph
        {
            get { return (Brush)GetValue(ScrollBarArrowGlyphProperty); }
            set { SetValue(ScrollBarArrowGlyphProperty, value); }
        }

        public static readonly DependencyProperty ScrollBarArrowGlyphDisabledProperty = DependencyProperty.Register("ScrollBarArrowGlyphDisabled", typeof(Brush), typeof(VisualStudioUIService), new PropertyMetadata(null));

        public Brush ScrollBarArrowGlyphDisabled
        {
            get { return (Brush)GetValue(ScrollBarArrowGlyphDisabledProperty); }
            set { SetValue(ScrollBarArrowGlyphDisabledProperty, value); }
        }

        public static readonly DependencyProperty ScrollBarArrowGlyphMouseOverProperty = DependencyProperty.Register("ScrollBarArrowGlyphMouseOver", typeof(Brush), typeof(VisualStudioUIService), new PropertyMetadata(null));

        public Brush ScrollBarArrowGlyphMouseOver
        {
            get { return (Brush)GetValue(ScrollBarArrowGlyphMouseOverProperty); }
            set { SetValue(ScrollBarArrowGlyphMouseOverProperty, value); }
        }

        public static readonly DependencyProperty ScrollBarArrowGlyphPressedProperty = DependencyProperty.Register("ScrollBarArrowGlyphPressed", typeof(Brush), typeof(VisualStudioUIService), new PropertyMetadata(null));

        public Brush ScrollBarArrowGlyphPressed
        {
            get { return (Brush)GetValue(ScrollBarArrowGlyphPressedProperty); }
            set { SetValue(ScrollBarArrowGlyphPressedProperty, value); }
        }

        public static readonly DependencyProperty ScrollBarArrowMouseOverBackgroundProperty = DependencyProperty.Register("ScrollBarArrowMouseOverBackground", typeof(Brush), typeof(VisualStudioUIService), new PropertyMetadata(null));

        public Brush ScrollBarArrowMouseOverBackground
        {
            get { return (Brush)GetValue(ScrollBarArrowMouseOverBackgroundProperty); }
            set { SetValue(ScrollBarArrowMouseOverBackgroundProperty, value); }
        }

        public static readonly DependencyProperty ScrollBarArrowPressedBackgroundProperty = DependencyProperty.Register("ScrollBarArrowPressedBackground", typeof(Brush), typeof(VisualStudioUIService), new PropertyMetadata(null));

        public Brush ScrollBarArrowPressedBackground
        {
            get { return (Brush)GetValue(ScrollBarArrowPressedBackgroundProperty); }
            set { SetValue(ScrollBarArrowPressedBackgroundProperty, value); }
        }

        public static readonly DependencyProperty ScrollBarBackgroundProperty = DependencyProperty.Register("ScrollBarBackground", typeof(Brush), typeof(VisualStudioUIService), new PropertyMetadata(null));

        public Brush ScrollBarBackground
        {
            get { return (Brush)GetValue(ScrollBarBackgroundProperty); }
            set { SetValue(ScrollBarBackgroundProperty, value); }
        }

        public static readonly DependencyProperty ScrollBarBorderProperty = DependencyProperty.Register("ScrollBarBorder", typeof(Brush), typeof(VisualStudioUIService), new PropertyMetadata(null));

        public Brush ScrollBarBorder
        {
            get { return (Brush)GetValue(ScrollBarBorderProperty); }
            set { SetValue(ScrollBarBorderProperty, value); }
        }

        public static readonly DependencyProperty ScrollBarDisabledBackgroundProperty = DependencyProperty.Register("ScrollBarDisabledBackground", typeof(Brush), typeof(VisualStudioUIService), new PropertyMetadata(null));

        public Brush ScrollBarDisabledBackground
        {
            get { return (Brush)GetValue(ScrollBarDisabledBackgroundProperty); }
            set { SetValue(ScrollBarDisabledBackgroundProperty, value); }
        }

        public static readonly DependencyProperty ScrollBarThumbBackgroundProperty = DependencyProperty.Register("ScrollBarThumbBackground", typeof(Brush), typeof(VisualStudioUIService), new PropertyMetadata(null));

        public Brush ScrollBarThumbBackground
        {
            get { return (Brush)GetValue(ScrollBarThumbBackgroundProperty); }
            set { SetValue(ScrollBarThumbBackgroundProperty, value); }
        }

        public static readonly DependencyProperty ScrollBarThumbBorderProperty = DependencyProperty.Register("ScrollBarThumbBorder", typeof(Brush), typeof(VisualStudioUIService), new PropertyMetadata(null));

        public Brush ScrollBarThumbBorder
        {
            get { return (Brush)GetValue(ScrollBarThumbBorderProperty); }
            set { SetValue(ScrollBarThumbBorderProperty, value); }
        }

        public static readonly DependencyProperty ScrollBarThumbDisabledProperty = DependencyProperty.Register("ScrollBarThumbDisabled", typeof(Brush), typeof(VisualStudioUIService), new PropertyMetadata(null));

        public Brush ScrollBarThumbDisabled
        {
            get { return (Brush)GetValue(ScrollBarThumbDisabledProperty); }
            set { SetValue(ScrollBarThumbDisabledProperty, value); }
        }

        public static readonly DependencyProperty ScrollBarThumbGlyphProperty = DependencyProperty.Register("ScrollBarThumbGlyph", typeof(Brush), typeof(VisualStudioUIService), new PropertyMetadata(null));

        public Brush ScrollBarThumbGlyph
        {
            get { return (Brush)GetValue(ScrollBarThumbGlyphProperty); }
            set { SetValue(ScrollBarThumbGlyphProperty, value); }
        }

        public static readonly DependencyProperty ScrollBarThumbGlyphMouseOverBorderProperty = DependencyProperty.Register("ScrollBarThumbGlyphMouseOverBorder", typeof(Brush), typeof(VisualStudioUIService), new PropertyMetadata(null));

        public Brush ScrollBarThumbGlyphMouseOverBorder
        {
            get { return (Brush)GetValue(ScrollBarThumbGlyphMouseOverBorderProperty); }
            set { SetValue(ScrollBarThumbGlyphMouseOverBorderProperty, value); }
        }

        public static readonly DependencyProperty ScrollBarThumbGlyphPressedBorderProperty = DependencyProperty.Register("ScrollBarThumbGlyphPressedBorder", typeof(Brush), typeof(VisualStudioUIService), new PropertyMetadata(null));

        public Brush ScrollBarThumbGlyphPressedBorder
        {
            get { return (Brush)GetValue(ScrollBarThumbGlyphPressedBorderProperty); }
            set { SetValue(ScrollBarThumbGlyphPressedBorderProperty, value); }
        }

        public static readonly DependencyProperty ScrollBarThumbMouseOverBackgroundProperty = DependencyProperty.Register("ScrollBarThumbMouseOverBackground", typeof(Brush), typeof(VisualStudioUIService), new PropertyMetadata(null));

        public Brush ScrollBarThumbMouseOverBackground
        {
            get { return (Brush)GetValue(ScrollBarThumbMouseOverBackgroundProperty); }
            set { SetValue(ScrollBarThumbMouseOverBackgroundProperty, value); }
        }

        public static readonly DependencyProperty ScrollBarThumbMouseOverBorderProperty = DependencyProperty.Register("ScrollBarThumbMouseOverBorder", typeof(Brush), typeof(VisualStudioUIService), new PropertyMetadata(null));

        public Brush ScrollBarThumbMouseOverBorder
        {
            get { return (Brush)GetValue(ScrollBarThumbMouseOverBorderProperty); }
            set { SetValue(ScrollBarThumbMouseOverBorderProperty, value); }
        }

        public static readonly DependencyProperty ScrollBarThumbPressedBackgroundProperty = DependencyProperty.Register("ScrollBarThumbPressedBackground", typeof(Brush), typeof(VisualStudioUIService), new PropertyMetadata(null));

        public Brush ScrollBarThumbPressedBackground
        {
            get { return (Brush)GetValue(ScrollBarThumbPressedBackgroundProperty); }
            set { SetValue(ScrollBarThumbPressedBackgroundProperty, value); }
        }

        public static readonly DependencyProperty ScrollBarThumbPressedBorderProperty = DependencyProperty.Register("ScrollBarThumbPressedBorder", typeof(Brush), typeof(VisualStudioUIService), new PropertyMetadata(null));

        public Brush ScrollBarThumbPressedBorder
        {
            get { return (Brush)GetValue(ScrollBarThumbPressedBorderProperty); }
            set { SetValue(ScrollBarThumbPressedBorderProperty, value); }
        }

        public static readonly DependencyProperty Environment100PercentFontSizeProperty = DependencyProperty.Register("Environment100PercentFontSize", typeof(double), typeof(VisualStudioUIService), new PropertyMetadata(0.0));

        public double Environment100PercentFontSize
        {
            get { return (double)GetValue(Environment100PercentFontSizeProperty); }
            set { SetValue(Environment100PercentFontSizeProperty, value); }
        }

        public static readonly DependencyProperty Environment111PercentFontSizeProperty = DependencyProperty.Register("Environment111PercentFontSize", typeof(double), typeof(VisualStudioUIService), new PropertyMetadata(0.0));

        public double Environment111PercentFontSize
        {
            get { return (double)GetValue(Environment111PercentFontSizeProperty); }
            set { SetValue(Environment111PercentFontSizeProperty, value); }
        }

        public static readonly DependencyProperty Environment122PercentFontSizeProperty = DependencyProperty.Register("Environment122PercentFontSize", typeof(double), typeof(VisualStudioUIService), new PropertyMetadata(0.0));

        public double Environment122PercentFontSize
        {
            get { return (double)GetValue(Environment122PercentFontSizeProperty); }
            set { SetValue(Environment122PercentFontSizeProperty, value); }
        }

        public static readonly DependencyProperty Environment133PercentFontSizeProperty = DependencyProperty.Register("Environment133PercentFontSize", typeof(double), typeof(VisualStudioUIService), new PropertyMetadata(0.0));

        public double Environment133PercentFontSize
        {
            get { return (double)GetValue(Environment133PercentFontSizeProperty); }
            set { SetValue(Environment133PercentFontSizeProperty, value); }
        }

        public static readonly DependencyProperty Environment155PercentFontSizeProperty = DependencyProperty.Register("Environment155PercentFontSize", typeof(double), typeof(VisualStudioUIService), new PropertyMetadata(0.0));

        public double Environment155PercentFontSize
        {
            get { return (double)GetValue(Environment155PercentFontSizeProperty); }
            set { SetValue(Environment155PercentFontSizeProperty, value); }
        }

        public static readonly DependencyProperty Environment200PercentFontSizeProperty = DependencyProperty.Register("Environment200PercentFontSize", typeof(double), typeof(VisualStudioUIService), new PropertyMetadata(0.0));

        public double Environment200PercentFontSize
        {
            get { return (double)GetValue(Environment200PercentFontSizeProperty); }
            set { SetValue(Environment200PercentFontSizeProperty, value); }
        }

        public static readonly DependencyProperty Environment310PercentFontSizeProperty = DependencyProperty.Register("Environment310PercentFontSize", typeof(double), typeof(VisualStudioUIService), new PropertyMetadata(0.0));

        public double Environment310PercentFontSize
        {
            get { return (double)GetValue(Environment310PercentFontSizeProperty); }
            set { SetValue(Environment310PercentFontSizeProperty, value); }
        }

        public static readonly DependencyProperty Environment330PercentFontSizeProperty = DependencyProperty.Register("Environment330PercentFontSize", typeof(double), typeof(VisualStudioUIService), new PropertyMetadata(0.0));

        public double Environment330PercentFontSize
        {
            get { return (double)GetValue(Environment330PercentFontSizeProperty); }
            set { SetValue(Environment330PercentFontSizeProperty, value); }
        }

        public static readonly DependencyProperty Environment375PercentFontSizeProperty = DependencyProperty.Register("Environment375PercentFontSize", typeof(double), typeof(VisualStudioUIService), new PropertyMetadata(0.0));

        public double Environment375PercentFontSize
        {
            get { return (double)GetValue(Environment375PercentFontSizeProperty); }
            set { SetValue(Environment375PercentFontSizeProperty, value); }
        }

        public static readonly DependencyProperty EnvironmentFontFamilyProperty = DependencyProperty.Register("EnvironmentFontFamily", typeof(FontFamily), typeof(VisualStudioUIService), new PropertyMetadata(null));

        public FontFamily EnvironmentFontFamily
        {
            get { return (FontFamily)GetValue(EnvironmentFontFamilyProperty); }
            set { SetValue(EnvironmentFontFamilyProperty, value); }
        }

        public static readonly DependencyProperty CardBackgroundDefaultProperty = DependencyProperty.Register("CardBackgroundDefault", typeof(Brush), typeof(VisualStudioUIService), new PropertyMetadata(null));

        public Brush CardBackgroundDefault
        {
            get { return (Brush)GetValue(CardBackgroundDefaultProperty); }
            set { SetValue(CardBackgroundDefaultProperty, value); }
        }

        public static readonly DependencyProperty CardBackgroundDisabledProperty = DependencyProperty.Register("CardBackgroundDisabled", typeof(Brush), typeof(VisualStudioUIService), new PropertyMetadata(null));

        public Brush CardBackgroundDisabled
        {
            get { return (Brush)GetValue(CardBackgroundDisabledProperty); }
            set { SetValue(CardBackgroundDisabledProperty, value); }
        }

        public static readonly DependencyProperty CardBackgroundHoverProperty = DependencyProperty.Register("CardBackgroundHover", typeof(Brush), typeof(VisualStudioUIService), new PropertyMetadata(null));

        public Brush CardBackgroundHover
        {
            get { return (Brush)GetValue(CardBackgroundHoverProperty); }
            set { SetValue(CardBackgroundHoverProperty, value); }
        }

        public static readonly DependencyProperty CardBackgroundSelectedProperty = DependencyProperty.Register("CardBackgroundSelected", typeof(Brush), typeof(VisualStudioUIService), new PropertyMetadata(null));

        public Brush CardBackgroundSelected
        {
            get { return (Brush)GetValue(CardBackgroundSelectedProperty); }
            set { SetValue(CardBackgroundSelectedProperty, value); }
        }

        public static readonly DependencyProperty CardBorderDefaultProperty = DependencyProperty.Register("CardBorderDefault", typeof(Brush), typeof(VisualStudioUIService), new PropertyMetadata(null));

        public Brush CardBorderDefault
        {
            get { return (Brush)GetValue(CardBorderDefaultProperty); }
            set { SetValue(CardBorderDefaultProperty, value); }
        }

        public static readonly DependencyProperty CardBorderDisabledProperty = DependencyProperty.Register("CardBorderDisabled", typeof(Brush), typeof(VisualStudioUIService), new PropertyMetadata(null));

        public Brush CardBorderDisabled
        {
            get { return (Brush)GetValue(CardBorderDisabledProperty); }
            set { SetValue(CardBorderDisabledProperty, value); }
        }

        public static readonly DependencyProperty CardBorderHoverProperty = DependencyProperty.Register("CardBorderHover", typeof(Brush), typeof(VisualStudioUIService), new PropertyMetadata(null));

        public Brush CardBorderHover
        {
            get { return (Brush)GetValue(CardBorderHoverProperty); }
            set { SetValue(CardBorderHoverProperty, value); }
        }

        public static readonly DependencyProperty CardBorderSelectedProperty = DependencyProperty.Register("CardBorderSelected", typeof(Brush), typeof(VisualStudioUIService), new PropertyMetadata(null));

        public Brush CardBorderSelected
        {
            get { return (Brush)GetValue(CardBorderSelectedProperty); }
            set { SetValue(CardBorderSelectedProperty, value); }
        }

        public static readonly DependencyProperty CardDescriptionTextProperty = DependencyProperty.Register("CardDescriptionText", typeof(Brush), typeof(VisualStudioUIService), new PropertyMetadata(null));

        public Brush CardDescriptionText
        {
            get { return (Brush)GetValue(CardDescriptionTextProperty); }
            set { SetValue(CardDescriptionTextProperty, value); }
        }

        public static readonly DependencyProperty CardFooterTextProperty = DependencyProperty.Register("CardFooterText", typeof(Brush), typeof(VisualStudioUIService), new PropertyMetadata(null));

        public Brush CardFooterText
        {
            get { return (Brush)GetValue(CardFooterTextProperty); }
            set { SetValue(CardFooterTextProperty, value); }
        }

        public static readonly DependencyProperty CardIconProperty = DependencyProperty.Register("CardIcon", typeof(Brush), typeof(VisualStudioUIService), new PropertyMetadata(null));

        public Brush CardIcon
        {
            get { return (Brush)GetValue(CardIconProperty); }
            set { SetValue(CardIconProperty, value); }
        }

        public static readonly DependencyProperty CardTitleTextProperty = DependencyProperty.Register("CardTitleText", typeof(Brush), typeof(VisualStudioUIService), new PropertyMetadata(null));

        public Brush CardTitleText
        {
            get { return (Brush)GetValue(CardTitleTextProperty); }
            set { SetValue(CardTitleTextProperty, value); }
        }

        public static readonly DependencyProperty ChangesSummaryDetailFileHeaderProperty = DependencyProperty.Register("ChangesSummaryDetailFileHeader", typeof(Brush), typeof(VisualStudioUIService), new PropertyMetadata(null));

        public Brush ChangesSummaryDetailFileHeader
        {
            get { return (Brush)GetValue(ChangesSummaryDetailFileHeaderProperty); }
            set { SetValue(ChangesSummaryDetailFileHeaderProperty, value); }
        }

        public static readonly DependencyProperty ChangesSummaryDetailFileHeaderTextProperty = DependencyProperty.Register("ChangesSummaryDetailFileHeaderText", typeof(Brush), typeof(VisualStudioUIService), new PropertyMetadata(null));

        public Brush ChangesSummaryDetailFileHeaderText
        {
            get { return (Brush)GetValue(ChangesSummaryDetailFileHeaderTextProperty); }
            set { SetValue(ChangesSummaryDetailFileHeaderTextProperty, value); }
        }

        public static readonly DependencyProperty DeleteTemplateIconProperty = DependencyProperty.Register("DeleteTemplateIcon", typeof(Brush), typeof(VisualStudioUIService), new PropertyMetadata(null));

        public Brush DeleteTemplateIcon
        {
            get { return (Brush)GetValue(DeleteTemplateIconProperty); }
            set { SetValue(DeleteTemplateIconProperty, value); }
        }

        public static readonly DependencyProperty GridHeadingBackgroundProperty = DependencyProperty.Register("GridHeadingBackground", typeof(Brush), typeof(VisualStudioUIService), new PropertyMetadata(null));

        public Brush GridHeadingBackground
        {
            get { return (Brush)GetValue(GridHeadingBackgroundProperty); }
            set { SetValue(GridHeadingBackgroundProperty, value); }
        }

        public static readonly DependencyProperty GridHeadingHoverBackgroundProperty = DependencyProperty.Register("GridHeadingHoverBackground", typeof(Brush), typeof(VisualStudioUIService), new PropertyMetadata(null));

        public Brush GridHeadingHoverBackground
        {
            get { return (Brush)GetValue(GridHeadingHoverBackgroundProperty); }
            set { SetValue(GridHeadingHoverBackgroundProperty, value); }
        }

        public static readonly DependencyProperty GridHeadingHoverTextProperty = DependencyProperty.Register("GridHeadingHoverText", typeof(Brush), typeof(VisualStudioUIService), new PropertyMetadata(null));

        public Brush GridHeadingHoverText
        {
            get { return (Brush)GetValue(GridHeadingHoverTextProperty); }
            set { SetValue(GridHeadingHoverTextProperty, value); }
        }

        public static readonly DependencyProperty GridHeadingTextProperty = DependencyProperty.Register("GridHeadingText", typeof(Brush), typeof(VisualStudioUIService), new PropertyMetadata(null));

        public Brush GridHeadingText
        {
            get { return (Brush)GetValue(GridHeadingTextProperty); }
            set { SetValue(GridHeadingTextProperty, value); }
        }

        public static readonly DependencyProperty GridLineProperty = DependencyProperty.Register("GridLine", typeof(Brush), typeof(VisualStudioUIService), new PropertyMetadata(null));

        public Brush GridLine
        {
            get { return (Brush)GetValue(GridLineProperty); }
            set { SetValue(GridLineProperty, value); }
        }

        public static readonly DependencyProperty HeaderTextProperty = DependencyProperty.Register("HeaderText", typeof(Brush), typeof(VisualStudioUIService), new PropertyMetadata(null));

        public Brush HeaderText
        {
            get { return (Brush)GetValue(HeaderTextProperty); }
            set { SetValue(HeaderTextProperty, value); }
        }

        public static readonly DependencyProperty HeaderTextSecondaryProperty = DependencyProperty.Register("HeaderTextSecondary", typeof(Brush), typeof(VisualStudioUIService), new PropertyMetadata(null));

        public Brush HeaderTextSecondary
        {
            get { return (Brush)GetValue(HeaderTextSecondaryProperty); }
            set { SetValue(HeaderTextSecondaryProperty, value); }
        }

        public static readonly DependencyProperty HyperlinkProperty = DependencyProperty.Register("Hyperlink", typeof(Brush), typeof(VisualStudioUIService), new PropertyMetadata(null));

        public Brush Hyperlink
        {
            get { return (Brush)GetValue(HyperlinkProperty); }
            set { SetValue(HyperlinkProperty, value); }
        }

        public static readonly DependencyProperty HyperlinkDisabledProperty = DependencyProperty.Register("HyperlinkDisabled", typeof(Brush), typeof(VisualStudioUIService), new PropertyMetadata(null));

        public Brush HyperlinkDisabled
        {
            get { return (Brush)GetValue(HyperlinkDisabledProperty); }
            set { SetValue(HyperlinkDisabledProperty, value); }
        }

        public static readonly DependencyProperty HyperlinkHoverProperty = DependencyProperty.Register("HyperlinkHover", typeof(Brush), typeof(VisualStudioUIService), new PropertyMetadata(null));

        public Brush HyperlinkHover
        {
            get { return (Brush)GetValue(HyperlinkHoverProperty); }
            set { SetValue(HyperlinkHoverProperty, value); }
        }

        public static readonly DependencyProperty ListItemDisabledTextProperty = DependencyProperty.Register("ListItemDisabledText", typeof(Brush), typeof(VisualStudioUIService), new PropertyMetadata(null));

        public Brush ListItemDisabledText
        {
            get { return (Brush)GetValue(ListItemDisabledTextProperty); }
            set { SetValue(ListItemDisabledTextProperty, value); }
        }

        public static readonly DependencyProperty ListItemMouseOverProperty = DependencyProperty.Register("ListItemMouseOver", typeof(Brush), typeof(VisualStudioUIService), new PropertyMetadata(null));

        public Brush ListItemMouseOver
        {
            get { return (Brush)GetValue(ListItemMouseOverProperty); }
            set { SetValue(ListItemMouseOverProperty, value); }
        }

        public static readonly DependencyProperty ListItemMouseOverTextProperty = DependencyProperty.Register("ListItemMouseOverText", typeof(Brush), typeof(VisualStudioUIService), new PropertyMetadata(null));

        public Brush ListItemMouseOverText
        {
            get { return (Brush)GetValue(ListItemMouseOverTextProperty); }
            set { SetValue(ListItemMouseOverTextProperty, value); }
        }

        public static readonly DependencyProperty NewItemFileStatusConflictingFileProperty = DependencyProperty.Register("NewItemFileStatusConflictingFile", typeof(Brush), typeof(VisualStudioUIService), new PropertyMetadata(null));

        public Brush NewItemFileStatusConflictingFile
        {
            get { return (Brush)GetValue(NewItemFileStatusConflictingFileProperty); }
            set { SetValue(NewItemFileStatusConflictingFileProperty, value); }
        }

        public static readonly DependencyProperty NewItemFileStatusConflictingStylesFileProperty = DependencyProperty.Register("NewItemFileStatusConflictingStylesFile", typeof(Brush), typeof(VisualStudioUIService), new PropertyMetadata(null));

        public Brush NewItemFileStatusConflictingStylesFile
        {
            get { return (Brush)GetValue(NewItemFileStatusConflictingStylesFileProperty); }
            set { SetValue(NewItemFileStatusConflictingStylesFileProperty, value); }
        }

        public static readonly DependencyProperty NewItemFileStatusModifiedFileProperty = DependencyProperty.Register("NewItemFileStatusModifiedFile", typeof(Brush), typeof(VisualStudioUIService), new PropertyMetadata(null));

        public Brush NewItemFileStatusModifiedFile
        {
            get { return (Brush)GetValue(NewItemFileStatusModifiedFileProperty); }
            set { SetValue(NewItemFileStatusModifiedFileProperty, value); }
        }

        public static readonly DependencyProperty NewItemFileStatusNewFileProperty = DependencyProperty.Register("NewItemFileStatusNewFile", typeof(Brush), typeof(VisualStudioUIService), new PropertyMetadata(null));

        public Brush NewItemFileStatusNewFile
        {
            get { return (Brush)GetValue(NewItemFileStatusNewFileProperty); }
            set { SetValue(NewItemFileStatusNewFileProperty, value); }
        }

        public static readonly DependencyProperty NewItemFileStatusUnchangedFileProperty = DependencyProperty.Register("NewItemFileStatusUnchangedFile", typeof(Brush), typeof(VisualStudioUIService), new PropertyMetadata(null));

        public Brush NewItemFileStatusUnchangedFile
        {
            get { return (Brush)GetValue(NewItemFileStatusUnchangedFileProperty); }
            set { SetValue(NewItemFileStatusUnchangedFileProperty, value); }
        }

        public static readonly DependencyProperty NewItemFileStatusWarningFileProperty = DependencyProperty.Register("NewItemFileStatusWarningFile", typeof(Brush), typeof(VisualStudioUIService), new PropertyMetadata(null));

        public Brush NewItemFileStatusWarningFile
        {
            get { return (Brush)GetValue(NewItemFileStatusWarningFileProperty); }
            set { SetValue(NewItemFileStatusWarningFileProperty, value); }
        }

        public static readonly DependencyProperty SavedTemplateBackgroundHoverProperty = DependencyProperty.Register("SavedTemplateBackgroundHover", typeof(Brush), typeof(VisualStudioUIService), new PropertyMetadata(null));

        public Brush SavedTemplateBackgroundHover
        {
            get { return (Brush)GetValue(SavedTemplateBackgroundHoverProperty); }
            set { SetValue(SavedTemplateBackgroundHoverProperty, value); }
        }

        public static readonly DependencyProperty SectionDividerProperty = DependencyProperty.Register("SectionDivider", typeof(Brush), typeof(VisualStudioUIService), new PropertyMetadata(null));

        public Brush SectionDivider
        {
            get { return (Brush)GetValue(SectionDividerProperty); }
            set { SetValue(SectionDividerProperty, value); }
        }

        public static readonly DependencyProperty SelectedItemActiveProperty = DependencyProperty.Register("SelectedItemActive", typeof(Brush), typeof(VisualStudioUIService), new PropertyMetadata(null));

        public Brush SelectedItemActive
        {
            get { return (Brush)GetValue(SelectedItemActiveProperty); }
            set { SetValue(SelectedItemActiveProperty, value); }
        }

        public static readonly DependencyProperty SelectedItemActiveTextProperty = DependencyProperty.Register("SelectedItemActiveText", typeof(Brush), typeof(VisualStudioUIService), new PropertyMetadata(null));

        public Brush SelectedItemActiveText
        {
            get { return (Brush)GetValue(SelectedItemActiveTextProperty); }
            set { SetValue(SelectedItemActiveTextProperty, value); }
        }

        public static readonly DependencyProperty SelectedItemInactiveProperty = DependencyProperty.Register("SelectedItemInactive", typeof(Brush), typeof(VisualStudioUIService), new PropertyMetadata(null));

        public Brush SelectedItemInactive
        {
            get { return (Brush)GetValue(SelectedItemInactiveProperty); }
            set { SetValue(SelectedItemInactiveProperty, value); }
        }

        public static readonly DependencyProperty SelectedItemInactiveTextProperty = DependencyProperty.Register("SelectedItemInactiveText", typeof(Brush), typeof(VisualStudioUIService), new PropertyMetadata(null));

        public Brush SelectedItemInactiveText
        {
            get { return (Brush)GetValue(SelectedItemInactiveTextProperty); }
            set { SetValue(SelectedItemInactiveTextProperty, value); }
        }

        public static readonly DependencyProperty TemplateInfoPageDescriptionProperty = DependencyProperty.Register("TemplateInfoPageDescription", typeof(Brush), typeof(VisualStudioUIService), new PropertyMetadata(null));

        public Brush TemplateInfoPageDescription
        {
            get { return (Brush)GetValue(TemplateInfoPageDescriptionProperty); }
            set { SetValue(TemplateInfoPageDescriptionProperty, value); }
        }

        public static readonly DependencyProperty WindowBorderProperty = DependencyProperty.Register("WindowBorder", typeof(Brush), typeof(VisualStudioUIService), new PropertyMetadata(null));

        public Brush WindowBorder
        {
            get { return (Brush)GetValue(WindowBorderProperty); }
            set { SetValue(WindowBorderProperty, value); }
        }

        public static readonly DependencyProperty WindowPanelProperty = DependencyProperty.Register("WindowPanel", typeof(Brush), typeof(VisualStudioUIService), new PropertyMetadata(null));

        public Brush WindowPanel
        {
            get { return (Brush)GetValue(WindowPanelProperty); }
            set { SetValue(WindowPanelProperty, value); }
        }

        public static readonly DependencyProperty WindowPanelColorProperty = DependencyProperty.Register("WindowPanelColor", typeof(System.Drawing.Color), typeof(VisualStudioUIService), new PropertyMetadata(null));

        public System.Drawing.Color WindowPanelColor
        {
            get { return (System.Drawing.Color)GetValue(WindowPanelColorProperty); }
            set { SetValue(WindowPanelColorProperty, value); }
        }

        public static readonly DependencyProperty WindowPanelTextProperty = DependencyProperty.Register("WindowPanelText", typeof(Brush), typeof(VisualStudioUIService), new PropertyMetadata(null));

        public Brush WindowPanelText
        {
            get { return (Brush)GetValue(WindowPanelTextProperty); }
            set { SetValue(WindowPanelTextProperty, value); }
        }

        public static readonly DependencyProperty WindowPanelTextColorProperty = DependencyProperty.Register("WindowPanelTextColor", typeof(System.Drawing.Color), typeof(VisualStudioUIService), new PropertyMetadata(null));

        public System.Drawing.Color WindowPanelTextColor
        {
            get { return (System.Drawing.Color)GetValue(WindowPanelTextColorProperty); }
            set { SetValue(WindowPanelTextColorProperty, value); }
        }

        public static readonly DependencyProperty WizardFooterProperty = DependencyProperty.Register("WizardFooter", typeof(Brush), typeof(VisualStudioUIService), new PropertyMetadata(null));

        public Brush WizardFooter
        {
            get { return (Brush)GetValue(WizardFooterProperty); }
            set { SetValue(WizardFooterProperty, value); }
        }

        public static readonly DependencyProperty WizardFooterTextProperty = DependencyProperty.Register("WizardFooterText", typeof(Brush), typeof(VisualStudioUIService), new PropertyMetadata(null));

        public Brush WizardFooterText
        {
            get { return (Brush)GetValue(WizardFooterTextProperty); }
            set { SetValue(WizardFooterTextProperty, value); }
        }

        public static readonly DependencyProperty IBButtonProperty = DependencyProperty.Register("IBButton", typeof(Brush), typeof(VisualStudioUIService), new PropertyMetadata(null));

        public Brush IBButton
        {
            get { return (Brush)GetValue(IBButtonProperty); }
            set { SetValue(IBButtonProperty, value); }
        }

        public static readonly DependencyProperty IBButtonBorderProperty = DependencyProperty.Register("IBButtonBorder", typeof(Brush), typeof(VisualStudioUIService), new PropertyMetadata(null));

        public Brush IBButtonBorder
        {
            get { return (Brush)GetValue(IBButtonBorderProperty); }
            set { SetValue(IBButtonBorderProperty, value); }
        }

        public static readonly DependencyProperty IBButtonDisabledProperty = DependencyProperty.Register("IBButtonDisabled", typeof(Brush), typeof(VisualStudioUIService), new PropertyMetadata(null));

        public Brush IBButtonDisabled
        {
            get { return (Brush)GetValue(IBButtonDisabledProperty); }
            set { SetValue(IBButtonDisabledProperty, value); }
        }

        public static readonly DependencyProperty IBButtonDisabledBorderProperty = DependencyProperty.Register("IBButtonDisabledBorder", typeof(Brush), typeof(VisualStudioUIService), new PropertyMetadata(null));

        public Brush IBButtonDisabledBorder
        {
            get { return (Brush)GetValue(IBButtonDisabledBorderProperty); }
            set { SetValue(IBButtonDisabledBorderProperty, value); }
        }

        public static readonly DependencyProperty IBButtonFocusProperty = DependencyProperty.Register("IBButtonFocus", typeof(Brush), typeof(VisualStudioUIService), new PropertyMetadata(null));

        public Brush IBButtonFocus
        {
            get { return (Brush)GetValue(IBButtonFocusProperty); }
            set { SetValue(IBButtonFocusProperty, value); }
        }

        public static readonly DependencyProperty IBButtonFocusBorderProperty = DependencyProperty.Register("IBButtonFocusBorder", typeof(Brush), typeof(VisualStudioUIService), new PropertyMetadata(null));

        public Brush IBButtonFocusBorder
        {
            get { return (Brush)GetValue(IBButtonFocusBorderProperty); }
            set { SetValue(IBButtonFocusBorderProperty, value); }
        }

        public static readonly DependencyProperty IBButtonMouseDownProperty = DependencyProperty.Register("IBButtonMouseDown", typeof(Brush), typeof(VisualStudioUIService), new PropertyMetadata(null));

        public Brush IBButtonMouseDown
        {
            get { return (Brush)GetValue(IBButtonMouseDownProperty); }
            set { SetValue(IBButtonMouseDownProperty, value); }
        }

        public static readonly DependencyProperty IBButtonMouseDownBorderProperty = DependencyProperty.Register("IBButtonMouseDownBorder", typeof(Brush), typeof(VisualStudioUIService), new PropertyMetadata(null));

        public Brush IBButtonMouseDownBorder
        {
            get { return (Brush)GetValue(IBButtonMouseDownBorderProperty); }
            set { SetValue(IBButtonMouseDownBorderProperty, value); }
        }

        public static readonly DependencyProperty IBButtonMouseOverProperty = DependencyProperty.Register("IBButtonMouseOver", typeof(Brush), typeof(VisualStudioUIService), new PropertyMetadata(null));

        public Brush IBButtonMouseOver
        {
            get { return (Brush)GetValue(IBButtonMouseOverProperty); }
            set { SetValue(IBButtonMouseOverProperty, value); }
        }

        public static readonly DependencyProperty IBButtonMouseOverBorderProperty = DependencyProperty.Register("IBButtonMouseOverBorder", typeof(Brush), typeof(VisualStudioUIService), new PropertyMetadata(null));

        public Brush IBButtonMouseOverBorder
        {
            get { return (Brush)GetValue(IBButtonMouseOverBorderProperty); }
            set { SetValue(IBButtonMouseOverBorderProperty, value); }
        }

        public static readonly DependencyProperty IBCloseButtonProperty = DependencyProperty.Register("IBCloseButton", typeof(Brush), typeof(VisualStudioUIService), new PropertyMetadata(null));

        public Brush IBCloseButton
        {
            get { return (Brush)GetValue(IBCloseButtonProperty); }
            set { SetValue(IBCloseButtonProperty, value); }
        }

        public static readonly DependencyProperty IBCloseButtonBorderProperty = DependencyProperty.Register("IBCloseButtonBorder", typeof(Brush), typeof(VisualStudioUIService), new PropertyMetadata(null));

        public Brush IBCloseButtonBorder
        {
            get { return (Brush)GetValue(IBCloseButtonBorderProperty); }
            set { SetValue(IBCloseButtonBorderProperty, value); }
        }

        public static readonly DependencyProperty IBCloseButtonDownProperty = DependencyProperty.Register("IBCloseButtonDown", typeof(Brush), typeof(VisualStudioUIService), new PropertyMetadata(null));

        public Brush IBCloseButtonDown
        {
            get { return (Brush)GetValue(IBCloseButtonDownProperty); }
            set { SetValue(IBCloseButtonDownProperty, value); }
        }

        public static readonly DependencyProperty IBCloseButtonDownBorderProperty = DependencyProperty.Register("IBCloseButtonDownBorder", typeof(Brush), typeof(VisualStudioUIService), new PropertyMetadata(null));

        public Brush IBCloseButtonDownBorder
        {
            get { return (Brush)GetValue(IBCloseButtonDownBorderProperty); }
            set { SetValue(IBCloseButtonDownBorderProperty, value); }
        }

        public static readonly DependencyProperty IBCloseButtonDownGlyphProperty = DependencyProperty.Register("IBCloseButtonDownGlyph", typeof(Brush), typeof(VisualStudioUIService), new PropertyMetadata(null));

        public Brush IBCloseButtonDownGlyph
        {
            get { return (Brush)GetValue(IBCloseButtonDownGlyphProperty); }
            set { SetValue(IBCloseButtonDownGlyphProperty, value); }
        }

        public static readonly DependencyProperty IBCloseButtonGlyphProperty = DependencyProperty.Register("IBCloseButtonGlyph", typeof(Brush), typeof(VisualStudioUIService), new PropertyMetadata(null));

        public Brush IBCloseButtonGlyph
        {
            get { return (Brush)GetValue(IBCloseButtonGlyphProperty); }
            set { SetValue(IBCloseButtonGlyphProperty, value); }
        }

        public static readonly DependencyProperty IBCloseButtonHoverProperty = DependencyProperty.Register("IBCloseButtonHover", typeof(Brush), typeof(VisualStudioUIService), new PropertyMetadata(null));

        public Brush IBCloseButtonHover
        {
            get { return (Brush)GetValue(IBCloseButtonHoverProperty); }
            set { SetValue(IBCloseButtonHoverProperty, value); }
        }

        public static readonly DependencyProperty IBCloseButtonHoverBorderProperty = DependencyProperty.Register("IBCloseButtonHoverBorder", typeof(Brush), typeof(VisualStudioUIService), new PropertyMetadata(null));

        public Brush IBCloseButtonHoverBorder
        {
            get { return (Brush)GetValue(IBCloseButtonHoverBorderProperty); }
            set { SetValue(IBCloseButtonHoverBorderProperty, value); }
        }

        public static readonly DependencyProperty IBCloseButtonHoverGlyphProperty = DependencyProperty.Register("IBCloseButtonHoverGlyph", typeof(Brush), typeof(VisualStudioUIService), new PropertyMetadata(null));

        public Brush IBCloseButtonHoverGlyph
        {
            get { return (Brush)GetValue(IBCloseButtonHoverGlyphProperty); }
            set { SetValue(IBCloseButtonHoverGlyphProperty, value); }
        }

        public static readonly DependencyProperty IBInfoBarBackgroundProperty = DependencyProperty.Register("IBInfoBarBackground", typeof(Brush), typeof(VisualStudioUIService), new PropertyMetadata(null));

        public Brush IBInfoBarBackground
        {
            get { return (Brush)GetValue(IBInfoBarBackgroundProperty); }
            set { SetValue(IBInfoBarBackgroundProperty, value); }
        }

        public static readonly DependencyProperty IBInfoBarBackgroundTextProperty = DependencyProperty.Register("IBInfoBarBackgroundText", typeof(Brush), typeof(VisualStudioUIService), new PropertyMetadata(null));

        public Brush IBInfoBarBackgroundText
        {
            get { return (Brush)GetValue(IBInfoBarBackgroundTextProperty); }
            set { SetValue(IBInfoBarBackgroundTextProperty, value); }
        }

        public static readonly DependencyProperty IBInfoBarBorderProperty = DependencyProperty.Register("IBInfoBarBorder", typeof(Brush), typeof(VisualStudioUIService), new PropertyMetadata(null));

        public Brush IBInfoBarBorder
        {
            get { return (Brush)GetValue(IBInfoBarBorderProperty); }
            set { SetValue(IBInfoBarBorderProperty, value); }
        }


        public static readonly DependencyProperty ListItemTextProperty = DependencyProperty.Register("ListItemText", typeof(Brush), typeof(VisualStudioUIService), new PropertyMetadata(null));

        public Brush ListItemText
        {
            get { return (Brush)GetValue(ListItemTextProperty); }
            set { SetValue(ListItemTextProperty, value); }
        }

        public static readonly DependencyProperty ListItemTextDisabledProperty = DependencyProperty.Register("ListItemTextDisabled", typeof(Brush), typeof(VisualStudioUIService), new PropertyMetadata(null));

        public Brush ListItemTextDisabled
        {
            get { return (Brush)GetValue(ListItemTextDisabledProperty); }
            set { SetValue(ListItemTextDisabledProperty, value); }
        }
    }
}

