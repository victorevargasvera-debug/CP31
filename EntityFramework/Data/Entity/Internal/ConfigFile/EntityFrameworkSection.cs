using System;
using System.Configuration;

namespace System.Data.Entity.Internal.ConfigFile
{
	// Token: 0x0200014D RID: 333
	internal class EntityFrameworkSection : global::System.Configuration.ConfigurationSection
	{
		// Token: 0x17000594 RID: 1428
		// (get) Token: 0x06001593 RID: 5523 RVA: 0x000374D5 File Offset: 0x000356D5
		// (set) Token: 0x06001594 RID: 5524 RVA: 0x000374E7 File Offset: 0x000356E7
		[global::System.Configuration.ConfigurationProperty("defaultConnectionFactory")]
		public virtual global::System.Data.Entity.Internal.ConfigFile.DefaultConnectionFactoryElement DefaultConnectionFactory
		{
			get
			{
				return (global::System.Data.Entity.Internal.ConfigFile.DefaultConnectionFactoryElement)base["defaultConnectionFactory"];
			}
			set
			{
				base["defaultConnectionFactory"] = value;
			}
		}

		// Token: 0x17000595 RID: 1429
		// (get) Token: 0x06001595 RID: 5525 RVA: 0x000374F5 File Offset: 0x000356F5
		// (set) Token: 0x06001596 RID: 5526 RVA: 0x00037507 File Offset: 0x00035707
		[global::System.Configuration.ConfigurationProperty("codeConfigurationType")]
		public virtual string ConfigurationTypeName
		{
			get
			{
				return (string)base["codeConfigurationType"];
			}
			set
			{
				base["codeConfigurationType"] = value;
			}
		}

		// Token: 0x17000596 RID: 1430
		// (get) Token: 0x06001597 RID: 5527 RVA: 0x00037515 File Offset: 0x00035715
		[global::System.Configuration.ConfigurationProperty("providers")]
		public virtual global::System.Data.Entity.Internal.ConfigFile.ProviderCollection Providers
		{
			get
			{
				return (global::System.Data.Entity.Internal.ConfigFile.ProviderCollection)base["providers"];
			}
		}

		// Token: 0x17000597 RID: 1431
		// (get) Token: 0x06001598 RID: 5528 RVA: 0x00037527 File Offset: 0x00035727
		[global::System.Configuration.ConfigurationProperty("contexts")]
		public virtual global::System.Data.Entity.Internal.ConfigFile.ContextCollection Contexts
		{
			get
			{
				return (global::System.Data.Entity.Internal.ConfigFile.ContextCollection)base["contexts"];
			}
		}

		// Token: 0x17000598 RID: 1432
		// (get) Token: 0x06001599 RID: 5529 RVA: 0x00037539 File Offset: 0x00035739
		[global::System.Configuration.ConfigurationProperty("interceptors")]
		public virtual global::System.Data.Entity.Internal.ConfigFile.InterceptorsCollection Interceptors
		{
			get
			{
				return (global::System.Data.Entity.Internal.ConfigFile.InterceptorsCollection)base["interceptors"];
			}
		}

		// Token: 0x17000599 RID: 1433
		// (get) Token: 0x0600159A RID: 5530 RVA: 0x0003754B File Offset: 0x0003574B
		// (set) Token: 0x0600159B RID: 5531 RVA: 0x0003755D File Offset: 0x0003575D
		[global::System.Configuration.ConfigurationProperty("queryCache")]
		public virtual global::System.Data.Entity.Internal.ConfigFile.QueryCacheElement QueryCache
		{
			get
			{
				return (global::System.Data.Entity.Internal.ConfigFile.QueryCacheElement)base["queryCache"];
			}
			set
			{
				base["queryCache"] = value;
			}
		}

		// Token: 0x040009DE RID: 2526
		private const string DefaultConnectionFactoryKey = "defaultConnectionFactory";

		// Token: 0x040009DF RID: 2527
		private const string ContextsKey = "contexts";

		// Token: 0x040009E0 RID: 2528
		private const string ProviderKey = "providers";

		// Token: 0x040009E1 RID: 2529
		private const string ConfigurationTypeKey = "codeConfigurationType";

		// Token: 0x040009E2 RID: 2530
		private const string InterceptorsKey = "interceptors";

		// Token: 0x040009E3 RID: 2531
		private const string QueryCacheKey = "queryCache";
	}
}
