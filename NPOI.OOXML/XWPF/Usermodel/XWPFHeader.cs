using System;
using System.IO;
using NPOI.OpenXml4Net.OPC;
using NPOI.OpenXmlFormats.Wordprocessing;
using NPOI.Util;

namespace NPOI.XWPF.UserModel
{
	// Token: 0x0200003A RID: 58
	public class XWPFHeader : global::NPOI.XWPF.UserModel.XWPFHeaderFooter
	{
		// Token: 0x060001FF RID: 511 RVA: 0x00007964 File Offset: 0x00005B64
		public XWPFHeader()
		{
			this.headerFooter = new global::NPOI.OpenXmlFormats.Wordprocessing.CT_Hdr();
			base.ReadHdrFtr();
		}

		// Token: 0x06000200 RID: 512 RVA: 0x0000718C File Offset: 0x0000538C
		public XWPFHeader(global::NPOI.POIXMLDocumentPart parent, global::NPOI.OpenXml4Net.OPC.PackagePart part) : base(parent, part)
		{
		}

		// Token: 0x06000201 RID: 513 RVA: 0x0000797D File Offset: 0x00005B7D
		[global::System.Obsolete("deprecated in POI 3.14, scheduled for removal in POI 3.16")]
		public XWPFHeader(global::NPOI.POIXMLDocumentPart parent, global::NPOI.OpenXml4Net.OPC.PackagePart part, global::NPOI.OpenXml4Net.OPC.PackageRelationship rel) : this(parent, part)
		{
		}

		// Token: 0x06000202 RID: 514 RVA: 0x00007988 File Offset: 0x00005B88
		public XWPFHeader(global::NPOI.XWPF.UserModel.XWPFDocument doc, global::NPOI.OpenXmlFormats.Wordprocessing.CT_HdrFtr hdrFtr) : base(doc, hdrFtr)
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

		// Token: 0x06000203 RID: 515 RVA: 0x00007A24 File Offset: 0x00005C24
		protected internal override void Commit()
		{
			using (global::System.IO.Stream outputStream = base.GetPackagePart().GetOutputStream())
			{
				new global::NPOI.OpenXmlFormats.Wordprocessing.HdrDocument((global::NPOI.OpenXmlFormats.Wordprocessing.CT_Hdr)this.headerFooter).Save(outputStream);
			}
		}

		// Token: 0x06000204 RID: 516 RVA: 0x00007A70 File Offset: 0x00005C70
		internal override void OnDocumentRead()
		{
			base.OnDocumentRead();
			global::System.IO.Stream stream = null;
			try
			{
				stream = base.GetPackagePart().GetInputStream();
				global::NPOI.OpenXmlFormats.Wordprocessing.HdrDocument hdrDocument = global::NPOI.OpenXmlFormats.Wordprocessing.HdrDocument.Parse(global::NPOI.Util.DocumentHelper.LoadDocument(stream), global::NPOI.POIXMLDocumentPart.NamespaceManager);
				this.headerFooter = hdrDocument.Hdr;
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
			finally
			{
				if (stream != null)
				{
					stream.Close();
				}
			}
		}

		// Token: 0x170000A0 RID: 160
		// (get) Token: 0x06000205 RID: 517 RVA: 0x00007BAC File Offset: 0x00005DAC
		public override global::NPOI.XWPF.UserModel.BodyType PartType
		{
			get
			{
				return global::NPOI.XWPF.UserModel.BodyType.HEADER;
			}
		}
	}
}
