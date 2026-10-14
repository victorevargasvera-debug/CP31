using System;
using NPOI.OpenXmlFormats.Shared;
using NPOI.XWPF.UserModel;

namespace NPOI.XWPF.Usermodel
{
	// Token: 0x0200000F RID: 15
	public class XWPFAcc : global::NPOI.XWPF.UserModel.IRunBody
	{
		// Token: 0x060000C2 RID: 194 RVA: 0x00004698 File Offset: 0x00002898
		public XWPFAcc(global::NPOI.OpenXmlFormats.Shared.CT_Acc acc, global::NPOI.XWPF.UserModel.IRunBody p)
		{
			this.acc = acc;
			this.parent = p;
			if (acc.e == null)
			{
				acc.e = new global::NPOI.OpenXmlFormats.Shared.CT_OMathArg();
			}
			this.e = new global::NPOI.XWPF.Usermodel.XWPFOMathArg(acc.e, this);
			if (acc.accPr == null)
			{
				acc.accPr = new global::NPOI.OpenXmlFormats.Shared.CT_AccPr();
			}
			if (acc.accPr.chr == null)
			{
				acc.accPr.chr = new global::NPOI.OpenXmlFormats.Shared.CT_Char();
			}
		}

		// Token: 0x1700003C RID: 60
		// (get) Token: 0x060000C3 RID: 195 RVA: 0x0000470E File Offset: 0x0000290E
		// (set) Token: 0x060000C4 RID: 196 RVA: 0x00004725 File Offset: 0x00002925
		public string AccPr
		{
			get
			{
				return this.acc.accPr.chr.val;
			}
			set
			{
				this.acc.accPr.chr.val = value;
			}
		}

		// Token: 0x1700003D RID: 61
		// (get) Token: 0x060000C5 RID: 197 RVA: 0x0000473D File Offset: 0x0000293D
		public global::NPOI.XWPF.Usermodel.XWPFOMathArg Element
		{
			get
			{
				return this.e;
			}
		}

		// Token: 0x1700003E RID: 62
		// (get) Token: 0x060000C6 RID: 198 RVA: 0x00004745 File Offset: 0x00002945
		public global::NPOI.XWPF.UserModel.XWPFDocument Document
		{
			get
			{
				return this.parent.Document;
			}
		}

		// Token: 0x1700003F RID: 63
		// (get) Token: 0x060000C7 RID: 199 RVA: 0x00004752 File Offset: 0x00002952
		public global::NPOI.POIXMLDocumentPart Part
		{
			get
			{
				return this.parent.Part;
			}
		}

		// Token: 0x0400002E RID: 46
		private global::NPOI.OpenXmlFormats.Shared.CT_Acc acc;

		// Token: 0x0400002F RID: 47
		private global::NPOI.XWPF.UserModel.IRunBody parent;

		// Token: 0x04000030 RID: 48
		private readonly global::NPOI.XWPF.Usermodel.XWPFOMathArg e;
	}
}
