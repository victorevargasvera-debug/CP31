using System;
using System.IO;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Shared
{
	// Token: 0x02000640 RID: 1600
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/officeDocument/2006/math")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/officeDocument/2006/math", IsNullable = true)]
	[global::System.Serializable]
	public class CT_Shp
	{
		// Token: 0x06004514 RID: 17684 RVA: 0x000A3E80 File Offset: 0x000A2080
		public static global::NPOI.OpenXmlFormats.Shared.CT_Shp Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Shared.CT_Shp ct_Shp = new global::NPOI.OpenXmlFormats.Shared.CT_Shp();
			if (node.Attributes["m:val"] != null)
			{
				ct_Shp.val = (global::NPOI.OpenXmlFormats.Shared.ST_Shp)global::System.Enum.Parse(typeof(global::NPOI.OpenXmlFormats.Shared.ST_Shp), node.Attributes["m:val"].Value);
			}
			return ct_Shp;
		}

		// Token: 0x06004515 RID: 17685 RVA: 0x000A3EDC File Offset: 0x000A20DC
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<m:{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "m:val", this.val.ToString());
			sw.Write(">");
			sw.Write(string.Format("</m:{0}>", nodeName));
		}

		// Token: 0x17001A00 RID: 6656
		// (get) Token: 0x06004516 RID: 17686 RVA: 0x000A3F35 File Offset: 0x000A2135
		// (set) Token: 0x06004517 RID: 17687 RVA: 0x000A3F3D File Offset: 0x000A213D
		[global::System.Xml.Serialization.XmlAttribute(Form = global::System.Xml.Schema.XmlSchemaForm.Qualified)]
		public global::NPOI.OpenXmlFormats.Shared.ST_Shp val
		{
			get
			{
				return this.valField;
			}
			set
			{
				this.valField = value;
			}
		}

		// Token: 0x04002B48 RID: 11080
		private global::NPOI.OpenXmlFormats.Shared.ST_Shp valField;
	}
}
