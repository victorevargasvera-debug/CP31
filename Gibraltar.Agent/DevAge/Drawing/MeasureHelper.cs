using System;
using System.Drawing;
using System.Windows.Forms;

namespace DevAge.Drawing
{
	// Token: 0x02000330 RID: 816
	internal class MeasureHelper : global::System.IDisposable
	{
		// Token: 0x0600266B RID: 9835 RVA: 0x000851CC File Offset: 0x000833CC
		public MeasureHelper(global::System.Windows.Forms.Control control)
		{
			this.mGraphics = control.CreateGraphics();
			this.mDisposeObj = true;
		}

		// Token: 0x0600266C RID: 9836 RVA: 0x000851E8 File Offset: 0x000833E8
		public MeasureHelper(global::System.Drawing.Graphics graphics)
		{
			this.mGraphics = graphics;
			this.mDisposeObj = false;
		}

		// Token: 0x0600266D RID: 9837 RVA: 0x00085200 File Offset: 0x00083400
		public MeasureHelper(global::DevAge.Drawing.GraphicsCache graphics)
		{
			this.mGraphics = graphics.Graphics;
			this.mDisposeObj = false;
		}

		// Token: 0x0600266E RID: 9838 RVA: 0x0008521C File Offset: 0x0008341C
		public void Dispose()
		{
			if (this.mGraphics != null && this.mDisposeObj)
			{
				this.mGraphics.Dispose();
				this.mGraphics = null;
			}
			if (this.bitmap != null)
			{
				this.bitmap.Dispose();
				this.bitmap = null;
			}
		}

		// Token: 0x17000BE5 RID: 3045
		// (get) Token: 0x0600266F RID: 9839 RVA: 0x00085274 File Offset: 0x00083474
		public global::System.Drawing.Graphics Graphics
		{
			get
			{
				return this.mGraphics;
			}
		}

		// Token: 0x04000D8E RID: 3470
		private global::System.Drawing.Bitmap bitmap;

		// Token: 0x04000D8F RID: 3471
		private global::System.Drawing.Graphics mGraphics;

		// Token: 0x04000D90 RID: 3472
		private bool mDisposeObj;
	}
}
