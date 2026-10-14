using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Spreadsheet
{
	// Token: 0x02000524 RID: 1316
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
	[global::System.Serializable]
	public class CT_DefinedNames
	{
		// Token: 0x060039F7 RID: 14839 RVA: 0x0008FE64 File Offset: 0x0008E064
		public static global::NPOI.OpenXmlFormats.Spreadsheet.CT_DefinedNames Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_DefinedNames ct_DefinedNames = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_DefinedNames();
			ct_DefinedNames.definedName = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_DefinedName>();
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "definedName")
				{
					ct_DefinedNames.definedName.Add(global::NPOI.OpenXmlFormats.Spreadsheet.CT_DefinedName.Parse(xmlNode, namespaceManager));
				}
			}
			return ct_DefinedNames;
		}

		// Token: 0x060039F8 RID: 14840 RVA: 0x0008FEF4 File Offset: 0x0008E0F4
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<{0}", nodeName));
			sw.Write(">");
			if (this.definedName != null)
			{
				foreach (global::NPOI.OpenXmlFormats.Spreadsheet.CT_DefinedName ct_DefinedName in this.definedName)
				{
					ct_DefinedName.Write(sw, "definedName");
				}
			}
			sw.Write(string.Format("</{0}>", nodeName));
		}

		// Token: 0x060039F9 RID: 14841 RVA: 0x0008FF80 File Offset: 0x0008E180
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_DefinedName AddNewDefinedName()
		{
			if (this.definedNameField == null)
			{
				this.definedNameField = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_DefinedName>();
			}
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_DefinedName ct_DefinedName = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_DefinedName();
			this.definedNameField.Add(ct_DefinedName);
			return ct_DefinedName;
		}

		// Token: 0x060039FA RID: 14842 RVA: 0x0008FFB3 File Offset: 0x0008E1B3
		public void SetDefinedNameArray(global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_DefinedName> array)
		{
			this.definedNameField = array;
		}

		// Token: 0x170015A9 RID: 5545
		// (get) Token: 0x060039FB RID: 14843 RVA: 0x0008FFBC File Offset: 0x0008E1BC
		// (set) Token: 0x060039FC RID: 14844 RVA: 0x0008FFB3 File Offset: 0x0008E1B3
		[global::System.Xml.Serialization.XmlElement]
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_DefinedName> definedName
		{
			get
			{
				return this.definedNameField;
			}
			set
			{
				this.definedNameField = value;
			}
		}

		// Token: 0x04002503 RID: 9475
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_DefinedName> definedNameField;
	}
}
