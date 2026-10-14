using System;
using System.Windows.Automation.Peers;
using Infragistics.AutomationPeers;

namespace Infragistics.Windows.Automation.Peers
{
	// Token: 0x02000102 RID: 258
	public class RecycleableItemAutomationPeer : global::Infragistics.AutomationPeers.AutomationPeerProxy
	{
		// Token: 0x06000911 RID: 2321 RVA: 0x0001F69D File Offset: 0x0001D89D
		public RecycleableItemAutomationPeer(object item, global::Infragistics.Windows.Automation.Peers.IListAutomationPeer listAutomationPeer)
		{
			if (item == null)
			{
				throw new global::System.ArgumentNullException("item");
			}
			if (listAutomationPeer == null)
			{
				throw new global::System.ArgumentNullException("listAutomationPeer");
			}
			this._item = item;
			this._listAutomationPeer = listAutomationPeer;
		}

		// Token: 0x06000912 RID: 2322 RVA: 0x0001F6CF File Offset: 0x0001D8CF
		protected override global::System.Windows.Automation.Peers.AutomationControlType GetAutomationControlTypeCore()
		{
			return global::System.Windows.Automation.Peers.AutomationControlType.ListItem;
		}

		// Token: 0x06000913 RID: 2323 RVA: 0x0001F6D2 File Offset: 0x0001D8D2
		protected override string GetClassNameCore()
		{
			return "Item";
		}

		// Token: 0x06000914 RID: 2324 RVA: 0x0001F6D9 File Offset: 0x0001D8D9
		protected override global::System.Windows.Automation.Peers.AutomationPeer GetUnderlyingPeer()
		{
			return this._listAutomationPeer.GetUnderlyingPeer(this._item);
		}

		// Token: 0x17000176 RID: 374
		// (get) Token: 0x06000915 RID: 2325 RVA: 0x0001F6EC File Offset: 0x0001D8EC
		public object Item
		{
			get
			{
				return this._item;
			}
		}

		// Token: 0x17000177 RID: 375
		// (get) Token: 0x06000916 RID: 2326 RVA: 0x0001F6F4 File Offset: 0x0001D8F4
		public global::Infragistics.Windows.Automation.Peers.IListAutomationPeer ListAutomationPeer
		{
			get
			{
				return this._listAutomationPeer;
			}
		}

		// Token: 0x06000917 RID: 2327 RVA: 0x0001F6FC File Offset: 0x0001D8FC
		internal global::System.Windows.Automation.Peers.AutomationPeer GetWrapperPeer()
		{
			return this.GetUnderlyingPeer();
		}

		// Token: 0x04000443 RID: 1091
		private object _item;

		// Token: 0x04000444 RID: 1092
		private global::Infragistics.Windows.Automation.Peers.IListAutomationPeer _listAutomationPeer;
	}
}
