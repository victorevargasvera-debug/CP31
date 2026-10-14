using System;
using System.ComponentModel;
using System.Windows;
using Infragistics.Controls.Grids.Primitives;

namespace Infragistics.Controls.Grids
{
	// Token: 0x0200000C RID: 12
	public class AddNewRowSettings : global::Infragistics.Controls.Grids.EditingSettingsBase
	{
		// Token: 0x1700003F RID: 63
		// (get) Token: 0x060000B4 RID: 180 RVA: 0x0000766D File Offset: 0x0000586D
		// (set) Token: 0x060000B5 RID: 181 RVA: 0x0000767F File Offset: 0x0000587F
		public global::Infragistics.Controls.Grids.AddNewRowLocation AllowAddNewRow
		{
			get
			{
				return (global::Infragistics.Controls.Grids.AddNewRowLocation)base.GetValue(global::Infragistics.Controls.Grids.AddNewRowSettings.AllowAddNewRowProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Grids.AddNewRowSettings.AllowAddNewRowProperty, value);
			}
		}

		// Token: 0x060000B6 RID: 182 RVA: 0x00007694 File Offset: 0x00005894
		private static void AllowAddNewRowChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Grids.AddNewRowSettings addNewRowSettings = (global::Infragistics.Controls.Grids.AddNewRowSettings)obj;
			addNewRowSettings.OnPropertyChanged("AllowAddNewRow");
		}

		// Token: 0x17000040 RID: 64
		// (get) Token: 0x060000B7 RID: 183 RVA: 0x000076B3 File Offset: 0x000058B3
		// (set) Token: 0x060000B8 RID: 184 RVA: 0x000076C5 File Offset: 0x000058C5
		public global::System.Windows.Style Style
		{
			get
			{
				return (global::System.Windows.Style)base.GetValue(global::Infragistics.Controls.Grids.AddNewRowSettings.StyleProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Grids.AddNewRowSettings.StyleProperty, value);
			}
		}

		// Token: 0x060000B9 RID: 185 RVA: 0x000076D4 File Offset: 0x000058D4
		private static void StyleChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Grids.AddNewRowSettings addNewRowSettings = (global::Infragistics.Controls.Grids.AddNewRowSettings)obj;
			addNewRowSettings.OnPropertyChanged("Style");
		}

		// Token: 0x17000041 RID: 65
		// (get) Token: 0x060000BA RID: 186 RVA: 0x000076F3 File Offset: 0x000058F3
		// (set) Token: 0x060000BB RID: 187 RVA: 0x00007705 File Offset: 0x00005905
		public global::System.Windows.Style ExpansionIndicatorStyle
		{
			get
			{
				return (global::System.Windows.Style)base.GetValue(global::Infragistics.Controls.Grids.AddNewRowSettings.ExpansionIndicatorStyleProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Grids.AddNewRowSettings.ExpansionIndicatorStyleProperty, value);
			}
		}

		// Token: 0x060000BC RID: 188 RVA: 0x00007714 File Offset: 0x00005914
		private static void ExpansionIndicatorStyleChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Grids.AddNewRowSettings addNewRowSettings = (global::Infragistics.Controls.Grids.AddNewRowSettings)obj;
			if (addNewRowSettings.Grid != null)
			{
				addNewRowSettings.Grid.ResetPanelRows();
			}
			addNewRowSettings.OnPropertyChanged("ExpansionIndicatorStyle");
		}

		// Token: 0x17000042 RID: 66
		// (get) Token: 0x060000BD RID: 189 RVA: 0x00007746 File Offset: 0x00005946
		// (set) Token: 0x060000BE RID: 190 RVA: 0x00007758 File Offset: 0x00005958
		public global::System.Windows.Style RowSelectorStyle
		{
			get
			{
				return (global::System.Windows.Style)base.GetValue(global::Infragistics.Controls.Grids.AddNewRowSettings.RowSelectorStyleProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Grids.AddNewRowSettings.RowSelectorStyleProperty, value);
			}
		}

		// Token: 0x060000BF RID: 191 RVA: 0x00007768 File Offset: 0x00005968
		private static void RowSelectorStyleChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Grids.AddNewRowSettings addNewRowSettings = (global::Infragistics.Controls.Grids.AddNewRowSettings)obj;
			addNewRowSettings.OnPropertyChanged("RowSelectorStyle");
		}

		// Token: 0x17000043 RID: 67
		// (get) Token: 0x060000C0 RID: 192 RVA: 0x00007787 File Offset: 0x00005987
		// (set) Token: 0x060000C1 RID: 193 RVA: 0x00007799 File Offset: 0x00005999
		[global::System.ComponentModel.TypeConverter(typeof(global::Infragistics.Controls.Grids.Primitives.RowHeightTypeConverter))]
		public global::Infragistics.Controls.Grids.RowHeight AddNewRowHeight
		{
			get
			{
				return (global::Infragistics.Controls.Grids.RowHeight)base.GetValue(global::Infragistics.Controls.Grids.AddNewRowSettings.AddNewRowHeightProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Grids.AddNewRowSettings.AddNewRowHeightProperty, value);
			}
		}

		// Token: 0x060000C2 RID: 194 RVA: 0x000077AC File Offset: 0x000059AC
		private static void AddNewRowHeightChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Grids.AddNewRowSettings addNewRowSettings = (global::Infragistics.Controls.Grids.AddNewRowSettings)obj;
			addNewRowSettings.OnPropertyChanged("AddNewRowHeight");
		}

		// Token: 0x0400002D RID: 45
		public static readonly global::System.Windows.DependencyProperty AllowAddNewRowProperty = global::System.Windows.DependencyProperty.Register("AllowAddNewRow", typeof(global::Infragistics.Controls.Grids.AddNewRowLocation), typeof(global::Infragistics.Controls.Grids.AddNewRowSettings), new global::System.Windows.PropertyMetadata(global::Infragistics.Controls.Grids.AddNewRowLocation.None, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Grids.AddNewRowSettings.AllowAddNewRowChanged)));

		// Token: 0x0400002E RID: 46
		public static readonly global::System.Windows.DependencyProperty StyleProperty = global::System.Windows.DependencyProperty.Register("Style", typeof(global::System.Windows.Style), typeof(global::Infragistics.Controls.Grids.AddNewRowSettings), new global::System.Windows.PropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Grids.AddNewRowSettings.StyleChanged)));

		// Token: 0x0400002F RID: 47
		public static readonly global::System.Windows.DependencyProperty ExpansionIndicatorStyleProperty = global::System.Windows.DependencyProperty.Register("ExpansionIndicatorStyle", typeof(global::System.Windows.Style), typeof(global::Infragistics.Controls.Grids.AddNewRowSettings), new global::System.Windows.PropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Grids.AddNewRowSettings.ExpansionIndicatorStyleChanged)));

		// Token: 0x04000030 RID: 48
		public static readonly global::System.Windows.DependencyProperty RowSelectorStyleProperty = global::System.Windows.DependencyProperty.Register("RowSelectorStyle", typeof(global::System.Windows.Style), typeof(global::Infragistics.Controls.Grids.AddNewRowSettings), new global::System.Windows.PropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Grids.AddNewRowSettings.RowSelectorStyleChanged)));

		// Token: 0x04000031 RID: 49
		public static readonly global::System.Windows.DependencyProperty AddNewRowHeightProperty = global::System.Windows.DependencyProperty.Register("AddNewRowHeight", typeof(global::Infragistics.Controls.Grids.RowHeight), typeof(global::Infragistics.Controls.Grids.AddNewRowSettings), new global::System.Windows.PropertyMetadata(global::Infragistics.Controls.Grids.RowHeight.SizeToLargestCell, global::Infragistics.DependencyPropertyUtilities.CreateTypeConverterCallbackWrapper<global::Infragistics.Controls.Grids.RowHeight>(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Grids.AddNewRowSettings.AddNewRowHeightChanged))));
	}
}
