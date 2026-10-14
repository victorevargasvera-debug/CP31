using System;

namespace System.Data.Entity.Internal
{
	// Token: 0x02000110 RID: 272
	internal class NavigationEntryMetadata : global::System.Data.Entity.Internal.MemberEntryMetadata
	{
		// Token: 0x06001330 RID: 4912 RVA: 0x0003161C File Offset: 0x0002F81C
		public NavigationEntryMetadata(global::System.Type declaringType, global::System.Type propertyType, string propertyName, bool isCollection) : base(declaringType, propertyType, propertyName)
		{
			this._isCollection = isCollection;
		}

		// Token: 0x170004E6 RID: 1254
		// (get) Token: 0x06001331 RID: 4913 RVA: 0x0003162F File Offset: 0x0002F82F
		public override global::System.Data.Entity.Internal.MemberEntryType MemberEntryType
		{
			get
			{
				if (!this._isCollection)
				{
					return global::System.Data.Entity.Internal.MemberEntryType.ReferenceNavigationProperty;
				}
				return global::System.Data.Entity.Internal.MemberEntryType.CollectionNavigationProperty;
			}
		}

		// Token: 0x170004E7 RID: 1255
		// (get) Token: 0x06001332 RID: 4914 RVA: 0x0003163C File Offset: 0x0002F83C
		public override global::System.Type MemberType
		{
			get
			{
				if (!this._isCollection)
				{
					return base.ElementType;
				}
				return global::System.Data.Entity.Internal.DbHelpers.CollectionType(base.ElementType);
			}
		}

		// Token: 0x06001333 RID: 4915 RVA: 0x00031658 File Offset: 0x0002F858
		public override global::System.Data.Entity.Internal.InternalMemberEntry CreateMemberEntry(global::System.Data.Entity.Internal.InternalEntityEntry internalEntityEntry, global::System.Data.Entity.Internal.InternalPropertyEntry parentPropertyEntry)
		{
			if (!this._isCollection)
			{
				return new global::System.Data.Entity.Internal.InternalReferenceEntry(internalEntityEntry, this);
			}
			return new global::System.Data.Entity.Internal.InternalCollectionEntry(internalEntityEntry, this);
		}

		// Token: 0x0400094B RID: 2379
		private readonly bool _isCollection;
	}
}
