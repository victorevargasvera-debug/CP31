using System;
using System.Data.Common;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.ModelConfiguration.Configuration;

namespace System.Data.Entity.Internal
{
	// Token: 0x020000FD RID: 253
	internal class EdmMetadataContext : global::System.Data.Entity.DbContext
	{
		// Token: 0x06001276 RID: 4726 RVA: 0x0002F6C3 File Offset: 0x0002D8C3
		static EdmMetadataContext()
		{
			global::System.Data.Entity.Database.SetInitializer<global::System.Data.Entity.Internal.EdmMetadataContext>(null);
		}

		// Token: 0x06001277 RID: 4727 RVA: 0x0002F6CB File Offset: 0x0002D8CB
		public EdmMetadataContext(global::System.Data.Common.DbConnection existingConnection) : base(existingConnection, false)
		{
		}

		// Token: 0x170004A5 RID: 1189
		// (get) Token: 0x06001278 RID: 4728 RVA: 0x0002F6D5 File Offset: 0x0002D8D5
		// (set) Token: 0x06001279 RID: 4729 RVA: 0x0002F6DD File Offset: 0x0002D8DD
		public virtual global::System.Data.Entity.IDbSet<global::System.Data.Entity.Infrastructure.EdmMetadata> Metadata { get; set; }

		// Token: 0x0600127A RID: 4730 RVA: 0x0002F6E6 File Offset: 0x0002D8E6
		protected override void OnModelCreating(global::System.Data.Entity.DbModelBuilder modelBuilder)
		{
			global::System.Data.Entity.Internal.EdmMetadataContext.ConfigureEdmMetadata(modelBuilder.ModelConfiguration);
		}

		// Token: 0x0600127B RID: 4731 RVA: 0x0002F6F3 File Offset: 0x0002D8F3
		public static void ConfigureEdmMetadata(global::System.Data.Entity.ModelConfiguration.Configuration.ModelConfiguration modelConfiguration)
		{
			modelConfiguration.Entity(typeof(global::System.Data.Entity.Infrastructure.EdmMetadata)).ToTable("EdmMetadata");
		}

		// Token: 0x0400091D RID: 2333
		public const string TableName = "EdmMetadata";
	}
}
