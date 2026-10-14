using System;

namespace DevAge
{
	// Token: 0x020002B8 RID: 696
	internal class ExceptionEventArgs : global::System.EventArgs
	{
		// Token: 0x06002271 RID: 8817 RVA: 0x000799B4 File Offset: 0x00077BB4
		public ExceptionEventArgs(global::System.Exception ex)
		{
			this.mException = ex;
		}

		// Token: 0x17000B12 RID: 2834
		// (get) Token: 0x06002272 RID: 8818 RVA: 0x000799C4 File Offset: 0x00077BC4
		public global::System.Exception Exception
		{
			get
			{
				return this.mException;
			}
		}

		// Token: 0x04000C65 RID: 3173
		private global::System.Exception mException;
	}
}
