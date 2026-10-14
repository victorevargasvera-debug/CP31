using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity.Resources;
using System.Data.Entity.Utilities;
using System.Data.Entity.Validation;
using System.Linq;

namespace System.Data.Entity.Internal.Validation
{
	// Token: 0x02000138 RID: 312
	internal class ValidationAttributeValidator : global::System.Data.Entity.Internal.Validation.IValidator
	{
		// Token: 0x060014D0 RID: 5328 RVA: 0x00035A38 File Offset: 0x00033C38
		public ValidationAttributeValidator(global::System.ComponentModel.DataAnnotations.ValidationAttribute validationAttribute, global::System.ComponentModel.DataAnnotations.DisplayAttribute displayAttribute)
		{
			this._validationAttribute = validationAttribute;
			this._displayAttribute = displayAttribute;
		}

		// Token: 0x060014D1 RID: 5329 RVA: 0x00035A50 File Offset: 0x00033C50
		public virtual global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Validation.DbValidationError> Validate(global::System.Data.Entity.Internal.Validation.EntityValidationContext entityValidationContext, global::System.Data.Entity.Internal.InternalMemberEntry property)
		{
			if (!this.AttributeApplicable(entityValidationContext, property))
			{
				return global::System.Linq.Enumerable.Empty<global::System.Data.Entity.Validation.DbValidationError>();
			}
			global::System.ComponentModel.DataAnnotations.ValidationContext externalValidationContext = entityValidationContext.ExternalValidationContext;
			externalValidationContext.SetDisplayName(property, this._displayAttribute);
			object value = (property == null) ? entityValidationContext.InternalEntity.Entity : property.CurrentValue;
			global::System.ComponentModel.DataAnnotations.ValidationResult validationResult = null;
			try
			{
				validationResult = this._validationAttribute.GetValidationResult(value, externalValidationContext);
			}
			catch (global::System.Exception innerException)
			{
				throw new global::System.Data.Entity.Validation.DbUnexpectedValidationException(global::System.Data.Entity.Resources.Strings.DbUnexpectedValidationException_ValidationAttribute(externalValidationContext.DisplayName, this._validationAttribute.GetType()), innerException);
			}
			if (validationResult == global::System.ComponentModel.DataAnnotations.ValidationResult.Success)
			{
				return global::System.Linq.Enumerable.Empty<global::System.Data.Entity.Validation.DbValidationError>();
			}
			return global::System.Data.Entity.Internal.DbHelpers.SplitValidationResults(externalValidationContext.MemberName, new global::System.ComponentModel.DataAnnotations.ValidationResult[]
			{
				validationResult
			});
		}

		// Token: 0x060014D2 RID: 5330 RVA: 0x00035AFC File Offset: 0x00033CFC
		protected virtual bool AttributeApplicable(global::System.Data.Entity.Internal.Validation.EntityValidationContext entityValidationContext, global::System.Data.Entity.Internal.InternalMemberEntry property)
		{
			global::System.Data.Entity.Internal.InternalNavigationEntry internalNavigationEntry = property as global::System.Data.Entity.Internal.InternalNavigationEntry;
			return !(this._validationAttribute is global::System.ComponentModel.DataAnnotations.RequiredAttribute) || property == null || property.InternalEntityEntry == null || property.InternalEntityEntry.State == global::System.Data.Entity.EntityState.Added || property.InternalEntityEntry.State == global::System.Data.Entity.EntityState.Detached || internalNavigationEntry == null || internalNavigationEntry.IsLoaded;
		}

		// Token: 0x040009C1 RID: 2497
		private readonly global::System.ComponentModel.DataAnnotations.DisplayAttribute _displayAttribute;

		// Token: 0x040009C2 RID: 2498
		private readonly global::System.ComponentModel.DataAnnotations.ValidationAttribute _validationAttribute;
	}
}
