using System;
using System.CodeDom.Compiler;
using System.Configuration;
using System.Runtime.CompilerServices;

namespace Infragistics.DataManager.Properties
{
	// Token: 0x02000048 RID: 72
	[CompilerGenerated]
	[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "10.0.0.0")]
	internal sealed partial class Settings : ApplicationSettingsBase
	{
		// Token: 0x170000C0 RID: 192
		// (get) Token: 0x060002E6 RID: 742 RVA: 0x0000E246 File Offset: 0x0000C446
		public static Settings Default
		{
			get
			{
				return Settings.defaultInstance;
			}
		}

		// Token: 0x04000115 RID: 277
		private static Settings defaultInstance = (Settings)SettingsBase.Synchronized(new Settings());
	}
}
