using System;
using System.ComponentModel;
using System.Data.Common;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Utilities;

namespace System.Data.Entity.Infrastructure.Interception
{
	// Token: 0x02000273 RID: 627
	public class BeginTransactionInterceptionContext : global::System.Data.Entity.Infrastructure.Interception.DbConnectionInterceptionContext<global::System.Data.Common.DbTransaction>
	{
		// Token: 0x06001F8B RID: 8075 RVA: 0x000590BF File Offset: 0x000572BF
		public BeginTransactionInterceptionContext()
		{
		}

		// Token: 0x06001F8C RID: 8076 RVA: 0x000590D0 File Offset: 0x000572D0
		public BeginTransactionInterceptionContext(global::System.Data.Entity.Infrastructure.Interception.DbInterceptionContext copyFrom) : base(copyFrom)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Infrastructure.Interception.DbInterceptionContext>(copyFrom, "copyFrom");
			global::System.Data.Entity.Infrastructure.Interception.BeginTransactionInterceptionContext beginTransactionInterceptionContext = copyFrom as global::System.Data.Entity.Infrastructure.Interception.BeginTransactionInterceptionContext;
			if (beginTransactionInterceptionContext != null)
			{
				this._isolationLevel = beginTransactionInterceptionContext._isolationLevel;
			}
		}

		// Token: 0x06001F8D RID: 8077 RVA: 0x0005910D File Offset: 0x0005730D
		public new global::System.Data.Entity.Infrastructure.Interception.BeginTransactionInterceptionContext AsAsync()
		{
			return (global::System.Data.Entity.Infrastructure.Interception.BeginTransactionInterceptionContext)base.AsAsync();
		}

		// Token: 0x170006E0 RID: 1760
		// (get) Token: 0x06001F8E RID: 8078 RVA: 0x0005911A File Offset: 0x0005731A
		public global::System.Data.IsolationLevel IsolationLevel
		{
			get
			{
				return this._isolationLevel;
			}
		}

		// Token: 0x06001F8F RID: 8079 RVA: 0x00059122 File Offset: 0x00057322
		public global::System.Data.Entity.Infrastructure.Interception.BeginTransactionInterceptionContext WithIsolationLevel(global::System.Data.IsolationLevel isolationLevel)
		{
			global::System.Data.Entity.Infrastructure.Interception.BeginTransactionInterceptionContext beginTransactionInterceptionContext = this.TypedClone();
			beginTransactionInterceptionContext._isolationLevel = isolationLevel;
			return beginTransactionInterceptionContext;
		}

		// Token: 0x06001F90 RID: 8080 RVA: 0x00059131 File Offset: 0x00057331
		private global::System.Data.Entity.Infrastructure.Interception.BeginTransactionInterceptionContext TypedClone()
		{
			return (global::System.Data.Entity.Infrastructure.Interception.BeginTransactionInterceptionContext)this.Clone();
		}

		// Token: 0x06001F91 RID: 8081 RVA: 0x0005913E File Offset: 0x0005733E
		protected override global::System.Data.Entity.Infrastructure.Interception.DbInterceptionContext Clone()
		{
			return new global::System.Data.Entity.Infrastructure.Interception.BeginTransactionInterceptionContext(this);
		}

		// Token: 0x06001F92 RID: 8082 RVA: 0x00059146 File Offset: 0x00057346
		public new global::System.Data.Entity.Infrastructure.Interception.BeginTransactionInterceptionContext WithDbContext(global::System.Data.Entity.DbContext context)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.DbContext>(context, "context");
			return (global::System.Data.Entity.Infrastructure.Interception.BeginTransactionInterceptionContext)base.WithDbContext(context);
		}

		// Token: 0x06001F93 RID: 8083 RVA: 0x00059160 File Offset: 0x00057360
		public new global::System.Data.Entity.Infrastructure.Interception.BeginTransactionInterceptionContext WithObjectContext(global::System.Data.Entity.Core.Objects.ObjectContext context)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Objects.ObjectContext>(context, "context");
			return (global::System.Data.Entity.Infrastructure.Interception.BeginTransactionInterceptionContext)base.WithObjectContext(context);
		}

		// Token: 0x06001F94 RID: 8084 RVA: 0x0005917A File Offset: 0x0005737A
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public override string ToString()
		{
			return base.ToString();
		}

		// Token: 0x06001F95 RID: 8085 RVA: 0x00059182 File Offset: 0x00057382
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public override bool Equals(object obj)
		{
			return base.Equals(obj);
		}

		// Token: 0x06001F96 RID: 8086 RVA: 0x0005918B File Offset: 0x0005738B
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		// Token: 0x06001F97 RID: 8087 RVA: 0x00059193 File Offset: 0x00057393
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public new global::System.Type GetType()
		{
			return base.GetType();
		}

		// Token: 0x04000B6B RID: 2923
		private global::System.Data.IsolationLevel _isolationLevel = global::System.Data.IsolationLevel.Unspecified;
	}
}
