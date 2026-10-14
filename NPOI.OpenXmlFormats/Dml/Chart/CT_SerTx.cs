using System;
using System.ComponentModel;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Dml.Chart
{
	// Token: 0x0200042F RID: 1071
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/chart")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/chart", IsNullable = true)]
	[global::System.Serializable]
	public class CT_SerTx
	{
		// Token: 0x1700102C RID: 4140
		// (get) Token: 0x06002AF0 RID: 10992 RVA: 0x0006BB37 File Offset: 0x00069D37
		// (set) Token: 0x06002AF1 RID: 10993 RVA: 0x0006BB3F File Offset: 0x00069D3F
		public global::NPOI.OpenXmlFormats.Dml.Chart.CT_StrRef strRef
		{
			get
			{
				return this.strRefField;
			}
			set
			{
				this.strRefField = value;
			}
		}

		// Token: 0x1700102D RID: 4141
		// (get) Token: 0x06002AF2 RID: 10994 RVA: 0x0006BB48 File Offset: 0x00069D48
		// (set) Token: 0x06002AF3 RID: 10995 RVA: 0x0006BB50 File Offset: 0x00069D50
		public string v
		{
			get
			{
				return this.vField;
			}
			set
			{
				this.vField = value;
			}
		}

		// Token: 0x06002AF4 RID: 10996 RVA: 0x0006BB5C File Offset: 0x00069D5C
		public static global::NPOI.OpenXmlFormats.Dml.Chart.CT_SerTx Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Dml.Chart.CT_SerTx ct_SerTx = new global::NPOI.OpenXmlFormats.Dml.Chart.CT_SerTx();
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "strRef")
				{
					ct_SerTx.strRef = global::NPOI.OpenXmlFormats.Dml.Chart.CT_StrRef.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "v")
				{
					ct_SerTx.v = xmlNode.InnerText;
				}
			}
			return ct_SerTx;
		}

		// Token: 0x06002AF5 RID: 10997 RVA: 0x0006BBFC File Offset: 0x00069DFC
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<c:{0}", nodeName));
			sw.Write(">");
			if (this.strRef != null)
			{
				this.strRef.Write(sw, "strRef");
			}
			if (this.v != null)
			{
				sw.Write(string.Format("<c:v>{0}</c:v>", global::NPOI.OpenXml4Net.Util.XmlHelper.EncodeXml(this.v)));
			}
			sw.Write(string.Format("</c:{0}>", nodeName));
		}

		// Token: 0x06002AF6 RID: 10998 RVA: 0x0006BC72 File Offset: 0x00069E72
		public global::NPOI.OpenXmlFormats.Dml.Chart.CT_StrRef AddNewStrRef()
		{
			this.strRefField = new global::NPOI.OpenXmlFormats.Dml.Chart.CT_StrRef();
			return this.strRefField;
		}

		// Token: 0x04001E80 RID: 7808
		private global::NPOI.OpenXmlFormats.Dml.Chart.CT_StrRef strRefField;

		// Token: 0x04001E81 RID: 7809
		private string vField;
	}
}
