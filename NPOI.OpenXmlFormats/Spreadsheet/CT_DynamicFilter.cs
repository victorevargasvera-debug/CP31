using System;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Spreadsheet
{
	// Token: 0x02000534 RID: 1332
	public class CT_DynamicFilter
	{
		// Token: 0x170015D3 RID: 5587
		// (get) Token: 0x06003A72 RID: 14962 RVA: 0x00090F75 File Offset: 0x0008F175
		// (set) Token: 0x06003A73 RID: 14963 RVA: 0x00090F7D File Offset: 0x0008F17D
		public global::NPOI.OpenXmlFormats.Spreadsheet.ST_DynamicFilterType type
		{
			get
			{
				return this.typeField;
			}
			set
			{
				this.typeField = value;
			}
		}

		// Token: 0x170015D4 RID: 5588
		// (get) Token: 0x06003A74 RID: 14964 RVA: 0x00090F86 File Offset: 0x0008F186
		// (set) Token: 0x06003A75 RID: 14965 RVA: 0x00090F8E File Offset: 0x0008F18E
		public double val
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

		// Token: 0x170015D5 RID: 5589
		// (get) Token: 0x06003A76 RID: 14966 RVA: 0x00090F97 File Offset: 0x0008F197
		// (set) Token: 0x06003A77 RID: 14967 RVA: 0x00090F9F File Offset: 0x0008F19F
		[global::System.Xml.Serialization.XmlIgnore]
		public bool valSpecified
		{
			get
			{
				return this.valFieldSpecified;
			}
			set
			{
				this.valFieldSpecified = value;
			}
		}

		// Token: 0x170015D6 RID: 5590
		// (get) Token: 0x06003A78 RID: 14968 RVA: 0x00090FA8 File Offset: 0x0008F1A8
		// (set) Token: 0x06003A79 RID: 14969 RVA: 0x00090FB0 File Offset: 0x0008F1B0
		public double maxVal
		{
			get
			{
				return this.maxValField;
			}
			set
			{
				this.maxValField = value;
			}
		}

		// Token: 0x170015D7 RID: 5591
		// (get) Token: 0x06003A7A RID: 14970 RVA: 0x00090FB9 File Offset: 0x0008F1B9
		// (set) Token: 0x06003A7B RID: 14971 RVA: 0x00090FC1 File Offset: 0x0008F1C1
		[global::System.Xml.Serialization.XmlIgnore]
		public bool maxValSpecified
		{
			get
			{
				return this.maxValFieldSpecified;
			}
			set
			{
				this.maxValFieldSpecified = value;
			}
		}

		// Token: 0x04002540 RID: 9536
		private global::NPOI.OpenXmlFormats.Spreadsheet.ST_DynamicFilterType typeField;

		// Token: 0x04002541 RID: 9537
		private double valField;

		// Token: 0x04002542 RID: 9538
		private bool valFieldSpecified;

		// Token: 0x04002543 RID: 9539
		private double maxValField;

		// Token: 0x04002544 RID: 9540
		private bool maxValFieldSpecified;
	}
}
