using System;
using System.ComponentModel;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Spreadsheet
{
	// Token: 0x020004E8 RID: 1256
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
	[global::System.Serializable]
	public class CT_TableColumn
	{
		// Token: 0x060034D2 RID: 13522 RVA: 0x000845C3 File Offset: 0x000827C3
		public CT_TableColumn()
		{
			this.totalsRowFunctionField = global::NPOI.OpenXmlFormats.Spreadsheet.ST_TotalsRowFunction.none;
		}

		// Token: 0x060034D3 RID: 13523 RVA: 0x000845D4 File Offset: 0x000827D4
		public static global::NPOI.OpenXmlFormats.Spreadsheet.CT_TableColumn Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_TableColumn ct_TableColumn = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_TableColumn();
			if (node.Attributes["id"] != null)
			{
				ct_TableColumn.id = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadUInt(node.Attributes["id"]);
			}
			ct_TableColumn.uniqueName = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["uniqueName"]);
			ct_TableColumn.name = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["name"]);
			if (node.Attributes["totalsRowFunction"] != null)
			{
				ct_TableColumn.totalsRowFunction = (global::NPOI.OpenXmlFormats.Spreadsheet.ST_TotalsRowFunction)global::System.Enum.Parse(typeof(global::NPOI.OpenXmlFormats.Spreadsheet.ST_TotalsRowFunction), node.Attributes["totalsRowFunction"].Value);
			}
			ct_TableColumn.totalsRowLabel = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["totalsRowLabel"]);
			if (node.Attributes["queryTableFieldId"] != null)
			{
				ct_TableColumn.queryTableFieldId = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadUInt(node.Attributes["queryTableFieldId"]);
			}
			if (node.Attributes["headerRowDxfId"] != null)
			{
				ct_TableColumn.headerRowDxfId = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadUInt(node.Attributes["headerRowDxfId"]);
			}
			if (node.Attributes["dataDxfId"] != null)
			{
				ct_TableColumn.dataDxfId = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadUInt(node.Attributes["dataDxfId"]);
			}
			if (node.Attributes["totalsRowDxfId"] != null)
			{
				ct_TableColumn.totalsRowDxfId = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadUInt(node.Attributes["totalsRowDxfId"]);
			}
			ct_TableColumn.headerRowCellStyle = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["headerRowCellStyle"]);
			ct_TableColumn.dataCellStyle = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["dataCellStyle"]);
			ct_TableColumn.totalsRowCellStyle = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["totalsRowCellStyle"]);
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "calculatedColumnFormula")
				{
					ct_TableColumn.calculatedColumnFormula = global::NPOI.OpenXmlFormats.Spreadsheet.CT_TableFormula.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "totalsRowFormula")
				{
					ct_TableColumn.totalsRowFormula = global::NPOI.OpenXmlFormats.Spreadsheet.CT_TableFormula.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "xmlColumnPr")
				{
					ct_TableColumn.xmlColumnPr = global::NPOI.OpenXmlFormats.Spreadsheet.CT_XmlColumnPr.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "extLst")
				{
					ct_TableColumn.extLst = global::NPOI.OpenXmlFormats.Spreadsheet.CT_ExtensionList.Parse(xmlNode, namespaceManager);
				}
			}
			return ct_TableColumn;
		}

		// Token: 0x060034D4 RID: 13524 RVA: 0x00084880 File Offset: 0x00082A80
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "id", this.id, false);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "uniqueName", this.uniqueName);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "name", this.name);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "totalsRowFunction", this.totalsRowFunction.ToString());
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "totalsRowLabel", this.totalsRowLabel);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "queryTableFieldId", this.queryTableFieldId, false);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "headerRowDxfId", this.headerRowDxfId, false);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "dataDxfId", this.dataDxfId, false);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "totalsRowDxfId", this.totalsRowDxfId, false);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "headerRowCellStyle", this.headerRowCellStyle);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "dataCellStyle", this.dataCellStyle);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "totalsRowCellStyle", this.totalsRowCellStyle);
			sw.Write(">");
			if (this.calculatedColumnFormula != null)
			{
				this.calculatedColumnFormula.Write(sw, "calculatedColumnFormula");
			}
			if (this.totalsRowFormula != null)
			{
				this.totalsRowFormula.Write(sw, "totalsRowFormula");
			}
			if (this.xmlColumnPr != null)
			{
				this.xmlColumnPr.Write(sw, "xmlColumnPr");
			}
			if (this.extLst != null)
			{
				this.extLst.Write(sw, "extLst");
			}
			sw.Write(string.Format("</{0}>", nodeName));
		}

		// Token: 0x1700140E RID: 5134
		// (get) Token: 0x060034D5 RID: 13525 RVA: 0x000849FD File Offset: 0x00082BFD
		// (set) Token: 0x060034D6 RID: 13526 RVA: 0x00084A05 File Offset: 0x00082C05
		[global::System.Xml.Serialization.XmlElement]
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_TableFormula calculatedColumnFormula
		{
			get
			{
				return this.calculatedColumnFormulaField;
			}
			set
			{
				this.calculatedColumnFormulaField = value;
			}
		}

		// Token: 0x1700140F RID: 5135
		// (get) Token: 0x060034D7 RID: 13527 RVA: 0x00084A0E File Offset: 0x00082C0E
		// (set) Token: 0x060034D8 RID: 13528 RVA: 0x00084A16 File Offset: 0x00082C16
		[global::System.Xml.Serialization.XmlElement]
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_TableFormula totalsRowFormula
		{
			get
			{
				return this.totalsRowFormulaField;
			}
			set
			{
				this.totalsRowFormulaField = value;
			}
		}

		// Token: 0x17001410 RID: 5136
		// (get) Token: 0x060034D9 RID: 13529 RVA: 0x00084A1F File Offset: 0x00082C1F
		// (set) Token: 0x060034DA RID: 13530 RVA: 0x00084A27 File Offset: 0x00082C27
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_XmlColumnPr xmlColumnPr
		{
			get
			{
				return this.xmlColumnPrField;
			}
			set
			{
				this.xmlColumnPrField = value;
			}
		}

		// Token: 0x17001411 RID: 5137
		// (get) Token: 0x060034DB RID: 13531 RVA: 0x00084A30 File Offset: 0x00082C30
		// (set) Token: 0x060034DC RID: 13532 RVA: 0x00084A38 File Offset: 0x00082C38
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

		// Token: 0x17001412 RID: 5138
		// (get) Token: 0x060034DD RID: 13533 RVA: 0x00084A41 File Offset: 0x00082C41
		// (set) Token: 0x060034DE RID: 13534 RVA: 0x00084A49 File Offset: 0x00082C49
		[global::System.Xml.Serialization.XmlAttribute]
		public uint id
		{
			get
			{
				return this.idField;
			}
			set
			{
				this.idField = value;
			}
		}

		// Token: 0x17001413 RID: 5139
		// (get) Token: 0x060034DF RID: 13535 RVA: 0x00084A52 File Offset: 0x00082C52
		// (set) Token: 0x060034E0 RID: 13536 RVA: 0x00084A5A File Offset: 0x00082C5A
		[global::System.Xml.Serialization.XmlAttribute]
		public string uniqueName
		{
			get
			{
				return this.uniqueNameField;
			}
			set
			{
				this.uniqueNameField = value;
			}
		}

		// Token: 0x17001414 RID: 5140
		// (get) Token: 0x060034E1 RID: 13537 RVA: 0x00084A63 File Offset: 0x00082C63
		// (set) Token: 0x060034E2 RID: 13538 RVA: 0x00084A6B File Offset: 0x00082C6B
		[global::System.Xml.Serialization.XmlAttribute]
		public string name
		{
			get
			{
				return this.nameField;
			}
			set
			{
				this.nameField = value;
			}
		}

		// Token: 0x17001415 RID: 5141
		// (get) Token: 0x060034E3 RID: 13539 RVA: 0x00084A74 File Offset: 0x00082C74
		// (set) Token: 0x060034E4 RID: 13540 RVA: 0x00084A7C File Offset: 0x00082C7C
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(global::NPOI.OpenXmlFormats.Spreadsheet.ST_TotalsRowFunction.none)]
		public global::NPOI.OpenXmlFormats.Spreadsheet.ST_TotalsRowFunction totalsRowFunction
		{
			get
			{
				return this.totalsRowFunctionField;
			}
			set
			{
				this.totalsRowFunctionField = value;
			}
		}

		// Token: 0x17001416 RID: 5142
		// (get) Token: 0x060034E5 RID: 13541 RVA: 0x00084A85 File Offset: 0x00082C85
		// (set) Token: 0x060034E6 RID: 13542 RVA: 0x00084A8D File Offset: 0x00082C8D
		[global::System.Xml.Serialization.XmlAttribute]
		public string totalsRowLabel
		{
			get
			{
				return this.totalsRowLabelField;
			}
			set
			{
				this.totalsRowLabelField = value;
			}
		}

		// Token: 0x17001417 RID: 5143
		// (get) Token: 0x060034E7 RID: 13543 RVA: 0x00084A96 File Offset: 0x00082C96
		// (set) Token: 0x060034E8 RID: 13544 RVA: 0x00084A9E File Offset: 0x00082C9E
		[global::System.Xml.Serialization.XmlAttribute]
		public uint queryTableFieldId
		{
			get
			{
				return this.queryTableFieldIdField;
			}
			set
			{
				this.queryTableFieldIdField = value;
			}
		}

		// Token: 0x17001418 RID: 5144
		// (get) Token: 0x060034E9 RID: 13545 RVA: 0x00084AA7 File Offset: 0x00082CA7
		// (set) Token: 0x060034EA RID: 13546 RVA: 0x00084AAF File Offset: 0x00082CAF
		[global::System.Xml.Serialization.XmlIgnore]
		public bool queryTableFieldIdSpecified
		{
			get
			{
				return this.queryTableFieldIdFieldSpecified;
			}
			set
			{
				this.queryTableFieldIdFieldSpecified = value;
			}
		}

		// Token: 0x17001419 RID: 5145
		// (get) Token: 0x060034EB RID: 13547 RVA: 0x00084AB8 File Offset: 0x00082CB8
		// (set) Token: 0x060034EC RID: 13548 RVA: 0x00084AC0 File Offset: 0x00082CC0
		[global::System.Xml.Serialization.XmlAttribute]
		public uint headerRowDxfId
		{
			get
			{
				return this.headerRowDxfIdField;
			}
			set
			{
				this.headerRowDxfIdField = value;
			}
		}

		// Token: 0x1700141A RID: 5146
		// (get) Token: 0x060034ED RID: 13549 RVA: 0x00084AC9 File Offset: 0x00082CC9
		// (set) Token: 0x060034EE RID: 13550 RVA: 0x00084AD1 File Offset: 0x00082CD1
		[global::System.Xml.Serialization.XmlIgnore]
		public bool headerRowDxfIdSpecified
		{
			get
			{
				return this.headerRowDxfIdFieldSpecified;
			}
			set
			{
				this.headerRowDxfIdFieldSpecified = value;
			}
		}

		// Token: 0x1700141B RID: 5147
		// (get) Token: 0x060034EF RID: 13551 RVA: 0x00084ADA File Offset: 0x00082CDA
		// (set) Token: 0x060034F0 RID: 13552 RVA: 0x00084AE2 File Offset: 0x00082CE2
		[global::System.Xml.Serialization.XmlAttribute]
		public uint dataDxfId
		{
			get
			{
				return this.dataDxfIdField;
			}
			set
			{
				this.dataDxfIdField = value;
			}
		}

		// Token: 0x1700141C RID: 5148
		// (get) Token: 0x060034F1 RID: 13553 RVA: 0x00084AEB File Offset: 0x00082CEB
		// (set) Token: 0x060034F2 RID: 13554 RVA: 0x00084AF3 File Offset: 0x00082CF3
		[global::System.Xml.Serialization.XmlIgnore]
		public bool dataDxfIdSpecified
		{
			get
			{
				return this.dataDxfIdFieldSpecified;
			}
			set
			{
				this.dataDxfIdFieldSpecified = value;
			}
		}

		// Token: 0x1700141D RID: 5149
		// (get) Token: 0x060034F3 RID: 13555 RVA: 0x00084AFC File Offset: 0x00082CFC
		// (set) Token: 0x060034F4 RID: 13556 RVA: 0x00084B04 File Offset: 0x00082D04
		[global::System.Xml.Serialization.XmlAttribute]
		public uint totalsRowDxfId
		{
			get
			{
				return this.totalsRowDxfIdField;
			}
			set
			{
				this.totalsRowDxfIdField = value;
			}
		}

		// Token: 0x1700141E RID: 5150
		// (get) Token: 0x060034F5 RID: 13557 RVA: 0x00084B0D File Offset: 0x00082D0D
		// (set) Token: 0x060034F6 RID: 13558 RVA: 0x00084B15 File Offset: 0x00082D15
		[global::System.Xml.Serialization.XmlIgnore]
		public bool totalsRowDxfIdSpecified
		{
			get
			{
				return this.totalsRowDxfIdFieldSpecified;
			}
			set
			{
				this.totalsRowDxfIdFieldSpecified = value;
			}
		}

		// Token: 0x1700141F RID: 5151
		// (get) Token: 0x060034F7 RID: 13559 RVA: 0x00084B1E File Offset: 0x00082D1E
		// (set) Token: 0x060034F8 RID: 13560 RVA: 0x00084B26 File Offset: 0x00082D26
		[global::System.Xml.Serialization.XmlAttribute]
		public string headerRowCellStyle
		{
			get
			{
				return this.headerRowCellStyleField;
			}
			set
			{
				this.headerRowCellStyleField = value;
			}
		}

		// Token: 0x17001420 RID: 5152
		// (get) Token: 0x060034F9 RID: 13561 RVA: 0x00084B2F File Offset: 0x00082D2F
		// (set) Token: 0x060034FA RID: 13562 RVA: 0x00084B37 File Offset: 0x00082D37
		[global::System.Xml.Serialization.XmlAttribute]
		public string dataCellStyle
		{
			get
			{
				return this.dataCellStyleField;
			}
			set
			{
				this.dataCellStyleField = value;
			}
		}

		// Token: 0x17001421 RID: 5153
		// (get) Token: 0x060034FB RID: 13563 RVA: 0x00084B40 File Offset: 0x00082D40
		// (set) Token: 0x060034FC RID: 13564 RVA: 0x00084B48 File Offset: 0x00082D48
		[global::System.Xml.Serialization.XmlAttribute]
		public string totalsRowCellStyle
		{
			get
			{
				return this.totalsRowCellStyleField;
			}
			set
			{
				this.totalsRowCellStyleField = value;
			}
		}

		// Token: 0x04002325 RID: 8997
		private global::NPOI.OpenXmlFormats.Spreadsheet.CT_TableFormula calculatedColumnFormulaField;

		// Token: 0x04002326 RID: 8998
		private global::NPOI.OpenXmlFormats.Spreadsheet.CT_TableFormula totalsRowFormulaField;

		// Token: 0x04002327 RID: 8999
		private global::NPOI.OpenXmlFormats.Spreadsheet.CT_XmlColumnPr xmlColumnPrField;

		// Token: 0x04002328 RID: 9000
		private global::NPOI.OpenXmlFormats.Spreadsheet.CT_ExtensionList extLstField;

		// Token: 0x04002329 RID: 9001
		private uint idField;

		// Token: 0x0400232A RID: 9002
		private string uniqueNameField;

		// Token: 0x0400232B RID: 9003
		private string nameField;

		// Token: 0x0400232C RID: 9004
		private global::NPOI.OpenXmlFormats.Spreadsheet.ST_TotalsRowFunction totalsRowFunctionField;

		// Token: 0x0400232D RID: 9005
		private string totalsRowLabelField;

		// Token: 0x0400232E RID: 9006
		private uint queryTableFieldIdField;

		// Token: 0x0400232F RID: 9007
		private bool queryTableFieldIdFieldSpecified;

		// Token: 0x04002330 RID: 9008
		private uint headerRowDxfIdField;

		// Token: 0x04002331 RID: 9009
		private bool headerRowDxfIdFieldSpecified;

		// Token: 0x04002332 RID: 9010
		private uint dataDxfIdField;

		// Token: 0x04002333 RID: 9011
		private bool dataDxfIdFieldSpecified;

		// Token: 0x04002334 RID: 9012
		private uint totalsRowDxfIdField;

		// Token: 0x04002335 RID: 9013
		private bool totalsRowDxfIdFieldSpecified;

		// Token: 0x04002336 RID: 9014
		private string headerRowCellStyleField;

		// Token: 0x04002337 RID: 9015
		private string dataCellStyleField;

		// Token: 0x04002338 RID: 9016
		private string totalsRowCellStyleField;
	}
}
