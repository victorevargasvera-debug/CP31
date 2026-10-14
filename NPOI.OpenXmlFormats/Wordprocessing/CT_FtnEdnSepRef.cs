using System;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Wordprocessing
{
	// Token: 0x02000125 RID: 293
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
	[global::System.Serializable]
	public class CT_FtnEdnSepRef
	{
		// Token: 0x060007F4 RID: 2036 RVA: 0x0001AF5D File Offset: 0x0001915D
		public static global::NPOI.OpenXmlFormats.Wordprocessing.CT_FtnEdnSepRef Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			return new global::NPOI.OpenXmlFormats.Wordprocessing.CT_FtnEdnSepRef
			{
				id = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["w:id"])
			};
		}

		// Token: 0x060007F5 RID: 2037 RVA: 0x0001AF84 File Offset: 0x00019184
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<w:{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "w:id", this.id);
			sw.Write("/>");
		}

		// Token: 0x1700029F RID: 671
		// (get) Token: 0x060007F6 RID: 2038 RVA: 0x0001AFB3 File Offset: 0x000191B3
		// (set) Token: 0x060007F7 RID: 2039 RVA: 0x0001AFBB File Offset: 0x000191BB
		[global::System.Xml.Serialization.XmlAttribute(DataType = "integer")]
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

		// Token: 0x0400072A RID: 1834
		private string idField;
	}
}
