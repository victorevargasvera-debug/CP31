using System;
using System.IO;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Wordprocessing
{
	// Token: 0x02000100 RID: 256
	[global::System.Xml.Serialization.XmlInclude(typeof(global::NPOI.OpenXmlFormats.Wordprocessing.CT_FontRel))]
	[global::System.Xml.Serialization.XmlInclude(typeof(global::NPOI.OpenXmlFormats.Wordprocessing.CT_HdrFtrRef))]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_Rel
	{
		// Token: 0x17000257 RID: 599
		// (get) Token: 0x060006FF RID: 1791 RVA: 0x00015F57 File Offset: 0x00014157
		// (set) Token: 0x06000700 RID: 1792 RVA: 0x00015F5F File Offset: 0x0001415F
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

		// Token: 0x06000701 RID: 1793 RVA: 0x00015F68 File Offset: 0x00014168
		public static global::NPOI.OpenXmlFormats.Wordprocessing.CT_Rel Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			return new global::NPOI.OpenXmlFormats.Wordprocessing.CT_Rel
			{
				id = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["r:id"])
			};
		}

		// Token: 0x06000702 RID: 1794 RVA: 0x00015F8F File Offset: 0x0001418F
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<w:{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "r:id", this.id);
			sw.Write(">");
			sw.Write(string.Format("</w:{0}>", nodeName));
		}

		// Token: 0x04000637 RID: 1591
		private string idField;
	}
}
