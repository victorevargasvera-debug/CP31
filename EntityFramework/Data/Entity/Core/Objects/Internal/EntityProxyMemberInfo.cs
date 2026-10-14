using System;
using System.Data.Entity.Core.Metadata.Edm;

namespace System.Data.Entity.Core.Objects.Internal
{
	// Token: 0x0200043C RID: 1084
	internal sealed class EntityProxyMemberInfo
	{
		// Token: 0x06003505 RID: 13573 RVA: 0x000A9860 File Offset: 0x000A7A60
		internal EntityProxyMemberInfo(global::System.Data.Entity.Core.Metadata.Edm.EdmMember member, int propertyIndex)
		{
			this._member = member;
			this._propertyIndex = propertyIndex;
		}

		// Token: 0x17000A3C RID: 2620
		// (get) Token: 0x06003506 RID: 13574 RVA: 0x000A9876 File Offset: 0x000A7A76
		internal global::System.Data.Entity.Core.Metadata.Edm.EdmMember EdmMember
		{
			get
			{
				return this._member;
			}
		}

		// Token: 0x17000A3D RID: 2621
		// (get) Token: 0x06003507 RID: 13575 RVA: 0x000A987E File Offset: 0x000A7A7E
		internal int PropertyIndex
		{
			get
			{
				return this._propertyIndex;
			}
		}

		// Token: 0x04001113 RID: 4371
		private readonly global::System.Data.Entity.Core.Metadata.Edm.EdmMember _member;

		// Token: 0x04001114 RID: 4372
		private readonly int _propertyIndex;
	}
}
