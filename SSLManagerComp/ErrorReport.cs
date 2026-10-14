using System;
using System.Runtime.InteropServices;
using IACustomException;

namespace SSLMangrComp
{
	// Token: 0x02000010 RID: 16
	[global::System.Runtime.InteropServices.ComVisible(true)]
	public struct ErrorReport
	{
		// Token: 0x06000079 RID: 121 RVA: 0x000088AC File Offset: 0x00006AAC
		public ErrorReport(global::SSLMangrComp.ErrorCategory errCat, global::IACustomException.IACommonErrorCode errId)
		{
			this.ErrCat = (uint)errCat;
			this.ErrorID = errId;
		}

		// Token: 0x04000046 RID: 70
		public uint ErrCat;

		// Token: 0x04000047 RID: 71
		public global::IACustomException.IACommonErrorCode ErrorID;
	}
}
