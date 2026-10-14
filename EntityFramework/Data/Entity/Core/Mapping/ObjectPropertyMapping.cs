using System;
using System.Data.Entity.Core.Metadata.Edm;

namespace System.Data.Entity.Core.Mapping
{
	// Token: 0x02000558 RID: 1368
	internal class ObjectPropertyMapping : global::System.Data.Entity.Core.Mapping.ObjectMemberMapping
	{
		// Token: 0x060042F4 RID: 17140 RVA: 0x000E5495 File Offset: 0x000E3695
		internal ObjectPropertyMapping(global::System.Data.Entity.Core.Metadata.Edm.EdmProperty edmProperty, global::System.Data.Entity.Core.Metadata.Edm.EdmProperty clrProperty) : base(edmProperty, clrProperty)
		{
		}

		// Token: 0x17000D48 RID: 3400
		// (get) Token: 0x060042F5 RID: 17141 RVA: 0x000E549F File Offset: 0x000E369F
		internal global::System.Data.Entity.Core.Metadata.Edm.EdmProperty ClrProperty
		{
			get
			{
				return (global::System.Data.Entity.Core.Metadata.Edm.EdmProperty)base.ClrMember;
			}
		}

		// Token: 0x17000D49 RID: 3401
		// (get) Token: 0x060042F6 RID: 17142 RVA: 0x000E54AC File Offset: 0x000E36AC
		internal override global::System.Data.Entity.Core.Mapping.MemberMappingKind MemberMappingKind
		{
			get
			{
				return global::System.Data.Entity.Core.Mapping.MemberMappingKind.ScalarPropertyMapping;
			}
		}
	}
}
