using System;
using System.Windows;

namespace Infragistics.Controls.Grids
{
	// Token: 0x0200001E RID: 30
	public abstract class StyleSettingsOverrideBase : global::Infragistics.Controls.Grids.SettingsOverrideBase
	{
		// Token: 0x1700006E RID: 110
		// (get) Token: 0x06000162 RID: 354 RVA: 0x00009230 File Offset: 0x00007430
		// (set) Token: 0x06000163 RID: 355 RVA: 0x00009242 File Offset: 0x00007442
		public global::System.Windows.Style Style
		{
			get
			{
				return (global::System.Windows.Style)base.GetValue(global::Infragistics.Controls.Grids.StyleSettingsOverrideBase.StyleProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Grids.StyleSettingsOverrideBase.StyleProperty, value);
			}
		}

		// Token: 0x06000164 RID: 356 RVA: 0x00009250 File Offset: 0x00007450
		private static void StyleChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Grids.StyleSettingsOverrideBase styleSettingsOverrideBase = (global::Infragistics.Controls.Grids.StyleSettingsOverrideBase)obj;
			if (styleSettingsOverrideBase.ColumnLayout != null && styleSettingsOverrideBase.ColumnLayout.Grid != null)
			{
				styleSettingsOverrideBase.ColumnLayout.Grid.ResetPanelRows();
			}
			styleSettingsOverrideBase.OnPropertyChanged("Style");
		}

		// Token: 0x1700006F RID: 111
		// (get) Token: 0x06000165 RID: 357 RVA: 0x00009294 File Offset: 0x00007494
		public global::System.Windows.Style StyleResolved
		{
			get
			{
				if (this.Style == null && this.SettingsObject != null)
				{
					return ((global::Infragistics.Controls.Grids.StyleSettingsBase)this.SettingsObject).Style;
				}
				return this.Style;
			}
		}

		// Token: 0x04000059 RID: 89
		public static readonly global::System.Windows.DependencyProperty StyleProperty = global::System.Windows.DependencyProperty.Register("Style", typeof(global::System.Windows.Style), typeof(global::Infragistics.Controls.Grids.StyleSettingsOverrideBase), new global::System.Windows.PropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Grids.StyleSettingsOverrideBase.StyleChanged)));
	}
}
