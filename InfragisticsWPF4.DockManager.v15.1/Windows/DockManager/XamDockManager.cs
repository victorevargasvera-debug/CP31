using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.IO;
using System.Reflection;
using System.Security;
using System.Windows;
using System.Windows.Automation.Peers;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Media;
using System.Windows.Threading;
using Infragistics.Collections;
using Infragistics.Themes;
using Infragistics.Windows.Automation.Peers.DockManager;
using Infragistics.Windows.Commands;
using Infragistics.Windows.Controls;
using Infragistics.Windows.Controls.Events;
using Infragistics.Windows.DockManager.Dragging;
using Infragistics.Windows.DockManager.Events;
using Infragistics.Windows.Helpers;
using Infragistics.Windows.Licensing;
using Infragistics.Windows.Themes;
using Infragistics.Windows.Themes.Internal;

namespace Infragistics.Windows.DockManager
{
	// Token: 0x020000D7 RID: 215
	[global::System.Windows.TemplatePart(Name = "PART_UnpinnedTabAreaLeft", Type = typeof(global::Infragistics.Windows.DockManager.UnpinnedTabArea))]
	[global::System.Windows.TemplatePart(Name = "PART_UnpinnedTabAreaRight", Type = typeof(global::Infragistics.Windows.DockManager.UnpinnedTabArea))]
	[global::Infragistics.Windows.Licensing.UltraLicense("XamDockManager")]
	[global::System.Windows.TemplatePart(Name = "PART_UnpinnedTabAreaBottom", Type = typeof(global::Infragistics.Windows.DockManager.UnpinnedTabArea))]
	[global::System.Windows.TemplatePart(Name = "PART_UnpinnedTabAreaTop", Type = typeof(global::Infragistics.Windows.DockManager.UnpinnedTabArea))]
	[global::System.Windows.TemplatePart(Name = "PART_Panel", Type = typeof(global::Infragistics.Windows.DockManager.DockManagerPanel))]
	[global::System.ComponentModel.LicenseProvider(typeof(global::Infragistics.Windows.Licensing.UltraLicenseProvider))]
	public class XamDockManager : global::System.Windows.Controls.ContentControl, global::Infragistics.Windows.Commands.ICommandHost, global::Infragistics.Windows.DockManager.IPaneContainer, global::Infragistics.Windows.DockManager.IHwndHostContainer, global::Infragistics.Windows.DockManager.IHwndHostInfoOwner
	{
		// Token: 0x06000743 RID: 1859 RVA: 0x0002256C File Offset: 0x0002076C
		public XamDockManager()
		{
			try
			{
				this._license = (global::System.ComponentModel.LicenseManager.Validate(typeof(global::Infragistics.Windows.DockManager.XamDockManager), this) as global::Infragistics.Windows.Licensing.UltraLicense);
			}
			catch (global::System.IO.FileNotFoundException)
			{
			}
			for (int i = 0; i < this._tabAreaInfos.Length; i++)
			{
				this._tabAreaInfos[i] = new global::Infragistics.Windows.DockManager.UnpinnedTabAreaInfo(this);
			}
			this._panes = new global::Infragistics.Windows.DockManager.XamDockManager.PanesCollection(this);
			this._toolWindows = new global::System.Collections.ObjectModel.ObservableCollection<global::Infragistics.Windows.DockManager.PaneToolWindow>();
			this._readOnlyWindows = new global::System.Collections.ObjectModel.ReadOnlyObservableCollection<global::Infragistics.Windows.DockManager.PaneToolWindow>(this._toolWindows);
			this._rootPaneList = new global::Infragistics.Windows.DockManager.XamDockManager.RootPaneList(this);
			this._commands = global::Infragistics.Windows.DockManager.DockManagerCommands.Instance;
			this._activePaneManager = new global::Infragistics.Windows.DockManager.ActivePaneManager(this);
			this._dragManager = new global::Infragistics.Windows.DockManager.Dragging.DragManager(this);
			if (!base.IsInitialized)
			{
				this._panes.BeginUpdate();
			}
			base.SetValue(global::Infragistics.Windows.DockManager.XamDockManager.DockManagerPropertyKey, this);
			base.SetValue(global::Infragistics.Windows.DockManager.XamDockManager.PaneLocationPropertyKey, global::Infragistics.Windows.DockManager.DockManagerKnownBoxes.PaneLocationUnknownBox);
			base.SetValue(global::Infragistics.Windows.DockManager.SplitPane.IsInFillPanePropertyKey, global::Infragistics.KnownBoxes.FalseBox);
			base.Loaded += this.OnDockManagerLoaded;
		}

		// Token: 0x06000744 RID: 1860 RVA: 0x00022684 File Offset: 0x00020884
		static XamDockManager()
		{
			global::Infragistics.Windows.DockManager.XamDockManager.ThemeChangedEvent = global::Infragistics.Windows.Themes.ThemeManager.ThemeChangedEvent.AddOwner(typeof(global::Infragistics.Windows.DockManager.XamDockManager));
			global::Infragistics.Windows.DockManager.XamDockManager.UseOwnedFloatingWindowsProperty = global::System.Windows.DependencyProperty.Register("UseOwnedFloatingWindows", typeof(bool), typeof(global::Infragistics.Windows.DockManager.XamDockManager), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.TrueBox));
			global::Infragistics.Windows.DockManager.XamDockManager.PinBehaviorProperty = global::System.Windows.DependencyProperty.Register("PinBehavior", typeof(global::Infragistics.Windows.DockManager.PaneActionBehavior), typeof(global::Infragistics.Windows.DockManager.XamDockManager), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.Windows.DockManager.PaneActionBehavior.AllPanes));
			global::Infragistics.Windows.DockManager.XamDockManager.UnpinnedTabHoverActionProperty = global::System.Windows.DependencyProperty.Register("UnpinnedTabHoverAction", typeof(global::Infragistics.Windows.DockManager.UnpinnedTabHoverAction), typeof(global::Infragistics.Windows.DockManager.XamDockManager), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.Windows.DockManager.UnpinnedTabHoverAction.Flyout));
			global::Infragistics.Windows.DockManager.XamDockManager.ComputedFloatingWindowVisibilityPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("ComputedFloatingWindowVisibility", typeof(global::System.Windows.Visibility), typeof(global::Infragistics.Windows.DockManager.XamDockManager), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.VisibilityCollapsedBox, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DockManager.XamDockManager.OnComputedFloatingWindowVisibilityChanged)));
			global::Infragistics.Windows.DockManager.XamDockManager.ComputedFloatingWindowVisibilityProperty = global::Infragistics.Windows.DockManager.XamDockManager.ComputedFloatingWindowVisibilityPropertyKey.DependencyProperty;
			global::Infragistics.Windows.DockManager.XamDockManager.ActivePaneChangedEvent = global::System.Windows.EventManager.RegisterRoutedEvent("ActivePaneChanged", global::System.Windows.RoutingStrategy.Bubble, typeof(global::System.Windows.RoutedPropertyChangedEventHandler<global::Infragistics.Windows.DockManager.ContentPane>), typeof(global::Infragistics.Windows.DockManager.XamDockManager));
			global::Infragistics.Windows.DockManager.XamDockManager.ExecutingCommandEvent = global::System.Windows.EventManager.RegisterRoutedEvent("ExecutingCommand", global::System.Windows.RoutingStrategy.Bubble, typeof(global::System.EventHandler<global::Infragistics.Windows.Controls.Events.ExecutingCommandEventArgs>), typeof(global::Infragistics.Windows.DockManager.XamDockManager));
			global::Infragistics.Windows.DockManager.XamDockManager.ExecutedCommandEvent = global::System.Windows.EventManager.RegisterRoutedEvent("ExecutedCommand", global::System.Windows.RoutingStrategy.Bubble, typeof(global::System.EventHandler<global::Infragistics.Windows.Controls.Events.ExecutedCommandEventArgs>), typeof(global::Infragistics.Windows.DockManager.XamDockManager));
			global::Infragistics.Windows.DockManager.XamDockManager.InitializePaneContentEvent = global::System.Windows.EventManager.RegisterRoutedEvent("InitializePaneContent", global::System.Windows.RoutingStrategy.Bubble, typeof(global::System.EventHandler<global::Infragistics.Windows.DockManager.Events.InitializePaneContentEventArgs>), typeof(global::Infragistics.Windows.DockManager.XamDockManager));
			global::Infragistics.Windows.DockManager.XamDockManager.PaneDragEndedEvent = global::System.Windows.EventManager.RegisterRoutedEvent("PaneDragEnded", global::System.Windows.RoutingStrategy.Bubble, typeof(global::System.EventHandler<global::Infragistics.Windows.DockManager.Events.PaneDragEndedEventArgs>), typeof(global::Infragistics.Windows.DockManager.XamDockManager));
			global::Infragistics.Windows.DockManager.XamDockManager.PaneDragOverEvent = global::System.Windows.EventManager.RegisterRoutedEvent("PaneDragOver", global::System.Windows.RoutingStrategy.Bubble, typeof(global::System.EventHandler<global::Infragistics.Windows.DockManager.Events.PaneDragOverEventArgs>), typeof(global::Infragistics.Windows.DockManager.XamDockManager));
			global::Infragistics.Windows.DockManager.XamDockManager.PaneDragStartingEvent = global::System.Windows.EventManager.RegisterRoutedEvent("PaneDragStarting", global::System.Windows.RoutingStrategy.Bubble, typeof(global::System.EventHandler<global::Infragistics.Windows.DockManager.Events.PaneDragStartingEventArgs>), typeof(global::Infragistics.Windows.DockManager.XamDockManager));
			global::Infragistics.Windows.DockManager.XamDockManager.ToolWindowLoadedEvent = global::System.Windows.EventManager.RegisterRoutedEvent("ToolWindowLoaded", global::System.Windows.RoutingStrategy.Bubble, typeof(global::System.EventHandler<global::Infragistics.Windows.DockManager.Events.PaneToolWindowEventArgs>), typeof(global::Infragistics.Windows.DockManager.XamDockManager));
			global::Infragistics.Windows.DockManager.XamDockManager.ToolWindowUnloadedEvent = global::System.Windows.EventManager.RegisterRoutedEvent("ToolWindowUnloaded", global::System.Windows.RoutingStrategy.Bubble, typeof(global::System.EventHandler<global::Infragistics.Windows.DockManager.Events.PaneToolWindowEventArgs>), typeof(global::Infragistics.Windows.DockManager.XamDockManager));
			global::System.Windows.FrameworkElement.DefaultStyleKeyProperty.OverrideMetadata(typeof(global::Infragistics.Windows.DockManager.XamDockManager), new global::System.Windows.FrameworkPropertyMetadata(typeof(global::Infragistics.Windows.DockManager.XamDockManager)));
			global::Infragistics.Windows.Themes.ThemeManager.RegisterGroupings(typeof(global::Infragistics.Windows.DockManager.XamDockManager), new string[]
			{
				global::Infragistics.Windows.Themes.PrimitivesResourceSet<global::Infragistics.Windows.Themes.PrimitivesGeneric.Locator>.Location.Grouping,
				global::Infragistics.Windows.Themes.DockManagerResourceSet<global::Infragistics.Windows.Themes.DockManagerGeneric.Locator>.Location.Grouping
			});
			global::System.Windows.FrameworkElement.FocusVisualStyleProperty.OverrideMetadata(typeof(global::Infragistics.Windows.DockManager.XamDockManager), new global::System.Windows.FrameworkPropertyMetadata(null));
			global::System.Windows.EventManager.RegisterClassHandler(typeof(global::Infragistics.Windows.DockManager.XamDockManager), global::System.Windows.Input.CommandManager.CanExecuteEvent, new global::System.Windows.Input.CanExecuteRoutedEventHandler(global::Infragistics.Windows.DockManager.XamDockManager.OnTransferCanExecuteCommand));
			global::System.Windows.EventManager.RegisterClassHandler(typeof(global::Infragistics.Windows.DockManager.XamDockManager), global::System.Windows.Input.CommandManager.ExecutedEvent, new global::System.Windows.Input.ExecutedRoutedEventHandler(global::Infragistics.Windows.DockManager.XamDockManager.OnTransferExecuteCommand));
			global::Infragistics.Windows.DockManager.XamDockManager._secureCommandType = global::System.Windows.Input.ApplicationCommands.Paste.GetType();
			global::System.Windows.Input.CanExecuteRoutedEventHandler canExecute = new global::System.Windows.Input.CanExecuteRoutedEventHandler(global::Infragistics.Windows.DockManager.XamDockManager.OnTransferBindingCanExecute);
			global::System.Windows.Input.ExecutedRoutedEventHandler executed = new global::System.Windows.Input.ExecutedRoutedEventHandler(global::Infragistics.Windows.DockManager.XamDockManager.OnTransferBindingExecute);
			foreach (global::System.Reflection.PropertyInfo propertyInfo in typeof(global::System.Windows.Input.ApplicationCommands).GetProperties(global::System.Reflection.BindingFlags.Static | global::System.Reflection.BindingFlags.Public))
			{
				if (typeof(global::System.Windows.Input.ICommand).IsAssignableFrom(propertyInfo.PropertyType))
				{
					global::System.Windows.Input.ICommand command = propertyInfo.GetValue(null, null) as global::System.Windows.Input.ICommand;
					if (command != null && command.GetType() == global::Infragistics.Windows.DockManager.XamDockManager._secureCommandType)
					{
						global::System.Windows.Input.CommandManager.RegisterClassCommandBinding(typeof(global::Infragistics.Windows.DockManager.XamDockManager), new global::System.Windows.Input.CommandBinding(command, executed, canExecute));
					}
				}
			}
			global::Infragistics.Themes.ThemeManager.RegisterControl(typeof(global::Infragistics.Windows.DockManager.XamDockManager));
		}

		// Token: 0x06000745 RID: 1861 RVA: 0x00022F4A File Offset: 0x0002114A
		protected override global::System.Windows.Automation.Peers.AutomationPeer OnCreateAutomationPeer()
		{
			return new global::Infragistics.Windows.Automation.Peers.DockManager.XamDockManagerAutomationPeer(this);
		}

		// Token: 0x17000207 RID: 519
		// (get) Token: 0x06000746 RID: 1862 RVA: 0x00022F54 File Offset: 0x00021154
		protected override global::System.Collections.IEnumerator LogicalChildren
		{
			get
			{
				if (this._logicalChildren == null || this._logicalChildren.Count == 0)
				{
					return base.LogicalChildren;
				}
				return new global::Infragistics.Collections.MultiSourceEnumerator(new global::System.Collections.IEnumerator[]
				{
					base.LogicalChildren,
					this._logicalChildren.GetEnumerator()
				});
			}
		}

		// Token: 0x06000747 RID: 1863 RVA: 0x00022FA8 File Offset: 0x000211A8
		public override void OnApplyTemplate()
		{
			if (this._dockPanel != null)
			{
				this._dockPanel.Loaded -= this.OnDockPanelLoaded;
				this._dockPanel.Panes.Clear();
				this._dockPanel.RemoveAllUnpinnedPanes();
			}
			global::System.Collections.Generic.IList<global::Infragistics.Windows.DockManager.SplitPane> list = new global::System.Collections.Generic.List<global::Infragistics.Windows.DockManager.SplitPane>();
			if (this._logicalChildren != null && this._hasAppliedTemplate)
			{
				foreach (object obj in this._logicalChildren)
				{
					global::Infragistics.Windows.DockManager.SplitPane splitPane = obj as global::Infragistics.Windows.DockManager.SplitPane;
					if (splitPane != null)
					{
						list.Add(splitPane);
					}
				}
			}
			using (global::Infragistics.Windows.DockManager.DockManagerUtilities.CreateMoveReplacement<global::Infragistics.Windows.DockManager.SplitPane>(list))
			{
				foreach (global::Infragistics.Windows.DockManager.SplitPane logicalChild in list)
				{
					this.RemoveLogicalChildInternal(logicalChild);
				}
				base.OnApplyTemplate();
				for (int i = 0; i < 4; i++)
				{
					this._tabAreaInfos[i].TabArea = (base.GetTemplateChild("PART_UnpinnedTabArea" + ((global::System.Windows.Controls.Dock)i).ToString()) as global::Infragistics.Windows.DockManager.UnpinnedTabArea);
				}
				this._dockPanel = (base.GetTemplateChild("PART_Panel") as global::Infragistics.Windows.DockManager.DockManagerPanel);
				foreach (global::Infragistics.Windows.DockManager.SplitPane logicalChild2 in list)
				{
					this.AddLogicalChildInternal(logicalChild2);
				}
			}
			if (this._dockPanel != null)
			{
				if (this.Panes.Count > 0)
				{
					bool flag = false;
					foreach (global::Infragistics.Windows.DockManager.SplitPane splitPane2 in this._panes.DockedPanes)
					{
						if (splitPane2.IsLoaded)
						{
							flag = true;
							break;
						}
					}
					if (this._dockPanel.IsLoaded || !flag)
					{
						this._dockPanel.Panes.ReInitialize(this._panes.DockedPanes);
					}
					else
					{
						this._dockPanel.Loaded += this.OnDockPanelLoaded;
					}
				}
				foreach (global::Infragistics.Windows.DockManager.ContentPane pane in global::Infragistics.Windows.DockManager.DockManagerUtilities.GetAllPanes(this, global::Infragistics.Windows.DockManager.PaneFilterFlags.Unpinned))
				{
					this._dockPanel.AddUnpinnedPane(pane);
				}
			}
			this._rootPaneList.RefreshTabAreas();
			this._hasAppliedTemplate = true;
		}

		// Token: 0x06000748 RID: 1864 RVA: 0x00023260 File Offset: 0x00021460
		protected override void OnContentChanged(object oldContent, object newContent)
		{
			base.OnContentChanged(oldContent, newContent);
			global::Infragistics.Windows.DockManager.DocumentContentHost documentContentHost = newContent as global::Infragistics.Windows.DockManager.DocumentContentHost;
			global::Infragistics.Windows.DockManager.DocumentContentHost documentContentHost2 = oldContent as global::Infragistics.Windows.DockManager.DocumentContentHost;
			base.SetValue(global::Infragistics.Windows.DockManager.XamDockManager.HasDocumentContentHostPropertyKey, (documentContentHost != null) ? global::Infragistics.KnownBoxes.TrueBox : global::System.Windows.DependencyProperty.UnsetValue);
			if (documentContentHost2 != null)
			{
				documentContentHost2.ClearValue(global::Infragistics.Windows.DockManager.XamDockManager.PaneLocationPropertyKey);
			}
			if (documentContentHost != null)
			{
				documentContentHost.SetValue(global::Infragistics.Windows.DockManager.XamDockManager.PaneLocationPropertyKey, global::Infragistics.Windows.DockManager.DockManagerKnownBoxes.PaneLocationDocumentBox);
			}
			global::System.Windows.FrameworkElement frameworkElement = newContent as global::System.Windows.FrameworkElement;
			global::System.Windows.FrameworkElement frameworkElement2 = oldContent as global::System.Windows.FrameworkElement;
			if (frameworkElement2 != null)
			{
				frameworkElement2.ClearValue(global::Infragistics.Windows.DockManager.HwndHostInfo.HwndHostProperty);
			}
			if (frameworkElement != null)
			{
				global::Infragistics.Windows.DockManager.HwndHostInfo.SetHwndHost(frameworkElement, new global::Infragistics.Windows.DockManager.HwndHostInfo(this));
			}
			base.CoerceValue(global::Infragistics.Windows.DockManager.XamDockManager.LayoutModeProperty);
		}

		// Token: 0x06000749 RID: 1865 RVA: 0x000232F4 File Offset: 0x000214F4
		protected override void OnPreviewGotKeyboardFocus(global::System.Windows.Input.KeyboardFocusChangedEventArgs e)
		{
			base.OnPreviewGotKeyboardFocus(e);
			if (this._isSettingFocusedElement)
			{
				return;
			}
			if (this._forcingFocus)
			{
				return;
			}
			if (this.ActivePaneManager.IsVerificationSuspended)
			{
				return;
			}
			global::System.Windows.DependencyObject newNestedFocusedElement = e.NewFocus as global::System.Windows.DependencyObject;
			this.EnsureIsFocusedElement(newNestedFocusedElement);
			if (this._isActivatingPane)
			{
				return;
			}
			if ((e.NewFocus == this || (this._dragHelper != null && e.NewFocus == this._dragHelper)) && (e.OldFocus != null || !base.IsLoaded))
			{
				this.ActivePaneManager.VerifyActiveDocument(true);
				global::Infragistics.Windows.DockManager.ContentPane contentPane = this.ActivePane ?? this.ActivePaneManager.GetActiveDocument();
				if (contentPane == null && !this.HasDocumentContentHost && this.DockPanel != null && this.DockPanel.Child != null)
				{
					e.Handled = this.DockPanel.Child.MoveFocus(new global::System.Windows.Input.TraversalRequest(global::System.Windows.Input.FocusNavigationDirection.First));
				}
				if (!e.Handled)
				{
					global::System.Windows.Window window = global::System.Windows.Window.GetWindow(this);
					if (contentPane != null && global::System.Windows.Window.GetWindow(contentPane) != window)
					{
						contentPane = null;
					}
					if (contentPane == null)
					{
						global::Infragistics.Windows.DockManager.PaneFilterFlags filter = global::Infragistics.Windows.DockManager.PaneFilterFlags.AllVisible;
						foreach (global::Infragistics.Windows.DockManager.ContentPane contentPane2 in this.ActivePaneManager.GetPanes(filter, global::Infragistics.Windows.DockManager.PaneNavigationOrder.ActivationOrder, true))
						{
							if (global::System.Windows.Window.GetWindow(contentPane2) == window)
							{
								contentPane = contentPane2;
								break;
							}
						}
					}
					if (contentPane != null)
					{
						this.SuspendShowFlyout();
						try
						{
							e.Handled = contentPane.ActivateInternal();
						}
						finally
						{
							this.ResumeShowFlyout();
						}
					}
				}
			}
		}

		// Token: 0x0600074A RID: 1866 RVA: 0x00023480 File Offset: 0x00021680
		protected override void OnInitialized(global::System.EventArgs e)
		{
			if (!global::Infragistics.Windows.DockManager.XamDockManager._avoidHwndSourceHelper)
			{
				try
				{
					this._hwndSourceHelper = new global::Infragistics.Windows.DockManager.XamDockManager.HwndSourceHelper(this);
				}
				catch (global::System.Security.SecurityException)
				{
					global::Infragistics.Windows.DockManager.XamDockManager._avoidHwndSourceHelper = true;
				}
			}
			this._panes.EndUpdate();
			this.VerifyFillPane();
			base.OnInitialized(e);
			this._activePaneManager.RebuildPaneList();
		}

		// Token: 0x0600074B RID: 1867 RVA: 0x000234E0 File Offset: 0x000216E0
		protected override void OnKeyDown(global::System.Windows.Input.KeyEventArgs e)
		{
			base.OnKeyDown(e);
			if (e.Handled)
			{
				return;
			}
			global::System.Windows.DependencyObject dependencyObject = e.OriginalSource as global::System.Windows.DependencyObject;
			if (dependencyObject != null && global::Infragistics.Windows.Controls.ToolWindow.GetToolWindow(dependencyObject) != global::Infragistics.Windows.Controls.ToolWindow.GetToolWindow(this))
			{
				return;
			}
			this.ProcessKeyDown(e);
		}

		// Token: 0x0600074C RID: 1868 RVA: 0x00023524 File Offset: 0x00021724
		protected override void OnKeyUp(global::System.Windows.Input.KeyEventArgs e)
		{
			base.OnKeyUp(e);
			if (e.Handled)
			{
				return;
			}
			global::System.Windows.DependencyObject dependencyObject = e.OriginalSource as global::System.Windows.DependencyObject;
			if (dependencyObject != null && global::Infragistics.Windows.Controls.ToolWindow.GetToolWindow(dependencyObject) != global::Infragistics.Windows.Controls.ToolWindow.GetToolWindow(this))
			{
				return;
			}
			this.ProcessKeyUp(e);
		}

		// Token: 0x17000208 RID: 520
		// (get) Token: 0x0600074D RID: 1869 RVA: 0x00023566 File Offset: 0x00021766
		[global::System.ComponentModel.ReadOnly(true)]
		[global::System.ComponentModel.Bindable(true)]
		public global::Infragistics.Windows.DockManager.ContentPane ActivePane
		{
			get
			{
				return (global::Infragistics.Windows.DockManager.ContentPane)base.GetValue(global::Infragistics.Windows.DockManager.XamDockManager.ActivePaneProperty);
			}
		}

		// Token: 0x17000209 RID: 521
		// (get) Token: 0x0600074E RID: 1870 RVA: 0x00023578 File Offset: 0x00021778
		// (set) Token: 0x0600074F RID: 1871 RVA: 0x0002358A File Offset: 0x0002178A
		[global::System.ComponentModel.Bindable(true)]
		public bool AllowMinimizeFloatingWindows
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.Windows.DockManager.XamDockManager.AllowMinimizeFloatingWindowsProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DockManager.XamDockManager.AllowMinimizeFloatingWindowsProperty, value);
			}
		}

		// Token: 0x1700020A RID: 522
		// (get) Token: 0x06000750 RID: 1872 RVA: 0x0002359D File Offset: 0x0002179D
		// (set) Token: 0x06000751 RID: 1873 RVA: 0x000235AF File Offset: 0x000217AF
		[global::System.ComponentModel.Bindable(true)]
		public bool AllowMaximizeFloatingWindows
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.Windows.DockManager.XamDockManager.AllowMaximizeFloatingWindowsProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DockManager.XamDockManager.AllowMaximizeFloatingWindowsProperty, value);
			}
		}

		// Token: 0x1700020B RID: 523
		// (get) Token: 0x06000752 RID: 1874 RVA: 0x000235C2 File Offset: 0x000217C2
		// (set) Token: 0x06000753 RID: 1875 RVA: 0x000235D4 File Offset: 0x000217D4
		[global::System.ComponentModel.Bindable(true)]
		public global::Infragistics.Windows.DockManager.PaneActionBehavior CloseBehavior
		{
			get
			{
				return (global::Infragistics.Windows.DockManager.PaneActionBehavior)base.GetValue(global::Infragistics.Windows.DockManager.XamDockManager.CloseBehaviorProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DockManager.XamDockManager.CloseBehaviorProperty, value);
			}
		}

		// Token: 0x1700020C RID: 524
		// (get) Token: 0x06000754 RID: 1876 RVA: 0x000235E7 File Offset: 0x000217E7
		public global::Infragistics.Windows.DockManager.ContentPane CurrentFlyoutPane
		{
			get
			{
				if (this._dockPanel == null || !this._dockPanel.HasFlyoutPanel)
				{
					return null;
				}
				return this._dockPanel.FlyoutPanel.Pane;
			}
		}

		// Token: 0x06000755 RID: 1877 RVA: 0x00023610 File Offset: 0x00021810
		public static global::Infragistics.Windows.DockManager.XamDockManager GetDockManager(global::System.Windows.DependencyObject d)
		{
			return (global::Infragistics.Windows.DockManager.XamDockManager)d.GetValue(global::Infragistics.Windows.DockManager.XamDockManager.DockManagerProperty);
		}

		// Token: 0x06000756 RID: 1878 RVA: 0x00023622 File Offset: 0x00021822
		public static global::Infragistics.Windows.DockManager.Dragging.DropPreviewTabLocation GetDropPreviewTabLocation(global::System.Windows.DependencyObject d)
		{
			return (global::Infragistics.Windows.DockManager.Dragging.DropPreviewTabLocation)d.GetValue(global::Infragistics.Windows.DockManager.XamDockManager.DropPreviewTabLocationProperty);
		}

		// Token: 0x06000757 RID: 1879 RVA: 0x00023634 File Offset: 0x00021834
		[global::System.Windows.AttachedPropertyBrowsableForType(typeof(global::Infragistics.Windows.DockManager.SplitPane))]
		[global::System.Windows.AttachedPropertyBrowsableForChildren(IncludeDescendants = false)]
		public static global::System.Windows.Point? GetFloatingLocation(global::System.Windows.DependencyObject d)
		{
			return (global::System.Windows.Point?)d.GetValue(global::Infragistics.Windows.DockManager.XamDockManager.FloatingLocationProperty);
		}

		// Token: 0x06000758 RID: 1880 RVA: 0x00023646 File Offset: 0x00021846
		public static void SetFloatingLocation(global::System.Windows.DependencyObject d, global::System.Windows.Point? value)
		{
			d.SetValue(global::Infragistics.Windows.DockManager.XamDockManager.FloatingLocationProperty, value);
		}

		// Token: 0x06000759 RID: 1881 RVA: 0x00023659 File Offset: 0x00021859
		[global::System.Windows.AttachedPropertyBrowsableForType(typeof(global::Infragistics.Windows.DockManager.SplitPane))]
		[global::System.Windows.AttachedPropertyBrowsableForChildren(IncludeDescendants = false)]
		public static global::System.Windows.Size GetFloatingSize(global::System.Windows.DependencyObject d)
		{
			return (global::System.Windows.Size)d.GetValue(global::Infragistics.Windows.DockManager.XamDockManager.FloatingSizeProperty);
		}

		// Token: 0x0600075A RID: 1882 RVA: 0x0002366B File Offset: 0x0002186B
		public static void SetFloatingSize(global::System.Windows.DependencyObject d, global::System.Windows.Size value)
		{
			d.SetValue(global::Infragistics.Windows.DockManager.XamDockManager.FloatingSizeProperty, value);
		}

		// Token: 0x1700020D RID: 525
		// (get) Token: 0x0600075B RID: 1883 RVA: 0x0002367E File Offset: 0x0002187E
		// (set) Token: 0x0600075C RID: 1884 RVA: 0x00023690 File Offset: 0x00021890
		[global::System.ComponentModel.Bindable(true)]
		public global::Infragistics.Windows.DockManager.FloatingWindowCaptionSource FloatingWindowCaptionSource
		{
			get
			{
				return (global::Infragistics.Windows.DockManager.FloatingWindowCaptionSource)base.GetValue(global::Infragistics.Windows.DockManager.XamDockManager.FloatingWindowCaptionSourceProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DockManager.XamDockManager.FloatingWindowCaptionSourceProperty, value);
			}
		}

		// Token: 0x1700020E RID: 526
		// (get) Token: 0x0600075D RID: 1885 RVA: 0x000236A3 File Offset: 0x000218A3
		// (set) Token: 0x0600075E RID: 1886 RVA: 0x000236B5 File Offset: 0x000218B5
		[global::System.ComponentModel.TypeConverter(typeof(global::Infragistics.Windows.Helpers.NullableConverter<global::Infragistics.Windows.DockManager.FloatingWindowDoubleClickAction>))]
		[global::System.ComponentModel.Bindable(true)]
		public global::Infragistics.Windows.DockManager.FloatingWindowDoubleClickAction? FloatingWindowDoubleClickAction
		{
			get
			{
				return (global::Infragistics.Windows.DockManager.FloatingWindowDoubleClickAction?)base.GetValue(global::Infragistics.Windows.DockManager.XamDockManager.FloatingWindowDoubleClickActionProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DockManager.XamDockManager.FloatingWindowDoubleClickActionProperty, value);
			}
		}

		// Token: 0x1700020F RID: 527
		// (get) Token: 0x0600075F RID: 1887 RVA: 0x000236C8 File Offset: 0x000218C8
		// (set) Token: 0x06000760 RID: 1888 RVA: 0x000236DA File Offset: 0x000218DA
		[global::System.ComponentModel.Bindable(true)]
		public global::Infragistics.Windows.DockManager.FloatingWindowDragMode FloatingWindowDragMode
		{
			get
			{
				return (global::Infragistics.Windows.DockManager.FloatingWindowDragMode)base.GetValue(global::Infragistics.Windows.DockManager.XamDockManager.FloatingWindowDragModeProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DockManager.XamDockManager.FloatingWindowDragModeProperty, value);
			}
		}

		// Token: 0x06000761 RID: 1889 RVA: 0x000236F0 File Offset: 0x000218F0
		private static void OnFloatingWindowVisibilityChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.DockManager.XamDockManager xamDockManager = d as global::Infragistics.Windows.DockManager.XamDockManager;
			xamDockManager.VerifyFloatingWindowVisibility();
		}

		// Token: 0x17000210 RID: 528
		// (get) Token: 0x06000762 RID: 1890 RVA: 0x0002370A File Offset: 0x0002190A
		// (set) Token: 0x06000763 RID: 1891 RVA: 0x0002371C File Offset: 0x0002191C
		[global::System.ComponentModel.Bindable(true)]
		public global::Infragistics.Windows.DockManager.FloatingWindowVisibility FloatingWindowVisibility
		{
			get
			{
				return (global::Infragistics.Windows.DockManager.FloatingWindowVisibility)base.GetValue(global::Infragistics.Windows.DockManager.XamDockManager.FloatingWindowVisibilityProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DockManager.XamDockManager.FloatingWindowVisibilityProperty, value);
			}
		}

		// Token: 0x06000764 RID: 1892 RVA: 0x0002372F File Offset: 0x0002192F
		private static void OnFlyoutAnimationChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
		}

		// Token: 0x17000211 RID: 529
		// (get) Token: 0x06000765 RID: 1893 RVA: 0x00023731 File Offset: 0x00021931
		// (set) Token: 0x06000766 RID: 1894 RVA: 0x00023743 File Offset: 0x00021943
		[global::System.ComponentModel.Bindable(true)]
		public global::Infragistics.Windows.DockManager.PaneFlyoutAnimation FlyoutAnimation
		{
			get
			{
				return (global::Infragistics.Windows.DockManager.PaneFlyoutAnimation)base.GetValue(global::Infragistics.Windows.DockManager.XamDockManager.FlyoutAnimationProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DockManager.XamDockManager.FlyoutAnimationProperty, value);
			}
		}

		// Token: 0x17000212 RID: 530
		// (get) Token: 0x06000767 RID: 1895 RVA: 0x00023756 File Offset: 0x00021956
		[global::System.ComponentModel.ReadOnly(true)]
		[global::System.ComponentModel.Bindable(true)]
		public bool HasDocumentContentHost
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.Windows.DockManager.XamDockManager.HasDocumentContentHostProperty);
			}
		}

		// Token: 0x06000768 RID: 1896 RVA: 0x00023768 File Offset: 0x00021968
		private static void OnInitialLocationChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.DockManager.SplitPane splitPane = d as global::Infragistics.Windows.DockManager.SplitPane;
			if (splitPane == null)
			{
				throw new global::System.InvalidOperationException(global::Infragistics.Windows.DockManager.XamDockManager.GetString("LE_InitialLocationForSplitOnly"));
			}
			global::Infragistics.Windows.DockManager.XamDockManager dockManager = global::Infragistics.Windows.DockManager.XamDockManager.GetDockManager(d);
			if (dockManager != null)
			{
				if (global::System.ComponentModel.DesignerProperties.GetIsInDesignMode(dockManager))
				{
					int num = dockManager.Panes.IndexOf(splitPane);
					if (num >= 0)
					{
						dockManager.Panes.RemoveAt(num);
						dockManager.Panes.Insert(num, splitPane);
						return;
					}
				}
				throw new global::System.InvalidOperationException(global::Infragistics.Windows.DockManager.XamDockManager.GetString("LE_CannotChangeInitialLocation"));
			}
		}

		// Token: 0x06000769 RID: 1897 RVA: 0x000237DC File Offset: 0x000219DC
		[global::System.Windows.AttachedPropertyBrowsableForType(typeof(global::Infragistics.Windows.DockManager.SplitPane))]
		[global::System.Windows.AttachedPropertyBrowsableForChildren(IncludeDescendants = false)]
		public static global::Infragistics.Windows.DockManager.InitialPaneLocation GetInitialLocation(global::System.Windows.DependencyObject d)
		{
			return (global::Infragistics.Windows.DockManager.InitialPaneLocation)d.GetValue(global::Infragistics.Windows.DockManager.XamDockManager.InitialLocationProperty);
		}

		// Token: 0x0600076A RID: 1898 RVA: 0x000237EE File Offset: 0x000219EE
		public static void SetInitialLocation(global::System.Windows.DependencyObject d, global::Infragistics.Windows.DockManager.InitialPaneLocation value)
		{
			d.SetValue(global::Infragistics.Windows.DockManager.XamDockManager.InitialLocationProperty, global::Infragistics.Windows.DockManager.DockManagerKnownBoxes.FromValue(value));
		}

		// Token: 0x0600076B RID: 1899 RVA: 0x00023801 File Offset: 0x00021A01
		private static object CoerceLayoutMode(global::System.Windows.DependencyObject d, object newValue)
		{
			if (!global::Infragistics.Windows.DockManager.DockedPaneLayoutMode.Standard.Equals(newValue) && ((global::Infragistics.Windows.DockManager.XamDockManager)d).HasContent)
			{
				return global::Infragistics.Windows.DockManager.DockedPaneLayoutMode.Standard;
			}
			return newValue;
		}

		// Token: 0x0600076C RID: 1900 RVA: 0x00023828 File Offset: 0x00021A28
		private static void OnLayoutModeChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.DockManager.XamDockManager xamDockManager = (global::Infragistics.Windows.DockManager.XamDockManager)d;
			if (xamDockManager._dockPanel != null)
			{
				xamDockManager._dockPanel.InvalidateMeasure();
				xamDockManager._dockPanel.InvalidateArrange();
			}
			xamDockManager.VerifyFillPane();
		}

		// Token: 0x17000213 RID: 531
		// (get) Token: 0x0600076D RID: 1901 RVA: 0x00023860 File Offset: 0x00021A60
		// (set) Token: 0x0600076E RID: 1902 RVA: 0x00023872 File Offset: 0x00021A72
		[global::System.ComponentModel.Bindable(true)]
		public global::Infragistics.Windows.DockManager.DockedPaneLayoutMode LayoutMode
		{
			get
			{
				return (global::Infragistics.Windows.DockManager.DockedPaneLayoutMode)base.GetValue(global::Infragistics.Windows.DockManager.XamDockManager.LayoutModeProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DockManager.XamDockManager.LayoutModeProperty, value);
			}
		}

		// Token: 0x17000214 RID: 532
		// (get) Token: 0x0600076F RID: 1903 RVA: 0x00023885 File Offset: 0x00021A85
		// (set) Token: 0x06000770 RID: 1904 RVA: 0x00023897 File Offset: 0x00021A97
		[global::System.ComponentModel.Bindable(true)]
		public global::Infragistics.Windows.DockManager.PaneNavigationOrder NavigationOrder
		{
			get
			{
				return (global::Infragistics.Windows.DockManager.PaneNavigationOrder)base.GetValue(global::Infragistics.Windows.DockManager.XamDockManager.NavigationOrderProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DockManager.XamDockManager.NavigationOrderProperty, value);
			}
		}

		// Token: 0x17000215 RID: 533
		// (get) Token: 0x06000771 RID: 1905 RVA: 0x000238AA File Offset: 0x00021AAA
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Content)]
		public global::Infragistics.Collections.ObservableCollectionExtended<global::Infragistics.Windows.DockManager.SplitPane> Panes
		{
			get
			{
				return this._panes;
			}
		}

		// Token: 0x06000772 RID: 1906 RVA: 0x000238B2 File Offset: 0x00021AB2
		public static global::Infragistics.Windows.DockManager.PaneLocation GetPaneLocation(global::System.Windows.DependencyObject d)
		{
			return (global::Infragistics.Windows.DockManager.PaneLocation)d.GetValue(global::Infragistics.Windows.DockManager.XamDockManager.PaneLocationProperty);
		}

		// Token: 0x17000216 RID: 534
		// (get) Token: 0x06000773 RID: 1907 RVA: 0x000238C4 File Offset: 0x00021AC4
		// (set) Token: 0x06000774 RID: 1908 RVA: 0x000238D6 File Offset: 0x00021AD6
		[global::System.ComponentModel.Bindable(true)]
		public global::Infragistics.Windows.DockManager.PaneNavigatorButtonDisplayMode PaneNavigatorButtonDisplayMode
		{
			get
			{
				return (global::Infragistics.Windows.DockManager.PaneNavigatorButtonDisplayMode)base.GetValue(global::Infragistics.Windows.DockManager.XamDockManager.PaneNavigatorButtonDisplayModeProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DockManager.XamDockManager.PaneNavigatorButtonDisplayModeProperty, value);
			}
		}

		// Token: 0x17000217 RID: 535
		// (get) Token: 0x06000775 RID: 1909 RVA: 0x000238E9 File Offset: 0x00021AE9
		// (set) Token: 0x06000776 RID: 1910 RVA: 0x000238FB File Offset: 0x00021AFB
		[global::System.ComponentModel.Bindable(true)]
		public bool RerouteToolWindowKeyEvents
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.Windows.DockManager.XamDockManager.RerouteToolWindowKeyEventsProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DockManager.XamDockManager.RerouteToolWindowKeyEventsProperty, value);
			}
		}

		// Token: 0x17000218 RID: 536
		// (get) Token: 0x06000777 RID: 1911 RVA: 0x0002390E File Offset: 0x00021B0E
		// (set) Token: 0x06000778 RID: 1912 RVA: 0x00023920 File Offset: 0x00021B20
		[global::System.ComponentModel.Bindable(true)]
		public bool ShowFloatingWindowsInTaskbar
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.Windows.DockManager.XamDockManager.ShowFloatingWindowsInTaskbarProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DockManager.XamDockManager.ShowFloatingWindowsInTaskbarProperty, value);
			}
		}

		// Token: 0x17000219 RID: 537
		// (get) Token: 0x06000779 RID: 1913 RVA: 0x00023933 File Offset: 0x00021B33
		// (set) Token: 0x0600077A RID: 1914 RVA: 0x00023945 File Offset: 0x00021B45
		[global::System.ComponentModel.Bindable(true)]
		public global::Infragistics.Windows.DockManager.TabItemDragBehavior TabItemDragBehavior
		{
			get
			{
				return (global::Infragistics.Windows.DockManager.TabItemDragBehavior)base.GetValue(global::Infragistics.Windows.DockManager.XamDockManager.TabItemDragBehaviorProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DockManager.XamDockManager.TabItemDragBehaviorProperty, value);
			}
		}

		// Token: 0x0600077B RID: 1915 RVA: 0x00023958 File Offset: 0x00021B58
		private static void OnThemeChanged(global::System.Windows.DependencyObject target, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.DockManager.XamDockManager xamDockManager = target as global::Infragistics.Windows.DockManager.XamDockManager;
			if (xamDockManager.IsInitialized)
			{
				xamDockManager.InvalidateMeasure();
				xamDockManager.UpdateLayout();
			}
			xamDockManager.OnThemeChanged((string)e.OldValue, (string)e.NewValue);
		}

		// Token: 0x1700021A RID: 538
		// (get) Token: 0x0600077C RID: 1916 RVA: 0x0002399E File Offset: 0x00021B9E
		// (set) Token: 0x0600077D RID: 1917 RVA: 0x000239B0 File Offset: 0x00021BB0
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.TypeConverter(typeof(global::Infragistics.Windows.Themes.Internal.DockManagerThemeTypeConverter))]
		public string Theme
		{
			get
			{
				return (string)base.GetValue(global::Infragistics.Windows.DockManager.XamDockManager.ThemeProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DockManager.XamDockManager.ThemeProperty, value);
			}
		}

		// Token: 0x0600077E RID: 1918 RVA: 0x000239C0 File Offset: 0x00021BC0
		protected virtual void OnThemeChanged(string previousValue, string currentValue)
		{
			base.RaiseEvent(new global::System.Windows.RoutedPropertyChangedEventArgs<string>(previousValue, currentValue)
			{
				RoutedEvent = global::Infragistics.Windows.DockManager.XamDockManager.ThemeChangedEvent,
				Source = this
			});
		}

		// Token: 0x1400000B RID: 11
		// (add) Token: 0x0600077F RID: 1919 RVA: 0x000239EE File Offset: 0x00021BEE
		// (remove) Token: 0x06000780 RID: 1920 RVA: 0x000239FC File Offset: 0x00021BFC
		public event global::System.Windows.RoutedPropertyChangedEventHandler<string> ThemeChanged
		{
			add
			{
				base.AddHandler(global::Infragistics.Windows.DockManager.XamDockManager.ThemeChangedEvent, value);
			}
			remove
			{
				base.RemoveHandler(global::Infragistics.Windows.DockManager.XamDockManager.ThemeChangedEvent, value);
			}
		}

		// Token: 0x1700021B RID: 539
		// (get) Token: 0x06000781 RID: 1921 RVA: 0x00023A0A File Offset: 0x00021C0A
		// (set) Token: 0x06000782 RID: 1922 RVA: 0x00023A1C File Offset: 0x00021C1C
		[global::System.ComponentModel.Bindable(true)]
		public bool UseOwnedFloatingWindows
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.Windows.DockManager.XamDockManager.UseOwnedFloatingWindowsProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DockManager.XamDockManager.UseOwnedFloatingWindowsProperty, value);
			}
		}

		// Token: 0x1700021C RID: 540
		// (get) Token: 0x06000783 RID: 1923 RVA: 0x00023A2F File Offset: 0x00021C2F
		// (set) Token: 0x06000784 RID: 1924 RVA: 0x00023A41 File Offset: 0x00021C41
		[global::System.ComponentModel.Bindable(true)]
		public global::Infragistics.Windows.DockManager.PaneActionBehavior PinBehavior
		{
			get
			{
				return (global::Infragistics.Windows.DockManager.PaneActionBehavior)base.GetValue(global::Infragistics.Windows.DockManager.XamDockManager.PinBehaviorProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DockManager.XamDockManager.PinBehaviorProperty, value);
			}
		}

		// Token: 0x1700021D RID: 541
		// (get) Token: 0x06000785 RID: 1925 RVA: 0x00023A54 File Offset: 0x00021C54
		// (set) Token: 0x06000786 RID: 1926 RVA: 0x00023A66 File Offset: 0x00021C66
		[global::System.ComponentModel.Bindable(true)]
		public global::Infragistics.Windows.DockManager.UnpinnedTabHoverAction UnpinnedTabHoverAction
		{
			get
			{
				return (global::Infragistics.Windows.DockManager.UnpinnedTabHoverAction)base.GetValue(global::Infragistics.Windows.DockManager.XamDockManager.UnpinnedTabHoverActionProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DockManager.XamDockManager.UnpinnedTabHoverActionProperty, value);
			}
		}

		// Token: 0x1700021E RID: 542
		// (get) Token: 0x06000787 RID: 1927 RVA: 0x00023A79 File Offset: 0x00021C79
		internal global::Infragistics.Windows.DockManager.ActivePaneManager ActivePaneManager
		{
			get
			{
				return this._activePaneManager;
			}
		}

		// Token: 0x1700021F RID: 543
		// (get) Token: 0x06000788 RID: 1928 RVA: 0x00023A81 File Offset: 0x00021C81
		internal global::Infragistics.Windows.Commands.CommandsBase Commands
		{
			get
			{
				return this._commands;
			}
		}

		// Token: 0x06000789 RID: 1929 RVA: 0x00023A8C File Offset: 0x00021C8C
		private static void OnComputedFloatingWindowVisibilityChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.DockManager.XamDockManager xamDockManager = d as global::Infragistics.Windows.DockManager.XamDockManager;
			if (xamDockManager._toolWindows != null)
			{
				foreach (global::Infragistics.Windows.DockManager.PaneToolWindow paneToolWindow in xamDockManager._toolWindows)
				{
					paneToolWindow.CoerceValue(global::System.Windows.UIElement.VisibilityProperty);
				}
			}
		}

		// Token: 0x17000220 RID: 544
		// (get) Token: 0x0600078A RID: 1930 RVA: 0x00023AEC File Offset: 0x00021CEC
		internal global::System.Windows.Visibility ComputedFloatingWindowVisibility
		{
			get
			{
				return (global::System.Windows.Visibility)base.GetValue(global::Infragistics.Windows.DockManager.XamDockManager.ComputedFloatingWindowVisibilityProperty);
			}
		}

		// Token: 0x17000221 RID: 545
		// (get) Token: 0x0600078B RID: 1931 RVA: 0x00023AFE File Offset: 0x00021CFE
		internal global::Infragistics.Windows.DockManager.DockManagerPanel DockPanel
		{
			get
			{
				return this._dockPanel;
			}
		}

		// Token: 0x17000222 RID: 546
		// (get) Token: 0x0600078C RID: 1932 RVA: 0x00023B06 File Offset: 0x00021D06
		internal global::Infragistics.Windows.DockManager.DocumentContentHost DocumentContentHost
		{
			get
			{
				return base.Content as global::Infragistics.Windows.DockManager.DocumentContentHost;
			}
		}

		// Token: 0x17000223 RID: 547
		// (get) Token: 0x0600078D RID: 1933 RVA: 0x00023B13 File Offset: 0x00021D13
		internal bool DragFullWindows
		{
			get
			{
				return this.GetDragFullWindows(this.FloatingWindowDragMode);
			}
		}

		// Token: 0x0600078E RID: 1934 RVA: 0x00023B24 File Offset: 0x00021D24
		internal bool GetDragFullWindows(global::Infragistics.Windows.DockManager.FloatingWindowDragMode dragMode)
		{
			switch (dragMode)
			{
			case global::Infragistics.Windows.DockManager.FloatingWindowDragMode.Deferred:
				return false;
			case global::Infragistics.Windows.DockManager.FloatingWindowDragMode.UseDragFullWindowsSystemSetting:
			case global::Infragistics.Windows.DockManager.FloatingWindowDragMode.UseSystemWindowDrag:
			{
				object obj = base.TryFindResource(global::System.Windows.SystemParameters.DragFullWindowsKey);
				return !(obj is bool) || (bool)obj;
			}
			}
			return true;
		}

		// Token: 0x17000224 RID: 548
		// (get) Token: 0x0600078F RID: 1935 RVA: 0x00023B6C File Offset: 0x00021D6C
		internal global::System.Windows.FrameworkContentElement DragHelper
		{
			get
			{
				if (this._dragHelper == null)
				{
					this._dragHelper = new global::System.Windows.FrameworkContentElement();
					this._dragHelper.Name = "DockManagerDragHelper";
					this._dragHelper.SetValue(global::System.Windows.ContentElement.FocusableProperty, global::Infragistics.KnownBoxes.TrueBox);
					this.AddLogicalChildInternal(this._dragHelper);
				}
				return this._dragHelper;
			}
		}

		// Token: 0x17000225 RID: 549
		// (get) Token: 0x06000790 RID: 1936 RVA: 0x00023BC3 File Offset: 0x00021DC3
		internal global::Infragistics.Windows.DockManager.Dragging.DragManager DragManager
		{
			get
			{
				return this._dragManager;
			}
		}

		// Token: 0x17000226 RID: 550
		// (get) Token: 0x06000791 RID: 1937 RVA: 0x00023BCB File Offset: 0x00021DCB
		internal global::Infragistics.Windows.DockManager.SplitPane FillPane
		{
			get
			{
				if (this._fillPane == null)
				{
					return null;
				}
				return global::Infragistics.CoreUtilities.GetWeakReferenceTargetSafe(this._fillPane) as global::Infragistics.Windows.DockManager.SplitPane;
			}
		}

		// Token: 0x17000227 RID: 551
		// (get) Token: 0x06000792 RID: 1938 RVA: 0x00023BE7 File Offset: 0x00021DE7
		internal global::Infragistics.Windows.DockManager.UnpinnedFlyoutState FlyoutState
		{
			get
			{
				if (this._dockPanel != null && this._dockPanel.HasFlyoutPanel)
				{
					return this._dockPanel.FlyoutPanel.CurrentState;
				}
				return global::Infragistics.Windows.DockManager.UnpinnedFlyoutState.Closed;
			}
		}

		// Token: 0x17000228 RID: 552
		// (get) Token: 0x06000793 RID: 1939 RVA: 0x00023C10 File Offset: 0x00021E10
		internal bool HasHwndHost
		{
			get
			{
				if (this._hasHwndHost == null)
				{
					this._hasHwndHost = new bool?(false);
					if (this._dockPanel != null && this._dockPanel.HasHwndHost)
					{
						this._hasHwndHost = new bool?(true);
					}
					else if (base.Content is global::System.Windows.FrameworkElement)
					{
						global::Infragistics.Windows.DockManager.HwndHostInfo hwndHost = global::Infragistics.Windows.DockManager.HwndHostInfo.GetHwndHost((global::System.Windows.DependencyObject)base.Content);
						if (hwndHost != null)
						{
							this._hasHwndHost = new bool?(hwndHost.HasHwndHost);
						}
					}
					if (this._hasHwndHost == false)
					{
						foreach (global::Infragistics.Windows.DockManager.ContentPane contentPane in this.GetPanes(global::Infragistics.Windows.DockManager.PaneNavigationOrder.VisibleOrder))
						{
							if (contentPane.HasHwndHost)
							{
								this._hasHwndHost = new bool?(true);
								break;
							}
						}
					}
					this._activePaneManager.VerifyHasPreprocessHandler();
					global::Infragistics.Windows.DockManager.HwndHostInfo.OnHasHwndHostChanged(this);
				}
				return this._hasHwndHost.Value;
			}
		}

		// Token: 0x17000229 RID: 553
		// (get) Token: 0x06000794 RID: 1940 RVA: 0x00023D18 File Offset: 0x00021F18
		internal bool? HasHwndHostNoVerify
		{
			get
			{
				return this._hasHwndHost;
			}
		}

		// Token: 0x1700022A RID: 554
		// (get) Token: 0x06000795 RID: 1941 RVA: 0x00023D20 File Offset: 0x00021F20
		// (set) Token: 0x06000796 RID: 1942 RVA: 0x00023D28 File Offset: 0x00021F28
		internal bool IsActivatingPane
		{
			get
			{
				return this._isActivatingPane;
			}
			set
			{
				this._isActivatingPane = value;
			}
		}

		// Token: 0x1700022B RID: 555
		// (get) Token: 0x06000797 RID: 1943 RVA: 0x00023D31 File Offset: 0x00021F31
		internal bool IsClosingPanes
		{
			get
			{
				return this._isClosingPanes;
			}
		}

		// Token: 0x1700022C RID: 556
		// (get) Token: 0x06000798 RID: 1944 RVA: 0x00023D39 File Offset: 0x00021F39
		// (set) Token: 0x06000799 RID: 1945 RVA: 0x00023D41 File Offset: 0x00021F41
		internal bool IsLoadingLayout
		{
			get
			{
				return this._isLoadingLayout;
			}
			set
			{
				if (value != this._isLoadingLayout)
				{
					this._isLoadingLayout = value;
					if (!value)
					{
						base.Dispatcher.BeginInvoke(global::System.Windows.Threading.DispatcherPriority.Normal, new global::Infragistics.Windows.DockManager.DockManagerUtilities.MethodInvoker(this.ResumeShowFlyout));
						return;
					}
					this.SuspendShowFlyout();
				}
			}
		}

		// Token: 0x1700022D RID: 557
		// (get) Token: 0x0600079A RID: 1946 RVA: 0x00023D77 File Offset: 0x00021F77
		internal bool IsShowFlyoutSuspended
		{
			get
			{
				return this._suspendShowFlyoutCount > 0;
			}
		}

		// Token: 0x1700022E RID: 558
		// (get) Token: 0x0600079B RID: 1947 RVA: 0x00023D82 File Offset: 0x00021F82
		internal bool ShowFlyoutInToolWindow
		{
			get
			{
				return this.HasHwndHost && (!global::System.Windows.Interop.BrowserInteropHelper.IsBrowserHosted || global::Infragistics.Windows.DockManager.DockManagerUtilities.HasUnmanagedCodeRights);
			}
		}

		// Token: 0x1700022F RID: 559
		// (get) Token: 0x0600079C RID: 1948 RVA: 0x00023D9C File Offset: 0x00021F9C
		internal bool ShowSplitterInPopup
		{
			get
			{
				return this.ShowFlyoutInToolWindow;
			}
		}

		// Token: 0x17000230 RID: 560
		// (get) Token: 0x0600079D RID: 1949 RVA: 0x00023DA4 File Offset: 0x00021FA4
		internal bool ShowToolWindowsInPopup
		{
			get
			{
				return this.HasHwndHost && global::System.Windows.Interop.BrowserInteropHelper.IsBrowserHosted && global::Infragistics.Windows.DockManager.DockManagerUtilities.HasUnmanagedCodeRights;
			}
		}

		// Token: 0x17000231 RID: 561
		// (get) Token: 0x0600079E RID: 1950 RVA: 0x00023DBC File Offset: 0x00021FBC
		internal global::System.Collections.ObjectModel.ReadOnlyObservableCollection<global::Infragistics.Windows.DockManager.PaneToolWindow> ToolWindows
		{
			get
			{
				return this._readOnlyWindows;
			}
		}

		// Token: 0x17000232 RID: 562
		// (get) Token: 0x0600079F RID: 1951 RVA: 0x00023DC4 File Offset: 0x00021FC4
		internal global::Infragistics.Windows.DockManager.LogicalContainer UnpinnedPaneHolder
		{
			get
			{
				if (this._unpinnedPaneHolder == null)
				{
					this._unpinnedPaneHolder = new global::Infragistics.Windows.DockManager.LogicalContainer();
					this._unpinnedPaneHolder.SetValue(global::Infragistics.Windows.DockManager.XamDockManager.PaneLocationPropertyKey, global::Infragistics.Windows.DockManager.DockManagerKnownBoxes.PaneLocationUnpinnedBox);
					this.AddLogicalChildInternal(this._unpinnedPaneHolder);
				}
				return this._unpinnedPaneHolder;
			}
		}

		// Token: 0x17000233 RID: 563
		// (get) Token: 0x060007A0 RID: 1952 RVA: 0x00023E00 File Offset: 0x00022000
		private bool AllowToolWindowLoaded
		{
			get
			{
				if (this.IsLoadingLayout || !base.IsLoaded)
				{
					return false;
				}
				if (!base.IsInitialized)
				{
					return false;
				}
				if (this._hwndSourceHelper == null)
				{
					return base.IsVisible;
				}
				if (this._hwndSourceHelper.CurrentSource == null)
				{
					return false;
				}
				switch (this.FloatingWindowVisibility)
				{
				case global::Infragistics.Windows.DockManager.FloatingWindowVisibility.Visible:
				case global::Infragistics.Windows.DockManager.FloatingWindowVisibility.Hidden:
					return true;
				case global::Infragistics.Windows.DockManager.FloatingWindowVisibility.Collapsed:
					return false;
				default:
					return this._hwndSourceHelper.RootVisualVisibility != global::System.Windows.Visibility.Collapsed;
				}
			}
		}

		// Token: 0x17000234 RID: 564
		// (get) Token: 0x060007A1 RID: 1953 RVA: 0x00023E77 File Offset: 0x00022077
		private bool IsHwndSourceRootVisualNonVisible
		{
			get
			{
				return this._hwndSourceHelper != null && this._hwndSourceHelper.CurrentSource != null && this._hwndSourceHelper.RootVisualVisibility != global::System.Windows.Visibility.Visible;
			}
		}

		// Token: 0x060007A2 RID: 1954 RVA: 0x00023EA4 File Offset: 0x000220A4
		public global::Infragistics.Windows.DockManager.ContentPane AddDocument(object header, object content)
		{
			if (!this.HasDocumentContentHost)
			{
				throw new global::System.InvalidOperationException(global::Infragistics.Windows.DockManager.XamDockManager.GetString("LE_NeedDocumentContentHost"));
			}
			global::Infragistics.Windows.DockManager.ContentPane contentPane = new global::Infragistics.Windows.DockManager.ContentPane();
			contentPane.Header = header;
			contentPane.Content = content;
			global::Infragistics.Windows.DockManager.IContentPaneContainer containerForPane = this.DocumentContentHost.GetContainerForPane(contentPane, true);
			containerForPane.InsertContentPane(new int?(0), contentPane);
			return contentPane;
		}

		// Token: 0x060007A3 RID: 1955 RVA: 0x00023EF9 File Offset: 0x000220F9
		public global::System.Collections.Generic.IEnumerable<global::Infragistics.Windows.DockManager.ContentPane> GetPanes(global::Infragistics.Windows.DockManager.PaneNavigationOrder order)
		{
			return this.ActivePaneManager.GetPanes(global::Infragistics.Windows.DockManager.PaneFilterFlags.All, order, false);
		}

		// Token: 0x060007A4 RID: 1956 RVA: 0x00023F09 File Offset: 0x00022109
		public bool ExecuteCommand(global::System.Windows.Input.RoutedCommand command)
		{
			return this.ExecuteCommandImpl(new global::Infragistics.Windows.Commands.ExecuteCommandInfo(command));
		}

		// Token: 0x060007A5 RID: 1957 RVA: 0x00023F17 File Offset: 0x00022117
		public void LoadLayout(global::System.IO.Stream stream)
		{
			global::Infragistics.Windows.DockManager.LayoutManager.LoadLayout(this, stream);
		}

		// Token: 0x060007A6 RID: 1958 RVA: 0x00023F20 File Offset: 0x00022120
		public void LoadLayout(string layout)
		{
			global::Infragistics.Windows.DockManager.LayoutManager.LoadLayout(this, layout);
		}

		// Token: 0x060007A7 RID: 1959 RVA: 0x00023F29 File Offset: 0x00022129
		public void SaveLayout(global::System.IO.Stream stream)
		{
			global::Infragistics.Windows.DockManager.LayoutManager.SaveLayout(this, stream);
		}

		// Token: 0x060007A8 RID: 1960 RVA: 0x00023F32 File Offset: 0x00022132
		public string SaveLayout()
		{
			return global::Infragistics.Windows.DockManager.LayoutManager.SaveLayout(this);
		}

		// Token: 0x060007A9 RID: 1961 RVA: 0x00023F3A File Offset: 0x0002213A
		internal void AddLogicalChildInternal(global::System.Windows.DependencyObject logicalChild)
		{
			if (this._logicalChildren == null)
			{
				this._logicalChildren = new global::System.Collections.Generic.List<global::System.Windows.DependencyObject>();
			}
			this._logicalChildren.Add(logicalChild);
			base.AddLogicalChild(logicalChild);
		}

		// Token: 0x060007AA RID: 1962 RVA: 0x00023F64 File Offset: 0x00022164
		internal global::Infragistics.Windows.DockManager.Dragging.AllowedDropLocations AdjustAllowedDropLocations(global::Infragistics.Windows.DockManager.Dragging.AllowedDropLocations allowedLocations)
		{
			global::Infragistics.Windows.DockManager.FloatingWindowVisibility floatingWindowVisibility = this.FloatingWindowVisibility;
			switch (floatingWindowVisibility)
			{
			case global::Infragistics.Windows.DockManager.FloatingWindowVisibility.Hidden:
			case global::Infragistics.Windows.DockManager.FloatingWindowVisibility.Collapsed:
				allowedLocations &= ~global::Infragistics.Windows.DockManager.Dragging.AllowedDropLocations.Floating;
				break;
			}
			if (this.IsHwndSourceRootVisualNonVisible)
			{
				allowedLocations &= ~(global::Infragistics.Windows.DockManager.Dragging.AllowedDropLocations.Left | global::Infragistics.Windows.DockManager.Dragging.AllowedDropLocations.Top | global::Infragistics.Windows.DockManager.Dragging.AllowedDropLocations.Right | global::Infragistics.Windows.DockManager.Dragging.AllowedDropLocations.Bottom | global::Infragistics.Windows.DockManager.Dragging.AllowedDropLocations.Document);
				if (floatingWindowVisibility == global::Infragistics.Windows.DockManager.FloatingWindowVisibility.SyncWithDockManagerWindow)
				{
					allowedLocations &= ~global::Infragistics.Windows.DockManager.Dragging.AllowedDropLocations.Floating;
				}
			}
			return allowedLocations;
		}

		// Token: 0x060007AB RID: 1963 RVA: 0x00023FAC File Offset: 0x000221AC
		internal void BringToolWindowsToFront()
		{
			global::Infragistics.Windows.Controls.ToolWindow[] toolWindows = global::Infragistics.Windows.Controls.ToolWindow.GetToolWindows(this);
			for (int i = toolWindows.Length - 1; i >= 0; i--)
			{
				global::Infragistics.Windows.DockManager.PaneToolWindow paneToolWindow = toolWindows[i] as global::Infragistics.Windows.DockManager.PaneToolWindow;
				if (paneToolWindow != null && paneToolWindow.IsVisible)
				{
					paneToolWindow.BringToFront();
				}
			}
		}

		// Token: 0x060007AC RID: 1964 RVA: 0x00023FEC File Offset: 0x000221EC
		internal static bool CanMoveToNewGroup(global::Infragistics.Windows.DockManager.ContentPane pane, global::System.Windows.Controls.Orientation orientation)
		{
			if (pane != null && pane.IsDocument)
			{
				global::Infragistics.Windows.DockManager.IContentPaneContainer currentContainer = pane.PlacementInfo.CurrentContainer;
				return currentContainer != null && currentContainer.GetVisiblePanes().Count > 1;
			}
			return false;
		}

		// Token: 0x060007AD RID: 1965 RVA: 0x00024025 File Offset: 0x00022225
		internal static bool CanMoveToNextPreviousGroup(global::Infragistics.Windows.DockManager.ContentPane pane, bool next)
		{
			return null != global::Infragistics.Windows.DockManager.XamDockManager.GetNextPreviousGroup(pane, next);
		}

		// Token: 0x060007AE RID: 1966 RVA: 0x00024034 File Offset: 0x00022234
		internal void CloseAllButThis(global::Infragistics.Windows.DockManager.ContentPane pane)
		{
			if (pane.PaneLocation != global::Infragistics.Windows.DockManager.PaneLocation.Document)
			{
				return;
			}
			global::System.Collections.Generic.IList<global::Infragistics.Windows.DockManager.ContentPane> list = new global::System.Collections.Generic.List<global::Infragistics.Windows.DockManager.ContentPane>();
			foreach (global::Infragistics.Windows.DockManager.ContentPane contentPane in global::Infragistics.Windows.DockManager.DockManagerUtilities.GetAllPanes(this.DocumentContentHost, global::Infragistics.Windows.DockManager.PaneFilterFlags.AllVisible))
			{
				if (contentPane != pane && contentPane.AllowClose)
				{
					list.Add(contentPane);
				}
			}
			this.ClosePanes(list);
		}

		// Token: 0x060007AF RID: 1967 RVA: 0x000240B4 File Offset: 0x000222B4
		internal void ClosePane(global::Infragistics.Windows.DockManager.ContentPane pane, bool includeSiblingsIfAllowed)
		{
			global::System.Collections.Generic.IList<global::Infragistics.Windows.DockManager.ContentPane> panesToProcess = this.GetPanesToProcess(pane, includeSiblingsIfAllowed, this.CloseBehavior);
			this.ClosePanes(panesToProcess);
		}

		// Token: 0x060007B0 RID: 1968 RVA: 0x000240D8 File Offset: 0x000222D8
		internal void ClosePanes(global::System.Collections.Generic.IList<global::Infragistics.Windows.DockManager.ContentPane> panes)
		{
			int i = 0;
			int count = panes.Count;
			while (i < count)
			{
				global::Infragistics.Windows.DockManager.ContentPane contentPane = panes[i];
				if (contentPane.AllowClose)
				{
					this.ClosePaneHelper(contentPane, contentPane.CloseAction, true);
				}
				i++;
			}
			base.Dispatcher.BeginInvoke(global::System.Windows.Threading.DispatcherPriority.Send, new global::Infragistics.Windows.DockManager.DockManagerUtilities.MethodInvoker(this.ActivePaneManager.VerifyActivePane));
		}

		// Token: 0x060007B1 RID: 1969 RVA: 0x00024135 File Offset: 0x00022335
		internal void ClosePaneHelper(global::Infragistics.Windows.DockManager.ContentPane pane, global::Infragistics.Windows.DockManager.PaneCloseAction closeAction, bool raiseEvents)
		{
			this.ClosePaneHelper(pane, closeAction, raiseEvents, true);
		}

		// Token: 0x060007B2 RID: 1970 RVA: 0x00024144 File Offset: 0x00022344
		internal void ClosePaneHelper(global::Infragistics.Windows.DockManager.ContentPane pane, global::Infragistics.Windows.DockManager.PaneCloseAction closeAction, bool raiseEvents, bool removeFromCurrentContainer)
		{
			bool isClosingPanes = this._isClosingPanes;
			this._isClosingPanes = true;
			try
			{
				this.ClosePaneHelperImpl(pane, closeAction, raiseEvents, removeFromCurrentContainer);
			}
			finally
			{
				this._isClosingPanes = isClosingPanes;
			}
		}

		// Token: 0x060007B3 RID: 1971 RVA: 0x00024184 File Offset: 0x00022384
		private void ClosePaneHelperImpl(global::Infragistics.Windows.DockManager.ContentPane pane, global::Infragistics.Windows.DockManager.PaneCloseAction closeAction, bool raiseEvents, bool removeFromCurrentContainer)
		{
			if (raiseEvents)
			{
				global::Infragistics.Windows.DockManager.Events.PaneClosingEventArgs paneClosingEventArgs = new global::Infragistics.Windows.DockManager.Events.PaneClosingEventArgs();
				pane.RaiseClosing(paneClosingEventArgs);
				if (paneClosingEventArgs.Cancel)
				{
					return;
				}
			}
			if (closeAction == global::Infragistics.Windows.DockManager.PaneCloseAction.RemovePane)
			{
				global::Infragistics.Windows.DockManager.ContentPane.PanePlacementInfo placementInfo = pane.PlacementInfo;
				if (placementInfo.DockedEdgePlaceholder != null)
				{
					this.DestroyPaneElement(placementInfo.DockedEdgePlaceholder.Container, pane);
				}
				if (placementInfo.FloatingDockablePlaceholder != null)
				{
					this.DestroyPaneElement(placementInfo.FloatingDockablePlaceholder.Container, pane);
				}
				if (placementInfo.FloatingOnlyPlaceholder != null)
				{
					this.DestroyPaneElement(placementInfo.FloatingOnlyPlaceholder.Container, pane);
				}
				if (removeFromCurrentContainer)
				{
					this.DestroyPaneElement(placementInfo.CurrentContainer, pane);
				}
			}
			else
			{
				pane.Visibility = global::System.Windows.Visibility.Collapsed;
			}
			if (raiseEvents)
			{
				pane.RaiseClosed(new global::Infragistics.Windows.DockManager.Events.PaneClosedEventArgs());
			}
		}

		// Token: 0x060007B4 RID: 1972 RVA: 0x0002422B File Offset: 0x0002242B
		internal void DirtyHasHwndHosts()
		{
			this._hasHwndHost = null;
		}

		// Token: 0x060007B5 RID: 1973 RVA: 0x0002423C File Offset: 0x0002243C
		internal void EnsureIsFocusedElement(global::System.Windows.DependencyObject newNestedFocusedElement)
		{
			if (newNestedFocusedElement != null)
			{
				global::System.Windows.DependencyObject focusScope = global::System.Windows.Input.FocusManager.GetFocusScope(newNestedFocusedElement);
				global::System.Windows.DependencyObject parent = global::Infragistics.Windows.Utilities.GetParent(this);
				global::System.Windows.DependencyObject dependencyObject = (parent != null) ? global::System.Windows.Input.FocusManager.GetFocusScope(parent) : null;
				global::System.Windows.DependencyObject dependencyObject2 = (dependencyObject != null) ? (global::System.Windows.Input.FocusManager.GetFocusedElement(dependencyObject) as global::System.Windows.DependencyObject) : null;
				if (dependencyObject2 == this)
				{
					return;
				}
				if (dependencyObject != null && focusScope != dependencyObject && (dependencyObject2 == null || dependencyObject2 == this._dragHelper || !global::Infragistics.Windows.Utilities.IsDescendantOf(this, dependencyObject2, true)))
				{
					bool isSettingFocusedElement = this._isSettingFocusedElement;
					this._isSettingFocusedElement = true;
					try
					{
						global::Infragistics.Windows.DockManager.DockManagerUtilities.SetFocusedElement(dependencyObject, this);
					}
					finally
					{
						this._isSettingFocusedElement = isSettingFocusedElement;
					}
				}
			}
		}

		// Token: 0x060007B6 RID: 1974 RVA: 0x000242CC File Offset: 0x000224CC
		internal void ForceFocus()
		{
			this.ForceFocus(this);
		}

		// Token: 0x060007B7 RID: 1975 RVA: 0x000242D8 File Offset: 0x000224D8
		internal void ForceFocus(global::System.Windows.IInputElement element)
		{
			bool forcingFocus = this._forcingFocus;
			this._forcingFocus = true;
			try
			{
				element.Focus();
			}
			finally
			{
				this._forcingFocus = forcingFocus;
			}
		}

		// Token: 0x060007B8 RID: 1976 RVA: 0x00024314 File Offset: 0x00022514
		internal global::System.Windows.Controls.Dock GetDockedSide(global::Infragistics.Windows.DockManager.ContentPane pane)
		{
			global::Infragistics.Windows.DockManager.PaneLocation paneLocation = global::Infragistics.Windows.DockManager.PaneLocation.DockedLeft;
			if (pane.PlacementInfo.DockedEdgePlaceholder != null)
			{
				paneLocation = global::Infragistics.Windows.DockManager.XamDockManager.GetPaneLocation(pane.PlacementInfo.DockedEdgePlaceholder);
			}
			else if (paneLocation == global::Infragistics.Windows.DockManager.PaneLocation.Unpinned)
			{
				global::Infragistics.Windows.DockManager.UnpinnedTabAreaInfo unpinnedTabAreaInfo = pane.PlacementInfo.CurrentContainer as global::Infragistics.Windows.DockManager.UnpinnedTabAreaInfo;
				if (unpinnedTabAreaInfo != null)
				{
					return (global::System.Windows.Controls.Dock)global::System.Array.IndexOf<global::Infragistics.Windows.DockManager.UnpinnedTabAreaInfo>(this._tabAreaInfos, unpinnedTabAreaInfo);
				}
			}
			else if (global::Infragistics.Windows.DockManager.DockManagerUtilities.IsDocked(paneLocation))
			{
				paneLocation = global::Infragistics.Windows.DockManager.XamDockManager.GetPaneLocation(pane);
			}
			return global::Infragistics.Windows.DockManager.DockManagerUtilities.GetDockedSide(paneLocation);
		}

		// Token: 0x060007B9 RID: 1977 RVA: 0x00024380 File Offset: 0x00022580
		internal static global::Infragistics.Windows.DockManager.IContentPaneContainer GetNextPreviousGroup(global::Infragistics.Windows.DockManager.ContentPane pane, bool next)
		{
			if (pane != null && pane.IsDocument)
			{
				global::Infragistics.Windows.DockManager.XamDockManager dockManager = global::Infragistics.Windows.DockManager.XamDockManager.GetDockManager(pane);
				if (dockManager != null && dockManager.HasDocumentContentHost)
				{
					global::Infragistics.Windows.DockManager.DocumentContentHost documentContentHost = dockManager.DocumentContentHost;
					global::Infragistics.Windows.DockManager.ContentPane contentPane = pane;
					while ((contentPane = global::Infragistics.Windows.DockManager.DockManagerUtilities.GetNextPreviousPane(contentPane, false, next, documentContentHost)) != null)
					{
						if (contentPane.PlacementInfo.CurrentContainer != pane.PlacementInfo.CurrentContainer)
						{
							return contentPane.PlacementInfo.CurrentContainer;
						}
					}
				}
			}
			return null;
		}

		// Token: 0x060007BA RID: 1978 RVA: 0x000243E8 File Offset: 0x000225E8
		internal static global::Infragistics.Windows.DockManager.ContentPane GetPaneForCommand(object parameter, object originalSource, global::Infragistics.Windows.DockManager.ContentPane defaultPane)
		{
			global::Infragistics.Windows.DockManager.ContentPane contentPane = parameter as global::Infragistics.Windows.DockManager.ContentPane;
			if (contentPane == null)
			{
				contentPane = (originalSource as global::Infragistics.Windows.DockManager.ContentPane);
			}
			if (contentPane == null)
			{
				global::System.Windows.DependencyObject dependencyObject = originalSource as global::System.Windows.DependencyObject;
				if (dependencyObject != null && !(dependencyObject is global::Infragistics.Windows.DockManager.XamDockManager))
				{
					contentPane = (global::Infragistics.Windows.Utilities.GetAncestorFromType(dependencyObject, typeof(global::Infragistics.Windows.DockManager.ContentPane), true, null, typeof(global::Infragistics.Windows.DockManager.XamDockManager)) as global::Infragistics.Windows.DockManager.ContentPane);
				}
			}
			if (contentPane == null)
			{
				contentPane = defaultPane;
			}
			return contentPane;
		}

		// Token: 0x060007BB RID: 1979 RVA: 0x00024443 File Offset: 0x00022643
		internal static string GetString(string name)
		{
			return global::Infragistics.Windows.DockManager.XamDockManager.GetString(name, null);
		}

		// Token: 0x060007BC RID: 1980 RVA: 0x0002444C File Offset: 0x0002264C
		internal static string GetString(string name, params object[] args)
		{
			return global::SR.GetString(name, args);
		}

		// Token: 0x060007BD RID: 1981 RVA: 0x00024455 File Offset: 0x00022655
		internal global::Infragistics.Windows.DockManager.UnpinnedTabAreaInfo GetUnpinnedTabAreaInfo(global::System.Windows.Controls.Dock side)
		{
			return this._tabAreaInfos[(int)side];
		}

		// Token: 0x060007BE RID: 1982 RVA: 0x0002445F File Offset: 0x0002265F
		internal global::Infragistics.Windows.DockManager.UnpinnedTabArea GetUnpinnedTabArea(global::System.Windows.Controls.Dock side)
		{
			return this.GetUnpinnedTabAreaInfo(side).TabArea;
		}

		// Token: 0x060007BF RID: 1983 RVA: 0x0002446D File Offset: 0x0002266D
		internal void HideFlyout(global::Infragistics.Windows.DockManager.ContentPane pane, bool checkMouseOver, bool allowAnimation, bool ignoreMouseWhileClosing, bool allowAutoHideDelay, bool honorIsFlyInSuspended = false)
		{
			if (this._dockPanel != null && this._dockPanel.HasFlyoutPanel)
			{
				this._dockPanel.FlyoutPanel.HideFlyout(pane, checkMouseOver, allowAnimation, ignoreMouseWhileClosing, allowAutoHideDelay, honorIsFlyInSuspended);
			}
		}

		// Token: 0x060007C0 RID: 1984 RVA: 0x000244A0 File Offset: 0x000226A0
		internal bool IsPaneLocationVisible(global::Infragistics.Windows.DockManager.PaneLocation paneLocation)
		{
			switch (paneLocation)
			{
			case global::Infragistics.Windows.DockManager.PaneLocation.Floating:
			case global::Infragistics.Windows.DockManager.PaneLocation.FloatingOnly:
				switch (this.FloatingWindowVisibility)
				{
				case global::Infragistics.Windows.DockManager.FloatingWindowVisibility.Hidden:
				case global::Infragistics.Windows.DockManager.FloatingWindowVisibility.Collapsed:
					return false;
				case global::Infragistics.Windows.DockManager.FloatingWindowVisibility.SyncWithDockManagerWindow:
					if (this.IsHwndSourceRootVisualNonVisible)
					{
						return false;
					}
					break;
				}
				break;
			default:
				if (this.IsHwndSourceRootVisualNonVisible)
				{
					return false;
				}
				break;
			}
			return true;
		}

		// Token: 0x060007C1 RID: 1985 RVA: 0x000244F8 File Offset: 0x000226F8
		internal bool MeetsVisibleCriteria(global::System.Windows.FrameworkElement element)
		{
			if (element == null)
			{
				return false;
			}
			global::Infragistics.Windows.DockManager.PaneLocation paneLocation = global::Infragistics.Windows.DockManager.XamDockManager.GetPaneLocation(element);
			if (global::Infragistics.Windows.DockManager.DockManagerUtilities.IsFloating(paneLocation))
			{
				switch (this.FloatingWindowVisibility)
				{
				case global::Infragistics.Windows.DockManager.FloatingWindowVisibility.Visible:
					return true;
				case global::Infragistics.Windows.DockManager.FloatingWindowVisibility.Hidden:
				case global::Infragistics.Windows.DockManager.FloatingWindowVisibility.Collapsed:
					return false;
				case global::Infragistics.Windows.DockManager.FloatingWindowVisibility.SyncWithDockManagerWindow:
					if (this.IsHwndSourceRootVisualNonVisible)
					{
						return false;
					}
					break;
				}
			}
			else if (this.IsHwndSourceRootVisualNonVisible)
			{
				return false;
			}
			return true;
		}

		// Token: 0x060007C2 RID: 1986 RVA: 0x00024554 File Offset: 0x00022754
		internal void MovePaneToPinnedContainer(global::Infragistics.Windows.DockManager.ContentPane pane, bool isRemovingPane)
		{
			global::Infragistics.Windows.DockManager.ContentPanePlaceholder dockedEdgePlaceholder = pane.PlacementInfo.DockedEdgePlaceholder;
			if (dockedEdgePlaceholder != null && (isRemovingPane || (global::Infragistics.Windows.DockManager.XamDockManager.GetDockManager(dockedEdgePlaceholder) == this && global::Infragistics.Windows.DockManager.DockManagerUtilities.IsDocked(dockedEdgePlaceholder))))
			{
				global::Infragistics.Windows.DockManager.IContentPaneContainer container = dockedEdgePlaceholder.Container;
				global::Infragistics.Windows.DockManager.IContentPaneContainer currentContainer = pane.PlacementInfo.CurrentContainer;
				if (container == null && isRemovingPane)
				{
					pane.PlacementInfo.RemovePlaceholder(dockedEdgePlaceholder);
					this.ClosePaneHelper(pane, global::Infragistics.Windows.DockManager.PaneCloseAction.RemovePane, false);
					return;
				}
				if (container != null && currentContainer != null)
				{
					using (global::Infragistics.Windows.DockManager.DockManagerUtilities.CreateMoveReplacement(pane))
					{
						currentContainer.RemoveContentPane(pane, false);
						container.InsertContentPane(null, pane);
					}
					if (pane.IsActivePane)
					{
						pane.BringIntoView();
					}
				}
			}
		}

		// Token: 0x060007C3 RID: 1987 RVA: 0x00024608 File Offset: 0x00022808
		internal static bool MoveToNewGroup(global::Infragistics.Windows.DockManager.ContentPane pane, global::System.Windows.Controls.Orientation newGroupOrientation)
		{
			if (pane == null || !pane.IsDocument)
			{
				return false;
			}
			global::Infragistics.Windows.DockManager.IContentPaneContainer currentContainer = pane.PlacementInfo.CurrentContainer;
			global::Infragistics.Windows.DockManager.IPaneContainer parentPane = global::Infragistics.Windows.DockManager.DockManagerUtilities.GetParentPane(currentContainer);
			global::Infragistics.Windows.DockManager.SplitPane splitPane = parentPane as global::Infragistics.Windows.DockManager.SplitPane;
			if (splitPane != null)
			{
				using (global::Infragistics.Windows.Helpers.GroupTempValueReplacement groupTempValueReplacement = new global::Infragistics.Windows.Helpers.GroupTempValueReplacement())
				{
					global::Infragistics.Windows.DockManager.DockManagerUtilities.AddMoveReplacement(groupTempValueReplacement, pane);
					currentContainer.RemoveContentPane(pane, false);
					global::System.Windows.FrameworkElement frameworkElement = (global::System.Windows.FrameworkElement)currentContainer;
					int num = splitPane.Panes.IndexOf(frameworkElement);
					global::Infragistics.Windows.DockManager.TabGroupPane tabGroupPane = global::Infragistics.Windows.DockManager.DockManagerUtilities.CreateTabGroup(global::Infragistics.Windows.DockManager.XamDockManager.GetDockManager(splitPane));
					tabGroupPane.Items.Add(pane);
					if (splitPane.SplitterOrientation == newGroupOrientation)
					{
						splitPane.Panes.Insert(num + 1, tabGroupPane);
					}
					else
					{
						global::Infragistics.Windows.DockManager.SplitPane splitPane2 = global::Infragistics.Windows.DockManager.DockManagerUtilities.CreateSplitPane(global::Infragistics.Windows.DockManager.XamDockManager.GetDockManager(splitPane));
						splitPane2.SplitterOrientation = newGroupOrientation;
						global::Infragistics.Windows.DockManager.DockManagerUtilities.AddMoveReplacement(groupTempValueReplacement, frameworkElement);
						splitPane.Panes.Remove(frameworkElement);
						splitPane2.Panes.Add(frameworkElement);
						splitPane2.Panes.Add(tabGroupPane);
						splitPane.Panes.Insert(num, splitPane2);
					}
					global::Infragistics.Windows.DockManager.DockManagerUtilities.RemoveContainerIfNeeded(currentContainer);
					return true;
				}
				return false;
			}
			return false;
		}

		// Token: 0x060007C4 RID: 1988 RVA: 0x00024724 File Offset: 0x00022924
		internal bool MoveToNextGroup(global::Infragistics.Windows.DockManager.ContentPane pane, bool next)
		{
			if (pane == null)
			{
				return false;
			}
			global::Infragistics.Windows.DockManager.IContentPaneContainer nextPreviousGroup = global::Infragistics.Windows.DockManager.XamDockManager.GetNextPreviousGroup(pane, next);
			global::Infragistics.Windows.DockManager.IContentPaneContainer currentContainer = pane.PlacementInfo.CurrentContainer;
			if (pane.IsDocument && nextPreviousGroup != null && currentContainer != null && nextPreviousGroup != currentContainer)
			{
				using (global::Infragistics.Windows.DockManager.DockManagerUtilities.CreateMoveReplacement(pane))
				{
					currentContainer.RemoveContentPane(pane, false);
					nextPreviousGroup.InsertContentPane(new int?(0), pane);
					pane.BringIntoView();
					global::Infragistics.Windows.DockManager.DockManagerUtilities.RemoveContainerIfNeeded(currentContainer);
					return true;
				}
				return false;
			}
			return false;
		}

		// Token: 0x060007C5 RID: 1989 RVA: 0x000247A8 File Offset: 0x000229A8
		internal void OnAfterLoadLayout()
		{
			foreach (global::Infragistics.Windows.DockManager.PaneToolWindow paneToolWindow in this._toolWindows)
			{
				paneToolWindow.RefreshToolWindowState();
			}
			this.VerifyFloatingWindowVisibility();
		}

		// Token: 0x060007C6 RID: 1990 RVA: 0x000247FC File Offset: 0x000229FC
		internal void OnBeforeLoadLayout()
		{
		}

		// Token: 0x060007C7 RID: 1991 RVA: 0x000247FE File Offset: 0x000229FE
		internal void OnBeforeLoadLayoutProcess()
		{
			this.ActivePaneManager.ProcessPendingOperations();
		}

		// Token: 0x060007C8 RID: 1992 RVA: 0x0002480C File Offset: 0x00022A0C
		internal void OnBeforeSaveLayout()
		{
			foreach (global::Infragistics.Windows.DockManager.ContentPane contentPane in this.GetPanes(global::Infragistics.Windows.DockManager.PaneNavigationOrder.VisibleOrder))
			{
				this.ProcessPinnedState(contentPane, contentPane.PaneLocation, false);
			}
			this.ProcessDeferredUnpinnedPanes();
		}

		// Token: 0x060007C9 RID: 1993 RVA: 0x00024868 File Offset: 0x00022A68
		internal void ProcessKeyDown(global::System.Windows.Input.KeyEventArgs e)
		{
			if (e.Handled)
			{
				return;
			}
			if (!this._activePaneManager.IsInNavigationMode && !e.IsRepeat)
			{
				switch ((e.Key == global::System.Windows.Input.Key.System) ? e.SystemKey : e.Key)
				{
				case global::System.Windows.Input.Key.LeftCtrl:
				case global::System.Windows.Input.Key.RightCtrl:
				case global::System.Windows.Input.Key.LeftAlt:
				case global::System.Windows.Input.Key.RightAlt:
					this.ActivePaneManager.IsInNavigationMode = true;
					break;
				}
			}
			global::Infragistics.Windows.DockManager.PaneNavigator.ProcessKeyDown(this, e);
			if (!e.Handled && this.Commands != null && this.Commands.ProcessKeyboardInput(e, this))
			{
				e.Handled = true;
			}
		}

		// Token: 0x060007CA RID: 1994 RVA: 0x00024908 File Offset: 0x00022B08
		internal void ProcessKeyUp(global::System.Windows.Input.KeyEventArgs e)
		{
			if (e.Handled)
			{
				return;
			}
			if (this._activePaneManager.IsInNavigationMode)
			{
				switch ((e.Key == global::System.Windows.Input.Key.System) ? e.SystemKey : e.Key)
				{
				case global::System.Windows.Input.Key.LeftCtrl:
				case global::System.Windows.Input.Key.RightCtrl:
				case global::System.Windows.Input.Key.LeftAlt:
				case global::System.Windows.Input.Key.RightAlt:
					this.ActivePaneManager.IsInNavigationMode = false;
					break;
				default:
					return;
				}
			}
		}

		// Token: 0x060007CB RID: 1995 RVA: 0x00024970 File Offset: 0x00022B70
		internal bool ProcessPaneHeaderDoubleClick(global::Infragistics.Windows.DockManager.ContentPane pane)
		{
			if (pane.IsProvidingFloatingWindowCaption)
			{
				global::Infragistics.Windows.DockManager.PaneToolWindow paneToolWindow = global::Infragistics.Windows.Controls.ToolWindow.GetToolWindow(pane) as global::Infragistics.Windows.DockManager.PaneToolWindow;
				if (paneToolWindow != null)
				{
					paneToolWindow.OnDoubleClickCaption(default(global::System.Windows.Point), global::System.Windows.Input.Mouse.PrimaryDevice);
					return true;
				}
			}
			global::Infragistics.Windows.DockManager.TabGroupPane tabGroupPane = global::Infragistics.Windows.DockManager.DockManagerUtilities.GetParentPane(pane) as global::Infragistics.Windows.DockManager.TabGroupPane;
			if (tabGroupPane == null || ((global::Infragistics.Windows.DockManager.IContentPaneContainer)tabGroupPane).GetVisiblePanes().Count < 2)
			{
				return pane.ExecuteCommand(global::Infragistics.Windows.DockManager.ContentPaneCommands.ToggleDockedState);
			}
			global::System.Collections.Generic.List<global::Infragistics.Windows.DockManager.ContentPane> allPanes = global::Infragistics.Windows.DockManager.DockManagerUtilities.GetAllPanes(tabGroupPane, global::Infragistics.Windows.DockManager.PaneFilterFlags.AllVisible);
			if (allPanes.Count == 1)
			{
				return allPanes[0].ExecuteCommand(global::Infragistics.Windows.DockManager.ContentPaneCommands.ToggleDockedState);
			}
			switch (pane.PaneLocation)
			{
			case global::Infragistics.Windows.DockManager.PaneLocation.DockedLeft:
			case global::Infragistics.Windows.DockManager.PaneLocation.DockedRight:
			case global::Infragistics.Windows.DockManager.PaneLocation.DockedTop:
			case global::Infragistics.Windows.DockManager.PaneLocation.DockedBottom:
			{
				foreach (global::Infragistics.Windows.DockManager.ContentPane contentPane in allPanes)
				{
					if (!contentPane.CanToggleDockedState)
					{
						return false;
					}
				}
				global::Infragistics.Windows.DockManager.ContentPane contentPane2 = (tabGroupPane.SelectedItem as global::Infragistics.Windows.DockManager.ContentPane) ?? global::Infragistics.Windows.DockManager.DockManagerUtilities.GetFirstLastPane(tabGroupPane, true);
				if (contentPane2 == null)
				{
					return false;
				}
				foreach (global::Infragistics.Windows.DockManager.ContentPane contentPane3 in allPanes)
				{
					global::Infragistics.Windows.Controls.Events.ExecutingCommandEventArgs executingCommandEventArgs = new global::Infragistics.Windows.Controls.Events.ExecutingCommandEventArgs(global::Infragistics.Windows.DockManager.ContentPaneCommands.ToggleDockedState);
					contentPane3.RaiseExecutingCommand(executingCommandEventArgs);
					if (executingCommandEventArgs.Cancel)
					{
						return false;
					}
				}
				global::Infragistics.Windows.DockManager.ContentPane activePane = this.ActivePane;
				global::System.Collections.Generic.IList<global::Infragistics.Windows.DockManager.IContentPaneContainer> paneContainers = global::Infragistics.Windows.DockManager.DockManagerUtilities.GetPaneContainers(allPanes);
				global::Infragistics.Windows.DockManager.SplitPane splitPane = global::Infragistics.Windows.DockManager.DockManagerUtilities.CreateSplitPane(this);
				using (global::Infragistics.Windows.DockManager.MovePaneHelper movePaneHelper = new global::Infragistics.Windows.DockManager.MovePaneHelper(this, splitPane, new global::Infragistics.Windows.DockManager.ContentPane[0]))
				{
					global::Infragistics.Windows.DockManager.XamDockManager.SetInitialLocation(splitPane, global::Infragistics.Windows.DockManager.InitialPaneLocation.DockableFloating);
					if (!contentPane2.LastFloatingWindowRect.IsEmpty)
					{
						global::Infragistics.Windows.DockManager.XamDockManager.SetFloatingLocation(splitPane, new global::System.Windows.Point?(contentPane2.LastFloatingWindowRect.Location));
						global::Infragistics.Windows.DockManager.XamDockManager.SetFloatingSize(splitPane, contentPane2.LastFloatingWindowRect.Size);
					}
					else
					{
						global::Infragistics.Windows.DockManager.XamDockManager.SetFloatingSize(splitPane, contentPane2.GetSizeForFloating());
					}
					this.Panes.Add(splitPane);
					global::Infragistics.Windows.DockManager.TabGroupPane tabGroupPane2 = global::Infragistics.Windows.DockManager.DockManagerUtilities.CreateTabGroup(this);
					splitPane.Panes.Add(tabGroupPane2);
					global::Infragistics.Windows.DockManager.DockManagerUtilities.Clone(tabGroupPane, global::Infragistics.Windows.DockManager.PaneLocation.Floating, tabGroupPane2, movePaneHelper);
				}
				global::Infragistics.Windows.DockManager.DockManagerUtilities.FixPlaceholders(allPanes);
				if (activePane != null)
				{
					activePane.ActivateInternal(true);
				}
				global::Infragistics.Windows.DockManager.DockManagerUtilities.RemoveContainersIfNeeded(paneContainers);
				foreach (global::Infragistics.Windows.DockManager.ContentPane contentPane4 in allPanes)
				{
					global::Infragistics.Windows.Controls.Events.ExecutedCommandEventArgs args = new global::Infragistics.Windows.Controls.Events.ExecutedCommandEventArgs(global::Infragistics.Windows.DockManager.ContentPaneCommands.ToggleDockedState);
					contentPane4.RaiseExecutedCommand(args);
				}
				return true;
			}
			case global::Infragistics.Windows.DockManager.PaneLocation.Floating:
				return this.ToggleDockedState(allPanes, true);
			}
			return false;
		}

		// Token: 0x060007CC RID: 1996 RVA: 0x00024C3C File Offset: 0x00022E3C
		internal void ProcessPinnedState(global::Infragistics.Windows.DockManager.ContentPane pane, global::Infragistics.Windows.DockManager.PaneLocation location, bool allowShowFlyout)
		{
			global::Infragistics.Windows.DockManager.IContentPaneContainer currentContainer = pane.PlacementInfo.CurrentContainer;
			if (currentContainer == null)
			{
				return;
			}
			switch (location)
			{
			case global::Infragistics.Windows.DockManager.PaneLocation.Unknown:
			case global::Infragistics.Windows.DockManager.PaneLocation.Floating:
			case global::Infragistics.Windows.DockManager.PaneLocation.FloatingOnly:
			case global::Infragistics.Windows.DockManager.PaneLocation.Document:
				break;
			case global::Infragistics.Windows.DockManager.PaneLocation.DockedLeft:
			case global::Infragistics.Windows.DockManager.PaneLocation.DockedRight:
			case global::Infragistics.Windows.DockManager.PaneLocation.DockedTop:
			case global::Infragistics.Windows.DockManager.PaneLocation.DockedBottom:
			{
				if (pane.IsPinned)
				{
					return;
				}
				bool flag = !this.IsLoadingLayout;
				bool flag2 = location == global::Infragistics.Windows.DockManager.PaneLocation.DockedLeft || location == global::Infragistics.Windows.DockManager.PaneLocation.DockedRight;
				if (flag)
				{
					global::Infragistics.Windows.DockManager.SplitPane rootSplitPane = global::Infragistics.Windows.DockManager.DockManagerUtilities.GetRootSplitPane(pane);
					double d = (rootSplitPane == null) ? double.NaN : (flag2 ? rootSplitPane.Width : rootSplitPane.Height);
					if (double.IsNaN(d))
					{
						flag = false;
					}
				}
				if (flag)
				{
					if (currentContainer.ContainerElement == null)
					{
						flag = false;
					}
					else if (!pane.IsMeasureValid)
					{
						global::Infragistics.Windows.DockManager.TabGroupPane tabGroupPane = currentContainer as global::Infragistics.Windows.DockManager.TabGroupPane;
						if (tabGroupPane == null || !tabGroupPane.IsMeasureValid)
						{
							this.DeferProcessPinnedState(pane, allowShowFlyout);
							return;
						}
					}
				}
				if (flag)
				{
					global::System.Windows.FrameworkElement frameworkElement = (currentContainer is global::Infragistics.Windows.DockManager.TabGroupPane) ? (currentContainer as global::System.Windows.FrameworkElement) : pane;
					double num = flag2 ? frameworkElement.ActualWidth : frameworkElement.ActualHeight;
					if (num > 0.0)
					{
						global::Infragistics.Windows.DockManager.IPaneContainer paneContainer = currentContainer.ContainerElement as global::Infragistics.Windows.DockManager.IPaneContainer;
						global::Infragistics.Windows.DockManager.IPaneContainer paneContainer2 = null;
						while (paneContainer != null && !(paneContainer is global::Infragistics.Windows.DockManager.XamDockManager))
						{
							paneContainer2 = paneContainer;
							paneContainer = global::Infragistics.Windows.DockManager.DockManagerUtilities.GetParentPane(paneContainer);
						}
						if (paneContainer2 is global::Infragistics.Windows.DockManager.SplitPane)
						{
							global::Infragistics.Windows.DockManager.PaneSplitter splitter = global::Infragistics.Windows.DockManager.PaneSplitter.GetSplitter(paneContainer2 as global::Infragistics.Windows.DockManager.SplitPane);
							if (splitter != null)
							{
								num += (flag2 ? splitter.ActualWidth : splitter.ActualHeight);
							}
						}
						global::Infragistics.Windows.DockManager.UnpinnedTabFlyout.SetFlyoutExtent(pane, num);
					}
				}
				global::System.Windows.Controls.Dock dockedSide = global::Infragistics.Windows.DockManager.DockManagerUtilities.GetDockedSide(location);
				using (global::Infragistics.Windows.DockManager.DockManagerUtilities.CreateMoveReplacement(pane))
				{
					currentContainer.RemoveContentPane(pane, true);
					global::Infragistics.Windows.DockManager.IContentPaneContainer contentPaneContainer = this._tabAreaInfos[(int)dockedSide];
					contentPaneContainer.InsertContentPane(null, pane);
				}
				if (allowShowFlyout && base.IsLoaded && !this.IsShowFlyoutSuspended && this.FlyoutAnimation != global::Infragistics.Windows.DockManager.PaneFlyoutAnimation.None)
				{
					this.ShowAndHideFlyout(pane);
				}
				break;
			}
			case global::Infragistics.Windows.DockManager.PaneLocation.Unpinned:
				if (!pane.IsPinned)
				{
					return;
				}
				this.MovePaneToPinnedContainer(pane, false);
				return;
			default:
				return;
			}
		}

		// Token: 0x060007CD RID: 1997 RVA: 0x00024E3C File Offset: 0x0002303C
		internal void RemoveLogicalChildInternal(global::System.Windows.DependencyObject logicalChild)
		{
			if (this._logicalChildren != null)
			{
				this._logicalChildren.Remove(logicalChild);
				base.RemoveLogicalChild(logicalChild);
			}
		}

		// Token: 0x060007CE RID: 1998 RVA: 0x00024E5A File Offset: 0x0002305A
		private void ShowAndHideFlyout(global::Infragistics.Windows.DockManager.ContentPane contentPane)
		{
			if (this._dockPanel != null && contentPane != null)
			{
				this._dockPanel.FlyoutPanel.ShowAndHideFlyout(contentPane);
			}
		}

		// Token: 0x060007CF RID: 1999 RVA: 0x00024E78 File Offset: 0x00023078
		internal void ShowFlyout(global::Infragistics.Windows.DockManager.ContentPane contentPane, bool delay, bool basedOnMouseOver)
		{
			if (this._dockPanel != null && contentPane != null)
			{
				this._dockPanel.FlyoutPanel.ShowFlyout(contentPane, delay, basedOnMouseOver, true);
			}
		}

		// Token: 0x060007D0 RID: 2000 RVA: 0x00024E9C File Offset: 0x0002309C
		internal bool ToggleDockedState(global::Infragistics.Windows.DockManager.ContentPane pane)
		{
			return this.ToggleDockedState(new global::System.Collections.Generic.List<global::Infragistics.Windows.DockManager.ContentPane>
			{
				pane
			}, false);
		}

		// Token: 0x060007D1 RID: 2001 RVA: 0x00024EC0 File Offset: 0x000230C0
		private bool ToggleDockedStateImpl(global::Infragistics.Windows.DockManager.ContentPane pane)
		{
			if (!pane.CanToggleDockedState)
			{
				return false;
			}
			global::Infragistics.Windows.DockManager.ContentPane.PanePlacementInfo placementInfo = pane.PlacementInfo;
			global::Infragistics.Windows.DockManager.IContentPaneContainer currentContainer = placementInfo.CurrentContainer;
			global::Infragistics.Windows.DockManager.SplitPane splitPane = null;
			global::Infragistics.Windows.DockManager.IContentPaneContainer contentPaneContainer;
			if (global::Infragistics.Windows.DockManager.DockManagerUtilities.IsDocked(currentContainer.PaneLocation))
			{
				global::Infragistics.Windows.DockManager.ContentPanePlaceholder floatingDockablePlaceholder = placementInfo.FloatingDockablePlaceholder;
				if (floatingDockablePlaceholder != null)
				{
					contentPaneContainer = floatingDockablePlaceholder.Container;
				}
				else
				{
					splitPane = global::Infragistics.Windows.DockManager.DockManagerUtilities.CreateSplitPane(this);
					global::Infragistics.Windows.DockManager.XamDockManager.SetInitialLocation(splitPane, global::Infragistics.Windows.DockManager.InitialPaneLocation.DockableFloating);
					global::Infragistics.Windows.DockManager.XamDockManager.SetFloatingSize(splitPane, pane.GetSizeForFloating());
					if (pane.LastFloatingLocation != null)
					{
						global::Infragistics.Windows.DockManager.XamDockManager.SetFloatingLocation(splitPane, pane.LastFloatingLocation);
					}
					contentPaneContainer = splitPane;
				}
			}
			else
			{
				contentPaneContainer = placementInfo.DockedContainer;
			}
			if (contentPaneContainer == null)
			{
				return false;
			}
			using (global::Infragistics.Windows.DockManager.MovePaneHelper movePaneHelper = new global::Infragistics.Windows.DockManager.MovePaneHelper(this, contentPaneContainer, new global::Infragistics.Windows.DockManager.ContentPane[]
			{
				pane
			}))
			{
				if (splitPane != null)
				{
					this.Panes.Add(splitPane);
				}
				global::Infragistics.Windows.DockManager.DockManagerUtilities.MovePane(pane, contentPaneContainer, null, contentPaneContainer.PaneLocation, movePaneHelper);
			}
			return true;
		}

		// Token: 0x060007D2 RID: 2002 RVA: 0x00024FB4 File Offset: 0x000231B4
		internal bool ToggleDockedState(global::System.Collections.Generic.List<global::Infragistics.Windows.DockManager.ContentPane> panes, bool raiseEvents)
		{
			global::Infragistics.Windows.DockManager.ContentPane activePane = this.ActivePane;
			bool flag = false;
			for (int i = panes.Count - 1; i >= 0; i--)
			{
				global::Infragistics.Windows.DockManager.ContentPane contentPane = panes[i];
				if (!contentPane.CanToggleDockedState)
				{
					panes.RemoveAt(i);
				}
			}
			if (raiseEvents)
			{
				for (int j = panes.Count - 1; j >= 0; j--)
				{
					global::Infragistics.Windows.DockManager.ContentPane contentPane2 = panes[j];
					global::Infragistics.Windows.Controls.Events.ExecutingCommandEventArgs executingCommandEventArgs = new global::Infragistics.Windows.Controls.Events.ExecutingCommandEventArgs(global::Infragistics.Windows.DockManager.ContentPaneCommands.ToggleDockedState);
					contentPane2.RaiseExecutingCommand(executingCommandEventArgs);
					if (executingCommandEventArgs.Cancel)
					{
						panes.RemoveAt(j);
					}
				}
			}
			if (panes.Count == 0)
			{
				return false;
			}
			global::System.Collections.Generic.IList<global::Infragistics.Windows.DockManager.IContentPaneContainer> paneContainers = global::Infragistics.Windows.DockManager.DockManagerUtilities.GetPaneContainers(panes);
			foreach (global::Infragistics.Windows.DockManager.ContentPane pane in panes)
			{
				if (this.ToggleDockedStateImpl(pane))
				{
					flag = true;
				}
			}
			global::Infragistics.Windows.DockManager.DockManagerUtilities.RemoveContainersIfNeeded(paneContainers);
			if (flag && activePane != null && activePane.CanActivate)
			{
				activePane.ActivateInternal(true, true, panes.Contains(activePane));
			}
			if (raiseEvents)
			{
				foreach (global::Infragistics.Windows.DockManager.ContentPane contentPane3 in panes)
				{
					global::Infragistics.Windows.Controls.Events.ExecutedCommandEventArgs args = new global::Infragistics.Windows.Controls.Events.ExecutedCommandEventArgs(global::Infragistics.Windows.DockManager.ContentPaneCommands.ToggleDockedState);
					contentPane3.RaiseExecutedCommand(args);
				}
			}
			return flag;
		}

		// Token: 0x060007D3 RID: 2003 RVA: 0x00025110 File Offset: 0x00023310
		internal void TransferFocusOutOfHwndHost()
		{
			foreach (global::Infragistics.Windows.DockManager.HwndHostInfo hwndHostInfo in this.GetHwndHostInfos())
			{
				global::System.Windows.DependencyObject dependencyObject = hwndHostInfo.GetFocusedHwndHost();
				if (dependencyObject != null)
				{
					while (dependencyObject != null)
					{
						global::System.Windows.IInputElement inputElement = dependencyObject as global::System.Windows.IInputElement;
						if (inputElement != null && !(dependencyObject is global::System.Windows.Interop.HwndHost) && inputElement.Focusable && inputElement.IsEnabled && true.Equals(dependencyObject.GetValue(global::System.Windows.UIElement.IsVisibleProperty)))
						{
							global::Infragistics.Windows.DockManager.XamDockManager dockManager = global::Infragistics.Windows.DockManager.XamDockManager.GetDockManager(dependencyObject);
							if (dockManager != null)
							{
								dockManager.ForceFocus(inputElement);
								break;
							}
						}
						dependencyObject = global::Infragistics.Windows.Utilities.GetParent(dependencyObject, true);
					}
					break;
				}
			}
		}

		// Token: 0x060007D4 RID: 2004 RVA: 0x000251C0 File Offset: 0x000233C0
		internal void UnpinPane(global::Infragistics.Windows.DockManager.ContentPane pane, bool includeSiblingsIfAllowed)
		{
			global::System.Collections.Generic.IList<global::Infragistics.Windows.DockManager.ContentPane> panesToProcess = this.GetPanesToProcess(pane, includeSiblingsIfAllowed, this.PinBehavior);
			int i = 0;
			int count = panesToProcess.Count;
			while (i < count)
			{
				global::Infragistics.Windows.DockManager.ContentPane contentPane = panesToProcess[i];
				if (contentPane.AllowPinning)
				{
					panesToProcess[i].IsPinned = !panesToProcess[i].IsPinned;
				}
				i++;
			}
		}

		// Token: 0x060007D5 RID: 2005 RVA: 0x0002521C File Offset: 0x0002341C
		internal void VerifyFillPane()
		{
			global::Infragistics.Windows.DockManager.SplitPane fillPane = this.FillPane;
			global::Infragistics.Windows.DockManager.SplitPane splitPane = null;
			if (this.LayoutMode == global::Infragistics.Windows.DockManager.DockedPaneLayoutMode.FillContainer)
			{
				for (int i = this.Panes.Count - 1; i >= 0; i--)
				{
					global::Infragistics.Windows.DockManager.SplitPane splitPane2 = this._panes[i];
					if (splitPane2.Visibility != global::System.Windows.Visibility.Collapsed && global::Infragistics.Windows.DockManager.DockManagerUtilities.IsDocked(splitPane2))
					{
						splitPane = splitPane2;
						break;
					}
				}
			}
			if (fillPane == null)
			{
				this._fillPane = null;
			}
			if (splitPane != fillPane)
			{
				if (fillPane != null)
				{
					fillPane.ClearValue(global::Infragistics.Windows.DockManager.SplitPane.IsFillPanePropertyKey);
				}
				if (splitPane == null)
				{
					this._fillPane = null;
					return;
				}
				this._fillPane = new global::System.WeakReference(splitPane);
				splitPane.SetValue(global::Infragistics.Windows.DockManager.SplitPane.IsFillPanePropertyKey, global::Infragistics.KnownBoxes.TrueBox);
			}
		}

		// Token: 0x060007D6 RID: 2006 RVA: 0x000252B8 File Offset: 0x000234B8
		protected internal virtual global::Infragistics.Windows.DockManager.PaneToolWindow CreatePaneToolWindow()
		{
			return new global::Infragistics.Windows.DockManager.PaneToolWindow();
		}

		// Token: 0x060007D7 RID: 2007 RVA: 0x000252CC File Offset: 0x000234CC
		protected internal virtual global::Infragistics.Windows.DockManager.SplitPane CreateSplitPane()
		{
			return new global::Infragistics.Windows.DockManager.SplitPane
			{
				Name = global::Infragistics.Windows.DockManager.DockManagerUtilities.AutoGeneratedName()
			};
		}

		// Token: 0x060007D8 RID: 2008 RVA: 0x000252EC File Offset: 0x000234EC
		protected internal virtual global::Infragistics.Windows.DockManager.TabGroupPane CreateTabGroupPane()
		{
			return new global::Infragistics.Windows.DockManager.TabGroupPane
			{
				Name = global::Infragistics.Windows.DockManager.DockManagerUtilities.AutoGeneratedName()
			};
		}

		// Token: 0x060007D9 RID: 2009 RVA: 0x0002530C File Offset: 0x0002350C
		private void DeferProcessPinnedState(global::Infragistics.Windows.DockManager.ContentPane pane, bool allowShowFlyout)
		{
			if (this._deferredPinnedPanes == null)
			{
				this._deferredPinnedPanes = new global::System.Collections.Generic.Dictionary<global::Infragistics.Windows.DockManager.ContentPane, bool>();
				global::System.EventHandler value = new global::System.EventHandler(this.OnLayoutUpdated);
				base.LayoutUpdated -= value;
				base.LayoutUpdated += value;
			}
			this._deferredPinnedPanes[pane] = allowShowFlyout;
		}

		// Token: 0x060007DA RID: 2010 RVA: 0x00025354 File Offset: 0x00023554
		private void DestroyPaneElement(global::Infragistics.Windows.DockManager.IContentPaneContainer container, global::Infragistics.Windows.DockManager.ContentPane pane)
		{
			if (container != null)
			{
				container.RemoveContentPane(pane, false);
				global::Infragistics.Windows.DockManager.DockManagerUtilities.RemoveContainerIfNeeded(container);
			}
		}

		// Token: 0x060007DB RID: 2011 RVA: 0x00025368 File Offset: 0x00023568
		private bool ExecuteCommandImpl(global::Infragistics.Windows.Commands.ExecuteCommandInfo commandInfo)
		{
			global::System.Windows.Input.RoutedCommand routedCommand = commandInfo.RoutedCommand;
			global::Infragistics.Windows.DockManager.DockManagerUtilities.ThrowIfNull(routedCommand, "command");
			if (!global::Infragistics.Windows.Commands.Commands<global::Infragistics.Windows.DockManager.XamDockManager>.IsMinimumStatePresentForCommand(this, routedCommand))
			{
				return false;
			}
			if (!((global::Infragistics.Windows.Commands.ICommandHost)this).CanExecute(commandInfo))
			{
				return false;
			}
			global::Infragistics.Windows.Controls.Events.ExecutingCommandEventArgs executingCommandEventArgs = new global::Infragistics.Windows.Controls.Events.ExecutingCommandEventArgs(routedCommand);
			if (!this.RaiseExecutingCommand(executingCommandEventArgs))
			{
				return !executingCommandEventArgs.ContinueKeyRouting;
			}
			global::System.Windows.Input.ModifierKeys modifiers = global::System.Windows.Input.Keyboard.Modifiers;
			global::System.Windows.Input.ModifierKeys modifiers2 = global::System.Windows.Input.Keyboard.Modifiers;
			global::System.Windows.Input.Keyboard.IsKeyDown(global::System.Windows.Input.Key.Tab);
			bool flag = false;
			global::Infragistics.Windows.DockManager.ContentPane paneForCommand = this.GetPaneForCommand(commandInfo);
			if (routedCommand == global::Infragistics.Windows.DockManager.DockManagerCommands.ActivateNextPane || routedCommand == global::Infragistics.Windows.DockManager.DockManagerCommands.ActivatePreviousPane)
			{
				flag = this._activePaneManager.ActivateNextPane(paneForCommand, routedCommand == global::Infragistics.Windows.DockManager.DockManagerCommands.ActivateNextPane);
			}
			else if (routedCommand == global::Infragistics.Windows.DockManager.DockManagerCommands.ActivateNextDocument || routedCommand == global::Infragistics.Windows.DockManager.DockManagerCommands.ActivatePreviousDocument)
			{
				flag = this._activePaneManager.ActivateNextDocument(paneForCommand, routedCommand == global::Infragistics.Windows.DockManager.DockManagerCommands.ActivateNextDocument);
			}
			else if (routedCommand == global::Infragistics.Windows.DockManager.DockManagerCommands.CloseActiveDocument)
			{
				global::Infragistics.Windows.DockManager.ContentPane activeDocument = this.ActivePaneManager.GetActiveDocument();
				if (activeDocument != null && activeDocument.AllowClose)
				{
					this.ClosePane(activeDocument, false);
				}
			}
			else if (routedCommand == global::Infragistics.Windows.DockManager.DockManagerCommands.ShowPaneNavigator)
			{
				global::Infragistics.Windows.DockManager.PaneNavigatorStartInfo startInfo = (commandInfo.Parameter as global::Infragistics.Windows.DockManager.PaneNavigatorStartInfo) ?? new global::Infragistics.Windows.DockManager.PaneNavigatorStartInfo();
				flag = global::Infragistics.Windows.DockManager.PaneNavigator.Show(this, startInfo);
			}
			if (flag)
			{
				this.RaiseExecutedCommand(new global::Infragistics.Windows.Controls.Events.ExecutedCommandEventArgs(routedCommand));
			}
			return flag;
		}

		// Token: 0x060007DC RID: 2012 RVA: 0x000256F0 File Offset: 0x000238F0
		private global::System.Collections.Generic.IEnumerable<global::Infragistics.Windows.DockManager.HwndHostInfo> GetHwndHostInfos()
		{
			if (this._dockPanel != null)
			{
				global::Infragistics.Windows.DockManager.HwndHostInfo hhi = global::Infragistics.Windows.DockManager.HwndHostInfo.GetHwndHost(this._dockPanel);
				if (hhi != null)
				{
					yield return hhi;
				}
			}
			if (base.Content is global::System.Windows.FrameworkElement)
			{
				global::Infragistics.Windows.DockManager.HwndHostInfo hhi2 = global::Infragistics.Windows.DockManager.HwndHostInfo.GetHwndHost((global::System.Windows.DependencyObject)base.Content);
				if (hhi2 != null)
				{
					yield return hhi2;
				}
			}
			foreach (global::Infragistics.Windows.DockManager.ContentPane cp in this.GetPanes(global::Infragistics.Windows.DockManager.PaneNavigationOrder.ActivationOrder))
			{
				global::Infragistics.Windows.DockManager.HwndHostInfo hhi3 = global::Infragistics.Windows.DockManager.HwndHostInfo.GetHwndHost(cp);
				if (hhi3 != null)
				{
					yield return hhi3;
				}
			}
			yield break;
		}

		// Token: 0x060007DD RID: 2013 RVA: 0x0002570D File Offset: 0x0002390D
		private global::Infragistics.Windows.DockManager.ContentPane GetPaneForCommand(global::Infragistics.Windows.Commands.ExecuteCommandInfo commandInfo)
		{
			return global::Infragistics.Windows.DockManager.XamDockManager.GetPaneForCommand(commandInfo.Parameter, commandInfo.OriginalSource, this.ActivePane);
		}

		// Token: 0x060007DE RID: 2014 RVA: 0x00025728 File Offset: 0x00023928
		private global::System.Collections.Generic.IList<global::Infragistics.Windows.DockManager.ContentPane> GetPanesToProcess(global::Infragistics.Windows.DockManager.ContentPane pane, bool includeSiblingsIfAllowed, global::Infragistics.Windows.DockManager.PaneActionBehavior behavior)
		{
			global::Infragistics.Windows.DockManager.IContentPaneContainer currentContainer = pane.PlacementInfo.CurrentContainer;
			if (pane.PaneLocation == global::Infragistics.Windows.DockManager.PaneLocation.Unpinned && !(pane.PlacementInfo.DockedContainer is global::Infragistics.Windows.DockManager.TabGroupPane))
			{
				includeSiblingsIfAllowed = false;
			}
			global::System.Collections.Generic.IList<global::Infragistics.Windows.DockManager.ContentPane> result;
			if (currentContainer != null && includeSiblingsIfAllowed && behavior == global::Infragistics.Windows.DockManager.PaneActionBehavior.AllPanes)
			{
				result = currentContainer.GetAllPanesForPaneAction(pane);
			}
			else
			{
				result = new global::Infragistics.Windows.DockManager.ContentPane[]
				{
					pane
				};
			}
			return result;
		}

		// Token: 0x060007DF RID: 2015 RVA: 0x00025784 File Offset: 0x00023984
		private global::System.Windows.IInputElement GetTransferCommandTarget()
		{
			global::Infragistics.Windows.DockManager.ContentPane contentPane = this.ActivePane;
			global::System.Windows.DependencyObject focusScope = global::System.Windows.Input.FocusManager.GetFocusScope(this);
			if (contentPane == null && !base.IsKeyboardFocusWithin && focusScope != null && global::System.Windows.Input.FocusManager.GetFocusedElement(focusScope) == this)
			{
				contentPane = this.ActivePaneManager.GetLastActivePane();
			}
			global::System.Windows.DependencyObject dependencyObject = (contentPane != null) ? global::System.Windows.Input.FocusManager.GetFocusScope(contentPane) : null;
			if (contentPane == null || global::System.ComponentModel.DesignerProperties.GetIsInDesignMode(this) || focusScope == dependencyObject || !global::Infragistics.Windows.Utilities.IsDescendantOf(this, contentPane, true))
			{
				return null;
			}
			global::System.Windows.IInputElement focusedElement = global::System.Windows.Input.FocusManager.GetFocusedElement(dependencyObject);
			global::System.Windows.DependencyObject dependencyObject2 = focusedElement as global::System.Windows.DependencyObject;
			global::Infragistics.Windows.DockManager.XamDockManager xamDockManager = dependencyObject2 as global::Infragistics.Windows.DockManager.XamDockManager;
			if (xamDockManager == null && dependencyObject2 != null)
			{
				global::Infragistics.Windows.DockManager.XamDockManager dockManager = global::Infragistics.Windows.DockManager.XamDockManager.GetDockManager(dependencyObject2);
				if (dockManager != null && dockManager._dragHelper == dependencyObject2)
				{
					xamDockManager = dockManager;
				}
			}
			if (xamDockManager != null && xamDockManager != this)
			{
				return xamDockManager.GetTransferCommandTarget();
			}
			return focusedElement;
		}

		// Token: 0x060007E0 RID: 2016 RVA: 0x00025838 File Offset: 0x00023A38
		private void OnDockPanelLoaded(object sender, global::System.Windows.RoutedEventArgs e)
		{
			if (this._dockPanel != null)
			{
				this._dockPanel.Panes.ReInitialize(this._panes.DockedPanes);
			}
		}

		// Token: 0x060007E1 RID: 2017 RVA: 0x00025860 File Offset: 0x00023A60
		private void OnDockManagerLoaded(object sender, global::System.Windows.RoutedEventArgs e)
		{
			if (!base.IsVisible)
			{
				this.VerifyFloatingWindowVisibility();
				return;
			}
			base.Unloaded += this.OnDockManagerUnloaded;
			base.Loaded -= this.OnDockManagerLoaded;
			this.VerifyFloatingWindowVisibility();
			this.ProcessDeferredUnpinnedPanes();
			if (this.ShowToolWindowsInPopup)
			{
				base.Dispatcher.BeginInvoke(global::System.Windows.Threading.DispatcherPriority.Input, new global::Infragistics.Windows.DockManager.DockManagerUtilities.MethodInvoker(this.BringToolWindowsToFront));
			}
		}

		// Token: 0x060007E2 RID: 2018 RVA: 0x000258CD File Offset: 0x00023ACD
		private void OnDockManagerUnloaded(object sender, global::System.Windows.RoutedEventArgs e)
		{
			base.Unloaded -= this.OnDockManagerUnloaded;
			base.Loaded += this.OnDockManagerLoaded;
			this.VerifyFloatingWindowVisibility();
		}

		// Token: 0x060007E3 RID: 2019 RVA: 0x000258F9 File Offset: 0x00023AF9
		private void OnLayoutUpdated(object sender, global::System.EventArgs e)
		{
			base.LayoutUpdated -= this.OnLayoutUpdated;
			base.Dispatcher.BeginInvoke(global::System.Windows.Threading.DispatcherPriority.Normal, new global::Infragistics.Windows.DockManager.DockManagerUtilities.MethodInvoker(this.ProcessDeferredUnpinnedPanes));
		}

		// Token: 0x060007E4 RID: 2020 RVA: 0x00025928 File Offset: 0x00023B28
		private static void OnTransferBindingExecute(object sender, global::System.Windows.Input.ExecutedRoutedEventArgs e)
		{
			global::Infragistics.Windows.DockManager.XamDockManager xamDockManager = (global::Infragistics.Windows.DockManager.XamDockManager)sender;
			if (!xamDockManager.ShouldTransferCommands())
			{
				return;
			}
			xamDockManager.TransferExecute(e.Command as global::System.Windows.Input.RoutedCommand, e);
		}

		// Token: 0x060007E5 RID: 2021 RVA: 0x00025958 File Offset: 0x00023B58
		private static void OnTransferBindingCanExecute(object sender, global::System.Windows.Input.CanExecuteRoutedEventArgs e)
		{
			global::Infragistics.Windows.DockManager.XamDockManager xamDockManager = (global::Infragistics.Windows.DockManager.XamDockManager)sender;
			if (!xamDockManager.ShouldTransferCommands())
			{
				e.ContinueRouting = true;
				return;
			}
			bool flag = xamDockManager._transferCanExecuteCommand != e.Command && !e.Handled && !e.ContinueRouting;
			if (flag)
			{
				e.ContinueRouting = true;
			}
			xamDockManager.TransferCanExecute(e.Command as global::System.Windows.Input.RoutedCommand, e);
			if (flag && e.Handled)
			{
				e.ContinueRouting = false;
			}
		}

		// Token: 0x060007E6 RID: 2022 RVA: 0x000259D0 File Offset: 0x00023BD0
		private static void OnTransferCanExecuteCommand(object sender, global::System.Windows.Input.CanExecuteRoutedEventArgs e)
		{
			global::Infragistics.Windows.DockManager.XamDockManager xamDockManager = (global::Infragistics.Windows.DockManager.XamDockManager)sender;
			global::System.Windows.Input.RoutedCommand routedCommand = e.Command as global::System.Windows.Input.RoutedCommand;
			if (routedCommand != null && routedCommand.GetType() != global::Infragistics.Windows.DockManager.XamDockManager._secureCommandType)
			{
				if (!xamDockManager.ShouldTransferCommands())
				{
					return;
				}
				xamDockManager.TransferCanExecute(routedCommand, e);
			}
		}

		// Token: 0x060007E7 RID: 2023 RVA: 0x00025A18 File Offset: 0x00023C18
		private static void OnTransferExecuteCommand(object sender, global::System.Windows.Input.ExecutedRoutedEventArgs e)
		{
			global::Infragistics.Windows.DockManager.XamDockManager xamDockManager = (global::Infragistics.Windows.DockManager.XamDockManager)sender;
			global::System.Windows.Input.RoutedCommand routedCommand = e.Command as global::System.Windows.Input.RoutedCommand;
			if (!xamDockManager.ShouldTransferCommands())
			{
				return;
			}
			if (routedCommand != null && routedCommand.GetType() != global::Infragistics.Windows.DockManager.XamDockManager._secureCommandType)
			{
				xamDockManager.TransferExecute(routedCommand, e);
			}
		}

		// Token: 0x060007E8 RID: 2024 RVA: 0x00025A60 File Offset: 0x00023C60
		private void ProcessDeferredUnpinnedPanes()
		{
			global::System.Collections.Generic.Dictionary<global::Infragistics.Windows.DockManager.ContentPane, bool> deferredPinnedPanes = this._deferredPinnedPanes;
			this._deferredPinnedPanes = null;
			if (deferredPinnedPanes != null)
			{
				foreach (global::System.Collections.Generic.KeyValuePair<global::Infragistics.Windows.DockManager.ContentPane, bool> keyValuePair in deferredPinnedPanes)
				{
					if (global::Infragistics.Windows.DockManager.XamDockManager.GetDockManager(keyValuePair.Key) == this)
					{
						this.ProcessPinnedState(keyValuePair.Key, keyValuePair.Key.PaneLocation, keyValuePair.Value);
					}
				}
			}
		}

		// Token: 0x060007E9 RID: 2025 RVA: 0x00025AE8 File Offset: 0x00023CE8
		internal void ResumeShowFlyout()
		{
			this._suspendShowFlyoutCount--;
		}

		// Token: 0x060007EA RID: 2026 RVA: 0x00025AF8 File Offset: 0x00023CF8
		private void SetIsWindowLoaded(bool loaded)
		{
			global::Infragistics.Windows.DockManager.PaneToolWindow[] array = new global::Infragistics.Windows.DockManager.PaneToolWindow[this._toolWindows.Count];
			this._toolWindows.CopyTo(array, 0);
			foreach (global::Infragistics.Windows.DockManager.PaneToolWindow window in array)
			{
				this.SetIsWindowLoaded(window, loaded);
			}
		}

		// Token: 0x060007EB RID: 2027 RVA: 0x00025B40 File Offset: 0x00023D40
		private void SetIsWindowLoaded(global::Infragistics.Windows.DockManager.PaneToolWindow window, bool loaded)
		{
			if (loaded && !window.IsWindowLoaded && this.FloatingWindowVisibility == global::Infragistics.Windows.DockManager.FloatingWindowVisibility.SyncWithDockManagerWindow && this.UseOwnedFloatingWindows && this._hwndSourceHelper != null && this._hwndSourceHelper.RootVisualWindowState == global::System.Windows.WindowState.Minimized)
			{
				loaded = false;
			}
			window.IsWindowLoaded = loaded;
		}

		// Token: 0x060007EC RID: 2028 RVA: 0x00025BA0 File Offset: 0x00023DA0
		private bool ShouldTransferCommands()
		{
			global::Infragistics.Windows.DockManager.ContentPane contentPane = global::System.Windows.Input.FocusManager.GetFocusScope(this) as global::Infragistics.Windows.DockManager.ContentPane;
			global::Infragistics.Windows.DockManager.XamDockManager xamDockManager = null;
			if (contentPane != null)
			{
				xamDockManager = global::Infragistics.Windows.DockManager.XamDockManager.GetDockManager(contentPane);
			}
			else
			{
				global::System.Windows.DependencyObject parent = global::System.Windows.Media.VisualTreeHelper.GetParent(this);
				if (parent != null)
				{
					xamDockManager = global::Infragistics.Windows.DockManager.XamDockManager.GetDockManager(parent);
				}
			}
			return xamDockManager == null;
		}

		// Token: 0x060007ED RID: 2029 RVA: 0x00025BDE File Offset: 0x00023DDE
		internal void SuspendShowFlyout()
		{
			this._suspendShowFlyoutCount++;
		}

		// Token: 0x060007EE RID: 2030 RVA: 0x00025BEE File Offset: 0x00023DEE
		private void OnFloatingPaneAdded(global::Infragistics.Windows.DockManager.SplitPane pane)
		{
			this.OnFloatingPaneAdded(pane, global::System.ComponentModel.DesignerProperties.GetIsInDesignMode(pane));
		}

		// Token: 0x060007EF RID: 2031 RVA: 0x00025C00 File Offset: 0x00023E00
		private void OnFloatingPaneAdded(global::Infragistics.Windows.DockManager.SplitPane pane, bool isDesignMode)
		{
			global::Infragistics.Windows.DockManager.PaneLocation value = global::Infragistics.Windows.DockManager.DockManagerUtilities.ToPaneLocation(global::Infragistics.Windows.DockManager.XamDockManager.GetInitialLocation(pane));
			if (isDesignMode)
			{
				pane.SetValue(global::Infragistics.Windows.DockManager.XamDockManager.PaneLocationPropertyKey, global::Infragistics.Windows.DockManager.DockManagerKnownBoxes.FromValue(value));
				this.AddLogicalChildInternal(pane);
				return;
			}
			global::Infragistics.Windows.DockManager.PaneToolWindow paneToolWindow = this.CreatePaneToolWindow();
			paneToolWindow.SetValue(global::Infragistics.Windows.DockManager.XamDockManager.DockManagerPropertyKey, this);
			paneToolWindow.SetValue(global::Infragistics.Windows.DockManager.XamDockManager.PaneLocationPropertyKey, global::Infragistics.Windows.DockManager.DockManagerKnownBoxes.FromValue(value));
			paneToolWindow.SetBinding(global::System.Windows.FrameworkElement.DataContextProperty, global::Infragistics.Windows.Utilities.CreateBindingObject(global::System.Windows.FrameworkElement.DataContextProperty, global::System.Windows.Data.BindingMode.OneWay, this));
			paneToolWindow.SetBinding(global::System.Windows.FrameworkElement.FlowDirectionProperty, global::Infragistics.Windows.Utilities.CreateBindingObject(global::System.Windows.FrameworkElement.FlowDirectionProperty, global::System.Windows.Data.BindingMode.OneWay, this));
			paneToolWindow.SetBinding(global::Infragistics.Windows.Controls.ToolWindow.AllowMaximizeProperty, global::Infragistics.Windows.Utilities.CreateBindingObject(global::Infragistics.Windows.DockManager.XamDockManager.AllowMaximizeFloatingWindowsProperty, global::System.Windows.Data.BindingMode.OneWay, this));
			paneToolWindow.SetBinding(global::Infragistics.Windows.Controls.ToolWindow.AllowMinimizeProperty, global::Infragistics.Windows.Utilities.CreateBindingObject(global::Infragistics.Windows.DockManager.XamDockManager.AllowMinimizeFloatingWindowsProperty, global::System.Windows.Data.BindingMode.OneWay, this));
			paneToolWindow.SetBinding(global::Infragistics.Windows.Controls.ToolWindow.ShowInTaskbarProperty, global::Infragistics.Windows.Utilities.CreateBindingObject(global::Infragistics.Windows.DockManager.XamDockManager.ShowFloatingWindowsInTaskbarProperty, global::System.Windows.Data.BindingMode.OneWay, this));
			paneToolWindow.SetBinding(global::Infragistics.Windows.Controls.ToolWindow.IsOwnedWindowProperty, global::Infragistics.Windows.Utilities.CreateBindingObject(global::Infragistics.Windows.DockManager.XamDockManager.UseOwnedFloatingWindowsProperty, global::System.Windows.Data.BindingMode.OneWay, this));
			paneToolWindow.SetBinding(global::Infragistics.Windows.DockManager.PaneToolWindow.FloatingWindowCaptionSourceProperty, global::Infragistics.Windows.Utilities.CreateBindingObject(global::Infragistics.Windows.DockManager.XamDockManager.FloatingWindowCaptionSourceProperty, global::System.Windows.Data.BindingMode.OneWay, this));
			paneToolWindow.Content = pane;
			this._toolWindows.Add(paneToolWindow);
			if (this.AllowToolWindowLoaded)
			{
				this.SetIsWindowLoaded(paneToolWindow, true);
			}
		}

		// Token: 0x060007F0 RID: 2032 RVA: 0x00025D24 File Offset: 0x00023F24
		private void OnFloatingPaneRemoved(global::Infragistics.Windows.DockManager.SplitPane pane)
		{
			this.OnFloatingPaneRemoved(pane, global::System.ComponentModel.DesignerProperties.GetIsInDesignMode(pane));
		}

		// Token: 0x060007F1 RID: 2033 RVA: 0x00025D34 File Offset: 0x00023F34
		private void OnFloatingPaneRemoved(global::Infragistics.Windows.DockManager.SplitPane pane, bool isDesignMode)
		{
			if (isDesignMode)
			{
				this.RemoveLogicalChildInternal(pane);
				pane.ClearValue(global::Infragistics.Windows.DockManager.XamDockManager.PaneLocationPropertyKey);
				return;
			}
			pane.ClearValue(global::Infragistics.Windows.DockManager.XamDockManager.PaneLocationPropertyKey);
			global::Infragistics.Windows.DockManager.PaneToolWindow paneToolWindow = global::Infragistics.Windows.Controls.ToolWindow.GetToolWindow(pane) as global::Infragistics.Windows.DockManager.PaneToolWindow;
			if (paneToolWindow != null)
			{
				this._toolWindows.Remove(paneToolWindow);
			}
			paneToolWindow.IsWindowLoaded = false;
			paneToolWindow.ClearValue(global::Infragistics.Windows.DockManager.XamDockManager.DockManagerPropertyKey);
			paneToolWindow.ClearValue(global::Infragistics.Windows.DockManager.XamDockManager.PaneLocationPropertyKey);
			paneToolWindow.Content = null;
			if (!paneToolWindow.IsClosing)
			{
				paneToolWindow.Close();
			}
		}

		// Token: 0x060007F2 RID: 2034 RVA: 0x00025DB0 File Offset: 0x00023FB0
		private void OnRootVisualVisibilityChanged()
		{
			base.Dispatcher.BeginInvoke(global::System.Windows.Threading.DispatcherPriority.Input, new global::Infragistics.Windows.DockManager.DockManagerUtilities.MethodInvoker(this.VerifyFloatingWindowVisibility));
		}

		// Token: 0x060007F3 RID: 2035 RVA: 0x00025DCC File Offset: 0x00023FCC
		private void TransferExecute(global::System.Windows.Input.RoutedCommand rc, global::System.Windows.Input.ExecutedRoutedEventArgs e)
		{
			if (rc != null && rc != this._transferExecuteCommand)
			{
				global::System.Windows.Input.RoutedCommand transferExecuteCommand = this._transferExecuteCommand;
				this._transferExecuteCommand = rc;
				try
				{
					global::System.Windows.IInputElement transferCommandTarget = this.GetTransferCommandTarget();
					if (transferCommandTarget != null && rc.CanExecute(e.Parameter, transferCommandTarget))
					{
						try
						{
							rc.Execute(e.Parameter, transferCommandTarget);
						}
						finally
						{
							e.Handled = true;
						}
					}
				}
				finally
				{
					this._transferExecuteCommand = transferExecuteCommand;
				}
			}
		}

		// Token: 0x060007F4 RID: 2036 RVA: 0x00025E4C File Offset: 0x0002404C
		private void TransferCanExecute(global::System.Windows.Input.RoutedCommand rc, global::System.Windows.Input.CanExecuteRoutedEventArgs e)
		{
			if (rc != null)
			{
				if (rc == this._transferExecuteCommand)
				{
					return;
				}
				if (rc != this._transferCanExecuteCommand)
				{
					global::System.Windows.Input.RoutedCommand transferCanExecuteCommand = this._transferCanExecuteCommand;
					this._transferCanExecuteCommand = rc;
					try
					{
						global::System.Windows.IInputElement transferCommandTarget = this.GetTransferCommandTarget();
						if (transferCommandTarget != null && rc.CanExecute(e.Parameter, transferCommandTarget))
						{
							e.CanExecute = true;
							e.Handled = true;
						}
						return;
					}
					finally
					{
						this._transferCanExecuteCommand = transferCanExecuteCommand;
					}
				}
				e.ContinueRouting = false;
				e.Handled = true;
			}
		}

		// Token: 0x060007F5 RID: 2037 RVA: 0x00025ECC File Offset: 0x000240CC
		private void VerifyFloatingWindowVisibility()
		{
			if (this._isVerifyingFloatingWindowVisibility)
			{
				this._verifyFloatingWindowVisibilityAgain = true;
				return;
			}
			try
			{
				this._isVerifyingFloatingWindowVisibility = true;
				this.VerifyFloatingWindowVisibilityImpl();
			}
			finally
			{
				this._isVerifyingFloatingWindowVisibility = false;
			}
			if (this._verifyFloatingWindowVisibilityAgain)
			{
				this._verifyFloatingWindowVisibilityAgain = false;
				this.VerifyFloatingWindowVisibility();
			}
		}

		// Token: 0x060007F6 RID: 2038 RVA: 0x00025F28 File Offset: 0x00024128
		private void VerifyFloatingWindowVisibilityImpl()
		{
			object value;
			if (!this.AllowToolWindowLoaded)
			{
				value = global::Infragistics.KnownBoxes.VisibilityCollapsedBox;
			}
			else
			{
				switch (this.FloatingWindowVisibility)
				{
				case global::Infragistics.Windows.DockManager.FloatingWindowVisibility.Hidden:
					value = global::Infragistics.KnownBoxes.VisibilityHiddenBox;
					goto IL_68;
				case global::Infragistics.Windows.DockManager.FloatingWindowVisibility.Collapsed:
					value = global::Infragistics.KnownBoxes.VisibilityCollapsedBox;
					goto IL_68;
				case global::Infragistics.Windows.DockManager.FloatingWindowVisibility.SyncWithDockManagerWindow:
					if (this._hwndSourceHelper == null)
					{
						value = global::Infragistics.KnownBoxes.VisibilityVisibleBox;
						goto IL_68;
					}
					value = this._hwndSourceHelper.RootVisualVisibility;
					goto IL_68;
				}
				value = global::Infragistics.KnownBoxes.VisibilityVisibleBox;
			}
			IL_68:
			base.SetValue(global::Infragistics.Windows.DockManager.XamDockManager.ComputedFloatingWindowVisibilityPropertyKey, value);
			this.SetIsWindowLoaded(this.AllowToolWindowLoaded);
		}

		// Token: 0x060007F7 RID: 2039 RVA: 0x00025FB5 File Offset: 0x000241B5
		protected virtual void OnActivePaneChanged(global::System.Windows.RoutedPropertyChangedEventArgs<global::Infragistics.Windows.DockManager.ContentPane> args)
		{
			base.RaiseEvent(args);
		}

		// Token: 0x060007F8 RID: 2040 RVA: 0x00025FBE File Offset: 0x000241BE
		internal void RaiseActivePaneChanged(global::System.Windows.RoutedPropertyChangedEventArgs<global::Infragistics.Windows.DockManager.ContentPane> args)
		{
			args.RoutedEvent = global::Infragistics.Windows.DockManager.XamDockManager.ActivePaneChangedEvent;
			args.Source = this;
			this.OnActivePaneChanged(args);
		}

		// Token: 0x1400000C RID: 12
		// (add) Token: 0x060007F9 RID: 2041 RVA: 0x00025FD9 File Offset: 0x000241D9
		// (remove) Token: 0x060007FA RID: 2042 RVA: 0x00025FE7 File Offset: 0x000241E7
		public event global::System.Windows.RoutedPropertyChangedEventHandler<global::Infragistics.Windows.DockManager.ContentPane> ActivePaneChanged
		{
			add
			{
				base.AddHandler(global::Infragistics.Windows.DockManager.XamDockManager.ActivePaneChangedEvent, value);
			}
			remove
			{
				base.RemoveHandler(global::Infragistics.Windows.DockManager.XamDockManager.ActivePaneChangedEvent, value);
			}
		}

		// Token: 0x060007FB RID: 2043 RVA: 0x00025FF5 File Offset: 0x000241F5
		protected virtual void OnExecutingCommand(global::Infragistics.Windows.Controls.Events.ExecutingCommandEventArgs args)
		{
			base.RaiseEvent(args);
		}

		// Token: 0x060007FC RID: 2044 RVA: 0x00025FFE File Offset: 0x000241FE
		internal bool RaiseExecutingCommand(global::Infragistics.Windows.Controls.Events.ExecutingCommandEventArgs args)
		{
			args.RoutedEvent = global::Infragistics.Windows.DockManager.XamDockManager.ExecutingCommandEvent;
			args.Source = this;
			this.OnExecutingCommand(args);
			return !args.Cancel;
		}

		// Token: 0x1400000D RID: 13
		// (add) Token: 0x060007FD RID: 2045 RVA: 0x00026022 File Offset: 0x00024222
		// (remove) Token: 0x060007FE RID: 2046 RVA: 0x00026030 File Offset: 0x00024230
		public event global::System.EventHandler<global::Infragistics.Windows.Controls.Events.ExecutingCommandEventArgs> ExecutingCommand
		{
			add
			{
				base.AddHandler(global::Infragistics.Windows.DockManager.XamDockManager.ExecutingCommandEvent, value);
			}
			remove
			{
				base.RemoveHandler(global::Infragistics.Windows.DockManager.XamDockManager.ExecutingCommandEvent, value);
			}
		}

		// Token: 0x060007FF RID: 2047 RVA: 0x0002603E File Offset: 0x0002423E
		protected virtual void OnExecutedCommand(global::Infragistics.Windows.Controls.Events.ExecutedCommandEventArgs args)
		{
			base.RaiseEvent(args);
		}

		// Token: 0x06000800 RID: 2048 RVA: 0x00026047 File Offset: 0x00024247
		internal void RaiseExecutedCommand(global::Infragistics.Windows.Controls.Events.ExecutedCommandEventArgs args)
		{
			args.RoutedEvent = global::Infragistics.Windows.DockManager.XamDockManager.ExecutedCommandEvent;
			args.Source = this;
			this.OnExecutedCommand(args);
		}

		// Token: 0x1400000E RID: 14
		// (add) Token: 0x06000801 RID: 2049 RVA: 0x00026062 File Offset: 0x00024262
		// (remove) Token: 0x06000802 RID: 2050 RVA: 0x00026070 File Offset: 0x00024270
		public event global::System.EventHandler<global::Infragistics.Windows.Controls.Events.ExecutedCommandEventArgs> ExecutedCommand
		{
			add
			{
				base.AddHandler(global::Infragistics.Windows.DockManager.XamDockManager.ExecutedCommandEvent, value);
			}
			remove
			{
				base.RemoveHandler(global::Infragistics.Windows.DockManager.XamDockManager.ExecutedCommandEvent, value);
			}
		}

		// Token: 0x06000803 RID: 2051 RVA: 0x00026080 File Offset: 0x00024280
		internal virtual void OnFlyoutOpening(global::System.EventArgs e)
		{
			global::System.EventHandler flyoutOpening = this.FlyoutOpening;
			if (flyoutOpening != null)
			{
				flyoutOpening(this, e);
			}
		}

		// Token: 0x06000804 RID: 2052 RVA: 0x0002609F File Offset: 0x0002429F
		internal void RaiseFlyoutOpening(global::System.EventArgs e)
		{
			this.OnFlyoutOpening(e);
		}

		// Token: 0x1400000F RID: 15
		// (add) Token: 0x06000805 RID: 2053 RVA: 0x000260A8 File Offset: 0x000242A8
		// (remove) Token: 0x06000806 RID: 2054 RVA: 0x000260E0 File Offset: 0x000242E0
		internal event global::System.EventHandler FlyoutOpening;

		// Token: 0x06000807 RID: 2055 RVA: 0x00026115 File Offset: 0x00024315
		protected virtual void OnInitializePaneContent(global::Infragistics.Windows.DockManager.Events.InitializePaneContentEventArgs args)
		{
			base.RaiseEvent(args);
		}

		// Token: 0x06000808 RID: 2056 RVA: 0x0002611E File Offset: 0x0002431E
		internal void RaiseInitializePaneContent(global::Infragistics.Windows.DockManager.Events.InitializePaneContentEventArgs args)
		{
			args.RoutedEvent = global::Infragistics.Windows.DockManager.XamDockManager.InitializePaneContentEvent;
			args.Source = this;
			this.OnInitializePaneContent(args);
		}

		// Token: 0x14000010 RID: 16
		// (add) Token: 0x06000809 RID: 2057 RVA: 0x00026139 File Offset: 0x00024339
		// (remove) Token: 0x0600080A RID: 2058 RVA: 0x00026147 File Offset: 0x00024347
		public event global::System.EventHandler<global::Infragistics.Windows.DockManager.Events.InitializePaneContentEventArgs> InitializePaneContent
		{
			add
			{
				base.AddHandler(global::Infragistics.Windows.DockManager.XamDockManager.InitializePaneContentEvent, value);
			}
			remove
			{
				base.RemoveHandler(global::Infragistics.Windows.DockManager.XamDockManager.InitializePaneContentEvent, value);
			}
		}

		// Token: 0x0600080B RID: 2059 RVA: 0x00026155 File Offset: 0x00024355
		protected virtual void OnPaneDragEnded(global::Infragistics.Windows.DockManager.Events.PaneDragEndedEventArgs args)
		{
			base.RaiseEvent(args);
		}

		// Token: 0x0600080C RID: 2060 RVA: 0x0002615E File Offset: 0x0002435E
		internal void RaisePaneDragEnded(global::Infragistics.Windows.DockManager.Events.PaneDragEndedEventArgs args)
		{
			args.RoutedEvent = global::Infragistics.Windows.DockManager.XamDockManager.PaneDragEndedEvent;
			args.Source = this;
			this.OnPaneDragEnded(args);
		}

		// Token: 0x14000011 RID: 17
		// (add) Token: 0x0600080D RID: 2061 RVA: 0x00026179 File Offset: 0x00024379
		// (remove) Token: 0x0600080E RID: 2062 RVA: 0x00026187 File Offset: 0x00024387
		public event global::System.EventHandler<global::Infragistics.Windows.DockManager.Events.PaneDragEndedEventArgs> PaneDragEnded
		{
			add
			{
				base.AddHandler(global::Infragistics.Windows.DockManager.XamDockManager.PaneDragEndedEvent, value);
			}
			remove
			{
				base.RemoveHandler(global::Infragistics.Windows.DockManager.XamDockManager.PaneDragEndedEvent, value);
			}
		}

		// Token: 0x0600080F RID: 2063 RVA: 0x00026195 File Offset: 0x00024395
		protected virtual void OnPaneDragOver(global::Infragistics.Windows.DockManager.Events.PaneDragOverEventArgs args)
		{
			base.RaiseEvent(args);
		}

		// Token: 0x06000810 RID: 2064 RVA: 0x0002619E File Offset: 0x0002439E
		internal void RaisePaneDragOver(global::Infragistics.Windows.DockManager.Events.PaneDragOverEventArgs args)
		{
			args.RoutedEvent = global::Infragistics.Windows.DockManager.XamDockManager.PaneDragOverEvent;
			args.Source = this;
			this.OnPaneDragOver(args);
		}

		// Token: 0x14000012 RID: 18
		// (add) Token: 0x06000811 RID: 2065 RVA: 0x000261B9 File Offset: 0x000243B9
		// (remove) Token: 0x06000812 RID: 2066 RVA: 0x000261C7 File Offset: 0x000243C7
		public event global::System.EventHandler<global::Infragistics.Windows.DockManager.Events.PaneDragOverEventArgs> PaneDragOver
		{
			add
			{
				base.AddHandler(global::Infragistics.Windows.DockManager.XamDockManager.PaneDragOverEvent, value);
			}
			remove
			{
				base.RemoveHandler(global::Infragistics.Windows.DockManager.XamDockManager.PaneDragOverEvent, value);
			}
		}

		// Token: 0x06000813 RID: 2067 RVA: 0x000261D8 File Offset: 0x000243D8
		internal void OnPageDragOverInternal(global::Infragistics.Windows.DockManager.Events.PaneDragOverEventArgs args)
		{
			global::System.EventHandler<global::Infragistics.Windows.DockManager.Events.PaneDragOverEventArgs> paneDragOverInternal = this.PaneDragOverInternal;
			if (paneDragOverInternal != null)
			{
				paneDragOverInternal(this, args);
			}
		}

		// Token: 0x17000235 RID: 565
		// (get) Token: 0x06000814 RID: 2068 RVA: 0x000261F7 File Offset: 0x000243F7
		internal bool HasPaneDragOverInternalListeners
		{
			get
			{
				return this.PaneDragOverInternal != null;
			}
		}

		// Token: 0x14000013 RID: 19
		// (add) Token: 0x06000815 RID: 2069 RVA: 0x00026208 File Offset: 0x00024408
		// (remove) Token: 0x06000816 RID: 2070 RVA: 0x00026240 File Offset: 0x00024440
		internal event global::System.EventHandler<global::Infragistics.Windows.DockManager.Events.PaneDragOverEventArgs> PaneDragOverInternal;

		// Token: 0x06000817 RID: 2071 RVA: 0x00026275 File Offset: 0x00024475
		protected virtual void OnPaneDragStarting(global::Infragistics.Windows.DockManager.Events.PaneDragStartingEventArgs args)
		{
			base.RaiseEvent(args);
		}

		// Token: 0x06000818 RID: 2072 RVA: 0x0002627E File Offset: 0x0002447E
		internal void RaisePaneDragStarting(global::Infragistics.Windows.DockManager.Events.PaneDragStartingEventArgs args)
		{
			args.RoutedEvent = global::Infragistics.Windows.DockManager.XamDockManager.PaneDragStartingEvent;
			args.Source = this;
			this.OnPaneDragStarting(args);
		}

		// Token: 0x14000014 RID: 20
		// (add) Token: 0x06000819 RID: 2073 RVA: 0x00026299 File Offset: 0x00024499
		// (remove) Token: 0x0600081A RID: 2074 RVA: 0x000262A7 File Offset: 0x000244A7
		public event global::System.EventHandler<global::Infragistics.Windows.DockManager.Events.PaneDragStartingEventArgs> PaneDragStarting
		{
			add
			{
				base.AddHandler(global::Infragistics.Windows.DockManager.XamDockManager.PaneDragStartingEvent, value);
			}
			remove
			{
				base.RemoveHandler(global::Infragistics.Windows.DockManager.XamDockManager.PaneDragStartingEvent, value);
			}
		}

		// Token: 0x0600081B RID: 2075 RVA: 0x000262B5 File Offset: 0x000244B5
		protected virtual void OnToolWindowLoaded(global::Infragistics.Windows.DockManager.Events.PaneToolWindowEventArgs args)
		{
			base.RaiseEvent(args);
		}

		// Token: 0x0600081C RID: 2076 RVA: 0x000262BE File Offset: 0x000244BE
		internal void RaiseToolWindowLoaded(global::Infragistics.Windows.DockManager.Events.PaneToolWindowEventArgs args)
		{
			args.RoutedEvent = global::Infragistics.Windows.DockManager.XamDockManager.ToolWindowLoadedEvent;
			args.Source = this;
			this.OnToolWindowLoaded(args);
		}

		// Token: 0x14000015 RID: 21
		// (add) Token: 0x0600081D RID: 2077 RVA: 0x000262D9 File Offset: 0x000244D9
		// (remove) Token: 0x0600081E RID: 2078 RVA: 0x000262E7 File Offset: 0x000244E7
		public event global::System.EventHandler<global::Infragistics.Windows.DockManager.Events.PaneToolWindowEventArgs> ToolWindowLoaded
		{
			add
			{
				base.AddHandler(global::Infragistics.Windows.DockManager.XamDockManager.ToolWindowLoadedEvent, value);
			}
			remove
			{
				base.RemoveHandler(global::Infragistics.Windows.DockManager.XamDockManager.ToolWindowLoadedEvent, value);
			}
		}

		// Token: 0x0600081F RID: 2079 RVA: 0x000262F5 File Offset: 0x000244F5
		protected virtual void OnToolWindowUnloaded(global::Infragistics.Windows.DockManager.Events.PaneToolWindowEventArgs args)
		{
			base.RaiseEvent(args);
		}

		// Token: 0x06000820 RID: 2080 RVA: 0x000262FE File Offset: 0x000244FE
		internal void RaiseToolWindowUnloaded(global::Infragistics.Windows.DockManager.Events.PaneToolWindowEventArgs args)
		{
			args.RoutedEvent = global::Infragistics.Windows.DockManager.XamDockManager.ToolWindowUnloadedEvent;
			args.Source = this;
			this.OnToolWindowUnloaded(args);
		}

		// Token: 0x14000016 RID: 22
		// (add) Token: 0x06000821 RID: 2081 RVA: 0x00026319 File Offset: 0x00024519
		// (remove) Token: 0x06000822 RID: 2082 RVA: 0x00026327 File Offset: 0x00024527
		public event global::System.EventHandler<global::Infragistics.Windows.DockManager.Events.PaneToolWindowEventArgs> ToolWindowUnloaded
		{
			add
			{
				base.AddHandler(global::Infragistics.Windows.DockManager.XamDockManager.ToolWindowUnloadedEvent, value);
			}
			remove
			{
				base.RemoveHandler(global::Infragistics.Windows.DockManager.XamDockManager.ToolWindowUnloadedEvent, value);
			}
		}

		// Token: 0x06000823 RID: 2083 RVA: 0x00026338 File Offset: 0x00024538
		bool global::Infragistics.Windows.Commands.ICommandHost.CanExecute(global::Infragistics.Windows.Commands.ExecuteCommandInfo commandInfo)
		{
			global::System.Windows.Input.RoutedCommand routedCommand = commandInfo.RoutedCommand;
			if (routedCommand != null)
			{
				if (commandInfo.Parameter is global::Infragistics.Windows.DockManager.XamDockManager && commandInfo.Parameter != this)
				{
					return false;
				}
				if (routedCommand.OwnerType == typeof(global::Infragistics.Windows.DockManager.DockManagerCommands))
				{
					commandInfo.ForceHandled = true;
				}
				if (routedCommand == global::Infragistics.Windows.DockManager.DockManagerCommands.ActivateNextDocument || routedCommand == global::Infragistics.Windows.DockManager.DockManagerCommands.ActivatePreviousDocument)
				{
					return this._activePaneManager.CanNavigateDocuments;
				}
				if (routedCommand == global::Infragistics.Windows.DockManager.DockManagerCommands.ActivateNextPane || routedCommand == global::Infragistics.Windows.DockManager.DockManagerCommands.ActivatePreviousPane)
				{
					return this._activePaneManager.CanNavigatePanes;
				}
				if (routedCommand == global::Infragistics.Windows.DockManager.DockManagerCommands.CloseActiveDocument)
				{
					global::Infragistics.Windows.DockManager.ContentPane activeDocument = this.ActivePaneManager.GetActiveDocument();
					return activeDocument != null && activeDocument.AllowClose;
				}
				if (routedCommand == global::Infragistics.Windows.DockManager.DockManagerCommands.ShowPaneNavigator)
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x06000824 RID: 2084 RVA: 0x000263EC File Offset: 0x000245EC
		long global::Infragistics.Windows.Commands.ICommandHost.GetCurrentState(long statesToQuery)
		{
			global::Infragistics.Windows.DockManager.DockManagerStates dockManagerStates = (global::Infragistics.Windows.DockManager.DockManagerStates)0L;
			if (this.ActivePane != null)
			{
				dockManagerStates |= global::Infragistics.Windows.DockManager.DockManagerStates.ActivePane;
			}
			if (this.HasDocumentContentHost)
			{
				dockManagerStates |= global::Infragistics.Windows.DockManager.DockManagerStates.HasDocumentContentHost;
				if (this.ActivePaneManager.GetActiveDocument() != null)
				{
					dockManagerStates |= global::Infragistics.Windows.DockManager.DockManagerStates.ActiveDocument;
				}
			}
			return (long)(dockManagerStates & (global::Infragistics.Windows.DockManager.DockManagerStates)statesToQuery);
		}

		// Token: 0x06000825 RID: 2085 RVA: 0x0002642C File Offset: 0x0002462C
		bool global::Infragistics.Windows.Commands.ICommandHost.Execute(global::Infragistics.Windows.Commands.ExecuteCommandInfo commandInfo)
		{
			global::System.Windows.Input.RoutedCommand routedCommand = commandInfo.RoutedCommand;
			return routedCommand != null && this.ExecuteCommandImpl(commandInfo);
		}

		// Token: 0x17000236 RID: 566
		// (get) Token: 0x06000826 RID: 2086 RVA: 0x0002644C File Offset: 0x0002464C
		global::System.Collections.IList global::Infragistics.Windows.DockManager.IPaneContainer.Panes
		{
			get
			{
				return this._rootPaneList;
			}
		}

		// Token: 0x06000827 RID: 2087 RVA: 0x00026454 File Offset: 0x00024654
		bool global::Infragistics.Windows.DockManager.IPaneContainer.RemovePane(object pane)
		{
			if (pane is global::Infragistics.Windows.DockManager.PaneToolWindow)
			{
				global::Infragistics.Windows.DockManager.PaneToolWindow item = (global::Infragistics.Windows.DockManager.PaneToolWindow)pane;
				this._toolWindows.IndexOf(item);
				return false;
			}
			if (!(pane is global::Infragistics.Windows.DockManager.SplitPane))
			{
				return false;
			}
			global::Infragistics.Windows.DockManager.SplitPane item2 = (global::Infragistics.Windows.DockManager.SplitPane)pane;
			int num = this.Panes.IndexOf(item2);
			if (num < 0)
			{
				return false;
			}
			this.Panes.RemoveAt(num);
			return true;
		}

		// Token: 0x17000237 RID: 567
		// (get) Token: 0x06000828 RID: 2088 RVA: 0x000264B0 File Offset: 0x000246B0
		bool global::Infragistics.Windows.DockManager.IPaneContainer.CanBeRemoved
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000238 RID: 568
		// (get) Token: 0x06000829 RID: 2089 RVA: 0x000264B3 File Offset: 0x000246B3
		bool global::Infragistics.Windows.DockManager.IHwndHostContainer.HasHwndHost
		{
			get
			{
				return this.HasHwndHost;
			}
		}

		// Token: 0x0600082A RID: 2090 RVA: 0x000266D8 File Offset: 0x000248D8
		global::System.Collections.Generic.IEnumerable<global::System.Windows.Interop.HwndHost> global::Infragistics.Windows.DockManager.IHwndHostContainer.GetHosts()
		{
			foreach (global::Infragistics.Windows.DockManager.HwndHostInfo hhi in this.GetHwndHostInfos())
			{
				foreach (global::System.Windows.Interop.HwndHost host in hhi.GetHosts())
				{
					yield return host;
				}
			}
			yield break;
		}

		// Token: 0x0600082B RID: 2091 RVA: 0x000266F5 File Offset: 0x000248F5
		void global::Infragistics.Windows.DockManager.IHwndHostInfoOwner.OnHasHostsChanged()
		{
			this.DirtyHasHwndHosts();
		}

		// Token: 0x040003CC RID: 972
		private global::Infragistics.Windows.DockManager.UnpinnedTabAreaInfo[] _tabAreaInfos = new global::Infragistics.Windows.DockManager.UnpinnedTabAreaInfo[4];

		// Token: 0x040003CD RID: 973
		private global::Infragistics.Windows.DockManager.DockManagerPanel _dockPanel;

		// Token: 0x040003CE RID: 974
		private global::Infragistics.Windows.DockManager.XamDockManager.PanesCollection _panes;

		// Token: 0x040003CF RID: 975
		private global::Infragistics.Windows.Licensing.UltraLicense _license;

		// Token: 0x040003D0 RID: 976
		private global::System.Collections.ObjectModel.ObservableCollection<global::Infragistics.Windows.DockManager.PaneToolWindow> _toolWindows;

		// Token: 0x040003D1 RID: 977
		private global::System.Collections.ObjectModel.ReadOnlyObservableCollection<global::Infragistics.Windows.DockManager.PaneToolWindow> _readOnlyWindows;

		// Token: 0x040003D2 RID: 978
		private global::Infragistics.Windows.DockManager.XamDockManager.RootPaneList _rootPaneList;

		// Token: 0x040003D3 RID: 979
		private global::Infragistics.Windows.DockManager.DockManagerCommands _commands;

		// Token: 0x040003D4 RID: 980
		private global::Infragistics.Windows.DockManager.ActivePaneManager _activePaneManager;

		// Token: 0x040003D5 RID: 981
		private global::Infragistics.Windows.DockManager.Dragging.DragManager _dragManager;

		// Token: 0x040003D6 RID: 982
		private global::System.Collections.Generic.List<global::System.Windows.DependencyObject> _logicalChildren;

		// Token: 0x040003D7 RID: 983
		private bool _isLoadingLayout;

		// Token: 0x040003D8 RID: 984
		private int _suspendShowFlyoutCount;

		// Token: 0x040003D9 RID: 985
		private global::System.Windows.Input.RoutedCommand _transferCanExecuteCommand;

		// Token: 0x040003DA RID: 986
		private global::System.Windows.Input.RoutedCommand _transferExecuteCommand;

		// Token: 0x040003DB RID: 987
		private bool _forcingFocus;

		// Token: 0x040003DC RID: 988
		private global::System.Windows.FrameworkContentElement _dragHelper;

		// Token: 0x040003DD RID: 989
		private bool _isClosingPanes;

		// Token: 0x040003DE RID: 990
		private global::System.Collections.Generic.Dictionary<global::Infragistics.Windows.DockManager.ContentPane, bool> _deferredPinnedPanes;

		// Token: 0x040003DF RID: 991
		private global::Infragistics.Windows.DockManager.LogicalContainer _unpinnedPaneHolder;

		// Token: 0x040003E0 RID: 992
		private bool? _hasHwndHost;

		// Token: 0x040003E1 RID: 993
		private bool _isSettingFocusedElement;

		// Token: 0x040003E2 RID: 994
		private static readonly global::System.Type _secureCommandType;

		// Token: 0x040003E3 RID: 995
		private global::System.WeakReference _fillPane;

		// Token: 0x040003E4 RID: 996
		private global::Infragistics.Windows.DockManager.XamDockManager.HwndSourceHelper _hwndSourceHelper;

		// Token: 0x040003E5 RID: 997
		private static bool _avoidHwndSourceHelper;

		// Token: 0x040003E6 RID: 998
		private bool _hasAppliedTemplate;

		// Token: 0x040003E7 RID: 999
		private bool _isActivatingPane;

		// Token: 0x040003E8 RID: 1000
		public static readonly global::System.Windows.ResourceKey DropPreviewStyleKey = new global::Infragistics.Windows.Themes.StaticPropertyResourceKey(typeof(global::Infragistics.Windows.DockManager.XamDockManager), "DropPreviewStyleKey");

		// Token: 0x040003E9 RID: 1001
		public static readonly global::System.Windows.ResourceKey ContextMenuStyleKey = new global::Infragistics.Windows.Themes.StaticPropertyResourceKey(typeof(global::Infragistics.Windows.DockManager.XamDockManager), "ContextMenuStyleKey");

		// Token: 0x040003EA RID: 1002
		public static readonly global::System.Windows.ResourceKey FloatingWindowPreviewStyleKey = new global::Infragistics.Windows.Themes.StaticPropertyResourceKey(typeof(global::Infragistics.Windows.DockManager.XamDockManager), "FloatingWindowPreviewStyleKey");

		// Token: 0x040003EB RID: 1003
		public static readonly global::System.Windows.ResourceKey MenuItemSeparatorStyleKey = new global::Infragistics.Windows.Themes.StaticPropertyResourceKey(typeof(global::Infragistics.Windows.DockManager.XamDockManager), "MenuItemSeparatorStyleKey");

		// Token: 0x040003EC RID: 1004
		public static readonly global::System.Windows.ResourceKey MenuItemStyleKey = new global::Infragistics.Windows.Themes.StaticPropertyResourceKey(typeof(global::Infragistics.Windows.DockManager.XamDockManager), "MenuItemStyleKey");

		// Token: 0x040003ED RID: 1005
		public static readonly global::System.Windows.ResourceKey ToolTipStyleKey = new global::Infragistics.Windows.Themes.StaticPropertyResourceKey(typeof(global::Infragistics.Windows.DockManager.XamDockManager), "ToolTipStyleKey");

		// Token: 0x040003EE RID: 1006
		public static readonly global::System.Windows.ResourceKey SubMenuItemTemplateKey = new global::Infragistics.Windows.Themes.StaticPropertyResourceKey(typeof(global::Infragistics.Windows.DockManager.XamDockManager), "SubMenuItemTemplateKey");

		// Token: 0x040003EF RID: 1007
		public static readonly global::System.Windows.DependencyProperty ActivePaneProperty = global::Infragistics.Windows.DockManager.ActivePaneManager.ActivePaneProperty.AddOwner(typeof(global::Infragistics.Windows.DockManager.XamDockManager));

		// Token: 0x040003F0 RID: 1008
		public static readonly global::System.Windows.DependencyProperty AllowMinimizeFloatingWindowsProperty = global::System.Windows.DependencyProperty.Register("AllowMinimizeFloatingWindows", typeof(bool), typeof(global::Infragistics.Windows.DockManager.XamDockManager), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox));

		// Token: 0x040003F1 RID: 1009
		public static readonly global::System.Windows.DependencyProperty AllowMaximizeFloatingWindowsProperty = global::System.Windows.DependencyProperty.Register("AllowMaximizeFloatingWindows", typeof(bool), typeof(global::Infragistics.Windows.DockManager.XamDockManager), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox));

		// Token: 0x040003F2 RID: 1010
		public static readonly global::System.Windows.DependencyProperty CloseBehaviorProperty = global::System.Windows.DependencyProperty.Register("CloseBehavior", typeof(global::Infragistics.Windows.DockManager.PaneActionBehavior), typeof(global::Infragistics.Windows.DockManager.XamDockManager), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.Windows.DockManager.PaneActionBehavior.ActivePane));

		// Token: 0x040003F3 RID: 1011
		internal static readonly global::System.Windows.DependencyPropertyKey DockManagerPropertyKey = global::System.Windows.DependencyProperty.RegisterAttachedReadOnly("DockManager", typeof(global::Infragistics.Windows.DockManager.XamDockManager), typeof(global::Infragistics.Windows.DockManager.XamDockManager), new global::System.Windows.FrameworkPropertyMetadata(null, global::System.Windows.FrameworkPropertyMetadataOptions.Inherits | global::System.Windows.FrameworkPropertyMetadataOptions.OverridesInheritanceBehavior));

		// Token: 0x040003F4 RID: 1012
		public static readonly global::System.Windows.DependencyProperty DockManagerProperty = global::Infragistics.Windows.DockManager.XamDockManager.DockManagerPropertyKey.DependencyProperty;

		// Token: 0x040003F5 RID: 1013
		internal static readonly global::System.Windows.DependencyPropertyKey DropPreviewTabLocationPropertyKey = global::System.Windows.DependencyProperty.RegisterAttachedReadOnly("DropPreviewTabLocation", typeof(global::Infragistics.Windows.DockManager.Dragging.DropPreviewTabLocation), typeof(global::Infragistics.Windows.DockManager.XamDockManager), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.Windows.DockManager.Dragging.DropPreviewTabLocation.None));

		// Token: 0x040003F6 RID: 1014
		public static readonly global::System.Windows.DependencyProperty DropPreviewTabLocationProperty = global::Infragistics.Windows.DockManager.XamDockManager.DropPreviewTabLocationPropertyKey.DependencyProperty;

		// Token: 0x040003F7 RID: 1015
		public static readonly global::System.Windows.DependencyProperty FloatingLocationProperty = global::System.Windows.DependencyProperty.RegisterAttached("FloatingLocation", typeof(global::System.Windows.Point?), typeof(global::Infragistics.Windows.DockManager.XamDockManager), new global::System.Windows.FrameworkPropertyMetadata(null));

		// Token: 0x040003F8 RID: 1016
		public static readonly global::System.Windows.DependencyProperty FloatingSizeProperty = global::System.Windows.DependencyProperty.RegisterAttached("FloatingSize", typeof(global::System.Windows.Size), typeof(global::Infragistics.Windows.DockManager.XamDockManager), new global::System.Windows.FrameworkPropertyMetadata(global::System.Windows.Size.Empty));

		// Token: 0x040003F9 RID: 1017
		public static readonly global::System.Windows.DependencyProperty FloatingWindowCaptionSourceProperty = global::System.Windows.DependencyProperty.Register("FloatingWindowCaptionSource", typeof(global::Infragistics.Windows.DockManager.FloatingWindowCaptionSource), typeof(global::Infragistics.Windows.DockManager.XamDockManager), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.Windows.DockManager.FloatingWindowCaptionSource.UseToolWindowTitle));

		// Token: 0x040003FA RID: 1018
		public static readonly global::System.Windows.DependencyProperty FloatingWindowDoubleClickActionProperty = global::System.Windows.DependencyProperty.Register("FloatingWindowDoubleClickAction", typeof(global::Infragistics.Windows.DockManager.FloatingWindowDoubleClickAction?), typeof(global::Infragistics.Windows.DockManager.XamDockManager), new global::System.Windows.FrameworkPropertyMetadata(null));

		// Token: 0x040003FB RID: 1019
		public static readonly global::System.Windows.DependencyProperty FloatingWindowDragModeProperty = global::System.Windows.DependencyProperty.Register("FloatingWindowDragMode", typeof(global::Infragistics.Windows.DockManager.FloatingWindowDragMode), typeof(global::Infragistics.Windows.DockManager.XamDockManager), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.Windows.DockManager.FloatingWindowDragMode.Immediate));

		// Token: 0x040003FC RID: 1020
		public static readonly global::System.Windows.DependencyProperty FloatingWindowVisibilityProperty = global::System.Windows.DependencyProperty.Register("FloatingWindowVisibility", typeof(global::Infragistics.Windows.DockManager.FloatingWindowVisibility), typeof(global::Infragistics.Windows.DockManager.XamDockManager), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.Windows.DockManager.FloatingWindowVisibility.Visible, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DockManager.XamDockManager.OnFloatingWindowVisibilityChanged)));

		// Token: 0x040003FD RID: 1021
		public static readonly global::System.Windows.DependencyProperty FlyoutAnimationProperty = global::System.Windows.DependencyProperty.Register("FlyoutAnimation", typeof(global::Infragistics.Windows.DockManager.PaneFlyoutAnimation), typeof(global::Infragistics.Windows.DockManager.XamDockManager), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.Windows.DockManager.PaneFlyoutAnimation.Slide, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DockManager.XamDockManager.OnFlyoutAnimationChanged)));

		// Token: 0x040003FE RID: 1022
		private static readonly global::System.Windows.DependencyPropertyKey HasDocumentContentHostPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("HasDocumentContentHost", typeof(bool), typeof(global::Infragistics.Windows.DockManager.XamDockManager), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox));

		// Token: 0x040003FF RID: 1023
		public static readonly global::System.Windows.DependencyProperty HasDocumentContentHostProperty = global::Infragistics.Windows.DockManager.XamDockManager.HasDocumentContentHostPropertyKey.DependencyProperty;

		// Token: 0x04000400 RID: 1024
		public static readonly global::System.Windows.DependencyProperty InitialLocationProperty = global::System.Windows.DependencyProperty.RegisterAttached("InitialLocation", typeof(global::Infragistics.Windows.DockManager.InitialPaneLocation), typeof(global::Infragistics.Windows.DockManager.XamDockManager), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.Windows.DockManager.InitialPaneLocation.DockedLeft, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DockManager.XamDockManager.OnInitialLocationChanged)));

		// Token: 0x04000401 RID: 1025
		public static readonly global::System.Windows.DependencyProperty LayoutModeProperty = global::System.Windows.DependencyProperty.Register("LayoutMode", typeof(global::Infragistics.Windows.DockManager.DockedPaneLayoutMode), typeof(global::Infragistics.Windows.DockManager.XamDockManager), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.Windows.DockManager.DockedPaneLayoutMode.Standard, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DockManager.XamDockManager.OnLayoutModeChanged), new global::System.Windows.CoerceValueCallback(global::Infragistics.Windows.DockManager.XamDockManager.CoerceLayoutMode)));

		// Token: 0x04000402 RID: 1026
		public static readonly global::System.Windows.DependencyProperty NavigationOrderProperty = global::System.Windows.DependencyProperty.Register("NavigationOrder", typeof(global::Infragistics.Windows.DockManager.PaneNavigationOrder), typeof(global::Infragistics.Windows.DockManager.XamDockManager), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.Windows.DockManager.PaneNavigationOrder.ActivationOrder));

		// Token: 0x04000403 RID: 1027
		internal static readonly global::System.Windows.DependencyPropertyKey PaneLocationPropertyKey = global::System.Windows.DependencyProperty.RegisterAttachedReadOnly("PaneLocation", typeof(global::Infragistics.Windows.DockManager.PaneLocation), typeof(global::Infragistics.Windows.DockManager.XamDockManager), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.Windows.DockManager.PaneLocation.Unknown, global::System.Windows.FrameworkPropertyMetadataOptions.Inherits | global::System.Windows.FrameworkPropertyMetadataOptions.OverridesInheritanceBehavior));

		// Token: 0x04000404 RID: 1028
		public static readonly global::System.Windows.DependencyProperty PaneLocationProperty = global::Infragistics.Windows.DockManager.XamDockManager.PaneLocationPropertyKey.DependencyProperty;

		// Token: 0x04000405 RID: 1029
		public static readonly global::System.Windows.DependencyProperty PaneNavigatorButtonDisplayModeProperty = global::System.Windows.DependencyProperty.Register("PaneNavigatorButtonDisplayMode", typeof(global::Infragistics.Windows.DockManager.PaneNavigatorButtonDisplayMode), typeof(global::Infragistics.Windows.DockManager.XamDockManager), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.Windows.DockManager.PaneNavigatorButtonDisplayMode.WhenHostedInBrowser));

		// Token: 0x04000406 RID: 1030
		public static readonly global::System.Windows.DependencyProperty RerouteToolWindowKeyEventsProperty = global::System.Windows.DependencyProperty.Register("RerouteToolWindowKeyEvents", typeof(bool), typeof(global::Infragistics.Windows.DockManager.XamDockManager), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.TrueBox));

		// Token: 0x04000407 RID: 1031
		public static readonly global::System.Windows.DependencyProperty ShowFloatingWindowsInTaskbarProperty = global::System.Windows.DependencyProperty.Register("ShowFloatingWindowsInTaskbar", typeof(bool), typeof(global::Infragistics.Windows.DockManager.XamDockManager), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox));

		// Token: 0x04000408 RID: 1032
		public static readonly global::System.Windows.DependencyProperty TabItemDragBehaviorProperty = global::System.Windows.DependencyProperty.Register("TabItemDragBehavior", typeof(global::Infragistics.Windows.DockManager.TabItemDragBehavior), typeof(global::Infragistics.Windows.DockManager.XamDockManager), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.Windows.DockManager.TabItemDragBehavior.DisplayTabPreview));

		// Token: 0x04000409 RID: 1033
		public static readonly global::System.Windows.DependencyProperty ThemeProperty = global::Infragistics.Windows.Themes.ThemeManager.ThemeProperty.AddOwner(typeof(global::Infragistics.Windows.DockManager.XamDockManager), new global::System.Windows.FrameworkPropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DockManager.XamDockManager.OnThemeChanged)));

		// Token: 0x0400040B RID: 1035
		public static readonly global::System.Windows.DependencyProperty UseOwnedFloatingWindowsProperty;

		// Token: 0x0400040C RID: 1036
		public static readonly global::System.Windows.DependencyProperty PinBehaviorProperty;

		// Token: 0x0400040D RID: 1037
		public static readonly global::System.Windows.DependencyProperty UnpinnedTabHoverActionProperty;

		// Token: 0x0400040E RID: 1038
		private static readonly global::System.Windows.DependencyPropertyKey ComputedFloatingWindowVisibilityPropertyKey;

		// Token: 0x0400040F RID: 1039
		internal static readonly global::System.Windows.DependencyProperty ComputedFloatingWindowVisibilityProperty;

		// Token: 0x04000410 RID: 1040
		private bool _isVerifyingFloatingWindowVisibility;

		// Token: 0x04000411 RID: 1041
		private bool _verifyFloatingWindowVisibilityAgain;

		// Token: 0x020000D8 RID: 216
		internal class PanesCollection : global::Infragistics.Collections.ObservableCollectionExtended<global::Infragistics.Windows.DockManager.SplitPane>
		{
			// Token: 0x0600082C RID: 2092 RVA: 0x00026700 File Offset: 0x00024900
			internal PanesCollection(global::Infragistics.Windows.DockManager.XamDockManager dockManager)
			{
				this._dockManager = dockManager;
				this._dockedPanes = new global::Infragistics.Windows.DockManager.QueuedObservableCollection<global::Infragistics.Windows.DockManager.SplitPane>();
				this._dockedPanes.CollectionChanged += this.OnDockedPanesChanged;
				this._floatingPanes = new global::Infragistics.Windows.DockManager.QueuedObservableCollection<global::Infragistics.Windows.DockManager.SplitPane>();
				this._floatingPanes.CollectionChanged += this.OnFloatingPanesChanged;
				this._readOnlyDockedPanes = new global::System.Collections.ObjectModel.ReadOnlyObservableCollection<global::Infragistics.Windows.DockManager.SplitPane>(this._dockedPanes);
				this._readOnlyFloatingPanes = new global::System.Collections.ObjectModel.ReadOnlyObservableCollection<global::Infragistics.Windows.DockManager.SplitPane>(this._floatingPanes);
			}

			// Token: 0x0600082D RID: 2093 RVA: 0x00026780 File Offset: 0x00024980
			protected override void OnCollectionChanged(global::System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
			{
				global::Infragistics.Windows.DockManager.SplitPane[] collection = global::Infragistics.Windows.DockManager.XamDockManager.PanesCollection.FindAll<global::Infragistics.Windows.DockManager.SplitPane>(this, new global::System.Predicate<global::Infragistics.Windows.DockManager.SplitPane>(global::Infragistics.Windows.DockManager.XamDockManager.PanesCollection.IsFloating));
				global::Infragistics.Windows.DockManager.SplitPane[] collection2 = global::Infragistics.Windows.DockManager.XamDockManager.PanesCollection.FindAll<global::Infragistics.Windows.DockManager.SplitPane>(this, new global::System.Predicate<global::Infragistics.Windows.DockManager.SplitPane>(global::Infragistics.Windows.DockManager.XamDockManager.PanesCollection.IsDocked));
				this._dockedPanes.ReInitialize(collection2);
				this._floatingPanes.ReInitialize(collection);
				base.OnCollectionChanged(e);
			}

			// Token: 0x17000239 RID: 569
			// (get) Token: 0x0600082E RID: 2094 RVA: 0x000267D2 File Offset: 0x000249D2
			public global::System.Collections.ObjectModel.ReadOnlyObservableCollection<global::Infragistics.Windows.DockManager.SplitPane> DockedPanes
			{
				get
				{
					return this._readOnlyDockedPanes;
				}
			}

			// Token: 0x1700023A RID: 570
			// (get) Token: 0x0600082F RID: 2095 RVA: 0x000267DA File Offset: 0x000249DA
			public global::System.Collections.ObjectModel.ReadOnlyObservableCollection<global::Infragistics.Windows.DockManager.SplitPane> FloatingPanes
			{
				get
				{
					return this._readOnlyFloatingPanes;
				}
			}

			// Token: 0x06000830 RID: 2096 RVA: 0x000267E4 File Offset: 0x000249E4
			private static bool IsFloating(global::Infragistics.Windows.DockManager.SplitPane pane)
			{
				global::Infragistics.Windows.DockManager.InitialPaneLocation initialLocation = global::Infragistics.Windows.DockManager.XamDockManager.GetInitialLocation(pane);
				return initialLocation == global::Infragistics.Windows.DockManager.InitialPaneLocation.DockableFloating || initialLocation == global::Infragistics.Windows.DockManager.InitialPaneLocation.FloatingOnly;
			}

			// Token: 0x06000831 RID: 2097 RVA: 0x00026802 File Offset: 0x00024A02
			private static bool IsDocked(global::Infragistics.Windows.DockManager.SplitPane pane)
			{
				return !global::Infragistics.Windows.DockManager.XamDockManager.PanesCollection.IsFloating(pane);
			}

			// Token: 0x06000832 RID: 2098 RVA: 0x00026810 File Offset: 0x00024A10
			private static T[] FindAll<T>(global::System.Collections.Generic.IList<T> list, global::System.Predicate<T> match)
			{
				global::System.Collections.Generic.List<T> list2 = new global::System.Collections.Generic.List<T>();
				int i = 0;
				int count = list.Count;
				while (i < count)
				{
					T t = list[i];
					if (match(t))
					{
						list2.Add(t);
					}
					i++;
				}
				return list2.ToArray();
			}

			// Token: 0x06000833 RID: 2099 RVA: 0x00026854 File Offset: 0x00024A54
			private void OnDockedPanesChanged(object sender, global::System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
			{
				global::Infragistics.Windows.DockManager.QueuedObservableCollection<global::Infragistics.Windows.DockManager.SplitPane>.QueuedNotifyCollectionChangedEventArgs queuedNotifyCollectionChangedEventArgs = e as global::Infragistics.Windows.DockManager.QueuedObservableCollection<global::Infragistics.Windows.DockManager.SplitPane>.QueuedNotifyCollectionChangedEventArgs;
				int i = 0;
				int count = queuedNotifyCollectionChangedEventArgs.ItemsAdded.Count;
				while (i < count)
				{
					global::Infragistics.Windows.DockManager.SplitPane splitPane = queuedNotifyCollectionChangedEventArgs.ItemsAdded[i];
					if (splitPane != null)
					{
						global::Infragistics.Windows.DockManager.PaneLocation value = global::Infragistics.Windows.DockManager.DockManagerUtilities.ToPaneLocation(global::Infragistics.Windows.DockManager.XamDockManager.GetInitialLocation(splitPane));
						splitPane.SetValue(global::Infragistics.Windows.DockManager.XamDockManager.PaneLocationPropertyKey, global::Infragistics.Windows.DockManager.DockManagerKnownBoxes.FromValue(value));
						this._dockManager.AddLogicalChildInternal(splitPane);
					}
					i++;
				}
				int j = 0;
				int count2 = queuedNotifyCollectionChangedEventArgs.ItemsRemoved.Count;
				while (j < count2)
				{
					global::Infragistics.Windows.DockManager.SplitPane splitPane2 = queuedNotifyCollectionChangedEventArgs.ItemsRemoved[j];
					if (splitPane2 != null)
					{
						this._dockManager.RemoveLogicalChildInternal(splitPane2);
						splitPane2.ClearValue(global::Infragistics.Windows.DockManager.XamDockManager.PaneLocationPropertyKey);
					}
					j++;
				}
				if (this._dockManager._dockPanel != null)
				{
					this._dockManager._dockPanel.Panes.ReInitialize(this._dockedPanes);
				}
				this._dockManager.VerifyFillPane();
			}

			// Token: 0x06000834 RID: 2100 RVA: 0x00026938 File Offset: 0x00024B38
			private void OnFloatingPanesChanged(object sender, global::System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
			{
				global::Infragistics.Windows.DockManager.QueuedObservableCollection<global::Infragistics.Windows.DockManager.SplitPane>.QueuedNotifyCollectionChangedEventArgs queuedNotifyCollectionChangedEventArgs = e as global::Infragistics.Windows.DockManager.QueuedObservableCollection<global::Infragistics.Windows.DockManager.SplitPane>.QueuedNotifyCollectionChangedEventArgs;
				int i = 0;
				int count = queuedNotifyCollectionChangedEventArgs.ItemsAdded.Count;
				while (i < count)
				{
					global::Infragistics.Windows.DockManager.SplitPane splitPane = queuedNotifyCollectionChangedEventArgs.ItemsAdded[i];
					if (splitPane != null)
					{
						this._dockManager.OnFloatingPaneAdded(splitPane);
					}
					i++;
				}
				int j = 0;
				int count2 = queuedNotifyCollectionChangedEventArgs.ItemsRemoved.Count;
				while (j < count2)
				{
					global::Infragistics.Windows.DockManager.SplitPane splitPane2 = queuedNotifyCollectionChangedEventArgs.ItemsRemoved[j];
					if (splitPane2 != null)
					{
						this._dockManager.OnFloatingPaneRemoved(splitPane2);
					}
					j++;
				}
			}

			// Token: 0x0400041D RID: 1053
			private global::Infragistics.Windows.DockManager.QueuedObservableCollection<global::Infragistics.Windows.DockManager.SplitPane> _dockedPanes;

			// Token: 0x0400041E RID: 1054
			private global::Infragistics.Windows.DockManager.QueuedObservableCollection<global::Infragistics.Windows.DockManager.SplitPane> _floatingPanes;

			// Token: 0x0400041F RID: 1055
			private global::Infragistics.Windows.DockManager.XamDockManager _dockManager;

			// Token: 0x04000420 RID: 1056
			private global::System.Collections.ObjectModel.ReadOnlyObservableCollection<global::Infragistics.Windows.DockManager.SplitPane> _readOnlyDockedPanes;

			// Token: 0x04000421 RID: 1057
			private global::System.Collections.ObjectModel.ReadOnlyObservableCollection<global::Infragistics.Windows.DockManager.SplitPane> _readOnlyFloatingPanes;
		}

		// Token: 0x020000D9 RID: 217
		private class RootPaneList : global::System.Collections.IList, global::System.Collections.ICollection, global::System.Collections.IEnumerable
		{
			// Token: 0x06000835 RID: 2101 RVA: 0x000269BE File Offset: 0x00024BBE
			internal RootPaneList(global::Infragistics.Windows.DockManager.XamDockManager dockManager)
			{
				this._dockManager = dockManager;
				this._unpinnedTabAreas = new global::System.Collections.Generic.List<global::Infragistics.Windows.DockManager.UnpinnedTabArea>(4);
				this.RefreshTabAreas();
			}

			// Token: 0x1700023B RID: 571
			// (get) Token: 0x06000836 RID: 2102 RVA: 0x000269DF File Offset: 0x00024BDF
			private global::System.Collections.IList DockedPanes
			{
				get
				{
					return ((global::Infragistics.Windows.DockManager.XamDockManager.PanesCollection)this._dockManager.Panes).DockedPanes;
				}
			}

			// Token: 0x1700023C RID: 572
			// (get) Token: 0x06000837 RID: 2103 RVA: 0x000269F6 File Offset: 0x00024BF6
			private global::Infragistics.Windows.DockManager.DocumentContentHost DocumentHost
			{
				get
				{
					if (!this._dockManager.HasDocumentContentHost)
					{
						return null;
					}
					return (global::Infragistics.Windows.DockManager.DocumentContentHost)this._dockManager.Content;
				}
			}

			// Token: 0x1700023D RID: 573
			// (get) Token: 0x06000838 RID: 2104 RVA: 0x00026A17 File Offset: 0x00024C17
			private global::System.Collections.IList ToolWindows
			{
				get
				{
					return this._dockManager._toolWindows;
				}
			}

			// Token: 0x1700023E RID: 574
			// (get) Token: 0x06000839 RID: 2105 RVA: 0x00026A24 File Offset: 0x00024C24
			private global::System.Collections.IList UnpinnedTabAreas
			{
				get
				{
					return this._unpinnedTabAreas;
				}
			}

			// Token: 0x0600083A RID: 2106 RVA: 0x00026A2C File Offset: 0x00024C2C
			internal void RefreshTabAreas()
			{
				this._unpinnedTabAreas.Clear();
				foreach (global::Infragistics.Windows.DockManager.UnpinnedTabAreaInfo unpinnedTabAreaInfo in this._dockManager._tabAreaInfos)
				{
					if (unpinnedTabAreaInfo.TabArea != null)
					{
						this._unpinnedTabAreas.Add(unpinnedTabAreaInfo.TabArea);
					}
				}
			}

			// Token: 0x0600083B RID: 2107 RVA: 0x00026A7B File Offset: 0x00024C7B
			public int Add(object value)
			{
				throw new global::System.NotSupportedException();
			}

			// Token: 0x0600083C RID: 2108 RVA: 0x00026A82 File Offset: 0x00024C82
			public void Clear()
			{
				throw new global::System.NotSupportedException();
			}

			// Token: 0x0600083D RID: 2109 RVA: 0x00026A89 File Offset: 0x00024C89
			public bool Contains(object value)
			{
				return this.IndexOf(value) >= 0;
			}

			// Token: 0x0600083E RID: 2110 RVA: 0x00026A98 File Offset: 0x00024C98
			public int IndexOf(object value)
			{
				int num = 0;
				int num2 = -1;
				if (value is global::Infragistics.Windows.DockManager.UnpinnedTabArea)
				{
					num2 = this.UnpinnedTabAreas.IndexOf(value);
				}
				if (num2 < 0)
				{
					num += this.UnpinnedTabAreas.Count;
					num2 = this.DockedPanes.IndexOf(value);
					if (num2 < 0)
					{
						num += this.DockedPanes.Count;
						if (this.DocumentHost != null)
						{
							if (value is global::Infragistics.Windows.DockManager.DocumentContentHost)
							{
								num2 = 0;
							}
							else
							{
								num++;
							}
						}
						if (num2 < 0)
						{
							num2 = this.ToolWindows.IndexOf(value);
						}
					}
				}
				if (num2 >= 0)
				{
					num2 += num;
				}
				return num2;
			}

			// Token: 0x0600083F RID: 2111 RVA: 0x00026B21 File Offset: 0x00024D21
			public void Insert(int index, object value)
			{
				throw new global::System.NotSupportedException();
			}

			// Token: 0x1700023F RID: 575
			// (get) Token: 0x06000840 RID: 2112 RVA: 0x00026B28 File Offset: 0x00024D28
			public bool IsFixedSize
			{
				get
				{
					return false;
				}
			}

			// Token: 0x17000240 RID: 576
			// (get) Token: 0x06000841 RID: 2113 RVA: 0x00026B2B File Offset: 0x00024D2B
			public bool IsReadOnly
			{
				get
				{
					return true;
				}
			}

			// Token: 0x06000842 RID: 2114 RVA: 0x00026B2E File Offset: 0x00024D2E
			public void Remove(object value)
			{
				throw new global::System.NotSupportedException();
			}

			// Token: 0x06000843 RID: 2115 RVA: 0x00026B35 File Offset: 0x00024D35
			public void RemoveAt(int index)
			{
				throw new global::System.NotSupportedException();
			}

			// Token: 0x17000241 RID: 577
			public object this[int index]
			{
				get
				{
					if (index < this._unpinnedTabAreas.Count)
					{
						return this._unpinnedTabAreas[index];
					}
					index -= this._unpinnedTabAreas.Count;
					if (index < this.DockedPanes.Count)
					{
						return this.DockedPanes[index];
					}
					index -= this.DockedPanes.Count;
					if (this.DocumentHost != null)
					{
						if (index == 0)
						{
							return this.DocumentHost;
						}
						index--;
					}
					return this._dockManager._toolWindows[index];
				}
				set
				{
					throw new global::System.NotSupportedException();
				}
			}

			// Token: 0x06000846 RID: 2118 RVA: 0x00026BCC File Offset: 0x00024DCC
			public void CopyTo(global::System.Array array, int index)
			{
				global::Infragistics.Windows.DockManager.DockManagerUtilities.ThrowIfNull(array, "array");
				if (index < 0)
				{
					throw new global::System.IndexOutOfRangeException();
				}
				this.UnpinnedTabAreas.CopyTo(array, index);
				index += this._unpinnedTabAreas.Count;
				this.DockedPanes.CopyTo(array, index);
				index += this.DockedPanes.Count;
				if (this.DocumentHost != null)
				{
					array.SetValue(this.DocumentHost, index);
					index++;
				}
				this.ToolWindows.CopyTo(array, index);
			}

			// Token: 0x17000242 RID: 578
			// (get) Token: 0x06000847 RID: 2119 RVA: 0x00026C50 File Offset: 0x00024E50
			public int Count
			{
				get
				{
					int num = this.UnpinnedTabAreas.Count + this.DockedPanes.Count + this.ToolWindows.Count;
					if (this.DocumentHost != null)
					{
						num++;
					}
					return num;
				}
			}

			// Token: 0x17000243 RID: 579
			// (get) Token: 0x06000848 RID: 2120 RVA: 0x00026C8E File Offset: 0x00024E8E
			public bool IsSynchronized
			{
				get
				{
					return false;
				}
			}

			// Token: 0x17000244 RID: 580
			// (get) Token: 0x06000849 RID: 2121 RVA: 0x00026C91 File Offset: 0x00024E91
			public object SyncRoot
			{
				get
				{
					return typeof(global::Infragistics.Windows.DockManager.XamDockManager.RootPaneList);
				}
			}

			// Token: 0x0600084A RID: 2122 RVA: 0x00026CA0 File Offset: 0x00024EA0
			public global::System.Collections.IEnumerator GetEnumerator()
			{
				return new global::Infragistics.Collections.MultiSourceEnumerator(new global::System.Collections.IEnumerator[]
				{
					this.UnpinnedTabAreas.GetEnumerator(),
					this.DockedPanes.GetEnumerator(),
					new global::Infragistics.Collections.SingleItemEnumerator(this.DocumentHost),
					this.ToolWindows.GetEnumerator()
				});
			}

			// Token: 0x04000422 RID: 1058
			private global::Infragistics.Windows.DockManager.XamDockManager _dockManager;

			// Token: 0x04000423 RID: 1059
			private global::System.Collections.Generic.List<global::Infragistics.Windows.DockManager.UnpinnedTabArea> _unpinnedTabAreas;
		}

		// Token: 0x020000DA RID: 218
		private class HwndSourceHelper : global::System.Windows.DependencyObject
		{
			// Token: 0x0600084B RID: 2123 RVA: 0x00026CF2 File Offset: 0x00024EF2
			internal HwndSourceHelper(global::Infragistics.Windows.DockManager.XamDockManager element)
			{
				this._element = new global::System.WeakReference(element);
				this.CurrentSource = global::System.Windows.PresentationSource.FromVisual(element);
				global::System.Windows.PresentationSource.AddSourceChangedHandler(element, new global::System.Windows.SourceChangedEventHandler(this.OnSourceChanged));
			}

			// Token: 0x17000245 RID: 581
			// (get) Token: 0x0600084C RID: 2124 RVA: 0x00026D2B File Offset: 0x00024F2B
			// (set) Token: 0x0600084D RID: 2125 RVA: 0x00026D34 File Offset: 0x00024F34
			public global::System.Windows.PresentationSource CurrentSource
			{
				get
				{
					return this._currentSource;
				}
				private set
				{
					if (value != this._currentSource)
					{
						global::System.Windows.PresentationSource currentSource = this._currentSource;
						this._currentSource = value;
						this.HookUnhookSource(currentSource, false);
						this.HookUnhookSource(value, true);
						this.UpdateRootVisibilityBinding();
					}
				}
			}

			// Token: 0x0600084E RID: 2126 RVA: 0x00026D70 File Offset: 0x00024F70
			private static void OnRootVisualVisibilityChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
			{
				global::Infragistics.Windows.DockManager.XamDockManager.HwndSourceHelper hwndSourceHelper = d as global::Infragistics.Windows.DockManager.XamDockManager.HwndSourceHelper;
				hwndSourceHelper.RootVisualVisibility = (global::System.Windows.Visibility)e.NewValue;
			}

			// Token: 0x17000246 RID: 582
			// (get) Token: 0x0600084F RID: 2127 RVA: 0x00026D96 File Offset: 0x00024F96
			// (set) Token: 0x06000850 RID: 2128 RVA: 0x00026DA0 File Offset: 0x00024FA0
			public global::System.Windows.Visibility RootVisualVisibility
			{
				get
				{
					return this._cachedRootVisualVisibility;
				}
				private set
				{
					if (value != this._cachedRootVisualVisibility)
					{
						this._cachedRootVisualVisibility = value;
						global::Infragistics.Windows.DockManager.XamDockManager xamDockManager = global::Infragistics.CoreUtilities.GetWeakReferenceTargetSafe(this._element) as global::Infragistics.Windows.DockManager.XamDockManager;
						if (xamDockManager != null)
						{
							xamDockManager.OnRootVisualVisibilityChanged();
						}
					}
				}
			}

			// Token: 0x06000851 RID: 2129 RVA: 0x00026DD8 File Offset: 0x00024FD8
			private static void OnRootVisualWindowStateChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
			{
				global::Infragistics.Windows.DockManager.XamDockManager.HwndSourceHelper hwndSourceHelper = d as global::Infragistics.Windows.DockManager.XamDockManager.HwndSourceHelper;
				hwndSourceHelper.RootVisualWindowState = (global::System.Windows.WindowState?)e.NewValue;
			}

			// Token: 0x17000247 RID: 583
			// (get) Token: 0x06000852 RID: 2130 RVA: 0x00026DFE File Offset: 0x00024FFE
			// (set) Token: 0x06000853 RID: 2131 RVA: 0x00026E08 File Offset: 0x00025008
			public global::System.Windows.WindowState? RootVisualWindowState
			{
				get
				{
					return this._cachedRootVisualWindowState;
				}
				private set
				{
					if (value != this._cachedRootVisualWindowState)
					{
						this._cachedRootVisualWindowState = value;
						global::Infragistics.Windows.DockManager.XamDockManager xamDockManager = global::Infragistics.CoreUtilities.GetWeakReferenceTargetSafe(this._element) as global::Infragistics.Windows.DockManager.XamDockManager;
						if (xamDockManager != null)
						{
							xamDockManager.OnRootVisualVisibilityChanged();
						}
					}
				}
			}

			// Token: 0x06000854 RID: 2132 RVA: 0x00026E68 File Offset: 0x00025068
			private void HookUnhookSource(global::System.Windows.PresentationSource ps, bool hook)
			{
				if (ps == null)
				{
					return;
				}
				global::System.Windows.Interop.HwndSource hwndSource = ps as global::System.Windows.Interop.HwndSource;
				if (hook)
				{
					ps.ContentRendered += this.OnPresentationSourceContentRendered;
					if (hwndSource != null)
					{
						hwndSource.Disposed += this.OnHwndSourceDisposed;
						return;
					}
				}
				else
				{
					ps.ContentRendered -= this.OnPresentationSourceContentRendered;
					if (hwndSource != null)
					{
						hwndSource.Disposed -= this.OnHwndSourceDisposed;
					}
				}
			}

			// Token: 0x06000855 RID: 2133 RVA: 0x00026ED2 File Offset: 0x000250D2
			private void OnHwndSourceDisposed(object sender, global::System.EventArgs e)
			{
			}

			// Token: 0x06000856 RID: 2134 RVA: 0x00026ED4 File Offset: 0x000250D4
			private void OnPresentationSourceContentRendered(object sender, global::System.EventArgs e)
			{
				this.UpdateRootVisibilityBinding();
			}

			// Token: 0x06000857 RID: 2135 RVA: 0x00026EDC File Offset: 0x000250DC
			private void OnSourceChanged(object sender, global::System.Windows.SourceChangedEventArgs e)
			{
				this.CurrentSource = e.NewSource;
			}

			// Token: 0x06000858 RID: 2136 RVA: 0x00026EEC File Offset: 0x000250EC
			private void UpdateRootVisibilityBinding()
			{
				global::System.Windows.Media.Visual visual = (this._currentSource != null) ? this._currentSource.RootVisual : null;
				if (visual == null)
				{
					global::System.Windows.Data.BindingOperations.ClearBinding(this, global::Infragistics.Windows.DockManager.XamDockManager.HwndSourceHelper.RootVisualVisibilityProperty);
					this.RootVisualVisibility = global::System.Windows.Visibility.Collapsed;
				}
				else
				{
					global::System.Windows.Data.BindingOperations.SetBinding(this, global::Infragistics.Windows.DockManager.XamDockManager.HwndSourceHelper.RootVisualVisibilityProperty, global::Infragistics.Windows.Utilities.CreateBindingObject(global::System.Windows.UIElement.VisibilityProperty, global::System.Windows.Data.BindingMode.OneWay, visual));
					this.RootVisualVisibility = (global::System.Windows.Visibility)visual.GetValue(global::System.Windows.UIElement.VisibilityProperty);
				}
				if (!(visual is global::System.Windows.Window))
				{
					global::System.Windows.Data.BindingOperations.ClearBinding(this, global::Infragistics.Windows.DockManager.XamDockManager.HwndSourceHelper.RootVisualWindowStateProperty);
					this.RootVisualWindowState = null;
					return;
				}
				global::System.Windows.Data.BindingOperations.SetBinding(this, global::Infragistics.Windows.DockManager.XamDockManager.HwndSourceHelper.RootVisualWindowStateProperty, global::Infragistics.Windows.Utilities.CreateBindingObject(global::System.Windows.Window.WindowStateProperty, global::System.Windows.Data.BindingMode.OneWay, visual));
				this.RootVisualWindowState = new global::System.Windows.WindowState?((global::System.Windows.WindowState)visual.GetValue(global::System.Windows.Window.WindowStateProperty));
			}

			// Token: 0x04000424 RID: 1060
			private const global::System.Windows.Visibility DefaultRootVisualVisibility = global::System.Windows.Visibility.Collapsed;

			// Token: 0x04000425 RID: 1061
			private global::System.WeakReference _element;

			// Token: 0x04000426 RID: 1062
			private global::System.Windows.PresentationSource _currentSource;

			// Token: 0x04000427 RID: 1063
			private global::System.Windows.Visibility _cachedRootVisualVisibility = global::System.Windows.Visibility.Collapsed;

			// Token: 0x04000428 RID: 1064
			private global::System.Windows.WindowState? _cachedRootVisualWindowState;

			// Token: 0x04000429 RID: 1065
			private static readonly global::System.Windows.DependencyProperty RootVisualVisibilityProperty = global::System.Windows.DependencyProperty.Register("RootVisualVisibility", typeof(global::System.Windows.Visibility), typeof(global::Infragistics.Windows.DockManager.XamDockManager.HwndSourceHelper), new global::System.Windows.FrameworkPropertyMetadata(global::System.Windows.Visibility.Collapsed, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DockManager.XamDockManager.HwndSourceHelper.OnRootVisualVisibilityChanged)));

			// Token: 0x0400042A RID: 1066
			private static readonly global::System.Windows.DependencyProperty RootVisualWindowStateProperty = global::System.Windows.DependencyProperty.Register("RootVisualWindowState", typeof(global::System.Windows.WindowState?), typeof(global::Infragistics.Windows.DockManager.XamDockManager.HwndSourceHelper), new global::System.Windows.FrameworkPropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DockManager.XamDockManager.HwndSourceHelper.OnRootVisualWindowStateChanged)));
		}
	}
}
