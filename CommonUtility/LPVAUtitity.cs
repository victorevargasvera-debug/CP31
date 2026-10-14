using System;
using System.Collections.Generic;
using System.Globalization;
using System.Reflection;
using Motorola.Common.Communication.Pba;
using Motorola.CommonCPS.Server.EntityModel;
using RFResourceRepository;

namespace CommonUtility
{
	// Token: 0x02000037 RID: 55
	public static class LPVAUtitity
	{
		// Token: 0x17000023 RID: 35
		// (get) Token: 0x0600011F RID: 287 RVA: 0x0001E338 File Offset: 0x0001C538
		public static string VAFilesFilter
		{
			get
			{
				int a_ = 10;
				short num = (short)640783362;
				short num2 = num;
				num = (short)155423746;
				switch (num2 == num)
				{
				}
				num = (short)68681729;
				if (num != 0)
				{
				}
				num = (short)1135935488;
				if (num != 0)
				{
				}
				num = (short)77660160;
				short num3 = num;
				return string.Format(global::System.Globalization.CultureInfo.InvariantCulture, global::CommonUtility.VersionUtility.b("洺刼嘾≀♂敄ن❈╊≌㩎㽐げご㩖㱘㕚⥜ⱞᵠ䥢Ṥ坦ᑨ偪䝬ᑮ䁰๲", a_), global::CommonUtility.VersionUtility.b("ᔺ值䤾⁀", a_), global::CommonUtility.VersionUtility.b("ᔺ䨼帾㝀", a_));
			}
		}

		// Token: 0x06000120 RID: 288 RVA: 0x0001E420 File Offset: 0x0001C620
		public static bool IsWavExtension(string filePath)
		{
			int a_ = 5;
			short num;
			for (;;)
			{
				num = (short)506724353;
				if (num != 0)
				{
				}
				if (filePath.EndsWith(global::CommonUtility.VersionUtility.b("ᠵ伷嬹䨻", a_), global::System.StringComparison.OrdinalIgnoreCase))
				{
					num = (short)272257;
					short num2 = num;
					num = (short)1822631809;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						continue;
					case 1:
						goto IL_AB;
					}
					break;
				}
				return false;
			}
			num = (short)293994496;
			short num3 = num;
			IL_AB:
			num = (short)523960320;
			if (num != 0)
			{
			}
			return true;
		}

		// Token: 0x06000121 RID: 289 RVA: 0x0001E4F4 File Offset: 0x0001C6F4
		public static bool IsMvaExtension(string filePath)
		{
			int a_ = 18;
			while (filePath.EndsWith(global::CommonUtility.VersionUtility.b("浂⡄ㅆ⡈", a_), global::System.StringComparison.OrdinalIgnoreCase))
			{
				short num = (short)1663574972;
				short num2 = num;
				num = (short)1009591228;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)1884946432;
					short num3 = num;
					num = (short)605421569;
					if (num != 0)
					{
					}
					num = (short)1149763584;
					if (num != 0)
					{
					}
					return true;
				}
				}
			}
			return false;
		}

		// Token: 0x06000122 RID: 290 RVA: 0x0001E5C8 File Offset: 0x0001C7C8
		public static bool IsTTSExtension(string filePath)
		{
			int a_ = 10;
			while (filePath.EndsWith(global::CommonUtility.VersionUtility.b("ᔺ䤼䬾㉀㍂⑄⑆≈", a_), global::System.StringComparison.OrdinalIgnoreCase))
			{
				short num = (short)1562443777;
				if (num != 0)
				{
				}
				num = (short)351815118;
				short num2 = num;
				num = (short)466109902;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					continue;
				case 1:
					break;
				default:
				{
					num = (short)1432551424;
					short num3 = num;
					break;
				}
				}
				num = (short)115277824;
				if (num != 0)
				{
				}
				return true;
			}
			return false;
		}

		// Token: 0x06000123 RID: 291 RVA: 0x0001E69C File Offset: 0x0001C89C
		public static bool IsSupportedVAExtension(string filePath)
		{
			short num = (short)164102147;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
				{
					num = (short)1646029842;
					short num3 = num;
					num = (short)1698130962;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_EC;
					default:
						num = (short)784007168;
						if (num != 0)
						{
						}
						if (!global::CommonUtility.LPVAUtitity.IsWavExtension(filePath))
						{
							num = (short)1120337924;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return true;
					}
					break;
				}
				case 1:
					goto IL_EA;
				case 2:
					goto IL_EC;
				case 3:
					switch (0)
					{
					case 0:
						goto IL_3D;
					}
					continue;
				case 4:
				{
					num = (short)155189248;
					short num4 = num;
					num = (short)2139029509;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 5:
					if (global::CommonUtility.LPVAUtitity.IsTTSExtension(filePath))
					{
						num = (short)654376961;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return false;
				}
				IL_3D:
				if (!global::CommonUtility.LPVAUtitity.IsMvaExtension(filePath))
				{
					num = (short)566165505;
					if (num != 0)
					{
					}
					num = (short)582025218;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_EC:
				num = (short)1812070400;
				num2 = (int)((global::System.IntPtr)num);
			}
			return true;
			IL_EA:
			return true;
		}

		// Token: 0x06000124 RID: 292 RVA: 0x0001E820 File Offset: 0x0001CA20
		public static string LPValueConvertFromCPValue(global::System.Type typeOfFieldLov, string fieldValue)
		{
			int a_ = 4;
			short num = (short)1085276160;
			switch (num)
			{
			default:
			{
				num = (short)842924037;
				int num2 = (int)((global::System.IntPtr)num);
				global::System.Collections.Generic.KeyValuePair<string, int?> keyValuePair;
				for (;;)
				{
					int num5;
					switch (num2)
					{
					case 0:
					{
						int num3;
						global::System.Reflection.FieldInfo[] fields;
						if (num3 >= fields.Length)
						{
							num = (short)1391984643;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						keyValuePair = (global::System.Collections.Generic.KeyValuePair<string, int?>)fields[num3].GetValue(null);
						int? value = keyValuePair.Value;
						int num4 = num5;
						num = (short)1629437189;
						short num6 = num;
						num = (short)2056207621;
						switch ((num6 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_220;
						default:
							num = (short)1126629376;
							if (num != 0)
							{
							}
							num = (short)1266155522;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 1:
					{
						global::System.Reflection.FieldInfo[] fields = typeOfFieldLov.GetFields(global::System.Reflection.BindingFlags.Static | global::System.Reflection.BindingFlags.Public | global::System.Reflection.BindingFlags.GetField);
						int num3 = 0;
						num = (short)1411055623;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
					{
						int? value;
						int num4;
						if (value.GetValueOrDefault() == num4 & value != null)
						{
							num = (short)2136342532;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						int num3;
						num3++;
						num = (short)1269366790;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 3:
						goto IL_169;
					case 4:
						goto IL_21B;
					case 5:
						switch (0)
						{
						case 0:
							goto IL_6C;
						}
						continue;
					case 6:
						goto IL_131;
					case 7:
						goto IL_131;
					}
					IL_6C:
					if (int.TryParse(fieldValue, out num5))
					{
						num = (short)1011023872;
						short num7 = num;
						num = (short)2120941569;
						if (num != 0)
						{
						}
						num = (short)415367169;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
					IL_131:
					num = (short)1198391296;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_169:
				goto IL_220;
				IL_21B:
				return keyValuePair.Key;
				IL_220:
				throw new global::System.ArgumentException(string.Format(global::System.Globalization.CultureInfo.InvariantCulture, global::CommonUtility.VersionUtility.b("瘴嘶圸᰺䤼Ἶ❀⩂⭄⍆楈⩊⍌㙎煐㩒⅔㉖㑘筚⩜㝞๠ၢd䝦⩨㭪㭬๮ᵰٲၴ坶ၸࡺ嵼塾婢뎂ꂆꦈﾌﲐ뎒ﺚ붜뢞\udaa0銢\ud8a4肦螨", a_), fieldValue, typeOfFieldLov.Name));
			}
			}
		}

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x06000125 RID: 293 RVA: 0x0001EA74 File Offset: 0x0001CC74
		public static string TTSFilesFilter
		{
			get
			{
				int a_ = 18;
				short num = (short)2071187971;
				short num2 = num;
				num = (short)1185862147;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1418526720;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1276051457;
				if (num != 0)
				{
				}
				num = (short)139132928;
				if (num != 0)
				{
				}
				return string.Format(global::System.Globalization.CultureInfo.InvariantCulture, global::CommonUtility.VersionUtility.b("ᝂ⁄㽆㵈歊᥌⁎煐R╔㉖㱘㡚㕜罞❠੢।ɦᩨᝪ䝬ᑮ䅰๲", a_), global::CommonUtility.VersionUtility.b("浂ㅄ㍆㩈㭊ⱌⱎ㩐", a_));
			}
		}

		// Token: 0x06000126 RID: 294 RVA: 0x0001EB4C File Offset: 0x0001CD4C
		public static bool IsSupportedTTSExtension(string filePath)
		{
			int a_ = 10;
			if (filePath.EndsWith(global::CommonUtility.VersionUtility.b("ᔺ䤼䬾㉀㍂⑄⑆≈", a_), global::System.StringComparison.OrdinalIgnoreCase))
			{
				short num = (short)1674607883;
				short num2 = num;
				num = (short)546995467;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)420741121;
					if (num != 0)
					{
					}
					num = (short)30801920;
					short num3 = num;
					num = (short)9699328;
					if (num != 0)
					{
					}
					break;
				}
				}
				return true;
			}
			return false;
		}

		// Token: 0x06000127 RID: 295 RVA: 0x0001EC1C File Offset: 0x0001CE1C
		public static global::Motorola.Common.Communication.Pba.PcrLanguagePackInfo Convert_PCRLanguagePack_to_PCRLanguagePackInfo(global::Motorola.CommonCPS.Server.EntityModel.PCRLanguagePack pak)
		{
			short num = (short)720306176;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_67;
				}
				global::System.Guid? fileUuid;
				global::Motorola.Common.Communication.Pba.PcrLanguagePackInfo pcrLanguagePackInfo2;
				for (;;)
				{
					IL_28:
					num = (short)155189248;
					short num3 = num;
					switch (num2)
					{
					case 0:
						goto IL_12C;
					case 1:
						num = (short)1088028673;
						if (num != 0)
						{
						}
						if (fileUuid != null)
						{
							num = (short)720699392;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_18A;
					case 2:
						goto IL_18A;
					}
					goto IL_67;
					IL_12C:
					global::Motorola.Common.Communication.Pba.PcrLanguagePackInfo pcrLanguagePackInfo = pcrLanguagePackInfo2;
					fileUuid = pak.FileUuid;
					pcrLanguagePackInfo.PackFilePath = fileUuid.Value.ToString();
					global::Motorola.Common.Communication.Pba.LanguagePackBase languagePackBase = pcrLanguagePackInfo2;
					fileUuid = pak.FileUuid;
					languagePackBase.sourceFilePath = fileUuid.Value.ToString();
					num = (short)1278214146;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_18A:
					num = (short)367142907;
					short num4 = num;
					num = (short)1741367291;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_12C;
					default:
						goto IL_1C1;
					}
				}
				IL_1C1:
				num = (short)1253376000;
				if (num != 0)
				{
				}
				return pcrLanguagePackInfo2;
				IL_67:
				pcrLanguagePackInfo2 = new global::Motorola.Common.Communication.Pba.PcrLanguagePackInfo();
				string[] array = pak.PackageVersion.Split(new char[]
				{
					'.'
				});
				pcrLanguagePackInfo2.MajorVersion = global::System.Convert.ToUInt32(array[0], global::System.Globalization.CultureInfo.InvariantCulture);
				pcrLanguagePackInfo2.MinorVersion = global::System.Convert.ToUInt32(array[1], global::System.Globalization.CultureInfo.InvariantCulture);
				pcrLanguagePackInfo2.Name = pak.PackageName;
				pcrLanguagePackInfo2.PackID = pak.PackageID;
				fileUuid = pak.FileUuid;
				num = (short)2142175233;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_28;
			}
			}
		}

		// Token: 0x06000128 RID: 296 RVA: 0x0001EE00 File Offset: 0x0001D000
		public static global::Motorola.Common.Communication.Pba.PcrLanguagePackInfo Convert_LanguageSettingDesc_to_PCRLanguagePackInfo(global::Motorola.CommonCPS.Server.EntityModel.LanguageSettingDesc languageSettingItem)
		{
			short num = (short)2038620603;
			short num2 = num;
			num = (short)2110906811;
			switch (num2 == num)
			{
			default:
			{
				num = (short)2051342336;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1479671809;
			if (num != 0)
			{
			}
			num = (short)664469504;
			if (num != 0)
			{
			}
			return new global::Motorola.Common.Communication.Pba.PcrLanguagePackInfo
			{
				Name = (string.IsNullOrEmpty(languageSettingItem.LanguageName) ? global::RFResourceRepository.PCRResourceHelper.Instance().GetRFResourceValueByResourceID(global::CommonUtility.PCRLanguageUtility.ToResourceID(languageSettingItem.LanguageID), null) : languageSettingItem.LanguageName),
				PackID = languageSettingItem.LanguageID,
				MajorVersion = 0U,
				MinorVersion = 0U
			};
		}

		// Token: 0x040000A3 RID: 163
		public const string TTSExtension = ".ttspack";

		// Token: 0x040000A4 RID: 164
		public const string WavExtension = ".wav";

		// Token: 0x040000A5 RID: 165
		public const string MvaExtension = ".mva";
	}
}
