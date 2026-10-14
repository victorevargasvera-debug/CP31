using System;
using System.Globalization;
using System.Windows.Automation.Peers;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Properties;
using System.Windows.Input;
using System.Windows.Media;

namespace System.Windows.Controls
{
	// Token: 0x0200000A RID: 10
	[global::System.Windows.TemplateVisualState(Name = "Disabled", GroupName = "CommonStates")]
	[global::System.Windows.TemplatePart(Name = "ExpandSite", Type = typeof(global::System.Windows.Controls.Primitives.ExpandableContentControl))]
	[global::System.Windows.TemplatePart(Name = "ExpanderButton", Type = typeof(global::System.Windows.Controls.Primitives.AccordionButton))]
	[global::System.Windows.StyleTypedProperty(Property = "AccordionButtonStyle", StyleTargetType = typeof(global::System.Windows.Controls.Primitives.AccordionButton))]
	[global::System.Windows.StyleTypedProperty(Property = "ExpandableContentControlStyle", StyleTargetType = typeof(global::System.Windows.Controls.Primitives.ExpandableContentControl))]
	[global::System.Windows.TemplateVisualState(Name = "MouseOver", GroupName = "CommonStates")]
	[global::System.Windows.TemplateVisualState(Name = "Pressed", GroupName = "CommonStates")]
	[global::System.Windows.TemplateVisualState(Name = "Normal", GroupName = "CommonStates")]
	[global::System.Windows.TemplateVisualState(Name = "Focused", GroupName = "FocusStates")]
	[global::System.Windows.TemplateVisualState(Name = "Unfocused", GroupName = "FocusStates")]
	[global::System.Windows.TemplateVisualState(Name = "Expanded", GroupName = "ExpansionStates")]
	[global::System.Windows.TemplateVisualState(Name = "Collapsed", GroupName = "ExpansionStates")]
	[global::System.Windows.TemplateVisualState(Name = "Locked", GroupName = "LockedStates")]
	[global::System.Windows.TemplateVisualState(Name = "Unlocked", GroupName = "LockedStates")]
	[global::System.Windows.TemplateVisualState(Name = "ExpandDown", GroupName = "ExpandDirectionStates")]
	[global::System.Windows.TemplateVisualState(Name = "ExpandUp", GroupName = "ExpandDirectionStates")]
	[global::System.Windows.TemplateVisualState(Name = "ExpandLeft", GroupName = "ExpandDirectionStates")]
	[global::System.Windows.TemplateVisualState(Name = "ExpandRight", GroupName = "ExpandDirectionStates")]
	public class AccordionItem : global::System.Windows.Controls.HeaderedContentControl, global::System.Windows.Controls.IUpdateVisualState
	{
		// Token: 0x1700000D RID: 13
		// (get) Token: 0x0600003A RID: 58 RVA: 0x00002E7F File Offset: 0x0000107F
		// (set) Token: 0x0600003B RID: 59 RVA: 0x00002E88 File Offset: 0x00001088
		private global::System.Windows.Controls.Primitives.AccordionButton ExpanderButton
		{
			get
			{
				return this._expanderButton;
			}
			set
			{
				if (this._expanderButton != null)
				{
					this._expanderButton.Click -= this.OnExpanderButtonClicked;
					this._expanderButton.ParentAccordionItem = null;
					this._expanderButton.SizeChanged -= this.OnHeaderSizeChanged;
				}
				this._expanderButton = value;
				if (this._expanderButton != null)
				{
					this._expanderButton.IsChecked = new bool?(this.IsSelected);
					this._expanderButton.Click += this.OnExpanderButtonClicked;
					this._expanderButton.ParentAccordionItem = this;
					this._expanderButton.SizeChanged += this.OnHeaderSizeChanged;
				}
			}
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x0600003C RID: 60 RVA: 0x00002F36 File Offset: 0x00001136
		// (set) Token: 0x0600003D RID: 61 RVA: 0x00002F40 File Offset: 0x00001140
		private global::System.Windows.Controls.Primitives.ExpandableContentControl ExpandSite
		{
			get
			{
				return this._expandSite;
			}
			set
			{
				if (this._expandSite != null)
				{
					this._expandSite.ContentSizeChanged -= this.OnExpandSiteContentSizeChanged;
				}
				this._expandSite = value;
				if (this._expandSite != null)
				{
					this._expandSite.ContentSizeChanged += this.OnExpandSiteContentSizeChanged;
				}
			}
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x0600003E RID: 62 RVA: 0x00002F92 File Offset: 0x00001192
		// (set) Token: 0x0600003F RID: 63 RVA: 0x00002FA4 File Offset: 0x000011A4
		public global::System.Windows.Controls.ExpandDirection ExpandDirection
		{
			get
			{
				return (global::System.Windows.Controls.ExpandDirection)base.GetValue(global::System.Windows.Controls.AccordionItem.ExpandDirectionProperty);
			}
			protected internal set
			{
				this._allowedToWriteExpandDirection = true;
				base.SetValue(global::System.Windows.Controls.AccordionItem.ExpandDirectionProperty, value);
				this._allowedToWriteExpandDirection = false;
			}
		}

		// Token: 0x06000040 RID: 64 RVA: 0x00002FC8 File Offset: 0x000011C8
		private static void OnExpandDirectionPropertyChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::System.Windows.Controls.AccordionItem accordionItem = (global::System.Windows.Controls.AccordionItem)d;
			global::System.Windows.Controls.ExpandDirection expandDirection = (global::System.Windows.Controls.ExpandDirection)e.OldValue;
			global::System.Windows.Controls.ExpandDirection expandDirection2 = (global::System.Windows.Controls.ExpandDirection)e.NewValue;
			if (!accordionItem._allowedToWriteExpandDirection)
			{
				accordionItem.ExpandDirection = expandDirection;
				string message = string.Format(global::System.Globalization.CultureInfo.InvariantCulture, global::System.Windows.Controls.Properties.Resources.AccordionItem_InvalidWriteToExpandDirection, new object[]
				{
					expandDirection2
				});
				throw new global::System.InvalidOperationException(message);
			}
			if (expandDirection2 != global::System.Windows.Controls.ExpandDirection.Down && expandDirection2 != global::System.Windows.Controls.ExpandDirection.Left && expandDirection2 != global::System.Windows.Controls.ExpandDirection.Right && expandDirection2 != global::System.Windows.Controls.ExpandDirection.Up)
			{
				accordionItem.ExpandDirection = expandDirection;
				string message2 = string.Format(global::System.Globalization.CultureInfo.InvariantCulture, global::System.Windows.Controls.Properties.Resources.Expander_OnExpandDirectionPropertyChanged_InvalidValue, new object[]
				{
					expandDirection2
				});
				throw new global::System.ArgumentException(message2, "e");
			}
			if (accordionItem.ExpandSite != null)
			{
				accordionItem.ExpandSite.RecalculatePercentage((double)(accordionItem.IsSelected ? 1 : 0));
			}
			accordionItem.UpdateVisualState(true);
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x06000041 RID: 65 RVA: 0x0000309F File Offset: 0x0000129F
		// (set) Token: 0x06000042 RID: 66 RVA: 0x000030B1 File Offset: 0x000012B1
		public bool IsSelected
		{
			get
			{
				return (bool)base.GetValue(global::System.Windows.Controls.AccordionItem.IsSelectedProperty);
			}
			set
			{
				base.SetValue(global::System.Windows.Controls.AccordionItem.IsSelectedProperty, value);
			}
		}

		// Token: 0x06000043 RID: 67 RVA: 0x000030C4 File Offset: 0x000012C4
		private static void OnIsSelectedPropertyChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::System.Windows.Controls.AccordionItem accordionItem = (global::System.Windows.Controls.AccordionItem)d;
			bool flag = (bool)e.NewValue;
			if (accordionItem.IsLocked && accordionItem._isSelectedNestedLevel == 0)
			{
				accordionItem._isSelectedNestedLevel++;
				accordionItem.SetValue(global::System.Windows.Controls.AccordionItem.IsSelectedProperty, e.OldValue);
				accordionItem._isSelectedNestedLevel--;
				throw new global::System.InvalidOperationException(global::System.Windows.Controls.Properties.Resources.AccordionItem_OnIsSelectedPropertyChanged_InvalidChange);
			}
			if (accordionItem._isSelectedNestedLevel == 0)
			{
				global::System.Windows.Controls.Accordion parentAccordion = accordionItem.ParentAccordion;
				if (parentAccordion != null)
				{
					if (flag)
					{
						parentAccordion.OnAccordionItemSelected(accordionItem);
					}
					else
					{
						parentAccordion.OnAccordionItemUnselected(accordionItem);
					}
				}
				if (flag)
				{
					accordionItem.OnSelected();
					return;
				}
				accordionItem.OnUnselected();
			}
		}

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x06000044 RID: 68 RVA: 0x00003163 File Offset: 0x00001363
		// (set) Token: 0x06000045 RID: 69 RVA: 0x0000316B File Offset: 0x0000136B
		public bool IsLocked
		{
			get
			{
				return this._isLocked;
			}
			internal set
			{
				if (this._isLocked != value)
				{
					this._isLocked = value;
					this.UpdateVisualState(true);
				}
			}
		}

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x06000046 RID: 70 RVA: 0x00003184 File Offset: 0x00001384
		// (set) Token: 0x06000047 RID: 71 RVA: 0x00003196 File Offset: 0x00001396
		public global::System.Windows.Style AccordionButtonStyle
		{
			get
			{
				return base.GetValue(global::System.Windows.Controls.AccordionItem.AccordionButtonStyleProperty) as global::System.Windows.Style;
			}
			set
			{
				base.SetValue(global::System.Windows.Controls.AccordionItem.AccordionButtonStyleProperty, value);
			}
		}

		// Token: 0x06000048 RID: 72 RVA: 0x000031A4 File Offset: 0x000013A4
		private static void OnAccordionButtonStylePropertyChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::System.Windows.Controls.AccordionItem accordionItem = (global::System.Windows.Controls.AccordionItem)d;
			accordionItem.OnAccordionButtonStyleChanged(e.OldValue as global::System.Windows.Style, e.NewValue as global::System.Windows.Style);
		}

		// Token: 0x06000049 RID: 73 RVA: 0x000031D6 File Offset: 0x000013D6
		protected virtual void OnAccordionButtonStyleChanged(global::System.Windows.Style oldStyle, global::System.Windows.Style newStyle)
		{
		}

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x0600004A RID: 74 RVA: 0x000031D8 File Offset: 0x000013D8
		// (set) Token: 0x0600004B RID: 75 RVA: 0x000031EA File Offset: 0x000013EA
		public global::System.Windows.Style ExpandableContentControlStyle
		{
			get
			{
				return base.GetValue(global::System.Windows.Controls.AccordionItem.ExpandableContentControlStyleProperty) as global::System.Windows.Style;
			}
			set
			{
				base.SetValue(global::System.Windows.Controls.AccordionItem.ExpandableContentControlStyleProperty, value);
			}
		}

		// Token: 0x0600004C RID: 76 RVA: 0x000031F8 File Offset: 0x000013F8
		private static void OnExpandableContentControlStylePropertyChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::System.Windows.Controls.AccordionItem accordionItem = (global::System.Windows.Controls.AccordionItem)d;
			accordionItem.OnExpandableContentControlStyleChanged(e.OldValue as global::System.Windows.Style, e.NewValue as global::System.Windows.Style);
		}

		// Token: 0x0600004D RID: 77 RVA: 0x0000322A File Offset: 0x0000142A
		protected virtual void OnExpandableContentControlStyleChanged(global::System.Windows.Style oldStyle, global::System.Windows.Style newStyle)
		{
		}

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x0600004E RID: 78 RVA: 0x0000322C File Offset: 0x0000142C
		// (set) Token: 0x0600004F RID: 79 RVA: 0x0000323E File Offset: 0x0000143E
		public global::System.Windows.Size ContentTargetSize
		{
			get
			{
				return (global::System.Windows.Size)base.GetValue(global::System.Windows.Controls.AccordionItem.ContentTargetSizeProperty);
			}
			internal set
			{
				this._allowedToWriteContentTargetSize = true;
				base.SetValue(global::System.Windows.Controls.AccordionItem.ContentTargetSizeProperty, value);
				this._allowedToWriteContentTargetSize = false;
			}
		}

		// Token: 0x06000050 RID: 80 RVA: 0x00003260 File Offset: 0x00001460
		private static void OnContentTargetSizePropertyChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::System.Windows.Controls.AccordionItem accordionItem = (global::System.Windows.Controls.AccordionItem)d;
			global::System.Windows.Size size = (global::System.Windows.Size)e.NewValue;
			if (!accordionItem._allowedToWriteContentTargetSize)
			{
				accordionItem.ContentTargetSize = (global::System.Windows.Size)e.OldValue;
				throw new global::System.InvalidOperationException(global::System.Windows.Controls.Properties.Resources.AccordionItem_InvalidWriteToContentTargetSize);
			}
			global::System.Windows.Controls.Primitives.ExpandableContentControl expandSite = accordionItem.ExpandSite;
			if (expandSite != null && !expandSite.TargetSize.Equals(size))
			{
				expandSite.TargetSize = size;
				if (accordionItem.IsSelected)
				{
					if (accordionItem.ParentAccordion != null && accordionItem.ParentAccordion.IsResizing)
					{
						expandSite.RecalculatePercentage(1.0);
						return;
					}
					accordionItem.Schedule(global::System.Windows.Controls.AccordionAction.Resize);
				}
			}
		}

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x06000051 RID: 81 RVA: 0x000032FC File Offset: 0x000014FC
		// (set) Token: 0x06000052 RID: 82 RVA: 0x00003304 File Offset: 0x00001504
		internal global::System.Windows.Controls.Accordion ParentAccordion { get; set; }

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x06000053 RID: 83 RVA: 0x0000330D File Offset: 0x0000150D
		// (set) Token: 0x06000054 RID: 84 RVA: 0x00003315 File Offset: 0x00001515
		internal global::System.Windows.Controls.AccordionAction ScheduledAction { get; private set; }

		// Token: 0x14000002 RID: 2
		// (add) Token: 0x06000055 RID: 85 RVA: 0x0000331E File Offset: 0x0000151E
		// (remove) Token: 0x06000056 RID: 86 RVA: 0x0000332C File Offset: 0x0000152C
		public event global::System.Windows.RoutedEventHandler Selected
		{
			add
			{
				base.AddHandler(global::System.Windows.Controls.AccordionItem.SelectedEvent, value);
			}
			remove
			{
				base.RemoveHandler(global::System.Windows.Controls.AccordionItem.SelectedEvent, value);
			}
		}

		// Token: 0x14000003 RID: 3
		// (add) Token: 0x06000057 RID: 87 RVA: 0x0000333A File Offset: 0x0000153A
		// (remove) Token: 0x06000058 RID: 88 RVA: 0x00003348 File Offset: 0x00001548
		public event global::System.Windows.RoutedEventHandler Unselected
		{
			add
			{
				base.AddHandler(global::System.Windows.Controls.AccordionItem.UnselectedEvent, value);
			}
			remove
			{
				base.RemoveHandler(global::System.Windows.Controls.AccordionItem.UnselectedEvent, value);
			}
		}

		// Token: 0x06000059 RID: 89 RVA: 0x00003358 File Offset: 0x00001558
		static AccordionItem()
		{
			global::System.Windows.Controls.AccordionItem.SelectedEvent = global::System.Windows.EventManager.RegisterRoutedEvent("Selected", global::System.Windows.RoutingStrategy.Bubble, typeof(global::System.Windows.RoutedEventHandler), typeof(global::System.Windows.Controls.AccordionItem));
			global::System.Windows.Controls.AccordionItem.UnselectedEvent = global::System.Windows.EventManager.RegisterRoutedEvent("Unselected", global::System.Windows.RoutingStrategy.Bubble, typeof(global::System.Windows.RoutedEventHandler), typeof(global::System.Windows.Controls.AccordionItem));
			global::System.Windows.FrameworkElement.DefaultStyleKeyProperty.OverrideMetadata(typeof(global::System.Windows.Controls.AccordionItem), new global::System.Windows.FrameworkPropertyMetadata(typeof(global::System.Windows.Controls.AccordionItem)));
		}

		// Token: 0x0600005A RID: 90 RVA: 0x000034F6 File Offset: 0x000016F6
		public AccordionItem()
		{
			this.ScheduledAction = global::System.Windows.Controls.AccordionAction.None;
			this._interaction = new global::System.Windows.Controls.InteractionHelper(this);
		}

		// Token: 0x0600005B RID: 91 RVA: 0x00003511 File Offset: 0x00001711
		private void OnHeaderSizeChanged(object sender, global::System.Windows.SizeChangedEventArgs e)
		{
			if (this.ParentAccordion != null)
			{
				this.ParentAccordion.OnHeaderSizeChange(this);
			}
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x0600005C RID: 92 RVA: 0x00003527 File Offset: 0x00001727
		internal global::System.Windows.Size RelevantContentSize
		{
			get
			{
				if (this.ExpandSite != null)
				{
					return this.ExpandSite.RelevantContentSize;
				}
				return new global::System.Windows.Size(0.0, 0.0);
			}
		}

		// Token: 0x0600005D RID: 93 RVA: 0x00003554 File Offset: 0x00001754
		private void Schedule(global::System.Windows.Controls.AccordionAction action)
		{
			this.ScheduledAction = action;
			if (this.ParentAccordion == null)
			{
				this.StartAction();
				return;
			}
			bool flag = this.ParentAccordion.ScheduleAction(this, action);
			if (flag)
			{
				this.StartAction();
			}
		}

		// Token: 0x0600005E RID: 94 RVA: 0x00003618 File Offset: 0x00001818
		internal virtual void StartAction()
		{
			if (this.ScheduledAction == global::System.Windows.Controls.AccordionAction.None)
			{
				throw new global::System.InvalidOperationException(global::System.Windows.Controls.Properties.Resources.AccordionItem_StartAction_InvalidCall);
			}
			global::System.Action action;
			switch (this.ScheduledAction)
			{
			case global::System.Windows.Controls.AccordionAction.Collapse:
				action = delegate()
				{
					global::System.Windows.VisualStateManager.GoToState(this, "Expanded", false);
					if (global::System.Windows.VisualStateManager.GoToState(this, "Collapsed", true))
					{
						this.ParentAccordion.OnActionFinish(this);
					}
				};
				break;
			case global::System.Windows.Controls.AccordionAction.Expand:
				action = delegate()
				{
					global::System.Windows.VisualStateManager.GoToState(this, "Collapsed", false);
					if (global::System.Windows.VisualStateManager.GoToState(this, "Expanded", true))
					{
						this.ParentAccordion.OnActionFinish(this);
					}
				};
				break;
			case global::System.Windows.Controls.AccordionAction.Resize:
				action = delegate()
				{
					global::System.Windows.VisualStateManager.GoToState(this, "Expanded", false);
					global::System.Windows.VisualStateManager.GoToState(this, "Collapsed", false);
					if (global::System.Windows.VisualStateManager.GoToState(this, "Expanded", true))
					{
						this.ParentAccordion.OnActionFinish(this);
					}
				};
				break;
			default:
			{
				string message = string.Format(global::System.Globalization.CultureInfo.InvariantCulture, global::System.Windows.Controls.Properties.Resources.AccordionItem_StartAction_InvalidAction, new object[]
				{
					this.ScheduledAction
				});
				throw new global::System.NotSupportedException(message);
			}
			}
			this.ScheduledAction = global::System.Windows.Controls.AccordionAction.None;
			this._isBusyWithAction = true;
			action();
		}

		// Token: 0x0600005F RID: 95 RVA: 0x000036E4 File Offset: 0x000018E4
		private void OnExpandSiteContentSizeChanged(object sender, global::System.Windows.SizeChangedEventArgs e)
		{
			if (this.IsSelected && !this._isBusyWithAction && ((!this.ShouldFillWidth && e.PreviousSize.Width != e.NewSize.Width) || (!this.ShouldFillHeight && e.PreviousSize.Height != e.NewSize.Height)))
			{
				this.ExpandSite.MeasureContent(this.ExpandSite.CalculateDesiredContentSize());
				this.ExpandSite.RecalculatePercentage(this.ExpandSite.TargetSize);
				this.Schedule(global::System.Windows.Controls.AccordionAction.Resize);
			}
		}

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x06000060 RID: 96 RVA: 0x00003784 File Offset: 0x00001984
		private bool ShouldFillWidth
		{
			get
			{
				return (this.ExpandDirection == global::System.Windows.Controls.ExpandDirection.Left || this.ExpandDirection == global::System.Windows.Controls.ExpandDirection.Right) && (!double.IsNaN(this.ContentTargetSize.Width) || base.HorizontalAlignment == global::System.Windows.HorizontalAlignment.Stretch);
			}
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x06000061 RID: 97 RVA: 0x000037C8 File Offset: 0x000019C8
		private bool ShouldFillHeight
		{
			get
			{
				return (this.ExpandDirection == global::System.Windows.Controls.ExpandDirection.Down || this.ExpandDirection == global::System.Windows.Controls.ExpandDirection.Up) && (!double.IsNaN(this.ContentTargetSize.Height) || base.VerticalAlignment == global::System.Windows.VerticalAlignment.Stretch);
			}
		}

		// Token: 0x06000062 RID: 98 RVA: 0x00003808 File Offset: 0x00001A08
		public override void OnApplyTemplate()
		{
			base.OnApplyTemplate();
			this.ExpanderButton = (base.GetTemplateChild("ExpanderButton") as global::System.Windows.Controls.Primitives.AccordionButton);
			this.ExpandSite = (base.GetTemplateChild("ExpandSite") as global::System.Windows.Controls.Primitives.ExpandableContentControl);
			if (global::System.Windows.Media.VisualTreeHelper.GetChildrenCount(this) > 0)
			{
				global::System.Windows.Media.VisualTreeHelper.GetChild(this, 0);
			}
			this._interaction.OnApplyTemplateBase();
			this.UpdateVisualState(false);
			if (this.IsSelected)
			{
				this.Schedule(global::System.Windows.Controls.AccordionAction.Expand);
				return;
			}
			this.Schedule(global::System.Windows.Controls.AccordionAction.Collapse);
		}

		// Token: 0x06000063 RID: 99 RVA: 0x00003881 File Offset: 0x00001A81
		protected override global::System.Windows.Automation.Peers.AutomationPeer OnCreateAutomationPeer()
		{
			return new global::System.Windows.Automation.Peers.AccordionItemWrapperAutomationPeer(this);
		}

		// Token: 0x06000064 RID: 100 RVA: 0x00003889 File Offset: 0x00001A89
		internal static void PreparePrepareHeaderedContentControlContainerForItemOverride(global::System.Windows.Controls.HeaderedContentControl element, object item, global::System.Windows.Controls.ItemsControl parent, global::System.Windows.Style parentItemContainerStyle)
		{
			if (element != item && !(item is global::System.Windows.UIElement) && global::System.Windows.Controls.AccordionItem.HasDefaultValue(element, global::System.Windows.Controls.HeaderedContentControl.HeaderProperty))
			{
				element.Header = item;
			}
		}

		// Token: 0x06000065 RID: 101 RVA: 0x000038AB File Offset: 0x00001AAB
		private static bool HasDefaultValue(global::System.Windows.Controls.Control control, global::System.Windows.DependencyProperty property)
		{
			return control.ReadLocalValue(property) == global::System.Windows.DependencyProperty.UnsetValue;
		}

		// Token: 0x06000066 RID: 102 RVA: 0x000038BC File Offset: 0x00001ABC
		protected override void OnKeyDown(global::System.Windows.Input.KeyEventArgs e)
		{
			base.OnKeyDown(e);
			if (e.Handled || !base.IsEnabled || this.IsLocked)
			{
				return;
			}
			bool isSelected = this.IsSelected;
			switch (this.ExpandDirection)
			{
			case global::System.Windows.Controls.ExpandDirection.Down:
				if ((isSelected && e.Key == global::System.Windows.Input.Key.Up) || (!isSelected && e.Key == global::System.Windows.Input.Key.Down))
				{
					this.IsSelected = !isSelected;
					return;
				}
				break;
			case global::System.Windows.Controls.ExpandDirection.Up:
				if ((isSelected && e.Key == global::System.Windows.Input.Key.Down) || (!isSelected && e.Key == global::System.Windows.Input.Key.Up))
				{
					this.IsSelected = !isSelected;
					return;
				}
				break;
			case global::System.Windows.Controls.ExpandDirection.Left:
				if ((isSelected && e.Key == global::System.Windows.Input.Key.Right) || (!isSelected && e.Key == global::System.Windows.Input.Key.Left))
				{
					this.IsSelected = !isSelected;
					return;
				}
				break;
			case global::System.Windows.Controls.ExpandDirection.Right:
				if ((isSelected && e.Key == global::System.Windows.Input.Key.Left) || (!isSelected && e.Key == global::System.Windows.Input.Key.Right))
				{
					this.IsSelected = !isSelected;
				}
				break;
			default:
				return;
			}
		}

		// Token: 0x06000067 RID: 103 RVA: 0x000039A4 File Offset: 0x00001BA4
		protected virtual void OnSelected()
		{
			this.ToggleSelected(new global::System.Windows.RoutedEventArgs(global::System.Windows.Controls.AccordionItem.SelectedEvent));
		}

		// Token: 0x06000068 RID: 104 RVA: 0x000039B6 File Offset: 0x00001BB6
		protected virtual void OnUnselected()
		{
			this.ToggleSelected(new global::System.Windows.RoutedEventArgs(global::System.Windows.Controls.AccordionItem.UnselectedEvent));
		}

		// Token: 0x06000069 RID: 105 RVA: 0x000039C8 File Offset: 0x00001BC8
		private void ToggleSelected(global::System.Windows.RoutedEventArgs args)
		{
			global::System.Windows.Controls.Primitives.ToggleButton expanderButton = this.ExpanderButton;
			if (expanderButton != null)
			{
				expanderButton.IsChecked = new bool?(this.IsSelected);
			}
			if (this.IsSelected)
			{
				this.Schedule(global::System.Windows.Controls.AccordionAction.Expand);
			}
			else
			{
				this.Schedule(global::System.Windows.Controls.AccordionAction.Collapse);
			}
			this.UpdateVisualState(true);
			base.RaiseEvent(args);
		}

		// Token: 0x0600006A RID: 106 RVA: 0x00003A16 File Offset: 0x00001C16
		private void OnExpanderButtonClicked(object sender, global::System.Windows.RoutedEventArgs e)
		{
			if (!this.IsLocked)
			{
				this.IsSelected = !this.IsSelected;
			}
		}

		// Token: 0x0600006B RID: 107 RVA: 0x00003A2F File Offset: 0x00001C2F
		protected override void OnGotFocus(global::System.Windows.RoutedEventArgs e)
		{
			if (this._interaction.AllowGotFocus(e))
			{
				this._interaction.OnGotFocusBase();
				base.OnGotFocus(e);
			}
		}

		// Token: 0x0600006C RID: 108 RVA: 0x00003A51 File Offset: 0x00001C51
		protected override void OnLostFocus(global::System.Windows.RoutedEventArgs e)
		{
			if (this._interaction.AllowLostFocus(e))
			{
				this._interaction.OnLostFocusBase();
				base.OnLostFocus(e);
			}
		}

		// Token: 0x0600006D RID: 109 RVA: 0x00003A73 File Offset: 0x00001C73
		protected override void OnMouseEnter(global::System.Windows.Input.MouseEventArgs e)
		{
			if (this._interaction.AllowMouseEnter(e))
			{
				this._interaction.OnMouseEnterBase();
				base.OnMouseEnter(e);
			}
		}

		// Token: 0x0600006E RID: 110 RVA: 0x00003A95 File Offset: 0x00001C95
		protected override void OnMouseLeave(global::System.Windows.Input.MouseEventArgs e)
		{
			if (this._interaction.AllowMouseLeave(e))
			{
				this._interaction.OnMouseLeaveBase();
				base.OnMouseLeave(e);
			}
		}

		// Token: 0x0600006F RID: 111 RVA: 0x00003AB7 File Offset: 0x00001CB7
		protected override void OnMouseLeftButtonDown(global::System.Windows.Input.MouseButtonEventArgs e)
		{
			if (this._interaction.AllowMouseLeftButtonDown(e))
			{
				this._interaction.OnMouseLeftButtonDownBase();
				base.OnMouseLeftButtonDown(e);
			}
		}

		// Token: 0x06000070 RID: 112 RVA: 0x00003AD9 File Offset: 0x00001CD9
		protected override void OnMouseLeftButtonUp(global::System.Windows.Input.MouseButtonEventArgs e)
		{
			if (this._interaction.AllowMouseLeftButtonUp(e))
			{
				this._interaction.OnMouseLeftButtonUpBase();
				base.OnMouseLeftButtonUp(e);
			}
		}

		// Token: 0x06000071 RID: 113 RVA: 0x00003AFB File Offset: 0x00001CFB
		void global::System.Windows.Controls.IUpdateVisualState.UpdateVisualState(bool useTransitions)
		{
			this.UpdateVisualState(useTransitions);
		}

		// Token: 0x06000072 RID: 114 RVA: 0x00003B04 File Offset: 0x00001D04
		internal virtual void UpdateVisualState(bool useTransitions)
		{
			if (this.IsLocked)
			{
				global::System.Windows.Controls.VisualStates.GoToState(this, useTransitions, new string[]
				{
					"Locked"
				});
			}
			else
			{
				global::System.Windows.Controls.VisualStates.GoToState(this, useTransitions, new string[]
				{
					"Unlocked"
				});
			}
			switch (this.ExpandDirection)
			{
			case global::System.Windows.Controls.ExpandDirection.Down:
				global::System.Windows.Controls.VisualStates.GoToState(this, useTransitions, new string[]
				{
					"ExpandDown"
				});
				break;
			case global::System.Windows.Controls.ExpandDirection.Up:
				global::System.Windows.Controls.VisualStates.GoToState(this, useTransitions, new string[]
				{
					"ExpandUp"
				});
				break;
			case global::System.Windows.Controls.ExpandDirection.Left:
				global::System.Windows.Controls.VisualStates.GoToState(this, useTransitions, new string[]
				{
					"ExpandLeft"
				});
				break;
			default:
				global::System.Windows.Controls.VisualStates.GoToState(this, useTransitions, new string[]
				{
					"ExpandRight"
				});
				break;
			}
			if (this.ExpanderButton != null)
			{
				this.ExpanderButton.UpdateVisualState(useTransitions);
			}
			this._interaction.UpdateVisualStateBase(useTransitions);
		}

		// Token: 0x04000015 RID: 21
		private const string ElementExpanderButtonName = "ExpanderButton";

		// Token: 0x04000016 RID: 22
		private const string ElementExpandSiteName = "ExpandSite";

		// Token: 0x04000017 RID: 23
		private global::System.Windows.Controls.Primitives.AccordionButton _expanderButton;

		// Token: 0x04000018 RID: 24
		private global::System.Windows.Controls.Primitives.ExpandableContentControl _expandSite;

		// Token: 0x04000019 RID: 25
		private bool _isBusyWithAction;

		// Token: 0x0400001A RID: 26
		private bool _allowedToWriteExpandDirection;

		// Token: 0x0400001B RID: 27
		public static readonly global::System.Windows.DependencyProperty ExpandDirectionProperty = global::System.Windows.DependencyProperty.Register("ExpandDirection", typeof(global::System.Windows.Controls.ExpandDirection), typeof(global::System.Windows.Controls.AccordionItem), new global::System.Windows.PropertyMetadata(global::System.Windows.Controls.ExpandDirection.Down, new global::System.Windows.PropertyChangedCallback(global::System.Windows.Controls.AccordionItem.OnExpandDirectionPropertyChanged)));

		// Token: 0x0400001C RID: 28
		public static readonly global::System.Windows.DependencyProperty IsSelectedProperty = global::System.Windows.DependencyProperty.Register("IsSelected", typeof(bool), typeof(global::System.Windows.Controls.AccordionItem), new global::System.Windows.PropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::System.Windows.Controls.AccordionItem.OnIsSelectedPropertyChanged)));

		// Token: 0x0400001D RID: 29
		private int _isSelectedNestedLevel;

		// Token: 0x0400001E RID: 30
		private bool _isLocked;

		// Token: 0x0400001F RID: 31
		public static readonly global::System.Windows.DependencyProperty AccordionButtonStyleProperty = global::System.Windows.DependencyProperty.Register("AccordionButtonStyle", typeof(global::System.Windows.Style), typeof(global::System.Windows.Controls.AccordionItem), new global::System.Windows.PropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::System.Windows.Controls.AccordionItem.OnAccordionButtonStylePropertyChanged)));

		// Token: 0x04000020 RID: 32
		public static readonly global::System.Windows.DependencyProperty ExpandableContentControlStyleProperty = global::System.Windows.DependencyProperty.Register("ExpandableContentControlStyle", typeof(global::System.Windows.Style), typeof(global::System.Windows.Controls.AccordionItem), new global::System.Windows.PropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::System.Windows.Controls.AccordionItem.OnExpandableContentControlStylePropertyChanged)));

		// Token: 0x04000021 RID: 33
		private bool _allowedToWriteContentTargetSize;

		// Token: 0x04000022 RID: 34
		public static readonly global::System.Windows.DependencyProperty ContentTargetSizeProperty = global::System.Windows.DependencyProperty.Register("ContentTargetSize", typeof(global::System.Windows.Size), typeof(global::System.Windows.Controls.AccordionItem), new global::System.Windows.PropertyMetadata(new global::System.Windows.Size(double.NaN, double.NaN), new global::System.Windows.PropertyChangedCallback(global::System.Windows.Controls.AccordionItem.OnContentTargetSizePropertyChanged)));

		// Token: 0x04000025 RID: 37
		private global::System.Windows.Controls.InteractionHelper _interaction;
	}
}
