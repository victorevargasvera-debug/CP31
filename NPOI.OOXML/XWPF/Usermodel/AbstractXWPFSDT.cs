using System;
using NPOI.OpenXmlFormats.Wordprocessing;

namespace NPOI.XWPF.UserModel
{
	// Token: 0x02000017 RID: 23
	public abstract class AbstractXWPFSDT : global::NPOI.XWPF.UserModel.ISDTContents
	{
		// Token: 0x0600010F RID: 271 RVA: 0x00004F7C File Offset: 0x0000317C
		public AbstractXWPFSDT(global::NPOI.OpenXmlFormats.Wordprocessing.CT_SdtPr pr, global::NPOI.XWPF.UserModel.IBody part)
		{
			global::NPOI.OpenXmlFormats.Wordprocessing.CT_String[] aliasArray = pr.GetAliasArray();
			if (aliasArray != null && aliasArray.Length != 0)
			{
				this.title = aliasArray[0].val;
			}
			else
			{
				this.title = "";
			}
			global::NPOI.OpenXmlFormats.Wordprocessing.CT_String[] aliasArray2 = pr.GetAliasArray();
			if (aliasArray2 != null && aliasArray2.Length != 0)
			{
				this.tag = aliasArray2[0].val;
			}
			else
			{
				this.tag = "";
			}
			this.part = part;
		}

		// Token: 0x06000110 RID: 272 RVA: 0x00004FE8 File Offset: 0x000031E8
		public string GetTitle()
		{
			return this.title;
		}

		// Token: 0x06000111 RID: 273 RVA: 0x00004FF0 File Offset: 0x000031F0
		public string GetTag()
		{
			return this.tag;
		}

		// Token: 0x17000067 RID: 103
		// (get) Token: 0x06000112 RID: 274
		public abstract global::NPOI.XWPF.UserModel.ISDTContent Content { get; }

		// Token: 0x06000113 RID: 275 RVA: 0x00004FF8 File Offset: 0x000031F8
		public global::NPOI.XWPF.UserModel.IBody GetBody()
		{
			return null;
		}

		// Token: 0x06000114 RID: 276 RVA: 0x00004FFB File Offset: 0x000031FB
		public global::NPOI.POIXMLDocumentPart GetPart()
		{
			return this.part.Part;
		}

		// Token: 0x06000115 RID: 277 RVA: 0x00005008 File Offset: 0x00003208
		public global::NPOI.XWPF.UserModel.BodyType GetPartType()
		{
			return global::NPOI.XWPF.UserModel.BodyType.CONTENTCONTROL;
		}

		// Token: 0x06000116 RID: 278 RVA: 0x00005008 File Offset: 0x00003208
		public global::NPOI.XWPF.UserModel.BodyElementType GetElementType()
		{
			return global::NPOI.XWPF.UserModel.BodyElementType.CONTENTCONTROL;
		}

		// Token: 0x06000117 RID: 279 RVA: 0x0000500B File Offset: 0x0000320B
		public global::NPOI.XWPF.UserModel.XWPFDocument GetDocument()
		{
			return this.part.GetXWPFDocument();
		}

		// Token: 0x04000054 RID: 84
		private string title;

		// Token: 0x04000055 RID: 85
		private string tag;

		// Token: 0x04000056 RID: 86
		private global::NPOI.XWPF.UserModel.IBody part;
	}
}
