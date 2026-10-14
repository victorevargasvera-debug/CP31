using System;
using System.Windows;
using System.Windows.Automation.Peers;
using System.Windows.Controls;

namespace Infragistics.Windows.Automation.Peers
{
	// Token: 0x02000100 RID: 256
	public interface IListAutomationPeer
	{
		// Token: 0x17000171 RID: 369
		// (get) Token: 0x06000902 RID: 2306
		global::System.Windows.UIElement Owner { get; }

		// Token: 0x17000172 RID: 370
		// (get) Token: 0x06000903 RID: 2307
		global::System.Windows.Controls.Panel ItemsControlPanel { get; }

		// Token: 0x06000904 RID: 2308
		global::System.Windows.Automation.Peers.AutomationPeer GetUnderlyingPeer(object item);

		// Token: 0x06000905 RID: 2309
		global::System.Windows.DependencyObject ContainerFromItem(object item);

		// Token: 0x06000906 RID: 2310
		object GetPattern(global::System.Windows.Automation.Peers.PatternInterface patternInterface);
	}
}
