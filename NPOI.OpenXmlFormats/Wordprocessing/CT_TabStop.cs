using System;
using System.IO;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Wordprocessing
{
	// Token: 0x020000ED RID: 237
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_TabStop
	{
		// Token: 0x060006A6 RID: 1702 RVA: 0x00015498 File Offset: 0x00013698
		public static global::NPOI.OpenXmlFormats.Wordprocessing.CT_TabStop Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Wordprocessing.CT_TabStop ct_TabStop = new global::NPOI.OpenXmlFormats.Wordprocessing.CT_TabStop();
			if (node.Attributes["w:val"] != null)
			{
				ct_TabStop.val = (global::NPOI.OpenXmlFormats.Wordprocessing.ST_TabJc)global::System.Enum.Parse(typeof(global::NPOI.OpenXmlFormats.Wordprocessing.ST_TabJc), node.Attributes["w:val"].Value);
			}
			if (node.Attributes["w:leader"] != null)
			{
				ct_TabStop.leader = (global::NPOI.OpenXmlFormats.Wordprocessing.ST_TabTlc)global::System.Enum.Parse(typeof(global::NPOI.OpenXmlFormats.Wordprocessing.ST_TabTlc), node.Attributes["w:leader"].Value);
			}
			ct_TabStop.pos = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["w:pos"]);
			return ct_TabStop;
		}

		// Token: 0x060006A7 RID: 1703 RVA: 0x00015550 File Offset: 0x00013750
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<w:{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "w:val", this.val.ToString());
			if (this.leader != global::NPOI.OpenXmlFormats.Wordprocessing.ST_TabTlc.none)
			{
				global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "w:leader", this.leader.ToString());
			}
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "w:pos", this.pos, true);
			sw.Write("/>");
		}

		// Token: 0x17000238 RID: 568
		// (get) Token: 0x060006A8 RID: 1704 RVA: 0x000155D1 File Offset: 0x000137D1
		// (set) Token: 0x060006A9 RID: 1705 RVA: 0x000155D9 File Offset: 0x000137D9
		[global::System.Xml.Serialization.XmlAttribute(Form = global::System.Xml.Schema.XmlSchemaForm.Qualified)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.ST_TabJc val
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

		// Token: 0x17000239 RID: 569
		// (get) Token: 0x060006AA RID: 1706 RVA: 0x000155E2 File Offset: 0x000137E2
		// (set) Token: 0x060006AB RID: 1707 RVA: 0x000155EA File Offset: 0x000137EA
		[global::System.Xml.Serialization.XmlAttribute(Form = global::System.Xml.Schema.XmlSchemaForm.Qualified)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.ST_TabTlc leader
		{
			get
			{
				return this.leaderField;
			}
			set
			{
				this.leaderField = value;
			}
		}

		// Token: 0x1700023A RID: 570
		// (get) Token: 0x060006AC RID: 1708 RVA: 0x000155F3 File Offset: 0x000137F3
		// (set) Token: 0x060006AD RID: 1709 RVA: 0x000155FB File Offset: 0x000137FB
		[global::System.Xml.Serialization.XmlIgnore]
		public bool leaderSpecified
		{
			get
			{
				return this.leaderFieldSpecified;
			}
			set
			{
				this.leaderFieldSpecified = value;
			}
		}

		// Token: 0x1700023B RID: 571
		// (get) Token: 0x060006AE RID: 1710 RVA: 0x00015604 File Offset: 0x00013804
		// (set) Token: 0x060006AF RID: 1711 RVA: 0x0001560C File Offset: 0x0001380C
		[global::System.Xml.Serialization.XmlAttribute(Form = global::System.Xml.Schema.XmlSchemaForm.Qualified, DataType = "integer")]
		public string pos
		{
			get
			{
				return this.posField;
			}
			set
			{
				this.posField = value;
			}
		}

		// Token: 0x040005BF RID: 1471
		private global::NPOI.OpenXmlFormats.Wordprocessing.ST_TabJc valField;

		// Token: 0x040005C0 RID: 1472
		private global::NPOI.OpenXmlFormats.Wordprocessing.ST_TabTlc leaderField;

		// Token: 0x040005C1 RID: 1473
		private bool leaderFieldSpecified;

		// Token: 0x040005C2 RID: 1474
		private string posField;
	}
}
