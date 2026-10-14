using System;
using System.Data.Entity.Core.Common.CommandTrees;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Data.Entity.Core.Common.Utils;
using System.Data.Entity.Core.Mapping.ViewGeneration.Structures;
using System.Text;

namespace System.Data.Entity.Core.Mapping.ViewGeneration.CqlGeneration
{
	// Token: 0x020005BF RID: 1471
	internal sealed class SlotInfo : global::System.Data.Entity.Core.Common.Utils.InternalBase
	{
		// Token: 0x0600475E RID: 18270 RVA: 0x000FB418 File Offset: 0x000F9618
		internal SlotInfo(bool isRequiredByParent, bool isProjected, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.ProjectedSlot slotValue, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath outputMember) : this(isRequiredByParent, isProjected, slotValue, outputMember, false)
		{
		}

		// Token: 0x0600475F RID: 18271 RVA: 0x000FB426 File Offset: 0x000F9626
		internal SlotInfo(bool isRequiredByParent, bool isProjected, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.ProjectedSlot slotValue, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath outputMember, bool enforceNotNull)
		{
			this.m_isRequiredByParent = isRequiredByParent;
			this.m_isProjected = isProjected;
			this.m_slotValue = slotValue;
			this.m_outputMember = outputMember;
			this.m_enforceNotNull = enforceNotNull;
		}

		// Token: 0x17000E15 RID: 3605
		// (get) Token: 0x06004760 RID: 18272 RVA: 0x000FB453 File Offset: 0x000F9653
		internal bool IsRequiredByParent
		{
			get
			{
				return this.m_isRequiredByParent;
			}
		}

		// Token: 0x17000E16 RID: 3606
		// (get) Token: 0x06004761 RID: 18273 RVA: 0x000FB45B File Offset: 0x000F965B
		internal bool IsProjected
		{
			get
			{
				return this.m_isProjected;
			}
		}

		// Token: 0x17000E17 RID: 3607
		// (get) Token: 0x06004762 RID: 18274 RVA: 0x000FB463 File Offset: 0x000F9663
		internal global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath OutputMember
		{
			get
			{
				return this.m_outputMember;
			}
		}

		// Token: 0x17000E18 RID: 3608
		// (get) Token: 0x06004763 RID: 18275 RVA: 0x000FB46B File Offset: 0x000F966B
		internal global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.ProjectedSlot SlotValue
		{
			get
			{
				return this.m_slotValue;
			}
		}

		// Token: 0x17000E19 RID: 3609
		// (get) Token: 0x06004764 RID: 18276 RVA: 0x000FB473 File Offset: 0x000F9673
		internal string CqlFieldAlias
		{
			get
			{
				if (this.m_slotValue == null)
				{
					return null;
				}
				return this.m_slotValue.GetCqlFieldAlias(this.m_outputMember);
			}
		}

		// Token: 0x17000E1A RID: 3610
		// (get) Token: 0x06004765 RID: 18277 RVA: 0x000FB490 File Offset: 0x000F9690
		internal bool IsEnforcedNotNull
		{
			get
			{
				return this.m_enforceNotNull;
			}
		}

		// Token: 0x06004766 RID: 18278 RVA: 0x000FB498 File Offset: 0x000F9698
		internal void ResetIsRequiredByParent()
		{
			this.m_isRequiredByParent = false;
		}

		// Token: 0x06004767 RID: 18279 RVA: 0x000FB4A4 File Offset: 0x000F96A4
		internal global::System.Text.StringBuilder AsEsql(global::System.Text.StringBuilder builder, string blockAlias, int indentLevel)
		{
			if (this.m_enforceNotNull)
			{
				builder.Append('(');
				this.m_slotValue.AsEsql(builder, this.m_outputMember, blockAlias, indentLevel);
				builder.Append(" AND ");
				this.m_slotValue.AsEsql(builder, this.m_outputMember, blockAlias, indentLevel);
				builder.Append(" IS NOT NULL)");
			}
			else
			{
				this.m_slotValue.AsEsql(builder, this.m_outputMember, blockAlias, indentLevel);
			}
			return builder;
		}

		// Token: 0x06004768 RID: 18280 RVA: 0x000FB51C File Offset: 0x000F971C
		internal global::System.Data.Entity.Core.Common.CommandTrees.DbExpression AsCqt(global::System.Data.Entity.Core.Common.CommandTrees.DbExpression row)
		{
			global::System.Data.Entity.Core.Common.CommandTrees.DbExpression dbExpression = this.m_slotValue.AsCqt(row, this.m_outputMember);
			if (this.m_enforceNotNull)
			{
				dbExpression = dbExpression.And(dbExpression.IsNull().Not());
			}
			return dbExpression;
		}

		// Token: 0x06004769 RID: 18281 RVA: 0x000FB557 File Offset: 0x000F9757
		internal override void ToCompactString(global::System.Text.StringBuilder builder)
		{
			if (this.m_slotValue != null)
			{
				builder.Append(this.CqlFieldAlias);
			}
		}

		// Token: 0x04001951 RID: 6481
		private bool m_isRequiredByParent;

		// Token: 0x04001952 RID: 6482
		private readonly bool m_isProjected;

		// Token: 0x04001953 RID: 6483
		private readonly global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.ProjectedSlot m_slotValue;

		// Token: 0x04001954 RID: 6484
		private readonly global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath m_outputMember;

		// Token: 0x04001955 RID: 6485
		private readonly bool m_enforceNotNull;
	}
}
