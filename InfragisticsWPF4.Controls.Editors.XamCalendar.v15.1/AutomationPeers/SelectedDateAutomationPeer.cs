using System;
using System.Windows.Automation;
using System.Windows.Automation.Peers;
using System.Windows.Automation.Provider;
using Infragistics.Controls.Editors;
using Infragistics.Controls.Editors.Primitives;

namespace Infragistics.AutomationPeers
{
	// Token: 0x0200000C RID: 12
	internal class SelectedDateAutomationPeer : global::Infragistics.AutomationPeers.PeerProxy, global::System.Windows.Automation.Provider.ISelectionItemProvider
	{
		// Token: 0x06000048 RID: 72 RVA: 0x00003242 File Offset: 0x00001442
		public SelectedDateAutomationPeer(global::Infragistics.Controls.Editors.CalendarBase CalendarBase, global::System.DateTime dateTime)
		{
			global::Infragistics.Controls.Editors.CalendarUtilities.ValidateNull("CalendarBase", CalendarBase);
			this._XamCalendar = CalendarBase;
			this._dateTime = dateTime;
		}

		// Token: 0x06000049 RID: 73 RVA: 0x00003263 File Offset: 0x00001463
		protected override global::System.Windows.Automation.Peers.AutomationControlType GetAutomationControlTypeCore()
		{
			return global::System.Windows.Automation.Peers.AutomationControlType.Custom;
		}

		// Token: 0x0600004A RID: 74 RVA: 0x00003267 File Offset: 0x00001467
		protected override string GetClassNameCore()
		{
			return "DateTime";
		}

		// Token: 0x0600004B RID: 75 RVA: 0x0000326E File Offset: 0x0000146E
		protected override string GetLocalizedControlTypeCore()
		{
			return global::Infragistics.Controls.Editors.CalendarUtilities.GetString("SelectedDate_AutomationType");
		}

		// Token: 0x0600004C RID: 76 RVA: 0x0000327C File Offset: 0x0000147C
		protected override string GetNameCore()
		{
			string text = base.GetNameCore();
			if (string.IsNullOrEmpty(text))
			{
				text = this._dateTime.ToString("d");
			}
			return text;
		}

		// Token: 0x0600004D RID: 77 RVA: 0x000032AA File Offset: 0x000014AA
		public override object GetPattern(global::System.Windows.Automation.Peers.PatternInterface patternInterface)
		{
			if (patternInterface == global::System.Windows.Automation.Peers.PatternInterface.SelectionItem)
			{
				return this;
			}
			return base.GetPattern(patternInterface);
		}

		// Token: 0x0600004E RID: 78 RVA: 0x000032BC File Offset: 0x000014BC
		protected override global::System.Windows.Automation.Peers.AutomationPeer GetUnderlyingPeer()
		{
			global::System.Windows.Automation.Peers.AutomationPeer result = null;
			if (this._XamCalendar.IsMinCalendarMode)
			{
				global::Infragistics.Controls.Editors.Primitives.CalendarItem item = this._XamCalendar.GetItem(this._dateTime);
				if (item != null)
				{
					result = global::System.Windows.Automation.Peers.UIElementAutomationPeer.CreatePeerForElement(item);
				}
			}
			return result;
		}

		// Token: 0x0600004F RID: 79 RVA: 0x000032F8 File Offset: 0x000014F8
		protected override bool IsEnabledCore()
		{
			global::System.Windows.Automation.Peers.AutomationPeer underlyingPeer = this.GetUnderlyingPeer();
			return underlyingPeer == null || underlyingPeer.IsEnabled();
		}

		// Token: 0x06000050 RID: 80 RVA: 0x00003317 File Offset: 0x00001517
		void global::System.Windows.Automation.Provider.ISelectionItemProvider.AddToSelection()
		{
			if (!base.IsEnabled())
			{
				throw new global::System.Windows.Automation.ElementNotEnabledException();
			}
			if (!this._XamCalendar.SelectedDates.Contains(this._dateTime))
			{
				this._XamCalendar.SelectedDates.Add(this._dateTime);
			}
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x06000051 RID: 81 RVA: 0x00003355 File Offset: 0x00001555
		bool global::System.Windows.Automation.Provider.ISelectionItemProvider.IsSelected
		{
			get
			{
				return this._XamCalendar.SelectedDates.Contains(this._dateTime);
			}
		}

		// Token: 0x06000052 RID: 82 RVA: 0x0000336D File Offset: 0x0000156D
		void global::System.Windows.Automation.Provider.ISelectionItemProvider.RemoveFromSelection()
		{
			if (!base.IsEnabled())
			{
				throw new global::System.Windows.Automation.ElementNotEnabledException();
			}
			this._XamCalendar.SelectedDates.Remove(this._dateTime);
		}

		// Token: 0x06000053 RID: 83 RVA: 0x00003394 File Offset: 0x00001594
		void global::System.Windows.Automation.Provider.ISelectionItemProvider.Select()
		{
			if (!base.IsEnabled())
			{
				throw new global::System.Windows.Automation.ElementNotEnabledException();
			}
			this._XamCalendar.SelectedDate = new global::System.DateTime?(this._dateTime);
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x06000054 RID: 84 RVA: 0x000033BC File Offset: 0x000015BC
		global::System.Windows.Automation.Provider.IRawElementProviderSimple global::System.Windows.Automation.Provider.ISelectionItemProvider.SelectionContainer
		{
			get
			{
				global::System.Windows.Automation.Peers.AutomationPeer automationPeer = global::System.Windows.Automation.Peers.UIElementAutomationPeer.CreatePeerForElement(this._XamCalendar);
				if (automationPeer == null)
				{
					return null;
				}
				return base.ProviderFromPeer(automationPeer);
			}
		}

		// Token: 0x04000019 RID: 25
		private global::Infragistics.Controls.Editors.CalendarBase _XamCalendar;

		// Token: 0x0400001A RID: 26
		private global::System.DateTime _dateTime;
	}
}
