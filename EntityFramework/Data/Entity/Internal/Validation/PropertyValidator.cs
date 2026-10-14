using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;

namespace System.Data.Entity.Internal.Validation
{
	// Token: 0x02000135 RID: 309
	internal class PropertyValidator
	{
		// Token: 0x060014C4 RID: 5316 RVA: 0x00035840 File Offset: 0x00033A40
		public PropertyValidator(string propertyName, global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Internal.Validation.IValidator> propertyValidators)
		{
			this._propertyValidators = propertyValidators;
			this._propertyName = propertyName;
		}

		// Token: 0x17000567 RID: 1383
		// (get) Token: 0x060014C5 RID: 5317 RVA: 0x00035856 File Offset: 0x00033A56
		public global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Internal.Validation.IValidator> PropertyAttributeValidators
		{
			get
			{
				return this._propertyValidators;
			}
		}

		// Token: 0x17000568 RID: 1384
		// (get) Token: 0x060014C6 RID: 5318 RVA: 0x0003585E File Offset: 0x00033A5E
		public string PropertyName
		{
			get
			{
				return this._propertyName;
			}
		}

		// Token: 0x060014C7 RID: 5319 RVA: 0x00035868 File Offset: 0x00033A68
		public virtual global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Validation.DbValidationError> Validate(global::System.Data.Entity.Internal.Validation.EntityValidationContext entityValidationContext, global::System.Data.Entity.Internal.InternalMemberEntry property)
		{
			global::System.Collections.Generic.List<global::System.Data.Entity.Validation.DbValidationError> list = new global::System.Collections.Generic.List<global::System.Data.Entity.Validation.DbValidationError>();
			foreach (global::System.Data.Entity.Internal.Validation.IValidator validator in this._propertyValidators)
			{
				list.AddRange(validator.Validate(entityValidationContext, property));
			}
			return list;
		}

		// Token: 0x040009BC RID: 2492
		private readonly global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Internal.Validation.IValidator> _propertyValidators;

		// Token: 0x040009BD RID: 2493
		private readonly string _propertyName;
	}
}
