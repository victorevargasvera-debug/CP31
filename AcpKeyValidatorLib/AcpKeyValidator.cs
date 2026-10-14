using System;
using IBtnWrapperLib;

namespace AcpKeyValidatorLib
{
	// Token: 0x02000008 RID: 8
	public class AcpKeyValidator
	{
		// Token: 0x06000016 RID: 22 RVA: 0x0000599C File Offset: 0x00003B9C
		public bool IsDepotKeyAttached()
		{
			short num = (short)648314913;
			short num2 = num;
			num = (short)634617889;
			switch (num2 == num)
			{
			}
			num = (short)1369309185;
			if (num != 0)
			{
			}
			num = (short)2005008384;
			if (num != 0)
			{
			}
			num = (short)163577856;
			short num3 = num;
			bool flag = true;
			return this.a(global::AcpKeyValidatorLib.HardwareKeyType.DEPOT_KEY, out flag);
		}

		// Token: 0x06000017 RID: 23 RVA: 0x00005A54 File Offset: 0x00003C54
		public bool IsLabtoolKeyAttached(out bool bFullAccess)
		{
			short num = (short)1497184935;
			short num2 = num;
			num = (short)1999190695;
			switch (num2 == num)
			{
			}
			num = (short)1584070657;
			if (num != 0)
			{
			}
			num = (short)634060800;
			if (num != 0)
			{
			}
			num = (short)1771765760;
			short num3 = num;
			bFullAccess = false;
			return this.a(global::AcpKeyValidatorLib.HardwareKeyType.LABTOOL_KEY, out bFullAccess);
		}

		// Token: 0x06000018 RID: 24 RVA: 0x00005B08 File Offset: 0x00003D08
		public bool IsFTRKeyAttached()
		{
			short num = (short)705048025;
			short num2 = num;
			num = (short)1975135705;
			switch (num2 == num)
			{
			}
			num = (short)1065811969;
			if (num != 0)
			{
			}
			num = (short)192675840;
			if (num != 0)
			{
			}
			num = (short)266731520;
			short num3 = num;
			bool flag = true;
			return this.a(global::AcpKeyValidatorLib.HardwareKeyType.FTR_KEY, out flag);
		}

		// Token: 0x06000019 RID: 25 RVA: 0x00005BBC File Offset: 0x00003DBC
		internal bool a(global::AcpKeyValidatorLib.HardwareKeyType A_0, out bool A_1)
		{
			short num = (short)1929248768;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_5C;
				}
				bool flag;
				int options;
				for (;;)
				{
					IL_29:
					short num4;
					short num5;
					switch (num2)
					{
					case 0:
						if (A_0 != global::AcpKeyValidatorLib.HardwareKeyType.LABTOOL_KEY)
						{
							num = (short)56557569;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_81D;
					case 1:
					{
						num = (short)1928528353;
						short num3 = num;
						num = (short)1419968993;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_B3;
						default:
							num = (short)343277568;
							if (num != 0)
							{
							}
							num = (short)1836646403;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 2:
						if (A_0 != global::AcpKeyValidatorLib.HardwareKeyType.FTR_KEY)
						{
							num = (short)1687552010;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_81D;
					case 3:
						if (A_0 != global::AcpKeyValidatorLib.HardwareKeyType.DEPOT_KEY)
						{
							num = (short)1034420230;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_81D;
					case 4:
						return flag;
					case 5:
						goto IL_7E3;
					case 6:
						num = (short)1124925442;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
						goto IL_7E3;
					case 8:
						goto IL_B3;
					case 9:
						if (num4 > num5)
						{
							num = (short)758448132;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1822294024;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 10:
						return false;
					}
					goto IL_5C;
					IL_B3:
					num = (short)959709185;
					if (num != 0)
					{
					}
					num = (short)1094844416;
					short num6 = num;
					global::IBtnWrapperLib.MultiBtnWrapper multiBtnWrapper;
					try
					{
						switch (0)
						{
						case 0:
							goto IL_272;
						}
						short num7;
						for (;;)
						{
							IL_1FB:
							bool flag2;
							short num8;
							short family;
							switch (num2)
							{
							case 0:
								goto IL_741;
							case 1:
								if (flag)
								{
									num = (short)2059730964;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								num = (short)1685454866;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 2:
								num7 = 2;
								num = (short)59834393;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 3:
								goto IL_6E2;
							case 4:
								goto IL_317;
							case 5:
								if (A_0 == global::AcpKeyValidatorLib.HardwareKeyType.FTR_KEY)
								{
									num = (short)1313538060;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_35B;
							case 6:
								goto IL_77B;
							case 7:
								goto IL_35B;
							case 8:
								if (!flag)
								{
									num = (short)1037369368;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_741;
							case 9:
								if (flag2)
								{
									num = (short)2075197453;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_77B;
							case 10:
								if (flag)
								{
									num = (short)1966342147;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								multiBtnWrapper.PortNumber = num8;
								family = 255;
								num = (short)977666053;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 11:
								goto IL_3C0;
							case 12:
								family = 4;
								num = (short)1836843015;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 13:
								goto IL_3A0;
							case 14:
								if (!flag)
								{
									num = (short)62586902;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_6E2;
							case 15:
								if (multiBtnWrapper.PortType == 6)
								{
									num = (short)1942093826;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_720;
							case 16:
								if (flag2)
								{
									num = (short)328073235;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_77B;
							case 17:
								try
								{
									switch (0)
									{
									case 0:
										goto IL_54C;
									}
									global::AcpKeyValidatorLib.AcpiButton acpiButton;
									for (;;)
									{
										IL_515:
										switch (num2)
										{
										case 0:
											if (A_0 == global::AcpKeyValidatorLib.HardwareKeyType.DEPOT_KEY)
											{
												num = (short)156303362;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											num = (short)64487435;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										case 1:
											if (flag)
											{
												num = (short)1326317571;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											goto IL_6BA;
										case 2:
											flag = acpiButton.IsDepot(multiBtnWrapper, out A_1);
											num = (short)869793793;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										case 3:
											this.DepotKeySerialNum = multiBtnWrapper.GetROMSerialNum();
											num = (short)1335427076;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										case 4:
											goto IL_6BA;
										case 5:
											flag = acpiButton.IsFTR(multiBtnWrapper);
											A_1 = true;
											num = (short)1369440263;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										case 6:
											flag = acpiButton.IsLabTool(multiBtnWrapper, out A_1);
											num = (short)1577385993;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										case 7:
											goto IL_6BA;
										case 8:
											goto IL_6D5;
										case 9:
											goto IL_6BA;
										case 10:
											if (A_0 == global::AcpKeyValidatorLib.HardwareKeyType.FTR_KEY)
											{
												num = (short)1707868165;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											goto IL_6BA;
										case 11:
											if (A_0 == global::AcpKeyValidatorLib.HardwareKeyType.LABTOOL_KEY)
											{
												num = (short)232914950;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											num = (short)1760428042;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										goto IL_54C;
										IL_6BA:
										acpiButton = null;
										num = (short)1371996168;
										num2 = (int)((global::System.IntPtr)num);
									}
									IL_6D5:
									goto IL_422;
									IL_54C:
									multiBtnWrapper.OpenNonMotoBtn(options);
									acpiButton = new global::AcpKeyValidatorLib.AcpiButton();
									num = (short)160497664;
									num2 = (int)((global::System.IntPtr)num);
									goto IL_515;
								}
								catch
								{
									flag = false;
									goto IL_422;
								}
								goto IL_6E2;
								IL_422:
								num = (short)782041096;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 18:
								goto IL_7CF;
							case 19:
								num = (short)1278279703;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 20:
								num = (short)871890948;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 21:
								if (num8 <= 15)
								{
									num = (short)705167387;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_6E2;
							case 22:
								num8 += 1;
								num = (short)818479115;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 23:
								if (flag)
								{
									num = (short)352780294;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_3A0;
							case 24:
								flag2 = multiBtnWrapper.FindNextBtn();
								num = (short)852099072;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 25:
								goto IL_720;
							case 26:
								goto IL_3C0;
							case 27:
								num = (short)602603530;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_272;
							IL_35B:
							flag2 = multiBtnWrapper.FindFirstBtn(family);
							num = (short)1505427465;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_3A0:
							num = (short)503709713;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_3C0:
							num = (short)2065432597;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_6E2:
							num = (short)857014273;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_720:
							num8 = num7;
							num = (short)169869338;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_741:
							num = (short)255393808;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_77B:
							num = (short)1569914894;
							num2 = (int)((global::System.IntPtr)num);
						}
						IL_317:
						return flag;
						IL_7CF:
						goto IL_147;
						IL_272:
						multiBtnWrapper.PortType = num4;
						multiBtnWrapper.CreateButton();
						num7 = 1;
						num = (short)389218319;
						num2 = (int)((global::System.IntPtr)num);
						goto IL_1FB;
					}
					catch
					{
						flag = false;
						goto IL_147;
					}
					finally
					{
						multiBtnWrapper.CloseButton();
					}
					goto IL_7E3;
					IL_147:
					num4 += 4;
					num = (short)2058223621;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_7E3:
					num = (short)306315273;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_81D:
					short num9 = 2;
					num5 = 2;
					num5 = 6;
					multiBtnWrapper = new global::IBtnWrapperLib.MultiBtnWrapper();
					num4 = num9;
					num = (short)1553203207;
					num2 = (int)((global::System.IntPtr)num);
				}
				return false;
				IL_5C:
				flag = false;
				options = 0;
				A_1 = false;
				num = (short)1132920832;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_29;
			}
			}
		}

		// Token: 0x0600001B RID: 27 RVA: 0x00006474 File Offset: 0x00004674
		internal static string b(string A_0, int A_1)
		{
			char[] array = A_0.ToCharArray();
			int num = (int)((global::System.IntPtr)(774226351 + A_1) + (global::System.IntPtr)94 + (global::System.IntPtr)22 + (global::System.IntPtr)9 + (global::System.IntPtr)46);
			int num3;
			int num2;
			if ((num2 = (num3 = 0)) < 1)
			{
				goto IL_63;
			}
			IL_30:
			int num5;
			int num4 = num5 = num2;
			char[] array2 = array;
			int num6 = num5;
			char c = array[num5];
			byte b = (byte)((int)(c & 'ÿ') ^ num++);
			byte b2 = (byte)((int)(c >> 8) ^ num++);
			byte b3 = b2;
			b2 = b;
			b = b3;
			array2[num6] = (ushort)((int)b2 << 8 | (int)b);
			num3 = num4 + 1;
			IL_63:
			if ((num2 = num3) >= array.Length)
			{
				return string.Intern(new string(array));
			}
			goto IL_30;
		}

		// Token: 0x0400000D RID: 13
		public byte[] DepotKeySerialNum;
	}
}
