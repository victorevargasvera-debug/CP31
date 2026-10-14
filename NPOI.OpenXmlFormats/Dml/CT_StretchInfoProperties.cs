using System;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Dml
{
	// Token: 0x02000328 RID: 808
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_StretchInfoProperties
	{
		// Token: 0x0600204F RID: 8271 RVA: 0x00055DE4 File Offset: 0x00053FE4
		public static global::NPOI.OpenXmlFormats.Dml.CT_StretchInfoProperties Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Dml.CT_StretchInfoProperties ct_StretchInfoProperties = new global::NPOI.OpenXmlFormats.Dml.CT_StretchInfoProperties();
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "fillRect")
				{
					ct_StretchInfoProperties.fillRect = global::NPOI.OpenXmlFormats.Dml.CT_RelativeRect.Parse(xmlNode, namespaceManager);
				}
			}
			return ct_StretchInfoProperties;
		}

		// Token: 0x06002050 RID: 8272 RVA: 0x00055E64 File Offset: 0x00054064
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<a:{0}", nodeName));
			sw.Write(">");
			if (this.fillRect != null)
			{
				this.fillRect.Write(sw, "fillRect");
			}
			sw.Write(string.Format("</a:{0}>", nodeName));
		}

		// Token: 0x06002051 RID: 8273 RVA: 0x00055EB7 File Offset: 0x000540B7
		public global::NPOI.OpenXmlFormats.Dml.CT_RelativeRect AddNewFillRect()
		{
			this.fillRectField = new global::NPOI.OpenXmlFormats.Dml.CT_RelativeRect();
			return this.fillRectField;
		}

		// Token: 0x17000C2C RID: 3116
		// (get) Token: 0x06002052 RID: 8274 RVA: 0x00055ECA File Offset: 0x000540CA
		// (set) Token: 0x06002053 RID: 8275 RVA: 0x00055ED2 File Offset: 0x000540D2
		[global::System.Xml.Serialization.XmlElement(Order = 0)]
		public global::NPOI.OpenXmlFormats.Dml.CT_RelativeRect fillRect
		{
			get
			{
				return this.fillRectField;
			}
			set
			{
				this.fillRectField = value;
			}
		}

		// Token: 0x040018E0 RID: 6368
		private global::NPOI.OpenXmlFormats.Dml.CT_RelativeRect fillRectField;
	}
}
