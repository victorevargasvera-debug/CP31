using System;
using System.Runtime.Serialization;

namespace CodeplugExchangeLibrary.Exceptions
{
	// Token: 0x0200000A RID: 10
	[global::System.Serializable]
	public class CxfFileException : global::System.Exception
	{
		// Token: 0x06000027 RID: 39 RVA: 0x0000440C File Offset: 0x0000260C
		public CxfFileException()
		{
		}

		// Token: 0x06000028 RID: 40 RVA: 0x00004420 File Offset: 0x00002620
		public CxfFileException(string message) : base(message)
		{
		}

		// Token: 0x06000029 RID: 41 RVA: 0x00004434 File Offset: 0x00002634
		public CxfFileException(string message, global::System.Exception innerException) : base(message, innerException)
		{
		}

		// Token: 0x0600002A RID: 42 RVA: 0x0000444C File Offset: 0x0000264C
		protected CxfFileException(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}
	}
}
