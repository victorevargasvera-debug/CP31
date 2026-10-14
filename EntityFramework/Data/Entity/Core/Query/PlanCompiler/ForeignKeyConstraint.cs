using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Common.Utils;
using System.Data.Entity.Core.Metadata.Edm;

namespace System.Data.Entity.Core.Query.PlanCompiler
{
	// Token: 0x02000341 RID: 833
	internal class ForeignKeyConstraint
	{
		// Token: 0x1700084B RID: 2123
		// (get) Token: 0x060027B9 RID: 10169 RVA: 0x00074404 File Offset: 0x00072604
		internal global::System.Collections.Generic.List<string> ParentKeys
		{
			get
			{
				return this.m_parentKeys;
			}
		}

		// Token: 0x1700084C RID: 2124
		// (get) Token: 0x060027BA RID: 10170 RVA: 0x0007440C File Offset: 0x0007260C
		internal global::System.Collections.Generic.List<string> ChildKeys
		{
			get
			{
				return this.m_childKeys;
			}
		}

		// Token: 0x1700084D RID: 2125
		// (get) Token: 0x060027BB RID: 10171 RVA: 0x00074414 File Offset: 0x00072614
		internal global::System.Data.Entity.Core.Query.PlanCompiler.ExtentPair Pair
		{
			get
			{
				return this.m_extentPair;
			}
		}

		// Token: 0x1700084E RID: 2126
		// (get) Token: 0x060027BC RID: 10172 RVA: 0x0007441C File Offset: 0x0007261C
		internal global::System.Data.Entity.Core.Metadata.Edm.RelationshipMultiplicity ChildMultiplicity
		{
			get
			{
				return this.m_constraint.ToRole.RelationshipMultiplicity;
			}
		}

		// Token: 0x060027BD RID: 10173 RVA: 0x0007442E File Offset: 0x0007262E
		internal bool GetParentProperty(string childPropertyName, out string parentPropertyName)
		{
			this.BuildKeyMap();
			return this.m_keyMap.TryGetValue(childPropertyName, out parentPropertyName);
		}

		// Token: 0x060027BE RID: 10174 RVA: 0x00074444 File Offset: 0x00072644
		internal ForeignKeyConstraint(global::System.Data.Entity.Core.Metadata.Edm.RelationshipSet relationshipSet, global::System.Data.Entity.Core.Metadata.Edm.ReferentialConstraint constraint)
		{
			global::System.Data.Entity.Core.Metadata.Edm.AssociationSet associationSet = relationshipSet as global::System.Data.Entity.Core.Metadata.Edm.AssociationSet;
			global::System.Data.Entity.Core.Metadata.Edm.AssociationEndMember associationEndMember = constraint.FromRole as global::System.Data.Entity.Core.Metadata.Edm.AssociationEndMember;
			global::System.Data.Entity.Core.Metadata.Edm.AssociationEndMember associationEndMember2 = constraint.ToRole as global::System.Data.Entity.Core.Metadata.Edm.AssociationEndMember;
			if (associationSet == null || associationEndMember == null || associationEndMember2 == null)
			{
				throw new global::System.NotSupportedException();
			}
			this.m_constraint = constraint;
			global::System.Data.Entity.Core.Metadata.Edm.EntitySet entitySetAtEnd = global::System.Data.Entity.Core.Common.Utils.MetadataHelper.GetEntitySetAtEnd(associationSet, associationEndMember);
			global::System.Data.Entity.Core.Metadata.Edm.EntitySet entitySetAtEnd2 = global::System.Data.Entity.Core.Common.Utils.MetadataHelper.GetEntitySetAtEnd(associationSet, associationEndMember2);
			this.m_extentPair = new global::System.Data.Entity.Core.Query.PlanCompiler.ExtentPair(entitySetAtEnd, entitySetAtEnd2);
			this.m_childKeys = new global::System.Collections.Generic.List<string>();
			foreach (global::System.Data.Entity.Core.Metadata.Edm.EdmProperty edmProperty in constraint.ToProperties)
			{
				this.m_childKeys.Add(edmProperty.Name);
			}
			this.m_parentKeys = new global::System.Collections.Generic.List<string>();
			foreach (global::System.Data.Entity.Core.Metadata.Edm.EdmProperty edmProperty2 in constraint.FromProperties)
			{
				this.m_parentKeys.Add(edmProperty2.Name);
			}
			global::System.Data.Entity.Core.Query.PlanCompiler.PlanCompiler.Assert(associationEndMember.RelationshipMultiplicity == global::System.Data.Entity.Core.Metadata.Edm.RelationshipMultiplicity.ZeroOrOne || global::System.Data.Entity.Core.Metadata.Edm.RelationshipMultiplicity.One == associationEndMember.RelationshipMultiplicity, "from-end of relationship constraint cannot have multiplicity greater than 1");
		}

		// Token: 0x060027BF RID: 10175 RVA: 0x00074584 File Offset: 0x00072784
		private void BuildKeyMap()
		{
			if (this.m_keyMap != null)
			{
				return;
			}
			this.m_keyMap = new global::System.Collections.Generic.Dictionary<string, string>();
			global::System.Collections.Generic.IEnumerator<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty> enumerator = this.m_constraint.FromProperties.GetEnumerator();
			global::System.Collections.Generic.IEnumerator<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty> enumerator2 = this.m_constraint.ToProperties.GetEnumerator();
			for (;;)
			{
				bool flag = !enumerator.MoveNext();
				bool flag2 = !enumerator2.MoveNext();
				global::System.Data.Entity.Core.Query.PlanCompiler.PlanCompiler.Assert(flag == flag2, "key count mismatch");
				if (flag)
				{
					break;
				}
				this.m_keyMap[enumerator2.Current.Name] = enumerator.Current.Name;
			}
		}

		// Token: 0x04000DDC RID: 3548
		private readonly global::System.Data.Entity.Core.Query.PlanCompiler.ExtentPair m_extentPair;

		// Token: 0x04000DDD RID: 3549
		private readonly global::System.Collections.Generic.List<string> m_parentKeys;

		// Token: 0x04000DDE RID: 3550
		private readonly global::System.Collections.Generic.List<string> m_childKeys;

		// Token: 0x04000DDF RID: 3551
		private readonly global::System.Data.Entity.Core.Metadata.Edm.ReferentialConstraint m_constraint;

		// Token: 0x04000DE0 RID: 3552
		private global::System.Collections.Generic.Dictionary<string, string> m_keyMap;
	}
}
