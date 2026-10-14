using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Dml
{
	// Token: 0x0200028A RID: 650
	[global::System.Diagnostics.DebuggerStepThrough]
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_LineEndProperties
	{
		// Token: 0x06001AD1 RID: 6865 RVA: 0x00048D98 File Offset: 0x00046F98
		public static global::NPOI.OpenXmlFormats.Dml.CT_LineEndProperties Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Dml.CT_LineEndProperties ct_LineEndProperties = new global::NPOI.OpenXmlFormats.Dml.CT_LineEndProperties();
			if (node.Attributes["type"] != null)
			{
				ct_LineEndProperties.type = (global::NPOI.OpenXmlFormats.Dml.ST_LineEndType)global::System.Enum.Parse(typeof(global::NPOI.OpenXmlFormats.Dml.ST_LineEndType), node.Attributes["type"].Value);
			}
			if (node.Attributes["w"] != null)
			{
				ct_LineEndProperties.w = (global::NPOI.OpenXmlFormats.Dml.ST_LineEndWidth)global::System.Enum.Parse(typeof(global::NPOI.OpenXmlFormats.Dml.ST_LineEndWidth), node.Attributes["w"].Value);
			}
			if (node.Attributes["len"] != null)
			{
				ct_LineEndProperties.len = (global::NPOI.OpenXmlFormats.Dml.ST_LineEndLength)global::System.Enum.Parse(typeof(global::NPOI.OpenXmlFormats.Dml.ST_LineEndLength), node.Attributes["len"].Value);
			}
			return ct_LineEndProperties;
		}

		// Token: 0x06001AD2 RID: 6866 RVA: 0x00048E74 File Offset: 0x00047074
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<a:{0}", nodeName));
			if (this.type != global::NPOI.OpenXmlFormats.Dml.ST_LineEndType.none)
			{
				global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "type", this.type.ToString());
			}
			if (this.w != global::NPOI.OpenXmlFormats.Dml.ST_LineEndWidth.sm)
			{
				global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "w", this.w.ToString());
			}
			if (this.len != global::NPOI.OpenXmlFormats.Dml.ST_LineEndLength.sm)
			{
				global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "len", this.len.ToString());
			}
			sw.Write("/>");
		}

		// Token: 0x17000A1F RID: 2591
		// (get) Token: 0x06001AD3 RID: 6867 RVA: 0x00048F12 File Offset: 0x00047112
		// (set) Token: 0x06001AD4 RID: 6868 RVA: 0x00048F1A File Offset: 0x0004711A
		[global::System.Xml.Serialization.XmlAttribute]
		public global::NPOI.OpenXmlFormats.Dml.ST_LineEndType type
		{
			get
			{
				return this.typeField;
			}
			set
			{
				this.typeField = value;
			}
		}

		// Token: 0x17000A20 RID: 2592
		// (get) Token: 0x06001AD5 RID: 6869 RVA: 0x00048F23 File Offset: 0x00047123
		// (set) Token: 0x06001AD6 RID: 6870 RVA: 0x00048F2B File Offset: 0x0004712B
		[global::System.Xml.Serialization.XmlAttribute]
		public global::NPOI.OpenXmlFormats.Dml.ST_LineEndWidth w
		{
			get
			{
				return this.wField;
			}
			set
			{
				this.wField = value;
			}
		}

		// Token: 0x17000A21 RID: 2593
		// (get) Token: 0x06001AD7 RID: 6871 RVA: 0x00048F34 File Offset: 0x00047134
		// (set) Token: 0x06001AD8 RID: 6872 RVA: 0x00048F3C File Offset: 0x0004713C
		[global::System.Xml.Serialization.XmlAttribute]
		public global::NPOI.OpenXmlFormats.Dml.ST_LineEndLength len
		{
			get
			{
				return this.lenField;
			}
			set
			{
				this.lenField = value;
			}
		}

		// Token: 0x040013F5 RID: 5109
		private global::NPOI.OpenXmlFormats.Dml.ST_LineEndType typeField;

		// Token: 0x040013F6 RID: 5110
		private global::NPOI.OpenXmlFormats.Dml.ST_LineEndWidth wField;

		// Token: 0x040013F7 RID: 5111
		private global::NPOI.OpenXmlFormats.Dml.ST_LineEndLength lenField;
	}
}
