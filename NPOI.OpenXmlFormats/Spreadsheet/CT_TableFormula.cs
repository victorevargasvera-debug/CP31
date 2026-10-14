using System;
using System.ComponentModel;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Spreadsheet
{
	// Token: 0x020004E9 RID: 1257
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
	[global::System.Serializable]
	public class CT_TableFormula
	{
		// Token: 0x060034FD RID: 13565 RVA: 0x00084B51 File Offset: 0x00082D51
		public CT_TableFormula()
		{
			this.arrayField = false;
		}

		// Token: 0x17001422 RID: 5154
		// (get) Token: 0x060034FE RID: 13566 RVA: 0x00084B60 File Offset: 0x00082D60
		// (set) Token: 0x060034FF RID: 13567 RVA: 0x00084B68 File Offset: 0x00082D68
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(false)]
		public bool array
		{
			get
			{
				return this.arrayField;
			}
			set
			{
				this.arrayField = value;
			}
		}

		// Token: 0x17001423 RID: 5155
		// (get) Token: 0x06003500 RID: 13568 RVA: 0x00084B71 File Offset: 0x00082D71
		// (set) Token: 0x06003501 RID: 13569 RVA: 0x00084B79 File Offset: 0x00082D79
		[global::System.Xml.Serialization.XmlText]
		public string Value
		{
			get
			{
				return this.valueField;
			}
			set
			{
				this.valueField = value;
			}
		}

		// Token: 0x06003502 RID: 13570 RVA: 0x00084B84 File Offset: 0x00082D84
		public static global::NPOI.OpenXmlFormats.Spreadsheet.CT_TableFormula Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_TableFormula ct_TableFormula = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_TableFormula();
			if (node.Attributes["array"] != null)
			{
				ct_TableFormula.array = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["array"]);
			}
			ct_TableFormula.Value = node.InnerText;
			return ct_TableFormula;
		}

		// Token: 0x06003503 RID: 13571 RVA: 0x00084BD8 File Offset: 0x00082DD8
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "array", this.array);
			sw.Write(">");
			sw.Write(global::NPOI.OpenXml4Net.Util.XmlHelper.EncodeXml(this.valueField));
			sw.Write(string.Format("</{0}>", nodeName));
		}

		// Token: 0x04002339 RID: 9017
		private bool arrayField;

		// Token: 0x0400233A RID: 9018
		private string valueField;
	}
}
