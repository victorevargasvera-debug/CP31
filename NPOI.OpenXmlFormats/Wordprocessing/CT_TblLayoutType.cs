using System;
using System.IO;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Wordprocessing
{
	// Token: 0x020001B5 RID: 437
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_TblLayoutType
	{
		// Token: 0x06001097 RID: 4247 RVA: 0x00035F44 File Offset: 0x00034144
		public static global::NPOI.OpenXmlFormats.Wordprocessing.CT_TblLayoutType Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Wordprocessing.CT_TblLayoutType ct_TblLayoutType = new global::NPOI.OpenXmlFormats.Wordprocessing.CT_TblLayoutType();
			if (node.Attributes["w:type"] != null)
			{
				ct_TblLayoutType.type = (global::NPOI.OpenXmlFormats.Wordprocessing.ST_TblLayoutType)global::System.Enum.Parse(typeof(global::NPOI.OpenXmlFormats.Wordprocessing.ST_TblLayoutType), node.Attributes["w:type"].Value);
			}
			return ct_TblLayoutType;
		}

		// Token: 0x06001098 RID: 4248 RVA: 0x00035FA0 File Offset: 0x000341A0
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<w:{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "w:type", this.type.ToString());
			sw.Write("/>");
		}

		// Token: 0x170005EE RID: 1518
		// (get) Token: 0x06001099 RID: 4249 RVA: 0x00035FE8 File Offset: 0x000341E8
		// (set) Token: 0x0600109A RID: 4250 RVA: 0x00035FF0 File Offset: 0x000341F0
		[global::System.Xml.Serialization.XmlAttribute(Form = global::System.Xml.Schema.XmlSchemaForm.Qualified)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.ST_TblLayoutType type
		{
			get
			{
				return this.typeField;
			}
			set
			{
				this.typeField = value;
			}
		}

		// Token: 0x170005EF RID: 1519
		// (get) Token: 0x0600109B RID: 4251 RVA: 0x00035FF9 File Offset: 0x000341F9
		// (set) Token: 0x0600109C RID: 4252 RVA: 0x00036001 File Offset: 0x00034201
		[global::System.Xml.Serialization.XmlIgnore]
		public bool typeSpecified
		{
			get
			{
				return this.typeFieldSpecified;
			}
			set
			{
				this.typeFieldSpecified = value;
			}
		}

		// Token: 0x04000D29 RID: 3369
		private global::NPOI.OpenXmlFormats.Wordprocessing.ST_TblLayoutType typeField;

		// Token: 0x04000D2A RID: 3370
		private bool typeFieldSpecified;
	}
}
