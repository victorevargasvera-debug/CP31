using System;
using System.Windows;
using System.Windows.Input;

namespace Infragistics.Controls
{
	// Token: 0x020000D8 RID: 216
	internal abstract class TouchHelperBase : global::System.Windows.DependencyObject
	{
		// Token: 0x0600079D RID: 1949 RVA: 0x0001A444 File Offset: 0x00018644
		protected TouchHelperBase(global::Infragistics.Controls.IProvideTouchInfo touchInfoProvider)
		{
			this._touchInfoProvider = touchInfoProvider;
		}

		// Token: 0x1700014F RID: 335
		// (get) Token: 0x0600079E RID: 1950 RVA: 0x0001A453 File Offset: 0x00018653
		// (set) Token: 0x0600079F RID: 1951 RVA: 0x0001A45C File Offset: 0x0001865C
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

		// Token: 0x17000150 RID: 336
		// (get) Token: 0x060007A0 RID: 1952 RVA: 0x0001A48D File Offset: 0x0001868D
		public global::System.Windows.UIElement Element
		{
			get
			{
				return this._element;
			}
		}

		// Token: 0x17000151 RID: 337
		// (get) Token: 0x060007A1 RID: 1953 RVA: 0x0001A495 File Offset: 0x00018695
		internal global::Infragistics.Controls.TouchScrollMode ScrollMode
		{
			get
			{
				return this._scrollMode;
			}
		}

		// Token: 0x17000152 RID: 338
		// (get) Token: 0x060007A2 RID: 1954 RVA: 0x0001A49D File Offset: 0x0001869D
		internal global::Infragistics.Controls.IProvideTouchInfo TouchInfoProvider
		{
			get
			{
				return this._touchInfoProvider;
			}
		}

		// Token: 0x060007A3 RID: 1955 RVA: 0x0001A4A5 File Offset: 0x000186A5
		public static global::Infragistics.Controls.TouchHelper GetTouchHelper(global::System.Windows.UIElement element)
		{
			return (global::Infragistics.Controls.TouchHelper)element.GetValue(global::Infragistics.Controls.TouchHelperBase.TouchHelperProperty);
		}

		// Token: 0x060007A4 RID: 1956 RVA: 0x0001A4B7 File Offset: 0x000186B7
		public static void SetTouchHelper(global::System.Windows.UIElement element, global::Infragistics.Controls.TouchHelper helper)
		{
			element.SetValue(global::Infragistics.Controls.TouchHelperBase.TouchHelperProperty, helper);
		}

		// Token: 0x060007A5 RID: 1957 RVA: 0x0001A4C8 File Offset: 0x000186C8
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

		// Token: 0x060007A6 RID: 1958 RVA: 0x0001A516 File Offset: 0x00018716
		protected internal virtual void CancelTouchInteraction()
		{
		}

		// Token: 0x060007A7 RID: 1959
		protected abstract void OnAttached();

		// Token: 0x060007A8 RID: 1960
		protected abstract void OnDetached();

		// Token: 0x060007A9 RID: 1961 RVA: 0x0001A518 File Offset: 0x00018718
		internal void SetScrollModeFromPoint(global::System.Windows.Point point, global::System.Windows.UIElement elementDirectlyOver)
		{
			if (this._touchInfoProvider == null)
			{
				this._scrollMode = global::Infragistics.Controls.TouchScrollMode.Both;
				return;
			}
			this._scrollMode = this._touchInfoProvider.GetScrollModeFromPoint(point, elementDirectlyOver);
		}

		// Token: 0x14000016 RID: 22
		// (add) Token: 0x060007AA RID: 1962 RVA: 0x0001A540 File Offset: 0x00018740
		// (remove) Token: 0x060007AB RID: 1963 RVA: 0x0001A578 File Offset: 0x00018778
		public event global::System.EventHandler<global::Infragistics.Controls.TapEventArgs> TouchStarted;

		// Token: 0x060007AC RID: 1964 RVA: 0x0001A5AD File Offset: 0x000187AD
		protected virtual void OnTouchStarted(global::System.Windows.Point p, global::System.Windows.UIElement element)
		{
			if (this.TouchStarted != null)
			{
				this.TouchStarted(this.Element, new global::Infragistics.Controls.TapEventArgs(p, element));
			}
		}

		// Token: 0x14000017 RID: 23
		// (add) Token: 0x060007AD RID: 1965 RVA: 0x0001A5D0 File Offset: 0x000187D0
		// (remove) Token: 0x060007AE RID: 1966 RVA: 0x0001A608 File Offset: 0x00018808
		public event global::System.EventHandler<global::Infragistics.Controls.TapEventArgs> TouchCompleted;

		// Token: 0x060007AF RID: 1967 RVA: 0x0001A63D File Offset: 0x0001883D
		protected virtual void OnTouchCompleted(global::System.Windows.Point p, global::System.Windows.UIElement element)
		{
			if (this.TouchCompleted != null)
			{
				this.TouchCompleted(this.Element, new global::Infragistics.Controls.TapEventArgs(p, element));
			}
		}

		// Token: 0x14000018 RID: 24
		// (add) Token: 0x060007B0 RID: 1968 RVA: 0x0001A660 File Offset: 0x00018860
		// (remove) Token: 0x060007B1 RID: 1969 RVA: 0x0001A698 File Offset: 0x00018898
		public event global::System.EventHandler<global::Infragistics.Controls.TapEventArgs> Tap;

		// Token: 0x060007B2 RID: 1970 RVA: 0x0001A6CD File Offset: 0x000188CD
		protected virtual void OnTap(global::System.Windows.Point p, global::System.Windows.UIElement element)
		{
			if (this.Tap != null)
			{
				this.Tap(this.Element, new global::Infragistics.Controls.TapEventArgs(p, element));
			}
		}

		// Token: 0x14000019 RID: 25
		// (add) Token: 0x060007B3 RID: 1971 RVA: 0x0001A6F0 File Offset: 0x000188F0
		// (remove) Token: 0x060007B4 RID: 1972 RVA: 0x0001A728 File Offset: 0x00018928
		public event global::System.EventHandler<global::Infragistics.Controls.TapEventArgs> DoubleTap;

		// Token: 0x060007B5 RID: 1973 RVA: 0x0001A75D File Offset: 0x0001895D
		protected virtual void OnDoubleTap(global::System.Windows.Point p, global::System.Windows.UIElement element)
		{
			if (this.DoubleTap != null)
			{
				this.DoubleTap(this.Element, new global::Infragistics.Controls.TapEventArgs(p, element));
			}
		}

		// Token: 0x1400001A RID: 26
		// (add) Token: 0x060007B6 RID: 1974 RVA: 0x0001A780 File Offset: 0x00018980
		// (remove) Token: 0x060007B7 RID: 1975 RVA: 0x0001A7B8 File Offset: 0x000189B8
		public event global::System.EventHandler<global::Infragistics.Controls.TapEventArgs> TapAndHold;

		// Token: 0x060007B8 RID: 1976 RVA: 0x0001A7ED File Offset: 0x000189ED
		protected virtual void OnTapAndHold(global::System.Windows.Point p, global::System.Windows.UIElement element)
		{
			if (this.TapAndHold != null)
			{
				this.TapAndHold(this.Element, new global::Infragistics.Controls.TapEventArgs(p, element));
			}
		}

		// Token: 0x1400001B RID: 27
		// (add) Token: 0x060007B9 RID: 1977 RVA: 0x0001A810 File Offset: 0x00018A10
		// (remove) Token: 0x060007BA RID: 1978 RVA: 0x0001A848 File Offset: 0x00018A48
		public event global::System.EventHandler<global::Infragistics.Controls.PanEventArgs> Pan;

		// Token: 0x060007BB RID: 1979 RVA: 0x0001A880 File Offset: 0x00018A80
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

		// Token: 0x060007BC RID: 1980 RVA: 0x0001A8E4 File Offset: 0x00018AE4
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

		// Token: 0x1400001C RID: 28
		// (add) Token: 0x060007BD RID: 1981 RVA: 0x0001A91C File Offset: 0x00018B1C
		// (remove) Token: 0x060007BE RID: 1982 RVA: 0x0001A954 File Offset: 0x00018B54
		public event global::System.EventHandler<global::System.EventArgs> PanComplete;

		// Token: 0x060007BF RID: 1983 RVA: 0x0001A989 File Offset: 0x00018B89
		protected virtual void OnPanComplete()
		{
			if (this.PanComplete != null)
			{
				this.PanComplete(this.Element, global::System.EventArgs.Empty);
			}
		}

		// Token: 0x1400001D RID: 29
		// (add) Token: 0x060007C0 RID: 1984 RVA: 0x0001A9AC File Offset: 0x00018BAC
		// (remove) Token: 0x060007C1 RID: 1985 RVA: 0x0001A9E4 File Offset: 0x00018BE4
		public event global::System.EventHandler<global::Infragistics.Controls.StateChangedEventArgs> StateChanged;

		// Token: 0x060007C2 RID: 1986 RVA: 0x0001AA19 File Offset: 0x00018C19
		protected virtual void OnStateChanged(global::Infragistics.Controls.TouchState newState, global::Infragistics.Controls.TouchState oldState)
		{
			if (this.StateChanged != null)
			{
				this.StateChanged(this.Element, new global::Infragistics.Controls.StateChangedEventArgs(newState, oldState));
			}
		}

		// Token: 0x0400036E RID: 878
		protected const int TOUCH_MOVE_THRESHHOLD = 3;

		// Token: 0x0400036F RID: 879
		protected const int DOUBLE_CLICK_TIME = 500;

		// Token: 0x04000370 RID: 880
		protected const int TOUCH_HOLD_TIME = 400;

		// Token: 0x04000371 RID: 881
		protected const double FLICK_DIRECTION_RATIO_THRESHHOLD = 4.0;

		// Token: 0x04000372 RID: 882
		private global::Infragistics.Controls.IProvideTouchInfo _touchInfoProvider;

		// Token: 0x04000373 RID: 883
		private global::Infragistics.Controls.TouchScrollMode _scrollMode;

		// Token: 0x04000374 RID: 884
		private global::Infragistics.Controls.TouchState _currentState;

		// Token: 0x04000375 RID: 885
		private global::System.Windows.UIElement _element;

		// Token: 0x04000376 RID: 886
		public static readonly global::System.Windows.DependencyProperty TouchHelperProperty = global::System.Windows.DependencyProperty.RegisterAttached("TouchHelper", typeof(global::Infragistics.Controls.TouchHelperBase), typeof(global::Infragistics.Controls.TouchHelperBase), new global::System.Windows.PropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.TouchHelperBase.OnTouchHelperChanged)));
	}
}
