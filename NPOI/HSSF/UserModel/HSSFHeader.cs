using System;
using NPOI.HSSF.Record;
using NPOI.HSSF.Record.Aggregates;
using NPOI.SS.UserModel;

namespace NPOI.HSSF.UserModel
{
	// Token: 0x0200037A RID: 890
	public class HSSFHeader : global::NPOI.HSSF.UserModel.HeaderFooter, global::NPOI.SS.UserModel.IHeader, global::NPOI.SS.UserModel.IHeaderFooter
	{
		// Token: 0x06001C3E RID: 7230 RVA: 0x00055AF3 File Offset: 0x00053CF3
		public HSSFHeader(global::NPOI.HSSF.Record.Aggregates.PageSettingsBlock psb)
		{
			this._psb = psb;
		}

		// Token: 0x170005CB RID: 1483
		// (get) Token: 0x06001C3F RID: 7231 RVA: 0x00055B04 File Offset: 0x00053D04
		public override string RawText
		{
			get
			{
				global::NPOI.HSSF.Record.HeaderRecord header = this._psb.Header;
				if (header == null)
				{
					return string.Empty;
				}
				return header.Text;
			}
		}

		// Token: 0x06001C40 RID: 7232 RVA: 0x00055B2C File Offset: 0x00053D2C
		protected override void SetHeaderFooterText(string text)
		{
			global::NPOI.HSSF.Record.HeaderRecord headerRecord = this._psb.Header;
			if (headerRecord == null)
			{
				headerRecord = new global::NPOI.HSSF.Record.HeaderRecord(text);
				this._psb.Header = headerRecord;
				return;
			}
			headerRecord.Text = text;
		}

		// Token: 0x04000B5E RID: 2910
		private global::NPOI.HSSF.Record.Aggregates.PageSettingsBlock _psb;
	}
}
