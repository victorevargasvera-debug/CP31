using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Ionic.Zip
{
	// Token: 0x0200003F RID: 63
	[global::System.Runtime.InteropServices.Guid("ebc25cf6-9120-4283-b972-0e5520d00007")]
	[global::System.Serializable]
	public class BadStateException : global::Ionic.Zip.ZipException
	{
		// Token: 0x060002CF RID: 719 RVA: 0x00011870 File Offset: 0x0000FA70
		public BadStateException()
		{
		}

		// Token: 0x060002D0 RID: 720 RVA: 0x00011878 File Offset: 0x0000FA78
		public BadStateException(string message) : base(message)
		{
		}

		// Token: 0x060002D1 RID: 721 RVA: 0x00011881 File Offset: 0x0000FA81
		public BadStateException(string message, global::System.Exception innerException) : base(message, innerException)
		{
		}

		// Token: 0x060002D2 RID: 722 RVA: 0x0001188B File Offset: 0x0000FA8B
		protected BadStateException(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}
	}
}
