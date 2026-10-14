using System;
using System.Collections.Generic;
using System.Windows.Automation.Peers;
using System.Windows.Automation.Provider;
using Infragistics.Controls.Editors;
using Infragistics.Controls.Editors.Primitives;
using Infragistics.Controls.Primitives;

namespace Infragistics.AutomationPeers
{
	// Token: 0x0200000A RID: 10
	public class CalendarItemGroupAutomationPeer : global::Infragistics.AutomationPeers.FrameworkElementAutomationPeerBase, global::System.Windows.Automation.Provider.ISelectionProvider
	{
		// Token: 0x0600003C RID: 60 RVA: 0x0000312B File Offset: 0x0000132B
		public CalendarItemGroupAutomationPeer(global::Infragistics.Controls.Editors.Primitives.CalendarItemGroup owner) : base(owner)
		{
			this._XamCalendar = global::Infragistics.Controls.Editors.CalendarBase.GetCalendar(owner);
		}

		// Token: 0x0600003D RID: 61 RVA: 0x00003140 File Offset: 0x00001340
		protected override global::System.Windows.Automation.Peers.AutomationControlType GetAutomationControlTypeCore()
		{
			return global::System.Windows.Automation.Peers.AutomationControlType.Custom;
		}

		// Token: 0x0600003E RID: 62 RVA: 0x00003144 File Offset: 0x00001344
		protected override string GetClassNameCore()
		{
			return "CalendarItemGroup";
		}

		// Token: 0x0600003F RID: 63 RVA: 0x0000314B File Offset: 0x0000134B
		protected override object GetPatternCore(global::System.Windows.Automation.Peers.PatternInterface patternInterface)
		{
			if (patternInterface == global::System.Windows.Automation.Peers.PatternInterface.Selection)
			{
				return this;
			}
			return base.GetPatternCore(patternInterface);
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000040 RID: 64 RVA: 0x0000315A File Offset: 0x0000135A
		bool global::System.Windows.Automation.Provider.ISelectionProvider.CanSelectMultiple
		{
			get
			{
				return global::Infragistics.Controls.Primitives.SelectionStrategyBase.IsMultiSelectStrategy(this._XamCalendar.CurrentSelectionTypeResolved);
			}
		}

		// Token: 0x06000041 RID: 65 RVA: 0x0000316C File Offset: 0x0000136C
		global::System.Windows.Automation.Provider.IRawElementProviderSimple[] global::System.Windows.Automation.Provider.ISelectionProvider.GetSelection()
		{
			global::Infragistics.Controls.Editors.Primitives.CalendarItemGroup calendarItemGroup = base.Owner as global::Infragistics.Controls.Editors.Primitives.CalendarItemGroup;
			if (calendarItemGroup.Items != null)
			{
				global::System.Collections.Generic.List<global::System.Windows.Automation.Provider.IRawElementProviderSimple> list = new global::System.Collections.Generic.List<global::System.Windows.Automation.Provider.IRawElementProviderSimple>();
				for (int i = 0; i < calendarItemGroup.Items.Count; i++)
				{
					if (calendarItemGroup.Items[i].IsSelected)
					{
						global::Infragistics.Controls.Editors.Primitives.CalendarItem element = calendarItemGroup.Items[i];
						global::System.Windows.Automation.Peers.AutomationPeer peer = global::System.Windows.Automation.Peers.UIElementAutomationPeer.CreatePeerForElement(element);
						list.Add(base.ProviderFromPeer(peer));
					}
				}
				return list.ToArray();
			}
			return null;
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x06000042 RID: 66 RVA: 0x000031E7 File Offset: 0x000013E7
		bool global::System.Windows.Automation.Provider.ISelectionProvider.IsSelectionRequired
		{
			get
			{
				return false;
			}
		}

		// Token: 0x04000017 RID: 23
		private global::Infragistics.Controls.Editors.CalendarBase _XamCalendar;
	}
}
