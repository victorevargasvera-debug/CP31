namespace SpecialFeatures.DepotLabtool
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
        public MessageWindow(string messageText, string title);
        [GeneratedCode("PresentationBuildTasks", "5.0.10.0"), DebuggerNonUserCode]
        public void InitializeComponent();
        private void ObButtonClick_Close(object A_0, RoutedEventArgs A_1);
        [DebuggerNonUserCode, GeneratedCode("PresentationBuildTasks", "5.0.10.0"), EditorBrowsable(1)]
        void IComponentConnector.Connect(int connectionId, object target);
        private void Window_MouseLeftButtonDown(object A_0, MouseButtonEventArgs A_1);
    }
}

