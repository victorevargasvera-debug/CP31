using System;
using System.Data.Entity.Core.Mapping;
using System.Data.Entity.Core.Metadata.Edm.Provider;
using System.Data.Entity.Resources;
using System.Data.Entity.Utilities;

namespace System.Data.Entity.Core.Metadata.Edm
{
	// Token: 0x0200048F RID: 1167
	internal sealed class ClrPerspective : global::System.Data.Entity.Core.Metadata.Edm.Perspective
	{
		// Token: 0x060039E8 RID: 14824 RVA: 0x000BDD76 File Offset: 0x000BBF76
		internal ClrPerspective(global::System.Data.Entity.Core.Metadata.Edm.MetadataWorkspace metadataWorkspace) : base(metadataWorkspace, global::System.Data.Entity.Core.Metadata.Edm.DataSpace.CSpace)
		{
		}

		// Token: 0x060039E9 RID: 14825 RVA: 0x000BDD80 File Offset: 0x000BBF80
		internal bool TryGetType(global::System.Type clrType, out global::System.Data.Entity.Core.Metadata.Edm.TypeUsage outTypeUsage)
		{
			return this.TryGetTypeByName(clrType.FullNameWithNesting(), false, out outTypeUsage);
		}

		// Token: 0x060039EA RID: 14826 RVA: 0x000BDD90 File Offset: 0x000BBF90
		internal override bool TryGetMember(global::System.Data.Entity.Core.Metadata.Edm.StructuralType type, string memberName, bool ignoreCase, out global::System.Data.Entity.Core.Metadata.Edm.EdmMember outMember)
		{
			outMember = null;
			global::System.Data.Entity.Core.Mapping.MappingBase mappingBase = null;
			if (base.MetadataWorkspace.TryGetMap(type, global::System.Data.Entity.Core.Metadata.Edm.DataSpace.OCSpace, out mappingBase))
			{
				global::System.Data.Entity.Core.Mapping.ObjectTypeMapping objectTypeMapping = mappingBase as global::System.Data.Entity.Core.Mapping.ObjectTypeMapping;
				if (objectTypeMapping != null)
				{
					global::System.Data.Entity.Core.Mapping.ObjectMemberMapping memberMapForClrMember = objectTypeMapping.GetMemberMapForClrMember(memberName, ignoreCase);
					if (memberMapForClrMember != null)
					{
						outMember = memberMapForClrMember.EdmMember;
						return true;
					}
				}
			}
			return false;
		}

		// Token: 0x060039EB RID: 14827 RVA: 0x000BDDD8 File Offset: 0x000BBFD8
		internal override bool TryGetTypeByName(string fullName, bool ignoreCase, out global::System.Data.Entity.Core.Metadata.Edm.TypeUsage typeUsage)
		{
			typeUsage = null;
			global::System.Data.Entity.Core.Mapping.MappingBase mappingBase = null;
			if (base.MetadataWorkspace.TryGetMap(fullName, global::System.Data.Entity.Core.Metadata.Edm.DataSpace.OSpace, ignoreCase, global::System.Data.Entity.Core.Metadata.Edm.DataSpace.OCSpace, out mappingBase))
			{
				if (mappingBase.EdmItem.BuiltInTypeKind == global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.PrimitiveType)
				{
					global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType mappedPrimitiveType = base.MetadataWorkspace.GetMappedPrimitiveType(((global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType)mappingBase.EdmItem).PrimitiveTypeKind, global::System.Data.Entity.Core.Metadata.Edm.DataSpace.CSpace);
					if (mappedPrimitiveType != null)
					{
						typeUsage = global::System.Data.Entity.Core.Metadata.Edm.Provider.EdmProviderManifest.Instance.GetCanonicalModelTypeUsage(mappedPrimitiveType.PrimitiveTypeKind);
					}
				}
				else
				{
					typeUsage = global::System.Data.Entity.Core.Metadata.Edm.ClrPerspective.GetMappedTypeUsage(mappingBase);
				}
			}
			return typeUsage != null;
		}

		// Token: 0x060039EC RID: 14828 RVA: 0x000BDE4D File Offset: 0x000BC04D
		internal override global::System.Data.Entity.Core.Metadata.Edm.EntityContainer GetDefaultContainer()
		{
			return this._defaultContainer;
		}

		// Token: 0x060039ED RID: 14829 RVA: 0x000BDE58 File Offset: 0x000BC058
		internal void SetDefaultContainer(string defaultContainerName)
		{
			global::System.Data.Entity.Core.Metadata.Edm.EntityContainer defaultContainer = null;
			if (!string.IsNullOrEmpty(defaultContainerName) && !base.MetadataWorkspace.TryGetEntityContainer(defaultContainerName, global::System.Data.Entity.Core.Metadata.Edm.DataSpace.CSpace, out defaultContainer))
			{
				throw new global::System.ArgumentException(global::System.Data.Entity.Resources.Strings.ObjectContext_InvalidDefaultContainerName(defaultContainerName), "defaultContainerName");
			}
			this._defaultContainer = defaultContainer;
		}

		// Token: 0x060039EE RID: 14830 RVA: 0x000BDE98 File Offset: 0x000BC098
		private static global::System.Data.Entity.Core.Metadata.Edm.TypeUsage GetMappedTypeUsage(global::System.Data.Entity.Core.Mapping.MappingBase map)
		{
			global::System.Data.Entity.Core.Metadata.Edm.TypeUsage result = null;
			if (map != null)
			{
				global::System.Data.Entity.Core.Metadata.Edm.MetadataItem edmItem = map.EdmItem;
				global::System.Data.Entity.Core.Metadata.Edm.EdmType edmType = edmItem as global::System.Data.Entity.Core.Metadata.Edm.EdmType;
				if (edmItem != null && edmType != null)
				{
					result = global::System.Data.Entity.Core.Metadata.Edm.TypeUsage.Create(edmType);
				}
			}
			return result;
		}

		// Token: 0x04001353 RID: 4947
		private global::System.Data.Entity.Core.Metadata.Edm.EntityContainer _defaultContainer;
	}
}
