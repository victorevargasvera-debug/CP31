using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Entity.Utilities;

namespace System.Data.Entity.Core.Metadata.Edm
{
	// Token: 0x020004CF RID: 1231
	internal sealed class MemberCollection : global::System.Data.Entity.Core.Metadata.Edm.MetadataCollection<global::System.Data.Entity.Core.Metadata.Edm.EdmMember>
	{
		// Token: 0x06003D13 RID: 15635 RVA: 0x000C944C File Offset: 0x000C764C
		public MemberCollection(global::System.Data.Entity.Core.Metadata.Edm.StructuralType declaringType) : this(declaringType, null)
		{
		}

		// Token: 0x06003D14 RID: 15636 RVA: 0x000C9456 File Offset: 0x000C7656
		public MemberCollection(global::System.Data.Entity.Core.Metadata.Edm.StructuralType declaringType, global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Metadata.Edm.EdmMember> items) : base(items)
		{
			this._declaringType = declaringType;
		}

		// Token: 0x17000C08 RID: 3080
		// (get) Token: 0x06003D15 RID: 15637 RVA: 0x000C9466 File Offset: 0x000C7666
		public override global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Data.Entity.Core.Metadata.Edm.EdmMember> AsReadOnly
		{
			get
			{
				return new global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Data.Entity.Core.Metadata.Edm.EdmMember>(this);
			}
		}

		// Token: 0x17000C09 RID: 3081
		// (get) Token: 0x06003D16 RID: 15638 RVA: 0x000C946E File Offset: 0x000C766E
		public override int Count
		{
			get
			{
				return this.GetBaseTypeMemberCount() + base.Count;
			}
		}

		// Token: 0x17000C0A RID: 3082
		public override global::System.Data.Entity.Core.Metadata.Edm.EdmMember this[int index]
		{
			get
			{
				int relativeIndex = this.GetRelativeIndex(index);
				if (relativeIndex < 0)
				{
					return ((global::System.Data.Entity.Core.Metadata.Edm.StructuralType)this._declaringType.BaseType).Members[index];
				}
				return base[relativeIndex];
			}
			set
			{
				int relativeIndex = this.GetRelativeIndex(index);
				if (relativeIndex < 0)
				{
					((global::System.Data.Entity.Core.Metadata.Edm.StructuralType)this._declaringType.BaseType).Members.Source[index] = value;
					return;
				}
				base[relativeIndex] = value;
			}
		}

		// Token: 0x06003D19 RID: 15641 RVA: 0x000C94FF File Offset: 0x000C76FF
		public override void Add(global::System.Data.Entity.Core.Metadata.Edm.EdmMember member)
		{
			this.ValidateMemberForAdd(member, "member");
			base.Add(member);
			member.ChangeDeclaringTypeWithoutCollectionFixup(this._declaringType);
		}

		// Token: 0x06003D1A RID: 15642 RVA: 0x000C9520 File Offset: 0x000C7720
		public override bool ContainsIdentity(string identity)
		{
			if (base.ContainsIdentity(identity))
			{
				return true;
			}
			global::System.Data.Entity.Core.Metadata.Edm.EdmType baseType = this._declaringType.BaseType;
			return baseType != null && ((global::System.Data.Entity.Core.Metadata.Edm.StructuralType)baseType).Members.Contains(identity);
		}

		// Token: 0x06003D1B RID: 15643 RVA: 0x000C9560 File Offset: 0x000C7760
		public override int IndexOf(global::System.Data.Entity.Core.Metadata.Edm.EdmMember item)
		{
			int num = base.IndexOf(item);
			if (num != -1)
			{
				return num + this.GetBaseTypeMemberCount();
			}
			global::System.Data.Entity.Core.Metadata.Edm.StructuralType structuralType = this._declaringType.BaseType as global::System.Data.Entity.Core.Metadata.Edm.StructuralType;
			if (structuralType != null)
			{
				return structuralType.Members.IndexOf(item);
			}
			return -1;
		}

		// Token: 0x06003D1C RID: 15644 RVA: 0x000C95A4 File Offset: 0x000C77A4
		public override void CopyTo(global::System.Data.Entity.Core.Metadata.Edm.EdmMember[] array, int arrayIndex)
		{
			if (arrayIndex < 0)
			{
				throw new global::System.ArgumentOutOfRangeException("arrayIndex");
			}
			int baseTypeMemberCount = this.GetBaseTypeMemberCount();
			if (base.Count + baseTypeMemberCount > array.Length - arrayIndex)
			{
				throw new global::System.ArgumentOutOfRangeException("arrayIndex");
			}
			if (baseTypeMemberCount > 0)
			{
				((global::System.Data.Entity.Core.Metadata.Edm.StructuralType)this._declaringType.BaseType).Members.CopyTo(array, arrayIndex);
			}
			base.CopyTo(array, arrayIndex + baseTypeMemberCount);
		}

		// Token: 0x06003D1D RID: 15645 RVA: 0x000C960C File Offset: 0x000C780C
		public override bool TryGetValue(string identity, bool ignoreCase, out global::System.Data.Entity.Core.Metadata.Edm.EdmMember item)
		{
			if (!base.TryGetValue(identity, ignoreCase, out item))
			{
				global::System.Data.Entity.Core.Metadata.Edm.EdmType baseType = this._declaringType.BaseType;
				if (baseType != null)
				{
					((global::System.Data.Entity.Core.Metadata.Edm.StructuralType)baseType).Members.TryGetValue(identity, ignoreCase, out item);
				}
			}
			return item != null;
		}

		// Token: 0x06003D1E RID: 15646 RVA: 0x000C964C File Offset: 0x000C784C
		internal global::System.Data.Entity.Core.Metadata.Edm.ReadOnlyMetadataCollection<T> GetDeclaredOnlyMembers<T>() where T : global::System.Data.Entity.Core.Metadata.Edm.EdmMember
		{
			global::System.Data.Entity.Core.Metadata.Edm.MetadataCollection<T> metadataCollection = new global::System.Data.Entity.Core.Metadata.Edm.MetadataCollection<T>();
			for (int i = 0; i < base.Count; i++)
			{
				T t = base[i] as T;
				if (t != null)
				{
					metadataCollection.Add(t);
				}
			}
			return new global::System.Data.Entity.Core.Metadata.Edm.ReadOnlyMetadataCollection<T>(metadataCollection);
		}

		// Token: 0x06003D1F RID: 15647 RVA: 0x000C9698 File Offset: 0x000C7898
		private int GetBaseTypeMemberCount()
		{
			global::System.Data.Entity.Core.Metadata.Edm.StructuralType structuralType = this._declaringType.BaseType as global::System.Data.Entity.Core.Metadata.Edm.StructuralType;
			if (structuralType != null)
			{
				return structuralType.Members.Count;
			}
			return 0;
		}

		// Token: 0x06003D20 RID: 15648 RVA: 0x000C96C8 File Offset: 0x000C78C8
		private int GetRelativeIndex(int index)
		{
			int baseTypeMemberCount = this.GetBaseTypeMemberCount();
			int count = base.Count;
			if (index < 0 || index >= baseTypeMemberCount + count)
			{
				throw new global::System.ArgumentOutOfRangeException("index");
			}
			return index - baseTypeMemberCount;
		}

		// Token: 0x06003D21 RID: 15649 RVA: 0x000C96FB File Offset: 0x000C78FB
		private void ValidateMemberForAdd(global::System.Data.Entity.Core.Metadata.Edm.EdmMember member, string argumentName)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Metadata.Edm.EdmMember>(member, argumentName);
			this._declaringType.ValidateMemberForAdd(member);
		}

		// Token: 0x040014EB RID: 5355
		private readonly global::System.Data.Entity.Core.Metadata.Edm.StructuralType _declaringType;
	}
}
