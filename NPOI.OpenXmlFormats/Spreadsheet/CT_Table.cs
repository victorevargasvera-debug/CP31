using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Spreadsheet
{
	// Token: 0x020004E6 RID: 1254
	[global::System.Diagnostics.DebuggerStepThrough]
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot("table", Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_Table
	{
		// Token: 0x06003481 RID: 13441 RVA: 0x00083ADC File Offset: 0x00081CDC
		public CT_Table()
		{
			this.tableTypeField = global::NPOI.OpenXmlFormats.Spreadsheet.ST_TableType.worksheet;
			this.headerRowCountField = 1U;
			this.insertRowField = false;
			this.insertRowShiftField = false;
			this.totalsRowCountField = 0U;
			this.totalsRowShownField = true;
			this.publishedField = false;
		}

		// Token: 0x06003482 RID: 13442 RVA: 0x00083B18 File Offset: 0x00081D18
		public static global::NPOI.OpenXmlFormats.Spreadsheet.CT_Table Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_Table ct_Table = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_Table();
			if (node.Attributes["id"] != null)
			{
				ct_Table.id = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadUInt(node.Attributes["id"]);
			}
			ct_Table.name = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["name"]);
			ct_Table.displayName = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["displayName"]);
			ct_Table.comment = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["comment"]);
			ct_Table.@ref = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["ref"]);
			if (node.Attributes["tableType"] != null)
			{
				ct_Table.tableType = (global::NPOI.OpenXmlFormats.Spreadsheet.ST_TableType)global::System.Enum.Parse(typeof(global::NPOI.OpenXmlFormats.Spreadsheet.ST_TableType), node.Attributes["tableType"].Value);
			}
			if (node.Attributes["headerRowCount"] != null)
			{
				ct_Table.headerRowCount = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadUInt(node.Attributes["headerRowCount"]);
			}
			if (node.Attributes["insertRow"] != null)
			{
				ct_Table.insertRow = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["insertRow"]);
			}
			if (node.Attributes["insertRowShift"] != null)
			{
				ct_Table.insertRowShift = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["insertRowShift"]);
			}
			if (node.Attributes["totalsRowCount"] != null)
			{
				ct_Table.totalsRowCount = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadUInt(node.Attributes["totalsRowCount"]);
			}
			if (node.Attributes["totalsRowShown"] != null)
			{
				ct_Table.totalsRowShown = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["totalsRowShown"]);
			}
			if (node.Attributes["published"] != null)
			{
				ct_Table.published = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["published"]);
			}
			if (node.Attributes["headerRowDxfId"] != null)
			{
				ct_Table.headerRowDxfId = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadUInt(node.Attributes["headerRowDxfId"]);
			}
			if (node.Attributes["dataDxfId"] != null)
			{
				ct_Table.dataDxfId = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadUInt(node.Attributes["dataDxfId"]);
			}
			if (node.Attributes["totalsRowDxfId"] != null)
			{
				ct_Table.totalsRowDxfId = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadUInt(node.Attributes["totalsRowDxfId"]);
			}
			if (node.Attributes["headerRowBorderDxfId"] != null)
			{
				ct_Table.headerRowBorderDxfId = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadUInt(node.Attributes["headerRowBorderDxfId"]);
			}
			if (node.Attributes["tableBorderDxfId"] != null)
			{
				ct_Table.tableBorderDxfId = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadUInt(node.Attributes["tableBorderDxfId"]);
			}
			if (node.Attributes["totalsRowBorderDxfId"] != null)
			{
				ct_Table.totalsRowBorderDxfId = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadUInt(node.Attributes["totalsRowBorderDxfId"]);
			}
			ct_Table.headerRowCellStyle = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["headerRowCellStyle"]);
			ct_Table.dataCellStyle = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["dataCellStyle"]);
			ct_Table.totalsRowCellStyle = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["totalsRowCellStyle"]);
			if (node.Attributes["connectionId"] != null)
			{
				ct_Table.connectionId = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadUInt(node.Attributes["connectionId"]);
			}
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "autoFilter")
				{
					ct_Table.autoFilter = global::NPOI.OpenXmlFormats.Spreadsheet.CT_AutoFilter.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "sortState")
				{
					ct_Table.sortState = global::NPOI.OpenXmlFormats.Spreadsheet.CT_SortState.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "tableColumns")
				{
					ct_Table.tableColumns = global::NPOI.OpenXmlFormats.Spreadsheet.CT_TableColumns.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "tableStyleInfo")
				{
					ct_Table.tableStyleInfo = global::NPOI.OpenXmlFormats.Spreadsheet.CT_TableStyleInfo.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "extLst")
				{
					ct_Table.extLst = global::NPOI.OpenXmlFormats.Spreadsheet.CT_ExtensionList.Parse(xmlNode, namespaceManager);
				}
			}
			return ct_Table;
		}

		// Token: 0x06003483 RID: 13443 RVA: 0x00083F98 File Offset: 0x00082198
		internal void Write(global::System.IO.StreamWriter sw)
		{
			sw.Write("<?xml version=\"1.0\" encoding=\"UTF-8\" standalone=\"yes\"?>");
			sw.Write("<table xmlns=\"http://schemas.openxmlformats.org/spreadsheetml/2006/main\"");
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "id", this.id, false);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "name", this.name);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "displayName", this.displayName);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "comment", this.comment);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "ref", this.@ref);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "tableType", this.tableType.ToString());
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "headerRowCount", this.headerRowCount, false);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "insertRow", this.insertRow);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "insertRowShift", this.insertRowShift);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "totalsRowCount", this.totalsRowCount, false);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "totalsRowShown", this.totalsRowShown);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "published", this.published);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "headerRowDxfId", this.headerRowDxfId, false);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "dataDxfId", this.dataDxfId, false);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "totalsRowDxfId", this.totalsRowDxfId, false);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "headerRowBorderDxfId", this.headerRowBorderDxfId, false);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "tableBorderDxfId", this.tableBorderDxfId, false);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "totalsRowBorderDxfId", this.totalsRowBorderDxfId, false);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "headerRowCellStyle", this.headerRowCellStyle);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "dataCellStyle", this.dataCellStyle);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "totalsRowCellStyle", this.totalsRowCellStyle);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "connectionId", this.connectionId, false);
			sw.Write(">");
			if (this.autoFilter != null)
			{
				this.autoFilter.Write(sw, "autoFilter");
			}
			if (this.sortState != null)
			{
				this.sortState.Write(sw, "sortState");
			}
			if (this.tableColumns != null)
			{
				this.tableColumns.Write(sw, "tableColumns");
			}
			if (this.tableStyleInfo != null)
			{
				this.tableStyleInfo.Write(sw, "tableStyleInfo");
			}
			if (this.extLst != null)
			{
				this.extLst.Write(sw, "extLst");
			}
			sw.Write("</table>");
		}

		// Token: 0x170013E9 RID: 5097
		// (get) Token: 0x06003484 RID: 13444 RVA: 0x000841DC File Offset: 0x000823DC
		// (set) Token: 0x06003485 RID: 13445 RVA: 0x000841E4 File Offset: 0x000823E4
		[global::System.Xml.Serialization.XmlElement]
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_AutoFilter autoFilter
		{
			get
			{
				return this.autoFilterField;
			}
			set
			{
				this.autoFilterField = value;
			}
		}

		// Token: 0x170013EA RID: 5098
		// (get) Token: 0x06003486 RID: 13446 RVA: 0x000841ED File Offset: 0x000823ED
		// (set) Token: 0x06003487 RID: 13447 RVA: 0x000841F5 File Offset: 0x000823F5
		[global::System.Xml.Serialization.XmlElement]
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_SortState sortState
		{
			get
			{
				return this.sortStateField;
			}
			set
			{
				this.sortStateField = value;
			}
		}

		// Token: 0x170013EB RID: 5099
		// (get) Token: 0x06003488 RID: 13448 RVA: 0x000841FE File Offset: 0x000823FE
		// (set) Token: 0x06003489 RID: 13449 RVA: 0x00084206 File Offset: 0x00082406
		[global::System.Xml.Serialization.XmlElement]
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_TableColumns tableColumns
		{
			get
			{
				return this.tableColumnsField;
			}
			set
			{
				this.tableColumnsField = value;
			}
		}

		// Token: 0x170013EC RID: 5100
		// (get) Token: 0x0600348A RID: 13450 RVA: 0x0008420F File Offset: 0x0008240F
		// (set) Token: 0x0600348B RID: 13451 RVA: 0x00084217 File Offset: 0x00082417
		[global::System.Xml.Serialization.XmlElement]
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_TableStyleInfo tableStyleInfo
		{
			get
			{
				return this.tableStyleInfoField;
			}
			set
			{
				this.tableStyleInfoField = value;
			}
		}

		// Token: 0x170013ED RID: 5101
		// (get) Token: 0x0600348C RID: 13452 RVA: 0x00084220 File Offset: 0x00082420
		// (set) Token: 0x0600348D RID: 13453 RVA: 0x00084228 File Offset: 0x00082428
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

		// Token: 0x170013EE RID: 5102
		// (get) Token: 0x0600348E RID: 13454 RVA: 0x00084231 File Offset: 0x00082431
		// (set) Token: 0x0600348F RID: 13455 RVA: 0x00084239 File Offset: 0x00082439
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

		// Token: 0x170013EF RID: 5103
		// (get) Token: 0x06003490 RID: 13456 RVA: 0x00084242 File Offset: 0x00082442
		// (set) Token: 0x06003491 RID: 13457 RVA: 0x0008424A File Offset: 0x0008244A
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

		// Token: 0x170013F0 RID: 5104
		// (get) Token: 0x06003492 RID: 13458 RVA: 0x00084253 File Offset: 0x00082453
		// (set) Token: 0x06003493 RID: 13459 RVA: 0x0008425B File Offset: 0x0008245B
		[global::System.Xml.Serialization.XmlAttribute]
		public string displayName
		{
			get
			{
				return this.displayNameField;
			}
			set
			{
				this.displayNameField = value;
			}
		}

		// Token: 0x170013F1 RID: 5105
		// (get) Token: 0x06003494 RID: 13460 RVA: 0x00084264 File Offset: 0x00082464
		// (set) Token: 0x06003495 RID: 13461 RVA: 0x0008426C File Offset: 0x0008246C
		[global::System.Xml.Serialization.XmlAttribute]
		public string comment
		{
			get
			{
				return this.commentField;
			}
			set
			{
				this.commentField = value;
			}
		}

		// Token: 0x170013F2 RID: 5106
		// (get) Token: 0x06003496 RID: 13462 RVA: 0x00084275 File Offset: 0x00082475
		// (set) Token: 0x06003497 RID: 13463 RVA: 0x0008427D File Offset: 0x0008247D
		[global::System.Xml.Serialization.XmlAttribute]
		public string @ref
		{
			get
			{
				return this.refField;
			}
			set
			{
				this.refField = value;
			}
		}

		// Token: 0x170013F3 RID: 5107
		// (get) Token: 0x06003498 RID: 13464 RVA: 0x00084286 File Offset: 0x00082486
		// (set) Token: 0x06003499 RID: 13465 RVA: 0x0008428E File Offset: 0x0008248E
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(global::NPOI.OpenXmlFormats.Spreadsheet.ST_TableType.worksheet)]
		public global::NPOI.OpenXmlFormats.Spreadsheet.ST_TableType tableType
		{
			get
			{
				return this.tableTypeField;
			}
			set
			{
				this.tableTypeField = value;
			}
		}

		// Token: 0x170013F4 RID: 5108
		// (get) Token: 0x0600349A RID: 13466 RVA: 0x00084297 File Offset: 0x00082497
		// (set) Token: 0x0600349B RID: 13467 RVA: 0x0008429F File Offset: 0x0008249F
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(typeof(uint), "1")]
		public uint headerRowCount
		{
			get
			{
				return this.headerRowCountField;
			}
			set
			{
				this.headerRowCountField = value;
			}
		}

		// Token: 0x170013F5 RID: 5109
		// (get) Token: 0x0600349C RID: 13468 RVA: 0x000842A8 File Offset: 0x000824A8
		// (set) Token: 0x0600349D RID: 13469 RVA: 0x000842B0 File Offset: 0x000824B0
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(false)]
		public bool insertRow
		{
			get
			{
				return this.insertRowField;
			}
			set
			{
				this.insertRowField = value;
			}
		}

		// Token: 0x170013F6 RID: 5110
		// (get) Token: 0x0600349E RID: 13470 RVA: 0x000842B9 File Offset: 0x000824B9
		// (set) Token: 0x0600349F RID: 13471 RVA: 0x000842C1 File Offset: 0x000824C1
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(false)]
		public bool insertRowShift
		{
			get
			{
				return this.insertRowShiftField;
			}
			set
			{
				this.insertRowShiftField = value;
			}
		}

		// Token: 0x170013F7 RID: 5111
		// (get) Token: 0x060034A0 RID: 13472 RVA: 0x000842CA File Offset: 0x000824CA
		// (set) Token: 0x060034A1 RID: 13473 RVA: 0x000842D2 File Offset: 0x000824D2
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(typeof(uint), "0")]
		public uint totalsRowCount
		{
			get
			{
				return this.totalsRowCountField;
			}
			set
			{
				this.totalsRowCountField = value;
			}
		}

		// Token: 0x170013F8 RID: 5112
		// (get) Token: 0x060034A2 RID: 13474 RVA: 0x000842DB File Offset: 0x000824DB
		// (set) Token: 0x060034A3 RID: 13475 RVA: 0x000842E3 File Offset: 0x000824E3
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(true)]
		public bool totalsRowShown
		{
			get
			{
				return this.totalsRowShownField;
			}
			set
			{
				this.totalsRowShownField = value;
			}
		}

		// Token: 0x170013F9 RID: 5113
		// (get) Token: 0x060034A4 RID: 13476 RVA: 0x000842EC File Offset: 0x000824EC
		// (set) Token: 0x060034A5 RID: 13477 RVA: 0x000842F4 File Offset: 0x000824F4
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(false)]
		public bool published
		{
			get
			{
				return this.publishedField;
			}
			set
			{
				this.publishedField = value;
			}
		}

		// Token: 0x170013FA RID: 5114
		// (get) Token: 0x060034A6 RID: 13478 RVA: 0x000842FD File Offset: 0x000824FD
		// (set) Token: 0x060034A7 RID: 13479 RVA: 0x00084305 File Offset: 0x00082505
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

		// Token: 0x170013FB RID: 5115
		// (get) Token: 0x060034A8 RID: 13480 RVA: 0x0008430E File Offset: 0x0008250E
		// (set) Token: 0x060034A9 RID: 13481 RVA: 0x00084316 File Offset: 0x00082516
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

		// Token: 0x170013FC RID: 5116
		// (get) Token: 0x060034AA RID: 13482 RVA: 0x0008431F File Offset: 0x0008251F
		// (set) Token: 0x060034AB RID: 13483 RVA: 0x00084327 File Offset: 0x00082527
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

		// Token: 0x170013FD RID: 5117
		// (get) Token: 0x060034AC RID: 13484 RVA: 0x00084330 File Offset: 0x00082530
		// (set) Token: 0x060034AD RID: 13485 RVA: 0x00084338 File Offset: 0x00082538
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

		// Token: 0x170013FE RID: 5118
		// (get) Token: 0x060034AE RID: 13486 RVA: 0x00084341 File Offset: 0x00082541
		// (set) Token: 0x060034AF RID: 13487 RVA: 0x00084349 File Offset: 0x00082549
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

		// Token: 0x170013FF RID: 5119
		// (get) Token: 0x060034B0 RID: 13488 RVA: 0x00084352 File Offset: 0x00082552
		// (set) Token: 0x060034B1 RID: 13489 RVA: 0x0008435A File Offset: 0x0008255A
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

		// Token: 0x17001400 RID: 5120
		// (get) Token: 0x060034B2 RID: 13490 RVA: 0x00084363 File Offset: 0x00082563
		// (set) Token: 0x060034B3 RID: 13491 RVA: 0x0008436B File Offset: 0x0008256B
		[global::System.Xml.Serialization.XmlAttribute]
		public uint headerRowBorderDxfId
		{
			get
			{
				return this.headerRowBorderDxfIdField;
			}
			set
			{
				this.headerRowBorderDxfIdField = value;
			}
		}

		// Token: 0x17001401 RID: 5121
		// (get) Token: 0x060034B4 RID: 13492 RVA: 0x00084374 File Offset: 0x00082574
		// (set) Token: 0x060034B5 RID: 13493 RVA: 0x0008437C File Offset: 0x0008257C
		[global::System.Xml.Serialization.XmlIgnore]
		public bool headerRowBorderDxfIdSpecified
		{
			get
			{
				return this.headerRowBorderDxfIdFieldSpecified;
			}
			set
			{
				this.headerRowBorderDxfIdFieldSpecified = value;
			}
		}

		// Token: 0x17001402 RID: 5122
		// (get) Token: 0x060034B6 RID: 13494 RVA: 0x00084385 File Offset: 0x00082585
		// (set) Token: 0x060034B7 RID: 13495 RVA: 0x0008438D File Offset: 0x0008258D
		[global::System.Xml.Serialization.XmlAttribute]
		public uint tableBorderDxfId
		{
			get
			{
				return this.tableBorderDxfIdField;
			}
			set
			{
				this.tableBorderDxfIdField = value;
			}
		}

		// Token: 0x17001403 RID: 5123
		// (get) Token: 0x060034B8 RID: 13496 RVA: 0x00084396 File Offset: 0x00082596
		// (set) Token: 0x060034B9 RID: 13497 RVA: 0x0008439E File Offset: 0x0008259E
		[global::System.Xml.Serialization.XmlIgnore]
		public bool tableBorderDxfIdSpecified
		{
			get
			{
				return this.tableBorderDxfIdFieldSpecified;
			}
			set
			{
				this.tableBorderDxfIdFieldSpecified = value;
			}
		}

		// Token: 0x17001404 RID: 5124
		// (get) Token: 0x060034BA RID: 13498 RVA: 0x000843A7 File Offset: 0x000825A7
		// (set) Token: 0x060034BB RID: 13499 RVA: 0x000843AF File Offset: 0x000825AF
		[global::System.Xml.Serialization.XmlAttribute]
		public uint totalsRowBorderDxfId
		{
			get
			{
				return this.totalsRowBorderDxfIdField;
			}
			set
			{
				this.totalsRowBorderDxfIdField = value;
			}
		}

		// Token: 0x17001405 RID: 5125
		// (get) Token: 0x060034BC RID: 13500 RVA: 0x000843B8 File Offset: 0x000825B8
		// (set) Token: 0x060034BD RID: 13501 RVA: 0x000843C0 File Offset: 0x000825C0
		[global::System.Xml.Serialization.XmlIgnore]
		public bool totalsRowBorderDxfIdSpecified
		{
			get
			{
				return this.totalsRowBorderDxfIdFieldSpecified;
			}
			set
			{
				this.totalsRowBorderDxfIdFieldSpecified = value;
			}
		}

		// Token: 0x17001406 RID: 5126
		// (get) Token: 0x060034BE RID: 13502 RVA: 0x000843C9 File Offset: 0x000825C9
		// (set) Token: 0x060034BF RID: 13503 RVA: 0x000843D1 File Offset: 0x000825D1
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

		// Token: 0x17001407 RID: 5127
		// (get) Token: 0x060034C0 RID: 13504 RVA: 0x000843DA File Offset: 0x000825DA
		// (set) Token: 0x060034C1 RID: 13505 RVA: 0x000843E2 File Offset: 0x000825E2
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

		// Token: 0x17001408 RID: 5128
		// (get) Token: 0x060034C2 RID: 13506 RVA: 0x000843EB File Offset: 0x000825EB
		// (set) Token: 0x060034C3 RID: 13507 RVA: 0x000843F3 File Offset: 0x000825F3
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

		// Token: 0x17001409 RID: 5129
		// (get) Token: 0x060034C4 RID: 13508 RVA: 0x000843FC File Offset: 0x000825FC
		// (set) Token: 0x060034C5 RID: 13509 RVA: 0x00084404 File Offset: 0x00082604
		[global::System.Xml.Serialization.XmlAttribute]
		public uint connectionId
		{
			get
			{
				return this.connectionIdField;
			}
			set
			{
				this.connectionIdField = value;
			}
		}

		// Token: 0x1700140A RID: 5130
		// (get) Token: 0x060034C6 RID: 13510 RVA: 0x0008440D File Offset: 0x0008260D
		// (set) Token: 0x060034C7 RID: 13511 RVA: 0x00084415 File Offset: 0x00082615
		[global::System.Xml.Serialization.XmlIgnore]
		public bool connectionIdSpecified
		{
			get
			{
				return this.connectionIdFieldSpecified;
			}
			set
			{
				this.connectionIdFieldSpecified = value;
			}
		}

		// Token: 0x060034C8 RID: 13512 RVA: 0x0008441E File Offset: 0x0008261E
		internal global::NPOI.OpenXmlFormats.Spreadsheet.CT_TableStyleInfo AddNewTableStyleInfo()
		{
			this.tableStyleInfoField = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_TableStyleInfo();
			return this.tableStyleInfoField;
		}

		// Token: 0x04002300 RID: 8960
		private global::NPOI.OpenXmlFormats.Spreadsheet.CT_AutoFilter autoFilterField;

		// Token: 0x04002301 RID: 8961
		private global::NPOI.OpenXmlFormats.Spreadsheet.CT_SortState sortStateField;

		// Token: 0x04002302 RID: 8962
		private global::NPOI.OpenXmlFormats.Spreadsheet.CT_TableColumns tableColumnsField;

		// Token: 0x04002303 RID: 8963
		private global::NPOI.OpenXmlFormats.Spreadsheet.CT_TableStyleInfo tableStyleInfoField;

		// Token: 0x04002304 RID: 8964
		private global::NPOI.OpenXmlFormats.Spreadsheet.CT_ExtensionList extLstField;

		// Token: 0x04002305 RID: 8965
		private uint idField;

		// Token: 0x04002306 RID: 8966
		private string nameField;

		// Token: 0x04002307 RID: 8967
		private string displayNameField;

		// Token: 0x04002308 RID: 8968
		private string commentField;

		// Token: 0x04002309 RID: 8969
		private string refField;

		// Token: 0x0400230A RID: 8970
		private global::NPOI.OpenXmlFormats.Spreadsheet.ST_TableType tableTypeField;

		// Token: 0x0400230B RID: 8971
		private uint headerRowCountField;

		// Token: 0x0400230C RID: 8972
		private bool insertRowField;

		// Token: 0x0400230D RID: 8973
		private bool insertRowShiftField;

		// Token: 0x0400230E RID: 8974
		private uint totalsRowCountField;

		// Token: 0x0400230F RID: 8975
		private bool totalsRowShownField;

		// Token: 0x04002310 RID: 8976
		private bool publishedField;

		// Token: 0x04002311 RID: 8977
		private uint headerRowDxfIdField;

		// Token: 0x04002312 RID: 8978
		private bool headerRowDxfIdFieldSpecified;

		// Token: 0x04002313 RID: 8979
		private uint dataDxfIdField;

		// Token: 0x04002314 RID: 8980
		private bool dataDxfIdFieldSpecified;

		// Token: 0x04002315 RID: 8981
		private uint totalsRowDxfIdField;

		// Token: 0x04002316 RID: 8982
		private bool totalsRowDxfIdFieldSpecified;

		// Token: 0x04002317 RID: 8983
		private uint headerRowBorderDxfIdField;

		// Token: 0x04002318 RID: 8984
		private bool headerRowBorderDxfIdFieldSpecified;

		// Token: 0x04002319 RID: 8985
		private uint tableBorderDxfIdField;

		// Token: 0x0400231A RID: 8986
		private bool tableBorderDxfIdFieldSpecified;

		// Token: 0x0400231B RID: 8987
		private uint totalsRowBorderDxfIdField;

		// Token: 0x0400231C RID: 8988
		private bool totalsRowBorderDxfIdFieldSpecified;

		// Token: 0x0400231D RID: 8989
		private string headerRowCellStyleField;

		// Token: 0x0400231E RID: 8990
		private string dataCellStyleField;

		// Token: 0x0400231F RID: 8991
		private string totalsRowCellStyleField;

		// Token: 0x04002320 RID: 8992
		private uint connectionIdField;

		// Token: 0x04002321 RID: 8993
		private bool connectionIdFieldSpecified;
	}
}
