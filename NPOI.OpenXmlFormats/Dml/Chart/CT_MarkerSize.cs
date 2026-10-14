using System;
using System.ComponentModel;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Dml.Chart
{
	// Token: 0x02000434 RID: 1076
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/chart")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/chart", IsNullable = true)]
	[global::System.Serializable]
	public class CT_MarkerSize
	{
		// Token: 0x06002B1C RID: 11036 RVA: 0x0006C2CD File Offset: 0x0006A4CD
		public CT_MarkerSize()
		{
			this.valField = 5;
		}

		// Token: 0x1700103B RID: 4155
		// (get) Token: 0x06002B1D RID: 11037 RVA: 0x0006C2DC File Offset: 0x0006A4DC
		// (set) Token: 0x06002B1E RID: 11038 RVA: 0x0006C2E4 File Offset: 0x0006A4E4
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(typeof(byte), "5")]
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

		// Token: 0x06002B1F RID: 11039 RVA: 0x0006C2ED File Offset: 0x0006A4ED
		public static global::NPOI.OpenXmlFormats.Dml.Chart.CT_MarkerSize Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			return new global::NPOI.OpenXmlFormats.Dml.Chart.CT_MarkerSize
			{
				val = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadByte(node.Attributes["val"])
			};
		}

		// Token: 0x06002B20 RID: 11040 RVA: 0x0006C314 File Offset: 0x0006A514
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<c:{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "val", (int)this.val);
			sw.Write(">");
			sw.Write(string.Format("</c:{0}>", nodeName));
		}

		// Token: 0x04001E9B RID: 7835
		private byte valField;
	}
}
