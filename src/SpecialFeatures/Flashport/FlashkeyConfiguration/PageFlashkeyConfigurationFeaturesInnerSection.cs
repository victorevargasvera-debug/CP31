namespace SpecialFeatures.Flashport.FlashkeyConfiguration
{
    using AcpUI;
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Windows;
    using System.Windows.Controls;
    using System.Windows.Data;
    using System.Windows.Markup;

    public class PageFlashkeyConfigurationFeaturesInnerSection : AcpPageFeature, IComponentConnector
    {
        internal CollectionView myCollectionView;
        internal Grid grid;
        internal AcpTextBox FkeyConfigFeatureName;
        internal AcpLabel LblFlashkeyCfgFeatureName;
        internal AcpTextBox FkeyConfigCurrentFlashcodeValue;
        internal AcpLabel LblFlashkeyCfgCurrentFlashcode;
        internal AcpTextBox FkeyConfigNewFlashcodeValue;
        internal AcpLabel LblFlashkeyCfgNewFlashcode;
        private bool a;

        internal PageFlashkeyConfigurationFeaturesInnerSection(FlashkeyConfigurationFeaturesInner record);
        [DebuggerNonUserCode, GeneratedCode("PresentationBuildTasks", "5.0.10.0")]
        public void InitializeComponent();
        private void OnFieldNameDoubleClick(object A_0, RoutedEventArgs A_1);
        public override void SetDataContext();
        [GeneratedCode("PresentationBuildTasks", "5.0.10.0"), DebuggerNonUserCode, EditorBrowsable(1)]
        void IComponentConnector.Connect(int connectionId, object target);
    }
}

