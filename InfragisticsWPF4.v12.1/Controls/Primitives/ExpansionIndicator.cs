using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Automation.Peers;
using System.Windows.Controls;
using System.Windows.Input;
using Infragistics.AutomationPeers;

namespace Infragistics.Controls.Primitives
{
	// Token: 0x020000BC RID: 188
	[global::System.Windows.TemplateVisualState(GroupName = "ExpansionStates", Name = "Expanded")]
	[global::System.Windows.TemplateVisualState(GroupName = "ExpansionStates", Name = "Collapsed")]
	[global::System.Windows.TemplateVisualState(Name = "MouseOver", GroupName = "CommonStates")]
	[global::System.Windows.TemplateVisualState(Name = "Disabled", GroupName = "CommonStates")]
	[global::System.Windows.TemplatePart(Name = "ExpansionIndicator", Type = typeof(global::System.Windows.FrameworkElement))]
	[global::System.Windows.TemplateVisualState(Name = "Normal", GroupName = "CommonStates")]
	[global::System.ComponentModel.DesignTimeVisible(false)]
	public class ExpansionIndicator : global::System.Windows.Controls.ContentControl
	{
		// Token: 0x060006FD RID: 1789 RVA: 0x00018AE4 File Offset: 0x00016CE4
		static ExpansionIndicator()
		{
			global::System.Windows.FrameworkElement.DefaultStyleKeyProperty.OverrideMetadata(typeof(global::Infragistics.Controls.Primitives.ExpansionIndicator), new global::System.Windows.FrameworkPropertyMetadata(typeof(global::Infragistics.Controls.Primitives.ExpansionIndicator)));
		}

		// Token: 0x060006FE RID: 1790 RVA: 0x00018B7C File Offset: 0x00016D7C
		public ExpansionIndicator()
		{
			base.IsTabStop = false;
			base.IsEnabledChanged += this.ExpansionIndicator_IsEnabledChanged;
		}

		// Token: 0x060006FF RID: 1791 RVA: 0x00018BA0 File Offset: 0x00016DA0
		public override void OnApplyTemplate()
		{
			this._expansionIndicator = (base.GetTemplateChild("ExpansionIndicator") as global::System.Windows.FrameworkElement);
			if (this._expansionIndicator != null)
			{
				this._expansionIndicator.MouseLeftButtonDown += this.ExpansionIndicator_MouseDown;
				this._expansionIndicator.Visibility = this.IndicatorVisibility;
			}
			this.UpdateVisualState(false, this.IsExpanded);
		}

		// Token: 0x06000700 RID: 1792 RVA: 0x00018C00 File Offset: 0x00016E00
		protected override global::System.Windows.Automation.Peers.AutomationPeer OnCreateAutomationPeer()
		{
			return new global::Infragistics.AutomationPeers.ExpansionIndicatorAutomationPeer(this);
		}

		// Token: 0x06000701 RID: 1793 RVA: 0x00018C08 File Offset: 0x00016E08
		protected override void OnMouseEnter(global::System.Windows.Input.MouseEventArgs e)
		{
			this._isMouseOver = true;
			this.UpdateVisualState(true, this.IsExpanded);
			base.OnMouseEnter(e);
		}

		// Token: 0x06000702 RID: 1794 RVA: 0x00018C25 File Offset: 0x00016E25
		protected override void OnMouseLeave(global::System.Windows.Input.MouseEventArgs e)
		{
			this._isMouseOver = false;
			this.UpdateVisualState(true, this.IsExpanded);
			base.OnMouseLeave(e);
		}

		// Token: 0x1700012B RID: 299
		// (get) Token: 0x06000703 RID: 1795 RVA: 0x00018C42 File Offset: 0x00016E42
		// (set) Token: 0x06000704 RID: 1796 RVA: 0x00018C54 File Offset: 0x00016E54
		public bool IsExpanded
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.Controls.Primitives.ExpansionIndicator.IsExpandedProperty);
			}
			set
			{
				if (value)
				{
					global::System.Windows.VisualStateManager.GoToState(this, "Expanded", true);
				}
				else
				{
					global::System.Windows.VisualStateManager.GoToState(this, "Collapsed", true);
				}
				base.SetValue(global::Infragistics.Controls.Primitives.ExpansionIndicator.IsExpandedProperty, value);
			}
		}

		// Token: 0x06000705 RID: 1797 RVA: 0x00018C88 File Offset: 0x00016E88
		private static void IsExpandedChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Primitives.ExpansionIndicator expansionIndicator = (global::Infragistics.Controls.Primitives.ExpansionIndicator)obj;
			expansionIndicator.UpdateVisualState(false, expansionIndicator.IsExpanded);
		}

		// Token: 0x1700012C RID: 300
		// (get) Token: 0x06000706 RID: 1798 RVA: 0x00018CA9 File Offset: 0x00016EA9
		// (set) Token: 0x06000707 RID: 1799 RVA: 0x00018CBB File Offset: 0x00016EBB
		public global::System.Windows.Visibility IndicatorVisibility
		{
			get
			{
				return (global::System.Windows.Visibility)base.GetValue(global::Infragistics.Controls.Primitives.ExpansionIndicator.IndicatorVisibilityProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Primitives.ExpansionIndicator.IndicatorVisibilityProperty, value);
			}
		}

		// Token: 0x06000708 RID: 1800 RVA: 0x00018CD0 File Offset: 0x00016ED0
		private static void IndicatorVisibilityChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Primitives.ExpansionIndicator expansionIndicator = (global::Infragistics.Controls.Primitives.ExpansionIndicator)obj;
			if (expansionIndicator._expansionIndicator != null)
			{
				expansionIndicator._expansionIndicator.Visibility = (global::System.Windows.Visibility)e.NewValue;
			}
		}

		// Token: 0x1700012D RID: 301
		// (get) Token: 0x06000709 RID: 1801 RVA: 0x00018D03 File Offset: 0x00016F03
		// (set) Token: 0x0600070A RID: 1802 RVA: 0x00018D0B File Offset: 0x00016F0B
		protected global::System.Windows.FrameworkElement IndicatorElement
		{
			get
			{
				return this._expansionIndicator;
			}
			set
			{
				this._expansionIndicator = value;
			}
		}

		// Token: 0x0600070B RID: 1803 RVA: 0x00018D14 File Offset: 0x00016F14
		private void UpdateVisualState(bool useTransistions, bool isExpanded)
		{
			if (base.IsEnabled)
			{
				if (this._isMouseOver)
				{
					global::System.Windows.VisualStateManager.GoToState(this, "MouseOver", useTransistions);
				}
				else
				{
					global::System.Windows.VisualStateManager.GoToState(this, "Normal", useTransistions);
				}
			}
			else
			{
				global::System.Windows.VisualStateManager.GoToState(this, "Disabled", useTransistions);
			}
			if (isExpanded)
			{
				global::System.Windows.VisualStateManager.GoToState(this, "Expanded", useTransistions);
				return;
			}
			global::System.Windows.VisualStateManager.GoToState(this, "Collapsed", useTransistions);
		}

		// Token: 0x0600070C RID: 1804 RVA: 0x00018D7A File Offset: 0x00016F7A
		private void ExpansionIndicator_MouseDown(object sender, global::System.Windows.Input.MouseButtonEventArgs e)
		{
			this.UpdateVisualState(true, !this.IsExpanded);
			this.IsExpanded = !this.IsExpanded;
			e.Handled = true;
		}

		// Token: 0x0600070D RID: 1805 RVA: 0x00018DA2 File Offset: 0x00016FA2
		private void ExpansionIndicator_IsEnabledChanged(object sender, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			this.UpdateVisualState(false, this.IsExpanded);
		}

		// Token: 0x04000331 RID: 817
		private const string StateMouseOver = "MouseOver";

		// Token: 0x04000332 RID: 818
		private const string StateNormal = "Normal";

		// Token: 0x04000333 RID: 819
		private const string StateDiabled = "Disabled";

		// Token: 0x04000334 RID: 820
		private bool _isMouseOver;

		// Token: 0x04000335 RID: 821
		private global::System.Windows.FrameworkElement _expansionIndicator;

		// Token: 0x04000336 RID: 822
		public static readonly global::System.Windows.DependencyProperty IsExpandedProperty = global::System.Windows.DependencyProperty.Register("IsExpanded", typeof(bool), typeof(global::Infragistics.Controls.Primitives.ExpansionIndicator), new global::System.Windows.PropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Primitives.ExpansionIndicator.IsExpandedChanged)));

		// Token: 0x04000337 RID: 823
		public static readonly global::System.Windows.DependencyProperty IndicatorVisibilityProperty = global::System.Windows.DependencyProperty.Register("IndicatorVisibility", typeof(global::System.Windows.Visibility), typeof(global::Infragistics.Controls.Primitives.ExpansionIndicator), new global::System.Windows.PropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Primitives.ExpansionIndicator.IndicatorVisibilityChanged)));
	}
}
