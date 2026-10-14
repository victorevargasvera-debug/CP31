using System;

namespace AcpKeyValidatorLib
{
	// Token: 0x0200000B RID: 11
	public interface IAcpKeyValidator
	{
		// Token: 0x0600001D RID: 29
		bool IsDepotKeyAttached();

		// Token: 0x0600001E RID: 30
		bool IsLabtoolKeyAttached(out bool bFullAccess);

		// Token: 0x0600001F RID: 31
		bool IsFTRKeyAttached();
	}
}
