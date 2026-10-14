using System;
using System.Windows.Automation;
using System.Windows.Automation.Peers;
using System.Windows.Automation.Provider;
using Infragistics.Windows.Editors;

namespace Infragistics.Windows.Automation.Peers.Editors
{
	// Token: 0x0200000B RID: 11
	internal class CalendarItemGroupTitleAutomationPeer : global::System.Windows.Automation.Peers.FrameworkElementAutomationPeer, global::System.Windows.Automation.Provider.IInvokeProvider
	{
		// Token: 0x0600003E RID: 62 RVA: 0x00002806 File Offset: 0x00000A06
		public CalendarItemGroupTitleAutomationPeer(global::Infragistics.Windows.Editors.CalendarItemGroupTitle owner) : base(owner)
		{
			this._xamMonthCalendar = global::Infragistics.Windows.Editors.XamMonthCalendar.GetMonthCalendar(owner);
		}

		// Token: 0x0600003F RID: 63 RVA: 0x0000281B File Offset: 0x00000A1B
		protected override global::System.Windows.Automation.Peers.AutomationControlType GetAutomationControlTypeCore()
		{
			return global::System.Windows.Automation.Peers.AutomationControlType.Custom;
		}

		// Token: 0x06000040 RID: 64 RVA: 0x0000281F File Offset: 0x00000A1F
		protected override string GetClassNameCore()
		{
			return "CalendarItemGroupTitle";
		}

		// Token: 0x06000041 RID: 65 RVA: 0x00002826 File Offset: 0x00000A26
		public override object GetPattern(global::System.Windows.Automation.Peers.PatternInterface patternInterface)
		{
			if (patternInterface == global::System.Windows.Automation.Peers.PatternInterface.Invoke)
			{
				return this;
			}
			return base.GetPattern(patternInterface);
		}

		// Token: 0x06000042 RID: 66 RVA: 0x00002834 File Offset: 0x00000A34
		void global::System.Windows.Automation.Provider.IInvokeProvider.Invoke()
		{
			if (!base.IsEnabled())
			{
				throw new global::System.Windows.Automation.ElementNotEnabledException();
			}
			this._xamMonthCalendar.ExecuteCommand(global::Infragistics.Windows.Editors.MonthCalendarCommands.ZoomOutCalendarMode);
		}

		// Token: 0x04000007 RID: 7
		private global::Infragistics.Windows.Editors.XamMonthCalendar _xamMonthCalendar;
	}
}
