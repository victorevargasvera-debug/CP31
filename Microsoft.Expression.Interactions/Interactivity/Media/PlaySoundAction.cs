using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Interactivity;

namespace Microsoft.Expression.Interactivity.Media
{
	// Token: 0x02000023 RID: 35
	public class PlaySoundAction : global::System.Windows.Interactivity.TriggerAction<global::System.Windows.DependencyObject>
	{
		// Token: 0x1700004B RID: 75
		// (get) Token: 0x06000164 RID: 356 RVA: 0x000086FB File Offset: 0x000068FB
		// (set) Token: 0x06000165 RID: 357 RVA: 0x0000870D File Offset: 0x0000690D
		public global::System.Uri Source
		{
			get
			{
				return (global::System.Uri)base.GetValue(global::Microsoft.Expression.Interactivity.Media.PlaySoundAction.SourceProperty);
			}
			set
			{
				base.SetValue(global::Microsoft.Expression.Interactivity.Media.PlaySoundAction.SourceProperty, value);
			}
		}

		// Token: 0x1700004C RID: 76
		// (get) Token: 0x06000166 RID: 358 RVA: 0x0000871B File Offset: 0x0000691B
		// (set) Token: 0x06000167 RID: 359 RVA: 0x0000872D File Offset: 0x0000692D
		public double Volume
		{
			get
			{
				return (double)base.GetValue(global::Microsoft.Expression.Interactivity.Media.PlaySoundAction.VolumeProperty);
			}
			set
			{
				base.SetValue(global::Microsoft.Expression.Interactivity.Media.PlaySoundAction.VolumeProperty, value);
			}
		}

		// Token: 0x06000168 RID: 360 RVA: 0x00008740 File Offset: 0x00006940
		protected virtual void SetMediaElementProperties(global::System.Windows.Controls.MediaElement mediaElement)
		{
			if (mediaElement != null)
			{
				mediaElement.Source = this.Source;
				mediaElement.Volume = this.Volume;
			}
		}

		// Token: 0x06000169 RID: 361 RVA: 0x0000879C File Offset: 0x0000699C
		protected override void Invoke(object parameter)
		{
			if (this.Source == null || base.AssociatedObject == null)
			{
				return;
			}
			global::System.Windows.Controls.Primitives.Popup popup = new global::System.Windows.Controls.Primitives.Popup();
			global::System.Windows.Controls.MediaElement mediaElement = new global::System.Windows.Controls.MediaElement();
			popup.Child = mediaElement;
			mediaElement.Visibility = global::System.Windows.Visibility.Collapsed;
			this.SetMediaElementProperties(mediaElement);
			mediaElement.MediaEnded += delegate(object A_1, global::System.Windows.RoutedEventArgs A_2)
			{
				popup.Child = null;
				popup.IsOpen = false;
			};
			mediaElement.MediaFailed += delegate(object A_1, global::System.Windows.ExceptionRoutedEventArgs A_2)
			{
				popup.Child = null;
				popup.IsOpen = false;
			};
			popup.IsOpen = true;
		}

		// Token: 0x04000074 RID: 116
		public static readonly global::System.Windows.DependencyProperty SourceProperty = global::System.Windows.DependencyProperty.Register("Source", typeof(global::System.Uri), typeof(global::Microsoft.Expression.Interactivity.Media.PlaySoundAction), null);

		// Token: 0x04000075 RID: 117
		public static readonly global::System.Windows.DependencyProperty VolumeProperty = global::System.Windows.DependencyProperty.Register("Volume", typeof(double), typeof(global::Microsoft.Expression.Interactivity.Media.PlaySoundAction), new global::System.Windows.PropertyMetadata(0.5));
	}
}
