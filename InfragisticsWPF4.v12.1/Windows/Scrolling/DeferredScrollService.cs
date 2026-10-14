using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;

namespace Infragistics.Windows.Scrolling
{
	// Token: 0x020001FA RID: 506
	public static class DeferredScrollService
	{
		// Token: 0x06001324 RID: 4900 RVA: 0x00046300 File Offset: 0x00044500
		public static void RegisterDeferredScrollHost(global::System.Type classType)
		{
			if (null == classType)
			{
				throw new global::System.ArgumentNullException("classType");
			}
			if (!typeof(global::Infragistics.Windows.Scrolling.IDeferredScrollHost).IsAssignableFrom(classType))
			{
				throw new global::System.ArgumentException(global::SR.GetString("LE_ArgumentException_5"));
			}
			global::System.Windows.EventManager.RegisterClassHandler(classType, global::System.Windows.Controls.Primitives.Thumb.DragStartedEvent, new global::System.Windows.Controls.Primitives.DragStartedEventHandler(global::Infragistics.Windows.Scrolling.DeferredScrollService.OnThumbDragStarted), true);
			global::System.Windows.EventManager.RegisterClassHandler(classType, global::System.Windows.Controls.Primitives.Thumb.DragCompletedEvent, new global::System.Windows.Controls.Primitives.DragCompletedEventHandler(global::Infragistics.Windows.Scrolling.DeferredScrollService.OnThumbDragCompleted), true);
		}

		// Token: 0x06001325 RID: 4901 RVA: 0x00046374 File Offset: 0x00044574
		private static void OnThumbDragCompleted(object sender, global::System.Windows.Controls.Primitives.DragCompletedEventArgs e)
		{
			global::System.Windows.DependencyObject dependencyObject = sender as global::System.Windows.DependencyObject;
			global::Infragistics.Windows.Scrolling.IDeferredScrollPanel deferredScrollPanel = dependencyObject.GetValue(global::Infragistics.Windows.Scrolling.DeferredScrollService.DeferredScrollPanel) as global::Infragistics.Windows.Scrolling.IDeferredScrollPanel;
			if (deferredScrollPanel == null)
			{
				return;
			}
			deferredScrollPanel.OnThumbDragComplete(e.Canceled);
		}

		// Token: 0x06001326 RID: 4902 RVA: 0x000463AC File Offset: 0x000445AC
		private static void OnThumbDragStarted(object sender, global::System.Windows.Controls.Primitives.DragStartedEventArgs e)
		{
			global::Infragistics.Windows.Scrolling.IDeferredScrollHost deferredScrollHost = sender as global::Infragistics.Windows.Scrolling.IDeferredScrollHost;
			global::Infragistics.Windows.Scrolling.IDeferredScrollPanel scrollPanel = deferredScrollHost.ScrollPanel;
			if (scrollPanel == null)
			{
				return;
			}
			global::System.Windows.Controls.Primitives.Thumb thumb = e.OriginalSource as global::System.Windows.Controls.Primitives.Thumb;
			if (thumb == null)
			{
				return;
			}
			global::System.Windows.Controls.Primitives.ScrollBar scrollBar = thumb.TemplatedParent as global::System.Windows.Controls.Primitives.ScrollBar;
			if (scrollBar == null)
			{
				return;
			}
			global::System.Windows.Controls.ScrollViewer scrollViewer = scrollBar.TemplatedParent as global::System.Windows.Controls.ScrollViewer;
			if (scrollViewer == null)
			{
				return;
			}
			if (scrollPanel.SupportsDeferredScrolling(scrollBar.Orientation, scrollViewer))
			{
				global::System.Windows.DependencyObject dependencyObject = deferredScrollHost as global::System.Windows.DependencyObject;
				dependencyObject.SetValue(global::Infragistics.Windows.Scrolling.DeferredScrollService.DeferredScrollPanel, scrollPanel);
				scrollPanel.OnThumbDragStart(thumb, scrollBar.Orientation);
			}
		}

		// Token: 0x040009E0 RID: 2528
		private static readonly global::System.Windows.DependencyProperty DeferredScrollPanel = global::System.Windows.DependencyProperty.Register("DeferredScrollPanel", typeof(global::Infragistics.Windows.Scrolling.IDeferredScrollPanel), typeof(global::Infragistics.Windows.Scrolling.IDeferredScrollHost));
	}
}
