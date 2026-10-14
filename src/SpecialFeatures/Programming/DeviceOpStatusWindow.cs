namespace SpecialFeatures.Programming
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Threading;
    using System.Windows;
    using System.Windows.Controls;
    using System.Windows.Markup;

    public class DeviceOpStatusWindow : Window, IDisposable, IComponentConnector
    {
        private bool a;
        private EventWaitHandle b;
        private EventWaitHandle c;
        private string d;
        internal TextBox statusText;
        private bool e;

        internal DeviceOpStatusWindow();
        private void a(bool A_0);
        public void Dispose();
        [DebuggerNonUserCode, GeneratedCode("PresentationBuildTasks", "5.0.10.0")]
        public void InitializeComponent();
        internal void Run();
        [EditorBrowsable(1), GeneratedCode("PresentationBuildTasks", "5.0.10.0"), DebuggerNonUserCode]
        void IComponentConnector.Connect(int connectionId, object target);

        public string StatusMsg { set; }

        internal EventWaitHandle WaitStatusThread { set; }

        internal EventWaitHandle CloseEventHandle { get; set; }
    }
}

