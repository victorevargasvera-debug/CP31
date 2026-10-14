using System;
using System.Windows;

namespace Infragistics.Controls.Grids
{
	// Token: 0x0200001D RID: 29
	public class ColumnChooserSettings : global::Infragistics.Controls.Grids.StyleSettingsBase
	{
		// Token: 0x0600014D RID: 333 RVA: 0x00008F18 File Offset: 0x00007118
		public ColumnChooserSettings()
		{
			this.HiddenColumnIndicatorToolTipText = global::Infragistics.SRGrid.GetString("ColumnChooserToolTipText");
			this.ColumnChooserDisplayText = global::Infragistics.SRGrid.GetString("ColumnChooserDisplayText");
		}

		// Token: 0x17000068 RID: 104
		// (get) Token: 0x0600014E RID: 334 RVA: 0x00008F40 File Offset: 0x00007140
		// (set) Token: 0x0600014F RID: 335 RVA: 0x00008F52 File Offset: 0x00007152
		public bool AllowHiddenColumnIndicator
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.Controls.Grids.ColumnChooserSettings.AllowHiddenColumnIndicatorProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Grids.ColumnChooserSettings.AllowHiddenColumnIndicatorProperty, value);
			}
		}

		// Token: 0x06000150 RID: 336 RVA: 0x00008F68 File Offset: 0x00007168
		private static void AllowHiddenColumnIndicatorChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Grids.ColumnChooserSettings columnChooserSettings = (global::Infragistics.Controls.Grids.ColumnChooserSettings)obj;
			columnChooserSettings.OnPropertyChanged("AllowHiddenColumnIndicator");
		}

		// Token: 0x17000069 RID: 105
		// (get) Token: 0x06000151 RID: 337 RVA: 0x00008F87 File Offset: 0x00007187
		// (set) Token: 0x06000152 RID: 338 RVA: 0x00008F99 File Offset: 0x00007199
		public bool AllowHideColumnIcon
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.Controls.Grids.ColumnChooserSettings.AllowHideColumnIconProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Grids.ColumnChooserSettings.AllowHideColumnIconProperty, value);
			}
		}

		// Token: 0x06000153 RID: 339 RVA: 0x00008FAC File Offset: 0x000071AC
		private static void AllowHideColumnIconChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Grids.ColumnChooserSettings columnChooserSettings = (global::Infragistics.Controls.Grids.ColumnChooserSettings)obj;
			columnChooserSettings.OnPropertyChanged("AllowHideColumnIcon");
		}

		// Token: 0x1700006A RID: 106
		// (get) Token: 0x06000154 RID: 340 RVA: 0x00008FCB File Offset: 0x000071CB
		// (set) Token: 0x06000155 RID: 341 RVA: 0x00008FDD File Offset: 0x000071DD
		public string HiddenColumnIndicatorToolTipText
		{
			get
			{
				return (string)base.GetValue(global::Infragistics.Controls.Grids.ColumnChooserSettings.HiddenColumnIndicatorToolTipTextProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Grids.ColumnChooserSettings.HiddenColumnIndicatorToolTipTextProperty, value);
			}
		}

		// Token: 0x06000156 RID: 342 RVA: 0x00008FEB File Offset: 0x000071EB
		private static void HiddenColumnIndicatorToolTipTextChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
		}

		// Token: 0x1700006B RID: 107
		// (get) Token: 0x06000157 RID: 343 RVA: 0x00008FED File Offset: 0x000071ED
		// (set) Token: 0x06000158 RID: 344 RVA: 0x00008FFF File Offset: 0x000071FF
		public string ColumnChooserDisplayText
		{
			get
			{
				return (string)base.GetValue(global::Infragistics.Controls.Grids.ColumnChooserSettings.ColumnChooserDisplayTextProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Grids.ColumnChooserSettings.ColumnChooserDisplayTextProperty, value);
			}
		}

		// Token: 0x06000159 RID: 345 RVA: 0x00009010 File Offset: 0x00007210
		private static void ColumnChooserDisplayTextChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Grids.ColumnChooserSettings columnChooserSettings = (global::Infragistics.Controls.Grids.ColumnChooserSettings)obj;
			if (columnChooserSettings.Grid != null)
			{
				columnChooserSettings.Grid.ColumnChooserDialog.Invalidate();
			}
		}

		// Token: 0x1700006C RID: 108
		// (get) Token: 0x0600015A RID: 346 RVA: 0x0000903C File Offset: 0x0000723C
		// (set) Token: 0x0600015B RID: 347 RVA: 0x0000904E File Offset: 0x0000724E
		public global::System.Windows.Point? InitialLocation
		{
			get
			{
				return (global::System.Windows.Point?)base.GetValue(global::Infragistics.Controls.Grids.ColumnChooserSettings.InitialLocationProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Grids.ColumnChooserSettings.InitialLocationProperty, value);
			}
		}

		// Token: 0x0600015C RID: 348 RVA: 0x00009061 File Offset: 0x00007261
		private static void InitialLocationChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
		}

		// Token: 0x0600015D RID: 349 RVA: 0x00009063 File Offset: 0x00007263
		protected override void OnStyleChanged()
		{
			if (base.Grid != null)
			{
				base.Grid.ColumnChooserDialog.Style = base.Style;
				base.Grid.ColumnChooserDialog.Invalidate();
			}
		}

		// Token: 0x1700006D RID: 109
		// (get) Token: 0x0600015E RID: 350 RVA: 0x00009093 File Offset: 0x00007293
		// (set) Token: 0x0600015F RID: 351 RVA: 0x000090A5 File Offset: 0x000072A5
		public bool AllowColumnMoving
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.Controls.Grids.ColumnChooserSettings.AllowColumnMovingProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Grids.ColumnChooserSettings.AllowColumnMovingProperty, value);
			}
		}

		// Token: 0x06000160 RID: 352 RVA: 0x000090B8 File Offset: 0x000072B8
		private static void AllowColumnMovingChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Grids.ColumnChooserSettings columnChooserSettings = (global::Infragistics.Controls.Grids.ColumnChooserSettings)obj;
			columnChooserSettings.OnPropertyChanged("AllowColumnMoving");
		}

		// Token: 0x04000053 RID: 83
		public static readonly global::System.Windows.DependencyProperty AllowHiddenColumnIndicatorProperty = global::System.Windows.DependencyProperty.Register("AllowHiddenColumnIndicator", typeof(bool), typeof(global::Infragistics.Controls.Grids.ColumnChooserSettings), new global::System.Windows.PropertyMetadata(false, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Grids.ColumnChooserSettings.AllowHiddenColumnIndicatorChanged)));

		// Token: 0x04000054 RID: 84
		public static readonly global::System.Windows.DependencyProperty AllowHideColumnIconProperty = global::System.Windows.DependencyProperty.Register("AllowHideColumnIcon", typeof(bool), typeof(global::Infragistics.Controls.Grids.ColumnChooserSettings), new global::System.Windows.PropertyMetadata(false, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Grids.ColumnChooserSettings.AllowHideColumnIconChanged)));

		// Token: 0x04000055 RID: 85
		public static readonly global::System.Windows.DependencyProperty HiddenColumnIndicatorToolTipTextProperty = global::System.Windows.DependencyProperty.Register("HiddenColumnIndicatorToolTipText", typeof(string), typeof(global::Infragistics.Controls.Grids.ColumnChooserSettings), new global::System.Windows.PropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Grids.ColumnChooserSettings.HiddenColumnIndicatorToolTipTextChanged)));

		// Token: 0x04000056 RID: 86
		public static readonly global::System.Windows.DependencyProperty ColumnChooserDisplayTextProperty = global::System.Windows.DependencyProperty.Register("ColumnChooserDisplayText", typeof(string), typeof(global::Infragistics.Controls.Grids.ColumnChooserSettings), new global::System.Windows.PropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Grids.ColumnChooserSettings.ColumnChooserDisplayTextChanged)));

		// Token: 0x04000057 RID: 87
		public static readonly global::System.Windows.DependencyProperty InitialLocationProperty = global::System.Windows.DependencyProperty.Register("InitialLocation", typeof(global::System.Windows.Point?), typeof(global::Infragistics.Controls.Grids.ColumnChooserSettings), new global::System.Windows.PropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Grids.ColumnChooserSettings.InitialLocationChanged)));

		// Token: 0x04000058 RID: 88
		public static readonly global::System.Windows.DependencyProperty AllowColumnMovingProperty = global::System.Windows.DependencyProperty.Register("AllowColumnMoving", typeof(bool), typeof(global::Infragistics.Controls.Grids.ColumnChooserSettings), new global::System.Windows.PropertyMetadata(true, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Grids.ColumnChooserSettings.AllowColumnMovingChanged)));
	}
}
