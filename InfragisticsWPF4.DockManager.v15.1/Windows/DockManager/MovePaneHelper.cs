using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Data;
using Infragistics.Windows.Controls;

namespace Infragistics.Windows.DockManager
{
	// Token: 0x0200002F RID: 47
	internal class MovePaneHelper : global::System.Windows.DependencyObject, global::System.IDisposable
	{
		// Token: 0x0600027F RID: 639 RVA: 0x0000D1C8 File Offset: 0x0000B3C8
		internal MovePaneHelper(global::Infragistics.Windows.DockManager.XamDockManager dockManager, global::Infragistics.Windows.DockManager.IContentPaneContainer newContainer, params global::Infragistics.Windows.DockManager.ContentPane[] panes)
		{
			global::Infragistics.CoreUtilities.ValidateNotNull(newContainer);
			global::System.Windows.FrameworkElement containerElement = newContainer.ContainerElement;
			this._newContainer = newContainer;
			this._newContainerElement = newContainer.ContainerElement;
			this._dockManager = dockManager;
			this._panes = new global::System.Collections.Generic.Dictionary<global::Infragistics.Windows.DockManager.ContentPane, object>();
			if (this._dockManager != null && this._newContainerElement != null)
			{
				global::System.Windows.Data.BindingOperations.SetBinding(this, global::Infragistics.Windows.DockManager.MovePaneHelper.ToolWindowProperty, global::Infragistics.Windows.Utilities.CreateBindingObject(global::Infragistics.Windows.Controls.ToolWindow.ToolWindowProperty, global::System.Windows.Data.BindingMode.OneWay, this._newContainerElement));
			}
			foreach (global::Infragistics.Windows.DockManager.ContentPane pane in panes)
			{
				this.AddPaneToBeMoved(pane);
			}
		}

		// Token: 0x06000280 RID: 640 RVA: 0x0000D255 File Offset: 0x0000B455
		private static void OnHasVisibleChildrenPendingChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			d.CoerceValue(global::System.Windows.UIElement.VisibilityProperty);
		}

		// Token: 0x06000281 RID: 641 RVA: 0x0000D262 File Offset: 0x0000B462
		public static bool GetHasVisibleChildrenPending(global::System.Windows.DependencyObject d)
		{
			return (bool)d.GetValue(global::Infragistics.Windows.DockManager.MovePaneHelper.HasVisibleChildrenPendingProperty);
		}

		// Token: 0x06000282 RID: 642 RVA: 0x0000D274 File Offset: 0x0000B474
		private static void SetHasVisibleChildrenPending(global::System.Windows.DependencyObject d, bool value)
		{
			d.SetValue(global::Infragistics.Windows.DockManager.MovePaneHelper.HasVisibleChildrenPendingProperty, value);
		}

		// Token: 0x06000283 RID: 643 RVA: 0x0000D288 File Offset: 0x0000B488
		private static void OnToolWindowChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.DockManager.MovePaneHelper movePaneHelper = d as global::Infragistics.Windows.DockManager.MovePaneHelper;
			global::Infragistics.Windows.DockManager.PaneToolWindow paneToolWindow = e.NewValue as global::Infragistics.Windows.DockManager.PaneToolWindow;
			if (e.OldValue != e.NewValue && (paneToolWindow == null || global::Infragistics.Windows.DockManager.XamDockManager.GetDockManager(paneToolWindow) == movePaneHelper._dockManager))
			{
				movePaneHelper.OnToolWindowChanged(movePaneHelper._toolWindow, paneToolWindow);
			}
		}

		// Token: 0x06000284 RID: 644 RVA: 0x0000D2D7 File Offset: 0x0000B4D7
		private void OnToolWindowChanged(global::Infragistics.Windows.DockManager.PaneToolWindow oldWindow, global::Infragistics.Windows.DockManager.PaneToolWindow newWindow)
		{
			this._toolWindow = newWindow;
			if (oldWindow != null)
			{
				oldWindow.ResumeSyncShow();
			}
			if (newWindow != null)
			{
				newWindow.SuspendSyncShow();
			}
		}

		// Token: 0x17000077 RID: 119
		// (get) Token: 0x06000285 RID: 645 RVA: 0x0000D2F2 File Offset: 0x0000B4F2
		// (set) Token: 0x06000286 RID: 646 RVA: 0x0000D304 File Offset: 0x0000B504
		private global::Infragistics.Windows.Controls.ToolWindow ToolWindow
		{
			get
			{
				return (global::Infragistics.Windows.Controls.ToolWindow)base.GetValue(global::Infragistics.Windows.DockManager.MovePaneHelper.ToolWindowProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DockManager.MovePaneHelper.ToolWindowProperty, value);
			}
		}

		// Token: 0x06000287 RID: 647 RVA: 0x0000D314 File Offset: 0x0000B514
		internal void AddPaneToBeMoved(global::Infragistics.Windows.DockManager.ContentPane pane)
		{
			if (!this._panes.ContainsKey(pane))
			{
				this._panes[pane] = null;
				if (pane.Visibility != global::System.Windows.Visibility.Collapsed && this._newContainerElement != null && this._dockManager != null)
				{
					this._newContainerElement.SetValue(global::Infragistics.Windows.DockManager.MovePaneHelper.HasVisibleChildrenPendingProperty, global::Infragistics.KnownBoxes.TrueBox);
				}
			}
		}

		// Token: 0x06000288 RID: 648 RVA: 0x0000D36A File Offset: 0x0000B56A
		void global::System.IDisposable.Dispose()
		{
			if (this._dockManager != null)
			{
				this._dockManager = null;
				this._newContainerElement.ClearValue(global::Infragistics.Windows.DockManager.MovePaneHelper.HasVisibleChildrenPendingProperty);
				global::System.Windows.Data.BindingOperations.ClearBinding(this, global::Infragistics.Windows.DockManager.MovePaneHelper.ToolWindowProperty);
			}
		}

		// Token: 0x04000164 RID: 356
		private global::Infragistics.Windows.DockManager.XamDockManager _dockManager;

		// Token: 0x04000165 RID: 357
		private global::Infragistics.Windows.DockManager.IContentPaneContainer _newContainer;

		// Token: 0x04000166 RID: 358
		private global::System.Windows.FrameworkElement _newContainerElement;

		// Token: 0x04000167 RID: 359
		private global::System.Collections.Generic.Dictionary<global::Infragistics.Windows.DockManager.ContentPane, object> _panes;

		// Token: 0x04000168 RID: 360
		private global::Infragistics.Windows.DockManager.PaneToolWindow _toolWindow;

		// Token: 0x04000169 RID: 361
		private static readonly global::System.Windows.DependencyProperty HasVisibleChildrenPendingProperty = global::System.Windows.DependencyProperty.RegisterAttached("HasVisibleChildrenPending", typeof(bool), typeof(global::Infragistics.Windows.DockManager.MovePaneHelper), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DockManager.MovePaneHelper.OnHasVisibleChildrenPendingChanged)));

		// Token: 0x0400016A RID: 362
		public static readonly global::System.Windows.DependencyProperty ToolWindowProperty = global::System.Windows.DependencyProperty.Register("ToolWindow", typeof(global::Infragistics.Windows.Controls.ToolWindow), typeof(global::Infragistics.Windows.DockManager.MovePaneHelper), new global::System.Windows.FrameworkPropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DockManager.MovePaneHelper.OnToolWindowChanged)));
	}
}
