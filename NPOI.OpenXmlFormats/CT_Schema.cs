using System;
using System.ComponentModel;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats
{
	// Token: 0x02000005 RID: 5
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/schemaLibrary/2006/main")]
	[global::System.Serializable]
	public class CT_Schema
	{
		// Token: 0x06000016 RID: 22 RVA: 0x000022A0 File Offset: 0x000004A0
		public static global::NPOI.OpenXmlFormats.CT_Schema Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			return new global::NPOI.OpenXmlFormats.CT_Schema
			{
				uri = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["w:uri"]),
				manifestLocation = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["w:manifestLocation"]),
				schemaLocation = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["w:schemaLocation"])
			};
		}

		// Token: 0x06000017 RID: 23 RVA: 0x00002308 File Offset: 0x00000508
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<w:{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "w:uri", this.uri);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "w:manifestLocation", this.manifestLocation);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "w:schemaLocation", this.schemaLocation);
			sw.Write(">");
			sw.Write(string.Format("</w:{0}>", nodeName));
		}

		// Token: 0x06000018 RID: 24 RVA: 0x00002375 File Offset: 0x00000575
		public CT_Schema()
		{
			this.uriField = "";
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000019 RID: 25 RVA: 0x00002388 File Offset: 0x00000588
		// (set) Token: 0x0600001A RID: 26 RVA: 0x00002390 File Offset: 0x00000590
		[global::System.ComponentModel.DefaultValue("")]
		[global::System.Xml.Serialization.XmlAttribute]
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

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x0600001B RID: 27 RVA: 0x00002399 File Offset: 0x00000599
		// (set) Token: 0x0600001C RID: 28 RVA: 0x000023A1 File Offset: 0x000005A1
		[global::System.Xml.Serialization.XmlAttribute]
		public string manifestLocation
		{
			get
			{
				return this.manifestLocationField;
			}
			set
			{
				this.manifestLocationField = value;
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x0600001D RID: 29 RVA: 0x000023AA File Offset: 0x000005AA
		// (set) Token: 0x0600001E RID: 30 RVA: 0x000023B2 File Offset: 0x000005B2
		[global::System.Xml.Serialization.XmlAttribute]
		public string schemaLocation
		{
			get
			{
				return this.schemaLocationField;
			}
			set
			{
				this.schemaLocationField = value;
			}
		}

		// Token: 0x04000008 RID: 8
		private string uriField;

		// Token: 0x04000009 RID: 9
		private string manifestLocationField;

		// Token: 0x0400000A RID: 10
		private string schemaLocationField;
	}
}
