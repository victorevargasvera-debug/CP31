using System;
using System.Collections.Generic;
using System.Collections.Specialized;

namespace SpecialFeatures.UCL.CallListUpdate
{
	// Token: 0x02000221 RID: 545
	internal interface ICSVProvider
	{
		// Token: 0x06001BC4 RID: 7108
		global::System.Collections.Generic.IDictionary<string, string> getUnitIdAndAliasDict();

		// Token: 0x06001BC5 RID: 7109
		global::System.Collections.Generic.IDictionary<string, string> getUnitIdAndSortedAliasDict();

		// Token: 0x06001BC6 RID: 7110
		bool isCsvValid();

		// Token: 0x06001BC7 RID: 7111
		global::System.Collections.Specialized.NameValueCollection getUnitIdAndAliasList();
	}
}
