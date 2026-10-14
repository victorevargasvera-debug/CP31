namespace SpecialFeatures.DepotLabtool
{
    using System;
    using System.CodeDom.Compiler;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Runtime.CompilerServices;
    using System.Windows;
    using System.Windows.Controls;
    using System.Windows.Markup;
    using System.Windows.Media;

    public class DepotCreateCodeplugWnd : Window, IComponentConnector
    {
        private bool a;
        private bool b;
        private bool c;
        private string d;
        private const string e = "APX5000";
        private const string f = "APX5500";
        private const string g = "APX6000";
        private const string h = "APX6500";
        private const string i = "I";
        private Dictionary<int, Dictionary<string, string>> j;
        private PCIHandler k;
        [CompilerGenerated]
        private List<string> l;
        internal Label label1;
        internal ComboBox cmbRadio;
        internal Label label3;
        internal ComboBox cmbModelNum;
        internal Label label4;
        internal Label label5;
        internal TextBox txtFlashCode1;
        internal Label label6;
        internal TextBox txtFlashCode2;
        internal Label label7;
        internal TextBox txtFlashCodeCheckSum;
        internal Button btnOK;
        internal Button btnCancel;
        internal TextBox txtSerNum;
        internal Label labelRegion;
        internal ComboBox cmbRegion;
        internal CheckBox cbULP;
        internal CheckBox cbAPX6000P25;
        internal CheckBox cbMariTimeRadio;
        internal CheckBox cbDualKnobs;
        internal CheckBox cbDisableEnc;
        private bool m;

        public DepotCreateCodeplugWnd();
        private void a(string A_0);
        private void a(Dictionary<string, string> A_0, string A_1, string A_2);
        private void b();
        private void btnCancel_Click(object A_0, RoutedEventArgs A_1);
        private void btnOK_Click(object A_0, RoutedEventArgs A_1);
        private void c();
        private void cmbModelNum_SelectionChanged(object A_0, SelectionChangedEventArgs A_1);
        private void cmbRegion_SelectionChanged(object A_0, SelectionChangedEventArgs A_1);
        private void d();
        private void e();
        [DebuggerNonUserCode, GeneratedCode("PresentationBuildTasks", "5.0.10.0")]
        public void InitializeComponent();
        private void SelectModel(object A_0, RoutedEventArgs A_1);
        [EditorBrowsable(1), DebuggerNonUserCode, GeneratedCode("PresentationBuildTasks", "5.0.10.0")]
        void IComponentConnector.Connect(int connectionId, object target);
        private void txtFlashCode_TextChanged(object A_0, TextChangedEventArgs A_1);
        private void txtSerNum_TextChanged(object A_0, TextChangedEventArgs A_1);

        public string ModelNum { get; }

        public string SerNum { get; }

        public string FlashCode { get; set; }

        public List<string> DepotOptions { get; internal set; }

        private Brush NormalBorder { get; }
    }
}

