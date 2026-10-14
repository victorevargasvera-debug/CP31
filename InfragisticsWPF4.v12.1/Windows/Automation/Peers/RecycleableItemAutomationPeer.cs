using System;
using System.Windows.Automation.Peers;
using Infragistics.AutomationPeers;

namespace Infragistics.Windows.Automation.Peers
{
	// Token: 0x020000E4 RID: 228
	public class RecycleableItemAutomationPeer : global::Infragistics.AutomationPeers.AutomationPeerProxy
	{
		// Token: 0x06000812 RID: 2066 RVA: 0x0001BAD5 File Offset: 0x00019CD5
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

		// Token: 0x06000813 RID: 2067 RVA: 0x0001BB07 File Offset: 0x00019D07
		protected override global::System.Windows.Automation.Peers.AutomationControlType GetAutomationControlTypeCore()
		{
			return global::System.Windows.Automation.Peers.AutomationControlType.ListItem;
		}

		// Token: 0x06000814 RID: 2068 RVA: 0x0001BB0A File Offset: 0x00019D0A
		protected override string GetClassNameCore()
		{
			return "Item";
		}

		// Token: 0x06000815 RID: 2069 RVA: 0x0001BB11 File Offset: 0x00019D11
		protected override global::System.Windows.Automation.Peers.AutomationPeer GetUnderlyingPeer()
		{
			return this._listAutomationPeer.GetUnderlyingPeer(this._item);
		}

		// Token: 0x1700015E RID: 350
		// (get) Token: 0x06000816 RID: 2070 RVA: 0x0001BB24 File Offset: 0x00019D24
		public object Item
		{
			get
			{
				return this._item;
			}
		}

		// Token: 0x1700015F RID: 351
		// (get) Token: 0x06000817 RID: 2071 RVA: 0x0001BB2C File Offset: 0x00019D2C
		public global::Infragistics.Windows.Automation.Peers.IListAutomationPeer ListAutomationPeer
		{
			get
			{
				return this._listAutomationPeer;
			}
		}

		// Token: 0x06000818 RID: 2072 RVA: 0x0001BB34 File Offset: 0x00019D34
		internal global::System.Windows.Automation.Peers.AutomationPeer GetWrapperPeer()
		{
			return this.GetUnderlyingPeer();
		}

		// Token: 0x04000390 RID: 912
		private object _item;

		// Token: 0x04000391 RID: 913
		private global::Infragistics.Windows.Automation.Peers.IListAutomationPeer _listAutomationPeer;
	}
}
