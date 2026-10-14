using System;
using NPOI.OpenXmlFormats.Shared;
using NPOI.XWPF.UserModel;

namespace NPOI.XWPF.Usermodel
{
	// Token: 0x02000012 RID: 18
	public class XWPFNary : global::NPOI.XWPF.UserModel.IRunBody
	{
		// Token: 0x060000D4 RID: 212 RVA: 0x000048FC File Offset: 0x00002AFC
		public XWPFNary(global::NPOI.OpenXmlFormats.Shared.CT_Nary nary, global::NPOI.XWPF.UserModel.IRunBody p)
		{
			this.nary = nary;
			this.parent = p;
			if (nary.e == null)
			{
				nary.e = new global::NPOI.OpenXmlFormats.Shared.CT_OMathArg();
			}
			this.e = new global::NPOI.XWPF.Usermodel.XWPFOMathArg(nary.e, this);
			if (nary.sub == null)
			{
				nary.sub = new global::NPOI.OpenXmlFormats.Shared.CT_OMathArg();
			}
			this.sub = new global::NPOI.XWPF.Usermodel.XWPFOMathArg(nary.sub, this);
			if (nary.sup == null)
			{
				nary.sup = new global::NPOI.OpenXmlFormats.Shared.CT_OMathArg();
			}
			this.sup = new global::NPOI.XWPF.Usermodel.XWPFOMathArg(nary.sup, this);
			if (nary.naryPr == null)
			{
				nary.naryPr = new global::NPOI.OpenXmlFormats.Shared.CT_NaryPr();
			}
			if (nary.naryPr.chr == null)
			{
				nary.naryPr.chr = new global::NPOI.OpenXmlFormats.Shared.CT_Char();
			}
		}

		// Token: 0x17000049 RID: 73
		// (get) Token: 0x060000D5 RID: 213 RVA: 0x000049BC File Offset: 0x00002BBC
		public global::NPOI.XWPF.UserModel.XWPFDocument Document
		{
			get
			{
				return this.parent.Document;
			}
		}

		// Token: 0x1700004A RID: 74
		// (get) Token: 0x060000D6 RID: 214 RVA: 0x000049C9 File Offset: 0x00002BC9
		public global::NPOI.POIXMLDocumentPart Part
		{
			get
			{
				return this.parent.Part;
			}
		}

		// Token: 0x1700004B RID: 75
		// (get) Token: 0x060000D7 RID: 215 RVA: 0x000049D6 File Offset: 0x00002BD6
		public global::NPOI.XWPF.Usermodel.XWPFOMathArg Element
		{
			get
			{
				return this.e;
			}
		}

		// Token: 0x1700004C RID: 76
		// (get) Token: 0x060000D8 RID: 216 RVA: 0x000049DE File Offset: 0x00002BDE
		public global::NPOI.XWPF.Usermodel.XWPFOMathArg Subscript
		{
			get
			{
				return this.sub;
			}
		}

		// Token: 0x1700004D RID: 77
		// (get) Token: 0x060000D9 RID: 217 RVA: 0x000049E6 File Offset: 0x00002BE6
		public global::NPOI.XWPF.Usermodel.XWPFOMathArg Superscript
		{
			get
			{
				return this.sup;
			}
		}

		// Token: 0x1700004E RID: 78
		// (get) Token: 0x060000DA RID: 218 RVA: 0x000049EE File Offset: 0x00002BEE
		public string NaryPr
		{
			get
			{
				return this.nary.naryPr.chr.val;
			}
		}

		// Token: 0x060000DB RID: 219 RVA: 0x00004A05 File Offset: 0x00002C05
		public global::NPOI.XWPF.Usermodel.XWPFNary SetSumm()
		{
			this.nary.naryPr.chr.val = "∑";
			return this;
		}

		// Token: 0x060000DC RID: 220 RVA: 0x00004A22 File Offset: 0x00002C22
		public global::NPOI.XWPF.Usermodel.XWPFNary SetUnion()
		{
			this.nary.naryPr.chr.val = "⋃";
			return this;
		}

		// Token: 0x060000DD RID: 221 RVA: 0x00004A3F File Offset: 0x00002C3F
		public global::NPOI.XWPF.Usermodel.XWPFNary SetIntegral()
		{
			this.nary.naryPr.chr.val = "∫";
			return this;
		}

		// Token: 0x060000DE RID: 222 RVA: 0x00004A5C File Offset: 0x00002C5C
		public global::NPOI.XWPF.Usermodel.XWPFNary SetAnd()
		{
			this.nary.naryPr.chr.val = "⋀";
			return this;
		}

		// Token: 0x04000039 RID: 57
		private global::NPOI.OpenXmlFormats.Shared.CT_Nary nary;

		// Token: 0x0400003A RID: 58
		private global::NPOI.XWPF.UserModel.IRunBody parent;

		// Token: 0x0400003B RID: 59
		private readonly global::NPOI.XWPF.Usermodel.XWPFOMathArg e;

		// Token: 0x0400003C RID: 60
		private readonly global::NPOI.XWPF.Usermodel.XWPFOMathArg sub;

		// Token: 0x0400003D RID: 61
		private readonly global::NPOI.XWPF.Usermodel.XWPFOMathArg sup;
	}
}
