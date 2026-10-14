using System;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Wordprocessing
{
	// Token: 0x020001C8 RID: 456
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_VMerge
	{
		// Token: 0x06001160 RID: 4448 RVA: 0x00039B9F File Offset: 0x00037D9F
		public CT_VMerge()
		{
			this.valField = global::NPOI.OpenXmlFormats.Wordprocessing.ST_Merge.@continue;
		}

		// Token: 0x06001161 RID: 4449 RVA: 0x00039BB0 File Offset: 0x00037DB0
		public static global::NPOI.OpenXmlFormats.Wordprocessing.CT_VMerge Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Wordprocessing.CT_VMerge ct_VMerge = new global::NPOI.OpenXmlFormats.Wordprocessing.CT_VMerge();
			if (node.Attributes["w:val"] != null)
			{
				ct_VMerge.valField = (global::NPOI.OpenXmlFormats.Wordprocessing.ST_Merge)global::System.Enum.Parse(typeof(global::NPOI.OpenXmlFormats.Wordprocessing.ST_Merge), node.Attributes["w:val"].Value);
				ct_VMerge.valFieldSpecified = true;
			}
			return ct_VMerge;
		}

		// Token: 0x06001162 RID: 4450 RVA: 0x00039C14 File Offset: 0x00037E14
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<w:{0}", nodeName));
			if (this.valField != global::NPOI.OpenXmlFormats.Wordprocessing.ST_Merge.@continue || this.valFieldSpecified)
			{
				global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "w:val", this.valField.ToString());
			}
			sw.Write("/>");
		}

		// Token: 0x17000623 RID: 1571
		// (get) Token: 0x06001163 RID: 4451 RVA: 0x00039C69 File Offset: 0x00037E69
		// (set) Token: 0x06001164 RID: 4452 RVA: 0x00039C71 File Offset: 0x00037E71
		public global::NPOI.OpenXmlFormats.Wordprocessing.ST_Merge val
		{
			get
			{
				return this.valField;
			}
			set
			{
				this.valField = value;
				this.valFieldSpecified = true;
			}
		}

		// Token: 0x17000624 RID: 1572
		// (get) Token: 0x06001165 RID: 4453 RVA: 0x00039C81 File Offset: 0x00037E81
		// (set) Token: 0x06001166 RID: 4454 RVA: 0x00039C89 File Offset: 0x00037E89
		[global::System.Xml.Serialization.XmlIgnore]
		public bool valSpecified
		{
			get
			{
				return this.valFieldSpecified;
			}
			set
			{
				this.valFieldSpecified = value;
			}
		}

		// Token: 0x04000D86 RID: 3462
		private global::NPOI.OpenXmlFormats.Wordprocessing.ST_Merge valField;

		// Token: 0x04000D87 RID: 3463
		private bool valFieldSpecified;
	}
}
