using System;

namespace System.Data.Entity.Core.Objects
{
	// Token: 0x02000415 RID: 1045
	public sealed class ObjectContextOptions
	{
		// Token: 0x06003220 RID: 12832 RVA: 0x000A05EC File Offset: 0x0009E7EC
		internal ObjectContextOptions()
		{
			this.ProxyCreationEnabled = true;
			this.EnsureTransactionsForFunctionsAndCommands = true;
		}

		// Token: 0x170009A9 RID: 2473
		// (get) Token: 0x06003221 RID: 12833 RVA: 0x000A0602 File Offset: 0x0009E802
		// (set) Token: 0x06003222 RID: 12834 RVA: 0x000A060A File Offset: 0x0009E80A
		public bool EnsureTransactionsForFunctionsAndCommands { get; set; }

		// Token: 0x170009AA RID: 2474
		// (get) Token: 0x06003223 RID: 12835 RVA: 0x000A0613 File Offset: 0x0009E813
		// (set) Token: 0x06003224 RID: 12836 RVA: 0x000A061B File Offset: 0x0009E81B
		public bool LazyLoadingEnabled { get; set; }

		// Token: 0x170009AB RID: 2475
		// (get) Token: 0x06003225 RID: 12837 RVA: 0x000A0624 File Offset: 0x0009E824
		// (set) Token: 0x06003226 RID: 12838 RVA: 0x000A062C File Offset: 0x0009E82C
		public bool ProxyCreationEnabled { get; set; }

		// Token: 0x170009AC RID: 2476
		// (get) Token: 0x06003227 RID: 12839 RVA: 0x000A0635 File Offset: 0x0009E835
		// (set) Token: 0x06003228 RID: 12840 RVA: 0x000A063D File Offset: 0x0009E83D
		public bool UseLegacyPreserveChangesBehavior { get; set; }

		// Token: 0x170009AD RID: 2477
		// (get) Token: 0x06003229 RID: 12841 RVA: 0x000A0646 File Offset: 0x0009E846
		// (set) Token: 0x0600322A RID: 12842 RVA: 0x000A064E File Offset: 0x0009E84E
		public bool UseConsistentNullReferenceBehavior { get; set; }

		// Token: 0x170009AE RID: 2478
		// (get) Token: 0x0600322B RID: 12843 RVA: 0x000A0657 File Offset: 0x0009E857
		// (set) Token: 0x0600322C RID: 12844 RVA: 0x000A065F File Offset: 0x0009E85F
		public bool UseCSharpNullComparisonBehavior { get; set; }

		// Token: 0x170009AF RID: 2479
		// (get) Token: 0x0600322D RID: 12845 RVA: 0x000A0668 File Offset: 0x0009E868
		// (set) Token: 0x0600322E RID: 12846 RVA: 0x000A0670 File Offset: 0x0009E870
		public bool DisableFilterOverProjectionSimplificationForCustomFunctions { get; set; }
	}
}
