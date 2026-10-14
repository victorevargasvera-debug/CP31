namespace SpecialFeatures.CBISerialNum
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Windows;
    using System.Windows.Controls;
    using System.Windows.Input;
    using System.Windows.Markup;

    public class CbiSerNumWind : Window, IComponentConnector
    {
        private string a;
        internal CbiSerNumWind myCbiWindow;
        internal Label operationLabel;
        internal Grid Main;
        internal TextBox CbiSerEntry;
        internal StackPanel stackPanelError;
        internal Image imageError;
        internal TextBox textBoxError;
        private bool b;

        public CbiSerNumWind();
        private void buttonHelp_Click(object A_0, RoutedEventArgs A_1);
        private void CbiSerEntryCancel_Click(object A_0, RoutedEventArgs A_1);
        private void CbiSerEntryOK_Click(object A_0, RoutedEventArgs A_1);
        private void F1HelpCommandCanExcute(object A_0, CanExecuteRoutedEventArgs A_1);
        [GeneratedCode("PresentationBuildTasks", "5.0.10.0"), DebuggerNonUserCode]
        public void InitializeComponent();
        [GeneratedCode("PresentationBuildTasks", "5.0.10.0"), EditorBrowsable(1), DebuggerNonUserCode]
        void IComponentConnector.Connect(int connectionId, object target);

        public string SerNum { get; set; }
    }
}

