using System;
using System.IO;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Wordprocessing
{
	// Token: 0x02000162 RID: 354
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_Spacing
	{
		// Token: 0x06000ADD RID: 2781 RVA: 0x00025E58 File Offset: 0x00024058
		public static global::NPOI.OpenXmlFormats.Wordprocessing.CT_Spacing Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Wordprocessing.CT_Spacing ct_Spacing = new global::NPOI.OpenXmlFormats.Wordprocessing.CT_Spacing();
			if (node.Attributes["w:before"] != null)
			{
				ct_Spacing.before = new ulong?(global::NPOI.OpenXml4Net.Util.XmlHelper.ReadULong(node.Attributes["w:before"]));
			}
			ct_Spacing.beforeLines = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["w:beforeLines"]);
			if (node.Attributes["w:beforeAutospacing"] != null)
			{
				ct_Spacing.beforeAutospacing = (global::NPOI.OpenXmlFormats.Wordprocessing.ST_OnOff)global::System.Enum.Parse(typeof(global::NPOI.OpenXmlFormats.Wordprocessing.ST_OnOff), node.Attributes["w:beforeAutospacing"].Value, true);
			}
			if (node.Attributes["w:after"] != null)
			{
				ct_Spacing.after = new ulong?(global::NPOI.OpenXml4Net.Util.XmlHelper.ReadULong(node.Attributes["w:after"]));
			}
			ct_Spacing.afterLines = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["w:afterLines"]);
			if (node.Attributes["w:afterAutospacing"] != null)
			{
				ct_Spacing.afterAutospacing = (global::NPOI.OpenXmlFormats.Wordprocessing.ST_OnOff)global::System.Enum.Parse(typeof(global::NPOI.OpenXmlFormats.Wordprocessing.ST_OnOff), node.Attributes["w:afterAutospacing"].Value, true);
			}
			ct_Spacing.line = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["w:line"]);
			if (node.Attributes["w:lineRule"] != null)
			{
				ct_Spacing.lineRule = (global::NPOI.OpenXmlFormats.Wordprocessing.ST_LineSpacingRule)global::System.Enum.Parse(typeof(global::NPOI.OpenXmlFormats.Wordprocessing.ST_LineSpacingRule), node.Attributes["w:lineRule"].Value);
			}
			return ct_Spacing;
		}

		// Token: 0x06000ADE RID: 2782 RVA: 0x00025FEC File Offset: 0x000241EC
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<w:{0}", nodeName));
			if (this.beforeField != null)
			{
				global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "w:before", this.before.Value, true);
			}
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "w:beforeLines", this.beforeLines);
			if (this.beforeAutospacing != global::NPOI.OpenXmlFormats.Wordprocessing.ST_OnOff.off)
			{
				global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "w:beforeAutospacing", this.beforeAutospacing.ToString());
			}
			if (this.afterField != null)
			{
				global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "w:after", this.after.Value, true);
			}
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "w:afterLines", this.afterLines);
			if (this.afterAutospacing != global::NPOI.OpenXmlFormats.Wordprocessing.ST_OnOff.off)
			{
				global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "w:afterAutospacing", this.afterAutospacing.ToString());
			}
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "w:line", this.line);
			if (this.lineRule != global::NPOI.OpenXmlFormats.Wordprocessing.ST_LineSpacingRule.nil)
			{
				global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "w:lineRule", this.lineRule.ToString());
			}
			sw.Write("/>");
		}

		// Token: 0x1700039C RID: 924
		// (get) Token: 0x06000ADF RID: 2783 RVA: 0x0002610F File Offset: 0x0002430F
		// (set) Token: 0x06000AE0 RID: 2784 RVA: 0x00026117 File Offset: 0x00024317
		[global::System.Xml.Serialization.XmlAttribute(Form = global::System.Xml.Schema.XmlSchemaForm.Qualified)]
		public ulong? before
		{
			get
			{
				return this.beforeField;
			}
			set
			{
				this.beforeField = value;
			}
		}

		// Token: 0x1700039D RID: 925
		// (get) Token: 0x06000AE1 RID: 2785 RVA: 0x00026120 File Offset: 0x00024320
		// (set) Token: 0x06000AE2 RID: 2786 RVA: 0x00026128 File Offset: 0x00024328
		[global::System.Xml.Serialization.XmlAttribute(Form = global::System.Xml.Schema.XmlSchemaForm.Qualified, DataType = "integer")]
		public string beforeLines
		{
			get
			{
				return this.beforeLinesField;
			}
			set
			{
				this.beforeLinesField = value;
			}
		}

		// Token: 0x1700039E RID: 926
		// (get) Token: 0x06000AE3 RID: 2787 RVA: 0x00026131 File Offset: 0x00024331
		// (set) Token: 0x06000AE4 RID: 2788 RVA: 0x00026139 File Offset: 0x00024339
		[global::System.Xml.Serialization.XmlAttribute(Form = global::System.Xml.Schema.XmlSchemaForm.Qualified)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.ST_OnOff beforeAutospacing
		{
			get
			{
				return this.beforeAutospacingField;
			}
			set
			{
				this.beforeAutospacingField = value;
			}
		}

		// Token: 0x1700039F RID: 927
		// (get) Token: 0x06000AE5 RID: 2789 RVA: 0x00026142 File Offset: 0x00024342
		// (set) Token: 0x06000AE6 RID: 2790 RVA: 0x0002614A File Offset: 0x0002434A
		[global::System.Xml.Serialization.XmlIgnore]
		public bool beforeAutospacingSpecified
		{
			get
			{
				return this.beforeAutospacingFieldSpecified;
			}
			set
			{
				this.beforeAutospacingFieldSpecified = value;
			}
		}

		// Token: 0x170003A0 RID: 928
		// (get) Token: 0x06000AE7 RID: 2791 RVA: 0x00026153 File Offset: 0x00024353
		// (set) Token: 0x06000AE8 RID: 2792 RVA: 0x0002615B File Offset: 0x0002435B
		public ulong? after
		{
			get
			{
				return this.afterField;
			}
			set
			{
				this.afterField = value;
			}
		}

		// Token: 0x170003A1 RID: 929
		// (get) Token: 0x06000AE9 RID: 2793 RVA: 0x00026164 File Offset: 0x00024364
		// (set) Token: 0x06000AEA RID: 2794 RVA: 0x0002616C File Offset: 0x0002436C
		[global::System.Xml.Serialization.XmlAttribute(Form = global::System.Xml.Schema.XmlSchemaForm.Qualified, DataType = "integer")]
		public string afterLines
		{
			get
			{
				return this.afterLinesField;
			}
			set
			{
				this.afterLinesField = value;
			}
		}

		// Token: 0x170003A2 RID: 930
		// (get) Token: 0x06000AEB RID: 2795 RVA: 0x00026175 File Offset: 0x00024375
		// (set) Token: 0x06000AEC RID: 2796 RVA: 0x0002617D File Offset: 0x0002437D
		[global::System.Xml.Serialization.XmlAttribute(Form = global::System.Xml.Schema.XmlSchemaForm.Qualified)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.ST_OnOff afterAutospacing
		{
			get
			{
				return this.afterAutospacingField;
			}
			set
			{
				this.afterAutospacingField = value;
			}
		}

		// Token: 0x170003A3 RID: 931
		// (get) Token: 0x06000AED RID: 2797 RVA: 0x00026186 File Offset: 0x00024386
		// (set) Token: 0x06000AEE RID: 2798 RVA: 0x0002618E File Offset: 0x0002438E
		[global::System.Xml.Serialization.XmlIgnore]
		public bool afterAutospacingSpecified
		{
			get
			{
				return this.afterAutospacingFieldSpecified;
			}
			set
			{
				this.afterAutospacingFieldSpecified = value;
			}
		}

		// Token: 0x170003A4 RID: 932
		// (get) Token: 0x06000AEF RID: 2799 RVA: 0x00026197 File Offset: 0x00024397
		// (set) Token: 0x06000AF0 RID: 2800 RVA: 0x0002619F File Offset: 0x0002439F
		[global::System.Xml.Serialization.XmlAttribute(Form = global::System.Xml.Schema.XmlSchemaForm.Qualified, DataType = "integer")]
		public string line
		{
			get
			{
				return this.lineField;
			}
			set
			{
				this.lineField = value;
			}
		}

		// Token: 0x170003A5 RID: 933
		// (get) Token: 0x06000AF1 RID: 2801 RVA: 0x000261A8 File Offset: 0x000243A8
		// (set) Token: 0x06000AF2 RID: 2802 RVA: 0x000261B0 File Offset: 0x000243B0
		[global::System.Xml.Serialization.XmlAttribute(Form = global::System.Xml.Schema.XmlSchemaForm.Qualified)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.ST_LineSpacingRule lineRule
		{
			get
			{
				return this.lineRuleField;
			}
			set
			{
				this.lineRuleField = value;
			}
		}

		// Token: 0x170003A6 RID: 934
		// (get) Token: 0x06000AF3 RID: 2803 RVA: 0x000261B9 File Offset: 0x000243B9
		// (set) Token: 0x06000AF4 RID: 2804 RVA: 0x000261C1 File Offset: 0x000243C1
		[global::System.Xml.Serialization.XmlIgnore]
		public bool lineRuleSpecified
		{
			get
			{
				return this.lineRuleFieldSpecified;
			}
			set
			{
				this.lineRuleFieldSpecified = value;
			}
		}

		// Token: 0x06000AF5 RID: 2805 RVA: 0x000261CA File Offset: 0x000243CA
		public bool IsSetBefore()
		{
			return this.beforeField != null;
		}

		// Token: 0x06000AF6 RID: 2806 RVA: 0x000261D7 File Offset: 0x000243D7
		public bool IsSetBeforeLines()
		{
			return !string.IsNullOrEmpty(this.beforeLinesField);
		}

		// Token: 0x06000AF7 RID: 2807 RVA: 0x000261E7 File Offset: 0x000243E7
		public bool IsSetLineRule()
		{
			return this.lineRuleField > global::NPOI.OpenXmlFormats.Wordprocessing.ST_LineSpacingRule.nil;
		}

		// Token: 0x06000AF8 RID: 2808 RVA: 0x000261F2 File Offset: 0x000243F2
		public bool IsSetBetweenLines()
		{
			return !string.IsNullOrEmpty(this.lineField);
		}

		// Token: 0x06000AF9 RID: 2809 RVA: 0x00026204 File Offset: 0x00024404
		public bool IsSetAfter()
		{
			ulong? num = this.afterField;
			ulong num2 = 0UL;
			return !(num.GetValueOrDefault() == num2 & num != null);
		}

		// Token: 0x06000AFA RID: 2810 RVA: 0x00026230 File Offset: 0x00024430
		public bool IsSetAfterLines()
		{
			return !string.IsNullOrEmpty(this.afterLinesField);
		}

		// Token: 0x04000A18 RID: 2584
		private ulong? beforeField;

		// Token: 0x04000A19 RID: 2585
		private string beforeLinesField;

		// Token: 0x04000A1A RID: 2586
		private global::NPOI.OpenXmlFormats.Wordprocessing.ST_OnOff beforeAutospacingField;

		// Token: 0x04000A1B RID: 2587
		private bool beforeAutospacingFieldSpecified;

		// Token: 0x04000A1C RID: 2588
		private ulong? afterField;

		// Token: 0x04000A1D RID: 2589
		private string afterLinesField;

		// Token: 0x04000A1E RID: 2590
		private global::NPOI.OpenXmlFormats.Wordprocessing.ST_OnOff afterAutospacingField;

		// Token: 0x04000A1F RID: 2591
		private bool afterAutospacingFieldSpecified;

		// Token: 0x04000A20 RID: 2592
		private string lineField;

		// Token: 0x04000A21 RID: 2593
		private global::NPOI.OpenXmlFormats.Wordprocessing.ST_LineSpacingRule lineRuleField;

		// Token: 0x04000A22 RID: 2594
		private bool lineRuleFieldSpecified;
	}
}
