using System;
using System.Configuration;

namespace System.Data.Entity.Internal.ConfigFile
{
	// Token: 0x02000154 RID: 340
	internal class QueryCacheElement : global::System.Configuration.ConfigurationElement
	{
		// Token: 0x170005A9 RID: 1449
		// (get) Token: 0x060015C8 RID: 5576 RVA: 0x000378EB File Offset: 0x00035AEB
		// (set) Token: 0x060015C9 RID: 5577 RVA: 0x000378FD File Offset: 0x00035AFD
		[global::System.Configuration.ConfigurationProperty("size")]
		[global::System.Configuration.IntegerValidator(MinValue = 0, MaxValue = 2147483647)]
		public int Size
		{
			get
			{
				return (int)base["size"];
			}
			set
			{
				base["size"] = value;
			}
		}

		// Token: 0x170005AA RID: 1450
		// (get) Token: 0x060015CA RID: 5578 RVA: 0x00037910 File Offset: 0x00035B10
		// (set) Token: 0x060015CB RID: 5579 RVA: 0x00037922 File Offset: 0x00035B22
		[global::System.Configuration.ConfigurationProperty("cleaningIntervalInSeconds")]
		[global::System.Configuration.IntegerValidator(MinValue = 0, MaxValue = 2147483647)]
		public int CleaningIntervalInSeconds
		{
			get
			{
				return (int)base["cleaningIntervalInSeconds"];
			}
			set
			{
				base["cleaningIntervalInSeconds"] = value;
			}
		}

		// Token: 0x040009F1 RID: 2545
		private const string SizeKey = "size";

		// Token: 0x040009F2 RID: 2546
		private const string CleaningIntervalInSecondsKey = "cleaningIntervalInSeconds";
	}
}
