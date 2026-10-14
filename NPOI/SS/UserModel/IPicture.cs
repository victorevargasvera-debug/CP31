using System;
using System.Drawing;

namespace NPOI.SS.UserModel
{
	// Token: 0x0200007C RID: 124
	public interface IPicture
	{
		// Token: 0x06000440 RID: 1088
		void Resize();

		// Token: 0x06000441 RID: 1089
		void Resize(double scale);

		// Token: 0x06000442 RID: 1090
		void Resize(double scaleX, double scaleY);

		// Token: 0x06000443 RID: 1091
		global::NPOI.SS.UserModel.IClientAnchor GetPreferredSize();

		// Token: 0x06000444 RID: 1092
		global::NPOI.SS.UserModel.IClientAnchor GetPreferredSize(double scaleX, double scaleY);

		// Token: 0x06000445 RID: 1093
		global::System.Drawing.Size GetImageDimension();

		// Token: 0x1700013E RID: 318
		// (get) Token: 0x06000446 RID: 1094
		global::NPOI.SS.UserModel.IPictureData PictureData { get; }

		// Token: 0x1700013F RID: 319
		// (get) Token: 0x06000447 RID: 1095
		global::NPOI.SS.UserModel.IClientAnchor ClientAnchor { get; }

		// Token: 0x17000140 RID: 320
		// (get) Token: 0x06000448 RID: 1096
		global::NPOI.SS.UserModel.ISheet Sheet { get; }
	}
}
