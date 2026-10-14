using System;
using System.IO;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Wordprocessing
{
	// Token: 0x020000CE RID: 206
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_LineNumber
	{
		// Token: 0x060005DD RID: 1501 RVA: 0x000101B4 File Offset: 0x0000E3B4
		public static global::NPOI.OpenXmlFormats.Wordprocessing.CT_LineNumber Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Wordprocessing.CT_LineNumber ct_LineNumber = new global::NPOI.OpenXmlFormats.Wordprocessing.CT_LineNumber();
			ct_LineNumber.countBy = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["w:countBy"]);
			ct_LineNumber.start = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["w:start"]);
			ct_LineNumber.distance = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadULong(node.Attributes["w:distance"]);
			if (node.Attributes["w:restart"] != null)
			{
				ct_LineNumber.restart = (global::NPOI.OpenXmlFormats.Wordprocessing.ST_LineNumberRestart)global::System.Enum.Parse(typeof(global::NPOI.OpenXmlFormats.Wordprocessing.ST_LineNumberRestart), node.Attributes["w:restart"].Value);
			}
			return ct_LineNumber;
		}

		// Token: 0x060005DE RID: 1502 RVA: 0x00010260 File Offset: 0x0000E460
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<w:{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "w:countBy", this.countBy);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "w:start", this.start);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "w:distance", this.distance);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "w:restart", this.restart.ToString());
			sw.Write(">");
			sw.Write(string.Format("</w:{0}>", nodeName));
		}

		// Token: 0x17000203 RID: 515
		// (get) Token: 0x060005DF RID: 1503 RVA: 0x000102EE File Offset: 0x0000E4EE
		// (set) Token: 0x060005E0 RID: 1504 RVA: 0x000102F6 File Offset: 0x0000E4F6
		[global::System.Xml.Serialization.XmlAttribute(Form = global::System.Xml.Schema.XmlSchemaForm.Qualified, DataType = "integer")]
		public string countBy
		{
			get
			{
				return this.countByField;
			}
			set
			{
				this.countByField = value;
			}
		}

		// Token: 0x17000204 RID: 516
		// (get) Token: 0x060005E1 RID: 1505 RVA: 0x000102FF File Offset: 0x0000E4FF
		// (set) Token: 0x060005E2 RID: 1506 RVA: 0x00010307 File Offset: 0x0000E507
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

		// Token: 0x17000205 RID: 517
		// (get) Token: 0x060005E3 RID: 1507 RVA: 0x00010310 File Offset: 0x0000E510
		// (set) Token: 0x060005E4 RID: 1508 RVA: 0x00010318 File Offset: 0x0000E518
		[global::System.Xml.Serialization.XmlAttribute(Form = global::System.Xml.Schema.XmlSchemaForm.Qualified)]
		public ulong distance
		{
			get
			{
				return this.distanceField;
			}
			set
			{
				this.distanceField = value;
			}
		}

		// Token: 0x17000206 RID: 518
		// (get) Token: 0x060005E5 RID: 1509 RVA: 0x00010321 File Offset: 0x0000E521
		// (set) Token: 0x060005E6 RID: 1510 RVA: 0x00010329 File Offset: 0x0000E529
		[global::System.Xml.Serialization.XmlIgnore]
		public bool distanceSpecified
		{
			get
			{
				return this.distanceFieldSpecified;
			}
			set
			{
				this.distanceFieldSpecified = value;
			}
		}

		// Token: 0x17000207 RID: 519
		// (get) Token: 0x060005E7 RID: 1511 RVA: 0x00010332 File Offset: 0x0000E532
		// (set) Token: 0x060005E8 RID: 1512 RVA: 0x0001033A File Offset: 0x0000E53A
		[global::System.Xml.Serialization.XmlAttribute(Form = global::System.Xml.Schema.XmlSchemaForm.Qualified)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.ST_LineNumberRestart restart
		{
			get
			{
				return this.restartField;
			}
			set
			{
				this.restartField = value;
			}
		}

		// Token: 0x17000208 RID: 520
		// (get) Token: 0x060005E9 RID: 1513 RVA: 0x00010343 File Offset: 0x0000E543
		// (set) Token: 0x060005EA RID: 1514 RVA: 0x0001034B File Offset: 0x0000E54B
		[global::System.Xml.Serialization.XmlIgnore]
		public bool restartSpecified
		{
			get
			{
				return this.restartFieldSpecified;
			}
			set
			{
				this.restartFieldSpecified = value;
			}
		}

		// Token: 0x040004F1 RID: 1265
		private string countByField;

		// Token: 0x040004F2 RID: 1266
		private string startField;

		// Token: 0x040004F3 RID: 1267
		private ulong distanceField;

		// Token: 0x040004F4 RID: 1268
		private bool distanceFieldSpecified;

		// Token: 0x040004F5 RID: 1269
		private global::NPOI.OpenXmlFormats.Wordprocessing.ST_LineNumberRestart restartField;

		// Token: 0x040004F6 RID: 1270
		private bool restartFieldSpecified;
	}
}
