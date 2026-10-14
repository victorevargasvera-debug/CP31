using System;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Dml
{
	// Token: 0x020002AD RID: 685
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_Point2D
	{
		// Token: 0x06001B90 RID: 7056 RVA: 0x0004A630 File Offset: 0x00048830
		public static global::NPOI.OpenXmlFormats.Dml.CT_Point2D Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			return new global::NPOI.OpenXmlFormats.Dml.CT_Point2D
			{
				name = node.Name,
				x = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadLong(node.Attributes["x"]),
				y = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadLong(node.Attributes["y"])
			};
		}

		// Token: 0x06001B91 RID: 7057 RVA: 0x0004A68C File Offset: 0x0004888C
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			if (this.name == null)
			{
				sw.Write(string.Format("<a:{0}", nodeName));
			}
			else
			{
				sw.Write(string.Format("<{0}", this.name));
			}
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "x", (double)this.x, true);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "y", (double)this.y, true);
			sw.Write("/>");
		}

		// Token: 0x17000A65 RID: 2661
		// (get) Token: 0x06001B92 RID: 7058 RVA: 0x0004A6FB File Offset: 0x000488FB
		// (set) Token: 0x06001B93 RID: 7059 RVA: 0x0004A703 File Offset: 0x00048903
		[global::System.Xml.Serialization.XmlAttribute]
		public long x
		{
			get
			{
				return this.xField;
			}
			set
			{
				this.xField = value;
			}
		}

		// Token: 0x17000A66 RID: 2662
		// (get) Token: 0x06001B94 RID: 7060 RVA: 0x0004A70C File Offset: 0x0004890C
		// (set) Token: 0x06001B95 RID: 7061 RVA: 0x0004A714 File Offset: 0x00048914
		[global::System.Xml.Serialization.XmlAttribute]
		public long y
		{
			get
			{
				return this.yField;
			}
			set
			{
				this.yField = value;
			}
		}

		// Token: 0x040014E7 RID: 5351
		private long xField;

		// Token: 0x040014E8 RID: 5352
		private long yField;

		// Token: 0x040014E9 RID: 5353
		private string name;
	}
}
