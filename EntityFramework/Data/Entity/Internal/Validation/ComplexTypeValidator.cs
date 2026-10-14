using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;

namespace System.Data.Entity.Internal.Validation
{
	// Token: 0x02000130 RID: 304
	internal class ComplexTypeValidator : global::System.Data.Entity.Internal.Validation.TypeValidator
	{
		// Token: 0x060014AF RID: 5295 RVA: 0x0003516E File Offset: 0x0003336E
		public ComplexTypeValidator(global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Internal.Validation.PropertyValidator> propertyValidators, global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Internal.Validation.IValidator> typeLevelValidators) : base(propertyValidators, typeLevelValidators)
		{
		}

		// Token: 0x060014B0 RID: 5296 RVA: 0x00035178 File Offset: 0x00033378
		public new global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Validation.DbValidationError> Validate(global::System.Data.Entity.Internal.Validation.EntityValidationContext entityValidationContext, global::System.Data.Entity.Internal.InternalPropertyEntry property)
		{
			return base.Validate(entityValidationContext, property);
		}

		// Token: 0x060014B1 RID: 5297 RVA: 0x00035184 File Offset: 0x00033384
		protected override void ValidateProperties(global::System.Data.Entity.Internal.Validation.EntityValidationContext entityValidationContext, global::System.Data.Entity.Internal.InternalPropertyEntry parentProperty, global::System.Collections.Generic.List<global::System.Data.Entity.Validation.DbValidationError> validationErrors)
		{
			foreach (global::System.Data.Entity.Internal.Validation.PropertyValidator propertyValidator in base.PropertyValidators)
			{
				global::System.Data.Entity.Internal.InternalPropertyEntry property = parentProperty.Property(propertyValidator.PropertyName, null, false);
				validationErrors.AddRange(propertyValidator.Validate(entityValidationContext, property));
			}
		}
	}
}
