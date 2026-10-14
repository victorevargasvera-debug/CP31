using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration.Utilities;

namespace System.Data.Entity.Internal.Validation
{
	// Token: 0x02000139 RID: 313
	internal class ValidationProvider
	{
		// Token: 0x060014D3 RID: 5331 RVA: 0x00035B52 File Offset: 0x00033D52
		public ValidationProvider(global::System.Data.Entity.Internal.Validation.EntityValidatorBuilder builder = null, global::System.Data.Entity.ModelConfiguration.Utilities.AttributeProvider attributeProvider = null)
		{
			this._entityValidators = new global::System.Collections.Generic.Dictionary<global::System.Type, global::System.Data.Entity.Internal.Validation.EntityValidator>();
			this._entityValidatorBuilder = (builder ?? new global::System.Data.Entity.Internal.Validation.EntityValidatorBuilder(attributeProvider ?? new global::System.Data.Entity.ModelConfiguration.Utilities.AttributeProvider()));
		}

		// Token: 0x060014D4 RID: 5332 RVA: 0x00035B80 File Offset: 0x00033D80
		public virtual global::System.Data.Entity.Internal.Validation.EntityValidator GetEntityValidator(global::System.Data.Entity.Internal.InternalEntityEntry entityEntry)
		{
			global::System.Type entityType = entityEntry.EntityType;
			global::System.Data.Entity.Internal.Validation.EntityValidator entityValidator = null;
			if (this._entityValidators.TryGetValue(entityType, out entityValidator))
			{
				return entityValidator;
			}
			entityValidator = this._entityValidatorBuilder.BuildEntityValidator(entityEntry);
			this._entityValidators[entityType] = entityValidator;
			return entityValidator;
		}

		// Token: 0x060014D5 RID: 5333 RVA: 0x00035BC4 File Offset: 0x00033DC4
		public virtual global::System.Data.Entity.Internal.Validation.PropertyValidator GetPropertyValidator(global::System.Data.Entity.Internal.InternalEntityEntry owningEntity, global::System.Data.Entity.Internal.InternalMemberEntry property)
		{
			global::System.Data.Entity.Internal.Validation.EntityValidator entityValidator = this.GetEntityValidator(owningEntity);
			if (entityValidator == null)
			{
				return null;
			}
			return this.GetValidatorForProperty(entityValidator, property);
		}

		// Token: 0x060014D6 RID: 5334 RVA: 0x00035BE8 File Offset: 0x00033DE8
		protected virtual global::System.Data.Entity.Internal.Validation.PropertyValidator GetValidatorForProperty(global::System.Data.Entity.Internal.Validation.EntityValidator entityValidator, global::System.Data.Entity.Internal.InternalMemberEntry memberEntry)
		{
			global::System.Data.Entity.Internal.InternalNestedPropertyEntry internalNestedPropertyEntry = memberEntry as global::System.Data.Entity.Internal.InternalNestedPropertyEntry;
			if (internalNestedPropertyEntry == null)
			{
				return entityValidator.GetPropertyValidator(memberEntry.Name);
			}
			global::System.Data.Entity.Internal.Validation.ComplexPropertyValidator complexPropertyValidator = this.GetValidatorForProperty(entityValidator, internalNestedPropertyEntry.ParentPropertyEntry) as global::System.Data.Entity.Internal.Validation.ComplexPropertyValidator;
			if (complexPropertyValidator == null || complexPropertyValidator.ComplexTypeValidator == null)
			{
				return null;
			}
			return complexPropertyValidator.ComplexTypeValidator.GetPropertyValidator(memberEntry.Name);
		}

		// Token: 0x060014D7 RID: 5335 RVA: 0x00035C3D File Offset: 0x00033E3D
		public virtual global::System.Data.Entity.Internal.Validation.EntityValidationContext GetEntityValidationContext(global::System.Data.Entity.Internal.InternalEntityEntry entityEntry, global::System.Collections.Generic.IDictionary<object, object> items)
		{
			return new global::System.Data.Entity.Internal.Validation.EntityValidationContext(entityEntry, new global::System.ComponentModel.DataAnnotations.ValidationContext(entityEntry.Entity, null, items));
		}

		// Token: 0x040009C3 RID: 2499
		private readonly global::System.Collections.Generic.Dictionary<global::System.Type, global::System.Data.Entity.Internal.Validation.EntityValidator> _entityValidators;

		// Token: 0x040009C4 RID: 2500
		private readonly global::System.Data.Entity.Internal.Validation.EntityValidatorBuilder _entityValidatorBuilder;
	}
}
