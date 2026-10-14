using System;
using System.Data.Entity.Core.Common.CommandTrees;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Data.Entity.Core.Common.Utils;
using System.Data.Entity.Core.Mapping.ViewGeneration.Structures;
using System.Text;

namespace System.Data.Entity.Core.Mapping.ViewGeneration.CqlGeneration
{
	// Token: 0x020005B8 RID: 1464
	internal sealed class QualifiedSlot : global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.ProjectedSlot
	{
		// Token: 0x06004730 RID: 18224 RVA: 0x000FA993 File Offset: 0x000F8B93
		internal QualifiedSlot(global::System.Data.Entity.Core.Mapping.ViewGeneration.CqlGeneration.CqlBlock block, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.ProjectedSlot slot)
		{
			this.m_block = block;
			this.m_slot = slot;
		}

		// Token: 0x06004731 RID: 18225 RVA: 0x000FA9A9 File Offset: 0x000F8BA9
		internal override global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.ProjectedSlot DeepQualify(global::System.Data.Entity.Core.Mapping.ViewGeneration.CqlGeneration.CqlBlock block)
		{
			return new global::System.Data.Entity.Core.Mapping.ViewGeneration.CqlGeneration.QualifiedSlot(block, this.m_slot);
		}

		// Token: 0x06004732 RID: 18226 RVA: 0x000FA9B7 File Offset: 0x000F8BB7
		internal override string GetCqlFieldAlias(global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath outputMember)
		{
			return this.GetOriginalSlot().GetCqlFieldAlias(outputMember);
		}

		// Token: 0x06004733 RID: 18227 RVA: 0x000FA9C8 File Offset: 0x000F8BC8
		internal global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.ProjectedSlot GetOriginalSlot()
		{
			global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.ProjectedSlot slot = this.m_slot;
			for (;;)
			{
				global::System.Data.Entity.Core.Mapping.ViewGeneration.CqlGeneration.QualifiedSlot qualifiedSlot = slot as global::System.Data.Entity.Core.Mapping.ViewGeneration.CqlGeneration.QualifiedSlot;
				if (qualifiedSlot == null)
				{
					break;
				}
				slot = qualifiedSlot.m_slot;
			}
			return slot;
		}

		// Token: 0x06004734 RID: 18228 RVA: 0x000FA9F0 File Offset: 0x000F8BF0
		internal string GetQualifiedCqlName(global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath outputMember)
		{
			return global::System.Data.Entity.Core.Mapping.ViewGeneration.CqlGeneration.CqlWriter.GetQualifiedName(this.m_block.CqlAlias, this.GetCqlFieldAlias(outputMember));
		}

		// Token: 0x06004735 RID: 18229 RVA: 0x000FAA09 File Offset: 0x000F8C09
		internal override global::System.Text.StringBuilder AsEsql(global::System.Text.StringBuilder builder, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath outputMember, string blockAlias, int indentLevel)
		{
			builder.Append(this.GetQualifiedCqlName(outputMember));
			return builder;
		}

		// Token: 0x06004736 RID: 18230 RVA: 0x000FAA1A File Offset: 0x000F8C1A
		internal override global::System.Data.Entity.Core.Common.CommandTrees.DbExpression AsCqt(global::System.Data.Entity.Core.Common.CommandTrees.DbExpression row, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath outputMember)
		{
			return this.m_block.GetInput(row).Property(this.GetCqlFieldAlias(outputMember));
		}

		// Token: 0x06004737 RID: 18231 RVA: 0x000FAA34 File Offset: 0x000F8C34
		internal override void ToCompactString(global::System.Text.StringBuilder builder)
		{
			global::System.Data.Entity.Core.Common.Utils.StringUtil.FormatStringBuilder(builder, "{0} ", new object[]
			{
				this.m_block.CqlAlias
			});
			this.m_slot.ToCompactString(builder);
		}

		// Token: 0x04001940 RID: 6464
		private readonly global::System.Data.Entity.Core.Mapping.ViewGeneration.CqlGeneration.CqlBlock m_block;

		// Token: 0x04001941 RID: 6465
		private readonly global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.ProjectedSlot m_slot;
	}
}
