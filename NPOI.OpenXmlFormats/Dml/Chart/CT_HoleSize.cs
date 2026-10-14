using System;
using System.ComponentModel;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Dml.Chart
{
	// Token: 0x020003DF RID: 991
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/chart")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/chart", IsNullable = true)]
	[global::System.Serializable]
	public class CT_HoleSize
	{
		// Token: 0x0600274B RID: 10059 RVA: 0x0006273A File Offset: 0x0006093A
		public CT_HoleSize()
		{
			this.valField = 10;
		}

		// Token: 0x0600274C RID: 10060 RVA: 0x0006274C File Offset: 0x0006094C
		public static global::NPOI.OpenXmlFormats.Dml.Chart.CT_HoleSize Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Dml.Chart.CT_HoleSize ct_HoleSize = new global::NPOI.OpenXmlFormats.Dml.Chart.CT_HoleSize();
			if (node.Attributes["val"] != null)
			{
				ct_HoleSize.val = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadByte(node.Attributes["val"]);
			}
			return ct_HoleSize;
		}

		// Token: 0x0600274D RID: 10061 RVA: 0x00062792 File Offset: 0x00060992
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<c:{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "val", (int)this.val);
			sw.Write(">");
			sw.Write(string.Format("</c:{0}>", nodeName));
		}

		// Token: 0x17000EEF RID: 3823
		// (get) Token: 0x0600274E RID: 10062 RVA: 0x000627D2 File Offset: 0x000609D2
		// (set) Token: 0x0600274F RID: 10063 RVA: 0x000627DA File Offset: 0x000609DA
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(typeof(byte), "10")]
		public byte val
		{
			get
			{
				return this.valField;
			}
			set
			{
				this.valField = value;
			}
		}

		// Token: 0x04001CFA RID: 7418
		private byte valField;
	}
}
