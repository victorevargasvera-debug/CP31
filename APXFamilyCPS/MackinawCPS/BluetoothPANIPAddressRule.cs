using System;
using System.Globalization;
using System.Net;
using System.Windows.Controls;
using PreEmptive.SoS.Runtime;

namespace MackinawCPS
{
	// Token: 0x02000026 RID: 38
	public class BluetoothPANIPAddressRule : global::System.Windows.Controls.ValidationRule
	{
		// Token: 0x06000082 RID: 130 RVA: 0x0000F19C File Offset: 0x0000D39C
		public override global::System.Windows.Controls.ValidationResult Validate(object value, global::System.Globalization.CultureInfo cultureInfo)
		{
			short num = (short)1077887100;
			short num2 = num;
			num = (short)1509965948;
			int num4;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
			{
				IL_C6:
				num = (short)402718720;
				short num3 = num;
				num = (short)1314324481;
				num4 = (int)((global::System.IntPtr)num);
				break;
			}
			default:
				num = (short)1342111745;
				if (num != 0)
				{
				}
				num = (short)418906112;
				if (num != 0)
				{
				}
				num = (short)1702559746;
				num4 = (int)((global::System.IntPtr)num);
				break;
			}
			for (;;)
			{
				switch (num4)
				{
				case 0:
					goto IL_128;
				case 1:
					if (global::MackinawCPS.BluetoothPANIPAddressRule.IsValidBluetoothPANIPAddress(value.ToString()))
					{
						num = (short)153026560;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_132;
				case 2:
					switch (0)
					{
					case 0:
						goto IL_A6;
					}
					continue;
				case 3:
					goto IL_BE;
				}
				IL_A6:
				if (value != null)
				{
					goto IL_C6;
				}
				num = (short)1174339587;
				num4 = (int)((global::System.IntPtr)num);
			}
			IL_BE:
			return new global::System.Windows.Controls.ValidationResult(false, null);
			IL_128:
			return global::System.Windows.Controls.ValidationResult.ValidResult;
			IL_132:
			return new global::System.Windows.Controls.ValidationResult(false, null);
		}

		// Token: 0x06000083 RID: 131 RVA: 0x0000F2E4 File Offset: 0x0000D4E4
		public static bool IsValidBluetoothPANIPAddress(string strIPAddress)
		{
			int a_ = 10;
			bool result = true;
			short num;
			try
			{
				num = (short)1124073474;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					global::System.Net.IPAddress ipaddress;
					switch (num2)
					{
					case 0:
					{
						string[] array;
						if (array.Length == 4)
						{
							num = (short)1040318484;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						result = false;
						num = (short)1280049158;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 1:
						goto IL_3D0;
					case 2:
						switch (0)
						{
						case 0:
							goto IL_89;
						}
						continue;
					case 3:
						goto IL_381;
					case 4:
						IL_3CB:
						num = (short)1021509653;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
					{
						string[] array;
						if (array[2] != global::PreEmptive.SoS.Runtime.FixedLengthStream.b("\udae9", a_))
						{
							num = (short)1700462596;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2A3;
					}
					case 6:
						goto IL_3D0;
					case 7:
						goto IL_3E7;
					case 8:
						goto IL_3D0;
					case 9:
						num = (short)1329397774;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 10:
						goto IL_13A;
					case 11:
					{
						string[] array;
						if (!array[1].StartsWith(global::PreEmptive.SoS.Runtime.FixedLengthStream.b("\udae9", a_)))
						{
							num = (short)1661403139;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_13A;
					}
					case 12:
						goto IL_3D0;
					case 13:
						num = (short)870842369;
						if (num != 0)
						{
						}
						num = (short)353763339;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 14:
					{
						if (ipaddress.GetAddressBytes()[3] != 1)
						{
							num = (short)208928785;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						string[] array = strIPAddress.Split(new char[]
						{
							'.'
						});
						num = (short)92733440;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 15:
					{
						string[] array;
						if (array[1] != global::PreEmptive.SoS.Runtime.FixedLengthStream.b("\udae9", a_))
						{
							num = (short)2063335437;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_381;
					}
					case 16:
						goto IL_3D0;
					case 17:
						result = false;
						num = (short)641400844;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 18:
					{
						string[] array;
						if (array[3].StartsWith(global::PreEmptive.SoS.Runtime.FixedLengthStream.b("\udae9", a_)))
						{
							num = (short)82837514;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						result = true;
						num = (short)166854657;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 19:
						goto IL_2A3;
					case 20:
						num = (short)1754660879;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 21:
					{
						string[] array;
						if (!array[2].StartsWith(global::PreEmptive.SoS.Runtime.FixedLengthStream.b("\udae9", a_)))
						{
							num = (short)500826131;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_13A;
					}
					}
					IL_89:
					if (global::System.Net.IPAddress.TryParse(strIPAddress, out ipaddress))
					{
						num = (short)1305411593;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					result = false;
					num = (short)926941192;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_13A:
					num = (short)553014675;
					short num3 = num;
					num = (short)1857377683;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_3CB;
					default:
						num = (short)2037645312;
						if (num != 0)
						{
						}
						result = false;
						num = (short)1780547600;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_2A3:
					num = (short)908984338;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_381:
					num = (short)1738670085;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_3D0:
					num = (short)116195335;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_3E7:;
			}
			catch
			{
				result = false;
			}
			num = (short)1916928000;
			short num4 = num;
			return result;
		}

		// Token: 0x0400003B RID: 59
		[global::System.NonSerialized]
		string VafgnaprSvryq = 32;
	}
}
