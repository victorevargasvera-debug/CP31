using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;

namespace System.Data.Entity.Internal.Validation
{
	// Token: 0x02000136 RID: 310
	internal abstract class TypeValidator
	{
		// Token: 0x060014C8 RID: 5320 RVA: 0x000358C4 File Offset: 0x00033AC4
		public TypeValidator(global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Internal.Validation.PropertyValidator> propertyValidators, global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Internal.Validation.IValidator> typeLevelValidators)
		{
			this._typeLevelValidators = typeLevelValidators;
			this._propertyValidators = propertyValidators;
		}

		// Token: 0x17000569 RID: 1385
		// (get) Token: 0x060014C9 RID: 5321 RVA: 0x000358DA File Offset: 0x00033ADA
		public global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Internal.Validation.IValidator> TypeLevelValidators
		{
			get
			{
				return this._typeLevelValidators;
			}
		}

		// Token: 0x1700056A RID: 1386
		// (get) Token: 0x060014CA RID: 5322 RVA: 0x000358E2 File Offset: 0x00033AE2
		public global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Internal.Validation.PropertyValidator> PropertyValidators
		{
			get
			{
				return this._propertyValidators;
			}
		}

		// Token: 0x060014CB RID: 5323 RVA: 0x000358EC File Offset: 0x00033AEC
		protected global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Validation.DbValidationError> Validate(global::System.Data.Entity.Internal.Validation.EntityValidationContext entityValidationContext, global::System.Data.Entity.Internal.InternalPropertyEntry property)
		{
			global::System.Collections.Generic.List<global::System.Data.Entity.Validation.DbValidationError> list = new global::System.Collections.Generic.List<global::System.Data.Entity.Validation.DbValidationError>();
			this.ValidateProperties(entityValidationContext, property, list);
			if (!list.Any<global::System.Data.Entity.Validation.DbValidationError>())
			{
				foreach (global::System.Data.Entity.Internal.Validation.IValidator validator in this._typeLevelValidators)
				{
					list.AddRange(validator.Validate(entityValidationContext, property));
				}
			}
			return list;
		}

		// Token: 0x060014CC RID: 5324
		protected abstract void ValidateProperties(global::System.Data.Entity.Internal.Validation.EntityValidationContext entityValidationContext, global::System.Data.Entity.Internal.InternalPropertyEntry parentProperty, global::System.Collections.Generic.List<global::System.Data.Entity.Validation.DbValidationError> validationErrors);

		// Token: 0x060014CD RID: 5325 RVA: 0x00035958 File Offset: 0x00033B58
		public global::System.Data.Entity.Internal.Validation.PropertyValidator GetPropertyValidator(string name)
		{
			return this._propertyValidators.SingleOrDefault((global::System.Data.Entity.Internal.Validation.PropertyValidator v) => v.PropertyName == name);
		}

		// Token: 0x040009BE RID: 2494
		private readonly global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Internal.Validation.IValidator> _typeLevelValidators;

		// Token: 0x040009BF RID: 2495
		private readonly global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Internal.Validation.PropertyValidator> _propertyValidators;
	}
}
