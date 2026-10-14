using System;

namespace NPOI.SS.UserModel
{
	// Token: 0x0200007D RID: 125
	public interface IPictureData
	{
		// Token: 0x17000141 RID: 321
		// (get) Token: 0x06000449 RID: 1097
		byte[] Data { get; }

		// Token: 0x0600044A RID: 1098
		string SuggestFileExtension();

		// Token: 0x17000142 RID: 322
		// (get) Token: 0x0600044B RID: 1099
		string MimeType { get; }

		// Token: 0x17000143 RID: 323
		// (get) Token: 0x0600044C RID: 1100
		global::NPOI.SS.UserModel.PictureType PictureType { get; }
	}
}
