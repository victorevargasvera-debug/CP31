using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml;
using NPOI.OpenXml4Net.OPC;
using NPOI.OpenXmlFormats.Wordprocessing;
using NPOI.Util;

namespace NPOI.XWPF.UserModel
{
	// Token: 0x0200003B RID: 59
	public abstract class XWPFHeaderFooter : global::NPOI.POIXMLDocumentPart, global::NPOI.XWPF.UserModel.IBody
	{
		// Token: 0x06000206 RID: 518 RVA: 0x00007BB0 File Offset: 0x00005DB0
		public XWPFHeaderFooter(global::NPOI.XWPF.UserModel.XWPFDocument doc, global::NPOI.OpenXmlFormats.Wordprocessing.CT_HdrFtr hdrFtr)
		{
			if (doc == null)
			{
				throw new global::System.NullReferenceException();
			}
			this.document = doc;
			this.headerFooter = hdrFtr;
			this.ReadHdrFtr();
		}

		// Token: 0x06000207 RID: 519 RVA: 0x00007C10 File Offset: 0x00005E10
		protected XWPFHeaderFooter()
		{
			this.headerFooter = new global::NPOI.OpenXmlFormats.Wordprocessing.CT_HdrFtr();
			this.ReadHdrFtr();
		}

		// Token: 0x06000208 RID: 520 RVA: 0x00007C64 File Offset: 0x00005E64
		public XWPFHeaderFooter(global::NPOI.POIXMLDocumentPart parent, global::NPOI.OpenXml4Net.OPC.PackagePart part) : base(parent, part)
		{
			this.document = (global::NPOI.XWPF.UserModel.XWPFDocument)base.GetParent();
			if (this.document == null)
			{
				throw new global::System.NullReferenceException();
			}
		}

		// Token: 0x06000209 RID: 521 RVA: 0x0000718C File Offset: 0x0000538C
		[global::System.Obsolete("deprecated in POI 3.14, scheduled for removal in POI 3.16")]
		public XWPFHeaderFooter(global::NPOI.POIXMLDocumentPart parent, global::NPOI.OpenXml4Net.OPC.PackagePart part, global::NPOI.OpenXml4Net.OPC.PackageRelationship rel) : this(parent, part)
		{
		}

		// Token: 0x0600020A RID: 522 RVA: 0x00007CC8 File Offset: 0x00005EC8
		internal override void OnDocumentRead()
		{
			foreach (global::NPOI.POIXMLDocumentPart poixmldocumentPart in base.GetRelations())
			{
				if (poixmldocumentPart is global::NPOI.XWPF.UserModel.XWPFPictureData)
				{
					global::NPOI.XWPF.UserModel.XWPFPictureData xwpfpictureData = (global::NPOI.XWPF.UserModel.XWPFPictureData)poixmldocumentPart;
					this.pictures.Add(xwpfpictureData);
					this.document.RegisterPackagePictureData(xwpfpictureData);
				}
			}
		}

		// Token: 0x0600020B RID: 523 RVA: 0x00007D3C File Offset: 0x00005F3C
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_HdrFtr _getHdrFtr()
		{
			return this.headerFooter;
		}

		// Token: 0x170000A1 RID: 161
		// (get) Token: 0x0600020C RID: 524 RVA: 0x00007D44 File Offset: 0x00005F44
		public global::System.Collections.Generic.IList<global::NPOI.XWPF.UserModel.IBodyElement> BodyElements
		{
			get
			{
				return this.bodyElements.AsReadOnly();
			}
		}

		// Token: 0x170000A2 RID: 162
		// (get) Token: 0x0600020D RID: 525 RVA: 0x00007D51 File Offset: 0x00005F51
		public global::System.Collections.Generic.IList<global::NPOI.XWPF.UserModel.XWPFParagraph> Paragraphs
		{
			get
			{
				return this.paragraphs.AsReadOnly();
			}
		}

		// Token: 0x170000A3 RID: 163
		// (get) Token: 0x0600020E RID: 526 RVA: 0x00007D5E File Offset: 0x00005F5E
		public global::System.Collections.Generic.IList<global::NPOI.XWPF.UserModel.XWPFTable> Tables
		{
			get
			{
				return this.tables.AsReadOnly();
			}
		}

		// Token: 0x170000A4 RID: 164
		// (get) Token: 0x0600020F RID: 527 RVA: 0x00007D6C File Offset: 0x00005F6C
		public string Text
		{
			get
			{
				global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
				for (int i = 0; i < this.paragraphs.Count; i++)
				{
					if (!this.paragraphs[i].IsEmpty)
					{
						string text = this.paragraphs[i].Text;
						if (text != null && text.Length > 0)
						{
							stringBuilder.Append(text);
							stringBuilder.Append('\n');
						}
					}
				}
				global::System.Collections.Generic.IList<global::NPOI.XWPF.UserModel.XWPFTable> list = this.Tables;
				for (int j = 0; j < list.Count; j++)
				{
					string text2 = list[j].Text;
					if (text2 != null && text2.Length > 0)
					{
						stringBuilder.Append(text2);
						stringBuilder.Append('\n');
					}
				}
				foreach (global::NPOI.XWPF.UserModel.IBodyElement bodyElement in this.BodyElements)
				{
					if (bodyElement is global::NPOI.XWPF.UserModel.XWPFSDT)
					{
						stringBuilder.Append(((global::NPOI.XWPF.UserModel.XWPFSDT)bodyElement).Content.Text + "\n");
					}
				}
				return stringBuilder.ToString();
			}
		}

		// Token: 0x06000210 RID: 528 RVA: 0x00007E94 File Offset: 0x00006094
		public void SetHeaderFooter(global::NPOI.OpenXmlFormats.Wordprocessing.CT_HdrFtr headerFooter)
		{
			this.headerFooter = headerFooter;
			this.ReadHdrFtr();
		}

		// Token: 0x06000211 RID: 529 RVA: 0x00007EA4 File Offset: 0x000060A4
		public global::NPOI.XWPF.UserModel.XWPFTable GetTable(global::NPOI.OpenXmlFormats.Wordprocessing.CT_Tbl ctTable)
		{
			foreach (global::NPOI.XWPF.UserModel.XWPFTable xwpftable in this.tables)
			{
				if (xwpftable == null)
				{
					return null;
				}
				if (xwpftable.GetCTTbl().Equals(ctTable))
				{
					return xwpftable;
				}
			}
			return null;
		}

		// Token: 0x06000212 RID: 530 RVA: 0x00007F0C File Offset: 0x0000610C
		public global::NPOI.XWPF.UserModel.XWPFParagraph GetParagraph(global::NPOI.OpenXmlFormats.Wordprocessing.CT_P p)
		{
			foreach (global::NPOI.XWPF.UserModel.XWPFParagraph xwpfparagraph in this.paragraphs)
			{
				if (xwpfparagraph.GetCTP().Equals(p))
				{
					return xwpfparagraph;
				}
			}
			return null;
		}

		// Token: 0x06000213 RID: 531 RVA: 0x00007F70 File Offset: 0x00006170
		public global::NPOI.XWPF.UserModel.XWPFParagraph GetParagraphArray(int pos)
		{
			if (pos >= 0 && pos < this.paragraphs.Count)
			{
				return this.paragraphs[pos];
			}
			return null;
		}

		// Token: 0x06000214 RID: 532 RVA: 0x00007F92 File Offset: 0x00006192
		public global::System.Collections.Generic.List<global::NPOI.XWPF.UserModel.XWPFParagraph> GetListParagraph()
		{
			return this.paragraphs;
		}

		// Token: 0x170000A5 RID: 165
		// (get) Token: 0x06000215 RID: 533 RVA: 0x00007F9A File Offset: 0x0000619A
		public global::System.Collections.Generic.IList<global::NPOI.XWPF.UserModel.XWPFPictureData> AllPictures
		{
			get
			{
				return this.pictures.AsReadOnly();
			}
		}

		// Token: 0x170000A6 RID: 166
		// (get) Token: 0x06000216 RID: 534 RVA: 0x00007FA7 File Offset: 0x000061A7
		public global::System.Collections.Generic.IList<global::NPOI.XWPF.UserModel.XWPFPictureData> AllPackagePictures
		{
			get
			{
				return this.document.AllPackagePictures;
			}
		}

		// Token: 0x06000217 RID: 535 RVA: 0x00007FB4 File Offset: 0x000061B4
		public string AddPictureData(byte[] pictureData, int format)
		{
			global::NPOI.XWPF.UserModel.XWPFPictureData xwpfpictureData = this.document.FindPackagePictureData(pictureData, format);
			global::NPOI.POIXMLRelation descriptor = global::NPOI.XWPF.UserModel.XWPFPictureData.RELATIONS[format];
			if (xwpfpictureData == null)
			{
				int nextPicNameNumber = this.document.GetNextPicNameNumber(format);
				xwpfpictureData = (global::NPOI.XWPF.UserModel.XWPFPictureData)base.CreateRelationship(descriptor, global::NPOI.XWPF.UserModel.XWPFFactory.GetInstance(), nextPicNameNumber);
				global::NPOI.OpenXml4Net.OPC.PackagePart packagePart = xwpfpictureData.GetPackagePart();
				global::System.IO.Stream stream = null;
				try
				{
					stream = packagePart.GetOutputStream();
					stream.Write(pictureData, 0, pictureData.Length);
				}
				catch (global::System.IO.IOException ex)
				{
					throw new global::NPOI.POIXMLException(ex);
				}
				finally
				{
					try
					{
						if (stream != null)
						{
							stream.Close();
						}
					}
					catch (global::System.IO.IOException)
					{
					}
				}
				this.document.RegisterPackagePictureData(xwpfpictureData);
				this.pictures.Add(xwpfpictureData);
				return base.GetRelationId(xwpfpictureData);
			}
			if (!base.GetRelations().Contains(xwpfpictureData))
			{
				xwpfpictureData.GetPackagePart();
				global::NPOI.POIXMLDocumentPart.RelationPart relationPart = base.AddRelation(null, global::NPOI.XWPF.UserModel.XWPFRelation.IMAGES, xwpfpictureData);
				this.pictures.Add(xwpfpictureData);
				return relationPart.Relationship.Id;
			}
			return base.GetRelationId(xwpfpictureData);
		}

		// Token: 0x06000218 RID: 536 RVA: 0x000080BC File Offset: 0x000062BC
		public string AddPictureData(global::System.IO.Stream is1, int format)
		{
			byte[] pictureData = global::NPOI.Util.IOUtils.ToByteArray(is1);
			return this.AddPictureData(pictureData, format);
		}

		// Token: 0x06000219 RID: 537 RVA: 0x000080D8 File Offset: 0x000062D8
		public global::NPOI.XWPF.UserModel.XWPFPictureData GetPictureDataByID(string blipID)
		{
			global::NPOI.POIXMLDocumentPart relationById = base.GetRelationById(blipID);
			if (relationById != null && relationById is global::NPOI.XWPF.UserModel.XWPFPictureData)
			{
				return (global::NPOI.XWPF.UserModel.XWPFPictureData)relationById;
			}
			return null;
		}

		// Token: 0x170000A7 RID: 167
		// (get) Token: 0x0600021A RID: 538 RVA: 0x00006FB7 File Offset: 0x000051B7
		public global::NPOI.POIXMLDocumentPart Owner
		{
			get
			{
				return this;
			}
		}

		// Token: 0x0600021B RID: 539 RVA: 0x00008100 File Offset: 0x00006300
		public global::NPOI.XWPF.UserModel.XWPFTable GetTableArray(int pos)
		{
			if (pos >= 0 && pos < this.tables.Count)
			{
				return this.tables[pos];
			}
			return null;
		}

		// Token: 0x0600021C RID: 540 RVA: 0x00008124 File Offset: 0x00006324
		public void InsertTable(int pos, global::NPOI.XWPF.UserModel.XWPFTable table)
		{
			this.bodyElements.Insert(pos, table);
			int num = 0;
			while (num < this.headerFooter.GetTblList().Count && this.headerFooter.GetTblArray(num) != table.GetCTTbl())
			{
				num++;
			}
			this.tables.Insert(num, table);
		}

		// Token: 0x0600021D RID: 541 RVA: 0x0000817C File Offset: 0x0000637C
		public void ReadHdrFtr()
		{
			this.bodyElements = new global::System.Collections.Generic.List<global::NPOI.XWPF.UserModel.IBodyElement>();
			this.paragraphs = new global::System.Collections.Generic.List<global::NPOI.XWPF.UserModel.XWPFParagraph>();
			this.tables = new global::System.Collections.Generic.List<global::NPOI.XWPF.UserModel.XWPFTable>();
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
			}
		}

		// Token: 0x0600021E RID: 542 RVA: 0x000065E4 File Offset: 0x000047E4
		public global::NPOI.XWPF.UserModel.XWPFTableCell GetTableCell(global::NPOI.OpenXmlFormats.Wordprocessing.CT_Tc cell)
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x0600021F RID: 543 RVA: 0x0000824C File Offset: 0x0000644C
		public void SetXWPFDocument(global::NPOI.XWPF.UserModel.XWPFDocument doc)
		{
			this.document = doc;
		}

		// Token: 0x06000220 RID: 544 RVA: 0x00008255 File Offset: 0x00006455
		public global::NPOI.XWPF.UserModel.XWPFDocument GetXWPFDocument()
		{
			if (this.document != null)
			{
				return this.document;
			}
			return (global::NPOI.XWPF.UserModel.XWPFDocument)base.GetParent();
		}

		// Token: 0x170000A8 RID: 168
		// (get) Token: 0x06000221 RID: 545 RVA: 0x00006FB7 File Offset: 0x000051B7
		public global::NPOI.POIXMLDocumentPart Part
		{
			get
			{
				return this;
			}
		}

		// Token: 0x170000A9 RID: 169
		// (get) Token: 0x06000222 RID: 546 RVA: 0x000065E4 File Offset: 0x000047E4
		public virtual global::NPOI.XWPF.UserModel.BodyType PartType
		{
			get
			{
				throw new global::System.NotImplementedException();
			}
		}

		// Token: 0x06000223 RID: 547 RVA: 0x00008274 File Offset: 0x00006474
		public global::NPOI.XWPF.UserModel.XWPFParagraph CreateParagraph()
		{
			global::NPOI.XWPF.UserModel.XWPFParagraph xwpfparagraph = new global::NPOI.XWPF.UserModel.XWPFParagraph(this.headerFooter.AddNewP(), this);
			this.paragraphs.Add(xwpfparagraph);
			return xwpfparagraph;
		}

		// Token: 0x06000224 RID: 548 RVA: 0x000065E4 File Offset: 0x000047E4
		public global::NPOI.XWPF.UserModel.XWPFParagraph InsertNewParagraph(global::System.Xml.XmlDocument cursor)
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x06000225 RID: 549 RVA: 0x000065E4 File Offset: 0x000047E4
		public global::NPOI.XWPF.UserModel.XWPFTable InsertNewTbl(global::System.Xml.XmlDocument cursor)
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x040001D3 RID: 467
		protected global::System.Collections.Generic.List<global::NPOI.XWPF.UserModel.XWPFParagraph> paragraphs = new global::System.Collections.Generic.List<global::NPOI.XWPF.UserModel.XWPFParagraph>(1);

		// Token: 0x040001D4 RID: 468
		protected global::System.Collections.Generic.List<global::NPOI.XWPF.UserModel.XWPFTable> tables = new global::System.Collections.Generic.List<global::NPOI.XWPF.UserModel.XWPFTable>(1);

		// Token: 0x040001D5 RID: 469
		protected global::System.Collections.Generic.List<global::NPOI.XWPF.UserModel.XWPFPictureData> pictures = new global::System.Collections.Generic.List<global::NPOI.XWPF.UserModel.XWPFPictureData>();

		// Token: 0x040001D6 RID: 470
		protected global::System.Collections.Generic.List<global::NPOI.XWPF.UserModel.IBodyElement> bodyElements = new global::System.Collections.Generic.List<global::NPOI.XWPF.UserModel.IBodyElement>(1);

		// Token: 0x040001D7 RID: 471
		protected global::NPOI.OpenXmlFormats.Wordprocessing.CT_HdrFtr headerFooter;

		// Token: 0x040001D8 RID: 472
		protected global::NPOI.XWPF.UserModel.XWPFDocument document;
	}
}
