using System;
using System.CodeDom.Compiler;
using System.Configuration;
using System.Runtime.CompilerServices;

namespace Infragistics.Controls.Editors.Properties
{
	// Token: 0x02000058 RID: 88
	[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "10.0.0.0")]
	[CompilerGenerated]
	internal sealed partial class Settings : ApplicationSettingsBase
	{
		// Token: 0x170000FB RID: 251
		// (get) Token: 0x06000484 RID: 1156 RVA: 0x000151DE File Offset: 0x000133DE
		public static Settings Default
		{
			get
			{
				return Settings.defaultInstance;
			}
		}

		// Token: 0x0400023C RID: 572
		private static Settings defaultInstance = (Settings)SettingsBase.Synchronized(new Settings());
	}
}
