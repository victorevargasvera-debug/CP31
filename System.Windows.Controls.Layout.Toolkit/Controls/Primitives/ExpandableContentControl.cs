using System;
using System.Globalization;
using System.Windows.Controls.Properties;
using System.Windows.Media;

namespace System.Windows.Controls.Primitives
{
	// Token: 0x0200000D RID: 13
	[global::System.Windows.TemplatePart(Name = "ContentSite", Type = typeof(global::System.Windows.Controls.ContentPresenter))]
	public class ExpandableContentControl : global::System.Windows.Controls.ContentControl
	{
		// Token: 0x1700002D RID: 45
		// (get) Token: 0x060000D5 RID: 213 RVA: 0x00006090 File Offset: 0x00004290
		// (set) Token: 0x060000D6 RID: 214 RVA: 0x00006098 File Offset: 0x00004298
		private global::System.Windows.Controls.ContentPresenter ContentSite
		{
			get
			{
				return this._contentSite;
			}
			set
			{
				if (this._contentSite != null)
				{
					this._contentSite.SizeChanged -= this.OnContentSiteSizeChanged;
				}
				this._contentSite = value;
				if (this._contentSite != null)
				{
					this._contentSite.SizeChanged += this.OnContentSiteSizeChanged;
				}
			}
		}

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x060000D7 RID: 215 RVA: 0x000060EA File Offset: 0x000042EA
		// (set) Token: 0x060000D8 RID: 216 RVA: 0x000060FC File Offset: 0x000042FC
		public global::System.Windows.Controls.ExpandDirection RevealMode
		{
			get
			{
				return (global::System.Windows.Controls.ExpandDirection)base.GetValue(global::System.Windows.Controls.Primitives.ExpandableContentControl.RevealModeProperty);
			}
			set
			{
				base.SetValue(global::System.Windows.Controls.Primitives.ExpandableContentControl.RevealModeProperty, value);
			}
		}

		// Token: 0x060000D9 RID: 217 RVA: 0x00006110 File Offset: 0x00004310
		private static void OnRevealModePropertyChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::System.Windows.Controls.Primitives.ExpandableContentControl expandableContentControl = (global::System.Windows.Controls.Primitives.ExpandableContentControl)d;
			global::System.Windows.Controls.ExpandDirection expandDirection = (global::System.Windows.Controls.ExpandDirection)e.NewValue;
			if (expandDirection != global::System.Windows.Controls.ExpandDirection.Down && expandDirection != global::System.Windows.Controls.ExpandDirection.Left && expandDirection != global::System.Windows.Controls.ExpandDirection.Right && expandDirection != global::System.Windows.Controls.ExpandDirection.Up)
			{
				expandableContentControl.RevealMode = (global::System.Windows.Controls.ExpandDirection)e.OldValue;
				string message = string.Format(global::System.Globalization.CultureInfo.InvariantCulture, global::System.Windows.Controls.Properties.Resources.Expander_OnExpandDirectionPropertyChanged_InvalidValue, new object[]
				{
					expandDirection
				});
				throw new global::System.ArgumentException(message, "e");
			}
			expandableContentControl.SetNonRevealDimension();
			expandableContentControl.SetRevealDimension();
		}

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x060000DA RID: 218 RVA: 0x0000618B File Offset: 0x0000438B
		private bool IsVerticalRevealMode
		{
			get
			{
				return this.RevealMode == global::System.Windows.Controls.ExpandDirection.Down || this.RevealMode == global::System.Windows.Controls.ExpandDirection.Up;
			}
		}

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x060000DB RID: 219 RVA: 0x000061A0 File Offset: 0x000043A0
		private bool IsHorizontalRevealMode
		{
			get
			{
				return this.RevealMode == global::System.Windows.Controls.ExpandDirection.Left || this.RevealMode == global::System.Windows.Controls.ExpandDirection.Right;
			}
		}

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x060000DC RID: 220 RVA: 0x000061B6 File Offset: 0x000043B6
		// (set) Token: 0x060000DD RID: 221 RVA: 0x000061C8 File Offset: 0x000043C8
		public double Percentage
		{
			get
			{
				return (double)base.GetValue(global::System.Windows.Controls.Primitives.ExpandableContentControl.PercentageProperty);
			}
			set
			{
				base.SetValue(global::System.Windows.Controls.Primitives.ExpandableContentControl.PercentageProperty, value);
			}
		}

		// Token: 0x060000DE RID: 222 RVA: 0x000061DC File Offset: 0x000043DC
		private static object CoercePercentageProperty(global::System.Windows.DependencyObject d, object baseValue)
		{
			object result = baseValue;
			global::System.Windows.Controls.Primitives.ExpandableContentControl expandableContentControl = d as global::System.Windows.Controls.Primitives.ExpandableContentControl;
			if (expandableContentControl != null && expandableContentControl.calculatePercentage != null)
			{
				if (double.IsNaN(expandableContentControl.calculatePercentage.Value))
				{
					result = global::System.Windows.Controls.Primitives.ExpandableContentControl.CalculatePercentage(expandableContentControl, expandableContentControl.TargetSize);
				}
				else
				{
					result = expandableContentControl.calculatePercentage.Value;
				}
				expandableContentControl.calculatePercentage = null;
			}
			return result;
		}

		// Token: 0x060000DF RID: 223 RVA: 0x00006248 File Offset: 0x00004448
		private static void OnPercentagePropertyChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::System.Windows.Controls.Primitives.ExpandableContentControl expandableContentControl = (global::System.Windows.Controls.Primitives.ExpandableContentControl)d;
			expandableContentControl.SetRevealDimension();
		}

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x060000E0 RID: 224 RVA: 0x00006262 File Offset: 0x00004462
		// (set) Token: 0x060000E1 RID: 225 RVA: 0x00006274 File Offset: 0x00004474
		public global::System.Windows.Size TargetSize
		{
			get
			{
				return (global::System.Windows.Size)base.GetValue(global::System.Windows.Controls.Primitives.ExpandableContentControl.TargetSizeProperty);
			}
			set
			{
				base.SetValue(global::System.Windows.Controls.Primitives.ExpandableContentControl.TargetSizeProperty, value);
			}
		}

		// Token: 0x060000E2 RID: 226 RVA: 0x00006288 File Offset: 0x00004488
		private static void OnTargetSizePropertyChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::System.Windows.Controls.Primitives.ExpandableContentControl expandableContentControl = (global::System.Windows.Controls.Primitives.ExpandableContentControl)d;
			global::System.Windows.Size size = (global::System.Windows.Size)e.NewValue;
			expandableContentControl.RecalculatePercentage(double.NaN);
		}

		// Token: 0x14000006 RID: 6
		// (add) Token: 0x060000E3 RID: 227 RVA: 0x000062B8 File Offset: 0x000044B8
		// (remove) Token: 0x060000E4 RID: 228 RVA: 0x000062D1 File Offset: 0x000044D1
		public event global::System.Windows.SizeChangedEventHandler ContentSizeChanged;

		// Token: 0x060000E5 RID: 229 RVA: 0x000062EC File Offset: 0x000044EC
		protected override global::System.Windows.Size MeasureOverride(global::System.Windows.Size availableSize)
		{
			if (this.ContentSite != null)
			{
				global::System.Windows.Size desiredSize = availableSize;
				if (this.Percentage != 1.0)
				{
					desiredSize = this.CalculateDesiredContentSize();
				}
				this.MeasureContent(desiredSize);
				return this.ContentSite.DesiredSize;
			}
			return new global::System.Windows.Size(0.0, 0.0);
		}

		// Token: 0x060000E6 RID: 230 RVA: 0x00006345 File Offset: 0x00004545
		internal void MeasureContent(global::System.Windows.Size desiredSize)
		{
			if (this.ContentSite != null)
			{
				this.ContentSite.Measure(desiredSize);
			}
		}

		// Token: 0x060000E7 RID: 231 RVA: 0x0000635C File Offset: 0x0000455C
		internal global::System.Windows.Size CalculateDesiredContentSize()
		{
			global::System.Windows.Size targetSize = this.TargetSize;
			if (targetSize.Width.Equals(double.NaN))
			{
				targetSize.Width = double.PositiveInfinity;
			}
			if (targetSize.Height.Equals(double.NaN))
			{
				targetSize.Height = double.PositiveInfinity;
			}
			return targetSize;
		}

		// Token: 0x060000E8 RID: 232 RVA: 0x000063C8 File Offset: 0x000045C8
		protected override global::System.Windows.Size ArrangeOverride(global::System.Windows.Size finalSize)
		{
			if (this.ContentSite == null)
			{
				return finalSize;
			}
			global::System.Windows.Size targetSize = this.TargetSize;
			if (targetSize.Width.Equals(double.NaN))
			{
				targetSize.Width = finalSize.Width;
			}
			if (targetSize.Height.Equals(double.NaN))
			{
				targetSize.Height = finalSize.Height;
			}
			global::System.Windows.Rect finalRect = new global::System.Windows.Rect(new global::System.Windows.Point(0.0, 0.0), targetSize);
			this.ContentSite.Arrange(finalRect);
			global::System.Windows.Size size = new global::System.Windows.Size(this.IsHorizontalRevealMode ? base.Width : finalSize.Width, this.IsVerticalRevealMode ? base.Height : finalSize.Height);
			if (double.IsNaN(size.Width))
			{
				size.Width = finalSize.Width;
			}
			if (double.IsNaN(size.Height))
			{
				size.Height = finalSize.Height;
			}
			this.UpdateClip(size);
			return size;
		}

		// Token: 0x060000E9 RID: 233 RVA: 0x000064D8 File Offset: 0x000046D8
		private void UpdateClip(global::System.Windows.Size arrangeSize)
		{
			if (base.Clip != this._clippingRectangle)
			{
				base.Clip = this._clippingRectangle;
			}
			this._clippingRectangle.Rect = new global::System.Windows.Rect(0.0, 0.0, arrangeSize.Width, arrangeSize.Height);
		}

		// Token: 0x060000EA RID: 234 RVA: 0x0000652F File Offset: 0x0000472F
		internal void RecalculatePercentage(global::System.Windows.Size value)
		{
			this.Percentage = global::System.Windows.Controls.Primitives.ExpandableContentControl.CalculatePercentage(this, value);
		}

		// Token: 0x060000EB RID: 235 RVA: 0x0000653E File Offset: 0x0000473E
		internal void RecalculatePercentage(double percentage)
		{
			this.calculatePercentage = new double?(percentage);
			base.CoerceValue(global::System.Windows.Controls.Primitives.ExpandableContentControl.PercentageProperty);
		}

		// Token: 0x060000EC RID: 236 RVA: 0x00006558 File Offset: 0x00004758
		private static double CalculatePercentage(global::System.Windows.Controls.Primitives.ExpandableContentControl expandableContentControl, global::System.Windows.Size value)
		{
			double result = 0.0;
			if (expandableContentControl.ContentSite != null)
			{
				if (expandableContentControl.IsVerticalRevealMode)
				{
					result = expandableContentControl.ActualHeight / (double.IsNaN(value.Height) ? expandableContentControl.ContentSite.DesiredSize.Height : value.Height);
				}
				else if (expandableContentControl.IsHorizontalRevealMode)
				{
					result = expandableContentControl.ActualWidth / (double.IsNaN(value.Width) ? expandableContentControl.ContentSite.DesiredSize.Width : value.Width);
				}
			}
			return result;
		}

		// Token: 0x060000ED RID: 237 RVA: 0x000065F0 File Offset: 0x000047F0
		private void SetRevealDimension()
		{
			if (this.ContentSite == null)
			{
				return;
			}
			if (this.IsHorizontalRevealMode)
			{
				double width = this.TargetSize.Width;
				if (double.IsNaN(width))
				{
					width = this.ContentSite.DesiredSize.Width;
				}
				base.Width = this.Percentage * width;
			}
			if (this.IsVerticalRevealMode)
			{
				double height = this.TargetSize.Height;
				if (double.IsNaN(height))
				{
					height = this.ContentSite.DesiredSize.Height;
				}
				base.Height = this.Percentage * height;
			}
		}

		// Token: 0x060000EE RID: 238 RVA: 0x0000668C File Offset: 0x0000488C
		private void SetNonRevealDimension()
		{
			if (this.IsHorizontalRevealMode)
			{
				base.Height = this.TargetSize.Height;
			}
			if (this.IsVerticalRevealMode)
			{
				base.Width = this.TargetSize.Width;
			}
		}

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x060000EF RID: 239 RVA: 0x000066D1 File Offset: 0x000048D1
		internal global::System.Windows.Size RelevantContentSize
		{
			get
			{
				return new global::System.Windows.Size(this.IsHorizontalRevealMode ? base.Width : 0.0, this.IsVerticalRevealMode ? base.Height : 0.0);
			}
		}

		// Token: 0x060000F0 RID: 240 RVA: 0x0000670C File Offset: 0x0000490C
		static ExpandableContentControl()
		{
			global::System.Windows.FrameworkElement.DefaultStyleKeyProperty.OverrideMetadata(typeof(global::System.Windows.Controls.Primitives.ExpandableContentControl), new global::System.Windows.FrameworkPropertyMetadata(typeof(global::System.Windows.Controls.Primitives.ExpandableContentControl)));
		}

		// Token: 0x060000F1 RID: 241 RVA: 0x00006814 File Offset: 0x00004A14
		public ExpandableContentControl()
		{
			this._clippingRectangle = new global::System.Windows.Media.RectangleGeometry();
			base.Clip = this._clippingRectangle;
		}

		// Token: 0x060000F2 RID: 242 RVA: 0x00006833 File Offset: 0x00004A33
		public override void OnApplyTemplate()
		{
			this.ContentSite = (base.GetTemplateChild("ContentSite") as global::System.Windows.Controls.ContentPresenter);
			this.SetRevealDimension();
			this.SetNonRevealDimension();
		}

		// Token: 0x060000F3 RID: 243 RVA: 0x00006858 File Offset: 0x00004A58
		private void OnContentSiteSizeChanged(object sender, global::System.Windows.SizeChangedEventArgs e)
		{
			global::System.Windows.SizeChangedEventHandler contentSizeChanged = this.ContentSizeChanged;
			if (contentSizeChanged != null)
			{
				contentSizeChanged(this, e);
			}
		}

		// Token: 0x04000044 RID: 68
		private const string ElementContentSiteName = "ContentSite";

		// Token: 0x04000045 RID: 69
		private readonly global::System.Windows.Media.RectangleGeometry _clippingRectangle;

		// Token: 0x04000046 RID: 70
		private global::System.Windows.Controls.ContentPresenter _contentSite;

		// Token: 0x04000047 RID: 71
		public static readonly global::System.Windows.DependencyProperty RevealModeProperty = global::System.Windows.DependencyProperty.Register("RevealMode", typeof(global::System.Windows.Controls.ExpandDirection), typeof(global::System.Windows.Controls.Primitives.ExpandableContentControl), new global::System.Windows.PropertyMetadata(global::System.Windows.Controls.ExpandDirection.Down, new global::System.Windows.PropertyChangedCallback(global::System.Windows.Controls.Primitives.ExpandableContentControl.OnRevealModePropertyChanged)));

		// Token: 0x04000048 RID: 72
		private double? calculatePercentage;

		// Token: 0x04000049 RID: 73
		public static readonly global::System.Windows.DependencyProperty PercentageProperty = global::System.Windows.DependencyProperty.Register("Percentage", typeof(double), typeof(global::System.Windows.Controls.Primitives.ExpandableContentControl), new global::System.Windows.FrameworkPropertyMetadata(0.0, new global::System.Windows.PropertyChangedCallback(global::System.Windows.Controls.Primitives.ExpandableContentControl.OnPercentagePropertyChanged), new global::System.Windows.CoerceValueCallback(global::System.Windows.Controls.Primitives.ExpandableContentControl.CoercePercentageProperty)));

		// Token: 0x0400004A RID: 74
		public static readonly global::System.Windows.DependencyProperty TargetSizeProperty = global::System.Windows.DependencyProperty.Register("TargetSize", typeof(global::System.Windows.Size), typeof(global::System.Windows.Controls.Primitives.ExpandableContentControl), new global::System.Windows.PropertyMetadata(new global::System.Windows.Size(double.NaN, double.NaN), new global::System.Windows.PropertyChangedCallback(global::System.Windows.Controls.Primitives.ExpandableContentControl.OnTargetSizePropertyChanged)));
	}
}
