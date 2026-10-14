namespace SpecialFeatures.RadioFeatureSet
{
    using AcpUI;
    using AcpUI.Common;
    using AcpUILib;
    using Infragistics.Windows.DataPresenter.Events;
    using SpecialFeatures.Flashport;
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Runtime.CompilerServices;
    using System.Windows;
    using System.Windows.Controls;
    using System.Windows.Documents;
    using System.Windows.Input;
    using System.Windows.Markup;

    public class PageRadioFeatureSet : AcpPageFeature, IAcpPageFeature, IComponentConnector
    {
        private RadioFeatureSetRecset a;
        private Recordset b;
        internal AcpThemeBase ThemeBaseObj;
        internal Hyperlink HLinkRadioFeatureSetGeneral;
        internal Hyperlink HLinkRadioFeatureSetUsed;
        internal Hyperlink HLinkRadioExtendedFeatureSetUsed;
        internal StackPanel MyStackPanel;
        internal AcpExpander ExpanderRadioFeatureSetGeneral;
        internal AcpGroupBox GrpBoxExpanderRadioFeatureSetGeneralPseudo0;
        internal Grid StdGrpBoxExpanderRadioFeatureSetGeneralPseudo0;
        internal AcpLabel LblFeatureSetGeneralPurchasedFLASHcode;
        internal AcpTextBox FeatureSetGeneralPurchasedFLASHcode;
        internal AcpLabel LblFeatureSetGeneralUsedFLASHcode;
        internal AcpTextBox FeatureSetGeneralUsedFLASHcode;
        internal AcpExpander ExpanderRadioFeatureSetUsed;
        internal AcpXamDataPresenter ExpanderRadioFeatureSetUsedTable;
        internal AcpExpander ExpanderRadioExtendedFeatureSetUsed;
        internal AcpXamDataPresenter ExpanderRadioExtendedFeatureSetUsedTable;
        internal Button buttonClose;
        internal Button buttonHelp;
        private bool c;

        public PageRadioFeatureSet();
        private void a();
        private void a(string A_0, bool A_1, PageRadioFeatureSet.PCIExcisedConstraint A_2);
        private void b();
        private void buttonClose_Click(object A_0, RoutedEventArgs A_1);
        private void buttonHelp_Click(object A_0, RoutedEventArgs A_1);
        private void c();
        internal bool Calculate();
        private void ExpanderRadioFeatureSetUsedTable_RecordActivating(object A_0, RecordActivatingEventArgs A_1);
        private void F1HelpCommandCanExcute(object A_0, CanExecuteRoutedEventArgs A_1);
        private void HLinkClick(object A_0, RoutedEventArgs A_1);
        [DebuggerNonUserCode, GeneratedCode("PresentationBuildTasks", "5.0.10.0")]
        public void InitializeComponent();
        private void OnFieldNameDoubleClick(object A_0, RoutedEventArgs A_1);
        public override void OnLoaded(object sender, RoutedEventArgs e);
        public override void SetDataContext();
        [EditorBrowsable(1), DebuggerNonUserCode, GeneratedCode("PresentationBuildTasks", "5.0.10.0")]
        void IComponentConnector.Connect(int connectionId, object target);

        public RadioFeatureSetRecset FeatSetRecSet { get; }

        public delegate bool PCIExcisedConstraint();
    }
}

