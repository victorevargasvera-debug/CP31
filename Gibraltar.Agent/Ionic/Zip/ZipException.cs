using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Ionic.Zip
{
	// Token: 0x0200045B RID: 1115
	[global::System.Runtime.InteropServices.Guid("ebc25cf6-9120-4283-b972-0e5520d00006")]
	[global::System.Serializable]
	internal class ZipException : global::System.Exception
	{
		// Token: 0x06002FFB RID: 12283 RVA: 0x000A9EB4 File Offset: 0x000A80B4
		public ZipException()
		{
		}

		// Token: 0x06002FFC RID: 12284 RVA: 0x000A9EBC File Offset: 0x000A80BC
		public ZipException(string message) : base(message)
		{
		}

		// Token: 0x06002FFD RID: 12285 RVA: 0x000A9EC8 File Offset: 0x000A80C8
		public ZipException(string message, global::System.Exception innerException) : base(message, innerException)
		{
		}

		// Token: 0x06002FFE RID: 12286 RVA: 0x000A9ED4 File Offset: 0x000A80D4
		protected ZipException(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}
	}
}
