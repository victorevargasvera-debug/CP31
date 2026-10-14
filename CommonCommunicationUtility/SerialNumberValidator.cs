using System;
using System.Text;
using System.Text.RegularExpressions;

namespace Motorola.Common.Communication
{
	// Token: 0x0200000D RID: 13
	public static class SerialNumberValidator
	{
		// Token: 0x0600003C RID: 60 RVA: 0x00005F10 File Offset: 0x00004110
		public static bool ValidateSerialNumber(string serialNumber)
		{
			switch (0)
			{
			case 0:
				goto IL_44;
			}
			int num;
			bool result;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					result = true;
					num2 = (short)1015152641;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
					return result;
				case 2:
					num2 = (short)1203306504;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 3:
					if (new global::System.Text.RegularExpressions.Regex("[0-9][0-9][0-9][0-9A-Z-[O]][A-Z-[IO]][A-Z-[IO]][0-9A-Z-[AEIOUY]][0-9A-Z-[AEIOUY]][0-9A-Z-[AEIOUY]][0-9A-Z-[AEIOUY]]").IsMatch(serialNumber))
					{
						num2 = (short)529006596;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				case 4:
				{
					num2 = (short)1371889479;
					short num3 = num2;
					num2 = (short)1260478279;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_19B;
					default:
						num2 = (short)542900224;
						if (num2 != 0)
						{
						}
						result = true;
						num2 = (short)618266630;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 5:
					if (serialNumber.Length == 10)
					{
						num2 = (short)22347785;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				case 6:
					return result;
				case 7:
					goto IL_19B;
				case 8:
					if (char.IsUpper(serialNumber[9]))
					{
						num2 = (short)1871380487;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)192806923;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 9:
					num2 = (short)697565196;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 10:
					try
					{
						num2 = (short)1410203649;
						if (num2 != 0)
						{
						}
						byte[] bytes = global::System.Convert.FromBase64String(serialNumber);
						serialNumber = global::System.Text.Encoding.ASCII.GetString(bytes);
						goto IL_26F;
					}
					catch (global::System.Exception)
					{
						goto IL_26F;
					}
					goto IL_19B;
					IL_26F:
					num2 = (short)1893793797;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 11:
					if (new global::System.Text.RegularExpressions.Regex("[0-9][0-9][0-9][0-9A-Z-[O]][A-Z-[IO]][A-Z-[IO]][0-9A-Z-[IO]][0-9A-Z-[IO]][0-9A-Z-[AEIOUY]][0-9A-Z-[AEIOUY]]").IsMatch(serialNumber))
					{
						num2 = (short)1873281024;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				case 12:
					if (!char.IsUpper(serialNumber[8]))
					{
						num2 = (short)1972174850;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_19B;
				}
				goto IL_44;
				IL_19B:
				num2 = (short)1344798720;
				short num4 = num2;
				num2 = (short)98238467;
				num = (int)((global::System.IntPtr)num2);
			}
			return result;
			IL_44:
			result = false;
			num2 = (short)968491018;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x0600003D RID: 61 RVA: 0x000061D8 File Offset: 0x000043D8
		public static bool IsCBISerialNumber(string serialNumber)
		{
			switch (0)
			{
			case 0:
				goto IL_48;
			}
			int num;
			short num3;
			bool result;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
				{
					int num2;
					if (num2 >= global::Motorola.Common.Communication.SerialNumberValidator.a.Length)
					{
						num3 = (short)1885929481;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					num3 = (short)2136014851;
					num = (int)((global::System.IntPtr)num3);
					continue;
				}
				case 1:
				{
					int num2 = 0;
					num3 = (short)1966669834;
					num = (int)((global::System.IntPtr)num3);
					continue;
				}
				case 2:
					return result;
				case 3:
				{
					int num2;
					byte[] array;
					if (global::Motorola.Common.Communication.SerialNumberValidator.a[num2] != array[num2])
					{
						num3 = (short)911474696;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					num2++;
					num3 = (short)990969861;
					num = (int)((global::System.IntPtr)num3);
					continue;
				}
				case 4:
				{
					num3 = (short)325332355;
					short num4 = num3;
					num3 = (short)1451896195;
					switch ((num4 == num3) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_1E4;
					default:
						goto IL_1CA;
					}
					break;
				}
				case 5:
					goto IL_82;
				case 6:
				{
					byte[] array;
					if (array.Length == global::Motorola.Common.Communication.SerialNumberValidator.a.Length)
					{
						num3 = (short)506396673;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					result = false;
					num3 = (short)125304845;
					num = (int)((global::System.IntPtr)num3);
					continue;
				}
				case 7:
					goto IL_1E4;
				case 8:
				{
					num3 = (short)54722560;
					short num5 = num3;
					result = false;
					num3 = (short)2082406412;
					num = (int)((global::System.IntPtr)num3);
					continue;
				}
				case 9:
					num3 = (short)823394305;
					if (num3 != 0)
					{
					}
					num3 = (short)2060320772;
					num = (int)((global::System.IntPtr)num3);
					continue;
				case 10:
					goto IL_82;
				case 11:
				{
					if (global::Motorola.Common.Communication.SerialNumberValidator.ValidateSerialNumber(serialNumber))
					{
						num3 = (short)1710161927;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					byte[] array = global::System.Convert.FromBase64String(serialNumber);
					num3 = (short)298123270;
					num = (int)((global::System.IntPtr)num3);
					continue;
				}
				case 12:
					goto IL_12C;
				case 13:
					return result;
				}
				goto IL_48;
				IL_82:
				num3 = (short)612958208;
				num = (int)((global::System.IntPtr)num3);
				continue;
				IL_1E4:
				result = false;
				num3 = (short)896663554;
				num = (int)((global::System.IntPtr)num3);
			}
			IL_12C:
			return result;
			IL_1CA:
			num3 = (short)794820608;
			if (num3 != 0)
			{
			}
			return result;
			IL_48:
			result = true;
			num3 = (short)152305675;
			num = (int)((global::System.IntPtr)num3);
			goto IL_0A;
		}

		// Token: 0x0600003E RID: 62 RVA: 0x00006488 File Offset: 0x00004688
		// Note: this type is marked as 'beforefieldinit'.
		static SerialNumberValidator()
		{
			short num = (short)1941762056;
			short num2 = num;
			num = (short)56487944;
			switch (num2 == num)
			{
			}
			num = (short)20709376;
			short num3 = num;
			num = (short)387121153;
			if (num != 0)
			{
			}
			num = (short)1175650304;
			if (num != 0)
			{
			}
			global::Motorola.Common.Communication.SerialNumberValidator.a = new byte[]
			{
				200,
				212,
				221,
				157,
				162,
				204,
				132,
				209,
				157,
				175
			};
		}

		// Token: 0x04000031 RID: 49
		public const short SERIALNUMBERSIZE = 10;

		// Token: 0x04000032 RID: 50
		private static readonly byte[] a;
	}
}
