using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Spreadsheet
{
	// Token: 0x02000530 RID: 1328
	public class CT_ColorFilter
	{
		// Token: 0x06003A61 RID: 14945 RVA: 0x00090EC6 File Offset: 0x0008F0C6
		public CT_ColorFilter()
		{
			this.cellColorField = true;
		}

		// Token: 0x170015CC RID: 5580
		// (get) Token: 0x06003A62 RID: 14946 RVA: 0x00090ED5 File Offset: 0x0008F0D5
		// (set) Token: 0x06003A63 RID: 14947 RVA: 0x00090EDD File Offset: 0x0008F0DD
		public uint dxfId
		{
			get
			{
				return this.dxfIdField;
			}
			set
			{
				this.dxfIdField = value;
			}
		}

		// Token: 0x170015CD RID: 5581
		// (get) Token: 0x06003A64 RID: 14948 RVA: 0x00090EE6 File Offset: 0x0008F0E6
		// (set) Token: 0x06003A65 RID: 14949 RVA: 0x00090EEE File Offset: 0x0008F0EE
		[global::System.Xml.Serialization.XmlIgnore]
		public bool dxfIdSpecified
		{
			get
			{
				return this.dxfIdFieldSpecified;
			}
			set
			{
				this.dxfIdFieldSpecified = value;
			}
		}

		// Token: 0x170015CE RID: 5582
		// (get) Token: 0x06003A66 RID: 14950 RVA: 0x00090EF7 File Offset: 0x0008F0F7
		// (set) Token: 0x06003A67 RID: 14951 RVA: 0x00090EFF File Offset: 0x0008F0FF
		[global::System.ComponentModel.DefaultValue(true)]
		public bool cellColor
		{
			get
			{
				return this.cellColorField;
			}
			set
			{
				this.cellColorField = value;
			}
		}

		// Token: 0x04002532 RID: 9522
		private uint dxfIdField;

		// Token: 0x04002533 RID: 9523
		private bool dxfIdFieldSpecified;

		// Token: 0x04002534 RID: 9524
		private bool cellColorField;
	}
}
