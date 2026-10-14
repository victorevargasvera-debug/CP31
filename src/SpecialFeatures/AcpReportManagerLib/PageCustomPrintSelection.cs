namespace SpecialFeatures.AcpReportManagerLib
{
    using AcpCommonLib;
    using System;
    using System.CodeDom.Compiler;
    using System.Collections;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Runtime.CompilerServices;
    using System.Windows;
    using System.Windows.Controls;
    using System.Windows.Input;
    using System.Windows.Markup;
    using System.Windows.Navigation;
    using System.Xml;

    public class PageCustomPrintSelection : PageFunction<string>, IComponentConnector
    {
        private ArrayList a;
        private Window b;
        internal Grid gReportsChoices;
        internal ListView lstUIValue;
        internal Button btnPrtHelp;
        internal Button btnPrtPreview;
        internal Button btnPrtSelectAll;
        internal Button btnPrtUnSelectAll;
        internal Button btnPrtCreateTpl;
        internal Button btnPrtEditTpl;
        internal Button btnPrtDelTpl;
        internal Button btnCancel;
        internal Image imgMotologo;
        internal Label lblSelectionTitle;
        internal RadioButton radBtnFeatures;
        internal RadioButton radBtnTemplates;
        private bool c;

        internal PageCustomPrintSelection();
        private void a();
        private bool a(IAcpFeatureSection A_0);
        private bool a(IAcpFeatureNode A_0, IAcpFeatureSection A_1);
        private bool a(PageCustomPrintSelection.fileAction A_0, ref string A_1);
        internal bool BuildCustomPrintSelection();
        internal bool BuildFeatureXMLData();
        internal void BuildPrintChoicesReport();
        internal bool BuildTemplateFileXMLData(string fileName);
        private void F1HelpCommandCanExcute(object A_0, CanExecuteRoutedEventArgs A_1);
        [GeneratedCode("PresentationBuildTasks", "5.0.10.0"), DebuggerNonUserCode]
        public void InitializeComponent();
        public void InitializeData(object sender, EventArgs e);
        public override void OnApplyTemplate();
        private void OnCreateTemplate(object A_0, RoutedEventArgs A_1);
        private void OnDelTemplate(object A_0, RoutedEventArgs A_1);
        private void OnEditTemplate(object A_0, RoutedEventArgs A_1);
        private void OnFeatureSelected(object A_0, RoutedEventArgs A_1);
        private void OnHelp(object A_0, RoutedEventArgs A_1);
        internal void OnPrtPreview(object sender, RoutedEventArgs e);
        internal void OnPrtSelCancel(object sender, RoutedEventArgs e);
        internal void OnPrtSelectAll(object sender, RoutedEventArgs e);
        internal void OnPrtUnSelectAll(object sender, RoutedEventArgs e);
        private void OnSelectExistingTemplateFile(object A_0, RoutedEventArgs A_1);
        private void OnTemplateSelected(object A_0, RoutedEventArgs A_1);
        [DebuggerNonUserCode, EditorBrowsable(1), GeneratedCode("PresentationBuildTasks", "5.0.10.0")]
        void IComponentConnector.Connect(int connectionId, object target);

        public Window ParenWnd { set; }

        [CompilerGenerated]
        private sealed class <>c__DisplayClass27_0
        {
            public PageCustomPrintSelection <>4__this;
            public List<int> lstSectionItemsId;
            public List<string> lstFieldName;
            public XmlTextWriter tWriter;

            public <>c__DisplayClass27_0();
            internal void <BuildTemplateFileXMLData>b__0(int featureID);
        }

        private enum fileAction
        {
            display,
            edit,
            del
        }

        public enum ItemType
        {
            Parent,
            Child,
            GrandChild
        }
    }
}

