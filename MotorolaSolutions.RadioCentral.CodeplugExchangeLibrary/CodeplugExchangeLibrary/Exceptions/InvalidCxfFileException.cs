using System;
using System.Runtime.Serialization;

namespace CodeplugExchangeLibrary.Exceptions
{
	// Token: 0x0200000B RID: 11
	[global::System.Serializable]
	public class InvalidCxfFileException : global::System.Exception
	{
		// Token: 0x0600002B RID: 43 RVA: 0x00004464 File Offset: 0x00002664
		public InvalidCxfFileException()
		{
		}

		// Token: 0x0600002C RID: 44 RVA: 0x00004478 File Offset: 0x00002678
		public InvalidCxfFileException(string message) : base(message)
		{
		}

		// Token: 0x0600002D RID: 45 RVA: 0x0000448C File Offset: 0x0000268C
		public InvalidCxfFileException(string message, global::System.Exception innerException) : base(message, innerException)
		{
		}

		// Token: 0x0600002E RID: 46 RVA: 0x000044A4 File Offset: 0x000026A4
		protected InvalidCxfFileException(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}
	}
}
