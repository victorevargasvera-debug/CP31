using System;
using System.Runtime.CompilerServices;
using System.Windows.Automation;
using System.Windows.Automation.Peers;
using System.Windows.Automation.Provider;
using Microsoft.Windows.Controls;

namespace Microsoft.Windows.Automation.Peers
{
	// Token: 0x0200002C RID: 44
	public sealed class DatePickerAutomationPeer : global::System.Windows.Automation.Peers.FrameworkElementAutomationPeer, global::System.Windows.Automation.Provider.IExpandCollapseProvider, global::System.Windows.Automation.Provider.IValueProvider
	{
		// Token: 0x0600026A RID: 618 RVA: 0x00009966 File Offset: 0x00007B66
		public DatePickerAutomationPeer(global::Microsoft.Windows.Controls.DatePicker owner) : base(owner)
		{
		}

		// Token: 0x170000AF RID: 175
		// (get) Token: 0x0600026B RID: 619 RVA: 0x0000996F File Offset: 0x00007B6F
		private global::Microsoft.Windows.Controls.DatePicker OwningDatePicker
		{
			get
			{
				return base.Owner as global::Microsoft.Windows.Controls.DatePicker;
			}
		}

		// Token: 0x0600026C RID: 620 RVA: 0x0000997C File Offset: 0x00007B7C
		public override object GetPattern(global::System.Windows.Automation.Peers.PatternInterface patternInterface)
		{
			if (patternInterface == global::System.Windows.Automation.Peers.PatternInterface.ExpandCollapse || patternInterface == global::System.Windows.Automation.Peers.PatternInterface.Value)
			{
				return this;
			}
			return base.GetPattern(patternInterface);
		}

		// Token: 0x0600026D RID: 621 RVA: 0x0000998F File Offset: 0x00007B8F
		protected override global::System.Windows.Automation.Peers.AutomationControlType GetAutomationControlTypeCore()
		{
			return global::System.Windows.Automation.Peers.AutomationControlType.Custom;
		}

		// Token: 0x0600026E RID: 622 RVA: 0x00009993 File Offset: 0x00007B93
		protected override string GetClassNameCore()
		{
			return base.Owner.GetType().Name;
		}

		// Token: 0x0600026F RID: 623 RVA: 0x000099A5 File Offset: 0x00007BA5
		protected override string GetLocalizedControlTypeCore()
		{
			return global::Microsoft.Windows.Controls.SR.Get(global::Microsoft.Windows.Controls.SRID.DatePickerAutomationPeer_LocalizedControlType);
		}

		// Token: 0x170000B0 RID: 176
		// (get) Token: 0x06000270 RID: 624 RVA: 0x000099B1 File Offset: 0x00007BB1
		global::System.Windows.Automation.ExpandCollapseState global::System.Windows.Automation.Provider.IExpandCollapseProvider.ExpandCollapseState
		{
			get
			{
				if (this.OwningDatePicker.IsDropDownOpen)
				{
					return global::System.Windows.Automation.ExpandCollapseState.Expanded;
				}
				return global::System.Windows.Automation.ExpandCollapseState.Collapsed;
			}
		}

		// Token: 0x06000271 RID: 625 RVA: 0x000099C3 File Offset: 0x00007BC3
		void global::System.Windows.Automation.Provider.IExpandCollapseProvider.Collapse()
		{
			this.OwningDatePicker.IsDropDownOpen = false;
		}

		// Token: 0x06000272 RID: 626 RVA: 0x000099D1 File Offset: 0x00007BD1
		void global::System.Windows.Automation.Provider.IExpandCollapseProvider.Expand()
		{
			this.OwningDatePicker.IsDropDownOpen = true;
		}

		// Token: 0x170000B1 RID: 177
		// (get) Token: 0x06000273 RID: 627 RVA: 0x000099DF File Offset: 0x00007BDF
		bool global::System.Windows.Automation.Provider.IValueProvider.IsReadOnly
		{
			get
			{
				return false;
			}
		}

		// Token: 0x170000B2 RID: 178
		// (get) Token: 0x06000274 RID: 628 RVA: 0x000099E2 File Offset: 0x00007BE2
		string global::System.Windows.Automation.Provider.IValueProvider.Value
		{
			get
			{
				return this.OwningDatePicker.ToString();
			}
		}

		// Token: 0x06000275 RID: 629 RVA: 0x000099EF File Offset: 0x00007BEF
		void global::System.Windows.Automation.Provider.IValueProvider.SetValue(string value)
		{
			this.OwningDatePicker.Text = value;
		}

		// Token: 0x06000276 RID: 630 RVA: 0x000099FD File Offset: 0x00007BFD
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
		internal void RaiseValuePropertyChangedEvent(string oldValue, string newValue)
		{
			if (oldValue != newValue)
			{
				base.RaisePropertyChangedEvent(global::System.Windows.Automation.ValuePatternIdentifiers.ValueProperty, oldValue, newValue);
			}
		}
	}
}
