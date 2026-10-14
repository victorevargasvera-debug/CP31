using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Automation.Peers;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Shapes;
using Infragistics.Windows.Automation.Peers.DataPresenter;
using Infragistics.Windows.Controls;
using Infragistics.Windows.DataPresenter.Events;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x0200017D RID: 381
	[global::System.Windows.TemplatePart(Name = "PART_InsertionPoint", Type = typeof(global::System.Windows.FrameworkElement))]
	public abstract class GroupByAreaBase : global::System.Windows.Controls.Control
	{
		// Token: 0x060017F7 RID: 6135 RVA: 0x0006FF74 File Offset: 0x0006E174
		static GroupByAreaBase()
		{
			global::Infragistics.Windows.DataPresenter.GroupByAreaBase.CollapsedEvent = global::System.Windows.Controls.Expander.CollapsedEvent.AddOwner(typeof(global::Infragistics.Windows.DataPresenter.GroupByAreaBase));
			global::Infragistics.Windows.DataPresenter.GroupByAreaBase.ExpandedEvent = global::System.Windows.Controls.Expander.ExpandedEvent.AddOwner(typeof(global::Infragistics.Windows.DataPresenter.GroupByAreaBase));
			global::Infragistics.Windows.DataPresenter.GroupByAreaBase.HideInsertionPointEvent = global::System.Windows.EventManager.RegisterRoutedEvent("HideInsertionPoint", global::System.Windows.RoutingStrategy.Bubble, typeof(global::System.Windows.RoutedEventHandler), typeof(global::Infragistics.Windows.DataPresenter.GroupByAreaBase));
			global::Infragistics.Windows.DataPresenter.GroupByAreaBase.HidePromptsEvent = global::System.Windows.EventManager.RegisterRoutedEvent("HidePrompts", global::System.Windows.RoutingStrategy.Bubble, typeof(global::System.Windows.RoutedEventHandler), typeof(global::Infragistics.Windows.DataPresenter.GroupByAreaBase));
			global::Infragistics.Windows.DataPresenter.GroupByAreaBase.ShowInsertionPointEvent = global::System.Windows.EventManager.RegisterRoutedEvent("ShowInsertionPoint", global::System.Windows.RoutingStrategy.Bubble, typeof(global::System.Windows.RoutedEventHandler), typeof(global::Infragistics.Windows.DataPresenter.GroupByAreaBase));
			global::Infragistics.Windows.DataPresenter.GroupByAreaBase.ShowPromptsEvent = global::System.Windows.EventManager.RegisterRoutedEvent("ShowPrompts", global::System.Windows.RoutingStrategy.Bubble, typeof(global::System.Windows.RoutedEventHandler), typeof(global::Infragistics.Windows.DataPresenter.GroupByAreaBase));
			global::Infragistics.Windows.DataPresenter.GroupByAreaBase.ToggleExpandedState = new global::System.Windows.Input.RoutedCommand("ToggleExpandedState", typeof(global::Infragistics.Windows.DataPresenter.GroupByAreaBase));
			global::System.Windows.Input.CommandManager.RegisterClassCommandBinding(typeof(global::Infragistics.Windows.DataPresenter.GroupByAreaBase), new global::System.Windows.Input.CommandBinding(global::Infragistics.Windows.DataPresenter.GroupByAreaBase.ToggleExpandedState, new global::System.Windows.Input.ExecutedRoutedEventHandler(global::Infragistics.Windows.DataPresenter.GroupByAreaBase.OnToggleExpandedState), new global::System.Windows.Input.CanExecuteRoutedEventHandler(global::Infragistics.Windows.DataPresenter.GroupByAreaBase.OnQueryToggleExpandedState)));
		}

		// Token: 0x060017F8 RID: 6136 RVA: 0x0007022A File Offset: 0x0006E42A
		public GroupByAreaBase() : this(null)
		{
			this.IsExpanded = true;
		}

		// Token: 0x060017F9 RID: 6137 RVA: 0x0007023A File Offset: 0x0006E43A
		internal GroupByAreaBase(global::Infragistics.Windows.DataPresenter.DataPresenterBase dataPresenter)
		{
			this.InitializeDataPresenter(dataPresenter);
		}

		// Token: 0x060017FA RID: 6138 RVA: 0x00070266 File Offset: 0x0006E466
		protected override global::System.Windows.Media.Visual GetVisualChild(int index)
		{
			if (index > 0 && this.FieldLabelDragInProgress && this._currentFieldLabelDragElement != null)
			{
				return this._currentFieldLabelDragElement;
			}
			return base.GetVisualChild(index);
		}

		// Token: 0x060017FB RID: 6139 RVA: 0x000702A4 File Offset: 0x0006E4A4
		public override void OnApplyTemplate()
		{
			global::System.Windows.RoutedEventHandler value = new global::System.Windows.RoutedEventHandler(this.OnExpanderBarClick);
			if (this._expanderBars == null)
			{
				this._expanderBars = new global::System.Collections.Generic.List<global::Infragistics.Windows.Controls.ExpanderBar>();
			}
			else
			{
				foreach (global::Infragistics.Windows.Controls.ExpanderBar expanderBar in this._expanderBars)
				{
					expanderBar.Click -= value;
				}
				this._expanderBars.Clear();
			}
			base.OnApplyTemplate();
			global::Infragistics.Windows.Utilities.DependencyObjectSearchCallback<global::Infragistics.Windows.Controls.ExpanderBar> callback = delegate(global::Infragistics.Windows.Controls.ExpanderBar bar)
			{
				if (bar.Command == null)
				{
					this._expanderBars.Add(bar);
				}
				return false;
			};
			global::Infragistics.Windows.Utilities.GetTemplateChild<global::Infragistics.Windows.Controls.ExpanderBar>(this, callback);
			foreach (global::Infragistics.Windows.Controls.ExpanderBar expanderBar2 in this._expanderBars)
			{
				expanderBar2.Click += value;
			}
			this.InitializePrompts();
			this.VerifyInsertionPoint();
			this.OnFieldLayoutInitialized();
			if (!this._arePropertiesHookedUp && this._dataPresenter != null)
			{
				this._arePropertiesHookedUp = true;
				base.SetBinding(global::Infragistics.Windows.DataPresenter.GroupByAreaBase.IsExpandedProperty, global::Infragistics.Windows.Utilities.CreateBindingObject(global::Infragistics.Windows.DataPresenter.DataPresenterBase.IsGroupByAreaExpandedProperty, global::System.Windows.Data.BindingMode.TwoWay, this._dataPresenter));
			}
		}

		// Token: 0x060017FC RID: 6140 RVA: 0x000703CC File Offset: 0x0006E5CC
		protected override global::System.Windows.Automation.Peers.AutomationPeer OnCreateAutomationPeer()
		{
			return new global::Infragistics.Windows.Automation.Peers.DataPresenter.GroupByAreaBaseAutomationPeer(this);
		}

		// Token: 0x060017FD RID: 6141 RVA: 0x000703D4 File Offset: 0x0006E5D4
		protected override void OnPropertyChanged(global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			base.OnPropertyChanged(e);
			if (e.Property == global::Infragistics.Windows.DataPresenter.GroupByAreaBase.DefaultPrompt1Property || e.Property == global::Infragistics.Windows.DataPresenter.GroupByAreaBase.DefaultPrompt2Property)
			{
				if (base.IsInitialized)
				{
					global::System.Windows.DependencyProperty dp;
					if (e.Property == global::Infragistics.Windows.DataPresenter.GroupByAreaBase.DefaultPrompt1Property)
					{
						dp = global::Infragistics.Windows.DataPresenter.GroupByAreaBase.Prompt1Property;
					}
					else
					{
						dp = global::Infragistics.Windows.DataPresenter.GroupByAreaBase.Prompt2Property;
					}
					string text = base.GetValue(dp) as string;
					if (text == null || text == (string)e.OldValue)
					{
						base.SetValue(dp, e.NewValue);
						return;
					}
				}
			}
			else if ((e.Property == global::Infragistics.Windows.DataPresenter.GroupByAreaBase.Prompt1Property || e.Property == global::Infragistics.Windows.DataPresenter.GroupByAreaBase.Prompt2Property) && base.IsInitialized && e.NewValue == null)
			{
				this.InitializePrompts();
			}
		}

		// Token: 0x1700063B RID: 1595
		// (get) Token: 0x060017FE RID: 6142 RVA: 0x00070491 File Offset: 0x0006E691
		protected override int VisualChildrenCount
		{
			get
			{
				if (this.FieldLabelDragInProgress && this._currentFieldLabelDragElement != null)
				{
					return 2;
				}
				return base.VisualChildrenCount;
			}
		}

		// Token: 0x1700063C RID: 1596
		// (get) Token: 0x060017FF RID: 6143 RVA: 0x000704AB File Offset: 0x0006E6AB
		public bool FieldLabelDragInProgress
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.Windows.DataPresenter.GroupByAreaBase.FieldLabelDragInProgressProperty);
			}
		}

		// Token: 0x06001800 RID: 6144 RVA: 0x000704C0 File Offset: 0x0006E6C0
		private static void OnIsExpandedChanged(global::System.Windows.DependencyObject target, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.DataPresenter.GroupByAreaBase groupByAreaBase = target as global::Infragistics.Windows.DataPresenter.GroupByAreaBase;
			if (groupByAreaBase != null)
			{
				global::System.Windows.Automation.Peers.AutomationPeer automationPeer = global::System.Windows.Automation.Peers.UIElementAutomationPeer.FromElement(groupByAreaBase);
				if (automationPeer != null)
				{
					bool flag = (bool)e.NewValue;
					automationPeer.RaisePropertyChangedEvent(global::System.Windows.Automation.ExpandCollapsePatternIdentifiers.ExpandCollapseStateProperty, (!flag) ? global::System.Windows.Automation.ExpandCollapseState.Expanded : global::System.Windows.Automation.ExpandCollapseState.Collapsed, flag ? global::System.Windows.Automation.ExpandCollapseState.Expanded : global::System.Windows.Automation.ExpandCollapseState.Collapsed);
				}
				if ((bool)e.NewValue)
				{
					groupByAreaBase.OnExpanded();
					return;
				}
				groupByAreaBase.OnCollapsed();
			}
		}

		// Token: 0x1700063D RID: 1597
		// (get) Token: 0x06001801 RID: 6145 RVA: 0x0007052C File Offset: 0x0006E72C
		// (set) Token: 0x06001802 RID: 6146 RVA: 0x0007053E File Offset: 0x0006E73E
		public bool IsExpanded
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.Windows.DataPresenter.GroupByAreaBase.IsExpandedProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.GroupByAreaBase.IsExpandedProperty, global::Infragistics.KnownBoxes.FromValue(value));
			}
		}

		// Token: 0x1700063E RID: 1598
		// (get) Token: 0x06001803 RID: 6147 RVA: 0x00070551 File Offset: 0x0006E751
		// (set) Token: 0x06001804 RID: 6148 RVA: 0x00070563 File Offset: 0x0006E763
		public string Prompt1
		{
			get
			{
				return (string)base.GetValue(global::Infragistics.Windows.DataPresenter.GroupByAreaBase.Prompt1Property);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.GroupByAreaBase.Prompt1Property, value);
			}
		}

		// Token: 0x1700063F RID: 1599
		// (get) Token: 0x06001805 RID: 6149 RVA: 0x00070571 File Offset: 0x0006E771
		// (set) Token: 0x06001806 RID: 6150 RVA: 0x00070583 File Offset: 0x0006E783
		[global::System.ComponentModel.Bindable(true)]
		public global::System.Windows.DataTemplate Prompt1Template
		{
			get
			{
				return (global::System.Windows.DataTemplate)base.GetValue(global::Infragistics.Windows.DataPresenter.GroupByAreaBase.Prompt1TemplateProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.GroupByAreaBase.Prompt1TemplateProperty, value);
			}
		}

		// Token: 0x17000640 RID: 1600
		// (get) Token: 0x06001807 RID: 6151 RVA: 0x00070591 File Offset: 0x0006E791
		// (set) Token: 0x06001808 RID: 6152 RVA: 0x000705A3 File Offset: 0x0006E7A3
		public string Prompt2
		{
			get
			{
				return (string)base.GetValue(global::Infragistics.Windows.DataPresenter.GroupByAreaBase.Prompt2Property);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.GroupByAreaBase.Prompt2Property, value);
			}
		}

		// Token: 0x17000641 RID: 1601
		// (get) Token: 0x06001809 RID: 6153 RVA: 0x000705B1 File Offset: 0x0006E7B1
		// (set) Token: 0x0600180A RID: 6154 RVA: 0x000705C3 File Offset: 0x0006E7C3
		[global::System.ComponentModel.Bindable(true)]
		public global::System.Windows.DataTemplate Prompt2Template
		{
			get
			{
				return (global::System.Windows.DataTemplate)base.GetValue(global::Infragistics.Windows.DataPresenter.GroupByAreaBase.Prompt2TemplateProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.GroupByAreaBase.Prompt2TemplateProperty, value);
			}
		}

		// Token: 0x17000642 RID: 1602
		// (get) Token: 0x0600180B RID: 6155 RVA: 0x000705D4 File Offset: 0x0006E7D4
		// (set) Token: 0x0600180C RID: 6156 RVA: 0x00070640 File Offset: 0x0006E840
		internal global::System.Windows.Shapes.Rectangle CurrentFieldLabelDragElement
		{
			get
			{
				if (this._currentFieldLabelDragElement == null)
				{
					this._currentFieldLabelDragElement = new global::System.Windows.Shapes.Rectangle();
					this._currentFieldLabelDragElement.Visibility = global::System.Windows.Visibility.Hidden;
					this._currentFieldLabelDragElementTransform = new global::System.Windows.Media.TranslateTransform(0.0, 0.0);
					this._currentFieldLabelDragElement.RenderTransform = this._currentFieldLabelDragElementTransform;
					base.AddVisualChild(this._currentFieldLabelDragElement);
				}
				return this._currentFieldLabelDragElement;
			}
			set
			{
				this._currentFieldLabelDragElement = value;
			}
		}

		// Token: 0x17000643 RID: 1603
		// (get) Token: 0x0600180D RID: 6157 RVA: 0x00070649 File Offset: 0x0006E849
		internal global::System.Windows.Media.TranslateTransform CurrentFieldLabelDragElementTransform
		{
			get
			{
				return this._currentFieldLabelDragElementTransform;
			}
		}

		// Token: 0x17000644 RID: 1604
		// (get) Token: 0x0600180E RID: 6158 RVA: 0x00070651 File Offset: 0x0006E851
		internal global::Infragistics.Windows.DataPresenter.DataPresenterBase DataPresenter
		{
			get
			{
				return this._dataPresenter;
			}
		}

		// Token: 0x17000645 RID: 1605
		// (get) Token: 0x0600180F RID: 6159 RVA: 0x00070659 File Offset: 0x0006E859
		private string DefaultPrompt1
		{
			get
			{
				return (string)base.GetValue(global::Infragistics.Windows.DataPresenter.GroupByAreaBase.DefaultPrompt1Property);
			}
		}

		// Token: 0x17000646 RID: 1606
		// (get) Token: 0x06001810 RID: 6160 RVA: 0x0007066B File Offset: 0x0006E86B
		private string DefaultPrompt2
		{
			get
			{
				return (string)base.GetValue(global::Infragistics.Windows.DataPresenter.GroupByAreaBase.DefaultPrompt2Property);
			}
		}

		// Token: 0x17000647 RID: 1607
		// (get) Token: 0x06001811 RID: 6161 RVA: 0x0007067D File Offset: 0x0006E87D
		internal global::System.Windows.FrameworkElement InsertionPoint
		{
			get
			{
				return this._insertionPoint;
			}
		}

		// Token: 0x17000648 RID: 1608
		// (get) Token: 0x06001812 RID: 6162 RVA: 0x00070685 File Offset: 0x0006E885
		// (set) Token: 0x06001813 RID: 6163 RVA: 0x0007068D File Offset: 0x0006E88D
		internal bool IsDragInsertionPointHighlighted
		{
			get
			{
				return this._isDragInsertionPointHighlighted;
			}
			set
			{
				this._isDragInsertionPointHighlighted = value;
			}
		}

		// Token: 0x17000649 RID: 1609
		// (get) Token: 0x06001814 RID: 6164 RVA: 0x00070696 File Offset: 0x0006E896
		// (set) Token: 0x06001815 RID: 6165 RVA: 0x0007069E File Offset: 0x0006E89E
		internal global::System.Windows.Vector LastDragInsertionPointOffset
		{
			get
			{
				return this._lastDragInsertionPointOffset;
			}
			set
			{
				this._lastDragInsertionPointOffset = value;
			}
		}

		// Token: 0x06001816 RID: 6166 RVA: 0x000706A8 File Offset: 0x0006E8A8
		private static void OnStyleVersionNumberPropertyChanged(global::System.Windows.DependencyObject target, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.DataPresenter.GroupByAreaBase groupByAreaBase = target as global::Infragistics.Windows.DataPresenter.GroupByAreaBase;
			if (groupByAreaBase != null)
			{
				groupByAreaBase.OnStyleVersionNumberChanged();
				return;
			}
			if (target != null)
			{
				throw new global::System.InvalidOperationException(global::Infragistics.Windows.DataPresenter.DataPresenterBase.GetString("LE_InvalidOperationException_12"));
			}
		}

		// Token: 0x06001817 RID: 6167 RVA: 0x000706D9 File Offset: 0x0006E8D9
		internal virtual void OnStyleVersionNumberChanged()
		{
		}

		// Token: 0x1700064A RID: 1610
		// (get) Token: 0x06001818 RID: 6168 RVA: 0x000706DB File Offset: 0x0006E8DB
		// (set) Token: 0x06001819 RID: 6169 RVA: 0x000706ED File Offset: 0x0006E8ED
		internal int StyleVersionNumber
		{
			get
			{
				return (int)base.GetValue(global::Infragistics.Windows.DataPresenter.GroupByAreaBase.StyleVersionNumberProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.GroupByAreaBase.StyleVersionNumberProperty, value);
			}
		}

		// Token: 0x0600181A RID: 6170 RVA: 0x00070700 File Offset: 0x0006E900
		internal virtual void InitializeDataPresenter(global::Infragistics.Windows.DataPresenter.DataPresenterBase dataPresenter)
		{
			if (this._dataPresenter != null)
			{
				this._dataPresenter.FieldLayoutInitialized -= this.OnFieldLayoutInitialized;
			}
			this._dataPresenter = dataPresenter;
			if (this._dataPresenter != null)
			{
				this._dataPresenter.FieldLayoutInitialized += this.OnFieldLayoutInitialized;
			}
		}

		// Token: 0x0600181B RID: 6171 RVA: 0x00070754 File Offset: 0x0006E954
		private void InitializePrompts()
		{
			if (this.Prompt1 == null)
			{
				this.Prompt1 = this.DefaultPrompt1;
			}
			if (this.Prompt2 == null)
			{
				this.Prompt2 = this.DefaultPrompt2;
			}
		}

		// Token: 0x0600181C RID: 6172 RVA: 0x0007078D File Offset: 0x0006E98D
		private void OnExpanderBarClick(object sender, global::System.Windows.RoutedEventArgs e)
		{
			global::Infragistics.Windows.DataPresenter.GroupByAreaBase.ToggleExpandedState.Execute(null, this);
		}

		// Token: 0x0600181D RID: 6173 RVA: 0x0007079B File Offset: 0x0006E99B
		private void OnLoaded(object sender, global::System.Windows.RoutedEventArgs e)
		{
			base.Loaded -= this.OnLoaded;
			if (this._showPromptsInOnLoaded)
			{
				this.OnShowPrompts();
				this._showPromptsInOnLoaded = false;
				return;
			}
			if (this._hidePromptsInOnLoaded)
			{
				this.OnHidePrompts();
				this._hidePromptsInOnLoaded = false;
			}
		}

		// Token: 0x0600181E RID: 6174 RVA: 0x000707DA File Offset: 0x0006E9DA
		internal virtual void OnThemeChanged(object sender, global::System.Windows.RoutedPropertyChangedEventArgs<string> e)
		{
		}

		// Token: 0x0600181F RID: 6175 RVA: 0x000707DC File Offset: 0x0006E9DC
		private void OnFieldLayoutInitialized(object sender, global::Infragistics.Windows.DataPresenter.Events.FieldLayoutInitializedEventArgs e)
		{
			this.OnFieldLayoutInitialized();
		}

		// Token: 0x06001820 RID: 6176 RVA: 0x000707E4 File Offset: 0x0006E9E4
		internal virtual void OnFieldLayoutInitialized()
		{
			if (this.DataPresenter == null || this.DataPresenter.DefaultFieldLayout == null)
			{
				return;
			}
			if (!this._isThemeChangedEventWired)
			{
				this._isThemeChangedEventWired = true;
				this.DataPresenter.ThemeChanged += this.OnThemeChanged;
			}
		}

		// Token: 0x06001821 RID: 6177 RVA: 0x00070823 File Offset: 0x0006EA23
		private void OnExpanderBarAreaMouseDown(object sender, global::System.Windows.Input.MouseButtonEventArgs e)
		{
			this.IsExpanded = !this.IsExpanded;
		}

		// Token: 0x06001822 RID: 6178 RVA: 0x00070834 File Offset: 0x0006EA34
		private void VerifyInsertionPoint()
		{
			global::System.Windows.DependencyObject templateChild = base.GetTemplateChild("PART_InsertionPoint");
			if (templateChild == null)
			{
				return;
			}
			global::System.Windows.FrameworkElement frameworkElement = templateChild as global::System.Windows.FrameworkElement;
			if (frameworkElement == null)
			{
				throw new global::System.NotSupportedException(global::Infragistics.Windows.DataPresenter.DataPresenterBase.GetString("LE_NotSupportedException_4", new object[]
				{
					"FrameworkElement",
					"PART_InsertionPoint",
					"GroupByArea",
					templateChild.GetType().Name
				}));
			}
			this._insertionPoint = frameworkElement;
		}

		// Token: 0x06001823 RID: 6179 RVA: 0x000708A0 File Offset: 0x0006EAA0
		private static void OnToggleExpandedState(object target, global::System.Windows.Input.ExecutedRoutedEventArgs args)
		{
			global::Infragistics.Windows.DataPresenter.GroupByAreaBase groupByAreaBase = target as global::Infragistics.Windows.DataPresenter.GroupByAreaBase;
			if (groupByAreaBase != null)
			{
				groupByAreaBase.IsExpanded = !groupByAreaBase.IsExpanded;
				return;
			}
			throw new global::System.InvalidOperationException(global::Infragistics.Windows.DataPresenter.DataPresenterBase.GetString("LE_InvalidOperationException_13"));
		}

		// Token: 0x06001824 RID: 6180 RVA: 0x000708D6 File Offset: 0x0006EAD6
		private static void OnQueryToggleExpandedState(object target, global::System.Windows.Input.CanExecuteRoutedEventArgs args)
		{
			args.CanExecute = true;
		}

		// Token: 0x06001825 RID: 6181 RVA: 0x000708E0 File Offset: 0x0006EAE0
		protected internal virtual void OnCollapsed()
		{
			global::System.Windows.RoutedEventArgs e = new global::System.Windows.RoutedEventArgs(global::Infragistics.Windows.DataPresenter.GroupByAreaBase.CollapsedEvent, this);
			base.RaiseEvent(e);
		}

		// Token: 0x14000064 RID: 100
		// (add) Token: 0x06001826 RID: 6182 RVA: 0x00070900 File Offset: 0x0006EB00
		// (remove) Token: 0x06001827 RID: 6183 RVA: 0x0007090E File Offset: 0x0006EB0E
		public event global::System.Windows.RoutedEventHandler Collapsed
		{
			add
			{
				base.AddHandler(global::Infragistics.Windows.DataPresenter.GroupByAreaBase.CollapsedEvent, value);
			}
			remove
			{
				base.RemoveHandler(global::Infragistics.Windows.DataPresenter.GroupByAreaBase.CollapsedEvent, value);
			}
		}

		// Token: 0x06001828 RID: 6184 RVA: 0x0007091C File Offset: 0x0006EB1C
		protected internal virtual void OnExpanded()
		{
			global::System.Windows.RoutedEventArgs e = new global::System.Windows.RoutedEventArgs(global::Infragistics.Windows.DataPresenter.GroupByAreaBase.ExpandedEvent, this);
			base.RaiseEvent(e);
		}

		// Token: 0x14000065 RID: 101
		// (add) Token: 0x06001829 RID: 6185 RVA: 0x0007093C File Offset: 0x0006EB3C
		// (remove) Token: 0x0600182A RID: 6186 RVA: 0x0007094A File Offset: 0x0006EB4A
		public event global::System.Windows.RoutedEventHandler Expanded
		{
			add
			{
				base.AddHandler(global::Infragistics.Windows.DataPresenter.GroupByAreaBase.ExpandedEvent, value);
			}
			remove
			{
				base.RemoveHandler(global::Infragistics.Windows.DataPresenter.GroupByAreaBase.ExpandedEvent, value);
			}
		}

		// Token: 0x0600182B RID: 6187 RVA: 0x00070958 File Offset: 0x0006EB58
		protected internal virtual void OnHideInsertionPoint()
		{
			global::System.Windows.RoutedEventArgs e = new global::System.Windows.RoutedEventArgs(global::Infragistics.Windows.DataPresenter.GroupByAreaBase.HideInsertionPointEvent, this);
			base.RaiseEvent(e);
			this._isDragInsertionPointHighlighted = false;
		}

		// Token: 0x14000066 RID: 102
		// (add) Token: 0x0600182C RID: 6188 RVA: 0x0007097F File Offset: 0x0006EB7F
		// (remove) Token: 0x0600182D RID: 6189 RVA: 0x0007098D File Offset: 0x0006EB8D
		public event global::System.Windows.RoutedEventHandler HideInsertionPoint
		{
			add
			{
				base.AddHandler(global::Infragistics.Windows.DataPresenter.GroupByAreaBase.HideInsertionPointEvent, value);
			}
			remove
			{
				base.RemoveHandler(global::Infragistics.Windows.DataPresenter.GroupByAreaBase.HideInsertionPointEvent, value);
			}
		}

		// Token: 0x0600182E RID: 6190 RVA: 0x0007099C File Offset: 0x0006EB9C
		protected internal virtual void OnHidePrompts()
		{
			if (!base.IsLoaded)
			{
				base.Loaded += this.OnLoaded;
				this._hidePromptsInOnLoaded = true;
				this._showPromptsInOnLoaded = false;
				return;
			}
			global::System.Windows.DependencyObject parent = global::System.Windows.Media.VisualTreeHelper.GetParent(this);
			if (parent != null && global::System.Windows.Media.VisualTreeHelper.GetChildrenCount(this) > 0)
			{
				global::System.Windows.RoutedEventArgs e = new global::System.Windows.RoutedEventArgs(global::Infragistics.Windows.DataPresenter.GroupByAreaBase.HidePromptsEvent, this);
				base.RaiseEvent(e);
			}
		}

		// Token: 0x14000067 RID: 103
		// (add) Token: 0x0600182F RID: 6191 RVA: 0x000709F8 File Offset: 0x0006EBF8
		// (remove) Token: 0x06001830 RID: 6192 RVA: 0x00070A06 File Offset: 0x0006EC06
		public event global::System.Windows.RoutedEventHandler HidePrompts
		{
			add
			{
				base.AddHandler(global::Infragistics.Windows.DataPresenter.GroupByAreaBase.HidePromptsEvent, value);
			}
			remove
			{
				base.RemoveHandler(global::Infragistics.Windows.DataPresenter.GroupByAreaBase.HidePromptsEvent, value);
			}
		}

		// Token: 0x06001831 RID: 6193 RVA: 0x00070A14 File Offset: 0x0006EC14
		protected internal virtual void OnShowInsertionPoint()
		{
			global::System.Windows.RoutedEventArgs e = new global::System.Windows.RoutedEventArgs(global::Infragistics.Windows.DataPresenter.GroupByAreaBase.ShowInsertionPointEvent, this);
			base.RaiseEvent(e);
			this._isDragInsertionPointHighlighted = true;
		}

		// Token: 0x14000068 RID: 104
		// (add) Token: 0x06001832 RID: 6194 RVA: 0x00070A3B File Offset: 0x0006EC3B
		// (remove) Token: 0x06001833 RID: 6195 RVA: 0x00070A49 File Offset: 0x0006EC49
		public event global::System.Windows.RoutedEventHandler ShowInsertionPoint
		{
			add
			{
				base.AddHandler(global::Infragistics.Windows.DataPresenter.GroupByAreaBase.ShowInsertionPointEvent, value);
			}
			remove
			{
				base.RemoveHandler(global::Infragistics.Windows.DataPresenter.GroupByAreaBase.ShowInsertionPointEvent, value);
			}
		}

		// Token: 0x06001834 RID: 6196 RVA: 0x00070A58 File Offset: 0x0006EC58
		protected internal virtual void OnShowPrompts()
		{
			if (!base.IsLoaded)
			{
				base.Loaded += this.OnLoaded;
				this._showPromptsInOnLoaded = true;
				this._hidePromptsInOnLoaded = false;
				return;
			}
			global::System.Windows.DependencyObject parent = global::System.Windows.Media.VisualTreeHelper.GetParent(this);
			if (parent != null && global::System.Windows.Media.VisualTreeHelper.GetChildrenCount(this) > 0)
			{
				global::System.Windows.RoutedEventArgs e = new global::System.Windows.RoutedEventArgs(global::Infragistics.Windows.DataPresenter.GroupByAreaBase.ShowPromptsEvent, this);
				base.RaiseEvent(e);
			}
		}

		// Token: 0x14000069 RID: 105
		// (add) Token: 0x06001835 RID: 6197 RVA: 0x00070AB4 File Offset: 0x0006ECB4
		// (remove) Token: 0x06001836 RID: 6198 RVA: 0x00070AC2 File Offset: 0x0006ECC2
		public event global::System.Windows.RoutedEventHandler ShowPrompts
		{
			add
			{
				base.AddHandler(global::Infragistics.Windows.DataPresenter.GroupByAreaBase.ShowPromptsEvent, value);
			}
			remove
			{
				base.RemoveHandler(global::Infragistics.Windows.DataPresenter.GroupByAreaBase.ShowPromptsEvent, value);
			}
		}

		// Token: 0x040009D6 RID: 2518
		private global::Infragistics.Windows.DataPresenter.DataPresenterBase _dataPresenter;

		// Token: 0x040009D7 RID: 2519
		private global::System.Windows.FrameworkElement _insertionPoint;

		// Token: 0x040009D8 RID: 2520
		private global::System.Windows.Shapes.Rectangle _currentFieldLabelDragElement;

		// Token: 0x040009D9 RID: 2521
		private global::System.Windows.Media.TranslateTransform _currentFieldLabelDragElementTransform;

		// Token: 0x040009DA RID: 2522
		private bool _arePropertiesHookedUp;

		// Token: 0x040009DB RID: 2523
		private bool _isDragInsertionPointHighlighted;

		// Token: 0x040009DC RID: 2524
		private global::System.Windows.Vector _lastDragInsertionPointOffset = new global::System.Windows.Vector(double.PositiveInfinity, double.PositiveInfinity);

		// Token: 0x040009DD RID: 2525
		private bool _isThemeChangedEventWired;

		// Token: 0x040009DE RID: 2526
		private bool _showPromptsInOnLoaded;

		// Token: 0x040009DF RID: 2527
		private bool _hidePromptsInOnLoaded;

		// Token: 0x040009E0 RID: 2528
		private global::System.Collections.Generic.List<global::Infragistics.Windows.Controls.ExpanderBar> _expanderBars;

		// Token: 0x040009E1 RID: 2529
		public static readonly global::System.Windows.Input.RoutedCommand ToggleExpandedState;

		// Token: 0x040009E2 RID: 2530
		internal static readonly global::System.Windows.DependencyPropertyKey FieldLabelDragInProgressPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("FieldLabelDragInProgress", typeof(bool), typeof(global::Infragistics.Windows.DataPresenter.GroupByAreaBase), new global::System.Windows.FrameworkPropertyMetadata());

		// Token: 0x040009E3 RID: 2531
		public static readonly global::System.Windows.DependencyProperty FieldLabelDragInProgressProperty = global::Infragistics.Windows.DataPresenter.GroupByAreaBase.FieldLabelDragInProgressPropertyKey.DependencyProperty;

		// Token: 0x040009E4 RID: 2532
		public static readonly global::System.Windows.DependencyProperty IsExpandedProperty = global::System.Windows.DependencyProperty.Register("IsExpanded", typeof(bool), typeof(global::Infragistics.Windows.DataPresenter.GroupByAreaBase), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox, global::System.Windows.FrameworkPropertyMetadataOptions.None, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.GroupByAreaBase.OnIsExpandedChanged)));

		// Token: 0x040009E5 RID: 2533
		public static readonly global::System.Windows.DependencyProperty Prompt1Property = global::System.Windows.DependencyProperty.Register("Prompt1", typeof(string), typeof(global::Infragistics.Windows.DataPresenter.GroupByAreaBase), new global::System.Windows.FrameworkPropertyMetadata());

		// Token: 0x040009E6 RID: 2534
		public static readonly global::System.Windows.DependencyProperty Prompt1TemplateProperty = global::System.Windows.DependencyProperty.Register("Prompt1Template", typeof(global::System.Windows.DataTemplate), typeof(global::Infragistics.Windows.DataPresenter.GroupByAreaBase), new global::System.Windows.FrameworkPropertyMetadata(null));

		// Token: 0x040009E7 RID: 2535
		public static readonly global::System.Windows.DependencyProperty Prompt2Property = global::System.Windows.DependencyProperty.Register("Prompt2", typeof(string), typeof(global::Infragistics.Windows.DataPresenter.GroupByAreaBase), new global::System.Windows.FrameworkPropertyMetadata());

		// Token: 0x040009E8 RID: 2536
		public static readonly global::System.Windows.DependencyProperty Prompt2TemplateProperty = global::System.Windows.DependencyProperty.Register("Prompt2Template", typeof(global::System.Windows.DataTemplate), typeof(global::Infragistics.Windows.DataPresenter.GroupByAreaBase), new global::System.Windows.FrameworkPropertyMetadata(null));

		// Token: 0x040009E9 RID: 2537
		private static readonly global::System.Windows.DependencyProperty DefaultPrompt1Property = global::System.Windows.DependencyProperty.Register("DefaultPrompt1", typeof(string), typeof(global::Infragistics.Windows.DataPresenter.GroupByAreaBase), new global::System.Windows.FrameworkPropertyMetadata());

		// Token: 0x040009EA RID: 2538
		private static readonly global::System.Windows.DependencyProperty DefaultPrompt2Property = global::System.Windows.DependencyProperty.Register("DefaultPrompt2", typeof(string), typeof(global::Infragistics.Windows.DataPresenter.GroupByAreaBase), new global::System.Windows.FrameworkPropertyMetadata());

		// Token: 0x040009EB RID: 2539
		internal static readonly global::System.Windows.DependencyProperty StyleVersionNumberProperty = global::System.Windows.DependencyProperty.Register("StyleVersionNumber", typeof(int), typeof(global::Infragistics.Windows.DataPresenter.GroupByAreaBase), new global::System.Windows.FrameworkPropertyMetadata(0, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.GroupByAreaBase.OnStyleVersionNumberPropertyChanged)));
	}
}
