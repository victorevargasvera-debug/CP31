using System;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Dml
{
	// Token: 0x02000323 RID: 803
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_PathShadeProperties
	{
		// Token: 0x06002016 RID: 8214 RVA: 0x00055754 File Offset: 0x00053954
		public static global::NPOI.OpenXmlFormats.Dml.CT_PathShadeProperties Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Dml.CT_PathShadeProperties ct_PathShadeProperties = new global::NPOI.OpenXmlFormats.Dml.CT_PathShadeProperties();
			if (node.Attributes["path"] != null)
			{
				ct_PathShadeProperties.path = (global::NPOI.OpenXmlFormats.Dml.ST_PathShadeType)global::System.Enum.Parse(typeof(global::NPOI.OpenXmlFormats.Dml.ST_PathShadeType), node.Attributes["path"].Value);
			}
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "fillToRect")
				{
					ct_PathShadeProperties.fillToRect = global::NPOI.OpenXmlFormats.Dml.CT_RelativeRect.Parse(xmlNode, namespaceManager);
				}
			}
			return ct_PathShadeProperties;
		}

		// Token: 0x06002017 RID: 8215 RVA: 0x00055814 File Offset: 0x00053A14
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<a:{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "path", this.path.ToString());
			sw.Write(">");
			if (this.fillToRect != null)
			{
				this.fillToRect.Write(sw, "fillToRect");
			}
			sw.Write(string.Format("</a:{0}>", nodeName));
		}

		// Token: 0x17000C15 RID: 3093
		// (get) Token: 0x06002018 RID: 8216 RVA: 0x00055886 File Offset: 0x00053A86
		// (set) Token: 0x06002019 RID: 8217 RVA: 0x0005588E File Offset: 0x00053A8E
		[global::System.Xml.Serialization.XmlElement(Order = 0)]
		public global::NPOI.OpenXmlFormats.Dml.CT_RelativeRect fillToRect
		{
			get
			{
				return this.fillToRectField;
			}
			set
			{
				this.fillToRectField = value;
			}
		}

		// Token: 0x17000C16 RID: 3094
		// (get) Token: 0x0600201A RID: 8218 RVA: 0x00055897 File Offset: 0x00053A97
		// (set) Token: 0x0600201B RID: 8219 RVA: 0x0005589F File Offset: 0x00053A9F
		[global::System.Xml.Serialization.XmlAttribute]
		public global::NPOI.OpenXmlFormats.Dml.ST_PathShadeType path
		{
			get
			{
				return this.pathField;
			}
			set
			{
				this.pathField = value;
			}
		}

		// Token: 0x17000C17 RID: 3095
		// (get) Token: 0x0600201C RID: 8220 RVA: 0x000558A8 File Offset: 0x00053AA8
		// (set) Token: 0x0600201D RID: 8221 RVA: 0x000558B0 File Offset: 0x00053AB0
		[global::System.Xml.Serialization.XmlIgnore]
		public bool pathSpecified
		{
			get
			{
				return this.pathFieldSpecified;
			}
			set
			{
				this.pathFieldSpecified = value;
			}
		}

		// Token: 0x040018C0 RID: 6336
		private global::NPOI.OpenXmlFormats.Dml.CT_RelativeRect fillToRectField;

		// Token: 0x040018C1 RID: 6337
		private global::NPOI.OpenXmlFormats.Dml.ST_PathShadeType pathField;

		// Token: 0x040018C2 RID: 6338
		private bool pathFieldSpecified;
	}
}
