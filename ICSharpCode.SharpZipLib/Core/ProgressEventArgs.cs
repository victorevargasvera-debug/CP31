using System;

namespace ICSharpCode.SharpZipLib.Core
{
	// Token: 0x0200005E RID: 94
	public class ProgressEventArgs : global::System.EventArgs
	{
		// Token: 0x06000437 RID: 1079 RVA: 0x0001345E File Offset: 0x0001165E
		public ProgressEventArgs(string name, long processed, long target)
		{
			this.name_ = name;
			this.processed_ = processed;
			this.target_ = target;
		}

		// Token: 0x170000FD RID: 253
		// (get) Token: 0x06000438 RID: 1080 RVA: 0x00013482 File Offset: 0x00011682
		public string Name
		{
			get
			{
				return this.name_;
			}
		}

		// Token: 0x170000FE RID: 254
		// (get) Token: 0x06000439 RID: 1081 RVA: 0x0001348A File Offset: 0x0001168A
		// (set) Token: 0x0600043A RID: 1082 RVA: 0x00013492 File Offset: 0x00011692
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

		// Token: 0x170000FF RID: 255
		// (get) Token: 0x0600043B RID: 1083 RVA: 0x0001349C File Offset: 0x0001169C
		public float PercentComplete
		{
			get
			{
				float result;
				if (this.target_ <= 0L)
				{
					result = 0f;
				}
				else
				{
					result = (float)this.processed_ / (float)this.target_ * 100f;
				}
				return result;
			}
		}

		// Token: 0x17000100 RID: 256
		// (get) Token: 0x0600043C RID: 1084 RVA: 0x000134D2 File Offset: 0x000116D2
		public long Processed
		{
			get
			{
				return this.processed_;
			}
		}

		// Token: 0x17000101 RID: 257
		// (get) Token: 0x0600043D RID: 1085 RVA: 0x000134DA File Offset: 0x000116DA
		public long Target
		{
			get
			{
				return this.target_;
			}
		}

		// Token: 0x0400028E RID: 654
		private string name_;

		// Token: 0x0400028F RID: 655
		private long processed_;

		// Token: 0x04000290 RID: 656
		private long target_;

		// Token: 0x04000291 RID: 657
		private bool continueRunning_ = true;
	}
}
