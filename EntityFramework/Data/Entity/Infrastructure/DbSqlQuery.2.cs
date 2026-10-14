using System;
using System.ComponentModel;
using System.Data.Entity.Internal;

namespace System.Data.Entity.Infrastructure
{
	// Token: 0x02000238 RID: 568
	public class DbSqlQuery<TEntity> : global::System.Data.Entity.Infrastructure.DbRawSqlQuery<TEntity> where TEntity : class
	{
		// Token: 0x06001E12 RID: 7698 RVA: 0x0005325C File Offset: 0x0005145C
		internal DbSqlQuery(global::System.Data.Entity.Internal.InternalSqlQuery internalQuery) : base(internalQuery)
		{
		}

		// Token: 0x06001E13 RID: 7699 RVA: 0x00053265 File Offset: 0x00051465
		protected DbSqlQuery() : this(null)
		{
		}

		// Token: 0x06001E14 RID: 7700 RVA: 0x0005326E File Offset: 0x0005146E
		public virtual global::System.Data.Entity.Infrastructure.DbSqlQuery<TEntity> AsNoTracking()
		{
			if (base.InternalQuery != null)
			{
				return new global::System.Data.Entity.Infrastructure.DbSqlQuery<TEntity>(base.InternalQuery.AsNoTracking());
			}
			return this;
		}

		// Token: 0x06001E15 RID: 7701 RVA: 0x0005328A File Offset: 0x0005148A
		[global::System.Obsolete("Queries are now streaming by default unless a retrying ExecutionStrategy is used. Calling this method will have no effect.")]
		public new virtual global::System.Data.Entity.Infrastructure.DbSqlQuery<TEntity> AsStreaming()
		{
			if (base.InternalQuery != null)
			{
				return new global::System.Data.Entity.Infrastructure.DbSqlQuery<TEntity>(base.InternalQuery.AsStreaming());
			}
			return this;
		}

		// Token: 0x06001E16 RID: 7702 RVA: 0x000532A6 File Offset: 0x000514A6
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public override string ToString()
		{
			return base.ToString();
		}

		// Token: 0x06001E17 RID: 7703 RVA: 0x000532AE File Offset: 0x000514AE
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public override bool Equals(object obj)
		{
			return base.Equals(obj);
		}

		// Token: 0x06001E18 RID: 7704 RVA: 0x000532B7 File Offset: 0x000514B7
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		// Token: 0x06001E19 RID: 7705 RVA: 0x000532BF File Offset: 0x000514BF
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public new global::System.Type GetType()
		{
			return base.GetType();
		}
	}
}
