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
	// Token: 0x0200011F RID: 287
	[global::System.ComponentModel.DesignTimeVisible(false)]
	public class ExpanderDecorator : global::System.Windows.Controls.Decorator
	{
		// Token: 0x06000A99 RID: 2713 RVA: 0x00023464 File Offset: 0x00021664
		static ExpanderDecorator()
		{
			global::System.Windows.UIElement.ClipToBoundsProperty.OverrideMetadata(typeof(global::Infragistics.Windows.ExpanderDecorator), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.TrueBox));
			global::Infragistics.Windows.ExpanderDecorator.ToggleExpandedState = new global::System.Windows.Input.RoutedCommand("ToggleExpandedState", typeof(global::Infragistics.Windows.ExpanderDecorator));
			global::System.Windows.Input.CommandManager.RegisterClassCommandBinding(typeof(global::Infragistics.Windows.ExpanderDecorator), new global::System.Windows.Input.CommandBinding(global::Infragistics.Windows.ExpanderDecorator.ToggleExpandedState, new global::System.Windows.Input.ExecutedRoutedEventHandler(global::Infragistics.Windows.ExpanderDecorator.OnToggleExpandedState), new global::System.Windows.Input.CanExecuteRoutedEventHandler(global::Infragistics.Windows.ExpanderDecorator.OnQueryToggleExpandedState)));
		}

		// Token: 0x06000A9A RID: 2714 RVA: 0x00023558 File Offset: 0x00021758
		protected override global::System.Windows.Size ArrangeOverride(global::System.Windows.Size arrangeSize)
		{
			global::System.Windows.Size result = base.ArrangeOverride(arrangeSize);
			if (this.Child != null && this.IsExpanded && !this._isAnimationActive)
			{
				this._cachedChildActualSize = new global::System.Windows.Size(((global::System.Windows.FrameworkElement)this.Child).ActualWidth, ((global::System.Windows.FrameworkElement)this.Child).ActualHeight);
			}
			return result;
		}

		// Token: 0x06000A9B RID: 2715 RVA: 0x000235B4 File Offset: 0x000217B4
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

		// Token: 0x06000A9C RID: 2716 RVA: 0x0002363E File Offset: 0x0002183E
		protected override global::System.Windows.Automation.Peers.AutomationPeer OnCreateAutomationPeer()
		{
			return new global::Infragistics.Windows.Automation.Peers.ExpanderDecoratorAutomationPeer(this);
		}

		// Token: 0x06000A9D RID: 2717 RVA: 0x00023648 File Offset: 0x00021848
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

		// Token: 0x06000A9E RID: 2718 RVA: 0x00023694 File Offset: 0x00021894
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

		// Token: 0x170001C0 RID: 448
		// (get) Token: 0x06000A9F RID: 2719 RVA: 0x000236F6 File Offset: 0x000218F6
		// (set) Token: 0x06000AA0 RID: 2720 RVA: 0x00023708 File Offset: 0x00021908
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

		// Token: 0x06000AA1 RID: 2721 RVA: 0x0002371C File Offset: 0x0002191C
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

		// Token: 0x170001C1 RID: 449
		// (get) Token: 0x06000AA2 RID: 2722 RVA: 0x0002379F File Offset: 0x0002199F
		// (set) Token: 0x06000AA3 RID: 2723 RVA: 0x000237B1 File Offset: 0x000219B1
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

		// Token: 0x06000AA4 RID: 2724 RVA: 0x000237C4 File Offset: 0x000219C4
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

		// Token: 0x06000AA5 RID: 2725 RVA: 0x00023A0D File Offset: 0x00021C0D
		private void BeginAnimateSizeForExpand()
		{
			if (this.IsExpanded)
			{
				this.AnimateSize(true);
			}
		}

		// Token: 0x06000AA6 RID: 2726 RVA: 0x00023A20 File Offset: 0x00021C20
		private global::System.Windows.Media.Animation.DoubleAnimation CreateDoubleAnimation(double from, double to, global::System.Windows.Duration duration)
		{
			return new global::System.Windows.Media.Animation.DoubleAnimation(from, to, duration);
		}

		// Token: 0x06000AA7 RID: 2727 RVA: 0x00023A38 File Offset: 0x00021C38
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

		// Token: 0x06000AA8 RID: 2728 RVA: 0x00023A9C File Offset: 0x00021C9C
		private static void OnToggleExpandedState(object target, global::System.Windows.Input.ExecutedRoutedEventArgs args)
		{
			global::Infragistics.Windows.ExpanderDecorator expanderDecorator = target as global::Infragistics.Windows.ExpanderDecorator;
			if (expanderDecorator != null)
			{
				expanderDecorator.IsExpanded = !expanderDecorator.IsExpanded;
			}
		}

		// Token: 0x06000AA9 RID: 2729 RVA: 0x00023AC2 File Offset: 0x00021CC2
		private static void OnQueryToggleExpandedState(object target, global::System.Windows.Input.CanExecuteRoutedEventArgs args)
		{
			args.CanExecute = true;
		}

		// Token: 0x0400048C RID: 1164
		private global::System.Windows.Size _cachedChildActualSize = global::System.Windows.Size.Empty;

		// Token: 0x0400048D RID: 1165
		private double _fromAnimationValue;

		// Token: 0x0400048E RID: 1166
		private double _toAnimationValue;

		// Token: 0x0400048F RID: 1167
		private global::System.Windows.DependencyProperty _propertyToAnimate;

		// Token: 0x04000490 RID: 1168
		private bool _isAnimationActive;

		// Token: 0x04000491 RID: 1169
		private global::System.Windows.Media.Animation.Storyboard _storyboard;

		// Token: 0x04000492 RID: 1170
		public static readonly global::System.Windows.Input.RoutedCommand ToggleExpandedState;

		// Token: 0x04000493 RID: 1171
		public static readonly global::System.Windows.DependencyProperty IsExpandedProperty = global::System.Windows.DependencyProperty.Register("IsExpanded", typeof(bool), typeof(global::Infragistics.Windows.ExpanderDecorator), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.ExpanderDecorator.OnIsExpandedChanged), new global::System.Windows.CoerceValueCallback(global::Infragistics.Windows.ExpanderDecorator.OnCoerceIsExpanded)));

		// Token: 0x04000494 RID: 1172
		public static readonly global::System.Windows.DependencyProperty OrientationProperty = global::System.Windows.DependencyProperty.Register("Orientation", typeof(global::System.Windows.Controls.Orientation), typeof(global::Infragistics.Windows.ExpanderDecorator), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.OrientationHorizontalBox, null, new global::System.Windows.CoerceValueCallback(global::Infragistics.Windows.ExpanderDecorator.OnCoerceOrientation)));
	}
}
