using System;
using System.Runtime.Serialization;

namespace Motorola.Acp.PackUnpack.Ish.Exceptions
{
	// Token: 0x02000080 RID: 128
	public class IshItemNotFoundException : global::Motorola.Acp.PackUnpack.Ish.Exceptions.PackUnpackException
	{
		// Token: 0x060003A3 RID: 931 RVA: 0x00046884 File Offset: 0x00044A84
		internal IshItemNotFoundException()
		{
		}

		// Token: 0x060003A4 RID: 932 RVA: 0x00046898 File Offset: 0x00044A98
		internal IshItemNotFoundException(string A_0) : base(A_0)
		{
		}

		// Token: 0x060003A5 RID: 933 RVA: 0x000468AC File Offset: 0x00044AAC
		protected IshItemNotFoundException(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x060003A6 RID: 934 RVA: 0x000468C4 File Offset: 0x00044AC4
		internal IshItemNotFoundException(string A_0, global::System.Exception A_1) : base(A_0, A_1)
		{
		}
	}
}
