using System;
using System.IO;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Wordprocessing
{
	// Token: 0x02000062 RID: 98
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_Attr
	{
		// Token: 0x060002FF RID: 767 RVA: 0x00006B54 File Offset: 0x00004D54
		public static global::NPOI.OpenXmlFormats.Wordprocessing.CT_Attr Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			return new global::NPOI.OpenXmlFormats.Wordprocessing.CT_Attr
			{
				uri = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["w:uri"]),
				name = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["w:name"]),
				val = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["w:val"])
			};
		}

		// Token: 0x06000300 RID: 768 RVA: 0x00006BBC File Offset: 0x00004DBC
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<w:{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "w:uri", this.uri);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "w:name", this.name);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "w:val", this.val);
			sw.Write(">");
			sw.Write(string.Format("</w:{0}>", nodeName));
		}

		// Token: 0x170000FC RID: 252
		// (get) Token: 0x06000301 RID: 769 RVA: 0x00006C29 File Offset: 0x00004E29
		// (set) Token: 0x06000302 RID: 770 RVA: 0x00006C31 File Offset: 0x00004E31
		[global::System.Xml.Serialization.XmlAttribute(Form = global::System.Xml.Schema.XmlSchemaForm.Qualified)]
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

		// Token: 0x170000FD RID: 253
		// (get) Token: 0x06000303 RID: 771 RVA: 0x00006C3A File Offset: 0x00004E3A
		// (set) Token: 0x06000304 RID: 772 RVA: 0x00006C42 File Offset: 0x00004E42
		[global::System.Xml.Serialization.XmlAttribute(Form = global::System.Xml.Schema.XmlSchemaForm.Qualified)]
		public string name
		{
			get
			{
				return this.nameField;
			}
			set
			{
				this.nameField = value;
			}
		}

		// Token: 0x170000FE RID: 254
		// (get) Token: 0x06000305 RID: 773 RVA: 0x00006C4B File Offset: 0x00004E4B
		// (set) Token: 0x06000306 RID: 774 RVA: 0x00006C53 File Offset: 0x00004E53
		[global::System.Xml.Serialization.XmlAttribute(Form = global::System.Xml.Schema.XmlSchemaForm.Qualified)]
		public string val
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

		// Token: 0x040001F0 RID: 496
		private string uriField;

		// Token: 0x040001F1 RID: 497
		private string nameField;

		// Token: 0x040001F2 RID: 498
		private string valField;
	}
}
