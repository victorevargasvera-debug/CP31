using System;
using System.IO;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Spreadsheet
{
	// Token: 0x02000590 RID: 1424
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
	[global::System.Serializable]
	public class CT_DataRef
	{
		// Token: 0x17001780 RID: 6016
		// (get) Token: 0x06003E8D RID: 16013 RVA: 0x00097B24 File Offset: 0x00095D24
		// (set) Token: 0x06003E8E RID: 16014 RVA: 0x00097B2C File Offset: 0x00095D2C
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

		// Token: 0x17001781 RID: 6017
		// (get) Token: 0x06003E8F RID: 16015 RVA: 0x00097B35 File Offset: 0x00095D35
		// (set) Token: 0x06003E90 RID: 16016 RVA: 0x00097B3D File Offset: 0x00095D3D
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

		// Token: 0x17001782 RID: 6018
		// (get) Token: 0x06003E91 RID: 16017 RVA: 0x00097B46 File Offset: 0x00095D46
		// (set) Token: 0x06003E92 RID: 16018 RVA: 0x00097B4E File Offset: 0x00095D4E
		public string sheet
		{
			get
			{
				return this.sheetField;
			}
			set
			{
				this.sheetField = value;
			}
		}

		// Token: 0x17001783 RID: 6019
		// (get) Token: 0x06003E93 RID: 16019 RVA: 0x00097B57 File Offset: 0x00095D57
		// (set) Token: 0x06003E94 RID: 16020 RVA: 0x00097B5F File Offset: 0x00095D5F
		[global::System.Xml.Serialization.XmlAttribute(Form = global::System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://schemas.openxmlformats.org/officeDocument/2006/relationships")]
		public string id
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

		// Token: 0x06003E95 RID: 16021 RVA: 0x00097B68 File Offset: 0x00095D68
		public static global::NPOI.OpenXmlFormats.Spreadsheet.CT_DataRef Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			return new global::NPOI.OpenXmlFormats.Spreadsheet.CT_DataRef
			{
				@ref = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["ref"]),
				name = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["name"]),
				sheet = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["sheet"]),
				id = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["id", "http://schemas.openxmlformats.org/officeDocument/2006/relationships"])
			};
		}

		// Token: 0x06003E96 RID: 16022 RVA: 0x00097BF0 File Offset: 0x00095DF0
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "ref", this.@ref);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "name", this.name);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "sheet", this.sheet);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "r:id", this.id);
			sw.Write(">");
			sw.Write(string.Format("</{0}>", nodeName));
		}

		// Token: 0x040027B4 RID: 10164
		private string refField;

		// Token: 0x040027B5 RID: 10165
		private string nameField;

		// Token: 0x040027B6 RID: 10166
		private string sheetField;

		// Token: 0x040027B7 RID: 10167
		private string idField;
	}
}
