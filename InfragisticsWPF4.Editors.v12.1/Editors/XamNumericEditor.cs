using System;
using System.ComponentModel;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using Infragistics.Windows.Licensing;

namespace Infragistics.Windows.Editors
{
	// Token: 0x02000073 RID: 115
	[global::Infragistics.Windows.Licensing.UltraLicense("XamNumericEditor")]
	[global::System.ComponentModel.LicenseProvider(typeof(global::Infragistics.Windows.Licensing.UltraLicenseProvider))]
	public class XamNumericEditor : global::Infragistics.Windows.Editors.XamMaskedEditor
	{
		// Token: 0x060006FA RID: 1786 RVA: 0x0001E41C File Offset: 0x0001C61C
		static XamNumericEditor()
		{
			global::Infragistics.Windows.Editors.ValueEditor.ValueTypeProperty.OverrideMetadata(typeof(global::Infragistics.Windows.Editors.XamNumericEditor), new global::System.Windows.FrameworkPropertyMetadata(typeof(double)));
			global::System.Windows.Controls.Control.HorizontalContentAlignmentProperty.OverrideMetadata(typeof(global::Infragistics.Windows.Editors.XamNumericEditor), new global::System.Windows.FrameworkPropertyMetadata(global::System.Windows.HorizontalAlignment.Right));
			global::System.Windows.FrameworkElement.DefaultStyleKeyProperty.OverrideMetadata(typeof(global::Infragistics.Windows.Editors.XamNumericEditor), new global::System.Windows.FrameworkPropertyMetadata(typeof(global::Infragistics.Windows.Editors.XamNumericEditor)));
		}

		// Token: 0x060006FB RID: 1787 RVA: 0x0001E490 File Offset: 0x0001C690
		public XamNumericEditor()
		{
			try
			{
				this._license = (global::System.ComponentModel.LicenseManager.Validate(typeof(global::Infragistics.Windows.Editors.XamNumericEditor), this) as global::Infragistics.Windows.Licensing.UltraLicense);
			}
			catch (global::System.IO.FileNotFoundException)
			{
			}
		}

		// Token: 0x04000279 RID: 633
		private global::Infragistics.Windows.Licensing.UltraLicense _license;
	}
}
