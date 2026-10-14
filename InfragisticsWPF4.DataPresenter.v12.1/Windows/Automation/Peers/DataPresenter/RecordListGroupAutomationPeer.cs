using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Automation.Peers;
using System.Windows.Automation.Provider;
using Infragistics.Windows.DataPresenter;

namespace Infragistics.Windows.Automation.Peers.DataPresenter
{
	// Token: 0x0200002A RID: 42
	public class RecordListGroupAutomationPeer : global::System.Windows.Automation.Peers.AutomationPeer, global::System.Windows.Automation.Provider.ITableProvider, global::System.Windows.Automation.Provider.IGridProvider
	{
		// Token: 0x06000169 RID: 361 RVA: 0x00006938 File Offset: 0x00004B38
		internal RecordListGroupAutomationPeer(global::Infragistics.Windows.Automation.Peers.DataPresenter.RecordListGroup group)
		{
			this._group = group;
		}

		// Token: 0x0600016A RID: 362 RVA: 0x00006947 File Offset: 0x00004B47
		protected override string GetAcceleratorKeyCore()
		{
			return string.Empty;
		}

		// Token: 0x0600016B RID: 363 RVA: 0x0000694E File Offset: 0x00004B4E
		protected override string GetAccessKeyCore()
		{
			return string.Empty;
		}

		// Token: 0x0600016C RID: 364 RVA: 0x00006955 File Offset: 0x00004B55
		protected override global::System.Windows.Automation.Peers.AutomationControlType GetAutomationControlTypeCore()
		{
			if (!this._group.SupportsGridPattern)
			{
				return global::System.Windows.Automation.Peers.AutomationControlType.List;
			}
			return global::System.Windows.Automation.Peers.AutomationControlType.DataGrid;
		}

		// Token: 0x0600016D RID: 365 RVA: 0x00006968 File Offset: 0x00004B68
		protected override string GetAutomationIdCore()
		{
			return string.Empty;
		}

		// Token: 0x0600016E RID: 366 RVA: 0x00006970 File Offset: 0x00004B70
		protected override global::System.Windows.Rect GetBoundingRectangleCore()
		{
			global::System.Windows.Rect? visibleBounds = this._group.GetVisibleBounds(this._group.SupportsGridPattern ? this.HeaderPeer : null);
			if (visibleBounds == null)
			{
				return default(global::System.Windows.Rect);
			}
			return visibleBounds.Value;
		}

		// Token: 0x0600016F RID: 367 RVA: 0x000069BC File Offset: 0x00004BBC
		protected override global::System.Collections.Generic.List<global::System.Windows.Automation.Peers.AutomationPeer> GetChildrenCore()
		{
			global::System.Collections.Generic.List<global::System.Windows.Automation.Peers.AutomationPeer> recordPeers = this._group.GetRecordPeers();
			if (this.CouldSupportGridPattern())
			{
				global::System.Windows.Automation.Peers.AutomationPeer headerPeer = this.HeaderPeer;
				if (headerPeer != null)
				{
					recordPeers.Insert(0, headerPeer);
				}
			}
			return recordPeers;
		}

		// Token: 0x06000170 RID: 368 RVA: 0x000069F0 File Offset: 0x00004BF0
		protected override string GetClassNameCore()
		{
			return "RecordListGroup";
		}

		// Token: 0x06000171 RID: 369 RVA: 0x000069F7 File Offset: 0x00004BF7
		protected override global::System.Windows.Point GetClickablePointCore()
		{
			return new global::System.Windows.Point(double.NaN, double.NaN);
		}

		// Token: 0x06000172 RID: 370 RVA: 0x00006A10 File Offset: 0x00004C10
		protected override string GetHelpTextCore()
		{
			return string.Empty;
		}

		// Token: 0x06000173 RID: 371 RVA: 0x00006A17 File Offset: 0x00004C17
		protected override string GetItemStatusCore()
		{
			return string.Empty;
		}

		// Token: 0x06000174 RID: 372 RVA: 0x00006A1E File Offset: 0x00004C1E
		protected override string GetItemTypeCore()
		{
			return string.Empty;
		}

		// Token: 0x06000175 RID: 373 RVA: 0x00006A25 File Offset: 0x00004C25
		protected override global::System.Windows.Automation.Peers.AutomationPeer GetLabeledByCore()
		{
			return null;
		}

		// Token: 0x06000176 RID: 374 RVA: 0x00006A28 File Offset: 0x00004C28
		protected override string GetNameCore()
		{
			if (this._group != null && this._group.FieldLayout != null && this._group.FieldLayout.Key != null)
			{
				return this._group.FieldLayout.Key.ToString();
			}
			return string.Empty;
		}

		// Token: 0x06000177 RID: 375 RVA: 0x00006A77 File Offset: 0x00004C77
		protected override global::System.Windows.Automation.Peers.AutomationOrientation GetOrientationCore()
		{
			return global::System.Windows.Automation.Peers.AutomationOrientation.None;
		}

		// Token: 0x06000178 RID: 376 RVA: 0x00006A7A File Offset: 0x00004C7A
		public override object GetPattern(global::System.Windows.Automation.Peers.PatternInterface patternInterface)
		{
			if (patternInterface != global::System.Windows.Automation.Peers.PatternInterface.Grid && patternInterface != global::System.Windows.Automation.Peers.PatternInterface.Table)
			{
				return null;
			}
			if (!this.CouldSupportGridPattern())
			{
				return null;
			}
			return this;
		}

		// Token: 0x06000179 RID: 377 RVA: 0x00006A92 File Offset: 0x00004C92
		protected override bool HasKeyboardFocusCore()
		{
			return false;
		}

		// Token: 0x0600017A RID: 378 RVA: 0x00006A95 File Offset: 0x00004C95
		protected override bool IsContentElementCore()
		{
			return true;
		}

		// Token: 0x0600017B RID: 379 RVA: 0x00006A98 File Offset: 0x00004C98
		protected override bool IsControlElementCore()
		{
			return true;
		}

		// Token: 0x0600017C RID: 380 RVA: 0x00006A9B File Offset: 0x00004C9B
		protected override bool IsEnabledCore()
		{
			return true;
		}

		// Token: 0x0600017D RID: 381 RVA: 0x00006A9E File Offset: 0x00004C9E
		protected override bool IsKeyboardFocusableCore()
		{
			return false;
		}

		// Token: 0x0600017E RID: 382 RVA: 0x00006AA4 File Offset: 0x00004CA4
		protected override bool IsOffscreenCore()
		{
			return this.GetBoundingRectangleCore().Equals(default(global::System.Windows.Rect));
		}

		// Token: 0x0600017F RID: 383 RVA: 0x00006AC8 File Offset: 0x00004CC8
		protected override bool IsPasswordCore()
		{
			return false;
		}

		// Token: 0x06000180 RID: 384 RVA: 0x00006ACB File Offset: 0x00004CCB
		protected override bool IsRequiredForFormCore()
		{
			return false;
		}

		// Token: 0x06000181 RID: 385 RVA: 0x00006ACE File Offset: 0x00004CCE
		protected override void SetFocusCore()
		{
		}

		// Token: 0x17000057 RID: 87
		// (get) Token: 0x06000182 RID: 386 RVA: 0x00006AD0 File Offset: 0x00004CD0
		private int FieldCount
		{
			get
			{
				global::Infragistics.Windows.Automation.Peers.DataPresenter.HeaderAutomationPeer headerPeer = this.HeaderPeer;
				if (headerPeer == null)
				{
					return 0;
				}
				return headerPeer.GetHeaderItemCount();
			}
		}

		// Token: 0x17000058 RID: 88
		// (get) Token: 0x06000183 RID: 387 RVA: 0x00006AF0 File Offset: 0x00004CF0
		private global::System.Windows.Automation.Provider.IRawElementProviderSimple[] FieldHeaders
		{
			get
			{
				global::Infragistics.Windows.Automation.Peers.DataPresenter.HeaderAutomationPeer headerPeer = this.HeaderPeer;
				if (headerPeer == null)
				{
					return new global::System.Windows.Automation.Provider.IRawElementProviderSimple[0];
				}
				return headerPeer.GetHeaderItems();
			}
		}

		// Token: 0x17000059 RID: 89
		// (get) Token: 0x06000184 RID: 388 RVA: 0x00006B14 File Offset: 0x00004D14
		internal global::Infragistics.Windows.Automation.Peers.DataPresenter.HeaderAutomationPeer HeaderPeer
		{
			get
			{
				if (this._headerPeer == null && this.CouldSupportGridPattern())
				{
					this._headerPeer = new global::Infragistics.Windows.Automation.Peers.DataPresenter.HeaderAutomationPeer(this._group);
				}
				return this._headerPeer;
			}
		}

		// Token: 0x1700005A RID: 90
		// (get) Token: 0x06000185 RID: 389 RVA: 0x00006B3D File Offset: 0x00004D3D
		internal bool IsHorizontalRowLayout
		{
			get
			{
				return this._group.RecordListAutomationPeer.IsHorizontalRowLayout;
			}
		}

		// Token: 0x1700005B RID: 91
		// (get) Token: 0x06000186 RID: 390 RVA: 0x00006B4F File Offset: 0x00004D4F
		private int RecordCount
		{
			get
			{
				return this._group.RecordCount;
			}
		}

		// Token: 0x06000187 RID: 391 RVA: 0x00006B5C File Offset: 0x00004D5C
		private bool CouldSupportGridPattern()
		{
			return this._group.SupportsGridPattern;
		}

		// Token: 0x06000188 RID: 392 RVA: 0x00006B69 File Offset: 0x00004D69
		internal void Initialize(global::Infragistics.Windows.Automation.Peers.DataPresenter.RecordListGroup newGroup)
		{
			global::Infragistics.CoreUtilities.ValidateNotNull(newGroup);
			this._group = newGroup;
		}

		// Token: 0x06000189 RID: 393 RVA: 0x00006B78 File Offset: 0x00004D78
		global::System.Windows.Automation.Provider.IRawElementProviderSimple[] global::System.Windows.Automation.Provider.ITableProvider.GetColumnHeaders()
		{
			if (!this.IsHorizontalRowLayout)
			{
				return this.FieldHeaders;
			}
			return new global::System.Windows.Automation.Provider.IRawElementProviderSimple[0];
		}

		// Token: 0x0600018A RID: 394 RVA: 0x00006B8F File Offset: 0x00004D8F
		global::System.Windows.Automation.Provider.IRawElementProviderSimple[] global::System.Windows.Automation.Provider.ITableProvider.GetRowHeaders()
		{
			if (!this.IsHorizontalRowLayout)
			{
				return new global::System.Windows.Automation.Provider.IRawElementProviderSimple[0];
			}
			return this.FieldHeaders;
		}

		// Token: 0x1700005C RID: 92
		// (get) Token: 0x0600018B RID: 395 RVA: 0x00006BA6 File Offset: 0x00004DA6
		global::System.Windows.Automation.RowOrColumnMajor global::System.Windows.Automation.Provider.ITableProvider.RowOrColumnMajor
		{
			get
			{
				if (!this.IsHorizontalRowLayout)
				{
					return global::System.Windows.Automation.RowOrColumnMajor.RowMajor;
				}
				return global::System.Windows.Automation.RowOrColumnMajor.ColumnMajor;
			}
		}

		// Token: 0x1700005D RID: 93
		// (get) Token: 0x0600018C RID: 396 RVA: 0x00006BB3 File Offset: 0x00004DB3
		int global::System.Windows.Automation.Provider.IGridProvider.ColumnCount
		{
			get
			{
				if (!this.IsHorizontalRowLayout)
				{
					return this.FieldCount;
				}
				return this.RecordCount;
			}
		}

		// Token: 0x0600018D RID: 397 RVA: 0x00006BCC File Offset: 0x00004DCC
		global::System.Windows.Automation.Provider.IRawElementProviderSimple global::System.Windows.Automation.Provider.IGridProvider.GetItem(int row, int column)
		{
			if (row > ((global::System.Windows.Automation.Provider.IGridProvider)this).RowCount || row < 0)
			{
				throw new global::System.ArgumentOutOfRangeException("row");
			}
			if (column > ((global::System.Windows.Automation.Provider.IGridProvider)this).ColumnCount || column < 0)
			{
				throw new global::System.ArgumentOutOfRangeException("column");
			}
			if (this.IsHorizontalRowLayout)
			{
				int num = column;
				column = row;
				row = num;
			}
			global::Infragistics.Windows.DataPresenter.DataRecord dataRecord = this._group.GetRecord(row) as global::Infragistics.Windows.DataPresenter.DataRecord;
			if (dataRecord != null && !(dataRecord is global::Infragistics.Windows.DataPresenter.HeaderRecord))
			{
				global::Infragistics.Windows.Automation.Peers.DataPresenter.RecordAutomationPeer automationPeer = dataRecord.AutomationPeer;
				if (automationPeer != null)
				{
					global::Infragistics.Windows.DataPresenter.Field fieldAtIndex = this.HeaderPeer.GetFieldAtIndex(column);
					global::Infragistics.Windows.Automation.Peers.DataPresenter.CellAutomationPeer cellPeer = automationPeer.GetCellPeer(dataRecord.Cells[fieldAtIndex]);
					if (cellPeer != null)
					{
						return base.ProviderFromPeer(cellPeer);
					}
				}
			}
			return null;
		}

		// Token: 0x1700005E RID: 94
		// (get) Token: 0x0600018E RID: 398 RVA: 0x00006C6F File Offset: 0x00004E6F
		int global::System.Windows.Automation.Provider.IGridProvider.RowCount
		{
			get
			{
				if (!this.IsHorizontalRowLayout)
				{
					return this.RecordCount;
				}
				return this.FieldCount;
			}
		}

		// Token: 0x0400004C RID: 76
		private global::Infragistics.Windows.Automation.Peers.DataPresenter.RecordListGroup _group;

		// Token: 0x0400004D RID: 77
		private global::Infragistics.Windows.Automation.Peers.DataPresenter.HeaderAutomationPeer _headerPeer;
	}
}
