using System;
using System.Collections.Generic;
using System.Data.Entity.Resources;
using System.Data.Entity.Utilities;
using System.Linq;
using System.Runtime.CompilerServices;

namespace System.Data.Entity.Core.Metadata.Edm
{
	// Token: 0x020004BD RID: 1213
	public abstract class EntityTypeBase : global::System.Data.Entity.Core.Metadata.Edm.StructuralType
	{
		// Token: 0x06003C17 RID: 15383 RVA: 0x000C647A File Offset: 0x000C467A
		internal EntityTypeBase(string name, string namespaceName, global::System.Data.Entity.Core.Metadata.Edm.DataSpace dataSpace) : base(name, namespaceName, dataSpace)
		{
			this._keyMembers = new global::System.Data.Entity.Core.Metadata.Edm.ReadOnlyMetadataCollection<global::System.Data.Entity.Core.Metadata.Edm.EdmMember>(new global::System.Data.Entity.Core.Metadata.Edm.MetadataCollection<global::System.Data.Entity.Core.Metadata.Edm.EdmMember>());
		}

		// Token: 0x17000BBB RID: 3003
		// (get) Token: 0x06003C18 RID: 15384 RVA: 0x000C64A0 File Offset: 0x000C46A0
		[global::System.Data.Entity.Core.Metadata.Edm.MetadataProperty(global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.EdmMember, true)]
		public virtual global::System.Data.Entity.Core.Metadata.Edm.ReadOnlyMetadataCollection<global::System.Data.Entity.Core.Metadata.Edm.EdmMember> KeyMembers
		{
			get
			{
				if (this.BaseType != null && ((global::System.Data.Entity.Core.Metadata.Edm.EntityTypeBase)this.BaseType).KeyMembers.Count != 0)
				{
					return ((global::System.Data.Entity.Core.Metadata.Edm.EntityTypeBase)this.BaseType).KeyMembers;
				}
				return this._keyMembers;
			}
		}

		// Token: 0x17000BBC RID: 3004
		// (get) Token: 0x06003C19 RID: 15385 RVA: 0x000C64D8 File Offset: 0x000C46D8
		public virtual global::System.Data.Entity.Core.Metadata.Edm.ReadOnlyMetadataCollection<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty> KeyProperties
		{
			get
			{
				global::System.Data.Entity.Core.Metadata.Edm.ReadOnlyMetadataCollection<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty> keyProperties = this._keyProperties;
				if (keyProperties == null)
				{
					object keyPropertiesSync = this._keyPropertiesSync;
					lock (keyPropertiesSync)
					{
						if (this._keyProperties == null)
						{
							this.KeyMembers.SourceAccessed += this.KeyMembersSourceAccessedEventHandler;
							this._keyProperties = new global::System.Data.Entity.Core.Metadata.Edm.ReadOnlyMetadataCollection<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty>(this.KeyMembers.Cast<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty>().ToList<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty>());
						}
						keyProperties = this._keyProperties;
					}
				}
				return keyProperties;
			}
		}

		// Token: 0x06003C1A RID: 15386 RVA: 0x000C6560 File Offset: 0x000C4760
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		internal void ResetKeyPropertiesCache()
		{
			if (this._keyProperties != null)
			{
				object keyPropertiesSync = this._keyPropertiesSync;
				lock (keyPropertiesSync)
				{
					if (this._keyProperties != null)
					{
						this._keyProperties = null;
						this.KeyMembers.SourceAccessed -= this.KeyMembersSourceAccessedEventHandler;
					}
				}
			}
		}

		// Token: 0x06003C1B RID: 15387 RVA: 0x000C65C8 File Offset: 0x000C47C8
		private void KeyMembersSourceAccessedEventHandler(object sender, global::System.EventArgs e)
		{
			this.ResetKeyPropertiesCache();
		}

		// Token: 0x17000BBD RID: 3005
		// (get) Token: 0x06003C1C RID: 15388 RVA: 0x000C65D0 File Offset: 0x000C47D0
		internal virtual string[] KeyMemberNames
		{
			get
			{
				if (this._keyMemberNames == null)
				{
					string[] array = new string[this.KeyMembers.Count];
					for (int i = 0; i < array.Length; i++)
					{
						array[i] = this.KeyMembers[i].Name;
					}
					this._keyMemberNames = array;
				}
				return this._keyMemberNames;
			}
		}

		// Token: 0x06003C1D RID: 15389 RVA: 0x000C6627 File Offset: 0x000C4827
		public void AddKeyMember(global::System.Data.Entity.Core.Metadata.Edm.EdmMember member)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Metadata.Edm.EdmMember>(member, "member");
			global::System.Data.Entity.Core.Metadata.Edm.Util.ThrowIfReadOnly(this);
			if (!base.Members.Contains(member))
			{
				base.AddMember(member);
			}
			this._keyMembers.Source.Add(member);
		}

		// Token: 0x06003C1E RID: 15390 RVA: 0x000C6661 File Offset: 0x000C4861
		internal override void SetReadOnly()
		{
			if (!base.IsReadOnly)
			{
				this._keyMembers.Source.SetReadOnly();
				base.SetReadOnly();
			}
		}

		// Token: 0x06003C1F RID: 15391 RVA: 0x000C6684 File Offset: 0x000C4884
		internal static void CheckAndAddMembers(global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Metadata.Edm.EdmMember> members, global::System.Data.Entity.Core.Metadata.Edm.EntityType entityType)
		{
			foreach (global::System.Data.Entity.Core.Metadata.Edm.EdmMember edmMember in members)
			{
				if (edmMember == null)
				{
					throw new global::System.ArgumentException(global::System.Data.Entity.Resources.Strings.ADP_CollectionParameterElementIsNull("members"));
				}
				entityType.AddMember(edmMember);
			}
		}

		// Token: 0x06003C20 RID: 15392 RVA: 0x000C66E0 File Offset: 0x000C48E0
		internal void CheckAndAddKeyMembers(global::System.Collections.Generic.IEnumerable<string> keyMembers)
		{
			foreach (string text in keyMembers)
			{
				if (text == null)
				{
					throw new global::System.ArgumentException(global::System.Data.Entity.Resources.Strings.ADP_CollectionParameterElementIsNull("keyMembers"));
				}
				global::System.Data.Entity.Core.Metadata.Edm.EdmMember member;
				if (!base.Members.TryGetValue(text, false, out member))
				{
					throw new global::System.ArgumentException(global::System.Data.Entity.Resources.Strings.InvalidKeyMember(text));
				}
				this.AddKeyMember(member);
			}
		}

		// Token: 0x06003C21 RID: 15393 RVA: 0x000C6758 File Offset: 0x000C4958
		public override void RemoveMember(global::System.Data.Entity.Core.Metadata.Edm.EdmMember member)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Metadata.Edm.EdmMember>(member, "member");
			global::System.Data.Entity.Core.Metadata.Edm.Util.ThrowIfReadOnly(this);
			if (this._keyMembers.Contains(member))
			{
				this._keyMembers.Source.Remove(member);
			}
			base.RemoveMember(member);
		}

		// Token: 0x06003C22 RID: 15394 RVA: 0x000C6793 File Offset: 0x000C4993
		internal override void NotifyItemIdentityChanged(global::System.Data.Entity.Core.Metadata.Edm.EdmMember item, string initialIdentity)
		{
			base.NotifyItemIdentityChanged(item, initialIdentity);
			this._keyMembers.Source.HandleIdentityChange(item, initialIdentity);
		}

		// Token: 0x040014AE RID: 5294
		private readonly global::System.Data.Entity.Core.Metadata.Edm.ReadOnlyMetadataCollection<global::System.Data.Entity.Core.Metadata.Edm.EdmMember> _keyMembers;

		// Token: 0x040014AF RID: 5295
		private readonly object _keyPropertiesSync = new object();

		// Token: 0x040014B0 RID: 5296
		private global::System.Data.Entity.Core.Metadata.Edm.ReadOnlyMetadataCollection<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty> _keyProperties;

		// Token: 0x040014B1 RID: 5297
		private string[] _keyMemberNames;
	}
}
