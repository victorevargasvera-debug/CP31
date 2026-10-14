using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Common.CommandTrees;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Data.Entity.Core.Mapping.ViewGeneration.CqlGeneration;
using System.Text;

namespace System.Data.Entity.Core.Mapping.ViewGeneration.Structures
{
	// Token: 0x0200059B RID: 1435
	internal class CellIdBoolean : global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.TrueFalseLiteral
	{
		// Token: 0x06004588 RID: 17800 RVA: 0x000F4797 File Offset: 0x000F2997
		internal CellIdBoolean(global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CqlIdentifiers identifiers, int index)
		{
			this.m_index = index;
			this.m_slotName = identifiers.GetFromVariable(index);
		}

		// Token: 0x17000DB8 RID: 3512
		// (get) Token: 0x06004589 RID: 17801 RVA: 0x000F47B3 File Offset: 0x000F29B3
		internal string SlotName
		{
			get
			{
				return this.m_slotName;
			}
		}

		// Token: 0x0600458A RID: 17802 RVA: 0x000F47BC File Offset: 0x000F29BC
		internal override global::System.Text.StringBuilder AsEsql(global::System.Text.StringBuilder builder, string blockAlias, bool skipIsNotNull)
		{
			string qualifiedName = global::System.Data.Entity.Core.Mapping.ViewGeneration.CqlGeneration.CqlWriter.GetQualifiedName(blockAlias, this.SlotName);
			builder.Append(qualifiedName);
			return builder;
		}

		// Token: 0x0600458B RID: 17803 RVA: 0x000F47DF File Offset: 0x000F29DF
		internal override global::System.Data.Entity.Core.Common.CommandTrees.DbExpression AsCqt(global::System.Data.Entity.Core.Common.CommandTrees.DbExpression row, bool skipIsNotNull)
		{
			return row.Property(this.SlotName);
		}

		// Token: 0x0600458C RID: 17804 RVA: 0x000F47ED File Offset: 0x000F29ED
		internal override global::System.Text.StringBuilder AsUserString(global::System.Text.StringBuilder builder, string blockAlias, bool skipIsNotNull)
		{
			return this.AsEsql(builder, blockAlias, skipIsNotNull);
		}

		// Token: 0x0600458D RID: 17805 RVA: 0x000F47F8 File Offset: 0x000F29F8
		internal override global::System.Text.StringBuilder AsNegatedUserString(global::System.Text.StringBuilder builder, string blockAlias, bool skipIsNotNull)
		{
			builder.Append("NOT(");
			builder = this.AsUserString(builder, blockAlias, skipIsNotNull);
			builder.Append(")");
			return builder;
		}

		// Token: 0x0600458E RID: 17806 RVA: 0x000F4820 File Offset: 0x000F2A20
		internal override void GetRequiredSlots(global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberProjectionIndex projectedSlotMap, bool[] requiredSlots)
		{
			int numBoolSlots = requiredSlots.Length - projectedSlotMap.Count;
			int num = projectedSlotMap.BoolIndexToSlot(this.m_index, numBoolSlots);
			requiredSlots[num] = true;
		}

		// Token: 0x0600458F RID: 17807 RVA: 0x000F484C File Offset: 0x000F2A4C
		protected override bool IsEqualTo(global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolLiteral right)
		{
			global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellIdBoolean cellIdBoolean = right as global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellIdBoolean;
			return cellIdBoolean != null && this.m_index == cellIdBoolean.m_index;
		}

		// Token: 0x06004590 RID: 17808 RVA: 0x000F4874 File Offset: 0x000F2A74
		public override int GetHashCode()
		{
			return this.m_index.GetHashCode();
		}

		// Token: 0x06004591 RID: 17809 RVA: 0x000F488F File Offset: 0x000F2A8F
		internal override global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolLiteral RemapBool(global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath> remap)
		{
			return this;
		}

		// Token: 0x06004592 RID: 17810 RVA: 0x000F4892 File Offset: 0x000F2A92
		internal override void ToCompactString(global::System.Text.StringBuilder builder)
		{
			builder.Append(this.SlotName);
		}

		// Token: 0x040018F0 RID: 6384
		private readonly int m_index;

		// Token: 0x040018F1 RID: 6385
		private readonly string m_slotName;
	}
}
