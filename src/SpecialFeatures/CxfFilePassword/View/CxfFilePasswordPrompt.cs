namespace SpecialFeatures.CxfFilePassword.View
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Windows;
    using System.Windows.Controls;
    using System.Windows.Markup;

    public class CxfFilePasswordPrompt : Window, IComponentConnector
    {
        internal TextBlock FileNameTextBlock;
        internal PasswordBox CxfFilePasswordBox;
        private bool a;

        public CxfFilePasswordPrompt();
        [GeneratedCode("PresentationBuildTasks", "5.0.10.0"), DebuggerNonUserCode]
        public void InitializeComponent();
        [EditorBrowsable(1), DebuggerNonUserCode, GeneratedCode("PresentationBuildTasks", "5.0.10.0")]
        void IComponentConnector.Connect(int connectionId, object target);
    }
}

