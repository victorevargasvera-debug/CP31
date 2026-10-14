using System;
using System.Runtime.InteropServices;

namespace Motorola.Common.Communication.RUDP
{
	// Token: 0x02000022 RID: 34
	internal static class u
	{
		// Token: 0x06000178 RID: 376
		[global::System.Runtime.InteropServices.DllImport("Kernel32.dll")]
		internal static extern bool QueryPerformanceCounter(out long A_0);

		// Token: 0x06000179 RID: 377
		[global::System.Runtime.InteropServices.DllImport("Kernel32.dll")]
		internal static extern bool QueryPerformanceFrequency(out long A_0);
	}
}
