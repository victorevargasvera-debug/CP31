using System;
using System.ComponentModel;
using System.Windows;

namespace Infragistics.Controls.Grids
{
	// Token: 0x0200001F RID: 31
	public class ColumnChooserSettingsOverride : global::Infragistics.Controls.Grids.StyleSettingsOverrideBase
	{
		// Token: 0x17000070 RID: 112
		// (get) Token: 0x06000168 RID: 360 RVA: 0x000092FB File Offset: 0x000074FB
		// (set) Token: 0x06000169 RID: 361 RVA: 0x0000930D File Offset: 0x0000750D
		[global::System.ComponentModel.TypeConverter(typeof(global::System.Windows.NullableBoolConverter))]
		public bool? AllowHiddenColumnIndicator
		{
			get
			{
				return (bool?)base.GetValue(global::Infragistics.Controls.Grids.ColumnChooserSettingsOverride.AllowHiddenColumnIndicatorProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Grids.ColumnChooserSettingsOverride.AllowHiddenColumnIndicatorProperty, value);
			}
		}

		// Token: 0x0600016A RID: 362 RVA: 0x00009320 File Offset: 0x00007520
		private static void AllowHiddenColumnIndicatorChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Grids.ColumnChooserSettingsOverride columnChooserSettingsOverride = (global::Infragistics.Controls.Grids.ColumnChooserSettingsOverride)obj;
			columnChooserSettingsOverride.OnPropertyChanged("AllowHiddenColumnIndicator");
		}

		// Token: 0x17000071 RID: 113
		// (get) Token: 0x0600016B RID: 363 RVA: 0x00009340 File Offset: 0x00007540
		public bool AllowHiddenColumnIndicatorResolved
		{
			get
			{
				if (this.AllowHiddenColumnIndicator != null)
				{
					return this.AllowHiddenColumnIndicator.Value;
				}
				if (this.SettingsObject != null)
				{
					return ((global::Infragistics.Controls.Grids.ColumnChooserSettings)this.SettingsObject).AllowHiddenColumnIndicator;
				}
				return (bool)global::Infragistics.Controls.Grids.ColumnChooserSettings.AllowHiddenColumnIndicatorProperty.GetMetadata(typeof(global::Infragistics.Controls.Grids.ColumnChooserSettings)).DefaultValue;
			}
		}

		// Token: 0x17000072 RID: 114
		// (get) Token: 0x0600016C RID: 364 RVA: 0x000093A3 File Offset: 0x000075A3
		// (set) Token: 0x0600016D RID: 365 RVA: 0x000093B5 File Offset: 0x000075B5
		[global::System.ComponentModel.TypeConverter(typeof(global::System.Windows.NullableBoolConverter))]
		public bool? AllowHideColumnIcon
		{
			get
			{
				return (bool?)base.GetValue(global::Infragistics.Controls.Grids.ColumnChooserSettingsOverride.AllowHideColumnIconProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Grids.ColumnChooserSettingsOverride.AllowHideColumnIconProperty, value);
			}
		}

		// Token: 0x0600016E RID: 366 RVA: 0x000093C8 File Offset: 0x000075C8
		private static void AllowHideColumnIconChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Grids.ColumnChooserSettingsOverride columnChooserSettingsOverride = (global::Infragistics.Controls.Grids.ColumnChooserSettingsOverride)obj;
			columnChooserSettingsOverride.OnPropertyChanged("AllowHideColumnIcon");
		}

		// Token: 0x17000073 RID: 115
		// (get) Token: 0x0600016F RID: 367 RVA: 0x000093E8 File Offset: 0x000075E8
		public bool AllowHideColumnIconResolved
		{
			get
			{
				if (this.AllowHideColumnIcon != null)
				{
					return this.AllowHideColumnIcon.Value;
				}
				if (this.SettingsObject != null)
				{
					return ((global::Infragistics.Controls.Grids.ColumnChooserSettings)this.SettingsObject).AllowHideColumnIcon;
				}
				return (bool)global::Infragistics.Controls.Grids.ColumnChooserSettings.AllowHideColumnIconProperty.GetMetadata(typeof(global::Infragistics.Controls.Grids.ColumnChooserSettings)).DefaultValue;
			}
		}

		// Token: 0x17000074 RID: 116
		// (get) Token: 0x06000170 RID: 368 RVA: 0x0000944C File Offset: 0x0000764C
		protected override global::Infragistics.Controls.Grids.SettingsBase SettingsObject
		{
			get
			{
				global::Infragistics.Controls.Grids.SettingsBase result = null;
				if (base.ColumnLayout != null && base.ColumnLayout.Grid != null)
				{
					result = base.ColumnLayout.Grid.ColumnChooserSettings;
				}
				return result;
			}
		}

		// Token: 0x0400005A RID: 90
		public static readonly global::System.Windows.DependencyProperty AllowHiddenColumnIndicatorProperty = global::System.Windows.DependencyProperty.Register("AllowHiddenColumnIndicator", typeof(bool?), typeof(global::Infragistics.Controls.Grids.ColumnChooserSettingsOverride), new global::System.Windows.PropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Grids.ColumnChooserSettingsOverride.AllowHiddenColumnIndicatorChanged)));

		// Token: 0x0400005B RID: 91
		public static readonly global::System.Windows.DependencyProperty AllowHideColumnIconProperty = global::System.Windows.DependencyProperty.Register("AllowHideColumnIcon", typeof(bool?), typeof(global::Infragistics.Controls.Grids.ColumnChooserSettingsOverride), new global::System.Windows.PropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Grids.ColumnChooserSettingsOverride.AllowHideColumnIconChanged)));
	}
}
