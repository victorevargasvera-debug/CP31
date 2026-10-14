using System;
using System.Data.Entity.Core.Metadata.Edm;

namespace System.Data.Entity.ModelConfiguration.Edm
{
	// Token: 0x02000167 RID: 359
	internal static class EntitySetExtensions
	{
		// Token: 0x06001670 RID: 5744 RVA: 0x0003A4B5 File Offset: 0x000386B5
		public static object GetConfiguration(this global::System.Data.Entity.Core.Metadata.Edm.EntitySet entitySet)
		{
			return entitySet.Annotations.GetConfiguration();
		}

		// Token: 0x06001671 RID: 5745 RVA: 0x0003A4C2 File Offset: 0x000386C2
		public static void SetConfiguration(this global::System.Data.Entity.Core.Metadata.Edm.EntitySet entitySet, object configuration)
		{
			entitySet.GetMetadataProperties().SetConfiguration(configuration);
		}
	}
}
