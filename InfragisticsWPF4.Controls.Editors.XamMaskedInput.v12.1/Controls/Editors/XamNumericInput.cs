using System;
using System.ComponentModel;
using System.IO;
using System.Windows;
using Infragistics.Windows.Licensing;

namespace Infragistics.Controls.Editors
{
	// Token: 0x0200005D RID: 93
	[global::System.ComponentModel.LicenseProvider(typeof(global::Infragistics.Windows.Licensing.UltraLicenseProvider))]
	[global::Infragistics.Windows.Licensing.UltraLicense("XamNumericEditor")]
	public class XamNumericInput : global::Infragistics.Controls.Editors.XamMaskedInput
	{
		// Token: 0x060004CF RID: 1231 RVA: 0x000195EE File Offset: 0x000177EE
		static XamNumericInput()
		{
			global::System.Windows.FrameworkElement.DefaultStyleKeyProperty.OverrideMetadata(typeof(global::Infragistics.Controls.Editors.XamNumericInput), new global::System.Windows.FrameworkPropertyMetadata(typeof(global::Infragistics.Controls.Editors.XamNumericInput)));
		}

		// Token: 0x060004D0 RID: 1232 RVA: 0x00019614 File Offset: 0x00017814
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

		// Token: 0x17000117 RID: 279
		// (get) Token: 0x060004D1 RID: 1233 RVA: 0x00019658 File Offset: 0x00017858
		protected override global::System.Type DefaultValueType
		{
			get
			{
				return typeof(double);
			}
		}

		// Token: 0x040001B3 RID: 435
		private global::Infragistics.Windows.Licensing.UltraLicense _license;
	}
}
