using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace System.Data.Entity.Infrastructure
{
	// Token: 0x02000259 RID: 601
	[global::System.Serializable]
	public sealed class ObjectReferenceEqualityComparer : global::System.Collections.Generic.IEqualityComparer<object>
	{
		// Token: 0x170006C6 RID: 1734
		// (get) Token: 0x06001ED1 RID: 7889 RVA: 0x00054BC7 File Offset: 0x00052DC7
		public static global::System.Data.Entity.Infrastructure.ObjectReferenceEqualityComparer Default
		{
			get
			{
				return global::System.Data.Entity.Infrastructure.ObjectReferenceEqualityComparer._default;
			}
		}

		// Token: 0x06001ED2 RID: 7890 RVA: 0x00054BCE File Offset: 0x00052DCE
		bool global::System.Collections.Generic.IEqualityComparer<object>.Equals(object x, object y)
		{
			return x == y;
		}

		// Token: 0x06001ED3 RID: 7891 RVA: 0x00054BD4 File Offset: 0x00052DD4
		int global::System.Collections.Generic.IEqualityComparer<object>.GetHashCode(object obj)
		{
			return global::System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(obj);
		}

		// Token: 0x04000B39 RID: 2873
		private static readonly global::System.Data.Entity.Infrastructure.ObjectReferenceEqualityComparer _default = new global::System.Data.Entity.Infrastructure.ObjectReferenceEqualityComparer();
	}
}
