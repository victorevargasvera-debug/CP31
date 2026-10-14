using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Common.Utils;
using System.Data.Entity.Core.Mapping.ViewGeneration.Structures;
using System.Data.Entity.Core.Metadata.Edm;
using System.Text;

namespace System.Data.Entity.Core.Mapping.ViewGeneration.Validation
{
	// Token: 0x02000577 RID: 1399
	internal class BasicCellRelation : global::System.Data.Entity.Core.Mapping.ViewGeneration.Validation.CellRelation
	{
		// Token: 0x060043FA RID: 17402 RVA: 0x000EC7F2 File Offset: 0x000EA9F2
		internal BasicCellRelation(global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellQuery cellQuery, global::System.Data.Entity.Core.Mapping.ViewGeneration.Validation.ViewCellRelation viewCellRelation, global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberProjectedSlot> slots) : base(viewCellRelation.CellNumber)
		{
			this.m_cellQuery = cellQuery;
			this.m_slots = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberProjectedSlot>(slots);
			this.m_viewCellRelation = viewCellRelation;
		}

		// Token: 0x17000D79 RID: 3449
		// (get) Token: 0x060043FB RID: 17403 RVA: 0x000EC81A File Offset: 0x000EAA1A
		internal global::System.Data.Entity.Core.Mapping.ViewGeneration.Validation.ViewCellRelation ViewCellRelation
		{
			get
			{
				return this.m_viewCellRelation;
			}
		}

		// Token: 0x060043FC RID: 17404 RVA: 0x000EC822 File Offset: 0x000EAA22
		internal void PopulateKeyConstraints(global::System.Data.Entity.Core.Mapping.ViewGeneration.Validation.SchemaConstraints<global::System.Data.Entity.Core.Mapping.ViewGeneration.Validation.BasicKeyConstraint> constraints)
		{
			if (this.m_cellQuery.Extent is global::System.Data.Entity.Core.Metadata.Edm.EntitySet)
			{
				this.PopulateKeyConstraintsForEntitySet(constraints);
				return;
			}
			this.PopulateKeyConstraintsForRelationshipSet(constraints);
		}

		// Token: 0x060043FD RID: 17405 RVA: 0x000EC848 File Offset: 0x000EAA48
		private void PopulateKeyConstraintsForEntitySet(global::System.Data.Entity.Core.Mapping.ViewGeneration.Validation.SchemaConstraints<global::System.Data.Entity.Core.Mapping.ViewGeneration.Validation.BasicKeyConstraint> constraints)
		{
			global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath prefix = new global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath(this.m_cellQuery.Extent);
			global::System.Data.Entity.Core.Metadata.Edm.EntityType entityType = (global::System.Data.Entity.Core.Metadata.Edm.EntityType)this.m_cellQuery.Extent.ElementType;
			global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.ExtentKey> keysForEntityType = global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.ExtentKey.GetKeysForEntityType(prefix, entityType);
			this.AddKeyConstraints(keysForEntityType, constraints);
		}

		// Token: 0x060043FE RID: 17406 RVA: 0x000EC88C File Offset: 0x000EAA8C
		private void PopulateKeyConstraintsForRelationshipSet(global::System.Data.Entity.Core.Mapping.ViewGeneration.Validation.SchemaConstraints<global::System.Data.Entity.Core.Mapping.ViewGeneration.Validation.BasicKeyConstraint> constraints)
		{
			global::System.Data.Entity.Core.Metadata.Edm.AssociationSet associationSet = this.m_cellQuery.Extent as global::System.Data.Entity.Core.Metadata.Edm.AssociationSet;
			global::System.Data.Entity.Core.Common.Utils.Set<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath> set = new global::System.Data.Entity.Core.Common.Utils.Set<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath>(global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath.EqualityComparer);
			bool flag = false;
			foreach (global::System.Data.Entity.Core.Metadata.Edm.AssociationSetEnd associationSetEnd in associationSet.AssociationSetEnds)
			{
				global::System.Data.Entity.Core.Metadata.Edm.AssociationEndMember correspondingAssociationEndMember = associationSetEnd.CorrespondingAssociationEndMember;
				global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.ExtentKey> keysForEntityType = global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.ExtentKey.GetKeysForEntityType(new global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath(associationSet, correspondingAssociationEndMember), associationSetEnd.EntitySet.ElementType);
				if (global::System.Data.Entity.Core.Common.Utils.MetadataHelper.DoesEndFormKey(associationSet, correspondingAssociationEndMember))
				{
					this.AddKeyConstraints(keysForEntityType, constraints);
					flag = true;
				}
				set.AddRange(keysForEntityType[0].KeyFields);
			}
			if (!flag)
			{
				global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.ExtentKey extentKey = new global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.ExtentKey(set);
				global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.ExtentKey[] keys = new global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.ExtentKey[]
				{
					extentKey
				};
				this.AddKeyConstraints(keys, constraints);
			}
		}

		// Token: 0x060043FF RID: 17407 RVA: 0x000EC964 File Offset: 0x000EAB64
		private void AddKeyConstraints(global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.ExtentKey> keys, global::System.Data.Entity.Core.Mapping.ViewGeneration.Validation.SchemaConstraints<global::System.Data.Entity.Core.Mapping.ViewGeneration.Validation.BasicKeyConstraint> constraints)
		{
			foreach (global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.ExtentKey extentKey in keys)
			{
				global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberProjectedSlot> slots = global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberProjectedSlot.GetSlots(this.m_slots, extentKey.KeyFields);
				if (slots != null)
				{
					global::System.Data.Entity.Core.Mapping.ViewGeneration.Validation.BasicKeyConstraint constraint = new global::System.Data.Entity.Core.Mapping.ViewGeneration.Validation.BasicKeyConstraint(this, slots);
					constraints.Add(constraint);
				}
			}
		}

		// Token: 0x06004400 RID: 17408 RVA: 0x000EC9CC File Offset: 0x000EABCC
		protected override int GetHash()
		{
			return this.m_cellQuery.GetHashCode();
		}

		// Token: 0x06004401 RID: 17409 RVA: 0x000EC9D9 File Offset: 0x000EABD9
		internal override void ToCompactString(global::System.Text.StringBuilder builder)
		{
			builder.Append("BasicRel: ");
			global::System.Data.Entity.Core.Common.Utils.StringUtil.FormatStringBuilder(builder, "{0}", new object[]
			{
				this.m_slots[0]
			});
		}

		// Token: 0x04001889 RID: 6281
		private readonly global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellQuery m_cellQuery;

		// Token: 0x0400188A RID: 6282
		private readonly global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberProjectedSlot> m_slots;

		// Token: 0x0400188B RID: 6283
		private readonly global::System.Data.Entity.Core.Mapping.ViewGeneration.Validation.ViewCellRelation m_viewCellRelation;
	}
}
