using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Wordprocessing
{
	// Token: 0x02000160 RID: 352
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_SectPr
	{
		// Token: 0x06000A82 RID: 2690 RVA: 0x00024FA4 File Offset: 0x000231A4
		public CT_SectPr()
		{
			this.docGridField = new global::NPOI.OpenXmlFormats.Wordprocessing.CT_DocGrid();
			this.docGrid.type = global::NPOI.OpenXmlFormats.Wordprocessing.ST_DocGrid.lines;
			this.docGrid.typeSpecified = true;
			this.docGrid.linePitch = "312";
			this.colsField = new global::NPOI.OpenXmlFormats.Wordprocessing.CT_Columns();
			this.cols.space = 425UL;
			this.cols.spaceSpecified = true;
			this.pgMarField = new global::NPOI.OpenXmlFormats.Wordprocessing.CT_PageMar();
			this.pgMar.top = "1440";
			this.pgMar.right = 1800UL;
			this.pgMar.bottom = "1440";
			this.pgMar.left = 1800UL;
			this.pgMar.header = 851UL;
			this.pgMar.footer = 992UL;
			this.pgMar.gutter = 0UL;
			this.pgSzField = new global::NPOI.OpenXmlFormats.Wordprocessing.CT_PageSz();
			this.pgSz.w = 11906UL;
			this.pgSz.wSpecified = true;
			this.pgSz.h = 16838UL;
			this.pgSz.hSpecified = true;
		}

		// Token: 0x1700037C RID: 892
		// (get) Token: 0x06000A83 RID: 2691 RVA: 0x000250D3 File Offset: 0x000232D3
		// (set) Token: 0x06000A84 RID: 2692 RVA: 0x000250DB File Offset: 0x000232DB
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.CT_HdrFtrRef> footerReference
		{
			get
			{
				return this.footerReferenceField;
			}
			set
			{
				this.footerReferenceField = value;
			}
		}

		// Token: 0x1700037D RID: 893
		// (get) Token: 0x06000A85 RID: 2693 RVA: 0x000250E4 File Offset: 0x000232E4
		// (set) Token: 0x06000A86 RID: 2694 RVA: 0x000250EC File Offset: 0x000232EC
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.CT_HdrFtrRef> headerReference
		{
			get
			{
				return this.headerReferenceField;
			}
			set
			{
				this.headerReferenceField = value;
			}
		}

		// Token: 0x1700037E RID: 894
		// (get) Token: 0x06000A87 RID: 2695 RVA: 0x000250F5 File Offset: 0x000232F5
		// (set) Token: 0x06000A88 RID: 2696 RVA: 0x000250FD File Offset: 0x000232FD
		[global::System.Xml.Serialization.XmlElement(Order = 2)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_FtnProps footnotePr
		{
			get
			{
				return this.footnotePrField;
			}
			set
			{
				this.footnotePrField = value;
			}
		}

		// Token: 0x1700037F RID: 895
		// (get) Token: 0x06000A89 RID: 2697 RVA: 0x00025106 File Offset: 0x00023306
		// (set) Token: 0x06000A8A RID: 2698 RVA: 0x0002510E File Offset: 0x0002330E
		[global::System.Xml.Serialization.XmlElement(Order = 3)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_EdnProps endnotePr
		{
			get
			{
				return this.endnotePrField;
			}
			set
			{
				this.endnotePrField = value;
			}
		}

		// Token: 0x17000380 RID: 896
		// (get) Token: 0x06000A8B RID: 2699 RVA: 0x00025117 File Offset: 0x00023317
		// (set) Token: 0x06000A8C RID: 2700 RVA: 0x0002511F File Offset: 0x0002331F
		[global::System.Xml.Serialization.XmlElement(Order = 4)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_SectType type
		{
			get
			{
				return this.typeField;
			}
			set
			{
				this.typeField = value;
			}
		}

		// Token: 0x17000381 RID: 897
		// (get) Token: 0x06000A8D RID: 2701 RVA: 0x00025128 File Offset: 0x00023328
		// (set) Token: 0x06000A8E RID: 2702 RVA: 0x00025130 File Offset: 0x00023330
		[global::System.Xml.Serialization.XmlElement(Order = 5)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_PageSz pgSz
		{
			get
			{
				return this.pgSzField;
			}
			set
			{
				this.pgSzField = value;
			}
		}

		// Token: 0x17000382 RID: 898
		// (get) Token: 0x06000A8F RID: 2703 RVA: 0x00025139 File Offset: 0x00023339
		// (set) Token: 0x06000A90 RID: 2704 RVA: 0x00025141 File Offset: 0x00023341
		[global::System.Xml.Serialization.XmlElement(Order = 6)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_PageMar pgMar
		{
			get
			{
				return this.pgMarField;
			}
			set
			{
				this.pgMarField = value;
			}
		}

		// Token: 0x17000383 RID: 899
		// (get) Token: 0x06000A91 RID: 2705 RVA: 0x0002514A File Offset: 0x0002334A
		// (set) Token: 0x06000A92 RID: 2706 RVA: 0x00025152 File Offset: 0x00023352
		[global::System.Xml.Serialization.XmlElement(Order = 7)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_PaperSource paperSrc
		{
			get
			{
				return this.paperSrcField;
			}
			set
			{
				this.paperSrcField = value;
			}
		}

		// Token: 0x17000384 RID: 900
		// (get) Token: 0x06000A93 RID: 2707 RVA: 0x0002515B File Offset: 0x0002335B
		// (set) Token: 0x06000A94 RID: 2708 RVA: 0x00025163 File Offset: 0x00023363
		[global::System.Xml.Serialization.XmlElement(Order = 8)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_PageBorders pgBorders
		{
			get
			{
				return this.pgBordersField;
			}
			set
			{
				this.pgBordersField = value;
			}
		}

		// Token: 0x17000385 RID: 901
		// (get) Token: 0x06000A95 RID: 2709 RVA: 0x0002516C File Offset: 0x0002336C
		// (set) Token: 0x06000A96 RID: 2710 RVA: 0x00025174 File Offset: 0x00023374
		[global::System.Xml.Serialization.XmlElement(Order = 9)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_LineNumber lnNumType
		{
			get
			{
				return this.lnNumTypeField;
			}
			set
			{
				this.lnNumTypeField = value;
			}
		}

		// Token: 0x17000386 RID: 902
		// (get) Token: 0x06000A97 RID: 2711 RVA: 0x0002517D File Offset: 0x0002337D
		// (set) Token: 0x06000A98 RID: 2712 RVA: 0x00025185 File Offset: 0x00023385
		[global::System.Xml.Serialization.XmlElement(Order = 10)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_PageNumber pgNumType
		{
			get
			{
				return this.pgNumTypeField;
			}
			set
			{
				this.pgNumTypeField = value;
			}
		}

		// Token: 0x17000387 RID: 903
		// (get) Token: 0x06000A99 RID: 2713 RVA: 0x0002518E File Offset: 0x0002338E
		// (set) Token: 0x06000A9A RID: 2714 RVA: 0x00025196 File Offset: 0x00023396
		[global::System.Xml.Serialization.XmlElement(Order = 11)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_Columns cols
		{
			get
			{
				return this.colsField;
			}
			set
			{
				this.colsField = value;
			}
		}

		// Token: 0x17000388 RID: 904
		// (get) Token: 0x06000A9B RID: 2715 RVA: 0x0002519F File Offset: 0x0002339F
		// (set) Token: 0x06000A9C RID: 2716 RVA: 0x000251A7 File Offset: 0x000233A7
		[global::System.Xml.Serialization.XmlElement(Order = 12)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff formProt
		{
			get
			{
				return this.formProtField;
			}
			set
			{
				this.formProtField = value;
			}
		}

		// Token: 0x17000389 RID: 905
		// (get) Token: 0x06000A9D RID: 2717 RVA: 0x000251B0 File Offset: 0x000233B0
		// (set) Token: 0x06000A9E RID: 2718 RVA: 0x000251B8 File Offset: 0x000233B8
		[global::System.Xml.Serialization.XmlElement(Order = 13)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_VerticalJc vAlign
		{
			get
			{
				return this.vAlignField;
			}
			set
			{
				this.vAlignField = value;
			}
		}

		// Token: 0x1700038A RID: 906
		// (get) Token: 0x06000A9F RID: 2719 RVA: 0x000251C1 File Offset: 0x000233C1
		// (set) Token: 0x06000AA0 RID: 2720 RVA: 0x000251C9 File Offset: 0x000233C9
		[global::System.Xml.Serialization.XmlElement(Order = 14)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff noEndnote
		{
			get
			{
				return this.noEndnoteField;
			}
			set
			{
				this.noEndnoteField = value;
			}
		}

		// Token: 0x1700038B RID: 907
		// (get) Token: 0x06000AA1 RID: 2721 RVA: 0x000251D2 File Offset: 0x000233D2
		// (set) Token: 0x06000AA2 RID: 2722 RVA: 0x000251DA File Offset: 0x000233DA
		[global::System.Xml.Serialization.XmlElement(Order = 15)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff titlePg
		{
			get
			{
				return this.titlePgField;
			}
			set
			{
				this.titlePgField = value;
			}
		}

		// Token: 0x1700038C RID: 908
		// (get) Token: 0x06000AA3 RID: 2723 RVA: 0x000251E3 File Offset: 0x000233E3
		// (set) Token: 0x06000AA4 RID: 2724 RVA: 0x000251EB File Offset: 0x000233EB
		[global::System.Xml.Serialization.XmlElement(Order = 16)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_TextDirection textDirection
		{
			get
			{
				return this.textDirectionField;
			}
			set
			{
				this.textDirectionField = value;
			}
		}

		// Token: 0x1700038D RID: 909
		// (get) Token: 0x06000AA5 RID: 2725 RVA: 0x000251F4 File Offset: 0x000233F4
		// (set) Token: 0x06000AA6 RID: 2726 RVA: 0x000251FC File Offset: 0x000233FC
		[global::System.Xml.Serialization.XmlElement(Order = 17)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff bidi
		{
			get
			{
				return this.bidiField;
			}
			set
			{
				this.bidiField = value;
			}
		}

		// Token: 0x1700038E RID: 910
		// (get) Token: 0x06000AA7 RID: 2727 RVA: 0x00025205 File Offset: 0x00023405
		// (set) Token: 0x06000AA8 RID: 2728 RVA: 0x0002520D File Offset: 0x0002340D
		[global::System.Xml.Serialization.XmlElement(Order = 18)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff rtlGutter
		{
			get
			{
				return this.rtlGutterField;
			}
			set
			{
				this.rtlGutterField = value;
			}
		}

		// Token: 0x1700038F RID: 911
		// (get) Token: 0x06000AA9 RID: 2729 RVA: 0x00025216 File Offset: 0x00023416
		// (set) Token: 0x06000AAA RID: 2730 RVA: 0x0002521E File Offset: 0x0002341E
		[global::System.Xml.Serialization.XmlElement(Order = 19)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_DocGrid docGrid
		{
			get
			{
				return this.docGridField;
			}
			set
			{
				this.docGridField = value;
			}
		}

		// Token: 0x17000390 RID: 912
		// (get) Token: 0x06000AAB RID: 2731 RVA: 0x00025227 File Offset: 0x00023427
		// (set) Token: 0x06000AAC RID: 2732 RVA: 0x0002522F File Offset: 0x0002342F
		[global::System.Xml.Serialization.XmlElement(Order = 20)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_Rel printerSettings
		{
			get
			{
				return this.printerSettingsField;
			}
			set
			{
				this.printerSettingsField = value;
			}
		}

		// Token: 0x17000391 RID: 913
		// (get) Token: 0x06000AAD RID: 2733 RVA: 0x00025238 File Offset: 0x00023438
		// (set) Token: 0x06000AAE RID: 2734 RVA: 0x00025240 File Offset: 0x00023440
		[global::System.Xml.Serialization.XmlElement(Order = 21)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_SectPrChange sectPrChange
		{
			get
			{
				return this.sectPrChangeField;
			}
			set
			{
				this.sectPrChangeField = value;
			}
		}

		// Token: 0x17000392 RID: 914
		// (get) Token: 0x06000AAF RID: 2735 RVA: 0x00025249 File Offset: 0x00023449
		// (set) Token: 0x06000AB0 RID: 2736 RVA: 0x00025251 File Offset: 0x00023451
		[global::System.Xml.Serialization.XmlAttribute(Form = global::System.Xml.Schema.XmlSchemaForm.Qualified, DataType = "hexBinary")]
		public byte[] rsidRPr
		{
			get
			{
				return this.rsidRPrField;
			}
			set
			{
				this.rsidRPrField = value;
			}
		}

		// Token: 0x17000393 RID: 915
		// (get) Token: 0x06000AB1 RID: 2737 RVA: 0x0002525A File Offset: 0x0002345A
		// (set) Token: 0x06000AB2 RID: 2738 RVA: 0x00025262 File Offset: 0x00023462
		[global::System.Xml.Serialization.XmlAttribute(Form = global::System.Xml.Schema.XmlSchemaForm.Qualified, DataType = "hexBinary")]
		public byte[] rsidDel
		{
			get
			{
				return this.rsidDelField;
			}
			set
			{
				this.rsidDelField = value;
			}
		}

		// Token: 0x17000394 RID: 916
		// (get) Token: 0x06000AB3 RID: 2739 RVA: 0x0002526B File Offset: 0x0002346B
		// (set) Token: 0x06000AB4 RID: 2740 RVA: 0x00025273 File Offset: 0x00023473
		[global::System.Xml.Serialization.XmlAttribute(Form = global::System.Xml.Schema.XmlSchemaForm.Qualified, DataType = "hexBinary")]
		public byte[] rsidR
		{
			get
			{
				return this.rsidRField;
			}
			set
			{
				this.rsidRField = value;
			}
		}

		// Token: 0x17000395 RID: 917
		// (get) Token: 0x06000AB5 RID: 2741 RVA: 0x0002527C File Offset: 0x0002347C
		// (set) Token: 0x06000AB6 RID: 2742 RVA: 0x00025284 File Offset: 0x00023484
		[global::System.Xml.Serialization.XmlAttribute(Form = global::System.Xml.Schema.XmlSchemaForm.Qualified, DataType = "hexBinary")]
		public byte[] rsidSect
		{
			get
			{
				return this.rsidSectField;
			}
			set
			{
				this.rsidSectField = value;
			}
		}

		// Token: 0x06000AB7 RID: 2743 RVA: 0x00025290 File Offset: 0x00023490
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_HdrFtrRef AddNewHeaderReference()
		{
			global::NPOI.OpenXmlFormats.Wordprocessing.CT_HdrFtrRef ct_HdrFtrRef = new global::NPOI.OpenXmlFormats.Wordprocessing.CT_HdrFtrRef();
			if (this.headerReferenceField == null)
			{
				this.headerReferenceField = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.CT_HdrFtrRef>();
			}
			this.headerReferenceField.Add(ct_HdrFtrRef);
			return ct_HdrFtrRef;
		}

		// Token: 0x06000AB8 RID: 2744 RVA: 0x000252C4 File Offset: 0x000234C4
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_HdrFtrRef AddNewFooterReference()
		{
			global::NPOI.OpenXmlFormats.Wordprocessing.CT_HdrFtrRef ct_HdrFtrRef = new global::NPOI.OpenXmlFormats.Wordprocessing.CT_HdrFtrRef();
			if (this.footerReferenceField == null)
			{
				this.footerReferenceField = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.CT_HdrFtrRef>();
			}
			this.footerReferenceField.Add(ct_HdrFtrRef);
			return ct_HdrFtrRef;
		}

		// Token: 0x06000AB9 RID: 2745 RVA: 0x000252F7 File Offset: 0x000234F7
		public int SizeOfHeaderReferenceArray()
		{
			if (this.headerReferenceField == null)
			{
				return 0;
			}
			return this.headerReferenceField.Count;
		}

		// Token: 0x06000ABA RID: 2746 RVA: 0x0002530E File Offset: 0x0002350E
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_HdrFtrRef GetHeaderReferenceArray(int i)
		{
			if (this.headerReferenceField == null)
			{
				return null;
			}
			return this.headerReferenceField[i];
		}

		// Token: 0x06000ABB RID: 2747 RVA: 0x00025326 File Offset: 0x00023526
		public int SizeOfFooterReferenceArray()
		{
			if (this.footerReferenceField == null)
			{
				return 0;
			}
			return this.footerReferenceField.Count;
		}

		// Token: 0x06000ABC RID: 2748 RVA: 0x0002533D File Offset: 0x0002353D
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_HdrFtrRef GetFooterReferenceArray(int i)
		{
			if (this.footerReferenceField == null)
			{
				return null;
			}
			return this.footerReferenceField[i];
		}

		// Token: 0x06000ABD RID: 2749 RVA: 0x00025358 File Offset: 0x00023558
		public static global::NPOI.OpenXmlFormats.Wordprocessing.CT_SectPr Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Wordprocessing.CT_SectPr ct_SectPr = new global::NPOI.OpenXmlFormats.Wordprocessing.CT_SectPr();
			ct_SectPr.rsidRPr = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBytes(node.Attributes["w:rsidRPr"]);
			ct_SectPr.rsidDel = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBytes(node.Attributes["w:rsidDel"]);
			ct_SectPr.rsidR = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBytes(node.Attributes["w:rsidR"]);
			ct_SectPr.rsidSect = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBytes(node.Attributes["w:rsidSect"]);
			ct_SectPr.footerReference = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.CT_HdrFtrRef>();
			ct_SectPr.headerReference = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.CT_HdrFtrRef>();
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "footnotePr")
				{
					ct_SectPr.footnotePr = global::NPOI.OpenXmlFormats.Wordprocessing.CT_FtnProps.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "endnotePr")
				{
					ct_SectPr.endnotePr = global::NPOI.OpenXmlFormats.Wordprocessing.CT_EdnProps.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "type")
				{
					ct_SectPr.type = global::NPOI.OpenXmlFormats.Wordprocessing.CT_SectType.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "pgSz")
				{
					ct_SectPr.pgSz = global::NPOI.OpenXmlFormats.Wordprocessing.CT_PageSz.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "pgMar")
				{
					ct_SectPr.pgMar = global::NPOI.OpenXmlFormats.Wordprocessing.CT_PageMar.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "paperSrc")
				{
					ct_SectPr.paperSrc = global::NPOI.OpenXmlFormats.Wordprocessing.CT_PaperSource.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "pgBorders")
				{
					ct_SectPr.pgBorders = global::NPOI.OpenXmlFormats.Wordprocessing.CT_PageBorders.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "lnNumType")
				{
					ct_SectPr.lnNumType = global::NPOI.OpenXmlFormats.Wordprocessing.CT_LineNumber.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "pgNumType")
				{
					ct_SectPr.pgNumType = global::NPOI.OpenXmlFormats.Wordprocessing.CT_PageNumber.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "cols")
				{
					ct_SectPr.cols = global::NPOI.OpenXmlFormats.Wordprocessing.CT_Columns.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "formProt")
				{
					ct_SectPr.formProt = global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "vAlign")
				{
					ct_SectPr.vAlign = global::NPOI.OpenXmlFormats.Wordprocessing.CT_VerticalJc.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "noEndnote")
				{
					ct_SectPr.noEndnote = global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "titlePg")
				{
					ct_SectPr.titlePg = global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "textDirection")
				{
					ct_SectPr.textDirection = global::NPOI.OpenXmlFormats.Wordprocessing.CT_TextDirection.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "bidi")
				{
					ct_SectPr.bidi = global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "rtlGutter")
				{
					ct_SectPr.rtlGutter = global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "docGrid")
				{
					ct_SectPr.docGrid = global::NPOI.OpenXmlFormats.Wordprocessing.CT_DocGrid.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "printerSettings")
				{
					ct_SectPr.printerSettings = global::NPOI.OpenXmlFormats.Wordprocessing.CT_Rel.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "sectPrChange")
				{
					ct_SectPr.sectPrChange = global::NPOI.OpenXmlFormats.Wordprocessing.CT_SectPrChange.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "footerReference")
				{
					ct_SectPr.footerReference.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_HdrFtrRef.Parse(xmlNode, namespaceManager));
				}
				else if (xmlNode.LocalName == "headerReference")
				{
					ct_SectPr.headerReference.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_HdrFtrRef.Parse(xmlNode, namespaceManager));
				}
			}
			return ct_SectPr;
		}

		// Token: 0x06000ABE RID: 2750 RVA: 0x00025760 File Offset: 0x00023960
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<w:{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "w:rsidR", this.rsidR);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "w:rsidRPr", this.rsidRPr);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "w:rsidSect", this.rsidSect);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "w:rsidDel", this.rsidDel);
			sw.Write(">");
			if (this.headerReference != null)
			{
				foreach (global::NPOI.OpenXmlFormats.Wordprocessing.CT_HdrFtrRef ct_HdrFtrRef in this.headerReference)
				{
					ct_HdrFtrRef.Write(sw, "headerReference");
				}
			}
			if (this.footerReference != null)
			{
				foreach (global::NPOI.OpenXmlFormats.Wordprocessing.CT_HdrFtrRef ct_HdrFtrRef2 in this.footerReference)
				{
					ct_HdrFtrRef2.Write(sw, "footerReference");
				}
			}
			if (this.footnotePr != null)
			{
				this.footnotePr.Write(sw, "footnotePr");
			}
			if (this.endnotePr != null)
			{
				this.endnotePr.Write(sw, "endnotePr");
			}
			if (this.type != null)
			{
				this.type.Write(sw, "type");
			}
			if (this.pgSz != null)
			{
				this.pgSz.Write(sw, "pgSz");
			}
			if (this.pgMar != null)
			{
				this.pgMar.Write(sw, "pgMar");
			}
			if (this.paperSrc != null)
			{
				this.paperSrc.Write(sw, "paperSrc");
			}
			if (this.pgBorders != null)
			{
				this.pgBorders.Write(sw, "pgBorders");
			}
			if (this.lnNumType != null)
			{
				this.lnNumType.Write(sw, "lnNumType");
			}
			if (this.pgNumType != null)
			{
				this.pgNumType.Write(sw, "pgNumType");
			}
			if (this.cols != null)
			{
				this.cols.Write(sw, "cols");
			}
			if (this.formProt != null)
			{
				this.formProt.Write(sw, "formProt");
			}
			if (this.vAlign != null)
			{
				this.vAlign.Write(sw, "vAlign");
			}
			if (this.noEndnote != null)
			{
				this.noEndnote.Write(sw, "noEndnote");
			}
			if (this.titlePg != null)
			{
				this.titlePg.Write(sw, "titlePg");
			}
			if (this.textDirection != null)
			{
				this.textDirection.Write(sw, "textDirection");
			}
			if (this.bidi != null)
			{
				this.bidi.Write(sw, "bidi");
			}
			if (this.rtlGutter != null)
			{
				this.rtlGutter.Write(sw, "rtlGutter");
			}
			if (this.docGrid != null)
			{
				this.docGrid.Write(sw, "docGrid");
			}
			if (this.printerSettings != null)
			{
				this.printerSettings.Write(sw, "printerSettings");
			}
			if (this.sectPrChange != null)
			{
				this.sectPrChange.Write(sw, "sectPrChange");
			}
			sw.Write(string.Format("</w:{0}>", nodeName));
		}

		// Token: 0x040009F8 RID: 2552
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_FtnProps footnotePrField;

		// Token: 0x040009F9 RID: 2553
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_EdnProps endnotePrField;

		// Token: 0x040009FA RID: 2554
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_SectType typeField;

		// Token: 0x040009FB RID: 2555
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_PageSz pgSzField;

		// Token: 0x040009FC RID: 2556
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_PageMar pgMarField;

		// Token: 0x040009FD RID: 2557
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_PaperSource paperSrcField;

		// Token: 0x040009FE RID: 2558
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_PageBorders pgBordersField;

		// Token: 0x040009FF RID: 2559
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_LineNumber lnNumTypeField;

		// Token: 0x04000A00 RID: 2560
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_PageNumber pgNumTypeField;

		// Token: 0x04000A01 RID: 2561
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_Columns colsField;

		// Token: 0x04000A02 RID: 2562
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff formProtField;

		// Token: 0x04000A03 RID: 2563
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_VerticalJc vAlignField;

		// Token: 0x04000A04 RID: 2564
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff noEndnoteField;

		// Token: 0x04000A05 RID: 2565
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff titlePgField;

		// Token: 0x04000A06 RID: 2566
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_TextDirection textDirectionField;

		// Token: 0x04000A07 RID: 2567
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff bidiField;

		// Token: 0x04000A08 RID: 2568
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff rtlGutterField;

		// Token: 0x04000A09 RID: 2569
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_DocGrid docGridField;

		// Token: 0x04000A0A RID: 2570
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_Rel printerSettingsField;

		// Token: 0x04000A0B RID: 2571
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_SectPrChange sectPrChangeField;

		// Token: 0x04000A0C RID: 2572
		private byte[] rsidRPrField;

		// Token: 0x04000A0D RID: 2573
		private byte[] rsidDelField;

		// Token: 0x04000A0E RID: 2574
		private byte[] rsidRField;

		// Token: 0x04000A0F RID: 2575
		private byte[] rsidSectField;

		// Token: 0x04000A10 RID: 2576
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.CT_HdrFtrRef> footerReferenceField;

		// Token: 0x04000A11 RID: 2577
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.CT_HdrFtrRef> headerReferenceField;
	}
}
