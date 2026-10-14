using System;
using NPOI.OpenXml4Net.OPC;
using NPOI.OpenXmlFormats.Dml;
using NPOI.OpenXmlFormats.Dml.Picture;

namespace NPOI.XWPF.UserModel
{
	// Token: 0x02000043 RID: 67
	public class XWPFPicture
	{
		// Token: 0x060002AE RID: 686 RVA: 0x0000A7D1 File Offset: 0x000089D1
		public XWPFPicture(global::NPOI.OpenXmlFormats.Dml.Picture.CT_Picture ctPic, global::NPOI.XWPF.UserModel.XWPFRun Run)
		{
			this.run = Run;
			this.ctPic = ctPic;
			this.description = ctPic.nvPicPr.cNvPr.descr;
		}

		// Token: 0x060002AF RID: 687 RVA: 0x0000A7FD File Offset: 0x000089FD
		public void SetPictureReference(global::NPOI.OpenXml4Net.OPC.PackageRelationship rel)
		{
			this.ctPic.blipFill.blip.embed = rel.Id;
		}

		// Token: 0x060002B0 RID: 688 RVA: 0x0000A81A File Offset: 0x00008A1A
		public global::NPOI.OpenXmlFormats.Dml.Picture.CT_Picture GetCTPicture()
		{
			return this.ctPic;
		}

		// Token: 0x060002B1 RID: 689 RVA: 0x0000A824 File Offset: 0x00008A24
		public global::NPOI.XWPF.UserModel.XWPFPictureData GetPictureData()
		{
			global::NPOI.OpenXmlFormats.Dml.CT_BlipFillProperties blipFill = this.ctPic.blipFill;
			if (blipFill == null || !blipFill.IsSetBlip())
			{
				return null;
			}
			string embed = blipFill.blip.embed;
			global::NPOI.POIXMLDocumentPart part = this.run.Parent.Part;
			if (part != null)
			{
				global::NPOI.POIXMLDocumentPart relationById = part.GetRelationById(embed);
				if (relationById is global::NPOI.XWPF.UserModel.XWPFPictureData)
				{
					return (global::NPOI.XWPF.UserModel.XWPFPictureData)relationById;
				}
			}
			return null;
		}

		// Token: 0x060002B2 RID: 690 RVA: 0x0000A882 File Offset: 0x00008A82
		public string GetDescription()
		{
			return this.description;
		}

		// Token: 0x170000DA RID: 218
		// (get) Token: 0x060002B3 RID: 691 RVA: 0x0000A88A File Offset: 0x00008A8A
		public long Width
		{
			get
			{
				return this.ctPic.spPr.xfrm.ext.cx;
			}
		}

		// Token: 0x170000DB RID: 219
		// (get) Token: 0x060002B4 RID: 692 RVA: 0x0000A8A6 File Offset: 0x00008AA6
		public long Height
		{
			get
			{
				return this.ctPic.spPr.xfrm.ext.cy;
			}
		}

		// Token: 0x040001EB RID: 491
		private global::NPOI.OpenXmlFormats.Dml.Picture.CT_Picture ctPic;

		// Token: 0x040001EC RID: 492
		private string description;

		// Token: 0x040001ED RID: 493
		private global::NPOI.XWPF.UserModel.XWPFRun run;
	}
}
