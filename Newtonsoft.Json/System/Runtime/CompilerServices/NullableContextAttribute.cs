using System;
using Microsoft.CodeAnalysis;

namespace System.Runtime.CompilerServices
{
	// Token: 0x02000005 RID: 5
	[global::System.Runtime.CompilerServices.CompilerGenerated]
	[global::Microsoft.CodeAnalysis.Embedded]
	[global::System.AttributeUsage(global::System.AttributeTargets.Class | global::System.AttributeTargets.Struct | global::System.AttributeTargets.Method | global::System.AttributeTargets.Interface | global::System.AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableContextAttribute : global::System.Attribute
	{
		// Token: 0x06000005 RID: 5 RVA: 0x00002087 File Offset: 0x00000287
		public NullableContextAttribute(byte A_1)
		{
			this.Flag = A_1;
		}

		// Token: 0x04000002 RID: 2
		public readonly byte Flag;
	}
}
