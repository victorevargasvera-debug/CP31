using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Interactivity;

namespace Microsoft.Expression.Interactivity.Core
{
	// Token: 0x02000024 RID: 36
	public class RemoveElementAction : global::System.Windows.Interactivity.TargetedTriggerAction<global::System.Windows.FrameworkElement>
	{
		// Token: 0x0600016B RID: 363 RVA: 0x0000888C File Offset: 0x00006A8C
		protected override void Invoke(object parameter)
		{
			if (base.AssociatedObject != null && base.Target != null)
			{
				global::System.Windows.DependencyObject parent = base.Target.Parent;
				global::System.Windows.Controls.Panel panel = parent as global::System.Windows.Controls.Panel;
				if (panel != null)
				{
					panel.Children.Remove(base.Target);
					return;
				}
				global::System.Windows.Controls.ContentControl contentControl = parent as global::System.Windows.Controls.ContentControl;
				if (contentControl != null)
				{
					if (contentControl.Content == base.Target)
					{
						contentControl.Content = null;
					}
					return;
				}
				global::System.Windows.Controls.ItemsControl itemsControl = parent as global::System.Windows.Controls.ItemsControl;
				if (itemsControl != null)
				{
					itemsControl.Items.Remove(base.Target);
					return;
				}
				global::System.Windows.Controls.Page page = parent as global::System.Windows.Controls.Page;
				if (page != null)
				{
					if (page.Content == base.Target)
					{
						page.Content = null;
					}
					return;
				}
				global::System.Windows.Controls.Decorator decorator = parent as global::System.Windows.Controls.Decorator;
				if (decorator != null)
				{
					if (decorator.Child == base.Target)
					{
						decorator.Child = null;
					}
					return;
				}
				if (parent != null)
				{
					throw new global::System.InvalidOperationException(global::ExceptionStringTable.UnsupportedRemoveTargetExceptionMessage);
				}
			}
		}
	}
}
