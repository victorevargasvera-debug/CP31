using System;
using System.ComponentModel;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Spreadsheet
{
	// Token: 0x020004CB RID: 1227
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main", IsNullable = true)]
	public class CT_DataField
	{
		// Token: 0x0600334F RID: 13135 RVA: 0x00080A14 File Offset: 0x0007EC14
		public static global::NPOI.OpenXmlFormats.Spreadsheet.CT_DataField Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_DataField ct_DataField = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_DataField();
			ct_DataField.name = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["name"]);
			if (node.Attributes["fld"] != null)
			{
				ct_DataField.fld = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadUInt(node.Attributes["fld"]);
			}
			if (node.Attributes["subtotal"] != null)
			{
				ct_DataField.subtotal = (global::NPOI.OpenXmlFormats.Spreadsheet.ST_DataConsolidateFunction)global::System.Enum.Parse(typeof(global::NPOI.OpenXmlFormats.Spreadsheet.ST_DataConsolidateFunction), node.Attributes["subtotal"].Value);
			}
			if (node.Attributes["showDataAs"] != null)
			{
				ct_DataField.showDataAs = (global::NPOI.OpenXmlFormats.Spreadsheet.ST_ShowDataAs)global::System.Enum.Parse(typeof(global::NPOI.OpenXmlFormats.Spreadsheet.ST_ShowDataAs), node.Attributes["showDataAs"].Value);
			}
			if (node.Attributes["baseField"] != null)
			{
				ct_DataField.baseField = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadInt(node.Attributes["baseField"]);
			}
			if (node.Attributes["baseItem"] != null)
			{
				ct_DataField.baseItem = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadUInt(node.Attributes["baseItem"]);
			}
			if (node.Attributes["numFmtId"] != null)
			{
				ct_DataField.numFmtId = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadUInt(node.Attributes["numFmtId"]);
			}
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "extLst")
				{
					ct_DataField.extLst = global::NPOI.OpenXmlFormats.Spreadsheet.CT_ExtensionList.Parse(xmlNode, namespaceManager);
				}
			}
			return ct_DataField;
		}

		// Token: 0x06003350 RID: 13136 RVA: 0x00080BE4 File Offset: 0x0007EDE4
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "name", this.name);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "fld", this.fld, false);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "subtotal", this.subtotal.ToString());
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "showDataAs", this.showDataAs.ToString());
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "baseField", this.baseField);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "baseItem", this.baseItem, false);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "numFmtId", this.numFmtId, false);
			sw.Write(">");
			if (this.extLst != null)
			{
				this.extLst.Write(sw, "extLst");
			}
			sw.Write(string.Format("</{0}>", nodeName));
		}

		// Token: 0x06003351 RID: 13137 RVA: 0x00080CCD File Offset: 0x0007EECD
		public CT_DataField()
		{
			this.extLstField = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_ExtensionList();
			this.subtotalField = global::NPOI.OpenXmlFormats.Spreadsheet.ST_DataConsolidateFunction.sum;
			this.showDataAsField = global::NPOI.OpenXmlFormats.Spreadsheet.ST_ShowDataAs.normal;
			this.baseFieldField = -1;
			this.baseItemField = 1048832U;
		}

		// Token: 0x17001374 RID: 4980
		// (get) Token: 0x06003352 RID: 13138 RVA: 0x00080D00 File Offset: 0x0007EF00
		// (set) Token: 0x06003353 RID: 13139 RVA: 0x00080D08 File Offset: 0x0007EF08
		[global::System.Xml.Serialization.XmlElement(Order = 0)]
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

		// Token: 0x17001375 RID: 4981
		// (get) Token: 0x06003354 RID: 13140 RVA: 0x00080D11 File Offset: 0x0007EF11
		// (set) Token: 0x06003355 RID: 13141 RVA: 0x00080D19 File Offset: 0x0007EF19
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

		// Token: 0x17001376 RID: 4982
		// (get) Token: 0x06003356 RID: 13142 RVA: 0x00080D22 File Offset: 0x0007EF22
		// (set) Token: 0x06003357 RID: 13143 RVA: 0x00080D2A File Offset: 0x0007EF2A
		[global::System.Xml.Serialization.XmlAttribute]
		public uint fld
		{
			get
			{
				return this.fldField;
			}
			set
			{
				this.fldField = value;
			}
		}

		// Token: 0x17001377 RID: 4983
		// (get) Token: 0x06003358 RID: 13144 RVA: 0x00080D33 File Offset: 0x0007EF33
		// (set) Token: 0x06003359 RID: 13145 RVA: 0x00080D3B File Offset: 0x0007EF3B
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(global::NPOI.OpenXmlFormats.Spreadsheet.ST_DataConsolidateFunction.sum)]
		public global::NPOI.OpenXmlFormats.Spreadsheet.ST_DataConsolidateFunction subtotal
		{
			get
			{
				return this.subtotalField;
			}
			set
			{
				this.subtotalField = value;
			}
		}

		// Token: 0x17001378 RID: 4984
		// (get) Token: 0x0600335A RID: 13146 RVA: 0x00080D44 File Offset: 0x0007EF44
		// (set) Token: 0x0600335B RID: 13147 RVA: 0x00080D4C File Offset: 0x0007EF4C
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(global::NPOI.OpenXmlFormats.Spreadsheet.ST_ShowDataAs.normal)]
		public global::NPOI.OpenXmlFormats.Spreadsheet.ST_ShowDataAs showDataAs
		{
			get
			{
				return this.showDataAsField;
			}
			set
			{
				this.showDataAsField = value;
			}
		}

		// Token: 0x17001379 RID: 4985
		// (get) Token: 0x0600335C RID: 13148 RVA: 0x00080D55 File Offset: 0x0007EF55
		// (set) Token: 0x0600335D RID: 13149 RVA: 0x00080D5D File Offset: 0x0007EF5D
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(-1)]
		public int baseField
		{
			get
			{
				return this.baseFieldField;
			}
			set
			{
				this.baseFieldField = value;
			}
		}

		// Token: 0x1700137A RID: 4986
		// (get) Token: 0x0600335E RID: 13150 RVA: 0x00080D66 File Offset: 0x0007EF66
		// (set) Token: 0x0600335F RID: 13151 RVA: 0x00080D6E File Offset: 0x0007EF6E
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(typeof(uint), "1048832")]
		public uint baseItem
		{
			get
			{
				return this.baseItemField;
			}
			set
			{
				this.baseItemField = value;
			}
		}

		// Token: 0x1700137B RID: 4987
		// (get) Token: 0x06003360 RID: 13152 RVA: 0x00080D77 File Offset: 0x0007EF77
		// (set) Token: 0x06003361 RID: 13153 RVA: 0x00080D7F File Offset: 0x0007EF7F
		[global::System.Xml.Serialization.XmlAttribute]
		public uint numFmtId
		{
			get
			{
				return this.numFmtIdField;
			}
			set
			{
				this.numFmtIdField = value;
			}
		}

		// Token: 0x1700137C RID: 4988
		// (get) Token: 0x06003362 RID: 13154 RVA: 0x00080D88 File Offset: 0x0007EF88
		// (set) Token: 0x06003363 RID: 13155 RVA: 0x00080D90 File Offset: 0x0007EF90
		[global::System.Xml.Serialization.XmlIgnore]
		public bool numFmtIdSpecified
		{
			get
			{
				return this.numFmtIdFieldSpecified;
			}
			set
			{
				this.numFmtIdFieldSpecified = value;
			}
		}

		// Token: 0x04002230 RID: 8752
		private global::NPOI.OpenXmlFormats.Spreadsheet.CT_ExtensionList extLstField;

		// Token: 0x04002231 RID: 8753
		private string nameField;

		// Token: 0x04002232 RID: 8754
		private uint fldField;

		// Token: 0x04002233 RID: 8755
		private global::NPOI.OpenXmlFormats.Spreadsheet.ST_DataConsolidateFunction subtotalField;

		// Token: 0x04002234 RID: 8756
		private global::NPOI.OpenXmlFormats.Spreadsheet.ST_ShowDataAs showDataAsField;

		// Token: 0x04002235 RID: 8757
		private int baseFieldField;

		// Token: 0x04002236 RID: 8758
		private uint baseItemField;

		// Token: 0x04002237 RID: 8759
		private uint numFmtIdField;

		// Token: 0x04002238 RID: 8760
		private bool numFmtIdFieldSpecified;
	}
}
