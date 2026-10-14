using System;
using System.Data.Entity.Resources;

namespace System.Data.Entity.Core.Common.EntitySql
{
	// Token: 0x02000661 RID: 1633
	internal sealed class MetadataNamespace : global::System.Data.Entity.Core.Common.EntitySql.MetadataMember
	{
		// Token: 0x06004E31 RID: 20017 RVA: 0x0011818A File Offset: 0x0011638A
		internal MetadataNamespace(string name) : base(global::System.Data.Entity.Core.Common.EntitySql.MetadataMemberClass.Namespace, name)
		{
		}

		// Token: 0x17000F16 RID: 3862
		// (get) Token: 0x06004E32 RID: 20018 RVA: 0x00118194 File Offset: 0x00116394
		internal override string MetadataMemberClassName
		{
			get
			{
				return global::System.Data.Entity.Core.Common.EntitySql.MetadataNamespace.NamespaceClassName;
			}
		}

		// Token: 0x17000F17 RID: 3863
		// (get) Token: 0x06004E33 RID: 20019 RVA: 0x0011819B File Offset: 0x0011639B
		internal static string NamespaceClassName
		{
			get
			{
				return global::System.Data.Entity.Resources.Strings.LocalizedNamespace;
			}
		}
	}
}
