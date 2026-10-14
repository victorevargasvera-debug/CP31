using System;
using System.Drawing;

namespace DevAge.Drawing
{
	// Token: 0x0200032A RID: 810
	internal class GraphicsCache : global::System.IDisposable
	{
		// Token: 0x0600263D RID: 9789 RVA: 0x00084838 File Offset: 0x00082A38
		public GraphicsCache(global::System.Drawing.Graphics graphics)
		{
			this.mGraphics = graphics;
			this.mClipRectangle = global::System.Drawing.Rectangle.Empty;
			this.mPensCache = new global::DevAge.Drawing.PensCache(20);
			this.mBrushsCache = new global::DevAge.Drawing.BrushsCache(20);
		}

		// Token: 0x0600263E RID: 9790 RVA: 0x0008486C File Offset: 0x00082A6C
		public GraphicsCache(global::System.Drawing.Graphics graphics, global::System.Drawing.Rectangle clipRectangle)
		{
			this.mGraphics = graphics;
			this.mClipRectangle = clipRectangle;
			this.mPensCache = new global::DevAge.Drawing.PensCache(20);
			this.mBrushsCache = new global::DevAge.Drawing.BrushsCache(20);
		}

		// Token: 0x0600263F RID: 9791 RVA: 0x0008489C File Offset: 0x00082A9C
		public GraphicsCache(global::System.Drawing.Graphics graphics, global::System.Drawing.Rectangle clipRectangle, int pensCapacity, int brushsCapacity)
		{
			this.mGraphics = graphics;
			this.mClipRectangle = clipRectangle;
			this.mPensCache = new global::DevAge.Drawing.PensCache(pensCapacity);
			this.mBrushsCache = new global::DevAge.Drawing.BrushsCache(brushsCapacity);
		}

		// Token: 0x17000BDA RID: 3034
		// (get) Token: 0x06002640 RID: 9792 RVA: 0x000848CC File Offset: 0x00082ACC
		public global::System.Drawing.Rectangle ClipRectangle
		{
			get
			{
				return this.mClipRectangle;
			}
		}

		// Token: 0x17000BDB RID: 3035
		// (get) Token: 0x06002641 RID: 9793 RVA: 0x000848D4 File Offset: 0x00082AD4
		public global::System.Drawing.Graphics Graphics
		{
			get
			{
				return this.mGraphics;
			}
		}

		// Token: 0x17000BDC RID: 3036
		// (get) Token: 0x06002642 RID: 9794 RVA: 0x000848DC File Offset: 0x00082ADC
		public global::DevAge.Drawing.PensCache PensCache
		{
			get
			{
				return this.mPensCache;
			}
		}

		// Token: 0x17000BDD RID: 3037
		// (get) Token: 0x06002643 RID: 9795 RVA: 0x000848E4 File Offset: 0x00082AE4
		public global::DevAge.Drawing.BrushsCache BrushsCache
		{
			get
			{
				return this.mBrushsCache;
			}
		}

		// Token: 0x06002644 RID: 9796 RVA: 0x000848EC File Offset: 0x00082AEC
		public void Dispose()
		{
			this.mPensCache.Dispose();
			this.mPensCache = null;
			this.mBrushsCache.Dispose();
			this.mBrushsCache = null;
			this.mGraphics = null;
		}

		// Token: 0x04000D75 RID: 3445
		private global::System.Drawing.Rectangle mClipRectangle;

		// Token: 0x04000D76 RID: 3446
		private global::System.Drawing.Graphics mGraphics;

		// Token: 0x04000D77 RID: 3447
		private global::DevAge.Drawing.PensCache mPensCache;

		// Token: 0x04000D78 RID: 3448
		private global::DevAge.Drawing.BrushsCache mBrushsCache;
	}
}
