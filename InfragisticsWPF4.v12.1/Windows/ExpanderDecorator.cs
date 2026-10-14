using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Automation.Peers;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media.Animation;
using System.Windows.Threading;
using Infragistics.Windows.Automation.Peers;

namespace Infragistics.Windows
{
	// Token: 0x02000101 RID: 257
	[global::System.ComponentModel.DesignTimeVisible(false)]
	public class ExpanderDecorator : global::System.Windows.Controls.Decorator
	{
		// Token: 0x0600099A RID: 2458 RVA: 0x0001F89C File Offset: 0x0001DA9C
		static ExpanderDecorator()
		{
			global::System.Windows.UIElement.ClipToBoundsProperty.OverrideMetadata(typeof(global::Infragistics.Windows.ExpanderDecorator), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.TrueBox));
			global::Infragistics.Windows.ExpanderDecorator.ToggleExpandedState = new global::System.Windows.Input.RoutedCommand("ToggleExpandedState", typeof(global::Infragistics.Windows.ExpanderDecorator));
			global::System.Windows.Input.CommandManager.RegisterClassCommandBinding(typeof(global::Infragistics.Windows.ExpanderDecorator), new global::System.Windows.Input.CommandBinding(global::Infragistics.Windows.ExpanderDecorator.ToggleExpandedState, new global::System.Windows.Input.ExecutedRoutedEventHandler(global::Infragistics.Windows.ExpanderDecorator.OnToggleExpandedState), new global::System.Windows.Input.CanExecuteRoutedEventHandler(global::Infragistics.Windows.ExpanderDecorator.OnQueryToggleExpandedState)));
		}

		// Token: 0x0600099B RID: 2459 RVA: 0x0001F990 File Offset: 0x0001DB90
		protected override global::System.Windows.Size ArrangeOverride(global::System.Windows.Size arrangeSize)
		{
			global::System.Windows.Size result = base.ArrangeOverride(arrangeSize);
			if (this.Child != null && this.IsExpanded && !this._isAnimationActive)
			{
				this._cachedChildActualSize = new global::System.Windows.Size(((global::System.Windows.FrameworkElement)this.Child).ActualWidth, ((global::System.Windows.FrameworkElement)this.Child).ActualHeight);
			}
			return result;
		}

		// Token: 0x0600099C RID: 2460 RVA: 0x0001F9EC File Offset: 0x0001DBEC
		protected override global::System.Windows.Size MeasureOverride(global::System.Windows.Size constraint)
		{
			global::System.Windows.Size desiredSize = new global::System.Windows.Size(0.0, 0.0);
			if (this.Child != null)
			{
				global::System.Windows.Size availableSize = constraint;
				if (this.IsExpanded)
				{
					if (this.Orientation == global::System.Windows.Controls.Orientation.Vertical)
					{
						availableSize = new global::System.Windows.Size(constraint.Width, double.PositiveInfinity);
					}
					else
					{
						availableSize = new global::System.Windows.Size(double.PositiveInfinity, constraint.Height);
					}
				}
				this.Child.Measure(availableSize);
				desiredSize = this.Child.DesiredSize;
			}
			return desiredSize;
		}

		// Token: 0x0600099D RID: 2461 RVA: 0x0001FA76 File Offset: 0x0001DC76
		protected override global::System.Windows.Automation.Peers.AutomationPeer OnCreateAutomationPeer()
		{
			return new global::Infragistics.Windows.Automation.Peers.ExpanderDecoratorAutomationPeer(this);
		}

		// Token: 0x0600099E RID: 2462 RVA: 0x0001FA80 File Offset: 0x0001DC80
		private static object OnCoerceIsExpanded(global::System.Windows.DependencyObject target, object value)
		{
			global::Infragistics.Windows.ExpanderDecorator expanderDecorator = target as global::Infragistics.Windows.ExpanderDecorator;
			if (expanderDecorator != null && !expanderDecorator.IsLoaded && (bool)value)
			{
				if (expanderDecorator.Orientation == global::System.Windows.Controls.Orientation.Vertical)
				{
					expanderDecorator.ClearValue(global::System.Windows.FrameworkElement.HeightProperty);
				}
				else
				{
					expanderDecorator.ClearValue(global::System.Windows.FrameworkElement.WidthProperty);
				}
			}
			return value;
		}

		// Token: 0x0600099F RID: 2463 RVA: 0x0001FACC File Offset: 0x0001DCCC
		private static void OnIsExpandedChanged(global::System.Windows.DependencyObject target, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.ExpanderDecorator expanderDecorator = target as global::Infragistics.Windows.ExpanderDecorator;
			if (expanderDecorator != null)
			{
				if (!(bool)e.NewValue || !expanderDecorator.IsLoaded || !expanderDecorator.IsVisible)
				{
					expanderDecorator.AnimateSize((bool)e.NewValue);
					return;
				}
				expanderDecorator.Dispatcher.BeginInvoke(global::System.Windows.Threading.DispatcherPriority.Normal, new global::Infragistics.Windows.Utilities.MethodDelegate(expanderDecorator.BeginAnimateSizeForExpand));
			}
		}

		// Token: 0x170001A8 RID: 424
		// (get) Token: 0x060009A0 RID: 2464 RVA: 0x0001FB2E File Offset: 0x0001DD2E
		// (set) Token: 0x060009A1 RID: 2465 RVA: 0x0001FB40 File Offset: 0x0001DD40
		[global::System.ComponentModel.Bindable(true)]
		public bool IsExpanded
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.Windows.ExpanderDecorator.IsExpandedProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.ExpanderDecorator.IsExpandedProperty, value);
			}
		}

		// Token: 0x060009A2 RID: 2466 RVA: 0x0001FB54 File Offset: 0x0001DD54
		private static object OnCoerceOrientation(global::System.Windows.DependencyObject target, object value)
		{
			global::Infragistics.Windows.ExpanderDecorator expanderDecorator = target as global::Infragistics.Windows.ExpanderDecorator;
			if (expanderDecorator != null && expanderDecorator.IsLoaded && !expanderDecorator.IsExpanded)
			{
				expanderDecorator.IsExpanded = true;
			}
			else if (expanderDecorator != null && !expanderDecorator.IsLoaded && !expanderDecorator.IsExpanded)
			{
				if ((global::System.Windows.Controls.Orientation)value == global::System.Windows.Controls.Orientation.Vertical)
				{
					expanderDecorator.Height = 0.0;
					expanderDecorator.ClearValue(global::System.Windows.FrameworkElement.WidthProperty);
				}
				else
				{
					expanderDecorator.Width = 0.0;
					expanderDecorator.ClearValue(global::System.Windows.FrameworkElement.HeightProperty);
				}
			}
			return value;
		}

		// Token: 0x170001A9 RID: 425
		// (get) Token: 0x060009A3 RID: 2467 RVA: 0x0001FBD7 File Offset: 0x0001DDD7
		// (set) Token: 0x060009A4 RID: 2468 RVA: 0x0001FBE9 File Offset: 0x0001DDE9
		[global::System.ComponentModel.Bindable(true)]
		public global::System.Windows.Controls.Orientation Orientation
		{
			get
			{
				return (global::System.Windows.Controls.Orientation)base.GetValue(global::Infragistics.Windows.ExpanderDecorator.OrientationProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.ExpanderDecorator.OrientationProperty, value);
			}
		}

		// Token: 0x060009A5 RID: 2469 RVA: 0x0001FBFC File Offset: 0x0001DDFC
		private void AnimateSize(bool newIsExpandedValue)
		{
			if (this.Child == null)
			{
				return;
			}
			if (!base.IsLoaded || !base.IsVisible)
			{
				if (!newIsExpandedValue)
				{
					if (this.Orientation == global::System.Windows.Controls.Orientation.Vertical)
					{
						base.Height = 0.0;
						return;
					}
					base.Width = 0.0;
					return;
				}
				else
				{
					if (this.Orientation == global::System.Windows.Controls.Orientation.Vertical)
					{
						base.ClearValue(global::System.Windows.FrameworkElement.HeightProperty);
						base.BeginAnimation(global::System.Windows.FrameworkElement.HeightProperty, null);
						return;
					}
					base.ClearValue(global::System.Windows.FrameworkElement.WidthProperty);
					base.BeginAnimation(global::System.Windows.FrameworkElement.WidthProperty, null);
					return;
				}
			}
			else
			{
				if (newIsExpandedValue)
				{
					base.InvalidateMeasure();
					base.InvalidateArrange();
					base.UpdateLayout();
				}
				double width = this._cachedChildActualSize.Width;
				double height = this._cachedChildActualSize.Height;
				if (double.IsInfinity(width))
				{
					width = this.Child.DesiredSize.Width;
				}
				if (double.IsInfinity(height))
				{
					height = this.Child.DesiredSize.Height;
				}
				if (!newIsExpandedValue)
				{
					this._toAnimationValue = 0.0;
					if (this.Orientation == global::System.Windows.Controls.Orientation.Vertical)
					{
						this._fromAnimationValue = height;
						this._propertyToAnimate = global::System.Windows.FrameworkElement.HeightProperty;
					}
					else
					{
						this._fromAnimationValue = width;
						this._propertyToAnimate = global::System.Windows.FrameworkElement.WidthProperty;
					}
				}
				else if (this.Orientation == global::System.Windows.Controls.Orientation.Vertical)
				{
					this._fromAnimationValue = 0.0;
					this._toAnimationValue = height;
					this._propertyToAnimate = global::System.Windows.FrameworkElement.HeightProperty;
				}
				else
				{
					this._fromAnimationValue = 0.0;
					this._toAnimationValue = width;
					this._propertyToAnimate = global::System.Windows.FrameworkElement.WidthProperty;
				}
				if (double.IsInfinity(this._fromAnimationValue) || double.IsInfinity(this._toAnimationValue))
				{
					return;
				}
				global::System.Windows.Media.Animation.DoubleAnimation doubleAnimation = this.CreateDoubleAnimation(this._fromAnimationValue, this._toAnimationValue, new global::System.Windows.Duration(global::System.TimeSpan.FromSeconds(0.3)));
				this._storyboard = new global::System.Windows.Media.Animation.Storyboard();
				this._storyboard.Children.Add(doubleAnimation);
				string text = base.Name;
				if (string.IsNullOrEmpty(text))
				{
					global::System.Windows.NameScope.SetNameScope(this, new global::System.Windows.NameScope());
					text = "ExpDec";
					base.RegisterName(text, this);
				}
				global::System.Windows.Media.Animation.Storyboard.SetTargetName(doubleAnimation, text);
				global::System.Windows.Media.Animation.Storyboard.SetTargetProperty(doubleAnimation, new global::System.Windows.PropertyPath(this._propertyToAnimate));
				this._storyboard.Completed += this.StoryboardCompleted;
				this._isAnimationActive = true;
				this._storyboard.Begin(this);
				return;
			}
		}

		// Token: 0x060009A6 RID: 2470 RVA: 0x0001FE45 File Offset: 0x0001E045
		private void BeginAnimateSizeForExpand()
		{
			if (this.IsExpanded)
			{
				this.AnimateSize(true);
			}
		}

		// Token: 0x060009A7 RID: 2471 RVA: 0x0001FE58 File Offset: 0x0001E058
		private global::System.Windows.Media.Animation.DoubleAnimation CreateDoubleAnimation(double from, double to, global::System.Windows.Duration duration)
		{
			return new global::System.Windows.Media.Animation.DoubleAnimation(from, to, duration);
		}

		// Token: 0x060009A8 RID: 2472 RVA: 0x0001FE70 File Offset: 0x0001E070
		private void StoryboardCompleted(object sender, global::System.EventArgs e)
		{
			if (this._storyboard != null)
			{
				this._storyboard.Completed -= this.StoryboardCompleted;
			}
			this._storyboard = null;
			this._isAnimationActive = false;
			if (this._toAnimationValue != 0.0)
			{
				base.BeginAnimation(this._propertyToAnimate, null);
				base.ClearValue(this._propertyToAnimate);
			}
		}

		// Token: 0x060009A9 RID: 2473 RVA: 0x0001FED4 File Offset: 0x0001E0D4
		private static void OnToggleExpandedState(object target, global::System.Windows.Input.ExecutedRoutedEventArgs args)
		{
			global::Infragistics.Windows.ExpanderDecorator expanderDecorator = target as global::Infragistics.Windows.ExpanderDecorator;
			if (expanderDecorator != null)
			{
				expanderDecorator.IsExpanded = !expanderDecorator.IsExpanded;
			}
		}

		// Token: 0x060009AA RID: 2474 RVA: 0x0001FEFA File Offset: 0x0001E0FA
		private static void OnQueryToggleExpandedState(object target, global::System.Windows.Input.CanExecuteRoutedEventArgs args)
		{
			args.CanExecute = true;
		}

		// Token: 0x040003D9 RID: 985
		private global::System.Windows.Size _cachedChildActualSize = global::System.Windows.Size.Empty;

		// Token: 0x040003DA RID: 986
		private double _fromAnimationValue;

		// Token: 0x040003DB RID: 987
		private double _toAnimationValue;

		// Token: 0x040003DC RID: 988
		private global::System.Windows.DependencyProperty _propertyToAnimate;

		// Token: 0x040003DD RID: 989
		private bool _isAnimationActive;

		// Token: 0x040003DE RID: 990
		private global::System.Windows.Media.Animation.Storyboard _storyboard;

		// Token: 0x040003DF RID: 991
		public static readonly global::System.Windows.Input.RoutedCommand ToggleExpandedState;

		// Token: 0x040003E0 RID: 992
		public static readonly global::System.Windows.DependencyProperty IsExpandedProperty = global::System.Windows.DependencyProperty.Register("IsExpanded", typeof(bool), typeof(global::Infragistics.Windows.ExpanderDecorator), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.ExpanderDecorator.OnIsExpandedChanged), new global::System.Windows.CoerceValueCallback(global::Infragistics.Windows.ExpanderDecorator.OnCoerceIsExpanded)));

		// Token: 0x040003E1 RID: 993
		public static readonly global::System.Windows.DependencyProperty OrientationProperty = global::System.Windows.DependencyProperty.Register("Orientation", typeof(global::System.Windows.Controls.Orientation), typeof(global::Infragistics.Windows.ExpanderDecorator), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.OrientationHorizontalBox, null, new global::System.Windows.CoerceValueCallback(global::Infragistics.Windows.ExpanderDecorator.OnCoerceOrientation)));
	}
}
