using System;
using System.Runtime.Serialization;

namespace Microsoft.Practices.Prism.Modularity
{
	// Token: 0x02000096 RID: 150
	[global::System.Serializable]
	public class ModuleTypeLoaderNotFoundException : global::Microsoft.Practices.Prism.Modularity.ModularityException
	{
		// Token: 0x060003F4 RID: 1012 RVA: 0x0000B666 File Offset: 0x00009866
		public ModuleTypeLoaderNotFoundException()
		{
		}

		// Token: 0x060003F5 RID: 1013 RVA: 0x0000B66E File Offset: 0x0000986E
		public ModuleTypeLoaderNotFoundException(string message) : base(message)
		{
		}

		// Token: 0x060003F6 RID: 1014 RVA: 0x0000B677 File Offset: 0x00009877
		public ModuleTypeLoaderNotFoundException(string message, global::System.Exception innerException) : base(message, innerException)
		{
		}

		// Token: 0x060003F7 RID: 1015 RVA: 0x0000B681 File Offset: 0x00009881
		public ModuleTypeLoaderNotFoundException(string moduleName, string message, global::System.Exception innerException) : base(moduleName, message, innerException)
		{
		}

		// Token: 0x060003F8 RID: 1016 RVA: 0x0000B68C File Offset: 0x0000988C
		protected ModuleTypeLoaderNotFoundException(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}
	}
}
