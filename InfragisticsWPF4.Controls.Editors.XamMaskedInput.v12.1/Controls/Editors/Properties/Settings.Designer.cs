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
		// Token: 0x1700011A RID: 282
		// (get) Token: 0x060004D7 RID: 1239 RVA: 0x000196C2 File Offset: 0x000178C2
		public static Settings Default
		{
			get
			{
				return Settings.defaultInstance;
			}
		}

		// Token: 0x040001BE RID: 446
		private static Settings defaultInstance = (Settings)SettingsBase.Synchronized(new Settings());
	}
}
