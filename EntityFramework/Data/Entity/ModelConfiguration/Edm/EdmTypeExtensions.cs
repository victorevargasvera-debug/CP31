using System;
using System.Data.Entity.Core.Metadata.Edm;

namespace System.Data.Entity.ModelConfiguration.Edm
{
	// Token: 0x02000166 RID: 358
	internal static class EdmTypeExtensions
	{
		// Token: 0x0600166F RID: 5743 RVA: 0x0003A474 File Offset: 0x00038674
		public static global::System.Type GetClrType(this global::System.Data.Entity.Core.Metadata.Edm.EdmType item)
		{
			global::System.Data.Entity.Core.Metadata.Edm.EntityType entityType = item as global::System.Data.Entity.Core.Metadata.Edm.EntityType;
			if (entityType != null)
			{
				return entityType.GetClrType();
			}
			global::System.Data.Entity.Core.Metadata.Edm.EnumType enumType = item as global::System.Data.Entity.Core.Metadata.Edm.EnumType;
			if (enumType != null)
			{
				return enumType.GetClrType();
			}
			global::System.Data.Entity.Core.Metadata.Edm.ComplexType complexType = item as global::System.Data.Entity.Core.Metadata.Edm.ComplexType;
			if (complexType != null)
			{
				return complexType.GetClrType();
			}
			return null;
		}
	}
}
