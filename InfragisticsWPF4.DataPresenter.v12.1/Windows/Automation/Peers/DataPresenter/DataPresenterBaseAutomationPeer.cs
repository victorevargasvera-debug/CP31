using System;
using System.Windows.Automation.Peers;
using Infragistics.Collections;
using Infragistics.Windows.DataPresenter;
using Infragistics.Windows.Internal;

namespace Infragistics.Windows.Automation.Peers.DataPresenter
{
	// Token: 0x02000013 RID: 19
	public class DataPresenterBaseAutomationPeer : global::System.Windows.Automation.Peers.FrameworkElementAutomationPeer
	{
		// Token: 0x0600008B RID: 139 RVA: 0x00003D3C File Offset: 0x00001F3C
		public DataPresenterBaseAutomationPeer(global::Infragistics.Windows.DataPresenter.DataPresenterBase owner) : base(owner)
		{
		}

		// Token: 0x0600008C RID: 140 RVA: 0x00003D45 File Offset: 0x00001F45
		protected override global::System.Windows.Automation.Peers.AutomationControlType GetAutomationControlTypeCore()
		{
			return global::System.Windows.Automation.Peers.AutomationControlType.Custom;
		}

		// Token: 0x0600008D RID: 141 RVA: 0x00003D49 File Offset: 0x00001F49
		protected override string GetClassNameCore()
		{
			return "DataPresenterBase";
		}

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x0600008E RID: 142 RVA: 0x00003D50 File Offset: 0x00001F50
		// (set) Token: 0x0600008F RID: 143 RVA: 0x00003D5C File Offset: 0x00001F5C
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

		// Token: 0x06000090 RID: 144 RVA: 0x00003D6C File Offset: 0x00001F6C
		internal void AddProxyPeerHost(global::System.Windows.Automation.Peers.AutomationPeer peer)
		{
			if (this._proxyPeerHostList == null)
			{
				this._proxyPeerHostList = new global::Infragistics.Collections.WeakList<global::System.Windows.Automation.Peers.AutomationPeer>();
				this._processVisualTreeTracker = new global::Infragistics.Windows.Internal.PropertyValueTracker(global::Infragistics.Windows.Automation.Peers.DataPresenter.DataPresenterBaseAutomationPeer._processVisualTreeOnlyState, "Value", new global::Infragistics.Windows.Internal.PropertyValueTracker.PropertyValueChangedHandler(this.OnProcessVisualTreeOnlyChanged));
			}
			this._proxyPeerHostList.Add(peer);
		}

		// Token: 0x06000091 RID: 145 RVA: 0x00003DBC File Offset: 0x00001FBC
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

		// Token: 0x06000092 RID: 146 RVA: 0x00003DE4 File Offset: 0x00001FE4
		private void OnProcessVisualTreeOnlyChanged()
		{
			foreach (global::System.Windows.Automation.Peers.AutomationPeer automationPeer in this._proxyPeerHostList)
			{
				automationPeer.ResetChildrenCache();
			}
		}

		// Token: 0x04000028 RID: 40
		private static readonly global::Infragistics.Windows.DataPresenter.SimpleValueHolder<bool> _processVisualTreeOnlyState = new global::Infragistics.Windows.DataPresenter.SimpleValueHolder<bool>(false);

		// Token: 0x04000029 RID: 41
		private global::Infragistics.Collections.WeakList<global::System.Windows.Automation.Peers.AutomationPeer> _proxyPeerHostList;

		// Token: 0x0400002A RID: 42
		private global::Infragistics.Windows.Internal.PropertyValueTracker _processVisualTreeTracker;
	}
}
