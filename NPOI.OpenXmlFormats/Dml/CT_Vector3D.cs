using System;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Dml
{
	// Token: 0x020002C3 RID: 707
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_Vector3D
	{
		// Token: 0x06001C11 RID: 7185 RVA: 0x0004D3FC File Offset: 0x0004B5FC
		public static global::NPOI.OpenXmlFormats.Dml.CT_Vector3D Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			return new global::NPOI.OpenXmlFormats.Dml.CT_Vector3D
			{
				dx = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadLong(node.Attributes["dx"]),
				dy = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadLong(node.Attributes["dy"]),
				dz = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadLong(node.Attributes["dz"])
			};
		}

		// Token: 0x06001C12 RID: 7186 RVA: 0x0004D464 File Offset: 0x0004B664
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<a:{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "dx", (double)this.dx);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "dy", (double)this.dy);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "dz", (double)this.dz);
			sw.Write(">");
			sw.Write(string.Format("</a:{0}>", nodeName));
		}

		// Token: 0x17000A8D RID: 2701
		// (get) Token: 0x06001C13 RID: 7187 RVA: 0x0004D4D4 File Offset: 0x0004B6D4
		// (set) Token: 0x06001C14 RID: 7188 RVA: 0x0004D4DC File Offset: 0x0004B6DC
		[global::System.Xml.Serialization.XmlAttribute]
		public long dx
		{
			get
			{
				return this.dxField;
			}
			set
			{
				this.dxField = value;
			}
		}

		// Token: 0x17000A8E RID: 2702
		// (get) Token: 0x06001C15 RID: 7189 RVA: 0x0004D4E5 File Offset: 0x0004B6E5
		// (set) Token: 0x06001C16 RID: 7190 RVA: 0x0004D4ED File Offset: 0x0004B6ED
		[global::System.Xml.Serialization.XmlAttribute]
		public long dy
		{
			get
			{
				return this.dyField;
			}
			set
			{
				this.dyField = value;
			}
		}

		// Token: 0x17000A8F RID: 2703
		// (get) Token: 0x06001C17 RID: 7191 RVA: 0x0004D4F6 File Offset: 0x0004B6F6
		// (set) Token: 0x06001C18 RID: 7192 RVA: 0x0004D4FE File Offset: 0x0004B6FE
		[global::System.Xml.Serialization.XmlAttribute]
		public long dz
		{
			get
			{
				return this.dzField;
			}
			set
			{
				this.dzField = value;
			}
		}

		// Token: 0x040015F1 RID: 5617
		private long dxField;

		// Token: 0x040015F2 RID: 5618
		private long dyField;

		// Token: 0x040015F3 RID: 5619
		private long dzField;
	}
}
