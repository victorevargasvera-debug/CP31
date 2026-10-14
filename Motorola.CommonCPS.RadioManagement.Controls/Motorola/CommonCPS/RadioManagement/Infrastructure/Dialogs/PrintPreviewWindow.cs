using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Markup;
using Infragistics.Windows.DataPresenter;
using Infragistics.Windows.Reporting;
using Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree;

namespace Motorola.CommonCPS.RadioManagement.Infrastructure.Dialogs
{
	// Token: 0x02000007 RID: 7
	public class PrintPreviewWindow : global::System.Windows.Window, global::System.Windows.Markup.IComponentConnector
	{
		// Token: 0x06000013 RID: 19 RVA: 0x00002950 File Offset: 0x00000B50
		public PrintPreviewWindow(global::Infragistics.Windows.DataPresenter.XamDataGrid dataGrid)
		{
			this.InitializeComponent();
			global::Infragistics.Windows.Reporting.Report report = new global::Infragistics.Windows.Reporting.Report();
			global::Infragistics.Windows.Reporting.EmbeddedVisualReportSection item = new global::Infragistics.Windows.Reporting.EmbeddedVisualReportSection(dataGrid);
			report.Sections.Add(item);
			this.reportPreview.FontSize = 0.5;
			report.ReportSettings.HorizontalPaginationMode = global::Infragistics.Windows.Reporting.HorizontalPaginationMode.Scale;
			report.ReportSettings.PagePrintOrder = global::Infragistics.Windows.Reporting.PagePrintOrder.Vertical;
			report.ReportSettings.PageOrientation = global::Infragistics.Windows.Reporting.PageOrientation.Landscape;
			this.reportPreview.GeneratePreview(report, false, true);
		}

		// Token: 0x06000014 RID: 20 RVA: 0x000029C8 File Offset: 0x00000BC8
		[global::System.Diagnostics.DebuggerNonUserCode]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		public void InitializeComponent()
		{
			int a_ = 6;
			if (this._contentLoaded)
			{
				short num = (short)2134998937;
				short num2 = num;
				num = (short)1108901785;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_B2;
				case 1:
					break;
				default:
				{
					num = (short)1098514432;
					short num3 = num;
					break;
				}
				}
				num = (short)137297921;
				if (num != 0)
				{
				}
				num = (short)989986816;
				if (num != 0)
				{
				}
				return;
			}
			IL_B2:
			this._contentLoaded = true;
			global::System.Uri resourceLocator = new global::System.Uri(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("놝춡킣즥\udaa7얩삫쾭麯\udbb3\udbb5햷햹튻ﶽ邿釁铅꧇껉ꗋꇍ鷏돑뫓럕뿗뿙뇛믝軟雡쫣ꗥ蟧蓩飫鳭鿯黱蟳췵鯷闹釻軽濿氁愃栅簇┉笋服縏瘑笓愕欗㔙氛氝䤟䰡倣嘥娧伩娫䜭唯䔱䌳張嘷帹医䤽渿㩁╃⭅⑇", a_), global::System.UriKind.Relative);
			global::System.Windows.Application.LoadComponent(this, resourceLocator);
		}

		// Token: 0x06000015 RID: 21 RVA: 0x00002AAC File Offset: 0x00000CAC
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::System.Diagnostics.DebuggerNonUserCode]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		void global::System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
		{
			if (connectionId == 1)
			{
				short num = (short)464060417;
				if (num != 0)
				{
				}
				num = (short)868810752;
				short num2 = num;
				num = (short)899933288;
				short num3 = num;
				num = (short)1848108136;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)172163072;
					if (num != 0)
					{
					}
					this.reportPreview = (global::Infragistics.Windows.Reporting.XamReportPreview)target;
					return;
				}
			}
			this._contentLoaded = true;
		}

		// Token: 0x04000006 RID: 6
		internal global::Infragistics.Windows.Reporting.XamReportPreview reportPreview;

		// Token: 0x04000007 RID: 7
		private bool _contentLoaded;
	}
}
