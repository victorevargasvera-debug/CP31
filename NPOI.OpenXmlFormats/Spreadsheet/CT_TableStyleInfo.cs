using System;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Spreadsheet
{
	// Token: 0x020004EB RID: 1259
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
	[global::System.Serializable]
	public class CT_TableStyleInfo
	{
		// Token: 0x06003513 RID: 13587 RVA: 0x00084E80 File Offset: 0x00083080
		public static global::NPOI.OpenXmlFormats.Spreadsheet.CT_TableStyleInfo Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_TableStyleInfo ct_TableStyleInfo = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_TableStyleInfo();
			ct_TableStyleInfo.name = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["name"]);
			if (node.Attributes["showFirstColumn"] != null)
			{
				ct_TableStyleInfo.showFirstColumn = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["showFirstColumn"]);
			}
			if (node.Attributes["showLastColumn"] != null)
			{
				ct_TableStyleInfo.showLastColumn = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["showLastColumn"]);
			}
			if (node.Attributes["showRowStripes"] != null)
			{
				ct_TableStyleInfo.showRowStripes = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["showRowStripes"]);
			}
			if (node.Attributes["showColumnStripes"] != null)
			{
				ct_TableStyleInfo.showColumnStripes = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["showColumnStripes"]);
			}
			return ct_TableStyleInfo;
		}

		// Token: 0x06003514 RID: 13588 RVA: 0x00084F68 File Offset: 0x00083168
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "name", this.name);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "showFirstColumn", this.showFirstColumn);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "showLastColumn", this.showLastColumn);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "showRowStripes", this.showRowStripes);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "showColumnStripes", this.showColumnStripes);
			sw.Write("/>");
		}

		// Token: 0x1700142A RID: 5162
		// (get) Token: 0x06003515 RID: 13589 RVA: 0x00084FE6 File Offset: 0x000831E6
		// (set) Token: 0x06003516 RID: 13590 RVA: 0x00084FEE File Offset: 0x000831EE
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

		// Token: 0x1700142B RID: 5163
		// (get) Token: 0x06003517 RID: 13591 RVA: 0x00084FF7 File Offset: 0x000831F7
		// (set) Token: 0x06003518 RID: 13592 RVA: 0x00084FFF File Offset: 0x000831FF
		[global::System.Xml.Serialization.XmlAttribute]
		public bool showFirstColumn
		{
			get
			{
				return this.showFirstColumnField;
			}
			set
			{
				this.showFirstColumnField = value;
			}
		}

		// Token: 0x1700142C RID: 5164
		// (get) Token: 0x06003519 RID: 13593 RVA: 0x00085008 File Offset: 0x00083208
		// (set) Token: 0x0600351A RID: 13594 RVA: 0x00085010 File Offset: 0x00083210
		[global::System.Xml.Serialization.XmlIgnore]
		public bool showFirstColumnSpecified
		{
			get
			{
				return this.showFirstColumnFieldSpecified;
			}
			set
			{
				this.showFirstColumnFieldSpecified = value;
			}
		}

		// Token: 0x1700142D RID: 5165
		// (get) Token: 0x0600351B RID: 13595 RVA: 0x00085019 File Offset: 0x00083219
		// (set) Token: 0x0600351C RID: 13596 RVA: 0x00085021 File Offset: 0x00083221
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

		// Token: 0x1700142E RID: 5166
		// (get) Token: 0x0600351D RID: 13597 RVA: 0x0008502A File Offset: 0x0008322A
		// (set) Token: 0x0600351E RID: 13598 RVA: 0x00085032 File Offset: 0x00083232
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

		// Token: 0x1700142F RID: 5167
		// (get) Token: 0x0600351F RID: 13599 RVA: 0x0008503B File Offset: 0x0008323B
		// (set) Token: 0x06003520 RID: 13600 RVA: 0x00085043 File Offset: 0x00083243
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

		// Token: 0x17001430 RID: 5168
		// (get) Token: 0x06003521 RID: 13601 RVA: 0x0008504C File Offset: 0x0008324C
		// (set) Token: 0x06003522 RID: 13602 RVA: 0x00085054 File Offset: 0x00083254
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

		// Token: 0x17001431 RID: 5169
		// (get) Token: 0x06003523 RID: 13603 RVA: 0x0008505D File Offset: 0x0008325D
		// (set) Token: 0x06003524 RID: 13604 RVA: 0x00085065 File Offset: 0x00083265
		[global::System.Xml.Serialization.XmlAttribute]
		public bool showColumnStripes
		{
			get
			{
				return this.showColumnStripesField;
			}
			set
			{
				this.showColumnStripesField = value;
			}
		}

		// Token: 0x17001432 RID: 5170
		// (get) Token: 0x06003525 RID: 13605 RVA: 0x0008506E File Offset: 0x0008326E
		// (set) Token: 0x06003526 RID: 13606 RVA: 0x00085076 File Offset: 0x00083276
		[global::System.Xml.Serialization.XmlIgnore]
		public bool showColumnStripesSpecified
		{
			get
			{
				return this.showColumnStripesFieldSpecified;
			}
			set
			{
				this.showColumnStripesFieldSpecified = value;
			}
		}

		// Token: 0x04002341 RID: 9025
		private string nameField;

		// Token: 0x04002342 RID: 9026
		private bool showFirstColumnField;

		// Token: 0x04002343 RID: 9027
		private bool showFirstColumnFieldSpecified;

		// Token: 0x04002344 RID: 9028
		private bool showLastColumnField;

		// Token: 0x04002345 RID: 9029
		private bool showLastColumnFieldSpecified;

		// Token: 0x04002346 RID: 9030
		private bool showRowStripesField;

		// Token: 0x04002347 RID: 9031
		private bool showRowStripesFieldSpecified;

		// Token: 0x04002348 RID: 9032
		private bool showColumnStripesField;

		// Token: 0x04002349 RID: 9033
		private bool showColumnStripesFieldSpecified;
	}
}
