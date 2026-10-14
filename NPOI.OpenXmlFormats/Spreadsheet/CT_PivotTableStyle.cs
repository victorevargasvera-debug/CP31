using System;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Spreadsheet
{
	// Token: 0x020004DD RID: 1245
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main", IsNullable = true)]
	public class CT_PivotTableStyle
	{
		// Token: 0x06003407 RID: 13319 RVA: 0x00082964 File Offset: 0x00080B64
		public static global::NPOI.OpenXmlFormats.Spreadsheet.CT_PivotTableStyle Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_PivotTableStyle ct_PivotTableStyle = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_PivotTableStyle();
			ct_PivotTableStyle.name = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["name"]);
			if (node.Attributes["showRowHeaders"] != null)
			{
				ct_PivotTableStyle.showRowHeaders = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["showRowHeaders"]);
			}
			if (node.Attributes["showColHeaders"] != null)
			{
				ct_PivotTableStyle.showColHeaders = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["showColHeaders"]);
			}
			if (node.Attributes["showRowStripes"] != null)
			{
				ct_PivotTableStyle.showRowStripes = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["showRowStripes"]);
			}
			if (node.Attributes["showColStripes"] != null)
			{
				ct_PivotTableStyle.showColStripes = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["showColStripes"]);
			}
			if (node.Attributes["showLastColumn"] != null)
			{
				ct_PivotTableStyle.showLastColumn = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["showLastColumn"]);
			}
			return ct_PivotTableStyle;
		}

		// Token: 0x06003408 RID: 13320 RVA: 0x00082A7C File Offset: 0x00080C7C
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "name", this.name);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "showRowHeaders", this.showRowHeaders);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "showColHeaders", this.showColHeaders);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "showRowStripes", this.showRowStripes);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "showColStripes", this.showColStripes);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "showLastColumn", this.showLastColumn);
			sw.Write(">");
			sw.Write(string.Format("</{0}>", nodeName));
		}

		// Token: 0x170013BB RID: 5051
		// (get) Token: 0x06003409 RID: 13321 RVA: 0x00082B1C File Offset: 0x00080D1C
		// (set) Token: 0x0600340A RID: 13322 RVA: 0x00082B24 File Offset: 0x00080D24
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

		// Token: 0x170013BC RID: 5052
		// (get) Token: 0x0600340B RID: 13323 RVA: 0x00082B2D File Offset: 0x00080D2D
		// (set) Token: 0x0600340C RID: 13324 RVA: 0x00082B35 File Offset: 0x00080D35
		[global::System.Xml.Serialization.XmlAttribute]
		public bool showRowHeaders
		{
			get
			{
				return this.showRowHeadersField;
			}
			set
			{
				this.showRowHeadersField = value;
			}
		}

		// Token: 0x170013BD RID: 5053
		// (get) Token: 0x0600340D RID: 13325 RVA: 0x00082B3E File Offset: 0x00080D3E
		// (set) Token: 0x0600340E RID: 13326 RVA: 0x00082B46 File Offset: 0x00080D46
		[global::System.Xml.Serialization.XmlIgnore]
		public bool showRowHeadersSpecified
		{
			get
			{
				return this.showRowHeadersFieldSpecified;
			}
			set
			{
				this.showRowHeadersFieldSpecified = value;
			}
		}

		// Token: 0x170013BE RID: 5054
		// (get) Token: 0x0600340F RID: 13327 RVA: 0x00082B4F File Offset: 0x00080D4F
		// (set) Token: 0x06003410 RID: 13328 RVA: 0x00082B57 File Offset: 0x00080D57
		[global::System.Xml.Serialization.XmlAttribute]
		public bool showColHeaders
		{
			get
			{
				return this.showColHeadersField;
			}
			set
			{
				this.showColHeadersField = value;
			}
		}

		// Token: 0x170013BF RID: 5055
		// (get) Token: 0x06003411 RID: 13329 RVA: 0x00082B60 File Offset: 0x00080D60
		// (set) Token: 0x06003412 RID: 13330 RVA: 0x00082B68 File Offset: 0x00080D68
		[global::System.Xml.Serialization.XmlIgnore]
		public bool showColHeadersSpecified
		{
			get
			{
				return this.showColHeadersFieldSpecified;
			}
			set
			{
				this.showColHeadersFieldSpecified = value;
			}
		}

		// Token: 0x170013C0 RID: 5056
		// (get) Token: 0x06003413 RID: 13331 RVA: 0x00082B71 File Offset: 0x00080D71
		// (set) Token: 0x06003414 RID: 13332 RVA: 0x00082B79 File Offset: 0x00080D79
		[global::System.Xml.Serialization.XmlAttribute]
		public bool showRowStripes
		{
			get
			{
				return this.showRowStripesField;
			}
			set
			{
				this.showRowStripesField = value;
			}
		}

		// Token: 0x170013C1 RID: 5057
		// (get) Token: 0x06003415 RID: 13333 RVA: 0x00082B82 File Offset: 0x00080D82
		// (set) Token: 0x06003416 RID: 13334 RVA: 0x00082B8A File Offset: 0x00080D8A
		[global::System.Xml.Serialization.XmlIgnore]
		public bool showRowStripesSpecified
		{
			get
			{
				return this.showRowStripesFieldSpecified;
			}
			set
			{
				this.showRowStripesFieldSpecified = value;
			}
		}

		// Token: 0x170013C2 RID: 5058
		// (get) Token: 0x06003417 RID: 13335 RVA: 0x00082B93 File Offset: 0x00080D93
		// (set) Token: 0x06003418 RID: 13336 RVA: 0x00082B9B File Offset: 0x00080D9B
		[global::System.Xml.Serialization.XmlAttribute]
		public bool showColStripes
		{
			get
			{
				return this.showColStripesField;
			}
			set
			{
				this.showColStripesField = value;
			}
		}

		// Token: 0x170013C3 RID: 5059
		// (get) Token: 0x06003419 RID: 13337 RVA: 0x00082BA4 File Offset: 0x00080DA4
		// (set) Token: 0x0600341A RID: 13338 RVA: 0x00082BAC File Offset: 0x00080DAC
		[global::System.Xml.Serialization.XmlIgnore]
		public bool showColStripesSpecified
		{
			get
			{
				return this.showColStripesFieldSpecified;
			}
			set
			{
				this.showColStripesFieldSpecified = value;
			}
		}

		// Token: 0x170013C4 RID: 5060
		// (get) Token: 0x0600341B RID: 13339 RVA: 0x00082BB5 File Offset: 0x00080DB5
		// (set) Token: 0x0600341C RID: 13340 RVA: 0x00082BBD File Offset: 0x00080DBD
		[global::System.Xml.Serialization.XmlAttribute]
		public bool showLastColumn
		{
			get
			{
				return this.showLastColumnField;
			}
			set
			{
				this.showLastColumnField = value;
			}
		}

		// Token: 0x170013C5 RID: 5061
		// (get) Token: 0x0600341D RID: 13341 RVA: 0x00082BC6 File Offset: 0x00080DC6
		// (set) Token: 0x0600341E RID: 13342 RVA: 0x00082BCE File Offset: 0x00080DCE
		[global::System.Xml.Serialization.XmlIgnore]
		public bool showLastColumnSpecified
		{
			get
			{
				return this.showLastColumnFieldSpecified;
			}
			set
			{
				this.showLastColumnFieldSpecified = value;
			}
		}

		// Token: 0x0400228F RID: 8847
		private string nameField;

		// Token: 0x04002290 RID: 8848
		private bool showRowHeadersField;

		// Token: 0x04002291 RID: 8849
		private bool showRowHeadersFieldSpecified;

		// Token: 0x04002292 RID: 8850
		private bool showColHeadersField;

		// Token: 0x04002293 RID: 8851
		private bool showColHeadersFieldSpecified;

		// Token: 0x04002294 RID: 8852
		private bool showRowStripesField;

		// Token: 0x04002295 RID: 8853
		private bool showRowStripesFieldSpecified;

		// Token: 0x04002296 RID: 8854
		private bool showColStripesField;

		// Token: 0x04002297 RID: 8855
		private bool showColStripesFieldSpecified;

		// Token: 0x04002298 RID: 8856
		private bool showLastColumnField;

		// Token: 0x04002299 RID: 8857
		private bool showLastColumnFieldSpecified;
	}
}
