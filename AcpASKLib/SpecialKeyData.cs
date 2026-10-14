using System;
using AcpKeyValidatorLib;

namespace AcpASKLib
{
	// Token: 0x02000039 RID: 57
	public class SpecialKeyData
	{
		// Token: 0x06000184 RID: 388 RVA: 0x00029A88 File Offset: 0x00027C88
		internal SpecialKeyData(string A_0, global::AcpKeyValidatorLib.HardwareKeyType A_1)
		{
			this.a = A_0;
			this.b = A_1;
		}

		// Token: 0x17000074 RID: 116
		// (get) Token: 0x06000185 RID: 389 RVA: 0x00029AAC File Offset: 0x00027CAC
		internal global::AcpKeyValidatorLib.HardwareKeyType Type
		{
			get
			{
				short num = (short)798985984;
				short num2 = num;
				num = (short)1719832320;
				switch (num2 == num)
				{
				}
				num = (short)190971905;
				if (num != 0)
				{
				}
				num = (short)1971585024;
				short num3 = num;
				num = (short)1760100352;
				if (num != 0)
				{
				}
				return this.b;
			}
		}

		// Token: 0x17000075 RID: 117
		// (get) Token: 0x06000186 RID: 390 RVA: 0x00029B5C File Offset: 0x00027D5C
		internal string iBtnSerialNum
		{
			get
			{
				short num = (short)1508178378;
				short num2 = num;
				num = (short)962918858;
				switch (num2 == num)
				{
				}
				num = (short)1306525697;
				if (num != 0)
				{
				}
				num = (short)1715339264;
				short num3 = num;
				num = (short)884342784;
				if (num != 0)
				{
				}
				return this.a;
			}
		}

		// Token: 0x040001C9 RID: 457
		private string a;

		// Token: 0x040001CA RID: 458
		private global::AcpKeyValidatorLib.HardwareKeyType b;
	}
}
