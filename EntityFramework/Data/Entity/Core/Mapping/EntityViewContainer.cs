using System;
using System.Collections.Generic;

namespace System.Data.Entity.Core.Mapping
{
	// Token: 0x02000530 RID: 1328
	[global::System.Obsolete("The mechanism to provide pre-generated views has changed. Implement a class that derives from System.Data.Entity.Infrastructure.MappingViews.DbMappingViewCache and has a parameterless constructor, then associate it with a type that derives from DbContext or ObjectContext by using System.Data.Entity.Infrastructure.MappingViews.DbMappingViewCacheTypeAttribute.", true)]
	public abstract class EntityViewContainer
	{
		// Token: 0x17000CF8 RID: 3320
		// (get) Token: 0x060041A6 RID: 16806 RVA: 0x000DCEC2 File Offset: 0x000DB0C2
		internal global::System.Collections.Generic.IEnumerable<global::System.Collections.Generic.KeyValuePair<string, string>> ExtentViews
		{
			get
			{
				int num;
				for (int i = 0; i < this.ViewCount; i = num + 1)
				{
					yield return this.GetViewAt(i);
					num = i;
				}
				yield break;
			}
		}

		// Token: 0x060041A7 RID: 16807
		protected abstract global::System.Collections.Generic.KeyValuePair<string, string> GetViewAt(int index);

		// Token: 0x17000CF9 RID: 3321
		// (get) Token: 0x060041A8 RID: 16808 RVA: 0x000DCED2 File Offset: 0x000DB0D2
		// (set) Token: 0x060041A9 RID: 16809 RVA: 0x000DCEDA File Offset: 0x000DB0DA
		public string EdmEntityContainerName { get; set; }

		// Token: 0x17000CFA RID: 3322
		// (get) Token: 0x060041AA RID: 16810 RVA: 0x000DCEE3 File Offset: 0x000DB0E3
		// (set) Token: 0x060041AB RID: 16811 RVA: 0x000DCEEB File Offset: 0x000DB0EB
		public string StoreEntityContainerName { get; set; }

		// Token: 0x17000CFB RID: 3323
		// (get) Token: 0x060041AC RID: 16812 RVA: 0x000DCEF4 File Offset: 0x000DB0F4
		// (set) Token: 0x060041AD RID: 16813 RVA: 0x000DCEFC File Offset: 0x000DB0FC
		public string HashOverMappingClosure { get; set; }

		// Token: 0x17000CFC RID: 3324
		// (get) Token: 0x060041AE RID: 16814 RVA: 0x000DCF05 File Offset: 0x000DB105
		// (set) Token: 0x060041AF RID: 16815 RVA: 0x000DCF0D File Offset: 0x000DB10D
		public string HashOverAllExtentViews { get; set; }

		// Token: 0x17000CFD RID: 3325
		// (get) Token: 0x060041B0 RID: 16816 RVA: 0x000DCF16 File Offset: 0x000DB116
		// (set) Token: 0x060041B1 RID: 16817 RVA: 0x000DCF1E File Offset: 0x000DB11E
		public int ViewCount { get; protected set; }
	}
}
