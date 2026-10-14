using System;
using System.ComponentModel;
using System.Data.Entity.Internal;

namespace System.Data.Entity.Infrastructure
{
	// Token: 0x02000237 RID: 567
	public class DbSqlQuery : global::System.Data.Entity.Infrastructure.DbRawSqlQuery
	{
		// Token: 0x06001E0A RID: 7690 RVA: 0x000531F1 File Offset: 0x000513F1
		internal DbSqlQuery(global::System.Data.Entity.Internal.InternalSqlQuery internalQuery) : base(internalQuery)
		{
		}

		// Token: 0x06001E0B RID: 7691 RVA: 0x000531FA File Offset: 0x000513FA
		protected DbSqlQuery() : this(null)
		{
		}

		// Token: 0x06001E0C RID: 7692 RVA: 0x00053203 File Offset: 0x00051403
		public virtual global::System.Data.Entity.Infrastructure.DbSqlQuery AsNoTracking()
		{
			if (base.InternalQuery != null)
			{
				return new global::System.Data.Entity.Infrastructure.DbSqlQuery(base.InternalQuery.AsNoTracking());
			}
			return this;
		}

		// Token: 0x06001E0D RID: 7693 RVA: 0x0005321F File Offset: 0x0005141F
		[global::System.Obsolete("Queries are now streaming by default unless a retrying ExecutionStrategy is used. Calling this method will have no effect.")]
		public new virtual global::System.Data.Entity.Infrastructure.DbSqlQuery AsStreaming()
		{
			if (base.InternalQuery != null)
			{
				return new global::System.Data.Entity.Infrastructure.DbSqlQuery(base.InternalQuery.AsStreaming());
			}
			return this;
		}

		// Token: 0x06001E0E RID: 7694 RVA: 0x0005323B File Offset: 0x0005143B
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public override string ToString()
		{
			return base.ToString();
		}

		// Token: 0x06001E0F RID: 7695 RVA: 0x00053243 File Offset: 0x00051443
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public override bool Equals(object obj)
		{
			return base.Equals(obj);
		}

		// Token: 0x06001E10 RID: 7696 RVA: 0x0005324C File Offset: 0x0005144C
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		// Token: 0x06001E11 RID: 7697 RVA: 0x00053254 File Offset: 0x00051454
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public new global::System.Type GetType()
		{
			return base.GetType();
		}
	}
}
