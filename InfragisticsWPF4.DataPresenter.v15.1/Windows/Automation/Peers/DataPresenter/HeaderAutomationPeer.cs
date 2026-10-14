using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Automation.Peers;
using System.Windows.Automation.Provider;
using System.Windows.Controls;
using Infragistics.AutomationPeers;
using Infragistics.Windows.DataPresenter;

namespace Infragistics.Windows.Automation.Peers.DataPresenter
{
	// Token: 0x0200001D RID: 29
	public class HeaderAutomationPeer : global::Infragistics.AutomationPeers.AutomationPeerProxy, global::System.Windows.IWeakEventListener
	{
		// Token: 0x060000C8 RID: 200 RVA: 0x000040F4 File Offset: 0x000022F4
		public HeaderAutomationPeer(global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout, global::Infragistics.Windows.Automation.Peers.DataPresenter.IRecordListAutomationPeer recordListAutomationPeer, global::Infragistics.Windows.Automation.Peers.IListAutomationPeer listAutomationPeer)
		{
			if (fieldLayout == null)
			{
				throw new global::System.ArgumentNullException("fieldLayout");
			}
			this._fieldLayout = fieldLayout;
			this._recordListAutomationPeer = recordListAutomationPeer;
			this._listAutomationPeer = listAutomationPeer;
			global::System.Collections.Specialized.CollectionChangedEventManager.AddListener(this._fieldLayout.Fields, this);
		}

		// Token: 0x060000C9 RID: 201 RVA: 0x00004142 File Offset: 0x00002342
		internal HeaderAutomationPeer(global::Infragistics.Windows.Automation.Peers.DataPresenter.RecordListGroup group) : this(group.FieldLayout, group.RecordListAutomationPeer, group.ListAutomationPeer)
		{
			if (group == null)
			{
				throw new global::System.ArgumentNullException("group");
			}
			this._group = group;
		}

		// Token: 0x060000CA RID: 202 RVA: 0x00004174 File Offset: 0x00002374
		protected override global::System.Windows.Automation.Peers.AutomationPeer GetUnderlyingPeer()
		{
			global::Infragistics.Windows.DataPresenter.HeaderPresenter headerElement = this.GetHeaderElement();
			global::System.Windows.Automation.Peers.AutomationPeer automationPeer = (headerElement != null) ? global::System.Windows.Automation.Peers.UIElementAutomationPeer.CreatePeerForElement(headerElement) : null;
			if (automationPeer != null)
			{
				automationPeer.EventsSource = this;
			}
			return automationPeer;
		}

		// Token: 0x060000CB RID: 203 RVA: 0x000041A0 File Offset: 0x000023A0
		protected override global::System.Windows.Automation.Peers.AutomationControlType GetAutomationControlTypeCore()
		{
			return global::System.Windows.Automation.Peers.AutomationControlType.Header;
		}

		// Token: 0x060000CC RID: 204 RVA: 0x000041F4 File Offset: 0x000023F4
		protected override global::System.Collections.Generic.List<global::System.Windows.Automation.Peers.AutomationPeer> GetChildrenCore()
		{
			global::System.Collections.Generic.List<global::System.Windows.Automation.Peers.AutomationPeer> list = base.GetChildrenCore();
			if (list != null)
			{
				list.RemoveAll((global::System.Windows.Automation.Peers.AutomationPeer peer) => peer is global::System.Windows.Automation.Peers.FrameworkElementAutomationPeer && ((global::System.Windows.Automation.Peers.FrameworkElementAutomationPeer)peer).Owner is global::Infragistics.Windows.DataPresenter.LabelPresenter);
			}
			else
			{
				list = new global::System.Collections.Generic.List<global::System.Windows.Automation.Peers.AutomationPeer>();
			}
			this.VerifyLabelPeers();
			global::System.Collections.Generic.Dictionary<global::Infragistics.Windows.DataPresenter.Field, global::Infragistics.Windows.Automation.Peers.DataPresenter.LabelAutomationPeer> labelPeers = this.LabelPeers;
			global::Infragistics.Windows.DataPresenter.HeaderPresenter headerElement = this.GetHeaderElement();
			global::System.Collections.Generic.Dictionary<global::Infragistics.Windows.DataPresenter.Field, global::Infragistics.Windows.DataPresenter.LabelPresenter> labels = new global::System.Collections.Generic.Dictionary<global::Infragistics.Windows.DataPresenter.Field, global::Infragistics.Windows.DataPresenter.LabelPresenter>();
			if (headerElement != null)
			{
				global::Infragistics.Windows.Utilities.DependencyObjectSearchCallback<global::Infragistics.Windows.DataPresenter.LabelPresenter> callback = delegate(global::Infragistics.Windows.DataPresenter.LabelPresenter element)
				{
					global::Infragistics.Windows.DataPresenter.Field field = element.Field;
					if (field != null)
					{
						labels[field] = element;
					}
					return false;
				};
				global::Infragistics.Windows.Utilities.GetDescendantFromType<global::Infragistics.Windows.DataPresenter.LabelPresenter>(headerElement, true, callback, new global::System.Type[]
				{
					typeof(global::Infragistics.Windows.DataPresenter.LabelPresenter)
				});
			}
			foreach (global::Infragistics.Windows.DataPresenter.Field key in this._fieldLayout.Fields)
			{
				global::Infragistics.Windows.Automation.Peers.DataPresenter.LabelAutomationPeer labelAutomationPeer;
				if (labelPeers.TryGetValue(key, out labelAutomationPeer))
				{
					global::Infragistics.Windows.DataPresenter.LabelPresenter element2;
					if (labels.TryGetValue(key, out element2))
					{
						global::System.Windows.Automation.Peers.AutomationPeer automationPeer = global::System.Windows.Automation.Peers.UIElementAutomationPeer.FromElement(element2);
						if (automationPeer != null && automationPeer.EventsSource != labelAutomationPeer)
						{
							if (automationPeer.EventsSource != null)
							{
								global::Infragistics.AutomationPeers.AutomationPeerHelper.InvalidateChildren(automationPeer.EventsSource);
							}
							automationPeer.EventsSource = labelAutomationPeer;
							global::Infragistics.AutomationPeers.AutomationPeerHelper.InvalidateChildren(labelAutomationPeer);
						}
					}
					list.Add(labelAutomationPeer);
				}
			}
			return list;
		}

		// Token: 0x060000CD RID: 205 RVA: 0x00004344 File Offset: 0x00002544
		protected override string GetClassNameCore()
		{
			return "Header";
		}

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x060000CE RID: 206 RVA: 0x0000434B File Offset: 0x0000254B
		internal global::Infragistics.Windows.DataPresenter.FieldLayout FieldLayout
		{
			get
			{
				return this._fieldLayout;
			}
		}

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x060000CF RID: 207 RVA: 0x00004353 File Offset: 0x00002553
		private global::System.Collections.Generic.Dictionary<global::Infragistics.Windows.DataPresenter.Field, global::Infragistics.Windows.Automation.Peers.DataPresenter.LabelAutomationPeer> LabelPeers
		{
			get
			{
				if (this._labelPeers == null)
				{
					this._labelPeers = new global::System.Collections.Generic.Dictionary<global::Infragistics.Windows.DataPresenter.Field, global::Infragistics.Windows.Automation.Peers.DataPresenter.LabelAutomationPeer>();
				}
				return this._labelPeers;
			}
		}

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x060000D0 RID: 208 RVA: 0x0000436E File Offset: 0x0000256E
		internal int Version
		{
			get
			{
				return this._fieldCollectionVersion;
			}
		}

		// Token: 0x060000D1 RID: 209 RVA: 0x00004376 File Offset: 0x00002576
		internal virtual global::Infragistics.Windows.Automation.Peers.DataPresenter.LabelAutomationPeer CreateLabelAutomationPeer(global::Infragistics.Windows.DataPresenter.Field field)
		{
			return new global::Infragistics.Windows.Automation.Peers.DataPresenter.LabelAutomationPeer(field, this);
		}

		// Token: 0x060000D2 RID: 210 RVA: 0x0000437F File Offset: 0x0000257F
		internal void Deactivate()
		{
			global::System.Collections.Specialized.CollectionChangedEventManager.RemoveListener(this._fieldLayout.Fields, this);
		}

		// Token: 0x060000D3 RID: 211 RVA: 0x00004394 File Offset: 0x00002594
		internal int GetFieldIndex(global::Infragistics.Windows.DataPresenter.Field field)
		{
			this.VerifyLabelPeers();
			int num = 0;
			foreach (global::Infragistics.Windows.DataPresenter.Field field2 in this._fieldLayout.Fields)
			{
				global::Infragistics.Windows.Automation.Peers.DataPresenter.LabelAutomationPeer labelAutomationPeer;
				if (this._labelPeers.TryGetValue(field2, out labelAutomationPeer))
				{
					if (field == field2)
					{
						return num;
					}
					num++;
				}
			}
			return -1;
		}

		// Token: 0x060000D4 RID: 212 RVA: 0x0000440C File Offset: 0x0000260C
		internal global::Infragistics.Windows.DataPresenter.Field GetFieldAtIndex(int index)
		{
			this.VerifyLabelPeers();
			int num = 0;
			foreach (global::Infragistics.Windows.DataPresenter.Field field in this._fieldLayout.Fields)
			{
				global::Infragistics.Windows.Automation.Peers.DataPresenter.LabelAutomationPeer labelAutomationPeer;
				if (this._labelPeers.TryGetValue(field, out labelAutomationPeer))
				{
					if (num == index)
					{
						return field;
					}
					num++;
				}
			}
			return null;
		}

		// Token: 0x060000D5 RID: 213 RVA: 0x00004484 File Offset: 0x00002684
		private global::Infragistics.Windows.DataPresenter.RecordPresenter GetFlatViewHeaderElement(global::Infragistics.Windows.DataPresenter.DataPresenterBase dp)
		{
			if (this._group != null && this._group.RecordCount == 0)
			{
				return null;
			}
			global::Infragistics.Windows.DataPresenter.FlatScrollRecordsCollection flatScrollRecordsCollection = dp.InternalRecords as global::Infragistics.Windows.DataPresenter.FlatScrollRecordsCollection;
			global::Infragistics.Windows.DataPresenter.RecordPresenter result = null;
			global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.HeaderRecord> list = (flatScrollRecordsCollection != null) ? flatScrollRecordsCollection.HeadersUsedInLastMeasure : null;
			if (list != null && list.Count > 0)
			{
				global::Infragistics.Windows.DataPresenter.RecordCollectionBase recordCollection = this._recordListAutomationPeer.GetRecordCollection();
				int i = 0;
				int count = list.Count;
				while (i < count)
				{
					global::Infragistics.Windows.DataPresenter.HeaderRecord headerRecord = list[i];
					if (headerRecord != null && headerRecord.FieldLayout == this._fieldLayout)
					{
						global::Infragistics.Windows.DataPresenter.Record attachedToRecord = headerRecord.AttachedToRecord;
						if (attachedToRecord == null || (attachedToRecord.ParentCollection == recordCollection && (this._group == null || this._group.CompareTo(attachedToRecord.VisibleIndex) == 0)))
						{
							result = headerRecord.AssociatedRecordPresenter;
							break;
						}
					}
					i++;
				}
			}
			return result;
		}

		// Token: 0x060000D6 RID: 214 RVA: 0x00004554 File Offset: 0x00002754
		internal global::Infragistics.Windows.Automation.Peers.DataPresenter.LabelAutomationPeer GetHeaderItem(global::Infragistics.Windows.DataPresenter.Cell cell)
		{
			this.VerifyLabelPeers();
			global::Infragistics.Windows.Automation.Peers.DataPresenter.LabelAutomationPeer result;
			if (!this.LabelPeers.TryGetValue(cell.Field, out result))
			{
				return null;
			}
			return result;
		}

		// Token: 0x060000D7 RID: 215 RVA: 0x00004580 File Offset: 0x00002780
		internal global::System.Windows.Automation.Provider.IRawElementProviderSimple[] GetHeaderItems()
		{
			this.VerifyLabelPeers();
			global::System.Collections.Generic.List<global::System.Windows.Automation.Provider.IRawElementProviderSimple> list = new global::System.Collections.Generic.List<global::System.Windows.Automation.Provider.IRawElementProviderSimple>(this._labelPeers.Count);
			foreach (global::Infragistics.Windows.DataPresenter.Field key in this._fieldLayout.Fields)
			{
				global::Infragistics.Windows.Automation.Peers.DataPresenter.LabelAutomationPeer peer;
				if (this._labelPeers.TryGetValue(key, out peer))
				{
					list.Add(base.ProviderFromPeer(peer));
				}
			}
			return list.ToArray();
		}

		// Token: 0x060000D8 RID: 216 RVA: 0x00004608 File Offset: 0x00002808
		internal int GetHeaderItemCount()
		{
			this.VerifyLabelPeers();
			return this._labelPeers.Count;
		}

		// Token: 0x060000D9 RID: 217 RVA: 0x00004624 File Offset: 0x00002824
		internal global::Infragistics.Windows.DataPresenter.HeaderPresenter GetHeaderElement()
		{
			global::Infragistics.Windows.DataPresenter.RecordPresenter recordPresenter = null;
			if (this._headerRecordPresenter != null)
			{
				recordPresenter = (global::Infragistics.CoreUtilities.GetWeakReferenceTargetSafe(this._headerRecordPresenter) as global::Infragistics.Windows.DataPresenter.RecordPresenter);
				if (recordPresenter != null && (!recordPresenter.IsLoaded || !this.IsValidRecordPresenter(recordPresenter)))
				{
					recordPresenter = null;
				}
			}
			if (recordPresenter == null)
			{
				global::Infragistics.Windows.DataPresenter.DataPresenterBase dataPresenter = this._fieldLayout.DataPresenter;
				if (dataPresenter != null && dataPresenter.IsFlatView)
				{
					recordPresenter = this.GetFlatViewHeaderElement(dataPresenter);
				}
				else
				{
					global::System.Windows.Controls.ItemsControl parent = this._listAutomationPeer.Owner as global::System.Windows.Controls.ItemsControl;
					global::Infragistics.Windows.Utilities.DependencyObjectSearchCallback<global::Infragistics.Windows.DataPresenter.RecordPresenter> callback = (global::Infragistics.Windows.DataPresenter.RecordPresenter record) => this.IsValidRecordPresenter(record);
					recordPresenter = global::Infragistics.Windows.Utilities.GetDescendantFromType<global::Infragistics.Windows.DataPresenter.RecordPresenter>(parent, true, callback, new global::System.Type[]
					{
						typeof(global::Infragistics.Windows.DataPresenter.RecordPresenter)
					});
				}
			}
			this._headerRecordPresenter = ((recordPresenter == null) ? null : new global::System.WeakReference(recordPresenter));
			if (recordPresenter != null)
			{
				global::System.Windows.FrameworkElement headerContentSite = recordPresenter.GetHeaderContentSite();
				if (headerContentSite == null)
				{
					return null;
				}
				global::Infragistics.Windows.DataPresenter.HeaderPresenter descendantFromType = global::Infragistics.Windows.Utilities.GetDescendantFromType<global::Infragistics.Windows.DataPresenter.HeaderPresenter>(headerContentSite, true, null, new global::System.Type[]
				{
					typeof(global::System.Windows.Controls.ItemsControl)
				});
				if (descendantFromType != null)
				{
					return descendantFromType;
				}
			}
			return null;
		}

		// Token: 0x060000DA RID: 218 RVA: 0x00004720 File Offset: 0x00002920
		internal bool IsValidRecordPresenter(global::Infragistics.Windows.DataPresenter.RecordPresenter rp)
		{
			global::Infragistics.Windows.DataPresenter.DataPresenterBase dataPresenter = this._fieldLayout.DataPresenter;
			if (dataPresenter == null)
			{
				return false;
			}
			if (!rp.HasHeaderContent || rp.FieldLayout != this._fieldLayout)
			{
				return false;
			}
			global::Infragistics.Windows.DataPresenter.Record record = rp.GetRecordForMeasure();
			global::Infragistics.Windows.DataPresenter.HeaderRecord headerRecord = record as global::Infragistics.Windows.DataPresenter.HeaderRecord;
			if (headerRecord != null)
			{
				record = headerRecord.AttachedToRecord;
				if (record == null)
				{
					return rp.Visibility != global::System.Windows.Visibility.Collapsed && this._group == null;
				}
			}
			return record != null && (!dataPresenter.IsFlatView || record.ParentCollection == this._recordListAutomationPeer.GetRecordCollection()) && (this._group == null || this._group.IndexOf(record) >= 0);
		}

		// Token: 0x060000DB RID: 219 RVA: 0x000047C4 File Offset: 0x000029C4
		internal void OnVisibleFieldsChanged()
		{
			this._fieldCollectionVersion = -1;
			global::System.Collections.Generic.Dictionary<global::Infragistics.Windows.DataPresenter.Field, global::Infragistics.Windows.Automation.Peers.DataPresenter.LabelAutomationPeer> labelPeers = this._labelPeers;
			this.VerifyLabelPeers();
			global::System.Collections.Generic.Dictionary<global::Infragistics.Windows.DataPresenter.Field, global::Infragistics.Windows.Automation.Peers.DataPresenter.LabelAutomationPeer> labelPeers2 = this.LabelPeers;
			int num = (labelPeers != null) ? labelPeers.Count : 0;
			int num2 = (labelPeers2 != null) ? labelPeers2.Count : 0;
			bool flag = num != num2;
			if (!flag && num > 0)
			{
				foreach (global::System.Collections.Generic.KeyValuePair<global::Infragistics.Windows.DataPresenter.Field, global::Infragistics.Windows.Automation.Peers.DataPresenter.LabelAutomationPeer> keyValuePair in labelPeers2)
				{
					if (!labelPeers.ContainsKey(keyValuePair.Key))
					{
						flag = true;
						break;
					}
				}
			}
			if (flag)
			{
				if (num != num2)
				{
					global::System.Windows.Automation.Peers.AutomationPeer automationPeer = (this._group != null) ? this._group.AutomationPeer : ((global::System.Windows.Automation.Peers.AutomationPeer)this._recordListAutomationPeer);
					bool flag2 = (this._group != null) ? this._group.AutomationPeer.IsHorizontalRowLayout : this._recordListAutomationPeer.IsHorizontalRowLayout;
					global::System.Windows.Automation.AutomationProperty property = (!flag2) ? global::System.Windows.Automation.GridPatternIdentifiers.ColumnCountProperty : global::System.Windows.Automation.GridPatternIdentifiers.RowCountProperty;
					automationPeer.RaisePropertyChangedEvent(property, num, num2);
				}
				if (this._recordListAutomationPeer is global::System.Windows.Automation.Peers.AutomationPeer)
				{
					((global::System.Windows.Automation.Peers.AutomationPeer)this._recordListAutomationPeer).RaiseAutomationEvent(global::System.Windows.Automation.Peers.AutomationEvents.StructureChanged);
				}
			}
		}

		// Token: 0x060000DC RID: 220 RVA: 0x00004904 File Offset: 0x00002B04
		private void VerifyLabelPeers()
		{
			if (this._fieldLayout.Fields.Version != this._fieldCollectionVersion)
			{
				this._fieldCollectionVersion = this._fieldLayout.Fields.Version;
				global::System.Collections.Generic.Dictionary<global::Infragistics.Windows.DataPresenter.Field, global::Infragistics.Windows.Automation.Peers.DataPresenter.LabelAutomationPeer> labelPeers = this._labelPeers;
				this._labelPeers = null;
				global::System.Collections.Generic.Dictionary<global::Infragistics.Windows.DataPresenter.Field, global::Infragistics.Windows.Automation.Peers.DataPresenter.LabelAutomationPeer> labelPeers2 = this.LabelPeers;
				foreach (global::Infragistics.Windows.DataPresenter.Field field in this._fieldLayout.Fields)
				{
					if (field.IsVisibleInCellArea)
					{
						global::Infragistics.Windows.Automation.Peers.DataPresenter.LabelAutomationPeer value;
						if (labelPeers == null || !labelPeers.TryGetValue(field, out value))
						{
							value = this.CreateLabelAutomationPeer(field);
						}
						labelPeers2.Add(field, value);
					}
				}
			}
		}

		// Token: 0x060000DD RID: 221 RVA: 0x000049C0 File Offset: 0x00002BC0
		bool global::System.Windows.IWeakEventListener.ReceiveWeakEvent(global::System.Type managerType, object sender, global::System.EventArgs e)
		{
			if (managerType == typeof(global::System.Collections.Specialized.CollectionChangedEventManager))
			{
				this.OnVisibleFieldsChanged();
				return true;
			}
			return false;
		}

		// Token: 0x0400003A RID: 58
		private global::Infragistics.Windows.DataPresenter.FieldLayout _fieldLayout;

		// Token: 0x0400003B RID: 59
		private global::Infragistics.Windows.Automation.Peers.DataPresenter.IRecordListAutomationPeer _recordListAutomationPeer;

		// Token: 0x0400003C RID: 60
		private global::Infragistics.Windows.Automation.Peers.IListAutomationPeer _listAutomationPeer;

		// Token: 0x0400003D RID: 61
		private global::System.Collections.Generic.Dictionary<global::Infragistics.Windows.DataPresenter.Field, global::Infragistics.Windows.Automation.Peers.DataPresenter.LabelAutomationPeer> _labelPeers;

		// Token: 0x0400003E RID: 62
		private int _fieldCollectionVersion = -1;

		// Token: 0x0400003F RID: 63
		private global::Infragistics.Windows.Automation.Peers.DataPresenter.RecordListGroup _group;

		// Token: 0x04000040 RID: 64
		private global::System.WeakReference _headerRecordPresenter;
	}
}
