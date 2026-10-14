using System;
using System.ComponentModel;
using System.IO;
using System.Threading;
using System.Windows;
using System.Windows.Automation.Peers;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Threading;
using Infragistics.Windows.Automation.Peers;
using Infragistics.Windows.Commands;
using Infragistics.Windows.Controls.Events;
using Infragistics.Windows.Helpers;
using Infragistics.Windows.Internal;
using Infragistics.Windows.Licensing;
using Infragistics.Windows.Themes;
using Infragistics.Windows.Themes.Internal;

namespace Infragistics.Windows.Controls
{
	// Token: 0x0200028B RID: 651
	[global::System.Windows.TemplatePart(Name = "PART_SelectedContentHost", Type = typeof(global::System.Windows.Controls.ContentPresenter))]
	[global::System.Windows.TemplatePart(Name = "PART_Popup", Type = typeof(global::System.Windows.Controls.Primitives.Popup))]
	[global::System.Windows.TemplatePart(Name = "PART_TabItemScrollViewer", Type = typeof(global::System.Windows.Controls.ScrollViewer))]
	[global::System.Windows.TemplatePart(Name = "PART_SelectedContentHostMinimized", Type = typeof(global::System.Windows.Controls.ContentPresenter))]
	[global::System.Windows.TemplatePart(Name = "PART_HeaderArea", Type = typeof(global::System.Windows.FrameworkElement))]
	[global::System.ComponentModel.LicenseProvider(typeof(global::Infragistics.Windows.Licensing.UltraLicenseProvider))]
	[global::Infragistics.Windows.Licensing.UltraLicense("XamTabControl", global::Infragistics.Windows.Licensing.UltraLicenseAttribute.WpfProductType.DV | global::Infragistics.Windows.Licensing.UltraLicenseAttribute.WpfProductType.LOB)]
	public class XamTabControl : global::System.Windows.Controls.TabControl, global::Infragistics.Windows.Commands.ICommandHost
	{
		// Token: 0x06001A44 RID: 6724 RVA: 0x00065B38 File Offset: 0x00063D38
		static XamTabControl()
		{
			global::Infragistics.Windows.Controls.XamTabControl.ThemeChangedEvent = global::Infragistics.Windows.Themes.ThemeManager.ThemeChangedEvent.AddOwner(typeof(global::Infragistics.Windows.Controls.XamTabControl));
			global::Infragistics.Windows.Controls.XamTabControl.DropDownClosedEvent = global::System.Windows.EventManager.RegisterRoutedEvent("DropDownClosed", global::System.Windows.RoutingStrategy.Bubble, typeof(global::System.Windows.RoutedEventHandler), typeof(global::Infragistics.Windows.Controls.XamTabControl));
			global::Infragistics.Windows.Controls.XamTabControl.DropDownOpenedEvent = global::System.Windows.EventManager.RegisterRoutedEvent("DropDownOpened", global::System.Windows.RoutingStrategy.Bubble, typeof(global::System.Windows.RoutedEventHandler), typeof(global::Infragistics.Windows.Controls.XamTabControl));
			global::Infragistics.Windows.Controls.XamTabControl.DropDownOpeningEvent = global::System.Windows.EventManager.RegisterRoutedEvent("DropDownOpening", global::System.Windows.RoutingStrategy.Bubble, typeof(global::System.EventHandler<global::Infragistics.Windows.Controls.Events.TabControlDropDownOpeningEventArgs>), typeof(global::Infragistics.Windows.Controls.XamTabControl));
			global::Infragistics.Windows.Controls.XamTabControl.ExecutingCommandEvent = global::System.Windows.EventManager.RegisterRoutedEvent("ExecutingCommand", global::System.Windows.RoutingStrategy.Bubble, typeof(global::System.EventHandler<global::Infragistics.Windows.Controls.Events.ExecutingCommandEventArgs>), typeof(global::Infragistics.Windows.Controls.XamTabControl));
			global::Infragistics.Windows.Controls.XamTabControl.ExecutedCommandEvent = global::System.Windows.EventManager.RegisterRoutedEvent("ExecutedCommand", global::System.Windows.RoutingStrategy.Bubble, typeof(global::System.EventHandler<global::Infragistics.Windows.Controls.Events.ExecutedCommandEventArgs>), typeof(global::Infragistics.Windows.Controls.XamTabControl));
			global::Infragistics.Windows.Controls.XamTabControl.CloseButtonStyleKey = new global::Infragistics.Windows.Themes.StaticPropertyResourceKey(typeof(global::Infragistics.Windows.Controls.XamTabControl), "CloseButtonStyleKey");
			global::Infragistics.Windows.Controls.XamTabControl.MultiRowTabItemPagerStyleKey = new global::Infragistics.Windows.Themes.StaticPropertyResourceKey(typeof(global::Infragistics.Windows.Controls.XamTabControl), "MultiRowTabItemPagerStyleKey");
			global::Infragistics.Windows.Controls.XamTabControl.ScrollDownButtonStyleKey = new global::Infragistics.Windows.Themes.StaticPropertyResourceKey(typeof(global::Infragistics.Windows.Controls.XamTabControl), "ScrollDownButtonStyleKey");
			global::Infragistics.Windows.Controls.XamTabControl.ScrollLeftButtonStyleKey = new global::Infragistics.Windows.Themes.StaticPropertyResourceKey(typeof(global::Infragistics.Windows.Controls.XamTabControl), "ScrollLeftButtonStyleKey");
			global::Infragistics.Windows.Controls.XamTabControl.ScrollRightButtonStyleKey = new global::Infragistics.Windows.Themes.StaticPropertyResourceKey(typeof(global::Infragistics.Windows.Controls.XamTabControl), "ScrollRightButtonStyleKey");
			global::Infragistics.Windows.Controls.XamTabControl.ScrollUpButtonStyleKey = new global::Infragistics.Windows.Themes.StaticPropertyResourceKey(typeof(global::Infragistics.Windows.Controls.XamTabControl), "ScrollUpButtonStyleKey");
			global::Infragistics.Windows.Controls.XamTabControl.SingleRowTabItemPagerStyleKey = new global::Infragistics.Windows.Themes.StaticPropertyResourceKey(typeof(global::Infragistics.Windows.Controls.XamTabControl), "SingleRowTabItemPagerStyleKey");
			global::System.Windows.FrameworkElement.DefaultStyleKeyProperty.OverrideMetadata(typeof(global::Infragistics.Windows.Controls.XamTabControl), new global::System.Windows.FrameworkPropertyMetadata(typeof(global::Infragistics.Windows.Controls.XamTabControl)));
			global::Infragistics.Windows.Themes.ThemeManager.RegisterGroupings(typeof(global::Infragistics.Windows.Controls.XamTabControl), new string[]
			{
				global::Infragistics.Windows.Themes.PrimitivesResourceSet<global::Infragistics.Windows.Themes.PrimitivesGeneric.Locator>.Location.Grouping
			});
			global::System.Windows.Controls.TabControl.TabStripPlacementProperty.OverrideMetadata(typeof(global::Infragistics.Windows.Controls.XamTabControl), new global::System.Windows.FrameworkPropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.Controls.XamTabControl.OnTabStripPlacementChanged)));
			global::System.Windows.FrameworkElementFactory frameworkElementFactory = new global::System.Windows.FrameworkElementFactory(typeof(global::Infragistics.Windows.Controls.TabItemPanel));
			global::System.Windows.Data.RelativeSource relativeSource = new global::System.Windows.Data.RelativeSource(global::System.Windows.Data.RelativeSourceMode.FindAncestor, typeof(global::Infragistics.Windows.Controls.XamTabControl), 1);
			frameworkElementFactory.SetBinding(global::Infragistics.Windows.Controls.XamTabControl.InterTabSpacingProperty, global::Infragistics.Windows.Utilities.CreateBindingObject(global::Infragistics.Windows.Controls.XamTabControl.InterTabSpacingProperty, global::System.Windows.Data.BindingMode.OneWay, relativeSource));
			frameworkElementFactory.SetBinding(global::Infragistics.Windows.Controls.XamTabControl.TabLayoutStyleProperty, global::Infragistics.Windows.Utilities.CreateBindingObject(global::Infragistics.Windows.Controls.XamTabControl.TabLayoutStyleProperty, global::System.Windows.Data.BindingMode.OneWay, relativeSource));
			frameworkElementFactory.SetBinding(global::Infragistics.Windows.Controls.XamTabControl.MaximumSizeToFitAdjustmentProperty, global::Infragistics.Windows.Utilities.CreateBindingObject(global::Infragistics.Windows.Controls.XamTabControl.MaximumSizeToFitAdjustmentProperty, global::System.Windows.Data.BindingMode.OneWay, relativeSource));
			frameworkElementFactory.SetBinding(global::Infragistics.Windows.Controls.XamTabControl.MinimumTabExtentProperty, global::Infragistics.Windows.Utilities.CreateBindingObject(global::Infragistics.Windows.Controls.XamTabControl.MinimumTabExtentProperty, global::System.Windows.Data.BindingMode.OneWay, relativeSource));
			frameworkElementFactory.SetBinding(global::System.Windows.Controls.TabControl.TabStripPlacementProperty, global::Infragistics.Windows.Utilities.CreateBindingObject(global::System.Windows.Controls.TabControl.TabStripPlacementProperty, global::System.Windows.Data.BindingMode.OneWay, relativeSource));
			frameworkElementFactory.SetValue(global::System.Windows.Controls.Panel.IsItemsHostProperty, global::Infragistics.KnownBoxes.TrueBox);
			frameworkElementFactory.SetBinding(global::Infragistics.Windows.Controls.XamTabControl.InterRowSpacingProperty, global::Infragistics.Windows.Utilities.CreateBindingObject(global::Infragistics.Windows.Controls.XamTabControl.InterRowSpacingProperty, global::System.Windows.Data.BindingMode.OneWay, relativeSource));
			frameworkElementFactory.SetBinding(global::Infragistics.Windows.Controls.XamTabControl.MaximumTabRowsProperty, global::Infragistics.Windows.Utilities.CreateBindingObject(global::Infragistics.Windows.Controls.XamTabControl.MaximumTabRowsProperty, global::System.Windows.Data.BindingMode.OneWay, relativeSource));
			global::System.Windows.Controls.ItemsPanelTemplate itemsPanelTemplate = new global::System.Windows.Controls.ItemsPanelTemplate(frameworkElementFactory);
			itemsPanelTemplate.Seal();
			global::System.Windows.Controls.ItemsControl.ItemsPanelProperty.OverrideMetadata(typeof(global::Infragistics.Windows.Controls.XamTabControl), new global::System.Windows.FrameworkPropertyMetadata(itemsPanelTemplate));
			global::System.Windows.EventManager.RegisterClassHandler(typeof(global::System.Windows.Controls.Primitives.Popup), global::System.Windows.Input.Mouse.PreviewMouseUpEvent, new global::System.Windows.Input.MouseButtonEventHandler(global::Infragistics.Windows.Controls.XamTabControl.OnPopupPreviewMouseUp_ClassHandler));
		}

		// Token: 0x06001A45 RID: 6725 RVA: 0x00066530 File Offset: 0x00064730
		public XamTabControl()
		{
			try
			{
				this._license = (global::System.ComponentModel.LicenseManager.Validate(typeof(global::Infragistics.Windows.Controls.XamTabControl), this) as global::Infragistics.Windows.Licensing.UltraLicense);
			}
			catch (global::System.IO.FileNotFoundException)
			{
			}
			this.VerifyScrollBarVisibility();
			base.SetValue(global::Infragistics.Windows.Controls.XamTabControl.PreferredDropDownPlacementCallbackPropertyKey, new global::System.Windows.Controls.Primitives.CustomPopupPlacementCallback(this.GetPreferredPopupPlacement));
		}

		// Token: 0x06001A46 RID: 6726 RVA: 0x0006659C File Offset: 0x0006479C
		public override void OnApplyTemplate()
		{
			if (this._cpMinimized != null)
			{
				this._cpMinimized.ClearValue(global::System.Windows.Controls.ContentPresenter.ContentProperty);
			}
			if (this._cpMaximized != null)
			{
				this._cpMaximized.ClearValue(global::System.Windows.Controls.ContentPresenter.ContentProperty);
			}
			base.OnApplyTemplate();
			this._cpMinimized = (base.GetTemplateChild("PART_SelectedContentHostMinimized") as global::System.Windows.Controls.ContentPresenter);
			this._cpMaximized = (base.GetTemplateChild("PART_SelectedContentHost") as global::System.Windows.Controls.ContentPresenter);
			this._tabItemScrollViewer = (base.GetTemplateChild("PART_TabItemScrollViewer") as global::System.Windows.Controls.ScrollViewer);
			if (this._popup != null)
			{
				this._popup.Closed -= this.OnPopupClosed;
			}
			this._popup = (base.GetTemplateChild("PART_Popup") as global::System.Windows.Controls.Primitives.Popup);
			if (this._popup != null)
			{
				this._popup.Closed += this.OnPopupClosed;
			}
			if (this._tabItemScrollViewer != null)
			{
				base.SetBinding(global::Infragistics.Windows.Controls.XamTabControl.ComputedTabItemHorizontalScrollBarVisibilityProperty, global::Infragistics.Windows.Utilities.CreateBindingObject(global::System.Windows.Controls.ScrollViewer.ComputedHorizontalScrollBarVisibilityProperty, global::System.Windows.Data.BindingMode.OneWay, this._tabItemScrollViewer));
				base.SetBinding(global::Infragistics.Windows.Controls.XamTabControl.ComputedTabItemVerticalScrollBarVisibilityProperty, global::Infragistics.Windows.Utilities.CreateBindingObject(global::System.Windows.Controls.ScrollViewer.ComputedVerticalScrollBarVisibilityProperty, global::System.Windows.Data.BindingMode.OneWay, this._tabItemScrollViewer));
			}
			else
			{
				global::System.Windows.Data.BindingOperations.ClearBinding(this, global::Infragistics.Windows.Controls.XamTabControl.ComputedTabItemHorizontalScrollBarVisibilityProperty);
				global::System.Windows.Data.BindingOperations.ClearBinding(this, global::Infragistics.Windows.Controls.XamTabControl.ComputedTabItemVerticalScrollBarVisibilityProperty);
			}
			global::System.Windows.FrameworkElement frameworkElement = base.GetTemplateChild("PART_HeaderArea") as global::System.Windows.FrameworkElement;
			if (frameworkElement != null)
			{
				base.SetBinding(global::Infragistics.Windows.Controls.XamTabControl.TabHeaderHeightProperty, new global::System.Windows.Data.Binding("ActualHeight")
				{
					Source = frameworkElement
				});
			}
			else
			{
				global::System.Windows.Data.BindingOperations.ClearBinding(this, global::Infragistics.Windows.Controls.XamTabControl.TabHeaderHeightProperty);
			}
			if (this.IsMinimized)
			{
				this.VerifyMinimizedContentBinding();
			}
		}

		// Token: 0x06001A47 RID: 6727 RVA: 0x0006671D File Offset: 0x0006491D
		protected override global::System.Windows.Automation.Peers.AutomationPeer OnCreateAutomationPeer()
		{
			return new global::Infragistics.Windows.Automation.Peers.XamTabControlAutomationPeer(this);
		}

		// Token: 0x06001A48 RID: 6728 RVA: 0x00066725 File Offset: 0x00064925
		protected override void OnInitialized(global::System.EventArgs e)
		{
			if (base.ItemContainerGenerator != null)
			{
				base.ItemContainerGenerator.StatusChanged += this.OnGeneratorStatusChanged;
			}
			base.OnInitialized(e);
		}

		// Token: 0x06001A49 RID: 6729 RVA: 0x0006674D File Offset: 0x0006494D
		protected override void OnKeyDown(global::System.Windows.Input.KeyEventArgs e)
		{
			base.OnKeyDown(e);
			if (!e.Handled && global::Infragistics.Windows.Controls.TabControlCommands.Instance.ProcessKeyboardInput(e, this))
			{
				e.Handled = true;
			}
		}

		// Token: 0x06001A4A RID: 6730 RVA: 0x00066773 File Offset: 0x00064973
		protected override void OnMouseDoubleClick(global::System.Windows.Input.MouseButtonEventArgs e)
		{
			base.OnMouseDoubleClick(e);
		}

		// Token: 0x06001A4B RID: 6731 RVA: 0x0006677C File Offset: 0x0006497C
		protected override global::System.Windows.DependencyObject GetContainerForItemOverride()
		{
			return new global::Infragistics.Windows.Controls.TabItemEx();
		}

		// Token: 0x06001A4C RID: 6732 RVA: 0x00066784 File Offset: 0x00064984
		private global::System.Windows.Controls.TabItem GetTabItem(global::System.Windows.Input.MouseEventArgs mouseArgs)
		{
			global::System.Windows.Point position = mouseArgs.GetPosition(this);
			global::System.Windows.DependencyObject dependencyObject = base.InputHitTest(position) as global::System.Windows.DependencyObject;
			if (dependencyObject == null)
			{
				return null;
			}
			global::System.Windows.Controls.TabItem tabItem = global::Infragistics.Windows.Utilities.GetAncestorFromType(dependencyObject, typeof(global::System.Windows.Controls.TabItem), true, this) as global::System.Windows.Controls.TabItem;
			if (tabItem != null)
			{
				int num = base.ItemContainerGenerator.IndexFromContainer(tabItem);
				if (num < 0)
				{
					tabItem = null;
				}
			}
			if (tabItem != null)
			{
				global::System.Windows.DependencyObject dependencyObject2 = mouseArgs.OriginalSource as global::System.Windows.DependencyObject;
				while (dependencyObject2 is global::System.Windows.ContentElement)
				{
					dependencyObject2 = global::System.Windows.LogicalTreeHelper.GetParent(dependencyObject2);
				}
				global::System.Windows.UIElement uielement = dependencyObject2 as global::System.Windows.UIElement;
				if (uielement != null && uielement.InputHitTest(mouseArgs.GetPosition(uielement)) != null && !tabItem.IsAncestorOf(uielement))
				{
					return null;
				}
			}
			return tabItem;
		}

		// Token: 0x06001A4D RID: 6733 RVA: 0x00066828 File Offset: 0x00064A28
		protected override void OnPreviewMouseLeftButtonDown(global::System.Windows.Input.MouseButtonEventArgs e)
		{
			global::System.Windows.Point position = e.GetPosition(this);
			global::System.Windows.Controls.TabItem tabItem = this.GetTabItem(e);
			this._eatNextMouseLeftButtonUp = false;
			bool flag = tabItem != null && tabItem.Focusable;
			if (tabItem != null)
			{
				global::System.Windows.DependencyObject dependencyObject = base.InputHitTest(position) as global::System.Windows.DependencyObject;
				if (dependencyObject != null)
				{
					global::System.Windows.Controls.Primitives.ButtonBase buttonBase = dependencyObject as global::System.Windows.Controls.Primitives.ButtonBase;
					if (buttonBase == null)
					{
						buttonBase = (global::Infragistics.Windows.Utilities.GetAncestorFromType(dependencyObject, typeof(global::System.Windows.Controls.Primitives.ButtonBase), true, tabItem) as global::System.Windows.Controls.Primitives.ButtonBase);
					}
					if (buttonBase != null && buttonBase.IsEnabled)
					{
						base.OnPreviewMouseLeftButtonDown(e);
						return;
					}
				}
				bool flag2 = false;
				bool flag3 = tabItem != null && tabItem.IsSelected;
				int doubleClickTime = global::Infragistics.Windows.Helpers.NativeWindowMethods.DoubleClickTime;
				global::System.Windows.Size doubleClickSize = global::Infragistics.Windows.Helpers.NativeWindowMethods.DoubleClickSize;
				double num = global::System.Math.Abs(position.X - this._lastSingleLeftMouseDownPoint.X);
				double num2 = global::System.Math.Abs(position.Y - this._lastSingleLeftMouseDownPoint.Y);
				if (e.Timestamp - this._lastSingleLeftMouseDownTime < doubleClickTime && num <= doubleClickSize.Width && num2 <= doubleClickSize.Height)
				{
					flag2 = true;
				}
				else
				{
					if (flag3 || this.IsMinimized)
					{
						this._lastSingleLeftMouseDownTime = e.Timestamp;
						this._lastSingleLeftMouseDownPoint = position;
					}
					if (!flag)
					{
						e.Handled = true;
					}
					if (this.IsDropDownOpen && (flag3 || tabItem == null))
					{
						this.IsDropDownOpen = false;
						return;
					}
				}
				if (!flag3)
				{
					if (this.IsMinimized)
					{
						flag = false;
						this._eatNextMouseLeftButtonUp = true;
					}
					global::Infragistics.DependencyPropertyUtilities.SetCurrentValue(tabItem, global::System.Windows.Controls.TabItem.IsSelectedProperty, global::Infragistics.KnownBoxes.TrueBox);
				}
				tabItem.BringIntoView();
				if (!flag)
				{
					e.Handled = true;
				}
				if (flag2 && this.AllowMinimize)
				{
					this.IsMinimized = !this.IsMinimized;
					e.Handled = true;
				}
				if (!e.Handled && flag)
				{
					base.OnPreviewMouseLeftButtonDown(e);
				}
			}
		}

		// Token: 0x06001A4E RID: 6734 RVA: 0x000669D1 File Offset: 0x00064BD1
		protected override void OnPreviewMouseLeftButtonUp(global::System.Windows.Input.MouseButtonEventArgs e)
		{
			if (this._eatNextMouseLeftButtonUp)
			{
				this._eatNextMouseLeftButtonUp = false;
				e.Handled = true;
				return;
			}
			base.OnPreviewMouseLeftButtonUp(e);
		}

		// Token: 0x06001A4F RID: 6735 RVA: 0x000669F4 File Offset: 0x00064BF4
		protected override void OnPropertyChanged(global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			if (e.Property == global::System.Windows.Controls.Control.TemplateProperty)
			{
				if (this._cpMinimized != null)
				{
					this._cpMinimized.ClearValue(global::System.Windows.Controls.ContentControl.ContentProperty);
				}
				if (this._cpMaximized != null)
				{
					this._cpMaximized.ClearValue(global::System.Windows.Controls.ContentControl.ContentProperty);
				}
			}
			base.OnPropertyChanged(e);
		}

		// Token: 0x06001A50 RID: 6736 RVA: 0x00066A48 File Offset: 0x00064C48
		protected override void OnSelectionChanged(global::System.Windows.Controls.SelectionChangedEventArgs e)
		{
			if (this._initializingSelection)
			{
				return;
			}
			if (e.AddedItems.Count == 1 && this.IsMinimized)
			{
				if (this._suppressSelectionChangeCount > 0)
				{
					this._initializingSelection = true;
					try
					{
						base.SelectedIndex = -1;
					}
					finally
					{
						this._initializingSelection = false;
					}
					return;
				}
				bool isDropDownOpen = this.IsDropDownOpen;
				this.IsDropDownOpen = true;
				if (isDropDownOpen)
				{
					this.InitializeDropdownLocationInfo();
				}
			}
			if (base.IsInitialized && e.AddedItems.Count == 1)
			{
				global::System.Windows.Controls.TabItem selectedTabItem = this.GetSelectedTabItem();
				if (selectedTabItem != null)
				{
					selectedTabItem.BringIntoView();
				}
			}
			base.OnSelectionChanged(e);
			this.RefreshSelectedTabPeerChildren();
		}

		// Token: 0x17000626 RID: 1574
		// (get) Token: 0x06001A51 RID: 6737 RVA: 0x00066AF0 File Offset: 0x00064CF0
		internal bool HasVerticalTabs
		{
			get
			{
				return base.TabStripPlacement == global::System.Windows.Controls.Dock.Left || base.TabStripPlacement == global::System.Windows.Controls.Dock.Right;
			}
		}

		// Token: 0x06001A52 RID: 6738 RVA: 0x00066B08 File Offset: 0x00064D08
		private static void OnIsMultiRowChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.Controls.XamTabControl xamTabControl = d as global::Infragistics.Windows.Controls.XamTabControl;
			if (xamTabControl != null)
			{
				xamTabControl.VerifyScrollBarVisibility();
			}
		}

		// Token: 0x17000627 RID: 1575
		// (get) Token: 0x06001A53 RID: 6739 RVA: 0x00066B25 File Offset: 0x00064D25
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.ReadOnly(true)]
		public bool IsMultiRow
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.Windows.Controls.XamTabControl.IsMultiRowProperty);
			}
		}

		// Token: 0x17000628 RID: 1576
		// (get) Token: 0x06001A54 RID: 6740 RVA: 0x00066B37 File Offset: 0x00064D37
		internal global::System.Windows.FrameworkElement HeaderArea
		{
			get
			{
				return base.GetTemplateChild("PART_HeaderArea") as global::System.Windows.FrameworkElement;
			}
		}

		// Token: 0x17000629 RID: 1577
		// (get) Token: 0x06001A55 RID: 6741 RVA: 0x00066B49 File Offset: 0x00064D49
		internal int InternalVersion
		{
			get
			{
				return (int)base.GetValue(global::Infragistics.Windows.Controls.XamTabControl.InternalVersionProperty);
			}
		}

		// Token: 0x1700062A RID: 1578
		// (get) Token: 0x06001A56 RID: 6742 RVA: 0x00066B5B File Offset: 0x00064D5B
		internal global::System.Windows.Controls.ContentPresenter MinimizedContentPresenter
		{
			get
			{
				return this._cpMinimized;
			}
		}

		// Token: 0x06001A57 RID: 6743 RVA: 0x00066B64 File Offset: 0x00064D64
		private static void OnAllowMinimizeChanged(global::System.Windows.DependencyObject target, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.Controls.XamTabControl xamTabControl = target as global::Infragistics.Windows.Controls.XamTabControl;
			if (xamTabControl != null)
			{
				xamTabControl.RaiseAutomationExpandCollapseStateChanged();
			}
		}

		// Token: 0x1700062B RID: 1579
		// (get) Token: 0x06001A58 RID: 6744 RVA: 0x00066B81 File Offset: 0x00064D81
		// (set) Token: 0x06001A59 RID: 6745 RVA: 0x00066B93 File Offset: 0x00064D93
		[global::System.ComponentModel.Bindable(true)]
		public bool AllowMinimize
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.Windows.Controls.XamTabControl.AllowMinimizeProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.Controls.XamTabControl.AllowMinimizeProperty, value);
			}
		}

		// Token: 0x06001A5A RID: 6746 RVA: 0x00066BA8 File Offset: 0x00064DA8
		private static void OnAllowTabClosingChanged(global::System.Windows.DependencyObject target, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.Controls.XamTabControl xamTabControl = target as global::Infragistics.Windows.Controls.XamTabControl;
			if (xamTabControl != null)
			{
				xamTabControl.BumpInternalVersion();
			}
		}

		// Token: 0x1700062C RID: 1580
		// (get) Token: 0x06001A5B RID: 6747 RVA: 0x00066BC5 File Offset: 0x00064DC5
		// (set) Token: 0x06001A5C RID: 6748 RVA: 0x00066BD7 File Offset: 0x00064DD7
		public bool? AllowTabClosing
		{
			get
			{
				return (bool?)base.GetValue(global::Infragistics.Windows.Controls.XamTabControl.AllowTabClosingProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.Controls.XamTabControl.AllowTabClosingProperty, value);
			}
		}

		// Token: 0x1700062D RID: 1581
		// (get) Token: 0x06001A5D RID: 6749 RVA: 0x00066BEA File Offset: 0x00064DEA
		// (set) Token: 0x06001A5E RID: 6750 RVA: 0x00066BFC File Offset: 0x00064DFC
		public global::System.Windows.Controls.Primitives.PopupAnimation DropDownAnimation
		{
			get
			{
				return (global::System.Windows.Controls.Primitives.PopupAnimation)base.GetValue(global::Infragistics.Windows.Controls.XamTabControl.DropDownAnimationProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.Controls.XamTabControl.DropDownAnimationProperty, value);
			}
		}

		// Token: 0x1700062E RID: 1582
		// (get) Token: 0x06001A5F RID: 6751 RVA: 0x00066C0F File Offset: 0x00064E0F
		// (set) Token: 0x06001A60 RID: 6752 RVA: 0x00066C22 File Offset: 0x00064E22
		[global::System.ComponentModel.Bindable(true)]
		public double InterRowSpacing
		{
			get
			{
				return (double)((int)base.GetValue(global::Infragistics.Windows.Controls.XamTabControl.InterRowSpacingProperty));
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.Controls.XamTabControl.InterRowSpacingProperty, value);
			}
		}

		// Token: 0x1700062F RID: 1583
		// (get) Token: 0x06001A61 RID: 6753 RVA: 0x00066C35 File Offset: 0x00064E35
		// (set) Token: 0x06001A62 RID: 6754 RVA: 0x00066C48 File Offset: 0x00064E48
		[global::System.ComponentModel.Bindable(true)]
		public double InterTabSpacing
		{
			get
			{
				return (double)((int)base.GetValue(global::Infragistics.Windows.Controls.XamTabControl.InterTabSpacingProperty));
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.Controls.XamTabControl.InterTabSpacingProperty, value);
			}
		}

		// Token: 0x06001A63 RID: 6755 RVA: 0x00066C5C File Offset: 0x00064E5C
		private static void OnIsDropDownOpenChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.Controls.XamTabControl xamTabControl = d as global::Infragistics.Windows.Controls.XamTabControl;
			if (xamTabControl != null)
			{
				bool flag = (bool)e.NewValue;
				if (flag)
				{
					if (!xamTabControl.IsMinimized)
					{
						xamTabControl.IsMinimized = true;
					}
					else
					{
						xamTabControl.ResetSelectedItem();
					}
				}
				else if (xamTabControl.IsMinimized)
				{
					xamTabControl.ResetSelectedItem();
				}
				xamTabControl.VerifySelectedContent();
				if (flag)
				{
					xamTabControl.InitializeDropdownLocationInfo();
				}
				xamTabControl.RefreshSelectedTabPeerChildren();
				if (flag)
				{
					xamTabControl.RaiseDropDownOpened(new global::System.Windows.RoutedEventArgs());
					return;
				}
				xamTabControl.RaiseDropDownClosed(new global::System.Windows.RoutedEventArgs());
			}
		}

		// Token: 0x06001A64 RID: 6756 RVA: 0x00066CDC File Offset: 0x00064EDC
		private static object CoerceIsDropDownOpen(global::System.Windows.DependencyObject d, object value)
		{
			global::Infragistics.Windows.Controls.XamTabControl xamTabControl = d as global::Infragistics.Windows.Controls.XamTabControl;
			if (xamTabControl != null && global::Infragistics.KnownBoxes.TrueBox.Equals(value) && !xamTabControl.IsMinimized)
			{
				return global::Infragistics.KnownBoxes.FalseBox;
			}
			if ((bool)value)
			{
				global::Infragistics.Windows.Controls.Events.TabControlDropDownOpeningEventArgs args = new global::Infragistics.Windows.Controls.Events.TabControlDropDownOpeningEventArgs();
				xamTabControl.RaiseDropDownOpening(args);
			}
			return value;
		}

		// Token: 0x17000630 RID: 1584
		// (get) Token: 0x06001A65 RID: 6757 RVA: 0x00066D24 File Offset: 0x00064F24
		// (set) Token: 0x06001A66 RID: 6758 RVA: 0x00066D36 File Offset: 0x00064F36
		[global::System.ComponentModel.Bindable(true)]
		public bool IsDropDownOpen
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.Windows.Controls.XamTabControl.IsDropDownOpenProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.Controls.XamTabControl.IsDropDownOpenProperty, value);
			}
		}

		// Token: 0x17000631 RID: 1585
		// (get) Token: 0x06001A67 RID: 6759 RVA: 0x00066D49 File Offset: 0x00064F49
		// (set) Token: 0x06001A68 RID: 6760 RVA: 0x00066D5B File Offset: 0x00064F5B
		[global::System.ComponentModel.Bindable(true)]
		public bool IsMinimized
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.Windows.Controls.XamTabControl.IsMinimizedProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.Controls.XamTabControl.IsMinimizedProperty, value);
			}
		}

		// Token: 0x06001A69 RID: 6761 RVA: 0x00066D70 File Offset: 0x00064F70
		private static void OnIsMinimizedChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.Controls.XamTabControl xamTabControl = d as global::Infragistics.Windows.Controls.XamTabControl;
			if (xamTabControl != null)
			{
				if (!(bool)e.NewValue && xamTabControl.IsDropDownOpen)
				{
					xamTabControl.IsDropDownOpen = false;
				}
				xamTabControl.VerifyMinimizedContentBinding();
				xamTabControl.ResetSelectedItem();
				xamTabControl.RaiseAutomationExpandCollapseStateChanged();
			}
		}

		// Token: 0x17000632 RID: 1586
		// (get) Token: 0x06001A6A RID: 6762 RVA: 0x00066DB8 File Offset: 0x00064FB8
		[global::System.ComponentModel.ReadOnly(true)]
		[global::System.ComponentModel.Bindable(true)]
		public bool IsTabItemPanelScrolling
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.Windows.Controls.XamTabControl.IsTabItemPanelScrollingProperty);
			}
		}

		// Token: 0x06001A6B RID: 6763 RVA: 0x00066DCA File Offset: 0x00064FCA
		private static bool OnValidateAtLeastZero(object newValue)
		{
			return newValue is double && (double)newValue >= 0.0;
		}

		// Token: 0x17000633 RID: 1587
		// (get) Token: 0x06001A6C RID: 6764 RVA: 0x00066DEA File Offset: 0x00064FEA
		// (set) Token: 0x06001A6D RID: 6765 RVA: 0x00066DFC File Offset: 0x00064FFC
		[global::System.ComponentModel.Bindable(true)]
		public double MaximumSizeToFitAdjustment
		{
			get
			{
				return (double)base.GetValue(global::Infragistics.Windows.Controls.XamTabControl.MaximumSizeToFitAdjustmentProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.Controls.XamTabControl.MaximumSizeToFitAdjustmentProperty, value);
			}
		}

		// Token: 0x06001A6E RID: 6766 RVA: 0x00066E0F File Offset: 0x0006500F
		private static bool ValidateMaximumTabRows(object value)
		{
			return value is int && (int)value >= 1;
		}

		// Token: 0x17000634 RID: 1588
		// (get) Token: 0x06001A6F RID: 6767 RVA: 0x00066E25 File Offset: 0x00065025
		// (set) Token: 0x06001A70 RID: 6768 RVA: 0x00066E37 File Offset: 0x00065037
		[global::System.ComponentModel.Bindable(true)]
		public int MaximumTabRows
		{
			get
			{
				return (int)base.GetValue(global::Infragistics.Windows.Controls.XamTabControl.MaximumTabRowsProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.Controls.XamTabControl.MaximumTabRowsProperty, value);
			}
		}

		// Token: 0x17000635 RID: 1589
		// (get) Token: 0x06001A71 RID: 6769 RVA: 0x00066E4A File Offset: 0x0006504A
		// (set) Token: 0x06001A72 RID: 6770 RVA: 0x00066E5C File Offset: 0x0006505C
		[global::System.ComponentModel.Bindable(true)]
		public double MinimumTabExtent
		{
			get
			{
				return (double)base.GetValue(global::Infragistics.Windows.Controls.XamTabControl.MinimumTabExtentProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.Controls.XamTabControl.MinimumTabExtentProperty, value);
			}
		}

		// Token: 0x17000636 RID: 1590
		// (get) Token: 0x06001A73 RID: 6771 RVA: 0x00066E6F File Offset: 0x0006506F
		// (set) Token: 0x06001A74 RID: 6772 RVA: 0x00066E7C File Offset: 0x0006507C
		[global::System.ComponentModel.Bindable(true)]
		public object PostTabItemContent
		{
			get
			{
				return base.GetValue(global::Infragistics.Windows.Controls.XamTabControl.PostTabItemContentProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.Controls.XamTabControl.PostTabItemContentProperty, value);
			}
		}

		// Token: 0x17000637 RID: 1591
		// (get) Token: 0x06001A75 RID: 6773 RVA: 0x00066E8A File Offset: 0x0006508A
		// (set) Token: 0x06001A76 RID: 6774 RVA: 0x00066E9C File Offset: 0x0006509C
		[global::System.ComponentModel.Bindable(true)]
		public global::System.Windows.DataTemplate PostTabItemContentTemplate
		{
			get
			{
				return (global::System.Windows.DataTemplate)base.GetValue(global::Infragistics.Windows.Controls.XamTabControl.PostTabItemContentTemplateProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.Controls.XamTabControl.PostTabItemContentTemplateProperty, value);
			}
		}

		// Token: 0x17000638 RID: 1592
		// (get) Token: 0x06001A77 RID: 6775 RVA: 0x00066EAA File Offset: 0x000650AA
		// (set) Token: 0x06001A78 RID: 6776 RVA: 0x00066EBC File Offset: 0x000650BC
		[global::System.ComponentModel.Bindable(true)]
		public global::System.Windows.Controls.DataTemplateSelector PostTabItemContentTemplateSelector
		{
			get
			{
				return (global::System.Windows.Controls.DataTemplateSelector)base.GetValue(global::Infragistics.Windows.Controls.XamTabControl.PostTabItemContentTemplateSelectorProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.Controls.XamTabControl.PostTabItemContentTemplateSelectorProperty, value);
			}
		}

		// Token: 0x17000639 RID: 1593
		// (get) Token: 0x06001A79 RID: 6777 RVA: 0x00066ECA File Offset: 0x000650CA
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.Browsable(false)]
		public double PreferredDropDownExtent
		{
			get
			{
				return (double)base.GetValue(global::Infragistics.Windows.Controls.XamTabControl.PreferredDropDownExtentProperty);
			}
		}

		// Token: 0x1700063A RID: 1594
		// (get) Token: 0x06001A7A RID: 6778 RVA: 0x00066EDC File Offset: 0x000650DC
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.Browsable(false)]
		public global::System.Windows.Controls.Primitives.CustomPopupPlacementCallback PreferredDropDownPlacementCallback
		{
			get
			{
				return (global::System.Windows.Controls.Primitives.CustomPopupPlacementCallback)base.GetValue(global::Infragistics.Windows.Controls.XamTabControl.PreferredDropDownPlacementCallbackProperty);
			}
		}

		// Token: 0x1700063B RID: 1595
		// (get) Token: 0x06001A7B RID: 6779 RVA: 0x00066EEE File Offset: 0x000650EE
		// (set) Token: 0x06001A7C RID: 6780 RVA: 0x00066EFB File Offset: 0x000650FB
		[global::System.ComponentModel.Bindable(true)]
		public object PreTabItemContent
		{
			get
			{
				return base.GetValue(global::Infragistics.Windows.Controls.XamTabControl.PreTabItemContentProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.Controls.XamTabControl.PreTabItemContentProperty, value);
			}
		}

		// Token: 0x1700063C RID: 1596
		// (get) Token: 0x06001A7D RID: 6781 RVA: 0x00066F09 File Offset: 0x00065109
		// (set) Token: 0x06001A7E RID: 6782 RVA: 0x00066F1B File Offset: 0x0006511B
		[global::System.ComponentModel.Bindable(true)]
		public global::System.Windows.DataTemplate PreTabItemContentTemplate
		{
			get
			{
				return (global::System.Windows.DataTemplate)base.GetValue(global::Infragistics.Windows.Controls.XamTabControl.PreTabItemContentTemplateProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.Controls.XamTabControl.PreTabItemContentTemplateProperty, value);
			}
		}

		// Token: 0x1700063D RID: 1597
		// (get) Token: 0x06001A7F RID: 6783 RVA: 0x00066F29 File Offset: 0x00065129
		// (set) Token: 0x06001A80 RID: 6784 RVA: 0x00066F3B File Offset: 0x0006513B
		[global::System.ComponentModel.Bindable(true)]
		public global::System.Windows.Controls.DataTemplateSelector PreTabItemContentTemplateSelector
		{
			get
			{
				return (global::System.Windows.Controls.DataTemplateSelector)base.GetValue(global::Infragistics.Windows.Controls.XamTabControl.PreTabItemContentTemplateSelectorProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.Controls.XamTabControl.PreTabItemContentTemplateSelectorProperty, value);
			}
		}

		// Token: 0x06001A81 RID: 6785 RVA: 0x00066F4C File Offset: 0x0006514C
		private static void OnShowTabHeaderCloseButtonChanged(global::System.Windows.DependencyObject target, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.Controls.XamTabControl xamTabControl = target as global::Infragistics.Windows.Controls.XamTabControl;
			if (xamTabControl != null)
			{
				xamTabControl.BumpInternalVersion();
				global::System.Windows.Input.CommandManager.InvalidateRequerySuggested();
			}
		}

		// Token: 0x1700063E RID: 1598
		// (get) Token: 0x06001A82 RID: 6786 RVA: 0x00066F6E File Offset: 0x0006516E
		// (set) Token: 0x06001A83 RID: 6787 RVA: 0x00066F80 File Offset: 0x00065180
		public bool ShowTabHeaderCloseButton
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.Windows.Controls.XamTabControl.ShowTabHeaderCloseButtonProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.Controls.XamTabControl.ShowTabHeaderCloseButtonProperty, value);
			}
		}

		// Token: 0x1700063F RID: 1599
		// (get) Token: 0x06001A84 RID: 6788 RVA: 0x00066F93 File Offset: 0x00065193
		// (set) Token: 0x06001A85 RID: 6789 RVA: 0x00066FA5 File Offset: 0x000651A5
		public double TabHeaderHeight
		{
			get
			{
				return (double)base.GetValue(global::Infragistics.Windows.Controls.XamTabControl.TabHeaderHeightProperty);
			}
			private set
			{
				base.SetValue(global::Infragistics.Windows.Controls.XamTabControl.TabHeaderHeightProperty, value);
			}
		}

		// Token: 0x06001A86 RID: 6790 RVA: 0x00066FB8 File Offset: 0x000651B8
		private static void OnTabItemCloseButtonVisibilityChanged(global::System.Windows.DependencyObject target, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.Controls.XamTabControl xamTabControl = target as global::Infragistics.Windows.Controls.XamTabControl;
			if (xamTabControl != null)
			{
				xamTabControl.BumpInternalVersion();
			}
		}

		// Token: 0x17000640 RID: 1600
		// (get) Token: 0x06001A87 RID: 6791 RVA: 0x00066FD5 File Offset: 0x000651D5
		// (set) Token: 0x06001A88 RID: 6792 RVA: 0x00066FE7 File Offset: 0x000651E7
		public global::Infragistics.Windows.Controls.TabItemCloseButtonVisibility TabItemCloseButtonVisibility
		{
			get
			{
				return (global::Infragistics.Windows.Controls.TabItemCloseButtonVisibility)base.GetValue(global::Infragistics.Windows.Controls.XamTabControl.TabItemCloseButtonVisibilityProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.Controls.XamTabControl.TabItemCloseButtonVisibilityProperty, value);
			}
		}

		// Token: 0x17000641 RID: 1601
		// (get) Token: 0x06001A89 RID: 6793 RVA: 0x00066FFA File Offset: 0x000651FA
		// (set) Token: 0x06001A8A RID: 6794 RVA: 0x0006700C File Offset: 0x0006520C
		[global::System.ComponentModel.Bindable(true)]
		public double TabItemContentHeight
		{
			get
			{
				return (double)base.GetValue(global::Infragistics.Windows.Controls.XamTabControl.TabItemContentHeightProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.Controls.XamTabControl.TabItemContentHeightProperty, value);
			}
		}

		// Token: 0x17000642 RID: 1602
		// (get) Token: 0x06001A8B RID: 6795 RVA: 0x0006701F File Offset: 0x0006521F
		[global::System.ComponentModel.ReadOnly(true)]
		public global::System.Windows.Controls.ScrollBarVisibility TabItemHorizontalScrollBarVisibility
		{
			get
			{
				return (global::System.Windows.Controls.ScrollBarVisibility)base.GetValue(global::Infragistics.Windows.Controls.XamTabControl.TabItemHorizontalScrollBarVisibilityProperty);
			}
		}

		// Token: 0x17000643 RID: 1603
		// (get) Token: 0x06001A8C RID: 6796 RVA: 0x00067031 File Offset: 0x00065231
		[global::System.ComponentModel.ReadOnly(true)]
		public global::System.Windows.Controls.ScrollBarVisibility TabItemVerticalScrollBarVisibility
		{
			get
			{
				return (global::System.Windows.Controls.ScrollBarVisibility)base.GetValue(global::Infragistics.Windows.Controls.XamTabControl.TabItemVerticalScrollBarVisibilityProperty);
			}
		}

		// Token: 0x06001A8D RID: 6797 RVA: 0x00067044 File Offset: 0x00065244
		private static void OnTabLayoutStyleChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.Controls.XamTabControl xamTabControl = d as global::Infragistics.Windows.Controls.XamTabControl;
			if (xamTabControl != null)
			{
				xamTabControl.SetValue(global::Infragistics.Windows.Controls.XamTabControl.IsMultiRowPropertyKey, global::Infragistics.Windows.Controls.TabItemPanel.IsMultiRowStyle(xamTabControl.TabLayoutStyle));
			}
		}

		// Token: 0x17000644 RID: 1604
		// (get) Token: 0x06001A8E RID: 6798 RVA: 0x00067076 File Offset: 0x00065276
		// (set) Token: 0x06001A8F RID: 6799 RVA: 0x00067088 File Offset: 0x00065288
		[global::System.ComponentModel.Bindable(true)]
		public global::Infragistics.Windows.Controls.TabLayoutStyle TabLayoutStyle
		{
			get
			{
				return (global::Infragistics.Windows.Controls.TabLayoutStyle)base.GetValue(global::Infragistics.Windows.Controls.XamTabControl.TabLayoutStyleProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.Controls.XamTabControl.TabLayoutStyleProperty, value);
			}
		}

		// Token: 0x06001A90 RID: 6800 RVA: 0x0006709B File Offset: 0x0006529B
		[global::System.Windows.AttachedPropertyBrowsableForChildren]
		public static int GetTabPriority(global::System.Windows.DependencyObject d)
		{
			return (int)d.GetValue(global::Infragistics.Windows.Controls.XamTabControl.TabPriorityProperty);
		}

		// Token: 0x06001A91 RID: 6801 RVA: 0x000670AD File Offset: 0x000652AD
		public static void SetTabPriority(global::System.Windows.DependencyObject d, int value)
		{
			d.SetValue(global::Infragistics.Windows.Controls.XamTabControl.TabPriorityProperty, value);
		}

		// Token: 0x06001A92 RID: 6802 RVA: 0x000670C0 File Offset: 0x000652C0
		private static void OnThemeChanged(global::System.Windows.DependencyObject target, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.Controls.XamTabControl xamTabControl = target as global::Infragistics.Windows.Controls.XamTabControl;
			xamTabControl.UpdateThemeResources();
			xamTabControl.OnThemeChanged((string)e.OldValue, (string)e.NewValue);
		}

		// Token: 0x17000645 RID: 1605
		// (get) Token: 0x06001A93 RID: 6803 RVA: 0x000670F8 File Offset: 0x000652F8
		// (set) Token: 0x06001A94 RID: 6804 RVA: 0x0006710A File Offset: 0x0006530A
		[global::System.ComponentModel.TypeConverter(typeof(global::Infragistics.Windows.Themes.Internal.PrimitivesThemeTypeConverter))]
		[global::System.ComponentModel.DefaultValue(null)]
		[global::System.ComponentModel.Bindable(true)]
		public string Theme
		{
			get
			{
				return (string)base.GetValue(global::Infragistics.Windows.Controls.XamTabControl.ThemeProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.Controls.XamTabControl.ThemeProperty, value);
			}
		}

		// Token: 0x06001A95 RID: 6805 RVA: 0x00067118 File Offset: 0x00065318
		protected virtual void OnThemeChanged(string previousValue, string currentValue)
		{
			base.RaiseEvent(new global::System.Windows.RoutedPropertyChangedEventArgs<string>(previousValue, currentValue)
			{
				RoutedEvent = global::Infragistics.Windows.Controls.XamTabControl.ThemeChangedEvent,
				Source = this
			});
		}

		// Token: 0x1400003D RID: 61
		// (add) Token: 0x06001A96 RID: 6806 RVA: 0x00067146 File Offset: 0x00065346
		// (remove) Token: 0x06001A97 RID: 6807 RVA: 0x00067154 File Offset: 0x00065354
		public event global::System.Windows.RoutedPropertyChangedEventHandler<string> ThemeChanged
		{
			add
			{
				base.AddHandler(global::Infragistics.Windows.Controls.XamTabControl.ThemeChangedEvent, value);
			}
			remove
			{
				base.RemoveHandler(global::Infragistics.Windows.Controls.XamTabControl.ThemeChangedEvent, value);
			}
		}

		// Token: 0x06001A98 RID: 6808 RVA: 0x00067162 File Offset: 0x00065362
		public bool ExecuteCommand(global::System.Windows.Input.RoutedCommand command)
		{
			return this.ExecuteCommandImpl(new global::Infragistics.Windows.Commands.ExecuteCommandInfo(command));
		}

		// Token: 0x06001A99 RID: 6809 RVA: 0x00067170 File Offset: 0x00065370
		private void BumpInternalVersion()
		{
			base.SetValue(global::Infragistics.Windows.Controls.XamTabControl.InternalVersionPropertyKey, this.InternalVersion + 1);
		}

		// Token: 0x06001A9A RID: 6810 RVA: 0x0006718A File Offset: 0x0006538A
		internal bool CloseTab(global::Infragistics.Windows.Controls.TabItemEx tab)
		{
			if (!tab.Close())
			{
				return false;
			}
			this.EnsureSelectedTabIsVisible();
			return true;
		}

		// Token: 0x06001A9B RID: 6811 RVA: 0x000671A0 File Offset: 0x000653A0
		internal bool CloseAllTabs(global::System.Windows.Controls.TabItem excludeTab)
		{
			if (base.HasItems)
			{
				int i = 0;
				int count = base.Items.Count;
				while (i < count)
				{
					global::Infragistics.Windows.Controls.TabItemEx tabItemEx = this.GetTabItemAtIndex(i, false, true) as global::Infragistics.Windows.Controls.TabItemEx;
					if (tabItemEx != null && tabItemEx != excludeTab)
					{
						tabItemEx.Close();
					}
					i++;
				}
			}
			this.EnsureSelectedTabIsVisible();
			return true;
		}

		// Token: 0x06001A9C RID: 6812 RVA: 0x000671F4 File Offset: 0x000653F4
		private void EnsureSelectedTabIsVisible()
		{
			global::System.Windows.Controls.TabItem selectedTabItem = this.GetSelectedTabItem();
			if (selectedTabItem == null || selectedTabItem.Visibility == global::System.Windows.Visibility.Visible)
			{
				return;
			}
			global::System.Windows.Controls.TabItem tabItem = this.GetNextTabItem(selectedTabItem, true, true);
			if (tabItem == null)
			{
				tabItem = this.GetPreviousTabItem(selectedTabItem, true, true);
			}
			if (tabItem == null)
			{
				tabItem = this.GetNextTabItem(selectedTabItem, false, true);
			}
			if (tabItem == null)
			{
				tabItem = this.GetPreviousTabItem(selectedTabItem, false, true);
			}
			if (tabItem == null)
			{
				base.SelectedIndex = -1;
				return;
			}
			base.SelectedIndex = base.ItemContainerGenerator.IndexFromContainer(tabItem);
		}

		// Token: 0x06001A9D RID: 6813 RVA: 0x00067264 File Offset: 0x00065464
		private bool ExecuteCommandImpl(global::Infragistics.Windows.Commands.ExecuteCommandInfo commandInfo)
		{
			global::System.Windows.Input.RoutedCommand routedCommand = commandInfo.RoutedCommand;
			global::Infragistics.Windows.Utilities.ThrowIfNull(routedCommand, "command");
			if (!global::Infragistics.Windows.Commands.Commands<global::Infragistics.Windows.Controls.XamTabControl>.IsMinimumStatePresentForCommand(this, routedCommand))
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
			if (routedCommand == global::Infragistics.Windows.Controls.TabItemExCommands.Close || routedCommand == global::Infragistics.Windows.Controls.TabControlCommands.CloseSelected)
			{
				global::Infragistics.Windows.Controls.TabItemEx tabItemEx = this.GetSelectedTabItem() as global::Infragistics.Windows.Controls.TabItemEx;
				if (tabItemEx != null)
				{
					flag = this.CloseTab(tabItemEx);
				}
			}
			else if (routedCommand == global::Infragistics.Windows.Controls.TabItemExCommands.CloseAllButThis)
			{
				global::System.Windows.Controls.TabItem selectedTabItem = this.GetSelectedTabItem();
				if (selectedTabItem != null)
				{
					flag = this.CloseAllTabs(selectedTabItem);
				}
			}
			else if (routedCommand == global::Infragistics.Windows.Controls.TabControlCommands.CloseAll)
			{
				flag = this.CloseAllTabs(null);
			}
			else if (routedCommand == global::Infragistics.Windows.Controls.TabControlCommands.SelectFirstTab)
			{
				global::System.Windows.Controls.TabItem firstTabItemToSelect = this.GetFirstTabItemToSelect();
				if (firstTabItemToSelect != null)
				{
					global::Infragistics.DependencyPropertyUtilities.SetCurrentValue(firstTabItemToSelect, global::System.Windows.Controls.TabItem.IsSelectedProperty, global::Infragistics.KnownBoxes.TrueBox);
					firstTabItemToSelect.BringIntoView();
				}
				flag = (firstTabItemToSelect != null && firstTabItemToSelect.IsSelected);
			}
			else if (routedCommand == global::Infragistics.Windows.Controls.TabControlCommands.SelectLastTab)
			{
				global::System.Windows.Controls.TabItem lastTabItem = this.GetLastTabItem(true, true);
				if (lastTabItem == null)
				{
					lastTabItem = this.GetLastTabItem(false, true);
				}
				if (lastTabItem != null)
				{
					global::Infragistics.DependencyPropertyUtilities.SetCurrentValue(lastTabItem, global::System.Windows.Controls.TabItem.IsSelectedProperty, global::Infragistics.KnownBoxes.TrueBox);
					lastTabItem.BringIntoView();
				}
				flag = (lastTabItem != null && lastTabItem.IsSelected);
			}
			if (routedCommand == global::Infragistics.Windows.Controls.TabControlCommands.SelectNextTab)
			{
				global::System.Windows.Controls.TabItem selectedTabItem2 = this.GetSelectedTabItem();
				if (selectedTabItem2 != null)
				{
					global::System.Windows.Controls.TabItem nextTabItem = this.GetNextTabItem(selectedTabItem2, true, true);
					if (nextTabItem == null)
					{
						nextTabItem = this.GetNextTabItem(selectedTabItem2, false, true);
					}
					if (nextTabItem != null)
					{
						global::Infragistics.DependencyPropertyUtilities.SetCurrentValue(nextTabItem, global::System.Windows.Controls.TabItem.IsSelectedProperty, global::Infragistics.KnownBoxes.TrueBox);
						nextTabItem.BringIntoView();
					}
					flag = (nextTabItem != null && nextTabItem.IsSelected);
				}
			}
			else if (routedCommand == global::Infragistics.Windows.Controls.TabControlCommands.SelectPreviousTab)
			{
				global::System.Windows.Controls.TabItem selectedTabItem3 = this.GetSelectedTabItem();
				if (selectedTabItem3 != null)
				{
					global::System.Windows.Controls.TabItem previousTabItem = this.GetPreviousTabItem(selectedTabItem3, true, true);
					if (previousTabItem == null)
					{
						previousTabItem = this.GetPreviousTabItem(selectedTabItem3, false, true);
					}
					if (previousTabItem != null)
					{
						global::Infragistics.DependencyPropertyUtilities.SetCurrentValue(previousTabItem, global::System.Windows.Controls.TabItem.IsSelectedProperty, global::Infragistics.KnownBoxes.TrueBox);
						previousTabItem.BringIntoView();
					}
					flag = (previousTabItem != null && previousTabItem.IsSelected);
				}
			}
			else if (routedCommand == global::Infragistics.Windows.Controls.TabControlCommands.Expand)
			{
				this.IsMinimized = false;
				flag = !this.IsMinimized;
			}
			else if (routedCommand == global::Infragistics.Windows.Controls.TabControlCommands.Minimize)
			{
				if (this.AllowMinimize)
				{
					this.IsMinimized = true;
					flag = this.IsMinimized;
				}
			}
			else if (routedCommand == global::Infragistics.Windows.Controls.TabControlCommands.ToggleMinimized)
			{
				if (this.IsMinimized)
				{
					this.IsMinimized = false;
					flag = !this.IsMinimized;
				}
				else
				{
					if (!this.AllowMinimize)
					{
						return false;
					}
					this.IsMinimized = true;
					flag = this.IsMinimized;
				}
			}
			if (flag)
			{
				this.RaiseExecutedCommand(new global::Infragistics.Windows.Controls.Events.ExecutedCommandEventArgs(routedCommand));
			}
			return flag;
		}

		// Token: 0x06001A9E RID: 6814 RVA: 0x000674F4 File Offset: 0x000656F4
		private global::System.Windows.Controls.TabItem GetFirstTabItem(bool excludeDisabled, bool excludeCollapsed)
		{
			if (base.HasItems)
			{
				int i = 0;
				int count = base.Items.Count;
				while (i < count)
				{
					global::System.Windows.Controls.TabItem tabItemAtIndex = this.GetTabItemAtIndex(i, excludeDisabled, excludeCollapsed);
					if (tabItemAtIndex != null)
					{
						return tabItemAtIndex;
					}
					i++;
				}
			}
			return null;
		}

		// Token: 0x06001A9F RID: 6815 RVA: 0x00067534 File Offset: 0x00065734
		private global::System.Windows.Controls.TabItem GetFirstTabItemToSelect()
		{
			global::System.Windows.Controls.TabItem firstTabItem = this.GetFirstTabItem(true, true);
			if (firstTabItem != null)
			{
				return firstTabItem;
			}
			return this.GetFirstTabItem(false, true);
		}

		// Token: 0x06001AA0 RID: 6816 RVA: 0x00067558 File Offset: 0x00065758
		private global::System.Windows.Controls.TabItem GetLastTabItem(bool excludeDisabled, bool excludeCollapsed)
		{
			if (base.HasItems)
			{
				for (int i = base.Items.Count - 1; i >= 0; i--)
				{
					global::System.Windows.Controls.TabItem tabItemAtIndex = this.GetTabItemAtIndex(i, excludeDisabled, excludeCollapsed);
					if (tabItemAtIndex != null)
					{
						return tabItemAtIndex;
					}
				}
			}
			return null;
		}

		// Token: 0x06001AA1 RID: 6817 RVA: 0x00067598 File Offset: 0x00065798
		private global::System.Windows.Controls.TabItem GetNextTabItem(global::System.Windows.Controls.TabItem startTab, bool excludeDisabled, bool excludeCollapsed)
		{
			if (base.HasItems)
			{
				int num = base.ItemContainerGenerator.IndexFromContainer(startTab);
				int i = num + 1;
				int count = base.Items.Count;
				while (i < count)
				{
					global::System.Windows.Controls.TabItem tabItemAtIndex = this.GetTabItemAtIndex(i, excludeDisabled, excludeCollapsed);
					if (tabItemAtIndex != null)
					{
						return tabItemAtIndex;
					}
					i++;
				}
			}
			return null;
		}

		// Token: 0x06001AA2 RID: 6818 RVA: 0x000675E4 File Offset: 0x000657E4
		private global::System.Windows.Controls.TabItem GetPreviousTabItem(global::System.Windows.Controls.TabItem startTab, bool excludeDisabled, bool excludeCollapsed)
		{
			if (base.HasItems)
			{
				int num = base.ItemContainerGenerator.IndexFromContainer(startTab);
				if (num < 0)
				{
					num = base.Items.Count;
				}
				for (int i = num - 1; i >= 0; i--)
				{
					global::System.Windows.Controls.TabItem tabItemAtIndex = this.GetTabItemAtIndex(i, excludeDisabled, excludeCollapsed);
					if (tabItemAtIndex != null)
					{
						return tabItemAtIndex;
					}
				}
			}
			return null;
		}

		// Token: 0x06001AA3 RID: 6819 RVA: 0x00067634 File Offset: 0x00065834
		private object GetFirstVisibleTabItem()
		{
			for (int i = 0; i < base.Items.Count; i++)
			{
				global::System.Windows.FrameworkElement frameworkElement = base.ItemContainerGenerator.ContainerFromIndex(i) as global::System.Windows.FrameworkElement;
				if (frameworkElement != null && frameworkElement.Visibility == global::System.Windows.Visibility.Visible && frameworkElement.IsEnabled)
				{
					return frameworkElement;
				}
			}
			return null;
		}

		// Token: 0x06001AA4 RID: 6820 RVA: 0x00067680 File Offset: 0x00065880
		private global::System.Windows.Controls.Primitives.CustomPopupPlacement[] GetPreferredPopupPlacement(global::System.Windows.Size popupSize, global::System.Windows.Size targetSize, global::System.Windows.Point offset)
		{
			global::System.Windows.Controls.Primitives.CustomPopupPlacement[] array = new global::System.Windows.Controls.Primitives.CustomPopupPlacement[2];
			double x = (base.FlowDirection == global::System.Windows.FlowDirection.LeftToRight) ? 0.0 : (-popupSize.Width);
			global::System.Windows.Point point;
			global::System.Windows.Point point2;
			global::System.Windows.Controls.Primitives.PopupPrimaryAxis primaryAxis;
			switch (base.TabStripPlacement)
			{
			case global::System.Windows.Controls.Dock.Left:
				point = new global::System.Windows.Point(targetSize.Width, 0.0);
				point2 = new global::System.Windows.Point(-popupSize.Width, 0.0);
				primaryAxis = global::System.Windows.Controls.Primitives.PopupPrimaryAxis.Horizontal;
				goto IL_F3;
			case global::System.Windows.Controls.Dock.Right:
				point2 = new global::System.Windows.Point(targetSize.Width, 0.0);
				point = new global::System.Windows.Point(-popupSize.Width, 0.0);
				primaryAxis = global::System.Windows.Controls.Primitives.PopupPrimaryAxis.Horizontal;
				goto IL_F3;
			case global::System.Windows.Controls.Dock.Bottom:
				point2 = new global::System.Windows.Point(x, targetSize.Height);
				point = new global::System.Windows.Point(x, -popupSize.Height);
				primaryAxis = global::System.Windows.Controls.Primitives.PopupPrimaryAxis.Vertical;
				goto IL_F3;
			}
			point = new global::System.Windows.Point(x, targetSize.Height);
			point2 = new global::System.Windows.Point(x, -popupSize.Height);
			primaryAxis = global::System.Windows.Controls.Primitives.PopupPrimaryAxis.Vertical;
			IL_F3:
			array[0] = new global::System.Windows.Controls.Primitives.CustomPopupPlacement(point, primaryAxis);
			array[1] = new global::System.Windows.Controls.Primitives.CustomPopupPlacement(point2, primaryAxis);
			return array;
		}

		// Token: 0x06001AA5 RID: 6821 RVA: 0x000677A8 File Offset: 0x000659A8
		private global::System.Windows.Controls.TabItem GetSelectedTabItem()
		{
			int selectedIndex = base.SelectedIndex;
			if (selectedIndex >= 0)
			{
				return base.ItemContainerGenerator.ContainerFromIndex(selectedIndex) as global::System.Windows.Controls.TabItem;
			}
			return null;
		}

		// Token: 0x06001AA6 RID: 6822 RVA: 0x000677D4 File Offset: 0x000659D4
		private global::System.Windows.Controls.TabItem GetTabItemAtIndex(int index, bool nullIfDisabled, bool nullIfCollapsed)
		{
			global::System.Windows.Controls.TabItem tabItem = base.ItemContainerGenerator.ContainerFromIndex(index) as global::System.Windows.Controls.TabItem;
			if (tabItem != null && (!nullIfCollapsed || tabItem.Visibility != global::System.Windows.Visibility.Collapsed) && (!nullIfDisabled || tabItem.IsEnabled))
			{
				return tabItem;
			}
			return null;
		}

		// Token: 0x06001AA7 RID: 6823 RVA: 0x00067810 File Offset: 0x00065A10
		private void InitializeDropdownLocationInfo()
		{
			object selectedItem = base.SelectedItem;
			global::System.Windows.Controls.TabItem tabItem = (selectedItem == null) ? null : (base.ItemContainerGenerator.ContainerFromItem(selectedItem) as global::System.Windows.Controls.TabItem);
			global::System.Windows.FrameworkElement frameworkElement = (base.GetTemplateChild("PART_HeaderArea") as global::System.Windows.FrameworkElement) ?? this;
			bool flag = global::System.Windows.Input.Mouse.LeftButton == global::System.Windows.Input.MouseButtonState.Pressed && base.IsMouseOver;
			if (flag && tabItem is global::Infragistics.Windows.Controls.TabItemEx)
			{
				global::System.Windows.Media.HitTestResult hitTestResult = global::System.Windows.Media.VisualTreeHelper.HitTest(tabItem, global::System.Windows.Input.Mouse.GetPosition(tabItem));
				if (hitTestResult == null || hitTestResult.VisualHit == null)
				{
					flag = false;
				}
			}
			else
			{
				flag = false;
			}
			global::System.Windows.Size size = new global::System.Windows.Size(frameworkElement.ActualWidth, frameworkElement.ActualHeight);
			global::System.Windows.Point point = global::Infragistics.Windows.Utilities.PointToScreenSafe(frameworkElement, default(global::System.Windows.Point));
			global::System.Windows.Point point2 = global::Infragistics.Windows.Utilities.PointToScreenSafe(frameworkElement, new global::System.Windows.Point(size.Width, size.Height));
			global::System.Windows.Rect rect = global::Infragistics.Windows.Utilities.RectFromPoints(point, point2);
			global::System.Windows.Point point3;
			if (flag)
			{
				point3 = global::System.Windows.Input.Mouse.GetPosition(frameworkElement);
			}
			else
			{
				global::System.Windows.Rect workArea = global::Infragistics.Windows.Utilities.GetWorkArea(frameworkElement, default(global::System.Windows.Point), null);
				global::System.Windows.Rect workArea2 = global::Infragistics.Windows.Utilities.GetWorkArea(frameworkElement, new global::System.Windows.Point(frameworkElement.ActualWidth, frameworkElement.ActualHeight), null);
				workArea.Intersect(rect);
				workArea2.Intersect(rect);
				double num = workArea.Width * workArea.Height;
				double num2 = workArea2.Width * workArea2.Height;
				point3 = ((num >= num2) ? workArea.Location : workArea2.Location);
				point3 = global::Infragistics.Windows.Utilities.PointFromScreenSafe(frameworkElement, point3);
			}
			global::System.Windows.Rect workArea3 = global::Infragistics.Windows.Utilities.GetWorkArea(frameworkElement, point3, null);
			global::System.Windows.Rect rect2 = global::System.Windows.Rect.Intersect(rect, workArea3);
			global::System.Windows.Point point4 = global::Infragistics.Windows.Utilities.PointFromScreenSafe(frameworkElement, rect2.Location);
			global::System.Windows.Point point5 = global::Infragistics.Windows.Utilities.PointFromScreenSafe(frameworkElement, new global::System.Windows.Point(rect2.Right, rect2.Bottom));
			global::System.Windows.Rect rect3 = global::Infragistics.Windows.Utilities.RectFromPoints(point4, point5);
			double num3 = (base.TabStripPlacement == global::System.Windows.Controls.Dock.Left || base.TabStripPlacement == global::System.Windows.Controls.Dock.Right) ? rect3.Height : rect3.Width;
			base.SetValue(global::Infragistics.Windows.Controls.XamTabControl.PreferredDropDownExtentPropertyKey, num3);
			if (this._popup != null && this._popup.CustomPopupPlacementCallback == this.PreferredDropDownPlacementCallback && this._popup.Placement == global::System.Windows.Controls.Primitives.PlacementMode.Custom)
			{
				if (this._popupPlacementAdorner == null)
				{
					this._popupPlacementAdorner = new global::Infragistics.Windows.Controls.XamTabControl.PopupPlacementAdorner(this);
				}
				if (!(this._popupPlacementAdorner.Parent is global::System.Windows.Documents.AdornerLayer))
				{
					global::System.Windows.Documents.AdornerLayer adornerLayer = global::System.Windows.Documents.AdornerLayer.GetAdornerLayer(this);
					if (adornerLayer != null)
					{
						adornerLayer.Add(this._popupPlacementAdorner);
					}
				}
				else
				{
					((global::System.Windows.Documents.AdornerLayer)this._popupPlacementAdorner.Parent).InvalidateArrange();
				}
				this._popupPlacementAdorner.Rect = frameworkElement.TransformToVisual(this).TransformBounds(rect3);
				if (!(this._popup.PlacementTarget is global::Infragistics.Windows.Controls.XamTabControl.PopupPlacementAdorner))
				{
					this._oldPlacementTarget = this._popup.ReadLocalValue(global::System.Windows.Controls.Primitives.Popup.PlacementTargetProperty);
					this._popup.PlacementTarget = this._popupPlacementAdorner;
				}
			}
		}

		// Token: 0x06001AA8 RID: 6824 RVA: 0x00067ACE File Offset: 0x00065CCE
		private void OnAfterContainersGenerated(object context)
		{
			this._suppressSelectionChangeCount--;
		}

		// Token: 0x06001AA9 RID: 6825 RVA: 0x00067AE0 File Offset: 0x00065CE0
		private static void OnComputedScrollBarVisibilityChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.Controls.XamTabControl xamTabControl = d as global::Infragistics.Windows.Controls.XamTabControl;
			if (xamTabControl != null)
			{
				global::System.Windows.Visibility visibility = (global::System.Windows.Visibility)xamTabControl.GetValue(global::Infragistics.Windows.Controls.XamTabControl.ComputedTabItemHorizontalScrollBarVisibilityProperty);
				global::System.Windows.Visibility visibility2 = (global::System.Windows.Visibility)xamTabControl.GetValue(global::Infragistics.Windows.Controls.XamTabControl.ComputedTabItemVerticalScrollBarVisibilityProperty);
				bool value = visibility == global::System.Windows.Visibility.Visible || visibility2 == global::System.Windows.Visibility.Visible;
				xamTabControl.SetValue(global::Infragistics.Windows.Controls.XamTabControl.IsTabItemPanelScrollingPropertyKey, global::Infragistics.KnownBoxes.FromValue(value));
			}
		}

		// Token: 0x06001AAA RID: 6826 RVA: 0x00067B38 File Offset: 0x00065D38
		private void OnGeneratorStatusChanged(object sender, global::System.EventArgs e)
		{
			if (base.ItemContainerGenerator.Status == global::System.Windows.Controls.Primitives.GeneratorStatus.ContainersGenerated)
			{
				if (this.IsMinimized)
				{
					this._suppressSelectionChangeCount++;
					base.Dispatcher.BeginInvoke(global::System.Windows.Threading.DispatcherPriority.Send, new global::System.Threading.ContextCallback(this.OnAfterContainersGenerated), null);
					return;
				}
				if (base.HasItems && base.SelectedIndex < 0)
				{
					global::System.Windows.Controls.TabItem firstTabItemToSelect = this.GetFirstTabItemToSelect();
					if (firstTabItemToSelect != null)
					{
						global::Infragistics.DependencyPropertyUtilities.SetCurrentValue(firstTabItemToSelect, global::System.Windows.Controls.TabItem.IsSelectedProperty, global::Infragistics.KnownBoxes.TrueBox);
					}
				}
			}
		}

		// Token: 0x06001AAB RID: 6827 RVA: 0x00067BB0 File Offset: 0x00065DB0
		private void OnLayoutUpdated(object sender, global::System.EventArgs e)
		{
			base.LayoutUpdated -= this.OnLayoutUpdated;
			if (this._isRefreshSelectedTabPeerPending)
			{
				this._isRefreshSelectedTabPeerPending = false;
				global::System.Windows.Controls.TabItem selectedTabItem = this.GetSelectedTabItem();
				if (selectedTabItem != null)
				{
					global::System.Windows.Automation.Peers.AutomationPeer automationPeer = global::System.Windows.Automation.Peers.UIElementAutomationPeer.FromElement(selectedTabItem);
					if (automationPeer != null && automationPeer.EventsSource != null)
					{
						automationPeer.EventsSource.ResetChildrenCache();
					}
				}
			}
		}

		// Token: 0x06001AAC RID: 6828 RVA: 0x00067C08 File Offset: 0x00065E08
		private void OnPopupClosed(object sender, global::System.EventArgs e)
		{
			global::System.Windows.Controls.Primitives.Popup popup = sender as global::System.Windows.Controls.Primitives.Popup;
			if (this._oldPlacementTarget != global::Infragistics.Windows.Controls.XamTabControl.NotInitialized)
			{
				if (this._oldPlacementTarget == global::System.Windows.DependencyProperty.UnsetValue)
				{
					popup.ClearValue(global::System.Windows.Controls.Primitives.Popup.PlacementTargetProperty);
				}
				else if (this._oldPlacementTarget is global::System.Windows.Data.BindingBase)
				{
					popup.SetBinding(global::System.Windows.Controls.Primitives.Popup.PlacementTargetProperty, (global::System.Windows.Data.BindingBase)this._oldPlacementTarget);
				}
				else
				{
					popup.SetValue(global::System.Windows.Controls.Primitives.Popup.PlacementTargetProperty, this._oldPlacementTarget);
				}
			}
			this._oldPlacementTarget = global::Infragistics.Windows.Controls.XamTabControl.NotInitialized;
		}

		// Token: 0x06001AAD RID: 6829 RVA: 0x00067C88 File Offset: 0x00065E88
		private static void OnPopupPreviewMouseUp_ClassHandler(object sender, global::System.Windows.Input.MouseButtonEventArgs e)
		{
			if (e.ChangedButton != global::System.Windows.Input.MouseButton.Left)
			{
				return;
			}
			global::System.Windows.Controls.Primitives.Popup popup = sender as global::System.Windows.Controls.Primitives.Popup;
			if (popup == null)
			{
				return;
			}
			global::Infragistics.Windows.Controls.XamTabControl xamTabControl = popup.TemplatedParent as global::Infragistics.Windows.Controls.XamTabControl;
			if (xamTabControl == null)
			{
				return;
			}
			if (!xamTabControl.IsMinimized || !xamTabControl.IsDropDownOpen)
			{
				return;
			}
			global::System.Windows.Point position = e.GetPosition(xamTabControl);
			global::System.Windows.DependencyObject dependencyObject = xamTabControl.InputHitTest(position) as global::System.Windows.DependencyObject;
			if (dependencyObject == null)
			{
				return;
			}
			global::System.Windows.Controls.TabItem tabItem = global::Infragistics.Windows.Utilities.GetAncestorFromType(dependencyObject, typeof(global::System.Windows.Controls.TabItem), true, xamTabControl) as global::System.Windows.Controls.TabItem;
			if (tabItem == null)
			{
				return;
			}
			int num = xamTabControl.ItemContainerGenerator.IndexFromContainer(tabItem);
			if (num < 0)
			{
				return;
			}
			if (num == xamTabControl.SelectedIndex)
			{
				e.Handled = true;
			}
		}

		// Token: 0x06001AAE RID: 6830 RVA: 0x00067D28 File Offset: 0x00065F28
		private static void OnTabStripPlacementChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.Controls.XamTabControl xamTabControl = d as global::Infragistics.Windows.Controls.XamTabControl;
			if (xamTabControl != null)
			{
				xamTabControl.VerifyScrollBarVisibility();
			}
		}

		// Token: 0x06001AAF RID: 6831 RVA: 0x00067D48 File Offset: 0x00065F48
		private void RaiseAutomationExpandCollapseStateChanged()
		{
			global::Infragistics.Windows.Automation.Peers.XamTabControlAutomationPeer xamTabControlAutomationPeer = global::System.Windows.Automation.Peers.UIElementAutomationPeer.FromElement(this) as global::Infragistics.Windows.Automation.Peers.XamTabControlAutomationPeer;
			if (xamTabControlAutomationPeer != null)
			{
				xamTabControlAutomationPeer.RaiseExpandCollapseStateChanged();
			}
		}

		// Token: 0x06001AB0 RID: 6832 RVA: 0x00067D6A File Offset: 0x00065F6A
		private void RefreshSelectedTabPeerChildren()
		{
			if (this._isRefreshSelectedTabPeerPending)
			{
				return;
			}
			this._isRefreshSelectedTabPeerPending = true;
			base.LayoutUpdated -= this.OnLayoutUpdated;
			base.LayoutUpdated += this.OnLayoutUpdated;
		}

		// Token: 0x06001AB1 RID: 6833 RVA: 0x00067DA0 File Offset: 0x00065FA0
		private void ResetSelectedItem()
		{
			if (this.IsMinimized && !this.IsDropDownOpen && base.SelectedItem != null)
			{
				this._previouslySelectedItem = base.SelectedItem;
				global::System.Windows.Controls.TabItem tabItem = base.ItemContainerGenerator.ContainerFromItem(this._previouslySelectedItem) as global::System.Windows.Controls.TabItem;
				base.ClearValue(global::System.Windows.Controls.Primitives.Selector.SelectedItemProperty);
				if (tabItem != null)
				{
					if (tabItem.IsKeyboardFocusWithin)
					{
						if (tabItem.Focusable)
						{
							tabItem.Focus();
							return;
						}
						base.Focus();
						return;
					}
					else
					{
						global::System.Windows.DependencyObject focusScope = global::System.Windows.Input.FocusManager.GetFocusScope(tabItem);
						if (focusScope != null && focusScope == global::System.Windows.Input.FocusManager.GetFocusScope(this))
						{
							global::Infragistics.Windows.Utilities.SetFocusedElement(focusScope, this);
							return;
						}
					}
				}
			}
			else if (base.SelectedItem == null && (!this.IsMinimized || this.IsDropDownOpen))
			{
				if (this._previouslySelectedItem == null && base.Items.Count > 0)
				{
					this._previouslySelectedItem = this.GetFirstVisibleTabItem();
				}
				if (base.ItemContainerGenerator.ContainerFromItem(this._previouslySelectedItem) != null)
				{
					base.SelectedItem = this._previouslySelectedItem;
				}
				this._previouslySelectedItem = null;
			}
		}

		// Token: 0x06001AB2 RID: 6834 RVA: 0x00067E94 File Offset: 0x00066094
		private void UpdateThemeResources()
		{
			string[] groupings = new string[]
			{
				global::Infragistics.Windows.Themes.PrimitivesResourceSet<global::Infragistics.Windows.Themes.PrimitivesGeneric.Locator>.Location.Grouping
			};
			global::Infragistics.Windows.Themes.ThemeManager.OnThemeChanged(this, this.Theme, groupings);
			if (base.IsInitialized)
			{
				base.InvalidateMeasure();
				base.UpdateLayout();
			}
		}

		// Token: 0x06001AB3 RID: 6835 RVA: 0x00067ED8 File Offset: 0x000660D8
		private void VerifyScrollBarVisibility()
		{
			object value;
			object value2;
			if (this.IsMultiRow != this.HasVerticalTabs)
			{
				value = global::Infragistics.KnownBoxes.ScrollBarVisibilityAutoBox;
				value2 = global::Infragistics.KnownBoxes.ScrollBarVisibilityDisabledBox;
			}
			else
			{
				value = global::Infragistics.KnownBoxes.ScrollBarVisibilityDisabledBox;
				value2 = global::Infragistics.KnownBoxes.ScrollBarVisibilityAutoBox;
			}
			base.SetValue(global::Infragistics.Windows.Controls.XamTabControl.TabItemHorizontalScrollBarVisibilityPropertyKey, value2);
			base.SetValue(global::Infragistics.Windows.Controls.XamTabControl.TabItemVerticalScrollBarVisibilityPropertyKey, value);
		}

		// Token: 0x06001AB4 RID: 6836 RVA: 0x00067F28 File Offset: 0x00066128
		private void VerifyMinimizedContentBinding()
		{
			bool isMinimized = this.IsMinimized;
			global::System.Windows.Controls.ContentPresenter cpMinimized = this._cpMinimized;
			global::System.Windows.Controls.ContentPresenter cpMaximized = this._cpMaximized;
			if (cpMinimized != null && cpMaximized != null)
			{
				global::System.Windows.Controls.ContentPresenter contentPresenter = isMinimized ? cpMaximized : cpMinimized;
				global::System.Windows.Controls.ContentPresenter contentPresenter2 = isMinimized ? cpMinimized : cpMaximized;
				contentPresenter.Content = null;
				contentPresenter2.SetBinding(global::System.Windows.Controls.ContentPresenter.ContentProperty, global::Infragistics.Windows.Utilities.CreateBindingObject(global::System.Windows.Controls.TabControl.SelectedContentProperty, global::System.Windows.Data.BindingMode.OneWay, this));
			}
		}

		// Token: 0x06001AB5 RID: 6837 RVA: 0x00067F84 File Offset: 0x00066184
		private void VerifySelectedContent()
		{
			object selectedItem = base.SelectedItem;
			global::System.Windows.Controls.TabItem tabItem = selectedItem as global::System.Windows.Controls.TabItem;
			if (tabItem == null && selectedItem != null)
			{
				tabItem = (base.ItemContainerGenerator.ContainerFromItem(selectedItem) as global::System.Windows.Controls.TabItem);
			}
			if (tabItem != null && base.SelectedContent != tabItem.Content)
			{
				base.OnApplyTemplate();
			}
		}

		// Token: 0x06001AB6 RID: 6838 RVA: 0x00067FCE File Offset: 0x000661CE
		protected virtual void OnDropDownClosed(global::System.Windows.RoutedEventArgs args)
		{
			base.RaiseEvent(args);
		}

		// Token: 0x06001AB7 RID: 6839 RVA: 0x00067FD7 File Offset: 0x000661D7
		internal void RaiseDropDownClosed(global::System.Windows.RoutedEventArgs args)
		{
			args.RoutedEvent = global::Infragistics.Windows.Controls.XamTabControl.DropDownClosedEvent;
			args.Source = this;
			this.OnDropDownClosed(args);
		}

		// Token: 0x1400003E RID: 62
		// (add) Token: 0x06001AB8 RID: 6840 RVA: 0x00067FF2 File Offset: 0x000661F2
		// (remove) Token: 0x06001AB9 RID: 6841 RVA: 0x00068000 File Offset: 0x00066200
		public event global::System.Windows.RoutedEventHandler DropDownClosed
		{
			add
			{
				base.AddHandler(global::Infragistics.Windows.Controls.XamTabControl.DropDownClosedEvent, value);
			}
			remove
			{
				base.RemoveHandler(global::Infragistics.Windows.Controls.XamTabControl.DropDownClosedEvent, value);
			}
		}

		// Token: 0x06001ABA RID: 6842 RVA: 0x0006800E File Offset: 0x0006620E
		protected virtual void OnDropDownOpened(global::System.Windows.RoutedEventArgs args)
		{
			base.RaiseEvent(args);
		}

		// Token: 0x06001ABB RID: 6843 RVA: 0x00068017 File Offset: 0x00066217
		internal void RaiseDropDownOpened(global::System.Windows.RoutedEventArgs args)
		{
			args.RoutedEvent = global::Infragistics.Windows.Controls.XamTabControl.DropDownOpenedEvent;
			args.Source = this;
			this.OnDropDownOpened(args);
		}

		// Token: 0x1400003F RID: 63
		// (add) Token: 0x06001ABC RID: 6844 RVA: 0x00068032 File Offset: 0x00066232
		// (remove) Token: 0x06001ABD RID: 6845 RVA: 0x00068040 File Offset: 0x00066240
		public event global::System.Windows.RoutedEventHandler DropDownOpened
		{
			add
			{
				base.AddHandler(global::Infragistics.Windows.Controls.XamTabControl.DropDownOpenedEvent, value);
			}
			remove
			{
				base.RemoveHandler(global::Infragistics.Windows.Controls.XamTabControl.DropDownOpenedEvent, value);
			}
		}

		// Token: 0x06001ABE RID: 6846 RVA: 0x0006804E File Offset: 0x0006624E
		protected virtual void OnDropDownOpening(global::Infragistics.Windows.Controls.Events.TabControlDropDownOpeningEventArgs args)
		{
			base.RaiseEvent(args);
		}

		// Token: 0x06001ABF RID: 6847 RVA: 0x00068057 File Offset: 0x00066257
		private void RaiseDropDownOpening(global::Infragistics.Windows.Controls.Events.TabControlDropDownOpeningEventArgs args)
		{
			args.RoutedEvent = global::Infragistics.Windows.Controls.XamTabControl.DropDownOpeningEvent;
			args.Source = this;
			this.OnDropDownOpening(args);
		}

		// Token: 0x14000040 RID: 64
		// (add) Token: 0x06001AC0 RID: 6848 RVA: 0x00068072 File Offset: 0x00066272
		// (remove) Token: 0x06001AC1 RID: 6849 RVA: 0x00068080 File Offset: 0x00066280
		public event global::System.EventHandler<global::Infragistics.Windows.Controls.Events.TabControlDropDownOpeningEventArgs> DropDownOpening
		{
			add
			{
				base.AddHandler(global::Infragistics.Windows.Controls.XamTabControl.DropDownOpeningEvent, value);
			}
			remove
			{
				base.RemoveHandler(global::Infragistics.Windows.Controls.XamTabControl.DropDownOpeningEvent, value);
			}
		}

		// Token: 0x06001AC2 RID: 6850 RVA: 0x0006808E File Offset: 0x0006628E
		protected virtual void OnExecutingCommand(global::Infragistics.Windows.Controls.Events.ExecutingCommandEventArgs args)
		{
			base.RaiseEvent(args);
		}

		// Token: 0x06001AC3 RID: 6851 RVA: 0x00068097 File Offset: 0x00066297
		internal bool RaiseExecutingCommand(global::Infragistics.Windows.Controls.Events.ExecutingCommandEventArgs args)
		{
			args.RoutedEvent = global::Infragistics.Windows.Controls.XamTabControl.ExecutingCommandEvent;
			args.Source = this;
			this.OnExecutingCommand(args);
			return !args.Cancel;
		}

		// Token: 0x14000041 RID: 65
		// (add) Token: 0x06001AC4 RID: 6852 RVA: 0x000680BB File Offset: 0x000662BB
		// (remove) Token: 0x06001AC5 RID: 6853 RVA: 0x000680C9 File Offset: 0x000662C9
		public event global::System.EventHandler<global::Infragistics.Windows.Controls.Events.ExecutingCommandEventArgs> ExecutingCommand
		{
			add
			{
				base.AddHandler(global::Infragistics.Windows.Controls.XamTabControl.ExecutingCommandEvent, value);
			}
			remove
			{
				base.RemoveHandler(global::Infragistics.Windows.Controls.XamTabControl.ExecutingCommandEvent, value);
			}
		}

		// Token: 0x06001AC6 RID: 6854 RVA: 0x000680D7 File Offset: 0x000662D7
		protected virtual void OnExecutedCommand(global::Infragistics.Windows.Controls.Events.ExecutedCommandEventArgs args)
		{
			base.RaiseEvent(args);
		}

		// Token: 0x06001AC7 RID: 6855 RVA: 0x000680E0 File Offset: 0x000662E0
		internal void RaiseExecutedCommand(global::Infragistics.Windows.Controls.Events.ExecutedCommandEventArgs args)
		{
			args.RoutedEvent = global::Infragistics.Windows.Controls.XamTabControl.ExecutedCommandEvent;
			args.Source = this;
			this.OnExecutedCommand(args);
		}

		// Token: 0x14000042 RID: 66
		// (add) Token: 0x06001AC8 RID: 6856 RVA: 0x000680FB File Offset: 0x000662FB
		// (remove) Token: 0x06001AC9 RID: 6857 RVA: 0x00068109 File Offset: 0x00066309
		public event global::System.EventHandler<global::Infragistics.Windows.Controls.Events.ExecutedCommandEventArgs> ExecutedCommand
		{
			add
			{
				base.AddHandler(global::Infragistics.Windows.Controls.XamTabControl.ExecutedCommandEvent, value);
			}
			remove
			{
				base.RemoveHandler(global::Infragistics.Windows.Controls.XamTabControl.ExecutedCommandEvent, value);
			}
		}

		// Token: 0x06001ACA RID: 6858 RVA: 0x00068118 File Offset: 0x00066318
		bool global::Infragistics.Windows.Commands.ICommandHost.Execute(global::Infragistics.Windows.Commands.ExecuteCommandInfo commandInfo)
		{
			global::System.Windows.Input.RoutedCommand routedCommand = commandInfo.RoutedCommand;
			return routedCommand != null && this.ExecuteCommandImpl(commandInfo);
		}

		// Token: 0x06001ACB RID: 6859 RVA: 0x00068138 File Offset: 0x00066338
		long global::Infragistics.Windows.Commands.ICommandHost.GetCurrentState(long statesToQuery)
		{
			global::Infragistics.Windows.Controls.TabControlStates tabControlStates = (global::Infragistics.Windows.Controls.TabControlStates)0L;
			if (this.AllowMinimize)
			{
				tabControlStates |= global::Infragistics.Windows.Controls.TabControlStates.AllowMinimized;
			}
			if (this.IsMinimized)
			{
				tabControlStates |= global::Infragistics.Windows.Controls.TabControlStates.Minimized;
			}
			global::System.Windows.Controls.TabItem selectedTabItem = this.GetSelectedTabItem();
			if (selectedTabItem != null)
			{
				tabControlStates |= global::Infragistics.Windows.Controls.TabControlStates.HasSelectedTab;
				if (selectedTabItem is global::Infragistics.Windows.Controls.TabItemEx && ((global::Infragistics.Windows.Controls.TabItemEx)selectedTabItem).AllowClosingResolved)
				{
					tabControlStates |= global::Infragistics.Windows.Controls.TabControlStates.SelectedTabAllowsClosing;
				}
			}
			global::System.Windows.Controls.TabItem firstTabItem = this.GetFirstTabItem(true, true);
			if (firstTabItem != null)
			{
				tabControlStates |= global::Infragistics.Windows.Controls.TabControlStates.HasSelectableTab;
				if (selectedTabItem == firstTabItem)
				{
					tabControlStates |= global::Infragistics.Windows.Controls.TabControlStates.FirstTabSelected;
				}
				global::System.Windows.Controls.TabItem lastTabItem = this.GetLastTabItem(true, true);
				if (selectedTabItem == lastTabItem)
				{
					tabControlStates |= global::Infragistics.Windows.Controls.TabControlStates.LastTabSelected;
				}
			}
			return (long)tabControlStates;
		}

		// Token: 0x06001ACC RID: 6860 RVA: 0x000681BC File Offset: 0x000663BC
		bool global::Infragistics.Windows.Commands.ICommandHost.CanExecute(global::Infragistics.Windows.Commands.ExecuteCommandInfo commandInfo)
		{
			global::System.Windows.Input.RoutedCommand routedCommand = commandInfo.RoutedCommand;
			if (routedCommand == null)
			{
				return false;
			}
			if (routedCommand == global::Infragistics.Windows.Controls.TabControlCommands.ToggleMinimized)
			{
				return this.AllowMinimize;
			}
			if (routedCommand == global::Infragistics.Windows.Controls.TabControlCommands.Expand)
			{
				return this.IsMinimized;
			}
			if (routedCommand == global::Infragistics.Windows.Controls.TabControlCommands.Minimize)
			{
				return this.AllowMinimize && !this.IsMinimized;
			}
			if (routedCommand == global::Infragistics.Windows.Controls.TabItemExCommands.Close || routedCommand == global::Infragistics.Windows.Controls.TabControlCommands.CloseSelected)
			{
				global::Infragistics.Windows.Controls.TabItemEx tabItemEx = this.GetSelectedTabItem() as global::Infragistics.Windows.Controls.TabItemEx;
				return tabItemEx != null && tabItemEx.AllowClosingResolved;
			}
			global::System.Windows.Controls.TabItem firstTabItem = this.GetFirstTabItem(false, true);
			if (routedCommand == global::Infragistics.Windows.Controls.TabControlCommands.CloseAll)
			{
				return firstTabItem != null;
			}
			if (firstTabItem != null)
			{
				global::System.Windows.Controls.TabItem firstTabItem2 = this.GetFirstTabItem(true, true);
				if (firstTabItem2 != null)
				{
					global::System.Windows.Controls.TabItem selectedTabItem = this.GetSelectedTabItem();
					if (routedCommand == global::Infragistics.Windows.Controls.TabItemExCommands.CloseAllButThis)
					{
						return selectedTabItem != null;
					}
					if (routedCommand == global::Infragistics.Windows.Controls.TabControlCommands.SelectFirstTab)
					{
						return firstTabItem2 != selectedTabItem;
					}
					global::System.Windows.Controls.TabItem lastTabItem = this.GetLastTabItem(true, true);
					if (routedCommand == global::Infragistics.Windows.Controls.TabControlCommands.SelectLastTab)
					{
						return lastTabItem != selectedTabItem;
					}
					if (selectedTabItem != null)
					{
						if (routedCommand == global::Infragistics.Windows.Controls.TabControlCommands.SelectNextTab)
						{
							return lastTabItem != selectedTabItem;
						}
						if (routedCommand == global::Infragistics.Windows.Controls.TabControlCommands.SelectPreviousTab)
						{
							return firstTabItem2 != selectedTabItem;
						}
					}
				}
			}
			return false;
		}

		// Token: 0x04000C5F RID: 3167
		internal const double DefaultInterRowSpacing = 0.0;

		// Token: 0x04000C60 RID: 3168
		internal const double DefaultInterTabSpacing = 0.0;

		// Token: 0x04000C61 RID: 3169
		internal const double DefaultMaximumSizeToFit = 0.0;

		// Token: 0x04000C62 RID: 3170
		internal const double DefaultMinimumTabExtent = 18.0;

		// Token: 0x04000C63 RID: 3171
		private object _previouslySelectedItem;

		// Token: 0x04000C64 RID: 3172
		private global::System.Windows.Controls.ScrollViewer _tabItemScrollViewer;

		// Token: 0x04000C65 RID: 3173
		private global::System.Windows.Controls.Primitives.Popup _popup;

		// Token: 0x04000C66 RID: 3174
		private int _lastSingleLeftMouseDownTime;

		// Token: 0x04000C67 RID: 3175
		private global::System.Windows.Point _lastSingleLeftMouseDownPoint;

		// Token: 0x04000C68 RID: 3176
		private global::Infragistics.Windows.Licensing.UltraLicense _license;

		// Token: 0x04000C69 RID: 3177
		private global::System.Windows.Controls.ContentPresenter _cpMaximized;

		// Token: 0x04000C6A RID: 3178
		private global::System.Windows.Controls.ContentPresenter _cpMinimized;

		// Token: 0x04000C6B RID: 3179
		private global::Infragistics.Windows.Controls.XamTabControl.PopupPlacementAdorner _popupPlacementAdorner;

		// Token: 0x04000C6C RID: 3180
		private static readonly object NotInitialized = new object();

		// Token: 0x04000C6D RID: 3181
		private object _oldPlacementTarget = global::Infragistics.Windows.Controls.XamTabControl.NotInitialized;

		// Token: 0x04000C6E RID: 3182
		private int _suppressSelectionChangeCount;

		// Token: 0x04000C6F RID: 3183
		private bool _initializingSelection;

		// Token: 0x04000C70 RID: 3184
		private bool _eatNextMouseLeftButtonUp;

		// Token: 0x04000C71 RID: 3185
		private bool _isRefreshSelectedTabPeerPending;

		// Token: 0x04000C72 RID: 3186
		private static readonly global::System.Windows.DependencyPropertyKey IsMultiRowPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("IsMultiRow", typeof(bool), typeof(global::Infragistics.Windows.Controls.XamTabControl), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.Controls.XamTabControl.OnIsMultiRowChanged)));

		// Token: 0x04000C73 RID: 3187
		public static readonly global::System.Windows.DependencyProperty IsMultiRowProperty = global::Infragistics.Windows.Controls.XamTabControl.IsMultiRowPropertyKey.DependencyProperty;

		// Token: 0x04000C74 RID: 3188
		private static readonly global::System.Windows.DependencyProperty ComputedTabItemHorizontalScrollBarVisibilityProperty = global::System.Windows.DependencyProperty.Register("ComputedTabItemHorizontalScrollBarVisibility", typeof(global::System.Windows.Visibility), typeof(global::Infragistics.Windows.Controls.XamTabControl), new global::System.Windows.FrameworkPropertyMetadata(global::System.Windows.Visibility.Collapsed, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.Controls.XamTabControl.OnComputedScrollBarVisibilityChanged)));

		// Token: 0x04000C75 RID: 3189
		private static readonly global::System.Windows.DependencyProperty ComputedTabItemVerticalScrollBarVisibilityProperty = global::System.Windows.DependencyProperty.Register("ComputedTabItemVerticalScrollBarVisibility", typeof(global::System.Windows.Visibility), typeof(global::Infragistics.Windows.Controls.XamTabControl), new global::System.Windows.FrameworkPropertyMetadata(global::System.Windows.Visibility.Collapsed, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.Controls.XamTabControl.OnComputedScrollBarVisibilityChanged)));

		// Token: 0x04000C76 RID: 3190
		private static readonly global::System.Windows.DependencyPropertyKey InternalVersionPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("InternalVersion", typeof(int), typeof(global::Infragistics.Windows.Controls.XamTabControl), new global::System.Windows.FrameworkPropertyMetadata(0));

		// Token: 0x04000C77 RID: 3191
		internal static readonly global::System.Windows.DependencyProperty InternalVersionProperty = global::Infragistics.Windows.Controls.XamTabControl.InternalVersionPropertyKey.DependencyProperty;

		// Token: 0x04000C78 RID: 3192
		public static readonly global::System.Windows.DependencyProperty AllowMinimizeProperty = global::System.Windows.DependencyProperty.Register("AllowMinimize", typeof(bool), typeof(global::Infragistics.Windows.Controls.XamTabControl), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.Controls.XamTabControl.OnAllowMinimizeChanged)));

		// Token: 0x04000C79 RID: 3193
		public static readonly global::System.Windows.DependencyProperty AllowTabClosingProperty = global::System.Windows.DependencyProperty.Register("AllowTabClosing", typeof(bool?), typeof(global::Infragistics.Windows.Controls.XamTabControl), new global::System.Windows.FrameworkPropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.Controls.XamTabControl.OnAllowTabClosingChanged)));

		// Token: 0x04000C7A RID: 3194
		public static readonly global::System.Windows.DependencyProperty DropDownAnimationProperty = global::System.Windows.DependencyProperty.Register("DropDownAnimation", typeof(global::System.Windows.Controls.Primitives.PopupAnimation), typeof(global::Infragistics.Windows.Controls.XamTabControl), new global::System.Windows.FrameworkPropertyMetadata(global::System.Windows.Controls.Primitives.PopupAnimation.None));

		// Token: 0x04000C7B RID: 3195
		public static readonly global::System.Windows.DependencyProperty InterRowSpacingProperty = global::System.Windows.DependencyProperty.Register("InterRowSpacing", typeof(double), typeof(global::Infragistics.Windows.Controls.XamTabControl), new global::System.Windows.FrameworkPropertyMetadata(0.0));

		// Token: 0x04000C7C RID: 3196
		public static readonly global::System.Windows.DependencyProperty InterTabSpacingProperty = global::System.Windows.DependencyProperty.Register("InterTabSpacing", typeof(double), typeof(global::Infragistics.Windows.Controls.XamTabControl), new global::System.Windows.FrameworkPropertyMetadata(0.0));

		// Token: 0x04000C7D RID: 3197
		public static readonly global::System.Windows.DependencyProperty IsDropDownOpenProperty = global::System.Windows.DependencyProperty.Register("IsDropDownOpen", typeof(bool), typeof(global::Infragistics.Windows.Controls.XamTabControl), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox, global::System.Windows.FrameworkPropertyMetadataOptions.BindsTwoWayByDefault, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.Controls.XamTabControl.OnIsDropDownOpenChanged), new global::System.Windows.CoerceValueCallback(global::Infragistics.Windows.Controls.XamTabControl.CoerceIsDropDownOpen)));

		// Token: 0x04000C7E RID: 3198
		public static readonly global::System.Windows.DependencyProperty IsMinimizedProperty = global::System.Windows.DependencyProperty.Register("IsMinimized", typeof(bool), typeof(global::Infragistics.Windows.Controls.XamTabControl), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.Controls.XamTabControl.OnIsMinimizedChanged)));

		// Token: 0x04000C7F RID: 3199
		private static readonly global::System.Windows.DependencyPropertyKey IsTabItemPanelScrollingPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("IsTabItemPanelScrolling", typeof(bool), typeof(global::Infragistics.Windows.Controls.XamTabControl), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox));

		// Token: 0x04000C80 RID: 3200
		public static readonly global::System.Windows.DependencyProperty IsTabItemPanelScrollingProperty = global::Infragistics.Windows.Controls.XamTabControl.IsTabItemPanelScrollingPropertyKey.DependencyProperty;

		// Token: 0x04000C81 RID: 3201
		public static readonly global::System.Windows.DependencyProperty MaximumSizeToFitAdjustmentProperty = global::System.Windows.DependencyProperty.Register("MaximumSizeToFitAdjustment", typeof(double), typeof(global::Infragistics.Windows.Controls.XamTabControl), new global::System.Windows.FrameworkPropertyMetadata(0.0), new global::System.Windows.ValidateValueCallback(global::Infragistics.Windows.Controls.XamTabControl.OnValidateAtLeastZero));

		// Token: 0x04000C82 RID: 3202
		public static readonly global::System.Windows.DependencyProperty MaximumTabRowsProperty = global::System.Windows.DependencyProperty.Register("MaximumTabRows", typeof(int), typeof(global::Infragistics.Windows.Controls.XamTabControl), new global::System.Windows.FrameworkPropertyMetadata(3), new global::System.Windows.ValidateValueCallback(global::Infragistics.Windows.Controls.XamTabControl.ValidateMaximumTabRows));

		// Token: 0x04000C83 RID: 3203
		public static readonly global::System.Windows.DependencyProperty MinimumTabExtentProperty = global::System.Windows.DependencyProperty.Register("MinimumTabExtent", typeof(double), typeof(global::Infragistics.Windows.Controls.XamTabControl), new global::System.Windows.FrameworkPropertyMetadata(18.0), new global::System.Windows.ValidateValueCallback(global::Infragistics.Windows.Controls.XamTabControl.OnValidateAtLeastZero));

		// Token: 0x04000C84 RID: 3204
		public static readonly global::System.Windows.DependencyProperty PostTabItemContentProperty = global::System.Windows.DependencyProperty.Register("PostTabItemContent", typeof(object), typeof(global::Infragistics.Windows.Controls.XamTabControl), new global::System.Windows.FrameworkPropertyMetadata(null));

		// Token: 0x04000C85 RID: 3205
		public static readonly global::System.Windows.DependencyProperty PostTabItemContentTemplateProperty = global::System.Windows.DependencyProperty.Register("PostTabItemContentTemplate", typeof(global::System.Windows.DataTemplate), typeof(global::Infragistics.Windows.Controls.XamTabControl), new global::System.Windows.FrameworkPropertyMetadata(null));

		// Token: 0x04000C86 RID: 3206
		public static readonly global::System.Windows.DependencyProperty PostTabItemContentTemplateSelectorProperty = global::System.Windows.DependencyProperty.Register("PostTabItemContentTemplateSelector", typeof(global::System.Windows.Controls.DataTemplateSelector), typeof(global::Infragistics.Windows.Controls.XamTabControl), new global::System.Windows.FrameworkPropertyMetadata(null));

		// Token: 0x04000C87 RID: 3207
		private static readonly global::System.Windows.DependencyPropertyKey PreferredDropDownExtentPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("PreferredDropDownExtent", typeof(double), typeof(global::Infragistics.Windows.Controls.XamTabControl), new global::System.Windows.FrameworkPropertyMetadata(double.NaN));

		// Token: 0x04000C88 RID: 3208
		public static readonly global::System.Windows.DependencyProperty PreferredDropDownExtentProperty = global::Infragistics.Windows.Controls.XamTabControl.PreferredDropDownExtentPropertyKey.DependencyProperty;

		// Token: 0x04000C89 RID: 3209
		private static readonly global::System.Windows.DependencyPropertyKey PreferredDropDownPlacementCallbackPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("PreferredDropDownPlacementCallback", typeof(global::System.Windows.Controls.Primitives.CustomPopupPlacementCallback), typeof(global::Infragistics.Windows.Controls.XamTabControl), new global::System.Windows.FrameworkPropertyMetadata(null));

		// Token: 0x04000C8A RID: 3210
		public static readonly global::System.Windows.DependencyProperty PreferredDropDownPlacementCallbackProperty = global::Infragistics.Windows.Controls.XamTabControl.PreferredDropDownPlacementCallbackPropertyKey.DependencyProperty;

		// Token: 0x04000C8B RID: 3211
		public static readonly global::System.Windows.DependencyProperty PreTabItemContentProperty = global::System.Windows.DependencyProperty.Register("PreTabItemContent", typeof(object), typeof(global::Infragistics.Windows.Controls.XamTabControl), new global::System.Windows.FrameworkPropertyMetadata(null));

		// Token: 0x04000C8C RID: 3212
		public static readonly global::System.Windows.DependencyProperty PreTabItemContentTemplateProperty = global::System.Windows.DependencyProperty.Register("PreTabItemContentTemplate", typeof(global::System.Windows.DataTemplate), typeof(global::Infragistics.Windows.Controls.XamTabControl), new global::System.Windows.FrameworkPropertyMetadata(null));

		// Token: 0x04000C8D RID: 3213
		public static readonly global::System.Windows.DependencyProperty PreTabItemContentTemplateSelectorProperty = global::System.Windows.DependencyProperty.Register("PreTabItemContentTemplateSelector", typeof(global::System.Windows.Controls.DataTemplateSelector), typeof(global::Infragistics.Windows.Controls.XamTabControl), new global::System.Windows.FrameworkPropertyMetadata(null));

		// Token: 0x04000C8E RID: 3214
		public static readonly global::System.Windows.DependencyProperty ShowTabHeaderCloseButtonProperty = global::System.Windows.DependencyProperty.Register("ShowTabHeaderCloseButton", typeof(bool), typeof(global::Infragistics.Windows.Controls.XamTabControl), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.Controls.XamTabControl.OnShowTabHeaderCloseButtonChanged)));

		// Token: 0x04000C8F RID: 3215
		public static readonly global::System.Windows.DependencyProperty TabHeaderHeightProperty = global::Infragistics.DependencyPropertyUtilities.Register("TabHeaderHeight", typeof(double), typeof(global::Infragistics.Windows.Controls.XamTabControl), global::Infragistics.DependencyPropertyUtilities.CreateMetadata(0.0));

		// Token: 0x04000C90 RID: 3216
		public static readonly global::System.Windows.DependencyProperty TabItemCloseButtonVisibilityProperty = global::System.Windows.DependencyProperty.Register("TabItemCloseButtonVisibility", typeof(global::Infragistics.Windows.Controls.TabItemCloseButtonVisibility), typeof(global::Infragistics.Windows.Controls.XamTabControl), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.Windows.Controls.TabItemCloseButtonVisibility.Hidden, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.Controls.XamTabControl.OnTabItemCloseButtonVisibilityChanged)));

		// Token: 0x04000C91 RID: 3217
		public static readonly global::System.Windows.DependencyProperty TabItemContentHeightProperty = global::System.Windows.DependencyProperty.Register("TabItemContentHeight", typeof(double), typeof(global::Infragistics.Windows.Controls.XamTabControl), new global::System.Windows.FrameworkPropertyMetadata(double.NaN));

		// Token: 0x04000C92 RID: 3218
		private static readonly global::System.Windows.DependencyPropertyKey TabItemHorizontalScrollBarVisibilityPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("TabItemHorizontalScrollBarVisibility", typeof(global::System.Windows.Controls.ScrollBarVisibility), typeof(global::Infragistics.Windows.Controls.XamTabControl), new global::System.Windows.FrameworkPropertyMetadata(global::System.Windows.Controls.ScrollBarVisibility.Auto));

		// Token: 0x04000C93 RID: 3219
		public static readonly global::System.Windows.DependencyProperty TabItemHorizontalScrollBarVisibilityProperty = global::Infragistics.Windows.Controls.XamTabControl.TabItemHorizontalScrollBarVisibilityPropertyKey.DependencyProperty;

		// Token: 0x04000C94 RID: 3220
		private static readonly global::System.Windows.DependencyPropertyKey TabItemVerticalScrollBarVisibilityPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("TabItemVerticalScrollBarVisibility", typeof(global::System.Windows.Controls.ScrollBarVisibility), typeof(global::Infragistics.Windows.Controls.XamTabControl), new global::System.Windows.FrameworkPropertyMetadata(global::System.Windows.Controls.ScrollBarVisibility.Auto));

		// Token: 0x04000C95 RID: 3221
		public static readonly global::System.Windows.DependencyProperty TabItemVerticalScrollBarVisibilityProperty = global::Infragistics.Windows.Controls.XamTabControl.TabItemVerticalScrollBarVisibilityPropertyKey.DependencyProperty;

		// Token: 0x04000C96 RID: 3222
		public static readonly global::System.Windows.DependencyProperty TabLayoutStyleProperty = global::System.Windows.DependencyProperty.Register("TabLayoutStyle", typeof(global::Infragistics.Windows.Controls.TabLayoutStyle), typeof(global::Infragistics.Windows.Controls.XamTabControl), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.Windows.Controls.TabLayoutStyle.SingleRowAutoSize, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.Controls.XamTabControl.OnTabLayoutStyleChanged)));

		// Token: 0x04000C97 RID: 3223
		public static readonly global::System.Windows.DependencyProperty TabPriorityProperty = global::System.Windows.DependencyProperty.RegisterAttached("TabPriority", typeof(int), typeof(global::Infragistics.Windows.Controls.XamTabControl), new global::System.Windows.FrameworkPropertyMetadata(0));

		// Token: 0x04000C98 RID: 3224
		public static readonly global::System.Windows.DependencyProperty ThemeProperty = global::Infragistics.Windows.Themes.ThemeManager.ThemeProperty.AddOwner(typeof(global::Infragistics.Windows.Controls.XamTabControl), new global::System.Windows.FrameworkPropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.Controls.XamTabControl.OnThemeChanged)));

		// Token: 0x04000C9F RID: 3231
		public static readonly global::System.Windows.ResourceKey CloseButtonStyleKey;

		// Token: 0x04000CA0 RID: 3232
		public static readonly global::System.Windows.ResourceKey MultiRowTabItemPagerStyleKey;

		// Token: 0x04000CA1 RID: 3233
		public static readonly global::System.Windows.ResourceKey ScrollDownButtonStyleKey;

		// Token: 0x04000CA2 RID: 3234
		public static readonly global::System.Windows.ResourceKey ScrollLeftButtonStyleKey;

		// Token: 0x04000CA3 RID: 3235
		public static readonly global::System.Windows.ResourceKey ScrollRightButtonStyleKey;

		// Token: 0x04000CA4 RID: 3236
		public static readonly global::System.Windows.ResourceKey ScrollUpButtonStyleKey;

		// Token: 0x04000CA5 RID: 3237
		public static readonly global::System.Windows.ResourceKey SingleRowTabItemPagerStyleKey;

		// Token: 0x0200028C RID: 652
		private class PopupPlacementAdorner : global::Infragistics.Windows.Internal.AdornerEx
		{
			// Token: 0x06001ACD RID: 6861 RVA: 0x000682CD File Offset: 0x000664CD
			internal PopupPlacementAdorner(global::Infragistics.Windows.Controls.XamTabControl tabControl) : base(tabControl)
			{
				base.Visibility = global::System.Windows.Visibility.Hidden;
			}

			// Token: 0x17000646 RID: 1606
			// (get) Token: 0x06001ACE RID: 6862 RVA: 0x000682E9 File Offset: 0x000664E9
			// (set) Token: 0x06001ACF RID: 6863 RVA: 0x000682F1 File Offset: 0x000664F1
			internal global::System.Windows.Rect Rect
			{
				get
				{
					return this._rect;
				}
				set
				{
					if (value != this._rect)
					{
						if (value.IsEmpty)
						{
							value = default(global::System.Windows.Rect);
						}
						this._rect = value;
						base.InvalidateMeasure();
					}
				}
			}

			// Token: 0x06001AD0 RID: 6864 RVA: 0x0006831F File Offset: 0x0006651F
			protected override global::System.Windows.Size MeasureOverride(global::System.Windows.Size constraint)
			{
				return this._rect.Size;
			}

			// Token: 0x06001AD1 RID: 6865 RVA: 0x0006832C File Offset: 0x0006652C
			public override global::System.Windows.Media.GeneralTransform GetDesiredTransform(global::System.Windows.Media.GeneralTransform transform)
			{
				return new global::System.Windows.Media.GeneralTransformGroup
				{
					Children = 
					{
						transform,
						new global::System.Windows.Media.TranslateTransform(this._rect.X, this._rect.Y)
					}
				};
			}

			// Token: 0x04000CA6 RID: 3238
			private global::System.Windows.Rect _rect = default(global::System.Windows.Rect);
		}
	}
}
