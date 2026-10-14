using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using Infragistics.Windows.Themes;

namespace Infragistics.Windows.Controls
{
	// Token: 0x02000227 RID: 551
	[global::System.ComponentModel.DesignTimeVisible(false)]
	public class MousePanningDecorator : global::System.Windows.Documents.AdornerDecorator
	{
		// Token: 0x060014C8 RID: 5320 RVA: 0x0004AE30 File Offset: 0x00049030
		protected override void OnMouseDown(global::System.Windows.Input.MouseButtonEventArgs e)
		{
			if (!e.Handled && e.ChangedButton == global::System.Windows.Input.MouseButton.Middle)
			{
				global::System.Windows.Controls.ScrollViewer scrollViewer = null;
				do
				{
					global::System.Windows.DependencyObject source = scrollViewer ?? (e.OriginalSource as global::System.Windows.DependencyObject);
					scrollViewer = (global::System.Windows.Controls.ScrollViewer)global::Infragistics.Windows.Controls.MousePanningDecorator.GetAncestor(source, typeof(global::System.Windows.Controls.ScrollViewer), this);
				}
				while (scrollViewer != null && !global::Infragistics.Windows.Controls.MousePanningAdorner.CanScroll(scrollViewer));
				if (scrollViewer != null)
				{
					global::System.Windows.Point position = e.GetPosition(scrollViewer);
					global::System.Windows.Documents.AdornerLayer adornerLayer = global::System.Windows.Documents.AdornerLayer.GetAdornerLayer(scrollViewer);
					if (adornerLayer != null)
					{
						global::Infragistics.Windows.Controls.MousePanningAdorner mousePanningAdorner = new global::Infragistics.Windows.Controls.MousePanningAdorner(scrollViewer, position.X, position.Y);
						adornerLayer.Add(mousePanningAdorner);
						if (mousePanningAdorner.CaptureMouse())
						{
							e.Handled = true;
							return;
						}
						adornerLayer.Remove(mousePanningAdorner);
					}
				}
			}
			base.OnMouseDown(e);
		}

		// Token: 0x060014C9 RID: 5321 RVA: 0x0004AEDC File Offset: 0x000490DC
		private static global::System.Windows.DependencyObject GetAncestor(global::System.Windows.DependencyObject source, global::System.Type ancestorType, global::System.Windows.DependencyObject stopAtElement)
		{
			global::System.Windows.DependencyObject dependencyObject = (source != null) ? global::Infragistics.Windows.Utilities.GetParent(source) : null;
			while (dependencyObject != null && dependencyObject != stopAtElement)
			{
				if (ancestorType.IsAssignableFrom(dependencyObject.GetType()))
				{
					return dependencyObject;
				}
				dependencyObject = global::Infragistics.Windows.Utilities.GetParent(dependencyObject);
			}
			return null;
		}

		// Token: 0x04000B1A RID: 2842
		public static readonly global::System.Windows.ResourceKey ScrollAllImageKey = new global::Infragistics.Windows.Themes.StaticPropertyResourceKey(typeof(global::Infragistics.Windows.Controls.MousePanningDecorator), "ScrollAllImageKey");

		// Token: 0x04000B1B RID: 2843
		public static readonly global::System.Windows.ResourceKey ScrollNSImageKey = new global::Infragistics.Windows.Themes.StaticPropertyResourceKey(typeof(global::Infragistics.Windows.Controls.MousePanningDecorator), "ScrollNSImageKey");

		// Token: 0x04000B1C RID: 2844
		public static readonly global::System.Windows.ResourceKey ScrollEWImageKey = new global::Infragistics.Windows.Themes.StaticPropertyResourceKey(typeof(global::Infragistics.Windows.Controls.MousePanningDecorator), "ScrollEWImageKey");
	}
}
