using System;
using System.ComponentModel;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using Infragistics.Themes;
using Infragistics.Windows.Licensing;

namespace Infragistics.Windows.Editors
{
	// Token: 0x02000079 RID: 121
	[global::Infragistics.Windows.Licensing.UltraLicense("XamNumericEditor")]
	[global::System.ComponentModel.LicenseProvider(typeof(global::Infragistics.Windows.Licensing.UltraLicenseProvider))]
	public class XamNumericEditor : global::Infragistics.Windows.Editors.XamMaskedEditor
	{
		// Token: 0x0600075A RID: 1882 RVA: 0x0001FDE0 File Offset: 0x0001DFE0
		static XamNumericEditor()
		{
			global::Infragistics.Windows.Editors.ValueEditor.ValueTypeProperty.OverrideMetadata(typeof(global::Infragistics.Windows.Editors.XamNumericEditor), new global::System.Windows.FrameworkPropertyMetadata(typeof(double)));
			global::System.Windows.Controls.Control.HorizontalContentAlignmentProperty.OverrideMetadata(typeof(global::Infragistics.Windows.Editors.XamNumericEditor), new global::System.Windows.FrameworkPropertyMetadata(global::System.Windows.HorizontalAlignment.Right));
			global::System.Windows.FrameworkElement.DefaultStyleKeyProperty.OverrideMetadata(typeof(global::Infragistics.Windows.Editors.XamNumericEditor), new global::System.Windows.FrameworkPropertyMetadata(typeof(global::Infragistics.Windows.Editors.XamNumericEditor)));
			global::Infragistics.Themes.ThemeManager.RegisterControl(typeof(global::Infragistics.Windows.Editors.XamNumericEditor));
		}

		// Token: 0x0600075B RID: 1883 RVA: 0x0001FE64 File Offset: 0x0001E064
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

		// Token: 0x040002AC RID: 684
		private global::Infragistics.Windows.Licensing.UltraLicense _license;
	}
}
