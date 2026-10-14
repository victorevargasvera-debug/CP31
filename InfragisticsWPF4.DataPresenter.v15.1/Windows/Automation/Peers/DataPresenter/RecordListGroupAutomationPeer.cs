using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Automation.Peers;
using System.Windows.Automation.Provider;
using Infragistics.AutomationPeers;
using Infragistics.Windows.DataPresenter;

namespace Infragistics.Windows.Automation.Peers.DataPresenter
{
	// Token: 0x0200002A RID: 42
	public class RecordListGroupAutomationPeer : global::System.Windows.Automation.Peers.AutomationPeer, global::System.Windows.Automation.Provider.ITableProvider, global::System.Windows.Automation.Provider.IGridProvider, global::System.Windows.Automation.Provider.IItemContainerProvider
	{
		// Token: 0x06000179 RID: 377 RVA: 0x00006AF0 File Offset: 0x00004CF0
		internal RecordListGroupAutomationPeer(global::Infragistics.Windows.Automation.Peers.DataPresenter.RecordListGroup group)
		{
			this._group = group;
		}

		// Token: 0x0600017A RID: 378 RVA: 0x00006AFF File Offset: 0x00004CFF
		protected override string GetAcceleratorKeyCore()
		{
			return string.Empty;
		}

		// Token: 0x0600017B RID: 379 RVA: 0x00006B06 File Offset: 0x00004D06
		protected override string GetAccessKeyCore()
		{
			return string.Empty;
		}

		// Token: 0x0600017C RID: 380 RVA: 0x00006B0D File Offset: 0x00004D0D
		protected override global::System.Windows.Automation.Peers.AutomationControlType GetAutomationControlTypeCore()
		{
			if (!this._group.SupportsGridPattern)
			{
				return global::System.Windows.Automation.Peers.AutomationControlType.List;
			}
			return global::System.Windows.Automation.Peers.AutomationControlType.DataGrid;
		}

		// Token: 0x0600017D RID: 381 RVA: 0x00006B20 File Offset: 0x00004D20
		protected override string GetAutomationIdCore()
		{
			return string.Empty;
		}

		// Token: 0x0600017E RID: 382 RVA: 0x00006B28 File Offset: 0x00004D28
		protected override global::System.Windows.Rect GetBoundingRectangleCore()
		{
			global::System.Windows.Rect? visibleBounds = this._group.GetVisibleBounds(this._group.SupportsGridPattern ? this.HeaderPeer : null);
			if (visibleBounds == null)
			{
				return default(global::System.Windows.Rect);
			}
			return visibleBounds.Value;
		}

		// Token: 0x0600017F RID: 383 RVA: 0x00006B71 File Offset: 0x00004D71
		protected override global::System.Collections.Generic.List<global::System.Windows.Automation.Peers.AutomationPeer> GetChildrenCore()
		{
			return this.GetChildrenHelper(false);
		}

		// Token: 0x06000180 RID: 384 RVA: 0x00006B7A File Offset: 0x00004D7A
		protected override string GetClassNameCore()
		{
			return "RecordListGroup";
		}

		// Token: 0x06000181 RID: 385 RVA: 0x00006B81 File Offset: 0x00004D81
		protected override global::System.Windows.Point GetClickablePointCore()
		{
			return new global::System.Windows.Point(double.NaN, double.NaN);
		}

		// Token: 0x06000182 RID: 386 RVA: 0x00006B9A File Offset: 0x00004D9A
		protected override string GetHelpTextCore()
		{
			return string.Empty;
		}

		// Token: 0x06000183 RID: 387 RVA: 0x00006BA1 File Offset: 0x00004DA1
		protected override string GetItemStatusCore()
		{
			return string.Empty;
		}

		// Token: 0x06000184 RID: 388 RVA: 0x00006BA8 File Offset: 0x00004DA8
		protected override string GetItemTypeCore()
		{
			return string.Empty;
		}

		// Token: 0x06000185 RID: 389 RVA: 0x00006BAF File Offset: 0x00004DAF
		protected override global::System.Windows.Automation.Peers.AutomationPeer GetLabeledByCore()
		{
			return null;
		}

		// Token: 0x06000186 RID: 390 RVA: 0x00006BB4 File Offset: 0x00004DB4
		protected override string GetNameCore()
		{
			if (this._group != null && this._group.FieldLayout != null && this._group.FieldLayout.Key != null)
			{
				return this._group.FieldLayout.Key.ToString();
			}
			return string.Empty;
		}

		// Token: 0x06000187 RID: 391 RVA: 0x00006C03 File Offset: 0x00004E03
		protected override global::System.Windows.Automation.Peers.AutomationOrientation GetOrientationCore()
		{
			return global::System.Windows.Automation.Peers.AutomationOrientation.None;
		}

		// Token: 0x06000188 RID: 392 RVA: 0x00006C06 File Offset: 0x00004E06
		public override object GetPattern(global::System.Windows.Automation.Peers.PatternInterface patternInterface)
		{
			if (patternInterface == global::System.Windows.Automation.Peers.PatternInterface.Grid || patternInterface == global::System.Windows.Automation.Peers.PatternInterface.Table)
			{
				if (!this.CouldSupportGridPattern())
				{
					return null;
				}
				return this;
			}
			else
			{
				if (patternInterface == global::System.Windows.Automation.Peers.PatternInterface.ItemContainer)
				{
					return this;
				}
				return null;
			}
		}

		// Token: 0x06000189 RID: 393 RVA: 0x00006C25 File Offset: 0x00004E25
		protected override bool HasKeyboardFocusCore()
		{
			return false;
		}

		// Token: 0x0600018A RID: 394 RVA: 0x00006C28 File Offset: 0x00004E28
		protected override bool IsContentElementCore()
		{
			return true;
		}

		// Token: 0x0600018B RID: 395 RVA: 0x00006C2B File Offset: 0x00004E2B
		protected override bool IsControlElementCore()
		{
			return true;
		}

		// Token: 0x0600018C RID: 396 RVA: 0x00006C2E File Offset: 0x00004E2E
		protected override bool IsEnabledCore()
		{
			return true;
		}

		// Token: 0x0600018D RID: 397 RVA: 0x00006C31 File Offset: 0x00004E31
		protected override bool IsKeyboardFocusableCore()
		{
			return false;
		}

		// Token: 0x0600018E RID: 398 RVA: 0x00006C34 File Offset: 0x00004E34
		protected override bool IsOffscreenCore()
		{
			return this.GetBoundingRectangleCore().Equals(default(global::System.Windows.Rect));
		}

		// Token: 0x0600018F RID: 399 RVA: 0x00006C58 File Offset: 0x00004E58
		protected override bool IsPasswordCore()
		{
			return false;
		}

		// Token: 0x06000190 RID: 400 RVA: 0x00006C5B File Offset: 0x00004E5B
		protected override bool IsRequiredForFormCore()
		{
			return false;
		}

		// Token: 0x06000191 RID: 401 RVA: 0x00006C5E File Offset: 0x00004E5E
		protected override void SetFocusCore()
		{
		}

		// Token: 0x1700005B RID: 91
		// (get) Token: 0x06000192 RID: 402 RVA: 0x00006C60 File Offset: 0x00004E60
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

		// Token: 0x1700005C RID: 92
		// (get) Token: 0x06000193 RID: 403 RVA: 0x00006C80 File Offset: 0x00004E80
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

		// Token: 0x1700005D RID: 93
		// (get) Token: 0x06000194 RID: 404 RVA: 0x00006CA4 File Offset: 0x00004EA4
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

		// Token: 0x1700005E RID: 94
		// (get) Token: 0x06000195 RID: 405 RVA: 0x00006CCD File Offset: 0x00004ECD
		internal bool IsHorizontalRowLayout
		{
			get
			{
				return this._group.RecordListAutomationPeer.IsHorizontalRowLayout;
			}
		}

		// Token: 0x1700005F RID: 95
		// (get) Token: 0x06000196 RID: 406 RVA: 0x00006CDF File Offset: 0x00004EDF
		private int RecordCount
		{
			get
			{
				return this._group.RecordCount;
			}
		}

		// Token: 0x06000197 RID: 407 RVA: 0x00006CEC File Offset: 0x00004EEC
		private bool CouldSupportGridPattern()
		{
			return this._group.SupportsGridPattern;
		}

		// Token: 0x06000198 RID: 408 RVA: 0x00006CFC File Offset: 0x00004EFC
		private global::System.Collections.Generic.List<global::System.Windows.Automation.Peers.AutomationPeer> GetChildrenHelper(bool forceGetAll = false)
		{
			global::System.Collections.Generic.List<global::System.Windows.Automation.Peers.AutomationPeer> recordPeers = this._group.GetRecordPeers(forceGetAll);
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

		// Token: 0x06000199 RID: 409 RVA: 0x00006D31 File Offset: 0x00004F31
		internal void Initialize(global::Infragistics.Windows.Automation.Peers.DataPresenter.RecordListGroup newGroup)
		{
			global::Infragistics.CoreUtilities.ValidateNotNull(newGroup);
			this._group = newGroup;
		}

		// Token: 0x0600019A RID: 410 RVA: 0x00006D40 File Offset: 0x00004F40
		global::System.Windows.Automation.Provider.IRawElementProviderSimple[] global::System.Windows.Automation.Provider.ITableProvider.GetColumnHeaders()
		{
			if (!this.IsHorizontalRowLayout)
			{
				return this.FieldHeaders;
			}
			return new global::System.Windows.Automation.Provider.IRawElementProviderSimple[0];
		}

		// Token: 0x0600019B RID: 411 RVA: 0x00006D57 File Offset: 0x00004F57
		global::System.Windows.Automation.Provider.IRawElementProviderSimple[] global::System.Windows.Automation.Provider.ITableProvider.GetRowHeaders()
		{
			if (!this.IsHorizontalRowLayout)
			{
				return new global::System.Windows.Automation.Provider.IRawElementProviderSimple[0];
			}
			return this.FieldHeaders;
		}

		// Token: 0x17000060 RID: 96
		// (get) Token: 0x0600019C RID: 412 RVA: 0x00006D6E File Offset: 0x00004F6E
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

		// Token: 0x17000061 RID: 97
		// (get) Token: 0x0600019D RID: 413 RVA: 0x00006D7B File Offset: 0x00004F7B
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

		// Token: 0x0600019E RID: 414 RVA: 0x00006D94 File Offset: 0x00004F94
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

		// Token: 0x17000062 RID: 98
		// (get) Token: 0x0600019F RID: 415 RVA: 0x00006E37 File Offset: 0x00005037
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

		// Token: 0x060001A0 RID: 416 RVA: 0x00006E50 File Offset: 0x00005050
		global::System.Windows.Automation.Provider.IRawElementProviderSimple global::System.Windows.Automation.Provider.IItemContainerProvider.FindItemByProperty(global::System.Windows.Automation.Provider.IRawElementProviderSimple startAfter, int propertyId, object value)
		{
			if (propertyId != 0 && propertyId != global::System.Windows.Automation.AutomationElementIdentifiers.NameProperty.Id && propertyId != global::System.Windows.Automation.AutomationElementIdentifiers.AutomationIdProperty.Id && propertyId != global::System.Windows.Automation.AutomationElementIdentifiers.ControlTypeProperty.Id)
			{
				throw new global::System.ArgumentException("PropertyNotSupported");
			}
			global::System.Collections.Generic.List<global::System.Windows.Automation.Peers.AutomationPeer> list = this._group.ShouldVirtualizeRecords ? this.GetChildrenHelper(true) : base.GetChildren();
			if (list.Count == 0)
			{
				return null;
			}
			global::Infragistics.Windows.Automation.Peers.DataPresenter.RecordAutomationPeer recordAutomationPeer = null;
			global::Infragistics.Windows.Automation.Peers.DataPresenter.HeaderAutomationPeer headerAutomationPeer = null;
			if (startAfter != null)
			{
				recordAutomationPeer = (base.PeerFromProvider(startAfter) as global::Infragistics.Windows.Automation.Peers.DataPresenter.RecordAutomationPeer);
				if (recordAutomationPeer == null)
				{
					headerAutomationPeer = (base.PeerFromProvider(startAfter) as global::Infragistics.Windows.Automation.Peers.DataPresenter.HeaderAutomationPeer);
				}
			}
			int i = 0;
			global::System.Windows.Automation.Peers.AutomationPeer automationPeer = list[0];
			if (recordAutomationPeer != null || headerAutomationPeer != null)
			{
				global::Infragistics.Windows.DataPresenter.Record record = (recordAutomationPeer != null) ? recordAutomationPeer.Record : null;
				global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout = (headerAutomationPeer != null) ? headerAutomationPeer.FieldLayout : null;
				int count = list.Count;
				int num = (recordAutomationPeer != null) ? (i + this._group.IndexOfRecord(record)) : 0;
				i = -1;
				if (num >= 0)
				{
					int j = num;
					int num2 = global::System.Math.Min(count, num + 2);
					while (j < num2)
					{
						if (recordAutomationPeer != null)
						{
							global::Infragistics.Windows.Automation.Peers.DataPresenter.RecordAutomationPeer recordAutomationPeer2 = list[j] as global::Infragistics.Windows.Automation.Peers.DataPresenter.RecordAutomationPeer;
							if (recordAutomationPeer2 != null && recordAutomationPeer2.Record == record)
							{
								i = j + 1;
								break;
							}
						}
						else
						{
							global::Infragistics.Windows.Automation.Peers.DataPresenter.HeaderAutomationPeer headerAutomationPeer2 = list[j] as global::Infragistics.Windows.Automation.Peers.DataPresenter.HeaderAutomationPeer;
							if (headerAutomationPeer2 != null && headerAutomationPeer2.FieldLayout == fieldLayout)
							{
								i = j + 1;
								break;
							}
						}
						j++;
					}
				}
			}
			if (propertyId != 0)
			{
				while (i < list.Count)
				{
					object automationPropertyValue = global::Infragistics.AutomationPeers.AutomationPeerHelper.GetAutomationPropertyValue(propertyId, list[i]);
					if (object.Equals(value, automationPropertyValue))
					{
						break;
					}
					i++;
				}
			}
			if (i < 0 || i >= list.Count)
			{
				return null;
			}
			return base.ProviderFromPeer(list[i]);
		}

		// Token: 0x0400005B RID: 91
		private global::Infragistics.Windows.Automation.Peers.DataPresenter.RecordListGroup _group;

		// Token: 0x0400005C RID: 92
		private global::Infragistics.Windows.Automation.Peers.DataPresenter.HeaderAutomationPeer _headerPeer;
	}
}
