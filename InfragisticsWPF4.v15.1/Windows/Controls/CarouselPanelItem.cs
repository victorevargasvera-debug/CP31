using System;
using System.Collections;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Media;
using Infragistics.Collections;

namespace Infragistics.Windows.Controls
{
	// Token: 0x0200025F RID: 607
	[global::System.ComponentModel.DesignTimeVisible(false)]
	public class CarouselPanelItem : global::System.Windows.Controls.ListBoxItem
	{
		// Token: 0x0600190B RID: 6411 RVA: 0x000611A8 File Offset: 0x0005F3A8
		static CarouselPanelItem()
		{
			global::System.Windows.FrameworkElement.DefaultStyleKeyProperty.OverrideMetadata(typeof(global::Infragistics.Windows.Controls.CarouselPanelItem), new global::System.Windows.FrameworkPropertyMetadata(typeof(global::Infragistics.Windows.Controls.CarouselPanelItem)));
		}

		// Token: 0x0600190C RID: 6412 RVA: 0x0006137A File Offset: 0x0005F57A
		public CarouselPanelItem()
		{
		}

		// Token: 0x0600190D RID: 6413 RVA: 0x000613B8 File Offset: 0x0005F5B8
		protected internal CarouselPanelItem(global::Infragistics.Windows.Controls.XamCarouselPanel carouselPanel)
		{
			if (carouselPanel == null)
			{
				throw new global::System.ArgumentException(global::SR.GetString("LE_ArgumentNullException_1"));
			}
			this._carouselPanel = carouselPanel;
			global::System.Windows.Data.Binding binding = new global::System.Windows.Data.Binding();
			binding.Mode = global::System.Windows.Data.BindingMode.OneWay;
			binding.Source = carouselPanel;
			binding.Path = new global::System.Windows.PropertyPath("ViewSettingsVersion", new object[0]);
			base.SetBinding(global::Infragistics.Windows.Controls.CarouselPanelItem.ViewSettingsVersionProperty, binding);
		}

		// Token: 0x170005AB RID: 1451
		// (get) Token: 0x0600190E RID: 6414 RVA: 0x00061454 File Offset: 0x0005F654
		protected override global::System.Collections.IEnumerator LogicalChildren
		{
			get
			{
				global::System.Windows.DependencyObject dependencyObject = base.Content as global::System.Windows.DependencyObject;
				if (dependencyObject != null && global::System.Windows.LogicalTreeHelper.GetParent(dependencyObject) == this)
				{
					return new global::Infragistics.Collections.SingleItemEnumerator(dependencyObject);
				}
				return base.LogicalChildren;
			}
		}

		// Token: 0x170005AC RID: 1452
		// (get) Token: 0x0600190F RID: 6415 RVA: 0x00061486 File Offset: 0x0005F686
		internal global::Infragistics.Windows.Controls.XamCarouselPanel CarouselPanel
		{
			get
			{
				return this._carouselPanel;
			}
		}

		// Token: 0x170005AD RID: 1453
		// (get) Token: 0x06001910 RID: 6416 RVA: 0x0006148E File Offset: 0x0005F68E
		// (set) Token: 0x06001911 RID: 6417 RVA: 0x00061496 File Offset: 0x0005F696
		internal global::System.Windows.Point CurrentLocation
		{
			get
			{
				return this._currentLocation;
			}
			set
			{
				this._currentLocation = value;
			}
		}

		// Token: 0x170005AE RID: 1454
		// (get) Token: 0x06001912 RID: 6418 RVA: 0x0006149F File Offset: 0x0005F69F
		// (set) Token: 0x06001913 RID: 6419 RVA: 0x000614A7 File Offset: 0x0005F6A7
		internal double CurrentZindexEffectStopValue
		{
			get
			{
				return this._currentZindexEffectStopValue;
			}
			set
			{
				this._currentZindexEffectStopValue = value;
			}
		}

		// Token: 0x170005AF RID: 1455
		// (get) Token: 0x06001914 RID: 6420 RVA: 0x000614B0 File Offset: 0x0005F6B0
		internal bool IsPathLocationUnset
		{
			get
			{
				return double.IsNegativeInfinity(this._pathLocationPercent);
			}
		}

		// Token: 0x170005B0 RID: 1456
		// (get) Token: 0x06001915 RID: 6421 RVA: 0x000614BD File Offset: 0x0005F6BD
		// (set) Token: 0x06001916 RID: 6422 RVA: 0x000614C5 File Offset: 0x0005F6C5
		internal bool NeedsArrange
		{
			get
			{
				return this._needsArrange;
			}
			set
			{
				this._needsArrange = value;
			}
		}

		// Token: 0x170005B1 RID: 1457
		// (get) Token: 0x06001917 RID: 6423 RVA: 0x000614CE File Offset: 0x0005F6CE
		// (set) Token: 0x06001918 RID: 6424 RVA: 0x000614D6 File Offset: 0x0005F6D6
		internal double PathLocationPercent
		{
			get
			{
				return this._pathLocationPercent;
			}
			set
			{
				this._pathLocationPercent = value;
			}
		}

		// Token: 0x170005B2 RID: 1458
		// (get) Token: 0x06001919 RID: 6425 RVA: 0x000614DF File Offset: 0x0005F6DF
		// (set) Token: 0x0600191A RID: 6426 RVA: 0x000614E7 File Offset: 0x0005F6E7
		internal double PathTargetPercent
		{
			get
			{
				return this._pathTargetPercent;
			}
			set
			{
				this._pathTargetPercent = value;
			}
		}

		// Token: 0x170005B3 RID: 1459
		// (get) Token: 0x0600191B RID: 6427 RVA: 0x000614F0 File Offset: 0x0005F6F0
		// (set) Token: 0x0600191C RID: 6428 RVA: 0x000614F8 File Offset: 0x0005F6F8
		internal double Velocity
		{
			get
			{
				return this._velocity;
			}
			set
			{
				this._velocity = value;
			}
		}

		// Token: 0x0600191D RID: 6429 RVA: 0x00061504 File Offset: 0x0005F704
		private static void OnViewSettingsVersionChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.Controls.CarouselPanelItem carouselPanelItem = d as global::Infragistics.Windows.Controls.CarouselPanelItem;
			if (carouselPanelItem != null)
			{
				global::Infragistics.Windows.Controls.CarouselViewSettings viewSettingsInternal = carouselPanelItem.CarouselPanel.ViewSettingsInternal;
				if (viewSettingsInternal != null)
				{
					carouselPanelItem.SetValue(global::Infragistics.Windows.Controls.CarouselPanelItem.AutoScaleItemContentsToFitPropertyKey, global::Infragistics.KnownBoxes.FromValue(viewSettingsInternal.AutoScaleItemContentsToFit));
					carouselPanelItem.SetValue(global::Infragistics.Windows.Controls.CarouselPanelItem.IsListContinuousPropertyKey, global::Infragistics.KnownBoxes.FromValue(viewSettingsInternal.IsListContinuous));
					carouselPanelItem.SetValue(global::Infragistics.Windows.Controls.CarouselPanelItem.ItemHorizontalScrollBarVisibilityPropertyKey, global::Infragistics.KnownBoxes.FromValue(viewSettingsInternal.ItemHorizontalScrollBarVisibility));
					carouselPanelItem.SetValue(global::Infragistics.Windows.Controls.CarouselPanelItem.ItemVerticalScrollBarVisibilityPropertyKey, global::Infragistics.KnownBoxes.FromValue(viewSettingsInternal.ItemVerticalScrollBarVisibility));
				}
			}
		}

		// Token: 0x170005B4 RID: 1460
		// (get) Token: 0x0600191E RID: 6430 RVA: 0x00061582 File Offset: 0x0005F782
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.ReadOnly(true)]
		public bool AutoScaleItemContentsToFit
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.Windows.Controls.CarouselPanelItem.AutoScaleItemContentsToFitProperty);
			}
		}

		// Token: 0x170005B5 RID: 1461
		// (get) Token: 0x0600191F RID: 6431 RVA: 0x00061594 File Offset: 0x0005F794
		[global::System.ComponentModel.ReadOnly(true)]
		[global::System.ComponentModel.Bindable(true)]
		public bool IsListContinuous
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.Windows.Controls.CarouselPanelItem.IsListContinuousProperty);
			}
		}

		// Token: 0x170005B6 RID: 1462
		// (get) Token: 0x06001920 RID: 6432 RVA: 0x000615A6 File Offset: 0x0005F7A6
		[global::System.ComponentModel.ReadOnly(true)]
		[global::System.ComponentModel.Bindable(true)]
		public bool IsFirstItem
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.Windows.Controls.CarouselPanelItem.IsFirstItemProperty);
			}
		}

		// Token: 0x170005B7 RID: 1463
		// (get) Token: 0x06001921 RID: 6433 RVA: 0x000615B8 File Offset: 0x0005F7B8
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.ReadOnly(true)]
		public bool IsLastItem
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.Windows.Controls.CarouselPanelItem.IsLastItemProperty);
			}
		}

		// Token: 0x170005B8 RID: 1464
		// (get) Token: 0x06001922 RID: 6434 RVA: 0x000615CA File Offset: 0x0005F7CA
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.ReadOnly(true)]
		public global::System.Windows.Controls.ScrollBarVisibility ItemHorizontalScrollBarVisibility
		{
			get
			{
				return (global::System.Windows.Controls.ScrollBarVisibility)base.GetValue(global::Infragistics.Windows.Controls.CarouselPanelItem.ItemHorizontalScrollBarVisibilityProperty);
			}
		}

		// Token: 0x170005B9 RID: 1465
		// (get) Token: 0x06001923 RID: 6435 RVA: 0x000615DC File Offset: 0x0005F7DC
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.ReadOnly(true)]
		public global::System.Windows.Controls.ScrollBarVisibility ItemVerticalScrollBarVisibility
		{
			get
			{
				return (global::System.Windows.Controls.ScrollBarVisibility)base.GetValue(global::Infragistics.Windows.Controls.CarouselPanelItem.ItemVerticalScrollBarVisibilityProperty);
			}
		}

		// Token: 0x06001924 RID: 6436 RVA: 0x000615EE File Offset: 0x0005F7EE
		public virtual void ClearContainerForItem(object item)
		{
			global::System.Windows.Data.BindingOperations.ClearAllBindings(this);
		}

		// Token: 0x06001925 RID: 6437 RVA: 0x000615F6 File Offset: 0x0005F7F6
		public virtual void PrepareContainerForItem(object item)
		{
		}

		// Token: 0x06001926 RID: 6438 RVA: 0x000615F8 File Offset: 0x0005F7F8
		internal bool UpdateTransforms(global::System.Windows.Media.Matrix newMatrix, double newSkewAngleX, double newSkewAngleY, double newSkewCenterX, double newSkewCenterY)
		{
			this.EnsureTransforms();
			bool result = false;
			if (this._matrixTransform.Matrix != newMatrix)
			{
				this._matrixTransform.Matrix = newMatrix;
				result = true;
			}
			if (this._skewTransform.AngleX != newSkewAngleX)
			{
				this._skewTransform.AngleX = newSkewAngleX;
				result = true;
			}
			if (this._skewTransform.AngleY != newSkewAngleY)
			{
				this._skewTransform.AngleY = newSkewAngleY;
				result = true;
			}
			if (!double.IsNegativeInfinity(newSkewCenterX) && this._skewTransform.CenterX != newSkewCenterX)
			{
				this._skewTransform.CenterX = newSkewCenterX;
				result = true;
			}
			if (!double.IsNegativeInfinity(newSkewCenterY) && this._skewTransform.CenterY != newSkewCenterY)
			{
				this._skewTransform.CenterY = newSkewCenterY;
				result = true;
			}
			return result;
		}

		// Token: 0x06001927 RID: 6439 RVA: 0x000616B8 File Offset: 0x0005F8B8
		private void EnsureTransforms()
		{
			global::System.Windows.Media.TransformGroup transformGroup = base.RenderTransform as global::System.Windows.Media.TransformGroup;
			if (transformGroup != null)
			{
				global::System.Windows.Media.TransformCollection children = transformGroup.Children;
				if (children.Count > 2 && children[0].GetType() == typeof(global::System.Windows.Media.SkewTransform) && children[1].GetType() == typeof(global::System.Windows.Media.ScaleTransform) && children[2].GetType() == typeof(global::System.Windows.Media.MatrixTransform) && this._skewTransform == children[0] && this._scaleTransform == children[1] && this._matrixTransform == children[2])
				{
					return;
				}
			}
			transformGroup = new global::System.Windows.Media.TransformGroup();
			this._skewTransform = new global::System.Windows.Media.SkewTransform();
			transformGroup.Children.Add(this._skewTransform);
			this._scaleTransform = new global::System.Windows.Media.ScaleTransform();
			transformGroup.Children.Add(this._scaleTransform);
			this._matrixTransform = new global::System.Windows.Media.MatrixTransform();
			transformGroup.Children.Add(this._matrixTransform);
			base.RenderTransform = transformGroup;
		}

		// Token: 0x04000C98 RID: 3224
		private double _pathLocationPercent = double.NegativeInfinity;

		// Token: 0x04000C99 RID: 3225
		private double _pathTargetPercent;

		// Token: 0x04000C9A RID: 3226
		private double _velocity;

		// Token: 0x04000C9B RID: 3227
		private global::System.Windows.Point _currentLocation = new global::System.Windows.Point(0.0, 0.0);

		// Token: 0x04000C9C RID: 3228
		private double _currentZindexEffectStopValue;

		// Token: 0x04000C9D RID: 3229
		private global::Infragistics.Windows.Controls.XamCarouselPanel _carouselPanel;

		// Token: 0x04000C9E RID: 3230
		private global::System.Windows.Media.MatrixTransform _matrixTransform;

		// Token: 0x04000C9F RID: 3231
		private global::System.Windows.Media.ScaleTransform _scaleTransform;

		// Token: 0x04000CA0 RID: 3232
		private global::System.Windows.Media.SkewTransform _skewTransform;

		// Token: 0x04000CA1 RID: 3233
		private bool _needsArrange = true;

		// Token: 0x04000CA2 RID: 3234
		internal static readonly global::System.Windows.DependencyProperty ViewSettingsVersionProperty = global::System.Windows.DependencyProperty.Register("ViewSettingsVersion", typeof(int), typeof(global::Infragistics.Windows.Controls.CarouselPanelItem), new global::System.Windows.FrameworkPropertyMetadata(0, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.Controls.CarouselPanelItem.OnViewSettingsVersionChanged)));

		// Token: 0x04000CA3 RID: 3235
		private static readonly global::System.Windows.DependencyPropertyKey AutoScaleItemContentsToFitPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("AutoScaleItemContentsToFit", typeof(bool), typeof(global::Infragistics.Windows.Controls.CarouselPanelItem), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox));

		// Token: 0x04000CA4 RID: 3236
		public static readonly global::System.Windows.DependencyProperty AutoScaleItemContentsToFitProperty = global::Infragistics.Windows.Controls.CarouselPanelItem.AutoScaleItemContentsToFitPropertyKey.DependencyProperty;

		// Token: 0x04000CA5 RID: 3237
		private static readonly global::System.Windows.DependencyPropertyKey IsListContinuousPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("IsListContinuous", typeof(bool), typeof(global::Infragistics.Windows.Controls.CarouselPanelItem), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox));

		// Token: 0x04000CA6 RID: 3238
		public static readonly global::System.Windows.DependencyProperty IsListContinuousProperty = global::Infragistics.Windows.Controls.CarouselPanelItem.IsListContinuousPropertyKey.DependencyProperty;

		// Token: 0x04000CA7 RID: 3239
		internal static readonly global::System.Windows.DependencyPropertyKey IsFirstItemPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("IsFirstItem", typeof(bool), typeof(global::Infragistics.Windows.Controls.CarouselPanelItem), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox));

		// Token: 0x04000CA8 RID: 3240
		public static readonly global::System.Windows.DependencyProperty IsFirstItemProperty = global::Infragistics.Windows.Controls.CarouselPanelItem.IsFirstItemPropertyKey.DependencyProperty;

		// Token: 0x04000CA9 RID: 3241
		internal static readonly global::System.Windows.DependencyPropertyKey IsLastItemPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("IsLastItem", typeof(bool), typeof(global::Infragistics.Windows.Controls.CarouselPanelItem), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox));

		// Token: 0x04000CAA RID: 3242
		public static readonly global::System.Windows.DependencyProperty IsLastItemProperty = global::Infragistics.Windows.Controls.CarouselPanelItem.IsLastItemPropertyKey.DependencyProperty;

		// Token: 0x04000CAB RID: 3243
		private static readonly global::System.Windows.DependencyPropertyKey ItemHorizontalScrollBarVisibilityPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("ItemHorizontalScrollBarVisibility", typeof(global::System.Windows.Controls.ScrollBarVisibility), typeof(global::Infragistics.Windows.Controls.CarouselPanelItem), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.ScrollBarVisibilityAutoBox));

		// Token: 0x04000CAC RID: 3244
		public static readonly global::System.Windows.DependencyProperty ItemHorizontalScrollBarVisibilityProperty = global::Infragistics.Windows.Controls.CarouselPanelItem.ItemHorizontalScrollBarVisibilityPropertyKey.DependencyProperty;

		// Token: 0x04000CAD RID: 3245
		private static readonly global::System.Windows.DependencyPropertyKey ItemVerticalScrollBarVisibilityPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("ItemVerticalScrollBarVisibility", typeof(global::System.Windows.Controls.ScrollBarVisibility), typeof(global::Infragistics.Windows.Controls.CarouselPanelItem), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.ScrollBarVisibilityAutoBox));

		// Token: 0x04000CAE RID: 3246
		public static readonly global::System.Windows.DependencyProperty ItemVerticalScrollBarVisibilityProperty = global::Infragistics.Windows.Controls.CarouselPanelItem.ItemVerticalScrollBarVisibilityPropertyKey.DependencyProperty;
	}
}
