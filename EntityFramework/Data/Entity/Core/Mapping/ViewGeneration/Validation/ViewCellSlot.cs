using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Common.CommandTrees;
using System.Data.Entity.Core.Common.Utils;
using System.Data.Entity.Core.Mapping.ViewGeneration.Structures;
using System.Text;

namespace System.Data.Entity.Core.Mapping.ViewGeneration.Validation
{
	// Token: 0x02000582 RID: 1410
	internal class ViewCellSlot : global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.ProjectedSlot
	{
		// Token: 0x0600444B RID: 17483 RVA: 0x000EF208 File Offset: 0x000ED408
		internal ViewCellSlot(int slotNum, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberProjectedSlot cSlot, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberProjectedSlot sSlot)
		{
			this.m_slotNum = slotNum;
			this.m_cSlot = cSlot;
			this.m_sSlot = sSlot;
		}

		// Token: 0x17000D83 RID: 3459
		// (get) Token: 0x0600444C RID: 17484 RVA: 0x000EF225 File Offset: 0x000ED425
		internal global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberProjectedSlot CSlot
		{
			get
			{
				return this.m_cSlot;
			}
		}

		// Token: 0x17000D84 RID: 3460
		// (get) Token: 0x0600444D RID: 17485 RVA: 0x000EF22D File Offset: 0x000ED42D
		internal global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberProjectedSlot SSlot
		{
			get
			{
				return this.m_sSlot;
			}
		}

		// Token: 0x0600444E RID: 17486 RVA: 0x000EF238 File Offset: 0x000ED438
		protected override bool IsEqualTo(global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.ProjectedSlot right)
		{
			global::System.Data.Entity.Core.Mapping.ViewGeneration.Validation.ViewCellSlot viewCellSlot = right as global::System.Data.Entity.Core.Mapping.ViewGeneration.Validation.ViewCellSlot;
			return viewCellSlot != null && (this.m_slotNum == viewCellSlot.m_slotNum && global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.ProjectedSlot.EqualityComparer.Equals(this.m_cSlot, viewCellSlot.m_cSlot)) && global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.ProjectedSlot.EqualityComparer.Equals(this.m_sSlot, viewCellSlot.m_sSlot);
		}

		// Token: 0x0600444F RID: 17487 RVA: 0x000EF28F File Offset: 0x000ED48F
		protected override int GetHash()
		{
			return global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.ProjectedSlot.EqualityComparer.GetHashCode(this.m_cSlot) ^ global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.ProjectedSlot.EqualityComparer.GetHashCode(this.m_sSlot) ^ this.m_slotNum;
		}

		// Token: 0x06004450 RID: 17488 RVA: 0x000EF2BC File Offset: 0x000ED4BC
		internal static string SlotsToUserString(global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Mapping.ViewGeneration.Validation.ViewCellSlot> slots, bool isFromCside)
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			bool flag = true;
			foreach (global::System.Data.Entity.Core.Mapping.ViewGeneration.Validation.ViewCellSlot slot in slots)
			{
				if (!flag)
				{
					stringBuilder.Append(", ");
				}
				stringBuilder.Append(global::System.Data.Entity.Core.Mapping.ViewGeneration.Validation.ViewCellSlot.SlotToUserString(slot, isFromCside));
				flag = false;
			}
			return stringBuilder.ToString();
		}

		// Token: 0x06004451 RID: 17489 RVA: 0x000EF32C File Offset: 0x000ED52C
		internal static string SlotToUserString(global::System.Data.Entity.Core.Mapping.ViewGeneration.Validation.ViewCellSlot slot, bool isFromCside)
		{
			global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberProjectedSlot memberProjectedSlot = isFromCside ? slot.CSlot : slot.SSlot;
			return global::System.Data.Entity.Core.Common.Utils.StringUtil.FormatInvariant("{0}", new object[]
			{
				memberProjectedSlot
			});
		}

		// Token: 0x06004452 RID: 17490 RVA: 0x000EF35F File Offset: 0x000ED55F
		internal override string GetCqlFieldAlias(global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath outputMember)
		{
			return null;
		}

		// Token: 0x06004453 RID: 17491 RVA: 0x000EF362 File Offset: 0x000ED562
		internal override global::System.Text.StringBuilder AsEsql(global::System.Text.StringBuilder builder, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath outputMember, string blockAlias, int indentLevel)
		{
			return null;
		}

		// Token: 0x06004454 RID: 17492 RVA: 0x000EF365 File Offset: 0x000ED565
		internal override global::System.Data.Entity.Core.Common.CommandTrees.DbExpression AsCqt(global::System.Data.Entity.Core.Common.CommandTrees.DbExpression row, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath outputMember)
		{
			return null;
		}

		// Token: 0x06004455 RID: 17493 RVA: 0x000EF368 File Offset: 0x000ED568
		internal override void ToCompactString(global::System.Text.StringBuilder builder)
		{
			builder.Append('<');
			global::System.Data.Entity.Core.Common.Utils.StringUtil.FormatStringBuilder(builder, "{0}", new object[]
			{
				this.m_slotNum
			});
			builder.Append(':');
			this.m_cSlot.ToCompactString(builder);
			builder.Append('-');
			this.m_sSlot.ToCompactString(builder);
			builder.Append('>');
		}

		// Token: 0x0400189C RID: 6300
		private readonly int m_slotNum;

		// Token: 0x0400189D RID: 6301
		private readonly global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberProjectedSlot m_cSlot;

		// Token: 0x0400189E RID: 6302
		private readonly global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberProjectedSlot m_sSlot;
	}
}
