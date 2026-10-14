using System;
using System.Collections.ObjectModel;

namespace Microsoft.Practices.Prism.Modularity
{
	// Token: 0x0200002F RID: 47
	[global::System.Serializable]
	public class ModuleInfo : global::Microsoft.Practices.Prism.Modularity.IModuleCatalogItem
	{
		// Token: 0x060000F5 RID: 245 RVA: 0x000047F2 File Offset: 0x000029F2
		public ModuleInfo() : this(null, null, new string[0])
		{
		}

		// Token: 0x060000F6 RID: 246 RVA: 0x00004804 File Offset: 0x00002A04
		public ModuleInfo(string name, string type, params string[] dependsOn)
		{
			if (dependsOn == null)
			{
				throw new global::System.ArgumentNullException("dependsOn");
			}
			this.ModuleName = name;
			this.ModuleType = type;
			this.DependsOn = new global::System.Collections.ObjectModel.Collection<string>();
			foreach (string item in dependsOn)
			{
				this.DependsOn.Add(item);
			}
		}

		// Token: 0x060000F7 RID: 247 RVA: 0x0000485E File Offset: 0x00002A5E
		public ModuleInfo(string name, string type) : this(name, type, new string[0])
		{
		}

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x060000F8 RID: 248 RVA: 0x0000486E File Offset: 0x00002A6E
		// (set) Token: 0x060000F9 RID: 249 RVA: 0x00004876 File Offset: 0x00002A76
		public string ModuleName { get; set; }

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x060000FA RID: 250 RVA: 0x0000487F File Offset: 0x00002A7F
		// (set) Token: 0x060000FB RID: 251 RVA: 0x00004887 File Offset: 0x00002A87
		public string ModuleType { get; set; }

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x060000FC RID: 252 RVA: 0x00004890 File Offset: 0x00002A90
		// (set) Token: 0x060000FD RID: 253 RVA: 0x00004898 File Offset: 0x00002A98
		public global::System.Collections.ObjectModel.Collection<string> DependsOn { get; set; }

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x060000FE RID: 254 RVA: 0x000048A1 File Offset: 0x00002AA1
		// (set) Token: 0x060000FF RID: 255 RVA: 0x000048A9 File Offset: 0x00002AA9
		public global::Microsoft.Practices.Prism.Modularity.InitializationMode InitializationMode { get; set; }

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x06000100 RID: 256 RVA: 0x000048B2 File Offset: 0x00002AB2
		// (set) Token: 0x06000101 RID: 257 RVA: 0x000048BA File Offset: 0x00002ABA
		public string Ref { get; set; }

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x06000102 RID: 258 RVA: 0x000048C3 File Offset: 0x00002AC3
		// (set) Token: 0x06000103 RID: 259 RVA: 0x000048CB File Offset: 0x00002ACB
		public global::Microsoft.Practices.Prism.Modularity.ModuleState State { get; set; }
	}
}
