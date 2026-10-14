using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Dml
{
	// Token: 0x0200033F RID: 831
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_GradientStopList
	{
		// Token: 0x060020BB RID: 8379 RVA: 0x00056524 File Offset: 0x00054724
		public static global::NPOI.OpenXmlFormats.Dml.CT_GradientStopList Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Dml.CT_GradientStopList ct_GradientStopList = new global::NPOI.OpenXmlFormats.Dml.CT_GradientStopList();
			ct_GradientStopList.gs = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.CT_GradientStop>();
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "gs")
				{
					ct_GradientStopList.gs.Add(global::NPOI.OpenXmlFormats.Dml.CT_GradientStop.Parse(xmlNode, namespaceManager));
				}
			}
			return ct_GradientStopList;
		}

		// Token: 0x060020BC RID: 8380 RVA: 0x000565B4 File Offset: 0x000547B4
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<a:{0}", nodeName));
			sw.Write(">");
			if (this.gs != null)
			{
				foreach (global::NPOI.OpenXmlFormats.Dml.CT_GradientStop ct_GradientStop in this.gs)
				{
					ct_GradientStop.Write(sw, "gs");
				}
			}
			sw.Write(string.Format("</a:{0}>", nodeName));
		}

		// Token: 0x060020BD RID: 8381 RVA: 0x00056640 File Offset: 0x00054840
		public CT_GradientStopList()
		{
			this.gsField = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.CT_GradientStop>();
		}

		// Token: 0x17000C54 RID: 3156
		// (get) Token: 0x060020BE RID: 8382 RVA: 0x00056653 File Offset: 0x00054853
		// (set) Token: 0x060020BF RID: 8383 RVA: 0x0005665B File Offset: 0x0005485B
		[global::System.Xml.Serialization.XmlElement("gs", Order = 0)]
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.CT_GradientStop> gs
		{
			get
			{
				return this.gsField;
			}
			set
			{
				this.gsField = value;
			}
		}

		// Token: 0x0400194E RID: 6478
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.CT_GradientStop> gsField;
	}
}
