using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using authAES;
using Motorola.Common.Communication.AmpConfigPackage;
using Motorola.Common.Communication.CommonUtil;
using Motorola.Common.Communication.Pba;
using Motorola.Common.CustomException;

namespace Motorola.Common.Communication.AmpPasswords
{
	// Token: 0x02000037 RID: 55
	public static class AmpPasswordsHelper
	{
		// Token: 0x06000193 RID: 403 RVA: 0x00028204 File Offset: 0x00026404
		public static void UpdatePinPasswordAfterRead(global::Motorola.Common.Communication.Pba.PbaObject pbaObject, string esn)
		{
			int a_ = 4;
			short num = (short)161349632;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					switch (0)
					{
					case 0:
						goto IL_39;
					}
					continue;
				case 1:
				{
					num = (short)1582240683;
					short num3 = num;
					num = (short)409932715;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						continue;
					default:
						goto IL_8D;
					}
					break;
				}
				case 2:
					try
					{
						global::Motorola.Common.Communication.AmpPasswords.AmpPasswordsHelper.d(pbaObject, esn);
						return;
					}
					catch (global::System.Exception ex)
					{
						global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteError(global::Motorola.Common.Communication.AmpConfigPackage.PackageGenerator.b("뗳鯵裷꫹鷻跽珿甁欃琅氇礉䐋欍簏我焓搕∗㨙䤛渝䐟䌡倣䌥砧挩戫縭儯䄱䜳䄵圷䠹堻缽☿㙁⅃㑅ᩇ⽉ⵋ⩍灏㑑㕓㽕㑗㽙㡛繝᝟ୡၣ๥剧䩩ᝫ幭൯", a_), new object[]
						{
							ex.Message
						});
						throw;
					}
					goto IL_DD;
				}
				IL_39:
				if (string.IsNullOrEmpty(esn))
				{
					num = (short)1191116801;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_DD:
				num = (short)1796669440;
				short num4 = num;
				num = (short)33357825;
				if (num != 0)
				{
				}
				num = (short)443351042;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_8D:
			num = (short)793509888;
			if (num != 0)
			{
			}
			throw new global::System.ArgumentException(global::Motorola.Common.Communication.AmpConfigPackage.PackageGenerator.b("뗳鯵裷꫹鷻跽珿甁欃琅氇礉䐋欍簏我焓搕∗㨙䤛渝䐟䌡倣䌥砧挩戫縭儯䄱䜳䄵圷䠹堻缽☿㙁⅃㑅ᩇ⽉ⵋ⩍灏⁑ㅓ㕕㵗㍙⩛㭝џ䉡੣፥ѧ٩䱫ŭɯ剱ᅳ᭵ࡷ๹ջ幽ꞅ", a_), global::Motorola.Common.Communication.AmpConfigPackage.PackageGenerator.b("釳藵雷", a_));
		}

		// Token: 0x06000194 RID: 404 RVA: 0x00028394 File Offset: 0x00026594
		private static void d(global::Motorola.Common.Communication.Pba.PbaObject A_0, string A_1)
		{
			int a_ = 8;
			short num = (short)1655308288;
			switch (num)
			{
			default:
			{
				num = (short)773652488;
				int num2 = (int)((global::System.IntPtr)num);
				string text;
				for (;;)
				{
					switch (num2)
					{
					case 0:
						goto IL_17F;
					case 1:
						if (!global::Motorola.Common.Communication.AmpPasswords.AmpPasswordsHelper.e.IsMatch(text))
						{
							num = (short)876806151;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_26B;
					case 2:
						if (!global::Motorola.Common.Communication.AmpPasswords.AmpPasswordsHelper.e.IsMatch(text))
						{
							num = (short)1735655430;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_26B;
					case 3:
						return;
					case 4:
						goto IL_20D;
					case 5:
					{
						if (!global::Motorola.Common.Communication.CodeplugParseHelper.IsPINPSWBlockExist(A_0))
						{
							num = (short)390266884;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						string encryptedPwd = global::Motorola.Common.Communication.CodeplugParseHelper.ReadEncryptPassword(A_0);
						byte[] cipherKeyBytes = global::Motorola.Common.Communication.AmpPasswords.AmpPasswordsHelper.c(A_1);
						text = global::authAES.AESCryptography.AESDecrypt(encryptedPwd, cipherKeyBytes);
						num = (short)1237975041;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 6:
						text = string.Empty;
						goto IL_166;
					case 7:
					{
						string encryptedPwd;
						text = global::authAES.AESCryptography.AESDecryptWithDefKey(encryptedPwd);
						num = (short)1341062848;
						short num3 = num;
						num = (short)1667169984;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_166;
						default:
							num = (short)2005991424;
							if (num != 0)
							{
							}
							num = (short)1996947458;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 8:
						switch (0)
						{
						case 0:
							goto IL_73;
						}
						continue;
					}
					IL_73:
					if (!global::Motorola.Common.Communication.CodeplugParseHelper.ReadEncryptPasswordFlag(A_0))
					{
						num = (short)654835715;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1860304901;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_166:
					num = (short)86769664;
					num2 = (int)((global::System.IntPtr)num);
				}
				return;
				IL_17F:
				num = (short)1431240704;
				short num4 = num;
				num = (short)1459027969;
				if (num != 0)
				{
				}
				goto IL_26B;
				IL_20D:
				global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteError(global::Motorola.Common.Communication.AmpConfigPackage.PackageGenerator.b("믷闹釻鏽痿氁洃攅椇縉攋愍縏䴑䜓猕椗漙礛瀝䌟䜡椣䜥䘧䬩䬫䬭䈯洱申䔵䰷䠹医愽िⱁ㉃❅⑇⍉⡋ᅍᕏ㱑㝓⑕⅗⩙⡛㝝ཟౡ㭣㙥१ᥩὫᥭὯqၳ⥵㹷ᙹᵻ᥽걿ꊁﾉ낏ﾕ몙얟芡캣즥쪧让趫", a_), global::System.Array.Empty<object>());
				throw new global::System.InvalidOperationException(global::Motorola.Common.Communication.AmpConfigPackage.PackageGenerator.b("믷闹飻鯽烿渁焃愅⠇渉挋欍挏簑㌓戕㠗礙猛瀝吟䌡䴣䠥ࠧ帩䐫䬭ု戱紳砵᜷樹崻䴽㌿㕁⭃㑅ⱇ橉⹋≍㽏ㅑ㽓穕硗㡙⥛⩝䁟ݡ੣եᩧ፩ᱫᩭ᥯ᵱᩳ噵ṷᙹᵻ᥽ꁿꚅﮇ꺍﶑뒓鍊낝躟財", a_));
				IL_26B:
				string encryptedPwd2 = global::authAES.AESCryptography.AESEncryptWithDefKey(text);
				global::Motorola.Common.Communication.CodeplugParseHelper.WriteEncryptPassword(A_0, encryptedPwd2);
				return;
			}
			}
		}

		// Token: 0x06000195 RID: 405 RVA: 0x0002861C File Offset: 0x0002681C
		public static void UpdatePinPasswordBeforeWrite(global::Motorola.Common.Communication.Pba.PbaObject pbaObject, string esn)
		{
			int a_ = 11;
			short num = (short)1891958786;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
				{
					num = (short)268591805;
					short num3 = num;
					num = (short)320168637;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						continue;
					default:
						goto IL_B5;
					}
					break;
				}
				case 1:
					try
					{
						global::Motorola.Common.Communication.AmpPasswords.AmpPasswordsHelper.c(pbaObject, esn);
						return;
					}
					catch (global::System.Exception ex)
					{
						global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteError(global::Motorola.Common.Communication.AmpConfigPackage.PackageGenerator.b("뫺郼迾儀戂瘄理縈搊缌欎成嬒瀔笖椘縚漜┞Ġ瘢唤䌦䠨弪䠬缮砰紲攴嘶䨸䠺䨼倾㍀❂݄≆⽈⑊㽌⩎ِ⅒㱔⍖㱘筚㭜㹞ࡠརdͦ䥨ᱪѬ᭮ᥰ䥲啴౶䥸ٺ", a_), new object[]
						{
							ex.Message
						});
						throw;
					}
					goto IL_129;
				case 2:
					switch (0)
					{
					case 0:
						goto IL_3B;
					}
					continue;
				}
				IL_3B:
				num = (short)830144513;
				if (num != 0)
				{
				}
				if (string.IsNullOrEmpty(esn))
				{
					num = (short)297730048;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_129:
				num = (short)1619460097;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_B5:
			num = (short)486408192;
			if (num != 0)
			{
			}
			num = (short)1920139264;
			short num4 = num;
			throw new global::System.ArgumentException(global::Motorola.Common.Communication.AmpConfigPackage.PackageGenerator.b("뫺郼迾儀戂瘄理縈搊缌欎成嬒瀔笖椘縚漜┞Ġ瘢唤䌦䠨弪䠬缮堰崲攴嘶䨸䠺䨼倾㍀❂݄≆⽈⑊㽌⩎ِ⅒㱔⍖㱘筚⽜㩞ɠ٢౤ᅦ౨ཪ䵬ŮѰὲᥴ坶ᙸॺ嵼᩾ﺆꦈﺌ낐", a_), global::Motorola.Common.Communication.AmpConfigPackage.PackageGenerator.b("黺軼釾", a_));
		}

		// Token: 0x06000196 RID: 406 RVA: 0x000287A0 File Offset: 0x000269A0
		private static void c(global::Motorola.Common.Communication.Pba.PbaObject A_0, string A_1)
		{
			if (!global::Motorola.Common.Communication.CodeplugParseHelper.ReadEncryptPasswordFlag(A_0))
			{
				short num = (short)1082518337;
				short num2 = num;
				num = (short)962849601;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)1973682176;
					short num3 = num;
					num = (short)1789263873;
					if (num != 0)
					{
					}
					num = (short)1129119744;
					if (num != 0)
					{
					}
					break;
				}
				}
				return;
			}
			string plainPwd = global::authAES.AESCryptography.AESDecryptWithDefKey(global::Motorola.Common.Communication.CodeplugParseHelper.ReadEncryptPassword(A_0));
			byte[] cipherKeyBytes = global::Motorola.Common.Communication.AmpPasswords.AmpPasswordsHelper.c(A_1);
			string encryptedPwd = global::authAES.AESCryptography.AESEncrypt(plainPwd, cipherKeyBytes);
			global::Motorola.Common.Communication.CodeplugParseHelper.WriteEncryptPassword(A_0, encryptedPwd);
		}

		// Token: 0x06000197 RID: 407 RVA: 0x00028878 File Offset: 0x00026A78
		public static void UpdateWiFiPasswordBeforeWrite(global::Motorola.Common.Communication.Pba.PbaObject pbaToWrite, string esn)
		{
			int a_ = 12;
			short num = (short)1970864130;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
				{
					num = (short)32440341;
					short num3 = num;
					num = (short)1326252053;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						continue;
					default:
						goto IL_8F;
					}
					break;
				}
				case 1:
					try
					{
						global::Motorola.Common.Communication.CodeplugParseHelper.UpdateWiFiEncryptPassword(pbaToWrite, global::authAES.AESCryptography.CIPHER_DEF_KEY, global::Motorola.Common.Communication.AmpPasswords.AmpPasswordsHelper.c(esn), false);
						return;
					}
					catch (global::System.Exception ex)
					{
						global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteError(global::Motorola.Common.Communication.AmpConfigPackage.PackageGenerator.b("뷻鏽烿刁攃甅笇紉挋簍琏愑尓猕琗標礛氝᨟ȡ焣嘥䰧䬩堫䬭术嬱爳張样嬹伻䴽㜿ⵁ㙃≅ੇ⽉⩋⅍≏㝑͓⑕ㅗ⹙㥛繝ٟ͡ൣ੥൧๩䱫ᥭ᥯ٱᱳ䱵塷Ź䱻ͽ", a_), new object[]
						{
							ex.Message
						});
						throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.Communication_SequenceManager_Astro_Decrypt_WiFi_Password_Fail);
					}
					goto IL_F5;
				case 2:
					switch (0)
					{
					case 0:
						goto IL_39;
					}
					continue;
				}
				IL_39:
				if (string.IsNullOrEmpty(esn))
				{
					num = (short)1540358144;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_F5:
				num = (short)245301248;
				short num4 = num;
				num = (short)1614413825;
				if (num != 0)
				{
				}
				num = (short)1346764801;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_8F:
			num = (short)1690435584;
			if (num != 0)
			{
			}
			throw new global::System.ArgumentException(global::Motorola.Common.Communication.AmpConfigPackage.PackageGenerator.b("뷻鏽烿刁攃甅笇紉挋簍琏愑尓猕琗標礛氝᨟ȡ焣嘥䰧䬩堫䬭术嬱爳張样嬹伻䴽㜿ⵁ㙃≅ੇ⽉⩋⅍≏㝑͓⑕ㅗ⹙㥛繝቟ݡݣͥŧᱩ५੭偯ᱱų᩵ᑷ婹፻౽ꁿﲇ겋ﲑ떓", a_), global::Motorola.Common.Communication.AmpConfigPackage.PackageGenerator.b("駻跽滿", a_));
		}

		// Token: 0x06000198 RID: 408 RVA: 0x00028A1C File Offset: 0x00026C1C
		public static void UpdateWiFiPasswordAfterRead(global::Motorola.Common.Communication.Pba.PbaObject pbaForRead, string esn)
		{
			int a_ = 12;
			short num = (short)373948418;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
				{
					num = (short)188868515;
					short num3 = num;
					num = (short)1313400739;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						continue;
					default:
						goto IL_B5;
					}
					break;
				}
				case 1:
					try
					{
						global::Motorola.Common.Communication.AmpPasswords.AmpPasswordsHelper.b(pbaForRead, esn);
						return;
					}
					catch (global::System.Exception ex)
					{
						global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteError(global::Motorola.Common.Communication.AmpConfigPackage.PackageGenerator.b("뷻鏽烿刁攃甅笇紉挋簍琏愑尓猕琗標礛氝᨟ȡ焣嘥䰧䬩堫䬭术嬱爳張样嬹伻䴽㜿ⵁ㙃≅ेⱉ㡋⭍≏Qㅓ㝕㱗穙㩛㽝य़๡ţɥ䡧ᵩիᩭᡯ䡱味൵䡷ݹ", a_), new object[]
						{
							ex.Message
						});
						throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.Communication_SequenceManager_Astro_Encrypt_WiFi_Password_Fail);
					}
					goto IL_134;
				case 2:
					switch (0)
					{
					case 0:
						goto IL_39;
					}
					continue;
				}
				IL_39:
				num = (short)780992513;
				if (num != 0)
				{
				}
				if (string.IsNullOrEmpty(esn))
				{
					num = (short)79757312;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_134:
				num = (short)240779265;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_B5:
			num = (short)1526202368;
			if (num != 0)
			{
			}
			num = (short)96075776;
			short num4 = num;
			throw new global::System.ArgumentException(global::Motorola.Common.Communication.AmpConfigPackage.PackageGenerator.b("뷻鏽烿刁攃甅笇紉挋簍琏愑尓猕琗標礛氝᨟ȡ焣嘥䰧䬩堫䬭术嬱爳張样嬹伻䴽㜿ⵁ㙃≅ेⱉ㡋⭍≏Qㅓ㝕㱗穙⹛㭝͟ݡൣၥ൧๩䱫mկṱᡳ噵᝷ࡹ屻᭽ﾅꢇﾋ놏", a_), global::Motorola.Common.Communication.AmpConfigPackage.PackageGenerator.b("駻跽滿", a_));
		}

		// Token: 0x06000199 RID: 409 RVA: 0x00028BAC File Offset: 0x00026DAC
		private static void b(global::Motorola.Common.Communication.Pba.PbaObject A_0, string A_1)
		{
			short num = (short)771555328;
			switch (num)
			{
			default:
			{
				num = (short)1986461696;
				short num2 = num;
				byte[] a_ = global::authAES.AESCryptography.HexString2Bytes(A_1);
				global::Motorola.Common.Communication.CommonUtil.IshItemCollection codeplugInIshItemCollection = A_0.GetCodeplugInIshItemCollection();
				int num3 = 0;
				global::System.Collections.Generic.IEnumerator<global::System.Collections.Generic.KeyValuePair<global::Motorola.Common.Communication.CommonUtil.IshHeader, global::Motorola.Common.Communication.CommonUtil.IshItem>> enumerator = codeplugInIshItemCollection.GetEnumerator();
				try
				{
					num = (short)1713176615;
					int num4 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						global::System.Collections.Generic.KeyValuePair<global::Motorola.Common.Communication.CommonUtil.IshHeader, global::Motorola.Common.Communication.CommonUtil.IshItem> keyValuePair;
						int a_2;
						int a_3;
						int a_4;
						byte[] data;
						switch (num4)
						{
						case 0:
						{
							ushort ishType;
							if (ishType - 3664 > 1)
							{
								num = (short)1090256902;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::Motorola.Common.Communication.AmpPasswords.AmpPasswordsHelper.a(keyValuePair.Value, a_, global::authAES.AESCryptography.CIPHER_DEF_KEY, num3, a_2, a_3);
							num = (short)1201930260;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 1:
							num = (short)1763311631;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
							num = (short)591069205;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 3:
						{
							ushort ishType;
							if (ishType <= 3664)
							{
								num = (short)687144970;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)1330184216;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 4:
							num = (short)2027159559;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 5:
							num = (short)1699807243;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 6:
							num = (short)1304625160;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 7:
						{
							ushort ishType;
							if (ishType != 3676)
							{
								num = (short)2138439711;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_42A;
						}
						case 8:
						{
							ushort ishType;
							if (ishType != 3676)
							{
								num = (short)1670643752;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_27E;
						}
						case 9:
							if (num3 != 0)
							{
								num = (short)1239810078;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						case 10:
							num = (short)1415053334;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 11:
						{
							ushort ishType;
							if (ishType == 3664)
							{
								num = (short)1742798884;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 12:
							goto IL_6DE;
						case 13:
						{
							ushort ishType;
							if (ishType != 1160)
							{
								num = (short)1620508691;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_27E;
						}
						case 14:
						{
							ushort ishType;
							if (ishType == 3664)
							{
								num = (short)1328283674;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_54C;
						}
						case 15:
							goto IL_6DE;
						case 17:
						{
							if (!enumerator.MoveNext())
							{
								num = (short)2142240795;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							keyValuePair = enumerator.Current;
							ushort ishType = keyValuePair.Key.IshType;
							num = (short)1421279270;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 18:
							num = (short)380305445;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 19:
							num = (short)1557266432;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 21:
						{
							ushort ishType;
							if (ishType != 3676)
							{
								num = (short)1293549569;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							a_2 = 7;
							a_4 = 99;
							a_3 = ((int)data[1] << 8) + (int)data[2];
							num = (short)1545207842;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 22:
						{
							ushort ishType;
							if (ishType != 1160)
							{
								num = (short)1157365793;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							a_2 = 19;
							a_4 = ((int)data[1] << 8) + (int)data[2];
							a_3 = ((int)data[11] << 8) + (int)data[12];
							num = (short)148504601;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 23:
							goto IL_738;
						case 24:
						{
							ushort ishType;
							if (ishType != 3665)
							{
								num = (short)910622722;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							a_2 = 94;
							num3 = ((int)data[1] << 8) + (int)data[2];
							a_3 = ((int)data[11] << 8) + (int)data[12];
							num = (short)1944322060;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 25:
							goto IL_6DE;
						case 26:
							num = (short)357171209;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 27:
							num = (short)1426063383;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 28:
							goto IL_6DE;
						case 29:
						{
							ushort ishType;
							if (ishType != 3664)
							{
								num = (short)117178386;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							a_2 = 82;
							a_3 = ((int)data[1] << 8) + (int)data[2];
							num = (short)1672806428;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 30:
							goto IL_54C;
						case 31:
							goto IL_1FF;
						case 32:
						{
							ushort ishType;
							if (ishType != 3665)
							{
								num = (short)721027077;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_42A;
						}
						case 33:
							num = (short)422248477;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 34:
							goto IL_6DE;
						case 36:
							goto IL_42A;
						case 37:
							goto IL_6DE;
						case 38:
						{
							ushort ishType;
							if (ishType != 1160)
							{
								num = (short)445382660;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_42A;
						}
						case 39:
							switch (0)
							{
							case 0:
								goto IL_12A;
							}
							continue;
						case 40:
						{
							num = (short)296658162;
							short num5 = num;
							num = (short)687121650;
							switch ((num5 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_1FF;
							default:
								num = (short)497483776;
								if (num != 0)
								{
								}
								num = (short)2112618512;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						}
						goto IL_12A;
						IL_1FF:
						num = (short)483721248;
						num4 = (int)((global::System.IntPtr)num);
						continue;
						IL_27E:
						global::Motorola.Common.Communication.AmpPasswords.AmpPasswordsHelper.a(keyValuePair.Value, a_, global::authAES.AESCryptography.CIPHER_DEF_KEY, a_4, a_2, a_3);
						num = (short)96862243;
						num4 = (int)((global::System.IntPtr)num);
						continue;
						IL_34E:
						num = (short)1273757713;
						num4 = (int)((global::System.IntPtr)num);
						continue;
						IL_12A:
						goto IL_34E;
						IL_42A:
						data = keyValuePair.Value.Data;
						a_2 = 0;
						a_4 = 0;
						a_3 = 0;
						num = (short)967376899;
						num4 = (int)((global::System.IntPtr)num);
						continue;
						IL_54C:
						num = (short)1998979085;
						num4 = (int)((global::System.IntPtr)num);
						continue;
						IL_6DE:
						num = (short)634978318;
						num4 = (int)((global::System.IntPtr)num);
					}
					IL_738:;
				}
				finally
				{
					num = (short)964624386;
					int num4 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num4)
						{
						case 0:
							enumerator.Dispose();
							num = (short)1322450945;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							goto IL_7A3;
						case 2:
							switch (0)
							{
							case 0:
								goto IL_76D;
							}
							continue;
						}
						IL_76D:
						if (enumerator == null)
						{
							break;
						}
						num = (short)1510932480;
						num4 = (int)((global::System.IntPtr)num);
					}
					IL_7A3:;
				}
				num = (short)348389377;
				if (num != 0)
				{
				}
				return;
			}
			}
		}

		// Token: 0x0600019A RID: 410 RVA: 0x000293A4 File Offset: 0x000275A4
		private static void a(global::Motorola.Common.Communication.CommonUtil.IshItem A_0, byte[] A_1, byte[] A_2, int A_3, int A_4, int A_5)
		{
			short num = (short)344260608;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_6E;
				}
				for (;;)
				{
					IL_27:
					string text2;
					string text3;
					switch (num2)
					{
					case 0:
						num = (short)1851260941;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						goto IL_294;
					case 2:
					{
						string text;
						if (!global::Motorola.Common.Communication.AmpPasswords.AmpPasswordsHelper.b(text))
						{
							goto IL_201;
						}
						goto IL_2D1;
					}
					case 3:
						text2 = string.Empty;
						num = (short)1346568207;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						num = (short)461504517;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
					{
						string text;
						if (!global::Motorola.Common.Communication.AmpPasswords.AmpPasswordsHelper.a(text))
						{
							num = (short)1473642496;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2D1;
					}
					case 6:
						goto IL_2CC;
					case 7:
					{
						string text;
						text2 = global::authAES.AESCryptography.AESDecrypt_Ex(text, A_2, 0, 4);
						num = (short)129957899;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 8:
						if (!global::Motorola.Common.Communication.AmpPasswords.AmpPasswordsHelper.a(text2, 63))
						{
							num = (short)1532166151;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_14B;
					case 9:
					{
						int num3;
						if (num3 >= A_5)
						{
							num = (short)1293484038;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						string text = global::authAES.AESCryptography.HEXString(new global::System.ArraySegment<byte>(A_0.Data, A_4 + num3 * A_3, 64).ToArray<byte>());
						num = (short)1333395458;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 10:
					{
						byte[] array = global::authAES.AESCryptography.HexString2Bytes(global::authAES.AESCryptography.AESEncrypt_Ex(text2, A_2, 0, 4));
						if (array.Length != 64)
						{
							goto Block_1;
						}
						int num3;
						global::System.Array.Copy(array, 0, A_0.Data, A_4 + num3 * A_3, 64);
						num3++;
						num = (short)882573313;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 11:
						if (!global::Motorola.Common.Communication.AmpPasswords.AmpPasswordsHelper.a(text2, 63))
						{
							num = (short)1621426179;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_14B;
					case 12:
						text3 = string.Empty;
						goto IL_32E;
					case 13:
					{
						string text;
						text3 = global::authAES.AESCryptography.AESDecrypt_Ex(text, A_1, 0, 4);
						goto IL_32E;
					}
					case 14:
					{
						num = (short)1867448320;
						short num4 = num;
						goto IL_294;
					}
					case 15:
						num = (short)418971649;
						if (num != 0)
						{
						}
						goto IL_14B;
					}
					goto IL_6E;
					IL_14B:
					num = (short)2076704778;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_294:
					num = (short)2044395529;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2D1:
					num = (short)2010578956;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_32E:
					text2 = text3;
					num = (short)295960584;
					num2 = (int)((global::System.IntPtr)num);
				}
				Block_1:
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.ArgumentOutOfRange);
				IL_2CC:
				byte[] data = A_0.Data;
				global::Motorola.Common.Communication.CodeplugParseHelper.UpdateIshItemCRC(ref data, 0, data.Length - 2);
				return;
				IL_6E:
				num = (short)1003386045;
				short num5 = num;
				num = (short)2047112381;
				switch ((num5 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					IL_201:
					num = (short)644546564;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_27;
				default:
				{
					num = (short)1864171520;
					if (num != 0)
					{
					}
					int num3 = 0;
					num = (short)626589710;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_27;
				}
				}
				break;
			}
			}
		}

		// Token: 0x0600019B RID: 411 RVA: 0x0002973C File Offset: 0x0002793C
		public static void UpdateExternalDataModemPasswordBeforeWrite(global::Motorola.Common.Communication.Pba.PbaObject pbaToWrite, string esn)
		{
			int a_ = 17;
			short num = (short)1600847874;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
				{
					num = (short)1328193634;
					short num3 = num;
					num = (short)929734754;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						continue;
					default:
						goto IL_B8;
					}
					break;
				}
				case 1:
					try
					{
						global::Motorola.Common.Communication.CodeplugParseHelper.UpdateExternalDataModemEncryptPassword(pbaToWrite, global::authAES.AESCryptography.CIPHER_DEF_KEY, global::Motorola.Common.Communication.AmpPasswords.AmpPasswordsHelper.c(esn), false);
						return;
					}
					catch (global::System.Exception ex)
					{
						global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteError(global::Motorola.Common.Communication.AmpConfigPackage.PackageGenerator.b("䀀渂甄圆栈砊縌砎縐愒焔搖儘縚焜漞䐠儢ἤܦ簨嬪䤬丮䔰嘲瀴伶䴸帺似儾⁀⽂ń♆㵈⩊L⁎㕐㙒㡔ݖ㡘⡚⹜⡞๠ᅢŤ╦౨൪ɬᵮᑰ⑲ݴṶ൸Ṻ嵼᥾ꮊ戴ﮒ꾔랖ꮚ", a_), new object[]
						{
							ex.Message
						});
						throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.Communication_SequenceManager_Astro_Decrypt_External_Data_Modem_Password_Fail);
					}
					goto IL_13F;
				case 2:
					switch (0)
					{
					case 0:
						goto IL_3B;
					}
					continue;
				}
				IL_3B:
				num = (short)600113153;
				if (num != 0)
				{
				}
				if (string.IsNullOrEmpty(esn))
				{
					num = (short)2092630016;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_13F:
				num = (short)1440808961;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_B8:
			num = (short)1517813760;
			if (num != 0)
			{
			}
			num = (short)1939144704;
			short num4 = num;
			throw new global::System.ArgumentException(global::Motorola.Common.Communication.AmpConfigPackage.PackageGenerator.b("䀀渂甄圆栈砊縌砎縐愒焔搖儘縚焜漞䐠儢ἤܦ簨嬪䤬丮䔰嘲瀴伶䴸帺似儾⁀⽂ń♆㵈⩊L⁎㕐㙒㡔ݖ㡘⡚⹜⡞๠ᅢŤ╦౨൪ɬᵮᑰ⑲ݴṶ൸Ṻ嵼ൾﾈ꾎ﾐ璉ﮖ릘뾞쒠캢햤펦킨讪좬\udcae\udfb0銲", a_), global::Motorola.Common.Communication.AmpConfigPackage.PackageGenerator.b("搀瀂欄", a_));
		}

		// Token: 0x0600019C RID: 412 RVA: 0x000298D4 File Offset: 0x00027AD4
		public static void UpdateExternalDataModemPasswordAfterRead(global::Motorola.Common.Communication.Pba.PbaObject pbaForRead, string esn)
		{
			int a_ = 3;
			short num = (short)1623588864;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					num = (short)243269633;
					if (num != 0)
					{
					}
					switch (0)
					{
					case 0:
						goto IL_60;
					}
					continue;
				case 1:
				{
					num = (short)1526209096;
					short num3 = num;
					num = (short)1199249992;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_153;
					case 1:
						break;
					default:
					{
						num = (short)993918976;
						short num4 = num;
						break;
					}
					}
					num = (short)203096064;
					if (num != 0)
					{
					}
					try
					{
						global::Motorola.Common.Communication.AmpPasswords.AmpPasswordsHelper.a(pbaForRead, esn);
						return;
					}
					catch (global::System.Exception ex)
					{
						global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteError(global::Motorola.Common.Communication.AmpConfigPackage.PackageGenerator.b("닲飴蟶꧸髺軼賾瘀氂眄挆稈䌊栌挎愐瘒朔ⴖ㤘业洜笞䀠圢䀤戦儨弪䠬崮弰刲头猶堸伺尼爾⹀❂⁄⩆᥈⩊㹌㱎♐㱒❔㍖ᡘ㵚⥜㩞፠ㅢd٦൨䭪୬๮ᡰὲၴ፶奸౺ᑼ୾릂ꖄﲆ릈", a_), new object[]
						{
							ex.Message
						});
						throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.Communication_SequenceManager_Astro_Encrypt_External_Data_Modem_Password_Fail);
					}
					goto IL_C1;
				}
				case 2:
					goto IL_7D;
				}
				IL_60:
				if (string.IsNullOrEmpty(esn))
				{
					num = (short)1952514050;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_C1:
				num = (short)44367873;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_7D:
			IL_153:
			throw new global::System.ArgumentException(global::Motorola.Common.Communication.AmpConfigPackage.PackageGenerator.b("닲飴蟶꧸髺軼賾瘀氂眄挆稈䌊栌挎愐瘒朔ⴖ㤘业洜笞䀠圢䀤戦儨弪䠬崮弰刲头猶堸伺尼爾⹀❂⁄⩆᥈⩊㹌㱎♐㱒❔㍖ᡘ㵚⥜㩞፠ㅢd٦൨䭪Ὤ੮ተᙲᱴŶᱸὺ嵼ᅾꞆ力권ﲐ릘ﺚ肠", a_), global::Motorola.Common.Communication.AmpConfigPackage.PackageGenerator.b("雲蛴駶", a_));
		}

		// Token: 0x0600019D RID: 413 RVA: 0x00029A68 File Offset: 0x00027C68
		private static void a(global::Motorola.Common.Communication.Pba.PbaObject A_0, string A_1)
		{
			short num = (short)1323551898;
			short num2 = num;
			num = (short)1378995354;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
				num = (short)1105264640;
				if (num != 0)
				{
				}
				num = (short)1728446465;
				if (num != 0)
				{
				}
				num = (short)150601728;
				switch (num)
				{
				default:
				{
					num = (short)1892614144;
					short num3 = num;
					byte[] a_ = global::Motorola.Common.Communication.AmpPasswords.AmpPasswordsHelper.c(A_1);
					global::Motorola.Common.Communication.CommonUtil.IshItemCollection codeplugInIshItemCollection = A_0.GetCodeplugInIshItemCollection();
					int num4 = 0;
					global::System.Collections.Generic.IEnumerator<global::System.Collections.Generic.KeyValuePair<global::Motorola.Common.Communication.CommonUtil.IshHeader, global::Motorola.Common.Communication.CommonUtil.IshItem>> enumerator = codeplugInIshItemCollection.GetEnumerator();
					try
					{
						num = (short)2014117892;
						int num5 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							int a_2;
							int a_3;
							switch (num5)
							{
							case 0:
							{
								ushort ishType;
								if (ishType != 3665)
								{
									num = (short)726269962;
									num5 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_48E;
							}
							case 1:
								goto IL_555;
							case 2:
								num = (short)2085486614;
								num5 = (int)((global::System.IntPtr)num);
								continue;
							case 3:
							{
								if (!enumerator.MoveNext())
								{
									num = (short)1662451744;
									num5 = (int)((global::System.IntPtr)num);
									continue;
								}
								global::System.Collections.Generic.KeyValuePair<global::Motorola.Common.Communication.CommonUtil.IshHeader, global::Motorola.Common.Communication.CommonUtil.IshItem> keyValuePair = enumerator.Current;
								ushort ishType = keyValuePair.Key.IshType;
								num = (short)129957900;
								num5 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 4:
								switch (0)
								{
								case 0:
									goto IL_179;
								}
								continue;
							case 5:
								goto IL_662;
							case 7:
							{
								global::Motorola.Common.Communication.CommonUtil.IshItem value;
								if (value.Data.Length < 430)
								{
									num = (short)157483027;
									num5 = (int)((global::System.IntPtr)num);
									continue;
								}
								a_2 = 396;
								a_3 = 1;
								num = (short)1316683777;
								num5 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 9:
								goto IL_555;
							case 10:
								num = (short)1674969111;
								num5 = (int)((global::System.IntPtr)num);
								continue;
							case 11:
								num = (short)1759379470;
								num5 = (int)((global::System.IntPtr)num);
								continue;
							case 12:
							{
								ushort ishType;
								if (ishType != 1027)
								{
									num = (short)208863253;
									num5 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_48E;
							}
							case 13:
								num = (short)897253407;
								num5 = (int)((global::System.IntPtr)num);
								continue;
							case 14:
								if (num4 != 0)
								{
									num = (short)293797917;
									num5 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							case 15:
								goto IL_555;
							case 16:
							{
								ushort ishType;
								if (ishType != 3665)
								{
									num = (short)823263245;
									num5 = (int)((global::System.IntPtr)num);
									continue;
								}
								a_2 = 61;
								global::System.Collections.Generic.KeyValuePair<global::Motorola.Common.Communication.CommonUtil.IshHeader, global::Motorola.Common.Communication.CommonUtil.IshItem> keyValuePair;
								global::Motorola.Common.Communication.CommonUtil.IshItem value = keyValuePair.Value;
								int num6 = (int)value.Data[1] << 8;
								value = keyValuePair.Value;
								num4 = num6 + (int)value.Data[2];
								value = keyValuePair.Value;
								int num7 = (int)value.Data[11] << 8;
								value = keyValuePair.Value;
								a_3 = num7 + (int)value.Data[12];
								num = (short)1510473737;
								num5 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 17:
								goto IL_50D;
							case 18:
							{
								ushort ishType;
								if (ishType != 1027)
								{
									num = (short)1365901340;
									num5 = (int)((global::System.IntPtr)num);
									continue;
								}
								global::System.Collections.Generic.KeyValuePair<global::Motorola.Common.Communication.CommonUtil.IshHeader, global::Motorola.Common.Communication.CommonUtil.IshItem> keyValuePair;
								global::Motorola.Common.Communication.AmpPasswords.AmpPasswordsHelper.a(keyValuePair.Value, a_, global::authAES.AESCryptography.CIPHER_DEF_KEY, 0, a_2, a_3, true);
								num = (short)2070478856;
								num5 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 19:
								num = (short)310444049;
								num5 = (int)((global::System.IntPtr)num);
								continue;
							case 20:
							{
								ushort ishType;
								if (ishType == 3664)
								{
									num = (short)391118859;
									num5 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_512;
							}
							case 21:
								num = (short)906821632;
								num5 = (int)((global::System.IntPtr)num);
								continue;
							case 22:
							{
								ushort ishType;
								if (ishType != 3664)
								{
									num = (short)1261502489;
									num5 = (int)((global::System.IntPtr)num);
									continue;
								}
								a_2 = 49;
								global::System.Collections.Generic.KeyValuePair<global::Motorola.Common.Communication.CommonUtil.IshHeader, global::Motorola.Common.Communication.CommonUtil.IshItem> keyValuePair;
								global::Motorola.Common.Communication.CommonUtil.IshItem value = keyValuePair.Value;
								int num8 = (int)value.Data[1] << 8;
								value = keyValuePair.Value;
								a_3 = num8 + (int)value.Data[2];
								num = (short)720699407;
								num5 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 23:
							{
								ushort ishType;
								if (ishType == 3664)
								{
									num = (short)93126683;
									num5 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							}
							case 24:
							{
								global::System.Collections.Generic.KeyValuePair<global::Motorola.Common.Communication.CommonUtil.IshHeader, global::Motorola.Common.Communication.CommonUtil.IshItem> keyValuePair;
								global::Motorola.Common.Communication.AmpPasswords.AmpPasswordsHelper.a(keyValuePair.Value, a_, global::authAES.AESCryptography.CIPHER_DEF_KEY, num4, a_2, a_3, false);
								num = (short)1525022726;
								num5 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 25:
								num = (short)1067581456;
								num5 = (int)((global::System.IntPtr)num);
								continue;
							case 26:
							{
								ushort ishType;
								if (ishType - 3664 <= 1)
								{
									num = (short)1684733976;
									num5 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							}
							case 27:
								goto IL_48E;
							case 28:
								num = (short)215351322;
								num5 = (int)((global::System.IntPtr)num);
								continue;
							case 29:
								goto IL_512;
							case 30:
							{
								ushort ishType;
								if (ishType != 1027)
								{
									num = (short)125042690;
									num5 = (int)((global::System.IntPtr)num);
									continue;
								}
								global::System.Collections.Generic.KeyValuePair<global::Motorola.Common.Communication.CommonUtil.IshHeader, global::Motorola.Common.Communication.CommonUtil.IshItem> keyValuePair;
								global::Motorola.Common.Communication.CommonUtil.IshItem value = keyValuePair.Value;
								num = (short)1500839943;
								num5 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 31:
								goto IL_555;
							case 32:
								num = (short)1297481733;
								num5 = (int)((global::System.IntPtr)num);
								continue;
							}
							IL_3A3:
							num = (short)1748172803;
							num5 = (int)((global::System.IntPtr)num);
							continue;
							IL_179:
							goto IL_3A3;
							IL_48E:
							a_2 = 0;
							a_3 = 0;
							num = (short)617611294;
							num5 = (int)((global::System.IntPtr)num);
							continue;
							IL_512:
							num = (short)1127088146;
							num5 = (int)((global::System.IntPtr)num);
							continue;
							IL_555:
							num = (short)1221394452;
							num5 = (int)((global::System.IntPtr)num);
						}
						IL_50D:
						IL_662:;
					}
					finally
					{
						num = (short)301072384;
						int num5 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num5)
							{
							case 0:
								switch (0)
								{
								case 0:
									goto IL_696;
								}
								continue;
							case 1:
								goto IL_6CB;
							case 2:
								enumerator.Dispose();
								num = (short)787152897;
								num5 = (int)((global::System.IntPtr)num);
								continue;
							}
							IL_696:
							if (enumerator == null)
							{
								break;
							}
							num = (short)1201799170;
							num5 = (int)((global::System.IntPtr)num);
						}
						IL_6CB:;
					}
					break;
				}
				}
				break;
			}
		}

		// Token: 0x0600019E RID: 414 RVA: 0x0002A160 File Offset: 0x00028360
		private static void a(global::Motorola.Common.Communication.CommonUtil.IshItem A_0, byte[] A_1, byte[] A_2, int A_3, int A_4, int A_5, bool A_6 = false)
		{
			int a_ = 4;
			short num = (short)1733558272;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				num = (short)275651054;
				short num3 = num;
				num = (short)1946622446;
				string text2;
				string text;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					IL_18D:
					text = global::authAES.AESCryptography.AESDecrypt_Ex(text2, A_1, 0, 3);
					goto IL_2B6;
				default:
					num = (short)1560281088;
					if (num != 0)
					{
					}
					switch (0)
					{
					case 0:
						goto IL_BE;
					}
					break;
				}
				string text3;
				int num4;
				byte[] data;
				for (;;)
				{
					IL_7B:
					switch (num2)
					{
					case 0:
						if (!global::Motorola.Common.Communication.AmpPasswords.AmpPasswordsHelper.f.IsMatch(text3))
						{
							num = (short)799997955;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_261;
					case 1:
						if (A_6)
						{
							num = (short)1311244302;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_370;
					case 2:
						goto IL_18D;
					case 3:
						text3 = global::authAES.AESCryptography.AESDecrypt_Ex(text2, A_2, 0, 3);
						num = (short)58458122;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						if (!global::Motorola.Common.Communication.AmpPasswords.AmpPasswordsHelper.b(text2))
						{
							num = (short)850722828;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1289814022;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						text3 = global::Motorola.Common.Communication.AmpConfigPackage.PackageGenerator.b("엳쓵쯷컹짻", a_);
						num = (short)678559755;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
						goto IL_30F;
					case 7:
						num = (short)892731393;
						if (num != 0)
						{
						}
						goto IL_10B;
					case 8:
					{
						if (num4 >= A_5)
						{
							num = (short)174260233;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						text2 = global::authAES.AESCryptography.HEXString(new global::System.ArraySegment<byte>(data, A_4 + num4 * A_3, 33).ToArray<byte>());
						num = (short)1573584896;
						short num5 = num;
						num = (short)1041367044;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 9:
						num = (short)69730305;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 10:
						if (!global::Motorola.Common.Communication.AmpPasswords.AmpPasswordsHelper.f.IsMatch(text3))
						{
							num = (short)510394373;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_261;
					case 11:
						goto IL_261;
					case 12:
						num = (short)1891696642;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 13:
						goto IL_10B;
					case 14:
						goto IL_1D2;
					}
					goto IL_BE;
					IL_10B:
					num = (short)1381629960;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_261:
					global::System.Array.Copy(global::authAES.AESCryptography.HexString2Bytes(global::authAES.AESCryptography.AESEncrypt_Ex(text3, A_2, 0, 3).Substring(0, 66)), 0, data, A_4 + num4 * A_3, 33);
					num4++;
					num = (short)1071317005;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_1D2:
				global::Motorola.Common.Communication.CodeplugParseHelper.UpdateIshItemCRC(ref data, 1, data.Length - 3);
				return;
				IL_30F:
				text = global::Motorola.Common.Communication.AmpConfigPackage.PackageGenerator.b("엳쓵쯷컹짻", a_);
				goto IL_2B6;
				IL_370:
				global::Motorola.Common.Communication.CodeplugParseHelper.UpdateIshItemCRC(ref data, 0, data.Length - 2);
				return;
				IL_BE:
				data = A_0.Data;
				num4 = 0;
				num = (short)771686407;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_7B;
				IL_2B6:
				text3 = text;
				num = (short)1706622976;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_7B;
			}
			}
		}

		// Token: 0x0600019F RID: 415 RVA: 0x0002A4EC File Offset: 0x000286EC
		private static byte[] c(string esn)
		{
			short num = (short)966937276;
			short num2 = num;
			num = (short)1371818684;
			switch (num2 == num)
			{
			}
			num = (short)2064580609;
			if (num != 0)
			{
			}
			num = (short)723910656;
			short num3 = num;
			num = (short)2116354048;
			if (num != 0)
			{
			}
			return global::authAES.AESCryptography.HexString2Bytes(esn.ToUpper());
		}

		// Token: 0x060001A0 RID: 416 RVA: 0x0002A5A4 File Offset: 0x000287A4
		private static bool b(string password)
		{
			short num = (short)1497827715;
			short num2 = num;
			num = (short)2143816067;
			switch (num2 == num)
			{
			}
			num = (short)437649408;
			if (num != 0)
			{
			}
			num = (short)770834432;
			short num3 = num;
			num = (short)891224065;
			if (num != 0)
			{
			}
			return global::System.Array.TrueForAll<char>(password.ToCharArray(), new global::System.Predicate<char>(global::Motorola.Common.Communication.AmpPasswords.AmpPasswordsHelper.<>c.<>9.a));
		}

		// Token: 0x060001A1 RID: 417 RVA: 0x0002A67C File Offset: 0x0002887C
		private static bool a(string encryptedHexString)
		{
			short num = (short)1784207563;
			short num2 = num;
			num = (short)1547294923;
			switch (num2 == num)
			{
			}
			num = (short)802750464;
			if (num != 0)
			{
			}
			num = (short)383188992;
			short num3 = num;
			num = (short)1067188225;
			if (num != 0)
			{
			}
			return encryptedHexString == global::authAES.AESCryptography.AESEncryptWithDefKey_ForWiFiPassword(string.Empty);
		}

		// Token: 0x060001A2 RID: 418 RVA: 0x0002A734 File Offset: 0x00028934
		private static bool a(string A_0, int A_1 = 63)
		{
			short num = (short)1661927425;
			if (num != 0)
			{
			}
			num = (short)2002321408;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					switch (0)
					{
					case 0:
						goto IL_56;
					}
					continue;
				case 1:
					goto IL_105;
				case 2:
					return false;
				}
				IL_56:
				if (A_0.Length > A_1)
				{
					num = (short)1565130754;
					num2 = (int)((global::System.IntPtr)num);
				}
				else
				{
					num = (short)1507924339;
					short num3 = num;
					num = (short)896866675;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						continue;
					case 1:
						break;
					default:
					{
						num = (short)2071396352;
						short num4 = num;
						break;
					}
					}
					num = (short)530317312;
					if (num != 0)
					{
					}
					num = (short)930938881;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
			return false;
			IL_105:
			return global::System.Array.TrueForAll<char>(A_0.ToCharArray(), new global::System.Predicate<char>(global::Motorola.Common.Communication.AmpPasswords.AmpPasswordsHelper.<>c.<>9.b));
		}

		// Token: 0x060001A3 RID: 419 RVA: 0x0002A874 File Offset: 0x00028A74
		// Note: this type is marked as 'beforefieldinit'.
		static AmpPasswordsHelper()
		{
			int a_ = 15;
			short num = (short)43375212;
			short num2 = num;
			num = (short)493804140;
			switch (num2 == num)
			{
			}
			num = (short)1248329728;
			if (num != 0)
			{
			}
			num = (short)167182336;
			short num3 = num;
			num = (short)113508353;
			if (num != 0)
			{
			}
			global::Motorola.Common.Communication.AmpPasswords.AmpPasswordsHelper.e = new global::System.Text.RegularExpressions.Regex(global::Motorola.Common.Communication.AmpConfigPackage.PackageGenerator.b("ꇾ娀㌂⠄㸆䠈☊圌渎㰐椒䤔㜖䔘㘚䄜㐞素ఢ礤ദ用ࠪ焬म洰ᘲ椴ጶ搸䀺഼ጾ獀獂㡄捆", a_), global::System.Text.RegularExpressions.RegexOptions.Compiled);
			global::Motorola.Common.Communication.AmpPasswords.AmpPasswordsHelper.f = new global::System.Text.RegularExpressions.Regex(global::Motorola.Common.Communication.AmpConfigPackage.PackageGenerator.b("ꇾ娀㌂⠄㸆䠈☊圌渎㰐椒䤔㨖䔘㔚䀜搞ᔠ༢ᘤᔦ吨༪", a_), global::System.Text.RegularExpressions.RegexOptions.Compiled);
		}

		// Token: 0x040000D2 RID: 210
		private const int a = 1160;

		// Token: 0x040000D3 RID: 211
		private const int b = 3676;

		// Token: 0x040000D4 RID: 212
		private const int c = 3665;

		// Token: 0x040000D5 RID: 213
		private const int d = 3664;

		// Token: 0x040000D6 RID: 214
		private static readonly global::System.Text.RegularExpressions.Regex e;

		// Token: 0x040000D7 RID: 215
		private static readonly global::System.Text.RegularExpressions.Regex f;
	}
}
