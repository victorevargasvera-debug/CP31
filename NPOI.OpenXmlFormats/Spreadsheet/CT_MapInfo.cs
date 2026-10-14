using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Spreadsheet
{
	// Token: 0x020005F3 RID: 1523
	[global::System.Diagnostics.DebuggerStepThrough]
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot("MapInfo", Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_MapInfo
	{
		// Token: 0x17001943 RID: 6467
		// (get) Token: 0x060042E3 RID: 17123 RVA: 0x0009FB98 File Offset: 0x0009DD98
		// (set) Token: 0x060042E4 RID: 17124 RVA: 0x0009FBA0 File Offset: 0x0009DDA0
		[global::System.Xml.Serialization.XmlElement("Schema")]
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_Schema> Schema
		{
			get
			{
				return this.schemaField;
			}
			set
			{
				this.schemaField = value;
			}
		}

		// Token: 0x17001944 RID: 6468
		// (get) Token: 0x060042E5 RID: 17125 RVA: 0x0009FBA9 File Offset: 0x0009DDA9
		// (set) Token: 0x060042E6 RID: 17126 RVA: 0x0009FBB1 File Offset: 0x0009DDB1
		[global::System.Xml.Serialization.XmlElement("Map")]
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_Map> Map
		{
			get
			{
				return this.mapField;
			}
			set
			{
				this.mapField = value;
			}
		}

		// Token: 0x17001945 RID: 6469
		// (get) Token: 0x060042E7 RID: 17127 RVA: 0x0009FBBA File Offset: 0x0009DDBA
		// (set) Token: 0x060042E8 RID: 17128 RVA: 0x0009FBC2 File Offset: 0x0009DDC2
		[global::System.Xml.Serialization.XmlAttribute]
		public string SelectionNamespaces
		{
			get
			{
				return this.selectionNamespacesField;
			}
			set
			{
				this.selectionNamespacesField = value;
			}
		}

		// Token: 0x04002A45 RID: 10821
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_Schema> schemaField = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_Schema>();

		// Token: 0x04002A46 RID: 10822
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_Map> mapField = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_Map>();

		// Token: 0x04002A47 RID: 10823
		private string selectionNamespacesField = string.Empty;
	}
}
