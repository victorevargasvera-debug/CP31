using System;
using System.Windows;
using System.Windows.Media.Animation;

namespace Infragistics.Controls
{
	// Token: 0x020000D0 RID: 208
	internal class TouchScrollHelper : global::Infragistics.Controls.IProvideTouchInfo
	{
		// Token: 0x0600076A RID: 1898 RVA: 0x00019A2E File Offset: 0x00017C2E
		public TouchScrollHelper(global::System.Windows.FrameworkElement element, global::Infragistics.Controls.ISupportScrollHelper owner)
		{
			this._owner = owner;
			this._element = element;
			this._touchHandler = new global::Infragistics.Controls.TouchHelper(this);
			this.ReconnectEvents();
		}

		// Token: 0x17000145 RID: 325
		// (get) Token: 0x0600076B RID: 1899 RVA: 0x00019A5D File Offset: 0x00017C5D
		// (set) Token: 0x0600076C RID: 1900 RVA: 0x00019A65 File Offset: 0x00017C65
		public bool AnimateToIntegralItemOnEndPan
		{
			get
			{
				return this._animateToIntegralItemOnEndPan;
			}
			set
			{
				if (value != this._animateToIntegralItemOnEndPan)
				{
					this._animateToIntegralItemOnEndPan = value;
					if (!this._animateToIntegralItemOnEndPan)
					{
						this.StopPanningEndAnimation();
					}
				}
			}
		}

		// Token: 0x17000146 RID: 326
		// (get) Token: 0x0600076D RID: 1901 RVA: 0x00019A85 File Offset: 0x00017C85
		public global::Infragistics.Controls.TouchState CurrentState
		{
			get
			{
				return this._touchHandler.CurrentState;
			}
		}

		// Token: 0x17000147 RID: 327
		// (get) Token: 0x0600076E RID: 1902 RVA: 0x00019A92 File Offset: 0x00017C92
		// (set) Token: 0x0600076F RID: 1903 RVA: 0x00019A9A File Offset: 0x00017C9A
		public bool IsEnabled
		{
			get
			{
				return this._isEnabled;
			}
			set
			{
				if (value != this._isEnabled)
				{
					this._isEnabled = value;
					if (this._isEnabled)
					{
						this.ReconnectEvents();
						return;
					}
					this.DisconnectEvents();
				}
			}
		}

		// Token: 0x06000770 RID: 1904 RVA: 0x00019AC1 File Offset: 0x00017CC1
		public void CancelTouchInteraction()
		{
			if (this._touchHandler != null)
			{
				this._touchHandler.CancelTouchInteraction();
			}
		}

		// Token: 0x06000771 RID: 1905 RVA: 0x00019AD8 File Offset: 0x00017CD8
		private global::System.Windows.Media.Animation.Timeline CreateAnimation(int durationInMilliseconds, double fromValue, double toValue, global::System.Windows.Media.Animation.IEasingFunction easing)
		{
			return new global::System.Windows.Media.Animation.DoubleAnimation
			{
				Duration = global::System.TimeSpan.FromMilliseconds((double)durationInMilliseconds),
				AutoReverse = false,
				FillBehavior = global::System.Windows.Media.Animation.FillBehavior.Stop,
				From = new double?(fromValue),
				To = new double?(toValue),
				EasingFunction = easing
			};
		}

		// Token: 0x06000772 RID: 1906 RVA: 0x00019B2C File Offset: 0x00017D2C
		private global::Infragistics.Controls.TouchScrollHelper.DoubleValueAnimator CreatePanningEndAnimator(double fromValue, double toValue, double elementExtent)
		{
			int durationInMilliseconds = global::System.Math.Max(global::System.Math.Min((int)(global::System.Math.Abs(toValue - fromValue) * elementExtent * 4.0), 750), 200);
			return global::Infragistics.Controls.TouchScrollHelper.DoubleValueAnimator.Create(new global::System.Action<global::Infragistics.Controls.TouchScrollHelper.DoubleValueAnimator>(this.OnPanningEndAnimationValueChanged), new global::System.Action<global::Infragistics.Controls.TouchScrollHelper.DoubleValueAnimator>(this.OnPanningEndAnimationComplete), this.CreateAnimation(durationInMilliseconds, fromValue, toValue, new global::System.Windows.Media.Animation.QuadraticEase
			{
				EasingMode = global::System.Windows.Media.Animation.EasingMode.EaseOut
			}));
		}

		// Token: 0x06000773 RID: 1907 RVA: 0x00019B98 File Offset: 0x00017D98
		private void DisconnectEvents()
		{
			this._element.ClearValue(global::Infragistics.Controls.TouchHelperBase.TouchHelperProperty);
			if (this._touchHandler != null)
			{
				this._touchHandler.TouchStarted -= new global::System.EventHandler<global::Infragistics.Controls.TapEventArgs>(this.TouchHandler_TouchStarted);
				this._touchHandler.Pan -= this.TouchHandler_Pan;
				this._touchHandler.TouchCompleted -= new global::System.EventHandler<global::Infragistics.Controls.TapEventArgs>(this.TouchHandler_TouchCompleted);
				this._touchHandler.PanComplete -= this.TouchHandler_PanComplete;
				this._touchHandler.StateChanged -= this.TouchHandler_StateChanged;
			}
		}

		// Token: 0x06000774 RID: 1908 RVA: 0x00019C30 File Offset: 0x00017E30
		private void OnPanningEndAnimationValueChanged(global::Infragistics.Controls.TouchScrollHelper.DoubleValueAnimator animator)
		{
			if (animator == this._panningEndAnimatorX)
			{
				this._owner.HorizontalValue = animator.Value;
				this._owner.InvalidateScrollLayout();
				return;
			}
			if (animator == this._panningEndAnimatorY)
			{
				this._owner.VerticalValue = animator.Value;
				this._owner.InvalidateScrollLayout();
			}
		}

		// Token: 0x06000775 RID: 1909 RVA: 0x00019C88 File Offset: 0x00017E88
		private void OnPanningEndAnimationComplete(global::Infragistics.Controls.TouchScrollHelper.DoubleValueAnimator animator)
		{
			bool flag = false;
			if (animator == this._panningEndAnimatorX)
			{
				this._owner.HorizontalValue = global::Infragistics.CoreUtilities.RoundToIntegralValue(this._owner.HorizontalValue);
				this._panningEndAnimatorX = null;
				flag = (this._panningEndAnimatorY == null);
			}
			else if (animator == this._panningEndAnimatorY)
			{
				this._owner.VerticalValue = global::Infragistics.CoreUtilities.RoundToIntegralValue(this._owner.VerticalValue);
				this._panningEndAnimatorY = null;
				flag = (this._panningEndAnimatorX == null);
			}
			if (flag && this._owner != null)
			{
				this._owner.OnPanComplete();
			}
		}

		// Token: 0x06000776 RID: 1910 RVA: 0x00019D1C File Offset: 0x00017F1C
		private void ReconnectEvents()
		{
			this.DisconnectEvents();
			global::Infragistics.Controls.TouchHelperBase.SetTouchHelper(this._element, this._touchHandler);
			if (this._touchHandler != null)
			{
				this._touchHandler.TouchStarted += new global::System.EventHandler<global::Infragistics.Controls.TapEventArgs>(this.TouchHandler_TouchStarted);
				this._touchHandler.Pan += this.TouchHandler_Pan;
				this._touchHandler.TouchCompleted += new global::System.EventHandler<global::Infragistics.Controls.TapEventArgs>(this.TouchHandler_TouchCompleted);
				this._touchHandler.PanComplete += this.TouchHandler_PanComplete;
				this._touchHandler.StateChanged += this.TouchHandler_StateChanged;
			}
		}

		// Token: 0x06000777 RID: 1911 RVA: 0x00019DBB File Offset: 0x00017FBB
		private void StopPanningEndAnimation()
		{
			this._panningEndAnimatorY = null;
			this._panningEndAnimatorY = null;
		}

		// Token: 0x06000778 RID: 1912 RVA: 0x00019DCB File Offset: 0x00017FCB
		private void TouchHandler_TouchStarted(object sender, global::System.EventArgs e)
		{
			this.OnTouchStarted();
		}

		// Token: 0x06000779 RID: 1913 RVA: 0x00019DD4 File Offset: 0x00017FD4
		private void TouchHandler_Pan(object sender, global::Infragistics.Controls.PanEventArgs e)
		{
			this.StopPanningEndAnimation();
			bool flag = false;
			global::System.Windows.Point deltaPoint = e.DeltaPoint;
			double verticalMax = this._owner.VerticalMax;
			if (verticalMax > 0.0)
			{
				double num = deltaPoint.Y;
				if (this._owner.VerticalScrollType == global::Infragistics.Controls.ScrollType.Item)
				{
					double firstItemHeight = this._owner.GetFirstItemHeight();
					num /= firstItemHeight;
				}
				if (num != 0.0)
				{
					flag = true;
					if (num < 0.0)
					{
						this._owner.VerticalValue = global::System.Math.Min(verticalMax, this._owner.VerticalValue - num);
					}
					else
					{
						this._owner.VerticalValue = global::System.Math.Max(0.0, this._owner.VerticalValue - num);
					}
				}
			}
			double horizontalMax = this._owner.HorizontalMax;
			if (horizontalMax > 0.0)
			{
				double num2 = deltaPoint.X;
				if (this._owner.HorizontalScrollType == global::Infragistics.Controls.ScrollType.Item)
				{
					double firstItemWidth = this._owner.GetFirstItemWidth();
					num2 /= firstItemWidth;
				}
				if (num2 != 0.0)
				{
					flag = true;
					if (num2 < 0.0)
					{
						this._owner.HorizontalValue = global::System.Math.Min(horizontalMax, this._owner.HorizontalValue - num2);
					}
					else
					{
						this._owner.HorizontalValue = global::System.Math.Max(0.0, this._owner.HorizontalValue - num2);
					}
				}
			}
			if (flag)
			{
				this._owner.InvalidateScrollLayout();
			}
			e.Handled = true;
		}

		// Token: 0x0600077A RID: 1914 RVA: 0x00019F55 File Offset: 0x00018155
		private void TouchHandler_StateChanged(object sender, global::Infragistics.Controls.StateChangedEventArgs e)
		{
			if (this._owner != null)
			{
				this._owner.OnStateChanged(e.NewState, e.OldState);
			}
		}

		// Token: 0x0600077B RID: 1915 RVA: 0x00019F76 File Offset: 0x00018176
		private void TouchHandler_TouchCompleted(object sender, global::System.EventArgs e)
		{
			this.OnTouchCompleted();
		}

		// Token: 0x0600077C RID: 1916 RVA: 0x00019F7E File Offset: 0x0001817E
		private void TouchHandler_PanComplete(object sender, global::System.EventArgs e)
		{
			this.ProcessPanComplete();
		}

		// Token: 0x0600077D RID: 1917 RVA: 0x00019F88 File Offset: 0x00018188
		private void ProcessPanComplete()
		{
			this.StopPanningEndAnimation();
			if (this._owner == null)
			{
				return;
			}
			if (!this.AnimateToIntegralItemOnEndPan)
			{
				this._owner.OnPanComplete();
				return;
			}
			if (this._owner.VerticalScrollType == global::Infragistics.Controls.ScrollType.Item)
			{
				double firstItemHeight = this._owner.GetFirstItemHeight();
				double verticalValue = this._owner.VerticalValue;
				double num = global::Infragistics.CoreUtilities.RoundToIntegralValue(verticalValue);
				double value = firstItemHeight * (verticalValue - num);
				if (global::System.Math.Abs(value) > 5.0)
				{
					this._panningEndAnimatorY = this.CreatePanningEndAnimator(verticalValue, num, firstItemHeight);
				}
				else
				{
					this._owner.VerticalValue = num;
				}
			}
			if (this._owner.HorizontalScrollType == global::Infragistics.Controls.ScrollType.Item)
			{
				double firstItemWidth = this._owner.GetFirstItemWidth();
				double horizontalValue = this._owner.HorizontalValue;
				double num2 = global::Infragistics.CoreUtilities.RoundToIntegralValue(horizontalValue);
				double value2 = firstItemWidth * (horizontalValue - num2);
				if (global::System.Math.Abs(value2) > 5.0)
				{
					this._panningEndAnimatorX = this.CreatePanningEndAnimator(horizontalValue, num2, firstItemWidth);
				}
				else
				{
					this._owner.HorizontalValue = num2;
				}
			}
			if (this._panningEndAnimatorX == null && this._panningEndAnimatorY == null)
			{
				this._owner.OnPanComplete();
			}
		}

		// Token: 0x14000014 RID: 20
		// (add) Token: 0x0600077E RID: 1918 RVA: 0x0001A0A4 File Offset: 0x000182A4
		// (remove) Token: 0x0600077F RID: 1919 RVA: 0x0001A0DC File Offset: 0x000182DC
		public event global::System.EventHandler<global::System.EventArgs> TouchStarted;

		// Token: 0x06000780 RID: 1920 RVA: 0x0001A111 File Offset: 0x00018311
		protected virtual void OnTouchStarted()
		{
			if (this.TouchStarted != null)
			{
				this.TouchStarted(this._element, global::System.EventArgs.Empty);
			}
		}

		// Token: 0x14000015 RID: 21
		// (add) Token: 0x06000781 RID: 1921 RVA: 0x0001A134 File Offset: 0x00018334
		// (remove) Token: 0x06000782 RID: 1922 RVA: 0x0001A16C File Offset: 0x0001836C
		public event global::System.EventHandler<global::System.EventArgs> TouchCompleted;

		// Token: 0x06000783 RID: 1923 RVA: 0x0001A1A1 File Offset: 0x000183A1
		protected virtual void OnTouchCompleted()
		{
			if (this.TouchCompleted != null)
			{
				this.TouchCompleted(this._element, global::System.EventArgs.Empty);
			}
		}

		// Token: 0x06000784 RID: 1924 RVA: 0x0001A1C1 File Offset: 0x000183C1
		global::Infragistics.Controls.TouchScrollMode global::Infragistics.Controls.IProvideTouchInfo.GetScrollModeFromPoint(global::System.Windows.Point point, global::System.Windows.UIElement elementDirectlyOver)
		{
			if (this._owner != null)
			{
				return this._owner.GetScrollModeFromPoint(point, elementDirectlyOver);
			}
			return global::Infragistics.Controls.TouchScrollMode.None;
		}

		// Token: 0x0400034F RID: 847
		private const double VELOCITY_EXTENT_FACTOR = 2.0;

		// Token: 0x04000350 RID: 848
		private global::Infragistics.Controls.ISupportScrollHelper _owner;

		// Token: 0x04000351 RID: 849
		private global::System.Windows.FrameworkElement _element;

		// Token: 0x04000352 RID: 850
		private bool _animateToIntegralItemOnEndPan;

		// Token: 0x04000353 RID: 851
		private global::Infragistics.Controls.TouchScrollHelper.DoubleValueAnimator _panningEndAnimatorX;

		// Token: 0x04000354 RID: 852
		private global::Infragistics.Controls.TouchScrollHelper.DoubleValueAnimator _panningEndAnimatorY;

		// Token: 0x04000355 RID: 853
		private bool _isEnabled = true;

		// Token: 0x04000356 RID: 854
		private global::Infragistics.Controls.TouchHelper _touchHandler;

		// Token: 0x020000D1 RID: 209
		private class DoubleValueAnimator : global::System.Windows.DependencyObject
		{
			// Token: 0x06000785 RID: 1925 RVA: 0x0001A1DA File Offset: 0x000183DA
			private DoubleValueAnimator(global::System.Windows.Media.Animation.Timeline animation)
			{
				this._animation = animation;
			}

			// Token: 0x06000786 RID: 1926 RVA: 0x0001A1EC File Offset: 0x000183EC
			internal static global::Infragistics.Controls.TouchScrollHelper.DoubleValueAnimator Create(global::System.Action<global::Infragistics.Controls.TouchScrollHelper.DoubleValueAnimator> onChangedAction, global::System.Action<global::Infragistics.Controls.TouchScrollHelper.DoubleValueAnimator> onAnimationCompleteAction, global::System.Windows.Media.Animation.Timeline animation)
			{
				global::Infragistics.Controls.TouchScrollHelper.DoubleValueAnimator doubleValueAnimator = new global::Infragistics.Controls.TouchScrollHelper.DoubleValueAnimator(animation);
				doubleValueAnimator.Initialize(onChangedAction, onAnimationCompleteAction);
				return doubleValueAnimator;
			}

			// Token: 0x06000787 RID: 1927 RVA: 0x0001A20C File Offset: 0x0001840C
			private static void OnValueChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
			{
				global::Infragistics.Controls.TouchScrollHelper.DoubleValueAnimator doubleValueAnimator = (global::Infragistics.Controls.TouchScrollHelper.DoubleValueAnimator)d;
				if (doubleValueAnimator._onChangedAction != null && !double.IsNaN((double)e.NewValue))
				{
					doubleValueAnimator._onChangedAction(doubleValueAnimator);
				}
			}

			// Token: 0x17000148 RID: 328
			// (get) Token: 0x06000788 RID: 1928 RVA: 0x0001A247 File Offset: 0x00018447
			// (set) Token: 0x06000789 RID: 1929 RVA: 0x0001A259 File Offset: 0x00018459
			public double Value
			{
				get
				{
					return (double)base.GetValue(global::Infragistics.Controls.TouchScrollHelper.DoubleValueAnimator.ValueProperty);
				}
				set
				{
					base.SetValue(global::Infragistics.Controls.TouchScrollHelper.DoubleValueAnimator.ValueProperty, value);
				}
			}

			// Token: 0x0600078A RID: 1930 RVA: 0x0001A26C File Offset: 0x0001846C
			private void Initialize(global::System.Action<global::Infragistics.Controls.TouchScrollHelper.DoubleValueAnimator> onChangedAction, global::System.Action<global::Infragistics.Controls.TouchScrollHelper.DoubleValueAnimator> onAnimationCompleteAction)
			{
				this._onAnimatedCompleteAction = onAnimationCompleteAction;
				if (this._animation != null)
				{
					if (!(this._animation is global::System.Windows.Media.Animation.DoubleAnimation) && !(this._animation is global::System.Windows.Media.Animation.DoubleAnimationUsingKeyFrames))
					{
						throw new global::System.ArgumentException("animation must be DoubleAnimation or DoubleAnimationUsingKeyFrames");
					}
					this._storyboard = new global::System.Windows.Media.Animation.Storyboard();
					this._storyboard.Completed += this.OnStoryboardCompleted;
					this._storyboard.FillBehavior = global::System.Windows.Media.Animation.FillBehavior.Stop;
					global::System.Windows.Media.Animation.Storyboard.SetTargetProperty(this._animation, new global::System.Windows.PropertyPath(global::Infragistics.Controls.TouchScrollHelper.DoubleValueAnimator.ValueProperty));
					this._storyboard.Children.Add(this._animation);
					global::System.Windows.Media.Animation.Storyboard.SetTarget(this._animation, this);
					this._storyboard.Begin();
				}
				this._onChangedAction = onChangedAction;
			}

			// Token: 0x0600078B RID: 1931 RVA: 0x0001A327 File Offset: 0x00018527
			private void OnStoryboardCompleted(object sender, global::System.EventArgs e)
			{
				this._onChangedAction = null;
				if (this._onAnimatedCompleteAction != null)
				{
					this._onAnimatedCompleteAction(this);
					this._onAnimatedCompleteAction = null;
				}
			}

			// Token: 0x04000359 RID: 857
			private global::System.Action<global::Infragistics.Controls.TouchScrollHelper.DoubleValueAnimator> _onChangedAction;

			// Token: 0x0400035A RID: 858
			private global::System.Action<global::Infragistics.Controls.TouchScrollHelper.DoubleValueAnimator> _onAnimatedCompleteAction;

			// Token: 0x0400035B RID: 859
			private global::System.Windows.Media.Animation.Timeline _animation;

			// Token: 0x0400035C RID: 860
			private global::System.Windows.Media.Animation.Storyboard _storyboard;

			// Token: 0x0400035D RID: 861
			public static readonly global::System.Windows.DependencyProperty ValueProperty = global::Infragistics.DependencyPropertyUtilities.Register("Value", typeof(double), typeof(global::Infragistics.Controls.TouchScrollHelper.DoubleValueAnimator), global::Infragistics.DependencyPropertyUtilities.CreateMetadata(double.NaN, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.TouchScrollHelper.DoubleValueAnimator.OnValueChanged)));
		}
	}
}
