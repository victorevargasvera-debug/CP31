using System;
using System.Data.Entity.Core.Metadata.Edm;

namespace System.Data.Entity.ModelConfiguration.Edm
{
	// Token: 0x02000170 RID: 368
	internal static class RelationshipMultiplicityExtensions
	{
		// Token: 0x060016A4 RID: 5796 RVA: 0x0003AC06 File Offset: 0x00038E06
		public static bool IsMany(this global::System.Data.Entity.Core.Metadata.Edm.RelationshipMultiplicity associationEndKind)
		{
			return associationEndKind == global::System.Data.Entity.Core.Metadata.Edm.RelationshipMultiplicity.Many;
		}

		// Token: 0x060016A5 RID: 5797 RVA: 0x0003AC0C File Offset: 0x00038E0C
		public static bool IsOptional(this global::System.Data.Entity.Core.Metadata.Edm.RelationshipMultiplicity associationEndKind)
		{
			return associationEndKind == global::System.Data.Entity.Core.Metadata.Edm.RelationshipMultiplicity.ZeroOrOne;
		}

		// Token: 0x060016A6 RID: 5798 RVA: 0x0003AC12 File Offset: 0x00038E12
		public static bool IsRequired(this global::System.Data.Entity.Core.Metadata.Edm.RelationshipMultiplicity associationEndKind)
		{
			return associationEndKind == global::System.Data.Entity.Core.Metadata.Edm.RelationshipMultiplicity.One;
		}
	}
}
