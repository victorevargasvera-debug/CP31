using System;
using System.ComponentModel;

namespace NPOI.OpenXmlFormats.Spreadsheet
{
	// Token: 0x0200056D RID: 1389
	public class CT_RevisionSheetRename
	{
		// Token: 0x06003CA0 RID: 15520 RVA: 0x000938EE File Offset: 0x00091AEE
		public CT_RevisionSheetRename()
		{
			this.extLstField = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_ExtensionList();
			this.uaField = false;
			this.raField = false;
		}

		// Token: 0x170016BC RID: 5820
		// (get) Token: 0x06003CA1 RID: 15521 RVA: 0x0009390F File Offset: 0x00091B0F
		// (set) Token: 0x06003CA2 RID: 15522 RVA: 0x00093917 File Offset: 0x00091B17
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_ExtensionList extLst
		{
			get
			{
				return this.extLstField;
			}
			set
			{
				this.extLstField = value;
			}
		}

		// Token: 0x170016BD RID: 5821
		// (get) Token: 0x06003CA3 RID: 15523 RVA: 0x00093920 File Offset: 0x00091B20
		// (set) Token: 0x06003CA4 RID: 15524 RVA: 0x00093928 File Offset: 0x00091B28
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

		// Token: 0x170016BE RID: 5822
		// (get) Token: 0x06003CA5 RID: 15525 RVA: 0x00093931 File Offset: 0x00091B31
		// (set) Token: 0x06003CA6 RID: 15526 RVA: 0x00093939 File Offset: 0x00091B39
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

		// Token: 0x170016BF RID: 5823
		// (get) Token: 0x06003CA7 RID: 15527 RVA: 0x00093942 File Offset: 0x00091B42
		// (set) Token: 0x06003CA8 RID: 15528 RVA: 0x0009394A File Offset: 0x00091B4A
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

		// Token: 0x170016C0 RID: 5824
		// (get) Token: 0x06003CA9 RID: 15529 RVA: 0x00093953 File Offset: 0x00091B53
		// (set) Token: 0x06003CAA RID: 15530 RVA: 0x0009395B File Offset: 0x00091B5B
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

		// Token: 0x170016C1 RID: 5825
		// (get) Token: 0x06003CAB RID: 15531 RVA: 0x00093964 File Offset: 0x00091B64
		// (set) Token: 0x06003CAC RID: 15532 RVA: 0x0009396C File Offset: 0x00091B6C
		public string oldName
		{
			get
			{
				return this.oldNameField;
			}
			set
			{
				this.oldNameField = value;
			}
		}

		// Token: 0x170016C2 RID: 5826
		// (get) Token: 0x06003CAD RID: 15533 RVA: 0x00093975 File Offset: 0x00091B75
		// (set) Token: 0x06003CAE RID: 15534 RVA: 0x0009397D File Offset: 0x00091B7D
		public string newName
		{
			get
			{
				return this.newNameField;
			}
			set
			{
				this.newNameField = value;
			}
		}

		// Token: 0x040026C9 RID: 9929
		private global::NPOI.OpenXmlFormats.Spreadsheet.CT_ExtensionList extLstField;

		// Token: 0x040026CA RID: 9930
		private uint rIdField;

		// Token: 0x040026CB RID: 9931
		private bool uaField;

		// Token: 0x040026CC RID: 9932
		private bool raField;

		// Token: 0x040026CD RID: 9933
		private uint sheetIdField;

		// Token: 0x040026CE RID: 9934
		private string oldNameField;

		// Token: 0x040026CF RID: 9935
		private string newNameField;
	}
}
