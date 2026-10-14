using System;
using System.ComponentModel;
using System.IO;
using System.Windows;
using Infragistics.Themes;
using Infragistics.Windows.Licensing;

namespace Infragistics.Controls.Editors
{
	// Token: 0x0200005A RID: 90
	[global::System.ComponentModel.LicenseProvider(typeof(global::Infragistics.Windows.Licensing.UltraLicenseProvider))]
	[global::Infragistics.Windows.Licensing.UltraLicense("XamCurrencyEditor")]
	public class XamCurrencyInput : global::Infragistics.Controls.Editors.XamMaskedInput
	{
		// Token: 0x060004CF RID: 1231 RVA: 0x00019579 File Offset: 0x00017779
		static XamCurrencyInput()
		{
			global::System.Windows.FrameworkElement.DefaultStyleKeyProperty.OverrideMetadata(typeof(global::Infragistics.Controls.Editors.XamCurrencyInput), new global::System.Windows.FrameworkPropertyMetadata(typeof(global::Infragistics.Controls.Editors.XamCurrencyInput)));
			global::Infragistics.Themes.ThemeManager.RegisterControl(typeof(global::Infragistics.Controls.Editors.XamCurrencyInput));
		}

		// Token: 0x060004D0 RID: 1232 RVA: 0x000195B0 File Offset: 0x000177B0
		public XamCurrencyInput()
		{
			try
			{
				this._license = (global::System.ComponentModel.LicenseManager.Validate(typeof(global::Infragistics.Controls.Editors.XamCurrencyInput), this) as global::Infragistics.Windows.Licensing.UltraLicense);
			}
			catch (global::System.IO.FileNotFoundException)
			{
			}
		}

		// Token: 0x17000115 RID: 277
		// (get) Token: 0x060004D1 RID: 1233 RVA: 0x000195F4 File Offset: 0x000177F4
		protected override global::System.Type DefaultValueType
		{
			get
			{
				return typeof(decimal);
			}
		}

		// Token: 0x040001BC RID: 444
		private global::Infragistics.Windows.Licensing.UltraLicense _license;
	}
}
