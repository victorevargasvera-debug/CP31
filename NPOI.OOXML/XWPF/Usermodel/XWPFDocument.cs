using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using NPOI.OOXML.XWPF.Util;
using NPOI.OpenXml4Net.OPC;
using NPOI.OpenXmlFormats.Wordprocessing;
using NPOI.Util;
using NPOI.XWPF.Model;

namespace NPOI.XWPF.UserModel
{
	// Token: 0x02000034 RID: 52
	public class XWPFDocument : global::NPOI.POIXMLDocument, global::NPOI.XWPF.UserModel.Document, global::NPOI.XWPF.UserModel.IBody
	{
		// Token: 0x06000164 RID: 356 RVA: 0x00005810 File Offset: 0x00003A10
		public XWPFDocument(global::NPOI.OpenXml4Net.OPC.OPCPackage pkg) : base(pkg)
		{
			base.Load(global::NPOI.XWPF.UserModel.XWPFFactory.GetInstance());
		}

		// Token: 0x06000165 RID: 357 RVA: 0x000058B8 File Offset: 0x00003AB8
		public XWPFDocument(global::System.IO.Stream is1) : base(global::NPOI.Util.PackageHelper.Open(is1))
		{
			base.Load(global::NPOI.XWPF.UserModel.XWPFFactory.GetInstance());
		}

		// Token: 0x06000166 RID: 358 RVA: 0x00005964 File Offset: 0x00003B64
		public XWPFDocument() : base(global::NPOI.XWPF.UserModel.XWPFDocument.NewPackage())
		{
			this.OnDocumentCreate();
		}

		// Token: 0x06000167 RID: 359 RVA: 0x00005A0C File Offset: 0x00003C0C
		internal override void OnDocumentRead()
		{
			try
			{
				global::NPOI.OpenXmlFormats.Wordprocessing.DocumentDocument documentDocument = global::NPOI.OpenXmlFormats.Wordprocessing.DocumentDocument.Parse(global::NPOI.Util.DocumentHelper.LoadDocument(base.GetPackagePart().GetInputStream()), global::NPOI.POIXMLDocumentPart.NamespaceManager);
				this.ctDocument = documentDocument.Document;
				this.InitFootnotes();
				foreach (object obj in this.ctDocument.body.Items)
				{
					if (obj is global::NPOI.OpenXmlFormats.Wordprocessing.CT_P)
					{
						global::NPOI.XWPF.UserModel.XWPFParagraph item = new global::NPOI.XWPF.UserModel.XWPFParagraph((global::NPOI.OpenXmlFormats.Wordprocessing.CT_P)obj, this);
						this.bodyElements.Add(item);
						this.paragraphs.Add(item);
					}
					else if (obj is global::NPOI.OpenXmlFormats.Wordprocessing.CT_Tbl)
					{
						global::NPOI.XWPF.UserModel.XWPFTable item2 = new global::NPOI.XWPF.UserModel.XWPFTable((global::NPOI.OpenXmlFormats.Wordprocessing.CT_Tbl)obj, this);
						this.bodyElements.Add(item2);
						this.tables.Add(item2);
					}
					else if (obj is global::NPOI.OpenXmlFormats.Wordprocessing.CT_SdtBlock)
					{
						global::NPOI.XWPF.UserModel.XWPFSDT item3 = new global::NPOI.XWPF.UserModel.XWPFSDT((global::NPOI.OpenXmlFormats.Wordprocessing.CT_SdtBlock)obj, this);
						this.bodyElements.Add(item3);
						this.contentControls.Add(item3);
					}
				}
				if (documentDocument.Document.body.sectPr != null)
				{
					this.headerFooterPolicy = new global::NPOI.XWPF.Model.XWPFHeaderFooterPolicy(this);
				}
				foreach (global::NPOI.POIXMLDocumentPart.RelationPart relationPart in base.RelationParts)
				{
					global::NPOI.POIXMLDocumentPart documentPart = relationPart.DocumentPart;
					string relationshipType = relationPart.Relationship.RelationshipType;
					if (relationshipType.Equals(global::NPOI.XWPF.UserModel.XWPFRelation.STYLES.Relation))
					{
						this.styles = (global::NPOI.XWPF.UserModel.XWPFStyles)documentPart;
						this.styles.OnDocumentRead();
					}
					else if (relationshipType.Equals(global::NPOI.XWPF.UserModel.XWPFRelation.NUMBERING.Relation))
					{
						this.numbering = (global::NPOI.XWPF.UserModel.XWPFNumbering)documentPart;
						this.numbering.OnDocumentRead();
					}
					else if (relationshipType.Equals(global::NPOI.XWPF.UserModel.XWPFRelation.FOOTER.Relation))
					{
						global::NPOI.XWPF.UserModel.XWPFFooter xwpffooter = (global::NPOI.XWPF.UserModel.XWPFFooter)documentPart;
						this.footers.Add(xwpffooter);
						xwpffooter.OnDocumentRead();
					}
					else if (relationshipType.Equals(global::NPOI.XWPF.UserModel.XWPFRelation.HEADER.Relation))
					{
						global::NPOI.XWPF.UserModel.XWPFHeader xwpfheader = (global::NPOI.XWPF.UserModel.XWPFHeader)documentPart;
						this.headers.Add(xwpfheader);
						xwpfheader.OnDocumentRead();
					}
					else
					{
						if (relationshipType.Equals(global::NPOI.XWPF.UserModel.XWPFRelation.COMMENT.Relation))
						{
							using (global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.CT_Comment>.Enumerator enumerator3 = global::NPOI.OpenXmlFormats.Wordprocessing.CommentsDocument.Parse(global::NPOI.POIXMLDocumentPart.ConvertStreamToXml(documentPart.GetPackagePart().GetInputStream()), global::NPOI.POIXMLDocumentPart.NamespaceManager).Comments.comment.GetEnumerator())
							{
								while (enumerator3.MoveNext())
								{
									global::NPOI.OpenXmlFormats.Wordprocessing.CT_Comment comment = enumerator3.Current;
									this.comments.Add(new global::NPOI.XWPF.UserModel.XWPFComment(comment, this));
								}
								continue;
							}
						}
						if (relationshipType.Equals(global::NPOI.XWPF.UserModel.XWPFRelation.SETTINGS.Relation))
						{
							this.Settings = (global::NPOI.XWPF.UserModel.XWPFSettings)documentPart;
							this.Settings.OnDocumentRead();
						}
						else if (relationshipType.Equals(global::NPOI.XWPF.UserModel.XWPFRelation.IMAGES.Relation))
						{
							global::NPOI.XWPF.UserModel.XWPFPictureData xwpfpictureData = (global::NPOI.XWPF.UserModel.XWPFPictureData)documentPart;
							xwpfpictureData.OnDocumentRead();
							this.RegisterPackagePictureData(xwpfpictureData);
							this.pictures.Add(xwpfpictureData);
						}
						else if (relationshipType.Equals(global::NPOI.XWPF.UserModel.XWPFRelation.GLOSSARY_DOCUMENT.Relation))
						{
							foreach (global::NPOI.POIXMLDocumentPart poixmldocumentPart in documentPart.GetRelations())
							{
								try
								{
									poixmldocumentPart.OnDocumentRead();
								}
								catch (global::System.Exception ex)
								{
									throw new global::NPOI.POIXMLException(ex);
								}
							}
						}
					}
				}
				this.InitHyperlinks();
			}
			catch (global::System.Xml.XmlException ex2)
			{
				throw new global::NPOI.POIXMLException(ex2);
			}
		}

		// Token: 0x06000168 RID: 360 RVA: 0x00005E24 File Offset: 0x00004024
		private void InitHyperlinks()
		{
			try
			{
				foreach (global::NPOI.OpenXml4Net.OPC.PackageRelationship packageRelationship in base.GetPackagePart().GetRelationshipsByType(global::NPOI.XWPF.UserModel.XWPFRelation.HYPERLINK.Relation))
				{
					this.hyperlinks.Add(new global::NPOI.XWPF.UserModel.XWPFHyperlink(packageRelationship.Id, packageRelationship.TargetUri.ToString()));
				}
			}
			catch (global::System.IO.InvalidDataException ex)
			{
				throw new global::NPOI.POIXMLException(ex);
			}
		}

		// Token: 0x06000169 RID: 361 RVA: 0x00005E98 File Offset: 0x00004098
		private void InitFootnotes()
		{
			foreach (global::NPOI.POIXMLDocumentPart.RelationPart relationPart in base.RelationParts)
			{
				global::NPOI.POIXMLDocumentPart documentPart = relationPart.DocumentPart;
				string relationshipType = relationPart.Relationship.RelationshipType;
				if (relationshipType.Equals(global::NPOI.XWPF.UserModel.XWPFRelation.FOOTNOTE.Relation))
				{
					this.footnotes = (global::NPOI.XWPF.UserModel.XWPFFootnotes)documentPart;
					this.footnotes.OnDocumentRead();
				}
				if (relationshipType.Equals(global::NPOI.XWPF.UserModel.XWPFRelation.ENDNOTE.Relation))
				{
					foreach (global::NPOI.OpenXmlFormats.Wordprocessing.CT_FtnEdn ct_FtnEdn in global::NPOI.OpenXmlFormats.Wordprocessing.EndnotesDocument.Parse(global::NPOI.POIXMLDocumentPart.ConvertStreamToXml(documentPart.GetPackagePart().GetInputStream()), global::NPOI.POIXMLDocumentPart.NamespaceManager).Endnotes.endnote)
					{
						this.endnotes.Add(int.Parse(ct_FtnEdn.id), new global::NPOI.XWPF.UserModel.XWPFFootnote(this, ct_FtnEdn));
					}
				}
			}
		}

		// Token: 0x0600016A RID: 362 RVA: 0x00005FAC File Offset: 0x000041AC
		protected static global::NPOI.OpenXml4Net.OPC.OPCPackage NewPackage()
		{
			global::NPOI.OpenXml4Net.OPC.OPCPackage result;
			try
			{
				global::NPOI.OpenXml4Net.OPC.OPCPackage opcpackage = global::NPOI.OpenXml4Net.OPC.OPCPackage.Create(new global::System.IO.MemoryStream());
				global::NPOI.OpenXml4Net.OPC.PackagePartName packagePartName = global::NPOI.OpenXml4Net.OPC.PackagingUriHelper.CreatePartName(global::NPOI.XWPF.UserModel.XWPFRelation.DOCUMENT.DefaultFileName);
				opcpackage.AddRelationship(packagePartName, global::NPOI.OpenXml4Net.OPC.TargetMode.Internal, "http://schemas.openxmlformats.org/officeDocument/2006/relationships/officeDocument");
				opcpackage.CreatePart(packagePartName, global::NPOI.XWPF.UserModel.XWPFRelation.DOCUMENT.ContentType);
				opcpackage.GetPackageProperties().SetCreatorProperty(global::NPOI.POIXMLDocument.DOCUMENT_CREATOR);
				result = opcpackage;
			}
			catch (global::System.Exception ex)
			{
				throw new global::NPOI.POIXMLException(ex);
			}
			return result;
		}

		// Token: 0x0600016B RID: 363 RVA: 0x00006020 File Offset: 0x00004220
		internal override void OnDocumentCreate()
		{
			this.ctDocument = new global::NPOI.OpenXmlFormats.Wordprocessing.CT_Document();
			this.ctDocument.AddNewBody();
			this.Settings = (global::NPOI.XWPF.UserModel.XWPFSettings)base.CreateRelationship(global::NPOI.XWPF.UserModel.XWPFRelation.SETTINGS, global::NPOI.XWPF.UserModel.XWPFFactory.GetInstance());
			this.CreateStyles();
			base.GetProperties().ExtendedProperties.GetUnderlyingProperties().Application = global::NPOI.POIXMLDocument.DOCUMENT_CREATOR;
		}

		// Token: 0x17000086 RID: 134
		// (get) Token: 0x0600016C RID: 364 RVA: 0x0000607F File Offset: 0x0000427F
		// (set) Token: 0x0600016D RID: 365 RVA: 0x00006087 File Offset: 0x00004287
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_Document Document
		{
			get
			{
				return this.ctDocument;
			}
			set
			{
				this.ctDocument = value;
			}
		}

		// Token: 0x17000087 RID: 135
		// (get) Token: 0x0600016E RID: 366 RVA: 0x00006090 File Offset: 0x00004290
		// (set) Token: 0x0600016F RID: 367 RVA: 0x000060B1 File Offset: 0x000042B1
		public int ColumnCount
		{
			get
			{
				return int.Parse(this.ctDocument.body.sectPr.cols.num);
			}
			set
			{
				if (this.ctDocument != null)
				{
					this.ctDocument.body.sectPr.cols.num = value.ToString();
				}
			}
		}

		// Token: 0x17000088 RID: 136
		// (get) Token: 0x06000170 RID: 368 RVA: 0x000060DC File Offset: 0x000042DC
		// (set) Token: 0x06000171 RID: 369 RVA: 0x000060F8 File Offset: 0x000042F8
		public global::NPOI.OpenXmlFormats.Wordprocessing.ST_TextDirection TextDirection
		{
			get
			{
				return this.ctDocument.body.sectPr.textDirection.val;
			}
			set
			{
				if (this.ctDocument != null)
				{
					this.ctDocument.body.sectPr.textDirection.val = value;
				}
			}
		}

		// Token: 0x17000089 RID: 137
		// (get) Token: 0x06000172 RID: 370 RVA: 0x0000611D File Offset: 0x0000431D
		internal global::NPOI.Util.IdentifierManager DrawingIdManager
		{
			get
			{
				return this.drawingIdManager;
			}
		}

		// Token: 0x1700008A RID: 138
		// (get) Token: 0x06000173 RID: 371 RVA: 0x00006125 File Offset: 0x00004325
		public global::System.Collections.Generic.IList<global::NPOI.XWPF.UserModel.IBodyElement> BodyElements
		{
			get
			{
				return this.bodyElements.AsReadOnly();
			}
		}

		// Token: 0x06000174 RID: 372 RVA: 0x00006132 File Offset: 0x00004332
		public global::System.Collections.Generic.IEnumerator<global::NPOI.XWPF.UserModel.IBodyElement> GetBodyElementsIterator()
		{
			return this.bodyElements.GetEnumerator();
		}

		// Token: 0x1700008B RID: 139
		// (get) Token: 0x06000175 RID: 373 RVA: 0x00006144 File Offset: 0x00004344
		public global::System.Collections.Generic.IList<global::NPOI.XWPF.UserModel.XWPFParagraph> Paragraphs
		{
			get
			{
				return this.paragraphs.AsReadOnly();
			}
		}

		// Token: 0x1700008C RID: 140
		// (get) Token: 0x06000176 RID: 374 RVA: 0x00006151 File Offset: 0x00004351
		public global::System.Collections.Generic.IList<global::NPOI.XWPF.UserModel.XWPFTable> Tables
		{
			get
			{
				return this.tables.AsReadOnly();
			}
		}

		// Token: 0x06000177 RID: 375 RVA: 0x0000615E File Offset: 0x0000435E
		public global::NPOI.XWPF.UserModel.XWPFTable GetTableArray(int pos)
		{
			if (pos >= 0 && pos < this.tables.Count)
			{
				return this.tables[pos];
			}
			return null;
		}

		// Token: 0x1700008D RID: 141
		// (get) Token: 0x06000178 RID: 376 RVA: 0x00006180 File Offset: 0x00004380
		public global::System.Collections.Generic.IList<global::NPOI.XWPF.UserModel.XWPFFooter> FooterList
		{
			get
			{
				return this.footers.AsReadOnly();
			}
		}

		// Token: 0x06000179 RID: 377 RVA: 0x0000618D File Offset: 0x0000438D
		public global::NPOI.XWPF.UserModel.XWPFFooter GetFooterArray(int pos)
		{
			if (pos >= 0 && pos < this.footers.Count)
			{
				return this.footers[pos];
			}
			return null;
		}

		// Token: 0x1700008E RID: 142
		// (get) Token: 0x0600017A RID: 378 RVA: 0x000061AF File Offset: 0x000043AF
		public global::System.Collections.Generic.IList<global::NPOI.XWPF.UserModel.XWPFHeader> HeaderList
		{
			get
			{
				return this.headers.AsReadOnly();
			}
		}

		// Token: 0x0600017B RID: 379 RVA: 0x000061BC File Offset: 0x000043BC
		public global::NPOI.XWPF.UserModel.XWPFHeader GetHeaderArray(int pos)
		{
			if (pos >= 0 && pos < this.headers.Count)
			{
				return this.headers[pos];
			}
			return null;
		}

		// Token: 0x0600017C RID: 380 RVA: 0x000061DE File Offset: 0x000043DE
		public string GetTblStyle(global::NPOI.XWPF.UserModel.XWPFTable table)
		{
			return table.StyleID;
		}

		// Token: 0x0600017D RID: 381 RVA: 0x000061E8 File Offset: 0x000043E8
		public global::NPOI.XWPF.UserModel.XWPFHyperlink GetHyperlinkByID(string id)
		{
			foreach (global::NPOI.XWPF.UserModel.XWPFHyperlink xwpfhyperlink in this.hyperlinks)
			{
				if (xwpfhyperlink.Id.Equals(id))
				{
					return xwpfhyperlink;
				}
			}
			return null;
		}

		// Token: 0x0600017E RID: 382 RVA: 0x00006228 File Offset: 0x00004428
		public global::NPOI.XWPF.UserModel.XWPFFootnote GetFootnoteByID(int id)
		{
			if (this.footnotes == null)
			{
				return null;
			}
			return this.footnotes.GetFootnoteById(id);
		}

		// Token: 0x1700008F RID: 143
		// (get) Token: 0x0600017F RID: 383 RVA: 0x00006240 File Offset: 0x00004440
		public global::System.Collections.Generic.Dictionary<int, global::NPOI.XWPF.UserModel.XWPFFootnote> Endnotes
		{
			get
			{
				return this.endnotes;
			}
		}

		// Token: 0x06000180 RID: 384 RVA: 0x00006248 File Offset: 0x00004448
		public global::NPOI.XWPF.UserModel.XWPFFootnote GetEndnoteByID(int id)
		{
			if (this.endnotes == null || !this.endnotes.ContainsKey(id))
			{
				return null;
			}
			return this.endnotes[id];
		}

		// Token: 0x06000181 RID: 385 RVA: 0x0000626E File Offset: 0x0000446E
		public global::System.Collections.Generic.List<global::NPOI.XWPF.UserModel.XWPFFootnote> GetFootnotes()
		{
			if (this.footnotes == null)
			{
				return new global::System.Collections.Generic.List<global::NPOI.XWPF.UserModel.XWPFFootnote>();
			}
			return this.footnotes.GetFootnotesList();
		}

		// Token: 0x06000182 RID: 386 RVA: 0x00006289 File Offset: 0x00004489
		public global::NPOI.XWPF.UserModel.XWPFHyperlink[] GetHyperlinks()
		{
			return this.hyperlinks.ToArray();
		}

		// Token: 0x06000183 RID: 387 RVA: 0x00006298 File Offset: 0x00004498
		public global::NPOI.XWPF.UserModel.XWPFComment GetCommentByID(string id)
		{
			foreach (global::NPOI.XWPF.UserModel.XWPFComment xwpfcomment in this.comments)
			{
				if (xwpfcomment.Id.Equals(id))
				{
					return xwpfcomment;
				}
			}
			return null;
		}

		// Token: 0x06000184 RID: 388 RVA: 0x000062D8 File Offset: 0x000044D8
		public global::NPOI.XWPF.UserModel.XWPFComment[] GetComments()
		{
			return this.comments.ToArray();
		}

		// Token: 0x06000185 RID: 389 RVA: 0x000062E8 File Offset: 0x000044E8
		public global::NPOI.OpenXml4Net.OPC.PackagePart GetPartById(string id)
		{
			global::NPOI.OpenXml4Net.OPC.PackagePart relatedPart;
			try
			{
				global::NPOI.OpenXml4Net.OPC.PackagePart corePart = base.CorePart;
				relatedPart = corePart.GetRelatedPart(corePart.GetRelationship(id));
			}
			catch (global::System.Exception innerException)
			{
				throw new global::System.ArgumentException("GetTargetPart exception", innerException);
			}
			return relatedPart;
		}

		// Token: 0x06000186 RID: 390 RVA: 0x00006328 File Offset: 0x00004528
		public global::NPOI.XWPF.Model.XWPFHeaderFooterPolicy GetHeaderFooterPolicy()
		{
			return this.headerFooterPolicy;
		}

		// Token: 0x06000187 RID: 391 RVA: 0x00006330 File Offset: 0x00004530
		public global::NPOI.XWPF.Model.XWPFHeaderFooterPolicy CreateHeaderFooterPolicy()
		{
			if (this.headerFooterPolicy == null)
			{
				if (!this.ctDocument.body.IsSetSectPr())
				{
					this.ctDocument.body.AddNewSectPr();
				}
				this.headerFooterPolicy = new global::NPOI.XWPF.Model.XWPFHeaderFooterPolicy(this);
			}
			return this.headerFooterPolicy;
		}

		// Token: 0x06000188 RID: 392 RVA: 0x00006370 File Offset: 0x00004570
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_Styles GetCTStyle()
		{
			global::NPOI.OpenXml4Net.OPC.PackagePart[] relatedByType;
			try
			{
				relatedByType = base.GetRelatedByType(global::NPOI.XWPF.UserModel.XWPFRelation.STYLES.Relation);
			}
			catch (global::System.Exception innerException)
			{
				throw new global::System.InvalidOperationException("get Style document part exception", innerException);
			}
			if (relatedByType.Length != 1)
			{
				throw new global::System.InvalidOperationException("Expecting one Styles document part, but found " + relatedByType.Length.ToString());
			}
			return global::NPOI.OpenXmlFormats.Wordprocessing.StylesDocument.Parse(global::NPOI.POIXMLDocumentPart.ConvertStreamToXml(relatedByType[0].GetInputStream()), global::NPOI.POIXMLDocumentPart.NamespaceManager).Styles;
		}

		// Token: 0x06000189 RID: 393 RVA: 0x000063EC File Offset: 0x000045EC
		public override global::System.Collections.Generic.List<global::NPOI.OpenXml4Net.OPC.PackagePart> GetAllEmbedds()
		{
			global::System.Collections.Generic.List<global::NPOI.OpenXml4Net.OPC.PackagePart> list = new global::System.Collections.Generic.List<global::NPOI.OpenXml4Net.OPC.PackagePart>();
			global::NPOI.OpenXml4Net.OPC.PackagePart packagePart = base.GetPackagePart();
			foreach (global::NPOI.OpenXml4Net.OPC.PackageRelationship rel in base.GetPackagePart().GetRelationshipsByType(global::NPOI.POIXMLDocument.OLE_OBJECT_REL_TYPE))
			{
				list.Add(packagePart.GetRelatedPart(rel));
			}
			foreach (global::NPOI.OpenXml4Net.OPC.PackageRelationship rel2 in base.GetPackagePart().GetRelationshipsByType(global::NPOI.POIXMLDocument.PACK_OBJECT_REL_TYPE))
			{
				list.Add(packagePart.GetRelatedPart(rel2));
			}
			return list;
		}

		// Token: 0x0600018A RID: 394 RVA: 0x000064A8 File Offset: 0x000046A8
		private int GetBodyElementSpecificPos(int pos, global::System.Collections.Generic.List<global::NPOI.XWPF.UserModel.IBodyElement> list)
		{
			if (list.Count == 0)
			{
				return -1;
			}
			if (pos >= 0 && pos < this.bodyElements.Count)
			{
				global::NPOI.XWPF.UserModel.IBodyElement bodyElement = this.bodyElements[pos];
				if (bodyElement.ElementType != list[0].ElementType)
				{
					return -1;
				}
				for (int i = global::System.Math.Min(pos, list.Count - 1); i >= 0; i--)
				{
					if (list[i] == bodyElement)
					{
						return i;
					}
				}
			}
			return -1;
		}

		// Token: 0x0600018B RID: 395 RVA: 0x0000651C File Offset: 0x0000471C
		public int GetParagraphPos(int pos)
		{
			global::System.Collections.Generic.List<global::NPOI.XWPF.UserModel.IBodyElement> list = new global::System.Collections.Generic.List<global::NPOI.XWPF.UserModel.IBodyElement>();
			foreach (global::NPOI.XWPF.UserModel.IBodyElement item in this.paragraphs)
			{
				list.Add(item);
			}
			return this.GetBodyElementSpecificPos(pos, list);
		}

		// Token: 0x0600018C RID: 396 RVA: 0x00006580 File Offset: 0x00004780
		public int GetTablePos(int pos)
		{
			global::System.Collections.Generic.List<global::NPOI.XWPF.UserModel.IBodyElement> list = new global::System.Collections.Generic.List<global::NPOI.XWPF.UserModel.IBodyElement>();
			foreach (global::NPOI.XWPF.UserModel.IBodyElement item in this.tables)
			{
				list.Add(item);
			}
			return this.GetBodyElementSpecificPos(pos, list);
		}

		// Token: 0x0600018D RID: 397 RVA: 0x000065E4 File Offset: 0x000047E4
		public global::NPOI.XWPF.UserModel.XWPFParagraph InsertNewParagraph(global::System.Xml.XmlDocument cursor)
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x0600018E RID: 398 RVA: 0x000065E4 File Offset: 0x000047E4
		public global::NPOI.XWPF.UserModel.XWPFTable InsertNewTbl(global::System.Xml.XmlDocument cursor)
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x0600018F RID: 399 RVA: 0x000065E4 File Offset: 0x000047E4
		private bool IsCursorInBody(global::System.Xml.XmlDocument cursor)
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x06000190 RID: 400 RVA: 0x000065EC File Offset: 0x000047EC
		private int GetPosOfBodyElement(global::NPOI.XWPF.UserModel.IBodyElement needle)
		{
			global::NPOI.XWPF.UserModel.BodyElementType elementType = needle.ElementType;
			for (int i = 0; i < this.bodyElements.Count; i++)
			{
				global::NPOI.XWPF.UserModel.IBodyElement bodyElement = this.bodyElements[i];
				if (bodyElement.ElementType == elementType && bodyElement.Equals(needle))
				{
					return i;
				}
			}
			return -1;
		}

		// Token: 0x06000191 RID: 401 RVA: 0x00006638 File Offset: 0x00004838
		public int GetPosOfParagraph(global::NPOI.XWPF.UserModel.XWPFParagraph p)
		{
			return this.GetPosOfBodyElement(p);
		}

		// Token: 0x06000192 RID: 402 RVA: 0x00006638 File Offset: 0x00004838
		public int GetPosOfTable(global::NPOI.XWPF.UserModel.XWPFTable t)
		{
			return this.GetPosOfBodyElement(t);
		}

		// Token: 0x06000193 RID: 403 RVA: 0x00006644 File Offset: 0x00004844
		protected internal override void Commit()
		{
			using (global::System.IO.Stream outputStream = base.GetPackagePart().GetOutputStream())
			{
				new global::NPOI.OpenXmlFormats.Wordprocessing.DocumentDocument(this.ctDocument).Save(outputStream);
			}
		}

		// Token: 0x06000194 RID: 404 RVA: 0x0000668C File Offset: 0x0000488C
		private int GetRelationIndex(global::NPOI.XWPF.UserModel.XWPFRelation relation)
		{
			int num = 1;
			using (global::System.Collections.Generic.List<global::NPOI.POIXMLDocumentPart.RelationPart>.Enumerator enumerator = base.RelationParts.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (enumerator.Current.Relationship.RelationshipType.Equals(relation.Relation))
					{
						num++;
					}
				}
			}
			return num;
		}

		// Token: 0x06000195 RID: 405 RVA: 0x000066F8 File Offset: 0x000048F8
		public global::NPOI.XWPF.UserModel.XWPFParagraph CreateParagraph()
		{
			global::NPOI.XWPF.UserModel.XWPFParagraph xwpfparagraph = new global::NPOI.XWPF.UserModel.XWPFParagraph(this.ctDocument.body.AddNewP(), this);
			this.bodyElements.Add(xwpfparagraph);
			this.paragraphs.Add(xwpfparagraph);
			return xwpfparagraph;
		}

		// Token: 0x06000196 RID: 406 RVA: 0x00006738 File Offset: 0x00004938
		public global::NPOI.XWPF.UserModel.XWPFNumbering CreateNumbering()
		{
			if (this.numbering == null)
			{
				global::NPOI.OpenXmlFormats.Wordprocessing.NumberingDocument numberingDocument = new global::NPOI.OpenXmlFormats.Wordprocessing.NumberingDocument();
				global::NPOI.XWPF.UserModel.XWPFRelation xwpfrelation = global::NPOI.XWPF.UserModel.XWPFRelation.NUMBERING;
				int relationIndex = this.GetRelationIndex(xwpfrelation);
				global::NPOI.XWPF.UserModel.XWPFNumbering xwpfnumbering = (global::NPOI.XWPF.UserModel.XWPFNumbering)base.CreateRelationship(xwpfrelation, global::NPOI.XWPF.UserModel.XWPFFactory.GetInstance(), relationIndex);
				xwpfnumbering.SetNumbering(numberingDocument.Numbering);
				this.numbering = xwpfnumbering;
			}
			return this.numbering;
		}

		// Token: 0x06000197 RID: 407 RVA: 0x00006790 File Offset: 0x00004990
		public global::NPOI.XWPF.UserModel.XWPFStyles CreateStyles()
		{
			if (this.styles == null)
			{
				global::NPOI.OpenXmlFormats.Wordprocessing.StylesDocument stylesDocument = new global::NPOI.OpenXmlFormats.Wordprocessing.StylesDocument();
				global::NPOI.XWPF.UserModel.XWPFRelation xwpfrelation = global::NPOI.XWPF.UserModel.XWPFRelation.STYLES;
				int relationIndex = this.GetRelationIndex(xwpfrelation);
				global::NPOI.XWPF.UserModel.XWPFStyles xwpfstyles = (global::NPOI.XWPF.UserModel.XWPFStyles)base.CreateRelationship(xwpfrelation, global::NPOI.XWPF.UserModel.XWPFFactory.GetInstance(), relationIndex);
				xwpfstyles.SetStyles(stylesDocument.Styles);
				this.styles = xwpfstyles;
			}
			return this.styles;
		}

		// Token: 0x06000198 RID: 408 RVA: 0x000067E8 File Offset: 0x000049E8
		public global::NPOI.XWPF.UserModel.XWPFFootnotes CreateFootnotes()
		{
			if (this.footnotes == null)
			{
				global::NPOI.OpenXmlFormats.Wordprocessing.FootnotesDocument footnotesDocument = new global::NPOI.OpenXmlFormats.Wordprocessing.FootnotesDocument();
				global::NPOI.XWPF.UserModel.XWPFRelation footnote = global::NPOI.XWPF.UserModel.XWPFRelation.FOOTNOTE;
				int relationIndex = this.GetRelationIndex(footnote);
				global::NPOI.XWPF.UserModel.XWPFFootnotes xwpffootnotes = (global::NPOI.XWPF.UserModel.XWPFFootnotes)base.CreateRelationship(footnote, global::NPOI.XWPF.UserModel.XWPFFactory.GetInstance(), relationIndex);
				xwpffootnotes.SetFootnotes(footnotesDocument.Footnotes);
				this.footnotes = xwpffootnotes;
			}
			return this.footnotes;
		}

		// Token: 0x06000199 RID: 409 RVA: 0x0000683D File Offset: 0x00004A3D
		public global::NPOI.XWPF.UserModel.XWPFFootnote AddFootnote(global::NPOI.OpenXmlFormats.Wordprocessing.CT_FtnEdn note)
		{
			return this.footnotes.AddFootnote(note);
		}

		// Token: 0x0600019A RID: 410 RVA: 0x0000684C File Offset: 0x00004A4C
		public global::NPOI.XWPF.UserModel.XWPFFootnote AddEndnote(global::NPOI.OpenXmlFormats.Wordprocessing.CT_FtnEdn note)
		{
			global::NPOI.XWPF.UserModel.XWPFFootnote xwpffootnote = new global::NPOI.XWPF.UserModel.XWPFFootnote(this, note);
			this.endnotes.Add(int.Parse(note.id), xwpffootnote);
			return xwpffootnote;
		}

		// Token: 0x0600019B RID: 411 RVA: 0x0000687C File Offset: 0x00004A7C
		public bool RemoveBodyElement(int pos)
		{
			if (pos >= 0 && pos < this.bodyElements.Count)
			{
				global::NPOI.XWPF.UserModel.BodyElementType elementType = this.bodyElements[pos].ElementType;
				if (elementType == global::NPOI.XWPF.UserModel.BodyElementType.TABLE)
				{
					int tablePos = this.GetTablePos(pos);
					this.tables.RemoveAt(tablePos);
					this.ctDocument.body.RemoveTbl(tablePos);
				}
				if (elementType == global::NPOI.XWPF.UserModel.BodyElementType.PARAGRAPH)
				{
					int paragraphPos = this.GetParagraphPos(pos);
					this.paragraphs.RemoveAt(paragraphPos);
					this.ctDocument.body.RemoveP(paragraphPos);
				}
				this.bodyElements.RemoveAt(pos);
				return true;
			}
			return false;
		}

		// Token: 0x0600019C RID: 412 RVA: 0x0000690C File Offset: 0x00004B0C
		public void SetParagraph(global::NPOI.XWPF.UserModel.XWPFParagraph paragraph, int pos)
		{
			this.paragraphs[pos] = paragraph;
			this.ctDocument.body.SetPArray(pos, paragraph.GetCTP());
		}

		// Token: 0x0600019D RID: 413 RVA: 0x00006934 File Offset: 0x00004B34
		public global::NPOI.XWPF.UserModel.XWPFParagraph GetLastParagraph()
		{
			int index = this.paragraphs.ToArray().Length - 1;
			return this.paragraphs[index];
		}

		// Token: 0x0600019E RID: 414 RVA: 0x00006960 File Offset: 0x00004B60
		public global::NPOI.XWPF.UserModel.XWPFTable CreateTable()
		{
			global::NPOI.XWPF.UserModel.XWPFTable xwpftable = new global::NPOI.XWPF.UserModel.XWPFTable(this.ctDocument.body.AddNewTbl(), this);
			this.bodyElements.Add(xwpftable);
			this.tables.Add(xwpftable);
			return xwpftable;
		}

		// Token: 0x0600019F RID: 415 RVA: 0x000069A0 File Offset: 0x00004BA0
		public global::NPOI.XWPF.UserModel.XWPFTable CreateTable(int rows, int cols)
		{
			global::NPOI.XWPF.UserModel.XWPFTable xwpftable = new global::NPOI.XWPF.UserModel.XWPFTable(this.ctDocument.body.AddNewTbl(), this, rows, cols);
			this.bodyElements.Add(xwpftable);
			this.tables.Add(xwpftable);
			return xwpftable;
		}

		// Token: 0x060001A0 RID: 416 RVA: 0x000069E0 File Offset: 0x00004BE0
		public void CreateTOC()
		{
			global::NPOI.OpenXmlFormats.Wordprocessing.CT_Styles ct_Styles = global::NPOI.OOXML.XWPF.Util.DocumentStylesBuilder.BuildStylesForTOC(null);
			this.styles.SetStyles(ct_Styles);
			new global::NPOI.XWPF.UserModel.TOC(this.Document.body.AddNewSdt()).Build();
			this.EnforceUpdateFields();
		}

		// Token: 0x060001A1 RID: 417 RVA: 0x00006A21 File Offset: 0x00004C21
		public void SetTable(int pos, global::NPOI.XWPF.UserModel.XWPFTable table)
		{
			this.tables[pos] = table;
			this.ctDocument.body.SetTblArray(pos, table.GetCTTbl());
		}

		// Token: 0x060001A2 RID: 418 RVA: 0x00006A47 File Offset: 0x00004C47
		public bool IsEnforcedProtection()
		{
			return this.Settings.IsEnforcedWith();
		}

		// Token: 0x060001A3 RID: 419 RVA: 0x00006A54 File Offset: 0x00004C54
		public bool IsEnforcedReadonlyProtection()
		{
			return this.Settings.IsEnforcedWith(global::NPOI.OpenXmlFormats.Wordprocessing.ST_DocProtect.readOnly);
		}

		// Token: 0x060001A4 RID: 420 RVA: 0x00006A62 File Offset: 0x00004C62
		public bool IsEnforcedFillingFormsProtection()
		{
			return this.Settings.IsEnforcedWith(global::NPOI.OpenXmlFormats.Wordprocessing.ST_DocProtect.forms);
		}

		// Token: 0x060001A5 RID: 421 RVA: 0x00006A70 File Offset: 0x00004C70
		public bool IsEnforcedCommentsProtection()
		{
			return this.Settings.IsEnforcedWith(global::NPOI.OpenXmlFormats.Wordprocessing.ST_DocProtect.comments);
		}

		// Token: 0x060001A6 RID: 422 RVA: 0x00006A7E File Offset: 0x00004C7E
		public bool IsEnforcedTrackedChangesProtection()
		{
			return this.Settings.IsEnforcedWith(global::NPOI.OpenXmlFormats.Wordprocessing.ST_DocProtect.trackedChanges);
		}

		// Token: 0x060001A7 RID: 423 RVA: 0x00006A8C File Offset: 0x00004C8C
		public bool IsEnforcedUpdateFields()
		{
			return this.Settings.IsUpdateFields();
		}

		// Token: 0x060001A8 RID: 424 RVA: 0x00006A99 File Offset: 0x00004C99
		public void EnforceReadonlyProtection()
		{
			this.Settings.SetEnforcementEditValue(global::NPOI.OpenXmlFormats.Wordprocessing.ST_DocProtect.readOnly);
		}

		// Token: 0x060001A9 RID: 425 RVA: 0x00006AA7 File Offset: 0x00004CA7
		public void EnforceFillingFormsProtection()
		{
			this.Settings.SetEnforcementEditValue(global::NPOI.OpenXmlFormats.Wordprocessing.ST_DocProtect.forms);
		}

		// Token: 0x060001AA RID: 426 RVA: 0x00006AB5 File Offset: 0x00004CB5
		public void EnforceCommentsProtection()
		{
			this.Settings.SetEnforcementEditValue(global::NPOI.OpenXmlFormats.Wordprocessing.ST_DocProtect.comments);
		}

		// Token: 0x060001AB RID: 427 RVA: 0x00006AC3 File Offset: 0x00004CC3
		public void EnforceTrackedChangesProtection()
		{
			this.Settings.SetEnforcementEditValue(global::NPOI.OpenXmlFormats.Wordprocessing.ST_DocProtect.trackedChanges);
		}

		// Token: 0x060001AC RID: 428 RVA: 0x00006AD1 File Offset: 0x00004CD1
		public void RemoveProtectionEnforcement()
		{
			this.Settings.RemoveEnforcement();
		}

		// Token: 0x060001AD RID: 429 RVA: 0x00006ADE File Offset: 0x00004CDE
		public void EnforceUpdateFields()
		{
			this.Settings.SetUpdateFields();
		}

		// Token: 0x17000090 RID: 144
		// (get) Token: 0x060001AE RID: 430 RVA: 0x00006AEB File Offset: 0x00004CEB
		// (set) Token: 0x060001AF RID: 431 RVA: 0x00006AF8 File Offset: 0x00004CF8
		public bool IsTrackRevisions
		{
			get
			{
				return this.Settings.IsTrackRevisions;
			}
			set
			{
				this.Settings.IsTrackRevisions = value;
			}
		}

		// Token: 0x060001B0 RID: 432 RVA: 0x00006B08 File Offset: 0x00004D08
		public void InsertTable(int pos, global::NPOI.XWPF.UserModel.XWPFTable table)
		{
			this.bodyElements.Insert(pos, table);
			global::NPOI.OpenXmlFormats.Wordprocessing.CT_Tbl[] tblArray = this.ctDocument.body.GetTblArray();
			int num = 0;
			while (num < tblArray.Length && tblArray[num] != table.GetCTTbl())
			{
				num++;
			}
			this.tables.Insert(num, table);
		}

		// Token: 0x17000091 RID: 145
		// (get) Token: 0x060001B1 RID: 433 RVA: 0x00006B59 File Offset: 0x00004D59
		public global::System.Collections.Generic.IList<global::NPOI.XWPF.UserModel.XWPFPictureData> AllPictures
		{
			get
			{
				return this.pictures.AsReadOnly();
			}
		}

		// Token: 0x17000092 RID: 146
		// (get) Token: 0x060001B2 RID: 434 RVA: 0x00006B68 File Offset: 0x00004D68
		public global::System.Collections.Generic.IList<global::NPOI.XWPF.UserModel.XWPFPictureData> AllPackagePictures
		{
			get
			{
				global::System.Collections.Generic.List<global::NPOI.XWPF.UserModel.XWPFPictureData> list = new global::System.Collections.Generic.List<global::NPOI.XWPF.UserModel.XWPFPictureData>();
				foreach (global::System.Collections.Generic.List<global::NPOI.XWPF.UserModel.XWPFPictureData> collection in this.packagePictures.Values)
				{
					list.AddRange(collection);
				}
				return list.AsReadOnly();
			}
		}

		// Token: 0x060001B3 RID: 435 RVA: 0x00006BCC File Offset: 0x00004DCC
		public void RegisterPackagePictureData(global::NPOI.XWPF.UserModel.XWPFPictureData picData)
		{
			global::System.Collections.Generic.List<global::NPOI.XWPF.UserModel.XWPFPictureData> list = null;
			if (this.packagePictures.ContainsKey(picData.Checksum))
			{
				list = this.packagePictures[picData.Checksum];
			}
			if (list == null)
			{
				list = new global::System.Collections.Generic.List<global::NPOI.XWPF.UserModel.XWPFPictureData>(1);
				this.packagePictures.Add(picData.Checksum, list);
			}
			if (!list.Contains(picData))
			{
				list.Add(picData);
			}
		}

		// Token: 0x060001B4 RID: 436 RVA: 0x00006C2C File Offset: 0x00004E2C
		public global::NPOI.XWPF.UserModel.XWPFPictureData FindPackagePictureData(byte[] pictureData, int format)
		{
			long key = global::NPOI.Util.IOUtils.CalculateChecksum(pictureData);
			global::NPOI.XWPF.UserModel.XWPFPictureData xwpfpictureData = null;
			global::System.Collections.Generic.List<global::NPOI.XWPF.UserModel.XWPFPictureData> list = null;
			if (this.packagePictures.ContainsKey(key))
			{
				list = this.packagePictures[key];
			}
			if (list != null)
			{
				global::System.Collections.Generic.IEnumerator<global::NPOI.XWPF.UserModel.XWPFPictureData> enumerator = list.GetEnumerator();
				while (enumerator.MoveNext() && xwpfpictureData == null)
				{
					global::NPOI.XWPF.UserModel.XWPFPictureData xwpfpictureData2 = enumerator.Current;
					if (global::NPOI.Util.Arrays.Equals(pictureData, xwpfpictureData2.Data))
					{
						xwpfpictureData = xwpfpictureData2;
					}
				}
			}
			return xwpfpictureData;
		}

		// Token: 0x060001B5 RID: 437 RVA: 0x00006C98 File Offset: 0x00004E98
		public string AddPictureData(byte[] pictureData, int format)
		{
			global::NPOI.XWPF.UserModel.XWPFPictureData xwpfpictureData = this.FindPackagePictureData(pictureData, format);
			global::NPOI.POIXMLRelation descriptor = global::NPOI.XWPF.UserModel.XWPFPictureData.RELATIONS[format];
			if (xwpfpictureData == null)
			{
				int nextPicNameNumber = this.GetNextPicNameNumber(format);
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
				this.RegisterPackagePictureData(xwpfpictureData);
				this.pictures.Add(xwpfpictureData);
				return base.GetRelationId(xwpfpictureData);
			}
			if (!base.GetRelations().Contains(xwpfpictureData))
			{
				xwpfpictureData.GetPackagePart();
				return base.AddRelation(null, global::NPOI.XWPF.UserModel.XWPFRelation.IMAGES, xwpfpictureData).Relationship.Id;
			}
			return base.GetRelationId(xwpfpictureData);
		}

		// Token: 0x060001B6 RID: 438 RVA: 0x00006D84 File Offset: 0x00004F84
		public string AddPictureData(global::System.IO.Stream is1, int format)
		{
			string result;
			try
			{
				byte[] pictureData = global::NPOI.Util.IOUtils.ToByteArray(is1);
				result = this.AddPictureData(pictureData, format);
			}
			catch (global::System.IO.IOException ex)
			{
				throw new global::NPOI.POIXMLException(ex);
			}
			return result;
		}

		// Token: 0x060001B7 RID: 439 RVA: 0x00006DBC File Offset: 0x00004FBC
		public int GetNextPicNameNumber(int format)
		{
			int num = this.AllPackagePictures.Count + 1;
			global::NPOI.OpenXml4Net.OPC.PackagePartName partName = global::NPOI.OpenXml4Net.OPC.PackagingUriHelper.CreatePartName(global::NPOI.XWPF.UserModel.XWPFPictureData.RELATIONS[format].GetFileName(num));
			while (base.Package.GetPart(partName) != null)
			{
				num++;
				partName = global::NPOI.OpenXml4Net.OPC.PackagingUriHelper.CreatePartName(global::NPOI.XWPF.UserModel.XWPFPictureData.RELATIONS[format].GetFileName(num));
			}
			return num;
		}

		// Token: 0x060001B8 RID: 440 RVA: 0x00006E14 File Offset: 0x00005014
		public global::NPOI.XWPF.UserModel.XWPFPictureData GetPictureDataByID(string blipID)
		{
			global::NPOI.POIXMLDocumentPart relationById = base.GetRelationById(blipID);
			if (relationById is global::NPOI.XWPF.UserModel.XWPFPictureData)
			{
				return (global::NPOI.XWPF.UserModel.XWPFPictureData)relationById;
			}
			return null;
		}

		// Token: 0x060001B9 RID: 441 RVA: 0x00006E39 File Offset: 0x00005039
		public global::NPOI.XWPF.UserModel.XWPFNumbering GetNumbering()
		{
			if (this.numbering == null)
			{
				this.numbering = new global::NPOI.XWPF.UserModel.XWPFNumbering();
			}
			return this.numbering;
		}

		// Token: 0x060001BA RID: 442 RVA: 0x00006E54 File Offset: 0x00005054
		public global::NPOI.XWPF.UserModel.XWPFStyles GetStyles()
		{
			return this.styles;
		}

		// Token: 0x060001BB RID: 443 RVA: 0x00006E5C File Offset: 0x0000505C
		public global::NPOI.XWPF.UserModel.XWPFParagraph GetParagraph(global::NPOI.OpenXmlFormats.Wordprocessing.CT_P p)
		{
			for (int i = 0; i < this.Paragraphs.Count; i++)
			{
				if (this.Paragraphs[i].GetCTP() == p)
				{
					return this.Paragraphs[i];
				}
			}
			return null;
		}

		// Token: 0x060001BC RID: 444 RVA: 0x00006EA4 File Offset: 0x000050A4
		public global::NPOI.XWPF.UserModel.XWPFTable GetTable(global::NPOI.OpenXmlFormats.Wordprocessing.CT_Tbl ctTbl)
		{
			for (int i = 0; i < this.tables.Count; i++)
			{
				if (this.tables[i].GetCTTbl() == ctTbl)
				{
					return this.tables[i];
				}
			}
			return null;
		}

		// Token: 0x060001BD RID: 445 RVA: 0x00006EE9 File Offset: 0x000050E9
		public global::System.Collections.Generic.IEnumerator<global::NPOI.XWPF.UserModel.XWPFTable> GetTablesEnumerator()
		{
			return this.tables.GetEnumerator();
		}

		// Token: 0x060001BE RID: 446 RVA: 0x00006EFC File Offset: 0x000050FC
		public void ChangeOrientation(global::NPOI.OpenXmlFormats.Wordprocessing.ST_PageOrientation orientation)
		{
			global::NPOI.OpenXmlFormats.Wordprocessing.CT_Body body = this.Document.body;
			if (body.sectPr == null)
			{
				body.AddNewSectPr();
			}
			global::NPOI.OpenXmlFormats.Wordprocessing.CT_SectPr sectPr = body.sectPr;
			this.CreateParagraph().GetCTP().AddNewPPr().sectPr = sectPr;
			global::NPOI.OpenXmlFormats.Wordprocessing.CT_PageSz pgSz = sectPr.pgSz;
			pgSz.orient = orientation;
			if (orientation == global::NPOI.OpenXmlFormats.Wordprocessing.ST_PageOrientation.landscape)
			{
				pgSz.w = 16840UL;
				pgSz.h = 11900UL;
				return;
			}
			pgSz.h = 16840UL;
			pgSz.w = 11900UL;
		}

		// Token: 0x060001BF RID: 447 RVA: 0x00006F83 File Offset: 0x00005183
		public global::System.Collections.Generic.IEnumerator<global::NPOI.XWPF.UserModel.XWPFParagraph> GetParagraphsEnumerator()
		{
			return this.paragraphs.GetEnumerator();
		}

		// Token: 0x060001C0 RID: 448 RVA: 0x00006F95 File Offset: 0x00005195
		public global::NPOI.XWPF.UserModel.XWPFParagraph GetParagraphArray(int pos)
		{
			if (pos >= 0 && pos < this.paragraphs.Count)
			{
				return this.paragraphs[pos];
			}
			return null;
		}

		// Token: 0x17000093 RID: 147
		// (get) Token: 0x060001C1 RID: 449 RVA: 0x00006FB7 File Offset: 0x000051B7
		public global::NPOI.POIXMLDocumentPart Part
		{
			get
			{
				return this;
			}
		}

		// Token: 0x17000094 RID: 148
		// (get) Token: 0x060001C2 RID: 450 RVA: 0x00006FBA File Offset: 0x000051BA
		public global::NPOI.XWPF.UserModel.BodyType PartType
		{
			get
			{
				return global::NPOI.XWPF.UserModel.BodyType.DOCUMENT;
			}
		}

		// Token: 0x060001C3 RID: 451 RVA: 0x00006FC0 File Offset: 0x000051C0
		public global::NPOI.XWPF.UserModel.XWPFTableCell GetTableCell(global::NPOI.OpenXmlFormats.Wordprocessing.CT_Tc cell)
		{
			if (cell == null || !(cell.Parent is global::NPOI.OpenXmlFormats.Wordprocessing.CT_Row))
			{
				return null;
			}
			object parent = ((global::NPOI.OpenXmlFormats.Wordprocessing.CT_Row)cell.Parent).Parent;
			if (parent == null || !(parent is global::NPOI.OpenXmlFormats.Wordprocessing.CT_Tbl))
			{
				return null;
			}
			global::NPOI.XWPF.UserModel.XWPFTable table = this.GetTable((global::NPOI.OpenXmlFormats.Wordprocessing.CT_Tbl)parent);
			if (table == null)
			{
				return null;
			}
			global::NPOI.XWPF.UserModel.XWPFTableRow row = table.GetRow((global::NPOI.OpenXmlFormats.Wordprocessing.CT_Row)cell.Parent);
			if (row == null)
			{
				return null;
			}
			return row.GetTableCell(cell);
		}

		// Token: 0x060001C4 RID: 452 RVA: 0x00006FB7 File Offset: 0x000051B7
		public global::NPOI.XWPF.UserModel.XWPFDocument GetXWPFDocument()
		{
			return this;
		}

		// Token: 0x040001B4 RID: 436
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_Document ctDocument;

		// Token: 0x040001B5 RID: 437
		private global::NPOI.XWPF.UserModel.XWPFSettings Settings;

		// Token: 0x040001B6 RID: 438
		private global::NPOI.Util.IdentifierManager drawingIdManager = new global::NPOI.Util.IdentifierManager(0L, (long)((ulong)-1));

		// Token: 0x040001B7 RID: 439
		protected global::System.Collections.Generic.List<global::NPOI.XWPF.UserModel.XWPFFooter> footers = new global::System.Collections.Generic.List<global::NPOI.XWPF.UserModel.XWPFFooter>();

		// Token: 0x040001B8 RID: 440
		protected global::System.Collections.Generic.List<global::NPOI.XWPF.UserModel.XWPFHeader> headers = new global::System.Collections.Generic.List<global::NPOI.XWPF.UserModel.XWPFHeader>();

		// Token: 0x040001B9 RID: 441
		protected global::System.Collections.Generic.List<global::NPOI.XWPF.UserModel.XWPFComment> comments = new global::System.Collections.Generic.List<global::NPOI.XWPF.UserModel.XWPFComment>();

		// Token: 0x040001BA RID: 442
		protected global::System.Collections.Generic.List<global::NPOI.XWPF.UserModel.XWPFHyperlink> hyperlinks = new global::System.Collections.Generic.List<global::NPOI.XWPF.UserModel.XWPFHyperlink>();

		// Token: 0x040001BB RID: 443
		protected global::System.Collections.Generic.List<global::NPOI.XWPF.UserModel.XWPFParagraph> paragraphs = new global::System.Collections.Generic.List<global::NPOI.XWPF.UserModel.XWPFParagraph>();

		// Token: 0x040001BC RID: 444
		protected global::System.Collections.Generic.List<global::NPOI.XWPF.UserModel.XWPFTable> tables = new global::System.Collections.Generic.List<global::NPOI.XWPF.UserModel.XWPFTable>();

		// Token: 0x040001BD RID: 445
		protected global::System.Collections.Generic.List<global::NPOI.XWPF.UserModel.XWPFSDT> contentControls = new global::System.Collections.Generic.List<global::NPOI.XWPF.UserModel.XWPFSDT>();

		// Token: 0x040001BE RID: 446
		protected global::System.Collections.Generic.List<global::NPOI.XWPF.UserModel.IBodyElement> bodyElements = new global::System.Collections.Generic.List<global::NPOI.XWPF.UserModel.IBodyElement>();

		// Token: 0x040001BF RID: 447
		protected global::System.Collections.Generic.List<global::NPOI.XWPF.UserModel.XWPFPictureData> pictures = new global::System.Collections.Generic.List<global::NPOI.XWPF.UserModel.XWPFPictureData>();

		// Token: 0x040001C0 RID: 448
		protected global::System.Collections.Generic.Dictionary<long, global::System.Collections.Generic.List<global::NPOI.XWPF.UserModel.XWPFPictureData>> packagePictures = new global::System.Collections.Generic.Dictionary<long, global::System.Collections.Generic.List<global::NPOI.XWPF.UserModel.XWPFPictureData>>();

		// Token: 0x040001C1 RID: 449
		protected global::System.Collections.Generic.Dictionary<int, global::NPOI.XWPF.UserModel.XWPFFootnote> endnotes = new global::System.Collections.Generic.Dictionary<int, global::NPOI.XWPF.UserModel.XWPFFootnote>();

		// Token: 0x040001C2 RID: 450
		protected global::NPOI.XWPF.UserModel.XWPFNumbering numbering;

		// Token: 0x040001C3 RID: 451
		protected global::NPOI.XWPF.UserModel.XWPFStyles styles;

		// Token: 0x040001C4 RID: 452
		protected global::NPOI.XWPF.UserModel.XWPFFootnotes footnotes;

		// Token: 0x040001C5 RID: 453
		private global::NPOI.XWPF.Model.XWPFHeaderFooterPolicy headerFooterPolicy;
	}
}
