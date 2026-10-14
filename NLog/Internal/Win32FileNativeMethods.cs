using System;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;
using NLog.Targets;

namespace NLog.Internal
{
	// Token: 0x02000131 RID: 305
	internal static class Win32FileNativeMethods
	{
		// Token: 0x06000DE7 RID: 3559
		[global::System.Runtime.InteropServices.DllImport("kernel32.dll", CharSet = global::System.Runtime.InteropServices.CharSet.Unicode, SetLastError = true)]
		public static extern global::Microsoft.Win32.SafeHandles.SafeFileHandle CreateFile(string lpFileName, global::NLog.Internal.Win32FileNativeMethods.FileAccess dwDesiredAccess, int dwShareMode, global::System.IntPtr lpSecurityAttributes, global::NLog.Internal.Win32FileNativeMethods.CreationDisposition dwCreationDisposition, global::NLog.Targets.Win32FileAttributes dwFlagsAndAttributes, global::System.IntPtr hTemplateFile);

		// Token: 0x06000DE8 RID: 3560
		[global::System.Runtime.InteropServices.DllImport("kernel32.dll", SetLastError = true)]
		[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Bool)]
		public static extern bool GetFileInformationByHandle(global::System.IntPtr hFile, out global::NLog.Internal.Win32FileNativeMethods.BY_HANDLE_FILE_INFORMATION lpFileInformation);

		// Token: 0x040003D5 RID: 981
		public const int FILE_SHARE_READ = 1;

		// Token: 0x040003D6 RID: 982
		public const int FILE_SHARE_WRITE = 2;

		// Token: 0x040003D7 RID: 983
		public const int FILE_SHARE_DELETE = 4;

		// Token: 0x02000220 RID: 544
		[global::System.Flags]
		public enum FileAccess : uint
		{
			// Token: 0x0400062F RID: 1583
			GenericRead = 2147483648U,
			// Token: 0x04000630 RID: 1584
			GenericWrite = 1073741824U,
			// Token: 0x04000631 RID: 1585
			GenericExecute = 536870912U,
			// Token: 0x04000632 RID: 1586
			GenericAll = 268435456U
		}

		// Token: 0x02000221 RID: 545
		public enum CreationDisposition : uint
		{
			// Token: 0x04000634 RID: 1588
			New = 1U,
			// Token: 0x04000635 RID: 1589
			CreateAlways,
			// Token: 0x04000636 RID: 1590
			OpenExisting,
			// Token: 0x04000637 RID: 1591
			OpenAlways,
			// Token: 0x04000638 RID: 1592
			TruncateExisting
		}

		// Token: 0x02000222 RID: 546
		[global::System.Runtime.InteropServices.StructLayout(global::System.Runtime.InteropServices.LayoutKind.Sequential, Pack = 1)]
		public struct BY_HANDLE_FILE_INFORMATION
		{
			// Token: 0x04000639 RID: 1593
			public uint dwFileAttributes;

			// Token: 0x0400063A RID: 1594
			public long ftCreationTime;

			// Token: 0x0400063B RID: 1595
			public long ftLastAccessTime;

			// Token: 0x0400063C RID: 1596
			public long ftLastWriteTime;

			// Token: 0x0400063D RID: 1597
			public uint dwVolumeSerialNumber;

			// Token: 0x0400063E RID: 1598
			public uint nFileSizeHigh;

			// Token: 0x0400063F RID: 1599
			public uint nFileSizeLow;

			// Token: 0x04000640 RID: 1600
			public uint nNumberOfLinks;

			// Token: 0x04000641 RID: 1601
			public uint nFileIndexHigh;

			// Token: 0x04000642 RID: 1602
			public uint nFileIndexLow;
		}
	}
}
