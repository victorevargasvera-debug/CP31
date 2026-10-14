using System;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Wordprocessing
{
	// Token: 0x0200005E RID: 94
	[global::System.Xml.Serialization.XmlInclude(typeof(global::NPOI.OpenXmlFormats.Wordprocessing.CT_TblGridChange))]
	[global::System.Xml.Serialization.XmlInclude(typeof(global::NPOI.OpenXmlFormats.Wordprocessing.CT_MarkupRange))]
	[global::System.Xml.Serialization.XmlInclude(typeof(global::NPOI.OpenXmlFormats.Wordprocessing.CT_BookmarkRange))]
	[global::System.Xml.Serialization.XmlInclude(typeof(global::NPOI.OpenXmlFormats.Wordprocessing.CT_Bookmark))]
	[global::System.Xml.Serialization.XmlInclude(typeof(global::NPOI.OpenXmlFormats.Wordprocessing.CT_MoveBookmark))]
	[global::System.Xml.Serialization.XmlInclude(typeof(global::NPOI.OpenXmlFormats.Wordprocessing.CT_TrackChange))]
	[global::System.Xml.Serialization.XmlInclude(typeof(global::NPOI.OpenXmlFormats.Wordprocessing.CT_RunTrackChange))]
	[global::System.Xml.Serialization.XmlInclude(typeof(global::NPOI.OpenXmlFormats.Wordprocessing.CT_RPrChange))]
	[global::System.Xml.Serialization.XmlInclude(typeof(global::NPOI.OpenXmlFormats.Wordprocessing.CT_ParaRPrChange))]
	[global::System.Xml.Serialization.XmlInclude(typeof(global::NPOI.OpenXmlFormats.Wordprocessing.CT_PPrChange))]
	[global::System.Xml.Serialization.XmlInclude(typeof(global::NPOI.OpenXmlFormats.Wordprocessing.CT_SectPrChange))]
	[global::System.Xml.Serialization.XmlInclude(typeof(global::NPOI.OpenXmlFormats.Wordprocessing.CT_TblPrChange))]
	[global::System.Xml.Serialization.XmlInclude(typeof(global::NPOI.OpenXmlFormats.Wordprocessing.CT_TrPrChange))]
	[global::System.Xml.Serialization.XmlInclude(typeof(global::NPOI.OpenXmlFormats.Wordprocessing.CT_TcPrChange))]
	[global::System.Xml.Serialization.XmlInclude(typeof(global::NPOI.OpenXmlFormats.Wordprocessing.CT_TblPrExChange))]
	[global::System.Xml.Serialization.XmlInclude(typeof(global::NPOI.OpenXmlFormats.Wordprocessing.CT_TrackChangeNumbering))]
	[global::System.Xml.Serialization.XmlInclude(typeof(global::NPOI.OpenXmlFormats.Wordprocessing.CT_Comment))]
	[global::System.Xml.Serialization.XmlInclude(typeof(global::NPOI.OpenXmlFormats.Wordprocessing.CT_TrackChangeRange))]
	[global::System.Xml.Serialization.XmlInclude(typeof(global::NPOI.OpenXmlFormats.Wordprocessing.CT_CellMergeTrackChange))]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_Markup
	{
		// Token: 0x060002DF RID: 735 RVA: 0x00005D42 File Offset: 0x00003F42
		public static global::NPOI.OpenXmlFormats.Wordprocessing.CT_Markup Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			return new global::NPOI.OpenXmlFormats.Wordprocessing.CT_Markup
			{
				id = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["w:id"])
			};
		}

		// Token: 0x060002E0 RID: 736 RVA: 0x00005D69 File Offset: 0x00003F69
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<w:{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "w:id", this.id);
			sw.Write("/>");
		}

		// Token: 0x170000F2 RID: 242
		// (get) Token: 0x060002E1 RID: 737 RVA: 0x00005D98 File Offset: 0x00003F98
		// (set) Token: 0x060002E2 RID: 738 RVA: 0x00005DA0 File Offset: 0x00003FA0
		public string id
		{
			get
			{
				return this.idField;
			}
			set
			{
				this.idField = value;
			}
		}

		// Token: 0x040001E6 RID: 486
		private string idField;
	}
}
