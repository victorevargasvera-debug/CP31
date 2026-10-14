using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity.Resources;
using System.Data.Entity.Utilities;
using System.Data.Entity.Validation;
using System.Linq;

namespace System.Data.Entity.Internal.Validation
{
	// Token: 0x02000137 RID: 311
	internal class ValidatableObjectValidator : global::System.Data.Entity.Internal.Validation.IValidator
	{
		// Token: 0x060014CE RID: 5326 RVA: 0x00035989 File Offset: 0x00033B89
		public ValidatableObjectValidator(global::System.ComponentModel.DataAnnotations.DisplayAttribute displayAttribute)
		{
			this._displayAttribute = displayAttribute;
		}

		// Token: 0x060014CF RID: 5327 RVA: 0x00035998 File Offset: 0x00033B98
		public virtual global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Validation.DbValidationError> Validate(global::System.Data.Entity.Internal.Validation.EntityValidationContext entityValidationContext, global::System.Data.Entity.Internal.InternalMemberEntry property)
		{
			if (property != null && property.CurrentValue == null)
			{
				return global::System.Linq.Enumerable.Empty<global::System.Data.Entity.Validation.DbValidationError>();
			}
			global::System.ComponentModel.DataAnnotations.ValidationContext externalValidationContext = entityValidationContext.ExternalValidationContext;
			externalValidationContext.SetDisplayName(property, this._displayAttribute);
			global::System.ComponentModel.DataAnnotations.IValidatableObject validatableObject = (global::System.ComponentModel.DataAnnotations.IValidatableObject)((property == null) ? entityValidationContext.InternalEntity.Entity : property.CurrentValue);
			global::System.Collections.Generic.IEnumerable<global::System.ComponentModel.DataAnnotations.ValidationResult> enumerable = null;
			try
			{
				enumerable = validatableObject.Validate(externalValidationContext);
			}
			catch (global::System.Exception innerException)
			{
				throw new global::System.Data.Entity.Validation.DbUnexpectedValidationException(global::System.Data.Entity.Resources.Strings.DbUnexpectedValidationException_IValidatableObject(externalValidationContext.DisplayName, global::System.Data.Entity.Internal.ObjectContextTypeCache.GetObjectType(validatableObject.GetType())), innerException);
			}
			return global::System.Data.Entity.Internal.DbHelpers.SplitValidationResults(externalValidationContext.MemberName, enumerable ?? global::System.Linq.Enumerable.Empty<global::System.ComponentModel.DataAnnotations.ValidationResult>());
		}

		// Token: 0x040009C0 RID: 2496
		private readonly global::System.ComponentModel.DataAnnotations.DisplayAttribute _displayAttribute;
	}
}
