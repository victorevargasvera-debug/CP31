using System;
using System.ComponentModel;
using System.IO;
using System.Windows;
using Infragistics.Windows.Licensing;

namespace Infragistics.Controls.Editors
{
	// Token: 0x0200005A RID: 90
	[global::System.ComponentModel.LicenseProvider(typeof(global::Infragistics.Windows.Licensing.UltraLicenseProvider))]
	[global::Infragistics.Windows.Licensing.UltraLicense("XamCurrencyEditor")]
	public class XamCurrencyInput : global::Infragistics.Controls.Editors.XamMaskedInput
	{
		// Token: 0x060004BB RID: 1211 RVA: 0x00019171 File Offset: 0x00017371
		static XamCurrencyInput()
		{
			global::System.Windows.FrameworkElement.DefaultStyleKeyProperty.OverrideMetadata(typeof(global::Infragistics.Controls.Editors.XamCurrencyInput), new global::System.Windows.FrameworkPropertyMetadata(typeof(global::Infragistics.Controls.Editors.XamCurrencyInput)));
		}

		// Token: 0x060004BC RID: 1212 RVA: 0x00019198 File Offset: 0x00017398
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

		// Token: 0x17000111 RID: 273
		// (get) Token: 0x060004BD RID: 1213 RVA: 0x000191DC File Offset: 0x000173DC
		protected override global::System.Type DefaultValueType
		{
			get
			{
				return typeof(decimal);
			}
		}

		// Token: 0x040001AF RID: 431
		private global::Infragistics.Windows.Licensing.UltraLicense _license;
	}
}
