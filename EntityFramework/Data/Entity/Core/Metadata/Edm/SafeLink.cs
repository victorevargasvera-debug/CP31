using System;
using System.Collections.Generic;

namespace System.Data.Entity.Core.Metadata.Edm
{
	// Token: 0x020004F8 RID: 1272
	internal class SafeLink<TParent> where TParent : class
	{
		// Token: 0x17000C67 RID: 3175
		// (get) Token: 0x06003F17 RID: 16151 RVA: 0x000D0DD1 File Offset: 0x000CEFD1
		public TParent Value
		{
			get
			{
				return this._value;
			}
		}

		// Token: 0x06003F18 RID: 16152 RVA: 0x000D0DDC File Offset: 0x000CEFDC
		internal static global::System.Collections.Generic.IEnumerable<TChild> BindChildren<TChild>(TParent parent, global::System.Func<TChild, global::System.Data.Entity.Core.Metadata.Edm.SafeLink<TParent>> getLink, global::System.Collections.Generic.IEnumerable<TChild> children)
		{
			foreach (TChild child in children)
			{
				global::System.Data.Entity.Core.Metadata.Edm.SafeLink<TParent>.BindChild<TChild>(parent, getLink, child);
			}
			return children;
		}

		// Token: 0x06003F19 RID: 16153 RVA: 0x000D0E28 File Offset: 0x000CF028
		internal static TChild BindChild<TChild>(TParent parent, global::System.Func<TChild, global::System.Data.Entity.Core.Metadata.Edm.SafeLink<TParent>> getLink, TChild child)
		{
			getLink(child)._value = parent;
			return child;
		}

		// Token: 0x04001585 RID: 5509
		private TParent _value;
	}
}
