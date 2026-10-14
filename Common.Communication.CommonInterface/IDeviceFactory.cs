using System;
using System.Collections.Generic;

namespace Motorola.Common.Communication
{
	// Token: 0x02000007 RID: 7
	public interface IDeviceFactory
	{
		// Token: 0x1700000F RID: 15
		// (get) Token: 0x06000026 RID: 38
		// (set) Token: 0x06000027 RID: 39
		string[] PIDList { get; set; }

		// Token: 0x06000028 RID: 40
		bool CreateRadios(out global::System.Collections.Generic.List<global::Motorola.Common.Communication.IMotoDevice> radioList, global::System.Collections.Generic.List<global::Motorola.Common.Communication.IRadioProfile> hwProfileList);

		// Token: 0x06000029 RID: 41
		bool IsSupport(string productId);
	}
}
