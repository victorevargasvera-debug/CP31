using System;
using System.Runtime.Serialization;

namespace Motorola.Acp.PackUnpack.Ish.Exceptions
{
	// Token: 0x0200007D RID: 125
	public class PackUnpackException : global::System.SystemException
	{
		// Token: 0x06000397 RID: 919 RVA: 0x0004677C File Offset: 0x0004497C
		internal PackUnpackException()
		{
		}

		// Token: 0x06000398 RID: 920 RVA: 0x00046790 File Offset: 0x00044990
		internal PackUnpackException(string A_0) : base(A_0)
		{
		}

		// Token: 0x06000399 RID: 921 RVA: 0x000467A4 File Offset: 0x000449A4
		protected PackUnpackException(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x0600039A RID: 922 RVA: 0x000467BC File Offset: 0x000449BC
		internal PackUnpackException(string A_0, global::System.Exception A_1) : base(A_0, A_1)
		{
		}
	}
}
