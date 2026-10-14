using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Automation.Peers;
using System.Windows.Controls;
using System.Windows.Input;
using Infragistics.AutomationPeers;

namespace Infragistics.Controls.Primitives
{
	// Token: 0x020000D9 RID: 217
	[global::System.Windows.TemplatePart(Name = "ExpansionIndicator", Type = typeof(global::System.Windows.FrameworkElement))]
	[global::System.Windows.TemplateVisualState(Name = "Normal", GroupName = "CommonStates")]
	[global::System.Windows.TemplateVisualState(GroupName = "ExpansionStates", Name = "Expanded")]
	[global::System.Windows.TemplateVisualState(GroupName = "ExpansionStates", Name = "Collapsed")]
	[global::System.Windows.TemplateVisualState(Name = "MouseOver", GroupName = "CommonStates")]
	[global::System.ComponentModel.DesignTimeVisible(false)]
	[global::System.Windows.TemplateVisualState(Name = "Disabled", GroupName = "CommonStates")]
	public class ExpansionIndicator : global::System.Windows.Controls.ContentControl
	{
		// Token: 0x060007E8 RID: 2024 RVA: 0x0001C28C File Offset: 0x0001A48C
		static ExpansionIndicator()
		{
			global::System.Windows.FrameworkElement.DefaultStyleKeyProperty.OverrideMetadata(typeof(global::Infragistics.Controls.Primitives.ExpansionIndicator), new global::System.Windows.FrameworkPropertyMetadata(typeof(global::Infragistics.Controls.Primitives.ExpansionIndicator)));
		}

		// Token: 0x060007E9 RID: 2025 RVA: 0x0001C32A File Offset: 0x0001A52A
		public ExpansionIndicator()
		{
			base.IsTabStop = false;
			base.IsEnabledChanged += this.ExpansionIndicator_IsEnabledChanged;
		}

		// Token: 0x060007EA RID: 2026 RVA: 0x0001C34C File Offset: 0x0001A54C
		public override void OnApplyTemplate()
		{
			if (this._expansionIndicator != null)
			{
				this._expansionIndicator.MouseLeftButtonDown -= this.ExpansionIndicator_MouseDown;
			}
			this._expansionIndicator = (base.GetTemplateChild("ExpansionIndicator") as global::System.Windows.FrameworkElement);
			if (this._expansionIndicator != null)
			{
				this._expansionIndicator.MouseLeftButtonDown += this.ExpansionIndicator_MouseDown;
				this._expansionIndicator.Visibility = this.IndicatorVisibility;
			}
			this.UpdateVisualState(false, this.IsExpanded);
		}

		// Token: 0x060007EB RID: 2027 RVA: 0x0001C3CB File Offset: 0x0001A5CB
		protected override global::System.Windows.Automation.Peers.AutomationPeer OnCreateAutomationPeer()
		{
			return new global::Infragistics.AutomationPeers.ExpansionIndicatorAutomationPeer(this);
		}

		// Token: 0x060007EC RID: 2028 RVA: 0x0001C3D3 File Offset: 0x0001A5D3
		protected override void OnMouseEnter(global::System.Windows.Input.MouseEventArgs e)
		{
			this.OnMouseEnter();
			base.OnMouseEnter(e);
		}

		// Token: 0x060007ED RID: 2029 RVA: 0x0001C3E2 File Offset: 0x0001A5E2
		protected override void OnMouseLeave(global::System.Windows.Input.MouseEventArgs e)
		{
			this.OnMouseLeave();
			base.OnMouseLeave(e);
		}

		// Token: 0x17000143 RID: 323
		// (get) Token: 0x060007EE RID: 2030 RVA: 0x0001C3F1 File Offset: 0x0001A5F1
		// (set) Token: 0x060007EF RID: 2031 RVA: 0x0001C403 File Offset: 0x0001A603
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

		// Token: 0x060007F0 RID: 2032 RVA: 0x0001C438 File Offset: 0x0001A638
		private static void IsExpandedChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Primitives.ExpansionIndicator expansionIndicator = (global::Infragistics.Controls.Primitives.ExpansionIndicator)obj;
			expansionIndicator.UpdateVisualState(false, expansionIndicator.IsExpanded);
		}

		// Token: 0x17000144 RID: 324
		// (get) Token: 0x060007F1 RID: 2033 RVA: 0x0001C459 File Offset: 0x0001A659
		// (set) Token: 0x060007F2 RID: 2034 RVA: 0x0001C46B File Offset: 0x0001A66B
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

		// Token: 0x060007F3 RID: 2035 RVA: 0x0001C480 File Offset: 0x0001A680
		private static void IndicatorVisibilityChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Primitives.ExpansionIndicator expansionIndicator = (global::Infragistics.Controls.Primitives.ExpansionIndicator)obj;
			if (expansionIndicator._expansionIndicator != null)
			{
				expansionIndicator._expansionIndicator.Visibility = (global::System.Windows.Visibility)e.NewValue;
			}
		}

		// Token: 0x17000145 RID: 325
		// (get) Token: 0x060007F4 RID: 2036 RVA: 0x0001C4B3 File Offset: 0x0001A6B3
		// (set) Token: 0x060007F5 RID: 2037 RVA: 0x0001C4BB File Offset: 0x0001A6BB
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

		// Token: 0x060007F6 RID: 2038 RVA: 0x0001C4C4 File Offset: 0x0001A6C4
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

		// Token: 0x060007F7 RID: 2039 RVA: 0x0001C52A File Offset: 0x0001A72A
		internal void OnMouseEnter()
		{
			this._isMouseOver = true;
			this.UpdateVisualState(true, this.IsExpanded);
		}

		// Token: 0x060007F8 RID: 2040 RVA: 0x0001C540 File Offset: 0x0001A740
		internal void OnMouseLeave()
		{
			this._isMouseOver = false;
			this.UpdateVisualState(true, this.IsExpanded);
		}

		// Token: 0x060007F9 RID: 2041 RVA: 0x0001C556 File Offset: 0x0001A756
		private void ExpansionIndicator_MouseDown(object sender, global::System.Windows.Input.MouseButtonEventArgs e)
		{
			this.UpdateVisualState(true, !this.IsExpanded);
			this.IsExpanded = !this.IsExpanded;
			e.Handled = true;
		}

		// Token: 0x060007FA RID: 2042 RVA: 0x0001C57E File Offset: 0x0001A77E
		private void ExpansionIndicator_IsEnabledChanged(object sender, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			this.UpdateVisualState(false, this.IsExpanded);
		}

		// Token: 0x040003DF RID: 991
		private const string StateMouseOver = "MouseOver";

		// Token: 0x040003E0 RID: 992
		private const string StateNormal = "Normal";

		// Token: 0x040003E1 RID: 993
		private const string StateDiabled = "Disabled";

		// Token: 0x040003E2 RID: 994
		private bool _isMouseOver;

		// Token: 0x040003E3 RID: 995
		private global::System.Windows.FrameworkElement _expansionIndicator;

		// Token: 0x040003E4 RID: 996
		public static readonly global::System.Windows.DependencyProperty IsExpandedProperty = global::System.Windows.DependencyProperty.Register("IsExpanded", typeof(bool), typeof(global::Infragistics.Controls.Primitives.ExpansionIndicator), new global::System.Windows.PropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Primitives.ExpansionIndicator.IsExpandedChanged)));

		// Token: 0x040003E5 RID: 997
		public static readonly global::System.Windows.DependencyProperty IndicatorVisibilityProperty = global::System.Windows.DependencyProperty.Register("IndicatorVisibility", typeof(global::System.Windows.Visibility), typeof(global::Infragistics.Controls.Primitives.ExpansionIndicator), new global::System.Windows.PropertyMetadata(global::System.Windows.Visibility.Visible, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Primitives.ExpansionIndicator.IndicatorVisibilityChanged)));
	}
}
