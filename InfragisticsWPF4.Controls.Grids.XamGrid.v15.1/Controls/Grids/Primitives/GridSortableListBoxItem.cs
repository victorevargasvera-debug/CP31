using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Input;
using System.Windows.Media;

namespace Infragistics.Controls.Grids.Primitives
{
	// Token: 0x020001D6 RID: 470
	public class GridSortableListBoxItem : global::System.Windows.Controls.ListBoxItem
	{
		// Token: 0x06000C76 RID: 3190 RVA: 0x0002C1EC File Offset: 0x0002A3EC
		public GridSortableListBoxItem()
		{
			this.PopupElement = new global::System.Windows.Controls.Primitives.Popup();
			this.PopupElement.Placement = global::System.Windows.Controls.Primitives.PlacementMode.Relative;
			this.PopupElement.AllowsTransparency = true;
			base.DefaultStyleKey = typeof(global::Infragistics.Controls.Grids.Primitives.GridSortableListBoxItem);
		}

		// Token: 0x170003AF RID: 943
		// (get) Token: 0x06000C77 RID: 3191 RVA: 0x0002C227 File Offset: 0x0002A427
		// (set) Token: 0x06000C78 RID: 3192 RVA: 0x0002C239 File Offset: 0x0002A439
		public bool IsMovable
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.Controls.Grids.Primitives.GridSortableListBoxItem.IsMovableProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Grids.Primitives.GridSortableListBoxItem.IsMovableProperty, value);
			}
		}

		// Token: 0x06000C79 RID: 3193 RVA: 0x0002C24C File Offset: 0x0002A44C
		private static void IsMovableChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Grids.Primitives.GridSortableListBoxItem gridSortableListBoxItem = (global::Infragistics.Controls.Grids.Primitives.GridSortableListBoxItem)obj;
			if (gridSortableListBoxItem._dragHandle != null)
			{
				if (gridSortableListBoxItem.IsMovable)
				{
					gridSortableListBoxItem._dragHandle.Cursor = gridSortableListBoxItem._originalCursor;
					return;
				}
				gridSortableListBoxItem._dragHandle.Cursor = global::System.Windows.Input.Cursors.Arrow;
			}
		}

		// Token: 0x06000C7A RID: 3194 RVA: 0x0002C294 File Offset: 0x0002A494
		public override void OnApplyTemplate()
		{
			base.OnApplyTemplate();
			if (this._dragHandle != null)
			{
				this._dragHandle.RemoveHandler(global::System.Windows.UIElement.MouseLeftButtonDownEvent, new global::System.Windows.Input.MouseButtonEventHandler(this.SortableListBoxItem_MouseLeftButtonDown));
			}
			this._dragHandle = (base.GetTemplateChild("DragHandle") as global::System.Windows.FrameworkElement);
			if (this._dragHandle != null)
			{
				this._originalCursor = this._dragHandle.Cursor;
				this._dragHandle.AddHandler(global::System.Windows.UIElement.MouseLeftButtonDownEvent, new global::System.Windows.Input.MouseButtonEventHandler(this.SortableListBoxItem_MouseLeftButtonDown), true);
				if (!this.IsMovable)
				{
					this._dragHandle.Cursor = global::System.Windows.Input.Cursors.Arrow;
				}
			}
		}

		// Token: 0x06000C7B RID: 3195 RVA: 0x0002C330 File Offset: 0x0002A530
		private void SortableListBoxItem_MouseLeftButtonDown(object sender, global::System.Windows.Input.MouseButtonEventArgs e)
		{
			if (this.PopupElement != null && this.IsMovable)
			{
				if (this._parent == null)
				{
					global::System.Windows.DependencyObject dependencyObject = this;
					while (dependencyObject != null && this._parent == null)
					{
						dependencyObject = global::System.Windows.Media.VisualTreeHelper.GetParent(dependencyObject);
						this._parent = (dependencyObject as global::Infragistics.Controls.Grids.Primitives.GridSortableListBox);
					}
					if (this._parent != null)
					{
						global::System.Windows.FrameworkElement frameworkElement = this._parent;
						for (global::System.Windows.DependencyObject dependencyObject2 = frameworkElement; dependencyObject2 != null; dependencyObject2 = global::Infragistics.PlatformProxy.GetParent(dependencyObject2, false))
						{
							global::System.Windows.FrameworkElement frameworkElement2 = dependencyObject2 as global::System.Windows.FrameworkElement;
							if (frameworkElement2 != null)
							{
								frameworkElement = frameworkElement2;
							}
						}
						frameworkElement.FlowDirection = this._parent.FlowDirection;
						this.PopupElement.PlacementTarget = frameworkElement;
					}
				}
				if (this._parent != null && this._parent.ItemsSource != null)
				{
					this._parent.SetItem(this);
				}
			}
		}

		// Token: 0x0400040D RID: 1037
		internal global::System.Windows.Controls.Primitives.Popup PopupElement;

		// Token: 0x0400040E RID: 1038
		private global::System.Windows.FrameworkElement _dragHandle;

		// Token: 0x0400040F RID: 1039
		private global::Infragistics.Controls.Grids.Primitives.GridSortableListBox _parent;

		// Token: 0x04000410 RID: 1040
		private global::System.Windows.Input.Cursor _originalCursor;

		// Token: 0x04000411 RID: 1041
		public static readonly global::System.Windows.DependencyProperty IsMovableProperty = global::System.Windows.DependencyProperty.Register("IsMovable", typeof(bool), typeof(global::Infragistics.Controls.Grids.Primitives.GridSortableListBoxItem), new global::System.Windows.PropertyMetadata(false, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Grids.Primitives.GridSortableListBoxItem.IsMovableChanged)));
	}
}
