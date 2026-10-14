using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace NPOI.OpenXmlFormats.Spreadsheet
{
	// Token: 0x02000557 RID: 1367
	public class CT_RevisionHeaders
	{
		// Token: 0x06003B3D RID: 15165 RVA: 0x00092AF8 File Offset: 0x00090CF8
		public CT_RevisionHeaders()
		{
			this.headerField = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_RevisionHeader>();
			this.sharedField = true;
			this.diskRevisionsField = false;
			this.historyField = true;
			this.trackRevisionsField = true;
			this.exclusiveField = false;
			this.revisionIdField = 0U;
			this.versionField = 1;
			this.keepChangeHistoryField = true;
			this.protectedField = false;
			this.preserveHistoryField = 30U;
		}

		// Token: 0x17001614 RID: 5652
		// (get) Token: 0x06003B3E RID: 15166 RVA: 0x00092B5D File Offset: 0x00090D5D
		// (set) Token: 0x06003B3F RID: 15167 RVA: 0x00092B65 File Offset: 0x00090D65
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_RevisionHeader> header
		{
			get
			{
				return this.headerField;
			}
			set
			{
				this.headerField = value;
			}
		}

		// Token: 0x17001615 RID: 5653
		// (get) Token: 0x06003B40 RID: 15168 RVA: 0x00092B6E File Offset: 0x00090D6E
		// (set) Token: 0x06003B41 RID: 15169 RVA: 0x00092B76 File Offset: 0x00090D76
		public string guid
		{
			get
			{
				return this.guidField;
			}
			set
			{
				this.guidField = value;
			}
		}

		// Token: 0x17001616 RID: 5654
		// (get) Token: 0x06003B42 RID: 15170 RVA: 0x00092B7F File Offset: 0x00090D7F
		// (set) Token: 0x06003B43 RID: 15171 RVA: 0x00092B87 File Offset: 0x00090D87
		public string lastGuid
		{
			get
			{
				return this.lastGuidField;
			}
			set
			{
				this.lastGuidField = value;
			}
		}

		// Token: 0x17001617 RID: 5655
		// (get) Token: 0x06003B44 RID: 15172 RVA: 0x00092B90 File Offset: 0x00090D90
		// (set) Token: 0x06003B45 RID: 15173 RVA: 0x00092B98 File Offset: 0x00090D98
		[global::System.ComponentModel.DefaultValue(true)]
		public bool shared
		{
			get
			{
				return this.sharedField;
			}
			set
			{
				this.sharedField = value;
			}
		}

		// Token: 0x17001618 RID: 5656
		// (get) Token: 0x06003B46 RID: 15174 RVA: 0x00092BA1 File Offset: 0x00090DA1
		// (set) Token: 0x06003B47 RID: 15175 RVA: 0x00092BA9 File Offset: 0x00090DA9
		[global::System.ComponentModel.DefaultValue(false)]
		public bool diskRevisions
		{
			get
			{
				return this.diskRevisionsField;
			}
			set
			{
				this.diskRevisionsField = value;
			}
		}

		// Token: 0x17001619 RID: 5657
		// (get) Token: 0x06003B48 RID: 15176 RVA: 0x00092BB2 File Offset: 0x00090DB2
		// (set) Token: 0x06003B49 RID: 15177 RVA: 0x00092BBA File Offset: 0x00090DBA
		[global::System.ComponentModel.DefaultValue(true)]
		public bool history
		{
			get
			{
				return this.historyField;
			}
			set
			{
				this.historyField = value;
			}
		}

		// Token: 0x1700161A RID: 5658
		// (get) Token: 0x06003B4A RID: 15178 RVA: 0x00092BC3 File Offset: 0x00090DC3
		// (set) Token: 0x06003B4B RID: 15179 RVA: 0x00092BCB File Offset: 0x00090DCB
		[global::System.ComponentModel.DefaultValue(true)]
		public bool trackRevisions
		{
			get
			{
				return this.trackRevisionsField;
			}
			set
			{
				this.trackRevisionsField = value;
			}
		}

		// Token: 0x1700161B RID: 5659
		// (get) Token: 0x06003B4C RID: 15180 RVA: 0x00092BD4 File Offset: 0x00090DD4
		// (set) Token: 0x06003B4D RID: 15181 RVA: 0x00092BDC File Offset: 0x00090DDC
		[global::System.ComponentModel.DefaultValue(false)]
		public bool exclusive
		{
			get
			{
				return this.exclusiveField;
			}
			set
			{
				this.exclusiveField = value;
			}
		}

		// Token: 0x1700161C RID: 5660
		// (get) Token: 0x06003B4E RID: 15182 RVA: 0x00092BE5 File Offset: 0x00090DE5
		// (set) Token: 0x06003B4F RID: 15183 RVA: 0x00092BED File Offset: 0x00090DED
		[global::System.ComponentModel.DefaultValue(typeof(uint), "0")]
		public uint revisionId
		{
			get
			{
				return this.revisionIdField;
			}
			set
			{
				this.revisionIdField = value;
			}
		}

		// Token: 0x1700161D RID: 5661
		// (get) Token: 0x06003B50 RID: 15184 RVA: 0x00092BF6 File Offset: 0x00090DF6
		// (set) Token: 0x06003B51 RID: 15185 RVA: 0x00092BFE File Offset: 0x00090DFE
		[global::System.ComponentModel.DefaultValue(1)]
		public int version
		{
			get
			{
				return this.versionField;
			}
			set
			{
				this.versionField = value;
			}
		}

		// Token: 0x1700161E RID: 5662
		// (get) Token: 0x06003B52 RID: 15186 RVA: 0x00092C07 File Offset: 0x00090E07
		// (set) Token: 0x06003B53 RID: 15187 RVA: 0x00092C0F File Offset: 0x00090E0F
		[global::System.ComponentModel.DefaultValue(true)]
		public bool keepChangeHistory
		{
			get
			{
				return this.keepChangeHistoryField;
			}
			set
			{
				this.keepChangeHistoryField = value;
			}
		}

		// Token: 0x1700161F RID: 5663
		// (get) Token: 0x06003B54 RID: 15188 RVA: 0x00092C18 File Offset: 0x00090E18
		// (set) Token: 0x06003B55 RID: 15189 RVA: 0x00092C20 File Offset: 0x00090E20
		[global::System.ComponentModel.DefaultValue(false)]
		public bool @protected
		{
			get
			{
				return this.protectedField;
			}
			set
			{
				this.protectedField = value;
			}
		}

		// Token: 0x17001620 RID: 5664
		// (get) Token: 0x06003B56 RID: 15190 RVA: 0x00092C29 File Offset: 0x00090E29
		// (set) Token: 0x06003B57 RID: 15191 RVA: 0x00092C31 File Offset: 0x00090E31
		[global::System.ComponentModel.DefaultValue(typeof(uint), "30")]
		public uint preserveHistory
		{
			get
			{
				return this.preserveHistoryField;
			}
			set
			{
				this.preserveHistoryField = value;
			}
		}

		// Token: 0x04002613 RID: 9747
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_RevisionHeader> headerField;

		// Token: 0x04002614 RID: 9748
		private string guidField;

		// Token: 0x04002615 RID: 9749
		private string lastGuidField;

		// Token: 0x04002616 RID: 9750
		private bool sharedField;

		// Token: 0x04002617 RID: 9751
		private bool diskRevisionsField;

		// Token: 0x04002618 RID: 9752
		private bool historyField;

		// Token: 0x04002619 RID: 9753
		private bool trackRevisionsField;

		// Token: 0x0400261A RID: 9754
		private bool exclusiveField;

		// Token: 0x0400261B RID: 9755
		private uint revisionIdField;

		// Token: 0x0400261C RID: 9756
		private int versionField;

		// Token: 0x0400261D RID: 9757
		private bool keepChangeHistoryField;

		// Token: 0x0400261E RID: 9758
		private bool protectedField;

		// Token: 0x0400261F RID: 9759
		private uint preserveHistoryField;
	}
}
