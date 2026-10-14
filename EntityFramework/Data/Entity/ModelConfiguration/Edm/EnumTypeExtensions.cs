using System;
using System.Data.Entity.Core.Metadata.Edm;

namespace System.Data.Entity.ModelConfiguration.Edm
{
	// Token: 0x02000169 RID: 361
	internal static class EnumTypeExtensions
	{
		// Token: 0x06001686 RID: 5766 RVA: 0x0003A8D4 File Offset: 0x00038AD4
		public static global::System.Type GetClrType(this global::System.Data.Entity.Core.Metadata.Edm.EnumType enumType)
		{
			return enumType.Annotations.GetClrType();
		}

		// Token: 0x06001687 RID: 5767 RVA: 0x0003A8E1 File Offset: 0x00038AE1
		public static void SetClrType(this global::System.Data.Entity.Core.Metadata.Edm.EnumType enumType, global::System.Type type)
		{
			enumType.GetMetadataProperties().SetClrType(type);
		}
	}
}
