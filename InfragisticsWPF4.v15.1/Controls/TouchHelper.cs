using System;
using System.Collections.Generic;
using System.Security;
using System.Windows;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Threading;
using Infragistics.Windows;

namespace Infragistics.Controls
{
	// Token: 0x020000F7 RID: 247
	internal class TouchHelper : global::Infragistics.Controls.TouchHelperBase
	{
		// Token: 0x060008C3 RID: 2243 RVA: 0x0001E639 File Offset: 0x0001C839
		public TouchHelper() : this(null)
		{
		}

		// Token: 0x060008C4 RID: 2244 RVA: 0x0001E642 File Offset: 0x0001C842
		public TouchHelper(global::Infragistics.Controls.IProvideTouchInfo touchInfoProvider) : base(touchInfoProvider)
		{
		}

		// Token: 0x060008C5 RID: 2245 RVA: 0x0001E674 File Offset: 0x0001C874
		protected override void OnAttached()
		{
			global::System.Windows.UIElement element = base.Element;
			if (element != null)
			{
				global::Infragistics.Controls.TouchHelper.ManageHwndSource(element, true);
				element.ManipulationCompleted += this._element_ManipulationCompleted;
				element.ManipulationInertiaStarting += this._element_ManipulationInertiaStarting;
				element.ManipulationStarted += this._element_ManipulationStarted;
				element.ManipulationStarting += this._element_ManipulationStarting;
				element.ManipulationDelta += this._element_ManipulationDelta;
			}
			this._touchAndHoldTimer = new global::System.Windows.Threading.DispatcherTimer
			{
				Interval = this.TouchAndHoldThreshold
			};
			this._touchAndHoldTimer.Tick += this.TouchAndHoldTimer_Tick;
			this._tapTimer = new global::System.Windows.Threading.DispatcherTimer
			{
				Interval = this.TapThreshold
			};
			this._tapTimer.Tick += this.TapTimer_Tick;
		}

		// Token: 0x060008C6 RID: 2246 RVA: 0x0001E74C File Offset: 0x0001C94C
		protected override void OnDetached()
		{
			global::System.Windows.UIElement element = base.Element;
			if (element != null)
			{
				global::Infragistics.Controls.TouchHelper.ManageHwndSource(element, true);
				element.ManipulationBoundaryFeedback -= this._element_ManipulationBoundaryFeedback;
				element.ManipulationCompleted -= this._element_ManipulationCompleted;
				element.ManipulationInertiaStarting -= this._element_ManipulationInertiaStarting;
				element.ManipulationStarted -= this._element_ManipulationStarted;
				element.ManipulationStarting -= this._element_ManipulationStarting;
				element.ManipulationDelta -= this._element_ManipulationDelta;
			}
			if (this._touchAndHoldTimer != null)
			{
				this._touchAndHoldTimer.Stop();
				this._touchAndHoldTimer.Tick -= this.TouchAndHoldTimer_Tick;
				this._touchAndHoldTimer = null;
			}
			if (this._tapTimer != null)
			{
				this._tapTimer.Stop();
				this._tapTimer.Tick -= this.TouchAndHoldTimer_Tick;
				this._tapTimer = null;
			}
		}

		// Token: 0x060008C7 RID: 2247 RVA: 0x0001E838 File Offset: 0x0001CA38
		protected override void OnStateChanged(global::Infragistics.Controls.TouchState newState, global::Infragistics.Controls.TouchState oldState)
		{
			if (newState != global::Infragistics.Controls.TouchState.Pending)
			{
				this._touchAndHoldTimer.Stop();
				this._tapTimer.Stop();
			}
			base.OnStateChanged(newState, oldState);
		}

		// Token: 0x1700016B RID: 363
		// (get) Token: 0x060008C8 RID: 2248 RVA: 0x0001E85C File Offset: 0x0001CA5C
		// (set) Token: 0x060008C9 RID: 2249 RVA: 0x0001E864 File Offset: 0x0001CA64
		public global::System.TimeSpan TouchAndHoldThreshold
		{
			get
			{
				return this._touchAndHoldThreshold;
			}
			set
			{
				if (value != this._touchAndHoldThreshold)
				{
					this._touchAndHoldThreshold = value;
					this._touchAndHoldTimer.Interval = this._touchAndHoldThreshold;
				}
			}
		}

		// Token: 0x1700016C RID: 364
		// (get) Token: 0x060008CA RID: 2250 RVA: 0x0001E88C File Offset: 0x0001CA8C
		// (set) Token: 0x060008CB RID: 2251 RVA: 0x0001E894 File Offset: 0x0001CA94
		public global::System.TimeSpan TapThreshold
		{
			get
			{
				return this._tapThreshold;
			}
			set
			{
				if (value != this._tapThreshold)
				{
					this._tapThreshold = value;
					this._tapTimer.Interval = this._tapThreshold;
				}
			}
		}

		// Token: 0x060008CC RID: 2252 RVA: 0x0001E8BC File Offset: 0x0001CABC
		private bool HasLastQueryTimeExpired()
		{
			bool result = false;
			if (global::Infragistics.Controls.TouchHelper._TickCountOfLastQuerySystemGestureStatus != null)
			{
				result = (global::System.Math.Abs(global::System.Environment.TickCount - global::Infragistics.Controls.TouchHelper._TickCountOfLastQuerySystemGestureStatus.Value) > 400);
				global::Infragistics.Controls.TouchHelper._TickCountOfLastQuerySystemGestureStatus = null;
			}
			return result;
		}

		// Token: 0x060008CD RID: 2253 RVA: 0x0001E900 File Offset: 0x0001CB00
		[global::System.Security.SecuritySafeCritical]
		private static void ManageHwndSource(global::System.Windows.UIElement element, bool isAdding)
		{
			global::Infragistics.CoreUtilities.ValidateNotNull(element);
			if (global::Infragistics.Controls.TouchHelper._hwndSourceHelper == null)
			{
				if (!isAdding || !global::Infragistics.Controls.TouchHelper._canCreateHwndSource)
				{
					return;
				}
				if (global::Infragistics.Controls.TouchHelper._canCreateHwndSource)
				{
					try
					{
						global::Infragistics.Controls.TouchHelper._hwndSourceHelper = new global::Infragistics.Windows.HwndSourceHelper(new global::System.Windows.Interop.HwndSourceHook(global::Infragistics.Controls.TouchHelper.WndProc));
					}
					catch (global::System.Security.SecurityException)
					{
						global::Infragistics.Controls.TouchHelper._canCreateHwndSource = false;
					}
				}
				if (global::Infragistics.Controls.TouchHelper._hwndSourceHelper == null)
				{
					return;
				}
			}
			if (isAdding)
			{
				global::Infragistics.Controls.TouchHelper._hwndSourceHelper.AddElement(element);
				return;
			}
			global::Infragistics.Controls.TouchHelper._hwndSourceHelper.RemoveElement(element);
		}

		// Token: 0x060008CE RID: 2254 RVA: 0x0001E980 File Offset: 0x0001CB80
		private static global::System.IntPtr WndProc(global::System.IntPtr hwnd, int message, global::System.IntPtr wParam, global::System.IntPtr lParam, ref bool handled)
		{
			if (message == 716)
			{
				global::Infragistics.Controls.TouchHelper._TickCountOfLastQuerySystemGestureStatus = new int?(global::System.Environment.TickCount);
			}
			return global::System.IntPtr.Zero;
		}

		// Token: 0x060008CF RID: 2255 RVA: 0x0001E9A0 File Offset: 0x0001CBA0
		private void _element_ManipulationDelta(object sender, global::System.Windows.Input.ManipulationDeltaEventArgs e)
		{
			this._touchAndHoldTimer.Stop();
			if (e.ManipulationContainer != base.Element)
			{
				return;
			}
			if (base.CurrentState == global::Infragistics.Controls.TouchState.Scrolling && global::Infragistics.Controls.TouchHelper._TickCountOfLastQuerySystemGestureStatus != null)
			{
				e.Complete();
				e.Handled = true;
				base.CurrentState = global::Infragistics.Controls.TouchState.NotDown;
				return;
			}
			if (this.HasLastQueryTimeExpired())
			{
				base.CurrentState = global::Infragistics.Controls.TouchState.Holding;
				base.CurrentState = global::Infragistics.Controls.TouchState.NotDown;
				e.Cancel();
				e.Handled = true;
				return;
			}
			if (base.CurrentState == global::Infragistics.Controls.TouchState.Pending)
			{
				int tickCount = global::System.Environment.TickCount;
				if (global::System.Math.Abs(tickCount - this._startedTimeStamp) <= 400)
				{
					global::System.Windows.Vector translation = e.CumulativeManipulation.Translation;
					if (global::System.Math.Abs(translation.X) <= 3.0 && global::System.Math.Abs(translation.Y) <= 3.0)
					{
						e.Handled = true;
						return;
					}
					base.CurrentState = global::Infragistics.Controls.TouchState.Scrolling;
				}
				else
				{
					base.CurrentState = global::Infragistics.Controls.TouchState.Holding;
				}
			}
			this._tapValid = false;
			if (base.CurrentState != global::Infragistics.Controls.TouchState.Scrolling)
			{
				base.CurrentState = global::Infragistics.Controls.TouchState.NotDown;
				e.Cancel();
				e.Handled = true;
				return;
			}
			this.OnPan(e);
			this._pannedData = true;
			e.Handled = true;
		}

		// Token: 0x060008D0 RID: 2256 RVA: 0x0001EAC8 File Offset: 0x0001CCC8
		private void _element_ManipulationStarting(object sender, global::System.Windows.Input.ManipulationStartingEventArgs e)
		{
			if (e.ManipulationContainer != base.Element)
			{
				return;
			}
			int lastManipulationStarting = this._lastManipulationStarting;
			this._lastManipulationStarting = global::System.Environment.TickCount;
			int num = global::System.Math.Abs(this._lastManipulationStarting - lastManipulationStarting);
			if (num < global::Infragistics.Windows.Utilities.SystemDoubleClickTime)
			{
				base.CurrentState = global::Infragistics.Controls.TouchState.NotDown;
				e.Cancel();
				e.Handled = true;
				this._lastManipulationStarting = 0;
				return;
			}
			if (this.HasLastQueryTimeExpired())
			{
				base.CurrentState = global::Infragistics.Controls.TouchState.NotDown;
				e.Cancel();
				e.Handled = true;
				return;
			}
			global::System.Windows.Point position = new global::System.Windows.Point(-1000.0, -1000.0);
			global::System.Windows.UIElement elementDirectlyOver = null;
			using (global::System.Collections.Generic.IEnumerator<global::System.Windows.Input.IManipulator> enumerator = e.Manipulators.GetEnumerator())
			{
				if (enumerator.MoveNext())
				{
					global::System.Windows.Input.IManipulator manipulator = enumerator.Current;
					position = manipulator.GetPosition(base.Element);
					global::System.Windows.DependencyObject dependencyObject = base.Element.InputHitTest(position) as global::System.Windows.DependencyObject;
					while (dependencyObject is global::System.Windows.ContentElement)
					{
						dependencyObject = global::System.Windows.LogicalTreeHelper.GetParent(dependencyObject);
					}
					elementDirectlyOver = (dependencyObject as global::System.Windows.UIElement);
				}
			}
			base.SetScrollModeFromPoint(position, elementDirectlyOver);
			switch (base.ScrollMode)
			{
			case global::Infragistics.Controls.TouchScrollMode.None:
				return;
			case global::Infragistics.Controls.TouchScrollMode.Horizontal:
				e.Mode = global::System.Windows.Input.ManipulationModes.TranslateX;
				goto IL_13E;
			case global::Infragistics.Controls.TouchScrollMode.Vertical:
				e.Mode = global::System.Windows.Input.ManipulationModes.TranslateY;
				goto IL_13E;
			}
			e.Mode = global::System.Windows.Input.ManipulationModes.Translate;
			IL_13E:
			e.Handled = true;
		}

		// Token: 0x060008D1 RID: 2257 RVA: 0x0001EC2C File Offset: 0x0001CE2C
		private void _element_ManipulationStarted(object sender, global::System.Windows.Input.ManipulationStartedEventArgs e)
		{
			if (e.ManipulationContainer != base.Element)
			{
				return;
			}
			this._initalTouchElement = (e.ManipulationContainer as global::System.Windows.UIElement);
			this._initialTouchPoint = e.ManipulationOrigin;
			if (base.ScrollMode == global::Infragistics.Controls.TouchScrollMode.None)
			{
				base.CurrentState = global::Infragistics.Controls.TouchState.NotDown;
				e.Cancel();
				e.Handled = true;
				return;
			}
			base.CurrentState = global::Infragistics.Controls.TouchState.Pending;
			this._tapValid = true;
			this._tapTimer.Start();
			this._touchAndHoldTimer.Start();
			int tickCount = global::System.Environment.TickCount;
			if (global::System.Math.Abs((long)tickCount - (long)this._startedTimeStamp) <= 500L)
			{
				this.OnDoubleTap(this._initialTouchPoint, this._initalTouchElement);
			}
			this._startedTimeStamp = global::System.Environment.TickCount;
			e.Handled = true;
		}

		// Token: 0x060008D2 RID: 2258 RVA: 0x0001ECE8 File Offset: 0x0001CEE8
		private void _element_ManipulationInertiaStarting(object sender, global::System.Windows.Input.ManipulationInertiaStartingEventArgs e)
		{
			if (e.ManipulationContainer != base.Element)
			{
				return;
			}
			global::System.Windows.Input.ManipulationVelocities initialVelocities = e.InitialVelocities;
			double num = global::System.Math.Abs(initialVelocities.LinearVelocity.X);
			double num2 = global::System.Math.Abs(initialVelocities.LinearVelocity.Y);
			if (base.CurrentState == global::Infragistics.Controls.TouchState.Pending)
			{
				if (num < 0.001 && num2 < 0.001)
				{
					e.Cancel();
					e.Handled = true;
					base.CurrentState = global::Infragistics.Controls.TouchState.NotDown;
					return;
				}
			}
			else if (base.CurrentState != global::Infragistics.Controls.TouchState.Scrolling)
			{
				base.CurrentState = global::Infragistics.Controls.TouchState.NotDown;
				e.Cancel();
				e.Handled = true;
				return;
			}
			global::System.Windows.Input.InertiaTranslationBehavior translationBehavior = e.TranslationBehavior;
			if (translationBehavior != null)
			{
				if (num * 4.0 > num2)
				{
					translationBehavior.InitialVelocity = new global::System.Windows.Vector(initialVelocities.LinearVelocity.X, 0.0);
				}
				else if (num2 * 4.0 > num)
				{
					translationBehavior.InitialVelocity = new global::System.Windows.Vector(0.0, initialVelocities.LinearVelocity.Y);
				}
			}
			if (!e.Handled)
			{
				e.TranslationBehavior.DesiredDeceleration = 0.001;
				e.Handled = true;
			}
		}

		// Token: 0x060008D3 RID: 2259 RVA: 0x0001EE1C File Offset: 0x0001D01C
		private void _element_ManipulationCompleted(object sender, global::System.Windows.Input.ManipulationCompletedEventArgs e)
		{
			this._touchAndHoldTimer.Stop();
			if (e.ManipulationContainer != base.Element)
			{
				return;
			}
			if (this._tapValid)
			{
				this.OnTap(e.ManipulationOrigin, e.ManipulationContainer as global::System.Windows.UIElement);
			}
			this._initalTouchElement = null;
			if (this._pannedData)
			{
				this._pannedData = false;
				this.OnPanComplete();
			}
			this.OnTouchCompleted(e.ManipulationOrigin, e.ManipulationContainer as global::System.Windows.UIElement);
			switch (base.CurrentState)
			{
			case global::Infragistics.Controls.TouchState.Pending:
			case global::Infragistics.Controls.TouchState.Holding:
				e.Cancel();
				break;
			}
			base.CurrentState = global::Infragistics.Controls.TouchState.NotDown;
			e.Handled = true;
		}

		// Token: 0x060008D4 RID: 2260 RVA: 0x0001EEC7 File Offset: 0x0001D0C7
		private void _element_ManipulationBoundaryFeedback(object sender, global::System.Windows.Input.ManipulationBoundaryFeedbackEventArgs e)
		{
		}

		// Token: 0x060008D5 RID: 2261 RVA: 0x0001EEC9 File Offset: 0x0001D0C9
		private void TapTimer_Tick(object sender, global::System.EventArgs e)
		{
			this._tapValid = false;
			this._tapTimer.Stop();
		}

		// Token: 0x060008D6 RID: 2262 RVA: 0x0001EEDD File Offset: 0x0001D0DD
		private void TouchAndHoldTimer_Tick(object sender, global::System.EventArgs e)
		{
			this._touchAndHoldTimer.Stop();
			if (base.CurrentState == global::Infragistics.Controls.TouchState.Pending)
			{
				base.CurrentState = global::Infragistics.Controls.TouchState.Holding;
				this.OnTapAndHold(this._initialTouchPoint, this._initalTouchElement);
				base.CurrentState = global::Infragistics.Controls.TouchState.NotDown;
			}
		}

		// Token: 0x04000432 RID: 1074
		private bool _tapValid;

		// Token: 0x04000433 RID: 1075
		private global::System.TimeSpan _touchAndHoldThreshold = global::System.TimeSpan.FromSeconds(2.0);

		// Token: 0x04000434 RID: 1076
		private global::System.TimeSpan _tapThreshold = global::System.TimeSpan.FromSeconds(2.0);

		// Token: 0x04000435 RID: 1077
		private global::System.Windows.Threading.DispatcherTimer _touchAndHoldTimer;

		// Token: 0x04000436 RID: 1078
		private global::System.Windows.Threading.DispatcherTimer _tapTimer;

		// Token: 0x04000437 RID: 1079
		private int _startedTimeStamp;

		// Token: 0x04000438 RID: 1080
		private global::System.Windows.UIElement _initalTouchElement;

		// Token: 0x04000439 RID: 1081
		private global::System.Windows.Point _initialTouchPoint;

		// Token: 0x0400043A RID: 1082
		private int _lastManipulationStarting;

		// Token: 0x0400043B RID: 1083
		private bool _pannedData;

		// Token: 0x0400043C RID: 1084
		[global::System.ThreadStatic]
		private static global::Infragistics.Windows.HwndSourceHelper _hwndSourceHelper;

		// Token: 0x0400043D RID: 1085
		private static bool _canCreateHwndSource = true;

		// Token: 0x0400043E RID: 1086
		[global::System.ThreadStatic]
		private static int? _TickCountOfLastQuerySystemGestureStatus;
	}
}
