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

    public class DepotUpgradeCodeplugWnd : Window, IComponentConnector
    {
        private bool a;
        private bool b;
        private string c;
        private UpgradeRadioData d;
        private PCIHandler e;
        [CompilerGenerated]
        private List<string> f;
        internal GroupBox groupBox1;
        internal Grid grid1;
        internal Label label1;
        internal TextBox txtModelNumber;
        internal Label label3;
        internal TextBox txtSerNum;
        internal Label label2;
        internal TextBox txtFlashCode1;
        internal Label label5;
        internal TextBox txtFlashCode2;
        internal Label label6;
        internal TextBox txtFlashCodeCheckSum;
        internal CheckBox cbDisableEnc;
        internal Button btnOK;
        internal Button button2;
        private bool g;

        public DepotUpgradeCodeplugWnd();
        private void a();
        private static string[] a(string A_0);
        private static string a(string[] A_0);
        private void btnOK_Click(object A_0, RoutedEventArgs A_1);
        private void c();
        [GeneratedCode("PresentationBuildTasks", "5.0.10.0"), DebuggerNonUserCode]
        public void InitializeComponent();
        [EditorBrowsable(1), DebuggerNonUserCode, GeneratedCode("PresentationBuildTasks", "5.0.10.0")]
        void IComponentConnector.Connect(int connectionId, object target);
        private void txtFlashCode_TextChanged(object A_0, TextChangedEventArgs A_1);
        private void txtSerNum_TextChanged(object A_0, TextChangedEventArgs A_1);

        public string ModelNumber { get; set; }

        public string SerialNumber { get; set; }

        public string FlashCode { get; set; }

        public string FwVersion { get; set; }

        public bool DisableEnc { get; set; }

        private Brush NormalBorder { get; }

        public List<string> DepotOptions { get; internal set; }
    }
}

