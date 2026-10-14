using System;
using System.Reflection;
using System.Windows.Automation.Peers;
using System.Windows.Controls;

namespace Infragistics.AutomationPeers
{
	// Token: 0x02000003 RID: 3
	internal static class ItemsControlPeerHelper
	{
		// Token: 0x06000008 RID: 8 RVA: 0x000022D4 File Offset: 0x000004D4
		static ItemsControlPeerHelper()
		{
			global::System.Type typeFromHandle = typeof(global::System.Windows.Automation.Peers.ItemsControlAutomationPeer);
			try
			{
				global::Infragistics.AutomationPeers.ItemsControlPeerHelper._weakRefStorageProp = typeFromHandle.GetProperty("WeakRefElementProxyStorage", global::System.Reflection.BindingFlags.Instance | global::System.Reflection.BindingFlags.Public | global::System.Reflection.BindingFlags.NonPublic);
				if (global::Infragistics.AutomationPeers.ItemsControlPeerHelper._weakRefStorageProp != null)
				{
					global::Infragistics.AutomationPeers.ItemsControlPeerHelper._removeMethod = global::Infragistics.AutomationPeers.ItemsControlPeerHelper._weakRefStorageProp.PropertyType.GetMethod("Remove", new global::System.Type[]
					{
						typeof(object)
					});
				}
				else
				{
					global::Infragistics.AutomationPeers.ItemsControlPeerHelper._removeMethod = null;
				}
				global::Infragistics.AutomationPeers.ItemsControlPeerHelper._canAccessWeakRefStorage = (global::Infragistics.AutomationPeers.ItemsControlPeerHelper._weakRefStorageProp != null && global::Infragistics.AutomationPeers.ItemsControlPeerHelper._removeMethod != null);
			}
			catch
			{
			}
		}

		// Token: 0x06000009 RID: 9 RVA: 0x00002378 File Offset: 0x00000578
		internal static void OnItemRemoved(global::System.Windows.Controls.ItemsControl itemsControl, object item)
		{
			if (global::Infragistics.AutomationPeers.ItemsControlPeerHelper._canAccessWeakRefStorage)
			{
				global::System.Windows.Automation.Peers.ItemsControlAutomationPeer itemsControlAutomationPeer = global::System.Windows.Automation.Peers.UIElementAutomationPeer.FromElement(itemsControl) as global::System.Windows.Automation.Peers.ItemsControlAutomationPeer;
				if (itemsControlAutomationPeer != null)
				{
					try
					{
						object value = global::Infragistics.AutomationPeers.ItemsControlPeerHelper._weakRefStorageProp.GetValue(itemsControlAutomationPeer, null);
						if (value != null)
						{
							global::Infragistics.AutomationPeers.ItemsControlPeerHelper._removeMethod.Invoke(value, new object[]
							{
								item
							});
							global::Infragistics.AutomationPeers.AutomationPeerHelper.InvalidateChildren(itemsControlAutomationPeer);
						}
					}
					catch
					{
						global::Infragistics.AutomationPeers.ItemsControlPeerHelper._canAccessWeakRefStorage = false;
					}
				}
			}
		}

		// Token: 0x04000004 RID: 4
		private static global::System.Reflection.PropertyInfo _weakRefStorageProp;

		// Token: 0x04000005 RID: 5
		private static bool _canAccessWeakRefStorage;

		// Token: 0x04000006 RID: 6
		private static global::System.Reflection.MethodInfo _removeMethod;
	}
}
