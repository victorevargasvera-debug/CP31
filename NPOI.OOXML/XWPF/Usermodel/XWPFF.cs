using System;
using NPOI.OpenXmlFormats.Shared;
using NPOI.XWPF.UserModel;

namespace NPOI.XWPF.Usermodel
{
	// Token: 0x02000011 RID: 17
	public class XWPFF : global::NPOI.XWPF.UserModel.IRunBody
	{
		// Token: 0x060000CD RID: 205 RVA: 0x00004808 File Offset: 0x00002A08
		public XWPFF(global::NPOI.OpenXmlFormats.Shared.CT_F f, global::NPOI.XWPF.UserModel.IRunBody p)
		{
			this.f = f;
			this.parent = p;
			if (f.fPr == null)
			{
				f.fPr = new global::NPOI.OpenXmlFormats.Shared.CT_FPr();
			}
			if (f.fPr.type == null)
			{
				f.fPr.type = new global::NPOI.OpenXmlFormats.Shared.CT_FType();
			}
			if (f.num == null)
			{
				f.num = new global::NPOI.OpenXmlFormats.Shared.CT_OMathArg();
			}
			this.num = new global::NPOI.XWPF.Usermodel.XWPFOMathArg(f.num, this);
			if (f.den == null)
			{
				f.den = new global::NPOI.OpenXmlFormats.Shared.CT_OMathArg();
			}
			this.den = new global::NPOI.XWPF.Usermodel.XWPFOMathArg(f.den, this);
		}

		// Token: 0x17000044 RID: 68
		// (get) Token: 0x060000CE RID: 206 RVA: 0x000048A3 File Offset: 0x00002AA3
		// (set) Token: 0x060000CF RID: 207 RVA: 0x000048BA File Offset: 0x00002ABA
		public global::NPOI.OpenXmlFormats.Shared.ST_FType FractionType
		{
			get
			{
				return this.f.fPr.type.val;
			}
			set
			{
				this.f.fPr.type.val = value;
			}
		}

		// Token: 0x17000045 RID: 69
		// (get) Token: 0x060000D0 RID: 208 RVA: 0x000048D2 File Offset: 0x00002AD2
		public global::NPOI.XWPF.UserModel.XWPFDocument Document
		{
			get
			{
				return this.parent.Document;
			}
		}

		// Token: 0x17000046 RID: 70
		// (get) Token: 0x060000D1 RID: 209 RVA: 0x000048DF File Offset: 0x00002ADF
		public global::NPOI.POIXMLDocumentPart Part
		{
			get
			{
				return this.parent.Part;
			}
		}

		// Token: 0x17000047 RID: 71
		// (get) Token: 0x060000D2 RID: 210 RVA: 0x000048EC File Offset: 0x00002AEC
		public global::NPOI.XWPF.Usermodel.XWPFOMathArg Numerator
		{
			get
			{
				return this.num;
			}
		}

		// Token: 0x17000048 RID: 72
		// (get) Token: 0x060000D3 RID: 211 RVA: 0x000048F4 File Offset: 0x00002AF4
		public global::NPOI.XWPF.Usermodel.XWPFOMathArg Denominator
		{
			get
			{
				return this.den;
			}
		}

		// Token: 0x04000035 RID: 53
		private global::NPOI.OpenXmlFormats.Shared.CT_F f;

		// Token: 0x04000036 RID: 54
		private global::NPOI.XWPF.UserModel.IRunBody parent;

		// Token: 0x04000037 RID: 55
		private global::NPOI.XWPF.Usermodel.XWPFOMathArg num;

		// Token: 0x04000038 RID: 56
		private global::NPOI.XWPF.Usermodel.XWPFOMathArg den;
	}
}
