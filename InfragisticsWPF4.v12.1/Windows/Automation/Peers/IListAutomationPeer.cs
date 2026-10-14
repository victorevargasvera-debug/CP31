using System;
using System.Windows;
using System.Windows.Automation.Peers;
using System.Windows.Controls;

namespace Infragistics.Windows.Automation.Peers
{
	// Token: 0x020000E2 RID: 226
	public interface IListAutomationPeer
	{
		// Token: 0x17000159 RID: 345
		// (get) Token: 0x06000803 RID: 2051
		global::System.Windows.UIElement Owner { get; }

		// Token: 0x1700015A RID: 346
		// (get) Token: 0x06000804 RID: 2052
		global::System.Windows.Controls.Panel ItemsControlPanel { get; }

		// Token: 0x06000805 RID: 2053
		global::System.Windows.Automation.Peers.AutomationPeer GetUnderlyingPeer(object item);

		// Token: 0x06000806 RID: 2054
		global::System.Windows.DependencyObject ContainerFromItem(object item);

		// Token: 0x06000807 RID: 2055
		object GetPattern(global::System.Windows.Automation.Peers.PatternInterface patternInterface);
	}
}
