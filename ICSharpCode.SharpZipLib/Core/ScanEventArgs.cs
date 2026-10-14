using System;

namespace ICSharpCode.SharpZipLib.Core
{
	// Token: 0x0200005D RID: 93
	public class ScanEventArgs : global::System.EventArgs
	{
		// Token: 0x06000433 RID: 1075 RVA: 0x0001342F File Offset: 0x0001162F
		public ScanEventArgs(string name)
		{
			this.name_ = name;
		}

		// Token: 0x170000FB RID: 251
		// (get) Token: 0x06000434 RID: 1076 RVA: 0x00013445 File Offset: 0x00011645
		public string Name
		{
			get
			{
				return this.name_;
			}
		}

		// Token: 0x170000FC RID: 252
		// (get) Token: 0x06000435 RID: 1077 RVA: 0x0001344D File Offset: 0x0001164D
		// (set) Token: 0x06000436 RID: 1078 RVA: 0x00013455 File Offset: 0x00011655
		public bool ContinueRunning
		{
			get
			{
				return this.continueRunning_;
			}
			set
			{
				this.continueRunning_ = value;
			}
		}

		// Token: 0x0400028C RID: 652
		private string name_;

		// Token: 0x0400028D RID: 653
		private bool continueRunning_ = true;
	}
}
