using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Ionic.Zip
{
	// Token: 0x02000040 RID: 64
	[global::System.Runtime.InteropServices.Guid("ebc25cf6-9120-4283-b972-0e5520d00006")]
	[global::System.Serializable]
	public class ZipException : global::System.Exception
	{
		// Token: 0x060002D3 RID: 723 RVA: 0x0000AE31 File Offset: 0x00009031
		public ZipException()
		{
		}

		// Token: 0x060002D4 RID: 724 RVA: 0x0000AE39 File Offset: 0x00009039
		public ZipException(string message) : base(message)
		{
		}

		// Token: 0x060002D5 RID: 725 RVA: 0x00011895 File Offset: 0x0000FA95
		public ZipException(string message, global::System.Exception innerException) : base(message, innerException)
		{
		}

		// Token: 0x060002D6 RID: 726 RVA: 0x0001189F File Offset: 0x0000FA9F
		protected ZipException(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}
	}
}
