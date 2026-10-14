using System;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Spreadsheet
{
	// Token: 0x020004F6 RID: 1270
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
	[global::System.Serializable]
	public class CT_RElt
	{
		// Token: 0x060035A2 RID: 13730 RVA: 0x00086160 File Offset: 0x00084360
		public static global::NPOI.OpenXmlFormats.Spreadsheet.CT_RElt Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_RElt ct_RElt = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_RElt();
			global::System.Xml.XmlNode xmlNode = node.SelectSingleNode("d:t", namespaceManager);
			if (xmlNode != null)
			{
				ct_RElt.t = xmlNode.InnerText.Replace("\r", "");
			}
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode2 = (global::System.Xml.XmlNode)obj;
				if (xmlNode2.LocalName == "rPr")
				{
					ct_RElt.rPr = global::NPOI.OpenXmlFormats.Spreadsheet.CT_RPrElt.Parse(xmlNode2, namespaceManager);
				}
			}
			return ct_RElt;
		}

		// Token: 0x060035A3 RID: 13731 RVA: 0x0008620C File Offset: 0x0008440C
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<{0}>", nodeName));
			if (this.rPr != null)
			{
				this.rPr.Write(sw, "rPr");
			}
			if (this.t != null)
			{
				sw.Write(string.Format("<t xml:space=\"preserve\">{0}</t>", global::NPOI.OpenXml4Net.Util.XmlHelper.ExcelEncodeString(global::NPOI.OpenXml4Net.Util.XmlHelper.EncodeXml(this.t))));
			}
			sw.Write(string.Format("</{0}>", nodeName));
		}

		// Token: 0x060035A4 RID: 13732 RVA: 0x0008627C File Offset: 0x0008447C
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_RPrElt AddNewRPr()
		{
			this.rPrField = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_RPrElt();
			return this.rPrField;
		}

		// Token: 0x17001454 RID: 5204
		// (get) Token: 0x060035A5 RID: 13733 RVA: 0x0008628F File Offset: 0x0008448F
		// (set) Token: 0x060035A6 RID: 13734 RVA: 0x00086297 File Offset: 0x00084497
		[global::System.Xml.Serialization.XmlElement("rPr")]
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_RPrElt rPr
		{
			get
			{
				return this.rPrField;
			}
			set
			{
				this.rPrField = value;
			}
		}

		// Token: 0x17001455 RID: 5205
		// (get) Token: 0x060035A7 RID: 13735 RVA: 0x000862A0 File Offset: 0x000844A0
		// (set) Token: 0x060035A8 RID: 13736 RVA: 0x000862A8 File Offset: 0x000844A8
		[global::System.Xml.Serialization.XmlElement("t")]
		public string t
		{
			get
			{
				return this.tField;
			}
			set
			{
				this.tField = value;
			}
		}

		// Token: 0x060035A9 RID: 13737 RVA: 0x000862B1 File Offset: 0x000844B1
		public bool isSetRPr()
		{
			return this.rPrField != null;
		}

		// Token: 0x04002396 RID: 9110
		private global::NPOI.OpenXmlFormats.Spreadsheet.CT_RPrElt rPrField;

		// Token: 0x04002397 RID: 9111
		private string tField = string.Empty;
	}
}
