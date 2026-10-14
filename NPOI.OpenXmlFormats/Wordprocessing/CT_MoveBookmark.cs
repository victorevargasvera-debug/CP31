using System;
using System.IO;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Wordprocessing
{
	// Token: 0x02000059 RID: 89
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_MoveBookmark : global::NPOI.OpenXmlFormats.Wordprocessing.CT_Bookmark
	{
		// Token: 0x060002B8 RID: 696 RVA: 0x0000499C File Offset: 0x00002B9C
		public new static global::NPOI.OpenXmlFormats.Wordprocessing.CT_MoveBookmark Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Wordprocessing.CT_MoveBookmark ct_MoveBookmark = new global::NPOI.OpenXmlFormats.Wordprocessing.CT_MoveBookmark();
			ct_MoveBookmark.author = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["w:author"]);
			ct_MoveBookmark.date = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["w:date"]);
			ct_MoveBookmark.name = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["w:name"]);
			ct_MoveBookmark.colFirst = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["w:colFirst"]);
			ct_MoveBookmark.colLast = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["w:colLast"]);
			if (node.Attributes["w:displacedByCustomXml"] != null)
			{
				ct_MoveBookmark.displacedByCustomXml = (global::NPOI.OpenXmlFormats.Wordprocessing.ST_DisplacedByCustomXml)global::System.Enum.Parse(typeof(global::NPOI.OpenXmlFormats.Wordprocessing.ST_DisplacedByCustomXml), node.Attributes["w:displacedByCustomXml"].Value);
			}
			ct_MoveBookmark.id = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["w:id"]);
			return ct_MoveBookmark;
		}

		// Token: 0x060002B9 RID: 697 RVA: 0x00004A98 File Offset: 0x00002C98
		internal new void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<w:{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "w:author", this.author);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "w:date", this.date);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "w:name", base.name);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "w:colFirst", base.colFirst);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "w:colLast", base.colLast);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "w:displacedByCustomXml", base.displacedByCustomXml.ToString());
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "w:id", base.id);
			sw.Write("/>");
		}

		// Token: 0x170000E9 RID: 233
		// (get) Token: 0x060002BA RID: 698 RVA: 0x00004B46 File Offset: 0x00002D46
		// (set) Token: 0x060002BB RID: 699 RVA: 0x00004B4E File Offset: 0x00002D4E
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

		// Token: 0x170000EA RID: 234
		// (get) Token: 0x060002BC RID: 700 RVA: 0x00004B57 File Offset: 0x00002D57
		// (set) Token: 0x060002BD RID: 701 RVA: 0x00004B5F File Offset: 0x00002D5F
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

		// Token: 0x040001BE RID: 446
		private string authorField;

		// Token: 0x040001BF RID: 447
		private string dateField;
	}
}
