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
	// Token: 0x020000D9 RID: 217
	internal class TouchHelper : global::Infragistics.Controls.TouchHelperBase
	{
		// Token: 0x060007C4 RID: 1988 RVA: 0x0001AA72 File Offset: 0x00018C72
		public TouchHelper() : this(null)
		{
		}

		// Token: 0x060007C5 RID: 1989 RVA: 0x0001AA7B File Offset: 0x00018C7B
		public TouchHelper(global::Infragistics.Controls.IProvideTouchInfo touchInfoProvider) : base(touchInfoProvider)
		{
		}

		// Token: 0x060007C6 RID: 1990 RVA: 0x0001AAAC File Offset: 0x00018CAC
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

		// Token: 0x060007C7 RID: 1991 RVA: 0x0001AB84 File Offset: 0x00018D84
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

		// Token: 0x060007C8 RID: 1992 RVA: 0x0001AC70 File Offset: 0x00018E70
		protected override void OnStateChanged(global::Infragistics.Controls.TouchState newState, global::Infragistics.Controls.TouchState oldState)
		{
			if (newState != global::Infragistics.Controls.TouchState.Pending)
			{
				this._touchAndHoldTimer.Stop();
				this._tapTimer.Stop();
			}
			base.OnStateChanged(newState, oldState);
		}

		// Token: 0x17000153 RID: 339
		// (get) Token: 0x060007C9 RID: 1993 RVA: 0x0001AC94 File Offset: 0x00018E94
		// (set) Token: 0x060007CA RID: 1994 RVA: 0x0001AC9C File Offset: 0x00018E9C
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

		// Token: 0x17000154 RID: 340
		// (get) Token: 0x060007CB RID: 1995 RVA: 0x0001ACC4 File Offset: 0x00018EC4
		// (set) Token: 0x060007CC RID: 1996 RVA: 0x0001ACCC File Offset: 0x00018ECC
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

		// Token: 0x060007CD RID: 1997 RVA: 0x0001ACF4 File Offset: 0x00018EF4
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

		// Token: 0x060007CE RID: 1998 RVA: 0x0001AD38 File Offset: 0x00018F38
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

		// Token: 0x060007CF RID: 1999 RVA: 0x0001ADB8 File Offset: 0x00018FB8
		private static global::System.IntPtr WndProc(global::System.IntPtr hwnd, int message, global::System.IntPtr wParam, global::System.IntPtr lParam, ref bool handled)
		{
			if (message == 716)
			{
				global::Infragistics.Controls.TouchHelper._TickCountOfLastQuerySystemGestureStatus = new int?(global::System.Environment.TickCount);
			}
			return global::System.IntPtr.Zero;
		}

		// Token: 0x060007D0 RID: 2000 RVA: 0x0001ADD8 File Offset: 0x00018FD8
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

		// Token: 0x060007D1 RID: 2001 RVA: 0x0001AF00 File Offset: 0x00019100
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

		// Token: 0x060007D2 RID: 2002 RVA: 0x0001B064 File Offset: 0x00019264
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

		// Token: 0x060007D3 RID: 2003 RVA: 0x0001B120 File Offset: 0x00019320
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

		// Token: 0x060007D4 RID: 2004 RVA: 0x0001B254 File Offset: 0x00019454
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

		// Token: 0x060007D5 RID: 2005 RVA: 0x0001B2FF File Offset: 0x000194FF
		private void _element_ManipulationBoundaryFeedback(object sender, global::System.Windows.Input.ManipulationBoundaryFeedbackEventArgs e)
		{
		}

		// Token: 0x060007D6 RID: 2006 RVA: 0x0001B301 File Offset: 0x00019501
		private void TapTimer_Tick(object sender, global::System.EventArgs e)
		{
			this._tapValid = false;
			this._tapTimer.Stop();
		}

		// Token: 0x060007D7 RID: 2007 RVA: 0x0001B315 File Offset: 0x00019515
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

		// Token: 0x0400037F RID: 895
		private bool _tapValid;

		// Token: 0x04000380 RID: 896
		private global::System.TimeSpan _touchAndHoldThreshold = global::System.TimeSpan.FromSeconds(2.0);

		// Token: 0x04000381 RID: 897
		private global::System.TimeSpan _tapThreshold = global::System.TimeSpan.FromSeconds(2.0);

		// Token: 0x04000382 RID: 898
		private global::System.Windows.Threading.DispatcherTimer _touchAndHoldTimer;

		// Token: 0x04000383 RID: 899
		private global::System.Windows.Threading.DispatcherTimer _tapTimer;

		// Token: 0x04000384 RID: 900
		private int _startedTimeStamp;

		// Token: 0x04000385 RID: 901
		private global::System.Windows.UIElement _initalTouchElement;

		// Token: 0x04000386 RID: 902
		private global::System.Windows.Point _initialTouchPoint;

		// Token: 0x04000387 RID: 903
		private int _lastManipulationStarting;

		// Token: 0x04000388 RID: 904
		private bool _pannedData;

		// Token: 0x04000389 RID: 905
		[global::System.ThreadStatic]
		private static global::Infragistics.Windows.HwndSourceHelper _hwndSourceHelper;

		// Token: 0x0400038A RID: 906
		private static bool _canCreateHwndSource = true;

		// Token: 0x0400038B RID: 907
		[global::System.ThreadStatic]
		private static int? _TickCountOfLastQuerySystemGestureStatus;
	}
}
