using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Spreadsheet
{
	// Token: 0x020005CF RID: 1487
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
	[global::System.Serializable]
	public class CT_Controls
	{
		// Token: 0x06004180 RID: 16768 RVA: 0x0009EA38 File Offset: 0x0009CC38
		public static global::NPOI.OpenXmlFormats.Spreadsheet.CT_Controls Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_Controls ct_Controls = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_Controls();
			ct_Controls.control = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_Control>();
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "control")
				{
					ct_Controls.control.Add(global::NPOI.OpenXmlFormats.Spreadsheet.CT_Control.Parse(xmlNode, namespaceManager));
				}
			}
			return ct_Controls;
		}

		// Token: 0x06004181 RID: 16769 RVA: 0x0009EAC8 File Offset: 0x0009CCC8
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<{0}", nodeName));
			sw.Write(">");
			if (this.control != null)
			{
				foreach (global::NPOI.OpenXmlFormats.Spreadsheet.CT_Control ct_Control in this.control)
				{
					ct_Control.Write(sw, "control");
				}
			}
			sw.Write(string.Format("</{0}>", nodeName));
		}

		// Token: 0x170018A2 RID: 6306
		// (get) Token: 0x06004183 RID: 16771 RVA: 0x0009EB54 File Offset: 0x0009CD54
		// (set) Token: 0x06004184 RID: 16772 RVA: 0x0009EB5C File Offset: 0x0009CD5C
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_Control> control
		{
			get
			{
				return this.controlField;
			}
			set
			{
				this.controlField = value;
			}
		}

		// Token: 0x0400294C RID: 10572
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_Control> controlField;
	}
}
