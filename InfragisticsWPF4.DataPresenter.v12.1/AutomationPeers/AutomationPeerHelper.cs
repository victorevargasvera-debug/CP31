using System;
using System.Collections.Generic;
using System.Threading;
using System.Windows.Automation.Peers;
using System.Windows.Threading;
using Infragistics.Collections;

namespace Infragistics.AutomationPeers
{
	// Token: 0x02000002 RID: 2
	internal static class AutomationPeerHelper
	{
		// Token: 0x06000001 RID: 1 RVA: 0x000020D0 File Offset: 0x000002D0
		internal static void InvalidateChildren(global::System.Windows.Automation.Peers.AutomationPeer peer)
		{
			if (global::Infragistics.AutomationPeers.AutomationPeerHelper._pendingInvalidationTable == null)
			{
				global::Infragistics.AutomationPeers.AutomationPeerHelper._pendingInvalidationTable = new global::Infragistics.Collections.WeakDictionary<global::System.Windows.Automation.Peers.AutomationPeer, bool>(true, false);
			}
			global::Infragistics.AutomationPeers.AutomationPeerHelper._pendingInvalidationTable[peer] = true;
			if (global::Infragistics.AutomationPeers.AutomationPeerHelper._pendingOperation == null)
			{
				global::System.Windows.Threading.Dispatcher currentDispatcher = global::System.Windows.Threading.Dispatcher.CurrentDispatcher;
				global::System.Windows.Threading.DispatcherPriority priority = global::System.Windows.Threading.DispatcherPriority.Background;
				global::System.Delegate method = new global::System.Threading.SendOrPostCallback(global::Infragistics.AutomationPeers.AutomationPeerHelper.OnProcessPendingInvalidations);
				object[] arg = new object[1];
				global::Infragistics.AutomationPeers.AutomationPeerHelper._pendingOperation = currentDispatcher.BeginInvoke(priority, method, arg);
			}
		}

		// Token: 0x06000002 RID: 2 RVA: 0x00002127 File Offset: 0x00000327
		internal static void RemovePendingChildrenInvalidation(global::System.Windows.Automation.Peers.AutomationPeer peer)
		{
			if (global::Infragistics.AutomationPeers.AutomationPeerHelper._pendingInvalidationTable != null)
			{
				global::Infragistics.AutomationPeers.AutomationPeerHelper._pendingInvalidationTable.Remove(peer);
			}
		}

		// Token: 0x06000003 RID: 3 RVA: 0x0000213C File Offset: 0x0000033C
		private static void OnProcessPendingInvalidations(object param)
		{
			global::Infragistics.AutomationPeers.AutomationPeerHelper._pendingOperation = null;
			global::System.Collections.Generic.List<global::System.Windows.Automation.Peers.AutomationPeer> list = new global::System.Collections.Generic.List<global::System.Windows.Automation.Peers.AutomationPeer>(global::Infragistics.AutomationPeers.AutomationPeerHelper._pendingInvalidationTable.Keys);
			global::Infragistics.AutomationPeers.AutomationPeerHelper._pendingInvalidationTable.Clear();
			foreach (global::System.Windows.Automation.Peers.AutomationPeer automationPeer in list)
			{
				automationPeer.ResetChildrenCache();
			}
		}

		// Token: 0x04000001 RID: 1
		[global::System.ThreadStatic]
		private static global::System.Windows.Threading.DispatcherOperation _pendingOperation;

		// Token: 0x04000002 RID: 2
		[global::System.ThreadStatic]
		private static global::Infragistics.Collections.WeakDictionary<global::System.Windows.Automation.Peers.AutomationPeer, bool> _pendingInvalidationTable;
	}
}
