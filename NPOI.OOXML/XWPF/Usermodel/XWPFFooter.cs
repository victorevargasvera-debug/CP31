using System;
using System.IO;
using NPOI.OpenXml4Net.OPC;
using NPOI.OpenXmlFormats.Wordprocessing;

namespace NPOI.XWPF.UserModel
{
	// Token: 0x02000037 RID: 55
	public class XWPFFooter : global::NPOI.XWPF.UserModel.XWPFHeaderFooter
	{
		// Token: 0x060001CE RID: 462 RVA: 0x000070D5 File Offset: 0x000052D5
		public XWPFFooter()
		{
			this.headerFooter = new global::NPOI.OpenXmlFormats.Wordprocessing.CT_Ftr();
			base.ReadHdrFtr();
		}

		// Token: 0x060001CF RID: 463 RVA: 0x000070F0 File Offset: 0x000052F0
		public XWPFFooter(global::NPOI.XWPF.UserModel.XWPFDocument doc, global::NPOI.OpenXmlFormats.Wordprocessing.CT_HdrFtr hdrFtr) : base(doc, hdrFtr)
		{
			foreach (object obj in hdrFtr.Items)
			{
				if (obj is global::NPOI.OpenXmlFormats.Wordprocessing.CT_P)
				{
					global::NPOI.XWPF.UserModel.XWPFParagraph item = new global::NPOI.XWPF.UserModel.XWPFParagraph((global::NPOI.OpenXmlFormats.Wordprocessing.CT_P)obj, this);
					this.paragraphs.Add(item);
				}
				if (obj is global::NPOI.OpenXmlFormats.Wordprocessing.CT_Tbl)
				{
					global::NPOI.XWPF.UserModel.XWPFTable item2 = new global::NPOI.XWPF.UserModel.XWPFTable((global::NPOI.OpenXmlFormats.Wordprocessing.CT_Tbl)obj, this);
					this.tables.Add(item2);
				}
			}
		}

		// Token: 0x060001D0 RID: 464 RVA: 0x0000718C File Offset: 0x0000538C
		public XWPFFooter(global::NPOI.POIXMLDocumentPart parent, global::NPOI.OpenXml4Net.OPC.PackagePart part) : base(parent, part)
		{
		}

		// Token: 0x060001D1 RID: 465 RVA: 0x00007196 File Offset: 0x00005396
		[global::System.Obsolete("deprecated in POI 3.14, scheduled for removal in POI 3.16")]
		public XWPFFooter(global::NPOI.POIXMLDocumentPart parent, global::NPOI.OpenXml4Net.OPC.PackagePart part, global::NPOI.OpenXml4Net.OPC.PackageRelationship rel) : this(parent, part)
		{
		}

		// Token: 0x060001D2 RID: 466 RVA: 0x000071A0 File Offset: 0x000053A0
		protected internal override void Commit()
		{
			using (global::System.IO.Stream outputStream = base.GetPackagePart().GetOutputStream())
			{
				new global::NPOI.OpenXmlFormats.Wordprocessing.FtrDocument((global::NPOI.OpenXmlFormats.Wordprocessing.CT_Ftr)this.headerFooter).Save(outputStream);
			}
		}

		// Token: 0x060001D3 RID: 467 RVA: 0x000071EC File Offset: 0x000053EC
		internal override void OnDocumentRead()
		{
			base.OnDocumentRead();
			try
			{
				global::NPOI.OpenXmlFormats.Wordprocessing.FtrDocument ftrDocument = global::NPOI.OpenXmlFormats.Wordprocessing.FtrDocument.Parse(global::NPOI.POIXMLDocumentPart.ConvertStreamToXml(base.GetPackagePart().GetInputStream()), global::NPOI.POIXMLDocumentPart.NamespaceManager);
				this.headerFooter = ftrDocument.Ftr;
				foreach (object obj in this.headerFooter.Items)
				{
					if (obj is global::NPOI.OpenXmlFormats.Wordprocessing.CT_P)
					{
						global::NPOI.XWPF.UserModel.XWPFParagraph item = new global::NPOI.XWPF.UserModel.XWPFParagraph((global::NPOI.OpenXmlFormats.Wordprocessing.CT_P)obj, this);
						this.paragraphs.Add(item);
						this.bodyElements.Add(item);
					}
					if (obj is global::NPOI.OpenXmlFormats.Wordprocessing.CT_Tbl)
					{
						global::NPOI.XWPF.UserModel.XWPFTable item2 = new global::NPOI.XWPF.UserModel.XWPFTable((global::NPOI.OpenXmlFormats.Wordprocessing.CT_Tbl)obj, this);
						this.tables.Add(item2);
						this.bodyElements.Add(item2);
					}
					if (obj is global::NPOI.OpenXmlFormats.Wordprocessing.CT_SdtBlock)
					{
						global::NPOI.XWPF.UserModel.XWPFSDT item3 = new global::NPOI.XWPF.UserModel.XWPFSDT((global::NPOI.OpenXmlFormats.Wordprocessing.CT_SdtBlock)obj, this);
						this.bodyElements.Add(item3);
					}
				}
			}
			catch (global::System.Exception ex)
			{
				throw new global::NPOI.POIXMLException(ex);
			}
		}

		// Token: 0x17000096 RID: 150
		// (get) Token: 0x060001D4 RID: 468 RVA: 0x0000730C File Offset: 0x0000550C
		public override global::NPOI.XWPF.UserModel.BodyType PartType
		{
			get
			{
				return global::NPOI.XWPF.UserModel.BodyType.FOOTER;
			}
		}
	}
}
