using System;
using System.Collections.Generic;
using System.Windows.Automation.Peers;
using System.Windows.Automation.Provider;
using Infragistics.Windows.DockManager;

namespace Infragistics.Windows.Automation.Peers.DockManager
{
	// Token: 0x02000017 RID: 23
	public class XamDockManagerAutomationPeer : global::System.Windows.Automation.Peers.FrameworkElementAutomationPeer, global::System.Windows.Automation.Provider.ISelectionProvider
	{
		// Token: 0x060000B1 RID: 177 RVA: 0x00004CC8 File Offset: 0x00002EC8
		public XamDockManagerAutomationPeer(global::Infragistics.Windows.DockManager.XamDockManager owner) : base(owner)
		{
		}

		// Token: 0x060000B2 RID: 178 RVA: 0x00004CD1 File Offset: 0x00002ED1
		protected override global::System.Windows.Automation.Peers.AutomationControlType GetAutomationControlTypeCore()
		{
			return global::System.Windows.Automation.Peers.AutomationControlType.Custom;
		}

		// Token: 0x060000B3 RID: 179 RVA: 0x00004CD5 File Offset: 0x00002ED5
		protected override string GetClassNameCore()
		{
			return "XamDockManager";
		}

		// Token: 0x060000B4 RID: 180 RVA: 0x00004CDC File Offset: 0x00002EDC
		public override object GetPattern(global::System.Windows.Automation.Peers.PatternInterface patternInterface)
		{
			if (patternInterface == global::System.Windows.Automation.Peers.PatternInterface.Selection)
			{
				return this;
			}
			return base.GetPattern(patternInterface);
		}

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x060000B5 RID: 181 RVA: 0x00004CEB File Offset: 0x00002EEB
		bool global::System.Windows.Automation.Provider.ISelectionProvider.CanSelectMultiple
		{
			get
			{
				return false;
			}
		}

		// Token: 0x060000B6 RID: 182 RVA: 0x00004CF0 File Offset: 0x00002EF0
		global::System.Windows.Automation.Provider.IRawElementProviderSimple[] global::System.Windows.Automation.Provider.ISelectionProvider.GetSelection()
		{
			global::Infragistics.Windows.DockManager.XamDockManager xamDockManager = (global::Infragistics.Windows.DockManager.XamDockManager)base.Owner;
			global::Infragistics.Windows.DockManager.ContentPane activePane = xamDockManager.ActivePane;
			if (activePane != null)
			{
				global::System.Collections.Generic.List<global::System.Windows.Automation.Provider.IRawElementProviderSimple> list = new global::System.Collections.Generic.List<global::System.Windows.Automation.Provider.IRawElementProviderSimple>(1);
				if (activePane != null)
				{
					global::System.Windows.Automation.Peers.AutomationPeer peer = global::System.Windows.Automation.Peers.UIElementAutomationPeer.CreatePeerForElement(activePane);
					list.Add(base.ProviderFromPeer(peer));
				}
				return list.ToArray();
			}
			return null;
		}

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x060000B7 RID: 183 RVA: 0x00004D39 File Offset: 0x00002F39
		bool global::System.Windows.Automation.Provider.ISelectionProvider.IsSelectionRequired
		{
			get
			{
				return false;
			}
		}
	}
}
