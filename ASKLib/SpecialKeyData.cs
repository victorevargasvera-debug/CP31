using System;
using RMKeyValidatorLib;

namespace ASKLib
{
	// Token: 0x0200000D RID: 13
	public class SpecialKeyData
	{
		// Token: 0x06000051 RID: 81 RVA: 0x0000B798 File Offset: 0x00009998
		internal SpecialKeyData(string A_0, global::RMKeyValidatorLib.HardwareKeyType A_1)
		{
			this.a = A_0;
			this.b = A_1;
		}

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x06000052 RID: 82 RVA: 0x0000B7BC File Offset: 0x000099BC
		internal global::RMKeyValidatorLib.HardwareKeyType Type
		{
			get
			{
				short num = (short)1941110784;
				short num2 = num;
				num = (short)1148846081;
				if (num != 0)
				{
				}
				num = (short)842158090;
				short num3 = num;
				num = (short)282677258;
				switch (num3 == num)
				{
				}
				num = (short)1547108352;
				if (num != 0)
				{
				}
				return this.b;
			}
		}

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x06000053 RID: 83 RVA: 0x0000B86C File Offset: 0x00009A6C
		internal string iBtnSerialNum
		{
			get
			{
				short num = (short)1279852544;
				short num2 = num;
				num = (short)697312508;
				short num3 = num;
				num = (short)1084695804;
				switch (num3 == num)
				{
				}
				num = (short)1462108161;
				if (num != 0)
				{
				}
				num = (short)923205632;
				if (num != 0)
				{
				}
				return this.a;
			}
		}

		// Token: 0x0400002A RID: 42
		private string a;

		// Token: 0x0400002B RID: 43
		private global::RMKeyValidatorLib.HardwareKeyType b;
	}
}
