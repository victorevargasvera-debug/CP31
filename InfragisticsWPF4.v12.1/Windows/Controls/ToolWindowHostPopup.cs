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
using System.Windows.Media;
using System.Windows.Media.Media3D;
using System.Windows.Threading;
using Infragistics.Collections;
using Infragistics.Windows.Helpers;

namespace Infragistics.Windows.Controls
{
	// Token: 0x02000210 RID: 528
	internal class ToolWindowHostPopup : global::Infragistics.Windows.Controls.ToolWindowContainer, global::Infragistics.Windows.Controls.IToolWindowHost
	{
		// Token: 0x060014BA RID: 5306 RVA: 0x0004CD54 File Offset: 0x0004AF54
		static ToolWindowHostPopup()
		{
			global::System.Windows.Input.FocusManager.IsFocusScopeProperty.OverrideMetadata(typeof(global::Infragistics.Windows.Controls.ToolWindowHostPopup), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox));
		}

		// Token: 0x060014BB RID: 5307 RVA: 0x0004CE4E File Offset: 0x0004B04E
		private ToolWindowHostPopup()
		{
			base.Loaded += this.OnLoaded;
		}

		// Token: 0x170004B4 RID: 1204
		// (get) Token: 0x060014BC RID: 5308 RVA: 0x0004CE68 File Offset: 0x0004B068
		public override bool AllowsTransparency
		{
			get
			{
				return this._popup != null && this._popup.AllowsTransparency;
			}
		}

		// Token: 0x060014BD RID: 5309 RVA: 0x0004CE80 File Offset: 0x0004B080
		public override void BringToFront()
		{
			global::Infragistics.Windows.Controls.ToolWindow toolWindow = base.Child as global::Infragistics.Windows.Controls.ToolWindow;
			if (toolWindow != null && !toolWindow.IsModal)
			{
				base.BringIntoView();
			}
		}

		// Token: 0x060014BE RID: 5310 RVA: 0x0004CEAC File Offset: 0x0004B0AC
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

		// Token: 0x060014BF RID: 5311 RVA: 0x0004CEEF File Offset: 0x0004B0EF
		public override void EnsureOnScreen(bool fullyInView)
		{
			this.VerifyIsInView(true, true, fullyInView);
		}

		// Token: 0x060014C0 RID: 5312 RVA: 0x0004CEFC File Offset: 0x0004B0FC
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

		// Token: 0x060014C1 RID: 5313 RVA: 0x0004CFEC File Offset: 0x0004B1EC
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

		// Token: 0x060014C2 RID: 5314 RVA: 0x0004D068 File Offset: 0x0004B268
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

		// Token: 0x060014C3 RID: 5315 RVA: 0x0004D274 File Offset: 0x0004B474
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

		// Token: 0x060014C4 RID: 5316 RVA: 0x0004D363 File Offset: 0x0004B563
		public override void RelativePositionStateChanged()
		{
			this.RelativePositionStateChanged(global::Infragistics.Windows.Controls.ToolWindowHostPopup.RelativePositionStateChangedId);
		}

		// Token: 0x060014C5 RID: 5317 RVA: 0x0004D374 File Offset: 0x0004B574
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

		// Token: 0x060014C6 RID: 5318 RVA: 0x0004D564 File Offset: 0x0004B764
		public override bool SupportsAllowTransparency(bool allowsTransparency)
		{
			return allowsTransparency == global::Infragistics.Windows.Controls.PopupHelper.PopupAllowsTransparency;
		}

		// Token: 0x170004B5 RID: 1205
		// (get) Token: 0x060014C7 RID: 5319 RVA: 0x0004D56E File Offset: 0x0004B76E
		private bool ConstrainToWorkArea
		{
			get
			{
				return this._controller == null || (global::Infragistics.Windows.Controls.PopupHelper.IsPopupInChildWindow && this._isModal);
			}
		}

		// Token: 0x170004B6 RID: 1206
		// (get) Token: 0x060014C8 RID: 5320 RVA: 0x0004D589 File Offset: 0x0004B789
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

		// Token: 0x060014C9 RID: 5321 RVA: 0x0004D5A4 File Offset: 0x0004B7A4
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
						toolWindow.OnClosedInternal();
					}
				}
			}
		}

		// Token: 0x170004B7 RID: 1207
		// (get) Token: 0x060014CA RID: 5322 RVA: 0x0004D5F1 File Offset: 0x0004B7F1
		// (set) Token: 0x060014CB RID: 5323 RVA: 0x0004D603 File Offset: 0x0004B803
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

		// Token: 0x060014CC RID: 5324 RVA: 0x0004D616 File Offset: 0x0004B816
		private static global::System.Collections.Generic.Stack<global::Infragistics.Windows.Controls.ToolWindowHostPopup> GetModalToolWindows(global::System.Windows.DependencyObject d)
		{
			return (global::System.Collections.Generic.Stack<global::Infragistics.Windows.Controls.ToolWindowHostPopup>)d.GetValue(global::Infragistics.Windows.Controls.ToolWindowHostPopup.ModalToolWindowsProperty);
		}

		// Token: 0x060014CD RID: 5325 RVA: 0x0004D628 File Offset: 0x0004B828
		private static global::System.Collections.Generic.IList<global::Infragistics.Windows.Controls.ToolWindow> GetToolWindows(global::System.Windows.DependencyObject d)
		{
			return (global::System.Collections.Generic.IList<global::Infragistics.Windows.Controls.ToolWindow>)d.GetValue(global::Infragistics.Windows.Controls.ToolWindowHostPopup.ToolWindowsProperty);
		}

		// Token: 0x060014CE RID: 5326 RVA: 0x0004D63C File Offset: 0x0004B83C
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

		// Token: 0x060014CF RID: 5327 RVA: 0x0004D674 File Offset: 0x0004B874
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

		// Token: 0x060014D0 RID: 5328 RVA: 0x0004D6A0 File Offset: 0x0004B8A0
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

		// Token: 0x060014D1 RID: 5329 RVA: 0x0004D6D4 File Offset: 0x0004B8D4
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

		// Token: 0x060014D2 RID: 5330 RVA: 0x0004D768 File Offset: 0x0004B968
		private global::System.Windows.Rect GetWorkArea(global::System.Windows.Input.MouseEventArgs e)
		{
			if (!this.ConstrainToWorkArea)
			{
				return global::Infragistics.Windows.Helpers.NativeWindowMethods.VirtualScreenArea;
			}
			return new global::System.Windows.Rect(default(global::System.Windows.Point), this._rootVisual.RenderSize);
		}

		// Token: 0x060014D3 RID: 5331 RVA: 0x0004D79C File Offset: 0x0004B99C
		private void OnLayoutUpdated(object sender, global::System.EventArgs e)
		{
			this.RelativePositionStateChanged(global::Infragistics.Windows.Controls.ToolWindowHostPopup.LayoutUpdatedId);
		}

		// Token: 0x060014D4 RID: 5332 RVA: 0x0004D7AA File Offset: 0x0004B9AA
		private void OnUnloaded(object sender, global::System.Windows.RoutedEventArgs e)
		{
			base.Unloaded -= this.OnUnloaded;
			base.Loaded += this.OnLoaded;
			base.LayoutUpdated -= this.OnLayoutUpdated;
		}

		// Token: 0x060014D5 RID: 5333 RVA: 0x0004D7E2 File Offset: 0x0004B9E2
		private void OnLoaded(object sender, global::System.Windows.RoutedEventArgs e)
		{
			base.Loaded -= this.OnLoaded;
			base.Unloaded += this.OnUnloaded;
			this.RelativePositionStateChanged();
		}

		// Token: 0x060014D6 RID: 5334 RVA: 0x0004D810 File Offset: 0x0004BA10
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
				toolWindow.OnClosedInternal();
				if (this._callback != null)
				{
					this._callback(toolWindow, new bool?(value));
				}
			}
		}

		// Token: 0x060014D7 RID: 5335 RVA: 0x0004D8B9 File Offset: 0x0004BAB9
		private void OnPopupClosedModeless(object sender, global::System.EventArgs e)
		{
			global::Infragistics.Windows.Controls.ToolWindowHostPopup.CurrentPopups.Remove(this);
		}

		// Token: 0x060014D8 RID: 5336 RVA: 0x0004D8C8 File Offset: 0x0004BAC8
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

		// Token: 0x060014D9 RID: 5337 RVA: 0x0004D8F8 File Offset: 0x0004BAF8
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

		// Token: 0x060014DA RID: 5338 RVA: 0x0004D990 File Offset: 0x0004BB90
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

		// Token: 0x060014DB RID: 5339 RVA: 0x0004D9D2 File Offset: 0x0004BBD2
		internal static global::Infragistics.Windows.Controls.ToolWindow.IDeferShow Show(global::Infragistics.Windows.Controls.ToolWindow toolWindow)
		{
			return global::Infragistics.Windows.Controls.ToolWindowHostPopup.ShowImpl(toolWindow, false, null);
		}

		// Token: 0x060014DC RID: 5340 RVA: 0x0004D9DC File Offset: 0x0004BBDC
		internal static void ShowDialog(global::Infragistics.Windows.Controls.ToolWindow toolWindow, global::Infragistics.Windows.Controls.ToolWindow.ShowDialogCallback callback)
		{
			global::Infragistics.Windows.Controls.ToolWindow.IDeferShow deferShow = global::Infragistics.Windows.Controls.ToolWindowHostPopup.ShowImpl(toolWindow, true, callback);
			if (deferShow != null)
			{
				deferShow.Show(true);
			}
		}

		// Token: 0x060014DD RID: 5341 RVA: 0x0004D9FC File Offset: 0x0004BBFC
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
			toolWindowHostPopup._controller = global::Infragistics.Windows.Controls.PopupController.Create(popup, toolWindow.Owner);
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

		// Token: 0x060014DE RID: 5342 RVA: 0x0004DBC8 File Offset: 0x0004BDC8
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

		// Token: 0x060014DF RID: 5343 RVA: 0x0004DC08 File Offset: 0x0004BE08
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

		// Token: 0x060014E0 RID: 5344 RVA: 0x0004DC6C File Offset: 0x0004BE6C
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

		// Token: 0x04000A6C RID: 2668
		private global::System.Windows.Controls.Primitives.Popup _popup;

		// Token: 0x04000A6D RID: 2669
		private global::Infragistics.Windows.Controls.ToolWindow.ShowDialogCallback _callback;

		// Token: 0x04000A6E RID: 2670
		private global::System.Windows.FrameworkElement _rootVisual;

		// Token: 0x04000A6F RID: 2671
		private global::System.Windows.Rect _screenRect;

		// Token: 0x04000A70 RID: 2672
		private global::System.WeakReference _previousFocusedElement;

		// Token: 0x04000A71 RID: 2673
		private global::System.Windows.FrameworkElement _elementToDisable;

		// Token: 0x04000A72 RID: 2674
		private global::Infragistics.Windows.Controls.PopupController _controller;

		// Token: 0x04000A73 RID: 2675
		private static readonly object InitialRelativePositionId = new object();

		// Token: 0x04000A74 RID: 2676
		private static readonly object RelativePositionStateChangedId = new object();

		// Token: 0x04000A75 RID: 2677
		private static readonly object LayoutUpdatedId = new object();

		// Token: 0x04000A76 RID: 2678
		private static readonly object SynchronousRelativePositionId = new object();

		// Token: 0x04000A77 RID: 2679
		[global::System.ThreadStatic]
		private static global::Infragistics.Collections.WeakList<global::Infragistics.Windows.Controls.ToolWindowHostPopup> _currentPopups;

		// Token: 0x04000A78 RID: 2680
		private global::Infragistics.Windows.Helpers.GroupTempValueReplacement _modalDisabledStates;

		// Token: 0x04000A79 RID: 2681
		private bool _isModal;

		// Token: 0x04000A7A RID: 2682
		private static readonly global::System.Windows.DependencyProperty IsOpenProperty = global::System.Windows.DependencyProperty.Register("IsOpen", typeof(bool), typeof(global::Infragistics.Windows.Controls.ToolWindowHostPopup), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.Controls.ToolWindowHostPopup.OnIsOpenChanged)));

		// Token: 0x04000A7B RID: 2683
		private static readonly global::System.Windows.DependencyPropertyKey ModalToolWindowsPropertyKey = global::System.Windows.DependencyProperty.RegisterAttachedReadOnly("ModalToolWindows", typeof(global::System.Collections.Generic.Stack<global::Infragistics.Windows.Controls.ToolWindowHostPopup>), typeof(global::Infragistics.Windows.Controls.ToolWindowHostPopup), new global::System.Windows.FrameworkPropertyMetadata());

		// Token: 0x04000A7C RID: 2684
		private static readonly global::System.Windows.DependencyProperty ModalToolWindowsProperty = global::Infragistics.Windows.Controls.ToolWindowHostPopup.ModalToolWindowsPropertyKey.DependencyProperty;

		// Token: 0x04000A7D RID: 2685
		private static readonly global::System.Windows.DependencyPropertyKey ToolWindowsPropertyKey = global::System.Windows.DependencyProperty.RegisterAttachedReadOnly("ToolWindows", typeof(global::System.Collections.Generic.IList<global::Infragistics.Windows.Controls.ToolWindow>), typeof(global::Infragistics.Windows.Controls.ToolWindowHostPopup), new global::System.Windows.FrameworkPropertyMetadata());

		// Token: 0x04000A7E RID: 2686
		private static readonly global::System.Windows.DependencyProperty ToolWindowsProperty = global::Infragistics.Windows.Controls.ToolWindowHostPopup.ToolWindowsPropertyKey.DependencyProperty;

		// Token: 0x02000211 RID: 529
		private class PopupChildWrapper : global::System.Windows.FrameworkElement
		{
			// Token: 0x060014E1 RID: 5345 RVA: 0x0004DD07 File Offset: 0x0004BF07
			internal PopupChildWrapper(global::Infragistics.Windows.Controls.ToolWindowHostPopup host)
			{
				this._host = host;
				base.AddLogicalChild(host);
				base.AddVisualChild(host);
			}

			// Token: 0x060014E2 RID: 5346 RVA: 0x0004DD24 File Offset: 0x0004BF24
			protected override global::System.Windows.Size MeasureOverride(global::System.Windows.Size availableSize)
			{
				if (this._isMeasuringMaxHeight)
				{
					return new global::System.Windows.Size(2147483647.0, 2147483647.0);
				}
				this._host.Measure(availableSize);
				return this._host.DesiredSize;
			}

			// Token: 0x060014E3 RID: 5347 RVA: 0x0004DD5D File Offset: 0x0004BF5D
			protected override global::System.Windows.Size ArrangeOverride(global::System.Windows.Size finalSize)
			{
				this._host.Arrange(new global::System.Windows.Rect(finalSize));
				return finalSize;
			}

			// Token: 0x060014E4 RID: 5348 RVA: 0x0004DD71 File Offset: 0x0004BF71
			protected override global::System.Windows.Media.Visual GetVisualChild(int index)
			{
				if (index != 0)
				{
					throw new global::System.ArgumentOutOfRangeException();
				}
				return this._host;
			}

			// Token: 0x170004B8 RID: 1208
			// (get) Token: 0x060014E5 RID: 5349 RVA: 0x0004DD82 File Offset: 0x0004BF82
			protected override int VisualChildrenCount
			{
				get
				{
					return 1;
				}
			}

			// Token: 0x170004B9 RID: 1209
			// (get) Token: 0x060014E6 RID: 5350 RVA: 0x0004DD85 File Offset: 0x0004BF85
			protected override global::System.Collections.IEnumerator LogicalChildren
			{
				get
				{
					return new global::Infragistics.Collections.SingleItemEnumerator(this._host);
				}
			}

			// Token: 0x170004BA RID: 1210
			// (get) Token: 0x060014E7 RID: 5351 RVA: 0x0004DD92 File Offset: 0x0004BF92
			public global::Infragistics.Windows.Controls.ToolWindowHostPopup Host
			{
				get
				{
					return this._host;
				}
			}

			// Token: 0x060014E8 RID: 5352 RVA: 0x0004DD9C File Offset: 0x0004BF9C
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

			// Token: 0x04000A7F RID: 2687
			private global::Infragistics.Windows.Controls.ToolWindowHostPopup _host;

			// Token: 0x04000A80 RID: 2688
			private bool _isMeasuringMaxHeight;
		}

		// Token: 0x02000212 RID: 530
		private class DeferShowHelper : global::Infragistics.Windows.Controls.ToolWindow.IDeferShow
		{
			// Token: 0x060014E9 RID: 5353 RVA: 0x0004DE48 File Offset: 0x0004C048
			internal DeferShowHelper(global::Infragistics.Windows.Controls.ToolWindowHostPopup window)
			{
				this._window = window;
			}

			// Token: 0x060014EA RID: 5354 RVA: 0x0004DE58 File Offset: 0x0004C058
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

			// Token: 0x060014EB RID: 5355 RVA: 0x0004DEE4 File Offset: 0x0004C0E4
			public void Cancel()
			{
				global::Infragistics.Windows.Controls.ToolWindow toolWindow = this._window.Child as global::Infragistics.Windows.Controls.ToolWindow;
				if (toolWindow != null && !toolWindow.IsModal)
				{
					this._window.Child = null;
					global::Infragistics.Windows.Controls.ToolWindowHostPopup.CurrentPopups.Remove(this._window);
					if (toolWindow != null)
					{
						toolWindow.OnClosedInternal();
					}
				}
			}

			// Token: 0x04000A81 RID: 2689
			private global::Infragistics.Windows.Controls.ToolWindowHostPopup _window;
		}
	}
}
