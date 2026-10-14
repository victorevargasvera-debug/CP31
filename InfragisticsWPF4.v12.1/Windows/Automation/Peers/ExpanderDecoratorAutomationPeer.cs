using System;
using System.Collections.Generic;
using System.Windows.Automation.Peers;

namespace Infragistics.Windows.Automation.Peers
{
	// Token: 0x020000E1 RID: 225
	public class ExpanderDecoratorAutomationPeer : global::System.Windows.Automation.Peers.FrameworkElementAutomationPeer
	{
		// Token: 0x060007FE RID: 2046 RVA: 0x0001B9DB File Offset: 0x00019BDB
		public ExpanderDecoratorAutomationPeer(global::Infragistics.Windows.ExpanderDecorator expander) : base(expander)
		{
		}

		// Token: 0x060007FF RID: 2047 RVA: 0x0001B9E4 File Offset: 0x00019BE4
		protected override global::System.Windows.Automation.Peers.AutomationControlType GetAutomationControlTypeCore()
		{
			return global::System.Windows.Automation.Peers.AutomationControlType.Group;
		}

		// Token: 0x06000800 RID: 2048 RVA: 0x0001B9E8 File Offset: 0x00019BE8
		protected override string GetClassNameCore()
		{
			return "ExpanderDecorator";
		}

		// Token: 0x06000801 RID: 2049 RVA: 0x0001B9F0 File Offset: 0x00019BF0
		protected override global::System.Collections.Generic.List<global::System.Windows.Automation.Peers.AutomationPeer> GetChildrenCore()
		{
			global::Infragistics.Windows.ExpanderDecorator expanderDecorator = (global::Infragistics.Windows.ExpanderDecorator)base.Owner;
			if (!expanderDecorator.IsExpanded)
			{
				return new global::System.Collections.Generic.List<global::System.Windows.Automation.Peers.AutomationPeer>();
			}
			return base.GetChildrenCore();
		}

		// Token: 0x06000802 RID: 2050 RVA: 0x0001BA1D File Offset: 0x00019C1D
		protected override bool IsControlElementCore()
		{
			return false;
		}
	}
}
