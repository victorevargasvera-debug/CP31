using System;
using System.Globalization;
using Motorola.Common.CustomException;

namespace CommonUtility
{
	// Token: 0x02000050 RID: 80
	public class SMAConverter
	{
		// Token: 0x060001A9 RID: 425 RVA: 0x0002E2BC File Offset: 0x0002C4BC
		public global::System.DateTime ConvertNumberToDateTime(byte smaNumber)
		{
			short num = (short)1462370304;
			short num2 = num;
			num = (short)1741338543;
			short num3 = num;
			num = (short)396343215;
			switch (num3 == num)
			{
			}
			num = (short)284557313;
			if (num != 0)
			{
			}
			num = (short)1351024640;
			if (num != 0)
			{
			}
			int months = (int)(smaNumber * 3);
			return this.a.AddMonths(months);
		}

		// Token: 0x060001AA RID: 426 RVA: 0x0002E378 File Offset: 0x0002C578
		public byte ConvertDateTimeToNumber(global::System.DateTime smaDate)
		{
			int a_ = 17;
			int num;
			short num2;
			int num4;
			switch (0)
			{
			case 0:
				break;
			default:
				for (;;)
				{
					IL_13:
					switch (num)
					{
					case 0:
					{
						num2 = (short)1039859712;
						short num3 = num2;
						if (num4 >= 0)
						{
							num2 = (short)713031682;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_BB;
					}
					case 1:
						if (num4 > 255)
						{
							num2 = (short)1964507139;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_18A;
					case 2:
					{
						num2 = (short)105167302;
						short num5 = num2;
						num2 = (short)243907014;
						switch ((num5 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_5E;
						default:
							num2 = (short)1995964416;
							if (num2 != 0)
							{
							}
							num2 = (short)981270529;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						break;
					}
					case 3:
						goto IL_15C;
					}
					goto IL_29;
				}
				IL_BB:
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.ArgumentOutOfRange, string.Format(global::CommonUtility.VersionUtility.b("Ձⵃぅⵇ⑉汋⩍ㅏ♑ㅓ癕⍗橙⅛繝य़ᅡ䑣॥ᵧṩ䱫ŭᙯ剱ٳ᝵ᙷᵹ᥻偽", a_), smaDate));
				IL_15C:
				num2 = (short)1701576705;
				if (num2 != 0)
				{
				}
				goto IL_BB;
				IL_18A:
				return (byte)num4;
			}
			IL_29:
			int num6 = smaDate.Year - this.a.Year;
			num4 = (smaDate.Month - this.a.Month + num6 * 12) / 3;
			IL_5E:
			num2 = (short)777781248;
			num = (int)((global::System.IntPtr)num2);
			goto IL_13;
		}

		// Token: 0x060001AB RID: 427 RVA: 0x0002E514 File Offset: 0x0002C714
		public string ConvertNumberToDateTimeString(byte smaNumber, string dateFormat = "d", global::System.Globalization.CultureInfo culture = null)
		{
			int a_ = 12;
			switch (0)
			{
			case 0:
				goto IL_2D;
			}
			int num;
			short num2;
			string result;
			for (;;)
			{
				IL_13:
				switch (num)
				{
				case 0:
				{
					if (string.IsNullOrWhiteSpace(dateFormat))
					{
						num2 = (short)2109210625;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					global::System.DateTime dateTime;
					result = dateTime.ToString(dateFormat, global::System.Globalization.CultureInfo.InvariantCulture);
					num2 = (short)1359413250;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 1:
				{
					num2 = (short)1231749120;
					short num3 = num2;
					num2 = (short)275578883;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 2:
					return result;
				case 3:
				{
					global::System.DateTime dateTime;
					result = dateTime.ToString(global::CommonUtility.VersionUtility.b("夼", a_), culture ?? new global::System.Globalization.CultureInfo(global::CommonUtility.VersionUtility.b("堼儾汀ᙂᙄ", a_)));
					num2 = (short)203620356;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 4:
					return result;
				}
				goto IL_2D;
			}
			return result;
			for (;;)
			{
				IL_2D:
				num2 = (short)591003649;
				if (num2 != 0)
				{
				}
				global::System.DateTime dateTime = this.ConvertNumberToDateTime(smaNumber);
				num2 = (short)15562869;
				short num4 = num2;
				num2 = (short)40794229;
				switch ((num4 == num2) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					goto IL_93;
				}
			}
			IL_93:
			num2 = (short)488439808;
			if (num2 != 0)
			{
			}
			num2 = (short)1497432064;
			num = (int)((global::System.IntPtr)num2);
			goto IL_13;
		}

		// Token: 0x060001AC RID: 428 RVA: 0x0002E6B8 File Offset: 0x0002C8B8
		public byte ConvertDateTimeStringToByte(string releaseDate, string dateFormat = "d", global::System.Globalization.CultureInfo culture = null)
		{
			short num = (short)371523584;
			short num2 = num;
			num = (short)1300327286;
			short num3 = num;
			num = (short)185363318;
			switch (num3 == num)
			{
			}
			num = (short)1439825920;
			if (num != 0)
			{
			}
			num = (short)1749417985;
			if (num != 0)
			{
			}
			global::System.DateTime smaDate = global::System.DateTime.ParseExact(releaseDate, dateFormat, culture);
			return this.ConvertDateTimeToNumber(smaDate);
		}

		// Token: 0x0400010E RID: 270
		private readonly global::System.DateTime a = new global::System.DateTime(2018, 12, 31);

		// Token: 0x0400010F RID: 271
		private const byte b = 3;

		// Token: 0x04000110 RID: 272
		private const int c = 12;
	}
}
