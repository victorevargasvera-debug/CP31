using System;

namespace Motorola.Common.Communication.CommunicationPipe
{
	// Token: 0x02000004 RID: 4
	public static class Constants
	{
		// Token: 0x04000003 RID: 3
		internal const int a = 2000;

		// Token: 0x04000004 RID: 4
		internal const int b = 5000;

		// Token: 0x04000005 RID: 5
		public const byte NO_ENCRYPT = 0;

		// Token: 0x04000006 RID: 6
		public const byte ENCRYPT = 1;

		// Token: 0x04000007 RID: 7
		public const byte TLS_1_2_VID = 2;

		// Token: 0x04000008 RID: 8
		public const int MaxRetries = 3;

		// Token: 0x04000009 RID: 9
		internal const int c = 100;

		// Token: 0x0400000A RID: 10
		internal const int d = 100;

		// Token: 0x0400000B RID: 11
		internal const int e = 400;

		// Token: 0x0400000C RID: 12
		internal const int f = 50;

		// Token: 0x02000005 RID: 5
		public enum NLOptions
		{
			// Token: 0x0400000E RID: 14
			None,
			// Token: 0x0400000F RID: 15
			XNL_TRANSPORT,
			// Token: 0x04000010 RID: 16
			RNL_TRANSPORT
		}
	}
}
