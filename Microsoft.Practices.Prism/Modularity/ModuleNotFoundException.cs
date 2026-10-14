using System;
using System.Runtime.Serialization;

namespace Microsoft.Practices.Prism.Modularity
{
	// Token: 0x02000030 RID: 48
	[global::System.Serializable]
	public class ModuleNotFoundException : global::Microsoft.Practices.Prism.Modularity.ModularityException
	{
		// Token: 0x06000104 RID: 260 RVA: 0x000048D4 File Offset: 0x00002AD4
		protected ModuleNotFoundException(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x06000105 RID: 261 RVA: 0x000048DE File Offset: 0x00002ADE
		public ModuleNotFoundException()
		{
		}

		// Token: 0x06000106 RID: 262 RVA: 0x000048E6 File Offset: 0x00002AE6
		public ModuleNotFoundException(string message) : base(message)
		{
		}

		// Token: 0x06000107 RID: 263 RVA: 0x000048EF File Offset: 0x00002AEF
		public ModuleNotFoundException(string message, global::System.Exception innerException) : base(message, innerException)
		{
		}

		// Token: 0x06000108 RID: 264 RVA: 0x000048F9 File Offset: 0x00002AF9
		public ModuleNotFoundException(string moduleName, string message) : base(moduleName, message)
		{
		}

		// Token: 0x06000109 RID: 265 RVA: 0x00004903 File Offset: 0x00002B03
		public ModuleNotFoundException(string moduleName, string message, global::System.Exception innerException) : base(moduleName, message, innerException)
		{
		}
	}
}
