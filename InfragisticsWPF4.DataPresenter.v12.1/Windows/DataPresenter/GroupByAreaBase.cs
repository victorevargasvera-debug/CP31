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
	// Token: 0x02000161 RID: 353
	[global::System.Windows.TemplatePart(Name = "PART_InsertionPoint", Type = typeof(global::System.Windows.FrameworkElement))]
	public abstract class GroupByAreaBase : global::System.Windows.Controls.Control
	{
		// Token: 0x0600147E RID: 5246 RVA: 0x0005DFDC File Offset: 0x0005C1DC
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

		// Token: 0x0600147F RID: 5247 RVA: 0x0005E292 File Offset: 0x0005C492
		public GroupByAreaBase() : this(null)
		{
			this.IsExpanded = true;
		}

		// Token: 0x06001480 RID: 5248 RVA: 0x0005E2A2 File Offset: 0x0005C4A2
		internal GroupByAreaBase(global::Infragistics.Windows.DataPresenter.DataPresenterBase dataPresenter)
		{
			this.InitializeDataPresenter(dataPresenter);
		}

		// Token: 0x06001481 RID: 5249 RVA: 0x0005E2CE File Offset: 0x0005C4CE
		protected override global::System.Windows.Media.Visual GetVisualChild(int index)
		{
			if (index > 0 && this.FieldLabelDragInProgress && this._currentFieldLabelDragElement != null)
			{
				return this._currentFieldLabelDragElement;
			}
			return base.GetVisualChild(index);
		}

		// Token: 0x06001482 RID: 5250 RVA: 0x0005E30C File Offset: 0x0005C50C
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

		// Token: 0x06001483 RID: 5251 RVA: 0x0005E434 File Offset: 0x0005C634
		protected override global::System.Windows.Automation.Peers.AutomationPeer OnCreateAutomationPeer()
		{
			return new global::Infragistics.Windows.Automation.Peers.DataPresenter.GroupByAreaBaseAutomationPeer(this);
		}

		// Token: 0x06001484 RID: 5252 RVA: 0x0005E43C File Offset: 0x0005C63C
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

		// Token: 0x170004F5 RID: 1269
		// (get) Token: 0x06001485 RID: 5253 RVA: 0x0005E4F9 File Offset: 0x0005C6F9
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

		// Token: 0x170004F6 RID: 1270
		// (get) Token: 0x06001486 RID: 5254 RVA: 0x0005E513 File Offset: 0x0005C713
		public bool FieldLabelDragInProgress
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.Windows.DataPresenter.GroupByAreaBase.FieldLabelDragInProgressProperty);
			}
		}

		// Token: 0x06001487 RID: 5255 RVA: 0x0005E528 File Offset: 0x0005C728
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

		// Token: 0x170004F7 RID: 1271
		// (get) Token: 0x06001488 RID: 5256 RVA: 0x0005E594 File Offset: 0x0005C794
		// (set) Token: 0x06001489 RID: 5257 RVA: 0x0005E5A6 File Offset: 0x0005C7A6
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

		// Token: 0x170004F8 RID: 1272
		// (get) Token: 0x0600148A RID: 5258 RVA: 0x0005E5B9 File Offset: 0x0005C7B9
		// (set) Token: 0x0600148B RID: 5259 RVA: 0x0005E5CB File Offset: 0x0005C7CB
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

		// Token: 0x170004F9 RID: 1273
		// (get) Token: 0x0600148C RID: 5260 RVA: 0x0005E5D9 File Offset: 0x0005C7D9
		// (set) Token: 0x0600148D RID: 5261 RVA: 0x0005E5EB File Offset: 0x0005C7EB
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

		// Token: 0x170004FA RID: 1274
		// (get) Token: 0x0600148E RID: 5262 RVA: 0x0005E5F9 File Offset: 0x0005C7F9
		// (set) Token: 0x0600148F RID: 5263 RVA: 0x0005E60B File Offset: 0x0005C80B
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

		// Token: 0x170004FB RID: 1275
		// (get) Token: 0x06001490 RID: 5264 RVA: 0x0005E619 File Offset: 0x0005C819
		// (set) Token: 0x06001491 RID: 5265 RVA: 0x0005E62B File Offset: 0x0005C82B
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

		// Token: 0x170004FC RID: 1276
		// (get) Token: 0x06001492 RID: 5266 RVA: 0x0005E63C File Offset: 0x0005C83C
		// (set) Token: 0x06001493 RID: 5267 RVA: 0x0005E6A8 File Offset: 0x0005C8A8
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

		// Token: 0x170004FD RID: 1277
		// (get) Token: 0x06001494 RID: 5268 RVA: 0x0005E6B1 File Offset: 0x0005C8B1
		internal global::System.Windows.Media.TranslateTransform CurrentFieldLabelDragElementTransform
		{
			get
			{
				return this._currentFieldLabelDragElementTransform;
			}
		}

		// Token: 0x170004FE RID: 1278
		// (get) Token: 0x06001495 RID: 5269 RVA: 0x0005E6B9 File Offset: 0x0005C8B9
		internal global::Infragistics.Windows.DataPresenter.DataPresenterBase DataPresenter
		{
			get
			{
				return this._dataPresenter;
			}
		}

		// Token: 0x170004FF RID: 1279
		// (get) Token: 0x06001496 RID: 5270 RVA: 0x0005E6C1 File Offset: 0x0005C8C1
		private string DefaultPrompt1
		{
			get
			{
				return (string)base.GetValue(global::Infragistics.Windows.DataPresenter.GroupByAreaBase.DefaultPrompt1Property);
			}
		}

		// Token: 0x17000500 RID: 1280
		// (get) Token: 0x06001497 RID: 5271 RVA: 0x0005E6D3 File Offset: 0x0005C8D3
		private string DefaultPrompt2
		{
			get
			{
				return (string)base.GetValue(global::Infragistics.Windows.DataPresenter.GroupByAreaBase.DefaultPrompt2Property);
			}
		}

		// Token: 0x17000501 RID: 1281
		// (get) Token: 0x06001498 RID: 5272 RVA: 0x0005E6E5 File Offset: 0x0005C8E5
		internal global::System.Windows.FrameworkElement InsertionPoint
		{
			get
			{
				return this._insertionPoint;
			}
		}

		// Token: 0x17000502 RID: 1282
		// (get) Token: 0x06001499 RID: 5273 RVA: 0x0005E6ED File Offset: 0x0005C8ED
		// (set) Token: 0x0600149A RID: 5274 RVA: 0x0005E6F5 File Offset: 0x0005C8F5
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

		// Token: 0x17000503 RID: 1283
		// (get) Token: 0x0600149B RID: 5275 RVA: 0x0005E6FE File Offset: 0x0005C8FE
		// (set) Token: 0x0600149C RID: 5276 RVA: 0x0005E706 File Offset: 0x0005C906
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

		// Token: 0x0600149D RID: 5277 RVA: 0x0005E710 File Offset: 0x0005C910
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

		// Token: 0x0600149E RID: 5278 RVA: 0x0005E741 File Offset: 0x0005C941
		internal virtual void OnStyleVersionNumberChanged()
		{
		}

		// Token: 0x17000504 RID: 1284
		// (get) Token: 0x0600149F RID: 5279 RVA: 0x0005E743 File Offset: 0x0005C943
		// (set) Token: 0x060014A0 RID: 5280 RVA: 0x0005E755 File Offset: 0x0005C955
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

		// Token: 0x060014A1 RID: 5281 RVA: 0x0005E768 File Offset: 0x0005C968
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

		// Token: 0x060014A2 RID: 5282 RVA: 0x0005E7BC File Offset: 0x0005C9BC
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

		// Token: 0x060014A3 RID: 5283 RVA: 0x0005E7F5 File Offset: 0x0005C9F5
		private void OnExpanderBarClick(object sender, global::System.Windows.RoutedEventArgs e)
		{
			global::Infragistics.Windows.DataPresenter.GroupByAreaBase.ToggleExpandedState.Execute(null, this);
		}

		// Token: 0x060014A4 RID: 5284 RVA: 0x0005E803 File Offset: 0x0005CA03
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

		// Token: 0x060014A5 RID: 5285 RVA: 0x0005E842 File Offset: 0x0005CA42
		internal virtual void OnThemeChanged(object sender, global::System.Windows.RoutedPropertyChangedEventArgs<string> e)
		{
		}

		// Token: 0x060014A6 RID: 5286 RVA: 0x0005E844 File Offset: 0x0005CA44
		private void OnFieldLayoutInitialized(object sender, global::Infragistics.Windows.DataPresenter.Events.FieldLayoutInitializedEventArgs e)
		{
			this.OnFieldLayoutInitialized();
		}

		// Token: 0x060014A7 RID: 5287 RVA: 0x0005E84C File Offset: 0x0005CA4C
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

		// Token: 0x060014A8 RID: 5288 RVA: 0x0005E88B File Offset: 0x0005CA8B
		private void OnExpanderBarAreaMouseDown(object sender, global::System.Windows.Input.MouseButtonEventArgs e)
		{
			this.IsExpanded = !this.IsExpanded;
		}

		// Token: 0x060014A9 RID: 5289 RVA: 0x0005E89C File Offset: 0x0005CA9C
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

		// Token: 0x060014AA RID: 5290 RVA: 0x0005E908 File Offset: 0x0005CB08
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

		// Token: 0x060014AB RID: 5291 RVA: 0x0005E93E File Offset: 0x0005CB3E
		private static void OnQueryToggleExpandedState(object target, global::System.Windows.Input.CanExecuteRoutedEventArgs args)
		{
			args.CanExecute = true;
		}

		// Token: 0x060014AC RID: 5292 RVA: 0x0005E948 File Offset: 0x0005CB48
		protected internal virtual void OnCollapsed()
		{
			global::System.Windows.RoutedEventArgs e = new global::System.Windows.RoutedEventArgs(global::Infragistics.Windows.DataPresenter.GroupByAreaBase.CollapsedEvent, this);
			base.RaiseEvent(e);
		}

		// Token: 0x14000063 RID: 99
		// (add) Token: 0x060014AD RID: 5293 RVA: 0x0005E968 File Offset: 0x0005CB68
		// (remove) Token: 0x060014AE RID: 5294 RVA: 0x0005E976 File Offset: 0x0005CB76
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

		// Token: 0x060014AF RID: 5295 RVA: 0x0005E984 File Offset: 0x0005CB84
		protected internal virtual void OnExpanded()
		{
			global::System.Windows.RoutedEventArgs e = new global::System.Windows.RoutedEventArgs(global::Infragistics.Windows.DataPresenter.GroupByAreaBase.ExpandedEvent, this);
			base.RaiseEvent(e);
		}

		// Token: 0x14000064 RID: 100
		// (add) Token: 0x060014B0 RID: 5296 RVA: 0x0005E9A4 File Offset: 0x0005CBA4
		// (remove) Token: 0x060014B1 RID: 5297 RVA: 0x0005E9B2 File Offset: 0x0005CBB2
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

		// Token: 0x060014B2 RID: 5298 RVA: 0x0005E9C0 File Offset: 0x0005CBC0
		protected internal virtual void OnHideInsertionPoint()
		{
			global::System.Windows.RoutedEventArgs e = new global::System.Windows.RoutedEventArgs(global::Infragistics.Windows.DataPresenter.GroupByAreaBase.HideInsertionPointEvent, this);
			base.RaiseEvent(e);
			this._isDragInsertionPointHighlighted = false;
		}

		// Token: 0x14000065 RID: 101
		// (add) Token: 0x060014B3 RID: 5299 RVA: 0x0005E9E7 File Offset: 0x0005CBE7
		// (remove) Token: 0x060014B4 RID: 5300 RVA: 0x0005E9F5 File Offset: 0x0005CBF5
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

		// Token: 0x060014B5 RID: 5301 RVA: 0x0005EA04 File Offset: 0x0005CC04
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

		// Token: 0x14000066 RID: 102
		// (add) Token: 0x060014B6 RID: 5302 RVA: 0x0005EA60 File Offset: 0x0005CC60
		// (remove) Token: 0x060014B7 RID: 5303 RVA: 0x0005EA6E File Offset: 0x0005CC6E
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

		// Token: 0x060014B8 RID: 5304 RVA: 0x0005EA7C File Offset: 0x0005CC7C
		protected internal virtual void OnShowInsertionPoint()
		{
			global::System.Windows.RoutedEventArgs e = new global::System.Windows.RoutedEventArgs(global::Infragistics.Windows.DataPresenter.GroupByAreaBase.ShowInsertionPointEvent, this);
			base.RaiseEvent(e);
			this._isDragInsertionPointHighlighted = true;
		}

		// Token: 0x14000067 RID: 103
		// (add) Token: 0x060014B9 RID: 5305 RVA: 0x0005EAA3 File Offset: 0x0005CCA3
		// (remove) Token: 0x060014BA RID: 5306 RVA: 0x0005EAB1 File Offset: 0x0005CCB1
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

		// Token: 0x060014BB RID: 5307 RVA: 0x0005EAC0 File Offset: 0x0005CCC0
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

		// Token: 0x14000068 RID: 104
		// (add) Token: 0x060014BC RID: 5308 RVA: 0x0005EB1C File Offset: 0x0005CD1C
		// (remove) Token: 0x060014BD RID: 5309 RVA: 0x0005EB2A File Offset: 0x0005CD2A
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

		// Token: 0x04000821 RID: 2081
		private global::Infragistics.Windows.DataPresenter.DataPresenterBase _dataPresenter;

		// Token: 0x04000822 RID: 2082
		private global::System.Windows.FrameworkElement _insertionPoint;

		// Token: 0x04000823 RID: 2083
		private global::System.Windows.Shapes.Rectangle _currentFieldLabelDragElement;

		// Token: 0x04000824 RID: 2084
		private global::System.Windows.Media.TranslateTransform _currentFieldLabelDragElementTransform;

		// Token: 0x04000825 RID: 2085
		private bool _arePropertiesHookedUp;

		// Token: 0x04000826 RID: 2086
		private bool _isDragInsertionPointHighlighted;

		// Token: 0x04000827 RID: 2087
		private global::System.Windows.Vector _lastDragInsertionPointOffset = new global::System.Windows.Vector(double.PositiveInfinity, double.PositiveInfinity);

		// Token: 0x04000828 RID: 2088
		private bool _isThemeChangedEventWired;

		// Token: 0x04000829 RID: 2089
		private bool _showPromptsInOnLoaded;

		// Token: 0x0400082A RID: 2090
		private bool _hidePromptsInOnLoaded;

		// Token: 0x0400082B RID: 2091
		private global::System.Collections.Generic.List<global::Infragistics.Windows.Controls.ExpanderBar> _expanderBars;

		// Token: 0x0400082C RID: 2092
		public static readonly global::System.Windows.Input.RoutedCommand ToggleExpandedState;

		// Token: 0x0400082D RID: 2093
		internal static readonly global::System.Windows.DependencyPropertyKey FieldLabelDragInProgressPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("FieldLabelDragInProgress", typeof(bool), typeof(global::Infragistics.Windows.DataPresenter.GroupByAreaBase), new global::System.Windows.FrameworkPropertyMetadata());

		// Token: 0x0400082E RID: 2094
		public static readonly global::System.Windows.DependencyProperty FieldLabelDragInProgressProperty = global::Infragistics.Windows.DataPresenter.GroupByAreaBase.FieldLabelDragInProgressPropertyKey.DependencyProperty;

		// Token: 0x0400082F RID: 2095
		public static readonly global::System.Windows.DependencyProperty IsExpandedProperty = global::System.Windows.DependencyProperty.Register("IsExpanded", typeof(bool), typeof(global::Infragistics.Windows.DataPresenter.GroupByAreaBase), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox, global::System.Windows.FrameworkPropertyMetadataOptions.None, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.GroupByAreaBase.OnIsExpandedChanged)));

		// Token: 0x04000830 RID: 2096
		public static readonly global::System.Windows.DependencyProperty Prompt1Property = global::System.Windows.DependencyProperty.Register("Prompt1", typeof(string), typeof(global::Infragistics.Windows.DataPresenter.GroupByAreaBase), new global::System.Windows.FrameworkPropertyMetadata());

		// Token: 0x04000831 RID: 2097
		public static readonly global::System.Windows.DependencyProperty Prompt1TemplateProperty = global::System.Windows.DependencyProperty.Register("Prompt1Template", typeof(global::System.Windows.DataTemplate), typeof(global::Infragistics.Windows.DataPresenter.GroupByAreaBase), new global::System.Windows.FrameworkPropertyMetadata(null));

		// Token: 0x04000832 RID: 2098
		public static readonly global::System.Windows.DependencyProperty Prompt2Property = global::System.Windows.DependencyProperty.Register("Prompt2", typeof(string), typeof(global::Infragistics.Windows.DataPresenter.GroupByAreaBase), new global::System.Windows.FrameworkPropertyMetadata());

		// Token: 0x04000833 RID: 2099
		public static readonly global::System.Windows.DependencyProperty Prompt2TemplateProperty = global::System.Windows.DependencyProperty.Register("Prompt2Template", typeof(global::System.Windows.DataTemplate), typeof(global::Infragistics.Windows.DataPresenter.GroupByAreaBase), new global::System.Windows.FrameworkPropertyMetadata(null));

		// Token: 0x04000834 RID: 2100
		private static readonly global::System.Windows.DependencyProperty DefaultPrompt1Property = global::System.Windows.DependencyProperty.Register("DefaultPrompt1", typeof(string), typeof(global::Infragistics.Windows.DataPresenter.GroupByAreaBase), new global::System.Windows.FrameworkPropertyMetadata());

		// Token: 0x04000835 RID: 2101
		private static readonly global::System.Windows.DependencyProperty DefaultPrompt2Property = global::System.Windows.DependencyProperty.Register("DefaultPrompt2", typeof(string), typeof(global::Infragistics.Windows.DataPresenter.GroupByAreaBase), new global::System.Windows.FrameworkPropertyMetadata());

		// Token: 0x04000836 RID: 2102
		internal static readonly global::System.Windows.DependencyProperty StyleVersionNumberProperty = global::System.Windows.DependencyProperty.Register("StyleVersionNumber", typeof(int), typeof(global::Infragistics.Windows.DataPresenter.GroupByAreaBase), new global::System.Windows.FrameworkPropertyMetadata(0, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.GroupByAreaBase.OnStyleVersionNumberPropertyChanged)));
	}
}
