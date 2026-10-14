using System;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Wordprocessing
{
	// Token: 0x020001C5 RID: 453
	[global::System.Xml.Serialization.XmlInclude(typeof(global::NPOI.OpenXmlFormats.Wordprocessing.CT_TcPrInner))]
	[global::System.Xml.Serialization.XmlInclude(typeof(global::NPOI.OpenXmlFormats.Wordprocessing.CT_TcPr))]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_TcPrBase
	{
		// Token: 0x17000614 RID: 1556
		// (get) Token: 0x06001138 RID: 4408 RVA: 0x0003996C File Offset: 0x00037B6C
		// (set) Token: 0x06001139 RID: 4409 RVA: 0x00039974 File Offset: 0x00037B74
		[global::System.Xml.Serialization.XmlElement(Order = 0)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_Cnf cnfStyle
		{
			get
			{
				return this.cnfStyleField;
			}
			set
			{
				this.cnfStyleField = value;
			}
		}

		// Token: 0x17000615 RID: 1557
		// (get) Token: 0x0600113A RID: 4410 RVA: 0x0003997D File Offset: 0x00037B7D
		// (set) Token: 0x0600113B RID: 4411 RVA: 0x00039985 File Offset: 0x00037B85
		[global::System.Xml.Serialization.XmlElement(Order = 1)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_TblWidth tcW
		{
			get
			{
				return this.tcWField;
			}
			set
			{
				this.tcWField = value;
			}
		}

		// Token: 0x17000616 RID: 1558
		// (get) Token: 0x0600113C RID: 4412 RVA: 0x0003998E File Offset: 0x00037B8E
		// (set) Token: 0x0600113D RID: 4413 RVA: 0x00039996 File Offset: 0x00037B96
		[global::System.Xml.Serialization.XmlElement(Order = 2)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_DecimalNumber gridSpan
		{
			get
			{
				return this.gridSpanField;
			}
			set
			{
				this.gridSpanField = value;
			}
		}

		// Token: 0x17000617 RID: 1559
		// (get) Token: 0x0600113E RID: 4414 RVA: 0x0003999F File Offset: 0x00037B9F
		// (set) Token: 0x0600113F RID: 4415 RVA: 0x000399A7 File Offset: 0x00037BA7
		[global::System.Xml.Serialization.XmlElement(Order = 3)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_HMerge hMerge
		{
			get
			{
				return this.hMergeField;
			}
			set
			{
				this.hMergeField = value;
			}
		}

		// Token: 0x17000618 RID: 1560
		// (get) Token: 0x06001140 RID: 4416 RVA: 0x000399B0 File Offset: 0x00037BB0
		// (set) Token: 0x06001141 RID: 4417 RVA: 0x000399B8 File Offset: 0x00037BB8
		[global::System.Xml.Serialization.XmlElement(Order = 4)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_VMerge vMerge
		{
			get
			{
				return this.vMergeField;
			}
			set
			{
				this.vMergeField = value;
			}
		}

		// Token: 0x17000619 RID: 1561
		// (get) Token: 0x06001142 RID: 4418 RVA: 0x000399C1 File Offset: 0x00037BC1
		// (set) Token: 0x06001143 RID: 4419 RVA: 0x000399C9 File Offset: 0x00037BC9
		[global::System.Xml.Serialization.XmlElement(Order = 5)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_TcBorders tcBorders
		{
			get
			{
				return this.tcBordersField;
			}
			set
			{
				this.tcBordersField = value;
			}
		}

		// Token: 0x1700061A RID: 1562
		// (get) Token: 0x06001144 RID: 4420 RVA: 0x000399D2 File Offset: 0x00037BD2
		// (set) Token: 0x06001145 RID: 4421 RVA: 0x000399DA File Offset: 0x00037BDA
		[global::System.Xml.Serialization.XmlElement(Order = 6)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_Shd shd
		{
			get
			{
				return this.shdField;
			}
			set
			{
				this.shdField = value;
			}
		}

		// Token: 0x1700061B RID: 1563
		// (get) Token: 0x06001146 RID: 4422 RVA: 0x000399E3 File Offset: 0x00037BE3
		// (set) Token: 0x06001147 RID: 4423 RVA: 0x000399EB File Offset: 0x00037BEB
		[global::System.Xml.Serialization.XmlElement(Order = 7)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff noWrap
		{
			get
			{
				return this.noWrapField;
			}
			set
			{
				this.noWrapField = value;
			}
		}

		// Token: 0x1700061C RID: 1564
		// (get) Token: 0x06001148 RID: 4424 RVA: 0x000399F4 File Offset: 0x00037BF4
		// (set) Token: 0x06001149 RID: 4425 RVA: 0x000399FC File Offset: 0x00037BFC
		[global::System.Xml.Serialization.XmlElement(Order = 8)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_TcMar tcMar
		{
			get
			{
				return this.tcMarField;
			}
			set
			{
				this.tcMarField = value;
			}
		}

		// Token: 0x1700061D RID: 1565
		// (get) Token: 0x0600114A RID: 4426 RVA: 0x00039A05 File Offset: 0x00037C05
		// (set) Token: 0x0600114B RID: 4427 RVA: 0x00039A0D File Offset: 0x00037C0D
		[global::System.Xml.Serialization.XmlElement(Order = 9)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_TextDirection textDirection
		{
			get
			{
				return this.textDirectionField;
			}
			set
			{
				this.textDirectionField = value;
			}
		}

		// Token: 0x1700061E RID: 1566
		// (get) Token: 0x0600114C RID: 4428 RVA: 0x00039A16 File Offset: 0x00037C16
		// (set) Token: 0x0600114D RID: 4429 RVA: 0x00039A1E File Offset: 0x00037C1E
		[global::System.Xml.Serialization.XmlElement(Order = 10)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff tcFitText
		{
			get
			{
				return this.tcFitTextField;
			}
			set
			{
				this.tcFitTextField = value;
			}
		}

		// Token: 0x1700061F RID: 1567
		// (get) Token: 0x0600114E RID: 4430 RVA: 0x00039A27 File Offset: 0x00037C27
		// (set) Token: 0x0600114F RID: 4431 RVA: 0x00039A2F File Offset: 0x00037C2F
		[global::System.Xml.Serialization.XmlElement(Order = 11)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_VerticalJc vAlign
		{
			get
			{
				return this.vAlignField;
			}
			set
			{
				this.vAlignField = value;
			}
		}

		// Token: 0x17000620 RID: 1568
		// (get) Token: 0x06001150 RID: 4432 RVA: 0x00039A38 File Offset: 0x00037C38
		// (set) Token: 0x06001151 RID: 4433 RVA: 0x00039A40 File Offset: 0x00037C40
		[global::System.Xml.Serialization.XmlElement(Order = 12)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff hideMark
		{
			get
			{
				return this.hideMarkField;
			}
			set
			{
				this.hideMarkField = value;
			}
		}

		// Token: 0x06001152 RID: 4434 RVA: 0x00039A49 File Offset: 0x00037C49
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_Shd AddNewShd()
		{
			this.shdField = new global::NPOI.OpenXmlFormats.Wordprocessing.CT_Shd();
			return this.shdField;
		}

		// Token: 0x06001153 RID: 4435 RVA: 0x00039A5C File Offset: 0x00037C5C
		public bool IsSetShd()
		{
			return this.shdField != null;
		}

		// Token: 0x06001154 RID: 4436 RVA: 0x00039A67 File Offset: 0x00037C67
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_VerticalJc AddNewVAlign()
		{
			this.vAlign = new global::NPOI.OpenXmlFormats.Wordprocessing.CT_VerticalJc();
			return this.vAlign;
		}

		// Token: 0x06001155 RID: 4437 RVA: 0x00039A7A File Offset: 0x00037C7A
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_VMerge AddNewVMerge()
		{
			this.vMerge = new global::NPOI.OpenXmlFormats.Wordprocessing.CT_VMerge();
			return this.vMerge;
		}

		// Token: 0x06001156 RID: 4438 RVA: 0x00039A8D File Offset: 0x00037C8D
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_TcBorders AddNewTcBorders()
		{
			this.tcBorders = new global::NPOI.OpenXmlFormats.Wordprocessing.CT_TcBorders();
			return this.tcBorders;
		}

		// Token: 0x06001157 RID: 4439 RVA: 0x00039AA0 File Offset: 0x00037CA0
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_HMerge AddNewHMerge()
		{
			this.hMerge = new global::NPOI.OpenXmlFormats.Wordprocessing.CT_HMerge();
			return this.hMerge;
		}

		// Token: 0x06001158 RID: 4440 RVA: 0x00039AB3 File Offset: 0x00037CB3
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_DecimalNumber AddNewGridspan()
		{
			this.gridSpanField = new global::NPOI.OpenXmlFormats.Wordprocessing.CT_DecimalNumber();
			return this.gridSpanField;
		}

		// Token: 0x04000D74 RID: 3444
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_Cnf cnfStyleField;

		// Token: 0x04000D75 RID: 3445
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_TblWidth tcWField;

		// Token: 0x04000D76 RID: 3446
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_DecimalNumber gridSpanField;

		// Token: 0x04000D77 RID: 3447
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_HMerge hMergeField;

		// Token: 0x04000D78 RID: 3448
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_VMerge vMergeField;

		// Token: 0x04000D79 RID: 3449
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_TcBorders tcBordersField;

		// Token: 0x04000D7A RID: 3450
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_Shd shdField;

		// Token: 0x04000D7B RID: 3451
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff noWrapField;

		// Token: 0x04000D7C RID: 3452
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_TcMar tcMarField;

		// Token: 0x04000D7D RID: 3453
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_TextDirection textDirectionField;

		// Token: 0x04000D7E RID: 3454
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff tcFitTextField;

		// Token: 0x04000D7F RID: 3455
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_VerticalJc vAlignField;

		// Token: 0x04000D80 RID: 3456
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff hideMarkField;
	}
}
