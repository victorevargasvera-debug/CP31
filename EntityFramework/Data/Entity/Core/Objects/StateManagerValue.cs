using System;

namespace System.Data.Entity.Core.Objects
{
	// Token: 0x02000434 RID: 1076
	internal struct StateManagerValue
	{
		// Token: 0x06003466 RID: 13414 RVA: 0x000A82B0 File Offset: 0x000A64B0
		public StateManagerValue(global::System.Data.Entity.Core.Objects.StateManagerMemberMetadata metadata, object instance, object value)
		{
			this.MemberMetadata = metadata;
			this.UserObject = instance;
			this.OriginalValue = value;
		}

		// Token: 0x040010E9 RID: 4329
		public global::System.Data.Entity.Core.Objects.StateManagerMemberMetadata MemberMetadata;

		// Token: 0x040010EA RID: 4330
		public object UserObject;

		// Token: 0x040010EB RID: 4331
		public object OriginalValue;
	}
}
