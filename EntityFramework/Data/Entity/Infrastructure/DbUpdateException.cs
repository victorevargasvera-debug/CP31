using System;
using System.Collections.Generic;
using System.Data.Entity.Core;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Internal;
using System.Data.Entity.Resources;
using System.Linq;
using System.Runtime.Serialization;

namespace System.Data.Entity.Infrastructure
{
	// Token: 0x0200023A RID: 570
	[global::System.Serializable]
	public class DbUpdateException : global::System.Data.DataException
	{
		// Token: 0x06001E1F RID: 7711 RVA: 0x000532F7 File Offset: 0x000514F7
		internal DbUpdateException(global::System.Data.Entity.Internal.InternalContext internalContext, global::System.Data.Entity.Core.UpdateException innerException, bool involvesIndependentAssociations) : base(involvesIndependentAssociations ? global::System.Data.Entity.Resources.Strings.DbContext_IndependentAssociationUpdateException : innerException.Message, innerException)
		{
			this._internalContext = internalContext;
			this._involvesIndependentAssociations = involvesIndependentAssociations;
		}

		// Token: 0x170006B8 RID: 1720
		// (get) Token: 0x06001E20 RID: 7712 RVA: 0x00053320 File Offset: 0x00051520
		public global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Infrastructure.DbEntityEntry> Entries
		{
			get
			{
				global::System.Data.Entity.Core.UpdateException ex = base.InnerException as global::System.Data.Entity.Core.UpdateException;
				if (this._involvesIndependentAssociations || this._internalContext == null || ex == null || ex.StateEntries == null)
				{
					return global::System.Linq.Enumerable.Empty<global::System.Data.Entity.Infrastructure.DbEntityEntry>();
				}
				return from e in ex.StateEntries
				select new global::System.Data.Entity.Infrastructure.DbEntityEntry(new global::System.Data.Entity.Internal.InternalEntityEntry(this._internalContext, new global::System.Data.Entity.Internal.StateEntryAdapter(e)));
			}
		}

		// Token: 0x06001E21 RID: 7713 RVA: 0x00053371 File Offset: 0x00051571
		public DbUpdateException()
		{
		}

		// Token: 0x06001E22 RID: 7714 RVA: 0x00053379 File Offset: 0x00051579
		public DbUpdateException(string message) : base(message)
		{
		}

		// Token: 0x06001E23 RID: 7715 RVA: 0x00053382 File Offset: 0x00051582
		public DbUpdateException(string message, global::System.Exception innerException) : base(message, innerException)
		{
		}

		// Token: 0x06001E24 RID: 7716 RVA: 0x0005338C File Offset: 0x0005158C
		protected DbUpdateException(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
			this._involvesIndependentAssociations = info.GetBoolean("InvolvesIndependentAssociations");
		}

		// Token: 0x06001E25 RID: 7717 RVA: 0x000533A7 File Offset: 0x000515A7
		public override void GetObjectData(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			base.GetObjectData(info, context);
			info.AddValue("InvolvesIndependentAssociations", this._involvesIndependentAssociations);
		}

		// Token: 0x04000B2A RID: 2858
		[global::System.NonSerialized]
		private readonly global::System.Data.Entity.Internal.InternalContext _internalContext;

		// Token: 0x04000B2B RID: 2859
		private readonly bool _involvesIndependentAssociations;
	}
}
