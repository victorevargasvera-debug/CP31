using System;
using System.Data.Entity.Utilities;

namespace System.Data.Entity.Infrastructure
{
	// Token: 0x02000242 RID: 578
	public class ExecutionStrategyKey
	{
		// Token: 0x06001E42 RID: 7746 RVA: 0x000537D8 File Offset: 0x000519D8
		public ExecutionStrategyKey(string providerInvariantName, string serverName)
		{
			global::System.Data.Entity.Utilities.Check.NotEmpty(providerInvariantName, "providerInvariantName");
			this.ProviderInvariantName = providerInvariantName;
			this.ServerName = serverName;
		}

		// Token: 0x170006BD RID: 1725
		// (get) Token: 0x06001E43 RID: 7747 RVA: 0x000537FA File Offset: 0x000519FA
		// (set) Token: 0x06001E44 RID: 7748 RVA: 0x00053802 File Offset: 0x00051A02
		public string ProviderInvariantName { get; private set; }

		// Token: 0x170006BE RID: 1726
		// (get) Token: 0x06001E45 RID: 7749 RVA: 0x0005380B File Offset: 0x00051A0B
		// (set) Token: 0x06001E46 RID: 7750 RVA: 0x00053813 File Offset: 0x00051A13
		public string ServerName { get; private set; }

		// Token: 0x06001E47 RID: 7751 RVA: 0x0005381C File Offset: 0x00051A1C
		public override bool Equals(object obj)
		{
			global::System.Data.Entity.Infrastructure.ExecutionStrategyKey executionStrategyKey = obj as global::System.Data.Entity.Infrastructure.ExecutionStrategyKey;
			return executionStrategyKey != null && this.ProviderInvariantName.Equals(executionStrategyKey.ProviderInvariantName, global::System.StringComparison.Ordinal) && ((this.ServerName == null && executionStrategyKey.ServerName == null) || (this.ServerName != null && this.ServerName.Equals(executionStrategyKey.ServerName, global::System.StringComparison.Ordinal)));
		}

		// Token: 0x06001E48 RID: 7752 RVA: 0x00053879 File Offset: 0x00051A79
		public override int GetHashCode()
		{
			if (this.ServerName != null)
			{
				return this.ProviderInvariantName.GetHashCode() ^ this.ServerName.GetHashCode();
			}
			return this.ProviderInvariantName.GetHashCode();
		}
	}
}
