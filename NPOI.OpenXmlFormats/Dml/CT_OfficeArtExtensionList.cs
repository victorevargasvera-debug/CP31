using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Dml
{
	// Token: 0x020002BE RID: 702
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_OfficeArtExtensionList
	{
		// Token: 0x06001BDA RID: 7130 RVA: 0x0004CC28 File Offset: 0x0004AE28
		public CT_OfficeArtExtensionList()
		{
			this.extField = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.CT_OfficeArtExtension>();
		}

		// Token: 0x06001BDB RID: 7131 RVA: 0x0004CC3C File Offset: 0x0004AE3C
		public static global::NPOI.OpenXmlFormats.Dml.CT_OfficeArtExtensionList Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Dml.CT_OfficeArtExtensionList ct_OfficeArtExtensionList = new global::NPOI.OpenXmlFormats.Dml.CT_OfficeArtExtensionList();
			ct_OfficeArtExtensionList.ext = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.CT_OfficeArtExtension>();
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "ext")
				{
					ct_OfficeArtExtensionList.ext.Add(global::NPOI.OpenXmlFormats.Dml.CT_OfficeArtExtension.Parse(xmlNode, namespaceManager));
				}
			}
			return ct_OfficeArtExtensionList;
		}

		// Token: 0x06001BDC RID: 7132 RVA: 0x0004CCCC File Offset: 0x0004AECC
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<a:{0}", nodeName));
			sw.Write(">");
			if (this.ext != null)
			{
				foreach (global::NPOI.OpenXmlFormats.Dml.CT_OfficeArtExtension ct_OfficeArtExtension in this.ext)
				{
					ct_OfficeArtExtension.Write(sw, "ext");
				}
			}
			sw.Write(string.Format("</a:{0}>", nodeName));
		}

		// Token: 0x17000A7B RID: 2683
		// (get) Token: 0x06001BDD RID: 7133 RVA: 0x0004CD58 File Offset: 0x0004AF58
		// (set) Token: 0x06001BDE RID: 7134 RVA: 0x0004CD60 File Offset: 0x0004AF60
		[global::System.Xml.Serialization.XmlElement("ext", Order = 0)]
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.CT_OfficeArtExtension> ext
		{
			get
			{
				return this.extField;
			}
			set
			{
				this.extField = value;
			}
		}

		// Token: 0x040015DF RID: 5599
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.CT_OfficeArtExtension> extField;
	}
}
