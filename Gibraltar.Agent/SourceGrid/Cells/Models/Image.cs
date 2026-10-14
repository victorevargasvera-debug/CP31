using System;
using System.Drawing;

namespace SourceGrid.Cells.Models
{
	// Token: 0x020003B3 RID: 947
	internal class Image : global::SourceGrid.Cells.Models.IImage, global::SourceGrid.Cells.Models.IModel
	{
		// Token: 0x06002B8D RID: 11149 RVA: 0x0009248C File Offset: 0x0009068C
		public Image()
		{
		}

		// Token: 0x06002B8E RID: 11150 RVA: 0x00092494 File Offset: 0x00090694
		public Image(global::System.Drawing.Image image)
		{
			this.mImage = image;
		}

		// Token: 0x06002B8F RID: 11151 RVA: 0x000924A4 File Offset: 0x000906A4
		public global::System.Drawing.Image GetImage(global::SourceGrid.CellContext cellContext)
		{
			return this.mImage;
		}

		// Token: 0x17000CE1 RID: 3297
		// (get) Token: 0x06002B90 RID: 11152 RVA: 0x000924AC File Offset: 0x000906AC
		// (set) Token: 0x06002B91 RID: 11153 RVA: 0x000924B4 File Offset: 0x000906B4
		public global::System.Drawing.Image ImageValue
		{
			get
			{
				return this.mImage;
			}
			set
			{
				this.mImage = value;
			}
		}

		// Token: 0x04000E99 RID: 3737
		private global::System.Drawing.Image mImage;
	}
}
