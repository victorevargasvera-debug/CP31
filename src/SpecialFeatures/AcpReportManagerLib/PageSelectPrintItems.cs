namespace SpecialFeatures.AcpReportManagerLib
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Windows;
    using System.Windows.Controls;
    using System.Windows.Input;
    using System.Windows.Markup;
    using System.Windows.Navigation;

    public class PageSelectPrintItems : PageFunction<string>, IComponentConnector
    {
        internal Grid gReportsSelectPrintItems;
        internal Label lblAvailablePrint;
        internal Label lblSelectPrint;
        internal TreeView tvAvailable;
        internal TreeView tvSelected;
        internal Button btnAddSelectedItems;
        internal Button btnRemSelectedItems;
        internal Button btnSave;
        internal Button btnSaveAs;
        internal Button btnCancel;
        internal Button btnHelp;
        internal Image imgMotologo;
        private bool a;

        internal PageSelectPrintItems();
        private void a();
        private bool a(PageSelectPrintItems.serializeAction A_0);
        private void a(RptTreeViewItem A_0);
        private void a(RptTreeViewItem A_0, RptTreeViewItem A_1);
        private bool a(ref TreeView A_0, int A_1);
        private void a(RptTreeViewItem A_0, RptTreeViewItem A_1, RptTreeViewItem A_2);
        private bool a(RptTreeViewItem A_0, ref RptTreeViewItem A_1, string A_2);
        internal void AddToSelectedTreeItems(RptTreeViewItem pItem, RptTreeViewItem cItem, RptTreeViewItem gItem);
        private void b(RptTreeViewItem A_0);
        private void b(RptTreeViewItem A_0, RptTreeViewItem A_1);
        private void b(RptTreeViewItem A_0, RptTreeViewItem A_1, RptTreeViewItem A_2);
        internal bool BuildPrintItems();
        private void buttonHelp_Click(object A_0, RoutedEventArgs A_1);
        private void c(RptTreeViewItem A_0);
        private void c(RptTreeViewItem A_0, RptTreeViewItem A_1);
        private void d(RptTreeViewItem A_0);
        private void d(RptTreeViewItem A_0, RptTreeViewItem A_1);
        private void e(RptTreeViewItem A_0, RptTreeViewItem A_1);
        private void F1HelpCommandCanExcute(object A_0, CanExecuteRoutedEventArgs A_1);
        [GeneratedCode("PresentationBuildTasks", "5.0.10.0"), DebuggerNonUserCode]
        public void InitializeComponent();
        private void InitializeData(object A_0, EventArgs A_1);
        internal void OnClickAdd(object sender, RoutedEventArgs e);
        internal void OnClickRmv(object sender, RoutedEventArgs e);
        internal void OnSave(object sender, RoutedEventArgs e);
        internal void OnSaveAs(object sender, RoutedEventArgs e);
        internal void OnSelItemsCancel(object sender, RoutedEventArgs e);
        internal void RmvFromAvailableTreeItems(RptTreeViewItem pItem, RptTreeViewItem cItem, RptTreeViewItem gItem);
        internal void SortItems(ref TreeView itemsContainer);
        [GeneratedCode("PresentationBuildTasks", "5.0.10.0"), EditorBrowsable(1), DebuggerNonUserCode]
        void IComponentConnector.Connect(int connectionId, object target);

        private enum serializeAction
        {
            saveAs,
            save
        }
    }
}

