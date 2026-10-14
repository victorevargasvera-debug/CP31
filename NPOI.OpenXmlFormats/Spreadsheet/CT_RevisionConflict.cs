using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Spreadsheet
{
	// Token: 0x02000560 RID: 1376
	public class CT_RevisionConflict
	{
		// Token: 0x06003BD2 RID: 15314 RVA: 0x000930FF File Offset: 0x000912FF
		public CT_RevisionConflict()
		{
			this.uaField = false;
			this.raField = false;
		}

		// Token: 0x1700165A RID: 5722
		// (get) Token: 0x06003BD3 RID: 15315 RVA: 0x00093115 File Offset: 0x00091315
		// (set) Token: 0x06003BD4 RID: 15316 RVA: 0x0009311D File Offset: 0x0009131D
		public uint rId
		{
			get
			{
				return this.rIdField;
			}
			set
			{
				this.rIdField = value;
			}
		}

		// Token: 0x1700165B RID: 5723
		// (get) Token: 0x06003BD5 RID: 15317 RVA: 0x00093126 File Offset: 0x00091326
		// (set) Token: 0x06003BD6 RID: 15318 RVA: 0x0009312E File Offset: 0x0009132E
		[global::System.ComponentModel.DefaultValue(false)]
		public bool ua
		{
			get
			{
				return this.uaField;
			}
			set
			{
				this.uaField = value;
			}
		}

		// Token: 0x1700165C RID: 5724
		// (get) Token: 0x06003BD7 RID: 15319 RVA: 0x00093137 File Offset: 0x00091337
		// (set) Token: 0x06003BD8 RID: 15320 RVA: 0x0009313F File Offset: 0x0009133F
		[global::System.ComponentModel.DefaultValue(false)]
		public bool ra
		{
			get
			{
				return this.raField;
			}
			set
			{
				this.raField = value;
			}
		}

		// Token: 0x1700165D RID: 5725
		// (get) Token: 0x06003BD9 RID: 15321 RVA: 0x00093148 File Offset: 0x00091348
		// (set) Token: 0x06003BDA RID: 15322 RVA: 0x00093150 File Offset: 0x00091350
		public uint sheetId
		{
			get
			{
				return this.sheetIdField;
			}
			set
			{
				this.sheetIdField = value;
			}
		}

		// Token: 0x1700165E RID: 5726
		// (get) Token: 0x06003BDB RID: 15323 RVA: 0x00093159 File Offset: 0x00091359
		// (set) Token: 0x06003BDC RID: 15324 RVA: 0x00093161 File Offset: 0x00091361
		[global::System.Xml.Serialization.XmlIgnore]
		public bool sheetIdSpecified
		{
			get
			{
				return this.sheetIdFieldSpecified;
			}
			set
			{
				this.sheetIdFieldSpecified = value;
			}
		}

		// Token: 0x04002659 RID: 9817
		private uint rIdField;

		// Token: 0x0400265A RID: 9818
		private bool uaField;

		// Token: 0x0400265B RID: 9819
		private bool raField;

		// Token: 0x0400265C RID: 9820
		private uint sheetIdField;

		// Token: 0x0400265D RID: 9821
		private bool sheetIdFieldSpecified;
	}
}
