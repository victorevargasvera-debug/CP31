using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Spreadsheet
{
	// Token: 0x020005D6 RID: 1494
	public class CT_FutureMetadata
	{
		// Token: 0x060041DF RID: 16863 RVA: 0x0009EFA3 File Offset: 0x0009D1A3
		public CT_FutureMetadata()
		{
			this.extLstField = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_ExtensionList();
			this.bkField = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_FutureMetadataBlock>();
			this.countField = 0U;
		}

		// Token: 0x170018CD RID: 6349
		// (get) Token: 0x060041E0 RID: 16864 RVA: 0x0009EFC8 File Offset: 0x0009D1C8
		// (set) Token: 0x060041E1 RID: 16865 RVA: 0x0009EFD0 File Offset: 0x0009D1D0
		[global::System.Xml.Serialization.XmlElement("bk")]
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_FutureMetadataBlock> bk
		{
			get
			{
				return this.bkField;
			}
			set
			{
				this.bkField = value;
			}
		}

		// Token: 0x170018CE RID: 6350
		// (get) Token: 0x060041E2 RID: 16866 RVA: 0x0009EFD9 File Offset: 0x0009D1D9
		// (set) Token: 0x060041E3 RID: 16867 RVA: 0x0009EFE1 File Offset: 0x0009D1E1
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

		// Token: 0x170018CF RID: 6351
		// (get) Token: 0x060041E4 RID: 16868 RVA: 0x0009EFEA File Offset: 0x0009D1EA
		// (set) Token: 0x060041E5 RID: 16869 RVA: 0x0009EFF2 File Offset: 0x0009D1F2
		[global::System.Xml.Serialization.XmlAttribute]
		public string name
		{
			get
			{
				return this.nameField;
			}
			set
			{
				this.nameField = value;
			}
		}

		// Token: 0x170018D0 RID: 6352
		// (get) Token: 0x060041E6 RID: 16870 RVA: 0x0009EFFB File Offset: 0x0009D1FB
		// (set) Token: 0x060041E7 RID: 16871 RVA: 0x0009F003 File Offset: 0x0009D203
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(typeof(uint), "0")]
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

		// Token: 0x04002977 RID: 10615
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_FutureMetadataBlock> bkField;

		// Token: 0x04002978 RID: 10616
		private global::NPOI.OpenXmlFormats.Spreadsheet.CT_ExtensionList extLstField;

		// Token: 0x04002979 RID: 10617
		private string nameField;

		// Token: 0x0400297A RID: 10618
		private uint countField;
	}
}
