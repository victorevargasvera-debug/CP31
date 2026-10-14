using System;
using System.ComponentModel;

namespace Microsoft.Practices.Prism.Modularity
{
	// Token: 0x0200002D RID: 45
	public class ModuleDownloadProgressChangedEventArgs : global::System.ComponentModel.ProgressChangedEventArgs
	{
		// Token: 0x060000ED RID: 237 RVA: 0x00004771 File Offset: 0x00002971
		public ModuleDownloadProgressChangedEventArgs(global::Microsoft.Practices.Prism.Modularity.ModuleInfo moduleInfo, long bytesReceived, long totalBytesToReceive) : base(global::Microsoft.Practices.Prism.Modularity.ModuleDownloadProgressChangedEventArgs.CalculateProgressPercentage(bytesReceived, totalBytesToReceive), null)
		{
			if (moduleInfo == null)
			{
				throw new global::System.ArgumentNullException("moduleInfo");
			}
			this.ModuleInfo = moduleInfo;
			this.BytesReceived = bytesReceived;
			this.TotalBytesToReceive = totalBytesToReceive;
		}

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x060000EE RID: 238 RVA: 0x000047A4 File Offset: 0x000029A4
		// (set) Token: 0x060000EF RID: 239 RVA: 0x000047AC File Offset: 0x000029AC
		public global::Microsoft.Practices.Prism.Modularity.ModuleInfo ModuleInfo { get; private set; }

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x060000F0 RID: 240 RVA: 0x000047B5 File Offset: 0x000029B5
		// (set) Token: 0x060000F1 RID: 241 RVA: 0x000047BD File Offset: 0x000029BD
		public long BytesReceived { get; private set; }

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x060000F2 RID: 242 RVA: 0x000047C6 File Offset: 0x000029C6
		// (set) Token: 0x060000F3 RID: 243 RVA: 0x000047CE File Offset: 0x000029CE
		public long TotalBytesToReceive { get; private set; }

		// Token: 0x060000F4 RID: 244 RVA: 0x000047D7 File Offset: 0x000029D7
		private static int CalculateProgressPercentage(long bytesReceived, long totalBytesToReceive)
		{
			if (bytesReceived == 0L || totalBytesToReceive == 0L || totalBytesToReceive == -1L)
			{
				return 0;
			}
			return (int)(bytesReceived * 100L / totalBytesToReceive);
		}
	}
}
