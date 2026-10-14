using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Spreadsheet
{
	// Token: 0x0200056E RID: 1390
	public class CT_Users
	{
		// Token: 0x06003CAF RID: 15535 RVA: 0x00093986 File Offset: 0x00091B86
		public CT_Users()
		{
			this.userInfoField = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_SharedUser>();
		}

		// Token: 0x170016C3 RID: 5827
		// (get) Token: 0x06003CB0 RID: 15536 RVA: 0x00093999 File Offset: 0x00091B99
		// (set) Token: 0x06003CB1 RID: 15537 RVA: 0x000939A1 File Offset: 0x00091BA1
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_SharedUser> userInfo
		{
			get
			{
				return this.userInfoField;
			}
			set
			{
				this.userInfoField = value;
			}
		}

		// Token: 0x170016C4 RID: 5828
		// (get) Token: 0x06003CB2 RID: 15538 RVA: 0x000939AA File Offset: 0x00091BAA
		// (set) Token: 0x06003CB3 RID: 15539 RVA: 0x000939B2 File Offset: 0x00091BB2
		public uint count
		{
			get
			{
				return this.countField;
			}
			set
			{
				this.countField = value;
			}
		}

		// Token: 0x170016C5 RID: 5829
		// (get) Token: 0x06003CB4 RID: 15540 RVA: 0x000939BB File Offset: 0x00091BBB
		// (set) Token: 0x06003CB5 RID: 15541 RVA: 0x000939C3 File Offset: 0x00091BC3
		[global::System.Xml.Serialization.XmlIgnore]
		public bool countSpecified
		{
			get
			{
				return this.countFieldSpecified;
			}
			set
			{
				this.countFieldSpecified = value;
			}
		}

		// Token: 0x040026D0 RID: 9936
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_SharedUser> userInfoField;

		// Token: 0x040026D1 RID: 9937
		private uint countField;

		// Token: 0x040026D2 RID: 9938
		private bool countFieldSpecified;
	}
}
