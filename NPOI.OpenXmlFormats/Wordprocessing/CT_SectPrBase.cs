using System;
using System.IO;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Wordprocessing
{
	// Token: 0x0200015F RID: 351
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_SectPrBase
	{
		// Token: 0x06000A52 RID: 2642 RVA: 0x00024848 File Offset: 0x00022A48
		public static global::NPOI.OpenXmlFormats.Wordprocessing.CT_SectPrBase Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Wordprocessing.CT_SectPrBase ct_SectPrBase = new global::NPOI.OpenXmlFormats.Wordprocessing.CT_SectPrBase();
			ct_SectPrBase.rsidRPr = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBytes(node.Attributes["w:rsidRPr"]);
			ct_SectPrBase.rsidDel = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBytes(node.Attributes["w:rsidDel"]);
			ct_SectPrBase.rsidR = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBytes(node.Attributes["w:rsidR"]);
			ct_SectPrBase.rsidSect = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBytes(node.Attributes["w:rsidSect"]);
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "footnotePr")
				{
					ct_SectPrBase.footnotePr = global::NPOI.OpenXmlFormats.Wordprocessing.CT_FtnProps.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "endnotePr")
				{
					ct_SectPrBase.endnotePr = global::NPOI.OpenXmlFormats.Wordprocessing.CT_EdnProps.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "type")
				{
					ct_SectPrBase.type = global::NPOI.OpenXmlFormats.Wordprocessing.CT_SectType.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "pgSz")
				{
					ct_SectPrBase.pgSz = global::NPOI.OpenXmlFormats.Wordprocessing.CT_PageSz.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "pgMar")
				{
					ct_SectPrBase.pgMar = global::NPOI.OpenXmlFormats.Wordprocessing.CT_PageMar.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "paperSrc")
				{
					ct_SectPrBase.paperSrc = global::NPOI.OpenXmlFormats.Wordprocessing.CT_PaperSource.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "pgBorders")
				{
					ct_SectPrBase.pgBorders = global::NPOI.OpenXmlFormats.Wordprocessing.CT_PageBorders.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "lnNumType")
				{
					ct_SectPrBase.lnNumType = global::NPOI.OpenXmlFormats.Wordprocessing.CT_LineNumber.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "pgNumType")
				{
					ct_SectPrBase.pgNumType = global::NPOI.OpenXmlFormats.Wordprocessing.CT_PageNumber.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "cols")
				{
					ct_SectPrBase.cols = global::NPOI.OpenXmlFormats.Wordprocessing.CT_Columns.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "formProt")
				{
					ct_SectPrBase.formProt = global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "vAlign")
				{
					ct_SectPrBase.vAlign = global::NPOI.OpenXmlFormats.Wordprocessing.CT_VerticalJc.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "noEndnote")
				{
					ct_SectPrBase.noEndnote = global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "titlePg")
				{
					ct_SectPrBase.titlePg = global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "textDirection")
				{
					ct_SectPrBase.textDirection = global::NPOI.OpenXmlFormats.Wordprocessing.CT_TextDirection.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "bidi")
				{
					ct_SectPrBase.bidi = global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "rtlGutter")
				{
					ct_SectPrBase.rtlGutter = global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "docGrid")
				{
					ct_SectPrBase.docGrid = global::NPOI.OpenXmlFormats.Wordprocessing.CT_DocGrid.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "printerSettings")
				{
					ct_SectPrBase.printerSettings = global::NPOI.OpenXmlFormats.Wordprocessing.CT_Rel.Parse(xmlNode, namespaceManager);
				}
			}
			return ct_SectPrBase;
		}

		// Token: 0x06000A53 RID: 2643 RVA: 0x00024BC4 File Offset: 0x00022DC4
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<w:{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "w:rsidRPr", this.rsidRPr);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "w:rsidDel", this.rsidDel);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "w:rsidR", this.rsidR);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "w:rsidSect", this.rsidSect);
			sw.Write(">");
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
			sw.Write(string.Format("</w:{0}>", nodeName));
		}

		// Token: 0x17000365 RID: 869
		// (get) Token: 0x06000A54 RID: 2644 RVA: 0x00024E1D File Offset: 0x0002301D
		// (set) Token: 0x06000A55 RID: 2645 RVA: 0x00024E25 File Offset: 0x00023025
		[global::System.Xml.Serialization.XmlElement(Order = 0)]
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

		// Token: 0x17000366 RID: 870
		// (get) Token: 0x06000A56 RID: 2646 RVA: 0x00024E2E File Offset: 0x0002302E
		// (set) Token: 0x06000A57 RID: 2647 RVA: 0x00024E36 File Offset: 0x00023036
		[global::System.Xml.Serialization.XmlElement(Order = 1)]
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

		// Token: 0x17000367 RID: 871
		// (get) Token: 0x06000A58 RID: 2648 RVA: 0x00024E3F File Offset: 0x0002303F
		// (set) Token: 0x06000A59 RID: 2649 RVA: 0x00024E47 File Offset: 0x00023047
		[global::System.Xml.Serialization.XmlElement(Order = 2)]
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

		// Token: 0x17000368 RID: 872
		// (get) Token: 0x06000A5A RID: 2650 RVA: 0x00024E50 File Offset: 0x00023050
		// (set) Token: 0x06000A5B RID: 2651 RVA: 0x00024E58 File Offset: 0x00023058
		[global::System.Xml.Serialization.XmlElement(Order = 3)]
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

		// Token: 0x17000369 RID: 873
		// (get) Token: 0x06000A5C RID: 2652 RVA: 0x00024E61 File Offset: 0x00023061
		// (set) Token: 0x06000A5D RID: 2653 RVA: 0x00024E69 File Offset: 0x00023069
		[global::System.Xml.Serialization.XmlElement(Order = 4)]
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

		// Token: 0x1700036A RID: 874
		// (get) Token: 0x06000A5E RID: 2654 RVA: 0x00024E72 File Offset: 0x00023072
		// (set) Token: 0x06000A5F RID: 2655 RVA: 0x00024E7A File Offset: 0x0002307A
		[global::System.Xml.Serialization.XmlElement(Order = 5)]
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

		// Token: 0x1700036B RID: 875
		// (get) Token: 0x06000A60 RID: 2656 RVA: 0x00024E83 File Offset: 0x00023083
		// (set) Token: 0x06000A61 RID: 2657 RVA: 0x00024E8B File Offset: 0x0002308B
		[global::System.Xml.Serialization.XmlElement(Order = 6)]
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

		// Token: 0x1700036C RID: 876
		// (get) Token: 0x06000A62 RID: 2658 RVA: 0x00024E94 File Offset: 0x00023094
		// (set) Token: 0x06000A63 RID: 2659 RVA: 0x00024E9C File Offset: 0x0002309C
		[global::System.Xml.Serialization.XmlElement(Order = 7)]
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

		// Token: 0x1700036D RID: 877
		// (get) Token: 0x06000A64 RID: 2660 RVA: 0x00024EA5 File Offset: 0x000230A5
		// (set) Token: 0x06000A65 RID: 2661 RVA: 0x00024EAD File Offset: 0x000230AD
		[global::System.Xml.Serialization.XmlElement(Order = 8)]
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

		// Token: 0x1700036E RID: 878
		// (get) Token: 0x06000A66 RID: 2662 RVA: 0x00024EB6 File Offset: 0x000230B6
		// (set) Token: 0x06000A67 RID: 2663 RVA: 0x00024EBE File Offset: 0x000230BE
		[global::System.Xml.Serialization.XmlElement(Order = 9)]
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

		// Token: 0x1700036F RID: 879
		// (get) Token: 0x06000A68 RID: 2664 RVA: 0x00024EC7 File Offset: 0x000230C7
		// (set) Token: 0x06000A69 RID: 2665 RVA: 0x00024ECF File Offset: 0x000230CF
		[global::System.Xml.Serialization.XmlElement(Order = 10)]
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

		// Token: 0x17000370 RID: 880
		// (get) Token: 0x06000A6A RID: 2666 RVA: 0x00024ED8 File Offset: 0x000230D8
		// (set) Token: 0x06000A6B RID: 2667 RVA: 0x00024EE0 File Offset: 0x000230E0
		[global::System.Xml.Serialization.XmlElement(Order = 11)]
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

		// Token: 0x17000371 RID: 881
		// (get) Token: 0x06000A6C RID: 2668 RVA: 0x00024EE9 File Offset: 0x000230E9
		// (set) Token: 0x06000A6D RID: 2669 RVA: 0x00024EF1 File Offset: 0x000230F1
		[global::System.Xml.Serialization.XmlElement(Order = 12)]
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

		// Token: 0x17000372 RID: 882
		// (get) Token: 0x06000A6E RID: 2670 RVA: 0x00024EFA File Offset: 0x000230FA
		// (set) Token: 0x06000A6F RID: 2671 RVA: 0x00024F02 File Offset: 0x00023102
		[global::System.Xml.Serialization.XmlElement(Order = 13)]
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

		// Token: 0x17000373 RID: 883
		// (get) Token: 0x06000A70 RID: 2672 RVA: 0x00024F0B File Offset: 0x0002310B
		// (set) Token: 0x06000A71 RID: 2673 RVA: 0x00024F13 File Offset: 0x00023113
		[global::System.Xml.Serialization.XmlElement(Order = 14)]
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

		// Token: 0x17000374 RID: 884
		// (get) Token: 0x06000A72 RID: 2674 RVA: 0x00024F1C File Offset: 0x0002311C
		// (set) Token: 0x06000A73 RID: 2675 RVA: 0x00024F24 File Offset: 0x00023124
		[global::System.Xml.Serialization.XmlElement(Order = 15)]
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

		// Token: 0x17000375 RID: 885
		// (get) Token: 0x06000A74 RID: 2676 RVA: 0x00024F2D File Offset: 0x0002312D
		// (set) Token: 0x06000A75 RID: 2677 RVA: 0x00024F35 File Offset: 0x00023135
		[global::System.Xml.Serialization.XmlElement(Order = 16)]
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

		// Token: 0x17000376 RID: 886
		// (get) Token: 0x06000A76 RID: 2678 RVA: 0x00024F3E File Offset: 0x0002313E
		// (set) Token: 0x06000A77 RID: 2679 RVA: 0x00024F46 File Offset: 0x00023146
		[global::System.Xml.Serialization.XmlElement(Order = 17)]
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

		// Token: 0x17000377 RID: 887
		// (get) Token: 0x06000A78 RID: 2680 RVA: 0x00024F4F File Offset: 0x0002314F
		// (set) Token: 0x06000A79 RID: 2681 RVA: 0x00024F57 File Offset: 0x00023157
		[global::System.Xml.Serialization.XmlElement(Order = 18)]
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

		// Token: 0x17000378 RID: 888
		// (get) Token: 0x06000A7A RID: 2682 RVA: 0x00024F60 File Offset: 0x00023160
		// (set) Token: 0x06000A7B RID: 2683 RVA: 0x00024F68 File Offset: 0x00023168
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

		// Token: 0x17000379 RID: 889
		// (get) Token: 0x06000A7C RID: 2684 RVA: 0x00024F71 File Offset: 0x00023171
		// (set) Token: 0x06000A7D RID: 2685 RVA: 0x00024F79 File Offset: 0x00023179
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

		// Token: 0x1700037A RID: 890
		// (get) Token: 0x06000A7E RID: 2686 RVA: 0x00024F82 File Offset: 0x00023182
		// (set) Token: 0x06000A7F RID: 2687 RVA: 0x00024F8A File Offset: 0x0002318A
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

		// Token: 0x1700037B RID: 891
		// (get) Token: 0x06000A80 RID: 2688 RVA: 0x00024F93 File Offset: 0x00023193
		// (set) Token: 0x06000A81 RID: 2689 RVA: 0x00024F9B File Offset: 0x0002319B
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

		// Token: 0x040009E1 RID: 2529
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_FtnProps footnotePrField;

		// Token: 0x040009E2 RID: 2530
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_EdnProps endnotePrField;

		// Token: 0x040009E3 RID: 2531
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_SectType typeField;

		// Token: 0x040009E4 RID: 2532
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_PageSz pgSzField;

		// Token: 0x040009E5 RID: 2533
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_PageMar pgMarField;

		// Token: 0x040009E6 RID: 2534
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_PaperSource paperSrcField;

		// Token: 0x040009E7 RID: 2535
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_PageBorders pgBordersField;

		// Token: 0x040009E8 RID: 2536
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_LineNumber lnNumTypeField;

		// Token: 0x040009E9 RID: 2537
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_PageNumber pgNumTypeField;

		// Token: 0x040009EA RID: 2538
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_Columns colsField;

		// Token: 0x040009EB RID: 2539
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff formProtField;

		// Token: 0x040009EC RID: 2540
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_VerticalJc vAlignField;

		// Token: 0x040009ED RID: 2541
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff noEndnoteField;

		// Token: 0x040009EE RID: 2542
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff titlePgField;

		// Token: 0x040009EF RID: 2543
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_TextDirection textDirectionField;

		// Token: 0x040009F0 RID: 2544
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff bidiField;

		// Token: 0x040009F1 RID: 2545
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff rtlGutterField;

		// Token: 0x040009F2 RID: 2546
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_DocGrid docGridField;

		// Token: 0x040009F3 RID: 2547
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_Rel printerSettingsField;

		// Token: 0x040009F4 RID: 2548
		private byte[] rsidRPrField;

		// Token: 0x040009F5 RID: 2549
		private byte[] rsidDelField;

		// Token: 0x040009F6 RID: 2550
		private byte[] rsidRField;

		// Token: 0x040009F7 RID: 2551
		private byte[] rsidSectField;
	}
}
