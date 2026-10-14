using System;
using System.ComponentModel;
using System.ComponentModel.Composition;
using Microsoft.Practices.Prism.Modularity;

namespace Microsoft.Practices.Prism.MefExtensions.Modularity
{
	// Token: 0x0200000B RID: 11
	[global::System.ComponentModel.Composition.MetadataAttribute]
	[global::System.AttributeUsage(global::System.AttributeTargets.Class, AllowMultiple = false)]
	public class ModuleExportAttribute : global::System.ComponentModel.Composition.ExportAttribute, global::Microsoft.Practices.Prism.MefExtensions.Modularity.IModuleExport
	{
		// Token: 0x0600003D RID: 61 RVA: 0x00002D2B File Offset: 0x00000F2B
		public ModuleExportAttribute(global::System.Type moduleType) : base(typeof(global::Microsoft.Practices.Prism.Modularity.IModule))
		{
			if (moduleType == null)
			{
				throw new global::System.ArgumentNullException("moduleType");
			}
			this.ModuleName = moduleType.Name;
			this.ModuleType = moduleType;
		}

		// Token: 0x0600003E RID: 62 RVA: 0x00002D64 File Offset: 0x00000F64
		public ModuleExportAttribute(string moduleName, global::System.Type moduleType) : base(typeof(global::Microsoft.Practices.Prism.Modularity.IModule))
		{
			this.ModuleName = moduleName;
			this.ModuleType = moduleType;
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x0600003F RID: 63 RVA: 0x00002D84 File Offset: 0x00000F84
		// (set) Token: 0x06000040 RID: 64 RVA: 0x00002D8C File Offset: 0x00000F8C
		public string ModuleName { get; private set; }

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x06000041 RID: 65 RVA: 0x00002D95 File Offset: 0x00000F95
		// (set) Token: 0x06000042 RID: 66 RVA: 0x00002D9D File Offset: 0x00000F9D
		public global::System.Type ModuleType { get; private set; }

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x06000043 RID: 67 RVA: 0x00002DA6 File Offset: 0x00000FA6
		// (set) Token: 0x06000044 RID: 68 RVA: 0x00002DAE File Offset: 0x00000FAE
		public global::Microsoft.Practices.Prism.Modularity.InitializationMode InitializationMode { get; set; }

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x06000045 RID: 69 RVA: 0x00002DB7 File Offset: 0x00000FB7
		// (set) Token: 0x06000046 RID: 70 RVA: 0x00002DBF File Offset: 0x00000FBF
		[global::System.ComponentModel.DefaultValue(new string[]
		{

		})]
		public string[] DependsOnModuleNames { get; set; }
	}
}
