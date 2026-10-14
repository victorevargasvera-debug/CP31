using System;
using NLog.Targets;

namespace NLog.Internal.FileAppenders
{
	// Token: 0x02000140 RID: 320
	internal interface ICreateFileParameters
	{
		// Token: 0x170002B3 RID: 691
		// (get) Token: 0x06000E73 RID: 3699
		int ConcurrentWriteAttemptDelay { get; }

		// Token: 0x170002B4 RID: 692
		// (get) Token: 0x06000E74 RID: 3700
		int ConcurrentWriteAttempts { get; }

		// Token: 0x170002B5 RID: 693
		// (get) Token: 0x06000E75 RID: 3701
		bool ConcurrentWrites { get; }

		// Token: 0x170002B6 RID: 694
		// (get) Token: 0x06000E76 RID: 3702
		bool CreateDirs { get; }

		// Token: 0x170002B7 RID: 695
		// (get) Token: 0x06000E77 RID: 3703
		bool EnableFileDelete { get; }

		// Token: 0x170002B8 RID: 696
		// (get) Token: 0x06000E78 RID: 3704
		int BufferSize { get; }

		// Token: 0x170002B9 RID: 697
		// (get) Token: 0x06000E79 RID: 3705
		bool ForceManaged { get; }

		// Token: 0x170002BA RID: 698
		// (get) Token: 0x06000E7A RID: 3706
		global::NLog.Targets.Win32FileAttributes FileAttributes { get; }

		// Token: 0x170002BB RID: 699
		// (get) Token: 0x06000E7B RID: 3707
		bool IsArchivingEnabled { get; }
	}
}
