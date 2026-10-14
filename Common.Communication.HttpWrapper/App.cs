using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

namespace Motorola.Common.Communication
{
	// Token: 0x0200002C RID: 44
	[global::System.Runtime.Serialization.DataContract]
	public class App
	{
		// Token: 0x17000022 RID: 34
		// (get) Token: 0x0600009B RID: 155 RVA: 0x000095A4 File Offset: 0x000077A4
		// (set) Token: 0x0600009C RID: 156 RVA: 0x00009654 File Offset: 0x00007854
		[global::System.Runtime.Serialization.DataMember]
		public string appName
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1149579911;
				short num2 = num;
				num = (short)374026887;
				switch (num2 == num)
				{
				}
				num = (short)1191575553;
				if (num != 0)
				{
				}
				num = (short)265814016;
				if (num != 0)
				{
				}
				num = (short)1387528192;
				short num3 = num;
				return this.a;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)552851305;
				short num2 = num;
				num = (short)652138345;
				switch (num2 == num)
				{
				}
				num = (short)1792802817;
				if (num != 0)
				{
				}
				num = (short)924647424;
				if (num != 0)
				{
				}
				num = (short)235995136;
				short num3 = num;
				this.a = value;
			}
		}

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x0600009D RID: 157 RVA: 0x00009704 File Offset: 0x00007904
		// (set) Token: 0x0600009E RID: 158 RVA: 0x000097B4 File Offset: 0x000079B4
		[global::System.Runtime.Serialization.DataMember]
		public string appLabel
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)2100067549;
				short num2 = num;
				num = (short)425884893;
				switch (num2 == num)
				{
				}
				num = (short)1725693953;
				if (num != 0)
				{
				}
				num = (short)1249771520;
				if (num != 0)
				{
				}
				num = (short)1700069376;
				short num3 = num;
				return this.b;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)247859764;
				short num2 = num;
				num = (short)2079263284;
				switch (num2 == num)
				{
				}
				num = (short)1717501953;
				if (num != 0)
				{
				}
				num = (short)707788800;
				if (num != 0)
				{
				}
				num = (short)1163264000;
				short num3 = num;
				this.b = value;
			}
		}

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x0600009F RID: 159 RVA: 0x00009868 File Offset: 0x00007A68
		// (set) Token: 0x060000A0 RID: 160 RVA: 0x00009918 File Offset: 0x00007B18
		[global::System.Runtime.Serialization.DataMember]
		public int versionCode
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1947673009;
				short num2 = num;
				num = (short)153362865;
				switch (num2 == num)
				{
				}
				num = (short)391053313;
				if (num != 0)
				{
				}
				num = (short)556728320;
				if (num != 0)
				{
				}
				num = (short)282263552;
				short num3 = num;
				return this.c;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1176019935;
				short num2 = num;
				num = (short)1534698463;
				switch (num2 == num)
				{
				}
				num = (short)622919681;
				if (num != 0)
				{
				}
				num = (short)941096960;
				if (num != 0)
				{
				}
				num = (short)370540544;
				short num3 = num;
				this.c = value;
			}
		}

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x060000A1 RID: 161 RVA: 0x000099C8 File Offset: 0x00007BC8
		// (set) Token: 0x060000A2 RID: 162 RVA: 0x00009A7C File Offset: 0x00007C7C
		[global::System.Runtime.Serialization.DataMember]
		public string versionName
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)982235165;
				short num2 = num;
				num = (short)754759709;
				switch (num2 == num)
				{
				}
				num = (short)77135873;
				if (num != 0)
				{
				}
				num = (short)431423488;
				if (num != 0)
				{
				}
				num = (short)845611008;
				short num3 = num;
				return this.d;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1513523919;
				short num2 = num;
				num = (short)714771151;
				switch (num2 == num)
				{
				}
				num = (short)1262813184;
				if (num != 0)
				{
				}
				num = (short)1791885313;
				if (num != 0)
				{
				}
				num = (short)914685952;
				short num3 = num;
				this.d = value;
			}
		}

		// Token: 0x060000A3 RID: 163 RVA: 0x00009B30 File Offset: 0x00007D30
		public App(string name, string label, int code, string vname)
		{
			this.appName = name;
			this.appLabel = label;
			this.versionCode = code;
			this.versionName = vname;
		}

		// Token: 0x0400005E RID: 94
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private string a;

		// Token: 0x0400005F RID: 95
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private string b;

		// Token: 0x04000060 RID: 96
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private int c;

		// Token: 0x04000061 RID: 97
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private string d;
	}
}
