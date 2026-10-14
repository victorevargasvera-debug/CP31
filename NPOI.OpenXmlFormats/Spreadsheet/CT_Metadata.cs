using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Spreadsheet
{
	// Token: 0x020005D0 RID: 1488
	[global::System.Diagnostics.DebuggerStepThrough]
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_Metadata
	{
		// Token: 0x06004185 RID: 16773 RVA: 0x0009EB68 File Offset: 0x0009CD68
		public CT_Metadata()
		{
			this.extLstField = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_ExtensionList();
			this.valueMetadataField = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_MetadataBlocks();
			this.cellMetadataField = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_MetadataBlocks();
			this.futureMetadataField = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_FutureMetadata>();
			this.mdxMetadataField = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_MdxMetadata();
			this.metadataStringsField = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_MetadataStrings();
			this.metadataTypesField = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_MetadataTypes();
		}

		// Token: 0x170018A3 RID: 6307
		// (get) Token: 0x06004186 RID: 16774 RVA: 0x0009EBC8 File Offset: 0x0009CDC8
		// (set) Token: 0x06004187 RID: 16775 RVA: 0x0009EBD0 File Offset: 0x0009CDD0
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_MetadataTypes metadataTypes
		{
			get
			{
				return this.metadataTypesField;
			}
			set
			{
				this.metadataTypesField = value;
			}
		}

		// Token: 0x170018A4 RID: 6308
		// (get) Token: 0x06004188 RID: 16776 RVA: 0x0009EBD9 File Offset: 0x0009CDD9
		// (set) Token: 0x06004189 RID: 16777 RVA: 0x0009EBE1 File Offset: 0x0009CDE1
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_MetadataStrings metadataStrings
		{
			get
			{
				return this.metadataStringsField;
			}
			set
			{
				this.metadataStringsField = value;
			}
		}

		// Token: 0x170018A5 RID: 6309
		// (get) Token: 0x0600418A RID: 16778 RVA: 0x0009EBEA File Offset: 0x0009CDEA
		// (set) Token: 0x0600418B RID: 16779 RVA: 0x0009EBF2 File Offset: 0x0009CDF2
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_MdxMetadata mdxMetadata
		{
			get
			{
				return this.mdxMetadataField;
			}
			set
			{
				this.mdxMetadataField = value;
			}
		}

		// Token: 0x170018A6 RID: 6310
		// (get) Token: 0x0600418C RID: 16780 RVA: 0x0009EBFB File Offset: 0x0009CDFB
		// (set) Token: 0x0600418D RID: 16781 RVA: 0x0009EC03 File Offset: 0x0009CE03
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_FutureMetadata> futureMetadata
		{
			get
			{
				return this.futureMetadataField;
			}
			set
			{
				this.futureMetadataField = value;
			}
		}

		// Token: 0x170018A7 RID: 6311
		// (get) Token: 0x0600418E RID: 16782 RVA: 0x0009EC0C File Offset: 0x0009CE0C
		// (set) Token: 0x0600418F RID: 16783 RVA: 0x0009EC14 File Offset: 0x0009CE14
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_MetadataBlocks cellMetadata
		{
			get
			{
				return this.cellMetadataField;
			}
			set
			{
				this.cellMetadataField = value;
			}
		}

		// Token: 0x170018A8 RID: 6312
		// (get) Token: 0x06004190 RID: 16784 RVA: 0x0009EC1D File Offset: 0x0009CE1D
		// (set) Token: 0x06004191 RID: 16785 RVA: 0x0009EC25 File Offset: 0x0009CE25
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_MetadataBlocks valueMetadata
		{
			get
			{
				return this.valueMetadataField;
			}
			set
			{
				this.valueMetadataField = value;
			}
		}

		// Token: 0x170018A9 RID: 6313
		// (get) Token: 0x06004192 RID: 16786 RVA: 0x0009EC2E File Offset: 0x0009CE2E
		// (set) Token: 0x06004193 RID: 16787 RVA: 0x0009EC36 File Offset: 0x0009CE36
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

		// Token: 0x0400294D RID: 10573
		private global::NPOI.OpenXmlFormats.Spreadsheet.CT_MetadataTypes metadataTypesField;

		// Token: 0x0400294E RID: 10574
		private global::NPOI.OpenXmlFormats.Spreadsheet.CT_MetadataStrings metadataStringsField;

		// Token: 0x0400294F RID: 10575
		private global::NPOI.OpenXmlFormats.Spreadsheet.CT_MdxMetadata mdxMetadataField;

		// Token: 0x04002950 RID: 10576
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_FutureMetadata> futureMetadataField;

		// Token: 0x04002951 RID: 10577
		private global::NPOI.OpenXmlFormats.Spreadsheet.CT_MetadataBlocks cellMetadataField;

		// Token: 0x04002952 RID: 10578
		private global::NPOI.OpenXmlFormats.Spreadsheet.CT_MetadataBlocks valueMetadataField;

		// Token: 0x04002953 RID: 10579
		private global::NPOI.OpenXmlFormats.Spreadsheet.CT_ExtensionList extLstField;
	}
}
