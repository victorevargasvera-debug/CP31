using System;
using NPOI.OpenXmlFormats.Wordprocessing;

namespace NPOI.XWPF.UserModel
{
	// Token: 0x02000049 RID: 73
	public class XWPFSDTCell : global::NPOI.XWPF.UserModel.AbstractXWPFSDT, global::NPOI.XWPF.UserModel.ICell
	{
		// Token: 0x06000318 RID: 792 RVA: 0x0000C609 File Offset: 0x0000A809
		public XWPFSDTCell(global::NPOI.OpenXmlFormats.Wordprocessing.CT_SdtCell sdtCell, global::NPOI.XWPF.UserModel.XWPFTableRow xwpfTableRow, global::NPOI.XWPF.UserModel.IBody part) : base(sdtCell.sdtPr, part)
		{
			this.cellContent = new global::NPOI.XWPF.UserModel.XWPFSDTContentCell(sdtCell.sdtContent, xwpfTableRow, part);
		}

		// Token: 0x170000FD RID: 253
		// (get) Token: 0x06000319 RID: 793 RVA: 0x0000C62B File Offset: 0x0000A82B
		public override global::NPOI.XWPF.UserModel.ISDTContent Content
		{
			get
			{
				return this.cellContent;
			}
		}

		// Token: 0x0400021A RID: 538
		private global::NPOI.XWPF.UserModel.XWPFSDTContentCell cellContent;
	}
}
