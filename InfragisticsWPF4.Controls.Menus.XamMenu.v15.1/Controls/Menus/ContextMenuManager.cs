using System;
using System.Windows;
using System.Windows.Input;
using Infragistics.Controls.Menus.Primitives;

namespace Infragistics.Controls.Menus
{
	// Token: 0x02000006 RID: 6
	public class ContextMenuManager : global::System.Windows.DependencyObject
	{
		// Token: 0x0600002A RID: 42 RVA: 0x00002860 File Offset: 0x00000A60
		private static void OnContextMenuChanged(global::System.Windows.DependencyObject target, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Menus.ContextMenuManager contextMenuManager = target as global::Infragistics.Controls.Menus.ContextMenuManager;
			if (contextMenuManager != null)
			{
				contextMenuManager.PrepareContextMenu(contextMenuManager.ParentElement, e.OldValue as global::Infragistics.Controls.Menus.XamContextMenu, e.NewValue as global::Infragistics.Controls.Menus.XamContextMenu);
			}
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x0600002B RID: 43 RVA: 0x0000289B File Offset: 0x00000A9B
		// (set) Token: 0x0600002C RID: 44 RVA: 0x000028AD File Offset: 0x00000AAD
		public global::Infragistics.Controls.Menus.XamContextMenu ContextMenu
		{
			get
			{
				return (global::Infragistics.Controls.Menus.XamContextMenu)base.GetValue(global::Infragistics.Controls.Menus.ContextMenuManager.ContextMenuProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Menus.ContextMenuManager.ContextMenuProperty, value);
			}
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x0600002D RID: 45 RVA: 0x000028BB File Offset: 0x00000ABB
		// (set) Token: 0x0600002E RID: 46 RVA: 0x000028CD File Offset: 0x00000ACD
		public global::System.Windows.Input.ModifierKeys ModifierKeys
		{
			get
			{
				return (global::System.Windows.Input.ModifierKeys)base.GetValue(global::Infragistics.Controls.Menus.ContextMenuManager.ModifierKeysProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Menus.ContextMenuManager.ModifierKeysProperty, value);
			}
		}

		// Token: 0x0600002F RID: 47 RVA: 0x000028E0 File Offset: 0x00000AE0
		private static void OnOpenModeChanged(global::System.Windows.DependencyObject target, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Menus.ContextMenuManager contextMenuManager = target as global::Infragistics.Controls.Menus.ContextMenuManager;
			if (contextMenuManager != null)
			{
				contextMenuManager.PrepareOpenMode(contextMenuManager.ParentElement, (global::Infragistics.Controls.Menus.OpenMode)e.OldValue, (global::Infragistics.Controls.Menus.OpenMode)e.NewValue);
			}
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x06000030 RID: 48 RVA: 0x0000291B File Offset: 0x00000B1B
		// (set) Token: 0x06000031 RID: 49 RVA: 0x0000292D File Offset: 0x00000B2D
		public global::Infragistics.Controls.Menus.OpenMode OpenMode
		{
			get
			{
				return (global::Infragistics.Controls.Menus.OpenMode)base.GetValue(global::Infragistics.Controls.Menus.ContextMenuManager.OpenModeProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Menus.ContextMenuManager.OpenModeProperty, value);
			}
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x06000032 RID: 50 RVA: 0x00002940 File Offset: 0x00000B40
		// (set) Token: 0x06000033 RID: 51 RVA: 0x00002969 File Offset: 0x00000B69
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
				this.OnParentElementChanging(this.ParentElement, value);
				this._targetElement = new global::System.WeakReference(value);
			}
		}

		// Token: 0x06000034 RID: 52 RVA: 0x00002984 File Offset: 0x00000B84
		private void OnParentElementChanging(global::System.Windows.UIElement oldElement, global::System.Windows.UIElement newElement)
		{
			if (newElement == null)
			{
				this.PrepareOpenMode(oldElement, this.OpenMode, global::Infragistics.Controls.Menus.OpenMode.None);
			}
			global::System.Windows.FrameworkElement frameworkElement = oldElement as global::System.Windows.FrameworkElement;
			if (frameworkElement != null)
			{
				frameworkElement.Unloaded -= this.OnParentElementUnloaded;
			}
			global::System.Windows.FrameworkElement frameworkElement2 = newElement as global::System.Windows.FrameworkElement;
			if (frameworkElement2 != null)
			{
				frameworkElement2.Unloaded += this.OnParentElementUnloaded;
			}
			if (this.ContextMenu != null)
			{
				this.ContextMenu.CloseCurrentOpen();
				this.ContextMenu.ParentElement = newElement;
			}
			this.PrepareOpenMode(newElement, global::Infragistics.Controls.Menus.OpenMode.None, this.OpenMode);
		}

		// Token: 0x06000035 RID: 53 RVA: 0x00002A08 File Offset: 0x00000C08
		private static bool OpenContextMenu(object sender, global::System.Windows.Point p)
		{
			global::System.Windows.DependencyObject dependencyObject = sender as global::System.Windows.DependencyObject;
			global::Infragistics.Controls.Menus.XamContextMenu xamContextMenu = null;
			if (dependencyObject != null)
			{
				global::Infragistics.Controls.Menus.ContextMenuManager manager = global::Infragistics.Controls.Menus.ContextMenuService.GetManager(dependencyObject);
				xamContextMenu = manager.ContextMenu;
				if (xamContextMenu != null && xamContextMenu.Visibility == global::System.Windows.Visibility.Visible)
				{
					global::Infragistics.Controls.Menus.ContextMenuService.PositionContextMenu(xamContextMenu, p, sender as global::System.Windows.UIElement);
				}
			}
			return xamContextMenu != null && (xamContextMenu.IsOpen || xamContextMenu.IsCancelled);
		}

		// Token: 0x06000036 RID: 54 RVA: 0x00002A5C File Offset: 0x00000C5C
		private void PrepareOpenMode(global::System.Windows.UIElement element, global::Infragistics.Controls.Menus.OpenMode oldOpenMode, global::Infragistics.Controls.Menus.OpenMode newOpenMode)
		{
			if (element != null)
			{
				switch (oldOpenMode)
				{
				case global::Infragistics.Controls.Menus.OpenMode.LeftClick:
					this.RemoveLeftMouseButtonUpHandler(element);
					break;
				case global::Infragistics.Controls.Menus.OpenMode.RightClick:
					this.RemoveRightMouseButtonUpHandler(element);
					break;
				}
				switch (newOpenMode)
				{
				case global::Infragistics.Controls.Menus.OpenMode.LeftClick:
					this.AddLeftMouseButtonUpHandler(element);
					break;
				case global::Infragistics.Controls.Menus.OpenMode.RightClick:
					this.AddRightMouseButtonUpHandler(element);
					return;
				default:
					return;
				}
			}
		}

		// Token: 0x06000037 RID: 55 RVA: 0x00002AB4 File Offset: 0x00000CB4
		private void PrepareContextMenu(global::System.Windows.UIElement element, global::Infragistics.Controls.Menus.XamContextMenu oldContextMenu, global::Infragistics.Controls.Menus.XamContextMenu newContextMenu)
		{
			if (element != null)
			{
				if (oldContextMenu != null)
				{
					this.PrepareOpenMode(oldContextMenu.ParentElement, this.OpenMode, global::Infragistics.Controls.Menus.OpenMode.None);
				}
				if (newContextMenu != null)
				{
					this.PrepareOpenMode(element, global::Infragistics.Controls.Menus.OpenMode.None, this.OpenMode);
				}
				if (newContextMenu != null)
				{
					newContextMenu.ParentElement = element;
				}
			}
			global::Infragistics.CommandSourceManager.NotifyCanExecuteChanged(typeof(global::Infragistics.Controls.Menus.Primitives.OpenCommand));
			global::Infragistics.CommandSourceManager.NotifyCanExecuteChanged(typeof(global::Infragistics.Controls.Menus.Primitives.CloseCommand));
		}

		// Token: 0x06000038 RID: 56 RVA: 0x00002B13 File Offset: 0x00000D13
		private void AddRightMouseButtonUpHandler(global::System.Windows.UIElement element)
		{
			element.MouseRightButtonDown += this.Element_MouseRightButtonDown;
			element.MouseRightButtonUp += this.Element_MouseRightButtonUp;
		}

		// Token: 0x06000039 RID: 57 RVA: 0x00002B39 File Offset: 0x00000D39
		private void AddLeftMouseButtonUpHandler(global::System.Windows.UIElement element)
		{
			element.AddHandler(global::System.Windows.UIElement.MouseLeftButtonUpEvent, new global::System.Windows.Input.MouseButtonEventHandler(this.Element_MouseLeftButtonUp), true);
		}

		// Token: 0x0600003A RID: 58 RVA: 0x00002B53 File Offset: 0x00000D53
		private void RemoveRightMouseButtonUpHandler(global::System.Windows.UIElement element)
		{
			element.MouseRightButtonDown -= this.Element_MouseRightButtonDown;
			element.MouseRightButtonUp -= this.Element_MouseRightButtonUp;
		}

		// Token: 0x0600003B RID: 59 RVA: 0x00002B79 File Offset: 0x00000D79
		private void RemoveLeftMouseButtonUpHandler(global::System.Windows.UIElement element)
		{
			element.RemoveHandler(global::System.Windows.UIElement.MouseLeftButtonUpEvent, new global::System.Windows.Input.MouseButtonEventHandler(this.Element_MouseLeftButtonUp));
		}

		// Token: 0x0600003C RID: 60 RVA: 0x00002B94 File Offset: 0x00000D94
		private bool CheckModifierKeys()
		{
			global::System.Windows.Input.ModifierKeys currentModifierKeys = global::Infragistics.Controls.PresentationUtilities.GetCurrentModifierKeys();
			return this.ModifierKeys == global::System.Windows.Input.ModifierKeys.None || (currentModifierKeys & this.ModifierKeys) == this.ModifierKeys;
		}

		// Token: 0x0600003D RID: 61 RVA: 0x00002BC4 File Offset: 0x00000DC4
		private void Element_MouseLeftButtonUp(object sender, global::System.Windows.Input.MouseButtonEventArgs e)
		{
			if (!this.CheckModifierKeys())
			{
				return;
			}
			bool flag = false;
			global::System.Windows.DependencyObject dependencyObject = e.OriginalSource as global::System.Windows.DependencyObject;
			if (dependencyObject != null)
			{
				flag = (global::Infragistics.Controls.Menus.ContextMenuService.GetManager(dependencyObject) != null);
			}
			if (sender == e.OriginalSource || !e.Handled || !flag)
			{
				e.Handled = global::Infragistics.Controls.Menus.ContextMenuManager.OpenContextMenu(sender, e.GetPosition(global::Infragistics.PlatformProxy.GetRootVisual(dependencyObject)));
			}
		}

		// Token: 0x0600003E RID: 62 RVA: 0x00002C24 File Offset: 0x00000E24
		private void Element_MouseRightButtonUp(object sender, global::System.Windows.Input.MouseButtonEventArgs e)
		{
			e.Handled = this.Element_MouseRightButtonUpImpl(sender, new global::System.Func<global::System.Windows.UIElement, global::System.Windows.Point>(e.GetPosition));
		}

		// Token: 0x0600003F RID: 63 RVA: 0x00002C40 File Offset: 0x00000E40
		private bool Element_MouseRightButtonUpImpl(object sender, global::System.Func<global::System.Windows.UIElement, global::System.Windows.Point> getPosition)
		{
			if (!this.CheckModifierKeys())
			{
				return false;
			}
			bool result;
			if (global::Infragistics.Controls.Menus.ContextMenuService.CloseActiveContextMenu())
			{
				result = this.ContextMenu.ShouldRightClickBeHandled;
				global::Infragistics.Controls.Menus.ContextMenuManager.OpenContextMenu(sender, getPosition(global::Infragistics.PlatformProxy.GetRootVisual(sender as global::System.Windows.DependencyObject)));
			}
			else
			{
				result = true;
			}
			return result;
		}

		// Token: 0x06000040 RID: 64 RVA: 0x00002C89 File Offset: 0x00000E89
		private void Element_MouseRightButtonDown(object sender, global::System.Windows.Input.MouseButtonEventArgs e)
		{
			e.Handled = true;
		}

		// Token: 0x06000041 RID: 65 RVA: 0x00002C92 File Offset: 0x00000E92
		private void OnParentElementUnloaded(object sender, global::System.Windows.RoutedEventArgs e)
		{
			if (this.ContextMenu != null)
			{
				this.ContextMenu.CloseCurrentOpen();
			}
		}

		// Token: 0x04000003 RID: 3
		private const global::Infragistics.Controls.Menus.OpenMode OpenModeDefaultValue = global::Infragistics.Controls.Menus.OpenMode.RightClick;

		// Token: 0x04000004 RID: 4
		private const global::System.Windows.Input.ModifierKeys ModifierKeysDefaultValue = global::System.Windows.Input.ModifierKeys.None;

		// Token: 0x04000005 RID: 5
		private global::System.WeakReference _targetElement;

		// Token: 0x04000006 RID: 6
		public static readonly global::System.Windows.DependencyProperty ContextMenuProperty = global::System.Windows.DependencyProperty.Register("ContextMenu", typeof(global::Infragistics.Controls.Menus.XamContextMenu), typeof(global::Infragistics.Controls.Menus.ContextMenuManager), new global::System.Windows.PropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Menus.ContextMenuManager.OnContextMenuChanged)));

		// Token: 0x04000007 RID: 7
		public static readonly global::System.Windows.DependencyProperty ModifierKeysProperty = global::System.Windows.DependencyProperty.Register("ModifierKeys", typeof(global::System.Windows.Input.ModifierKeys), typeof(global::Infragistics.Controls.Menus.ContextMenuManager), new global::System.Windows.PropertyMetadata(global::System.Windows.Input.ModifierKeys.None));

		// Token: 0x04000008 RID: 8
		public static readonly global::System.Windows.DependencyProperty OpenModeProperty = global::System.Windows.DependencyProperty.Register("OpenMode", typeof(global::Infragistics.Controls.Menus.OpenMode), typeof(global::Infragistics.Controls.Menus.ContextMenuManager), new global::System.Windows.PropertyMetadata(global::Infragistics.Controls.Menus.OpenMode.RightClick, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Menus.ContextMenuManager.OnOpenModeChanged)));
	}
}
