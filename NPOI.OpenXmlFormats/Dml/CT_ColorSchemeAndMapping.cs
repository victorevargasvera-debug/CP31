using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Dml
{
	// Token: 0x02000346 RID: 838
	[global::System.Diagnostics.DebuggerStepThrough]
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_ColorSchemeAndMapping
	{
		// Token: 0x06002106 RID: 8454 RVA: 0x00057040 File Offset: 0x00055240
		public static global::NPOI.OpenXmlFormats.Dml.CT_ColorSchemeAndMapping Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Dml.CT_ColorSchemeAndMapping ct_ColorSchemeAndMapping = new global::NPOI.OpenXmlFormats.Dml.CT_ColorSchemeAndMapping();
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "clrScheme")
				{
					ct_ColorSchemeAndMapping.clrScheme = global::NPOI.OpenXmlFormats.Dml.CT_ColorScheme.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "clrMap")
				{
					ct_ColorSchemeAndMapping.clrMap = global::NPOI.OpenXmlFormats.Dml.CT_ColorMapping.Parse(xmlNode, namespaceManager);
				}
			}
			return ct_ColorSchemeAndMapping;
		}

		// Token: 0x06002107 RID: 8455 RVA: 0x000570E0 File Offset: 0x000552E0
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<a:{0}", nodeName));
			sw.Write(">");
			if (this.clrScheme != null)
			{
				this.clrScheme.Write(sw, "clrScheme");
			}
			if (this.clrMap != null)
			{
				this.clrMap.Write(sw, "clrMap");
			}
			sw.Write(string.Format("</a:{0}>", nodeName));
		}

		// Token: 0x17000C73 RID: 3187
		// (get) Token: 0x06002109 RID: 8457 RVA: 0x0005714C File Offset: 0x0005534C
		// (set) Token: 0x0600210A RID: 8458 RVA: 0x00057154 File Offset: 0x00055354
		[global::System.Xml.Serialization.XmlElement(Order = 0)]
		public global::NPOI.OpenXmlFormats.Dml.CT_ColorScheme clrScheme
		{
			get
			{
				return this.clrSchemeField;
			}
			set
			{
				this.clrSchemeField = value;
			}
		}

		// Token: 0x17000C74 RID: 3188
		// (get) Token: 0x0600210B RID: 8459 RVA: 0x0005715D File Offset: 0x0005535D
		// (set) Token: 0x0600210C RID: 8460 RVA: 0x00057165 File Offset: 0x00055365
		[global::System.Xml.Serialization.XmlElement(Order = 1)]
		public global::NPOI.OpenXmlFormats.Dml.CT_ColorMapping clrMap
		{
			get
			{
				return this.clrMapField;
			}
			set
			{
				this.clrMapField = value;
			}
		}

		// Token: 0x0400196D RID: 6509
		private global::NPOI.OpenXmlFormats.Dml.CT_ColorScheme clrSchemeField;

		// Token: 0x0400196E RID: 6510
		private global::NPOI.OpenXmlFormats.Dml.CT_ColorMapping clrMapField;
	}
}
