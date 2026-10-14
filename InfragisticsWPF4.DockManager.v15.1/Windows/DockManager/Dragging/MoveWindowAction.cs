using System;
using System.Windows;
using Infragistics.Windows.Controls;

namespace Infragistics.Windows.DockManager.Dragging
{
	// Token: 0x02000046 RID: 70
	public class MoveWindowAction : global::Infragistics.Windows.DockManager.Dragging.PaneDragAction
	{
		// Token: 0x06000384 RID: 900 RVA: 0x000137CB File Offset: 0x000119CB
		public MoveWindowAction(global::Infragistics.Windows.DockManager.PaneToolWindow window, global::System.Windows.Point oldLocation, global::System.Windows.Point newLocation)
		{
			this._window = window;
			this._oldLocation = oldLocation;
			this._newLocation = newLocation;
		}

		// Token: 0x170000B6 RID: 182
		// (get) Token: 0x06000385 RID: 901 RVA: 0x000137E8 File Offset: 0x000119E8
		public global::Infragistics.Windows.DockManager.PaneToolWindow Window
		{
			get
			{
				return this._window;
			}
		}

		// Token: 0x170000B7 RID: 183
		// (get) Token: 0x06000386 RID: 902 RVA: 0x000137F0 File Offset: 0x000119F0
		public global::System.Windows.Point OldLocation
		{
			get
			{
				return this._oldLocation;
			}
		}

		// Token: 0x170000B8 RID: 184
		// (get) Token: 0x06000387 RID: 903 RVA: 0x000137F8 File Offset: 0x000119F8
		// (set) Token: 0x06000388 RID: 904 RVA: 0x00013800 File Offset: 0x00011A00
		public global::System.Windows.Point NewLocation
		{
			get
			{
				return this._newLocation;
			}
			set
			{
				this._newLocation = value;
			}
		}

		// Token: 0x06000389 RID: 905 RVA: 0x00013809 File Offset: 0x00011A09
		internal override int GetDragHashCode()
		{
			if (this._window == null)
			{
				return this._newLocation.GetHashCode();
			}
			return this._newLocation.GetHashCode() | this._window.GetHashCode();
		}

		// Token: 0x0600038A RID: 906 RVA: 0x00013842 File Offset: 0x00011A42
		internal override bool IsActionAllowed(global::Infragistics.Windows.DockManager.Dragging.DragManager dragManager)
		{
			return dragManager.IsDropLocationAllowed(global::Infragistics.Windows.DockManager.Dragging.AllowedDropLocations.Floating) || dragManager.IsForcedFloatingDrag;
		}

		// Token: 0x0600038B RID: 907 RVA: 0x00013858 File Offset: 0x00011A58
		internal override bool IsSameResult(global::Infragistics.Windows.DockManager.Dragging.PaneDragAction action)
		{
			global::Infragistics.Windows.DockManager.Dragging.MoveWindowAction moveWindowAction = action as global::Infragistics.Windows.DockManager.Dragging.MoveWindowAction;
			return moveWindowAction != null && moveWindowAction._newLocation == this._newLocation && moveWindowAction._window == this._window;
		}

		// Token: 0x0600038C RID: 908 RVA: 0x00013894 File Offset: 0x00011A94
		internal override void PerformAction(global::Infragistics.Windows.DockManager.Dragging.DragManager dragManager, bool isPreview)
		{
			if (dragManager.IsInWindowDragMode)
			{
				return;
			}
			if (dragManager.DeferFloatingWindowPositioning)
			{
				if (isPreview)
				{
					global::Infragistics.Windows.Controls.ToolWindow floatingWindow = dragManager.FloatingWindow;
					if (floatingWindow == null)
					{
						global::Infragistics.Windows.DockManager.PaneToolWindow windowBeingDragged = dragManager.WindowBeingDragged;
						if (windowBeingDragged != null)
						{
							global::System.Windows.Size size = new global::System.Windows.Size(windowBeingDragged.ActualWidth, windowBeingDragged.ActualHeight);
							global::System.Windows.Rect rect = (windowBeingDragged.WindowState == global::System.Windows.WindowState.Maximized) ? windowBeingDragged.GetRestoreBounds() : global::System.Windows.Rect.Empty;
							if (!rect.IsEmpty)
							{
								size = rect.Size;
							}
							else if (windowBeingDragged.Host != null && windowBeingDragged.UseOSNonClientArea)
							{
								size = windowBeingDragged.AddNonClientSize(size);
							}
							dragManager.CreateFloatingPreviewWindow(this.NewLocation, size);
							return;
						}
					}
					else
					{
						global::Infragistics.Windows.DockManager.DockManagerUtilities.MoveToolWindow(floatingWindow, this.NewLocation);
						if (!floatingWindow.IsVisible)
						{
							global::Infragistics.Windows.DockManager.DockManagerUtilities.ShowToolWindow(floatingWindow, dragManager.DockManager, false);
							floatingWindow.BringToFront();
							return;
						}
					}
				}
				else
				{
					if (dragManager.WindowBeingDragged == null)
					{
						global::Infragistics.Windows.Controls.ToolWindow floatingWindow2 = dragManager.FloatingWindow;
						global::System.Windows.Size size2 = (floatingWindow2 == null) ? new global::System.Windows.Size(double.PositiveInfinity, double.PositiveInfinity) : floatingWindow2.RenderSize;
						dragManager.CreateWindowBeingDragged(this.NewLocation, size2);
						return;
					}
					global::Infragistics.Windows.Controls.ToolWindow windowBeingDragged2 = dragManager.WindowBeingDragged;
					if (windowBeingDragged2.WindowState == global::System.Windows.WindowState.Maximized)
					{
						windowBeingDragged2.WindowState = global::System.Windows.WindowState.Normal;
					}
					global::Infragistics.Windows.DockManager.DockManagerUtilities.MoveToolWindow(windowBeingDragged2, this.NewLocation);
					return;
				}
			}
			else if (this._window != null)
			{
				global::Infragistics.Windows.DockManager.DockManagerUtilities.MoveToolWindow(this._window, this.NewLocation);
			}
		}

		// Token: 0x040001E8 RID: 488
		private global::System.Windows.Point _oldLocation;

		// Token: 0x040001E9 RID: 489
		private global::System.Windows.Point _newLocation;

		// Token: 0x040001EA RID: 490
		private global::Infragistics.Windows.DockManager.PaneToolWindow _window;
	}
}
