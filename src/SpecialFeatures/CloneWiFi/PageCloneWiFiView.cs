namespace SpecialFeatures.CloneWiFi
{
    using AcpUI;
    using Infragistics.Windows.DataPresenter;
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Windows;
    using System.Windows.Controls;
    using System.Windows.Markup;

    public class PageCloneWiFiView : AcpPageFeature, IComponentConnector
    {
        internal Label LblCloneWiFiDescription;
        internal AcpXamDataPresenter ExpanderWifiConfiguredNetworksList;
        internal UnboundField DataWideFeatureName_Col;
        internal UnboundField DataWideWiFiNetworkSSID_42519_Col;
        internal UnboundField DataWideWiFiNetworkEncryptedNetworkPassword_42517_Col;
        internal Label LblCloneWiFiWarning;
        internal Button buttonOK;
        internal Button buttonCancel;
        internal Button buttonHelp;
        private bool a;

        public PageCloneWiFiView();
        [DebuggerNonUserCode, GeneratedCode("PresentationBuildTasks", "5.0.10.0")]
        public void InitializeComponent();
        public override void OnLoaded(object sender, RoutedEventArgs e);
        protected override void OnRenderSizeChanged(SizeChangedInfo sizeInfo);
        public override void SetDataContext();
        [EditorBrowsable(1), DebuggerNonUserCode, GeneratedCode("PresentationBuildTasks", "5.0.10.0")]
        void IComponentConnector.Connect(int connectionId, object target);
    }
}

