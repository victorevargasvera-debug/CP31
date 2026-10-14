using System;
using System.IO;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Wordprocessing
{
	// Token: 0x020000CB RID: 203
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_PageNumber
	{
		// Token: 0x060005C7 RID: 1479 RVA: 0x0000FF18 File Offset: 0x0000E118
		public static global::NPOI.OpenXmlFormats.Wordprocessing.CT_PageNumber Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Wordprocessing.CT_PageNumber ct_PageNumber = new global::NPOI.OpenXmlFormats.Wordprocessing.CT_PageNumber();
			if (node.Attributes["w:fmt"] != null)
			{
				ct_PageNumber.fmt = (global::NPOI.OpenXmlFormats.Wordprocessing.ST_NumberFormat)global::System.Enum.Parse(typeof(global::NPOI.OpenXmlFormats.Wordprocessing.ST_NumberFormat), node.Attributes["w:fmt"].Value);
			}
			ct_PageNumber.start = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["w:start"]);
			ct_PageNumber.chapStyle = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["w:chapStyle"]);
			if (node.Attributes["w:chapSep"] != null)
			{
				ct_PageNumber.chapSep = (global::NPOI.OpenXmlFormats.Wordprocessing.ST_ChapterSep)global::System.Enum.Parse(typeof(global::NPOI.OpenXmlFormats.Wordprocessing.ST_ChapterSep), node.Attributes["w:chapSep"].Value);
			}
			return ct_PageNumber;
		}

		// Token: 0x060005C8 RID: 1480 RVA: 0x0000FFEC File Offset: 0x0000E1EC
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<w:{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "w:fmt", this.fmt.ToString());
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "w:start", this.start);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "w:chapStyle", this.chapStyle);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "w:chapSep", this.chapSep.ToString());
			sw.Write("/>");
		}

		// Token: 0x170001FB RID: 507
		// (get) Token: 0x060005C9 RID: 1481 RVA: 0x00010075 File Offset: 0x0000E275
		// (set) Token: 0x060005CA RID: 1482 RVA: 0x0001007D File Offset: 0x0000E27D
		[global::System.Xml.Serialization.XmlAttribute(Form = global::System.Xml.Schema.XmlSchemaForm.Qualified)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.ST_NumberFormat fmt
		{
			get
			{
				return this.fmtField;
			}
			set
			{
				this.fmtField = value;
			}
		}

		// Token: 0x170001FC RID: 508
		// (get) Token: 0x060005CB RID: 1483 RVA: 0x00010086 File Offset: 0x0000E286
		// (set) Token: 0x060005CC RID: 1484 RVA: 0x0001008E File Offset: 0x0000E28E
		[global::System.Xml.Serialization.XmlIgnore]
		public bool fmtSpecified
		{
			get
			{
				return this.fmtFieldSpecified;
			}
			set
			{
				this.fmtFieldSpecified = value;
			}
		}

		// Token: 0x170001FD RID: 509
		// (get) Token: 0x060005CD RID: 1485 RVA: 0x00010097 File Offset: 0x0000E297
		// (set) Token: 0x060005CE RID: 1486 RVA: 0x0001009F File Offset: 0x0000E29F
		[global::System.Xml.Serialization.XmlAttribute(Form = global::System.Xml.Schema.XmlSchemaForm.Qualified, DataType = "integer")]
		public string start
		{
			get
			{
				return this.startField;
			}
			set
			{
				this.startField = value;
			}
		}

		// Token: 0x170001FE RID: 510
		// (get) Token: 0x060005CF RID: 1487 RVA: 0x000100A8 File Offset: 0x0000E2A8
		// (set) Token: 0x060005D0 RID: 1488 RVA: 0x000100B0 File Offset: 0x0000E2B0
		[global::System.Xml.Serialization.XmlAttribute(Form = global::System.Xml.Schema.XmlSchemaForm.Qualified, DataType = "integer")]
		public string chapStyle
		{
			get
			{
				return this.chapStyleField;
			}
			set
			{
				this.chapStyleField = value;
			}
		}

		// Token: 0x170001FF RID: 511
		// (get) Token: 0x060005D1 RID: 1489 RVA: 0x000100B9 File Offset: 0x0000E2B9
		// (set) Token: 0x060005D2 RID: 1490 RVA: 0x000100C1 File Offset: 0x0000E2C1
		[global::System.Xml.Serialization.XmlAttribute(Form = global::System.Xml.Schema.XmlSchemaForm.Qualified)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.ST_ChapterSep chapSep
		{
			get
			{
				return this.chapSepField;
			}
			set
			{
				this.chapSepField = value;
			}
		}

		// Token: 0x17000200 RID: 512
		// (get) Token: 0x060005D3 RID: 1491 RVA: 0x000100CA File Offset: 0x0000E2CA
		// (set) Token: 0x060005D4 RID: 1492 RVA: 0x000100D2 File Offset: 0x0000E2D2
		[global::System.Xml.Serialization.XmlIgnore]
		public bool chapSepSpecified
		{
			get
			{
				return this.chapSepFieldSpecified;
			}
			set
			{
				this.chapSepFieldSpecified = value;
			}
		}

		// Token: 0x040004E3 RID: 1251
		private global::NPOI.OpenXmlFormats.Wordprocessing.ST_NumberFormat fmtField;

		// Token: 0x040004E4 RID: 1252
		private bool fmtFieldSpecified;

		// Token: 0x040004E5 RID: 1253
		private string startField;

		// Token: 0x040004E6 RID: 1254
		private string chapStyleField;

		// Token: 0x040004E7 RID: 1255
		private global::NPOI.OpenXmlFormats.Wordprocessing.ST_ChapterSep chapSepField;

		// Token: 0x040004E8 RID: 1256
		private bool chapSepFieldSpecified;
	}
}
