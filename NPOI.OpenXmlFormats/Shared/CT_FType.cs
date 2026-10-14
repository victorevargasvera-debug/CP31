using System;
using System.IO;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Shared
{
	// Token: 0x02000642 RID: 1602
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/officeDocument/2006/math")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/officeDocument/2006/math", IsNullable = true)]
	[global::System.Serializable]
	public class CT_FType
	{
		// Token: 0x06004519 RID: 17689 RVA: 0x000A3F48 File Offset: 0x000A2148
		public static global::NPOI.OpenXmlFormats.Shared.CT_FType Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Shared.CT_FType ct_FType = new global::NPOI.OpenXmlFormats.Shared.CT_FType();
			if (node.Attributes["m:val"] != null)
			{
				ct_FType.val = (global::NPOI.OpenXmlFormats.Shared.ST_FType)global::System.Enum.Parse(typeof(global::NPOI.OpenXmlFormats.Shared.ST_FType), node.Attributes["m:val"].Value);
			}
			return ct_FType;
		}

		// Token: 0x0600451A RID: 17690 RVA: 0x000A3FA4 File Offset: 0x000A21A4
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<m:{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "m:val", this.val.ToString());
			sw.Write(">");
			sw.Write(string.Format("</m:{0}>", nodeName));
		}

		// Token: 0x17001A01 RID: 6657
		// (get) Token: 0x0600451B RID: 17691 RVA: 0x000A3FFD File Offset: 0x000A21FD
		// (set) Token: 0x0600451C RID: 17692 RVA: 0x000A4005 File Offset: 0x000A2205
		[global::System.Xml.Serialization.XmlAttribute(Form = global::System.Xml.Schema.XmlSchemaForm.Qualified)]
		public global::NPOI.OpenXmlFormats.Shared.ST_FType val
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

		// Token: 0x04002B4C RID: 11084
		private global::NPOI.OpenXmlFormats.Shared.ST_FType valField;
	}
}
