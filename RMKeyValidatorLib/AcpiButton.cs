using System;
using System.Collections;
using AcpCryptoLib;
using RMIBtnWrapperLib;

namespace RMKeyValidatorLib
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
				int a_ = 6;
				short num = (short)824246273;
				if (num != 0)
				{
				}
				switch (0)
				{
				case 0:
					goto IL_59;
				}
				int num2;
				string text;
				for (;;)
				{
					IL_3B:
					switch (num2)
					{
					case 0:
						return text;
					case 1:
						goto IL_94;
					case 2:
						goto IL_94;
					case 3:
					{
						int num3 = 7;
						num = (short)1854472193;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 4:
						if (this.a != null)
						{
							num = (short)1507065859;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return text;
					case 5:
					{
						num = (short)1850109104;
						short num4 = num;
						num = (short)740715696;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_165;
						case 1:
							break;
						default:
						{
							num = (short)1965293568;
							short num5 = num;
							break;
						}
						}
						num = (short)314572800;
						if (num != 0)
						{
						}
						int num3;
						if (num3 < 0)
						{
							num = (short)617807872;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						text += string.Format(global::RMKeyValidatorLib.AcpKeyValidator.b("ੰ䍲佴ྲྀ䭸ٺ", a_), this.a[num3]);
						num3--;
						IL_165:
						num = (short)595853314;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					goto IL_59;
					IL_94:
					num = (short)1530068997;
					num2 = (int)((global::System.IntPtr)num);
				}
				return text;
				IL_59:
				text = null;
				num = (short)1555234820;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_3B;
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000005 RID: 5 RVA: 0x00002350 File Offset: 0x00000550
		public global::RMKeyValidatorLib.HardwareKeyType KeyType
		{
			get
			{
				short num = (short)1759052721;
				short num2 = num;
				num = (short)597689265;
				switch (num2 == num)
				{
				}
				num = (short)975503361;
				if (num != 0)
				{
				}
				num = (short)1937637376;
				if (num != 0)
				{
				}
				num = (short)297598976;
				short num3 = num;
				return this.d;
			}
		}

		// Token: 0x06000006 RID: 6 RVA: 0x00002400 File Offset: 0x00000600
		private void a(global::RMIBtnWrapperLib.IIBtnWrapper A_0, string A_1, ref short A_2, ref short A_3)
		{
			switch (0)
			{
			case 0:
				goto IL_1C;
			}
			byte[] array;
			short num2;
			for (;;)
			{
				IL_0A:
				int num;
				switch (num)
				{
				case 0:
					return;
				case 1:
					if (array != null)
					{
						num2 = (short)1159069698;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 2:
					goto IL_E9;
				}
				goto IL_1C;
			}
			IL_E9:
			num2 = (short)247005184;
			short num3 = num2;
			goto IL_113;
			IL_1C:
			num2 = (short)313523967;
			short num4 = num2;
			num2 = (short)286785279;
			switch ((num4 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
			{
				IL_113:
				byte b = array[0];
				this.c = new byte[array.Length - 1];
				global::System.Array.Copy(array, 1, this.c, 0, array.Length - 1);
				num2 = (short)132775936;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			default:
			{
				num2 = (short)1765867520;
				if (num2 != 0)
				{
				}
				num2 = (short)161218561;
				if (num2 != 0)
				{
				}
				this.a = A_0.GetROMSerialNum();
				this.b = this.a[0];
				array = null;
				A_0.ReadFileAtPage(A_1, ref A_2, ref A_3, out array);
				num2 = (short)1408368641;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			}
		}

		// Token: 0x06000007 RID: 7 RVA: 0x00002560 File Offset: 0x00000760
		public bool IsDepot(global::RMIBtnWrapperLib.IIBtnWrapper ibtnWrapper, out bool bFullAccess)
		{
			int a_ = 11;
			short num = (short)1984888832;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				num = (short)1633222657;
				if (num != 0)
				{
				}
				string a_2 = global::RMKeyValidatorLib.AcpKeyValidator.b("㭵㝷⹹㩻偽끿", a_);
				short num3 = 80;
				short num4 = 0;
				bool result = false;
				bFullAccess = true;
				try
				{
					switch (0)
					{
					case 0:
						goto IL_88;
					}
					for (;;)
					{
						IL_71:
						switch (num2)
						{
						case 0:
							goto IL_156;
						case 1:
							goto IL_13B;
						case 2:
							if (this.a(ibtnWrapper, true, global::RMKeyValidatorLib.HardwareKeyType.DEPOT_KEY, out bFullAccess))
							{
								num = (short)1330511875;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_13D;
						case 3:
						{
							num = (short)576731554;
							short num5 = num;
							num = (short)990198178;
							switch ((num5 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_13B;
							default:
								num = (short)329121792;
								if (num != 0)
								{
								}
								result = true;
								this.d = global::RMKeyValidatorLib.HardwareKeyType.DEPOT_KEY;
								num = (short)1668022273;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						}
						goto IL_88;
						IL_13D:
						num = (short)730726400;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_13B:
						goto IL_13D;
					}
					IL_156:
					goto IL_15D;
					IL_88:
					this.a(ibtnWrapper, a_2, ref num3, ref num4);
					num = (short)1756954626;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_71;
				}
				catch
				{
					result = false;
				}
				IL_15D:
				num = (short)621215744;
				short num6 = num;
				return result;
			}
			}
		}

		// Token: 0x06000008 RID: 8 RVA: 0x00002708 File Offset: 0x00000908
		public bool IsLabTool(global::RMIBtnWrapperLib.IIBtnWrapper ibtnWrapper, out bool bFullAccess)
		{
			int a_ = 5;
			short num = (short)42598400;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				num = (short)1396768769;
				if (num != 0)
				{
				}
				string a_2 = global::RMKeyValidatorLib.AcpKeyValidator.b("㵯㵱⁳ふ噷䩹", a_);
				short num3 = 80;
				short num4 = 0;
				bFullAccess = false;
				bool result = false;
				try
				{
					switch (0)
					{
					case 0:
						goto IL_8A;
					}
					for (;;)
					{
						IL_73:
						switch (num2)
						{
						case 0:
							goto IL_15B;
						case 1:
							goto IL_141;
						case 2:
							if (this.a(ibtnWrapper, true, global::RMKeyValidatorLib.HardwareKeyType.LABTOOL_KEY, out bFullAccess))
							{
								num = (short)2011168771;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_143;
						case 3:
						{
							num = (short)595935023;
							short num5 = num;
							num = (short)1716928303;
							switch ((num5 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_141;
							default:
								num = (short)463470592;
								if (num != 0)
								{
								}
								result = true;
								this.d = global::RMKeyValidatorLib.HardwareKeyType.LABTOOL_KEY;
								num = (short)1395458049;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						}
						goto IL_8A;
						IL_143:
						num = (short)1722351616;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_141:
						goto IL_143;
					}
					IL_15B:
					goto IL_162;
					IL_8A:
					this.a(ibtnWrapper, a_2, ref num3, ref num4);
					num = (short)1957429250;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_73;
				}
				catch
				{
					result = false;
				}
				IL_162:
				num = (short)2110914560;
				short num6 = num;
				return result;
			}
			}
		}

		// Token: 0x06000009 RID: 9 RVA: 0x000028B0 File Offset: 0x00000AB0
		public bool IsFTR(global::RMIBtnWrapperLib.IIBtnWrapper ibtnWrapper)
		{
			int a_ = 2;
			short num = (short)2121203712;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				string a_2 = global::RMKeyValidatorLib.AcpKeyValidator.b("⁬⥮╰ⅲ孴䙶", a_);
				short num3 = 400;
				short num4 = 0;
				bool result = false;
				try
				{
					switch (0)
					{
					case 0:
						goto IL_63;
					}
					for (;;)
					{
						IL_4C:
						switch (num2)
						{
						case 0:
							goto IL_130;
						case 1:
							goto IL_116;
						case 2:
							if (this.a(ibtnWrapper, true))
							{
								num = (short)297336835;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_118;
						case 3:
						{
							num = (short)1979965671;
							short num5 = num;
							num = (short)865263847;
							switch ((num5 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_116;
							default:
								num = (short)921239552;
								if (num != 0)
								{
								}
								result = true;
								this.d = global::RMKeyValidatorLib.HardwareKeyType.FTR_KEY;
								num = (short)1285292033;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						}
						goto IL_63;
						IL_118:
						num = (short)1165295616;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_116:
						goto IL_118;
					}
					IL_130:
					goto IL_137;
					IL_63:
					this.a(ibtnWrapper, a_2, ref num3, ref num4);
					num = (short)1866399746;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_4C;
				}
				catch
				{
					result = false;
				}
				IL_137:
				num = (short)1834942465;
				if (num != 0)
				{
				}
				num = (short)1767440384;
				short num6 = num;
				return result;
			}
			}
		}

		// Token: 0x0600000A RID: 10 RVA: 0x00002A58 File Offset: 0x00000C58
		private bool a(global::RMIBtnWrapperLib.IIBtnWrapper A_0, bool A_1, global::RMKeyValidatorLib.HardwareKeyType A_2, out bool A_3)
		{
			short num = (short)1229062144;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_156;
				}
				bool flag;
				byte[] array4;
				for (;;)
				{
					IL_27:
					int num4;
					byte[] array3;
					int num9;
					switch (num2)
					{
					case 0:
						goto IL_217;
					case 1:
						goto IL_B3D;
					case 2:
						goto IL_2D2;
					case 3:
						if (A_2 == global::RMKeyValidatorLib.HardwareKeyType.DEPOT_KEY)
						{
							num = (short)1666646082;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)929038409;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						goto IL_A6D;
					case 5:
						flag = false;
						num = (short)1001586717;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
					{
						byte[] array = new byte[10];
						num = (short)683409466;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 7:
					{
						int num3;
						if (num3 >= 34)
						{
							num = (short)527040530;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1915224115;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 8:
						if (A_2 == global::RMKeyValidatorLib.HardwareKeyType.LABTOOL_KEY)
						{
							goto IL_7C5;
						}
						goto IL_784;
					case 9:
						goto IL_784;
					case 10:
						goto IL_A15;
					case 11:
						goto IL_5C3;
					case 12:
					{
						byte[] array2 = new byte[6];
						num4 = 0;
						int num5 = 10;
						num = (short)1051066369;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 13:
						A_3 = true;
						num = (short)1071841334;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 14:
						if (flag)
						{
							num = (short)1898774540;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_748;
					case 15:
					{
						global::System.Array.Copy(this.a, array3, 8);
						global::System.Array.Reverse(array3);
						num4 = 0;
						int num6 = 16;
						num = (short)1575288848;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 16:
						goto IL_873;
					case 17:
						if (array4.Length != 0)
						{
							num = (short)127336516;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return flag;
					case 18:
						goto IL_748;
					case 19:
					{
						byte[] array5;
						global::System.Array.Copy(array3, array5, 4);
						byte[] array6 = new byte[10];
						byte[] a_;
						this.a(ref array6, a_, array5, 8);
						num4 = 0;
						int num3 = 24;
						num = (short)1156579339;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 20:
						flag = false;
						num = (short)369557504;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 21:
						if (flag)
						{
							num = (short)1594818575;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_355;
					case 22:
						if (flag)
						{
							num = (short)1124335622;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_748;
					case 23:
					{
						int num6;
						if (num6 >= 24)
						{
							num = (short)1039204404;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)34603039;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 24:
					{
						num = (short)557988050;
						short num7 = num;
						num = (short)877672658;
						switch ((num7 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_7C5;
						default:
							goto IL_BCF;
						}
						break;
					}
					case 25:
						if (this.c.Length >= 1)
						{
							num = (short)902037546;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_9B2;
					case 26:
						num = (short)175112209;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 27:
					{
						byte[] a_ = new byte[80];
						byte[] array;
						byte[] array2;
						this.a(ref a_, array, array2);
						byte[] array5 = new byte[10];
						int num8 = 0;
						num = (short)1785004034;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 28:
						if (flag)
						{
							num = (short)1456799805;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_217;
					case 29:
						goto IL_748;
					case 30:
					{
						byte[] array;
						if (array4[num9] != array[num4++])
						{
							num = (short)1592787003;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num9++;
						num = (short)1689124924;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 31:
					{
						int num6;
						if (array4[num6] != array3[num4++])
						{
							num = (short)1374158901;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num6++;
						num = (short)955777061;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 32:
						goto IL_9B2;
					case 33:
					{
						byte[] array;
						global::System.Array.Copy(global::RMKeyValidatorLib.a.am, array, 10);
						num = (short)1507000361;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 34:
						goto IL_B3D;
					case 35:
						num = (short)1870331905;
						if (num != 0)
						{
						}
						if (A_1)
						{
							num = (short)655753259;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						array4 = new byte[this.c.Length];
						global::System.Array.Copy(this.c, array4, this.c.Length);
						num = (short)938606602;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 36:
					{
						byte[] array;
						global::System.Array.Copy(global::RMKeyValidatorLib.a.al, array, 10);
						num = (short)349503497;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 37:
						goto IL_873;
					case 38:
					{
						int num5;
						if (num5 >= 16)
						{
							num = (short)340918299;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						byte[] array2;
						array2[num4++] = array4[num5];
						num5++;
						num = (short)1169948706;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 39:
						goto IL_A15;
					case 40:
						num = (short)1849229315;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 41:
						goto IL_784;
					case 42:
						num = (short)620494905;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 43:
					{
						byte[] array7 = this.a(A_0, this.c);
						array4 = new byte[array7.Length];
						global::System.Array.Copy(array7, array4, array7.Length);
						num = (short)2097545255;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 44:
						goto IL_355;
					case 45:
						if (array4 != null)
						{
							num = (short)30933018;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return flag;
					case 46:
						goto IL_2D2;
					case 47:
						if (flag)
						{
							num = (short)1337524264;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return flag;
					case 48:
					{
						int num10;
						if (this.a(array4, num10 - 1, 0) != array4[num10 - 1])
						{
							num = (short)498925588;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_217;
					}
					case 49:
						goto IL_603;
					case 50:
						goto IL_A15;
					case 51:
					{
						int num3;
						byte[] array6;
						if (array4[num3] != array6[num4++])
						{
							num = (short)670040069;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num3++;
						num = (short)1014038584;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 52:
						goto IL_355;
					case 53:
						flag = false;
						num = (short)529072172;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 54:
						goto IL_9EC;
					case 55:
						if (array4[34] == 254)
						{
							num = (short)545521729;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return flag;
					case 56:
						goto IL_5C3;
					case 57:
						if (this.a == null)
						{
							num = (short)797835296;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1565327395;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 58:
						if (A_2 == global::RMKeyValidatorLib.HardwareKeyType.DEPOT_KEY)
						{
							num = (short)1777336356;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1198522376;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 59:
						flag = false;
						num = (short)101908544;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 60:
						goto IL_603;
					case 61:
					{
						num = (short)79495168;
						short num11 = num;
						int num10 = 45;
						num = (short)1823932464;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 62:
						if (this.c != null)
						{
							num = (short)1854013507;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_9B2;
					case 63:
						num = (short)1971847213;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 64:
						goto IL_43C;
					case 65:
						A_3 = false;
						num = (short)1675886616;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 66:
						A_3 = true;
						num = (short)1524563972;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 67:
						num = (short)96206873;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 68:
						num = (short)33292358;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 69:
						if (num9 >= 10)
						{
							num = (short)796721223;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)936706078;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 70:
						if (array4[34] == 255)
						{
							num = (short)658374669;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1942093879;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 71:
						goto IL_43C;
					case 72:
					{
						int num8;
						if (num8 >= 10)
						{
							num = (short)74973203;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						byte[] array5;
						array5[num8] = 0;
						num8++;
						num = (short)942080046;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 73:
						if (A_2 == global::RMKeyValidatorLib.HardwareKeyType.LABTOOL_KEY)
						{
							num = (short)717357119;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return flag;
					}
					goto IL_156;
					IL_217:
					num = (short)89128982;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2D2:
					num = (short)1557332040;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_355:
					num = (short)1219690510;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_43C:
					array3 = new byte[8];
					num = (short)1796866069;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_5C3:
					num = (short)592314375;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_603:
					num = (short)1885339717;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_748:
					num = (short)857341999;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_784:
					num4 = 0;
					num9 = 0;
					num = (short)380043313;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_7C5:
					num = (short)1572405281;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_873:
					num = (short)946733079;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_9B2:
					flag = false;
					num = (short)1906769970;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_A15:
					num = (short)256376860;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_B3D:
					num = (short)1834745894;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_9EC:
				IL_A6D:
				return flag;
				IL_BCF:
				num = (short)1078329344;
				if (num != 0)
				{
				}
				return flag;
				IL_156:
				array4 = null;
				flag = true;
				A_3 = false;
				num = (short)2008285246;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x0600000B RID: 11 RVA: 0x00003694 File Offset: 0x00001894
		private byte a(byte[] A_0, int A_1, byte A_2)
		{
			switch (0)
			{
			case 0:
				goto IL_40;
			}
			int num;
			short num2;
			byte b2;
			int num4;
			for (;;)
			{
				IL_0A:
				byte b;
				switch (num)
				{
				case 0:
					goto IL_244;
				case 1:
				{
					num2 = (short)1978892259;
					short num3 = num2;
					num2 = (short)1544978403;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_1D7;
					default:
						num2 = (short)1379467264;
						if (num2 != 0)
						{
						}
						b = (byte)(b >> 1 | 128);
						num2 = (short)269287432;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 2:
					return b2;
				case 3:
					goto IL_120;
				case 4:
					goto IL_120;
				case 5:
					if (num4 >= A_1)
					{
						num2 = (short)1949171714;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					b = A_0[num4];
					b ^= A_2;
					A_2 = b;
					num2 = (short)1627127818;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 6:
					b2 = (byte)(b2 >> 1 | 128);
					b2 ^= byte.MaxValue;
					num2 = (short)1662517259;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 7:
					goto IL_1A7;
				case 8:
					goto IL_244;
				case 9:
					if ((b2 & 128) != 0)
					{
						num2 = (short)84475910;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					b2 = (byte)(b2 >> 1);
					num2 = (short)1140523015;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 10:
					if ((b & 128) != 0)
					{
						num2 = (short)1927413761;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					b = (byte)(b >> 1);
					num2 = (short)134283264;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 11:
					goto IL_1A7;
				}
				goto IL_40;
				IL_120:
				num2 = (short)418840581;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_1D7:
				num2 = (short)1604976640;
				short num5 = num2;
				num2 = (short)2039218177;
				if (num2 != 0)
				{
				}
				num2 = (short)1581187076;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_1A7:
				b2 &= 15;
				b += b2;
				b2 = A_2;
				b2 &= 7;
				this.a(ref b2, ref b);
				b = global::RMKeyValidatorLib.a.ay[(int)b];
				b2 ^= b;
				A_2 = b2;
				num4++;
				goto IL_1D7;
				IL_244:
				b = (byte)(b >> 1);
				b ^= A_2;
				b2 = b;
				b = (byte)(b << 1);
				b &= 240;
				num2 = (short)141295625;
				num = (int)((global::System.IntPtr)num2);
			}
			return b2;
			IL_40:
			b2 = 0;
			num4 = 0;
			num2 = (short)2050555907;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x0600000C RID: 12 RVA: 0x00003960 File Offset: 0x00001B60
		private void a(ref byte[] A_0, byte[] A_1, byte[] A_2)
		{
			short num = (short)905969664;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_8E;
				}
				int num9;
				for (;;)
				{
					IL_27:
					switch (num2)
					{
					case 0:
						goto IL_312;
					case 1:
					{
						int num3;
						if (num3 >= 6)
						{
							num = (short)640614407;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						byte b = A_2[num3] + 13;
						A_0[num3 + 74] = b;
						num3++;
						num = (short)804388864;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
					{
						global::System.Array.Copy(A_1, 0, A_0, 48, 10);
						global::System.Array.Copy(A_2, 0, A_0, 58, 6);
						int num4 = 0;
						num = (short)1620508681;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 3:
					{
						num = (short)429654017;
						if (num != 0)
						{
						}
						num = (short)249102336;
						short num5 = num;
						int num6 = 0;
						num = (short)99024917;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 4:
					{
						int num7 = 0;
						num = (short)358285317;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 5:
						goto IL_295;
					case 6:
						goto IL_185;
					case 7:
						return;
					case 8:
						goto IL_185;
					case 9:
						goto IL_2D3;
					case 10:
					{
						int num3 = 0;
						num = (short)1863974931;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 11:
					{
						int num6;
						if (num6 >= 6)
						{
							num = (short)2127101954;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						byte b = (byte)(A_2[num6] << 4);
						A_0[num6 + 42] = b;
						num6++;
						num = (short)50987023;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 12:
					{
						int num8;
						if (num8 >= 10)
						{
							num = (short)675151875;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						byte b = (byte)(A_1[num8] << 4);
						A_0[num8 + 32] = b;
						num8++;
						num = (short)1864761357;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 13:
						goto IL_22F;
					case 14:
						goto IL_295;
					case 15:
						goto IL_485;
					case 16:
					{
						int num7;
						if (num7 >= 6)
						{
							num = (short)175308822;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						byte b = A_2[num7] + 1;
						A_0[num7 + 26] = b;
						num7++;
						num = (short)1905328142;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 17:
					{
						int num4;
						if (num4 >= 10)
						{
							num = (short)1661272074;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						byte b = A_1[num4] + 13;
						A_0[num4 + 64] = b;
						num4++;
						num = (short)837877780;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 18:
						goto IL_22F;
					case 19:
						goto IL_312;
					case 20:
						goto IL_2D3;
					case 21:
						goto IL_485;
					case 22:
					{
						int num8 = 0;
						num = (short)1702690834;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 23:
					{
						if (num9 >= 10)
						{
							num = (short)179765252;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						byte b = A_1[num9] + 1;
						A_0[num9 + 16] = b;
						num9++;
						num = (short)343426186;
						short num10 = num;
						num = (short)422986890;
						switch ((num10 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_185;
						default:
							num = (short)59113472;
							if (num != 0)
							{
							}
							num = (short)1756430342;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					}
					goto IL_8E;
					IL_185:
					num = (short)495910935;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_22F:
					num = (short)178978828;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_295:
					num = (short)825360400;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2D3:
					num = (short)1987051537;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_312:
					num = (short)312016897;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_485:
					num = (short)476774411;
					num2 = (int)((global::System.IntPtr)num);
				}
				return;
				IL_8E:
				global::System.Array.Copy(A_1, 0, A_0, 0, 10);
				global::System.Array.Copy(A_2, 0, A_0, 10, 6);
				num9 = 0;
				num = (short)51707912;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x0600000D RID: 13 RVA: 0x00003E30 File Offset: 0x00002030
		private void a(ref byte[] A_0, byte[] A_1, byte[] A_2, int A_3)
		{
			short num = (short)97452032;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_4E;
				}
				byte[] array;
				byte[] array2;
				int num4;
				for (;;)
				{
					IL_27:
					switch (num2)
					{
					case 0:
						return;
					case 1:
						goto IL_1AA;
					case 2:
					{
						int num3;
						if (num3 >= A_3)
						{
							num = (short)666566657;
							if (num != 0)
							{
							}
							num = (short)2048589830;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						array[0] = A_1[(int)array2[num4 * A_3 + num3]];
						byte b = this.a(array, 1, b);
						num3++;
						num = (short)664862724;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 3:
						goto IL_1AF;
					case 4:
						goto IL_124;
					case 5:
					{
						if (num4 >= 10)
						{
							num = (short)727646208;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						byte b = 0;
						int num3 = 0;
						num = (short)361103361;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 6:
					{
						byte b;
						A_0[num4] = (b ^ A_2[num4]);
						num4++;
						num = (short)1489633287;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 7:
					{
						num = (short)156903321;
						short num5 = num;
						num = (short)136193945;
						switch ((num5 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_1AA;
						default:
						{
							num = (short)1403781120;
							short num6 = num;
							num = (short)2098135040;
							if (num != 0)
							{
							}
							goto IL_1AF;
						}
						}
						break;
					}
					}
					goto IL_4E;
					IL_124:
					num = (short)1374224386;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1AA:
					goto IL_124;
					IL_1AF:
					num = (short)1679949829;
					num2 = (int)((global::System.IntPtr)num);
				}
				return;
				IL_4E:
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
				num = (short)1047724035;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x0600000E RID: 14 RVA: 0x00004064 File Offset: 0x00002264
		private void a(ref byte A_0, ref byte A_1)
		{
			short num = (short)2003240703;
			short num2 = num;
			num = (short)1932461823;
			switch (num2 == num)
			{
			}
			num = (short)449052673;
			if (num != 0)
			{
			}
			num = (short)97320960;
			if (num != 0)
			{
			}
			num = (short)1611071488;
			short num3 = num;
			A_0 ^= A_1;
			A_1 ^= A_0;
			A_0 ^= A_1;
		}

		// Token: 0x0600000F RID: 15 RVA: 0x00004128 File Offset: 0x00002328
		private byte[] a(global::RMIBtnWrapperLib.IIBtnWrapper A_0, byte[] A_1)
		{
			short num = (short)2026438656;
			switch (num)
			{
			default:
			{
				num = (short)625278977;
				if (num != 0)
				{
				}
				num = (short)1641349120;
				int num2 = (int)((global::System.IntPtr)num);
				byte[] array4;
				for (;;)
				{
					byte[] array2;
					switch (num2)
					{
					case 0:
						switch (0)
						{
						case 0:
							goto IL_8F;
						}
						continue;
					case 1:
						goto IL_1D0;
					case 2:
						num = (short)507576325;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
					{
						byte[] array;
						global::System.Array.Clear(array, 0, array.Length);
						num = (short)1911619585;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 4:
					{
						byte[] array;
						if (array != null)
						{
							num = (short)1529020419;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_217;
					}
					case 5:
						goto IL_183;
					case 6:
					{
						byte[] array;
						if (this.a(A_0, out array2, out array, false))
						{
							num = (short)1429798914;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_217;
					}
					case 7:
						goto IL_F9;
					case 8:
					{
						global::AcpCryptoLib.FlashkeyCrypto flashkeyCrypto = new global::AcpCryptoLib.FlashkeyCrypto();
						byte[] array;
						flashkeyCrypto.Init(array2, array);
						byte[] array3 = flashkeyCrypto.Decrypt(A_1);
						array4 = new byte[array3.Length];
						global::System.Array.Copy(array3, 0, array4, 0, array3.Length);
						global::System.Array.Clear(array2, 0, array2.Length);
						num = (short)272302084;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					IL_8F:
					if (A_1 != null)
					{
						array4 = null;
						num = (short)1656684550;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)280992053;
					short num3 = num;
					num = (short)882415925;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num = (short)1163395072;
						if (num != 0)
						{
						}
						num = (short)1634533383;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_183:
					if (array2 == null)
					{
						goto IL_217;
					}
					num = (short)790298632;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_F9:
				throw new global::System.NullReferenceException();
				IL_1D0:
				IL_217:
				num = (short)323813376;
				short num4 = num;
				return array4;
			}
			}
		}

		// Token: 0x06000010 RID: 16 RVA: 0x00004378 File Offset: 0x00002578
		private bool a(global::RMIBtnWrapperLib.IIBtnWrapper A_0, out byte[] A_1, out byte[] A_2, bool A_3)
		{
			short num = (short)99680256;
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
					int num4;
					switch (num2)
					{
					case 0:
						if (A_3)
						{
							num = (short)2120482840;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3FC;
					case 1:
					{
						if (num3 >= 4)
						{
							num = (short)450494470;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						byte[] array;
						A_2[num3] = array[num3];
						num3++;
						num = (short)209977358;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
						if (A_3)
						{
							num = (short)1089142795;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_DF;
					case 3:
					{
						if (num4 >= 8)
						{
							num = (short)869269516;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						byte[] array2;
						A_2[num4] = array2[num4 - 4];
						num4++;
						num = (short)385089558;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 4:
						num = (short)561577984;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						A_1 = new byte[8];
						global::System.Array.Copy(this.a, A_1, 8);
						global::System.Array.Reverse(A_1);
						A_2 = null;
						num = (short)1740636167;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
					{
						byte[] array2 = null;
						ushort a_ = 9;
						num = (short)399900695;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 7:
						if (this.b == 24)
						{
							num = (short)587005973;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						result = true;
						num = (short)208863250;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 8:
						num = (short)1135738889;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 9:
						if (this.a.Length == 8)
						{
							num = (short)612171781;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return result;
					case 10:
						if (this.a != null)
						{
							num = (short)1885798408;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return result;
					case 11:
					{
						byte[] array2;
						int num5 = (int)array2[3] << 24;
						num5 += (int)array2[2] << 16;
						num5 += (int)array2[1] << 8;
						num5 += (int)array2[0];
						num5++;
						array2[3] = (byte)(num5 >> 24);
						array2[2] = (byte)(num5 >> 16);
						array2[1] = (byte)(num5 >> 8);
						array2[0] = (byte)num5;
						num = (short)196673549;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 12:
						result = true;
						num = (short)1660289040;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 13:
						goto IL_DF;
					case 14:
						goto IL_2D8;
					case 15:
						num = (short)1936785409;
						if (num != 0)
						{
						}
						num = (short)726663170;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 16:
						return result;
					case 17:
						goto IL_1AA;
					case 18:
						return result;
					case 19:
						goto IL_3FC;
					case 20:
					{
						num = (short)1377435648;
						short num6 = num;
						goto IL_2D8;
					}
					case 21:
					{
						A_2 = new byte[8];
						byte[] array = null;
						num = (short)785514521;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 22:
						goto IL_1AA;
					case 23:
					{
						byte[] array2;
						ushort a_;
						if (this.a(A_0, a_, out array2))
						{
							goto IL_12B;
						}
						return result;
					}
					case 24:
					{
						byte[] array;
						int num7 = (int)array[3] << 24;
						num7 += (int)array[2] << 16;
						num7 += (int)array[1] << 8;
						num7 += (int)array[0];
						num7++;
						array[3] = (byte)(num7 >> 24);
						array[2] = (byte)(num7 >> 16);
						array[1] = (byte)(num7 >> 8);
						array[0] = (byte)num7;
						num = (short)565116947;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 25:
					{
						byte[] array;
						if (this.a(A_0, 8, out array))
						{
							num = (short)117637124;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return result;
					}
					}
					goto IL_96;
					IL_DF:
					num4 = 4;
					num = (short)159711249;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_12B:
					num = (short)653131791;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2D8:
					num = (short)453910166;
					short num8 = num;
					num = (short)116203158;
					switch ((num8 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_12B;
					default:
						num = (short)1117454336;
						if (num != 0)
						{
						}
						num = (short)1611137025;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_1AA:
					num = (short)2075328515;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_3FC:
					num3 = 0;
					num = (short)949944340;
					num2 = (int)((global::System.IntPtr)num);
				}
				return result;
				IL_96:
				result = false;
				A_1 = null;
				A_2 = null;
				num = (short)541130762;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x06000011 RID: 17 RVA: 0x000048E4 File Offset: 0x00002AE4
		private bool a(global::RMIBtnWrapperLib.IIBtnWrapper A_0, bool A_1)
		{
			int a_ = 10;
			short num = (short)1091239936;
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
				byte[] array;
				byte[] array2;
				bool flag;
				for (;;)
				{
					IL_31:
					bool flag2;
					byte[] array4;
					switch (num2)
					{
					case 0:
					{
						byte b = array[0];
						int num3 = (int)array[1] << 8;
						num3 += (int)array[2];
						array2 = new byte[array.Length - 3];
						global::System.Array.Copy(array, 3, array2, 0, array.Length - 3);
						num = (short)31588403;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 1:
						goto IL_3CE;
					case 2:
						flag = false;
						num = (short)1427374110;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						goto IL_3CE;
					case 4:
						flag = false;
						num = (short)1079771189;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						flag = false;
						num = (short)1433337859;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
						num = (short)1021771810;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
						if (A_1)
						{
							goto IL_187;
						}
						array = new byte[this.c.Length];
						global::System.Array.Copy(this.c, array, this.c.Length);
						num = (short)1446641713;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 8:
						if (this.c != null)
						{
							num = (short)316014634;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_20B;
					case 9:
					{
						int num4;
						if (num4 >= 19)
						{
							num = (short)238223416;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1838481456;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 10:
						if (this.a == null)
						{
							num = (short)1147273270;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)695664679;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 11:
					{
						int num5;
						if (num5 >= 11)
						{
							num = (short)81068065;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1635188774;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 12:
					{
						byte[] array3 = new byte[10];
						global::System.Array.Copy(global::RMKeyValidatorLib.a.au, array3, 10);
						int num6 = 0;
						int num5 = 1;
						num = (short)354615314;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 13:
						goto IL_30A;
					case 14:
						num = (short)699531265;
						if (num != 0)
						{
						}
						num = (short)1995178041;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 15:
					{
						string text = text.ToLower();
						global::System.Collections.ArrayList arrayList = this.a();
						string text2 = "";
						int num7 = 0;
						num = (short)607322143;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 16:
						if (flag)
						{
							num = (short)2012020750;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_5B2;
					case 17:
					{
						num = (short)1808596992;
						short num8 = num;
						string text = "";
						int num9 = 0;
						num = (short)1284374568;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 18:
						goto IL_54F;
					case 19:
						flag2 = true;
						goto IL_4F6;
					case 20:
						goto IL_9DE;
					case 21:
						if (flag)
						{
							num = (short)2138767372;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1A5;
					case 22:
						if (flag)
						{
							num = (short)1420427281;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return flag;
					case 23:
						flag = false;
						num = (short)2107244588;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 24:
					{
						global::System.Array.Copy(this.a, array4, 8);
						global::System.Array.Reverse(array4);
						int num6 = 0;
						int num4 = 11;
						num = (short)1367212077;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 25:
					{
						string text;
						string text2;
						if (!text.Contains(text2))
						{
							num = (short)883818532;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						int num7;
						num7++;
						num = (short)1405091860;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 26:
						goto IL_54F;
					case 27:
						if (flag)
						{
							num = (short)1783758848;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_97A;
					case 28:
					{
						int num9;
						if (num9 >= array.Length)
						{
							num = (short)1705771023;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						string str = string.Format(global::RMKeyValidatorLib.AcpKeyValidator.b("๴䝶䍸ͺ佼ɾ", a_), array[num9]);
						string text;
						text += str;
						num9++;
						num = (short)2064056352;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 29:
						goto IL_3CE;
					case 30:
						goto IL_1A5;
					case 31:
						goto IL_9DE;
					case 32:
						goto IL_2CD;
					case 33:
						goto IL_26A;
					case 34:
						flag2 = this.a(A_0, global::RMIBtnWrapperLib.TimerType.interval);
						goto IL_4F6;
					case 35:
						num = (short)922288138;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 36:
						flag = false;
						num = (short)1045626923;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 37:
					{
						byte[] array5 = this.a(A_0, this.c);
						array = new byte[array5.Length];
						global::System.Array.Copy(array5, array, array5.Length);
						num = (short)1082654749;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 38:
					{
						int num5;
						byte[] array3;
						int num6;
						if (array2[num5] != array3[num6++])
						{
							num = (short)1938292740;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num5++;
						num = (short)869466138;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 39:
						if (this.b != 4)
						{
							num = (short)210370565;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1580531719;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 40:
						goto IL_2CD;
					case 41:
						if (this.c.Length >= 1)
						{
							num = (short)1684996131;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_20B;
					case 42:
						num = (short)1678770217;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 43:
						return flag;
					case 44:
						goto IL_5B2;
					case 45:
						goto IL_30A;
					case 46:
						goto IL_97A;
					case 47:
					{
						global::System.Collections.ArrayList arrayList;
						int num7;
						if (num7 >= arrayList.Count)
						{
							num = (short)403111986;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						string text2 = (string)arrayList[num7];
						text2 = text2.ToLower();
						num = (short)485294105;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 48:
					{
						num = (short)1850081424;
						short num10 = num;
						num = (short)1572602000;
						switch ((num10 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_187;
						default:
						{
							num = (short)587792384;
							if (num != 0)
							{
							}
							int num4;
							int num6;
							if (array2[num4] != array4[num6++])
							{
								num = (short)2089222146;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							num4++;
							num = (short)1346699277;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						break;
					}
					case 49:
						goto IL_3CE;
					case 50:
						return flag;
					case 51:
					{
						byte b;
						int num3;
						if (this.a(array2, num3, 0) != b)
						{
							num = (short)1126170676;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_97A;
					}
					case 52:
						flag = false;
						num = (short)1417674798;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 53:
						goto IL_26A;
					case 54:
						goto IL_20B;
					case 55:
						if (flag)
						{
							num = (short)1575419928;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1A5;
					case 56:
						goto IL_1A5;
					case 57:
						if (!this.a(A_0, global::RMIBtnWrapperLib.TimerType.realTime))
						{
							num = (short)1308360710;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)432603155;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_120;
					IL_187:
					num = (short)223019045;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1A5:
					num = (short)2141585430;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_20B:
					flag = false;
					num = (short)166658049;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_26A:
					array4 = new byte[8];
					num = (short)1733034039;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2CD:
					num = (short)137560092;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_30A:
					num = (short)1198325769;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_3CE:
					num = (short)846528539;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_4F6:
					if (!flag2)
					{
						num = (short)595591191;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_5B2;
					IL_54F:
					num = (short)529661963;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_5B2:
					num = (short)1590493205;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_97A:
					num = (short)1417936912;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_9DE:
					num = (short)1636433967;
					num2 = (int)((global::System.IntPtr)num);
				}
				return flag;
				IL_120:
				array2 = null;
				array = null;
				flag = true;
				num = (short)302710792;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_31;
			}
			}
		}

		// Token: 0x06000012 RID: 18 RVA: 0x00005314 File Offset: 0x00003514
		private bool a(global::RMIBtnWrapperLib.IIBtnWrapper A_0, global::RMIBtnWrapperLib.TimerType A_1)
		{
			short num = (short)1820624397;
			short num2 = num;
			num = (short)547128845;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)1719533568;
				if (num != 0)
				{
				}
				num = (short)622854144;
				short num3 = num;
				num = (short)861143041;
				if (num != 0)
				{
				}
				num = (short)1984495616;
				int num4 = (int)num;
				switch (num4)
				{
				}
				break;
			}
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
					goto IL_107;
				}
				int num4;
				for (;;)
				{
					IL_D8:
					switch (num4)
					{
					case 0:
						result = true;
						num = (short)434569217;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						goto IL_239;
					case 2:
					{
						byte b5 = array[0];
						byte b6 = array[1];
						if ((b5 & b2) == b)
						{
							num = (short)892665864;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_239;
					}
					case 3:
						if (A_1 == global::RMIBtnWrapperLib.TimerType.realTime)
						{
							num = (short)1863450630;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						b = 0;
						b4 = 80;
						b2 = 16;
						b3 = 16;
						num = (short)1390542855;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
					{
						byte b6;
						if ((b6 & b4) == b3)
						{
							num = (short)2091450368;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_239;
					}
					case 5:
						goto IL_1F2;
					case 6:
						b = 0;
						b4 = 16;
						b2 = 8;
						b3 = 16;
						num = (short)1044316165;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
						goto IL_1F2;
					case 8:
						num = (short)1041629188;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					case 9:
						goto IL_252;
					}
					goto IL_107;
					IL_1F2:
					num = (short)721289218;
					num4 = (int)((global::System.IntPtr)num);
					continue;
					IL_239:
					num = (short)1273495561;
					num4 = (int)((global::System.IntPtr)num);
				}
				IL_252:
				return result;
				IL_107:
				A_0.ReadMemoryData(0, 2, 30, array);
				num = (short)107479043;
				num4 = (int)((global::System.IntPtr)num);
				goto IL_D8;
			}
			catch
			{
				result = false;
			}
			return result;
		}

		// Token: 0x06000013 RID: 19 RVA: 0x00005598 File Offset: 0x00003798
		private bool a(global::RMIBtnWrapperLib.IIBtnWrapper A_0, ushort A_1, out byte[] A_2)
		{
			short num = (short)1017970688;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_63;
				}
				byte addrLSB;
				byte addrMSB;
				short num3;
				bool result;
				for (;;)
				{
					IL_28:
					switch (num2)
					{
					case 0:
						try
						{
							A_0.ReadMemoryData(addrLSB, addrMSB, num3, A_2);
							return result;
						}
						catch
						{
							A_2 = null;
							return false;
						}
						goto IL_148;
					case 1:
						num = (short)832700427;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						goto IL_1BE;
					case 3:
						goto IL_1BE;
					case 4:
						goto IL_1BE;
					case 5:
						goto IL_1BE;
					case 6:
						switch (A_1)
						{
						case 8:
							goto IL_148;
						case 9:
							addrLSB = 100;
							num = (short)843907077;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 10:
							addrLSB = 104;
							num = (short)812646404;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 11:
							addrLSB = 108;
							num = (short)1464860673;
							if (num != 0)
							{
							}
							num = (short)275316748;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 12:
							addrLSB = 112;
							num = (short)184090631;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 13:
							goto IL_ED;
						case 14:
						{
							num = (short)1254817792;
							short num4 = num;
							addrLSB = 120;
							num = (short)231079938;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 15:
							addrLSB = 124;
							num = (short)725942280;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						default:
							num = (short)1346633729;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					case 7:
						goto IL_1BE;
					case 8:
						goto IL_1BE;
					case 9:
						goto IL_1BE;
					case 10:
						goto IL_1BE;
					case 11:
					{
						num = (short)1846025298;
						short num5 = num;
						num = (short)1678711890;
						switch ((num5 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_ED;
						default:
							num = (short)1283981312;
							if (num != 0)
							{
							}
							addrLSB = 96;
							num = (short)68091913;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 12:
						goto IL_1BE;
					}
					goto IL_63;
					IL_ED:
					addrLSB = 116;
					num = (short)546766858;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_148:
					addrLSB = 96;
					num = (short)793772035;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1BE:
					num = (short)637009920;
					num2 = (int)((global::System.IntPtr)num);
				}
				return result;
				IL_63:
				result = true;
				addrMSB = 2;
				addrLSB = 0;
				num3 = 4;
				A_2 = new byte[(int)num3];
				num = (short)1786183686;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_28;
			}
			}
		}

		// Token: 0x06000014 RID: 20 RVA: 0x0000588C File Offset: 0x00003A8C
		private global::System.Collections.ArrayList a()
		{
			int a_ = 15;
			short num = (short)553904225;
			short num2 = num;
			num = (short)2131552353;
			switch (num2 == num)
			{
			default:
			{
				num = (short)859176960;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1277886464;
			if (num != 0)
			{
			}
			num = (short)1691090945;
			if (num != 0)
			{
			}
			global::System.Collections.ArrayList arrayList = new global::System.Collections.ArrayList();
			global::System.Guid guid = new global::System.Guid(global::RMKeyValidatorLib.AcpKeyValidator.b("Ź䱻ٽ쉿욁잃뒅춇뎉쾋쪍벏ꊑꆕ궗\ud899ꖛ늝邟\udaa1那鞥鶧銩肫햭肯쪱薵钷誹쒻貽莿뻅難韛ﻍ꣏釓𥉉ꋙ鯝쳟틡鳣\udfe5탧웩\udceb雭뗯싱\ud8f3웵胷쫹엻菽緿", a_));
			string text = guid.ToString();
			text = text.Replace(global::RMKeyValidatorLib.AcpKeyValidator.b("坹", a_), "");
			text = text.ToUpper();
			arrayList.Add(text);
			arrayList.Add(global::RMKeyValidatorLib.AcpKeyValidator.b("䡹䡻䵽뒁뺅낇", a_));
			return arrayList;
		}

		// Token: 0x04000003 RID: 3
		private byte[] a;

		// Token: 0x04000004 RID: 4
		private byte b;

		// Token: 0x04000005 RID: 5
		private byte[] c;

		// Token: 0x04000006 RID: 6
		private global::RMKeyValidatorLib.HardwareKeyType d;
	}
}
