using System;
using System.Windows;

namespace Infragistics.Controls.Grids
{
	// Token: 0x02000065 RID: 101
	public class EditingSettings : global::Infragistics.Controls.Grids.EditingSettingsBase
	{
		// Token: 0x1700010B RID: 267
		// (get) Token: 0x0600037B RID: 891 RVA: 0x000100CE File Offset: 0x0000E2CE
		// (set) Token: 0x0600037C RID: 892 RVA: 0x000100E0 File Offset: 0x0000E2E0
		public global::Infragistics.Controls.Grids.EditingType AllowEditing
		{
			get
			{
				return (global::Infragistics.Controls.Grids.EditingType)base.GetValue(global::Infragistics.Controls.Grids.EditingSettings.AllowEditingProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Grids.EditingSettings.AllowEditingProperty, value);
			}
		}

		// Token: 0x0600037D RID: 893 RVA: 0x000100F4 File Offset: 0x0000E2F4
		private static void AllowEditingChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Grids.EditingSettings editingSettings = (global::Infragistics.Controls.Grids.EditingSettings)obj;
			editingSettings.OnPropertyChanged("AllowEditing");
		}

		// Token: 0x040000DB RID: 219
		public static readonly global::System.Windows.DependencyProperty AllowEditingProperty = global::System.Windows.DependencyProperty.Register("AllowEditing", typeof(global::Infragistics.Controls.Grids.EditingType), typeof(global::Infragistics.Controls.Grids.EditingSettings), new global::System.Windows.PropertyMetadata(global::Infragistics.Controls.Grids.EditingType.None, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Grids.EditingSettings.AllowEditingChanged)));
	}
}
