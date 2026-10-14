using System;
using System.Collections.Generic;
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
		// Token: 0x0600018F RID: 399 RVA: 0x00006C86 File Offset: 0x00004E86
		internal RecordListGroup(global::Infragistics.Windows.Automation.Peers.DataPresenter.IRecordListAutomationPeer recordListAutomationPeer, global::Infragistics.Windows.Automation.Peers.IListAutomationPeer listAutomationPeer, global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout, bool supportsGridPattern)
		{
			this._recordListAutomationPeer = recordListAutomationPeer;
			this._fieldLayout = fieldLayout;
			this._listAutomationPeer = listAutomationPeer;
			this._supportsGridPattern = supportsGridPattern;
		}

		// Token: 0x1700005F RID: 95
		// (get) Token: 0x06000190 RID: 400 RVA: 0x00006CB6 File Offset: 0x00004EB6
		internal global::Infragistics.Windows.Automation.Peers.DataPresenter.RecordListGroupAutomationPeer AutomationPeer
		{
			get
			{
				if (this._peer == null)
				{
					this._peer = new global::Infragistics.Windows.Automation.Peers.DataPresenter.RecordListGroupAutomationPeer(this);
				}
				return this._peer;
			}
		}

		// Token: 0x17000060 RID: 96
		// (get) Token: 0x06000191 RID: 401 RVA: 0x00006CD2 File Offset: 0x00004ED2
		internal global::Infragistics.Windows.DataPresenter.FieldLayout FieldLayout
		{
			get
			{
				return this._fieldLayout;
			}
		}

		// Token: 0x17000061 RID: 97
		// (get) Token: 0x06000192 RID: 402 RVA: 0x00006CDA File Offset: 0x00004EDA
		internal global::Infragistics.Windows.Automation.Peers.IListAutomationPeer ListAutomationPeer
		{
			get
			{
				return this._listAutomationPeer;
			}
		}

		// Token: 0x17000062 RID: 98
		// (get) Token: 0x06000193 RID: 403 RVA: 0x00006CE2 File Offset: 0x00004EE2
		internal global::Infragistics.Windows.Automation.Peers.DataPresenter.IRecordListAutomationPeer RecordListAutomationPeer
		{
			get
			{
				return this._recordListAutomationPeer;
			}
		}

		// Token: 0x17000063 RID: 99
		// (get) Token: 0x06000194 RID: 404 RVA: 0x00006CEA File Offset: 0x00004EEA
		internal int RecordCount
		{
			get
			{
				return this._records.Count;
			}
		}

		// Token: 0x17000064 RID: 100
		// (get) Token: 0x06000195 RID: 405 RVA: 0x00006CF7 File Offset: 0x00004EF7
		internal bool SupportsGridPattern
		{
			get
			{
				return this._supportsGridPattern;
			}
		}

		// Token: 0x06000196 RID: 406 RVA: 0x00006CFF File Offset: 0x00004EFF
		internal void AddRecord(global::Infragistics.Windows.DataPresenter.Record record)
		{
			this._records.Add(record);
		}

		// Token: 0x06000197 RID: 407 RVA: 0x00006D0D File Offset: 0x00004F0D
		internal int CompareTo(int recordIndex)
		{
			if (recordIndex < this._records[0].VisibleIndex)
			{
				return -1;
			}
			if (recordIndex > this._records[this._records.Count - 1].VisibleIndex)
			{
				return 1;
			}
			return 0;
		}

		// Token: 0x06000198 RID: 408 RVA: 0x00006D48 File Offset: 0x00004F48
		internal global::Infragistics.Windows.DataPresenter.Record GetRecord(int index)
		{
			return this._records[index];
		}

		// Token: 0x06000199 RID: 409 RVA: 0x00006D58 File Offset: 0x00004F58
		internal global::System.Collections.Generic.List<global::System.Windows.Automation.Peers.AutomationPeer> GetRecordPeers()
		{
			global::System.Collections.Generic.List<global::System.Windows.Automation.Peers.AutomationPeer> list = new global::System.Collections.Generic.List<global::System.Windows.Automation.Peers.AutomationPeer>(this._records.Count);
			int i = 0;
			int count = this._records.Count;
			while (i < count)
			{
				global::Infragistics.Windows.DataPresenter.Record record = this._records[i];
				global::System.Windows.Automation.Peers.AutomationPeer automationPeer = record.AutomationPeer;
				if (automationPeer == null)
				{
					automationPeer = this.RecordListAutomationPeer.CreateAutomationPeer(record);
				}
				list.Add(automationPeer);
				i++;
			}
			return list;
		}

		// Token: 0x0600019A RID: 410 RVA: 0x00006DC0 File Offset: 0x00004FC0
		internal global::System.Windows.Rect? GetVisibleBounds(global::Infragistics.Windows.Automation.Peers.DataPresenter.HeaderAutomationPeer headerPeer)
		{
			bool recursive = this._fieldLayout.DataPresenter != null && this._fieldLayout.DataPresenter.IsFlatView;
			return global::Infragistics.Windows.Automation.Peers.DataPresenter.RecordListGroup.GetVisibleBounds(this._records, headerPeer, recursive);
		}

		// Token: 0x0600019B RID: 411 RVA: 0x00006DFC File Offset: 0x00004FFC
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

		// Token: 0x0600019C RID: 412 RVA: 0x00006ECC File Offset: 0x000050CC
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

		// Token: 0x0600019D RID: 413 RVA: 0x00006F3C File Offset: 0x0000513C
		internal void InitializeNotifyRecordCount()
		{
			this._lastRecordCountNotification = this._records.Count;
		}

		// Token: 0x0600019E RID: 414 RVA: 0x00006F50 File Offset: 0x00005150
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

		// Token: 0x0600019F RID: 415 RVA: 0x00006FC4 File Offset: 0x000051C4
		internal int IndexOf(global::Infragistics.Windows.DataPresenter.Record record)
		{
			if (record.FieldLayout != this.FieldLayout)
			{
				return -1;
			}
			return this._records.IndexOf(record);
		}

		// Token: 0x060001A0 RID: 416 RVA: 0x00006FE4 File Offset: 0x000051E4
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

		// Token: 0x060001A1 RID: 417 RVA: 0x0000705E File Offset: 0x0000525E
		internal void RemoveAt(int recordIndex)
		{
			this._records.RemoveAt(recordIndex);
		}

		// Token: 0x0400004E RID: 78
		private global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.Record> _records = new global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.Record>();

		// Token: 0x0400004F RID: 79
		private global::Infragistics.Windows.Automation.Peers.DataPresenter.IRecordListAutomationPeer _recordListAutomationPeer;

		// Token: 0x04000050 RID: 80
		private global::Infragistics.Windows.Automation.Peers.IListAutomationPeer _listAutomationPeer;

		// Token: 0x04000051 RID: 81
		private global::Infragistics.Windows.DataPresenter.FieldLayout _fieldLayout;

		// Token: 0x04000052 RID: 82
		private global::Infragistics.Windows.Automation.Peers.DataPresenter.RecordListGroupAutomationPeer _peer;

		// Token: 0x04000053 RID: 83
		private int _lastRecordCountNotification;

		// Token: 0x04000054 RID: 84
		private bool _supportsGridPattern;

		// Token: 0x04000055 RID: 85
		internal static readonly global::System.Windows.Rect EmptyRect = default(global::System.Windows.Rect);
	}
}
