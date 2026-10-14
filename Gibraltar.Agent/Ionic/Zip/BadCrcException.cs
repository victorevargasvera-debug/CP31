using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Ionic.Zip
{
	// Token: 0x02000458 RID: 1112
	[global::System.Runtime.InteropServices.Guid("ebc25cf6-9120-4283-b972-0e5520d00009")]
	[global::System.Serializable]
	internal class BadCrcException : global::Ionic.Zip.ZipException
	{
		// Token: 0x06002FF1 RID: 12273 RVA: 0x000A9E48 File Offset: 0x000A8048
		public BadCrcException()
		{
		}

		// Token: 0x06002FF2 RID: 12274 RVA: 0x000A9E50 File Offset: 0x000A8050
		public BadCrcException(string message) : base(message)
		{
		}

		// Token: 0x06002FF3 RID: 12275 RVA: 0x000A9E5C File Offset: 0x000A805C
		protected BadCrcException(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}
	}
}
