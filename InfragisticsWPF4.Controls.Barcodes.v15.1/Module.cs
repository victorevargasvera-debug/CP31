using System;

namespace Infragistics.Controls.Barcodes
{
	// Token: 0x02000021 RID: 33
	public class Module
	{
		// Token: 0x06000105 RID: 261 RVA: 0x0000FBC7 File Offset: 0x0000DDC7
		public Module()
		{
		}

		// Token: 0x06000106 RID: 262 RVA: 0x0000FBCF File Offset: 0x0000DDCF
		public Module(int row, int column, int rowSpan, int colSpan)
		{
			this.Row = row;
			this.Column = column;
			this.RowSpan = rowSpan;
			this.ColSpan = colSpan;
		}

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x06000107 RID: 263 RVA: 0x0000FBF4 File Offset: 0x0000DDF4
		// (set) Token: 0x06000108 RID: 264 RVA: 0x0000FBFC File Offset: 0x0000DDFC
		public int Row { get; set; }

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x06000109 RID: 265 RVA: 0x0000FC05 File Offset: 0x0000DE05
		// (set) Token: 0x0600010A RID: 266 RVA: 0x0000FC0D File Offset: 0x0000DE0D
		public int Column { get; set; }

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x0600010B RID: 267 RVA: 0x0000FC16 File Offset: 0x0000DE16
		// (set) Token: 0x0600010C RID: 268 RVA: 0x0000FC1E File Offset: 0x0000DE1E
		public int RowSpan { get; set; }

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x0600010D RID: 269 RVA: 0x0000FC27 File Offset: 0x0000DE27
		// (set) Token: 0x0600010E RID: 270 RVA: 0x0000FC2F File Offset: 0x0000DE2F
		public int ColSpan { get; set; }
	}
}
