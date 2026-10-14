using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Spreadsheet
{
	// Token: 0x02000547 RID: 1351
	[global::System.Diagnostics.DebuggerStepThrough]
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
	[global::System.Serializable]
	public class CT_ExtensionList
	{
		// Token: 0x06003AFB RID: 15099 RVA: 0x00091C20 File Offset: 0x0008FE20
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_ExtensionList Copy()
		{
			return new global::NPOI.OpenXmlFormats.Spreadsheet.CT_ExtensionList
			{
				ext = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_Extension>(this.ext)
			};
		}

		// Token: 0x1700160C RID: 5644
		// (get) Token: 0x06003AFC RID: 15100 RVA: 0x00091C38 File Offset: 0x0008FE38
		// (set) Token: 0x06003AFD RID: 15101 RVA: 0x00091C40 File Offset: 0x0008FE40
		[global::System.Xml.Serialization.XmlElement]
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_Extension> ext
		{
			get
			{
				return this.extField;
			}
			set
			{
				this.extField = value;
			}
		}

		// Token: 0x06003AFE RID: 15102 RVA: 0x00091C4C File Offset: 0x0008FE4C
		public static global::NPOI.OpenXmlFormats.Spreadsheet.CT_ExtensionList Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_ExtensionList ct_ExtensionList = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_ExtensionList();
			ct_ExtensionList.ext = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_Extension>();
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "ext")
				{
					ct_ExtensionList.ext.Add(global::NPOI.OpenXmlFormats.Spreadsheet.CT_Extension.Parse(xmlNode, namespaceManager));
				}
			}
			return ct_ExtensionList;
		}

		// Token: 0x06003AFF RID: 15103 RVA: 0x00091CDC File Offset: 0x0008FEDC
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<{0}>", nodeName));
			if (this.ext != null)
			{
				foreach (global::NPOI.OpenXmlFormats.Spreadsheet.CT_Extension ct_Extension in this.ext)
				{
					ct_Extension.Write(sw, "ext");
				}
			}
			sw.Write(string.Format("</{0}>", nodeName));
		}

		// Token: 0x040025C4 RID: 9668
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_Extension> extField = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_Extension>();
	}
}
