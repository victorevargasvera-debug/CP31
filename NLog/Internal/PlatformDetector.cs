using System;

namespace NLog.Internal
{
	// Token: 0x02000115 RID: 277
	internal static class PlatformDetector
	{
		// Token: 0x17000281 RID: 641
		// (get) Token: 0x06000D39 RID: 3385 RVA: 0x00020B47 File Offset: 0x0001ED47
		public static global::NLog.Internal.RuntimeOS CurrentOS
		{
			get
			{
				return global::NLog.Internal.PlatformDetector.currentOS;
			}
		}

		// Token: 0x17000282 RID: 642
		// (get) Token: 0x06000D3A RID: 3386 RVA: 0x00020B4E File Offset: 0x0001ED4E
		public static bool IsDesktopWin32
		{
			get
			{
				return global::NLog.Internal.PlatformDetector.currentOS == global::NLog.Internal.RuntimeOS.Windows || global::NLog.Internal.PlatformDetector.currentOS == global::NLog.Internal.RuntimeOS.WindowsNT;
			}
		}

		// Token: 0x17000283 RID: 643
		// (get) Token: 0x06000D3B RID: 3387 RVA: 0x00020B62 File Offset: 0x0001ED62
		public static bool IsWin32
		{
			get
			{
				return global::NLog.Internal.PlatformDetector.currentOS == global::NLog.Internal.RuntimeOS.Windows || global::NLog.Internal.PlatformDetector.currentOS == global::NLog.Internal.RuntimeOS.WindowsNT || global::NLog.Internal.PlatformDetector.currentOS == global::NLog.Internal.RuntimeOS.WindowsCE;
			}
		}

		// Token: 0x17000284 RID: 644
		// (get) Token: 0x06000D3C RID: 3388 RVA: 0x00020B7E File Offset: 0x0001ED7E
		public static bool IsUnix
		{
			get
			{
				return global::NLog.Internal.PlatformDetector.currentOS == global::NLog.Internal.RuntimeOS.Unix;
			}
		}

		// Token: 0x17000285 RID: 645
		// (get) Token: 0x06000D3D RID: 3389 RVA: 0x00020B88 File Offset: 0x0001ED88
		public static bool IsMono
		{
			get
			{
				bool? isMono = global::NLog.Internal.PlatformDetector._isMono;
				if (isMono == null)
				{
					bool? flag = global::NLog.Internal.PlatformDetector._isMono = new bool?(global::System.Type.GetType("Mono.Runtime") != null);
					return flag.Value;
				}
				return isMono.GetValueOrDefault();
			}
		}

		// Token: 0x17000286 RID: 646
		// (get) Token: 0x06000D3E RID: 3390 RVA: 0x00020BCF File Offset: 0x0001EDCF
		public static bool SupportsSharableMutex
		{
			get
			{
				return !global::NLog.Internal.PlatformDetector.IsMono || global::System.Environment.Version.Major >= 4;
			}
		}

		// Token: 0x06000D3F RID: 3391 RVA: 0x00020BE8 File Offset: 0x0001EDE8
		private static global::NLog.Internal.RuntimeOS GetCurrentRuntimeOS()
		{
			global::System.PlatformID platform = global::System.Environment.OSVersion.Platform;
			if (platform == global::System.PlatformID.Unix || platform == (global::System.PlatformID)128)
			{
				return global::NLog.Internal.RuntimeOS.Unix;
			}
			if (platform == global::System.PlatformID.WinCE)
			{
				return global::NLog.Internal.RuntimeOS.WindowsCE;
			}
			if (platform == global::System.PlatformID.Win32Windows)
			{
				return global::NLog.Internal.RuntimeOS.Windows;
			}
			if (platform == global::System.PlatformID.Win32NT)
			{
				return global::NLog.Internal.RuntimeOS.WindowsNT;
			}
			return global::NLog.Internal.RuntimeOS.Unknown;
		}

		// Token: 0x040003A4 RID: 932
		private static global::NLog.Internal.RuntimeOS currentOS = global::NLog.Internal.PlatformDetector.GetCurrentRuntimeOS();

		// Token: 0x040003A5 RID: 933
		private static bool? _isMono;
	}
}
