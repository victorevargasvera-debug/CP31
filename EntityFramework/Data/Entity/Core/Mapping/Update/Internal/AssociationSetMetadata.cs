using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Common.Utils;
using System.Data.Entity.Core.Metadata.Edm;
using System.Linq;

namespace System.Data.Entity.Core.Mapping.Update.Internal
{
	// Token: 0x020005C1 RID: 1473
	internal sealed class AssociationSetMetadata
	{
		// Token: 0x17000E1B RID: 3611
		// (get) Token: 0x0600476D RID: 18285 RVA: 0x000FB654 File Offset: 0x000F9854
		internal bool HasEnds
		{
			get
			{
				return 0 < this.RequiredEnds.Count || 0 < this.OptionalEnds.Count || 0 < this.IncludedValueEnds.Count;
			}
		}

		// Token: 0x0600476E RID: 18286 RVA: 0x000FB684 File Offset: 0x000F9884
		internal AssociationSetMetadata(global::System.Data.Entity.Core.Common.Utils.Set<global::System.Data.Entity.Core.Metadata.Edm.EntitySet> affectedTables, global::System.Data.Entity.Core.Metadata.Edm.AssociationSet associationSet, global::System.Data.Entity.Core.Metadata.Edm.MetadataWorkspace workspace)
		{
			bool flag = 1 < affectedTables.Count;
			global::System.Data.Entity.Core.Metadata.Edm.ReadOnlyMetadataCollection<global::System.Data.Entity.Core.Metadata.Edm.AssociationSetEnd> associationSetEnds = associationSet.AssociationSetEnds;
			foreach (global::System.Data.Entity.Core.Metadata.Edm.EntitySet table in affectedTables)
			{
				foreach (global::System.Data.Entity.Core.Metadata.Edm.EntitySet item in global::System.Data.Entity.Core.Common.Utils.MetadataHelper.GetInfluencingEntitySetsForTable(table, workspace))
				{
					foreach (global::System.Data.Entity.Core.Metadata.Edm.AssociationSetEnd associationSetEnd in associationSetEnds)
					{
						if (associationSetEnd.EntitySet.EdmEquals(item))
						{
							if (flag)
							{
								global::System.Data.Entity.Core.Mapping.Update.Internal.AssociationSetMetadata.AddEnd(ref this.RequiredEnds, associationSetEnd.CorrespondingAssociationEndMember);
							}
							else if (this.RequiredEnds == null || !this.RequiredEnds.Contains(associationSetEnd.CorrespondingAssociationEndMember))
							{
								global::System.Data.Entity.Core.Mapping.Update.Internal.AssociationSetMetadata.AddEnd(ref this.OptionalEnds, associationSetEnd.CorrespondingAssociationEndMember);
							}
						}
					}
				}
			}
			global::System.Data.Entity.Core.Mapping.Update.Internal.AssociationSetMetadata.FixSet(ref this.RequiredEnds);
			global::System.Data.Entity.Core.Mapping.Update.Internal.AssociationSetMetadata.FixSet(ref this.OptionalEnds);
			foreach (global::System.Data.Entity.Core.Metadata.Edm.ReferentialConstraint referentialConstraint in associationSet.ElementType.ReferentialConstraints)
			{
				global::System.Data.Entity.Core.Metadata.Edm.AssociationEndMember element = (global::System.Data.Entity.Core.Metadata.Edm.AssociationEndMember)referentialConstraint.FromRole;
				if (!this.RequiredEnds.Contains(element) && !this.OptionalEnds.Contains(element))
				{
					global::System.Data.Entity.Core.Mapping.Update.Internal.AssociationSetMetadata.AddEnd(ref this.IncludedValueEnds, element);
				}
			}
			global::System.Data.Entity.Core.Mapping.Update.Internal.AssociationSetMetadata.FixSet(ref this.IncludedValueEnds);
		}

		// Token: 0x0600476F RID: 18287 RVA: 0x000FB848 File Offset: 0x000F9A48
		internal AssociationSetMetadata(global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Metadata.Edm.AssociationEndMember> requiredEnds)
		{
			if (requiredEnds.Any<global::System.Data.Entity.Core.Metadata.Edm.AssociationEndMember>())
			{
				this.RequiredEnds = new global::System.Data.Entity.Core.Common.Utils.Set<global::System.Data.Entity.Core.Metadata.Edm.AssociationEndMember>(requiredEnds);
			}
			global::System.Data.Entity.Core.Mapping.Update.Internal.AssociationSetMetadata.FixSet(ref this.RequiredEnds);
			global::System.Data.Entity.Core.Mapping.Update.Internal.AssociationSetMetadata.FixSet(ref this.OptionalEnds);
			global::System.Data.Entity.Core.Mapping.Update.Internal.AssociationSetMetadata.FixSet(ref this.IncludedValueEnds);
		}

		// Token: 0x06004770 RID: 18288 RVA: 0x000FB885 File Offset: 0x000F9A85
		private static void AddEnd(ref global::System.Data.Entity.Core.Common.Utils.Set<global::System.Data.Entity.Core.Metadata.Edm.AssociationEndMember> set, global::System.Data.Entity.Core.Metadata.Edm.AssociationEndMember element)
		{
			if (set == null)
			{
				set = new global::System.Data.Entity.Core.Common.Utils.Set<global::System.Data.Entity.Core.Metadata.Edm.AssociationEndMember>();
			}
			set.Add(element);
		}

		// Token: 0x06004771 RID: 18289 RVA: 0x000FB89A File Offset: 0x000F9A9A
		private static void FixSet(ref global::System.Data.Entity.Core.Common.Utils.Set<global::System.Data.Entity.Core.Metadata.Edm.AssociationEndMember> set)
		{
			if (set == null)
			{
				set = global::System.Data.Entity.Core.Common.Utils.Set<global::System.Data.Entity.Core.Metadata.Edm.AssociationEndMember>.Empty;
				return;
			}
			set.MakeReadOnly();
		}

		// Token: 0x04001956 RID: 6486
		internal readonly global::System.Data.Entity.Core.Common.Utils.Set<global::System.Data.Entity.Core.Metadata.Edm.AssociationEndMember> RequiredEnds;

		// Token: 0x04001957 RID: 6487
		internal readonly global::System.Data.Entity.Core.Common.Utils.Set<global::System.Data.Entity.Core.Metadata.Edm.AssociationEndMember> OptionalEnds;

		// Token: 0x04001958 RID: 6488
		internal readonly global::System.Data.Entity.Core.Common.Utils.Set<global::System.Data.Entity.Core.Metadata.Edm.AssociationEndMember> IncludedValueEnds;
	}
}
