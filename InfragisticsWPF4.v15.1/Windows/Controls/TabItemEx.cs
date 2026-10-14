using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Input;
using System.Windows.Media;
using Infragistics.Windows.Commands;
using Infragistics.Windows.Controls.Events;

namespace Infragistics.Windows.Controls
{
	// Token: 0x0200020F RID: 527
	[global::System.Windows.TemplateVisualState(Name = "Left_MouseOverTab", GroupName = "LocationStates")]
	[global::System.Windows.TemplateVisualState(Name = "Right_MouseOverTab", GroupName = "LocationStates")]
	[global::System.ComponentModel.DesignTimeVisible(false)]
	[global::System.Windows.TemplateVisualState(Name = "Bottom_MouseOverTab", GroupName = "LocationStates")]
	[global::System.Windows.TemplateVisualState(Name = "Top", GroupName = "LocationStates")]
	[global::System.Windows.TemplateVisualState(Name = "Bottom", GroupName = "LocationStates")]
	[global::System.Windows.TemplateVisualState(Name = "Left", GroupName = "LocationStates")]
	[global::System.Windows.TemplateVisualState(Name = "Right", GroupName = "LocationStates")]
	[global::System.Windows.TemplateVisualState(Name = "Top_MouseOverTab", GroupName = "LocationStates")]
	public class TabItemEx : global::System.Windows.Controls.TabItem, global::Infragistics.Windows.Commands.ICommandHost
	{
		// Token: 0x060013A4 RID: 5028 RVA: 0x00045608 File Offset: 0x00043808
		static TabItemEx()
		{
			global::Infragistics.Windows.Controls.TabItemEx.ExecutingCommandEvent = global::System.Windows.EventManager.RegisterRoutedEvent("ExecutingCommand", global::System.Windows.RoutingStrategy.Bubble, typeof(global::System.EventHandler<global::Infragistics.Windows.Controls.Events.ExecutingCommandEventArgs>), typeof(global::Infragistics.Windows.Controls.TabItemEx));
			global::Infragistics.Windows.Controls.TabItemEx.ExecutedCommandEvent = global::System.Windows.EventManager.RegisterRoutedEvent("ExecutedCommand", global::System.Windows.RoutingStrategy.Bubble, typeof(global::System.EventHandler<global::Infragistics.Windows.Controls.Events.ExecutedCommandEventArgs>), typeof(global::Infragistics.Windows.Controls.TabItemEx));
			global::Infragistics.Windows.Controls.TabItemEx.ClosingEvent = global::System.Windows.EventManager.RegisterRoutedEvent("Closing", global::System.Windows.RoutingStrategy.Bubble, typeof(global::System.EventHandler<global::Infragistics.Windows.Controls.Events.TabClosingEventArgs>), typeof(global::Infragistics.Windows.Controls.TabItemEx));
			global::Infragistics.Windows.Controls.TabItemEx.ClosedEvent = global::System.Windows.EventManager.RegisterRoutedEvent("Closed", global::System.Windows.RoutingStrategy.Bubble, typeof(global::System.Windows.RoutedEventHandler), typeof(global::Infragistics.Windows.Controls.TabItemEx));
			global::Infragistics.Windows.Controls.TabItemEx.TabControlVersionProperty = global::System.Windows.DependencyProperty.Register("TabControlVersion", typeof(int), typeof(global::Infragistics.Windows.Controls.TabItemEx), new global::System.Windows.FrameworkPropertyMetadata(0, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.Controls.TabItemEx.OnTabControlVersionChanged)));
			global::Infragistics.Windows.Controls.TabItemEx.AllowClosingProperty = global::System.Windows.DependencyProperty.Register("AllowClosing", typeof(bool?), typeof(global::Infragistics.Windows.Controls.TabItemEx), new global::System.Windows.FrameworkPropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.Controls.TabItemEx.OnAllowClosingChanged)));
			global::Infragistics.Windows.Controls.TabItemEx.CloseButtonVisibilityProperty = global::System.Windows.DependencyProperty.Register("CloseButtonVisibility", typeof(global::Infragistics.Windows.Controls.TabItemCloseButtonVisibility?), typeof(global::Infragistics.Windows.Controls.TabItemEx), new global::System.Windows.FrameworkPropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.Controls.TabItemEx.OnCloseButtonVisibilityChanged)));
			global::Infragistics.Windows.Controls.TabItemEx.ComputedCloseButtonVisibilityPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("ComputedCloseButtonVisibility", typeof(global::System.Windows.Visibility), typeof(global::Infragistics.Windows.Controls.TabItemEx), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.VisibilityCollapsedBox));
			global::Infragistics.Windows.Controls.TabItemEx.ComputedCloseButtonVisibilityProperty = global::Infragistics.Windows.Controls.TabItemEx.ComputedCloseButtonVisibilityPropertyKey.DependencyProperty;
			global::Infragistics.Windows.Controls.TabItemEx.IsMouseOverTabPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("IsMouseOverTab", typeof(bool), typeof(global::Infragistics.Windows.Controls.TabItemEx), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsRender, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.Controls.TabItemEx.OnIsMouseOverTabChanged)));
			global::Infragistics.Windows.Controls.TabItemEx.IsMouseOverTabProperty = global::Infragistics.Windows.Controls.TabItemEx.IsMouseOverTabPropertyKey.DependencyProperty;
			global::System.Windows.FrameworkElement.DefaultStyleKeyProperty.OverrideMetadata(typeof(global::Infragistics.Windows.Controls.TabItemEx), new global::System.Windows.FrameworkPropertyMetadata(typeof(global::Infragistics.Windows.Controls.TabItemEx)));
			global::System.Windows.EventManager.RegisterClassHandler(typeof(global::Infragistics.Windows.Controls.TabItemEx), global::System.Windows.Input.Mouse.GotMouseCaptureEvent, new global::System.Windows.Input.MouseEventHandler(global::Infragistics.Windows.Controls.TabItemEx.OnGotMouseCaptureWithin), true);
		}

		// Token: 0x060013A5 RID: 5029 RVA: 0x00045813 File Offset: 0x00043A13
		protected virtual void OnExecutingCommand(global::Infragistics.Windows.Controls.Events.ExecutingCommandEventArgs args)
		{
			base.RaiseEvent(args);
		}

		// Token: 0x060013A6 RID: 5030 RVA: 0x0004581C File Offset: 0x00043A1C
		internal bool RaiseExecutingCommand(global::Infragistics.Windows.Controls.Events.ExecutingCommandEventArgs args)
		{
			args.RoutedEvent = global::Infragistics.Windows.Controls.TabItemEx.ExecutingCommandEvent;
			args.Source = this;
			this.OnExecutingCommand(args);
			return !args.Cancel;
		}

		// Token: 0x14000027 RID: 39
		// (add) Token: 0x060013A7 RID: 5031 RVA: 0x00045840 File Offset: 0x00043A40
		// (remove) Token: 0x060013A8 RID: 5032 RVA: 0x0004584E File Offset: 0x00043A4E
		public event global::System.EventHandler<global::Infragistics.Windows.Controls.Events.ExecutingCommandEventArgs> ExecutingCommand
		{
			add
			{
				base.AddHandler(global::Infragistics.Windows.Controls.TabItemEx.ExecutingCommandEvent, value);
			}
			remove
			{
				base.RemoveHandler(global::Infragistics.Windows.Controls.TabItemEx.ExecutingCommandEvent, value);
			}
		}

		// Token: 0x060013A9 RID: 5033 RVA: 0x0004585C File Offset: 0x00043A5C
		protected virtual void OnExecutedCommand(global::Infragistics.Windows.Controls.Events.ExecutedCommandEventArgs args)
		{
			base.RaiseEvent(args);
		}

		// Token: 0x060013AA RID: 5034 RVA: 0x00045865 File Offset: 0x00043A65
		internal void RaiseExecutedCommand(global::Infragistics.Windows.Controls.Events.ExecutedCommandEventArgs args)
		{
			args.RoutedEvent = global::Infragistics.Windows.Controls.TabItemEx.ExecutedCommandEvent;
			args.Source = this;
			this.OnExecutedCommand(args);
		}

		// Token: 0x14000028 RID: 40
		// (add) Token: 0x060013AB RID: 5035 RVA: 0x00045880 File Offset: 0x00043A80
		// (remove) Token: 0x060013AC RID: 5036 RVA: 0x0004588E File Offset: 0x00043A8E
		public event global::System.EventHandler<global::Infragistics.Windows.Controls.Events.ExecutedCommandEventArgs> ExecutedCommand
		{
			add
			{
				base.AddHandler(global::Infragistics.Windows.Controls.TabItemEx.ExecutedCommandEvent, value);
			}
			remove
			{
				base.RemoveHandler(global::Infragistics.Windows.Controls.TabItemEx.ExecutedCommandEvent, value);
			}
		}

		// Token: 0x060013AD RID: 5037 RVA: 0x0004589C File Offset: 0x00043A9C
		protected override global::System.Windows.Size MeasureOverride(global::System.Windows.Size constraint)
		{
			global::System.Windows.Size result = base.MeasureOverride(constraint);
			this.ValidateTabControlBindings();
			return result;
		}

		// Token: 0x060013AE RID: 5038 RVA: 0x000458B8 File Offset: 0x00043AB8
		protected override void OnAccessKey(global::System.Windows.Input.AccessKeyEventArgs e)
		{
			if (!base.Focusable && !base.IsSelected)
			{
				global::Infragistics.DependencyPropertyUtilities.SetCurrentValue(this, global::System.Windows.Controls.TabItem.IsSelectedProperty, global::Infragistics.KnownBoxes.TrueBox);
				if (base.IsSelected)
				{
					base.BringIntoView();
					return;
				}
			}
			else
			{
				base.OnAccessKey(e);
			}
		}

		// Token: 0x060013AF RID: 5039 RVA: 0x000458F0 File Offset: 0x00043AF0
		public override void OnApplyTemplate()
		{
			base.OnApplyTemplate();
			this._hasVisualStateGroups = global::Infragistics.VisualStateUtilities.GetHasVisualStateGroups(this);
			this.UpdateVisualStates(false);
		}

		// Token: 0x060013B0 RID: 5040 RVA: 0x0004590B File Offset: 0x00043B0B
		protected override void OnKeyDown(global::System.Windows.Input.KeyEventArgs e)
		{
			base.OnKeyDown(e);
			if (!e.Handled && global::Infragistics.Windows.Controls.TabItemExCommands.Instance.ProcessKeyboardInput(e, this))
			{
				e.Handled = true;
			}
		}

		// Token: 0x060013B1 RID: 5041 RVA: 0x00045931 File Offset: 0x00043B31
		protected override void OnMouseEnter(global::System.Windows.Input.MouseEventArgs e)
		{
			base.OnMouseEnter(e);
			this.VerifyIsMouseOverTab(e);
		}

		// Token: 0x060013B2 RID: 5042 RVA: 0x00045941 File Offset: 0x00043B41
		protected override void OnMouseLeave(global::System.Windows.Input.MouseEventArgs e)
		{
			base.OnMouseLeave(e);
			this.VerifyIsMouseOverTab(e);
		}

		// Token: 0x060013B3 RID: 5043 RVA: 0x00045951 File Offset: 0x00043B51
		protected override void OnMouseLeftButtonDown(global::System.Windows.Input.MouseButtonEventArgs e)
		{
			if (!base.Focusable && !base.IsSelected)
			{
				global::Infragistics.DependencyPropertyUtilities.SetCurrentValue(this, global::System.Windows.Controls.TabItem.IsSelectedProperty, global::Infragistics.KnownBoxes.TrueBox);
				if (base.IsSelected)
				{
					base.BringIntoView();
				}
				e.Handled = true;
				return;
			}
			base.OnMouseLeftButtonDown(e);
		}

		// Token: 0x060013B4 RID: 5044 RVA: 0x00045990 File Offset: 0x00043B90
		protected override void OnMouseDown(global::System.Windows.Input.MouseButtonEventArgs e)
		{
			base.OnMouseDown(e);
			if (e.MiddleButton == global::System.Windows.Input.MouseButtonState.Pressed && this.AllowClosingResolved && this.IsMouseOverTab)
			{
				global::Infragistics.Windows.Controls.XamTabControl tabControl = this.TabControl;
				if (tabControl != null && tabControl.CloseTab(this))
				{
					e.Handled = true;
				}
			}
		}

		// Token: 0x060013B5 RID: 5045 RVA: 0x000459D7 File Offset: 0x00043BD7
		protected override void OnMouseMove(global::System.Windows.Input.MouseEventArgs e)
		{
			base.OnMouseMove(e);
			this.VerifyIsMouseOverTab(e);
		}

		// Token: 0x060013B6 RID: 5046 RVA: 0x000459E8 File Offset: 0x00043BE8
		protected override void OnPreviewGotKeyboardFocus(global::System.Windows.Input.KeyboardFocusChangedEventArgs e)
		{
			global::Infragistics.Windows.Controls.XamTabControl tabControl = this.TabControl;
			if (tabControl != null && tabControl.IsMinimized && !tabControl.IsDropDownOpen)
			{
				return;
			}
			base.OnPreviewGotKeyboardFocus(e);
		}

		// Token: 0x060013B7 RID: 5047 RVA: 0x00045A17 File Offset: 0x00043C17
		protected override void OnPropertyChanged(global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			base.OnPropertyChanged(e);
			if (e.Property == global::System.Windows.Controls.TabItem.TabStripPlacementProperty)
			{
				this.UpdateVisualStates();
			}
		}

		// Token: 0x060013B8 RID: 5048 RVA: 0x00045A34 File Offset: 0x00043C34
		protected override void OnSelected(global::System.Windows.RoutedEventArgs e)
		{
			base.OnSelected(e);
			this.ComputeCloseButtonVisibility();
		}

		// Token: 0x060013B9 RID: 5049 RVA: 0x00045A43 File Offset: 0x00043C43
		protected override void OnUnselected(global::System.Windows.RoutedEventArgs e)
		{
			base.OnUnselected(e);
			this.ComputeCloseButtonVisibility();
		}

		// Token: 0x060013BA RID: 5050 RVA: 0x00045A52 File Offset: 0x00043C52
		protected override void OnVisualParentChanged(global::System.Windows.DependencyObject oldParent)
		{
			base.OnVisualParentChanged(oldParent);
			this.ValidateTabControlBindings();
		}

		// Token: 0x060013BB RID: 5051 RVA: 0x00045A61 File Offset: 0x00043C61
		protected virtual void OnClosing(global::Infragistics.Windows.Controls.Events.TabClosingEventArgs args)
		{
			base.RaiseEvent(args);
		}

		// Token: 0x060013BC RID: 5052 RVA: 0x00045A6A File Offset: 0x00043C6A
		internal void RaiseClosing(global::Infragistics.Windows.Controls.Events.TabClosingEventArgs args)
		{
			args.RoutedEvent = global::Infragistics.Windows.Controls.TabItemEx.ClosingEvent;
			args.Source = this;
			this.OnClosing(args);
		}

		// Token: 0x14000029 RID: 41
		// (add) Token: 0x060013BD RID: 5053 RVA: 0x00045A85 File Offset: 0x00043C85
		// (remove) Token: 0x060013BE RID: 5054 RVA: 0x00045A93 File Offset: 0x00043C93
		public event global::System.EventHandler<global::Infragistics.Windows.Controls.Events.TabClosingEventArgs> Closing
		{
			add
			{
				base.AddHandler(global::Infragistics.Windows.Controls.TabItemEx.ClosingEvent, value);
			}
			remove
			{
				base.RemoveHandler(global::Infragistics.Windows.Controls.TabItemEx.ClosingEvent, value);
			}
		}

		// Token: 0x060013BF RID: 5055 RVA: 0x00045AA1 File Offset: 0x00043CA1
		protected virtual void OnClosed(global::System.Windows.RoutedEventArgs args)
		{
			base.RaiseEvent(args);
		}

		// Token: 0x060013C0 RID: 5056 RVA: 0x00045AAC File Offset: 0x00043CAC
		internal void RaiseClosed()
		{
			this.OnClosed(new global::System.Windows.RoutedEventArgs
			{
				RoutedEvent = global::Infragistics.Windows.Controls.TabItemEx.ClosedEvent,
				Source = this
			});
		}

		// Token: 0x1400002A RID: 42
		// (add) Token: 0x060013C1 RID: 5057 RVA: 0x00045AD8 File Offset: 0x00043CD8
		// (remove) Token: 0x060013C2 RID: 5058 RVA: 0x00045AE6 File Offset: 0x00043CE6
		public event global::System.Windows.RoutedEventHandler Closed
		{
			add
			{
				base.AddHandler(global::Infragistics.Windows.Controls.TabItemEx.ClosedEvent, value);
			}
			remove
			{
				base.RemoveHandler(global::Infragistics.Windows.Controls.TabItemEx.ClosedEvent, value);
			}
		}

		// Token: 0x17000480 RID: 1152
		// (get) Token: 0x060013C3 RID: 5059 RVA: 0x00045AF4 File Offset: 0x00043CF4
		internal bool AllowClosingResolved
		{
			get
			{
				bool? flag = this.AllowClosing;
				if (flag != null)
				{
					return flag.Value;
				}
				global::Infragistics.Windows.Controls.TabItemCloseButtonVisibility? closeButtonVisibility = this.CloseButtonVisibility;
				if (closeButtonVisibility != null)
				{
					return closeButtonVisibility.Value != global::Infragistics.Windows.Controls.TabItemCloseButtonVisibility.Hidden;
				}
				global::Infragistics.Windows.Controls.XamTabControl tabControl = this.TabControl;
				if (tabControl == null)
				{
					return false;
				}
				flag = tabControl.AllowTabClosing;
				if (flag != null)
				{
					return flag.Value;
				}
				return tabControl.TabItemCloseButtonVisibility != global::Infragistics.Windows.Controls.TabItemCloseButtonVisibility.Hidden || tabControl.ShowTabHeaderCloseButton;
			}
		}

		// Token: 0x060013C4 RID: 5060 RVA: 0x00045B6C File Offset: 0x00043D6C
		private static void OnTabControlVersionChanged(global::System.Windows.DependencyObject target, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.Controls.TabItemEx tabItemEx = target as global::Infragistics.Windows.Controls.TabItemEx;
			if (tabItemEx != null)
			{
				tabItemEx.ComputeCloseButtonVisibility();
			}
		}

		// Token: 0x17000481 RID: 1153
		// (get) Token: 0x060013C5 RID: 5061 RVA: 0x00045B89 File Offset: 0x00043D89
		// (set) Token: 0x060013C6 RID: 5062 RVA: 0x00045B9B File Offset: 0x00043D9B
		internal int TabControlVersion
		{
			get
			{
				return (int)base.GetValue(global::Infragistics.Windows.Controls.TabItemEx.TabControlVersionProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.Controls.TabItemEx.TabControlVersionProperty, value);
			}
		}

		// Token: 0x17000482 RID: 1154
		// (get) Token: 0x060013C7 RID: 5063 RVA: 0x00045BAE File Offset: 0x00043DAE
		private global::Infragistics.Windows.Controls.XamTabControl TabControl
		{
			get
			{
				return global::System.Windows.Controls.ItemsControl.ItemsControlFromItemContainer(this) as global::Infragistics.Windows.Controls.XamTabControl;
			}
		}

		// Token: 0x060013C8 RID: 5064 RVA: 0x00045BBC File Offset: 0x00043DBC
		private static void OnAllowClosingChanged(global::System.Windows.DependencyObject target, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.Controls.TabItemEx tabItemEx = target as global::Infragistics.Windows.Controls.TabItemEx;
			if (tabItemEx != null)
			{
				tabItemEx.ComputeCloseButtonVisibility();
			}
		}

		// Token: 0x17000483 RID: 1155
		// (get) Token: 0x060013C9 RID: 5065 RVA: 0x00045BD9 File Offset: 0x00043DD9
		// (set) Token: 0x060013CA RID: 5066 RVA: 0x00045BEB File Offset: 0x00043DEB
		public bool? AllowClosing
		{
			get
			{
				return (bool?)base.GetValue(global::Infragistics.Windows.Controls.TabItemEx.AllowClosingProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.Controls.TabItemEx.AllowClosingProperty, value);
			}
		}

		// Token: 0x060013CB RID: 5067 RVA: 0x00045C00 File Offset: 0x00043E00
		private static void OnCloseButtonVisibilityChanged(global::System.Windows.DependencyObject target, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.Controls.TabItemEx tabItemEx = target as global::Infragistics.Windows.Controls.TabItemEx;
			if (tabItemEx != null)
			{
				tabItemEx.ComputeCloseButtonVisibility();
			}
		}

		// Token: 0x17000484 RID: 1156
		// (get) Token: 0x060013CC RID: 5068 RVA: 0x00045C1D File Offset: 0x00043E1D
		// (set) Token: 0x060013CD RID: 5069 RVA: 0x00045C2F File Offset: 0x00043E2F
		public global::Infragistics.Windows.Controls.TabItemCloseButtonVisibility? CloseButtonVisibility
		{
			get
			{
				return (global::Infragistics.Windows.Controls.TabItemCloseButtonVisibility?)base.GetValue(global::Infragistics.Windows.Controls.TabItemEx.CloseButtonVisibilityProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.Controls.TabItemEx.CloseButtonVisibilityProperty, value);
			}
		}

		// Token: 0x17000485 RID: 1157
		// (get) Token: 0x060013CE RID: 5070 RVA: 0x00045C42 File Offset: 0x00043E42
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.ReadOnly(true)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		public global::System.Windows.Visibility ComputedCloseButtonVisibility
		{
			get
			{
				return (global::System.Windows.Visibility)base.GetValue(global::Infragistics.Windows.Controls.TabItemEx.ComputedCloseButtonVisibilityProperty);
			}
		}

		// Token: 0x060013CF RID: 5071 RVA: 0x00045C54 File Offset: 0x00043E54
		private static void OnIsMouseOverTabChanged(global::System.Windows.DependencyObject target, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.Controls.TabItemEx tabItemEx = target as global::Infragistics.Windows.Controls.TabItemEx;
			if (tabItemEx != null)
			{
				tabItemEx.ComputeCloseButtonVisibility();
				tabItemEx.UpdateVisualStates();
			}
		}

		// Token: 0x17000486 RID: 1158
		// (get) Token: 0x060013D0 RID: 5072 RVA: 0x00045C77 File Offset: 0x00043E77
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.ReadOnly(true)]
		public bool IsMouseOverTab
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.Windows.Controls.TabItemEx.IsMouseOverTabProperty);
			}
		}

		// Token: 0x060013D1 RID: 5073 RVA: 0x00045C89 File Offset: 0x00043E89
		public bool ExecuteCommand(global::System.Windows.Input.RoutedCommand command)
		{
			return this.ExecuteCommandImpl(new global::Infragistics.Windows.Commands.ExecuteCommandInfo(command));
		}

		// Token: 0x060013D2 RID: 5074 RVA: 0x00045C98 File Offset: 0x00043E98
		private void ComputeCloseButtonVisibility()
		{
			global::System.Windows.Visibility visibility = global::System.Windows.Visibility.Collapsed;
			if (this.AllowClosingResolved)
			{
				global::Infragistics.Windows.Controls.TabItemCloseButtonVisibility? closeButtonVisibility = this.CloseButtonVisibility;
				if (closeButtonVisibility == null)
				{
					global::Infragistics.Windows.Controls.XamTabControl tabControl = this.TabControl;
					if (tabControl != null)
					{
						closeButtonVisibility = new global::Infragistics.Windows.Controls.TabItemCloseButtonVisibility?(this.TabControl.TabItemCloseButtonVisibility);
					}
				}
				if (closeButtonVisibility != null)
				{
					switch (closeButtonVisibility.Value)
					{
					case global::Infragistics.Windows.Controls.TabItemCloseButtonVisibility.Visible:
						visibility = global::System.Windows.Visibility.Visible;
						break;
					case global::Infragistics.Windows.Controls.TabItemCloseButtonVisibility.WhenSelected:
						visibility = (base.IsSelected ? global::System.Windows.Visibility.Visible : global::System.Windows.Visibility.Hidden);
						break;
					case global::Infragistics.Windows.Controls.TabItemCloseButtonVisibility.WhenSelectedOrHotTracked:
						visibility = ((base.IsSelected || this.IsMouseOverTab) ? global::System.Windows.Visibility.Visible : global::System.Windows.Visibility.Hidden);
						break;
					}
				}
			}
			base.SetValue(global::Infragistics.Windows.Controls.TabItemEx.ComputedCloseButtonVisibilityPropertyKey, visibility);
		}

		// Token: 0x060013D3 RID: 5075 RVA: 0x00045D3C File Offset: 0x00043F3C
		private bool ExecuteCommandImpl(global::Infragistics.Windows.Commands.ExecuteCommandInfo commandInfo)
		{
			global::System.Windows.Input.RoutedCommand routedCommand = commandInfo.RoutedCommand;
			global::Infragistics.Windows.Utilities.ThrowIfNull(routedCommand, "command");
			if (!global::Infragistics.Windows.Commands.Commands<global::Infragistics.Windows.Controls.TabItemEx>.IsMinimumStatePresentForCommand(this, routedCommand))
			{
				return false;
			}
			if (!((global::Infragistics.Windows.Commands.ICommandHost)this).CanExecute(commandInfo))
			{
				return false;
			}
			global::Infragistics.Windows.Controls.Events.ExecutingCommandEventArgs executingCommandEventArgs = new global::Infragistics.Windows.Controls.Events.ExecutingCommandEventArgs(routedCommand);
			if (!this.RaiseExecutingCommand(executingCommandEventArgs))
			{
				return !executingCommandEventArgs.ContinueKeyRouting;
			}
			bool flag = false;
			global::Infragistics.Windows.Controls.XamTabControl tabControl = this.TabControl;
			if (tabControl != null)
			{
				if (routedCommand == global::Infragistics.Windows.Controls.TabItemExCommands.Close)
				{
					flag = tabControl.CloseTab(this);
				}
				if (routedCommand == global::Infragistics.Windows.Controls.TabItemExCommands.CloseAllButThis)
				{
					flag = tabControl.CloseAllTabs(this);
				}
			}
			if (flag)
			{
				this.RaiseExecutedCommand(new global::Infragistics.Windows.Controls.Events.ExecutedCommandEventArgs(routedCommand));
			}
			return flag;
		}

		// Token: 0x060013D4 RID: 5076 RVA: 0x00045DCD File Offset: 0x00043FCD
		private static void OnGotMouseCaptureWithin(object sender, global::System.Windows.Input.MouseEventArgs e)
		{
			((global::Infragistics.Windows.Controls.TabItemEx)sender).VerifyIsMouseOverTab(e);
		}

		// Token: 0x060013D5 RID: 5077 RVA: 0x00045DDC File Offset: 0x00043FDC
		private void ValidateTabControlBindings()
		{
			global::Infragistics.Windows.Controls.XamTabControl tabControl = this.TabControl;
			if (tabControl != null)
			{
				if (this._bindingsSetWithTabControl != tabControl)
				{
					this._bindingsSetWithTabControl = tabControl;
					base.SetBinding(global::Infragistics.Windows.Controls.TabItemEx.TabControlVersionProperty, global::Infragistics.Windows.Utilities.CreateBindingObject(global::Infragistics.Windows.Controls.XamTabControl.InternalVersionProperty, global::System.Windows.Data.BindingMode.OneWay, tabControl));
					return;
				}
			}
			else if (this._bindingsSetWithTabControl != null)
			{
				this._bindingsSetWithTabControl = null;
				global::System.Windows.Data.BindingOperations.ClearBinding(this, global::Infragistics.Windows.Controls.TabItemEx.TabControlVersionProperty);
			}
		}

		// Token: 0x060013D6 RID: 5078 RVA: 0x00045E38 File Offset: 0x00044038
		private void VerifyIsMouseOverTab(global::System.Windows.Input.MouseEventArgs e)
		{
			if (global::System.Windows.Input.Mouse.Captured != null && !base.IsMouseCaptureWithin)
			{
				base.ClearValue(global::Infragistics.Windows.Controls.TabItemEx.IsMouseOverTabPropertyKey);
				return;
			}
			if (!base.IsMouseOver)
			{
				base.ClearValue(global::Infragistics.Windows.Controls.TabItemEx.IsMouseOverTabPropertyKey);
				return;
			}
			global::System.Windows.Media.HitTestResult hitTestResult = global::System.Windows.Media.VisualTreeHelper.HitTest(this, e.GetPosition(this));
			if (hitTestResult != null && hitTestResult.VisualHit != null)
			{
				base.SetValue(global::Infragistics.Windows.Controls.TabItemEx.IsMouseOverTabPropertyKey, global::Infragistics.KnownBoxes.TrueBox);
				return;
			}
			base.ClearValue(global::Infragistics.Windows.Controls.TabItemEx.IsMouseOverTabPropertyKey);
		}

		// Token: 0x060013D7 RID: 5079 RVA: 0x00045EAC File Offset: 0x000440AC
		protected virtual void SetVisualState(bool useTransitions)
		{
			if (this.IsMouseOverTab)
			{
				switch (base.TabStripPlacement)
				{
				case global::System.Windows.Controls.Dock.Left:
					global::Infragistics.VisualStateUtilities.GoToState(this, useTransitions, new string[]
					{
						"Left_MouseOverTab",
						"Left"
					});
					return;
				case global::System.Windows.Controls.Dock.Top:
					global::Infragistics.VisualStateUtilities.GoToState(this, useTransitions, new string[]
					{
						"Top_MouseOverTab",
						"Top"
					});
					return;
				case global::System.Windows.Controls.Dock.Right:
					global::Infragistics.VisualStateUtilities.GoToState(this, useTransitions, new string[]
					{
						"Right_MouseOverTab",
						"Right"
					});
					return;
				case global::System.Windows.Controls.Dock.Bottom:
					global::Infragistics.VisualStateUtilities.GoToState(this, useTransitions, new string[]
					{
						"Bottom_MouseOverTab",
						"Bottom"
					});
					return;
				default:
					return;
				}
			}
			else
			{
				switch (base.TabStripPlacement)
				{
				case global::System.Windows.Controls.Dock.Left:
					global::System.Windows.VisualStateManager.GoToState(this, "Left", useTransitions);
					return;
				case global::System.Windows.Controls.Dock.Top:
					global::System.Windows.VisualStateManager.GoToState(this, "Top", useTransitions);
					return;
				case global::System.Windows.Controls.Dock.Right:
					global::System.Windows.VisualStateManager.GoToState(this, "Right", useTransitions);
					return;
				case global::System.Windows.Controls.Dock.Bottom:
					global::System.Windows.VisualStateManager.GoToState(this, "Bottom", useTransitions);
					return;
				default:
					return;
				}
			}
		}

		// Token: 0x060013D8 RID: 5080 RVA: 0x00045FC0 File Offset: 0x000441C0
		private static void OnVisualStatePropertyChanged(global::System.Windows.DependencyObject target, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.Controls.TabItemEx tabItemEx = target as global::Infragistics.Windows.Controls.TabItemEx;
			tabItemEx.UpdateVisualStates();
		}

		// Token: 0x060013D9 RID: 5081 RVA: 0x00045FDA File Offset: 0x000441DA
		protected void UpdateVisualStates()
		{
			this.UpdateVisualStates(true);
		}

		// Token: 0x060013DA RID: 5082 RVA: 0x00045FE3 File Offset: 0x000441E3
		protected void UpdateVisualStates(bool useTransitions)
		{
			if (!this._hasVisualStateGroups)
			{
				return;
			}
			if (!base.IsLoaded)
			{
				useTransitions = false;
			}
			this.SetVisualState(useTransitions);
		}

		// Token: 0x060013DB RID: 5083 RVA: 0x00046000 File Offset: 0x00044200
		internal bool Close()
		{
			if (base.Visibility == global::System.Windows.Visibility.Collapsed)
			{
				return false;
			}
			if (!this.AllowClosingResolved)
			{
				return false;
			}
			global::Infragistics.Windows.Controls.Events.TabClosingEventArgs tabClosingEventArgs = new global::Infragistics.Windows.Controls.Events.TabClosingEventArgs();
			this.RaiseClosing(tabClosingEventArgs);
			if (tabClosingEventArgs.Cancel)
			{
				return false;
			}
			base.Visibility = global::System.Windows.Visibility.Collapsed;
			this.RaiseClosed();
			return base.Visibility == global::System.Windows.Visibility.Collapsed;
		}

		// Token: 0x060013DC RID: 5084 RVA: 0x00046050 File Offset: 0x00044250
		bool global::Infragistics.Windows.Commands.ICommandHost.Execute(global::Infragistics.Windows.Commands.ExecuteCommandInfo commandInfo)
		{
			global::System.Windows.Input.RoutedCommand routedCommand = commandInfo.RoutedCommand;
			return routedCommand != null && this.ExecuteCommandImpl(commandInfo);
		}

		// Token: 0x060013DD RID: 5085 RVA: 0x00046070 File Offset: 0x00044270
		long global::Infragistics.Windows.Commands.ICommandHost.GetCurrentState(long statesToQuery)
		{
			global::Infragistics.Windows.Controls.TabItemExStates tabItemExStates = (global::Infragistics.Windows.Controls.TabItemExStates)0L;
			if (this.AllowClosingResolved)
			{
				tabItemExStates |= global::Infragistics.Windows.Controls.TabItemExStates.AllowsClosing;
			}
			if (base.IsSelected)
			{
				tabItemExStates |= global::Infragistics.Windows.Controls.TabItemExStates.SelectedTab;
			}
			return (long)(tabItemExStates & (global::Infragistics.Windows.Controls.TabItemExStates)statesToQuery);
		}

		// Token: 0x060013DE RID: 5086 RVA: 0x000460A0 File Offset: 0x000442A0
		bool global::Infragistics.Windows.Commands.ICommandHost.CanExecute(global::Infragistics.Windows.Commands.ExecuteCommandInfo commandInfo)
		{
			global::System.Windows.Input.RoutedCommand routedCommand = commandInfo.RoutedCommand;
			if (routedCommand == null)
			{
				return false;
			}
			if (routedCommand == global::Infragistics.Windows.Controls.TabItemExCommands.Close)
			{
				return this.AllowClosingResolved;
			}
			return routedCommand == global::Infragistics.Windows.Controls.TabItemExCommands.CloseAllButThis;
		}

		// Token: 0x04000A78 RID: 2680
		private global::Infragistics.Windows.Controls.XamTabControl _bindingsSetWithTabControl;

		// Token: 0x04000A79 RID: 2681
		private bool _hasVisualStateGroups;

		// Token: 0x04000A7E RID: 2686
		internal static readonly global::System.Windows.DependencyProperty TabControlVersionProperty;

		// Token: 0x04000A7F RID: 2687
		public static readonly global::System.Windows.DependencyProperty AllowClosingProperty;

		// Token: 0x04000A80 RID: 2688
		public static readonly global::System.Windows.DependencyProperty CloseButtonVisibilityProperty;

		// Token: 0x04000A81 RID: 2689
		private static readonly global::System.Windows.DependencyPropertyKey ComputedCloseButtonVisibilityPropertyKey;

		// Token: 0x04000A82 RID: 2690
		public static readonly global::System.Windows.DependencyProperty ComputedCloseButtonVisibilityProperty;

		// Token: 0x04000A83 RID: 2691
		private static readonly global::System.Windows.DependencyPropertyKey IsMouseOverTabPropertyKey;

		// Token: 0x04000A84 RID: 2692
		public static readonly global::System.Windows.DependencyProperty IsMouseOverTabProperty;
	}
}
