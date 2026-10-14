using System;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Spreadsheet
{
	// Token: 0x02000502 RID: 1282
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
	[global::System.Serializable]
	public class CT_RgbColor
	{
		// Token: 0x06003697 RID: 13975 RVA: 0x000881BE File Offset: 0x000863BE
		public static global::NPOI.OpenXmlFormats.Spreadsheet.CT_RgbColor Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			return new global::NPOI.OpenXmlFormats.Spreadsheet.CT_RgbColor
			{
				rgb = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBytes(node.Attributes["rgb"])
			};
		}

		// Token: 0x06003698 RID: 13976 RVA: 0x000881E5 File Offset: 0x000863E5
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "rgb", this.rgb);
			sw.Write("/>");
		}

		// Token: 0x170014A6 RID: 5286
		// (get) Token: 0x06003699 RID: 13977 RVA: 0x00088214 File Offset: 0x00086414
		// (set) Token: 0x0600369A RID: 13978 RVA: 0x0008821C File Offset: 0x0008641C
		[global::System.Xml.Serialization.XmlAttribute(DataType = "hexBinary")]
		public byte[] rgb
		{
			get
			{
				return this.rgbField;
			}
			set
			{
				this.rgbField = value;
			}
		}

		// Token: 0x040023E8 RID: 9192
		private byte[] rgbField;
	}
}
