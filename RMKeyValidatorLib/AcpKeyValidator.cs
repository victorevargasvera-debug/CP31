using System;
using RMIBtnWrapperLib;

namespace RMKeyValidatorLib
{
	// Token: 0x02000008 RID: 8
	public class AcpKeyValidator
	{
		// Token: 0x06000016 RID: 22 RVA: 0x000059B8 File Offset: 0x00003BB8
		public bool IsDepotKeyAttached()
		{
			short num = (short)1617615814;
			short num2 = num;
			num = (short)1229249478;
			switch (num2 == num)
			{
			default:
			{
				num = (short)259063808;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1782579201;
			if (num != 0)
			{
			}
			num = (short)836173824;
			if (num != 0)
			{
			}
			bool flag = true;
			return this.a(global::RMKeyValidatorLib.HardwareKeyType.DEPOT_KEY, out flag);
		}

		// Token: 0x06000017 RID: 23 RVA: 0x00005A70 File Offset: 0x00003C70
		public bool IsLabtoolKeyAttached(out bool bFullAccess)
		{
			short num = (short)2024895423;
			short num2 = num;
			num = (short)2086368191;
			switch (num2 == num)
			{
			default:
			{
				num = (short)864092160;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1952907265;
			if (num != 0)
			{
			}
			num = (short)568066048;
			if (num != 0)
			{
			}
			bFullAccess = false;
			return this.a(global::RMKeyValidatorLib.HardwareKeyType.LABTOOL_KEY, out bFullAccess);
		}

		// Token: 0x06000018 RID: 24 RVA: 0x00005B24 File Offset: 0x00003D24
		public bool IsFTRKeyAttached()
		{
			short num = (short)1879473187;
			short num2 = num;
			num = (short)129006627;
			switch (num2 == num)
			{
			default:
			{
				num = (short)291045376;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)875298817;
			if (num != 0)
			{
			}
			num = (short)1805844480;
			if (num != 0)
			{
			}
			bool flag = true;
			return this.a(global::RMKeyValidatorLib.HardwareKeyType.FTR_KEY, out flag);
		}

		// Token: 0x06000019 RID: 25 RVA: 0x00005BD8 File Offset: 0x00003DD8
		internal bool a(global::RMKeyValidatorLib.HardwareKeyType A_0, out bool A_1)
		{
			short num = (short)1952841728;
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
					short num3;
					short num4;
					global::RMIBtnWrapperLib.MultiBtnWrapper multiBtnWrapper;
					switch (num2)
					{
					case 0:
						num = (short)1887698945;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						if (A_0 != global::RMKeyValidatorLib.HardwareKeyType.FTR_KEY)
						{
							num = (short)22413318;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_7DA;
					case 2:
						if (A_0 != global::RMKeyValidatorLib.HardwareKeyType.DEPOT_KEY)
						{
							num = (short)1888485376;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_7DA;
					case 3:
						if (num3 > num4)
						{
							num = (short)894173193;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)579862536;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
					{
						if (A_0 == global::RMKeyValidatorLib.HardwareKeyType.LABTOOL_KEY)
						{
							goto IL_7DA;
						}
						num = (short)1004763456;
						short num5 = num;
						num = (short)1308457280;
						switch ((num5 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_7DA;
						default:
							num = (short)634781696;
							if (num != 0)
							{
							}
							num = (short)421003271;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 5:
						goto IL_776;
					case 6:
						return false;
					case 7:
						num = (short)530513921;
						if (num != 0)
						{
						}
						num = (short)1789001730;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 8:
						try
						{
							switch (0)
							{
							case 0:
								goto IL_253;
							}
							short num7;
							for (;;)
							{
								IL_1DC:
								short family;
								short num6;
								bool flag2;
								switch (num2)
								{
								case 0:
									goto IL_762;
								case 1:
									goto IL_2FA;
								case 2:
									family = 4;
									num = (short)2025259017;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 3:
									num = (short)358350867;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 4:
									goto IL_6D3;
								case 5:
									num = (short)83034135;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 6:
									goto IL_675;
								case 7:
									if (num6 <= 15)
									{
										num = (short)746258435;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_675;
								case 8:
									try
									{
										switch (0)
										{
										case 0:
											goto IL_523;
										}
										global::RMKeyValidatorLib.AcpiButton acpiButton;
										for (;;)
										{
											IL_4F4:
											switch (num2)
											{
											case 0:
												if (A_0 == global::RMKeyValidatorLib.HardwareKeyType.LABTOOL_KEY)
												{
													num = (short)1498939394;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												num = (short)1292238853;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											case 1:
												goto IL_64D;
											case 2:
												flag = acpiButton.IsLabTool(multiBtnWrapper, out A_1);
												num = (short)1140391943;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											case 3:
												if (A_0 == global::RMKeyValidatorLib.HardwareKeyType.DEPOT_KEY)
												{
													num = (short)1435238406;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												num = (short)984023040;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											case 4:
												flag = acpiButton.IsFTR(multiBtnWrapper);
												A_1 = true;
												num = (short)868089864;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											case 5:
												if (A_0 == global::RMKeyValidatorLib.HardwareKeyType.FTR_KEY)
												{
													num = (short)1068630020;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												goto IL_64D;
											case 6:
												flag = acpiButton.IsDepot(multiBtnWrapper, out A_1);
												num = (short)1260781569;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											case 7:
												goto IL_64D;
											case 8:
												goto IL_64D;
											case 9:
												goto IL_668;
											}
											goto IL_523;
											IL_64D:
											acpiButton = null;
											num = (short)86638601;
											num2 = (int)((global::System.IntPtr)num);
										}
										IL_668:
										goto IL_402;
										IL_523:
										multiBtnWrapper.OpenNonMotoBtn(options);
										acpiButton = new global::RMKeyValidatorLib.AcpiButton();
										num = (short)211550211;
										num2 = (int)((global::System.IntPtr)num);
										goto IL_4F4;
									}
									catch
									{
										flag = false;
										goto IL_402;
									}
									goto IL_675;
									IL_402:
									num = (short)1621229579;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 9:
									goto IL_33E;
								case 10:
									goto IL_70D;
								case 11:
									if (!flag)
									{
										num = (short)1647247380;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_6D3;
								case 12:
									if (multiBtnWrapper.PortType == 6)
									{
										num = (short)2027618325;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_6B1;
								case 13:
									if (flag2)
									{
										num = (short)1862795289;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_70D;
								case 14:
									goto IL_3A3;
								case 15:
									if (flag2)
									{
										num = (short)871432197;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_70D;
								case 16:
									goto IL_3A3;
								case 17:
									if (A_0 == global::RMKeyValidatorLib.HardwareKeyType.FTR_KEY)
									{
										num = (short)29294594;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_33E;
								case 18:
									num = (short)11534337;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 19:
									if (flag)
									{
										num = (short)2013790214;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									multiBtnWrapper.PortNumber = num6;
									family = 255;
									num = (short)1035206673;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 20:
									flag2 = multiBtnWrapper.FindNextBtn();
									num = (short)2114060292;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 21:
									num7 = 2;
									num = (short)360775704;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 22:
									if (flag)
									{
										num = (short)566755346;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)170852352;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 23:
									if (flag)
									{
										num = (short)1066205194;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_385;
								case 24:
									goto IL_6B1;
								case 25:
									goto IL_385;
								case 26:
									if (!flag)
									{
										num = (short)1561985051;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_675;
								case 27:
									num6 += 1;
									num = (short)530382864;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_253;
								IL_33E:
								flag2 = multiBtnWrapper.FindFirstBtn(family);
								num = (short)1436483597;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_385:
								num = (short)889978888;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_3A3:
								num = (short)17956871;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_675:
								num = (short)1527709718;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_6B1:
								num6 = num7;
								num = (short)471138318;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_6D3:
								num = (short)465698831;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_70D:
								num = (short)154599450;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_2FA:
							return flag;
							IL_762:
							goto IL_16D;
							IL_253:
							multiBtnWrapper.PortType = num3;
							multiBtnWrapper.CreateButton();
							num7 = 1;
							num = (short)1948581900;
							num2 = (int)((global::System.IntPtr)num);
							goto IL_1DC;
						}
						catch
						{
							flag = false;
							goto IL_16D;
						}
						finally
						{
							multiBtnWrapper.CloseButton();
						}
						goto IL_776;
						IL_16D:
						num3 += 4;
						num = (short)207618053;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 9:
						goto IL_7AF;
					case 10:
						goto IL_776;
					}
					goto IL_5C;
					IL_776:
					num = (short)275120131;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_7DA:
					short num8 = 2;
					num4 = 2;
					num4 = 6;
					multiBtnWrapper = new global::RMIBtnWrapperLib.MultiBtnWrapper();
					num3 = num8;
					num = (short)1549402122;
					num2 = (int)((global::System.IntPtr)num);
				}
				return false;
				IL_7AF:
				num = (short)575668224;
				short num9 = num;
				return flag;
				IL_5C:
				flag = false;
				options = 0;
				A_1 = false;
				num = (short)1255079940;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_29;
			}
			}
		}

		// Token: 0x0600001B RID: 27 RVA: 0x00006450 File Offset: 0x00004650
		internal static string b(string A_0, int A_1)
		{
			char[] array = A_0.ToCharArray();
			int num = (int)((global::System.IntPtr)(1474127795 + A_1) + (global::System.IntPtr)94 + (global::System.IntPtr)34 + (global::System.IntPtr)23 + (global::System.IntPtr)32);
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
	}
}
