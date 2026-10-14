using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Dml
{
	// Token: 0x020002EA RID: 746
	[global::System.Diagnostics.DebuggerStepThrough]
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_Path2DArcTo
	{
		// Token: 0x17000ADF RID: 2783
		// (get) Token: 0x06001CF3 RID: 7411 RVA: 0x0004EAF3 File Offset: 0x0004CCF3
		// (set) Token: 0x06001CF4 RID: 7412 RVA: 0x0004EAFB File Offset: 0x0004CCFB
		[global::System.Xml.Serialization.XmlAttribute]
		public string wR
		{
			get
			{
				return this.wrField;
			}
			set
			{
				this.wrField = value;
			}
		}

		// Token: 0x17000AE0 RID: 2784
		// (get) Token: 0x06001CF5 RID: 7413 RVA: 0x0004EB04 File Offset: 0x0004CD04
		// (set) Token: 0x06001CF6 RID: 7414 RVA: 0x0004EB0C File Offset: 0x0004CD0C
		[global::System.Xml.Serialization.XmlAttribute]
		public string hR
		{
			get
			{
				return this.hrField;
			}
			set
			{
				this.hrField = value;
			}
		}

		// Token: 0x17000AE1 RID: 2785
		// (get) Token: 0x06001CF7 RID: 7415 RVA: 0x0004EB15 File Offset: 0x0004CD15
		// (set) Token: 0x06001CF8 RID: 7416 RVA: 0x0004EB1D File Offset: 0x0004CD1D
		[global::System.Xml.Serialization.XmlAttribute]
		public string stAng
		{
			get
			{
				return this.stAngField;
			}
			set
			{
				this.stAngField = value;
			}
		}

		// Token: 0x17000AE2 RID: 2786
		// (get) Token: 0x06001CF9 RID: 7417 RVA: 0x0004EB26 File Offset: 0x0004CD26
		// (set) Token: 0x06001CFA RID: 7418 RVA: 0x0004EB2E File Offset: 0x0004CD2E
		[global::System.Xml.Serialization.XmlAttribute]
		public string swAng
		{
			get
			{
				return this.swAngField;
			}
			set
			{
				this.swAngField = value;
			}
		}

		// Token: 0x04001752 RID: 5970
		private string wrField;

		// Token: 0x04001753 RID: 5971
		private string hrField;

		// Token: 0x04001754 RID: 5972
		private string stAngField;

		// Token: 0x04001755 RID: 5973
		private string swAngField;
	}
}
