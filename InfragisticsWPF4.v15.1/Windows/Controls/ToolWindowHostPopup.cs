using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Media;
using System.Windows.Media.Media3D;
using System.Windows.Threading;
using Infragistics.Collections;
using Infragistics.Windows.Helpers;

namespace Infragistics.Windows.Controls
{
	// Token: 0x02000241 RID: 577
	internal class ToolWindowHostPopup : global::Infragistics.Windows.Controls.ToolWindowContainer, global::Infragistics.Windows.Controls.IToolWindowHost
	{
		// Token: 0x060016A3 RID: 5795 RVA: 0x00052D30 File Offset: 0x00050F30
		static ToolWindowHostPopup()
		{
			global::System.Windows.Input.FocusManager.IsFocusScopeProperty.OverrideMetadata(typeof(global::Infragistics.Windows.Controls.ToolWindowHostPopup), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox));
		}

		// Token: 0x060016A4 RID: 5796 RVA: 0x00052E2A File Offset: 0x0005102A
		private ToolWindowHostPopup()
		{
			base.Loaded += this.OnLoaded;
		}

		// Token: 0x1700052D RID: 1325
		// (get) Token: 0x060016A5 RID: 5797 RVA: 0x00052E44 File Offset: 0x00051044
		public override bool AllowsTransparency
		{
			get
			{
				return this._popup != null && this._popup.AllowsTransparency;
			}
		}

		// Token: 0x060016A6 RID: 5798 RVA: 0x00052E5C File Offset: 0x0005105C
		public override void BringToFront()
		{
			global::Infragistics.Windows.Controls.ToolWindow toolWindow = base.Child as global::Infragistics.Windows.Controls.ToolWindow;
			if (toolWindow != null && !toolWindow.IsModal)
			{
				base.BringIntoView();
			}
		}

		// Token: 0x060016A7 RID: 5799 RVA: 0x00052E88 File Offset: 0x00051088
		public override void Close()
		{
			global::Infragistics.Windows.Controls.ToolWindow toolWindow = base.Child as global::Infragistics.Windows.Controls.ToolWindow;
			if (this._popup.IsOpen)
			{
				if (toolWindow != null && toolWindow.OnClosingInternal(new global::System.ComponentModel.CancelEventArgs()))
				{
					return;
				}
				this._popup.IsOpen = false;
			}
		}

		// Token: 0x060016A8 RID: 5800 RVA: 0x00052ECB File Offset: 0x000510CB
		public override void EnsureOnScreen(bool fullyInView)
		{
			this.VerifyIsInView(true, true, fullyInView);
		}

		// Token: 0x060016A9 RID: 5801 RVA: 0x00052ED8 File Offset: 0x000510D8
		protected override global::System.Windows.Point GetRelativeScreenPoint(global::System.Windows.Input.MouseEventArgs e)
		{
			global::System.Windows.Point position = e.GetPosition(this);
			position.X += base.Left;
			position.Y += base.Top;
			if (this.ConstrainToWorkArea || base.IsResizing)
			{
				if (position.X < this._screenRect.X)
				{
					position.X = this._screenRect.X;
				}
				else if (position.X > this._screenRect.Right)
				{
					position.X = this._screenRect.Right;
				}
				if (position.Y < this._screenRect.Y)
				{
					position.Y = this._screenRect.Y;
				}
				else if (position.Y > this._screenRect.Bottom)
				{
					position.Y = this._screenRect.Bottom;
				}
			}
			return position;
		}

		// Token: 0x1700052E RID: 1326
		// (get) Token: 0x060016AA RID: 5802 RVA: 0x00052FC5 File Offset: 0x000511C5
		public override global::Infragistics.Windows.Controls.ToolWindowHostType HostType
		{
			get
			{
				return global::Infragistics.Windows.Controls.ToolWindowHostType.Popup;
			}
		}

		// Token: 0x060016AB RID: 5803 RVA: 0x00052FC8 File Offset: 0x000511C8
		protected override void OnChildChanged(global::System.Windows.UIElement oldChild, global::System.Windows.UIElement newChild)
		{
			global::Infragistics.Windows.Controls.ToolWindow toolWindow = oldChild as global::Infragistics.Windows.Controls.ToolWindow;
			global::Infragistics.Windows.Controls.ToolWindow toolWindow2 = newChild as global::Infragistics.Windows.Controls.ToolWindow;
			if (toolWindow != null)
			{
				global::System.Windows.FrameworkElement owner = toolWindow.Owner;
				if (owner != null)
				{
					global::System.Collections.Generic.IList<global::Infragistics.Windows.Controls.ToolWindow> toolWindows = global::Infragistics.Windows.Controls.ToolWindowHostPopup.GetToolWindows(owner);
					if (toolWindows != null)
					{
						toolWindows.Remove(toolWindow);
					}
				}
			}
			if (toolWindow2 != null)
			{
				global::System.Windows.FrameworkElement owner2 = toolWindow2.Owner;
				if (owner2 != null)
				{
					global::System.Collections.Generic.IList<global::Infragistics.Windows.Controls.ToolWindow> list = global::Infragistics.Windows.Controls.ToolWindowHostPopup.GetToolWindows(owner2);
					if (list == null)
					{
						list = new global::System.Collections.Generic.List<global::Infragistics.Windows.Controls.ToolWindow>();
						owner2.SetValue(global::Infragistics.Windows.Controls.ToolWindowHostPopup.ToolWindowsPropertyKey, list);
					}
					list.Add(toolWindow2);
				}
			}
			base.OnChildChanged(oldChild, newChild);
		}

		// Token: 0x060016AC RID: 5804 RVA: 0x00053044 File Offset: 0x00051244
		protected override void OnEnteringDrag(global::System.Windows.Input.MouseEventArgs e, global::Infragistics.Windows.Controls.ToolWindowResizeElementLocation location)
		{
			global::System.Windows.Rect workArea = this.GetWorkArea(e);
			global::System.Windows.Point position = e.GetPosition(this);
			global::Infragistics.Windows.Controls.ToolWindowHostPopup.PopupChildWrapper popupChildWrapper = this._popup.Child as global::Infragistics.Windows.Controls.ToolWindowHostPopup.PopupChildWrapper;
			if (popupChildWrapper != null)
			{
				global::System.Windows.Size size = popupChildWrapper.CalculateMaxPopupSize(workArea);
				if (!size.IsEmpty)
				{
					global::System.Windows.Rect rect = new global::System.Windows.Rect(base.Left, base.Top, base.ActualWidth, base.ActualHeight);
					global::System.Windows.Rect rect2 = new global::System.Windows.Rect(base.Left, base.Top, global::System.Math.Min(workArea.Width, size.Width), global::System.Math.Min(workArea.Height, size.Height));
					switch (location)
					{
					case global::Infragistics.Windows.Controls.ToolWindowResizeElementLocation.Top:
					case global::Infragistics.Windows.Controls.ToolWindowResizeElementLocation.TopLeft:
					case global::Infragistics.Windows.Controls.ToolWindowResizeElementLocation.TopRight:
						rect2.Y = rect.Bottom - rect2.Height;
						break;
					}
					if (location != global::Infragistics.Windows.Controls.ToolWindowResizeElementLocation.Left)
					{
						switch (location)
						{
						case global::Infragistics.Windows.Controls.ToolWindowResizeElementLocation.TopLeft:
						case global::Infragistics.Windows.Controls.ToolWindowResizeElementLocation.BottomLeft:
							break;
						case global::Infragistics.Windows.Controls.ToolWindowResizeElementLocation.TopRight:
							goto IL_100;
						default:
							goto IL_100;
						}
					}
					rect2.X = rect.Right - rect2.Width;
					IL_100:
					workArea.Intersect(rect2);
				}
			}
			switch (location)
			{
			case global::Infragistics.Windows.Controls.ToolWindowResizeElementLocation.Top:
			case global::Infragistics.Windows.Controls.ToolWindowResizeElementLocation.TopLeft:
			case global::Infragistics.Windows.Controls.ToolWindowResizeElementLocation.TopRight:
				workArea.Y += position.Y;
				workArea.Height -= position.Y;
				break;
			case global::Infragistics.Windows.Controls.ToolWindowResizeElementLocation.Bottom:
			case global::Infragistics.Windows.Controls.ToolWindowResizeElementLocation.BottomLeft:
			case global::Infragistics.Windows.Controls.ToolWindowResizeElementLocation.BottomRight:
				workArea.Height -= base.ActualHeight - position.Y;
				break;
			}
			switch (location)
			{
			case global::Infragistics.Windows.Controls.ToolWindowResizeElementLocation.Left:
			case global::Infragistics.Windows.Controls.ToolWindowResizeElementLocation.TopLeft:
			case global::Infragistics.Windows.Controls.ToolWindowResizeElementLocation.BottomLeft:
				workArea.X += position.X;
				workArea.Width -= position.X;
				break;
			case global::Infragistics.Windows.Controls.ToolWindowResizeElementLocation.Right:
			case global::Infragistics.Windows.Controls.ToolWindowResizeElementLocation.TopRight:
			case global::Infragistics.Windows.Controls.ToolWindowResizeElementLocation.BottomRight:
				workArea.Width -= base.ActualWidth - position.X;
				break;
			}
			this._screenRect = workArea;
			base.OnEnteringDrag(e, location);
		}

		// Token: 0x060016AD RID: 5805 RVA: 0x00053250 File Offset: 0x00051450
		protected override void OnEnteringMove(global::System.Windows.Input.MouseEventArgs e)
		{
			if (this.ConstrainToWorkArea)
			{
				global::System.Windows.Rect rect = this.GetWorkArea(e);
				global::System.Windows.Point position = e.GetPosition(this);
				global::System.Windows.Rect rect2 = new global::System.Windows.Rect(base.Left, base.Top, base.ActualWidth, base.ActualHeight);
				rect = global::System.Windows.Rect.Union(rect2, rect);
				double num = global::System.Math.Min(base.Top, 0.0);
				double num2 = global::System.Math.Min(base.Left, 0.0);
				rect.Y = position.Y + num;
				rect.X = position.X + num2;
				rect.Width = global::System.Math.Max(rect.Width - base.ActualWidth, 0.0);
				rect.Height = global::System.Math.Max(rect.Height - base.ActualHeight, 0.0);
				this._screenRect = rect;
			}
			base.OnEnteringMove(e);
		}

		// Token: 0x060016AE RID: 5806 RVA: 0x0005333F File Offset: 0x0005153F
		public override void RelativePositionStateChanged()
		{
			this.RelativePositionStateChanged(global::Infragistics.Windows.Controls.ToolWindowHostPopup.RelativePositionStateChangedId);
		}

		// Token: 0x060016AF RID: 5807 RVA: 0x00053350 File Offset: 0x00051550
		private object RelativePositionStateChanged(object param)
		{
			global::Infragistics.Windows.Controls.ToolWindow toolWindow = base.Child as global::Infragistics.Windows.Controls.ToolWindow;
			bool flag = false;
			bool flag2 = toolWindow != null && this._popup != null && this._popup.IsOpen;
			if (!flag2 && toolWindow != null && param == global::Infragistics.Windows.Controls.ToolWindowHostPopup.InitialRelativePositionId)
			{
				flag2 = true;
			}
			if (flag2)
			{
				try
				{
					global::System.Windows.FrameworkElement owner = toolWindow.Owner;
					global::System.Windows.Window window = owner as global::System.Windows.Window;
					global::System.Windows.Point location;
					if (window != null)
					{
						location = new global::System.Windows.Point(window.Left, window.Top);
					}
					else
					{
						location = global::Infragistics.Windows.Utilities.PointToScreenSafe(owner, default(global::System.Windows.Point));
						if (!global::System.Windows.Interop.BrowserInteropHelper.IsBrowserHosted)
						{
							global::System.Windows.Media.Matrix deviceMatrix = global::Infragistics.Windows.Utilities.GetDeviceMatrix(false, owner ?? this);
							location.X *= deviceMatrix.M11;
							location.Y *= deviceMatrix.M22;
						}
					}
					global::System.Windows.Rect ownerRect = new global::System.Windows.Rect(location, owner.RenderSize);
					if (owner.FlowDirection == global::System.Windows.FlowDirection.RightToLeft)
					{
						ownerRect.X -= owner.ActualWidth;
					}
					global::System.Windows.Rect rect = new global::System.Windows.Rect(base.Left, base.Top, base.ActualWidth, base.ActualHeight);
					if (base.IsLoaded)
					{
						base.PerformInitialPositioning(ref rect);
					}
					toolWindow.AdjustRelativeRect(ownerRect, ref rect);
					if (toolWindow.VerticalAlignmentMode != global::Infragistics.Windows.Controls.ToolWindowAlignmentMode.Manual)
					{
						flag = true;
						base.Top = rect.Y;
						if (rect.Height != base.ActualHeight)
						{
							base.Height = rect.Height;
						}
					}
					if (toolWindow.HorizontalAlignmentMode != global::Infragistics.Windows.Controls.ToolWindowAlignmentMode.Manual)
					{
						flag = true;
						base.Left = rect.X;
						if (rect.Width != base.ActualWidth)
						{
							base.Width = rect.Width;
						}
					}
				}
				catch (global::System.InvalidOperationException)
				{
					flag = false;
				}
			}
			base.LayoutUpdated -= this.OnLayoutUpdated;
			if (flag && base.IsLoaded)
			{
				if (param != global::Infragistics.Windows.Controls.ToolWindowHostPopup.SynchronousRelativePositionId && this._controller != null)
				{
					base.Dispatcher.BeginInvoke(global::System.Windows.Threading.DispatcherPriority.Normal, new global::System.Windows.Threading.DispatcherOperationCallback(this.RelativePositionStateChanged), global::Infragistics.Windows.Controls.ToolWindowHostPopup.SynchronousRelativePositionId);
				}
				base.LayoutUpdated += this.OnLayoutUpdated;
			}
			else
			{
				base.LayoutUpdated -= this.OnLayoutUpdated;
			}
			return null;
		}

		// Token: 0x060016B0 RID: 5808 RVA: 0x00053580 File Offset: 0x00051780
		public override bool SupportsAllowTransparency(bool allowsTransparency)
		{
			return allowsTransparency == global::Infragistics.Windows.Controls.PopupHelper.PopupAllowsTransparency;
		}

		// Token: 0x1700052F RID: 1327
		// (get) Token: 0x060016B1 RID: 5809 RVA: 0x0005358A File Offset: 0x0005178A
		private bool ConstrainToWorkArea
		{
			get
			{
				return this._controller == null || (global::Infragistics.Windows.Controls.PopupHelper.IsPopupInChildWindow && this._isModal);
			}
		}

		// Token: 0x17000530 RID: 1328
		// (get) Token: 0x060016B2 RID: 5810 RVA: 0x000535A5 File Offset: 0x000517A5
		private static global::Infragistics.Collections.WeakList<global::Infragistics.Windows.Controls.ToolWindowHostPopup> CurrentPopups
		{
			get
			{
				if (global::Infragistics.Windows.Controls.ToolWindowHostPopup._currentPopups == null)
				{
					global::Infragistics.Windows.Controls.ToolWindowHostPopup._currentPopups = new global::Infragistics.Collections.WeakList<global::Infragistics.Windows.Controls.ToolWindowHostPopup>();
				}
				return global::Infragistics.Windows.Controls.ToolWindowHostPopup._currentPopups;
			}
		}

		// Token: 0x060016B3 RID: 5811 RVA: 0x000535C0 File Offset: 0x000517C0
		private static void OnIsOpenChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			if (false.Equals(e.NewValue))
			{
				global::Infragistics.Windows.Controls.ToolWindowHostPopup toolWindowHostPopup = (global::Infragistics.Windows.Controls.ToolWindowHostPopup)d;
				global::Infragistics.Windows.Controls.ToolWindow toolWindow = toolWindowHostPopup.Child as global::Infragistics.Windows.Controls.ToolWindow;
				if (toolWindow != null && !toolWindow.IsModal)
				{
					toolWindowHostPopup.Child = null;
					if (toolWindow != null)
					{
						toolWindow.OnClosedInternal(false);
					}
				}
			}
		}

		// Token: 0x17000531 RID: 1329
		// (get) Token: 0x060016B4 RID: 5812 RVA: 0x0005360E File Offset: 0x0005180E
		// (set) Token: 0x060016B5 RID: 5813 RVA: 0x00053620 File Offset: 0x00051820
		private bool IsOpen
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.Windows.Controls.ToolWindowHostPopup.IsOpenProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.Controls.ToolWindowHostPopup.IsOpenProperty, value);
			}
		}

		// Token: 0x060016B6 RID: 5814 RVA: 0x00053633 File Offset: 0x00051833
		private static global::System.Collections.Generic.Stack<global::Infragistics.Windows.Controls.ToolWindowHostPopup> GetModalToolWindows(global::System.Windows.DependencyObject d)
		{
			return (global::System.Collections.Generic.Stack<global::Infragistics.Windows.Controls.ToolWindowHostPopup>)d.GetValue(global::Infragistics.Windows.Controls.ToolWindowHostPopup.ModalToolWindowsProperty);
		}

		// Token: 0x060016B7 RID: 5815 RVA: 0x00053645 File Offset: 0x00051845
		private static global::System.Collections.Generic.IList<global::Infragistics.Windows.Controls.ToolWindow> GetToolWindows(global::System.Windows.DependencyObject d)
		{
			return (global::System.Collections.Generic.IList<global::Infragistics.Windows.Controls.ToolWindow>)d.GetValue(global::Infragistics.Windows.Controls.ToolWindowHostPopup.ToolWindowsProperty);
		}

		// Token: 0x060016B8 RID: 5816 RVA: 0x00053658 File Offset: 0x00051858
		internal static void AddToolWindows(global::System.Windows.FrameworkElement owner, global::System.Collections.Generic.List<global::Infragistics.Windows.Controls.ToolWindow> windows)
		{
			global::System.Collections.Generic.IList<global::Infragistics.Windows.Controls.ToolWindow> toolWindows = global::Infragistics.Windows.Controls.ToolWindowHostPopup.GetToolWindows(owner);
			if (toolWindows != null)
			{
				for (int i = toolWindows.Count - 1; i >= 0; i--)
				{
					windows.Add(toolWindows[i]);
				}
			}
		}

		// Token: 0x060016B9 RID: 5817 RVA: 0x00053690 File Offset: 0x00051890
		private static global::Infragistics.Windows.Controls.ToolWindowHostPopup GetCurrentDialog(global::System.Windows.FrameworkElement page)
		{
			if (page != null)
			{
				global::System.Collections.Generic.Stack<global::Infragistics.Windows.Controls.ToolWindowHostPopup> modalToolWindows = global::Infragistics.Windows.Controls.ToolWindowHostPopup.GetModalToolWindows(page);
				if (modalToolWindows != null && modalToolWindows.Count > 0)
				{
					return modalToolWindows.Peek();
				}
			}
			return null;
		}

		// Token: 0x060016BA RID: 5818 RVA: 0x000536BC File Offset: 0x000518BC
		internal static global::Infragistics.Windows.Controls.ToolWindowHostPopup GetHost(global::System.Windows.Controls.Primitives.Popup popup)
		{
			if (popup == null)
			{
				return null;
			}
			global::Infragistics.Windows.Controls.ToolWindowHostPopup.PopupChildWrapper popupChildWrapper = popup.Child as global::Infragistics.Windows.Controls.ToolWindowHostPopup.PopupChildWrapper;
			if (popupChildWrapper != null)
			{
				return popupChildWrapper.Host;
			}
			return popup.Child as global::Infragistics.Windows.Controls.ToolWindowHostPopup;
		}

		// Token: 0x060016BB RID: 5819 RVA: 0x000536F0 File Offset: 0x000518F0
		private static global::System.Windows.FrameworkElement GetRootVisual(global::System.Windows.FrameworkElement owner)
		{
			global::System.Windows.DependencyObject dependencyObject = owner;
			while (dependencyObject != null && !(dependencyObject is global::System.Windows.Controls.Page))
			{
				global::System.Windows.DependencyObject dependencyObject2 = global::System.Windows.LogicalTreeHelper.GetParent(dependencyObject);
				if (dependencyObject2 == null && (dependencyObject is global::System.Windows.Media.Visual || dependencyObject is global::System.Windows.Media.Media3D.Visual3D))
				{
					dependencyObject2 = global::System.Windows.Media.VisualTreeHelper.GetParent(dependencyObject);
				}
				if (dependencyObject2 == null && dependencyObject is global::System.Windows.Controls.Primitives.Popup)
				{
					global::Infragistics.Windows.Controls.ToolWindowHostPopup host = global::Infragistics.Windows.Controls.ToolWindowHostPopup.GetHost(dependencyObject as global::System.Windows.Controls.Primitives.Popup);
					if (host != null && host.Child is global::Infragistics.Windows.Controls.ToolWindow)
					{
						dependencyObject2 = ((global::Infragistics.Windows.Controls.ToolWindow)host.Child).Owner;
					}
				}
				if (dependencyObject2 == null)
				{
					break;
				}
				dependencyObject = dependencyObject2;
			}
			global::System.Windows.Window window = dependencyObject as global::System.Windows.Window;
			if (window != null)
			{
				dependencyObject = global::System.Windows.Media.VisualTreeHelper.GetChild(dependencyObject, 0);
			}
			return dependencyObject as global::System.Windows.FrameworkElement;
		}

		// Token: 0x060016BC RID: 5820 RVA: 0x00053784 File Offset: 0x00051984
		private global::System.Windows.Rect GetWorkArea(global::System.Windows.Input.MouseEventArgs e)
		{
			if (!this.ConstrainToWorkArea)
			{
				return global::Infragistics.Windows.Helpers.NativeWindowMethods.VirtualScreenArea;
			}
			return new global::System.Windows.Rect(default(global::System.Windows.Point), this._rootVisual.RenderSize);
		}

		// Token: 0x060016BD RID: 5821 RVA: 0x000537B8 File Offset: 0x000519B8
		private void OnLayoutUpdated(object sender, global::System.EventArgs e)
		{
			this.RelativePositionStateChanged(global::Infragistics.Windows.Controls.ToolWindowHostPopup.LayoutUpdatedId);
		}

		// Token: 0x060016BE RID: 5822 RVA: 0x000537C6 File Offset: 0x000519C6
		private void OnUnloaded(object sender, global::System.Windows.RoutedEventArgs e)
		{
			base.Unloaded -= this.OnUnloaded;
			base.Loaded += this.OnLoaded;
			base.LayoutUpdated -= this.OnLayoutUpdated;
		}

		// Token: 0x060016BF RID: 5823 RVA: 0x000537FE File Offset: 0x000519FE
		private void OnLoaded(object sender, global::System.Windows.RoutedEventArgs e)
		{
			base.Loaded -= this.OnLoaded;
			base.Unloaded += this.OnUnloaded;
			this.RelativePositionStateChanged();
		}

		// Token: 0x060016C0 RID: 5824 RVA: 0x0005382C File Offset: 0x00051A2C
		private void OnPopupClosed(object sender, global::System.EventArgs e)
		{
			bool isKeyboardFocusWithin = base.IsKeyboardFocusWithin;
			global::Infragistics.Windows.Controls.ToolWindow toolWindow = base.Child as global::Infragistics.Windows.Controls.ToolWindow;
			base.Child = null;
			if (toolWindow != null)
			{
				if (this._modalDisabledStates != null)
				{
					this._modalDisabledStates.Dispose();
				}
				global::Infragistics.Windows.Controls.ToolWindowHostPopup.CurrentPopups.Remove(this);
				global::Infragistics.Windows.Controls.ToolWindowHostPopup.PopModalDialog(this);
				if (isKeyboardFocusWithin)
				{
					global::System.Windows.IInputElement inputElement = global::Infragistics.CoreUtilities.GetWeakReferenceTargetSafe(this._previousFocusedElement) as global::System.Windows.IInputElement;
					if (inputElement != null)
					{
						inputElement.Focus();
					}
				}
				bool value = toolWindow.DialogResult ?? false;
				toolWindow.OnClosedInternal(false);
				if (this._callback != null)
				{
					this._callback(toolWindow, new bool?(value));
				}
			}
		}

		// Token: 0x060016C1 RID: 5825 RVA: 0x000538D9 File Offset: 0x00051AD9
		private void OnPopupClosedModeless(object sender, global::System.EventArgs e)
		{
			global::Infragistics.Windows.Controls.ToolWindowHostPopup.CurrentPopups.Remove(this);
		}

		// Token: 0x060016C2 RID: 5826 RVA: 0x000538E8 File Offset: 0x00051AE8
		private static void PopModalDialog(global::Infragistics.Windows.Controls.ToolWindowHostPopup popup)
		{
			global::System.Collections.Generic.Stack<global::Infragistics.Windows.Controls.ToolWindowHostPopup> modalToolWindows = global::Infragistics.Windows.Controls.ToolWindowHostPopup.GetModalToolWindows(popup._rootVisual);
			if (modalToolWindows != null && modalToolWindows.Contains(popup))
			{
				while (modalToolWindows.Pop() != popup)
				{
				}
			}
		}

		// Token: 0x060016C3 RID: 5827 RVA: 0x00053918 File Offset: 0x00051B18
		private void PrepareModalDisabledState()
		{
			this._modalDisabledStates = new global::Infragistics.Windows.Helpers.GroupTempValueReplacement();
			new global::System.Collections.Generic.List<global::Infragistics.Windows.Controls.ToolWindowHostPopup>();
			for (int i = global::Infragistics.Windows.Controls.ToolWindowHostPopup.CurrentPopups.Count - 1; i >= 0; i--)
			{
				global::Infragistics.Windows.Controls.ToolWindowHostPopup toolWindowHostPopup = global::Infragistics.Windows.Controls.ToolWindowHostPopup._currentPopups[i];
				if (toolWindowHostPopup != null)
				{
					if (toolWindowHostPopup != this._elementToDisable)
					{
						this._modalDisabledStates.Add(new global::Infragistics.Windows.Helpers.TempValueReplacement(toolWindowHostPopup, global::System.Windows.UIElement.IsEnabledProperty, global::Infragistics.KnownBoxes.FalseBox));
					}
					if (toolWindowHostPopup._isModal)
					{
						break;
					}
				}
			}
			if (this._elementToDisable != null)
			{
				this._modalDisabledStates.Add(new global::Infragistics.Windows.Helpers.TempValueReplacement(this._elementToDisable, global::System.Windows.UIElement.IsEnabledProperty, global::Infragistics.KnownBoxes.FalseBox));
			}
		}

		// Token: 0x060016C4 RID: 5828 RVA: 0x000539B0 File Offset: 0x00051BB0
		private static void PushModalDialog(global::Infragistics.Windows.Controls.ToolWindowHostPopup popup)
		{
			if (popup._rootVisual != null)
			{
				global::System.Collections.Generic.Stack<global::Infragistics.Windows.Controls.ToolWindowHostPopup> stack = global::Infragistics.Windows.Controls.ToolWindowHostPopup.GetModalToolWindows(popup._rootVisual);
				if (stack == null)
				{
					stack = new global::System.Collections.Generic.Stack<global::Infragistics.Windows.Controls.ToolWindowHostPopup>();
					popup._rootVisual.SetValue(global::Infragistics.Windows.Controls.ToolWindowHostPopup.ModalToolWindowsPropertyKey, stack);
				}
				stack.Push(popup);
			}
		}

		// Token: 0x060016C5 RID: 5829 RVA: 0x000539F2 File Offset: 0x00051BF2
		internal static global::Infragistics.Windows.Controls.ToolWindow.IDeferShow Show(global::Infragistics.Windows.Controls.ToolWindow toolWindow)
		{
			return global::Infragistics.Windows.Controls.ToolWindowHostPopup.ShowImpl(toolWindow, false, null);
		}

		// Token: 0x060016C6 RID: 5830 RVA: 0x000539FC File Offset: 0x00051BFC
		internal static void ShowDialog(global::Infragistics.Windows.Controls.ToolWindow toolWindow, global::Infragistics.Windows.Controls.ToolWindow.ShowDialogCallback callback)
		{
			global::Infragistics.Windows.Controls.ToolWindow.IDeferShow deferShow = global::Infragistics.Windows.Controls.ToolWindowHostPopup.ShowImpl(toolWindow, true, callback);
			if (deferShow != null)
			{
				deferShow.Show(true);
			}
		}

		// Token: 0x060016C7 RID: 5831 RVA: 0x00053A1C File Offset: 0x00051C1C
		private static global::Infragistics.Windows.Controls.ToolWindow.IDeferShow ShowImpl(global::Infragistics.Windows.Controls.ToolWindow toolWindow, bool isModal, global::Infragistics.Windows.Controls.ToolWindow.ShowDialogCallback callback)
		{
			global::System.Windows.Controls.Primitives.Popup popup = new global::System.Windows.Controls.Primitives.Popup();
			global::Infragistics.Windows.Controls.ToolWindowHostPopup toolWindowHostPopup = new global::Infragistics.Windows.Controls.ToolWindowHostPopup();
			if (isModal)
			{
				toolWindowHostPopup._callback = callback;
			}
			popup.AllowsTransparency = toolWindow.AllowsTransparencyResolved;
			toolWindowHostPopup._popup = popup;
			if (isModal)
			{
				toolWindowHostPopup._previousFocusedElement = new global::System.WeakReference(global::System.Windows.Input.Keyboard.FocusedElement);
			}
			global::System.Windows.FrameworkElement rootVisual = global::Infragistics.Windows.Controls.ToolWindowHostPopup.GetRootVisual(toolWindow.Owner);
			toolWindowHostPopup._rootVisual = rootVisual;
			if (isModal)
			{
				toolWindowHostPopup._elementToDisable = (global::Infragistics.Windows.Controls.ToolWindowHostPopup.GetCurrentDialog(rootVisual) ?? rootVisual);
			}
			global::Infragistics.Windows.Controls.ToolWindowHostPopup.PopupChildWrapper popupChildWrapper = new global::Infragistics.Windows.Controls.ToolWindowHostPopup.PopupChildWrapper(toolWindowHostPopup);
			popup.Child = popupChildWrapper;
			popup.StaysOpen = true;
			toolWindowHostPopup.Child = toolWindow;
			popupChildWrapper.SetBinding(global::System.Windows.FrameworkElement.FlowDirectionProperty, global::Infragistics.Windows.Utilities.CreateBindingObject(global::System.Windows.FrameworkElement.FlowDirectionProperty, global::System.Windows.Data.BindingMode.OneWay, toolWindow.Owner));
			popup.PopupAnimation = global::System.Windows.Controls.Primitives.PopupAnimation.None;
			if (isModal)
			{
				popup.PlacementTarget = (rootVisual ?? toolWindow.Owner);
			}
			else
			{
				popup.PlacementTarget = toolWindow.Owner;
			}
			popup.Placement = global::System.Windows.Controls.Primitives.PlacementMode.Absolute;
			popup.SetBinding(global::System.Windows.Controls.Primitives.Popup.HorizontalOffsetProperty, global::Infragistics.Windows.Utilities.CreateBindingObject(global::Infragistics.Windows.Controls.ToolWindow.LeftProperty, global::System.Windows.Data.BindingMode.TwoWay, toolWindowHostPopup));
			popup.SetBinding(global::System.Windows.Controls.Primitives.Popup.VerticalOffsetProperty, global::Infragistics.Windows.Utilities.CreateBindingObject(global::Infragistics.Windows.Controls.ToolWindow.TopProperty, global::System.Windows.Data.BindingMode.TwoWay, toolWindowHostPopup));
			if (isModal)
			{
				popup.Closed += toolWindowHostPopup.OnPopupClosed;
			}
			else
			{
				popup.Closed += toolWindowHostPopup.OnPopupClosedModeless;
			}
			toolWindowHostPopup.SetBinding(global::Infragistics.Windows.Controls.ToolWindowHostPopup.IsOpenProperty, global::Infragistics.Windows.Utilities.CreateBindingObject(global::System.Windows.Controls.Primitives.Popup.IsOpenProperty, global::System.Windows.Data.BindingMode.OneWay, popup));
			if (double.IsNaN(popup.HorizontalOffset))
			{
				popup.HorizontalOffset = 0.0;
			}
			if (double.IsNaN(popup.VerticalOffset))
			{
				popup.VerticalOffset = 0.0;
			}
			popup.SetBinding(global::System.Windows.FrameworkElement.WidthProperty, global::Infragistics.Windows.Utilities.CreateBindingObject(global::Infragistics.Windows.Controls.ToolWindow.RequiredPopupWidthProperty, global::System.Windows.Data.BindingMode.OneWay, toolWindow));
			popup.SetBinding(global::System.Windows.FrameworkElement.HeightProperty, global::Infragistics.Windows.Utilities.CreateBindingObject(global::Infragistics.Windows.Controls.ToolWindow.RequiredPopupHeightProperty, global::System.Windows.Data.BindingMode.OneWay, toolWindow));
			toolWindowHostPopup._controller = global::Infragistics.Windows.Controls.PopupController.Create(popup, toolWindow.Owner);
			if (toolWindowHostPopup._controller != null)
			{
				toolWindowHostPopup._controller.BindPopupRootExtents = true;
			}
			if (isModal)
			{
				global::Infragistics.Windows.Controls.ToolWindowHostPopup.PushModalDialog(toolWindowHostPopup);
			}
			toolWindowHostPopup._isModal = isModal;
			if (isModal)
			{
				toolWindowHostPopup.PrepareModalDisabledState();
			}
			global::Infragistics.Windows.Controls.ToolWindowHostPopup.CurrentPopups.Add(toolWindowHostPopup);
			toolWindowHostPopup.RelativePositionStateChanged(global::Infragistics.Windows.Controls.ToolWindowHostPopup.InitialRelativePositionId);
			return new global::Infragistics.Windows.Controls.ToolWindowHostPopup.DeferShowHelper(toolWindowHostPopup);
		}

		// Token: 0x060016C8 RID: 5832 RVA: 0x00053C2C File Offset: 0x00051E2C
		private void VerifyActivation(object param)
		{
			global::Infragistics.Windows.Controls.ToolWindow toolWindow = base.Child as global::Infragistics.Windows.Controls.ToolWindow;
			if (toolWindow != null && toolWindow.IsVisible)
			{
				if (true.Equals(param))
				{
					toolWindow.BringToFront();
					return;
				}
				toolWindow.Activate();
			}
		}

		// Token: 0x060016C9 RID: 5833 RVA: 0x00053C6C File Offset: 0x00051E6C
		private void VerifyIsInView(bool force, bool async, bool ensureFullyInView)
		{
			global::Infragistics.Windows.Controls.ToolWindow toolWindow = base.Child as global::Infragistics.Windows.Controls.ToolWindow;
			if (toolWindow == null || (!toolWindow.KeepOnScreen && !force))
			{
				return;
			}
			if (toolWindow.WindowState == global::System.Windows.WindowState.Minimized)
			{
				return;
			}
			if (async)
			{
				base.Dispatcher.BeginInvoke(global::System.Windows.Threading.DispatcherPriority.Background, new global::System.Threading.SendOrPostCallback(this.VerifyIsInViewImpl), ensureFullyInView);
				return;
			}
			this.VerifyIsInViewImpl(ensureFullyInView);
		}

		// Token: 0x060016CA RID: 5834 RVA: 0x00053CD0 File Offset: 0x00051ED0
		private void VerifyIsInViewImpl(object param)
		{
			global::Infragistics.Windows.Controls.ToolWindow toolWindow = base.Child as global::Infragistics.Windows.Controls.ToolWindow;
			if (toolWindow == null)
			{
				return;
			}
			global::System.Windows.Rect logicalScreenRect = new global::System.Windows.Rect(base.Left, base.Top, base.ActualWidth, base.ActualHeight);
			global::System.Windows.Point? point = global::Infragistics.Windows.Utilities.CalculateOnScreenLocation(logicalScreenRect, this, true.Equals(param));
			if (point != null)
			{
				if (toolWindow != null && toolWindow.HorizontalAlignmentMode == global::Infragistics.Windows.Controls.ToolWindowAlignmentMode.Manual)
				{
					base.Left = point.Value.X;
				}
				if (toolWindow != null && toolWindow.VerticalAlignmentMode == global::Infragistics.Windows.Controls.ToolWindowAlignmentMode.Manual)
				{
					base.Top = point.Value.Y;
				}
			}
		}

		// Token: 0x04000BBE RID: 3006
		private global::System.Windows.Controls.Primitives.Popup _popup;

		// Token: 0x04000BBF RID: 3007
		private global::Infragistics.Windows.Controls.ToolWindow.ShowDialogCallback _callback;

		// Token: 0x04000BC0 RID: 3008
		private global::System.Windows.FrameworkElement _rootVisual;

		// Token: 0x04000BC1 RID: 3009
		private global::System.Windows.Rect _screenRect;

		// Token: 0x04000BC2 RID: 3010
		private global::System.WeakReference _previousFocusedElement;

		// Token: 0x04000BC3 RID: 3011
		private global::System.Windows.FrameworkElement _elementToDisable;

		// Token: 0x04000BC4 RID: 3012
		private global::Infragistics.Windows.Controls.PopupController _controller;

		// Token: 0x04000BC5 RID: 3013
		private static readonly object InitialRelativePositionId = new object();

		// Token: 0x04000BC6 RID: 3014
		private static readonly object RelativePositionStateChangedId = new object();

		// Token: 0x04000BC7 RID: 3015
		private static readonly object LayoutUpdatedId = new object();

		// Token: 0x04000BC8 RID: 3016
		private static readonly object SynchronousRelativePositionId = new object();

		// Token: 0x04000BC9 RID: 3017
		[global::System.ThreadStatic]
		private static global::Infragistics.Collections.WeakList<global::Infragistics.Windows.Controls.ToolWindowHostPopup> _currentPopups;

		// Token: 0x04000BCA RID: 3018
		private global::Infragistics.Windows.Helpers.GroupTempValueReplacement _modalDisabledStates;

		// Token: 0x04000BCB RID: 3019
		private bool _isModal;

		// Token: 0x04000BCC RID: 3020
		private static readonly global::System.Windows.DependencyProperty IsOpenProperty = global::System.Windows.DependencyProperty.Register("IsOpen", typeof(bool), typeof(global::Infragistics.Windows.Controls.ToolWindowHostPopup), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.Controls.ToolWindowHostPopup.OnIsOpenChanged)));

		// Token: 0x04000BCD RID: 3021
		private static readonly global::System.Windows.DependencyPropertyKey ModalToolWindowsPropertyKey = global::System.Windows.DependencyProperty.RegisterAttachedReadOnly("ModalToolWindows", typeof(global::System.Collections.Generic.Stack<global::Infragistics.Windows.Controls.ToolWindowHostPopup>), typeof(global::Infragistics.Windows.Controls.ToolWindowHostPopup), new global::System.Windows.FrameworkPropertyMetadata());

		// Token: 0x04000BCE RID: 3022
		private static readonly global::System.Windows.DependencyProperty ModalToolWindowsProperty = global::Infragistics.Windows.Controls.ToolWindowHostPopup.ModalToolWindowsPropertyKey.DependencyProperty;

		// Token: 0x04000BCF RID: 3023
		private static readonly global::System.Windows.DependencyPropertyKey ToolWindowsPropertyKey = global::System.Windows.DependencyProperty.RegisterAttachedReadOnly("ToolWindows", typeof(global::System.Collections.Generic.IList<global::Infragistics.Windows.Controls.ToolWindow>), typeof(global::Infragistics.Windows.Controls.ToolWindowHostPopup), new global::System.Windows.FrameworkPropertyMetadata());

		// Token: 0x04000BD0 RID: 3024
		private static readonly global::System.Windows.DependencyProperty ToolWindowsProperty = global::Infragistics.Windows.Controls.ToolWindowHostPopup.ToolWindowsPropertyKey.DependencyProperty;

		// Token: 0x02000242 RID: 578
		private class PopupChildWrapper : global::System.Windows.FrameworkElement
		{
			// Token: 0x060016CB RID: 5835 RVA: 0x00053D6B File Offset: 0x00051F6B
			internal PopupChildWrapper(global::Infragistics.Windows.Controls.ToolWindowHostPopup host)
			{
				this._host = host;
				base.AddLogicalChild(host);
				base.AddVisualChild(host);
			}

			// Token: 0x060016CC RID: 5836 RVA: 0x00053D88 File Offset: 0x00051F88
			protected override global::System.Windows.Size MeasureOverride(global::System.Windows.Size availableSize)
			{
				if (this._isMeasuringMaxHeight)
				{
					return new global::System.Windows.Size(2147483647.0, 2147483647.0);
				}
				this._host.Measure(availableSize);
				return this._host.DesiredSize;
			}

			// Token: 0x060016CD RID: 5837 RVA: 0x00053DC1 File Offset: 0x00051FC1
			protected override global::System.Windows.Size ArrangeOverride(global::System.Windows.Size finalSize)
			{
				this._host.Arrange(new global::System.Windows.Rect(finalSize));
				return finalSize;
			}

			// Token: 0x060016CE RID: 5838 RVA: 0x00053DD5 File Offset: 0x00051FD5
			protected override global::System.Windows.Media.Visual GetVisualChild(int index)
			{
				if (index != 0)
				{
					throw new global::System.ArgumentOutOfRangeException();
				}
				return this._host;
			}

			// Token: 0x17000532 RID: 1330
			// (get) Token: 0x060016CF RID: 5839 RVA: 0x00053DE6 File Offset: 0x00051FE6
			protected override int VisualChildrenCount
			{
				get
				{
					return 1;
				}
			}

			// Token: 0x17000533 RID: 1331
			// (get) Token: 0x060016D0 RID: 5840 RVA: 0x00053DE9 File Offset: 0x00051FE9
			protected override global::System.Collections.IEnumerator LogicalChildren
			{
				get
				{
					return new global::Infragistics.Collections.SingleItemEnumerator(this._host);
				}
			}

			// Token: 0x17000534 RID: 1332
			// (get) Token: 0x060016D1 RID: 5841 RVA: 0x00053DF6 File Offset: 0x00051FF6
			public global::Infragistics.Windows.Controls.ToolWindowHostPopup Host
			{
				get
				{
					return this._host;
				}
			}

			// Token: 0x060016D2 RID: 5842 RVA: 0x00053E00 File Offset: 0x00052000
			internal global::System.Windows.Size CalculateMaxPopupSize(global::System.Windows.Rect workRect)
			{
				bool isMeasuringMaxHeight = this._isMeasuringMaxHeight;
				this._isMeasuringMaxHeight = true;
				global::System.Windows.Size result;
				try
				{
					global::System.Windows.UIElement uielement;
					global::System.Windows.UIElement uielement2;
					for (uielement = this; uielement != null; uielement = uielement2)
					{
						uielement2 = (global::Infragistics.Windows.Utilities.GetParent(uielement, false) as global::System.Windows.UIElement);
						if (uielement2 == null)
						{
							break;
						}
					}
					if (uielement == null)
					{
						result = global::System.Windows.Size.Empty;
					}
					else
					{
						global::Infragistics.Windows.Utilities.InvalidateMeasure(this, uielement);
						base.InvalidateMeasure();
						uielement.InvalidateMeasure();
						uielement.Measure(new global::System.Windows.Size(double.PositiveInfinity, double.PositiveInfinity));
						global::System.Windows.Size desiredSize = uielement.DesiredSize;
						base.InvalidateMeasure();
						uielement.InvalidateMeasure();
						global::Infragistics.Windows.Utilities.InvalidateMeasure(this, uielement);
						result = desiredSize;
					}
				}
				finally
				{
					this._isMeasuringMaxHeight = isMeasuringMaxHeight;
				}
				return result;
			}

			// Token: 0x04000BD1 RID: 3025
			private global::Infragistics.Windows.Controls.ToolWindowHostPopup _host;

			// Token: 0x04000BD2 RID: 3026
			private bool _isMeasuringMaxHeight;
		}

		// Token: 0x02000243 RID: 579
		private class DeferShowHelper : global::Infragistics.Windows.Controls.ToolWindow.IDeferShow
		{
			// Token: 0x060016D3 RID: 5843 RVA: 0x00053EAC File Offset: 0x000520AC
			internal DeferShowHelper(global::Infragistics.Windows.Controls.ToolWindowHostPopup window)
			{
				this._window = window;
			}

			// Token: 0x060016D4 RID: 5844 RVA: 0x00053EBC File Offset: 0x000520BC
			public void Show(bool activate)
			{
				global::System.Windows.Controls.Primitives.Popup popup = this._window._popup;
				global::Infragistics.Windows.Controls.ToolWindow toolWindow = this._window.Child as global::Infragistics.Windows.Controls.ToolWindow;
				if (toolWindow != null)
				{
					popup.AllowsTransparency = toolWindow.AllowsTransparencyResolved;
				}
				popup.IsOpen = true;
				toolWindow = (this._window.Child as global::Infragistics.Windows.Controls.ToolWindow);
				if (activate && toolWindow != null)
				{
					toolWindow.Activate();
					toolWindow.Dispatcher.BeginInvoke(global::System.Windows.Threading.DispatcherPriority.Background, new global::System.Threading.ContextCallback(this._window.VerifyActivation), null);
				}
				this._window.VerifyIsInView(false, true, false);
			}

			// Token: 0x060016D5 RID: 5845 RVA: 0x00053F48 File Offset: 0x00052148
			public void Cancel()
			{
				global::Infragistics.Windows.Controls.ToolWindow toolWindow = this._window.Child as global::Infragistics.Windows.Controls.ToolWindow;
				if (toolWindow != null && !toolWindow.IsModal)
				{
					this._window.Child = null;
					global::Infragistics.Windows.Controls.ToolWindowHostPopup.CurrentPopups.Remove(this._window);
					if (toolWindow != null)
					{
						toolWindow.OnClosedInternal(false);
					}
				}
			}

			// Token: 0x04000BD3 RID: 3027
			private global::Infragistics.Windows.Controls.ToolWindowHostPopup _window;
		}
	}
}
