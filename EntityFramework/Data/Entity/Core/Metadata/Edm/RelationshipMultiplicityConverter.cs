using System;

namespace System.Data.Entity.Core.Metadata.Edm
{
	// Token: 0x020004F4 RID: 1268
	internal static class RelationshipMultiplicityConverter
	{
		// Token: 0x06003F03 RID: 16131 RVA: 0x000D0A16 File Offset: 0x000CEC16
		internal static string MultiplicityToString(global::System.Data.Entity.Core.Metadata.Edm.RelationshipMultiplicity multiplicity)
		{
			switch (multiplicity)
			{
			case global::System.Data.Entity.Core.Metadata.Edm.RelationshipMultiplicity.ZeroOrOne:
				return "0..1";
			case global::System.Data.Entity.Core.Metadata.Edm.RelationshipMultiplicity.One:
				return "1";
			case global::System.Data.Entity.Core.Metadata.Edm.RelationshipMultiplicity.Many:
				return "*";
			default:
				return string.Empty;
			}
		}

		// Token: 0x06003F04 RID: 16132 RVA: 0x000D0A44 File Offset: 0x000CEC44
		internal static bool TryParseMultiplicity(string value, out global::System.Data.Entity.Core.Metadata.Edm.RelationshipMultiplicity multiplicity)
		{
			if (value != null)
			{
				if (value == "*")
				{
					multiplicity = global::System.Data.Entity.Core.Metadata.Edm.RelationshipMultiplicity.Many;
					return true;
				}
				if (value == "1")
				{
					multiplicity = global::System.Data.Entity.Core.Metadata.Edm.RelationshipMultiplicity.One;
					return true;
				}
				if (value == "0..1")
				{
					multiplicity = global::System.Data.Entity.Core.Metadata.Edm.RelationshipMultiplicity.ZeroOrOne;
					return true;
				}
			}
			multiplicity = (global::System.Data.Entity.Core.Metadata.Edm.RelationshipMultiplicity)(-1);
			return false;
		}
	}
}
