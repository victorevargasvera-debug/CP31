namespace SpecialFeatures.FileOperations
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Runtime.CompilerServices;
    using System.Windows;
    using System.Windows.Controls;
    using System.Windows.Input;
    using System.Windows.Markup;

    public class BrowseForFileDialogBox : Window, IComponentConnector
    {
        private readonly Type a;
        private bool b;
        [CompilerGenerated]
        private SpecialFeatures.FileOperations.FileOperationData c;
        internal Label operationLabel;
        internal Frame BrowseForFileMainFrame;
        private bool d;

        public BrowseForFileDialogBox(Action<BrowseForFilePage> action, SpecialFeatures.FileOperations.FileOperationData fileOperationData, Type expectedProgressPageType);
        private void a(object A_0, FileOperationReturnEventArgs A_1);
        [GeneratedCode("PresentationBuildTasks", "5.0.10.0"), DebuggerNonUserCode]
        public void InitializeComponent();
        private void NavigationWindow_Closing(object A_0, CancelEventArgs A_1);
        [EditorBrowsable(1), GeneratedCode("PresentationBuildTasks", "5.0.10.0"), DebuggerNonUserCode]
        void IComponentConnector.Connect(int connectionId, object target);
        private void Window_MouseLeftButtonDown(object A_0, MouseButtonEventArgs A_1);

        public SpecialFeatures.FileOperations.FileOperationData FileOperationData { get; private set; }
    }
}

