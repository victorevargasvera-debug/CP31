using System;
using NPOI.OpenXmlFormats.Shared;
using NPOI.XWPF.UserModel;

namespace NPOI.XWPF.Usermodel
{
	// Token: 0x02000015 RID: 21
	public class XWPFSSup : global::NPOI.XWPF.UserModel.IRunBody
	{
		// Token: 0x06000105 RID: 261 RVA: 0x00004E4C File Offset: 0x0000304C
		public XWPFSSup(global::NPOI.OpenXmlFormats.Shared.CT_SSup ssup, global::NPOI.XWPF.UserModel.IRunBody p)
		{
			this.ssup = ssup;
			this.parent = p;
			if (ssup.e == null)
			{
				ssup.e = new global::NPOI.OpenXmlFormats.Shared.CT_OMathArg();
			}
			this.e = new global::NPOI.XWPF.Usermodel.XWPFOMathArg(ssup.e, this);
			if (ssup.sup == null)
			{
				ssup.sup = new global::NPOI.OpenXmlFormats.Shared.CT_OMathArg();
			}
			this.sup = new global::NPOI.XWPF.Usermodel.XWPFOMathArg(ssup.sup, this);
		}

		// Token: 0x1700005F RID: 95
		// (get) Token: 0x06000106 RID: 262 RVA: 0x00004EB7 File Offset: 0x000030B7
		public global::NPOI.XWPF.UserModel.XWPFDocument Document
		{
			get
			{
				return this.parent.Document;
			}
		}

		// Token: 0x17000060 RID: 96
		// (get) Token: 0x06000107 RID: 263 RVA: 0x00004EC4 File Offset: 0x000030C4
		public global::NPOI.POIXMLDocumentPart Part
		{
			get
			{
				return this.parent.Part;
			}
		}

		// Token: 0x17000061 RID: 97
		// (get) Token: 0x06000108 RID: 264 RVA: 0x00004ED1 File Offset: 0x000030D1
		public global::NPOI.XWPF.Usermodel.XWPFOMathArg Element
		{
			get
			{
				return this.e;
			}
		}

		// Token: 0x17000062 RID: 98
		// (get) Token: 0x06000109 RID: 265 RVA: 0x00004ED9 File Offset: 0x000030D9
		public global::NPOI.XWPF.Usermodel.XWPFOMathArg Superscript
		{
			get
			{
				return this.sup;
			}
		}

		// Token: 0x0400004C RID: 76
		private global::NPOI.OpenXmlFormats.Shared.CT_SSup ssup;

		// Token: 0x0400004D RID: 77
		private global::NPOI.XWPF.UserModel.IRunBody parent;

		// Token: 0x0400004E RID: 78
		private readonly global::NPOI.XWPF.Usermodel.XWPFOMathArg e;

		// Token: 0x0400004F RID: 79
		private readonly global::NPOI.XWPF.Usermodel.XWPFOMathArg sup;
	}
}
