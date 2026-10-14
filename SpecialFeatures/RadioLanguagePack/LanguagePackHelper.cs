using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using System.Xml;
using AcpBusinessLayer;
using AcpCommonLib;
using CommonResources;
using CommonUtility;
using ConstraintHelper;
using Motorola.Common.Communication.Pba;
using Motorola.CommonCPS.RadioManagement.SharedServices;
using Motorola.CommonCPS.Server.CommonDBConstants;
using Motorola.CommonCPS.Server.EntityModel;
using Motorola.MackinawCPS.CoreFeatures.DisplayAndMenu;
using Motorola.MackinawCPS.CoreFeatures.RadioInformation;
using SpecialFeatures.AcpReportManagerLib;

namespace SpecialFeatures.RadioLanguagePack
{
	// Token: 0x020000BB RID: 187
	public static class LanguagePackHelper
	{
		// Token: 0x17000451 RID: 1105
		// (get) Token: 0x06000C17 RID: 3095 RVA: 0x000F72CC File Offset: 0x000F54CC
		// (set) Token: 0x06000C18 RID: 3096 RVA: 0x000F737C File Offset: 0x000F557C
		public static int UpgradRadioLangSetting
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)38207488;
				short num2 = num;
				num = (short)1410916260;
				short num3 = num;
				num = (short)1939333028;
				switch (num3 == num)
				{
				}
				num = (short)1301610497;
				if (num != 0)
				{
				}
				num = (short)1832124416;
				if (num != 0)
				{
				}
				return global::SpecialFeatures.RadioLanguagePack.LanguagePackHelper.b;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)241238016;
				short num2 = num;
				num = (short)1559338830;
				short num3 = num;
				num = (short)738107214;
				switch (num3 == num)
				{
				}
				num = (short)299302912;
				if (num != 0)
				{
				}
				num = (short)1450508289;
				if (num != 0)
				{
				}
				global::SpecialFeatures.RadioLanguagePack.LanguagePackHelper.b = value;
			}
		}

		// Token: 0x17000452 RID: 1106
		// (get) Token: 0x06000C19 RID: 3097 RVA: 0x000F742C File Offset: 0x000F562C
		// (set) Token: 0x06000C1A RID: 3098 RVA: 0x000F74DC File Offset: 0x000F56DC
		public static string warningOTAPMessage
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1197604864;
				short num2 = num;
				num = (short)1013966155;
				short num3 = num;
				num = (short)776856907;
				switch (num3 == num)
				{
				}
				num = (short)1063321601;
				if (num != 0)
				{
				}
				num = (short)2032926720;
				if (num != 0)
				{
				}
				return global::SpecialFeatures.RadioLanguagePack.LanguagePackHelper.d;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1394081792;
				short num2 = num;
				num = (short)305659905;
				if (num != 0)
				{
				}
				num = (short)1961921665;
				short num3 = num;
				num = (short)124357761;
				switch (num3 == num)
				{
				}
				num = (short)703528960;
				if (num != 0)
				{
				}
				global::SpecialFeatures.RadioLanguagePack.LanguagePackHelper.d = value;
			}
		}

		// Token: 0x17000453 RID: 1107
		// (get) Token: 0x06000C1B RID: 3099 RVA: 0x000F758C File Offset: 0x000F578C
		internal static global::System.Collections.Generic.Dictionary<int, global::Motorola.CommonCPS.Server.EntityModel.ASTROLanguagePack> LanguageMappingTable
		{
			get
			{
				short num = (short)1820327936;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
					{
						num = (short)957672175;
						short num3 = num;
						num = (short)2146495215;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							num = (short)94371840;
							if (num != 0)
							{
							}
							switch (0)
							{
							case 0:
								goto IL_7D;
							}
							continue;
						}
						break;
					}
					case 1:
						goto IL_10E;
					case 2:
					{
						num = (short)803799041;
						if (num != 0)
						{
						}
						num = (short)417398784;
						short num4 = num;
						global::SpecialFeatures.RadioLanguagePack.LanguagePackHelper.e = new global::System.Collections.Generic.Dictionary<int, global::Motorola.CommonCPS.Server.EntityModel.ASTROLanguagePack>();
						num = (short)374734849;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					IL_7D:
					if (global::SpecialFeatures.RadioLanguagePack.LanguagePackHelper.e != null)
					{
						break;
					}
					num = (short)1113260034;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_10E:
				return global::SpecialFeatures.RadioLanguagePack.LanguagePackHelper.e;
			}
		}

		// Token: 0x06000C1C RID: 3100 RVA: 0x000F76B0 File Offset: 0x000F58B0
		static LanguagePackHelper()
		{
			int a_ = 2;
			short num = (short)1090650112;
			short num2 = num;
			num = (short)1032594711;
			short num3 = num;
			num = (short)1519199511;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
				num = (short)1839529985;
				if (num != 0)
				{
				}
				num = (short)2042363904;
				if (num != 0)
				{
				}
				global::SpecialFeatures.RadioLanguagePack.LanguagePackHelper.c = global::CommonResources.AppResources.LP_One_or_more_files_in_the_RadioLanguagePacks_is_missing + global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("辄", a_) + global::CommonResources.AppResources.LP_Please_see_CPS_Help_topic;
				try
				{
					global::SpecialFeatures.RadioLanguagePack.LanguagePackHelper.LanguagePackFolderPath = global::System.IO.Path.Combine(global::System.IO.Path.GetDirectoryName(global::System.Reflection.Assembly.GetExecutingAssembly().Location), global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("힄쎎ﶒﲚ쾞삠삢캤풦", a_));
				}
				catch
				{
					global::SpecialFeatures.RadioLanguagePack.LanguagePackHelper.LanguagePackFolderPath = string.Empty;
				}
				break;
			}
		}

		// Token: 0x06000C1D RID: 3101 RVA: 0x000F77D0 File Offset: 0x000F59D0
		public static void BindingLanguageSections()
		{
			short num = (short)1635844096;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_BF;
				}
				global::System.Collections.Generic.List<string> list2;
				for (;;)
				{
					IL_27:
					num = (short)744755833;
					short num3 = num;
					num = (short)1686508153;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_BF;
					default:
					{
						num = (short)1586954240;
						short num4 = num;
						num = (short)1781596160;
						if (num != 0)
						{
						}
						global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.ListItem> enumerator;
						switch (num2)
						{
						case 0:
						{
							if (!global::SpecialFeatures.RadioLanguagePack.LanguagePackHelper.IsNeedBindingServerLanguagePack((global::AcpCommonLib.FeatureManager.GetFeature(2049)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation).General.RadInfoGeneralFirmwareVersion_A8124_UIValue))
							{
								num = (short)1803747329;
								if (num != 0)
								{
								}
								num = (short)2123431937;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.ASTROLanguagePack> list = global::SpecialFeatures.RadioLanguagePack.LanguagePackHelper.a();
							num = (short)1139212292;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 1:
							return;
						case 2:
							goto IL_540;
						case 3:
						{
							try
							{
								num = (short)1754726400;
								num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									switch (num2)
									{
									case 0:
										switch (0)
										{
										case 0:
											goto IL_3E7;
										}
										continue;
									case 1:
									{
										global::AcpBusinessLayer.ListItem listItem;
										if (listItem.ItemName == global::CommonResources.AcgResources.ID_ENGLISH)
										{
											num = (short)641073154;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										listItem.ItemVisibility = false;
										num = (short)400031750;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 2:
									{
										global::AcpBusinessLayer.ListItem listItem;
										listItem.ItemVisibility = true;
										num = (short)1121058821;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 3:
										goto IL_4CE;
									case 4:
										num = (short)853934083;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 7:
									{
										if (!enumerator.MoveNext())
										{
											num = (short)1181089796;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										global::AcpBusinessLayer.ListItem listItem = enumerator.Current;
										num = (short)887160833;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									}
									IL_455:
									num = (short)1717698567;
									num2 = (int)((global::System.IntPtr)num);
									continue;
									IL_3E7:
									goto IL_455;
								}
								IL_4CE:
								goto IL_355;
							}
							finally
							{
								num = (short)1273626624;
								num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									switch (num2)
									{
									case 0:
										switch (0)
										{
										case 0:
											goto IL_505;
										}
										continue;
									case 1:
										goto IL_53D;
									case 2:
										enumerator.Dispose();
										num = (short)1392967681;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									IL_505:
									if (enumerator == null)
									{
										break;
									}
									num = (short)1333723138;
									num2 = (int)((global::System.IntPtr)num);
								}
								IL_53D:;
							}
							goto Block_5;
							IL_355:
							global::System.Collections.Generic.List<string>.Enumerator enumerator2 = list2.GetEnumerator();
							num = (short)2081751045;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 4:
						{
							global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.ASTROLanguagePack> list;
							if (list != null)
							{
								num = (short)2049703942;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_157;
						}
						case 5:
							goto IL_376;
						case 6:
						{
							global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.ASTROLanguagePack> list;
							global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.ASTROLanguagePack>.Enumerator enumerator3 = list.GetEnumerator();
							num = (short)1387134978;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						goto IL_BF;
						IL_157:
						global::Motorola.MackinawCPS.CoreFeatures.DisplayAndMenu.DisplayAndMenu displayAndMenu = global::AcpCommonLib.FeatureManager.GetFeature(2010)[0] as global::Motorola.MackinawCPS.CoreFeatures.DisplayAndMenu.DisplayAndMenu;
						enumerator = displayAndMenu.Advanced.DispMenuAdvancedLanguageSelection_A8386.Items.GetEnumerator();
						num = (short)703135747;
						num2 = (int)((global::System.IntPtr)num);
						break;
						Block_5:
						try
						{
							IL_540:
							num = (short)356253696;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_57A;
									}
									continue;
								case 1:
									goto IL_614;
								case 3:
									num = (short)1602093057;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 4:
								{
									global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.ASTROLanguagePack>.Enumerator enumerator3;
									if (!enumerator3.MoveNext())
									{
										num = (short)1828323331;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Motorola.CommonCPS.Server.EntityModel.ASTROLanguagePack astrolanguagePack = enumerator3.Current;
									list2.Add(astrolanguagePack.LpID);
									global::SpecialFeatures.RadioLanguagePack.LanguagePackHelper.e.Add(global::SpecialFeatures.RadioLanguagePack.LanguagePackHelper.b(astrolanguagePack.LpID), astrolanguagePack);
									num = (short)1390739458;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								}
								IL_5C2:
								num = (short)1100218372;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_57A:
								goto IL_5C2;
							}
							IL_614:
							goto IL_157;
						}
						finally
						{
							global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.ASTROLanguagePack>.Enumerator enumerator3;
							((global::System.IDisposable)enumerator3).Dispose();
						}
						return;
					}
					}
				}
				return;
				IL_376:
				try
				{
					num = (short)489947136;
					num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
							switch (0)
							{
							case 0:
								goto IL_224;
							}
							continue;
						case 2:
							goto IL_341;
						case 3:
						{
							global::AcpBusinessLayer.ListItem listItem2;
							if (listItem2 != null)
							{
								num = (short)62783492;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 4:
						{
							global::AcpBusinessLayer.ListItem listItem2;
							listItem2.ItemVisibility = true;
							num = (short)874643457;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 5:
							num = (short)1632108546;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 6:
						{
							global::System.Collections.Generic.List<string>.Enumerator enumerator2;
							if (!enumerator2.MoveNext())
							{
								num = (short)1660354565;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							string a_ = enumerator2.Current;
							int num5 = global::SpecialFeatures.RadioLanguagePack.LanguagePackHelper.b(a_);
							global::Motorola.MackinawCPS.CoreFeatures.DisplayAndMenu.DisplayAndMenu displayAndMenu;
							object strLanguage = displayAndMenu.Advanced.DispMenuAdvancedLanguageSelection_A8386.Converter.Convert(num5, null, null, null);
							global::AcpBusinessLayer.ListItem listItem2 = displayAndMenu.Advanced.DispMenuAdvancedLanguageSelection_A8386.Items.Where(delegate(global::AcpBusinessLayer.ListItem p)
							{
								short num6 = (short)1434820964;
								short num7 = num6;
								num6 = (short)299934052;
								switch (num7 == num6)
								{
								}
								num6 = (short)351272960;
								short num8 = num6;
								num6 = (short)194904065;
								if (num6 != 0)
								{
								}
								num6 = (short)1874526208;
								if (num6 != 0)
								{
								}
								return p.ItemName == strLanguage.ToString();
							}).FirstOrDefault<global::AcpBusinessLayer.ListItem>();
							num = (short)736755715;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						IL_2E8:
						num = (short)2029846534;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_224:
						goto IL_2E8;
					}
					IL_341:
					return;
				}
				finally
				{
					global::System.Collections.Generic.List<string>.Enumerator enumerator2;
					((global::System.IDisposable)enumerator2).Dispose();
				}
				return;
				IL_BF:
				list2 = new global::System.Collections.Generic.List<string>();
				global::SpecialFeatures.RadioLanguagePack.LanguagePackHelper.e = new global::System.Collections.Generic.Dictionary<int, global::Motorola.CommonCPS.Server.EntityModel.ASTROLanguagePack>();
				num = (short)877264896;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x06000C1E RID: 3102 RVA: 0x000F7E50 File Offset: 0x000F6050
		private static global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.ASTROLanguagePack> a()
		{
			int a_ = 3;
			short num = (short)1839595520;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				for (;;)
				{
					num = (short)300089345;
					if (num != 0)
					{
					}
					switch (0)
					{
					case 0:
						goto IL_73;
					}
					string radInfoGeneralFirmwareVersion_A8124_UIValue;
					for (;;)
					{
						IL_58:
						switch (num2)
						{
						case 0:
							goto IL_F0;
						case 1:
						{
							if (!new global::System.Text.RegularExpressions.Regex(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("꺅풇Ꞌ튍뺏캑붕쒗뒙삛瞧讟计", a_)).Match(radInfoGeneralFirmwareVersion_A8124_UIValue).Success)
							{
								num = (short)715456512;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.ASTROLanguagePack> list = new global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.ASTROLanguagePack>();
							global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.ASTROPackage> astropackagesByCompatibleVersion = global::Motorola.CommonCPS.RadioManagement.SharedServices.RMCExportInterface.GetInstance().GetASTROPackagesByCompatibleVersion(global::Motorola.CommonCPS.Server.CommonDBConstants.PackageType.LanguagePack, radInfoGeneralFirmwareVersion_A8124_UIValue);
							num = (short)1250361347;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 2:
							goto IL_5E3;
						case 3:
						{
							global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.ASTROPackage> astropackagesByCompatibleVersion;
							if (astropackagesByCompatibleVersion == null)
							{
								num = (short)1587412994;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							string empty = string.Empty;
							global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.ASTROPackage>.Enumerator enumerator = astropackagesByCompatibleVersion.GetEnumerator();
							num = (short)227672068;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 4:
							goto IL_610;
						}
						goto IL_73;
					}
					IL_F0:
					num = (short)939804609;
					short num3 = num;
					num = (short)761415617;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						continue;
					case 1:
						goto IL_586;
					}
					goto Block_3;
					IL_73:
					global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation radioInformation = global::AcpCommonLib.FeatureManager.GetFeature(2049)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation;
					string astroLanugagePackID = global::SpecialFeatures.RadioLanguagePack.LanguagePackHelper.GetAstroLanugagePackID(global::SpecialFeatures.RadioLanguagePack.LanguagePackHelper.GetCodeplugLanguageIndex());
					radInfoGeneralFirmwareVersion_A8124_UIValue = radioInformation.General.RadInfoGeneralFirmwareVersion_A8124_UIValue;
					num = (short)175112193;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_58;
				}
				IL_527:
				return null;
				Block_3:
				num = (short)1505034240;
				short num4 = num;
				IL_586:
				num = (short)180486144;
				if (num != 0)
				{
				}
				return null;
				IL_5E3:
				goto IL_527;
				IL_610:
				try
				{
					num = (short)1070399503;
					num2 = (int)((global::System.IntPtr)num);
					global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.ASTROLanguagePack> list;
					for (;;)
					{
						global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.ASTROPackage>.Enumerator enumerator;
						global::Motorola.CommonCPS.Server.EntityModel.ASTROLanguagePack astrolanguagePack2;
						switch (num2)
						{
						case 0:
							num = (short)842465283;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
						{
							global::Motorola.CommonCPS.Server.EntityModel.ASTROLanguagePack astrolanguagePack;
							if (astrolanguagePack == null)
							{
								num = (short)761462793;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 3:
							goto IL_514;
						case 4:
							num = (short)1044316168;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 5:
						{
							global::Motorola.CommonCPS.Server.EntityModel.ASTROLanguagePack astrolanguagePack = null;
							global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.ASTROLanguagePack>.Enumerator enumerator2 = list.GetEnumerator();
							num = (short)1287520267;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 6:
						{
							string radInfoGeneralFirmwareVersion_A8124_UIValue;
							string empty;
							if (global::SpecialFeatures.RadioLanguagePack.LanguagePackHelper.IsFirmwareLPCompatible(radInfoGeneralFirmwareVersion_A8124_UIValue, ref empty, global::SpecialFeatures.RadioLanguagePack.LanguagePackHelper.b(astrolanguagePack2.LpID), global::ConstraintHelper.UtilityMack.IsPortablePro))
							{
								num = (short)568066053;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 7:
							if (!enumerator.MoveNext())
							{
								num = (short)1854013440;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_3B5;
						case 8:
						{
							global::Motorola.CommonCPS.Server.EntityModel.ASTROLanguagePack astrolanguagePack;
							if (string.Compare(astrolanguagePack.PackageVersion, astrolanguagePack2.PackageVersion) < 0)
							{
								num = (short)81068050;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_21D;
						}
						case 9:
							list.Add(astrolanguagePack2);
							num = (short)1497300993;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 10:
						{
							global::Motorola.CommonCPS.Server.EntityModel.ASTROLanguagePack astrolanguagePack;
							if (astrolanguagePack != null)
							{
								num = (short)1408040964;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_21D;
						}
						case 11:
							try
							{
								num = (short)1022033923;
								num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									switch (num2)
									{
									case 0:
									{
										global::Motorola.CommonCPS.Server.EntityModel.ASTROLanguagePack astrolanguagePack3;
										if (string.Equals(astrolanguagePack3.LpID, astrolanguagePack2.LpID, global::System.StringComparison.CurrentCultureIgnoreCase))
										{
											num = (short)1380253701;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										break;
									}
									case 1:
										goto IL_2FA;
									case 2:
										num = (short)2010906630;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 3:
										switch (0)
										{
										case 0:
											goto IL_2DE;
										}
										continue;
									case 4:
									{
										global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.ASTROLanguagePack>.Enumerator enumerator2;
										if (!enumerator2.MoveNext())
										{
											num = (short)1941307394;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										global::Motorola.CommonCPS.Server.EntityModel.ASTROLanguagePack astrolanguagePack3 = enumerator2.Current;
										num = (short)1980760064;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 5:
									{
										global::Motorola.CommonCPS.Server.EntityModel.ASTROLanguagePack astrolanguagePack3;
										global::Motorola.CommonCPS.Server.EntityModel.ASTROLanguagePack astrolanguagePack = astrolanguagePack3;
										num = (short)191037441;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 6:
										goto IL_3A2;
									}
									IL_34D:
									num = (short)783024132;
									num2 = (int)((global::System.IntPtr)num);
									continue;
									IL_2DE:
									goto IL_34D;
								}
								IL_2FA:
								IL_3A2:
								goto IL_191;
							}
							finally
							{
								global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.ASTROLanguagePack>.Enumerator enumerator2;
								((global::System.IDisposable)enumerator2).Dispose();
							}
							goto IL_3B5;
							IL_191:
							num = (short)1581383690;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 12:
						{
							string astroLanugagePackID;
							if (astroLanugagePackID != astrolanguagePack2.LpID)
							{
								num = (short)1000144913;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_1CA;
						}
						case 13:
						{
							global::System.Guid? fileUuid;
							if (fileUuid != null)
							{
								num = (short)2108686352;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 15:
							switch (0)
							{
							case 0:
								goto IL_168;
							}
							continue;
						case 16:
							goto IL_1CA;
						case 17:
						{
							global::System.Guid? fileUuid = astrolanguagePack2.FileUuid;
							num = (short)1747320845;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 18:
						{
							global::Motorola.CommonCPS.Server.EntityModel.ASTROLanguagePack astrolanguagePack;
							list.Remove(astrolanguagePack);
							list.Add(astrolanguagePack2);
							num = (short)592904206;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						goto IL_168;
						IL_1CA:
						num = (short)180289542;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_21D:
						num = (short)1642594306;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_257:
						num = (short)92864519;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_168:
						goto IL_257;
						IL_3B5:
						astrolanguagePack2 = (enumerator.Current as global::Motorola.CommonCPS.Server.EntityModel.ASTROLanguagePack);
						num = (short)400883724;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_514:
					return list;
				}
				finally
				{
					global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.ASTROPackage>.Enumerator enumerator;
					((global::System.IDisposable)enumerator).Dispose();
				}
				goto IL_527;
			}
			}
		}

		// Token: 0x06000C1F RID: 3103 RVA: 0x000F84A8 File Offset: 0x000F66A8
		public static void UpdateLanguageRefence(global::Motorola.CommonCPS.Server.EntityModel.APXTemplate template)
		{
			short num = (short)150667264;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_68;
				}
				int codeplugLanguageIndex;
				global::Motorola.CommonCPS.Server.EntityModel.ASTROLanguagePack astrolanguagePack;
				for (;;)
				{
					IL_29:
					switch (num2)
					{
					case 0:
						num = (short)2102722561;
						if (num != 0)
						{
						}
						if (!global::SpecialFeatures.RadioLanguagePack.LanguagePackHelper.IsNeedBindingServerLanguagePack((global::AcpCommonLib.FeatureManager.GetFeature(2049)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation).General.RadInfoGeneralFirmwareVersion_A8124_UIValue))
						{
							num = (short)1800929284;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						(global::AcpCommonLib.FeatureManager.GetFeature(2010)[0] as global::Motorola.MackinawCPS.CoreFeatures.DisplayAndMenu.DisplayAndMenu).Advanced.DispMenuAdvancedLanguageSelection_A8386Value = 0;
						template.LanguageIndex = new int?(0);
						num = (short)1118240779;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						if (global::SpecialFeatures.RadioLanguagePack.LanguagePackHelper.LanguageMappingTable.TryGetValue(codeplugLanguageIndex, out astrolanguagePack))
						{
							num = (short)348717059;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)713162752;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						if (codeplugLanguageIndex == 0)
						{
							num = (short)1880293388;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_303;
					case 3:
						goto IL_173;
					case 4:
					{
						global::Motorola.MackinawCPS.CoreFeatures.DisplayAndMenu.DisplayAndMenu displayAndMenu = global::AcpCommonLib.FeatureManager.GetFeature(2010)[0] as global::Motorola.MackinawCPS.CoreFeatures.DisplayAndMenu.DisplayAndMenu;
						template.LanguageIndex = new int?(displayAndMenu.Advanced.DispMenuAdvancedLanguageSelection_A8386Value);
						num = (short)1495531527;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 5:
					{
						num = (short)2033647616;
						short num3 = num;
						num = (short)531431426;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 6:
						return;
					case 7:
						goto IL_1BF;
					case 8:
						if (template.ASTROLanguagePack != null)
						{
							num = (short)898695181;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_130;
					case 9:
						if (codeplugLanguageIndex == global::SpecialFeatures.RadioLanguagePack.LanguagePackHelper.b(template.ASTROLanguagePack.LpID))
						{
							goto IL_2E6;
						}
						goto IL_130;
					case 10:
						if (template.ASTROLanguagePack == null)
						{
							num = (short)1644232709;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_303;
					case 11:
						goto IL_2B3;
					case 12:
						return;
					case 13:
						num = (short)1143472137;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_68;
					IL_130:
					num = (short)1294467073;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2E6:
					num = (short)1876623366;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_303:
					num = (short)1149129916;
					short num4 = num;
					num = (short)1392661692;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_2E6;
					default:
						num = (short)614596608;
						if (num != 0)
						{
						}
						num = (short)1744568328;
						num2 = (int)((global::System.IntPtr)num);
						break;
					}
				}
				IL_173:
				template.ASTROLanguagePack = astrolanguagePack;
				global::Motorola.MackinawCPS.CoreFeatures.DisplayAndMenu.DisplayAndMenu displayAndMenu2 = global::AcpCommonLib.FeatureManager.GetFeature(2010)[0] as global::Motorola.MackinawCPS.CoreFeatures.DisplayAndMenu.DisplayAndMenu;
				template.LanguageIndex = new int?(displayAndMenu2.Advanced.DispMenuAdvancedLanguageSelection_A8386Value);
				template.LanguagePackUuid = new global::System.Guid?(astrolanguagePack.Uuid);
				return;
				IL_1BF:
				IL_2B3:
				template.ASTROLanguagePack = null;
				template.LanguagePackUuid = null;
				return;
				IL_68:
				codeplugLanguageIndex = global::SpecialFeatures.RadioLanguagePack.LanguagePackHelper.GetCodeplugLanguageIndex();
				num = (short)2102001674;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_29;
			}
			}
		}

		// Token: 0x06000C20 RID: 3104 RVA: 0x000F885C File Offset: 0x000F6A5C
		public static bool IsNeedBindingServerLanguagePack(string firmwareVersion)
		{
			int a_ = 9;
			short num = (short)2051342348;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				num = (short)1086827592;
				short num3 = num;
				num = (short)1696115784;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)1140654080;
					if (num != 0)
					{
					}
					num = (short)787611648;
					short num4 = num;
					short num5;
					switch (num2)
					{
					case 0:
						return true;
					case 1:
						if (!firmwareVersion.StartsWith(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("캋", a_)))
						{
							num = (short)1778450445;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_23C;
					case 2:
						goto IL_23C;
					case 3:
						if (num5 < 8)
						{
							num = (short)1795358730;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return true;
					case 4:
						if (firmwareVersion.StartsWith(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쾋", a_)))
						{
							num = (short)512360450;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 5:
						if (firmwareVersion.StartsWith(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\ude8b", a_)))
						{
							goto IL_21C;
						}
						goto IL_274;
					case 6:
						num = (short)1142292481;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
						if (num5 < 7)
						{
							num = (short)1661075467;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return true;
					case 8:
						num = (short)1901330435;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 9:
						if (!firmwareVersion.StartsWith(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("좋", a_)))
						{
							num = (short)651821062;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_23C;
					case 10:
						goto IL_274;
					case 11:
						goto IL_272;
					case 12:
						switch (0)
						{
						case 0:
							goto IL_D9;
						}
						continue;
					case 13:
						num = (short)893517825;
						if (num != 0)
						{
						}
						num = (short)1936523268;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_D9:
					if (!new global::System.Text.RegularExpressions.Regex(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("ꒋ튍릑좓뢕쒗ﺙ랛슝躟ﺡ삣趥膧", a_)).Match(firmwareVersion).Success)
					{
						num = (short)852164608;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num5 = global::System.Convert.ToInt16(firmwareVersion.Substring(1, 2), 10);
					num = (short)1843134469;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_23C:
					num = (short)865337351;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_274:
					num = (short)1155792905;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				}
				IL_21C:
				num = (short)1360592904;
				num2 = (int)((global::System.IntPtr)num);
			}
			return true;
			IL_272:
			return false;
		}

		// Token: 0x06000C21 RID: 3105 RVA: 0x000F8B60 File Offset: 0x000F6D60
		public static bool IsFirmwareLPCompatible(string hostVersion, ref string stat, int codeplugLanguageIndx, bool IsPortable)
		{
			int a_ = 12;
			switch (0)
			{
			case 0:
				goto IL_265;
			}
			int num;
			short num2;
			short num3;
			for (;;)
			{
				IL_13:
				switch (num)
				{
				case 0:
					if (num2 < 8)
					{
						num3 = (short)1337852024;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					return true;
				case 1:
					num3 = (short)1336279044;
					num = (int)((global::System.IntPtr)num3);
					continue;
				case 2:
					if (num2 < 7)
					{
						num3 = (short)684589082;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					return true;
				case 3:
					if (codeplugLanguageIndx != 5)
					{
						num3 = (short)1825964042;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					goto IL_1129;
				case 4:
					if (!hostVersion.StartsWith(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("춎", a_)))
					{
						num3 = (short)2089222231;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					goto IL_5A5;
				case 5:
					if (!hostVersion.StartsWith(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("춎", a_)))
					{
						num3 = (short)995295317;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					goto IL_74B;
				case 6:
					num3 = (short)445644942;
					num = (int)((global::System.IntPtr)num3);
					continue;
				case 7:
					if (hostVersion.StartsWith(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("첎", a_)))
					{
						num3 = (short)1484718175;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					goto IL_12D1;
				case 8:
					goto IL_148B;
				case 9:
					if (codeplugLanguageIndx != 1)
					{
						num3 = (short)196345965;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					goto IL_1129;
				case 10:
					num3 = (short)90964013;
					num = (int)((global::System.IntPtr)num3);
					continue;
				case 11:
					goto IL_10B8;
				case 12:
					if (hostVersion.StartsWith(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udd8e", a_)))
					{
						num3 = (short)1887043604;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					goto IL_14FC;
				case 13:
					if (codeplugLanguageIndx != 6)
					{
						num3 = (short)1280180343;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					goto IL_13A7;
				case 14:
					if (!hostVersion.StartsWith(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쮎", a_)))
					{
						num3 = (short)1226375203;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					goto IL_74B;
				case 15:
					if (num2 == 4)
					{
						num3 = (short)1686306839;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					goto IL_94A;
				case 16:
					goto IL_1405;
				case 17:
					num3 = (short)2064318464;
					num = (int)((global::System.IntPtr)num3);
					continue;
				case 18:
					if (num2 == 6)
					{
						num3 = (short)1343619209;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					return false;
				case 19:
					if (codeplugLanguageIndx == 6)
					{
						num3 = (short)1148846119;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					return false;
				case 20:
					num3 = (short)567345267;
					num = (int)((global::System.IntPtr)num3);
					continue;
				case 21:
					goto IL_1129;
				case 22:
					if (codeplugLanguageIndx == 5)
					{
						num3 = (short)983826497;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					return false;
				case 23:
					goto IL_10F1;
				case 24:
					if (codeplugLanguageIndx != 7)
					{
						num3 = (short)1252130897;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					goto IL_394;
				case 25:
					if (hostVersion.StartsWith(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udd8e", a_)))
					{
						num3 = (short)633405471;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					goto IL_1405;
				case 26:
					goto IL_30C;
				case 27:
					num3 = (short)127533115;
					num = (int)((global::System.IntPtr)num3);
					continue;
				case 28:
					num3 = (short)1151533106;
					num = (int)((global::System.IntPtr)num3);
					continue;
				case 29:
					if (codeplugLanguageIndx != 9)
					{
						num3 = (short)1650589743;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					goto IL_13A7;
				case 30:
					if (hostVersion.StartsWith(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udd8e", a_)))
					{
						num3 = (short)2095972420;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					goto IL_119E;
				case 31:
					num3 = (short)983695454;
					num = (int)((global::System.IntPtr)num3);
					continue;
				case 32:
					goto IL_119E;
				case 33:
					if (codeplugLanguageIndx != 7)
					{
						num3 = (short)1322254425;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					goto IL_13A7;
				case 34:
					num3 = (short)1528102934;
					num = (int)((global::System.IntPtr)num3);
					continue;
				case 35:
					num3 = (short)2021588997;
					num = (int)((global::System.IntPtr)num3);
					continue;
				case 36:
					if (codeplugLanguageIndx != 11)
					{
						num3 = (short)1039532084;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					goto IL_13A7;
				case 37:
					if (codeplugLanguageIndx != 2)
					{
						num3 = (short)1743192207;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					return false;
				case 38:
					num3 = (short)274595954;
					num = (int)((global::System.IntPtr)num3);
					continue;
				case 39:
					goto IL_13E2;
				case 40:
					num3 = (short)428802120;
					num = (int)((global::System.IntPtr)num3);
					continue;
				case 41:
					num3 = (short)1764556801;
					if (num3 != 0)
					{
					}
					stat = global::CommonResources.AppResources.LP_Radio_display_Language_Not_Supported_By_this_radio;
					num3 = (short)737869952;
					num = (int)((global::System.IntPtr)num3);
					continue;
				case 42:
					if (!hostVersion.StartsWith(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쮎", a_)))
					{
						num3 = (short)498335801;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					goto IL_8D6;
				case 43:
					num3 = (short)757727256;
					num = (int)((global::System.IntPtr)num3);
					continue;
				case 44:
					if (codeplugLanguageIndx != 0)
					{
						num3 = (short)898498637;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					goto IL_1129;
				case 45:
					if (codeplugLanguageIndx == 6)
					{
						num3 = (short)1995374613;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					goto IL_13E2;
				case 46:
					if (codeplugLanguageIndx != 2)
					{
						goto IL_1182;
					}
					goto IL_13A7;
				case 47:
					num3 = (short)60358778;
					num = (int)((global::System.IntPtr)num3);
					continue;
				case 48:
					goto IL_90F;
				case 49:
					goto IL_74B;
				case 50:
					if (codeplugLanguageIndx == 5)
					{
						num3 = (short)371589131;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					goto IL_101E;
				case 51:
					try
					{
						num2 = global::System.Convert.ToInt16(hostVersion.Substring(1, 2), 10);
						goto IL_996;
					}
					catch
					{
						stat = global::CommonResources.AppResources.LP_Cannot_Determine_Host_Version;
						return false;
					}
					goto IL_5A5;
					IL_996:
					num3 = (short)515047570;
					num = (int)((global::System.IntPtr)num3);
					continue;
				case 52:
					num3 = (short)656277580;
					num = (int)((global::System.IntPtr)num3);
					continue;
				case 53:
					num3 = (short)859832420;
					num = (int)((global::System.IntPtr)num3);
					continue;
				case 54:
					if (!hostVersion.StartsWith(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쮎", a_)))
					{
						num3 = (short)1831272449;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					goto IL_5A5;
				case 55:
					if (!hostVersion.StartsWith(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쮎", a_)))
					{
						num3 = (short)820445274;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					goto IL_BD2;
				case 56:
					if (codeplugLanguageIndx != 6)
					{
						num3 = (short)607584299;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					goto IL_394;
				case 57:
					num3 = (short)363659333;
					num = (int)((global::System.IntPtr)num3);
					continue;
				case 58:
					if (hostVersion.StartsWith(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udd8e", a_)))
					{
						num3 = (short)669057024;
						short num4 = num3;
						num3 = (short)1786773521;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					goto IL_5E1;
				case 59:
					if (codeplugLanguageIndx != 1)
					{
						num3 = (short)372048017;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					goto IL_13A7;
				case 60:
					if (!IsPortable)
					{
						num3 = (short)217382976;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					return false;
				case 61:
					goto IL_482;
				case 62:
					goto IL_F73;
				case 63:
					if (codeplugLanguageIndx != 5)
					{
						num3 = (short)1964965961;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					goto IL_394;
				case 64:
					num3 = (short)2113011731;
					num = (int)((global::System.IntPtr)num3);
					continue;
				case 65:
					goto IL_101E;
				case 66:
					goto IL_5A5;
				case 67:
					if (!hostVersion.StartsWith(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쮎", a_)))
					{
						num3 = (short)604897384;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					goto IL_482;
				case 68:
					num3 = (short)545063046;
					num = (int)((global::System.IntPtr)num3);
					continue;
				case 69:
					if (!hostVersion.StartsWith(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("춎", a_)))
					{
						num3 = (short)9896022;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					goto IL_8D6;
				case 70:
					goto IL_14FC;
				case 71:
				{
					num3 = (short)347638638;
					short num5 = num3;
					num3 = (short)205818734;
					switch ((num5 == num3) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_1182;
					default:
						goto IL_14E1;
					}
					break;
				}
				case 72:
					if (codeplugLanguageIndx != 1)
					{
						num3 = (short)738984063;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					return false;
				case 73:
					num3 = (short)1494941752;
					num = (int)((global::System.IntPtr)num3);
					continue;
				case 74:
					if (codeplugLanguageIndx != 3)
					{
						num3 = (short)1376714793;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					return false;
				case 75:
					if (!hostVersion.StartsWith(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("춎", a_)))
					{
						num3 = (short)268107905;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					goto IL_482;
				case 76:
					if (codeplugLanguageIndx == 12)
					{
						num3 = (short)1703805020;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					goto IL_148B;
				case 77:
					num3 = (short)183566345;
					num = (int)((global::System.IntPtr)num3);
					continue;
				case 78:
					if (codeplugLanguageIndx != 3)
					{
						num3 = (short)41091125;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					goto IL_13A7;
				case 79:
					num3 = (short)1636761636;
					num = (int)((global::System.IntPtr)num3);
					continue;
				case 80:
					if (hostVersion.StartsWith(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("첎", a_)))
					{
						num3 = (short)1493434434;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					goto IL_30C;
				case 81:
					return true;
				case 82:
					goto IL_1451;
				case 83:
					goto IL_A48;
				case 84:
					num3 = (short)1461649520;
					num = (int)((global::System.IntPtr)num3);
					continue;
				case 85:
					num3 = (short)391905413;
					num = (int)((global::System.IntPtr)num3);
					continue;
				case 86:
					num3 = (short)1507131399;
					num = (int)((global::System.IntPtr)num3);
					continue;
				case 87:
					num3 = (short)203423824;
					num = (int)((global::System.IntPtr)num3);
					continue;
				case 88:
					goto IL_BD2;
				case 89:
					num3 = (short)624164893;
					num = (int)((global::System.IntPtr)num3);
					continue;
				case 90:
					num3 = (short)41943165;
					num = (int)((global::System.IntPtr)num3);
					continue;
				case 91:
					if (codeplugLanguageIndx != 2)
					{
						num3 = (short)1755447302;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					goto IL_1129;
				case 92:
					goto IL_13A7;
				case 93:
					if (codeplugLanguageIndx == 7)
					{
						num3 = (short)1339031560;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					return false;
				case 94:
					if (num2 != 5)
					{
						num3 = (short)1200488464;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					goto IL_10F1;
				case 95:
					goto IL_8D6;
				case 96:
					if (codeplugLanguageIndx != 3)
					{
						num3 = (short)1915289628;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					goto IL_10B8;
				case 97:
					if (!IsPortable)
					{
						num3 = (short)1872232482;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					return false;
				case 98:
					if (num2 < 4)
					{
						num3 = (short)1144062000;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					goto IL_12D1;
				case 99:
					goto IL_1400;
				case 100:
					if (codeplugLanguageIndx != 5)
					{
						num3 = (short)179044484;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					goto IL_13A7;
				case 101:
					if (num2 != 7)
					{
						num3 = (short)492240979;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					goto IL_861;
				case 102:
					if (hostVersion.StartsWith(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("첎", a_)))
					{
						num3 = (short)1528365144;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					return false;
				case 103:
					if (num2 == 5)
					{
						num3 = (short)1330184254;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					goto IL_F24;
				case 104:
					num3 = (short)356319307;
					num = (int)((global::System.IntPtr)num3);
					continue;
				case 105:
					num3 = (short)1528234062;
					num = (int)((global::System.IntPtr)num3);
					continue;
				case 106:
					num3 = (short)1525874795;
					num = (int)((global::System.IntPtr)num3);
					continue;
				case 107:
					if (codeplugLanguageIndx != 2)
					{
						num3 = (short)1360658516;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					goto IL_394;
				case 108:
					num3 = (short)1697972355;
					num = (int)((global::System.IntPtr)num3);
					continue;
				case 109:
					num3 = (short)95158363;
					num = (int)((global::System.IntPtr)num3);
					continue;
				case 110:
					num3 = (short)1606942816;
					num = (int)((global::System.IntPtr)num3);
					continue;
				case 111:
					num3 = (short)1109917822;
					num = (int)((global::System.IntPtr)num3);
					continue;
				case 112:
					if (codeplugLanguageIndx != 3)
					{
						num3 = (short)175767692;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					goto IL_394;
				case 113:
					num3 = (short)1685323877;
					num = (int)((global::System.IntPtr)num3);
					continue;
				case 114:
					if (codeplugLanguageIndx != 5)
					{
						num3 = (short)1870331986;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					goto IL_13E2;
				case 115:
					if (num2 >= 5)
					{
						num3 = (short)1586692166;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					goto IL_90F;
				case 116:
					if (codeplugLanguageIndx != 0)
					{
						num3 = (short)1951006747;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					goto IL_13A7;
				case 117:
					if (!IsPortable)
					{
						num3 = (short)1592066086;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					goto IL_1451;
				case 118:
					if (codeplugLanguageIndx != 1)
					{
						num3 = (short)846069868;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					goto IL_10B8;
				case 119:
					num3 = (short)1433665569;
					num = (int)((global::System.IntPtr)num3);
					continue;
				case 120:
					goto IL_5E1;
				case 121:
					if (hostVersion.StartsWith(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udd8e", a_)))
					{
						num3 = (short)943980657;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					goto IL_A48;
				case 122:
					if (codeplugLanguageIndx != 10)
					{
						num3 = (short)896532559;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					goto IL_13A7;
				case 123:
					num3 = (short)2013528166;
					num = (int)((global::System.IntPtr)num3);
					continue;
				case 124:
					if (codeplugLanguageIndx != 0)
					{
						num3 = (short)1218707496;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					return false;
				case 125:
					if (!hostVersion.StartsWith(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("춎", a_)))
					{
						num3 = (short)1447035003;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					goto IL_BD2;
				case 126:
					if (codeplugLanguageIndx != 1)
					{
						num3 = (short)1294073962;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					goto IL_394;
				case 127:
					num3 = (short)602210341;
					num = (int)((global::System.IntPtr)num3);
					continue;
				case 128:
					goto IL_CED;
				case 129:
					num3 = (short)506986632;
					num = (int)((global::System.IntPtr)num3);
					continue;
				case 130:
					num3 = (short)2042757123;
					num = (int)((global::System.IntPtr)num3);
					continue;
				case 131:
					if (codeplugLanguageIndx != 2)
					{
						num3 = (short)737345646;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					goto IL_10B8;
				case 132:
					num3 = (short)590807053;
					num = (int)((global::System.IntPtr)num3);
					continue;
				case 133:
					if (hostVersion.StartsWith(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("첎", a_)))
					{
						num3 = (short)2102329393;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					goto IL_94A;
				case 134:
					if (num2 != 6)
					{
						num3 = (short)1331429408;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					goto IL_F73;
				case 135:
					num3 = (short)783810653;
					num = (int)((global::System.IntPtr)num3);
					continue;
				case 136:
					if (hostVersion.StartsWith(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("첎", a_)))
					{
						num3 = (short)132841533;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					goto IL_F24;
				case 137:
					goto IL_861;
				case 138:
					if (!IsPortable)
					{
						num3 = (short)450429063;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					return false;
				case 139:
					goto IL_103E;
				case 140:
					num3 = (short)878706751;
					num = (int)((global::System.IntPtr)num3);
					continue;
				case 141:
					if (codeplugLanguageIndx != 0)
					{
						num3 = (short)825950352;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					goto IL_10B8;
				case 142:
					if (codeplugLanguageIndx != 3)
					{
						num3 = (short)997326978;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					goto IL_1129;
				case 143:
					num3 = (short)1964834890;
					num = (int)((global::System.IntPtr)num3);
					continue;
				case 144:
					num3 = (short)1849360502;
					num = (int)((global::System.IntPtr)num3);
					continue;
				case 145:
					num3 = (short)1836580910;
					num = (int)((global::System.IntPtr)num3);
					continue;
				case 146:
					if (codeplugLanguageIndx != 0)
					{
						num3 = (short)1138557039;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					goto IL_394;
				}
				goto IL_265;
				IL_30C:
				num3 = (short)601489420;
				num = (int)((global::System.IntPtr)num3);
				continue;
				IL_394:
				num3 = (short)73334842;
				num = (int)((global::System.IntPtr)num3);
				continue;
				IL_482:
				num3 = (short)755957863;
				num = (int)((global::System.IntPtr)num3);
				continue;
				IL_5A5:
				num3 = (short)1286602754;
				num = (int)((global::System.IntPtr)num3);
				continue;
				IL_5E1:
				num3 = (short)710213686;
				num = (int)((global::System.IntPtr)num3);
				continue;
				IL_74B:
				num3 = (short)2040725519;
				num = (int)((global::System.IntPtr)num3);
				continue;
				IL_861:
				num3 = (short)1552941172;
				num = (int)((global::System.IntPtr)num3);
				continue;
				IL_8D6:
				num3 = (short)1868562530;
				num = (int)((global::System.IntPtr)num3);
				continue;
				IL_90F:
				num3 = (short)776142972;
				num = (int)((global::System.IntPtr)num3);
				continue;
				IL_94A:
				num3 = (short)2048393246;
				num = (int)((global::System.IntPtr)num3);
				continue;
				IL_A48:
				num3 = (short)1243217975;
				num = (int)((global::System.IntPtr)num3);
				continue;
				IL_BD2:
				num3 = (short)385548306;
				num = (int)((global::System.IntPtr)num3);
				continue;
				IL_F24:
				num3 = (short)927531129;
				num = (int)((global::System.IntPtr)num3);
				continue;
				IL_F73:
				num3 = (short)662700076;
				num = (int)((global::System.IntPtr)num3);
				continue;
				IL_101E:
				stat = global::CommonResources.AppResources.LP_Radio_display_Language_Not_Supported_By_this_radio;
				num3 = (short)1406926987;
				num = (int)((global::System.IntPtr)num3);
				continue;
				IL_10B8:
				num3 = (short)10682465;
				num = (int)((global::System.IntPtr)num3);
				continue;
				IL_10F1:
				num3 = (short)1096482957;
				num = (int)((global::System.IntPtr)num3);
				continue;
				IL_1129:
				num3 = (short)1843855477;
				num = (int)((global::System.IntPtr)num3);
				continue;
				IL_1182:
				num3 = (short)1345519721;
				num = (int)((global::System.IntPtr)num3);
				continue;
				IL_119E:
				num3 = (short)1084751939;
				num = (int)((global::System.IntPtr)num3);
				continue;
				IL_12D1:
				num3 = (short)786104345;
				num = (int)((global::System.IntPtr)num3);
				continue;
				IL_13A7:
				num3 = (short)130351242;
				num = (int)((global::System.IntPtr)num3);
				continue;
				IL_13E2:
				stat = global::CommonResources.AppResources.LP_Radio_display_Language_Not_Supported_By_this_radio;
				num3 = (short)2052128867;
				num = (int)((global::System.IntPtr)num3);
				continue;
				IL_1405:
				num3 = (short)950796302;
				num = (int)((global::System.IntPtr)num3);
				continue;
				IL_1451:
				num3 = (short)1668743228;
				num = (int)((global::System.IntPtr)num3);
				continue;
				IL_148B:
				stat = global::CommonResources.AppResources.LP_Radio_display_Language_Not_Supported_By_this_radio;
				num3 = (short)1407909959;
				num = (int)((global::System.IntPtr)num3);
				continue;
				IL_14FC:
				num3 = (short)1013973034;
				num = (int)((global::System.IntPtr)num3);
			}
			return false;
			IL_CED:
			return false;
			IL_103E:
			IL_1400:
			return false;
			IL_14E1:
			num3 = (short)1293287424;
			if (num3 != 0)
			{
			}
			return false;
			IL_265:
			num2 = 0;
			num3 = (short)1130496051;
			num = (int)((global::System.IntPtr)num3);
			goto IL_13;
		}

		// Token: 0x06000C22 RID: 3106 RVA: 0x000FA104 File Offset: 0x000F8304
		public static bool IsFirmwareLPCompatible(string hostVersion, int cpLanguageIndex)
		{
			int a_ = 1;
			short num = (short)1749410339;
			short num2 = num;
			num = (short)1671881251;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)1461714944;
				if (num != 0)
				{
				}
				switch (0)
				{
				case 0:
					goto IL_D0;
				}
				int num3;
				short num4;
				for (;;)
				{
					IL_5E:
					switch (num3)
					{
					case 0:
						if (cpLanguageIndex == 8)
						{
							num = (short)1502740483;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)2039021575;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						if (!hostVersion.StartsWith(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("삃", a_)))
						{
							num = (short)1607794711;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2B4;
					case 2:
						num = (short)799408137;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						num = (short)500498457;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						goto IL_EF;
					case 5:
						if (num4 < 7)
						{
							num = (short)1365508112;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2EB;
					case 6:
						num = (short)2116616218;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
						if (hostVersion.StartsWith(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("횃", a_)))
						{
							num = (short)1234763778;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_EF;
					case 8:
						num = (short)1145110542;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 9:
						if (num4 < 8)
						{
							num = (short)1931083780;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2EB;
					case 10:
						if (!hostVersion.StartsWith(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("욃", a_)))
						{
							num = (short)1387134984;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2B4;
					case 11:
						try
						{
							num4 = global::System.Convert.ToInt16(hostVersion.Substring(1, 2), 10);
							goto IL_1FE;
						}
						catch
						{
							return false;
						}
						goto IL_37B;
						IL_1FE:
						num = (short)298844160;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 12:
						num = (short)769064984;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 13:
						goto IL_4AD;
					case 14:
						if (hostVersion.StartsWith(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("잃", a_)))
						{
							num = (short)1832189971;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 15:
						if (num4 < 9)
						{
							num = (short)566755346;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						return true;
					case 16:
						goto IL_2E9;
					case 17:
						if (!hostVersion.StartsWith(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("삃", a_)))
						{
							num = (short)617152518;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_4AD;
					case 18:
						goto IL_4E5;
					case 19:
						goto IL_2B4;
					case 20:
						num = (short)623050773;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 21:
						if (hostVersion.StartsWith(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("잃", a_)))
						{
							num = (short)2101739533;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 22:
						goto IL_37B;
					case 23:
						num = (short)1883635713;
						if (num != 0)
						{
						}
						num = (short)1237712906;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 24:
						if (num4 < 10)
						{
							num = (short)1847459862;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						return true;
					case 25:
						if (hostVersion.StartsWith(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("횃", a_)))
						{
							num = (short)1704001548;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_37B;
					case 26:
						if (!hostVersion.StartsWith(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("욃", a_)))
						{
							num = (short)1441005588;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_4AD;
					}
					goto IL_D0;
					IL_EF:
					num = (short)1514405889;
					num3 = (int)((global::System.IntPtr)num);
					continue;
					IL_2B4:
					num = (short)2108162053;
					num3 = (int)((global::System.IntPtr)num);
					continue;
					IL_37B:
					num = (short)1152712721;
					num3 = (int)((global::System.IntPtr)num);
					continue;
					IL_4AD:
					num = (short)1136132111;
					num3 = (int)((global::System.IntPtr)num);
				}
				return true;
				IL_2E9:
				return false;
				IL_2EB:
				num = (short)1463353344;
				short num5 = num;
				return true;
				IL_D0:
				num4 = 0;
				num = (short)525860875;
				num3 = (int)((global::System.IntPtr)num);
				goto IL_5E;
			}
			}
			return false;
			IL_4E5:
			return false;
		}

		// Token: 0x06000C23 RID: 3107 RVA: 0x000FA60C File Offset: 0x000F880C
		public static bool IsRadioUpgradeHostGreaterThan_7_12(string radioHostVer, string cvnHostVer)
		{
			int a_ = 18;
			short num = (short)1502666692;
			short num2 = num;
			num = (short)965402564;
			int num3;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_108:
				num = (short)421396496;
				num3 = (int)((global::System.IntPtr)num);
				break;
			default:
				num = (short)346816512;
				if (num != 0)
				{
				}
				switch (0)
				{
				case 0:
					goto IL_B4;
				}
				break;
			}
			short num5;
			short num6;
			for (;;)
			{
				IL_5E:
				switch (num3)
				{
				case 0:
					if (radioHostVer.StartsWith(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("힔", a_)))
					{
						num = (short)933429263;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					return false;
				case 1:
					if (!cvnHostVer.StartsWith(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("톔", a_)))
					{
						num = (short)37224462;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1FB;
				case 2:
					goto IL_1FB;
				case 3:
					goto IL_26F;
				case 4:
					if (radioHostVer.StartsWith(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("잔", a_)))
					{
						goto IL_108;
					}
					goto IL_1AE;
				case 5:
					if (!radioHostVer.StartsWith(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("톔", a_)))
					{
						num = (short)575864838;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_2BD;
				case 6:
					num = (short)933953536;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 7:
				{
					num = (short)1246101504;
					short num4 = num;
					num = (short)935395340;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 8:
					num = (short)433913857;
					if (num != 0)
					{
					}
					if (cvnHostVer.StartsWith(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("잔", a_)))
					{
						num = (short)1979383815;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_26F;
				case 9:
					goto IL_342;
				case 10:
					if (num5 >= 7)
					{
						num = (short)18153481;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					return false;
				case 11:
					return true;
				case 12:
					if (num6 < 8)
					{
						num = (short)123469827;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					return true;
				case 13:
					if (num5 < 8)
					{
						num = (short)513343507;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_342;
				case 14:
					num = (short)414973970;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 15:
					goto IL_2BD;
				case 16:
					num = (short)77070349;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 17:
					if (num6 >= 7)
					{
						num = (short)446103563;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					return false;
				case 18:
					if (cvnHostVer.StartsWith(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("힔", a_)))
					{
						num = (short)1684668418;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					return false;
				case 19:
					goto IL_1AE;
				}
				goto IL_B4;
				IL_1AE:
				num = (short)851973;
				num3 = (int)((global::System.IntPtr)num);
				continue;
				IL_1FB:
				num = (short)82575377;
				num3 = (int)((global::System.IntPtr)num);
				continue;
				IL_26F:
				num = (short)1782644737;
				num3 = (int)((global::System.IntPtr)num);
				continue;
				IL_2BD:
				num = (short)602931210;
				num3 = (int)((global::System.IntPtr)num);
				continue;
				IL_342:
				num = (short)389087240;
				num3 = (int)((global::System.IntPtr)num);
			}
			return true;
			IL_B4:
			num5 = 0;
			num6 = 0;
			short.TryParse(radioHostVer.Substring(1, 2), out num5);
			short.TryParse(cvnHostVer.Substring(1, 2), out num6);
			num = (short)14417924;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_5E;
		}

		// Token: 0x06000C24 RID: 3108 RVA: 0x000FA9F8 File Offset: 0x000F8BF8
		internal static bool IsRadioUpgradeHostLessThan_7_12(string radioHostVer, string cvnHostVer)
		{
			int a_ = 4;
			switch (0)
			{
			case 0:
				goto IL_69;
			}
			int num;
			short num2;
			short num5;
			short num6;
			for (;;)
			{
				IL_13:
				switch (num)
				{
				case 0:
					if (radioHostVer.StartsWith(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("얆", a_)))
					{
						num2 = (short)222232591;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return false;
				case 1:
					if (!cvnHostVer.StartsWith(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쎆", a_)))
					{
						num2 = (short)505217038;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_1B2;
				case 2:
					goto IL_1B2;
				case 3:
					goto IL_22B;
				case 4:
					if (radioHostVer.StartsWith(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("햆", a_)))
					{
						num2 = (short)698679312;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_165;
				case 5:
					if (!radioHostVer.StartsWith(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쎆", a_)))
					{
						num2 = (short)813826054;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_27A;
				case 6:
					num2 = (short)371654657;
					if (num2 != 0)
					{
					}
					num2 = (short)218890240;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 7:
					goto IL_129;
				case 8:
					if (cvnHostVer.StartsWith(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("햆", a_)))
					{
						num2 = (short)118030343;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_22B;
				case 9:
				{
					num2 = (short)52029957;
					short num3 = num2;
					num2 = (short)576907781;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_129;
					default:
						num2 = (short)1349648384;
						if (num2 != 0)
						{
						}
						goto IL_395;
					}
					break;
				}
				case 10:
				{
					num2 = (short)997195776;
					short num4 = num2;
					if (num5 < 7)
					{
						num2 = (short)1037107209;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return false;
				}
				case 11:
					return true;
				case 12:
					if (num6 < 8)
					{
						num2 = (short)972161027;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return true;
				case 13:
					if (num5 >= 8)
					{
						num2 = (short)1782120467;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_395;
				case 14:
					num2 = (short)867565586;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 15:
					goto IL_27A;
				case 16:
					num2 = (short)2066415629;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 17:
					if (num6 >= 7)
					{
						num2 = (short)625344523;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return false;
				case 18:
					if (cvnHostVer.StartsWith(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("얆", a_)))
					{
						num2 = (short)1240727554;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return false;
				case 19:
					goto IL_165;
				}
				goto IL_69;
				IL_129:
				num2 = (short)765722636;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_165:
				num2 = (short)1533542405;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_1B2:
				num2 = (short)2033582097;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_22B:
				num2 = (short)1382285313;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_27A:
				num2 = (short)1411645450;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_395:
				num2 = (short)781123592;
				num = (int)((global::System.IntPtr)num2);
			}
			return true;
			IL_69:
			num5 = 0;
			num6 = 0;
			short.TryParse(radioHostVer.Substring(1, 2), out num5);
			short.TryParse(cvnHostVer.Substring(1, 2), out num6);
			num2 = (short)229441540;
			num = (int)((global::System.IntPtr)num2);
			goto IL_13;
		}

		// Token: 0x06000C25 RID: 3109 RVA: 0x000FADEC File Offset: 0x000F8FEC
		internal static global::Motorola.Common.Communication.Pba.LanguagePackData BuildWriteLanguageData(string softWareVersion, bool isFlashPort)
		{
			short num = (short)204931072;
			short num2 = num;
			num = (short)1123930098;
			short num3 = num;
			num = (short)1313132530;
			switch (num3 == num)
			{
			}
			num = (short)1251213312;
			if (num != 0)
			{
			}
			num = (short)1521680385;
			if (num != 0)
			{
			}
			global::Motorola.Common.Communication.Pba.LanguagePackData languagePackData = new global::Motorola.Common.Communication.Pba.LanguagePackData();
			string sourceFilePath = global::SpecialFeatures.RadioLanguagePack.LanguagePackHelper.a(softWareVersion);
			global::Motorola.Common.Communication.Pba.AstroFilePackInfo item = new global::Motorola.Common.Communication.Pba.AstroFilePackInfo
			{
				sourceFilePath = sourceFilePath,
				languageUpgradeType = global::SpecialFeatures.RadioLanguagePack.LanguagePackHelper.UpgradRadioLangSetting,
				isFlashPortUpgradeLP = isFlashPort
			};
			languagePackData.LanguagePacks.Add(item);
			return languagePackData;
		}

		// Token: 0x06000C26 RID: 3110 RVA: 0x000FAECC File Offset: 0x000F90CC
		public static global::Motorola.CommonCPS.Server.EntityModel.ASTROLanguagePack ParseLanguagePackage(string packagePath)
		{
			int a_ = 5;
			short num = (short)2094268416;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_50;
				}
				global::System.Xml.XmlNode xmlNode;
				for (;;)
				{
					IL_31:
					switch (num2)
					{
					case 0:
					{
						global::System.Xml.XmlDocument xmlDocument;
						try
						{
							xmlDocument = global::SpecialFeatures.RadioLanguagePack.LPFileEncDec.Decrypt(packagePath);
							goto IL_155;
						}
						catch (global::System.Exception)
						{
							throw new global::System.ArgumentException(string.Format(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udd87ﲏ뒓몙ﮝ솟욡蒣삥솧용즫钭邯즱蒳쮵", a_), packagePath));
						}
						goto IL_1CB;
						IL_155:
						xmlNode = xmlDocument.DocumentElement.SelectSingleNode(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("ꞇꖉﺍﾓ릕ﺙﾝ잟", a_));
						num = (short)1642528769;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 1:
						if (xmlNode != null)
						{
							num = (short)859111428;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1CB;
					case 2:
						goto IL_102;
					case 3:
						goto IL_1CB;
					case 4:
					{
						num = (short)1136197632;
						short num3 = num;
						num = (short)1837105154;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 5:
						goto IL_1EF;
					}
					goto IL_50;
					IL_1CB:
					global::SpecialFeatures.CommonExceptionHelper.CreateDirectMessageCommonException(global::SpecialFeatures.RadioLanguagePack.LanguagePackHelper.c);
					num = (short)2017984517;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_1EF:
				goto IL_1F1;
				IL_50:
				num = (short)1168498352;
				short num4 = num;
				num = (short)427417264;
				global::Motorola.CommonCPS.Server.EntityModel.ASTROLanguagePack astrolanguagePack;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					IL_102:
					num = (short)280428545;
					if (num != 0)
					{
					}
					if (string.IsNullOrEmpty(xmlNode.InnerText))
					{
						num = (short)62980099;
						num2 = (int)((global::System.IntPtr)num);
						goto IL_31;
					}
					break;
				default:
				{
					num = (short)1418592256;
					if (num != 0)
					{
					}
					astrolanguagePack = new global::Motorola.CommonCPS.Server.EntityModel.ASTROLanguagePack();
					global::System.Xml.XmlDocument xmlDocument = null;
					num = (short)1987575808;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_31;
				}
				}
				IL_1F1:
				astrolanguagePack.PackageVersion = xmlNode[global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("ﺇﺋﶍ憐﶑望", a_)].InnerText;
				astrolanguagePack.PackageName = global::System.IO.Path.GetFileNameWithoutExtension(packagePath);
				astrolanguagePack.LpID = xmlNode[global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("", a_)].InnerText;
				astrolanguagePack.CompatibleVersion = xmlNode[global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("ﺍﶓﾙ쪛ﮝ튟톡춣즥욧", a_)].InnerText;
				astrolanguagePack.PackageLanguage = xmlNode[global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("ﺍ\uda93ﾙ", a_)].InnerText;
				global::Motorola.CommonCPS.Server.EntityModel.RMFile rmfile = new global::Motorola.CommonCPS.Server.EntityModel.RMFile
				{
					Url = packagePath
				};
				astrolanguagePack.RMFile = rmfile;
				astrolanguagePack.ModifiedDate = new global::System.DateTime?(global::System.DateTime.Now);
				return astrolanguagePack;
			}
			}
		}

		// Token: 0x06000C27 RID: 3111 RVA: 0x000FB188 File Offset: 0x000F9388
		private static int b(string A_0)
		{
			int a_ = 14;
			switch (0)
			{
			case 0:
				goto IL_165;
			}
			int num;
			string s;
			short num2;
			int result;
			uint num3;
			for (;;)
			{
				IL_13:
				switch (num)
				{
				case 0:
					if (!(s == global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("뢔", a_)))
					{
						num2 = (short)2081882184;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					result = 2;
					num2 = (short)1606090830;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
					if (num3 != 816402186U)
					{
						num2 = (short)829292579;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)725090365;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
					if (num3 != 210211011U)
					{
						num2 = (short)484900917;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)830013456;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 3:
					goto IL_C4F;
				case 4:
					goto IL_C4F;
				case 5:
					num2 = (short)382402614;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 6:
					num2 = (short)2061107274;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 7:
					goto IL_C4F;
				case 8:
					num2 = (short)592248897;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 9:
					num2 = (short)159449127;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 10:
					goto IL_C4F;
				case 11:
					num2 = (short)1220018180;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 12:
					goto IL_C4F;
				case 13:
					if (num3 <= 1663232296U)
					{
						num2 = (short)602472457;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)2006188052;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 14:
					num2 = (short)928251919;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 15:
					if (num3 != 1865549462U)
					{
						num2 = (short)1074659360;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)1750925389;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 16:
					if (!(s == global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("ﮒ뢔", a_)))
					{
						num2 = (short)1751121946;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					result = 7;
					num2 = (short)1834942495;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 17:
					num2 = (short)1570635788;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 18:
					goto IL_C4F;
				case 19:
					num2 = (short)517210174;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 20:
					if (num3 <= 2695330748U)
					{
						num2 = (short)24445004;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)920518722;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 21:
				{
					num2 = (short)1096893441;
					short num4 = num2;
					num2 = (short)665994241;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_991;
					default:
						num2 = (short)469893120;
						if (num2 != 0)
						{
						}
						goto IL_C4F;
					}
					break;
				}
				case 22:
					if (num3 != 1171357212U)
					{
						num2 = (short)502792222;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)2083586127;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 23:
					goto IL_C4F;
				case 24:
					num2 = (short)184614914;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 25:
					goto IL_C4F;
				case 26:
					num2 = (short)1486553091;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 27:
					if (!(s == global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("뢔", a_)))
					{
						num2 = (short)870514747;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					result = 3;
					num2 = (short)39583807;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 28:
					return result;
				case 29:
					goto IL_C4F;
				case 30:
					num2 = (short)759693346;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 31:
					return result;
				case 32:
					num2 = (short)2041708587;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 33:
					return result;
				case 34:
					goto IL_C4F;
				case 35:
					num2 = (short)1716060182;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 36:
					if (!(s == global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("ﶒ뢔", a_)))
					{
						num2 = (short)605487115;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					result = 9;
					num2 = (short)1571749932;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 37:
					return result;
				case 38:
					return result;
				case 39:
					if (num3 <= 1171357212U)
					{
						num2 = (short)1615790104;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)589889607;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 40:
					num2 = (short)673775623;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 41:
					goto IL_C4F;
				case 42:
					num2 = (short)545587229;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 43:
					if (num3 != 2695330748U)
					{
						num2 = (short)1427570736;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)1632174144;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 44:
					return result;
				case 45:
					num2 = (short)962199598;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 46:
					if (num3 != 3836164254U)
					{
						num2 = (short)476840004;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)1003487302;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 47:
					return result;
				case 48:
					num2 = (short)482738197;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 49:
					num2 = (short)1309343785;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 50:
					num2 = (short)1500708916;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 51:
					goto IL_C4F;
				case 52:
					goto IL_C4F;
				case 53:
					num2 = (short)290979841;
					if (num2 != 0)
					{
					}
					num2 = (short)516227073;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 54:
					if (num3 != 1546480511U)
					{
						num2 = (short)2144468998;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)1083113545;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 55:
					return result;
				case 56:
					return result;
				case 57:
					if (!(s == global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("뢔", a_)))
					{
						num2 = (short)480837699;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					result = 11;
					num2 = (short)1831338040;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 58:
					goto IL_C4F;
				case 59:
					num2 = (short)501874711;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 60:
					if (num3 != 1848771843U)
					{
						num2 = (short)1423114254;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)1151926329;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 61:
					if (!(s == global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("뢔", a_)))
					{
						num2 = (short)1840971818;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					result = 8;
					num2 = (short)690946095;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 62:
				{
					if (num3 != 3555265851U)
					{
						num2 = (short)989331501;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)1014824960;
					short num5 = num2;
					num2 = (short)3145764;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 63:
					return result;
				case 64:
					if (!(s == global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("戀뢔ﺖ", a_)))
					{
						num2 = (short)626393128;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					result = 5;
					num2 = (short)1191247905;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 65:
					goto IL_C4F;
				case 66:
					if (num3 != 2831332922U)
					{
						num2 = (short)1891631123;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)977535045;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 67:
					num2 = (short)626655283;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 68:
					num2 = (short)1754660874;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 69:
					if (!(s == global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("뢔ﺖﶘ", a_)))
					{
						num2 = (short)1573257266;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					result = 4;
					num2 = (short)1982464037;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 70:
					if (!(s == global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("뢔", a_)))
					{
						num2 = (short)966000722;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					result = 6;
					num2 = (short)1295646800;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 71:
					if (num3 != 1437583224U)
					{
						num2 = (short)272171013;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)763035675;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 72:
					num2 = (short)2023686169;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 73:
					if (!(s == global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("뢔", a_)))
					{
						num2 = (short)1700528177;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					result = 10;
					num2 = (short)1450704934;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 74:
					if (num3 != 1663232296U)
					{
						goto IL_991;
					}
					num2 = (short)674824192;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 75:
					return result;
				case 76:
					num2 = (short)435879996;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 77:
					if (!(s == global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("뢔", a_)))
					{
						num2 = (short)367132753;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					result = 12;
					num2 = (short)1968963639;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 78:
					return result;
				case 79:
					if (!(s == global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("뢔", a_)))
					{
						num2 = (short)1713045512;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					result = 1;
					num2 = (short)2046230603;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 80:
					return result;
				case 81:
					num2 = (short)1214971922;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 82:
					num2 = (short)2067333178;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_165;
				IL_991:
				num2 = (short)1754791953;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_C4F:
				result = 0;
				num2 = (short)1572864028;
				num = (int)((global::System.IntPtr)num2);
			}
			return result;
			IL_165:
			s = A_0.ToLower();
			num3 = global::<PrivateImplementationDetails>.ComputeStringHash(s);
			num2 = (short)2134376461;
			num = (int)((global::System.IntPtr)num2);
			goto IL_13;
		}

		// Token: 0x06000C28 RID: 3112 RVA: 0x000FBE50 File Offset: 0x000FA050
		public static string GetAstroLanugagePackID(int languageIndex)
		{
			int a_ = 6;
			short num = (short)977076226;
			int num2 = (int)((global::System.IntPtr)num);
			string result;
			for (;;)
			{
				switch (num2)
				{
				case 0:
				{
					num = (short)1558773760;
					short num3 = num;
					result = string.Empty;
					num = (short)605814793;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 1:
					return result;
				case 2:
					switch (0)
					{
					case 0:
						goto IL_71;
					}
					continue;
				case 3:
					return result;
				case 4:
					return result;
				case 5:
					return result;
				case 6:
					return result;
				case 7:
					return result;
				case 8:
					return result;
				case 9:
					return result;
				case 10:
					return result;
				case 11:
					return result;
				case 12:
					return result;
				case 13:
					return result;
				case 14:
					num = (short)1781792768;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 15:
					return result;
				case 16:
					return result;
				}
				IL_71:
				switch (languageIndex)
				{
				case 0:
					result = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("ꂌ搜", a_);
					num = (short)1766588428;
					num2 = (int)((global::System.IntPtr)num);
					break;
				case 1:
					result = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("力ꂌ", a_);
					num = (short)1068236806;
					num2 = (int)((global::System.IntPtr)num);
					break;
				case 2:
					result = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("ꂌ", a_);
					num = (short)1398145028;
					num2 = (int)((global::System.IntPtr)num);
					break;
				case 3:
					result = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("麗ﾊꂌﾎ", a_);
					num = (short)316080131;
					num2 = (int)((global::System.IntPtr)num);
					break;
				case 4:
				{
					num = (short)1621639011;
					short num4 = num;
					num = (short)1765228387;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						return result;
					default:
						num = (short)252772352;
						if (num != 0)
						{
						}
						result = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("ꂌ", a_);
						num = (short)1492123655;
						num2 = (int)((global::System.IntPtr)num);
						break;
					}
					break;
				}
				case 5:
					result = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("ꂌ﶐", a_);
					num = (short)1255866381;
					num2 = (int)((global::System.IntPtr)num);
					break;
				case 6:
					result = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("ﮈﺊꂌﶎ", a_);
					num = (short)774242305;
					if (num != 0)
					{
					}
					num = (short)1539702785;
					num2 = (int)((global::System.IntPtr)num);
					break;
				case 7:
					result = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("ꂌﮎ", a_);
					num = (short)1928790031;
					num2 = (int)((global::System.IntPtr)num);
					break;
				case 8:
					result = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("力ꂌ", a_);
					num = (short)28442634;
					num2 = (int)((global::System.IntPtr)num);
					break;
				case 9:
					result = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("ꂌ", a_);
					num = (short)1778712581;
					num2 = (int)((global::System.IntPtr)num);
					break;
				case 10:
					result = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("ꂌ", a_);
					num = (short)855310352;
					num2 = (int)((global::System.IntPtr)num);
					break;
				case 11:
					result = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("ꂌ﶐", a_);
					num = (short)1222377480;
					num2 = (int)((global::System.IntPtr)num);
					break;
				case 12:
					result = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("ꂌﺐ", a_);
					num = (short)1591476235;
					num2 = (int)((global::System.IntPtr)num);
					break;
				default:
					num = (short)1116798990;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
			}
			return result;
		}

		// Token: 0x06000C29 RID: 3113 RVA: 0x000FC238 File Offset: 0x000FA438
		private static string a(int A_0)
		{
			int a_ = 18;
			short num;
			for (;;)
			{
				num = (short)621281281;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						num = (short)82837506;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
					{
						num = (short)812974080;
						short num3 = num;
						switch (0)
						{
						case 0:
							goto IL_62;
						}
						continue;
					}
					case 2:
						goto IL_105;
					}
					IL_62:
					switch (A_0)
					{
					case 0:
					case 4:
					case 9:
						goto IL_1AB;
					case 1:
						goto IL_D0;
					case 2:
					case 10:
					case 11:
					case 12:
						goto IL_128;
					case 3:
						goto IL_119;
					case 5:
						goto IL_C1;
					case 6:
						goto IL_B2;
					case 7:
						goto IL_10A;
					case 8:
						goto IL_DF;
					default:
						num = (short)429457408;
						num2 = (int)((global::System.IntPtr)num);
						break;
					}
				}
				IL_128:
				num = (short)155917926;
				short num4 = num;
				num = (short)839851622;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					goto IL_15D;
				}
			}
			IL_B2:
			return global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("잔ﺞ쾠", a_);
			IL_C1:
			return global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udd94ﮘ", a_);
			IL_D0:
			return global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("펔ﲘﺜ", a_);
			IL_DF:
			return global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("풔連ﲞ", a_);
			IL_105:
			goto IL_1AB;
			IL_10A:
			return global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("횔ﾖ쒠", a_);
			IL_119:
			return global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("얔풠욢횤슦", a_);
			IL_15D:
			num = (short)149159937;
			if (num != 0)
			{
			}
			num = (short)307822592;
			if (num != 0)
			{
			}
			return global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("요즠", a_);
			IL_1AB:
			return global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("킔練ﺘ즠", a_);
		}

		// Token: 0x06000C2A RID: 3114 RVA: 0x000FC400 File Offset: 0x000FA600
		private static string a(string A_0)
		{
			int a_ = 11;
			short num = (short)1369702400;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_F0;
				}
				string innerText2;
				int value;
				string text2;
				for (;;)
				{
					IL_30:
					num = (short)121831424;
					short num3 = num;
					int num4;
					string[] array;
					global::System.Version version;
					global::System.Text.RegularExpressions.Regex regex;
					global::System.Text.RegularExpressions.Match match2;
					switch (num2)
					{
					case 0:
					{
						if (num4 < 0)
						{
							num = (short)375062548;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						string text = array.ElementAt(num4);
						num = (short)1648754703;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 1:
					{
						string xpath = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("ꆍ뾏ﺑﮗ뎛쒟횡얣솥螧즩쎫쎭삯펱삳\udfb5\udab7횹\ud9bbꖿ껁ꇃꟅ믇꿉飋꿍럏蓑뇓ꓕꯗ동돛냝", a_);
						global::System.Xml.XmlDocument xmlDocument;
						global::System.Xml.XmlNode xmlNode = xmlDocument.DocumentElement.SelectSingleNode(xpath);
						num = (short)478216215;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
						goto IL_1FA;
					case 3:
					{
						global::System.Version version2;
						if (version.CompareTo(version2) >= 0)
						{
							num = (short)865796103;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_35C;
					}
					case 4:
					{
						global::System.Text.RegularExpressions.Match match;
						global::System.Version version2 = new global::System.Version(match.Value);
						num = (short)1971519515;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 5:
						num = (short)1725169678;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
						num = (short)389087260;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
						num = (short)642646045;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 8:
					{
						try
						{
							string searchPattern;
							array = global::System.IO.Directory.GetFiles(global::SpecialFeatures.RadioLanguagePack.LanguagePackHelper.LanguagePackFolderPath, searchPattern);
							goto IL_43A;
						}
						catch (global::System.Exception)
						{
							throw global::SpecialFeatures.CommonExceptionHelper.CreateDirectMessageCommonException(global::SpecialFeatures.RadioLanguagePack.LanguagePackHelper.c);
						}
						goto IL_32A;
						IL_43A:
						string text = string.Empty;
						global::System.Xml.XmlDocument xmlDocument = null;
						num = (short)274530329;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 9:
					{
						global::System.Xml.XmlNode xmlNode2;
						if (string.IsNullOrEmpty(xmlNode2.InnerText))
						{
							num = (short)1561067550;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						string innerText = xmlNode2.InnerText;
						global::System.Text.RegularExpressions.Match match = regex.Match(innerText);
						num = (short)1655242787;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 10:
						if (!string.IsNullOrEmpty(innerText2))
						{
							num = (short)1249705996;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_42F;
					case 11:
					{
						global::System.Xml.XmlNode xmlNode2;
						if (xmlNode2 != null)
						{
							num = (short)1362558994;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_4C4;
					}
					case 12:
						num = (short)498663457;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 13:
						goto IL_6D5;
					case 14:
						if (value != 9)
						{
							num = (short)1308098594;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_788;
					case 15:
					{
						global::System.Xml.XmlDocument xmlDocument;
						try
						{
							string text;
							xmlDocument = global::SpecialFeatures.RadioLanguagePack.LPFileEncDec.Decrypt(text);
							goto IL_151;
						}
						catch (global::System.Exception)
						{
							string text;
							throw global::SpecialFeatures.CommonExceptionHelper.CreateDirectMessageCommonException(string.Format(global::CommonResources.AppResources.Unable_to_read_file, text));
						}
						goto IL_737;
						IL_151:
						global::System.Xml.XmlNode xmlNode2 = xmlDocument.DocumentElement.SelectSingleNode(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("ꆍ뾏ﺑﮗ뎛쒟횡얣솥螧즩쎫쎭삯펱삳\udfb5\udab7횹\ud9bbꖿ냁럃꿅Ꟈ꓉", a_));
						num = (short)1107886091;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 16:
						match2 = regex.Match(A_0);
						if (!match2.Success)
						{
							goto Block_4;
						}
						goto IL_32A;
					case 17:
						goto IL_1F5;
					case 18:
						num = (short)1639579657;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 19:
						goto IL_6D5;
					case 20:
						goto IL_510;
					case 21:
						if (value != 0)
						{
							num = (short)733937669;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_788;
					case 22:
						goto IL_308;
					case 23:
					{
						global::System.Xml.XmlNode xmlNode;
						if (xmlNode != null)
						{
							num = (short)1062862879;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_424;
					}
					case 24:
						goto IL_4CF;
					case 25:
						num = (short)1939472385;
						if (num != 0)
						{
						}
						if (array.Length != 0)
						{
							num = (short)1580662786;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_742;
					case 26:
					{
						global::System.Xml.XmlNode xmlNode;
						if (string.IsNullOrEmpty(xmlNode.InnerText))
						{
							num = (short)1199898646;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						innerText2 = xmlNode.InnerText;
						num = (short)1772158986;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 27:
					{
						global::System.Version version2;
						if (version.Major == version2.Major)
						{
							num = (short)650313734;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_4CF;
					}
					case 28:
						if (!A_0.StartsWith(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udc8d", a_)))
						{
							num = (short)333905944;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_35C;
					case 29:
						goto IL_510;
					case 30:
						goto IL_67A;
					case 31:
						num = (short)1109721114;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 32:
					{
						num = (short)121176452;
						short num5 = num;
						num = (short)1589772676;
						switch ((num5 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_1FA;
						default:
						{
							num = (short)1924726784;
							if (num != 0)
							{
							}
							if (num4 < 0)
							{
								num = (short)1082195969;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							string text;
							return text;
						}
						}
						break;
					}
					case 33:
						if (!innerText2.StartsWith(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udc8d", a_)))
						{
							num = (short)30277649;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_280;
					case 34:
					{
						text2 = global::SpecialFeatures.RadioLanguagePack.LanguagePackHelper.a(value);
						string searchPattern = text2 + global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("꒍뺏ﺑﶕ", a_);
						array = null;
						num = (short)1792737288;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 35:
					{
						global::System.Text.RegularExpressions.Match match;
						if (match.Success)
						{
							num = (short)191692804;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_737;
					}
					}
					goto IL_F0;
					IL_1FA:
					global::System.Array.Sort<string>(array);
					regex = new global::System.Text.RegularExpressions.Regex(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("ꚍ첏뾓쪕뚗욙떝ﲟ財슥莧莩", a_));
					num = (short)1068105744;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_32A:
					version = new global::System.Version(match2.Value);
					num4 = array.Length - 1;
					num = (short)84541453;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_35C:
					num4--;
					num = (short)997392403;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_4CF:
					num = (short)1450246147;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_510:
					num = (short)1398407200;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_6D5:
					num = (short)1317011456;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_1F5:
				goto IL_42F;
				Block_4:
				throw global::SpecialFeatures.CommonExceptionHelper.CreateDirectMessageCommonException(global::CommonResources.AppResources.Radio_firware_version_is_invalid);
				IL_280:
				throw global::SpecialFeatures.CommonExceptionHelper.CreateDirectMessageCommonException(string.Format(global::CommonResources.AppResources.LP_Radio_display_Language_Not_Supported_Upgrade_FW, text2, innerText2));
				IL_308:
				IL_424:
				throw global::SpecialFeatures.CommonExceptionHelper.CreateDirectMessageCommonException(global::SpecialFeatures.RadioLanguagePack.LanguagePackHelper.c);
				IL_42F:
				throw global::SpecialFeatures.CommonExceptionHelper.CreateDirectMessageCommonException(global::SpecialFeatures.RadioLanguagePack.LanguagePackHelper.c);
				IL_4C4:
				throw global::SpecialFeatures.CommonExceptionHelper.CreateDirectMessageCommonException(global::SpecialFeatures.RadioLanguagePack.LanguagePackHelper.c);
				IL_67A:
				goto IL_4C4;
				IL_737:
				throw global::SpecialFeatures.CommonExceptionHelper.CreateDirectMessageCommonException(global::SpecialFeatures.RadioLanguagePack.LanguagePackHelper.c);
				IL_742:
				throw global::SpecialFeatures.CommonExceptionHelper.CreateDirectMessageCommonException(global::SpecialFeatures.RadioLanguagePack.LanguagePackHelper.c);
				IL_788:
				return string.Empty;
				IL_F0:
				value = (global::AcpCommonLib.FeatureManager.GetFeature(2010)[0] as global::Motorola.MackinawCPS.CoreFeatures.DisplayAndMenu.DisplayAndMenu).Advanced.DispMenuAdvancedLanguageSelection_A8386.Value;
				num = (short)20185109;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_30;
			}
			}
		}

		// Token: 0x06000C2B RID: 3115 RVA: 0x000FCBB8 File Offset: 0x000FADB8
		internal static int GetCodeplugLanguageIndex()
		{
			short num = (short)853464350;
			short num2 = num;
			num = (short)2131023134;
			switch (num2 == num)
			{
			}
			num = (short)1925906432;
			short num3 = num;
			num = (short)10485760;
			if (num != 0)
			{
			}
			num = (short)836370433;
			if (num != 0)
			{
			}
			return (global::AcpCommonLib.FeatureManager.GetFeature(2010)[0] as global::Motorola.MackinawCPS.CoreFeatures.DisplayAndMenu.DisplayAndMenu).Advanced.DispMenuAdvancedLanguageSelection_A8386.Value;
		}

		// Token: 0x06000C2C RID: 3116 RVA: 0x000FCC84 File Offset: 0x000FAE84
		public static void AttachLanguagePackagesReference(global::Motorola.CommonCPS.Server.EntityModel.APXTemplate template)
		{
			short num;
			for (;;)
			{
				num = (short)679542784;
				short num2 = num;
				switch (0)
				{
				case 0:
					goto IL_45;
				}
				int num3;
				int? languageIndex;
				int num4;
				for (;;)
				{
					IL_33:
					switch (num3)
					{
					case 0:
					{
						global::CommonUtility.ASTROLanguageUtility instance = global::CommonUtility.ASTROLanguageUtility.Instance;
						languageIndex = template.LanguageIndex;
						global::Motorola.CommonCPS.Server.EntityModel.ASTROLanguagePack astrolanguagePack = instance.CreateFakeLanguagePackage(languageIndex.ToString());
						template.ASTROLanguagePack = astrolanguagePack;
						num = (short)220004354;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 1:
						if (!(languageIndex.GetValueOrDefault() == num4 & languageIndex != null))
						{
							num = (short)434962432;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 2:
						goto IL_F8;
					}
					goto IL_45;
				}
				IL_F8:
				num = (short)1672034511;
				short num5 = num;
				num = (short)486750415;
				switch ((num5 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					continue;
				default:
					goto IL_12C;
				}
				IL_45:
				num = (short)605814785;
				if (num != 0)
				{
				}
				languageIndex = template.LanguageIndex;
				num4 = 0;
				num = (short)1007419393;
				num3 = (int)((global::System.IntPtr)num);
				goto IL_33;
			}
			IL_12C:
			num = (short)83951616;
			if (num != 0)
			{
			}
		}

		// Token: 0x040005C8 RID: 1480
		private const string a = "RadioLanguagePacks";

		// Token: 0x040005C9 RID: 1481
		public static readonly string LanguagePackFolderPath;

		// Token: 0x040005CA RID: 1482
		public const string LanguagePackExtension = ".lpk";

		// Token: 0x040005CB RID: 1483
		public const string LanguagePackSearchPattern = "*.lpk";

		// Token: 0x040005CC RID: 1484
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private static int b;

		// Token: 0x040005CD RID: 1485
		private static string c;

		// Token: 0x040005CE RID: 1486
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private static string d;

		// Token: 0x040005CF RID: 1487
		private static global::System.Collections.Generic.Dictionary<int, global::Motorola.CommonCPS.Server.EntityModel.ASTROLanguagePack> e;
	}
}
