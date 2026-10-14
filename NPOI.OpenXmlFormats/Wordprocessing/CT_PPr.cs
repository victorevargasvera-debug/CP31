using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Wordprocessing
{
	// Token: 0x0200015C RID: 348
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_PPr : global::NPOI.OpenXmlFormats.Wordprocessing.CT_PPrBase
	{
		// Token: 0x060009E3 RID: 2531 RVA: 0x00022E02 File Offset: 0x00021002
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_SectPr createSectPr()
		{
			this.sectPrField = new global::NPOI.OpenXmlFormats.Wordprocessing.CT_SectPr();
			return this.sectPrField;
		}

		// Token: 0x17000334 RID: 820
		// (get) Token: 0x060009E4 RID: 2532 RVA: 0x00022E15 File Offset: 0x00021015
		public override bool IsEmpty
		{
			get
			{
				return base.IsEmpty && this.rPrField == null && this.sectPrField == null && this.pPrChangeField == null;
			}
		}

		// Token: 0x060009E5 RID: 2533 RVA: 0x00022E3C File Offset: 0x0002103C
		public new static global::NPOI.OpenXmlFormats.Wordprocessing.CT_PPr Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Wordprocessing.CT_PPr ct_PPr = new global::NPOI.OpenXmlFormats.Wordprocessing.CT_PPr();
			ct_PPr.tabs = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.CT_TabStop>();
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "rPr")
				{
					ct_PPr.rPr = global::NPOI.OpenXmlFormats.Wordprocessing.CT_ParaRPr.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "sectPr")
				{
					ct_PPr.sectPr = global::NPOI.OpenXmlFormats.Wordprocessing.CT_SectPr.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "pPrChange")
				{
					ct_PPr.pPrChange = global::NPOI.OpenXmlFormats.Wordprocessing.CT_PPrChange.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "pStyle")
				{
					ct_PPr.pStyle = global::NPOI.OpenXmlFormats.Wordprocessing.CT_String.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "keepNext")
				{
					ct_PPr.keepNext = global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "keepLines")
				{
					ct_PPr.keepLines = global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "pageBreakBefore")
				{
					ct_PPr.pageBreakBefore = global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "framePr")
				{
					ct_PPr.framePr = global::NPOI.OpenXmlFormats.Wordprocessing.CT_FramePr.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "widowControl")
				{
					ct_PPr.widowControl = global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "numPr")
				{
					ct_PPr.numPr = global::NPOI.OpenXmlFormats.Wordprocessing.CT_NumPr.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "suppressLineNumbers")
				{
					ct_PPr.suppressLineNumbers = global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "pBdr")
				{
					ct_PPr.pBdr = global::NPOI.OpenXmlFormats.Wordprocessing.CT_PBdr.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "shd")
				{
					ct_PPr.shd = global::NPOI.OpenXmlFormats.Wordprocessing.CT_Shd.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "suppressAutoHyphens")
				{
					ct_PPr.suppressAutoHyphens = global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "kinsoku")
				{
					ct_PPr.kinsoku = global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "wordWrap")
				{
					ct_PPr.wordWrap = global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "overflowPunct")
				{
					ct_PPr.overflowPunct = global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "topLinePunct")
				{
					ct_PPr.topLinePunct = global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "autoSpaceDE")
				{
					ct_PPr.autoSpaceDE = global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "autoSpaceDN")
				{
					ct_PPr.autoSpaceDN = global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "bidi")
				{
					ct_PPr.bidi = global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "adjustRightInd")
				{
					ct_PPr.adjustRightInd = global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "snapToGrid")
				{
					ct_PPr.snapToGrid = global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "spacing")
				{
					ct_PPr.spacing = global::NPOI.OpenXmlFormats.Wordprocessing.CT_Spacing.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "ind")
				{
					ct_PPr.ind = global::NPOI.OpenXmlFormats.Wordprocessing.CT_Ind.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "contextualSpacing")
				{
					ct_PPr.contextualSpacing = global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "mirrorIndents")
				{
					ct_PPr.mirrorIndents = global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "suppressOverlap")
				{
					ct_PPr.suppressOverlap = global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "jc")
				{
					ct_PPr.jc = global::NPOI.OpenXmlFormats.Wordprocessing.CT_Jc.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "textDirection")
				{
					ct_PPr.textDirection = global::NPOI.OpenXmlFormats.Wordprocessing.CT_TextDirection.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "textAlignment")
				{
					ct_PPr.textAlignment = global::NPOI.OpenXmlFormats.Wordprocessing.CT_TextAlignment.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "textboxTightWrap")
				{
					ct_PPr.textboxTightWrap = global::NPOI.OpenXmlFormats.Wordprocessing.CT_TextboxTightWrap.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "outlineLvl")
				{
					ct_PPr.outlineLvl = global::NPOI.OpenXmlFormats.Wordprocessing.CT_DecimalNumber.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "divId")
				{
					ct_PPr.divId = global::NPOI.OpenXmlFormats.Wordprocessing.CT_DecimalNumber.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "cnfStyle")
				{
					ct_PPr.cnfStyle = global::NPOI.OpenXmlFormats.Wordprocessing.CT_Cnf.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "tabs")
				{
					foreach (object obj2 in xmlNode.ChildNodes)
					{
						global::System.Xml.XmlNode node2 = (global::System.Xml.XmlNode)obj2;
						ct_PPr.tabs.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_TabStop.Parse(node2, namespaceManager));
					}
				}
			}
			return ct_PPr;
		}

		// Token: 0x060009E6 RID: 2534 RVA: 0x00023418 File Offset: 0x00021618
		internal new void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<w:{0}", nodeName));
			sw.Write(">");
			if (this.sectPr != null)
			{
				this.sectPr.Write(sw, "sectPr");
			}
			if (this.pPrChange != null)
			{
				this.pPrChange.Write(sw, "pPrChange");
			}
			if (base.pStyle != null)
			{
				base.pStyle.Write(sw, "pStyle");
			}
			if (base.keepNext != null)
			{
				base.keepNext.Write(sw, "keepNext");
			}
			if (base.keepLines != null)
			{
				base.keepLines.Write(sw, "keepLines");
			}
			if (base.pageBreakBefore != null)
			{
				base.pageBreakBefore.Write(sw, "pageBreakBefore");
			}
			if (base.framePr != null)
			{
				base.framePr.Write(sw, "framePr");
			}
			if (base.widowControl != null)
			{
				base.widowControl.Write(sw, "widowControl");
			}
			if (base.numPr != null)
			{
				base.numPr.Write(sw, "numPr");
			}
			if (base.pBdr != null)
			{
				base.pBdr.Write(sw, "pBdr");
			}
			if (base.tabs != null && base.tabs.Count > 0)
			{
				sw.Write("<w:tabs>");
				foreach (global::NPOI.OpenXmlFormats.Wordprocessing.CT_TabStop ct_TabStop in base.tabs)
				{
					ct_TabStop.Write(sw, "tab");
				}
				sw.Write("</w:tabs>");
			}
			if (base.suppressLineNumbers != null)
			{
				base.suppressLineNumbers.Write(sw, "suppressLineNumbers");
			}
			if (base.shd != null)
			{
				base.shd.Write(sw, "shd");
			}
			if (base.suppressAutoHyphens != null)
			{
				base.suppressAutoHyphens.Write(sw, "suppressAutoHyphens");
			}
			if (base.kinsoku != null)
			{
				base.kinsoku.Write(sw, "kinsoku");
			}
			if (base.wordWrap != null)
			{
				base.wordWrap.Write(sw, "wordWrap");
			}
			if (base.overflowPunct != null)
			{
				base.overflowPunct.Write(sw, "overflowPunct");
			}
			if (base.topLinePunct != null)
			{
				base.topLinePunct.Write(sw, "topLinePunct");
			}
			if (base.autoSpaceDE != null)
			{
				base.autoSpaceDE.Write(sw, "autoSpaceDE");
			}
			if (base.autoSpaceDN != null)
			{
				base.autoSpaceDN.Write(sw, "autoSpaceDN");
			}
			if (base.bidi != null)
			{
				base.bidi.Write(sw, "bidi");
			}
			if (base.adjustRightInd != null)
			{
				base.adjustRightInd.Write(sw, "adjustRightInd");
			}
			if (base.snapToGrid != null)
			{
				base.snapToGrid.Write(sw, "snapToGrid");
			}
			if (base.spacing != null)
			{
				base.spacing.Write(sw, "spacing");
			}
			if (base.ind != null)
			{
				base.ind.Write(sw, "ind");
			}
			if (base.contextualSpacing != null)
			{
				base.contextualSpacing.Write(sw, "contextualSpacing");
			}
			if (base.mirrorIndents != null)
			{
				base.mirrorIndents.Write(sw, "mirrorIndents");
			}
			if (base.suppressOverlap != null)
			{
				base.suppressOverlap.Write(sw, "suppressOverlap");
			}
			if (base.jc != null)
			{
				base.jc.Write(sw, "jc");
			}
			if (base.outlineLvl != null)
			{
				base.outlineLvl.Write(sw, "outlineLvl");
			}
			if (this.rPr != null)
			{
				this.rPr.Write(sw, "rPr");
			}
			if (base.textDirection != null)
			{
				base.textDirection.Write(sw, "textDirection");
			}
			if (base.textAlignment != null)
			{
				base.textAlignment.Write(sw, "textAlignment");
			}
			if (base.textboxTightWrap != null)
			{
				base.textboxTightWrap.Write(sw, "textboxTightWrap");
			}
			if (base.divId != null)
			{
				base.divId.Write(sw, "divId");
			}
			if (base.cnfStyle != null)
			{
				base.cnfStyle.Write(sw, "cnfStyle");
			}
			sw.Write(string.Format("</w:{0}>", nodeName));
		}

		// Token: 0x17000335 RID: 821
		// (get) Token: 0x060009E7 RID: 2535 RVA: 0x00023834 File Offset: 0x00021A34
		// (set) Token: 0x060009E8 RID: 2536 RVA: 0x0002383C File Offset: 0x00021A3C
		[global::System.Xml.Serialization.XmlElement(Order = 0)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_ParaRPr rPr
		{
			get
			{
				return this.rPrField;
			}
			set
			{
				this.rPrField = value;
			}
		}

		// Token: 0x17000336 RID: 822
		// (get) Token: 0x060009E9 RID: 2537 RVA: 0x00023845 File Offset: 0x00021A45
		// (set) Token: 0x060009EA RID: 2538 RVA: 0x0002384D File Offset: 0x00021A4D
		[global::System.Xml.Serialization.XmlElement(Order = 1)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_SectPr sectPr
		{
			get
			{
				return this.sectPrField;
			}
			set
			{
				this.sectPrField = value;
			}
		}

		// Token: 0x17000337 RID: 823
		// (get) Token: 0x060009EB RID: 2539 RVA: 0x00023856 File Offset: 0x00021A56
		// (set) Token: 0x060009EC RID: 2540 RVA: 0x0002385E File Offset: 0x00021A5E
		[global::System.Xml.Serialization.XmlElement(Order = 2)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_PPrChange pPrChange
		{
			get
			{
				return this.pPrChangeField;
			}
			set
			{
				this.pPrChangeField = value;
			}
		}

		// Token: 0x060009ED RID: 2541 RVA: 0x00023867 File Offset: 0x00021A67
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_ParaRPr AddNewRPr()
		{
			if (this.rPrField == null)
			{
				this.rPrField = new global::NPOI.OpenXmlFormats.Wordprocessing.CT_ParaRPr();
			}
			return this.rPrField;
		}

		// Token: 0x060009EE RID: 2542 RVA: 0x00023882 File Offset: 0x00021A82
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_NumPr AddNewNumPr()
		{
			if (base.numPr == null)
			{
				base.numPr = new global::NPOI.OpenXmlFormats.Wordprocessing.CT_NumPr();
			}
			return base.numPr;
		}

		// Token: 0x060009EF RID: 2543 RVA: 0x0002389D File Offset: 0x00021A9D
		public bool IsSetSpacing()
		{
			return base.spacing != null;
		}

		// Token: 0x040009B1 RID: 2481
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_ParaRPr rPrField;

		// Token: 0x040009B2 RID: 2482
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_SectPr sectPrField;

		// Token: 0x040009B3 RID: 2483
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_PPrChange pPrChangeField;
	}
}
