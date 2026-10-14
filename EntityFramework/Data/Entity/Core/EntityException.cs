using System;
using System.Data.Entity.Resources;
using System.Runtime.Serialization;

namespace System.Data.Entity.Core
{
	// Token: 0x020002CF RID: 719
	[global::System.Serializable]
	public class EntityException : global::System.Data.DataException
	{
		// Token: 0x060022B6 RID: 8886 RVA: 0x000610F4 File Offset: 0x0005F2F4
		public EntityException() : base(global::System.Data.Entity.Resources.Strings.EntityClient_ProviderGeneralError)
		{
		}

		// Token: 0x060022B7 RID: 8887 RVA: 0x00061101 File Offset: 0x0005F301
		public EntityException(string message) : base(message)
		{
		}

		// Token: 0x060022B8 RID: 8888 RVA: 0x0006110A File Offset: 0x0005F30A
		public EntityException(string message, global::System.Exception innerException) : base(message, innerException)
		{
		}

		// Token: 0x060022B9 RID: 8889 RVA: 0x00061114 File Offset: 0x0005F314
		protected EntityException(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}
	}
}
