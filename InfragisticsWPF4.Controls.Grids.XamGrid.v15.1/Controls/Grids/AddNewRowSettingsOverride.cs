using System;
using System.ComponentModel;
using System.Windows;
using Infragistics.Controls.Grids.Primitives;

namespace Infragistics.Controls.Grids
{
	// Token: 0x0200000F RID: 15
	public class AddNewRowSettingsOverride : global::Infragistics.Controls.Grids.EditingSettingsBaseOverride
	{
		// Token: 0x1700004F RID: 79
		// (get) Token: 0x060000DD RID: 221 RVA: 0x00007CA8 File Offset: 0x00005EA8
		protected override global::Infragistics.Controls.Grids.SettingsBase SettingsObject
		{
			get
			{
				global::Infragistics.Controls.Grids.SettingsBase result = null;
				if (base.ColumnLayout != null && base.ColumnLayout.Grid != null)
				{
					result = base.ColumnLayout.Grid.AddNewRowSettings;
				}
				return result;
			}
		}

		// Token: 0x17000050 RID: 80
		// (get) Token: 0x060000DE RID: 222 RVA: 0x00007CDE File Offset: 0x00005EDE
		// (set) Token: 0x060000DF RID: 223 RVA: 0x00007CF0 File Offset: 0x00005EF0
		[global::System.ComponentModel.TypeConverter(typeof(global::Infragistics.NullableEnumTypeConverter<global::Infragistics.Controls.Grids.AddNewRowLocation>))]
		public global::Infragistics.Controls.Grids.AddNewRowLocation? AllowAddNewRow
		{
			get
			{
				return (global::Infragistics.Controls.Grids.AddNewRowLocation?)base.GetValue(global::Infragistics.Controls.Grids.AddNewRowSettingsOverride.AllowAddNewRowProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Grids.AddNewRowSettingsOverride.AllowAddNewRowProperty, value);
			}
		}

		// Token: 0x060000E0 RID: 224 RVA: 0x00007D04 File Offset: 0x00005F04
		private static void AllowAddNewRowChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Grids.AddNewRowSettingsOverride addNewRowSettingsOverride = (global::Infragistics.Controls.Grids.AddNewRowSettingsOverride)obj;
			addNewRowSettingsOverride.OnPropertyChanged("AllowAddNewRow");
		}

		// Token: 0x17000051 RID: 81
		// (get) Token: 0x060000E1 RID: 225 RVA: 0x00007D24 File Offset: 0x00005F24
		public global::Infragistics.Controls.Grids.AddNewRowLocation AllowAddNewRowResolved
		{
			get
			{
				if (this.AllowAddNewRow != null)
				{
					return this.AllowAddNewRow.Value;
				}
				if (this.SettingsObject != null)
				{
					return ((global::Infragistics.Controls.Grids.AddNewRowSettings)this.SettingsObject).AllowAddNewRow;
				}
				return (global::Infragistics.Controls.Grids.AddNewRowLocation)global::Infragistics.Controls.Grids.AddNewRowSettings.AllowAddNewRowProperty.GetMetadata(typeof(global::Infragistics.Controls.Grids.AddNewRowSettings)).DefaultValue;
			}
		}

		// Token: 0x17000052 RID: 82
		// (get) Token: 0x060000E2 RID: 226 RVA: 0x00007D87 File Offset: 0x00005F87
		// (set) Token: 0x060000E3 RID: 227 RVA: 0x00007D99 File Offset: 0x00005F99
		public global::System.Windows.Style ExpansionIndicatorStyle
		{
			get
			{
				return (global::System.Windows.Style)base.GetValue(global::Infragistics.Controls.Grids.AddNewRowSettingsOverride.ExpansionIndicatorStyleProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Grids.AddNewRowSettingsOverride.ExpansionIndicatorStyleProperty, value);
			}
		}

		// Token: 0x060000E4 RID: 228 RVA: 0x00007DA8 File Offset: 0x00005FA8
		private static void ExpansionIndicatorStyleChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Grids.AddNewRowSettingsOverride addNewRowSettingsOverride = (global::Infragistics.Controls.Grids.AddNewRowSettingsOverride)obj;
			if (addNewRowSettingsOverride.ColumnLayout != null && addNewRowSettingsOverride.ColumnLayout.Grid != null)
			{
				addNewRowSettingsOverride.ColumnLayout.Grid.ResetPanelRows();
			}
			addNewRowSettingsOverride.OnPropertyChanged("ExpansionIndicatorStyle");
		}

		// Token: 0x17000053 RID: 83
		// (get) Token: 0x060000E5 RID: 229 RVA: 0x00007DEC File Offset: 0x00005FEC
		public global::System.Windows.Style ExpansionIndicatorStyleResolved
		{
			get
			{
				if (this.ExpansionIndicatorStyle == null && this.SettingsObject != null)
				{
					return ((global::Infragistics.Controls.Grids.AddNewRowSettings)this.SettingsObject).ExpansionIndicatorStyle;
				}
				return this.ExpansionIndicatorStyle;
			}
		}

		// Token: 0x17000054 RID: 84
		// (get) Token: 0x060000E6 RID: 230 RVA: 0x00007E15 File Offset: 0x00006015
		// (set) Token: 0x060000E7 RID: 231 RVA: 0x00007E27 File Offset: 0x00006027
		public global::System.Windows.Style Style
		{
			get
			{
				return (global::System.Windows.Style)base.GetValue(global::Infragistics.Controls.Grids.AddNewRowSettingsOverride.StyleProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Grids.AddNewRowSettingsOverride.StyleProperty, value);
			}
		}

		// Token: 0x060000E8 RID: 232 RVA: 0x00007E38 File Offset: 0x00006038
		private static void StyleChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Grids.AddNewRowSettingsOverride addNewRowSettingsOverride = (global::Infragistics.Controls.Grids.AddNewRowSettingsOverride)obj;
			addNewRowSettingsOverride.OnPropertyChanged("Style");
		}

		// Token: 0x17000055 RID: 85
		// (get) Token: 0x060000E9 RID: 233 RVA: 0x00007E57 File Offset: 0x00006057
		public global::System.Windows.Style StyleResolved
		{
			get
			{
				if (this.Style == null && this.SettingsObject != null)
				{
					return ((global::Infragistics.Controls.Grids.AddNewRowSettings)this.SettingsObject).Style;
				}
				return this.Style;
			}
		}

		// Token: 0x17000056 RID: 86
		// (get) Token: 0x060000EA RID: 234 RVA: 0x00007E80 File Offset: 0x00006080
		// (set) Token: 0x060000EB RID: 235 RVA: 0x00007E92 File Offset: 0x00006092
		public global::System.Windows.Style RowSelectorStyle
		{
			get
			{
				return (global::System.Windows.Style)base.GetValue(global::Infragistics.Controls.Grids.AddNewRowSettingsOverride.RowSelectorStyleProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Grids.AddNewRowSettingsOverride.RowSelectorStyleProperty, value);
			}
		}

		// Token: 0x060000EC RID: 236 RVA: 0x00007EA0 File Offset: 0x000060A0
		private static void RowSelectorStyleChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Grids.AddNewRowSettingsOverride addNewRowSettingsOverride = (global::Infragistics.Controls.Grids.AddNewRowSettingsOverride)obj;
			addNewRowSettingsOverride.OnPropertyChanged("RowSelectorStyle");
		}

		// Token: 0x17000057 RID: 87
		// (get) Token: 0x060000ED RID: 237 RVA: 0x00007EBF File Offset: 0x000060BF
		public global::System.Windows.Style RowSelectorStyleResolved
		{
			get
			{
				if (this.RowSelectorStyle == null && this.SettingsObject != null)
				{
					return ((global::Infragistics.Controls.Grids.AddNewRowSettings)this.SettingsObject).RowSelectorStyle;
				}
				return this.RowSelectorStyle;
			}
		}

		// Token: 0x17000058 RID: 88
		// (get) Token: 0x060000EE RID: 238 RVA: 0x00007EE8 File Offset: 0x000060E8
		// (set) Token: 0x060000EF RID: 239 RVA: 0x00007EFA File Offset: 0x000060FA
		[global::System.ComponentModel.TypeConverter(typeof(global::Infragistics.Controls.Grids.Primitives.RowHeightTypeConverter))]
		public global::Infragistics.Controls.Grids.RowHeight? AddNewRowHeight
		{
			get
			{
				return (global::Infragistics.Controls.Grids.RowHeight?)base.GetValue(global::Infragistics.Controls.Grids.AddNewRowSettingsOverride.AddNewRowHeightProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Grids.AddNewRowSettingsOverride.AddNewRowHeightProperty, value);
			}
		}

		// Token: 0x060000F0 RID: 240 RVA: 0x00007F10 File Offset: 0x00006110
		private static void AddNewRowHeightChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Grids.AddNewRowSettingsOverride addNewRowSettingsOverride = (global::Infragistics.Controls.Grids.AddNewRowSettingsOverride)obj;
			addNewRowSettingsOverride.OnPropertyChanged("AddNewRowHeight");
		}

		// Token: 0x17000059 RID: 89
		// (get) Token: 0x060000F1 RID: 241 RVA: 0x00007F30 File Offset: 0x00006130
		public global::Infragistics.Controls.Grids.RowHeight AddNewRowHeightResolved
		{
			get
			{
				if (this.AddNewRowHeight != null)
				{
					return this.AddNewRowHeight.Value;
				}
				if (this.SettingsObject != null)
				{
					return ((global::Infragistics.Controls.Grids.AddNewRowSettings)this.SettingsObject).AddNewRowHeight;
				}
				return (global::Infragistics.Controls.Grids.RowHeight)global::Infragistics.Controls.Grids.AddNewRowSettings.AddNewRowHeightProperty.GetMetadata(typeof(global::Infragistics.Controls.Grids.AddNewRowSettings)).DefaultValue;
			}
		}

		// Token: 0x060000F2 RID: 242 RVA: 0x00007F93 File Offset: 0x00006193
		protected internal override global::Infragistics.Controls.Grids.EditingType ResolveEditingType()
		{
			return global::Infragistics.Controls.Grids.EditingType.Row;
		}

		// Token: 0x04000037 RID: 55
		public static readonly global::System.Windows.DependencyProperty AllowAddNewRowProperty = global::System.Windows.DependencyProperty.Register("AllowAddNewRow", typeof(global::Infragistics.Controls.Grids.AddNewRowLocation?), typeof(global::Infragistics.Controls.Grids.AddNewRowSettingsOverride), new global::System.Windows.PropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Grids.AddNewRowSettingsOverride.AllowAddNewRowChanged)));

		// Token: 0x04000038 RID: 56
		public static readonly global::System.Windows.DependencyProperty ExpansionIndicatorStyleProperty = global::System.Windows.DependencyProperty.Register("ExpansionIndicatorStyle", typeof(global::System.Windows.Style), typeof(global::Infragistics.Controls.Grids.AddNewRowSettingsOverride), new global::System.Windows.PropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Grids.AddNewRowSettingsOverride.ExpansionIndicatorStyleChanged)));

		// Token: 0x04000039 RID: 57
		public static readonly global::System.Windows.DependencyProperty StyleProperty = global::System.Windows.DependencyProperty.Register("Style", typeof(global::System.Windows.Style), typeof(global::Infragistics.Controls.Grids.AddNewRowSettingsOverride), new global::System.Windows.PropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Grids.AddNewRowSettingsOverride.StyleChanged)));

		// Token: 0x0400003A RID: 58
		public static readonly global::System.Windows.DependencyProperty RowSelectorStyleProperty = global::System.Windows.DependencyProperty.Register("RowSelectorStyle", typeof(global::System.Windows.Style), typeof(global::Infragistics.Controls.Grids.AddNewRowSettingsOverride), new global::System.Windows.PropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Grids.AddNewRowSettingsOverride.RowSelectorStyleChanged)));

		// Token: 0x0400003B RID: 59
		public static readonly global::System.Windows.DependencyProperty AddNewRowHeightProperty = global::System.Windows.DependencyProperty.Register("AddNewRowHeight", typeof(global::Infragistics.Controls.Grids.RowHeight?), typeof(global::Infragistics.Controls.Grids.AddNewRowSettingsOverride), new global::System.Windows.PropertyMetadata(null, global::Infragistics.DependencyPropertyUtilities.CreateTypeConverterCallbackWrapper<global::Infragistics.Controls.Grids.RowHeight?>(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Grids.AddNewRowSettingsOverride.AddNewRowHeightChanged))));
	}
}
