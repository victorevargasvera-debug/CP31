using System;
using System.Data.Entity.Core.Common.CommandTrees;
using System.Data.Entity.Core.Mapping.ViewGeneration.CqlGeneration;
using System.Text;

namespace System.Data.Entity.Core.Mapping.ViewGeneration.Structures
{
	// Token: 0x020005AF RID: 1455
	internal sealed class QualifiedCellIdBoolean : global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellIdBoolean
	{
		// Token: 0x060046ED RID: 18157 RVA: 0x000F9A45 File Offset: 0x000F7C45
		internal QualifiedCellIdBoolean(global::System.Data.Entity.Core.Mapping.ViewGeneration.CqlGeneration.CqlBlock block, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CqlIdentifiers identifiers, int originalCellNum) : base(identifiers, originalCellNum)
		{
			this.m_block = block;
		}

		// Token: 0x060046EE RID: 18158 RVA: 0x000F9A56 File Offset: 0x000F7C56
		internal override global::System.Text.StringBuilder AsEsql(global::System.Text.StringBuilder builder, string blockAlias, bool skipIsNotNull)
		{
			return base.AsEsql(builder, this.m_block.CqlAlias, skipIsNotNull);
		}

		// Token: 0x060046EF RID: 18159 RVA: 0x000F9A6B File Offset: 0x000F7C6B
		internal override global::System.Data.Entity.Core.Common.CommandTrees.DbExpression AsCqt(global::System.Data.Entity.Core.Common.CommandTrees.DbExpression row, bool skipIsNotNull)
		{
			return base.AsCqt(this.m_block.GetInput(row), skipIsNotNull);
		}

		// Token: 0x04001932 RID: 6450
		private readonly global::System.Data.Entity.Core.Mapping.ViewGeneration.CqlGeneration.CqlBlock m_block;
	}
}
