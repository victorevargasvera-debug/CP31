namespace SpecialFeatures.AcpReportManagerLib
{
    using DevComponents.WpfRibbon;
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.IO;
    using System.Runtime.InteropServices;
    using System.Security.AccessControl;
    using System.Windows;
    using System.Windows.Controls;
    using System.Windows.Controls.Primitives;
    using System.Windows.Documents;
    using System.Windows.Input;
    using System.Windows.Markup;
    using System.Windows.Threading;
    using System.Windows.Xps;
    using System.Windows.Xps.Packaging;
    using System.Xml;

    public class ReportViewer : Window, IDisposable, IComponentConnector
    {
        private XmlDocument a;
        private XmlNodeList b;
        private XmlNodeList c;
        private XmlNodeList d;
        private XmlNodeList e;
        private XmlNodeList f;
        private XmlNodeList g;
        private string h;
        private FileStream i;
        private XpsDocument j;
        private XpsDocumentWriter k;
        public InputDialog usrInpDia;
        private bool l;
        private string m;
        private int n;
        private reportType o;
        public static RoutedCommand CustomLastPage;
        public static RoutedCommand CustomNextPage;
        internal DocumentViewer RptViewer;
        internal Menu mnuMenu;
        internal MenuItem MenuItemFile;
        internal MenuItem MenuItemFileOpen;
        internal MenuItem MenuItemFileSave;
        internal MenuItem MenuItemFilePrint;
        internal MenuItem MenuItemFileExit;
        internal MenuItem MenuItemView;
        internal MenuItem menuViewIncreaseZoom;
        internal MenuItem menuViewDecreaseZoom;
        internal ButtonDropDown ribbonBarHelpButton;
        internal StatusBar stsbtmBar;
        private bool p;

        static ReportViewer();
        public ReportViewer(reportType rptType, string xmlFile, int fileCreationTime, ref bool retVal);
        private string a();
        private bool a(reportType A_0);
        private void a(ref XmlTextWriter A_0);
        private void a(bool A_0);
        private bool a(reportType A_0, int A_1);
        private void a(ref XmlTextWriter A_0, string A_1);
        private void a(ref XmlTextWriter A_0, XmlNodeList A_1);
        private void a(ref XmlTextWriter A_0, string A_1, int A_2);
        private static void a(string A_0, string A_1, FileSystemRights A_2, AccessControlType A_3);
        private bool a(string A_0, string A_1, int A_2, int A_3, int A_4, bool A_5);
        private bool a(string A_0, string A_1, string A_2, int A_3, int A_4, int A_5, bool A_6);
        private void a(ref string A_0, ref int A_1, ref int A_2, ref int A_3, string A_4, int A_5, int A_6, int A_7);
        private string b();
        private IDocumentPaginatorSource b(reportType A_0);
        private void b(ref XmlTextWriter A_0, string A_1);
        private void buttonHelp_Click(object A_0, RoutedEventArgs A_1);
        private string c();
        private void c(ref XmlTextWriter A_0, string A_1);
        private void CanExecuteCustomCommand(object A_0, CanExecuteRoutedEventArgs A_1);
        public static string convertToArabicDateTime(string dt);
        private void CustomLastPage_CommandBinding_CanExecute(object A_0, CanExecuteRoutedEventArgs A_1);
        private void CustomLastPage_CommandBinding_Executed(object A_0, ExecutedRoutedEventArgs A_1);
        private void CustomNextPage_CommandBinding_CanExecute(object A_0, CanExecuteRoutedEventArgs A_1);
        private void CustomNextPage_CommandBinding_Executed(object A_0, ExecutedRoutedEventArgs A_1);
        private void d();
        private void Dispatcher_UnhandledException(object A_0, DispatcherUnhandledExceptionEventArgs A_1);
        public void Dispose();
        protected virtual void Dispose(bool disposing);
        private void e();
        private void ExecutedCustomCommand(object A_0, ExecutedRoutedEventArgs A_1);
        private bool f();
        private void F1HelpCommandCanExcute(object A_0, CanExecuteRoutedEventArgs A_1);
        private bool g();
        private void GoToPage(object A_0, RoutedEventArgs A_1);
        private bool h();
        [GeneratedCode("PresentationBuildTasks", "5.0.10.0"), DebuggerNonUserCode]
        public void InitializeComponent();
        private void OnDragUpdateStatus(object A_0, MouseEventArgs A_1);
        private void OnMenuItemClick(object A_0, RoutedEventArgs A_1);
        [DebuggerNonUserCode, EditorBrowsable(1), GeneratedCode("PresentationBuildTasks", "5.0.10.0")]
        void IComponentConnector.Connect(int connectionId, object target);
        public void UpdateStatusBar();
        private void Window_Closing(object A_0, CancelEventArgs A_1);
        private void Window_Loaded(object A_0, RoutedEventArgs A_1);
    }
}

