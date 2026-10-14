using System;
using System.IO;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Wordprocessing
{
	// Token: 0x02000091 RID: 145
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_FFName
	{
		// Token: 0x17000150 RID: 336
		// (get) Token: 0x060003F4 RID: 1012 RVA: 0x0000B924 File Offset: 0x00009B24
		// (set) Token: 0x060003F5 RID: 1013 RVA: 0x0000B92C File Offset: 0x00009B2C
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

		// Token: 0x060003F6 RID: 1014 RVA: 0x0000B935 File Offset: 0x00009B35
		public static global::NPOI.OpenXmlFormats.Wordprocessing.CT_FFName Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			return new global::NPOI.OpenXmlFormats.Wordprocessing.CT_FFName
			{
				val = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["w:val"])
			};
		}

		// Token: 0x060003F7 RID: 1015 RVA: 0x0000B95C File Offset: 0x00009B5C
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<w:{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "w:val", this.val, true);
			sw.Write("/>");
		}

		// Token: 0x04000396 RID: 918
		private string valField;
	}
}
