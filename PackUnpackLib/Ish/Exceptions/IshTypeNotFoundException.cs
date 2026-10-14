using System;
using System.Runtime.Serialization;

namespace Motorola.Acp.PackUnpack.Ish.Exceptions
{
	// Token: 0x02000081 RID: 129
	public class IshTypeNotFoundException : global::Motorola.Acp.PackUnpack.Ish.Exceptions.PackUnpackException
	{
		// Token: 0x060003A7 RID: 935 RVA: 0x000468DC File Offset: 0x00044ADC
		internal IshTypeNotFoundException()
		{
		}

		// Token: 0x060003A8 RID: 936 RVA: 0x000468F0 File Offset: 0x00044AF0
		internal IshTypeNotFoundException(string A_0) : base(A_0)
		{
		}

		// Token: 0x060003A9 RID: 937 RVA: 0x00046904 File Offset: 0x00044B04
		protected IshTypeNotFoundException(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x060003AA RID: 938 RVA: 0x0004691C File Offset: 0x00044B1C
		internal IshTypeNotFoundException(string A_0, global::System.Exception A_1) : base(A_0, A_1)
		{
		}
	}
}
