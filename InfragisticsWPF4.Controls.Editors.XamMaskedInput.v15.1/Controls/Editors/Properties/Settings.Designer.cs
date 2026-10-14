using System;
using System.CodeDom.Compiler;
using System.Configuration;
using System.Runtime.CompilerServices;

namespace Infragistics.Controls.Editors.Properties
{
	// Token: 0x02000060 RID: 96
	[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "10.0.0.0")]
	[CompilerGenerated]
	internal sealed partial class Settings : ApplicationSettingsBase
	{
		// Token: 0x1700011E RID: 286
		// (get) Token: 0x060004EB RID: 1259 RVA: 0x00019AE2 File Offset: 0x00017CE2
		public static Settings Default
		{
			get
			{
				return Settings.defaultInstance;
			}
		}

		// Token: 0x040001C8 RID: 456
		private static Settings defaultInstance = (Settings)SettingsBase.Synchronized(new Settings());
	}
}
