using System;
using System.Windows;

namespace Infragistics.Controls.Grids
{
	// Token: 0x02000023 RID: 35
	public class ColumnResizingSettings : global::Infragistics.Controls.Grids.SettingsBase
	{
		// Token: 0x17000088 RID: 136
		// (get) Token: 0x060001A3 RID: 419 RVA: 0x00009E77 File Offset: 0x00008077
		// (set) Token: 0x060001A4 RID: 420 RVA: 0x00009E89 File Offset: 0x00008089
		public global::System.Windows.Style IndicatorStyle
		{
			get
			{
				return (global::System.Windows.Style)base.GetValue(global::Infragistics.Controls.Grids.ColumnResizingSettings.IndicatorStyleProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Grids.ColumnResizingSettings.IndicatorStyleProperty, value);
			}
		}

		// Token: 0x060001A5 RID: 421 RVA: 0x00009E98 File Offset: 0x00008098
		private static void IndicatorStyleChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Grids.ColumnResizingSettings columnResizingSettings = (global::Infragistics.Controls.Grids.ColumnResizingSettings)obj;
			columnResizingSettings.OnPropertyChanged("IndicatorStyle");
		}

		// Token: 0x17000089 RID: 137
		// (get) Token: 0x060001A6 RID: 422 RVA: 0x00009EB7 File Offset: 0x000080B7
		// (set) Token: 0x060001A7 RID: 423 RVA: 0x00009EC9 File Offset: 0x000080C9
		public global::Infragistics.Controls.Grids.ColumnResizingType AllowColumnResizing
		{
			get
			{
				return (global::Infragistics.Controls.Grids.ColumnResizingType)base.GetValue(global::Infragistics.Controls.Grids.ColumnResizingSettings.AllowColumnResizingTypeProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Grids.ColumnResizingSettings.AllowColumnResizingTypeProperty, value);
			}
		}

		// Token: 0x060001A8 RID: 424 RVA: 0x00009EDC File Offset: 0x000080DC
		private static void AllowColumnResizingChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Grids.ColumnResizingSettings columnResizingSettings = (global::Infragistics.Controls.Grids.ColumnResizingSettings)obj;
			columnResizingSettings.OnPropertyChanged("AllowColumnResizing");
		}

		// Token: 0x1700008A RID: 138
		// (get) Token: 0x060001A9 RID: 425 RVA: 0x00009EFB File Offset: 0x000080FB
		// (set) Token: 0x060001AA RID: 426 RVA: 0x00009F0D File Offset: 0x0000810D
		public bool AllowDoubleClickToSize
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.Controls.Grids.ColumnResizingSettings.AllowDoubleClickToSizeProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Grids.ColumnResizingSettings.AllowDoubleClickToSizeProperty, value);
			}
		}

		// Token: 0x060001AB RID: 427 RVA: 0x00009F20 File Offset: 0x00008120
		private static void AllowDoubleClickToSizeChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Grids.ColumnResizingSettings columnResizingSettings = (global::Infragistics.Controls.Grids.ColumnResizingSettings)obj;
			columnResizingSettings.OnPropertyChanged("AllowDoubleClickToSize");
		}

		// Token: 0x1700008B RID: 139
		// (get) Token: 0x060001AC RID: 428 RVA: 0x00009F3F File Offset: 0x0000813F
		// (set) Token: 0x060001AD RID: 429 RVA: 0x00009F51 File Offset: 0x00008151
		public bool AllowMultipleColumnResize
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.Controls.Grids.ColumnResizingSettings.AllowMultipleColumnResizeProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Grids.ColumnResizingSettings.AllowMultipleColumnResizeProperty, value);
			}
		}

		// Token: 0x060001AE RID: 430 RVA: 0x00009F64 File Offset: 0x00008164
		private static void AllowMultipleColumnResizeChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Grids.ColumnResizingSettings columnResizingSettings = (global::Infragistics.Controls.Grids.ColumnResizingSettings)obj;
			columnResizingSettings.OnPropertyChanged("AllowMultipleColumnResize");
		}

		// Token: 0x1700008C RID: 140
		// (get) Token: 0x060001AF RID: 431 RVA: 0x00009F83 File Offset: 0x00008183
		// (set) Token: 0x060001B0 RID: 432 RVA: 0x00009F95 File Offset: 0x00008195
		public bool AllowCellAreaResizing
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.Controls.Grids.ColumnResizingSettings.AllowCellAreaResizingProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Grids.ColumnResizingSettings.AllowCellAreaResizingProperty, value);
			}
		}

		// Token: 0x060001B1 RID: 433 RVA: 0x00009FA8 File Offset: 0x000081A8
		private static void AllowCellAreaResizingChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Grids.ColumnResizingSettings columnResizingSettings = (global::Infragistics.Controls.Grids.ColumnResizingSettings)obj;
			columnResizingSettings.OnPropertyChanged("AllowCellAreaResizing");
		}

		// Token: 0x0400006D RID: 109
		public static readonly global::System.Windows.DependencyProperty IndicatorStyleProperty = global::System.Windows.DependencyProperty.Register("IndicatorStyle", typeof(global::System.Windows.Style), typeof(global::Infragistics.Controls.Grids.ColumnResizingSettings), new global::System.Windows.PropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Grids.ColumnResizingSettings.IndicatorStyleChanged)));

		// Token: 0x0400006E RID: 110
		public static readonly global::System.Windows.DependencyProperty AllowColumnResizingTypeProperty = global::System.Windows.DependencyProperty.Register("AllowColumnResizing", typeof(global::Infragistics.Controls.Grids.ColumnResizingType), typeof(global::Infragistics.Controls.Grids.ColumnResizingSettings), new global::System.Windows.PropertyMetadata(global::Infragistics.Controls.Grids.ColumnResizingType.Immediate, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Grids.ColumnResizingSettings.AllowColumnResizingChanged)));

		// Token: 0x0400006F RID: 111
		public static readonly global::System.Windows.DependencyProperty AllowDoubleClickToSizeProperty = global::System.Windows.DependencyProperty.Register("AllowDoubleClickToSize", typeof(bool), typeof(global::Infragistics.Controls.Grids.ColumnResizingSettings), new global::System.Windows.PropertyMetadata(true, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Grids.ColumnResizingSettings.AllowDoubleClickToSizeChanged)));

		// Token: 0x04000070 RID: 112
		public static readonly global::System.Windows.DependencyProperty AllowMultipleColumnResizeProperty = global::System.Windows.DependencyProperty.Register("AllowMultipleColumnResize", typeof(bool), typeof(global::Infragistics.Controls.Grids.ColumnResizingSettings), new global::System.Windows.PropertyMetadata(true, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Grids.ColumnResizingSettings.AllowMultipleColumnResizeChanged)));

		// Token: 0x04000071 RID: 113
		public static readonly global::System.Windows.DependencyProperty AllowCellAreaResizingProperty = global::System.Windows.DependencyProperty.Register("AllowCellAreaResizing", typeof(bool), typeof(global::Infragistics.Controls.Grids.ColumnResizingSettings), new global::System.Windows.PropertyMetadata(false, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Grids.ColumnResizingSettings.AllowCellAreaResizingChanged)));
	}
}
