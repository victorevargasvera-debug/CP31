using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Spreadsheet
{
	// Token: 0x02000505 RID: 1285
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
	[global::System.Serializable]
	public class CT_Fills
	{
		// Token: 0x060036CC RID: 14028 RVA: 0x00088958 File Offset: 0x00086B58
		public static global::NPOI.OpenXmlFormats.Spreadsheet.CT_Fills Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_Fills ct_Fills = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_Fills();
			ct_Fills.count = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadUInt(node.Attributes["count"]);
			ct_Fills.fill = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_Fill>();
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "fill")
				{
					ct_Fills.fill.Add(global::NPOI.OpenXmlFormats.Spreadsheet.CT_Fill.Parse(xmlNode, namespaceManager));
				}
			}
			return ct_Fills;
		}

		// Token: 0x060036CD RID: 14029 RVA: 0x00088A00 File Offset: 0x00086C00
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "count", this.count, false);
			sw.Write(">");
			if (this.fill != null)
			{
				foreach (global::NPOI.OpenXmlFormats.Spreadsheet.CT_Fill ct_Fill in this.fill)
				{
					ct_Fill.Write(sw, "fill");
				}
			}
			sw.Write(string.Format("</{0}>", nodeName));
		}

		// Token: 0x170014B3 RID: 5299
		// (get) Token: 0x060036CE RID: 14030 RVA: 0x00088AA0 File Offset: 0x00086CA0
		// (set) Token: 0x060036CF RID: 14031 RVA: 0x00088AA8 File Offset: 0x00086CA8
		[global::System.Xml.Serialization.XmlElement]
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_Fill> fill
		{
			get
			{
				return this.fillField;
			}
			set
			{
				this.fillField = value;
			}
		}

		// Token: 0x060036D0 RID: 14032 RVA: 0x00088AA8 File Offset: 0x00086CA8
		public void SetFillArray(global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_Fill> array)
		{
			this.fillField = array;
		}

		// Token: 0x170014B4 RID: 5300
		// (get) Token: 0x060036D1 RID: 14033 RVA: 0x00088AB1 File Offset: 0x00086CB1
		// (set) Token: 0x060036D2 RID: 14034 RVA: 0x00088AB9 File Offset: 0x00086CB9
		[global::System.Xml.Serialization.XmlAttribute]
		public uint count
		{
			get
			{
				return this.countField;
			}
			set
			{
				this.countField = value;
			}
		}

		// Token: 0x170014B5 RID: 5301
		// (get) Token: 0x060036D3 RID: 14035 RVA: 0x00088AC2 File Offset: 0x00086CC2
		// (set) Token: 0x060036D4 RID: 14036 RVA: 0x00088ACA File Offset: 0x00086CCA
		[global::System.Xml.Serialization.XmlIgnore]
		public bool countSpecified
		{
			get
			{
				return this.countFieldSpecified;
			}
			set
			{
				this.countFieldSpecified = value;
			}
		}

		// Token: 0x040023F5 RID: 9205
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_Fill> fillField;

		// Token: 0x040023F6 RID: 9206
		private uint countField;

		// Token: 0x040023F7 RID: 9207
		private bool countFieldSpecified;
	}
}
