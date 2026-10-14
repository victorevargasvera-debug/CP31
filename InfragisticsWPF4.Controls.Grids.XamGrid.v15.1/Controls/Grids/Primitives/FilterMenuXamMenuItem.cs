using System;
using System.ComponentModel;
using System.Windows;
using Infragistics.Controls.Menus;

namespace Infragistics.Controls.Grids.Primitives
{
	// Token: 0x020000C7 RID: 199
	public class FilterMenuXamMenuItem : global::Infragistics.Controls.Menus.XamMenuItem, global::System.ComponentModel.INotifyPropertyChanged
	{
		// Token: 0x060006E7 RID: 1767 RVA: 0x0001DDAC File Offset: 0x0001BFAC
		public FilterMenuXamMenuItem()
		{
			base.DefaultStyleKey = typeof(global::Infragistics.Controls.Grids.Primitives.FilterMenuXamMenuItem);
		}

		// Token: 0x060006E8 RID: 1768 RVA: 0x0001DDC4 File Offset: 0x0001BFC4
		protected override global::System.Windows.DependencyObject GetContainerForItemOverride()
		{
			global::Infragistics.Controls.Grids.Primitives.FilterMenuXamMenuItem filterMenuXamMenuItem = null;
			if (base.DefaultItemsContainer != null)
			{
				filterMenuXamMenuItem = (base.DefaultItemsContainer.LoadContent() as global::Infragistics.Controls.Grids.Primitives.FilterMenuXamMenuItem);
			}
			if (filterMenuXamMenuItem == null)
			{
				return new global::Infragistics.Controls.Grids.Primitives.FilterMenuXamMenuItem();
			}
			return filterMenuXamMenuItem;
		}

		// Token: 0x060006E9 RID: 1769 RVA: 0x0001DDF6 File Offset: 0x0001BFF6
		protected override void ChangeVisualState(bool useTransitions)
		{
			base.ChangeVisualState(useTransitions);
			if (this.IsSeparator)
			{
				global::System.Windows.VisualStateManager.GoToState(this, "IsSeperator", useTransitions);
				return;
			}
			global::System.Windows.VisualStateManager.GoToState(this, "IsNotSeperator", useTransitions);
		}

		// Token: 0x060006EA RID: 1770 RVA: 0x0001DE22 File Offset: 0x0001C022
		protected override void OnPropertyChanged(string name)
		{
			base.OnPropertyChanged(name);
			if (name == "ParentItemsControl")
			{
				this.OnPropertyChanged("ParentMenu");
			}
		}

		// Token: 0x060006EB RID: 1771 RVA: 0x0001DE43 File Offset: 0x0001C043
		protected override void UpdateRoleState()
		{
			base.UpdateRoleState();
			if (base.Role == global::Infragistics.Controls.Menus.MenuItemRole.SubmenuHeader)
			{
				base.SetValue(global::Infragistics.Controls.Menus.XamMenuItem.CheckBoxVisibilityResolvedProperty, global::System.Windows.Visibility.Visible);
			}
			if (base.Role == global::Infragistics.Controls.Menus.MenuItemRole.TopLevelHeader)
			{
				base.SetValue(global::Infragistics.Controls.Menus.XamMenuItem.CheckBoxVisibilityResolvedProperty, global::System.Windows.Visibility.Collapsed);
			}
		}

		// Token: 0x17000216 RID: 534
		// (get) Token: 0x060006EC RID: 1772 RVA: 0x0001DE7F File Offset: 0x0001C07F
		// (set) Token: 0x060006ED RID: 1773 RVA: 0x0001DE91 File Offset: 0x0001C091
		public bool IsSeparator
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.Controls.Grids.Primitives.FilterMenuXamMenuItem.IsSeparatorProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Grids.Primitives.FilterMenuXamMenuItem.IsSeparatorProperty, value);
			}
		}

		// Token: 0x060006EE RID: 1774 RVA: 0x0001DEA4 File Offset: 0x0001C0A4
		private static void IsSeperatorChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Grids.Primitives.FilterMenuXamMenuItem filterMenuXamMenuItem = (global::Infragistics.Controls.Grids.Primitives.FilterMenuXamMenuItem)obj;
			filterMenuXamMenuItem.OnPropertyChanged("IsSeparator");
			filterMenuXamMenuItem.IsHitTestVisible = !filterMenuXamMenuItem.IsSeparator;
			filterMenuXamMenuItem.IsTabStop = !filterMenuXamMenuItem.IsSeparator;
			filterMenuXamMenuItem.IsKeyboardNavigable = !filterMenuXamMenuItem.IsSeparator;
			filterMenuXamMenuItem.ChangeVisualState(false);
		}

		// Token: 0x17000217 RID: 535
		// (get) Token: 0x060006EF RID: 1775 RVA: 0x0001DEF7 File Offset: 0x0001C0F7
		// (set) Token: 0x060006F0 RID: 1776 RVA: 0x0001DF09 File Offset: 0x0001C109
		public global::Infragistics.Controls.Grids.CellBase Cell
		{
			get
			{
				return (global::Infragistics.Controls.Grids.CellBase)base.GetValue(global::Infragistics.Controls.Grids.Primitives.FilterMenuXamMenuItem.CellProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Grids.Primitives.FilterMenuXamMenuItem.CellProperty, value);
			}
		}

		// Token: 0x060006F1 RID: 1777 RVA: 0x0001DF18 File Offset: 0x0001C118
		private static void CellChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Grids.Primitives.FilterMenuXamMenuItem filterMenuXamMenuItem = (global::Infragistics.Controls.Grids.Primitives.FilterMenuXamMenuItem)obj;
			filterMenuXamMenuItem.OnPropertyChanged("Cell");
			if (filterMenuXamMenuItem.Cell != null && filterMenuXamMenuItem.DataContext != null)
			{
				global::Infragistics.Controls.Grids.FilterMenuTrackingObject filterMenuTrackingObject = filterMenuXamMenuItem.DataContext as global::Infragistics.Controls.Grids.FilterMenuTrackingObject;
			}
		}

		// Token: 0x17000218 RID: 536
		// (get) Token: 0x060006F2 RID: 1778 RVA: 0x0001DF55 File Offset: 0x0001C155
		public global::Infragistics.Controls.Menus.XamMenuBase ParentMenu
		{
			get
			{
				return base.ParentXamMenu;
			}
		}

		// Token: 0x040001C2 RID: 450
		public static readonly global::System.Windows.DependencyProperty IsSeparatorProperty = global::System.Windows.DependencyProperty.Register("IsSeparator", typeof(bool), typeof(global::Infragistics.Controls.Grids.Primitives.FilterMenuXamMenuItem), new global::System.Windows.PropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Grids.Primitives.FilterMenuXamMenuItem.IsSeperatorChanged)));

		// Token: 0x040001C3 RID: 451
		public static readonly global::System.Windows.DependencyProperty CellProperty = global::System.Windows.DependencyProperty.Register("Cell", typeof(global::Infragistics.Controls.Grids.CellBase), typeof(global::Infragistics.Controls.Grids.Primitives.FilterMenuXamMenuItem), new global::System.Windows.PropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Grids.Primitives.FilterMenuXamMenuItem.CellChanged)));
	}
}
