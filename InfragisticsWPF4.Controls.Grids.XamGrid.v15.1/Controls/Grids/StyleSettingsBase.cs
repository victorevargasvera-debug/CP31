using System;
using System.Windows;

namespace Infragistics.Controls.Grids
{
	// Token: 0x0200001C RID: 28
	public abstract class StyleSettingsBase : global::Infragistics.Controls.Grids.SettingsBase
	{
		// Token: 0x17000067 RID: 103
		// (get) Token: 0x06000147 RID: 327 RVA: 0x00008E7D File Offset: 0x0000707D
		// (set) Token: 0x06000148 RID: 328 RVA: 0x00008E8F File Offset: 0x0000708F
		public global::System.Windows.Style Style
		{
			get
			{
				return (global::System.Windows.Style)base.GetValue(global::Infragistics.Controls.Grids.StyleSettingsBase.StyleProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Grids.StyleSettingsBase.StyleProperty, value);
			}
		}

		// Token: 0x06000149 RID: 329 RVA: 0x00008EA0 File Offset: 0x000070A0
		private static void StyleChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Grids.StyleSettingsBase styleSettingsBase = (global::Infragistics.Controls.Grids.StyleSettingsBase)obj;
			if (styleSettingsBase.Grid != null)
			{
				styleSettingsBase.Grid.ResetPanelRows();
			}
			styleSettingsBase.OnPropertyChanged("Style");
			styleSettingsBase.OnStyleChanged();
		}

		// Token: 0x0600014A RID: 330 RVA: 0x00008ED8 File Offset: 0x000070D8
		protected virtual void OnStyleChanged()
		{
		}

		// Token: 0x04000052 RID: 82
		public static readonly global::System.Windows.DependencyProperty StyleProperty = global::System.Windows.DependencyProperty.Register("Style", typeof(global::System.Windows.Style), typeof(global::Infragistics.Controls.Grids.StyleSettingsBase), new global::System.Windows.PropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Grids.StyleSettingsBase.StyleChanged)));
	}
}
