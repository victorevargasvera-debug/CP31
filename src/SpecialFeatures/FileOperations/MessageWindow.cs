namespace SpecialFeatures.FileOperations
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Windows;
    using System.Windows.Controls;
    using System.Windows.Input;
    using System.Windows.Markup;

    public class MessageWindow : Window, IComponentConnector
    {
        internal Label operationLabel;
        internal TextBox ProgText;
        private bool a;

        public MessageWindow();
        public MessageWindow(string messageText);
        internal MessageWindow(string messageText, string title);
        [DebuggerNonUserCode, GeneratedCode("PresentationBuildTasks", "5.0.10.0")]
        public void InitializeComponent();
        private void ObButtonClick_Close(object A_0, RoutedEventArgs A_1);
        [EditorBrowsable(1), DebuggerNonUserCode, GeneratedCode("PresentationBuildTasks", "5.0.10.0")]
        void IComponentConnector.Connect(int connectionId, object target);
        private void Window_MouseLeftButtonDown(object A_0, MouseButtonEventArgs A_1);
    }
}

