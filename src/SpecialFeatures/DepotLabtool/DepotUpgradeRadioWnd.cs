namespace SpecialFeatures.DepotLabtool
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Windows;
    using System.Windows.Controls;
    using System.Windows.Markup;

    public class DepotUpgradeRadioWnd : Window, IComponentConnector
    {
        private bool a;
        private bool b;
        private UpgradeRadioData c;
        internal GroupBox groupBox1;
        internal Grid grid1;
        internal Label label1;
        internal TextBox txtModelNumber;
        internal Label label2;
        internal TextBox txtFlashCode1;
        internal Label label5;
        internal TextBox txtFlashCode2;
        internal Label label6;
        internal TextBox txtFlashCodeCheckSum;
        internal GroupBox groupBox2;
        internal Label label3;
        internal TextBox txtFlashUpgradeFile;
        internal Button btnBrowse;
        internal GroupBox groupBox3;
        internal Label label4;
        internal TextBox txtNewFlashCode1;
        internal TextBox txtNewFlashCode2;
        internal TextBox txtNewFlashCodeCheckSum;
        internal Label label7;
        internal Label label8;
        internal Button btnOK;
        internal Button button2;
        private bool d;

        public DepotUpgradeRadioWnd();
        private void a();
        private static string[] a(string A_0);
        private static string a(string[] A_0);
        private void btnBrowse_Click(object A_0, RoutedEventArgs A_1);
        private void btnOK_Click(object A_0, RoutedEventArgs A_1);
        [DebuggerNonUserCode, GeneratedCode("PresentationBuildTasks", "5.0.10.0")]
        public void InitializeComponent();
        [GeneratedCode("PresentationBuildTasks", "5.0.10.0"), EditorBrowsable(1), DebuggerNonUserCode]
        void IComponentConnector.Connect(int connectionId, object target);
        private void txtFlashUpgradeFile_TextChanged(object A_0, TextChangedEventArgs A_1);
        private void txtNewFlashCode_TextChanged(object A_0, TextChangedEventArgs A_1);

        public string ModelNumber { get; set; }

        public string FlashCode { set; }

        public string NewFlashCode { get; set; }

        public string upgradeFile { get; set; }
    }
}

