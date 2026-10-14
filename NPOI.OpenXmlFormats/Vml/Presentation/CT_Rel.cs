using System;
using System.ComponentModel;
using System.IO;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Vml.Presentation
{
	// Token: 0x02000208 RID: 520
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "urn:schemas-microsoft-com:office:powerpoint")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "urn:schemas-microsoft-com:office:powerpoint", IsNullable = true)]
	[global::System.Serializable]
	public class CT_Rel
	{
		// Token: 0x1700079B RID: 1947
		// (get) Token: 0x060014D4 RID: 5332 RVA: 0x00040E8D File Offset: 0x0003F08D
		// (set) Token: 0x060014D5 RID: 5333 RVA: 0x00040E95 File Offset: 0x0003F095
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

		// Token: 0x060014D6 RID: 5334 RVA: 0x00040E9E File Offset: 0x0003F09E
		public static global::NPOI.OpenXmlFormats.Vml.Presentation.CT_Rel Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			return new global::NPOI.OpenXmlFormats.Vml.Presentation.CT_Rel
			{
				id = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["r:id"])
			};
		}

		// Token: 0x060014D7 RID: 5335 RVA: 0x00040EC5 File Offset: 0x0003F0C5
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<p:{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "r:id", this.id);
			sw.Write(">");
			sw.Write(string.Format("</p:{0}>", nodeName));
		}

		// Token: 0x040010B5 RID: 4277
		private string idField;
	}
}
