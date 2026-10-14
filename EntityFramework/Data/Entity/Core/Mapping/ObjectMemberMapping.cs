using System;
using System.Data.Entity.Core.Metadata.Edm;

namespace System.Data.Entity.Core.Mapping
{
	// Token: 0x02000555 RID: 1365
	internal abstract class ObjectMemberMapping
	{
		// Token: 0x060042EE RID: 17134 RVA: 0x000E5462 File Offset: 0x000E3662
		protected ObjectMemberMapping(global::System.Data.Entity.Core.Metadata.Edm.EdmMember edmMember, global::System.Data.Entity.Core.Metadata.Edm.EdmMember clrMember)
		{
			this.m_edmMember = edmMember;
			this.m_clrMember = clrMember;
		}

		// Token: 0x17000D44 RID: 3396
		// (get) Token: 0x060042EF RID: 17135 RVA: 0x000E5478 File Offset: 0x000E3678
		internal global::System.Data.Entity.Core.Metadata.Edm.EdmMember EdmMember
		{
			get
			{
				return this.m_edmMember;
			}
		}

		// Token: 0x17000D45 RID: 3397
		// (get) Token: 0x060042F0 RID: 17136 RVA: 0x000E5480 File Offset: 0x000E3680
		internal global::System.Data.Entity.Core.Metadata.Edm.EdmMember ClrMember
		{
			get
			{
				return this.m_clrMember;
			}
		}

		// Token: 0x17000D46 RID: 3398
		// (get) Token: 0x060042F1 RID: 17137
		internal abstract global::System.Data.Entity.Core.Mapping.MemberMappingKind MemberMappingKind { get; }

		// Token: 0x040017E3 RID: 6115
		private readonly global::System.Data.Entity.Core.Metadata.Edm.EdmMember m_edmMember;

		// Token: 0x040017E4 RID: 6116
		private readonly global::System.Data.Entity.Core.Metadata.Edm.EdmMember m_clrMember;
	}
}
