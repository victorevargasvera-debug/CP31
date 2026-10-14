using System;
using System.Configuration;

namespace System.Data.Entity.Internal.ConfigFile
{
	// Token: 0x0200014A RID: 330
	internal class ContextElement : global::System.Configuration.ConfigurationElement
	{
		// Token: 0x1700058C RID: 1420
		// (get) Token: 0x06001581 RID: 5505 RVA: 0x000373C1 File Offset: 0x000355C1
		// (set) Token: 0x06001582 RID: 5506 RVA: 0x000373D3 File Offset: 0x000355D3
		[global::System.Configuration.ConfigurationProperty("type", IsRequired = true)]
		public virtual string ContextTypeName
		{
			get
			{
				return (string)base["type"];
			}
			set
			{
				base["type"] = value;
			}
		}

		// Token: 0x1700058D RID: 1421
		// (get) Token: 0x06001583 RID: 5507 RVA: 0x000373E1 File Offset: 0x000355E1
		// (set) Token: 0x06001584 RID: 5508 RVA: 0x000373F3 File Offset: 0x000355F3
		[global::System.Configuration.ConfigurationProperty("commandTimeout")]
		public virtual int? CommandTimeout
		{
			get
			{
				return (int?)base["commandTimeout"];
			}
			set
			{
				base["commandTimeout"] = value;
			}
		}

		// Token: 0x1700058E RID: 1422
		// (get) Token: 0x06001585 RID: 5509 RVA: 0x00037406 File Offset: 0x00035606
		// (set) Token: 0x06001586 RID: 5510 RVA: 0x00037418 File Offset: 0x00035618
		[global::System.Configuration.ConfigurationProperty("disableDatabaseInitialization", DefaultValue = false)]
		public virtual bool IsDatabaseInitializationDisabled
		{
			get
			{
				return (bool)base["disableDatabaseInitialization"];
			}
			set
			{
				base["disableDatabaseInitialization"] = value;
			}
		}

		// Token: 0x1700058F RID: 1423
		// (get) Token: 0x06001587 RID: 5511 RVA: 0x0003742B File Offset: 0x0003562B
		// (set) Token: 0x06001588 RID: 5512 RVA: 0x0003743D File Offset: 0x0003563D
		[global::System.Configuration.ConfigurationProperty("databaseInitializer")]
		public virtual global::System.Data.Entity.Internal.ConfigFile.DatabaseInitializerElement DatabaseInitializer
		{
			get
			{
				return (global::System.Data.Entity.Internal.ConfigFile.DatabaseInitializerElement)base["databaseInitializer"];
			}
			set
			{
				base["databaseInitializer"] = value;
			}
		}

		// Token: 0x040009D6 RID: 2518
		private const string TypeKey = "type";

		// Token: 0x040009D7 RID: 2519
		private const string CommandTimeoutKey = "commandTimeout";

		// Token: 0x040009D8 RID: 2520
		private const string DisableDatabaseInitializationKey = "disableDatabaseInitialization";

		// Token: 0x040009D9 RID: 2521
		private const string DatabaseInitializerKey = "databaseInitializer";
	}
}
