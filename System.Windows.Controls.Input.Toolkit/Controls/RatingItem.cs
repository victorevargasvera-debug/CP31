using System;
using System.Globalization;
using System.Windows.Automation.Peers;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Properties;
using System.Windows.Input;

namespace System.Windows.Controls
{
	// Token: 0x02000016 RID: 22
	[global::System.Windows.TemplateVisualState(Name = "Empty", GroupName = "FillStates")]
	[global::System.Windows.TemplateVisualState(Name = "ReadOnly", GroupName = "CommonStates")]
	[global::System.Windows.TemplateVisualState(Name = "Focused", GroupName = "FocusStates")]
	[global::System.Windows.TemplateVisualState(Name = "Disabled", GroupName = "CommonStates")]
	[global::System.Windows.TemplateVisualState(Name = "Partial", GroupName = "FillStates")]
	[global::System.Windows.TemplateVisualState(Name = "MouseOver", GroupName = "CommonStates")]
	[global::System.Windows.TemplateVisualState(Name = "Pressed", GroupName = "CommonStates")]
	[global::System.Windows.TemplateVisualState(Name = "Normal", GroupName = "CommonStates")]
	[global::System.Windows.TemplateVisualState(Name = "Unfocused", GroupName = "FocusStates")]
	[global::System.Windows.TemplateVisualState(Name = "Filled", GroupName = "FillStates")]
	public class RatingItem : global::System.Windows.Controls.Primitives.ButtonBase, global::System.Windows.Controls.IUpdateVisualState
	{
		// Token: 0x1700003A RID: 58
		// (get) Token: 0x06000154 RID: 340 RVA: 0x00006523 File Offset: 0x00004723
		// (set) Token: 0x06000155 RID: 341 RVA: 0x00006538 File Offset: 0x00004738
		public double DisplayValue
		{
			get
			{
				return (double)base.GetValue(global::System.Windows.Controls.RatingItem.DisplayValueProperty);
			}
			internal set
			{
				this._settingDisplayValue = true;
				try
				{
					base.SetValue(global::System.Windows.Controls.RatingItem.DisplayValueProperty, value);
				}
				finally
				{
					this._settingDisplayValue = false;
				}
			}
		}

		// Token: 0x06000156 RID: 342 RVA: 0x00006578 File Offset: 0x00004778
		private static void OnDisplayValueChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::System.Windows.Controls.RatingItem ratingItem = (global::System.Windows.Controls.RatingItem)d;
			ratingItem.OnDisplayValueChanged((double)e.OldValue, (double)e.NewValue);
		}

		// Token: 0x06000157 RID: 343 RVA: 0x000065AC File Offset: 0x000047AC
		private void OnDisplayValueChanged(double oldValue, double newValue)
		{
			if (!this._settingDisplayValue)
			{
				this._settingDisplayValue = true;
				this.DisplayValue = oldValue;
				throw new global::System.InvalidOperationException(string.Format(global::System.Globalization.CultureInfo.CurrentUICulture, global::System.Windows.Controls.Properties.Resources.InvalidAttemptToChangeReadOnlyProperty, new object[]
				{
					"DisplayValue"
				}));
			}
			if (newValue <= 0.0)
			{
				global::System.Windows.Controls.VisualStates.GoToState(this, true, new string[]
				{
					"Empty"
				});
				return;
			}
			if (newValue >= 1.0)
			{
				global::System.Windows.Controls.VisualStates.GoToState(this, true, new string[]
				{
					"Filled"
				});
				return;
			}
			global::System.Windows.Controls.VisualStates.GoToState(this, true, new string[]
			{
				"Partial"
			});
		}

		// Token: 0x1700003B RID: 59
		// (get) Token: 0x06000158 RID: 344 RVA: 0x00006653 File Offset: 0x00004853
		// (set) Token: 0x06000159 RID: 345 RVA: 0x00006668 File Offset: 0x00004868
		public bool IsReadOnly
		{
			get
			{
				return (bool)base.GetValue(global::System.Windows.Controls.RatingItem.IsReadOnlyProperty);
			}
			internal set
			{
				this._settingIsReadOnly = true;
				try
				{
					base.SetValue(global::System.Windows.Controls.RatingItem.IsReadOnlyProperty, value);
				}
				finally
				{
					this._settingIsReadOnly = false;
				}
			}
		}

		// Token: 0x0600015A RID: 346 RVA: 0x000066A8 File Offset: 0x000048A8
		private static void OnIsReadOnlyChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::System.Windows.Controls.RatingItem ratingItem = (global::System.Windows.Controls.RatingItem)d;
			bool oldValue = (bool)e.OldValue;
			bool newValue = (bool)e.NewValue;
			ratingItem.OnIsReadOnlyChanged(oldValue, newValue);
		}

		// Token: 0x0600015B RID: 347 RVA: 0x000066E0 File Offset: 0x000048E0
		protected virtual void OnIsReadOnlyChanged(bool oldValue, bool newValue)
		{
			if (!this._settingIsReadOnly)
			{
				this._settingIsReadOnly = true;
				this.IsReadOnly = oldValue;
				throw new global::System.InvalidOperationException(string.Format(global::System.Globalization.CultureInfo.CurrentUICulture, global::System.Windows.Controls.Properties.Resources.InvalidAttemptToChangeReadOnlyProperty, new object[]
				{
					"IsReadOnly"
				}));
			}
			this._interactionHelper.OnIsReadOnlyChanged(newValue);
		}

		// Token: 0x1700003C RID: 60
		// (get) Token: 0x0600015C RID: 348 RVA: 0x00006734 File Offset: 0x00004934
		// (set) Token: 0x0600015D RID: 349 RVA: 0x0000673C File Offset: 0x0000493C
		internal global::System.Windows.Controls.Rating ParentRating { get; set; }

		// Token: 0x1700003D RID: 61
		// (get) Token: 0x0600015E RID: 350 RVA: 0x00006745 File Offset: 0x00004945
		// (set) Token: 0x0600015F RID: 351 RVA: 0x00006757 File Offset: 0x00004957
		internal double Value
		{
			get
			{
				return (double)base.GetValue(global::System.Windows.Controls.RatingItem.ValueProperty);
			}
			set
			{
				base.SetValue(global::System.Windows.Controls.RatingItem.ValueProperty, value);
			}
		}

		// Token: 0x06000160 RID: 352 RVA: 0x0000676A File Offset: 0x0000496A
		internal void SelectValue()
		{
			if (!this.IsReadOnly)
			{
				this.Value = 1.0;
				this.OnClick();
			}
		}

		// Token: 0x06000161 RID: 353 RVA: 0x0000678C File Offset: 0x0000498C
		static RatingItem()
		{
			global::System.Windows.FrameworkElement.DefaultStyleKeyProperty.OverrideMetadata(typeof(global::System.Windows.Controls.RatingItem), new global::System.Windows.FrameworkPropertyMetadata(typeof(global::System.Windows.Controls.RatingItem)));
		}

		// Token: 0x06000162 RID: 354 RVA: 0x0000686E File Offset: 0x00004A6E
		public RatingItem()
		{
			this._interactionHelper = new global::System.Windows.Controls.InteractionHelper(this);
		}

		// Token: 0x06000163 RID: 355 RVA: 0x00006882 File Offset: 0x00004A82
		protected override void OnMouseLeftButtonDown(global::System.Windows.Input.MouseButtonEventArgs e)
		{
			if (this._interactionHelper.AllowMouseLeftButtonDown(e))
			{
				this._interactionHelper.OnMouseLeftButtonDownBase();
			}
			base.OnMouseLeftButtonDown(e);
		}

		// Token: 0x06000164 RID: 356 RVA: 0x000068A4 File Offset: 0x00004AA4
		protected override void OnMouseLeftButtonUp(global::System.Windows.Input.MouseButtonEventArgs e)
		{
			if (this._interactionHelper.AllowMouseLeftButtonUp(e))
			{
				this._interactionHelper.OnMouseLeftButtonUpBase();
			}
			base.OnMouseLeftButtonUp(e);
		}

		// Token: 0x06000165 RID: 357 RVA: 0x000068C6 File Offset: 0x00004AC6
		protected override void OnMouseEnter(global::System.Windows.Input.MouseEventArgs e)
		{
			if (this._interactionHelper.AllowMouseEnter(e))
			{
				this._interactionHelper.UpdateVisualStateBase(true);
			}
			base.OnMouseEnter(e);
		}

		// Token: 0x06000166 RID: 358 RVA: 0x000068E9 File Offset: 0x00004AE9
		protected override void OnMouseLeave(global::System.Windows.Input.MouseEventArgs e)
		{
			if (this._interactionHelper.AllowMouseLeave(e))
			{
				this._interactionHelper.UpdateVisualStateBase(true);
			}
			base.OnMouseLeave(e);
		}

		// Token: 0x06000167 RID: 359 RVA: 0x0000690C File Offset: 0x00004B0C
		protected override void OnClick()
		{
			base.OnClick();
		}

		// Token: 0x06000168 RID: 360 RVA: 0x00006914 File Offset: 0x00004B14
		void global::System.Windows.Controls.IUpdateVisualState.UpdateVisualState(bool useTransitions)
		{
			this._interactionHelper.UpdateVisualStateBase(useTransitions);
		}

		// Token: 0x06000169 RID: 361 RVA: 0x00006922 File Offset: 0x00004B22
		protected override global::System.Windows.Automation.Peers.AutomationPeer OnCreateAutomationPeer()
		{
			return new global::System.Windows.Automation.Peers.RatingItemAutomationPeer(this);
		}

		// Token: 0x0400005B RID: 91
		private const string StateFilled = "Filled";

		// Token: 0x0400005C RID: 92
		private const string StateEmpty = "Empty";

		// Token: 0x0400005D RID: 93
		private const string GroupFill = "FillStates";

		// Token: 0x0400005E RID: 94
		private const string StatePartial = "Partial";

		// Token: 0x0400005F RID: 95
		private global::System.Windows.Controls.InteractionHelper _interactionHelper;

		// Token: 0x04000060 RID: 96
		private bool _settingDisplayValue;

		// Token: 0x04000061 RID: 97
		public static readonly global::System.Windows.DependencyProperty DisplayValueProperty = global::System.Windows.DependencyProperty.Register("DisplayValue", typeof(double), typeof(global::System.Windows.Controls.RatingItem), new global::System.Windows.PropertyMetadata(0.0, new global::System.Windows.PropertyChangedCallback(global::System.Windows.Controls.RatingItem.OnDisplayValueChanged)));

		// Token: 0x04000062 RID: 98
		private bool _settingIsReadOnly;

		// Token: 0x04000063 RID: 99
		public static readonly global::System.Windows.DependencyProperty IsReadOnlyProperty = global::System.Windows.DependencyProperty.Register("IsReadOnly", typeof(bool), typeof(global::System.Windows.Controls.RatingItem), new global::System.Windows.PropertyMetadata(false, new global::System.Windows.PropertyChangedCallback(global::System.Windows.Controls.RatingItem.OnIsReadOnlyChanged)));

		// Token: 0x04000064 RID: 100
		internal static readonly global::System.Windows.DependencyProperty ValueProperty = global::System.Windows.DependencyProperty.Register("Value", typeof(double), typeof(global::System.Windows.Controls.RatingItem), new global::System.Windows.PropertyMetadata(0.0));
	}
}
