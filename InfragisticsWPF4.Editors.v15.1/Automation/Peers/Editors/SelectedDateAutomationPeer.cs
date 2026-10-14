using System;
using System.Windows.Automation;
using System.Windows.Automation.Peers;
using System.Windows.Automation.Provider;
using Infragistics.AutomationPeers;
using Infragistics.Windows.Editors;

namespace Infragistics.Windows.Automation.Peers.Editors
{
	// Token: 0x0200000C RID: 12
	internal class SelectedDateAutomationPeer : global::Infragistics.AutomationPeers.AutomationPeerProxy, global::System.Windows.Automation.Provider.ISelectionItemProvider
	{
		// Token: 0x06000043 RID: 67 RVA: 0x00002855 File Offset: 0x00000A55
		public SelectedDateAutomationPeer(global::Infragistics.Windows.Editors.XamMonthCalendar xamMonthCalendar, global::System.DateTime dateTime)
		{
			global::Infragistics.Windows.Editors.Utils.ValidateNull("xamMonthCalendar", xamMonthCalendar);
			this._xamMonthCalendar = xamMonthCalendar;
			this._dateTime = dateTime;
		}

		// Token: 0x06000044 RID: 68 RVA: 0x00002876 File Offset: 0x00000A76
		protected override global::System.Windows.Automation.Peers.AutomationControlType GetAutomationControlTypeCore()
		{
			return global::System.Windows.Automation.Peers.AutomationControlType.Custom;
		}

		// Token: 0x06000045 RID: 69 RVA: 0x0000287A File Offset: 0x00000A7A
		protected override string GetClassNameCore()
		{
			return "DateTime";
		}

		// Token: 0x06000046 RID: 70 RVA: 0x00002884 File Offset: 0x00000A84
		protected override string GetNameCore()
		{
			string text = base.GetNameCore();
			if (string.IsNullOrEmpty(text))
			{
				text = this._dateTime.ToString("d");
			}
			return text;
		}

		// Token: 0x06000047 RID: 71 RVA: 0x000028B2 File Offset: 0x00000AB2
		public override object GetPattern(global::System.Windows.Automation.Peers.PatternInterface patternInterface)
		{
			if (patternInterface == global::System.Windows.Automation.Peers.PatternInterface.SelectionItem)
			{
				return this;
			}
			return base.GetPattern(patternInterface);
		}

		// Token: 0x06000048 RID: 72 RVA: 0x000028C4 File Offset: 0x00000AC4
		protected override global::System.Windows.Automation.Peers.AutomationPeer GetUnderlyingPeer()
		{
			global::System.Windows.Automation.Peers.AutomationPeer result = null;
			if (this._xamMonthCalendar.IsMinCalendarMode)
			{
				global::Infragistics.Windows.Editors.CalendarItem item = this._xamMonthCalendar.GetItem(this._dateTime);
				if (item != null)
				{
					result = global::System.Windows.Automation.Peers.UIElementAutomationPeer.CreatePeerForElement(item);
				}
			}
			return result;
		}

		// Token: 0x06000049 RID: 73 RVA: 0x00002900 File Offset: 0x00000B00
		protected override bool IsEnabledCore()
		{
			global::System.Windows.Automation.Peers.AutomationPeer underlyingPeer = this.GetUnderlyingPeer();
			return underlyingPeer == null || underlyingPeer.IsEnabled();
		}

		// Token: 0x0600004A RID: 74 RVA: 0x0000291F File Offset: 0x00000B1F
		void global::System.Windows.Automation.Provider.ISelectionItemProvider.AddToSelection()
		{
			if (!base.IsEnabled())
			{
				throw new global::System.Windows.Automation.ElementNotEnabledException();
			}
			if (!this._xamMonthCalendar.SelectedDates.Contains(this._dateTime))
			{
				this._xamMonthCalendar.SelectedDates.Add(this._dateTime);
			}
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x0600004B RID: 75 RVA: 0x0000295D File Offset: 0x00000B5D
		bool global::System.Windows.Automation.Provider.ISelectionItemProvider.IsSelected
		{
			get
			{
				return this._xamMonthCalendar.SelectedDates.Contains(this._dateTime);
			}
		}

		// Token: 0x0600004C RID: 76 RVA: 0x00002975 File Offset: 0x00000B75
		void global::System.Windows.Automation.Provider.ISelectionItemProvider.RemoveFromSelection()
		{
			if (!base.IsEnabled())
			{
				throw new global::System.Windows.Automation.ElementNotEnabledException();
			}
			this._xamMonthCalendar.SelectedDates.Remove(this._dateTime);
		}

		// Token: 0x0600004D RID: 77 RVA: 0x0000299C File Offset: 0x00000B9C
		void global::System.Windows.Automation.Provider.ISelectionItemProvider.Select()
		{
			if (!base.IsEnabled())
			{
				throw new global::System.Windows.Automation.ElementNotEnabledException();
			}
			this._xamMonthCalendar.SelectedDate = new global::System.DateTime?(this._dateTime);
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x0600004E RID: 78 RVA: 0x000029C4 File Offset: 0x00000BC4
		global::System.Windows.Automation.Provider.IRawElementProviderSimple global::System.Windows.Automation.Provider.ISelectionItemProvider.SelectionContainer
		{
			get
			{
				global::System.Windows.Automation.Peers.AutomationPeer automationPeer = global::System.Windows.Automation.Peers.UIElementAutomationPeer.CreatePeerForElement(this._xamMonthCalendar);
				if (automationPeer == null)
				{
					return null;
				}
				return base.ProviderFromPeer(automationPeer);
			}
		}

		// Token: 0x04000008 RID: 8
		private global::Infragistics.Windows.Editors.XamMonthCalendar _xamMonthCalendar;

		// Token: 0x04000009 RID: 9
		private global::System.DateTime _dateTime;
	}
}
