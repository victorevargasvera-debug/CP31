namespace SpecialFeatures.Ucl.HotList
{
    using AcpUI;
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Windows;
    using System.Windows.Data;
    using System.Windows.Markup;

    public class UclTrunkingT2CallHotListTblView : AcpPageFeature, IComponentConnector, IStyleConnector
    {
        private CollectionView a;
        private bool b;
        internal AcpRecNavToolbar RecNavToolbarPageUclTrunkingT2HotList;
        internal AcpXamDataPresenter UclTrunkingT2HotList;
        private bool c;

        public UclTrunkingT2CallHotListTblView();
        private void a(UclTrunkingT2CallHotList A_0);
        [GeneratedCode("PresentationBuildTasks", "5.0.10.0"), DebuggerNonUserCode]
        public void InitializeComponent();
        private void OnFieldNameDoubleClick(object A_0, RoutedEventArgs A_1);
        public override void OnLoaded(object sender, RoutedEventArgs e);
        private void OnModeClick(object A_0, RoutedEventArgs A_1);
        public override void OnUnloaded(object sender, RoutedEventArgs e);
        public override void SetDataContext();
        [GeneratedCode("PresentationBuildTasks", "5.0.10.0"), DebuggerNonUserCode, EditorBrowsable(1)]
        void IComponentConnector.Connect(int connectionId, object target);
        [EditorBrowsable(1), GeneratedCode("PresentationBuildTasks", "5.0.10.0"), DebuggerNonUserCode]
        void IStyleConnector.Connect(int connectionId, object target);
    }
}

