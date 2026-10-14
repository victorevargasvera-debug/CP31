using System;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Dml
{
	// Token: 0x020002AE RID: 686
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_PositiveSize2D
	{
		// Token: 0x06001B97 RID: 7063 RVA: 0x0004A720 File Offset: 0x00048920
		public static global::NPOI.OpenXmlFormats.Dml.CT_PositiveSize2D Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			return new global::NPOI.OpenXmlFormats.Dml.CT_PositiveSize2D
			{
				cx = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadLong(node.Attributes["cx"]),
				cy = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadLong(node.Attributes["cy"])
			};
		}

		// Token: 0x06001B98 RID: 7064 RVA: 0x0004A770 File Offset: 0x00048970
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "cx", (double)this.cx, true);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "cy", (double)this.cy, true);
			sw.Write("/>");
		}

		// Token: 0x17000A67 RID: 2663
		// (get) Token: 0x06001B99 RID: 7065 RVA: 0x0004A7BF File Offset: 0x000489BF
		// (set) Token: 0x06001B9A RID: 7066 RVA: 0x0004A7C7 File Offset: 0x000489C7
		[global::System.Xml.Serialization.XmlAttribute]
		public long cx
		{
			get
			{
				return this.cxField;
			}
			set
			{
				this.cxField = value;
			}
		}

		// Token: 0x17000A68 RID: 2664
		// (get) Token: 0x06001B9B RID: 7067 RVA: 0x0004A7D0 File Offset: 0x000489D0
		// (set) Token: 0x06001B9C RID: 7068 RVA: 0x0004A7D8 File Offset: 0x000489D8
		[global::System.Xml.Serialization.XmlAttribute]
		public long cy
		{
			get
			{
				return this.cyField;
			}
			set
			{
				this.cyField = value;
			}
		}

		// Token: 0x040014EA RID: 5354
		private long cxField;

		// Token: 0x040014EB RID: 5355
		private long cyField;
	}
}
