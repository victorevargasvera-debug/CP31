using System;
using System.Data.Entity.Core.Metadata.Edm;

namespace System.Data.Entity.Core.Mapping
{
	// Token: 0x02000554 RID: 1364
	internal class ObjectComplexPropertyMapping : global::System.Data.Entity.Core.Mapping.ObjectPropertyMapping
	{
		// Token: 0x060042EC RID: 17132 RVA: 0x000E5455 File Offset: 0x000E3655
		internal ObjectComplexPropertyMapping(global::System.Data.Entity.Core.Metadata.Edm.EdmProperty edmProperty, global::System.Data.Entity.Core.Metadata.Edm.EdmProperty clrProperty) : base(edmProperty, clrProperty)
		{
		}

		// Token: 0x17000D43 RID: 3395
		// (get) Token: 0x060042ED RID: 17133 RVA: 0x000E545F File Offset: 0x000E365F
		internal override global::System.Data.Entity.Core.Mapping.MemberMappingKind MemberMappingKind
		{
			get
			{
				return global::System.Data.Entity.Core.Mapping.MemberMappingKind.ComplexPropertyMapping;
			}
		}
	}
}
