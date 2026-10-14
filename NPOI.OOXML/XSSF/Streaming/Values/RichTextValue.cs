using System;
using NPOI.SS.UserModel;

namespace NPOI.XSSF.Streaming.Values
{
	// Token: 0x020000D9 RID: 217
	public class RichTextValue : global::NPOI.XSSF.Streaming.Values.StringValue
	{
		// Token: 0x06000DE4 RID: 3556 RVA: 0x00006FBA File Offset: 0x000051BA
		public new global::NPOI.SS.UserModel.CellType GetType()
		{
			return global::NPOI.SS.UserModel.CellType.String;
		}

		// Token: 0x06000DE5 RID: 3557 RVA: 0x00006FBA File Offset: 0x000051BA
		public override bool IsRichText()
		{
			return true;
		}

		// Token: 0x04000410 RID: 1040
		public global::NPOI.SS.UserModel.IRichTextString Value;
	}
}
