using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Resources;
using System.Data.Entity.Utilities;

namespace System.Data.Entity.Core.Mapping
{
	// Token: 0x02000559 RID: 1369
	internal class ObjectTypeMapping : global::System.Data.Entity.Core.Mapping.MappingBase
	{
		// Token: 0x060042F7 RID: 17143 RVA: 0x000E54B0 File Offset: 0x000E36B0
		internal ObjectTypeMapping(global::System.Data.Entity.Core.Metadata.Edm.EdmType clrType, global::System.Data.Entity.Core.Metadata.Edm.EdmType cdmType)
		{
			this.m_clrType = clrType;
			this.m_cdmType = cdmType;
			this.identity = clrType.Identity + ":" + cdmType.Identity;
			if (global::System.Data.Entity.Core.Metadata.Edm.Helper.IsStructuralType(cdmType))
			{
				this.m_memberMapping = new global::System.Collections.Generic.Dictionary<string, global::System.Data.Entity.Core.Mapping.ObjectMemberMapping>(((global::System.Data.Entity.Core.Metadata.Edm.StructuralType)cdmType).Members.Count);
				return;
			}
			this.m_memberMapping = global::System.Data.Entity.Core.Mapping.ObjectTypeMapping.EmptyMemberMapping;
		}

		// Token: 0x17000D4A RID: 3402
		// (get) Token: 0x060042F8 RID: 17144 RVA: 0x000E551C File Offset: 0x000E371C
		public override global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind BuiltInTypeKind
		{
			get
			{
				return global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.MetadataItem;
			}
		}

		// Token: 0x17000D4B RID: 3403
		// (get) Token: 0x060042F9 RID: 17145 RVA: 0x000E5520 File Offset: 0x000E3720
		internal global::System.Data.Entity.Core.Metadata.Edm.EdmType ClrType
		{
			get
			{
				return this.m_clrType;
			}
		}

		// Token: 0x17000D4C RID: 3404
		// (get) Token: 0x060042FA RID: 17146 RVA: 0x000E5528 File Offset: 0x000E3728
		internal override global::System.Data.Entity.Core.Metadata.Edm.MetadataItem EdmItem
		{
			get
			{
				return this.EdmType;
			}
		}

		// Token: 0x17000D4D RID: 3405
		// (get) Token: 0x060042FB RID: 17147 RVA: 0x000E5530 File Offset: 0x000E3730
		internal global::System.Data.Entity.Core.Metadata.Edm.EdmType EdmType
		{
			get
			{
				return this.m_cdmType;
			}
		}

		// Token: 0x17000D4E RID: 3406
		// (get) Token: 0x060042FC RID: 17148 RVA: 0x000E5538 File Offset: 0x000E3738
		internal override string Identity
		{
			get
			{
				return this.identity;
			}
		}

		// Token: 0x060042FD RID: 17149 RVA: 0x000E5540 File Offset: 0x000E3740
		internal global::System.Data.Entity.Core.Mapping.ObjectPropertyMapping GetPropertyMap(string propertyName)
		{
			global::System.Data.Entity.Core.Mapping.ObjectMemberMapping memberMap = this.GetMemberMap(propertyName, false);
			if (memberMap != null && (memberMap.MemberMappingKind == global::System.Data.Entity.Core.Mapping.MemberMappingKind.ScalarPropertyMapping || memberMap.MemberMappingKind == global::System.Data.Entity.Core.Mapping.MemberMappingKind.ComplexPropertyMapping))
			{
				return (global::System.Data.Entity.Core.Mapping.ObjectPropertyMapping)memberMap;
			}
			return null;
		}

		// Token: 0x060042FE RID: 17150 RVA: 0x000E5572 File Offset: 0x000E3772
		internal void AddMemberMap(global::System.Data.Entity.Core.Mapping.ObjectMemberMapping memberMapping)
		{
			this.m_memberMapping.Add(memberMapping.EdmMember.Name, memberMapping);
		}

		// Token: 0x060042FF RID: 17151 RVA: 0x000E558B File Offset: 0x000E378B
		internal global::System.Data.Entity.Core.Mapping.ObjectMemberMapping GetMemberMapForClrMember(string clrMemberName, bool ignoreCase)
		{
			return this.GetMemberMap(clrMemberName, ignoreCase);
		}

		// Token: 0x06004300 RID: 17152 RVA: 0x000E5598 File Offset: 0x000E3798
		private global::System.Data.Entity.Core.Mapping.ObjectMemberMapping GetMemberMap(string propertyName, bool ignoreCase)
		{
			global::System.Data.Entity.Utilities.Check.NotEmpty(propertyName, "propertyName");
			global::System.Data.Entity.Core.Mapping.ObjectMemberMapping objectMemberMapping = null;
			if (!ignoreCase)
			{
				this.m_memberMapping.TryGetValue(propertyName, out objectMemberMapping);
			}
			else
			{
				foreach (global::System.Collections.Generic.KeyValuePair<string, global::System.Data.Entity.Core.Mapping.ObjectMemberMapping> keyValuePair in this.m_memberMapping)
				{
					if (keyValuePair.Key.Equals(propertyName, global::System.StringComparison.OrdinalIgnoreCase))
					{
						if (objectMemberMapping != null)
						{
							throw new global::System.Data.Entity.Core.MappingException(global::System.Data.Entity.Resources.Strings.Mapping_Duplicate_PropertyMap_CaseInsensitive(propertyName));
						}
						objectMemberMapping = keyValuePair.Value;
					}
				}
			}
			return objectMemberMapping;
		}

		// Token: 0x06004301 RID: 17153 RVA: 0x000E5630 File Offset: 0x000E3830
		public override string ToString()
		{
			return this.Identity;
		}

		// Token: 0x040017EA RID: 6122
		private readonly global::System.Data.Entity.Core.Metadata.Edm.EdmType m_clrType;

		// Token: 0x040017EB RID: 6123
		private readonly global::System.Data.Entity.Core.Metadata.Edm.EdmType m_cdmType;

		// Token: 0x040017EC RID: 6124
		private readonly string identity;

		// Token: 0x040017ED RID: 6125
		private readonly global::System.Collections.Generic.Dictionary<string, global::System.Data.Entity.Core.Mapping.ObjectMemberMapping> m_memberMapping;

		// Token: 0x040017EE RID: 6126
		private static readonly global::System.Collections.Generic.Dictionary<string, global::System.Data.Entity.Core.Mapping.ObjectMemberMapping> EmptyMemberMapping = new global::System.Collections.Generic.Dictionary<string, global::System.Data.Entity.Core.Mapping.ObjectMemberMapping>(0);
	}
}
