using System;
using System.Windows.Forms;

namespace DevAge.Windows.Forms
{
	// Token: 0x020002E0 RID: 736
	internal class ControlCursor
	{
		// Token: 0x06002398 RID: 9112 RVA: 0x0007C550 File Offset: 0x0007A750
		public ControlCursor(global::System.Windows.Forms.Cursor pCursor)
		{
			this.mCursor = pCursor;
		}

		// Token: 0x06002399 RID: 9113 RVA: 0x0007C560 File Offset: 0x0007A760
		public void ApplyCursor(global::System.Windows.Forms.Control control)
		{
			if (this.mControl == null)
			{
				this.mControl = control;
				this.mOldCursor = this.mControl.Cursor;
				this.mControl.Cursor = this.mCursor;
			}
		}

		// Token: 0x0600239A RID: 9114 RVA: 0x0007C598 File Offset: 0x0007A798
		public void ResetCursor()
		{
			if (this.mControl != null && this.mControl.Cursor == this.mCursor)
			{
				this.mControl.Cursor = this.mOldCursor;
				this.mControl = null;
			}
		}

		// Token: 0x04000CA4 RID: 3236
		private global::System.Windows.Forms.Cursor mCursor;

		// Token: 0x04000CA5 RID: 3237
		private global::System.Windows.Forms.Cursor mOldCursor;

		// Token: 0x04000CA6 RID: 3238
		private global::System.Windows.Forms.Control mControl;
	}
}
