using System;
using System.Windows;

namespace Infragistics.Controls
{
	// Token: 0x020000AE RID: 174
	public static class Commanding
	{
		// Token: 0x06000697 RID: 1687 RVA: 0x00017B8D File Offset: 0x00015D8D
		public static global::Infragistics.Controls.CommandSource GetCommand(global::System.Windows.FrameworkElement element)
		{
			return (global::Infragistics.Controls.CommandSource)element.GetValue(global::Infragistics.Controls.Commanding.CommandProperty);
		}

		// Token: 0x06000698 RID: 1688 RVA: 0x00017B9F File Offset: 0x00015D9F
		public static void SetCommand(global::System.Windows.FrameworkElement element, global::Infragistics.Controls.CommandSource command)
		{
			element.SetValue(global::Infragistics.Controls.Commanding.CommandProperty, command);
		}

		// Token: 0x06000699 RID: 1689 RVA: 0x00017BB0 File Offset: 0x00015DB0
		private static void OnCommandChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::System.Windows.FrameworkElement elem = obj as global::System.Windows.FrameworkElement;
			global::Infragistics.Controls.CommandSource commandSource = e.OldValue as global::Infragistics.Controls.CommandSource;
			if (commandSource != null)
			{
				global::Infragistics.CommandSourceManager.UnregisterCommandSource(commandSource);
			}
			global::Infragistics.Controls.CommandSource commandSource2 = e.NewValue as global::Infragistics.Controls.CommandSource;
			if (commandSource2 != null)
			{
				global::Infragistics.CommandSourceManager.RegisterCommandSource(commandSource2, elem);
			}
		}

		// Token: 0x0600069A RID: 1690 RVA: 0x00017BF4 File Offset: 0x00015DF4
		public static global::Infragistics.CommandSourceCollection GetCommands(global::System.Windows.FrameworkElement element)
		{
			global::Infragistics.CommandSourceCollection commandSourceCollection = (global::Infragistics.CommandSourceCollection)element.GetValue(global::Infragistics.Controls.Commanding.CommandsProperty);
			if (commandSourceCollection == null)
			{
				commandSourceCollection = new global::Infragistics.CommandSourceCollection();
				element.SetValue(global::Infragistics.Controls.Commanding.CommandsProperty, commandSourceCollection);
			}
			if (commandSourceCollection.Element == null)
			{
				commandSourceCollection.Element = element;
			}
			return commandSourceCollection;
		}

		// Token: 0x0600069B RID: 1691 RVA: 0x00017C37 File Offset: 0x00015E37
		public static void SetCommands(global::System.Windows.FrameworkElement elem, global::Infragistics.CommandSourceCollection commands)
		{
			elem.SetValue(global::Infragistics.Controls.Commanding.CommandsProperty, commands);
		}

		// Token: 0x0600069C RID: 1692 RVA: 0x00017C48 File Offset: 0x00015E48
		private static void OnCommandsChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.CommandSourceCollection commandSourceCollection = (global::Infragistics.CommandSourceCollection)e.NewValue;
			if (commandSourceCollection != null)
			{
				commandSourceCollection.Element = (obj as global::System.Windows.FrameworkElement);
			}
		}

		// Token: 0x0600069D RID: 1693 RVA: 0x00017C71 File Offset: 0x00015E71
		public static global::System.Windows.FrameworkElement GetCommandTarget(global::System.Windows.FrameworkElement element)
		{
			return (global::System.Windows.FrameworkElement)element.GetValue(global::Infragistics.Controls.Commanding.CommandTargetProperty);
		}

		// Token: 0x0600069E RID: 1694 RVA: 0x00017C83 File Offset: 0x00015E83
		public static void SetCommandTarget(global::System.Windows.FrameworkElement element, global::System.Windows.FrameworkElement commandTarget)
		{
			element.SetValue(global::Infragistics.Controls.Commanding.CommandTargetProperty, commandTarget);
		}

		// Token: 0x0600069F RID: 1695 RVA: 0x00017C91 File Offset: 0x00015E91
		private static void OnCommandTargetChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
		}

		// Token: 0x04000310 RID: 784
		public static readonly global::System.Windows.DependencyProperty CommandProperty = global::System.Windows.DependencyProperty.RegisterAttached("Command", typeof(global::Infragistics.Controls.CommandSource), typeof(global::Infragistics.Controls.Commanding), new global::System.Windows.PropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Commanding.OnCommandChanged)));

		// Token: 0x04000311 RID: 785
		public static readonly global::System.Windows.DependencyProperty CommandsProperty = global::System.Windows.DependencyProperty.RegisterAttached("Commands", typeof(global::Infragistics.CommandSourceCollection), typeof(global::Infragistics.Controls.Commanding), new global::System.Windows.PropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Commanding.OnCommandsChanged)));

		// Token: 0x04000312 RID: 786
		public static readonly global::System.Windows.DependencyProperty CommandTargetProperty = global::System.Windows.DependencyProperty.RegisterAttached("CommandTarget", typeof(global::System.Windows.FrameworkElement), typeof(global::Infragistics.Controls.Commanding), new global::System.Windows.PropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Commanding.OnCommandTargetChanged)));
	}
}
