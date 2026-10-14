using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Common.CommandTrees;
using System.Data.Entity.Core.Common.Utils;
using System.Data.Entity.Core.Mapping.ViewGeneration.CqlGeneration;
using System.Text;

namespace System.Data.Entity.Core.Mapping.ViewGeneration.Structures
{
	// Token: 0x020005AE RID: 1454
	internal abstract class ProjectedSlot : global::System.Data.Entity.Core.Common.Utils.InternalBase, global::System.IEquatable<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.ProjectedSlot>
	{
		// Token: 0x060046E0 RID: 18144 RVA: 0x000F9935 File Offset: 0x000F7B35
		protected virtual bool IsEqualTo(global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.ProjectedSlot right)
		{
			return base.Equals(right);
		}

		// Token: 0x060046E1 RID: 18145 RVA: 0x000F993E File Offset: 0x000F7B3E
		protected virtual int GetHash()
		{
			return base.GetHashCode();
		}

		// Token: 0x060046E2 RID: 18146 RVA: 0x000F9946 File Offset: 0x000F7B46
		public bool Equals(global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.ProjectedSlot right)
		{
			return global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.ProjectedSlot.EqualityComparer.Equals(this, right);
		}

		// Token: 0x060046E3 RID: 18147 RVA: 0x000F9954 File Offset: 0x000F7B54
		public override bool Equals(object obj)
		{
			global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.ProjectedSlot right = obj as global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.ProjectedSlot;
			return obj != null && this.Equals(right);
		}

		// Token: 0x060046E4 RID: 18148 RVA: 0x000F9974 File Offset: 0x000F7B74
		public override int GetHashCode()
		{
			return global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.ProjectedSlot.EqualityComparer.GetHashCode(this);
		}

		// Token: 0x060046E5 RID: 18149 RVA: 0x000F9981 File Offset: 0x000F7B81
		internal virtual global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.ProjectedSlot DeepQualify(global::System.Data.Entity.Core.Mapping.ViewGeneration.CqlGeneration.CqlBlock block)
		{
			return new global::System.Data.Entity.Core.Mapping.ViewGeneration.CqlGeneration.QualifiedSlot(block, this);
		}

		// Token: 0x060046E6 RID: 18150 RVA: 0x000F998A File Offset: 0x000F7B8A
		internal virtual string GetCqlFieldAlias(global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath outputMember)
		{
			return outputMember.CqlFieldAlias;
		}

		// Token: 0x060046E7 RID: 18151
		internal abstract global::System.Text.StringBuilder AsEsql(global::System.Text.StringBuilder builder, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath outputMember, string blockAlias, int indentLevel);

		// Token: 0x060046E8 RID: 18152
		internal abstract global::System.Data.Entity.Core.Common.CommandTrees.DbExpression AsCqt(global::System.Data.Entity.Core.Common.CommandTrees.DbExpression row, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath outputMember);

		// Token: 0x060046E9 RID: 18153 RVA: 0x000F9994 File Offset: 0x000F7B94
		internal static bool TryMergeRemapSlots(global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.ProjectedSlot[] slots1, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.ProjectedSlot[] slots2, out global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.ProjectedSlot[] result)
		{
			global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.ProjectedSlot[] array;
			if (!global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.ProjectedSlot.TryMergeSlots(slots1, slots2, out array))
			{
				result = null;
				return false;
			}
			result = array;
			return true;
		}

		// Token: 0x060046EA RID: 18154 RVA: 0x000F99B8 File Offset: 0x000F7BB8
		private static bool TryMergeSlots(global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.ProjectedSlot[] slots1, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.ProjectedSlot[] slots2, out global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.ProjectedSlot[] slots)
		{
			slots = new global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.ProjectedSlot[slots1.Length];
			for (int i = 0; i < slots.Length; i++)
			{
				global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.ProjectedSlot projectedSlot = slots1[i];
				global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.ProjectedSlot projectedSlot2 = slots2[i];
				if (projectedSlot == null)
				{
					slots[i] = projectedSlot2;
				}
				else if (projectedSlot2 == null)
				{
					slots[i] = projectedSlot;
				}
				else
				{
					global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberProjectedSlot memberProjectedSlot = projectedSlot as global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberProjectedSlot;
					global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberProjectedSlot memberProjectedSlot2 = projectedSlot2 as global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberProjectedSlot;
					if (memberProjectedSlot != null && memberProjectedSlot2 != null && !global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.ProjectedSlot.EqualityComparer.Equals(memberProjectedSlot, memberProjectedSlot2))
					{
						return false;
					}
					global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.ProjectedSlot projectedSlot3 = (memberProjectedSlot != null) ? projectedSlot : projectedSlot2;
					slots[i] = projectedSlot3;
				}
			}
			return true;
		}

		// Token: 0x04001931 RID: 6449
		internal static readonly global::System.Collections.Generic.IEqualityComparer<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.ProjectedSlot> EqualityComparer = new global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.ProjectedSlot.Comparer();

		// Token: 0x02000BE1 RID: 3041
		private sealed class Comparer : global::System.Collections.Generic.IEqualityComparer<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.ProjectedSlot>
		{
			// Token: 0x06006884 RID: 26756 RVA: 0x0016351C File Offset: 0x0016171C
			public bool Equals(global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.ProjectedSlot left, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.ProjectedSlot right)
			{
				return left == right || (left != null && right != null && left.IsEqualTo(right));
			}

			// Token: 0x06006885 RID: 26757 RVA: 0x00163533 File Offset: 0x00161733
			public int GetHashCode(global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.ProjectedSlot key)
			{
				return key.GetHash();
			}
		}
	}
}
