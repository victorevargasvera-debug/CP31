using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Ionic.Zip
{
	// Token: 0x0200003C RID: 60
	[global::System.Runtime.InteropServices.Guid("ebc25cf6-9120-4283-b972-0e5520d0000A")]
	[global::System.Serializable]
	public class BadReadException : global::Ionic.Zip.ZipException
	{
		// Token: 0x060002C5 RID: 709 RVA: 0x00011870 File Offset: 0x0000FA70
		public BadReadException()
		{
		}

		// Token: 0x060002C6 RID: 710 RVA: 0x00011878 File Offset: 0x0000FA78
		public BadReadException(string message) : base(message)
		{
		}

		// Token: 0x060002C7 RID: 711 RVA: 0x00011881 File Offset: 0x0000FA81
		public BadReadException(string message, global::System.Exception innerException) : base(message, innerException)
		{
		}

		// Token: 0x060002C8 RID: 712 RVA: 0x0001188B File Offset: 0x0000FA8B
		protected BadReadException(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}
	}
}
