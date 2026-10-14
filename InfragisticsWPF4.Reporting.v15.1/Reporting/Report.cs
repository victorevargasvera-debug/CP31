using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing.Printing;
using System.IO;
using System.IO.Packaging;
using System.Printing;
using System.Security;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Documents.Serialization;
using System.Windows.Forms;
using System.Windows.Interop;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Windows.Xps;
using System.Windows.Xps.Packaging;
using Infragistics.Windows.Controls;
using Infragistics.Windows.Reporting.Events;

namespace Infragistics.Windows.Reporting
{
	// Token: 0x02000010 RID: 16
	public class Report : global::Infragistics.Windows.Reporting.ReportBase, global::System.Windows.Documents.IDocumentPaginatorSource
	{
		// Token: 0x0600005C RID: 92 RVA: 0x0000370C File Offset: 0x0000190C
		public Report()
		{
			this._paginator = new global::Infragistics.Windows.Reporting.Report.Paginator(this);
			this._sections = new global::Infragistics.Windows.Reporting.ReportSectionCollection();
			this._paginator.PrintProgress += this.OnPrintProgress;
			this._reportSettings = new global::Infragistics.Windows.Reporting.ReportSettings();
		}

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x0600005D RID: 93 RVA: 0x00003770 File Offset: 0x00001970
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.ReadOnly(true)]
		[global::System.ComponentModel.Bindable(false)]
		public override global::System.Windows.Size PageSizeResolved
		{
			get
			{
				if (!global::Infragistics.Windows.Reporting.Report.IsValidPageSize(this._explicitPageSize))
				{
					return base.PageSizeResolved;
				}
				global::System.Windows.Size pageImageableAreaExtent = base.PageImageableAreaExtent;
				if (global::Infragistics.Windows.Reporting.Report.IsValidPageSize(pageImageableAreaExtent))
				{
					if (this._explicitPageSize.Width > this._explicitPageSize.Height && pageImageableAreaExtent.Width < pageImageableAreaExtent.Height)
					{
						double width = pageImageableAreaExtent.Width;
						pageImageableAreaExtent.Width = pageImageableAreaExtent.Height;
						pageImageableAreaExtent.Height = width;
					}
					return new global::System.Windows.Size(global::System.Math.Min(this._explicitPageSize.Width, pageImageableAreaExtent.Width), global::System.Math.Min(this._explicitPageSize.Height, pageImageableAreaExtent.Height));
				}
				return this._explicitPageSize;
			}
		}

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x0600005E RID: 94 RVA: 0x00003823 File Offset: 0x00001A23
		public override global::Infragistics.Windows.Reporting.ReportSettings ReportSettings
		{
			get
			{
				return this._reportSettings;
			}
		}

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x0600005F RID: 95 RVA: 0x0000382B File Offset: 0x00001A2B
		// (set) Token: 0x06000060 RID: 96 RVA: 0x00003833 File Offset: 0x00001A33
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.ReadOnly(true)]
		[global::System.ComponentModel.Browsable(false)]
		public bool IsGeneratingPreview
		{
			get
			{
				return this._isGeneratingPreview;
			}
			internal set
			{
				if (this._isGeneratingPreview != value)
				{
					this._isGeneratingPreview = value;
					base.RaisePropertyChangedEvent("IsGeneratingPreview");
				}
			}
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x06000061 RID: 97 RVA: 0x00003850 File Offset: 0x00001A50
		// (set) Token: 0x06000062 RID: 98 RVA: 0x00003858 File Offset: 0x00001A58
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.ReadOnly(true)]
		public int PhysicalPageNumber
		{
			get
			{
				return this._physicalPageNumber;
			}
			internal set
			{
				this._physicalPageNumber = value;
				base.RaisePropertyChangedEvent("PhysicalPageNumber");
			}
		}

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x06000063 RID: 99 RVA: 0x0000386C File Offset: 0x00001A6C
		// (set) Token: 0x06000064 RID: 100 RVA: 0x00003874 File Offset: 0x00001A74
		[global::System.ComponentModel.ReadOnly(true)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		public int LogicalPageNumber
		{
			get
			{
				return this._logicalPageNumber;
			}
			internal set
			{
				this._logicalPageNumber = value;
				base.RaisePropertyChangedEvent("LogicalPageNumber");
			}
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x06000065 RID: 101 RVA: 0x00003888 File Offset: 0x00001A88
		// (set) Token: 0x06000066 RID: 102 RVA: 0x00003890 File Offset: 0x00001A90
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.ReadOnly(true)]
		public int LogicalPagePartNumber
		{
			get
			{
				return this._logicalPagePartNumber;
			}
			internal set
			{
				this._logicalPagePartNumber = value;
				base.RaisePropertyChangedEvent("LogicalPagePartNumber");
			}
		}

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x06000067 RID: 103 RVA: 0x000038A4 File Offset: 0x00001AA4
		// (set) Token: 0x06000068 RID: 104 RVA: 0x000038AC File Offset: 0x00001AAC
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.ReadOnly(true)]
		public int SectionPhysicalPageNumber
		{
			get
			{
				return this._sectionPhysicalPageNumber;
			}
			internal set
			{
				this._sectionPhysicalPageNumber = value;
				base.RaisePropertyChangedEvent("SectionPhysicalPageNumber");
			}
		}

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x06000069 RID: 105 RVA: 0x000038C0 File Offset: 0x00001AC0
		// (set) Token: 0x0600006A RID: 106 RVA: 0x000038C8 File Offset: 0x00001AC8
		[global::System.ComponentModel.ReadOnly(true)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		public int SectionLogicalPageNumber
		{
			get
			{
				return this._sectionLogicalPageNumber;
			}
			internal set
			{
				this._sectionLogicalPageNumber = value;
				base.RaisePropertyChangedEvent("SectionLogicalPageNumber");
			}
		}

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x0600006B RID: 107 RVA: 0x000038DC File Offset: 0x00001ADC
		// (set) Token: 0x0600006C RID: 108 RVA: 0x000038E4 File Offset: 0x00001AE4
		[global::System.ComponentModel.ReadOnly(true)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		public int SectionLogicalPagePartNumber
		{
			get
			{
				return this._sectionLogicalPagePartNumber;
			}
			internal set
			{
				this._sectionLogicalPagePartNumber = value;
				base.RaisePropertyChangedEvent("SectionLogicalPagePartNumber");
			}
		}

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x0600006D RID: 109 RVA: 0x000038F8 File Offset: 0x00001AF8
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		public global::Infragistics.Windows.Reporting.ReportSectionCollection Sections
		{
			get
			{
				return this._sections;
			}
		}

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x0600006E RID: 110 RVA: 0x00003900 File Offset: 0x00001B00
		internal int RunningLogicalPageCount
		{
			get
			{
				return this._runningLogicalPageCount;
			}
		}

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x0600006F RID: 111 RVA: 0x00003908 File Offset: 0x00001B08
		internal global::System.Windows.FrameworkElement ReportProgressControlOwnedElementResolved
		{
			get
			{
				if (this._reportProgressControlOwnedElement != null)
				{
					return this._reportProgressControlOwnedElement;
				}
				foreach (global::Infragistics.Windows.Reporting.ReportSection reportSection in this.Sections)
				{
					global::Infragistics.Windows.Reporting.EmbeddedVisualReportSection embeddedVisualReportSection = reportSection as global::Infragistics.Windows.Reporting.EmbeddedVisualReportSection;
					if (embeddedVisualReportSection != null)
					{
						global::System.Windows.FrameworkElement frameworkElement = global::Infragistics.Windows.Utilities.GetAncestorFromType(embeddedVisualReportSection.SourceVisual, typeof(global::System.Windows.Controls.Page), true) as global::System.Windows.FrameworkElement;
						if (frameworkElement != null)
						{
							return frameworkElement;
						}
						global::System.Windows.FrameworkElement frameworkElement2 = global::Infragistics.Windows.Utilities.GetAncestorFromType(embeddedVisualReportSection.SourceVisual, typeof(global::System.Windows.Window), true) as global::System.Windows.FrameworkElement;
						if (frameworkElement2 != null)
						{
							return frameworkElement2;
						}
					}
				}
				return null;
			}
		}

		// Token: 0x06000070 RID: 112 RVA: 0x000039B8 File Offset: 0x00001BB8
		internal void ExportToXPS()
		{
			this._exportDoc = null;
			this._exportPackage = null;
			try
			{
				string path;
				if (string.IsNullOrEmpty(this.ReportSettings.FileName))
				{
					path = global::System.Environment.CurrentDirectory + global::System.IO.Path.DirectorySeparatorChar + this._defaultExportFileName;
				}
				else
				{
					string text = global::System.IO.Path.GetDirectoryName(this.ReportSettings.FileName);
					string text2 = global::System.IO.Path.GetFileName(this.ReportSettings.FileName);
					if (string.IsNullOrEmpty(text2))
					{
						text2 = this._defaultExportFileName;
					}
					if (!global::System.IO.Directory.Exists(text))
					{
						text = global::System.Environment.CurrentDirectory;
					}
					path = text + global::System.IO.Path.DirectorySeparatorChar + text2;
				}
				this.CheckUserSettings();
				this._exportPackage = global::System.IO.Packaging.Package.Open(path, global::System.IO.FileMode.Create);
				this._exportDoc = new global::System.Windows.Xps.Packaging.XpsDocument(this._exportPackage);
				this.GenerateReport(this._exportDoc);
			}
			catch (global::System.IO.IOException exception)
			{
				this.OnWritingCanceled(this, new global::System.Windows.Documents.Serialization.WritingCancelledEventArgs(exception));
			}
		}

		// Token: 0x06000071 RID: 113 RVA: 0x00003AAC File Offset: 0x00001CAC
		internal void ExportToXPS(string fileName)
		{
			this._exportDoc = null;
			this._exportPackage = null;
			try
			{
				if (string.IsNullOrEmpty(fileName))
				{
					this.ExportToXPS();
				}
				else
				{
					string text = global::System.IO.Path.GetDirectoryName(fileName);
					string fileName2 = global::System.IO.Path.GetFileName(fileName);
					if (string.IsNullOrEmpty(fileName2))
					{
						this.ExportToXPS();
					}
					else
					{
						if (!global::System.IO.Directory.Exists(text))
						{
							text = global::System.Environment.CurrentDirectory;
						}
						text = text + global::System.IO.Path.DirectorySeparatorChar + fileName2;
						this.CheckUserSettings();
						this._exportPackage = global::System.IO.Packaging.Package.Open(text, global::System.IO.FileMode.Create);
						this._exportDoc = new global::System.Windows.Xps.Packaging.XpsDocument(this._exportPackage);
						this.GenerateReport(this._exportDoc);
					}
				}
			}
			catch (global::System.IO.IOException exception)
			{
				this.OnWritingCanceled(this, new global::System.Windows.Documents.Serialization.WritingCancelledEventArgs(exception));
			}
		}

		// Token: 0x06000072 RID: 114 RVA: 0x00003B6C File Offset: 0x00001D6C
		internal void ExportToXPS(global::System.IO.Stream stream)
		{
			this._exportDoc = null;
			this._exportPackage = null;
			try
			{
				if (stream == null || !stream.CanWrite)
				{
					this.ExportToXPS();
				}
				else
				{
					this.CheckUserSettings();
					this._exportPackage = global::System.IO.Packaging.Package.Open(stream, global::System.IO.FileMode.Create);
					this._exportDoc = new global::System.Windows.Xps.Packaging.XpsDocument(this._exportPackage);
					this.GenerateReport(this._exportDoc);
				}
			}
			catch (global::System.IO.IOException exception)
			{
				this.OnWritingCanceled(this, new global::System.Windows.Documents.Serialization.WritingCancelledEventArgs(exception));
			}
		}

		// Token: 0x06000073 RID: 115 RVA: 0x00003BEC File Offset: 0x00001DEC
		internal global::System.Windows.Controls.PrintDialog CreateAndInitializePrintDialog()
		{
			global::System.Windows.Controls.PrintDialog printDialog = new global::System.Windows.Controls.PrintDialog();
			printDialog.UserPageRangeEnabled = this.ReportSettings.UserPageRangeEnabled;
			global::System.Windows.Controls.PageRange pageRange = this.ReportSettings.PageRange;
			if (pageRange.PageFrom > 0 && pageRange.PageTo > 0 && pageRange.PageTo >= pageRange.PageFrom)
			{
				printDialog.PageRange = pageRange;
				printDialog.PageRangeSelection = global::System.Windows.Controls.PageRangeSelection.UserPages;
			}
			global::System.Printing.PrintTicket printTicket = printDialog.PrintTicket;
			global::System.Printing.PrintQueue printQueue = printDialog.PrintQueue;
			global::System.Printing.PageMediaSize pageMediaSize = this.ReportSettings.PageMediaSize;
			if (pageMediaSize != null && printTicket != null)
			{
				printTicket.PageMediaSize = pageMediaSize;
			}
			if (this.ReportSettings.PageOrientation == global::Infragistics.Windows.Reporting.PageOrientation.Landscape)
			{
				if (printTicket != null)
				{
					printTicket.PageOrientation = new global::System.Printing.PageOrientation?(global::System.Printing.PageOrientation.Landscape);
				}
				if (printQueue != null)
				{
					printQueue.DefaultPrintTicket.PageOrientation = new global::System.Printing.PageOrientation?(global::System.Printing.PageOrientation.Landscape);
				}
			}
			else
			{
				if (printTicket != null)
				{
					printTicket.PageOrientation = new global::System.Printing.PageOrientation?(global::System.Printing.PageOrientation.Portrait);
				}
				if (printQueue != null)
				{
					printQueue.DefaultPrintTicket.PageOrientation = new global::System.Printing.PageOrientation?(global::System.Printing.PageOrientation.Portrait);
				}
			}
			if (printQueue != null)
			{
				printQueue.UserPrintTicket = printDialog.PrintTicket;
			}
			return printDialog;
		}

		// Token: 0x06000074 RID: 116 RVA: 0x00003CE0 File Offset: 0x00001EE0
		internal void UpdateSettingsFromPrintDialog(global::System.Windows.Controls.PrintDialog printDialog, bool dialogDisplayed, global::System.Windows.Size originalPrintAreaSize)
		{
			global::System.Printing.PrintTicket printTicket = printDialog.PrintTicket;
			global::System.Printing.PrintQueue printQueue = printDialog.PrintQueue;
			if (dialogDisplayed)
			{
				if (printQueue != null)
				{
					printQueue.UserPrintTicket = printDialog.PrintTicket;
					this.ReportSettings.PrintQueue = printQueue;
				}
				this.ReportSettings.PageRange = printDialog.PageRange;
				try
				{
					if (originalPrintAreaSize.Width != printDialog.PrintableAreaWidth || originalPrintAreaSize.Height != printDialog.PrintableAreaHeight)
					{
						this._explicitPageSize = new global::System.Windows.Size(printDialog.PrintableAreaWidth, printDialog.PrintableAreaHeight);
					}
					goto IL_11D;
				}
				catch (global::System.Printing.PrintQueueException)
				{
					goto IL_11D;
				}
			}
			if (printQueue != null)
			{
				printQueue.UserPrintTicket = printDialog.PrintTicket;
				if (this.ReportSettings.PageOrientation == global::Infragistics.Windows.Reporting.PageOrientation.Landscape)
				{
					printQueue.UserPrintTicket.PageOrientation = new global::System.Printing.PageOrientation?(global::System.Printing.PageOrientation.Landscape);
				}
				this.ReportSettings.PrintQueue = printQueue;
			}
			global::System.Windows.Size settingsPageSizeResolved = this.GetSettingsPageSizeResolved();
			if (!global::Infragistics.Windows.Reporting.Report.IsValidPageSize(settingsPageSizeResolved))
			{
				try
				{
					this._explicitPageSize = new global::System.Windows.Size(printDialog.PrintableAreaWidth, printDialog.PrintableAreaHeight);
					goto IL_E9;
				}
				catch (global::System.Printing.PrintQueueException)
				{
					goto IL_E9;
				}
			}
			this._explicitPageSize = settingsPageSizeResolved;
			IL_E9:
			global::System.Windows.Controls.PageRange pageRange = this.ReportSettings.PageRange;
			if (this.ReportSettings.PageRange.PageFrom == 0)
			{
				this.ReportSettings.PageRange = new global::System.Windows.Controls.PageRange(1, 0);
			}
			IL_11D:
			if (printDialog.PrintTicket.PageOrientation != null)
			{
				if (printDialog.PrintTicket.PageOrientation.Value.Equals(global::System.Printing.PageOrientation.Portrait))
				{
					this.ReportSettings.PageOrientation = global::Infragistics.Windows.Reporting.PageOrientation.Portrait;
				}
				else
				{
					this.ReportSettings.PageOrientation = global::Infragistics.Windows.Reporting.PageOrientation.Landscape;
				}
			}
			if (printDialog.PrintTicket.PageMediaSize != null && printDialog.PrintTicket.PageMediaSize.Width != null && printDialog.PrintTicket.PageMediaSize.Height != null)
			{
				double value = printDialog.PrintTicket.PageMediaSize.Width.Value;
				double value2 = printDialog.PrintTicket.PageMediaSize.Height.Value;
				global::System.Windows.Size size;
				if (global::Infragistics.Windows.Reporting.Report.IsValidPageSize(this._explicitPageSize))
				{
					size = this._explicitPageSize;
				}
				else
				{
					size = this.GetSettingsPageSizeResolved();
				}
				if (size.Width > value || size.Height > value2)
				{
					this._explicitPageSize = new global::System.Windows.Size(global::System.Math.Min(value, size.Width), global::System.Math.Min(value2, size.Height));
				}
			}
		}

		// Token: 0x06000075 RID: 117 RVA: 0x00003F54 File Offset: 0x00002154
		internal bool InitializeReport(bool showPrintDialog)
		{
			if (this.ReportSettings.PrintQueue != null)
			{
				this.CheckUserSettings();
				return true;
			}
			global::System.Windows.Controls.PrintDialog printDialog = this.CreateAndInitializePrintDialog();
			global::System.Windows.Size originalPrintAreaSize = default(global::System.Windows.Size);
			try
			{
				originalPrintAreaSize = new global::System.Windows.Size(printDialog.PrintableAreaWidth, printDialog.PrintableAreaHeight);
			}
			catch (global::System.Printing.PrintQueueException)
			{
			}
			if (showPrintDialog && printDialog.ShowDialog() != true)
			{
				return false;
			}
			this.UpdateSettingsFromPrintDialog(printDialog, showPrintDialog, originalPrintAreaSize);
			return true;
		}

		// Token: 0x06000076 RID: 118 RVA: 0x00003FDC File Offset: 0x000021DC
		internal void PrintViaPrintDialog(bool showReportProgressControl)
		{
			this._explicitPageSize = global::System.Windows.Size.Empty;
			global::Infragistics.Windows.Reporting.ReportSettings reportSettings = this.ReportSettings;
			global::System.Windows.Controls.PrintDialog printDialog = new global::System.Windows.Controls.PrintDialog();
			printDialog.UserPageRangeEnabled = reportSettings.UserPageRangeEnabled;
			global::System.Printing.PrintTicket printTicket = printDialog.PrintTicket;
			if (printTicket != null)
			{
				printTicket.PageOrientation = new global::System.Printing.PageOrientation?((reportSettings.PageOrientation == global::Infragistics.Windows.Reporting.PageOrientation.Landscape) ? global::System.Printing.PageOrientation.Landscape : global::System.Printing.PageOrientation.Portrait);
			}
			if (printDialog.ShowDialog() != true)
			{
				return;
			}
			reportSettings.PageRange = printDialog.PageRange;
			if (printTicket != null && printTicket.PageOrientation != null)
			{
				switch (printTicket.PageOrientation.Value)
				{
				case global::System.Printing.PageOrientation.Landscape:
				case global::System.Printing.PageOrientation.ReverseLandscape:
					reportSettings.PageOrientation = global::Infragistics.Windows.Reporting.PageOrientation.Landscape;
					goto IL_BE;
				}
				reportSettings.PageOrientation = global::Infragistics.Windows.Reporting.PageOrientation.Portrait;
			}
			IL_BE:
			base.ClearCachedOriginAndSize();
			try
			{
				this._explicitPageSize = new global::System.Windows.Size(printDialog.PrintableAreaWidth, printDialog.PrintableAreaHeight);
			}
			catch (global::System.Printing.PrintQueueException)
			{
			}
			if (showReportProgressControl)
			{
				this.ShowReportProgressControl();
			}
			this._paginator.Initialize(reportSettings);
			printDialog.PrintDocument(this._paginator, "");
			if (!this._paginator.IsCancel)
			{
				this.OnWritingCompleted(this, new global::System.Windows.Documents.Serialization.WritingCompletedEventArgs(false, "", null));
			}
		}

		// Token: 0x06000077 RID: 119 RVA: 0x00004120 File Offset: 0x00002320
		private void CheckUserSettings()
		{
			global::System.Windows.Controls.PageRange pageRange = this.ReportSettings.PageRange;
			if (this.ReportSettings.PageRange.PageFrom == 0)
			{
				this.ReportSettings.PageRange = new global::System.Windows.Controls.PageRange(1, 0);
			}
		}

		// Token: 0x06000078 RID: 120 RVA: 0x00004160 File Offset: 0x00002360
		private void CleanUpDocAndPackage()
		{
			if (this._exportDoc != null)
			{
				this._exportDoc.Close();
				this._exportDoc = null;
			}
			if (this._exportPackage != null)
			{
				this._exportPackage.Close();
				this._exportPackage = null;
			}
		}

		// Token: 0x06000079 RID: 121 RVA: 0x00004196 File Offset: 0x00002396
		private void CloseReportProgressControl()
		{
			if (this._buildInProgressWnd != null)
			{
				this._buildInProgressWnd.Close();
				this._buildInProgressWnd = null;
			}
		}

		// Token: 0x0600007A RID: 122 RVA: 0x000041B4 File Offset: 0x000023B4
		private void GenerateReport(object reportObject)
		{
			if (reportObject is global::System.Windows.Xps.Packaging.XpsDocument)
			{
				global::System.Windows.Xps.Packaging.XpsDocument xpsDocument = reportObject as global::System.Windows.Xps.Packaging.XpsDocument;
				global::System.Windows.Xps.XpsDocumentWriter writer = global::System.Windows.Xps.Packaging.XpsDocument.CreateXpsDocumentWriter(xpsDocument);
				global::System.Printing.PrintTicket printTicket = null;
				global::System.Printing.PrintQueue printQueue = null;
				try
				{
					printQueue = this.ReportSettings.PrintQueue;
					if (printQueue != null)
					{
						printTicket = this.ReportSettings.PrintQueue.DefaultPrintTicket;
					}
				}
				catch (global::System.Exception)
				{
				}
				try
				{
					this.ProcessXpsDocumentWriter(writer, printTicket, printQueue);
					return;
				}
				catch (global::System.Printing.PrintQueueException)
				{
					this.InvokeEndPaginationIfNeeded();
					writer = global::System.Windows.Xps.Packaging.XpsDocument.CreateXpsDocumentWriter(xpsDocument);
					this.ProcessXpsDocumentWriter(writer, new global::System.Printing.PrintTicket(), printQueue);
					return;
				}
			}
			if (reportObject is global::System.Printing.PrintQueue)
			{
				global::System.Printing.PrintQueue printQueue2 = reportObject as global::System.Printing.PrintQueue;
				global::System.Windows.Xps.XpsDocumentWriter writer2 = global::System.Printing.PrintQueue.CreateXpsDocumentWriter(printQueue2);
				try
				{
					this.ProcessXpsDocumentWriter(writer2, printQueue2);
				}
				catch (global::System.Printing.PrintQueueException)
				{
					this.InvokeEndPaginationIfNeeded();
					writer2 = global::System.Printing.PrintQueue.CreateXpsDocumentWriter(printQueue2);
					this.ProcessXpsDocumentWriter(writer2, new global::System.Printing.PrintTicket(), printQueue2);
				}
			}
		}

		// Token: 0x0600007B RID: 123 RVA: 0x00004298 File Offset: 0x00002498
		private global::System.Windows.Size GetSettingsPageSizeResolved()
		{
			global::System.Windows.Size pageSize = this.ReportSettings.PageSize;
			global::System.Printing.PageMediaSize pageMediaSize = this.ReportSettings.PageMediaSize;
			if (pageMediaSize != null)
			{
				double? width = pageMediaSize.Width;
				if (width.GetValueOrDefault() > 0.0 && width != null)
				{
					pageSize.Width = pageMediaSize.Width.Value;
				}
				double? height = pageMediaSize.Height;
				if (height.GetValueOrDefault() > 0.0 && height != null)
				{
					pageSize.Height = pageMediaSize.Height.Value;
				}
			}
			return pageSize;
		}

		// Token: 0x0600007C RID: 124 RVA: 0x00004339 File Offset: 0x00002539
		private void InvokeEndPaginationIfNeeded()
		{
			if (this._hasCalledBeginPagination)
			{
				this._hasCalledBeginPagination = false;
				this._paginator.EndPagination();
			}
		}

		// Token: 0x0600007D RID: 125 RVA: 0x00004358 File Offset: 0x00002558
		private bool IsPermissionGranted(global::System.Security.CodeAccessPermission requestedPermission)
		{
			bool result;
			try
			{
				requestedPermission.Demand();
				result = true;
			}
			catch
			{
				result = false;
			}
			return result;
		}

		// Token: 0x0600007E RID: 126 RVA: 0x00004388 File Offset: 0x00002588
		private static bool IsValidPageSize(global::System.Windows.Size size)
		{
			return !size.IsEmpty && size.Height >= 1.0 && size.Width >= 1.0;
		}

		// Token: 0x0600007F RID: 127 RVA: 0x000043BC File Offset: 0x000025BC
		internal void ShowReportProgressControl(global::Infragistics.Windows.Reporting.XamReportPreview preview)
		{
			this._reportProgressControlOwnedElement = preview;
			try
			{
				this.ShowReportProgressControl();
			}
			finally
			{
				this._reportProgressControlOwnedElement = null;
			}
		}

		// Token: 0x06000080 RID: 128 RVA: 0x000043F0 File Offset: 0x000025F0
		private void ShowReportProgressControl()
		{
			if (this._buildInProgressWnd == null)
			{
				global::System.Windows.FrameworkElement reportProgressControlOwnedElementResolved = this.ReportProgressControlOwnedElementResolved;
				if (reportProgressControlOwnedElementResolved == null)
				{
					return;
				}
				global::Infragistics.Windows.Reporting.ReportProgressControl reportProgressControl = new global::Infragistics.Windows.Reporting.ReportProgressControl();
				reportProgressControl.Report = this;
				this._buildInProgressWnd = new global::Infragistics.Windows.Controls.ToolWindow();
				this._buildInProgressWnd.VerticalAlignmentMode = global::Infragistics.Windows.Controls.ToolWindowAlignmentMode.UseAlignment;
				this._buildInProgressWnd.VerticalAlignment = global::System.Windows.VerticalAlignment.Center;
				this._buildInProgressWnd.HorizontalAlignmentMode = global::Infragistics.Windows.Controls.ToolWindowAlignmentMode.UseAlignment;
				this._buildInProgressWnd.HorizontalAlignment = global::System.Windows.HorizontalAlignment.Center;
				this._buildInProgressWnd.Content = reportProgressControl;
				this._buildInProgressWnd.MinHeight = 200.0;
				this._buildInProgressWnd.MinWidth = 300.0;
				if (this.IsGeneratingPreview)
				{
					this._buildInProgressWnd.Title = global::Infragistics.Windows.Reporting.XamReportPreview.GetString("ReportProgressControlTitle_Preview");
				}
				else
				{
					this._buildInProgressWnd.Title = global::Infragistics.Windows.Reporting.XamReportPreview.GetString("ReportProgressControlTitle");
				}
				this._buildInProgressWnd.Show(reportProgressControlOwnedElementResolved);
			}
		}

		// Token: 0x06000081 RID: 129 RVA: 0x000044CF File Offset: 0x000026CF
		private void ProcessXpsDocumentWriter(global::System.Windows.Xps.XpsDocumentWriter writer, global::System.Printing.PrintQueue printQueue)
		{
			this.ProcessXpsDocumentWriter(writer, null, printQueue);
		}

		// Token: 0x06000082 RID: 130 RVA: 0x000044DC File Offset: 0x000026DC
		private void ProcessXpsDocumentWriter(global::System.Windows.Xps.XpsDocumentWriter writer, global::System.Printing.PrintTicket printTicket, global::System.Printing.PrintQueue printQueue)
		{
			base.ClearCachedOriginAndSize();
			this._paginator.Initialize(this.ReportSettings);
			if (printTicket == null)
			{
				if (printQueue != null)
				{
					printTicket = printQueue.UserPrintTicket;
					if (printTicket == null)
					{
						printTicket = printQueue.DefaultPrintTicket;
					}
				}
				if (printTicket == null)
				{
					printTicket = new global::System.Printing.PrintTicket();
				}
			}
			writer.Write(this._paginator, printTicket);
			if (this._paginator.IsCancel)
			{
				this.CleanUpDocAndPackage();
				return;
			}
			this.OnWritingCompleted(this, new global::System.Windows.Documents.Serialization.WritingCompletedEventArgs(false, "State", null));
		}

		// Token: 0x06000083 RID: 131 RVA: 0x00004557 File Offset: 0x00002757
		private void RaisePrintStartEvent(global::System.EventArgs e)
		{
			if (this.PrintStart != null)
			{
				this.PrintStart(this, e);
			}
		}

		// Token: 0x06000084 RID: 132 RVA: 0x0000456E File Offset: 0x0000276E
		private void RaisePrintProgressEvent(global::Infragistics.Windows.Reporting.Events.PrintProgressEventArgs e)
		{
			if (this.PrintProgress != null)
			{
				this.PrintProgress(this, e);
			}
		}

		// Token: 0x06000085 RID: 133 RVA: 0x00004585 File Offset: 0x00002785
		private void RaisePrintEndedEvent(global::Infragistics.Windows.Reporting.Events.PrintEndedEventArgs e)
		{
			if (this.PrintEnded != null)
			{
				this.PrintEnded(this, e);
			}
		}

		// Token: 0x06000086 RID: 134 RVA: 0x0000459C File Offset: 0x0000279C
		private void VerifyAtLeastOneSection()
		{
			global::Infragistics.Windows.Reporting.ReportSectionCollection sections = this.Sections;
			if (sections == null || sections.Count == 0)
			{
				throw new global::System.InvalidOperationException(global::SR.GetString("LE_Report_NoSections"));
			}
		}

		// Token: 0x06000087 RID: 135 RVA: 0x000045CB File Offset: 0x000027CB
		protected void OnPrintProgress(object sender, global::Infragistics.Windows.Reporting.Events.PrintProgressEventArgs e)
		{
			this._countPrintedPages++;
			this.RaisePrintProgressEvent(e);
			if (e != null && e.Cancel)
			{
				this._paginator.IsCancel = true;
				this.OnWritingCanceled(this, new global::System.Windows.Documents.Serialization.WritingCancelledEventArgs(null));
			}
		}

		// Token: 0x06000088 RID: 136 RVA: 0x00004608 File Offset: 0x00002808
		protected void OnWritingCompleted(object sender, global::System.Windows.Documents.Serialization.WritingCompletedEventArgs e)
		{
			this.CleanUpDocAndPackage();
			this.InvokeEndPaginationIfNeeded();
			global::Infragistics.Windows.Reporting.PrintStatus status;
			if (e.Cancelled)
			{
				status = global::Infragistics.Windows.Reporting.PrintStatus.Canceled;
			}
			else if (e.Error == null)
			{
				status = global::Infragistics.Windows.Reporting.PrintStatus.Successful;
			}
			else
			{
				status = global::Infragistics.Windows.Reporting.PrintStatus.Canceled;
			}
			global::Infragistics.Windows.Reporting.Events.PrintEndedEventArgs e2 = new global::Infragistics.Windows.Reporting.Events.PrintEndedEventArgs(status, this._countPrintedPages);
			this.RaisePrintEndedEvent(e2);
			this.CloseReportProgressControl();
		}

		// Token: 0x06000089 RID: 137 RVA: 0x00004658 File Offset: 0x00002858
		protected void OnWritingCanceled(object sender, global::System.Windows.Documents.Serialization.WritingCancelledEventArgs e)
		{
			global::Infragistics.Windows.Reporting.Events.PrintEndedEventArgs e2 = new global::Infragistics.Windows.Reporting.Events.PrintEndedEventArgs(global::Infragistics.Windows.Reporting.PrintStatus.Canceled, this._countPrintedPages);
			this.RaisePrintEndedEvent(e2);
			this.InvokeEndPaginationIfNeeded();
			this.CloseReportProgressControl();
		}

		// Token: 0x0600008A RID: 138 RVA: 0x00004688 File Offset: 0x00002888
		public void Export(global::Infragistics.Windows.Reporting.OutputFormat outputFormat)
		{
			this.VerifyAtLeastOneSection();
			this.RaisePrintStartEvent(new global::System.EventArgs());
			if (outputFormat != global::Infragistics.Windows.Reporting.OutputFormat.XPS)
			{
				return;
			}
			this.ExportToXPS();
		}

		// Token: 0x0600008B RID: 139 RVA: 0x000046B3 File Offset: 0x000028B3
		public void Export(global::Infragistics.Windows.Reporting.OutputFormat outputFormat, string fileName)
		{
			this.Export(outputFormat, fileName, false);
		}

		// Token: 0x0600008C RID: 140 RVA: 0x000046C0 File Offset: 0x000028C0
		public void Export(global::Infragistics.Windows.Reporting.OutputFormat outputFormat, string fileName, bool showSaveFileDialog)
		{
			this.VerifyAtLeastOneSection();
			string fileName2;
			if (showSaveFileDialog)
			{
				global::System.Windows.Forms.SaveFileDialog saveFileDialog = new global::System.Windows.Forms.SaveFileDialog();
				saveFileDialog.FileName = fileName;
				saveFileDialog.Filter = "xps files (*.xps)|*.xps|All files (*.*)|*.*";
				if (saveFileDialog.ShowDialog() != global::System.Windows.Forms.DialogResult.OK)
				{
					return;
				}
				fileName2 = saveFileDialog.FileName;
			}
			else
			{
				fileName2 = fileName;
			}
			this.RaisePrintStartEvent(new global::System.EventArgs());
			if (outputFormat != global::Infragistics.Windows.Reporting.OutputFormat.XPS)
			{
				return;
			}
			this.ExportToXPS(fileName2);
		}

		// Token: 0x0600008D RID: 141 RVA: 0x00004724 File Offset: 0x00002924
		public void Export(global::Infragistics.Windows.Reporting.OutputFormat outputFormat, global::System.IO.Stream stream)
		{
			this.VerifyAtLeastOneSection();
			this.RaisePrintStartEvent(new global::System.EventArgs());
			if (outputFormat != global::Infragistics.Windows.Reporting.OutputFormat.XPS)
			{
				return;
			}
			this.ExportToXPS(stream);
		}

		// Token: 0x0600008E RID: 142 RVA: 0x00004750 File Offset: 0x00002950
		public void Print()
		{
			this.Print(true, false);
		}

		// Token: 0x0600008F RID: 143 RVA: 0x0000475A File Offset: 0x0000295A
		public void Print(bool showPrintDialog, bool showReportProgressControl)
		{
			this.Print(showPrintDialog, showReportProgressControl, null);
		}

		// Token: 0x06000090 RID: 144 RVA: 0x00004768 File Offset: 0x00002968
		public void Print(bool showPrintDialog, bool showReportProgressControl, global::System.Windows.FrameworkElement reportProgressControlOwnedElement)
		{
			this.VerifyAtLeastOneSection();
			this._explicitPageSize = global::System.Windows.Size.Empty;
			base.ClearCachedOriginAndSize();
			this._reportProgressControlOwnedElement = reportProgressControlOwnedElement;
			this._countPrintedPages = 0;
			this.RaisePrintStartEvent(new global::System.EventArgs());
			if (global::System.Drawing.Printing.PrinterSettings.InstalledPrinters.Count == 0)
			{
				this._reportProgressControlOwnedElement = null;
				this.RaisePrintEndedEvent(new global::Infragistics.Windows.Reporting.Events.PrintEndedEventArgs(global::Infragistics.Windows.Reporting.PrintStatus.Canceled, 0, global::Infragistics.Windows.Reporting.PrintCancelationReason.NoPrinterAvailable));
				return;
			}
			if (!global::System.Windows.Interop.BrowserInteropHelper.IsBrowserHosted)
			{
				if (!this.InitializeReport(showPrintDialog))
				{
					return;
				}
				if (showReportProgressControl)
				{
					this.ShowReportProgressControl();
				}
				try
				{
					this.GenerateReport(this.ReportSettings.PrintQueue);
					goto IL_92;
				}
				catch
				{
					if (showReportProgressControl)
					{
						this.CloseReportProgressControl();
					}
					throw;
				}
			}
			this.PrintViaPrintDialog(showReportProgressControl);
			IL_92:
			this._reportProgressControlOwnedElement = null;
		}

		// Token: 0x06000091 RID: 145 RVA: 0x00004820 File Offset: 0x00002A20
		public bool ShowPrintDialog()
		{
			global::System.Windows.Controls.PrintDialog printDialog = this.CreateAndInitializePrintDialog();
			global::System.Windows.Size originalPrintAreaSize = default(global::System.Windows.Size);
			try
			{
				originalPrintAreaSize = new global::System.Windows.Size(printDialog.PrintableAreaWidth, printDialog.PrintableAreaHeight);
			}
			catch (global::System.Printing.PrintQueueException)
			{
			}
			if (printDialog.ShowDialog() == false)
			{
				return false;
			}
			this.UpdateSettingsFromPrintDialog(printDialog, true, originalPrintAreaSize);
			return true;
		}

		// Token: 0x14000004 RID: 4
		// (add) Token: 0x06000092 RID: 146 RVA: 0x0000488C File Offset: 0x00002A8C
		// (remove) Token: 0x06000093 RID: 147 RVA: 0x000048C4 File Offset: 0x00002AC4
		public event global::System.EventHandler<global::Infragistics.Windows.Reporting.Events.PrintProgressEventArgs> PrintProgress;

		// Token: 0x14000005 RID: 5
		// (add) Token: 0x06000094 RID: 148 RVA: 0x000048FC File Offset: 0x00002AFC
		// (remove) Token: 0x06000095 RID: 149 RVA: 0x00004934 File Offset: 0x00002B34
		public event global::System.EventHandler PrintStart;

		// Token: 0x14000006 RID: 6
		// (add) Token: 0x06000096 RID: 150 RVA: 0x0000496C File Offset: 0x00002B6C
		// (remove) Token: 0x06000097 RID: 151 RVA: 0x000049A4 File Offset: 0x00002BA4
		public event global::System.EventHandler<global::Infragistics.Windows.Reporting.Events.PrintEndedEventArgs> PrintEnded;

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x06000098 RID: 152 RVA: 0x000049D9 File Offset: 0x00002BD9
		global::System.Windows.Documents.DocumentPaginator global::System.Windows.Documents.IDocumentPaginatorSource.DocumentPaginator
		{
			get
			{
				return this._paginator;
			}
		}

		// Token: 0x04000030 RID: 48
		private global::Infragistics.Windows.Controls.ToolWindow _buildInProgressWnd;

		// Token: 0x04000031 RID: 49
		private int _countPrintedPages;

		// Token: 0x04000032 RID: 50
		private global::Infragistics.Windows.Reporting.Report.Paginator _paginator;

		// Token: 0x04000033 RID: 51
		private global::Infragistics.Windows.Reporting.ReportSectionCollection _sections;

		// Token: 0x04000034 RID: 52
		private int _physicalPageNumber;

		// Token: 0x04000035 RID: 53
		private int _logicalPageNumber;

		// Token: 0x04000036 RID: 54
		private int _logicalPagePartNumber;

		// Token: 0x04000037 RID: 55
		private int _sectionPhysicalPageNumber;

		// Token: 0x04000038 RID: 56
		private int _sectionLogicalPageNumber;

		// Token: 0x04000039 RID: 57
		private int _sectionLogicalPagePartNumber;

		// Token: 0x0400003A RID: 58
		private int _runningLogicalPageCount;

		// Token: 0x0400003B RID: 59
		private global::System.Windows.FrameworkElement _reportProgressControlOwnedElement;

		// Token: 0x0400003C RID: 60
		private global::System.IO.Packaging.Package _exportPackage;

		// Token: 0x0400003D RID: 61
		private global::System.Windows.Xps.Packaging.XpsDocument _exportDoc;

		// Token: 0x0400003E RID: 62
		private global::System.Windows.Size _explicitPageSize = global::System.Windows.Size.Empty;

		// Token: 0x0400003F RID: 63
		private bool _isGeneratingPreview;

		// Token: 0x04000040 RID: 64
		private global::Infragistics.Windows.Reporting.ReportSettings _reportSettings;

		// Token: 0x04000041 RID: 65
		private string _defaultExportFileName = "Export.xsp";

		// Token: 0x04000042 RID: 66
		private bool _hasCalledBeginPagination;

		// Token: 0x02000011 RID: 17
		private class Paginator : global::System.Windows.Documents.DocumentPaginator
		{
			// Token: 0x06000099 RID: 153 RVA: 0x000049E1 File Offset: 0x00002BE1
			internal Paginator(global::Infragistics.Windows.Reporting.Report report)
			{
				this._isPreviewMode = false;
				this._isPageCountValid = false;
				this._report = report;
				this._isCancel = false;
			}

			// Token: 0x0600009A RID: 154 RVA: 0x00004A08 File Offset: 0x00002C08
			public override global::System.Windows.Documents.DocumentPage GetPage(int pageNumber)
			{
				this._report._runningLogicalPageCount = 0;
				if (this._report.Sections.Count == 0)
				{
					return null;
				}
				this._report.PhysicalPageNumber = pageNumber + this.PageRange.PageFrom;
				bool flag = pageNumber > 0;
				int count = this._report.Sections.Count;
				while (this._currentSectionIndex < count)
				{
					global::Infragistics.Windows.Reporting.ReportSection reportSection = this._report.Sections[this._currentSectionIndex];
					if (reportSection != null)
					{
						int pageNumber2 = pageNumber + this._pageRange.PageFrom - this._totalPagesProcessed - 1;
						global::System.Windows.Documents.DocumentPage page = reportSection.GetPage(pageNumber2);
						if (page != null)
						{
							if (this._currentSectionIndex == this._report.Sections.Count - 1 && reportSection.IsEndReached)
							{
								this._isPageCountValid = true;
							}
							if (pageNumber + this._pageRange.PageFrom >= this._pageRange.PageTo && this._pageRange.PageTo != 0)
							{
								this._isPageCountValid = true;
							}
							this._maxLogicalNumbers[this._currentSectionIndex] = global::System.Math.Max(this._maxLogicalNumbers[this._currentSectionIndex], reportSection.LogicalPageNumber);
							this._report.LogicalPageNumber = reportSection.LogicalPageNumber + this._report.RunningLogicalPageCount;
							this._report.LogicalPagePartNumber = reportSection.LogicalPagePartNumber;
							this._report.SectionPhysicalPageNumber = reportSection.PhysicalPageNumber;
							this._report.SectionLogicalPageNumber = reportSection.LogicalPageNumber;
							this._report.SectionLogicalPagePartNumber = reportSection.LogicalPagePartNumber;
							global::System.Windows.UIElement uielement = page.Visual as global::System.Windows.UIElement;
							if (uielement != null)
							{
								uielement.InvalidateMeasure();
								uielement.InvalidateArrange();
								uielement.Measure(page.Size);
								uielement.Arrange(new global::System.Windows.Rect(default(global::System.Windows.Point), page.Size));
								uielement.UpdateLayout();
							}
							if (this._isPreviewMode)
							{
								this._pageVisual = this.CreatePreviewCopy(page.Visual);
							}
							this.RaisePrintProgress(pageNumber);
							return page;
						}
						if (this._currentSectionIndex < count - 1)
						{
							if (flag)
							{
								this._totalPagesProcessed += reportSection.GeneratedPageCount;
							}
							else
							{
								global::Infragistics.Windows.Reporting.EmbeddedVisualReportSection embeddedVisualReportSection = reportSection as global::Infragistics.Windows.Reporting.EmbeddedVisualReportSection;
								int num;
								if (embeddedVisualReportSection != null)
								{
									num = global::System.Math.Max(embeddedVisualReportSection.EstmatedPageCount, 1);
								}
								else
								{
									num = 1;
								}
								this._totalPagesProcessed += num;
							}
						}
						else
						{
							this._totalPagesProcessed += reportSection.GeneratedPageCount;
							this._report._runningLogicalPageCount += this._maxLogicalNumbers[this._currentSectionIndex];
						}
					}
					this._currentSectionIndex++;
				}
				if (pageNumber > this._totalPagesProcessed)
				{
					throw new global::System.ArgumentOutOfRangeException("pageNumber", global::Infragistics.Windows.Reporting.XamReportPreview.GetString("LE_ReportPaginator_OutOfRangeException"));
				}
				this._isPageCountValid = true;
				global::System.Windows.Size size = new global::System.Windows.Size(100.0, 100.0);
				return new global::System.Windows.Documents.DocumentPage(new global::System.Windows.Controls.Canvas(), size, new global::System.Windows.Rect(size), new global::System.Windows.Rect(size));
			}

			// Token: 0x17000021 RID: 33
			// (get) Token: 0x0600009B RID: 155 RVA: 0x00004D12 File Offset: 0x00002F12
			public override bool IsPageCountValid
			{
				get
				{
					return this._isPageCountValid;
				}
			}

			// Token: 0x17000022 RID: 34
			// (get) Token: 0x0600009C RID: 156 RVA: 0x00004D1A File Offset: 0x00002F1A
			public override int PageCount
			{
				get
				{
					return 0;
				}
			}

			// Token: 0x17000023 RID: 35
			// (get) Token: 0x0600009D RID: 157 RVA: 0x00004D1D File Offset: 0x00002F1D
			// (set) Token: 0x0600009E RID: 158 RVA: 0x00004D25 File Offset: 0x00002F25
			public override global::System.Windows.Size PageSize
			{
				get
				{
					return this._pageSize;
				}
				set
				{
					this._pageSize = value;
				}
			}

			// Token: 0x17000024 RID: 36
			// (get) Token: 0x0600009F RID: 159 RVA: 0x00004D2E File Offset: 0x00002F2E
			public override global::System.Windows.Documents.IDocumentPaginatorSource Source
			{
				get
				{
					return this._report;
				}
			}

			// Token: 0x17000025 RID: 37
			// (get) Token: 0x060000A1 RID: 161 RVA: 0x00004D3F File Offset: 0x00002F3F
			// (set) Token: 0x060000A0 RID: 160 RVA: 0x00004D36 File Offset: 0x00002F36
			internal global::System.Windows.Controls.PageRange PageRange
			{
				get
				{
					return this._pageRange;
				}
				set
				{
					this._pageRange = value;
				}
			}

			// Token: 0x17000026 RID: 38
			// (set) Token: 0x060000A2 RID: 162 RVA: 0x00004D47 File Offset: 0x00002F47
			internal int PrintPageCount
			{
				set
				{
					this._printPageCount = value;
				}
			}

			// Token: 0x17000027 RID: 39
			// (set) Token: 0x060000A3 RID: 163 RVA: 0x00004D50 File Offset: 0x00002F50
			internal bool IsPreviewMode
			{
				set
				{
					this._isPreviewMode = value;
				}
			}

			// Token: 0x17000028 RID: 40
			// (get) Token: 0x060000A4 RID: 164 RVA: 0x00004D59 File Offset: 0x00002F59
			internal global::System.Windows.Media.Visual PageVisual
			{
				get
				{
					return this._pageVisual;
				}
			}

			// Token: 0x17000029 RID: 41
			// (get) Token: 0x060000A6 RID: 166 RVA: 0x00004D71 File Offset: 0x00002F71
			// (set) Token: 0x060000A5 RID: 165 RVA: 0x00004D61 File Offset: 0x00002F61
			internal bool IsCancel
			{
				get
				{
					return this._isCancel;
				}
				set
				{
					this._isPageCountValid = true;
					this._isCancel = true;
				}
			}

			// Token: 0x060000A7 RID: 167 RVA: 0x00004D7C File Offset: 0x00002F7C
			internal void BeginPagination()
			{
				this._currentSectionIndex = 0;
				this._totalPagesProcessed = 0;
				this._maxLogicalNumbers = new global::System.Collections.Generic.List<int>();
				this._printPageCount = 0;
				foreach (global::Infragistics.Windows.Reporting.ReportSection reportSection in this._report.Sections)
				{
					this._maxLogicalNumbers.Add(0);
					reportSection.OnBeginPagination(this._report);
					if (reportSection is global::Infragistics.Windows.Reporting.EmbeddedVisualReportSection)
					{
						this._printPageCount += ((global::Infragistics.Windows.Reporting.EmbeddedVisualReportSection)reportSection).EstmatedPageCount;
					}
					else
					{
						this._printPageCount++;
					}
					if (this._pageRange.PageTo != 0 && this._pageRange.PageTo >= this._pageRange.PageFrom && this._pageRange.PageTo <= this._printPageCount)
					{
						this._printPageCount = this._pageRange.PageTo - this._pageRange.PageFrom;
					}
				}
			}

			// Token: 0x060000A8 RID: 168 RVA: 0x00004E8C File Offset: 0x0000308C
			internal global::System.Windows.Media.Visual CreatePreviewCopy(global::System.Windows.Media.Visual pageContent)
			{
				double num = 2.0;
				global::System.Windows.Media.Imaging.RenderTargetBitmap renderTargetBitmap = new global::System.Windows.Media.Imaging.RenderTargetBitmap((int)(this._pageSize.Width * num), (int)(this._pageSize.Height * num), 96.0 * num, 96.0 * num, global::System.Windows.Media.PixelFormats.Default);
				renderTargetBitmap.Render(pageContent);
				global::System.Windows.Media.ImageBrush fill = new global::System.Windows.Media.ImageBrush(renderTargetBitmap);
				global::System.Windows.Controls.StackPanel stackPanel = new global::System.Windows.Controls.StackPanel();
				global::System.Windows.Shapes.Rectangle rectangle = new global::System.Windows.Shapes.Rectangle();
				rectangle.Width = this._pageSize.Width;
				rectangle.Height = this._pageSize.Height;
				rectangle.Fill = fill;
				stackPanel.Children.Add(rectangle);
				return stackPanel;
			}

			// Token: 0x060000A9 RID: 169 RVA: 0x00004F38 File Offset: 0x00003138
			internal void EndPagination()
			{
				foreach (global::Infragistics.Windows.Reporting.ReportSection reportSection in this._report.Sections)
				{
					reportSection.OnEndPagination();
				}
			}

			// Token: 0x060000AA RID: 170 RVA: 0x00004F8C File Offset: 0x0000318C
			internal void Initialize(global::Infragistics.Windows.Reporting.ReportSettings settings)
			{
				this._isPreviewMode = false;
				this._isPageCountValid = false;
				this._isCancel = false;
				this.PageRange = settings.PageRange;
				this.PageSize = this._report.PageSizeResolved;
				this.BeginPagination();
				this._report._hasCalledBeginPagination = true;
			}

			// Token: 0x060000AB RID: 171 RVA: 0x00004FE0 File Offset: 0x000031E0
			private void RaisePrintProgress(int pageNumber)
			{
				int num = pageNumber + 1;
				double num2 = (double)num / (double)this._printPageCount * 100.0;
				string @string;
				if (this._report != null && this._report.IsGeneratingPreview)
				{
					@string = global::Infragistics.Windows.Reporting.XamReportPreview.GetString("ProgressPrintingDescription_Preview", new object[]
					{
						num
					});
				}
				else
				{
					@string = global::Infragistics.Windows.Reporting.XamReportPreview.GetString("ProgressPrintingDescription", new object[]
					{
						num
					});
				}
				global::Infragistics.Windows.Reporting.Events.PrintProgressEventArgs e = new global::Infragistics.Windows.Reporting.Events.PrintProgressEventArgs(num, @string, (double)((int)num2));
				if (this.PrintProgress != null)
				{
					this.PrintProgress(this, e);
				}
			}

			// Token: 0x14000007 RID: 7
			// (add) Token: 0x060000AC RID: 172 RVA: 0x0000507C File Offset: 0x0000327C
			// (remove) Token: 0x060000AD RID: 173 RVA: 0x000050B4 File Offset: 0x000032B4
			internal event global::System.EventHandler<global::Infragistics.Windows.Reporting.Events.PrintProgressEventArgs> PrintProgress;

			// Token: 0x04000046 RID: 70
			private global::System.Windows.Media.Visual _pageVisual;

			// Token: 0x04000047 RID: 71
			private global::System.Collections.Generic.List<int> _maxLogicalNumbers;

			// Token: 0x04000048 RID: 72
			private int _printPageCount;

			// Token: 0x04000049 RID: 73
			private global::System.Windows.Controls.PageRange _pageRange;

			// Token: 0x0400004A RID: 74
			private global::System.Windows.Size _pageSize;

			// Token: 0x0400004B RID: 75
			private global::Infragistics.Windows.Reporting.Report _report;

			// Token: 0x0400004C RID: 76
			private bool _isPageCountValid;

			// Token: 0x0400004D RID: 77
			private bool _isPreviewMode;

			// Token: 0x0400004E RID: 78
			private bool _isCancel;

			// Token: 0x0400004F RID: 79
			private int _currentSectionIndex;

			// Token: 0x04000050 RID: 80
			private int _totalPagesProcessed;
		}
	}
}
