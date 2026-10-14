using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Spreadsheet
{
	// Token: 0x020005ED RID: 1517
	[global::System.Diagnostics.DebuggerStepThrough]
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_QueryTableRefresh
	{
		// Token: 0x060042AC RID: 17068 RVA: 0x0009F971 File Offset: 0x0009DB71
		public CT_QueryTableRefresh()
		{
			this.preserveSortFilterLayoutField = true;
			this.fieldIdWrappedField = false;
			this.headersInLastRefreshField = true;
			this.minimumVersionField = 0;
			this.nextIdField = 1U;
			this.unboundColumnsLeftField = 0U;
			this.unboundColumnsRightField = 0U;
		}

		// Token: 0x1700192A RID: 6442
		// (get) Token: 0x060042AD RID: 17069 RVA: 0x0009F9AA File Offset: 0x0009DBAA
		// (set) Token: 0x060042AE RID: 17070 RVA: 0x0009F9B2 File Offset: 0x0009DBB2
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_QueryTableFields queryTableFields
		{
			get
			{
				return this.queryTableFieldsField;
			}
			set
			{
				this.queryTableFieldsField = value;
			}
		}

		// Token: 0x1700192B RID: 6443
		// (get) Token: 0x060042AF RID: 17071 RVA: 0x0009F9BB File Offset: 0x0009DBBB
		// (set) Token: 0x060042B0 RID: 17072 RVA: 0x0009F9C3 File Offset: 0x0009DBC3
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_QueryTableDeletedFields queryTableDeletedFields
		{
			get
			{
				return this.queryTableDeletedFieldsField;
			}
			set
			{
				this.queryTableDeletedFieldsField = value;
			}
		}

		// Token: 0x1700192C RID: 6444
		// (get) Token: 0x060042B1 RID: 17073 RVA: 0x0009F9CC File Offset: 0x0009DBCC
		// (set) Token: 0x060042B2 RID: 17074 RVA: 0x0009F9D4 File Offset: 0x0009DBD4
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_SortState sortState
		{
			get
			{
				return this.sortStateField;
			}
			set
			{
				this.sortStateField = value;
			}
		}

		// Token: 0x1700192D RID: 6445
		// (get) Token: 0x060042B3 RID: 17075 RVA: 0x0009F9DD File Offset: 0x0009DBDD
		// (set) Token: 0x060042B4 RID: 17076 RVA: 0x0009F9E5 File Offset: 0x0009DBE5
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

		// Token: 0x1700192E RID: 6446
		// (get) Token: 0x060042B5 RID: 17077 RVA: 0x0009F9EE File Offset: 0x0009DBEE
		// (set) Token: 0x060042B6 RID: 17078 RVA: 0x0009F9F6 File Offset: 0x0009DBF6
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(true)]
		public bool preserveSortFilterLayout
		{
			get
			{
				return this.preserveSortFilterLayoutField;
			}
			set
			{
				this.preserveSortFilterLayoutField = value;
			}
		}

		// Token: 0x1700192F RID: 6447
		// (get) Token: 0x060042B7 RID: 17079 RVA: 0x0009F9FF File Offset: 0x0009DBFF
		// (set) Token: 0x060042B8 RID: 17080 RVA: 0x0009FA07 File Offset: 0x0009DC07
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(false)]
		public bool fieldIdWrapped
		{
			get
			{
				return this.fieldIdWrappedField;
			}
			set
			{
				this.fieldIdWrappedField = value;
			}
		}

		// Token: 0x17001930 RID: 6448
		// (get) Token: 0x060042B9 RID: 17081 RVA: 0x0009FA10 File Offset: 0x0009DC10
		// (set) Token: 0x060042BA RID: 17082 RVA: 0x0009FA18 File Offset: 0x0009DC18
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(true)]
		public bool headersInLastRefresh
		{
			get
			{
				return this.headersInLastRefreshField;
			}
			set
			{
				this.headersInLastRefreshField = value;
			}
		}

		// Token: 0x17001931 RID: 6449
		// (get) Token: 0x060042BB RID: 17083 RVA: 0x0009FA21 File Offset: 0x0009DC21
		// (set) Token: 0x060042BC RID: 17084 RVA: 0x0009FA29 File Offset: 0x0009DC29
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(typeof(byte), "0")]
		public byte minimumVersion
		{
			get
			{
				return this.minimumVersionField;
			}
			set
			{
				this.minimumVersionField = value;
			}
		}

		// Token: 0x17001932 RID: 6450
		// (get) Token: 0x060042BD RID: 17085 RVA: 0x0009FA32 File Offset: 0x0009DC32
		// (set) Token: 0x060042BE RID: 17086 RVA: 0x0009FA3A File Offset: 0x0009DC3A
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(typeof(uint), "1")]
		public uint nextId
		{
			get
			{
				return this.nextIdField;
			}
			set
			{
				this.nextIdField = value;
			}
		}

		// Token: 0x17001933 RID: 6451
		// (get) Token: 0x060042BF RID: 17087 RVA: 0x0009FA43 File Offset: 0x0009DC43
		// (set) Token: 0x060042C0 RID: 17088 RVA: 0x0009FA4B File Offset: 0x0009DC4B
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(typeof(uint), "0")]
		public uint unboundColumnsLeft
		{
			get
			{
				return this.unboundColumnsLeftField;
			}
			set
			{
				this.unboundColumnsLeftField = value;
			}
		}

		// Token: 0x17001934 RID: 6452
		// (get) Token: 0x060042C1 RID: 17089 RVA: 0x0009FA54 File Offset: 0x0009DC54
		// (set) Token: 0x060042C2 RID: 17090 RVA: 0x0009FA5C File Offset: 0x0009DC5C
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(typeof(uint), "0")]
		public uint unboundColumnsRight
		{
			get
			{
				return this.unboundColumnsRightField;
			}
			set
			{
				this.unboundColumnsRightField = value;
			}
		}

		// Token: 0x04002A28 RID: 10792
		private global::NPOI.OpenXmlFormats.Spreadsheet.CT_QueryTableFields queryTableFieldsField;

		// Token: 0x04002A29 RID: 10793
		private global::NPOI.OpenXmlFormats.Spreadsheet.CT_QueryTableDeletedFields queryTableDeletedFieldsField;

		// Token: 0x04002A2A RID: 10794
		private global::NPOI.OpenXmlFormats.Spreadsheet.CT_SortState sortStateField;

		// Token: 0x04002A2B RID: 10795
		private global::NPOI.OpenXmlFormats.Spreadsheet.CT_ExtensionList extLstField;

		// Token: 0x04002A2C RID: 10796
		private bool preserveSortFilterLayoutField;

		// Token: 0x04002A2D RID: 10797
		private bool fieldIdWrappedField;

		// Token: 0x04002A2E RID: 10798
		private bool headersInLastRefreshField;

		// Token: 0x04002A2F RID: 10799
		private byte minimumVersionField;

		// Token: 0x04002A30 RID: 10800
		private uint nextIdField;

		// Token: 0x04002A31 RID: 10801
		private uint unboundColumnsLeftField;

		// Token: 0x04002A32 RID: 10802
		private uint unboundColumnsRightField;
	}
}
