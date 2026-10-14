using System;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Spreadsheet
{
	// Token: 0x020004B0 RID: 1200
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main", IsNullable = true)]
	public class CT_CalculatedItem
	{
		// Token: 0x06003111 RID: 12561 RVA: 0x0007B0C0 File Offset: 0x000792C0
		public static global::NPOI.OpenXmlFormats.Spreadsheet.CT_CalculatedItem Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_CalculatedItem ct_CalculatedItem = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_CalculatedItem();
			if (node.Attributes["field"] != null)
			{
				ct_CalculatedItem.field = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadUInt(node.Attributes["field"]);
			}
			ct_CalculatedItem.formula = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["formula"]);
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "pivotArea")
				{
					ct_CalculatedItem.pivotArea = global::NPOI.OpenXmlFormats.Spreadsheet.CT_PivotArea.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "extLst")
				{
					ct_CalculatedItem.extLst = global::NPOI.OpenXmlFormats.Spreadsheet.CT_ExtensionList.Parse(xmlNode, namespaceManager);
				}
			}
			return ct_CalculatedItem;
		}

		// Token: 0x06003112 RID: 12562 RVA: 0x0007B1A8 File Offset: 0x000793A8
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "field", this.field, false);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "formula", this.formula);
			sw.Write(">");
			if (this.pivotArea != null)
			{
				this.pivotArea.Write(sw, "pivotArea");
			}
			if (this.extLst != null)
			{
				this.extLst.Write(sw, "extLst");
			}
			sw.Write(string.Format("</{0}>", nodeName));
		}

		// Token: 0x06003113 RID: 12563 RVA: 0x0007B237 File Offset: 0x00079437
		public CT_CalculatedItem()
		{
			this.extLstField = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_ExtensionList();
			this.pivotAreaField = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_PivotArea();
		}

		// Token: 0x17001287 RID: 4743
		// (get) Token: 0x06003114 RID: 12564 RVA: 0x0007B255 File Offset: 0x00079455
		// (set) Token: 0x06003115 RID: 12565 RVA: 0x0007B25D File Offset: 0x0007945D
		[global::System.Xml.Serialization.XmlElement(Order = 0)]
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_PivotArea pivotArea
		{
			get
			{
				return this.pivotAreaField;
			}
			set
			{
				this.pivotAreaField = value;
			}
		}

		// Token: 0x17001288 RID: 4744
		// (get) Token: 0x06003116 RID: 12566 RVA: 0x0007B266 File Offset: 0x00079466
		// (set) Token: 0x06003117 RID: 12567 RVA: 0x0007B26E File Offset: 0x0007946E
		[global::System.Xml.Serialization.XmlElement(Order = 1)]
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

		// Token: 0x17001289 RID: 4745
		// (get) Token: 0x06003118 RID: 12568 RVA: 0x0007B277 File Offset: 0x00079477
		// (set) Token: 0x06003119 RID: 12569 RVA: 0x0007B27F File Offset: 0x0007947F
		[global::System.Xml.Serialization.XmlAttribute]
		public uint field
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

		// Token: 0x1700128A RID: 4746
		// (get) Token: 0x0600311A RID: 12570 RVA: 0x0007B288 File Offset: 0x00079488
		// (set) Token: 0x0600311B RID: 12571 RVA: 0x0007B290 File Offset: 0x00079490
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

		// Token: 0x1700128B RID: 4747
		// (get) Token: 0x0600311C RID: 12572 RVA: 0x0007B299 File Offset: 0x00079499
		// (set) Token: 0x0600311D RID: 12573 RVA: 0x0007B2A1 File Offset: 0x000794A1
		[global::System.Xml.Serialization.XmlAttribute]
		public string formula
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

		// Token: 0x0400212F RID: 8495
		private global::NPOI.OpenXmlFormats.Spreadsheet.CT_PivotArea pivotAreaField;

		// Token: 0x04002130 RID: 8496
		private global::NPOI.OpenXmlFormats.Spreadsheet.CT_ExtensionList extLstField;

		// Token: 0x04002131 RID: 8497
		private uint fieldField;

		// Token: 0x04002132 RID: 8498
		private bool fieldFieldSpecified;

		// Token: 0x04002133 RID: 8499
		private string formulaField;
	}
}
