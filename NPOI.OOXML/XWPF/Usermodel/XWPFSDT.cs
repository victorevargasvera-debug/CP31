using System;
using NPOI.OpenXmlFormats.Wordprocessing;

namespace NPOI.XWPF.UserModel
{
	// Token: 0x02000048 RID: 72
	public class XWPFSDT : global::NPOI.XWPF.UserModel.AbstractXWPFSDT, global::NPOI.XWPF.UserModel.IBodyElement, global::NPOI.XWPF.UserModel.IRunBody, global::NPOI.XWPF.UserModel.ISDTContents, global::NPOI.XWPF.UserModel.IRunElement
	{
		// Token: 0x06000310 RID: 784 RVA: 0x0000C595 File Offset: 0x0000A795
		public XWPFSDT(global::NPOI.OpenXmlFormats.Wordprocessing.CT_SdtRun sdtRun, global::NPOI.XWPF.UserModel.IBody part) : base(sdtRun.sdtPr, part)
		{
			this.content = new global::NPOI.XWPF.UserModel.XWPFSDTContent(sdtRun.sdtContent, part, this);
		}

		// Token: 0x06000311 RID: 785 RVA: 0x0000C5B7 File Offset: 0x0000A7B7
		public XWPFSDT(global::NPOI.OpenXmlFormats.Wordprocessing.CT_SdtBlock block, global::NPOI.XWPF.UserModel.IBody part) : base(block.sdtPr, part)
		{
			this.content = new global::NPOI.XWPF.UserModel.XWPFSDTContent(block.sdtContent, part, this);
		}

		// Token: 0x170000F7 RID: 247
		// (get) Token: 0x06000312 RID: 786 RVA: 0x0000C5D9 File Offset: 0x0000A7D9
		public override global::NPOI.XWPF.UserModel.ISDTContent Content
		{
			get
			{
				return this.content;
			}
		}

		// Token: 0x170000F8 RID: 248
		// (get) Token: 0x06000313 RID: 787 RVA: 0x0000C5E1 File Offset: 0x0000A7E1
		public global::NPOI.XWPF.UserModel.XWPFDocument Document
		{
			get
			{
				return base.GetDocument();
			}
		}

		// Token: 0x170000F9 RID: 249
		// (get) Token: 0x06000314 RID: 788 RVA: 0x0000C5E9 File Offset: 0x0000A7E9
		public global::NPOI.POIXMLDocumentPart Part
		{
			get
			{
				return base.GetPart();
			}
		}

		// Token: 0x170000FA RID: 250
		// (get) Token: 0x06000315 RID: 789 RVA: 0x0000C5F1 File Offset: 0x0000A7F1
		public global::NPOI.XWPF.UserModel.IBody Body
		{
			get
			{
				return base.GetBody();
			}
		}

		// Token: 0x170000FB RID: 251
		// (get) Token: 0x06000316 RID: 790 RVA: 0x0000C5F9 File Offset: 0x0000A7F9
		public global::NPOI.XWPF.UserModel.BodyType PartType
		{
			get
			{
				return base.GetPartType();
			}
		}

		// Token: 0x170000FC RID: 252
		// (get) Token: 0x06000317 RID: 791 RVA: 0x0000C601 File Offset: 0x0000A801
		public global::NPOI.XWPF.UserModel.BodyElementType ElementType
		{
			get
			{
				return base.GetElementType();
			}
		}

		// Token: 0x04000219 RID: 537
		private global::NPOI.XWPF.UserModel.ISDTContent content;
	}
}
