using System;
using System.Data.Entity.Core.Metadata.Edm;

namespace System.Data.Entity.ModelConfiguration.Edm
{
	// Token: 0x0200015E RID: 350
	internal static class AssociationTypeExtensions
	{
		// Token: 0x06001614 RID: 5652 RVA: 0x00038DF4 File Offset: 0x00036FF4
		public static void MarkIndependent(this global::System.Data.Entity.Core.Metadata.Edm.AssociationType associationType)
		{
			associationType.GetMetadataProperties().SetAnnotation("IsIndependent", true);
		}

		// Token: 0x06001615 RID: 5653 RVA: 0x00038E0C File Offset: 0x0003700C
		public static bool IsIndependent(this global::System.Data.Entity.Core.Metadata.Edm.AssociationType associationType)
		{
			object annotation = associationType.Annotations.GetAnnotation("IsIndependent");
			return annotation != null && (bool)annotation;
		}

		// Token: 0x06001616 RID: 5654 RVA: 0x00038E35 File Offset: 0x00037035
		public static void MarkPrincipalConfigured(this global::System.Data.Entity.Core.Metadata.Edm.AssociationType associationType)
		{
			associationType.GetMetadataProperties().SetAnnotation("IsPrincipalConfigured", true);
		}

		// Token: 0x06001617 RID: 5655 RVA: 0x00038E50 File Offset: 0x00037050
		public static bool IsPrincipalConfigured(this global::System.Data.Entity.Core.Metadata.Edm.AssociationType associationType)
		{
			object annotation = associationType.Annotations.GetAnnotation("IsPrincipalConfigured");
			return annotation != null && (bool)annotation;
		}

		// Token: 0x06001618 RID: 5656 RVA: 0x00038E79 File Offset: 0x00037079
		public static global::System.Data.Entity.Core.Metadata.Edm.AssociationEndMember GetOtherEnd(this global::System.Data.Entity.Core.Metadata.Edm.AssociationType associationType, global::System.Data.Entity.Core.Metadata.Edm.AssociationEndMember associationEnd)
		{
			if (associationEnd != associationType.SourceEnd)
			{
				return associationType.SourceEnd;
			}
			return associationType.TargetEnd;
		}

		// Token: 0x06001619 RID: 5657 RVA: 0x00038E91 File Offset: 0x00037091
		public static object GetConfiguration(this global::System.Data.Entity.Core.Metadata.Edm.AssociationType associationType)
		{
			return associationType.Annotations.GetConfiguration();
		}

		// Token: 0x0600161A RID: 5658 RVA: 0x00038E9E File Offset: 0x0003709E
		public static void SetConfiguration(this global::System.Data.Entity.Core.Metadata.Edm.AssociationType associationType, object configuration)
		{
			associationType.GetMetadataProperties().SetConfiguration(configuration);
		}

		// Token: 0x0600161B RID: 5659 RVA: 0x00038EAC File Offset: 0x000370AC
		public static bool IsRequiredToMany(this global::System.Data.Entity.Core.Metadata.Edm.AssociationType associationType)
		{
			return associationType.SourceEnd.IsRequired() && associationType.TargetEnd.IsMany();
		}

		// Token: 0x0600161C RID: 5660 RVA: 0x00038EC8 File Offset: 0x000370C8
		public static bool IsRequiredToRequired(this global::System.Data.Entity.Core.Metadata.Edm.AssociationType associationType)
		{
			return associationType.SourceEnd.IsRequired() && associationType.TargetEnd.IsRequired();
		}

		// Token: 0x0600161D RID: 5661 RVA: 0x00038EE4 File Offset: 0x000370E4
		public static bool IsManyToRequired(this global::System.Data.Entity.Core.Metadata.Edm.AssociationType associationType)
		{
			return associationType.SourceEnd.IsMany() && associationType.TargetEnd.IsRequired();
		}

		// Token: 0x0600161E RID: 5662 RVA: 0x00038F00 File Offset: 0x00037100
		public static bool IsManyToMany(this global::System.Data.Entity.Core.Metadata.Edm.AssociationType associationType)
		{
			return associationType.SourceEnd.IsMany() && associationType.TargetEnd.IsMany();
		}

		// Token: 0x0600161F RID: 5663 RVA: 0x00038F1C File Offset: 0x0003711C
		public static bool IsOneToOne(this global::System.Data.Entity.Core.Metadata.Edm.AssociationType associationType)
		{
			return !associationType.SourceEnd.IsMany() && !associationType.TargetEnd.IsMany();
		}

		// Token: 0x06001620 RID: 5664 RVA: 0x00038F3C File Offset: 0x0003713C
		public static bool IsSelfReferencing(this global::System.Data.Entity.Core.Metadata.Edm.AssociationType associationType)
		{
			global::System.Data.Entity.Core.Metadata.Edm.RelationshipEndMember sourceEnd = associationType.SourceEnd;
			global::System.Data.Entity.Core.Metadata.Edm.AssociationEndMember targetEnd = associationType.TargetEnd;
			return sourceEnd.GetEntityType().GetRootType() == targetEnd.GetEntityType().GetRootType();
		}

		// Token: 0x06001621 RID: 5665 RVA: 0x00038F6D File Offset: 0x0003716D
		public static bool IsRequiredToNonRequired(this global::System.Data.Entity.Core.Metadata.Edm.AssociationType associationType)
		{
			return (associationType.SourceEnd.IsRequired() && !associationType.TargetEnd.IsRequired()) || (associationType.TargetEnd.IsRequired() && !associationType.SourceEnd.IsRequired());
		}

		// Token: 0x06001622 RID: 5666 RVA: 0x00038FA8 File Offset: 0x000371A8
		public static bool TryGuessPrincipalAndDependentEnds(this global::System.Data.Entity.Core.Metadata.Edm.AssociationType associationType, out global::System.Data.Entity.Core.Metadata.Edm.AssociationEndMember principalEnd, out global::System.Data.Entity.Core.Metadata.Edm.AssociationEndMember dependentEnd)
		{
			global::System.Data.Entity.Core.Metadata.Edm.AssociationEndMember associationEndMember;
			dependentEnd = (associationEndMember = null);
			principalEnd = associationEndMember;
			global::System.Data.Entity.Core.Metadata.Edm.AssociationEndMember sourceEnd = associationType.SourceEnd;
			global::System.Data.Entity.Core.Metadata.Edm.AssociationEndMember targetEnd = associationType.TargetEnd;
			if (sourceEnd.RelationshipMultiplicity != targetEnd.RelationshipMultiplicity)
			{
				principalEnd = ((sourceEnd.IsRequired() || (sourceEnd.IsOptional() && targetEnd.IsMany())) ? sourceEnd : targetEnd);
				dependentEnd = ((principalEnd == sourceEnd) ? targetEnd : sourceEnd);
			}
			return principalEnd != null;
		}

		// Token: 0x04000A00 RID: 2560
		private const string IsIndependentAnnotation = "IsIndependent";

		// Token: 0x04000A01 RID: 2561
		private const string IsPrincipalConfiguredAnnotation = "IsPrincipalConfigured";
	}
}
