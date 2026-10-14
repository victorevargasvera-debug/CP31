using System;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Dml
{
	// Token: 0x020002C2 RID: 706
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_Point3D
	{
		// Token: 0x06001C08 RID: 7176 RVA: 0x0004D2F0 File Offset: 0x0004B4F0
		public static global::NPOI.OpenXmlFormats.Dml.CT_Point3D Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			return new global::NPOI.OpenXmlFormats.Dml.CT_Point3D
			{
				x = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadLong(node.Attributes["x"]),
				y = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadLong(node.Attributes["y"]),
				z = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadLong(node.Attributes["z"])
			};
		}

		// Token: 0x06001C09 RID: 7177 RVA: 0x0004D358 File Offset: 0x0004B558
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<a:{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "x", (double)this.x);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "y", (double)this.y);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "z", (double)this.z);
			sw.Write(">");
			sw.Write(string.Format("</a:{0}>", nodeName));
		}

		// Token: 0x17000A8A RID: 2698
		// (get) Token: 0x06001C0A RID: 7178 RVA: 0x0004D3C8 File Offset: 0x0004B5C8
		// (set) Token: 0x06001C0B RID: 7179 RVA: 0x0004D3D0 File Offset: 0x0004B5D0
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

		// Token: 0x17000A8B RID: 2699
		// (get) Token: 0x06001C0C RID: 7180 RVA: 0x0004D3D9 File Offset: 0x0004B5D9
		// (set) Token: 0x06001C0D RID: 7181 RVA: 0x0004D3E1 File Offset: 0x0004B5E1
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

		// Token: 0x17000A8C RID: 2700
		// (get) Token: 0x06001C0E RID: 7182 RVA: 0x0004D3EA File Offset: 0x0004B5EA
		// (set) Token: 0x06001C0F RID: 7183 RVA: 0x0004D3F2 File Offset: 0x0004B5F2
		[global::System.Xml.Serialization.XmlAttribute]
		public long z
		{
			get
			{
				return this.zField;
			}
			set
			{
				this.zField = value;
			}
		}

		// Token: 0x040015EE RID: 5614
		private long xField;

		// Token: 0x040015EF RID: 5615
		private long yField;

		// Token: 0x040015F0 RID: 5616
		private long zField;
	}
}
