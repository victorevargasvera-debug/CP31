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
    using System.Windows.Navigation;
    using System.Windows.Shapes;

    public class BrowseForFilePage : PageFunction<DialogResult>, IComponentConnector
    {
        [CompilerGenerated]
        private SpecialFeatures.FileOperations.FileOperationData a;
        [CompilerGenerated]
        private readonly Action<BrowseForFilePage> b;
        internal Grid Main;
        internal Rectangle Divider;
        internal Grid Header;
        internal Label ViewboxTitle;
        internal Grid SelectUpgradeFile1;
        internal Label TitleContent;
        internal TextBox TxtBoxFilePath;
        internal Button HelpBtn;
        internal Button ActionBtn;
        private bool c;

        internal BrowseForFilePage(SpecialFeatures.FileOperations.FileOperationData fileOperationData, Action<BrowseForFilePage> action);
        [DebuggerNonUserCode, GeneratedCode("PresentationBuildTasks", "5.0.10.0")]
        public void InitializeComponent();
        private void OnButtonClickAction(object A_0, RoutedEventArgs A_1);
        private void OnButtonClickBrowse(object A_0, RoutedEventArgs A_1);
        private void OnButtonClickCancel(object A_0, RoutedEventArgs A_1);
        private void OnButtonClickF1Help(object A_0, RoutedEventArgs A_1);
        private void OnF1HelpCommandCanExcute(object A_0, CanExecuteRoutedEventArgs A_1);
        private void OnLoaded(object A_0, RoutedEventArgs A_1);
        public void OnPageReturn(object sender, ReturnEventArgs<DialogResult> e);
        [EditorBrowsable(1), GeneratedCode("PresentationBuildTasks", "5.0.10.0"), DebuggerNonUserCode]
        void IComponentConnector.Connect(int connectionId, object target);

        public SpecialFeatures.FileOperations.FileOperationData FileOperationData { get; set; }

        public Action<BrowseForFilePage> Action { get; }
    }
}

