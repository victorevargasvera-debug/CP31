using System;

namespace Motorola.CommonCPS.RadioManagement.UIModels
{
	// Token: 0x02000053 RID: 83
	public class PreloadSetInfo
	{
		// Token: 0x06000254 RID: 596 RVA: 0x000244E4 File Offset: 0x000226E4
		public PreloadSetInfo(string setType, string setName)
		{
			this.a = setType;
			this.b = setName;
		}

		// Token: 0x170000FD RID: 253
		// (get) Token: 0x06000255 RID: 597 RVA: 0x0002451C File Offset: 0x0002271C
		public string SetType
		{
			get
			{
				short num = (short)1031130372;
				short num2 = num;
				num = (short)1082969348;
				switch (num2 == num)
				{
				}
				num = (short)1782841344;
				if (num != 0)
				{
				}
				num = (short)627834881;
				if (num != 0)
				{
				}
				num = (short)1157234688;
				short num3 = num;
				return this.a;
			}
		}

		// Token: 0x170000FE RID: 254
		// (get) Token: 0x06000256 RID: 598 RVA: 0x000245CC File Offset: 0x000227CC
		public string SetName
		{
			get
			{
				short num = (short)705136400;
				short num2 = num;
				num = (short)602179344;
				switch (num2 == num)
				{
				}
				num = (short)262078464;
				if (num != 0)
				{
				}
				num = (short)1015873537;
				if (num != 0)
				{
				}
				num = (short)129564672;
				short num3 = num;
				return this.b;
			}
		}

		// Token: 0x040000FA RID: 250
		private string a = string.Empty;

		// Token: 0x040000FB RID: 251
		private string b = string.Empty;
	}
}
