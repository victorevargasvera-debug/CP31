using System;
using System.Collections.Generic;
using System.Configuration;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Text.RegularExpressions;
using Microsoft.Win32;
using Motorola.Common.Communication.CommonUtil;
using Motorola.Common.CustomException;
using Motorola.Common.LogUtility;
using Motorola.CommonCPS.RadioManagement.CommonBase;
using Motorola.CommonCPS.RadioManagement.Global.Properties;
using Motorola.CommonCPS.Server.CommonDBConstants;
using Motorola.CommonCPS.Server.EntityModel.GenericModel;

namespace Motorola.CommonCPS.RadioManagement.SharedServices
{
	// Token: 0x020000B4 RID: 180
	public class ConfigurationRegistryAndSetting : global::Motorola.CommonCPS.RadioManagement.SharedServices.IRegistryAndSetting
	{
		// Token: 0x17000100 RID: 256
		// (get) Token: 0x06000A77 RID: 2679 RVA: 0x0007F514 File Offset: 0x0007D714
		private string EntryPath
		{
			get
			{
				short num = (short)1899823104;
				short num2 = num;
				num = (short)1696380854;
				short num3 = num;
				num = (short)458995638;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)330629120;
					if (num != 0)
					{
					}
					num = (short)1484390401;
					if (num != 0)
					{
					}
					if (!(global::System.Reflection.Assembly.GetEntryAssembly() == null))
					{
						return global::System.IO.Path.GetDirectoryName(global::System.Reflection.Assembly.GetEntryAssembly().Location);
					}
					break;
				}
				return string.Empty;
			}
		}

		// Token: 0x06000A78 RID: 2680 RVA: 0x0007F5E0 File Offset: 0x0007D7E0
		public string GetCurrentDisplayLanguage()
		{
			short num = (short)1623966957;
			short num2 = num;
			num = (short)1602733293;
			switch (num2 == num)
			{
			}
			num = (short)790364161;
			if (num != 0)
			{
			}
			num = (short)516096000;
			short num3 = num;
			num = (short)1652293632;
			if (num != 0)
			{
			}
			throw new global::System.NotImplementedException();
		}

		// Token: 0x06000A79 RID: 2681 RVA: 0x0007F690 File Offset: 0x0007D890
		public global::Motorola.CommonCPS.Server.CommonDBConstants.RegionName? GetDefaultRegion()
		{
			short num = (short)941636868;
			short num2 = num;
			num = (short)1725709572;
			switch (num2 == num)
			{
			}
			num = (short)1947664385;
			if (num != 0)
			{
			}
			num = (short)1302200320;
			short num3 = num;
			num = (short)885653504;
			if (num != 0)
			{
			}
			return new global::Motorola.CommonCPS.Server.CommonDBConstants.RegionName?(global::Motorola.CommonCPS.Server.CommonDBConstants.RegionName.NULL);
		}

		// Token: 0x06000A7A RID: 2682 RVA: 0x0007F740 File Offset: 0x0007D940
		public global::Motorola.CommonCPS.Server.CommonDBConstants.RegionName? GetRegion()
		{
			short num = (short)825037631;
			short num2 = num;
			num = (short)384570175;
			switch (num2 == num)
			{
			}
			num = (short)1071251456;
			if (num != 0)
			{
			}
			num = (short)1083244544;
			short num3 = num;
			num = (short)2045181953;
			if (num != 0)
			{
			}
			return null;
		}

		// Token: 0x06000A7B RID: 2683 RVA: 0x0007F7F0 File Offset: 0x0007D9F0
		public string GetXferFolderPath()
		{
			int a_ = 3;
			short num = (short)1209270272;
			short num2 = num;
			num = (short)675900144;
			short num3 = num;
			num = (short)216820464;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
				num = (short)767098880;
				if (num != 0)
				{
				}
				num = (short)822149121;
				if (num != 0)
				{
				}
				if (!string.IsNullOrEmpty(global::System.Configuration.ConfigurationManager.AppSettings[global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("슙瀞ﮝ튟쮣쪥첧쾩\udeabﺭ톯욱\udcb3", a_)]))
				{
					return global::System.Configuration.ConfigurationManager.AppSettings[global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("슙瀞ﮝ튟쮣쪥첧쾩\udeabﺭ톯욱\udcb3", a_)];
				}
				break;
			}
			return global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("\ud999ꚛ슝킡쮣솥\udaa7쮩솫톯욱햳햹좻톽늿귁ꣃꟅ铇觉鳋鷍迏胑駓諕胗鳙駛賝", a_);
		}

		// Token: 0x06000A7C RID: 2684 RVA: 0x0007F8E8 File Offset: 0x0007DAE8
		public global::System.Collections.Generic.IList<string> GetAllDisplayLanguage()
		{
			short num = (short)1379758180;
			short num2 = num;
			num = (short)1074425956;
			switch (num2 == num)
			{
			}
			num = (short)1449787393;
			if (num != 0)
			{
			}
			num = (short)495845376;
			short num3 = num;
			num = (short)1301741568;
			if (num != 0)
			{
			}
			throw new global::System.NotImplementedException();
		}

		// Token: 0x06000A7D RID: 2685 RVA: 0x0007F994 File Offset: 0x0007DB94
		public string GetLanguagePacksInstallPath(global::Motorola.CommonCPS.Server.CommonDBConstants.PACType pac)
		{
			switch (0)
			{
			case 0:
				goto IL_4E;
			}
			short num;
			int num3;
			for (;;)
			{
				IL_0A:
				num = (short)1026031616;
				short num2 = num;
				switch (num3)
				{
				case 0:
				{
					num = (short)1983332520;
					short num4 = num;
					num = (short)575160488;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_81;
					default:
						num = (short)1452408832;
						if (num != 0)
						{
						}
						if (pac != global::Motorola.CommonCPS.Server.CommonDBConstants.PACType.PCR)
						{
							num = (short)916324356;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_161;
					}
					break;
				}
				case 1:
					if (pac != global::Motorola.CommonCPS.Server.CommonDBConstants.PACType.ASTRO)
					{
						num = (short)412286979;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_81;
				case 2:
					goto IL_B2;
				case 3:
					num = (short)1810104320;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					num = (short)982974465;
					if (num != 0)
					{
					}
					num = (short)287834114;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_4E;
			}
			IL_81:
			string path = global::Motorola.CommonCPS.RadioManagement.Global.Properties.Settings.Default.ASTROLanguagePacksLocation;
			return global::System.IO.Path.Combine(this.EntryPath, path);
			IL_B2:
			throw new global::System.NotImplementedException();
			IL_161:
			path = global::Motorola.CommonCPS.RadioManagement.Global.Properties.Settings.Default.PCRLanguagePacksLocation;
			return global::System.IO.Path.Combine(this.EntryPath, path);
			IL_4E:
			path = string.Empty;
			num = (short)41680897;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_0A;
		}

		// Token: 0x06000A7E RID: 2686 RVA: 0x0007FB20 File Offset: 0x0007DD20
		public string GetVoiceAnnouncementInstallPath(global::Motorola.CommonCPS.Server.CommonDBConstants.PACType pac)
		{
			short num = (short)653393921;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					if (pac != global::Motorola.CommonCPS.Server.CommonDBConstants.PACType.PCR)
					{
						num = (short)251199488;
						short num3 = num;
						num = (short)1040056324;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_130;
				case 1:
					switch (0)
					{
					case 0:
						goto IL_3A;
					}
					continue;
				case 2:
					goto IL_CD;
				case 3:
					num = (short)2129264640;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
				{
					num = (short)583943943;
					short num4 = num;
					num = (short)339887879;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_130;
					default:
						num = (short)1811611648;
						if (num != 0)
						{
						}
						num = (short)537395202;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				}
				IL_3A:
				if (pac == global::Motorola.CommonCPS.Server.CommonDBConstants.PACType.ASTRO)
				{
					break;
				}
				num = (short)818741251;
				num2 = (int)((global::System.IntPtr)num);
			}
			string astrovoiceAnnouncementLocation = global::Motorola.CommonCPS.RadioManagement.Global.Properties.Settings.Default.ASTROVoiceAnnouncementLocation;
			return global::System.IO.Path.Combine(this.EntryPath, astrovoiceAnnouncementLocation);
			IL_CD:
			num = (short)1628962817;
			if (num != 0)
			{
			}
			throw new global::System.NotImplementedException();
			IL_130:
			string pcrvoiceAnnouncementLocation = global::Motorola.CommonCPS.RadioManagement.Global.Properties.Settings.Default.PCRVoiceAnnouncementLocation;
			return global::System.IO.Path.Combine(this.EntryPath, pcrvoiceAnnouncementLocation);
		}

		// Token: 0x06000A7F RID: 2687 RVA: 0x0007FCA4 File Offset: 0x0007DEA4
		public string GetTextToSpeechInstallPath()
		{
			short num = (short)681397930;
			short num2 = num;
			num = (short)623726250;
			switch (num2 == num)
			{
			}
			num = (short)319356928;
			if (num != 0)
			{
			}
			num = (short)1801781248;
			short num3 = num;
			num = (short)1714814977;
			if (num != 0)
			{
			}
			string pcrtextToSpeechLocation = global::Motorola.CommonCPS.RadioManagement.Global.Properties.Settings.Default.PCRTextToSpeechLocation;
			return global::System.IO.Path.Combine(this.EntryPath, pcrtextToSpeechLocation);
		}

		// Token: 0x06000A80 RID: 2688 RVA: 0x0007FD68 File Offset: 0x0007DF68
		public global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.GenericModel.PCRFirmwareCodeplugPairPackageFileInfo> GetPCRFirmwareInstallInfos()
		{
			int a_ = 3;
			short num = (short)65208320;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_4B;
				}
				string text;
				global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.GenericModel.PCRFirmwareCodeplugPairPackageFileInfo> list2;
				for (;;)
				{
					IL_30:
					global::Microsoft.Win32.RegistryKey registryKey;
					switch (num2)
					{
					case 0:
						goto IL_5E2;
					case 1:
						if (global::System.Environment.Is64BitOperatingSystem)
						{
							num = (short)1200553987;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						text = string.Format(global::System.Globalization.CultureInfo.InvariantCulture, text, string.Empty);
						num = (short)1186463748;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						goto IL_BE;
						try
						{
							for (;;)
							{
								IL_BE:
								switch (0)
								{
								case 0:
									goto IL_EF;
								}
								for (;;)
								{
									IL_C8:
									int num4;
									string[] subKeyNames;
									switch (num2)
									{
									case 0:
									{
										num = (short)2091010858;
										short num3 = num;
										num = (short)1918651178;
										switch ((num3 == num) ? 1 : 0)
										{
										case 0:
										case 2:
											goto IL_BE;
										default:
											num = (short)1132920832;
											if (num != 0)
											{
											}
											if (registryKey == null)
											{
												num = (short)1639776260;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											goto IL_589;
										}
										break;
									}
									case 1:
									{
										if (num4 >= subKeyNames.Length)
										{
											num = (short)327876614;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										string text2 = subKeyNames[num4];
										num = (short)1242497029;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 2:
										goto IL_179;
									case 3:
										goto IL_179;
									case 4:
										goto IL_177;
									case 5:
										try
										{
											switch (0)
											{
											case 0:
												goto IL_281;
											}
											global::Microsoft.Win32.RegistryKey registryKey2;
											global::Motorola.CommonCPS.Server.EntityModel.GenericModel.PCRFirmwareCodeplugPairPackageFileInfo pcrfirmwareCodeplugPairPackageFileInfo;
											global::System.Collections.Generic.List<string> list;
											string[] valueNames;
											for (;;)
											{
												IL_242:
												int num5;
												switch (num2)
												{
												case 0:
													goto IL_522;
												case 1:
													if (registryKey2.GetValue(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("좙鍊얟쎡힣쎥獵\udfa9춫\udcad쒯ힱ욳", a_)) != null)
													{
														num = (short)1049559045;
														num2 = (int)((global::System.IntPtr)num);
														continue;
													}
													goto IL_3D2;
												case 2:
													pcrfirmwareCodeplugPairPackageFileInfo.XferFolderPath = this.GetXferFolderPath();
													pcrfirmwareCodeplugPairPackageFileInfo.Path = list.ToArray();
													list2.Add(pcrfirmwareCodeplugPairPackageFileInfo);
													num = (short)2139291655;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												case 3:
												{
													string text3;
													list.Add(registryKey2.GetValue(text3).ToString());
													num = (short)236322816;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												case 4:
													goto IL_4A0;
												case 5:
													pcrfirmwareCodeplugPairPackageFileInfo.RDate = registryKey2.GetValue(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("좙鍊얟쎡힣쎥獵\udfa9춫\udcad쒯ힱ욳", a_)).ToString();
													num = (short)130940937;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												case 6:
													if (new global::Motorola.Common.Communication.CommonUtil.PackageHandler(pcrfirmwareCodeplugPairPackageFileInfo.Title, pcrfirmwareCodeplugPairPackageFileInfo.Type, pcrfirmwareCodeplugPairPackageFileInfo.RDate).IsProperPackage())
													{
														num = (short)1366753292;
														num2 = (int)((global::System.IntPtr)num);
														continue;
													}
													goto IL_546;
												case 7:
													goto IL_546;
												case 8:
												{
													string text3;
													global::System.Text.RegularExpressions.Regex regex;
													if (regex.IsMatch(text3))
													{
														num = (short)55181315;
														num2 = (int)((global::System.IntPtr)num);
														continue;
													}
													goto IL_522;
												}
												case 9:
													goto IL_3D2;
												case 10:
													goto IL_4A0;
												case 11:
												{
													string[] array;
													if (num5 >= array.Length)
													{
														num = (short)1739522050;
														num2 = (int)((global::System.IntPtr)num);
														continue;
													}
													string text3 = array[num5];
													num = (short)708509704;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												case 12:
												{
													global::System.Text.RegularExpressions.Regex regex = new global::System.Text.RegularExpressions.Regex(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("쒙첛ﾝ풟쪡ﾣ隥薧鎩蒭钯", a_), global::System.Text.RegularExpressions.RegexOptions.IgnoreCase);
													string[] array = valueNames;
													num5 = 0;
													num = (short)512950282;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												case 13:
													goto IL_55E;
												}
												goto IL_281;
												IL_3D2:
												num = (short)524681222;
												num2 = (int)((global::System.IntPtr)num);
												continue;
												IL_4A0:
												num = (short)833028107;
												num2 = (int)((global::System.IntPtr)num);
												continue;
												IL_522:
												num5++;
												num = (short)986513412;
												num2 = (int)((global::System.IntPtr)num);
												continue;
												IL_546:
												num = (short)1331625997;
												num2 = (int)((global::System.IntPtr)num);
											}
											IL_55E:
											goto IL_1ED;
											IL_281:
											pcrfirmwareCodeplugPairPackageFileInfo = new global::Motorola.CommonCPS.Server.EntityModel.GenericModel.PCRFirmwareCodeplugPairPackageFileInfo();
											string text2;
											pcrfirmwareCodeplugPairPackageFileInfo.GUID = text2;
											registryKey2 = registryKey.OpenSubKey(text2);
											valueNames = registryKey2.GetValueNames();
											pcrfirmwareCodeplugPairPackageFileInfo.Title = registryKey2.GetValue(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("캙첟잡", a_)).ToString();
											pcrfirmwareCodeplugPairPackageFileInfo.Type = registryKey2.GetValue(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("캙얟", a_)).ToString();
											pcrfirmwareCodeplugPairPackageFileInfo.Region = registryKey2.GetValue(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("좙鍊劣즟춡쪣", a_)).ToString();
											list = new global::System.Collections.Generic.List<string>();
											num = (short)1123287041;
											num2 = (int)((global::System.IntPtr)num);
											goto IL_242;
										}
										catch (global::System.Exception e)
										{
											global::Motorola.Common.LogUtility.LogManager.GetLogger(global::Motorola.CommonCPS.RadioManagement.CommonBase.LoggerName.RMCLoggerName).Error(e, global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("\udd99鍊솧\ud8a9솫\ud9ad톯삱톳ﾵ횷즹좻\udfbd겿껁跃ꣅ껇ꗉ뿋뗏ꃑꛓ맕꫗", a_));
											goto IL_1ED;
										}
										goto IL_589;
										IL_1ED:
										num4++;
										num = (short)260505601;
										if (num != 0)
										{
										}
										num = (short)699727875;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 6:
										num = (short)416350215;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 7:
										goto IL_5C8;
									}
									break;
									IL_179:
									num = (short)429064193;
									num2 = (int)((global::System.IntPtr)num);
									continue;
									IL_589:
									subKeyNames = registryKey.GetSubKeyNames();
									num4 = 0;
									num = (short)430112770;
									num2 = (int)((global::System.IntPtr)num);
								}
								IL_EF:
								registryKey = registryKey.OpenSubKey(text);
								num = (short)1461125120;
								num2 = (int)((global::System.IntPtr)num);
								goto IL_C8;
							}
							IL_177:
							throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("캙ﮝ튟잡蒣쾥\udba7誩슫솭邯슱햳햵펷\udbb9\udbbb\udbbdꯁ꫃뗅볇ꯉꃋꋍ뗏뛑䀘", a_));
							IL_5C8:
							return list2;
						}
						catch
						{
							throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("캙ﮝ튟잡蒣쾥\udba7誩슫솭邯펱슳ힵ톷횹\uddbb\udcbd겿ꟁ뛅꧇꧉Ɤ꿍럏럑뿕뛗꧙꣛뿝賟軡臣若웧", a_));
						}
						goto IL_5E2;
					case 3:
						text = string.Format(global::System.Globalization.CultureInfo.InvariantCulture, text, global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("욙쮛힟钡那閥骧쎫쪭햯", a_));
						num = (short)1109524480;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						goto IL_5E2;
					}
					goto IL_4B;
					IL_5E2:
					registryKey = global::Microsoft.Win32.Registry.LocalMachine;
					num = (short)132644866;
					num2 = (int)((global::System.IntPtr)num);
				}
				return list2;
				IL_4B:
				list2 = new global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.GenericModel.PCRFirmwareCodeplugPairPackageFileInfo>();
				text = global::Motorola.CommonCPS.RadioManagement.SharedServices.ConfigurationRegistryAndSetting.STRREGPATHPACKAGES;
				num = (short)1211039744;
				short num6 = num;
				num = (short)630063105;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_30;
			}
			}
		}

		// Token: 0x06000A82 RID: 2690 RVA: 0x00080428 File Offset: 0x0007E628
		// Note: this type is marked as 'beforefieldinit'.
		static ConfigurationRegistryAndSetting()
		{
			int a_ = 4;
			short num = (short)1730197433;
			short num2 = num;
			num = (short)755152825;
			switch (num2 == num)
			{
			}
			num = (short)1211105280;
			if (num != 0)
			{
			}
			num = (short)270204928;
			short num3 = num;
			num = (short)237305857;
			if (num != 0)
			{
			}
			global::Motorola.CommonCPS.RadioManagement.SharedServices.ConfigurationRegistryAndSetting.AES_KEYPASSWORD_REGION = global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("즚ﺠ膤銦誨", a_);
			global::Motorola.CommonCPS.RadioManagement.SharedServices.ConfigurationRegistryAndSetting.AES_KEYSALT_REGION = global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("즚ﺠ鮨", a_);
			global::Motorola.CommonCPS.RadioManagement.SharedServices.ConfigurationRegistryAndSetting.STRREGPATHPACKAGES = global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("좚튜\ud99e킪鶬튮ﺲ\udab4쎶횸즺튼펾ꃀ鿂裄裆鷈蓊駌鷎鏐鳒铖觘裚臜连胠胢軤蛦軨軪黬", a_);
		}

		// Token: 0x04000183 RID: 387
		internal const string STRREGNAMETITLE = "Title";

		// Token: 0x04000184 RID: 388
		internal const string STRREGNAMETYPE = "Type";

		// Token: 0x04000185 RID: 389
		internal const string STRREGNAMEREGION = "Region";

		// Token: 0x04000186 RID: 390
		internal const string STRREGNAMEPATH = "Path";

		// Token: 0x04000187 RID: 391
		internal const string STRREGNAMERDATE = "ReleaseQuarter";

		// Token: 0x04000188 RID: 392
		internal static readonly string AES_KEYPASSWORD_REGION;

		// Token: 0x04000189 RID: 393
		internal static readonly string AES_KEYSALT_REGION;

		// Token: 0x0400018A RID: 394
		internal static string STRREGPATHPACKAGES;
	}
}
