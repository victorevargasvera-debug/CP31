using System;
using System.IO;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Shared
{
	// Token: 0x0200064C RID: 1612
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/officeDocument/2006/math")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/officeDocument/2006/math", IsNullable = true)]
	[global::System.Serializable]
	public class CT_Text1
	{
		// Token: 0x06004543 RID: 17731 RVA: 0x000A453F File Offset: 0x000A273F
		public static global::NPOI.OpenXmlFormats.Shared.CT_Text1 Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			return new global::NPOI.OpenXmlFormats.Shared.CT_Text1
			{
				space = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["m:space"]),
				Value = node.InnerText
			};
		}

		// Token: 0x06004544 RID: 17732 RVA: 0x000A4574 File Offset: 0x000A2774
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<m:{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "m:space", this.space);
			sw.Write(">");
			if (this.valueField != null)
			{
				sw.Write(global::NPOI.OpenXml4Net.Util.XmlHelper.EncodeXml(this.valueField));
			}
			sw.Write(string.Format("</m:{0}>", nodeName));
		}

		// Token: 0x17001A0C RID: 6668
		// (get) Token: 0x06004545 RID: 17733 RVA: 0x000A45D8 File Offset: 0x000A27D8
		// (set) Token: 0x06004546 RID: 17734 RVA: 0x000A45E0 File Offset: 0x000A27E0
		[global::System.Xml.Serialization.XmlAttribute(Form = global::System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.w3.org/XML/1998/namespace")]
		public string space
		{
			get
			{
				return this.spaceField;
			}
			set
			{
				this.spaceField = value;
			}
		}

		// Token: 0x17001A0D RID: 6669
		// (get) Token: 0x06004547 RID: 17735 RVA: 0x000A45E9 File Offset: 0x000A27E9
		// (set) Token: 0x06004548 RID: 17736 RVA: 0x000A45F1 File Offset: 0x000A27F1
		[global::System.Xml.Serialization.XmlText]
		public string Value
		{
			get
			{
				return this.valueField;
			}
			set
			{
				this.valueField = value;
			}
		}

		// Token: 0x04002B6B RID: 11115
		private string spaceField;

		// Token: 0x04002B6C RID: 11116
		private string valueField;
	}
}
