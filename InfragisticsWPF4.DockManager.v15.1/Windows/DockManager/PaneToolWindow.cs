using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Threading;
using Infragistics.Collections;
using Infragistics.Windows.Commands;
using Infragistics.Windows.Controls;
using Infragistics.Windows.DockManager.Dragging;
using Infragistics.Windows.DockManager.Events;
using Infragistics.Windows.Helpers;
using Infragistics.Windows.Themes;

namespace Infragistics.Windows.DockManager
{
	// Token: 0x0200008C RID: 140
	[global::System.ComponentModel.DesignTimeVisible(false)]
	public class PaneToolWindow : global::Infragistics.Windows.Controls.ToolWindow, global::Infragistics.Windows.Commands.ICommandHost, global::Infragistics.Windows.DockManager.IPaneContainer
	{
		// Token: 0x06000510 RID: 1296 RVA: 0x0001BAC4 File Offset: 0x00019CC4
		static PaneToolWindow()
		{
			global::Infragistics.Windows.Themes.ThemeManager.RegisterGroupings(typeof(global::Infragistics.Windows.DockManager.PaneToolWindow), new string[]
			{
				global::Infragistics.Windows.Themes.PrimitivesResourceSet<global::Infragistics.Windows.Themes.PrimitivesGeneric.Locator>.Location.Grouping,
				global::Infragistics.Windows.Themes.DockManagerResourceSet<global::Infragistics.Windows.Themes.DockManagerGeneric.Locator>.Location.Grouping
			});
			global::Infragistics.Windows.Controls.ToolWindow.LeftProperty.OverrideMetadata(typeof(global::Infragistics.Windows.DockManager.PaneToolWindow), new global::System.Windows.FrameworkPropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DockManager.PaneToolWindow.OnTopLeftChanged)));
			global::Infragistics.Windows.Controls.ToolWindow.TopProperty.OverrideMetadata(typeof(global::Infragistics.Windows.DockManager.PaneToolWindow), new global::System.Windows.FrameworkPropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DockManager.PaneToolWindow.OnTopLeftChanged)));
			global::System.Windows.FrameworkElement.WidthProperty.OverrideMetadata(typeof(global::Infragistics.Windows.DockManager.PaneToolWindow), new global::System.Windows.FrameworkPropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DockManager.PaneToolWindow.OnWidthHeightChanged)));
			global::System.Windows.FrameworkElement.HeightProperty.OverrideMetadata(typeof(global::Infragistics.Windows.DockManager.PaneToolWindow), new global::System.Windows.FrameworkPropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DockManager.PaneToolWindow.OnWidthHeightChanged)));
			global::System.Windows.EventManager.RegisterClassHandler(typeof(global::Infragistics.Windows.DockManager.PaneToolWindow), global::Infragistics.Windows.DockManager.DockManagerUtilities.VisibilityChangedEvent, new global::System.Windows.RoutedEventHandler(global::Infragistics.Windows.DockManager.PaneToolWindow.OnChildVisibilityChanged));
			global::System.Windows.UIElement.VisibilityProperty.OverrideMetadata(typeof(global::Infragistics.Windows.DockManager.PaneToolWindow), new global::System.Windows.FrameworkPropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DockManager.PaneToolWindow.OnVisibilityChanged), new global::System.Windows.CoerceValueCallback(global::Infragistics.Windows.DockManager.PaneToolWindow.CoerceVisibility)));
			global::Infragistics.Windows.DockManager.XamDockManager.DockManagerPropertyKey.OverrideMetadata(typeof(global::Infragistics.Windows.DockManager.PaneToolWindow), new global::System.Windows.FrameworkPropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DockManager.PaneToolWindow.OnDockManagerChanged)));
			global::Infragistics.Windows.Commands.Commands<global::Infragistics.Windows.DockManager.PaneToolWindow>.Initialize(global::Infragistics.Windows.DockManager.DockManagerCommands.GetCommandWrappers());
			global::Infragistics.Windows.Controls.ToolWindow.UseOSNonClientAreaProperty.OverrideMetadata(typeof(global::Infragistics.Windows.DockManager.PaneToolWindow), new global::System.Windows.FrameworkPropertyMetadata(null, new global::System.Windows.CoerceValueCallback(global::Infragistics.Windows.DockManager.PaneToolWindow.CoerceUseOSNonClientArea)));
		}

		// Token: 0x06000511 RID: 1297 RVA: 0x0001BD64 File Offset: 0x00019F64
		public PaneToolWindow()
		{
			global::System.Windows.NameScope.SetNameScope(this, new global::Infragistics.Windows.DockManager.PaneToolWindow.OwnerNameScope(this));
			base.Loaded += delegate(object sender, global::System.Windows.RoutedEventArgs e)
			{
				this.SynchronizeContentPaneFloatingRect();
				base.LayoutUpdated += this.OnLayoutUpdated;
			};
			base.Unloaded += delegate(object sender, global::System.Windows.RoutedEventArgs e)
			{
				base.LayoutUpdated -= this.OnLayoutUpdated;
			};
			base.AddHandler(global::System.Windows.Input.CommandManager.CanExecuteEvent, new global::System.Windows.Input.CanExecuteRoutedEventHandler(global::Infragistics.Windows.DockManager.PaneToolWindow.OnCanExecuteCommand));
			base.AddHandler(global::System.Windows.Input.CommandManager.ExecutedEvent, new global::System.Windows.Input.ExecutedRoutedEventHandler(global::Infragistics.Windows.DockManager.PaneToolWindow.OnExecuteCommand));
			global::System.Windows.Input.KeyEventHandler value = new global::System.Windows.Input.KeyEventHandler(global::Infragistics.Windows.DockManager.DockManagerUtilities.OnToolWindowKeyEvent);
			base.PreviewKeyDown += value;
			base.PreviewKeyUp += value;
			base.KeyDown += value;
			base.KeyUp += value;
		}

		// Token: 0x06000512 RID: 1298 RVA: 0x0001BE0C File Offset: 0x0001A00C
		internal override void CloseOverride()
		{
			global::Infragistics.Windows.DockManager.XamDockManager dockManager = global::Infragistics.Windows.DockManager.XamDockManager.GetDockManager(this);
			if (dockManager != null)
			{
				dockManager.DragManager.OnToolWindowClosing(this);
			}
			if (this.ForceRemainOpen)
			{
				return;
			}
			base.CloseOverride();
		}

		// Token: 0x06000513 RID: 1299 RVA: 0x0001BE40 File Offset: 0x0001A040
		protected override global::System.Windows.Controls.ContextMenu CreateDefaultContextMenu(object originalSource)
		{
			global::System.Windows.DependencyObject dependencyObject = originalSource as global::System.Windows.DependencyObject;
			global::Infragistics.Windows.DockManager.SplitPane splitPane = base.Content as global::Infragistics.Windows.DockManager.SplitPane;
			while (dependencyObject is global::System.Windows.ContentElement)
			{
				dependencyObject = global::System.Windows.LogicalTreeHelper.GetParent(dependencyObject);
			}
			if (dependencyObject is global::System.Windows.Media.Visual && splitPane != null && !splitPane.IsAncestorOf(dependencyObject))
			{
				this.VerifyActivePane();
				global::Infragistics.Windows.DockManager.ContentPane contentPane = this._activePane ?? global::Infragistics.Windows.DockManager.DockManagerUtilities.GetFirstLastPane(splitPane, true);
				if (contentPane != null)
				{
					global::System.Windows.Controls.ContextMenu contextMenu = new global::System.Windows.Controls.ContextMenu();
					contextMenu.SetValue(global::System.Windows.FrameworkElement.DefaultStyleKeyProperty, global::Infragistics.Windows.DockManager.XamDockManager.ContextMenuStyleKey);
					contentPane.InitializeMenu(contextMenu.Items);
					return contextMenu;
				}
			}
			return base.CreateDefaultContextMenu(originalSource);
		}

		// Token: 0x17000114 RID: 276
		// (get) Token: 0x06000514 RID: 1300 RVA: 0x0001BECC File Offset: 0x0001A0CC
		internal override bool KeepOnScreen
		{
			get
			{
				global::Infragistics.Windows.DockManager.XamDockManager dockManager = global::Infragistics.Windows.DockManager.XamDockManager.GetDockManager(this);
				return (dockManager == null || dockManager.DragManager.DragState == global::Infragistics.Windows.DockManager.Dragging.DragState.None || (base.Host != null && !base.Host.IsWindow)) && base.KeepOnScreen;
			}
		}

		// Token: 0x17000115 RID: 277
		// (get) Token: 0x06000515 RID: 1301 RVA: 0x0001BF10 File Offset: 0x0001A110
		protected override global::System.Collections.IEnumerator LogicalChildren
		{
			get
			{
				global::System.Collections.IEnumerator logicalChildren = base.LogicalChildren;
				if (this._dragHelper != null)
				{
					return new global::Infragistics.Collections.MultiSourceEnumerator(new global::System.Collections.IEnumerator[]
					{
						logicalChildren,
						new global::Infragistics.Collections.SingleItemEnumerator(this._dragHelper)
					});
				}
				return logicalChildren;
			}
		}

		// Token: 0x06000516 RID: 1302 RVA: 0x0001BF50 File Offset: 0x0001A150
		protected override void OnActivated(global::System.EventArgs e)
		{
			base.OnActivated(e);
			this.ActivatePaneIfNeeded();
			global::Infragistics.Windows.DockManager.XamDockManager dockManager = global::Infragistics.Windows.DockManager.XamDockManager.GetDockManager(this);
			if (dockManager != null)
			{
				dockManager.ActivePaneManager.OnToolWindowActivationChanged(this);
			}
		}

		// Token: 0x06000517 RID: 1303 RVA: 0x0001BF80 File Offset: 0x0001A180
		public override void OnApplyTemplate()
		{
			base.OnApplyTemplate();
			this._captionElement = (base.GetTemplateChild("PART_Caption") as global::System.Windows.FrameworkElement);
		}

		// Token: 0x06000518 RID: 1304 RVA: 0x0001BFA0 File Offset: 0x0001A1A0
		protected internal override void OnClosing(global::System.ComponentModel.CancelEventArgs e)
		{
			base.OnClosing(e);
			if (this._isReshowing)
			{
				return;
			}
			if (base.IsReshowing)
			{
				return;
			}
			if (!this.IsWindowLoaded)
			{
				e.Cancel = false;
				return;
			}
			global::Infragistics.Windows.DockManager.XamDockManager dockManager = global::Infragistics.Windows.DockManager.XamDockManager.GetDockManager(this);
			if (!e.Cancel && dockManager != null && dockManager.IsLoaded)
			{
				global::System.Collections.Generic.List<global::Infragistics.Windows.DockManager.ContentPane> list = new global::System.Collections.Generic.List<global::Infragistics.Windows.DockManager.ContentPane>();
				global::Infragistics.Windows.DockManager.SplitPane splitPane = base.Content as global::Infragistics.Windows.DockManager.SplitPane;
				global::Infragistics.Windows.DockManager.PaneFilterFlags filter = global::Infragistics.Windows.DockManager.PaneFilterFlags.AllVisible;
				for (global::Infragistics.Windows.DockManager.ContentPane contentPane = global::Infragistics.Windows.DockManager.DockManagerUtilities.GetFirstLastPane(splitPane, true, filter); contentPane != null; contentPane = global::Infragistics.Windows.DockManager.DockManagerUtilities.GetNextPreviousPane(contentPane, false, true, splitPane, filter))
				{
					if (contentPane.AllowClose)
					{
						list.Add(contentPane);
					}
				}
				bool isClosing = this._isClosing;
				this._isClosing = true;
				try
				{
					dockManager.ClosePanes(list);
				}
				finally
				{
					this._isClosing = isClosing;
				}
				e.Cancel = (null != global::Infragistics.Windows.DockManager.DockManagerUtilities.GetFirstLastPane(splitPane, true));
				if (e.Cancel)
				{
					this.RefreshToolWindowState();
					return;
				}
				if (base.IsKeyboardFocusWithin && dockManager.DragManager.DragState == global::Infragistics.Windows.DockManager.Dragging.DragState.ProcessingDrop)
				{
					dockManager.ForceFocus(dockManager.DragHelper);
				}
			}
		}

		// Token: 0x06000519 RID: 1305 RVA: 0x0001C0B4 File Offset: 0x0001A2B4
		protected override void OnContentChanged(object oldContent, object newContent)
		{
			if (newContent != null && !(newContent is global::Infragistics.Windows.DockManager.SplitPane))
			{
				throw new global::System.InvalidOperationException(global::Infragistics.Windows.DockManager.XamDockManager.GetString("LE_InvalidPaneToolWindowContent"));
			}
			base.OnContentChanged(oldContent, newContent);
			global::Infragistics.Windows.DockManager.SplitPane splitPane = newContent as global::Infragistics.Windows.DockManager.SplitPane;
			if (splitPane != null)
			{
				base.SetBinding(global::System.Windows.UIElement.VisibilityProperty, global::Infragistics.Windows.Utilities.CreateBindingObject(global::System.Windows.UIElement.VisibilityProperty, global::System.Windows.Data.BindingMode.OneWay, newContent));
				base.SetBinding(global::Infragistics.Windows.DockManager.PaneToolWindow.FloatingLocationProperty, global::Infragistics.Windows.Utilities.CreateBindingObject(global::Infragistics.Windows.DockManager.XamDockManager.FloatingLocationProperty, global::System.Windows.Data.BindingMode.TwoWay, newContent));
				base.SetBinding(global::Infragistics.Windows.DockManager.PaneToolWindow.FloatingSizeProperty, global::Infragistics.Windows.Utilities.CreateBindingObject(global::Infragistics.Windows.DockManager.XamDockManager.FloatingSizeProperty, global::System.Windows.Data.BindingMode.TwoWay, newContent));
			}
			else
			{
				global::System.Windows.Data.BindingOperations.ClearBinding(this, global::System.Windows.UIElement.VisibilityProperty);
				global::System.Windows.Data.BindingOperations.ClearBinding(this, global::Infragistics.Windows.DockManager.PaneToolWindow.FloatingLocationProperty);
				global::System.Windows.Data.BindingOperations.ClearBinding(this, global::Infragistics.Windows.DockManager.PaneToolWindow.FloatingSizeProperty);
			}
			this.RefreshToolWindowState();
			base.SetValue(global::Infragistics.Windows.DockManager.PaneToolWindow.PanePropertyKey, splitPane);
		}

		// Token: 0x0600051A RID: 1306 RVA: 0x0001C16C File Offset: 0x0001A36C
		protected override void OnDeactivated(global::System.EventArgs e)
		{
			base.OnDeactivated(e);
			global::Infragistics.Windows.DockManager.XamDockManager dockManager = global::Infragistics.Windows.DockManager.XamDockManager.GetDockManager(this);
			if (dockManager != null)
			{
				dockManager.ActivePaneManager.OnToolWindowActivationChanged(this);
			}
		}

		// Token: 0x0600051B RID: 1307 RVA: 0x0001C198 File Offset: 0x0001A398
		protected internal override bool OnDoubleClickCaption(global::System.Windows.Point pt, global::System.Windows.Input.MouseDevice mouse)
		{
			global::Infragistics.Windows.DockManager.XamDockManager dockManager = global::Infragistics.Windows.DockManager.XamDockManager.GetDockManager(this);
			if (dockManager != null)
			{
				global::Infragistics.Windows.DockManager.FloatingWindowDoubleClickAction? floatingWindowDoubleClickAction = dockManager.FloatingWindowDoubleClickAction;
				if (floatingWindowDoubleClickAction == null)
				{
					if (base.OnDoubleClickCaption(pt, mouse))
					{
						return true;
					}
				}
				else if (floatingWindowDoubleClickAction == global::Infragistics.Windows.DockManager.FloatingWindowDoubleClickAction.ToggleWindowState)
				{
					return base.OnDoubleClickCaption(pt, mouse);
				}
			}
			if (global::Infragistics.Windows.DockManager.XamDockManager.GetPaneLocation(this) == global::Infragistics.Windows.DockManager.PaneLocation.Floating)
			{
				global::Infragistics.Windows.DockManager.SplitPane splitPane = base.Content as global::Infragistics.Windows.DockManager.SplitPane;
				if (splitPane != null)
				{
					global::System.Collections.Generic.List<global::Infragistics.Windows.DockManager.ContentPane> allPanes = global::Infragistics.Windows.DockManager.DockManagerUtilities.GetAllPanes(splitPane, global::Infragistics.Windows.DockManager.PaneFilterFlags.AllVisible);
					bool flag = false;
					if (dockManager != null)
					{
						flag = dockManager.ToggleDockedState(allPanes, true);
					}
					if (flag)
					{
						return true;
					}
				}
			}
			return true;
		}

		// Token: 0x0600051C RID: 1308 RVA: 0x0001C228 File Offset: 0x0001A428
		protected internal override bool OnDragCaption(global::System.Windows.Point pt, global::System.Windows.Input.MouseDevice mouse)
		{
			if (base.WindowState == global::System.Windows.WindowState.Minimized)
			{
				return base.OnDragCaption(pt, mouse);
			}
			global::Infragistics.Windows.DockManager.XamDockManager dockManager = global::Infragistics.Windows.DockManager.XamDockManager.GetDockManager(this);
			if (dockManager != null && base.Host != null && base.Host.IsWindow && (dockManager.FloatingWindowDragMode == global::Infragistics.Windows.DockManager.FloatingWindowDragMode.UseSystemWindowDrag || base.IsNonClientTouchDrag))
			{
				bool flag = dockManager.DragManager.OnWindowBeforeDrag(this, pt, mouse);
				return !flag;
			}
			bool flag2 = null != dockManager;
			if (flag2)
			{
				switch (global::Infragistics.Windows.DockManager.XamDockManager.GetPaneLocation(this))
				{
				case global::Infragistics.Windows.DockManager.PaneLocation.Floating:
					break;
				case global::Infragistics.Windows.DockManager.PaneLocation.FloatingOnly:
					if (dockManager.DragFullWindows)
					{
						flag2 = false;
					}
					break;
				default:
					flag2 = false;
					break;
				}
			}
			if (flag2)
			{
				return dockManager.DragManager.StartWindowDrag(this, pt, mouse);
			}
			return base.OnDragCaption(pt, mouse);
		}

		// Token: 0x0600051D RID: 1309 RVA: 0x0001C2D8 File Offset: 0x0001A4D8
		internal override bool OnEnterMove()
		{
			base.OnEnterMove();
			global::Infragistics.Windows.DockManager.XamDockManager dockManager = global::Infragistics.Windows.DockManager.XamDockManager.GetDockManager(this);
			if (dockManager == null)
			{
				return false;
			}
			if (!dockManager.DragManager.IsDragging)
			{
				return false;
			}
			dockManager.DragManager.OnWindowDragStart(this);
			return true;
		}

		// Token: 0x0600051E RID: 1310 RVA: 0x0001C314 File Offset: 0x0001A514
		internal override bool OnExitMove()
		{
			bool flag = base.OnExitMove();
			global::Infragistics.Windows.DockManager.XamDockManager dockManager = global::Infragistics.Windows.DockManager.XamDockManager.GetDockManager(this);
			if (dockManager != null && dockManager.DragManager != null)
			{
				flag |= dockManager.DragManager.OnWindowDragEnd(this);
			}
			return flag;
		}

		// Token: 0x0600051F RID: 1311 RVA: 0x0001C34A File Offset: 0x0001A54A
		protected override void OnInitialized(global::System.EventArgs e)
		{
			base.OnInitialized(e);
		}

		// Token: 0x06000520 RID: 1312 RVA: 0x0001C354 File Offset: 0x0001A554
		protected override void OnKeyDown(global::System.Windows.Input.KeyEventArgs e)
		{
			base.OnKeyDown(e);
			if (e.Handled)
			{
				return;
			}
			global::Infragistics.Windows.DockManager.XamDockManager dockManager = global::Infragistics.Windows.DockManager.XamDockManager.GetDockManager(this);
			if (dockManager != null)
			{
				dockManager.ProcessKeyDown(e);
			}
		}

		// Token: 0x06000521 RID: 1313 RVA: 0x0001C384 File Offset: 0x0001A584
		protected override void OnKeyUp(global::System.Windows.Input.KeyEventArgs e)
		{
			base.OnKeyUp(e);
			if (e.Handled)
			{
				return;
			}
			global::Infragistics.Windows.DockManager.XamDockManager dockManager = global::Infragistics.Windows.DockManager.XamDockManager.GetDockManager(this);
			if (dockManager != null)
			{
				dockManager.ProcessKeyUp(e);
			}
		}

		// Token: 0x06000522 RID: 1314 RVA: 0x0001C3B4 File Offset: 0x0001A5B4
		protected override void OnPreviewGotKeyboardFocus(global::System.Windows.Input.KeyboardFocusChangedEventArgs e)
		{
			if (this._dragHelper != null && e.NewFocus == this._dragHelper)
			{
				global::Infragistics.Windows.DockManager.XamDockManager dockManager = global::Infragistics.Windows.DockManager.XamDockManager.GetDockManager(this);
				if (dockManager == null || dockManager.DragManager.IsDragging)
				{
					return;
				}
				if (this._activePane == null)
				{
					this.VerifyActivePane();
				}
				if (this._activePane != null && this._activePane.CanActivate)
				{
					this._activePane.Activate();
					e.Handled = true;
				}
			}
		}

		// Token: 0x06000523 RID: 1315 RVA: 0x0001C428 File Offset: 0x0001A628
		internal override void OnMoveCancelled()
		{
			global::Infragistics.Windows.DockManager.XamDockManager dockManager = global::Infragistics.Windows.DockManager.XamDockManager.GetDockManager(this);
			if (dockManager != null)
			{
				dockManager.DragManager.OnWindowMoveCancelled(this);
			}
		}

		// Token: 0x06000524 RID: 1316 RVA: 0x0001C44C File Offset: 0x0001A64C
		internal override void OnWindowMoving(global::System.Windows.Point pt, global::System.Windows.Input.MouseDevice mouse, global::System.Windows.Rect logicalScreenRect)
		{
			global::Infragistics.Windows.DockManager.XamDockManager dockManager = global::Infragistics.Windows.DockManager.XamDockManager.GetDockManager(this);
			if (dockManager != null)
			{
				dockManager.DragManager.OnWindowDragging(this, pt, mouse, logicalScreenRect);
			}
		}

		// Token: 0x06000525 RID: 1317 RVA: 0x0001C472 File Offset: 0x0001A672
		internal override void OnWindowStateChanged()
		{
			base.OnWindowStateChanged();
			if (base.IsActive)
			{
				base.Dispatcher.BeginInvoke(global::System.Windows.Threading.DispatcherPriority.Background, new global::Infragistics.Windows.DockManager.DockManagerUtilities.MethodInvoker(this.VerifyActivePaneForWindowStateChange));
			}
		}

		// Token: 0x17000116 RID: 278
		// (get) Token: 0x06000526 RID: 1318 RVA: 0x0001C49B File Offset: 0x0001A69B
		protected override bool SupportsAllowsTransparency
		{
			get
			{
				return !global::Infragistics.Windows.DockManager.DockManagerUtilities.GetPreventAllowsTransparency(this);
			}
		}

		// Token: 0x17000117 RID: 279
		// (get) Token: 0x06000527 RID: 1319 RVA: 0x0001C4A6 File Offset: 0x0001A6A6
		protected sealed override bool SupportsShowDialog
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000118 RID: 280
		// (get) Token: 0x06000528 RID: 1320 RVA: 0x0001C4A9 File Offset: 0x0001A6A9
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.ReadOnly(true)]
		public global::Infragistics.Windows.DockManager.SplitPane Pane
		{
			get
			{
				return (global::Infragistics.Windows.DockManager.SplitPane)base.GetValue(global::Infragistics.Windows.DockManager.PaneToolWindow.PaneProperty);
			}
		}

		// Token: 0x06000529 RID: 1321 RVA: 0x0001C4BC File Offset: 0x0001A6BC
		private static void OnFloatingWindowCaptionSourceChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.DockManager.PaneToolWindow paneToolWindow = d as global::Infragistics.Windows.DockManager.PaneToolWindow;
			paneToolWindow.CoerceValue(global::Infragistics.Windows.Controls.ToolWindow.UseOSNonClientAreaProperty);
			paneToolWindow.VerifyCaptionVisibility();
			global::Infragistics.Windows.DockManager.ContentPane singlePane = paneToolWindow.SinglePane;
			if (singlePane != null)
			{
				singlePane.VerifyHeaderVisibility();
			}
		}

		// Token: 0x17000119 RID: 281
		// (get) Token: 0x0600052A RID: 1322 RVA: 0x0001C4F1 File Offset: 0x0001A6F1
		// (set) Token: 0x0600052B RID: 1323 RVA: 0x0001C503 File Offset: 0x0001A703
		[global::System.ComponentModel.Bindable(true)]
		public global::Infragistics.Windows.DockManager.FloatingWindowCaptionSource FloatingWindowCaptionSource
		{
			get
			{
				return (global::Infragistics.Windows.DockManager.FloatingWindowCaptionSource)base.GetValue(global::Infragistics.Windows.DockManager.PaneToolWindow.FloatingWindowCaptionSourceProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DockManager.PaneToolWindow.FloatingWindowCaptionSourceProperty, value);
			}
		}

		// Token: 0x1700011A RID: 282
		// (get) Token: 0x0600052C RID: 1324 RVA: 0x0001C516 File Offset: 0x0001A716
		internal new global::System.Windows.FrameworkElement CaptionElement
		{
			get
			{
				return this._captionElement;
			}
		}

		// Token: 0x1700011B RID: 283
		// (get) Token: 0x0600052D RID: 1325 RVA: 0x0001C520 File Offset: 0x0001A720
		internal global::System.Windows.FrameworkContentElement DragHelper
		{
			get
			{
				if (this._dragHelper == null)
				{
					this._dragHelper = new global::System.Windows.FrameworkContentElement();
					this._dragHelper.Name = "PaneToolWindowDragHelper";
					this._dragHelper.SetValue(global::System.Windows.ContentElement.FocusableProperty, global::Infragistics.KnownBoxes.TrueBox);
					base.AddLogicalChild(this._dragHelper);
				}
				return this._dragHelper;
			}
		}

		// Token: 0x1700011C RID: 284
		// (get) Token: 0x0600052E RID: 1326 RVA: 0x0001C577 File Offset: 0x0001A777
		// (set) Token: 0x0600052F RID: 1327 RVA: 0x0001C57F File Offset: 0x0001A77F
		internal bool ForceRemainOpen
		{
			get
			{
				return this._forceRemainOpen;
			}
			set
			{
				this._forceRemainOpen = value;
				base.CoerceValue(global::System.Windows.UIElement.VisibilityProperty);
				if (!value && (this.Pane == null || this.Pane.Visibility == global::System.Windows.Visibility.Collapsed))
				{
					base.Close();
				}
			}
		}

		// Token: 0x1700011D RID: 285
		// (get) Token: 0x06000530 RID: 1328 RVA: 0x0001C5B2 File Offset: 0x0001A7B2
		internal bool IsClosing
		{
			get
			{
				return this._isClosing;
			}
		}

		// Token: 0x1700011E RID: 286
		// (get) Token: 0x06000531 RID: 1329 RVA: 0x0001C5BA File Offset: 0x0001A7BA
		// (set) Token: 0x06000532 RID: 1330 RVA: 0x0001C5C4 File Offset: 0x0001A7C4
		internal bool IsWindowLoaded
		{
			get
			{
				return this._isWindowLoaded;
			}
			set
			{
				if (value != this._isWindowLoaded)
				{
					this._isWindowLoaded = value;
					global::Infragistics.Windows.DockManager.XamDockManager dockManager = global::Infragistics.Windows.DockManager.XamDockManager.GetDockManager(this);
					if (dockManager != null)
					{
						global::Infragistics.Windows.DockManager.Events.PaneToolWindowEventArgs args = new global::Infragistics.Windows.DockManager.Events.PaneToolWindowEventArgs(this);
						if (value)
						{
							global::Infragistics.Windows.DockManager.SplitPane splitPane = base.Content as global::Infragistics.Windows.DockManager.SplitPane;
							this._isRaiseWindowLoadedPending = true;
							if (base.Visibility != global::System.Windows.Visibility.Collapsed && splitPane != null && splitPane.Visibility != global::System.Windows.Visibility.Collapsed)
							{
								this.ShowHelper();
								return;
							}
							if (this._syncShowCount <= 0)
							{
								this.RaisePendingToolWindowLoaded();
								return;
							}
						}
						else
						{
							if (this._isRaiseWindowLoadedPending)
							{
								this._isRaiseWindowLoadedPending = false;
								return;
							}
							dockManager.RaiseToolWindowUnloaded(args);
							if (!this.IsClosing && !this.IsWindowLoaded && base.Owner != null)
							{
								base.Close();
							}
						}
					}
				}
			}
		}

		// Token: 0x1700011F RID: 287
		// (get) Token: 0x06000533 RID: 1331 RVA: 0x0001C66C File Offset: 0x0001A86C
		// (set) Token: 0x06000534 RID: 1332 RVA: 0x0001C674 File Offset: 0x0001A874
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.Browsable(false)]
		internal global::Infragistics.Windows.DockManager.ContentPane LastActivePane
		{
			get
			{
				return this._activePane;
			}
			set
			{
				this._activePane = value;
			}
		}

		// Token: 0x17000120 RID: 288
		// (get) Token: 0x06000535 RID: 1333 RVA: 0x0001C67D File Offset: 0x0001A87D
		// (set) Token: 0x06000536 RID: 1334 RVA: 0x0001C688 File Offset: 0x0001A888
		internal global::Infragistics.Windows.DockManager.ContentPane SinglePane
		{
			get
			{
				return this._singlePane;
			}
			private set
			{
				if (value != this._singlePane)
				{
					global::Infragistics.Windows.DockManager.ContentPane singlePane = this._singlePane;
					this._singlePane = value;
					if (singlePane != null && global::Infragistics.Windows.DockManager.PaneToolWindow.GetSinglePaneToolWindow(singlePane) == this)
					{
						singlePane.ClearValue(global::Infragistics.Windows.DockManager.PaneToolWindow.SinglePaneToolWindowPropertyKey);
					}
					if (this._singlePane != null)
					{
						this._singlePane.SetValue(global::Infragistics.Windows.DockManager.PaneToolWindow.SinglePaneToolWindowPropertyKey, this);
					}
					this.VerifyCaptionVisibility();
				}
			}
		}

		// Token: 0x06000537 RID: 1335 RVA: 0x0001C6E4 File Offset: 0x0001A8E4
		private static void OnSinglePaneToolWindowChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.DockManager.ContentPane contentPane = d as global::Infragistics.Windows.DockManager.ContentPane;
			if (contentPane == null)
			{
				return;
			}
			global::Infragistics.Windows.DockManager.PaneToolWindow paneToolWindow = e.NewValue as global::Infragistics.Windows.DockManager.PaneToolWindow;
			global::Infragistics.Windows.DockManager.PaneToolWindow paneToolWindow2 = e.OldValue as global::Infragistics.Windows.DockManager.PaneToolWindow;
			if (paneToolWindow2 != null)
			{
				global::System.Windows.Data.BindingOperations.ClearBinding(paneToolWindow2, global::Infragistics.Windows.Controls.ToolWindow.TitleProperty);
			}
			if (paneToolWindow != null)
			{
				paneToolWindow.RefreshSinglePaneTitle();
			}
			contentPane.VerifyHeaderVisibility();
		}

		// Token: 0x06000538 RID: 1336 RVA: 0x0001C733 File Offset: 0x0001A933
		internal static global::Infragistics.Windows.DockManager.PaneToolWindow GetSinglePaneToolWindow(global::System.Windows.DependencyObject d)
		{
			return (global::Infragistics.Windows.DockManager.PaneToolWindow)d.GetValue(global::Infragistics.Windows.DockManager.PaneToolWindow.SinglePaneToolWindowProperty);
		}

		// Token: 0x06000539 RID: 1337 RVA: 0x0001C745 File Offset: 0x0001A945
		private static void OnFloatingLocationChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			((global::Infragistics.Windows.DockManager.PaneToolWindow)d).SynchronizeLocation(false);
		}

		// Token: 0x17000121 RID: 289
		// (get) Token: 0x0600053A RID: 1338 RVA: 0x0001C753 File Offset: 0x0001A953
		// (set) Token: 0x0600053B RID: 1339 RVA: 0x0001C765 File Offset: 0x0001A965
		private global::System.Windows.Point? FloatingLocation
		{
			get
			{
				return (global::System.Windows.Point?)base.GetValue(global::Infragistics.Windows.DockManager.PaneToolWindow.FloatingLocationProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DockManager.PaneToolWindow.FloatingLocationProperty, value);
			}
		}

		// Token: 0x0600053C RID: 1340 RVA: 0x0001C778 File Offset: 0x0001A978
		private static void OnFloatingSizeChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			((global::Infragistics.Windows.DockManager.PaneToolWindow)d).SynchronizeSize(false);
		}

		// Token: 0x17000122 RID: 290
		// (get) Token: 0x0600053D RID: 1341 RVA: 0x0001C786 File Offset: 0x0001A986
		// (set) Token: 0x0600053E RID: 1342 RVA: 0x0001C798 File Offset: 0x0001A998
		private global::System.Windows.Size FloatingSize
		{
			get
			{
				return (global::System.Windows.Size)base.GetValue(global::Infragistics.Windows.DockManager.PaneToolWindow.FloatingSizeProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DockManager.PaneToolWindow.FloatingSizeProperty, value);
			}
		}

		// Token: 0x0600053F RID: 1343 RVA: 0x0001C7AB File Offset: 0x0001A9AB
		internal global::System.Windows.Size AddNonClientSize(global::System.Windows.Size arrangeBounds)
		{
			return base.CalculateNonClientSize(arrangeBounds);
		}

		// Token: 0x06000540 RID: 1344 RVA: 0x0001C7B4 File Offset: 0x0001A9B4
		internal void ClearDragHelperFocusedElement()
		{
			if (this._dragHelper == null)
			{
				return;
			}
			if (this._dragHelper.IsKeyboardFocused)
			{
				return;
			}
			global::System.Windows.DependencyObject focusScope = global::System.Windows.Input.FocusManager.GetFocusScope(this._dragHelper);
			if (focusScope == null || global::System.Windows.Input.FocusManager.GetFocusedElement(focusScope) != this._dragHelper)
			{
				return;
			}
			if (global::System.Windows.Input.Keyboard.FocusedElement == this._dragHelper)
			{
				global::System.Windows.Input.FocusManager.SetFocusedElement(focusScope, this);
				return;
			}
			global::Infragistics.Windows.DockManager.DockManagerUtilities.SetFocusedElement(focusScope, this);
		}

		// Token: 0x06000541 RID: 1345 RVA: 0x0001C814 File Offset: 0x0001AA14
		internal void RefreshSinglePaneTitle()
		{
			global::Infragistics.Windows.DockManager.ContentPane singlePane = this.SinglePane;
			if (singlePane == null)
			{
				base.ClearValue(global::Infragistics.Windows.Controls.ToolWindow.TitleProperty);
				return;
			}
			if (singlePane.Header is global::System.Windows.Controls.TextBlock)
			{
				base.SetBinding(global::Infragistics.Windows.Controls.ToolWindow.TitleProperty, global::Infragistics.Windows.Utilities.CreateBindingObject(global::System.Windows.Controls.TextBlock.TextProperty, global::System.Windows.Data.BindingMode.OneWay, singlePane.Header));
				return;
			}
			base.SetBinding(global::Infragistics.Windows.Controls.ToolWindow.TitleProperty, global::Infragistics.Windows.Utilities.CreateBindingObject(global::System.Windows.Controls.HeaderedContentControl.HeaderProperty, global::System.Windows.Data.BindingMode.OneWay, singlePane));
		}

		// Token: 0x06000542 RID: 1346 RVA: 0x0001C87C File Offset: 0x0001AA7C
		internal void RefreshToolWindowState()
		{
			global::Infragistics.Windows.DockManager.XamDockManager dockManager = global::Infragistics.Windows.DockManager.XamDockManager.GetDockManager(this);
			if (dockManager != null && dockManager.IsLoadingLayout)
			{
				return;
			}
			if (this._suspendReshowCount != 0)
			{
				return;
			}
			global::Infragistics.Windows.DockManager.SplitPane splitPane = base.Content as global::Infragistics.Windows.DockManager.SplitPane;
			global::Infragistics.Windows.DockManager.PaneFilterFlags filter = ~global::Infragistics.Windows.DockManager.PaneFilterFlags.Hidden;
			global::Infragistics.Windows.DockManager.ContentPane firstLastPane = global::Infragistics.Windows.DockManager.DockManagerUtilities.GetFirstLastPane(splitPane, true, filter);
			global::Infragistics.Windows.DockManager.ContentPane contentPane = (firstLastPane != null) ? global::Infragistics.Windows.DockManager.DockManagerUtilities.GetFirstLastPane(splitPane, false, filter) : null;
			global::Infragistics.Windows.DockManager.ContentPane contentPane2 = null;
			if (firstLastPane != null && contentPane != null && firstLastPane != contentPane)
			{
				global::Infragistics.Windows.DockManager.IPaneContainer parentPane = global::Infragistics.Windows.DockManager.DockManagerUtilities.GetParentPane(firstLastPane);
				global::Infragistics.Windows.DockManager.IPaneContainer parentPane2 = global::Infragistics.Windows.DockManager.DockManagerUtilities.GetParentPane(contentPane);
				if (parentPane == parentPane2 && parentPane is global::Infragistics.Windows.DockManager.TabGroupPane)
				{
					contentPane2 = (((global::Infragistics.Windows.DockManager.TabGroupPane)parentPane).SelectedItem as global::Infragistics.Windows.DockManager.ContentPane);
				}
			}
			if (contentPane2 == null && firstLastPane == contentPane)
			{
				contentPane2 = firstLastPane;
			}
			global::Infragistics.Windows.DockManager.ContentPane contentPane3 = firstLastPane;
			bool allowClose = false;
			while (contentPane3 != null)
			{
				if (contentPane3.AllowClose)
				{
					allowClose = true;
					break;
				}
				contentPane3 = global::Infragistics.Windows.DockManager.DockManagerUtilities.GetNextPreviousPane(contentPane3, false, true, splitPane, filter);
			}
			this.SinglePane = contentPane2;
			base.AllowClose = allowClose;
			this.VerifyActivePane();
			this.VerifyPreventAllowsTransparency();
		}

		// Token: 0x06000543 RID: 1347 RVA: 0x0001C960 File Offset: 0x0001AB60
		internal void ResumeSyncShow()
		{
			this._syncShowCount--;
			if (this._syncShowCount == 0)
			{
				if (this._pendingSyncShow != null)
				{
					global::System.IDisposable pendingSyncShow = this._pendingSyncShow;
					this._pendingSyncShow = null;
					global::Infragistics.Windows.DockManager.SplitPane splitPane = base.Content as global::Infragistics.Windows.DockManager.SplitPane;
					this.RaisePendingToolWindowLoaded();
					if (this.IsWindowLoaded && splitPane != null && splitPane.Visibility != global::System.Windows.Visibility.Collapsed)
					{
						global::System.Windows.DependencyObject dependencyObject;
						global::Infragistics.Windows.DockManager.XamDockManager xamDockManager;
						global::Infragistics.Windows.DockManager.DockManagerUtilities.BeforeShowToolWindow(this, base.Owner, out dependencyObject, out xamDockManager);
						pendingSyncShow.Dispose();
						return;
					}
					base.Close();
					return;
				}
				else
				{
					this.RaisePendingToolWindowLoaded();
				}
			}
		}

		// Token: 0x06000544 RID: 1348 RVA: 0x0001C9E3 File Offset: 0x0001ABE3
		internal void SuspendSyncShow()
		{
			this._syncShowCount++;
		}

		// Token: 0x06000545 RID: 1349 RVA: 0x0001C9F3 File Offset: 0x0001ABF3
		internal void VerifyPreventAllowsTransparency()
		{
			if (this._isReshowing)
			{
				return;
			}
			if (this._pendingVerifyAllowsTransparency == null)
			{
				this._pendingVerifyAllowsTransparency = base.Dispatcher.BeginInvoke(global::System.Windows.Threading.DispatcherPriority.Normal, new global::Infragistics.Windows.DockManager.DockManagerUtilities.MethodInvoker(this.VerifyPreventAllowsTransparencyImpl));
			}
		}

		// Token: 0x06000546 RID: 1350 RVA: 0x0001CA28 File Offset: 0x0001AC28
		private void VerifyPreventAllowsTransparencyImpl()
		{
			if (this._isReshowing)
			{
				return;
			}
			if (global::Infragistics.Windows.DockManager.XamDockManager.GetDockManager(this) == null)
			{
				return;
			}
			this._pendingVerifyAllowsTransparency = null;
			if (!base.IsVisible)
			{
				return;
			}
			this._isReshowing = true;
			try
			{
				bool flag = global::Infragistics.Windows.DockManager.DockManagerUtilities.CalculatePreventAllowsTransparency(this);
				if (base.IsVisible && flag && !global::Infragistics.Windows.DockManager.DockManagerUtilities.GetPreventAllowsTransparency(this))
				{
					base.SetValue(global::Infragistics.Windows.DockManager.DockManagerUtilities.PreventAllowsTransparencyPropertyKey, global::Infragistics.KnownBoxes.TrueBox);
					base.OnSupportsAllowsTransparencyChanged();
				}
			}
			finally
			{
				this._isReshowing = false;
			}
		}

		// Token: 0x06000547 RID: 1351 RVA: 0x0001CAAC File Offset: 0x0001ACAC
		private void ActivatePaneIfNeeded()
		{
			global::System.Windows.DependencyObject focusScope = global::System.Windows.Input.FocusManager.GetFocusScope(this);
			global::System.Windows.IInputElement inputElement = (focusScope != null) ? global::System.Windows.Input.FocusManager.GetFocusedElement(focusScope) : null;
			if (focusScope != null && (inputElement == focusScope || inputElement == this))
			{
				this.VerifyActivePane();
				if (this._activePane != null)
				{
					this._activePane.ActivateInternal(true);
				}
			}
		}

		// Token: 0x06000548 RID: 1352 RVA: 0x0001CAF4 File Offset: 0x0001ACF4
		private static object CoerceUseOSNonClientArea(global::System.Windows.DependencyObject d, object newValue)
		{
			global::Infragistics.Windows.DockManager.PaneToolWindow paneToolWindow = d as global::Infragistics.Windows.DockManager.PaneToolWindow;
			if (paneToolWindow.FloatingWindowCaptionSource == global::Infragistics.Windows.DockManager.FloatingWindowCaptionSource.UseContentPaneCaption)
			{
				return global::Infragistics.KnownBoxes.FalseBox;
			}
			return newValue;
		}

		// Token: 0x06000549 RID: 1353 RVA: 0x0001CB18 File Offset: 0x0001AD18
		private static object CoerceVisibility(global::System.Windows.DependencyObject d, object newValue)
		{
			global::Infragistics.Windows.DockManager.XamDockManager dockManager = global::Infragistics.Windows.DockManager.XamDockManager.GetDockManager(d);
			global::Infragistics.Windows.DockManager.PaneToolWindow paneToolWindow = d as global::Infragistics.Windows.DockManager.PaneToolWindow;
			if (paneToolWindow._forceRemainOpen && !global::System.Windows.Visibility.Visible.Equals(newValue) && paneToolWindow.Host != null && paneToolWindow.Host.IsWindow && (paneToolWindow.Pane == null || paneToolWindow.Pane.Visibility == global::System.Windows.Visibility.Collapsed))
			{
				return global::Infragistics.KnownBoxes.VisibilityHiddenBox;
			}
			if (dockManager != null)
			{
				newValue = dockManager.GetValue(global::Infragistics.Windows.DockManager.XamDockManager.ComputedFloatingWindowVisibilityProperty);
			}
			return newValue;
		}

		// Token: 0x0600054A RID: 1354 RVA: 0x0001CB8C File Offset: 0x0001AD8C
		private static void OnCanExecuteCommand(object sender, global::System.Windows.Input.CanExecuteRoutedEventArgs e)
		{
			global::Infragistics.Windows.DockManager.PaneToolWindow d = sender as global::Infragistics.Windows.DockManager.PaneToolWindow;
			global::Infragistics.Windows.DockManager.XamDockManager dockManager = global::Infragistics.Windows.DockManager.XamDockManager.GetDockManager(d);
			if (dockManager != null)
			{
				global::System.Windows.Input.RoutedCommand routedCommand = e.Command as global::System.Windows.Input.RoutedCommand;
				if (routedCommand != null)
				{
					e.CanExecute = routedCommand.CanExecute(e.Parameter, dockManager);
					e.ContinueRouting = false;
					e.Handled = true;
				}
			}
		}

		// Token: 0x0600054B RID: 1355 RVA: 0x0001CBDC File Offset: 0x0001ADDC
		private static void OnChildVisibilityChanged(object sender, global::System.Windows.RoutedEventArgs e)
		{
			global::Infragistics.Windows.DockManager.PaneToolWindow paneToolWindow = (global::Infragistics.Windows.DockManager.PaneToolWindow)sender;
			if (paneToolWindow._isRaisingToolWindowLoaded)
			{
				return;
			}
			global::Infragistics.Windows.DockManager.SplitPane splitPane = paneToolWindow.Content as global::Infragistics.Windows.DockManager.SplitPane;
			if (splitPane != null && splitPane.Visibility != global::System.Windows.Visibility.Collapsed)
			{
				if (!paneToolWindow.ShowIfRootIsVisible(true))
				{
					return;
				}
			}
			else if (!paneToolWindow._isClosing && paneToolWindow._suspendReshowCount == 0 && paneToolWindow._syncShowCount == 0)
			{
				paneToolWindow.Close();
			}
			e.Handled = true;
		}

		// Token: 0x0600054C RID: 1356 RVA: 0x0001CC40 File Offset: 0x0001AE40
		private static void OnDockManagerChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			if (e.NewValue != null)
			{
				global::System.Windows.Data.BindingOperations.SetBinding(d, global::Infragistics.Windows.Controls.ToolWindow.ThemeProperty, global::Infragistics.Windows.Utilities.CreateBindingObject(global::Infragistics.Windows.DockManager.XamDockManager.ThemeProperty, global::System.Windows.Data.BindingMode.OneWay, e.NewValue));
				return;
			}
			global::System.Windows.Data.BindingOperations.ClearBinding(d, global::Infragistics.Windows.Controls.ToolWindow.ThemeProperty);
		}

		// Token: 0x0600054D RID: 1357 RVA: 0x0001CC78 File Offset: 0x0001AE78
		private static void OnExecuteCommand(object sender, global::System.Windows.Input.ExecutedRoutedEventArgs e)
		{
			global::Infragistics.Windows.DockManager.PaneToolWindow d = sender as global::Infragistics.Windows.DockManager.PaneToolWindow;
			global::Infragistics.Windows.DockManager.XamDockManager dockManager = global::Infragistics.Windows.DockManager.XamDockManager.GetDockManager(d);
			if (dockManager != null)
			{
				global::System.Windows.Input.RoutedCommand routedCommand = e.Command as global::System.Windows.Input.RoutedCommand;
				if (routedCommand != null)
				{
					routedCommand.Execute(e.Parameter, dockManager);
					e.Handled = true;
				}
			}
		}

		// Token: 0x0600054E RID: 1358 RVA: 0x0001CCB9 File Offset: 0x0001AEB9
		private void OnLayoutUpdated(object sender, global::System.EventArgs e)
		{
			if (base.IsVisible)
			{
				this.SynchronizeContentPaneFloatingRect();
			}
		}

		// Token: 0x0600054F RID: 1359 RVA: 0x0001CCC9 File Offset: 0x0001AEC9
		private static void OnTopLeftChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			((global::Infragistics.Windows.DockManager.PaneToolWindow)d).SynchronizeLocation(true);
		}

		// Token: 0x06000550 RID: 1360 RVA: 0x0001CCD8 File Offset: 0x0001AED8
		private static void OnVisibilityChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.DockManager.PaneToolWindow paneToolWindow = d as global::Infragistics.Windows.DockManager.PaneToolWindow;
			if (global::System.Windows.Visibility.Collapsed.Equals(e.OldValue) && e.OldValue != e.NewValue)
			{
				paneToolWindow.ShowIfRootIsVisible(true);
			}
		}

		// Token: 0x06000551 RID: 1361 RVA: 0x0001CD18 File Offset: 0x0001AF18
		private static void OnWidthHeightChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			((global::Infragistics.Windows.DockManager.PaneToolWindow)d).SynchronizeSize(true);
		}

		// Token: 0x06000552 RID: 1362 RVA: 0x0001CD28 File Offset: 0x0001AF28
		private void RaisePendingToolWindowLoaded()
		{
			if (!this._isRaiseWindowLoadedPending)
			{
				return;
			}
			this._isRaiseWindowLoadedPending = false;
			global::Infragistics.Windows.DockManager.XamDockManager dockManager = global::Infragistics.Windows.DockManager.XamDockManager.GetDockManager(this);
			if (dockManager != null)
			{
				bool isRaisingToolWindowLoaded = this._isRaisingToolWindowLoaded;
				this._isRaisingToolWindowLoaded = true;
				try
				{
					dockManager.RaiseToolWindowLoaded(new global::Infragistics.Windows.DockManager.Events.PaneToolWindowEventArgs(this));
				}
				finally
				{
					this._isRaisingToolWindowLoaded = isRaisingToolWindowLoaded;
				}
			}
		}

		// Token: 0x06000553 RID: 1363 RVA: 0x0001CD84 File Offset: 0x0001AF84
		private void ResumeReshow()
		{
			this._suspendReshowCount--;
			if (this._suspendReshowCount == 0)
			{
				global::Infragistics.Windows.DockManager.PaneToolWindow.OnChildVisibilityChanged(this, new global::System.Windows.RoutedEventArgs(global::Infragistics.Windows.DockManager.DockManagerUtilities.VisibilityChangedEvent));
				this.RefreshToolWindowState();
			}
		}

		// Token: 0x06000554 RID: 1364 RVA: 0x0001CDB4 File Offset: 0x0001AFB4
		private void ShowHelper()
		{
			if (this._pendingSyncShow != null)
			{
				return;
			}
			global::Infragistics.Windows.DockManager.XamDockManager dockManager = global::Infragistics.Windows.DockManager.XamDockManager.GetDockManager(this);
			if (this._syncShowCount <= 0)
			{
				this.RaisePendingToolWindowLoaded();
				global::Infragistics.Windows.DockManager.DockManagerUtilities.ShowToolWindow(this, dockManager, false);
				return;
			}
			this._pendingSyncShow = base.ShowAsync(dockManager, false, dockManager.ShowToolWindowsInPopup);
		}

		// Token: 0x06000555 RID: 1365 RVA: 0x0001CE08 File Offset: 0x0001B008
		private bool ShowIfRootIsVisible(bool canDefer = true)
		{
			if (base.IsVisible)
			{
				return false;
			}
			if (this._suspendReshowCount > 0)
			{
				return false;
			}
			global::Infragistics.Windows.DockManager.XamDockManager dockManager = global::Infragistics.Windows.DockManager.XamDockManager.GetDockManager(this);
			if (base.Owner == dockManager)
			{
				return false;
			}
			if (dockManager != null && dockManager.IsLoaded && this.IsWindowLoaded)
			{
				global::Infragistics.Windows.DockManager.SplitPane pane = this.Pane;
				if (pane != null && pane.Visibility == global::System.Windows.Visibility.Collapsed)
				{
					return false;
				}
				if (canDefer && global::Infragistics.Windows.DockManager.DockManagerUtilities.IsInUpdateLayout)
				{
					if (this._pendingChildVisibilityOperation == null || this._pendingChildVisibilityOperation.Status == global::System.Windows.Threading.DispatcherOperationStatus.Completed)
					{
						this._pendingChildVisibilityOperation = base.Dispatcher.BeginInvoke(global::System.Windows.Threading.DispatcherPriority.Normal, new global::System.Action(delegate()
						{
							this.ShowIfRootIsVisible(true);
						}));
					}
					return true;
				}
				this._pendingChildVisibilityOperation = null;
				this.ShowHelper();
			}
			return true;
		}

		// Token: 0x06000556 RID: 1366 RVA: 0x0001CEBA File Offset: 0x0001B0BA
		private void SuspendReshow()
		{
			this._suspendReshowCount++;
		}

		// Token: 0x06000557 RID: 1367 RVA: 0x0001CECC File Offset: 0x0001B0CC
		private void SynchronizeContentPaneFloatingRect()
		{
			if (base.IsCalculatingSizeWithoutContent)
			{
				return;
			}
			global::Infragistics.Windows.DockManager.SplitPane splitPane = base.Content as global::Infragistics.Windows.DockManager.SplitPane;
			if (splitPane != null)
			{
				if (base.WindowState != global::System.Windows.WindowState.Normal)
				{
					return;
				}
				global::System.Windows.Size arrangeBounds = new global::System.Windows.Size(base.Width, base.Height);
				bool isUsingOSNonClientArea = base.IsUsingOSNonClientArea;
				if (isUsingOSNonClientArea)
				{
					arrangeBounds = this.AddNonClientSize(arrangeBounds);
				}
				global::System.Windows.Rect lastFloatingWindowRect = new global::System.Windows.Rect(base.Left, base.Top, arrangeBounds.Width, arrangeBounds.Height);
				global::Infragistics.Windows.DockManager.ContentPane contentPane = global::Infragistics.Windows.DockManager.DockManagerUtilities.GetFirstLastPane(splitPane, true);
				global::Infragistics.Windows.DockManager.XamDockManager.GetDockManager(this);
				while (contentPane != null)
				{
					global::System.Windows.FrameworkElement frameworkElement = (global::Infragistics.Windows.DockManager.DockManagerUtilities.GetParentPane(contentPane) as global::Infragistics.Windows.DockManager.TabGroupPane) ?? contentPane;
					if (frameworkElement != null && frameworkElement.IsDescendantOf(this))
					{
						global::System.Windows.Point value = frameworkElement.TransformToAncestor(this).Transform(default(global::System.Windows.Point));
						value.Offset(base.Left, base.Top);
						contentPane.LastFloatingLocation = new global::System.Windows.Point?(value);
					}
					if (frameworkElement != null && !isUsingOSNonClientArea)
					{
						global::System.Windows.FrameworkElement element;
						if (frameworkElement is global::Infragistics.Windows.DockManager.SplitPane)
						{
							element = contentPane;
						}
						else
						{
							element = frameworkElement;
						}
						global::System.Windows.Size size = global::System.Windows.Controls.Primitives.LayoutInformation.GetLayoutSlot(element).Size;
						if (!size.IsEmpty)
						{
							size = this.AddNonClientSize(size);
							contentPane.LastFloatingSize = size;
						}
					}
					contentPane.LastFloatingWindowRect = lastFloatingWindowRect;
					contentPane = global::Infragistics.Windows.DockManager.DockManagerUtilities.GetNextPreviousPane(contentPane, false, true, splitPane);
				}
			}
		}

		// Token: 0x06000558 RID: 1368 RVA: 0x0001D018 File Offset: 0x0001B218
		private void SynchronizeLocation(bool updateFromTopLeft)
		{
			if (this._synchronizingLocation)
			{
				return;
			}
			this._synchronizingLocation = true;
			try
			{
				if (updateFromTopLeft)
				{
					this.FloatingLocation = new global::System.Windows.Point?(new global::System.Windows.Point(base.Left, base.Top));
				}
				else
				{
					global::System.Windows.Point? floatingLocation = this.FloatingLocation;
					if (floatingLocation != null)
					{
						base.Left = floatingLocation.Value.X;
						base.Top = floatingLocation.Value.Y;
					}
				}
				this.SynchronizeContentPaneFloatingRect();
			}
			finally
			{
				this._synchronizingLocation = false;
			}
			if (!updateFromTopLeft && this.FloatingLocation != null && this.KeepOnScreen)
			{
				base.EnsureOnScreen(false);
			}
		}

		// Token: 0x06000559 RID: 1369 RVA: 0x0001D0D4 File Offset: 0x0001B2D4
		private void SynchronizeSize(bool updateFromActual)
		{
			if (this._synchronizingSize)
			{
				return;
			}
			if (base.WindowState != global::System.Windows.WindowState.Normal)
			{
				return;
			}
			this._synchronizingSize = true;
			try
			{
				if (updateFromActual)
				{
					this.FloatingSize = new global::System.Windows.Size(base.Width, base.Height);
				}
				else
				{
					global::System.Windows.Size floatingSize = this.FloatingSize;
					base.Width = (double.IsInfinity(floatingSize.Width) ? double.NaN : floatingSize.Width);
					base.Height = (double.IsInfinity(floatingSize.Height) ? double.NaN : floatingSize.Height);
				}
				this.SynchronizeContentPaneFloatingRect();
			}
			finally
			{
				this._synchronizingSize = false;
			}
			if (!updateFromActual && this.KeepOnScreen)
			{
				base.EnsureOnScreen(false);
			}
		}

		// Token: 0x0600055A RID: 1370 RVA: 0x0001D19C File Offset: 0x0001B39C
		private void VerifyActivePane()
		{
			bool flag = this._activePane == null || global::Infragistics.Windows.Controls.ToolWindow.GetToolWindow(this._activePane) != this;
			if (!flag && global::System.Windows.Input.Keyboard.FocusedElement != null)
			{
				global::System.Windows.DependencyObject dependencyObject = global::System.Windows.Input.Keyboard.FocusedElement as global::System.Windows.DependencyObject;
				if (dependencyObject != null && global::Infragistics.Windows.Utilities.IsDescendantOf(this, dependencyObject))
				{
					this.LastActivePane = ((dependencyObject as global::Infragistics.Windows.DockManager.ContentPane) ?? (global::Infragistics.Windows.Utilities.GetAncestorFromType(dependencyObject, typeof(global::Infragistics.Windows.DockManager.ContentPane), true) as global::Infragistics.Windows.DockManager.ContentPane));
					while (this._activePane != null)
					{
						if (global::Infragistics.Windows.DockManager.XamDockManager.GetDockManager(this._activePane) == global::Infragistics.Windows.DockManager.XamDockManager.GetDockManager(this))
						{
							break;
						}
						this.LastActivePane = (global::Infragistics.Windows.Utilities.GetAncestorFromType(this._activePane, typeof(global::Infragistics.Windows.DockManager.ContentPane), true) as global::Infragistics.Windows.DockManager.ContentPane);
					}
				}
			}
			else if (flag && base.Content is global::Infragistics.Windows.DockManager.SplitPane)
			{
				global::Infragistics.Windows.DockManager.ContentPane contentPane = null;
				global::Infragistics.Windows.DockManager.XamDockManager dockManager = global::Infragistics.Windows.DockManager.XamDockManager.GetDockManager(this);
				if (dockManager != null)
				{
					foreach (global::Infragistics.Windows.DockManager.ContentPane contentPane2 in dockManager.GetPanes(global::Infragistics.Windows.DockManager.PaneNavigationOrder.ActivationOrder))
					{
						if (global::Infragistics.Windows.Controls.ToolWindow.GetToolWindow(contentPane2) == this && global::Infragistics.Windows.DockManager.DockManagerUtilities.MeetsCriteria(contentPane2, ~global::Infragistics.Windows.DockManager.PaneFilterFlags.Hidden))
						{
							contentPane = contentPane2;
							break;
						}
					}
				}
				if (contentPane == null)
				{
					global::Infragistics.Windows.DockManager.PaneFilterFlags filter = ~global::Infragistics.Windows.DockManager.PaneFilterFlags.Hidden;
					contentPane = global::Infragistics.Windows.DockManager.DockManagerUtilities.GetFirstLastPane((global::Infragistics.Windows.DockManager.SplitPane)base.Content, true, filter);
				}
				this.LastActivePane = contentPane;
			}
			if (this._activePane != null)
			{
				global::Infragistics.Windows.DockManager.TabGroupPane tabGroupPane = global::System.Windows.LogicalTreeHelper.GetParent(this._activePane) as global::Infragistics.Windows.DockManager.TabGroupPane;
				if (tabGroupPane != null && tabGroupPane.SelectedItem is global::Infragistics.Windows.DockManager.ContentPane && ((global::Infragistics.Windows.DockManager.ContentPane)tabGroupPane.SelectedItem).CanActivate)
				{
					this.LastActivePane = (tabGroupPane.SelectedItem as global::Infragistics.Windows.DockManager.ContentPane);
				}
			}
		}

		// Token: 0x0600055B RID: 1371 RVA: 0x0001D34C File Offset: 0x0001B54C
		private void VerifyActivePaneForWindowStateChange()
		{
			if (base.IsActive && base.WindowState != global::System.Windows.WindowState.Minimized && base.IsLoaded)
			{
				this.ActivatePaneIfNeeded();
			}
		}

		// Token: 0x0600055C RID: 1372 RVA: 0x0001D370 File Offset: 0x0001B570
		private void VerifyCaptionVisibility()
		{
			global::System.Windows.FrameworkElement captionElement = this.CaptionElement;
			if (captionElement != null && captionElement.IsMeasureValid)
			{
				global::System.Windows.UIElement uielement = global::System.Windows.Media.VisualTreeHelper.GetParent(captionElement) as global::System.Windows.UIElement;
				if (uielement != null && !uielement.IsMeasureValid)
				{
					base.Dispatcher.BeginInvoke(global::System.Windows.Threading.DispatcherPriority.DataBind, new global::Infragistics.Windows.Controls.ToolWindow.MethodInvoker(this.VerifyCaptionVisibilityImpl));
					return;
				}
			}
			this.VerifyCaptionVisibilityImpl();
		}

		// Token: 0x0600055D RID: 1373 RVA: 0x0001D3C6 File Offset: 0x0001B5C6
		private void VerifyCaptionVisibilityImpl()
		{
			if (this.FloatingWindowCaptionSource == global::Infragistics.Windows.DockManager.FloatingWindowCaptionSource.UseContentPaneCaption && this.SinglePane != null)
			{
				base.CaptionVisibility = global::System.Windows.Visibility.Collapsed;
				return;
			}
			base.CaptionVisibility = global::System.Windows.Visibility.Visible;
		}

		// Token: 0x0600055E RID: 1374 RVA: 0x0001D3E8 File Offset: 0x0001B5E8
		bool global::Infragistics.Windows.Commands.ICommandHost.CanExecute(global::Infragistics.Windows.Commands.ExecuteCommandInfo commandInfo)
		{
			global::Infragistics.Windows.DockManager.XamDockManager dockManager = global::Infragistics.Windows.DockManager.XamDockManager.GetDockManager(this);
			return dockManager != null && ((global::Infragistics.Windows.Commands.ICommandHost)dockManager).CanExecute(commandInfo);
		}

		// Token: 0x0600055F RID: 1375 RVA: 0x0001D408 File Offset: 0x0001B608
		long global::Infragistics.Windows.Commands.ICommandHost.GetCurrentState(long statesToQuery)
		{
			global::Infragistics.Windows.DockManager.XamDockManager dockManager = global::Infragistics.Windows.DockManager.XamDockManager.GetDockManager(this);
			if (dockManager == null)
			{
				return 0L;
			}
			return ((global::Infragistics.Windows.Commands.ICommandHost)dockManager).GetCurrentState(statesToQuery);
		}

		// Token: 0x06000560 RID: 1376 RVA: 0x0001D42C File Offset: 0x0001B62C
		bool global::Infragistics.Windows.Commands.ICommandHost.Execute(global::Infragistics.Windows.Commands.ExecuteCommandInfo commandInfo)
		{
			global::Infragistics.Windows.DockManager.XamDockManager dockManager = global::Infragistics.Windows.DockManager.XamDockManager.GetDockManager(this);
			return dockManager != null && ((global::Infragistics.Windows.Commands.ICommandHost)dockManager).Execute(commandInfo);
		}

		// Token: 0x17000123 RID: 291
		// (get) Token: 0x06000561 RID: 1377 RVA: 0x0001D44C File Offset: 0x0001B64C
		global::System.Collections.IList global::Infragistics.Windows.DockManager.IPaneContainer.Panes
		{
			get
			{
				if (base.Content == null)
				{
					return new global::Infragistics.Windows.DockManager.SplitPane[0];
				}
				return new global::Infragistics.Windows.DockManager.SplitPane[]
				{
					base.Content as global::Infragistics.Windows.DockManager.SplitPane
				};
			}
		}

		// Token: 0x06000562 RID: 1378 RVA: 0x0001D480 File Offset: 0x0001B680
		bool global::Infragistics.Windows.DockManager.IPaneContainer.RemovePane(object pane)
		{
			if (pane == base.Content)
			{
				global::Infragistics.Windows.DockManager.XamDockManager dockManager = global::Infragistics.Windows.DockManager.XamDockManager.GetDockManager(this);
				if (dockManager != null)
				{
					dockManager.Panes.Remove((global::Infragistics.Windows.DockManager.SplitPane)base.Content);
					return true;
				}
			}
			return false;
		}

		// Token: 0x17000124 RID: 292
		// (get) Token: 0x06000563 RID: 1379 RVA: 0x0001D4BA File Offset: 0x0001B6BA
		bool global::Infragistics.Windows.DockManager.IPaneContainer.CanBeRemoved
		{
			get
			{
				return base.Content == null || ((global::Infragistics.Windows.DockManager.IPaneContainer)base.Content).CanBeRemoved;
			}
		}

		// Token: 0x0400033A RID: 826
		private bool _synchronizingLocation;

		// Token: 0x0400033B RID: 827
		private bool _synchronizingSize;

		// Token: 0x0400033C RID: 828
		private global::Infragistics.Windows.DockManager.ContentPane _activePane;

		// Token: 0x0400033D RID: 829
		private global::Infragistics.Windows.DockManager.ContentPane _singlePane;

		// Token: 0x0400033E RID: 830
		private global::System.Windows.FrameworkElement _captionElement;

		// Token: 0x0400033F RID: 831
		private bool _isClosing;

		// Token: 0x04000340 RID: 832
		private bool _isWindowLoaded;

		// Token: 0x04000341 RID: 833
		private global::System.Windows.Threading.DispatcherOperation _pendingVerifyAllowsTransparency;

		// Token: 0x04000342 RID: 834
		private bool _isReshowing;

		// Token: 0x04000343 RID: 835
		private int _suspendReshowCount;

		// Token: 0x04000344 RID: 836
		private int _syncShowCount;

		// Token: 0x04000345 RID: 837
		private global::System.IDisposable _pendingSyncShow;

		// Token: 0x04000346 RID: 838
		private bool _isRaiseWindowLoadedPending;

		// Token: 0x04000347 RID: 839
		private bool _isRaisingToolWindowLoaded;

		// Token: 0x04000348 RID: 840
		private global::System.Windows.FrameworkContentElement _dragHelper;

		// Token: 0x04000349 RID: 841
		private bool _forceRemainOpen;

		// Token: 0x0400034A RID: 842
		private global::System.Windows.Threading.DispatcherOperation _pendingChildVisibilityOperation;

		// Token: 0x0400034B RID: 843
		private static readonly global::System.Windows.DependencyPropertyKey PanePropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("Pane", typeof(global::Infragistics.Windows.DockManager.SplitPane), typeof(global::Infragistics.Windows.DockManager.PaneToolWindow), new global::System.Windows.FrameworkPropertyMetadata(null));

		// Token: 0x0400034C RID: 844
		public static readonly global::System.Windows.DependencyProperty PaneProperty = global::Infragistics.Windows.DockManager.PaneToolWindow.PanePropertyKey.DependencyProperty;

		// Token: 0x0400034D RID: 845
		public static readonly global::System.Windows.DependencyProperty FloatingWindowCaptionSourceProperty = global::Infragistics.Windows.DockManager.XamDockManager.FloatingWindowCaptionSourceProperty.AddOwner(typeof(global::Infragistics.Windows.DockManager.PaneToolWindow), new global::System.Windows.FrameworkPropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DockManager.PaneToolWindow.OnFloatingWindowCaptionSourceChanged)));

		// Token: 0x0400034E RID: 846
		private static readonly global::System.Windows.DependencyPropertyKey SinglePaneToolWindowPropertyKey = global::System.Windows.DependencyProperty.RegisterAttachedReadOnly("SinglePaneToolWindow", typeof(global::Infragistics.Windows.DockManager.PaneToolWindow), typeof(global::Infragistics.Windows.DockManager.PaneToolWindow), new global::System.Windows.FrameworkPropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DockManager.PaneToolWindow.OnSinglePaneToolWindowChanged)));

		// Token: 0x0400034F RID: 847
		internal static readonly global::System.Windows.DependencyProperty SinglePaneToolWindowProperty = global::Infragistics.Windows.DockManager.PaneToolWindow.SinglePaneToolWindowPropertyKey.DependencyProperty;

		// Token: 0x04000350 RID: 848
		private static readonly global::System.Windows.DependencyProperty FloatingLocationProperty = global::Infragistics.Windows.DockManager.XamDockManager.FloatingLocationProperty.AddOwner(typeof(global::Infragistics.Windows.DockManager.PaneToolWindow), new global::System.Windows.FrameworkPropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DockManager.PaneToolWindow.OnFloatingLocationChanged)));

		// Token: 0x04000351 RID: 849
		private static readonly global::System.Windows.DependencyProperty FloatingSizeProperty = global::Infragistics.Windows.DockManager.XamDockManager.FloatingSizeProperty.AddOwner(typeof(global::Infragistics.Windows.DockManager.PaneToolWindow), new global::System.Windows.FrameworkPropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DockManager.PaneToolWindow.OnFloatingSizeChanged)));

		// Token: 0x0200008D RID: 141
		private class OwnerNameScope : global::Infragistics.Windows.Helpers.NameScopeProxy
		{
			// Token: 0x06000567 RID: 1383 RVA: 0x0001D4D6 File Offset: 0x0001B6D6
			internal OwnerNameScope(global::Infragistics.Windows.DockManager.PaneToolWindow toolWindow)
			{
				this._toolWindow = toolWindow;
			}

			// Token: 0x17000125 RID: 293
			// (get) Token: 0x06000568 RID: 1384 RVA: 0x0001D4E5 File Offset: 0x0001B6E5
			protected override global::System.Windows.DependencyObject StartingElement
			{
				get
				{
					return global::Infragistics.Windows.DockManager.XamDockManager.GetDockManager(this._toolWindow);
				}
			}

			// Token: 0x04000352 RID: 850
			private global::Infragistics.Windows.DockManager.PaneToolWindow _toolWindow;
		}

		// Token: 0x0200008E RID: 142
		internal class SuspendReshowHelper : global::System.IDisposable
		{
			// Token: 0x06000569 RID: 1385 RVA: 0x0001D4F2 File Offset: 0x0001B6F2
			internal SuspendReshowHelper(global::System.Windows.FrameworkElement toolWindowChild)
			{
				this._window = (global::Infragistics.Windows.Controls.ToolWindow.GetToolWindow(toolWindowChild) as global::Infragistics.Windows.DockManager.PaneToolWindow);
				if (this._window != null)
				{
					this._window.SuspendReshow();
				}
			}

			// Token: 0x0600056A RID: 1386 RVA: 0x0001D520 File Offset: 0x0001B720
			public void Dispose()
			{
				global::Infragistics.Windows.DockManager.PaneToolWindow window = this._window;
				this._window = null;
				if (window != null)
				{
					window.ResumeReshow();
				}
			}

			// Token: 0x04000353 RID: 851
			private global::Infragistics.Windows.DockManager.PaneToolWindow _window;
		}
	}
}
