using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXmlFormats.Vml;
using NPOI.OpenXmlFormats.Vml.Office;
using NPOI.OpenXmlFormats.Wordprocessing;
using NPOI.XWPF.UserModel;

namespace NPOI.XWPF.Model
{
	// Token: 0x02000054 RID: 84
	public class XWPFHeaderFooterPolicy
	{
		// Token: 0x060003CE RID: 974 RVA: 0x0000F390 File Offset: 0x0000D590
		public XWPFHeaderFooterPolicy(global::NPOI.XWPF.UserModel.XWPFDocument doc) : this(doc, doc.Document.body.sectPr)
		{
		}

		// Token: 0x060003CF RID: 975 RVA: 0x0000F3AC File Offset: 0x0000D5AC
		public XWPFHeaderFooterPolicy(global::NPOI.XWPF.UserModel.XWPFDocument doc, global::NPOI.OpenXmlFormats.Wordprocessing.CT_SectPr sectPr)
		{
			this.doc = doc;
			for (int i = 0; i < sectPr.SizeOfHeaderReferenceArray(); i++)
			{
				global::NPOI.OpenXmlFormats.Wordprocessing.CT_HdrFtrRef headerReferenceArray = sectPr.GetHeaderReferenceArray(i);
				global::NPOI.POIXMLDocumentPart relationById = doc.GetRelationById(headerReferenceArray.id);
				global::NPOI.XWPF.UserModel.XWPFHeader hdr = null;
				if (relationById != null && relationById is global::NPOI.XWPF.UserModel.XWPFHeader)
				{
					hdr = (global::NPOI.XWPF.UserModel.XWPFHeader)relationById;
				}
				global::NPOI.OpenXmlFormats.Wordprocessing.ST_HdrFtr type = headerReferenceArray.type;
				this.assignHeader(hdr, type);
			}
			for (int j = 0; j < sectPr.SizeOfFooterReferenceArray(); j++)
			{
				global::NPOI.OpenXmlFormats.Wordprocessing.CT_HdrFtrRef footerReferenceArray = sectPr.GetFooterReferenceArray(j);
				global::NPOI.POIXMLDocumentPart relationById2 = doc.GetRelationById(footerReferenceArray.id);
				global::NPOI.XWPF.UserModel.XWPFFooter ftr = null;
				if (relationById2 != null && relationById2 is global::NPOI.XWPF.UserModel.XWPFFooter)
				{
					ftr = (global::NPOI.XWPF.UserModel.XWPFFooter)relationById2;
				}
				global::NPOI.OpenXmlFormats.Wordprocessing.ST_HdrFtr type2 = footerReferenceArray.type;
				this.assignFooter(ftr, type2);
			}
		}

		// Token: 0x060003D0 RID: 976 RVA: 0x0000F46B File Offset: 0x0000D66B
		private void assignFooter(global::NPOI.XWPF.UserModel.XWPFFooter ftr, global::NPOI.OpenXmlFormats.Wordprocessing.ST_HdrFtr type)
		{
			if (type == global::NPOI.OpenXmlFormats.Wordprocessing.ST_HdrFtr.first)
			{
				this.firstPageFooter = ftr;
				return;
			}
			if (type == global::NPOI.OpenXmlFormats.Wordprocessing.ST_HdrFtr.even)
			{
				this.evenPageFooter = ftr;
				return;
			}
			this.defaultFooter = ftr;
		}

		// Token: 0x060003D1 RID: 977 RVA: 0x0000F48B File Offset: 0x0000D68B
		private void assignHeader(global::NPOI.XWPF.UserModel.XWPFHeader hdr, global::NPOI.OpenXmlFormats.Wordprocessing.ST_HdrFtr type)
		{
			if (type == global::NPOI.OpenXmlFormats.Wordprocessing.ST_HdrFtr.first)
			{
				this.firstPageHeader = hdr;
				return;
			}
			if (type == global::NPOI.OpenXmlFormats.Wordprocessing.ST_HdrFtr.even)
			{
				this.evenPageHeader = hdr;
				return;
			}
			this.defaultHeader = hdr;
		}

		// Token: 0x060003D2 RID: 978 RVA: 0x0000F4AB File Offset: 0x0000D6AB
		public global::NPOI.XWPF.UserModel.XWPFHeader CreateHeader(global::NPOI.OpenXmlFormats.Wordprocessing.ST_HdrFtr type)
		{
			return this.CreateHeader(type, null);
		}

		// Token: 0x060003D3 RID: 979 RVA: 0x0000F4B8 File Offset: 0x0000D6B8
		public global::NPOI.XWPF.UserModel.XWPFHeader CreateHeader(global::NPOI.OpenXmlFormats.Wordprocessing.ST_HdrFtr type, global::NPOI.XWPF.UserModel.XWPFParagraph[] pars)
		{
			global::NPOI.XWPF.UserModel.XWPFRelation header = global::NPOI.XWPF.UserModel.XWPFRelation.HEADER;
			string pStyle = "Header";
			int relationIndex = this.GetRelationIndex(header);
			global::NPOI.OpenXmlFormats.Wordprocessing.HdrDocument hdrDocument = new global::NPOI.OpenXmlFormats.Wordprocessing.HdrDocument();
			global::NPOI.XWPF.UserModel.XWPFHeader xwpfheader = (global::NPOI.XWPF.UserModel.XWPFHeader)this.doc.CreateRelationship(header, global::NPOI.XWPF.UserModel.XWPFFactory.GetInstance(), relationIndex);
			xwpfheader.SetXWPFDocument(this.doc);
			global::NPOI.OpenXmlFormats.Wordprocessing.CT_HdrFtr ct_HdrFtr = this.buildHdr(type, pStyle, xwpfheader, pars);
			xwpfheader.SetHeaderFooter(ct_HdrFtr);
			hdrDocument.SetHdr((global::NPOI.OpenXmlFormats.Wordprocessing.CT_Hdr)ct_HdrFtr);
			this.assignHeader(xwpfheader, type);
			using (global::System.IO.Stream outputStream = xwpfheader.GetPackagePart().GetOutputStream())
			{
				hdrDocument.Save(outputStream);
			}
			return xwpfheader;
		}

		// Token: 0x060003D4 RID: 980 RVA: 0x0000F568 File Offset: 0x0000D768
		public global::NPOI.XWPF.UserModel.XWPFFooter CreateFooter(global::NPOI.OpenXmlFormats.Wordprocessing.ST_HdrFtr type)
		{
			return this.CreateFooter(type, null);
		}

		// Token: 0x060003D5 RID: 981 RVA: 0x0000F574 File Offset: 0x0000D774
		public global::NPOI.XWPF.UserModel.XWPFFooter CreateFooter(global::NPOI.OpenXmlFormats.Wordprocessing.ST_HdrFtr type, global::NPOI.XWPF.UserModel.XWPFParagraph[] pars)
		{
			global::NPOI.XWPF.UserModel.XWPFRelation footer = global::NPOI.XWPF.UserModel.XWPFRelation.FOOTER;
			string pStyle = "Footer";
			int relationIndex = this.GetRelationIndex(footer);
			global::NPOI.OpenXmlFormats.Wordprocessing.FtrDocument ftrDocument = new global::NPOI.OpenXmlFormats.Wordprocessing.FtrDocument();
			global::NPOI.XWPF.UserModel.XWPFFooter xwpffooter = (global::NPOI.XWPF.UserModel.XWPFFooter)this.doc.CreateRelationship(footer, global::NPOI.XWPF.UserModel.XWPFFactory.GetInstance(), relationIndex);
			xwpffooter.SetXWPFDocument(this.doc);
			global::NPOI.OpenXmlFormats.Wordprocessing.CT_HdrFtr ct_HdrFtr = this.buildFtr(type, pStyle, xwpffooter, pars);
			xwpffooter.SetHeaderFooter(ct_HdrFtr);
			ftrDocument.SetFtr((global::NPOI.OpenXmlFormats.Wordprocessing.CT_Ftr)ct_HdrFtr);
			this.assignFooter(xwpffooter, type);
			using (global::System.IO.Stream outputStream = xwpffooter.GetPackagePart().GetOutputStream())
			{
				ftrDocument.Save(outputStream);
			}
			return xwpffooter;
		}

		// Token: 0x060003D6 RID: 982 RVA: 0x0000F624 File Offset: 0x0000D824
		private int GetRelationIndex(global::NPOI.XWPF.UserModel.XWPFRelation relation)
		{
			int num = 1;
			using (global::System.Collections.Generic.List<global::NPOI.POIXMLDocumentPart.RelationPart>.Enumerator enumerator = this.doc.RelationParts.GetEnumerator())
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

		// Token: 0x060003D7 RID: 983 RVA: 0x0000F694 File Offset: 0x0000D894
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_HdrFtr buildFtr(global::NPOI.OpenXmlFormats.Wordprocessing.ST_HdrFtr type, string pStyle, global::NPOI.XWPF.UserModel.XWPFHeaderFooter wrapper, global::NPOI.XWPF.UserModel.XWPFParagraph[] pars)
		{
			global::NPOI.OpenXmlFormats.Wordprocessing.CT_HdrFtr result = this.buildHdrFtr(pStyle, pars, wrapper);
			this.SetFooterReference(type, wrapper);
			return result;
		}

		// Token: 0x060003D8 RID: 984 RVA: 0x0000F6A8 File Offset: 0x0000D8A8
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_HdrFtr buildHdr(global::NPOI.OpenXmlFormats.Wordprocessing.ST_HdrFtr type, string pStyle, global::NPOI.XWPF.UserModel.XWPFHeaderFooter wrapper, global::NPOI.XWPF.UserModel.XWPFParagraph[] pars)
		{
			global::NPOI.OpenXmlFormats.Wordprocessing.CT_HdrFtr result = this.buildHdrFtr(pStyle, pars, wrapper);
			this.SetHeaderReference(type, wrapper);
			return result;
		}

		// Token: 0x060003D9 RID: 985 RVA: 0x0000F6BC File Offset: 0x0000D8BC
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_HdrFtr buildHdrFtr(string pStyle, global::NPOI.XWPF.UserModel.XWPFParagraph[] paragraphs, global::NPOI.XWPF.UserModel.XWPFHeaderFooter wrapper)
		{
			global::NPOI.OpenXmlFormats.Wordprocessing.CT_HdrFtr ct_HdrFtr = wrapper._getHdrFtr();
			if (paragraphs != null)
			{
				for (int i = 0; i < paragraphs.Length; i++)
				{
					ct_HdrFtr.AddNewP();
					ct_HdrFtr.SetPArray(i, paragraphs[i].GetCTP());
				}
			}
			else
			{
				global::NPOI.OpenXmlFormats.Wordprocessing.CT_P ct_P = ct_HdrFtr.AddNewP();
				global::NPOI.OpenXmlFormats.Wordprocessing.CT_Body body = this.doc.Document.body;
				if (body.SizeOfPArray() > 0)
				{
					global::NPOI.OpenXmlFormats.Wordprocessing.CT_P parray = body.GetPArray(0);
					if (parray.IsSetRsidR())
					{
						byte[] rsidR = parray.rsidR;
						byte[] rsidRDefault = parray.rsidRDefault;
						ct_P.rsidP = rsidR;
						ct_P.rsidRDefault = rsidRDefault;
					}
				}
				ct_P.AddNewPPr().AddNewPStyle().val = pStyle;
			}
			return ct_HdrFtr;
		}

		// Token: 0x060003DA RID: 986 RVA: 0x0000F760 File Offset: 0x0000D960
		private void SetFooterReference(global::NPOI.OpenXmlFormats.Wordprocessing.ST_HdrFtr type, global::NPOI.XWPF.UserModel.XWPFHeaderFooter wrapper)
		{
			global::NPOI.OpenXmlFormats.Wordprocessing.CT_HdrFtrRef ct_HdrFtrRef = this.doc.Document.body.sectPr.AddNewFooterReference();
			ct_HdrFtrRef.type = type;
			ct_HdrFtrRef.id = this.doc.GetRelationId(wrapper);
		}

		// Token: 0x060003DB RID: 987 RVA: 0x0000F794 File Offset: 0x0000D994
		private void SetHeaderReference(global::NPOI.OpenXmlFormats.Wordprocessing.ST_HdrFtr type, global::NPOI.XWPF.UserModel.XWPFHeaderFooter wrapper)
		{
			global::NPOI.OpenXmlFormats.Wordprocessing.CT_HdrFtrRef ct_HdrFtrRef = this.doc.Document.body.sectPr.AddNewHeaderReference();
			ct_HdrFtrRef.type = type;
			ct_HdrFtrRef.id = this.doc.GetRelationId(wrapper);
		}

		// Token: 0x060003DC RID: 988 RVA: 0x0000F7C8 File Offset: 0x0000D9C8
		private global::System.Xml.Serialization.XmlSerializerNamespaces Commit(global::NPOI.XWPF.UserModel.XWPFHeaderFooter wrapper)
		{
			return new global::System.Xml.Serialization.XmlSerializerNamespaces(new global::System.Xml.XmlQualifiedName[]
			{
				new global::System.Xml.XmlQualifiedName("ve", "http://schemas.openxmlformats.org/markup-compatibility/2006"),
				new global::System.Xml.XmlQualifiedName("r", "http://schemas.openxmlformats.org/officeDocument/2006/relationships"),
				new global::System.Xml.XmlQualifiedName("m", "http://schemas.openxmlformats.org/officeDocument/2006/math"),
				new global::System.Xml.XmlQualifiedName("v", "urn:schemas-microsoft-com:vml"),
				new global::System.Xml.XmlQualifiedName("wp", "http://schemas.openxmlformats.org/drawingml/2006/wordprocessingDrawing"),
				new global::System.Xml.XmlQualifiedName("w10", "urn:schemas-microsoft-com:office:word"),
				new global::System.Xml.XmlQualifiedName("wne", "http://schemas.microsoft.com/office/word/2006/wordml"),
				new global::System.Xml.XmlQualifiedName("w", "http://schemas.openxmlformats.org/wordprocessingml/2006/main")
			});
		}

		// Token: 0x060003DD RID: 989 RVA: 0x0000F870 File Offset: 0x0000DA70
		public global::NPOI.XWPF.UserModel.XWPFHeader GetFirstPageHeader()
		{
			return this.firstPageHeader;
		}

		// Token: 0x060003DE RID: 990 RVA: 0x0000F878 File Offset: 0x0000DA78
		public global::NPOI.XWPF.UserModel.XWPFFooter GetFirstPageFooter()
		{
			return this.firstPageFooter;
		}

		// Token: 0x060003DF RID: 991 RVA: 0x0000F880 File Offset: 0x0000DA80
		public global::NPOI.XWPF.UserModel.XWPFHeader GetOddPageHeader()
		{
			return this.defaultHeader;
		}

		// Token: 0x060003E0 RID: 992 RVA: 0x0000F888 File Offset: 0x0000DA88
		public global::NPOI.XWPF.UserModel.XWPFFooter GetOddPageFooter()
		{
			return this.defaultFooter;
		}

		// Token: 0x060003E1 RID: 993 RVA: 0x0000F890 File Offset: 0x0000DA90
		public global::NPOI.XWPF.UserModel.XWPFHeader GetEvenPageHeader()
		{
			return this.evenPageHeader;
		}

		// Token: 0x060003E2 RID: 994 RVA: 0x0000F898 File Offset: 0x0000DA98
		public global::NPOI.XWPF.UserModel.XWPFFooter GetEvenPageFooter()
		{
			return this.evenPageFooter;
		}

		// Token: 0x060003E3 RID: 995 RVA: 0x0000F880 File Offset: 0x0000DA80
		public global::NPOI.XWPF.UserModel.XWPFHeader GetDefaultHeader()
		{
			return this.defaultHeader;
		}

		// Token: 0x060003E4 RID: 996 RVA: 0x0000F888 File Offset: 0x0000DA88
		public global::NPOI.XWPF.UserModel.XWPFFooter GetDefaultFooter()
		{
			return this.defaultFooter;
		}

		// Token: 0x060003E5 RID: 997 RVA: 0x0000F8A0 File Offset: 0x0000DAA0
		public global::NPOI.XWPF.UserModel.XWPFHeader GetHeader(int pageNumber)
		{
			if (pageNumber == 1 && this.firstPageHeader != null)
			{
				return this.firstPageHeader;
			}
			if (pageNumber % 2 == 0 && this.evenPageHeader != null)
			{
				return this.evenPageHeader;
			}
			return this.defaultHeader;
		}

		// Token: 0x060003E6 RID: 998 RVA: 0x0000F8CF File Offset: 0x0000DACF
		public global::NPOI.XWPF.UserModel.XWPFFooter GetFooter(int pageNumber)
		{
			if (pageNumber == 1 && this.firstPageFooter != null)
			{
				return this.firstPageFooter;
			}
			if (pageNumber % 2 == 0 && this.evenPageFooter != null)
			{
				return this.evenPageFooter;
			}
			return this.defaultFooter;
		}

		// Token: 0x060003E7 RID: 999 RVA: 0x0000F900 File Offset: 0x0000DB00
		public void CreateWatermark(string text)
		{
			global::NPOI.XWPF.UserModel.XWPFParagraph[] array = new global::NPOI.XWPF.UserModel.XWPFParagraph[1];
			try
			{
				array[0] = this.GetWatermarkParagraph(text, 1);
				this.CreateHeader(global::NPOI.XWPF.Model.XWPFHeaderFooterPolicy.DEFAULT, array);
				array[0] = this.GetWatermarkParagraph(text, 2);
				this.CreateHeader(global::NPOI.XWPF.Model.XWPFHeaderFooterPolicy.FIRST, array);
				array[0] = this.GetWatermarkParagraph(text, 3);
				this.CreateHeader(global::NPOI.XWPF.Model.XWPFHeaderFooterPolicy.EVEN, array);
			}
			catch (global::System.IO.IOException ex)
			{
				global::System.Diagnostics.Trace.Write(ex.StackTrace);
			}
		}

		// Token: 0x060003E8 RID: 1000 RVA: 0x0000F97C File Offset: 0x0000DB7C
		private global::NPOI.XWPF.UserModel.XWPFParagraph GetWatermarkParagraph(string text, int idx)
		{
			global::NPOI.OpenXmlFormats.Wordprocessing.CT_P ct_P = new global::NPOI.OpenXmlFormats.Wordprocessing.CT_P();
			byte[] rsidR = this.doc.Document.body.GetPArray(0).rsidR;
			byte[] rsidRDefault = this.doc.Document.body.GetPArray(0).rsidRDefault;
			ct_P.rsidP = rsidR;
			ct_P.rsidRDefault = rsidRDefault;
			ct_P.AddNewPPr().AddNewPStyle().val = "Header";
			global::NPOI.OpenXmlFormats.Wordprocessing.CT_R ct_R = ct_P.AddNewR();
			ct_R.AddNewRPr().AddNewNoProof();
			global::NPOI.OpenXmlFormats.Wordprocessing.CT_PictureBase ct_PictureBase = ct_R.AddNewPict();
			global::NPOI.OpenXmlFormats.Vml.CT_Group ct_Group = new global::NPOI.OpenXmlFormats.Vml.CT_Group();
			global::NPOI.OpenXmlFormats.Vml.CT_Shapetype ct_Shapetype = ct_Group.AddNewShapetype();
			ct_Shapetype.id = "_x0000_t136";
			ct_Shapetype.coordsize = "1600,21600";
			ct_Shapetype.spt = 136f;
			ct_Shapetype.adj = "10800";
			ct_Shapetype.path2 = "m@7,0l@8,0m@5,21600l@6,21600e";
			global::NPOI.OpenXmlFormats.Vml.CT_Formulas ct_Formulas = ct_Shapetype.AddNewFormulas();
			ct_Formulas.AddNewF().eqn = "sum #0 0 10800";
			ct_Formulas.AddNewF().eqn = "prod #0 2 1";
			ct_Formulas.AddNewF().eqn = "sum 21600 0 @1";
			ct_Formulas.AddNewF().eqn = "sum 0 0 @2";
			ct_Formulas.AddNewF().eqn = "sum 21600 0 @3";
			ct_Formulas.AddNewF().eqn = "if @0 @3 0";
			ct_Formulas.AddNewF().eqn = "if @0 21600 @1";
			ct_Formulas.AddNewF().eqn = "if @0 0 @2";
			ct_Formulas.AddNewF().eqn = "if @0 @4 21600";
			ct_Formulas.AddNewF().eqn = "mid @5 @6";
			ct_Formulas.AddNewF().eqn = "mid @8 @5";
			ct_Formulas.AddNewF().eqn = "mid @7 @8";
			ct_Formulas.AddNewF().eqn = "mid @6 @7";
			ct_Formulas.AddNewF().eqn = "sum @6 0 @5";
			global::NPOI.OpenXmlFormats.Vml.CT_Path ct_Path = ct_Shapetype.AddNewPath();
			ct_Path.textpathok = global::NPOI.OpenXmlFormats.Vml.ST_TrueFalse.t;
			ct_Path.connecttype = global::NPOI.OpenXmlFormats.Vml.Office.ST_ConnectType.custom;
			ct_Path.connectlocs = "@9,0;@10,10800;@11,21600;@12,10800";
			ct_Path.connectangles = "270,180,90,0";
			global::NPOI.OpenXmlFormats.Vml.CT_TextPath ct_TextPath = ct_Shapetype.AddNewTextpath();
			ct_TextPath.on = global::NPOI.OpenXmlFormats.Vml.ST_TrueFalse.t;
			ct_TextPath.fitshape = global::NPOI.OpenXmlFormats.Vml.ST_TrueFalse.t;
			global::NPOI.OpenXmlFormats.Vml.CT_H ct_H = ct_Shapetype.AddNewHandles().AddNewH();
			ct_H.position = "#0,bottomRight";
			ct_H.xrange = "6629,14971";
			ct_Shapetype.AddNewLock().ext = global::NPOI.OpenXmlFormats.Vml.ST_Ext.edit;
			global::NPOI.OpenXmlFormats.Vml.CT_Shape ct_Shape = ct_Group.AddNewShape();
			ct_Shape.id = "PowerPlusWaterMarkObject" + idx.ToString();
			ct_Shape.spid = "_x0000_s102" + (4 + idx).ToString();
			ct_Shape.type = "#_x0000_t136";
			ct_Shape.style = "position:absolute;left:0;text-align:left;margin-left:0;margin-top:0;width:415pt;height:73.15pt;rotation:315;z-index:-251654144;mso-wrap-edited:f;mso-position-horizontal:center;mso-position-horizontal-relative:margin;mso-position-vertical:center;mso-position-vertical-relative:margin";
			ct_Shape.fillcolor = "silver";
			ct_Shape.stroked = global::NPOI.OpenXmlFormats.Vml.ST_TrueFalse.@false;
			global::NPOI.OpenXmlFormats.Vml.CT_TextPath ct_TextPath2 = ct_Shape.AddNewTextpath();
			ct_TextPath2.style = "font-family:\"Cambria\";;font-size:1pt";
			ct_TextPath2.@string = text;
			ct_Shape.AddNewFill().opacity = ".5";
			ct_PictureBase.Set(ct_Group);
			return new global::NPOI.XWPF.UserModel.XWPFParagraph(ct_P, this.doc);
		}

		// Token: 0x0400023C RID: 572
		public static global::NPOI.OpenXmlFormats.Wordprocessing.ST_HdrFtr DEFAULT = global::NPOI.OpenXmlFormats.Wordprocessing.ST_HdrFtr.@default;

		// Token: 0x0400023D RID: 573
		public static global::NPOI.OpenXmlFormats.Wordprocessing.ST_HdrFtr EVEN = global::NPOI.OpenXmlFormats.Wordprocessing.ST_HdrFtr.even;

		// Token: 0x0400023E RID: 574
		public static global::NPOI.OpenXmlFormats.Wordprocessing.ST_HdrFtr FIRST = global::NPOI.OpenXmlFormats.Wordprocessing.ST_HdrFtr.first;

		// Token: 0x0400023F RID: 575
		private global::NPOI.XWPF.UserModel.XWPFDocument doc;

		// Token: 0x04000240 RID: 576
		private global::NPOI.XWPF.UserModel.XWPFHeader firstPageHeader;

		// Token: 0x04000241 RID: 577
		private global::NPOI.XWPF.UserModel.XWPFFooter firstPageFooter;

		// Token: 0x04000242 RID: 578
		private global::NPOI.XWPF.UserModel.XWPFHeader evenPageHeader;

		// Token: 0x04000243 RID: 579
		private global::NPOI.XWPF.UserModel.XWPFFooter evenPageFooter;

		// Token: 0x04000244 RID: 580
		private global::NPOI.XWPF.UserModel.XWPFHeader defaultHeader;

		// Token: 0x04000245 RID: 581
		private global::NPOI.XWPF.UserModel.XWPFFooter defaultFooter;
	}
}
