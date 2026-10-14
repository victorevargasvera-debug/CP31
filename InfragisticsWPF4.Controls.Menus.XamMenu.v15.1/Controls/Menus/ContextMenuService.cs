using System;
using System.Windows;
using System.Windows.Controls.Primitives;
using System.Windows.Input;
using Infragistics.Controls.Menus.Primitives;

namespace Infragistics.Controls.Menus
{
	// Token: 0x02000007 RID: 7
	public static class ContextMenuService
	{
		// Token: 0x06000043 RID: 67 RVA: 0x00002D54 File Offset: 0x00000F54
		private static void OnManagerChanged(global::System.Windows.DependencyObject target, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Menus.ContextMenuManager contextMenuManager = e.OldValue as global::Infragistics.Controls.Menus.ContextMenuManager;
			global::Infragistics.Controls.Menus.ContextMenuManager contextMenuManager2 = e.NewValue as global::Infragistics.Controls.Menus.ContextMenuManager;
			if (contextMenuManager != null)
			{
				contextMenuManager.ParentElement = null;
			}
			if (contextMenuManager2 != null)
			{
				contextMenuManager2.ParentElement = (target as global::System.Windows.UIElement);
				contextMenuManager2.ParentElement.AddHandler(global::System.Windows.UIElement.KeyDownEvent, new global::System.Windows.Input.KeyEventHandler(global::Infragistics.Controls.Menus.ContextMenuService.XamContextMenu_KeyDown), true);
			}
			global::Infragistics.CommandSourceManager.NotifyCanExecuteChanged(typeof(global::Infragistics.Controls.Menus.Primitives.OpenCommand));
			global::Infragistics.CommandSourceManager.NotifyCanExecuteChanged(typeof(global::Infragistics.Controls.Menus.Primitives.CloseCommand));
		}

		// Token: 0x06000044 RID: 68 RVA: 0x00002DCF File Offset: 0x00000FCF
		public static global::Infragistics.Controls.Menus.ContextMenuManager GetManager(global::System.Windows.DependencyObject element)
		{
			return (global::Infragistics.Controls.Menus.ContextMenuManager)element.GetValue(global::Infragistics.Controls.Menus.ContextMenuService.ManagerProperty);
		}

		// Token: 0x06000045 RID: 69 RVA: 0x00002DE1 File Offset: 0x00000FE1
		public static void SetManager(global::System.Windows.DependencyObject element, global::Infragistics.Controls.Menus.ContextMenuManager value)
		{
			element.SetValue(global::Infragistics.Controls.Menus.ContextMenuService.ManagerProperty, value);
		}

		// Token: 0x06000046 RID: 70 RVA: 0x00002DF0 File Offset: 0x00000FF0
		public static bool IsMenuOpenForElement(global::System.Windows.DependencyObject obj)
		{
			if (obj == null)
			{
				return false;
			}
			if (global::Infragistics.Controls.Menus.ContextMenuService._activeContextMenu == null || !global::Infragistics.Controls.Menus.ContextMenuService._activeContextMenu.IsOpen || global::Infragistics.Controls.Menus.ContextMenuService._activeContextMenu.PlacementTargetResolved == null)
			{
				return false;
			}
			for (global::System.Windows.DependencyObject dependencyObject = global::Infragistics.Controls.Menus.ContextMenuService._activeContextMenu.PlacementTargetResolved; dependencyObject != null; dependencyObject = global::Infragistics.PlatformProxy.GetParent(dependencyObject))
			{
				if (obj == dependencyObject)
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x06000047 RID: 71 RVA: 0x00002E41 File Offset: 0x00001041
		internal static void OnContextMenuClosed(global::Infragistics.Controls.Menus.XamContextMenu contextMenu)
		{
			if (contextMenu == global::Infragistics.Controls.Menus.ContextMenuService._activeContextMenu)
			{
				global::Infragistics.Controls.Menus.ContextMenuService._activeContextMenu = null;
			}
		}

		// Token: 0x06000048 RID: 72 RVA: 0x00002E51 File Offset: 0x00001051
		internal static void OnContextMenuOpened(global::Infragistics.Controls.Menus.XamContextMenu xamContextMenu)
		{
			global::Infragistics.Controls.Menus.ContextMenuService.CloseActiveContextMenu();
			global::Infragistics.Controls.Menus.ContextMenuService._activeContextMenu = xamContextMenu;
		}

		// Token: 0x06000049 RID: 73 RVA: 0x00002E60 File Offset: 0x00001060
		internal static global::System.Windows.Rect GetBounds(global::System.Windows.UIElement element)
		{
			global::System.Windows.FrameworkElement frameworkElement = element as global::System.Windows.FrameworkElement;
			bool flag = true;
			double x = 0.0;
			double y = 0.0;
			global::System.Windows.Rect rect = (frameworkElement != null) ? new global::System.Windows.Rect(x, y, frameworkElement.ActualWidth, frameworkElement.ActualHeight) : new global::System.Windows.Rect(0.0, 0.0, element.RenderSize.Width, element.RenderSize.Height);
			try
			{
				global::System.Windows.UIElement rootVisual = global::Infragistics.PlatformProxy.GetRootVisual(element);
				if (rootVisual != null)
				{
					rect = element.TransformToVisual(rootVisual).TransformBounds(rect);
					flag = false;
				}
			}
			catch (global::System.ArgumentException)
			{
			}
			catch (global::System.InvalidOperationException)
			{
			}
			if (flag)
			{
				global::System.Windows.FrameworkElement frameworkElement2 = global::Infragistics.PlatformProxy.GetRootVisual(element) as global::System.Windows.FrameworkElement;
				if (frameworkElement2 == null)
				{
					frameworkElement2 = (global::Infragistics.PlatformProxy.GetRootParent(element) as global::System.Windows.FrameworkElement);
				}
				if (frameworkElement2 != null)
				{
					global::System.Windows.Controls.Primitives.Popup popup = frameworkElement2 as global::System.Windows.Controls.Primitives.Popup;
					if (popup != null)
					{
						frameworkElement2 = (popup.Child as global::System.Windows.FrameworkElement);
					}
					if (frameworkElement2 != null && !(frameworkElement2 is global::System.Windows.Controls.Primitives.Popup))
					{
						global::System.Windows.Point point = new global::System.Windows.Point(0.0, 0.0);
						global::System.Windows.Point point2 = element.PointToScreen(point);
						point = frameworkElement2.PointToScreen(point);
						point2.X -= point.X;
						point2.Y -= point.Y;
						rect.X = point2.X;
						rect.Y = point2.Y;
					}
				}
			}
			return rect;
		}

		// Token: 0x0600004A RID: 74 RVA: 0x00002FE4 File Offset: 0x000011E4
		public static bool CloseActiveContextMenu()
		{
			if (global::Infragistics.Controls.Menus.ContextMenuService._activeContextMenu != null)
			{
				global::Infragistics.Controls.Menus.ContextMenuService._activeContextMenu.IsOpen = false;
			}
			return global::Infragistics.Controls.Menus.ContextMenuService._activeContextMenu == null || !global::Infragistics.Controls.Menus.ContextMenuService._activeContextMenu.IsOpen;
		}

		// Token: 0x0600004B RID: 75 RVA: 0x00003010 File Offset: 0x00001210
		internal static void PositionContextMenu(global::Infragistics.Controls.Menus.XamContextMenu contextMenu, global::System.Windows.Point p, global::System.Windows.UIElement parentElement)
		{
			if (contextMenu != global::Infragistics.Controls.Menus.ContextMenuService._activeContextMenu && !global::Infragistics.Controls.Menus.ContextMenuService.CloseActiveContextMenu())
			{
				return;
			}
			if (parentElement != null)
			{
				global::Infragistics.Controls.Menus.ContextMenuManager manager = global::Infragistics.Controls.Menus.ContextMenuService.GetManager(parentElement);
				if (manager != null && manager.ContextMenu == contextMenu && contextMenu != null)
				{
					contextMenu.MouseClickLocation = p;
					contextMenu.ParentElement = parentElement;
					contextMenu.IsOpen = true;
				}
			}
		}

		// Token: 0x0600004C RID: 76 RVA: 0x0000305C File Offset: 0x0000125C
		internal static void XamContextMenu_KeyDown(object sender, global::System.Windows.Input.KeyEventArgs e)
		{
			if (!e.Handled && e.Key == global::System.Windows.Input.Key.Apps)
			{
				global::System.Windows.DependencyObject dependencyObject = sender as global::System.Windows.DependencyObject;
				if (dependencyObject != null)
				{
					global::Infragistics.Controls.Menus.ContextMenuManager manager = global::Infragistics.Controls.Menus.ContextMenuService.GetManager(dependencyObject);
					if (manager != null && !manager.ContextMenu.IsOpen)
					{
						manager.ContextMenu.OpenInternal();
						e.Handled = true;
					}
				}
			}
		}

		// Token: 0x04000009 RID: 9
		private static bool _handlerAdded;

		// Token: 0x0400000A RID: 10
		private static global::Infragistics.Controls.Menus.XamContextMenu _activeContextMenu;

		// Token: 0x0400000B RID: 11
		public static readonly global::System.Windows.DependencyProperty ManagerProperty = global::System.Windows.DependencyProperty.RegisterAttached("Manager", typeof(global::Infragistics.Controls.Menus.ContextMenuManager), typeof(global::Infragistics.Controls.Menus.ContextMenuService), new global::System.Windows.PropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Menus.ContextMenuService.OnManagerChanged)));
	}
}
