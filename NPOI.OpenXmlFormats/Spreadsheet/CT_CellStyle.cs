using System;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Spreadsheet
{
	// Token: 0x020004FE RID: 1278
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
	[global::System.Serializable]
	public class CT_CellStyle
	{
		// Token: 0x06003665 RID: 13925 RVA: 0x0008797C File Offset: 0x00085B7C
		public static global::NPOI.OpenXmlFormats.Spreadsheet.CT_CellStyle Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_CellStyle ct_CellStyle = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_CellStyle();
			ct_CellStyle.name = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["name"]);
			ct_CellStyle.xfId = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadUInt(node.Attributes["xfId"]);
			ct_CellStyle.builtinId = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadUInt(node.Attributes["builtinId"]);
			ct_CellStyle.iLevel = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadUInt(node.Attributes["iLevel"]);
			ct_CellStyle.hidden = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["hidden"]);
			ct_CellStyle.customBuiltin = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["customBuiltin"]);
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "extLst")
				{
					ct_CellStyle.extLst = global::NPOI.OpenXmlFormats.Spreadsheet.CT_ExtensionList.Parse(xmlNode, namespaceManager);
				}
			}
			return ct_CellStyle;
		}

		// Token: 0x06003666 RID: 13926 RVA: 0x00087A9C File Offset: 0x00085C9C
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "name", this.name);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "xfId", this.xfId, true);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "builtinId", this.builtinId, true);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "iLevel", this.iLevel, false);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "hidden", this.hidden, false);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "customBuiltin", this.customBuiltin, false);
			if (this.extLst != null)
			{
				sw.Write(">");
				this.extLst.Write(sw, "extLst");
				sw.Write(string.Format("</{0}>", nodeName));
				return;
			}
			sw.Write("/>");
		}

		// Token: 0x17001493 RID: 5267
		// (get) Token: 0x06003667 RID: 13927 RVA: 0x00087B66 File Offset: 0x00085D66
		// (set) Token: 0x06003668 RID: 13928 RVA: 0x00087B6E File Offset: 0x00085D6E
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

		// Token: 0x17001494 RID: 5268
		// (get) Token: 0x06003669 RID: 13929 RVA: 0x00087B77 File Offset: 0x00085D77
		// (set) Token: 0x0600366A RID: 13930 RVA: 0x00087B7F File Offset: 0x00085D7F
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

		// Token: 0x17001495 RID: 5269
		// (get) Token: 0x0600366B RID: 13931 RVA: 0x00087B88 File Offset: 0x00085D88
		// (set) Token: 0x0600366C RID: 13932 RVA: 0x00087B90 File Offset: 0x00085D90
		[global::System.Xml.Serialization.XmlAttribute]
		public uint xfId
		{
			get
			{
				return this.xfIdField;
			}
			set
			{
				this.xfIdField = value;
			}
		}

		// Token: 0x17001496 RID: 5270
		// (get) Token: 0x0600366D RID: 13933 RVA: 0x00087B99 File Offset: 0x00085D99
		// (set) Token: 0x0600366E RID: 13934 RVA: 0x00087BA1 File Offset: 0x00085DA1
		[global::System.Xml.Serialization.XmlAttribute]
		public uint builtinId
		{
			get
			{
				return this.builtinIdField;
			}
			set
			{
				this.builtinIdField = value;
			}
		}

		// Token: 0x17001497 RID: 5271
		// (get) Token: 0x0600366F RID: 13935 RVA: 0x00087BAA File Offset: 0x00085DAA
		// (set) Token: 0x06003670 RID: 13936 RVA: 0x00087BB2 File Offset: 0x00085DB2
		[global::System.Xml.Serialization.XmlIgnore]
		public bool builtinIdSpecified
		{
			get
			{
				return this.builtinIdFieldSpecified;
			}
			set
			{
				this.builtinIdFieldSpecified = value;
			}
		}

		// Token: 0x17001498 RID: 5272
		// (get) Token: 0x06003671 RID: 13937 RVA: 0x00087BBB File Offset: 0x00085DBB
		// (set) Token: 0x06003672 RID: 13938 RVA: 0x00087BC3 File Offset: 0x00085DC3
		[global::System.Xml.Serialization.XmlAttribute]
		public uint iLevel
		{
			get
			{
				return this.iLevelField;
			}
			set
			{
				this.iLevelField = value;
			}
		}

		// Token: 0x17001499 RID: 5273
		// (get) Token: 0x06003673 RID: 13939 RVA: 0x00087BCC File Offset: 0x00085DCC
		// (set) Token: 0x06003674 RID: 13940 RVA: 0x00087BD4 File Offset: 0x00085DD4
		[global::System.Xml.Serialization.XmlIgnore]
		public bool iLevelSpecified
		{
			get
			{
				return this.iLevelFieldSpecified;
			}
			set
			{
				this.iLevelFieldSpecified = value;
			}
		}

		// Token: 0x1700149A RID: 5274
		// (get) Token: 0x06003675 RID: 13941 RVA: 0x00087BDD File Offset: 0x00085DDD
		// (set) Token: 0x06003676 RID: 13942 RVA: 0x00087BE5 File Offset: 0x00085DE5
		[global::System.Xml.Serialization.XmlAttribute]
		public bool hidden
		{
			get
			{
				return this.hiddenField;
			}
			set
			{
				this.hiddenField = value;
			}
		}

		// Token: 0x1700149B RID: 5275
		// (get) Token: 0x06003677 RID: 13943 RVA: 0x00087BEE File Offset: 0x00085DEE
		// (set) Token: 0x06003678 RID: 13944 RVA: 0x00087BF6 File Offset: 0x00085DF6
		[global::System.Xml.Serialization.XmlIgnore]
		public bool hiddenSpecified
		{
			get
			{
				return this.hiddenFieldSpecified;
			}
			set
			{
				this.hiddenFieldSpecified = value;
			}
		}

		// Token: 0x1700149C RID: 5276
		// (get) Token: 0x06003679 RID: 13945 RVA: 0x00087BFF File Offset: 0x00085DFF
		// (set) Token: 0x0600367A RID: 13946 RVA: 0x00087C07 File Offset: 0x00085E07
		[global::System.Xml.Serialization.XmlAttribute]
		public bool customBuiltin
		{
			get
			{
				return this.customBuiltinField;
			}
			set
			{
				this.customBuiltinField = value;
			}
		}

		// Token: 0x1700149D RID: 5277
		// (get) Token: 0x0600367B RID: 13947 RVA: 0x00087C10 File Offset: 0x00085E10
		// (set) Token: 0x0600367C RID: 13948 RVA: 0x00087C18 File Offset: 0x00085E18
		[global::System.Xml.Serialization.XmlIgnore]
		public bool customBuiltinSpecified
		{
			get
			{
				return this.customBuiltinFieldSpecified;
			}
			set
			{
				this.customBuiltinFieldSpecified = value;
			}
		}

		// Token: 0x040023D5 RID: 9173
		private global::NPOI.OpenXmlFormats.Spreadsheet.CT_ExtensionList extLstField;

		// Token: 0x040023D6 RID: 9174
		private string nameField;

		// Token: 0x040023D7 RID: 9175
		private uint xfIdField;

		// Token: 0x040023D8 RID: 9176
		private uint builtinIdField;

		// Token: 0x040023D9 RID: 9177
		private bool builtinIdFieldSpecified;

		// Token: 0x040023DA RID: 9178
		private uint iLevelField;

		// Token: 0x040023DB RID: 9179
		private bool iLevelFieldSpecified;

		// Token: 0x040023DC RID: 9180
		private bool hiddenField;

		// Token: 0x040023DD RID: 9181
		private bool hiddenFieldSpecified;

		// Token: 0x040023DE RID: 9182
		private bool customBuiltinField;

		// Token: 0x040023DF RID: 9183
		private bool customBuiltinFieldSpecified;
	}
}
