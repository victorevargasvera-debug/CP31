using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Internal.Validation;
using System.Data.Entity.Validation;
using System.Linq;

namespace System.Data.Entity.Internal
{
	// Token: 0x02000107 RID: 263
	internal abstract class InternalMemberEntry
	{
		// Token: 0x060012D2 RID: 4818 RVA: 0x0003087D File Offset: 0x0002EA7D
		protected InternalMemberEntry(global::System.Data.Entity.Internal.InternalEntityEntry internalEntityEntry, global::System.Data.Entity.Internal.MemberEntryMetadata memberMetadata)
		{
			this._internalEntityEntry = internalEntityEntry;
			this._memberMetadata = memberMetadata;
		}

		// Token: 0x170004C2 RID: 1218
		// (get) Token: 0x060012D3 RID: 4819 RVA: 0x00030893 File Offset: 0x0002EA93
		public virtual string Name
		{
			get
			{
				return this._memberMetadata.MemberName;
			}
		}

		// Token: 0x170004C3 RID: 1219
		// (get) Token: 0x060012D4 RID: 4820
		// (set) Token: 0x060012D5 RID: 4821
		public abstract object CurrentValue { get; set; }

		// Token: 0x170004C4 RID: 1220
		// (get) Token: 0x060012D6 RID: 4822 RVA: 0x000308A0 File Offset: 0x0002EAA0
		public virtual global::System.Data.Entity.Internal.InternalEntityEntry InternalEntityEntry
		{
			get
			{
				return this._internalEntityEntry;
			}
		}

		// Token: 0x170004C5 RID: 1221
		// (get) Token: 0x060012D7 RID: 4823 RVA: 0x000308A8 File Offset: 0x0002EAA8
		public virtual global::System.Data.Entity.Internal.MemberEntryMetadata EntryMetadata
		{
			get
			{
				return this._memberMetadata;
			}
		}

		// Token: 0x060012D8 RID: 4824 RVA: 0x000308B0 File Offset: 0x0002EAB0
		public virtual global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Validation.DbValidationError> GetValidationErrors()
		{
			global::System.Data.Entity.Internal.Validation.ValidationProvider validationProvider = this.InternalEntityEntry.InternalContext.ValidationProvider;
			global::System.Data.Entity.Internal.Validation.PropertyValidator propertyValidator = validationProvider.GetPropertyValidator(this._internalEntityEntry, this);
			if (propertyValidator == null)
			{
				return global::System.Linq.Enumerable.Empty<global::System.Data.Entity.Validation.DbValidationError>();
			}
			return propertyValidator.Validate(validationProvider.GetEntityValidationContext(this._internalEntityEntry, null), this);
		}

		// Token: 0x060012D9 RID: 4825
		public abstract global::System.Data.Entity.Infrastructure.DbMemberEntry CreateDbMemberEntry();

		// Token: 0x060012DA RID: 4826
		public abstract global::System.Data.Entity.Infrastructure.DbMemberEntry<TEntity, TProperty> CreateDbMemberEntry<TEntity, TProperty>() where TEntity : class;

		// Token: 0x04000931 RID: 2353
		private readonly global::System.Data.Entity.Internal.InternalEntityEntry _internalEntityEntry;

		// Token: 0x04000932 RID: 2354
		private readonly global::System.Data.Entity.Internal.MemberEntryMetadata _memberMetadata;
	}
}
