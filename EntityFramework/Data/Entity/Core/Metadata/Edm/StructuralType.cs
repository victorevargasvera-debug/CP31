using System;
using System.Data.Entity.Resources;
using System.Data.Entity.Utilities;

namespace System.Data.Entity.Core.Metadata.Edm
{
	// Token: 0x020004FE RID: 1278
	public abstract class StructuralType : global::System.Data.Entity.Core.Metadata.Edm.EdmType
	{
		// Token: 0x06003F3C RID: 16188 RVA: 0x000D1882 File Offset: 0x000CFA82
		internal StructuralType()
		{
			this._members = new global::System.Data.Entity.Core.Metadata.Edm.MemberCollection(this);
			this._readOnlyMembers = this._members.AsReadOnlyMetadataCollection();
		}

		// Token: 0x06003F3D RID: 16189 RVA: 0x000D18A7 File Offset: 0x000CFAA7
		internal StructuralType(string name, string namespaceName, global::System.Data.Entity.Core.Metadata.Edm.DataSpace dataSpace) : base(name, namespaceName, dataSpace)
		{
			this._members = new global::System.Data.Entity.Core.Metadata.Edm.MemberCollection(this);
			this._readOnlyMembers = this._members.AsReadOnlyMetadataCollection();
		}

		// Token: 0x17000C6E RID: 3182
		// (get) Token: 0x06003F3E RID: 16190 RVA: 0x000D18CF File Offset: 0x000CFACF
		[global::System.Data.Entity.Core.Metadata.Edm.MetadataProperty(global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.EdmMember, true)]
		public global::System.Data.Entity.Core.Metadata.Edm.ReadOnlyMetadataCollection<global::System.Data.Entity.Core.Metadata.Edm.EdmMember> Members
		{
			get
			{
				return this._readOnlyMembers;
			}
		}

		// Token: 0x06003F3F RID: 16191 RVA: 0x000D18D7 File Offset: 0x000CFAD7
		internal global::System.Data.Entity.Core.Metadata.Edm.ReadOnlyMetadataCollection<T> GetDeclaredOnlyMembers<T>() where T : global::System.Data.Entity.Core.Metadata.Edm.EdmMember
		{
			return this._members.GetDeclaredOnlyMembers<T>();
		}

		// Token: 0x06003F40 RID: 16192 RVA: 0x000D18E4 File Offset: 0x000CFAE4
		internal override void SetReadOnly()
		{
			if (!base.IsReadOnly)
			{
				base.SetReadOnly();
				this.Members.Source.SetReadOnly();
			}
		}

		// Token: 0x06003F41 RID: 16193
		internal abstract void ValidateMemberForAdd(global::System.Data.Entity.Core.Metadata.Edm.EdmMember member);

		// Token: 0x06003F42 RID: 16194 RVA: 0x000D1905 File Offset: 0x000CFB05
		public void AddMember(global::System.Data.Entity.Core.Metadata.Edm.EdmMember member)
		{
			this.AddMember(member, false);
		}

		// Token: 0x06003F43 RID: 16195 RVA: 0x000D1910 File Offset: 0x000CFB10
		internal void AddMember(global::System.Data.Entity.Core.Metadata.Edm.EdmMember member, bool forceAdd)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Metadata.Edm.EdmMember>(member, "member");
			if (!forceAdd)
			{
				global::System.Data.Entity.Core.Metadata.Edm.Util.ThrowIfReadOnly(this);
			}
			if (this.DataSpace != member.TypeUsage.EdmType.DataSpace && this.BuiltInTypeKind != global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.RowType)
			{
				throw new global::System.ArgumentException(global::System.Data.Entity.Resources.Strings.AttemptToAddEdmMemberFromWrongDataSpace(member.Name, this.Name, member.TypeUsage.EdmType.DataSpace, this.DataSpace), "member");
			}
			if (global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.RowType == this.BuiltInTypeKind)
			{
				if (this._members.Count == 0)
				{
					this.DataSpace = member.TypeUsage.EdmType.DataSpace;
				}
				else if (this.DataSpace != (global::System.Data.Entity.Core.Metadata.Edm.DataSpace)(-1) && member.TypeUsage.EdmType.DataSpace != this.DataSpace)
				{
					this.DataSpace = (global::System.Data.Entity.Core.Metadata.Edm.DataSpace)(-1);
				}
			}
			if (this._members.IsReadOnly && forceAdd)
			{
				this._members.ResetReadOnly();
				this._members.Add(member);
				this._members.SetReadOnly();
				return;
			}
			this._members.Add(member);
		}

		// Token: 0x06003F44 RID: 16196 RVA: 0x000D1A26 File Offset: 0x000CFC26
		public virtual void RemoveMember(global::System.Data.Entity.Core.Metadata.Edm.EdmMember member)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Metadata.Edm.EdmMember>(member, "member");
			global::System.Data.Entity.Core.Metadata.Edm.Util.ThrowIfReadOnly(this);
			this._members.Remove(member);
		}

		// Token: 0x06003F45 RID: 16197 RVA: 0x000D1A47 File Offset: 0x000CFC47
		internal virtual bool HasMember(global::System.Data.Entity.Core.Metadata.Edm.EdmMember member)
		{
			return this._members.Contains(member);
		}

		// Token: 0x06003F46 RID: 16198 RVA: 0x000D1A55 File Offset: 0x000CFC55
		internal virtual void NotifyItemIdentityChanged(global::System.Data.Entity.Core.Metadata.Edm.EdmMember item, string initialIdentity)
		{
			this._members.HandleIdentityChange(item, initialIdentity);
		}

		// Token: 0x04001593 RID: 5523
		private readonly global::System.Data.Entity.Core.Metadata.Edm.MemberCollection _members;

		// Token: 0x04001594 RID: 5524
		private readonly global::System.Data.Entity.Core.Metadata.Edm.ReadOnlyMetadataCollection<global::System.Data.Entity.Core.Metadata.Edm.EdmMember> _readOnlyMembers;
	}
}
