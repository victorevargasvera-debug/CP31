using System;
using System.Collections.Generic;
using System.Reflection;
using System.Windows.Automation.Peers;
using Infragistics.AutomationPeers;
using Infragistics.Controls.Menus;
using Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree;

namespace Motorola.CommonCPS.RadioManagement.Controls.UiHelpers
{
	// Token: 0x0200012B RID: 299
	public class RMDataTreeAutomationPeerManager
	{
		// Token: 0x06000946 RID: 2374 RVA: 0x00098D9C File Offset: 0x00096F9C
		public RMDataTreeAutomationPeerManager(global::Infragistics.AutomationPeers.XamDataTreeAutomationPeer automationPeer)
		{
			int a_ = 15;
			base..ctor();
			global::System.Reflection.FieldInfo field = automationPeer.GetType().GetField(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("\ud9a8캪좬\uddae슰풴풶톸\udeba", a_), global::System.Reflection.BindingFlags.Instance | global::System.Reflection.BindingFlags.NonPublic);
			this.a = (((field != null) ? field.GetValue(automationPeer) : null) as global::System.Collections.Generic.Dictionary<global::Infragistics.Controls.Menus.XamDataTreeNode, global::System.Windows.Automation.Peers.AutomationPeer>);
		}

		// Token: 0x06000947 RID: 2375 RVA: 0x00098DF0 File Offset: 0x00096FF0
		public void ClearCachedData()
		{
			short num = (short)215914440;
			short num2 = num;
			num = (short)906008520;
			switch (num2 == num)
			{
			}
			num = (short)873988096;
			short num3 = num;
			num = (short)1301479425;
			if (num != 0)
			{
			}
			num = (short)258801664;
			if (num != 0)
			{
			}
			global::System.Collections.Generic.Dictionary<global::Infragistics.Controls.Menus.XamDataTreeNode, global::System.Windows.Automation.Peers.AutomationPeer> dictionary = this.a;
			if (dictionary == null)
			{
				return;
			}
			dictionary.Clear();
		}

		// Token: 0x0400044D RID: 1101
		private readonly global::System.Collections.Generic.Dictionary<global::Infragistics.Controls.Menus.XamDataTreeNode, global::System.Windows.Automation.Peers.AutomationPeer> a;
	}
}
