using System;
using System.Runtime.Serialization;

namespace Motorola.Acp.PackUnpack.Ish.Exceptions
{
	// Token: 0x0200007C RID: 124
	public class ExchangeNotFoundException : global::Motorola.Acp.PackUnpack.Ish.Exceptions.PackUnpackException
	{
		// Token: 0x06000393 RID: 915 RVA: 0x00046724 File Offset: 0x00044924
		internal ExchangeNotFoundException()
		{
		}

		// Token: 0x06000394 RID: 916 RVA: 0x00046738 File Offset: 0x00044938
		internal ExchangeNotFoundException(string A_0) : base(A_0)
		{
		}

		// Token: 0x06000395 RID: 917 RVA: 0x0004674C File Offset: 0x0004494C
		protected ExchangeNotFoundException(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x06000396 RID: 918 RVA: 0x00046764 File Offset: 0x00044964
		internal ExchangeNotFoundException(string A_0, global::System.Exception A_1) : base(A_0, A_1)
		{
		}
	}
}
