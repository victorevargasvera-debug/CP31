using System;
using System.Collections.Generic;
using AcpCommonLib;
using SpecialFeatures.AcpReportManagerLib;

namespace SpecialFeatures.Flashport.FlashRadio
{
	// Token: 0x020000EE RID: 238
	public static class FlashcodeGenerator
	{
		// Token: 0x06000DE1 RID: 3553 RVA: 0x00131618 File Offset: 0x0012F818
		public static void CalculateFlashcode(ref string flashcodeResult, string strModelNumber = "")
		{
			int a_ = 13;
			short num = (short)1976041472;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				bool[,] array = new bool[24, 8];
				byte[] array2 = new byte[24];
				bool[] array3 = new bool[8];
				global::SpecialFeatures.Flashport.FlashRadio.FlashcodeTable flashcodeTable = new global::SpecialFeatures.Flashport.FlashRadio.FlashcodeTable();
				try
				{
					switch (0)
					{
					case 0:
						goto IL_94;
					}
					for (;;)
					{
						IL_51:
						global::System.Collections.Generic.IList<global::SpecialFeatures.Flashport.FlashRadio.Option> optionsByPosition;
						int num4;
						int num5;
						switch (num2)
						{
						case 0:
						{
							num = (short)904496211;
							short num3 = num;
							num = (short)881624147;
							switch ((num3 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_91C;
							default:
								num = (short)170065920;
								if (num != 0)
								{
								}
								goto IL_1BC;
							}
							break;
						}
						case 1:
							if (optionsByPosition != null)
							{
								num = (short)1547567107;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_199;
						case 2:
							if (num4 >= 24)
							{
								num = (short)44105737;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							num5 = 0;
							num = (short)249626629;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 3:
						{
							global::System.Collections.Generic.IEnumerator<global::SpecialFeatures.Flashport.FlashRadio.Option> enumerator = optionsByPosition.GetEnumerator();
							num = (short)1435828230;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 4:
							goto IL_12D;
						case 5:
							goto IL_956;
						case 6:
							try
							{
								num = (short)982122517;
								num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									switch (num2)
									{
									case 2:
									{
										int fieldValue;
										switch (fieldValue)
										{
										case 1:
											array3[7] = true;
											num = (short)385744896;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										case 2:
											array3[6] = true;
											num = (short)220528672;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										case 3:
											array3[6] = true;
											array3[7] = true;
											num = (short)1469054980;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										case 4:
											array3[5] = true;
											num = (short)1957953542;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										case 5:
											array3[5] = true;
											array3[7] = true;
											num = (short)1091174426;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										case 6:
										case 7:
											break;
										case 8:
											array3[4] = true;
											num = (short)481624092;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										default:
											num = (short)541261861;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										break;
									}
									case 3:
									{
										string name;
										if (!(name == global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("슏\udf95ﲙ튝솟삡킣즥잧용ﲫ\udcad\ud9af\udfb1햳쒵솷\uddbb킽꒿뇁鯃蟅難柳", a_)))
										{
											num = (short)1159004178;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										num = (short)878968844;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 5:
										array3[3] = true;
										array3[2] = true;
										num = (short)768540687;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 7:
									{
										string name;
										if (!(name == global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("슏\udf95ﲙ튝솟삡킣즥잧용ﾫ쮭펯\uddb1\udab3튵\ud9b7좹얻ﲽꆿ곁ꃃ뗅韇诉ﻋ﷍", a_)))
										{
											num = (short)1672740893;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										num = (short)523108354;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 9:
									{
										string name;
										if (!(name == global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("슏\udf95ﲙ튝솟삡킣즥잧용肯蚱貳辵誷蒻螽觃軅鋇闉跋鬒", a_)))
										{
											num = (short)1582891032;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										num = (short)1948844071;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 12:
									{
										int fieldValue;
										switch (fieldValue)
										{
										case 1:
											array3[7] = true;
											num = (short)1319698463;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										case 2:
											array3[6] = true;
											num = (short)656146440;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										case 3:
											array3[6] = true;
											array3[7] = true;
											num = (short)1555234826;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										case 4:
											array3[5] = true;
											num = (short)989921281;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										case 5:
											array3[5] = true;
											array3[7] = true;
											num = (short)1301020699;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										case 6:
											array3[5] = true;
											array3[6] = true;
											num = (short)1066663955;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										case 7:
											array3[5] = true;
											array3[6] = true;
											array3[7] = true;
											num = (short)559087627;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										case 8:
											array3[4] = true;
											num = (short)943456270;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										default:
											num = (short)389873680;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										break;
									}
									case 13:
										goto IL_88E;
									case 16:
										num = (short)265551908;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 18:
										num = (short)1140981767;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 20:
									{
										string name;
										if (!(name == global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("슏\udf95ﲙ튝솟삡킣즥잧용ﶫ肯花膳肵膷讻蚽觃軅鋇闉跋鬒", a_)))
										{
											num = (short)1106575385;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										num = (short)1112670241;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 21:
										switch (0)
										{
										case 0:
											goto IL_2C5;
										}
										continue;
									case 22:
									{
										int fieldValue;
										array[num4, num5] = global::System.Convert.ToBoolean(fieldValue);
										array3[num5] = array[num4, num5];
										num = (short)637665314;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 23:
										num = (short)423493645;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 24:
										num = (short)2035679235;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 25:
										num = (short)1230766089;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 29:
										num = (short)2108686358;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 33:
									{
										int fieldValue;
										if (fieldValue == 3)
										{
											num = (short)1304363043;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										break;
									}
									case 35:
										array3[3] = true;
										array3[4] = true;
										num = (short)556990494;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 37:
										num = (short)717357073;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 38:
									{
										global::System.Collections.Generic.IEnumerator<global::SpecialFeatures.Flashport.FlashRadio.Option> enumerator;
										if (!enumerator.MoveNext())
										{
											num = (short)1942552599;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										global::AcpCommonLib.IAcpField dbField = enumerator.Current.DbField;
										int fieldValue = flashcodeTable.GetFieldValue(dbField);
										string name = dbField.Name;
										num = (short)956694548;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 39:
									{
										int fieldValue;
										if (fieldValue == 3)
										{
											num = (short)576782341;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										break;
									}
									}
									IL_78F:
									num = (short)390987814;
									num2 = (int)((global::System.IntPtr)num);
									continue;
									IL_2C5:
									goto IL_78F;
								}
								IL_88E:
								goto IL_199;
							}
							finally
							{
								num = (short)1534853122;
								num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									global::System.Collections.Generic.IEnumerator<global::SpecialFeatures.Flashport.FlashRadio.Option> enumerator;
									switch (num2)
									{
									case 0:
										goto IL_8FF;
									case 1:
										enumerator.Dispose();
										num = (short)592904192;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 2:
										switch (0)
										{
										case 0:
											goto IL_8C6;
										}
										continue;
									}
									IL_8C6:
									if (enumerator == null)
									{
										break;
									}
									num = (short)1205993473;
									num2 = (int)((global::System.IntPtr)num);
								}
								IL_8FF:;
							}
							goto IL_902;
						case 7:
							goto IL_A00;
						case 8:
							if (num5 >= 8)
							{
								num = (short)2126184461;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_902;
						case 9:
							num = (short)303104007;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 10:
							if (array != null)
							{
								num = (short)332726286;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_12D;
						case 11:
							goto IL_956;
						case 12:
							goto IL_1BC;
						case 13:
							array2[num4] = global::System.Convert.ToByte(global::SpecialFeatures.Flashport.FlashRadio.FlashcodeGenerator.a(array3));
							global::System.Array.Clear(array3, 0, 8);
							num4++;
							num = (short)1442054156;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 14:
						{
							int length = array.Length;
							num = (short)181403652;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						goto IL_94;
						IL_12D:
						num4 = 0;
						num = (short)247267328;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_199:
						num5++;
						num = (short)1293484043;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_1BC:
						num = (short)1367605250;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_91C:
						num = (short)1488388097;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_902:
						int position = num4 * 8 + num5 + 1;
						optionsByPosition = flashcodeTable.FLASHcode.GetOptionsByPosition(position);
						goto IL_91C;
						IL_956:
						num = (short)554303496;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_A00:
					goto IL_A9A;
					IL_94:
					flashcodeTable.InitTable(true, strModelNumber, false);
					num = (short)1496973322;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_51;
				}
				finally
				{
					num = (short)1705771009;
					if (num != 0)
					{
					}
					num = (short)25296898;
					num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
							goto IL_A97;
						case 1:
							((global::System.IDisposable)flashcodeTable).Dispose();
							num = (short)82640896;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
							switch (0)
							{
							case 0:
								goto IL_A5F;
							}
							continue;
						}
						IL_A5F:
						if (flashcodeTable == null)
						{
							break;
						}
						num = (short)750977025;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_A97:;
				}
				IL_A9A:
				num = (short)868548608;
				short num6 = num;
				flashcodeResult = global::SpecialFeatures.Flashport.FlashRadio.FlashcodeFormatter.FormatFlashcodeString(array2, array2.Length);
				return;
			}
			}
		}

		// Token: 0x06000DE2 RID: 3554 RVA: 0x00132128 File Offset: 0x00130328
		private static int a(bool[] A_0)
		{
			switch (0)
			{
			case 0:
				goto IL_38;
			}
			int num;
			short num2;
			int num3;
			for (;;)
			{
				IL_0A:
				int num5;
				switch (num)
				{
				case 0:
					goto IL_10D;
				case 1:
					goto IL_147;
				case 2:
					goto IL_10D;
				case 3:
					if (A_0 != null)
					{
						num2 = (short)2103967749;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_147;
				case 4:
					return num3;
				case 5:
				{
					int num4 = A_0.Length;
					num2 = (short)213516289;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 6:
					if (num5 >= 8)
					{
						num2 = (short)872218628;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_8E;
				case 7:
					num2 = (short)46399489;
					if (num2 != 0)
					{
					}
					if (A_0[num5])
					{
						num2 = (short)2026110985;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_6F;
				case 8:
					goto IL_6F;
				case 9:
				{
					num3 += global::System.Convert.ToInt32(global::System.Math.Pow(2.0, (double)num5));
					num2 = (short)1836843008;
					short num6 = num2;
					num2 = (short)639893512;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				}
				goto IL_38;
				IL_6F:
				num5++;
				num2 = (short)117309440;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_8E:
				num2 = (short)2027290631;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_147:
				global::SpecialFeatures.Flashport.FlashRadio.FlashcodeGenerator.a(ref A_0);
				num5 = 0;
				num2 = (short)556428526;
				short num7 = num2;
				num2 = (short)1750166766;
				switch ((num7 == num2) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_8E;
				default:
					num2 = (short)598016000;
					if (num2 != 0)
					{
					}
					num2 = (short)1099366402;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				IL_10D:
				num2 = (short)1908867078;
				num = (int)((global::System.IntPtr)num2);
			}
			return num3;
			IL_38:
			num3 = 0;
			num2 = (short)132579331;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000DE3 RID: 3555 RVA: 0x00132350 File Offset: 0x00130550
		private static void a(ref bool[] A_0)
		{
			short num = (short)142029629;
			short num2 = num;
			num = (short)1283601213;
			bool[] array;
			int num4;
			int num5;
			int num6;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
			{
				IL_E1:
				num = (short)1198129152;
				short num3 = num;
				array[num4] = A_0[num5];
				num4--;
				num5++;
				num = (short)1391198210;
				num6 = (int)((global::System.IntPtr)num);
				break;
			}
			default:
				num = (short)1254227969;
				if (num != 0)
				{
				}
				num = (short)1019609088;
				if (num != 0)
				{
				}
				switch (0)
				{
				case 0:
					goto IL_92;
				}
				break;
			}
			for (;;)
			{
				IL_7C:
				switch (num6)
				{
				case 0:
					goto IL_DF;
				case 1:
					goto IL_B3;
				case 2:
					goto IL_B3;
				case 3:
					if (num5 >= 8)
					{
						num = (short)1307836416;
						num6 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_E1;
				}
				goto IL_92;
				IL_B3:
				num = (short)1322385411;
				num6 = (int)((global::System.IntPtr)num);
			}
			IL_DF:
			array.CopyTo(A_0, 0);
			return;
			IL_92:
			array = new bool[8];
			num4 = 7;
			num5 = 0;
			num = (short)1838612481;
			num6 = (int)((global::System.IntPtr)num);
			goto IL_7C;
		}
	}
}
