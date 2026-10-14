using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;

namespace System.Data.Entity.Internal.Validation
{
	// Token: 0x0200012F RID: 303
	internal class ComplexPropertyValidator : global::System.Data.Entity.Internal.Validation.PropertyValidator
	{
		// Token: 0x17000564 RID: 1380
		// (get) Token: 0x060014AC RID: 5292 RVA: 0x00035102 File Offset: 0x00033302
		public global::System.Data.Entity.Internal.Validation.ComplexTypeValidator ComplexTypeValidator
		{
			get
			{
				return this._complexTypeValidator;
			}
		}

		// Token: 0x060014AD RID: 5293 RVA: 0x0003510A File Offset: 0x0003330A
		public ComplexPropertyValidator(string propertyName, global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Internal.Validation.IValidator> propertyValidators, global::System.Data.Entity.Internal.Validation.ComplexTypeValidator complexTypeValidator) : base(propertyName, propertyValidators)
		{
			this._complexTypeValidator = complexTypeValidator;
		}

		// Token: 0x060014AE RID: 5294 RVA: 0x0003511C File Offset: 0x0003331C
		public override global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Validation.DbValidationError> Validate(global::System.Data.Entity.Internal.Validation.EntityValidationContext entityValidationContext, global::System.Data.Entity.Internal.InternalMemberEntry property)
		{
			global::System.Collections.Generic.List<global::System.Data.Entity.Validation.DbValidationError> list = new global::System.Collections.Generic.List<global::System.Data.Entity.Validation.DbValidationError>();
			list.AddRange(base.Validate(entityValidationContext, property));
			if (!list.Any<global::System.Data.Entity.Validation.DbValidationError>() && property.CurrentValue != null && this._complexTypeValidator != null)
			{
				list.AddRange(this._complexTypeValidator.Validate(entityValidationContext, (global::System.Data.Entity.Internal.InternalPropertyEntry)property));
			}
			return list;
		}

		// Token: 0x040009B8 RID: 2488
		private readonly global::System.Data.Entity.Internal.Validation.ComplexTypeValidator _complexTypeValidator;
	}
}
