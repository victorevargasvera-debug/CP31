using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using DevAge.ComponentModel;
using DevAge.ComponentModel.Converter;
using DevAge.Drawing;
using Gibraltar.Windows.UI;
using Loupe.Extensibility.Data;
using SourceGrid;
using SourceGrid.Cells;
using SourceGrid.Cells.Controllers;
using SourceGrid.Cells.Editors;
using SourceGrid.Cells.Models;
using SourceGrid.Cells.Views;

namespace Gibraltar.Monitor.Windows.Internal
{
	// Token: 0x020001E8 RID: 488
	internal class GridViewer : global::SourceGrid.DataGrid, global::SourceGrid.Cells.Models.IImage, global::SourceGrid.Cells.Models.IModel
	{
		// Token: 0x14000078 RID: 120
		// (add) Token: 0x060017B5 RID: 6069 RVA: 0x0004FD68 File Offset: 0x0004DF68
		// (remove) Token: 0x060017B6 RID: 6070 RVA: 0x0004FDA4 File Offset: 0x0004DFA4
		public event global::System.EventHandler ViewChanged;

		// Token: 0x14000079 RID: 121
		// (add) Token: 0x060017B7 RID: 6071 RVA: 0x0004FDE0 File Offset: 0x0004DFE0
		// (remove) Token: 0x060017B8 RID: 6072 RVA: 0x0004FE1C File Offset: 0x0004E01C
		public event global::System.EventHandler UserInteraction;

		// Token: 0x1400007A RID: 122
		// (add) Token: 0x060017B9 RID: 6073 RVA: 0x0004FE58 File Offset: 0x0004E058
		// (remove) Token: 0x060017BA RID: 6074 RVA: 0x0004FE94 File Offset: 0x0004E094
		public event global::System.EventHandler FilterChanged;

		// Token: 0x060017BB RID: 6075 RVA: 0x0004FED0 File Offset: 0x0004E0D0
		public GridViewer()
		{
			this.m_LogMessages = new global::System.Collections.Generic.List<global::Gibraltar.Monitor.Windows.Internal.GridViewer.ViewerLogMessageWrapper>();
			this.m_FilteredLogMessages = new global::System.Collections.Generic.List<global::Gibraltar.Monitor.Windows.Internal.GridViewer.ViewerLogMessageWrapper>();
			this.m_ImageCritical = global::Gibraltar.Windows.UI.SessionIcons.Critical;
			((global::System.Drawing.Bitmap)this.m_ImageCritical).MakeTransparent(global::System.Drawing.Color.Magenta);
			this.m_ImageError = global::Gibraltar.Windows.UI.SessionIcons.Error;
			((global::System.Drawing.Bitmap)this.m_ImageError).MakeTransparent(global::System.Drawing.Color.Magenta);
			this.m_ImageWarning = global::Gibraltar.Windows.UI.SessionIcons.Warning;
			((global::System.Drawing.Bitmap)this.m_ImageWarning).MakeTransparent(global::System.Drawing.Color.Magenta);
			this.m_ImageInfo = global::Gibraltar.Windows.UI.SessionIcons.Information;
			((global::System.Drawing.Bitmap)this.m_ImageInfo).MakeTransparent(global::System.Drawing.Color.Magenta);
			this.m_ImageVerbose = global::Gibraltar.Windows.UI.SessionIcons.Verbose;
			((global::System.Drawing.Bitmap)this.m_ImageVerbose).MakeTransparent(global::System.Drawing.Color.Magenta);
			base.BorderStyle = global::System.Windows.Forms.BorderStyle.Fixed3D;
			this.BackColor = global::System.Drawing.SystemColors.Window;
			base.Rows.AutoSizeMode = global::SourceGrid.AutoSizeMode.MinimumSize;
			base.AutoStretchColumnsToFitWidth = false;
			base.AutoStretchRowsToFitHeight = false;
			base.SelectionMode = global::SourceGrid.GridSelectionMode.Row;
			this.m_SequenceColumn = base.Columns.Add("Sequence", "Sequence", typeof(long));
			this.m_SequenceColumn.Tag = global::Gibraltar.Monitor.Windows.LogMessageColumn.Sequence;
			this.m_SequenceColumn.Visible = false;
			this.m_SeverityColumn = base.Columns.Add("Severity", string.Empty, typeof(global::Loupe.Extensibility.Data.LogMessageSeverity));
			this.m_SeverityColumn.Tag = global::Gibraltar.Monitor.Windows.LogMessageColumn.Severity;
			this.m_SeverityColumn.DataCell.Model.AddModel(new global::Gibraltar.Monitor.Windows.Internal.GridViewer.BoundImage());
			this.m_SeverityColumn.Width = 20;
			this.m_SeverityColumn.AutoSizeMode = global::SourceGrid.AutoSizeMode.None;
			this.m_SeverityColumn.DataCell.View.Border = new global::DevAge.Drawing.RectangleBorder(new global::DevAge.Drawing.BorderLine(global::System.Drawing.SystemColors.Window, 0f), new global::DevAge.Drawing.BorderLine(global::System.Drawing.SystemColors.Window, 0f));
			this.m_TimeColumn = base.Columns.Add("TimestampDateTime", "Time", typeof(global::System.DateTime));
			this.m_TimeColumn.Tag = global::Gibraltar.Monitor.Windows.LogMessageColumn.Timestamp;
			this.m_TimeColumn.Width = 136;
			this.m_TimeColumn.AutoSizeMode = global::SourceGrid.AutoSizeMode.None;
			global::System.ComponentModel.TypeConverter typeConverter = new global::DevAge.ComponentModel.Converter.DateTimeTypeConverter("G");
			this.m_TimeColumn.DataCell.Editor = new global::SourceGrid.Cells.Editors.TextBoxUITypeEditor(typeof(global::System.DateTime))
			{
				TypeConverter = typeConverter
			};
			this.m_UserNameColumn = base.Columns.Add("UserName", "User", typeof(string));
			this.m_UserNameColumn.Tag = global::Gibraltar.Monitor.Windows.LogMessageColumn.UserName;
			this.m_UserNameColumn.Width = 100;
			this.m_UserNameColumn.Visible = true;
			this.m_UserNameColumn.AutoSizeMode = global::SourceGrid.AutoSizeMode.None;
			this.m_MessageColumn = base.Columns.Add("Message", "Message", typeof(string));
			this.m_MessageColumn.Tag = global::Gibraltar.Monitor.Windows.LogMessageColumn.Caption;
			this.m_MessageColumn.Width = 300;
			this.m_MessageColumn.AutoSizeMode = global::SourceGrid.AutoSizeMode.None;
			this.m_ThreadNameColumn = base.Columns.Add("ThreadName", "Thread", typeof(string));
			this.m_ThreadNameColumn.Tag = global::Gibraltar.Monitor.Windows.LogMessageColumn.Thread;
			this.m_ThreadNameColumn.Width = 50;
			this.m_ThreadNameColumn.Visible = false;
			this.m_ThreadNameColumn.AutoSizeMode = global::SourceGrid.AutoSizeMode.None;
			this.m_MethodColumn = base.Columns.Add("MethodFullName", "Method", typeof(string));
			this.m_MethodColumn.Tag = global::Gibraltar.Monitor.Windows.LogMessageColumn.Method;
			this.m_MethodColumn.Width = 50;
			this.m_MethodColumn.Visible = false;
			this.m_MethodColumn.AutoSizeMode = global::SourceGrid.AutoSizeMode.None;
			this.m_SourceCodeLocationColumn = base.Columns.Add("SourceCodeLocation", "Source Code", typeof(string));
			this.m_SourceCodeLocationColumn.Tag = global::Gibraltar.Monitor.Windows.LogMessageColumn.SourceCodeLocation;
			this.m_SourceCodeLocationColumn.Width = 150;
			this.m_SourceCodeLocationColumn.Visible = false;
			this.m_SourceCodeLocationColumn.AutoSizeMode = global::SourceGrid.AutoSizeMode.None;
			base.DataSource = new global::Gibraltar.Monitor.Windows.Internal.GridViewer.LogMessageBoundList(this.m_FilteredLogMessages)
			{
				AllowEdit = false,
				AllowNew = false,
				AllowDelete = false,
				AllowSort = true
			};
			foreach (global::SourceGrid.ColumnInfo columnInfo in base.Columns)
			{
				global::SourceGrid.DataGridColumn dataGridColumn = (global::SourceGrid.DataGridColumn)columnInfo;
				dataGridColumn.HeaderCell.Model.FindModel(typeof(global::SourceGrid.Cells.Models.ISortableHeader));
				dataGridColumn.HeaderCell.Controller.FindController(typeof(global::SourceGrid.Cells.Controllers.SortableHeader));
				dataGridColumn.HeaderCell.Controller.FindController(typeof(bool));
				dataGridColumn.DataCell.AddController(global::SourceGrid.Cells.Controllers.ToolTipText.Default);
				dataGridColumn.DataCell.Model.AddModel(this.m_ToolTipModel);
				dataGridColumn.DataCell.View.TextAlignment = global::DevAge.Drawing.ContentAlignment.TopLeft;
				((global::SourceGrid.Cells.Views.ViewBase)dataGridColumn.DataCell.View).ImageAlignment = global::DevAge.Drawing.ContentAlignment.TopLeft;
				dataGridColumn.DataCell.View.WordWrap = true;
			}
			base.ToolTip.AutoPopDelay = 60000;
			base.ToolTip.InitialDelay = 200;
			base.ToolTip.ReshowDelay = 0;
			base.ToolTip.ShowAlways = false;
			base.ToolTip.UseAnimation = true;
			base.ToolTip.UseFading = true;
			this.MaxMessages = 10000;
		}

		// Token: 0x060017BC RID: 6076 RVA: 0x00050484 File Offset: 0x0004E684
		protected override global::SourceGrid.RowsBase CreateRowsObject()
		{
			return new global::Gibraltar.Monitor.Windows.Internal.GridViewerRows(this);
		}

		// Token: 0x1700081E RID: 2078
		// (get) Token: 0x060017BD RID: 6077 RVA: 0x0005048C File Offset: 0x0004E68C
		// (set) Token: 0x060017BE RID: 6078 RVA: 0x0005049C File Offset: 0x0004E69C
		public bool ShowDetailsInTooltips
		{
			get
			{
				return this.m_ToolTipModel.ShowDetails;
			}
			set
			{
				this.m_ToolTipModel.ShowDetails = value;
			}
		}

		// Token: 0x1700081F RID: 2079
		// (get) Token: 0x060017BF RID: 6079 RVA: 0x000504AC File Offset: 0x0004E6AC
		public bool Sorted
		{
			get
			{
				return this.m_SortColumn != 0;
			}
		}

		// Token: 0x17000820 RID: 2080
		// (get) Token: 0x060017C0 RID: 6080 RVA: 0x000504B8 File Offset: 0x0004E6B8
		// (set) Token: 0x060017C1 RID: 6081 RVA: 0x000504C8 File Offset: 0x0004E6C8
		public bool EnableMultiSelection
		{
			get
			{
				return base.Selection.EnableMultiSelection;
			}
			set
			{
				base.Selection.EnableMultiSelection = value;
			}
		}

		// Token: 0x17000821 RID: 2081
		// (get) Token: 0x060017C2 RID: 6082 RVA: 0x000504D8 File Offset: 0x0004E6D8
		// (set) Token: 0x060017C3 RID: 6083 RVA: 0x000504E0 File Offset: 0x0004E6E0
		public bool Frozen
		{
			get
			{
				return this.m_Frozen;
			}
			set
			{
				this.m_Frozen = value;
			}
		}

		// Token: 0x17000822 RID: 2082
		// (get) Token: 0x060017C4 RID: 6084 RVA: 0x000504EC File Offset: 0x0004E6EC
		// (set) Token: 0x060017C5 RID: 6085 RVA: 0x000504F4 File Offset: 0x0004E6F4
		public bool AutoScrollMessages { get; set; }

		// Token: 0x17000823 RID: 2083
		// (get) Token: 0x060017C6 RID: 6086 RVA: 0x00050500 File Offset: 0x0004E700
		// (set) Token: 0x060017C7 RID: 6087 RVA: 0x00050508 File Offset: 0x0004E708
		public int MaxMessages { get; set; }

		// Token: 0x17000824 RID: 2084
		// (get) Token: 0x060017C8 RID: 6088 RVA: 0x00050514 File Offset: 0x0004E714
		// (set) Token: 0x060017C9 RID: 6089 RVA: 0x0005051C File Offset: 0x0004E71C
		public bool ShowCriticalMessages { get; set; }

		// Token: 0x17000825 RID: 2085
		// (get) Token: 0x060017CA RID: 6090 RVA: 0x00050528 File Offset: 0x0004E728
		// (set) Token: 0x060017CB RID: 6091 RVA: 0x00050530 File Offset: 0x0004E730
		public bool ShowErrorMessages { get; set; }

		// Token: 0x17000826 RID: 2086
		// (get) Token: 0x060017CC RID: 6092 RVA: 0x0005053C File Offset: 0x0004E73C
		// (set) Token: 0x060017CD RID: 6093 RVA: 0x00050544 File Offset: 0x0004E744
		public bool ShowWarningMessages { get; set; }

		// Token: 0x17000827 RID: 2087
		// (get) Token: 0x060017CE RID: 6094 RVA: 0x00050550 File Offset: 0x0004E750
		// (set) Token: 0x060017CF RID: 6095 RVA: 0x00050558 File Offset: 0x0004E758
		public bool ShowInformationMessages { get; set; }

		// Token: 0x17000828 RID: 2088
		// (get) Token: 0x060017D0 RID: 6096 RVA: 0x00050564 File Offset: 0x0004E764
		// (set) Token: 0x060017D1 RID: 6097 RVA: 0x0005056C File Offset: 0x0004E76C
		public bool ShowVerboseMessages { get; set; }

		// Token: 0x17000829 RID: 2089
		// (get) Token: 0x060017D2 RID: 6098 RVA: 0x00050578 File Offset: 0x0004E778
		// (set) Token: 0x060017D3 RID: 6099 RVA: 0x00050580 File Offset: 0x0004E780
		public string SearchText
		{
			get
			{
				return this.m_SearchText;
			}
			set
			{
				if (string.IsNullOrEmpty(value))
				{
					value = string.Empty;
				}
				if (this.m_SearchText == value.ToLower())
				{
					return;
				}
				this.m_SearchText = value.ToLower();
				this.FilterMessages();
			}
		}

		// Token: 0x1700082A RID: 2090
		// (get) Token: 0x060017D4 RID: 6100 RVA: 0x000505C0 File Offset: 0x0004E7C0
		public int MessageCount
		{
			get
			{
				return this.m_LogMessages.Count;
			}
		}

		// Token: 0x1700082B RID: 2091
		// (get) Token: 0x060017D5 RID: 6101 RVA: 0x000505D0 File Offset: 0x0004E7D0
		public int CriticalMessageCount
		{
			get
			{
				return this.m_CriticalCount;
			}
		}

		// Token: 0x1700082C RID: 2092
		// (get) Token: 0x060017D6 RID: 6102 RVA: 0x000505D8 File Offset: 0x0004E7D8
		public int ErrorMessageCount
		{
			get
			{
				return this.m_ErrorCount;
			}
		}

		// Token: 0x1700082D RID: 2093
		// (get) Token: 0x060017D7 RID: 6103 RVA: 0x000505E0 File Offset: 0x0004E7E0
		public int WarningMessageCount
		{
			get
			{
				return this.m_WarningCount;
			}
		}

		// Token: 0x1700082E RID: 2094
		// (get) Token: 0x060017D8 RID: 6104 RVA: 0x000505E8 File Offset: 0x0004E7E8
		public int InfoMessageCount
		{
			get
			{
				return this.m_InfoCount;
			}
		}

		// Token: 0x1700082F RID: 2095
		// (get) Token: 0x060017D9 RID: 6105 RVA: 0x000505F0 File Offset: 0x0004E7F0
		public int VerboseMessageCount
		{
			get
			{
				return this.m_VerboseCount;
			}
		}

		// Token: 0x17000830 RID: 2096
		// (get) Token: 0x060017DA RID: 6106 RVA: 0x000505F8 File Offset: 0x0004E7F8
		public long MinMessageId
		{
			get
			{
				if (this.m_LogMessages.Count <= 0)
				{
					return 0L;
				}
				return this.m_LogMessages[0].Sequence;
			}
		}

		// Token: 0x17000831 RID: 2097
		// (get) Token: 0x060017DB RID: 6107 RVA: 0x00050620 File Offset: 0x0004E820
		public int VisibleCount
		{
			get
			{
				return this.m_FilteredLogMessages.Count;
			}
		}

		// Token: 0x060017DC RID: 6108 RVA: 0x00050630 File Offset: 0x0004E830
		public void ClearSelection()
		{
			this.m_SelectedLogMessage = null;
			base.Selection.ResetSelection(false);
		}

		// Token: 0x060017DD RID: 6109 RVA: 0x00050648 File Offset: 0x0004E848
		public override void ChangeMouseDownCell(global::SourceGrid.Position p_MouseDownCell, global::SourceGrid.Position p_MouseCell)
		{
			if (p_MouseDownCell.Row > 0)
			{
				this.m_SelectedLogMessage = this.m_FilteredLogMessages[p_MouseDownCell.Row - 1];
			}
			base.ChangeMouseDownCell(p_MouseDownCell, p_MouseCell);
		}

		// Token: 0x060017DE RID: 6110 RVA: 0x00050688 File Offset: 0x0004E888
		public void FilterMessages()
		{
			base.DataSource.BeginAddNew();
			this.m_FilteredLogMessages.Clear();
			foreach (global::Gibraltar.Monitor.Windows.Internal.GridViewer.ViewerLogMessageWrapper viewerLogMessageWrapper in this.m_LogMessages)
			{
				if (this.MatchesSeverityFilter(viewerLogMessageWrapper.Severity) && this.MatchesSearchText(viewerLogMessageWrapper.Message))
				{
					this.m_FilteredLogMessages.Add(viewerLogMessageWrapper);
				}
			}
			this.Prune();
			if (this.Sorted)
			{
				this.SortByColumn(this.m_SortColumn, this.m_SortAscending);
			}
			base.DataSource.EndEdit(false);
			this.PerformResize();
			this.ShowSelectedRow();
			this.OnViewChanged();
			if (this.AutoScrollMessages)
			{
				this.MoveLast();
			}
			this.OnFilterChanged();
		}

		// Token: 0x060017DF RID: 6111 RVA: 0x00050778 File Offset: 0x0004E978
		private void ShowSelectedRow()
		{
			base.RecalcCustomScrollBars();
			int num = this.m_FilteredLogMessages.BinarySearch(this.m_SelectedLogMessage, new global::Gibraltar.Monitor.Windows.Internal.GridViewer.SequenceComparer());
			bool flag = num >= 0;
			int num2;
			if (num < 0)
			{
				num = ~num;
				if (num >= this.m_FilteredLogMessages.Count)
				{
					num2 = this.m_FilteredLogMessages.Count - 1;
				}
				else
				{
					num2 = num;
				}
			}
			else
			{
				num2 = num;
			}
			num2++;
			base.ShowCell(new global::SourceGrid.Position(num2, 0), true);
			int count = base.GetVisibleRows(true).Count;
			int num3 = num2 - count / 2;
			if (num3 <= 0)
			{
				num3 = 1;
			}
			base.ShowCell(new global::SourceGrid.Position(num3, 0), true);
			base.ShowCell(new global::SourceGrid.Position(num2, 0), true);
			if (flag)
			{
				base.Selection.FocusRow(num2);
				return;
			}
			base.Selection.ResetSelection(false);
		}

		// Token: 0x060017E0 RID: 6112 RVA: 0x00050858 File Offset: 0x0004EA58
		public void Add(global::Loupe.Extensibility.Data.ILogMessage newMessage)
		{
			this.AddRange(new global::Loupe.Extensibility.Data.ILogMessage[]
			{
				newMessage
			});
		}

		// Token: 0x060017E1 RID: 6113 RVA: 0x0005086C File Offset: 0x0004EA6C
		public void AddRange(global::Loupe.Extensibility.Data.ILogMessage[] newMessages)
		{
			base.DataSource.BeginAddNew();
			int i = 0;
			while (i < newMessages.Length)
			{
				global::Gibraltar.Monitor.Windows.Internal.GridViewer.ViewerLogMessageWrapper viewerLogMessageWrapper = new global::Gibraltar.Monitor.Windows.Internal.GridViewer.ViewerLogMessageWrapper(newMessages[i]);
				global::Loupe.Extensibility.Data.LogMessageSeverity severity = viewerLogMessageWrapper.Severity;
				switch (severity)
				{
				case global::Loupe.Extensibility.Data.LogMessageSeverity.Critical:
					this.m_CriticalCount++;
					break;
				case global::Loupe.Extensibility.Data.LogMessageSeverity.Error:
					this.m_ErrorCount++;
					break;
				case global::Loupe.Extensibility.Data.LogMessageSeverity.Critical | global::Loupe.Extensibility.Data.LogMessageSeverity.Error:
					goto IL_99;
				case global::Loupe.Extensibility.Data.LogMessageSeverity.Warning:
					this.m_WarningCount++;
					break;
				default:
					if (severity != global::Loupe.Extensibility.Data.LogMessageSeverity.Information)
					{
						goto IL_99;
					}
					this.m_InfoCount++;
					break;
				}
				IL_A7:
				this.m_LogMessages.Add(viewerLogMessageWrapper);
				if (this.MatchesSeverityFilter(viewerLogMessageWrapper.Severity) && this.MatchesSearchText(viewerLogMessageWrapper.Message))
				{
					this.m_FilteredLogMessages.Add(viewerLogMessageWrapper);
				}
				i++;
				continue;
				IL_99:
				this.m_VerboseCount++;
				goto IL_A7;
			}
			this.Prune();
			base.DataSource.EndEdit(false);
			if (this.AutoScrollMessages)
			{
				base.Columns.StretchToFit();
				this.MoveLast();
			}
			this.OnViewChanged();
		}

		// Token: 0x060017E2 RID: 6114 RVA: 0x000509A0 File Offset: 0x0004EBA0
		public void PerformResize()
		{
			this.OnResize(global::System.EventArgs.Empty);
		}

		// Token: 0x060017E3 RID: 6115 RVA: 0x000509B0 File Offset: 0x0004EBB0
		protected override void OnResize(global::System.EventArgs e)
		{
			if (!base.Visible)
			{
				return;
			}
			base.OnResize(e);
			base.SuspendLayout();
			base.SetScrollArea();
			int num = 480;
			global::SourceGrid.DataGridColumn columnForEnum = this.GetColumnForEnum(global::Gibraltar.Monitor.Windows.LogMessageColumn.Thread);
			bool flag = columnForEnum != null && columnForEnum.Visible;
			if (flag)
			{
				num += 100;
			}
			int num2 = global::System.Math.Max(base.ClientSize.Width - num, 0);
			this.m_SeverityColumn.Width = 20;
			this.m_TimeColumn.Width = 136;
			if (flag)
			{
				this.m_MessageColumn.Width = 300 + (int)((double)num2 * 0.75);
				this.m_ThreadNameColumn.Width = 50 + (int)((double)num2 * 0.05);
				this.m_MethodColumn.Width = 50 + (int)((double)num2 * 0.2);
			}
			else
			{
				this.m_MessageColumn.Width = 300 + num2;
			}
			base.Invalidate();
			base.ResumeLayout(true);
		}

		// Token: 0x060017E4 RID: 6116 RVA: 0x00050ABC File Offset: 0x0004ECBC
		public void ColumnVisible(global::Gibraltar.Monitor.Windows.LogMessageColumn column, bool visible)
		{
			global::SourceGrid.DataGridColumn columnForEnum = this.GetColumnForEnum(column);
			if (columnForEnum != null && columnForEnum.Visible != visible)
			{
				int width;
				if (visible)
				{
					width = base.DefaultWidth;
					switch (column)
					{
					case global::Gibraltar.Monitor.Windows.LogMessageColumn.Thread:
						width = 50;
						break;
					case global::Gibraltar.Monitor.Windows.LogMessageColumn.Method:
						width = 50;
						break;
					case global::Gibraltar.Monitor.Windows.LogMessageColumn.SourceCodeLocation:
						width = 150;
						break;
					}
				}
				else
				{
					width = 0;
				}
				columnForEnum.Visible = visible;
				columnForEnum.Width = width;
			}
		}

		// Token: 0x060017E5 RID: 6117 RVA: 0x00050B38 File Offset: 0x0004ED38
		public void CopyAll()
		{
			global::SourceGrid.RangeRegion region = new global::SourceGrid.RangeRegion(new global::SourceGrid.Range(1, 1, base.Rows.Count - 1, base.Columns.Count - 1));
			this.CopyToClipboard(region);
		}

		// Token: 0x060017E6 RID: 6118 RVA: 0x00050B78 File Offset: 0x0004ED78
		public void CopySelection()
		{
			global::SourceGrid.RangeRegion selectionRegion = base.Selection.GetSelectionRegion();
			this.CopyToClipboard(selectionRegion);
		}

		// Token: 0x060017E7 RID: 6119 RVA: 0x00050B9C File Offset: 0x0004ED9C
		public void Clear()
		{
			base.DataSource.BeginAddNew();
			this.m_LogMessages.Clear();
			this.m_CriticalCount = 0;
			this.m_ErrorCount = 0;
			this.m_WarningCount = 0;
			this.m_InfoCount = 0;
			this.m_VerboseCount = 0;
			this.m_FilteredLogMessages.Clear();
			base.DataSource.EndEdit(false);
		}

		// Token: 0x060017E8 RID: 6120 RVA: 0x00050C00 File Offset: 0x0004EE00
		public global::Loupe.Extensibility.Data.ILogMessage GetCurrentMessage()
		{
			if (this.m_FilteredLogMessages.Count <= 0)
			{
				return null;
			}
			return this.m_FilteredLogMessages[this.m_FilteredLogMessages.Count - 1];
		}

		// Token: 0x060017E9 RID: 6121 RVA: 0x00050C30 File Offset: 0x0004EE30
		public global::Loupe.Extensibility.Data.ILogMessage GetSelectedMessage()
		{
			int row = base.Selection.ActivePosition.Row;
			if (row > 0 && row <= this.m_FilteredLogMessages.Count)
			{
				return this.m_FilteredLogMessages[row - 1];
			}
			return null;
		}

		// Token: 0x060017EA RID: 6122 RVA: 0x00050C80 File Offset: 0x0004EE80
		public void MoveLast()
		{
			base.ShowCell(new global::SourceGrid.Position(base.Rows.Count, 1), false);
			base.Selection.ResetSelection(false);
		}

		// Token: 0x060017EB RID: 6123 RVA: 0x00050CB8 File Offset: 0x0004EEB8
		public void MoveFirst()
		{
			base.ShowCell(new global::SourceGrid.Position(1, 1), false);
			base.Selection.ResetSelection(false);
		}

		// Token: 0x060017EC RID: 6124 RVA: 0x00050CD8 File Offset: 0x0004EED8
		public void Save(string fileNamePath)
		{
			this.ActionSave(fileNamePath);
		}

		// Token: 0x060017ED RID: 6125 RVA: 0x00050CE4 File Offset: 0x0004EEE4
		public void SelectAll()
		{
			for (int i = 1; i < base.Rows.Count; i++)
			{
				base.Selection.SelectRow(i, true);
			}
		}

		// Token: 0x060017EE RID: 6126 RVA: 0x00050D1C File Offset: 0x0004EF1C
		internal global::SourceGrid.DataGridColumn GetColumnForEnum(global::Gibraltar.Monitor.Windows.LogMessageColumn column)
		{
			foreach (global::SourceGrid.ColumnInfo columnInfo in base.Columns)
			{
				if ((global::Gibraltar.Monitor.Windows.LogMessageColumn)columnInfo.Tag == column)
				{
					return (global::SourceGrid.DataGridColumn)columnInfo;
				}
			}
			return null;
		}

		// Token: 0x060017EF RID: 6127 RVA: 0x00050D8C File Offset: 0x0004EF8C
		private bool MatchesSearchText(string messageText)
		{
			return string.IsNullOrEmpty(this.m_SearchText) || messageText.ToLower().Contains(this.m_SearchText);
		}

		// Token: 0x060017F0 RID: 6128 RVA: 0x00050DB4 File Offset: 0x0004EFB4
		private bool MatchesSeverityFilter(global::Loupe.Extensibility.Data.LogMessageSeverity severity)
		{
			switch (severity)
			{
			case global::Loupe.Extensibility.Data.LogMessageSeverity.Critical:
				return this.ShowCriticalMessages;
			case global::Loupe.Extensibility.Data.LogMessageSeverity.Error:
				return this.ShowErrorMessages;
			case global::Loupe.Extensibility.Data.LogMessageSeverity.Critical | global::Loupe.Extensibility.Data.LogMessageSeverity.Error:
				break;
			case global::Loupe.Extensibility.Data.LogMessageSeverity.Warning:
				return this.ShowWarningMessages;
			default:
				if (severity == global::Loupe.Extensibility.Data.LogMessageSeverity.Information)
				{
					return this.ShowInformationMessages;
				}
				break;
			}
			return this.ShowVerboseMessages;
		}

		// Token: 0x060017F1 RID: 6129 RVA: 0x00050E0C File Offset: 0x0004F00C
		protected override void OnUserInteraction()
		{
			this.DisableAutoScrollMessages();
		}

		// Token: 0x060017F2 RID: 6130 RVA: 0x00050E14 File Offset: 0x0004F014
		private void DisableAutoScrollMessages()
		{
			if (this.AutoScrollMessages)
			{
				this.AutoScrollMessages = false;
				global::System.EventHandler userInteraction = this.UserInteraction;
				if (userInteraction != null)
				{
					userInteraction(this, global::System.EventArgs.Empty);
				}
			}
		}

		// Token: 0x060017F3 RID: 6131 RVA: 0x00050E50 File Offset: 0x0004F050
		protected override void OnKeyPress(global::System.Windows.Forms.KeyPressEventArgs e)
		{
			char keyChar = e.KeyChar;
			if (keyChar != '\u0001')
			{
				if (keyChar != '\u0003')
				{
					return;
				}
				this.CopySelection();
			}
			else if (this.EnableMultiSelection)
			{
				this.SelectAll();
				return;
			}
		}

		// Token: 0x060017F4 RID: 6132 RVA: 0x00050E90 File Offset: 0x0004F090
		private void ActionSave(string fileNamePath)
		{
			if (global::System.IO.File.Exists(fileNamePath))
			{
				global::System.IO.File.Delete(fileNamePath);
			}
			using (global::System.IO.FileStream fileStream = global::System.IO.File.Create(fileNamePath))
			{
				foreach (global::Loupe.Extensibility.Data.ILogMessage logMessage in this.m_LogMessages)
				{
					global::System.DateTimeOffset timestamp = logMessage.Timestamp;
					string s = string.Format("{0:0000}-{1:00}-{2:00} {3:00}-{4:00}-{5:00}: {6} - {7}\r\n", new object[]
					{
						timestamp.Year,
						timestamp.Month,
						timestamp.Day,
						timestamp.Hour,
						timestamp.Minute,
						timestamp.Second,
						logMessage.Severity,
						logMessage.Caption
					});
					byte[] bytes = new global::System.Text.UTF8Encoding(true).GetBytes(s);
					fileStream.Write(bytes, 0, bytes.Length);
				}
			}
		}

		// Token: 0x060017F5 RID: 6133 RVA: 0x00050FBC File Offset: 0x0004F1BC
		private void CopyToClipboard(global::SourceGrid.RangeRegion region)
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			int num = 0;
			for (int i = 0; i < region.Count; i++)
			{
				global::SourceGrid.Range range = region[i];
				int j = range.Start.Row;
				while (j <= range.End.Row)
				{
					int num2 = 0;
					int k = 1;
					while (k <= range.End.Column)
					{
						global::SourceGrid.Cells.ICellVirtual cell = this.GetCell(j, k);
						global::SourceGrid.Position pPosition = new global::SourceGrid.Position(j, k);
						global::SourceGrid.CellContext cellContext = new global::SourceGrid.CellContext(this, pPosition);
						if (cell.Model.ValueModel.GetValue(cellContext) != null)
						{
							string value = cell.Model.ValueModel.GetValue(cellContext).ToString();
							stringBuilder.Append(value);
						}
						if (k != range.End.Column)
						{
							stringBuilder.Append('\t');
						}
						k++;
						num2++;
					}
					stringBuilder.Append("\r\n");
					j++;
					num++;
				}
			}
			global::System.Windows.Forms.Clipboard.SetText(stringBuilder.ToString());
		}

		// Token: 0x060017F6 RID: 6134 RVA: 0x000510F0 File Offset: 0x0004F2F0
		protected override void OnSortingRangeRows(global::SourceGrid.SortRangeRowsEventArgs e)
		{
			if (this.SortByColumn(e.KeyColumn, e.Ascending))
			{
				this.m_Frozen = (e.KeyColumn != 0);
				this.m_SortColumn = e.KeyColumn;
				this.m_SortAscending = e.Ascending;
				this.UpdateGridBackColor();
			}
		}

		// Token: 0x060017F7 RID: 6135 RVA: 0x00051148 File Offset: 0x0004F348
		private bool SortByColumn(int keyColumn, bool ascending)
		{
			if (base.DataSource == null || !base.DataSource.AllowSort)
			{
				return false;
			}
			global::System.ComponentModel.PropertyDescriptor propertyColumn = base.Columns[0].PropertyColumn;
			global::System.ComponentModel.PropertyDescriptor propertyColumn2 = base.Columns[keyColumn].PropertyColumn;
			if (propertyColumn2 != null)
			{
				global::System.ComponentModel.ListSortDirection direction = ascending ? global::System.ComponentModel.ListSortDirection.Ascending : global::System.ComponentModel.ListSortDirection.Descending;
				global::System.ComponentModel.ListSortDescription[] sorts = new global::System.ComponentModel.ListSortDescription[]
				{
					new global::System.ComponentModel.ListSortDescription(propertyColumn2, direction),
					new global::System.ComponentModel.ListSortDescription(propertyColumn, direction)
				};
				base.DataSource.ApplySort(new global::System.ComponentModel.ListSortDescriptionCollection(sorts));
				this.MoveFirst();
				return true;
			}
			return false;
		}

		// Token: 0x060017F8 RID: 6136 RVA: 0x000511EC File Offset: 0x0004F3EC
		public void RemoveSort()
		{
			global::SourceGrid.Cells.Controllers.SortableHeader sortableHeader = base.Columns[0].HeaderCell.Controller.FindController(typeof(global::SourceGrid.Cells.Controllers.SortableHeader)) as global::SourceGrid.Cells.Controllers.SortableHeader;
			if (sortableHeader != null)
			{
				sortableHeader.SortColumn(new global::SourceGrid.CellContext(this, new global::SourceGrid.Position(0, 0)), true, null);
			}
			this.m_SortColumn = 0;
			this.Frozen = false;
			this.UpdateGridBackColor();
		}

		// Token: 0x060017F9 RID: 6137 RVA: 0x00051258 File Offset: 0x0004F458
		internal void UpdateGridBackColor()
		{
		}

		// Token: 0x060017FA RID: 6138 RVA: 0x0005125C File Offset: 0x0004F45C
		private void Prune()
		{
			if (this.MaxMessages <= 0)
			{
				return;
			}
			int num = this.m_LogMessages.Count - this.MaxMessages;
			if (num > 0)
			{
				int i = 0;
				while (i < num)
				{
					global::Loupe.Extensibility.Data.LogMessageSeverity severity = this.m_LogMessages[i].Severity;
					switch (severity)
					{
					case global::Loupe.Extensibility.Data.LogMessageSeverity.Critical:
						this.m_CriticalCount--;
						break;
					case global::Loupe.Extensibility.Data.LogMessageSeverity.Error:
						this.m_ErrorCount--;
						break;
					case global::Loupe.Extensibility.Data.LogMessageSeverity.Critical | global::Loupe.Extensibility.Data.LogMessageSeverity.Error:
						goto IL_B0;
					case global::Loupe.Extensibility.Data.LogMessageSeverity.Warning:
						this.m_WarningCount--;
						break;
					default:
						if (severity != global::Loupe.Extensibility.Data.LogMessageSeverity.Information)
						{
							goto IL_B0;
						}
						this.m_InfoCount--;
						break;
					}
					IL_BE:
					i++;
					continue;
					IL_B0:
					this.m_VerboseCount--;
					goto IL_BE;
				}
				this.m_LogMessages.RemoveRange(0, num);
				if (this.m_LogMessages.Count == 0)
				{
					this.m_FilteredLogMessages.Clear();
					return;
				}
				num = 0;
				long sequence = this.m_LogMessages[0].Sequence;
				int num2 = 0;
				while (num2 < this.m_FilteredLogMessages.Count && this.m_FilteredLogMessages[num2].Sequence < sequence)
				{
					num++;
					num2++;
				}
				if (num > 0)
				{
					this.m_FilteredLogMessages.RemoveRange(0, num);
				}
			}
		}

		// Token: 0x060017FB RID: 6139 RVA: 0x000513C0 File Offset: 0x0004F5C0
		private void OnViewChanged()
		{
			global::System.EventHandler viewChanged = this.ViewChanged;
			if (viewChanged != null)
			{
				viewChanged(this, global::System.EventArgs.Empty);
			}
		}

		// Token: 0x060017FC RID: 6140 RVA: 0x000513EC File Offset: 0x0004F5EC
		private void OnFilterChanged()
		{
			global::System.EventHandler filterChanged = this.FilterChanged;
			if (filterChanged != null)
			{
				filterChanged(this, global::System.EventArgs.Empty);
			}
		}

		// Token: 0x060017FD RID: 6141 RVA: 0x00051418 File Offset: 0x0004F618
		public global::System.Drawing.Image GetImage(global::SourceGrid.CellContext cellContext)
		{
			object value = cellContext.Value;
			if (value == null || value.GetType() != typeof(global::Loupe.Extensibility.Data.LogMessageSeverity))
			{
				return this.m_ImageVerbose;
			}
			global::Loupe.Extensibility.Data.LogMessageSeverity logMessageSeverity = (global::Loupe.Extensibility.Data.LogMessageSeverity)value;
			switch (logMessageSeverity)
			{
			case global::Loupe.Extensibility.Data.LogMessageSeverity.Critical:
				return this.m_ImageCritical;
			case global::Loupe.Extensibility.Data.LogMessageSeverity.Error:
				return this.m_ImageError;
			case global::Loupe.Extensibility.Data.LogMessageSeverity.Critical | global::Loupe.Extensibility.Data.LogMessageSeverity.Error:
				break;
			case global::Loupe.Extensibility.Data.LogMessageSeverity.Warning:
				return this.m_ImageWarning;
			default:
				if (logMessageSeverity == global::Loupe.Extensibility.Data.LogMessageSeverity.Information)
				{
					return this.m_ImageInfo;
				}
				break;
			}
			return this.m_ImageVerbose;
		}

		// Token: 0x04000837 RID: 2103
		private const int MinWidthMessageColumn = 300;

		// Token: 0x04000838 RID: 2104
		private const int MinWidthMethodColumn = 50;

		// Token: 0x04000839 RID: 2105
		private const int MinWidthSourceColumn = 150;

		// Token: 0x0400083A RID: 2106
		private const int MinWidthThreadColumn = 50;

		// Token: 0x0400083B RID: 2107
		private const int MinWidthTimeColumn = 136;

		// Token: 0x0400083C RID: 2108
		private const int MinWidthSeverityColumn = 20;

		// Token: 0x0400083D RID: 2109
		private const int MinWidthUserColumn = 100;

		// Token: 0x0400083E RID: 2110
		private readonly global::System.Drawing.Image m_ImageCritical;

		// Token: 0x0400083F RID: 2111
		private readonly global::System.Drawing.Image m_ImageError;

		// Token: 0x04000840 RID: 2112
		private readonly global::System.Drawing.Image m_ImageInfo;

		// Token: 0x04000841 RID: 2113
		private readonly global::System.Drawing.Image m_ImageVerbose;

		// Token: 0x04000842 RID: 2114
		private readonly global::System.Drawing.Image m_ImageWarning;

		// Token: 0x04000843 RID: 2115
		private readonly global::Gibraltar.Monitor.Windows.Internal.GridViewer.MyToolTipModel m_ToolTipModel = new global::Gibraltar.Monitor.Windows.Internal.GridViewer.MyToolTipModel();

		// Token: 0x04000844 RID: 2116
		private readonly global::SourceGrid.DataGridColumn m_SequenceColumn;

		// Token: 0x04000845 RID: 2117
		private readonly global::SourceGrid.DataGridColumn m_SeverityColumn;

		// Token: 0x04000846 RID: 2118
		private readonly global::SourceGrid.DataGridColumn m_TimeColumn;

		// Token: 0x04000847 RID: 2119
		private readonly global::SourceGrid.DataGridColumn m_UserNameColumn;

		// Token: 0x04000848 RID: 2120
		private readonly global::SourceGrid.DataGridColumn m_MessageColumn;

		// Token: 0x04000849 RID: 2121
		private readonly global::SourceGrid.DataGridColumn m_ThreadNameColumn;

		// Token: 0x0400084A RID: 2122
		private readonly global::SourceGrid.DataGridColumn m_MethodColumn;

		// Token: 0x0400084B RID: 2123
		private readonly global::SourceGrid.DataGridColumn m_SourceCodeLocationColumn;

		// Token: 0x0400084C RID: 2124
		private readonly global::System.Collections.Generic.List<global::Gibraltar.Monitor.Windows.Internal.GridViewer.ViewerLogMessageWrapper> m_FilteredLogMessages;

		// Token: 0x0400084D RID: 2125
		private readonly global::System.Collections.Generic.List<global::Gibraltar.Monitor.Windows.Internal.GridViewer.ViewerLogMessageWrapper> m_LogMessages;

		// Token: 0x0400084E RID: 2126
		private bool m_Frozen;

		// Token: 0x0400084F RID: 2127
		private string m_SearchText;

		// Token: 0x04000850 RID: 2128
		private bool m_SortAscending;

		// Token: 0x04000851 RID: 2129
		private int m_SortColumn;

		// Token: 0x04000852 RID: 2130
		private int m_CriticalCount;

		// Token: 0x04000853 RID: 2131
		private int m_ErrorCount;

		// Token: 0x04000854 RID: 2132
		private int m_WarningCount;

		// Token: 0x04000855 RID: 2133
		private int m_InfoCount;

		// Token: 0x04000856 RID: 2134
		private int m_VerboseCount;

		// Token: 0x04000857 RID: 2135
		private global::Gibraltar.Monitor.Windows.Internal.GridViewer.ViewerLogMessageWrapper m_SelectedLogMessage;

		// Token: 0x020004B0 RID: 1200
		public class BoundImage : global::SourceGrid.Cells.Models.IImage, global::SourceGrid.Cells.Models.IModel
		{
			// Token: 0x060033A8 RID: 13224 RVA: 0x000BAA6C File Offset: 0x000B8C6C
			public BoundImage()
			{
				this.m_MyThreadId = global::System.Threading.Thread.CurrentThread.ManagedThreadId;
				global::Gibraltar.Monitor.Windows.Internal.GridViewer.BoundImage.m_AllBoundImages.Add(this);
			}

			// Token: 0x060033A9 RID: 13225 RVA: 0x000BAA90 File Offset: 0x000B8C90
			public global::System.Drawing.Image GetImage(global::SourceGrid.CellContext cellContext)
			{
				object value = cellContext.Value;
				global::Gibraltar.Monitor.Windows.Internal.GridViewer gridViewer = (global::Gibraltar.Monitor.Windows.Internal.GridViewer)cellContext.Grid;
				if (value == null || value.GetType() != typeof(global::Loupe.Extensibility.Data.LogMessageSeverity))
				{
					return gridViewer.m_ImageVerbose;
				}
				global::Loupe.Extensibility.Data.LogMessageSeverity logMessageSeverity = (global::Loupe.Extensibility.Data.LogMessageSeverity)value;
				switch (logMessageSeverity)
				{
				case global::Loupe.Extensibility.Data.LogMessageSeverity.Critical:
					return gridViewer.m_ImageCritical;
				case global::Loupe.Extensibility.Data.LogMessageSeverity.Error:
					return gridViewer.m_ImageError;
				case global::Loupe.Extensibility.Data.LogMessageSeverity.Critical | global::Loupe.Extensibility.Data.LogMessageSeverity.Error:
					break;
				case global::Loupe.Extensibility.Data.LogMessageSeverity.Warning:
					return gridViewer.m_ImageWarning;
				default:
					if (logMessageSeverity == global::Loupe.Extensibility.Data.LogMessageSeverity.Information)
					{
						return gridViewer.m_ImageInfo;
					}
					break;
				}
				return gridViewer.m_ImageVerbose;
			}

			// Token: 0x040013A0 RID: 5024
			private static readonly global::System.Collections.Generic.List<global::Gibraltar.Monitor.Windows.Internal.GridViewer.BoundImage> m_AllBoundImages = new global::System.Collections.Generic.List<global::Gibraltar.Monitor.Windows.Internal.GridViewer.BoundImage>();

			// Token: 0x040013A1 RID: 5025
			private int m_MyThreadId;
		}

		// Token: 0x020004B1 RID: 1201
		private class LogMessageBoundList : global::DevAge.ComponentModel.BoundList<global::Gibraltar.Monitor.Windows.Internal.GridViewer.ViewerLogMessageWrapper>
		{
			// Token: 0x060033AB RID: 13227 RVA: 0x000BAB30 File Offset: 0x000B8D30
			public LogMessageBoundList(global::System.Collections.Generic.IList<global::Gibraltar.Monitor.Windows.Internal.GridViewer.ViewerLogMessageWrapper> list) : base(list)
			{
			}

			// Token: 0x060033AC RID: 13228 RVA: 0x000BAB3C File Offset: 0x000B8D3C
			protected override global::Gibraltar.Monitor.Windows.Internal.GridViewer.ViewerLogMessageWrapper OnAddNew()
			{
				return null;
			}
		}

		// Token: 0x020004B2 RID: 1202
		private class MyToolTipModel : global::SourceGrid.Cells.Models.IToolTipText, global::SourceGrid.Cells.Models.IModel
		{
			// Token: 0x17000ED3 RID: 3795
			// (get) Token: 0x060033AD RID: 13229 RVA: 0x000BAB40 File Offset: 0x000B8D40
			// (set) Token: 0x060033AE RID: 13230 RVA: 0x000BAB48 File Offset: 0x000B8D48
			public bool ShowDetails { get; set; }

			// Token: 0x060033B0 RID: 13232 RVA: 0x000BAB5C File Offset: 0x000B8D5C
			public string GetToolTipText(global::SourceGrid.CellContext cellContext)
			{
				global::Gibraltar.Monitor.Windows.Internal.GridViewer gridViewer = (global::Gibraltar.Monitor.Windows.Internal.GridViewer)cellContext.Grid;
				if (!this.ShowDetails || (gridViewer.AutoScrollMessages && !gridViewer.Frozen))
				{
					return null;
				}
				new global::SourceGrid.CellContext(gridViewer, new global::SourceGrid.Position(cellContext.Position.Row, 0));
				global::SourceGrid.CellContext cellContext2 = new global::SourceGrid.CellContext(gridViewer, new global::SourceGrid.Position(cellContext.Position.Row, 1));
				global::SourceGrid.CellContext cellContext3 = new global::SourceGrid.CellContext(gridViewer, new global::SourceGrid.Position(cellContext.Position.Row, 2));
				global::SourceGrid.CellContext cellContext4 = new global::SourceGrid.CellContext(gridViewer, new global::SourceGrid.Position(cellContext.Position.Row, 3));
				global::SourceGrid.CellContext cellContext5 = new global::SourceGrid.CellContext(gridViewer, new global::SourceGrid.Position(cellContext.Position.Row, 4));
				global::SourceGrid.CellContext cellContext6 = new global::SourceGrid.CellContext(gridViewer, new global::SourceGrid.Position(cellContext.Position.Row, 5));
				global::SourceGrid.CellContext cellContext7 = new global::SourceGrid.CellContext(gridViewer, new global::SourceGrid.Position(cellContext.Position.Row, 6));
				global::SourceGrid.Cells.Controllers.ToolTipText @default = global::SourceGrid.Cells.Controllers.ToolTipText.Default;
				@default.ToolTipIcon = global::System.Windows.Forms.ToolTipIcon.None;
				gridViewer.ToolTip.ToolTipIcon = global::System.Windows.Forms.ToolTipIcon.None;
				long num = (long)cellContext.Position.Row;
				string toolTipTitle = string.Format("{0} message ({1} of {2}) at {3}", new object[]
				{
					cellContext2.DisplayText,
					num,
					gridViewer.MessageCount,
					cellContext3.DisplayText
				});
				@default.ToolTipTitle = toolTipTitle;
				if (this.ShowDetails)
				{
					return string.Format("{0}\n\nThread:\t{1}\nMethod:\t{2}\nSource:\t{3}", new object[]
					{
						cellContext4.DisplayText,
						cellContext5.DisplayText,
						cellContext6.DisplayText,
						cellContext7.DisplayText
					});
				}
				return cellContext4.DisplayText;
			}
		}

		// Token: 0x020004B3 RID: 1203
		private class SequenceComparer : global::System.Collections.Generic.IComparer<global::Gibraltar.Monitor.Windows.Internal.GridViewer.ViewerLogMessageWrapper>
		{
			// Token: 0x060033B1 RID: 13233 RVA: 0x000BAD10 File Offset: 0x000B8F10
			public int Compare(global::Gibraltar.Monitor.Windows.Internal.GridViewer.ViewerLogMessageWrapper x, global::Gibraltar.Monitor.Windows.Internal.GridViewer.ViewerLogMessageWrapper y)
			{
				if (x == null)
				{
					if (y != null)
					{
						return -1;
					}
					return 0;
				}
				else
				{
					if (y == null)
					{
						return 1;
					}
					return (int)(x.Sequence - y.Sequence);
				}
			}
		}

		// Token: 0x020004B4 RID: 1204
		private class ViewerLogMessageWrapper : global::Loupe.Extensibility.Data.ILogMessage, global::System.IComparable<global::Loupe.Extensibility.Data.ILogMessage>, global::System.IEquatable<global::Loupe.Extensibility.Data.ILogMessage>
		{
			// Token: 0x060033B3 RID: 13235 RVA: 0x000BAD40 File Offset: 0x000B8F40
			public ViewerLogMessageWrapper(global::Loupe.Extensibility.Data.ILogMessage logMessage)
			{
				this.m_LogMessage = logMessage;
			}

			// Token: 0x060033B4 RID: 13236 RVA: 0x000BAD50 File Offset: 0x000B8F50
			public int CompareTo(global::Loupe.Extensibility.Data.ILogMessage other)
			{
				return this.m_LogMessage.CompareTo(other);
			}

			// Token: 0x060033B5 RID: 13237 RVA: 0x000BAD60 File Offset: 0x000B8F60
			public bool Equals(global::Loupe.Extensibility.Data.ILogMessage other)
			{
				return this.m_LogMessage.Equals(other);
			}

			// Token: 0x17000ED4 RID: 3796
			// (get) Token: 0x060033B6 RID: 13238 RVA: 0x000BAD70 File Offset: 0x000B8F70
			public global::Loupe.Extensibility.Data.ISession Session
			{
				get
				{
					return this.m_LogMessage.Session;
				}
			}

			// Token: 0x17000ED5 RID: 3797
			// (get) Token: 0x060033B7 RID: 13239 RVA: 0x000BAD80 File Offset: 0x000B8F80
			public global::System.Guid Id
			{
				get
				{
					return this.m_LogMessage.Id;
				}
			}

			// Token: 0x17000ED6 RID: 3798
			// (get) Token: 0x060033B8 RID: 13240 RVA: 0x000BAD90 File Offset: 0x000B8F90
			public long Sequence
			{
				get
				{
					return this.m_LogMessage.Sequence;
				}
			}

			// Token: 0x17000ED7 RID: 3799
			// (get) Token: 0x060033B9 RID: 13241 RVA: 0x000BADA0 File Offset: 0x000B8FA0
			public global::System.DateTimeOffset Timestamp
			{
				get
				{
					return this.m_LogMessage.Timestamp;
				}
			}

			// Token: 0x17000ED8 RID: 3800
			// (get) Token: 0x060033BA RID: 13242 RVA: 0x000BADB0 File Offset: 0x000B8FB0
			public global::System.DateTimeOffset DisplayTimestamp
			{
				get
				{
					return this.m_LogMessage.DisplayTimestamp;
				}
			}

			// Token: 0x17000ED9 RID: 3801
			// (get) Token: 0x060033BB RID: 13243 RVA: 0x000BADC0 File Offset: 0x000B8FC0
			public global::Loupe.Extensibility.Data.LogMessageSeverity Severity
			{
				get
				{
					return this.m_LogMessage.Severity;
				}
			}

			// Token: 0x17000EDA RID: 3802
			// (get) Token: 0x060033BC RID: 13244 RVA: 0x000BADD0 File Offset: 0x000B8FD0
			public string LogSystem
			{
				get
				{
					return this.m_LogMessage.LogSystem;
				}
			}

			// Token: 0x17000EDB RID: 3803
			// (get) Token: 0x060033BD RID: 13245 RVA: 0x000BADE0 File Offset: 0x000B8FE0
			public string CategoryName
			{
				get
				{
					return this.m_LogMessage.CategoryName;
				}
			}

			// Token: 0x17000EDC RID: 3804
			// (get) Token: 0x060033BE RID: 13246 RVA: 0x000BADF0 File Offset: 0x000B8FF0
			public string UserName
			{
				get
				{
					return this.m_LogMessage.UserName;
				}
			}

			// Token: 0x17000EDD RID: 3805
			// (get) Token: 0x060033BF RID: 13247 RVA: 0x000BAE00 File Offset: 0x000B9000
			public string Caption
			{
				get
				{
					return this.m_LogMessage.Caption;
				}
			}

			// Token: 0x17000EDE RID: 3806
			// (get) Token: 0x060033C0 RID: 13248 RVA: 0x000BAE10 File Offset: 0x000B9010
			public string Description
			{
				get
				{
					return this.m_LogMessage.Description;
				}
			}

			// Token: 0x17000EDF RID: 3807
			// (get) Token: 0x060033C1 RID: 13249 RVA: 0x000BAE20 File Offset: 0x000B9020
			public string Details
			{
				get
				{
					return this.m_LogMessage.Details;
				}
			}

			// Token: 0x17000EE0 RID: 3808
			// (get) Token: 0x060033C2 RID: 13250 RVA: 0x000BAE30 File Offset: 0x000B9030
			public string MethodName
			{
				get
				{
					return this.m_LogMessage.MethodName;
				}
			}

			// Token: 0x17000EE1 RID: 3809
			// (get) Token: 0x060033C3 RID: 13251 RVA: 0x000BAE40 File Offset: 0x000B9040
			public string ClassName
			{
				get
				{
					return this.m_LogMessage.ClassName;
				}
			}

			// Token: 0x17000EE2 RID: 3810
			// (get) Token: 0x060033C4 RID: 13252 RVA: 0x000BAE50 File Offset: 0x000B9050
			public string FileName
			{
				get
				{
					return this.m_LogMessage.FileName;
				}
			}

			// Token: 0x17000EE3 RID: 3811
			// (get) Token: 0x060033C5 RID: 13253 RVA: 0x000BAE60 File Offset: 0x000B9060
			public int LineNumber
			{
				get
				{
					return this.m_LogMessage.LineNumber;
				}
			}

			// Token: 0x17000EE4 RID: 3812
			// (get) Token: 0x060033C6 RID: 13254 RVA: 0x000BAE70 File Offset: 0x000B9070
			public bool HasException
			{
				get
				{
					return this.m_LogMessage.HasException;
				}
			}

			// Token: 0x17000EE5 RID: 3813
			// (get) Token: 0x060033C7 RID: 13255 RVA: 0x000BAE80 File Offset: 0x000B9080
			public global::Loupe.Extensibility.Data.IExceptionInfo Exception
			{
				get
				{
					return this.m_LogMessage.Exception;
				}
			}

			// Token: 0x17000EE6 RID: 3814
			// (get) Token: 0x060033C8 RID: 13256 RVA: 0x000BAE90 File Offset: 0x000B9090
			public int ThreadId
			{
				get
				{
					return this.m_LogMessage.ThreadId;
				}
			}

			// Token: 0x17000EE7 RID: 3815
			// (get) Token: 0x060033C9 RID: 13257 RVA: 0x000BAEA0 File Offset: 0x000B90A0
			public string ThreadName
			{
				get
				{
					return this.m_LogMessage.ThreadName;
				}
			}

			// Token: 0x17000EE8 RID: 3816
			// (get) Token: 0x060033CA RID: 13258 RVA: 0x000BAEB0 File Offset: 0x000B90B0
			public int DomainId
			{
				get
				{
					return this.m_LogMessage.DomainId;
				}
			}

			// Token: 0x17000EE9 RID: 3817
			// (get) Token: 0x060033CB RID: 13259 RVA: 0x000BAEC0 File Offset: 0x000B90C0
			public string DomainName
			{
				get
				{
					return this.m_LogMessage.DomainName;
				}
			}

			// Token: 0x17000EEA RID: 3818
			// (get) Token: 0x060033CC RID: 13260 RVA: 0x000BAED0 File Offset: 0x000B90D0
			public bool IsBackground
			{
				get
				{
					return this.m_LogMessage.IsBackground;
				}
			}

			// Token: 0x17000EEB RID: 3819
			// (get) Token: 0x060033CD RID: 13261 RVA: 0x000BAEE0 File Offset: 0x000B90E0
			public bool IsThreadPoolThread
			{
				get
				{
					return this.m_LogMessage.IsThreadPoolThread;
				}
			}

			// Token: 0x17000EEC RID: 3820
			// (get) Token: 0x060033CE RID: 13262 RVA: 0x000BAEF0 File Offset: 0x000B90F0
			public bool HasThreadInfo
			{
				get
				{
					return this.m_LogMessage.HasThreadInfo;
				}
			}

			// Token: 0x17000EED RID: 3821
			// (get) Token: 0x060033CF RID: 13263 RVA: 0x000BAF00 File Offset: 0x000B9100
			public bool HasMethodInfo
			{
				get
				{
					return this.m_LogMessage.HasMethodInfo;
				}
			}

			// Token: 0x17000EEE RID: 3822
			// (get) Token: 0x060033D0 RID: 13264 RVA: 0x000BAF10 File Offset: 0x000B9110
			public bool HasSourceLocation
			{
				get
				{
					return this.m_LogMessage.HasSourceLocation;
				}
			}

			// Token: 0x17000EEF RID: 3823
			// (get) Token: 0x060033D1 RID: 13265 RVA: 0x000BAF20 File Offset: 0x000B9120
			public global::System.DateTime TimestampDateTime
			{
				get
				{
					return this.Timestamp.DateTime;
				}
			}

			// Token: 0x17000EF0 RID: 3824
			// (get) Token: 0x060033D2 RID: 13266 RVA: 0x000BAF40 File Offset: 0x000B9140
			public string Message
			{
				get
				{
					if (this.m_Message == null)
					{
						bool flag = !string.IsNullOrEmpty(this.m_LogMessage.Caption);
						bool flag2 = !string.IsNullOrEmpty(this.m_LogMessage.Caption);
						if (flag && flag2)
						{
							this.m_Message = global::Gibraltar.StringReference.GetReference(this.m_LogMessage.Caption + "\r\n" + this.m_LogMessage.Description);
						}
						else if (flag)
						{
							this.m_Message = this.m_LogMessage.Caption;
						}
						else if (flag2)
						{
							this.m_Message = this.m_LogMessage.Description;
						}
						else
						{
							this.m_Message = string.Empty;
						}
					}
					return this.m_Message;
				}
			}

			// Token: 0x17000EF1 RID: 3825
			// (get) Token: 0x060033D3 RID: 13267 RVA: 0x000BB008 File Offset: 0x000B9208
			public string MethodFullName
			{
				get
				{
					if (string.IsNullOrEmpty(this.ClassName) || string.IsNullOrEmpty(this.MethodName))
					{
						return string.Empty;
					}
					return global::Gibraltar.StringReference.GetReference(this.ClassName + "." + this.MethodName);
				}
			}

			// Token: 0x17000EF2 RID: 3826
			// (get) Token: 0x060033D4 RID: 13268 RVA: 0x000BB05C File Offset: 0x000B925C
			public string SourceCodeLocation
			{
				get
				{
					if (string.IsNullOrEmpty(this.FileName))
					{
						return string.Empty;
					}
					return global::Gibraltar.StringReference.GetReference(string.Format(global::Gibraltar.FileSystemTools.UICultureFormat, "{0} ({1:N0})", new object[]
					{
						this.FileName,
						this.LineNumber
					}));
				}
			}

			// Token: 0x040013A3 RID: 5027
			private readonly global::Loupe.Extensibility.Data.ILogMessage m_LogMessage;

			// Token: 0x040013A4 RID: 5028
			private string m_Message;
		}
	}
}
