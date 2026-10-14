using System;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Spreadsheet
{
	// Token: 0x02000558 RID: 1368
	public class CT_RevisionHeader
	{
		// Token: 0x06003B58 RID: 15192 RVA: 0x00092C3A File Offset: 0x00090E3A
		public CT_RevisionHeader()
		{
			this.extLstField = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_ExtensionList();
			this.reviewedListField = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_ReviewedRevisions();
			this.sheetIdMapField = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_SheetIdMap();
		}

		// Token: 0x17001621 RID: 5665
		// (get) Token: 0x06003B59 RID: 15193 RVA: 0x00092C63 File Offset: 0x00090E63
		// (set) Token: 0x06003B5A RID: 15194 RVA: 0x00092C6B File Offset: 0x00090E6B
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_SheetIdMap sheetIdMap
		{
			get
			{
				return this.sheetIdMapField;
			}
			set
			{
				this.sheetIdMapField = value;
			}
		}

		// Token: 0x17001622 RID: 5666
		// (get) Token: 0x06003B5B RID: 15195 RVA: 0x00092C74 File Offset: 0x00090E74
		// (set) Token: 0x06003B5C RID: 15196 RVA: 0x00092C7C File Offset: 0x00090E7C
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_ReviewedRevisions reviewedList
		{
			get
			{
				return this.reviewedListField;
			}
			set
			{
				this.reviewedListField = value;
			}
		}

		// Token: 0x17001623 RID: 5667
		// (get) Token: 0x06003B5D RID: 15197 RVA: 0x00092C85 File Offset: 0x00090E85
		// (set) Token: 0x06003B5E RID: 15198 RVA: 0x00092C8D File Offset: 0x00090E8D
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

		// Token: 0x17001624 RID: 5668
		// (get) Token: 0x06003B5F RID: 15199 RVA: 0x00092C96 File Offset: 0x00090E96
		// (set) Token: 0x06003B60 RID: 15200 RVA: 0x00092C9E File Offset: 0x00090E9E
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

		// Token: 0x17001625 RID: 5669
		// (get) Token: 0x06003B61 RID: 15201 RVA: 0x00092CA7 File Offset: 0x00090EA7
		// (set) Token: 0x06003B62 RID: 15202 RVA: 0x00092CAF File Offset: 0x00090EAF
		public global::System.DateTime dateTime
		{
			get
			{
				return this.dateTimeField;
			}
			set
			{
				this.dateTimeField = value;
			}
		}

		// Token: 0x17001626 RID: 5670
		// (get) Token: 0x06003B63 RID: 15203 RVA: 0x00092CB8 File Offset: 0x00090EB8
		// (set) Token: 0x06003B64 RID: 15204 RVA: 0x00092CC0 File Offset: 0x00090EC0
		public uint maxSheetId
		{
			get
			{
				return this.maxSheetIdField;
			}
			set
			{
				this.maxSheetIdField = value;
			}
		}

		// Token: 0x17001627 RID: 5671
		// (get) Token: 0x06003B65 RID: 15205 RVA: 0x00092CC9 File Offset: 0x00090EC9
		// (set) Token: 0x06003B66 RID: 15206 RVA: 0x00092CD1 File Offset: 0x00090ED1
		public string userName
		{
			get
			{
				return this.userNameField;
			}
			set
			{
				this.userNameField = value;
			}
		}

		// Token: 0x17001628 RID: 5672
		// (get) Token: 0x06003B67 RID: 15207 RVA: 0x00092CDA File Offset: 0x00090EDA
		// (set) Token: 0x06003B68 RID: 15208 RVA: 0x00092CE2 File Offset: 0x00090EE2
		[global::System.Xml.Serialization.XmlAttribute(Form = global::System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://schemas.openxmlformats.org/officeDocument/2006/relationships")]
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

		// Token: 0x17001629 RID: 5673
		// (get) Token: 0x06003B69 RID: 15209 RVA: 0x00092CEB File Offset: 0x00090EEB
		// (set) Token: 0x06003B6A RID: 15210 RVA: 0x00092CF3 File Offset: 0x00090EF3
		public uint minRId
		{
			get
			{
				return this.minRIdField;
			}
			set
			{
				this.minRIdField = value;
			}
		}

		// Token: 0x1700162A RID: 5674
		// (get) Token: 0x06003B6B RID: 15211 RVA: 0x00092CFC File Offset: 0x00090EFC
		// (set) Token: 0x06003B6C RID: 15212 RVA: 0x00092D04 File Offset: 0x00090F04
		[global::System.Xml.Serialization.XmlIgnore]
		public bool minRIdSpecified
		{
			get
			{
				return this.minRIdFieldSpecified;
			}
			set
			{
				this.minRIdFieldSpecified = value;
			}
		}

		// Token: 0x1700162B RID: 5675
		// (get) Token: 0x06003B6D RID: 15213 RVA: 0x00092D0D File Offset: 0x00090F0D
		// (set) Token: 0x06003B6E RID: 15214 RVA: 0x00092D15 File Offset: 0x00090F15
		public uint maxRId
		{
			get
			{
				return this.maxRIdField;
			}
			set
			{
				this.maxRIdField = value;
			}
		}

		// Token: 0x1700162C RID: 5676
		// (get) Token: 0x06003B6F RID: 15215 RVA: 0x00092D1E File Offset: 0x00090F1E
		// (set) Token: 0x06003B70 RID: 15216 RVA: 0x00092D26 File Offset: 0x00090F26
		[global::System.Xml.Serialization.XmlIgnore]
		public bool maxRIdSpecified
		{
			get
			{
				return this.maxRIdFieldSpecified;
			}
			set
			{
				this.maxRIdFieldSpecified = value;
			}
		}

		// Token: 0x04002620 RID: 9760
		private global::NPOI.OpenXmlFormats.Spreadsheet.CT_SheetIdMap sheetIdMapField;

		// Token: 0x04002621 RID: 9761
		private global::NPOI.OpenXmlFormats.Spreadsheet.CT_ReviewedRevisions reviewedListField;

		// Token: 0x04002622 RID: 9762
		private global::NPOI.OpenXmlFormats.Spreadsheet.CT_ExtensionList extLstField;

		// Token: 0x04002623 RID: 9763
		private string guidField;

		// Token: 0x04002624 RID: 9764
		private global::System.DateTime dateTimeField;

		// Token: 0x04002625 RID: 9765
		private uint maxSheetIdField;

		// Token: 0x04002626 RID: 9766
		private string userNameField;

		// Token: 0x04002627 RID: 9767
		private string idField;

		// Token: 0x04002628 RID: 9768
		private uint minRIdField;

		// Token: 0x04002629 RID: 9769
		private bool minRIdFieldSpecified;

		// Token: 0x0400262A RID: 9770
		private uint maxRIdField;

		// Token: 0x0400262B RID: 9771
		private bool maxRIdFieldSpecified;
	}
}
