using System;
using System.Windows.Automation;
using System.Windows.Automation.Peers;
using System.Windows.Automation.Provider;
using System.Windows.Controls;
using Microsoft.Windows.Controls;
using Microsoft.Windows.Controls.Primitives;

namespace Microsoft.Windows.Automation.Peers
{
	// Token: 0x02000054 RID: 84
	public sealed class CalendarDayButtonAutomationPeer : global::System.Windows.Automation.Peers.ButtonAutomationPeer, global::System.Windows.Automation.Provider.ISelectionItemProvider, global::System.Windows.Automation.Provider.ITableItemProvider, global::System.Windows.Automation.Provider.IGridItemProvider
	{
		// Token: 0x060006B8 RID: 1720 RVA: 0x0001BAB3 File Offset: 0x00019CB3
		public CalendarDayButtonAutomationPeer(global::Microsoft.Windows.Controls.Primitives.CalendarDayButton owner) : base(owner)
		{
		}

		// Token: 0x17000194 RID: 404
		// (get) Token: 0x060006B9 RID: 1721 RVA: 0x0001BABC File Offset: 0x00019CBC
		private global::Microsoft.Windows.Controls.Calendar OwningCalendar
		{
			get
			{
				return this.OwningCalendarDayButton.Owner;
			}
		}

		// Token: 0x17000195 RID: 405
		// (get) Token: 0x060006BA RID: 1722 RVA: 0x0001BACC File Offset: 0x00019CCC
		private global::System.Windows.Automation.Provider.IRawElementProviderSimple OwningCalendarAutomationPeer
		{
			get
			{
				if (this.OwningCalendar != null)
				{
					global::System.Windows.Automation.Peers.AutomationPeer automationPeer = global::System.Windows.Automation.Peers.UIElementAutomationPeer.CreatePeerForElement(this.OwningCalendar);
					if (automationPeer != null)
					{
						return base.ProviderFromPeer(automationPeer);
					}
				}
				return null;
			}
		}

		// Token: 0x17000196 RID: 406
		// (get) Token: 0x060006BB RID: 1723 RVA: 0x0001BAF9 File Offset: 0x00019CF9
		private global::Microsoft.Windows.Controls.Primitives.CalendarDayButton OwningCalendarDayButton
		{
			get
			{
				return base.Owner as global::Microsoft.Windows.Controls.Primitives.CalendarDayButton;
			}
		}

		// Token: 0x17000197 RID: 407
		// (get) Token: 0x060006BC RID: 1724 RVA: 0x0001BB08 File Offset: 0x00019D08
		private global::System.DateTime? Date
		{
			get
			{
				if (this.OwningCalendarDayButton != null && this.OwningCalendarDayButton.DataContext is global::System.DateTime)
				{
					return (global::System.DateTime?)this.OwningCalendarDayButton.DataContext;
				}
				return null;
			}
		}

		// Token: 0x060006BD RID: 1725 RVA: 0x0001BB4C File Offset: 0x00019D4C
		public override object GetPattern(global::System.Windows.Automation.Peers.PatternInterface patternInterface)
		{
			object result;
			if (patternInterface == global::System.Windows.Automation.Peers.PatternInterface.GridItem || patternInterface == global::System.Windows.Automation.Peers.PatternInterface.SelectionItem || patternInterface == global::System.Windows.Automation.Peers.PatternInterface.TableItem)
			{
				if (this.OwningCalendar != null && this.OwningCalendarDayButton != null)
				{
					result = this;
				}
				else
				{
					result = base.GetPattern(patternInterface);
				}
			}
			else
			{
				result = base.GetPattern(patternInterface);
			}
			return result;
		}

		// Token: 0x060006BE RID: 1726 RVA: 0x0001BB92 File Offset: 0x00019D92
		protected override global::System.Windows.Automation.Peers.AutomationControlType GetAutomationControlTypeCore()
		{
			return global::System.Windows.Automation.Peers.AutomationControlType.Button;
		}

		// Token: 0x060006BF RID: 1727 RVA: 0x0001BB95 File Offset: 0x00019D95
		protected override string GetClassNameCore()
		{
			return base.Owner.GetType().Name;
		}

		// Token: 0x060006C0 RID: 1728 RVA: 0x0001BBA8 File Offset: 0x00019DA8
		protected override string GetHelpTextCore()
		{
			if (this.Date == null)
			{
				return base.GetHelpTextCore();
			}
			string text = global::Microsoft.Windows.Controls.DateTimeHelper.ToLongDateString(this.Date, global::Microsoft.Windows.Controls.DateTimeHelper.GetCulture(this.OwningCalendarDayButton));
			if (this.OwningCalendarDayButton.IsBlackedOut)
			{
				return string.Format(global::Microsoft.Windows.Controls.DateTimeHelper.GetCurrentDateFormat(), global::Microsoft.Windows.Controls.SR.Get(global::Microsoft.Windows.Controls.SRID.CalendarAutomationPeer_BlackoutDayHelpText), new object[]
				{
					text
				});
			}
			return text;
		}

		// Token: 0x060006C1 RID: 1729 RVA: 0x0001BC12 File Offset: 0x00019E12
		protected override string GetLocalizedControlTypeCore()
		{
			return global::Microsoft.Windows.Controls.SR.Get(global::Microsoft.Windows.Controls.SRID.CalendarAutomationPeer_DayButtonLocalizedControlType);
		}

		// Token: 0x060006C2 RID: 1730 RVA: 0x0001BC20 File Offset: 0x00019E20
		protected override string GetNameCore()
		{
			if (this.Date == null)
			{
				return base.GetNameCore();
			}
			return global::Microsoft.Windows.Controls.DateTimeHelper.ToLongDateString(this.Date, global::Microsoft.Windows.Controls.DateTimeHelper.GetCulture(this.OwningCalendarDayButton));
		}

		// Token: 0x17000198 RID: 408
		// (get) Token: 0x060006C3 RID: 1731 RVA: 0x0001BC5A File Offset: 0x00019E5A
		int global::System.Windows.Automation.Provider.IGridItemProvider.Column
		{
			get
			{
				return (int)this.OwningCalendarDayButton.GetValue(global::System.Windows.Controls.Grid.ColumnProperty);
			}
		}

		// Token: 0x17000199 RID: 409
		// (get) Token: 0x060006C4 RID: 1732 RVA: 0x0001BC71 File Offset: 0x00019E71
		int global::System.Windows.Automation.Provider.IGridItemProvider.ColumnSpan
		{
			get
			{
				return (int)this.OwningCalendarDayButton.GetValue(global::System.Windows.Controls.Grid.ColumnSpanProperty);
			}
		}

		// Token: 0x1700019A RID: 410
		// (get) Token: 0x060006C5 RID: 1733 RVA: 0x0001BC88 File Offset: 0x00019E88
		global::System.Windows.Automation.Provider.IRawElementProviderSimple global::System.Windows.Automation.Provider.IGridItemProvider.ContainingGrid
		{
			get
			{
				return this.OwningCalendarAutomationPeer;
			}
		}

		// Token: 0x1700019B RID: 411
		// (get) Token: 0x060006C6 RID: 1734 RVA: 0x0001BC90 File Offset: 0x00019E90
		int global::System.Windows.Automation.Provider.IGridItemProvider.Row
		{
			get
			{
				return (int)this.OwningCalendarDayButton.GetValue(global::System.Windows.Controls.Grid.RowProperty) - 1;
			}
		}

		// Token: 0x1700019C RID: 412
		// (get) Token: 0x060006C7 RID: 1735 RVA: 0x0001BCA9 File Offset: 0x00019EA9
		int global::System.Windows.Automation.Provider.IGridItemProvider.RowSpan
		{
			get
			{
				return (int)this.OwningCalendarDayButton.GetValue(global::System.Windows.Controls.Grid.RowSpanProperty);
			}
		}

		// Token: 0x1700019D RID: 413
		// (get) Token: 0x060006C8 RID: 1736 RVA: 0x0001BCC0 File Offset: 0x00019EC0
		bool global::System.Windows.Automation.Provider.ISelectionItemProvider.IsSelected
		{
			get
			{
				return this.OwningCalendarDayButton.IsSelected;
			}
		}

		// Token: 0x1700019E RID: 414
		// (get) Token: 0x060006C9 RID: 1737 RVA: 0x0001BCCD File Offset: 0x00019ECD
		global::System.Windows.Automation.Provider.IRawElementProviderSimple global::System.Windows.Automation.Provider.ISelectionItemProvider.SelectionContainer
		{
			get
			{
				return this.OwningCalendarAutomationPeer;
			}
		}

		// Token: 0x060006CA RID: 1738 RVA: 0x0001BCD8 File Offset: 0x00019ED8
		void global::System.Windows.Automation.Provider.ISelectionItemProvider.AddToSelection()
		{
			if (((global::System.Windows.Automation.Provider.ISelectionItemProvider)this).IsSelected)
			{
				return;
			}
			if (this.EnsureSelection() && this.OwningCalendarDayButton.DataContext is global::System.DateTime)
			{
				if (this.OwningCalendar.SelectionMode == global::Microsoft.Windows.Controls.CalendarSelectionMode.SingleDate)
				{
					this.OwningCalendar.SelectedDate = new global::System.DateTime?((global::System.DateTime)this.OwningCalendarDayButton.DataContext);
					return;
				}
				this.OwningCalendar.SelectedDates.Add((global::System.DateTime)this.OwningCalendarDayButton.DataContext);
			}
		}

		// Token: 0x060006CB RID: 1739 RVA: 0x0001BD56 File Offset: 0x00019F56
		void global::System.Windows.Automation.Provider.ISelectionItemProvider.RemoveFromSelection()
		{
			if (!((global::System.Windows.Automation.Provider.ISelectionItemProvider)this).IsSelected)
			{
				return;
			}
			if (this.OwningCalendarDayButton.DataContext is global::System.DateTime)
			{
				this.OwningCalendar.SelectedDates.Remove((global::System.DateTime)this.OwningCalendarDayButton.DataContext);
			}
		}

		// Token: 0x060006CC RID: 1740 RVA: 0x0001BD94 File Offset: 0x00019F94
		void global::System.Windows.Automation.Provider.ISelectionItemProvider.Select()
		{
			if (this.EnsureSelection())
			{
				this.OwningCalendar.SelectedDates.Clear();
				if (this.OwningCalendarDayButton.DataContext is global::System.DateTime)
				{
					this.OwningCalendar.SelectedDates.Add((global::System.DateTime)this.OwningCalendarDayButton.DataContext);
				}
			}
		}

		// Token: 0x060006CD RID: 1741 RVA: 0x0001BDEC File Offset: 0x00019FEC
		global::System.Windows.Automation.Provider.IRawElementProviderSimple[] global::System.Windows.Automation.Provider.ITableItemProvider.GetColumnHeaderItems()
		{
			if (this.OwningCalendar != null && this.OwningCalendarAutomationPeer != null)
			{
				global::System.Windows.Automation.Provider.IRawElementProviderSimple[] columnHeaders = ((global::System.Windows.Automation.Provider.ITableProvider)global::System.Windows.Automation.Peers.UIElementAutomationPeer.CreatePeerForElement(this.OwningCalendar)).GetColumnHeaders();
				if (columnHeaders != null)
				{
					int column = ((global::System.Windows.Automation.Provider.IGridItemProvider)this).Column;
					return new global::System.Windows.Automation.Provider.IRawElementProviderSimple[]
					{
						columnHeaders[column]
					};
				}
			}
			return null;
		}

		// Token: 0x060006CE RID: 1742 RVA: 0x0001BE39 File Offset: 0x0001A039
		global::System.Windows.Automation.Provider.IRawElementProviderSimple[] global::System.Windows.Automation.Provider.ITableItemProvider.GetRowHeaderItems()
		{
			return null;
		}

		// Token: 0x060006CF RID: 1743 RVA: 0x0001BE3C File Offset: 0x0001A03C
		private bool EnsureSelection()
		{
			if (!this.OwningCalendarDayButton.IsEnabled)
			{
				throw new global::System.Windows.Automation.ElementNotEnabledException();
			}
			return !this.OwningCalendarDayButton.IsBlackedOut && this.OwningCalendar.SelectionMode != global::Microsoft.Windows.Controls.CalendarSelectionMode.None;
		}
	}
}
