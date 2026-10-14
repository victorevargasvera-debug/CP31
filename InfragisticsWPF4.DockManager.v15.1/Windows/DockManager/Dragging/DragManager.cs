using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Media;
using System.Windows.Threading;
using Infragistics.Windows.Controls;
using Infragistics.Windows.DockManager.Events;
using Infragistics.Windows.Helpers;
using Infragistics.Windows.Themes;

namespace Infragistics.Windows.DockManager.Dragging
{
	// Token: 0x02000038 RID: 56
	internal class DragManager
	{
		// Token: 0x060002FA RID: 762 RVA: 0x0000F588 File Offset: 0x0000D788
		static DragManager()
		{
			global::System.Windows.FrameworkElementFactory frameworkElementFactory = new global::System.Windows.FrameworkElementFactory(typeof(global::System.Windows.Controls.ContentPresenter));
			frameworkElementFactory.Name = "PART_Content";
			global::System.Windows.Controls.ControlTemplate controlTemplate = new global::System.Windows.Controls.ControlTemplate(typeof(global::Infragistics.Windows.Controls.ToolWindow));
			controlTemplate.VisualTree = frameworkElementFactory;
			controlTemplate.Seal();
			global::Infragistics.Windows.DockManager.Dragging.DragManager.IndicatorToolWindowTemplate = controlTemplate;
			global::System.Windows.FrameworkElementFactory frameworkElementFactory2 = new global::System.Windows.FrameworkElementFactory(typeof(global::System.Windows.Controls.Grid));
			global::System.Windows.FrameworkElementFactory frameworkElementFactory3 = new global::System.Windows.FrameworkElementFactory(typeof(global::System.Windows.Controls.ContentPresenter));
			frameworkElementFactory3.Name = "PART_Content";
			frameworkElementFactory2.SetValue(global::System.Windows.Controls.Control.BackgroundProperty, global::System.Windows.Media.Brushes.White);
			frameworkElementFactory2.AppendChild(frameworkElementFactory3);
			global::System.Windows.Controls.ControlTemplate controlTemplate2 = new global::System.Windows.Controls.ControlTemplate(typeof(global::Infragistics.Windows.Controls.ToolWindow));
			controlTemplate2.VisualTree = frameworkElementFactory2;
			controlTemplate2.Seal();
			global::Infragistics.Windows.DockManager.Dragging.DragManager.IndicatorToolWindowTemplateWhite = controlTemplate2;
		}

		// Token: 0x060002FB RID: 763 RVA: 0x0000F63C File Offset: 0x0000D83C
		internal DragManager(global::Infragistics.Windows.DockManager.XamDockManager dockManager)
		{
			global::Infragistics.Windows.DockManager.DockManagerUtilities.ThrowIfNull(dockManager, "dockManager");
			this._dockManager = dockManager;
		}

		// Token: 0x1700009A RID: 154
		// (get) Token: 0x060002FC RID: 764 RVA: 0x0000F658 File Offset: 0x0000D858
		internal global::System.Windows.Size CurrentDragPaneSize
		{
			get
			{
				global::System.Windows.FrameworkElement frameworkElement = this._windowBeingDragged ?? this._rootDragElement;
				global::System.Windows.Size result = new global::System.Windows.Size(frameworkElement.ActualWidth, frameworkElement.ActualHeight);
				return result;
			}
		}

		// Token: 0x1700009B RID: 155
		// (get) Token: 0x060002FD RID: 765 RVA: 0x0000F68A File Offset: 0x0000D88A
		internal global::Infragistics.Windows.DockManager.XamDockManager DockManager
		{
			get
			{
				return this._dockManager;
			}
		}

		// Token: 0x1700009C RID: 156
		// (get) Token: 0x060002FE RID: 766 RVA: 0x0000F692 File Offset: 0x0000D892
		internal global::Infragistics.Windows.DockManager.Dragging.DragState DragState
		{
			get
			{
				return this._dragState;
			}
		}

		// Token: 0x1700009D RID: 157
		// (get) Token: 0x060002FF RID: 767 RVA: 0x0000F69C File Offset: 0x0000D89C
		private global::Infragistics.Windows.Controls.ToolWindow DropPreviewWindow
		{
			get
			{
				if (this._dropPreviewWindow == null)
				{
					global::Infragistics.Windows.Controls.ToolWindow toolWindow = global::Infragistics.Windows.DockManager.Dragging.DragManager.DragToolWindow.Create(this._dockManager);
					toolWindow.HorizontalAlignmentMode = global::Infragistics.Windows.Controls.ToolWindowAlignmentMode.UseAlignment;
					toolWindow.VerticalAlignmentMode = global::Infragistics.Windows.Controls.ToolWindowAlignmentMode.UseAlignment;
					toolWindow.IsHitTestVisible = false;
					global::System.Windows.Controls.Control control = new global::System.Windows.Controls.Control();
					control.HorizontalAlignment = global::System.Windows.HorizontalAlignment.Stretch;
					control.VerticalAlignment = global::System.Windows.VerticalAlignment.Stretch;
					control.SetResourceReference(global::System.Windows.FrameworkElement.StyleProperty, global::Infragistics.Windows.DockManager.XamDockManager.DropPreviewStyleKey);
					toolWindow.Topmost = true;
					toolWindow.Content = control;
					this._dropPreviewWindow = toolWindow;
				}
				return this._dropPreviewWindow;
			}
		}

		// Token: 0x1700009E RID: 158
		// (get) Token: 0x06000300 RID: 768 RVA: 0x0000F711 File Offset: 0x0000D911
		internal global::Infragistics.Windows.Controls.ToolWindow FloatingWindow
		{
			get
			{
				if (this.DeferFloatingWindowPositioning)
				{
					return this._floatingPreviewWindow;
				}
				return this.WindowBeingDragged;
			}
		}

		// Token: 0x1700009F RID: 159
		// (get) Token: 0x06000301 RID: 769 RVA: 0x0000F728 File Offset: 0x0000D928
		internal global::System.Windows.FrameworkElement GlobalIndicatorsElement
		{
			get
			{
				if (this._isDraggingDocuments)
				{
					return this._dockManager.DocumentContentHost;
				}
				return this._dockManager.DockPanel ?? this._dockManager;
			}
		}

		// Token: 0x170000A0 RID: 160
		// (get) Token: 0x06000302 RID: 770 RVA: 0x0000F753 File Offset: 0x0000D953
		private static bool IsControlKeyDown
		{
			get
			{
				return (global::System.Windows.Input.Keyboard.Modifiers & global::System.Windows.Input.ModifierKeys.Control) == global::System.Windows.Input.ModifierKeys.Control;
			}
		}

		// Token: 0x170000A1 RID: 161
		// (get) Token: 0x06000303 RID: 771 RVA: 0x0000F75F File Offset: 0x0000D95F
		internal bool IsDragging
		{
			get
			{
				return this._dragState == global::Infragistics.Windows.DockManager.Dragging.DragState.Dragging;
			}
		}

		// Token: 0x170000A2 RID: 162
		// (get) Token: 0x06000304 RID: 772 RVA: 0x0000F76A File Offset: 0x0000D96A
		internal bool IsDragPending
		{
			get
			{
				return this._dragState == global::Infragistics.Windows.DockManager.Dragging.DragState.Pending;
			}
		}

		// Token: 0x170000A3 RID: 163
		// (get) Token: 0x06000305 RID: 773 RVA: 0x0000F775 File Offset: 0x0000D975
		internal bool IsForcedFloatingDrag
		{
			get
			{
				return this._forceFloating;
			}
		}

		// Token: 0x170000A4 RID: 164
		// (get) Token: 0x06000306 RID: 774 RVA: 0x0000F77D File Offset: 0x0000D97D
		// (set) Token: 0x06000307 RID: 775 RVA: 0x0000F788 File Offset: 0x0000D988
		internal bool IsInWindowDragMode
		{
			get
			{
				return this._isWindowDragMode;
			}
			set
			{
				if (value != this._isWindowDragMode)
				{
					this._isWindowDragMode = value;
					if (value && this._windowDragModeKeyTimer == null && !this._forceFloating)
					{
						this._windowDragModeKeyTimer = new global::System.Threading.Timer(new global::System.Threading.TimerCallback(this.OnWindowDragModeKeyTimerTick), null, 0, 250);
						return;
					}
					if (!value && this._windowDragModeKeyTimer != null)
					{
						this._windowDragModeKeyTimer.Dispose();
						this._windowDragModeKeyTimer = null;
					}
				}
			}
		}

		// Token: 0x170000A5 RID: 165
		// (get) Token: 0x06000308 RID: 776 RVA: 0x0000F7F4 File Offset: 0x0000D9F4
		internal global::System.Windows.FrameworkElement OriginalRootContainer
		{
			get
			{
				return this._rootDragElement;
			}
		}

		// Token: 0x170000A6 RID: 166
		// (get) Token: 0x06000309 RID: 777 RVA: 0x0000F7FC File Offset: 0x0000D9FC
		internal global::System.Collections.ObjectModel.ReadOnlyCollection<global::Infragistics.Windows.DockManager.ContentPane> PanesBeingDragged
		{
			get
			{
				return this._panesBeingDragged;
			}
		}

		// Token: 0x170000A7 RID: 167
		// (get) Token: 0x0600030A RID: 778 RVA: 0x0000F804 File Offset: 0x0000DA04
		internal global::Infragistics.Windows.DockManager.TabItemDragBehavior TabItemDragBehavior
		{
			get
			{
				return this._tabItemDragBehavior;
			}
		}

		// Token: 0x170000A8 RID: 168
		// (get) Token: 0x0600030B RID: 779 RVA: 0x0000F80C File Offset: 0x0000DA0C
		private global::Infragistics.Windows.Controls.ToolWindow TabItemDropPreviewWindow
		{
			get
			{
				if (this._tabItemDropPreviewWindow == null)
				{
					global::Infragistics.Windows.Controls.ToolWindow toolWindow = global::Infragistics.Windows.DockManager.Dragging.DragManager.DragToolWindow.Create(this._dockManager);
					toolWindow.HorizontalAlignmentMode = global::Infragistics.Windows.Controls.ToolWindowAlignmentMode.Manual;
					toolWindow.VerticalAlignmentMode = global::Infragistics.Windows.Controls.ToolWindowAlignmentMode.Manual;
					toolWindow.IsHitTestVisible = false;
					global::System.Windows.Controls.Control control = new global::Infragistics.Windows.Controls.DropIndicator();
					control.HorizontalAlignment = global::System.Windows.HorizontalAlignment.Stretch;
					control.VerticalAlignment = global::System.Windows.VerticalAlignment.Stretch;
					toolWindow.Topmost = true;
					toolWindow.Content = control;
					this._tabItemDropPreviewWindow = toolWindow;
					global::Infragistics.Windows.DockManager.DockManagerUtilities.ApplyTemplateRecursively(toolWindow);
				}
				return this._tabItemDropPreviewWindow;
			}
		}

		// Token: 0x170000A9 RID: 169
		// (get) Token: 0x0600030C RID: 780 RVA: 0x0000F877 File Offset: 0x0000DA77
		internal bool DeferFloatingWindowPositioning
		{
			get
			{
				return this._deferFloatingWindowPositioning;
			}
		}

		// Token: 0x170000AA RID: 170
		// (get) Token: 0x0600030D RID: 781 RVA: 0x0000F87F File Offset: 0x0000DA7F
		internal global::Infragistics.Windows.DockManager.PaneToolWindow WindowBeingDragged
		{
			get
			{
				return this._windowBeingDragged;
			}
		}

		// Token: 0x0600030E RID: 782 RVA: 0x0000F888 File Offset: 0x0000DA88
		internal global::Infragistics.Windows.DockManager.SplitPane CloneRootDragElement(global::Infragistics.Windows.DockManager.PaneLocation newLocation, global::System.Action<global::Infragistics.Windows.DockManager.SplitPane> initializeNewSplit)
		{
			global::Infragistics.Windows.DockManager.SplitPane splitPane = global::Infragistics.Windows.DockManager.DockManagerUtilities.CreateSplitPane(this._dockManager);
			using (global::Infragistics.Windows.DockManager.MovePaneHelper movePaneHelper = new global::Infragistics.Windows.DockManager.MovePaneHelper(this._dockManager, splitPane, new global::Infragistics.Windows.DockManager.ContentPane[0]))
			{
				if (initializeNewSplit != null)
				{
					initializeNewSplit(splitPane);
				}
				if (this._rootDragElement is global::Infragistics.Windows.DockManager.TabGroupPane || this._rootDragElement is global::Infragistics.Windows.DockManager.ContentPane)
				{
					if (this._rootDragElement is global::Infragistics.Windows.DockManager.ContentPane)
					{
						global::Infragistics.Windows.DockManager.DockManagerUtilities.MovePane((global::Infragistics.Windows.DockManager.ContentPane)this._rootDragElement, splitPane, null, newLocation, movePaneHelper);
					}
					else
					{
						global::Infragistics.Windows.DockManager.TabGroupPane tabGroupPane = global::Infragistics.Windows.DockManager.DockManagerUtilities.CreateTabGroup(this._dockManager);
						splitPane.Panes.Add(tabGroupPane);
						global::Infragistics.Windows.DockManager.DockManagerUtilities.Clone(this._rootDragElement as global::Infragistics.Windows.DockManager.TabGroupPane, newLocation, tabGroupPane, movePaneHelper);
					}
				}
				else
				{
					global::Infragistics.Windows.DockManager.SplitPane splitPane2;
					if (this._windowBeingDragged != null)
					{
						splitPane2 = (this._windowBeingDragged.Content as global::Infragistics.Windows.DockManager.SplitPane);
					}
					else
					{
						splitPane2 = (this._rootDragElement as global::Infragistics.Windows.DockManager.SplitPane);
					}
					if (splitPane2 == null)
					{
						return null;
					}
					global::Infragistics.Windows.DockManager.DockManagerUtilities.Clone(splitPane2, newLocation, splitPane, movePaneHelper);
				}
			}
			return splitPane;
		}

		// Token: 0x0600030F RID: 783 RVA: 0x0000F98C File Offset: 0x0000DB8C
		internal void CreateFloatingPreviewWindow(global::System.Windows.Point point, global::System.Windows.Size size)
		{
			if (this._floatingPreviewWindow == null)
			{
				this._floatingPreviewWindow = global::Infragistics.Windows.DockManager.Dragging.DragManager.DragToolWindow.Create(this._dockManager);
				this._floatingPreviewWindow.IsHitTestVisible = false;
				this._floatingPreviewWindow.Left = point.X;
				this._floatingPreviewWindow.Top = point.Y;
				this._floatingPreviewWindow.Width = size.Width;
				this._floatingPreviewWindow.Height = size.Height;
				global::System.Windows.Controls.Control control = new global::System.Windows.Controls.Control();
				control.HorizontalAlignment = global::System.Windows.HorizontalAlignment.Stretch;
				control.VerticalAlignment = global::System.Windows.VerticalAlignment.Stretch;
				control.SetResourceReference(global::System.Windows.FrameworkElement.StyleProperty, global::Infragistics.Windows.DockManager.XamDockManager.FloatingWindowPreviewStyleKey);
				this._floatingPreviewWindow.Content = control;
				global::Infragistics.Windows.DockManager.PaneLocation value = (this._initialDragElement != null) ? global::Infragistics.Windows.DockManager.XamDockManager.GetPaneLocation(this._initialDragElement) : global::Infragistics.Windows.DockManager.PaneLocation.Unknown;
				control.SetValue(global::Infragistics.Windows.DockManager.XamDockManager.PaneLocationPropertyKey, global::Infragistics.Windows.DockManager.DockManagerKnownBoxes.FromValue(value));
				global::Infragistics.Windows.DockManager.DockManagerUtilities.ShowToolWindow(this._floatingPreviewWindow, this._dockManager, false);
				this._floatingPreviewWindow.BringToFront();
				return;
			}
			this._floatingPreviewWindow.Width = size.Width;
			this._floatingPreviewWindow.Height = size.Height;
			this._floatingPreviewWindow.Top = point.Y;
			this._floatingPreviewWindow.Left = point.X;
		}

		// Token: 0x06000310 RID: 784 RVA: 0x0000FB0C File Offset: 0x0000DD0C
		internal void CreateWindowBeingDragged(global::System.Windows.Point location, global::System.Windows.Size size)
		{
			if (this._windowBeingDragged == null && (this._rootDragElement is global::Infragistics.Windows.DockManager.ContentPane || this._rootDragElement is global::Infragistics.Windows.DockManager.TabGroupPane))
			{
				global::System.Windows.IInputElement focusedElement = global::System.Windows.Input.Keyboard.FocusedElement;
				bool flag = focusedElement is global::System.Windows.DependencyObject && (focusedElement == this._rootDragElement || global::Infragistics.Windows.Utilities.IsDescendantOf(this._rootDragElement, focusedElement as global::System.Windows.DependencyObject));
				if (flag && this._mouseCaptureHelper != null)
				{
					global::System.Windows.Input.Keyboard.Focus(this._mouseCaptureHelper);
				}
				global::System.Collections.Generic.IList<global::Infragistics.Windows.DockManager.IContentPaneContainer> dragPaneContainers = this.GetDragPaneContainers();
				global::System.Action<global::Infragistics.Windows.DockManager.SplitPane> initializeNewSplit = delegate(global::Infragistics.Windows.DockManager.SplitPane split)
				{
					global::Infragistics.Windows.DockManager.XamDockManager.SetInitialLocation(split, global::Infragistics.Windows.DockManager.InitialPaneLocation.DockableFloating);
					global::Infragistics.Windows.DockManager.XamDockManager.SetFloatingLocation(split, new global::System.Windows.Point?(location));
					global::Infragistics.Windows.DockManager.XamDockManager.SetFloatingSize(split, size);
					this._dockManager.Panes.Add(split);
				};
				global::Infragistics.Windows.DockManager.SplitPane d = this.CloneRootDragElement(global::Infragistics.Windows.DockManager.PaneLocation.Floating, initializeNewSplit);
				this._windowBeingDragged = (global::Infragistics.Windows.Controls.ToolWindow.GetToolWindow(d) as global::Infragistics.Windows.DockManager.PaneToolWindow);
				if (this._lastActivePane != null)
				{
					global::Infragistics.Windows.DockManager.PaneToolWindow paneToolWindow = global::Infragistics.Windows.Controls.ToolWindow.GetToolWindow(this._lastActivePane) as global::Infragistics.Windows.DockManager.PaneToolWindow;
					if (paneToolWindow != null && paneToolWindow == this._windowBeingDragged)
					{
						paneToolWindow.LastActivePane = this._lastActivePane;
					}
				}
				this.FixPlaceholders();
				global::Infragistics.Windows.DockManager.DockManagerUtilities.RemoveContainersIfNeeded(dragPaneContainers);
				if (flag)
				{
					global::Infragistics.Windows.DockManager.ContentPane contentPane = (focusedElement as global::Infragistics.Windows.DockManager.ContentPane) ?? (global::Infragistics.Windows.Utilities.GetAncestorFromType((global::System.Windows.DependencyObject)focusedElement, typeof(global::Infragistics.Windows.DockManager.ContentPane), true, this._rootDragElement) as global::Infragistics.Windows.DockManager.ContentPane);
					if (contentPane != null)
					{
						contentPane.ActivateInternal(true);
					}
					if (contentPane != focusedElement)
					{
						focusedElement.Focus();
					}
				}
				if (this._dragState != global::Infragistics.Windows.DockManager.Dragging.DragState.ProcessingDrop && this._windowBeingDragged != null && this._windowBeingDragged.Host != null && this._windowBeingDragged.Host.IsWindow)
				{
					if (this._dockManager.FloatingWindowDragMode == global::Infragistics.Windows.DockManager.FloatingWindowDragMode.UseSystemWindowDrag)
					{
						this.SwitchToWindowDrag();
						return;
					}
					global::System.Windows.FrameworkContentElement dragHelper = this._windowBeingDragged.DragHelper;
					if (global::System.Windows.Input.Keyboard.FocusedElement == this._mouseCaptureHelper)
					{
						dragHelper.Focus();
					}
					if (this._dragState == global::Infragistics.Windows.DockManager.Dragging.DragState.Dragging)
					{
						if (this._mouseCaptureHelper != null)
						{
							this.SetDragCaptureHelper(null);
						}
						dragHelper.CaptureMouse();
						if (this._dragState == global::Infragistics.Windows.DockManager.Dragging.DragState.Dragging)
						{
							this.SetDragCaptureHelper(dragHelper);
						}
					}
				}
			}
		}

		// Token: 0x06000311 RID: 785 RVA: 0x0000FD0C File Offset: 0x0000DF0C
		internal static global::Infragistics.Windows.DockManager.Dragging.AllowedDropLocations GetDropLocation(global::Infragistics.Windows.DockManager.PaneLocation location)
		{
			switch (location)
			{
			default:
				return (global::Infragistics.Windows.DockManager.Dragging.AllowedDropLocations)0;
			case global::Infragistics.Windows.DockManager.PaneLocation.DockedLeft:
				return global::Infragistics.Windows.DockManager.Dragging.AllowedDropLocations.Left;
			case global::Infragistics.Windows.DockManager.PaneLocation.DockedRight:
				return global::Infragistics.Windows.DockManager.Dragging.AllowedDropLocations.Right;
			case global::Infragistics.Windows.DockManager.PaneLocation.DockedTop:
				return global::Infragistics.Windows.DockManager.Dragging.AllowedDropLocations.Top;
			case global::Infragistics.Windows.DockManager.PaneLocation.DockedBottom:
				return global::Infragistics.Windows.DockManager.Dragging.AllowedDropLocations.Bottom;
			case global::Infragistics.Windows.DockManager.PaneLocation.Floating:
				return global::Infragistics.Windows.DockManager.Dragging.AllowedDropLocations.Floating;
			case global::Infragistics.Windows.DockManager.PaneLocation.Document:
				return global::Infragistics.Windows.DockManager.Dragging.AllowedDropLocations.Document;
			}
		}

		// Token: 0x06000312 RID: 786 RVA: 0x0000FD54 File Offset: 0x0000DF54
		internal global::System.Windows.Size GetMoveToSplitPaneRelativeSize(global::System.Windows.FrameworkElement newGroup)
		{
			global::System.Windows.FrameworkElement d;
			if (this._panesBeingDragged.Count == 1)
			{
				d = this._panesBeingDragged[0];
			}
			else if (this._rootDragElement is global::Infragistics.Windows.DockManager.TabGroupPane)
			{
				d = this._rootDragElement;
			}
			else
			{
				if (this._windowBeingDragged == null)
				{
					return new global::System.Windows.Size(100.0, 100.0);
				}
				d = (this._windowBeingDragged.Pane ?? this._windowBeingDragged);
			}
			return global::Infragistics.Windows.DockManager.SplitPane.GetRelativeSize(d);
		}

		// Token: 0x06000313 RID: 787 RVA: 0x0000FDD2 File Offset: 0x0000DFD2
		internal global::System.Collections.Generic.IList<global::Infragistics.Windows.DockManager.IContentPaneContainer> GetDragPaneContainers()
		{
			return global::Infragistics.Windows.DockManager.DockManagerUtilities.GetPaneContainers(this._panesBeingDragged);
		}

		// Token: 0x06000314 RID: 788 RVA: 0x0000FDDF File Offset: 0x0000DFDF
		internal static global::System.Windows.Controls.ControlTemplate GetIndicatorToolWindowTemplate(global::Infragistics.Windows.DockManager.XamDockManager dm)
		{
			if (dm == null || !dm.ShowToolWindowsInPopup || !global::Infragistics.Windows.DockManager.DockManagerUtilities.IsPopupInChildWindow)
			{
				return global::Infragistics.Windows.DockManager.Dragging.DragManager.IndicatorToolWindowTemplate;
			}
			return global::Infragistics.Windows.DockManager.Dragging.DragManager.IndicatorToolWindowTemplateWhite;
		}

		// Token: 0x06000315 RID: 789 RVA: 0x0000FE00 File Offset: 0x0000E000
		internal static global::System.Collections.Generic.IList<global::Infragistics.Windows.DockManager.ContentPane> GetPanesForDragElement(global::System.Windows.FrameworkElement rootPane, out global::System.Windows.FrameworkElement rootContainerElement)
		{
			global::Infragistics.Windows.DockManager.XamDockManager dockManager = global::Infragistics.Windows.DockManager.XamDockManager.GetDockManager(rootPane);
			if (dockManager == null)
			{
				throw new global::System.ArgumentException(global::Infragistics.Windows.DockManager.XamDockManager.GetString("LE_ElementNotInDockManager"), "rootPane");
			}
			global::Infragistics.Windows.DockManager.ContentPane contentPane = rootPane as global::Infragistics.Windows.DockManager.ContentPane;
			if (contentPane == null)
			{
				global::Infragistics.Windows.DockManager.PaneTabItem paneTabItem = (rootPane as global::Infragistics.Windows.DockManager.PaneTabItem) ?? (global::Infragistics.Windows.Utilities.GetAncestorFromType(rootPane, typeof(global::Infragistics.Windows.DockManager.PaneTabItem), true, dockManager, typeof(global::Infragistics.Windows.DockManager.IPaneContainer)) as global::Infragistics.Windows.DockManager.PaneTabItem);
				if (paneTabItem != null)
				{
					contentPane = paneTabItem.Pane;
				}
				else
				{
					contentPane = (global::Infragistics.Windows.Utilities.GetAncestorFromType(rootPane, typeof(global::Infragistics.Windows.DockManager.ContentPane), true, dockManager, typeof(global::Infragistics.Windows.DockManager.IPaneContainer)) as global::Infragistics.Windows.DockManager.ContentPane);
					if (contentPane != null && global::Infragistics.Windows.DockManager.DockManagerUtilities.GetParentPane(contentPane) is global::Infragistics.Windows.DockManager.TabGroupPane)
					{
						contentPane = null;
					}
				}
			}
			global::System.Collections.Generic.IList<global::Infragistics.Windows.DockManager.ContentPane> list;
			if (contentPane != null)
			{
				rootContainerElement = contentPane;
				list = new global::Infragistics.Windows.DockManager.ContentPane[]
				{
					contentPane
				};
			}
			else
			{
				list = new global::System.Collections.Generic.List<global::Infragistics.Windows.DockManager.ContentPane>();
				global::Infragistics.Windows.DockManager.IPaneContainer paneContainer = (rootPane as global::Infragistics.Windows.DockManager.IPaneContainer) ?? global::Infragistics.Windows.DockManager.DockManagerUtilities.GetParentPane(rootPane);
				if (paneContainer == null)
				{
					throw new global::System.ArgumentException(global::Infragistics.Windows.DockManager.XamDockManager.GetString("LE_InvalidRootDragElement"));
				}
				rootContainerElement = (paneContainer as global::System.Windows.FrameworkElement);
				for (contentPane = global::Infragistics.Windows.DockManager.DockManagerUtilities.GetFirstLastPane(paneContainer as global::System.Windows.UIElement, true, global::Infragistics.Windows.DockManager.PaneFilterFlags.AllVisible); contentPane != null; contentPane = global::Infragistics.Windows.DockManager.DockManagerUtilities.GetNextPreviousPane(contentPane, false, true, paneContainer))
				{
					list.Add(contentPane);
				}
			}
			return list;
		}

		// Token: 0x06000316 RID: 790 RVA: 0x0000FF17 File Offset: 0x0000E117
		internal void HideDropPreview()
		{
			global::Infragistics.Windows.DockManager.Dragging.DragManager.HideToolWindow(this._dropPreviewWindow);
			global::Infragistics.Windows.DockManager.Dragging.DragManager.HideToolWindow(this._tabItemDropPreviewWindow);
		}

		// Token: 0x06000317 RID: 791 RVA: 0x0000FF2F File Offset: 0x0000E12F
		private static void HideToolWindow(global::Infragistics.Windows.Controls.ToolWindow toolWindow)
		{
			if (toolWindow != null && toolWindow.IsVisible)
			{
				toolWindow.Close();
			}
		}

		// Token: 0x06000318 RID: 792 RVA: 0x0000FF44 File Offset: 0x0000E144
		internal bool IsBeingDragged(global::Infragistics.Windows.DockManager.ContentPane pane)
		{
			foreach (global::Infragistics.Windows.DockManager.ContentPane contentPane in this._panesBeingDragged)
			{
				if (contentPane == pane)
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x06000319 RID: 793 RVA: 0x0000FF98 File Offset: 0x0000E198
		internal bool IsDropLocationAllowed(global::Infragistics.Windows.DockManager.PaneLocation location)
		{
			return this.IsDropLocationAllowed(global::Infragistics.Windows.DockManager.Dragging.DragManager.GetDropLocation(location));
		}

		// Token: 0x0600031A RID: 794 RVA: 0x0000FFA6 File Offset: 0x0000E1A6
		internal bool IsDropLocationAllowed(global::Infragistics.Windows.DockManager.Dragging.AllowedDropLocations location)
		{
			return (global::Infragistics.Windows.DockManager.Dragging.AllowedDropLocations)0 != (this._allowedLocations & location);
		}

		// Token: 0x0600031B RID: 795 RVA: 0x0000FFB8 File Offset: 0x0000E1B8
		internal void OnToolWindowClosing(global::Infragistics.Windows.DockManager.PaneToolWindow toolWindow)
		{
			if (this._dragState == global::Infragistics.Windows.DockManager.Dragging.DragState.ProcessingDrop)
			{
				this.AddForceRemainOpen(toolWindow);
				return;
			}
			if (toolWindow == null || toolWindow != this._rootDragElementToolWindow)
			{
				return;
			}
			if (this._dragState != global::Infragistics.Windows.DockManager.Dragging.DragState.Dragging)
			{
				return;
			}
			global::System.Windows.FrameworkContentElement mouseCaptureHelper = this._mouseCaptureHelper;
			if (mouseCaptureHelper == null || global::System.Windows.LogicalTreeHelper.GetParent(mouseCaptureHelper) != toolWindow)
			{
				return;
			}
			if (toolWindow.Pane != null && toolWindow.Pane.Visibility != global::System.Windows.Visibility.Collapsed)
			{
				return;
			}
			if (toolWindow.IsReshowing)
			{
				return;
			}
			if (toolWindow.Host != null && toolWindow.Host.IsWindow)
			{
				this.AddForceRemainOpen(this._rootDragElementToolWindow);
			}
			global::System.Windows.FrameworkContentElement dragHelper = this._dockManager.DragHelper;
			this.SetDragCaptureHelper(null);
			mouseCaptureHelper.ReleaseMouseCapture();
			dragHelper.CaptureMouse();
			if (this._dragState != global::Infragistics.Windows.DockManager.Dragging.DragState.Dragging)
			{
				return;
			}
			if (dragHelper.IsMouseCaptured)
			{
				this.SetDragCaptureHelper(dragHelper);
			}
			this._dockManager.ForceFocus(this._dockManager.DragHelper);
		}

		// Token: 0x0600031C RID: 796 RVA: 0x00010094 File Offset: 0x0000E294
		internal void MoveToNewRootSplitPane(global::System.Windows.Controls.Dock side, bool outerEdge, double thickness)
		{
			global::System.Collections.Generic.IList<global::Infragistics.Windows.DockManager.IContentPaneContainer> dragPaneContainers = this.GetDragPaneContainers();
			global::Infragistics.Windows.DockManager.PaneLocation dockedLocation = global::Infragistics.Windows.DockManager.DockManagerUtilities.GetDockedLocation(side);
			global::Infragistics.Windows.DockManager.SplitPane splitPane = global::Infragistics.Windows.DockManager.DockManagerUtilities.CreateSplitPane(this._dockManager);
			using (global::Infragistics.Windows.DockManager.MovePaneHelper movePaneHelper = new global::Infragistics.Windows.DockManager.MovePaneHelper(this._dockManager, splitPane, new global::Infragistics.Windows.DockManager.ContentPane[0]))
			{
				int index = outerEdge ? 0 : this._dockManager.Panes.Count;
				global::Infragistics.Windows.DockManager.InitialPaneLocation initialLocation = global::Infragistics.Windows.DockManager.DockManagerUtilities.GetInitialLocation(side);
				global::Infragistics.Windows.DockManager.XamDockManager.SetInitialLocation(splitPane, initialLocation);
				if (side == global::System.Windows.Controls.Dock.Left || side == global::System.Windows.Controls.Dock.Right)
				{
					splitPane.Width = thickness;
				}
				else
				{
					splitPane.Height = thickness;
				}
				this._dockManager.Panes.Insert(index, splitPane);
				this.MoveToSplitPane(splitPane, 0, dockedLocation, movePaneHelper);
			}
			global::Infragistics.Windows.DockManager.DockManagerUtilities.RemoveContainersIfNeeded(dragPaneContainers);
		}

		// Token: 0x0600031D RID: 797 RVA: 0x00010150 File Offset: 0x0000E350
		internal global::System.Windows.FrameworkElement MoveToSplitPane(global::Infragistics.Windows.DockManager.SplitPane splitPane, int index)
		{
			global::Infragistics.Windows.DockManager.PaneLocation paneLocation = global::Infragistics.Windows.DockManager.XamDockManager.GetPaneLocation(splitPane);
			global::System.Windows.FrameworkElement result;
			using (global::Infragistics.Windows.DockManager.MovePaneHelper movePaneHelper = new global::Infragistics.Windows.DockManager.MovePaneHelper(this._dockManager, splitPane, new global::Infragistics.Windows.DockManager.ContentPane[0]))
			{
				result = this.MoveToSplitPane(splitPane, index, paneLocation, movePaneHelper);
			}
			return result;
		}

		// Token: 0x0600031E RID: 798 RVA: 0x000101A0 File Offset: 0x0000E3A0
		internal bool OnWindowBeforeDrag(global::Infragistics.Windows.DockManager.PaneToolWindow paneToolWindow, global::System.Windows.Point pt, global::System.Windows.Input.MouseDevice mouse)
		{
			if (this.DragState == global::Infragistics.Windows.DockManager.Dragging.DragState.Dragging && paneToolWindow == this.FloatingWindow)
			{
				return true;
			}
			global::System.Windows.Point screenPoint = global::Infragistics.Windows.Utilities.PointToScreenSafe(paneToolWindow, pt);
			global::System.Windows.Point mouseDownPosition = pt;
			global::Infragistics.Windows.DockManager.Dragging.DragManager.AdjustDragPositionForToolWindow(paneToolWindow, screenPoint, ref mouseDownPosition);
			return this.StartDrag(paneToolWindow, mouseDownPosition, new global::Infragistics.Windows.DockManager.Dragging.DragManager.ScreenInputDeviceInfo(screenPoint), false, true);
		}

		// Token: 0x0600031F RID: 799 RVA: 0x000101E4 File Offset: 0x0000E3E4
		internal void OnWindowDragStart(global::Infragistics.Windows.Controls.ToolWindow paneToolWindow)
		{
		}

		// Token: 0x06000320 RID: 800 RVA: 0x000101E8 File Offset: 0x0000E3E8
		internal bool OnWindowDragEnd(global::Infragistics.Windows.Controls.ToolWindow toolWindow)
		{
			bool result = false;
			if (toolWindow == this.FloatingWindow)
			{
				if (this._dragState == global::Infragistics.Windows.DockManager.Dragging.DragState.Dragging)
				{
					result = true;
				}
				this.EndDrag(false);
			}
			return result;
		}

		// Token: 0x06000321 RID: 801 RVA: 0x00010213 File Offset: 0x0000E413
		internal void OnWindowDragging(global::Infragistics.Windows.Controls.ToolWindow toolWindow, global::System.Windows.Point pt, global::System.Windows.Input.MouseDevice mouse, global::System.Windows.Rect logicalScreenRect)
		{
			if (toolWindow == this.FloatingWindow)
			{
				this.ProcessDragMove(new global::Infragistics.Windows.DockManager.Dragging.DragManager.ScreenInputDeviceInfo(global::Infragistics.Windows.Utilities.PointToScreenSafe(toolWindow, pt)), new global::System.Windows.Rect?(logicalScreenRect));
			}
		}

		// Token: 0x06000322 RID: 802 RVA: 0x00010237 File Offset: 0x0000E437
		internal void OnWindowMoveCancelled(global::Infragistics.Windows.DockManager.PaneToolWindow paneToolWindow)
		{
			if (paneToolWindow == this.FloatingWindow)
			{
				this.EndDrag(true);
			}
		}

		// Token: 0x06000323 RID: 803 RVA: 0x00010249 File Offset: 0x0000E449
		internal static void ProcessMouseDown(global::System.Windows.FrameworkElement element, global::System.Windows.Input.MouseButtonEventArgs e)
		{
			if (global::Infragistics.Windows.DockManager.Dragging.DragManager.ProcessMouseDown(element, new global::Infragistics.Windows.DockManager.Dragging.DragManager.MouseArgsInputDeviceInfo(e)))
			{
				e.Handled = true;
			}
		}

		// Token: 0x06000324 RID: 804 RVA: 0x00010260 File Offset: 0x0000E460
		private static bool ProcessMouseDown(global::System.Windows.FrameworkElement element, global::Infragistics.Windows.DockManager.Dragging.DragManager.IInputDeviceInfo e)
		{
			global::Infragistics.Windows.DockManager.XamDockManager dockManager = global::Infragistics.Windows.DockManager.XamDockManager.GetDockManager(element);
			global::Infragistics.Windows.DockManager.Dragging.DragManager dragManager = (dockManager != null) ? dockManager.DragManager : null;
			global::Infragistics.Windows.DockManager.DockManagerUtilities.ThrowIfNull(element, "element");
			global::Infragistics.Windows.DockManager.PaneLocation paneLocation = global::Infragistics.Windows.DockManager.XamDockManager.GetPaneLocation(element);
			if (paneLocation == global::Infragistics.Windows.DockManager.PaneLocation.Unknown || paneLocation == global::Infragistics.Windows.DockManager.PaneLocation.Unpinned)
			{
				return false;
			}
			if (dragManager != null)
			{
				if ((e.ChangedButton ?? global::System.Windows.Input.MouseButton.Left) == global::System.Windows.Input.MouseButton.Left)
				{
					global::System.Windows.FrameworkElement frameworkElement;
					global::System.Collections.Generic.IList<global::Infragistics.Windows.DockManager.ContentPane> panesForDragElement = global::Infragistics.Windows.DockManager.Dragging.DragManager.GetPanesForDragElement(element, out frameworkElement);
					if (panesForDragElement == null || panesForDragElement.Count == 0)
					{
						return false;
					}
					global::Infragistics.Windows.DockManager.Dragging.AllowedDropLocations allowedDropLocations = dragManager.GetAllowedDropLocations(panesForDragElement);
					global::Infragistics.Windows.DockManager.PaneHeaderPresenter paneHeaderPresenter = element as global::Infragistics.Windows.DockManager.PaneHeaderPresenter;
					global::Infragistics.Windows.Controls.ToolWindow toolWindow = null;
					if (paneHeaderPresenter != null && paneHeaderPresenter.Pane != null)
					{
						global::Infragistics.Windows.Controls.ToolWindow singlePaneToolWindow;
						toolWindow = (singlePaneToolWindow = global::Infragistics.Windows.DockManager.PaneToolWindow.GetSinglePaneToolWindow(paneHeaderPresenter.Pane));
						if (singlePaneToolWindow != null && dockManager.FloatingWindowDragMode == global::Infragistics.Windows.DockManager.FloatingWindowDragMode.UseSystemWindowDrag)
						{
							if (dragManager.StartDrag(singlePaneToolWindow, e.GetPosition(singlePaneToolWindow), e, false, true) && dragManager.DragState == global::Infragistics.Windows.DockManager.Dragging.DragState.Dragging)
							{
								dragManager.SwitchToWindowDrag();
								return true;
							}
							return false;
						}
					}
					if (allowedDropLocations == (global::Infragistics.Windows.DockManager.Dragging.AllowedDropLocations)0 && (toolWindow == null || global::Infragistics.Windows.DockManager.XamDockManager.GetPaneLocation(toolWindow) != global::Infragistics.Windows.DockManager.PaneLocation.FloatingOnly))
					{
						return false;
					}
					if (element.CaptureMouse())
					{
						dragManager.HookElementPendingDrag(element);
						dragManager._dragState = global::Infragistics.Windows.DockManager.Dragging.DragState.Pending;
						dragManager._mouseDownLocation = new global::System.Windows.Point?(global::Infragistics.Windows.Utilities.PointToScreenSafe(element, e.GetPosition(element)));
						return true;
					}
				}
				else if (dragManager.DragState != global::Infragistics.Windows.DockManager.Dragging.DragState.None)
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x06000325 RID: 805 RVA: 0x00010394 File Offset: 0x0000E594
		internal void ShowDropPreview(global::System.Windows.FrameworkElement owner, global::Infragistics.Windows.DockManager.Dragging.DropPreviewTabLocation location, global::System.Windows.Size size, global::Infragistics.Windows.DockManager.PaneLocation targetLocation)
		{
			this.ShowDropPreview(owner, location, null, size, 0.0, 0.0, targetLocation);
		}

		// Token: 0x06000326 RID: 806 RVA: 0x000103C8 File Offset: 0x0000E5C8
		internal void ShowDropPreview(global::System.Windows.FrameworkElement owner, global::System.Windows.Controls.Dock side, global::System.Windows.Size size, double offset, global::Infragistics.Windows.DockManager.PaneLocation targetLocation)
		{
			bool flag = side == global::System.Windows.Controls.Dock.Left || side == global::System.Windows.Controls.Dock.Right;
			double offsetX = flag ? offset : 0.0;
			double offsetY = flag ? 0.0 : offset;
			this.ShowDropPreview(owner, global::Infragistics.Windows.DockManager.Dragging.DropPreviewTabLocation.None, new global::System.Windows.Controls.Dock?(side), size, offsetX, offsetY, targetLocation);
		}

		// Token: 0x06000327 RID: 807 RVA: 0x00010418 File Offset: 0x0000E618
		private void ShowDropPreview(global::System.Windows.FrameworkElement owner, global::Infragistics.Windows.DockManager.Dragging.DropPreviewTabLocation location, global::System.Windows.Controls.Dock? sideForNone, global::System.Windows.Size size, double offsetX, double offsetY, global::Infragistics.Windows.DockManager.PaneLocation targetLocation)
		{
			global::System.Windows.HorizontalAlignment horzAlign = global::System.Windows.HorizontalAlignment.Stretch;
			global::System.Windows.VerticalAlignment vertAlign = global::System.Windows.VerticalAlignment.Stretch;
			if (location == global::Infragistics.Windows.DockManager.Dragging.DropPreviewTabLocation.None && sideForNone != null)
			{
				switch (sideForNone.Value)
				{
				case global::System.Windows.Controls.Dock.Left:
				case global::System.Windows.Controls.Dock.Right:
					horzAlign = ((sideForNone == global::System.Windows.Controls.Dock.Left) ? global::System.Windows.HorizontalAlignment.Left : global::System.Windows.HorizontalAlignment.Right);
					break;
				case global::System.Windows.Controls.Dock.Top:
				case global::System.Windows.Controls.Dock.Bottom:
					vertAlign = ((sideForNone == global::System.Windows.Controls.Dock.Top) ? global::System.Windows.VerticalAlignment.Top : global::System.Windows.VerticalAlignment.Bottom);
					break;
				}
			}
			this.ShowDropPreview(owner, location, size, horzAlign, vertAlign, offsetX, offsetY, targetLocation);
		}

		// Token: 0x06000328 RID: 808 RVA: 0x000104A4 File Offset: 0x0000E6A4
		internal void ShowDropPreview(global::System.Windows.FrameworkElement owner, global::Infragistics.Windows.DockManager.Dragging.DropPreviewTabLocation location, global::System.Windows.Size size, global::System.Windows.HorizontalAlignment horzAlign, global::System.Windows.VerticalAlignment vertAlign, double offsetX, double offsetY, global::Infragistics.Windows.DockManager.PaneLocation targetLocation)
		{
			global::Infragistics.Windows.DockManager.Dragging.DragManager.HideToolWindow(this._tabItemDropPreviewWindow);
			global::Infragistics.Windows.Controls.ToolWindow dropPreviewWindow = this.DropPreviewWindow;
			global::System.Windows.Controls.Control control = dropPreviewWindow.Content as global::System.Windows.Controls.Control;
			if (dropPreviewWindow.Owner != owner)
			{
				dropPreviewWindow.Close();
			}
			if (!double.IsNaN(size.Width) && !double.IsInfinity(size.Width))
			{
				dropPreviewWindow.Width = size.Width;
			}
			else
			{
				dropPreviewWindow.ClearValue(global::System.Windows.FrameworkElement.WidthProperty);
			}
			if (!double.IsNaN(size.Height) && !double.IsInfinity(size.Height))
			{
				dropPreviewWindow.Height = size.Height;
			}
			else
			{
				dropPreviewWindow.ClearValue(global::System.Windows.FrameworkElement.HeightProperty);
			}
			dropPreviewWindow.VerticalAlignment = vertAlign;
			dropPreviewWindow.HorizontalAlignment = horzAlign;
			dropPreviewWindow.VerticalAlignmentOffset = offsetY;
			dropPreviewWindow.HorizontalAlignmentOffset = offsetX;
			control.SetValue(global::Infragistics.Windows.DockManager.XamDockManager.DropPreviewTabLocationPropertyKey, global::Infragistics.Windows.DockManager.DockManagerKnownBoxes.FromValue(location));
			control.SetValue(global::Infragistics.Windows.DockManager.XamDockManager.PaneLocationPropertyKey, global::Infragistics.Windows.DockManager.DockManagerKnownBoxes.FromValue(targetLocation));
			if (!dropPreviewWindow.IsVisible)
			{
				global::Infragistics.Windows.DockManager.DockManagerUtilities.ShowToolWindow(dropPreviewWindow, owner, false);
				this._bringWindowToFront = true;
				foreach (global::Infragistics.Windows.Controls.ToolWindow toolWindow in this._indicatorWindows)
				{
					if (toolWindow != null && toolWindow.IsVisible)
					{
						toolWindow.BringToFront();
					}
				}
			}
		}

		// Token: 0x06000329 RID: 809 RVA: 0x000105D4 File Offset: 0x0000E7D4
		internal bool ShowTabItemPreview(global::Infragistics.Windows.DockManager.TabGroupPane tabGroup, int index)
		{
			global::Infragistics.Windows.Controls.ToolWindow tabItemDropPreviewWindow = this.TabItemDropPreviewWindow;
			global::Infragistics.Windows.Controls.DropIndicator dropIndicator = tabItemDropPreviewWindow.Content as global::Infragistics.Windows.Controls.DropIndicator;
			global::System.Windows.FlowDirection flowDirection = tabGroup.FlowDirection;
			bool flag = tabGroup.TabStripPlacement == global::System.Windows.Controls.Dock.Top || tabGroup.TabStripPlacement == global::System.Windows.Controls.Dock.Bottom;
			global::System.Windows.Controls.TabItem tabItem = global::Infragistics.Windows.DockManager.DockManagerUtilities.GetItemContainer(tabGroup, index, true, false) as global::System.Windows.Controls.TabItem;
			global::System.Windows.Controls.TabItem tabItem2 = global::Infragistics.Windows.DockManager.DockManagerUtilities.GetItemContainer(tabGroup, index, false, true) as global::System.Windows.Controls.TabItem;
			bool flag2 = false;
			global::System.Windows.Controls.TabItem tabItem3;
			if (tabItem2 == null)
			{
				flag2 = true;
				tabItem3 = tabItem;
			}
			else
			{
				tabItem3 = tabItem2;
				if (tabItem != null)
				{
					int zindex = global::System.Windows.Controls.Panel.GetZIndex(tabItem);
					int zindex2 = global::System.Windows.Controls.Panel.GetZIndex(tabItem2);
					if (zindex > zindex2)
					{
						flag2 = true;
						tabItem3 = tabItem;
					}
				}
				else
				{
					tabItem3 = tabItem2;
				}
			}
			if (tabItem3 == null)
			{
				return false;
			}
			global::Infragistics.Windows.Controls.DropLocation dropLocation;
			if (!flag)
			{
				dropLocation = (flag2 ? global::Infragistics.Windows.Controls.DropLocation.BelowTarget : global::Infragistics.Windows.Controls.DropLocation.AboveTarget);
			}
			else
			{
				dropLocation = (flag2 ? global::Infragistics.Windows.Controls.DropLocation.RightOfTarget : global::Infragistics.Windows.Controls.DropLocation.LeftOfTarget);
			}
			global::System.Windows.Controls.TabItem tabItem4 = tabItem3;
			if (tabItemDropPreviewWindow.Owner != tabGroup || tabItemDropPreviewWindow.Tag != tabItem4 || dropLocation != dropIndicator.DropLocation)
			{
				dropIndicator.DropLocation = null;
				tabItemDropPreviewWindow.Close();
			}
			tabItemDropPreviewWindow.Tag = tabItem4;
			global::System.Windows.Media.GeneralTransform generalTransform = tabItem3.TransformToAncestor(tabGroup);
			global::System.Windows.Rect rect = global::System.Windows.Rect.Union(new global::System.Windows.Rect(tabItem3.RenderSize), global::System.Windows.Media.VisualTreeHelper.GetDescendantBounds(tabItem3));
			rect = generalTransform.TransformBounds(rect);
			global::System.Windows.Point point = global::Infragistics.Windows.Utilities.PointToScreenSafe(tabGroup, rect.TopLeft, null);
			global::System.Windows.Point point2 = global::Infragistics.Windows.Utilities.PointToScreenSafe(tabGroup, rect.BottomRight, null);
			rect = global::Infragistics.Windows.Utilities.RectFromPoints(point, point2);
			dropIndicator.DropTargetWidth = rect.Width;
			dropIndicator.DropTargetHeight = rect.Height;
			dropIndicator.DropLocation = new global::Infragistics.Windows.Controls.DropLocation?(dropLocation);
			tabItemDropPreviewWindow.UpdateLayout();
			global::System.Windows.UIElement descendantFromName = global::Infragistics.Windows.Utilities.GetDescendantFromName(dropIndicator, "PART_Offset");
			global::System.Windows.Point point3 = rect.Location;
			if (descendantFromName != null)
			{
				if (!tabItemDropPreviewWindow.IsVisible)
				{
					tabItemDropPreviewWindow.Measure(new global::System.Windows.Size(double.PositiveInfinity, double.PositiveInfinity));
					tabItemDropPreviewWindow.Arrange(new global::System.Windows.Rect(tabItemDropPreviewWindow.DesiredSize));
				}
				global::System.Windows.Point point4 = descendantFromName.TranslatePoint(new global::System.Windows.Point(0.0, 0.0), tabItemDropPreviewWindow);
				point3.X -= point4.X;
				point3.Y -= point4.Y;
			}
			if ((global::Infragistics.Windows.Controls.DropLocation.RightOfTarget == dropLocation && flowDirection == global::System.Windows.FlowDirection.LeftToRight) || (global::Infragistics.Windows.Controls.DropLocation.LeftOfTarget == dropLocation && flowDirection == global::System.Windows.FlowDirection.RightToLeft))
			{
				point3.X += rect.Width;
			}
			else if (global::Infragistics.Windows.Controls.DropLocation.BelowTarget == dropLocation)
			{
				point3.Y += rect.Height;
			}
			point3 = global::Infragistics.Windows.Utilities.PointFromScreenSafe(tabGroup, point3);
			point3 = global::Infragistics.Windows.Controls.ToolWindow.GetScreenPoint(tabGroup, point3, tabGroup);
			tabItemDropPreviewWindow.Left = point3.X;
			tabItemDropPreviewWindow.Top = point3.Y;
			global::Infragistics.Windows.DockManager.Dragging.DragManager.HideToolWindow(this._dropPreviewWindow);
			if (!tabItemDropPreviewWindow.IsVisible)
			{
				global::Infragistics.Windows.DockManager.DockManagerUtilities.ShowToolWindow(tabItemDropPreviewWindow, tabGroup, false);
			}
			return true;
		}

		// Token: 0x0600032A RID: 810 RVA: 0x000108A5 File Offset: 0x0000EAA5
		internal bool StartWindowDrag(global::Infragistics.Windows.DockManager.PaneToolWindow paneToolWindow, global::System.Windows.Point pt, global::System.Windows.Input.MouseDevice mouse)
		{
			return global::Infragistics.Windows.DockManager.Dragging.DragManager.ProcessMouseDown(paneToolWindow, new global::Infragistics.Windows.DockManager.Dragging.DragManager.ScreenInputDeviceInfo(global::Infragistics.Windows.Utilities.PointToScreenSafe(paneToolWindow, pt)));
		}

		// Token: 0x0600032B RID: 811 RVA: 0x000108B9 File Offset: 0x0000EAB9
		private void AddForceRemainOpen(global::Infragistics.Windows.DockManager.PaneToolWindow toolWindow)
		{
			if (toolWindow == null)
			{
				return;
			}
			if (this._windowsPendingClose == null)
			{
				this._windowsPendingClose = new global::Infragistics.Windows.Helpers.HashSet();
			}
			this._windowsPendingClose.Add(toolWindow);
			toolWindow.ForceRemainOpen = true;
		}

		// Token: 0x0600032C RID: 812 RVA: 0x000108E8 File Offset: 0x0000EAE8
		private static void AdjustDragPositionForToolWindow(global::Infragistics.Windows.Controls.ToolWindow toolWindow, global::System.Windows.Point screenPoint, ref global::System.Windows.Point relativePoint)
		{
			if (toolWindow != null && toolWindow.Host is global::System.Windows.Window)
			{
				global::System.Windows.Rect windowBounds = toolWindow.Host.GetWindowBounds();
				if (!windowBounds.IsEmpty)
				{
					global::System.Windows.Point point = global::Infragistics.Windows.Utilities.ConvertToLogicalPixels((int)screenPoint.X, (int)screenPoint.Y, toolWindow);
					point.X -= windowBounds.Left;
					point.Y -= windowBounds.Top;
					relativePoint = point;
				}
			}
		}

		// Token: 0x0600032D RID: 813 RVA: 0x00010962 File Offset: 0x0000EB62
		private void CancelPendingDrag(global::System.Windows.FrameworkElement element)
		{
			this._mouseDownLocation = null;
			this._dragState = global::Infragistics.Windows.DockManager.Dragging.DragState.None;
			this.UnhookElementPendingDrag(element);
			element.ReleaseMouseCapture();
		}

		// Token: 0x0600032E RID: 814 RVA: 0x00010984 File Offset: 0x0000EB84
		private global::Infragistics.Windows.DockManager.Dragging.AddToGroupActionBase CreateAddToGroupAction(global::System.Windows.FrameworkElement group, int index)
		{
			return this.CreateAddToGroupAction(group, index, false);
		}

		// Token: 0x0600032F RID: 815 RVA: 0x00010990 File Offset: 0x0000EB90
		private global::Infragistics.Windows.DockManager.Dragging.AddToGroupActionBase CreateAddToGroupAction(global::System.Windows.FrameworkElement group, int index, bool allowTabItemInsertionBar)
		{
			global::Infragistics.Windows.DockManager.Dragging.AddToGroupActionBase addToGroupActionBase;
			if (this.IsMoveInGroupAction(group))
			{
				addToGroupActionBase = new global::Infragistics.Windows.DockManager.Dragging.MoveInGroupAction(group, index);
			}
			else
			{
				addToGroupActionBase = new global::Infragistics.Windows.DockManager.Dragging.AddToGroupAction(group, index);
			}
			if (allowTabItemInsertionBar)
			{
				addToGroupActionBase.TabItemDragBehavior = this.TabItemDragBehavior;
			}
			return addToGroupActionBase;
		}

		// Token: 0x06000330 RID: 816 RVA: 0x000109C8 File Offset: 0x0000EBC8
		private void CreateIndicators()
		{
			this._indicatorWindows = new global::Infragistics.Windows.Controls.ToolWindow[5];
			for (int i = 0; i < this._indicatorWindows.Length; i++)
			{
				this._indicatorWindows[i] = this.CreateIndicatorWindow((global::Infragistics.Windows.DockManager.DockingIndicatorPosition)i);
			}
		}

		// Token: 0x06000331 RID: 817 RVA: 0x00010A04 File Offset: 0x0000EC04
		private global::Infragistics.Windows.Controls.ToolWindow CreateIndicatorWindow(global::Infragistics.Windows.DockManager.DockingIndicatorPosition position)
		{
			global::Infragistics.Windows.DockManager.DockingIndicator dockingIndicator = new global::Infragistics.Windows.DockManager.DockingIndicator();
			dockingIndicator.Position = position;
			global::Infragistics.Windows.Controls.ToolWindow toolWindow = global::Infragistics.Windows.DockManager.Dragging.DragManager.DragToolWindow.Create(this._dockManager);
			toolWindow.Topmost = true;
			toolWindow.VerticalAlignmentMode = global::Infragistics.Windows.Controls.ToolWindowAlignmentMode.UseAlignment;
			toolWindow.HorizontalAlignmentMode = global::Infragistics.Windows.Controls.ToolWindowAlignmentMode.UseAlignment;
			switch (position)
			{
			case global::Infragistics.Windows.DockManager.DockingIndicatorPosition.Center:
				toolWindow.HorizontalAlignment = global::System.Windows.HorizontalAlignment.Center;
				toolWindow.VerticalAlignment = global::System.Windows.VerticalAlignment.Center;
				break;
			case global::Infragistics.Windows.DockManager.DockingIndicatorPosition.Left:
				toolWindow.HorizontalAlignment = global::System.Windows.HorizontalAlignment.Left;
				toolWindow.VerticalAlignment = global::System.Windows.VerticalAlignment.Center;
				toolWindow.HorizontalAlignmentOffset = 13.0;
				break;
			case global::Infragistics.Windows.DockManager.DockingIndicatorPosition.Top:
				toolWindow.HorizontalAlignment = global::System.Windows.HorizontalAlignment.Center;
				toolWindow.VerticalAlignment = global::System.Windows.VerticalAlignment.Top;
				toolWindow.VerticalAlignmentOffset = 13.0;
				break;
			case global::Infragistics.Windows.DockManager.DockingIndicatorPosition.Right:
				toolWindow.HorizontalAlignment = global::System.Windows.HorizontalAlignment.Right;
				toolWindow.VerticalAlignment = global::System.Windows.VerticalAlignment.Center;
				toolWindow.HorizontalAlignmentOffset = -13.0;
				break;
			case global::Infragistics.Windows.DockManager.DockingIndicatorPosition.Bottom:
				toolWindow.HorizontalAlignment = global::System.Windows.HorizontalAlignment.Center;
				toolWindow.VerticalAlignment = global::System.Windows.VerticalAlignment.Bottom;
				toolWindow.VerticalAlignmentOffset = -13.0;
				break;
			}
			toolWindow.Content = dockingIndicator;
			return toolWindow;
		}

		// Token: 0x06000332 RID: 818 RVA: 0x00010AF4 File Offset: 0x0000ECF4
		private void EndDrag(bool cancel)
		{
			switch (this._dragState)
			{
			case global::Infragistics.Windows.DockManager.Dragging.DragState.None:
			case global::Infragistics.Windows.DockManager.Dragging.DragState.Pending:
			case global::Infragistics.Windows.DockManager.Dragging.DragState.ProcessingDrop:
				return;
			}
			if (this._isProcessingMouseMove)
			{
				if (this._pendingCancelDuringMouseMove == null)
				{
					this._pendingCancelDuringMouseMove = new bool?(cancel);
				}
				return;
			}
			this._rootDragElementToolWindow = null;
			this._dragMoveCache = null;
			if (this._keyFocusWatcher != null)
			{
				this._keyFocusWatcher.KeyEvent -= this.OnKeyFocusWatcherKeyEvent;
				this._keyFocusWatcher.Dispose();
				this._keyFocusWatcher = null;
			}
			global::System.Windows.FrameworkContentElement frameworkContentElement = this._mouseCaptureHelper;
			this.SetDragCaptureHelper(null);
			if (this._isWindowDragMode)
			{
				global::System.Windows.Input.Mouse.OverrideCursor = null;
				this.IsInWindowDragMode = false;
				this._isWindowDragMode = true;
			}
			this._dragState = global::Infragistics.Windows.DockManager.Dragging.DragState.None;
			if (this._lastHotTrackIndicator != null)
			{
				this._lastHotTrackIndicator.ClearValue(global::Infragistics.Windows.DockManager.DockingIndicator.HotTrackPositionPropertyKey);
				this._lastHotTrackIndicator = null;
			}
			this.RemoveIndicators();
			global::Infragistics.Windows.DockManager.Dragging.DragManager.ReleaseToolWindow(ref this._dropPreviewWindow);
			global::Infragistics.Windows.DockManager.Dragging.DragManager.ReleaseToolWindow(ref this._tabItemDropPreviewWindow);
			this._globalIndicatorState = null;
			this._indicatorStates = null;
			this._defaultValidCursor = null;
			this._defaultInvalidCursor = null;
			if (this._floatingPreviewWindow != null)
			{
				this._floatingPreviewWindow.Close();
				this._floatingPreviewWindow.Resources.MergedDictionaries.Clear();
			}
			if (!cancel)
			{
				if (this._dropInfo != null && this._dropInfo.Action != null)
				{
					global::Infragistics.Windows.DockManager.Dragging.DragManager.DragResult dragResult;
					this._dragResults.TryGetValue(this._dropInfo.Action, out dragResult);
					if (dragResult != null && dragResult.IsValid)
					{
						global::System.Windows.IInputElement focusedElement = global::System.Windows.Input.Keyboard.FocusedElement;
						if (focusedElement != null)
						{
							if (frameworkContentElement == null)
							{
								frameworkContentElement = this._dockManager.DragHelper;
							}
							if (!(this._dropInfo.Action is global::Infragistics.Windows.DockManager.Dragging.MoveWindowAction))
							{
								global::System.Windows.Input.Keyboard.Focus(frameworkContentElement);
							}
						}
						try
						{
							this._dragState = global::Infragistics.Windows.DockManager.Dragging.DragState.ProcessingDrop;
							this._dockManager.ActivePaneManager.SuspendVerification();
							this._dropInfo.Action.PerformAction(this, false);
							this.FixPlaceholders();
						}
						finally
						{
							this._dragState = global::Infragistics.Windows.DockManager.Dragging.DragState.None;
							this._dockManager.ActivePaneManager.ResumeVerification();
						}
						global::Infragistics.Windows.DockManager.ContentPane contentPane = (!(focusedElement is global::System.Windows.DependencyObject)) ? null : ((focusedElement as global::Infragistics.Windows.DockManager.ContentPane) ?? (global::Infragistics.Windows.Utilities.GetAncestorFromType((global::System.Windows.DependencyObject)focusedElement, typeof(global::Infragistics.Windows.DockManager.ContentPane), true, this._rootDragElement) as global::Infragistics.Windows.DockManager.ContentPane));
						if (contentPane != null)
						{
							contentPane.ActivateInternal(true);
						}
						if (contentPane != focusedElement && focusedElement != null)
						{
							focusedElement.Focus();
						}
					}
				}
				else if (this._windowBeingDragged != null && !this._windowBeingDragged.IsVisible)
				{
					global::Infragistics.Windows.DockManager.DockManagerUtilities.ShowToolWindow(this._windowBeingDragged, this._dockManager, true);
				}
			}
			this.IsInWindowDragMode = false;
			if ((frameworkContentElement != null && frameworkContentElement.IsKeyboardFocused) || this._dockManager.DragHelper.IsKeyboardFocused)
			{
				if (this._lastFocusedElement != null && this._lastFocusedElement.Focusable)
				{
					global::System.Windows.Input.Keyboard.Focus(this._lastFocusedElement);
				}
				if (frameworkContentElement.IsKeyboardFocused || this._dockManager.DragHelper.IsKeyboardFocused)
				{
					if (this._lastActivePane != null && this._lastActivePane.CanActivate)
					{
						this._lastActivePane.ActivateInternal();
					}
					if (frameworkContentElement.IsKeyboardFocused || this._dockManager.DragHelper.IsKeyboardFocused)
					{
						global::System.Windows.Input.Keyboard.Focus(null);
					}
				}
			}
			if (this._windowBeingDragged != null && this._windowBeingDragged.IsVisible)
			{
				this._windowBeingDragged.BringToFront();
			}
			global::System.Windows.DependencyObject focusScope = global::System.Windows.Input.FocusManager.GetFocusScope(this._dockManager);
			if (focusScope != null && frameworkContentElement != null && global::System.Windows.Input.FocusManager.GetFocusedElement(focusScope) == frameworkContentElement)
			{
				global::System.Windows.Input.FocusManager.SetFocusedElement(focusScope, this._dockManager);
			}
			this._windowBeingDragged = null;
			this._initialDragElement = null;
			this._rootDragElement = null;
			this._dropInfo = null;
			this._dragResults = null;
			this._floatingPreviewWindow = null;
			this._lastActivePane = null;
			this._lastFocusedElement = null;
			this.ProcessPendingWindowClose();
			if (this._canRaiseDragEvents)
			{
				global::Infragistics.Windows.DockManager.Events.PaneDragEndedEventArgs args = new global::Infragistics.Windows.DockManager.Events.PaneDragEndedEventArgs(this._panesBeingDragged);
				this._panesBeingDragged = null;
				this._dockManager.RaisePaneDragEnded(args);
			}
		}

		// Token: 0x06000333 RID: 819 RVA: 0x00010ED8 File Offset: 0x0000F0D8
		private void FixPlaceholders()
		{
			global::Infragistics.Windows.DockManager.DockManagerUtilities.FixPlaceholders(this._panesBeingDragged);
		}

		// Token: 0x06000334 RID: 820 RVA: 0x00010EE8 File Offset: 0x0000F0E8
		private global::Infragistics.Windows.DockManager.Dragging.AllowedDropLocations GetAllowedDropLocations(global::System.Collections.Generic.IList<global::Infragistics.Windows.DockManager.ContentPane> panes)
		{
			if (panes.Count == 0)
			{
				return (global::Infragistics.Windows.DockManager.Dragging.AllowedDropLocations)0;
			}
			global::Infragistics.Windows.DockManager.Dragging.AllowedDropLocations allowedDropLocations = global::Infragistics.Windows.DockManager.Dragging.AllowedDropLocations.All;
			foreach (global::Infragistics.Windows.DockManager.ContentPane contentPane in panes)
			{
				global::Infragistics.Windows.DockManager.Dragging.AllowedDropLocations allowedDropLocations2 = contentPane.AllowedDropLocations;
				allowedDropLocations &= allowedDropLocations2;
			}
			allowedDropLocations = this._dockManager.AdjustAllowedDropLocations(allowedDropLocations);
			return allowedDropLocations;
		}

		// Token: 0x06000335 RID: 821 RVA: 0x00010F50 File Offset: 0x0000F150
		private global::Infragistics.Windows.DockManager.DockingIndicator GetHitTestIndicator(global::Infragistics.Windows.DockManager.Dragging.DragManager.IInputDeviceInfo e, out global::Infragistics.Windows.DockManager.DockingIndicatorPosition? position)
		{
			for (int i = 0; i < this._indicatorWindows.Length; i++)
			{
				global::Infragistics.Windows.DockManager.DockingIndicator dockingIndicator = this._indicatorWindows[i].Content as global::Infragistics.Windows.DockManager.DockingIndicator;
				if (dockingIndicator.IsVisible)
				{
					this.InitializeIndicator(dockingIndicator);
					global::System.Windows.Point position2 = e.GetPosition(dockingIndicator);
					position = dockingIndicator.GetPosition(position2);
					if (position != null)
					{
						return dockingIndicator;
					}
				}
			}
			position = null;
			return null;
		}

		// Token: 0x06000336 RID: 822 RVA: 0x00010FBC File Offset: 0x0000F1BC
		private global::Infragistics.Windows.DockManager.Dragging.PaneDragAction GetIndicatorDragAction(global::Infragistics.Windows.DockManager.DockingIndicator indicator, global::Infragistics.Windows.DockManager.DockingIndicatorPosition positionInIndicator)
		{
			global::Infragistics.Windows.Controls.ToolWindow toolWindow = global::Infragistics.Windows.Controls.ToolWindow.GetToolWindow(indicator);
			if (toolWindow == null)
			{
				return null;
			}
			if (global::Infragistics.Windows.DockManager.XamDockManager.GetPaneLocation(toolWindow.Owner) == global::Infragistics.Windows.DockManager.PaneLocation.Document)
			{
				global::Infragistics.Windows.DockManager.DocumentContentHost documentContentHost = this._dockManager.DocumentContentHost;
				if (toolWindow.Owner is global::Infragistics.Windows.DockManager.DocumentContentHost)
				{
					if (!this._isDraggingDocuments)
					{
						switch (positionInIndicator)
						{
						case global::Infragistics.Windows.DockManager.DockingIndicatorPosition.Center:
						{
							global::Infragistics.Windows.DockManager.IContentPaneContainer containerForPane = documentContentHost.GetContainerForPane(this._panesBeingDragged[0], false);
							return new global::Infragistics.Windows.DockManager.Dragging.AddToDocumentHostAction(containerForPane as global::Infragistics.Windows.DockManager.TabGroupPane, 0);
						}
						case global::Infragistics.Windows.DockManager.DockingIndicatorPosition.Left:
						case global::Infragistics.Windows.DockManager.DockingIndicatorPosition.Top:
						case global::Infragistics.Windows.DockManager.DockingIndicatorPosition.Right:
						case global::Infragistics.Windows.DockManager.DockingIndicatorPosition.Bottom:
							return new global::Infragistics.Windows.DockManager.Dragging.NewRootPaneAction(global::Infragistics.Windows.DockManager.DockManagerUtilities.GetDockedSide(positionInIndicator), global::Infragistics.Windows.DockManager.Dragging.RootSplitPaneLocation.InnerDockManagerEdge);
						default:
							return null;
						}
					}
					else
					{
						if (positionInIndicator == global::Infragistics.Windows.DockManager.DockingIndicatorPosition.Center || documentContentHost.ActiveDocument == null)
						{
							global::Infragistics.Windows.DockManager.IContentPaneContainer containerForPane2 = documentContentHost.GetContainerForPane(this._panesBeingDragged[0], false);
							return new global::Infragistics.Windows.DockManager.Dragging.AddToDocumentHostAction(containerForPane2 as global::Infragistics.Windows.DockManager.TabGroupPane, 0);
						}
						switch (positionInIndicator)
						{
						case global::Infragistics.Windows.DockManager.DockingIndicatorPosition.Left:
						case global::Infragistics.Windows.DockManager.DockingIndicatorPosition.Top:
						case global::Infragistics.Windows.DockManager.DockingIndicatorPosition.Right:
						case global::Infragistics.Windows.DockManager.DockingIndicatorPosition.Bottom:
						{
							global::System.Windows.Controls.Dock dockedSide = global::Infragistics.Windows.DockManager.DockManagerUtilities.GetDockedSide(positionInIndicator);
							return new global::Infragistics.Windows.DockManager.Dragging.NewRootPaneAction(dockedSide, global::Infragistics.Windows.DockManager.Dragging.RootSplitPaneLocation.DocumentContentHost);
						}
						default:
							return null;
						}
					}
				}
				else if (indicator.Position != global::Infragistics.Windows.DockManager.DockingIndicatorPosition.Center || !this._isDraggingDocuments)
				{
					return null;
				}
			}
			if (indicator.Position == global::Infragistics.Windows.DockManager.DockingIndicatorPosition.Center)
			{
				if (!(toolWindow.Owner is global::Infragistics.Windows.DockManager.ContentPane))
				{
					switch (positionInIndicator)
					{
					case global::Infragistics.Windows.DockManager.DockingIndicatorPosition.Center:
						return null;
					case global::Infragistics.Windows.DockManager.DockingIndicatorPosition.Left:
					case global::Infragistics.Windows.DockManager.DockingIndicatorPosition.Top:
					case global::Infragistics.Windows.DockManager.DockingIndicatorPosition.Right:
					case global::Infragistics.Windows.DockManager.DockingIndicatorPosition.Bottom:
						return new global::Infragistics.Windows.DockManager.Dragging.NewRootPaneAction(global::Infragistics.Windows.DockManager.DockManagerUtilities.GetDockedSide(positionInIndicator), global::Infragistics.Windows.DockManager.Dragging.RootSplitPaneLocation.InnerDockManagerEdge);
					default:
						return null;
					}
				}
				else
				{
					global::Infragistics.Windows.DockManager.ContentPane contentPane = toolWindow.Owner as global::Infragistics.Windows.DockManager.ContentPane;
					if (contentPane == null)
					{
						return null;
					}
					global::Infragistics.Windows.DockManager.IPaneContainer parentPane = global::Infragistics.Windows.DockManager.DockManagerUtilities.GetParentPane(contentPane);
					if (!(parentPane is global::Infragistics.Windows.DockManager.SplitPane) && !(parentPane is global::Infragistics.Windows.DockManager.TabGroupPane))
					{
						return null;
					}
					if (parentPane is global::Infragistics.Windows.DockManager.SplitPane && global::Infragistics.Windows.DockManager.XamDockManager.GetPaneLocation(toolWindow.Owner) == global::Infragistics.Windows.DockManager.PaneLocation.Document)
					{
						return null;
					}
					global::System.Windows.FrameworkElement frameworkElement = (parentPane as global::Infragistics.Windows.DockManager.TabGroupPane) ?? contentPane;
					switch (positionInIndicator)
					{
					case global::Infragistics.Windows.DockManager.DockingIndicatorPosition.Center:
						if (frameworkElement is global::Infragistics.Windows.DockManager.TabGroupPane)
						{
							int index = 0;
							if (this._panesBeingDragged.Count == 1)
							{
								global::Infragistics.Windows.DockManager.TabGroupPane tabGroupPane = (global::Infragistics.Windows.DockManager.TabGroupPane)frameworkElement;
								int num = global::Infragistics.Windows.DockManager.DockManagerUtilities.IndexOf(tabGroupPane.Items, this._panesBeingDragged[0], false);
								if (num >= 0)
								{
								}
							}
							return this.CreateAddToGroupAction(frameworkElement, index);
						}
						return new global::Infragistics.Windows.DockManager.Dragging.NewTabGroupAction(contentPane);
					case global::Infragistics.Windows.DockManager.DockingIndicatorPosition.Left:
					case global::Infragistics.Windows.DockManager.DockingIndicatorPosition.Top:
					case global::Infragistics.Windows.DockManager.DockingIndicatorPosition.Right:
					case global::Infragistics.Windows.DockManager.DockingIndicatorPosition.Bottom:
					{
						global::System.Windows.Controls.Dock dockedSide2 = global::Infragistics.Windows.DockManager.DockManagerUtilities.GetDockedSide(positionInIndicator);
						global::Infragistics.Windows.DockManager.SplitPane splitPane = global::Infragistics.Windows.DockManager.DockManagerUtilities.GetParentPane(frameworkElement) as global::Infragistics.Windows.DockManager.SplitPane;
						if (splitPane == null)
						{
							return null;
						}
						switch (dockedSide2)
						{
						case global::System.Windows.Controls.Dock.Left:
						case global::System.Windows.Controls.Dock.Right:
							if (splitPane.SplitterOrientation == global::System.Windows.Controls.Orientation.Vertical)
							{
								return this.CreateAddToGroupAction(splitPane, splitPane.Panes.IndexOf(frameworkElement) + ((dockedSide2 == global::System.Windows.Controls.Dock.Right) ? 1 : 0));
							}
							break;
						case global::System.Windows.Controls.Dock.Top:
						case global::System.Windows.Controls.Dock.Bottom:
							if (splitPane.SplitterOrientation == global::System.Windows.Controls.Orientation.Horizontal)
							{
								return this.CreateAddToGroupAction(splitPane, splitPane.Panes.IndexOf(frameworkElement) + ((dockedSide2 == global::System.Windows.Controls.Dock.Bottom) ? 1 : 0));
							}
							break;
						}
						return new global::Infragistics.Windows.DockManager.Dragging.NewSplitPaneAction(frameworkElement, global::Infragistics.Windows.DockManager.DockManagerUtilities.GetDockedSide(positionInIndicator));
					}
					default:
						return null;
					}
				}
			}
			else
			{
				if (indicator.Position == global::Infragistics.Windows.DockManager.DockingIndicatorPosition.Center)
				{
					return null;
				}
				return new global::Infragistics.Windows.DockManager.Dragging.NewRootPaneAction(global::Infragistics.Windows.DockManager.DockManagerUtilities.GetDockedSide(indicator.Position), global::Infragistics.Windows.DockManager.Dragging.RootSplitPaneLocation.OuterDockManagerEdge);
			}
		}

		// Token: 0x06000337 RID: 823 RVA: 0x00011297 File Offset: 0x0000F497
		private global::System.Windows.Point GetScreenPoint(global::System.Windows.Input.MouseEventArgs e)
		{
			return global::Infragistics.Windows.Controls.ToolWindow.GetScreenPoint(this._dockManager, e);
		}

		// Token: 0x06000338 RID: 824 RVA: 0x000112A8 File Offset: 0x0000F4A8
		private void HideIndicators(bool includeCenter, bool includeGlobal)
		{
			if (this._indicatorWindows != null)
			{
				int i = 0;
				while (i < this._indicatorWindows.Length)
				{
					global::Infragistics.Windows.Controls.ToolWindow toolWindow = this._indicatorWindows[i];
					global::Infragistics.Windows.DockManager.DockingIndicator dockingIndicator = toolWindow.Content as global::Infragistics.Windows.DockManager.DockingIndicator;
					if (dockingIndicator.Position == global::Infragistics.Windows.DockManager.DockingIndicatorPosition.Center)
					{
						if (includeCenter)
						{
							goto IL_31;
						}
					}
					else if (includeGlobal)
					{
						goto IL_31;
					}
					IL_46:
					i++;
					continue;
					IL_31:
					if (toolWindow.IsVisible)
					{
						this._indicatorWindows[i].Close();
						goto IL_46;
					}
					goto IL_46;
				}
			}
		}

		// Token: 0x06000339 RID: 825 RVA: 0x000116FC File Offset: 0x0000F8FC
		private global::System.Collections.Generic.IEnumerable<global::System.Windows.IInputElement> HitTest(global::Infragistics.Windows.DockManager.Dragging.DragManager.IInputDeviceInfo e)
		{
			global::System.Windows.Window dmWindow = global::System.Windows.Window.GetWindow(this._dockManager);
			int ownerIndex;
			global::Infragistics.Windows.Controls.ToolWindow[] windows = global::Infragistics.Windows.Controls.ToolWindow.GetToolWindows(this._dockManager, out ownerIndex);
			for (int i = 0; i < windows.Length; i++)
			{
				if (i == ownerIndex)
				{
					global::System.Windows.Point dmPoint = e.GetPosition(this._dockManager);
					global::System.Windows.IInputElement dmElement = this._dockManager.InputHitTest(dmPoint);
					if (dmElement != null)
					{
						yield return dmElement;
					}
					if (global::Infragistics.Windows.Controls.ToolWindow.IsMouseOverRoot(this._dockManager, dmPoint))
					{
						break;
					}
				}
				global::Infragistics.Windows.DockManager.PaneToolWindow window = windows[i] as global::Infragistics.Windows.DockManager.PaneToolWindow;
				if (window != null && window.Content is global::Infragistics.Windows.DockManager.SplitPane && window.IsVisible && window != this._windowBeingDragged && window != this._floatingPreviewWindow)
				{
					global::System.Windows.Point pt = e.GetPosition(window);
					global::System.Windows.IInputElement windowElement = window.InputHitTest(pt);
					if (windowElement != null)
					{
						yield return windowElement;
					}
					else if (window.SinglePane != null && window.IsUsingOSNonClientArea)
					{
						global::System.Windows.Window windowHost = global::System.Windows.Window.GetWindow(window);
						if (windowHost != null && windowHost != dmWindow)
						{
							global::System.Windows.Point screenPt = window.PointToScreen(pt);
							global::System.IntPtr hwnd = new global::System.Windows.Interop.WindowInteropHelper(windowHost).Handle;
							global::System.IntPtr lParam = new global::System.IntPtr((int)screenPt.Y << 16 | (int)screenPt.X);
							if (global::System.IntPtr.Zero != hwnd)
							{
								global::System.IntPtr hResult = global::Infragistics.Windows.DockManager.NativeWindowMethods.SendMessageApi(hwnd, 132, global::System.IntPtr.Zero, lParam);
								if (2 == global::Infragistics.Windows.DockManager.NativeWindowMethods.IntPtrToInt32(hResult))
								{
									yield return windowHost;
								}
							}
						}
					}
				}
			}
			if (ownerIndex == windows.Length)
			{
				global::System.Windows.Point dmPoint2 = e.GetPosition(this._dockManager);
				global::System.Windows.IInputElement dmElement2 = this._dockManager.InputHitTest(dmPoint2);
				if (dmElement2 != null)
				{
					yield return dmElement2;
				}
			}
			yield break;
		}

		// Token: 0x0600033A RID: 826 RVA: 0x00011720 File Offset: 0x0000F920
		private void HookElementPendingDrag(global::System.Windows.FrameworkElement element)
		{
			element.AddHandler(global::System.Windows.UIElement.LostMouseCaptureEvent, new global::System.Windows.Input.MouseEventHandler(this.OnPendingDragElementLostCapture), true);
			element.AddHandler(global::System.Windows.UIElement.MouseUpEvent, new global::System.Windows.Input.MouseButtonEventHandler(this.OnPendingDragElementMouseUp), true);
			element.AddHandler(global::System.Windows.UIElement.MouseMoveEvent, new global::System.Windows.Input.MouseEventHandler(this.OnPendingDragElementMouseMove), true);
		}

		// Token: 0x0600033B RID: 827 RVA: 0x00011778 File Offset: 0x0000F978
		private void InitializeIndicator(global::Infragistics.Windows.DockManager.DockingIndicator indicator)
		{
			switch (indicator.Position)
			{
			case global::Infragistics.Windows.DockManager.DockingIndicatorPosition.Center:
			{
				global::Infragistics.Windows.Controls.ToolWindow toolWindow = global::Infragistics.Windows.Controls.ToolWindow.GetToolWindow(indicator);
				global::Infragistics.Windows.DockManager.Dragging.DragManager.IndicatorEnabledState indicatorEnabledState;
				if (!this._indicatorStates.TryGetValue(toolWindow.Owner, out indicatorEnabledState))
				{
					indicatorEnabledState = new global::Infragistics.Windows.DockManager.Dragging.DragManager.IndicatorEnabledState();
					this._indicatorStates.Add(toolWindow.Owner, indicatorEnabledState);
				}
				indicatorEnabledState.Initialize(indicator);
				return;
			}
			case global::Infragistics.Windows.DockManager.DockingIndicatorPosition.Left:
				indicator.SetValue(global::Infragistics.Windows.DockManager.DockingIndicator.CanDockLeftPropertyKey, global::Infragistics.KnownBoxes.FromValue(this._globalIndicatorState.Left ?? true));
				return;
			case global::Infragistics.Windows.DockManager.DockingIndicatorPosition.Top:
				indicator.SetValue(global::Infragistics.Windows.DockManager.DockingIndicator.CanDockTopPropertyKey, global::Infragistics.KnownBoxes.FromValue(this._globalIndicatorState.Top ?? true));
				return;
			case global::Infragistics.Windows.DockManager.DockingIndicatorPosition.Right:
				indicator.SetValue(global::Infragistics.Windows.DockManager.DockingIndicator.CanDockRightPropertyKey, global::Infragistics.KnownBoxes.FromValue(this._globalIndicatorState.Right ?? true));
				return;
			case global::Infragistics.Windows.DockManager.DockingIndicatorPosition.Bottom:
				indicator.SetValue(global::Infragistics.Windows.DockManager.DockingIndicator.CanDockBottomPropertyKey, global::Infragistics.KnownBoxes.FromValue(this._globalIndicatorState.Bottom ?? true));
				return;
			default:
				return;
			}
		}

		// Token: 0x0600033C RID: 828 RVA: 0x000118A8 File Offset: 0x0000FAA8
		private bool IsMoveInGroupAction(global::System.Windows.FrameworkElement group)
		{
			global::Infragistics.Windows.DockManager.IPaneContainer paneContainer = group as global::Infragistics.Windows.DockManager.IPaneContainer;
			if (paneContainer != null)
			{
				global::System.Collections.IList panes = paneContainer.Panes;
				foreach (global::Infragistics.Windows.DockManager.ContentPane pane in this._panesBeingDragged)
				{
					if (global::Infragistics.Windows.DockManager.DockManagerUtilities.IndexOf(panes, pane, false) < 0)
					{
						return false;
					}
				}
				return true;
			}
			return true;
		}

		// Token: 0x0600033D RID: 829 RVA: 0x00011918 File Offset: 0x0000FB18
		private global::System.Windows.FrameworkElement MoveToSplitPane(global::Infragistics.Windows.DockManager.SplitPane splitPane, int index, global::Infragistics.Windows.DockManager.PaneLocation paneLocation, global::Infragistics.Windows.DockManager.MovePaneHelper moveHelper)
		{
			global::System.Windows.FrameworkElement result;
			if (this._panesBeingDragged.Count == 1)
			{
				global::Infragistics.Windows.DockManager.DockManagerUtilities.MovePane(this._panesBeingDragged[0], splitPane, new int?(index), paneLocation, moveHelper);
				result = this._panesBeingDragged[0];
			}
			else if (this._rootDragElement is global::Infragistics.Windows.DockManager.TabGroupPane)
			{
				global::Infragistics.Windows.DockManager.TabGroupPane tabGroupPane;
				if (this._windowBeingDragged != null)
				{
					global::Infragistics.Windows.DockManager.SplitPane parent = (global::Infragistics.Windows.DockManager.SplitPane)this._windowBeingDragged.Content;
					global::Infragistics.Windows.DockManager.ContentPane firstLastPane = global::Infragistics.Windows.DockManager.DockManagerUtilities.GetFirstLastPane(parent, true, global::Infragistics.Windows.DockManager.PaneFilterFlags.AllVisible);
					tabGroupPane = ((firstLastPane != null) ? (global::Infragistics.Windows.DockManager.DockManagerUtilities.GetParentPane(firstLastPane) as global::Infragistics.Windows.DockManager.TabGroupPane) : null);
				}
				else
				{
					tabGroupPane = (global::Infragistics.Windows.DockManager.TabGroupPane)this._rootDragElement;
				}
				if (tabGroupPane != null)
				{
					global::Infragistics.Windows.DockManager.TabGroupPane tabGroupPane2 = global::Infragistics.Windows.DockManager.DockManagerUtilities.CreateTabGroup(this._dockManager);
					index = global::System.Math.Min(index, splitPane.Panes.Count);
					splitPane.Panes.Insert(index, tabGroupPane2);
					global::Infragistics.Windows.DockManager.DockManagerUtilities.Clone(tabGroupPane, paneLocation, tabGroupPane2, moveHelper);
					result = tabGroupPane2;
				}
				else
				{
					result = null;
				}
			}
			else
			{
				global::Infragistics.Windows.DockManager.SplitPane source = (global::Infragistics.Windows.DockManager.SplitPane)this._windowBeingDragged.Content;
				global::Infragistics.Windows.DockManager.SplitPane splitPane2 = global::Infragistics.Windows.DockManager.DockManagerUtilities.CreateSplitPane(this._dockManager);
				if (splitPane != null)
				{
					splitPane.Panes.Insert(index, splitPane2);
				}
				else
				{
					splitPane = splitPane2;
				}
				global::Infragistics.Windows.DockManager.DockManagerUtilities.Clone(source, paneLocation, splitPane2, moveHelper);
				result = splitPane2;
			}
			return result;
		}

		// Token: 0x0600033E RID: 830 RVA: 0x00011A3E File Offset: 0x0000FC3E
		private void OnDragElementLostCapture(object sender, global::System.Windows.Input.MouseEventArgs e)
		{
			this.EndDrag(true);
			e.Handled = true;
		}

		// Token: 0x0600033F RID: 831 RVA: 0x00011A4E File Offset: 0x0000FC4E
		private void OnDragElementMouseDown(object sender, global::System.Windows.Input.MouseButtonEventArgs e)
		{
			e.Handled = true;
		}

		// Token: 0x06000340 RID: 832 RVA: 0x00011A57 File Offset: 0x0000FC57
		private void OnDragElementMouseUp(object sender, global::System.Windows.Input.MouseButtonEventArgs e)
		{
			if (e.ChangedButton == global::System.Windows.Input.MouseButton.Left)
			{
				this.EndDrag(false);
			}
			e.Handled = true;
		}

		// Token: 0x06000341 RID: 833 RVA: 0x00011A6F File Offset: 0x0000FC6F
		private void OnDragElementMouseMove(object sender, global::System.Windows.Input.MouseEventArgs e)
		{
			if (this._dragState == global::Infragistics.Windows.DockManager.Dragging.DragState.Dragging && e.LeftButton != global::System.Windows.Input.MouseButtonState.Pressed)
			{
				this.EndDrag(true);
				return;
			}
			this.ProcessDragMove(e);
		}

		// Token: 0x06000342 RID: 834 RVA: 0x00011A94 File Offset: 0x0000FC94
		private void OnKeyFocusWatcherKeyEvent(object sender, global::System.Windows.Input.KeyEventArgs e)
		{
			if (e.RoutedEvent == global::System.Windows.Input.Keyboard.PreviewKeyDownEvent)
			{
				global::System.Windows.Input.Key key = (e.Key == global::System.Windows.Input.Key.System) ? e.SystemKey : e.Key;
				if (key == global::System.Windows.Input.Key.LeftCtrl || key == global::System.Windows.Input.Key.RightCtrl)
				{
					this.VerifyControlKeyStateChanged();
				}
				else if (key == global::System.Windows.Input.Key.Escape)
				{
					this.EndDrag(true);
				}
			}
			else if (e.RoutedEvent == global::System.Windows.Input.Keyboard.PreviewKeyUpEvent)
			{
				global::System.Windows.Input.Key key2 = (e.Key == global::System.Windows.Input.Key.System) ? e.SystemKey : e.Key;
				if (key2 == global::System.Windows.Input.Key.LeftCtrl || key2 == global::System.Windows.Input.Key.RightCtrl)
				{
					this.VerifyControlKeyStateChanged();
				}
			}
			e.Handled = true;
		}

		// Token: 0x06000343 RID: 835 RVA: 0x00011B2A File Offset: 0x0000FD2A
		private void OnPendingDragElementLostCapture(object sender, global::System.Windows.Input.MouseEventArgs e)
		{
			this.CancelPendingDrag(sender as global::System.Windows.FrameworkElement);
		}

		// Token: 0x06000344 RID: 836 RVA: 0x00011B38 File Offset: 0x0000FD38
		private void OnPendingDragElementMouseUp(object sender, global::System.Windows.Input.MouseButtonEventArgs e)
		{
			if (e.ChangedButton == global::System.Windows.Input.MouseButton.Left)
			{
				this.CancelPendingDrag(sender as global::System.Windows.FrameworkElement);
			}
		}

		// Token: 0x06000345 RID: 837 RVA: 0x00011B50 File Offset: 0x0000FD50
		private void OnPendingDragElementMouseMove(object sender, global::System.Windows.Input.MouseEventArgs e)
		{
			global::System.Windows.FrameworkElement frameworkElement = sender as global::System.Windows.FrameworkElement;
			if (!frameworkElement.IsVisible)
			{
				this.CancelPendingDrag(frameworkElement);
				return;
			}
			global::System.Windows.Point position = e.GetPosition(frameworkElement);
			global::System.Windows.Point point = global::Infragistics.Windows.Utilities.PointFromScreenSafe(frameworkElement, this._mouseDownLocation.Value);
			global::System.Windows.Point point2 = global::Infragistics.Windows.Utilities.PointToScreenSafe(frameworkElement, position);
			if (global::Infragistics.Windows.DockManager.XamDockManager.GetDockManager(frameworkElement) == null)
			{
				this.CancelPendingDrag(frameworkElement);
				return;
			}
			global::System.Windows.Rect rect = new global::System.Windows.Rect(this._mouseDownLocation.Value, default(global::System.Windows.Size));
			rect.Inflate(global::System.Math.Min(6.0, global::System.Windows.SystemParameters.MinimumHorizontalDragDistance), global::System.Math.Min(6.0, global::System.Windows.SystemParameters.MinimumVerticalDragDistance));
			if (!rect.Contains(point2))
			{
				global::Infragistics.Windows.DockManager.Dragging.DragManager.AdjustDragPositionForToolWindow(frameworkElement as global::Infragistics.Windows.Controls.ToolWindow, this._mouseDownLocation.Value, ref point);
				this.CancelPendingDrag(frameworkElement);
				e.Handled = true;
				bool flag = false;
				global::Infragistics.Windows.DockManager.PaneHeaderPresenter paneHeaderPresenter = frameworkElement as global::Infragistics.Windows.DockManager.PaneHeaderPresenter;
				if (paneHeaderPresenter != null && paneHeaderPresenter.Pane != null)
				{
					global::Infragistics.Windows.DockManager.PaneToolWindow singlePaneToolWindow = global::Infragistics.Windows.DockManager.PaneToolWindow.GetSinglePaneToolWindow(paneHeaderPresenter.Pane);
					if (singlePaneToolWindow != null)
					{
						point = paneHeaderPresenter.TransformToAncestor(singlePaneToolWindow).Transform(point);
						frameworkElement = singlePaneToolWindow;
						if (this.DockManager.FloatingWindowDragMode == global::Infragistics.Windows.DockManager.FloatingWindowDragMode.UseSystemWindowDrag)
						{
							flag = true;
						}
					}
				}
				global::Infragistics.Windows.Controls.ToolWindow toolWindow = frameworkElement as global::Infragistics.Windows.Controls.ToolWindow;
				if (toolWindow != null && toolWindow.WindowState == global::System.Windows.WindowState.Minimized)
				{
					flag = true;
				}
				bool flag2 = this.StartDrag(frameworkElement, point, new global::Infragistics.Windows.DockManager.Dragging.DragManager.MouseArgsInputDeviceInfo(e), true, flag);
				if (flag2 && this.DragState == global::Infragistics.Windows.DockManager.Dragging.DragState.Dragging && flag)
				{
					this.SwitchToWindowDrag();
				}
			}
		}

		// Token: 0x06000346 RID: 838 RVA: 0x00011CB3 File Offset: 0x0000FEB3
		private void OnWindowDragModeKeyTimerTick(object state)
		{
			if (this._dragState == global::Infragistics.Windows.DockManager.Dragging.DragState.Dragging)
			{
				this._dockManager.Dispatcher.BeginInvoke(global::System.Windows.Threading.DispatcherPriority.Normal, new global::Infragistics.Windows.DockManager.DockManagerUtilities.MethodInvoker(this.VerifySystemControlKeyState));
			}
		}

		// Token: 0x06000347 RID: 839 RVA: 0x00011CDD File Offset: 0x0000FEDD
		[global::System.Diagnostics.Conditional("DEBUG_DRAGGING")]
		private static void Output(object value, string category)
		{
		}

		// Token: 0x06000348 RID: 840 RVA: 0x00011CDF File Offset: 0x0000FEDF
		[global::System.Diagnostics.Conditional("DEBUG_DRAGGING")]
		private static void OutputIf(bool condition, object value, string category)
		{
		}

		// Token: 0x06000349 RID: 841 RVA: 0x00011CE4 File Offset: 0x0000FEE4
		private void PositionCenterIndicator(global::System.Windows.DependencyObject hitTestElement)
		{
			global::Infragistics.Windows.Controls.ToolWindow toolWindow = this._indicatorWindows[0];
			object content = toolWindow.Content;
			global::System.Windows.FrameworkElement frameworkElement = hitTestElement as global::System.Windows.FrameworkElement;
			if (toolWindow.Owner != frameworkElement)
			{
				if (toolWindow.Owner != null)
				{
					toolWindow.Close();
				}
				if (frameworkElement != null)
				{
					global::Infragistics.Windows.DockManager.DockManagerUtilities.ShowToolWindow(toolWindow, frameworkElement, false);
					this._bringWindowToFront = true;
				}
			}
		}

		// Token: 0x0600034A RID: 842 RVA: 0x00011D34 File Offset: 0x0000FF34
		private void ProcessDragMove(global::System.Windows.Input.MouseEventArgs e)
		{
			this.ProcessDragMove(new global::Infragistics.Windows.DockManager.Dragging.DragManager.MouseArgsInputDeviceInfo(e), null);
		}

		// Token: 0x0600034B RID: 843 RVA: 0x00011D58 File Offset: 0x0000FF58
		private void ProcessDragMove(global::Infragistics.Windows.DockManager.Dragging.DragManager.IInputDeviceInfo e, global::System.Windows.Rect? windowRect)
		{
			if (this._isProcessingMouseMove)
			{
				return;
			}
			this._isProcessingMouseMove = true;
			this._pendingCancelDuringMouseMove = null;
			try
			{
				this.ProcessDragMoveImpl(e, windowRect);
			}
			finally
			{
				this._isProcessingMouseMove = false;
			}
			this.ProcessPendingCloseInDragMove();
		}

		// Token: 0x0600034C RID: 844 RVA: 0x00011DAC File Offset: 0x0000FFAC
		private void ProcessDragMoveImpl(global::Infragistics.Windows.DockManager.Dragging.DragManager.IInputDeviceInfo e, global::System.Windows.Rect? windowRect)
		{
			if (this._dragMoveCache == null)
			{
				this._dragMoveCache = new global::Infragistics.Windows.DockManager.Dragging.DragManager.DragMoveCache();
			}
			this._dragMoveCache.DeviceInfo = e;
			this._dragMoveCache.WindowRect = windowRect;
			this._dragMoveCache.WasControlKeyDown = global::Infragistics.Windows.DockManager.Dragging.DragManager.IsControlKeyDown;
			bool flag = this._forceFloating || this._dragMoveCache.WasControlKeyDown;
			global::Infragistics.Windows.DockManager.Dragging.DragManager.DropInfo dropInfo = this._dropInfo;
			this._dropInfo.Reset();
			if (flag)
			{
				dropInfo.ShowGlobalIndicators = false;
				dropInfo.HideCenterIndicator = true;
				dropInfo.ShowFloatingWindow = true;
				dropInfo.HideDropPreview = true;
				dropInfo.HitTestLocation = global::Infragistics.Windows.DockManager.PaneLocation.Floating;
			}
			else
			{
				global::System.Windows.FrameworkElement globalIndicatorsElement = this.GlobalIndicatorsElement;
				global::System.Windows.Rect rect = new global::System.Windows.Rect(0.0, 0.0, globalIndicatorsElement.ActualWidth, globalIndicatorsElement.ActualHeight);
				dropInfo.ShowGlobalIndicators = rect.Contains(e.GetPosition(globalIndicatorsElement));
				using (global::System.Collections.Generic.IEnumerator<global::System.Windows.IInputElement> enumerator = this.HitTest(e).GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						global::System.Windows.IInputElement inputElement = enumerator.Current;
						global::System.Windows.DependencyObject dependencyObject = inputElement as global::System.Windows.DependencyObject;
						if (dependencyObject == null)
						{
							break;
						}
						if (dependencyObject is global::System.Windows.Window)
						{
							global::Infragistics.Windows.DockManager.PaneToolWindow paneToolWindow = ((global::System.Windows.Window)dependencyObject).Content as global::Infragistics.Windows.DockManager.PaneToolWindow;
							global::Infragistics.Windows.DockManager.ContentPane singlePane = paneToolWindow.SinglePane;
							if (paneToolWindow != this._windowBeingDragged)
							{
								global::Infragistics.Windows.DockManager.PaneLocation paneLocation = global::Infragistics.Windows.DockManager.XamDockManager.GetPaneLocation(paneToolWindow);
								if (paneLocation != global::Infragistics.Windows.DockManager.PaneLocation.FloatingOnly)
								{
									dropInfo.HitTestLocation = paneLocation;
									global::Infragistics.Windows.DockManager.IPaneContainer parentPane = global::Infragistics.Windows.DockManager.DockManagerUtilities.GetParentPane(singlePane);
									global::Infragistics.Windows.DockManager.TabGroupPane tabGroupPane = parentPane as global::Infragistics.Windows.DockManager.TabGroupPane;
									if (tabGroupPane != null)
									{
										dropInfo.Action = new global::Infragistics.Windows.DockManager.Dragging.AddToGroupAction(tabGroupPane, tabGroupPane.Items.Count);
									}
									else
									{
										dropInfo.Action = new global::Infragistics.Windows.DockManager.Dragging.NewTabGroupAction(singlePane);
									}
									dropInfo.ShowGlobalIndicators = false;
									dropInfo.HideCenterIndicator = true;
									dropInfo.ShowFloatingWindow = true;
									dropInfo.HideDropPreview = false;
									break;
								}
							}
						}
						else
						{
							while (dependencyObject != null)
							{
								global::System.Windows.DependencyObject dockManager = global::Infragistics.Windows.DockManager.XamDockManager.GetDockManager(dependencyObject);
								if (dockManager == null || dockManager == this._dockManager)
								{
									break;
								}
								dependencyObject = global::System.Windows.Media.VisualTreeHelper.GetParent(dockManager);
							}
							if (dependencyObject != null)
							{
								global::Infragistics.Windows.DockManager.PaneLocation paneLocation2 = global::Infragistics.Windows.DockManager.XamDockManager.GetPaneLocation(dependencyObject);
								dropInfo.HitTestLocation = paneLocation2;
								if (paneLocation2 == global::Infragistics.Windows.DockManager.PaneLocation.Unknown && global::Infragistics.Windows.DockManager.XamDockManager.GetDockManager(dependencyObject) == this._dockManager && !this._dockManager.HasDocumentContentHost)
								{
									global::Infragistics.Windows.DockManager.DockManagerPanel dockPanel = this._dockManager.DockPanel;
									if (dockPanel != null && dockPanel.Child != null)
									{
										global::System.Windows.Point position = e.GetPosition(dockPanel.Child);
										if (new global::System.Windows.Rect(dockPanel.Child.RenderSize).Contains(position))
										{
											dropInfo.ShowGlobalIndicators = true;
											dropInfo.HideCenterIndicator = false;
											dropInfo.ShowFloatingWindow = true;
											dropInfo.HideDropPreview = false;
											dropInfo.CenterIndicatorElement = dockPanel.Child;
											break;
										}
									}
								}
								global::Infragistics.Windows.DockManager.PaneLocation paneLocation3 = paneLocation2;
								if (paneLocation3 != global::Infragistics.Windows.DockManager.PaneLocation.Unknown)
								{
									switch (paneLocation3)
									{
									case global::Infragistics.Windows.DockManager.PaneLocation.FloatingOnly:
									case global::Infragistics.Windows.DockManager.PaneLocation.Unpinned:
										break;
									default:
									{
										global::Infragistics.Windows.DockManager.PaneToolWindow paneToolWindow2 = (paneLocation2 == global::Infragistics.Windows.DockManager.PaneLocation.Floating) ? (global::Infragistics.Windows.Controls.ToolWindow.GetToolWindow(dependencyObject) as global::Infragistics.Windows.DockManager.PaneToolWindow) : null;
										while (dependencyObject != null)
										{
											bool flag2 = false;
											if (global::Infragistics.Windows.DockManager.XamDockManager.GetDockManager(dependencyObject) == this._dockManager)
											{
												if (dependencyObject is global::Infragistics.Windows.DockManager.PaneHeaderPresenter)
												{
													global::Infragistics.Windows.DockManager.PaneHeaderPresenter paneHeaderPresenter = (global::Infragistics.Windows.DockManager.PaneHeaderPresenter)dependencyObject;
													if (!this.IsBeingDragged(paneHeaderPresenter.Pane) && paneHeaderPresenter.Pane != null)
													{
														flag2 = true;
														global::Infragistics.Windows.DockManager.IPaneContainer parentPane2 = global::Infragistics.Windows.DockManager.DockManagerUtilities.GetParentPane(paneHeaderPresenter.Pane);
														global::Infragistics.Windows.DockManager.TabGroupPane tabGroupPane2 = parentPane2 as global::Infragistics.Windows.DockManager.TabGroupPane;
														if (tabGroupPane2 != null)
														{
															dropInfo.Action = this.CreateAddToGroupAction(tabGroupPane2, tabGroupPane2.Items.Count);
														}
														else
														{
															dropInfo.Action = new global::Infragistics.Windows.DockManager.Dragging.NewTabGroupAction(paneHeaderPresenter.Pane);
														}
													}
												}
												else if (paneToolWindow2 != null && paneToolWindow2.SinglePane != null && paneToolWindow2.CaptionElement == dependencyObject)
												{
													if (!this.IsBeingDragged(paneToolWindow2.SinglePane))
													{
														flag2 = true;
														global::Infragistics.Windows.DockManager.IPaneContainer parentPane3 = global::Infragistics.Windows.DockManager.DockManagerUtilities.GetParentPane(paneToolWindow2.SinglePane);
														global::Infragistics.Windows.DockManager.TabGroupPane tabGroupPane3 = parentPane3 as global::Infragistics.Windows.DockManager.TabGroupPane;
														if (tabGroupPane3 != null)
														{
															dropInfo.Action = this.CreateAddToGroupAction(tabGroupPane3, tabGroupPane3.Items.Count);
														}
														else
														{
															dropInfo.Action = new global::Infragistics.Windows.DockManager.Dragging.NewTabGroupAction(paneToolWindow2.SinglePane);
														}
													}
												}
												else if (dependencyObject is global::Infragistics.Windows.DockManager.ContentPane || dependencyObject is global::Infragistics.Windows.DockManager.DocumentContentHost)
												{
													if ((!(dependencyObject is global::Infragistics.Windows.DockManager.ContentPane) || this._isDraggingDocuments || global::Infragistics.Windows.DockManager.PaneLocation.Document != global::Infragistics.Windows.DockManager.XamDockManager.GetPaneLocation(dependencyObject)) && (!(dependencyObject is global::Infragistics.Windows.DockManager.DocumentContentHost) || !this._isDraggingDocuments))
													{
														bool flag3 = false;
														if (dependencyObject is global::Infragistics.Windows.DockManager.ContentPane)
														{
															global::Infragistics.Windows.DockManager.IPaneContainer parentPane4 = global::Infragistics.Windows.DockManager.DockManagerUtilities.GetParentPane(dependencyObject);
															if (parentPane4 is global::Infragistics.Windows.DockManager.TabGroupPane)
															{
																using (global::System.Collections.IEnumerator enumerator2 = parentPane4.Panes.GetEnumerator())
																{
																	while (enumerator2.MoveNext())
																	{
																		object obj = enumerator2.Current;
																		global::Infragistics.Windows.DockManager.ContentPane contentPane = obj as global::Infragistics.Windows.DockManager.ContentPane;
																		if (contentPane != null && contentPane.Visibility == global::System.Windows.Visibility.Visible && 0 > global::Infragistics.Windows.DockManager.DockManagerUtilities.IndexOf(this.PanesBeingDragged, contentPane, false))
																		{
																			flag3 = true;
																			break;
																		}
																	}
																	goto IL_4B2;
																}
																goto IL_4A0;
															}
															goto IL_4A0;
															IL_4B2:
															if (flag3)
															{
																goto IL_4B9;
															}
															break;
															IL_4A0:
															flag3 = !this.IsBeingDragged((global::Infragistics.Windows.DockManager.ContentPane)dependencyObject);
															goto IL_4B2;
														}
														flag3 = true;
														IL_4B9:
														if (flag3)
														{
															dropInfo.ShowFloatingWindow = true;
															dropInfo.HideCenterIndicator = false;
															dropInfo.CenterIndicatorElement = dependencyObject;
															break;
														}
													}
												}
												else if (dependencyObject is global::Infragistics.Windows.DockManager.PaneTabItem)
												{
													global::Infragistics.Windows.DockManager.PaneTabItem paneTabItem = (global::Infragistics.Windows.DockManager.PaneTabItem)dependencyObject;
													global::Infragistics.Windows.DockManager.TabGroupPane tabGroupPane4 = global::System.Windows.Controls.ItemsControl.ItemsControlFromItemContainer(dependencyObject) as global::Infragistics.Windows.DockManager.TabGroupPane;
													if (tabGroupPane4 != null && (this._isDraggingDocuments || global::Infragistics.Windows.DockManager.PaneLocation.Document != global::Infragistics.Windows.DockManager.XamDockManager.GetPaneLocation(dependencyObject)) && (this._panesBeingDragged.Count <= 1 || !this.IsBeingDragged(paneTabItem.Pane)))
													{
														flag2 = true;
														int num = tabGroupPane4.ItemContainerGenerator.IndexFromContainer(dependencyObject);
														if (this.TabItemDragBehavior == global::Infragistics.Windows.DockManager.TabItemDragBehavior.DisplayInsertionBar && !this.IsBeingDragged(paneTabItem.Pane))
														{
															global::System.Windows.Rect rect2 = global::System.Windows.Rect.Union(new global::System.Windows.Rect(paneTabItem.RenderSize), global::System.Windows.Media.VisualTreeHelper.GetDescendantBounds(paneTabItem));
															rect2 = paneTabItem.TransformToAncestor(tabGroupPane4).TransformBounds(rect2);
															global::System.Windows.Point position2 = e.GetPosition(tabGroupPane4);
															bool flag4 = tabGroupPane4.TabStripPlacement == global::System.Windows.Controls.Dock.Top || tabGroupPane4.TabStripPlacement == global::System.Windows.Controls.Dock.Bottom;
															bool flag5;
															if (flag4)
															{
																flag5 = (position2.X >= rect2.Left + (rect2.Width + 1.0) / 2.0);
															}
															else
															{
																flag5 = (position2.Y >= rect2.Top + (rect2.Height + 1.0) / 2.0);
															}
															if (flag5)
															{
																num++;
															}
															else
															{
																int num2;
																global::Infragistics.Windows.DockManager.PaneTabItem paneTabItem2 = global::Infragistics.Windows.DockManager.DockManagerUtilities.GetItemContainer(tabGroupPane4, num, true, false, out num2) as global::Infragistics.Windows.DockManager.PaneTabItem;
																if (paneTabItem2 != null && this.IsBeingDragged(paneTabItem2.Pane))
																{
																	num = num2;
																}
															}
														}
														dropInfo.Action = this.CreateAddToGroupAction(tabGroupPane4, num, true);
														dropInfo.ShowFloatingWindow = false;
														dropInfo.HideDropPreview = false;
													}
												}
												else if (dependencyObject is global::Infragistics.Windows.DockManager.TabGroupPane)
												{
													if ((this._isDraggingDocuments || global::Infragistics.Windows.DockManager.PaneLocation.Document != global::Infragistics.Windows.DockManager.XamDockManager.GetPaneLocation(dependencyObject)) && dependencyObject != this._rootDragElement)
													{
														global::Infragistics.Windows.DockManager.TabGroupPane tabGroupPane5 = (global::Infragistics.Windows.DockManager.TabGroupPane)dependencyObject;
														global::System.Windows.FrameworkElement headerArea = tabGroupPane5.HeaderArea;
														flag2 = true;
														if (headerArea != null && global::Infragistics.Windows.Utilities.IsDescendantOf(headerArea, inputElement as global::System.Windows.DependencyObject))
														{
															dropInfo.Action = this.CreateAddToGroupAction(tabGroupPane5, tabGroupPane5.Items.Count, true);
														}
														else if (this.TabItemDragBehavior == global::Infragistics.Windows.DockManager.TabItemDragBehavior.DisplayInsertionBar)
														{
															dropInfo.Action = this.CreateAddToGroupAction(tabGroupPane5, tabGroupPane5.Items.Count, true);
														}
														else
														{
															dropInfo.Action = this.CreateAddToGroupAction(tabGroupPane5, 0);
														}
													}
												}
												else if (dependencyObject is global::Infragistics.Windows.DockManager.XamDockManager && dependencyObject == this._dockManager)
												{
													break;
												}
											}
											if (flag2)
											{
												dropInfo.ShowGlobalIndicators = false;
												dropInfo.HideCenterIndicator = true;
												dropInfo.HideDropPreview = false;
												break;
											}
											dependencyObject = global::Infragistics.Windows.Utilities.GetParent(dependencyObject);
										}
										goto IL_77B;
									}
									}
								}
							}
						}
					}
					IL_77B:;
				}
				if (!this._raisePaneDragOverForInvalidLocations && !this.IsDropLocationAllowed(global::Infragistics.Windows.DockManager.Dragging.AllowedDropLocations.Docked))
				{
					dropInfo.ShowGlobalIndicators = false;
				}
			}
			if (!this._raisePaneDragOverForInvalidLocations)
			{
				if (dropInfo.Action != null)
				{
					switch (dropInfo.HitTestLocation)
					{
					case global::Infragistics.Windows.DockManager.PaneLocation.Unknown:
					case global::Infragistics.Windows.DockManager.PaneLocation.DockedLeft:
					case global::Infragistics.Windows.DockManager.PaneLocation.DockedRight:
					case global::Infragistics.Windows.DockManager.PaneLocation.DockedTop:
					case global::Infragistics.Windows.DockManager.PaneLocation.DockedBottom:
					case global::Infragistics.Windows.DockManager.PaneLocation.Floating:
					case global::Infragistics.Windows.DockManager.PaneLocation.Document:
						if (!this.IsDropLocationAllowed(dropInfo.HitTestLocation))
						{
							dropInfo.Action = global::Infragistics.Windows.DockManager.Dragging.InvalidDropLocation.Instance;
						}
						break;
					}
				}
				else if (dropInfo.CenterIndicatorElement != null)
				{
					global::Infragistics.Windows.DockManager.Dragging.AllowedDropLocations location;
					if (dropInfo.CenterIndicatorElement is global::Infragistics.Windows.DockManager.DocumentContentHost)
					{
						location = (global::Infragistics.Windows.DockManager.Dragging.AllowedDropLocations.Left | global::Infragistics.Windows.DockManager.Dragging.AllowedDropLocations.Top | global::Infragistics.Windows.DockManager.Dragging.AllowedDropLocations.Right | global::Infragistics.Windows.DockManager.Dragging.AllowedDropLocations.Bottom | global::Infragistics.Windows.DockManager.Dragging.AllowedDropLocations.Document);
					}
					else if (dropInfo.HitTestLocation == global::Infragistics.Windows.DockManager.PaneLocation.Unknown)
					{
						location = global::Infragistics.Windows.DockManager.Dragging.AllowedDropLocations.Docked;
					}
					else
					{
						location = global::Infragistics.Windows.DockManager.Dragging.DragManager.GetDropLocation(dropInfo.HitTestLocation);
					}
					if (!this.IsDropLocationAllowed(location))
					{
						dropInfo.Action = global::Infragistics.Windows.DockManager.Dragging.InvalidDropLocation.Instance;
					}
				}
			}
			if (dropInfo.Action != global::Infragistics.Windows.DockManager.Dragging.InvalidDropLocation.Instance && !dropInfo.HideCenterIndicator && dropInfo.CenterIndicatorElement != null)
			{
				this.PositionCenterIndicator(dropInfo.CenterIndicatorElement);
			}
			if (dropInfo.ShowGlobalIndicators)
			{
				if (dropInfo.HideCenterIndicator)
				{
					this.HideIndicators(true, false);
				}
				this.ShowGlobalIndicators();
			}
			else
			{
				this.HideIndicators(dropInfo.HideCenterIndicator, true);
			}
			global::Infragistics.Windows.DockManager.DockingIndicatorPosition? dockingIndicatorPosition = null;
			global::Infragistics.Windows.DockManager.DockingIndicator dockingIndicator = null;
			if (!flag && dropInfo.Action == null)
			{
				dockingIndicator = this.GetHitTestIndicator(e, out dockingIndicatorPosition);
				if (dockingIndicator != null)
				{
					dropInfo.Action = this.GetIndicatorDragAction(dockingIndicator, dockingIndicatorPosition.Value);
					if (dropInfo.Action == null)
					{
						dropInfo.HideDropPreview = true;
						dockingIndicator = null;
						dockingIndicatorPosition = null;
					}
					else
					{
						dropInfo.HideDropPreview = false;
					}
				}
			}
			if (dropInfo.Action != null && dockingIndicator == null && !this._raisePaneDragOverForInvalidLocations && !dropInfo.Action.IsActionAllowed(this))
			{
				if (this.IsDropLocationAllowed(global::Infragistics.Windows.DockManager.Dragging.AllowedDropLocations.Floating))
				{
					dropInfo.Action = null;
				}
				else
				{
					dropInfo.Action = global::Infragistics.Windows.DockManager.Dragging.InvalidDropLocation.Instance;
					dropInfo.HideDropPreview = true;
				}
			}
			if (dropInfo.Action == null)
			{
				dropInfo.HideDropPreview = true;
				global::System.Windows.Point point = e.GetScreenPoint(this._dockManager);
				global::System.Windows.Point screenPoint = point;
				point.X -= this._mouseDownLocation.Value.X;
				point.Y -= this._mouseDownLocation.Value.Y;
				global::Infragistics.Windows.Controls.ToolWindow floatingWindow = this.FloatingWindow;
				if (floatingWindow == null && this._windowBeingDragged == null)
				{
					global::Infragistics.Windows.DockManager.ContentPane contentPane2 = (this._rootDragElement as global::Infragistics.Windows.DockManager.ContentPane) ?? (((global::Infragistics.Windows.DockManager.TabGroupPane)this._rootDragElement).SelectedItem as global::Infragistics.Windows.DockManager.ContentPane);
					global::System.Windows.Size size = (contentPane2 != null) ? contentPane2.LastFloatingSize : global::System.Windows.Size.Empty;
					if (size.IsEmpty)
					{
						size = new global::System.Windows.Size(this._rootDragElement.ActualWidth, this._rootDragElement.ActualHeight);
					}
					global::Infragistics.Windows.DockManager.DockManagerUtilities.AdjustFloatingLocation(screenPoint, ref point, size);
					dropInfo.Action = new global::Infragistics.Windows.DockManager.Dragging.FloatPaneAction(point, size);
				}
				else
				{
					global::Infragistics.Windows.Controls.ToolWindow toolWindow = (floatingWindow != null) ? floatingWindow : this._windowBeingDragged;
					global::System.Windows.Point point2 = new global::System.Windows.Point(toolWindow.Left, toolWindow.Top);
					global::Infragistics.Windows.DockManager.DockManagerUtilities.AdjustFloatingLocation(screenPoint, ref point, toolWindow.RenderSize);
					if (windowRect != null)
					{
						point = windowRect.Value.Location;
					}
					if (point2 != point)
					{
						dropInfo.Action = new global::Infragistics.Windows.DockManager.Dragging.MoveWindowAction(this.DeferFloatingWindowPositioning ? null : this._windowBeingDragged, point2, point);
					}
				}
			}
			if (this._lastHotTrackIndicator != null && (dockingIndicatorPosition == null || this._lastHotTrackIndicator != dockingIndicator))
			{
				this._lastHotTrackIndicator.ClearValue(global::Infragistics.Windows.DockManager.DockingIndicator.HotTrackPositionPropertyKey);
			}
			if (dropInfo.HideDropPreview)
			{
				this.HideDropPreview();
			}
			else if (this._floatingPreviewWindow != null && this._floatingPreviewWindow.IsVisible)
			{
				this._floatingPreviewWindow.Close();
			}
			if (dropInfo.Action != null)
			{
				global::Infragistics.Windows.DockManager.Dragging.DragManager.DragResult dragResult = null;
				this._dragResults.TryGetValue(dropInfo.Action, out dragResult);
				bool flag6 = false;
				if (dragResult == null)
				{
					global::Infragistics.Windows.DockManager.Events.PaneDragOverEventArgs paneDragOverEventArgs = new global::Infragistics.Windows.DockManager.Events.PaneDragOverEventArgs(this._panesBeingDragged, dropInfo.Action);
					paneDragOverEventArgs.IsValidDragAction = dropInfo.Action.IsActionAllowed(this);
					if (this._canRaiseDragEvents && (paneDragOverEventArgs.IsValidDragAction || this._raisePaneDragOverForInvalidLocations))
					{
						this._dockManager.RaisePaneDragOver(paneDragOverEventArgs);
						this.ProcessPendingCloseInDragMove();
						if (this._dragState != global::Infragistics.Windows.DockManager.Dragging.DragState.Dragging)
						{
							return;
						}
					}
					bool isValidDragAction = paneDragOverEventArgs.IsValidDragAction;
					global::System.Windows.Input.Cursor cursor = paneDragOverEventArgs.Cursor ?? (isValidDragAction ? this._defaultValidCursor : this._defaultInvalidCursor);
					dragResult = new global::Infragistics.Windows.DockManager.Dragging.DragManager.DragResult(cursor, isValidDragAction);
					flag6 = true;
				}
				if (this.RaisePaneDragOverInternal)
				{
					global::Infragistics.Windows.DockManager.Events.PaneDragOverEventArgs paneDragOverEventArgs2 = new global::Infragistics.Windows.DockManager.Events.PaneDragOverEventArgs(this._panesBeingDragged, dropInfo.Action);
					paneDragOverEventArgs2.IsValidDragAction = dragResult.IsValid;
					paneDragOverEventArgs2.Cursor = dragResult.Cursor;
					this._dockManager.OnPageDragOverInternal(paneDragOverEventArgs2);
					if (paneDragOverEventArgs2.IsValidDragAction != dragResult.IsValid || paneDragOverEventArgs2.Cursor != dragResult.Cursor)
					{
						dragResult = new global::Infragistics.Windows.DockManager.Dragging.DragManager.DragResult(paneDragOverEventArgs2.Cursor, paneDragOverEventArgs2.IsValidDragAction);
						flag6 = true;
					}
				}
				if (flag6)
				{
					if (dockingIndicator != null && dockingIndicatorPosition != null)
					{
						this.StoreIndicatorState(dockingIndicator, dockingIndicatorPosition.Value, dragResult.IsValid);
					}
					this._dragResults[dropInfo.Action] = dragResult;
				}
				if (!dragResult.IsValid)
				{
					this.HideDropPreview();
					if (this._lastHotTrackIndicator != null)
					{
						this._lastHotTrackIndicator.ClearValue(global::Infragistics.Windows.DockManager.DockingIndicator.HotTrackPositionPropertyKey);
					}
					dockingIndicator = null;
					dockingIndicatorPosition = null;
				}
				if (this._mouseCaptureHelper != null)
				{
					this._mouseCaptureHelper.Cursor = dragResult.Cursor;
				}
				else
				{
					global::System.Windows.Input.Mouse.OverrideCursor = dragResult.Cursor;
				}
				if (dragResult.IsValid)
				{
					dropInfo.Action.PerformAction(this, true);
					this.ProcessPendingCloseInDragMove();
					if (this._dragState != global::Infragistics.Windows.DockManager.Dragging.DragState.Dragging)
					{
						return;
					}
				}
			}
			this._lastHotTrackIndicator = dockingIndicator;
			if (dockingIndicatorPosition != null && dockingIndicator.HotTrackPosition != dockingIndicatorPosition.Value)
			{
				dockingIndicator.SetValue(global::Infragistics.Windows.DockManager.DockingIndicator.HotTrackPositionPropertyKey, dockingIndicatorPosition.Value);
			}
			global::Infragistics.Windows.Controls.ToolWindow floatingWindow2 = this.FloatingWindow;
			if (this._bringWindowToFront && floatingWindow2 != null && floatingWindow2.IsVisible)
			{
				floatingWindow2.BringToFront();
				this._bringWindowToFront = false;
			}
		}

		// Token: 0x0600034D RID: 845 RVA: 0x00012B7C File Offset: 0x00010D7C
		private void ProcessPendingCloseInDragMove()
		{
			if (this._pendingCancelDuringMouseMove != null)
			{
				bool value = this._pendingCancelDuringMouseMove.Value;
				this._pendingCancelDuringMouseMove = null;
				this.EndDrag(value);
			}
		}

		// Token: 0x0600034E RID: 846 RVA: 0x00012BB8 File Offset: 0x00010DB8
		private void ProcessPendingWindowClose()
		{
			if (this._windowsPendingClose != null)
			{
				global::Infragistics.Windows.DockManager.PaneToolWindow[] array = this._windowsPendingClose.ToArray<global::Infragistics.Windows.DockManager.PaneToolWindow>();
				this._windowsPendingClose.Clear();
				foreach (global::Infragistics.Windows.DockManager.PaneToolWindow paneToolWindow in array)
				{
					paneToolWindow.ForceRemainOpen = false;
				}
			}
		}

		// Token: 0x0600034F RID: 847 RVA: 0x00012BFF File Offset: 0x00010DFF
		private static void ReleaseToolWindow(ref global::Infragistics.Windows.Controls.ToolWindow toolWindow)
		{
			if (toolWindow != null)
			{
				toolWindow.Close();
				toolWindow.Resources.MergedDictionaries.Clear();
				toolWindow = null;
			}
		}

		// Token: 0x06000350 RID: 848 RVA: 0x00012C20 File Offset: 0x00010E20
		private void RemoveIndicators()
		{
			if (this._indicatorWindows != null)
			{
				this.HideIndicators(true, true);
				foreach (global::Infragistics.Windows.Controls.ToolWindow toolWindow in this._indicatorWindows)
				{
					if (toolWindow != null)
					{
						toolWindow.Resources.MergedDictionaries.Clear();
					}
				}
				this._indicatorWindows = null;
			}
		}

		// Token: 0x06000351 RID: 849 RVA: 0x00012C70 File Offset: 0x00010E70
		private void SetDragCaptureHelper(global::System.Windows.FrameworkContentElement dragHelper)
		{
			if (this._mouseCaptureHelper != null)
			{
				this._mouseCaptureHelper.LostMouseCapture -= this.OnDragElementLostCapture;
				this._mouseCaptureHelper.MouseUp -= this.OnDragElementMouseUp;
				this._mouseCaptureHelper.MouseMove -= this.OnDragElementMouseMove;
				this._mouseCaptureHelper.MouseDown -= this.OnDragElementMouseDown;
				this._mouseCaptureHelper.ClearValue(global::System.Windows.FrameworkContentElement.CursorProperty);
				this._mouseCaptureHelper.ReleaseMouseCapture();
			}
			this._mouseCaptureHelper = dragHelper;
			if (dragHelper != null)
			{
				dragHelper.LostMouseCapture += this.OnDragElementLostCapture;
				dragHelper.MouseUp += this.OnDragElementMouseUp;
				dragHelper.MouseMove += this.OnDragElementMouseMove;
				dragHelper.MouseDown += this.OnDragElementMouseDown;
			}
		}

		// Token: 0x06000352 RID: 850 RVA: 0x00012D50 File Offset: 0x00010F50
		private void ShowGlobalIndicators()
		{
			for (int i = 0; i < this._indicatorWindows.Length; i++)
			{
				global::Infragistics.Windows.DockManager.DockingIndicatorPosition dockingIndicatorPosition = (global::Infragistics.Windows.DockManager.DockingIndicatorPosition)i;
				global::Infragistics.Windows.Controls.ToolWindow toolWindow = this._indicatorWindows[i];
				if (dockingIndicatorPosition != global::Infragistics.Windows.DockManager.DockingIndicatorPosition.Center && !toolWindow.IsVisible && this._dockManager.MeetsVisibleCriteria(this.GlobalIndicatorsElement))
				{
					global::Infragistics.Windows.DockManager.DockManagerUtilities.ShowToolWindow(this._indicatorWindows[i], this.GlobalIndicatorsElement, false);
					this._bringWindowToFront = true;
				}
			}
		}

		// Token: 0x06000353 RID: 851 RVA: 0x00012DB4 File Offset: 0x00010FB4
		private bool StartDrag(global::System.Windows.FrameworkElement element, global::System.Windows.Point mouseDownPosition, global::Infragistics.Windows.DockManager.Dragging.DragManager.IInputDeviceInfo e, bool processMove, bool isWindowDragMode)
		{
			if (element == null)
			{
				return false;
			}
			global::Infragistics.Windows.DockManager.PaneLocation paneLocation = global::Infragistics.Windows.DockManager.XamDockManager.GetPaneLocation(element);
			global::Infragistics.Windows.DockManager.PaneLocation paneLocation2 = paneLocation;
			if (paneLocation2 == global::Infragistics.Windows.DockManager.PaneLocation.FloatingOnly)
			{
				this._canRaiseDragEvents = false;
				this._forceFloating = true;
			}
			else
			{
				this._forceFloating = false;
				this._canRaiseDragEvents = true;
			}
			global::System.Windows.FrameworkContentElement dragHelper = this._dockManager.DragHelper;
			if (global::Infragistics.Windows.DockManager.DockManagerUtilities.IsFloating(paneLocation))
			{
				global::Infragistics.Windows.DockManager.PaneToolWindow paneToolWindow = global::Infragistics.Windows.Controls.ToolWindow.GetToolWindow(element) as global::Infragistics.Windows.DockManager.PaneToolWindow;
				if (paneToolWindow != null)
				{
					dragHelper = paneToolWindow.DragHelper;
					if (paneToolWindow.WindowState == global::System.Windows.WindowState.Minimized)
					{
						this._canRaiseDragEvents = false;
						this._forceFloating = true;
					}
				}
			}
			global::Infragistics.Windows.DockManager.PaneToolWindow paneToolWindow2 = element as global::Infragistics.Windows.DockManager.PaneToolWindow;
			bool flag = false;
			if (!flag)
			{
				global::Infragistics.Windows.DockManager.Events.PaneDragStartingEventArgs paneDragStartingEventArgs = new global::Infragistics.Windows.DockManager.Events.PaneDragStartingEventArgs(element);
				paneDragStartingEventArgs.InvalidDragActionCursor = global::System.Windows.Input.Cursors.No;
				paneDragStartingEventArgs.ValidDragActionCursor = global::System.Windows.Input.Cursors.Arrow;
				if (paneDragStartingEventArgs.Panes.Count == 0)
				{
					flag = true;
				}
				else
				{
					if (!flag && paneToolWindow2 != null && paneToolWindow2.WindowState == global::System.Windows.WindowState.Maximized && !global::Infragistics.Windows.Controls.ToolWindow.RestoreCommand.CanExecute(null, paneToolWindow2))
					{
						paneDragStartingEventArgs.Cancel = true;
					}
					if (this._canRaiseDragEvents)
					{
						this._dockManager.RaisePaneDragStarting(paneDragStartingEventArgs);
					}
					flag = paneDragStartingEventArgs.Cancel;
				}
				if (!flag)
				{
					this._panesBeingDragged = paneDragStartingEventArgs.Panes;
					this._rootDragElement = paneDragStartingEventArgs.RootContainerElement;
					this._rootDragElementToolWindow = (global::Infragistics.Windows.Controls.ToolWindow.GetToolWindow(this._rootDragElement) as global::Infragistics.Windows.DockManager.PaneToolWindow);
					this._defaultInvalidCursor = paneDragStartingEventArgs.InvalidDragActionCursor;
					this._defaultValidCursor = paneDragStartingEventArgs.ValidDragActionCursor;
					this._raisePaneDragOverForInvalidLocations = paneDragStartingEventArgs.RaisePaneDragOverForInvalidLocations;
				}
			}
			bool dragFullWindows = this._dockManager.GetDragFullWindows(isWindowDragMode ? global::Infragistics.Windows.DockManager.FloatingWindowDragMode.UseSystemWindowDrag : this._dockManager.FloatingWindowDragMode);
			if (!flag && element is global::Infragistics.Windows.DockManager.PaneToolWindow && !isWindowDragMode && dragFullWindows && paneToolWindow2.WindowState == global::System.Windows.WindowState.Maximized)
			{
				processMove = true;
				paneToolWindow2.WindowState = global::System.Windows.WindowState.Normal;
				if (!paneToolWindow2.IsVisible || paneToolWindow2.WindowState != global::System.Windows.WindowState.Normal)
				{
					flag = true;
				}
			}
			if (!flag && !isWindowDragMode)
			{
				dragHelper.CaptureMouse();
				flag = !dragHelper.IsMouseCaptured;
			}
			if (flag)
			{
				this._panesBeingDragged = null;
				this._rootDragElement = null;
				return false;
			}
			this.RaisePaneDragOverInternal = (this._canRaiseDragEvents && this._dockManager.HasPaneDragOverInternalListeners);
			this._lastActivePane = this._dockManager.ActivePane;
			this._lastFocusedElement = global::System.Windows.Input.Keyboard.FocusedElement;
			this._dropInfo = new global::Infragistics.Windows.DockManager.Dragging.DragManager.DropInfo();
			this._dragFullWindows = dragFullWindows;
			this._deferFloatingWindowPositioning = (!this._dragFullWindows && !isWindowDragMode && (!global::Infragistics.Windows.Controls.ToolWindow.WillHostInWindow(this._dockManager) || this._dockManager.FloatingWindowDragMode != global::Infragistics.Windows.DockManager.FloatingWindowDragMode.UseSystemWindowDrag));
			this._tabItemDragBehavior = this._dockManager.TabItemDragBehavior;
			this._windowBeingDragged = (element as global::Infragistics.Windows.DockManager.PaneToolWindow);
			this._initialDragElement = element;
			this.IsInWindowDragMode = isWindowDragMode;
			if (element is global::Infragistics.Windows.DockManager.PaneTabItem)
			{
				global::Infragistics.Windows.DockManager.TabGroupPane tabGroupPane = global::System.Windows.Controls.ItemsControl.ItemsControlFromItemContainer(element) as global::Infragistics.Windows.DockManager.TabGroupPane;
				if (tabGroupPane != null && tabGroupPane.HeaderArea != null && element.IsDescendantOf(tabGroupPane.HeaderArea))
				{
					mouseDownPosition = element.TransformToAncestor(tabGroupPane.HeaderArea).Transform(mouseDownPosition);
				}
			}
			this._mouseDownLocation = new global::System.Windows.Point?(mouseDownPosition);
			this._dragState = global::Infragistics.Windows.DockManager.Dragging.DragState.Dragging;
			if (!isWindowDragMode)
			{
				this.SetDragCaptureHelper(dragHelper);
			}
			this._keyFocusWatcher = new global::Infragistics.Windows.DockManager.KeyEventFocusWatcher();
			this._keyFocusWatcher.KeyEvent += this.OnKeyFocusWatcherKeyEvent;
			this._globalIndicatorState = new global::Infragistics.Windows.DockManager.Dragging.DragManager.IndicatorEnabledState();
			this._indicatorStates = new global::System.Collections.Generic.Dictionary<global::System.Windows.FrameworkElement, global::Infragistics.Windows.DockManager.Dragging.DragManager.IndicatorEnabledState>();
			this._dragResults = new global::System.Collections.Generic.Dictionary<global::Infragistics.Windows.DockManager.Dragging.PaneDragAction, global::Infragistics.Windows.DockManager.Dragging.DragManager.DragResult>(new global::Infragistics.Windows.DockManager.Dragging.DragActionComparer());
			this._dragResults.Add(global::Infragistics.Windows.DockManager.Dragging.InvalidDropLocation.Instance, new global::Infragistics.Windows.DockManager.Dragging.DragManager.DragResult(this._defaultInvalidCursor, false));
			this.CreateIndicators();
			this._allowedLocations = this.GetAllowedDropLocations(this._panesBeingDragged);
			this._isDraggingDocuments = (global::Infragistics.Windows.DockManager.XamDockManager.GetPaneLocation(this._panesBeingDragged[0]) == global::Infragistics.Windows.DockManager.PaneLocation.Document);
			if (!isWindowDragMode && this._mouseCaptureHelper == dragHelper)
			{
				if (global::System.Windows.LogicalTreeHelper.GetParent(dragHelper) is global::Infragistics.Windows.Controls.ToolWindow)
				{
					dragHelper.Focus();
				}
				else
				{
					this._dockManager.ForceFocus(dragHelper);
				}
			}
			if (processMove)
			{
				this.ProcessDragMove(e, null);
			}
			return true;
		}

		// Token: 0x06000354 RID: 852 RVA: 0x0001318C File Offset: 0x0001138C
		private void StoreIndicatorState(global::Infragistics.Windows.DockManager.DockingIndicator indicator, global::Infragistics.Windows.DockManager.DockingIndicatorPosition position, bool isEnabled)
		{
			global::Infragistics.Windows.DockManager.Dragging.DragManager.IndicatorEnabledState globalIndicatorState;
			if (indicator.Position == global::Infragistics.Windows.DockManager.DockingIndicatorPosition.Center)
			{
				global::Infragistics.Windows.Controls.ToolWindow toolWindow = global::Infragistics.Windows.Controls.ToolWindow.GetToolWindow(indicator);
				if (!this._indicatorStates.TryGetValue(toolWindow.Owner, out globalIndicatorState))
				{
					return;
				}
			}
			else
			{
				globalIndicatorState = this._globalIndicatorState;
			}
			switch (position)
			{
			case global::Infragistics.Windows.DockManager.DockingIndicatorPosition.Center:
				globalIndicatorState.Center = new bool?(isEnabled);
				return;
			case global::Infragistics.Windows.DockManager.DockingIndicatorPosition.Left:
				globalIndicatorState.Left = new bool?(isEnabled);
				return;
			case global::Infragistics.Windows.DockManager.DockingIndicatorPosition.Top:
				globalIndicatorState.Top = new bool?(isEnabled);
				return;
			case global::Infragistics.Windows.DockManager.DockingIndicatorPosition.Right:
				globalIndicatorState.Right = new bool?(isEnabled);
				return;
			case global::Infragistics.Windows.DockManager.DockingIndicatorPosition.Bottom:
				globalIndicatorState.Bottom = new bool?(isEnabled);
				return;
			default:
				return;
			}
		}

		// Token: 0x06000355 RID: 853 RVA: 0x00013222 File Offset: 0x00011422
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
		private void SwitchToWindowDrag()
		{
			this._dockManager.Dispatcher.BeginInvoke(global::System.Windows.Threading.DispatcherPriority.Input, new global::Infragistics.Windows.DockManager.DockManagerUtilities.MethodInvoker(this.OnDelayedSwitchToWindowDrag));
		}

		// Token: 0x06000356 RID: 854 RVA: 0x00013244 File Offset: 0x00011444
		private void OnDelayedSwitchToWindowDrag()
		{
			if (this.DragState != global::Infragistics.Windows.DockManager.Dragging.DragState.Dragging)
			{
				return;
			}
			global::Infragistics.Windows.Controls.ToolWindow floatingWindow = this.FloatingWindow;
			if (floatingWindow == null)
			{
				return;
			}
			this.SetDragCaptureHelper(null);
			this.IsInWindowDragMode = true;
			global::System.Windows.Input.MouseDevice primaryDevice = global::System.Windows.Input.Mouse.PrimaryDevice;
			if (primaryDevice == null || primaryDevice.LeftButton != global::System.Windows.Input.MouseButtonState.Pressed)
			{
				this.EndDrag(true);
				return;
			}
			floatingWindow.Host.DragMove(new global::System.Windows.Input.MouseEventArgs(primaryDevice, 0));
		}

		// Token: 0x06000357 RID: 855 RVA: 0x000132A0 File Offset: 0x000114A0
		private void UnhookElementPendingDrag(global::System.Windows.FrameworkElement element)
		{
			element.RemoveHandler(global::System.Windows.UIElement.LostMouseCaptureEvent, new global::System.Windows.Input.MouseEventHandler(this.OnPendingDragElementLostCapture));
			element.RemoveHandler(global::System.Windows.UIElement.MouseUpEvent, new global::System.Windows.Input.MouseButtonEventHandler(this.OnPendingDragElementMouseUp));
			element.RemoveHandler(global::System.Windows.UIElement.MouseMoveEvent, new global::System.Windows.Input.MouseEventHandler(this.OnPendingDragElementMouseMove));
		}

		// Token: 0x06000358 RID: 856 RVA: 0x000132F4 File Offset: 0x000114F4
		private void VerifyControlKeyStateChanged()
		{
			if (this._dragMoveCache != null && this._dragState == global::Infragistics.Windows.DockManager.Dragging.DragState.Dragging && !this._forceFloating && this._dragMoveCache.WasControlKeyDown != global::Infragistics.Windows.DockManager.Dragging.DragManager.IsControlKeyDown)
			{
				this.ProcessDragMove(this._dragMoveCache.DeviceInfo, this._dragMoveCache.WindowRect);
			}
		}

		// Token: 0x06000359 RID: 857 RVA: 0x00013348 File Offset: 0x00011548
		private void VerifySystemControlKeyState()
		{
			this.VerifyControlKeyStateChanged();
		}

		// Token: 0x0400018E RID: 398
		private const bool DebugTabItemPreview = false;

		// Token: 0x0400018F RID: 399
		private global::Infragistics.Windows.DockManager.XamDockManager _dockManager;

		// Token: 0x04000190 RID: 400
		private global::Infragistics.Windows.DockManager.Dragging.DragState _dragState;

		// Token: 0x04000191 RID: 401
		private global::System.Windows.Point? _mouseDownLocation;

		// Token: 0x04000192 RID: 402
		private global::System.Windows.FrameworkContentElement _mouseCaptureHelper;

		// Token: 0x04000193 RID: 403
		private global::Infragistics.Windows.Controls.ToolWindow[] _indicatorWindows;

		// Token: 0x04000194 RID: 404
		private static readonly global::System.Windows.Controls.ControlTemplate IndicatorToolWindowTemplate;

		// Token: 0x04000195 RID: 405
		private static readonly global::System.Windows.Controls.ControlTemplate IndicatorToolWindowTemplateWhite;

		// Token: 0x04000196 RID: 406
		private global::Infragistics.Windows.DockManager.DockingIndicator _lastHotTrackIndicator;

		// Token: 0x04000197 RID: 407
		private global::System.Collections.ObjectModel.ReadOnlyCollection<global::Infragistics.Windows.DockManager.ContentPane> _panesBeingDragged;

		// Token: 0x04000198 RID: 408
		private global::Infragistics.Windows.DockManager.KeyEventFocusWatcher _keyFocusWatcher;

		// Token: 0x04000199 RID: 409
		private global::Infragistics.Windows.DockManager.Dragging.AllowedDropLocations _allowedLocations;

		// Token: 0x0400019A RID: 410
		private bool _isDraggingDocuments;

		// Token: 0x0400019B RID: 411
		private global::Infragistics.Windows.DockManager.Dragging.DragManager.DropInfo _dropInfo;

		// Token: 0x0400019C RID: 412
		private global::Infragistics.Windows.DockManager.PaneToolWindow _windowBeingDragged;

		// Token: 0x0400019D RID: 413
		private global::System.Windows.UIElement _initialDragElement;

		// Token: 0x0400019E RID: 414
		private global::System.Windows.FrameworkElement _rootDragElement;

		// Token: 0x0400019F RID: 415
		private global::Infragistics.Windows.DockManager.PaneToolWindow _rootDragElementToolWindow;

		// Token: 0x040001A0 RID: 416
		private global::Infragistics.Windows.Controls.ToolWindow _dropPreviewWindow;

		// Token: 0x040001A1 RID: 417
		private global::System.Collections.Generic.Dictionary<global::System.Windows.FrameworkElement, global::Infragistics.Windows.DockManager.Dragging.DragManager.IndicatorEnabledState> _indicatorStates;

		// Token: 0x040001A2 RID: 418
		private global::Infragistics.Windows.DockManager.Dragging.DragManager.IndicatorEnabledState _globalIndicatorState;

		// Token: 0x040001A3 RID: 419
		private global::System.Collections.Generic.Dictionary<global::Infragistics.Windows.DockManager.Dragging.PaneDragAction, global::Infragistics.Windows.DockManager.Dragging.DragManager.DragResult> _dragResults;

		// Token: 0x040001A4 RID: 420
		private global::System.Windows.IInputElement _lastFocusedElement;

		// Token: 0x040001A5 RID: 421
		private global::Infragistics.Windows.DockManager.ContentPane _lastActivePane;

		// Token: 0x040001A6 RID: 422
		private global::System.Windows.Input.Cursor _defaultValidCursor;

		// Token: 0x040001A7 RID: 423
		private global::System.Windows.Input.Cursor _defaultInvalidCursor;

		// Token: 0x040001A8 RID: 424
		private bool _raisePaneDragOverForInvalidLocations;

		// Token: 0x040001A9 RID: 425
		private bool _bringWindowToFront;

		// Token: 0x040001AA RID: 426
		private bool _dragFullWindows;

		// Token: 0x040001AB RID: 427
		private global::Infragistics.Windows.Controls.ToolWindow _floatingPreviewWindow;

		// Token: 0x040001AC RID: 428
		private bool _canRaiseDragEvents;

		// Token: 0x040001AD RID: 429
		private bool _forceFloating;

		// Token: 0x040001AE RID: 430
		private global::Infragistics.Windows.DockManager.TabItemDragBehavior _tabItemDragBehavior;

		// Token: 0x040001AF RID: 431
		private global::Infragistics.Windows.Controls.ToolWindow _tabItemDropPreviewWindow;

		// Token: 0x040001B0 RID: 432
		private bool RaisePaneDragOverInternal;

		// Token: 0x040001B1 RID: 433
		private bool _isWindowDragMode;

		// Token: 0x040001B2 RID: 434
		private bool _deferFloatingWindowPositioning;

		// Token: 0x040001B3 RID: 435
		private global::System.Threading.Timer _windowDragModeKeyTimer;

		// Token: 0x040001B4 RID: 436
		private global::Infragistics.Windows.DockManager.Dragging.DragManager.DragMoveCache _dragMoveCache;

		// Token: 0x040001B5 RID: 437
		private global::Infragistics.Windows.Helpers.HashSet _windowsPendingClose;

		// Token: 0x040001B6 RID: 438
		private bool _isProcessingMouseMove;

		// Token: 0x040001B7 RID: 439
		private bool? _pendingCancelDuringMouseMove;

		// Token: 0x02000039 RID: 57
		private class DragResult
		{
			// Token: 0x0600035A RID: 858 RVA: 0x00013350 File Offset: 0x00011550
			internal DragResult(global::System.Windows.Input.Cursor cursor, bool isValid)
			{
				this._isValid = isValid;
				this._cursor = cursor;
			}

			// Token: 0x170000AB RID: 171
			// (get) Token: 0x0600035B RID: 859 RVA: 0x00013366 File Offset: 0x00011566
			internal global::System.Windows.Input.Cursor Cursor
			{
				get
				{
					return this._cursor;
				}
			}

			// Token: 0x170000AC RID: 172
			// (get) Token: 0x0600035C RID: 860 RVA: 0x0001336E File Offset: 0x0001156E
			internal bool IsValid
			{
				get
				{
					return this._isValid;
				}
			}

			// Token: 0x040001B8 RID: 440
			private global::System.Windows.Input.Cursor _cursor;

			// Token: 0x040001B9 RID: 441
			private bool _isValid;
		}

		// Token: 0x0200003A RID: 58
		private class DragToolWindow : global::Infragistics.Windows.Controls.ToolWindow
		{
			// Token: 0x0600035D RID: 861 RVA: 0x00013378 File Offset: 0x00011578
			static DragToolWindow()
			{
				global::Infragistics.Windows.Themes.ThemeManager.RegisterGroupings(typeof(global::Infragistics.Windows.DockManager.Dragging.DragManager.DragToolWindow), new string[]
				{
					global::Infragistics.Windows.Themes.PrimitivesResourceSet<global::Infragistics.Windows.Themes.PrimitivesGeneric.Locator>.Location.Grouping,
					global::Infragistics.Windows.Themes.DockManagerResourceSet<global::Infragistics.Windows.Themes.DockManagerGeneric.Locator>.Location.Grouping
				});
			}

			// Token: 0x0600035E RID: 862 RVA: 0x000133B8 File Offset: 0x000115B8
			internal static global::Infragistics.Windows.DockManager.Dragging.DragManager.DragToolWindow Create(global::Infragistics.Windows.DockManager.XamDockManager dockManager)
			{
				global::Infragistics.Windows.DockManager.Dragging.DragManager.DragToolWindow dragToolWindow = new global::Infragistics.Windows.DockManager.Dragging.DragManager.DragToolWindow();
				dragToolWindow.ResizeMode = global::System.Windows.ResizeMode.NoResize;
				dragToolWindow.UseOSNonClientArea = false;
				dragToolWindow.Template = global::Infragistics.Windows.DockManager.Dragging.DragManager.GetIndicatorToolWindowTemplate(dockManager);
				dragToolWindow.SetValue(global::Infragistics.Windows.DockManager.XamDockManager.DockManagerPropertyKey, dockManager);
				dragToolWindow.IsOwnedWindow = false;
				dragToolWindow.SetBinding(global::System.Windows.FrameworkElement.FlowDirectionProperty, global::Infragistics.Windows.Utilities.CreateBindingObject(global::System.Windows.FrameworkElement.FlowDirectionProperty, global::System.Windows.Data.BindingMode.OneWay, dockManager));
				if (dockManager != null)
				{
					dragToolWindow.Resources.MergedDictionaries.Add(dockManager.Resources);
				}
				return dragToolWindow;
			}

			// Token: 0x170000AD RID: 173
			// (get) Token: 0x0600035F RID: 863 RVA: 0x0001342A File Offset: 0x0001162A
			internal override bool KeepOnScreen
			{
				get
				{
					return false;
				}
			}
		}

		// Token: 0x0200003B RID: 59
		private class DropInfo
		{
			// Token: 0x06000361 RID: 865 RVA: 0x00013435 File Offset: 0x00011635
			internal DropInfo()
			{
				this.Reset();
			}

			// Token: 0x06000362 RID: 866 RVA: 0x00013443 File Offset: 0x00011643
			internal void Reset()
			{
				this.Action = null;
				this.ShowFloatingWindow = true;
				this.ShowGlobalIndicators = false;
				this.HideCenterIndicator = true;
				this.HideDropPreview = true;
				this.CenterIndicatorElement = null;
				this.HitTestLocation = global::Infragistics.Windows.DockManager.PaneLocation.Unknown;
			}

			// Token: 0x040001BA RID: 442
			public global::Infragistics.Windows.DockManager.Dragging.PaneDragAction Action;

			// Token: 0x040001BB RID: 443
			public bool ShowGlobalIndicators;

			// Token: 0x040001BC RID: 444
			public bool ShowFloatingWindow;

			// Token: 0x040001BD RID: 445
			public bool HideCenterIndicator;

			// Token: 0x040001BE RID: 446
			public bool HideDropPreview;

			// Token: 0x040001BF RID: 447
			public global::System.Windows.DependencyObject CenterIndicatorElement;

			// Token: 0x040001C0 RID: 448
			public global::Infragistics.Windows.DockManager.PaneLocation HitTestLocation;
		}

		// Token: 0x0200003C RID: 60
		private class IndicatorEnabledState
		{
			// Token: 0x170000AE RID: 174
			// (get) Token: 0x06000363 RID: 867 RVA: 0x00013476 File Offset: 0x00011676
			// (set) Token: 0x06000364 RID: 868 RVA: 0x00013483 File Offset: 0x00011683
			internal bool? Center
			{
				get
				{
					return this.GetValue(global::Infragistics.Windows.DockManager.Dragging.DragManager.IndicatorEnabledState._centerSection);
				}
				set
				{
					this.SetValue(global::Infragistics.Windows.DockManager.Dragging.DragManager.IndicatorEnabledState._centerSection, value);
				}
			}

			// Token: 0x170000AF RID: 175
			// (get) Token: 0x06000365 RID: 869 RVA: 0x00013491 File Offset: 0x00011691
			// (set) Token: 0x06000366 RID: 870 RVA: 0x0001349E File Offset: 0x0001169E
			internal bool? Left
			{
				get
				{
					return this.GetValue(global::Infragistics.Windows.DockManager.Dragging.DragManager.IndicatorEnabledState._leftSection);
				}
				set
				{
					this.SetValue(global::Infragistics.Windows.DockManager.Dragging.DragManager.IndicatorEnabledState._leftSection, value);
				}
			}

			// Token: 0x170000B0 RID: 176
			// (get) Token: 0x06000367 RID: 871 RVA: 0x000134AC File Offset: 0x000116AC
			// (set) Token: 0x06000368 RID: 872 RVA: 0x000134B9 File Offset: 0x000116B9
			internal bool? Right
			{
				get
				{
					return this.GetValue(global::Infragistics.Windows.DockManager.Dragging.DragManager.IndicatorEnabledState._rightSection);
				}
				set
				{
					this.SetValue(global::Infragistics.Windows.DockManager.Dragging.DragManager.IndicatorEnabledState._rightSection, value);
				}
			}

			// Token: 0x170000B1 RID: 177
			// (get) Token: 0x06000369 RID: 873 RVA: 0x000134C7 File Offset: 0x000116C7
			// (set) Token: 0x0600036A RID: 874 RVA: 0x000134D4 File Offset: 0x000116D4
			internal bool? Top
			{
				get
				{
					return this.GetValue(global::Infragistics.Windows.DockManager.Dragging.DragManager.IndicatorEnabledState._topSection);
				}
				set
				{
					this.SetValue(global::Infragistics.Windows.DockManager.Dragging.DragManager.IndicatorEnabledState._topSection, value);
				}
			}

			// Token: 0x170000B2 RID: 178
			// (get) Token: 0x0600036B RID: 875 RVA: 0x000134E2 File Offset: 0x000116E2
			// (set) Token: 0x0600036C RID: 876 RVA: 0x000134EF File Offset: 0x000116EF
			internal bool? Bottom
			{
				get
				{
					return this.GetValue(global::Infragistics.Windows.DockManager.Dragging.DragManager.IndicatorEnabledState._bottomSection);
				}
				set
				{
					this.SetValue(global::Infragistics.Windows.DockManager.Dragging.DragManager.IndicatorEnabledState._bottomSection, value);
				}
			}

			// Token: 0x0600036D RID: 877 RVA: 0x00013500 File Offset: 0x00011700
			private bool? GetValue(global::System.Collections.Specialized.BitVector32.Section section)
			{
				if (section == global::Infragistics.Windows.DockManager.Dragging.DragManager.IndicatorEnabledState._centerSection)
				{
					return this._center;
				}
				int num = this._flags[section];
				if (num == 0)
				{
					return null;
				}
				return new bool?(num == 16);
			}

			// Token: 0x0600036E RID: 878 RVA: 0x00013548 File Offset: 0x00011748
			private void SetValue(global::System.Collections.Specialized.BitVector32.Section section, bool? value)
			{
				if (section == global::Infragistics.Windows.DockManager.Dragging.DragManager.IndicatorEnabledState._centerSection)
				{
					this._center = value;
					return;
				}
				int value2 = (value == null) ? 0 : (value.Value ? 16 : 1);
				this._flags[section] = value2;
			}

			// Token: 0x0600036F RID: 879 RVA: 0x00013592 File Offset: 0x00011792
			private static object GetDependencyValue(bool? value)
			{
				if (value == null)
				{
					return global::System.Windows.DependencyProperty.UnsetValue;
				}
				if (value.Value)
				{
					return global::Infragistics.KnownBoxes.TrueBox;
				}
				return global::Infragistics.KnownBoxes.FalseBox;
			}

			// Token: 0x06000370 RID: 880 RVA: 0x000135B8 File Offset: 0x000117B8
			internal void Initialize(global::Infragistics.Windows.DockManager.DockingIndicator indicator)
			{
				indicator.SetValue(global::Infragistics.Windows.DockManager.DockingIndicator.CanDockCenterPropertyKey, global::Infragistics.Windows.DockManager.Dragging.DragManager.IndicatorEnabledState.GetDependencyValue(this.GetValue(global::Infragistics.Windows.DockManager.Dragging.DragManager.IndicatorEnabledState._centerSection)));
				indicator.SetValue(global::Infragistics.Windows.DockManager.DockingIndicator.CanDockLeftPropertyKey, global::Infragistics.Windows.DockManager.Dragging.DragManager.IndicatorEnabledState.GetDependencyValue(this.GetValue(global::Infragistics.Windows.DockManager.Dragging.DragManager.IndicatorEnabledState._leftSection)));
				indicator.SetValue(global::Infragistics.Windows.DockManager.DockingIndicator.CanDockRightPropertyKey, global::Infragistics.Windows.DockManager.Dragging.DragManager.IndicatorEnabledState.GetDependencyValue(this.GetValue(global::Infragistics.Windows.DockManager.Dragging.DragManager.IndicatorEnabledState._rightSection)));
				indicator.SetValue(global::Infragistics.Windows.DockManager.DockingIndicator.CanDockTopPropertyKey, global::Infragistics.Windows.DockManager.Dragging.DragManager.IndicatorEnabledState.GetDependencyValue(this.GetValue(global::Infragistics.Windows.DockManager.Dragging.DragManager.IndicatorEnabledState._topSection)));
				indicator.SetValue(global::Infragistics.Windows.DockManager.DockingIndicator.CanDockBottomPropertyKey, global::Infragistics.Windows.DockManager.Dragging.DragManager.IndicatorEnabledState.GetDependencyValue(this.GetValue(global::Infragistics.Windows.DockManager.Dragging.DragManager.IndicatorEnabledState._bottomSection)));
			}

			// Token: 0x040001C1 RID: 449
			private const int Unset = 0;

			// Token: 0x040001C2 RID: 450
			private const int Disabled = 1;

			// Token: 0x040001C3 RID: 451
			private const int Enabled = 16;

			// Token: 0x040001C4 RID: 452
			private static global::System.Collections.Specialized.BitVector32.Section _leftSection = global::System.Collections.Specialized.BitVector32.CreateSection(255);

			// Token: 0x040001C5 RID: 453
			private static global::System.Collections.Specialized.BitVector32.Section _rightSection = global::System.Collections.Specialized.BitVector32.CreateSection(255, global::Infragistics.Windows.DockManager.Dragging.DragManager.IndicatorEnabledState._leftSection);

			// Token: 0x040001C6 RID: 454
			private static global::System.Collections.Specialized.BitVector32.Section _topSection = global::System.Collections.Specialized.BitVector32.CreateSection(255, global::Infragistics.Windows.DockManager.Dragging.DragManager.IndicatorEnabledState._rightSection);

			// Token: 0x040001C7 RID: 455
			private static global::System.Collections.Specialized.BitVector32.Section _bottomSection = global::System.Collections.Specialized.BitVector32.CreateSection(255, global::Infragistics.Windows.DockManager.Dragging.DragManager.IndicatorEnabledState._topSection);

			// Token: 0x040001C8 RID: 456
			private static global::System.Collections.Specialized.BitVector32.Section _centerSection = global::System.Collections.Specialized.BitVector32.CreateSection(4095);

			// Token: 0x040001C9 RID: 457
			private global::System.Collections.Specialized.BitVector32 _flags;

			// Token: 0x040001CA RID: 458
			private bool? _center;
		}

		// Token: 0x0200003D RID: 61
		private interface IInputDeviceInfo
		{
			// Token: 0x06000373 RID: 883
			global::System.Windows.Point GetPosition(global::System.Windows.IInputElement relativeTo);

			// Token: 0x06000374 RID: 884
			global::System.Windows.Point GetScreenPoint(global::System.Windows.FrameworkElement relativeElement);

			// Token: 0x170000B3 RID: 179
			// (get) Token: 0x06000375 RID: 885
			global::System.Windows.Input.MouseButton? ChangedButton { get; }
		}

		// Token: 0x0200003E RID: 62
		private class MouseArgsInputDeviceInfo : global::Infragistics.Windows.DockManager.Dragging.DragManager.IInputDeviceInfo
		{
			// Token: 0x06000376 RID: 886 RVA: 0x000136BB File Offset: 0x000118BB
			internal MouseArgsInputDeviceInfo(global::System.Windows.Input.MouseEventArgs args)
			{
				this._args = args;
			}

			// Token: 0x06000377 RID: 887 RVA: 0x000136CA File Offset: 0x000118CA
			global::System.Windows.Point global::Infragistics.Windows.DockManager.Dragging.DragManager.IInputDeviceInfo.GetPosition(global::System.Windows.IInputElement relativeTo)
			{
				return this._args.GetPosition(relativeTo);
			}

			// Token: 0x06000378 RID: 888 RVA: 0x000136D8 File Offset: 0x000118D8
			global::System.Windows.Point global::Infragistics.Windows.DockManager.Dragging.DragManager.IInputDeviceInfo.GetScreenPoint(global::System.Windows.FrameworkElement relativeElement)
			{
				return global::Infragistics.Windows.Controls.ToolWindow.GetScreenPoint(relativeElement, this._args);
			}

			// Token: 0x170000B4 RID: 180
			// (get) Token: 0x06000379 RID: 889 RVA: 0x000136E8 File Offset: 0x000118E8
			global::System.Windows.Input.MouseButton? global::Infragistics.Windows.DockManager.Dragging.DragManager.IInputDeviceInfo.ChangedButton
			{
				get
				{
					global::System.Windows.Input.MouseButtonEventArgs mouseButtonEventArgs = this._args as global::System.Windows.Input.MouseButtonEventArgs;
					if (mouseButtonEventArgs != null)
					{
						return new global::System.Windows.Input.MouseButton?(mouseButtonEventArgs.ChangedButton);
					}
					return null;
				}
			}

			// Token: 0x040001CB RID: 459
			private global::System.Windows.Input.MouseEventArgs _args;
		}

		// Token: 0x0200003F RID: 63
		private class ScreenInputDeviceInfo : global::Infragistics.Windows.DockManager.Dragging.DragManager.IInputDeviceInfo
		{
			// Token: 0x0600037A RID: 890 RVA: 0x00013719 File Offset: 0x00011919
			internal ScreenInputDeviceInfo(global::System.Windows.Point screenPoint)
			{
				this._screenPoint = screenPoint;
			}

			// Token: 0x0600037B RID: 891 RVA: 0x00013728 File Offset: 0x00011928
			global::System.Windows.Point global::Infragistics.Windows.DockManager.Dragging.DragManager.IInputDeviceInfo.GetPosition(global::System.Windows.IInputElement relativeTo)
			{
				global::System.Windows.DependencyObject dependencyObject = relativeTo as global::System.Windows.DependencyObject;
				while (dependencyObject != null && !(dependencyObject is global::System.Windows.Media.Visual))
				{
					dependencyObject = global::Infragistics.Windows.Utilities.GetParent(dependencyObject, true);
				}
				if (dependencyObject == null)
				{
					return default(global::System.Windows.Point);
				}
				return global::Infragistics.Windows.Utilities.PointFromScreenSafe(dependencyObject as global::System.Windows.Media.Visual, this._screenPoint);
			}

			// Token: 0x0600037C RID: 892 RVA: 0x00013770 File Offset: 0x00011970
			global::System.Windows.Point global::Infragistics.Windows.DockManager.Dragging.DragManager.IInputDeviceInfo.GetScreenPoint(global::System.Windows.FrameworkElement relativeElement)
			{
				global::System.Windows.Point point = global::Infragistics.Windows.Utilities.PointFromScreenSafe(relativeElement, this._screenPoint);
				return global::Infragistics.Windows.Utilities.PointToScreenSafe(relativeElement, point);
			}

			// Token: 0x170000B5 RID: 181
			// (get) Token: 0x0600037D RID: 893 RVA: 0x00013794 File Offset: 0x00011994
			global::System.Windows.Input.MouseButton? global::Infragistics.Windows.DockManager.Dragging.DragManager.IInputDeviceInfo.ChangedButton
			{
				get
				{
					return null;
				}
			}

			// Token: 0x040001CC RID: 460
			private global::System.Windows.Point _screenPoint;
		}

		// Token: 0x02000040 RID: 64
		private class DragMoveCache
		{
			// Token: 0x040001CD RID: 461
			internal global::System.Windows.Rect? WindowRect;

			// Token: 0x040001CE RID: 462
			internal global::Infragistics.Windows.DockManager.Dragging.DragManager.IInputDeviceInfo DeviceInfo;

			// Token: 0x040001CF RID: 463
			internal bool WasControlKeyDown;
		}
	}
}
