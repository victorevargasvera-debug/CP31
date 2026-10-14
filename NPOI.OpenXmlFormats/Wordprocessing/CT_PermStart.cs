using System;
using System.IO;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Wordprocessing
{
	// Token: 0x020000C1 RID: 193
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_PermStart : global::NPOI.OpenXmlFormats.Wordprocessing.CT_Perm
	{
		// Token: 0x170001DC RID: 476
		// (get) Token: 0x0600057A RID: 1402 RVA: 0x0000F52D File Offset: 0x0000D72D
		// (set) Token: 0x0600057B RID: 1403 RVA: 0x0000F535 File Offset: 0x0000D735
		[global::System.Xml.Serialization.XmlAttribute(Form = global::System.Xml.Schema.XmlSchemaForm.Qualified)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.ST_EdGrp edGrp
		{
			get
			{
				return this.edGrpField;
			}
			set
			{
				this.edGrpField = value;
			}
		}

		// Token: 0x170001DD RID: 477
		// (get) Token: 0x0600057C RID: 1404 RVA: 0x0000F53E File Offset: 0x0000D73E
		// (set) Token: 0x0600057D RID: 1405 RVA: 0x0000F546 File Offset: 0x0000D746
		[global::System.Xml.Serialization.XmlIgnore]
		public bool edGrpSpecified
		{
			get
			{
				return this.edGrpFieldSpecified;
			}
			set
			{
				this.edGrpFieldSpecified = value;
			}
		}

		// Token: 0x170001DE RID: 478
		// (get) Token: 0x0600057E RID: 1406 RVA: 0x0000F54F File Offset: 0x0000D74F
		// (set) Token: 0x0600057F RID: 1407 RVA: 0x0000F557 File Offset: 0x0000D757
		[global::System.Xml.Serialization.XmlAttribute(Form = global::System.Xml.Schema.XmlSchemaForm.Qualified)]
		public string ed
		{
			get
			{
				return this.edField;
			}
			set
			{
				this.edField = value;
			}
		}

		// Token: 0x170001DF RID: 479
		// (get) Token: 0x06000580 RID: 1408 RVA: 0x0000F560 File Offset: 0x0000D760
		// (set) Token: 0x06000581 RID: 1409 RVA: 0x0000F568 File Offset: 0x0000D768
		[global::System.Xml.Serialization.XmlAttribute(Form = global::System.Xml.Schema.XmlSchemaForm.Qualified, DataType = "integer")]
		public string colFirst
		{
			get
			{
				return this.colFirstField;
			}
			set
			{
				this.colFirstField = value;
			}
		}

		// Token: 0x170001E0 RID: 480
		// (get) Token: 0x06000582 RID: 1410 RVA: 0x0000F571 File Offset: 0x0000D771
		// (set) Token: 0x06000583 RID: 1411 RVA: 0x0000F579 File Offset: 0x0000D779
		[global::System.Xml.Serialization.XmlAttribute(Form = global::System.Xml.Schema.XmlSchemaForm.Qualified, DataType = "integer")]
		public string colLast
		{
			get
			{
				return this.colLastField;
			}
			set
			{
				this.colLastField = value;
			}
		}

		// Token: 0x06000584 RID: 1412 RVA: 0x0000F584 File Offset: 0x0000D784
		public new static global::NPOI.OpenXmlFormats.Wordprocessing.CT_PermStart Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Wordprocessing.CT_PermStart ct_PermStart = new global::NPOI.OpenXmlFormats.Wordprocessing.CT_PermStart();
			if (node.Attributes["w:edGrp"] != null)
			{
				ct_PermStart.edGrp = (global::NPOI.OpenXmlFormats.Wordprocessing.ST_EdGrp)global::System.Enum.Parse(typeof(global::NPOI.OpenXmlFormats.Wordprocessing.ST_EdGrp), node.Attributes["w:edGrp"].Value);
			}
			ct_PermStart.ed = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["w:ed"]);
			ct_PermStart.colFirst = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["w:colFirst"]);
			ct_PermStart.colLast = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["w:colLast"]);
			ct_PermStart.id = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["w:id"]);
			if (node.Attributes["w:displacedByCustomXml"] != null)
			{
				ct_PermStart.displacedByCustomXml = (global::NPOI.OpenXmlFormats.Wordprocessing.ST_DisplacedByCustomXml)global::System.Enum.Parse(typeof(global::NPOI.OpenXmlFormats.Wordprocessing.ST_DisplacedByCustomXml), node.Attributes["w:displacedByCustomXml"].Value);
			}
			return ct_PermStart;
		}

		// Token: 0x06000585 RID: 1413 RVA: 0x0000F68C File Offset: 0x0000D88C
		internal new void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<w:{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "w:edGrp", this.edGrp.ToString());
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "w:ed", this.ed);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "w:colFirst", this.colFirst);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "w:colLast", this.colLast);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "w:id", base.id);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "w:displacedByCustomXml", base.displacedByCustomXml.ToString());
			sw.Write(">");
			sw.Write(string.Format("</w:{0}>", nodeName));
		}

		// Token: 0x040004AF RID: 1199
		private global::NPOI.OpenXmlFormats.Wordprocessing.ST_EdGrp edGrpField;

		// Token: 0x040004B0 RID: 1200
		private bool edGrpFieldSpecified;

		// Token: 0x040004B1 RID: 1201
		private string edField;

		// Token: 0x040004B2 RID: 1202
		private string colFirstField;

		// Token: 0x040004B3 RID: 1203
		private string colLastField;
	}
}
