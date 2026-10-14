using System;

namespace Microsoft.Practices.Prism.Modularity
{
	// Token: 0x02000037 RID: 55
	public static class ModuleInfoGroupExtensions
	{
		// Token: 0x06000122 RID: 290 RVA: 0x00004978 File Offset: 0x00002B78
		public static global::Microsoft.Practices.Prism.Modularity.ModuleInfoGroup AddModule(this global::Microsoft.Practices.Prism.Modularity.ModuleInfoGroup moduleInfoGroup, string moduleName, global::System.Type moduleType, params string[] dependsOn)
		{
			if (moduleType == null)
			{
				throw new global::System.ArgumentNullException("moduleType");
			}
			if (moduleInfoGroup == null)
			{
				throw new global::System.ArgumentNullException("moduleInfoGroup");
			}
			global::Microsoft.Practices.Prism.Modularity.ModuleInfo moduleInfo = new global::Microsoft.Practices.Prism.Modularity.ModuleInfo(moduleName, moduleType.AssemblyQualifiedName);
			moduleInfo.DependsOn.AddRange(dependsOn);
			moduleInfoGroup.Add(moduleInfo);
			return moduleInfoGroup;
		}

		// Token: 0x06000123 RID: 291 RVA: 0x000049C9 File Offset: 0x00002BC9
		public static global::Microsoft.Practices.Prism.Modularity.ModuleInfoGroup AddModule(this global::Microsoft.Practices.Prism.Modularity.ModuleInfoGroup moduleInfoGroup, global::System.Type moduleType, params string[] dependsOn)
		{
			if (moduleType == null)
			{
				throw new global::System.ArgumentNullException("moduleType");
			}
			return moduleInfoGroup.AddModule(moduleType.Name, moduleType, dependsOn);
		}
	}
}
