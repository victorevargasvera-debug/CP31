using System;
using System.Runtime.Serialization;

namespace System.Data.Entity.Core
{
	// Token: 0x020002DC RID: 732
	[global::System.Serializable]
	public sealed class ObjectNotFoundException : global::System.Data.DataException
	{
		// Token: 0x06002331 RID: 9009 RVA: 0x00062725 File Offset: 0x00060925
		public ObjectNotFoundException()
		{
		}

		// Token: 0x06002332 RID: 9010 RVA: 0x0006272D File Offset: 0x0006092D
		public ObjectNotFoundException(string message) : base(message)
		{
		}

		// Token: 0x06002333 RID: 9011 RVA: 0x00062736 File Offset: 0x00060936
		public ObjectNotFoundException(string message, global::System.Exception innerException) : base(message, innerException)
		{
		}

		// Token: 0x06002334 RID: 9012 RVA: 0x00062740 File Offset: 0x00060940
		private ObjectNotFoundException(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}
	}
}
