using System;

namespace System.Data.Entity.Core.Objects.DataClasses
{
	// Token: 0x02000475 RID: 1141
	public abstract class EdmTypeAttribute : global::System.Attribute
	{
		// Token: 0x060037C7 RID: 14279 RVA: 0x000B5A41 File Offset: 0x000B3C41
		internal EdmTypeAttribute()
		{
		}

		// Token: 0x17000AB8 RID: 2744
		// (get) Token: 0x060037C8 RID: 14280 RVA: 0x000B5A49 File Offset: 0x000B3C49
		// (set) Token: 0x060037C9 RID: 14281 RVA: 0x000B5A51 File Offset: 0x000B3C51
		public string Name { get; set; }

		// Token: 0x17000AB9 RID: 2745
		// (get) Token: 0x060037CA RID: 14282 RVA: 0x000B5A5A File Offset: 0x000B3C5A
		// (set) Token: 0x060037CB RID: 14283 RVA: 0x000B5A62 File Offset: 0x000B3C62
		public string NamespaceName { get; set; }
	}
}
