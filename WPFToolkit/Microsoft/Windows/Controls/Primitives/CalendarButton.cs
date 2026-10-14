using System;
using System.Windows;
using System.Windows.Automation.Peers;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Input;
using Microsoft.Windows.Automation.Peers;

namespace Microsoft.Windows.Controls.Primitives
{
	// Token: 0x02000053 RID: 83
	[global::System.Windows.TemplateVisualState(Name = "Inactive", GroupName = "ActiveStates")]
	[global::System.Windows.TemplateVisualState(Name = "Active", GroupName = "ActiveStates")]
	[global::System.Windows.TemplateVisualState(Name = "Normal", GroupName = "CommonStates")]
	[global::System.Windows.TemplateVisualState(Name = "MouseOver", GroupName = "CommonStates")]
	[global::System.Windows.TemplateVisualState(Name = "Pressed", GroupName = "CommonStates")]
	[global::System.Windows.TemplateVisualState(Name = "Disabled", GroupName = "CommonStates")]
	[global::System.Windows.TemplateVisualState(Name = "Unselected", GroupName = "SelectionStates")]
	[global::System.Windows.TemplateVisualState(Name = "Selected", GroupName = "SelectionStates")]
	[global::System.Windows.TemplateVisualState(Name = "CalendarButtonUnfocused", GroupName = "CalendarButtonFocusStates")]
	[global::System.Windows.TemplateVisualState(Name = "CalendarButtonFocused", GroupName = "CalendarButtonFocusStates")]
	public sealed class CalendarButton : global::System.Windows.Controls.Button
	{
		// Token: 0x060006A7 RID: 1703 RVA: 0x0001B7A8 File Offset: 0x000199A8
		static CalendarButton()
		{
			global::System.Windows.FrameworkElement.DefaultStyleKeyProperty.OverrideMetadata(typeof(global::Microsoft.Windows.Controls.Primitives.CalendarButton), new global::System.Windows.FrameworkPropertyMetadata(typeof(global::Microsoft.Windows.Controls.Primitives.CalendarButton)));
			global::System.Windows.Controls.ContentControl.ContentProperty.OverrideMetadata(typeof(global::Microsoft.Windows.Controls.Primitives.CalendarButton), new global::System.Windows.FrameworkPropertyMetadata(null, new global::System.Windows.CoerceValueCallback(global::Microsoft.Windows.Controls.Primitives.CalendarButton.OnCoerceContent)));
		}

		// Token: 0x060006A8 RID: 1704 RVA: 0x0001B89C File Offset: 0x00019A9C
		public CalendarButton()
		{
			base.Loaded += delegate(object A_1, global::System.Windows.RoutedEventArgs A_2)
			{
				this.ChangeVisualState(false);
			};
		}

		// Token: 0x17000191 RID: 401
		// (get) Token: 0x060006A9 RID: 1705 RVA: 0x0001B8C8 File Offset: 0x00019AC8
		// (set) Token: 0x060006AA RID: 1706 RVA: 0x0001B8DA File Offset: 0x00019ADA
		public bool HasSelectedDays
		{
			get
			{
				return (bool)base.GetValue(global::Microsoft.Windows.Controls.Primitives.CalendarButton.HasSelectedDaysProperty);
			}
			internal set
			{
				base.SetValue(global::Microsoft.Windows.Controls.Primitives.CalendarButton.HasSelectedDaysPropertyKey, value);
			}
		}

		// Token: 0x17000192 RID: 402
		// (get) Token: 0x060006AB RID: 1707 RVA: 0x0001B8ED File Offset: 0x00019AED
		// (set) Token: 0x060006AC RID: 1708 RVA: 0x0001B8FF File Offset: 0x00019AFF
		public bool IsInactive
		{
			get
			{
				return (bool)base.GetValue(global::Microsoft.Windows.Controls.Primitives.CalendarButton.IsInactiveProperty);
			}
			internal set
			{
				base.SetValue(global::Microsoft.Windows.Controls.Primitives.CalendarButton.IsInactivePropertyKey, value);
			}
		}

		// Token: 0x17000193 RID: 403
		// (get) Token: 0x060006AD RID: 1709 RVA: 0x0001B912 File Offset: 0x00019B12
		// (set) Token: 0x060006AE RID: 1710 RVA: 0x0001B91A File Offset: 0x00019B1A
		internal global::Microsoft.Windows.Controls.Calendar Owner { get; set; }

		// Token: 0x060006AF RID: 1711 RVA: 0x0001B923 File Offset: 0x00019B23
		public override void OnApplyTemplate()
		{
			base.OnApplyTemplate();
			this.ChangeVisualState(false);
		}

		// Token: 0x060006B0 RID: 1712 RVA: 0x0001B932 File Offset: 0x00019B32
		protected override global::System.Windows.Automation.Peers.AutomationPeer OnCreateAutomationPeer()
		{
			return new global::Microsoft.Windows.Automation.Peers.CalendarButtonAutomationPeer(this);
		}

		// Token: 0x060006B1 RID: 1713 RVA: 0x0001B93A File Offset: 0x00019B3A
		protected override void OnGotKeyboardFocus(global::System.Windows.Input.KeyboardFocusChangedEventArgs e)
		{
			this.ChangeVisualState(true);
			base.OnGotKeyboardFocus(e);
		}

		// Token: 0x060006B2 RID: 1714 RVA: 0x0001B94A File Offset: 0x00019B4A
		protected override void OnLostKeyboardFocus(global::System.Windows.Input.KeyboardFocusChangedEventArgs e)
		{
			this.ChangeVisualState(true);
			base.OnLostKeyboardFocus(e);
		}

		// Token: 0x060006B3 RID: 1715 RVA: 0x0001B95A File Offset: 0x00019B5A
		internal void SetContentInternal(string value)
		{
			if (global::System.Windows.Data.BindingOperations.GetBindingExpressionBase(this, global::System.Windows.Controls.ContentControl.ContentProperty) != null)
			{
				base.Content = value;
				return;
			}
			this._shouldCoerceContent = true;
			this._coercedContent = value;
			base.CoerceValue(global::System.Windows.Controls.ContentControl.ContentProperty);
		}

		// Token: 0x060006B4 RID: 1716 RVA: 0x0001B98C File Offset: 0x00019B8C
		private void ChangeVisualState(bool useTransitions)
		{
			if (this.HasSelectedDays)
			{
				global::Microsoft.Windows.Controls.VisualStates.GoToState(this, useTransitions, new string[]
				{
					"Selected",
					"Unselected"
				});
			}
			else
			{
				global::Microsoft.Windows.Controls.VisualStates.GoToState(this, useTransitions, new string[]
				{
					"Unselected"
				});
			}
			if (this.IsInactive)
			{
				global::Microsoft.Windows.Controls.VisualStates.GoToState(this, useTransitions, new string[]
				{
					"Inactive"
				});
			}
			else
			{
				global::Microsoft.Windows.Controls.VisualStates.GoToState(this, useTransitions, new string[]
				{
					"Active",
					"Inactive"
				});
			}
			if (base.IsKeyboardFocused)
			{
				global::Microsoft.Windows.Controls.VisualStates.GoToState(this, useTransitions, new string[]
				{
					"CalendarButtonFocused",
					"CalendarButtonUnfocused"
				});
				return;
			}
			global::System.Windows.VisualStateManager.GoToState(this, "CalendarButtonUnfocused", useTransitions);
		}

		// Token: 0x060006B5 RID: 1717 RVA: 0x0001BA54 File Offset: 0x00019C54
		private static void OnVisualStatePropertyChanged(global::System.Windows.DependencyObject dObject, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Microsoft.Windows.Controls.Primitives.CalendarButton calendarButton = dObject as global::Microsoft.Windows.Controls.Primitives.CalendarButton;
			if (calendarButton != null && !object.Equals(e.OldValue, e.NewValue))
			{
				calendarButton.ChangeVisualState(true);
			}
		}

		// Token: 0x060006B6 RID: 1718 RVA: 0x0001BA88 File Offset: 0x00019C88
		private static object OnCoerceContent(global::System.Windows.DependencyObject sender, object baseValue)
		{
			global::Microsoft.Windows.Controls.Primitives.CalendarButton calendarButton = (global::Microsoft.Windows.Controls.Primitives.CalendarButton)sender;
			if (calendarButton._shouldCoerceContent)
			{
				calendarButton._shouldCoerceContent = false;
				return calendarButton._coercedContent;
			}
			return baseValue;
		}

		// Token: 0x040001E2 RID: 482
		private bool _shouldCoerceContent;

		// Token: 0x040001E3 RID: 483
		private object _coercedContent;

		// Token: 0x040001E4 RID: 484
		internal static readonly global::System.Windows.DependencyPropertyKey HasSelectedDaysPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("HasSelectedDays", typeof(bool), typeof(global::Microsoft.Windows.Controls.Primitives.CalendarButton), new global::System.Windows.FrameworkPropertyMetadata(false, new global::System.Windows.PropertyChangedCallback(global::Microsoft.Windows.Controls.Primitives.CalendarButton.OnVisualStatePropertyChanged)));

		// Token: 0x040001E5 RID: 485
		public static readonly global::System.Windows.DependencyProperty HasSelectedDaysProperty = global::Microsoft.Windows.Controls.Primitives.CalendarButton.HasSelectedDaysPropertyKey.DependencyProperty;

		// Token: 0x040001E6 RID: 486
		internal static readonly global::System.Windows.DependencyPropertyKey IsInactivePropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("IsInactive", typeof(bool), typeof(global::Microsoft.Windows.Controls.Primitives.CalendarButton), new global::System.Windows.FrameworkPropertyMetadata(false, new global::System.Windows.PropertyChangedCallback(global::Microsoft.Windows.Controls.Primitives.CalendarButton.OnVisualStatePropertyChanged)));

		// Token: 0x040001E7 RID: 487
		public static readonly global::System.Windows.DependencyProperty IsInactiveProperty = global::Microsoft.Windows.Controls.Primitives.CalendarButton.IsInactivePropertyKey.DependencyProperty;
	}
}
