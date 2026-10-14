using System;

namespace System.Data.Entity.Internal
{
	// Token: 0x0200010E RID: 270
	internal abstract class MemberEntryMetadata
	{
		// Token: 0x06001329 RID: 4905 RVA: 0x000315E7 File Offset: 0x0002F7E7
		protected MemberEntryMetadata(global::System.Type declaringType, global::System.Type elementType, string memberName)
		{
			this._declaringType = declaringType;
			this._elementType = elementType;
			this._memberName = memberName;
		}

		// Token: 0x0600132A RID: 4906
		public abstract global::System.Data.Entity.Internal.InternalMemberEntry CreateMemberEntry(global::System.Data.Entity.Internal.InternalEntityEntry internalEntityEntry, global::System.Data.Entity.Internal.InternalPropertyEntry parentPropertyEntry);

		// Token: 0x170004E1 RID: 1249
		// (get) Token: 0x0600132B RID: 4907
		public abstract global::System.Data.Entity.Internal.MemberEntryType MemberEntryType { get; }

		// Token: 0x170004E2 RID: 1250
		// (get) Token: 0x0600132C RID: 4908 RVA: 0x00031604 File Offset: 0x0002F804
		public string MemberName
		{
			get
			{
				return this._memberName;
			}
		}

		// Token: 0x170004E3 RID: 1251
		// (get) Token: 0x0600132D RID: 4909 RVA: 0x0003160C File Offset: 0x0002F80C
		public global::System.Type DeclaringType
		{
			get
			{
				return this._declaringType;
			}
		}

		// Token: 0x170004E4 RID: 1252
		// (get) Token: 0x0600132E RID: 4910 RVA: 0x00031614 File Offset: 0x0002F814
		public global::System.Type ElementType
		{
			get
			{
				return this._elementType;
			}
		}

		// Token: 0x170004E5 RID: 1253
		// (get) Token: 0x0600132F RID: 4911
		public abstract global::System.Type MemberType { get; }

		// Token: 0x04000943 RID: 2371
		private readonly global::System.Type _declaringType;

		// Token: 0x04000944 RID: 2372
		private readonly global::System.Type _elementType;

		// Token: 0x04000945 RID: 2373
		private readonly string _memberName;
	}
}
