namespace SpecialFeatures.SystemCertificates.List
{
    using AcpUI;
    using AcpUI.Common;
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Windows;
    using System.Windows.Controls;
    using System.Windows.Documents;
    using System.Windows.Markup;

    public class SystemCertificateListPage : AcpPageFeature, IComponentConnector
    {
        private bool a;
        internal AcpParentRecNavToolbar RecNavToolbarPageSystemCertificateList;
        internal AcpThemeBase ThemeBaseObj;
        internal Hyperlink HLinkSystemCertificateGeneral;
        internal StackPanel MyStackPanel;
        internal AcpExpander ExpanderSystemCertificateGeneral;
        internal Grid ExpanderSystemCertificateGeneralGrid;
        internal AcpGroupBox GrpBoxExpanderSystemCertificateListGeneralPseudo0;
        internal Grid StdGrpBoxExpanderSystemCertificateGeneralPseudo0;
        internal AcpCustomViewCheckBox CVBtnSystemCertificateName;
        internal AcpLabel LblSystemCertificateName;
        internal AcpTextBox SecSysCertGeneralKeyofSystemCertificates_A43633;
        internal AcpCustomViewCheckBox CVBtnSystemCertificateFileName_A43634;
        internal AcpLabel LblSystemCertificateFileName_A43634;
        internal AcpTextBoxFileBrowser SecSysCertGeneralCertificateFilename_A43634;
        internal Grid CompGrpBoxExpanderSystemCertificateGeneralPseudo0;
        internal AcpCopyButton CpyBtnSystemCertificateFileName_A43634;
        internal AcpViewOnlyCtrl SystemCertificateFileName_A43634Comp;
        private bool b;

        public SystemCertificateListPage();
        private void a(object A_0);
        private void HLinkSystemCertificateClick(object A_0, RoutedEventArgs A_1);
        [GeneratedCode("PresentationBuildTasks", "5.0.10.0"), DebuggerNonUserCode]
        public void InitializeComponent();
        private void OnFieldNameDoubleClick(object A_0, RoutedEventArgs A_1);
        public override void OnLoaded(object sender, RoutedEventArgs e);
        private void OnModeClick(object A_0, RoutedEventArgs A_1);
        public override void OnUnloaded(object sender, RoutedEventArgs e);
        public override void SetDataContext();
        [EditorBrowsable(1), DebuggerNonUserCode, GeneratedCode("PresentationBuildTasks", "5.0.10.0")]
        void IComponentConnector.Connect(int connectionId, object target);
    }
}

