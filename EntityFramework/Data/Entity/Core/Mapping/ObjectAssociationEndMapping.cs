using System;
using System.Data.Entity.Core.Metadata.Edm;

namespace System.Data.Entity.Core.Mapping
{
	// Token: 0x02000553 RID: 1363
	internal class ObjectAssociationEndMapping : global::System.Data.Entity.Core.Mapping.ObjectMemberMapping
	{
		// Token: 0x060042EA RID: 17130 RVA: 0x000E5448 File Offset: 0x000E3648
		internal ObjectAssociationEndMapping(global::System.Data.Entity.Core.Metadata.Edm.AssociationEndMember edmAssociationEnd, global::System.Data.Entity.Core.Metadata.Edm.AssociationEndMember clrAssociationEnd) : base(edmAssociationEnd, clrAssociationEnd)
		{
		}

		// Token: 0x17000D42 RID: 3394
		// (get) Token: 0x060042EB RID: 17131 RVA: 0x000E5452 File Offset: 0x000E3652
		internal override global::System.Data.Entity.Core.Mapping.MemberMappingKind MemberMappingKind
		{
			get
			{
				return global::System.Data.Entity.Core.Mapping.MemberMappingKind.AssociationEndMapping;
			}
		}
	}
}
