using System;
using System.ComponentModel;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Dml.Chart
{
	// Token: 0x020003FF RID: 1023
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/chart")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/chart", IsNullable = true)]
	[global::System.Serializable]
	public class CT_Extension
	{
		// Token: 0x17000F86 RID: 3974
		// (get) Token: 0x060028E9 RID: 10473 RVA: 0x00067083 File Offset: 0x00065283
		// (set) Token: 0x060028EA RID: 10474 RVA: 0x0006708B File Offset: 0x0006528B
		[global::System.Xml.Serialization.XmlText]
		public string Any
		{
			get
			{
				return this.anyField;
			}
			set
			{
				this.anyField = value;
			}
		}

		// Token: 0x17000F87 RID: 3975
		// (get) Token: 0x060028EB RID: 10475 RVA: 0x00067094 File Offset: 0x00065294
		// (set) Token: 0x060028EC RID: 10476 RVA: 0x0006709C File Offset: 0x0006529C
		[global::System.Xml.Serialization.XmlAttribute(DataType = "token")]
		public string uri
		{
			get
			{
				return this.uriField;
			}
			set
			{
				this.uriField = value;
			}
		}

		// Token: 0x060028ED RID: 10477 RVA: 0x000670A5 File Offset: 0x000652A5
		public static global::NPOI.OpenXmlFormats.Dml.Chart.CT_Extension Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			return new global::NPOI.OpenXmlFormats.Dml.Chart.CT_Extension
			{
				uri = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["uri"]),
				Any = node.InnerXml
			};
		}

		// Token: 0x060028EE RID: 10478 RVA: 0x000670D8 File Offset: 0x000652D8
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<c:{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "uri", this.uri);
			sw.Write(">");
			if (this.Any != null)
			{
				sw.Write(this.Any);
			}
			sw.Write(string.Format("</c:{0}>", nodeName));
		}

		// Token: 0x04001DA3 RID: 7587
		private string anyField;

		// Token: 0x04001DA4 RID: 7588
		private string uriField;
	}
}
