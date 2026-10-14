using System;

namespace CefSharp.Structs
{
	// Token: 0x020000B1 RID: 177
	public struct Size
	{
		// Token: 0x170001BB RID: 443
		// (get) Token: 0x06000568 RID: 1384 RVA: 0x000085B0 File Offset: 0x000067B0
		// (set) Token: 0x06000569 RID: 1385 RVA: 0x000085B8 File Offset: 0x000067B8
		public int Width { get; private set; }

		// Token: 0x170001BC RID: 444
		// (get) Token: 0x0600056A RID: 1386 RVA: 0x000085C1 File Offset: 0x000067C1
		// (set) Token: 0x0600056B RID: 1387 RVA: 0x000085C9 File Offset: 0x000067C9
		public int Height { get; private set; }

		// Token: 0x0600056C RID: 1388 RVA: 0x000085D2 File Offset: 0x000067D2
		public Size(int width, int height)
		{
			this = default(global::CefSharp.Structs.Size);
			this.Width = width;
			this.Height = height;
		}
	}
}
