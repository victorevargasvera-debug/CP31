using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Spreadsheet
{
	// Token: 0x020004F9 RID: 1273
	[global::System.Diagnostics.DebuggerStepThrough]
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(ElementName = "sst", Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_Sst
	{
		// Token: 0x06003624 RID: 13860 RVA: 0x000873C9 File Offset: 0x000855C9
		public CT_Sst()
		{
			this.siField = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_Rst>();
		}

		// Token: 0x17001479 RID: 5241
		// (get) Token: 0x06003625 RID: 13861 RVA: 0x000873DC File Offset: 0x000855DC
		// (set) Token: 0x06003626 RID: 13862 RVA: 0x000873E4 File Offset: 0x000855E4
		[global::System.Xml.Serialization.XmlElement]
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_Rst> si
		{
			get
			{
				return this.siField;
			}
			set
			{
				this.siField = value;
			}
		}

		// Token: 0x1700147A RID: 5242
		// (get) Token: 0x06003627 RID: 13863 RVA: 0x000873ED File Offset: 0x000855ED
		// (set) Token: 0x06003628 RID: 13864 RVA: 0x000873F5 File Offset: 0x000855F5
		[global::System.Xml.Serialization.XmlElement]
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

		// Token: 0x1700147B RID: 5243
		// (get) Token: 0x06003629 RID: 13865 RVA: 0x000873FE File Offset: 0x000855FE
		// (set) Token: 0x0600362A RID: 13866 RVA: 0x00087406 File Offset: 0x00085606
		[global::System.Xml.Serialization.XmlAttribute]
		public int count
		{
			get
			{
				return this.countField;
			}
			set
			{
				this.countField = value;
				this.countFieldSpecified = true;
			}
		}

		// Token: 0x1700147C RID: 5244
		// (get) Token: 0x0600362B RID: 13867 RVA: 0x00087416 File Offset: 0x00085616
		// (set) Token: 0x0600362C RID: 13868 RVA: 0x0008741E File Offset: 0x0008561E
		public bool countSpecified
		{
			get
			{
				return this.countFieldSpecified;
			}
			set
			{
				this.countFieldSpecified = value;
			}
		}

		// Token: 0x1700147D RID: 5245
		// (get) Token: 0x0600362D RID: 13869 RVA: 0x00087427 File Offset: 0x00085627
		// (set) Token: 0x0600362E RID: 13870 RVA: 0x0008742F File Offset: 0x0008562F
		[global::System.Xml.Serialization.XmlAttribute]
		public int uniqueCount
		{
			get
			{
				return this.uniqueCountField;
			}
			set
			{
				this.uniqueCountField = value;
				this.uniqueCountFieldSpecified = true;
			}
		}

		// Token: 0x1700147E RID: 5246
		// (get) Token: 0x0600362F RID: 13871 RVA: 0x0008743F File Offset: 0x0008563F
		// (set) Token: 0x06003630 RID: 13872 RVA: 0x00087447 File Offset: 0x00085647
		public bool uniqueCountSpecified
		{
			get
			{
				return this.uniqueCountFieldSpecified;
			}
			set
			{
				this.uniqueCountFieldSpecified = value;
			}
		}

		// Token: 0x040023AC RID: 9132
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_Rst> siField;

		// Token: 0x040023AD RID: 9133
		private global::NPOI.OpenXmlFormats.Spreadsheet.CT_ExtensionList extLstField;

		// Token: 0x040023AE RID: 9134
		private int countField;

		// Token: 0x040023AF RID: 9135
		private bool countFieldSpecified;

		// Token: 0x040023B0 RID: 9136
		private int uniqueCountField;

		// Token: 0x040023B1 RID: 9137
		private bool uniqueCountFieldSpecified;
	}
}
