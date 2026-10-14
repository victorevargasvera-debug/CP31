using System;
using System.IO;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Wordprocessing
{
	// Token: 0x0200005D RID: 93
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
	public class CT_TrackChange : global::NPOI.OpenXmlFormats.Wordprocessing.CT_Markup
	{
		// Token: 0x170000EF RID: 239
		// (get) Token: 0x060002D6 RID: 726 RVA: 0x00005C40 File Offset: 0x00003E40
		// (set) Token: 0x060002D7 RID: 727 RVA: 0x00005C48 File Offset: 0x00003E48
		[global::System.Xml.Serialization.XmlAttribute(Form = global::System.Xml.Schema.XmlSchemaForm.Qualified)]
		public string author
		{
			get
			{
				return this.authorField;
			}
			set
			{
				this.authorField = value;
			}
		}

		// Token: 0x170000F0 RID: 240
		// (get) Token: 0x060002D8 RID: 728 RVA: 0x00005C51 File Offset: 0x00003E51
		// (set) Token: 0x060002D9 RID: 729 RVA: 0x00005C59 File Offset: 0x00003E59
		[global::System.Xml.Serialization.XmlAttribute(Form = global::System.Xml.Schema.XmlSchemaForm.Qualified)]
		public string date
		{
			get
			{
				return this.dateField;
			}
			set
			{
				this.dateField = value;
			}
		}

		// Token: 0x170000F1 RID: 241
		// (get) Token: 0x060002DA RID: 730 RVA: 0x00005C62 File Offset: 0x00003E62
		// (set) Token: 0x060002DB RID: 731 RVA: 0x00005C6A File Offset: 0x00003E6A
		[global::System.Xml.Serialization.XmlIgnore]
		public bool dateSpecified
		{
			get
			{
				return this.dateFieldSpecified;
			}
			set
			{
				this.dateFieldSpecified = value;
			}
		}

		// Token: 0x060002DC RID: 732 RVA: 0x00005C74 File Offset: 0x00003E74
		public new static global::NPOI.OpenXmlFormats.Wordprocessing.CT_TrackChange Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			return new global::NPOI.OpenXmlFormats.Wordprocessing.CT_TrackChange
			{
				author = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["w:author"]),
				date = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["w:date"]),
				id = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["w:id"])
			};
		}

		// Token: 0x060002DD RID: 733 RVA: 0x00005CDC File Offset: 0x00003EDC
		internal new void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<w:{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "w:author", this.author, true);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "w:date", this.date);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "w:id", base.id, true);
			sw.Write("/>");
		}

		// Token: 0x040001E3 RID: 483
		private string authorField;

		// Token: 0x040001E4 RID: 484
		private string dateField;

		// Token: 0x040001E5 RID: 485
		private bool dateFieldSpecified;
	}
}
