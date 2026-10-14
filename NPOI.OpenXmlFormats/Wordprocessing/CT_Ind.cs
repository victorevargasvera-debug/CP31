using System;
using System.IO;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Wordprocessing
{
	// Token: 0x02000164 RID: 356
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_Ind
	{
		// Token: 0x06000AFC RID: 2812 RVA: 0x00026240 File Offset: 0x00024440
		public CT_Ind()
		{
			this.firstLineField = -1L;
		}

		// Token: 0x06000AFD RID: 2813 RVA: 0x00026250 File Offset: 0x00024450
		public static global::NPOI.OpenXmlFormats.Wordprocessing.CT_Ind Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Wordprocessing.CT_Ind ct_Ind = new global::NPOI.OpenXmlFormats.Wordprocessing.CT_Ind();
			ct_Ind.left = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["w:left"]);
			ct_Ind.leftChars = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["w:leftChars"]);
			ct_Ind.right = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["w:right"]);
			ct_Ind.rightChars = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["w:rightChars"]);
			ct_Ind.hanging = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadULong(node.Attributes["w:hanging"]);
			ct_Ind.hangingChars = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["w:hangingChars"]);
			if (node.Attributes["w:firstLine"] != null)
			{
				ct_Ind.firstLine = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadLong(node.Attributes["w:firstLine"]);
			}
			ct_Ind.firstLineChars = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["w:firstLineChars"]);
			return ct_Ind;
		}

		// Token: 0x06000AFE RID: 2814 RVA: 0x00026354 File Offset: 0x00024554
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<w:{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "w:leftChars", this.leftChars);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "w:left", this.left);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "w:rightChars", this.rightChars);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "w:right", this.right);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "w:hangingChars", this.hangingChars);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "w:hanging", this.hanging);
			if (this.firstLineField >= 0L)
			{
				global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "w:firstLine", (double)this.firstLine, true);
			}
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "w:firstLineChars", this.firstLineChars);
			sw.Write("/>");
		}

		// Token: 0x170003A7 RID: 935
		// (get) Token: 0x06000AFF RID: 2815 RVA: 0x00026413 File Offset: 0x00024613
		// (set) Token: 0x06000B00 RID: 2816 RVA: 0x0002641B File Offset: 0x0002461B
		[global::System.Xml.Serialization.XmlAttribute(Form = global::System.Xml.Schema.XmlSchemaForm.Qualified, DataType = "integer")]
		public string left
		{
			get
			{
				return this.leftField;
			}
			set
			{
				this.leftField = value;
			}
		}

		// Token: 0x170003A8 RID: 936
		// (get) Token: 0x06000B01 RID: 2817 RVA: 0x00026424 File Offset: 0x00024624
		// (set) Token: 0x06000B02 RID: 2818 RVA: 0x0002642C File Offset: 0x0002462C
		[global::System.Xml.Serialization.XmlAttribute(Form = global::System.Xml.Schema.XmlSchemaForm.Qualified, DataType = "integer")]
		public string leftChars
		{
			get
			{
				return this.leftCharsField;
			}
			set
			{
				this.leftCharsField = value;
			}
		}

		// Token: 0x170003A9 RID: 937
		// (get) Token: 0x06000B03 RID: 2819 RVA: 0x00026435 File Offset: 0x00024635
		// (set) Token: 0x06000B04 RID: 2820 RVA: 0x0002643D File Offset: 0x0002463D
		[global::System.Xml.Serialization.XmlAttribute(Form = global::System.Xml.Schema.XmlSchemaForm.Qualified, DataType = "integer")]
		public string right
		{
			get
			{
				return this.rightField;
			}
			set
			{
				this.rightField = value;
			}
		}

		// Token: 0x170003AA RID: 938
		// (get) Token: 0x06000B05 RID: 2821 RVA: 0x00026446 File Offset: 0x00024646
		// (set) Token: 0x06000B06 RID: 2822 RVA: 0x0002644E File Offset: 0x0002464E
		[global::System.Xml.Serialization.XmlAttribute(Form = global::System.Xml.Schema.XmlSchemaForm.Qualified, DataType = "integer")]
		public string rightChars
		{
			get
			{
				return this.rightCharsField;
			}
			set
			{
				this.rightCharsField = value;
			}
		}

		// Token: 0x170003AB RID: 939
		// (get) Token: 0x06000B07 RID: 2823 RVA: 0x00026457 File Offset: 0x00024657
		// (set) Token: 0x06000B08 RID: 2824 RVA: 0x0002645F File Offset: 0x0002465F
		[global::System.Xml.Serialization.XmlAttribute(Form = global::System.Xml.Schema.XmlSchemaForm.Qualified)]
		public ulong hanging
		{
			get
			{
				return this.hangingField;
			}
			set
			{
				this.hangingField = value;
				this.hangingFieldSpecified = true;
			}
		}

		// Token: 0x170003AC RID: 940
		// (get) Token: 0x06000B09 RID: 2825 RVA: 0x0002646F File Offset: 0x0002466F
		// (set) Token: 0x06000B0A RID: 2826 RVA: 0x00026477 File Offset: 0x00024677
		[global::System.Xml.Serialization.XmlIgnore]
		public bool hangingSpecified
		{
			get
			{
				return this.hangingFieldSpecified;
			}
			set
			{
				this.hangingFieldSpecified = value;
			}
		}

		// Token: 0x170003AD RID: 941
		// (get) Token: 0x06000B0B RID: 2827 RVA: 0x00026480 File Offset: 0x00024680
		// (set) Token: 0x06000B0C RID: 2828 RVA: 0x00026488 File Offset: 0x00024688
		[global::System.Xml.Serialization.XmlAttribute(Form = global::System.Xml.Schema.XmlSchemaForm.Qualified, DataType = "integer")]
		public string hangingChars
		{
			get
			{
				return this.hangingCharsField;
			}
			set
			{
				this.hangingCharsField = value;
			}
		}

		// Token: 0x170003AE RID: 942
		// (get) Token: 0x06000B0D RID: 2829 RVA: 0x00026491 File Offset: 0x00024691
		// (set) Token: 0x06000B0E RID: 2830 RVA: 0x00026499 File Offset: 0x00024699
		[global::System.Xml.Serialization.XmlAttribute(Form = global::System.Xml.Schema.XmlSchemaForm.Qualified)]
		public long firstLine
		{
			get
			{
				return this.firstLineField;
			}
			set
			{
				this.firstLineField = value;
			}
		}

		// Token: 0x170003AF RID: 943
		// (get) Token: 0x06000B0F RID: 2831 RVA: 0x000264A2 File Offset: 0x000246A2
		// (set) Token: 0x06000B10 RID: 2832 RVA: 0x000264AA File Offset: 0x000246AA
		[global::System.Xml.Serialization.XmlIgnore]
		public bool firstLineSpecified
		{
			get
			{
				return this.firstLineFieldSpecified;
			}
			set
			{
				this.firstLineFieldSpecified = value;
			}
		}

		// Token: 0x170003B0 RID: 944
		// (get) Token: 0x06000B11 RID: 2833 RVA: 0x000264B3 File Offset: 0x000246B3
		// (set) Token: 0x06000B12 RID: 2834 RVA: 0x000264BB File Offset: 0x000246BB
		[global::System.Xml.Serialization.XmlAttribute(Form = global::System.Xml.Schema.XmlSchemaForm.Qualified, DataType = "integer")]
		public string firstLineChars
		{
			get
			{
				return this.firstLineCharsField;
			}
			set
			{
				this.firstLineCharsField = value;
			}
		}

		// Token: 0x06000B13 RID: 2835 RVA: 0x000264C4 File Offset: 0x000246C4
		public bool IsSetLeft()
		{
			return !string.IsNullOrEmpty(this.leftField);
		}

		// Token: 0x06000B14 RID: 2836 RVA: 0x000264D4 File Offset: 0x000246D4
		public bool IsSetRight()
		{
			return !string.IsNullOrEmpty(this.rightField);
		}

		// Token: 0x06000B15 RID: 2837 RVA: 0x000264E4 File Offset: 0x000246E4
		public bool IsSetHanging()
		{
			return this.hangingField > 0UL;
		}

		// Token: 0x06000B16 RID: 2838 RVA: 0x000264F0 File Offset: 0x000246F0
		public bool IsSetFirstLine()
		{
			return this.firstLineField != 0L;
		}

		// Token: 0x04000A28 RID: 2600
		private string leftField;

		// Token: 0x04000A29 RID: 2601
		private string leftCharsField;

		// Token: 0x04000A2A RID: 2602
		private string rightField;

		// Token: 0x04000A2B RID: 2603
		private string rightCharsField;

		// Token: 0x04000A2C RID: 2604
		private ulong hangingField;

		// Token: 0x04000A2D RID: 2605
		private bool hangingFieldSpecified;

		// Token: 0x04000A2E RID: 2606
		private string hangingCharsField;

		// Token: 0x04000A2F RID: 2607
		private long firstLineField;

		// Token: 0x04000A30 RID: 2608
		private bool firstLineFieldSpecified;

		// Token: 0x04000A31 RID: 2609
		private string firstLineCharsField;
	}
}
