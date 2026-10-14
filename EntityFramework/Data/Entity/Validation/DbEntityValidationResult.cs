using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Internal;
using System.Data.Entity.Utilities;
using System.Linq;

namespace System.Data.Entity.Validation
{
	// Token: 0x0200006F RID: 111
	[global::System.Serializable]
	public class DbEntityValidationResult
	{
		// Token: 0x0600041F RID: 1055 RVA: 0x0000E787 File Offset: 0x0000C987
		public DbEntityValidationResult(global::System.Data.Entity.Infrastructure.DbEntityEntry entry, global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Validation.DbValidationError> validationErrors)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Infrastructure.DbEntityEntry>(entry, "entry");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Validation.DbValidationError>>(validationErrors, "validationErrors");
			this._entry = entry.InternalEntry;
			this._validationErrors = validationErrors.ToList<global::System.Data.Entity.Validation.DbValidationError>();
		}

		// Token: 0x06000420 RID: 1056 RVA: 0x0000E7BF File Offset: 0x0000C9BF
		internal DbEntityValidationResult(global::System.Data.Entity.Internal.InternalEntityEntry entry, global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Validation.DbValidationError> validationErrors)
		{
			this._entry = entry;
			this._validationErrors = validationErrors.ToList<global::System.Data.Entity.Validation.DbValidationError>();
		}

		// Token: 0x170000C9 RID: 201
		// (get) Token: 0x06000421 RID: 1057 RVA: 0x0000E7DA File Offset: 0x0000C9DA
		public global::System.Data.Entity.Infrastructure.DbEntityEntry Entry
		{
			get
			{
				if (this._entry == null)
				{
					return null;
				}
				return new global::System.Data.Entity.Infrastructure.DbEntityEntry(this._entry);
			}
		}

		// Token: 0x170000CA RID: 202
		// (get) Token: 0x06000422 RID: 1058 RVA: 0x0000E7F1 File Offset: 0x0000C9F1
		public global::System.Collections.Generic.ICollection<global::System.Data.Entity.Validation.DbValidationError> ValidationErrors
		{
			get
			{
				return this._validationErrors;
			}
		}

		// Token: 0x170000CB RID: 203
		// (get) Token: 0x06000423 RID: 1059 RVA: 0x0000E7F9 File Offset: 0x0000C9F9
		public bool IsValid
		{
			get
			{
				return !this._validationErrors.Any<global::System.Data.Entity.Validation.DbValidationError>();
			}
		}

		// Token: 0x0400010E RID: 270
		[global::System.NonSerialized]
		private readonly global::System.Data.Entity.Internal.InternalEntityEntry _entry;

		// Token: 0x0400010F RID: 271
		private readonly global::System.Collections.Generic.List<global::System.Data.Entity.Validation.DbValidationError> _validationErrors;
	}
}
