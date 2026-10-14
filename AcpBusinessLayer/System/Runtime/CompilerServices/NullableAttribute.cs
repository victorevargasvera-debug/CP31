using System;
using Microsoft.CodeAnalysis;

namespace System.Runtime.CompilerServices
{
	// Token: 0x02000004 RID: 4
	[global::System.AttributeUsage(global::System.AttributeTargets.Class | global::System.AttributeTargets.Property | global::System.AttributeTargets.Field | global::System.AttributeTargets.Event | global::System.AttributeTargets.Parameter | global::System.AttributeTargets.ReturnValue | global::System.AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	[global::Microsoft.CodeAnalysis.Embedded]
	[global::System.Runtime.CompilerServices.CompilerGenerated]
	internal sealed class NullableAttribute : global::System.Attribute
	{
		// Token: 0x06000005 RID: 5 RVA: 0x00002130 File Offset: 0x00000330
		public NullableAttribute(byte A_1)
		{
			this.NullableFlags = new byte[]
			{
				A_1
			};
		}

		// Token: 0x06000006 RID: 6 RVA: 0x00002154 File Offset: 0x00000354
		public NullableAttribute(byte[] A_1)
		{
			this.NullableFlags = A_1;
		}

		// Token: 0x04000003 RID: 3
		public readonly byte[] NullableFlags;
	}
}
