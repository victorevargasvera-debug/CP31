using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Spreadsheet
{
	// Token: 0x020005DD RID: 1501
	public class CT_MdxTuple
	{
		// Token: 0x06004202 RID: 16898 RVA: 0x0009F0F7 File Offset: 0x0009D2F7
		public CT_MdxTuple()
		{
			this.nField = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_MetadataStringIndex>();
			this.cField = 0U;
			this.iField = false;
			this.uField = false;
			this.stField = false;
			this.bField = false;
		}

		// Token: 0x170018DC RID: 6364
		// (get) Token: 0x06004203 RID: 16899 RVA: 0x0009F12D File Offset: 0x0009D32D
		// (set) Token: 0x06004204 RID: 16900 RVA: 0x0009F135 File Offset: 0x0009D335
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_MetadataStringIndex> n
		{
			get
			{
				return this.nField;
			}
			set
			{
				this.nField = value;
			}
		}

		// Token: 0x170018DD RID: 6365
		// (get) Token: 0x06004205 RID: 16901 RVA: 0x0009F13E File Offset: 0x0009D33E
		// (set) Token: 0x06004206 RID: 16902 RVA: 0x0009F146 File Offset: 0x0009D346
		[global::System.ComponentModel.DefaultValue(typeof(uint), "0")]
		public uint c
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

		// Token: 0x170018DE RID: 6366
		// (get) Token: 0x06004207 RID: 16903 RVA: 0x0009F14F File Offset: 0x0009D34F
		// (set) Token: 0x06004208 RID: 16904 RVA: 0x0009F157 File Offset: 0x0009D357
		public string ct
		{
			get
			{
				return this.ctField;
			}
			set
			{
				this.ctField = value;
			}
		}

		// Token: 0x170018DF RID: 6367
		// (get) Token: 0x06004209 RID: 16905 RVA: 0x0009F160 File Offset: 0x0009D360
		// (set) Token: 0x0600420A RID: 16906 RVA: 0x0009F168 File Offset: 0x0009D368
		public uint si
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

		// Token: 0x170018E0 RID: 6368
		// (get) Token: 0x0600420B RID: 16907 RVA: 0x0009F171 File Offset: 0x0009D371
		// (set) Token: 0x0600420C RID: 16908 RVA: 0x0009F179 File Offset: 0x0009D379
		[global::System.Xml.Serialization.XmlIgnore]
		public bool siSpecified
		{
			get
			{
				return this.siFieldSpecified;
			}
			set
			{
				this.siFieldSpecified = value;
			}
		}

		// Token: 0x170018E1 RID: 6369
		// (get) Token: 0x0600420D RID: 16909 RVA: 0x0009F182 File Offset: 0x0009D382
		// (set) Token: 0x0600420E RID: 16910 RVA: 0x0009F18A File Offset: 0x0009D38A
		public uint fi
		{
			get
			{
				return this.fiField;
			}
			set
			{
				this.fiField = value;
			}
		}

		// Token: 0x170018E2 RID: 6370
		// (get) Token: 0x0600420F RID: 16911 RVA: 0x0009F193 File Offset: 0x0009D393
		// (set) Token: 0x06004210 RID: 16912 RVA: 0x0009F19B File Offset: 0x0009D39B
		[global::System.Xml.Serialization.XmlIgnore]
		public bool fiSpecified
		{
			get
			{
				return this.fiFieldSpecified;
			}
			set
			{
				this.fiFieldSpecified = value;
			}
		}

		// Token: 0x170018E3 RID: 6371
		// (get) Token: 0x06004211 RID: 16913 RVA: 0x0009F1A4 File Offset: 0x0009D3A4
		// (set) Token: 0x06004212 RID: 16914 RVA: 0x0009F1AC File Offset: 0x0009D3AC
		[global::System.Xml.Serialization.XmlAttribute(DataType = "hexBinary")]
		public byte[] bc
		{
			get
			{
				return this.bcField;
			}
			set
			{
				this.bcField = value;
			}
		}

		// Token: 0x170018E4 RID: 6372
		// (get) Token: 0x06004213 RID: 16915 RVA: 0x0009F1B5 File Offset: 0x0009D3B5
		// (set) Token: 0x06004214 RID: 16916 RVA: 0x0009F1BD File Offset: 0x0009D3BD
		[global::System.Xml.Serialization.XmlAttribute(DataType = "hexBinary")]
		public byte[] fc
		{
			get
			{
				return this.fcField;
			}
			set
			{
				this.fcField = value;
			}
		}

		// Token: 0x170018E5 RID: 6373
		// (get) Token: 0x06004215 RID: 16917 RVA: 0x0009F1C6 File Offset: 0x0009D3C6
		// (set) Token: 0x06004216 RID: 16918 RVA: 0x0009F1CE File Offset: 0x0009D3CE
		[global::System.ComponentModel.DefaultValue(false)]
		public bool i
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

		// Token: 0x170018E6 RID: 6374
		// (get) Token: 0x06004217 RID: 16919 RVA: 0x0009F1D7 File Offset: 0x0009D3D7
		// (set) Token: 0x06004218 RID: 16920 RVA: 0x0009F1DF File Offset: 0x0009D3DF
		[global::System.ComponentModel.DefaultValue(false)]
		public bool u
		{
			get
			{
				return this.uField;
			}
			set
			{
				this.uField = value;
			}
		}

		// Token: 0x170018E7 RID: 6375
		// (get) Token: 0x06004219 RID: 16921 RVA: 0x0009F1E8 File Offset: 0x0009D3E8
		// (set) Token: 0x0600421A RID: 16922 RVA: 0x0009F1F0 File Offset: 0x0009D3F0
		[global::System.ComponentModel.DefaultValue(false)]
		public bool st
		{
			get
			{
				return this.stField;
			}
			set
			{
				this.stField = value;
			}
		}

		// Token: 0x170018E8 RID: 6376
		// (get) Token: 0x0600421B RID: 16923 RVA: 0x0009F1F9 File Offset: 0x0009D3F9
		// (set) Token: 0x0600421C RID: 16924 RVA: 0x0009F201 File Offset: 0x0009D401
		[global::System.ComponentModel.DefaultValue(false)]
		public bool b
		{
			get
			{
				return this.bField;
			}
			set
			{
				this.bField = value;
			}
		}

		// Token: 0x04002995 RID: 10645
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_MetadataStringIndex> nField;

		// Token: 0x04002996 RID: 10646
		private uint cField;

		// Token: 0x04002997 RID: 10647
		private string ctField;

		// Token: 0x04002998 RID: 10648
		private uint siField;

		// Token: 0x04002999 RID: 10649
		private bool siFieldSpecified;

		// Token: 0x0400299A RID: 10650
		private uint fiField;

		// Token: 0x0400299B RID: 10651
		private bool fiFieldSpecified;

		// Token: 0x0400299C RID: 10652
		private byte[] bcField;

		// Token: 0x0400299D RID: 10653
		private byte[] fcField;

		// Token: 0x0400299E RID: 10654
		private bool iField;

		// Token: 0x0400299F RID: 10655
		private bool uField;

		// Token: 0x040029A0 RID: 10656
		private bool stField;

		// Token: 0x040029A1 RID: 10657
		private bool bField;
	}
}
