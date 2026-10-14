using System;
using System.ComponentModel;
using System.IO;
using System.IO.Packaging;
using System.Printing;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Threading;
using System.Windows.Xps.Packaging;
using Infragistics.Windows.Licensing;
using Infragistics.Windows.Themes;

namespace Infragistics.Windows.Reporting
{
	// Token: 0x02000014 RID: 20
	[global::Infragistics.Windows.Licensing.UltraLicense("XamReportPreview")]
	[global::System.ComponentModel.LicenseProvider(typeof(global::Infragistics.Windows.Licensing.UltraLicenseProvider))]
	[global::System.Windows.TemplatePart(Name = "Part_Viewer", Type = typeof(global::System.Windows.Controls.DocumentViewer))]
	public class XamReportPreview : global::System.Windows.Controls.Control
	{
		// Token: 0x060000CF RID: 207 RVA: 0x00005A68 File Offset: 0x00003C68
		static XamReportPreview()
		{
			global::System.Windows.FrameworkElement.DefaultStyleKeyProperty.OverrideMetadata(typeof(global::Infragistics.Windows.Reporting.XamReportPreview), new global::System.Windows.FrameworkPropertyMetadata(typeof(global::Infragistics.Windows.Reporting.XamReportPreview)));
			global::System.Windows.EventManager.RegisterClassHandler(typeof(global::Infragistics.Windows.Reporting.XamReportPreview), global::System.Windows.UIElement.GotFocusEvent, new global::System.Windows.RoutedEventHandler(global::Infragistics.Windows.Reporting.XamReportPreview.XamReportPreview_GotFocus));
			global::System.Windows.EventManager.RegisterClassHandler(typeof(global::Infragistics.Windows.Reporting.XamReportPreview), global::System.Windows.Input.CommandManager.PreviewExecutedEvent, new global::System.Windows.Input.ExecutedRoutedEventHandler(global::Infragistics.Windows.Reporting.XamReportPreview.OnPreviewDocumentCommand));
		}

		// Token: 0x060000D0 RID: 208 RVA: 0x00005BA4 File Offset: 0x00003DA4
		public XamReportPreview()
		{
			try
			{
				this._license = (global::System.ComponentModel.LicenseManager.Validate(typeof(global::Infragistics.Windows.Reporting.XamReportPreview), this) as global::Infragistics.Windows.Licensing.UltraLicense);
			}
			catch (global::System.IO.FileNotFoundException)
			{
			}
			base.Unloaded += this.OnUnloaded;
		}

		// Token: 0x060000D1 RID: 209 RVA: 0x00005BFC File Offset: 0x00003DFC
		public override void OnApplyTemplate()
		{
			base.OnApplyTemplate();
			if (this._documentViewer != null)
			{
				base.ClearValue(global::Infragistics.Windows.Reporting.XamReportPreview.DocumentTrackerProperty);
			}
			this._documentViewer = (base.GetTemplateChild("Part_Viewer") as global::System.Windows.Controls.DocumentViewer);
			if (this._documentViewer != null)
			{
				base.SetBinding(global::Infragistics.Windows.Reporting.XamReportPreview.DocumentTrackerProperty, global::Infragistics.Windows.Utilities.CreateBindingObject(global::System.Windows.Controls.Primitives.DocumentViewerBase.DocumentProperty, global::System.Windows.Data.BindingMode.OneWay, this._documentViewer));
			}
			this.Refresh();
		}

		// Token: 0x17000038 RID: 56
		// (get) Token: 0x060000D2 RID: 210 RVA: 0x00005C63 File Offset: 0x00003E63
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		public global::System.Windows.Controls.DocumentViewer DocumentViewer
		{
			get
			{
				return this._documentViewer;
			}
		}

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x060000D3 RID: 211 RVA: 0x00005C6B File Offset: 0x00003E6B
		// (set) Token: 0x060000D4 RID: 212 RVA: 0x00005C7D File Offset: 0x00003E7D
		[global::System.ComponentModel.Bindable(true)]
		public bool IsContentVisible
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.Windows.Reporting.XamReportPreview.IsContentVisibleProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.Reporting.XamReportPreview.IsContentVisibleProperty, value);
			}
		}

		// Token: 0x060000D5 RID: 213 RVA: 0x00005C90 File Offset: 0x00003E90
		private static void OnIsContentVisibleChangedCallback(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs args)
		{
			global::Infragistics.Windows.Reporting.XamReportPreview xamReportPreview = obj as global::Infragistics.Windows.Reporting.XamReportPreview;
			bool flag = (bool)args.OldValue;
			bool flag2 = (bool)args.NewValue;
			if (flag2)
			{
				xamReportPreview._documentViewer.Visibility = global::System.Windows.Visibility.Visible;
				return;
			}
			xamReportPreview._documentViewer.Visibility = global::System.Windows.Visibility.Hidden;
		}

		// Token: 0x060000D6 RID: 214 RVA: 0x00005CDC File Offset: 0x00003EDC
		private static object OnCoerceIsContentVisible(global::System.Windows.DependencyObject target, object value)
		{
			global::Infragistics.Windows.Reporting.XamReportPreview xamReportPreview = target as global::Infragistics.Windows.Reporting.XamReportPreview;
			if (xamReportPreview != null && xamReportPreview._documentViewer != null)
			{
				return value;
			}
			return 0;
		}

		// Token: 0x1700003A RID: 58
		// (get) Token: 0x060000D7 RID: 215 RVA: 0x00005D03 File Offset: 0x00003F03
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.ReadOnly(true)]
		public global::Infragistics.Windows.Reporting.Report Report
		{
			get
			{
				return (global::Infragistics.Windows.Reporting.Report)base.GetValue(global::Infragistics.Windows.Reporting.XamReportPreview.ReportProperty);
			}
		}

		// Token: 0x060000D8 RID: 216 RVA: 0x00005D18 File Offset: 0x00003F18
		private static void OnDocumentTrackerChanged(object target, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.Reporting.XamReportPreview xamReportPreview = target as global::Infragistics.Windows.Reporting.XamReportPreview;
			if (xamReportPreview != null && e.NewValue == null)
			{
				xamReportPreview.ReleaseDocumentResources();
			}
		}

		// Token: 0x060000D9 RID: 217 RVA: 0x00005D40 File Offset: 0x00003F40
		public void GeneratePreview(global::Infragistics.Windows.Reporting.Report report, bool showPrintDialog, bool showReportProgressControl)
		{
			if (this._documentViewer != null)
			{
				this._documentViewer.ClearValue(global::System.Windows.Controls.Primitives.DocumentViewerBase.DocumentProperty);
			}
			base.SetValue(global::Infragistics.Windows.Reporting.XamReportPreview.ReportPropertyKey, report);
			if (!global::System.Windows.Interop.BrowserInteropHelper.IsBrowserHosted)
			{
				if (!report.InitializeReport(showPrintDialog))
				{
					return;
				}
			}
			else
			{
				global::System.Windows.Controls.PrintDialog printDialog = new global::System.Windows.Controls.PrintDialog();
				printDialog.UserPageRangeEnabled = report.ReportSettings.UserPageRangeEnabled;
				if (showPrintDialog)
				{
					try
					{
						if (printDialog.PrintTicket != null)
						{
							if (report.ReportSettings.PageMediaSize != null)
							{
								printDialog.PrintTicket.PageMediaSize = report.ReportSettings.PageMediaSize;
							}
							printDialog.PrintTicket.PageOrientation = new global::System.Printing.PageOrientation?((report.ReportSettings.PageOrientation == global::Infragistics.Windows.Reporting.PageOrientation.Landscape) ? global::System.Printing.PageOrientation.Landscape : global::System.Printing.PageOrientation.Portrait);
						}
					}
					catch (global::System.Printing.PrintQueueException)
					{
					}
					if (printDialog.ShowDialog() != true)
					{
						return;
					}
					report.ReportSettings.PageRange = printDialog.PageRange;
					try
					{
						if (printDialog.PrintTicket != null && printDialog.PrintTicket.PageMediaSize != null)
						{
							report.ReportSettings.PageMediaSize = printDialog.PrintTicket.PageMediaSize;
						}
						else
						{
							report.ReportSettings.PageSize = new global::System.Windows.Size(printDialog.PrintableAreaWidth, printDialog.PrintableAreaHeight);
						}
						if (printDialog.PrintTicket != null && printDialog.PrintTicket.PageOrientation != null)
						{
							switch (printDialog.PrintTicket.PageOrientation.Value)
							{
							case global::System.Printing.PageOrientation.Landscape:
							case global::System.Printing.PageOrientation.ReverseLandscape:
								report.ReportSettings.PageOrientation = global::Infragistics.Windows.Reporting.PageOrientation.Landscape;
								goto IL_187;
							}
							report.ReportSettings.PageOrientation = global::Infragistics.Windows.Reporting.PageOrientation.Portrait;
						}
						IL_187:
						goto IL_1C0;
					}
					catch (global::System.Printing.PrintQueueException)
					{
						goto IL_1C0;
					}
				}
				global::System.Windows.Controls.PageRange pageRange = report.ReportSettings.PageRange;
				if (report.ReportSettings.PageRange.PageFrom == 0)
				{
					report.ReportSettings.PageRange = new global::System.Windows.Controls.PageRange(1, 0);
				}
			}
			IL_1C0:
			this.ReleaseDocumentResources();
			this._stream = new global::System.IO.MemoryStream();
			report.IsGeneratingPreview = true;
			if (showReportProgressControl)
			{
				report.ShowReportProgressControl(this);
			}
			report.Export(global::Infragistics.Windows.Reporting.OutputFormat.XPS, this._stream);
			this._package = global::System.IO.Packaging.Package.Open(this._stream, global::System.IO.FileMode.Open, global::System.IO.FileAccess.Read);
			string str = "pack://xamreportpreview.document";
			global::System.Uri uri = new global::System.Uri(str + ".xps");
			int num = 1;
			while (global::System.IO.Packaging.PackageStore.GetPackage(uri) != null)
			{
				num++;
				uri = new global::System.Uri(str + num.ToString() + ".xps");
			}
			this._packageRegisteredUri = uri;
			global::System.IO.Packaging.PackageStore.AddPackage(this._packageRegisteredUri, this._package);
			this._xpsDocument = new global::System.Windows.Xps.Packaging.XpsDocument(this._package, global::System.IO.Packaging.CompressionOption.Maximum, this._packageRegisteredUri.AbsoluteUri);
			this._documentForPreview = this._xpsDocument.GetFixedDocumentSequence();
			this.Refresh();
			report.IsGeneratingPreview = false;
			report.ReportSettings.PrintQueue = null;
		}

		// Token: 0x060000DA RID: 218 RVA: 0x0000600C File Offset: 0x0000420C
		private static void OnPreviewDocumentCommand(object sender, global::System.Windows.Input.ExecutedRoutedEventArgs e)
		{
			if (e.Command == global::System.Windows.Input.ApplicationCommands.Print)
			{
				global::Infragistics.Windows.Reporting.XamReportPreview xamReportPreview = sender as global::Infragistics.Windows.Reporting.XamReportPreview;
				if (xamReportPreview != null)
				{
					global::Infragistics.Windows.Reporting.Report report = xamReportPreview.Report;
					if (report != null)
					{
						report.Print(true, true, xamReportPreview);
						report.ReportSettings.PrintQueue = null;
					}
					e.Handled = true;
				}
			}
		}

		// Token: 0x060000DB RID: 219 RVA: 0x00006056 File Offset: 0x00004256
		private void OnUnloaded(object sender, global::System.Windows.RoutedEventArgs e)
		{
			base.Dispatcher.BeginInvoke(global::System.Windows.Threading.DispatcherPriority.Background, new global::Infragistics.Windows.Reporting.XamReportPreview.MethodDelegate(this.VerifyUnloaded));
		}

		// Token: 0x060000DC RID: 220 RVA: 0x00006074 File Offset: 0x00004274
		private void ReleaseDocumentResources()
		{
			if (this._packageRegisteredUri != null)
			{
				if (global::System.IO.Packaging.PackageStore.GetPackage(this._packageRegisteredUri) == this._package)
				{
					global::System.IO.Packaging.PackageStore.RemovePackage(this._packageRegisteredUri);
				}
				this._packageRegisteredUri = null;
			}
			if (this._xpsDocument != null)
			{
				this._xpsDocument.Close();
				this._xpsDocument = null;
			}
			if (this._package != null)
			{
				this._package.Close();
				this._package = null;
			}
			if (this._stream != null)
			{
				this._stream.Close();
				this._stream = null;
			}
			if (this._documentForPreview != null)
			{
				this._documentForPreview = null;
			}
		}

		// Token: 0x060000DD RID: 221 RVA: 0x00006111 File Offset: 0x00004311
		private void VerifyUnloaded()
		{
			if (!base.IsLoaded && !global::Infragistics.Windows.Utilities.HasLoadedAncestor(this))
			{
				if (this._documentViewer != null)
				{
					this._documentViewer.ClearValue(global::System.Windows.Controls.Primitives.DocumentViewerBase.DocumentProperty);
				}
				this.ReleaseDocumentResources();
			}
		}

		// Token: 0x060000DE RID: 222 RVA: 0x00006144 File Offset: 0x00004344
		private static void XamReportPreview_GotFocus(object sender, global::System.Windows.RoutedEventArgs e)
		{
			global::Infragistics.Windows.Reporting.XamReportPreview xamReportPreview = e.Source as global::Infragistics.Windows.Reporting.XamReportPreview;
			if (xamReportPreview != null && xamReportPreview._documentViewer != null)
			{
				xamReportPreview._documentViewer.Focus();
			}
		}

		// Token: 0x060000DF RID: 223 RVA: 0x00006174 File Offset: 0x00004374
		internal static string GetString(string name)
		{
			return global::Infragistics.Windows.Reporting.XamReportPreview.GetString(name, null);
		}

		// Token: 0x060000E0 RID: 224 RVA: 0x0000617D File Offset: 0x0000437D
		internal static string GetString(string name, params object[] args)
		{
			return global::SR.GetString(name, args);
		}

		// Token: 0x060000E1 RID: 225 RVA: 0x00006188 File Offset: 0x00004388
		internal void Refresh()
		{
			if (this._documentViewer != null)
			{
				this._documentViewer.Document = this._documentForPreview;
				if (global::System.Windows.Controls.DocumentViewer.FitToMaxPagesAcrossCommand.CanExecute(1, this._documentViewer))
				{
					global::System.Windows.Controls.DocumentViewer.FitToMaxPagesAcrossCommand.Execute(1, this._documentViewer);
				}
			}
		}

		// Token: 0x0400006D RID: 109
		private global::System.Windows.Documents.FixedDocumentSequence _documentForPreview;

		// Token: 0x0400006E RID: 110
		private global::System.Windows.Controls.DocumentViewer _documentViewer;

		// Token: 0x0400006F RID: 111
		private global::System.IO.Stream _stream;

		// Token: 0x04000070 RID: 112
		private global::System.IO.Packaging.Package _package;

		// Token: 0x04000071 RID: 113
		private global::System.Uri _packageRegisteredUri;

		// Token: 0x04000072 RID: 114
		private global::System.Windows.Xps.Packaging.XpsDocument _xpsDocument;

		// Token: 0x04000073 RID: 115
		private global::Infragistics.Windows.Licensing.UltraLicense _license;

		// Token: 0x04000074 RID: 116
		public static readonly global::System.Windows.ResourceKey DocumentViewerStyleKey = new global::Infragistics.Windows.Themes.StaticPropertyResourceKey(typeof(global::Infragistics.Windows.Reporting.XamReportPreview), "DocumentViewerStyleKey");

		// Token: 0x04000075 RID: 117
		public static readonly global::System.Windows.DependencyProperty IsContentVisibleProperty = global::System.Windows.DependencyProperty.Register("IsContentVisible", typeof(bool), typeof(global::Infragistics.Windows.Reporting.XamReportPreview), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.Reporting.XamReportPreview.OnIsContentVisibleChangedCallback), new global::System.Windows.CoerceValueCallback(global::Infragistics.Windows.Reporting.XamReportPreview.OnCoerceIsContentVisible)));

		// Token: 0x04000076 RID: 118
		private static readonly global::System.Windows.DependencyPropertyKey ReportPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("Report", typeof(global::Infragistics.Windows.Reporting.Report), typeof(global::Infragistics.Windows.Reporting.XamReportPreview), new global::System.Windows.FrameworkPropertyMetadata(null));

		// Token: 0x04000077 RID: 119
		public static readonly global::System.Windows.DependencyProperty ReportProperty = global::Infragistics.Windows.Reporting.XamReportPreview.ReportPropertyKey.DependencyProperty;

		// Token: 0x04000078 RID: 120
		private static readonly global::System.Windows.DependencyProperty DocumentTrackerProperty = global::System.Windows.DependencyProperty.Register("DocumentTracker", typeof(global::System.Windows.Documents.IDocumentPaginatorSource), typeof(global::Infragistics.Windows.Reporting.XamReportPreview), new global::System.Windows.FrameworkPropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.Reporting.XamReportPreview.OnDocumentTrackerChanged)));

		// Token: 0x02000015 RID: 21
		// (Invoke) Token: 0x060000E3 RID: 227
		private delegate void MethodDelegate();
	}
}
