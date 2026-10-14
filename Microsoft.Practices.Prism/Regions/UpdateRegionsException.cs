using System;
using System.Runtime.Serialization;

namespace Microsoft.Practices.Prism.Regions
{
	// Token: 0x02000081 RID: 129
	[global::System.Serializable]
	public class UpdateRegionsException : global::System.Exception
	{
		// Token: 0x0600037B RID: 891 RVA: 0x00009CE8 File Offset: 0x00007EE8
		public UpdateRegionsException()
		{
		}

		// Token: 0x0600037C RID: 892 RVA: 0x00009CF0 File Offset: 0x00007EF0
		public UpdateRegionsException(string message) : base(message)
		{
		}

		// Token: 0x0600037D RID: 893 RVA: 0x00009CF9 File Offset: 0x00007EF9
		public UpdateRegionsException(string message, global::System.Exception inner) : base(message, inner)
		{
		}

		// Token: 0x0600037E RID: 894 RVA: 0x00009D03 File Offset: 0x00007F03
		protected UpdateRegionsException(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}
	}
}
