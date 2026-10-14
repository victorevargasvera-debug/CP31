using System;
using System.Windows;

namespace Infragistics.Controls.Grids
{
	// Token: 0x02000062 RID: 98
	public class DeferredScrollingSettings : global::Infragistics.Controls.Grids.SettingsBase
	{
		// Token: 0x170000FD RID: 253
		// (get) Token: 0x06000358 RID: 856 RVA: 0x0000FCC8 File Offset: 0x0000DEC8
		// (set) Token: 0x06000359 RID: 857 RVA: 0x0000FCDA File Offset: 0x0000DEDA
		public global::Infragistics.Controls.Grids.DeferredScrollingType AllowDeferredScrolling
		{
			get
			{
				return (global::Infragistics.Controls.Grids.DeferredScrollingType)base.GetValue(global::Infragistics.Controls.Grids.DeferredScrollingSettings.AllowDeferredScrollingProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Grids.DeferredScrollingSettings.AllowDeferredScrollingProperty, value);
			}
		}

		// Token: 0x0600035A RID: 858 RVA: 0x0000FCED File Offset: 0x0000DEED
		private static void AllowDeferredScrollingChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
		}

		// Token: 0x170000FE RID: 254
		// (get) Token: 0x0600035B RID: 859 RVA: 0x0000FCEF File Offset: 0x0000DEEF
		// (set) Token: 0x0600035C RID: 860 RVA: 0x0000FD01 File Offset: 0x0000DF01
		public global::System.Windows.DataTemplate DeferredScrollTemplate
		{
			get
			{
				return (global::System.Windows.DataTemplate)base.GetValue(global::Infragistics.Controls.Grids.DeferredScrollingSettings.DeferredScrollTemplateProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Grids.DeferredScrollingSettings.DeferredScrollTemplateProperty, value);
			}
		}

		// Token: 0x170000FF RID: 255
		// (get) Token: 0x0600035D RID: 861 RVA: 0x0000FD0F File Offset: 0x0000DF0F
		// (set) Token: 0x0600035E RID: 862 RVA: 0x0000FD21 File Offset: 0x0000DF21
		public string DefaultColumnKey
		{
			get
			{
				return (string)base.GetValue(global::Infragistics.Controls.Grids.DeferredScrollingSettings.DefaultColumnKeyProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Grids.DeferredScrollingSettings.DefaultColumnKeyProperty, value);
			}
		}

		// Token: 0x0600035F RID: 863 RVA: 0x0000FD30 File Offset: 0x0000DF30
		private static void DefaultColumnKeyChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Grids.DeferredScrollingSettings deferredScrollingSettings = (global::Infragistics.Controls.Grids.DeferredScrollingSettings)obj;
			deferredScrollingSettings.OnPropertyChanged("DefaultColumnKey");
		}

		// Token: 0x17000100 RID: 256
		// (get) Token: 0x06000360 RID: 864 RVA: 0x0000FD4F File Offset: 0x0000DF4F
		// (set) Token: 0x06000361 RID: 865 RVA: 0x0000FD61 File Offset: 0x0000DF61
		public global::System.Windows.DataTemplate GroupByDeferredScrollTemplate
		{
			get
			{
				return (global::System.Windows.DataTemplate)base.GetValue(global::Infragistics.Controls.Grids.DeferredScrollingSettings.GroupByDeferredScrollTemplateProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Grids.DeferredScrollingSettings.GroupByDeferredScrollTemplateProperty, value);
			}
		}

		// Token: 0x06000362 RID: 866 RVA: 0x0000FD70 File Offset: 0x0000DF70
		private static void GroupByDeferredScrollTemplateChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Grids.DeferredScrollingSettings deferredScrollingSettings = (global::Infragistics.Controls.Grids.DeferredScrollingSettings)obj;
			deferredScrollingSettings.OnPropertyChanged("GroupByDeferredScrollTemplate");
		}

		// Token: 0x040000D1 RID: 209
		public static readonly global::System.Windows.DependencyProperty AllowDeferredScrollingProperty = global::System.Windows.DependencyProperty.Register("AllowDeferredScrolling", typeof(global::Infragistics.Controls.Grids.DeferredScrollingType), typeof(global::Infragistics.Controls.Grids.DeferredScrollingSettings), new global::System.Windows.PropertyMetadata(global::Infragistics.Controls.Grids.DeferredScrollingType.None, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Grids.DeferredScrollingSettings.AllowDeferredScrollingChanged)));

		// Token: 0x040000D2 RID: 210
		public static readonly global::System.Windows.DependencyProperty DeferredScrollTemplateProperty = global::System.Windows.DependencyProperty.Register("DeferredScrollTemplate", typeof(global::System.Windows.DataTemplate), typeof(global::Infragistics.Controls.Grids.DeferredScrollingSettings), null);

		// Token: 0x040000D3 RID: 211
		public static readonly global::System.Windows.DependencyProperty DefaultColumnKeyProperty = global::System.Windows.DependencyProperty.Register("DefaultColumnKey", typeof(string), typeof(global::Infragistics.Controls.Grids.DeferredScrollingSettings), new global::System.Windows.PropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Grids.DeferredScrollingSettings.DefaultColumnKeyChanged)));

		// Token: 0x040000D4 RID: 212
		public static readonly global::System.Windows.DependencyProperty GroupByDeferredScrollTemplateProperty = global::System.Windows.DependencyProperty.Register("GroupByDeferredScrollTemplate", typeof(global::System.Windows.DataTemplate), typeof(global::Infragistics.Controls.Grids.DeferredScrollingSettings), new global::System.Windows.PropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Grids.DeferredScrollingSettings.GroupByDeferredScrollTemplateChanged)));
	}
}
