using System;
using System.Data.Common;
using System.Data.Entity.Infrastructure;

namespace System.Data.Entity.Migrations.History
{
	// Token: 0x020000DB RID: 219
	public class HistoryContext : global::System.Data.Entity.DbContext, global::System.Data.Entity.Infrastructure.IDbModelCacheKeyProvider
	{
		// Token: 0x060010B7 RID: 4279 RVA: 0x000253DA File Offset: 0x000235DA
		internal HistoryContext()
		{
			this.InternalContext.InitializerDisabled = true;
		}

		// Token: 0x060010B8 RID: 4280 RVA: 0x000253EE File Offset: 0x000235EE
		public HistoryContext(global::System.Data.Common.DbConnection existingConnection, string defaultSchema) : base(existingConnection, false)
		{
			this._defaultSchema = defaultSchema;
			base.Configuration.ValidateOnSaveEnabled = false;
			this.InternalContext.InitializerDisabled = true;
		}

		// Token: 0x1700046C RID: 1132
		// (get) Token: 0x060010B9 RID: 4281 RVA: 0x00025417 File Offset: 0x00023617
		public virtual string CacheKey
		{
			get
			{
				return this._defaultSchema;
			}
		}

		// Token: 0x1700046D RID: 1133
		// (get) Token: 0x060010BA RID: 4282 RVA: 0x0002541F File Offset: 0x0002361F
		protected string DefaultSchema
		{
			get
			{
				return this._defaultSchema;
			}
		}

		// Token: 0x1700046E RID: 1134
		// (get) Token: 0x060010BB RID: 4283 RVA: 0x00025427 File Offset: 0x00023627
		// (set) Token: 0x060010BC RID: 4284 RVA: 0x0002542F File Offset: 0x0002362F
		public virtual global::System.Data.Entity.IDbSet<global::System.Data.Entity.Migrations.History.HistoryRow> History { get; set; }

		// Token: 0x060010BD RID: 4285 RVA: 0x00025438 File Offset: 0x00023638
		protected override void OnModelCreating(global::System.Data.Entity.DbModelBuilder modelBuilder)
		{
			modelBuilder.HasDefaultSchema(this._defaultSchema);
			modelBuilder.Entity<global::System.Data.Entity.Migrations.History.HistoryRow>().ToTable("__MigrationHistory");
			modelBuilder.Entity<global::System.Data.Entity.Migrations.History.HistoryRow>().HasKey((global::System.Data.Entity.Migrations.History.HistoryRow h) => new
			{
				h.MigrationId,
				h.ContextKey
			});
			modelBuilder.Entity<global::System.Data.Entity.Migrations.History.HistoryRow>().Property((global::System.Data.Entity.Migrations.History.HistoryRow h) => h.MigrationId).HasMaxLength(new int?(150)).IsRequired();
			modelBuilder.Entity<global::System.Data.Entity.Migrations.History.HistoryRow>().Property((global::System.Data.Entity.Migrations.History.HistoryRow h) => h.ContextKey).HasMaxLength(new int?(300)).IsRequired();
			modelBuilder.Entity<global::System.Data.Entity.Migrations.History.HistoryRow>().Property((global::System.Data.Entity.Migrations.History.HistoryRow h) => h.Model).IsRequired().IsMaxLength();
			modelBuilder.Entity<global::System.Data.Entity.Migrations.History.HistoryRow>().Property((global::System.Data.Entity.Migrations.History.HistoryRow h) => h.ProductVersion).HasMaxLength(new int?(32)).IsRequired();
		}

		// Token: 0x040008B0 RID: 2224
		public const string DefaultTableName = "__MigrationHistory";

		// Token: 0x040008B1 RID: 2225
		internal const int ContextKeyMaxLength = 300;

		// Token: 0x040008B2 RID: 2226
		internal const int MigrationIdMaxLength = 150;

		// Token: 0x040008B3 RID: 2227
		private readonly string _defaultSchema;

		// Token: 0x040008B4 RID: 2228
		internal static readonly global::System.Func<global::System.Data.Common.DbConnection, string, global::System.Data.Entity.Migrations.History.HistoryContext> DefaultFactory = (global::System.Data.Common.DbConnection e, string d) => new global::System.Data.Entity.Migrations.History.HistoryContext(e, d);
	}
}
