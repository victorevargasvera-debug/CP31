namespace SpecialFeatures.Programming
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Windows;
    using System.Windows.Controls;
    using System.Windows.Markup;

    public class USBProgrammingWindow : Window, IComponentConnector
    {
        private ProgrammingOperation a;
        internal StackPanel ProgrammingPanel;
        internal Label operationLabel;
        internal Button btnOperation;
        internal Button btnCancel;
        internal Button btnHelp;
        private bool b;

        public USBProgrammingWindow();
        internal USBProgrammingWindow(ProgrammingOperation operation);
        private void btnCancel_Click(object A_0, RoutedEventArgs A_1);
        private void btnHelp_Click(object A_0, RoutedEventArgs A_1);
        private void btnOperation_Click(object A_0, RoutedEventArgs A_1);
        [GeneratedCode("PresentationBuildTasks", "5.0.10.0"), DebuggerNonUserCode]
        public void InitializeComponent();
        [EditorBrowsable(1), DebuggerNonUserCode, GeneratedCode("PresentationBuildTasks", "5.0.10.0")]
        void IComponentConnector.Connect(int connectionId, object target);
    }
}

