using System;
using NPOI.HSSF.Record;
using NPOI.HSSF.Record.Aggregates;
using NPOI.SS.UserModel;

namespace NPOI.HSSF.UserModel
{
	// Token: 0x02000378 RID: 888
	public class HSSFFooter : global::NPOI.HSSF.UserModel.HeaderFooter, global::NPOI.SS.UserModel.IFooter, global::NPOI.SS.UserModel.IHeaderFooter
	{
		// Token: 0x06001C2B RID: 7211 RVA: 0x000557F3 File Offset: 0x000539F3
		public HSSFFooter(global::NPOI.HSSF.Record.Aggregates.PageSettingsBlock psb)
		{
			this._psb = psb;
		}

		// Token: 0x170005CA RID: 1482
		// (get) Token: 0x06001C2C RID: 7212 RVA: 0x00055804 File Offset: 0x00053A04
		public override string RawText
		{
			get
			{
				global::NPOI.HSSF.Record.FooterRecord footer = this._psb.Footer;
				if (footer == null)
				{
					return string.Empty;
				}
				return footer.Text;
			}
		}

		// Token: 0x06001C2D RID: 7213 RVA: 0x0005582C File Offset: 0x00053A2C
		protected override void SetHeaderFooterText(string text)
		{
			global::NPOI.HSSF.Record.FooterRecord footerRecord = this._psb.Footer;
			if (footerRecord == null)
			{
				footerRecord = new global::NPOI.HSSF.Record.FooterRecord(text);
				this._psb.Footer = footerRecord;
				return;
			}
			footerRecord.Text = text;
		}

		// Token: 0x04000B55 RID: 2901
		private global::NPOI.HSSF.Record.Aggregates.PageSettingsBlock _psb;
	}
}
