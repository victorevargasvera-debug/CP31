using System;
using System.Windows.Automation;
using System.Windows.Automation.Peers;
using System.Windows.Automation.Provider;
using Infragistics.Controls.Primitives;

namespace Infragistics.AutomationPeers
{
	// Token: 0x020000DA RID: 218
	public class ExpansionIndicatorAutomationPeer : global::System.Windows.Automation.Peers.FrameworkElementAutomationPeer, global::System.Windows.Automation.Provider.IToggleProvider
	{
		// Token: 0x060007FB RID: 2043 RVA: 0x0001C58D File Offset: 0x0001A78D
		public ExpansionIndicatorAutomationPeer(global::Infragistics.Controls.Primitives.ExpansionIndicator owner) : base(owner)
		{
		}

		// Token: 0x060007FC RID: 2044 RVA: 0x0001C596 File Offset: 0x0001A796
		protected override global::System.Windows.Automation.Peers.AutomationControlType GetAutomationControlTypeCore()
		{
			return global::System.Windows.Automation.Peers.AutomationControlType.CheckBox;
		}

		// Token: 0x060007FD RID: 2045 RVA: 0x0001C599 File Offset: 0x0001A799
		protected override string GetClassNameCore()
		{
			return "ExpansionIndicator";
		}

		// Token: 0x060007FE RID: 2046 RVA: 0x0001C5A0 File Offset: 0x0001A7A0
		public override object GetPattern(global::System.Windows.Automation.Peers.PatternInterface patternInterface)
		{
			if (patternInterface == global::System.Windows.Automation.Peers.PatternInterface.Toggle)
			{
				return this;
			}
			return base.GetPattern(patternInterface);
		}

		// Token: 0x060007FF RID: 2047 RVA: 0x0001C5B0 File Offset: 0x0001A7B0
		public void Toggle()
		{
			global::Infragistics.Controls.Primitives.ExpansionIndicator expansionIndicator = base.Owner as global::Infragistics.Controls.Primitives.ExpansionIndicator;
			if (expansionIndicator == null)
			{
				throw new global::System.InvalidOperationException();
			}
			if (!expansionIndicator.IsEnabled)
			{
				throw new global::System.Windows.Automation.ElementNotEnabledException();
			}
			expansionIndicator.IsExpanded = !expansionIndicator.IsExpanded;
		}

		// Token: 0x17000146 RID: 326
		// (get) Token: 0x06000800 RID: 2048 RVA: 0x0001C5F0 File Offset: 0x0001A7F0
		public global::System.Windows.Automation.ToggleState ToggleState
		{
			get
			{
				global::Infragistics.Controls.Primitives.ExpansionIndicator expansionIndicator = base.Owner as global::Infragistics.Controls.Primitives.ExpansionIndicator;
				if (expansionIndicator == null)
				{
					throw new global::System.InvalidOperationException();
				}
				if (expansionIndicator.IsExpanded)
				{
					return global::System.Windows.Automation.ToggleState.On;
				}
				return global::System.Windows.Automation.ToggleState.Off;
			}
		}
	}
}
