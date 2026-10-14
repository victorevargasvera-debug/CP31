using System;
using System.Configuration;
using System.Data.Entity.Internal.ConfigFile;
using System.Data.Entity.Utilities;
using System.Linq;

namespace System.Data.Entity.Infrastructure.Design
{
	// Token: 0x0200029B RID: 667
	public class AppConfigReader
	{
		// Token: 0x06002157 RID: 8535 RVA: 0x0005C796 File Offset: 0x0005A996
		public AppConfigReader(global::System.Configuration.Configuration configuration)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Configuration.Configuration>(configuration, "configuration");
			this._configuration = configuration;
		}

		// Token: 0x06002158 RID: 8536 RVA: 0x0005C7B4 File Offset: 0x0005A9B4
		public string GetProviderServices(string invariantName)
		{
			global::System.Data.Entity.Internal.ConfigFile.EntityFrameworkSection entityFrameworkSection = (global::System.Data.Entity.Internal.ConfigFile.EntityFrameworkSection)this._configuration.GetSection("entityFramework");
			if (entityFrameworkSection == null)
			{
				return null;
			}
			return (from global::System.Data.Entity.Internal.ConfigFile.ProviderElement p in entityFrameworkSection.Providers
			where p.InvariantName == invariantName
			select p.ProviderTypeName).FirstOrDefault<string>();
		}

		// Token: 0x04000B99 RID: 2969
		private readonly global::System.Configuration.Configuration _configuration;
	}
}
