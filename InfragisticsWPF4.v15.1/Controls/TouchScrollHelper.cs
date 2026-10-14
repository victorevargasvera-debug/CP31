using System;
using System.Windows;
using System.Windows.Media.Animation;

namespace Infragistics.Controls
{
	// Token: 0x020000EE RID: 238
	internal class TouchScrollHelper : global::Infragistics.Controls.IProvideTouchInfo
	{
		// Token: 0x06000869 RID: 2153 RVA: 0x0001D5DA File Offset: 0x0001B7DA
		public TouchScrollHelper(global::System.Windows.FrameworkElement element, global::Infragistics.Controls.ISupportScrollHelper owner)
		{
			this._owner = owner;
			this._element = element;
			this._touchHandler = new global::Infragistics.Controls.TouchHelper(this);
			this.ReconnectEvents();
		}

		// Token: 0x1700015D RID: 349
		// (get) Token: 0x0600086A RID: 2154 RVA: 0x0001D609 File Offset: 0x0001B809
		// (set) Token: 0x0600086B RID: 2155 RVA: 0x0001D611 File Offset: 0x0001B811
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

		// Token: 0x1700015E RID: 350
		// (get) Token: 0x0600086C RID: 2156 RVA: 0x0001D631 File Offset: 0x0001B831
		public global::Infragistics.Controls.TouchState CurrentState
		{
			get
			{
				return this._touchHandler.CurrentState;
			}
		}

		// Token: 0x1700015F RID: 351
		// (get) Token: 0x0600086D RID: 2157 RVA: 0x0001D63E File Offset: 0x0001B83E
		// (set) Token: 0x0600086E RID: 2158 RVA: 0x0001D646 File Offset: 0x0001B846
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

		// Token: 0x0600086F RID: 2159 RVA: 0x0001D66D File Offset: 0x0001B86D
		public void CancelTouchInteraction()
		{
			if (this._touchHandler != null)
			{
				this._touchHandler.CancelTouchInteraction();
			}
		}

		// Token: 0x06000870 RID: 2160 RVA: 0x0001D684 File Offset: 0x0001B884
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

		// Token: 0x06000871 RID: 2161 RVA: 0x0001D6D8 File Offset: 0x0001B8D8
		private global::Infragistics.Controls.TouchScrollHelper.DoubleValueAnimator CreatePanningEndAnimator(double fromValue, double toValue, double elementExtent)
		{
			int durationInMilliseconds = global::System.Math.Max(global::System.Math.Min((int)(global::System.Math.Abs(toValue - fromValue) * elementExtent * 4.0), 750), 200);
			return global::Infragistics.Controls.TouchScrollHelper.DoubleValueAnimator.Create(new global::System.Action<global::Infragistics.Controls.TouchScrollHelper.DoubleValueAnimator>(this.OnPanningEndAnimationValueChanged), new global::System.Action<global::Infragistics.Controls.TouchScrollHelper.DoubleValueAnimator>(this.OnPanningEndAnimationComplete), this.CreateAnimation(durationInMilliseconds, fromValue, toValue, new global::System.Windows.Media.Animation.QuadraticEase
			{
				EasingMode = global::System.Windows.Media.Animation.EasingMode.EaseOut
			}));
		}

		// Token: 0x06000872 RID: 2162 RVA: 0x0001D744 File Offset: 0x0001B944
		private void DisconnectEvents()
		{
			this._element.ClearValue(global::Infragistics.Controls.TouchHelperBase.TouchHelperPropertyKey);
			if (this._touchHandler != null)
			{
				this._touchHandler.TouchStarted -= new global::System.EventHandler<global::Infragistics.Controls.TapEventArgs>(this.TouchHandler_TouchStarted);
				this._touchHandler.Pan -= this.TouchHandler_Pan;
				this._touchHandler.TouchCompleted -= new global::System.EventHandler<global::Infragistics.Controls.TapEventArgs>(this.TouchHandler_TouchCompleted);
				this._touchHandler.PanComplete -= this.TouchHandler_PanComplete;
				this._touchHandler.StateChanged -= this.TouchHandler_StateChanged;
			}
		}

		// Token: 0x06000873 RID: 2163 RVA: 0x0001D7DC File Offset: 0x0001B9DC
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

		// Token: 0x06000874 RID: 2164 RVA: 0x0001D834 File Offset: 0x0001BA34
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

		// Token: 0x06000875 RID: 2165 RVA: 0x0001D8C8 File Offset: 0x0001BAC8
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

		// Token: 0x06000876 RID: 2166 RVA: 0x0001D967 File Offset: 0x0001BB67
		private void StopPanningEndAnimation()
		{
			this._panningEndAnimatorY = null;
			this._panningEndAnimatorY = null;
		}

		// Token: 0x06000877 RID: 2167 RVA: 0x0001D977 File Offset: 0x0001BB77
		private void TouchHandler_TouchStarted(object sender, global::System.EventArgs e)
		{
			this.OnTouchStarted();
		}

		// Token: 0x06000878 RID: 2168 RVA: 0x0001D980 File Offset: 0x0001BB80
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

		// Token: 0x06000879 RID: 2169 RVA: 0x0001DB01 File Offset: 0x0001BD01
		private void TouchHandler_StateChanged(object sender, global::Infragistics.Controls.StateChangedEventArgs e)
		{
			if (this._owner != null)
			{
				this._owner.OnStateChanged(e.NewState, e.OldState);
			}
		}

		// Token: 0x0600087A RID: 2170 RVA: 0x0001DB22 File Offset: 0x0001BD22
		private void TouchHandler_TouchCompleted(object sender, global::System.EventArgs e)
		{
			this.OnTouchCompleted();
		}

		// Token: 0x0600087B RID: 2171 RVA: 0x0001DB2A File Offset: 0x0001BD2A
		private void TouchHandler_PanComplete(object sender, global::System.EventArgs e)
		{
			this.ProcessPanComplete();
		}

		// Token: 0x0600087C RID: 2172 RVA: 0x0001DB34 File Offset: 0x0001BD34
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

		// Token: 0x14000016 RID: 22
		// (add) Token: 0x0600087D RID: 2173 RVA: 0x0001DC50 File Offset: 0x0001BE50
		// (remove) Token: 0x0600087E RID: 2174 RVA: 0x0001DC88 File Offset: 0x0001BE88
		public event global::System.EventHandler<global::System.EventArgs> TouchStarted;

		// Token: 0x0600087F RID: 2175 RVA: 0x0001DCBD File Offset: 0x0001BEBD
		protected virtual void OnTouchStarted()
		{
			if (this.TouchStarted != null)
			{
				this.TouchStarted(this._element, global::System.EventArgs.Empty);
			}
		}

		// Token: 0x14000017 RID: 23
		// (add) Token: 0x06000880 RID: 2176 RVA: 0x0001DCE0 File Offset: 0x0001BEE0
		// (remove) Token: 0x06000881 RID: 2177 RVA: 0x0001DD18 File Offset: 0x0001BF18
		public event global::System.EventHandler<global::System.EventArgs> TouchCompleted;

		// Token: 0x06000882 RID: 2178 RVA: 0x0001DD4D File Offset: 0x0001BF4D
		protected virtual void OnTouchCompleted()
		{
			if (this.TouchCompleted != null)
			{
				this.TouchCompleted(this._element, global::System.EventArgs.Empty);
			}
		}

		// Token: 0x06000883 RID: 2179 RVA: 0x0001DD6D File Offset: 0x0001BF6D
		global::Infragistics.Controls.TouchScrollMode global::Infragistics.Controls.IProvideTouchInfo.GetScrollModeFromPoint(global::System.Windows.Point point, global::System.Windows.UIElement elementDirectlyOver)
		{
			if (this._owner != null)
			{
				return this._owner.GetScrollModeFromPoint(point, elementDirectlyOver);
			}
			return global::Infragistics.Controls.TouchScrollMode.None;
		}

		// Token: 0x04000401 RID: 1025
		private const double VELOCITY_EXTENT_FACTOR = 2.0;

		// Token: 0x04000402 RID: 1026
		private global::Infragistics.Controls.ISupportScrollHelper _owner;

		// Token: 0x04000403 RID: 1027
		private global::System.Windows.FrameworkElement _element;

		// Token: 0x04000404 RID: 1028
		private bool _animateToIntegralItemOnEndPan;

		// Token: 0x04000405 RID: 1029
		private global::Infragistics.Controls.TouchScrollHelper.DoubleValueAnimator _panningEndAnimatorX;

		// Token: 0x04000406 RID: 1030
		private global::Infragistics.Controls.TouchScrollHelper.DoubleValueAnimator _panningEndAnimatorY;

		// Token: 0x04000407 RID: 1031
		private bool _isEnabled = true;

		// Token: 0x04000408 RID: 1032
		private global::Infragistics.Controls.TouchHelper _touchHandler;

		// Token: 0x020000EF RID: 239
		private class DoubleValueAnimator : global::System.Windows.DependencyObject
		{
			// Token: 0x06000884 RID: 2180 RVA: 0x0001DD86 File Offset: 0x0001BF86
			private DoubleValueAnimator(global::System.Windows.Media.Animation.Timeline animation)
			{
				this._animation = animation;
			}

			// Token: 0x06000885 RID: 2181 RVA: 0x0001DD98 File Offset: 0x0001BF98
			internal static global::Infragistics.Controls.TouchScrollHelper.DoubleValueAnimator Create(global::System.Action<global::Infragistics.Controls.TouchScrollHelper.DoubleValueAnimator> onChangedAction, global::System.Action<global::Infragistics.Controls.TouchScrollHelper.DoubleValueAnimator> onAnimationCompleteAction, global::System.Windows.Media.Animation.Timeline animation)
			{
				global::Infragistics.Controls.TouchScrollHelper.DoubleValueAnimator doubleValueAnimator = new global::Infragistics.Controls.TouchScrollHelper.DoubleValueAnimator(animation);
				doubleValueAnimator.Initialize(onChangedAction, onAnimationCompleteAction);
				return doubleValueAnimator;
			}

			// Token: 0x06000886 RID: 2182 RVA: 0x0001DDB8 File Offset: 0x0001BFB8
			private static void OnValueChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
			{
				global::Infragistics.Controls.TouchScrollHelper.DoubleValueAnimator doubleValueAnimator = (global::Infragistics.Controls.TouchScrollHelper.DoubleValueAnimator)d;
				if (doubleValueAnimator._onChangedAction != null && !double.IsNaN((double)e.NewValue))
				{
					doubleValueAnimator._onChangedAction(doubleValueAnimator);
				}
			}

			// Token: 0x17000160 RID: 352
			// (get) Token: 0x06000887 RID: 2183 RVA: 0x0001DDF3 File Offset: 0x0001BFF3
			// (set) Token: 0x06000888 RID: 2184 RVA: 0x0001DE05 File Offset: 0x0001C005
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

			// Token: 0x06000889 RID: 2185 RVA: 0x0001DE18 File Offset: 0x0001C018
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

			// Token: 0x0600088A RID: 2186 RVA: 0x0001DED3 File Offset: 0x0001C0D3
			private void OnStoryboardCompleted(object sender, global::System.EventArgs e)
			{
				this._onChangedAction = null;
				if (this._onAnimatedCompleteAction != null)
				{
					this._onAnimatedCompleteAction(this);
					this._onAnimatedCompleteAction = null;
				}
			}

			// Token: 0x0400040B RID: 1035
			private global::System.Action<global::Infragistics.Controls.TouchScrollHelper.DoubleValueAnimator> _onChangedAction;

			// Token: 0x0400040C RID: 1036
			private global::System.Action<global::Infragistics.Controls.TouchScrollHelper.DoubleValueAnimator> _onAnimatedCompleteAction;

			// Token: 0x0400040D RID: 1037
			private global::System.Windows.Media.Animation.Timeline _animation;

			// Token: 0x0400040E RID: 1038
			private global::System.Windows.Media.Animation.Storyboard _storyboard;

			// Token: 0x0400040F RID: 1039
			public static readonly global::System.Windows.DependencyProperty ValueProperty = global::Infragistics.DependencyPropertyUtilities.Register("Value", typeof(double), typeof(global::Infragistics.Controls.TouchScrollHelper.DoubleValueAnimator), global::Infragistics.DependencyPropertyUtilities.CreateMetadata(double.NaN, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.TouchScrollHelper.DoubleValueAnimator.OnValueChanged)));
		}
	}
}
