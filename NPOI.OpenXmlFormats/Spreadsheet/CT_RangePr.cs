using System;
using System.ComponentModel;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Spreadsheet
{
	// Token: 0x02000497 RID: 1175
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main", IsNullable = true)]
	public class CT_RangePr
	{
		// Token: 0x06002FDA RID: 12250 RVA: 0x00077EB4 File Offset: 0x000760B4
		public static global::NPOI.OpenXmlFormats.Spreadsheet.CT_RangePr Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_RangePr ct_RangePr = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_RangePr();
			if (node.Attributes["autoStart"] != null)
			{
				ct_RangePr.autoStart = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["autoStart"]);
			}
			if (node.Attributes["autoEnd"] != null)
			{
				ct_RangePr.autoEnd = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["autoEnd"]);
			}
			if (node.Attributes["groupBy"] != null)
			{
				ct_RangePr.groupBy = (global::NPOI.OpenXmlFormats.Spreadsheet.ST_GroupBy)global::System.Enum.Parse(typeof(global::NPOI.OpenXmlFormats.Spreadsheet.ST_GroupBy), node.Attributes["groupBy"].Value);
			}
			if (node.Attributes["startNum"] != null)
			{
				ct_RangePr.startNum = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadDouble(node.Attributes["startNum"]);
			}
			if (node.Attributes["endNum"] != null)
			{
				ct_RangePr.endNum = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadDouble(node.Attributes["endNum"]);
			}
			if (node.Attributes["startDate"] != null)
			{
				ct_RangePr.startDate = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadDateTime(node.Attributes["startDate"]);
			}
			if (node.Attributes["endDate"] != null)
			{
				ct_RangePr.endDate = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadDateTime(node.Attributes["endDate"]);
			}
			if (node.Attributes["groupInterval"] != null)
			{
				ct_RangePr.groupInterval = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadDouble(node.Attributes["groupInterval"]);
			}
			return ct_RangePr;
		}

		// Token: 0x06002FDB RID: 12251 RVA: 0x0007804C File Offset: 0x0007624C
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "autoStart", this.autoStart);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "autoEnd", this.autoEnd);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "groupBy", this.groupBy.ToString());
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "startNum", this.startNum);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "endNum", this.endNum);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "startDate", this.startDate);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "endDate", this.endDate);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "groupInterval", this.groupInterval);
			sw.Write(">");
			sw.Write(string.Format("</{0}>", nodeName));
		}

		// Token: 0x06002FDC RID: 12252 RVA: 0x0007811C File Offset: 0x0007631C
		public CT_RangePr()
		{
			this.autoStartField = true;
			this.autoEndField = true;
			this.groupByField = global::NPOI.OpenXmlFormats.Spreadsheet.ST_GroupBy.range;
			this.groupIntervalField = 1.0;
		}

		// Token: 0x1700120E RID: 4622
		// (get) Token: 0x06002FDD RID: 12253 RVA: 0x00078148 File Offset: 0x00076348
		// (set) Token: 0x06002FDE RID: 12254 RVA: 0x00078150 File Offset: 0x00076350
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(true)]
		public bool autoStart
		{
			get
			{
				return this.autoStartField;
			}
			set
			{
				this.autoStartField = value;
			}
		}

		// Token: 0x1700120F RID: 4623
		// (get) Token: 0x06002FDF RID: 12255 RVA: 0x00078159 File Offset: 0x00076359
		// (set) Token: 0x06002FE0 RID: 12256 RVA: 0x00078161 File Offset: 0x00076361
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(true)]
		public bool autoEnd
		{
			get
			{
				return this.autoEndField;
			}
			set
			{
				this.autoEndField = value;
			}
		}

		// Token: 0x17001210 RID: 4624
		// (get) Token: 0x06002FE1 RID: 12257 RVA: 0x0007816A File Offset: 0x0007636A
		// (set) Token: 0x06002FE2 RID: 12258 RVA: 0x00078172 File Offset: 0x00076372
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(global::NPOI.OpenXmlFormats.Spreadsheet.ST_GroupBy.range)]
		public global::NPOI.OpenXmlFormats.Spreadsheet.ST_GroupBy groupBy
		{
			get
			{
				return this.groupByField;
			}
			set
			{
				this.groupByField = value;
			}
		}

		// Token: 0x17001211 RID: 4625
		// (get) Token: 0x06002FE3 RID: 12259 RVA: 0x0007817B File Offset: 0x0007637B
		// (set) Token: 0x06002FE4 RID: 12260 RVA: 0x00078183 File Offset: 0x00076383
		[global::System.Xml.Serialization.XmlAttribute]
		public double startNum
		{
			get
			{
				return this.startNumField;
			}
			set
			{
				this.startNumField = value;
			}
		}

		// Token: 0x17001212 RID: 4626
		// (get) Token: 0x06002FE5 RID: 12261 RVA: 0x0007818C File Offset: 0x0007638C
		// (set) Token: 0x06002FE6 RID: 12262 RVA: 0x00078194 File Offset: 0x00076394
		[global::System.Xml.Serialization.XmlIgnore]
		public bool startNumSpecified
		{
			get
			{
				return this.startNumFieldSpecified;
			}
			set
			{
				this.startNumFieldSpecified = value;
			}
		}

		// Token: 0x17001213 RID: 4627
		// (get) Token: 0x06002FE7 RID: 12263 RVA: 0x0007819D File Offset: 0x0007639D
		// (set) Token: 0x06002FE8 RID: 12264 RVA: 0x000781A5 File Offset: 0x000763A5
		[global::System.Xml.Serialization.XmlAttribute]
		public double endNum
		{
			get
			{
				return this.endNumField;
			}
			set
			{
				this.endNumField = value;
			}
		}

		// Token: 0x17001214 RID: 4628
		// (get) Token: 0x06002FE9 RID: 12265 RVA: 0x000781AE File Offset: 0x000763AE
		// (set) Token: 0x06002FEA RID: 12266 RVA: 0x000781B6 File Offset: 0x000763B6
		[global::System.Xml.Serialization.XmlIgnore]
		public bool endNumSpecified
		{
			get
			{
				return this.endNumFieldSpecified;
			}
			set
			{
				this.endNumFieldSpecified = value;
			}
		}

		// Token: 0x17001215 RID: 4629
		// (get) Token: 0x06002FEB RID: 12267 RVA: 0x000781BF File Offset: 0x000763BF
		// (set) Token: 0x06002FEC RID: 12268 RVA: 0x000781C7 File Offset: 0x000763C7
		[global::System.Xml.Serialization.XmlAttribute]
		public global::System.DateTime? startDate
		{
			get
			{
				return this.startDateField;
			}
			set
			{
				this.startDateField = value;
			}
		}

		// Token: 0x17001216 RID: 4630
		// (get) Token: 0x06002FED RID: 12269 RVA: 0x000781D0 File Offset: 0x000763D0
		// (set) Token: 0x06002FEE RID: 12270 RVA: 0x000781D8 File Offset: 0x000763D8
		[global::System.Xml.Serialization.XmlIgnore]
		public bool startDateSpecified
		{
			get
			{
				return this.startDateFieldSpecified;
			}
			set
			{
				this.startDateFieldSpecified = value;
			}
		}

		// Token: 0x17001217 RID: 4631
		// (get) Token: 0x06002FEF RID: 12271 RVA: 0x000781E1 File Offset: 0x000763E1
		// (set) Token: 0x06002FF0 RID: 12272 RVA: 0x000781E9 File Offset: 0x000763E9
		[global::System.Xml.Serialization.XmlAttribute]
		public global::System.DateTime? endDate
		{
			get
			{
				return this.endDateField;
			}
			set
			{
				this.endDateField = value;
			}
		}

		// Token: 0x17001218 RID: 4632
		// (get) Token: 0x06002FF1 RID: 12273 RVA: 0x000781F2 File Offset: 0x000763F2
		// (set) Token: 0x06002FF2 RID: 12274 RVA: 0x000781FA File Offset: 0x000763FA
		[global::System.Xml.Serialization.XmlIgnore]
		public bool endDateSpecified
		{
			get
			{
				return this.endDateFieldSpecified;
			}
			set
			{
				this.endDateFieldSpecified = value;
			}
		}

		// Token: 0x17001219 RID: 4633
		// (get) Token: 0x06002FF3 RID: 12275 RVA: 0x00078203 File Offset: 0x00076403
		// (set) Token: 0x06002FF4 RID: 12276 RVA: 0x0007820B File Offset: 0x0007640B
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(1.0)]
		public double groupInterval
		{
			get
			{
				return this.groupIntervalField;
			}
			set
			{
				this.groupIntervalField = value;
			}
		}

		// Token: 0x040020A5 RID: 8357
		private bool autoStartField;

		// Token: 0x040020A6 RID: 8358
		private bool autoEndField;

		// Token: 0x040020A7 RID: 8359
		private global::NPOI.OpenXmlFormats.Spreadsheet.ST_GroupBy groupByField;

		// Token: 0x040020A8 RID: 8360
		private double startNumField;

		// Token: 0x040020A9 RID: 8361
		private bool startNumFieldSpecified;

		// Token: 0x040020AA RID: 8362
		private double endNumField;

		// Token: 0x040020AB RID: 8363
		private bool endNumFieldSpecified;

		// Token: 0x040020AC RID: 8364
		private global::System.DateTime? startDateField;

		// Token: 0x040020AD RID: 8365
		private bool startDateFieldSpecified;

		// Token: 0x040020AE RID: 8366
		private global::System.DateTime? endDateField;

		// Token: 0x040020AF RID: 8367
		private bool endDateFieldSpecified;

		// Token: 0x040020B0 RID: 8368
		private double groupIntervalField;
	}
}
