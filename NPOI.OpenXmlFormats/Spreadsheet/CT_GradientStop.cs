using System;
using System.IO;
using System.Xml;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Spreadsheet
{
	// Token: 0x02000543 RID: 1347
	public class CT_GradientStop
	{
		// Token: 0x06003ADC RID: 15068 RVA: 0x00091764 File Offset: 0x0008F964
		public static global::NPOI.OpenXmlFormats.Spreadsheet.CT_GradientStop Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_GradientStop ct_GradientStop = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_GradientStop();
			ct_GradientStop.positionField = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadInt(node.Attributes["position"]);
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "color")
				{
					ct_GradientStop.colorField = global::NPOI.OpenXmlFormats.Spreadsheet.CT_Color.Parse(xmlNode, namespaceManager);
					break;
				}
			}
			return ct_GradientStop;
		}

		// Token: 0x06003ADD RID: 15069 RVA: 0x00091800 File Offset: 0x0008FA00
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "position", this.positionField, true);
			sw.Write(">");
			if (this.colorField != null)
			{
				this.colorField.Write(sw, "color");
			}
			sw.Write(string.Format("</{0}>", nodeName));
		}

		// Token: 0x040025B8 RID: 9656
		private int positionField;

		// Token: 0x040025B9 RID: 9657
		private global::NPOI.OpenXmlFormats.Spreadsheet.CT_Color colorField;
	}
}
