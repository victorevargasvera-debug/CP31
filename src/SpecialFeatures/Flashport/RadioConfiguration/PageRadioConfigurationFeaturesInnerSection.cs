namespace SpecialFeatures.Flashport.RadioConfiguration
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

    public class PageRadioConfigurationFeaturesInnerSection : AcpPageFeature, IComponentConnector
    {
        public CollectionView myCollectionView;
        internal Grid grid;
        internal AcpTextBox FkeyConfigFeatureName;
        internal AcpLabel LblRadioCfgFeaturesFeatureName;
        private bool a;

        internal PageRadioConfigurationFeaturesInnerSection(RadioConfigurationFeaturesInner record);
        [GeneratedCode("PresentationBuildTasks", "5.0.10.0"), DebuggerNonUserCode]
        public void InitializeComponent();
        private void OnFieldNameDoubleClick(object A_0, RoutedEventArgs A_1);
        public override void SetDataContext();
        [EditorBrowsable(1), DebuggerNonUserCode, GeneratedCode("PresentationBuildTasks", "5.0.10.0")]
        void IComponentConnector.Connect(int connectionId, object target);
    }
}

