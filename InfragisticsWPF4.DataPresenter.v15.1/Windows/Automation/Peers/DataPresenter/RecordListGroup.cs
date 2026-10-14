using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Automation.Peers;
using Infragistics.AutomationPeers;
using Infragistics.Windows.DataPresenter;

namespace Infragistics.Windows.Automation.Peers.DataPresenter
{
	// Token: 0x0200002B RID: 43
	internal class RecordListGroup
	{
		// Token: 0x060001A1 RID: 417 RVA: 0x00006FE8 File Offset: 0x000051E8
		internal RecordListGroup(global::Infragistics.Windows.Automation.Peers.DataPresenter.IRecordListAutomationPeer recordListAutomationPeer, global::Infragistics.Windows.Automation.Peers.IListAutomationPeer listAutomationPeer, global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout, bool supportsGridPattern)
		{
			this._recordListAutomationPeer = recordListAutomationPeer;
			this._fieldLayout = fieldLayout;
			this._listAutomationPeer = listAutomationPeer;
			this._supportsGridPattern = supportsGridPattern;
			if (recordListAutomationPeer is global::Infragistics.Windows.Automation.Peers.DataPresenter.ViewableRecordCollectionAutomationPeer)
			{
				this._dpPeer = (global::System.Windows.Automation.Peers.UIElementAutomationPeer.CreatePeerForElement(fieldLayout.DataPresenter) as global::Infragistics.Windows.Automation.Peers.DataPresenter.DataPresenterBaseAutomationPeer);
			}
		}

		// Token: 0x17000063 RID: 99
		// (get) Token: 0x060001A2 RID: 418 RVA: 0x00007041 File Offset: 0x00005241
		internal global::Infragistics.Windows.Automation.Peers.DataPresenter.RecordListGroupAutomationPeer AutomationPeer
		{
			get
			{
				if (this._peer == null)
				{
					this._peer = new global::Infragistics.Windows.Automation.Peers.DataPresenter.RecordListGroupAutomationPeer(this);
					if (this._dpPeer != null)
					{
						this._dpPeer.AddProxyPeerHost(this._peer);
					}
				}
				return this._peer;
			}
		}

		// Token: 0x17000064 RID: 100
		// (get) Token: 0x060001A3 RID: 419 RVA: 0x00007076 File Offset: 0x00005276
		internal global::Infragistics.Windows.DataPresenter.FieldLayout FieldLayout
		{
			get
			{
				return this._fieldLayout;
			}
		}

		// Token: 0x17000065 RID: 101
		// (get) Token: 0x060001A4 RID: 420 RVA: 0x0000707E File Offset: 0x0000527E
		internal global::Infragistics.Windows.Automation.Peers.IListAutomationPeer ListAutomationPeer
		{
			get
			{
				return this._listAutomationPeer;
			}
		}

		// Token: 0x17000066 RID: 102
		// (get) Token: 0x060001A5 RID: 421 RVA: 0x00007086 File Offset: 0x00005286
		internal global::Infragistics.Windows.Automation.Peers.DataPresenter.IRecordListAutomationPeer RecordListAutomationPeer
		{
			get
			{
				return this._recordListAutomationPeer;
			}
		}

		// Token: 0x17000067 RID: 103
		// (get) Token: 0x060001A6 RID: 422 RVA: 0x0000708E File Offset: 0x0000528E
		internal int RecordCount
		{
			get
			{
				return this._records.Count;
			}
		}

		// Token: 0x17000068 RID: 104
		// (get) Token: 0x060001A7 RID: 423 RVA: 0x0000709B File Offset: 0x0000529B
		internal bool ShouldVirtualizeRecords
		{
			get
			{
				return this._dpPeer != null && global::Infragistics.Windows.Automation.Peers.DataPresenter.DataPresenterBaseAutomationPeer.ShouldVirtualizeRecordPeers;
			}
		}

		// Token: 0x17000069 RID: 105
		// (get) Token: 0x060001A8 RID: 424 RVA: 0x000070AC File Offset: 0x000052AC
		internal bool SupportsGridPattern
		{
			get
			{
				return this._supportsGridPattern;
			}
		}

		// Token: 0x060001A9 RID: 425 RVA: 0x000070B4 File Offset: 0x000052B4
		internal void AddRecord(global::Infragistics.Windows.DataPresenter.Record record)
		{
			this._records.Add(record);
		}

		// Token: 0x060001AA RID: 426 RVA: 0x000070C4 File Offset: 0x000052C4
		internal int CompareTo(int recordIndex)
		{
			int count = this._records.Count;
			if (count == 0)
			{
				return -1;
			}
			if (recordIndex < this._records[0].VisibleIndex)
			{
				return -1;
			}
			if (recordIndex > this._records[count - 1].VisibleIndex)
			{
				return 1;
			}
			return 0;
		}

		// Token: 0x060001AB RID: 427 RVA: 0x00007111 File Offset: 0x00005311
		internal global::Infragistics.Windows.DataPresenter.Record GetRecord(int index)
		{
			return this._records[index];
		}

		// Token: 0x060001AC RID: 428 RVA: 0x00007120 File Offset: 0x00005320
		internal global::System.Collections.Generic.List<global::System.Windows.Automation.Peers.AutomationPeer> GetRecordPeers(bool forceGetAll = false)
		{
			global::System.Collections.Generic.List<global::System.Windows.Automation.Peers.AutomationPeer> list = new global::System.Collections.Generic.List<global::System.Windows.Automation.Peers.AutomationPeer>(this._records.Count);
			global::System.Collections.Generic.ICollection<global::Infragistics.Windows.DataPresenter.Record> collection = null;
			if (!forceGetAll && this.ShouldVirtualizeRecords)
			{
				global::Infragistics.Windows.DataPresenter.ViewableRecordCollection viewableRecords = ((global::Infragistics.Windows.Automation.Peers.DataPresenter.ViewableRecordCollectionAutomationPeer)this._recordListAutomationPeer).ViewableRecords;
				if (viewableRecords != null)
				{
					collection = this._dpPeer.GetRecordsInView(viewableRecords).ToArray<global::Infragistics.Windows.DataPresenter.Record>();
				}
			}
			global::Infragistics.Windows.Automation.Peers.DataPresenter.RecordListGroupAutomationPeer automationPeer = this.AutomationPeer;
			int i = 0;
			int count = this._records.Count;
			while (i < count)
			{
				global::Infragistics.Windows.DataPresenter.Record record = this._records[i];
				if (collection == null || collection.Contains(record))
				{
					global::Infragistics.Windows.Automation.Peers.DataPresenter.RecordAutomationPeer orCreateRecordAutomationPeer = global::Infragistics.Windows.Automation.Peers.DataPresenter.ListAutomationPeerHelper.GetOrCreateRecordAutomationPeer(record, this._recordListAutomationPeer, this._listAutomationPeer, automationPeer);
					list.Add(orCreateRecordAutomationPeer);
				}
				i++;
			}
			return list;
		}

		// Token: 0x060001AD RID: 429 RVA: 0x000071D4 File Offset: 0x000053D4
		internal global::System.Windows.Rect? GetVisibleBounds(global::Infragistics.Windows.Automation.Peers.DataPresenter.HeaderAutomationPeer headerPeer)
		{
			bool recursive = this._fieldLayout.DataPresenter != null && this._fieldLayout.DataPresenter.IsFlatView;
			return global::Infragistics.Windows.Automation.Peers.DataPresenter.RecordListGroup.GetVisibleBounds(this._records, headerPeer, recursive);
		}

		// Token: 0x060001AE RID: 430 RVA: 0x00007210 File Offset: 0x00005410
		internal static global::System.Windows.Rect? GetVisibleBounds(global::System.Collections.Generic.IList<global::Infragistics.Windows.DataPresenter.Record> records, global::Infragistics.Windows.Automation.Peers.DataPresenter.HeaderAutomationPeer headerPeer, bool recursive)
		{
			global::System.Windows.Rect? result = null;
			int i = 0;
			while (i < records.Count)
			{
				global::System.Windows.Automation.Peers.AutomationPeer automationPeer = records[i].AutomationPeer;
				global::System.Windows.Rect boundingRectangle;
				if (automationPeer != null)
				{
					boundingRectangle = automationPeer.GetBoundingRectangle();
					goto IL_44;
				}
				global::Infragistics.Windows.DataPresenter.RecordPresenter associatedRecordPresenter = records[i].AssociatedRecordPresenter;
				if (associatedRecordPresenter != null)
				{
					boundingRectangle = global::System.Windows.Automation.Peers.UIElementAutomationPeer.CreatePeerForElement(associatedRecordPresenter).GetBoundingRectangle();
					goto IL_44;
				}
				IL_79:
				i++;
				continue;
				IL_44:
				if (boundingRectangle.Equals(global::Infragistics.Windows.Automation.Peers.DataPresenter.RecordListGroup.EmptyRect))
				{
					goto IL_79;
				}
				if (result == null)
				{
					result = new global::System.Windows.Rect?(boundingRectangle);
					goto IL_79;
				}
				result = new global::System.Windows.Rect?(global::System.Windows.Rect.Union(result.Value, boundingRectangle));
				goto IL_79;
			}
			if (headerPeer != null)
			{
				global::System.Windows.Rect boundingRectangle2 = headerPeer.GetBoundingRectangle();
				if (!boundingRectangle2.Equals(global::Infragistics.Windows.Automation.Peers.DataPresenter.RecordListGroup.EmptyRect))
				{
					result = new global::System.Windows.Rect?((result == null) ? boundingRectangle2 : global::System.Windows.Rect.Union(result.Value, boundingRectangle2));
				}
			}
			return result;
		}

		// Token: 0x060001AF RID: 431 RVA: 0x000072DF File Offset: 0x000054DF
		internal int IndexOfRecord(global::Infragistics.Windows.DataPresenter.Record record)
		{
			return this._records.IndexOf(record);
		}

		// Token: 0x060001B0 RID: 432 RVA: 0x000072F0 File Offset: 0x000054F0
		internal void InitializeFrom(global::Infragistics.Windows.Automation.Peers.DataPresenter.RecordListGroup oldGroup)
		{
			if (this._peer == null && oldGroup != null)
			{
				this._peer = oldGroup._peer;
				if (this._peer != null)
				{
					this._peer.Initialize(this);
				}
			}
			this._lastRecordCountNotification = oldGroup._lastRecordCountNotification;
			if (this.RecordCount != oldGroup.RecordCount && this._peer != null)
			{
				global::Infragistics.AutomationPeers.AutomationPeerHelper.InvalidateChildren(this._peer);
				this._peer.InvalidatePeer();
			}
		}

		// Token: 0x060001B1 RID: 433 RVA: 0x00007360 File Offset: 0x00005560
		internal void InitializeNotifyRecordCount()
		{
			this._lastRecordCountNotification = this._records.Count;
		}

		// Token: 0x060001B2 RID: 434 RVA: 0x00007374 File Offset: 0x00005574
		internal bool IsSameGroup(global::Infragistics.Windows.Automation.Peers.DataPresenter.RecordListGroup group)
		{
			if (group._fieldLayout == this._fieldLayout)
			{
				foreach (global::Infragistics.Windows.DataPresenter.Record item in this._records)
				{
					if (!group._records.Contains(item))
					{
						return false;
					}
				}
				return true;
			}
			return false;
		}

		// Token: 0x060001B3 RID: 435 RVA: 0x000073E8 File Offset: 0x000055E8
		internal int IndexOf(global::Infragistics.Windows.DataPresenter.Record record)
		{
			if (record.FieldLayout != this.FieldLayout)
			{
				return -1;
			}
			return this._records.IndexOf(record);
		}

		// Token: 0x060001B4 RID: 436 RVA: 0x00007408 File Offset: 0x00005608
		internal void RaiseRecordCountChange()
		{
			if (this._lastRecordCountNotification != this._records.Count)
			{
				if (this._peer != null)
				{
					global::System.Windows.Automation.AutomationProperty property = this._recordListAutomationPeer.IsHorizontalRowLayout ? global::System.Windows.Automation.GridPatternIdentifiers.ColumnCountProperty : global::System.Windows.Automation.GridPatternIdentifiers.RowCountProperty;
					this._peer.RaisePropertyChangedEvent(property, this._lastRecordCountNotification, this._records.Count);
				}
				this._lastRecordCountNotification = this._records.Count;
			}
		}

		// Token: 0x060001B5 RID: 437 RVA: 0x00007482 File Offset: 0x00005682
		internal void RemoveAt(int recordIndex)
		{
			this._records.RemoveAt(recordIndex);
		}

		// Token: 0x0400005D RID: 93
		private global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.Record> _records = new global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.Record>();

		// Token: 0x0400005E RID: 94
		private global::Infragistics.Windows.Automation.Peers.DataPresenter.IRecordListAutomationPeer _recordListAutomationPeer;

		// Token: 0x0400005F RID: 95
		private global::Infragistics.Windows.Automation.Peers.IListAutomationPeer _listAutomationPeer;

		// Token: 0x04000060 RID: 96
		private global::Infragistics.Windows.DataPresenter.FieldLayout _fieldLayout;

		// Token: 0x04000061 RID: 97
		private global::Infragistics.Windows.Automation.Peers.DataPresenter.RecordListGroupAutomationPeer _peer;

		// Token: 0x04000062 RID: 98
		private int _lastRecordCountNotification;

		// Token: 0x04000063 RID: 99
		private bool _supportsGridPattern;

		// Token: 0x04000064 RID: 100
		internal static readonly global::System.Windows.Rect EmptyRect = default(global::System.Windows.Rect);

		// Token: 0x04000065 RID: 101
		private global::Infragistics.Windows.Automation.Peers.DataPresenter.DataPresenterBaseAutomationPeer _dpPeer;
	}
}
