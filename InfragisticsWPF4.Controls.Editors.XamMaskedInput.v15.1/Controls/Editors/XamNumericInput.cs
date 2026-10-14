using System;
using System.ComponentModel;
using System.IO;
using System.Windows;
using Infragistics.Themes;
using Infragistics.Windows.Licensing;

namespace Infragistics.Controls.Editors
{
	// Token: 0x0200005D RID: 93
	[global::Infragistics.Windows.Licensing.UltraLicense("XamNumericEditor")]
	[global::System.ComponentModel.LicenseProvider(typeof(global::Infragistics.Windows.Licensing.UltraLicenseProvider))]
	public class XamNumericInput : global::Infragistics.Controls.Editors.XamMaskedInput
	{
		// Token: 0x060004E3 RID: 1251 RVA: 0x000199FE File Offset: 0x00017BFE
		static XamNumericInput()
		{
			global::System.Windows.FrameworkElement.DefaultStyleKeyProperty.OverrideMetadata(typeof(global::Infragistics.Controls.Editors.XamNumericInput), new global::System.Windows.FrameworkPropertyMetadata(typeof(global::Infragistics.Controls.Editors.XamNumericInput)));
			global::Infragistics.Themes.ThemeManager.RegisterControl(typeof(global::Infragistics.Controls.Editors.XamNumericInput));
		}

		// Token: 0x060004E4 RID: 1252 RVA: 0x00019A34 File Offset: 0x00017C34
		public XamNumericInput()
		{
			try
			{
				this._license = (global::System.ComponentModel.LicenseManager.Validate(typeof(global::Infragistics.Controls.Editors.XamNumericInput), this) as global::Infragistics.Windows.Licensing.UltraLicense);
			}
			catch (global::System.IO.FileNotFoundException)
			{
			}
		}

		// Token: 0x1700011B RID: 283
		// (get) Token: 0x060004E5 RID: 1253 RVA: 0x00019A78 File Offset: 0x00017C78
		protected override global::System.Type DefaultValueType
		{
			get
			{
				return typeof(double);
			}
		}

		// Token: 0x040001C0 RID: 448
		private global::Infragistics.Windows.Licensing.UltraLicense _license;
	}
}
