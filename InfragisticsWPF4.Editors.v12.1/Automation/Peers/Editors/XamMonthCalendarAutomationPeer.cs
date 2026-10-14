using System;
using System.Collections.Generic;
using System.Windows.Automation.Peers;
using System.Windows.Automation.Provider;
using Infragistics.Windows.Editors;
using Infragistics.Windows.Selection;

namespace Infragistics.Windows.Automation.Peers.Editors
{
	// Token: 0x02000010 RID: 16
	public class XamMonthCalendarAutomationPeer : global::System.Windows.Automation.Peers.FrameworkElementAutomationPeer, global::System.Windows.Automation.Provider.ISelectionProvider, global::System.Windows.Automation.Provider.IMultipleViewProvider
	{
		// Token: 0x06000080 RID: 128 RVA: 0x000036EF File Offset: 0x000018EF
		public XamMonthCalendarAutomationPeer(global::Infragistics.Windows.Editors.XamMonthCalendar owner) : base(owner)
		{
		}

		// Token: 0x06000081 RID: 129 RVA: 0x000036F8 File Offset: 0x000018F8
		protected override global::System.Windows.Automation.Peers.AutomationControlType GetAutomationControlTypeCore()
		{
			return global::System.Windows.Automation.Peers.AutomationControlType.Calendar;
		}

		// Token: 0x06000082 RID: 130 RVA: 0x000036FB File Offset: 0x000018FB
		protected override string GetClassNameCore()
		{
			return "XamMonthCalendar";
		}

		// Token: 0x06000083 RID: 131 RVA: 0x00003702 File Offset: 0x00001902
		public override object GetPattern(global::System.Windows.Automation.Peers.PatternInterface patternInterface)
		{
			if (patternInterface == global::System.Windows.Automation.Peers.PatternInterface.Selection)
			{
				return this;
			}
			return base.GetPattern(patternInterface);
		}

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x06000084 RID: 132 RVA: 0x00003714 File Offset: 0x00001914
		bool global::System.Windows.Automation.Provider.ISelectionProvider.CanSelectMultiple
		{
			get
			{
				global::Infragistics.Windows.Editors.XamMonthCalendar xamMonthCalendar = base.Owner as global::Infragistics.Windows.Editors.XamMonthCalendar;
				return global::Infragistics.Windows.Selection.SelectionStrategyBase.IsMultiSelectStrategy(xamMonthCalendar.SelectionTypeResolved);
			}
		}

		// Token: 0x06000085 RID: 133 RVA: 0x00003738 File Offset: 0x00001938
		global::System.Windows.Automation.Provider.IRawElementProviderSimple[] global::System.Windows.Automation.Provider.ISelectionProvider.GetSelection()
		{
			global::Infragistics.Windows.Editors.XamMonthCalendar xamMonthCalendar = base.Owner as global::Infragistics.Windows.Editors.XamMonthCalendar;
			global::Infragistics.Windows.Editors.SelectedDateCollection selectedDates = xamMonthCalendar.SelectedDates;
			if (selectedDates != null)
			{
				global::System.Collections.Generic.List<global::System.Windows.Automation.Provider.IRawElementProviderSimple> list = new global::System.Collections.Generic.List<global::System.Windows.Automation.Provider.IRawElementProviderSimple>(selectedDates.Count);
				for (int i = 0; i < selectedDates.Count; i++)
				{
					global::System.DateTime dateTime = selectedDates[i];
					global::Infragistics.Windows.Automation.Peers.Editors.SelectedDateAutomationPeer peer = new global::Infragistics.Windows.Automation.Peers.Editors.SelectedDateAutomationPeer(xamMonthCalendar, dateTime);
					list[i] = base.ProviderFromPeer(peer);
				}
				return list.ToArray();
			}
			return null;
		}

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x06000086 RID: 134 RVA: 0x000037A2 File Offset: 0x000019A2
		bool global::System.Windows.Automation.Provider.ISelectionProvider.IsSelectionRequired
		{
			get
			{
				return false;
			}
		}

		// Token: 0x06000087 RID: 135 RVA: 0x000037A8 File Offset: 0x000019A8
		private static global::Infragistics.Windows.Editors.CalendarMode GetMode(int viewId)
		{
			global::Infragistics.Windows.Editors.CalendarMode calendarMode = (global::Infragistics.Windows.Editors.CalendarMode)viewId;
			if (!global::System.Enum.IsDefined(typeof(global::Infragistics.Windows.Editors.CalendarMode), calendarMode))
			{
				throw new global::System.ArgumentException(global::Infragistics.Windows.Editors.XamMonthCalendar.GetString("LE_InvalidViewId"));
			}
			return calendarMode;
		}

		// Token: 0x06000088 RID: 136 RVA: 0x000037E0 File Offset: 0x000019E0
		int[] global::System.Windows.Automation.Provider.IMultipleViewProvider.GetSupportedViews()
		{
			global::System.Collections.Generic.List<int> list = new global::System.Collections.Generic.List<int>();
			foreach (object obj in global::System.Enum.GetValues(typeof(global::Infragistics.Windows.Editors.CalendarMode)))
			{
				global::Infragistics.Windows.Editors.CalendarMode calendarMode = (global::Infragistics.Windows.Editors.CalendarMode)obj;
				global::Infragistics.Windows.Editors.XamMonthCalendar xamMonthCalendar = (global::Infragistics.Windows.Editors.XamMonthCalendar)base.Owner;
				if (calendarMode >= xamMonthCalendar.MinCalendarMode && calendarMode <= xamMonthCalendar.MaxCalendarMode)
				{
					list.Add((int)calendarMode);
				}
			}
			return list.ToArray();
		}

		// Token: 0x06000089 RID: 137 RVA: 0x00003870 File Offset: 0x00001A70
		string global::System.Windows.Automation.Provider.IMultipleViewProvider.GetViewName(int viewId)
		{
			return global::Infragistics.Windows.Automation.Peers.Editors.XamMonthCalendarAutomationPeer.GetMode(viewId).ToString();
		}

		// Token: 0x0600008A RID: 138 RVA: 0x00003884 File Offset: 0x00001A84
		void global::System.Windows.Automation.Provider.IMultipleViewProvider.SetCurrentView(int viewId)
		{
			global::Infragistics.Windows.Editors.XamMonthCalendar xamMonthCalendar = (global::Infragistics.Windows.Editors.XamMonthCalendar)base.Owner;
			global::Infragistics.Windows.Editors.CalendarMode mode = global::Infragistics.Windows.Automation.Peers.Editors.XamMonthCalendarAutomationPeer.GetMode(viewId);
			if (mode < xamMonthCalendar.MinCalendarMode)
			{
				throw new global::System.InvalidOperationException(global::Infragistics.Windows.Editors.XamMonthCalendar.GetString("LE_CannotSetMode", new object[]
				{
					mode
				}));
			}
			if (mode > xamMonthCalendar.MaxCalendarMode)
			{
				throw new global::System.InvalidOperationException();
			}
			xamMonthCalendar.CurrentCalendarMode = mode;
		}

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x0600008B RID: 139 RVA: 0x000038E4 File Offset: 0x00001AE4
		int global::System.Windows.Automation.Provider.IMultipleViewProvider.CurrentView
		{
			get
			{
				global::Infragistics.Windows.Editors.XamMonthCalendar xamMonthCalendar = (global::Infragistics.Windows.Editors.XamMonthCalendar)base.Owner;
				return (int)xamMonthCalendar.CurrentCalendarMode;
			}
		}
	}
}
