using System;
using System.IO;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Wordprocessing
{
	// Token: 0x0200019E RID: 414
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_SmartTagType
	{
		// Token: 0x06000F90 RID: 3984 RVA: 0x00032A30 File Offset: 0x00030C30
		public static global::NPOI.OpenXmlFormats.Wordprocessing.CT_SmartTagType Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			return new global::NPOI.OpenXmlFormats.Wordprocessing.CT_SmartTagType
			{
				namespaceuri = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["w:namespaceuri"]),
				name = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["w:name"]),
				url = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["w:url"])
			};
		}

		// Token: 0x06000F91 RID: 3985 RVA: 0x00032A98 File Offset: 0x00030C98
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<w:{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "w:namespaceuri", this.namespaceuri);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "w:name", this.name);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "w:url", this.url);
			sw.Write(">");
			sw.Write(string.Format("</w:{0}>", nodeName));
		}

		// Token: 0x17000596 RID: 1430
		// (get) Token: 0x06000F92 RID: 3986 RVA: 0x00032B05 File Offset: 0x00030D05
		// (set) Token: 0x06000F93 RID: 3987 RVA: 0x00032B0D File Offset: 0x00030D0D
		[global::System.Xml.Serialization.XmlAttribute(Form = global::System.Xml.Schema.XmlSchemaForm.Qualified)]
		public string namespaceuri
		{
			get
			{
				return this.namespaceuriField;
			}
			set
			{
				this.namespaceuriField = value;
			}
		}

		// Token: 0x17000597 RID: 1431
		// (get) Token: 0x06000F94 RID: 3988 RVA: 0x00032B16 File Offset: 0x00030D16
		// (set) Token: 0x06000F95 RID: 3989 RVA: 0x00032B1E File Offset: 0x00030D1E
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

		// Token: 0x17000598 RID: 1432
		// (get) Token: 0x06000F96 RID: 3990 RVA: 0x00032B27 File Offset: 0x00030D27
		// (set) Token: 0x06000F97 RID: 3991 RVA: 0x00032B2F File Offset: 0x00030D2F
		[global::System.Xml.Serialization.XmlAttribute(Form = global::System.Xml.Schema.XmlSchemaForm.Qualified)]
		public string url
		{
			get
			{
				return this.urlField;
			}
			set
			{
				this.urlField = value;
			}
		}

		// Token: 0x04000CAB RID: 3243
		private string namespaceuriField;

		// Token: 0x04000CAC RID: 3244
		private string nameField;

		// Token: 0x04000CAD RID: 3245
		private string urlField;
	}
}
