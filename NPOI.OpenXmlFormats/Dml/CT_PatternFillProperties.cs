using System;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Dml
{
	// Token: 0x02000329 RID: 809
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_PatternFillProperties
	{
		// Token: 0x06002055 RID: 8277 RVA: 0x00055EDC File Offset: 0x000540DC
		public static global::NPOI.OpenXmlFormats.Dml.CT_PatternFillProperties Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Dml.CT_PatternFillProperties ct_PatternFillProperties = new global::NPOI.OpenXmlFormats.Dml.CT_PatternFillProperties();
			if (node.Attributes["prst"] != null)
			{
				ct_PatternFillProperties.prst = (global::NPOI.OpenXmlFormats.Dml.ST_PresetPatternVal)global::System.Enum.Parse(typeof(global::NPOI.OpenXmlFormats.Dml.ST_PresetPatternVal), node.Attributes["prst"].Value);
			}
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "fgClr")
				{
					ct_PatternFillProperties.fgClr = global::NPOI.OpenXmlFormats.Dml.CT_Color.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "bgClr")
				{
					ct_PatternFillProperties.bgClr = global::NPOI.OpenXmlFormats.Dml.CT_Color.Parse(xmlNode, namespaceManager);
				}
			}
			return ct_PatternFillProperties;
		}

		// Token: 0x06002056 RID: 8278 RVA: 0x00055FBC File Offset: 0x000541BC
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<a:{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "prst", this.prst.ToString());
			sw.Write(">");
			if (this.fgClr != null)
			{
				this.fgClr.Write(sw, "fgClr");
			}
			if (this.bgClr != null)
			{
				this.bgClr.Write(sw, "bgClr");
			}
			sw.Write(string.Format("</a:{0}>", nodeName));
		}

		// Token: 0x17000C2D RID: 3117
		// (get) Token: 0x06002058 RID: 8280 RVA: 0x00056047 File Offset: 0x00054247
		// (set) Token: 0x06002059 RID: 8281 RVA: 0x0005604F File Offset: 0x0005424F
		[global::System.Xml.Serialization.XmlElement(Order = 0)]
		public global::NPOI.OpenXmlFormats.Dml.CT_Color fgClr
		{
			get
			{
				return this.fgClrField;
			}
			set
			{
				this.fgClrField = value;
			}
		}

		// Token: 0x17000C2E RID: 3118
		// (get) Token: 0x0600205A RID: 8282 RVA: 0x00056058 File Offset: 0x00054258
		// (set) Token: 0x0600205B RID: 8283 RVA: 0x00056060 File Offset: 0x00054260
		[global::System.Xml.Serialization.XmlElement(Order = 1)]
		public global::NPOI.OpenXmlFormats.Dml.CT_Color bgClr
		{
			get
			{
				return this.bgClrField;
			}
			set
			{
				this.bgClrField = value;
			}
		}

		// Token: 0x17000C2F RID: 3119
		// (get) Token: 0x0600205C RID: 8284 RVA: 0x00056069 File Offset: 0x00054269
		// (set) Token: 0x0600205D RID: 8285 RVA: 0x00056071 File Offset: 0x00054271
		[global::System.Xml.Serialization.XmlAttribute]
		public global::NPOI.OpenXmlFormats.Dml.ST_PresetPatternVal prst
		{
			get
			{
				return this.prstField;
			}
			set
			{
				this.prstField = value;
			}
		}

		// Token: 0x17000C30 RID: 3120
		// (get) Token: 0x0600205E RID: 8286 RVA: 0x0005607A File Offset: 0x0005427A
		// (set) Token: 0x0600205F RID: 8287 RVA: 0x00056082 File Offset: 0x00054282
		[global::System.Xml.Serialization.XmlIgnore]
		public bool prstSpecified
		{
			get
			{
				return this.prstFieldSpecified;
			}
			set
			{
				this.prstFieldSpecified = value;
			}
		}

		// Token: 0x040018E1 RID: 6369
		private global::NPOI.OpenXmlFormats.Dml.CT_Color fgClrField;

		// Token: 0x040018E2 RID: 6370
		private global::NPOI.OpenXmlFormats.Dml.CT_Color bgClrField;

		// Token: 0x040018E3 RID: 6371
		private global::NPOI.OpenXmlFormats.Dml.ST_PresetPatternVal prstField;

		// Token: 0x040018E4 RID: 6372
		private bool prstFieldSpecified;
	}
}
