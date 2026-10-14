using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Spreadsheet
{
	// Token: 0x020005A6 RID: 1446
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_DataValidations
	{
		// Token: 0x06003FCD RID: 16333 RVA: 0x0009AC18 File Offset: 0x00098E18
		public CT_DataValidations()
		{
			this.disablePromptsField = false;
		}

		// Token: 0x06003FCE RID: 16334 RVA: 0x0009AC28 File Offset: 0x00098E28
		public static global::NPOI.OpenXmlFormats.Spreadsheet.CT_DataValidations Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_DataValidations ct_DataValidations = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_DataValidations();
			ct_DataValidations.disablePrompts = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["disablePrompts"]);
			ct_DataValidations.xWindow = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadUInt(node.Attributes["xWindow"]);
			ct_DataValidations.yWindow = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadUInt(node.Attributes["yWindow"]);
			ct_DataValidations.count = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadUInt(node.Attributes["count"]);
			ct_DataValidations.dataValidation = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_DataValidation>();
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "dataValidation")
				{
					ct_DataValidations.dataValidation.Add(global::NPOI.OpenXmlFormats.Spreadsheet.CT_DataValidation.Parse(xmlNode, namespaceManager));
				}
			}
			return ct_DataValidations;
		}

		// Token: 0x06003FCF RID: 16335 RVA: 0x0009AD24 File Offset: 0x00098F24
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "disablePrompts", this.disablePrompts);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "xWindow", this.xWindow, false);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "yWindow", this.yWindow, false);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "count", this.count, false);
			sw.Write(">");
			if (this.dataValidation != null)
			{
				foreach (global::NPOI.OpenXmlFormats.Spreadsheet.CT_DataValidation ct_DataValidation in this.dataValidation)
				{
					ct_DataValidation.Write(sw, "dataValidation");
				}
			}
			sw.Write(string.Format("</{0}>", nodeName));
		}

		// Token: 0x170017FC RID: 6140
		// (get) Token: 0x06003FD0 RID: 16336 RVA: 0x0009ADF8 File Offset: 0x00098FF8
		// (set) Token: 0x06003FD1 RID: 16337 RVA: 0x0009AE00 File Offset: 0x00099000
		[global::System.Xml.Serialization.XmlElement("dataValidation", Order = 0)]
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_DataValidation> dataValidation
		{
			get
			{
				return this.dataValidationField;
			}
			set
			{
				this.dataValidationField = value;
			}
		}

		// Token: 0x170017FD RID: 6141
		// (get) Token: 0x06003FD2 RID: 16338 RVA: 0x0009AE09 File Offset: 0x00099009
		// (set) Token: 0x06003FD3 RID: 16339 RVA: 0x0009AE11 File Offset: 0x00099011
		[global::System.ComponentModel.DefaultValue(false)]
		[global::System.Xml.Serialization.XmlAttribute]
		public bool disablePrompts
		{
			get
			{
				return this.disablePromptsField;
			}
			set
			{
				this.disablePromptsField = value;
			}
		}

		// Token: 0x170017FE RID: 6142
		// (get) Token: 0x06003FD4 RID: 16340 RVA: 0x0009AE1A File Offset: 0x0009901A
		// (set) Token: 0x06003FD5 RID: 16341 RVA: 0x0009AE22 File Offset: 0x00099022
		[global::System.Xml.Serialization.XmlAttribute]
		public uint xWindow
		{
			get
			{
				return this.xWindowField;
			}
			set
			{
				this.xWindowField = value;
			}
		}

		// Token: 0x170017FF RID: 6143
		// (get) Token: 0x06003FD6 RID: 16342 RVA: 0x0009AE2B File Offset: 0x0009902B
		// (set) Token: 0x06003FD7 RID: 16343 RVA: 0x0009AE33 File Offset: 0x00099033
		[global::System.Xml.Serialization.XmlIgnore]
		public bool xWindowSpecified
		{
			get
			{
				return this.xWindowFieldSpecified;
			}
			set
			{
				this.xWindowFieldSpecified = value;
			}
		}

		// Token: 0x17001800 RID: 6144
		// (get) Token: 0x06003FD8 RID: 16344 RVA: 0x0009AE3C File Offset: 0x0009903C
		// (set) Token: 0x06003FD9 RID: 16345 RVA: 0x0009AE44 File Offset: 0x00099044
		[global::System.Xml.Serialization.XmlAttribute]
		public uint yWindow
		{
			get
			{
				return this.yWindowField;
			}
			set
			{
				this.yWindowField = value;
			}
		}

		// Token: 0x17001801 RID: 6145
		// (get) Token: 0x06003FDA RID: 16346 RVA: 0x0009AE4D File Offset: 0x0009904D
		// (set) Token: 0x06003FDB RID: 16347 RVA: 0x0009AE55 File Offset: 0x00099055
		[global::System.Xml.Serialization.XmlIgnore]
		public bool yWindowSpecified
		{
			get
			{
				return this.yWindowFieldSpecified;
			}
			set
			{
				this.yWindowFieldSpecified = value;
			}
		}

		// Token: 0x17001802 RID: 6146
		// (get) Token: 0x06003FDC RID: 16348 RVA: 0x0009AE5E File Offset: 0x0009905E
		// (set) Token: 0x06003FDD RID: 16349 RVA: 0x0009AE66 File Offset: 0x00099066
		[global::System.Xml.Serialization.XmlAttribute]
		public uint count
		{
			get
			{
				return this.countField;
			}
			set
			{
				this.countField = value;
			}
		}

		// Token: 0x17001803 RID: 6147
		// (get) Token: 0x06003FDE RID: 16350 RVA: 0x0009AE6F File Offset: 0x0009906F
		// (set) Token: 0x06003FDF RID: 16351 RVA: 0x0009AE77 File Offset: 0x00099077
		[global::System.Xml.Serialization.XmlIgnore]
		public bool countSpecified
		{
			get
			{
				return this.countFieldSpecified;
			}
			set
			{
				this.countFieldSpecified = value;
			}
		}

		// Token: 0x06003FE0 RID: 16352 RVA: 0x0009AE5E File Offset: 0x0009905E
		public int sizeOfDataValidationArray()
		{
			return (int)this.countField;
		}

		// Token: 0x06003FE1 RID: 16353 RVA: 0x0009AE80 File Offset: 0x00099080
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_DataValidation AddNewDataValidation()
		{
			if (this.dataValidationField == null)
			{
				this.dataValidationField = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_DataValidation>();
			}
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_DataValidation ct_DataValidation = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_DataValidation();
			this.dataValidationField.Add(ct_DataValidation);
			this.countField += 1U;
			return ct_DataValidation;
		}

		// Token: 0x04002875 RID: 10357
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_DataValidation> dataValidationField;

		// Token: 0x04002876 RID: 10358
		private bool disablePromptsField;

		// Token: 0x04002877 RID: 10359
		private uint xWindowField;

		// Token: 0x04002878 RID: 10360
		private bool xWindowFieldSpecified;

		// Token: 0x04002879 RID: 10361
		private uint yWindowField;

		// Token: 0x0400287A RID: 10362
		private bool yWindowFieldSpecified;

		// Token: 0x0400287B RID: 10363
		private uint countField;

		// Token: 0x0400287C RID: 10364
		private bool countFieldSpecified;
	}
}
