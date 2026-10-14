using System;
using System.Collections.Generic;

namespace Gibraltar
{
	// Token: 0x020000B5 RID: 181
	internal class NullOrEmptyStringComparer : global::System.Collections.Generic.EqualityComparer<string>
	{
		// Token: 0x0600079F RID: 1951 RVA: 0x0000E770 File Offset: 0x0000C970
		private NullOrEmptyStringComparer(global::System.StringComparer baseComparer)
		{
			this.m_BaseComparer = baseComparer;
		}

		// Token: 0x060007A0 RID: 1952 RVA: 0x0000E780 File Offset: 0x0000C980
		public override bool Equals(string x, string y)
		{
			return (string.IsNullOrEmpty(x) && string.IsNullOrEmpty(y)) || this.m_BaseComparer.Equals(x, y);
		}

		// Token: 0x060007A1 RID: 1953 RVA: 0x0000E7A8 File Offset: 0x0000C9A8
		public override int GetHashCode(string obj)
		{
			return this.m_BaseComparer.GetHashCode(obj);
		}

		// Token: 0x17000384 RID: 900
		// (get) Token: 0x060007A2 RID: 1954 RVA: 0x0000E7B8 File Offset: 0x0000C9B8
		public static global::System.Collections.Generic.IEqualityComparer<string> OrdinalIgnoreCase
		{
			get
			{
				return new global::Gibraltar.NullOrEmptyStringComparer(global::System.StringComparer.OrdinalIgnoreCase);
			}
		}

		// Token: 0x04000178 RID: 376
		private readonly global::System.StringComparer m_BaseComparer;
	}
}
