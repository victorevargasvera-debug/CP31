using System;
using System.ComponentModel;
using System.Reflection;
using System.Windows;
using System.Windows.Automation.Peers;
using System.Windows.Controls;
using System.Windows.Input;
using Infragistics.Windows.Automation.Peers.DataPresenter;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x02000111 RID: 273
	[global::System.ComponentModel.DesignTimeVisible(false)]
	public class FieldMenuItem : global::System.Windows.Controls.MenuItem
	{
		// Token: 0x06000E76 RID: 3702 RVA: 0x0003D598 File Offset: 0x0003B798
		static FieldMenuItem()
		{
			global::System.Windows.FrameworkElement.DefaultStyleKeyProperty.OverrideMetadata(typeof(global::Infragistics.Windows.DataPresenter.FieldMenuItem), new global::System.Windows.FrameworkPropertyMetadata(typeof(global::Infragistics.Windows.DataPresenter.FieldMenuItem)));
			try
			{
				global::System.Reflection.BindingFlags bindingAttr = global::System.Reflection.BindingFlags.Static | global::System.Reflection.BindingFlags.NonPublic;
				global::System.Reflection.FieldInfo field = typeof(global::System.Windows.Input.KeyboardNavigation).GetField("ShowKeyboardCuesProperty", bindingAttr);
				if (null != field)
				{
					global::Infragistics.Windows.DataPresenter.FieldMenuItem._showKeyboardCuesProperty = (field.GetValue(null) as global::System.Windows.DependencyProperty);
				}
			}
			catch
			{
			}
		}

		// Token: 0x06000E78 RID: 3704 RVA: 0x0003D618 File Offset: 0x0003B818
		protected override global::System.Windows.DependencyObject GetContainerForItemOverride()
		{
			return new global::Infragistics.Windows.DataPresenter.FieldMenuItem();
		}

		// Token: 0x06000E79 RID: 3705 RVA: 0x0003D61F File Offset: 0x0003B81F
		protected override global::System.Windows.Automation.Peers.AutomationPeer OnCreateAutomationPeer()
		{
			return new global::Infragistics.Windows.Automation.Peers.DataPresenter.FieldMenuItemAutomationPeer(this);
		}

		// Token: 0x06000E7A RID: 3706 RVA: 0x0003D628 File Offset: 0x0003B828
		protected override void OnKeyDown(global::System.Windows.Input.KeyEventArgs e)
		{
			global::System.Windows.Input.ModifierKeys modifiers = global::System.Windows.Input.Keyboard.Modifiers;
			global::System.Windows.Input.Key key = e.Key;
			if (key == global::System.Windows.Input.Key.System)
			{
				key = e.SystemKey;
			}
			global::Infragistics.Windows.DataPresenter.FieldMenuDataItem fieldMenuDataItem = base.DataContext as global::Infragistics.Windows.DataPresenter.FieldMenuDataItem;
			if (fieldMenuDataItem != null && fieldMenuDataItem.IsControlHost)
			{
				if (key == global::System.Windows.Input.Key.LeftAlt || key == global::System.Windows.Input.Key.RightAlt)
				{
					e.Handled = true;
				}
				else if (key == global::System.Windows.Input.Key.Down || key == global::System.Windows.Input.Key.Up)
				{
					global::System.Windows.FrameworkElement frameworkElement = (e.OriginalSource as global::System.Windows.FrameworkElement) ?? (global::Infragistics.Windows.Utilities.GetAncestorFromType(e.OriginalSource as global::System.Windows.DependencyObject, typeof(global::System.Windows.FrameworkElement), true) as global::System.Windows.FrameworkElement);
					if (frameworkElement != null && frameworkElement.MoveFocus(new global::System.Windows.Input.TraversalRequest((key == global::System.Windows.Input.Key.Down) ? global::System.Windows.Input.FocusNavigationDirection.Next : global::System.Windows.Input.FocusNavigationDirection.Previous)))
					{
						e.Handled = true;
						return;
					}
				}
			}
			if (!e.Handled && base.IsKeyboardFocused && key == global::System.Windows.Input.Key.Tab && base.Role == global::System.Windows.Controls.MenuItemRole.TopLevelHeader && base.IsSubmenuOpen)
			{
				global::System.Windows.Controls.ItemContainerGenerator itemContainerGenerator = base.ItemContainerGenerator;
				int i = 0;
				int count = base.Items.Count;
				while (i < count)
				{
					global::System.Windows.Controls.MenuItem menuItem = itemContainerGenerator.ContainerFromIndex(i) as global::System.Windows.Controls.MenuItem;
					if (menuItem != null && menuItem.IsEnabled && menuItem.Focusable)
					{
						menuItem.Focus();
						e.Handled = true;
						return;
					}
					i++;
				}
			}
			base.OnKeyDown(e);
		}

		// Token: 0x06000E7B RID: 3707 RVA: 0x0003D75C File Offset: 0x0003B95C
		protected override void OnPreviewGotKeyboardFocus(global::System.Windows.Input.KeyboardFocusChangedEventArgs e)
		{
			if (e.NewFocus == this)
			{
				global::Infragistics.Windows.DataPresenter.FieldMenuDataItem fieldMenuDataItem = base.DataContext as global::Infragistics.Windows.DataPresenter.FieldMenuDataItem;
				if (fieldMenuDataItem != null && fieldMenuDataItem.IsControlHost)
				{
					if (e.OldFocus is global::System.Windows.DependencyObject && base.IsAncestorOf(e.OldFocus as global::System.Windows.DependencyObject))
					{
						if (this._isShiftingFocusPrevious)
						{
							e.Handled = true;
							return;
						}
						global::System.Windows.DependencyObject dependencyObject = e.OldFocus as global::System.Windows.DependencyObject;
						global::System.Windows.FrameworkElement frameworkElement = (dependencyObject as global::System.Windows.FrameworkElement) ?? (global::Infragistics.Windows.Utilities.GetAncestorFromType(dependencyObject, typeof(global::System.Windows.FrameworkElement), true) as global::System.Windows.FrameworkElement);
						this._isShiftingFocusPrevious = true;
						try
						{
							if (!frameworkElement.IsVisible)
							{
								e.Handled = frameworkElement.MoveFocus(new global::System.Windows.Input.TraversalRequest(global::System.Windows.Input.FocusNavigationDirection.Previous));
								if (!e.Handled)
								{
									e.Handled = frameworkElement.MoveFocus(new global::System.Windows.Input.TraversalRequest(global::System.Windows.Input.FocusNavigationDirection.Next));
								}
							}
							else
							{
								e.Handled = this.MoveFocus(new global::System.Windows.Input.TraversalRequest(global::System.Windows.Input.FocusNavigationDirection.Previous));
								if (!e.Handled && this.VisualChildrenCount > 0)
								{
									global::System.Windows.FrameworkElement frameworkElement2 = this.GetVisualChild(0) as global::System.Windows.FrameworkElement;
									if (frameworkElement2 != null)
									{
										e.Handled = frameworkElement2.MoveFocus(new global::System.Windows.Input.TraversalRequest(global::System.Windows.Input.FocusNavigationDirection.Last));
									}
								}
							}
							goto IL_146;
						}
						finally
						{
							this._isShiftingFocusPrevious = false;
						}
					}
					if (this.VisualChildrenCount > 0)
					{
						global::System.Windows.FrameworkElement frameworkElement3 = this.GetVisualChild(0) as global::System.Windows.FrameworkElement;
						if (frameworkElement3 != null)
						{
							e.Handled = frameworkElement3.MoveFocus(new global::System.Windows.Input.TraversalRequest(global::System.Windows.Input.FocusNavigationDirection.First));
						}
					}
				}
			}
			IL_146:
			base.OnPreviewGotKeyboardFocus(e);
		}

		// Token: 0x06000E7C RID: 3708 RVA: 0x0003D8C8 File Offset: 0x0003BAC8
		protected override void OnPreviewLostKeyboardFocus(global::System.Windows.Input.KeyboardFocusChangedEventArgs e)
		{
			global::Infragistics.Windows.DataPresenter.FieldMenuDataItem fieldMenuDataItem = base.DataContext as global::Infragistics.Windows.DataPresenter.FieldMenuDataItem;
			if (fieldMenuDataItem != null && fieldMenuDataItem.IsControlHost && e.NewFocus is global::System.Windows.Controls.MenuItem)
			{
				global::System.Windows.Controls.MenuItem menuItem = e.NewFocus as global::System.Windows.Controls.MenuItem;
				if (this != null && menuItem.IsSubmenuOpen && this != menuItem && global::Infragistics.Windows.Utilities.IsDescendantOf(menuItem, this) && global::System.Windows.Controls.ItemsControl.ItemsControlFromItemContainer(this) == menuItem)
				{
					e.Handled = true;
				}
			}
			base.OnPreviewLostKeyboardFocus(e);
		}

		// Token: 0x06000E7D RID: 3709 RVA: 0x0003D938 File Offset: 0x0003BB38
		protected override void OnPropertyChanged(global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			if (global::Infragistics.Windows.DataPresenter.FieldMenuItem._showKeyboardCuesProperty == null && e.Property.OwnerType == typeof(global::System.Windows.Input.KeyboardNavigation) && e.Property.Name == "ShowKeyboardCues")
			{
				global::Infragistics.Windows.DataPresenter.FieldMenuItem._showKeyboardCuesProperty = e.Property;
			}
			base.OnPropertyChanged(e);
		}

		// Token: 0x06000E7E RID: 3710 RVA: 0x0003D994 File Offset: 0x0003BB94
		protected override void PrepareContainerForItemOverride(global::System.Windows.DependencyObject element, object item)
		{
			if (global::Infragistics.Windows.DataPresenter.FieldMenuItem._showKeyboardCuesProperty != null)
			{
				global::Infragistics.Windows.DataPresenter.FieldMenuItem fieldMenuItem = this;
				while (!(fieldMenuItem.TemplatedParent is global::Infragistics.Windows.DataPresenter.FilterButton))
				{
					global::Infragistics.Windows.DataPresenter.FieldMenuItem fieldMenuItem2 = global::System.Windows.Controls.ItemsControl.ItemsControlFromItemContainer(fieldMenuItem) as global::Infragistics.Windows.DataPresenter.FieldMenuItem;
					if (fieldMenuItem2 == null)
					{
						break;
					}
					fieldMenuItem = fieldMenuItem2;
				}
				if (fieldMenuItem.TemplatedParent is global::Infragistics.Windows.DataPresenter.FilterButton)
				{
					element.SetValue(global::Infragistics.Windows.DataPresenter.FieldMenuItem._showKeyboardCuesProperty, global::Infragistics.KnownBoxes.TrueBox);
				}
			}
			base.PrepareContainerForItemOverride(element, item);
		}

		// Token: 0x040005A0 RID: 1440
		internal static global::System.Windows.DependencyProperty _showKeyboardCuesProperty;

		// Token: 0x040005A1 RID: 1441
		private bool _isShiftingFocusPrevious;
	}
}
