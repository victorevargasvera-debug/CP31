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
	// Token: 0x0200022A RID: 554
	[global::System.ComponentModel.DesignTimeVisible(false)]
	public class CarouselPanelItem : global::System.Windows.Controls.ListBoxItem
	{
		// Token: 0x0600170B RID: 5899 RVA: 0x0005A760 File Offset: 0x00058960
		static CarouselPanelItem()
		{
			global::System.Windows.FrameworkElement.DefaultStyleKeyProperty.OverrideMetadata(typeof(global::Infragistics.Windows.Controls.CarouselPanelItem), new global::System.Windows.FrameworkPropertyMetadata(typeof(global::Infragistics.Windows.Controls.CarouselPanelItem)));
		}

		// Token: 0x0600170C RID: 5900 RVA: 0x0005A932 File Offset: 0x00058B32
		public CarouselPanelItem()
		{
		}

		// Token: 0x0600170D RID: 5901 RVA: 0x0005A970 File Offset: 0x00058B70
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

		// Token: 0x1700052F RID: 1327
		// (get) Token: 0x0600170E RID: 5902 RVA: 0x0005AA0C File Offset: 0x00058C0C
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

		// Token: 0x17000530 RID: 1328
		// (get) Token: 0x0600170F RID: 5903 RVA: 0x0005AA3E File Offset: 0x00058C3E
		internal global::Infragistics.Windows.Controls.XamCarouselPanel CarouselPanel
		{
			get
			{
				return this._carouselPanel;
			}
		}

		// Token: 0x17000531 RID: 1329
		// (get) Token: 0x06001710 RID: 5904 RVA: 0x0005AA46 File Offset: 0x00058C46
		// (set) Token: 0x06001711 RID: 5905 RVA: 0x0005AA4E File Offset: 0x00058C4E
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

		// Token: 0x17000532 RID: 1330
		// (get) Token: 0x06001712 RID: 5906 RVA: 0x0005AA57 File Offset: 0x00058C57
		// (set) Token: 0x06001713 RID: 5907 RVA: 0x0005AA5F File Offset: 0x00058C5F
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

		// Token: 0x17000533 RID: 1331
		// (get) Token: 0x06001714 RID: 5908 RVA: 0x0005AA68 File Offset: 0x00058C68
		internal bool IsPathLocationUnset
		{
			get
			{
				return double.IsNegativeInfinity(this._pathLocationPercent);
			}
		}

		// Token: 0x17000534 RID: 1332
		// (get) Token: 0x06001715 RID: 5909 RVA: 0x0005AA75 File Offset: 0x00058C75
		// (set) Token: 0x06001716 RID: 5910 RVA: 0x0005AA7D File Offset: 0x00058C7D
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

		// Token: 0x17000535 RID: 1333
		// (get) Token: 0x06001717 RID: 5911 RVA: 0x0005AA86 File Offset: 0x00058C86
		// (set) Token: 0x06001718 RID: 5912 RVA: 0x0005AA8E File Offset: 0x00058C8E
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

		// Token: 0x17000536 RID: 1334
		// (get) Token: 0x06001719 RID: 5913 RVA: 0x0005AA97 File Offset: 0x00058C97
		// (set) Token: 0x0600171A RID: 5914 RVA: 0x0005AA9F File Offset: 0x00058C9F
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

		// Token: 0x17000537 RID: 1335
		// (get) Token: 0x0600171B RID: 5915 RVA: 0x0005AAA8 File Offset: 0x00058CA8
		// (set) Token: 0x0600171C RID: 5916 RVA: 0x0005AAB0 File Offset: 0x00058CB0
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

		// Token: 0x0600171D RID: 5917 RVA: 0x0005AABC File Offset: 0x00058CBC
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

		// Token: 0x17000538 RID: 1336
		// (get) Token: 0x0600171E RID: 5918 RVA: 0x0005AB3A File Offset: 0x00058D3A
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.ReadOnly(true)]
		public bool AutoScaleItemContentsToFit
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.Windows.Controls.CarouselPanelItem.AutoScaleItemContentsToFitProperty);
			}
		}

		// Token: 0x17000539 RID: 1337
		// (get) Token: 0x0600171F RID: 5919 RVA: 0x0005AB4C File Offset: 0x00058D4C
		[global::System.ComponentModel.ReadOnly(true)]
		[global::System.ComponentModel.Bindable(true)]
		public bool IsListContinuous
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.Windows.Controls.CarouselPanelItem.IsListContinuousProperty);
			}
		}

		// Token: 0x1700053A RID: 1338
		// (get) Token: 0x06001720 RID: 5920 RVA: 0x0005AB5E File Offset: 0x00058D5E
		[global::System.ComponentModel.ReadOnly(true)]
		[global::System.ComponentModel.Bindable(true)]
		public bool IsFirstItem
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.Windows.Controls.CarouselPanelItem.IsFirstItemProperty);
			}
		}

		// Token: 0x1700053B RID: 1339
		// (get) Token: 0x06001721 RID: 5921 RVA: 0x0005AB70 File Offset: 0x00058D70
		[global::System.ComponentModel.ReadOnly(true)]
		[global::System.ComponentModel.Bindable(true)]
		public bool IsLastItem
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.Windows.Controls.CarouselPanelItem.IsLastItemProperty);
			}
		}

		// Token: 0x1700053C RID: 1340
		// (get) Token: 0x06001722 RID: 5922 RVA: 0x0005AB82 File Offset: 0x00058D82
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.ReadOnly(true)]
		public global::System.Windows.Controls.ScrollBarVisibility ItemHorizontalScrollBarVisibility
		{
			get
			{
				return (global::System.Windows.Controls.ScrollBarVisibility)base.GetValue(global::Infragistics.Windows.Controls.CarouselPanelItem.ItemHorizontalScrollBarVisibilityProperty);
			}
		}

		// Token: 0x1700053D RID: 1341
		// (get) Token: 0x06001723 RID: 5923 RVA: 0x0005AB94 File Offset: 0x00058D94
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.ReadOnly(true)]
		public global::System.Windows.Controls.ScrollBarVisibility ItemVerticalScrollBarVisibility
		{
			get
			{
				return (global::System.Windows.Controls.ScrollBarVisibility)base.GetValue(global::Infragistics.Windows.Controls.CarouselPanelItem.ItemVerticalScrollBarVisibilityProperty);
			}
		}

		// Token: 0x06001724 RID: 5924 RVA: 0x0005ABA6 File Offset: 0x00058DA6
		public virtual void ClearContainerForItem(object item)
		{
			global::System.Windows.Data.BindingOperations.ClearAllBindings(this);
		}

		// Token: 0x06001725 RID: 5925 RVA: 0x0005ABAE File Offset: 0x00058DAE
		public virtual void PrepareContainerForItem(object item)
		{
		}

		// Token: 0x06001726 RID: 5926 RVA: 0x0005ABB0 File Offset: 0x00058DB0
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

		// Token: 0x06001727 RID: 5927 RVA: 0x0005AC70 File Offset: 0x00058E70
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

		// Token: 0x04000B36 RID: 2870
		private double _pathLocationPercent = double.NegativeInfinity;

		// Token: 0x04000B37 RID: 2871
		private double _pathTargetPercent;

		// Token: 0x04000B38 RID: 2872
		private double _velocity;

		// Token: 0x04000B39 RID: 2873
		private global::System.Windows.Point _currentLocation = new global::System.Windows.Point(0.0, 0.0);

		// Token: 0x04000B3A RID: 2874
		private double _currentZindexEffectStopValue;

		// Token: 0x04000B3B RID: 2875
		private global::Infragistics.Windows.Controls.XamCarouselPanel _carouselPanel;

		// Token: 0x04000B3C RID: 2876
		private global::System.Windows.Media.MatrixTransform _matrixTransform;

		// Token: 0x04000B3D RID: 2877
		private global::System.Windows.Media.ScaleTransform _scaleTransform;

		// Token: 0x04000B3E RID: 2878
		private global::System.Windows.Media.SkewTransform _skewTransform;

		// Token: 0x04000B3F RID: 2879
		private bool _needsArrange = true;

		// Token: 0x04000B40 RID: 2880
		internal static readonly global::System.Windows.DependencyProperty ViewSettingsVersionProperty = global::System.Windows.DependencyProperty.Register("ViewSettingsVersion", typeof(int), typeof(global::Infragistics.Windows.Controls.CarouselPanelItem), new global::System.Windows.FrameworkPropertyMetadata(0, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.Controls.CarouselPanelItem.OnViewSettingsVersionChanged)));

		// Token: 0x04000B41 RID: 2881
		private static readonly global::System.Windows.DependencyPropertyKey AutoScaleItemContentsToFitPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("AutoScaleItemContentsToFit", typeof(bool), typeof(global::Infragistics.Windows.Controls.CarouselPanelItem), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox));

		// Token: 0x04000B42 RID: 2882
		public static readonly global::System.Windows.DependencyProperty AutoScaleItemContentsToFitProperty = global::Infragistics.Windows.Controls.CarouselPanelItem.AutoScaleItemContentsToFitPropertyKey.DependencyProperty;

		// Token: 0x04000B43 RID: 2883
		private static readonly global::System.Windows.DependencyPropertyKey IsListContinuousPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("IsListContinuous", typeof(bool), typeof(global::Infragistics.Windows.Controls.CarouselPanelItem), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox));

		// Token: 0x04000B44 RID: 2884
		public static readonly global::System.Windows.DependencyProperty IsListContinuousProperty = global::Infragistics.Windows.Controls.CarouselPanelItem.IsListContinuousPropertyKey.DependencyProperty;

		// Token: 0x04000B45 RID: 2885
		internal static readonly global::System.Windows.DependencyPropertyKey IsFirstItemPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("IsFirstItem", typeof(bool), typeof(global::Infragistics.Windows.Controls.CarouselPanelItem), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox));

		// Token: 0x04000B46 RID: 2886
		public static readonly global::System.Windows.DependencyProperty IsFirstItemProperty = global::Infragistics.Windows.Controls.CarouselPanelItem.IsFirstItemPropertyKey.DependencyProperty;

		// Token: 0x04000B47 RID: 2887
		internal static readonly global::System.Windows.DependencyPropertyKey IsLastItemPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("IsLastItem", typeof(bool), typeof(global::Infragistics.Windows.Controls.CarouselPanelItem), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox));

		// Token: 0x04000B48 RID: 2888
		public static readonly global::System.Windows.DependencyProperty IsLastItemProperty = global::Infragistics.Windows.Controls.CarouselPanelItem.IsLastItemPropertyKey.DependencyProperty;

		// Token: 0x04000B49 RID: 2889
		private static readonly global::System.Windows.DependencyPropertyKey ItemHorizontalScrollBarVisibilityPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("ItemHorizontalScrollBarVisibility", typeof(global::System.Windows.Controls.ScrollBarVisibility), typeof(global::Infragistics.Windows.Controls.CarouselPanelItem), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.ScrollBarVisibilityAutoBox));

		// Token: 0x04000B4A RID: 2890
		public static readonly global::System.Windows.DependencyProperty ItemHorizontalScrollBarVisibilityProperty = global::Infragistics.Windows.Controls.CarouselPanelItem.ItemHorizontalScrollBarVisibilityPropertyKey.DependencyProperty;

		// Token: 0x04000B4B RID: 2891
		private static readonly global::System.Windows.DependencyPropertyKey ItemVerticalScrollBarVisibilityPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("ItemVerticalScrollBarVisibility", typeof(global::System.Windows.Controls.ScrollBarVisibility), typeof(global::Infragistics.Windows.Controls.CarouselPanelItem), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.ScrollBarVisibilityAutoBox));

		// Token: 0x04000B4C RID: 2892
		public static readonly global::System.Windows.DependencyProperty ItemVerticalScrollBarVisibilityProperty = global::Infragistics.Windows.Controls.CarouselPanelItem.ItemVerticalScrollBarVisibilityPropertyKey.DependencyProperty;
	}
}
