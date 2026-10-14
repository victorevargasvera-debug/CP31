using System;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Resources;

namespace System.Data.Entity.Core.SchemaObjectModel
{
	// Token: 0x02000326 RID: 806
	internal static class ValidationHelper
	{
		// Token: 0x06002665 RID: 9829 RVA: 0x0006DA14 File Offset: 0x0006BC14
		internal static void ValidateFacets(global::System.Data.Entity.Core.SchemaObjectModel.SchemaElement element, global::System.Data.Entity.Core.SchemaObjectModel.SchemaType type, global::System.Data.Entity.Core.SchemaObjectModel.TypeUsageBuilder typeUsageBuilder)
		{
			if (type != null)
			{
				global::System.Data.Entity.Core.SchemaObjectModel.SchemaEnumType schemaEnumType = type as global::System.Data.Entity.Core.SchemaObjectModel.SchemaEnumType;
				if (schemaEnumType != null)
				{
					typeUsageBuilder.ValidateEnumFacets(schemaEnumType);
					return;
				}
				if (!(type is global::System.Data.Entity.Core.SchemaObjectModel.ScalarType) && typeUsageBuilder.HasUserDefinedFacets)
				{
					element.AddError(global::System.Data.Entity.Core.SchemaObjectModel.ErrorCode.FacetOnNonScalarType, global::System.Data.Entity.Core.Metadata.Edm.EdmSchemaErrorSeverity.Error, global::System.Data.Entity.Resources.Strings.FacetsOnNonScalarType(type.FQName));
					return;
				}
			}
			else if (typeUsageBuilder.HasUserDefinedFacets)
			{
				element.AddError(global::System.Data.Entity.Core.SchemaObjectModel.ErrorCode.IncorrectlyPlacedFacet, global::System.Data.Entity.Core.Metadata.Edm.EdmSchemaErrorSeverity.Error, global::System.Data.Entity.Resources.Strings.FacetDeclarationRequiresTypeAttribute);
			}
		}

		// Token: 0x06002666 RID: 9830 RVA: 0x0006DA77 File Offset: 0x0006BC77
		internal static void ValidateTypeDeclaration(global::System.Data.Entity.Core.SchemaObjectModel.SchemaElement element, global::System.Data.Entity.Core.SchemaObjectModel.SchemaType type, global::System.Data.Entity.Core.SchemaObjectModel.SchemaElement typeSubElement)
		{
			if (type == null && typeSubElement == null)
			{
				element.AddError(global::System.Data.Entity.Core.SchemaObjectModel.ErrorCode.TypeNotDeclared, global::System.Data.Entity.Core.Metadata.Edm.EdmSchemaErrorSeverity.Error, global::System.Data.Entity.Resources.Strings.TypeMustBeDeclared);
			}
			if (type != null && typeSubElement != null)
			{
				element.AddError(global::System.Data.Entity.Core.SchemaObjectModel.ErrorCode.TypeDeclaredAsAttributeAndElement, global::System.Data.Entity.Core.Metadata.Edm.EdmSchemaErrorSeverity.Error, global::System.Data.Entity.Resources.Strings.TypeDeclaredAsAttributeAndElement);
			}
		}

		// Token: 0x06002667 RID: 9831 RVA: 0x0006DAA7 File Offset: 0x0006BCA7
		internal static void ValidateRefType(global::System.Data.Entity.Core.SchemaObjectModel.SchemaElement element, global::System.Data.Entity.Core.SchemaObjectModel.SchemaType type)
		{
			if (type != null && !(type is global::System.Data.Entity.Core.SchemaObjectModel.SchemaEntityType))
			{
				element.AddError(global::System.Data.Entity.Core.SchemaObjectModel.ErrorCode.ReferenceToNonEntityType, global::System.Data.Entity.Core.Metadata.Edm.EdmSchemaErrorSeverity.Error, global::System.Data.Entity.Resources.Strings.ReferenceToNonEntityType(type.FQName));
			}
		}
	}
}
