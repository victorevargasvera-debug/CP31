using System;
using System.ComponentModel;
using System.Windows;

namespace Infragistics.Controls.Grids
{
	// Token: 0x0200000E RID: 14
	public abstract class EditingSettingsBaseOverride : global::Infragistics.Controls.Grids.SettingsOverrideBase
	{
		// Token: 0x17000046 RID: 70
		// (get) Token: 0x060000C9 RID: 201 RVA: 0x00007915 File Offset: 0x00005B15
		protected override global::Infragistics.Controls.Grids.SettingsBase SettingsObject
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000047 RID: 71
		// (get) Token: 0x060000CA RID: 202 RVA: 0x00007918 File Offset: 0x00005B18
		// (set) Token: 0x060000CB RID: 203 RVA: 0x0000792A File Offset: 0x00005B2A
		[global::System.ComponentModel.TypeConverter(typeof(global::System.Windows.NullableBoolConverter))]
		public bool? IsF2EditingEnabled
		{
			get
			{
				return (bool?)base.GetValue(global::Infragistics.Controls.Grids.EditingSettingsBaseOverride.IsF2EditingEnabledProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Grids.EditingSettingsBaseOverride.IsF2EditingEnabledProperty, value);
			}
		}

		// Token: 0x060000CC RID: 204 RVA: 0x00007940 File Offset: 0x00005B40
		private static void IsF2EditingEnabledChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Grids.EditingSettingsBaseOverride editingSettingsBaseOverride = (global::Infragistics.Controls.Grids.EditingSettingsBaseOverride)obj;
			editingSettingsBaseOverride.OnPropertyChanged("IsF2EditingEnabled");
		}

		// Token: 0x17000048 RID: 72
		// (get) Token: 0x060000CD RID: 205 RVA: 0x00007960 File Offset: 0x00005B60
		public bool IsF2EditingEnabledResolved
		{
			get
			{
				if (this.IsF2EditingEnabled != null)
				{
					return this.IsF2EditingEnabled.Value;
				}
				if (this.SettingsObject != null)
				{
					return ((global::Infragistics.Controls.Grids.EditingSettingsBase)this.SettingsObject).IsF2EditingEnabled;
				}
				return (bool)global::Infragistics.Controls.Grids.EditingSettingsBase.IsF2EditingEnabledProperty.GetMetadata(typeof(global::Infragistics.Controls.Grids.EditingSettingsBase)).DefaultValue;
			}
		}

		// Token: 0x17000049 RID: 73
		// (get) Token: 0x060000CE RID: 206 RVA: 0x000079C3 File Offset: 0x00005BC3
		// (set) Token: 0x060000CF RID: 207 RVA: 0x000079D5 File Offset: 0x00005BD5
		[global::System.ComponentModel.TypeConverter(typeof(global::System.Windows.NullableBoolConverter))]
		public bool? IsEnterKeyEditingEnabled
		{
			get
			{
				return (bool?)base.GetValue(global::Infragistics.Controls.Grids.EditingSettingsBaseOverride.IsEnterKeyEditingEnabledProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Grids.EditingSettingsBaseOverride.IsEnterKeyEditingEnabledProperty, value);
			}
		}

		// Token: 0x060000D0 RID: 208 RVA: 0x000079E8 File Offset: 0x00005BE8
		private static void IsEnterKeyEditingEnabledChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Grids.EditingSettingsBaseOverride editingSettingsBaseOverride = (global::Infragistics.Controls.Grids.EditingSettingsBaseOverride)obj;
			editingSettingsBaseOverride.OnPropertyChanged("IsEnterKeyEditingEnabled");
		}

		// Token: 0x1700004A RID: 74
		// (get) Token: 0x060000D1 RID: 209 RVA: 0x00007A08 File Offset: 0x00005C08
		public bool IsEnterKeyEditingEnabledResolved
		{
			get
			{
				if (this.IsEnterKeyEditingEnabled != null)
				{
					return this.IsEnterKeyEditingEnabled.Value;
				}
				if (this.SettingsObject != null)
				{
					return ((global::Infragistics.Controls.Grids.EditingSettingsBase)this.SettingsObject).IsEnterKeyEditingEnabled;
				}
				return (bool)global::Infragistics.Controls.Grids.EditingSettingsBase.IsEnterKeyEditingEnabledProperty.GetMetadata(typeof(global::Infragistics.Controls.Grids.EditingSettingsBase)).DefaultValue;
			}
		}

		// Token: 0x1700004B RID: 75
		// (get) Token: 0x060000D2 RID: 210 RVA: 0x00007A6B File Offset: 0x00005C6B
		// (set) Token: 0x060000D3 RID: 211 RVA: 0x00007A7D File Offset: 0x00005C7D
		[global::System.ComponentModel.TypeConverter(typeof(global::Infragistics.NullableEnumTypeConverter<global::Infragistics.Controls.Grids.MouseEditingAction>))]
		public global::Infragistics.Controls.Grids.MouseEditingAction? IsMouseActionEditingEnabled
		{
			get
			{
				return (global::Infragistics.Controls.Grids.MouseEditingAction?)base.GetValue(global::Infragistics.Controls.Grids.EditingSettingsBaseOverride.IsMouseActionEditingEnabledProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Grids.EditingSettingsBaseOverride.IsMouseActionEditingEnabledProperty, value);
			}
		}

		// Token: 0x060000D4 RID: 212 RVA: 0x00007A90 File Offset: 0x00005C90
		private static void IsMouseActionEditingEnabledChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Grids.EditingSettingsBaseOverride editingSettingsBaseOverride = (global::Infragistics.Controls.Grids.EditingSettingsBaseOverride)obj;
			editingSettingsBaseOverride.OnPropertyChanged("IsMouseActionEditingEnabled");
		}

		// Token: 0x1700004C RID: 76
		// (get) Token: 0x060000D5 RID: 213 RVA: 0x00007AB0 File Offset: 0x00005CB0
		public global::Infragistics.Controls.Grids.MouseEditingAction IsMouseActionEditingEnabledResolved
		{
			get
			{
				if (this.IsMouseActionEditingEnabled != null)
				{
					return this.IsMouseActionEditingEnabled.Value;
				}
				if (this.SettingsObject != null)
				{
					return ((global::Infragistics.Controls.Grids.EditingSettingsBase)this.SettingsObject).IsMouseActionEditingEnabled;
				}
				return (global::Infragistics.Controls.Grids.MouseEditingAction)global::Infragistics.Controls.Grids.EditingSettingsBase.IsMouseActionEditingEnabledProperty.GetMetadata(typeof(global::Infragistics.Controls.Grids.EditingSettingsBase)).DefaultValue;
			}
		}

		// Token: 0x1700004D RID: 77
		// (get) Token: 0x060000D6 RID: 214 RVA: 0x00007B13 File Offset: 0x00005D13
		// (set) Token: 0x060000D7 RID: 215 RVA: 0x00007B25 File Offset: 0x00005D25
		[global::System.ComponentModel.TypeConverter(typeof(global::System.Windows.NullableBoolConverter))]
		public bool? IsOnCellActiveEditingEnabled
		{
			get
			{
				return (bool?)base.GetValue(global::Infragistics.Controls.Grids.EditingSettingsBaseOverride.IsOnCellActiveEditingEnabledProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Grids.EditingSettingsBaseOverride.IsOnCellActiveEditingEnabledProperty, value);
			}
		}

		// Token: 0x060000D8 RID: 216 RVA: 0x00007B38 File Offset: 0x00005D38
		private static void IsOnCellActiveEditingEnabledChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Grids.EditingSettingsBaseOverride editingSettingsBaseOverride = (global::Infragistics.Controls.Grids.EditingSettingsBaseOverride)obj;
			editingSettingsBaseOverride.OnPropertyChanged("IsOnCellActiveEditingEnabled");
		}

		// Token: 0x1700004E RID: 78
		// (get) Token: 0x060000D9 RID: 217 RVA: 0x00007B58 File Offset: 0x00005D58
		public bool IsOnCellActiveEditingEnabledResolved
		{
			get
			{
				if (this.IsOnCellActiveEditingEnabled != null)
				{
					return this.IsOnCellActiveEditingEnabled.Value;
				}
				if (this.SettingsObject != null)
				{
					return ((global::Infragistics.Controls.Grids.EditingSettingsBase)this.SettingsObject).IsOnCellActiveEditingEnabled;
				}
				return (bool)global::Infragistics.Controls.Grids.EditingSettingsBase.IsOnCellActiveEditingEnabledProperty.GetMetadata(typeof(global::Infragistics.Controls.Grids.EditingSettingsBase)).DefaultValue;
			}
		}

		// Token: 0x060000DA RID: 218
		protected internal abstract global::Infragistics.Controls.Grids.EditingType ResolveEditingType();

		// Token: 0x04000033 RID: 51
		public static readonly global::System.Windows.DependencyProperty IsF2EditingEnabledProperty = global::System.Windows.DependencyProperty.Register("IsF2EditingEnabled", typeof(bool?), typeof(global::Infragistics.Controls.Grids.EditingSettingsBaseOverride), new global::System.Windows.PropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Grids.EditingSettingsBaseOverride.IsF2EditingEnabledChanged)));

		// Token: 0x04000034 RID: 52
		public static readonly global::System.Windows.DependencyProperty IsEnterKeyEditingEnabledProperty = global::System.Windows.DependencyProperty.Register("IsEnterKeyEditingEnabled", typeof(bool?), typeof(global::Infragistics.Controls.Grids.EditingSettingsBaseOverride), new global::System.Windows.PropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Grids.EditingSettingsBaseOverride.IsEnterKeyEditingEnabledChanged)));

		// Token: 0x04000035 RID: 53
		public static readonly global::System.Windows.DependencyProperty IsMouseActionEditingEnabledProperty = global::System.Windows.DependencyProperty.Register("IsMouseActionEditingEnabled", typeof(global::Infragistics.Controls.Grids.MouseEditingAction?), typeof(global::Infragistics.Controls.Grids.EditingSettingsBaseOverride), new global::System.Windows.PropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Grids.EditingSettingsBaseOverride.IsMouseActionEditingEnabledChanged)));

		// Token: 0x04000036 RID: 54
		public static readonly global::System.Windows.DependencyProperty IsOnCellActiveEditingEnabledProperty = global::System.Windows.DependencyProperty.Register("IsOnCellActiveEditingEnabled", typeof(bool?), typeof(global::Infragistics.Controls.Grids.EditingSettingsBaseOverride), new global::System.Windows.PropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Grids.EditingSettingsBaseOverride.IsOnCellActiveEditingEnabledChanged)));
	}
}
