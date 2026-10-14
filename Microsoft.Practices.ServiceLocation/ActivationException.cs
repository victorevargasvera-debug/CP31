using System;
using System.Runtime.Serialization;

namespace Microsoft.Practices.ServiceLocation
{
	// Token: 0x02000002 RID: 2
	[global::System.Serializable]
	public class ActivationException : global::System.Exception
	{
		// Token: 0x06000001 RID: 1 RVA: 0x000020D0 File Offset: 0x000010D0
		public ActivationException()
		{
		}

		// Token: 0x06000002 RID: 2 RVA: 0x000020D8 File Offset: 0x000010D8
		public ActivationException(string message) : base(message)
		{
		}

		// Token: 0x06000003 RID: 3 RVA: 0x000020E1 File Offset: 0x000010E1
		public ActivationException(string message, global::System.Exception innerException) : base(message, innerException)
		{
		}

		// Token: 0x06000004 RID: 4 RVA: 0x000020EB File Offset: 0x000010EB
		protected ActivationException(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}
	}
}
