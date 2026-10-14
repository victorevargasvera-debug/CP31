using System;
using System.Data.Entity.Core.Metadata.Edm;

namespace System.Data.Entity.ModelConfiguration.Edm
{
	// Token: 0x0200016F RID: 367
	internal static class RelationshipEndMemberExtensions
	{
		// Token: 0x060016A1 RID: 5793 RVA: 0x0003ABDF File Offset: 0x00038DDF
		public static bool IsMany(this global::System.Data.Entity.Core.Metadata.Edm.RelationshipEndMember associationEnd)
		{
			return associationEnd.RelationshipMultiplicity.IsMany();
		}

		// Token: 0x060016A2 RID: 5794 RVA: 0x0003ABEC File Offset: 0x00038DEC
		public static bool IsOptional(this global::System.Data.Entity.Core.Metadata.Edm.RelationshipEndMember associationEnd)
		{
			return associationEnd.RelationshipMultiplicity.IsOptional();
		}

		// Token: 0x060016A3 RID: 5795 RVA: 0x0003ABF9 File Offset: 0x00038DF9
		public static bool IsRequired(this global::System.Data.Entity.Core.Metadata.Edm.RelationshipEndMember associationEnd)
		{
			return associationEnd.RelationshipMultiplicity.IsRequired();
		}
	}
}
