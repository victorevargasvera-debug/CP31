using System;
using System.Windows.Automation.Peers;
using Infragistics.Windows.Editors;

namespace Infragistics.Windows.Automation.Peers.Editors
{
	// Token: 0x02000011 RID: 17
	public class XamTextEditorAutomationPeer : global::Infragistics.Windows.Automation.Peers.Editors.ValueEditorAutomationPeer
	{
		// Token: 0x0600008C RID: 140 RVA: 0x00003903 File Offset: 0x00001B03
		public XamTextEditorAutomationPeer(global::Infragistics.Windows.Editors.XamTextEditor owner) : base(owner)
		{
		}

		// Token: 0x0600008D RID: 141 RVA: 0x0000390C File Offset: 0x00001B0C
		protected override global::System.Windows.Automation.Peers.AutomationControlType GetAutomationControlTypeCore()
		{
			return global::System.Windows.Automation.Peers.AutomationControlType.Edit;
		}

		// Token: 0x0600008E RID: 142 RVA: 0x0000390F File Offset: 0x00001B0F
		protected override string GetClassNameCore()
		{
			return "XamTextEditor";
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x0600008F RID: 143 RVA: 0x00003916 File Offset: 0x00001B16
		private global::Infragistics.Windows.Editors.XamTextEditor Editor
		{
			get
			{
				return (global::Infragistics.Windows.Editors.XamTextEditor)base.Owner;
			}
		}
	}
}
