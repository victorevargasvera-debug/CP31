using System;
using System.ComponentModel;
using System.Windows;

namespace Infragistics.Controls.Grids
{
	// Token: 0x02000066 RID: 102
	public class EditingSettingsOverride : global::Infragistics.Controls.Grids.EditingSettingsBaseOverride
	{
		// Token: 0x1700010C RID: 268
		// (get) Token: 0x06000380 RID: 896 RVA: 0x00010158 File Offset: 0x0000E358
		protected override global::Infragistics.Controls.Grids.SettingsBase SettingsObject
		{
			get
			{
				global::Infragistics.Controls.Grids.SettingsBase result = null;
				if (base.ColumnLayout != null && base.ColumnLayout.Grid != null)
				{
					result = base.ColumnLayout.Grid.EditingSettings;
				}
				return result;
			}
		}

		// Token: 0x06000381 RID: 897 RVA: 0x0001018E File Offset: 0x0000E38E
		protected internal override global::Infragistics.Controls.Grids.EditingType ResolveEditingType()
		{
			return this.AllowEditingResolved;
		}

		// Token: 0x1700010D RID: 269
		// (get) Token: 0x06000382 RID: 898 RVA: 0x00010196 File Offset: 0x0000E396
		// (set) Token: 0x06000383 RID: 899 RVA: 0x000101A8 File Offset: 0x0000E3A8
		[global::System.ComponentModel.TypeConverter(typeof(global::Infragistics.NullableEnumTypeConverter<global::Infragistics.Controls.Grids.EditingType>))]
		public global::Infragistics.Controls.Grids.EditingType? AllowEditing
		{
			get
			{
				return (global::Infragistics.Controls.Grids.EditingType?)base.GetValue(global::Infragistics.Controls.Grids.EditingSettingsOverride.AllowEditingProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Grids.EditingSettingsOverride.AllowEditingProperty, value);
			}
		}

		// Token: 0x06000384 RID: 900 RVA: 0x000101BC File Offset: 0x0000E3BC
		private static void AllowEditingChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Grids.EditingSettingsOverride editingSettingsOverride = (global::Infragistics.Controls.Grids.EditingSettingsOverride)obj;
			editingSettingsOverride.OnPropertyChanged("AllowEditing");
		}

		// Token: 0x1700010E RID: 270
		// (get) Token: 0x06000385 RID: 901 RVA: 0x000101DC File Offset: 0x0000E3DC
		public global::Infragistics.Controls.Grids.EditingType AllowEditingResolved
		{
			get
			{
				if (this.AllowEditing != null)
				{
					return this.AllowEditing.Value;
				}
				if (this.SettingsObject != null)
				{
					return ((global::Infragistics.Controls.Grids.EditingSettings)this.SettingsObject).AllowEditing;
				}
				return (global::Infragistics.Controls.Grids.EditingType)global::Infragistics.Controls.Grids.EditingSettings.AllowEditingProperty.GetMetadata(typeof(global::Infragistics.Controls.Grids.EditingSettings)).DefaultValue;
			}
		}

		// Token: 0x040000DC RID: 220
		public static readonly global::System.Windows.DependencyProperty AllowEditingProperty = global::System.Windows.DependencyProperty.Register("AllowEditing", typeof(global::Infragistics.Controls.Grids.EditingType?), typeof(global::Infragistics.Controls.Grids.EditingSettingsOverride), new global::System.Windows.PropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Grids.EditingSettingsOverride.AllowEditingChanged)));
	}
}
