using System;
using System.Data.Entity.Resources;
using System.Runtime.Serialization;

namespace System.Data.Entity.Infrastructure
{
	// Token: 0x02000268 RID: 616
	[global::System.Serializable]
	public class UnintentionalCodeFirstException : global::System.InvalidOperationException
	{
		// Token: 0x06001F53 RID: 8019 RVA: 0x00055D41 File Offset: 0x00053F41
		public UnintentionalCodeFirstException() : base(global::System.Data.Entity.Resources.Strings.UnintentionalCodeFirstException_Message)
		{
		}

		// Token: 0x06001F54 RID: 8020 RVA: 0x00055D4E File Offset: 0x00053F4E
		protected UnintentionalCodeFirstException(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x06001F55 RID: 8021 RVA: 0x00055D58 File Offset: 0x00053F58
		public UnintentionalCodeFirstException(string message) : base(message)
		{
		}

		// Token: 0x06001F56 RID: 8022 RVA: 0x00055D61 File Offset: 0x00053F61
		public UnintentionalCodeFirstException(string message, global::System.Exception innerException) : base(message, innerException)
		{
		}
	}
}
