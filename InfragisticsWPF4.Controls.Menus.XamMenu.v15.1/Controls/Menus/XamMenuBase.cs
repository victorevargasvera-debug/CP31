using System;
using System.Reflection;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Media3D;
using Infragistics.Controls.Menus.Primitives;

namespace Infragistics.Controls.Menus
{
	// Token: 0x0200001A RID: 26
	public abstract class XamMenuBase : global::Infragistics.Controls.Menus.Primitives.XamHeaderedItemsControl
	{
		// Token: 0x060000A6 RID: 166 RVA: 0x00003CBC File Offset: 0x00001EBC
		static XamMenuBase()
		{
			global::System.Windows.Input.FocusManager.IsFocusScopeProperty.OverrideMetadata(typeof(global::Infragistics.Controls.Menus.XamMenuBase), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.TrueBox));
		}

		// Token: 0x060000A7 RID: 167 RVA: 0x00003D51 File Offset: 0x00001F51
		protected XamMenuBase()
		{
			base.AddHandler(global::System.Windows.Input.Mouse.PreviewMouseDownOutsideCapturedElementEvent, new global::System.Windows.Input.MouseButtonEventHandler(this.MouseDownOutside), true);
			base.Unloaded += this.XamWebMenuBase_Unloaded;
		}

		// Token: 0x060000A8 RID: 168 RVA: 0x00003D84 File Offset: 0x00001F84
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

		// Token: 0x060000A9 RID: 169 RVA: 0x00003DB6 File Offset: 0x00001FB6
		protected override bool IsItemItsOwnContainerOverride(object item)
		{
			return item is global::Infragistics.Controls.Menus.XamMenuItem || item is global::Infragistics.Controls.Menus.XamMenuSeparator;
		}

		// Token: 0x060000AA RID: 170 RVA: 0x00003DCC File Offset: 0x00001FCC
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

		// Token: 0x060000AB RID: 171 RVA: 0x00003DFC File Offset: 0x00001FFC
		protected override void ClearContainerForItemOverride(global::System.Windows.DependencyObject element, object item)
		{
			global::Infragistics.Controls.Menus.XamMenuItem xamMenuItem = element as global::Infragistics.Controls.Menus.XamMenuItem;
			if (xamMenuItem != null)
			{
				xamMenuItem.ParentItemsControl = null;
			}
			base.ClearContainerForItemOverride(element, item);
		}

		// Token: 0x060000AC RID: 172 RVA: 0x00003E24 File Offset: 0x00002024
		protected override void OnMouseDown(global::System.Windows.Input.MouseButtonEventArgs e)
		{
			base.OnMouseDown(e);
			for (global::System.Windows.DependencyObject dependencyObject = e.OriginalSource as global::System.Windows.DependencyObject; dependencyObject != null; dependencyObject = global::Infragistics.Controls.Menus.XamMenuBase.GetParent(dependencyObject))
			{
				if (dependencyObject is global::Infragistics.Controls.Menus.XamMenuItem || dependencyObject == this)
				{
					return;
				}
			}
			this.CloseCurrentOpen();
		}

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x060000AD RID: 173 RVA: 0x00003E63 File Offset: 0x00002063
		// (set) Token: 0x060000AE RID: 174 RVA: 0x00003E75 File Offset: 0x00002075
		internal global::Infragistics.Controls.Menus.XamMenuItem CurrentOpen
		{
			get
			{
				return (global::Infragistics.Controls.Menus.XamMenuItem)base.GetValue(global::Infragistics.Controls.Menus.XamMenuBase.CurrentOpenProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Menus.XamMenuBase.CurrentOpenProperty, value);
			}
		}

		// Token: 0x060000AF RID: 175 RVA: 0x00003E84 File Offset: 0x00002084
		private static void CurrentOpenChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Menus.XamMenuBase xamMenuBase = obj as global::Infragistics.Controls.Menus.XamMenuBase;
			global::Infragistics.Controls.Menus.XamMenuItem xamMenuItem = e.OldValue as global::Infragistics.Controls.Menus.XamMenuItem;
			global::Infragistics.Controls.Menus.XamMenuItem xamMenuItem2 = e.NewValue as global::Infragistics.Controls.Menus.XamMenuItem;
			if (xamMenuItem != null && xamMenuItem.IsSubmenuOpen)
			{
				xamMenuItem.ManipulateSubmenu(false, false);
				xamMenuItem.IsHighlighted = false;
				if (xamMenuItem2 != null)
				{
					xamMenuItem2.ManipulateSubmenu(true, false);
				}
			}
			if (xamMenuItem == null && xamMenuItem2 != null)
			{
				global::System.Windows.Input.Mouse.Capture(xamMenuBase, global::System.Windows.Input.CaptureMode.SubTree);
			}
			else if (xamMenuItem != null && xamMenuItem2 == null)
			{
				global::System.Windows.Input.Mouse.Capture(null);
			}
			xamMenuBase.OnCurrentOpenItemChanged(xamMenuItem, xamMenuItem2);
		}

		// Token: 0x060000B0 RID: 176 RVA: 0x00003EFC File Offset: 0x000020FC
		protected internal virtual void OnCurrentOpenItemChanged(global::Infragistics.Controls.Menus.XamMenuItem oldItem, global::Infragistics.Controls.Menus.XamMenuItem newItem)
		{
		}

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x060000B1 RID: 177 RVA: 0x00003EFE File Offset: 0x000020FE
		// (set) Token: 0x060000B2 RID: 178 RVA: 0x00003F10 File Offset: 0x00002110
		internal global::Infragistics.Controls.Menus.XamMenuItem CurrentSelected
		{
			get
			{
				return (global::Infragistics.Controls.Menus.XamMenuItem)base.GetValue(global::Infragistics.Controls.Menus.XamMenuBase.CurrentSelectedProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Menus.XamMenuBase.CurrentSelectedProperty, value);
			}
		}

		// Token: 0x060000B3 RID: 179 RVA: 0x00003F20 File Offset: 0x00002120
		private static void CurrentSelectedChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Menus.XamMenuItem xamMenuItem = e.OldValue as global::Infragistics.Controls.Menus.XamMenuItem;
			if (xamMenuItem != null)
			{
				xamMenuItem.IsSelected = false;
			}
		}

		// Token: 0x060000B4 RID: 180 RVA: 0x00003F44 File Offset: 0x00002144
		internal static global::System.Windows.DependencyObject GetRoot(global::System.Windows.DependencyObject element)
		{
			while (element != null)
			{
				global::System.Windows.DependencyObject parent = global::Infragistics.Controls.Menus.XamMenuBase.GetParent(element);
				if (parent == null)
				{
					break;
				}
				element = parent;
			}
			return element;
		}

		// Token: 0x060000B5 RID: 181 RVA: 0x00003F64 File Offset: 0x00002164
		internal void RaiseItemClickedEvent(global::Infragistics.Controls.Menus.XamMenuItem item)
		{
			this.OnItemClicked(new global::Infragistics.Controls.Menus.ItemClickedEventArgs
			{
				Item = item
			});
		}

		// Token: 0x060000B6 RID: 182 RVA: 0x00003F88 File Offset: 0x00002188
		internal static global::System.Windows.Controls.ItemContainerGenerator GetGenerator(global::System.Windows.Controls.ItemsControl control)
		{
			global::Infragistics.Controls.Menus.XamMenuItem xamMenuItem = control as global::Infragistics.Controls.Menus.XamMenuItem;
			if (xamMenuItem != null)
			{
				return xamMenuItem.ItemContainerGenerator;
			}
			global::Infragistics.Controls.Menus.XamMenuBase xamMenuBase = control as global::Infragistics.Controls.Menus.XamMenuBase;
			if (xamMenuBase != null)
			{
				return xamMenuBase.ItemContainerGenerator;
			}
			return null;
		}

		// Token: 0x060000B7 RID: 183 RVA: 0x00003FB8 File Offset: 0x000021B8
		internal virtual void CloseCurrentOpen()
		{
			if (this.CurrentOpen != null)
			{
				this.CurrentOpen.ManipulateSubmenu(false, true);
				this.CurrentOpen = null;
				if (this.CurrentSelected != null)
				{
					this.CurrentSelected.IsSelected = false;
					this.CurrentSelected.ChangeVisualState(false);
					this.CurrentSelected = null;
				}
			}
		}

		// Token: 0x060000B8 RID: 184 RVA: 0x00004008 File Offset: 0x00002208
		internal void ClearPreviouslyFocusedControl()
		{
			this._previouslyFocusedControl = null;
		}

		// Token: 0x060000B9 RID: 185 RVA: 0x00004011 File Offset: 0x00002211
		internal void ReturnFocus()
		{
			if (this._previouslyFocusedControl != null && this._previouslyFocusedControl.IsEnabled && this._previouslyFocusedControl.Visibility == global::System.Windows.Visibility.Visible)
			{
				this._previouslyFocusedControl.Focus();
				this.ClearPreviouslyFocusedControl();
			}
		}

		// Token: 0x060000BA RID: 186 RVA: 0x00004048 File Offset: 0x00002248
		internal void RootVisual_MouseLeftButtonDown(object sender, global::System.Windows.Input.MouseButtonEventArgs e)
		{
			object weakReferenceTargetSafe = global::Infragistics.CoreUtilities.GetWeakReferenceTargetSafe(this._lastMouseArgs);
			if (e == weakReferenceTargetSafe)
			{
				return;
			}
			global::System.Windows.DependencyObject dependencyObject = e.OriginalSource as global::System.Windows.DependencyObject;
			if (dependencyObject != null)
			{
				if (base.IsAncestorOf(dependencyObject))
				{
					return;
				}
				global::System.Windows.UIElement rootVisual = global::Infragistics.PlatformProxy.GetRootVisual(dependencyObject);
				if (rootVisual != null)
				{
					global::System.Windows.Controls.Primitives.Popup popup = global::Infragistics.PlatformProxy.GetParent(rootVisual) as global::System.Windows.Controls.Primitives.Popup;
					if (popup != null && base.IsAncestorOf(popup))
					{
						return;
					}
				}
			}
			this.CloseCurrentOpen();
			this.ClearPreviouslyFocusedControl();
		}

		// Token: 0x060000BB RID: 187 RVA: 0x000040AE File Offset: 0x000022AE
		protected virtual void OnItemClicked(global::Infragistics.Controls.Menus.ItemClickedEventArgs e)
		{
			if (this.ItemClicked != null)
			{
				this.ItemClicked(this, e);
			}
		}

		// Token: 0x060000BC RID: 188 RVA: 0x000040C5 File Offset: 0x000022C5
		protected virtual void OnBeforeUnload()
		{
		}

		// Token: 0x060000BD RID: 189 RVA: 0x000040C8 File Offset: 0x000022C8
		internal static bool IsObjectFromMenu(global::System.Windows.DependencyObject root, object originalSource)
		{
			global::System.Windows.DependencyObject parent;
			for (global::System.Windows.DependencyObject dependencyObject = originalSource as global::System.Windows.DependencyObject; dependencyObject != null; dependencyObject = parent)
			{
				if (object.ReferenceEquals(dependencyObject, root))
				{
					return true;
				}
				parent = global::Infragistics.Controls.Menus.XamMenuBase.GetParent(dependencyObject);
			}
			return false;
		}

		// Token: 0x060000BE RID: 190 RVA: 0x000040F8 File Offset: 0x000022F8
		internal static global::System.Windows.DependencyObject GetParent(global::System.Windows.DependencyObject element)
		{
			global::System.Windows.DependencyObject dependencyObject = null;
			if (element is global::System.Windows.Media.Visual || element is global::System.Windows.Media.Media3D.Visual3D)
			{
				dependencyObject = global::System.Windows.Media.VisualTreeHelper.GetParent(element);
			}
			if (dependencyObject == null)
			{
				global::System.Windows.FrameworkElement frameworkElement = element as global::System.Windows.FrameworkElement;
				if (frameworkElement != null)
				{
					dependencyObject = frameworkElement.Parent;
				}
				global::System.Windows.FrameworkContentElement frameworkContentElement = element as global::System.Windows.FrameworkContentElement;
				if (frameworkContentElement != null)
				{
					dependencyObject = frameworkContentElement.Parent;
				}
			}
			return dependencyObject;
		}

		// Token: 0x060000BF RID: 191 RVA: 0x00004144 File Offset: 0x00002344
		private void MouseDownOutside(object sender, global::System.Windows.Input.MouseButtonEventArgs e)
		{
			this.CloseCurrentOpen();
			this._previouslyFocusedControl = null;
		}

		// Token: 0x060000C0 RID: 192 RVA: 0x00004153 File Offset: 0x00002353
		public static void RegisterResources(string name, global::System.Reflection.Assembly assembly)
		{
			global::SR.AddResource(name, assembly);
		}

		// Token: 0x060000C1 RID: 193 RVA: 0x0000415C File Offset: 0x0000235C
		public static void UnregisterResources(string name)
		{
			global::SR.RemoveResource(name);
		}

		// Token: 0x14000001 RID: 1
		// (add) Token: 0x060000C2 RID: 194 RVA: 0x00004164 File Offset: 0x00002364
		// (remove) Token: 0x060000C3 RID: 195 RVA: 0x0000419C File Offset: 0x0000239C
		public event global::System.EventHandler<global::Infragistics.Controls.Menus.ItemClickedEventArgs> ItemClicked;

		// Token: 0x060000C4 RID: 196 RVA: 0x000041D1 File Offset: 0x000023D1
		private void XamWebMenuBase_Unloaded(object sender, global::System.Windows.RoutedEventArgs e)
		{
			this.OnBeforeUnload();
		}

		// Token: 0x04000043 RID: 67
		internal global::System.Windows.Controls.Control _previouslyFocusedControl;

		// Token: 0x04000044 RID: 68
		internal global::System.WeakReference _lastMouseArgs;

		// Token: 0x04000045 RID: 69
		internal static readonly global::System.Windows.DependencyProperty CurrentOpenProperty = global::System.Windows.DependencyProperty.Register("CurrentOpen", typeof(global::Infragistics.Controls.Menus.XamMenuItem), typeof(global::Infragistics.Controls.Menus.XamMenuBase), new global::System.Windows.PropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Menus.XamMenuBase.CurrentOpenChanged)));

		// Token: 0x04000046 RID: 70
		internal static readonly global::System.Windows.DependencyProperty CurrentSelectedProperty = global::System.Windows.DependencyProperty.Register("CurrentSelected", typeof(global::Infragistics.Controls.Menus.XamMenuItem), typeof(global::Infragistics.Controls.Menus.XamMenuBase), new global::System.Windows.PropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Menus.XamMenuBase.CurrentSelectedChanged)));

		// Token: 0x0200001B RID: 27
		// (Invoke) Token: 0x060000C6 RID: 198
		private delegate void EventDelegate(global::Infragistics.Controls.Menus.ItemClickedEventArgs e);
	}
}
