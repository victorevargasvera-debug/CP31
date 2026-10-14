using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Ionic.Zip
{
	// Token: 0x02000457 RID: 1111
	[global::System.Runtime.InteropServices.Guid("ebc25cf6-9120-4283-b972-0e5520d0000A")]
	[global::System.Serializable]
	internal class BadReadException : global::Ionic.Zip.ZipException
	{
		// Token: 0x06002FED RID: 12269 RVA: 0x000A9E1C File Offset: 0x000A801C
		public BadReadException()
		{
		}

		// Token: 0x06002FEE RID: 12270 RVA: 0x000A9E24 File Offset: 0x000A8024
		public BadReadException(string message) : base(message)
		{
		}

		// Token: 0x06002FEF RID: 12271 RVA: 0x000A9E30 File Offset: 0x000A8030
		public BadReadException(string message, global::System.Exception innerException) : base(message, innerException)
		{
		}

		// Token: 0x06002FF0 RID: 12272 RVA: 0x000A9E3C File Offset: 0x000A803C
		protected BadReadException(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}
	}
}
