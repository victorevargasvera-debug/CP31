using System;
using System.Runtime.Serialization;

namespace Microsoft.Practices.Prism.Regions
{
	// Token: 0x02000085 RID: 133
	[global::System.Serializable]
	public class ViewRegistrationException : global::System.Exception
	{
		// Token: 0x0600038F RID: 911 RVA: 0x00009F50 File Offset: 0x00008150
		public ViewRegistrationException()
		{
		}

		// Token: 0x06000390 RID: 912 RVA: 0x00009F58 File Offset: 0x00008158
		public ViewRegistrationException(string message) : base(message)
		{
		}

		// Token: 0x06000391 RID: 913 RVA: 0x00009F61 File Offset: 0x00008161
		public ViewRegistrationException(string message, global::System.Exception inner) : base(message, inner)
		{
		}

		// Token: 0x06000392 RID: 914 RVA: 0x00009F6B File Offset: 0x0000816B
		protected ViewRegistrationException(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}
	}
}
