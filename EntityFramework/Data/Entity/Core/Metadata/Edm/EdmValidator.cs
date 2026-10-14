using System;
using System.Collections.Generic;
using System.Data.Entity.Resources;
using System.Data.Entity.Utilities;

namespace System.Data.Entity.Core.Metadata.Edm
{
	// Token: 0x020004B6 RID: 1206
	internal class EdmValidator
	{
		// Token: 0x17000B9A RID: 2970
		// (get) Token: 0x06003B88 RID: 15240 RVA: 0x000C393E File Offset: 0x000C1B3E
		// (set) Token: 0x06003B89 RID: 15241 RVA: 0x000C3946 File Offset: 0x000C1B46
		internal bool SkipReadOnlyItems { get; set; }

		// Token: 0x06003B8A RID: 15242 RVA: 0x000C3950 File Offset: 0x000C1B50
		public void Validate<T>(global::System.Collections.Generic.IEnumerable<T> items, global::System.Collections.Generic.List<global::System.Data.Entity.Core.Metadata.Edm.EdmItemError> ospaceErrors) where T : global::System.Data.Entity.Core.Metadata.Edm.EdmType
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Collections.Generic.IEnumerable<T>>(items, "items");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Collections.Generic.IEnumerable<T>>(items, "items");
			global::System.Collections.Generic.HashSet<global::System.Data.Entity.Core.Metadata.Edm.MetadataItem> validatedItems = new global::System.Collections.Generic.HashSet<global::System.Data.Entity.Core.Metadata.Edm.MetadataItem>();
			foreach (T t in items)
			{
				global::System.Data.Entity.Core.Metadata.Edm.MetadataItem item = t;
				this.InternalValidate(item, ospaceErrors, validatedItems);
			}
		}

		// Token: 0x06003B8B RID: 15243 RVA: 0x000C39C0 File Offset: 0x000C1BC0
		protected virtual void OnValidationError(global::System.Data.Entity.Core.Metadata.Edm.ValidationErrorEventArgs e)
		{
		}

		// Token: 0x06003B8C RID: 15244 RVA: 0x000C39C4 File Offset: 0x000C1BC4
		private void AddError(global::System.Collections.Generic.List<global::System.Data.Entity.Core.Metadata.Edm.EdmItemError> errors, global::System.Data.Entity.Core.Metadata.Edm.EdmItemError newError)
		{
			global::System.Data.Entity.Core.Metadata.Edm.ValidationErrorEventArgs validationErrorEventArgs = new global::System.Data.Entity.Core.Metadata.Edm.ValidationErrorEventArgs(newError);
			this.OnValidationError(validationErrorEventArgs);
			errors.Add(validationErrorEventArgs.ValidationError);
		}

		// Token: 0x06003B8D RID: 15245 RVA: 0x000C39EB File Offset: 0x000C1BEB
		protected virtual global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Metadata.Edm.EdmItemError> CustomValidate(global::System.Data.Entity.Core.Metadata.Edm.MetadataItem item)
		{
			return null;
		}

		// Token: 0x06003B8E RID: 15246 RVA: 0x000C39F0 File Offset: 0x000C1BF0
		private void InternalValidate(global::System.Data.Entity.Core.Metadata.Edm.MetadataItem item, global::System.Collections.Generic.List<global::System.Data.Entity.Core.Metadata.Edm.EdmItemError> errors, global::System.Collections.Generic.HashSet<global::System.Data.Entity.Core.Metadata.Edm.MetadataItem> validatedItems)
		{
			if ((item.IsReadOnly && this.SkipReadOnlyItems) || validatedItems.Contains(item))
			{
				return;
			}
			validatedItems.Add(item);
			if (string.IsNullOrEmpty(item.Identity))
			{
				this.AddError(errors, new global::System.Data.Entity.Core.Metadata.Edm.EdmItemError(global::System.Data.Entity.Resources.Strings.Validator_EmptyIdentity));
			}
			switch (item.BuiltInTypeKind)
			{
			case global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.CollectionType:
				this.ValidateCollectionType((global::System.Data.Entity.Core.Metadata.Edm.CollectionType)item, errors, validatedItems);
				break;
			case global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.ComplexType:
				this.ValidateComplexType((global::System.Data.Entity.Core.Metadata.Edm.ComplexType)item, errors, validatedItems);
				break;
			case global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.EntityType:
				this.ValidateEntityType((global::System.Data.Entity.Core.Metadata.Edm.EntityType)item, errors, validatedItems);
				break;
			case global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.Facet:
				this.ValidateFacet((global::System.Data.Entity.Core.Metadata.Edm.Facet)item, errors, validatedItems);
				break;
			case global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.MetadataProperty:
				this.ValidateMetadataProperty((global::System.Data.Entity.Core.Metadata.Edm.MetadataProperty)item, errors, validatedItems);
				break;
			case global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.NavigationProperty:
				this.ValidateNavigationProperty((global::System.Data.Entity.Core.Metadata.Edm.NavigationProperty)item, errors, validatedItems);
				break;
			case global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.PrimitiveType:
				this.ValidatePrimitiveType((global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType)item, errors, validatedItems);
				break;
			case global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.EdmProperty:
				this.ValidateEdmProperty((global::System.Data.Entity.Core.Metadata.Edm.EdmProperty)item, errors, validatedItems);
				break;
			case global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.RefType:
				this.ValidateRefType((global::System.Data.Entity.Core.Metadata.Edm.RefType)item, errors, validatedItems);
				break;
			case global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.TypeUsage:
				this.ValidateTypeUsage((global::System.Data.Entity.Core.Metadata.Edm.TypeUsage)item, errors, validatedItems);
				break;
			}
			global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Metadata.Edm.EdmItemError> enumerable = this.CustomValidate(item);
			if (enumerable != null)
			{
				errors.AddRange(enumerable);
			}
		}

		// Token: 0x06003B8F RID: 15247 RVA: 0x000C3B90 File Offset: 0x000C1D90
		private void ValidateCollectionType(global::System.Data.Entity.Core.Metadata.Edm.CollectionType item, global::System.Collections.Generic.List<global::System.Data.Entity.Core.Metadata.Edm.EdmItemError> errors, global::System.Collections.Generic.HashSet<global::System.Data.Entity.Core.Metadata.Edm.MetadataItem> validatedItems)
		{
			this.ValidateEdmType(item, errors, validatedItems);
			if (item.BaseType != null)
			{
				this.AddError(errors, new global::System.Data.Entity.Core.Metadata.Edm.EdmItemError(global::System.Data.Entity.Resources.Strings.Validator_CollectionTypesCannotHaveBaseType));
			}
			if (item.TypeUsage == null)
			{
				this.AddError(errors, new global::System.Data.Entity.Core.Metadata.Edm.EdmItemError(global::System.Data.Entity.Resources.Strings.Validator_CollectionHasNoTypeUsage));
				return;
			}
			this.InternalValidate(item.TypeUsage, errors, validatedItems);
		}

		// Token: 0x06003B90 RID: 15248 RVA: 0x000C3BE7 File Offset: 0x000C1DE7
		private void ValidateComplexType(global::System.Data.Entity.Core.Metadata.Edm.ComplexType item, global::System.Collections.Generic.List<global::System.Data.Entity.Core.Metadata.Edm.EdmItemError> errors, global::System.Collections.Generic.HashSet<global::System.Data.Entity.Core.Metadata.Edm.MetadataItem> validatedItems)
		{
			this.ValidateStructuralType(item, errors, validatedItems);
		}

		// Token: 0x06003B91 RID: 15249 RVA: 0x000C3BF4 File Offset: 0x000C1DF4
		private void ValidateEdmType(global::System.Data.Entity.Core.Metadata.Edm.EdmType item, global::System.Collections.Generic.List<global::System.Data.Entity.Core.Metadata.Edm.EdmItemError> errors, global::System.Collections.Generic.HashSet<global::System.Data.Entity.Core.Metadata.Edm.MetadataItem> validatedItems)
		{
			this.ValidateItem(item, errors, validatedItems);
			if (string.IsNullOrEmpty(item.Name))
			{
				this.AddError(errors, new global::System.Data.Entity.Core.Metadata.Edm.EdmItemError(global::System.Data.Entity.Resources.Strings.Validator_TypeHasNoName));
			}
			if (item.NamespaceName == null || (item.DataSpace != global::System.Data.Entity.Core.Metadata.Edm.DataSpace.OSpace && string.Empty == item.NamespaceName))
			{
				this.AddError(errors, new global::System.Data.Entity.Core.Metadata.Edm.EdmItemError(global::System.Data.Entity.Resources.Strings.Validator_TypeHasNoNamespace));
			}
			if (item.BaseType != null)
			{
				this.InternalValidate(item.BaseType, errors, validatedItems);
			}
		}

		// Token: 0x06003B92 RID: 15250 RVA: 0x000C3C74 File Offset: 0x000C1E74
		private void ValidateEntityType(global::System.Data.Entity.Core.Metadata.Edm.EntityType item, global::System.Collections.Generic.List<global::System.Data.Entity.Core.Metadata.Edm.EdmItemError> errors, global::System.Collections.Generic.HashSet<global::System.Data.Entity.Core.Metadata.Edm.MetadataItem> validatedItems)
		{
			if (item.BaseType == null)
			{
				if (item.KeyMembers.Count < 1)
				{
					this.AddError(errors, new global::System.Data.Entity.Core.Metadata.Edm.EdmItemError(global::System.Data.Entity.Resources.Strings.Validator_NoKeyMembers(item.FullName)));
				}
				else
				{
					foreach (global::System.Data.Entity.Core.Metadata.Edm.EdmMember edmMember in item.KeyMembers)
					{
						global::System.Data.Entity.Core.Metadata.Edm.EdmProperty edmProperty = (global::System.Data.Entity.Core.Metadata.Edm.EdmProperty)edmMember;
						if (edmProperty.Nullable)
						{
							this.AddError(errors, new global::System.Data.Entity.Core.Metadata.Edm.EdmItemError(global::System.Data.Entity.Resources.Strings.Validator_NullableEntityKeyProperty(edmProperty.Name, item.FullName)));
						}
					}
				}
			}
			this.ValidateStructuralType(item, errors, validatedItems);
		}

		// Token: 0x06003B93 RID: 15251 RVA: 0x000C3D28 File Offset: 0x000C1F28
		private void ValidateFacet(global::System.Data.Entity.Core.Metadata.Edm.Facet item, global::System.Collections.Generic.List<global::System.Data.Entity.Core.Metadata.Edm.EdmItemError> errors, global::System.Collections.Generic.HashSet<global::System.Data.Entity.Core.Metadata.Edm.MetadataItem> validatedItems)
		{
			this.ValidateItem(item, errors, validatedItems);
			if (string.IsNullOrEmpty(item.Name))
			{
				this.AddError(errors, new global::System.Data.Entity.Core.Metadata.Edm.EdmItemError(global::System.Data.Entity.Resources.Strings.Validator_FacetHasNoName));
			}
			if (item.FacetType == null)
			{
				this.AddError(errors, new global::System.Data.Entity.Core.Metadata.Edm.EdmItemError(global::System.Data.Entity.Resources.Strings.Validator_FacetTypeIsNull));
				return;
			}
			this.InternalValidate(item.FacetType, errors, validatedItems);
		}

		// Token: 0x06003B94 RID: 15252 RVA: 0x000C3D84 File Offset: 0x000C1F84
		private void ValidateItem(global::System.Data.Entity.Core.Metadata.Edm.MetadataItem item, global::System.Collections.Generic.List<global::System.Data.Entity.Core.Metadata.Edm.EdmItemError> errors, global::System.Collections.Generic.HashSet<global::System.Data.Entity.Core.Metadata.Edm.MetadataItem> validatedItems)
		{
			if (item.RawMetadataProperties != null)
			{
				foreach (global::System.Data.Entity.Core.Metadata.Edm.MetadataProperty item2 in item.MetadataProperties)
				{
					this.InternalValidate(item2, errors, validatedItems);
				}
			}
		}

		// Token: 0x06003B95 RID: 15253 RVA: 0x000C3DE4 File Offset: 0x000C1FE4
		private void ValidateEdmMember(global::System.Data.Entity.Core.Metadata.Edm.EdmMember item, global::System.Collections.Generic.List<global::System.Data.Entity.Core.Metadata.Edm.EdmItemError> errors, global::System.Collections.Generic.HashSet<global::System.Data.Entity.Core.Metadata.Edm.MetadataItem> validatedItems)
		{
			this.ValidateItem(item, errors, validatedItems);
			if (string.IsNullOrEmpty(item.Name))
			{
				this.AddError(errors, new global::System.Data.Entity.Core.Metadata.Edm.EdmItemError(global::System.Data.Entity.Resources.Strings.Validator_MemberHasNoName));
			}
			if (item.DeclaringType == null)
			{
				this.AddError(errors, new global::System.Data.Entity.Core.Metadata.Edm.EdmItemError(global::System.Data.Entity.Resources.Strings.Validator_MemberHasNullDeclaringType));
			}
			else
			{
				this.InternalValidate(item.DeclaringType, errors, validatedItems);
			}
			if (item.TypeUsage == null)
			{
				this.AddError(errors, new global::System.Data.Entity.Core.Metadata.Edm.EdmItemError(global::System.Data.Entity.Resources.Strings.Validator_MemberHasNullTypeUsage));
				return;
			}
			this.InternalValidate(item.TypeUsage, errors, validatedItems);
		}

		// Token: 0x06003B96 RID: 15254 RVA: 0x000C3E6C File Offset: 0x000C206C
		private void ValidateMetadataProperty(global::System.Data.Entity.Core.Metadata.Edm.MetadataProperty item, global::System.Collections.Generic.List<global::System.Data.Entity.Core.Metadata.Edm.EdmItemError> errors, global::System.Collections.Generic.HashSet<global::System.Data.Entity.Core.Metadata.Edm.MetadataItem> validatedItems)
		{
			if (item.PropertyKind == global::System.Data.Entity.Core.Metadata.Edm.PropertyKind.Extended)
			{
				this.ValidateItem(item, errors, validatedItems);
				if (string.IsNullOrEmpty(item.Name))
				{
					this.AddError(errors, new global::System.Data.Entity.Core.Metadata.Edm.EdmItemError(global::System.Data.Entity.Resources.Strings.Validator_MetadataPropertyHasNoName));
				}
				if (item.TypeUsage == null)
				{
					this.AddError(errors, new global::System.Data.Entity.Core.Metadata.Edm.EdmItemError(global::System.Data.Entity.Resources.Strings.Validator_ItemAttributeHasNullTypeUsage));
					return;
				}
				this.InternalValidate(item.TypeUsage, errors, validatedItems);
			}
		}

		// Token: 0x06003B97 RID: 15255 RVA: 0x000C3ED1 File Offset: 0x000C20D1
		private void ValidateNavigationProperty(global::System.Data.Entity.Core.Metadata.Edm.NavigationProperty item, global::System.Collections.Generic.List<global::System.Data.Entity.Core.Metadata.Edm.EdmItemError> errors, global::System.Collections.Generic.HashSet<global::System.Data.Entity.Core.Metadata.Edm.MetadataItem> validatedItems)
		{
			this.ValidateEdmMember(item, errors, validatedItems);
		}

		// Token: 0x06003B98 RID: 15256 RVA: 0x000C3EDC File Offset: 0x000C20DC
		private void ValidatePrimitiveType(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType item, global::System.Collections.Generic.List<global::System.Data.Entity.Core.Metadata.Edm.EdmItemError> errors, global::System.Collections.Generic.HashSet<global::System.Data.Entity.Core.Metadata.Edm.MetadataItem> validatedItems)
		{
			this.ValidateSimpleType(item, errors, validatedItems);
		}

		// Token: 0x06003B99 RID: 15257 RVA: 0x000C3EE7 File Offset: 0x000C20E7
		private void ValidateEdmProperty(global::System.Data.Entity.Core.Metadata.Edm.EdmProperty item, global::System.Collections.Generic.List<global::System.Data.Entity.Core.Metadata.Edm.EdmItemError> errors, global::System.Collections.Generic.HashSet<global::System.Data.Entity.Core.Metadata.Edm.MetadataItem> validatedItems)
		{
			this.ValidateEdmMember(item, errors, validatedItems);
		}

		// Token: 0x06003B9A RID: 15258 RVA: 0x000C3EF4 File Offset: 0x000C20F4
		private void ValidateRefType(global::System.Data.Entity.Core.Metadata.Edm.RefType item, global::System.Collections.Generic.List<global::System.Data.Entity.Core.Metadata.Edm.EdmItemError> errors, global::System.Collections.Generic.HashSet<global::System.Data.Entity.Core.Metadata.Edm.MetadataItem> validatedItems)
		{
			this.ValidateEdmType(item, errors, validatedItems);
			if (item.BaseType != null)
			{
				this.AddError(errors, new global::System.Data.Entity.Core.Metadata.Edm.EdmItemError(global::System.Data.Entity.Resources.Strings.Validator_RefTypesCannotHaveBaseType));
			}
			if (item.ElementType == null)
			{
				this.AddError(errors, new global::System.Data.Entity.Core.Metadata.Edm.EdmItemError(global::System.Data.Entity.Resources.Strings.Validator_RefTypeHasNullEntityType));
				return;
			}
			this.InternalValidate(item.ElementType, errors, validatedItems);
		}

		// Token: 0x06003B9B RID: 15259 RVA: 0x000C3F4B File Offset: 0x000C214B
		private void ValidateSimpleType(global::System.Data.Entity.Core.Metadata.Edm.SimpleType item, global::System.Collections.Generic.List<global::System.Data.Entity.Core.Metadata.Edm.EdmItemError> errors, global::System.Collections.Generic.HashSet<global::System.Data.Entity.Core.Metadata.Edm.MetadataItem> validatedItems)
		{
			this.ValidateEdmType(item, errors, validatedItems);
		}

		// Token: 0x06003B9C RID: 15260 RVA: 0x000C3F58 File Offset: 0x000C2158
		private void ValidateStructuralType(global::System.Data.Entity.Core.Metadata.Edm.StructuralType item, global::System.Collections.Generic.List<global::System.Data.Entity.Core.Metadata.Edm.EdmItemError> errors, global::System.Collections.Generic.HashSet<global::System.Data.Entity.Core.Metadata.Edm.MetadataItem> validatedItems)
		{
			this.ValidateEdmType(item, errors, validatedItems);
			global::System.Collections.Generic.Dictionary<string, global::System.Data.Entity.Core.Metadata.Edm.EdmMember> dictionary = new global::System.Collections.Generic.Dictionary<string, global::System.Data.Entity.Core.Metadata.Edm.EdmMember>();
			foreach (global::System.Data.Entity.Core.Metadata.Edm.EdmMember edmMember in item.Members)
			{
				global::System.Data.Entity.Core.Metadata.Edm.EdmMember edmMember2 = null;
				if (dictionary.TryGetValue(edmMember.Name, out edmMember2))
				{
					this.AddError(errors, new global::System.Data.Entity.Core.Metadata.Edm.EdmItemError(global::System.Data.Entity.Resources.Strings.Validator_BaseTypeHasMemberOfSameName));
				}
				else
				{
					dictionary.Add(edmMember.Name, edmMember);
				}
				this.InternalValidate(edmMember, errors, validatedItems);
			}
		}

		// Token: 0x06003B9D RID: 15261 RVA: 0x000C3FF0 File Offset: 0x000C21F0
		private void ValidateTypeUsage(global::System.Data.Entity.Core.Metadata.Edm.TypeUsage item, global::System.Collections.Generic.List<global::System.Data.Entity.Core.Metadata.Edm.EdmItemError> errors, global::System.Collections.Generic.HashSet<global::System.Data.Entity.Core.Metadata.Edm.MetadataItem> validatedItems)
		{
			this.ValidateItem(item, errors, validatedItems);
			if (item.EdmType == null)
			{
				this.AddError(errors, new global::System.Data.Entity.Core.Metadata.Edm.EdmItemError(global::System.Data.Entity.Resources.Strings.Validator_TypeUsageHasNullEdmType));
			}
			else
			{
				this.InternalValidate(item.EdmType, errors, validatedItems);
			}
			foreach (global::System.Data.Entity.Core.Metadata.Edm.Facet item2 in item.Facets)
			{
				this.InternalValidate(item2, errors, validatedItems);
			}
		}
	}
}
