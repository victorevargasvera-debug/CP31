using System;
using System.Windows.Automation.Peers;
using Infragistics.Windows.Editors;

namespace Infragistics.Windows.Automation.Peers.Editors
{
	// Token: 0x02000006 RID: 6
	public class SectionsListAutomationPeer : global::System.Windows.Automation.Peers.FrameworkElementAutomationPeer
	{
		// Token: 0x06000018 RID: 24 RVA: 0x0000243D File Offset: 0x0000063D
		public SectionsListAutomationPeer(global::Infragistics.Windows.Editors.SectionsList owner) : base(owner)
		{
		}

		// Token: 0x06000019 RID: 25 RVA: 0x00002446 File Offset: 0x00000646
		protected override global::System.Windows.Automation.Peers.AutomationControlType GetAutomationControlTypeCore()
		{
			return global::System.Windows.Automation.Peers.AutomationControlType.Edit;
		}

		// Token: 0x0600001A RID: 26 RVA: 0x00002449 File Offset: 0x00000649
		protected override string GetClassNameCore()
		{
			return "SectionsList";
		}

		// Token: 0x0600001B RID: 27 RVA: 0x00002450 File Offset: 0x00000650
		protected override string GetNameCore()
		{
			string nameCore = base.GetNameCore();
			if (string.IsNullOrEmpty(nameCore))
			{
				global::System.Windows.Automation.Peers.AutomationPeer editorPeer = this.EditorPeer;
				if (editorPeer != null)
				{
					return editorPeer.GetName();
				}
			}
			return nameCore ?? string.Empty;
		}

		// Token: 0x0600001C RID: 28 RVA: 0x00002488 File Offset: 0x00000688
		public override object GetPattern(global::System.Windows.Automation.Peers.PatternInterface patternInterface)
		{
			if (patternInterface == global::System.Windows.Automation.Peers.PatternInterface.Text || patternInterface == global::System.Windows.Automation.Peers.PatternInterface.Value)
			{
				global::System.Windows.Automation.Peers.AutomationPeer editorPeer = this.EditorPeer;
				if (editorPeer != null)
				{
					return editorPeer.GetPattern(patternInterface);
				}
			}
			return base.GetPattern(patternInterface);
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x0600001D RID: 29 RVA: 0x000024B8 File Offset: 0x000006B8
		private global::System.Windows.Automation.Peers.AutomationPeer EditorPeer
		{
			get
			{
				global::Infragistics.Windows.Editors.SectionsList sectionsList = base.Owner as global::Infragistics.Windows.Editors.SectionsList;
				global::Infragistics.Windows.Editors.ValueEditor valueEditor = sectionsList.TemplatedParent as global::Infragistics.Windows.Editors.ValueEditor;
				if (valueEditor != null)
				{
					return (valueEditor != null) ? global::System.Windows.Automation.Peers.UIElementAutomationPeer.FromElement(valueEditor) : null;
				}
				return null;
			}
		}
	}
}
