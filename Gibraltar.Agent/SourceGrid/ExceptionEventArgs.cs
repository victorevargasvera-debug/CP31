using System;

namespace SourceGrid
{
	// Token: 0x0200037E RID: 894
	internal class ExceptionEventArgs : global::System.EventArgs
	{
		// Token: 0x06002A89 RID: 10889 RVA: 0x0008FC2C File Offset: 0x0008DE2C
		public ExceptionEventArgs(global::System.Exception p_Exception)
		{
			this.m_Exception = p_Exception;
		}

		// Token: 0x17000CAE RID: 3246
		// (get) Token: 0x06002A8A RID: 10890 RVA: 0x0008FC3C File Offset: 0x0008DE3C
		public global::System.Exception Exception
		{
			get
			{
				return this.m_Exception;
			}
		}

		// Token: 0x17000CAF RID: 3247
		// (get) Token: 0x06002A8B RID: 10891 RVA: 0x0008FC44 File Offset: 0x0008DE44
		// (set) Token: 0x06002A8C RID: 10892 RVA: 0x0008FC4C File Offset: 0x0008DE4C
		public bool Handled
		{
			get
			{
				return this.mHandled;
			}
			set
			{
				this.mHandled = value;
			}
		}

		// Token: 0x04000E56 RID: 3670
		private global::System.Exception m_Exception;

		// Token: 0x04000E57 RID: 3671
		private bool mHandled;
	}
}
