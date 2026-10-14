using System;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Automation.Peers;
using System.Windows.Automation.Provider;
using Infragistics.Controls.Editors;
using Infragistics.Controls.Editors.Primitives;

namespace Infragistics.AutomationPeers
{
	// Token: 0x0200000B RID: 11
	internal class CalendarItemGroupTitleAutomationPeer : global::Infragistics.AutomationPeers.FrameworkElementAutomationPeerBase, global::System.Windows.Automation.Provider.IInvokeProvider
	{
		// Token: 0x06000043 RID: 67 RVA: 0x000031EA File Offset: 0x000013EA
		public CalendarItemGroupTitleAutomationPeer(global::Infragistics.Controls.Editors.Primitives.CalendarItemGroupTitle owner) : base(owner)
		{
			this._calendar = global::Infragistics.Controls.Editors.CalendarBase.GetCalendar(owner);
		}

		// Token: 0x06000044 RID: 68 RVA: 0x000031FF File Offset: 0x000013FF
		protected override global::System.Windows.Automation.Peers.AutomationControlType GetAutomationControlTypeCore()
		{
			return global::System.Windows.Automation.Peers.AutomationControlType.Custom;
		}

		// Token: 0x06000045 RID: 69 RVA: 0x00003203 File Offset: 0x00001403
		protected override string GetClassNameCore()
		{
			return "CalendarItemGroupTitle";
		}

		// Token: 0x06000046 RID: 70 RVA: 0x0000320A File Offset: 0x0000140A
		protected override object GetPatternCore(global::System.Windows.Automation.Peers.PatternInterface patternInterface)
		{
			if (patternInterface == global::System.Windows.Automation.Peers.PatternInterface.Invoke)
			{
				return this;
			}
			return base.GetPatternCore(patternInterface);
		}

		// Token: 0x06000047 RID: 71 RVA: 0x00003218 File Offset: 0x00001418
		void global::System.Windows.Automation.Provider.IInvokeProvider.Invoke()
		{
			if (!base.IsEnabled())
			{
				throw new global::System.Windows.Automation.ElementNotEnabledException();
			}
			this._calendar.ExecuteCommand(global::Infragistics.Controls.Editors.CalendarCommandType.ZoomOutCalendarMode, null, base.Owner as global::System.Windows.FrameworkElement);
		}

		// Token: 0x04000018 RID: 24
		private global::Infragistics.Controls.Editors.CalendarBase _calendar;
	}
}
