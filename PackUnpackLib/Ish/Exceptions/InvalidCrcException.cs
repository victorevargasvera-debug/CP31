using System;
using System.Runtime.Serialization;

namespace Motorola.Acp.PackUnpack.Ish.Exceptions
{
	// Token: 0x0200007F RID: 127
	public class InvalidCrcException : global::Motorola.Acp.PackUnpack.Ish.Exceptions.PackUnpackException
	{
		// Token: 0x0600039F RID: 927 RVA: 0x0004682C File Offset: 0x00044A2C
		internal InvalidCrcException()
		{
		}

		// Token: 0x060003A0 RID: 928 RVA: 0x00046840 File Offset: 0x00044A40
		internal InvalidCrcException(string A_0) : base(A_0)
		{
		}

		// Token: 0x060003A1 RID: 929 RVA: 0x00046854 File Offset: 0x00044A54
		protected InvalidCrcException(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x060003A2 RID: 930 RVA: 0x0004686C File Offset: 0x00044A6C
		internal InvalidCrcException(string A_0, global::System.Exception A_1) : base(A_0, A_1)
		{
		}
	}
}
