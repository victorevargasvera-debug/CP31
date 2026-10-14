using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Spreadsheet
{
	// Token: 0x020005CE RID: 1486
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
	[global::System.Serializable]
	public class CT_OleObjects
	{
		// Token: 0x0600417B RID: 16763 RVA: 0x0009E8FC File Offset: 0x0009CAFC
		public static global::NPOI.OpenXmlFormats.Spreadsheet.CT_OleObjects Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_OleObjects ct_OleObjects = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_OleObjects();
			ct_OleObjects.oleObject = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_OleObject>();
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "oleObject")
				{
					ct_OleObjects.oleObject.Add(global::NPOI.OpenXmlFormats.Spreadsheet.CT_OleObject.Parse(xmlNode, namespaceManager));
				}
			}
			if (ct_OleObjects.oleObject.Count == 0)
			{
				return null;
			}
			return ct_OleObjects;
		}

		// Token: 0x0600417C RID: 16764 RVA: 0x0009E998 File Offset: 0x0009CB98
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<{0}", nodeName));
			sw.Write(">");
			if (this.oleObject != null)
			{
				foreach (global::NPOI.OpenXmlFormats.Spreadsheet.CT_OleObject ct_OleObject in this.oleObject)
				{
					ct_OleObject.Write(sw, "oleObject");
				}
			}
			sw.Write(string.Format("</{0}>", nodeName));
		}

		// Token: 0x170018A1 RID: 6305
		// (get) Token: 0x0600417E RID: 16766 RVA: 0x0009EA24 File Offset: 0x0009CC24
		// (set) Token: 0x0600417F RID: 16767 RVA: 0x0009EA2C File Offset: 0x0009CC2C
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_OleObject> oleObject
		{
			get
			{
				return this.oleObjectField;
			}
			set
			{
				this.oleObjectField = value;
			}
		}

		// Token: 0x0400294B RID: 10571
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_OleObject> oleObjectField;
	}
}
