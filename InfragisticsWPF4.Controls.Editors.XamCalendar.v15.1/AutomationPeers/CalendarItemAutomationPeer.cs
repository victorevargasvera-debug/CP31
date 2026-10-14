using System;
using System.Windows.Automation;
using System.Windows.Automation.Peers;
using System.Windows.Automation.Provider;
using Infragistics.Controls.Editors;
using Infragistics.Controls.Editors.Primitives;

namespace Infragistics.AutomationPeers
{
	// Token: 0x02000009 RID: 9
	public class CalendarItemAutomationPeer : global::Infragistics.AutomationPeers.FrameworkElementAutomationPeerBase, global::System.Windows.Automation.Provider.IInvokeProvider
	{
		// Token: 0x06000037 RID: 55 RVA: 0x000030A9 File Offset: 0x000012A9
		public CalendarItemAutomationPeer(global::Infragistics.Controls.Editors.Primitives.CalendarItem owner) : base(owner)
		{
			this._calendar = global::Infragistics.Controls.Editors.CalendarBase.GetCalendar(owner.Group);
		}

		// Token: 0x06000038 RID: 56 RVA: 0x000030C3 File Offset: 0x000012C3
		protected override global::System.Windows.Automation.Peers.AutomationControlType GetAutomationControlTypeCore()
		{
			return global::System.Windows.Automation.Peers.AutomationControlType.Custom;
		}

		// Token: 0x06000039 RID: 57 RVA: 0x000030C7 File Offset: 0x000012C7
		protected override string GetClassNameCore()
		{
			return "CalendarItem";
		}

		// Token: 0x0600003A RID: 58 RVA: 0x000030CE File Offset: 0x000012CE
		protected override object GetPatternCore(global::System.Windows.Automation.Peers.PatternInterface patternInterface)
		{
			if (patternInterface == global::System.Windows.Automation.Peers.PatternInterface.Invoke)
			{
				return this;
			}
			return base.GetPatternCore(patternInterface);
		}

		// Token: 0x0600003B RID: 59 RVA: 0x000030DC File Offset: 0x000012DC
		void global::System.Windows.Automation.Provider.IInvokeProvider.Invoke()
		{
			if (!base.IsEnabled())
			{
				throw new global::System.Windows.Automation.ElementNotEnabledException();
			}
			global::Infragistics.Controls.Editors.Primitives.CalendarItem sourceElement = base.Owner as global::Infragistics.Controls.Editors.Primitives.CalendarItem;
			if (this._calendar.CurrentMode > this._calendar.MinCalendarModeResolved)
			{
				this._calendar.ExecuteCommand(global::Infragistics.Controls.Editors.CalendarCommandType.ZoomInCalendarMode, null, sourceElement);
			}
		}

		// Token: 0x04000016 RID: 22
		private global::Infragistics.Controls.Editors.CalendarBase _calendar;
	}
}
