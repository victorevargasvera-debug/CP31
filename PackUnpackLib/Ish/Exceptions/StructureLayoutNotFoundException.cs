using System;
using System.Runtime.Serialization;

namespace Motorola.Acp.PackUnpack.Ish.Exceptions
{
	// Token: 0x02000082 RID: 130
	public class StructureLayoutNotFoundException : global::Motorola.Acp.PackUnpack.Ish.Exceptions.PackUnpackException
	{
		// Token: 0x060003AB RID: 939 RVA: 0x00046934 File Offset: 0x00044B34
		internal StructureLayoutNotFoundException()
		{
		}

		// Token: 0x060003AC RID: 940 RVA: 0x00046948 File Offset: 0x00044B48
		internal StructureLayoutNotFoundException(string A_0) : base(A_0)
		{
		}

		// Token: 0x060003AD RID: 941 RVA: 0x0004695C File Offset: 0x00044B5C
		protected StructureLayoutNotFoundException(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x060003AE RID: 942 RVA: 0x00046974 File Offset: 0x00044B74
		internal StructureLayoutNotFoundException(string A_0, global::System.Exception A_1) : base(A_0, A_1)
		{
		}
	}
}
