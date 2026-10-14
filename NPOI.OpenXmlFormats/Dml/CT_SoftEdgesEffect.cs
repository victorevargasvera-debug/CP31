using System;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Dml
{
	// Token: 0x02000312 RID: 786
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_SoftEdgesEffect
	{
		// Token: 0x06001F27 RID: 7975 RVA: 0x000537E9 File Offset: 0x000519E9
		public static global::NPOI.OpenXmlFormats.Dml.CT_SoftEdgesEffect Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			return new global::NPOI.OpenXmlFormats.Dml.CT_SoftEdgesEffect
			{
				rad = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadLong(node.Attributes["rad"])
			};
		}

		// Token: 0x06001F28 RID: 7976 RVA: 0x00053810 File Offset: 0x00051A10
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<a:{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "rad", (double)this.rad);
			sw.Write(">");
			sw.Write(string.Format("</a:{0}>", nodeName));
		}

		// Token: 0x17000BB7 RID: 2999
		// (get) Token: 0x06001F29 RID: 7977 RVA: 0x0005385C File Offset: 0x00051A5C
		// (set) Token: 0x06001F2A RID: 7978 RVA: 0x00053864 File Offset: 0x00051A64
		[global::System.Xml.Serialization.XmlAttribute]
		public long rad
		{
			get
			{
				return this.radField;
			}
			set
			{
				this.radField = value;
			}
		}

		// Token: 0x0400184D RID: 6221
		private long radField;
	}
}
