using System;
using System.Collections.Generic;
using System.Windows.Automation.Peers;
using System.Windows.Automation.Provider;
using Infragistics.Windows.Editors;
using Infragistics.Windows.Selection;

namespace Infragistics.Windows.Automation.Peers.Editors
{
	// Token: 0x0200000A RID: 10
	public class CalendarItemGroupAutomationPeer : global::System.Windows.Automation.Peers.FrameworkElementAutomationPeer, global::System.Windows.Automation.Provider.ISelectionProvider
	{
		// Token: 0x06000037 RID: 55 RVA: 0x00002747 File Offset: 0x00000947
		public CalendarItemGroupAutomationPeer(global::Infragistics.Windows.Editors.CalendarItemGroup owner) : base(owner)
		{
			this._xamMonthCalendar = global::Infragistics.Windows.Editors.XamMonthCalendar.GetMonthCalendar(owner);
		}

		// Token: 0x06000038 RID: 56 RVA: 0x0000275C File Offset: 0x0000095C
		protected override global::System.Windows.Automation.Peers.AutomationControlType GetAutomationControlTypeCore()
		{
			return global::System.Windows.Automation.Peers.AutomationControlType.Custom;
		}

		// Token: 0x06000039 RID: 57 RVA: 0x00002760 File Offset: 0x00000960
		protected override string GetClassNameCore()
		{
			return "CalendarItemGroup";
		}

		// Token: 0x0600003A RID: 58 RVA: 0x00002767 File Offset: 0x00000967
		public override object GetPattern(global::System.Windows.Automation.Peers.PatternInterface patternInterface)
		{
			if (patternInterface == global::System.Windows.Automation.Peers.PatternInterface.Selection)
			{
				return this;
			}
			return base.GetPattern(patternInterface);
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x0600003B RID: 59 RVA: 0x00002776 File Offset: 0x00000976
		bool global::System.Windows.Automation.Provider.ISelectionProvider.CanSelectMultiple
		{
			get
			{
				return global::Infragistics.Windows.Selection.SelectionStrategyBase.IsMultiSelectStrategy(this._xamMonthCalendar.SelectionTypeResolved);
			}
		}

		// Token: 0x0600003C RID: 60 RVA: 0x00002788 File Offset: 0x00000988
		global::System.Windows.Automation.Provider.IRawElementProviderSimple[] global::System.Windows.Automation.Provider.ISelectionProvider.GetSelection()
		{
			global::Infragistics.Windows.Editors.CalendarItemGroup calendarItemGroup = base.Owner as global::Infragistics.Windows.Editors.CalendarItemGroup;
			if (calendarItemGroup.Items != null)
			{
				global::System.Collections.Generic.List<global::System.Windows.Automation.Provider.IRawElementProviderSimple> list = new global::System.Collections.Generic.List<global::System.Windows.Automation.Provider.IRawElementProviderSimple>();
				for (int i = 0; i < calendarItemGroup.Items.Count; i++)
				{
					if (calendarItemGroup.Items[i].IsSelected)
					{
						global::Infragistics.Windows.Editors.CalendarItem element = calendarItemGroup.Items[i];
						global::System.Windows.Automation.Peers.AutomationPeer peer = global::System.Windows.Automation.Peers.UIElementAutomationPeer.CreatePeerForElement(element);
						list.Add(base.ProviderFromPeer(peer));
					}
				}
				return list.ToArray();
			}
			return null;
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x0600003D RID: 61 RVA: 0x00002803 File Offset: 0x00000A03
		bool global::System.Windows.Automation.Provider.ISelectionProvider.IsSelectionRequired
		{
			get
			{
				return false;
			}
		}

		// Token: 0x04000006 RID: 6
		private global::Infragistics.Windows.Editors.XamMonthCalendar _xamMonthCalendar;
	}
}
