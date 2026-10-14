using System;
using System.CodeDom.Compiler;
using System.Configuration;
using System.Runtime.CompilerServices;

namespace Infragistics.Controls.Barcodes.Properties
{
	// Token: 0x02000041 RID: 65
	[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "10.0.0.0")]
	[CompilerGenerated]
	internal sealed partial class Settings : ApplicationSettingsBase
	{
		// Token: 0x17000036 RID: 54
		// (get) Token: 0x060001C1 RID: 449 RVA: 0x0001A28E File Offset: 0x0001848E
		public static Settings Default
		{
			get
			{
				return Settings.defaultInstance;
			}
		}

		// Token: 0x040001A8 RID: 424
		private static Settings defaultInstance = (Settings)SettingsBase.Synchronized(new Settings());
	}
}
