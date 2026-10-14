using System;
using System.Data.Entity.Resources;
using System.Runtime.Serialization;

namespace System.Data.Entity.Core
{
	// Token: 0x020002D9 RID: 729
	[global::System.Serializable]
	public sealed class InvalidCommandTreeException : global::System.Data.DataException
	{
		// Token: 0x06002325 RID: 8997 RVA: 0x00062686 File Offset: 0x00060886
		public InvalidCommandTreeException() : base(global::System.Data.Entity.Resources.Strings.Cqt_Exceptions_InvalidCommandTree)
		{
		}

		// Token: 0x06002326 RID: 8998 RVA: 0x00062693 File Offset: 0x00060893
		public InvalidCommandTreeException(string message) : base(message)
		{
		}

		// Token: 0x06002327 RID: 8999 RVA: 0x0006269C File Offset: 0x0006089C
		public InvalidCommandTreeException(string message, global::System.Exception innerException) : base(message, innerException)
		{
		}

		// Token: 0x06002328 RID: 9000 RVA: 0x000626A6 File Offset: 0x000608A6
		private InvalidCommandTreeException(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}
	}
}
