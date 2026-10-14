namespace SpecialFeatures.RadioFeatureSet
{
    using AcpUI;
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Windows;
    using System.Windows.Controls;
    using System.Windows.Markup;

    public class PageFeatureSetInnerSection : AcpPageFeature, IComponentConnector
    {
        internal Grid grid;
        internal Grid StdGridGeneralGrp;
        internal AcpTextBox FeatureSetPurchasedFeatureName;
        internal AcpLabel LblFeatureSetPurchasedFeatureName;
        internal AcpTextBox FeatureSetEnabledInUsedFlashcode;
        internal AcpLabel LblFeatureSetEnabledInUsedFlashcode;
        private bool a;

        internal PageFeatureSetInnerSection(FeatureSetInner record);
        [GeneratedCode("PresentationBuildTasks", "5.0.10.0"), DebuggerNonUserCode]
        public void InitializeComponent();
        private void OnFieldNameDoubleClick(object A_0, RoutedEventArgs A_1);
        public override void SetDataContext();
        [GeneratedCode("PresentationBuildTasks", "5.0.10.0"), EditorBrowsable(1), DebuggerNonUserCode]
        void IComponentConnector.Connect(int connectionId, object target);
    }
}

