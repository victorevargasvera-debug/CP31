using System;
using System.IO;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Wordprocessing
{
	// Token: 0x0200004B RID: 75
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_MacroName
	{
		// Token: 0x170000DA RID: 218
		// (get) Token: 0x06000272 RID: 626 RVA: 0x000042CB File Offset: 0x000024CB
		// (set) Token: 0x06000273 RID: 627 RVA: 0x000042D3 File Offset: 0x000024D3
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

		// Token: 0x06000274 RID: 628 RVA: 0x000042DC File Offset: 0x000024DC
		public static global::NPOI.OpenXmlFormats.Wordprocessing.CT_MacroName Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			return new global::NPOI.OpenXmlFormats.Wordprocessing.CT_MacroName
			{
				val = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["w:val"])
			};
		}

		// Token: 0x06000275 RID: 629 RVA: 0x00004303 File Offset: 0x00002503
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<w:{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "w:val", this.val, true);
			sw.Write("/>");
		}

		// Token: 0x040001AF RID: 431
		private string valField;
	}
}
