using System;
using System.ComponentModel;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Spreadsheet
{
	// Token: 0x0200057F RID: 1407
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
	[global::System.Serializable]
	public class CT_PivotArea
	{
		// Token: 0x06003D72 RID: 15730 RVA: 0x000953F9 File Offset: 0x000935F9
		public CT_PivotArea()
		{
			this.typeField = global::NPOI.OpenXmlFormats.Spreadsheet.ST_PivotAreaType.normal;
			this.dataOnlyField = true;
			this.labelOnlyField = false;
			this.grandRowField = false;
			this.grandColField = false;
			this.cacheIndexField = false;
			this.outlineField = true;
			this.collapsedLevelsAreSubtotalsField = false;
		}

		// Token: 0x06003D73 RID: 15731 RVA: 0x0009543C File Offset: 0x0009363C
		public static global::NPOI.OpenXmlFormats.Spreadsheet.CT_PivotArea Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_PivotArea ct_PivotArea = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_PivotArea();
			ct_PivotArea.field = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadInt(node.Attributes["field"]);
			if (node.Attributes["type"] != null)
			{
				ct_PivotArea.type = (global::NPOI.OpenXmlFormats.Spreadsheet.ST_PivotAreaType)global::System.Enum.Parse(typeof(global::NPOI.OpenXmlFormats.Spreadsheet.ST_PivotAreaType), node.Attributes["type"].Value);
			}
			ct_PivotArea.dataOnly = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["dataOnly"]);
			ct_PivotArea.labelOnly = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["labelOnly"]);
			ct_PivotArea.grandRow = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["grandRow"]);
			ct_PivotArea.grandCol = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["grandCol"]);
			ct_PivotArea.cacheIndex = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["cacheIndex"]);
			ct_PivotArea.outline = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["outline"]);
			ct_PivotArea.offset = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["offset"]);
			ct_PivotArea.collapsedLevelsAreSubtotals = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["collapsedLevelsAreSubtotals"]);
			if (node.Attributes["axis"] != null)
			{
				ct_PivotArea.axis = (global::NPOI.OpenXmlFormats.Spreadsheet.ST_Axis)global::System.Enum.Parse(typeof(global::NPOI.OpenXmlFormats.Spreadsheet.ST_Axis), node.Attributes["axis"].Value);
			}
			ct_PivotArea.fieldPosition = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadUInt(node.Attributes["fieldPosition"]);
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "references")
				{
					ct_PivotArea.references = global::NPOI.OpenXmlFormats.Spreadsheet.CT_PivotAreaReferences.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "extLst")
				{
					ct_PivotArea.extLst = global::NPOI.OpenXmlFormats.Spreadsheet.CT_ExtensionList.Parse(xmlNode, namespaceManager);
				}
			}
			return ct_PivotArea;
		}

		// Token: 0x06003D74 RID: 15732 RVA: 0x0009566C File Offset: 0x0009386C
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "field", this.field);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "type", this.type.ToString());
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "dataOnly", this.dataOnly);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "labelOnly", this.labelOnly);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "grandRow", this.grandRow);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "grandCol", this.grandCol);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "cacheIndex", this.cacheIndex);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "outline", this.outline);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "offset", this.offset);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "collapsedLevelsAreSubtotals", this.collapsedLevelsAreSubtotals);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "axis", this.axis.ToString());
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "fieldPosition", this.fieldPosition, false);
			sw.Write(">");
			if (this.references != null)
			{
				this.references.Write(sw, "references");
			}
			if (this.extLst != null)
			{
				this.extLst.Write(sw, "extLst");
			}
			sw.Write(string.Format("</{0}>", nodeName));
		}

		// Token: 0x1700170A RID: 5898
		// (get) Token: 0x06003D75 RID: 15733 RVA: 0x000957C1 File Offset: 0x000939C1
		// (set) Token: 0x06003D76 RID: 15734 RVA: 0x000957C9 File Offset: 0x000939C9
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_PivotAreaReferences references
		{
			get
			{
				return this.referencesField;
			}
			set
			{
				this.referencesField = value;
			}
		}

		// Token: 0x1700170B RID: 5899
		// (get) Token: 0x06003D77 RID: 15735 RVA: 0x000957D2 File Offset: 0x000939D2
		// (set) Token: 0x06003D78 RID: 15736 RVA: 0x000957DA File Offset: 0x000939DA
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_ExtensionList extLst
		{
			get
			{
				return this.extLstField;
			}
			set
			{
				this.extLstField = value;
			}
		}

		// Token: 0x1700170C RID: 5900
		// (get) Token: 0x06003D79 RID: 15737 RVA: 0x000957E3 File Offset: 0x000939E3
		// (set) Token: 0x06003D7A RID: 15738 RVA: 0x000957EB File Offset: 0x000939EB
		[global::System.Xml.Serialization.XmlAttribute]
		public int field
		{
			get
			{
				return this.fieldField;
			}
			set
			{
				this.fieldField = value;
			}
		}

		// Token: 0x1700170D RID: 5901
		// (get) Token: 0x06003D7B RID: 15739 RVA: 0x000957F4 File Offset: 0x000939F4
		// (set) Token: 0x06003D7C RID: 15740 RVA: 0x000957FC File Offset: 0x000939FC
		[global::System.Xml.Serialization.XmlIgnore]
		public bool fieldSpecified
		{
			get
			{
				return this.fieldFieldSpecified;
			}
			set
			{
				this.fieldFieldSpecified = value;
			}
		}

		// Token: 0x1700170E RID: 5902
		// (get) Token: 0x06003D7D RID: 15741 RVA: 0x00095805 File Offset: 0x00093A05
		// (set) Token: 0x06003D7E RID: 15742 RVA: 0x0009580D File Offset: 0x00093A0D
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(global::NPOI.OpenXmlFormats.Spreadsheet.ST_PivotAreaType.normal)]
		public global::NPOI.OpenXmlFormats.Spreadsheet.ST_PivotAreaType type
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

		// Token: 0x1700170F RID: 5903
		// (get) Token: 0x06003D7F RID: 15743 RVA: 0x00095816 File Offset: 0x00093A16
		// (set) Token: 0x06003D80 RID: 15744 RVA: 0x0009581E File Offset: 0x00093A1E
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(true)]
		public bool dataOnly
		{
			get
			{
				return this.dataOnlyField;
			}
			set
			{
				this.dataOnlyField = value;
			}
		}

		// Token: 0x17001710 RID: 5904
		// (get) Token: 0x06003D81 RID: 15745 RVA: 0x00095827 File Offset: 0x00093A27
		// (set) Token: 0x06003D82 RID: 15746 RVA: 0x0009582F File Offset: 0x00093A2F
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(false)]
		public bool labelOnly
		{
			get
			{
				return this.labelOnlyField;
			}
			set
			{
				this.labelOnlyField = value;
			}
		}

		// Token: 0x17001711 RID: 5905
		// (get) Token: 0x06003D83 RID: 15747 RVA: 0x00095838 File Offset: 0x00093A38
		// (set) Token: 0x06003D84 RID: 15748 RVA: 0x00095840 File Offset: 0x00093A40
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(false)]
		public bool grandRow
		{
			get
			{
				return this.grandRowField;
			}
			set
			{
				this.grandRowField = value;
			}
		}

		// Token: 0x17001712 RID: 5906
		// (get) Token: 0x06003D85 RID: 15749 RVA: 0x00095849 File Offset: 0x00093A49
		// (set) Token: 0x06003D86 RID: 15750 RVA: 0x00095851 File Offset: 0x00093A51
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(false)]
		public bool grandCol
		{
			get
			{
				return this.grandColField;
			}
			set
			{
				this.grandColField = value;
			}
		}

		// Token: 0x17001713 RID: 5907
		// (get) Token: 0x06003D87 RID: 15751 RVA: 0x0009585A File Offset: 0x00093A5A
		// (set) Token: 0x06003D88 RID: 15752 RVA: 0x00095862 File Offset: 0x00093A62
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(false)]
		public bool cacheIndex
		{
			get
			{
				return this.cacheIndexField;
			}
			set
			{
				this.cacheIndexField = value;
			}
		}

		// Token: 0x17001714 RID: 5908
		// (get) Token: 0x06003D89 RID: 15753 RVA: 0x0009586B File Offset: 0x00093A6B
		// (set) Token: 0x06003D8A RID: 15754 RVA: 0x00095873 File Offset: 0x00093A73
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(true)]
		public bool outline
		{
			get
			{
				return this.outlineField;
			}
			set
			{
				this.outlineField = value;
			}
		}

		// Token: 0x17001715 RID: 5909
		// (get) Token: 0x06003D8B RID: 15755 RVA: 0x0009587C File Offset: 0x00093A7C
		// (set) Token: 0x06003D8C RID: 15756 RVA: 0x00095884 File Offset: 0x00093A84
		[global::System.Xml.Serialization.XmlAttribute]
		public string offset
		{
			get
			{
				return this.offsetField;
			}
			set
			{
				this.offsetField = value;
			}
		}

		// Token: 0x17001716 RID: 5910
		// (get) Token: 0x06003D8D RID: 15757 RVA: 0x0009588D File Offset: 0x00093A8D
		// (set) Token: 0x06003D8E RID: 15758 RVA: 0x00095895 File Offset: 0x00093A95
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(false)]
		public bool collapsedLevelsAreSubtotals
		{
			get
			{
				return this.collapsedLevelsAreSubtotalsField;
			}
			set
			{
				this.collapsedLevelsAreSubtotalsField = value;
			}
		}

		// Token: 0x17001717 RID: 5911
		// (get) Token: 0x06003D8F RID: 15759 RVA: 0x0009589E File Offset: 0x00093A9E
		// (set) Token: 0x06003D90 RID: 15760 RVA: 0x000958A6 File Offset: 0x00093AA6
		[global::System.Xml.Serialization.XmlAttribute]
		public global::NPOI.OpenXmlFormats.Spreadsheet.ST_Axis axis
		{
			get
			{
				return this.axisField;
			}
			set
			{
				this.axisField = value;
			}
		}

		// Token: 0x17001718 RID: 5912
		// (get) Token: 0x06003D91 RID: 15761 RVA: 0x000958AF File Offset: 0x00093AAF
		// (set) Token: 0x06003D92 RID: 15762 RVA: 0x000958B7 File Offset: 0x00093AB7
		[global::System.Xml.Serialization.XmlIgnore]
		public bool axisSpecified
		{
			get
			{
				return this.axisFieldSpecified;
			}
			set
			{
				this.axisFieldSpecified = value;
			}
		}

		// Token: 0x17001719 RID: 5913
		// (get) Token: 0x06003D93 RID: 15763 RVA: 0x000958C0 File Offset: 0x00093AC0
		// (set) Token: 0x06003D94 RID: 15764 RVA: 0x000958C8 File Offset: 0x00093AC8
		[global::System.Xml.Serialization.XmlAttribute]
		public uint fieldPosition
		{
			get
			{
				return this.fieldPositionField;
			}
			set
			{
				this.fieldPositionField = value;
			}
		}

		// Token: 0x1700171A RID: 5914
		// (get) Token: 0x06003D95 RID: 15765 RVA: 0x000958D1 File Offset: 0x00093AD1
		// (set) Token: 0x06003D96 RID: 15766 RVA: 0x000958D9 File Offset: 0x00093AD9
		[global::System.Xml.Serialization.XmlIgnore]
		public bool fieldPositionSpecified
		{
			get
			{
				return this.fieldPositionFieldSpecified;
			}
			set
			{
				this.fieldPositionFieldSpecified = value;
			}
		}

		// Token: 0x0400272C RID: 10028
		private global::NPOI.OpenXmlFormats.Spreadsheet.CT_PivotAreaReferences referencesField;

		// Token: 0x0400272D RID: 10029
		private global::NPOI.OpenXmlFormats.Spreadsheet.CT_ExtensionList extLstField;

		// Token: 0x0400272E RID: 10030
		private int fieldField;

		// Token: 0x0400272F RID: 10031
		private bool fieldFieldSpecified;

		// Token: 0x04002730 RID: 10032
		private global::NPOI.OpenXmlFormats.Spreadsheet.ST_PivotAreaType typeField;

		// Token: 0x04002731 RID: 10033
		private bool dataOnlyField;

		// Token: 0x04002732 RID: 10034
		private bool labelOnlyField;

		// Token: 0x04002733 RID: 10035
		private bool grandRowField;

		// Token: 0x04002734 RID: 10036
		private bool grandColField;

		// Token: 0x04002735 RID: 10037
		private bool cacheIndexField;

		// Token: 0x04002736 RID: 10038
		private bool outlineField;

		// Token: 0x04002737 RID: 10039
		private string offsetField;

		// Token: 0x04002738 RID: 10040
		private bool collapsedLevelsAreSubtotalsField;

		// Token: 0x04002739 RID: 10041
		private global::NPOI.OpenXmlFormats.Spreadsheet.ST_Axis axisField;

		// Token: 0x0400273A RID: 10042
		private bool axisFieldSpecified;

		// Token: 0x0400273B RID: 10043
		private uint fieldPositionField;

		// Token: 0x0400273C RID: 10044
		private bool fieldPositionFieldSpecified;
	}
}
