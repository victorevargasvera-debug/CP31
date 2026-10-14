using System;
using System.Windows;
using System.Windows.Input;
using System.Windows.Threading;

namespace Infragistics.Windows.DockManager
{
	// Token: 0x02000079 RID: 121
	internal static class MouseHoverService
	{
		// Token: 0x06000434 RID: 1076 RVA: 0x00017DDC File Offset: 0x00015FDC
		public static void Register(global::System.Type elementType)
		{
			if (!typeof(global::System.Windows.DependencyObject).IsAssignableFrom(elementType))
			{
				throw new global::System.InvalidOperationException();
			}
			if (!typeof(global::System.Windows.IInputElement).IsAssignableFrom(elementType))
			{
				throw new global::System.InvalidOperationException();
			}
			global::System.Windows.EventManager.RegisterClassHandler(elementType, global::System.Windows.Input.Mouse.MouseMoveEvent, new global::System.Windows.Input.MouseEventHandler(global::Infragistics.Windows.DockManager.MouseHoverService.OnMouseMove), true);
			global::System.Windows.EventManager.RegisterClassHandler(elementType, global::System.Windows.Input.Mouse.MouseDownEvent, new global::System.Windows.Input.MouseButtonEventHandler(global::Infragistics.Windows.DockManager.MouseHoverService.OnMouseDown), true);
			global::System.Windows.EventManager.RegisterClassHandler(elementType, global::System.Windows.Input.Mouse.MouseUpEvent, new global::System.Windows.Input.MouseButtonEventHandler(global::Infragistics.Windows.DockManager.MouseHoverService.OnMouseUp), true);
			global::System.Windows.EventManager.RegisterClassHandler(elementType, global::System.Windows.Input.Mouse.MouseLeaveEvent, new global::System.Windows.Input.MouseEventHandler(global::Infragistics.Windows.DockManager.MouseHoverService.OnMouseLeave), true);
		}

		// Token: 0x06000435 RID: 1077 RVA: 0x00017E79 File Offset: 0x00016079
		private static void OnMouseDown(object sender, global::System.Windows.Input.MouseButtonEventArgs e)
		{
			global::Infragistics.Windows.DockManager.MouseHoverService.ProcessMouseEvent(sender, e, true);
		}

		// Token: 0x06000436 RID: 1078 RVA: 0x00017E83 File Offset: 0x00016083
		private static void OnMouseLeave(object sender, global::System.Windows.Input.MouseEventArgs e)
		{
			global::Infragistics.Windows.DockManager.MouseHoverService.ProcessMouseEvent(sender, e, true);
		}

		// Token: 0x06000437 RID: 1079 RVA: 0x00017E8D File Offset: 0x0001608D
		private static void OnMouseMove(object sender, global::System.Windows.Input.MouseEventArgs e)
		{
			global::Infragistics.Windows.DockManager.MouseHoverService.ProcessMouseEvent(sender, e, false);
		}

		// Token: 0x06000438 RID: 1080 RVA: 0x00017E97 File Offset: 0x00016097
		private static void OnMouseUp(object sender, global::System.Windows.Input.MouseButtonEventArgs e)
		{
			global::Infragistics.Windows.DockManager.MouseHoverService.ProcessMouseEvent(sender, e, false);
		}

		// Token: 0x06000439 RID: 1081 RVA: 0x00017EA4 File Offset: 0x000160A4
		private static void ProcessMouseEvent(object sender, global::System.Windows.Input.MouseEventArgs e, bool forceCancel)
		{
			global::System.Windows.DependencyObject dependencyObject = (global::System.Windows.DependencyObject)sender;
			global::Infragistics.Windows.DockManager.MouseHoverService.MouseHoverInfo mouseHoverInfo = (global::Infragistics.Windows.DockManager.MouseHoverService.MouseHoverInfo)dependencyObject.GetValue(global::Infragistics.Windows.DockManager.MouseHoverService.MouseHoverInfoProperty);
			if (!forceCancel && e.LeftButton == global::System.Windows.Input.MouseButtonState.Released && e.RightButton == global::System.Windows.Input.MouseButtonState.Released && e.MiddleButton == global::System.Windows.Input.MouseButtonState.Released && e.XButton1 == global::System.Windows.Input.MouseButtonState.Released && e.XButton2 == global::System.Windows.Input.MouseButtonState.Released)
			{
				if (mouseHoverInfo == null)
				{
					mouseHoverInfo = new global::Infragistics.Windows.DockManager.MouseHoverService.MouseHoverInfo((global::System.Windows.IInputElement)sender);
					dependencyObject.SetValue(global::Infragistics.Windows.DockManager.MouseHoverService.MouseHoverInfoPropertyKey, mouseHoverInfo);
				}
				mouseHoverInfo.Initialize(e);
				return;
			}
			if (mouseHoverInfo != null)
			{
				mouseHoverInfo.Cancel();
				dependencyObject.ClearValue(global::Infragistics.Windows.DockManager.MouseHoverService.MouseHoverInfoPropertyKey);
			}
		}

		// Token: 0x040002C2 RID: 706
		private static readonly global::System.Windows.DependencyPropertyKey MouseHoverInfoPropertyKey = global::System.Windows.DependencyProperty.RegisterAttachedReadOnly("MouseHoverInfo", typeof(global::Infragistics.Windows.DockManager.MouseHoverService.MouseHoverInfo), typeof(global::Infragistics.Windows.DockManager.MouseHoverService), new global::System.Windows.FrameworkPropertyMetadata(null));

		// Token: 0x040002C3 RID: 707
		private static readonly global::System.Windows.DependencyProperty MouseHoverInfoProperty = global::Infragistics.Windows.DockManager.MouseHoverService.MouseHoverInfoPropertyKey.DependencyProperty;

		// Token: 0x040002C4 RID: 708
		public static readonly global::System.Windows.RoutedEvent MouseHoverEvent = global::System.Windows.EventManager.RegisterRoutedEvent("MouseHover", global::System.Windows.RoutingStrategy.Direct, typeof(global::System.Windows.Input.MouseEventHandler), typeof(global::Infragistics.Windows.DockManager.MouseHoverService));

		// Token: 0x0200007A RID: 122
		private class MouseHoverInfo
		{
			// Token: 0x0600043A RID: 1082 RVA: 0x00017F2B File Offset: 0x0001612B
			internal MouseHoverInfo(global::System.Windows.IInputElement element)
			{
				global::Infragistics.Windows.DockManager.DockManagerUtilities.ThrowIfNull(element, "element");
				this._element = element;
			}

			// Token: 0x0600043B RID: 1083 RVA: 0x00017F45 File Offset: 0x00016145
			internal void Cancel()
			{
				this._lastMousePoint = null;
				this.StopTimer();
			}

			// Token: 0x0600043C RID: 1084 RVA: 0x00017F5C File Offset: 0x0001615C
			internal void Initialize(global::System.Windows.Input.MouseEventArgs e)
			{
				global::System.Windows.Point position = e.GetPosition(this._element);
				if (this._lastMousePoint != null)
				{
					global::System.Windows.Size size = new global::System.Windows.Size(global::System.Windows.SystemParameters.MouseHoverWidth, global::System.Windows.SystemParameters.MouseHoverHeight);
					global::System.Windows.Rect rect = new global::System.Windows.Rect(this._lastMousePoint.Value, size);
					rect.Offset(-size.Width / 2.0, -size.Height / 2.0);
					if (rect.Contains(position))
					{
						return;
					}
				}
				this._lastMousePoint = new global::System.Windows.Point?(position);
				this.StartTimer();
			}

			// Token: 0x0600043D RID: 1085 RVA: 0x00017FF0 File Offset: 0x000161F0
			private void OnTimerTick(object sender, global::System.EventArgs e)
			{
				this.Cancel();
				global::System.Windows.Input.MouseEventArgs mouseEventArgs = new global::System.Windows.Input.MouseEventArgs(global::System.Windows.Input.Mouse.PrimaryDevice, global::System.Environment.TickCount);
				mouseEventArgs.RoutedEvent = global::Infragistics.Windows.DockManager.MouseHoverService.MouseHoverEvent;
				this._element.RaiseEvent(mouseEventArgs);
			}

			// Token: 0x0600043E RID: 1086 RVA: 0x0001802C File Offset: 0x0001622C
			private void StartTimer()
			{
				if (this._timer == null)
				{
					this._timer = new global::System.Windows.Threading.DispatcherTimer(global::System.Windows.Threading.DispatcherPriority.Input);
					this._timer.Tick += this.OnTimerTick;
				}
				else
				{
					this._timer.Stop();
				}
				this._timer.Interval = global::System.Windows.SystemParameters.MouseHoverTime;
				this._timer.Start();
			}

			// Token: 0x0600043F RID: 1087 RVA: 0x0001808C File Offset: 0x0001628C
			private void StopTimer()
			{
				if (this._timer != null)
				{
					this._timer.Stop();
				}
			}

			// Token: 0x040002C5 RID: 709
			private global::System.Windows.IInputElement _element;

			// Token: 0x040002C6 RID: 710
			private global::System.Windows.Point? _lastMousePoint;

			// Token: 0x040002C7 RID: 711
			private global::System.Windows.Threading.DispatcherTimer _timer;
		}
	}
}
