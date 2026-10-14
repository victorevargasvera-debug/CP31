namespace SpecialFeatures.Flashport.FlashRadio
{
    using AcpASKLib;
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Windows;
    using System.Windows.Controls;
    using System.Windows.Markup;

    public class OwnerSystemIDWnd : Window, IComponentConnector
    {
        private OwnerSystemData a;
        internal OwnerSystemIDWnd myOwnerSystemIDWindow;
        internal Label operationLabel;
        internal Grid Main;
        internal ComboBox CmboOwnerSystem;
        internal StackPanel stackPanelError;
        internal Image imageError;
        internal TextBlock textBoxError;
        private bool b;

        internal OwnerSystemIDWnd();
        private bool a(SystemKeyData A_0);
        [DebuggerNonUserCode, GeneratedCode("PresentationBuildTasks", "5.0.10.0")]
        public void InitializeComponent();
        private void OnCancel(object A_0, RoutedEventArgs A_1);
        private void OnOK(object A_0, RoutedEventArgs A_1);
        [GeneratedCode("PresentationBuildTasks", "5.0.10.0"), EditorBrowsable(1), DebuggerNonUserCode]
        void IComponentConnector.Connect(int connectionId, object target);

        internal OwnerSystemData OwnerSystemInfo { get; set; }
    }
}

