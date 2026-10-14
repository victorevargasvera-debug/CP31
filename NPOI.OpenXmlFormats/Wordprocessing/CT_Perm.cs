using System;
using System.IO;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Wordprocessing
{
	// Token: 0x020000C0 RID: 192
	[global::System.Xml.Serialization.XmlInclude(typeof(global::NPOI.OpenXmlFormats.Wordprocessing.CT_PermStart))]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_Perm
	{
		// Token: 0x06000571 RID: 1393 RVA: 0x0000F418 File Offset: 0x0000D618
		public static global::NPOI.OpenXmlFormats.Wordprocessing.CT_Perm Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Wordprocessing.CT_Perm ct_Perm = new global::NPOI.OpenXmlFormats.Wordprocessing.CT_Perm();
			ct_Perm.id = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["r:id"]);
			if (node.Attributes["w:displacedByCustomXml"] != null)
			{
				ct_Perm.displacedByCustomXml = (global::NPOI.OpenXmlFormats.Wordprocessing.ST_DisplacedByCustomXml)global::System.Enum.Parse(typeof(global::NPOI.OpenXmlFormats.Wordprocessing.ST_DisplacedByCustomXml), node.Attributes["w:displacedByCustomXml"].Value);
			}
			return ct_Perm;
		}

		// Token: 0x06000572 RID: 1394 RVA: 0x0000F490 File Offset: 0x0000D690
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<w:{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "r:id", this.id);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "w:displacedByCustomXml", this.displacedByCustomXml.ToString());
			sw.Write(">");
			sw.Write(string.Format("</w:{0}>", nodeName));
		}

		// Token: 0x170001D9 RID: 473
		// (get) Token: 0x06000573 RID: 1395 RVA: 0x0000F4FA File Offset: 0x0000D6FA
		// (set) Token: 0x06000574 RID: 1396 RVA: 0x0000F502 File Offset: 0x0000D702
		[global::System.Xml.Serialization.XmlAttribute(Form = global::System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://schemas.openxmlformats.org/officeDocument/2006/relationships")]
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

		// Token: 0x170001DA RID: 474
		// (get) Token: 0x06000575 RID: 1397 RVA: 0x0000F50B File Offset: 0x0000D70B
		// (set) Token: 0x06000576 RID: 1398 RVA: 0x0000F513 File Offset: 0x0000D713
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

		// Token: 0x170001DB RID: 475
		// (get) Token: 0x06000577 RID: 1399 RVA: 0x0000F51C File Offset: 0x0000D71C
		// (set) Token: 0x06000578 RID: 1400 RVA: 0x0000F524 File Offset: 0x0000D724
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

		// Token: 0x040004AC RID: 1196
		private string idField;

		// Token: 0x040004AD RID: 1197
		private global::NPOI.OpenXmlFormats.Wordprocessing.ST_DisplacedByCustomXml displacedByCustomXmlField;

		// Token: 0x040004AE RID: 1198
		private bool displacedByCustomXmlFieldSpecified;
	}
}
