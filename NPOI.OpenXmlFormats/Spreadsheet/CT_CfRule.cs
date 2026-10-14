using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Spreadsheet
{
	// Token: 0x0200059D RID: 1437
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
	[global::System.Serializable]
	public class CT_CfRule
	{
		// Token: 0x06003F57 RID: 16215 RVA: 0x00099953 File Offset: 0x00097B53
		public CT_CfRule()
		{
			this.dxfIdSpecified = false;
			this.stopIfTrueField = false;
			this.aboveAverageField = true;
			this.percentField = false;
			this.bottomField = false;
			this.equalAverageField = false;
		}

		// Token: 0x06003F58 RID: 16216 RVA: 0x00099988 File Offset: 0x00097B88
		public static global::NPOI.OpenXmlFormats.Spreadsheet.CT_CfRule Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_CfRule ct_CfRule = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_CfRule();
			if (node.Attributes["type"] != null)
			{
				ct_CfRule.type = (global::NPOI.OpenXmlFormats.Spreadsheet.ST_CfType)global::System.Enum.Parse(typeof(global::NPOI.OpenXmlFormats.Spreadsheet.ST_CfType), node.Attributes["type"].Value);
			}
			if (node.Attributes["dxfId"] != null)
			{
				ct_CfRule.dxfId = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadUInt(node.Attributes["dxfId"]);
				ct_CfRule.dxfIdFieldSpecified = true;
			}
			ct_CfRule.priority = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadInt(node.Attributes["priority"]);
			ct_CfRule.stopIfTrue = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["stopIfTrue"]);
			if (node.Attributes["aboveAverage"] != null)
			{
				ct_CfRule.aboveAverage = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["aboveAverage"]);
			}
			ct_CfRule.percent = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["percent"]);
			ct_CfRule.bottom = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["bottom"]);
			if (node.Attributes["operator"] != null)
			{
				ct_CfRule.@operator = new global::NPOI.OpenXmlFormats.Spreadsheet.ST_ConditionalFormattingOperator?((global::NPOI.OpenXmlFormats.Spreadsheet.ST_ConditionalFormattingOperator)global::System.Enum.Parse(typeof(global::NPOI.OpenXmlFormats.Spreadsheet.ST_ConditionalFormattingOperator), node.Attributes["operator"].Value));
			}
			ct_CfRule.text = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["text"]);
			if (node.Attributes["timePeriod"] != null)
			{
				ct_CfRule.timePeriod = new global::NPOI.OpenXmlFormats.Spreadsheet.ST_TimePeriod?((global::NPOI.OpenXmlFormats.Spreadsheet.ST_TimePeriod)global::System.Enum.Parse(typeof(global::NPOI.OpenXmlFormats.Spreadsheet.ST_TimePeriod), node.Attributes["timePeriod"].Value));
			}
			ct_CfRule.rank = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadUInt(node.Attributes["rank"]);
			ct_CfRule.stdDev = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadInt(node.Attributes["stdDev"]);
			ct_CfRule.equalAverage = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["equalAverage"]);
			ct_CfRule.formula = new global::System.Collections.Generic.List<string>();
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "colorScale")
				{
					ct_CfRule.colorScale = global::NPOI.OpenXmlFormats.Spreadsheet.CT_ColorScale.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "dataBar")
				{
					ct_CfRule.dataBar = global::NPOI.OpenXmlFormats.Spreadsheet.CT_DataBar.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "iconSet")
				{
					ct_CfRule.iconSet = global::NPOI.OpenXmlFormats.Spreadsheet.CT_IconSet.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "extLst")
				{
					ct_CfRule.extLst = global::NPOI.OpenXmlFormats.Spreadsheet.CT_ExtensionList.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "formula")
				{
					ct_CfRule.formula.Add(xmlNode.InnerText);
				}
			}
			return ct_CfRule;
		}

		// Token: 0x06003F59 RID: 16217 RVA: 0x00099CA8 File Offset: 0x00097EA8
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "type", this.type.ToString());
			if (this.dxfIdSpecified)
			{
				global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "dxfId", this.dxfId, true);
			}
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "priority", this.priority, true);
			if (this.stopIfTrue)
			{
				global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "stopIfTrue", this.stopIfTrue);
			}
			if (this.aboveAverage)
			{
				global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "aboveAverage", this.aboveAverage, true);
			}
			if (this.percent)
			{
				global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "percent", this.percent);
			}
			if (this.bottom)
			{
				global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "bottom", this.bottom);
			}
			if (this.@operator != null)
			{
				global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "operator", this.@operator.ToString());
			}
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "text", this.text);
			if (this.timePeriodField != null)
			{
				global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "timePeriod", this.timePeriod.ToString());
			}
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "rank", this.rank, false);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "stdDev", this.stdDev);
			if (this.equalAverageField)
			{
				global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "equalAverage", this.equalAverage);
			}
			sw.Write(">");
			if (this.colorScale != null)
			{
				this.colorScale.Write(sw, "colorScale");
			}
			if (this.dataBar != null)
			{
				this.dataBar.Write(sw, "dataBar");
			}
			if (this.iconSet != null)
			{
				this.iconSet.Write(sw, "iconSet");
			}
			if (this.extLst != null)
			{
				this.extLst.Write(sw, "extLst");
			}
			if (this.formula != null)
			{
				foreach (string xml in this.formula)
				{
					sw.Write(string.Format("<formula>{0}</formula>", global::NPOI.OpenXml4Net.Util.XmlHelper.EncodeXml(xml)));
				}
			}
			sw.Write(string.Format("</{0}>", nodeName));
		}

		// Token: 0x06003F5A RID: 16218 RVA: 0x00099F00 File Offset: 0x00098100
		public bool IsSetDxfId()
		{
			return this.dxfIdFieldSpecified;
		}

		// Token: 0x06003F5B RID: 16219 RVA: 0x00099F08 File Offset: 0x00098108
		public void AddFormula(string formula)
		{
			if (this.formula == null)
			{
				this.formula = new global::System.Collections.Generic.List<string>();
			}
			this.formula.Add(formula);
		}

		// Token: 0x06003F5C RID: 16220 RVA: 0x00099F2C File Offset: 0x0009812C
		public void Set(global::NPOI.OpenXmlFormats.Spreadsheet.CT_CfRule src)
		{
			this.formula = src.formula;
			this.stopIfTrue = src.stopIfTrue;
			this.bottom = src.bottom;
			this.percent = src.percent;
			this.dxfId = src.dxfId;
			this.priority = src.priority;
			this.@operator = src.@operator;
			this.type = src.type;
			this.equalAverage = src.equalAverage;
			this.aboveAverage = src.aboveAverage;
			this.colorScale = src.colorScale;
			this.dataBar = src.dataBar;
			this.iconSet = src.iconSet;
			this.extLst = src.extLst;
		}

		// Token: 0x06003F5D RID: 16221 RVA: 0x00099FE1 File Offset: 0x000981E1
		public int SizeOfFormulaArray()
		{
			return this.formula.Count;
		}

		// Token: 0x06003F5E RID: 16222 RVA: 0x00099FEE File Offset: 0x000981EE
		public string GetFormulaArray(int index)
		{
			return this.formula[index];
		}

		// Token: 0x06003F5F RID: 16223 RVA: 0x00099FFC File Offset: 0x000981FC
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_IconSet AddNewIconSet()
		{
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_IconSet ct_IconSet = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_IconSet();
			this.iconSet = ct_IconSet;
			return ct_IconSet;
		}

		// Token: 0x06003F60 RID: 16224 RVA: 0x0009A017 File Offset: 0x00098217
		public bool IsSetIconSet()
		{
			return this.iconSetField != null;
		}

		// Token: 0x06003F61 RID: 16225 RVA: 0x0009A022 File Offset: 0x00098222
		public bool IsSetColorScale()
		{
			return this.colorScale != null;
		}

		// Token: 0x06003F62 RID: 16226 RVA: 0x0009A02D File Offset: 0x0009822D
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_ColorScale AddNewColorScale()
		{
			this.colorScale = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_ColorScale();
			return this.colorScale;
		}

		// Token: 0x06003F63 RID: 16227 RVA: 0x0009A040 File Offset: 0x00098240
		public bool IsSetDataBar()
		{
			return this.dataBar != null;
		}

		// Token: 0x06003F64 RID: 16228 RVA: 0x0009A04B File Offset: 0x0009824B
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_DataBar AddNewDataBar()
		{
			this.dataBar = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_DataBar();
			return this.dataBar;
		}

		// Token: 0x170017D4 RID: 6100
		// (get) Token: 0x06003F65 RID: 16229 RVA: 0x0009A05E File Offset: 0x0009825E
		// (set) Token: 0x06003F66 RID: 16230 RVA: 0x0009A066 File Offset: 0x00098266
		[global::System.Xml.Serialization.XmlElement]
		public global::System.Collections.Generic.List<string> formula
		{
			get
			{
				return this.formulaField;
			}
			set
			{
				this.formulaField = value;
			}
		}

		// Token: 0x170017D5 RID: 6101
		// (get) Token: 0x06003F67 RID: 16231 RVA: 0x0009A06F File Offset: 0x0009826F
		// (set) Token: 0x06003F68 RID: 16232 RVA: 0x0009A077 File Offset: 0x00098277
		[global::System.Xml.Serialization.XmlElement]
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_ColorScale colorScale
		{
			get
			{
				return this.colorScaleField;
			}
			set
			{
				this.colorScaleField = value;
			}
		}

		// Token: 0x170017D6 RID: 6102
		// (get) Token: 0x06003F69 RID: 16233 RVA: 0x0009A080 File Offset: 0x00098280
		// (set) Token: 0x06003F6A RID: 16234 RVA: 0x0009A088 File Offset: 0x00098288
		[global::System.Xml.Serialization.XmlElement]
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_DataBar dataBar
		{
			get
			{
				return this.dataBarField;
			}
			set
			{
				this.dataBarField = value;
			}
		}

		// Token: 0x170017D7 RID: 6103
		// (get) Token: 0x06003F6B RID: 16235 RVA: 0x0009A091 File Offset: 0x00098291
		// (set) Token: 0x06003F6C RID: 16236 RVA: 0x0009A099 File Offset: 0x00098299
		[global::System.Xml.Serialization.XmlElement]
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_IconSet iconSet
		{
			get
			{
				return this.iconSetField;
			}
			set
			{
				this.iconSetField = value;
			}
		}

		// Token: 0x170017D8 RID: 6104
		// (get) Token: 0x06003F6D RID: 16237 RVA: 0x0009A0A2 File Offset: 0x000982A2
		// (set) Token: 0x06003F6E RID: 16238 RVA: 0x0009A0AA File Offset: 0x000982AA
		[global::System.Xml.Serialization.XmlElement]
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

		// Token: 0x170017D9 RID: 6105
		// (get) Token: 0x06003F6F RID: 16239 RVA: 0x0009A0B3 File Offset: 0x000982B3
		// (set) Token: 0x06003F70 RID: 16240 RVA: 0x0009A0BB File Offset: 0x000982BB
		[global::System.Xml.Serialization.XmlAttribute]
		public global::NPOI.OpenXmlFormats.Spreadsheet.ST_CfType type
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

		// Token: 0x170017DA RID: 6106
		// (get) Token: 0x06003F71 RID: 16241 RVA: 0x0009A0C4 File Offset: 0x000982C4
		// (set) Token: 0x06003F72 RID: 16242 RVA: 0x0009A0CC File Offset: 0x000982CC
		[global::System.Xml.Serialization.XmlIgnore]
		public bool typeSpecified
		{
			get
			{
				return this.typeFieldSpecified;
			}
			set
			{
				this.typeFieldSpecified = value;
			}
		}

		// Token: 0x170017DB RID: 6107
		// (get) Token: 0x06003F73 RID: 16243 RVA: 0x0009A0D5 File Offset: 0x000982D5
		// (set) Token: 0x06003F74 RID: 16244 RVA: 0x0009A0DD File Offset: 0x000982DD
		[global::System.Xml.Serialization.XmlAttribute]
		public uint dxfId
		{
			get
			{
				return this.dxfIdField;
			}
			set
			{
				this.dxfIdField = value;
				this.dxfIdFieldSpecified = true;
			}
		}

		// Token: 0x170017DC RID: 6108
		// (get) Token: 0x06003F75 RID: 16245 RVA: 0x00099F00 File Offset: 0x00098100
		// (set) Token: 0x06003F76 RID: 16246 RVA: 0x0009A0ED File Offset: 0x000982ED
		[global::System.Xml.Serialization.XmlIgnore]
		public bool dxfIdSpecified
		{
			get
			{
				return this.dxfIdFieldSpecified;
			}
			set
			{
				this.dxfIdFieldSpecified = value;
			}
		}

		// Token: 0x170017DD RID: 6109
		// (get) Token: 0x06003F77 RID: 16247 RVA: 0x0009A0F6 File Offset: 0x000982F6
		// (set) Token: 0x06003F78 RID: 16248 RVA: 0x0009A0FE File Offset: 0x000982FE
		[global::System.Xml.Serialization.XmlAttribute]
		public int priority
		{
			get
			{
				return this.priorityField;
			}
			set
			{
				this.priorityField = value;
			}
		}

		// Token: 0x170017DE RID: 6110
		// (get) Token: 0x06003F79 RID: 16249 RVA: 0x0009A107 File Offset: 0x00098307
		// (set) Token: 0x06003F7A RID: 16250 RVA: 0x0009A10F File Offset: 0x0009830F
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(false)]
		public bool stopIfTrue
		{
			get
			{
				return this.stopIfTrueField;
			}
			set
			{
				this.stopIfTrueField = value;
			}
		}

		// Token: 0x170017DF RID: 6111
		// (get) Token: 0x06003F7B RID: 16251 RVA: 0x0009A118 File Offset: 0x00098318
		// (set) Token: 0x06003F7C RID: 16252 RVA: 0x0009A120 File Offset: 0x00098320
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(true)]
		public bool aboveAverage
		{
			get
			{
				return this.aboveAverageField;
			}
			set
			{
				this.aboveAverageField = value;
			}
		}

		// Token: 0x170017E0 RID: 6112
		// (get) Token: 0x06003F7D RID: 16253 RVA: 0x0009A129 File Offset: 0x00098329
		// (set) Token: 0x06003F7E RID: 16254 RVA: 0x0009A131 File Offset: 0x00098331
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(false)]
		public bool percent
		{
			get
			{
				return this.percentField;
			}
			set
			{
				this.percentField = value;
			}
		}

		// Token: 0x170017E1 RID: 6113
		// (get) Token: 0x06003F7F RID: 16255 RVA: 0x0009A13A File Offset: 0x0009833A
		// (set) Token: 0x06003F80 RID: 16256 RVA: 0x0009A142 File Offset: 0x00098342
		[global::System.ComponentModel.DefaultValue(false)]
		public bool bottom
		{
			get
			{
				return this.bottomField;
			}
			set
			{
				this.bottomField = value;
			}
		}

		// Token: 0x170017E2 RID: 6114
		// (get) Token: 0x06003F81 RID: 16257 RVA: 0x0009A14B File Offset: 0x0009834B
		// (set) Token: 0x06003F82 RID: 16258 RVA: 0x0009A153 File Offset: 0x00098353
		[global::System.Xml.Serialization.XmlAttribute]
		public global::NPOI.OpenXmlFormats.Spreadsheet.ST_ConditionalFormattingOperator? @operator
		{
			get
			{
				return this.operatorField;
			}
			set
			{
				this.operatorField = value;
			}
		}

		// Token: 0x170017E3 RID: 6115
		// (get) Token: 0x06003F83 RID: 16259 RVA: 0x0009A15C File Offset: 0x0009835C
		// (set) Token: 0x06003F84 RID: 16260 RVA: 0x0009A164 File Offset: 0x00098364
		[global::System.Xml.Serialization.XmlIgnore]
		public bool operatorSpecified
		{
			get
			{
				return this.operatorFieldSpecified;
			}
			set
			{
				this.operatorFieldSpecified = value;
			}
		}

		// Token: 0x170017E4 RID: 6116
		// (get) Token: 0x06003F85 RID: 16261 RVA: 0x0009A16D File Offset: 0x0009836D
		// (set) Token: 0x06003F86 RID: 16262 RVA: 0x0009A175 File Offset: 0x00098375
		[global::System.Xml.Serialization.XmlAttribute]
		public string text
		{
			get
			{
				return this.textField;
			}
			set
			{
				this.textField = value;
			}
		}

		// Token: 0x170017E5 RID: 6117
		// (get) Token: 0x06003F87 RID: 16263 RVA: 0x0009A17E File Offset: 0x0009837E
		// (set) Token: 0x06003F88 RID: 16264 RVA: 0x0009A186 File Offset: 0x00098386
		[global::System.Xml.Serialization.XmlAttribute]
		public global::NPOI.OpenXmlFormats.Spreadsheet.ST_TimePeriod? timePeriod
		{
			get
			{
				return this.timePeriodField;
			}
			set
			{
				this.timePeriodField = value;
			}
		}

		// Token: 0x170017E6 RID: 6118
		// (get) Token: 0x06003F89 RID: 16265 RVA: 0x0009A18F File Offset: 0x0009838F
		// (set) Token: 0x06003F8A RID: 16266 RVA: 0x0009A197 File Offset: 0x00098397
		[global::System.Xml.Serialization.XmlIgnore]
		public bool timePeriodSpecified
		{
			get
			{
				return this.timePeriodFieldSpecified;
			}
			set
			{
				this.timePeriodFieldSpecified = value;
			}
		}

		// Token: 0x170017E7 RID: 6119
		// (get) Token: 0x06003F8B RID: 16267 RVA: 0x0009A1A0 File Offset: 0x000983A0
		// (set) Token: 0x06003F8C RID: 16268 RVA: 0x0009A1A8 File Offset: 0x000983A8
		[global::System.Xml.Serialization.XmlAttribute]
		public uint rank
		{
			get
			{
				return this.rankField;
			}
			set
			{
				this.rankField = value;
			}
		}

		// Token: 0x170017E8 RID: 6120
		// (get) Token: 0x06003F8D RID: 16269 RVA: 0x0009A1B1 File Offset: 0x000983B1
		// (set) Token: 0x06003F8E RID: 16270 RVA: 0x0009A1B9 File Offset: 0x000983B9
		[global::System.Xml.Serialization.XmlIgnore]
		public bool rankSpecified
		{
			get
			{
				return this.rankFieldSpecified;
			}
			set
			{
				this.rankFieldSpecified = value;
			}
		}

		// Token: 0x170017E9 RID: 6121
		// (get) Token: 0x06003F8F RID: 16271 RVA: 0x0009A1C2 File Offset: 0x000983C2
		// (set) Token: 0x06003F90 RID: 16272 RVA: 0x0009A1CA File Offset: 0x000983CA
		[global::System.Xml.Serialization.XmlAttribute]
		public int stdDev
		{
			get
			{
				return this.stdDevField;
			}
			set
			{
				this.stdDevField = value;
			}
		}

		// Token: 0x170017EA RID: 6122
		// (get) Token: 0x06003F91 RID: 16273 RVA: 0x0009A1D3 File Offset: 0x000983D3
		// (set) Token: 0x06003F92 RID: 16274 RVA: 0x0009A1DB File Offset: 0x000983DB
		[global::System.Xml.Serialization.XmlIgnore]
		public bool stdDevSpecified
		{
			get
			{
				return this.stdDevFieldSpecified;
			}
			set
			{
				this.stdDevFieldSpecified = value;
			}
		}

		// Token: 0x170017EB RID: 6123
		// (get) Token: 0x06003F93 RID: 16275 RVA: 0x0009A1E4 File Offset: 0x000983E4
		// (set) Token: 0x06003F94 RID: 16276 RVA: 0x0009A1EC File Offset: 0x000983EC
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(false)]
		public bool equalAverage
		{
			get
			{
				return this.equalAverageField;
			}
			set
			{
				this.equalAverageField = value;
			}
		}

		// Token: 0x04002818 RID: 10264
		private global::System.Collections.Generic.List<string> formulaField;

		// Token: 0x04002819 RID: 10265
		private global::NPOI.OpenXmlFormats.Spreadsheet.CT_ColorScale colorScaleField;

		// Token: 0x0400281A RID: 10266
		private global::NPOI.OpenXmlFormats.Spreadsheet.CT_DataBar dataBarField;

		// Token: 0x0400281B RID: 10267
		private global::NPOI.OpenXmlFormats.Spreadsheet.CT_IconSet iconSetField;

		// Token: 0x0400281C RID: 10268
		private global::NPOI.OpenXmlFormats.Spreadsheet.CT_ExtensionList extLstField;

		// Token: 0x0400281D RID: 10269
		private global::NPOI.OpenXmlFormats.Spreadsheet.ST_CfType typeField;

		// Token: 0x0400281E RID: 10270
		private bool typeFieldSpecified;

		// Token: 0x0400281F RID: 10271
		private uint dxfIdField;

		// Token: 0x04002820 RID: 10272
		private bool dxfIdFieldSpecified;

		// Token: 0x04002821 RID: 10273
		private int priorityField;

		// Token: 0x04002822 RID: 10274
		private bool stopIfTrueField;

		// Token: 0x04002823 RID: 10275
		private bool aboveAverageField;

		// Token: 0x04002824 RID: 10276
		private bool percentField;

		// Token: 0x04002825 RID: 10277
		private bool bottomField;

		// Token: 0x04002826 RID: 10278
		private global::NPOI.OpenXmlFormats.Spreadsheet.ST_ConditionalFormattingOperator? operatorField;

		// Token: 0x04002827 RID: 10279
		private bool operatorFieldSpecified;

		// Token: 0x04002828 RID: 10280
		private string textField;

		// Token: 0x04002829 RID: 10281
		private global::NPOI.OpenXmlFormats.Spreadsheet.ST_TimePeriod? timePeriodField;

		// Token: 0x0400282A RID: 10282
		private bool timePeriodFieldSpecified;

		// Token: 0x0400282B RID: 10283
		private uint rankField;

		// Token: 0x0400282C RID: 10284
		private bool rankFieldSpecified;

		// Token: 0x0400282D RID: 10285
		private int stdDevField;

		// Token: 0x0400282E RID: 10286
		private bool stdDevFieldSpecified;

		// Token: 0x0400282F RID: 10287
		private bool equalAverageField;
	}
}
