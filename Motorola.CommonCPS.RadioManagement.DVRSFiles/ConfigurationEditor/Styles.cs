using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using Motorola.CommonCPS.RadioManagement.Controls;

namespace Motorola.CommonCPS.RadioManagement.ConfigurationEditor
{
	// Token: 0x02000002 RID: 2
	public class Styles
	{
		// Token: 0x06000001 RID: 1 RVA: 0x00002050 File Offset: 0x00000250
		private void ctmActions_Opened(object sender, global::System.Windows.RoutedEventArgs e)
		{
			this.ShowOpenedContextMenu(sender);
		}

		// Token: 0x06000002 RID: 2 RVA: 0x00002059 File Offset: 0x00000259
		private void ctmName_Opened(object sender, global::System.Windows.RoutedEventArgs e)
		{
			this.ShowOpenedContextMenu(sender);
		}

		// Token: 0x06000003 RID: 3 RVA: 0x00002064 File Offset: 0x00000264
		private void ShowOpenedContextMenu(object sender)
		{
			global::System.Windows.Controls.ContextMenu contextMenu = (global::System.Windows.Controls.ContextMenu)sender;
			contextMenu.DataContext = this.GetAncestor<global::System.Windows.Controls.UserControl>(contextMenu.PlacementTarget).DataContext;
		}

		// Token: 0x06000004 RID: 4 RVA: 0x00002090 File Offset: 0x00000290
		private void lkbActions_Click(object sender, global::System.Windows.RoutedEventArgs e)
		{
			global::Motorola.CommonCPS.RadioManagement.Controls.RMLinkButton rmlinkButton = (global::Motorola.CommonCPS.RadioManagement.Controls.RMLinkButton)sender;
			global::System.Windows.Controls.ContextMenu contextMenu = rmlinkButton.ContextMenu;
			contextMenu.PlacementTarget = rmlinkButton;
			contextMenu.Visibility = global::System.Windows.Visibility.Visible;
			contextMenu.IsOpen = true;
			this.GetAncestor<global::System.Windows.Controls.ListBoxItem>(rmlinkButton).IsSelected = true;
		}

		// Token: 0x06000005 RID: 5 RVA: 0x000020CB File Offset: 0x000002CB
		private void lkbActions_MouseRightButtonDown(object sender, global::System.Windows.Input.MouseButtonEventArgs e)
		{
			e.Handled = true;
			((global::Motorola.CommonCPS.RadioManagement.Controls.RMLinkButton)sender).ContextMenu.Visibility = global::System.Windows.Visibility.Collapsed;
		}

		// Token: 0x06000006 RID: 6 RVA: 0x000020E5 File Offset: 0x000002E5
		private void tblName_MouseRightButtonDown(object sender, global::System.Windows.Input.MouseButtonEventArgs e)
		{
			global::System.Windows.Controls.ContextMenu contextMenu = ((global::System.Windows.Controls.TextBlock)sender).ContextMenu;
		}

		// Token: 0x06000007 RID: 7 RVA: 0x000020F4 File Offset: 0x000002F4
		private T GetAncestor<T>(global::System.Windows.DependencyObject control) where T : global::System.Windows.FrameworkElement
		{
			global::System.Windows.DependencyObject parent = global::System.Windows.Media.VisualTreeHelper.GetParent(control);
			T t = parent as T;
			if (t == null)
			{
				return this.GetAncestor<T>(parent);
			}
			return t;
		}
	}
}
