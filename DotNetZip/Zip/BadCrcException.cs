using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Ionic.Zip
{
	// Token: 0x0200003D RID: 61
	[global::System.Runtime.InteropServices.Guid("ebc25cf6-9120-4283-b972-0e5520d00009")]
	[global::System.Serializable]
	public class BadCrcException : global::Ionic.Zip.ZipException
	{
		// Token: 0x060002C9 RID: 713 RVA: 0x00011870 File Offset: 0x0000FA70
		public BadCrcException()
		{
		}

		// Token: 0x060002CA RID: 714 RVA: 0x00011878 File Offset: 0x0000FA78
		public BadCrcException(string message) : base(message)
		{
		}

		// Token: 0x060002CB RID: 715 RVA: 0x0001188B File Offset: 0x0000FA8B
		protected BadCrcException(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}
	}
}
