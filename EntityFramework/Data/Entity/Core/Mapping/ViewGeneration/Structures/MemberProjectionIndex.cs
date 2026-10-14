using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Common.Utils;
using System.Data.Entity.Core.Metadata.Edm;
using System.Text;

namespace System.Data.Entity.Core.Mapping.ViewGeneration.Structures
{
	// Token: 0x020005AA RID: 1450
	internal sealed class MemberProjectionIndex : global::System.Data.Entity.Core.Common.Utils.InternalBase
	{
		// Token: 0x06004693 RID: 18067 RVA: 0x000F8500 File Offset: 0x000F6700
		internal static global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberProjectionIndex Create(global::System.Data.Entity.Core.Metadata.Edm.EntitySetBase extent, global::System.Data.Entity.Core.Metadata.Edm.EdmItemCollection edmItemCollection)
		{
			global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberProjectionIndex memberProjectionIndex = new global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberProjectionIndex();
			global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberProjectionIndex.GatherPartialSignature(memberProjectionIndex, edmItemCollection, new global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath(extent), false);
			return memberProjectionIndex;
		}

		// Token: 0x06004694 RID: 18068 RVA: 0x000F8515 File Offset: 0x000F6715
		private MemberProjectionIndex()
		{
			this.m_indexMap = new global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath, int>(global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath.EqualityComparer);
			this.m_members = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath>();
		}

		// Token: 0x17000DFD RID: 3581
		// (get) Token: 0x06004695 RID: 18069 RVA: 0x000F8538 File Offset: 0x000F6738
		internal int Count
		{
			get
			{
				return this.m_members.Count;
			}
		}

		// Token: 0x17000DFE RID: 3582
		internal global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath this[int index]
		{
			get
			{
				return this.m_members[index];
			}
		}

		// Token: 0x17000DFF RID: 3583
		// (get) Token: 0x06004697 RID: 18071 RVA: 0x000F8554 File Offset: 0x000F6754
		internal global::System.Collections.Generic.IEnumerable<int> KeySlots
		{
			get
			{
				global::System.Collections.Generic.List<int> list = new global::System.Collections.Generic.List<int>();
				for (int i = 0; i < this.Count; i++)
				{
					if (this.IsKeySlot(i, 0))
					{
						list.Add(i);
					}
				}
				return list;
			}
		}

		// Token: 0x17000E00 RID: 3584
		// (get) Token: 0x06004698 RID: 18072 RVA: 0x000F858A File Offset: 0x000F678A
		internal global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath> Members
		{
			get
			{
				return this.m_members;
			}
		}

		// Token: 0x06004699 RID: 18073 RVA: 0x000F8594 File Offset: 0x000F6794
		internal int IndexOf(global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath member)
		{
			int result;
			if (this.m_indexMap.TryGetValue(member, out result))
			{
				return result;
			}
			return -1;
		}

		// Token: 0x0600469A RID: 18074 RVA: 0x000F85B4 File Offset: 0x000F67B4
		internal int CreateIndex(global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath member)
		{
			int count;
			if (!this.m_indexMap.TryGetValue(member, out count))
			{
				count = this.m_indexMap.Count;
				this.m_indexMap[member] = count;
				this.m_members.Add(member);
			}
			return count;
		}

		// Token: 0x0600469B RID: 18075 RVA: 0x000F85F7 File Offset: 0x000F67F7
		internal global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath GetMemberPath(int slotNum, int numBoolSlots)
		{
			if (!this.IsBoolSlot(slotNum, numBoolSlots))
			{
				return this[slotNum];
			}
			return null;
		}

		// Token: 0x0600469C RID: 18076 RVA: 0x000F860C File Offset: 0x000F680C
		internal int BoolIndexToSlot(int boolIndex, int numBoolSlots)
		{
			return this.Count + boolIndex;
		}

		// Token: 0x0600469D RID: 18077 RVA: 0x000F8616 File Offset: 0x000F6816
		internal int SlotToBoolIndex(int slotNum, int numBoolSlots)
		{
			return slotNum - this.Count;
		}

		// Token: 0x0600469E RID: 18078 RVA: 0x000F8620 File Offset: 0x000F6820
		internal bool IsKeySlot(int slotNum, int numBoolSlots)
		{
			return slotNum < this.Count && this[slotNum].IsPartOfKey;
		}

		// Token: 0x0600469F RID: 18079 RVA: 0x000F8639 File Offset: 0x000F6839
		internal bool IsBoolSlot(int slotNum, int numBoolSlots)
		{
			return slotNum >= this.Count;
		}

		// Token: 0x060046A0 RID: 18080 RVA: 0x000F8647 File Offset: 0x000F6847
		internal override void ToCompactString(global::System.Text.StringBuilder builder)
		{
			builder.Append('<');
			global::System.Data.Entity.Core.Common.Utils.StringUtil.ToCommaSeparatedString(builder, this.m_members);
			builder.Append('>');
		}

		// Token: 0x060046A1 RID: 18081 RVA: 0x000F8668 File Offset: 0x000F6868
		private static void GatherPartialSignature(global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberProjectionIndex index, global::System.Data.Entity.Core.Metadata.Edm.EdmItemCollection edmItemCollection, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath member, bool needKeysOnly)
		{
			global::System.Data.Entity.Core.Metadata.Edm.EdmType edmType = member.EdmType;
			if (edmType is global::System.Data.Entity.Core.Metadata.Edm.ComplexType && needKeysOnly)
			{
				return;
			}
			index.CreateIndex(member);
			foreach (global::System.Data.Entity.Core.Metadata.Edm.EdmType edmType2 in global::System.Data.Entity.Core.Common.Utils.MetadataHelper.GetTypeAndSubtypesOf(edmType, edmItemCollection, false))
			{
				global::System.Data.Entity.Core.Metadata.Edm.StructuralType possibleType = edmType2 as global::System.Data.Entity.Core.Metadata.Edm.StructuralType;
				global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberProjectionIndex.GatherSignatureFromTypeStructuralMembers(index, edmItemCollection, member, possibleType, needKeysOnly);
			}
		}

		// Token: 0x060046A2 RID: 18082 RVA: 0x000F86DC File Offset: 0x000F68DC
		private static void GatherSignatureFromTypeStructuralMembers(global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberProjectionIndex index, global::System.Data.Entity.Core.Metadata.Edm.EdmItemCollection edmItemCollection, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath member, global::System.Data.Entity.Core.Metadata.Edm.StructuralType possibleType, bool needKeysOnly)
		{
			foreach (object obj in global::System.Data.Entity.Core.Metadata.Edm.Helper.GetAllStructuralMembers(possibleType))
			{
				global::System.Data.Entity.Core.Metadata.Edm.EdmMember edmMember = (global::System.Data.Entity.Core.Metadata.Edm.EdmMember)obj;
				if (global::System.Data.Entity.Core.Common.Utils.MetadataHelper.IsNonRefSimpleMember(edmMember))
				{
					if (!needKeysOnly || global::System.Data.Entity.Core.Common.Utils.MetadataHelper.IsPartOfEntityTypeKey(edmMember))
					{
						global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath member2 = new global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath(member, edmMember);
						index.CreateIndex(member2);
					}
				}
				else
				{
					global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath member3 = new global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath(member, edmMember);
					global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberProjectionIndex.GatherPartialSignature(index, edmItemCollection, member3, needKeysOnly || global::System.Data.Entity.Core.Metadata.Edm.Helper.IsAssociationEndMember(edmMember));
				}
			}
		}

		// Token: 0x04001926 RID: 6438
		private readonly global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath, int> m_indexMap;

		// Token: 0x04001927 RID: 6439
		private readonly global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath> m_members;
	}
}
