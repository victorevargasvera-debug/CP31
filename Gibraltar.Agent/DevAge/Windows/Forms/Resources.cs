using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using DevAge.Properties;

namespace DevAge.Windows.Forms
{
	// Token: 0x020002F1 RID: 753
	internal class Resources
	{
		// Token: 0x0600243B RID: 9275 RVA: 0x0007E110 File Offset: 0x0007C310
		static Resources()
		{
			global::DevAge.Windows.Forms.Resources.Initialize();
		}

		// Token: 0x0600243C RID: 9276 RVA: 0x0007E118 File Offset: 0x0007C318
		public static void Initialize()
		{
			if (global::DevAge.Windows.Forms.Resources.tRightArrow == null)
			{
				using (global::System.IO.MemoryStream memoryStream = new global::System.IO.MemoryStream(global::DevAge.Properties.Resources.CURSOR_Right))
				{
					global::DevAge.Windows.Forms.Resources.tRightArrow = new global::System.Windows.Forms.Cursor(memoryStream);
				}
			}
			if (global::DevAge.Windows.Forms.Resources.tLeftArrow == null)
			{
				using (global::System.IO.MemoryStream memoryStream2 = new global::System.IO.MemoryStream(global::DevAge.Properties.Resources.CURSOR_Left))
				{
					global::DevAge.Windows.Forms.Resources.tLeftArrow = new global::System.Windows.Forms.Cursor(memoryStream2);
				}
			}
		}

		// Token: 0x17000B62 RID: 2914
		// (get) Token: 0x0600243D RID: 9277 RVA: 0x0007E1B4 File Offset: 0x0007C3B4
		public static global::System.Drawing.Icon IconSortDown
		{
			get
			{
				return global::DevAge.Properties.Resources.ICO_SortDown;
			}
		}

		// Token: 0x17000B63 RID: 2915
		// (get) Token: 0x0600243E RID: 9278 RVA: 0x0007E1BC File Offset: 0x0007C3BC
		public static global::System.Drawing.Icon IconSortUp
		{
			get
			{
				return global::DevAge.Properties.Resources.ICO_SortUp;
			}
		}

		// Token: 0x17000B64 RID: 2916
		// (get) Token: 0x0600243F RID: 9279 RVA: 0x0007E1C4 File Offset: 0x0007C3C4
		public static global::System.Windows.Forms.Cursor CursorRightArrow
		{
			get
			{
				global::DevAge.Windows.Forms.Resources.Initialize();
				return global::DevAge.Windows.Forms.Resources.tRightArrow;
			}
		}

		// Token: 0x17000B65 RID: 2917
		// (get) Token: 0x06002440 RID: 9280 RVA: 0x0007E1D0 File Offset: 0x0007C3D0
		public static global::System.Windows.Forms.Cursor CursorLeftArrow
		{
			get
			{
				global::DevAge.Windows.Forms.Resources.Initialize();
				return global::DevAge.Windows.Forms.Resources.tLeftArrow;
			}
		}

		// Token: 0x04000CC2 RID: 3266
		[global::System.ThreadStatic]
		private static global::System.Windows.Forms.Cursor tRightArrow;

		// Token: 0x04000CC3 RID: 3267
		[global::System.ThreadStatic]
		private static global::System.Windows.Forms.Cursor tLeftArrow;
	}
}
