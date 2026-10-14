using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Wordprocessing
{
	// Token: 0x020001CA RID: 458
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_Columns
	{
		// Token: 0x06001172 RID: 4466 RVA: 0x00039D88 File Offset: 0x00037F88
		public CT_Columns()
		{
			this.equalWidthField = global::NPOI.OpenXmlFormats.Wordprocessing.ST_OnOff.off;
			this.sepField = global::NPOI.OpenXmlFormats.Wordprocessing.ST_OnOff.off;
		}

		// Token: 0x06001173 RID: 4467 RVA: 0x00039DA0 File Offset: 0x00037FA0
		public static global::NPOI.OpenXmlFormats.Wordprocessing.CT_Columns Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Wordprocessing.CT_Columns ct_Columns = new global::NPOI.OpenXmlFormats.Wordprocessing.CT_Columns();
			if (node.Attributes["w:equalWidth"] != null)
			{
				ct_Columns.equalWidth = (global::NPOI.OpenXmlFormats.Wordprocessing.ST_OnOff)global::System.Enum.Parse(typeof(global::NPOI.OpenXmlFormats.Wordprocessing.ST_OnOff), node.Attributes["w:equalWidth"].Value, true);
			}
			ct_Columns.space = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadULong(node.Attributes["w:space"]);
			ct_Columns.num = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["w:num"]);
			if (node.Attributes["w:sep"] != null)
			{
				ct_Columns.sep = (global::NPOI.OpenXmlFormats.Wordprocessing.ST_OnOff)global::System.Enum.Parse(typeof(global::NPOI.OpenXmlFormats.Wordprocessing.ST_OnOff), node.Attributes["w:sep"].Value, true);
			}
			ct_Columns.col = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.CT_Column>();
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "col")
				{
					ct_Columns.col.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_Column.Parse(xmlNode, namespaceManager));
				}
			}
			return ct_Columns;
		}

		// Token: 0x06001174 RID: 4468 RVA: 0x00039EE8 File Offset: 0x000380E8
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<w:{0}", nodeName));
			if (this.equalWidth != global::NPOI.OpenXmlFormats.Wordprocessing.ST_OnOff.off)
			{
				global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "w:equalWidth", this.equalWidth.ToString());
			}
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "w:space", this.space);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "w:num", this.num);
			if (this.sep != global::NPOI.OpenXmlFormats.Wordprocessing.ST_OnOff.off)
			{
				global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "w:sep", this.sep.ToString());
			}
			if (this.col != null && this.col.Count > 0)
			{
				sw.Write(">");
				foreach (global::NPOI.OpenXmlFormats.Wordprocessing.CT_Column ct_Column in this.col)
				{
					ct_Column.Write(sw, "col");
				}
				sw.Write(string.Format("</w:{0}>", nodeName));
				return;
			}
			sw.Write("/>");
		}

		// Token: 0x17000629 RID: 1577
		// (get) Token: 0x06001175 RID: 4469 RVA: 0x0003A000 File Offset: 0x00038200
		// (set) Token: 0x06001176 RID: 4470 RVA: 0x0003A008 File Offset: 0x00038208
		[global::System.Xml.Serialization.XmlElement("col", Order = 0)]
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.CT_Column> col
		{
			get
			{
				return this.colField;
			}
			set
			{
				this.colField = value;
			}
		}

		// Token: 0x1700062A RID: 1578
		// (get) Token: 0x06001177 RID: 4471 RVA: 0x0003A011 File Offset: 0x00038211
		// (set) Token: 0x06001178 RID: 4472 RVA: 0x0003A019 File Offset: 0x00038219
		[global::System.Xml.Serialization.XmlAttribute(Form = global::System.Xml.Schema.XmlSchemaForm.Qualified)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.ST_OnOff equalWidth
		{
			get
			{
				return this.equalWidthField;
			}
			set
			{
				this.equalWidthField = value;
			}
		}

		// Token: 0x1700062B RID: 1579
		// (get) Token: 0x06001179 RID: 4473 RVA: 0x0003A022 File Offset: 0x00038222
		// (set) Token: 0x0600117A RID: 4474 RVA: 0x0003A02A File Offset: 0x0003822A
		[global::System.Xml.Serialization.XmlIgnore]
		public bool equalWidthSpecified
		{
			get
			{
				return this.equalWidthFieldSpecified;
			}
			set
			{
				this.equalWidthFieldSpecified = value;
			}
		}

		// Token: 0x1700062C RID: 1580
		// (get) Token: 0x0600117B RID: 4475 RVA: 0x0003A033 File Offset: 0x00038233
		// (set) Token: 0x0600117C RID: 4476 RVA: 0x0003A03B File Offset: 0x0003823B
		[global::System.Xml.Serialization.XmlAttribute(Form = global::System.Xml.Schema.XmlSchemaForm.Qualified)]
		public ulong space
		{
			get
			{
				return this.spaceField;
			}
			set
			{
				this.spaceField = value;
			}
		}

		// Token: 0x1700062D RID: 1581
		// (get) Token: 0x0600117D RID: 4477 RVA: 0x0003A044 File Offset: 0x00038244
		// (set) Token: 0x0600117E RID: 4478 RVA: 0x0003A04C File Offset: 0x0003824C
		[global::System.Xml.Serialization.XmlIgnore]
		public bool spaceSpecified
		{
			get
			{
				return this.spaceFieldSpecified;
			}
			set
			{
				this.spaceFieldSpecified = value;
			}
		}

		// Token: 0x1700062E RID: 1582
		// (get) Token: 0x0600117F RID: 4479 RVA: 0x0003A055 File Offset: 0x00038255
		// (set) Token: 0x06001180 RID: 4480 RVA: 0x0003A05D File Offset: 0x0003825D
		[global::System.Xml.Serialization.XmlAttribute(Form = global::System.Xml.Schema.XmlSchemaForm.Qualified, DataType = "integer")]
		public string num
		{
			get
			{
				return this.numField;
			}
			set
			{
				this.numField = value;
			}
		}

		// Token: 0x1700062F RID: 1583
		// (get) Token: 0x06001181 RID: 4481 RVA: 0x0003A066 File Offset: 0x00038266
		// (set) Token: 0x06001182 RID: 4482 RVA: 0x0003A06E File Offset: 0x0003826E
		[global::System.Xml.Serialization.XmlAttribute(Form = global::System.Xml.Schema.XmlSchemaForm.Qualified)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.ST_OnOff sep
		{
			get
			{
				return this.sepField;
			}
			set
			{
				this.sepField = value;
			}
		}

		// Token: 0x17000630 RID: 1584
		// (get) Token: 0x06001183 RID: 4483 RVA: 0x0003A077 File Offset: 0x00038277
		// (set) Token: 0x06001184 RID: 4484 RVA: 0x0003A07F File Offset: 0x0003827F
		[global::System.Xml.Serialization.XmlIgnore]
		public bool sepSpecified
		{
			get
			{
				return this.sepFieldSpecified;
			}
			set
			{
				this.sepFieldSpecified = value;
			}
		}

		// Token: 0x04000D8C RID: 3468
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.CT_Column> colField;

		// Token: 0x04000D8D RID: 3469
		private global::NPOI.OpenXmlFormats.Wordprocessing.ST_OnOff equalWidthField;

		// Token: 0x04000D8E RID: 3470
		private bool equalWidthFieldSpecified;

		// Token: 0x04000D8F RID: 3471
		private ulong spaceField;

		// Token: 0x04000D90 RID: 3472
		private bool spaceFieldSpecified;

		// Token: 0x04000D91 RID: 3473
		private string numField;

		// Token: 0x04000D92 RID: 3474
		private global::NPOI.OpenXmlFormats.Wordprocessing.ST_OnOff sepField;

		// Token: 0x04000D93 RID: 3475
		private bool sepFieldSpecified;
	}
}
