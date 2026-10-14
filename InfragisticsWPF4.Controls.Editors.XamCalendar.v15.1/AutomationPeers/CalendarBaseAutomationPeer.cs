using System;
using System.Collections.Generic;
using System.Windows.Automation.Peers;
using System.Windows.Automation.Provider;
using Infragistics.Collections;
using Infragistics.Controls.Editors;
using Infragistics.Controls.Primitives;

namespace Infragistics.AutomationPeers
{
	// Token: 0x0200000D RID: 13
	public class CalendarBaseAutomationPeer : global::Infragistics.AutomationPeers.FrameworkElementAutomationPeerBase, global::System.Windows.Automation.Provider.ISelectionProvider, global::System.Windows.Automation.Provider.IMultipleViewProvider
	{
		// Token: 0x06000055 RID: 85 RVA: 0x000033E1 File Offset: 0x000015E1
		public CalendarBaseAutomationPeer(global::Infragistics.Controls.Editors.CalendarBase owner) : base(owner)
		{
		}

		// Token: 0x06000056 RID: 86 RVA: 0x000033EA File Offset: 0x000015EA
		protected override global::System.Windows.Automation.Peers.AutomationControlType GetAutomationControlTypeCore()
		{
			return global::System.Windows.Automation.Peers.AutomationControlType.Calendar;
		}

		// Token: 0x06000057 RID: 87 RVA: 0x000033ED File Offset: 0x000015ED
		protected override string GetClassNameCore()
		{
			return "CalendarBase";
		}

		// Token: 0x06000058 RID: 88 RVA: 0x000033F4 File Offset: 0x000015F4
		protected override object GetPatternCore(global::System.Windows.Automation.Peers.PatternInterface patternInterface)
		{
			if (patternInterface == global::System.Windows.Automation.Peers.PatternInterface.Selection)
			{
				return this;
			}
			return base.GetPatternCore(patternInterface);
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x06000059 RID: 89 RVA: 0x00003404 File Offset: 0x00001604
		bool global::System.Windows.Automation.Provider.ISelectionProvider.CanSelectMultiple
		{
			get
			{
				global::Infragistics.Controls.Editors.CalendarBase calendarBase = base.Owner as global::Infragistics.Controls.Editors.CalendarBase;
				return global::Infragistics.Controls.Primitives.SelectionStrategyBase.IsMultiSelectStrategy(calendarBase.CurrentSelectionTypeResolved);
			}
		}

		// Token: 0x0600005A RID: 90 RVA: 0x00003428 File Offset: 0x00001628
		global::System.Windows.Automation.Provider.IRawElementProviderSimple[] global::System.Windows.Automation.Provider.ISelectionProvider.GetSelection()
		{
			global::Infragistics.Controls.Editors.CalendarBase calendarBase = base.Owner as global::Infragistics.Controls.Editors.CalendarBase;
			global::Infragistics.Collections.DateCollection selectedDates = calendarBase.SelectedDates;
			if (selectedDates != null)
			{
				global::System.Collections.Generic.List<global::System.Windows.Automation.Provider.IRawElementProviderSimple> list = new global::System.Collections.Generic.List<global::System.Windows.Automation.Provider.IRawElementProviderSimple>(selectedDates.Count);
				for (int i = 0; i < selectedDates.Count; i++)
				{
					global::System.DateTime dateTime = selectedDates[i];
					global::Infragistics.AutomationPeers.SelectedDateAutomationPeer peer = new global::Infragistics.AutomationPeers.SelectedDateAutomationPeer(calendarBase, dateTime);
					list[i] = base.ProviderFromPeer(peer);
				}
				return list.ToArray();
			}
			return null;
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x0600005B RID: 91 RVA: 0x00003492 File Offset: 0x00001692
		bool global::System.Windows.Automation.Provider.ISelectionProvider.IsSelectionRequired
		{
			get
			{
				return false;
			}
		}

		// Token: 0x0600005C RID: 92 RVA: 0x00003498 File Offset: 0x00001698
		private static global::Infragistics.Controls.Editors.CalendarZoomMode GetMode(int viewId)
		{
			global::Infragistics.Controls.Editors.CalendarZoomMode calendarZoomMode = (global::Infragistics.Controls.Editors.CalendarZoomMode)viewId;
			if (!global::System.Enum.IsDefined(typeof(global::Infragistics.Controls.Editors.CalendarZoomMode), calendarZoomMode))
			{
				throw new global::System.ArgumentException(global::Infragistics.Controls.Editors.CalendarBase.GetString("LE_InvalidViewId"));
			}
			return calendarZoomMode;
		}

		// Token: 0x0600005D RID: 93 RVA: 0x000034D0 File Offset: 0x000016D0
		int[] global::System.Windows.Automation.Provider.IMultipleViewProvider.GetSupportedViews()
		{
			global::Infragistics.Controls.Editors.CalendarBase calendarBase = (global::Infragistics.Controls.Editors.CalendarBase)base.Owner;
			global::System.Collections.Generic.List<int> list = new global::System.Collections.Generic.List<int>();
			foreach (global::Infragistics.Controls.Editors.CalendarZoomMode calendarZoomMode in global::Infragistics.Controls.Editors.CalendarUtilities.GetEnumValues<global::Infragistics.Controls.Editors.CalendarZoomMode>())
			{
				if (calendarZoomMode >= calendarBase.MinCalendarModeResolved && calendarZoomMode <= calendarBase.MaxCalendarMode)
				{
					list.Add((int)calendarZoomMode);
				}
			}
			return list.ToArray();
		}

		// Token: 0x0600005E RID: 94 RVA: 0x0000354C File Offset: 0x0000174C
		string global::System.Windows.Automation.Provider.IMultipleViewProvider.GetViewName(int viewId)
		{
			return global::Infragistics.AutomationPeers.CalendarBaseAutomationPeer.GetMode(viewId).ToString();
		}

		// Token: 0x0600005F RID: 95 RVA: 0x00003560 File Offset: 0x00001760
		void global::System.Windows.Automation.Provider.IMultipleViewProvider.SetCurrentView(int viewId)
		{
			global::Infragistics.Controls.Editors.CalendarBase calendarBase = (global::Infragistics.Controls.Editors.CalendarBase)base.Owner;
			global::Infragistics.Controls.Editors.CalendarZoomMode mode = global::Infragistics.AutomationPeers.CalendarBaseAutomationPeer.GetMode(viewId);
			if (mode < calendarBase.MinCalendarModeResolved)
			{
				throw new global::System.InvalidOperationException(global::Infragistics.Controls.Editors.CalendarBase.GetString("LE_CannotSetMode", new object[]
				{
					mode
				}));
			}
			if (mode > calendarBase.MaxCalendarMode)
			{
				throw new global::System.InvalidOperationException();
			}
			calendarBase.CurrentMode = mode;
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x06000060 RID: 96 RVA: 0x000035C0 File Offset: 0x000017C0
		int global::System.Windows.Automation.Provider.IMultipleViewProvider.CurrentView
		{
			get
			{
				global::Infragistics.Controls.Editors.CalendarBase calendarBase = (global::Infragistics.Controls.Editors.CalendarBase)base.Owner;
				return (int)calendarBase.CurrentMode;
			}
		}
	}
}
