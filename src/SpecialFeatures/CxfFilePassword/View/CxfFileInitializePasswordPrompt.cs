namespace SpecialFeatures.CxfFilePassword.View
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Windows;
    using System.Windows.Controls;
    using System.Windows.Markup;

    public class CxfFileInitializePasswordPrompt : Window, IComponentConnector
    {
        internal PasswordBox CxfFilePasswordBox;
        internal PasswordBox CxfFileRepeatPasswordBox;
        private bool a;

        public CxfFileInitializePasswordPrompt();
        private void CxfFilePasswordBoxChanged(object A_0, RoutedEventArgs A_1);
        private void CxfFileRepeatPasswordBoxChanged(object A_0, RoutedEventArgs A_1);
        [GeneratedCode("PresentationBuildTasks", "5.0.10.0"), DebuggerNonUserCode]
        public void InitializeComponent();
        [EditorBrowsable(1), DebuggerNonUserCode, GeneratedCode("PresentationBuildTasks", "5.0.10.0")]
        void IComponentConnector.Connect(int connectionId, object target);
    }
}

