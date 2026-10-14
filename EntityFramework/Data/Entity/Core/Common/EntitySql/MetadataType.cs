using System;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Resources;

namespace System.Data.Entity.Core.Common.EntitySql
{
	// Token: 0x02000662 RID: 1634
	internal sealed class MetadataType : global::System.Data.Entity.Core.Common.EntitySql.MetadataMember
	{
		// Token: 0x06004E34 RID: 20020 RVA: 0x001181A2 File Offset: 0x001163A2
		internal MetadataType(string name, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage typeUsage) : base(global::System.Data.Entity.Core.Common.EntitySql.MetadataMemberClass.Type, name)
		{
			this.TypeUsage = typeUsage;
		}

		// Token: 0x17000F18 RID: 3864
		// (get) Token: 0x06004E35 RID: 20021 RVA: 0x001181B3 File Offset: 0x001163B3
		internal override string MetadataMemberClassName
		{
			get
			{
				return global::System.Data.Entity.Core.Common.EntitySql.MetadataType.TypeClassName;
			}
		}

		// Token: 0x17000F19 RID: 3865
		// (get) Token: 0x06004E36 RID: 20022 RVA: 0x001181BA File Offset: 0x001163BA
		internal static string TypeClassName
		{
			get
			{
				return global::System.Data.Entity.Resources.Strings.LocalizedType;
			}
		}

		// Token: 0x04001C5D RID: 7261
		internal readonly global::System.Data.Entity.Core.Metadata.Edm.TypeUsage TypeUsage;
	}
}
