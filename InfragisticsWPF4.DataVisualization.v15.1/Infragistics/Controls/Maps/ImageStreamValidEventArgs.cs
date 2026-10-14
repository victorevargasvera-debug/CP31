using System;
using System.IO;

namespace Infragistics.Controls.Maps
{
	// Token: 0x020000EF RID: 239
	public class ImageStreamValidEventArgs : global::System.EventArgs
	{
		// Token: 0x17000269 RID: 617
		// (get) Token: 0x06000A0C RID: 2572 RVA: 0x0002C6E8 File Offset: 0x0002A8E8
		// (set) Token: 0x06000A0D RID: 2573 RVA: 0x0002C6F0 File Offset: 0x0002A8F0
		public global::System.IO.Stream Stream { get; set; }

		// Token: 0x06000A0E RID: 2574 RVA: 0x0002C6F9 File Offset: 0x0002A8F9
		public ImageStreamValidEventArgs(global::System.IO.Stream stream)
		{
			this.Stream = stream;
		}
	}
}
