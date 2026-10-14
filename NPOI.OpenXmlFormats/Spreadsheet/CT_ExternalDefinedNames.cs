using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Spreadsheet
{
	// Token: 0x0200060A RID: 1546
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_ExternalDefinedNames
	{
		// Token: 0x060043AF RID: 17327 RVA: 0x000A110C File Offset: 0x0009F30C
		public CT_ExternalDefinedNames()
		{
			this.definedNameField = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_ExternalDefinedName>();
		}

		// Token: 0x1700198E RID: 6542
		// (get) Token: 0x060043B0 RID: 17328 RVA: 0x000A111F File Offset: 0x0009F31F
		// (set) Token: 0x060043B1 RID: 17329 RVA: 0x000A112C File Offset: 0x0009F32C
		[global::System.Xml.Serialization.XmlElement("definedName")]
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_ExternalDefinedName[] definedName
		{
			get
			{
				return this.definedNameField.ToArray();
			}
			set
			{
				this.definedNameField.Clear();
				this.definedNameField.AddRange(value);
			}
		}

		// Token: 0x060043B2 RID: 17330 RVA: 0x000A1148 File Offset: 0x0009F348
		internal static global::NPOI.OpenXmlFormats.Spreadsheet.CT_ExternalDefinedNames Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_ExternalDefinedNames ct_ExternalDefinedNames = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_ExternalDefinedNames();
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode node2 = (global::System.Xml.XmlNode)obj;
				ct_ExternalDefinedNames.definedNameField.Add(global::NPOI.OpenXmlFormats.Spreadsheet.CT_ExternalDefinedName.Parse(node2, namespaceManager));
			}
			return ct_ExternalDefinedNames;
		}

		// Token: 0x060043B3 RID: 17331 RVA: 0x000A11B4 File Offset: 0x0009F3B4
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<{0}>", nodeName));
			foreach (global::NPOI.OpenXmlFormats.Spreadsheet.CT_ExternalDefinedName ct_ExternalDefinedName in this.definedNameField)
			{
				ct_ExternalDefinedName.Write(sw, "definedName");
			}
			sw.Write(string.Format("</{0}>", nodeName));
		}

		// Token: 0x04002A9A RID: 10906
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_ExternalDefinedName> definedNameField;
	}
}
