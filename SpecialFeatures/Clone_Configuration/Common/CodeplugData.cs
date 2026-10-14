using System;
using System.Collections.Generic;
using Motorola.CommonCPS.Server.EntityModel;

namespace SpecialFeatures.Clone_Configuration.Common
{
	// Token: 0x0200017D RID: 381
	public class CodeplugData
	{
		// Token: 0x04000A17 RID: 2583
		public string purchasedFlashcode;

		// Token: 0x04000A18 RID: 2584
		public string usedFlashcode;

		// Token: 0x04000A19 RID: 2585
		public string modelNumber;

		// Token: 0x04000A1A RID: 2586
		public global::System.Collections.Generic.List<global::SpecialFeatures.Clone_Configuration.Common.AstroRecSetCountsItem> recSetCounts;

		// Token: 0x04000A1B RID: 2587
		public global::Motorola.CommonCPS.Server.EntityModel.APXCodeplug _data;
	}
}
