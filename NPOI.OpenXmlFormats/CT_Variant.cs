using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats
{
	// Token: 0x02000012 RID: 18
	[global::System.Diagnostics.DebuggerStepThrough]
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/officeDocument/2006/docPropsVTypes")]
	[global::System.Serializable]
	public class CT_Variant
	{
		// Token: 0x1700003E RID: 62
		// (get) Token: 0x060000E3 RID: 227 RVA: 0x00002C11 File Offset: 0x00000E11
		// (set) Token: 0x060000E4 RID: 228 RVA: 0x00002C19 File Offset: 0x00000E19
		[global::System.Xml.Serialization.XmlElement]
		public short i2
		{
			get
			{
				return this.i2Field;
			}
			set
			{
				this.i2Field = value;
			}
		}

		// Token: 0x1700003F RID: 63
		// (get) Token: 0x060000E5 RID: 229 RVA: 0x00002C22 File Offset: 0x00000E22
		// (set) Token: 0x060000E6 RID: 230 RVA: 0x00002C2A File Offset: 0x00000E2A
		[global::System.Xml.Serialization.XmlIgnore]
		public bool i2Specified
		{
			get
			{
				return this.i2SpecifiedField;
			}
			set
			{
				this.i2SpecifiedField = value;
			}
		}

		// Token: 0x17000040 RID: 64
		// (get) Token: 0x060000E7 RID: 231 RVA: 0x00002C33 File Offset: 0x00000E33
		// (set) Token: 0x060000E8 RID: 232 RVA: 0x00002C3B File Offset: 0x00000E3B
		[global::System.Xml.Serialization.XmlElement]
		public int i4
		{
			get
			{
				return this.i4Field;
			}
			set
			{
				this.i4Field = value;
			}
		}

		// Token: 0x17000041 RID: 65
		// (get) Token: 0x060000E9 RID: 233 RVA: 0x00002C44 File Offset: 0x00000E44
		// (set) Token: 0x060000EA RID: 234 RVA: 0x00002C4C File Offset: 0x00000E4C
		[global::System.Xml.Serialization.XmlIgnore]
		public bool i4Specified
		{
			get
			{
				return this.i4SpecifiedField;
			}
			set
			{
				this.i4SpecifiedField = value;
			}
		}

		// Token: 0x17000042 RID: 66
		// (get) Token: 0x060000EB RID: 235 RVA: 0x00002C55 File Offset: 0x00000E55
		// (set) Token: 0x060000EC RID: 236 RVA: 0x00002C5D File Offset: 0x00000E5D
		[global::System.Xml.Serialization.XmlElement]
		public long i8
		{
			get
			{
				return this.i8Field;
			}
			set
			{
				this.i8Field = value;
			}
		}

		// Token: 0x17000043 RID: 67
		// (get) Token: 0x060000ED RID: 237 RVA: 0x00002C66 File Offset: 0x00000E66
		// (set) Token: 0x060000EE RID: 238 RVA: 0x00002C6E File Offset: 0x00000E6E
		[global::System.Xml.Serialization.XmlIgnore]
		public bool i8Specified
		{
			get
			{
				return this.i8SpecifiedField;
			}
			set
			{
				this.i8SpecifiedField = value;
			}
		}

		// Token: 0x17000044 RID: 68
		// (get) Token: 0x060000EF RID: 239 RVA: 0x00002C77 File Offset: 0x00000E77
		// (set) Token: 0x060000F0 RID: 240 RVA: 0x00002C7F File Offset: 0x00000E7F
		[global::System.Xml.Serialization.XmlElement]
		public string lpstr
		{
			get
			{
				return this.lpstrField;
			}
			set
			{
				this.lpstrField = value;
			}
		}

		// Token: 0x17000045 RID: 69
		// (get) Token: 0x060000F1 RID: 241 RVA: 0x00002C88 File Offset: 0x00000E88
		// (set) Token: 0x060000F2 RID: 242 RVA: 0x00002C90 File Offset: 0x00000E90
		[global::System.Xml.Serialization.XmlElement]
		public string lpwstr
		{
			get
			{
				return this.lpwstrField;
			}
			set
			{
				this.lpwstrField = value;
			}
		}

		// Token: 0x17000046 RID: 70
		// (get) Token: 0x060000F3 RID: 243 RVA: 0x00002C99 File Offset: 0x00000E99
		// (set) Token: 0x060000F4 RID: 244 RVA: 0x00002CA1 File Offset: 0x00000EA1
		[global::System.Xml.Serialization.XmlElement]
		public float r4
		{
			get
			{
				return this.r4Field;
			}
			set
			{
				this.r4Field = value;
			}
		}

		// Token: 0x17000047 RID: 71
		// (get) Token: 0x060000F5 RID: 245 RVA: 0x00002CAA File Offset: 0x00000EAA
		// (set) Token: 0x060000F6 RID: 246 RVA: 0x00002CB2 File Offset: 0x00000EB2
		[global::System.Xml.Serialization.XmlIgnore]
		public bool r4Specified
		{
			get
			{
				return this.r4SpecifiedField;
			}
			set
			{
				this.r4SpecifiedField = value;
			}
		}

		// Token: 0x17000048 RID: 72
		// (get) Token: 0x060000F7 RID: 247 RVA: 0x00002CBB File Offset: 0x00000EBB
		// (set) Token: 0x060000F8 RID: 248 RVA: 0x00002CC3 File Offset: 0x00000EC3
		[global::System.Xml.Serialization.XmlElement]
		public double r8
		{
			get
			{
				return this.r8Field;
			}
			set
			{
				this.r8Field = value;
			}
		}

		// Token: 0x17000049 RID: 73
		// (get) Token: 0x060000F9 RID: 249 RVA: 0x00002CCC File Offset: 0x00000ECC
		// (set) Token: 0x060000FA RID: 250 RVA: 0x00002CD4 File Offset: 0x00000ED4
		[global::System.Xml.Serialization.XmlIgnore]
		public bool r8Specified
		{
			get
			{
				return this.r8SpecifiedField;
			}
			set
			{
				this.r8SpecifiedField = value;
			}
		}

		// Token: 0x0400007A RID: 122
		private short i2Field;

		// Token: 0x0400007B RID: 123
		private bool i2SpecifiedField;

		// Token: 0x0400007C RID: 124
		private int i4Field;

		// Token: 0x0400007D RID: 125
		private bool i4SpecifiedField;

		// Token: 0x0400007E RID: 126
		private long i8Field;

		// Token: 0x0400007F RID: 127
		private bool i8SpecifiedField;

		// Token: 0x04000080 RID: 128
		private string lpstrField;

		// Token: 0x04000081 RID: 129
		private string lpwstrField;

		// Token: 0x04000082 RID: 130
		private float r4Field;

		// Token: 0x04000083 RID: 131
		private bool r4SpecifiedField;

		// Token: 0x04000084 RID: 132
		private double r8Field;

		// Token: 0x04000085 RID: 133
		private bool r8SpecifiedField;
	}
}
