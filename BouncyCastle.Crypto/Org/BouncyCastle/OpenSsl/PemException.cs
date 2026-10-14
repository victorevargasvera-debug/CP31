using System;
using System.IO;

namespace Org.BouncyCastle.OpenSsl
{
	// Token: 0x020001B9 RID: 441
	[global::System.Serializable]
	public class PemException : global::System.IO.IOException
	{
		// Token: 0x06001090 RID: 4240 RVA: 0x000436E0 File Offset: 0x000418E0
		public PemException(string message) : base(message)
		{
		}

		// Token: 0x06001091 RID: 4241 RVA: 0x000436E9 File Offset: 0x000418E9
		public PemException(string message, global::System.Exception exception) : base(message, exception)
		{
		}
	}
}
