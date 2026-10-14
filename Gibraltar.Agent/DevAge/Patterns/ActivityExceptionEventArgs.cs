using System;

namespace DevAge.Patterns
{
	// Token: 0x020002C2 RID: 706
	internal class ActivityExceptionEventArgs : global::DevAge.Patterns.ActivityEventArgs
	{
		// Token: 0x06002292 RID: 8850 RVA: 0x00079A5C File Offset: 0x00077C5C
		public ActivityExceptionEventArgs(global::DevAge.Patterns.IActivity activity, global::System.Exception exception) : base(activity)
		{
			this.mException = exception;
		}

		// Token: 0x17000B18 RID: 2840
		// (get) Token: 0x06002293 RID: 8851 RVA: 0x00079A6C File Offset: 0x00077C6C
		// (set) Token: 0x06002294 RID: 8852 RVA: 0x00079A74 File Offset: 0x00077C74
		public global::System.Exception Exception
		{
			get
			{
				return this.mException;
			}
			set
			{
				this.mException = value;
			}
		}

		// Token: 0x04000C6F RID: 3183
		private global::System.Exception mException;
	}
}
