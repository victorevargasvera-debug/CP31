using System;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Dml
{
	// Token: 0x020002A5 RID: 677
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_OfficeArtExtension
	{
		// Token: 0x17000A5A RID: 2650
		// (get) Token: 0x06001B70 RID: 7024 RVA: 0x0004A4BF File Offset: 0x000486BF
		// (set) Token: 0x06001B71 RID: 7025 RVA: 0x0004A4C7 File Offset: 0x000486C7
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

		// Token: 0x17000A5B RID: 2651
		// (get) Token: 0x06001B72 RID: 7026 RVA: 0x0004A4D0 File Offset: 0x000486D0
		// (set) Token: 0x06001B73 RID: 7027 RVA: 0x0004A4D8 File Offset: 0x000486D8
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

		// Token: 0x17000A5C RID: 2652
		// (get) Token: 0x06001B74 RID: 7028 RVA: 0x0004A4E1 File Offset: 0x000486E1
		// (set) Token: 0x06001B75 RID: 7029 RVA: 0x0004A4E9 File Offset: 0x000486E9
		public bool uriSpecified
		{
			get
			{
				return this.uriSpecifiedField;
			}
			set
			{
				this.uriSpecifiedField = value;
			}
		}

		// Token: 0x06001B76 RID: 7030 RVA: 0x0004A4F4 File Offset: 0x000486F4
		public static global::NPOI.OpenXmlFormats.Dml.CT_OfficeArtExtension Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			return new global::NPOI.OpenXmlFormats.Dml.CT_OfficeArtExtension
			{
				uri = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["uri"]),
				Any = node.InnerXml.Replace(" xmlns:a=\"http://schemas.openxmlformats.org/drawingml/2006/main\"", "")
			};
		}

		// Token: 0x06001B77 RID: 7031 RVA: 0x0004A544 File Offset: 0x00048744
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<a:{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "uri", this.uri);
			sw.Write(">");
			if (!string.IsNullOrEmpty(this.anyField))
			{
				sw.Write(this.anyField);
			}
			sw.Write(string.Format("</a:{0}>", nodeName));
		}

		// Token: 0x040014DC RID: 5340
		private string anyField;

		// Token: 0x040014DD RID: 5341
		private string uriField;

		// Token: 0x040014DE RID: 5342
		private bool uriSpecifiedField;
	}
}
