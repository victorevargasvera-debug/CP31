using System;

namespace Microsoft.Practices.Prism.Modularity
{
	// Token: 0x02000039 RID: 57
	[global::System.AttributeUsage(global::System.AttributeTargets.Class, AllowMultiple = false)]
	public sealed class ModuleAttribute : global::System.Attribute
	{
		// Token: 0x1700002C RID: 44
		// (get) Token: 0x06000141 RID: 321 RVA: 0x000050A8 File Offset: 0x000032A8
		// (set) Token: 0x06000142 RID: 322 RVA: 0x000050B0 File Offset: 0x000032B0
		public string ModuleName { get; set; }

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x06000143 RID: 323 RVA: 0x000050B9 File Offset: 0x000032B9
		// (set) Token: 0x06000144 RID: 324 RVA: 0x000050C4 File Offset: 0x000032C4
		[global::System.Obsolete("StartupLoaded has been replaced by the OnDemand property.")]
		public bool StartupLoaded
		{
			get
			{
				return !this.OnDemand;
			}
			set
			{
				this.OnDemand = !value;
			}
		}

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x06000145 RID: 325 RVA: 0x000050D0 File Offset: 0x000032D0
		// (set) Token: 0x06000146 RID: 326 RVA: 0x000050D8 File Offset: 0x000032D8
		public bool OnDemand { get; set; }
	}
}
