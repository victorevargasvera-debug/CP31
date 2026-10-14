using System;
using System.Windows;

namespace Infragistics.Controls
{
	// Token: 0x02000056 RID: 86
	public class NavigationSettings : global::Infragistics.DependencyObjectNotifier
	{
		// Token: 0x17000116 RID: 278
		// (get) Token: 0x06000467 RID: 1127 RVA: 0x00011540 File Offset: 0x0000F740
		// (set) Token: 0x06000468 RID: 1128 RVA: 0x00011552 File Offset: 0x0000F752
		public bool AllowPan
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.Controls.NavigationSettings.AllowPanProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.NavigationSettings.AllowPanProperty, value);
			}
		}

		// Token: 0x06000469 RID: 1129 RVA: 0x00011568 File Offset: 0x0000F768
		private static void AllowPanChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.NavigationSettings navigationSettings = obj as global::Infragistics.Controls.NavigationSettings;
			if (navigationSettings != null)
			{
				navigationSettings.OnPropertyChanged("AllowPan");
			}
		}

		// Token: 0x17000117 RID: 279
		// (get) Token: 0x0600046A RID: 1130 RVA: 0x0001158A File Offset: 0x0000F78A
		// (set) Token: 0x0600046B RID: 1131 RVA: 0x0001159C File Offset: 0x0000F79C
		public bool AllowZoom
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.Controls.NavigationSettings.AllowZoomProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.NavigationSettings.AllowZoomProperty, value);
			}
		}

		// Token: 0x0600046C RID: 1132 RVA: 0x000115B0 File Offset: 0x0000F7B0
		private static void AllowZoomChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.NavigationSettings navigationSettings = obj as global::Infragistics.Controls.NavigationSettings;
			if (navigationSettings != null)
			{
				navigationSettings.OnPropertyChanged("AllowZoom");
			}
		}

		// Token: 0x040001A4 RID: 420
		public static readonly global::System.Windows.DependencyProperty AllowPanProperty = global::System.Windows.DependencyProperty.Register("AllowPan", typeof(bool), typeof(global::Infragistics.Controls.NavigationSettings), new global::System.Windows.PropertyMetadata(true, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.NavigationSettings.AllowPanChanged)));

		// Token: 0x040001A5 RID: 421
		public static readonly global::System.Windows.DependencyProperty AllowZoomProperty = global::System.Windows.DependencyProperty.Register("AllowZoom", typeof(bool), typeof(global::Infragistics.Controls.NavigationSettings), new global::System.Windows.PropertyMetadata(true, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.NavigationSettings.AllowZoomChanged)));
	}
}
