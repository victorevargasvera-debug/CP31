using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Spreadsheet
{
	// Token: 0x0200055B RID: 1371
	public class CT_ReviewedRevisions
	{
		// Token: 0x06003B7B RID: 15227 RVA: 0x00092D86 File Offset: 0x00090F86
		public CT_ReviewedRevisions()
		{
			this.reviewedField = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_Reviewed>();
		}

		// Token: 0x17001631 RID: 5681
		// (get) Token: 0x06003B7C RID: 15228 RVA: 0x00092D99 File Offset: 0x00090F99
		// (set) Token: 0x06003B7D RID: 15229 RVA: 0x00092DA1 File Offset: 0x00090FA1
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_Reviewed> reviewed
		{
			get
			{
				return this.reviewedField;
			}
			set
			{
				this.reviewedField = value;
			}
		}

		// Token: 0x17001632 RID: 5682
		// (get) Token: 0x06003B7E RID: 15230 RVA: 0x00092DAA File Offset: 0x00090FAA
		// (set) Token: 0x06003B7F RID: 15231 RVA: 0x00092DB2 File Offset: 0x00090FB2
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

		// Token: 0x17001633 RID: 5683
		// (get) Token: 0x06003B80 RID: 15232 RVA: 0x00092DBB File Offset: 0x00090FBB
		// (set) Token: 0x06003B81 RID: 15233 RVA: 0x00092DC3 File Offset: 0x00090FC3
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

		// Token: 0x04002630 RID: 9776
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_Reviewed> reviewedField;

		// Token: 0x04002631 RID: 9777
		private uint countField;

		// Token: 0x04002632 RID: 9778
		private bool countFieldSpecified;
	}
}
