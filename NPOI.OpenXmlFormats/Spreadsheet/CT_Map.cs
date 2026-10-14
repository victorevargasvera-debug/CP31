using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Spreadsheet
{
	// Token: 0x020005F5 RID: 1525
	[global::System.Diagnostics.DebuggerStepThrough]
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
	[global::System.Serializable]
	public class CT_Map
	{
		// Token: 0x1700194C RID: 6476
		// (get) Token: 0x060042F5 RID: 17141 RVA: 0x0009FC61 File Offset: 0x0009DE61
		// (set) Token: 0x060042F6 RID: 17142 RVA: 0x0009FC69 File Offset: 0x0009DE69
		[global::System.Xml.Serialization.XmlElement]
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_DataBinding DataBinding
		{
			get
			{
				return this.dataBindingField;
			}
			set
			{
				this.dataBindingField = value;
			}
		}

		// Token: 0x1700194D RID: 6477
		// (get) Token: 0x060042F7 RID: 17143 RVA: 0x0009FC72 File Offset: 0x0009DE72
		[global::System.Xml.Serialization.XmlIgnore]
		public bool DataBindingSpecified
		{
			get
			{
				return this.dataBindingField != null;
			}
		}

		// Token: 0x1700194E RID: 6478
		// (get) Token: 0x060042F8 RID: 17144 RVA: 0x0009FC7D File Offset: 0x0009DE7D
		// (set) Token: 0x060042F9 RID: 17145 RVA: 0x0009FC85 File Offset: 0x0009DE85
		[global::System.Xml.Serialization.XmlAttribute]
		public uint ID
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

		// Token: 0x1700194F RID: 6479
		// (get) Token: 0x060042FA RID: 17146 RVA: 0x0009FC8E File Offset: 0x0009DE8E
		// (set) Token: 0x060042FB RID: 17147 RVA: 0x0009FC96 File Offset: 0x0009DE96
		[global::System.Xml.Serialization.XmlAttribute]
		public string Name
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

		// Token: 0x17001950 RID: 6480
		// (get) Token: 0x060042FC RID: 17148 RVA: 0x0009FC9F File Offset: 0x0009DE9F
		// (set) Token: 0x060042FD RID: 17149 RVA: 0x0009FCA7 File Offset: 0x0009DEA7
		[global::System.Xml.Serialization.XmlAttribute]
		public string RootElement
		{
			get
			{
				return this.rootElementField;
			}
			set
			{
				this.rootElementField = value;
			}
		}

		// Token: 0x17001951 RID: 6481
		// (get) Token: 0x060042FE RID: 17150 RVA: 0x0009FCB0 File Offset: 0x0009DEB0
		// (set) Token: 0x060042FF RID: 17151 RVA: 0x0009FCB8 File Offset: 0x0009DEB8
		[global::System.Xml.Serialization.XmlAttribute]
		public string SchemaID
		{
			get
			{
				return this.schemaIDField;
			}
			set
			{
				this.schemaIDField = value;
			}
		}

		// Token: 0x17001952 RID: 6482
		// (get) Token: 0x06004300 RID: 17152 RVA: 0x0009FCC1 File Offset: 0x0009DEC1
		// (set) Token: 0x06004301 RID: 17153 RVA: 0x0009FCC9 File Offset: 0x0009DEC9
		[global::System.Xml.Serialization.XmlAttribute]
		public bool ShowImportExportValidationErrors
		{
			get
			{
				return this.showImportExportValidationErrorsField;
			}
			set
			{
				this.showImportExportValidationErrorsField = value;
			}
		}

		// Token: 0x17001953 RID: 6483
		// (get) Token: 0x06004302 RID: 17154 RVA: 0x0009FCD2 File Offset: 0x0009DED2
		// (set) Token: 0x06004303 RID: 17155 RVA: 0x0009FCDA File Offset: 0x0009DEDA
		[global::System.Xml.Serialization.XmlAttribute]
		public bool AutoFit
		{
			get
			{
				return this.autoFitField;
			}
			set
			{
				this.autoFitField = value;
			}
		}

		// Token: 0x17001954 RID: 6484
		// (get) Token: 0x06004304 RID: 17156 RVA: 0x0009FCE3 File Offset: 0x0009DEE3
		// (set) Token: 0x06004305 RID: 17157 RVA: 0x0009FCEB File Offset: 0x0009DEEB
		[global::System.Xml.Serialization.XmlAttribute]
		public bool Append
		{
			get
			{
				return this.appendField;
			}
			set
			{
				this.appendField = value;
			}
		}

		// Token: 0x17001955 RID: 6485
		// (get) Token: 0x06004306 RID: 17158 RVA: 0x0009FCF4 File Offset: 0x0009DEF4
		// (set) Token: 0x06004307 RID: 17159 RVA: 0x0009FCFC File Offset: 0x0009DEFC
		[global::System.Xml.Serialization.XmlAttribute]
		public bool PreserveSortAFLayout
		{
			get
			{
				return this.preserveSortAFLayoutField;
			}
			set
			{
				this.preserveSortAFLayoutField = value;
			}
		}

		// Token: 0x17001956 RID: 6486
		// (get) Token: 0x06004308 RID: 17160 RVA: 0x0009FD05 File Offset: 0x0009DF05
		// (set) Token: 0x06004309 RID: 17161 RVA: 0x0009FD0D File Offset: 0x0009DF0D
		[global::System.Xml.Serialization.XmlAttribute]
		public bool PreserveFormat
		{
			get
			{
				return this.preserveFormatField;
			}
			set
			{
				this.preserveFormatField = value;
			}
		}

		// Token: 0x04002A4D RID: 10829
		private global::NPOI.OpenXmlFormats.Spreadsheet.CT_DataBinding dataBindingField;

		// Token: 0x04002A4E RID: 10830
		private uint idField;

		// Token: 0x04002A4F RID: 10831
		private string nameField;

		// Token: 0x04002A50 RID: 10832
		private string rootElementField;

		// Token: 0x04002A51 RID: 10833
		private string schemaIDField;

		// Token: 0x04002A52 RID: 10834
		private bool showImportExportValidationErrorsField;

		// Token: 0x04002A53 RID: 10835
		private bool autoFitField;

		// Token: 0x04002A54 RID: 10836
		private bool appendField;

		// Token: 0x04002A55 RID: 10837
		private bool preserveSortAFLayoutField;

		// Token: 0x04002A56 RID: 10838
		private bool preserveFormatField;
	}
}
