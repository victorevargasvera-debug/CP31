using System;
using System.Collections;
using AcpCryptoLib;
using IBtnWrapperLib;

namespace AcpKeyValidatorLib
{
	// Token: 0x02000003 RID: 3
	public class AcpiButton
	{
		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000004 RID: 4 RVA: 0x000021A0 File Offset: 0x000003A0
		public string SerialNumber
		{
			get
			{
				int a_ = 10;
				switch (0)
				{
				case 0:
					goto IL_31;
				}
				int num;
				short num3;
				string text;
				for (;;)
				{
					IL_13:
					switch (num)
					{
					case 0:
					{
						int num2;
						if (num2 < 0)
						{
							num3 = (short)1657929730;
							num = (int)((global::System.IntPtr)num3);
							continue;
						}
						text += string.Format(global::AcpKeyValidatorLib.AcpKeyValidator.b("Ṥ坦卨፪彬ቮ", a_), this.a[num2]);
						num2--;
						num3 = (short)1868693505;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					case 1:
						goto IL_135;
					case 2:
						goto IL_ED;
					case 3:
					{
						int num2 = 7;
						num3 = (short)1987444741;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					case 4:
						if (this.a != null)
						{
							num3 = (short)1678835715;
							num = (int)((global::System.IntPtr)num3);
							continue;
						}
						return text;
					case 5:
						goto IL_1A2;
					}
					goto IL_31;
				}
				IL_ED:
				return text;
				IL_1A2:
				goto IL_B9;
				IL_31:
				text = null;
				num3 = (short)1504165888;
				short num4 = num3;
				num3 = (short)363773952;
				switch ((num4 == num3) ? 1 : 0)
				{
				case 0:
				case 2:
				{
					IL_135:
					num3 = (short)95289345;
					if (num3 != 0)
					{
					}
					num3 = (short)409534464;
					short num5 = num3;
					break;
				}
				default:
					num3 = (short)1290600448;
					if (num3 != 0)
					{
					}
					num3 = (short)511770628;
					num = (int)((global::System.IntPtr)num3);
					goto IL_13;
				}
				IL_B9:
				num3 = (short)612302848;
				num = (int)((global::System.IntPtr)num3);
				goto IL_13;
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000005 RID: 5 RVA: 0x00002358 File Offset: 0x00000558
		public global::AcpKeyValidatorLib.HardwareKeyType KeyType
		{
			get
			{
				short num = (short)748083608;
				short num2 = num;
				num = (short)1894308248;
				switch (num2 == num)
				{
				}
				num = (short)200605697;
				if (num != 0)
				{
				}
				num = (short)617545728;
				short num3 = num;
				num = (short)2014642176;
				if (num != 0)
				{
				}
				return this.d;
			}
		}

		// Token: 0x06000006 RID: 6 RVA: 0x00002408 File Offset: 0x00000608
		private void a(global::IBtnWrapperLib.IIBtnWrapper A_0, string A_1, ref short A_2, ref short A_3)
		{
			switch (0)
			{
			case 0:
				goto IL_66;
			}
			short num;
			int num3;
			byte[] array;
			for (;;)
			{
				IL_0A:
				num = (short)668222672;
				short num2 = num;
				num = (short)1340032208;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_103;
				default:
					num = (short)520945664;
					if (num != 0)
					{
					}
					switch (num3)
					{
					case 0:
					{
						byte b = array[0];
						this.c = new byte[array.Length - 1];
						global::System.Array.Copy(array, 1, this.c, 0, array.Length - 1);
						num = (short)1005125634;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 1:
						if (array != null)
						{
							num = (short)218759168;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_103;
					case 2:
						goto IL_101;
					}
					goto IL_66;
				}
			}
			IL_101:
			IL_103:
			num = (short)1697054721;
			if (num != 0)
			{
			}
			num = (short)1042939904;
			short num4 = num;
			return;
			IL_66:
			this.a = A_0.GetROMSerialNum();
			this.b = this.a[0];
			array = null;
			A_0.ReadFileAtPage(A_1, ref A_2, ref A_3, out array);
			num = (short)1232338945;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_0A;
		}

		// Token: 0x06000007 RID: 7 RVA: 0x00002568 File Offset: 0x00000768
		public bool IsDepot(global::IBtnWrapperLib.IIBtnWrapper ibtnWrapper, out bool bFullAccess)
		{
			int a_ = 17;
			short num;
			for (;;)
			{
				num = (short)247660544;
				int num2 = (int)num;
				switch (num2)
				{
				default:
				{
					num = (short)1745657158;
					short num3 = num;
					num = (short)81894726;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						goto IL_5D;
					}
					break;
				}
				}
			}
			IL_5D:
			num = (short)403898369;
			if (num != 0)
			{
			}
			num = (short)156368896;
			if (num != 0)
			{
			}
			num = (short)1497825280;
			short num4 = num;
			string a_2 = global::AcpKeyValidatorLib.AcpKeyValidator.b("ⅫⅭ⑯㑱婳䙵", a_);
			short num5 = 80;
			short num6 = 0;
			bool result = false;
			bFullAccess = true;
			try
			{
				switch (0)
				{
				case 0:
					goto IL_FE;
				}
				int num2;
				for (;;)
				{
					IL_E7:
					switch (num2)
					{
					case 0:
						result = true;
						this.d = global::AcpKeyValidatorLib.HardwareKeyType.DEPOT_KEY;
						num = (short)1379860481;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						goto IL_167;
					case 2:
						if (this.a(ibtnWrapper, true, global::AcpKeyValidatorLib.HardwareKeyType.DEPOT_KEY, out bFullAccess))
						{
							num = (short)1063583744;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_167;
					case 3:
						goto IL_17F;
					}
					goto IL_FE;
					IL_167:
					num = (short)1390215171;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_17F:
				return result;
				IL_FE:
				this.a(ibtnWrapper, a_2, ref num5, ref num6);
				num = (short)1863909378;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_E7;
			}
			catch
			{
				result = false;
			}
			return result;
		}

		// Token: 0x06000008 RID: 8 RVA: 0x0000270C File Offset: 0x0000090C
		public bool IsLabTool(global::IBtnWrapperLib.IIBtnWrapper ibtnWrapper, out bool bFullAccess)
		{
			int a_ = 14;
			short num;
			for (;;)
			{
				num = (short)1957822465;
				if (num != 0)
				{
				}
				num = (short)1747255296;
				int num2 = (int)num;
				switch (num2)
				{
				default:
				{
					num = (short)1521109295;
					short num3 = num;
					num = (short)1635076399;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						goto IL_84;
					}
					break;
				}
				}
			}
			IL_84:
			num = (short)204406784;
			if (num != 0)
			{
			}
			num = (short)1095172096;
			short num4 = num;
			string a_2 = global::AcpKeyValidatorLib.AcpKeyValidator.b("⑨⑪㥬⥮彰䍲", a_);
			short num5 = 80;
			short num6 = 0;
			bFullAccess = false;
			bool result = false;
			try
			{
				switch (0)
				{
				case 0:
					goto IL_FE;
				}
				int num2;
				for (;;)
				{
					IL_E7:
					switch (num2)
					{
					case 0:
						result = true;
						this.d = global::AcpKeyValidatorLib.HardwareKeyType.LABTOOL_KEY;
						num = (short)1953431553;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						goto IL_164;
					case 2:
						if (this.a(ibtnWrapper, true, global::AcpKeyValidatorLib.HardwareKeyType.LABTOOL_KEY, out bFullAccess))
						{
							num = (short)1061486592;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_164;
					case 3:
						goto IL_17C;
					}
					goto IL_FE;
					IL_164:
					num = (short)1066860547;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_17C:
				return result;
				IL_FE:
				this.a(ibtnWrapper, a_2, ref num5, ref num6);
				num = (short)27852802;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_E7;
			}
			catch
			{
				result = false;
			}
			return result;
		}

		// Token: 0x06000009 RID: 9 RVA: 0x000028B0 File Offset: 0x00000AB0
		public bool IsFTR(global::IBtnWrapperLib.IIBtnWrapper ibtnWrapper)
		{
			int a_ = 7;
			short num;
			for (;;)
			{
				num = (short)990314497;
				if (num != 0)
				{
				}
				num = (short)1461452800;
				int num2 = (int)num;
				switch (num2)
				{
				default:
				{
					num = (short)1588188963;
					short num3 = num;
					num = (short)984602403;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						goto IL_80;
					}
					break;
				}
				}
			}
			IL_80:
			num = (short)463994880;
			if (num != 0)
			{
			}
			num = (short)963248128;
			short num4 = num;
			string a_2 = global::AcpKeyValidatorLib.AcpKeyValidator.b("⽡≣㉥㩧䑩嵫", a_);
			short num5 = 400;
			short num6 = 0;
			bool result = false;
			try
			{
				switch (0)
				{
				case 0:
					goto IL_F9;
				}
				int num2;
				for (;;)
				{
					IL_E2:
					switch (num2)
					{
					case 0:
						result = true;
						this.d = global::AcpKeyValidatorLib.HardwareKeyType.FTR_KEY;
						num = (short)2012282881;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						goto IL_15E;
					case 2:
						if (this.a(ibtnWrapper, true))
						{
							num = (short)599392256;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_15E;
					case 3:
						goto IL_177;
					}
					goto IL_F9;
					IL_15E:
					num = (short)253558787;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_177:
				return result;
				IL_F9:
				this.a(ibtnWrapper, a_2, ref num5, ref num6);
				num = (short)73662466;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_E2;
			}
			catch
			{
				result = false;
			}
			return result;
		}

		// Token: 0x0600000A RID: 10 RVA: 0x00002A4C File Offset: 0x00000C4C
		private bool a(global::IBtnWrapperLib.IIBtnWrapper A_0, bool A_1, global::AcpKeyValidatorLib.HardwareKeyType A_2, out bool A_3)
		{
			short num = (short)1427111936;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_158;
				}
				byte[] array5;
				bool flag;
				for (;;)
				{
					IL_29:
					byte[] array;
					int num3;
					int num7;
					switch (num2)
					{
					case 0:
					{
						byte[] array2;
						global::System.Array.Copy(array, array2, 4);
						byte[] array3 = new byte[10];
						byte[] a_;
						this.a(ref array3, a_, array2, 8);
						num3 = 0;
						int num4 = 24;
						num = (short)51970093;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 1:
					{
						int num5;
						if (num5 >= 16)
						{
							num = (short)740229163;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						byte[] array4;
						array4[num3++] = array5[num5];
						num5++;
						num = (short)1514340352;
						short num6 = num;
						num = (short)1635909657;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
					{
						byte[] array6;
						if (array5[num7] != array6[num3++])
						{
							num = (short)646250537;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num7++;
						num = (short)633470984;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 3:
						if (this.a == null)
						{
							num = (short)260046866;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1794572322;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
					{
						byte[] array7 = this.a(A_0, this.c);
						array5 = new byte[array7.Length];
						global::System.Array.Copy(array7, array5, array7.Length);
						num = (short)1791754291;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 5:
						if (flag)
						{
							num = (short)1521090612;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_378;
					case 6:
						goto IL_73E;
					case 7:
						goto IL_378;
					case 8:
						goto IL_5F9;
					case 9:
						if (flag)
						{
							num = (short)921239572;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_73E;
					case 10:
						num = (short)887750680;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 11:
						goto IL_378;
					case 12:
						num = (short)198574143;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 13:
					{
						int num8;
						if (num8 >= 10)
						{
							num = (short)949354496;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						byte[] array2;
						array2[num8] = 0;
						num8++;
						num = (short)1346699290;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 14:
					{
						byte[] array6;
						global::System.Array.Copy(global::AcpKeyValidatorLib.a.al, array6, 10);
						num = (short)1515651134;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 15:
						goto IL_460;
					case 16:
						num = (short)1370226725;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 17:
						goto IL_A30;
					case 18:
						goto IL_9D0;
					case 19:
						if (A_2 == global::AcpKeyValidatorLib.HardwareKeyType.DEPOT_KEY)
						{
							num = (short)945946673;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)159383585;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 20:
					{
						byte[] array4 = new byte[6];
						num3 = 0;
						int num5 = 10;
						num = (short)612892744;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 21:
						if (A_2 == global::AcpKeyValidatorLib.HardwareKeyType.LABTOOL_KEY)
						{
							num = (short)998965283;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_77A;
					case 22:
						goto IL_214;
					case 23:
						goto IL_2F6;
					case 24:
						if (this.c.Length >= 1)
						{
							num = (short)1869545527;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_9D0;
					case 25:
						goto IL_B7B;
					case 26:
						goto IL_2F6;
					case 27:
					{
						int num4;
						if (num4 >= 34)
						{
							num = (short)424280133;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)909312058;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 28:
						if (num7 >= 10)
						{
							num = (short)1436811308;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1745485826;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 29:
						goto IL_5B8;
					case 30:
						goto IL_BBA;
					case 31:
						A_3 = true;
						num = (short)405602369;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 32:
						if (flag)
						{
							num = (short)117375032;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_73E;
					case 33:
						if (A_2 == global::AcpKeyValidatorLib.HardwareKeyType.LABTOOL_KEY)
						{
							num = (short)904003600;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return flag;
					case 34:
					{
						num = (short)528307286;
						short num9 = num;
						num = (short)1907643478;
						switch ((num9 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_BBA;
						default:
							num = (short)672137216;
							if (num != 0)
							{
							}
							if (A_1)
							{
								num = (short)985006084;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							array5 = new byte[this.c.Length];
							global::System.Array.Copy(this.c, array5, this.c.Length);
							num = (short)1052508161;
							if (num != 0)
							{
							}
							num = (short)2096365615;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 35:
					{
						byte[] array6;
						global::System.Array.Copy(global::AcpKeyValidatorLib.a.am, array6, 10);
						num = (short)1479934019;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 36:
					{
						int num10;
						if (num10 >= 24)
						{
							num = (short)806682631;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1656356914;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 37:
						if (array5 != null)
						{
							num = (short)1617100812;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return flag;
					case 38:
						goto IL_892;
					case 39:
						return flag;
					case 40:
						flag = false;
						num = (short)1928265734;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 41:
						flag = false;
						num = (short)1504182287;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 42:
						if (this.c != null)
						{
							num = (short)1402732554;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_9D0;
					case 43:
					{
						byte[] a_ = new byte[80];
						byte[] array4;
						byte[] array6;
						this.a(ref a_, array6, array4);
						byte[] array2 = new byte[10];
						int num8 = 0;
						num = (short)2005860375;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 44:
						goto IL_460;
					case 45:
						goto IL_5B8;
					case 46:
						goto IL_892;
					case 47:
						goto IL_A30;
					case 48:
						if (array5[34] == 255)
						{
							num = (short)285736991;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1236009024;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 49:
						A_3 = true;
						num = (short)1064763465;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 50:
					{
						int num10;
						if (array5[num10] != array[num3++])
						{
							num = (short)1579810876;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num10++;
						num = (short)1565327398;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 51:
						goto IL_A30;
					case 52:
					{
						global::System.Array.Copy(this.a, array, 8);
						global::System.Array.Reverse(array);
						num3 = 0;
						int num10 = 16;
						num = (short)790429742;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 53:
						flag = false;
						num = (short)837812246;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 54:
						num = (short)967245872;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 55:
						num = (short)1708654595;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 56:
					{
						byte[] array6 = new byte[10];
						num = (short)496762950;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 57:
						num = (short)1534001171;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 58:
					{
						byte[] array3;
						int num4;
						if (array5[num4] != array3[num3++])
						{
							num = (short)346292264;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num4++;
						num = (short)1735131165;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 59:
						if (flag)
						{
							num = (short)1103036473;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return flag;
					case 60:
						flag = false;
						num = (short)1471676427;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 61:
						goto IL_5F9;
					case 62:
						goto IL_77A;
					case 63:
						if (array5.Length != 0)
						{
							num = (short)1742012470;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return flag;
					case 64:
						if (array5[34] == 254)
						{
							num = (short)480837662;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return flag;
					case 65:
						return flag;
					case 66:
						if (flag)
						{
							num = (short)1271857220;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_214;
					case 67:
						goto IL_77A;
					case 68:
					{
						int num11 = 45;
						num = (short)1169424455;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 69:
						goto IL_73E;
					case 70:
						if (A_2 == global::AcpKeyValidatorLib.HardwareKeyType.DEPOT_KEY)
						{
							num = (short)1166147598;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)369164309;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 71:
					{
						int num11;
						if (this.a(array5, num11 - 1, 0) != array5[num11 - 1])
						{
							num = (short)461111349;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_214;
					}
					case 72:
						goto IL_B7B;
					case 73:
						return flag;
					}
					goto IL_158;
					IL_214:
					num = (short)1423507488;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2F6:
					num = (short)882180109;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_378:
					num = (short)1473249289;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_460:
					array = new byte[8];
					num = (short)702349317;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_5B8:
					num = (short)606994459;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_5F9:
					num = (short)450363420;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_73E:
					num = (short)545849403;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_77A:
					num3 = 0;
					num7 = 0;
					num = (short)1946026045;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_892:
					num = (short)1193476132;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_9D0:
					flag = false;
					num = (short)1065811985;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_A30:
					num = (short)16646210;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_B7B:
					num = (short)1710227457;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_BBA:
					A_3 = false;
					num = (short)391315495;
					num2 = (int)((global::System.IntPtr)num);
				}
				return flag;
				IL_158:
				array5 = null;
				flag = true;
				A_3 = false;
				num = (short)315228202;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_29;
			}
			}
		}

		// Token: 0x0600000B RID: 11 RVA: 0x0000367C File Offset: 0x0000187C
		private byte a(byte[] A_0, int A_1, byte A_2)
		{
			switch (0)
			{
			case 0:
				goto IL_40;
			}
			int num;
			byte b;
			short num2;
			int num4;
			byte b2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					goto IL_248;
				case 1:
					goto IL_C7;
				case 2:
					goto IL_14B;
				case 3:
				{
					b = (byte)(b >> 1 | 128);
					num2 = (short)1017315328;
					short num3 = num2;
					num2 = (short)1231093765;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 4:
					if (num4 >= A_1)
					{
						num2 = (short)1908736009;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					b = A_0[num4];
					b ^= A_2;
					A_2 = b;
					num2 = (short)1113915398;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 5:
					goto IL_248;
				case 6:
					if ((b & 128) != 0)
					{
						num2 = (short)1743650819;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					b = (byte)(b >> 1);
					num2 = (short)1584005120;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 7:
					if ((b2 & 128) != 0)
					{
						num2 = (short)337772552;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					b2 = (byte)(b2 >> 1);
					num2 = (short)1889337345;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 8:
					b2 = (byte)(b2 >> 1 | 128);
					b2 ^= byte.MaxValue;
					num2 = (short)422510603;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 9:
					return b2;
				case 10:
					num2 = (short)502398977;
					if (num2 != 0)
					{
					}
					goto IL_14B;
				case 11:
					goto IL_F7;
				}
				goto IL_40;
				IL_14B:
				num2 = (short)1577385988;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_248:
				b = (byte)(b >> 1);
				b ^= A_2;
				b2 = b;
				b = (byte)(b << 1);
				b &= 240;
				num2 = (short)1453719559;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_F7:
			goto IL_1D4;
			IL_40:
			num2 = (short)813372219;
			short num5 = num2;
			num2 = (short)469308219;
			switch ((num5 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_C7:
				break;
			default:
				num2 = (short)1065418752;
				if (num2 != 0)
				{
				}
				b2 = 0;
				num4 = 0;
				num2 = (short)1317076994;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			IL_1D4:
			b2 &= 15;
			b += b2;
			b2 = A_2;
			b2 &= 7;
			this.a(ref b2, ref b);
			b = global::AcpKeyValidatorLib.a.ay[(int)b];
			b2 ^= b;
			A_2 = b2;
			num4++;
			num2 = (short)1047986186;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x0600000C RID: 12 RVA: 0x00003950 File Offset: 0x00001B50
		private void a(ref byte[] A_0, byte[] A_1, byte[] A_2)
		{
			short num = (short)14614528;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				int num10;
				switch (0)
				{
				case 0:
					break;
				default:
					for (;;)
					{
						IL_28:
						switch (num2)
						{
						case 0:
						{
							int num3 = 0;
							num = (short)1592918028;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 1:
							goto IL_320;
						case 2:
							goto IL_320;
						case 3:
							goto IL_186;
						case 4:
							goto IL_35F;
						case 5:
						{
							global::System.Array.Copy(A_1, 0, A_0, 48, 10);
							global::System.Array.Copy(A_2, 0, A_0, 58, 6);
							int num4 = 0;
							num = (short)2072707074;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 6:
							goto IL_485;
						case 7:
							goto IL_297;
						case 8:
							goto IL_186;
						case 9:
						{
							int num3;
							if (num3 >= 6)
							{
								num = (short)386269205;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							byte b = A_2[num3] + 1;
							A_0[num3 + 26] = b;
							num3++;
							num = (short)399704071;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 10:
						{
							int num5;
							if (num5 >= 6)
							{
								num = (short)2045706256;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							byte b = A_2[num5] + 13;
							A_0[num5 + 74] = b;
							num5++;
							num = (short)178847744;
							short num6 = num;
							num = (short)1948254219;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 11:
							goto IL_35F;
						case 12:
							goto IL_297;
						case 13:
						{
							int num7;
							if (num7 >= 10)
							{
								num = (short)1779433489;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							byte b = (byte)(A_1[num7] << 4);
							A_0[num7 + 32] = b;
							num7++;
							num = (short)343212052;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 14:
							goto IL_485;
						case 15:
						{
							int num5 = 0;
							num = (short)1017511940;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 16:
							return;
						case 17:
						{
							int num8 = 0;
							num = (short)1016791041;
							if (num != 0)
							{
							}
							num = (short)749010950;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 18:
						{
							int num8;
							if (num8 >= 6)
							{
								num = (short)2099118085;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							byte b = (byte)(A_2[num8] << 4);
							A_0[num8 + 42] = b;
							num8++;
							num = (short)119406606;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 19:
						{
							int num4;
							if (num4 >= 10)
							{
								num = (short)1568669711;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							byte b = A_1[num4] + 13;
							A_0[num4 + 64] = b;
							num4++;
							num = (short)2097676289;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 20:
							goto IL_257;
						case 21:
						{
							num = (short)1166088534;
							short num9 = num;
							num = (short)2078742870;
							switch ((num9 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_A9;
							default:
							{
								num = (short)418643968;
								if (num != 0)
								{
								}
								int num7 = 0;
								num = (short)1239416854;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							}
							break;
						}
						case 22:
							goto IL_257;
						case 23:
						{
							if (num10 >= 10)
							{
								num = (short)322240512;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							byte b = A_1[num10] + 1;
							A_0[num10 + 16] = b;
							num10++;
							num = (short)2118778883;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						goto IL_8F;
						IL_186:
						num = (short)1423573015;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_257:
						num = (short)1845035021;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_297:
						num = (short)1540554761;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_320:
						num = (short)2000093203;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_35F:
						num = (short)1105985546;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_485:
						num = (short)425066514;
						num2 = (int)((global::System.IntPtr)num);
					}
					return;
				}
				IL_8F:
				global::System.Array.Copy(A_1, 0, A_0, 0, 10);
				global::System.Array.Copy(A_2, 0, A_0, 10, 6);
				num10 = 0;
				IL_A9:
				num = (short)1197932552;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_28;
			}
			}
		}

		// Token: 0x0600000D RID: 13 RVA: 0x00003E24 File Offset: 0x00002024
		private void a(ref byte[] A_0, byte[] A_1, byte[] A_2, int A_3)
		{
			short num = (short)1752891392;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_4F;
				}
				byte[] array;
				byte[] array2;
				int num4;
				for (;;)
				{
					IL_28:
					switch (num2)
					{
					case 0:
						goto IL_17B;
					case 1:
						goto IL_120;
					case 2:
						return;
					case 3:
					{
						int num3;
						if (num3 >= A_3)
						{
							num = (short)655753221;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1719468033;
						if (num != 0)
						{
						}
						array[0] = A_1[(int)array2[num4 * A_3 + num3]];
						byte b = this.a(array, 1, b);
						num3++;
						num = (short)919273473;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 4:
						goto IL_120;
					case 5:
					{
						num = (short)1053655190;
						short num5 = num;
						num = (short)1399357590;
						switch ((num5 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						case 1:
							goto IL_E2;
						default:
						{
							num = (short)1515126784;
							short num6 = num;
							goto IL_E2;
						}
						}
						IL_105:
						num = (short)90439687;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_E2:
						num = (short)324468736;
						if (num != 0)
						{
						}
						byte b;
						A_0[num4] = (b ^ A_2[num4]);
						num4++;
						goto IL_105;
					}
					case 6:
					{
						if (num4 >= 10)
						{
							num = (short)144506882;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						byte b = 0;
						int num3 = 0;
						num = (short)75104260;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 7:
						goto IL_17B;
					}
					goto IL_4F;
					IL_120:
					num = (short)492371971;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_17B:
					num = (short)1370750982;
					num2 = (int)((global::System.IntPtr)num);
				}
				return;
				IL_4F:
				array2 = new byte[]
				{
					22,
					61,
					3,
					45,
					53,
					7,
					33,
					65,
					75,
					50,
					46,
					23,
					40,
					5,
					8,
					78,
					69,
					64,
					67,
					1,
					19,
					70,
					9,
					13,
					54,
					57,
					43,
					51,
					49,
					26,
					59,
					18,
					62,
					20,
					37,
					56,
					15,
					28,
					74,
					27,
					39,
					66,
					10,
					71,
					72,
					30,
					2,
					77,
					68,
					17,
					79,
					4,
					42,
					63,
					44,
					21,
					36,
					47,
					14,
					29,
					12,
					6,
					58,
					41,
					34,
					38,
					31,
					32,
					25,
					48,
					73,
					16,
					24,
					55,
					60,
					35,
					11,
					52,
					76,
					0
				};
				array = new byte[1];
				num4 = 0;
				num = (short)922877952;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_28;
			}
			}
		}

		// Token: 0x0600000E RID: 14 RVA: 0x00004048 File Offset: 0x00002248
		private void a(ref byte A_0, ref byte A_1)
		{
			short num = (short)1122111302;
			short num2 = num;
			num = (short)1955860294;
			switch (num2 == num)
			{
			}
			num = (short)1326841857;
			if (num != 0)
			{
			}
			num = (short)285147136;
			short num3 = num;
			num = (short)380633088;
			if (num != 0)
			{
			}
			A_0 ^= A_1;
			A_1 ^= A_0;
			A_0 ^= A_1;
		}

		// Token: 0x0600000F RID: 15 RVA: 0x0000410C File Offset: 0x0000230C
		private byte[] a(global::IBtnWrapperLib.IIBtnWrapper A_0, byte[] A_1)
		{
			short num = (short)1580335104;
			switch (num)
			{
			default:
			{
				num = (short)1119223808;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					byte[] array;
					switch (num2)
					{
					case 0:
						switch (0)
						{
						case 0:
							goto IL_67;
						}
						continue;
					case 1:
						goto IL_82;
					case 2:
						return array;
					case 3:
					{
						byte[] array2;
						byte[] array3;
						if (!this.a(A_0, out array2, out array3, false))
						{
							return array;
						}
						num = (short)1295582624;
						short num3 = num;
						num = (short)654902688;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_D8;
						default:
							num = (short)719519744;
							if (num != 0)
							{
							}
							num = (short)1252196358;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 4:
					{
						byte[] array2;
						if (array2 != null)
						{
							num = (short)2138243072;
							short num4 = num;
							num = (short)655491080;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return array;
					}
					case 5:
					{
						byte[] array3;
						if (array3 != null)
						{
							goto IL_D8;
						}
						return array;
					}
					case 6:
						num = (short)1250557956;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
					{
						num = (short)662700033;
						if (num != 0)
						{
						}
						byte[] array3;
						global::System.Array.Clear(array3, 0, array3.Length);
						num = (short)462356482;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 8:
					{
						global::AcpCryptoLib.FlashkeyCrypto flashkeyCrypto = new global::AcpCryptoLib.FlashkeyCrypto();
						byte[] array2;
						byte[] array3;
						flashkeyCrypto.Init(array2, array3);
						byte[] array4 = flashkeyCrypto.Decrypt(A_1);
						array = new byte[array4.Length];
						global::System.Array.Copy(array4, 0, array, 0, array4.Length);
						global::System.Array.Clear(array2, 0, array2.Length);
						num = (short)610664453;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					IL_67:
					if (A_1 == null)
					{
						num = (short)1813839873;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					array = null;
					num = (short)1401159683;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_D8:
					num = (short)2058158087;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_82:
				throw new global::System.NullReferenceException();
			}
			}
		}

		// Token: 0x06000010 RID: 16 RVA: 0x0000435C File Offset: 0x0000255C
		private bool a(global::IBtnWrapperLib.IIBtnWrapper A_0, out byte[] A_1, out byte[] A_2, bool A_3)
		{
			short num = (short)1241448448;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_96;
				}
				bool result;
				for (;;)
				{
					IL_27:
					int num3;
					int num6;
					switch (num2)
					{
					case 0:
						goto IL_2AF;
					case 1:
					{
						A_2 = new byte[8];
						byte[] array = null;
						num = (short)1437859865;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
					{
						byte[] array2 = null;
						ushort a_ = 9;
						num = (short)45416462;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 3:
						if (A_3)
						{
							num = (short)259850252;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3D6;
					case 4:
						return result;
					case 5:
						num = (short)1070202889;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
					{
						if (num3 >= 4)
						{
							num = (short)2131230722;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						byte[] array;
						A_2[num3] = array[num3];
						num3++;
						num = (short)199294976;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 7:
						goto IL_186;
					case 8:
					{
						num = (short)853344256;
						short num4 = num;
						goto IL_3D6;
					}
					case 9:
						if (A_3)
						{
							num = (short)1545601043;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_DF;
					case 10:
						if (this.a != null)
						{
							num = (short)131530768;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return result;
					case 11:
						num = (short)1729888259;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 12:
					{
						byte[] array;
						int num5 = (int)array[3] << 24;
						num5 += (int)array[2] << 16;
						num5 += (int)array[1] << 8;
						num5 += (int)array[0];
						num5++;
						array[3] = (byte)(num5 >> 24);
						array[2] = (byte)(num5 >> 16);
						array[1] = (byte)(num5 >> 8);
						array[0] = (byte)num5;
						num = (short)1777664008;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 13:
						if (this.b == 24)
						{
							num = (short)1339228161;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						result = true;
						num = (short)918618116;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 14:
					{
						byte[] array2;
						ushort a_;
						if (this.a(A_0, a_, out array2))
						{
							num = (short)68943877;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return result;
					}
					case 15:
					{
						if (num6 >= 8)
						{
							num = (short)455213078;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						byte[] array2;
						A_2[num6] = array2[num6 - 4];
						num6++;
						num = (short)1901133844;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 16:
						num = (short)107806741;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 17:
						goto IL_2AF;
					case 18:
						num = (short)1903230977;
						if (num != 0)
						{
						}
						A_1 = new byte[8];
						global::System.Array.Copy(this.a, A_1, 8);
						global::System.Array.Reverse(A_1);
						A_2 = null;
						num = (short)1835270157;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 19:
					{
						byte[] array2;
						int num7 = (int)array2[3] << 24;
						num7 += (int)array2[2] << 16;
						num7 += (int)array2[1] << 8;
						num7 += (int)array2[0];
						num7++;
						array2[3] = (byte)(num7 >> 24);
						array2[2] = (byte)(num7 >> 16);
						array2[1] = (byte)(num7 >> 8);
						array2[0] = (byte)num7;
						num = (short)1965293592;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 20:
						goto IL_186;
					case 21:
						if (this.a.Length == 8)
						{
							num = (short)216203282;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return result;
					case 22:
						result = true;
						num = (short)1604255767;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 23:
						return result;
					case 24:
						goto IL_DF;
					case 25:
					{
						byte[] array;
						if (!this.a(A_0, 8, out array))
						{
							return result;
						}
						num = (short)1613912661;
						short num8 = num;
						num = (short)1097685589;
						switch ((num8 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							continue;
						default:
							num = (short)1323892736;
							if (num != 0)
							{
							}
							num = (short)752549899;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					}
					goto IL_96;
					IL_DF:
					num6 = 4;
					num = (short)558891015;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_186:
					num = (short)84738063;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2AF:
					num = (short)905576454;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_3D6:
					num3 = 0;
					num = (short)200933393;
					num2 = (int)((global::System.IntPtr)num);
				}
				return result;
				IL_96:
				result = false;
				A_1 = null;
				A_2 = null;
				num = (short)832372746;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x06000011 RID: 17 RVA: 0x000048CC File Offset: 0x00002ACC
		private bool a(global::IBtnWrapperLib.IIBtnWrapper A_0, bool A_1)
		{
			int a_ = 12;
			short num = (short)360316928;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_120;
				}
				bool flag;
				byte[] array3;
				byte[] array4;
				for (;;)
				{
					IL_31:
					byte[] array2;
					bool flag2;
					switch (num2)
					{
					case 0:
					{
						byte[] array = new byte[10];
						global::System.Array.Copy(global::AcpKeyValidatorLib.a.au, array, 10);
						int num3 = 0;
						int num4 = 1;
						num = (short)310575155;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 1:
						goto IL_5F3;
					case 2:
						if (this.c != null)
						{
							num = (short)1082720298;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1FF;
					case 3:
						goto IL_1C4;
					case 4:
					{
						int num5;
						global::System.Collections.ArrayList arrayList;
						if (num5 >= arrayList.Count)
						{
							num = (short)1313079317;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						string text = (string)arrayList[num5];
						text = text.ToLower();
						num = (short)2015428637;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 5:
						flag = false;
						num = (short)1379860520;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
						if (flag)
						{
							num = (short)153681950;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_99D;
					case 7:
					{
						global::System.Array.Copy(this.a, array2, 8);
						global::System.Array.Reverse(array2);
						int num3 = 0;
						int num6 = 11;
						num = (short)1503592481;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 8:
						num = (short)1253048345;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 9:
					{
						string text2 = "";
						int num7 = 0;
						num = (short)1312292895;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 10:
					{
						int num6;
						if (num6 >= 19)
						{
							num = (short)1367474187;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)139853877;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 11:
						goto IL_1C4;
					case 12:
						goto IL_2FD;
					case 13:
						goto IL_3C0;
					case 14:
						flag = false;
						num = (short)1879703588;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 15:
						flag = false;
						num = (short)861405185;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 16:
					{
						num = (short)1821179904;
						short num8 = num;
						if (this.a == null)
						{
							num = (short)1489305649;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)261554195;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 17:
						num = (short)272302137;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 18:
						goto IL_25D;
					case 19:
						if (this.b != 4)
						{
							num = (short)2007892023;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1930166294;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 20:
						if (flag)
						{
							num = (short)202047495;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1C4;
					case 21:
						return flag;
					case 22:
						if (A_1)
						{
							num = (short)269353003;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						array3 = new byte[this.c.Length];
						global::System.Array.Copy(this.c, array3, this.c.Length);
						num = (short)419299369;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 23:
						if (this.c.Length >= 1)
						{
							num = (short)1278803994;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1FF;
					case 24:
						goto IL_9DA;
					case 25:
						flag2 = this.a(A_0, global::IBtnWrapperLib.TimerType.interval);
						goto IL_4EB;
					case 26:
						num = (short)2112946192;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 27:
						goto IL_545;
					case 28:
						goto IL_2C0;
					case 29:
					{
						string text;
						string text2;
						if (!text2.Contains(text))
						{
							num = (short)30605317;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						int num5;
						num5++;
						num = (short)1843423878;
						short num9 = num;
						num = (short)1604938374;
						switch ((num9 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							return flag;
						default:
							num = (short)14090240;
							if (num != 0)
							{
							}
							num = (short)495058968;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 30:
					{
						byte b = array3[0];
						int num10 = (int)array3[1] << 8;
						num10 += (int)array3[2];
						array4 = new byte[array3.Length - 3];
						global::System.Array.Copy(array3, 3, array4, 0, array3.Length - 3);
						num = (short)370147380;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 31:
						goto IL_2C0;
					case 32:
						flag2 = true;
						goto IL_4EB;
					case 33:
						goto IL_2FD;
					case 34:
						if (flag)
						{
							num = (short)1113194513;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_5F3;
					case 35:
						goto IL_9DA;
					case 36:
						goto IL_99D;
					case 37:
					{
						int num4;
						if (num4 >= 11)
						{
							num = (short)393281554;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)244842550;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 38:
						goto IL_3C0;
					case 39:
					{
						string text2 = text2.ToLower();
						global::System.Collections.ArrayList arrayList = this.a();
						string text = "";
						int num5 = 0;
						num = (short)851968035;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 40:
						return flag;
					case 41:
						goto IL_3C0;
					case 42:
						num = (short)408354817;
						if (num != 0)
						{
						}
						num = (short)424280087;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 43:
					{
						byte[] array5 = this.a(A_0, this.c);
						array3 = new byte[array5.Length];
						global::System.Array.Copy(array5, array3, array5.Length);
						num = (short)541261837;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 44:
						goto IL_3C0;
					case 45:
						if (flag)
						{
							num = (short)1568866304;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1C4;
					case 46:
					{
						int num7;
						if (num7 >= array3.Length)
						{
							num = (short)1011875879;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						string str = string.Format(global::AcpKeyValidatorLib.AcpKeyValidator.b("ᱦ奨兪ᕬ嵮౰", a_), array3[num7]);
						string text2;
						text2 += str;
						num7++;
						num = (short)1525153820;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 47:
						flag = false;
						num = (short)1692926008;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 48:
						if (flag)
						{
							num = (short)1935147017;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return flag;
					case 49:
						goto IL_1FF;
					case 50:
						flag = false;
						num = (short)1295384579;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 51:
						goto IL_545;
					case 52:
					{
						byte b;
						int num10;
						if (this.a(array4, num10, 0) != b)
						{
							num = (short)201195534;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_99D;
					}
					case 53:
					{
						int num3;
						int num6;
						if (array4[num6] != array2[num3++])
						{
							num = (short)1413218354;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num6++;
						num = (short)1861222412;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 54:
					{
						byte[] array;
						int num3;
						int num4;
						if (array4[num4] != array[num3++])
						{
							num = (short)1979842607;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num4++;
						num = (short)1645608987;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 55:
						flag = false;
						num = (short)569507884;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 56:
						goto IL_25D;
					case 57:
						if (!this.a(A_0, global::IBtnWrapperLib.TimerType.realTime))
						{
							num = (short)873594888;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)61407264;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_120;
					IL_1C4:
					num = (short)887029808;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1FF:
					flag = false;
					num = (short)325451814;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_25D:
					array2 = new byte[8];
					num = (short)1962868756;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2C0:
					num = (short)281018414;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2FD:
					num = (short)831586314;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_3C0:
					num = (short)1238106118;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_4EB:
					if (!flag2)
					{
						num = (short)1860829199;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_5F3;
					IL_545:
					num = (short)1463746597;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_5F3:
					num = (short)202244141;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_99D:
					num = (short)260898850;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_9DA:
					num = (short)480903172;
					num2 = (int)((global::System.IntPtr)num);
				}
				return flag;
				IL_120:
				array4 = null;
				array3 = null;
				flag = true;
				num = (short)1042022402;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_31;
			}
			}
		}

		// Token: 0x06000012 RID: 18 RVA: 0x000052F8 File Offset: 0x000034F8
		private bool a(global::IBtnWrapperLib.IIBtnWrapper A_0, global::IBtnWrapperLib.TimerType A_1)
		{
			short num = (short)545193984;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				num = (short)1548746753;
				if (num != 0)
				{
				}
				bool result = false;
				byte b = 0;
				byte b2 = 0;
				byte b3 = 0;
				byte b4 = 0;
				byte[] array = new byte[30];
				try
				{
					switch (0)
					{
					case 0:
						goto IL_94;
					}
					for (;;)
					{
						IL_65:
						switch (num2)
						{
						case 0:
							if (A_1 == global::IBtnWrapperLib.TimerType.realTime)
							{
								num = (short)1207042055;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							b = 0;
							b4 = 80;
							b2 = 16;
							b3 = 16;
							num = (short)82247681;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							goto IL_1CB;
						case 2:
							goto IL_20F;
						case 3:
							num = (short)1364656132;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 4:
						{
							num = (short)1045962271;
							short num3 = num;
							num = (short)1994333727;
							switch ((num3 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								continue;
							default:
							{
								num = (short)32178176;
								if (num != 0)
								{
								}
								byte b5;
								if ((b5 & b4) == b3)
								{
									num = (short)2025717765;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_20F;
							}
							}
							break;
						}
						case 5:
							result = true;
							num = (short)655818754;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 6:
							goto IL_227;
						case 7:
							b = 0;
							b4 = 16;
							b2 = 8;
							b3 = 16;
							num = (short)364183561;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 8:
						{
							byte b6 = array[0];
							byte b5 = array[1];
							if ((b6 & b2) == b)
							{
								num = (short)517341187;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_20F;
						}
						case 9:
							goto IL_1CB;
						}
						goto IL_94;
						IL_1CB:
						num = (short)271843336;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_20F:
						num = (short)1579483142;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_227:
					goto IL_22E;
					IL_94:
					A_0.ReadMemoryData(0, 2, 30, array);
					num = (short)1522466816;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_65;
				}
				catch
				{
					result = false;
				}
				IL_22E:
				num = (short)1603600384;
				short num4 = num;
				return result;
			}
			}
		}

		// Token: 0x06000013 RID: 19 RVA: 0x0000557C File Offset: 0x0000377C
		private bool a(global::IBtnWrapperLib.IIBtnWrapper A_0, ushort A_1, out byte[] A_2)
		{
			short num = (short)548995072;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_64;
				}
				byte addrLSB;
				byte addrMSB;
				short num4;
				bool result;
				for (;;)
				{
					IL_29:
					switch (num2)
					{
					case 0:
					{
						num = (short)979479983;
						short num3 = num;
						num = (short)1739304367;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							num = (short)1177550848;
							if (num != 0)
							{
							}
							switch (A_1)
							{
							case 8:
								goto IL_1C0;
							case 9:
								break;
							case 10:
								addrLSB = 104;
								num = (short)852361221;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 11:
								addrLSB = 108;
								num = (short)630456329;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 12:
								addrLSB = 112;
								num = (short)561577991;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 13:
								addrLSB = 116;
								num = (short)593625094;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 14:
								addrLSB = 120;
								num = (short)128122891;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 15:
								addrLSB = 124;
								num = (short)1502150664;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							default:
								num = (short)618790914;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						addrLSB = 100;
						num = (short)1639645185;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 1:
						goto IL_25E;
					case 2:
						num = (short)1408499715;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						num = (short)235864065;
						if (num != 0)
						{
						}
						addrLSB = 96;
						num = (short)57278474;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						try
						{
							A_0.ReadMemoryData(addrLSB, addrMSB, num4, A_2);
							return result;
						}
						catch
						{
							A_2 = null;
							return false;
						}
						goto IL_1C0;
					case 5:
						goto IL_25E;
					case 6:
						goto IL_25E;
					case 7:
						goto IL_25E;
					case 8:
						goto IL_25E;
					case 9:
						goto IL_25E;
					case 10:
						goto IL_25E;
					case 11:
						goto IL_25E;
					case 12:
						goto IL_25E;
					}
					goto IL_64;
					IL_1C0:
					num = (short)318242816;
					short num5 = num;
					addrLSB = 96;
					num = (short)97714188;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_25E:
					num = (short)1682178052;
					num2 = (int)((global::System.IntPtr)num);
				}
				return result;
				IL_64:
				result = true;
				addrMSB = 2;
				addrLSB = 0;
				num4 = 4;
				A_2 = new byte[(int)num4];
				num = (short)1513488384;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_29;
			}
			}
		}

		// Token: 0x06000014 RID: 20 RVA: 0x00005870 File Offset: 0x00003A70
		private global::System.Collections.ArrayList a()
		{
			int a_ = 11;
			short num = (short)682305227;
			short num2 = num;
			num = (short)1419388619;
			switch (num2 == num)
			{
			}
			num = (short)836960256;
			if (num != 0)
			{
			}
			num = (short)1115357185;
			if (num != 0)
			{
			}
			num = (short)1452212224;
			short num3 = num;
			global::System.Collections.ArrayList arrayList = new global::System.Collections.ArrayList();
			global::System.Guid guid = new global::System.Guid(global::AcpKeyValidatorLib.AcpKeyValidator.b("ᵥ塧ቩ⹫⩭㍯䁱ㅳ併㭷㹹偻乽떁놃쒅놇ꚉ벋꒏ꎑꆓ꺕뒗겛醡袣隥킧颩芭肯쪱蚳蚵钷誹쒻誽薿뻅迉ﻍ꣏𥉉ꋙ駛쳟틡鳣훥퇧韩釫", a_));
			string text = guid.ToString();
			text = text.Replace(global::AcpKeyValidatorLib.AcpKeyValidator.b("䭥", a_), "");
			text = text.ToUpper();
			arrayList.Add(text);
			arrayList.Add(global::AcpKeyValidatorLib.AcpKeyValidator.b("呥屧奩੫塭ᅯ䩱䱳", a_));
			return arrayList;
		}

		// Token: 0x04000003 RID: 3
		private byte[] a;

		// Token: 0x04000004 RID: 4
		private byte b;

		// Token: 0x04000005 RID: 5
		private byte[] c;

		// Token: 0x04000006 RID: 6
		private global::AcpKeyValidatorLib.HardwareKeyType d;
	}
}
