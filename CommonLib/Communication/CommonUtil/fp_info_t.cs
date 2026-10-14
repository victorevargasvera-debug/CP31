using System;

namespace Motorola.Common.Communication.CommonUtil
{
	// Token: 0x0200003A RID: 58
	[global::System.Serializable]
	public class fp_info_t : global::System.ICloneable
	{
		// Token: 0x0600015F RID: 351 RVA: 0x0001C4F4 File Offset: 0x0001A6F4
		public fp_info_t()
		{
			this.pFPStartAdd = 0U;
			this.pFPEndAdd = 0U;
			this.fp_packs = new global::Motorola.Common.Communication.CommonUtil.fp_version_t[16];
			for (int i = 0; i < this.fp_packs.Length; i++)
			{
				this.fp_packs[i] = new global::Motorola.Common.Communication.CommonUtil.fp_version_t();
			}
		}

		// Token: 0x06000160 RID: 352 RVA: 0x0001C548 File Offset: 0x0001A748
		public object Clone()
		{
			switch (0)
			{
			case 0:
				goto IL_20;
			}
			int num;
			int num2;
			short num3;
			global::Motorola.Common.Communication.CommonUtil.fp_info_t fp_info_t;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					goto IL_56;
				case 1:
					if (num2 >= this.fp_packs.Length)
					{
						num3 = (short)1785593859;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					for (;;)
					{
						fp_info_t.fp_packs[num2] = (global::Motorola.Common.Communication.CommonUtil.fp_version_t)this.fp_packs[num2].Clone();
						num2++;
						num3 = (short)1386348545;
						if (num3 != 0)
						{
						}
						num3 = (short)19427909;
						short num4 = num3;
						num3 = (short)1710060101;
						switch ((num4 == num3) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							goto IL_109;
						}
					}
					IL_109:
					num3 = (short)470351872;
					if (num3 != 0)
					{
					}
					num3 = (short)2093940738;
					num = (int)((global::System.IntPtr)num3);
					continue;
				case 2:
					goto IL_56;
				case 3:
					goto IL_89;
				}
				goto IL_20;
				IL_56:
				num3 = (short)60882945;
				num = (int)((global::System.IntPtr)num3);
			}
			IL_89:
			num3 = (short)2035286016;
			short num5 = num3;
			return fp_info_t;
			IL_20:
			fp_info_t = new global::Motorola.Common.Communication.CommonUtil.fp_info_t();
			fp_info_t.pFPStartAdd = this.pFPStartAdd;
			fp_info_t.pFPEndAdd = this.pFPEndAdd;
			num2 = 0;
			num3 = (short)1663041536;
			num = (int)((global::System.IntPtr)num3);
			goto IL_0A;
		}

		// Token: 0x06000161 RID: 353 RVA: 0x0001C6BC File Offset: 0x0001A8BC
		public void GetDatafromRaw(byte[] raw, uint index)
		{
			switch (0)
			{
			case 0:
				goto IL_20;
			}
			int num;
			int num2;
			short num3;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					goto IL_88;
				case 1:
					if (num2 >= this.fp_packs.Length)
					{
						num3 = (short)1136459779;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					for (;;)
					{
						this.fp_packs[num2].GetDatafromRaw(raw, index);
						index += 8U;
						num2++;
						num3 = (short)783961184;
						short num4 = num3;
						num3 = (short)277761120;
						switch ((num4 == num3) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							goto IL_114;
						}
					}
					IL_114:
					num3 = (short)1157955585;
					if (num3 != 0)
					{
					}
					num3 = (short)1632436224;
					if (num3 != 0)
					{
					}
					num3 = (short)1403584514;
					num = (int)((global::System.IntPtr)num3);
					continue;
				case 2:
					goto IL_88;
				case 3:
					goto IL_C2;
				}
				goto IL_20;
				IL_88:
				num3 = (short)361037825;
				num = (int)((global::System.IntPtr)num3);
			}
			IL_C2:
			num3 = (short)2010841088;
			short num5 = num3;
			return;
			IL_20:
			this.pFPStartAdd = (uint)((int)raw[(int)(index + 3U)] << 24 | (int)raw[(int)(index + 2U)] << 16 | (int)raw[(int)(index + 1U)] << 8 | (int)raw[(int)index]);
			index += 4U;
			this.pFPEndAdd = (uint)((int)raw[(int)(index + 3U)] << 24 | (int)raw[(int)(index + 2U)] << 16 | (int)raw[(int)(index + 1U)] << 8 | (int)raw[(int)index]);
			index += 4U;
			num2 = 0;
			num3 = (short)1220411392;
			num = (int)((global::System.IntPtr)num3);
			goto IL_0A;
		}

		// Token: 0x04000165 RID: 357
		public uint pFPStartAdd;

		// Token: 0x04000166 RID: 358
		public uint pFPEndAdd;

		// Token: 0x04000167 RID: 359
		public global::Motorola.Common.Communication.CommonUtil.fp_version_t[] fp_packs;
	}
}
