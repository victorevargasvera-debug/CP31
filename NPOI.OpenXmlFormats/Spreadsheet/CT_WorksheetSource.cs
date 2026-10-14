using System;
using System.IO;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Spreadsheet
{
	// Token: 0x02000486 RID: 1158
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main", IsNullable = true)]
	public class CT_WorksheetSource
	{
		// Token: 0x06002E66 RID: 11878 RVA: 0x0007473C File Offset: 0x0007293C
		public static global::NPOI.OpenXmlFormats.Spreadsheet.CT_WorksheetSource Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			return new global::NPOI.OpenXmlFormats.Spreadsheet.CT_WorksheetSource
			{
				@ref = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["ref"]),
				name = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["name"]),
				sheet = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["sheet"]),
				id = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["r:id"])
			};
		}

		// Token: 0x06002E67 RID: 11879 RVA: 0x000747C0 File Offset: 0x000729C0
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

		// Token: 0x1700116E RID: 4462
		// (get) Token: 0x06002E68 RID: 11880 RVA: 0x0007483E File Offset: 0x00072A3E
		// (set) Token: 0x06002E69 RID: 11881 RVA: 0x00074846 File Offset: 0x00072A46
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

		// Token: 0x1700116F RID: 4463
		// (get) Token: 0x06002E6A RID: 11882 RVA: 0x0007484F File Offset: 0x00072A4F
		// (set) Token: 0x06002E6B RID: 11883 RVA: 0x00074857 File Offset: 0x00072A57
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

		// Token: 0x17001170 RID: 4464
		// (get) Token: 0x06002E6C RID: 11884 RVA: 0x00074860 File Offset: 0x00072A60
		// (set) Token: 0x06002E6D RID: 11885 RVA: 0x00074868 File Offset: 0x00072A68
		[global::System.Xml.Serialization.XmlAttribute]
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

		// Token: 0x17001171 RID: 4465
		// (get) Token: 0x06002E6E RID: 11886 RVA: 0x00074871 File Offset: 0x00072A71
		// (set) Token: 0x06002E6F RID: 11887 RVA: 0x00074879 File Offset: 0x00072A79
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

		// Token: 0x04002000 RID: 8192
		private string refField;

		// Token: 0x04002001 RID: 8193
		private string nameField;

		// Token: 0x04002002 RID: 8194
		private string sheetField;

		// Token: 0x04002003 RID: 8195
		private string idField;
	}
}
