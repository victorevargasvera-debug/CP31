using System;
using System.Runtime.Serialization;

namespace Microsoft.Practices.Prism.Modularity
{
	// Token: 0x02000031 RID: 49
	[global::System.Serializable]
	public class CyclicDependencyFoundException : global::Microsoft.Practices.Prism.Modularity.ModularityException
	{
		// Token: 0x0600010A RID: 266 RVA: 0x0000490E File Offset: 0x00002B0E
		public CyclicDependencyFoundException()
		{
		}

		// Token: 0x0600010B RID: 267 RVA: 0x00004916 File Offset: 0x00002B16
		public CyclicDependencyFoundException(string message) : base(message)
		{
		}

		// Token: 0x0600010C RID: 268 RVA: 0x0000491F File Offset: 0x00002B1F
		public CyclicDependencyFoundException(string message, global::System.Exception innerException) : base(message, innerException)
		{
		}

		// Token: 0x0600010D RID: 269 RVA: 0x00004929 File Offset: 0x00002B29
		public CyclicDependencyFoundException(string moduleName, string message, global::System.Exception innerException) : base(moduleName, message, innerException)
		{
		}

		// Token: 0x0600010E RID: 270 RVA: 0x00004934 File Offset: 0x00002B34
		protected CyclicDependencyFoundException(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}
	}
}
