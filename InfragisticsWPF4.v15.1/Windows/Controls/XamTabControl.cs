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
using Infragistics.Themes;
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
	// Token: 0x020002C8 RID: 712
	[global::System.ComponentModel.LicenseProvider(typeof(global::Infragistics.Windows.Licensing.UltraLicenseProvider))]
	[global::System.Windows.TemplatePart(Name = "PART_SelectedContentHost", Type = typeof(global::System.Windows.Controls.ContentPresenter))]
	[global::System.Windows.TemplatePart(Name = "PART_SelectedContentHostMinimized", Type = typeof(global::System.Windows.Controls.ContentPresenter))]
	[global::System.Windows.TemplatePart(Name = "PART_HeaderArea", Type = typeof(global::System.Windows.FrameworkElement))]
	[global::System.Windows.TemplatePart(Name = "PART_TabItemScrollViewer", Type = typeof(global::System.Windows.Controls.ScrollViewer))]
	[global::Infragistics.Windows.Licensing.UltraLicense("XamTabControl", global::Infragistics.Windows.Licensing.UltraLicenseAttribute.WpfProductType.DV | global::Infragistics.Windows.Licensing.UltraLicenseAttribute.WpfProductType.LOB)]
	[global::System.Windows.TemplatePart(Name = "PART_Popup", Type = typeof(global::System.Windows.Controls.Primitives.Popup))]
	public class XamTabControl : global::System.Windows.Controls.TabControl, global::Infragistics.Windows.Commands.ICommandHost
	{
		// Token: 0x06001C75 RID: 7285 RVA: 0x0006CD94 File Offset: 0x0006AF94
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
			frameworkElementFactory.SetBinding(global::System.Windows.Input.KeyboardNavigation.DirectionalNavigationProperty, global::Infragistics.Windows.Utilities.CreateBindingObject(global::Infragistics.Windows.Controls.XamTabControl.TabDirectionalNavigationProperty, global::System.Windows.Data.BindingMode.OneWay, relativeSource));
			global::System.Windows.Controls.ItemsPanelTemplate itemsPanelTemplate = new global::System.Windows.Controls.ItemsPanelTemplate(frameworkElementFactory);
			itemsPanelTemplate.Seal();
			global::System.Windows.Controls.ItemsControl.ItemsPanelProperty.OverrideMetadata(typeof(global::Infragistics.Windows.Controls.XamTabControl), new global::System.Windows.FrameworkPropertyMetadata(itemsPanelTemplate));
			global::System.Windows.EventManager.RegisterClassHandler(typeof(global::System.Windows.Controls.Primitives.Popup), global::System.Windows.Input.Mouse.PreviewMouseUpEvent, new global::System.Windows.Input.MouseButtonEventHandler(global::Infragistics.Windows.Controls.XamTabControl.OnPopupPreviewMouseUp_ClassHandler));
		}

		// Token: 0x06001C76 RID: 7286 RVA: 0x0006D838 File Offset: 0x0006BA38
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
			global::Infragistics.Themes.ThemeManager.RegisterControl(typeof(global::Infragistics.Windows.Controls.XamTabControl));
		}

		// Token: 0x06001C77 RID: 7287 RVA: 0x0006D8B4 File Offset: 0x0006BAB4
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

		// Token: 0x06001C78 RID: 7288 RVA: 0x0006DA35 File Offset: 0x0006BC35
		protected override global::System.Windows.Automation.Peers.AutomationPeer OnCreateAutomationPeer()
		{
			return new global::Infragistics.Windows.Automation.Peers.XamTabControlAutomationPeer(this);
		}

		// Token: 0x06001C79 RID: 7289 RVA: 0x0006DA3D File Offset: 0x0006BC3D
		protected override void OnInitialized(global::System.EventArgs e)
		{
			if (base.ItemContainerGenerator != null)
			{
				base.ItemContainerGenerator.StatusChanged += this.OnGeneratorStatusChanged;
			}
			base.OnInitialized(e);
		}

		// Token: 0x06001C7A RID: 7290 RVA: 0x0006DA65 File Offset: 0x0006BC65
		protected override void OnKeyDown(global::System.Windows.Input.KeyEventArgs e)
		{
			base.OnKeyDown(e);
			if (!e.Handled && global::Infragistics.Windows.Controls.TabControlCommands.Instance.ProcessKeyboardInput(e, this))
			{
				e.Handled = true;
			}
		}

		// Token: 0x06001C7B RID: 7291 RVA: 0x0006DA8B File Offset: 0x0006BC8B
		protected override void OnMouseDoubleClick(global::System.Windows.Input.MouseButtonEventArgs e)
		{
			base.OnMouseDoubleClick(e);
		}

		// Token: 0x06001C7C RID: 7292 RVA: 0x0006DA94 File Offset: 0x0006BC94
		protected override global::System.Windows.DependencyObject GetContainerForItemOverride()
		{
			return new global::Infragistics.Windows.Controls.TabItemEx();
		}

		// Token: 0x06001C7D RID: 7293 RVA: 0x0006DA9C File Offset: 0x0006BC9C
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

		// Token: 0x06001C7E RID: 7294 RVA: 0x0006DB40 File Offset: 0x0006BD40
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
					if (tabItem.Focusable)
					{
						if (!tabItem.Focus())
						{
							flag = false;
						}
						if (tabItem.IsKeyboardFocused && !tabItem.IsSelected && this.IsMinimized)
						{
							global::Infragistics.DependencyPropertyUtilities.SetCurrentValue(tabItem, global::System.Windows.Controls.TabItem.IsSelectedProperty, global::Infragistics.KnownBoxes.TrueBox);
						}
					}
					else
					{
						global::Infragistics.DependencyPropertyUtilities.SetCurrentValue(tabItem, global::System.Windows.Controls.TabItem.IsSelectedProperty, global::Infragistics.KnownBoxes.TrueBox);
					}
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

		// Token: 0x06001C7F RID: 7295 RVA: 0x0006DD25 File Offset: 0x0006BF25
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

		// Token: 0x06001C80 RID: 7296 RVA: 0x0006DD48 File Offset: 0x0006BF48
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

		// Token: 0x06001C81 RID: 7297 RVA: 0x0006DD9C File Offset: 0x0006BF9C
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
					global::System.Windows.DependencyObject focusScope = global::System.Windows.Input.FocusManager.GetFocusScope(this);
					global::System.Windows.Controls.TabItem tabItem = global::System.Windows.Input.FocusManager.GetFocusedElement(focusScope) as global::System.Windows.Controls.TabItem;
					if (tabItem != null && tabItem != selectedTabItem && global::System.Windows.Controls.ItemsControl.ItemsControlFromItemContainer(tabItem) == this)
					{
						if (!base.IsKeyboardFocusWithin)
						{
							global::Infragistics.Windows.Utilities.SetFocusedElement(focusScope, selectedTabItem);
						}
						else if (selectedTabItem.Focusable)
						{
							selectedTabItem.Focus();
						}
						else
						{
							base.Focus();
						}
					}
					selectedTabItem.BringIntoView();
				}
			}
			base.OnSelectionChanged(e);
			this.RefreshSelectedTabPeerChildren();
		}

		// Token: 0x06001C82 RID: 7298 RVA: 0x0006DE90 File Offset: 0x0006C090
		private static void OnAllowNullSelectedItemChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.Controls.XamTabControl xamTabControl = d as global::Infragistics.Windows.Controls.XamTabControl;
			if (false.Equals(e.NewValue))
			{
				xamTabControl.ResetSelectedItem();
			}
		}

		// Token: 0x170006B4 RID: 1716
		// (get) Token: 0x06001C83 RID: 7299 RVA: 0x0006DEBC File Offset: 0x0006C0BC
		// (set) Token: 0x06001C84 RID: 7300 RVA: 0x0006DECE File Offset: 0x0006C0CE
		internal bool AllowNullSelectedItem
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.Windows.Controls.XamTabControl.AllowNullSelectedItemProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.Controls.XamTabControl.AllowNullSelectedItemProperty, value);
			}
		}

		// Token: 0x170006B5 RID: 1717
		// (get) Token: 0x06001C85 RID: 7301 RVA: 0x0006DEE1 File Offset: 0x0006C0E1
		internal bool HasVerticalTabs
		{
			get
			{
				return base.TabStripPlacement == global::System.Windows.Controls.Dock.Left || base.TabStripPlacement == global::System.Windows.Controls.Dock.Right;
			}
		}

		// Token: 0x06001C86 RID: 7302 RVA: 0x0006DEF8 File Offset: 0x0006C0F8
		private static void OnIsMultiRowChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.Controls.XamTabControl xamTabControl = d as global::Infragistics.Windows.Controls.XamTabControl;
			if (xamTabControl != null)
			{
				xamTabControl.VerifyScrollBarVisibility();
			}
		}

		// Token: 0x170006B6 RID: 1718
		// (get) Token: 0x06001C87 RID: 7303 RVA: 0x0006DF15 File Offset: 0x0006C115
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.ReadOnly(true)]
		public bool IsMultiRow
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.Windows.Controls.XamTabControl.IsMultiRowProperty);
			}
		}

		// Token: 0x170006B7 RID: 1719
		// (get) Token: 0x06001C88 RID: 7304 RVA: 0x0006DF27 File Offset: 0x0006C127
		internal global::System.Windows.FrameworkElement HeaderArea
		{
			get
			{
				return base.GetTemplateChild("PART_HeaderArea") as global::System.Windows.FrameworkElement;
			}
		}

		// Token: 0x170006B8 RID: 1720
		// (get) Token: 0x06001C89 RID: 7305 RVA: 0x0006DF39 File Offset: 0x0006C139
		internal int InternalVersion
		{
			get
			{
				return (int)base.GetValue(global::Infragistics.Windows.Controls.XamTabControl.InternalVersionProperty);
			}
		}

		// Token: 0x170006B9 RID: 1721
		// (get) Token: 0x06001C8A RID: 7306 RVA: 0x0006DF4B File Offset: 0x0006C14B
		internal global::System.Windows.Controls.ContentPresenter MinimizedContentPresenter
		{
			get
			{
				return this._cpMinimized;
			}
		}

		// Token: 0x170006BA RID: 1722
		// (get) Token: 0x06001C8B RID: 7307 RVA: 0x0006DF53 File Offset: 0x0006C153
		// (set) Token: 0x06001C8C RID: 7308 RVA: 0x0006DF5B File Offset: 0x0006C15B
		internal object PreviouslySelectedItem
		{
			get
			{
				return this._previouslySelectedItem;
			}
			set
			{
				this._previouslySelectedItem = value;
			}
		}

		// Token: 0x170006BB RID: 1723
		// (get) Token: 0x06001C8D RID: 7309 RVA: 0x0006DF64 File Offset: 0x0006C164
		// (set) Token: 0x06001C8E RID: 7310 RVA: 0x0006DF76 File Offset: 0x0006C176
		internal global::System.Windows.Input.KeyboardNavigationMode TabDirectionalNavigation
		{
			get
			{
				return (global::System.Windows.Input.KeyboardNavigationMode)base.GetValue(global::Infragistics.Windows.Controls.XamTabControl.TabDirectionalNavigationProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.Controls.XamTabControl.TabDirectionalNavigationProperty, value);
			}
		}

		// Token: 0x06001C8F RID: 7311 RVA: 0x0006DF8C File Offset: 0x0006C18C
		private static void OnAllowMinimizeChanged(global::System.Windows.DependencyObject target, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.Controls.XamTabControl xamTabControl = target as global::Infragistics.Windows.Controls.XamTabControl;
			if (xamTabControl != null)
			{
				xamTabControl.RaiseAutomationExpandCollapseStateChanged();
			}
		}

		// Token: 0x170006BC RID: 1724
		// (get) Token: 0x06001C90 RID: 7312 RVA: 0x0006DFA9 File Offset: 0x0006C1A9
		// (set) Token: 0x06001C91 RID: 7313 RVA: 0x0006DFBB File Offset: 0x0006C1BB
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

		// Token: 0x06001C92 RID: 7314 RVA: 0x0006DFD0 File Offset: 0x0006C1D0
		private static void OnAllowTabClosingChanged(global::System.Windows.DependencyObject target, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.Controls.XamTabControl xamTabControl = target as global::Infragistics.Windows.Controls.XamTabControl;
			if (xamTabControl != null)
			{
				xamTabControl.BumpInternalVersion();
			}
		}

		// Token: 0x170006BD RID: 1725
		// (get) Token: 0x06001C93 RID: 7315 RVA: 0x0006DFED File Offset: 0x0006C1ED
		// (set) Token: 0x06001C94 RID: 7316 RVA: 0x0006DFFF File Offset: 0x0006C1FF
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

		// Token: 0x170006BE RID: 1726
		// (get) Token: 0x06001C95 RID: 7317 RVA: 0x0006E012 File Offset: 0x0006C212
		// (set) Token: 0x06001C96 RID: 7318 RVA: 0x0006E024 File Offset: 0x0006C224
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

		// Token: 0x170006BF RID: 1727
		// (get) Token: 0x06001C97 RID: 7319 RVA: 0x0006E037 File Offset: 0x0006C237
		// (set) Token: 0x06001C98 RID: 7320 RVA: 0x0006E049 File Offset: 0x0006C249
		public global::Infragistics.Windows.Controls.TabAreaDropDownPlacement DropDownPlacement
		{
			get
			{
				return (global::Infragistics.Windows.Controls.TabAreaDropDownPlacement)base.GetValue(global::Infragistics.Windows.Controls.XamTabControl.DropDownPlacementProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.Controls.XamTabControl.DropDownPlacementProperty, value);
			}
		}

		// Token: 0x170006C0 RID: 1728
		// (get) Token: 0x06001C99 RID: 7321 RVA: 0x0006E05C File Offset: 0x0006C25C
		// (set) Token: 0x06001C9A RID: 7322 RVA: 0x0006E06F File Offset: 0x0006C26F
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

		// Token: 0x170006C1 RID: 1729
		// (get) Token: 0x06001C9B RID: 7323 RVA: 0x0006E082 File Offset: 0x0006C282
		// (set) Token: 0x06001C9C RID: 7324 RVA: 0x0006E095 File Offset: 0x0006C295
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

		// Token: 0x06001C9D RID: 7325 RVA: 0x0006E0A8 File Offset: 0x0006C2A8
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

		// Token: 0x06001C9E RID: 7326 RVA: 0x0006E128 File Offset: 0x0006C328
		private static object CoerceIsDropDownOpen(global::System.Windows.DependencyObject d, object value)
		{
			global::Infragistics.Windows.Controls.XamTabControl xamTabControl = d as global::Infragistics.Windows.Controls.XamTabControl;
			if (xamTabControl != null && global::Infragistics.KnownBoxes.TrueBox.Equals(value) && !xamTabControl.IsMinimized)
			{
				return global::Infragistics.KnownBoxes.FalseBox;
			}
			if (global::System.ComponentModel.DesignerProperties.GetIsInDesignMode(xamTabControl))
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

		// Token: 0x170006C2 RID: 1730
		// (get) Token: 0x06001C9F RID: 7327 RVA: 0x0006E17E File Offset: 0x0006C37E
		// (set) Token: 0x06001CA0 RID: 7328 RVA: 0x0006E190 File Offset: 0x0006C390
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

		// Token: 0x170006C3 RID: 1731
		// (get) Token: 0x06001CA1 RID: 7329 RVA: 0x0006E1A3 File Offset: 0x0006C3A3
		// (set) Token: 0x06001CA2 RID: 7330 RVA: 0x0006E1B5 File Offset: 0x0006C3B5
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

		// Token: 0x06001CA3 RID: 7331 RVA: 0x0006E1C8 File Offset: 0x0006C3C8
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

		// Token: 0x170006C4 RID: 1732
		// (get) Token: 0x06001CA4 RID: 7332 RVA: 0x0006E210 File Offset: 0x0006C410
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.ReadOnly(true)]
		public bool IsTabItemPanelScrolling
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.Windows.Controls.XamTabControl.IsTabItemPanelScrollingProperty);
			}
		}

		// Token: 0x06001CA5 RID: 7333 RVA: 0x0006E222 File Offset: 0x0006C422
		private static bool OnValidateAtLeastZero(object newValue)
		{
			return newValue is double && (double)newValue >= 0.0;
		}

		// Token: 0x170006C5 RID: 1733
		// (get) Token: 0x06001CA6 RID: 7334 RVA: 0x0006E242 File Offset: 0x0006C442
		// (set) Token: 0x06001CA7 RID: 7335 RVA: 0x0006E254 File Offset: 0x0006C454
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

		// Token: 0x06001CA8 RID: 7336 RVA: 0x0006E267 File Offset: 0x0006C467
		private static bool ValidateMaximumTabRows(object value)
		{
			return value is int && (int)value >= 1;
		}

		// Token: 0x170006C6 RID: 1734
		// (get) Token: 0x06001CA9 RID: 7337 RVA: 0x0006E27D File Offset: 0x0006C47D
		// (set) Token: 0x06001CAA RID: 7338 RVA: 0x0006E28F File Offset: 0x0006C48F
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

		// Token: 0x170006C7 RID: 1735
		// (get) Token: 0x06001CAB RID: 7339 RVA: 0x0006E2A2 File Offset: 0x0006C4A2
		// (set) Token: 0x06001CAC RID: 7340 RVA: 0x0006E2B4 File Offset: 0x0006C4B4
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

		// Token: 0x170006C8 RID: 1736
		// (get) Token: 0x06001CAD RID: 7341 RVA: 0x0006E2C7 File Offset: 0x0006C4C7
		// (set) Token: 0x06001CAE RID: 7342 RVA: 0x0006E2D4 File Offset: 0x0006C4D4
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

		// Token: 0x170006C9 RID: 1737
		// (get) Token: 0x06001CAF RID: 7343 RVA: 0x0006E2E2 File Offset: 0x0006C4E2
		// (set) Token: 0x06001CB0 RID: 7344 RVA: 0x0006E2F4 File Offset: 0x0006C4F4
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

		// Token: 0x170006CA RID: 1738
		// (get) Token: 0x06001CB1 RID: 7345 RVA: 0x0006E302 File Offset: 0x0006C502
		// (set) Token: 0x06001CB2 RID: 7346 RVA: 0x0006E314 File Offset: 0x0006C514
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

		// Token: 0x170006CB RID: 1739
		// (get) Token: 0x06001CB3 RID: 7347 RVA: 0x0006E322 File Offset: 0x0006C522
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.Browsable(false)]
		public double PreferredDropDownExtent
		{
			get
			{
				return (double)base.GetValue(global::Infragistics.Windows.Controls.XamTabControl.PreferredDropDownExtentProperty);
			}
		}

		// Token: 0x170006CC RID: 1740
		// (get) Token: 0x06001CB4 RID: 7348 RVA: 0x0006E334 File Offset: 0x0006C534
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.Browsable(false)]
		public global::System.Windows.Controls.Primitives.CustomPopupPlacementCallback PreferredDropDownPlacementCallback
		{
			get
			{
				return (global::System.Windows.Controls.Primitives.CustomPopupPlacementCallback)base.GetValue(global::Infragistics.Windows.Controls.XamTabControl.PreferredDropDownPlacementCallbackProperty);
			}
		}

		// Token: 0x170006CD RID: 1741
		// (get) Token: 0x06001CB5 RID: 7349 RVA: 0x0006E346 File Offset: 0x0006C546
		// (set) Token: 0x06001CB6 RID: 7350 RVA: 0x0006E353 File Offset: 0x0006C553
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

		// Token: 0x170006CE RID: 1742
		// (get) Token: 0x06001CB7 RID: 7351 RVA: 0x0006E361 File Offset: 0x0006C561
		// (set) Token: 0x06001CB8 RID: 7352 RVA: 0x0006E373 File Offset: 0x0006C573
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

		// Token: 0x170006CF RID: 1743
		// (get) Token: 0x06001CB9 RID: 7353 RVA: 0x0006E381 File Offset: 0x0006C581
		// (set) Token: 0x06001CBA RID: 7354 RVA: 0x0006E393 File Offset: 0x0006C593
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

		// Token: 0x06001CBB RID: 7355 RVA: 0x0006E3A4 File Offset: 0x0006C5A4
		private static void OnShowTabHeaderCloseButtonChanged(global::System.Windows.DependencyObject target, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.Controls.XamTabControl xamTabControl = target as global::Infragistics.Windows.Controls.XamTabControl;
			if (xamTabControl != null)
			{
				xamTabControl.BumpInternalVersion();
				global::System.Windows.Input.CommandManager.InvalidateRequerySuggested();
			}
		}

		// Token: 0x170006D0 RID: 1744
		// (get) Token: 0x06001CBC RID: 7356 RVA: 0x0006E3C6 File Offset: 0x0006C5C6
		// (set) Token: 0x06001CBD RID: 7357 RVA: 0x0006E3D8 File Offset: 0x0006C5D8
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

		// Token: 0x170006D1 RID: 1745
		// (get) Token: 0x06001CBE RID: 7358 RVA: 0x0006E3EB File Offset: 0x0006C5EB
		// (set) Token: 0x06001CBF RID: 7359 RVA: 0x0006E3FD File Offset: 0x0006C5FD
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

		// Token: 0x06001CC0 RID: 7360 RVA: 0x0006E410 File Offset: 0x0006C610
		private static void OnTabItemCloseButtonVisibilityChanged(global::System.Windows.DependencyObject target, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.Controls.XamTabControl xamTabControl = target as global::Infragistics.Windows.Controls.XamTabControl;
			if (xamTabControl != null)
			{
				xamTabControl.BumpInternalVersion();
			}
		}

		// Token: 0x170006D2 RID: 1746
		// (get) Token: 0x06001CC1 RID: 7361 RVA: 0x0006E42D File Offset: 0x0006C62D
		// (set) Token: 0x06001CC2 RID: 7362 RVA: 0x0006E43F File Offset: 0x0006C63F
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

		// Token: 0x170006D3 RID: 1747
		// (get) Token: 0x06001CC3 RID: 7363 RVA: 0x0006E452 File Offset: 0x0006C652
		// (set) Token: 0x06001CC4 RID: 7364 RVA: 0x0006E464 File Offset: 0x0006C664
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

		// Token: 0x170006D4 RID: 1748
		// (get) Token: 0x06001CC5 RID: 7365 RVA: 0x0006E477 File Offset: 0x0006C677
		[global::System.ComponentModel.ReadOnly(true)]
		public global::System.Windows.Controls.ScrollBarVisibility TabItemHorizontalScrollBarVisibility
		{
			get
			{
				return (global::System.Windows.Controls.ScrollBarVisibility)base.GetValue(global::Infragistics.Windows.Controls.XamTabControl.TabItemHorizontalScrollBarVisibilityProperty);
			}
		}

		// Token: 0x170006D5 RID: 1749
		// (get) Token: 0x06001CC6 RID: 7366 RVA: 0x0006E489 File Offset: 0x0006C689
		[global::System.ComponentModel.ReadOnly(true)]
		public global::System.Windows.Controls.ScrollBarVisibility TabItemVerticalScrollBarVisibility
		{
			get
			{
				return (global::System.Windows.Controls.ScrollBarVisibility)base.GetValue(global::Infragistics.Windows.Controls.XamTabControl.TabItemVerticalScrollBarVisibilityProperty);
			}
		}

		// Token: 0x06001CC7 RID: 7367 RVA: 0x0006E49C File Offset: 0x0006C69C
		private static void OnTabLayoutStyleChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.Controls.XamTabControl xamTabControl = d as global::Infragistics.Windows.Controls.XamTabControl;
			if (xamTabControl != null)
			{
				xamTabControl.SetValue(global::Infragistics.Windows.Controls.XamTabControl.IsMultiRowPropertyKey, global::Infragistics.Windows.Controls.TabItemPanel.IsMultiRowStyle(xamTabControl.TabLayoutStyle));
			}
		}

		// Token: 0x170006D6 RID: 1750
		// (get) Token: 0x06001CC8 RID: 7368 RVA: 0x0006E4CE File Offset: 0x0006C6CE
		// (set) Token: 0x06001CC9 RID: 7369 RVA: 0x0006E4E0 File Offset: 0x0006C6E0
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

		// Token: 0x06001CCA RID: 7370 RVA: 0x0006E4F3 File Offset: 0x0006C6F3
		[global::System.Windows.AttachedPropertyBrowsableForChildren]
		public static int GetTabPriority(global::System.Windows.DependencyObject d)
		{
			return (int)d.GetValue(global::Infragistics.Windows.Controls.XamTabControl.TabPriorityProperty);
		}

		// Token: 0x06001CCB RID: 7371 RVA: 0x0006E505 File Offset: 0x0006C705
		public static void SetTabPriority(global::System.Windows.DependencyObject d, int value)
		{
			d.SetValue(global::Infragistics.Windows.Controls.XamTabControl.TabPriorityProperty, value);
		}

		// Token: 0x06001CCC RID: 7372 RVA: 0x0006E518 File Offset: 0x0006C718
		private static void OnThemeChanged(global::System.Windows.DependencyObject target, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.Controls.XamTabControl xamTabControl = target as global::Infragistics.Windows.Controls.XamTabControl;
			xamTabControl.UpdateThemeResources();
			xamTabControl.OnThemeChanged((string)e.OldValue, (string)e.NewValue);
		}

		// Token: 0x170006D7 RID: 1751
		// (get) Token: 0x06001CCD RID: 7373 RVA: 0x0006E550 File Offset: 0x0006C750
		// (set) Token: 0x06001CCE RID: 7374 RVA: 0x0006E562 File Offset: 0x0006C762
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.DefaultValue(null)]
		[global::System.ComponentModel.TypeConverter(typeof(global::Infragistics.Windows.Themes.Internal.PrimitivesThemeTypeConverter))]
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

		// Token: 0x06001CCF RID: 7375 RVA: 0x0006E570 File Offset: 0x0006C770
		protected virtual void OnThemeChanged(string previousValue, string currentValue)
		{
			base.RaiseEvent(new global::System.Windows.RoutedPropertyChangedEventArgs<string>(previousValue, currentValue)
			{
				RoutedEvent = global::Infragistics.Windows.Controls.XamTabControl.ThemeChangedEvent,
				Source = this
			});
		}

		// Token: 0x1400003F RID: 63
		// (add) Token: 0x06001CD0 RID: 7376 RVA: 0x0006E59E File Offset: 0x0006C79E
		// (remove) Token: 0x06001CD1 RID: 7377 RVA: 0x0006E5AC File Offset: 0x0006C7AC
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

		// Token: 0x06001CD2 RID: 7378 RVA: 0x0006E5BA File Offset: 0x0006C7BA
		public bool ExecuteCommand(global::System.Windows.Input.RoutedCommand command)
		{
			return this.ExecuteCommandImpl(new global::Infragistics.Windows.Commands.ExecuteCommandInfo(command));
		}

		// Token: 0x06001CD3 RID: 7379 RVA: 0x0006E5C8 File Offset: 0x0006C7C8
		private void BumpInternalVersion()
		{
			base.SetValue(global::Infragistics.Windows.Controls.XamTabControl.InternalVersionPropertyKey, this.InternalVersion + 1);
		}

		// Token: 0x06001CD4 RID: 7380 RVA: 0x0006E5E2 File Offset: 0x0006C7E2
		internal bool CloseTab(global::Infragistics.Windows.Controls.TabItemEx tab)
		{
			if (!tab.Close())
			{
				return false;
			}
			this.EnsureSelectedTabIsVisible();
			return true;
		}

		// Token: 0x06001CD5 RID: 7381 RVA: 0x0006E5F8 File Offset: 0x0006C7F8
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

		// Token: 0x06001CD6 RID: 7382 RVA: 0x0006E64C File Offset: 0x0006C84C
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

		// Token: 0x06001CD7 RID: 7383 RVA: 0x0006E6BC File Offset: 0x0006C8BC
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

		// Token: 0x06001CD8 RID: 7384 RVA: 0x0006E94C File Offset: 0x0006CB4C
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

		// Token: 0x06001CD9 RID: 7385 RVA: 0x0006E98C File Offset: 0x0006CB8C
		private global::System.Windows.Controls.TabItem GetFirstTabItemToSelect()
		{
			global::System.Windows.Controls.TabItem firstTabItem = this.GetFirstTabItem(true, true);
			if (firstTabItem != null)
			{
				return firstTabItem;
			}
			return this.GetFirstTabItem(false, true);
		}

		// Token: 0x06001CDA RID: 7386 RVA: 0x0006E9B0 File Offset: 0x0006CBB0
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

		// Token: 0x06001CDB RID: 7387 RVA: 0x0006E9F0 File Offset: 0x0006CBF0
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

		// Token: 0x06001CDC RID: 7388 RVA: 0x0006EA3C File Offset: 0x0006CC3C
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

		// Token: 0x06001CDD RID: 7389 RVA: 0x0006EA8C File Offset: 0x0006CC8C
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

		// Token: 0x06001CDE RID: 7390 RVA: 0x0006EAD8 File Offset: 0x0006CCD8
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

		// Token: 0x06001CDF RID: 7391 RVA: 0x0006EC00 File Offset: 0x0006CE00
		private global::System.Windows.Controls.TabItem GetSelectedTabItem()
		{
			int selectedIndex = base.SelectedIndex;
			if (selectedIndex >= 0)
			{
				return base.ItemContainerGenerator.ContainerFromIndex(selectedIndex) as global::System.Windows.Controls.TabItem;
			}
			return null;
		}

		// Token: 0x06001CE0 RID: 7392 RVA: 0x0006EC2C File Offset: 0x0006CE2C
		private global::System.Windows.Controls.TabItem GetTabItemAtIndex(int index, bool nullIfDisabled, bool nullIfCollapsed)
		{
			global::System.Windows.Controls.TabItem tabItem = base.ItemContainerGenerator.ContainerFromIndex(index) as global::System.Windows.Controls.TabItem;
			if (tabItem != null && (!nullIfCollapsed || tabItem.Visibility != global::System.Windows.Visibility.Collapsed) && (!nullIfDisabled || tabItem.IsEnabled))
			{
				return tabItem;
			}
			return null;
		}

		// Token: 0x06001CE1 RID: 7393 RVA: 0x0006EC68 File Offset: 0x0006CE68
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
			bool flag2 = this.DropDownPlacement == global::Infragistics.Windows.Controls.TabAreaDropDownPlacement.AllowMonitorSpanning;
			if (flag2 && this._popup.Tag == null)
			{
				global::Infragistics.Windows.Controls.PopupController popupController = global::Infragistics.Windows.Controls.PopupController.Create(this._popup, this);
				if (popupController != null)
				{
					this._popup.Tag = popupController;
					popupController.BindPopupRootExtents = true;
					this._popup.Placement = global::System.Windows.Controls.Primitives.PlacementMode.Absolute;
				}
				else
				{
					flag2 = false;
				}
			}
			else if (!flag2 && this._popup.Tag is global::Infragistics.Windows.Controls.PopupController)
			{
				global::Infragistics.Windows.Controls.PopupController popupController2 = this._popup.Tag as global::Infragistics.Windows.Controls.PopupController;
				this._popup.ClearValue(global::System.Windows.FrameworkElement.TagProperty);
				this._popup.ClearValue(global::System.Windows.Controls.Primitives.Popup.PlacementProperty);
				this._popup.ClearValue(global::System.Windows.Controls.Primitives.Popup.HorizontalOffsetProperty);
				this._popup.ClearValue(global::System.Windows.Controls.Primitives.Popup.VerticalOffsetProperty);
				popupController2.Deactivate();
			}
			if (flag2)
			{
				rect2 = rect;
			}
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
			if (flag2)
			{
				global::System.Windows.Rect rect4 = frameworkElement.TransformToVisual(this).TransformBounds(rect3);
				global::System.Windows.Point point6 = global::Infragistics.Windows.Utilities.PointToScreenSafe(this, (base.FlowDirection == global::System.Windows.FlowDirection.LeftToRight) ? rect4.BottomLeft : rect4.BottomRight);
				point6.X = global::Infragistics.Windows.Utilities.ConvertToLogicalPixels((int)point6.X, this);
				point6.Y = global::Infragistics.Windows.Utilities.ConvertToLogicalPixels((int)point6.Y, this);
				this._popup.HorizontalOffset = point6.X;
				this._popup.VerticalOffset = point6.Y;
			}
		}

		// Token: 0x06001CE2 RID: 7394 RVA: 0x0006F075 File Offset: 0x0006D275
		private void OnAfterContainersGenerated(object context)
		{
			this._suppressSelectionChangeCount--;
		}

		// Token: 0x06001CE3 RID: 7395 RVA: 0x0006F088 File Offset: 0x0006D288
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

		// Token: 0x06001CE4 RID: 7396 RVA: 0x0006F0E0 File Offset: 0x0006D2E0
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

		// Token: 0x06001CE5 RID: 7397 RVA: 0x0006F158 File Offset: 0x0006D358
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

		// Token: 0x06001CE6 RID: 7398 RVA: 0x0006F1B0 File Offset: 0x0006D3B0
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

		// Token: 0x06001CE7 RID: 7399 RVA: 0x0006F230 File Offset: 0x0006D430
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

		// Token: 0x06001CE8 RID: 7400 RVA: 0x0006F2D0 File Offset: 0x0006D4D0
		private static void OnTabStripPlacementChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.Controls.XamTabControl xamTabControl = d as global::Infragistics.Windows.Controls.XamTabControl;
			if (xamTabControl != null)
			{
				xamTabControl.VerifyScrollBarVisibility();
			}
		}

		// Token: 0x06001CE9 RID: 7401 RVA: 0x0006F2F0 File Offset: 0x0006D4F0
		private void RaiseAutomationExpandCollapseStateChanged()
		{
			global::Infragistics.Windows.Automation.Peers.XamTabControlAutomationPeer xamTabControlAutomationPeer = global::System.Windows.Automation.Peers.UIElementAutomationPeer.FromElement(this) as global::Infragistics.Windows.Automation.Peers.XamTabControlAutomationPeer;
			if (xamTabControlAutomationPeer != null)
			{
				xamTabControlAutomationPeer.RaiseExpandCollapseStateChanged();
			}
		}

		// Token: 0x06001CEA RID: 7402 RVA: 0x0006F312 File Offset: 0x0006D512
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

		// Token: 0x06001CEB RID: 7403 RVA: 0x0006F348 File Offset: 0x0006D548
		private void ResetSelectedItem()
		{
			if (this.IsMinimized && !this.IsDropDownOpen && base.SelectedItem != null)
			{
				this._previouslySelectedItem = base.SelectedItem;
				global::System.Windows.Controls.TabItem tabItem = base.ItemContainerGenerator.ContainerFromItem(this._previouslySelectedItem) as global::System.Windows.Controls.TabItem;
				base.SetValue(global::System.Windows.Controls.Primitives.Selector.SelectedItemProperty, null);
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
				if (this.AllowNullSelectedItem)
				{
					return;
				}
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

		// Token: 0x06001CEC RID: 7404 RVA: 0x0006F44C File Offset: 0x0006D64C
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

		// Token: 0x06001CED RID: 7405 RVA: 0x0006F490 File Offset: 0x0006D690
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

		// Token: 0x06001CEE RID: 7406 RVA: 0x0006F4E0 File Offset: 0x0006D6E0
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

		// Token: 0x06001CEF RID: 7407 RVA: 0x0006F53C File Offset: 0x0006D73C
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

		// Token: 0x06001CF0 RID: 7408 RVA: 0x0006F586 File Offset: 0x0006D786
		protected virtual void OnDropDownClosed(global::System.Windows.RoutedEventArgs args)
		{
			base.RaiseEvent(args);
		}

		// Token: 0x06001CF1 RID: 7409 RVA: 0x0006F58F File Offset: 0x0006D78F
		internal void RaiseDropDownClosed(global::System.Windows.RoutedEventArgs args)
		{
			args.RoutedEvent = global::Infragistics.Windows.Controls.XamTabControl.DropDownClosedEvent;
			args.Source = this;
			this.OnDropDownClosed(args);
		}

		// Token: 0x14000040 RID: 64
		// (add) Token: 0x06001CF2 RID: 7410 RVA: 0x0006F5AA File Offset: 0x0006D7AA
		// (remove) Token: 0x06001CF3 RID: 7411 RVA: 0x0006F5B8 File Offset: 0x0006D7B8
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

		// Token: 0x06001CF4 RID: 7412 RVA: 0x0006F5C6 File Offset: 0x0006D7C6
		protected virtual void OnDropDownOpened(global::System.Windows.RoutedEventArgs args)
		{
			base.RaiseEvent(args);
		}

		// Token: 0x06001CF5 RID: 7413 RVA: 0x0006F5CF File Offset: 0x0006D7CF
		internal void RaiseDropDownOpened(global::System.Windows.RoutedEventArgs args)
		{
			args.RoutedEvent = global::Infragistics.Windows.Controls.XamTabControl.DropDownOpenedEvent;
			args.Source = this;
			this.OnDropDownOpened(args);
		}

		// Token: 0x14000041 RID: 65
		// (add) Token: 0x06001CF6 RID: 7414 RVA: 0x0006F5EA File Offset: 0x0006D7EA
		// (remove) Token: 0x06001CF7 RID: 7415 RVA: 0x0006F5F8 File Offset: 0x0006D7F8
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

		// Token: 0x06001CF8 RID: 7416 RVA: 0x0006F606 File Offset: 0x0006D806
		protected virtual void OnDropDownOpening(global::Infragistics.Windows.Controls.Events.TabControlDropDownOpeningEventArgs args)
		{
			base.RaiseEvent(args);
		}

		// Token: 0x06001CF9 RID: 7417 RVA: 0x0006F60F File Offset: 0x0006D80F
		private void RaiseDropDownOpening(global::Infragistics.Windows.Controls.Events.TabControlDropDownOpeningEventArgs args)
		{
			args.RoutedEvent = global::Infragistics.Windows.Controls.XamTabControl.DropDownOpeningEvent;
			args.Source = this;
			this.OnDropDownOpening(args);
		}

		// Token: 0x14000042 RID: 66
		// (add) Token: 0x06001CFA RID: 7418 RVA: 0x0006F62A File Offset: 0x0006D82A
		// (remove) Token: 0x06001CFB RID: 7419 RVA: 0x0006F638 File Offset: 0x0006D838
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

		// Token: 0x06001CFC RID: 7420 RVA: 0x0006F646 File Offset: 0x0006D846
		protected virtual void OnExecutingCommand(global::Infragistics.Windows.Controls.Events.ExecutingCommandEventArgs args)
		{
			base.RaiseEvent(args);
		}

		// Token: 0x06001CFD RID: 7421 RVA: 0x0006F64F File Offset: 0x0006D84F
		internal bool RaiseExecutingCommand(global::Infragistics.Windows.Controls.Events.ExecutingCommandEventArgs args)
		{
			args.RoutedEvent = global::Infragistics.Windows.Controls.XamTabControl.ExecutingCommandEvent;
			args.Source = this;
			this.OnExecutingCommand(args);
			return !args.Cancel;
		}

		// Token: 0x14000043 RID: 67
		// (add) Token: 0x06001CFE RID: 7422 RVA: 0x0006F673 File Offset: 0x0006D873
		// (remove) Token: 0x06001CFF RID: 7423 RVA: 0x0006F681 File Offset: 0x0006D881
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

		// Token: 0x06001D00 RID: 7424 RVA: 0x0006F68F File Offset: 0x0006D88F
		protected virtual void OnExecutedCommand(global::Infragistics.Windows.Controls.Events.ExecutedCommandEventArgs args)
		{
			base.RaiseEvent(args);
		}

		// Token: 0x06001D01 RID: 7425 RVA: 0x0006F698 File Offset: 0x0006D898
		internal void RaiseExecutedCommand(global::Infragistics.Windows.Controls.Events.ExecutedCommandEventArgs args)
		{
			args.RoutedEvent = global::Infragistics.Windows.Controls.XamTabControl.ExecutedCommandEvent;
			args.Source = this;
			this.OnExecutedCommand(args);
		}

		// Token: 0x14000044 RID: 68
		// (add) Token: 0x06001D02 RID: 7426 RVA: 0x0006F6B3 File Offset: 0x0006D8B3
		// (remove) Token: 0x06001D03 RID: 7427 RVA: 0x0006F6C1 File Offset: 0x0006D8C1
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

		// Token: 0x06001D04 RID: 7428 RVA: 0x0006F6D0 File Offset: 0x0006D8D0
		bool global::Infragistics.Windows.Commands.ICommandHost.Execute(global::Infragistics.Windows.Commands.ExecuteCommandInfo commandInfo)
		{
			global::System.Windows.Input.RoutedCommand routedCommand = commandInfo.RoutedCommand;
			return routedCommand != null && this.ExecuteCommandImpl(commandInfo);
		}

		// Token: 0x06001D05 RID: 7429 RVA: 0x0006F6F0 File Offset: 0x0006D8F0
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

		// Token: 0x06001D06 RID: 7430 RVA: 0x0006F774 File Offset: 0x0006D974
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

		// Token: 0x04000DD2 RID: 3538
		internal const double DefaultInterRowSpacing = 0.0;

		// Token: 0x04000DD3 RID: 3539
		internal const double DefaultInterTabSpacing = 0.0;

		// Token: 0x04000DD4 RID: 3540
		internal const double DefaultMaximumSizeToFit = 0.0;

		// Token: 0x04000DD5 RID: 3541
		internal const double DefaultMinimumTabExtent = 18.0;

		// Token: 0x04000DD6 RID: 3542
		private object _previouslySelectedItem;

		// Token: 0x04000DD7 RID: 3543
		private global::System.Windows.Controls.ScrollViewer _tabItemScrollViewer;

		// Token: 0x04000DD8 RID: 3544
		private global::System.Windows.Controls.Primitives.Popup _popup;

		// Token: 0x04000DD9 RID: 3545
		private int _lastSingleLeftMouseDownTime;

		// Token: 0x04000DDA RID: 3546
		private global::System.Windows.Point _lastSingleLeftMouseDownPoint;

		// Token: 0x04000DDB RID: 3547
		private global::Infragistics.Windows.Licensing.UltraLicense _license;

		// Token: 0x04000DDC RID: 3548
		private global::System.Windows.Controls.ContentPresenter _cpMaximized;

		// Token: 0x04000DDD RID: 3549
		private global::System.Windows.Controls.ContentPresenter _cpMinimized;

		// Token: 0x04000DDE RID: 3550
		private global::Infragistics.Windows.Controls.XamTabControl.PopupPlacementAdorner _popupPlacementAdorner;

		// Token: 0x04000DDF RID: 3551
		private static readonly object NotInitialized = new object();

		// Token: 0x04000DE0 RID: 3552
		private object _oldPlacementTarget = global::Infragistics.Windows.Controls.XamTabControl.NotInitialized;

		// Token: 0x04000DE1 RID: 3553
		private int _suppressSelectionChangeCount;

		// Token: 0x04000DE2 RID: 3554
		private bool _initializingSelection;

		// Token: 0x04000DE3 RID: 3555
		private bool _eatNextMouseLeftButtonUp;

		// Token: 0x04000DE4 RID: 3556
		private bool _isRefreshSelectedTabPeerPending;

		// Token: 0x04000DE5 RID: 3557
		internal static readonly global::System.Windows.DependencyProperty AllowNullSelectedItemProperty = global::System.Windows.DependencyProperty.Register("AllowNullSelectedItem", typeof(bool), typeof(global::Infragistics.Windows.Controls.XamTabControl), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.Controls.XamTabControl.OnAllowNullSelectedItemChanged)));

		// Token: 0x04000DE6 RID: 3558
		private static readonly global::System.Windows.DependencyPropertyKey IsMultiRowPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("IsMultiRow", typeof(bool), typeof(global::Infragistics.Windows.Controls.XamTabControl), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.Controls.XamTabControl.OnIsMultiRowChanged)));

		// Token: 0x04000DE7 RID: 3559
		public static readonly global::System.Windows.DependencyProperty IsMultiRowProperty = global::Infragistics.Windows.Controls.XamTabControl.IsMultiRowPropertyKey.DependencyProperty;

		// Token: 0x04000DE8 RID: 3560
		private static readonly global::System.Windows.DependencyProperty ComputedTabItemHorizontalScrollBarVisibilityProperty = global::System.Windows.DependencyProperty.Register("ComputedTabItemHorizontalScrollBarVisibility", typeof(global::System.Windows.Visibility), typeof(global::Infragistics.Windows.Controls.XamTabControl), new global::System.Windows.FrameworkPropertyMetadata(global::System.Windows.Visibility.Collapsed, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.Controls.XamTabControl.OnComputedScrollBarVisibilityChanged)));

		// Token: 0x04000DE9 RID: 3561
		private static readonly global::System.Windows.DependencyProperty ComputedTabItemVerticalScrollBarVisibilityProperty = global::System.Windows.DependencyProperty.Register("ComputedTabItemVerticalScrollBarVisibility", typeof(global::System.Windows.Visibility), typeof(global::Infragistics.Windows.Controls.XamTabControl), new global::System.Windows.FrameworkPropertyMetadata(global::System.Windows.Visibility.Collapsed, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.Controls.XamTabControl.OnComputedScrollBarVisibilityChanged)));

		// Token: 0x04000DEA RID: 3562
		private static readonly global::System.Windows.DependencyPropertyKey InternalVersionPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("InternalVersion", typeof(int), typeof(global::Infragistics.Windows.Controls.XamTabControl), new global::System.Windows.FrameworkPropertyMetadata(0));

		// Token: 0x04000DEB RID: 3563
		internal static readonly global::System.Windows.DependencyProperty InternalVersionProperty = global::Infragistics.Windows.Controls.XamTabControl.InternalVersionPropertyKey.DependencyProperty;

		// Token: 0x04000DEC RID: 3564
		internal static readonly global::System.Windows.DependencyProperty TabDirectionalNavigationProperty = global::System.Windows.DependencyProperty.Register("TabDirectionalNavigation", typeof(global::System.Windows.Input.KeyboardNavigationMode), typeof(global::Infragistics.Windows.Controls.XamTabControl), new global::System.Windows.FrameworkPropertyMetadata(global::System.Windows.Input.KeyboardNavigationMode.Cycle));

		// Token: 0x04000DED RID: 3565
		public static readonly global::System.Windows.DependencyProperty AllowMinimizeProperty = global::System.Windows.DependencyProperty.Register("AllowMinimize", typeof(bool), typeof(global::Infragistics.Windows.Controls.XamTabControl), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.Controls.XamTabControl.OnAllowMinimizeChanged)));

		// Token: 0x04000DEE RID: 3566
		public static readonly global::System.Windows.DependencyProperty AllowTabClosingProperty = global::System.Windows.DependencyProperty.Register("AllowTabClosing", typeof(bool?), typeof(global::Infragistics.Windows.Controls.XamTabControl), new global::System.Windows.FrameworkPropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.Controls.XamTabControl.OnAllowTabClosingChanged)));

		// Token: 0x04000DEF RID: 3567
		public static readonly global::System.Windows.DependencyProperty DropDownAnimationProperty = global::System.Windows.DependencyProperty.Register("DropDownAnimation", typeof(global::System.Windows.Controls.Primitives.PopupAnimation), typeof(global::Infragistics.Windows.Controls.XamTabControl), new global::System.Windows.FrameworkPropertyMetadata(global::System.Windows.Controls.Primitives.PopupAnimation.None));

		// Token: 0x04000DF0 RID: 3568
		public static readonly global::System.Windows.DependencyProperty DropDownPlacementProperty = global::System.Windows.DependencyProperty.Register("DropDownPlacement", typeof(global::Infragistics.Windows.Controls.TabAreaDropDownPlacement), typeof(global::Infragistics.Windows.Controls.XamTabControl), new global::System.Windows.PropertyMetadata(global::Infragistics.Windows.Controls.TabAreaDropDownPlacement.RestrictToSingleMonitor));

		// Token: 0x04000DF1 RID: 3569
		public static readonly global::System.Windows.DependencyProperty InterRowSpacingProperty = global::System.Windows.DependencyProperty.Register("InterRowSpacing", typeof(double), typeof(global::Infragistics.Windows.Controls.XamTabControl), new global::System.Windows.FrameworkPropertyMetadata(0.0));

		// Token: 0x04000DF2 RID: 3570
		public static readonly global::System.Windows.DependencyProperty InterTabSpacingProperty = global::System.Windows.DependencyProperty.Register("InterTabSpacing", typeof(double), typeof(global::Infragistics.Windows.Controls.XamTabControl), new global::System.Windows.FrameworkPropertyMetadata(0.0));

		// Token: 0x04000DF3 RID: 3571
		public static readonly global::System.Windows.DependencyProperty IsDropDownOpenProperty = global::System.Windows.DependencyProperty.Register("IsDropDownOpen", typeof(bool), typeof(global::Infragistics.Windows.Controls.XamTabControl), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox, global::System.Windows.FrameworkPropertyMetadataOptions.BindsTwoWayByDefault, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.Controls.XamTabControl.OnIsDropDownOpenChanged), new global::System.Windows.CoerceValueCallback(global::Infragistics.Windows.Controls.XamTabControl.CoerceIsDropDownOpen)));

		// Token: 0x04000DF4 RID: 3572
		public static readonly global::System.Windows.DependencyProperty IsMinimizedProperty = global::System.Windows.DependencyProperty.Register("IsMinimized", typeof(bool), typeof(global::Infragistics.Windows.Controls.XamTabControl), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.Controls.XamTabControl.OnIsMinimizedChanged)));

		// Token: 0x04000DF5 RID: 3573
		private static readonly global::System.Windows.DependencyPropertyKey IsTabItemPanelScrollingPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("IsTabItemPanelScrolling", typeof(bool), typeof(global::Infragistics.Windows.Controls.XamTabControl), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox));

		// Token: 0x04000DF6 RID: 3574
		public static readonly global::System.Windows.DependencyProperty IsTabItemPanelScrollingProperty = global::Infragistics.Windows.Controls.XamTabControl.IsTabItemPanelScrollingPropertyKey.DependencyProperty;

		// Token: 0x04000DF7 RID: 3575
		public static readonly global::System.Windows.DependencyProperty MaximumSizeToFitAdjustmentProperty = global::System.Windows.DependencyProperty.Register("MaximumSizeToFitAdjustment", typeof(double), typeof(global::Infragistics.Windows.Controls.XamTabControl), new global::System.Windows.FrameworkPropertyMetadata(0.0), new global::System.Windows.ValidateValueCallback(global::Infragistics.Windows.Controls.XamTabControl.OnValidateAtLeastZero));

		// Token: 0x04000DF8 RID: 3576
		public static readonly global::System.Windows.DependencyProperty MaximumTabRowsProperty = global::System.Windows.DependencyProperty.Register("MaximumTabRows", typeof(int), typeof(global::Infragistics.Windows.Controls.XamTabControl), new global::System.Windows.FrameworkPropertyMetadata(3), new global::System.Windows.ValidateValueCallback(global::Infragistics.Windows.Controls.XamTabControl.ValidateMaximumTabRows));

		// Token: 0x04000DF9 RID: 3577
		public static readonly global::System.Windows.DependencyProperty MinimumTabExtentProperty = global::System.Windows.DependencyProperty.Register("MinimumTabExtent", typeof(double), typeof(global::Infragistics.Windows.Controls.XamTabControl), new global::System.Windows.FrameworkPropertyMetadata(18.0), new global::System.Windows.ValidateValueCallback(global::Infragistics.Windows.Controls.XamTabControl.OnValidateAtLeastZero));

		// Token: 0x04000DFA RID: 3578
		public static readonly global::System.Windows.DependencyProperty PostTabItemContentProperty = global::System.Windows.DependencyProperty.Register("PostTabItemContent", typeof(object), typeof(global::Infragistics.Windows.Controls.XamTabControl), new global::System.Windows.FrameworkPropertyMetadata(null));

		// Token: 0x04000DFB RID: 3579
		public static readonly global::System.Windows.DependencyProperty PostTabItemContentTemplateProperty = global::System.Windows.DependencyProperty.Register("PostTabItemContentTemplate", typeof(global::System.Windows.DataTemplate), typeof(global::Infragistics.Windows.Controls.XamTabControl), new global::System.Windows.FrameworkPropertyMetadata(null));

		// Token: 0x04000DFC RID: 3580
		public static readonly global::System.Windows.DependencyProperty PostTabItemContentTemplateSelectorProperty = global::System.Windows.DependencyProperty.Register("PostTabItemContentTemplateSelector", typeof(global::System.Windows.Controls.DataTemplateSelector), typeof(global::Infragistics.Windows.Controls.XamTabControl), new global::System.Windows.FrameworkPropertyMetadata(null));

		// Token: 0x04000DFD RID: 3581
		private static readonly global::System.Windows.DependencyPropertyKey PreferredDropDownExtentPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("PreferredDropDownExtent", typeof(double), typeof(global::Infragistics.Windows.Controls.XamTabControl), new global::System.Windows.FrameworkPropertyMetadata(double.NaN));

		// Token: 0x04000DFE RID: 3582
		public static readonly global::System.Windows.DependencyProperty PreferredDropDownExtentProperty = global::Infragistics.Windows.Controls.XamTabControl.PreferredDropDownExtentPropertyKey.DependencyProperty;

		// Token: 0x04000DFF RID: 3583
		private static readonly global::System.Windows.DependencyPropertyKey PreferredDropDownPlacementCallbackPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("PreferredDropDownPlacementCallback", typeof(global::System.Windows.Controls.Primitives.CustomPopupPlacementCallback), typeof(global::Infragistics.Windows.Controls.XamTabControl), new global::System.Windows.FrameworkPropertyMetadata(null));

		// Token: 0x04000E00 RID: 3584
		public static readonly global::System.Windows.DependencyProperty PreferredDropDownPlacementCallbackProperty = global::Infragistics.Windows.Controls.XamTabControl.PreferredDropDownPlacementCallbackPropertyKey.DependencyProperty;

		// Token: 0x04000E01 RID: 3585
		public static readonly global::System.Windows.DependencyProperty PreTabItemContentProperty = global::System.Windows.DependencyProperty.Register("PreTabItemContent", typeof(object), typeof(global::Infragistics.Windows.Controls.XamTabControl), new global::System.Windows.FrameworkPropertyMetadata(null));

		// Token: 0x04000E02 RID: 3586
		public static readonly global::System.Windows.DependencyProperty PreTabItemContentTemplateProperty = global::System.Windows.DependencyProperty.Register("PreTabItemContentTemplate", typeof(global::System.Windows.DataTemplate), typeof(global::Infragistics.Windows.Controls.XamTabControl), new global::System.Windows.FrameworkPropertyMetadata(null));

		// Token: 0x04000E03 RID: 3587
		public static readonly global::System.Windows.DependencyProperty PreTabItemContentTemplateSelectorProperty = global::System.Windows.DependencyProperty.Register("PreTabItemContentTemplateSelector", typeof(global::System.Windows.Controls.DataTemplateSelector), typeof(global::Infragistics.Windows.Controls.XamTabControl), new global::System.Windows.FrameworkPropertyMetadata(null));

		// Token: 0x04000E04 RID: 3588
		public static readonly global::System.Windows.DependencyProperty ShowTabHeaderCloseButtonProperty = global::System.Windows.DependencyProperty.Register("ShowTabHeaderCloseButton", typeof(bool), typeof(global::Infragistics.Windows.Controls.XamTabControl), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.Controls.XamTabControl.OnShowTabHeaderCloseButtonChanged)));

		// Token: 0x04000E05 RID: 3589
		public static readonly global::System.Windows.DependencyProperty TabHeaderHeightProperty = global::Infragistics.DependencyPropertyUtilities.Register("TabHeaderHeight", typeof(double), typeof(global::Infragistics.Windows.Controls.XamTabControl), global::Infragistics.DependencyPropertyUtilities.CreateMetadata(0.0));

		// Token: 0x04000E06 RID: 3590
		public static readonly global::System.Windows.DependencyProperty TabItemCloseButtonVisibilityProperty = global::System.Windows.DependencyProperty.Register("TabItemCloseButtonVisibility", typeof(global::Infragistics.Windows.Controls.TabItemCloseButtonVisibility), typeof(global::Infragistics.Windows.Controls.XamTabControl), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.Windows.Controls.TabItemCloseButtonVisibility.Hidden, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.Controls.XamTabControl.OnTabItemCloseButtonVisibilityChanged)));

		// Token: 0x04000E07 RID: 3591
		public static readonly global::System.Windows.DependencyProperty TabItemContentHeightProperty = global::System.Windows.DependencyProperty.Register("TabItemContentHeight", typeof(double), typeof(global::Infragistics.Windows.Controls.XamTabControl), new global::System.Windows.FrameworkPropertyMetadata(double.NaN));

		// Token: 0x04000E08 RID: 3592
		private static readonly global::System.Windows.DependencyPropertyKey TabItemHorizontalScrollBarVisibilityPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("TabItemHorizontalScrollBarVisibility", typeof(global::System.Windows.Controls.ScrollBarVisibility), typeof(global::Infragistics.Windows.Controls.XamTabControl), new global::System.Windows.FrameworkPropertyMetadata(global::System.Windows.Controls.ScrollBarVisibility.Auto));

		// Token: 0x04000E09 RID: 3593
		public static readonly global::System.Windows.DependencyProperty TabItemHorizontalScrollBarVisibilityProperty = global::Infragistics.Windows.Controls.XamTabControl.TabItemHorizontalScrollBarVisibilityPropertyKey.DependencyProperty;

		// Token: 0x04000E0A RID: 3594
		private static readonly global::System.Windows.DependencyPropertyKey TabItemVerticalScrollBarVisibilityPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("TabItemVerticalScrollBarVisibility", typeof(global::System.Windows.Controls.ScrollBarVisibility), typeof(global::Infragistics.Windows.Controls.XamTabControl), new global::System.Windows.FrameworkPropertyMetadata(global::System.Windows.Controls.ScrollBarVisibility.Auto));

		// Token: 0x04000E0B RID: 3595
		public static readonly global::System.Windows.DependencyProperty TabItemVerticalScrollBarVisibilityProperty = global::Infragistics.Windows.Controls.XamTabControl.TabItemVerticalScrollBarVisibilityPropertyKey.DependencyProperty;

		// Token: 0x04000E0C RID: 3596
		public static readonly global::System.Windows.DependencyProperty TabLayoutStyleProperty = global::System.Windows.DependencyProperty.Register("TabLayoutStyle", typeof(global::Infragistics.Windows.Controls.TabLayoutStyle), typeof(global::Infragistics.Windows.Controls.XamTabControl), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.Windows.Controls.TabLayoutStyle.SingleRowAutoSize, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.Controls.XamTabControl.OnTabLayoutStyleChanged)));

		// Token: 0x04000E0D RID: 3597
		public static readonly global::System.Windows.DependencyProperty TabPriorityProperty = global::System.Windows.DependencyProperty.RegisterAttached("TabPriority", typeof(int), typeof(global::Infragistics.Windows.Controls.XamTabControl), new global::System.Windows.FrameworkPropertyMetadata(0));

		// Token: 0x04000E0E RID: 3598
		public static readonly global::System.Windows.DependencyProperty ThemeProperty = global::Infragistics.Windows.Themes.ThemeManager.ThemeProperty.AddOwner(typeof(global::Infragistics.Windows.Controls.XamTabControl), new global::System.Windows.FrameworkPropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.Controls.XamTabControl.OnThemeChanged)));

		// Token: 0x04000E15 RID: 3605
		public static readonly global::System.Windows.ResourceKey CloseButtonStyleKey;

		// Token: 0x04000E16 RID: 3606
		public static readonly global::System.Windows.ResourceKey MultiRowTabItemPagerStyleKey;

		// Token: 0x04000E17 RID: 3607
		public static readonly global::System.Windows.ResourceKey ScrollDownButtonStyleKey;

		// Token: 0x04000E18 RID: 3608
		public static readonly global::System.Windows.ResourceKey ScrollLeftButtonStyleKey;

		// Token: 0x04000E19 RID: 3609
		public static readonly global::System.Windows.ResourceKey ScrollRightButtonStyleKey;

		// Token: 0x04000E1A RID: 3610
		public static readonly global::System.Windows.ResourceKey ScrollUpButtonStyleKey;

		// Token: 0x04000E1B RID: 3611
		public static readonly global::System.Windows.ResourceKey SingleRowTabItemPagerStyleKey;

		// Token: 0x020002C9 RID: 713
		private class PopupPlacementAdorner : global::Infragistics.Windows.Internal.AdornerEx
		{
			// Token: 0x06001D07 RID: 7431 RVA: 0x0006F885 File Offset: 0x0006DA85
			internal PopupPlacementAdorner(global::Infragistics.Windows.Controls.XamTabControl tabControl) : base(tabControl)
			{
				base.Visibility = global::System.Windows.Visibility.Hidden;
			}

			// Token: 0x170006D8 RID: 1752
			// (get) Token: 0x06001D08 RID: 7432 RVA: 0x0006F8A1 File Offset: 0x0006DAA1
			// (set) Token: 0x06001D09 RID: 7433 RVA: 0x0006F8A9 File Offset: 0x0006DAA9
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

			// Token: 0x06001D0A RID: 7434 RVA: 0x0006F8D7 File Offset: 0x0006DAD7
			protected override global::System.Windows.Size MeasureOverride(global::System.Windows.Size constraint)
			{
				return this._rect.Size;
			}

			// Token: 0x06001D0B RID: 7435 RVA: 0x0006F8E4 File Offset: 0x0006DAE4
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

			// Token: 0x04000E1C RID: 3612
			private global::System.Windows.Rect _rect = default(global::System.Windows.Rect);
		}
	}
}
