using System;
using System.Data.Entity.Resources;
using System.Runtime.Serialization;

namespace System.Data.Entity.Infrastructure
{
	// Token: 0x02000261 RID: 609
	[global::System.Serializable]
	public class CommitFailedException : global::System.Data.DataException
	{
		// Token: 0x06001EF0 RID: 7920 RVA: 0x00054F53 File Offset: 0x00053153
		public CommitFailedException() : base(global::System.Data.Entity.Resources.Strings.CommitFailed)
		{
		}

		// Token: 0x06001EF1 RID: 7921 RVA: 0x00054F60 File Offset: 0x00053160
		public CommitFailedException(string message) : base(message)
		{
		}

		// Token: 0x06001EF2 RID: 7922 RVA: 0x00054F69 File Offset: 0x00053169
		public CommitFailedException(string message, global::System.Exception innerException) : base(message, innerException)
		{
		}

		// Token: 0x06001EF3 RID: 7923 RVA: 0x00054F73 File Offset: 0x00053173
		protected CommitFailedException(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}
	}
}
