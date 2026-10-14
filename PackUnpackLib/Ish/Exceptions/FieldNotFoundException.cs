using System;
using System.Runtime.Serialization;

namespace Motorola.Acp.PackUnpack.Ish.Exceptions
{
	// Token: 0x0200007E RID: 126
	public class FieldNotFoundException : global::Motorola.Acp.PackUnpack.Ish.Exceptions.PackUnpackException
	{
		// Token: 0x0600039B RID: 923 RVA: 0x000467D4 File Offset: 0x000449D4
		internal FieldNotFoundException()
		{
		}

		// Token: 0x0600039C RID: 924 RVA: 0x000467E8 File Offset: 0x000449E8
		internal FieldNotFoundException(string A_0) : base(A_0)
		{
		}

		// Token: 0x0600039D RID: 925 RVA: 0x000467FC File Offset: 0x000449FC
		protected FieldNotFoundException(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x0600039E RID: 926 RVA: 0x00046814 File Offset: 0x00044A14
		internal FieldNotFoundException(string A_0, global::System.Exception A_1) : base(A_0, A_1)
		{
		}
	}
}
