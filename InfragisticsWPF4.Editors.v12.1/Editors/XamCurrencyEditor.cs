using System;
using System.ComponentModel;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using Infragistics.Windows.Licensing;

namespace Infragistics.Windows.Editors
{
	// Token: 0x02000074 RID: 116
	[global::Infragistics.Windows.Licensing.UltraLicense("XamCurrencyEditor")]
	[global::System.ComponentModel.LicenseProvider(typeof(global::Infragistics.Windows.Licensing.UltraLicenseProvider))]
	public class XamCurrencyEditor : global::Infragistics.Windows.Editors.XamMaskedEditor
	{
		// Token: 0x060006FC RID: 1788 RVA: 0x0001E4D4 File Offset: 0x0001C6D4
		static XamCurrencyEditor()
		{
			global::Infragistics.Windows.Editors.ValueEditor.ValueTypeProperty.OverrideMetadata(typeof(global::Infragistics.Windows.Editors.XamCurrencyEditor), new global::System.Windows.FrameworkPropertyMetadata(typeof(decimal)));
			global::System.Windows.Controls.Control.HorizontalContentAlignmentProperty.OverrideMetadata(typeof(global::Infragistics.Windows.Editors.XamCurrencyEditor), new global::System.Windows.FrameworkPropertyMetadata(global::System.Windows.HorizontalAlignment.Right));
			global::System.Windows.FrameworkElement.DefaultStyleKeyProperty.OverrideMetadata(typeof(global::Infragistics.Windows.Editors.XamCurrencyEditor), new global::System.Windows.FrameworkPropertyMetadata(typeof(global::Infragistics.Windows.Editors.XamCurrencyEditor)));
		}

		// Token: 0x060006FD RID: 1789 RVA: 0x0001E548 File Offset: 0x0001C748
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

		// Token: 0x0400027A RID: 634
		private global::Infragistics.Windows.Licensing.UltraLicense _license;
	}
}
