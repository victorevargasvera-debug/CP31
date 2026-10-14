using System;
using System.IO;

namespace Org.BouncyCastle.Crypto
{
	// Token: 0x020002E0 RID: 736
	public interface IStreamCalculator
	{
		// Token: 0x17000462 RID: 1122
		// (get) Token: 0x06001FCD RID: 8141
		global::System.IO.Stream Stream { get; }

		// Token: 0x06001FCE RID: 8142
		object GetResult();
	}
}
