using System;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Spreadsheet
{
	// Token: 0x02000577 RID: 1399
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
	[global::System.Serializable]
	public class CT_SheetDimension
	{
		// Token: 0x170016D4 RID: 5844
		// (get) Token: 0x06003CE1 RID: 15585 RVA: 0x00093EC0 File Offset: 0x000920C0
		// (set) Token: 0x06003CE2 RID: 15586 RVA: 0x00093EC8 File Offset: 0x000920C8
		[global::System.Xml.Serialization.XmlAttribute("ref")]
		public string @ref
		{
			get
			{
				return this.refField;
			}
			set
			{
				this.refField = value;
			}
		}

		// Token: 0x06003CE3 RID: 15587 RVA: 0x00093ED1 File Offset: 0x000920D1
		public static global::NPOI.OpenXmlFormats.Spreadsheet.CT_SheetDimension Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			return new global::NPOI.OpenXmlFormats.Spreadsheet.CT_SheetDimension
			{
				@ref = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["ref"])
			};
		}

		// Token: 0x06003CE4 RID: 15588 RVA: 0x00093EF8 File Offset: 0x000920F8
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "ref", this.@ref);
			sw.Write("/>");
		}

		// Token: 0x040026ED RID: 9965
		private string refField;
	}
}
