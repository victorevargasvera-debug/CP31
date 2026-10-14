using System;

namespace Ionic.Zip
{
	// Token: 0x0200046A RID: 1130
	internal enum ZipErrorAction
	{
		// Token: 0x04001221 RID: 4641
		Throw,
		// Token: 0x04001222 RID: 4642
		Skip,
		// Token: 0x04001223 RID: 4643
		Retry,
		// Token: 0x04001224 RID: 4644
		InvokeErrorEvent
	}
}
