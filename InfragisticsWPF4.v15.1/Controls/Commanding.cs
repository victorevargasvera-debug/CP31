using System;
using System.Windows;

namespace Infragistics.Controls
{
	// Token: 0x020000C8 RID: 200
	public static class Commanding
	{
		// Token: 0x0600077D RID: 1917 RVA: 0x0001B2DD File Offset: 0x000194DD
		public static global::Infragistics.Controls.CommandSource GetCommand(global::System.Windows.FrameworkElement element)
		{
			return (global::Infragistics.Controls.CommandSource)element.GetValue(global::Infragistics.Controls.Commanding.CommandProperty);
		}

		// Token: 0x0600077E RID: 1918 RVA: 0x0001B2EF File Offset: 0x000194EF
		public static void SetCommand(global::System.Windows.FrameworkElement element, global::Infragistics.Controls.CommandSource command)
		{
			element.SetValue(global::Infragistics.Controls.Commanding.CommandProperty, command);
		}

		// Token: 0x0600077F RID: 1919 RVA: 0x0001B300 File Offset: 0x00019500
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

		// Token: 0x06000780 RID: 1920 RVA: 0x0001B344 File Offset: 0x00019544
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

		// Token: 0x06000781 RID: 1921 RVA: 0x0001B387 File Offset: 0x00019587
		public static void SetCommands(global::System.Windows.FrameworkElement elem, global::Infragistics.CommandSourceCollection commands)
		{
			elem.SetValue(global::Infragistics.Controls.Commanding.CommandsProperty, commands);
		}

		// Token: 0x06000782 RID: 1922 RVA: 0x0001B398 File Offset: 0x00019598
		private static void OnCommandsChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.CommandSourceCollection commandSourceCollection = (global::Infragistics.CommandSourceCollection)e.NewValue;
			if (commandSourceCollection != null)
			{
				commandSourceCollection.Element = (obj as global::System.Windows.FrameworkElement);
			}
		}

		// Token: 0x06000783 RID: 1923 RVA: 0x0001B3C1 File Offset: 0x000195C1
		public static global::System.Windows.FrameworkElement GetCommandTarget(global::System.Windows.FrameworkElement element)
		{
			return (global::System.Windows.FrameworkElement)element.GetValue(global::Infragistics.Controls.Commanding.CommandTargetProperty);
		}

		// Token: 0x06000784 RID: 1924 RVA: 0x0001B3D3 File Offset: 0x000195D3
		public static void SetCommandTarget(global::System.Windows.FrameworkElement element, global::System.Windows.FrameworkElement commandTarget)
		{
			element.SetValue(global::Infragistics.Controls.Commanding.CommandTargetProperty, commandTarget);
		}

		// Token: 0x06000785 RID: 1925 RVA: 0x0001B3E1 File Offset: 0x000195E1
		private static void OnCommandTargetChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
		}

		// Token: 0x040003B4 RID: 948
		public static readonly global::System.Windows.DependencyProperty CommandProperty = global::System.Windows.DependencyProperty.RegisterAttached("Command", typeof(global::Infragistics.Controls.CommandSource), typeof(global::Infragistics.Controls.Commanding), new global::System.Windows.PropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Commanding.OnCommandChanged)));

		// Token: 0x040003B5 RID: 949
		public static readonly global::System.Windows.DependencyProperty CommandsProperty = global::System.Windows.DependencyProperty.RegisterAttached("Commands", typeof(global::Infragistics.CommandSourceCollection), typeof(global::Infragistics.Controls.Commanding), new global::System.Windows.PropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Commanding.OnCommandsChanged)));

		// Token: 0x040003B6 RID: 950
		public static readonly global::System.Windows.DependencyProperty CommandTargetProperty = global::System.Windows.DependencyProperty.RegisterAttached("CommandTarget", typeof(global::System.Windows.FrameworkElement), typeof(global::Infragistics.Controls.Commanding), new global::System.Windows.PropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Commanding.OnCommandTargetChanged)));
	}
}
