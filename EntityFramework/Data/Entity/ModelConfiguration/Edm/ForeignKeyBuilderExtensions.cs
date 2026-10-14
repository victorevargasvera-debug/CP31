using System;
using System.Data.Entity.Core.Metadata.Edm;

namespace System.Data.Entity.ModelConfiguration.Edm
{
	// Token: 0x0200016A RID: 362
	internal static class ForeignKeyBuilderExtensions
	{
		// Token: 0x06001688 RID: 5768 RVA: 0x0003A8EF File Offset: 0x00038AEF
		public static string GetPreferredName(this global::System.Data.Entity.Core.Metadata.Edm.ForeignKeyBuilder fk)
		{
			return (string)fk.Annotations.GetAnnotation("PreferredName");
		}

		// Token: 0x06001689 RID: 5769 RVA: 0x0003A906 File Offset: 0x00038B06
		public static void SetPreferredName(this global::System.Data.Entity.Core.Metadata.Edm.ForeignKeyBuilder fk, string name)
		{
			fk.GetMetadataProperties().SetAnnotation("PreferredName", name);
		}

		// Token: 0x0600168A RID: 5770 RVA: 0x0003A91C File Offset: 0x00038B1C
		public static bool GetIsTypeConstraint(this global::System.Data.Entity.Core.Metadata.Edm.ForeignKeyBuilder fk)
		{
			object annotation = fk.Annotations.GetAnnotation("IsTypeConstraint");
			return annotation != null && (bool)annotation;
		}

		// Token: 0x0600168B RID: 5771 RVA: 0x0003A945 File Offset: 0x00038B45
		public static void SetIsTypeConstraint(this global::System.Data.Entity.Core.Metadata.Edm.ForeignKeyBuilder fk)
		{
			fk.GetMetadataProperties().SetAnnotation("IsTypeConstraint", true);
		}

		// Token: 0x0600168C RID: 5772 RVA: 0x0003A95D File Offset: 0x00038B5D
		public static void SetIsSplitConstraint(this global::System.Data.Entity.Core.Metadata.Edm.ForeignKeyBuilder fk)
		{
			fk.GetMetadataProperties().SetAnnotation("IsSplitConstraint", true);
		}

		// Token: 0x0600168D RID: 5773 RVA: 0x0003A975 File Offset: 0x00038B75
		public static global::System.Data.Entity.Core.Metadata.Edm.AssociationType GetAssociationType(this global::System.Data.Entity.Core.Metadata.Edm.ForeignKeyBuilder fk)
		{
			return fk.Annotations.GetAnnotation("AssociationType") as global::System.Data.Entity.Core.Metadata.Edm.AssociationType;
		}

		// Token: 0x0600168E RID: 5774 RVA: 0x0003A98C File Offset: 0x00038B8C
		public static void SetAssociationType(this global::System.Data.Entity.Core.Metadata.Edm.ForeignKeyBuilder fk, global::System.Data.Entity.Core.Metadata.Edm.AssociationType associationType)
		{
			fk.GetMetadataProperties().SetAnnotation("AssociationType", associationType);
		}

		// Token: 0x04000A09 RID: 2569
		private const string IsTypeConstraint = "IsTypeConstraint";

		// Token: 0x04000A0A RID: 2570
		private const string IsSplitConstraint = "IsSplitConstraint";

		// Token: 0x04000A0B RID: 2571
		private const string AssociationType = "AssociationType";

		// Token: 0x04000A0C RID: 2572
		private const string PreferredNameAnnotation = "PreferredName";
	}
}
