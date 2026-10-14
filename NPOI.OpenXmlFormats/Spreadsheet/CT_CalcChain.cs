using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Spreadsheet
{
	// Token: 0x020004F3 RID: 1267
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main", ElementName = "calcChain")]
	[global::System.Serializable]
	public class CT_CalcChain
	{
		// Token: 0x06003585 RID: 13701 RVA: 0x00085D9E File Offset: 0x00083F9E
		public int SizeOfCArray()
		{
			return this.c.Count;
		}

		// Token: 0x06003586 RID: 13702 RVA: 0x00085DAB File Offset: 0x00083FAB
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_CalcCell GetCArray(int index)
		{
			return this.c[index];
		}

		// Token: 0x06003587 RID: 13703 RVA: 0x00085DB9 File Offset: 0x00083FB9
		public void AddC(global::NPOI.OpenXmlFormats.Spreadsheet.CT_CalcCell cell)
		{
			this.c.Add(cell);
		}

		// Token: 0x06003588 RID: 13704 RVA: 0x00085DC7 File Offset: 0x00083FC7
		public void RemoveC(int index)
		{
			this.c.RemoveAt(index);
		}

		// Token: 0x1700144D RID: 5197
		// (get) Token: 0x06003589 RID: 13705 RVA: 0x00085DD5 File Offset: 0x00083FD5
		// (set) Token: 0x0600358A RID: 13706 RVA: 0x00085DDD File Offset: 0x00083FDD
		[global::System.Xml.Serialization.XmlElement("c")]
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_CalcCell> c
		{
			get
			{
				return this.cField;
			}
			set
			{
				this.cField = value;
			}
		}

		// Token: 0x1700144E RID: 5198
		// (get) Token: 0x0600358B RID: 13707 RVA: 0x00085DE6 File Offset: 0x00083FE6
		// (set) Token: 0x0600358C RID: 13708 RVA: 0x00085DEE File Offset: 0x00083FEE
		[global::System.Xml.Serialization.XmlElement("extLst")]
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

		// Token: 0x1700144F RID: 5199
		// (get) Token: 0x0600358D RID: 13709 RVA: 0x00085DF7 File Offset: 0x00083FF7
		[global::System.Xml.Serialization.XmlIgnore]
		public bool extLstSpecified
		{
			get
			{
				return this.extLst != null;
			}
		}

		// Token: 0x04002390 RID: 9104
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_CalcCell> cField = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_CalcCell>();

		// Token: 0x04002391 RID: 9105
		private global::NPOI.OpenXmlFormats.Spreadsheet.CT_ExtensionList extLstField;
	}
}
