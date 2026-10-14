using System;
using System.Data.Entity.Core.Metadata.Edm;

namespace System.Data.Entity.Core.Mapping
{
	// Token: 0x02000557 RID: 1367
	internal class ObjectNavigationPropertyMapping : global::System.Data.Entity.Core.Mapping.ObjectMemberMapping
	{
		// Token: 0x060042F2 RID: 17138 RVA: 0x000E5488 File Offset: 0x000E3688
		internal ObjectNavigationPropertyMapping(global::System.Data.Entity.Core.Metadata.Edm.NavigationProperty edmNavigationProperty, global::System.Data.Entity.Core.Metadata.Edm.NavigationProperty clrNavigationProperty) : base(edmNavigationProperty, clrNavigationProperty)
		{
		}

		// Token: 0x17000D47 RID: 3399
		// (get) Token: 0x060042F3 RID: 17139 RVA: 0x000E5492 File Offset: 0x000E3692
		internal override global::System.Data.Entity.Core.Mapping.MemberMappingKind MemberMappingKind
		{
			get
			{
				return global::System.Data.Entity.Core.Mapping.MemberMappingKind.NavigationPropertyMapping;
			}
		}
	}
}
