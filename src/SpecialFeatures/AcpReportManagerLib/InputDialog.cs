namespace SpecialFeatures.AcpReportManagerLib
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Windows;
    using System.Windows.Controls;
    using System.Windows.Markup;

    public class InputDialog : Window, IComponentConnector
    {
        public bool click;
        private int a;
        internal TextBox txtUserInput;
        internal Button BtnOk;
        private bool b;

        internal InputDialog();
        [DebuggerNonUserCode, GeneratedCode("PresentationBuildTasks", "5.0.10.0")]
        public void InitializeComponent();
        internal void OnClick(object sender, RoutedEventArgs e);
        internal void OnClosed(object sender, EventArgs e);
        [DebuggerNonUserCode, EditorBrowsable(1), GeneratedCode("PresentationBuildTasks", "5.0.10.0")]
        void IComponentConnector.Connect(int connectionId, object target);

        internal int Page { get; set; }
    }
}

