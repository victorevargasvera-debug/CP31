using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows;
using System.Windows.Automation.Peers;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Input;
using System.Windows.Media;
using Infragistics.AutomationPeers;
using Infragistics.Controls.Menus.Primitives;
using Infragistics.Themes;
using Infragistics.Windows;
using Infragistics.Windows.Licensing;

namespace Infragistics.Controls.Menus
{
	// Token: 0x0200001C RID: 28
	[global::Infragistics.Windows.Licensing.UltraLicense("XamContextMenu", global::Infragistics.Windows.Licensing.UltraLicenseAttribute.WpfProductType.DV | global::Infragistics.Windows.Licensing.UltraLicenseAttribute.WpfProductType.LOB)]
	[global::System.ComponentModel.LicenseProvider(typeof(global::Infragistics.Windows.Licensing.UltraLicenseProvider))]
	public class XamContextMenu : global::Infragistics.Controls.Menus.XamMenuBase, global::Infragistics.ICommandTarget
	{
		// Token: 0x060000C9 RID: 201 RVA: 0x000041DC File Offset: 0x000023DC
		static XamContextMenu()
		{
			global::System.Windows.Style style = new global::System.Windows.Style();
			style.Seal();
			global::System.Windows.FrameworkElement.FocusVisualStyleProperty.OverrideMetadata(typeof(global::Infragistics.Controls.Menus.XamContextMenu), new global::System.Windows.FrameworkPropertyMetadata(style));
			global::Infragistics.Themes.ThemeManager.RegisterControl(typeof(global::Infragistics.Controls.Menus.XamContextMenu));
		}

		// Token: 0x060000CA RID: 202 RVA: 0x00004464 File Offset: 0x00002664
		public XamContextMenu()
		{
			base.DefaultStyleKey = typeof(global::Infragistics.Controls.Menus.XamContextMenu);
			this._zoomTransform = new global::System.Windows.Media.ScaleTransform
			{
				ScaleX = 1.0,
				ScaleY = 1.0,
				CenterX = 0.0,
				CenterY = 0.0
			};
			this._contextMenuPopup = new global::System.Windows.Controls.Primitives.Popup
			{
				RenderTransform = this._zoomTransform
			};
			this._contextMenuPopup.StaysOpen = false;
			this._contextMenuPopup.Opened += this.Popup_Opened;
			this._contextMenuPopup.Closed += this.Popup_Closed;
			base.SizeChanged += this.XamContextMenu_SizeChanged;
			global::Infragistics.CommandSourceManager.RegisterCommandTarget(this);
			global::Infragistics.CommandSourceManager.NotifyCanExecuteChanged(typeof(global::Infragistics.Controls.Menus.Primitives.OpenCommand));
			global::Infragistics.CommandSourceManager.NotifyCanExecuteChanged(typeof(global::Infragistics.Controls.Menus.Primitives.CloseCommand));
			global::Infragistics.Windows.Utilities.ValidateLicense(typeof(global::Infragistics.Controls.Menus.XamContextMenu), this);
		}

		// Token: 0x060000CB RID: 203 RVA: 0x0000456A File Offset: 0x0000276A
		protected override global::System.Windows.Automation.Peers.AutomationPeer OnCreateAutomationPeer()
		{
			return new global::Infragistics.AutomationPeers.XamContextMenuAutomationPeer(this);
		}

		// Token: 0x060000CC RID: 204 RVA: 0x00004572 File Offset: 0x00002772
		protected override void OnItemClicked(global::Infragistics.Controls.Menus.ItemClickedEventArgs e)
		{
			if (!e.Item.IsSubmenuOpen && !e.Item.StaysOpenOnClick)
			{
				this.IsOpen = false;
			}
			base.OnItemClicked(e);
		}

		// Token: 0x060000CD RID: 205 RVA: 0x0000459C File Offset: 0x0000279C
		protected override void OnLostFocus(global::System.Windows.RoutedEventArgs e)
		{
			base.OnLostFocus(e);
			if (this.IsOpen)
			{
				global::System.Windows.FrameworkElement element = global::Infragistics.PlatformProxy.GetFocusedElement(this) as global::System.Windows.FrameworkElement;
				if (!this.IsChild(element))
				{
					this.IsOpen = false;
				}
			}
		}

		// Token: 0x060000CE RID: 206 RVA: 0x000045D4 File Offset: 0x000027D4
		internal override void CloseCurrentOpen()
		{
			base.CloseCurrentOpen();
			this.IsOpen = false;
			if (this.IsOpen)
			{
				this._focusedControl = this._previouslyFocusedControl;
				this._previouslyFocusedControl = null;
			}
		}

		// Token: 0x060000CF RID: 207 RVA: 0x00004600 File Offset: 0x00002800
		protected override void OnBeforeUnload()
		{
			foreach (object item in ((global::System.Collections.IEnumerable)base.Items))
			{
				global::Infragistics.Controls.Menus.XamMenuItem xamMenuItem = base.ItemContainerGenerator.ContainerFromItem(item) as global::Infragistics.Controls.Menus.XamMenuItem;
				if (xamMenuItem != null)
				{
					xamMenuItem.UnloadSubmenu();
				}
			}
		}

		// Token: 0x060000D0 RID: 208 RVA: 0x00004668 File Offset: 0x00002868
		protected override void OnKeyDown(global::System.Windows.Input.KeyEventArgs e)
		{
			if (e.Key == global::System.Windows.Input.Key.Escape)
			{
				this.CloseCurrentOpen();
				base.ClearPreviouslyFocusedControl();
			}
			base.OnKeyDown(e);
		}

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x060000D1 RID: 209 RVA: 0x00004688 File Offset: 0x00002888
		protected override global::System.Collections.Generic.List<string> PropertiesToIgnore
		{
			get
			{
				global::System.Collections.Generic.List<string> propertiesToIgnore = base.PropertiesToIgnore;
				propertiesToIgnore.Add("PlacementTarget");
				return propertiesToIgnore;
			}
		}

		// Token: 0x060000D2 RID: 210 RVA: 0x000046A8 File Offset: 0x000028A8
		private static void OnIsOpenChanged(global::System.Windows.DependencyObject target, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Menus.XamContextMenu xamContextMenu = target as global::Infragistics.Controls.Menus.XamContextMenu;
			if (xamContextMenu != null)
			{
				if (!xamContextMenu.ResolveIsOpenChange(e))
				{
					return;
				}
				if ((bool)e.NewValue)
				{
					xamContextMenu.OnContextMenuOpened();
				}
				else
				{
					xamContextMenu.OnContextMenuClosed();
				}
			}
			global::Infragistics.CommandSourceManager.NotifyCanExecuteChanged(typeof(global::Infragistics.Controls.Menus.Primitives.OpenCommand));
			global::Infragistics.CommandSourceManager.NotifyCanExecuteChanged(typeof(global::Infragistics.Controls.Menus.Primitives.CloseCommand));
		}

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x060000D3 RID: 211 RVA: 0x00004703 File Offset: 0x00002903
		// (set) Token: 0x060000D4 RID: 212 RVA: 0x00004715 File Offset: 0x00002915
		public bool IsOpen
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.Controls.Menus.XamContextMenu.IsOpenProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Menus.XamContextMenu.IsOpenProperty, value);
			}
		}

		// Token: 0x060000D5 RID: 213 RVA: 0x00004728 File Offset: 0x00002928
		private static void OnPlacementChanged(global::System.Windows.DependencyObject target, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Menus.XamContextMenu xamContextMenu = target as global::Infragistics.Controls.Menus.XamContextMenu;
			if (!xamContextMenu._preventPlacementChangeEvent && xamContextMenu != null && xamContextMenu.IsOpen)
			{
				xamContextMenu.SetPosition();
			}
		}

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x060000D6 RID: 214 RVA: 0x00004755 File Offset: 0x00002955
		// (set) Token: 0x060000D7 RID: 215 RVA: 0x00004767 File Offset: 0x00002967
		public global::Infragistics.Controls.Menus.PlacementMode Placement
		{
			get
			{
				return (global::Infragistics.Controls.Menus.PlacementMode)base.GetValue(global::Infragistics.Controls.Menus.XamContextMenu.PlacementProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Menus.XamContextMenu.PlacementProperty, value);
			}
		}

		// Token: 0x060000D8 RID: 216 RVA: 0x0000477C File Offset: 0x0000297C
		private static void OnPlacementTargetChanged(global::System.Windows.DependencyObject target, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Menus.XamContextMenu xamContextMenu = target as global::Infragistics.Controls.Menus.XamContextMenu;
			if (xamContextMenu != null && xamContextMenu.IsOpen)
			{
				xamContextMenu.SetPosition();
			}
		}

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x060000D9 RID: 217 RVA: 0x000047A1 File Offset: 0x000029A1
		// (set) Token: 0x060000DA RID: 218 RVA: 0x000047B3 File Offset: 0x000029B3
		public global::System.Windows.UIElement PlacementTarget
		{
			get
			{
				return (global::System.Windows.UIElement)base.GetValue(global::Infragistics.Controls.Menus.XamContextMenu.PlacementTargetProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Menus.XamContextMenu.PlacementTargetProperty, value);
			}
		}

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x060000DB RID: 219 RVA: 0x000047C4 File Offset: 0x000029C4
		public global::System.Windows.UIElement PlacementTargetResolved
		{
			get
			{
				global::System.Windows.UIElement uielement = this.PlacementTarget ?? (this.GetBindingValue(global::Infragistics.Controls.Menus.XamContextMenu.PlacementTargetProperty) as global::System.Windows.UIElement);
				return uielement ?? this.ParentElement;
			}
		}

		// Token: 0x060000DC RID: 220 RVA: 0x000047F8 File Offset: 0x000029F8
		private static void OnPlacementRectangleChanged(global::System.Windows.DependencyObject target, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Menus.XamContextMenu xamContextMenu = target as global::Infragistics.Controls.Menus.XamContextMenu;
			if (xamContextMenu != null && xamContextMenu.IsOpen)
			{
				xamContextMenu.SetPosition();
			}
		}

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x060000DD RID: 221 RVA: 0x0000481D File Offset: 0x00002A1D
		// (set) Token: 0x060000DE RID: 222 RVA: 0x0000482F File Offset: 0x00002A2F
		public global::System.Windows.Rect PlacementRectangle
		{
			get
			{
				return (global::System.Windows.Rect)base.GetValue(global::Infragistics.Controls.Menus.XamContextMenu.PlacementRectangleProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Menus.XamContextMenu.PlacementRectangleProperty, value);
			}
		}

		// Token: 0x060000DF RID: 223 RVA: 0x00004844 File Offset: 0x00002A44
		private static void OnHorizontalOffsetChanged(global::System.Windows.DependencyObject target, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Menus.XamContextMenu xamContextMenu = target as global::Infragistics.Controls.Menus.XamContextMenu;
			if (xamContextMenu != null)
			{
				xamContextMenu.SetPosition();
			}
		}

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x060000E0 RID: 224 RVA: 0x00004861 File Offset: 0x00002A61
		// (set) Token: 0x060000E1 RID: 225 RVA: 0x00004873 File Offset: 0x00002A73
		public double HorizontalOffset
		{
			get
			{
				return (double)base.GetValue(global::Infragistics.Controls.Menus.XamContextMenu.HorizontalOffsetProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Menus.XamContextMenu.HorizontalOffsetProperty, value);
			}
		}

		// Token: 0x060000E2 RID: 226 RVA: 0x00004888 File Offset: 0x00002A88
		private static void OnVerticalOffsetChanged(global::System.Windows.DependencyObject target, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Menus.XamContextMenu xamContextMenu = target as global::Infragistics.Controls.Menus.XamContextMenu;
			if (xamContextMenu != null)
			{
				xamContextMenu.SetPosition();
			}
		}

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x060000E3 RID: 227 RVA: 0x000048A5 File Offset: 0x00002AA5
		// (set) Token: 0x060000E4 RID: 228 RVA: 0x000048B7 File Offset: 0x00002AB7
		public double VerticalOffset
		{
			get
			{
				return (double)base.GetValue(global::Infragistics.Controls.Menus.XamContextMenu.VerticalOffsetProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Menus.XamContextMenu.VerticalOffsetProperty, value);
			}
		}

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x060000E5 RID: 229 RVA: 0x000048CA File Offset: 0x00002ACA
		// (set) Token: 0x060000E6 RID: 230 RVA: 0x000048D2 File Offset: 0x00002AD2
		public global::System.Windows.Point MouseClickLocation
		{
			get
			{
				return this._mouseClickLocation;
			}
			internal set
			{
				this._mouseClickLocation = value;
			}
		}

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x060000E7 RID: 231 RVA: 0x000048DC File Offset: 0x00002ADC
		// (set) Token: 0x060000E8 RID: 232 RVA: 0x000049B3 File Offset: 0x00002BB3
		public global::System.Windows.Point ContextMenuLocation
		{
			get
			{
				if (this.IsOpen && this.ParentElement != null && this._contextMenuPopup.IsOpen)
				{
					global::System.Windows.FrameworkElement frameworkElement = global::Infragistics.PlatformProxy.GetRootVisual(this.ParentElement) as global::System.Windows.FrameworkElement;
					if (frameworkElement == null)
					{
						frameworkElement = (global::Infragistics.PlatformProxy.GetRootParent(this.ParentElement) as global::System.Windows.FrameworkElement);
					}
					if (frameworkElement != null)
					{
						global::System.Windows.Controls.Primitives.Popup popup = frameworkElement as global::System.Windows.Controls.Primitives.Popup;
						if (popup != null)
						{
							frameworkElement = (popup.Child as global::System.Windows.FrameworkElement);
						}
						if (frameworkElement != null && !(frameworkElement is global::System.Windows.Controls.Primitives.Popup))
						{
							global::System.Windows.Point point = new global::System.Windows.Point(0.0, 0.0);
							global::System.Windows.Point result = base.PointToScreen(point);
							point = frameworkElement.PointToScreen(point);
							result.X -= point.X;
							result.Y -= point.Y;
							return result;
						}
					}
				}
				return this._contextMenuLocation;
			}
			internal set
			{
				this._contextMenuLocation = value;
				this._contextMenuPopup.HorizontalOffset = value.X;
				this._contextMenuPopup.VerticalOffset = value.Y;
			}
		}

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x060000E9 RID: 233 RVA: 0x000049E0 File Offset: 0x00002BE0
		// (set) Token: 0x060000EA RID: 234 RVA: 0x000049F2 File Offset: 0x00002BF2
		public bool ShouldRightClickBeHandled
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.Controls.Menus.XamContextMenu.ShouldRightClickBeHandledProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Menus.XamContextMenu.ShouldRightClickBeHandledProperty, value);
			}
		}

		// Token: 0x060000EB RID: 235 RVA: 0x00004A05 File Offset: 0x00002C05
		private static void ShouldRightClickBeHandledChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
		}

		// Token: 0x060000EC RID: 236 RVA: 0x00004A08 File Offset: 0x00002C08
		private static void OnPopupParentChanged(global::System.Windows.DependencyObject target, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Menus.XamContextMenu xamContextMenu = target as global::Infragistics.Controls.Menus.XamContextMenu;
			global::System.Windows.Controls.Panel panel = e.OldValue as global::System.Windows.Controls.Panel;
			global::System.Windows.Controls.Panel panel2 = e.NewValue as global::System.Windows.Controls.Panel;
			if (panel != null)
			{
				panel.Children.Remove(xamContextMenu._contextMenuPopup);
			}
			if (panel2 != null)
			{
				panel2.Children.Add(xamContextMenu._contextMenuPopup);
			}
		}

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x060000ED RID: 237 RVA: 0x00004A5F File Offset: 0x00002C5F
		// (set) Token: 0x060000EE RID: 238 RVA: 0x00004A71 File Offset: 0x00002C71
		public global::System.Windows.Controls.Panel PopupParent
		{
			get
			{
				return (global::System.Windows.Controls.Panel)base.GetValue(global::Infragistics.Controls.Menus.XamContextMenu.PopupParentProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Menus.XamContextMenu.PopupParentProperty, value);
			}
		}

		// Token: 0x060000EF RID: 239 RVA: 0x00004A80 File Offset: 0x00002C80
		private static void OnAllowsTransparencyChanged(global::System.Windows.DependencyObject target, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Menus.XamContextMenu xamContextMenu = target as global::Infragistics.Controls.Menus.XamContextMenu;
			if (xamContextMenu != null && xamContextMenu._contextMenuPopup != null)
			{
				xamContextMenu._contextMenuPopup.AllowsTransparency = (bool)e.NewValue;
			}
		}

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x060000F0 RID: 240 RVA: 0x00004AB6 File Offset: 0x00002CB6
		// (set) Token: 0x060000F1 RID: 241 RVA: 0x00004AC8 File Offset: 0x00002CC8
		public bool AllowsTransparency
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.Controls.Menus.XamContextMenu.AllowsTransparencyProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Menus.XamContextMenu.AllowsTransparencyProperty, value);
			}
		}

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x060000F2 RID: 242 RVA: 0x00004ADB File Offset: 0x00002CDB
		// (set) Token: 0x060000F3 RID: 243 RVA: 0x00004B04 File Offset: 0x00002D04
		internal global::System.Windows.UIElement ParentElement
		{
			get
			{
				if (this._targetElement != null && this._targetElement.IsAlive)
				{
					return this._targetElement.Target as global::System.Windows.UIElement;
				}
				return null;
			}
			set
			{
				this._targetElement = new global::System.WeakReference(value);
			}
		}

		// Token: 0x17000037 RID: 55
		// (get) Token: 0x060000F4 RID: 244 RVA: 0x00004B12 File Offset: 0x00002D12
		// (set) Token: 0x060000F5 RID: 245 RVA: 0x00004B1A File Offset: 0x00002D1A
		internal bool IsCancelled { get; set; }

		// Token: 0x060000F6 RID: 246 RVA: 0x00004B23 File Offset: 0x00002D23
		protected virtual void OnOpening(global::Infragistics.Controls.Menus.OpeningEventArgs args)
		{
			if (this.Opening != null)
			{
				this.Opening(this, args);
			}
		}

		// Token: 0x060000F7 RID: 247 RVA: 0x00004B3A File Offset: 0x00002D3A
		protected virtual void OnClosing(global::Infragistics.CancellableEventArgs args)
		{
			if (this.Closing != null)
			{
				this.Closing(this, args);
			}
		}

		// Token: 0x060000F8 RID: 248 RVA: 0x00004B51 File Offset: 0x00002D51
		protected virtual void OnClosed(global::System.EventArgs args)
		{
			if (this.Closed != null)
			{
				this.Closed(this, args);
			}
		}

		// Token: 0x060000F9 RID: 249 RVA: 0x00004B68 File Offset: 0x00002D68
		protected virtual void OnOpened(global::Infragistics.Controls.Menus.OpenedEventArgs args)
		{
			if (this.Opened != null)
			{
				this.Opened(this, args);
			}
		}

		// Token: 0x060000FA RID: 250 RVA: 0x00004B80 File Offset: 0x00002D80
		internal global::System.Collections.Generic.List<T> GetClickedElements<T>() where T : global::System.Windows.UIElement
		{
			global::System.Collections.Generic.List<T> list = new global::System.Collections.Generic.List<T>();
			global::System.Windows.UIElement parentElement = this.ParentElement;
			global::System.Windows.UIElement rootVisual = global::Infragistics.PlatformProxy.GetRootVisual(this.ParentElement);
			global::System.Windows.Point point = rootVisual.TranslatePoint(this.MouseClickLocation, this.ParentElement);
			global::System.Collections.Generic.IEnumerable<global::System.Windows.UIElement> elementsFromPoint = global::Infragistics.PlatformProxy.GetElementsFromPoint(point, this.ParentElement);
			if (elementsFromPoint == null)
			{
				return null;
			}
			if (elementsFromPoint.GetEnumerator().MoveNext())
			{
				foreach (global::System.Windows.UIElement uielement in elementsFromPoint)
				{
					T t = uielement as T;
					if (t != null)
					{
						list.Insert(0, t);
					}
				}
			}
			return list;
		}

		// Token: 0x060000FB RID: 251 RVA: 0x00004C34 File Offset: 0x00002E34
		internal void OpenInternal()
		{
			if (this.IsClickPlacement(this.Placement))
			{
				bool flag = this.IsClickPlacement(this.Placement);
				this._preventPlacementChangeEvent = true;
				global::Infragistics.Controls.Menus.PlacementMode placement = this.Placement;
				if (flag)
				{
					this.Placement = global::Infragistics.Controls.Menus.PlacementMode.Center;
				}
				this.IsOpen = true;
				if (flag)
				{
					this.Placement = placement;
				}
				this._preventPlacementChangeEvent = false;
				return;
			}
			this.IsOpen = true;
		}

		// Token: 0x060000FC RID: 252 RVA: 0x00004C94 File Offset: 0x00002E94
		private bool ResolveIsOpenChange(global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			if (this._skipIsOpenChange)
			{
				this._skipIsOpenChange = false;
				return false;
			}
			global::Infragistics.Controls.Menus.OpeningEventArgs openingEventArgs = new global::Infragistics.Controls.Menus.OpeningEventArgs(this, this.MouseClickLocation);
			if (this.ParentElement != null)
			{
				if ((bool)e.NewValue)
				{
					this.OnOpening(openingEventArgs);
				}
				else
				{
					this.OnClosing(openingEventArgs);
					if (this._popupInitiatedClose)
					{
						openingEventArgs.Cancel = false;
					}
				}
			}
			else
			{
				openingEventArgs.Cancel = this.IsOpen;
			}
			this.IsCancelled = openingEventArgs.Cancel;
			if (openingEventArgs.Cancel)
			{
				this._skipIsOpenChange = true;
				base.SetValue(global::Infragistics.Controls.Menus.XamContextMenu.IsOpenProperty, e.OldValue);
				return false;
			}
			if (!object.Equals(base.GetValue(global::Infragistics.Controls.Menus.XamContextMenu.IsOpenProperty), e.NewValue))
			{
				this._skipIsOpenChange = true;
				base.SetValue(global::Infragistics.Controls.Menus.XamContextMenu.IsOpenProperty, e.NewValue);
			}
			return true;
		}

		// Token: 0x060000FD RID: 253 RVA: 0x00004D64 File Offset: 0x00002F64
		private void OnContextMenuOpened()
		{
			this._previouslyFocusedControl = (global::Infragistics.PlatformProxy.GetFocusedElement(this) as global::System.Windows.Controls.Control);
			base.IsEnabled = true;
			if (!this._contextMenuPopup.IsOpen)
			{
				this.AddContextMenuToPopup();
				base.Measure(new global::System.Windows.Size(double.MaxValue, double.MaxValue));
				this.SetPopupPosition();
				this._contextMenuPopup.IsOpen = true;
				global::Infragistics.Controls.Menus.ContextMenuService.OnContextMenuOpened(this);
				global::System.Windows.Input.Mouse.Capture(this, global::System.Windows.Input.CaptureMode.SubTree);
			}
			foreach (object item in ((global::System.Collections.IEnumerable)base.Items))
			{
				global::Infragistics.Controls.Menus.XamMenuItem xamMenuItem = base.ItemContainerGenerator.ContainerFromItem(item) as global::Infragistics.Controls.Menus.XamMenuItem;
				if (xamMenuItem != null)
				{
					xamMenuItem.IsSelected = false;
					xamMenuItem.IsMouseOver = false;
					xamMenuItem.IsHighlighted = false;
					xamMenuItem.ChangeVisualState(false);
				}
			}
		}

		// Token: 0x060000FE RID: 254 RVA: 0x00004E4C File Offset: 0x0000304C
		private void HookAllOpenPopups()
		{
		}

		// Token: 0x060000FF RID: 255 RVA: 0x00004E4E File Offset: 0x0000304E
		private void UnHookAllOpenPopups()
		{
		}

		// Token: 0x06000100 RID: 256 RVA: 0x00004E50 File Offset: 0x00003050
		private void AddContextMenuToPopup()
		{
			this.RemoveContextMenuFromPopup();
			global::System.Windows.Controls.Grid grid = new global::System.Windows.Controls.Grid();
			this._contextMenuPopup.Child = grid;
			grid.Children.Add(this);
			grid.UpdateLayout();
		}

		// Token: 0x06000101 RID: 257 RVA: 0x00004E88 File Offset: 0x00003088
		private void RemoveContextMenuFromPopup()
		{
			global::System.Windows.Controls.Grid grid = this._contextMenuPopup.Child as global::System.Windows.Controls.Grid;
			if (grid != null)
			{
				grid.Children.Clear();
				this._contextMenuPopup.Child = null;
			}
		}

		// Token: 0x06000102 RID: 258 RVA: 0x00004EC0 File Offset: 0x000030C0
		private void OnContextMenuClosed()
		{
			bool popupInitiatedClose = this._popupInitiatedClose;
			if (this._contextMenuPopup.IsOpen || popupInitiatedClose)
			{
				if (this.IsChild(global::Infragistics.PlatformProxy.GetFocusedElement(this) as global::System.Windows.FrameworkElement))
				{
					if (this._previouslyFocusedControl == null)
					{
						this._previouslyFocusedControl = this._focusedControl;
						this._focusedControl = null;
					}
					base.ReturnFocus();
				}
				this._previouslyFocusedControl = null;
				foreach (object item in ((global::System.Collections.IEnumerable)base.Items))
				{
					global::Infragistics.Controls.Menus.XamMenuItem xamMenuItem = base.ItemContainerGenerator.ContainerFromItem(item) as global::Infragistics.Controls.Menus.XamMenuItem;
					if (xamMenuItem != null && xamMenuItem.IsSubmenuOpen)
					{
						xamMenuItem.CloseSubmenu(true);
					}
				}
				this.RemoveContextMenuFromPopup();
				global::System.Windows.Input.Mouse.Capture(null);
				this._contextMenuPopup.Child = null;
				this._contextMenuPopup.IsOpen = false;
				global::Infragistics.Controls.Menus.ContextMenuService.OnContextMenuClosed(this);
			}
			this.OnClosed(global::System.EventArgs.Empty);
		}

		// Token: 0x06000103 RID: 259 RVA: 0x00004FC4 File Offset: 0x000031C4
		private bool IsChild(global::System.Windows.FrameworkElement element)
		{
			return global::Infragistics.Controls.Menus.XamMenuBase.IsObjectFromMenu(this, element);
		}

		// Token: 0x06000104 RID: 260 RVA: 0x00004FCD File Offset: 0x000031CD
		private bool IsChildOfParentElement(global::System.Windows.DependencyObject element)
		{
			while (element != null)
			{
				if (this.ParentElement == element)
				{
					return true;
				}
				element = global::Infragistics.Controls.Menus.XamMenuBase.GetParent(element);
			}
			return false;
		}

		// Token: 0x06000105 RID: 261 RVA: 0x00004FE8 File Offset: 0x000031E8
		private double GetActualWidth()
		{
			if (base.ActualWidth <= 0.0)
			{
				return base.DesiredSize.Width;
			}
			return base.ActualWidth;
		}

		// Token: 0x06000106 RID: 262 RVA: 0x0000501C File Offset: 0x0000321C
		private double GetActualHeight()
		{
			if (base.ActualHeight <= 0.0)
			{
				return base.DesiredSize.Height;
			}
			return base.ActualHeight;
		}

		// Token: 0x06000107 RID: 263 RVA: 0x00005050 File Offset: 0x00003250
		private void SetPopupPosition()
		{
			double zoomFactor = global::Infragistics.PlatformProxy.GetZoomFactor();
			global::System.Windows.Size size = global::Infragistics.PlatformProxy.ResolveContainerSize();
			double num = size.Width;
			double num2 = size.Height;
			bool flag = zoomFactor > 0.0 && !global::Infragistics.PlatformProxy.IsVersionSupported("4.0");
			if (flag)
			{
				num /= zoomFactor;
				num2 /= zoomFactor;
			}
			else if (zoomFactor != 1.0)
			{
				num /= zoomFactor;
				num2 /= zoomFactor;
			}
			global::System.Windows.FrameworkElement frameworkElement = global::Infragistics.PlatformProxy.GetRootVisual(this) as global::System.Windows.FrameworkElement;
			if (frameworkElement == null)
			{
				frameworkElement = (global::Infragistics.PlatformProxy.GetRootVisual(this.ParentElement) as global::System.Windows.FrameworkElement);
			}
			global::System.Windows.Rect targetRect = this.GetTargetRect();
			global::System.Windows.Point contextMenuLocation = this.AlignToRect(targetRect, frameworkElement);
			global::System.Windows.FrameworkElement frameworkElement2 = this.ParentElement as global::System.Windows.FrameworkElement;
			if (frameworkElement2 != null && this.Placement == global::Infragistics.Controls.Menus.PlacementMode.MouseClick && global::System.Windows.FrameworkElement.GetFlowDirection(frameworkElement2) == global::System.Windows.FlowDirection.RightToLeft)
			{
				contextMenuLocation.X = frameworkElement2.ActualWidth - contextMenuLocation.X;
			}
			this.ContextMenuLocation = contextMenuLocation;
			this._skipPopupEvents = (this._contextMenuPopup.IsOpen && !base.IsMouseCaptured);
			if (this._skipPopupEvents)
			{
				this._contextMenuPopup.IsOpen = false;
				this._contextMenuPopup.IsOpen = true;
				global::System.Windows.Input.Mouse.Capture(this, global::System.Windows.Input.CaptureMode.SubTree);
				this._skipPopupEvents = false;
			}
			this._mustSetPosition = false;
			if (flag)
			{
				this._zoomTransform.ScaleX = (this._zoomTransform.ScaleY = zoomFactor);
			}
		}

		// Token: 0x06000108 RID: 264 RVA: 0x000051A6 File Offset: 0x000033A6
		private void SetPosition()
		{
			if (this.IsOpen)
			{
				this.SetPopupPosition();
			}
		}

		// Token: 0x06000109 RID: 265 RVA: 0x000051B8 File Offset: 0x000033B8
		private global::System.Windows.Point AlignToRect(global::System.Windows.Rect rect, global::System.Windows.FrameworkElement root)
		{
			double num = this.HorizontalOffset;
			double num2 = this.VerticalOffset;
			double actualWidth = this.GetActualWidth();
			double actualHeight = this.GetActualHeight();
			if (!rect.IsEmpty)
			{
				bool flag = root != null && root.FlowDirection == global::System.Windows.FlowDirection.RightToLeft;
				global::System.Windows.FlowDirection flowDirection = base.FlowDirection;
				switch (this.Placement)
				{
				case global::Infragistics.Controls.Menus.PlacementMode.AlignedAbove:
					if (flag)
					{
						num = rect.Right - actualWidth;
					}
					else
					{
						num += rect.Left;
					}
					num2 += rect.Top - actualHeight;
					goto IL_220;
				case global::Infragistics.Controls.Menus.PlacementMode.AlignedBelow:
					if (flag)
					{
						num += rect.Right - actualWidth;
					}
					else
					{
						num += rect.Left;
					}
					num2 += rect.Bottom;
					goto IL_220;
				case global::Infragistics.Controls.Menus.PlacementMode.AlignedToTheLeft:
					if (flag)
					{
						num += rect.Right;
					}
					else
					{
						num += rect.Left - actualWidth;
					}
					num2 += rect.Top;
					goto IL_220;
				case global::Infragistics.Controls.Menus.PlacementMode.AlignedToTheRight:
					if (flag)
					{
						num += rect.Left - actualWidth;
					}
					else
					{
						num += rect.Right;
					}
					num2 += rect.Top;
					goto IL_220;
				case global::Infragistics.Controls.Menus.PlacementMode.Center:
					num += (rect.Left + rect.Right - actualWidth) / 2.0;
					num2 += (rect.Top + rect.Bottom - actualHeight) / 2.0;
					goto IL_220;
				case global::Infragistics.Controls.Menus.PlacementMode.AlignedTop:
					if (flag)
					{
						num = rect.Right - actualWidth;
					}
					else
					{
						num += rect.Left;
					}
					num2 += rect.Top;
					goto IL_220;
				case global::Infragistics.Controls.Menus.PlacementMode.AlignedBottom:
					if (flag)
					{
						num = rect.Right - actualWidth;
					}
					else
					{
						num += rect.Left;
					}
					num2 += rect.Bottom - actualHeight;
					goto IL_220;
				case global::Infragistics.Controls.Menus.PlacementMode.AlignedLeft:
					if (flag)
					{
						num += rect.Right - actualWidth;
					}
					else
					{
						num += rect.Left;
					}
					num2 += rect.Top;
					goto IL_220;
				case global::Infragistics.Controls.Menus.PlacementMode.AlignedRight:
					if (flag)
					{
						num += rect.Left;
					}
					else
					{
						num += rect.Right - actualWidth;
					}
					num2 += rect.Top;
					goto IL_220;
				}
				num += rect.Left;
				num2 += rect.Top;
				IL_220:
				if (global::System.Windows.SystemParameters.IsMenuDropRightAligned && this.Placement != global::Infragistics.Controls.Menus.PlacementMode.MouseClick)
				{
					num += actualWidth;
				}
			}
			return new global::System.Windows.Point(num, num2);
		}

		// Token: 0x0600010A RID: 266 RVA: 0x00005400 File Offset: 0x00003600
		private global::System.Windows.Point AlignToScreen(global::System.Windows.Rect menu, global::System.Windows.Rect screen, global::System.Windows.Rect target, global::System.Windows.FrameworkElement root)
		{
			if (base.FlowDirection == global::System.Windows.FlowDirection.LeftToRight)
			{
				if (menu.Width >= screen.Width)
				{
					menu.X = screen.X;
				}
				else
				{
					if (menu.Left < screen.Left)
					{
						menu.X = screen.X;
					}
					if (menu.Right > screen.Right)
					{
						if (this.IsClickPlacement(this.Placement))
						{
							menu.X -= menu.Width - target.Width;
						}
						else
						{
							menu.X -= menu.Right - screen.Right;
						}
					}
					if (menu.X < screen.X)
					{
						menu.X = screen.X;
					}
					if (menu.Right > screen.Right)
					{
						menu.X -= menu.Right - screen.Right;
					}
				}
			}
			else if (menu.Width >= screen.Width)
			{
				menu.X = screen.Right;
			}
			else if (menu.Left < screen.Left)
			{
				menu.X = screen.Right;
			}
			else if (menu.Left < screen.Left)
			{
				if (this.IsClickPlacement(this.Placement))
				{
					menu.X -= menu.Width - target.Width;
				}
				else
				{
					menu.X -= screen.Left - menu.Left;
				}
			}
			else if (menu.X - menu.Width < screen.Left)
			{
				menu.X += menu.Width - menu.X;
			}
			if (menu.Height >= screen.Height)
			{
				menu.Y = screen.Y;
			}
			else
			{
				if (menu.Top < screen.Top)
				{
					menu.Y = screen.Y;
				}
				if (menu.Bottom > screen.Bottom)
				{
					if (this.IsClickPlacement(this.Placement))
					{
						menu.Y -= menu.Height - target.Height;
					}
					else
					{
						menu.Y -= menu.Bottom - screen.Bottom;
					}
				}
				if (menu.Top < screen.Top)
				{
					menu.Y = screen.Y;
				}
				if (menu.Bottom > screen.Bottom)
				{
					menu.Y -= menu.Bottom - screen.Bottom;
				}
			}
			return new global::System.Windows.Point(menu.Left, menu.Top);
		}

		// Token: 0x0600010B RID: 267 RVA: 0x000056D6 File Offset: 0x000038D6
		private bool IsClickPlacement(global::Infragistics.Controls.Menus.PlacementMode placementMode)
		{
			return this.Placement == global::Infragistics.Controls.Menus.PlacementMode.MouseClick;
		}

		// Token: 0x0600010C RID: 268 RVA: 0x000056E4 File Offset: 0x000038E4
		private global::System.Windows.Rect GetTargetRect()
		{
			global::System.Windows.Rect result = global::System.Windows.Rect.Empty;
			global::System.Windows.UIElement placementTargetResolved = this.PlacementTargetResolved;
			if (placementTargetResolved != null)
			{
				result = global::Infragistics.Controls.Menus.ContextMenuService.GetBounds(placementTargetResolved);
				if (!this.PlacementRectangle.IsEmpty)
				{
					result.X += this.PlacementRectangle.Left;
					result.Y += this.PlacementRectangle.Top;
					result.Width = this.PlacementRectangle.Width;
					result.Height = this.PlacementRectangle.Height;
				}
			}
			if (this.Placement == global::Infragistics.Controls.Menus.PlacementMode.MouseClick)
			{
				result.X = this.MouseClickLocation.X - result.X;
				result.Y = this.MouseClickLocation.Y - result.Y;
			}
			else
			{
				result.X = 0.0;
				result.Y = 0.0;
			}
			this._contextMenuPopup.PlacementTarget = placementTargetResolved;
			this._contextMenuPopup.Placement = global::System.Windows.Controls.Primitives.PlacementMode.Relative;
			this._contextMenuPopup.PlacementRectangle = this.PlacementRectangle;
			return result;
		}

		// Token: 0x0600010D RID: 269 RVA: 0x00005810 File Offset: 0x00003A10
		private object GetBindingValue(global::System.Windows.DependencyProperty property)
		{
			global::System.Windows.Data.BindingExpression bindingExpression = base.GetBindingExpression(property);
			global::System.Windows.FrameworkElement frameworkElement = this.ParentElement as global::System.Windows.FrameworkElement;
			if (bindingExpression != null && frameworkElement != null)
			{
				global::System.Windows.Data.Binding parentBinding = bindingExpression.ParentBinding;
				frameworkElement.SetBinding(global::Infragistics.Controls.Menus.XamContextMenu.BindingHelperProperty, parentBinding);
				return frameworkElement.GetValue(global::Infragistics.Controls.Menus.XamContextMenu.BindingHelperProperty);
			}
			return null;
		}

		// Token: 0x14000002 RID: 2
		// (add) Token: 0x0600010E RID: 270 RVA: 0x00005858 File Offset: 0x00003A58
		// (remove) Token: 0x0600010F RID: 271 RVA: 0x00005890 File Offset: 0x00003A90
		public event global::System.EventHandler<global::Infragistics.Controls.Menus.OpeningEventArgs> Opening;

		// Token: 0x14000003 RID: 3
		// (add) Token: 0x06000110 RID: 272 RVA: 0x000058C8 File Offset: 0x00003AC8
		// (remove) Token: 0x06000111 RID: 273 RVA: 0x00005900 File Offset: 0x00003B00
		public event global::System.EventHandler<global::Infragistics.Controls.Menus.OpenedEventArgs> Opened;

		// Token: 0x14000004 RID: 4
		// (add) Token: 0x06000112 RID: 274 RVA: 0x00005938 File Offset: 0x00003B38
		// (remove) Token: 0x06000113 RID: 275 RVA: 0x00005970 File Offset: 0x00003B70
		public event global::System.EventHandler<global::Infragistics.CancellableEventArgs> Closing;

		// Token: 0x14000005 RID: 5
		// (add) Token: 0x06000114 RID: 276 RVA: 0x000059A8 File Offset: 0x00003BA8
		// (remove) Token: 0x06000115 RID: 277 RVA: 0x000059E0 File Offset: 0x00003BE0
		public event global::System.EventHandler<global::System.EventArgs> Closed;

		// Token: 0x06000116 RID: 278 RVA: 0x00005A15 File Offset: 0x00003C15
		private void Popup_Closed(object sender, global::System.EventArgs e)
		{
			if (this._skipPopupEvents)
			{
				return;
			}
			if (this.IsOpen)
			{
				this._popupInitiatedClose = true;
				this.CloseCurrentOpen();
				this._popupInitiatedClose = false;
			}
			this._mustSetPosition = false;
		}

		// Token: 0x06000117 RID: 279 RVA: 0x00005A44 File Offset: 0x00003C44
		private void Popup_Opened(object sender, global::System.EventArgs e)
		{
			if (this._skipPopupEvents)
			{
				return;
			}
			if (this.GetActualHeight() < 1.0)
			{
				base.Measure(new global::System.Windows.Size(double.PositiveInfinity, double.PositiveInfinity));
				this._mustSetPosition = true;
			}
			this.SetPopupPosition();
			this.OnOpened(new global::Infragistics.Controls.Menus.OpenedEventArgs(this, this.MouseClickLocation, this.ContextMenuLocation));
			if (base.Items.Count > 0)
			{
				global::Infragistics.Controls.Menus.XamMenuItem xamMenuItem = base.ItemContainerGenerator.ContainerFromIndex(0) as global::Infragistics.Controls.Menus.XamMenuItem;
				if (xamMenuItem != null)
				{
					if (xamMenuItem.IsEnabled)
					{
						xamMenuItem.Focus();
						return;
					}
					xamMenuItem = xamMenuItem.FindSiblingItem(true, false);
					if (xamMenuItem != null)
					{
						xamMenuItem.Focus();
					}
				}
			}
		}

		// Token: 0x06000118 RID: 280 RVA: 0x00005AF3 File Offset: 0x00003CF3
		private void XamContextMenu_SizeChanged(object sender, global::System.Windows.SizeChangedEventArgs e)
		{
			if (this._mustSetPosition && this._contextMenuPopup.IsOpen)
			{
				this.SetPopupPosition();
			}
		}

		// Token: 0x06000119 RID: 281 RVA: 0x00005B10 File Offset: 0x00003D10
		protected virtual object GetParameter(global::Infragistics.Controls.CommandSource source)
		{
			if (source.Command is global::Infragistics.Controls.Menus.Primitives.XamContextMenuCommandBase)
			{
				return this;
			}
			return null;
		}

		// Token: 0x0600011A RID: 282 RVA: 0x00005B22 File Offset: 0x00003D22
		protected virtual bool SupportsCommand(global::System.Windows.Input.ICommand command)
		{
			return command is global::Infragistics.Controls.Menus.Primitives.XamContextMenuCommandBase;
		}

		// Token: 0x0600011B RID: 283 RVA: 0x00005B2D File Offset: 0x00003D2D
		bool global::Infragistics.ICommandTarget.SupportsCommand(global::System.Windows.Input.ICommand command)
		{
			return this.SupportsCommand(command);
		}

		// Token: 0x0600011C RID: 284 RVA: 0x00005B36 File Offset: 0x00003D36
		object global::Infragistics.ICommandTarget.GetParameter(global::Infragistics.Controls.CommandSource source)
		{
			return this.GetParameter(source);
		}

		// Token: 0x04000048 RID: 72
		private const global::Infragistics.Controls.Menus.PlacementMode PlacementModeDefaultValue = global::Infragistics.Controls.Menus.PlacementMode.MouseClick;

		// Token: 0x04000049 RID: 73
		private global::System.Windows.Controls.Primitives.Popup _contextMenuPopup;

		// Token: 0x0400004A RID: 74
		private global::System.Windows.Point _contextMenuLocation;

		// Token: 0x0400004B RID: 75
		private global::System.Windows.Point _mouseClickLocation;

		// Token: 0x0400004C RID: 76
		private bool _skipIsOpenChange;

		// Token: 0x0400004D RID: 77
		private global::System.WeakReference _targetElement;

		// Token: 0x0400004E RID: 78
		private bool _mustSetPosition;

		// Token: 0x0400004F RID: 79
		private global::System.Windows.Controls.Control _focusedControl;

		// Token: 0x04000050 RID: 80
		private global::System.Windows.Media.ScaleTransform _zoomTransform;

		// Token: 0x04000051 RID: 81
		private bool _preventPlacementChangeEvent;

		// Token: 0x04000052 RID: 82
		private bool _skipPopupEvents;

		// Token: 0x04000053 RID: 83
		private bool _popupInitiatedClose;

		// Token: 0x04000054 RID: 84
		public static readonly global::System.Windows.DependencyProperty IsOpenProperty = global::System.Windows.DependencyProperty.Register("IsOpen", typeof(bool), typeof(global::Infragistics.Controls.Menus.XamContextMenu), new global::System.Windows.PropertyMetadata(false, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Menus.XamContextMenu.OnIsOpenChanged)));

		// Token: 0x04000055 RID: 85
		public static readonly global::System.Windows.DependencyProperty PlacementProperty = global::System.Windows.DependencyProperty.Register("Placement", typeof(global::Infragistics.Controls.Menus.PlacementMode), typeof(global::Infragistics.Controls.Menus.XamContextMenu), new global::System.Windows.PropertyMetadata(global::Infragistics.Controls.Menus.PlacementMode.MouseClick, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Menus.XamContextMenu.OnPlacementChanged)));

		// Token: 0x04000056 RID: 86
		public static readonly global::System.Windows.DependencyProperty PlacementTargetProperty = global::System.Windows.DependencyProperty.Register("PlacementTarget", typeof(global::System.Windows.UIElement), typeof(global::Infragistics.Controls.Menus.XamContextMenu), new global::System.Windows.PropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Menus.XamContextMenu.OnPlacementTargetChanged)));

		// Token: 0x04000057 RID: 87
		public static readonly global::System.Windows.DependencyProperty PlacementRectangleProperty = global::System.Windows.DependencyProperty.Register("PlacementRectangle", typeof(global::System.Windows.Rect), typeof(global::Infragistics.Controls.Menus.XamContextMenu), new global::System.Windows.PropertyMetadata(global::System.Windows.Rect.Empty, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Menus.XamContextMenu.OnPlacementRectangleChanged)));

		// Token: 0x04000058 RID: 88
		public static readonly global::System.Windows.DependencyProperty HorizontalOffsetProperty = global::System.Windows.DependencyProperty.Register("HorizontalOffset", typeof(double), typeof(global::Infragistics.Controls.Menus.XamContextMenu), new global::System.Windows.PropertyMetadata(0.0, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Menus.XamContextMenu.OnHorizontalOffsetChanged)));

		// Token: 0x04000059 RID: 89
		public static readonly global::System.Windows.DependencyProperty VerticalOffsetProperty = global::System.Windows.DependencyProperty.Register("VerticalOffset", typeof(double), typeof(global::Infragistics.Controls.Menus.XamContextMenu), new global::System.Windows.PropertyMetadata(0.0, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Menus.XamContextMenu.OnVerticalOffsetChanged)));

		// Token: 0x0400005A RID: 90
		public static readonly global::System.Windows.DependencyProperty ShouldRightClickBeHandledProperty = global::System.Windows.DependencyProperty.Register("ShouldRightClickBeHandled", typeof(bool), typeof(global::Infragistics.Controls.Menus.XamContextMenu), new global::System.Windows.PropertyMetadata(true, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Menus.XamContextMenu.ShouldRightClickBeHandledChanged)));

		// Token: 0x0400005B RID: 91
		public static readonly global::System.Windows.DependencyProperty PopupParentProperty = global::System.Windows.DependencyProperty.Register("PopupParent", typeof(global::System.Windows.Controls.Panel), typeof(global::Infragistics.Controls.Menus.XamContextMenu), new global::System.Windows.PropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Menus.XamContextMenu.OnPopupParentChanged)));

		// Token: 0x0400005C RID: 92
		public static readonly global::System.Windows.DependencyProperty AllowsTransparencyProperty = global::System.Windows.DependencyProperty.Register("AllowsTransparency", typeof(bool), typeof(global::Infragistics.Controls.Menus.XamContextMenu), new global::System.Windows.PropertyMetadata(global::System.Windows.Controls.Primitives.Popup.AllowsTransparencyProperty.DefaultMetadata.DefaultValue, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Menus.XamContextMenu.OnAllowsTransparencyChanged)));

		// Token: 0x0400005D RID: 93
		private static global::System.Windows.DependencyProperty BindingHelperProperty = global::System.Windows.DependencyProperty.RegisterAttached("BindingHelper", typeof(object), typeof(global::Infragistics.Controls.Menus.XamContextMenu), new global::System.Windows.PropertyMetadata(null));
	}
}
