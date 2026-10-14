using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Metadata.Edm;

namespace System.Data.Entity.Core.Query.PlanCompiler
{
	// Token: 0x0200033A RID: 826
	internal class ConstraintManager
	{
		// Token: 0x06002742 RID: 10050 RVA: 0x0007141C File Offset: 0x0006F61C
		internal bool IsParentChildRelationship(global::System.Data.Entity.Core.Metadata.Edm.EntitySetBase table1, global::System.Data.Entity.Core.Metadata.Edm.EntitySetBase table2, out global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.PlanCompiler.ForeignKeyConstraint> constraints)
		{
			this.LoadRelationships(table1.EntityContainer);
			this.LoadRelationships(table2.EntityContainer);
			global::System.Data.Entity.Core.Query.PlanCompiler.ExtentPair key = new global::System.Data.Entity.Core.Query.PlanCompiler.ExtentPair(table1, table2);
			return this.m_parentChildRelationships.TryGetValue(key, out constraints);
		}

		// Token: 0x06002743 RID: 10051 RVA: 0x00071458 File Offset: 0x0006F658
		internal void LoadRelationships(global::System.Data.Entity.Core.Metadata.Edm.EntityContainer entityContainer)
		{
			if (this.m_entityContainerMap.ContainsKey(entityContainer))
			{
				return;
			}
			foreach (global::System.Data.Entity.Core.Metadata.Edm.EntitySetBase entitySetBase in entityContainer.BaseEntitySets)
			{
				global::System.Data.Entity.Core.Metadata.Edm.RelationshipSet relationshipSet = entitySetBase as global::System.Data.Entity.Core.Metadata.Edm.RelationshipSet;
				if (relationshipSet != null)
				{
					global::System.Data.Entity.Core.Metadata.Edm.RelationshipType elementType = relationshipSet.ElementType;
					global::System.Data.Entity.Core.Metadata.Edm.AssociationType associationType = elementType as global::System.Data.Entity.Core.Metadata.Edm.AssociationType;
					if (associationType != null && global::System.Data.Entity.Core.Query.PlanCompiler.ConstraintManager.IsBinary(elementType))
					{
						foreach (global::System.Data.Entity.Core.Metadata.Edm.ReferentialConstraint constraint in associationType.ReferentialConstraints)
						{
							global::System.Data.Entity.Core.Query.PlanCompiler.ForeignKeyConstraint foreignKeyConstraint = new global::System.Data.Entity.Core.Query.PlanCompiler.ForeignKeyConstraint(relationshipSet, constraint);
							global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.PlanCompiler.ForeignKeyConstraint> list;
							if (!this.m_parentChildRelationships.TryGetValue(foreignKeyConstraint.Pair, out list))
							{
								list = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.PlanCompiler.ForeignKeyConstraint>();
								this.m_parentChildRelationships[foreignKeyConstraint.Pair] = list;
							}
							list.Add(foreignKeyConstraint);
						}
					}
				}
			}
			this.m_entityContainerMap[entityContainer] = entityContainer;
		}

		// Token: 0x06002744 RID: 10052 RVA: 0x0007156C File Offset: 0x0006F76C
		internal ConstraintManager()
		{
			this.m_entityContainerMap = new global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Metadata.Edm.EntityContainer, global::System.Data.Entity.Core.Metadata.Edm.EntityContainer>();
			this.m_parentChildRelationships = new global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Query.PlanCompiler.ExtentPair, global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.PlanCompiler.ForeignKeyConstraint>>();
		}

		// Token: 0x06002745 RID: 10053 RVA: 0x0007158C File Offset: 0x0006F78C
		private static bool IsBinary(global::System.Data.Entity.Core.Metadata.Edm.RelationshipType relationshipType)
		{
			int num = 0;
			using (global::System.Data.Entity.Core.Metadata.Edm.ReadOnlyMetadataCollection<global::System.Data.Entity.Core.Metadata.Edm.EdmMember>.Enumerator enumerator = relationshipType.Members.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (enumerator.Current is global::System.Data.Entity.Core.Metadata.Edm.RelationshipEndMember)
					{
						num++;
						if (num > 2)
						{
							return false;
						}
					}
				}
			}
			return num == 2;
		}

		// Token: 0x04000DAF RID: 3503
		private readonly global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Metadata.Edm.EntityContainer, global::System.Data.Entity.Core.Metadata.Edm.EntityContainer> m_entityContainerMap;

		// Token: 0x04000DB0 RID: 3504
		private readonly global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Query.PlanCompiler.ExtentPair, global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.PlanCompiler.ForeignKeyConstraint>> m_parentChildRelationships;
	}
}
