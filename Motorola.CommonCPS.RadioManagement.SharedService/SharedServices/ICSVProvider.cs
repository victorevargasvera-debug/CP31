using System;
using System.Collections.Generic;
using System.Collections.Specialized;

namespace Motorola.CommonCPS.RadioManagement.SharedServices
{
	// Token: 0x0200002F RID: 47
	public interface ICSVProvider
	{
		// Token: 0x06000544 RID: 1348
		global::System.Collections.Generic.IDictionary<string, string> getUnitIdAndAliasDict();

		// Token: 0x06000545 RID: 1349
		global::System.Collections.Generic.IDictionary<string, string> getUnitIdAndSortedAliasDict();

		// Token: 0x06000546 RID: 1350
		bool isCsvValid();

		// Token: 0x06000547 RID: 1351
		global::System.Collections.Specialized.NameValueCollection getUnitIdAndAliasList();
	}
}
