using System;
using System.CodeDom.Compiler;
using System.Configuration;
using System.Runtime.CompilerServices;

namespace Infragistics.Controls.Menus.Properties
{
	// Token: 0x02000034 RID: 52
	[CompilerGenerated]
	[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "10.0.0.0")]
	internal sealed partial class Settings : ApplicationSettingsBase
	{
		// Token: 0x17000098 RID: 152
		// (get) Token: 0x06000219 RID: 537 RVA: 0x00009B7A File Offset: 0x00007D7A
		public static Settings Default
		{
			get
			{
				return Settings.defaultInstance;
			}
		}

		// Token: 0x040000AC RID: 172
		private static Settings defaultInstance = (Settings)SettingsBase.Synchronized(new Settings());
	}
}
