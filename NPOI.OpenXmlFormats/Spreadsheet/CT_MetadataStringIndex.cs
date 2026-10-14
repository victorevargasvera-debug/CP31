using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Spreadsheet
{
	// Token: 0x020005DB RID: 1499
	[global::System.Diagnostics.DebuggerStepThrough]
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_MetadataStringIndex
	{
		// Token: 0x060041FD RID: 16893 RVA: 0x0009F0C6 File Offset: 0x0009D2C6
		public CT_MetadataStringIndex()
		{
			this.sField = false;
		}

		// Token: 0x170018DA RID: 6362
		// (get) Token: 0x060041FE RID: 16894 RVA: 0x0009F0D5 File Offset: 0x0009D2D5
		// (set) Token: 0x060041FF RID: 16895 RVA: 0x0009F0DD File Offset: 0x0009D2DD
		public uint x
		{
			get
			{
				return this.xField;
			}
			set
			{
				this.xField = value;
			}
		}

		// Token: 0x170018DB RID: 6363
		// (get) Token: 0x06004200 RID: 16896 RVA: 0x0009F0E6 File Offset: 0x0009D2E6
		// (set) Token: 0x06004201 RID: 16897 RVA: 0x0009F0EE File Offset: 0x0009D2EE
		[global::System.ComponentModel.DefaultValue(false)]
		public bool s
		{
			get
			{
				return this.sField;
			}
			set
			{
				this.sField = value;
			}
		}

		// Token: 0x0400298B RID: 10635
		private uint xField;

		// Token: 0x0400298C RID: 10636
		private bool sField;
	}
}
