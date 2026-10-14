using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Motorola.Common.Communication.CommonUtil;
using Motorola.Common.Communication.Pba;
using Motorola.Common.CustomException;

namespace Motorola.Common.Communication.IshHandler
{
	// Token: 0x02000014 RID: 20
	public static class Validator
	{
		// Token: 0x06000134 RID: 308 RVA: 0x00018224 File Offset: 0x00016424
		public static global::System.Collections.Generic.IEnumerable<global::Motorola.Common.Communication.CommonUtil.IshHeader> GetValidateItemsToRead(global::System.Collections.Generic.IEnumerable<global::Motorola.Common.Communication.Pba.ValidationField> validationFields)
		{
			short num = (short)963706880;
			switch (num)
			{
			default:
			{
				num = (short)1189543937;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					num = (short)1893531648;
					short num3 = num;
					global::System.Collections.Generic.IEnumerator<global::Motorola.Common.Communication.Pba.ValidationField> enumerator;
					global::System.Collections.Generic.HashSet<global::Motorola.Common.Communication.CommonUtil.IshHeader> hashSet;
					switch (num2)
					{
					case 0:
						try
						{
							num = (short)579076106;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)89063437;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Motorola.Common.Communication.Pba.ValidationField validationField = enumerator.Current;
									global::Motorola.Common.Communication.CommonUtil.IshHeader item = new global::Motorola.Common.Communication.CommonUtil.IshHeader(validationField.PartitionID, validationField.BlockType, validationField.BlockID);
									num = (short)1005518855;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 1:
									goto IL_30F;
								case 2:
									goto IL_218;
								case 3:
									goto IL_160;
								case 4:
								{
									global::Motorola.Common.Communication.CommonUtil.IshHeader item;
									hashSet.Add(item);
									num = (short)517734402;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 5:
								{
									global::Motorola.Common.Communication.Pba.ValidationField validationField;
									if (validationField.Content.Length == 0)
									{
										num = (short)134938632;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									int num4 = (int)(validationField.OffsetInBits / 8U);
									num = (short)1827340294;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 6:
								{
									global::Motorola.Common.Communication.Pba.ValidationField validationField;
									int num4;
									if ((validationField.OffsetInBits + validationField.LengthInBits - 1U) / 8U - (uint)num4 >= (uint)validationField.Content.Length)
									{
										num = (short)1112211459;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 7:
								{
									global::Motorola.Common.Communication.CommonUtil.IshHeader item;
									if (!hashSet.Contains(item))
									{
										num = (short)1973551108;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_218;
								}
								case 8:
									goto IL_1E6;
								case 9:
								{
									global::Motorola.Common.Communication.Pba.ValidationField validationField;
									if (validationField.Content != null)
									{
										num = (short)2016411659;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_211;
								}
								case 10:
									switch (0)
									{
									case 0:
										goto IL_105;
									}
									continue;
								case 11:
									num = (short)1219297285;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 12:
								{
									global::Motorola.Common.Communication.Pba.ValidationField validationField;
									if (validationField.LengthInBits != 0U)
									{
										num = (short)354484238;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_211;
								}
								case 13:
									num = (short)364052481;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 14:
									num = (short)1572470793;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_165:
								num = (short)1972109312;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_105:
								goto IL_165;
								IL_218:
								num = (short)137166860;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_160:
							throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.InvalidArgument);
							IL_1E6:
							IL_211:
							throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.InvalidArgument);
							IL_30F:
							return hashSet;
						}
						finally
						{
							num = (short)42663937;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_3EF;
								case 1:
								{
									num = (short)428926654;
									short num5 = num;
									num = (short)1504437950;
									switch ((num5 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										break;
									default:
										num = (short)1117388800;
										if (num != 0)
										{
										}
										switch (0)
										{
										case 0:
											goto IL_392;
										}
										continue;
									}
									break;
								}
								case 2:
									enumerator.Dispose();
									num = (short)407175168;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_392:
								num = (short)1361379329;
								if (num != 0)
								{
								}
								if (enumerator == null)
								{
									break;
								}
								num = (short)17432578;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_3EF:;
						}
						goto IL_3F2;
					case 1:
						switch (0)
						{
						case 0:
							goto IL_81;
						}
						continue;
					case 2:
						goto IL_458;
					case 3:
						num = (short)194576388;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						if (!validationFields.Any<global::Motorola.Common.Communication.Pba.ValidationField>())
						{
							num = (short)325255170;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3F2;
					}
					IL_81:
					if (validationFields != null)
					{
						num = (short)1660092419;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
					IL_3F2:
					hashSet = new global::System.Collections.Generic.HashSet<global::Motorola.Common.Communication.CommonUtil.IshHeader>();
					enumerator = validationFields.GetEnumerator();
					num = (short)966787072;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_458:
				return null;
			}
			}
		}

		// Token: 0x06000135 RID: 309 RVA: 0x000186AC File Offset: 0x000168AC
		public static void ValidateFields(global::System.Collections.Generic.IEnumerable<global::Motorola.Common.Communication.Pba.ValidationField> validationFields, global::Motorola.Common.Communication.CommonUtil.IshItemCollection IshInRadio)
		{
			int a_ = 7;
			short num = (short)1352007680;
			switch (num)
			{
			default:
			{
				num = (short)2026766338;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					num = (short)797062377;
					short num3 = num;
					num = (short)2062824681;
					global::System.Collections.Generic.IEnumerator<global::Motorola.Common.Communication.Pba.ValidationField> enumerator;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num = (short)1434583040;
						if (num != 0)
						{
						}
						switch (num2)
						{
						case 0:
							if (!validationFields.Any<global::Motorola.Common.Communication.Pba.ValidationField>())
							{
								num = (short)1243611140;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_5C0;
						case 1:
							try
							{
								num = (short)110821389;
								num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									global::Motorola.Common.Communication.Pba.ValidationField validationField;
									switch (num2)
									{
									case 0:
									{
										global::Motorola.Common.Communication.CommonUtil.IshItem ishItem;
										if (!global::Motorola.Common.Communication.IshHandler.Validator.ValidateField(validationField, ishItem))
										{
											num = (short)1862729735;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										break;
									}
									case 2:
										num = (short)346292241;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 4:
										if (!validationField.BypassMissing)
										{
											num = (short)897974277;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										goto IL_1B2;
									case 5:
										num = (short)151781385;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 6:
										if (IshInRadio != null)
										{
											num = (short)2128871442;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										goto IL_4CD;
									case 7:
										global::Motorola.Common.Communication.IshHandler.Validator.ThrowException(validationField.ErrorToThrow, global::Motorola.Common.CustomException.CommonErrorCode.ValidateFieldsFailure);
										num = (short)1966342145;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 8:
									{
										global::Motorola.Common.Communication.CommonUtil.IshHeader ishHeader;
										if (!IshInRadio.ContainsHeader(ishHeader))
										{
											num = (short)1585119252;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										global::Motorola.Common.Communication.CommonUtil.IshItem ishItem = IshInRadio[ishHeader];
										num = (short)302907392;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 9:
										if (!validationField.AutoFill)
										{
											num = (short)1469382672;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										goto IL_1B2;
									case 10:
										num = (short)606666771;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 12:
										goto IL_33C;
									case 13:
										switch (0)
										{
										case 0:
											goto IL_173;
										}
										continue;
									case 14:
									{
										global::Motorola.Common.Communication.CommonUtil.IshHeader ishHeader;
										if (!IshInRadio.ContainsHeader(ishHeader))
										{
											num = (short)519634954;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										goto IL_33C;
									}
									case 15:
									{
										if (!enumerator.MoveNext())
										{
											num = (short)550371330;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										validationField = enumerator.Current;
										global::Motorola.Common.Communication.CommonUtil.IshHeader ishHeader = new global::Motorola.Common.Communication.CommonUtil.IshHeader(validationField.PartitionID, validationField.BlockType, validationField.BlockID);
										num = (short)1758724102;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 16:
										global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteVerbose(global::Motorola.Common.Communication.IshHandler.Validator.b("펱\ud8b3\udfb5\udcb7\udbb9좻\udbbd蓁귃ꏅ꓇껉裍뇏믑룓ꏕ꫗뿙ﻝ铟鯡铣菥죧뇩韫\udeed路꿱퓳鿵鳷ꇹ蟻쿽緿弁␃戅朇漉缋⸍縏紑怓㘕紗戙甛洝吟", a_), new object[]
										{
											validationField.BlockType,
											validationField.BlockID
										});
										global::Motorola.Common.Communication.IshHandler.Validator.ThrowException(validationField.ErrorToThrow, global::Motorola.Common.CustomException.CommonErrorCode.ValidateFieldsFailure);
										num = (short)2094596099;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 17:
										goto IL_526;
									case 18:
										num = (short)774897678;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 19:
										if (validationField.AutoFill)
										{
											num = (short)1066991628;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										goto IL_4CD;
									case 20:
										global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteVerbose(global::Motorola.Common.Communication.IshHandler.Validator.b("펱\ud8b3\udfb5\udcb7\udbb9좻\udbbd蓁귃ꏅ꓇껉词ꋏꃑ믓ꓕ龎꣛꟝郟蟡쓣뷥鏧\udae9釫돭탯鯱郳귵菷쯹臻ꏽ⃿洁戃怅笇漉砋唍欏‑椓䬕㠗瘙礛瀝䜟嘡䰣إ䄧䐩ఫ䰭夯䘱䜳洵䌷ह䄻挽怿⍁⩃≅桇⍉㡋㵍灏≑㕓⑕㵗㑙⡛繝ɟ๡ୣեͧ䩩࡫ŭṯ啱s噵ᵷɹᕻൽ겁", a_), new object[]
										{
											validationField.BlockType,
											validationField.BlockID,
											validationField.OffsetInBits,
											validationField.LengthInBits
										});
										global::Motorola.Common.Communication.IshHandler.Validator.ThrowException(validationField.ErrorToThrow, global::Motorola.Common.CustomException.CommonErrorCode.ValidateFieldsFailure);
										num = (short)1072431125;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_173;
									IL_1B2:
									global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteWarning(global::Motorola.Common.Communication.IshHandler.Validator.b("펱\ud8b3\udfb5\udcb7\udbb9좻\udbbd蓁귃ꏅ꓇껉駍뇏ꃑ뫓뿕뛗뷙ﻝ铟鯡铣菥죧뇩韫\udeed路꿱퓳鿵鳷ꇹ蟻쿽緿弁␃戅朇漉缋⸍縏紑怓㘕紗戙甛洝吟డУ搥儧娩䴫崭䌯圱倳", a_), new object[]
									{
										validationField.BlockType,
										validationField.BlockID
									});
									num = (short)1449984011;
									num2 = (int)((global::System.IntPtr)num);
									continue;
									IL_2FA:
									num = (short)1554382863;
									num2 = (int)((global::System.IntPtr)num);
									continue;
									IL_173:
									goto IL_2FA;
									IL_33C:
									num = (short)962396168;
									num2 = (int)((global::System.IntPtr)num);
									continue;
									IL_4CD:
									num = (short)940834820;
									num2 = (int)((global::System.IntPtr)num);
								}
								IL_526:
								return;
							}
							finally
							{
								num = (short)809828352;
								num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									switch (num2)
									{
									case 0:
										switch (0)
										{
										case 0:
											goto IL_55F;
										}
										continue;
									case 1:
										enumerator.Dispose();
										num = (short)716963842;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 2:
										goto IL_5BD;
									}
									IL_55F:
									if (enumerator == null)
									{
										break;
									}
									num = (short)1827864577;
									if (num != 0)
									{
									}
									num = (short)500039681;
									num2 = (int)((global::System.IntPtr)num);
								}
								IL_5BD:;
							}
							goto IL_5C0;
						case 2:
							switch (0)
							{
							case 0:
								goto IL_AB;
							}
							continue;
						case 3:
						{
							num = (short)1671430144;
							short num4 = num;
							num = (short)1478819840;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 4:
							return;
						}
						IL_AB:
						if (validationFields != null)
						{
							num = (short)1601175555;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					}
					IL_5C0:
					enumerator = validationFields.GetEnumerator();
					num = (short)529596417;
					num2 = (int)((global::System.IntPtr)num);
				}
				return;
			}
			}
		}

		// Token: 0x06000136 RID: 310 RVA: 0x00018CF8 File Offset: 0x00016EF8
		public static bool ValidateField(global::Motorola.Common.Communication.Pba.ValidationField validateField, global::Motorola.Common.Communication.CommonUtil.IshItem ishItem)
		{
			int a_ = 19;
			short num = (short)412090368;
			switch (num)
			{
			default:
			{
				num = (short)273154066;
				int num2 = (int)((global::System.IntPtr)num);
				int num3;
				byte[] array;
				for (;;)
				{
					int num4;
					int num5;
					byte[] array2;
					int num6;
					int num7;
					int num8;
					int num9;
					int num12;
					int num13;
					switch (num2)
					{
					case 0:
						goto IL_76E;
					case 1:
						if (num3 >= num4)
						{
							num = (short)1105199131;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num5 = 255;
						num = (short)1098645533;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						goto IL_336;
					case 3:
						array = array2.Skip(num6).Take(num7 - num6 + 1).ToArray<byte>();
						num = (short)1276248083;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						goto IL_111;
					case 5:
						goto IL_43F;
					case 6:
						num8 = (int)(8U - validateField.OffsetInBits % 8U);
						num9 = (int)((long)num8 - (long)((ulong)validateField.LengthInBits));
						num = (short)1871380493;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
						goto IL_331;
					case 8:
						goto IL_F0;
					case 9:
						goto IL_2E8;
					case 10:
						num = (short)933888020;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 11:
						if (num7 + 1 > ishItem.Data.Length)
						{
							num = (short)862388234;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						array = ishItem.Data.Skip(num6).Take(num7 - num6 + 1).ToArray<byte>();
						num = (short)1602879488;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 12:
						goto IL_43F;
					case 13:
						if (num9 < 0)
						{
							num = (short)1091305488;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_528;
					case 14:
					{
						if (num7 + 1 <= ishItem.Data.Length)
						{
							num = (short)1790640151;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1109393408;
						short num10 = num;
						num = (short)1960116246;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 15:
					{
						int num11 = (int)(7U - (validateField.OffsetInBits + validateField.LengthInBits - 1U) % 8U);
						num5 = 256 - (1 << num11);
						num = (short)868679705;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 16:
						num9 = 0;
						num = (short)1888878596;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 17:
						goto IL_336;
					case 18:
						switch (0)
						{
						case 0:
							goto IL_D2;
						}
						continue;
					case 19:
						goto IL_76E;
					case 20:
						if (validateField.AutoFill)
						{
							num = (short)1833697304;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1068171294;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 21:
						num12 = ishItem.Data.Length;
						goto IL_2C1;
					case 22:
						num12 = num7 + 1;
						goto IL_2C1;
					case 23:
						num = (short)1362886677;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 24:
						num = (short)1155334158;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 25:
						goto IL_2E8;
					case 26:
						if (num3 == num4 - 1)
						{
							num = (short)300351503;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2E8;
					case 27:
						return true;
					case 28:
						if (num13 >= ishItem.Data.Length)
						{
							num = (short)1735983107;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						array2[num13] = ishItem.Data[num13];
						num13++;
						num = (short)1504444421;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 29:
					{
						if (num3 != 0)
						{
							num = (short)1955856385;
							if (num != 0)
							{
							}
							num = (short)1813774362;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1916143376;
						short num14 = num;
						num = (short)1554712336;
						switch ((num14 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_111;
						default:
							num = (short)1877540864;
							if (num != 0)
							{
							}
							num = (short)1339949062;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 30:
						if (validateField.BypassMissing)
						{
							num = (short)1343225888;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_277;
					case 31:
						if (((int)validateField.Content[num3] & num5) != ((int)array[num3] & num5))
						{
							num = (short)1962803207;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num3++;
						num = (short)1480654850;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 32:
						goto IL_595;
					}
					IL_D2:
					if (validateField == null)
					{
						num = (short)291438600;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num6 = (int)(validateField.OffsetInBits / 8U);
					num7 = (int)((validateField.OffsetInBits + validateField.LengthInBits - 1U) / 8U);
					num = (short)1260650507;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2C1:
					array2 = new byte[num12];
					num13 = 0;
					num = (short)1929314316;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2E8:
					num = (short)631701535;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_336:
					num = (short)1006239745;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_43F:
					num = (short)1103822876;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_528:
					num5 = (1 << num8) - (1 << num9);
					num = (short)2112552969;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_111:
					goto IL_528;
					IL_76E:
					num4 = array.Length;
					num3 = 0;
					num = (short)115605521;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_F0:
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.InvalidArgument);
				IL_277:
				global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteVerbose(global::Motorola.Common.Communication.IshHandler.Validator.b("\udfbd겿ꯁꃃꟅ볇꿉裍맏럑룓닕鳙뷛럝賟韡難菥틧쫩飫韭胯韱퓳귵菷쫹臻ꏽ⃿欁怃崅猇㬉焋匍』紑爓瀕欗缙栛䔝嬟အ夣笥ࠧ丩䌫䬭䌯ሱ娳夵䰷ᨹ夻䘽⤿ㅁぃ桅", a_), new object[]
				{
					validateField.BlockType,
					validateField.BlockID,
					validateField.OffsetInBits
				});
				return false;
				IL_331:
				global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteVerbose(global::Motorola.Common.Communication.IshHandler.Validator.b("\udfbd겿ꯁꃃꟅ볇꿉裍맏럑룓닕鳙뷛럝賟韡難菥죧黩闫黭闯틱꿳践죷蟹ꇻ\udefd槿昁弃紅㤇眉儋⸍缏琑爓攕紗渙䜛攝ሟ弡礣إ䐧伩䈫䤭䐯娱漳䴵ଷ䜹愻ḽ⤿ⱁ⁃⍅ぇ橉ᝋ㕍摏⽑॓穕硗⥙㍛⭝቟šţ䙥㍧ᅩ奫፭ⵯ幱味ɵ᥷ࡹ᭻᭽ꊁ\udf83ﶅ뺇톋", a_), new object[]
				{
					validateField.BlockType,
					validateField.BlockID,
					validateField.OffsetInBits,
					validateField.LengthInBits,
					num3,
					validateField.Content[num3].ToString(global::Motorola.Common.Communication.IshHandler.Validator.b("", a_)),
					array[num3].ToString(global::Motorola.Common.Communication.IshHandler.Validator.b("", a_))
				});
				return false;
				IL_595:
				global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteWarning(global::Motorola.Common.Communication.IshHandler.Validator.b("\udfbd겿ꯁꃃꟅ볇꿉裍맏럑룓닕跙뷛곝軟诡諣臥틧쫩飫韭胯韱퓳귵菷쫹臻ꏽ⃿欁怃崅猇㬉焋匍』紑爓瀕欗缙栛䔝嬟အ夣笥ࠧ丩䌫䬭䌯ሱ娳夵䰷ᨹ夻䘽⤿ㅁぃ桅桇ࡉ㕋㹍ㅏ⅑❓㍕㱗", a_), new object[]
				{
					validateField.BlockType,
					validateField.BlockID,
					validateField.OffsetInBits
				});
				return true;
			}
			}
		}

		// Token: 0x06000137 RID: 311 RVA: 0x00019498 File Offset: 0x00017698
		public static void ValidateInfos(global::System.Collections.Generic.IEnumerable<global::Motorola.Common.Communication.Pba.ValidationInfo> validationInfos, global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, global::System.Collections.IComparer comparator = null)
		{
			int a_ = 1;
			short num = (short)1481703424;
			switch (num)
			{
			default:
			{
				num = (short)588054528;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						switch (0)
						{
						case 0:
							goto IL_69;
						}
						continue;
					case 1:
						num = (short)1586364420;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						goto IL_847;
					case 3:
						goto IL_142;
					case 4:
						if (!validationInfos.Any<global::Motorola.Common.Communication.Pba.ValidationInfo>())
						{
							num = (short)991887363;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_80F;
					case 5:
						try
						{
							num = (short)1196425238;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								int num3;
								bool flag;
								bool flag2;
								bool flag3;
								switch (num2)
								{
								case 0:
									goto IL_625;
								case 1:
								{
									global::Motorola.Common.Communication.Pba.ValidationInfo validationInfo;
									global::System.Reflection.FieldInfo field = deviceInfo.GetType().GetField(validationInfo.ID);
									if (field == null)
									{
										goto Block_12;
									}
									object obj = field.GetValue(deviceInfo);
									num = (short)1159594014;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 2:
									goto IL_625;
								case 3:
									flag = (num3 > 0);
									num = (short)1777401856;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 4:
									num = (short)588775449;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 5:
									goto IL_6AF;
								case 6:
								{
									global::Motorola.Common.Communication.Pba.ValidationInfo validationInfo;
									if (validationInfo.ValidationMethod == global::Motorola.Common.Communication.Pba.ValidationMethod.Equal)
									{
										num = (short)1280573475;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)1104412698;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 7:
									num = (short)308412434;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 8:
								{
									global::Motorola.Common.Communication.Pba.ValidationInfo validationInfo;
									if (validationInfo.ValidationMethod == global::Motorola.Common.Communication.Pba.ValidationMethod.NotLess)
									{
										num = (short)1005649924;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_625;
								}
								case 9:
								{
									global::Motorola.Common.Communication.Pba.ValidationInfo validationInfo;
									if (validationInfo.ValidationMethod == global::Motorola.Common.Communication.Pba.ValidationMethod.Less)
									{
										num = (short)1120534548;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)2110980117;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 10:
								{
									object obj;
									if (obj == null)
									{
										num = (short)891093005;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									string text = obj.ToString();
									global::Motorola.Common.Communication.Pba.ValidationInfo validationInfo;
									global::Motorola.Common.Communication.IshHandler.b b;
									num3 = b.a(validationInfo.Value, text);
									flag = false;
									num = (short)1409220614;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 11:
									goto IL_625;
								case 13:
									goto IL_6E6;
								case 14:
								{
									global::System.Reflection.PropertyInfo property;
									if (property != null)
									{
										num = (short)1275068444;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)1258160129;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 15:
								{
									global::System.Collections.Generic.IEnumerator<global::Motorola.Common.Communication.Pba.ValidationInfo> enumerator;
									if (!enumerator.MoveNext())
									{
										num = (short)786497543;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Motorola.Common.Communication.Pba.ValidationInfo validationInfo = enumerator.Current;
									object obj = null;
									global::System.Reflection.PropertyInfo property = deviceInfo.GetType().GetProperty(validationInfo.ID);
									num = (short)1071317006;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 16:
									flag2 = true;
									goto IL_580;
								case 17:
									num = (short)671678483;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 18:
									goto IL_79F;
								case 19:
									if (num3 != 0)
									{
										num = (short)1971585055;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)1401880603;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 20:
									flag = (num3 < 0);
									num = (short)2084175883;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 21:
								{
									global::Motorola.Common.Communication.Pba.ValidationInfo validationInfo;
									if (validationInfo.ValidationMethod == global::Motorola.Common.Communication.Pba.ValidationMethod.NotGreater)
									{
										num = (short)1538326545;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)1978531848;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 22:
									switch (0)
									{
									case 0:
										goto IL_200;
									}
									continue;
								case 23:
									goto IL_625;
								case 24:
									if (!flag)
									{
										num = (short)2070675489;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								case 25:
									if (num3 != 0)
									{
										num = (short)738918429;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)514654224;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 26:
								{
									global::Motorola.Common.Communication.Pba.ValidationInfo validationInfo;
									if (validationInfo.ValidationMethod == global::Motorola.Common.Communication.Pba.ValidationMethod.Greater)
									{
										num = (short)48103427;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)752025609;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 27:
									flag3 = true;
									goto IL_767;
								case 28:
								{
									global::System.Reflection.PropertyInfo property;
									object obj = property.GetValue(deviceInfo, null);
									num = (short)924254213;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 29:
									num = (short)933691428;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 30:
									goto IL_6AF;
								case 31:
									num = (short)1526530082;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 32:
									goto IL_625;
								case 33:
								{
									num = (short)1611791331;
									short num4 = num;
									num = (short)1559100387;
									switch ((num4 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										goto IL_61B;
									default:
									{
										num = (short)188153856;
										if (num != 0)
										{
										}
										global::Motorola.Common.Communication.Pba.ValidationInfo validationInfo;
										string text;
										global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteVerbose(global::Motorola.Common.Communication.IshHandler.Validator.b("ﲩ춫슭\ud9af횱햳습\uddb7骹킽ꚿ귁胅꧇ꏉꃋ믍ꋏ럑鿕鳗龎蟛ꗝ탟鿡맣웥ꗧ迩飫蛭鿯雱꿳践짷蟹ꇻ\udefd囿持栃猅洇儉看㰍洏休㐓䀕礗瘙椛笝ࠟ瀡䔣䈥䄧䔩ԫ甭䬯ı䤳欵ᠷ", a_), new object[]
										{
											validationInfo.ID,
											validationInfo.ValidationMethod.ToString(),
											validationInfo.Value,
											text
										});
										global::Motorola.Common.Communication.IshHandler.Validator.ThrowException(validationInfo.ErrorToThrow, global::Motorola.Common.CustomException.CommonErrorCode.ValidateInfosFailure);
										num = (short)1154678796;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									}
									break;
								}
								case 34:
									flag3 = (num3 < 0);
									goto IL_767;
								case 35:
									flag = (num3 == 0);
									num = (short)29687831;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 36:
									goto IL_61B;
								}
								goto IL_200;
								IL_580:
								flag = flag2;
								num = (short)524484640;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_61B:
								flag2 = (num3 > 0);
								goto IL_580;
								IL_59F:
								num = (short)579272719;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_200:
								goto IL_59F;
								IL_625:
								num = (short)2089680920;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_6AF:
								num = (short)1827536906;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_767:
								flag = flag3;
								num = (short)840761346;
								num2 = (int)((global::System.IntPtr)num);
							}
							Block_12:
							throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.ValidateInfosNotExist);
							IL_6E6:
							throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.ValidateInfosFailure);
							IL_79F:
							return;
						}
						finally
						{
							num = (short)472055810;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::System.Collections.Generic.IEnumerator<global::Motorola.Common.Communication.Pba.ValidationInfo> enumerator;
								switch (num2)
								{
								case 0:
									enumerator.Dispose();
									num = (short)484966401;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									goto IL_80C;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_7D7;
									}
									continue;
								}
								IL_7D7:
								if (enumerator == null)
								{
									break;
								}
								num = (short)375783424;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_80C:;
						}
						goto IL_80F;
					case 6:
					{
						if (deviceInfo == null)
						{
							num = (short)1178271746;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::Motorola.Common.Communication.IshHandler.b b = new global::Motorola.Common.Communication.IshHandler.b(comparator);
						global::System.Collections.Generic.IEnumerator<global::Motorola.Common.Communication.Pba.ValidationInfo> enumerator = validationInfos.GetEnumerator();
						num = (short)1830027269;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					IL_69:
					num = (short)642908160;
					short num5 = num;
					if (validationInfos != null)
					{
						num = (short)1460011009;
						if (num != 0)
						{
						}
						num = (short)1965883393;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
					IL_80F:
					num = (short)869138438;
					num2 = (int)((global::System.IntPtr)num);
				}
				return;
				IL_142:
				return;
				IL_847:
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.InvalidArgument);
			}
			}
		}

		// Token: 0x06000138 RID: 312 RVA: 0x00019D10 File Offset: 0x00017F10
		public static void ThrowException(global::Motorola.Common.CustomException.CommonErrorCode toThrow, global::Motorola.Common.CustomException.CommonErrorCode defaultError)
		{
			if (toThrow != global::Motorola.Common.CustomException.CommonErrorCode.None)
			{
				short num;
				for (;;)
				{
					num = (short)1413939200;
					short num2 = num;
					num = (short)988579792;
					short num3 = num;
					num = (short)1018398672;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						goto IL_67;
					}
				}
				IL_67:
				num = (short)189399041;
				if (num != 0)
				{
				}
				num = (short)519569408;
				if (num != 0)
				{
				}
				throw new global::Motorola.Common.CustomException.CommonException(toThrow);
			}
			throw new global::Motorola.Common.CustomException.CommonException(defaultError);
		}

		// Token: 0x06000139 RID: 313 RVA: 0x00019DD0 File Offset: 0x00017FD0
		public static void ValidateAvailableSpace(global::Motorola.Common.Communication.Pba.LanguagePackData lpData, global::Motorola.Common.Communication.Pba.LanguagePackData radioLpInfo)
		{
			short num = (short)795738112;
			switch (num)
			{
			default:
			{
				num = (short)826277900;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					int num3;
					global::Motorola.Common.Communication.Pba.PcrLanguagePackInfo pcrLanguagePackInfo;
					uint num7;
					uint num8;
					switch (num2)
					{
					case 0:
						num = (short)72613897;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						goto IL_359;
					case 2:
					{
						if (num3 >= radioLpInfo.LanguagePacks.Count)
						{
							num = (short)2139095056;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						pcrLanguagePackInfo = (radioLpInfo.LanguagePacks[num3] as global::Motorola.Common.Communication.Pba.PcrLanguagePackInfo);
						int num4 = 0;
						num = (short)168361999;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 3:
						goto IL_D0;
					case 4:
					{
						int num4;
						if (num4 >= lpData.LanguagePacks.Count)
						{
							num = (short)572129286;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::Motorola.Common.Communication.Pba.PcrLanguagePackInfo pcrLanguagePackInfo2 = lpData.LanguagePacks[num4] as global::Motorola.Common.Communication.Pba.PcrLanguagePackInfo;
						num = (short)1024720906;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 5:
						goto IL_30F;
					case 6:
						goto IL_D0;
					case 7:
						goto IL_124;
					case 8:
					{
						int num5;
						if (num5 >= lpData.LanguagePacks.Count)
						{
							num = (short)2067136513;
							if (num != 0)
							{
							}
							num = (short)96993280;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1619263488;
						short num6 = num;
						num7 += (lpData.LanguagePacks[num5] as global::Motorola.Common.Communication.Pba.PcrLanguagePackInfo).Size;
						num5++;
						num = (short)2103312391;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 9:
						if (num7 > num8 + radioLpInfo.AvailableSpace)
						{
							num = (short)1511260174;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 10:
					{
						num = (short)1149600427;
						short num9 = num;
						num = (short)1457619627;
						switch ((num9 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_30F;
						default:
						{
							num = (short)1857224704;
							if (num != 0)
							{
							}
							global::Motorola.Common.Communication.Pba.PcrLanguagePackInfo pcrLanguagePackInfo2;
							if (pcrLanguagePackInfo.PackID == pcrLanguagePackInfo2.PackID)
							{
								num = (short)426967045;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							int num4;
							num4++;
							num = (short)1807482897;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						break;
					}
					case 11:
						goto IL_124;
					case 12:
						switch (0)
						{
						case 0:
							goto IL_91;
						}
						continue;
					case 13:
						goto IL_359;
					case 14:
						goto IL_354;
					case 15:
						goto IL_227;
					case 16:
					{
						int num5 = 0;
						num = (short)1105526795;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 17:
						goto IL_227;
					case 18:
						goto IL_AC;
					}
					IL_91:
					if (radioLpInfo == null)
					{
						num = (short)2117402642;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num7 = 0U;
					num8 = 0U;
					num3 = 0;
					num = (short)1940127757;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_D0:
					num3++;
					num = (short)818413569;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_124:
					num = (short)1210515464;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_227:
					num = (short)1268908036;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_30F:
					num8 += pcrLanguagePackInfo.Size;
					num = (short)690880515;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_359:
					num = (short)1772814338;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_AC:
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.InvalidArgument);
				IL_354:
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.LanguagePack_PCR_Radio_does_not_have_enough_free_space);
			}
			}
		}

		// Token: 0x0600013A RID: 314 RVA: 0x0001A1D0 File Offset: 0x000183D0
		internal static string b(string A_0, int A_1)
		{
			char[] array = A_0.ToCharArray();
			int num = (int)((global::System.IntPtr)(409536765 + A_1) + (global::System.IntPtr)28 + (global::System.IntPtr)5 + (global::System.IntPtr)44 + (global::System.IntPtr)75 + (global::System.IntPtr)19);
			int num3;
			int num2;
			if ((num2 = (num3 = 0)) < 1)
			{
				goto IL_6A;
			}
			IL_37:
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
			IL_6A:
			if ((num2 = num3) >= array.Length)
			{
				return string.Intern(new string(array));
			}
			goto IL_37;
		}
	}
}
