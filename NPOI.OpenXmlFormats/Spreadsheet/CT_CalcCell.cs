using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Spreadsheet
{
	// Token: 0x020005EB RID: 1515
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
	[global::System.Serializable]
	public class CT_CalcCell
	{
		// Token: 0x17001904 RID: 6404
		// (get) Token: 0x0600425E RID: 16990 RVA: 0x0009F66A File Offset: 0x0009D86A
		// (set) Token: 0x0600425F RID: 16991 RVA: 0x0009F672 File Offset: 0x0009D872
		[global::System.Xml.Serialization.XmlAttribute]
		public string r
		{
			get
			{
				return this.rField;
			}
			set
			{
				this.rField = value;
			}
		}

		// Token: 0x17001905 RID: 6405
		// (get) Token: 0x06004260 RID: 16992 RVA: 0x0009F67B File Offset: 0x0009D87B
		// (set) Token: 0x06004261 RID: 16993 RVA: 0x0009F683 File Offset: 0x0009D883
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(0)]
		public int i
		{
			get
			{
				return this.iField;
			}
			set
			{
				this.iField = value;
			}
		}

		// Token: 0x17001906 RID: 6406
		// (get) Token: 0x06004262 RID: 16994 RVA: 0x0009F68C File Offset: 0x0009D88C
		// (set) Token: 0x06004263 RID: 16995 RVA: 0x0009F694 File Offset: 0x0009D894
		[global::System.Xml.Serialization.XmlIgnore]
		public bool iSpecified
		{
			get
			{
				return this.iSpecifiedField;
			}
			set
			{
				this.iSpecifiedField = value;
			}
		}

		// Token: 0x17001907 RID: 6407
		// (get) Token: 0x06004264 RID: 16996 RVA: 0x0009F69D File Offset: 0x0009D89D
		// (set) Token: 0x06004265 RID: 16997 RVA: 0x0009F6A5 File Offset: 0x0009D8A5
		[global::System.Xml.Serialization.XmlAttribute]
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

		// Token: 0x17001908 RID: 6408
		// (get) Token: 0x06004266 RID: 16998 RVA: 0x0009F6AE File Offset: 0x0009D8AE
		// (set) Token: 0x06004267 RID: 16999 RVA: 0x0009F6B6 File Offset: 0x0009D8B6
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(false)]
		public bool l
		{
			get
			{
				return this.lField;
			}
			set
			{
				this.lField = value;
			}
		}

		// Token: 0x17001909 RID: 6409
		// (get) Token: 0x06004268 RID: 17000 RVA: 0x0009F6BF File Offset: 0x0009D8BF
		// (set) Token: 0x06004269 RID: 17001 RVA: 0x0009F6C7 File Offset: 0x0009D8C7
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(false)]
		public bool t
		{
			get
			{
				return this.tField;
			}
			set
			{
				this.tField = value;
			}
		}

		// Token: 0x1700190A RID: 6410
		// (get) Token: 0x0600426A RID: 17002 RVA: 0x0009F6D0 File Offset: 0x0009D8D0
		// (set) Token: 0x0600426B RID: 17003 RVA: 0x0009F6D8 File Offset: 0x0009D8D8
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(false)]
		public bool a
		{
			get
			{
				return this.aField;
			}
			set
			{
				this.aField = value;
			}
		}

		// Token: 0x04002A02 RID: 10754
		private string rField = "";

		// Token: 0x04002A03 RID: 10755
		private int iField;

		// Token: 0x04002A04 RID: 10756
		private bool sField;

		// Token: 0x04002A05 RID: 10757
		private bool lField;

		// Token: 0x04002A06 RID: 10758
		private bool tField;

		// Token: 0x04002A07 RID: 10759
		private bool aField;

		// Token: 0x04002A08 RID: 10760
		private bool iSpecifiedField;
	}
}
