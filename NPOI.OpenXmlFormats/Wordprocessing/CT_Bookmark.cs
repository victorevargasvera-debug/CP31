using System;
using System.IO;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Wordprocessing
{
	// Token: 0x02000058 RID: 88
	[global::System.Xml.Serialization.XmlInclude(typeof(global::NPOI.OpenXmlFormats.Wordprocessing.CT_MoveBookmark))]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_Bookmark : global::NPOI.OpenXmlFormats.Wordprocessing.CT_BookmarkRange
	{
		// Token: 0x060002B3 RID: 691 RVA: 0x00004824 File Offset: 0x00002A24
		public new static global::NPOI.OpenXmlFormats.Wordprocessing.CT_Bookmark Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Wordprocessing.CT_Bookmark ct_Bookmark = new global::NPOI.OpenXmlFormats.Wordprocessing.CT_Bookmark();
			ct_Bookmark.name = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["w:name"]);
			ct_Bookmark.colFirst = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["w:colFirst"]);
			ct_Bookmark.colLast = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["w:colLast"]);
			if (node.Attributes["w:displacedByCustomXml"] != null)
			{
				ct_Bookmark.displacedByCustomXml = (global::NPOI.OpenXmlFormats.Wordprocessing.ST_DisplacedByCustomXml)global::System.Enum.Parse(typeof(global::NPOI.OpenXmlFormats.Wordprocessing.ST_DisplacedByCustomXml), node.Attributes["w:displacedByCustomXml"].Value);
			}
			ct_Bookmark.id = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["w:id"]);
			return ct_Bookmark;
		}

		// Token: 0x060002B4 RID: 692 RVA: 0x000048EC File Offset: 0x00002AEC
		internal new void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<w:{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "w:id", base.id);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "w:name", this.name);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "w:colFirst", base.colFirst);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "w:colLast", base.colLast);
			if (base.displacedByCustomXml != global::NPOI.OpenXmlFormats.Wordprocessing.ST_DisplacedByCustomXml.next)
			{
				global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "w:displacedByCustomXml", base.displacedByCustomXml.ToString());
			}
			sw.Write("/>");
		}

		// Token: 0x170000E8 RID: 232
		// (get) Token: 0x060002B5 RID: 693 RVA: 0x00004980 File Offset: 0x00002B80
		// (set) Token: 0x060002B6 RID: 694 RVA: 0x00004988 File Offset: 0x00002B88
		[global::System.Xml.Serialization.XmlAttribute(Form = global::System.Xml.Schema.XmlSchemaForm.Qualified)]
		public string name
		{
			get
			{
				return this.nameField;
			}
			set
			{
				this.nameField = value;
			}
		}

		// Token: 0x040001BD RID: 445
		private string nameField;
	}
}
