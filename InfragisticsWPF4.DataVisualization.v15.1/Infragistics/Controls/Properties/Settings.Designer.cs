using System;
using System.CodeDom.Compiler;
using System.Configuration;
using System.Runtime.CompilerServices;

namespace Infragistics.Controls.Properties
{
	// Token: 0x0200004F RID: 79
	[CompilerGenerated]
	[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "10.0.0.0")]
	internal sealed partial class Settings : ApplicationSettingsBase
	{
		// Token: 0x17000100 RID: 256
		// (get) Token: 0x06000433 RID: 1075 RVA: 0x0001108E File Offset: 0x0000F28E
		public static Settings Default
		{
			get
			{
				return Settings.defaultInstance;
			}
		}

		// Token: 0x0400019A RID: 410
		private static Settings defaultInstance = (Settings)SettingsBase.Synchronized(new Settings());
	}
}
