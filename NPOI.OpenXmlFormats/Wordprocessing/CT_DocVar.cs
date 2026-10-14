using System;
using System.IO;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Wordprocessing
{
	// Token: 0x02000195 RID: 405
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_DocVar
	{
		// Token: 0x06000F1B RID: 3867 RVA: 0x00031A20 File Offset: 0x0002FC20
		public static global::NPOI.OpenXmlFormats.Wordprocessing.CT_DocVar Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			return new global::NPOI.OpenXmlFormats.Wordprocessing.CT_DocVar
			{
				name = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["w:name"]),
				val = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["w:val"])
			};
		}

		// Token: 0x06000F1C RID: 3868 RVA: 0x00031A70 File Offset: 0x0002FC70
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<w:{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "w:name", this.name);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "w:val", this.val);
			sw.Write(">");
			sw.Write(string.Format("</w:{0}>", nodeName));
		}

		// Token: 0x17000566 RID: 1382
		// (get) Token: 0x06000F1D RID: 3869 RVA: 0x00031ACC File Offset: 0x0002FCCC
		// (set) Token: 0x06000F1E RID: 3870 RVA: 0x00031AD4 File Offset: 0x0002FCD4
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

		// Token: 0x17000567 RID: 1383
		// (get) Token: 0x06000F1F RID: 3871 RVA: 0x00031ADD File Offset: 0x0002FCDD
		// (set) Token: 0x06000F20 RID: 3872 RVA: 0x00031AE5 File Offset: 0x0002FCE5
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

		// Token: 0x04000C69 RID: 3177
		private string nameField;

		// Token: 0x04000C6A RID: 3178
		private string valField;
	}
}
