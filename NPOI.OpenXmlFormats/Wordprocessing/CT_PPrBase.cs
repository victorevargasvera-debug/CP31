using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Wordprocessing
{
	// Token: 0x0200016A RID: 362
	[global::System.Xml.Serialization.XmlInclude(typeof(global::NPOI.OpenXmlFormats.Wordprocessing.CT_PPr))]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_PPrBase
	{
		// Token: 0x17000406 RID: 1030
		// (get) Token: 0x06000BF7 RID: 3063 RVA: 0x00029204 File Offset: 0x00027404
		public virtual bool IsEmpty
		{
			get
			{
				return this.pStyleField == null && this.keepNextField == null && this.keepLinesField == null && this.pageBreakBeforeField == null && this.framePrField == null && this.widowControlField == null && this.numPrField == null && this.suppressLineNumbersField == null && this.pBdrField == null && this.shdField == null && this.tabsField == null && this.suppressAutoHyphensField == null && this.kinsokuField == null && this.wordWrapField == null && this.overflowPunctField == null && this.topLinePunctField == null && this.autoSpaceDEField == null && this.autoSpaceDNField == null && this.bidiField == null && this.adjustRightIndField == null && this.snapToGridField == null && this.spacingField == null && this.indField == null && this.contextualSpacingField == null && this.mirrorIndentsField == null && this.suppressOverlapField == null && this.jcField == null && this.textDirectionField == null && this.textAlignmentField == null && this.textboxTightWrapField == null && this.outlineLvlField == null && this.divIdField == null && this.cnfStyleField == null;
			}
		}

		// Token: 0x06000BF9 RID: 3065 RVA: 0x00029350 File Offset: 0x00027550
		public static global::NPOI.OpenXmlFormats.Wordprocessing.CT_PPrBase Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Wordprocessing.CT_PPrBase ct_PPrBase = new global::NPOI.OpenXmlFormats.Wordprocessing.CT_PPrBase();
			ct_PPrBase.tabs = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.CT_TabStop>();
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "pStyle")
				{
					ct_PPrBase.pStyle = global::NPOI.OpenXmlFormats.Wordprocessing.CT_String.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "keepNext")
				{
					ct_PPrBase.keepNext = global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "keepLines")
				{
					ct_PPrBase.keepLines = global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "pageBreakBefore")
				{
					ct_PPrBase.pageBreakBefore = global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "framePr")
				{
					ct_PPrBase.framePr = global::NPOI.OpenXmlFormats.Wordprocessing.CT_FramePr.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "widowControl")
				{
					ct_PPrBase.widowControl = global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "numPr")
				{
					ct_PPrBase.numPr = global::NPOI.OpenXmlFormats.Wordprocessing.CT_NumPr.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "suppressLineNumbers")
				{
					ct_PPrBase.suppressLineNumbers = global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "pBdr")
				{
					ct_PPrBase.pBdr = global::NPOI.OpenXmlFormats.Wordprocessing.CT_PBdr.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "shd")
				{
					ct_PPrBase.shd = global::NPOI.OpenXmlFormats.Wordprocessing.CT_Shd.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "suppressAutoHyphens")
				{
					ct_PPrBase.suppressAutoHyphens = global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "kinsoku")
				{
					ct_PPrBase.kinsoku = global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "wordWrap")
				{
					ct_PPrBase.wordWrap = global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "overflowPunct")
				{
					ct_PPrBase.overflowPunct = global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "topLinePunct")
				{
					ct_PPrBase.topLinePunct = global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "autoSpaceDE")
				{
					ct_PPrBase.autoSpaceDE = global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "autoSpaceDN")
				{
					ct_PPrBase.autoSpaceDN = global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "bidi")
				{
					ct_PPrBase.bidi = global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "adjustRightInd")
				{
					ct_PPrBase.adjustRightInd = global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "snapToGrid")
				{
					ct_PPrBase.snapToGrid = global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "spacing")
				{
					ct_PPrBase.spacing = global::NPOI.OpenXmlFormats.Wordprocessing.CT_Spacing.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "ind")
				{
					ct_PPrBase.ind = global::NPOI.OpenXmlFormats.Wordprocessing.CT_Ind.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "contextualSpacing")
				{
					ct_PPrBase.contextualSpacing = global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "mirrorIndents")
				{
					ct_PPrBase.mirrorIndents = global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "suppressOverlap")
				{
					ct_PPrBase.suppressOverlap = global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "jc")
				{
					ct_PPrBase.jc = global::NPOI.OpenXmlFormats.Wordprocessing.CT_Jc.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "textDirection")
				{
					ct_PPrBase.textDirection = global::NPOI.OpenXmlFormats.Wordprocessing.CT_TextDirection.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "textAlignment")
				{
					ct_PPrBase.textAlignment = global::NPOI.OpenXmlFormats.Wordprocessing.CT_TextAlignment.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "textboxTightWrap")
				{
					ct_PPrBase.textboxTightWrap = global::NPOI.OpenXmlFormats.Wordprocessing.CT_TextboxTightWrap.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "outlineLvl")
				{
					ct_PPrBase.outlineLvl = global::NPOI.OpenXmlFormats.Wordprocessing.CT_DecimalNumber.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "divId")
				{
					ct_PPrBase.divId = global::NPOI.OpenXmlFormats.Wordprocessing.CT_DecimalNumber.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "cnfStyle")
				{
					ct_PPrBase.cnfStyle = global::NPOI.OpenXmlFormats.Wordprocessing.CT_Cnf.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "tabs")
				{
					foreach (object obj2 in xmlNode.ChildNodes)
					{
						global::System.Xml.XmlNode node2 = (global::System.Xml.XmlNode)obj2;
						ct_PPrBase.tabs.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_TabStop.Parse(node2, namespaceManager));
					}
				}
			}
			return ct_PPrBase;
		}

		// Token: 0x06000BFA RID: 3066 RVA: 0x000298C0 File Offset: 0x00027AC0
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<w:{0}", nodeName));
			sw.Write(">");
			if (this.pStyle != null)
			{
				this.pStyle.Write(sw, "pStyle");
			}
			if (this.tabs != null && this.tabs.Count > 0)
			{
				sw.Write("<w:tabs>");
				foreach (global::NPOI.OpenXmlFormats.Wordprocessing.CT_TabStop ct_TabStop in this.tabs)
				{
					ct_TabStop.Write(sw, "tab");
				}
				sw.Write("</w:tabs>");
			}
			if (this.keepNext != null)
			{
				this.keepNext.Write(sw, "keepNext");
			}
			if (this.keepLines != null)
			{
				this.keepLines.Write(sw, "keepLines");
			}
			if (this.pageBreakBefore != null)
			{
				this.pageBreakBefore.Write(sw, "pageBreakBefore");
			}
			if (this.framePr != null)
			{
				this.framePr.Write(sw, "framePr");
			}
			if (this.widowControl != null)
			{
				this.widowControl.Write(sw, "widowControl");
			}
			if (this.numPr != null)
			{
				this.numPr.Write(sw, "numPr");
			}
			if (this.suppressLineNumbers != null)
			{
				this.suppressLineNumbers.Write(sw, "suppressLineNumbers");
			}
			if (this.pBdr != null)
			{
				this.pBdr.Write(sw, "pBdr");
			}
			if (this.shd != null)
			{
				this.shd.Write(sw, "shd");
			}
			if (this.suppressAutoHyphens != null)
			{
				this.suppressAutoHyphens.Write(sw, "suppressAutoHyphens");
			}
			if (this.kinsoku != null)
			{
				this.kinsoku.Write(sw, "kinsoku");
			}
			if (this.wordWrap != null)
			{
				this.wordWrap.Write(sw, "wordWrap");
			}
			if (this.overflowPunct != null)
			{
				this.overflowPunct.Write(sw, "overflowPunct");
			}
			if (this.topLinePunct != null)
			{
				this.topLinePunct.Write(sw, "topLinePunct");
			}
			if (this.autoSpaceDE != null)
			{
				this.autoSpaceDE.Write(sw, "autoSpaceDE");
			}
			if (this.autoSpaceDN != null)
			{
				this.autoSpaceDN.Write(sw, "autoSpaceDN");
			}
			if (this.bidi != null)
			{
				this.bidi.Write(sw, "bidi");
			}
			if (this.adjustRightInd != null)
			{
				this.adjustRightInd.Write(sw, "adjustRightInd");
			}
			if (this.snapToGrid != null)
			{
				this.snapToGrid.Write(sw, "snapToGrid");
			}
			if (this.spacing != null)
			{
				this.spacing.Write(sw, "spacing");
			}
			if (this.ind != null)
			{
				this.ind.Write(sw, "ind");
			}
			if (this.contextualSpacing != null)
			{
				this.contextualSpacing.Write(sw, "contextualSpacing");
			}
			if (this.mirrorIndents != null)
			{
				this.mirrorIndents.Write(sw, "mirrorIndents");
			}
			if (this.suppressOverlap != null)
			{
				this.suppressOverlap.Write(sw, "suppressOverlap");
			}
			if (this.jc != null)
			{
				this.jc.Write(sw, "jc");
			}
			if (this.textDirection != null)
			{
				this.textDirection.Write(sw, "textDirection");
			}
			if (this.textAlignment != null)
			{
				this.textAlignment.Write(sw, "textAlignment");
			}
			if (this.textboxTightWrap != null)
			{
				this.textboxTightWrap.Write(sw, "textboxTightWrap");
			}
			if (this.outlineLvl != null)
			{
				this.outlineLvl.Write(sw, "outlineLvl");
			}
			if (this.divId != null)
			{
				this.divId.Write(sw, "divId");
			}
			if (this.cnfStyle != null)
			{
				this.cnfStyle.Write(sw, "cnfStyle");
			}
			sw.Write(string.Format("</w:{0}>", nodeName));
		}

		// Token: 0x17000407 RID: 1031
		// (get) Token: 0x06000BFB RID: 3067 RVA: 0x00029C90 File Offset: 0x00027E90
		// (set) Token: 0x06000BFC RID: 3068 RVA: 0x00029C98 File Offset: 0x00027E98
		[global::System.Xml.Serialization.XmlElement(Order = 0)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_String pStyle
		{
			get
			{
				return this.pStyleField;
			}
			set
			{
				this.pStyleField = value;
			}
		}

		// Token: 0x17000408 RID: 1032
		// (get) Token: 0x06000BFD RID: 3069 RVA: 0x00029CA1 File Offset: 0x00027EA1
		// (set) Token: 0x06000BFE RID: 3070 RVA: 0x00029CA9 File Offset: 0x00027EA9
		[global::System.Xml.Serialization.XmlElement(Order = 1)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff keepNext
		{
			get
			{
				return this.keepNextField;
			}
			set
			{
				this.keepNextField = value;
			}
		}

		// Token: 0x17000409 RID: 1033
		// (get) Token: 0x06000BFF RID: 3071 RVA: 0x00029CB2 File Offset: 0x00027EB2
		// (set) Token: 0x06000C00 RID: 3072 RVA: 0x00029CBA File Offset: 0x00027EBA
		[global::System.Xml.Serialization.XmlElement(Order = 2)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff keepLines
		{
			get
			{
				return this.keepLinesField;
			}
			set
			{
				this.keepLinesField = value;
			}
		}

		// Token: 0x1700040A RID: 1034
		// (get) Token: 0x06000C01 RID: 3073 RVA: 0x00029CC3 File Offset: 0x00027EC3
		// (set) Token: 0x06000C02 RID: 3074 RVA: 0x00029CCB File Offset: 0x00027ECB
		[global::System.Xml.Serialization.XmlElement(Order = 3)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff pageBreakBefore
		{
			get
			{
				return this.pageBreakBeforeField;
			}
			set
			{
				this.pageBreakBeforeField = value;
			}
		}

		// Token: 0x1700040B RID: 1035
		// (get) Token: 0x06000C03 RID: 3075 RVA: 0x00029CD4 File Offset: 0x00027ED4
		// (set) Token: 0x06000C04 RID: 3076 RVA: 0x00029CDC File Offset: 0x00027EDC
		[global::System.Xml.Serialization.XmlElement(Order = 4)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_FramePr framePr
		{
			get
			{
				return this.framePrField;
			}
			set
			{
				this.framePrField = value;
			}
		}

		// Token: 0x1700040C RID: 1036
		// (get) Token: 0x06000C05 RID: 3077 RVA: 0x00029CE5 File Offset: 0x00027EE5
		// (set) Token: 0x06000C06 RID: 3078 RVA: 0x00029CED File Offset: 0x00027EED
		[global::System.Xml.Serialization.XmlElement(Order = 5)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff widowControl
		{
			get
			{
				return this.widowControlField;
			}
			set
			{
				this.widowControlField = value;
			}
		}

		// Token: 0x1700040D RID: 1037
		// (get) Token: 0x06000C07 RID: 3079 RVA: 0x00029CF6 File Offset: 0x00027EF6
		// (set) Token: 0x06000C08 RID: 3080 RVA: 0x00029CFE File Offset: 0x00027EFE
		[global::System.Xml.Serialization.XmlElement(Order = 6)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_NumPr numPr
		{
			get
			{
				return this.numPrField;
			}
			set
			{
				this.numPrField = value;
			}
		}

		// Token: 0x1700040E RID: 1038
		// (get) Token: 0x06000C09 RID: 3081 RVA: 0x00029D07 File Offset: 0x00027F07
		// (set) Token: 0x06000C0A RID: 3082 RVA: 0x00029D0F File Offset: 0x00027F0F
		[global::System.Xml.Serialization.XmlElement(Order = 7)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff suppressLineNumbers
		{
			get
			{
				return this.suppressLineNumbersField;
			}
			set
			{
				this.suppressLineNumbersField = value;
			}
		}

		// Token: 0x1700040F RID: 1039
		// (get) Token: 0x06000C0B RID: 3083 RVA: 0x00029D18 File Offset: 0x00027F18
		// (set) Token: 0x06000C0C RID: 3084 RVA: 0x00029D20 File Offset: 0x00027F20
		[global::System.Xml.Serialization.XmlElement(Order = 8)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_PBdr pBdr
		{
			get
			{
				return this.pBdrField;
			}
			set
			{
				this.pBdrField = value;
			}
		}

		// Token: 0x17000410 RID: 1040
		// (get) Token: 0x06000C0D RID: 3085 RVA: 0x00029D29 File Offset: 0x00027F29
		// (set) Token: 0x06000C0E RID: 3086 RVA: 0x00029D31 File Offset: 0x00027F31
		[global::System.Xml.Serialization.XmlElement(Order = 9)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_Shd shd
		{
			get
			{
				return this.shdField;
			}
			set
			{
				this.shdField = value;
			}
		}

		// Token: 0x17000411 RID: 1041
		// (get) Token: 0x06000C0F RID: 3087 RVA: 0x00029D3A File Offset: 0x00027F3A
		// (set) Token: 0x06000C10 RID: 3088 RVA: 0x00029D42 File Offset: 0x00027F42
		[global::System.Xml.Serialization.XmlArray(Order = 10)]
		[global::System.Xml.Serialization.XmlArrayItem("tab", IsNullable = false)]
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.CT_TabStop> tabs
		{
			get
			{
				return this.tabsField;
			}
			set
			{
				this.tabsField = value;
			}
		}

		// Token: 0x17000412 RID: 1042
		// (get) Token: 0x06000C11 RID: 3089 RVA: 0x00029D4B File Offset: 0x00027F4B
		// (set) Token: 0x06000C12 RID: 3090 RVA: 0x00029D53 File Offset: 0x00027F53
		[global::System.Xml.Serialization.XmlElement(Order = 11)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff suppressAutoHyphens
		{
			get
			{
				return this.suppressAutoHyphensField;
			}
			set
			{
				this.suppressAutoHyphensField = value;
			}
		}

		// Token: 0x17000413 RID: 1043
		// (get) Token: 0x06000C13 RID: 3091 RVA: 0x00029D5C File Offset: 0x00027F5C
		// (set) Token: 0x06000C14 RID: 3092 RVA: 0x00029D64 File Offset: 0x00027F64
		[global::System.Xml.Serialization.XmlElement(Order = 12)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff kinsoku
		{
			get
			{
				return this.kinsokuField;
			}
			set
			{
				this.kinsokuField = value;
			}
		}

		// Token: 0x17000414 RID: 1044
		// (get) Token: 0x06000C15 RID: 3093 RVA: 0x00029D6D File Offset: 0x00027F6D
		// (set) Token: 0x06000C16 RID: 3094 RVA: 0x00029D75 File Offset: 0x00027F75
		[global::System.Xml.Serialization.XmlElement(Order = 13)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff wordWrap
		{
			get
			{
				return this.wordWrapField;
			}
			set
			{
				this.wordWrapField = value;
			}
		}

		// Token: 0x17000415 RID: 1045
		// (get) Token: 0x06000C17 RID: 3095 RVA: 0x00029D7E File Offset: 0x00027F7E
		// (set) Token: 0x06000C18 RID: 3096 RVA: 0x00029D86 File Offset: 0x00027F86
		[global::System.Xml.Serialization.XmlElement(Order = 14)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff overflowPunct
		{
			get
			{
				return this.overflowPunctField;
			}
			set
			{
				this.overflowPunctField = value;
			}
		}

		// Token: 0x17000416 RID: 1046
		// (get) Token: 0x06000C19 RID: 3097 RVA: 0x00029D8F File Offset: 0x00027F8F
		// (set) Token: 0x06000C1A RID: 3098 RVA: 0x00029D97 File Offset: 0x00027F97
		[global::System.Xml.Serialization.XmlElement(Order = 15)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff topLinePunct
		{
			get
			{
				return this.topLinePunctField;
			}
			set
			{
				this.topLinePunctField = value;
			}
		}

		// Token: 0x17000417 RID: 1047
		// (get) Token: 0x06000C1B RID: 3099 RVA: 0x00029DA0 File Offset: 0x00027FA0
		// (set) Token: 0x06000C1C RID: 3100 RVA: 0x00029DA8 File Offset: 0x00027FA8
		[global::System.Xml.Serialization.XmlElement(Order = 16)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff autoSpaceDE
		{
			get
			{
				return this.autoSpaceDEField;
			}
			set
			{
				this.autoSpaceDEField = value;
			}
		}

		// Token: 0x17000418 RID: 1048
		// (get) Token: 0x06000C1D RID: 3101 RVA: 0x00029DB1 File Offset: 0x00027FB1
		// (set) Token: 0x06000C1E RID: 3102 RVA: 0x00029DB9 File Offset: 0x00027FB9
		[global::System.Xml.Serialization.XmlElement(Order = 17)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff autoSpaceDN
		{
			get
			{
				return this.autoSpaceDNField;
			}
			set
			{
				this.autoSpaceDNField = value;
			}
		}

		// Token: 0x17000419 RID: 1049
		// (get) Token: 0x06000C1F RID: 3103 RVA: 0x00029DC2 File Offset: 0x00027FC2
		// (set) Token: 0x06000C20 RID: 3104 RVA: 0x00029DCA File Offset: 0x00027FCA
		[global::System.Xml.Serialization.XmlElement(Order = 18)]
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

		// Token: 0x1700041A RID: 1050
		// (get) Token: 0x06000C21 RID: 3105 RVA: 0x00029DD3 File Offset: 0x00027FD3
		// (set) Token: 0x06000C22 RID: 3106 RVA: 0x00029DDB File Offset: 0x00027FDB
		[global::System.Xml.Serialization.XmlElement(Order = 19)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff adjustRightInd
		{
			get
			{
				return this.adjustRightIndField;
			}
			set
			{
				this.adjustRightIndField = value;
			}
		}

		// Token: 0x1700041B RID: 1051
		// (get) Token: 0x06000C23 RID: 3107 RVA: 0x00029DE4 File Offset: 0x00027FE4
		// (set) Token: 0x06000C24 RID: 3108 RVA: 0x00029DEC File Offset: 0x00027FEC
		[global::System.Xml.Serialization.XmlElement(Order = 20)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff snapToGrid
		{
			get
			{
				return this.snapToGridField;
			}
			set
			{
				this.snapToGridField = value;
			}
		}

		// Token: 0x1700041C RID: 1052
		// (get) Token: 0x06000C25 RID: 3109 RVA: 0x00029DF5 File Offset: 0x00027FF5
		// (set) Token: 0x06000C26 RID: 3110 RVA: 0x00029DFD File Offset: 0x00027FFD
		[global::System.Xml.Serialization.XmlElement(Order = 21)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_Spacing spacing
		{
			get
			{
				return this.spacingField;
			}
			set
			{
				this.spacingField = value;
			}
		}

		// Token: 0x1700041D RID: 1053
		// (get) Token: 0x06000C27 RID: 3111 RVA: 0x00029E06 File Offset: 0x00028006
		// (set) Token: 0x06000C28 RID: 3112 RVA: 0x00029E0E File Offset: 0x0002800E
		[global::System.Xml.Serialization.XmlElement(Order = 22)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_Ind ind
		{
			get
			{
				return this.indField;
			}
			set
			{
				this.indField = value;
			}
		}

		// Token: 0x1700041E RID: 1054
		// (get) Token: 0x06000C29 RID: 3113 RVA: 0x00029E17 File Offset: 0x00028017
		// (set) Token: 0x06000C2A RID: 3114 RVA: 0x00029E1F File Offset: 0x0002801F
		[global::System.Xml.Serialization.XmlElement(Order = 23)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff contextualSpacing
		{
			get
			{
				return this.contextualSpacingField;
			}
			set
			{
				this.contextualSpacingField = value;
			}
		}

		// Token: 0x1700041F RID: 1055
		// (get) Token: 0x06000C2B RID: 3115 RVA: 0x00029E28 File Offset: 0x00028028
		// (set) Token: 0x06000C2C RID: 3116 RVA: 0x00029E30 File Offset: 0x00028030
		[global::System.Xml.Serialization.XmlElement(Order = 24)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff mirrorIndents
		{
			get
			{
				return this.mirrorIndentsField;
			}
			set
			{
				this.mirrorIndentsField = value;
			}
		}

		// Token: 0x17000420 RID: 1056
		// (get) Token: 0x06000C2D RID: 3117 RVA: 0x00029E39 File Offset: 0x00028039
		// (set) Token: 0x06000C2E RID: 3118 RVA: 0x00029E41 File Offset: 0x00028041
		[global::System.Xml.Serialization.XmlElement(Order = 25)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff suppressOverlap
		{
			get
			{
				return this.suppressOverlapField;
			}
			set
			{
				this.suppressOverlapField = value;
			}
		}

		// Token: 0x17000421 RID: 1057
		// (get) Token: 0x06000C2F RID: 3119 RVA: 0x00029E4A File Offset: 0x0002804A
		// (set) Token: 0x06000C30 RID: 3120 RVA: 0x00029E52 File Offset: 0x00028052
		[global::System.Xml.Serialization.XmlElement(Order = 26)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_Jc jc
		{
			get
			{
				return this.jcField;
			}
			set
			{
				this.jcField = value;
			}
		}

		// Token: 0x17000422 RID: 1058
		// (get) Token: 0x06000C31 RID: 3121 RVA: 0x00029E5B File Offset: 0x0002805B
		// (set) Token: 0x06000C32 RID: 3122 RVA: 0x00029E63 File Offset: 0x00028063
		[global::System.Xml.Serialization.XmlElement(Order = 27)]
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

		// Token: 0x17000423 RID: 1059
		// (get) Token: 0x06000C33 RID: 3123 RVA: 0x00029E6C File Offset: 0x0002806C
		// (set) Token: 0x06000C34 RID: 3124 RVA: 0x00029E74 File Offset: 0x00028074
		[global::System.Xml.Serialization.XmlElement(Order = 28)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_TextAlignment textAlignment
		{
			get
			{
				return this.textAlignmentField;
			}
			set
			{
				this.textAlignmentField = value;
			}
		}

		// Token: 0x17000424 RID: 1060
		// (get) Token: 0x06000C35 RID: 3125 RVA: 0x00029E7D File Offset: 0x0002807D
		// (set) Token: 0x06000C36 RID: 3126 RVA: 0x00029E85 File Offset: 0x00028085
		[global::System.Xml.Serialization.XmlElement(Order = 29)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_TextboxTightWrap textboxTightWrap
		{
			get
			{
				return this.textboxTightWrapField;
			}
			set
			{
				this.textboxTightWrapField = value;
			}
		}

		// Token: 0x17000425 RID: 1061
		// (get) Token: 0x06000C37 RID: 3127 RVA: 0x00029E8E File Offset: 0x0002808E
		// (set) Token: 0x06000C38 RID: 3128 RVA: 0x00029E96 File Offset: 0x00028096
		[global::System.Xml.Serialization.XmlElement(Order = 30)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_DecimalNumber outlineLvl
		{
			get
			{
				return this.outlineLvlField;
			}
			set
			{
				this.outlineLvlField = value;
			}
		}

		// Token: 0x17000426 RID: 1062
		// (get) Token: 0x06000C39 RID: 3129 RVA: 0x00029E9F File Offset: 0x0002809F
		// (set) Token: 0x06000C3A RID: 3130 RVA: 0x00029EA7 File Offset: 0x000280A7
		[global::System.Xml.Serialization.XmlElement(Order = 31)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_DecimalNumber divId
		{
			get
			{
				return this.divIdField;
			}
			set
			{
				this.divIdField = value;
			}
		}

		// Token: 0x17000427 RID: 1063
		// (get) Token: 0x06000C3B RID: 3131 RVA: 0x00029EB0 File Offset: 0x000280B0
		// (set) Token: 0x06000C3C RID: 3132 RVA: 0x00029EB8 File Offset: 0x000280B8
		[global::System.Xml.Serialization.XmlElement(Order = 32)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_Cnf cnfStyle
		{
			get
			{
				return this.cnfStyleField;
			}
			set
			{
				this.cnfStyleField = value;
			}
		}

		// Token: 0x06000C3D RID: 3133 RVA: 0x00029EC1 File Offset: 0x000280C1
		public bool IsSetTextAlignment()
		{
			return this.textAlignmentField != null && this.textAlignmentField != null;
		}

		// Token: 0x06000C3E RID: 3134 RVA: 0x00029ED6 File Offset: 0x000280D6
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_TextAlignment AddNewTextAlignment()
		{
			if (this.textAlignmentField == null)
			{
				this.textAlignmentField = new global::NPOI.OpenXmlFormats.Wordprocessing.CT_TextAlignment();
			}
			return this.textAlignmentField;
		}

		// Token: 0x06000C3F RID: 3135 RVA: 0x00029EF1 File Offset: 0x000280F1
		public bool IsSetPStyle()
		{
			return this.pStyleField != null && !string.IsNullOrEmpty(this.pStyleField.val);
		}

		// Token: 0x06000C40 RID: 3136 RVA: 0x00029F10 File Offset: 0x00028110
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_String AddNewPStyle()
		{
			if (this.pStyleField == null)
			{
				this.pStyleField = new global::NPOI.OpenXmlFormats.Wordprocessing.CT_String();
			}
			return this.pStyleField;
		}

		// Token: 0x06000C41 RID: 3137 RVA: 0x00029F2B File Offset: 0x0002812B
		public bool IsSetShd()
		{
			return this.shdField != null;
		}

		// Token: 0x06000C42 RID: 3138 RVA: 0x00029F36 File Offset: 0x00028136
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_Shd AddNewShd()
		{
			if (this.shdField == null)
			{
				this.shdField = new global::NPOI.OpenXmlFormats.Wordprocessing.CT_Shd();
			}
			return this.shdField;
		}

		// Token: 0x06000C43 RID: 3139 RVA: 0x00029F51 File Offset: 0x00028151
		public bool IsSetJc()
		{
			return this.jcField != null;
		}

		// Token: 0x06000C44 RID: 3140 RVA: 0x00029F5C File Offset: 0x0002815C
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_Jc AddNewJc()
		{
			if (this.jcField == null)
			{
				this.jcField = new global::NPOI.OpenXmlFormats.Wordprocessing.CT_Jc();
			}
			return this.jcField;
		}

		// Token: 0x06000C45 RID: 3141 RVA: 0x00029F77 File Offset: 0x00028177
		public bool IsSetPBdr()
		{
			return this.pBdrField != null;
		}

		// Token: 0x06000C46 RID: 3142 RVA: 0x00029F82 File Offset: 0x00028182
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_Spacing AddNewSpacing()
		{
			if (this.spacingField == null)
			{
				this.spacingField = new global::NPOI.OpenXmlFormats.Wordprocessing.CT_Spacing();
			}
			return this.spacingField;
		}

		// Token: 0x06000C47 RID: 3143 RVA: 0x00029F9D File Offset: 0x0002819D
		public bool IsSetPageBreakBefore()
		{
			return this.pageBreakBeforeField != null && this.pageBreakBeforeField.val;
		}

		// Token: 0x06000C48 RID: 3144 RVA: 0x00029FB4 File Offset: 0x000281B4
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff AddNewPageBreakBefore()
		{
			if (this.pageBreakBeforeField == null)
			{
				this.pageBreakBeforeField = new global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff();
			}
			return this.pageBreakBeforeField;
		}

		// Token: 0x06000C49 RID: 3145 RVA: 0x00029FCF File Offset: 0x000281CF
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_PBdr AddNewPBdr()
		{
			if (this.pBdrField == null)
			{
				this.pBdrField = new global::NPOI.OpenXmlFormats.Wordprocessing.CT_PBdr();
			}
			return this.pBdrField;
		}

		// Token: 0x06000C4A RID: 3146 RVA: 0x00029FEA File Offset: 0x000281EA
		public bool IsSetWordWrap()
		{
			return this.wordWrapField != null && this.wordWrapField.val;
		}

		// Token: 0x06000C4B RID: 3147 RVA: 0x0002A001 File Offset: 0x00028201
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff AddNewWordWrap()
		{
			if (this.wordWrapField == null)
			{
				this.wordWrapField = new global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff();
			}
			return this.wordWrapField;
		}

		// Token: 0x06000C4C RID: 3148 RVA: 0x0002A01C File Offset: 0x0002821C
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_Ind AddNewInd()
		{
			if (this.indField == null)
			{
				this.indField = new global::NPOI.OpenXmlFormats.Wordprocessing.CT_Ind();
			}
			return this.indField;
		}

		// Token: 0x06000C4D RID: 3149 RVA: 0x0002A038 File Offset: 0x00028238
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_Tabs AddNewTabs()
		{
			global::NPOI.OpenXmlFormats.Wordprocessing.CT_Tabs ct_Tabs = new global::NPOI.OpenXmlFormats.Wordprocessing.CT_Tabs();
			this.tabsField = ct_Tabs.tab;
			return ct_Tabs;
		}

		// Token: 0x04000AAF RID: 2735
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_String pStyleField;

		// Token: 0x04000AB0 RID: 2736
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff keepNextField;

		// Token: 0x04000AB1 RID: 2737
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff keepLinesField;

		// Token: 0x04000AB2 RID: 2738
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff pageBreakBeforeField;

		// Token: 0x04000AB3 RID: 2739
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_FramePr framePrField;

		// Token: 0x04000AB4 RID: 2740
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff widowControlField;

		// Token: 0x04000AB5 RID: 2741
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_NumPr numPrField;

		// Token: 0x04000AB6 RID: 2742
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff suppressLineNumbersField;

		// Token: 0x04000AB7 RID: 2743
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_PBdr pBdrField;

		// Token: 0x04000AB8 RID: 2744
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_Shd shdField;

		// Token: 0x04000AB9 RID: 2745
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.CT_TabStop> tabsField;

		// Token: 0x04000ABA RID: 2746
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff suppressAutoHyphensField;

		// Token: 0x04000ABB RID: 2747
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff kinsokuField;

		// Token: 0x04000ABC RID: 2748
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff wordWrapField;

		// Token: 0x04000ABD RID: 2749
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff overflowPunctField;

		// Token: 0x04000ABE RID: 2750
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff topLinePunctField;

		// Token: 0x04000ABF RID: 2751
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff autoSpaceDEField;

		// Token: 0x04000AC0 RID: 2752
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff autoSpaceDNField;

		// Token: 0x04000AC1 RID: 2753
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff bidiField;

		// Token: 0x04000AC2 RID: 2754
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff adjustRightIndField;

		// Token: 0x04000AC3 RID: 2755
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff snapToGridField;

		// Token: 0x04000AC4 RID: 2756
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_Spacing spacingField;

		// Token: 0x04000AC5 RID: 2757
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_Ind indField;

		// Token: 0x04000AC6 RID: 2758
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff contextualSpacingField;

		// Token: 0x04000AC7 RID: 2759
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff mirrorIndentsField;

		// Token: 0x04000AC8 RID: 2760
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff suppressOverlapField;

		// Token: 0x04000AC9 RID: 2761
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_Jc jcField;

		// Token: 0x04000ACA RID: 2762
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_TextDirection textDirectionField;

		// Token: 0x04000ACB RID: 2763
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_TextAlignment textAlignmentField;

		// Token: 0x04000ACC RID: 2764
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_TextboxTightWrap textboxTightWrapField;

		// Token: 0x04000ACD RID: 2765
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_DecimalNumber outlineLvlField;

		// Token: 0x04000ACE RID: 2766
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_DecimalNumber divIdField;

		// Token: 0x04000ACF RID: 2767
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_Cnf cnfStyleField;
	}
}
