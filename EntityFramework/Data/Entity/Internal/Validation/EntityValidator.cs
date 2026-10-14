using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;

namespace System.Data.Entity.Internal.Validation
{
	// Token: 0x02000132 RID: 306
	internal class EntityValidator : global::System.Data.Entity.Internal.Validation.TypeValidator
	{
		// Token: 0x060014B6 RID: 5302 RVA: 0x00035217 File Offset: 0x00033417
		public EntityValidator(global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Internal.Validation.PropertyValidator> propertyValidators, global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Internal.Validation.IValidator> typeLevelValidators) : base(propertyValidators, typeLevelValidators)
		{
		}

		// Token: 0x060014B7 RID: 5303 RVA: 0x00035224 File Offset: 0x00033424
		public global::System.Data.Entity.Validation.DbEntityValidationResult Validate(global::System.Data.Entity.Internal.Validation.EntityValidationContext entityValidationContext)
		{
			global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Validation.DbValidationError> validationErrors = base.Validate(entityValidationContext, null);
			return new global::System.Data.Entity.Validation.DbEntityValidationResult(entityValidationContext.InternalEntity, validationErrors);
		}

		// Token: 0x060014B8 RID: 5304 RVA: 0x00035248 File Offset: 0x00033448
		protected override void ValidateProperties(global::System.Data.Entity.Internal.Validation.EntityValidationContext entityValidationContext, global::System.Data.Entity.Internal.InternalPropertyEntry parentProperty, global::System.Collections.Generic.List<global::System.Data.Entity.Validation.DbValidationError> validationErrors)
		{
			global::System.Data.Entity.Internal.InternalEntityEntry internalEntity = entityValidationContext.InternalEntity;
			foreach (global::System.Data.Entity.Internal.Validation.PropertyValidator propertyValidator in base.PropertyValidators)
			{
				validationErrors.AddRange(propertyValidator.Validate(entityValidationContext, internalEntity.Member(propertyValidator.PropertyName, null)));
			}
		}
	}
}
