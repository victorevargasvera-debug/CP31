using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations.Utilities;
using System.Data.Entity.Resources;
using System.Data.Entity.Utilities;
using System.Linq;
using System.Reflection;

namespace System.Data.Entity.Migrations.Infrastructure
{
	// Token: 0x020000D2 RID: 210
	internal class MigrationAssembly
	{
		// Token: 0x06001067 RID: 4199 RVA: 0x0002455A File Offset: 0x0002275A
		public static string CreateMigrationId(string migrationName)
		{
			return global::System.Data.Entity.Migrations.Utilities.UtcNowGenerator.UtcNowAsMigrationIdTimestamp() + "_" + migrationName;
		}

		// Token: 0x06001068 RID: 4200 RVA: 0x0002456C File Offset: 0x0002276C
		public static string CreateBootstrapMigrationId()
		{
			return new string('0', 15) + "_" + global::System.Data.Entity.Resources.Strings.BootstrapMigration;
		}

		// Token: 0x06001069 RID: 4201 RVA: 0x00024586 File Offset: 0x00022786
		protected MigrationAssembly()
		{
		}

		// Token: 0x0600106A RID: 4202 RVA: 0x00024590 File Offset: 0x00022790
		public MigrationAssembly(global::System.Reflection.Assembly migrationsAssembly, string migrationsNamespace)
		{
			this._migrations = (from t in migrationsAssembly.GetAccessibleTypes()
			where t.IsSubclassOf(typeof(global::System.Data.Entity.Migrations.DbMigration)) && typeof(global::System.Data.Entity.Migrations.Infrastructure.IMigrationMetadata).IsAssignableFrom(t) && t.GetPublicConstructor(new global::System.Type[0]) != null && !t.IsAbstract() && !t.IsGenericType() && t.Namespace == migrationsNamespace
			select (global::System.Data.Entity.Migrations.Infrastructure.IMigrationMetadata)global::System.Activator.CreateInstance(t) into mm
			where !string.IsNullOrWhiteSpace(mm.Id) && mm.Id.IsValidMigrationId()
			orderby mm.Id
			select mm).ToList<global::System.Data.Entity.Migrations.Infrastructure.IMigrationMetadata>();
		}

		// Token: 0x17000467 RID: 1127
		// (get) Token: 0x0600106B RID: 4203 RVA: 0x0002463E File Offset: 0x0002283E
		public virtual global::System.Collections.Generic.IEnumerable<string> MigrationIds
		{
			get
			{
				return (from t in this._migrations
				select t.Id).ToList<string>();
			}
		}

		// Token: 0x0600106C RID: 4204 RVA: 0x0002466F File Offset: 0x0002286F
		public virtual string UniquifyName(string migrationName)
		{
			return (from m in this._migrations
			select m.GetType().Name).Uniquify(migrationName);
		}

		// Token: 0x0600106D RID: 4205 RVA: 0x000246A4 File Offset: 0x000228A4
		public virtual global::System.Data.Entity.Migrations.DbMigration GetMigration(string migrationId)
		{
			global::System.Data.Entity.Migrations.DbMigration dbMigration = (global::System.Data.Entity.Migrations.DbMigration)this._migrations.SingleOrDefault((global::System.Data.Entity.Migrations.Infrastructure.IMigrationMetadata m) => m.Id.StartsWith(migrationId, global::System.StringComparison.Ordinal));
			if (dbMigration != null)
			{
				dbMigration.Reset();
			}
			return dbMigration;
		}

		// Token: 0x040008A5 RID: 2213
		private readonly global::System.Collections.Generic.IList<global::System.Data.Entity.Migrations.Infrastructure.IMigrationMetadata> _migrations;
	}
}
