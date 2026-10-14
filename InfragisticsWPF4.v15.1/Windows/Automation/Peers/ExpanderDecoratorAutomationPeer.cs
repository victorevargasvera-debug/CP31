using System;
using System.Collections.Generic;
using System.Windows.Automation.Peers;

namespace Infragistics.Windows.Automation.Peers
{
	// Token: 0x020000FF RID: 255
	public class ExpanderDecoratorAutomationPeer : global::System.Windows.Automation.Peers.FrameworkElementAutomationPeer
	{
		// Token: 0x060008FD RID: 2301 RVA: 0x0001F5A3 File Offset: 0x0001D7A3
		public ExpanderDecoratorAutomationPeer(global::Infragistics.Windows.ExpanderDecorator expander) : base(expander)
		{
		}

		// Token: 0x060008FE RID: 2302 RVA: 0x0001F5AC File Offset: 0x0001D7AC
		protected override global::System.Windows.Automation.Peers.AutomationControlType GetAutomationControlTypeCore()
		{
			return global::System.Windows.Automation.Peers.AutomationControlType.Group;
		}

		// Token: 0x060008FF RID: 2303 RVA: 0x0001F5B0 File Offset: 0x0001D7B0
		protected override string GetClassNameCore()
		{
			return "ExpanderDecorator";
		}

		// Token: 0x06000900 RID: 2304 RVA: 0x0001F5B8 File Offset: 0x0001D7B8
		protected override global::System.Collections.Generic.List<global::System.Windows.Automation.Peers.AutomationPeer> GetChildrenCore()
		{
			global::Infragistics.Windows.ExpanderDecorator expanderDecorator = (global::Infragistics.Windows.ExpanderDecorator)base.Owner;
			if (!expanderDecorator.IsExpanded)
			{
				return new global::System.Collections.Generic.List<global::System.Windows.Automation.Peers.AutomationPeer>();
			}
			return base.GetChildrenCore();
		}

		// Token: 0x06000901 RID: 2305 RVA: 0x0001F5E5 File Offset: 0x0001D7E5
		protected override bool IsControlElementCore()
		{
			return false;
		}
	}
}
