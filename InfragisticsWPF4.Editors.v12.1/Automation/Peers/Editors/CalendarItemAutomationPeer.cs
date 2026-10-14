using System;
using System.Windows.Automation;
using System.Windows.Automation.Peers;
using System.Windows.Automation.Provider;
using Infragistics.Windows.Editors;

namespace Infragistics.Windows.Automation.Peers.Editors
{
	// Token: 0x02000009 RID: 9
	public class CalendarItemAutomationPeer : global::System.Windows.Automation.Peers.FrameworkElementAutomationPeer, global::System.Windows.Automation.Provider.IInvokeProvider
	{
		// Token: 0x06000032 RID: 50 RVA: 0x000026C8 File Offset: 0x000008C8
		public CalendarItemAutomationPeer(global::Infragistics.Windows.Editors.CalendarItem owner) : base(owner)
		{
			this._xamMonthCalendar = global::Infragistics.Windows.Editors.XamMonthCalendar.GetMonthCalendar(owner.Group);
		}

		// Token: 0x06000033 RID: 51 RVA: 0x000026E2 File Offset: 0x000008E2
		protected override global::System.Windows.Automation.Peers.AutomationControlType GetAutomationControlTypeCore()
		{
			return global::System.Windows.Automation.Peers.AutomationControlType.Custom;
		}

		// Token: 0x06000034 RID: 52 RVA: 0x000026E6 File Offset: 0x000008E6
		protected override string GetClassNameCore()
		{
			return "CalendarItem";
		}

		// Token: 0x06000035 RID: 53 RVA: 0x000026ED File Offset: 0x000008ED
		public override object GetPattern(global::System.Windows.Automation.Peers.PatternInterface patternInterface)
		{
			if (patternInterface == global::System.Windows.Automation.Peers.PatternInterface.Invoke)
			{
				return this;
			}
			return base.GetPattern(patternInterface);
		}

		// Token: 0x06000036 RID: 54 RVA: 0x000026FC File Offset: 0x000008FC
		void global::System.Windows.Automation.Provider.IInvokeProvider.Invoke()
		{
			if (!base.IsEnabled())
			{
				throw new global::System.Windows.Automation.ElementNotEnabledException();
			}
			global::Infragistics.Windows.Editors.CalendarItem target = base.Owner as global::Infragistics.Windows.Editors.CalendarItem;
			if (this._xamMonthCalendar.CurrentCalendarMode > this._xamMonthCalendar.MinCalendarMode)
			{
				global::Infragistics.Windows.Editors.MonthCalendarCommands.ZoomInCalendarMode.Execute(null, target);
			}
		}

		// Token: 0x04000005 RID: 5
		private global::Infragistics.Windows.Editors.XamMonthCalendar _xamMonthCalendar;
	}
}
