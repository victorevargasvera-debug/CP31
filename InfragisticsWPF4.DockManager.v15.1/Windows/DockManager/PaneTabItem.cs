using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Automation.Peers;
using System.Windows.Controls;
using System.Windows.Input;
using Infragistics.Windows.Automation.Peers.DockManager;
using Infragistics.Windows.Controls;
using Infragistics.Windows.DockManager.Dragging;
using Infragistics.Windows.Themes;

namespace Infragistics.Windows.DockManager
{
	// Token: 0x0200008B RID: 139
	[global::System.ComponentModel.DesignTimeVisible(false)]
	public class PaneTabItem : global::Infragistics.Windows.Controls.TabItemEx
	{
		// Token: 0x06000507 RID: 1287 RVA: 0x0001B7D4 File Offset: 0x000199D4
		static PaneTabItem()
		{
			global::System.Windows.FrameworkElement.DefaultStyleKeyProperty.OverrideMetadata(typeof(global::Infragistics.Windows.DockManager.PaneTabItem), new global::System.Windows.FrameworkPropertyMetadata(typeof(global::Infragistics.Windows.DockManager.PaneTabItem)));
			global::System.Windows.UIElement.FocusableProperty.OverrideMetadata(typeof(global::Infragistics.Windows.DockManager.PaneTabItem), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox));
			global::System.Windows.Controls.Control.HorizontalContentAlignmentProperty.OverrideMetadata(typeof(global::Infragistics.Windows.DockManager.PaneTabItem), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.HorizontalAlignmentStretchBox));
			global::System.Windows.Controls.Control.VerticalContentAlignmentProperty.OverrideMetadata(typeof(global::Infragistics.Windows.DockManager.PaneTabItem), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.VerticalAlignmentStretchBox));
			global::System.Windows.EventManager.RegisterClassHandler(typeof(global::Infragistics.Windows.DockManager.PaneTabItem), global::System.Windows.FrameworkElement.ContextMenuOpeningEvent, new global::System.Windows.Controls.ContextMenuEventHandler(global::Infragistics.Windows.DockManager.ContentPane.OnPaneContextMenuOpening));
			global::Infragistics.Windows.DockManager.MouseHoverService.Register(typeof(global::Infragistics.Windows.DockManager.PaneTabItem));
			global::System.Windows.EventManager.RegisterClassHandler(typeof(global::Infragistics.Windows.DockManager.PaneTabItem), global::Infragistics.Windows.DockManager.MouseHoverService.MouseHoverEvent, new global::System.Windows.Input.MouseEventHandler(global::Infragistics.Windows.DockManager.PaneTabItem.OnMouseHover));
		}

		// Token: 0x06000508 RID: 1288 RVA: 0x0001B930 File Offset: 0x00019B30
		protected override global::System.Windows.Automation.Peers.AutomationPeer OnCreateAutomationPeer()
		{
			return new global::Infragistics.Windows.Automation.Peers.DockManager.PaneTabItemWrapperAutomationPeer(this);
		}

		// Token: 0x06000509 RID: 1289 RVA: 0x0001B938 File Offset: 0x00019B38
		protected override void OnContentChanged(object oldContent, object newContent)
		{
			base.OnContentChanged(oldContent, newContent);
			base.SetValue(global::Infragistics.Windows.DockManager.PaneTabItem.PanePropertyKey, newContent as global::Infragistics.Windows.DockManager.ContentPane);
		}

		// Token: 0x0600050A RID: 1290 RVA: 0x0001B954 File Offset: 0x00019B54
		protected override void OnMouseDown(global::System.Windows.Input.MouseButtonEventArgs e)
		{
			base.OnMouseDown(e);
			global::Infragistics.Windows.DockManager.ContentPane pane = this.Pane;
			if (pane != null)
			{
				if (e.ChangedButton == global::System.Windows.Input.MouseButton.Left)
				{
					if (e.ClickCount == 2)
					{
						if (pane.ExecuteCommand(global::Infragistics.Windows.DockManager.ContentPaneCommands.ToggleDockedState))
						{
							e.Handled = true;
						}
					}
					else if (e.ClickCount == 1 && this.IsUnpinned && global::System.Windows.Input.Keyboard.Modifiers == global::System.Windows.Input.ModifierKeys.Shift && pane.ExecuteCommand(global::Infragistics.Windows.DockManager.ContentPaneCommands.TogglePinnedState))
					{
						pane.ActivateInternal();
						e.Handled = true;
					}
				}
				else if (e.ChangedButton == global::System.Windows.Input.MouseButton.Middle && global::Infragistics.Windows.DockManager.XamDockManager.GetPaneLocation(this) == global::Infragistics.Windows.DockManager.PaneLocation.Document && pane.ExecuteCommand(global::Infragistics.Windows.DockManager.ContentPaneCommands.Close))
				{
					e.Handled = true;
				}
				if (!e.Handled)
				{
					bool force = false;
					global::Infragistics.Windows.DockManager.XamDockManager dockManager = global::Infragistics.Windows.DockManager.XamDockManager.GetDockManager(pane);
					if (dockManager != null && !pane.IsPinned && pane != dockManager.CurrentFlyoutPane)
					{
						force = true;
					}
					pane.ActivateInternal(force);
					global::Infragistics.Windows.DockManager.Dragging.DragManager.ProcessMouseDown(this, e);
				}
			}
		}

		// Token: 0x0600050B RID: 1291 RVA: 0x0001BA2E File Offset: 0x00019C2E
		protected override void OnMouseEnter(global::System.Windows.Input.MouseEventArgs e)
		{
			base.OnMouseEnter(e);
			if (this.IsUnpinned)
			{
				global::Infragistics.Windows.DockManager.UnpinnedTabFlyout.ShowFlyoutOnMouseEnter(this.Pane);
			}
		}

		// Token: 0x0600050C RID: 1292 RVA: 0x0001BA4A File Offset: 0x00019C4A
		protected override void OnMouseLeave(global::System.Windows.Input.MouseEventArgs e)
		{
			base.OnMouseLeave(e);
			if (this.IsUnpinned)
			{
				global::Infragistics.Windows.DockManager.UnpinnedTabFlyout.HideFlyoutOnMouseLeave(this.Pane);
			}
		}

		// Token: 0x17000112 RID: 274
		// (get) Token: 0x0600050D RID: 1293 RVA: 0x0001BA66 File Offset: 0x00019C66
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.ReadOnly(true)]
		public global::Infragistics.Windows.DockManager.ContentPane Pane
		{
			get
			{
				return (global::Infragistics.Windows.DockManager.ContentPane)base.GetValue(global::Infragistics.Windows.DockManager.PaneTabItem.PaneProperty);
			}
		}

		// Token: 0x17000113 RID: 275
		// (get) Token: 0x0600050E RID: 1294 RVA: 0x0001BA78 File Offset: 0x00019C78
		private bool IsUnpinned
		{
			get
			{
				return global::Infragistics.Windows.DockManager.PaneLocation.Unpinned == global::Infragistics.Windows.DockManager.XamDockManager.GetPaneLocation(this);
			}
		}

		// Token: 0x0600050F RID: 1295 RVA: 0x0001BA84 File Offset: 0x00019C84
		private static void OnMouseHover(object sender, global::System.Windows.Input.MouseEventArgs e)
		{
			global::Infragistics.Windows.DockManager.PaneTabItem paneTabItem = (global::Infragistics.Windows.DockManager.PaneTabItem)sender;
			if (paneTabItem != null && paneTabItem.IsUnpinned && paneTabItem.Pane != null)
			{
				global::Infragistics.Windows.DockManager.XamDockManager dockManager = global::Infragistics.Windows.DockManager.XamDockManager.GetDockManager(paneTabItem);
				if (dockManager != null)
				{
					dockManager.ShowFlyout(paneTabItem.Pane, false, true);
				}
			}
		}

		// Token: 0x04000335 RID: 821
		public static readonly global::System.Windows.ResourceKey DockableTabItemTemplateKey = new global::Infragistics.Windows.Themes.StaticPropertyResourceKey(typeof(global::Infragistics.Windows.DockManager.PaneTabItem), "DockableTabItemTemplateKey");

		// Token: 0x04000336 RID: 822
		public static readonly global::System.Windows.ResourceKey DocumentTabItemTemplateKey = new global::Infragistics.Windows.Themes.StaticPropertyResourceKey(typeof(global::Infragistics.Windows.DockManager.PaneTabItem), "DocumentTabItemTemplateKey");

		// Token: 0x04000337 RID: 823
		public static readonly global::System.Windows.ResourceKey UnpinnedTabItemTemplateKey = new global::Infragistics.Windows.Themes.StaticPropertyResourceKey(typeof(global::Infragistics.Windows.DockManager.PaneTabItem), "UnpinnedTabItemTemplateKey");

		// Token: 0x04000338 RID: 824
		private static readonly global::System.Windows.DependencyPropertyKey PanePropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("Pane", typeof(global::Infragistics.Windows.DockManager.ContentPane), typeof(global::Infragistics.Windows.DockManager.PaneTabItem), new global::System.Windows.FrameworkPropertyMetadata(null));

		// Token: 0x04000339 RID: 825
		public static readonly global::System.Windows.DependencyProperty PaneProperty = global::Infragistics.Windows.DockManager.PaneTabItem.PanePropertyKey.DependencyProperty;
	}
}
