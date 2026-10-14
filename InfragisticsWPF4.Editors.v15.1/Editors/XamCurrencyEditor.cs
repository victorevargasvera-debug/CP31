using System;
using System.ComponentModel;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using Infragistics.Themes;
using Infragistics.Windows.Licensing;

namespace Infragistics.Windows.Editors
{
	// Token: 0x0200007A RID: 122
	[global::System.ComponentModel.LicenseProvider(typeof(global::Infragistics.Windows.Licensing.UltraLicenseProvider))]
	[global::Infragistics.Windows.Licensing.UltraLicense("XamCurrencyEditor")]
	public class XamCurrencyEditor : global::Infragistics.Windows.Editors.XamMaskedEditor
	{
		// Token: 0x0600075C RID: 1884 RVA: 0x0001FEA8 File Offset: 0x0001E0A8
		static XamCurrencyEditor()
		{
			global::Infragistics.Windows.Editors.ValueEditor.ValueTypeProperty.OverrideMetadata(typeof(global::Infragistics.Windows.Editors.XamCurrencyEditor), new global::System.Windows.FrameworkPropertyMetadata(typeof(decimal)));
			global::System.Windows.Controls.Control.HorizontalContentAlignmentProperty.OverrideMetadata(typeof(global::Infragistics.Windows.Editors.XamCurrencyEditor), new global::System.Windows.FrameworkPropertyMetadata(global::System.Windows.HorizontalAlignment.Right));
			global::System.Windows.FrameworkElement.DefaultStyleKeyProperty.OverrideMetadata(typeof(global::Infragistics.Windows.Editors.XamCurrencyEditor), new global::System.Windows.FrameworkPropertyMetadata(typeof(global::Infragistics.Windows.Editors.XamCurrencyEditor)));
			global::Infragistics.Themes.ThemeManager.RegisterControl(typeof(global::Infragistics.Windows.Editors.XamCurrencyEditor));
		}

		// Token: 0x0600075D RID: 1885 RVA: 0x0001FF2C File Offset: 0x0001E12C
		public XamCurrencyEditor()
		{
			try
			{
				this._license = (global::System.ComponentModel.LicenseManager.Validate(typeof(global::Infragistics.Windows.Editors.XamCurrencyEditor), this) as global::Infragistics.Windows.Licensing.UltraLicense);
			}
			catch (global::System.IO.FileNotFoundException)
			{
			}
		}

		// Token: 0x040002AD RID: 685
		private global::Infragistics.Windows.Licensing.UltraLicense _license;
	}
}
