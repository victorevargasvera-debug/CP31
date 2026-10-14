using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Ionic.Zip
{
	// Token: 0x02000456 RID: 1110
	[global::System.Runtime.InteropServices.Guid("ebc25cf6-9120-4283-b972-0e5520d0000B")]
	[global::System.Serializable]
	internal class BadPasswordException : global::Ionic.Zip.ZipException
	{
		// Token: 0x06002FE9 RID: 12265 RVA: 0x000A9DF0 File Offset: 0x000A7FF0
		public BadPasswordException()
		{
		}

		// Token: 0x06002FEA RID: 12266 RVA: 0x000A9DF8 File Offset: 0x000A7FF8
		public BadPasswordException(string message) : base(message)
		{
		}

		// Token: 0x06002FEB RID: 12267 RVA: 0x000A9E04 File Offset: 0x000A8004
		public BadPasswordException(string message, global::System.Exception innerException) : base(message, innerException)
		{
		}

		// Token: 0x06002FEC RID: 12268 RVA: 0x000A9E10 File Offset: 0x000A8010
		protected BadPasswordException(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}
	}
}
