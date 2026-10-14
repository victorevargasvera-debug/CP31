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
	// Token: 0x020001E1 RID: 481
	[global::System.Windows.TemplateVisualState(Name = "Right_MouseOverTab", GroupName = "LocationStates")]
	[global::System.Windows.TemplateVisualState(Name = "Top", GroupName = "LocationStates")]
	[global::System.Windows.TemplateVisualState(Name = "Bottom", GroupName = "LocationStates")]
	[global::System.Windows.TemplateVisualState(Name = "Left", GroupName = "LocationStates")]
	[global::System.Windows.TemplateVisualState(Name = "Right", GroupName = "LocationStates")]
	[global::System.Windows.TemplateVisualState(Name = "Top_MouseOverTab", GroupName = "LocationStates")]
	[global::System.Windows.TemplateVisualState(Name = "Bottom_MouseOverTab", GroupName = "LocationStates")]
	[global::System.ComponentModel.DesignTimeVisible(false)]
	[global::System.Windows.TemplateVisualState(Name = "Left_MouseOverTab", GroupName = "LocationStates")]
	public class TabItemEx : global::System.Windows.Controls.TabItem, global::Infragistics.Windows.Commands.ICommandHost
	{
		// Token: 0x060011D0 RID: 4560 RVA: 0x0003FD60 File Offset: 0x0003DF60
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

		// Token: 0x060011D1 RID: 4561 RVA: 0x0003FF6B File Offset: 0x0003E16B
		protected virtual void OnExecutingCommand(global::Infragistics.Windows.Controls.Events.ExecutingCommandEventArgs args)
		{
			base.RaiseEvent(args);
		}

		// Token: 0x060011D2 RID: 4562 RVA: 0x0003FF74 File Offset: 0x0003E174
		internal bool RaiseExecutingCommand(global::Infragistics.Windows.Controls.Events.ExecutingCommandEventArgs args)
		{
			args.RoutedEvent = global::Infragistics.Windows.Controls.TabItemEx.ExecutingCommandEvent;
			args.Source = this;
			this.OnExecutingCommand(args);
			return !args.Cancel;
		}

		// Token: 0x14000025 RID: 37
		// (add) Token: 0x060011D3 RID: 4563 RVA: 0x0003FF98 File Offset: 0x0003E198
		// (remove) Token: 0x060011D4 RID: 4564 RVA: 0x0003FFA6 File Offset: 0x0003E1A6
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

		// Token: 0x060011D5 RID: 4565 RVA: 0x0003FFB4 File Offset: 0x0003E1B4
		protected virtual void OnExecutedCommand(global::Infragistics.Windows.Controls.Events.ExecutedCommandEventArgs args)
		{
			base.RaiseEvent(args);
		}

		// Token: 0x060011D6 RID: 4566 RVA: 0x0003FFBD File Offset: 0x0003E1BD
		internal void RaiseExecutedCommand(global::Infragistics.Windows.Controls.Events.ExecutedCommandEventArgs args)
		{
			args.RoutedEvent = global::Infragistics.Windows.Controls.TabItemEx.ExecutedCommandEvent;
			args.Source = this;
			this.OnExecutedCommand(args);
		}

		// Token: 0x14000026 RID: 38
		// (add) Token: 0x060011D7 RID: 4567 RVA: 0x0003FFD8 File Offset: 0x0003E1D8
		// (remove) Token: 0x060011D8 RID: 4568 RVA: 0x0003FFE6 File Offset: 0x0003E1E6
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

		// Token: 0x060011D9 RID: 4569 RVA: 0x0003FFF4 File Offset: 0x0003E1F4
		protected override global::System.Windows.Size MeasureOverride(global::System.Windows.Size constraint)
		{
			global::System.Windows.Size result = base.MeasureOverride(constraint);
			this.ValidateTabControlBindings();
			return result;
		}

		// Token: 0x060011DA RID: 4570 RVA: 0x00040010 File Offset: 0x0003E210
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

		// Token: 0x060011DB RID: 4571 RVA: 0x00040048 File Offset: 0x0003E248
		public override void OnApplyTemplate()
		{
			base.OnApplyTemplate();
			this._hasVisualStateGroups = global::Infragistics.VisualStateUtilities.GetHasVisualStateGroups(this);
			this.UpdateVisualStates(false);
		}

		// Token: 0x060011DC RID: 4572 RVA: 0x00040063 File Offset: 0x0003E263
		protected override void OnKeyDown(global::System.Windows.Input.KeyEventArgs e)
		{
			base.OnKeyDown(e);
			if (!e.Handled && global::Infragistics.Windows.Controls.TabItemExCommands.Instance.ProcessKeyboardInput(e, this))
			{
				e.Handled = true;
			}
		}

		// Token: 0x060011DD RID: 4573 RVA: 0x00040089 File Offset: 0x0003E289
		protected override void OnMouseEnter(global::System.Windows.Input.MouseEventArgs e)
		{
			base.OnMouseEnter(e);
			this.VerifyIsMouseOverTab(e);
		}

		// Token: 0x060011DE RID: 4574 RVA: 0x00040099 File Offset: 0x0003E299
		protected override void OnMouseLeave(global::System.Windows.Input.MouseEventArgs e)
		{
			base.OnMouseLeave(e);
			this.VerifyIsMouseOverTab(e);
		}

		// Token: 0x060011DF RID: 4575 RVA: 0x000400A9 File Offset: 0x0003E2A9
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

		// Token: 0x060011E0 RID: 4576 RVA: 0x000400E8 File Offset: 0x0003E2E8
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

		// Token: 0x060011E1 RID: 4577 RVA: 0x0004012F File Offset: 0x0003E32F
		protected override void OnMouseMove(global::System.Windows.Input.MouseEventArgs e)
		{
			base.OnMouseMove(e);
			this.VerifyIsMouseOverTab(e);
		}

		// Token: 0x060011E2 RID: 4578 RVA: 0x00040140 File Offset: 0x0003E340
		protected override void OnPreviewGotKeyboardFocus(global::System.Windows.Input.KeyboardFocusChangedEventArgs e)
		{
			global::Infragistics.Windows.Controls.XamTabControl tabControl = this.TabControl;
			if (tabControl != null && tabControl.IsMinimized && !tabControl.IsDropDownOpen)
			{
				return;
			}
			base.OnPreviewGotKeyboardFocus(e);
		}

		// Token: 0x060011E3 RID: 4579 RVA: 0x0004016F File Offset: 0x0003E36F
		protected override void OnPropertyChanged(global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			base.OnPropertyChanged(e);
			if (e.Property == global::System.Windows.Controls.TabItem.TabStripPlacementProperty)
			{
				this.UpdateVisualStates();
			}
		}

		// Token: 0x060011E4 RID: 4580 RVA: 0x0004018C File Offset: 0x0003E38C
		protected override void OnSelected(global::System.Windows.RoutedEventArgs e)
		{
			base.OnSelected(e);
			this.ComputeCloseButtonVisibility();
		}

		// Token: 0x060011E5 RID: 4581 RVA: 0x0004019B File Offset: 0x0003E39B
		protected override void OnUnselected(global::System.Windows.RoutedEventArgs e)
		{
			base.OnUnselected(e);
			this.ComputeCloseButtonVisibility();
		}

		// Token: 0x060011E6 RID: 4582 RVA: 0x000401AA File Offset: 0x0003E3AA
		protected override void OnVisualParentChanged(global::System.Windows.DependencyObject oldParent)
		{
			base.OnVisualParentChanged(oldParent);
			this.ValidateTabControlBindings();
		}

		// Token: 0x060011E7 RID: 4583 RVA: 0x000401B9 File Offset: 0x0003E3B9
		protected virtual void OnClosing(global::Infragistics.Windows.Controls.Events.TabClosingEventArgs args)
		{
			base.RaiseEvent(args);
		}

		// Token: 0x060011E8 RID: 4584 RVA: 0x000401C2 File Offset: 0x0003E3C2
		internal void RaiseClosing(global::Infragistics.Windows.Controls.Events.TabClosingEventArgs args)
		{
			args.RoutedEvent = global::Infragistics.Windows.Controls.TabItemEx.ClosingEvent;
			args.Source = this;
			this.OnClosing(args);
		}

		// Token: 0x14000027 RID: 39
		// (add) Token: 0x060011E9 RID: 4585 RVA: 0x000401DD File Offset: 0x0003E3DD
		// (remove) Token: 0x060011EA RID: 4586 RVA: 0x000401EB File Offset: 0x0003E3EB
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

		// Token: 0x060011EB RID: 4587 RVA: 0x000401F9 File Offset: 0x0003E3F9
		protected virtual void OnClosed(global::System.Windows.RoutedEventArgs args)
		{
			base.RaiseEvent(args);
		}

		// Token: 0x060011EC RID: 4588 RVA: 0x00040204 File Offset: 0x0003E404
		internal void RaiseClosed()
		{
			this.OnClosed(new global::System.Windows.RoutedEventArgs
			{
				RoutedEvent = global::Infragistics.Windows.Controls.TabItemEx.ClosedEvent,
				Source = this
			});
		}

		// Token: 0x14000028 RID: 40
		// (add) Token: 0x060011ED RID: 4589 RVA: 0x00040230 File Offset: 0x0003E430
		// (remove) Token: 0x060011EE RID: 4590 RVA: 0x0004023E File Offset: 0x0003E43E
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

		// Token: 0x1700040D RID: 1037
		// (get) Token: 0x060011EF RID: 4591 RVA: 0x0004024C File Offset: 0x0003E44C
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

		// Token: 0x060011F0 RID: 4592 RVA: 0x000402C4 File Offset: 0x0003E4C4
		private static void OnTabControlVersionChanged(global::System.Windows.DependencyObject target, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.Controls.TabItemEx tabItemEx = target as global::Infragistics.Windows.Controls.TabItemEx;
			if (tabItemEx != null)
			{
				tabItemEx.ComputeCloseButtonVisibility();
			}
		}

		// Token: 0x1700040E RID: 1038
		// (get) Token: 0x060011F1 RID: 4593 RVA: 0x000402E1 File Offset: 0x0003E4E1
		// (set) Token: 0x060011F2 RID: 4594 RVA: 0x000402F3 File Offset: 0x0003E4F3
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

		// Token: 0x1700040F RID: 1039
		// (get) Token: 0x060011F3 RID: 4595 RVA: 0x00040306 File Offset: 0x0003E506
		private global::Infragistics.Windows.Controls.XamTabControl TabControl
		{
			get
			{
				return global::System.Windows.Controls.ItemsControl.ItemsControlFromItemContainer(this) as global::Infragistics.Windows.Controls.XamTabControl;
			}
		}

		// Token: 0x060011F4 RID: 4596 RVA: 0x00040314 File Offset: 0x0003E514
		private static void OnAllowClosingChanged(global::System.Windows.DependencyObject target, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.Controls.TabItemEx tabItemEx = target as global::Infragistics.Windows.Controls.TabItemEx;
			if (tabItemEx != null)
			{
				tabItemEx.ComputeCloseButtonVisibility();
			}
		}

		// Token: 0x17000410 RID: 1040
		// (get) Token: 0x060011F5 RID: 4597 RVA: 0x00040331 File Offset: 0x0003E531
		// (set) Token: 0x060011F6 RID: 4598 RVA: 0x00040343 File Offset: 0x0003E543
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

		// Token: 0x060011F7 RID: 4599 RVA: 0x00040358 File Offset: 0x0003E558
		private static void OnCloseButtonVisibilityChanged(global::System.Windows.DependencyObject target, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.Controls.TabItemEx tabItemEx = target as global::Infragistics.Windows.Controls.TabItemEx;
			if (tabItemEx != null)
			{
				tabItemEx.ComputeCloseButtonVisibility();
			}
		}

		// Token: 0x17000411 RID: 1041
		// (get) Token: 0x060011F8 RID: 4600 RVA: 0x00040375 File Offset: 0x0003E575
		// (set) Token: 0x060011F9 RID: 4601 RVA: 0x00040387 File Offset: 0x0003E587
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

		// Token: 0x17000412 RID: 1042
		// (get) Token: 0x060011FA RID: 4602 RVA: 0x0004039A File Offset: 0x0003E59A
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.ReadOnly(true)]
		public global::System.Windows.Visibility ComputedCloseButtonVisibility
		{
			get
			{
				return (global::System.Windows.Visibility)base.GetValue(global::Infragistics.Windows.Controls.TabItemEx.ComputedCloseButtonVisibilityProperty);
			}
		}

		// Token: 0x060011FB RID: 4603 RVA: 0x000403AC File Offset: 0x0003E5AC
		private static void OnIsMouseOverTabChanged(global::System.Windows.DependencyObject target, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.Controls.TabItemEx tabItemEx = target as global::Infragistics.Windows.Controls.TabItemEx;
			if (tabItemEx != null)
			{
				tabItemEx.ComputeCloseButtonVisibility();
				tabItemEx.UpdateVisualStates();
			}
		}

		// Token: 0x17000413 RID: 1043
		// (get) Token: 0x060011FC RID: 4604 RVA: 0x000403CF File Offset: 0x0003E5CF
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.ReadOnly(true)]
		public bool IsMouseOverTab
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.Windows.Controls.TabItemEx.IsMouseOverTabProperty);
			}
		}

		// Token: 0x060011FD RID: 4605 RVA: 0x000403E1 File Offset: 0x0003E5E1
		public bool ExecuteCommand(global::System.Windows.Input.RoutedCommand command)
		{
			return this.ExecuteCommandImpl(new global::Infragistics.Windows.Commands.ExecuteCommandInfo(command));
		}

		// Token: 0x060011FE RID: 4606 RVA: 0x000403F0 File Offset: 0x0003E5F0
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

		// Token: 0x060011FF RID: 4607 RVA: 0x00040494 File Offset: 0x0003E694
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

		// Token: 0x06001200 RID: 4608 RVA: 0x00040525 File Offset: 0x0003E725
		private static void OnGotMouseCaptureWithin(object sender, global::System.Windows.Input.MouseEventArgs e)
		{
			((global::Infragistics.Windows.Controls.TabItemEx)sender).VerifyIsMouseOverTab(e);
		}

		// Token: 0x06001201 RID: 4609 RVA: 0x00040534 File Offset: 0x0003E734
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

		// Token: 0x06001202 RID: 4610 RVA: 0x00040590 File Offset: 0x0003E790
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

		// Token: 0x06001203 RID: 4611 RVA: 0x00040604 File Offset: 0x0003E804
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

		// Token: 0x06001204 RID: 4612 RVA: 0x00040718 File Offset: 0x0003E918
		private static void OnVisualStatePropertyChanged(global::System.Windows.DependencyObject target, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.Controls.TabItemEx tabItemEx = target as global::Infragistics.Windows.Controls.TabItemEx;
			tabItemEx.UpdateVisualStates();
		}

		// Token: 0x06001205 RID: 4613 RVA: 0x00040732 File Offset: 0x0003E932
		protected void UpdateVisualStates()
		{
			this.UpdateVisualStates(true);
		}

		// Token: 0x06001206 RID: 4614 RVA: 0x0004073B File Offset: 0x0003E93B
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

		// Token: 0x06001207 RID: 4615 RVA: 0x00040758 File Offset: 0x0003E958
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

		// Token: 0x06001208 RID: 4616 RVA: 0x000407A8 File Offset: 0x0003E9A8
		bool global::Infragistics.Windows.Commands.ICommandHost.Execute(global::Infragistics.Windows.Commands.ExecuteCommandInfo commandInfo)
		{
			global::System.Windows.Input.RoutedCommand routedCommand = commandInfo.RoutedCommand;
			return routedCommand != null && this.ExecuteCommandImpl(commandInfo);
		}

		// Token: 0x06001209 RID: 4617 RVA: 0x000407C8 File Offset: 0x0003E9C8
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

		// Token: 0x0600120A RID: 4618 RVA: 0x000407F8 File Offset: 0x0003E9F8
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

		// Token: 0x04000934 RID: 2356
		private global::Infragistics.Windows.Controls.XamTabControl _bindingsSetWithTabControl;

		// Token: 0x04000935 RID: 2357
		private bool _hasVisualStateGroups;

		// Token: 0x0400093A RID: 2362
		internal static readonly global::System.Windows.DependencyProperty TabControlVersionProperty;

		// Token: 0x0400093B RID: 2363
		public static readonly global::System.Windows.DependencyProperty AllowClosingProperty;

		// Token: 0x0400093C RID: 2364
		public static readonly global::System.Windows.DependencyProperty CloseButtonVisibilityProperty;

		// Token: 0x0400093D RID: 2365
		private static readonly global::System.Windows.DependencyPropertyKey ComputedCloseButtonVisibilityPropertyKey;

		// Token: 0x0400093E RID: 2366
		public static readonly global::System.Windows.DependencyProperty ComputedCloseButtonVisibilityProperty;

		// Token: 0x0400093F RID: 2367
		private static readonly global::System.Windows.DependencyPropertyKey IsMouseOverTabPropertyKey;

		// Token: 0x04000940 RID: 2368
		public static readonly global::System.Windows.DependencyProperty IsMouseOverTabProperty;
	}
}
