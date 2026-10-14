using System;
using System.IO;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Wordprocessing
{
	// Token: 0x0200005F RID: 95
	[global::System.Xml.Serialization.XmlInclude(typeof(global::NPOI.OpenXmlFormats.Wordprocessing.CT_BookmarkRange))]
	[global::System.Xml.Serialization.XmlInclude(typeof(global::NPOI.OpenXmlFormats.Wordprocessing.CT_Bookmark))]
	[global::System.Xml.Serialization.XmlInclude(typeof(global::NPOI.OpenXmlFormats.Wordprocessing.CT_MoveBookmark))]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_MarkupRange : global::NPOI.OpenXmlFormats.Wordprocessing.CT_Markup
	{
		// Token: 0x060002E4 RID: 740 RVA: 0x00005DAC File Offset: 0x00003FAC
		public new static global::NPOI.OpenXmlFormats.Wordprocessing.CT_MarkupRange Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Wordprocessing.CT_MarkupRange ct_MarkupRange = new global::NPOI.OpenXmlFormats.Wordprocessing.CT_MarkupRange();
			if (node.Attributes["w:displacedByCustomXml"] != null)
			{
				ct_MarkupRange.displacedByCustomXml = (global::NPOI.OpenXmlFormats.Wordprocessing.ST_DisplacedByCustomXml)global::System.Enum.Parse(typeof(global::NPOI.OpenXmlFormats.Wordprocessing.ST_DisplacedByCustomXml), node.Attributes["w:displacedByCustomXml"].Value);
			}
			ct_MarkupRange.id = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["w:id"]);
			return ct_MarkupRange;
		}

		// Token: 0x060002E5 RID: 741 RVA: 0x00005E24 File Offset: 0x00004024
		internal new void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<w:{0}", nodeName));
			if (this.displacedByCustomXml != global::NPOI.OpenXmlFormats.Wordprocessing.ST_DisplacedByCustomXml.next)
			{
				global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "w:displacedByCustomXml", this.displacedByCustomXml.ToString());
			}
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "w:id", base.id);
			sw.Write("/>");
		}

		// Token: 0x170000F3 RID: 243
		// (get) Token: 0x060002E6 RID: 742 RVA: 0x00005E85 File Offset: 0x00004085
		// (set) Token: 0x060002E7 RID: 743 RVA: 0x00005E8D File Offset: 0x0000408D
		[global::System.Xml.Serialization.XmlAttribute(Form = global::System.Xml.Schema.XmlSchemaForm.Qualified)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.ST_DisplacedByCustomXml displacedByCustomXml
		{
			get
			{
				return this.displacedByCustomXmlField;
			}
			set
			{
				this.displacedByCustomXmlField = value;
			}
		}

		// Token: 0x170000F4 RID: 244
		// (get) Token: 0x060002E8 RID: 744 RVA: 0x00005E96 File Offset: 0x00004096
		// (set) Token: 0x060002E9 RID: 745 RVA: 0x00005E9E File Offset: 0x0000409E
		[global::System.Xml.Serialization.XmlIgnore]
		public bool displacedByCustomXmlSpecified
		{
			get
			{
				return this.displacedByCustomXmlFieldSpecified;
			}
			set
			{
				this.displacedByCustomXmlFieldSpecified = value;
			}
		}

		// Token: 0x040001E7 RID: 487
		private global::NPOI.OpenXmlFormats.Wordprocessing.ST_DisplacedByCustomXml displacedByCustomXmlField;

		// Token: 0x040001E8 RID: 488
		private bool displacedByCustomXmlFieldSpecified;
	}
}
