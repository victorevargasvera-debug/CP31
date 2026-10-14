using System;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Dml
{
	// Token: 0x020002C4 RID: 708
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_SphereCoords
	{
		// Token: 0x06001C1A RID: 7194 RVA: 0x0004D508 File Offset: 0x0004B708
		public static global::NPOI.OpenXmlFormats.Dml.CT_SphereCoords Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			return new global::NPOI.OpenXmlFormats.Dml.CT_SphereCoords
			{
				lat = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadInt(node.Attributes["lat"]),
				lon = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadInt(node.Attributes["lon"]),
				rev = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadInt(node.Attributes["rev"])
			};
		}

		// Token: 0x06001C1B RID: 7195 RVA: 0x0004D570 File Offset: 0x0004B770
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<a:{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "lat", this.lat, true);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "lon", this.lon, true);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "rev", this.rev, true);
			sw.Write(">");
			sw.Write(string.Format("</a:{0}>", nodeName));
		}

		// Token: 0x17000A90 RID: 2704
		// (get) Token: 0x06001C1C RID: 7196 RVA: 0x0004D5E0 File Offset: 0x0004B7E0
		// (set) Token: 0x06001C1D RID: 7197 RVA: 0x0004D5E8 File Offset: 0x0004B7E8
		[global::System.Xml.Serialization.XmlAttribute]
		public int lat
		{
			get
			{
				return this.latField;
			}
			set
			{
				this.latField = value;
			}
		}

		// Token: 0x17000A91 RID: 2705
		// (get) Token: 0x06001C1E RID: 7198 RVA: 0x0004D5F1 File Offset: 0x0004B7F1
		// (set) Token: 0x06001C1F RID: 7199 RVA: 0x0004D5F9 File Offset: 0x0004B7F9
		[global::System.Xml.Serialization.XmlAttribute]
		public int lon
		{
			get
			{
				return this.lonField;
			}
			set
			{
				this.lonField = value;
			}
		}

		// Token: 0x17000A92 RID: 2706
		// (get) Token: 0x06001C20 RID: 7200 RVA: 0x0004D602 File Offset: 0x0004B802
		// (set) Token: 0x06001C21 RID: 7201 RVA: 0x0004D60A File Offset: 0x0004B80A
		[global::System.Xml.Serialization.XmlAttribute]
		public int rev
		{
			get
			{
				return this.revField;
			}
			set
			{
				this.revField = value;
			}
		}

		// Token: 0x040015F4 RID: 5620
		private int latField;

		// Token: 0x040015F5 RID: 5621
		private int lonField;

		// Token: 0x040015F6 RID: 5622
		private int revField;
	}
}
