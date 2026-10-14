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
	// Token: 0x020000DC RID: 220
	[global::System.ComponentModel.DesignTimeVisible(false)]
	public class AutoDisabledImage : global::System.Windows.Controls.Image
	{
		// Token: 0x060007E7 RID: 2023 RVA: 0x0001B6D4 File Offset: 0x000198D4
		static AutoDisabledImage()
		{
			global::System.Windows.Controls.Image.SourceProperty.OverrideMetadata(typeof(global::Infragistics.Windows.Controls.AutoDisabledImage), new global::System.Windows.FrameworkPropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.Controls.AutoDisabledImage.OnSourceChanged), new global::System.Windows.CoerceValueCallback(global::Infragistics.Windows.Controls.AutoDisabledImage.CoerceSource)));
			global::System.Windows.UIElement.IsEnabledProperty.OverrideMetadata(typeof(global::Infragistics.Windows.Controls.AutoDisabledImage), new global::System.Windows.FrameworkPropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.Controls.AutoDisabledImage.OnIsEnabledChanged)));
			global::System.Windows.UIElement.OpacityMaskProperty.OverrideMetadata(typeof(global::Infragistics.Windows.Controls.AutoDisabledImage), new global::System.Windows.FrameworkPropertyMetadata(null, new global::System.Windows.CoerceValueCallback(global::Infragistics.Windows.Controls.AutoDisabledImage.CoerceOpacityMask)));
			global::System.Windows.UIElement.OpacityProperty.OverrideMetadata(typeof(global::Infragistics.Windows.Controls.AutoDisabledImage), new global::System.Windows.FrameworkPropertyMetadata(null, new global::System.Windows.CoerceValueCallback(global::Infragistics.Windows.Controls.AutoDisabledImage.CoerceOpacity)));
		}

		// Token: 0x060007E9 RID: 2025 RVA: 0x0001B7C0 File Offset: 0x000199C0
		private static void OnDisabledSourceChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			if (false.Equals(d.GetValue(global::System.Windows.UIElement.IsEnabledProperty)))
			{
				((global::Infragistics.Windows.Controls.AutoDisabledImage)d).VerifySource();
			}
		}

		// Token: 0x17000158 RID: 344
		// (get) Token: 0x060007EA RID: 2026 RVA: 0x0001B7EE File Offset: 0x000199EE
		// (set) Token: 0x060007EB RID: 2027 RVA: 0x0001B800 File Offset: 0x00019A00
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

		// Token: 0x060007EC RID: 2028 RVA: 0x0001B810 File Offset: 0x00019A10
		private static object CoerceOpacity(global::System.Windows.DependencyObject d, object newValue)
		{
			global::Infragistics.Windows.Controls.AutoDisabledImage autoDisabledImage = d as global::Infragistics.Windows.Controls.AutoDisabledImage;
			if (autoDisabledImage.IsInitialized && !autoDisabledImage.IsEnabled && autoDisabledImage.DisabledSource == null)
			{
				return 0.5;
			}
			return newValue;
		}

		// Token: 0x060007ED RID: 2029 RVA: 0x0001B84C File Offset: 0x00019A4C
		private static object CoerceOpacityMask(global::System.Windows.DependencyObject d, object newValue)
		{
			global::Infragistics.Windows.Controls.AutoDisabledImage autoDisabledImage = d as global::Infragistics.Windows.Controls.AutoDisabledImage;
			if (autoDisabledImage.IsInitialized && newValue == null && autoDisabledImage._lastImageSource != null && autoDisabledImage.DisabledSource == null && !autoDisabledImage.IsEnabled)
			{
				return new global::System.Windows.Media.ImageBrush(autoDisabledImage._lastImageSource);
			}
			return newValue;
		}

		// Token: 0x060007EE RID: 2030 RVA: 0x0001B894 File Offset: 0x00019A94
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

		// Token: 0x060007EF RID: 2031 RVA: 0x0001B90C File Offset: 0x00019B0C
		private static void OnIsEnabledChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.Controls.AutoDisabledImage autoDisabledImage = d as global::Infragistics.Windows.Controls.AutoDisabledImage;
			if (autoDisabledImage.IsInitialized)
			{
				autoDisabledImage.VerifySource();
			}
		}

		// Token: 0x060007F0 RID: 2032 RVA: 0x0001B930 File Offset: 0x00019B30
		private static void OnSourceChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.Controls.AutoDisabledImage autoDisabledImage = d as global::Infragistics.Windows.Controls.AutoDisabledImage;
			autoDisabledImage.CoerceValue(global::System.Windows.UIElement.OpacityProperty);
			autoDisabledImage.CoerceValue(global::System.Windows.UIElement.OpacityMaskProperty);
		}

		// Token: 0x060007F1 RID: 2033 RVA: 0x0001B95A File Offset: 0x00019B5A
		private void VerifySource()
		{
			base.CoerceValue(global::System.Windows.Controls.Image.SourceProperty);
			base.CoerceValue(global::System.Windows.UIElement.OpacityProperty);
		}

		// Token: 0x060007F2 RID: 2034 RVA: 0x0001B972 File Offset: 0x00019B72
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

		// Token: 0x0400038D RID: 909
		private global::System.Windows.Media.ImageSource _lastImageSource;

		// Token: 0x0400038E RID: 910
		public static readonly global::System.Windows.DependencyProperty DisabledSourceProperty = global::System.Windows.DependencyProperty.Register("DisabledSource", typeof(global::System.Windows.Media.ImageSource), typeof(global::Infragistics.Windows.Controls.AutoDisabledImage), new global::System.Windows.FrameworkPropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.Controls.AutoDisabledImage.OnDisabledSourceChanged)));

		// Token: 0x020000DD RID: 221
		// (Invoke) Token: 0x060007F4 RID: 2036
		private delegate void MethodInvoker();
	}
}
