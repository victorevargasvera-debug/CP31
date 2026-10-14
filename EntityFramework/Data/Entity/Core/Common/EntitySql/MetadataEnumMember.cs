using System;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Resources;

namespace System.Data.Entity.Core.Common.EntitySql
{
	// Token: 0x0200065D RID: 1629
	internal sealed class MetadataEnumMember : global::System.Data.Entity.Core.Common.EntitySql.MetadataMember
	{
		// Token: 0x06004E26 RID: 20006 RVA: 0x00118118 File Offset: 0x00116318
		internal MetadataEnumMember(string name, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage enumType, global::System.Data.Entity.Core.Metadata.Edm.EnumMember enumMember) : base(global::System.Data.Entity.Core.Common.EntitySql.MetadataMemberClass.EnumMember, name)
		{
			this.EnumType = enumType;
			this.EnumMember = enumMember;
		}

		// Token: 0x17000F0F RID: 3855
		// (get) Token: 0x06004E27 RID: 20007 RVA: 0x00118130 File Offset: 0x00116330
		internal override string MetadataMemberClassName
		{
			get
			{
				return global::System.Data.Entity.Core.Common.EntitySql.MetadataEnumMember.EnumMemberClassName;
			}
		}

		// Token: 0x17000F10 RID: 3856
		// (get) Token: 0x06004E28 RID: 20008 RVA: 0x00118137 File Offset: 0x00116337
		internal static string EnumMemberClassName
		{
			get
			{
				return global::System.Data.Entity.Resources.Strings.LocalizedEnumMember;
			}
		}

		// Token: 0x04001C52 RID: 7250
		internal readonly global::System.Data.Entity.Core.Metadata.Edm.TypeUsage EnumType;

		// Token: 0x04001C53 RID: 7251
		internal readonly global::System.Data.Entity.Core.Metadata.Edm.EnumMember EnumMember;
	}
}
