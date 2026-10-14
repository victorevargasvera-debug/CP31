using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Spreadsheet
{
	// Token: 0x020005FE RID: 1534
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_DdeValues
	{
		// Token: 0x06004353 RID: 17235 RVA: 0x000A0367 File Offset: 0x0009E567
		public CT_DdeValues()
		{
			this.rowsField = 1U;
			this.colsField = 1U;
		}

		// Token: 0x1700196F RID: 6511
		// (get) Token: 0x06004354 RID: 17236 RVA: 0x000A037D File Offset: 0x0009E57D
		// (set) Token: 0x06004355 RID: 17237 RVA: 0x000A0385 File Offset: 0x0009E585
		[global::System.Xml.Serialization.XmlElement("value")]
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_DdeValue[] value
		{
			get
			{
				return this.valueField;
			}
			set
			{
				this.valueField = value;
			}
		}

		// Token: 0x17001970 RID: 6512
		// (get) Token: 0x06004356 RID: 17238 RVA: 0x000A038E File Offset: 0x0009E58E
		// (set) Token: 0x06004357 RID: 17239 RVA: 0x000A0396 File Offset: 0x0009E596
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(typeof(uint), "1")]
		public uint rows
		{
			get
			{
				return this.rowsField;
			}
			set
			{
				this.rowsField = value;
			}
		}

		// Token: 0x17001971 RID: 6513
		// (get) Token: 0x06004358 RID: 17240 RVA: 0x000A039F File Offset: 0x0009E59F
		// (set) Token: 0x06004359 RID: 17241 RVA: 0x000A03A7 File Offset: 0x0009E5A7
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(typeof(uint), "1")]
		public uint cols
		{
			get
			{
				return this.colsField;
			}
			set
			{
				this.colsField = value;
			}
		}

		// Token: 0x04002A75 RID: 10869
		private global::NPOI.OpenXmlFormats.Spreadsheet.CT_DdeValue[] valueField;

		// Token: 0x04002A76 RID: 10870
		private uint rowsField;

		// Token: 0x04002A77 RID: 10871
		private uint colsField;
	}
}
