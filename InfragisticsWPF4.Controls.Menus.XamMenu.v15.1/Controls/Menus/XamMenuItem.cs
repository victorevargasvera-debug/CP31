using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Globalization;
using System.Windows;
using System.Windows.Automation.Peers;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Input;
using Infragistics.AutomationPeers;
using Infragistics.Controls.Menus.Primitives;
using Infragistics.Windows;

namespace Infragistics.Controls.Menus
{
	// Token: 0x02000022 RID: 34
	[global::System.Windows.TemplatePart(Name = "ScrollViewer", Type = typeof(global::System.Windows.Controls.ScrollViewer))]
	[global::System.Windows.TemplateVisualState(GroupName = "SubmenuState", Name = "SubmenuCloseImmediately")]
	[global::System.Windows.TemplatePart(Name = "Popup", Type = typeof(global::System.Windows.Controls.Primitives.Popup))]
	[global::System.Windows.TemplateVisualState(GroupName = "CommonStates", Name = "Normal")]
	[global::System.Windows.TemplateVisualState(GroupName = "MenuItemRole", Name = "TopLevelItemWithIcon")]
	[global::System.Windows.TemplateVisualState(GroupName = "CommonStates", Name = "Highlighted")]
	[global::System.Windows.TemplateVisualState(GroupName = "CommonStates", Name = "Disabled")]
	[global::System.Windows.TemplateVisualState(GroupName = "SubmenuState", Name = "SubmenuOpen")]
	[global::System.Windows.TemplateVisualState(GroupName = "SubmenuState", Name = "SubmenuOpenImmediately")]
	[global::System.Windows.TemplateVisualState(GroupName = "SubmenuState", Name = "SubmenuClose")]
	[global::System.Windows.TemplateVisualState(GroupName = "CommonStates", Name = "MouseOver")]
	[global::System.Windows.TemplateVisualState(GroupName = "MenuItemRole", Name = "SubmenuHeader")]
	[global::System.Windows.TemplateVisualState(GroupName = "MenuItemRole", Name = "SubmenuItem")]
	[global::System.Windows.TemplateVisualState(GroupName = "MenuItemRole", Name = "TopLevelHeader")]
	[global::System.Windows.TemplateVisualState(GroupName = "MenuItemRole", Name = "TopLevelHeaderWithIcon")]
	[global::System.Windows.TemplateVisualState(GroupName = "MenuItemRole", Name = "TopLevelItem")]
	public class XamMenuItem : global::Infragistics.Controls.Menus.Primitives.XamHeaderedItemsControl, global::System.ComponentModel.INotifyPropertyChanged, global::System.Windows.Input.ICommandSource, global::Infragistics.IProvideParent
	{
		// Token: 0x06000143 RID: 323 RVA: 0x000060B8 File Offset: 0x000042B8
		static XamMenuItem()
		{
			global::System.Windows.Style style = new global::System.Windows.Style();
			style.Seal();
			global::System.Windows.FrameworkElement.FocusVisualStyleProperty.OverrideMetadata(typeof(global::Infragistics.Controls.Menus.XamMenuItem), new global::System.Windows.FrameworkPropertyMetadata(style));
			global::Infragistics.Controls.Menus.Primitives.XamHeaderedItemsControl.HeaderProperty.OverrideMetadata(typeof(global::Infragistics.Controls.Menus.XamMenuItem), new global::System.Windows.FrameworkPropertyMetadata(null, new global::System.Windows.CoerceValueCallback(global::Infragistics.Controls.Menus.XamMenuItem.CoerceHeader)));
		}

		// Token: 0x06000144 RID: 324 RVA: 0x00006610 File Offset: 0x00004810
		public XamMenuItem()
		{
			global::Infragistics.Windows.Utilities.ValidateLicense(typeof(global::Infragistics.Controls.Menus.XamMenuItem), this);
			this._isDesignMode = global::System.ComponentModel.DesignerProperties.GetIsInDesignMode(this);
			base.DefaultStyleKey = typeof(global::Infragistics.Controls.Menus.XamMenuItem);
			base.IsEnabledChanged += this.ControlIsEnabledChanged;
			this._navigator = new global::Infragistics.MenuNavigation();
			base.Unloaded += this.XamMenuItem_Unloaded;
		}

		// Token: 0x06000145 RID: 325 RVA: 0x00006694 File Offset: 0x00004894
		protected override global::System.Windows.Size ArrangeOverride(global::System.Windows.Size finalSize)
		{
			if (this._isMenuOrientationNotSet)
			{
				global::System.Windows.Controls.StackPanel stackPanel = base.HeaderedItemContainerGenerator.ItemsHost as global::System.Windows.Controls.StackPanel;
				if (stackPanel != null && stackPanel.Orientation != this.MenuOrientation)
				{
					stackPanel.Orientation = this.MenuOrientation;
					this._isMenuOrientationNotSet = false;
				}
			}
			global::System.Windows.Size result = base.ArrangeOverride(finalSize);
			this.EnsureSubmenuPosition();
			this.SetDropdownPopupPlacement();
			return result;
		}

		// Token: 0x1700003C RID: 60
		// (get) Token: 0x06000146 RID: 326 RVA: 0x000066F4 File Offset: 0x000048F4
		protected override bool IsEnabledCore
		{
			get
			{
				return base.IsEnabledCore && this._canExecute != false;
			}
		}

		// Token: 0x06000147 RID: 327 RVA: 0x00006727 File Offset: 0x00004927
		protected override global::System.Windows.Size MeasureOverride(global::System.Windows.Size constraint)
		{
			if (this._canExecute == null)
			{
				this.VerifyCanExecute();
			}
			return base.MeasureOverride(constraint);
		}

		// Token: 0x06000148 RID: 328 RVA: 0x00006744 File Offset: 0x00004944
		public override void OnApplyTemplate()
		{
			global::System.Windows.Input.AccessKeyManager.RemoveAccessKeyPressedHandler(this, new global::System.Windows.Input.AccessKeyPressedEventHandler(this.HandleAccessKeyPressed));
			this._scrollViewer = (base.GetTemplateChild("ScrollViewer") as global::System.Windows.Controls.ScrollViewer);
			if (this._dropDownPopup != null && this._dropDownPopup.Child != null)
			{
				this._dropDownPopup.Child.MouseEnter -= this.Items_MouseEnter;
				this._dropDownPopup.Child.MouseLeave -= this.Items_MouseLeave;
				(this._dropDownPopup.Child as global::System.Windows.FrameworkElement).SizeChanged -= this.Popup_SizeChanged;
			}
			base.OnApplyTemplate();
			if (this._headerIconPresenter != null)
			{
				this._headerIconPresenter.Content = null;
			}
			this._headerIconPresenter = (base.GetTemplateChild("HeaderIconPresenter") as global::System.Windows.Controls.ContentControl);
			if (this._headerIconPresenter != null)
			{
				this._headerIconPresenter.Content = this.Icon;
			}
			this._subMenuClosedVisualState = (base.GetTemplateChild("SubmenuClose") as global::System.Windows.VisualState);
			this._subMenuClosedImmediatelyVisualState = (base.GetTemplateChild("SubmenuCloseImmediately") as global::System.Windows.VisualState);
			this._dropDownPopup = (base.GetTemplateChild("Popup") as global::System.Windows.Controls.Primitives.Popup);
			if (this._dropDownPopup != null && this._dropDownPopup.Child != null)
			{
				this._dropDownPopup.PlacementTarget = this;
				this._dropDownPopup.Placement = global::System.Windows.Controls.Primitives.PlacementMode.Bottom;
				this.SetDropdownPopupPlacement();
				this._dropDownPopup.AllowsTransparency = true;
			}
			this.EnsureMenuItemRole();
			this.ChangeVisualState(false);
			global::System.Windows.VisualStateManager.GoToState(this, "SubmenuCloseImmediately", false);
			global::System.Windows.Input.AccessKeyManager.AddAccessKeyPressedHandler(this, new global::System.Windows.Input.AccessKeyPressedEventHandler(this.HandleAccessKeyPressed));
		}

		// Token: 0x06000149 RID: 329 RVA: 0x000068DD File Offset: 0x00004ADD
		protected override global::System.Windows.Automation.Peers.AutomationPeer OnCreateAutomationPeer()
		{
			return new global::Infragistics.AutomationPeers.XamMenuItemAutomationPeer(this);
		}

		// Token: 0x0600014A RID: 330 RVA: 0x000068E8 File Offset: 0x00004AE8
		protected override global::System.Windows.DependencyObject GetContainerForItemOverride()
		{
			global::Infragistics.Controls.Menus.XamMenuItem xamMenuItem = null;
			if (base.DefaultItemsContainer != null)
			{
				xamMenuItem = (base.DefaultItemsContainer.LoadContent() as global::Infragistics.Controls.Menus.XamMenuItem);
			}
			if (xamMenuItem == null)
			{
				return new global::Infragistics.Controls.Menus.XamMenuItem();
			}
			return xamMenuItem;
		}

		// Token: 0x0600014B RID: 331 RVA: 0x0000691A File Offset: 0x00004B1A
		protected override bool IsItemItsOwnContainerOverride(object item)
		{
			return item is global::Infragistics.Controls.Menus.XamMenuItem || item is global::Infragistics.Controls.Menus.XamMenuSeparator;
		}

		// Token: 0x0600014C RID: 332 RVA: 0x00006930 File Offset: 0x00004B30
		protected override void PrepareContainerForItemOverride(global::System.Windows.DependencyObject element, object item)
		{
			if (element is global::Infragistics.Controls.Menus.XamMenuSeparator)
			{
				return;
			}
			global::Infragistics.Controls.Menus.XamMenuItem xamMenuItem = element as global::Infragistics.Controls.Menus.XamMenuItem;
			if (xamMenuItem != null)
			{
				xamMenuItem.ParentItemsControl = this;
			}
			base.PrepareContainerForItemOverride(element, item);
		}

		// Token: 0x0600014D RID: 333 RVA: 0x00006960 File Offset: 0x00004B60
		protected override void ClearContainerForItemOverride(global::System.Windows.DependencyObject element, object item)
		{
			if (element is global::Infragistics.Controls.Menus.XamMenuSeparator)
			{
				return;
			}
			global::Infragistics.Controls.Menus.XamMenuItem xamMenuItem = element as global::Infragistics.Controls.Menus.XamMenuItem;
			if (xamMenuItem != null)
			{
				xamMenuItem.ParentItemsControl = null;
			}
			base.ClearContainerForItemOverride(element, item);
		}

		// Token: 0x0600014E RID: 334 RVA: 0x00006990 File Offset: 0x00004B90
		protected override void OnItemsChanged(global::System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
		{
			base.OnItemsChanged(e);
			if (e.Action == global::System.Collections.Specialized.NotifyCollectionChangedAction.Add || e.Action == global::System.Collections.Specialized.NotifyCollectionChangedAction.Remove || e.Action == global::System.Collections.Specialized.NotifyCollectionChangedAction.Reset)
			{
				this.EnsureMenuItemRole();
			}
			base.SetValue(global::Infragistics.Controls.Menus.XamMenuItem.HasChildrenProperty, base.Items.Count != 0);
		}

		// Token: 0x0600014F RID: 335 RVA: 0x000069E5 File Offset: 0x00004BE5
		protected override void OnMouseEnter(global::System.Windows.Input.MouseEventArgs e)
		{
			this.OnMouseEnterImpl();
			base.OnMouseEnter(e);
		}

		// Token: 0x06000150 RID: 336 RVA: 0x000069F4 File Offset: 0x00004BF4
		private void OnMouseEnterImpl()
		{
			if (this.ParentXamMenu == null)
			{
				return;
			}
			if (this.IsInContextMenu == false)
			{
				global::Infragistics.Controls.Menus.XamMenu xamMenu = this.ParentXamMenu as global::Infragistics.Controls.Menus.XamMenu;
				if (xamMenu.ExpandOnHover && this.Role == global::Infragistics.Controls.Menus.MenuItemRole.TopLevelHeader)
				{
					xamMenu.StopTimer();
				}
			}
			if (!this.IsHighlighted)
			{
				this.IgnorePropertyChange = true;
				this.IsHighlighted = true;
			}
			this.IsMouseOver = true;
		}

		// Token: 0x06000151 RID: 337 RVA: 0x00006A66 File Offset: 0x00004C66
		protected override void OnMouseLeave(global::System.Windows.Input.MouseEventArgs e)
		{
			this.OnMouseLeaveImpl();
			base.OnMouseLeave(e);
		}

		// Token: 0x06000152 RID: 338 RVA: 0x00006A78 File Offset: 0x00004C78
		private void OnMouseLeaveImpl()
		{
			if (this.ParentXamMenu == null)
			{
				return;
			}
			if (this.ParentXamMenuItem != null && this.ParentXamMenuItem.IgnoreMouseUp)
			{
				this.ParentXamMenuItem.IgnoreMouseUp = false;
			}
			if (this.IsInContextMenu == false)
			{
				global::Infragistics.Controls.Menus.XamMenu xamMenu = this.ParentXamMenu as global::Infragistics.Controls.Menus.XamMenu;
				if (xamMenu.ExpandOnHover && this.Role == global::Infragistics.Controls.Menus.MenuItemRole.TopLevelHeader)
				{
					xamMenu.StartTimer();
				}
			}
			if (this.IsHighlighted)
			{
				this.IgnorePropertyChange = true;
				this.IsHighlighted = false;
			}
			this.IsMouseOver = false;
		}

		// Token: 0x06000153 RID: 339 RVA: 0x00006B0B File Offset: 0x00004D0B
		protected override void OnMouseLeftButtonDown(global::System.Windows.Input.MouseButtonEventArgs e)
		{
			base.OnMouseLeftButtonDown(e);
			this.OnMouseLeftButtonDownImpl(e);
		}

		// Token: 0x06000154 RID: 340 RVA: 0x00006B1C File Offset: 0x00004D1C
		private void OnMouseLeftButtonDownImpl(global::System.Windows.Input.MouseButtonEventArgs e)
		{
			global::Infragistics.Controls.Menus.XamMenuBase parentXamMenu = this.ParentXamMenu;
			if (parentXamMenu == null)
			{
				return;
			}
			parentXamMenu._lastMouseArgs = null;
			if (this.IsMouseOverSubling)
			{
				return;
			}
			if (this._scrollViewer.ComputedVerticalScrollBarVisibility == global::System.Windows.Visibility.Visible || this._scrollViewer.ComputedHorizontalScrollBarVisibility == global::System.Windows.Visibility.Visible)
			{
				global::System.Windows.Rect rect = new global::System.Windows.Rect(e.GetPosition(this), new global::System.Windows.Size(0.0, 0.0));
				global::System.Windows.Rect rect2 = new global::System.Windows.Rect(base.RenderSize);
				if (!rect2.IntersectsWith(rect))
				{
					return;
				}
			}
			if (!e.Handled && base.IsEnabled)
			{
				if (this.Role == global::Infragistics.Controls.Menus.MenuItemRole.TopLevelItem)
				{
					if (!this.IsSelected)
					{
						this.IsSelected = true;
					}
				}
				else
				{
					this.FocusOrSelect();
				}
				parentXamMenu._lastMouseArgs = new global::System.WeakReference(e);
			}
			if (this.Role != global::Infragistics.Controls.Menus.MenuItemRole.TopLevelHeader)
			{
				if (this.Role == global::Infragistics.Controls.Menus.MenuItemRole.SubmenuHeader)
				{
					global::Infragistics.Controls.Menus.XamMenuItem sublingOpenItem = this.SublingOpenItem;
					if (sublingOpenItem != null)
					{
						sublingOpenItem.ManipulateSubmenu(false, true);
					}
					this.ManipulateSubmenu(true, true);
				}
				return;
			}
			if (this.IsSubmenuOpen && !((global::Infragistics.Controls.Menus.XamMenu)parentXamMenu).ExpandOnHover)
			{
				this.ManipulateSubmenu(false, false);
				parentXamMenu.CloseCurrentOpen();
				parentXamMenu.ReturnFocus();
				return;
			}
			this.ManipulateSubmenu(true, false);
		}

		// Token: 0x06000155 RID: 341 RVA: 0x00006C37 File Offset: 0x00004E37
		protected override void OnMouseLeftButtonUp(global::System.Windows.Input.MouseButtonEventArgs e)
		{
			base.OnMouseLeftButtonUp(e);
			this.OnMouseLeftButtonUpImpl(e);
		}

		// Token: 0x06000156 RID: 342 RVA: 0x00006C48 File Offset: 0x00004E48
		private void OnMouseLeftButtonUpImpl(global::System.Windows.Input.MouseButtonEventArgs e)
		{
			global::System.Windows.DependencyObject dependencyObject = e.OriginalSource as global::System.Windows.DependencyObject;
			while (dependencyObject != null && dependencyObject != this)
			{
				if (dependencyObject is global::System.Windows.Controls.Primitives.Popup)
				{
					return;
				}
				dependencyObject = global::Infragistics.Controls.Menus.XamMenuBase.GetParent(dependencyObject);
			}
			this.HandleItemSelection();
		}

		// Token: 0x06000157 RID: 343 RVA: 0x00006C80 File Offset: 0x00004E80
		protected override void OnLostMouseCapture(global::System.Windows.Input.MouseEventArgs e)
		{
			this.OnLostMouseCaptureImpl(e);
			base.OnLostMouseCapture(e);
		}

		// Token: 0x06000158 RID: 344 RVA: 0x00006C90 File Offset: 0x00004E90
		private void OnLostMouseCaptureImpl(global::System.Windows.Input.MouseEventArgs e)
		{
			if (this._hasMouseCapture)
			{
				base.ReleaseMouseCapture();
				this._hasMouseCapture = false;
			}
			if (!base.IsEnabled || base.Visibility == global::System.Windows.Visibility.Collapsed)
			{
				if (this.IsHighlighted)
				{
					this.IgnorePropertyChange = true;
					this.IsHighlighted = false;
				}
				this.IsMouseOver = false;
			}
		}

		// Token: 0x06000159 RID: 345 RVA: 0x00006CE0 File Offset: 0x00004EE0
		protected override void OnAccessKey(global::System.Windows.Input.AccessKeyEventArgs e)
		{
			base.OnAccessKey(e);
			if (this.HasChildren)
			{
				this.OpenSubmenu();
				this.IsSelected = true;
				this.IsHighlighted = true;
				global::Infragistics.Controls.Menus.XamMenuItem menuItem = this.FindSiblingItem(true, true);
				this.MoveToItem(menuItem);
				return;
			}
			this.IsSelected = true;
			this.IsHighlighted = true;
			this.HandleItemSelection();
		}

		// Token: 0x0600015A RID: 346 RVA: 0x00006D38 File Offset: 0x00004F38
		protected override void OnKeyDown(global::System.Windows.Input.KeyEventArgs e)
		{
			if (e.Key == global::System.Windows.Input.Key.System && global::System.Windows.Input.Keyboard.Modifiers == global::System.Windows.Input.ModifierKeys.Alt)
			{
				this._dropDownPopup.IsOpen = false;
			}
			base.OnKeyDown(e);
			if (this.ParentXamMenu == null)
			{
				return;
			}
			global::System.Windows.Controls.Orientation orientation = global::System.Windows.Controls.Orientation.Vertical;
			if (this.IsInContextMenu == false)
			{
				orientation = (this.ParentXamMenu as global::Infragistics.Controls.Menus.XamMenu).MenuOrientation;
			}
			global::System.Windows.DependencyObject objA = global::Infragistics.PlatformProxy.GetFocusedElement(this) as global::System.Windows.DependencyObject;
			if (!object.ReferenceEquals(objA, this))
			{
				return;
			}
			if (base.IsEnabled)
			{
				if (e.Handled)
				{
					return;
				}
				e.Handled = true;
				global::System.Windows.Input.Key key = e.Key;
				if (this.ParentXamMenu.FlowDirection == global::System.Windows.FlowDirection.RightToLeft)
				{
					if (e.Key == global::System.Windows.Input.Key.Left)
					{
						key = global::System.Windows.Input.Key.Right;
					}
					else if (e.Key == global::System.Windows.Input.Key.Right)
					{
						key = global::System.Windows.Input.Key.Left;
					}
				}
				global::System.Windows.Input.Key key2 = key;
				if (key2 == global::System.Windows.Input.Key.Return)
				{
					if (this.Role == global::Infragistics.Controls.Menus.MenuItemRole.TopLevelHeader || this.Role == global::Infragistics.Controls.Menus.MenuItemRole.SubmenuHeader)
					{
						if (this.IsSubmenuOpen)
						{
							this.ParentXamMenu.CloseCurrentOpen();
							this.ParentXamMenu.ReturnFocus();
						}
						else
						{
							this.ManipulateSubmenu(true, true);
							global::Infragistics.Controls.Menus.XamMenuItem xamMenuItem = this.FindSiblingItem(true, true);
							if (xamMenuItem != null)
							{
								this.IsHighlighted = true;
								this.MoveToItem(xamMenuItem);
							}
						}
					}
					else if (!this.StaysOpenOnClick && this.Role != global::Infragistics.Controls.Menus.MenuItemRole.SubmenuHeader)
					{
						this.ParentXamMenu.CloseCurrentOpen();
						if (this.ParentXamMenu != null)
						{
							this.ParentXamMenu.ReturnFocus();
						}
					}
					this.RaiseClickEvent();
					return;
				}
				if (key2 != global::System.Windows.Input.Key.Escape)
				{
					switch (key2)
					{
					case global::System.Windows.Input.Key.Space:
					{
						if (!this.IsCheckable)
						{
							return;
						}
						this.IsChecked = !this.IsChecked;
						if (this.StaysOpenOnClick || this.Role == global::Infragistics.Controls.Menus.MenuItemRole.SubmenuHeader)
						{
							return;
						}
						global::Infragistics.Controls.Menus.XamMenuBase parentXamMenu = this.ParentXamMenu;
						this.RaiseClickEvent();
						if (parentXamMenu != null)
						{
							parentXamMenu.CloseCurrentOpen();
							parentXamMenu.ReturnFocus();
							return;
						}
						return;
					}
					case global::System.Windows.Input.Key.Left:
						if ((this.Role == global::Infragistics.Controls.Menus.MenuItemRole.TopLevelHeader && orientation == global::System.Windows.Controls.Orientation.Vertical) || (this.ParentXamMenuItem != null && this.ParentXamMenuItem.MenuOrientation == global::System.Windows.Controls.Orientation.Horizontal))
						{
							this.HandleUpDownKey(false);
							return;
						}
						this.HandleLeftKey();
						return;
					case global::System.Windows.Input.Key.Up:
						if ((this.Role == global::Infragistics.Controls.Menus.MenuItemRole.TopLevelHeader && orientation == global::System.Windows.Controls.Orientation.Vertical) || (this.ParentXamMenuItem != null && this.ParentXamMenuItem.MenuOrientation == global::System.Windows.Controls.Orientation.Horizontal))
						{
							this.HandleLeftKey();
							return;
						}
						this.HandleUpDownKey(false);
						return;
					case global::System.Windows.Input.Key.Right:
						if ((this.Role == global::Infragistics.Controls.Menus.MenuItemRole.TopLevelHeader && orientation == global::System.Windows.Controls.Orientation.Vertical) || (this.ParentXamMenuItem != null && this.ParentXamMenuItem.MenuOrientation == global::System.Windows.Controls.Orientation.Horizontal))
						{
							this.HandleUpDownKey(true);
							return;
						}
						this.HandleRightKey();
						return;
					case global::System.Windows.Input.Key.Down:
						if ((this.Role == global::Infragistics.Controls.Menus.MenuItemRole.TopLevelHeader && orientation == global::System.Windows.Controls.Orientation.Vertical) || (this.ParentXamMenuItem != null && this.ParentXamMenuItem.MenuOrientation == global::System.Windows.Controls.Orientation.Horizontal))
						{
							this.HandleRightKey();
							return;
						}
						this.HandleUpDownKey(true);
						return;
					}
					e.Handled = false;
				}
				else
				{
					global::Infragistics.Controls.Menus.XamMenuBase parentXamMenu2 = this.ParentXamMenu;
					if (this.ParentXamMenuItem == parentXamMenu2.CurrentOpen)
					{
						parentXamMenu2.CloseCurrentOpen();
						parentXamMenu2.ReturnFocus();
						return;
					}
					this.HandleLeftKey();
					return;
				}
			}
		}

		// Token: 0x0600015B RID: 347 RVA: 0x00007028 File Offset: 0x00005228
		protected override void OnLostFocus(global::System.Windows.RoutedEventArgs e)
		{
			if (this.ParentXamMenu != null)
			{
				object focusedElement = global::Infragistics.PlatformProxy.GetFocusedElement(this.ParentXamMenu);
				if (!global::Infragistics.Controls.Menus.XamMenuBase.IsObjectFromMenu(this, focusedElement))
				{
					this.IsSelected = false;
					this.IsHighlighted = false;
				}
				if (global::Infragistics.Controls.Menus.XamMenuBase.IsObjectFromMenu(this.ParentXamMenu, focusedElement))
				{
					return;
				}
				this.ParentXamMenu._previouslyFocusedControl = null;
				this.IsSelected = false;
			}
		}

		// Token: 0x0600015C RID: 348 RVA: 0x00007084 File Offset: 0x00005284
		protected override void OnGotFocus(global::System.Windows.RoutedEventArgs e)
		{
			if (this.IsInContextMenu != true)
			{
				bool flag = this.ParentXamMenu == null || this.ParentXamMenu._previouslyFocusedControl != this;
				this.IsHighlighted = flag;
				this.IsSelected = flag;
			}
			base.OnGotFocus(e);
		}

		// Token: 0x0600015D RID: 349 RVA: 0x000070E4 File Offset: 0x000052E4
		private static void OnCommandChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Menus.XamMenuItem xamMenuItem = (global::Infragistics.Controls.Menus.XamMenuItem)d;
			xamMenuItem.OnCommandChanged(e.OldValue as global::System.Windows.Input.ICommand, e.NewValue as global::System.Windows.Input.ICommand);
		}

		// Token: 0x0600015E RID: 350 RVA: 0x00007148 File Offset: 0x00005348
		private void OnCommandChanged(global::System.Windows.Input.ICommand oldCommand, global::System.Windows.Input.ICommand newCommand)
		{
			if (this._weakCanExecuteChanged != null)
			{
				this._weakCanExecuteChanged.Detach();
				this._menuCanExecuteHandler = null;
				this._weakCanExecuteChanged = null;
			}
			if (newCommand != null)
			{
				this._weakCanExecuteChanged = new global::Infragistics.WeakEventHandler<global::Infragistics.Controls.Menus.XamMenuItem, global::System.Windows.Input.ICommand, global::System.EventArgs>(this, newCommand, delegate(global::Infragistics.Controls.Menus.XamMenuItem m, object o, global::System.EventArgs e)
				{
					m.DirtyCanExecute();
				}, delegate(global::Infragistics.WeakEventHandler<global::Infragistics.Controls.Menus.XamMenuItem, global::System.Windows.Input.ICommand, global::System.EventArgs> w, global::System.Windows.Input.ICommand c)
				{
					c.CanExecuteChanged -= w.OnEvent;
					if (w.Instance != null)
					{
						w.Instance._menuCanExecuteHandler = null;
					}
				});
				this._menuCanExecuteHandler = new global::System.EventHandler(this._weakCanExecuteChanged.OnEvent);
				newCommand.CanExecuteChanged += this._menuCanExecuteHandler;
			}
			this.DirtyCanExecute();
			base.CoerceValue(global::Infragistics.Controls.Menus.Primitives.XamHeaderedItemsControl.HeaderProperty);
			base.CoerceValue(global::Infragistics.Controls.Menus.XamMenuItem.InputGestureTextProperty);
		}

		// Token: 0x1700003D RID: 61
		// (get) Token: 0x0600015F RID: 351 RVA: 0x000071FF File Offset: 0x000053FF
		// (set) Token: 0x06000160 RID: 352 RVA: 0x00007211 File Offset: 0x00005411
		public global::System.Windows.Input.ICommand Command
		{
			get
			{
				return (global::System.Windows.Input.ICommand)base.GetValue(global::Infragistics.Controls.Menus.XamMenuItem.CommandProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Menus.XamMenuItem.CommandProperty, value);
			}
		}

		// Token: 0x06000161 RID: 353 RVA: 0x00007220 File Offset: 0x00005420
		private static void OnCommandParameterChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Menus.XamMenuItem xamMenuItem = (global::Infragistics.Controls.Menus.XamMenuItem)d;
			if (xamMenuItem.Command != null)
			{
				xamMenuItem.DirtyCanExecute();
			}
		}

		// Token: 0x1700003E RID: 62
		// (get) Token: 0x06000162 RID: 354 RVA: 0x00007242 File Offset: 0x00005442
		// (set) Token: 0x06000163 RID: 355 RVA: 0x0000724F File Offset: 0x0000544F
		public object CommandParameter
		{
			get
			{
				return base.GetValue(global::Infragistics.Controls.Menus.XamMenuItem.CommandParameterProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Menus.XamMenuItem.CommandParameterProperty, value);
			}
		}

		// Token: 0x06000164 RID: 356 RVA: 0x00007260 File Offset: 0x00005460
		private static void OnCommandTargetChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Menus.XamMenuItem xamMenuItem = (global::Infragistics.Controls.Menus.XamMenuItem)d;
			if (xamMenuItem.Command != null)
			{
				xamMenuItem.DirtyCanExecute();
			}
		}

		// Token: 0x1700003F RID: 63
		// (get) Token: 0x06000165 RID: 357 RVA: 0x00007282 File Offset: 0x00005482
		// (set) Token: 0x06000166 RID: 358 RVA: 0x00007294 File Offset: 0x00005494
		public global::System.Windows.IInputElement CommandTarget
		{
			get
			{
				return (global::System.Windows.IInputElement)base.GetValue(global::Infragistics.Controls.Menus.XamMenuItem.CommandTargetProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Menus.XamMenuItem.CommandTargetProperty, value);
			}
		}

		// Token: 0x17000040 RID: 64
		// (get) Token: 0x06000167 RID: 359 RVA: 0x000072A2 File Offset: 0x000054A2
		// (set) Token: 0x06000168 RID: 360 RVA: 0x000072B4 File Offset: 0x000054B4
		public bool IsKeyboardNavigable
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.Controls.Menus.XamMenuItem.IsKeyboardNavigableProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Menus.XamMenuItem.IsKeyboardNavigableProperty, value);
			}
		}

		// Token: 0x17000041 RID: 65
		// (get) Token: 0x06000169 RID: 361 RVA: 0x000072C7 File Offset: 0x000054C7
		public global::System.Windows.Visibility CheckBoxVisibilityResolved
		{
			get
			{
				return (global::System.Windows.Visibility)base.GetValue(global::Infragistics.Controls.Menus.XamMenuItem.CheckBoxVisibilityResolvedProperty);
			}
		}

		// Token: 0x17000042 RID: 66
		// (get) Token: 0x0600016A RID: 362 RVA: 0x000072D9 File Offset: 0x000054D9
		// (set) Token: 0x0600016B RID: 363 RVA: 0x000072E6 File Offset: 0x000054E6
		public object Icon
		{
			get
			{
				return base.GetValue(global::Infragistics.Controls.Menus.XamMenuItem.IconProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Menus.XamMenuItem.IconProperty, value);
			}
		}

		// Token: 0x0600016C RID: 364 RVA: 0x000072F4 File Offset: 0x000054F4
		private static void IconChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Menus.XamMenuItem xamMenuItem = obj as global::Infragistics.Controls.Menus.XamMenuItem;
			if (e.NewValue != null && !xamMenuItem.IsCheckable)
			{
				xamMenuItem.SetValue(global::Infragistics.Controls.Menus.XamMenuItem.IconVisibilityResolvedProperty, global::System.Windows.Visibility.Visible);
				xamMenuItem.SetValue(global::Infragistics.Controls.Menus.XamMenuItem.CheckBoxVisibilityResolvedProperty, global::System.Windows.Visibility.Collapsed);
			}
			if (xamMenuItem._headerIconPresenter != null)
			{
				xamMenuItem._headerIconPresenter.Content = xamMenuItem.Icon;
			}
		}

		// Token: 0x17000043 RID: 67
		// (get) Token: 0x0600016D RID: 365 RVA: 0x00007354 File Offset: 0x00005554
		public global::System.Windows.Visibility IconVisibilityResolved
		{
			get
			{
				return (global::System.Windows.Visibility)base.GetValue(global::Infragistics.Controls.Menus.XamMenuItem.IconVisibilityResolvedProperty);
			}
		}

		// Token: 0x17000044 RID: 68
		// (get) Token: 0x0600016E RID: 366 RVA: 0x00007366 File Offset: 0x00005566
		// (set) Token: 0x0600016F RID: 367 RVA: 0x00007378 File Offset: 0x00005578
		public string InputGestureText
		{
			get
			{
				return (string)base.GetValue(global::Infragistics.Controls.Menus.XamMenuItem.InputGestureTextProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Menus.XamMenuItem.InputGestureTextProperty, value);
			}
		}

		// Token: 0x17000045 RID: 69
		// (get) Token: 0x06000170 RID: 368 RVA: 0x00007386 File Offset: 0x00005586
		// (set) Token: 0x06000171 RID: 369 RVA: 0x00007398 File Offset: 0x00005598
		public bool IsCheckable
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.Controls.Menus.XamMenuItem.IsCheckableProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Menus.XamMenuItem.IsCheckableProperty, value);
			}
		}

		// Token: 0x06000172 RID: 370 RVA: 0x000073AC File Offset: 0x000055AC
		private static void IsCheckableChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Menus.XamMenuItem xamMenuItem = obj as global::Infragistics.Controls.Menus.XamMenuItem;
			bool flag = (bool)e.NewValue;
			if (flag)
			{
				xamMenuItem.SetValue(global::Infragistics.Controls.Menus.XamMenuItem.CheckBoxVisibilityResolvedProperty, global::System.Windows.Visibility.Visible);
				xamMenuItem.SetValue(global::Infragistics.Controls.Menus.XamMenuItem.IconVisibilityResolvedProperty, global::System.Windows.Visibility.Collapsed);
				return;
			}
			xamMenuItem.SetValue(global::Infragistics.Controls.Menus.XamMenuItem.CheckBoxVisibilityResolvedProperty, global::System.Windows.Visibility.Collapsed);
			if (xamMenuItem.Icon != null)
			{
				xamMenuItem.SetValue(global::Infragistics.Controls.Menus.XamMenuItem.IconVisibilityResolvedProperty, global::System.Windows.Visibility.Visible);
			}
		}

		// Token: 0x17000046 RID: 70
		// (get) Token: 0x06000173 RID: 371 RVA: 0x0000741D File Offset: 0x0000561D
		// (set) Token: 0x06000174 RID: 372 RVA: 0x0000742F File Offset: 0x0000562F
		public bool IsChecked
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.Controls.Menus.XamMenuItem.IsCheckedProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Menus.XamMenuItem.IsCheckedProperty, value);
			}
		}

		// Token: 0x06000175 RID: 373 RVA: 0x00007444 File Offset: 0x00005644
		private static void IsCheckedChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Menus.XamMenuItem xamMenuItem = obj as global::Infragistics.Controls.Menus.XamMenuItem;
			bool flag = (bool)e.NewValue;
			if (flag)
			{
				xamMenuItem.RaiseCheckedEvent();
				return;
			}
			xamMenuItem.RaiseUncheckedEvent();
		}

		// Token: 0x17000047 RID: 71
		// (get) Token: 0x06000176 RID: 374 RVA: 0x00007475 File Offset: 0x00005675
		// (set) Token: 0x06000177 RID: 375 RVA: 0x00007487 File Offset: 0x00005687
		public bool IsHighlighted
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.Controls.Menus.XamMenuItem.IsHighlightedProperty);
			}
			internal set
			{
				base.SetValue(global::Infragistics.Controls.Menus.XamMenuItem.IsHighlightedProperty, value);
			}
		}

		// Token: 0x06000178 RID: 376 RVA: 0x0000749C File Offset: 0x0000569C
		private static void IsHighlightedChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Menus.XamMenuItem xamMenuItem = (global::Infragistics.Controls.Menus.XamMenuItem)obj;
			if (xamMenuItem.IgnorePropertyChange)
			{
				xamMenuItem.IgnorePropertyChange = false;
				return;
			}
			if ((bool)e.NewValue && xamMenuItem.SublingOpenItem != null)
			{
				xamMenuItem.SublingOpenItem.ManipulateSubmenu(false, false);
			}
			xamMenuItem.ChangeVisualState(false);
		}

		// Token: 0x17000048 RID: 72
		// (get) Token: 0x06000179 RID: 377 RVA: 0x000074EA File Offset: 0x000056EA
		// (set) Token: 0x0600017A RID: 378 RVA: 0x000074FC File Offset: 0x000056FC
		public bool IsSubmenuOpen
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.Controls.Menus.XamMenuItem.IsSubmenuOpenProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Menus.XamMenuItem.IsSubmenuOpenProperty, value);
			}
		}

		// Token: 0x0600017B RID: 379 RVA: 0x00007510 File Offset: 0x00005710
		private static void IsSubmenuOpenChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Menus.XamMenuItem xamMenuItem = (global::Infragistics.Controls.Menus.XamMenuItem)obj;
			if (xamMenuItem.IgnorePropertyChange)
			{
				xamMenuItem.IgnorePropertyChange = false;
				return;
			}
			bool flag = (bool)e.NewValue;
			bool isSubmenuOpen = (bool)e.OldValue;
			if (xamMenuItem.Role == global::Infragistics.Controls.Menus.MenuItemRole.TopLevelItem || xamMenuItem.Role == global::Infragistics.Controls.Menus.MenuItemRole.SubmenuItem)
			{
				xamMenuItem.IgnorePropertyChange = true;
				xamMenuItem.IsSubmenuOpen = isSubmenuOpen;
				return;
			}
			if (flag)
			{
				xamMenuItem.OpenSubmenu();
				xamMenuItem.IsHighlighted = true;
				xamMenuItem.RaiseSubmenuOpenedEvent();
				return;
			}
			xamMenuItem.CloseSubmenu(false);
			if (xamMenuItem._dropDownPopup != null)
			{
				xamMenuItem._dropDownPopup.IsOpen = false;
			}
			xamMenuItem.RaiseSubmenuClosedEvent();
			xamMenuItem.ParentXamMenu.ReturnFocus();
			if (xamMenuItem.Role == global::Infragistics.Controls.Menus.MenuItemRole.TopLevelHeader)
			{
				xamMenuItem.ParentXamMenu.CloseCurrentOpen();
				xamMenuItem.ParentXamMenu.ClearPreviouslyFocusedControl();
			}
		}

		// Token: 0x17000049 RID: 73
		// (get) Token: 0x0600017C RID: 380 RVA: 0x000075D0 File Offset: 0x000057D0
		// (set) Token: 0x0600017D RID: 381 RVA: 0x000075E2 File Offset: 0x000057E2
		public global::System.Windows.Controls.Orientation MenuOrientation
		{
			get
			{
				return (global::System.Windows.Controls.Orientation)base.GetValue(global::Infragistics.Controls.Menus.XamMenuItem.MenuOrientationProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Menus.XamMenuItem.MenuOrientationProperty, value);
			}
		}

		// Token: 0x0600017E RID: 382 RVA: 0x000075F8 File Offset: 0x000057F8
		private static void MenuOrientationChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Menus.XamMenuItem xamMenuItem = obj as global::Infragistics.Controls.Menus.XamMenuItem;
			if (xamMenuItem != null)
			{
				global::System.Windows.Controls.StackPanel stackPanel = xamMenuItem.HeaderedItemContainerGenerator.ItemsHost as global::System.Windows.Controls.StackPanel;
				if (stackPanel != null)
				{
					stackPanel.Orientation = xamMenuItem.MenuOrientation;
				}
				else
				{
					xamMenuItem._isMenuOrientationNotSet = true;
				}
				xamMenuItem.SetDropdownPopupPlacement();
			}
		}

		// Token: 0x1700004A RID: 74
		// (get) Token: 0x0600017F RID: 383 RVA: 0x0000763E File Offset: 0x0000583E
		public bool HasChildren
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.Controls.Menus.XamMenuItem.HasChildrenProperty);
			}
		}

		// Token: 0x1700004B RID: 75
		// (get) Token: 0x06000180 RID: 384 RVA: 0x00007650 File Offset: 0x00005850
		public global::Infragistics.Controls.Menus.XamMenuItem ParentXamMenuItem
		{
			get
			{
				return this.ParentItemsControl as global::Infragistics.Controls.Menus.XamMenuItem;
			}
		}

		// Token: 0x1700004C RID: 76
		// (get) Token: 0x06000181 RID: 385 RVA: 0x0000765D File Offset: 0x0000585D
		// (set) Token: 0x06000182 RID: 386 RVA: 0x0000766F File Offset: 0x0000586F
		public global::Infragistics.Controls.Menus.MenuItemPosition SubmenuPreferredLocation
		{
			get
			{
				return (global::Infragistics.Controls.Menus.MenuItemPosition)base.GetValue(global::Infragistics.Controls.Menus.XamMenuItem.SubmenuPreferredLocationProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Menus.XamMenuItem.SubmenuPreferredLocationProperty, value);
			}
		}

		// Token: 0x06000183 RID: 387 RVA: 0x00007684 File Offset: 0x00005884
		private static void SubmenuPreferredLocationChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Menus.XamMenuItem xamMenuItem = (global::Infragistics.Controls.Menus.XamMenuItem)obj;
			if (xamMenuItem != null)
			{
				xamMenuItem.SetDropdownPopupPlacement();
			}
		}

		// Token: 0x1700004D RID: 77
		// (get) Token: 0x06000184 RID: 388 RVA: 0x000076A1 File Offset: 0x000058A1
		// (set) Token: 0x06000185 RID: 389 RVA: 0x000076B3 File Offset: 0x000058B3
		public bool StaysOpenOnClick
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.Controls.Menus.XamMenuItem.StaysOpenOnClickProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Menus.XamMenuItem.StaysOpenOnClickProperty, value);
			}
		}

		// Token: 0x1700004E RID: 78
		// (get) Token: 0x06000186 RID: 390 RVA: 0x000076C6 File Offset: 0x000058C6
		// (set) Token: 0x06000187 RID: 391 RVA: 0x000076D8 File Offset: 0x000058D8
		private protected global::Infragistics.Controls.Menus.MenuItemRole Role
		{
			protected get
			{
				return (global::Infragistics.Controls.Menus.MenuItemRole)base.GetValue(global::Infragistics.Controls.Menus.XamMenuItem.RoleProperty);
			}
			private set
			{
				base.SetValue(global::Infragistics.Controls.Menus.XamMenuItem.RoleProperty, value);
			}
		}

		// Token: 0x06000188 RID: 392 RVA: 0x000076EC File Offset: 0x000058EC
		private static void RoleChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs args)
		{
			global::Infragistics.Controls.Menus.XamMenuItem xamMenuItem = (global::Infragistics.Controls.Menus.XamMenuItem)obj;
			if (xamMenuItem != null)
			{
				xamMenuItem.SetDropdownPopupPlacement();
			}
		}

		// Token: 0x1700004F RID: 79
		// (get) Token: 0x06000189 RID: 393 RVA: 0x0000770C File Offset: 0x0000590C
		internal bool? IsInContextMenu
		{
			get
			{
				if (this.ParentXamMenu is global::Infragistics.Controls.Menus.XamContextMenu)
				{
					return new bool?(true);
				}
				if (this.ParentXamMenu is global::Infragistics.Controls.Menus.XamMenu)
				{
					return new bool?(false);
				}
				return null;
			}
		}

		// Token: 0x17000050 RID: 80
		// (get) Token: 0x0600018A RID: 394 RVA: 0x0000774A File Offset: 0x0000594A
		// (set) Token: 0x0600018B RID: 395 RVA: 0x0000775C File Offset: 0x0000595C
		internal bool IsSelected
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.Controls.Menus.XamMenuItem.IsSelectedProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Menus.XamMenuItem.IsSelectedProperty, value);
			}
		}

		// Token: 0x0600018C RID: 396 RVA: 0x00007770 File Offset: 0x00005970
		private static void IsSelectedChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Menus.XamMenuItem xamMenuItem = (global::Infragistics.Controls.Menus.XamMenuItem)obj;
			if (xamMenuItem.ParentXamMenu == null)
			{
				return;
			}
			bool flag = (bool)e.NewValue;
			if (flag)
			{
				xamMenuItem.ParentXamMenu.CurrentSelected = xamMenuItem;
				xamMenuItem.IsHighlighted = false;
				global::Infragistics.Controls.Menus.XamMenuItem childHighlightedItem = xamMenuItem.ChildHighlightedItem;
				if (childHighlightedItem != null)
				{
					childHighlightedItem.ManipulateSubmenu(false, false);
					return;
				}
			}
			else
			{
				xamMenuItem.ChangeVisualState(false);
			}
		}

		// Token: 0x17000051 RID: 81
		// (get) Token: 0x0600018D RID: 397 RVA: 0x000077CA File Offset: 0x000059CA
		// (set) Token: 0x0600018E RID: 398 RVA: 0x000077DC File Offset: 0x000059DC
		internal new bool IsMouseOver
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.Controls.Menus.XamMenuItem.IsMouseOverProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Menus.XamMenuItem.IsMouseOverProperty, value);
			}
		}

		// Token: 0x0600018F RID: 399 RVA: 0x000077F0 File Offset: 0x000059F0
		private static void IsMouseOverChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Menus.XamMenuItem xamMenuItem = (global::Infragistics.Controls.Menus.XamMenuItem)obj;
			if (xamMenuItem.ParentXamMenu == null)
			{
				return;
			}
			bool flag = (bool)e.NewValue;
			if (xamMenuItem.IsInContextMenu == true)
			{
				if (flag)
				{
					if (xamMenuItem.IsInContextMenu == true)
					{
						if (xamMenuItem.SublingOpenItem != null)
						{
							xamMenuItem.SublingOpenItem.ManipulateSubmenu(false, true);
						}
						if (xamMenuItem.Role == global::Infragistics.Controls.Menus.MenuItemRole.SubmenuHeader)
						{
							xamMenuItem.IsHighlighted = false;
							xamMenuItem.ManipulateSubmenu(true, true);
						}
					}
					xamMenuItem.FocusOrSelect();
				}
				else
				{
					xamMenuItem.IsSelected = false;
					if (xamMenuItem.Role == global::Infragistics.Controls.Menus.MenuItemRole.SubmenuHeader && !xamMenuItem._skipCloseUnselected)
					{
						xamMenuItem.ManipulateSubmenu(false, true);
					}
				}
			}
			else
			{
				bool expandOnHover = ((global::Infragistics.Controls.Menus.XamMenu)xamMenuItem.ParentXamMenu).ExpandOnHover;
				if (flag)
				{
					if (xamMenuItem.ParentXamMenu.CurrentOpen != null || expandOnHover)
					{
						xamMenuItem.FocusOrSelect();
					}
				}
				else
				{
					xamMenuItem.IsSelected = false;
				}
				switch (xamMenuItem.Role)
				{
				case global::Infragistics.Controls.Menus.MenuItemRole.TopLevelItem:
					if (xamMenuItem.ParentXamMenu.CurrentOpen != null && flag)
					{
						xamMenuItem.ParentXamMenu.CurrentOpen = null;
					}
					break;
				case global::Infragistics.Controls.Menus.MenuItemRole.TopLevelHeader:
					global::Infragistics.Controls.Menus.XamMenuItem.ManupulateMousOverTopLavelHeader(flag, xamMenuItem, expandOnHover);
					break;
				case global::Infragistics.Controls.Menus.MenuItemRole.SubmenuHeader:
					if (flag)
					{
						xamMenuItem.IsHighlighted = false;
						xamMenuItem.ManipulateSubmenu(true, false);
					}
					else
					{
						xamMenuItem.ManipulateSubmenu(false, false);
					}
					break;
				}
			}
			xamMenuItem.ChangeVisualState(false);
		}

		// Token: 0x17000052 RID: 82
		// (get) Token: 0x06000190 RID: 400 RVA: 0x0000795D File Offset: 0x00005B5D
		// (set) Token: 0x06000191 RID: 401 RVA: 0x0000796F File Offset: 0x00005B6F
		internal bool IsMouseOverSubling
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.Controls.Menus.XamMenuItem.IsMouseOverSublingProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Menus.XamMenuItem.IsMouseOverSublingProperty, value);
			}
		}

		// Token: 0x06000192 RID: 402 RVA: 0x00007984 File Offset: 0x00005B84
		private static void IsMouseOverSublingChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Menus.XamMenuItem xamMenuItem = (global::Infragistics.Controls.Menus.XamMenuItem)obj;
			if ((bool)e.NewValue)
			{
				xamMenuItem.IsHighlighted = true;
				xamMenuItem.ManipulateSubmenu(true, false);
			}
		}

		// Token: 0x17000053 RID: 83
		// (get) Token: 0x06000193 RID: 403 RVA: 0x000079B5 File Offset: 0x00005BB5
		// (set) Token: 0x06000194 RID: 404 RVA: 0x000079BD File Offset: 0x00005BBD
		internal global::System.Windows.Controls.ItemsControl ParentItemsControl
		{
			get
			{
				return this._parentItemsControl;
			}
			set
			{
				if (this._parentItemsControl != value)
				{
					this._parentItemsControl = value;
					this.OnPropertyChanged("ParentItemsControl");
					this.OnPropertyChanged("ParentXamMenu");
					this.OnPropertyChanged("ParentXamMenuItem");
				}
			}
		}

		// Token: 0x17000054 RID: 84
		// (get) Token: 0x06000195 RID: 405 RVA: 0x000079F0 File Offset: 0x00005BF0
		protected internal global::Infragistics.Controls.Menus.XamMenuBase ParentXamMenu
		{
			get
			{
				for (global::Infragistics.Controls.Menus.XamMenuItem xamMenuItem = this; xamMenuItem != null; xamMenuItem = xamMenuItem.ParentXamMenuItem)
				{
					global::Infragistics.Controls.Menus.XamMenuBase xamMenuBase = xamMenuItem.ParentItemsControl as global::Infragistics.Controls.Menus.XamMenuBase;
					if (xamMenuBase != null)
					{
						return xamMenuBase;
					}
				}
				return null;
			}
		}

		// Token: 0x17000055 RID: 85
		// (get) Token: 0x06000196 RID: 406 RVA: 0x00007A20 File Offset: 0x00005C20
		internal global::Infragistics.Controls.Menus.XamMenuItem SublingOpenItem
		{
			get
			{
				global::System.Windows.Controls.ItemsControl parentItemsControl = this.ParentItemsControl;
				global::System.Windows.Controls.ItemContainerGenerator generator = global::Infragistics.Controls.Menus.XamMenuBase.GetGenerator(parentItemsControl);
				if (parentItemsControl == null || generator == null)
				{
					return null;
				}
				for (int i = 0; i < parentItemsControl.Items.Count; i++)
				{
					global::Infragistics.Controls.Menus.XamMenuItem xamMenuItem = generator.ContainerFromIndex(i) as global::Infragistics.Controls.Menus.XamMenuItem;
					if (xamMenuItem != null && xamMenuItem.IsSubmenuOpen && xamMenuItem != this)
					{
						return xamMenuItem;
					}
				}
				return null;
			}
		}

		// Token: 0x17000056 RID: 86
		// (get) Token: 0x06000197 RID: 407 RVA: 0x00007A78 File Offset: 0x00005C78
		internal global::Infragistics.Controls.Menus.XamMenuItem ChildHighlightedItem
		{
			get
			{
				for (int i = 0; i < base.Items.Count; i++)
				{
					global::Infragistics.Controls.Menus.XamMenuItem xamMenuItem = base.ItemContainerGenerator.ContainerFromIndex(i) as global::Infragistics.Controls.Menus.XamMenuItem;
					if (xamMenuItem != null && xamMenuItem.IsHighlighted)
					{
						return xamMenuItem;
					}
				}
				return null;
			}
		}

		// Token: 0x17000057 RID: 87
		// (get) Token: 0x06000198 RID: 408 RVA: 0x00007ABB File Offset: 0x00005CBB
		// (set) Token: 0x06000199 RID: 409 RVA: 0x00007AC3 File Offset: 0x00005CC3
		internal bool IgnoreMouseUp { get; set; }

		// Token: 0x17000058 RID: 88
		// (get) Token: 0x0600019A RID: 410 RVA: 0x00007ACC File Offset: 0x00005CCC
		// (set) Token: 0x0600019B RID: 411 RVA: 0x00007AD4 File Offset: 0x00005CD4
		private bool IgnorePropertyChange { get; set; }

		// Token: 0x0600019C RID: 412 RVA: 0x00007ADD File Offset: 0x00005CDD
		internal void AutomationMenuItemClick()
		{
			this.OnClick(global::System.EventArgs.Empty);
		}

		// Token: 0x0600019D RID: 413 RVA: 0x00007AEC File Offset: 0x00005CEC
		internal void UnloadSubmenu()
		{
			if (this.Role == global::Infragistics.Controls.Menus.MenuItemRole.SubmenuHeader || this.Role == global::Infragistics.Controls.Menus.MenuItemRole.TopLevelHeader)
			{
				global::Infragistics.Controls.Menus.XamMenuItem childHighlightedItem = this.ChildHighlightedItem;
				if (childHighlightedItem != null)
				{
					childHighlightedItem.UnloadSubmenu();
				}
			}
			if (this._dropDownPopup != null)
			{
				this._dropDownPopup.IsOpen = false;
			}
		}

		// Token: 0x0600019E RID: 414 RVA: 0x00007B30 File Offset: 0x00005D30
		internal void CloseSubmenu(bool forceCloseImmediately = false)
		{
			if (this.Role == global::Infragistics.Controls.Menus.MenuItemRole.SubmenuHeader || this.Role == global::Infragistics.Controls.Menus.MenuItemRole.TopLevelHeader)
			{
				global::Infragistics.Controls.Menus.XamMenuItem childHighlightedItem = this.ChildHighlightedItem;
				if (childHighlightedItem != null)
				{
					if (forceCloseImmediately)
					{
						childHighlightedItem.CloseSubmenu(forceCloseImmediately);
					}
					else
					{
						childHighlightedItem.ManipulateSubmenu(false, this._isImmediately);
					}
				}
			}
			this.IsHighlighted = false;
			this.IsMouseOverSubling = false;
			if (forceCloseImmediately)
			{
				this.IsSubmenuOpen = false;
				return;
			}
			if (this.Role == global::Infragistics.Controls.Menus.MenuItemRole.TopLevelHeader || this._isImmediately)
			{
				this.GoToSubMenuClosedImmediatelyState();
				return;
			}
			if (this.Role == global::Infragistics.Controls.Menus.MenuItemRole.SubmenuHeader)
			{
				this.GoToSubMenuClosedState();
			}
		}

		// Token: 0x0600019F RID: 415 RVA: 0x00007BB2 File Offset: 0x00005DB2
		internal void ManipulateSubmenu(bool isOpen, bool isImmediately)
		{
			this._isImmediately = isImmediately;
			if (isOpen)
			{
				this.OpenSubmenu();
			}
			else
			{
				this.CloseSubmenu(false);
			}
			this._isImmediately = true;
		}

		// Token: 0x060001A0 RID: 416 RVA: 0x00007BD4 File Offset: 0x00005DD4
		internal void OpenSubmenu()
		{
			if (this._dropDownPopup != null)
			{
				if (this._dropDownPopup.Child != null)
				{
					this._dropDownPopup.Child.MouseEnter -= this.Items_MouseEnter;
					this._dropDownPopup.Child.MouseLeave -= this.Items_MouseLeave;
					(this._dropDownPopup.Child as global::System.Windows.FrameworkElement).SizeChanged -= this.Popup_SizeChanged;
					this._dropDownPopup.Child.MouseEnter += this.Items_MouseEnter;
					this._dropDownPopup.Child.MouseLeave += this.Items_MouseLeave;
					(this._dropDownPopup.Child as global::System.Windows.FrameworkElement).SizeChanged += this.Popup_SizeChanged;
				}
				if (this.Role == global::Infragistics.Controls.Menus.MenuItemRole.SubmenuHeader && this.ParentXamMenuItem != null && !this.ParentXamMenuItem.IsSubmenuOpen)
				{
					return;
				}
				global::System.Windows.FrameworkElement frameworkElement = this._dropDownPopup.Child as global::System.Windows.FrameworkElement;
				if (frameworkElement != null)
				{
					frameworkElement.MaxHeight = double.PositiveInfinity;
					frameworkElement.MinHeight = 0.0;
				}
				this._dropDownPopup.IsOpen = true;
				if (this.Role == global::Infragistics.Controls.Menus.MenuItemRole.TopLevelHeader || this._isImmediately)
				{
					global::System.Windows.VisualStateManager.GoToState(this, "SubmenuOpenImmediately", false);
				}
				else if (this.Role == global::Infragistics.Controls.Menus.MenuItemRole.SubmenuHeader)
				{
					global::System.Windows.VisualStateManager.GoToState(this, "SubmenuOpen", false);
				}
				if (this.Role == global::Infragistics.Controls.Menus.MenuItemRole.TopLevelHeader && this.ParentXamMenu != null)
				{
					this.ParentXamMenu.CurrentOpen = this;
				}
				if (!this.IsSubmenuOpen)
				{
					if (this._isMenuOrientationNotSet)
					{
						global::System.Windows.Controls.StackPanel stackPanel = base.HeaderedItemContainerGenerator.ItemsHost as global::System.Windows.Controls.StackPanel;
						if (stackPanel != null)
						{
							stackPanel.Orientation = this.MenuOrientation;
							this._isMenuOrientationNotSet = false;
						}
					}
					this.IgnorePropertyChange = true;
					this.IsSubmenuOpen = true;
					this.RaiseSubmenuOpenedEvent();
				}
				this._dropDownPopup.UpdateLayout();
			}
		}

		// Token: 0x060001A1 RID: 417 RVA: 0x00007DB4 File Offset: 0x00005FB4
		internal global::Infragistics.Controls.Menus.XamMenuItem FindSiblingItem(bool isForward, bool recurse)
		{
			if (recurse)
			{
				int index = 0;
				if (!isForward)
				{
					index = base.Items.Count - 1;
				}
				global::Infragistics.Controls.Menus.XamMenuItem xamMenuItem = base.ItemContainerGenerator.ContainerFromIndex(index) as global::Infragistics.Controls.Menus.XamMenuItem;
				if (xamMenuItem != null)
				{
					if (!xamMenuItem.IsEnabled)
					{
						return xamMenuItem.FindSiblingItem(isForward, false);
					}
					return xamMenuItem;
				}
			}
			global::System.Windows.Controls.ItemsControl parentItemsControl = this.ParentItemsControl;
			global::System.Windows.Controls.ItemContainerGenerator generator = global::Infragistics.Controls.Menus.XamMenuBase.GetGenerator(parentItemsControl);
			if (parentItemsControl == null && generator == null)
			{
				return null;
			}
			int num = generator.IndexFromContainer(this);
			int count = parentItemsControl.Items.Count;
			bool flag = false;
			if (isForward)
			{
				if (num == count - 1)
				{
					num = -1;
					flag = true;
				}
				while (num++ < count)
				{
					global::Infragistics.Controls.Menus.XamMenuItem xamMenuItem2 = generator.ContainerFromIndex(num) as global::Infragistics.Controls.Menus.XamMenuItem;
					if (xamMenuItem2 != null && xamMenuItem2.IsEnabled && xamMenuItem2.IsKeyboardNavigable)
					{
						return xamMenuItem2;
					}
					if (!flag && num == count - 1)
					{
						num = -1;
						flag = true;
					}
				}
			}
			else
			{
				if (num == 0)
				{
					flag = true;
					num = count;
				}
				while (num-- > 0)
				{
					global::Infragistics.Controls.Menus.XamMenuItem xamMenuItem2 = generator.ContainerFromIndex(num) as global::Infragistics.Controls.Menus.XamMenuItem;
					if (xamMenuItem2 != null && xamMenuItem2.IsEnabled && xamMenuItem2.IsKeyboardNavigable)
					{
						return xamMenuItem2;
					}
					if (!flag && num == 0)
					{
						num = count;
						flag = true;
					}
				}
			}
			return null;
		}

		// Token: 0x060001A2 RID: 418 RVA: 0x00007EDA File Offset: 0x000060DA
		protected virtual void OnChecked(global::System.EventArgs e)
		{
			if (this.Checked != null)
			{
				this.Checked(this, e);
			}
		}

		// Token: 0x060001A3 RID: 419 RVA: 0x00007EF4 File Offset: 0x000060F4
		private void RaiseCheckedEvent()
		{
			global::System.EventArgs e = new global::System.EventArgs();
			this.OnChecked(e);
		}

		// Token: 0x060001A4 RID: 420 RVA: 0x00007F0E File Offset: 0x0000610E
		protected virtual void OnUnchecked(global::System.EventArgs e)
		{
			if (this.Unchecked != null)
			{
				this.Unchecked(this, e);
			}
		}

		// Token: 0x060001A5 RID: 421 RVA: 0x00007F28 File Offset: 0x00006128
		private void RaiseUncheckedEvent()
		{
			global::System.EventArgs e = new global::System.EventArgs();
			this.OnUnchecked(e);
		}

		// Token: 0x060001A6 RID: 422 RVA: 0x00007F42 File Offset: 0x00006142
		protected virtual void OnClick(global::System.EventArgs e)
		{
			if (this.Click != null)
			{
				this.Click(this, e);
			}
		}

		// Token: 0x060001A7 RID: 423 RVA: 0x00007F5C File Offset: 0x0000615C
		private void RaiseClickEvent()
		{
			this.ExecuteCommand();
			global::Infragistics.Controls.Menus.XamMenuBase parentXamMenu = this.ParentXamMenu;
			if (this.ParentXamMenu != null && !this.StaysOpenOnClick && (this.Role == global::Infragistics.Controls.Menus.MenuItemRole.SubmenuItem || this.Role == global::Infragistics.Controls.Menus.MenuItemRole.TopLevelItem))
			{
				parentXamMenu.CloseCurrentOpen();
				parentXamMenu.ReturnFocus();
			}
			this.OnClick(global::System.EventArgs.Empty);
			if (parentXamMenu != null)
			{
				parentXamMenu.RaiseItemClickedEvent(this);
			}
			if (this.IsInContextMenu == false && this.NavigationOnClick)
			{
				if (this.NavigationElement == null && this.ParentXamMenu != null)
				{
					this._navigator.NavigationElement = (this.ParentXamMenu as global::Infragistics.Controls.Menus.XamMenu).NavigationElement;
				}
				this._navigator.NavigateTo();
			}
		}

		// Token: 0x060001A8 RID: 424 RVA: 0x00008012 File Offset: 0x00006212
		protected virtual void OnSubmenuClosed(global::System.EventArgs e)
		{
			if (this.SubmenuClosed != null)
			{
				this.SubmenuClosed(this, e);
			}
		}

		// Token: 0x060001A9 RID: 425 RVA: 0x0000802C File Offset: 0x0000622C
		private void RaiseSubmenuClosedEvent()
		{
			global::System.EventArgs e = new global::System.EventArgs();
			this.OnSubmenuClosed(e);
		}

		// Token: 0x060001AA RID: 426 RVA: 0x00008046 File Offset: 0x00006246
		protected virtual void OnSubmenuOpened(global::System.EventArgs e)
		{
			if (this.SubmenuOpened != null)
			{
				this.SubmenuOpened(this, e);
			}
		}

		// Token: 0x060001AB RID: 427 RVA: 0x00008060 File Offset: 0x00006260
		private void RaiseSubmenuOpenedEvent()
		{
			global::System.EventArgs e = new global::System.EventArgs();
			this.OnSubmenuOpened(e);
		}

		// Token: 0x060001AC RID: 428 RVA: 0x0000807C File Offset: 0x0000627C
		private void CloseAncestorMenuItems()
		{
			global::System.Collections.Generic.Queue<global::Infragistics.Controls.Menus.XamMenuItem> queue = new global::System.Collections.Generic.Queue<global::Infragistics.Controls.Menus.XamMenuItem>();
			for (global::Infragistics.Controls.Menus.XamMenuItem parentXamMenuItem = this.ParentXamMenuItem; parentXamMenuItem != null; parentXamMenuItem = parentXamMenuItem.ParentXamMenuItem)
			{
				queue.Enqueue(parentXamMenuItem);
			}
			foreach (global::Infragistics.Controls.Menus.XamMenuItem xamMenuItem in queue)
			{
				xamMenuItem.IsSubmenuOpen = false;
			}
		}

		// Token: 0x060001AD RID: 429 RVA: 0x000080EC File Offset: 0x000062EC
		private static object CoerceHeader(global::System.Windows.DependencyObject d, object newValue)
		{
			global::Infragistics.Controls.Menus.XamMenuItem xamMenuItem = (global::Infragistics.Controls.Menus.XamMenuItem)d;
			if (newValue == null)
			{
				global::System.Windows.Input.RoutedUICommand routedUICommand = xamMenuItem.Command as global::System.Windows.Input.RoutedUICommand;
				if (routedUICommand != null)
				{
					return routedUICommand.Text;
				}
			}
			else if (newValue is global::System.Windows.Input.RoutedUICommand)
			{
				global::System.Windows.Input.RoutedUICommand routedUICommand2 = newValue as global::System.Windows.Input.RoutedUICommand;
				global::System.Windows.Controls.ItemsControl itemsControl = global::System.Windows.Controls.ItemsControl.ItemsControlFromItemContainer(xamMenuItem);
				if (itemsControl != null && itemsControl.ItemContainerGenerator.ItemFromContainer(xamMenuItem) == newValue)
				{
					return routedUICommand2.Text;
				}
			}
			return newValue;
		}

		// Token: 0x060001AE RID: 430 RVA: 0x0000814C File Offset: 0x0000634C
		private static object CoerceInputGestureText(global::System.Windows.DependencyObject d, object newValue)
		{
			if (string.IsNullOrEmpty((string)newValue))
			{
				global::Infragistics.Controls.Menus.XamMenuItem xamMenuItem = d as global::Infragistics.Controls.Menus.XamMenuItem;
				global::System.Windows.Input.RoutedCommand routedCommand = xamMenuItem.Command as global::System.Windows.Input.RoutedCommand;
				if (routedCommand != null)
				{
					global::System.Windows.Input.InputGestureCollection inputGestures = routedCommand.InputGestures;
					if (inputGestures != null && inputGestures.Count > 0)
					{
						int i = 0;
						int count = inputGestures.Count;
						while (i < count)
						{
							global::System.Windows.Input.KeyGesture keyGesture = inputGestures[i] as global::System.Windows.Input.KeyGesture;
							if (keyGesture != null)
							{
								return keyGesture.GetDisplayStringForCulture(global::System.Globalization.CultureInfo.CurrentCulture);
							}
							i++;
						}
					}
				}
			}
			return newValue;
		}

		// Token: 0x060001AF RID: 431 RVA: 0x000081C4 File Offset: 0x000063C4
		private void DirtyCanExecute()
		{
			this._canExecute = null;
			base.InvalidateMeasure();
		}

		// Token: 0x060001B0 RID: 432 RVA: 0x000081D8 File Offset: 0x000063D8
		private void ExecuteCommand()
		{
			global::System.Windows.Input.ICommand command = this.Command;
			if (command != null)
			{
				object commandParameter = this.CommandParameter;
				global::System.Windows.Input.RoutedCommand routedCommand = command as global::System.Windows.Input.RoutedCommand;
				if (routedCommand != null)
				{
					global::System.Windows.IInputElement target = this.CommandTarget ?? this;
					if (routedCommand.CanExecute(commandParameter, target))
					{
						routedCommand.Execute(commandParameter, target);
					}
					return;
				}
				if (command.CanExecute(commandParameter))
				{
					command.Execute(commandParameter);
				}
			}
		}

		// Token: 0x060001B1 RID: 433 RVA: 0x00008230 File Offset: 0x00006430
		private void GoToSubMenuClosedState()
		{
			if (this._subMenuClosedVisualState != null && this._subMenuClosedVisualState.Storyboard != null)
			{
				this._closeStoreboardInProcess = true;
				this._subMenuClosedVisualState.Storyboard.Completed += this.Storyboard_Completed;
				if (!global::System.Windows.VisualStateManager.GoToState(this, "SubmenuClose", false))
				{
					this._subMenuClosedVisualState.Storyboard.Completed -= this.Storyboard_Completed;
					return;
				}
			}
			else
			{
				this.DetachPopupHandlers();
			}
		}

		// Token: 0x060001B2 RID: 434 RVA: 0x000082A8 File Offset: 0x000064A8
		private void GoToSubMenuClosedImmediatelyState()
		{
			if (this._subMenuClosedImmediatelyVisualState != null && this._subMenuClosedImmediatelyVisualState.Storyboard != null)
			{
				this._closeImmediatelyStoreboardInProcess = true;
				this._subMenuClosedImmediatelyVisualState.Storyboard.Completed += this.Storyboard_Completed;
				if (!global::System.Windows.VisualStateManager.GoToState(this, "SubmenuCloseImmediately", false))
				{
					this._subMenuClosedImmediatelyVisualState.Storyboard.Completed -= this.Storyboard_Completed;
					return;
				}
			}
			else
			{
				this.DetachPopupHandlers();
			}
		}

		// Token: 0x060001B3 RID: 435 RVA: 0x00008320 File Offset: 0x00006520
		private static void ManupulateMousOverTopLavelHeader(bool isMouseOver, global::Infragistics.Controls.Menus.XamMenuItem item, bool expanOnHover)
		{
			if (isMouseOver)
			{
				if ((item.ParentXamMenu.CurrentOpen == null && expanOnHover) || item.ParentXamMenu._previouslyFocusedControl != null)
				{
					item.ManipulateSubmenu(true, true);
					item.ParentXamMenu.CurrentOpen = item;
				}
				else if (item.ParentXamMenu.CurrentOpen != null)
				{
					item.ParentXamMenu.CurrentOpen = item;
				}
				item.IsHighlighted = false;
				return;
			}
			if (item.IsSubmenuOpen)
			{
				item.IsHighlighted = true;
			}
		}

		// Token: 0x060001B4 RID: 436 RVA: 0x00008394 File Offset: 0x00006594
		private void DetachPopupHandlers()
		{
			if (this._dropDownPopup != null && this._dropDownPopup.Child != null)
			{
				this._dropDownPopup.Child.MouseEnter -= this.Items_MouseEnter;
				this._dropDownPopup.Child.MouseLeave -= this.Items_MouseLeave;
				(this._dropDownPopup.Child as global::System.Windows.FrameworkElement).SizeChanged -= this.Popup_SizeChanged;
			}
		}

		// Token: 0x060001B5 RID: 437 RVA: 0x00008410 File Offset: 0x00006610
		private void Storyboard_Completed(object sender, global::System.EventArgs e)
		{
			this.DetachPopupHandlers();
			if (this.IsSubmenuOpen)
			{
				this._dropDownPopup.IsOpen = false;
				this.IgnorePropertyChange = true;
				this.IsSubmenuOpen = false;
				this.IsHighlighted = false;
				this.ChangeVisualState(false);
				this.RaiseSubmenuClosedEvent();
			}
			if (this._subMenuClosedImmediatelyVisualState != null && this._subMenuClosedImmediatelyVisualState.Storyboard != null)
			{
				this._subMenuClosedImmediatelyVisualState.Storyboard.Completed -= this.Storyboard_Completed;
			}
			if (this._subMenuClosedVisualState != null && this._subMenuClosedVisualState.Storyboard != null)
			{
				this._subMenuClosedVisualState.Storyboard.Completed -= this.Storyboard_Completed;
			}
		}

		// Token: 0x060001B6 RID: 438 RVA: 0x000084BB File Offset: 0x000066BB
		private void Popup_SizeChanged(object sender, global::System.Windows.SizeChangedEventArgs e)
		{
			this.EnsureSubmenuPosition();
		}

		// Token: 0x060001B7 RID: 439 RVA: 0x000084C3 File Offset: 0x000066C3
		private void ControlIsEnabledChanged(object sender, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			this.ChangeVisualState(false);
		}

		// Token: 0x060001B8 RID: 440 RVA: 0x000084D8 File Offset: 0x000066D8
		private void FocusOrSelect()
		{
			if (this.ParentXamMenu._previouslyFocusedControl == null)
			{
				global::System.Windows.Controls.Control control = global::Infragistics.PlatformProxy.GetFocusedElement(this) as global::System.Windows.Controls.Control;
				if (!(control is global::Infragistics.Controls.Menus.XamMenuItem))
				{
					this.ParentXamMenu._previouslyFocusedControl = control;
				}
			}
			base.Dispatcher.BeginInvoke(new global::System.Action(delegate()
			{
				base.Focus();
			}), new object[0]);
			if (!this.IsSelected)
			{
				this.IsSelected = true;
			}
		}

		// Token: 0x060001B9 RID: 441 RVA: 0x00008544 File Offset: 0x00006744
		private void Items_MouseEnter(object sender, global::System.Windows.Input.MouseEventArgs e)
		{
			if (this.ParentXamMenu == null)
			{
				return;
			}
			if (this.IsInContextMenu == false)
			{
				global::Infragistics.Controls.Menus.XamMenu xamMenu = this.ParentXamMenu as global::Infragistics.Controls.Menus.XamMenu;
				if (xamMenu.ExpandOnHover)
				{
					xamMenu.StopTimer();
				}
			}
			global::Infragistics.Controls.Menus.XamMenuItem childHighlightedItem = this.ChildHighlightedItem;
			if (childHighlightedItem != null && !global::Infragistics.Controls.PresentationUtilities.IsAncestorOf(childHighlightedItem, e.OriginalSource as global::System.Windows.DependencyObject))
			{
				childHighlightedItem.ManipulateSubmenu(false, true);
			}
			if (this._closeStoreboardInProcess)
			{
				this._closeStoreboardInProcess = false;
				this._subMenuClosedVisualState.Storyboard.Completed -= this.Storyboard_Completed;
			}
			if (this._closeImmediatelyStoreboardInProcess)
			{
				this._closeImmediatelyStoreboardInProcess = false;
				this._subMenuClosedImmediatelyVisualState.Storyboard.Completed -= this.Storyboard_Completed;
			}
			this.IsMouseOverSubling = true;
		}

		// Token: 0x060001BA RID: 442 RVA: 0x00008614 File Offset: 0x00006814
		private void Items_MouseLeave(object sender, global::System.Windows.Input.MouseEventArgs e)
		{
			if (this.ParentXamMenu == null)
			{
				return;
			}
			if (this.IsInContextMenu == false)
			{
				global::Infragistics.Controls.Menus.XamMenu xamMenu = this.ParentXamMenu as global::Infragistics.Controls.Menus.XamMenu;
				if (xamMenu.ExpandOnHover)
				{
					xamMenu.StartTimer();
				}
			}
			this.IsMouseOverSubling = false;
		}

		// Token: 0x060001BB RID: 443 RVA: 0x00008668 File Offset: 0x00006868
		private void EnsureMenuItemRole()
		{
			global::Infragistics.Controls.Menus.MenuItemRole menuItemRole;
			if (base.Items.Count != 0)
			{
				if (this.ParentXamMenuItem == null && this.IsInContextMenu == false)
				{
					menuItemRole = global::Infragistics.Controls.Menus.MenuItemRole.TopLevelHeader;
				}
				else
				{
					menuItemRole = global::Infragistics.Controls.Menus.MenuItemRole.SubmenuHeader;
				}
			}
			else if (this.ParentXamMenuItem == null && this.IsInContextMenu == false)
			{
				menuItemRole = global::Infragistics.Controls.Menus.MenuItemRole.TopLevelItem;
			}
			else
			{
				menuItemRole = global::Infragistics.Controls.Menus.MenuItemRole.SubmenuItem;
			}
			base.SetValue(global::Infragistics.Controls.Menus.XamMenuItem.RoleProperty, menuItemRole);
			this.UpdateRoleState();
		}

		// Token: 0x060001BC RID: 444 RVA: 0x000086F0 File Offset: 0x000068F0
		protected virtual void UpdateRoleState()
		{
			if (this._isDesignMode)
			{
				return;
			}
			switch (this.Role)
			{
			case global::Infragistics.Controls.Menus.MenuItemRole.TopLevelItem:
				if (this.CheckBoxVisibilityResolved == global::System.Windows.Visibility.Visible || this.IconVisibilityResolved == global::System.Windows.Visibility.Visible)
				{
					global::System.Windows.VisualStateManager.GoToState(this, "TopLevelItemWithIcon", false);
					return;
				}
				global::System.Windows.VisualStateManager.GoToState(this, "TopLevelItem", false);
				return;
			case global::Infragistics.Controls.Menus.MenuItemRole.TopLevelHeader:
				if (this.CheckBoxVisibilityResolved == global::System.Windows.Visibility.Visible || this.IconVisibilityResolved == global::System.Windows.Visibility.Visible)
				{
					global::System.Windows.VisualStateManager.GoToState(this, "TopLevelHeaderWithIcon", false);
					return;
				}
				global::System.Windows.VisualStateManager.GoToState(this, "TopLevelHeader", false);
				return;
			case global::Infragistics.Controls.Menus.MenuItemRole.SubmenuItem:
				global::System.Windows.VisualStateManager.GoToState(this, "SubmenuItem", false);
				return;
			case global::Infragistics.Controls.Menus.MenuItemRole.SubmenuHeader:
				global::System.Windows.VisualStateManager.GoToState(this, "SubmenuHeader", false);
				return;
			default:
				return;
			}
		}

		// Token: 0x060001BD RID: 445 RVA: 0x00008798 File Offset: 0x00006998
		protected internal virtual void ChangeVisualState(bool useTransitions)
		{
			if (!base.IsEnabled)
			{
				global::System.Windows.VisualStateManager.GoToState(this, "Disabled", useTransitions);
				return;
			}
			if (this.IsSelected)
			{
				global::System.Windows.VisualStateManager.GoToState(this, "MouseOver", useTransitions);
				return;
			}
			if (this.IsHighlighted)
			{
				global::System.Windows.VisualStateManager.GoToState(this, "Highlighted", useTransitions);
				return;
			}
			if (this.IsMouseOver)
			{
				global::System.Windows.VisualStateManager.GoToState(this, "MouseOver", useTransitions);
				return;
			}
			global::System.Windows.VisualStateManager.GoToState(this, "Normal", useTransitions);
		}

		// Token: 0x060001BE RID: 446 RVA: 0x0000880C File Offset: 0x00006A0C
		private void EnsureSubmenuPosition()
		{
			if (this._dropDownPopup == null)
			{
				return;
			}
			if (!(this._dropDownPopup.Child is global::System.Windows.FrameworkElement))
			{
				return;
			}
			new global::System.Windows.Size(32767.0, 32767.0);
			this._dropDownPopup.HorizontalOffset = 0.0;
			this._dropDownPopup.VerticalOffset = 0.0;
		}

		// Token: 0x060001BF RID: 447 RVA: 0x00008878 File Offset: 0x00006A78
		private static void PlaceSubmenuOnPrefferedPosition(out double popupX, out double popupY, out bool below, double rootOffsetX, double rootOffsetY, double rootWidth, double rootHeight, double popupContentWidth, double popupContentHeight, double myControlWidth, double myControlHeight, global::Infragistics.Controls.Menus.MenuItemPosition prefPosition)
		{
			below = true;
			popupX = 0.0;
			popupY = 0.0;
			switch (prefPosition)
			{
			case global::Infragistics.Controls.Menus.MenuItemPosition.Top:
				popupX = global::Infragistics.Controls.Menus.XamMenuItem.DefineHorizontalOffset(rootOffsetX, rootWidth, popupContentWidth);
				popupY = rootHeight + 1.0;
				popupY = global::Infragistics.Controls.Menus.XamMenuItem.DefineTopOrBottom(popupY, ref below, rootOffsetY, rootHeight, popupContentHeight, myControlHeight);
				return;
			case global::Infragistics.Controls.Menus.MenuItemPosition.Bottom:
				popupX = global::Infragistics.Controls.Menus.XamMenuItem.DefineHorizontalOffset(rootOffsetX, rootWidth, popupContentWidth);
				popupY = rootOffsetY + myControlHeight;
				popupY = global::Infragistics.Controls.Menus.XamMenuItem.DefineTopOrBottom(popupY, ref below, rootOffsetY, rootHeight, popupContentHeight, myControlHeight);
				return;
			case global::Infragistics.Controls.Menus.MenuItemPosition.Left:
				popupX = rootOffsetX - popupContentWidth;
				if (popupX < 0.0)
				{
					popupX = 0.0;
					popupY = rootOffsetY + myControlHeight;
					popupY = global::Infragistics.Controls.Menus.XamMenuItem.DefineTopOrBottom(popupY, ref below, rootOffsetY, rootHeight, popupContentHeight, myControlHeight);
					return;
				}
				popupY = global::Infragistics.Controls.Menus.XamMenuItem.DefineVerticalOffset(rootOffsetY, rootHeight, popupContentHeight);
				return;
			case global::Infragistics.Controls.Menus.MenuItemPosition.Right:
			{
				popupX = rootOffsetX + myControlWidth;
				double num = global::Infragistics.Controls.Menus.XamMenuItem.DefineHorizontalOffset(popupX, rootWidth, popupContentWidth);
				if (popupX != num)
				{
					popupX = num;
					popupY = rootOffsetY + myControlHeight;
					popupY = global::Infragistics.Controls.Menus.XamMenuItem.DefineTopOrBottom(popupY, ref below, rootOffsetY, rootHeight, popupContentHeight, myControlHeight);
					return;
				}
				popupY = global::Infragistics.Controls.Menus.XamMenuItem.DefineVerticalOffset(rootOffsetY, rootHeight, popupContentHeight);
				return;
			}
			default:
				return;
			}
		}

		// Token: 0x060001C0 RID: 448 RVA: 0x00008994 File Offset: 0x00006B94
		private static double DefineTopOrBottom(double popupY, ref bool below, double rootOffsetY, double rootHeight, double popupContentHeight, double myControlHeight)
		{
			double num = popupY;
			if (rootHeight < num + popupContentHeight)
			{
				below = false;
				num = rootOffsetY - popupContentHeight;
				if (num <= 0.0)
				{
					if (rootOffsetY < (rootHeight - myControlHeight) / 2.0)
					{
						below = true;
						num = rootOffsetY + myControlHeight;
					}
					else
					{
						below = false;
						num = rootOffsetY - popupContentHeight;
					}
				}
			}
			return num;
		}

		// Token: 0x060001C1 RID: 449 RVA: 0x000089E4 File Offset: 0x00006BE4
		private static double DefineVerticalOffset(double rootOffsetY, double rootHeight, double popupContentHeight)
		{
			double num = rootOffsetY;
			if (rootHeight < num + popupContentHeight)
			{
				num = rootHeight - popupContentHeight;
				num = global::System.Math.Max(0.0, num);
			}
			return num;
		}

		// Token: 0x060001C2 RID: 450 RVA: 0x00008A10 File Offset: 0x00006C10
		private static double DefineVerticalAlignment(ref bool below, double rootOffsetY, double rootHeight, double popupContentHeight, double myControlHeight)
		{
			double num = rootOffsetY;
			if (rootHeight < num + popupContentHeight)
			{
				below = false;
				num = rootOffsetY + myControlHeight - popupContentHeight;
				if (num < 0.0)
				{
					if (rootOffsetY < (rootHeight - myControlHeight) / 2.0)
					{
						below = true;
						num = rootOffsetY + myControlHeight;
					}
					else
					{
						below = false;
						num = rootOffsetY - popupContentHeight;
					}
				}
			}
			return num;
		}

		// Token: 0x060001C3 RID: 451 RVA: 0x00008A60 File Offset: 0x00006C60
		private static double DefineHorizontalOffset(double refferPoint, double rootWidth, double popupContentWidth)
		{
			double num = refferPoint;
			if (rootWidth < num + popupContentWidth)
			{
				num = rootWidth - popupContentWidth;
				num = global::System.Math.Max(0.0, num);
			}
			return num;
		}

		// Token: 0x060001C4 RID: 452 RVA: 0x00008A8C File Offset: 0x00006C8C
		private static double DefineLeftOrRight(double popupX, double rootOffsetX, double rootWidth, double popupContentWidth)
		{
			bool flag;
			return global::Infragistics.Controls.Menus.XamMenuItem.DefineLeftOrRight(popupX, rootOffsetX, rootWidth, popupContentWidth, out flag);
		}

		// Token: 0x060001C5 RID: 453 RVA: 0x00008AA4 File Offset: 0x00006CA4
		private static double DefineLeftOrRight(double popupX, double rootOffsetX, double rootWidth, double popupContentWidth, out bool isOverlay)
		{
			isOverlay = false;
			double num = popupX;
			if (rootWidth < num + popupContentWidth)
			{
				num = rootOffsetX - popupContentWidth;
				if (num < 0.0)
				{
					isOverlay = true;
					num = 0.0;
				}
			}
			return num;
		}

		// Token: 0x060001C6 RID: 454 RVA: 0x00008ADC File Offset: 0x00006CDC
		private void SetDropdownPopupPlacement()
		{
			if (this._dropDownPopup == null)
			{
				return;
			}
			global::Infragistics.Controls.Menus.MenuItemPosition menuItemPosition = this.SubmenuPreferredLocation;
			if (menuItemPosition == global::Infragistics.Controls.Menus.MenuItemPosition.Auto)
			{
				global::Infragistics.Controls.Menus.XamMenu xamMenu = this.ParentXamMenu as global::Infragistics.Controls.Menus.XamMenu;
				if (xamMenu == null)
				{
					menuItemPosition = global::Infragistics.Controls.Menus.MenuItemPosition.Right;
				}
				else if (xamMenu.MenuOrientation == global::System.Windows.Controls.Orientation.Vertical)
				{
					menuItemPosition = global::Infragistics.Controls.Menus.MenuItemPosition.Right;
				}
				else
				{
					menuItemPosition = ((this.Role == global::Infragistics.Controls.Menus.MenuItemRole.TopLevelHeader) ? global::Infragistics.Controls.Menus.MenuItemPosition.Bottom : global::Infragistics.Controls.Menus.MenuItemPosition.Right);
				}
			}
			global::System.Windows.Controls.Primitives.PlacementMode placement;
			switch (menuItemPosition)
			{
			case global::Infragistics.Controls.Menus.MenuItemPosition.Top:
				placement = global::System.Windows.Controls.Primitives.PlacementMode.Top;
				break;
			case global::Infragistics.Controls.Menus.MenuItemPosition.Bottom:
				placement = global::System.Windows.Controls.Primitives.PlacementMode.Bottom;
				break;
			case global::Infragistics.Controls.Menus.MenuItemPosition.Left:
				placement = global::System.Windows.Controls.Primitives.PlacementMode.Left;
				break;
			case global::Infragistics.Controls.Menus.MenuItemPosition.Right:
				placement = global::System.Windows.Controls.Primitives.PlacementMode.Right;
				break;
			default:
				placement = global::System.Windows.Controls.Primitives.PlacementMode.Bottom;
				break;
			}
			this._dropDownPopup.Placement = placement;
		}

		// Token: 0x060001C7 RID: 455 RVA: 0x00008B68 File Offset: 0x00006D68
		private void HandleUpDownKey(bool isDown)
		{
			if (!this.IsSelected && isDown)
			{
				this.IsSelected = true;
				this.ChangeVisualState(false);
				if (!this.IsSubmenuOpen)
				{
					return;
				}
			}
			global::Infragistics.Controls.Menus.XamMenuItem menuItem;
			if (this.Role == global::Infragistics.Controls.Menus.MenuItemRole.TopLevelHeader)
			{
				if (!this.IsSubmenuOpen)
				{
					this.ManipulateSubmenu(true, true);
				}
				menuItem = this.FindSiblingItem(isDown, true);
				this.IsHighlighted = true;
			}
			else
			{
				menuItem = this.FindSiblingItem(isDown, false);
			}
			this.MoveToItem(menuItem);
		}

		// Token: 0x060001C8 RID: 456 RVA: 0x00008BD4 File Offset: 0x00006DD4
		private void HandleLeftKey()
		{
			global::Infragistics.Controls.Menus.XamMenuItem xamMenuItem = null;
			switch (this.Role)
			{
			case global::Infragistics.Controls.Menus.MenuItemRole.TopLevelItem:
			case global::Infragistics.Controls.Menus.MenuItemRole.TopLevelHeader:
				xamMenuItem = this.FindSiblingItem(false, false);
				if (xamMenuItem != null)
				{
					if (xamMenuItem.Role == global::Infragistics.Controls.Menus.MenuItemRole.TopLevelHeader)
					{
						xamMenuItem.ManipulateSubmenu(true, true);
					}
					else
					{
						this.ManipulateSubmenu(false, true);
					}
				}
				break;
			case global::Infragistics.Controls.Menus.MenuItemRole.SubmenuItem:
			case global::Infragistics.Controls.Menus.MenuItemRole.SubmenuHeader:
				xamMenuItem = this.ParentXamMenuItem;
				if (xamMenuItem == null)
				{
					return;
				}
				xamMenuItem.ManipulateSubmenu(false, true);
				if (xamMenuItem.Role == global::Infragistics.Controls.Menus.MenuItemRole.TopLevelHeader)
				{
					xamMenuItem = this.ParentXamMenuItem.FindSiblingItem(false, false);
					if (xamMenuItem != null)
					{
						if (xamMenuItem.Role == global::Infragistics.Controls.Menus.MenuItemRole.TopLevelHeader)
						{
							xamMenuItem.ManipulateSubmenu(true, true);
						}
						this.ParentXamMenuItem.IsHighlighted = false;
						this.ParentXamMenuItem.ChangeVisualState(false);
					}
				}
				break;
			}
			this.MoveToItem(xamMenuItem);
		}

		// Token: 0x060001C9 RID: 457 RVA: 0x00008C88 File Offset: 0x00006E88
		private void HandleRightKey()
		{
			global::Infragistics.Controls.Menus.XamMenuItem xamMenuItem = null;
			switch (this.Role)
			{
			case global::Infragistics.Controls.Menus.MenuItemRole.TopLevelItem:
			case global::Infragistics.Controls.Menus.MenuItemRole.TopLevelHeader:
				xamMenuItem = this.FindSiblingItem(true, false);
				if (xamMenuItem != null)
				{
					if (xamMenuItem.Role == global::Infragistics.Controls.Menus.MenuItemRole.TopLevelHeader)
					{
						xamMenuItem.ManipulateSubmenu(true, true);
					}
					else
					{
						this.ManipulateSubmenu(false, true);
					}
				}
				break;
			case global::Infragistics.Controls.Menus.MenuItemRole.SubmenuItem:
				if (this.ParentXamMenu.CurrentOpen == null)
				{
					return;
				}
				xamMenuItem = this.ParentXamMenu.CurrentOpen.FindSiblingItem(true, false);
				if (xamMenuItem != null)
				{
					if (xamMenuItem.Role == global::Infragistics.Controls.Menus.MenuItemRole.TopLevelHeader)
					{
						xamMenuItem.ManipulateSubmenu(true, true);
					}
					else if (xamMenuItem.Role == global::Infragistics.Controls.Menus.MenuItemRole.TopLevelItem)
					{
						this.ParentXamMenu.CloseCurrentOpen();
					}
				}
				break;
			case global::Infragistics.Controls.Menus.MenuItemRole.SubmenuHeader:
				this.ManipulateSubmenu(true, true);
				xamMenuItem = this.FindSiblingItem(true, true);
				if (xamMenuItem != null)
				{
					this.IsHighlighted = true;
				}
				break;
			}
			this.MoveToItem(xamMenuItem);
		}

		// Token: 0x060001CA RID: 458 RVA: 0x00008D50 File Offset: 0x00006F50
		private void MoveToItem(global::Infragistics.Controls.Menus.XamMenuItem menuItem)
		{
			if (menuItem != null)
			{
				menuItem.FocusOrSelect();
				menuItem.ChangeVisualState(false);
				this.ChangeVisualState(false);
				if (this.ParentXamMenuItem != null)
				{
					this.ParentXamMenuItem.HeaderedItemContainerGenerator.ScrollIntoView(menuItem);
				}
			}
		}

		// Token: 0x060001CB RID: 459 RVA: 0x00008D84 File Offset: 0x00006F84
		private void HandleItemSelection()
		{
			if (this.ParentXamMenuItem != null)
			{
				this.ParentXamMenuItem.IgnoreMouseUp = true;
			}
			if (this.IgnoreMouseUp)
			{
				this.IgnoreMouseUp = false;
				return;
			}
			if (this.ParentXamMenu == null)
			{
				return;
			}
			if (this.IsCheckable)
			{
				this.IsChecked = !this.IsChecked;
			}
			this.RaiseClickEvent();
			if (this.Role == global::Infragistics.Controls.Menus.MenuItemRole.SubmenuItem)
			{
				if (this.ParentXamMenu != null && !this.StaysOpenOnClick)
				{
					this.ParentXamMenu.ReturnFocus();
					this.IsMouseOver = false;
				}
				else
				{
					base.Focus();
					if (!this.StaysOpenOnClick)
					{
						this.IsMouseOver = false;
					}
				}
			}
			if (this.Role == global::Infragistics.Controls.Menus.MenuItemRole.TopLevelItem && this.ParentXamMenu != null)
			{
				this.ParentXamMenu.ReturnFocus();
			}
			if (this._hasMouseCapture && !this.StaysOpenOnClick)
			{
				base.ReleaseMouseCapture();
				this._hasMouseCapture = false;
			}
		}

		// Token: 0x060001CC RID: 460 RVA: 0x00008E56 File Offset: 0x00007056
		private void HandleAccessKeyPressed(object sender, global::System.Windows.Input.AccessKeyPressedEventArgs e)
		{
			if (e.Scope == null && e.Target == null)
			{
				if (string.IsNullOrEmpty(e.Key))
				{
					return;
				}
				e.Target = this;
				e.Handled = true;
			}
		}

		// Token: 0x060001CD RID: 461 RVA: 0x00008E84 File Offset: 0x00007084
		private void VerifyCanExecute()
		{
			global::System.Windows.Input.ICommand command = this.Command;
			if (command == null)
			{
				this._canExecute = new bool?(true);
			}
			else if (command is global::System.Windows.Input.RoutedCommand)
			{
				global::System.Windows.Input.RoutedCommand routedCommand = command as global::System.Windows.Input.RoutedCommand;
				this._canExecute = new bool?(routedCommand.CanExecute(this.CommandParameter, this.CommandTarget ?? this));
			}
			else
			{
				this._canExecute = new bool?(command.CanExecute(this.CommandParameter));
			}
			base.CoerceValue(global::System.Windows.UIElement.IsEnabledProperty);
		}

		// Token: 0x14000006 RID: 6
		// (add) Token: 0x060001CE RID: 462 RVA: 0x00008F00 File Offset: 0x00007100
		// (remove) Token: 0x060001CF RID: 463 RVA: 0x00008F38 File Offset: 0x00007138
		public event global::System.EventHandler Click;

		// Token: 0x14000007 RID: 7
		// (add) Token: 0x060001D0 RID: 464 RVA: 0x00008F70 File Offset: 0x00007170
		// (remove) Token: 0x060001D1 RID: 465 RVA: 0x00008FA8 File Offset: 0x000071A8
		public event global::System.EventHandler Checked;

		// Token: 0x14000008 RID: 8
		// (add) Token: 0x060001D2 RID: 466 RVA: 0x00008FE0 File Offset: 0x000071E0
		// (remove) Token: 0x060001D3 RID: 467 RVA: 0x00009018 File Offset: 0x00007218
		public event global::System.EventHandler Unchecked;

		// Token: 0x14000009 RID: 9
		// (add) Token: 0x060001D4 RID: 468 RVA: 0x00009050 File Offset: 0x00007250
		// (remove) Token: 0x060001D5 RID: 469 RVA: 0x00009088 File Offset: 0x00007288
		public event global::System.EventHandler SubmenuClosed;

		// Token: 0x1400000A RID: 10
		// (add) Token: 0x060001D6 RID: 470 RVA: 0x000090C0 File Offset: 0x000072C0
		// (remove) Token: 0x060001D7 RID: 471 RVA: 0x000090F8 File Offset: 0x000072F8
		public event global::System.EventHandler SubmenuOpened;

		// Token: 0x17000059 RID: 89
		// (get) Token: 0x060001D8 RID: 472 RVA: 0x0000912D File Offset: 0x0000732D
		// (set) Token: 0x060001D9 RID: 473 RVA: 0x0000913F File Offset: 0x0000733F
		public global::System.Windows.Controls.Control NavigationElement
		{
			get
			{
				return (global::System.Windows.Controls.Control)base.GetValue(global::Infragistics.Controls.Menus.XamMenuItem.NavigationElementProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Menus.XamMenuItem.NavigationElementProperty, value);
			}
		}

		// Token: 0x060001DA RID: 474 RVA: 0x00009150 File Offset: 0x00007350
		private static void NavigationElementChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Menus.XamMenuItem xamMenuItem = obj as global::Infragistics.Controls.Menus.XamMenuItem;
			xamMenuItem._navigator.NavigationElement = (e.NewValue as global::System.Windows.Controls.Control);
		}

		// Token: 0x1700005A RID: 90
		// (get) Token: 0x060001DB RID: 475 RVA: 0x0000917B File Offset: 0x0000737B
		// (set) Token: 0x060001DC RID: 476 RVA: 0x0000918D File Offset: 0x0000738D
		[global::System.ComponentModel.TypeConverter(typeof(global::System.UriTypeConverter))]
		public global::System.Uri NavigationUri
		{
			get
			{
				return (global::System.Uri)base.GetValue(global::Infragistics.Controls.Menus.XamMenuItem.NavigationUriProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Menus.XamMenuItem.NavigationUriProperty, value);
			}
		}

		// Token: 0x060001DD RID: 477 RVA: 0x0000919C File Offset: 0x0000739C
		private static void NavigationUriChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Menus.XamMenuItem xamMenuItem = obj as global::Infragistics.Controls.Menus.XamMenuItem;
			xamMenuItem._navigator.NavigationUri = (e.NewValue as global::System.Uri);
		}

		// Token: 0x1700005B RID: 91
		// (get) Token: 0x060001DE RID: 478 RVA: 0x000091C7 File Offset: 0x000073C7
		// (set) Token: 0x060001DF RID: 479 RVA: 0x000091D9 File Offset: 0x000073D9
		public string NavigationParameter
		{
			get
			{
				return (string)base.GetValue(global::Infragistics.Controls.Menus.XamMenuItem.NavigationParameterProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Menus.XamMenuItem.NavigationParameterProperty, value);
			}
		}

		// Token: 0x060001E0 RID: 480 RVA: 0x000091E8 File Offset: 0x000073E8
		private static void NavigationParameterChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Menus.XamMenuItem xamMenuItem = obj as global::Infragistics.Controls.Menus.XamMenuItem;
			xamMenuItem._navigator.NavigationParameter = ((e.NewValue != null) ? e.NewValue.ToString() : "");
		}

		// Token: 0x1700005C RID: 92
		// (get) Token: 0x060001E1 RID: 481 RVA: 0x00009223 File Offset: 0x00007423
		// (set) Token: 0x060001E2 RID: 482 RVA: 0x00009235 File Offset: 0x00007435
		public bool NavigationOnClick
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.Controls.Menus.XamMenuItem.NavigationOnClickProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Menus.XamMenuItem.NavigationOnClickProperty, value);
			}
		}

		// Token: 0x060001E3 RID: 483 RVA: 0x00009248 File Offset: 0x00007448
		private void XamMenuItem_Unloaded(object sender, global::System.Windows.RoutedEventArgs e)
		{
			this.Storyboard_Completed(this, global::System.EventArgs.Empty);
		}

		// Token: 0x1400000B RID: 11
		// (add) Token: 0x060001E4 RID: 484 RVA: 0x00009258 File Offset: 0x00007458
		// (remove) Token: 0x060001E5 RID: 485 RVA: 0x00009290 File Offset: 0x00007490
		public event global::System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

		// Token: 0x060001E6 RID: 486 RVA: 0x000092C5 File Offset: 0x000074C5
		protected virtual void OnPropertyChanged(string name)
		{
			if (this.PropertyChanged != null)
			{
				this.PropertyChanged(this, new global::System.ComponentModel.PropertyChangedEventArgs(name));
			}
		}

		// Token: 0x1700005D RID: 93
		// (get) Token: 0x060001E7 RID: 487 RVA: 0x000092E1 File Offset: 0x000074E1
		global::System.Windows.Input.ICommand global::System.Windows.Input.ICommandSource.Command
		{
			get
			{
				return this.Command;
			}
		}

		// Token: 0x1700005E RID: 94
		// (get) Token: 0x060001E8 RID: 488 RVA: 0x000092E9 File Offset: 0x000074E9
		object global::System.Windows.Input.ICommandSource.CommandParameter
		{
			get
			{
				return this.CommandParameter;
			}
		}

		// Token: 0x1700005F RID: 95
		// (get) Token: 0x060001E9 RID: 489 RVA: 0x000092F1 File Offset: 0x000074F1
		global::System.Windows.IInputElement global::System.Windows.Input.ICommandSource.CommandTarget
		{
			get
			{
				return this.CommandTarget;
			}
		}

		// Token: 0x17000060 RID: 96
		// (get) Token: 0x060001EA RID: 490 RVA: 0x000092F9 File Offset: 0x000074F9
		global::System.Windows.DependencyObject global::Infragistics.IProvideParent.Parent
		{
			get
			{
				return this._parentItemsControl;
			}
		}

		// Token: 0x0400006B RID: 107
		private const string CommonStatesGroupName = "CommonStates";

		// Token: 0x0400006C RID: 108
		private const string MouseOver = "MouseOver";

		// Token: 0x0400006D RID: 109
		private const string Normal = "Normal";

		// Token: 0x0400006E RID: 110
		private const string Highlighted = "Highlighted";

		// Token: 0x0400006F RID: 111
		private const string Disabled = "Disabled";

		// Token: 0x04000070 RID: 112
		private const string SubmenuStateGroupName = "SubmenuState";

		// Token: 0x04000071 RID: 113
		private const string SubmenuOpen = "SubmenuOpen";

		// Token: 0x04000072 RID: 114
		private const string SubmenuOpenImmediately = "SubmenuOpenImmediately";

		// Token: 0x04000073 RID: 115
		private const string SubmenuClose = "SubmenuClose";

		// Token: 0x04000074 RID: 116
		private const string SubmenuCloseImmediately = "SubmenuCloseImmediately";

		// Token: 0x04000075 RID: 117
		private const string MenuItemRoleGroupName = "MenuItemRole";

		// Token: 0x04000076 RID: 118
		private const string TopLevelHeader = "TopLevelHeader";

		// Token: 0x04000077 RID: 119
		private const string TopLevelHeaderWithIcon = "TopLevelHeaderWithIcon";

		// Token: 0x04000078 RID: 120
		private const string SubmenuHeader = "SubmenuHeader";

		// Token: 0x04000079 RID: 121
		private const string SubmenuItem = "SubmenuItem";

		// Token: 0x0400007A RID: 122
		private const string TopLevelItem = "TopLevelItem";

		// Token: 0x0400007B RID: 123
		private const string TopLevelItemWithIcon = "TopLevelItemWithIcon";

		// Token: 0x0400007C RID: 124
		private const string Popup = "Popup";

		// Token: 0x0400007D RID: 125
		private const string ScrollViewer = "ScrollViewer";

		// Token: 0x0400007E RID: 126
		private const double MAX_POPUPHEIGHT_FROM_ROOTHEIGHT = 0.97;

		// Token: 0x0400007F RID: 127
		private global::System.Windows.Controls.ItemsControl _parentItemsControl;

		// Token: 0x04000080 RID: 128
		private global::System.Windows.Controls.Primitives.Popup _dropDownPopup;

		// Token: 0x04000081 RID: 129
		private global::System.Windows.Controls.ScrollViewer _scrollViewer;

		// Token: 0x04000082 RID: 130
		private bool _isImmediately = true;

		// Token: 0x04000083 RID: 131
		private bool _isMenuOrientationNotSet;

		// Token: 0x04000084 RID: 132
		private bool _hasMouseCapture;

		// Token: 0x04000085 RID: 133
		private global::System.Windows.Controls.ContentControl _headerIconPresenter;

		// Token: 0x04000086 RID: 134
		private bool _closeStoreboardInProcess;

		// Token: 0x04000087 RID: 135
		private bool _closeImmediatelyStoreboardInProcess;

		// Token: 0x04000088 RID: 136
		private bool _isDesignMode;

		// Token: 0x04000089 RID: 137
		private global::System.Windows.VisualState _subMenuClosedVisualState;

		// Token: 0x0400008A RID: 138
		private global::System.Windows.VisualState _subMenuClosedImmediatelyVisualState;

		// Token: 0x0400008B RID: 139
		private bool _skipCloseUnselected;

		// Token: 0x0400008C RID: 140
		private bool? _canExecute = new bool?(true);

		// Token: 0x0400008D RID: 141
		private global::Infragistics.WeakEventHandler<global::Infragistics.Controls.Menus.XamMenuItem, global::System.Windows.Input.ICommand, global::System.EventArgs> _weakCanExecuteChanged;

		// Token: 0x0400008E RID: 142
		private global::System.EventHandler _menuCanExecuteHandler;

		// Token: 0x0400008F RID: 143
		public static readonly global::System.Windows.DependencyProperty CommandProperty = global::Infragistics.DependencyPropertyUtilities.Register("Command", typeof(global::System.Windows.Input.ICommand), typeof(global::Infragistics.Controls.Menus.XamMenuItem), global::Infragistics.DependencyPropertyUtilities.CreateMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Menus.XamMenuItem.OnCommandChanged)));

		// Token: 0x04000090 RID: 144
		public static readonly global::System.Windows.DependencyProperty CommandParameterProperty = global::Infragistics.DependencyPropertyUtilities.Register("CommandParameter", typeof(object), typeof(global::Infragistics.Controls.Menus.XamMenuItem), global::Infragistics.DependencyPropertyUtilities.CreateMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Menus.XamMenuItem.OnCommandParameterChanged)));

		// Token: 0x04000091 RID: 145
		public static readonly global::System.Windows.DependencyProperty CommandTargetProperty = global::Infragistics.DependencyPropertyUtilities.Register("CommandTarget", typeof(global::System.Windows.IInputElement), typeof(global::Infragistics.Controls.Menus.XamMenuItem), global::Infragistics.DependencyPropertyUtilities.CreateMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Menus.XamMenuItem.OnCommandTargetChanged)));

		// Token: 0x04000092 RID: 146
		public static readonly global::System.Windows.DependencyProperty IsKeyboardNavigableProperty = global::System.Windows.DependencyProperty.Register("IsKeyboardNavigable", typeof(bool), typeof(global::Infragistics.Controls.Menus.XamMenuItem), new global::System.Windows.PropertyMetadata(true));

		// Token: 0x04000093 RID: 147
		public static readonly global::System.Windows.DependencyProperty CheckBoxVisibilityResolvedProperty = global::System.Windows.DependencyProperty.Register("CheckBoxVisibilityResolved", typeof(global::System.Windows.Visibility), typeof(global::Infragistics.Controls.Menus.XamMenuItem), new global::System.Windows.PropertyMetadata(global::System.Windows.Visibility.Collapsed));

		// Token: 0x04000094 RID: 148
		public static readonly global::System.Windows.DependencyProperty IconProperty = global::System.Windows.DependencyProperty.Register("Icon", typeof(object), typeof(global::Infragistics.Controls.Menus.XamMenuItem), new global::System.Windows.PropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Menus.XamMenuItem.IconChanged)));

		// Token: 0x04000095 RID: 149
		public static readonly global::System.Windows.DependencyProperty IconVisibilityResolvedProperty = global::System.Windows.DependencyProperty.Register("IconVisibilityResolved", typeof(global::System.Windows.Visibility), typeof(global::Infragistics.Controls.Menus.XamMenuItem), new global::System.Windows.PropertyMetadata(global::System.Windows.Visibility.Collapsed));

		// Token: 0x04000096 RID: 150
		public static readonly global::System.Windows.DependencyProperty InputGestureTextProperty = global::System.Windows.DependencyProperty.Register("InputGestureText", typeof(string), typeof(global::Infragistics.Controls.Menus.XamMenuItem), new global::System.Windows.FrameworkPropertyMetadata(null, null, new global::System.Windows.CoerceValueCallback(global::Infragistics.Controls.Menus.XamMenuItem.CoerceInputGestureText)));

		// Token: 0x04000097 RID: 151
		public static readonly global::System.Windows.DependencyProperty IsCheckableProperty = global::System.Windows.DependencyProperty.Register("IsCheckable", typeof(bool), typeof(global::Infragistics.Controls.Menus.XamMenuItem), new global::System.Windows.PropertyMetadata(false, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Menus.XamMenuItem.IsCheckableChanged)));

		// Token: 0x04000098 RID: 152
		public static readonly global::System.Windows.DependencyProperty IsCheckedProperty = global::System.Windows.DependencyProperty.Register("IsChecked", typeof(bool), typeof(global::Infragistics.Controls.Menus.XamMenuItem), new global::System.Windows.PropertyMetadata(false, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Menus.XamMenuItem.IsCheckedChanged)));

		// Token: 0x04000099 RID: 153
		public static readonly global::System.Windows.DependencyProperty IsHighlightedProperty = global::System.Windows.DependencyProperty.Register("IsHighlighted", typeof(bool), typeof(global::Infragistics.Controls.Menus.XamMenuItem), new global::System.Windows.PropertyMetadata(false, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Menus.XamMenuItem.IsHighlightedChanged)));

		// Token: 0x0400009A RID: 154
		public static readonly global::System.Windows.DependencyProperty IsSubmenuOpenProperty = global::System.Windows.DependencyProperty.Register("IsSubmenuOpen", typeof(bool), typeof(global::Infragistics.Controls.Menus.XamMenuItem), new global::System.Windows.PropertyMetadata(false, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Menus.XamMenuItem.IsSubmenuOpenChanged)));

		// Token: 0x0400009B RID: 155
		public static readonly global::System.Windows.DependencyProperty MenuOrientationProperty = global::System.Windows.DependencyProperty.Register("MenuOrientation", typeof(global::System.Windows.Controls.Orientation), typeof(global::Infragistics.Controls.Menus.XamMenuItem), new global::System.Windows.PropertyMetadata(global::System.Windows.Controls.Orientation.Vertical, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Menus.XamMenuItem.MenuOrientationChanged)));

		// Token: 0x0400009C RID: 156
		public static readonly global::System.Windows.DependencyProperty HasChildrenProperty = global::System.Windows.DependencyProperty.Register("HasChildren", typeof(bool), typeof(global::Infragistics.Controls.Menus.XamMenuItem), new global::System.Windows.PropertyMetadata(false));

		// Token: 0x0400009D RID: 157
		public static readonly global::System.Windows.DependencyProperty SubmenuPreferredLocationProperty = global::System.Windows.DependencyProperty.Register("SubmenuPreferredLocation", typeof(global::Infragistics.Controls.Menus.MenuItemPosition), typeof(global::Infragistics.Controls.Menus.XamMenuItem), new global::System.Windows.PropertyMetadata(global::Infragistics.Controls.Menus.MenuItemPosition.Auto, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Menus.XamMenuItem.SubmenuPreferredLocationChanged)));

		// Token: 0x0400009E RID: 158
		public static readonly global::System.Windows.DependencyProperty StaysOpenOnClickProperty = global::System.Windows.DependencyProperty.Register("StaysOpenOnClick", typeof(bool), typeof(global::Infragistics.Controls.Menus.XamMenuItem), new global::System.Windows.PropertyMetadata(false));

		// Token: 0x0400009F RID: 159
		protected static readonly global::System.Windows.DependencyProperty RoleProperty = global::System.Windows.DependencyProperty.Register("Role", typeof(global::Infragistics.Controls.Menus.MenuItemRole), typeof(global::Infragistics.Controls.Menus.XamMenuItem), new global::System.Windows.PropertyMetadata(global::Infragistics.Controls.Menus.MenuItemRole.SubmenuItem, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Menus.XamMenuItem.RoleChanged)));

		// Token: 0x040000A0 RID: 160
		internal static readonly global::System.Windows.DependencyProperty IsSelectedProperty = global::System.Windows.DependencyProperty.Register("IsSelected", typeof(bool), typeof(global::Infragistics.Controls.Menus.XamMenuItem), new global::System.Windows.PropertyMetadata(false, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Menus.XamMenuItem.IsSelectedChanged)));

		// Token: 0x040000A1 RID: 161
		internal new static readonly global::System.Windows.DependencyProperty IsMouseOverProperty = global::System.Windows.DependencyProperty.Register("IsMouseOver", typeof(bool), typeof(global::Infragistics.Controls.Menus.XamMenuItem), new global::System.Windows.PropertyMetadata(false, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Menus.XamMenuItem.IsMouseOverChanged)));

		// Token: 0x040000A2 RID: 162
		internal static readonly global::System.Windows.DependencyProperty IsMouseOverSublingProperty = global::System.Windows.DependencyProperty.Register("IsMouseOverSubling", typeof(bool), typeof(global::Infragistics.Controls.Menus.XamMenuItem), new global::System.Windows.PropertyMetadata(false, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Menus.XamMenuItem.IsMouseOverSublingChanged)));

		// Token: 0x040000A8 RID: 168
		private global::Infragistics.INavigation _navigator;

		// Token: 0x040000A9 RID: 169
		public static readonly global::System.Windows.DependencyProperty NavigationElementProperty = global::System.Windows.DependencyProperty.Register("NavigationElement", typeof(global::System.Windows.Controls.Control), typeof(global::Infragistics.Controls.Menus.XamMenuItem), new global::System.Windows.PropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Menus.XamMenuItem.NavigationElementChanged)));

		// Token: 0x040000AA RID: 170
		public static readonly global::System.Windows.DependencyProperty NavigationUriProperty = global::System.Windows.DependencyProperty.Register("NavigationUri", typeof(global::System.Uri), typeof(global::Infragistics.Controls.Menus.XamMenuItem), new global::System.Windows.PropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Menus.XamMenuItem.NavigationUriChanged)));

		// Token: 0x040000AB RID: 171
		public static readonly global::System.Windows.DependencyProperty NavigationParameterProperty = global::System.Windows.DependencyProperty.Register("NavigationParameter", typeof(string), typeof(global::Infragistics.Controls.Menus.XamMenuItem), new global::System.Windows.PropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Menus.XamMenuItem.NavigationParameterChanged)));

		// Token: 0x040000AC RID: 172
		public static readonly global::System.Windows.DependencyProperty NavigationOnClickProperty = global::System.Windows.DependencyProperty.Register("NavigationOnClick", typeof(bool), typeof(global::Infragistics.Controls.Menus.XamMenuItem), new global::System.Windows.PropertyMetadata(false));
	}
}
