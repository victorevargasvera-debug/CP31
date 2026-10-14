using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Threading;
using Infragistics.Windows.Reporting;

namespace Infragistics.Windows.Controls
{
	// Token: 0x020000FA RID: 250
	[global::System.ComponentModel.DesignTimeVisible(false)]
	public class AutoDisabledImage : global::System.Windows.Controls.Image
	{
		// Token: 0x060008E6 RID: 2278 RVA: 0x0001F29C File Offset: 0x0001D49C
		static AutoDisabledImage()
		{
			global::System.Windows.Controls.Image.SourceProperty.OverrideMetadata(typeof(global::Infragistics.Windows.Controls.AutoDisabledImage), new global::System.Windows.FrameworkPropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.Controls.AutoDisabledImage.OnSourceChanged), new global::System.Windows.CoerceValueCallback(global::Infragistics.Windows.Controls.AutoDisabledImage.CoerceSource)));
			global::System.Windows.UIElement.IsEnabledProperty.OverrideMetadata(typeof(global::Infragistics.Windows.Controls.AutoDisabledImage), new global::System.Windows.FrameworkPropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.Controls.AutoDisabledImage.OnIsEnabledChanged)));
			global::System.Windows.UIElement.OpacityMaskProperty.OverrideMetadata(typeof(global::Infragistics.Windows.Controls.AutoDisabledImage), new global::System.Windows.FrameworkPropertyMetadata(null, new global::System.Windows.CoerceValueCallback(global::Infragistics.Windows.Controls.AutoDisabledImage.CoerceOpacityMask)));
			global::System.Windows.UIElement.OpacityProperty.OverrideMetadata(typeof(global::Infragistics.Windows.Controls.AutoDisabledImage), new global::System.Windows.FrameworkPropertyMetadata(null, new global::System.Windows.CoerceValueCallback(global::Infragistics.Windows.Controls.AutoDisabledImage.CoerceOpacity)));
		}

		// Token: 0x060008E8 RID: 2280 RVA: 0x0001F388 File Offset: 0x0001D588
		private static void OnDisabledSourceChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			if (false.Equals(d.GetValue(global::System.Windows.UIElement.IsEnabledProperty)))
			{
				((global::Infragistics.Windows.Controls.AutoDisabledImage)d).VerifySource();
			}
		}

		// Token: 0x17000170 RID: 368
		// (get) Token: 0x060008E9 RID: 2281 RVA: 0x0001F3B6 File Offset: 0x0001D5B6
		// (set) Token: 0x060008EA RID: 2282 RVA: 0x0001F3C8 File Offset: 0x0001D5C8
		[global::System.ComponentModel.Bindable(true)]
		public global::System.Windows.Media.ImageSource DisabledSource
		{
			get
			{
				return (global::System.Windows.Media.ImageSource)base.GetValue(global::Infragistics.Windows.Controls.AutoDisabledImage.DisabledSourceProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.Controls.AutoDisabledImage.DisabledSourceProperty, value);
			}
		}

		// Token: 0x060008EB RID: 2283 RVA: 0x0001F3D8 File Offset: 0x0001D5D8
		private static object CoerceOpacity(global::System.Windows.DependencyObject d, object newValue)
		{
			global::Infragistics.Windows.Controls.AutoDisabledImage autoDisabledImage = d as global::Infragistics.Windows.Controls.AutoDisabledImage;
			if (autoDisabledImage.IsInitialized && !autoDisabledImage.IsEnabled && autoDisabledImage.DisabledSource == null)
			{
				return 0.5;
			}
			return newValue;
		}

		// Token: 0x060008EC RID: 2284 RVA: 0x0001F414 File Offset: 0x0001D614
		private static object CoerceOpacityMask(global::System.Windows.DependencyObject d, object newValue)
		{
			global::Infragistics.Windows.Controls.AutoDisabledImage autoDisabledImage = d as global::Infragistics.Windows.Controls.AutoDisabledImage;
			if (autoDisabledImage.IsInitialized && newValue == null && autoDisabledImage._lastImageSource != null && autoDisabledImage.DisabledSource == null && !autoDisabledImage.IsEnabled)
			{
				return new global::System.Windows.Media.ImageBrush(autoDisabledImage._lastImageSource);
			}
			return newValue;
		}

		// Token: 0x060008ED RID: 2285 RVA: 0x0001F45C File Offset: 0x0001D65C
		private static object CoerceSource(global::System.Windows.DependencyObject d, object newValue)
		{
			global::Infragistics.Windows.Controls.AutoDisabledImage autoDisabledImage = d as global::Infragistics.Windows.Controls.AutoDisabledImage;
			autoDisabledImage._lastImageSource = (newValue as global::System.Windows.Media.ImageSource);
			if (autoDisabledImage.IsInitialized && !autoDisabledImage.IsEnabled)
			{
				object disabledSource = autoDisabledImage.DisabledSource;
				if (disabledSource != null)
				{
					return disabledSource;
				}
				global::System.Windows.Media.Imaging.BitmapSource bitmapSource = newValue as global::System.Windows.Media.Imaging.BitmapSource;
				if (bitmapSource != null)
				{
					global::System.Windows.Media.Imaging.FormatConvertedBitmap formatConvertedBitmap = new global::System.Windows.Media.Imaging.FormatConvertedBitmap(bitmapSource, global::System.Windows.Media.PixelFormats.Gray32Float, null, 1.0);
					if (bitmapSource.IsFrozen && formatConvertedBitmap.CanFreeze)
					{
						formatConvertedBitmap.Freeze();
					}
					return formatConvertedBitmap;
				}
			}
			return newValue;
		}

		// Token: 0x060008EE RID: 2286 RVA: 0x0001F4D4 File Offset: 0x0001D6D4
		private static void OnIsEnabledChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.Controls.AutoDisabledImage autoDisabledImage = d as global::Infragistics.Windows.Controls.AutoDisabledImage;
			if (autoDisabledImage.IsInitialized)
			{
				autoDisabledImage.VerifySource();
			}
		}

		// Token: 0x060008EF RID: 2287 RVA: 0x0001F4F8 File Offset: 0x0001D6F8
		private static void OnSourceChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.Controls.AutoDisabledImage autoDisabledImage = d as global::Infragistics.Windows.Controls.AutoDisabledImage;
			autoDisabledImage.CoerceValue(global::System.Windows.UIElement.OpacityProperty);
			autoDisabledImage.CoerceValue(global::System.Windows.UIElement.OpacityMaskProperty);
		}

		// Token: 0x060008F0 RID: 2288 RVA: 0x0001F522 File Offset: 0x0001D722
		private void VerifySource()
		{
			base.CoerceValue(global::System.Windows.Controls.Image.SourceProperty);
			base.CoerceValue(global::System.Windows.UIElement.OpacityProperty);
		}

		// Token: 0x060008F1 RID: 2289 RVA: 0x0001F53A File Offset: 0x0001D73A
		protected override void OnInitialized(global::System.EventArgs e)
		{
			base.OnInitialized(e);
			if (global::Infragistics.Windows.Reporting.ReportSection.GetIsInReport(this))
			{
				this.VerifySource();
				return;
			}
			base.Dispatcher.BeginInvoke(global::System.Windows.Threading.DispatcherPriority.Render, new global::Infragistics.Windows.Controls.AutoDisabledImage.MethodInvoker(this.VerifySource));
		}

		// Token: 0x04000440 RID: 1088
		private global::System.Windows.Media.ImageSource _lastImageSource;

		// Token: 0x04000441 RID: 1089
		public static readonly global::System.Windows.DependencyProperty DisabledSourceProperty = global::System.Windows.DependencyProperty.Register("DisabledSource", typeof(global::System.Windows.Media.ImageSource), typeof(global::Infragistics.Windows.Controls.AutoDisabledImage), new global::System.Windows.FrameworkPropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.Controls.AutoDisabledImage.OnDisabledSourceChanged)));

		// Token: 0x020000FB RID: 251
		// (Invoke) Token: 0x060008F3 RID: 2291
		private delegate void MethodInvoker();
	}
}
