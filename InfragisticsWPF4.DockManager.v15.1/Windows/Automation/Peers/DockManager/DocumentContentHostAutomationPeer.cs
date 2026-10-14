using System;
using System.Collections.Generic;
using System.Windows.Automation.Peers;
using System.Windows.Automation.Provider;
using Infragistics.Windows.DockManager;

namespace Infragistics.Windows.Automation.Peers.DockManager
{
	// Token: 0x02000011 RID: 17
	public class DocumentContentHostAutomationPeer : global::System.Windows.Automation.Peers.FrameworkElementAutomationPeer, global::System.Windows.Automation.Provider.ISelectionProvider
	{
		// Token: 0x0600009E RID: 158 RVA: 0x00004A47 File Offset: 0x00002C47
		public DocumentContentHostAutomationPeer(global::Infragistics.Windows.DockManager.DocumentContentHost owner) : base(owner)
		{
		}

		// Token: 0x0600009F RID: 159 RVA: 0x00004A50 File Offset: 0x00002C50
		protected override global::System.Windows.Automation.Peers.AutomationControlType GetAutomationControlTypeCore()
		{
			return global::System.Windows.Automation.Peers.AutomationControlType.Custom;
		}

		// Token: 0x060000A0 RID: 160 RVA: 0x00004A54 File Offset: 0x00002C54
		protected override string GetClassNameCore()
		{
			return "DocumentContentHost";
		}

		// Token: 0x060000A1 RID: 161 RVA: 0x00004A5B File Offset: 0x00002C5B
		public override object GetPattern(global::System.Windows.Automation.Peers.PatternInterface patternInterface)
		{
			if (patternInterface == global::System.Windows.Automation.Peers.PatternInterface.Selection)
			{
				return this;
			}
			return base.GetPattern(patternInterface);
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x060000A2 RID: 162 RVA: 0x00004A6A File Offset: 0x00002C6A
		bool global::System.Windows.Automation.Provider.ISelectionProvider.CanSelectMultiple
		{
			get
			{
				return false;
			}
		}

		// Token: 0x060000A3 RID: 163 RVA: 0x00004A70 File Offset: 0x00002C70
		global::System.Windows.Automation.Provider.IRawElementProviderSimple[] global::System.Windows.Automation.Provider.ISelectionProvider.GetSelection()
		{
			global::Infragistics.Windows.DockManager.DocumentContentHost documentContentHost = (global::Infragistics.Windows.DockManager.DocumentContentHost)base.Owner;
			global::Infragistics.Windows.DockManager.ContentPane activeDocument = documentContentHost.ActiveDocument;
			if (activeDocument != null)
			{
				global::System.Collections.Generic.List<global::System.Windows.Automation.Provider.IRawElementProviderSimple> list = new global::System.Collections.Generic.List<global::System.Windows.Automation.Provider.IRawElementProviderSimple>(1);
				if (activeDocument != null)
				{
					global::System.Windows.Automation.Peers.AutomationPeer peer = global::System.Windows.Automation.Peers.UIElementAutomationPeer.CreatePeerForElement(activeDocument);
					list.Add(base.ProviderFromPeer(peer));
				}
				return list.ToArray();
			}
			return null;
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x060000A4 RID: 164 RVA: 0x00004AB9 File Offset: 0x00002CB9
		bool global::System.Windows.Automation.Provider.ISelectionProvider.IsSelectionRequired
		{
			get
			{
				return false;
			}
		}
	}
}
