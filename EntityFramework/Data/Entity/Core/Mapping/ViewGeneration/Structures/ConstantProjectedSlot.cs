using System;
using System.Data.Entity.Core.Common.CommandTrees;
using System.Data.Entity.Core.Mapping.ViewGeneration.CqlGeneration;
using System.Text;

namespace System.Data.Entity.Core.Mapping.ViewGeneration.Structures
{
	// Token: 0x020005A1 RID: 1441
	internal sealed class ConstantProjectedSlot : global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.ProjectedSlot
	{
		// Token: 0x060045ED RID: 17901 RVA: 0x000F5989 File Offset: 0x000F3B89
		internal ConstantProjectedSlot(global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant value)
		{
			this.m_constant = value;
		}

		// Token: 0x17000DD2 RID: 3538
		// (get) Token: 0x060045EE RID: 17902 RVA: 0x000F5998 File Offset: 0x000F3B98
		internal global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant CellConstant
		{
			get
			{
				return this.m_constant;
			}
		}

		// Token: 0x060045EF RID: 17903 RVA: 0x000F59A0 File Offset: 0x000F3BA0
		internal override global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.ProjectedSlot DeepQualify(global::System.Data.Entity.Core.Mapping.ViewGeneration.CqlGeneration.CqlBlock block)
		{
			return this;
		}

		// Token: 0x060045F0 RID: 17904 RVA: 0x000F59A3 File Offset: 0x000F3BA3
		internal override global::System.Text.StringBuilder AsEsql(global::System.Text.StringBuilder builder, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath outputMember, string blockAlias, int indentLevel)
		{
			return this.m_constant.AsEsql(builder, outputMember, blockAlias);
		}

		// Token: 0x060045F1 RID: 17905 RVA: 0x000F59B3 File Offset: 0x000F3BB3
		internal override global::System.Data.Entity.Core.Common.CommandTrees.DbExpression AsCqt(global::System.Data.Entity.Core.Common.CommandTrees.DbExpression row, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath outputMember)
		{
			return this.m_constant.AsCqt(row, outputMember);
		}

		// Token: 0x060045F2 RID: 17906 RVA: 0x000F59C4 File Offset: 0x000F3BC4
		protected override bool IsEqualTo(global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.ProjectedSlot right)
		{
			global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.ConstantProjectedSlot constantProjectedSlot = right as global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.ConstantProjectedSlot;
			return constantProjectedSlot != null && global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant.EqualityComparer.Equals(this.m_constant, constantProjectedSlot.m_constant);
		}

		// Token: 0x060045F3 RID: 17907 RVA: 0x000F59F3 File Offset: 0x000F3BF3
		protected override int GetHash()
		{
			return global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant.EqualityComparer.GetHashCode(this.m_constant);
		}

		// Token: 0x060045F4 RID: 17908 RVA: 0x000F5A05 File Offset: 0x000F3C05
		internal override void ToCompactString(global::System.Text.StringBuilder builder)
		{
			this.m_constant.ToCompactString(builder);
		}

		// Token: 0x04001909 RID: 6409
		private readonly global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant m_constant;
	}
}
