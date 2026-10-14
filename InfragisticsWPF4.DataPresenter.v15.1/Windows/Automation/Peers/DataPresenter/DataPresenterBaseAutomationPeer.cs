using System;
using System.Collections.Generic;
using System.Windows.Automation;
using System.Windows.Automation.Peers;
using System.Windows.Threading;
using Infragistics.Collections;
using Infragistics.Windows.DataPresenter;
using Infragistics.Windows.Internal;

namespace Infragistics.Windows.Automation.Peers.DataPresenter
{
	// Token: 0x02000013 RID: 19
	public class DataPresenterBaseAutomationPeer : global::System.Windows.Automation.Peers.FrameworkElementAutomationPeer
	{
		// Token: 0x0600008D RID: 141 RVA: 0x000038F0 File Offset: 0x00001AF0
		public DataPresenterBaseAutomationPeer(global::Infragistics.Windows.DataPresenter.DataPresenterBase owner) : base(owner)
		{
			this._recordsInViewVersionTracker = new global::Infragistics.Windows.Internal.PropertyValueTracker(owner, global::Infragistics.Windows.DataPresenter.DataPresenterBase.RecordsInViewVersionProperty, new global::Infragistics.Windows.Internal.PropertyValueTracker.PropertyValueChangedHandler(this.OnRecordsInViewChanged), false);
			owner.LayoutUpdated += this.OnOwnerLayoutUpdated;
		}

		// Token: 0x0600008E RID: 142 RVA: 0x00003929 File Offset: 0x00001B29
		protected override global::System.Windows.Automation.Peers.AutomationControlType GetAutomationControlTypeCore()
		{
			return global::System.Windows.Automation.Peers.AutomationControlType.Custom;
		}

		// Token: 0x0600008F RID: 143 RVA: 0x0000392D File Offset: 0x00001B2D
		protected override string GetClassNameCore()
		{
			return "DataPresenterBase";
		}

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x06000090 RID: 144 RVA: 0x00003934 File Offset: 0x00001B34
		// (set) Token: 0x06000091 RID: 145 RVA: 0x00003940 File Offset: 0x00001B40
		public static bool ProcessRecordsInViewOnly
		{
			get
			{
				return global::Infragistics.Windows.Automation.Peers.DataPresenter.DataPresenterBaseAutomationPeer._processRecordsInViewOnlyState.Value;
			}
			set
			{
				global::Infragistics.Windows.Automation.Peers.DataPresenter.DataPresenterBaseAutomationPeer._processRecordsInViewOnlyState.Value = value;
			}
		}

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x06000092 RID: 146 RVA: 0x0000394D File Offset: 0x00001B4D
		// (set) Token: 0x06000093 RID: 147 RVA: 0x00003959 File Offset: 0x00001B59
		public static bool ProcessVisualTreeOnly
		{
			get
			{
				return global::Infragistics.Windows.Automation.Peers.DataPresenter.DataPresenterBaseAutomationPeer._processVisualTreeOnlyState.Value;
			}
			set
			{
				global::Infragistics.Windows.Automation.Peers.DataPresenter.DataPresenterBaseAutomationPeer._processVisualTreeOnlyState.Value = value;
			}
		}

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x06000094 RID: 148 RVA: 0x00003966 File Offset: 0x00001B66
		internal static bool ShouldVirtualizeRecordPeers
		{
			get
			{
				return global::System.Windows.Automation.ItemContainerPatternIdentifiers.Pattern != null && global::Infragistics.Windows.Automation.Peers.DataPresenter.DataPresenterBaseAutomationPeer.ProcessRecordsInViewOnly;
			}
		}

		// Token: 0x06000095 RID: 149 RVA: 0x00003978 File Offset: 0x00001B78
		internal void AddProxyPeerHost(global::System.Windows.Automation.Peers.AutomationPeer peer)
		{
			if (this._proxyPeerHostList == null)
			{
				this._proxyPeerHostList = new global::Infragistics.Collections.WeakList<global::System.Windows.Automation.Peers.AutomationPeer>();
				this._processVisualTreeTracker = new global::Infragistics.Windows.Internal.PropertyValueTracker(global::Infragistics.Windows.Automation.Peers.DataPresenter.DataPresenterBaseAutomationPeer._processVisualTreeOnlyState, "Value", new global::Infragistics.Windows.Internal.PropertyValueTracker.PropertyValueChangedHandler(this.OnProcessVisualTreeOnlyChanged));
				this._processRecordsInViewTracker = new global::Infragistics.Windows.Internal.PropertyValueTracker(global::Infragistics.Windows.Automation.Peers.DataPresenter.DataPresenterBaseAutomationPeer._processRecordsInViewOnlyState, "Value", new global::Infragistics.Windows.Internal.PropertyValueTracker.PropertyValueChangedHandler(this.OnProcessVisualTreeOnlyChanged), true);
			}
			this._proxyPeerHostList.Add(peer);
		}

		// Token: 0x06000096 RID: 150 RVA: 0x000039E8 File Offset: 0x00001BE8
		internal static void AddProxyPeerHost(global::System.Windows.Automation.Peers.AutomationPeer peer, global::Infragistics.Windows.DataPresenter.DataPresenterBase dp)
		{
			if (dp != null)
			{
				global::Infragistics.Windows.Automation.Peers.DataPresenter.DataPresenterBaseAutomationPeer dataPresenterBaseAutomationPeer = global::System.Windows.Automation.Peers.UIElementAutomationPeer.CreatePeerForElement(dp) as global::Infragistics.Windows.Automation.Peers.DataPresenter.DataPresenterBaseAutomationPeer;
				if (dataPresenterBaseAutomationPeer != null)
				{
					dataPresenterBaseAutomationPeer.AddProxyPeerHost(peer);
				}
			}
		}

		// Token: 0x06000097 RID: 151 RVA: 0x00003C24 File Offset: 0x00001E24
		internal global::System.Collections.Generic.IEnumerable<global::Infragistics.Windows.DataPresenter.Record> GetRecordsInView(global::Infragistics.Windows.DataPresenter.ViewableRecordCollection records)
		{
			global::Infragistics.Windows.DataPresenter.Record[] recordsInView = this.GetRecordsInView();
			global::Infragistics.Windows.DataPresenter.RecordCollectionBase recordCollection = records.RecordCollection;
			global::System.Collections.Generic.HashSet<global::Infragistics.Windows.DataPresenter.Record> returnedRecords = new global::System.Collections.Generic.HashSet<global::Infragistics.Windows.DataPresenter.Record>();
			global::Infragistics.Windows.DataPresenter.Record[] array = recordsInView;
			int i = 0;
			IL_FD:
			while (i < array.Length)
			{
				global::Infragistics.Windows.DataPresenter.Record record = array[i];
				global::Infragistics.Windows.DataPresenter.Record temp = record;
				while (temp.ParentCollection != recordCollection)
				{
					temp = temp.ParentRecord;
					if (temp == null)
					{
						IL_EF:
						i++;
						goto IL_FD;
					}
				}
				if (returnedRecords.Add(temp))
				{
					yield return temp;
					goto IL_EF;
				}
				goto IL_EF;
			}
			yield break;
		}

		// Token: 0x06000098 RID: 152 RVA: 0x00003C5C File Offset: 0x00001E5C
		private void DirtyVirtualizedRecordPeers(bool async)
		{
			if (this._pendingDirtyRecordPeers != null)
			{
				if (async)
				{
					return;
				}
				this._pendingDirtyRecordPeers.Abort();
				this._pendingDirtyRecordPeers = null;
			}
			if (async)
			{
				this._pendingDirtyRecordPeers = base.Owner.Dispatcher.BeginInvoke(global::System.Windows.Threading.DispatcherPriority.Render, new global::Infragistics.Windows.DataPresenter.GridUtilities.MethodDelegate(delegate()
				{
					if (this._pendingDirtyRecordPeers != null)
					{
						this.DirtyVirtualizedRecordPeers(false);
					}
				}));
				return;
			}
			this.OnProcessVisualTreeOnlyChanged();
			if (this._proxyPeerHostList != null)
			{
				this._proxyPeerHostList.Compact();
			}
		}

		// Token: 0x06000099 RID: 153 RVA: 0x00003CD0 File Offset: 0x00001ED0
		private global::Infragistics.Windows.DataPresenter.Record[] GetRecordsInView()
		{
			if (this._recordsInView == null)
			{
				global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.RecordPresenter> recordPresentersInView = ((global::Infragistics.Windows.DataPresenter.DataPresenterBase)base.Owner).GetRecordPresentersInView(true, true, true, false);
				global::Infragistics.Windows.DataPresenter.Record[] array = new global::Infragistics.Windows.DataPresenter.Record[recordPresentersInView.Count];
				for (int i = 0; i < recordPresentersInView.Count; i++)
				{
					array[i] = recordPresentersInView[i].Record;
				}
				this._recordsInView = array;
			}
			return this._recordsInView;
		}

		// Token: 0x0600009A RID: 154 RVA: 0x00003D34 File Offset: 0x00001F34
		private void OnOwnerLayoutUpdated(object sender, global::System.EventArgs e)
		{
			if (this._awaitingDirtyRecordsUpdateLayout)
			{
				this._awaitingDirtyRecordsUpdateLayout = false;
				if (this._recordsInView != null)
				{
					global::Infragistics.Windows.DataPresenter.Record[] recordsInView = this._recordsInView;
					this._recordsInView = null;
					global::Infragistics.Windows.DataPresenter.Record[] recordsInView2 = this.GetRecordsInView();
					if (!global::Infragistics.CoreUtilities.AreEqual<global::Infragistics.Windows.DataPresenter.Record>(recordsInView, recordsInView2, null))
					{
						this.DirtyVirtualizedRecordPeers(false);
					}
				}
			}
		}

		// Token: 0x0600009B RID: 155 RVA: 0x00003D80 File Offset: 0x00001F80
		private void OnProcessVisualTreeOnlyChanged()
		{
			if (this._proxyPeerHostList == null)
			{
				return;
			}
			foreach (global::System.Windows.Automation.Peers.AutomationPeer automationPeer in this._proxyPeerHostList)
			{
				automationPeer.ResetChildrenCache();
			}
		}

		// Token: 0x0600009C RID: 156 RVA: 0x00003DD8 File Offset: 0x00001FD8
		private void OnRecordsInViewChanged()
		{
			this._recordsInView = null;
			if (!global::Infragistics.Windows.Automation.Peers.DataPresenter.DataPresenterBaseAutomationPeer.ProcessVisualTreeOnly && global::Infragistics.Windows.Automation.Peers.DataPresenter.DataPresenterBaseAutomationPeer.ShouldVirtualizeRecordPeers)
			{
				this._awaitingDirtyRecordsUpdateLayout = true;
				this.DirtyVirtualizedRecordPeers(true);
			}
		}

		// Token: 0x04000030 RID: 48
		private static readonly global::Infragistics.Windows.DataPresenter.SimpleValueHolder<bool> _processVisualTreeOnlyState = new global::Infragistics.Windows.DataPresenter.SimpleValueHolder<bool>(false);

		// Token: 0x04000031 RID: 49
		private global::Infragistics.Collections.WeakList<global::System.Windows.Automation.Peers.AutomationPeer> _proxyPeerHostList;

		// Token: 0x04000032 RID: 50
		private global::Infragistics.Windows.Internal.PropertyValueTracker _processVisualTreeTracker;

		// Token: 0x04000033 RID: 51
		private static readonly global::Infragistics.Windows.DataPresenter.SimpleValueHolder<bool> _processRecordsInViewOnlyState = new global::Infragistics.Windows.DataPresenter.SimpleValueHolder<bool>(true);

		// Token: 0x04000034 RID: 52
		private global::Infragistics.Windows.Internal.PropertyValueTracker _processRecordsInViewTracker;

		// Token: 0x04000035 RID: 53
		private global::Infragistics.Windows.DataPresenter.Record[] _recordsInView;

		// Token: 0x04000036 RID: 54
		private global::Infragistics.Windows.Internal.PropertyValueTracker _recordsInViewVersionTracker;

		// Token: 0x04000037 RID: 55
		private bool _awaitingDirtyRecordsUpdateLayout;

		// Token: 0x04000038 RID: 56
		private global::System.Windows.Threading.DispatcherOperation _pendingDirtyRecordPeers;
	}
}
