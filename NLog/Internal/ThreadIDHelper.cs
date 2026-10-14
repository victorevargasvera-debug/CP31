using System;

namespace NLog.Internal
{
	// Token: 0x0200012C RID: 300
	internal abstract class ThreadIDHelper
	{
		// Token: 0x06000DD0 RID: 3536 RVA: 0x0002301E File Offset: 0x0002121E
		static ThreadIDHelper()
		{
			if (global::NLog.Internal.PlatformDetector.IsWin32)
			{
				global::NLog.Internal.ThreadIDHelper.Instance = new global::NLog.Internal.Win32ThreadIDHelper();
				return;
			}
			global::NLog.Internal.ThreadIDHelper.Instance = new global::NLog.Internal.PortableThreadIDHelper();
		}

		// Token: 0x1700029C RID: 668
		// (get) Token: 0x06000DD1 RID: 3537 RVA: 0x0002303C File Offset: 0x0002123C
		// (set) Token: 0x06000DD2 RID: 3538 RVA: 0x00023043 File Offset: 0x00021243
		public static global::NLog.Internal.ThreadIDHelper Instance { get; private set; }

		// Token: 0x1700029D RID: 669
		// (get) Token: 0x06000DD3 RID: 3539
		public abstract int CurrentProcessID { get; }

		// Token: 0x1700029E RID: 670
		// (get) Token: 0x06000DD4 RID: 3540
		public abstract string CurrentProcessName { get; }

		// Token: 0x1700029F RID: 671
		// (get) Token: 0x06000DD5 RID: 3541
		public abstract string CurrentProcessBaseName { get; }
	}
}
