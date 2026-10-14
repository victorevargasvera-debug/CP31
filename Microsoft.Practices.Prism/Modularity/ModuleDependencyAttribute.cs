using System;

namespace Microsoft.Practices.Prism.Modularity
{
	// Token: 0x0200003E RID: 62
	[global::System.AttributeUsage(global::System.AttributeTargets.Class, AllowMultiple = true)]
	public sealed class ModuleDependencyAttribute : global::System.Attribute
	{
		// Token: 0x0600018A RID: 394 RVA: 0x00005CE4 File Offset: 0x00003EE4
		public ModuleDependencyAttribute(string moduleName)
		{
			this._moduleName = moduleName;
		}

		// Token: 0x1700003D RID: 61
		// (get) Token: 0x0600018B RID: 395 RVA: 0x00005CF3 File Offset: 0x00003EF3
		public string ModuleName
		{
			get
			{
				return this._moduleName;
			}
		}

		// Token: 0x04000065 RID: 101
		private readonly string _moduleName;
	}
}
