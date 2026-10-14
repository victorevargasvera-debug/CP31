using System;
using System.Windows;

namespace Infragistics.Controls.Grids
{
	// Token: 0x02000067 RID: 103
	public abstract class VisualSettingsBase : global::Infragistics.Controls.Grids.StyleSettingsBase
	{
		// Token: 0x1700010F RID: 271
		// (get) Token: 0x06000388 RID: 904 RVA: 0x0001027E File Offset: 0x0000E47E
		// (set) Token: 0x06000389 RID: 905 RVA: 0x00010290 File Offset: 0x0000E490
		public global::System.Windows.Visibility Visibility
		{
			get
			{
				return (global::System.Windows.Visibility)base.GetValue(global::Infragistics.Controls.Grids.VisualSettingsBase.VisibilityProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Grids.VisualSettingsBase.VisibilityProperty, value);
			}
		}

		// Token: 0x0600038A RID: 906 RVA: 0x000102A4 File Offset: 0x0000E4A4
		private static void VisibilityChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Grids.VisualSettingsBase visualSettingsBase = (global::Infragistics.Controls.Grids.VisualSettingsBase)obj;
			visualSettingsBase.OnPropertyChanged("Visibility");
		}

		// Token: 0x040000DD RID: 221
		public static readonly global::System.Windows.DependencyProperty VisibilityProperty = global::System.Windows.DependencyProperty.Register("Visibility", typeof(global::System.Windows.Visibility), typeof(global::Infragistics.Controls.Grids.VisualSettingsBase), new global::System.Windows.PropertyMetadata(global::System.Windows.Visibility.Visible, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Grids.VisualSettingsBase.VisibilityChanged)));
	}
}
