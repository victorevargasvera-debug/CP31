using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Spreadsheet
{
	// Token: 0x02000546 RID: 1350
	[global::System.Diagnostics.DebuggerStepThrough]
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
	[global::System.Serializable]
	public class CT_Extension
	{
		// Token: 0x06003AF3 RID: 15091 RVA: 0x00091B61 File Offset: 0x0008FD61
		public static global::NPOI.OpenXmlFormats.Spreadsheet.CT_Extension Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			return new global::NPOI.OpenXmlFormats.Spreadsheet.CT_Extension
			{
				uri = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["uri"]),
				Any = node.InnerXml
			};
		}

		// Token: 0x06003AF4 RID: 15092 RVA: 0x00091B94 File Offset: 0x0008FD94
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "uri", this.uri);
			sw.Write(">");
			if (this.Any != null)
			{
				sw.Write(this.Any);
			}
			sw.Write(string.Format("</{0}>", nodeName));
		}

		// Token: 0x17001609 RID: 5641
		// (get) Token: 0x06003AF5 RID: 15093 RVA: 0x00091BF3 File Offset: 0x0008FDF3
		// (set) Token: 0x06003AF6 RID: 15094 RVA: 0x00091BFB File Offset: 0x0008FDFB
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

		// Token: 0x1700160A RID: 5642
		// (get) Token: 0x06003AF7 RID: 15095 RVA: 0x00091C04 File Offset: 0x0008FE04
		// (set) Token: 0x06003AF8 RID: 15096 RVA: 0x00091C0C File Offset: 0x0008FE0C
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

		// Token: 0x1700160B RID: 5643
		// (get) Token: 0x06003AF9 RID: 15097 RVA: 0x00091C15 File Offset: 0x0008FE15
		[global::System.Xml.Serialization.XmlIgnore]
		public bool uriSpecified
		{
			get
			{
				return this.uriField != null;
			}
		}

		// Token: 0x040025C2 RID: 9666
		private string anyField;

		// Token: 0x040025C3 RID: 9667
		private string uriField;
	}
}
