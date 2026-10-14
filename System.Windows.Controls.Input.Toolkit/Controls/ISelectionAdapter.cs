using System;
using System.Collections;
using System.Windows.Automation.Peers;
using System.Windows.Input;

namespace System.Windows.Controls
{
	// Token: 0x02000003 RID: 3
	public interface ISelectionAdapter
	{
		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000002 RID: 2
		// (set) Token: 0x06000003 RID: 3
		object SelectedItem { get; set; }

		// Token: 0x14000001 RID: 1
		// (add) Token: 0x06000004 RID: 4
		// (remove) Token: 0x06000005 RID: 5
		event global::System.Windows.Controls.SelectionChangedEventHandler SelectionChanged;

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000006 RID: 6
		// (set) Token: 0x06000007 RID: 7
		global::System.Collections.IEnumerable ItemsSource { get; set; }

		// Token: 0x14000002 RID: 2
		// (add) Token: 0x06000008 RID: 8
		// (remove) Token: 0x06000009 RID: 9
		event global::System.Windows.RoutedEventHandler Commit;

		// Token: 0x14000003 RID: 3
		// (add) Token: 0x0600000A RID: 10
		// (remove) Token: 0x0600000B RID: 11
		event global::System.Windows.RoutedEventHandler Cancel;

		// Token: 0x0600000C RID: 12
		void HandleKeyDown(global::System.Windows.Input.KeyEventArgs e);

		// Token: 0x0600000D RID: 13
		global::System.Windows.Automation.Peers.AutomationPeer CreateAutomationPeer();
	}
}
