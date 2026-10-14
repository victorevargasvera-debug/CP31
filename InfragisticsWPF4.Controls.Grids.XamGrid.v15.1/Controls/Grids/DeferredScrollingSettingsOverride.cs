using System;
using System.Windows;

namespace Infragistics.Controls.Grids
{
	// Token: 0x02000063 RID: 99
	public class DeferredScrollingSettingsOverride : global::Infragistics.Controls.Grids.SettingsOverrideBase
	{
		// Token: 0x17000101 RID: 257
		// (get) Token: 0x06000365 RID: 869 RVA: 0x0000FE70 File Offset: 0x0000E070
		protected override global::Infragistics.Controls.Grids.SettingsBase SettingsObject
		{
			get
			{
				global::Infragistics.Controls.Grids.SettingsBase result = null;
				if (base.ColumnLayout != null && base.ColumnLayout.Grid != null)
				{
					result = base.ColumnLayout.Grid.DeferredScrollingSettings;
				}
				return result;
			}
		}

		// Token: 0x17000102 RID: 258
		// (get) Token: 0x06000366 RID: 870 RVA: 0x0000FEA6 File Offset: 0x0000E0A6
		// (set) Token: 0x06000367 RID: 871 RVA: 0x0000FEB8 File Offset: 0x0000E0B8
		public global::System.Windows.DataTemplate DeferredScrollTemplate
		{
			get
			{
				return (global::System.Windows.DataTemplate)base.GetValue(global::Infragistics.Controls.Grids.DeferredScrollingSettingsOverride.DeferredScrollTemplateProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Grids.DeferredScrollingSettingsOverride.DeferredScrollTemplateProperty, value);
			}
		}

		// Token: 0x17000103 RID: 259
		// (get) Token: 0x06000368 RID: 872 RVA: 0x0000FEC6 File Offset: 0x0000E0C6
		public global::System.Windows.DataTemplate DeferredScrollTemplateResolved
		{
			get
			{
				if (this.DeferredScrollTemplate == null && this.SettingsObject != null)
				{
					return ((global::Infragistics.Controls.Grids.DeferredScrollingSettings)this.SettingsObject).DeferredScrollTemplate;
				}
				return this.DeferredScrollTemplate;
			}
		}

		// Token: 0x17000104 RID: 260
		// (get) Token: 0x06000369 RID: 873 RVA: 0x0000FEEF File Offset: 0x0000E0EF
		// (set) Token: 0x0600036A RID: 874 RVA: 0x0000FF01 File Offset: 0x0000E101
		public string DefaultColumnKey
		{
			get
			{
				return (string)base.GetValue(global::Infragistics.Controls.Grids.DeferredScrollingSettingsOverride.DefaultColumnKeyProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Grids.DeferredScrollingSettingsOverride.DefaultColumnKeyProperty, value);
			}
		}

		// Token: 0x0600036B RID: 875 RVA: 0x0000FF10 File Offset: 0x0000E110
		private static void DefaultColumnKeyChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Grids.DeferredScrollingSettingsOverride deferredScrollingSettingsOverride = (global::Infragistics.Controls.Grids.DeferredScrollingSettingsOverride)obj;
			deferredScrollingSettingsOverride.OnPropertyChanged("DefaultColumnKey");
		}

		// Token: 0x17000105 RID: 261
		// (get) Token: 0x0600036C RID: 876 RVA: 0x0000FF2F File Offset: 0x0000E12F
		public string DefaultColumnKeyResolved
		{
			get
			{
				if (this.DefaultColumnKey == null && this.SettingsObject != null)
				{
					return ((global::Infragistics.Controls.Grids.DeferredScrollingSettings)this.SettingsObject).DefaultColumnKey;
				}
				return this.DefaultColumnKey;
			}
		}

		// Token: 0x17000106 RID: 262
		// (get) Token: 0x0600036D RID: 877 RVA: 0x0000FF58 File Offset: 0x0000E158
		// (set) Token: 0x0600036E RID: 878 RVA: 0x0000FF6A File Offset: 0x0000E16A
		public global::System.Windows.DataTemplate GroupByDeferredScrollTemplate
		{
			get
			{
				return (global::System.Windows.DataTemplate)base.GetValue(global::Infragistics.Controls.Grids.DeferredScrollingSettingsOverride.GroupByDeferredScrollTemplateProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Grids.DeferredScrollingSettingsOverride.GroupByDeferredScrollTemplateProperty, value);
			}
		}

		// Token: 0x0600036F RID: 879 RVA: 0x0000FF78 File Offset: 0x0000E178
		private static void GroupByDeferredScrollTemplateChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Grids.DeferredScrollingSettingsOverride deferredScrollingSettingsOverride = (global::Infragistics.Controls.Grids.DeferredScrollingSettingsOverride)obj;
			deferredScrollingSettingsOverride.OnPropertyChanged("GroupByDeferredScrollTemplate");
		}

		// Token: 0x17000107 RID: 263
		// (get) Token: 0x06000370 RID: 880 RVA: 0x0000FF97 File Offset: 0x0000E197
		public global::System.Windows.DataTemplate GroupByDeferredScrollTemplateResolved
		{
			get
			{
				if (this.GroupByDeferredScrollTemplate == null && this.SettingsObject != null)
				{
					return ((global::Infragistics.Controls.Grids.DeferredScrollingSettings)this.SettingsObject).GroupByDeferredScrollTemplate;
				}
				return this.GroupByDeferredScrollTemplate;
			}
		}

		// Token: 0x040000D5 RID: 213
		public static readonly global::System.Windows.DependencyProperty DeferredScrollTemplateProperty = global::System.Windows.DependencyProperty.Register("DeferredScrollTemplate", typeof(global::System.Windows.DataTemplate), typeof(global::Infragistics.Controls.Grids.DeferredScrollingSettingsOverride), null);

		// Token: 0x040000D6 RID: 214
		public static readonly global::System.Windows.DependencyProperty DefaultColumnKeyProperty = global::System.Windows.DependencyProperty.Register("DefaultColumnKey", typeof(string), typeof(global::Infragistics.Controls.Grids.DeferredScrollingSettingsOverride), new global::System.Windows.PropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Grids.DeferredScrollingSettingsOverride.DefaultColumnKeyChanged)));

		// Token: 0x040000D7 RID: 215
		public static readonly global::System.Windows.DependencyProperty GroupByDeferredScrollTemplateProperty = global::System.Windows.DependencyProperty.Register("GroupByDeferredScrollTemplate", typeof(global::System.Windows.DataTemplate), typeof(global::Infragistics.Controls.Grids.DeferredScrollingSettingsOverride), new global::System.Windows.PropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Grids.DeferredScrollingSettingsOverride.GroupByDeferredScrollTemplateChanged)));
	}
}
