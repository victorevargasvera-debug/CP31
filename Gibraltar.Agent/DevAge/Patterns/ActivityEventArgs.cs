using System;

namespace DevAge.Patterns
{
	// Token: 0x020002C0 RID: 704
	internal class ActivityEventArgs : global::System.EventArgs
	{
		// Token: 0x0600228B RID: 8843 RVA: 0x00079A38 File Offset: 0x00077C38
		public ActivityEventArgs(global::DevAge.Patterns.IActivity activity)
		{
			this.mActivity = activity;
		}

		// Token: 0x17000B17 RID: 2839
		// (get) Token: 0x0600228C RID: 8844 RVA: 0x00079A48 File Offset: 0x00077C48
		// (set) Token: 0x0600228D RID: 8845 RVA: 0x00079A50 File Offset: 0x00077C50
		public global::DevAge.Patterns.IActivity Activity
		{
			get
			{
				return this.mActivity;
			}
			set
			{
				this.mActivity = value;
			}
		}

		// Token: 0x04000C6E RID: 3182
		private global::DevAge.Patterns.IActivity mActivity;
	}
}
