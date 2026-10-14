using System;
using System.Collections.Generic;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Wordprocessing
{
	// Token: 0x02000106 RID: 262
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_Div
	{
		// Token: 0x06000713 RID: 1811 RVA: 0x00016050 File Offset: 0x00014250
		public CT_Div()
		{
			this.divsChildField = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.CT_Divs>();
			this.divBdrField = new global::NPOI.OpenXmlFormats.Wordprocessing.CT_DivBdr();
			this.marBottomField = new global::NPOI.OpenXmlFormats.Wordprocessing.CT_SignedTwipsMeasure();
			this.marTopField = new global::NPOI.OpenXmlFormats.Wordprocessing.CT_SignedTwipsMeasure();
			this.marRightField = new global::NPOI.OpenXmlFormats.Wordprocessing.CT_SignedTwipsMeasure();
			this.marLeftField = new global::NPOI.OpenXmlFormats.Wordprocessing.CT_SignedTwipsMeasure();
			this.bodyDivField = new global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff();
			this.blockQuoteField = new global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff();
		}

		// Token: 0x1700025E RID: 606
		// (get) Token: 0x06000714 RID: 1812 RVA: 0x000160BB File Offset: 0x000142BB
		// (set) Token: 0x06000715 RID: 1813 RVA: 0x000160C3 File Offset: 0x000142C3
		[global::System.Xml.Serialization.XmlElement(Order = 0)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff blockQuote
		{
			get
			{
				return this.blockQuoteField;
			}
			set
			{
				this.blockQuoteField = value;
			}
		}

		// Token: 0x1700025F RID: 607
		// (get) Token: 0x06000716 RID: 1814 RVA: 0x000160CC File Offset: 0x000142CC
		// (set) Token: 0x06000717 RID: 1815 RVA: 0x000160D4 File Offset: 0x000142D4
		[global::System.Xml.Serialization.XmlElement(Order = 1)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff bodyDiv
		{
			get
			{
				return this.bodyDivField;
			}
			set
			{
				this.bodyDivField = value;
			}
		}

		// Token: 0x17000260 RID: 608
		// (get) Token: 0x06000718 RID: 1816 RVA: 0x000160DD File Offset: 0x000142DD
		// (set) Token: 0x06000719 RID: 1817 RVA: 0x000160E5 File Offset: 0x000142E5
		[global::System.Xml.Serialization.XmlElement(Order = 2)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_SignedTwipsMeasure marLeft
		{
			get
			{
				return this.marLeftField;
			}
			set
			{
				this.marLeftField = value;
			}
		}

		// Token: 0x17000261 RID: 609
		// (get) Token: 0x0600071A RID: 1818 RVA: 0x000160EE File Offset: 0x000142EE
		// (set) Token: 0x0600071B RID: 1819 RVA: 0x000160F6 File Offset: 0x000142F6
		[global::System.Xml.Serialization.XmlElement(Order = 3)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_SignedTwipsMeasure marRight
		{
			get
			{
				return this.marRightField;
			}
			set
			{
				this.marRightField = value;
			}
		}

		// Token: 0x17000262 RID: 610
		// (get) Token: 0x0600071C RID: 1820 RVA: 0x000160FF File Offset: 0x000142FF
		// (set) Token: 0x0600071D RID: 1821 RVA: 0x00016107 File Offset: 0x00014307
		[global::System.Xml.Serialization.XmlElement(Order = 4)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_SignedTwipsMeasure marTop
		{
			get
			{
				return this.marTopField;
			}
			set
			{
				this.marTopField = value;
			}
		}

		// Token: 0x17000263 RID: 611
		// (get) Token: 0x0600071E RID: 1822 RVA: 0x00016110 File Offset: 0x00014310
		// (set) Token: 0x0600071F RID: 1823 RVA: 0x00016118 File Offset: 0x00014318
		[global::System.Xml.Serialization.XmlElement(Order = 5)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_SignedTwipsMeasure marBottom
		{
			get
			{
				return this.marBottomField;
			}
			set
			{
				this.marBottomField = value;
			}
		}

		// Token: 0x17000264 RID: 612
		// (get) Token: 0x06000720 RID: 1824 RVA: 0x00016121 File Offset: 0x00014321
		// (set) Token: 0x06000721 RID: 1825 RVA: 0x00016129 File Offset: 0x00014329
		[global::System.Xml.Serialization.XmlElement(Order = 6)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_DivBdr divBdr
		{
			get
			{
				return this.divBdrField;
			}
			set
			{
				this.divBdrField = value;
			}
		}

		// Token: 0x17000265 RID: 613
		// (get) Token: 0x06000722 RID: 1826 RVA: 0x00016132 File Offset: 0x00014332
		// (set) Token: 0x06000723 RID: 1827 RVA: 0x0001613A File Offset: 0x0001433A
		[global::System.Xml.Serialization.XmlElement("divsChild", Order = 7)]
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.CT_Divs> divsChild
		{
			get
			{
				return this.divsChildField;
			}
			set
			{
				this.divsChildField = value;
			}
		}

		// Token: 0x17000266 RID: 614
		// (get) Token: 0x06000724 RID: 1828 RVA: 0x00016143 File Offset: 0x00014343
		// (set) Token: 0x06000725 RID: 1829 RVA: 0x0001614B File Offset: 0x0001434B
		[global::System.Xml.Serialization.XmlAttribute(Form = global::System.Xml.Schema.XmlSchemaForm.Qualified, DataType = "integer")]
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

		// Token: 0x04000647 RID: 1607
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff blockQuoteField;

		// Token: 0x04000648 RID: 1608
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff bodyDivField;

		// Token: 0x04000649 RID: 1609
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_SignedTwipsMeasure marLeftField;

		// Token: 0x0400064A RID: 1610
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_SignedTwipsMeasure marRightField;

		// Token: 0x0400064B RID: 1611
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_SignedTwipsMeasure marTopField;

		// Token: 0x0400064C RID: 1612
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_SignedTwipsMeasure marBottomField;

		// Token: 0x0400064D RID: 1613
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_DivBdr divBdrField;

		// Token: 0x0400064E RID: 1614
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.CT_Divs> divsChildField;

		// Token: 0x0400064F RID: 1615
		private string idField;
	}
}
