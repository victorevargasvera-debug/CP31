using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Spreadsheet
{
	// Token: 0x0200053C RID: 1340
	public class CT_Top10
	{
		// Token: 0x06003AA9 RID: 15017 RVA: 0x0009114A File Offset: 0x0008F34A
		public CT_Top10()
		{
			this.topField = true;
			this.percentField = false;
		}

		// Token: 0x170015EC RID: 5612
		// (get) Token: 0x06003AAA RID: 15018 RVA: 0x00091160 File Offset: 0x0008F360
		// (set) Token: 0x06003AAB RID: 15019 RVA: 0x00091168 File Offset: 0x0008F368
		[global::System.ComponentModel.DefaultValue(true)]
		public bool top
		{
			get
			{
				return this.topField;
			}
			set
			{
				this.topField = value;
			}
		}

		// Token: 0x170015ED RID: 5613
		// (get) Token: 0x06003AAC RID: 15020 RVA: 0x00091171 File Offset: 0x0008F371
		// (set) Token: 0x06003AAD RID: 15021 RVA: 0x00091179 File Offset: 0x0008F379
		[global::System.ComponentModel.DefaultValue(false)]
		public bool percent
		{
			get
			{
				return this.percentField;
			}
			set
			{
				this.percentField = value;
			}
		}

		// Token: 0x170015EE RID: 5614
		// (get) Token: 0x06003AAE RID: 15022 RVA: 0x00091182 File Offset: 0x0008F382
		// (set) Token: 0x06003AAF RID: 15023 RVA: 0x0009118A File Offset: 0x0008F38A
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

		// Token: 0x170015EF RID: 5615
		// (get) Token: 0x06003AB0 RID: 15024 RVA: 0x00091193 File Offset: 0x0008F393
		// (set) Token: 0x06003AB1 RID: 15025 RVA: 0x0009119B File Offset: 0x0008F39B
		public double filterVal
		{
			get
			{
				return this.filterValField;
			}
			set
			{
				this.filterValField = value;
			}
		}

		// Token: 0x170015F0 RID: 5616
		// (get) Token: 0x06003AB2 RID: 15026 RVA: 0x000911A4 File Offset: 0x0008F3A4
		// (set) Token: 0x06003AB3 RID: 15027 RVA: 0x000911AC File Offset: 0x0008F3AC
		[global::System.Xml.Serialization.XmlIgnore]
		public bool filterValSpecified
		{
			get
			{
				return this.filterValFieldSpecified;
			}
			set
			{
				this.filterValFieldSpecified = value;
			}
		}

		// Token: 0x04002596 RID: 9622
		private bool topField;

		// Token: 0x04002597 RID: 9623
		private bool percentField;

		// Token: 0x04002598 RID: 9624
		private double valField;

		// Token: 0x04002599 RID: 9625
		private double filterValField;

		// Token: 0x0400259A RID: 9626
		private bool filterValFieldSpecified;
	}
}
