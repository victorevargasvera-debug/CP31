using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Ionic.Zip
{
	// Token: 0x0200003B RID: 59
	[global::System.Runtime.InteropServices.Guid("ebc25cf6-9120-4283-b972-0e5520d0000B")]
	[global::System.Serializable]
	public class BadPasswordException : global::Ionic.Zip.ZipException
	{
		// Token: 0x060002C1 RID: 705 RVA: 0x00011870 File Offset: 0x0000FA70
		public BadPasswordException()
		{
		}

		// Token: 0x060002C2 RID: 706 RVA: 0x00011878 File Offset: 0x0000FA78
		public BadPasswordException(string message) : base(message)
		{
		}

		// Token: 0x060002C3 RID: 707 RVA: 0x00011881 File Offset: 0x0000FA81
		public BadPasswordException(string message, global::System.Exception innerException) : base(message, innerException)
		{
		}

		// Token: 0x060002C4 RID: 708 RVA: 0x0001188B File Offset: 0x0000FA8B
		protected BadPasswordException(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}
	}
}
