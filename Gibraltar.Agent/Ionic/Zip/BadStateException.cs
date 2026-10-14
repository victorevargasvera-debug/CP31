using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Ionic.Zip
{
	// Token: 0x0200045A RID: 1114
	[global::System.Runtime.InteropServices.Guid("ebc25cf6-9120-4283-b972-0e5520d00007")]
	[global::System.Serializable]
	internal class BadStateException : global::Ionic.Zip.ZipException
	{
		// Token: 0x06002FF7 RID: 12279 RVA: 0x000A9E88 File Offset: 0x000A8088
		public BadStateException()
		{
		}

		// Token: 0x06002FF8 RID: 12280 RVA: 0x000A9E90 File Offset: 0x000A8090
		public BadStateException(string message) : base(message)
		{
		}

		// Token: 0x06002FF9 RID: 12281 RVA: 0x000A9E9C File Offset: 0x000A809C
		public BadStateException(string message, global::System.Exception innerException) : base(message, innerException)
		{
		}

		// Token: 0x06002FFA RID: 12282 RVA: 0x000A9EA8 File Offset: 0x000A80A8
		protected BadStateException(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}
	}
}
