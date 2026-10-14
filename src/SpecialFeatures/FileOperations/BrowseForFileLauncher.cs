namespace SpecialFeatures.FileOperations
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Runtime.CompilerServices;
    using System.Windows.Markup;
    using System.Windows.Navigation;

    public class BrowseForFileLauncher : PageFunction<DialogResult>, IComponentConnector
    {
        [CompilerGenerated]
        private FileOperationReturnEventHandler a;
        [CompilerGenerated]
        private readonly Action<BrowseForFilePage> b;
        [CompilerGenerated]
        private SpecialFeatures.FileOperations.FileOperationData c;
        private bool d;

        public event FileOperationReturnEventHandler FileOperationReturn;

        public BrowseForFileLauncher(Action<BrowseForFilePage> action, SpecialFeatures.FileOperations.FileOperationData fileOperationData);
        [GeneratedCode("PresentationBuildTasks", "5.0.10.0"), DebuggerNonUserCode]
        public void InitializeComponent();
        internal void OnBrowseForFileReturn(object sender, ReturnEventArgs<DialogResult> e);
        protected override void Start();
        [DebuggerNonUserCode, EditorBrowsable(1), GeneratedCode("PresentationBuildTasks", "5.0.10.0")]
        void IComponentConnector.Connect(int connectionId, object target);

        public Action<BrowseForFilePage> Action { get; }

        internal SpecialFeatures.FileOperations.FileOperationData FileOperationData { get; set; }
    }
}

