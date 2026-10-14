using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Metadata.Edm;

namespace System.Data.Entity.Core.Objects
{
	// Token: 0x02000409 RID: 1033
	internal struct EntitySetQualifiedType : global::System.Collections.Generic.IEqualityComparer<global::System.Data.Entity.Core.Objects.EntitySetQualifiedType>
	{
		// Token: 0x06003119 RID: 12569 RVA: 0x0009BC36 File Offset: 0x00099E36
		internal EntitySetQualifiedType(global::System.Type type, global::System.Data.Entity.Core.Metadata.Edm.EntitySet set)
		{
			this.ClrType = global::System.Data.Entity.Core.EntityUtil.GetEntityIdentityType(type);
			this.EntitySet = set;
		}

		// Token: 0x0600311A RID: 12570 RVA: 0x0009BC4B File Offset: 0x00099E4B
		public bool Equals(global::System.Data.Entity.Core.Objects.EntitySetQualifiedType x, global::System.Data.Entity.Core.Objects.EntitySetQualifiedType y)
		{
			return x.ClrType == y.ClrType && x.EntitySet == y.EntitySet;
		}

		// Token: 0x0600311B RID: 12571 RVA: 0x0009BC6B File Offset: 0x00099E6B
		public int GetHashCode(global::System.Data.Entity.Core.Objects.EntitySetQualifiedType obj)
		{
			return obj.ClrType.GetHashCode() + obj.EntitySet.Name.GetHashCode() + obj.EntitySet.EntityContainer.Name.GetHashCode();
		}

		// Token: 0x04001030 RID: 4144
		internal static readonly global::System.Collections.Generic.IEqualityComparer<global::System.Data.Entity.Core.Objects.EntitySetQualifiedType> EqualityComparer = default(global::System.Data.Entity.Core.Objects.EntitySetQualifiedType);

		// Token: 0x04001031 RID: 4145
		internal readonly global::System.Type ClrType;

		// Token: 0x04001032 RID: 4146
		internal readonly global::System.Data.Entity.Core.Metadata.Edm.EntitySet EntitySet;
	}
}
