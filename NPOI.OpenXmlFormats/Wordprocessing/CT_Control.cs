using System;
using System.IO;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Wordprocessing
{
	// Token: 0x0200012F RID: 303
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_Control
	{
		// Token: 0x06000843 RID: 2115 RVA: 0x0001BC64 File Offset: 0x00019E64
		public static global::NPOI.OpenXmlFormats.Wordprocessing.CT_Control Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			return new global::NPOI.OpenXmlFormats.Wordprocessing.CT_Control
			{
				name = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["w:name"]),
				shapeid = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["w:shapeid"]),
				id = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["r:id"])
			};
		}

		// Token: 0x06000844 RID: 2116 RVA: 0x0001BCCC File Offset: 0x00019ECC
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<w:{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "w:name", this.name);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "w:shapeid", this.shapeid);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "r:id", this.id);
			sw.Write(">");
			sw.Write(string.Format("</w:{0}>", nodeName));
		}

		// Token: 0x170002B8 RID: 696
		// (get) Token: 0x06000845 RID: 2117 RVA: 0x0001BD39 File Offset: 0x00019F39
		// (set) Token: 0x06000846 RID: 2118 RVA: 0x0001BD41 File Offset: 0x00019F41
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

		// Token: 0x170002B9 RID: 697
		// (get) Token: 0x06000847 RID: 2119 RVA: 0x0001BD4A File Offset: 0x00019F4A
		// (set) Token: 0x06000848 RID: 2120 RVA: 0x0001BD52 File Offset: 0x00019F52
		[global::System.Xml.Serialization.XmlAttribute(Form = global::System.Xml.Schema.XmlSchemaForm.Qualified)]
		public string shapeid
		{
			get
			{
				return this.shapeidField;
			}
			set
			{
				this.shapeidField = value;
			}
		}

		// Token: 0x170002BA RID: 698
		// (get) Token: 0x06000849 RID: 2121 RVA: 0x0001BD5B File Offset: 0x00019F5B
		// (set) Token: 0x0600084A RID: 2122 RVA: 0x0001BD63 File Offset: 0x00019F63
		[global::System.Xml.Serialization.XmlAttribute(Form = global::System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://schemas.openxmlformats.org/officeDocument/2006/relationships")]
		public string id
		{
			get
			{
				return this.idField;
			}
			set
			{
				this.idField = value;
			}
		}

		// Token: 0x04000746 RID: 1862
		private string nameField;

		// Token: 0x04000747 RID: 1863
		private string shapeidField;

		// Token: 0x04000748 RID: 1864
		private string idField;
	}
}
