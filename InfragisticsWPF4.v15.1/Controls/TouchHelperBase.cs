using System;
using System.Windows;
using System.Windows.Input;

namespace Infragistics.Controls
{
	// Token: 0x020000F6 RID: 246
	internal abstract class TouchHelperBase : global::System.Windows.DependencyObject
	{
		// Token: 0x0600089C RID: 2204 RVA: 0x0001DFF0 File Offset: 0x0001C1F0
		protected TouchHelperBase(global::Infragistics.Controls.IProvideTouchInfo touchInfoProvider)
		{
			this._touchInfoProvider = touchInfoProvider;
		}

		// Token: 0x17000167 RID: 359
		// (get) Token: 0x0600089D RID: 2205 RVA: 0x0001DFFF File Offset: 0x0001C1FF
		// (set) Token: 0x0600089E RID: 2206 RVA: 0x0001E008 File Offset: 0x0001C208
		public global::Infragistics.Controls.TouchState CurrentState
		{
			get
			{
				return this._currentState;
			}
			protected set
			{
				if (value != this._currentState)
				{
					global::Infragistics.Controls.TouchState currentState = this._currentState;
					this._currentState = value;
					this.OnStateChanged(this._currentState, currentState);
				}
			}
		}

		// Token: 0x17000168 RID: 360
		// (get) Token: 0x0600089F RID: 2207 RVA: 0x0001E039 File Offset: 0x0001C239
		public global::System.Windows.UIElement Element
		{
			get
			{
				return this._element;
			}
		}

		// Token: 0x17000169 RID: 361
		// (get) Token: 0x060008A0 RID: 2208 RVA: 0x0001E041 File Offset: 0x0001C241
		internal global::Infragistics.Controls.TouchScrollMode ScrollMode
		{
			get
			{
				return this._scrollMode;
			}
		}

		// Token: 0x1700016A RID: 362
		// (get) Token: 0x060008A1 RID: 2209 RVA: 0x0001E049 File Offset: 0x0001C249
		internal global::Infragistics.Controls.IProvideTouchInfo TouchInfoProvider
		{
			get
			{
				return this._touchInfoProvider;
			}
		}

		// Token: 0x060008A2 RID: 2210 RVA: 0x0001E051 File Offset: 0x0001C251
		public static global::Infragistics.Controls.TouchHelper GetTouchHelper(global::System.Windows.UIElement element)
		{
			return (global::Infragistics.Controls.TouchHelper)element.GetValue(global::Infragistics.Controls.TouchHelperBase.TouchHelperProperty);
		}

		// Token: 0x060008A3 RID: 2211 RVA: 0x0001E063 File Offset: 0x0001C263
		internal static void SetTouchHelper(global::System.Windows.UIElement element, global::Infragistics.Controls.TouchHelper helper)
		{
			element.SetValue(global::Infragistics.Controls.TouchHelperBase.TouchHelperPropertyKey, helper);
		}

		// Token: 0x060008A4 RID: 2212 RVA: 0x0001E074 File Offset: 0x0001C274
		private static void OnTouchHelperChanged(global::System.Windows.DependencyObject target, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::System.Windows.UIElement element = target as global::System.Windows.UIElement;
			global::Infragistics.Controls.TouchHelperBase touchHelperBase = e.OldValue as global::Infragistics.Controls.TouchHelperBase;
			if (touchHelperBase != null)
			{
				touchHelperBase.OnDetached();
				touchHelperBase._element = null;
			}
			global::Infragistics.Controls.TouchHelperBase touchHelperBase2 = e.NewValue as global::Infragistics.Controls.TouchHelperBase;
			if (touchHelperBase2 != null)
			{
				touchHelperBase2._element = element;
				touchHelperBase2.OnAttached();
			}
		}

		// Token: 0x060008A5 RID: 2213 RVA: 0x0001E0C2 File Offset: 0x0001C2C2
		protected internal virtual void CancelTouchInteraction()
		{
		}

		// Token: 0x060008A6 RID: 2214
		protected abstract void OnAttached();

		// Token: 0x060008A7 RID: 2215
		protected abstract void OnDetached();

		// Token: 0x060008A8 RID: 2216 RVA: 0x0001E0C4 File Offset: 0x0001C2C4
		internal void SetScrollModeFromPoint(global::System.Windows.Point point, global::System.Windows.UIElement elementDirectlyOver)
		{
			if (this._touchInfoProvider == null)
			{
				this._scrollMode = global::Infragistics.Controls.TouchScrollMode.Both;
				return;
			}
			this._scrollMode = this._touchInfoProvider.GetScrollModeFromPoint(point, elementDirectlyOver);
		}

		// Token: 0x14000018 RID: 24
		// (add) Token: 0x060008A9 RID: 2217 RVA: 0x0001E0EC File Offset: 0x0001C2EC
		// (remove) Token: 0x060008AA RID: 2218 RVA: 0x0001E124 File Offset: 0x0001C324
		public event global::System.EventHandler<global::Infragistics.Controls.TapEventArgs> TouchStarted;

		// Token: 0x060008AB RID: 2219 RVA: 0x0001E159 File Offset: 0x0001C359
		protected virtual void OnTouchStarted(global::System.Windows.Point p, global::System.Windows.UIElement element)
		{
			if (this.TouchStarted != null)
			{
				this.TouchStarted(this.Element, new global::Infragistics.Controls.TapEventArgs(p, element));
			}
		}

		// Token: 0x14000019 RID: 25
		// (add) Token: 0x060008AC RID: 2220 RVA: 0x0001E17C File Offset: 0x0001C37C
		// (remove) Token: 0x060008AD RID: 2221 RVA: 0x0001E1B4 File Offset: 0x0001C3B4
		public event global::System.EventHandler<global::Infragistics.Controls.TapEventArgs> TouchCompleted;

		// Token: 0x060008AE RID: 2222 RVA: 0x0001E1E9 File Offset: 0x0001C3E9
		protected virtual void OnTouchCompleted(global::System.Windows.Point p, global::System.Windows.UIElement element)
		{
			if (this.TouchCompleted != null)
			{
				this.TouchCompleted(this.Element, new global::Infragistics.Controls.TapEventArgs(p, element));
			}
		}

		// Token: 0x1400001A RID: 26
		// (add) Token: 0x060008AF RID: 2223 RVA: 0x0001E20C File Offset: 0x0001C40C
		// (remove) Token: 0x060008B0 RID: 2224 RVA: 0x0001E244 File Offset: 0x0001C444
		public event global::System.EventHandler<global::Infragistics.Controls.TapEventArgs> Tap;

		// Token: 0x060008B1 RID: 2225 RVA: 0x0001E279 File Offset: 0x0001C479
		protected virtual void OnTap(global::System.Windows.Point p, global::System.Windows.UIElement element)
		{
			if (this.Tap != null)
			{
				this.Tap(this.Element, new global::Infragistics.Controls.TapEventArgs(p, element));
			}
		}

		// Token: 0x1400001B RID: 27
		// (add) Token: 0x060008B2 RID: 2226 RVA: 0x0001E29C File Offset: 0x0001C49C
		// (remove) Token: 0x060008B3 RID: 2227 RVA: 0x0001E2D4 File Offset: 0x0001C4D4
		public event global::System.EventHandler<global::Infragistics.Controls.TapEventArgs> DoubleTap;

		// Token: 0x060008B4 RID: 2228 RVA: 0x0001E309 File Offset: 0x0001C509
		protected virtual void OnDoubleTap(global::System.Windows.Point p, global::System.Windows.UIElement element)
		{
			if (this.DoubleTap != null)
			{
				this.DoubleTap(this.Element, new global::Infragistics.Controls.TapEventArgs(p, element));
			}
		}

		// Token: 0x1400001C RID: 28
		// (add) Token: 0x060008B5 RID: 2229 RVA: 0x0001E32C File Offset: 0x0001C52C
		// (remove) Token: 0x060008B6 RID: 2230 RVA: 0x0001E364 File Offset: 0x0001C564
		public event global::System.EventHandler<global::Infragistics.Controls.TapEventArgs> TapAndHold;

		// Token: 0x060008B7 RID: 2231 RVA: 0x0001E399 File Offset: 0x0001C599
		protected virtual void OnTapAndHold(global::System.Windows.Point p, global::System.Windows.UIElement element)
		{
			if (this.TapAndHold != null)
			{
				this.TapAndHold(this.Element, new global::Infragistics.Controls.TapEventArgs(p, element));
			}
		}

		// Token: 0x1400001D RID: 29
		// (add) Token: 0x060008B8 RID: 2232 RVA: 0x0001E3BC File Offset: 0x0001C5BC
		// (remove) Token: 0x060008B9 RID: 2233 RVA: 0x0001E3F4 File Offset: 0x0001C5F4
		public event global::System.EventHandler<global::Infragistics.Controls.PanEventArgs> Pan;

		// Token: 0x060008BA RID: 2234 RVA: 0x0001E42C File Offset: 0x0001C62C
		protected virtual bool OnPan(global::System.Windows.Input.ManipulationDeltaEventArgs e)
		{
			if (this.Pan != null)
			{
				global::System.Windows.Point p = new global::System.Windows.Point(e.DeltaManipulation.Translation.X, e.DeltaManipulation.Translation.Y);
				global::Infragistics.Controls.PanEventArgs panEventArgs = new global::Infragistics.Controls.PanEventArgs(p);
				this.Pan(this.Element, panEventArgs);
				return panEventArgs.Handled;
			}
			return false;
		}

		// Token: 0x060008BB RID: 2235 RVA: 0x0001E490 File Offset: 0x0001C690
		protected virtual bool OnPan(global::System.Windows.Point p)
		{
			if (this.Pan != null)
			{
				global::Infragistics.Controls.PanEventArgs panEventArgs = new global::Infragistics.Controls.PanEventArgs(p);
				this.Pan(this.Element, panEventArgs);
				return panEventArgs.Handled;
			}
			return false;
		}

		// Token: 0x1400001E RID: 30
		// (add) Token: 0x060008BC RID: 2236 RVA: 0x0001E4C8 File Offset: 0x0001C6C8
		// (remove) Token: 0x060008BD RID: 2237 RVA: 0x0001E500 File Offset: 0x0001C700
		public event global::System.EventHandler<global::System.EventArgs> PanComplete;

		// Token: 0x060008BE RID: 2238 RVA: 0x0001E535 File Offset: 0x0001C735
		protected virtual void OnPanComplete()
		{
			if (this.PanComplete != null)
			{
				this.PanComplete(this.Element, global::System.EventArgs.Empty);
			}
		}

		// Token: 0x1400001F RID: 31
		// (add) Token: 0x060008BF RID: 2239 RVA: 0x0001E558 File Offset: 0x0001C758
		// (remove) Token: 0x060008C0 RID: 2240 RVA: 0x0001E590 File Offset: 0x0001C790
		public event global::System.EventHandler<global::Infragistics.Controls.StateChangedEventArgs> StateChanged;

		// Token: 0x060008C1 RID: 2241 RVA: 0x0001E5C5 File Offset: 0x0001C7C5
		protected virtual void OnStateChanged(global::Infragistics.Controls.TouchState newState, global::Infragistics.Controls.TouchState oldState)
		{
			if (this.StateChanged != null)
			{
				this.StateChanged(this.Element, new global::Infragistics.Controls.StateChangedEventArgs(newState, oldState));
			}
		}

		// Token: 0x04000420 RID: 1056
		protected const int TOUCH_MOVE_THRESHHOLD = 3;

		// Token: 0x04000421 RID: 1057
		protected const int DOUBLE_CLICK_TIME = 500;

		// Token: 0x04000422 RID: 1058
		protected const int TOUCH_HOLD_TIME = 400;

		// Token: 0x04000423 RID: 1059
		protected const double FLICK_DIRECTION_RATIO_THRESHHOLD = 4.0;

		// Token: 0x04000424 RID: 1060
		private global::Infragistics.Controls.IProvideTouchInfo _touchInfoProvider;

		// Token: 0x04000425 RID: 1061
		private global::Infragistics.Controls.TouchScrollMode _scrollMode;

		// Token: 0x04000426 RID: 1062
		private global::Infragistics.Controls.TouchState _currentState;

		// Token: 0x04000427 RID: 1063
		private global::System.Windows.UIElement _element;

		// Token: 0x04000428 RID: 1064
		internal static readonly global::System.Windows.DependencyPropertyKey TouchHelperPropertyKey = global::System.Windows.DependencyProperty.RegisterAttachedReadOnly("TouchHelper", typeof(global::Infragistics.Controls.TouchHelper), typeof(global::Infragistics.Controls.TouchHelperBase), new global::System.Windows.FrameworkPropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.TouchHelperBase.OnTouchHelperChanged)));

		// Token: 0x04000429 RID: 1065
		public static readonly global::System.Windows.DependencyProperty TouchHelperProperty = global::Infragistics.Controls.TouchHelperBase.TouchHelperPropertyKey.DependencyProperty;
	}
}
