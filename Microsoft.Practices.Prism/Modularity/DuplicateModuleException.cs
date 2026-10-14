using System;
using System.Runtime.Serialization;

namespace Microsoft.Practices.Prism.Modularity
{
	// Token: 0x02000032 RID: 50
	[global::System.Serializable]
	public class DuplicateModuleException : global::Microsoft.Practices.Prism.Modularity.ModularityException
	{
		// Token: 0x0600010F RID: 271 RVA: 0x0000493E File Offset: 0x00002B3E
		protected DuplicateModuleException(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x06000110 RID: 272 RVA: 0x00004948 File Offset: 0x00002B48
		public DuplicateModuleException()
		{
		}

		// Token: 0x06000111 RID: 273 RVA: 0x00004950 File Offset: 0x00002B50
		public DuplicateModuleException(string message) : base(message)
		{
		}

		// Token: 0x06000112 RID: 274 RVA: 0x00004959 File Offset: 0x00002B59
		public DuplicateModuleException(string message, global::System.Exception innerException) : base(message, innerException)
		{
		}

		// Token: 0x06000113 RID: 275 RVA: 0x00004963 File Offset: 0x00002B63
		public DuplicateModuleException(string moduleName, string message) : base(moduleName, message)
		{
		}

		// Token: 0x06000114 RID: 276 RVA: 0x0000496D File Offset: 0x00002B6D
		public DuplicateModuleException(string moduleName, string message, global::System.Exception innerException) : base(moduleName, message, innerException)
		{
		}
	}
}
