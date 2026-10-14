using System;
using System.Collections.Generic;
using System.Reflection;
using System.Threading;
using System.Windows.Automation;
using System.Windows.Automation.Peers;
using System.Windows.Threading;
using Infragistics.Collections;

namespace Infragistics.AutomationPeers
{
	// Token: 0x02000002 RID: 2
	internal static class AutomationPeerHelper
	{
		// Token: 0x06000001 RID: 1 RVA: 0x000020D0 File Offset: 0x000002D0
		internal static object GetAutomationPropertyValue(int propertyId, global::System.Windows.Automation.Peers.AutomationPeer peer)
		{
			if (peer == null)
			{
				return null;
			}
			if (propertyId == global::System.Windows.Automation.AutomationElementIdentifiers.NameProperty.Id)
			{
				return peer.GetName();
			}
			if (propertyId == global::System.Windows.Automation.AutomationElementIdentifiers.AutomationIdProperty.Id)
			{
				return peer.GetAutomationId();
			}
			if (propertyId == global::System.Windows.Automation.AutomationElementIdentifiers.ControlTypeProperty.Id)
			{
				return global::Infragistics.AutomationPeers.AutomationPeerHelper.GetControlTypeId(peer.GetAutomationControlType());
			}
			return null;
		}

		// Token: 0x06000002 RID: 2 RVA: 0x00002124 File Offset: 0x00000324
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

		// Token: 0x06000003 RID: 3 RVA: 0x0000217B File Offset: 0x0000037B
		internal static void RemovePendingChildrenInvalidation(global::System.Windows.Automation.Peers.AutomationPeer peer)
		{
			if (global::Infragistics.AutomationPeers.AutomationPeerHelper._pendingInvalidationTable != null)
			{
				global::Infragistics.AutomationPeers.AutomationPeerHelper._pendingInvalidationTable.Remove(peer);
			}
		}

		// Token: 0x06000004 RID: 4 RVA: 0x00002190 File Offset: 0x00000390
		private static global::System.Collections.Generic.Dictionary<global::System.Windows.Automation.Peers.AutomationControlType, global::System.Windows.Automation.ControlType> CreateAutomationControlTypeTable()
		{
			global::System.Collections.Generic.Dictionary<global::System.Windows.Automation.Peers.AutomationControlType, global::System.Windows.Automation.ControlType> dictionary = new global::System.Collections.Generic.Dictionary<global::System.Windows.Automation.Peers.AutomationControlType, global::System.Windows.Automation.ControlType>();
			foreach (global::System.Reflection.FieldInfo fieldInfo in typeof(global::System.Windows.Automation.ControlType).GetFields(global::System.Reflection.BindingFlags.Static | global::System.Reflection.BindingFlags.Public))
			{
				if (!(fieldInfo.FieldType != typeof(global::System.Windows.Automation.ControlType)))
				{
					global::System.Windows.Automation.Peers.AutomationControlType key = global::System.Windows.Automation.Peers.AutomationControlType.Button;
					try
					{
						key = (global::System.Windows.Automation.Peers.AutomationControlType)global::System.Enum.Parse(typeof(global::System.Windows.Automation.Peers.AutomationControlType), fieldInfo.Name, true);
					}
					catch (global::System.ArgumentException)
					{
						goto IL_6F;
					}
					dictionary[key] = (global::System.Windows.Automation.ControlType)fieldInfo.GetValue(null);
				}
				IL_6F:;
			}
			return dictionary;
		}

		// Token: 0x06000005 RID: 5 RVA: 0x0000222C File Offset: 0x0000042C
		private static object GetControlTypeId(global::System.Windows.Automation.Peers.AutomationControlType automationControlType)
		{
			global::System.Windows.Automation.ControlType controlType;
			if (!global::Infragistics.AutomationPeers.AutomationPeerHelper._automationControlTypeTable.TryGetValue(automationControlType, out controlType))
			{
				return null;
			}
			return controlType.Id;
		}

		// Token: 0x06000006 RID: 6 RVA: 0x00002258 File Offset: 0x00000458
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

		// Token: 0x04000003 RID: 3
		private static readonly global::System.Collections.Generic.Dictionary<global::System.Windows.Automation.Peers.AutomationControlType, global::System.Windows.Automation.ControlType> _automationControlTypeTable = global::Infragistics.AutomationPeers.AutomationPeerHelper.CreateAutomationControlTypeTable();
	}
}
