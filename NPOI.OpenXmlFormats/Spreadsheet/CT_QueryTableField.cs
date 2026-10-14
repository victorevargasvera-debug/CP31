using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Spreadsheet
{
	// Token: 0x020005EF RID: 1519
	[global::System.Diagnostics.DebuggerStepThrough]
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_QueryTableField
	{
		// Token: 0x060042C8 RID: 17096 RVA: 0x0009FAA1 File Offset: 0x0009DCA1
		public CT_QueryTableField()
		{
			this.dataBoundField = true;
			this.rowNumbersField = false;
			this.fillFormulasField = false;
			this.clippedField = false;
			this.tableColumnIdField = 0U;
		}

		// Token: 0x17001937 RID: 6455
		// (get) Token: 0x060042C9 RID: 17097 RVA: 0x0009FACC File Offset: 0x0009DCCC
		// (set) Token: 0x060042CA RID: 17098 RVA: 0x0009FAD4 File Offset: 0x0009DCD4
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

		// Token: 0x17001938 RID: 6456
		// (get) Token: 0x060042CB RID: 17099 RVA: 0x0009FADD File Offset: 0x0009DCDD
		// (set) Token: 0x060042CC RID: 17100 RVA: 0x0009FAE5 File Offset: 0x0009DCE5
		[global::System.Xml.Serialization.XmlAttribute]
		public uint id
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

		// Token: 0x17001939 RID: 6457
		// (get) Token: 0x060042CD RID: 17101 RVA: 0x0009FAEE File Offset: 0x0009DCEE
		// (set) Token: 0x060042CE RID: 17102 RVA: 0x0009FAF6 File Offset: 0x0009DCF6
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

		// Token: 0x1700193A RID: 6458
		// (get) Token: 0x060042CF RID: 17103 RVA: 0x0009FAFF File Offset: 0x0009DCFF
		// (set) Token: 0x060042D0 RID: 17104 RVA: 0x0009FB07 File Offset: 0x0009DD07
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(true)]
		public bool dataBound
		{
			get
			{
				return this.dataBoundField;
			}
			set
			{
				this.dataBoundField = value;
			}
		}

		// Token: 0x1700193B RID: 6459
		// (get) Token: 0x060042D1 RID: 17105 RVA: 0x0009FB10 File Offset: 0x0009DD10
		// (set) Token: 0x060042D2 RID: 17106 RVA: 0x0009FB18 File Offset: 0x0009DD18
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(false)]
		public bool rowNumbers
		{
			get
			{
				return this.rowNumbersField;
			}
			set
			{
				this.rowNumbersField = value;
			}
		}

		// Token: 0x1700193C RID: 6460
		// (get) Token: 0x060042D3 RID: 17107 RVA: 0x0009FB21 File Offset: 0x0009DD21
		// (set) Token: 0x060042D4 RID: 17108 RVA: 0x0009FB29 File Offset: 0x0009DD29
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(false)]
		public bool fillFormulas
		{
			get
			{
				return this.fillFormulasField;
			}
			set
			{
				this.fillFormulasField = value;
			}
		}

		// Token: 0x1700193D RID: 6461
		// (get) Token: 0x060042D5 RID: 17109 RVA: 0x0009FB32 File Offset: 0x0009DD32
		// (set) Token: 0x060042D6 RID: 17110 RVA: 0x0009FB3A File Offset: 0x0009DD3A
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(false)]
		public bool clipped
		{
			get
			{
				return this.clippedField;
			}
			set
			{
				this.clippedField = value;
			}
		}

		// Token: 0x1700193E RID: 6462
		// (get) Token: 0x060042D7 RID: 17111 RVA: 0x0009FB43 File Offset: 0x0009DD43
		// (set) Token: 0x060042D8 RID: 17112 RVA: 0x0009FB4B File Offset: 0x0009DD4B
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(typeof(uint), "0")]
		public uint tableColumnId
		{
			get
			{
				return this.tableColumnIdField;
			}
			set
			{
				this.tableColumnIdField = value;
			}
		}

		// Token: 0x04002A35 RID: 10805
		private global::NPOI.OpenXmlFormats.Spreadsheet.CT_ExtensionList extLstField;

		// Token: 0x04002A36 RID: 10806
		private uint idField;

		// Token: 0x04002A37 RID: 10807
		private string nameField;

		// Token: 0x04002A38 RID: 10808
		private bool dataBoundField;

		// Token: 0x04002A39 RID: 10809
		private bool rowNumbersField;

		// Token: 0x04002A3A RID: 10810
		private bool fillFormulasField;

		// Token: 0x04002A3B RID: 10811
		private bool clippedField;

		// Token: 0x04002A3C RID: 10812
		private uint tableColumnIdField;
	}
}
