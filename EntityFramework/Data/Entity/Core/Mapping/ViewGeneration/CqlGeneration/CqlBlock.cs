using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Entity.Core.Common.CommandTrees;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Data.Entity.Core.Common.Utils;
using System.Data.Entity.Core.Mapping.ViewGeneration.Structures;
using System.Linq;
using System.Text;

namespace System.Data.Entity.Core.Mapping.ViewGeneration.CqlGeneration
{
	// Token: 0x020005BB RID: 1467
	internal abstract class CqlBlock : global::System.Data.Entity.Core.Common.Utils.InternalBase
	{
		// Token: 0x06004740 RID: 18240 RVA: 0x000FAD00 File Offset: 0x000F8F00
		protected CqlBlock(global::System.Data.Entity.Core.Mapping.ViewGeneration.CqlGeneration.SlotInfo[] slotInfos, global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.ViewGeneration.CqlGeneration.CqlBlock> children, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolExpression whereClause, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CqlIdentifiers identifiers, int blockAliasNum)
		{
			this.m_slots = new global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Data.Entity.Core.Mapping.ViewGeneration.CqlGeneration.SlotInfo>(slotInfos);
			this.m_children = new global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Data.Entity.Core.Mapping.ViewGeneration.CqlGeneration.CqlBlock>(children);
			this.m_whereClause = whereClause;
			this.m_blockAlias = identifiers.GetBlockAlias(blockAliasNum);
		}

		// Token: 0x17000E11 RID: 3601
		// (get) Token: 0x06004741 RID: 18241 RVA: 0x000FAD36 File Offset: 0x000F8F36
		// (set) Token: 0x06004742 RID: 18242 RVA: 0x000FAD3E File Offset: 0x000F8F3E
		internal global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Data.Entity.Core.Mapping.ViewGeneration.CqlGeneration.SlotInfo> Slots
		{
			get
			{
				return this.m_slots;
			}
			set
			{
				this.m_slots = value;
			}
		}

		// Token: 0x17000E12 RID: 3602
		// (get) Token: 0x06004743 RID: 18243 RVA: 0x000FAD47 File Offset: 0x000F8F47
		protected global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Data.Entity.Core.Mapping.ViewGeneration.CqlGeneration.CqlBlock> Children
		{
			get
			{
				return this.m_children;
			}
		}

		// Token: 0x17000E13 RID: 3603
		// (get) Token: 0x06004744 RID: 18244 RVA: 0x000FAD4F File Offset: 0x000F8F4F
		protected global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolExpression WhereClause
		{
			get
			{
				return this.m_whereClause;
			}
		}

		// Token: 0x17000E14 RID: 3604
		// (get) Token: 0x06004745 RID: 18245 RVA: 0x000FAD57 File Offset: 0x000F8F57
		internal string CqlAlias
		{
			get
			{
				return this.m_blockAlias;
			}
		}

		// Token: 0x06004746 RID: 18246
		internal abstract global::System.Text.StringBuilder AsEsql(global::System.Text.StringBuilder builder, bool isTopLevel, int indentLevel);

		// Token: 0x06004747 RID: 18247
		internal abstract global::System.Data.Entity.Core.Common.CommandTrees.DbExpression AsCqt(bool isTopLevel);

		// Token: 0x06004748 RID: 18248 RVA: 0x000FAD60 File Offset: 0x000F8F60
		internal global::System.Data.Entity.Core.Mapping.ViewGeneration.CqlGeneration.QualifiedSlot QualifySlotWithBlockAlias(int slotNum)
		{
			global::System.Data.Entity.Core.Mapping.ViewGeneration.CqlGeneration.SlotInfo slotInfo = this.m_slots[slotNum];
			return new global::System.Data.Entity.Core.Mapping.ViewGeneration.CqlGeneration.QualifiedSlot(this, slotInfo.SlotValue);
		}

		// Token: 0x06004749 RID: 18249 RVA: 0x000FAD86 File Offset: 0x000F8F86
		internal global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.ProjectedSlot SlotValue(int slotNum)
		{
			return this.m_slots[slotNum].SlotValue;
		}

		// Token: 0x0600474A RID: 18250 RVA: 0x000FAD99 File Offset: 0x000F8F99
		internal global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath MemberPath(int slotNum)
		{
			return this.m_slots[slotNum].OutputMember;
		}

		// Token: 0x0600474B RID: 18251 RVA: 0x000FADAC File Offset: 0x000F8FAC
		internal bool IsProjected(int slotNum)
		{
			return this.m_slots[slotNum].IsProjected;
		}

		// Token: 0x0600474C RID: 18252 RVA: 0x000FADC0 File Offset: 0x000F8FC0
		protected void GenerateProjectionEsql(global::System.Text.StringBuilder builder, string blockAlias, bool addNewLineAfterEachSlot, int indentLevel, bool isTopLevel)
		{
			bool flag = true;
			foreach (global::System.Data.Entity.Core.Mapping.ViewGeneration.CqlGeneration.SlotInfo slotInfo in this.Slots)
			{
				if (slotInfo.IsRequiredByParent)
				{
					if (!flag)
					{
						builder.Append(", ");
					}
					if (addNewLineAfterEachSlot)
					{
						global::System.Data.Entity.Core.Common.Utils.StringUtil.IndentNewLine(builder, indentLevel + 1);
					}
					slotInfo.AsEsql(builder, blockAlias, indentLevel);
					if (!isTopLevel && (!(slotInfo.SlotValue is global::System.Data.Entity.Core.Mapping.ViewGeneration.CqlGeneration.QualifiedSlot) || slotInfo.IsEnforcedNotNull))
					{
						builder.Append(" AS ").Append(slotInfo.CqlFieldAlias);
					}
					flag = false;
				}
			}
			if (addNewLineAfterEachSlot)
			{
				global::System.Data.Entity.Core.Common.Utils.StringUtil.IndentNewLine(builder, indentLevel);
			}
		}

		// Token: 0x0600474D RID: 18253 RVA: 0x000FAE78 File Offset: 0x000F9078
		protected global::System.Data.Entity.Core.Common.CommandTrees.DbExpression GenerateProjectionCqt(global::System.Data.Entity.Core.Common.CommandTrees.DbExpression row, bool isTopLevel)
		{
			if (isTopLevel)
			{
				return (from slot in this.Slots
				where slot.IsRequiredByParent
				select slot).Single<global::System.Data.Entity.Core.Mapping.ViewGeneration.CqlGeneration.SlotInfo>().AsCqt(row);
			}
			return global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.DbExpressionBuilder.NewRow(from slot in this.Slots
			where slot.IsRequiredByParent
			select new global::System.Collections.Generic.KeyValuePair<string, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(slot.CqlFieldAlias, slot.AsCqt(row)));
		}

		// Token: 0x0600474E RID: 18254 RVA: 0x000FAF10 File Offset: 0x000F9110
		internal void SetJoinTreeContext(global::System.Collections.Generic.IList<string> parentQualifiers, string leafQualifier)
		{
			this.m_joinTreeContext = new global::System.Data.Entity.Core.Mapping.ViewGeneration.CqlGeneration.CqlBlock.JoinTreeContext(parentQualifiers, leafQualifier);
		}

		// Token: 0x0600474F RID: 18255 RVA: 0x000FAF1F File Offset: 0x000F911F
		internal global::System.Data.Entity.Core.Common.CommandTrees.DbExpression GetInput(global::System.Data.Entity.Core.Common.CommandTrees.DbExpression row)
		{
			if (this.m_joinTreeContext == null)
			{
				return row;
			}
			return this.m_joinTreeContext.FindInput(row);
		}

		// Token: 0x06004750 RID: 18256 RVA: 0x000FAF38 File Offset: 0x000F9138
		internal override void ToCompactString(global::System.Text.StringBuilder builder)
		{
			for (int i = 0; i < this.m_slots.Count; i++)
			{
				global::System.Data.Entity.Core.Common.Utils.StringUtil.FormatStringBuilder(builder, "{0}: ", new object[]
				{
					i
				});
				this.m_slots[i].ToCompactString(builder);
				builder.Append(' ');
			}
			this.m_whereClause.ToCompactString(builder);
		}

		// Token: 0x04001945 RID: 6469
		private global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Data.Entity.Core.Mapping.ViewGeneration.CqlGeneration.SlotInfo> m_slots;

		// Token: 0x04001946 RID: 6470
		private readonly global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Data.Entity.Core.Mapping.ViewGeneration.CqlGeneration.CqlBlock> m_children;

		// Token: 0x04001947 RID: 6471
		private readonly global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolExpression m_whereClause;

		// Token: 0x04001948 RID: 6472
		private readonly string m_blockAlias;

		// Token: 0x04001949 RID: 6473
		private global::System.Data.Entity.Core.Mapping.ViewGeneration.CqlGeneration.CqlBlock.JoinTreeContext m_joinTreeContext;

		// Token: 0x02000BED RID: 3053
		private sealed class JoinTreeContext
		{
			// Token: 0x060068B3 RID: 26803 RVA: 0x00163ED1 File Offset: 0x001620D1
			internal JoinTreeContext(global::System.Collections.Generic.IList<string> parentQualifiers, string leafQualifier)
			{
				this.m_parentQualifiers = parentQualifiers;
				this.m_indexInParentQualifiers = parentQualifiers.Count;
				this.m_leafQualifier = leafQualifier;
			}

			// Token: 0x060068B4 RID: 26804 RVA: 0x00163EF4 File Offset: 0x001620F4
			internal global::System.Data.Entity.Core.Common.CommandTrees.DbExpression FindInput(global::System.Data.Entity.Core.Common.CommandTrees.DbExpression row)
			{
				global::System.Data.Entity.Core.Common.CommandTrees.DbExpression instance = row;
				for (int i = this.m_parentQualifiers.Count - 1; i >= this.m_indexInParentQualifiers; i--)
				{
					instance = instance.Property(this.m_parentQualifiers[i]);
				}
				return instance.Property(this.m_leafQualifier);
			}

			// Token: 0x04002F2F RID: 12079
			private readonly global::System.Collections.Generic.IList<string> m_parentQualifiers;

			// Token: 0x04002F30 RID: 12080
			private readonly int m_indexInParentQualifiers;

			// Token: 0x04002F31 RID: 12081
			private readonly string m_leafQualifier;
		}
	}
}
