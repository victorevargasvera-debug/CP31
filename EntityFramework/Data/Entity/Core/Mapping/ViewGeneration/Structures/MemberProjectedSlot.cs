using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Common.CommandTrees;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Data.Entity.Core.Common.Utils;
using System.Data.Entity.Core.Mapping.ViewGeneration.CqlGeneration;
using System.Data.Entity.Core.Metadata.Edm;
using System.Text;

namespace System.Data.Entity.Core.Mapping.ViewGeneration.Structures
{
	// Token: 0x020005A9 RID: 1449
	internal sealed class MemberProjectedSlot : global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.ProjectedSlot
	{
		// Token: 0x06004686 RID: 18054 RVA: 0x000F828D File Offset: 0x000F648D
		internal MemberProjectedSlot(global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath node)
		{
			this.m_memberPath = node;
		}

		// Token: 0x17000DFC RID: 3580
		// (get) Token: 0x06004687 RID: 18055 RVA: 0x000F829C File Offset: 0x000F649C
		internal global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath MemberPath
		{
			get
			{
				return this.m_memberPath;
			}
		}

		// Token: 0x06004688 RID: 18056 RVA: 0x000F82A4 File Offset: 0x000F64A4
		internal override global::System.Text.StringBuilder AsEsql(global::System.Text.StringBuilder builder, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath outputMember, string blockAlias, int indentLevel)
		{
			global::System.Data.Entity.Core.Metadata.Edm.TypeUsage typeUsage;
			if (this.NeedToCastCqlValue(outputMember, out typeUsage))
			{
				builder.Append("CAST(");
				this.m_memberPath.AsEsql(builder, blockAlias);
				builder.Append(" AS ");
				global::System.Data.Entity.Core.Mapping.ViewGeneration.CqlGeneration.CqlWriter.AppendEscapedTypeName(builder, typeUsage.EdmType);
				builder.Append(')');
			}
			else
			{
				this.m_memberPath.AsEsql(builder, blockAlias);
			}
			return builder;
		}

		// Token: 0x06004689 RID: 18057 RVA: 0x000F8308 File Offset: 0x000F6508
		internal override global::System.Data.Entity.Core.Common.CommandTrees.DbExpression AsCqt(global::System.Data.Entity.Core.Common.CommandTrees.DbExpression row, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath outputMember)
		{
			global::System.Data.Entity.Core.Common.CommandTrees.DbExpression dbExpression = this.m_memberPath.AsCqt(row);
			global::System.Data.Entity.Core.Metadata.Edm.TypeUsage toType;
			if (this.NeedToCastCqlValue(outputMember, out toType))
			{
				dbExpression = dbExpression.CastTo(toType);
			}
			return dbExpression;
		}

		// Token: 0x0600468A RID: 18058 RVA: 0x000F8336 File Offset: 0x000F6536
		private bool NeedToCastCqlValue(global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath outputMember, out global::System.Data.Entity.Core.Metadata.Edm.TypeUsage outputMemberTypeUsage)
		{
			global::System.Data.Entity.Core.Metadata.Edm.TypeUsage modelTypeUsage = global::System.Data.Entity.Core.Metadata.Edm.Helper.GetModelTypeUsage(this.m_memberPath.LeafEdmMember);
			outputMemberTypeUsage = global::System.Data.Entity.Core.Metadata.Edm.Helper.GetModelTypeUsage(outputMember.LeafEdmMember);
			return !modelTypeUsage.EdmType.Equals(outputMemberTypeUsage.EdmType);
		}

		// Token: 0x0600468B RID: 18059 RVA: 0x000F8369 File Offset: 0x000F6569
		internal override void ToCompactString(global::System.Text.StringBuilder builder)
		{
			this.m_memberPath.ToCompactString(builder);
		}

		// Token: 0x0600468C RID: 18060 RVA: 0x000F8377 File Offset: 0x000F6577
		internal string ToUserString()
		{
			return this.m_memberPath.PathToString(new bool?(false));
		}

		// Token: 0x0600468D RID: 18061 RVA: 0x000F838C File Offset: 0x000F658C
		protected override bool IsEqualTo(global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.ProjectedSlot right)
		{
			global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberProjectedSlot memberProjectedSlot = right as global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberProjectedSlot;
			return memberProjectedSlot != null && global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath.EqualityComparer.Equals(this.m_memberPath, memberProjectedSlot.m_memberPath);
		}

		// Token: 0x0600468E RID: 18062 RVA: 0x000F83BB File Offset: 0x000F65BB
		protected override int GetHash()
		{
			return global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath.EqualityComparer.GetHashCode(this.m_memberPath);
		}

		// Token: 0x0600468F RID: 18063 RVA: 0x000F83D0 File Offset: 0x000F65D0
		internal global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberProjectedSlot RemapSlot(global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath> remap)
		{
			global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath node = null;
			if (remap.TryGetValue(this.MemberPath, out node))
			{
				return new global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberProjectedSlot(node);
			}
			return new global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberProjectedSlot(this.MemberPath);
		}

		// Token: 0x06004690 RID: 18064 RVA: 0x000F8404 File Offset: 0x000F6604
		internal static global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberProjectedSlot> GetKeySlots(global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberProjectedSlot> slots, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath prefix)
		{
			global::System.Data.Entity.Core.Metadata.Edm.EntitySet entitySet = prefix.EntitySet;
			global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.ExtentKey> keysForEntityType = global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.ExtentKey.GetKeysForEntityType(prefix, entitySet.ElementType);
			return global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberProjectedSlot.GetSlots(slots, keysForEntityType[0].KeyFields);
		}

		// Token: 0x06004691 RID: 18065 RVA: 0x000F8438 File Offset: 0x000F6638
		internal static global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberProjectedSlot> GetSlots(global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberProjectedSlot> slots, global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath> members)
		{
			global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberProjectedSlot> list = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberProjectedSlot>();
			foreach (global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath member in members)
			{
				global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberProjectedSlot slotForMember = global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberProjectedSlot.GetSlotForMember(global::System.Data.Entity.Core.Common.Utils.Helpers.AsSuperTypeList<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberProjectedSlot, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.ProjectedSlot>(slots), member);
				if (slotForMember == null)
				{
					return null;
				}
				list.Add(slotForMember);
			}
			return list;
		}

		// Token: 0x06004692 RID: 18066 RVA: 0x000F84A0 File Offset: 0x000F66A0
		internal static global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberProjectedSlot GetSlotForMember(global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.ProjectedSlot> slots, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath member)
		{
			foreach (global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.ProjectedSlot projectedSlot in slots)
			{
				global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberProjectedSlot memberProjectedSlot = (global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberProjectedSlot)projectedSlot;
				if (global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath.EqualityComparer.Equals(memberProjectedSlot.MemberPath, member))
				{
					return memberProjectedSlot;
				}
			}
			return null;
		}

		// Token: 0x04001925 RID: 6437
		private readonly global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath m_memberPath;
	}
}
