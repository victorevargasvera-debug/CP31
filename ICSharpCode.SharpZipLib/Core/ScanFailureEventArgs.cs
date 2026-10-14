using System;

namespace ICSharpCode.SharpZipLib.Core
{
	// Token: 0x02000060 RID: 96
	public class ScanFailureEventArgs : global::System.EventArgs
	{
		// Token: 0x06000440 RID: 1088 RVA: 0x000134FA File Offset: 0x000116FA
		public ScanFailureEventArgs(string name, global::System.Exception e)
		{
			this.name_ = name;
			this.exception_ = e;
			this.continueRunning_ = true;
		}

		// Token: 0x17000103 RID: 259
		// (get) Token: 0x06000441 RID: 1089 RVA: 0x00013517 File Offset: 0x00011717
		public string Name
		{
			get
			{
				return this.name_;
			}
		}

		// Token: 0x17000104 RID: 260
		// (get) Token: 0x06000442 RID: 1090 RVA: 0x0001351F File Offset: 0x0001171F
		public global::System.Exception Exception
		{
			get
			{
				return this.exception_;
			}
		}

		// Token: 0x17000105 RID: 261
		// (get) Token: 0x06000443 RID: 1091 RVA: 0x00013527 File Offset: 0x00011727
		// (set) Token: 0x06000444 RID: 1092 RVA: 0x0001352F File Offset: 0x0001172F
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

		// Token: 0x04000293 RID: 659
		private string name_;

		// Token: 0x04000294 RID: 660
		private global::System.Exception exception_;

		// Token: 0x04000295 RID: 661
		private bool continueRunning_;
	}
}
