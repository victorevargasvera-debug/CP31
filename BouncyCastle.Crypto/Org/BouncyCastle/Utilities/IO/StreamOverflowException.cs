using System;
using System.IO;

namespace Org.BouncyCastle.Utilities.IO
{
	// Token: 0x02000053 RID: 83
	[global::System.Serializable]
	public class StreamOverflowException : global::System.IO.IOException
	{
		// Token: 0x060003BA RID: 954 RVA: 0x00013E0E File Offset: 0x0001200E
		public StreamOverflowException()
		{
		}

		// Token: 0x060003BB RID: 955 RVA: 0x00013E16 File Offset: 0x00012016
		public StreamOverflowException(string message) : base(message)
		{
		}

		// Token: 0x060003BC RID: 956 RVA: 0x00013E1F File Offset: 0x0001201F
		public StreamOverflowException(string message, global::System.Exception exception) : base(message, exception)
		{
		}
	}
}
