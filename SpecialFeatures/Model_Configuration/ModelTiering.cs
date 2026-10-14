using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Xml;
using AcpBusinessLayer;
using AcpCommonLib;
using AcpCryptoLib;
using AcpModelTieringLib;
using AcpUtility;
using CommonResources;
using ConstraintHelper;
using Features.Common;
using Motorola.Acp.PackUnpack.Ish.Layouts;
using Motorola.Common.Communication.CommonUtil;
using Motorola.CommonCPS.Server.EntityModel;
using Motorola.MackinawCPS.CoreFeatures.ConventionalWide;
using Motorola.MackinawCPS.CoreFeatures.MenuItems;
using Motorola.MackinawCPS.CoreFeatures.RadioInformation;
using Motorola.MackinawCPS.CoreFeatures.RadioWide;
using SpecialFeatures.AcpReportManagerLib;
using SpecialFeatures.Flashport.FlashRadio;

namespace SpecialFeatures.Model_Configuration
{
	// Token: 0x020000AD RID: 173
	public sealed class ModelTiering : global::System.IDisposable
	{
		// Token: 0x1700044A RID: 1098
		// (get) Token: 0x06000B9C RID: 2972 RVA: 0x000E2EC8 File Offset: 0x000E10C8
		private global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide RadioWideRef
		{
			get
			{
				short num = (short)357040128;
				short num2 = num;
				num = (short)1597833217;
				if (num != 0)
				{
				}
				num = (short)845930666;
				short num3 = num;
				num = (short)1226105002;
				switch (num3 == num)
				{
				}
				num = (short)1020854272;
				if (num != 0)
				{
				}
				return global::AcpCommonLib.FeatureManager.GetFeature(2045)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide;
			}
		}

		// Token: 0x1700044B RID: 1099
		// (set) Token: 0x06000B9D RID: 2973 RVA: 0x000E2F84 File Offset: 0x000E1184
		public global::System.Collections.Generic.List<string> FPSCustomizationOptions
		{
			set
			{
				short num = (short)1451950080;
				short num2 = num;
				num = (short)259425802;
				short num3 = num;
				num = (short)1748600330;
				switch (num3 == num)
				{
				}
				num = (short)1362362369;
				if (num != 0)
				{
				}
				num = (short)1512243200;
				if (num != 0)
				{
				}
				this.bv = value;
			}
		}

		// Token: 0x1700044C RID: 1100
		// (get) Token: 0x06000B9E RID: 2974 RVA: 0x000E3034 File Offset: 0x000E1234
		internal string MTFPath
		{
			get
			{
				short num = (short)1831862272;
				short num2 = num;
				num = (short)1986076540;
				short num3 = num;
				num = (short)743251836;
				switch (num3 == num)
				{
				}
				num = (short)1702690817;
				if (num != 0)
				{
				}
				num = (short)1125056512;
				if (num != 0)
				{
				}
				return this.bx;
			}
		}

		// Token: 0x1700044D RID: 1101
		// (get) Token: 0x06000B9F RID: 2975 RVA: 0x000E30E0 File Offset: 0x000E12E0
		private bool IsModelMobile
		{
			get
			{
				short num = (short)2022506496;
				short num2 = num;
				num = (short)679870465;
				if (num != 0)
				{
				}
				num = (short)1871564736;
				short num3 = num;
				num = (short)415813568;
				switch (num3 == num)
				{
				}
				num = (short)960102400;
				if (num != 0)
				{
				}
				return global::SpecialFeatures.Model_Configuration.ModelTiering.IsModelMobileByModelNumber(this.bu);
			}
		}

		// Token: 0x06000BA0 RID: 2976 RVA: 0x000E3194 File Offset: 0x000E1394
		public static bool IsModelMobileByModelNumber(string modelNumber)
		{
			int a_ = 10;
			short num = (short)425984000;
			short num2 = num;
			num = (short)1209401345;
			if (num != 0)
			{
			}
			num = (short)516794942;
			short num3 = num;
			num = (short)1779083838;
			switch (num3 == num)
			{
			}
			num = (short)126484480;
			if (num != 0)
			{
			}
			return !modelNumber.StartsWith(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("얌", a_));
		}

		// Token: 0x06000BA1 RID: 2977 RVA: 0x000E3260 File Offset: 0x000E1460
		public void Dispose()
		{
			short num = (short)1480720384;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
				{
					num = (short)1163872770;
					short num3 = num;
					num = (short)282937858;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_F8;
					default:
					{
						num = (short)2020147200;
						if (num != 0)
						{
						}
						num = (short)550895616;
						short num4 = num;
						num = (short)1463615489;
						if (num != 0)
						{
						}
						switch (0)
						{
						case 0:
							goto IL_CD;
						}
						continue;
					}
					}
					break;
				}
				case 1:
					goto IL_10C;
				case 2:
					this.b1.Dispose();
					goto IL_F8;
				}
				IL_CD:
				if (this.b1 != null)
				{
					num = (short)1075642370;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_F8:
				num = (short)1444806657;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_10C:
			global::System.GC.SuppressFinalize(this);
		}

		// Token: 0x06000BA2 RID: 2978 RVA: 0x000E3384 File Offset: 0x000E1584
		static ModelTiering()
		{
			int a_ = 6;
			short num = (short)1631518720;
			short num2 = num;
			num = (short)125275519;
			short num3 = num;
			num = (short)482643327;
			switch (num3 == num)
			{
			}
			num = (short)712900609;
			if (num != 0)
			{
			}
			num = (short)1036845056;
			if (num != 0)
			{
			}
			global::SpecialFeatures.Model_Configuration.ModelTiering.br = new string[]
			{
				global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udb88욎ﾐ杖킖ﲘ삠쾢욦톨슪사\udaae\udcb0\uddb4횶ힸ햺\ud8bc펾닀鳂蓄ￊ頻", a_),
				global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udb88욎ﾐ杖킖ﲘ삠쾢햦삨욪첬\uddae좰잴튶좸캺\ud8bc톾ꋀ뫂蟄ꛆꟈ꿊鋌軎", a_),
				global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udb88욎ﾐ杖킖ﲘ삠쾢슦쪨쒪쎬쮮킰솲체쮸\udeba첼쪾꓀귂ꛄ뻆诈꫊ꏌꯎ軐鋒", a_),
				global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udb88욎ﾐ杖킖ﲘ삠쾢햦삨욪첬\uddae좰잴튶좸캺\ud8bc톾ꋀ뫂蟄ꛆꟈ꿊鯌蟎韐賒铔", a_),
				global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udb88욎ﾐ杖킖ﲘ삠쾢햦삨욪첬\uddae좰잴튶좸캺\ud8bc톾ꋀ뫂蟄ꛆꟈ꿊飌蟎韐諔雖ퟠ", a_),
				global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udb88욎ﾐ杖킖ﲘ삠쾢햦삨욪첬\uddae좰잴튶좸캺\ud8bc톾ꋀ뫂蟄ꛆꟈ꿊飌蟎韐諔雖훠", a_),
				global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udb88욎ﾐ杖킖ﲘ삠쾢햦삨욪첬\uddae좰잴튶좸캺\ud8bc톾ꋀ뫂蟄ꛆꟈ꿊頻ￎ賒铔", a_),
				global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udb88욎ﾐ杖킖ﲘ삠쾢햦삨욪첬\uddae좰잴튶좸캺\ud8bc톾ꋀ뫂蟄ꛆꟈ꿊ￎ賒铔", a_),
				global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udb88욎ﾐ杖킖ﲘ삠쾢햦삨욪첬\uddae좰잴튶좸캺\ud8bc톾ꋀ뫂蟄ꛆꟈ꿊ￎ賒铔", a_)
			};
			global::AcpUtility.AssemblyValidator.IsCallerAuthorized();
		}

		// Token: 0x06000BA3 RID: 2979 RVA: 0x000E34E4 File Offset: 0x000E16E4
		public ModelTiering(string strModelNumber, global::SpecialFeatures.Model_Configuration.ModelTiering.ActionTypes action, global::SpecialFeatures.Model_Configuration.ModelTiering.TargetTypes target, bool forComparedCodeplug = false)
		{
			int a_ = 9;
			this.bu = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쒋랍ꞏ욑펓튕ꆗ쪙쮛꾝", a_);
			this.bw = true;
			this.bx = string.Empty;
			this.by = global::System.AppDomain.CurrentDomain.BaseDirectory;
			base..ctor();
			this.CheckForModelTieringFile();
			if (!this.c(strModelNumber))
			{
				throw new global::System.Exception(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("얋ﾕﲗ몙톛쒟잡좣蚥\udfa9솫청햯삱钳\uddb7캹\ud9bb\uddbd뒿ꟁꃃ鳋ꋍ뗏돑ꟓ돕맙듛믝菟觡쓣鿥蟧鿩黫컭藯臱闳釵鷷\udaf9鏻飽⃿企欃戅洇昉堋服甏怑紓砕缗", a_));
			}
			for (;;)
			{
				this.bv = new global::System.Collections.Generic.List<string>();
				this.bt = target;
				this.bs = action;
				this.b1 = new global::SpecialFeatures.Flashport.FlashRadio.FlashcodeTable();
				this.b0 = this.b();
				this.bz = new global::System.Collections.Generic.Dictionary<string, bool>();
				this.b3 = new global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.List<string>>();
				try
				{
					if (this.bs != global::SpecialFeatures.Model_Configuration.ModelTiering.ActionTypes.DEPOT)
					{
						if (this.bs != global::SpecialFeatures.Model_Configuration.ModelTiering.ActionTypes.FLASHPORT)
						{
							if (this.bs != global::SpecialFeatures.Model_Configuration.ModelTiering.ActionTypes.NEW && this.bs != global::SpecialFeatures.Model_Configuration.ModelTiering.ActionTypes.NONE)
							{
								this.FPSInitializeOrderedOptions(forComparedCodeplug);
								break;
							}
							break;
						}
					}
					this.b1.InitTable(true, strModelNumber, false);
					this.a(false);
					this.b2 = new global::AcpModelTieringLib.CModelTieringEngine(this.bw, this.bx, true, this.bz);
					if (!this.c())
					{
						throw new global::System.Exception(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쪋ﲏ뒓삕ﶗ쾟첡蒣욧즩쎫쎭삯펱삳\udfb5\udab7펹킻ힽ뒿믁菅뫇룉ꏋ볍\udacf苑룓돕맗꧙맛ﻝ鋟蟡짣迥蛧駩飫迭鳯黱퓳苵郷鿹\udcfb鿽烿爁栃漅欇欉砋服缏簑㐓眕瘗縙㰛樝刟嬡У䜥伧䬩䔫䀭ḯ", a_));
					}
					break;
				}
				catch (global::System.Exception ex)
				{
					this.b2 = null;
					this.b1 = null;
					global::System.Windows.Forms.MessageBox.Show(ex.Message);
					global::System.Console.WriteLine(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("벋펏풑꒓ꞕ", a_));
					global::System.Console.WriteLine(ex.Message);
					global::System.Console.WriteLine(ex.StackTrace);
					global::System.Environment.Exit(52993);
					break;
				}
			}
		}

		// Token: 0x06000BA4 RID: 2980 RVA: 0x000E3698 File Offset: 0x000E1898
		public ModelTiering(string modelNumber, string flashCode)
		{
			int a_ = 17;
			this.bu = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udc93꾕꾗캙\udb9b\uda9d馟鞥", a_);
			this.bw = true;
			this.bx = string.Empty;
			this.by = global::System.AppDomain.CurrentDomain.BaseDirectory;
			base..ctor();
			this.CheckForModelTieringFile();
			if (!this.c(modelNumber))
			{
				throw new global::System.Exception(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udd93ﮙ쒟芡즥첧쾩삫躭ﺯ잱\ud9b3풵\uddb7좹鲻諾ꖿ뛁ꇃꗅ볇꿉꣋蓓뫕뷗믙꿛믝샟臡賣菥诧臩쳫韭鿯蟱蛳훵跷觹鷻駽旿∁欃怅⠇䜉挋樍甏縑䀓缕紗栙甛瀝䜟", a_));
			}
			for (;;)
			{
				this.bv = new global::System.Collections.Generic.List<string>();
				this.b3 = new global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.List<string>>();
				try
				{
					this.b0 = this.b();
					this.b1 = new global::SpecialFeatures.Flashport.FlashRadio.FlashcodeTable();
					this.b1.InitTable(false, modelNumber, false);
					this.bz = new global::System.Collections.Generic.Dictionary<string, bool>();
					this.b(flashCode);
					this.b2 = new global::AcpModelTieringLib.CModelTieringEngine(this.bw, this.bx, true, this.bz);
					break;
				}
				catch (global::System.Exception ex)
				{
					throw new global::System.Exception(ex.Message + global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("뒓肟쮡쪣蚥얩좫쮭\udcaf\uddb3펵쪷펹튻\ud9bd韁냃꿅꓇ꏉ룋럍金믓룕ꯗ껙껛ꯝ菟雡诣铥", a_));
				}
			}
		}

		// Token: 0x06000BA5 RID: 2981 RVA: 0x000E37B4 File Offset: 0x000E19B4
		public void FPSInitializeOrderedOptions(bool forComparedCodeplug = false)
		{
			short num = (short)34209792;
			short num2 = num;
			num = (short)961101445;
			short num3 = num;
			num = (short)1804615301;
			switch (num3 == num)
			{
			}
			num = (short)154140673;
			if (num != 0)
			{
			}
			num = (short)1161887744;
			if (num != 0)
			{
			}
			this.b1.InitTable(true, this.bu, forComparedCodeplug);
			this.a(forComparedCodeplug);
			this.b2 = new global::AcpModelTieringLib.CModelTieringEngine(this.bw, this.bx, true, this.bz);
			this.c();
		}

		// Token: 0x06000BA6 RID: 2982 RVA: 0x000E389C File Offset: 0x000E1A9C
		internal bool FindModel(string strModelNumber)
		{
			short num = (short)904462336;
			short num2 = num;
			num = (short)1616657047;
			short num3 = num;
			num = (short)990263959;
			switch (num3 == num)
			{
			}
			num = (short)1785069569;
			if (num != 0)
			{
			}
			num = (short)1960443904;
			if (num != 0)
			{
			}
			return this.b2.IsModelNumberValid(strModelNumber.Trim());
		}

		// Token: 0x06000BA7 RID: 2983 RVA: 0x000E3958 File Offset: 0x000E1B58
		internal bool IsOptionAvailableForModel(string strModelNumber, string strHOption)
		{
			short num = (short)1510211584;
			short num2 = num;
			num = (short)556421174;
			short num3 = num;
			num = (short)271601718;
			switch (num3 == num)
			{
			}
			num = (short)1584857089;
			if (num != 0)
			{
			}
			num = (short)1348272128;
			if (num != 0)
			{
			}
			return this.b2.IsOptionAvailableForModel(strModelNumber.Trim(), strHOption);
		}

		// Token: 0x06000BA8 RID: 2984 RVA: 0x000E3A14 File Offset: 0x000E1C14
		public void ApplyTieringForComparedMC()
		{
			short num = (short)721747968;
			switch (num)
			{
			default:
			{
				num = (short)1410007040;
				short num2 = num;
				num = (short)170524673;
				if (num != 0)
				{
				}
				global::System.Collections.Generic.IEnumerator<global::AcpCommonLib.IAcpRecordset> enumerator = global::AcpCommonLib.AppInfoManager.ComparatorDocument.Features.GetEnumerator();
				try
				{
					num = (short)168689667;
					int num3 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						global::AcpCommonLib.IAcpRecordset acpRecordset;
						global::AcpCommonLib.IAcpFeatureNode acpFeatureNode;
						global::System.Collections.Generic.IEnumerator<global::AcpCommonLib.IAcpFeatureSection> enumerator4;
						switch (num3)
						{
						case 0:
							acpFeatureNode = acpRecordset[0];
							num = (short)1452474370;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							if (acpRecordset.Count > 0)
							{
								num = (short)184745984;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							acpFeatureNode = ((global::AcpBusinessLayer.Recordset)acpRecordset).TemplateNode;
							num = (short)1927413770;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
							goto IL_D09;
						case 3:
							switch (0)
							{
							case 0:
								goto IL_D2;
							}
							continue;
						case 4:
							if (acpRecordset != null)
							{
								num = (short)1876492293;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						case 5:
						{
							num = (short)865023598;
							short num4 = num;
							num = (short)656291438;
							switch ((num4 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_C9B;
							default:
								num = (short)2041053184;
								if (num != 0)
								{
								}
								num = (short)1872297985;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 6:
							num = (short)1187905545;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 7:
							try
							{
								num = (short)1725366274;
								num3 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									global::AcpCommonLib.IAcpFeatureSection acpFeatureSection;
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode2;
									global::System.Collections.Generic.IEnumerator<global::AcpCommonLib.IAcpFeatureSection> enumerator2;
									global::System.Collections.Generic.IEnumerator<global::AcpCommonLib.IAcpField> enumerator3;
									switch (num3)
									{
									case 0:
										if (acpFeatureSection.EmbeddedRecset.Count > 0)
										{
											num = (short)1640955915;
											num3 = (int)((global::System.IntPtr)num);
											continue;
										}
										acpFeatureNode2 = ((global::AcpBusinessLayer.Recordset)acpFeatureSection.EmbeddedRecset).TemplateNode;
										num = (short)579469327;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									case 1:
										try
										{
											num = (short)21889032;
											num3 = (int)((global::System.IntPtr)num);
											for (;;)
											{
												global::AcpCommonLib.IAcpFeatureSection acpFeatureSection2;
												switch (num3)
												{
												case 0:
													if (!enumerator2.MoveNext())
													{
														num = (short)54984706;
														num3 = (int)((global::System.IntPtr)num);
														continue;
													}
													acpFeatureSection2 = enumerator2.Current;
													num = (short)1492189185;
													num3 = (int)((global::System.IntPtr)num);
													continue;
												case 1:
													if (this.bt != global::SpecialFeatures.Model_Configuration.ModelTiering.TargetTypes.ALL)
													{
														num = (short)1217658886;
														num3 = (int)((global::System.IntPtr)num);
														continue;
													}
													goto IL_421;
												case 2:
													num = (short)339542020;
													num3 = (int)((global::System.IntPtr)num);
													continue;
												case 3:
													goto IL_421;
												case 4:
													goto IL_7D9;
												case 5:
													if (this.bt == global::SpecialFeatures.Model_Configuration.ModelTiering.TargetTypes.FIELDS)
													{
														num = (short)1759576067;
														num3 = (int)((global::System.IntPtr)num);
														continue;
													}
													break;
												case 6:
													num = (short)1955921925;
													num3 = (int)((global::System.IntPtr)num);
													continue;
												case 7:
													try
													{
														num = (short)647888910;
														num3 = (int)((global::System.IntPtr)num);
														for (;;)
														{
															global::AcpCommonLib.IAcpField acpField;
															switch (num3)
															{
															case 0:
																goto IL_711;
															case 1:
															{
																this.b2.GetTieringData(acpField.Name);
																int initialize = this.b2.ModelTieringData.Initialize;
																num = (short)671416323;
																num3 = (int)((global::System.IntPtr)num);
																continue;
															}
															case 2:
															{
																int initialize = this.b2.ModelTieringData.Initialize;
																num = (short)1903689738;
																num3 = (int)((global::System.IntPtr)num);
																continue;
															}
															case 3:
															{
																int initialize;
																if (!initialize.Equals(1))
																{
																	num = (short)1866596354;
																	num3 = (int)((global::System.IntPtr)num);
																	continue;
																}
																goto IL_673;
															}
															case 4:
																num = (short)969474055;
																num3 = (int)((global::System.IntPtr)num);
																continue;
															case 5:
																goto IL_673;
															case 6:
																if (this.b2.TieredFields.Contains(acpField.Name))
																{
																	num = (short)1640038401;
																	num3 = (int)((global::System.IntPtr)num);
																	continue;
																}
																break;
															case 7:
																if (acpField is global::AcpBusinessLayer.AcpKeyField)
																{
																	num = (short)1678770185;
																	num3 = (int)((global::System.IntPtr)num);
																	continue;
																}
																break;
															case 8:
																num = (short)1921384448;
																num3 = (int)((global::System.IntPtr)num);
																continue;
															case 9:
																goto IL_54D;
															case 10:
															{
																int initialize;
																if (initialize.Equals(3))
																{
																	num = (short)1578303493;
																	num3 = (int)((global::System.IntPtr)num);
																	continue;
																}
																break;
															}
															case 12:
																if (!(acpField is global::AcpBusinessLayer.AcpStringField))
																{
																	num = (short)1632436228;
																	num3 = (int)((global::System.IntPtr)num);
																	continue;
																}
																goto IL_54D;
															case 13:
																if (!enumerator3.MoveNext())
																{
																	num = (short)429260808;
																	num3 = (int)((global::System.IntPtr)num);
																	continue;
																}
																acpField = enumerator3.Current;
																num = (short)965935110;
																num3 = (int)((global::System.IntPtr)num);
																continue;
															case 14:
																switch (0)
																{
																case 0:
																	goto IL_4F5;
																}
																continue;
															}
															goto IL_4F5;
															IL_54D:
															this.a(acpField, true);
															num = (short)731512843;
															num3 = (int)((global::System.IntPtr)num);
															continue;
															IL_5DA:
															num = (short)532086797;
															num3 = (int)((global::System.IntPtr)num);
															continue;
															IL_4F5:
															goto IL_5DA;
															IL_673:
															num = (short)938803212;
															num3 = (int)((global::System.IntPtr)num);
														}
														IL_711:;
													}
													finally
													{
														num = (short)290390018;
														num3 = (int)((global::System.IntPtr)num);
														for (;;)
														{
															switch (num3)
															{
															case 0:
																enumerator3.Dispose();
																num = (short)1391067137;
																num3 = (int)((global::System.IntPtr)num);
																continue;
															case 1:
																goto IL_77F;
															case 2:
																switch (0)
																{
																case 0:
																	goto IL_745;
																}
																continue;
															}
															IL_745:
															if (enumerator3 == null)
															{
																break;
															}
															num = (short)609943552;
															num3 = (int)((global::System.IntPtr)num);
														}
														IL_77F:;
													}
													break;
												case 8:
													switch (0)
													{
													case 0:
														goto IL_3E2;
													}
													continue;
												}
												goto IL_3E2;
												IL_421:
												enumerator3 = acpFeatureSection2.FieldsCollection.GetEnumerator();
												num = (short)789839879;
												num3 = (int)((global::System.IntPtr)num);
												continue;
												IL_782:
												num = (short)1048969216;
												num3 = (int)((global::System.IntPtr)num);
												continue;
												IL_3E2:
												goto IL_782;
											}
											IL_7D9:
											goto IL_8D2;
										}
										finally
										{
											num = (short)749469698;
											num3 = (int)((global::System.IntPtr)num);
											for (;;)
											{
												switch (num3)
												{
												case 0:
													enumerator2.Dispose();
													num = (short)1603862529;
													num3 = (int)((global::System.IntPtr)num);
													continue;
												case 1:
													goto IL_848;
												case 2:
													switch (0)
													{
													case 0:
														goto IL_810;
													}
													continue;
												}
												IL_810:
												if (enumerator2 == null)
												{
													break;
												}
												num = (short)1344339968;
												num3 = (int)((global::System.IntPtr)num);
											}
											IL_848:;
										}
										goto IL_84B;
									case 2:
										switch (0)
										{
										case 0:
											goto IL_215;
										}
										continue;
									case 3:
										if (acpFeatureSection.EmbeddedRecset != null)
										{
											num = (short)1983447048;
											num3 = (int)((global::System.IntPtr)num);
											continue;
										}
										goto IL_8D2;
									case 4:
										try
										{
											num = (short)329383950;
											num3 = (int)((global::System.IntPtr)num);
											for (;;)
											{
												global::AcpCommonLib.IAcpField acpField2;
												switch (num3)
												{
												case 0:
													goto IL_B89;
												case 1:
													num = (short)297926663;
													num3 = (int)((global::System.IntPtr)num);
													continue;
												case 3:
												{
													this.b2.GetTieringData(acpField2.Name);
													int initialize = this.b2.ModelTieringData.Initialize;
													num = (short)1047199754;
													num3 = (int)((global::System.IntPtr)num);
													continue;
												}
												case 4:
													num = (short)769064960;
													num3 = (int)((global::System.IntPtr)num);
													continue;
												case 5:
												{
													int initialize = this.b2.ModelTieringData.Initialize;
													num = (short)801308685;
													num3 = (int)((global::System.IntPtr)num);
													continue;
												}
												case 6:
													if (!(acpField2 is global::AcpBusinessLayer.AcpStringField))
													{
														num = (short)1892352001;
														num3 = (int)((global::System.IntPtr)num);
														continue;
													}
													goto IL_A3E;
												case 7:
													if (acpField2 is global::AcpBusinessLayer.AcpKeyField)
													{
														num = (short)237436937;
														num3 = (int)((global::System.IntPtr)num);
														continue;
													}
													break;
												case 8:
													goto IL_AB2;
												case 9:
													goto IL_A3E;
												case 10:
												{
													int initialize;
													if (!initialize.Equals(1))
													{
														num = (short)679542789;
														num3 = (int)((global::System.IntPtr)num);
														continue;
													}
													goto IL_AB2;
												}
												case 11:
													if (this.b2.TieredFields.Contains(acpField2.Name))
													{
														num = (short)1800208387;
														num3 = (int)((global::System.IntPtr)num);
														continue;
													}
													break;
												case 12:
													if (!enumerator3.MoveNext())
													{
														num = (short)1133379588;
														num3 = (int)((global::System.IntPtr)num);
														continue;
													}
													acpField2 = enumerator3.Current;
													num = (short)1648427019;
													num3 = (int)((global::System.IntPtr)num);
													continue;
												case 13:
												{
													int initialize;
													if (initialize.Equals(3))
													{
														num = (short)963706888;
														num3 = (int)((global::System.IntPtr)num);
														continue;
													}
													break;
												}
												case 14:
													switch (0)
													{
													case 0:
														goto IL_977;
													}
													continue;
												}
												goto IL_977;
												IL_A3E:
												this.a(acpField2, true);
												num = (short)811794434;
												num3 = (int)((global::System.IntPtr)num);
												continue;
												IL_AB2:
												num = (short)1483997190;
												num3 = (int)((global::System.IntPtr)num);
												continue;
												IL_AF1:
												num = (short)405602316;
												num3 = (int)((global::System.IntPtr)num);
												continue;
												IL_977:
												goto IL_AF1;
											}
											IL_B89:
											break;
										}
										finally
										{
											num = (short)2081292288;
											num3 = (int)((global::System.IntPtr)num);
											for (;;)
											{
												switch (num3)
												{
												case 0:
													switch (0)
													{
													case 0:
														goto IL_BC0;
													}
													continue;
												case 1:
													enumerator3.Dispose();
													num = (short)1126891522;
													num3 = (int)((global::System.IntPtr)num);
													continue;
												case 2:
													goto IL_BF7;
												}
												IL_BC0:
												if (enumerator3 == null)
												{
													break;
												}
												num = (short)1251213313;
												num3 = (int)((global::System.IntPtr)num);
											}
											IL_BF7:;
										}
										goto IL_BFA;
									case 5:
										goto IL_C13;
									case 6:
										num = (short)121176064;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									case 7:
										goto IL_258;
									case 8:
										num = (short)2018639886;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									case 9:
										goto IL_BFA;
									case 10:
										if (!enumerator4.MoveNext())
										{
											num = (short)541720585;
											num3 = (int)((global::System.IntPtr)num);
											continue;
										}
										acpFeatureSection = enumerator4.Current;
										num = (short)179896323;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									case 11:
										acpFeatureNode2 = acpFeatureSection.EmbeddedRecset[0];
										num = (short)1515847687;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									case 12:
										if (this.bt != global::SpecialFeatures.Model_Configuration.ModelTiering.TargetTypes.ALL)
										{
											num = (short)640286733;
											num3 = (int)((global::System.IntPtr)num);
											continue;
										}
										goto IL_369;
									case 13:
										goto IL_84B;
									case 14:
										if (acpFeatureSection.HasEmbeddedRecset)
										{
											num = (short)1006567430;
											num3 = (int)((global::System.IntPtr)num);
											continue;
										}
										goto IL_8D2;
									case 15:
										goto IL_258;
									case 16:
										goto IL_369;
									case 17:
										if (this.bt == global::SpecialFeatures.Model_Configuration.ModelTiering.TargetTypes.FIELDS)
										{
											num = (short)2752528;
											num3 = (int)((global::System.IntPtr)num);
											continue;
										}
										break;
									}
									IL_21A:
									num = (short)97976330;
									num3 = (int)((global::System.IntPtr)num);
									continue;
									IL_215:
									goto IL_21A;
									IL_258:
									enumerator2 = acpFeatureNode2.FeatureSectionsCollection.GetEnumerator();
									num = (short)1793064961;
									num3 = (int)((global::System.IntPtr)num);
									continue;
									IL_369:
									enumerator3 = acpFeatureSection.FieldsCollection.GetEnumerator();
									num = (short)452657156;
									num3 = (int)((global::System.IntPtr)num);
									continue;
									IL_84B:
									num = (short)1130233873;
									num3 = (int)((global::System.IntPtr)num);
									continue;
									IL_8D2:
									num = (short)1042350092;
									num3 = (int)((global::System.IntPtr)num);
									continue;
									IL_BFA:
									num = (short)368771077;
									num3 = (int)((global::System.IntPtr)num);
								}
								IL_C13:;
							}
							finally
							{
								num = (short)1161625600;
								num3 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									switch (num3)
									{
									case 0:
										switch (0)
										{
										case 0:
											goto IL_C48;
										}
										continue;
									case 1:
										enumerator4.Dispose();
										num = (short)1252786178;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									case 2:
										goto IL_C80;
									}
									IL_C48:
									if (enumerator4 == null)
									{
										break;
									}
									num = (short)1612316673;
									num3 = (int)((global::System.IntPtr)num);
								}
								IL_C80:;
							}
							break;
						case 8:
							goto IL_C9B;
						case 9:
							goto IL_D4C;
						case 10:
							goto IL_D09;
						}
						goto IL_D2;
						IL_C9B:
						if (!enumerator.MoveNext())
						{
							num = (short)515047430;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						acpRecordset = enumerator.Current;
						num = (short)1544880132;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_C83:
						num = (short)1334837256;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_D2:
						goto IL_C83;
						IL_D09:
						enumerator4 = acpFeatureNode.FeatureSectionsCollection.GetEnumerator();
						num = (short)1161953287;
						num3 = (int)((global::System.IntPtr)num);
					}
					IL_D4C:;
				}
				finally
				{
					num = (short)2139684864;
					int num3 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num3)
						{
						case 0:
							switch (0)
							{
							case 0:
								goto IL_D80;
							}
							continue;
						case 1:
							enumerator.Dispose();
							num = (short)1497235458;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
							goto IL_DB7;
						}
						IL_D80:
						if (enumerator == null)
						{
							break;
						}
						num = (short)676528129;
						num3 = (int)((global::System.IntPtr)num);
					}
					IL_DB7:;
				}
				return;
			}
			}
		}

		// Token: 0x06000BA9 RID: 2985 RVA: 0x000E4858 File Offset: 0x000E2A58
		public void ApplyTiering(bool bflashportApplyTiering = false)
		{
			int a_ = 17;
			short num = (short)827850752;
			switch (num)
			{
			default:
			{
				num = (short)1484062721;
				if (num != 0)
				{
				}
				global::System.Collections.Generic.IEnumerator<global::AcpCommonLib.IAcpRecordset> enumerator = global::AcpCommonLib.FeatureManager.Features.GetEnumerator();
				try
				{
					num = (short)1544159241;
					int num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						global::AcpCommonLib.IAcpFeatureNode acpFeatureNode;
						global::System.Collections.Generic.IEnumerator<global::AcpCommonLib.IAcpFeatureSection> enumerator3;
						switch (num2)
						{
						case 0:
						{
							global::AcpCommonLib.IAcpRecordset acpRecordset;
							if (acpRecordset.Count > 0)
							{
								num = (short)1844248593;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							acpFeatureNode = ((global::AcpBusinessLayer.Recordset)acpRecordset).TemplateNode;
							num = (short)1515978768;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 1:
							try
							{
								num = (short)613613581;
								num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									global::System.Collections.Generic.IEnumerator<global::AcpCommonLib.IAcpField> enumerator2;
									global::AcpCommonLib.IAcpFeatureSection acpFeatureSection;
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode2;
									global::System.Collections.Generic.IEnumerator<global::AcpCommonLib.IAcpFeatureSection> enumerator4;
									switch (num2)
									{
									case 0:
										if (this.bt == global::SpecialFeatures.Model_Configuration.ModelTiering.TargetTypes.RECORDSETS)
										{
											num = (short)928907281;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										goto IL_71C;
									case 1:
										num = (short)1347289111;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 2:
										try
										{
											num = (short)1645805576;
											num2 = (int)((global::System.IntPtr)num);
											for (;;)
											{
												switch (num2)
												{
												case 0:
												{
													if (bflashportApplyTiering)
													{
														num = (short)1388642317;
														num2 = (int)((global::System.IntPtr)num);
														continue;
													}
													global::AcpCommonLib.IAcpField acpField;
													this.a(acpField, false);
													num = (short)1013579792;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												case 1:
													if (this.bs == global::SpecialFeatures.Model_Configuration.ModelTiering.ActionTypes.NEW)
													{
														num = (short)2047672322;
														num2 = (int)((global::System.IntPtr)num);
														continue;
													}
													goto IL_37A;
												case 2:
												{
													global::AcpCommonLib.IAcpField acpField;
													acpField.ParseValueFrom(this.bu);
													num = (short)635109381;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												case 3:
													num = (short)951779328;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												case 5:
													goto IL_37A;
												case 6:
													goto IL_627;
												case 7:
													num = (short)1885470721;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												case 8:
													switch (0)
													{
													case 0:
														goto IL_375;
													}
													continue;
												case 9:
												{
													int initialize;
													if (initialize.Equals(3))
													{
														num = (short)311689226;
														num2 = (int)((global::System.IntPtr)num);
														continue;
													}
													break;
												}
												case 10:
												{
													global::AcpCommonLib.IAcpField acpField;
													this.a(acpField, false);
													num = (short)2080374788;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												case 11:
													num = (short)1478164486;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												case 12:
												{
													global::AcpCommonLib.IAcpField acpField;
													if (this.b2.TieredFields.Contains(acpField.Name))
													{
														num = (short)643235843;
														num2 = (int)((global::System.IntPtr)num);
														continue;
													}
													break;
												}
												case 13:
												{
													global::AcpCommonLib.IAcpField acpField;
													this.b2.GetTieringData(acpField.Name);
													int initialize = this.b2.ModelTieringData.Initialize;
													num = (short)1344864265;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												case 14:
												{
													global::AcpCommonLib.IAcpField acpField;
													if (acpField.Name.Equals(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("욓ﲗ펙쾟솣좥춧\ud8a9춫슭ﶯ\uddb1킳펵풷즻펽ꊿꟁ뛃駅觇溜﷍", a_)))
													{
														num = (short)1374748679;
														num2 = (int)((global::System.IntPtr)num);
														continue;
													}
													goto IL_37A;
												}
												case 15:
												{
													if (!enumerator2.MoveNext())
													{
														num = (short)1149501451;
														num2 = (int)((global::System.IntPtr)num);
														continue;
													}
													global::AcpCommonLib.IAcpField acpField = enumerator2.Current;
													num = (short)50069518;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												}
												goto IL_375;
												IL_37A:
												num = (short)809304076;
												num2 = (int)((global::System.IntPtr)num);
												continue;
												IL_490:
												num = (short)167728796;
												short num3 = num;
												num = (short)995055260;
												switch ((num3 == num) ? 1 : 0)
												{
												case 0:
												case 2:
													break;
												default:
													num = (short)196149248;
													if (num != 0)
													{
													}
													num = (short)1854275599;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												IL_375:
												goto IL_490;
											}
											IL_627:
											break;
										}
										finally
										{
											num = (short)1633615874;
											num2 = (int)((global::System.IntPtr)num);
											for (;;)
											{
												switch (num2)
												{
												case 0:
													goto IL_697;
												case 1:
													enumerator2.Dispose();
													num = (short)1781137408;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												case 2:
													switch (0)
													{
													case 0:
														goto IL_65F;
													}
													continue;
												}
												IL_65F:
												if (enumerator2 == null)
												{
													break;
												}
												num = (short)927006721;
												num2 = (int)((global::System.IntPtr)num);
											}
											IL_697:;
										}
										goto IL_69A;
									case 3:
										goto IL_69A;
									case 4:
										this.a(acpFeatureSection.EmbeddedRecset);
										num = (short)1198587918;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 5:
										goto IL_2A0;
									case 6:
										num = (short)1977810953;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 7:
										if (this.bt != global::SpecialFeatures.Model_Configuration.ModelTiering.TargetTypes.ALL)
										{
											num = (short)260112394;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										goto IL_1F5;
									case 8:
										if (!enumerator3.MoveNext())
										{
											num = (short)1338376198;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										acpFeatureSection = enumerator3.Current;
										num = (short)1112342543;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 9:
										goto IL_C93;
									case 10:
										num = (short)1849491477;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 11:
										if (this.bt != global::SpecialFeatures.Model_Configuration.ModelTiering.TargetTypes.ALL)
										{
											num = (short)37552131;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										goto IL_220;
									case 12:
										goto IL_1F5;
									case 13:
										switch (0)
										{
										case 0:
											goto IL_17A;
										}
										continue;
									case 14:
										goto IL_71C;
									case 15:
										if (acpFeatureSection.EmbeddedRecset != null)
										{
											num = (short)1998716929;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										goto IL_747;
									case 16:
										if (acpFeatureSection.EmbeddedRecset.Count > 0)
										{
											num = (short)106364948;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										acpFeatureNode2 = ((global::AcpBusinessLayer.Recordset)acpFeatureSection.EmbeddedRecset).TemplateNode;
										num = (short)1684799493;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 17:
										goto IL_220;
									case 18:
										num = (short)1984102416;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 19:
										try
										{
											num = (short)266272772;
											num2 = (int)((global::System.IntPtr)num);
											for (;;)
											{
												global::AcpCommonLib.IAcpFeatureSection acpFeatureSection2;
												switch (num2)
												{
												case 0:
													try
													{
														num = (short)1171324931;
														num2 = (int)((global::System.IntPtr)num);
														for (;;)
														{
															switch (num2)
															{
															case 0:
															{
																global::AcpCommonLib.IAcpField acpField2;
																this.b2.GetTieringData(acpField2.Name);
																int initialize = this.b2.ModelTieringData.Initialize;
																num = (short)1159725061;
																num2 = (int)((global::System.IntPtr)num);
																continue;
															}
															case 1:
															{
																if (bflashportApplyTiering)
																{
																	num = (short)670105600;
																	num2 = (int)((global::System.IntPtr)num);
																	continue;
																}
																global::AcpCommonLib.IAcpField acpField2;
																this.a(acpField2, false);
																num = (short)1297809416;
																num2 = (int)((global::System.IntPtr)num);
																continue;
															}
															case 2:
																goto IL_A94;
															case 3:
																switch (0)
																{
																case 0:
																	goto IL_8FE;
																}
																continue;
															case 4:
															{
																global::AcpCommonLib.IAcpField acpField2;
																if (this.b2.TieredFields.Contains(acpField2.Name))
																{
																	num = (short)879886345;
																	num2 = (int)((global::System.IntPtr)num);
																	continue;
																}
																break;
															}
															case 5:
															{
																int initialize;
																if (initialize.Equals(3))
																{
																	num = (short)239599622;
																	num2 = (int)((global::System.IntPtr)num);
																	continue;
																}
																break;
															}
															case 6:
															{
																global::AcpCommonLib.IAcpField acpField2;
																this.a(acpField2, false);
																num = (short)1107623946;
																num2 = (int)((global::System.IntPtr)num);
																continue;
															}
															case 7:
															{
																if (!enumerator2.MoveNext())
																{
																	num = (short)692977675;
																	num2 = (int)((global::System.IntPtr)num);
																	continue;
																}
																global::AcpCommonLib.IAcpField acpField2 = enumerator2.Current;
																num = (short)2122252292;
																num2 = (int)((global::System.IntPtr)num);
																continue;
															}
															case 9:
																num = (short)468910081;
																num2 = (int)((global::System.IntPtr)num);
																continue;
															case 11:
																num = (short)1373306882;
																num2 = (int)((global::System.IntPtr)num);
																continue;
															}
															IL_900:
															num = (short)898236423;
															num2 = (int)((global::System.IntPtr)num);
															continue;
															IL_8FE:
															goto IL_900;
														}
														IL_A94:
														break;
													}
													finally
													{
														num = (short)1964572674;
														num2 = (int)((global::System.IntPtr)num);
														for (;;)
														{
															switch (num2)
															{
															case 0:
																goto IL_B03;
															case 1:
																enumerator2.Dispose();
																num = (short)1209270272;
																num2 = (int)((global::System.IntPtr)num);
																continue;
															case 2:
																switch (0)
																{
																case 0:
																	goto IL_ACB;
																}
																continue;
															}
															IL_ACB:
															if (enumerator2 == null)
															{
																break;
															}
															num = (short)488505345;
															num2 = (int)((global::System.IntPtr)num);
														}
														IL_B03:;
													}
													goto IL_B06;
												case 1:
													goto IL_BCB;
												case 2:
													goto IL_B06;
												case 3:
													num = (short)1624113153;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												case 4:
													switch (0)
													{
													case 0:
														goto IL_85D;
													}
													continue;
												case 5:
													if (!enumerator4.MoveNext())
													{
														num = (short)1895170051;
														num2 = (int)((global::System.IntPtr)num);
														continue;
													}
													acpFeatureSection2 = enumerator4.Current;
													num = (short)2080243720;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												case 6:
													if (this.bt == global::SpecialFeatures.Model_Configuration.ModelTiering.TargetTypes.FIELDS)
													{
														num = (short)1303969799;
														num2 = (int)((global::System.IntPtr)num);
														continue;
													}
													break;
												case 7:
													goto IL_B86;
												case 8:
													if (this.bt != global::SpecialFeatures.Model_Configuration.ModelTiering.TargetTypes.ALL)
													{
														num = (short)1169031170;
														num2 = (int)((global::System.IntPtr)num);
														continue;
													}
													goto IL_B86;
												}
												goto IL_85D;
												IL_B06:
												num = (short)876347398;
												num2 = (int)((global::System.IntPtr)num);
												continue;
												IL_B47:
												num = (short)1429667845;
												num2 = (int)((global::System.IntPtr)num);
												continue;
												IL_85D:
												goto IL_B47;
												IL_B86:
												enumerator2 = acpFeatureSection2.FieldsCollection.GetEnumerator();
												num = (short)1757544448;
												num2 = (int)((global::System.IntPtr)num);
											}
											IL_BCB:
											goto IL_747;
										}
										finally
										{
											num = (short)1268187138;
											num2 = (int)((global::System.IntPtr)num);
											for (;;)
											{
												switch (num2)
												{
												case 0:
													goto IL_C3B;
												case 1:
													enumerator4.Dispose();
													num = (short)1206452224;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												case 2:
													switch (0)
													{
													case 0:
														goto IL_C03;
													}
													continue;
												}
												IL_C03:
												if (enumerator4 == null)
												{
													break;
												}
												num = (short)891092993;
												num2 = (int)((global::System.IntPtr)num);
											}
											IL_C3B:;
										}
										break;
									case 20:
										acpFeatureNode2 = acpFeatureSection.EmbeddedRecset[0];
										num = (short)299892758;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 21:
										if (this.bt == global::SpecialFeatures.Model_Configuration.ModelTiering.TargetTypes.FIELDS)
										{
											num = (short)892993548;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										break;
									case 22:
										goto IL_2A0;
									case 23:
										if (acpFeatureSection.HasEmbeddedRecset)
										{
											num = (short)1208418322;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										goto IL_747;
									case 24:
										if (this.b2.TieredRecordsets.Contains(acpFeatureSection.EmbeddedRecset.ToString()))
										{
											num = (short)1791164420;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										goto IL_71C;
									}
									goto IL_17A;
									IL_1F5:
									enumerator2 = acpFeatureSection.FieldsCollection.GetEnumerator();
									num = (short)1913454594;
									num2 = (int)((global::System.IntPtr)num);
									continue;
									IL_220:
									num = (short)890306584;
									num2 = (int)((global::System.IntPtr)num);
									continue;
									IL_2A0:
									num = (short)297336843;
									num2 = (int)((global::System.IntPtr)num);
									continue;
									IL_69A:
									num = (short)206766080;
									num2 = (int)((global::System.IntPtr)num);
									continue;
									IL_71C:
									enumerator4 = acpFeatureNode2.FeatureSectionsCollection.GetEnumerator();
									num = (short)166395923;
									num2 = (int)((global::System.IntPtr)num);
									continue;
									IL_747:
									num = (short)1673003015;
									num2 = (int)((global::System.IntPtr)num);
									continue;
									IL_C3E:
									num = (short)1460535304;
									num2 = (int)((global::System.IntPtr)num);
									continue;
									IL_17A:
									goto IL_C3E;
								}
								IL_C93:
								break;
							}
							finally
							{
								num = (short)667680769;
								num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									switch (num2)
									{
									case 0:
										goto IL_D01;
									case 1:
										switch (0)
										{
										case 0:
											goto IL_CCB;
										}
										continue;
									case 2:
										enumerator3.Dispose();
										num = (short)174784512;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									IL_CCB:
									if (enumerator3 == null)
									{
										break;
									}
									num = (short)1542389762;
									num2 = (int)((global::System.IntPtr)num);
								}
								IL_D01:;
							}
							goto IL_D04;
						case 2:
						{
							if (!enumerator.MoveNext())
							{
								num = (short)1220476931;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::AcpCommonLib.IAcpRecordset acpRecordset = enumerator.Current;
							num = (short)1417412622;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 3:
							num = (short)1493172231;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 4:
							goto IL_D45;
						case 5:
							goto IL_D04;
						case 6:
							if (this.bt != global::SpecialFeatures.Model_Configuration.ModelTiering.TargetTypes.ALL)
							{
								num = (short)1561919499;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_DAF;
						case 7:
							goto IL_F29;
						case 8:
						{
							global::AcpCommonLib.IAcpRecordset acpRecordset;
							this.a(acpRecordset);
							num = (short)1203175428;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 9:
							switch (0)
							{
							case 0:
								goto IL_C7;
							}
							continue;
						case 10:
							if (this.bt == global::SpecialFeatures.Model_Configuration.ModelTiering.TargetTypes.RECORDSETS)
							{
								num = (short)1083572236;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_D45;
						case 11:
							num = (short)1701773322;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 12:
							goto IL_DAF;
						case 13:
							goto IL_E4B;
						case 14:
						{
							global::AcpCommonLib.IAcpRecordset acpRecordset;
							if (acpRecordset != null)
							{
								num = (short)249430021;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 15:
						{
							global::AcpCommonLib.IAcpRecordset acpRecordset;
							if (this.b2.TieredRecordsets.Contains(acpRecordset.ToString()))
							{
								num = (short)90177544;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_D45;
						}
						case 16:
							goto IL_E4B;
						case 17:
						{
							global::AcpCommonLib.IAcpRecordset acpRecordset;
							acpFeatureNode = acpRecordset[0];
							num = (short)621674509;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						goto IL_C7;
						IL_D04:
						num = (short)39387136;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_D45:
						enumerator3 = acpFeatureNode.FeatureSectionsCollection.GetEnumerator();
						num = (short)692322305;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_D6F:
						num = (short)1285357570;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_C7:
						goto IL_D6F;
						IL_DAF:
						num = (short)1235877903;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_E4B:
						num = (short)1531314182;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_F29:;
				}
				finally
				{
					num = (short)1412956161;
					int num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
							goto IL_F92;
						case 1:
							switch (0)
							{
							case 0:
								goto IL_F5D;
							}
							continue;
						case 2:
							enumerator.Dispose();
							num = (short)989593600;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_F5D:
						if (enumerator == null)
						{
							break;
						}
						num = (short)92471298;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_F92:;
				}
				num = (short)475463680;
				short num4 = num;
				return;
			}
			}
		}

		// Token: 0x06000BAA RID: 2986 RVA: 0x000E58A4 File Offset: 0x000E3AA4
		public void ApplyTieringForVirtualFields()
		{
			short num = (short)1494024195;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				global::AcpCommonLib.IAcpRecordset acpRecordset;
				global::AcpCommonLib.IAcpRecordset acpRecordset2;
				global::AcpCommonLib.IAcpField[] array;
				global::AcpCommonLib.IAcpField[] array2;
				switch (num2)
				{
				case 0:
					acpRecordset = null;
					goto IL_7D;
				case 1:
					if (acpRecordset2.Count == 0)
					{
						num = (short)1615134726;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1445789707;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					num = (short)1808859137;
					if (num != 0)
					{
					}
					array = null;
					goto IL_1F9;
				case 3:
					switch (0)
					{
					case 0:
						goto IL_54;
					}
					continue;
				case 4:
					num = (short)1866203137;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
				{
					num = (short)1892220928;
					short num3 = num;
					array = null;
					goto IL_1F9;
				}
				case 6:
					return;
				case 7:
					array = null;
					goto IL_1F9;
				case 8:
					array2 = global::System.Array.Empty<global::AcpCommonLib.IAcpField>();
					goto IL_21E;
				case 9:
					goto IL_23B;
				case 10:
					if (acpRecordset2 != null)
					{
						num = (short)1888092164;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 11:
				{
					global::System.Collections.Generic.IEnumerable<global::AcpCommonLib.IAcpFeatureSection> featureSectionsCollection = acpRecordset2[0].FeatureSectionsCollection;
					if (featureSectionsCollection == null)
					{
						num = (short)443547650;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					global::AcpCommonLib.IAcpFeatureSection acpFeatureSection = featureSectionsCollection.FirstOrDefault<global::AcpCommonLib.IAcpFeatureSection>();
					if (acpFeatureSection == null)
					{
						num = (short)516751367;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					global::System.Collections.Generic.IEnumerable<global::AcpCommonLib.IAcpField> fieldsCollection = acpFeatureSection.FieldsCollection;
					if (fieldsCollection == null)
					{
						num = (short)1187250181;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					array = fieldsCollection.Where(delegate(global::AcpCommonLib.IAcpField c)
					{
						short num5 = (short)2136726457;
						short num6 = num5;
						num5 = (short)1727650745;
						switch (num6 == num5)
						{
						}
						num5 = (short)1272840193;
						if (num5 != 0)
						{
						}
						num5 = (short)1283653632;
						if (num5 != 0)
						{
						}
						num5 = (short)1464991744;
						short num7 = num5;
						return global::SpecialFeatures.Model_Configuration.ModelTiering.br.Contains(c.Name);
					});
					goto IL_1F9;
				}
				}
				IL_54:
				global::System.Collections.Generic.IEnumerable<global::AcpCommonLib.IAcpRecordset> features = global::AcpCommonLib.FeatureManager.Features;
				if (features == null)
				{
					num = (short)1163198464;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				acpRecordset = features.FirstOrDefault<global::AcpCommonLib.IAcpRecordset>();
				IL_7D:
				acpRecordset2 = acpRecordset;
				num = (short)1240137738;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_1F9:
				if ((array2 = array) == null)
				{
					num = (short)95813640;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_21E:
				global::System.Collections.Generic.IEnumerator<global::AcpCommonLib.IAcpField> enumerator = array2.GetEnumerator();
				num = (short)120193033;
				num2 = (int)((global::System.IntPtr)num);
			}
			return;
			IL_23B:
			try
			{
				num = (short)1462435840;
				num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						switch (0)
						{
						case 0:
							goto IL_27D;
						}
						continue;
					case 1:
					{
						global::AcpCommonLib.IAcpField acpField;
						this.a(acpField, false);
						num = (short)1691353094;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
					{
						global::System.Collections.Generic.IEnumerator<global::AcpCommonLib.IAcpField> enumerator;
						if (!enumerator.MoveNext())
						{
							num = (short)1489305603;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::AcpCommonLib.IAcpField acpField = enumerator.Current;
						num = (short)1061093381;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 3:
						num = (short)1760428036;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						goto IL_33E;
					case 5:
					{
						global::AcpCommonLib.IAcpField acpField;
						if (this.b2.TieredFields.Contains(acpField.Name))
						{
							num = (short)389283841;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					}
					IL_2EA:
					num = (short)946274306;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_27D:
					goto IL_2EA;
				}
				IL_33E:;
			}
			finally
			{
				for (;;)
				{
					IL_343:
					num = (short)125108225;
					num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						global::System.Collections.Generic.IEnumerator<global::AcpCommonLib.IAcpField> enumerator;
						switch (num2)
						{
						case 0:
							goto IL_3F4;
						case 1:
						{
							num = (short)65771479;
							short num4 = num;
							num = (short)239769559;
							switch ((num4 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_343;
							default:
								num = (short)362020864;
								if (num != 0)
								{
								}
								switch (0)
								{
								case 0:
									goto IL_3BF;
								}
								continue;
							}
							break;
						}
						case 2:
							enumerator.Dispose();
							num = (short)517472256;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_3BF:
						if (enumerator == null)
						{
							goto IL_3F6;
						}
						num = (short)1486946306;
						num2 = (int)((global::System.IntPtr)num);
					}
				}
				IL_3F4:
				IL_3F6:;
			}
		}

		// Token: 0x06000BAB RID: 2987 RVA: 0x000E5CC4 File Offset: 0x000E3EC4
		internal int GetRecordsetDataFromEngine(string strFullyQualifiedRecordsetName, global::SpecialFeatures.Model_Configuration.ModelTiering.RecsetAttributeTypes attributeToRetrieve)
		{
			int a_ = 0;
			short num = (short)2103771137;
			if (num != 0)
			{
			}
			switch (0)
			{
			case 0:
				goto IL_4D;
			}
			int num2;
			int result;
			for (;;)
			{
				IL_3B:
				switch (num2)
				{
				case 0:
					try
					{
						switch (0)
						{
						case 0:
							goto IL_DB;
						}
						for (;;)
						{
							IL_B5:
							switch (num2)
							{
							case 0:
								switch (attributeToRetrieve)
								{
								case global::SpecialFeatures.Model_Configuration.ModelTiering.RecsetAttributeTypes.MaxRecords:
									result = this.b2.ModelTieringData.MaxRecords;
									num = (short)721813508;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case global::SpecialFeatures.Model_Configuration.ModelTiering.RecsetAttributeTypes.MaxPoolRecords:
									result = this.b2.ModelTieringData.MaxPoolRecords;
									num = (short)938082305;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case global::SpecialFeatures.Model_Configuration.ModelTiering.RecsetAttributeTypes.MinRecords:
									result = this.b2.ModelTieringData.MinRecords;
									num = (short)1845559301;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case global::SpecialFeatures.Model_Configuration.ModelTiering.RecsetAttributeTypes.DefaultRecords:
									result = this.b2.ModelTieringData.DefaultRecords;
									num = (short)301400071;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								default:
									num = (short)518062086;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							case 1:
							{
								num = (short)1169906197;
								short num3 = num;
								num = (short)2075286037;
								switch ((num3 == num) ? 1 : 0)
								{
								case 0:
								case 2:
									continue;
								default:
									num = (short)2023882752;
									if (num != 0)
									{
									}
									goto IL_242;
								}
								break;
							}
							case 2:
								goto IL_242;
							case 3:
								goto IL_259;
							case 4:
								goto IL_242;
							case 5:
								goto IL_242;
							case 6:
								num = (short)1842872322;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 7:
								goto IL_242;
							}
							goto IL_DB;
							IL_242:
							num = (short)823787523;
							num2 = (int)((global::System.IntPtr)num);
						}
						IL_259:
						return result;
						IL_DB:
						this.b2.GetTieringData(strFullyQualifiedRecordsetName);
						num = (short)1727791104;
						num2 = (int)((global::System.IntPtr)num);
						goto IL_B5;
					}
					catch (global::System.Exception)
					{
						throw new global::System.Exception(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("욂力람꾎쎐ﮞ膠잢쒤펦좨讪캬캮\udfb0\uddb2\udab4쎶馸\ud9ba\ud8bc龾Ꟁ곂냄꧆귈", a_));
					}
					goto IL_270;
				case 1:
					if (attributeToRetrieve == global::SpecialFeatures.Model_Configuration.ModelTiering.RecsetAttributeTypes.Visibility)
					{
						num = (short)2138963970;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_270;
				case 2:
					goto IL_A6;
				}
				goto IL_4D;
				IL_270:
				num = (short)150011904;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_A6:
			throw new global::System.Exception(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("삂歷꾎붜ﺞ쾠莢첤즦\udda8讪쮬삮쎰鎲", a_) + attributeToRetrieve.ToString() + global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("ꎂꦈ첊ﮎ쎐ﾚ爵햠쒤펦좨\udfac삮\udcb0\udbb4킶킸햺\ud8bc", a_));
			IL_4D:
			num = (short)411697152;
			short num4 = num;
			result = -1;
			num = (short)507248641;
			num2 = (int)((global::System.IntPtr)num);
			goto IL_3B;
		}

		// Token: 0x06000BAC RID: 2988 RVA: 0x000E5FB4 File Offset: 0x000E41B4
		internal bool GetRecordsetVisibilityFromEngine(string strFullyQualifiedRecordsetName, global::SpecialFeatures.Model_Configuration.ModelTiering.RecsetAttributeTypes attributeToRetrieve)
		{
			int a_ = 9;
			short num = (short)2112028672;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
				{
					num = (short)821532163;
					short num3 = num;
					num = (short)298817027;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_126;
					default:
					{
						num = (short)1902706688;
						short num4 = num;
						num = (short)1771044864;
						if (num != 0)
						{
						}
						num = (short)1465647105;
						if (num != 0)
						{
						}
						switch (0)
						{
						case 0:
							goto IL_D7;
						}
						continue;
					}
					}
					break;
				}
				case 1:
					try
					{
						this.b2.GetTieringData(strFullyQualifiedRecordsetName);
						return this.b2.ModelTieringData.IsVisible;
					}
					catch (global::System.Exception)
					{
						throw new global::System.Exception(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("즋ﲍ﶑겕뢗좙鍊햟쮡횣쎥첧誩좫쾭쒯펱钳햵\ud9b7풹튻톽뒿ꛃꏅ곉ꏋ믍뻏뛑䀘", a_));
					}
					goto IL_125;
				case 2:
					goto IL_EF;
				}
				IL_D7:
				if (attributeToRetrieve != global::SpecialFeatures.Model_Configuration.ModelTiering.RecsetAttributeTypes.Visibility)
				{
					num = (short)1403977730;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_126:
				num = (short)1944256513;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_125:
				goto IL_126;
			}
			IL_EF:
			throw new global::System.Exception(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쾋ﺏﲑﮓ뢗鍊햟킡쪣蚥즧誩캫솭\udfaf\udeb1톳ힵ횷骹\udabb톽늿", a_) + attributeToRetrieve.ToString() + global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("겋ﺏ늑펓좙鍊ﶝ쾟킡삣향춧\udea9磌잭쎯\udbb1횳\udfb5풷펹좻잽蚿냁ꯃꯅ跇꓉ꯋꟍ뻏럑", a_));
		}

		// Token: 0x06000BAD RID: 2989 RVA: 0x000E6144 File Offset: 0x000E4344
		public void UpdateUtilityMackModelType()
		{
			int a_ = 13;
			short num2;
			try
			{
				for (;;)
				{
					IL_09:
					switch (0)
					{
					case 0:
						goto IL_4D;
					}
					int num;
					string text;
					for (;;)
					{
						IL_13:
						switch (num)
						{
						case 0:
							global::ConstraintHelper.UtilityMack.ReinitializeAndSetFlagsBasedOnModel(0, this.bu);
							num2 = (short)1815805957;
							num = (int)((global::System.IntPtr)num2);
							continue;
						case 1:
							if (text.ToUpper() == global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("삏\udd91욓슕\ud997\ud899킛\udb9d", a_))
							{
								num2 = (short)890503168;
								num = (int)((global::System.IntPtr)num2);
								continue;
							}
							goto IL_14C;
						case 2:
							if (this.b2 != null)
							{
								num2 = (short)53870602;
								num = (int)((global::System.IntPtr)num2);
								continue;
							}
							num2 = (short)2059403276;
							num = (int)((global::System.IntPtr)num2);
							continue;
						case 3:
							if (text.ToUpper() == global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udd8f\udd91횓\udf95풗\udf99", a_))
							{
								num2 = (short)242024456;
								num = (int)((global::System.IntPtr)num2);
								continue;
							}
							num2 = (short)724369409;
							num = (int)((global::System.IntPtr)num2);
							continue;
						case 4:
							goto IL_1A5;
						case 5:
							goto IL_26D;
						case 6:
							goto IL_26D;
						case 7:
						{
							num2 = (short)622019517;
							short num3 = num2;
							num2 = (short)1908753341;
							switch ((num3 == num2) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_09;
							default:
								num2 = (short)1382678528;
								if (num2 != 0)
								{
								}
								text = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udd8f\udd91횓\udf95풗\udf99", a_);
								num2 = (short)1011744772;
								num = (int)((global::System.IntPtr)num2);
								continue;
							}
							break;
						}
						case 8:
							global::ConstraintHelper.UtilityMack.ReinitializeAndSetFlagsBasedOnModel(1, this.bu);
							num2 = (short)1688666118;
							num = (int)((global::System.IntPtr)num2);
							continue;
						case 9:
							goto IL_286;
						case 10:
							text = this.b2.GetModelNumberType(this.bu);
							num2 = (short)822542347;
							num = (int)((global::System.IntPtr)num2);
							continue;
						case 11:
							goto IL_1A5;
						case 12:
							if (this.IsModelMobile)
							{
								num2 = (short)562888711;
								num = (int)((global::System.IntPtr)num2);
								continue;
							}
							goto IL_1A5;
						}
						break;
						IL_1A5:
						num2 = (short)424738819;
						num = (int)((global::System.IntPtr)num2);
						continue;
						IL_26D:
						num2 = (short)496762889;
						num = (int)((global::System.IntPtr)num2);
					}
					IL_4D:
					text = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("삏\udd91욓슕\ud997\ud899킛\udb9d", a_);
					num2 = (short)1020198914;
					num = (int)((global::System.IntPtr)num2);
					goto IL_13;
				}
				IL_14C:
				throw new global::System.Exception();
				IL_286:;
			}
			catch
			{
				throw new global::System.Exception(global::CommonResources.AcgResources.ID_UNABLETODETERMINERADIOMODELTYPE);
			}
			num2 = (short)2107834369;
			if (num2 != 0)
			{
			}
			num2 = (short)1118633984;
			short num4 = num2;
		}

		// Token: 0x06000BAE RID: 2990 RVA: 0x000E6450 File Offset: 0x000E4650
		internal void RestoreUtilityMackIfErrorOccurs(bool bIsMobile)
		{
			int a_ = 16;
			short num;
			try
			{
				num = (short)897581058;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					num = (short)957717269;
					short num3 = num;
					num = (short)1623104277;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num = (short)248709120;
						if (num != 0)
						{
						}
						switch (num2)
						{
						case 0:
							goto IL_116;
						case 1:
							global::ConstraintHelper.UtilityMack.ReinitializeAndSetFlagsBasedOnModel(0, this.bu);
							num = (short)1247543296;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
							num = (short)532348929;
							if (num != 0)
							{
							}
							switch (0)
							{
							case 0:
								goto IL_B2;
							}
							continue;
						case 3:
							goto IL_12D;
						case 4:
							goto IL_116;
						}
						break;
						IL_116:
						num = (short)559677443;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_B2:
					if (!bIsMobile)
					{
						num = (short)1703673857;
						num2 = (int)((global::System.IntPtr)num);
					}
					else
					{
						global::ConstraintHelper.UtilityMack.ReinitializeAndSetFlagsBasedOnModel(1, this.bu);
						num = (short)189857796;
						num2 = (int)((global::System.IntPtr)num);
					}
				}
				IL_12D:;
			}
			catch
			{
				throw new global::System.Exception(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\uda92ﮔﮞ膠삢쪤즦춨슪\ud9ac욮\udeb0\uddb2閴톶횸즺鶼뗀ꫂ꧄껆뷈닊苎냐냒뻔ﯖ律맚닜ꯞ觠쏢裤裦跨軪臬쿮藰諲藴鋶\ud9f8雺飼鋾挀昂眄理⤈樊缌樎ㄐ甒琔笖樘縚", a_));
			}
			num = (short)395444224;
			short num4 = num;
		}

		// Token: 0x06000BAF RID: 2991 RVA: 0x000E65E8 File Offset: 0x000E47E8
		internal void RecrefFixup1()
		{
			short num = (short)2078736384;
			switch (num)
			{
			default:
			{
				num = (short)191365120;
				short num2 = num;
				global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.List<string>>.Enumerator enumerator = this.b3.GetEnumerator();
				try
				{
					num = (short)1226637314;
					int num3 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num3)
						{
						case 0:
							goto IL_BD5;
						case 1:
							try
							{
								num = (short)2034630663;
								num3 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									switch (num3)
									{
									case 0:
										num = (short)2069889033;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									case 1:
									{
										global::System.Collections.Generic.IEnumerator<global::AcpCommonLib.IAcpRecordset> enumerator2;
										if (!enumerator2.MoveNext())
										{
											num = (short)1702297603;
											num3 = (int)((global::System.IntPtr)num);
											continue;
										}
										global::AcpCommonLib.IAcpRecordset acpRecordset = enumerator2.Current;
										bool flag = false;
										num = (short)267124741;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 2:
									{
										global::AcpCommonLib.IAcpRecordset acpRecordset;
										global::System.Collections.Generic.IEnumerator<global::AcpCommonLib.IAcpFeatureSection> enumerator3 = acpRecordset[0].FeatureSectionsCollection.GetEnumerator();
										num = (short)1621032966;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 3:
										goto IL_B48;
									case 4:
										goto IL_B62;
									case 5:
									{
										global::AcpCommonLib.IAcpRecordset acpRecordset;
										global::System.Collections.Generic.KeyValuePair<string, global::System.Collections.Generic.List<string>> keyValuePair;
										if (acpRecordset.RecordsetName == keyValuePair.Value[keyValuePair.Value.Count - 1])
										{
											num = (short)355401730;
											num3 = (int)((global::System.IntPtr)num);
											continue;
										}
										break;
									}
									case 6:
										try
										{
											num = (short)766377987;
											num3 = (int)((global::System.IntPtr)num);
											for (;;)
											{
												switch (num3)
												{
												case 0:
												{
													global::AcpCommonLib.IAcpFeatureSection acpFeatureSection;
													if (acpFeatureSection.EmbeddedRecset != null)
													{
														num = (short)928907266;
														num3 = (int)((global::System.IntPtr)num);
														continue;
													}
													goto IL_7CB;
												}
												case 1:
													try
													{
														num = (short)2028535814;
														num3 = (int)((global::System.IntPtr)num);
														for (;;)
														{
															switch (num3)
															{
															case 0:
																num = (short)530907141;
																num3 = (int)((global::System.IntPtr)num);
																continue;
															case 1:
																num = (short)618594311;
																num3 = (int)((global::System.IntPtr)num);
																continue;
															case 2:
															{
																global::System.Collections.Generic.IEnumerator<global::AcpCommonLib.IAcpField> enumerator4;
																if (!enumerator4.MoveNext())
																{
																	num = (short)905773056;
																	num3 = (int)((global::System.IntPtr)num);
																	continue;
																}
																global::AcpCommonLib.IAcpField acpField = enumerator4.Current;
																num = (short)1809055752;
																num3 = (int)((global::System.IntPtr)num);
																continue;
															}
															case 3:
																goto IL_A26;
															case 4:
															{
																global::AcpCommonLib.IAcpField acpField;
																this.a(acpField, false);
																bool flag;
																bool flag2 = flag = true;
																num = (short)478347267;
																num3 = (int)((global::System.IntPtr)num);
																continue;
															}
															case 5:
																goto IL_A45;
															case 6:
																switch (0)
																{
																case 0:
																	goto IL_923;
																}
																continue;
															case 7:
															{
																global::AcpCommonLib.IAcpField acpField;
																if (this.b2.TieredFields.Contains(acpField.Name))
																{
																	num = (short)375062532;
																	num3 = (int)((global::System.IntPtr)num);
																	continue;
																}
																break;
															}
															case 8:
															{
																global::System.Collections.Generic.KeyValuePair<string, global::System.Collections.Generic.List<string>> keyValuePair;
																global::AcpCommonLib.IAcpField acpField;
																if (acpField.Name == keyValuePair.Key)
																{
																	num = (short)788398081;
																	num3 = (int)((global::System.IntPtr)num);
																	continue;
																}
																break;
															}
															}
															IL_925:
															num = (short)1153302530;
															num3 = (int)((global::System.IntPtr)num);
															continue;
															IL_923:
															goto IL_925;
														}
														IL_A26:
														IL_A45:
														goto IL_7CB;
													}
													finally
													{
														num = (short)692649984;
														num3 = (int)((global::System.IntPtr)num);
														for (;;)
														{
															global::System.Collections.Generic.IEnumerator<global::AcpCommonLib.IAcpField> enumerator4;
															switch (num3)
															{
															case 0:
																switch (0)
																{
																case 0:
																	goto IL_A7E;
																}
																continue;
															case 1:
																goto IL_AB6;
															case 2:
																enumerator4.Dispose();
																num = (short)939261953;
																num3 = (int)((global::System.IntPtr)num);
																continue;
															}
															IL_A7E:
															if (enumerator4 == null)
															{
																break;
															}
															num = (short)723910658;
															num3 = (int)((global::System.IntPtr)num);
														}
														IL_AB6:;
													}
													goto IL_AB9;
												case 2:
													num = (short)496959500;
													num3 = (int)((global::System.IntPtr)num);
													continue;
												case 3:
													switch (0)
													{
													case 0:
														goto IL_2E5;
													}
													continue;
												case 4:
												{
													bool flag2;
													if (flag2)
													{
														num = (short)527958029;
														num3 = (int)((global::System.IntPtr)num);
														continue;
													}
													break;
												}
												case 5:
												{
													global::AcpCommonLib.IAcpFeatureSection acpFeatureSection;
													global::System.Collections.Generic.IEnumerator<global::AcpCommonLib.IAcpFeatureSection> enumerator5 = acpFeatureSection.EmbeddedRecset[0].FeatureSectionsCollection.GetEnumerator();
													num = (short)2137718791;
													num3 = (int)((global::System.IntPtr)num);
													continue;
												}
												case 6:
												{
													global::System.Collections.Generic.KeyValuePair<string, global::System.Collections.Generic.List<string>> keyValuePair;
													if (keyValuePair.Value.Count > 1)
													{
														num = (short)1345191946;
														num3 = (int)((global::System.IntPtr)num);
														continue;
													}
													global::AcpCommonLib.IAcpFeatureSection acpFeatureSection;
													global::System.Collections.Generic.IEnumerator<global::AcpCommonLib.IAcpField> enumerator4 = acpFeatureSection.FieldsCollection.GetEnumerator();
													num = (short)55705601;
													num3 = (int)((global::System.IntPtr)num);
													continue;
												}
												case 7:
													try
													{
														num = (short)245497863;
														num3 = (int)((global::System.IntPtr)num);
														for (;;)
														{
															switch (num3)
															{
															case 0:
																goto IL_6BA;
															case 1:
																try
																{
																	num = (short)812777478;
																	num3 = (int)((global::System.IntPtr)num);
																	for (;;)
																	{
																		switch (num3)
																		{
																		case 0:
																		{
																			global::AcpCommonLib.IAcpField acpField2;
																			this.a(acpField2, false);
																			bool flag;
																			bool flag2 = flag = true;
																			num = (short)707919875;
																			num3 = (int)((global::System.IntPtr)num);
																			continue;
																		}
																		case 1:
																			num = (short)229638149;
																			num3 = (int)((global::System.IntPtr)num);
																			continue;
																		case 2:
																		{
																			global::System.Collections.Generic.KeyValuePair<string, global::System.Collections.Generic.List<string>> keyValuePair;
																			global::AcpCommonLib.IAcpField acpField2;
																			if (acpField2.Name == keyValuePair.Key)
																			{
																				num = (short)683999232;
																				num3 = (int)((global::System.IntPtr)num);
																				continue;
																			}
																			break;
																		}
																		case 3:
																			goto IL_532;
																		case 4:
																			num = (short)2020802562;
																			num3 = (int)((global::System.IntPtr)num);
																			continue;
																		case 5:
																			goto IL_54F;
																		case 6:
																			switch (0)
																			{
																			case 0:
																				goto IL_428;
																			}
																			continue;
																		case 7:
																		{
																			global::AcpCommonLib.IAcpField acpField2;
																			if (this.b2.TieredFields.Contains(acpField2.Name))
																			{
																				num = (short)2063466500;
																				num3 = (int)((global::System.IntPtr)num);
																				continue;
																			}
																			break;
																		}
																		case 8:
																		{
																			global::System.Collections.Generic.IEnumerator<global::AcpCommonLib.IAcpField> enumerator4;
																			if (!enumerator4.MoveNext())
																			{
																				num = (short)1871773697;
																				num3 = (int)((global::System.IntPtr)num);
																				continue;
																			}
																			global::AcpCommonLib.IAcpField acpField2 = enumerator4.Current;
																			num = (short)1209925639;
																			num3 = (int)((global::System.IntPtr)num);
																			continue;
																		}
																		}
																		IL_472:
																		num = (short)1564606472;
																		num3 = (int)((global::System.IntPtr)num);
																		continue;
																		IL_428:
																		goto IL_472;
																	}
																	IL_532:
																	IL_54F:;
																}
																finally
																{
																	num = (short)1343225856;
																	num3 = (int)((global::System.IntPtr)num);
																	for (;;)
																	{
																		global::System.Collections.Generic.IEnumerator<global::AcpCommonLib.IAcpField> enumerator4;
																		switch (num3)
																		{
																		case 0:
																			goto IL_569;
																		case 1:
																			goto IL_60D;
																		case 2:
																		{
																			num = (short)812854920;
																			short num4 = num;
																			num = (short)614936200;
																			switch ((num4 == num) ? 1 : 0)
																			{
																			case 0:
																			case 2:
																				goto IL_569;
																			default:
																				num = (short)80674816;
																				if (num != 0)
																				{
																				}
																				enumerator4.Dispose();
																				num = (short)1177354241;
																				num3 = (int)((global::System.IntPtr)num);
																				continue;
																			}
																			break;
																		}
																		}
																		goto IL_586;
																		IL_569:
																		switch (0)
																		{
																		case 0:
																			IL_586:
																			if (enumerator4 == null)
																			{
																				goto IL_60F;
																			}
																			num = (short)1230897154;
																			num3 = (int)((global::System.IntPtr)num);
																			break;
																		}
																	}
																	IL_60D:
																	IL_60F:;
																}
																num = (short)1410859011;
																num3 = (int)((global::System.IntPtr)num);
																continue;
															case 2:
																num = (short)1334706180;
																num3 = (int)((global::System.IntPtr)num);
																continue;
															case 3:
															{
																bool flag2;
																if (flag2)
																{
																	num = (short)1942159366;
																	num3 = (int)((global::System.IntPtr)num);
																	continue;
																}
																break;
															}
															case 4:
																goto IL_715;
															case 5:
															{
																global::System.Collections.Generic.IEnumerator<global::AcpCommonLib.IAcpFeatureSection> enumerator5;
																if (!enumerator5.MoveNext())
																{
																	num = (short)724828162;
																	num3 = (int)((global::System.IntPtr)num);
																	continue;
																}
																global::AcpCommonLib.IAcpFeatureSection acpFeatureSection2 = enumerator5.Current;
																num = (short)1429864457;
																num3 = (int)((global::System.IntPtr)num);
																continue;
															}
															case 6:
																num = (short)714670080;
																num3 = (int)((global::System.IntPtr)num);
																continue;
															case 7:
																switch (0)
																{
																case 0:
																	goto IL_3B4;
																}
																continue;
															case 8:
															{
																global::AcpCommonLib.IAcpFeatureSection acpFeatureSection2;
																global::System.Collections.Generic.IEnumerator<global::AcpCommonLib.IAcpField> enumerator4 = acpFeatureSection2.FieldsCollection.GetEnumerator();
																num = (short)39124993;
																num3 = (int)((global::System.IntPtr)num);
																continue;
															}
															case 9:
															{
																global::System.Collections.Generic.KeyValuePair<string, global::System.Collections.Generic.List<string>> keyValuePair;
																global::AcpCommonLib.IAcpFeatureSection acpFeatureSection2;
																if (acpFeatureSection2.UIName == keyValuePair.Value[0])
																{
																	num = (short)35454984;
																	num3 = (int)((global::System.IntPtr)num);
																	continue;
																}
																break;
															}
															}
															IL_6BF:
															num = (short)862322693;
															num3 = (int)((global::System.IntPtr)num);
															continue;
															IL_3B4:
															goto IL_6BF;
														}
														IL_6BA:
														IL_715:
														goto IL_7CB;
													}
													finally
													{
														num = (short)1935736832;
														num3 = (int)((global::System.IntPtr)num);
														for (;;)
														{
															global::System.Collections.Generic.IEnumerator<global::AcpCommonLib.IAcpFeatureSection> enumerator5;
															switch (num3)
															{
															case 0:
																switch (0)
																{
																case 0:
																	goto IL_74E;
																}
																continue;
															case 1:
																goto IL_786;
															case 2:
																enumerator5.Dispose();
																num = (short)1147142145;
																num3 = (int)((global::System.IntPtr)num);
																continue;
															}
															IL_74E:
															if (enumerator5 == null)
															{
																break;
															}
															num = (short)1308360706;
															num3 = (int)((global::System.IntPtr)num);
														}
														IL_786:;
													}
													break;
												case 8:
												{
													global::System.Collections.Generic.IEnumerator<global::AcpCommonLib.IAcpFeatureSection> enumerator3;
													if (!enumerator3.MoveNext())
													{
														num = (short)1678180366;
														num3 = (int)((global::System.IntPtr)num);
														continue;
													}
													global::AcpCommonLib.IAcpFeatureSection acpFeatureSection = enumerator3.Current;
													bool flag2 = false;
													num = (short)1939931142;
													num3 = (int)((global::System.IntPtr)num);
													continue;
												}
												case 9:
													goto IL_8D4;
												case 10:
													num = (short)260440064;
													num3 = (int)((global::System.IntPtr)num);
													continue;
												case 11:
													goto IL_AD2;
												case 12:
												{
													global::AcpCommonLib.IAcpFeatureSection acpFeatureSection;
													if (acpFeatureSection.HasEmbeddedRecset)
													{
														num = (short)807206917;
														num3 = (int)((global::System.IntPtr)num);
														continue;
													}
													goto IL_7CB;
												}
												case 13:
													num = (short)1989541897;
													num3 = (int)((global::System.IntPtr)num);
													continue;
												case 14:
													goto IL_AB9;
												}
												IL_789:
												num = (short)123600904;
												num3 = (int)((global::System.IntPtr)num);
												continue;
												IL_2E5:
												goto IL_789;
												IL_7CB:
												num = (short)1479409668;
												num3 = (int)((global::System.IntPtr)num);
												continue;
												IL_AB9:
												num = (short)990707723;
												num3 = (int)((global::System.IntPtr)num);
											}
											IL_8D4:
											IL_AD2:
											goto IL_1DE;
										}
										finally
										{
											num = (short)742457345;
											num3 = (int)((global::System.IntPtr)num);
											for (;;)
											{
												global::System.Collections.Generic.IEnumerator<global::AcpCommonLib.IAcpFeatureSection> enumerator3;
												switch (num3)
												{
												case 0:
													enumerator3.Dispose();
													num = (short)1582891010;
													num3 = (int)((global::System.IntPtr)num);
													continue;
												case 1:
													switch (0)
													{
													case 0:
														goto IL_B0A;
													}
													continue;
												case 2:
													goto IL_B45;
												}
												IL_B0A:
												if (enumerator3 == null)
												{
													break;
												}
												num = (short)674562048;
												num3 = (int)((global::System.IntPtr)num);
											}
											IL_B45:;
										}
										goto IL_B48;
										IL_1DE:
										num = (short)367263752;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									case 7:
										switch (0)
										{
										case 0:
											goto IL_151;
										}
										continue;
									case 8:
									{
										bool flag;
										if (flag)
										{
											num = (short)1621688320;
											num3 = (int)((global::System.IntPtr)num);
											continue;
										}
										break;
									}
									case 9:
										goto IL_1D9;
									}
									IL_156:
									num = (short)1632043009;
									num3 = (int)((global::System.IntPtr)num);
									continue;
									IL_151:
									goto IL_156;
									IL_B48:
									num = (short)1099366404;
									num3 = (int)((global::System.IntPtr)num);
								}
								IL_1D9:
								IL_B62:
								break;
							}
							finally
							{
								num = (short)1124859905;
								num3 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									global::System.Collections.Generic.IEnumerator<global::AcpCommonLib.IAcpRecordset> enumerator2;
									switch (num3)
									{
									case 0:
										enumerator2.Dispose();
										num = (short)1378549762;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									case 1:
										switch (0)
										{
										case 0:
											goto IL_B9A;
										}
										continue;
									case 2:
										goto IL_BD2;
									}
									IL_B9A:
									if (enumerator2 == null)
									{
										break;
									}
									num = (short)1715994624;
									num3 = (int)((global::System.IntPtr)num);
								}
								IL_BD2:;
							}
							goto IL_BD5;
						case 2:
							switch (0)
							{
							case 0:
								goto IL_92;
							}
							continue;
						case 3:
							goto IL_BEF;
						case 4:
						{
							if (!enumerator.MoveNext())
							{
								num = (short)103022592;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::System.Collections.Generic.KeyValuePair<string, global::System.Collections.Generic.List<string>> keyValuePair = enumerator.Current;
							global::System.Collections.Generic.IEnumerator<global::AcpCommonLib.IAcpRecordset> enumerator2 = global::AcpCommonLib.FeatureManager.Features.GetEnumerator();
							num = (short)1148059649;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						IL_C2:
						num = (short)320536580;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_92:
						goto IL_C2;
						IL_BD5:
						num = (short)832897027;
						num3 = (int)((global::System.IntPtr)num);
					}
					IL_BEF:;
				}
				finally
				{
					num = (short)1446576129;
					if (num != 0)
					{
					}
					((global::System.IDisposable)enumerator).Dispose();
				}
				return;
			}
			}
		}

		// Token: 0x06000BB0 RID: 2992 RVA: 0x000E72B4 File Offset: 0x000E54B4
		public void RecrefFixup()
		{
			short num = (short)247545801;
			short num2 = num;
			num = (short)1854619593;
			switch (num2 == num)
			{
			}
			num = (short)233308160;
			short num3 = num;
			num = (short)2033647617;
			if (num != 0)
			{
			}
			num = (short)87687168;
			if (num != 0)
			{
			}
			this.RecrefFixup1();
			this.ApplyTiering(false);
		}

		// Token: 0x06000BB1 RID: 2993 RVA: 0x000E7368 File Offset: 0x000E5568
		internal global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<string, bool>> GetPCIBitsToBeSet(string strHostVersion)
		{
			int a_ = 8;
			short num = (short)1930493953;
			if (num != 0)
			{
			}
			num = (short)1619001344;
			switch (num)
			{
			default:
			{
				num = (short)1516371968;
				short num2 = num;
				global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<string, bool>> list = new global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<string, bool>>();
				using (global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.List<string[]>>.Enumerator enumerator = this.b2.PCIFieldsAndUpdateCriteria.GetEnumerator())
				{
					num = (short)1051525120;
					int num3 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num3)
						{
						case 0:
							switch (0)
							{
							case 0:
								goto IL_D4;
							}
							continue;
						case 1:
							try
							{
								num = (short)1418788872;
								num3 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									switch (num3)
									{
									case 0:
									{
										string text;
										if (!(text == global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("춊쒌\udd8e\udc90쒒풔얖\udc98쒚쮜\uda9e", a_)))
										{
											num = (short)992608268;
											num3 = (int)((global::System.IntPtr)num);
											continue;
										}
										bool flag;
										string text2;
										flag &= this.a(strHostVersion, text2);
										num = (short)1205141508;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 1:
										num = (short)1891893251;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									case 2:
										goto IL_341;
									case 3:
									{
										bool flag;
										if (flag)
										{
											num = (short)1843134486;
											num3 = (int)((global::System.IntPtr)num);
											continue;
										}
										goto IL_341;
									}
									case 4:
										goto IL_341;
									case 5:
										goto IL_56D;
									case 6:
										goto IL_1AD;
									case 7:
									{
										global::System.Collections.Generic.List<string[]>.Enumerator enumerator2;
										if (!enumerator2.MoveNext())
										{
											num = (short)2036662289;
											num3 = (int)((global::System.IntPtr)num);
											continue;
										}
										string[] array = enumerator2.Current;
										string text2 = array[1];
										string text3 = array[2].Trim();
										text2 = this.g(text2);
										string text = array[0];
										num = (short)1044643860;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 8:
										switch (0)
										{
										case 0:
											goto IL_165;
										}
										continue;
									case 9:
									{
										bool flag;
										if (!flag)
										{
											num = (short)1942683659;
											num3 = (int)((global::System.IntPtr)num);
											continue;
										}
										break;
									}
									case 10:
									{
										string[] array;
										if (array[0].Contains(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("춊쒌\udd8e\udc90쒒풔얖\udc98쒚쮜\uda9e", a_)))
										{
											num = (short)1069809665;
											num3 = (int)((global::System.IntPtr)num);
											continue;
										}
										num = (short)864354320;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 11:
										num = (short)1647312902;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									case 12:
										num = (short)949288973;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									case 13:
										num = (short)920190986;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									case 14:
										goto IL_341;
									case 15:
										goto IL_341;
									case 16:
									{
										string[] array;
										if (!array[0].Contains(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\ud98a좌좎\ud890\udc92\udb94", a_)))
										{
											num = (short)671547416;
											num3 = (int)((global::System.IntPtr)num);
											continue;
										}
										bool flag;
										string text2;
										flag &= this.f(text2);
										num = (short)418250770;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 17:
										num = (short)448266245;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									case 18:
									{
										bool flag;
										if (flag)
										{
											num = (short)2135883795;
											num3 = (int)((global::System.IntPtr)num);
											continue;
										}
										goto IL_341;
									}
									case 19:
									{
										string[] array;
										string strOptions = array[0].Replace(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\ud98a좌좎\ud890\udc92\udb94", a_), global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쪊소\ud88e킐쪒요", a_));
										bool flag;
										flag &= this.b2.ModelTieringData.EvaluateOptions(strOptions);
										num = (short)183238658;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 20:
									{
										string text;
										if (!(text == global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\ud98a좌좎\ud890\udc92\udb94", a_)))
										{
											num = (short)1598685207;
											num3 = (int)((global::System.IntPtr)num);
											continue;
										}
										bool flag;
										string text2;
										flag &= this.f(text2);
										num = (short)875102222;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 21:
										goto IL_341;
									case 22:
									{
										string[] array;
										string strOptions2 = array[0].Replace(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("춊쒌\udd8e\udc90쒒풔얖\udc98쒚쮜\uda9e", a_), global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쪊소\ud88e킐쪒요", a_));
										bool flag;
										flag &= this.b2.ModelTieringData.EvaluateOptions(strOptions2);
										num = (short)639303695;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 23:
										num = (short)1607532544;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									case 24:
									{
										bool flag;
										string[] array;
										flag &= this.b2.ModelTieringData.EvaluateOptions(array[0]);
										num = (short)1951006741;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									}
									IL_1B2:
									num = (short)1139539975;
									num3 = (int)((global::System.IntPtr)num);
									continue;
									IL_165:
									goto IL_1B2;
									IL_341:
									num = (short)118685705;
									num3 = (int)((global::System.IntPtr)num);
								}
								IL_1AD:
								IL_56D:
								goto IL_6A1;
							}
							finally
							{
								global::System.Collections.Generic.List<string[]>.Enumerator enumerator2;
								((global::System.IDisposable)enumerator2).Dispose();
							}
							break;
						case 2:
							goto IL_6F6;
						case 3:
						{
							bool flag;
							if (flag)
							{
								num = (short)255066119;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 4:
						{
							num = (short)737836486;
							short num4 = num;
							num = (short)904756678;
							switch ((num4 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_6A1;
							default:
								num = (short)116850688;
								if (num != 0)
								{
								}
								break;
							}
							break;
						}
						case 5:
						{
							if (!enumerator.MoveNext())
							{
								num = (short)1878523910;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::System.Collections.Generic.KeyValuePair<string, global::System.Collections.Generic.List<string[]>> keyValuePair = enumerator.Current;
							string key = keyValuePair.Key;
							global::System.Collections.Generic.List<string[]> value = keyValuePair.Value;
							bool flag = true;
							string text3 = string.Empty;
							global::System.Collections.Generic.List<string[]>.Enumerator enumerator2 = value.GetEnumerator();
							num = (short)744816641;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 6:
							num = (short)1145241602;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 7:
						{
							string text3;
							bool value2 = text3.ToLower() == global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("ﾊﾌ搜", a_);
							string key;
							global::System.Collections.Generic.KeyValuePair<string, bool> item = new global::System.Collections.Generic.KeyValuePair<string, bool>(key, value2);
							list.Add(item);
							num = (short)2137980932;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						IL_580:
						num = (short)1650720773;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_D4:
						goto IL_580;
						IL_6A1:
						num = (short)938868739;
						num3 = (int)((global::System.IntPtr)num);
					}
					IL_6F6:;
				}
				return list;
			}
			}
		}

		// Token: 0x06000BB2 RID: 2994 RVA: 0x000E7AB0 File Offset: 0x000E5CB0
		private string g(string A_0)
		{
			switch (0)
			{
			case 0:
				goto IL_5C;
			}
			short num;
			int num2;
			string @string;
			for (;;)
			{
				IL_0A:
				num = (short)817889281;
				if (num != 0)
				{
				}
				switch (num2)
				{
				case 0:
					goto IL_A2;
				case 1:
					if (@string == null)
					{
						num = (short)689045508;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_154;
				case 2:
					@string = global::CommonResources.AcgResources.ResourceManager.GetString(A_0, global::CommonResources.AcgResources.Culture);
					goto IL_EA;
				case 3:
					A_0 = @string.Trim();
					num = (short)265093128;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					@string = global::CommonResources.AppResources.ResourceManager.GetString(A_0, global::CommonResources.AppResources.Culture);
					num = (short)2129199109;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
					goto IL_154;
				case 6:
				{
					num = (short)1759701090;
					short num3 = num;
					num = (short)979757154;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_EA;
					default:
						num = (short)1546715136;
						if (num != 0)
						{
						}
						if (@string == null)
						{
							num = (short)974454786;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_A2;
					}
					break;
				}
				case 7:
					if (@string != null)
					{
						num = (short)1252261891;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1D7;
				case 8:
					goto IL_14F;
				}
				goto IL_5C;
				IL_A2:
				num = (short)1271857159;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_EA:
				num = (short)2125725696;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_154:
				num = (short)156631046;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_14F:
			IL_1D7:
			num = (short)2081226752;
			short num4 = num;
			return A_0;
			IL_5C:
			@string = global::CommonResources.MTFResources.ResourceManager.GetString(A_0, global::CommonResources.MTFResources.Culture);
			num = (short)2008678401;
			num2 = (int)((global::System.IntPtr)num);
			goto IL_0A;
		}

		// Token: 0x06000BB3 RID: 2995 RVA: 0x000E7CC0 File Offset: 0x000E5EC0
		private bool f(string A_0)
		{
			short num = (short)1888810231;
			short num2 = num;
			num = (short)825423095;
			switch (num2 == num)
			{
			}
			num = (short)1813577728;
			short num3 = num;
			num = (short)1871249409;
			if (num != 0)
			{
			}
			num = (short)1561395200;
			if (num != 0)
			{
			}
			return ((global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation)global::AcpCommonLib.FeatureManager.GetFeature(2049)[0]).General.RadInfoGeneralRegionalGovernance_A36710_UIValue == A_0;
		}

		// Token: 0x06000BB4 RID: 2996 RVA: 0x000E7D90 File Offset: 0x000E5F90
		private bool a(string A_0, string A_1)
		{
			switch (0)
			{
			case 0:
				goto IL_73;
			}
			short num;
			int num3;
			bool result;
			int[] array;
			int[] array2;
			for (;;)
			{
				IL_0A:
				num = (short)1854606502;
				short num2 = num;
				num = (short)1153174694;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)1144127488;
					if (num != 0)
					{
					}
					switch (num3)
					{
					case 0:
						return result;
					case 1:
						if (array[0] >= array2[0])
						{
							num = (short)1131151364;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						return result;
					case 2:
						return result;
					case 3:
						goto IL_189;
					case 4:
						num = (short)1654784005;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						if (array[0] > array2[0])
						{
							num = (short)1005518851;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						result = (array[1] >= array2[1]);
						num = (short)820051970;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_73;
				}
				IL_189:
				result = true;
				num = (short)1803616256;
				num3 = (int)((global::System.IntPtr)num);
			}
			return result;
			IL_73:
			num = (short)292683776;
			short num4 = num;
			result = false;
			array = this.e(A_0);
			array2 = this.e(A_1);
			num = (short)1785397249;
			if (num != 0)
			{
			}
			num = (short)1913847809;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_0A;
		}

		// Token: 0x06000BB5 RID: 2997 RVA: 0x000E7F2C File Offset: 0x000E612C
		private int[] e(string A_0)
		{
			int a_ = 12;
			switch (0)
			{
			case 0:
				goto IL_75;
			}
			int num;
			short num2;
			int[] array;
			string text;
			for (;;)
			{
				IL_13:
				int num3;
				switch (num)
				{
				case 0:
					num2 = (short)1027080193;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
					if (num3 >= array.Length)
					{
						num2 = (short)657653776;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)617480201;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
					goto IL_287;
				case 3:
					if (text.Length >= 2)
					{
						num2 = (short)1793064966;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					text = string.Empty;
					num2 = (short)1439170581;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 4:
					goto IL_287;
				case 5:
					goto IL_1CB;
				case 6:
					num2 = (short)1124859905;
					if (num2 != 0)
					{
					}
					text = text.Substring(2);
					num2 = (short)1929510924;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 7:
					num3 = 0;
					num2 = (short)1518075924;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 8:
				{
					num2 = (short)570949632;
					short num4 = num2;
					goto IL_287;
				}
				case 9:
					if (text.Length == 1)
					{
						num2 = (short)1951465486;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					int.TryParse(text.Substring(0, 2), out array[num3]);
					num2 = (short)1121189907;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 10:
					text = text.Substring(1);
					num2 = (short)2065235976;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 11:
					goto IL_2C5;
				case 12:
					goto IL_15D;
				case 13:
					if (text.Length > 0)
					{
						num2 = (short)1582497792;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return array;
				case 14:
					int.TryParse(text.Substring(0, 1), out array[num3]);
					num2 = (short)469762053;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 15:
				{
					if (char.IsDigit(text, 0))
					{
						num2 = (short)1613168662;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)535480787;
					short num5 = num2;
					num2 = (short)582207955;
					switch ((num5 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_15D;
					default:
						num2 = (short)2022965248;
						if (num2 != 0)
						{
						}
						num2 = (short)1077084178;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 16:
					return array;
				case 17:
					if (text != global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("뾎", a_))
					{
						num2 = (short)1409613831;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return array;
				case 18:
					if (text.Length > 1)
					{
						num2 = (short)1791164426;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					text = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("뾎", a_);
					num2 = (short)1112539140;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 19:
					goto IL_1CB;
				case 20:
					goto IL_2C5;
				case 21:
					goto IL_15D;
				case 22:
					num2 = (short)9175057;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_75;
				IL_15D:
				num3++;
				num2 = (short)465043467;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_1CB:
				num2 = (short)672989187;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_287:
				num2 = (short)1298333711;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_2C5:
				num2 = (short)416088077;
				num = (int)((global::System.IntPtr)num2);
			}
			return array;
			IL_75:
			array = new int[4];
			text = A_0.Trim().Replace(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("ꆎ", a_), "");
			num2 = (short)550633474;
			num = (int)((global::System.IntPtr)num2);
			goto IL_13;
		}

		// Token: 0x06000BB6 RID: 2998 RVA: 0x000E838C File Offset: 0x000E658C
		private bool c()
		{
			int a_ = 19;
			short num = (short)275447808;
			int num2 = (int)((global::System.IntPtr)num);
			global::System.Diagnostics.FileVersionInfo versionInfo;
			for (;;)
			{
				switch (num2)
				{
				case 0:
					switch (0)
					{
					case 0:
						goto IL_3E;
					}
					continue;
				case 1:
				{
					num = (short)185466880;
					short num3 = num;
					versionInfo = global::System.Diagnostics.FileVersionInfo.GetVersionInfo(this.by + global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쪕캗ﾙ얟\udaa1튥즧쒩좫쾭슯횱钹\ud9bb욽ꖿ", a_));
					num = (short)659845652;
					short num4 = num;
					num = (short)1845129748;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						continue;
					default:
						num = (short)1963589633;
						if (num != 0)
						{
						}
						num = (short)482017280;
						if (num != 0)
						{
						}
						num = (short)279969794;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 2:
					goto IL_16C;
				case 3:
					goto IL_BC;
				}
				IL_3E:
				if (global::Motorola.CommonCPS.Server.EntityModel.VersionInfoHelper.IsDFlagExisted(global::Motorola.Common.Communication.CommonUtil.DFlagType.DASTRO))
				{
					num = (short)485163009;
					num2 = (int)((global::System.IntPtr)num);
				}
				else
				{
					versionInfo = global::System.Diagnostics.FileVersionInfo.GetVersionInfo(this.by + global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쪕\ud997\ud89d솟쾡춣쪥톧ﲫﶭ麯ힱ첳펵", a_));
					num = (short)211222531;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
			IL_BC:
			IL_16C:
			int fileMajorPart = versionInfo.FileMajorPart;
			return int.Parse(this.b2.TieringFileVersion.Substring(1, 2)) >= fileMajorPart;
		}

		// Token: 0x06000BB7 RID: 2999 RVA: 0x000E852C File Offset: 0x000E672C
		private void a(global::AcpCommonLib.IAcpRecordset A_0)
		{
			int a_ = 11;
			short num = (short)524288000;
			short num2 = num;
			num = (short)97320960;
			int num3 = (int)num;
			switch (num3)
			{
			default:
				switch (0)
				{
				case 0:
					goto IL_11C;
				}
				for (;;)
				{
					IL_59:
					object[] args2;
					int num4;
					switch (num3)
					{
					case 0:
					{
						object[] args;
						A_0.GetType().InvokeMember(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("톍풏첝얟송쮣풥첧쎫\udbad\udeaf욱", a_), global::System.Reflection.BindingFlags.SetField, null, null, args);
						num = (short)548470828;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 1:
						if (this.b2.ModelTieringData.MaxPoolRecords > 0)
						{
							num = (short)1745027079;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_4D9;
					case 2:
						if (this.bs != global::SpecialFeatures.Model_Configuration.ModelTiering.ActionTypes.NEW)
						{
							num = (short)354680874;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2F1;
					case 3:
						goto IL_9F8;
					case 4:
						args2 = new object[]
						{
							this.b2.ModelTieringData.MaxRecords
						};
						num = (short)1053949984;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						num = (short)540868621;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
						if (num4 > 0)
						{
							num = (short)1420558355;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 7:
					{
						object[] args3 = new object[]
						{
							this.b2.ModelTieringData.MaxPoolRecords
						};
						num = (short)1204355095;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 8:
						goto IL_4D9;
					case 9:
						if (A_0.ParentSection.ParentRecset != null)
						{
							num = (short)364642328;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_A76;
					case 10:
						goto IL_3AB;
					case 11:
						if (this.b2.ModelTieringData.MaxRecords > 0)
						{
							num = (short)789643268;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_7CD;
					case 12:
						return;
					case 13:
						if (A_0.ParentSection.ParentRecset.Count > 1)
						{
							num = (short)878968857;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_B62;
					case 14:
					{
						object[] args4;
						A_0.GetType().InvokeMember(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("톍\udd8fﮑ望", a_), global::System.Reflection.BindingFlags.SetField, null, null, args4);
						num = (short)736165891;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 15:
					{
						try
						{
							num = (short)1601634309;
							num3 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num3)
								{
								case 0:
								{
									global::System.Collections.Generic.IEnumerator<global::AcpCommonLib.IAcpRecordset> enumerator;
									if (!enumerator.MoveNext())
									{
										num = (short)1721827336;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::AcpCommonLib.IAcpRecordset acpRecordset = enumerator.Current;
									num = (short)1588264964;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 1:
								{
									int num5;
									if (num5 > 0)
									{
										num = (short)2130247683;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_96D;
								}
								case 2:
									goto IL_883;
								case 3:
								{
									global::AcpCommonLib.IAcpRecordset acpRecordset;
									int num5;
									acpRecordset.AddMultipleDefaultRecords(num5);
									num = (short)791216130;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 4:
								{
									global::AcpCommonLib.IAcpRecordset acpRecordset;
									if (acpRecordset.RecordsetName.Equals(A_0.RecordsetName))
									{
										num = (short)1900412934;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 5:
									switch (0)
									{
									case 0:
										goto IL_862;
									}
									continue;
								case 6:
								{
									global::AcpCommonLib.IAcpRecordset acpRecordset;
									int num5 = this.b2.ModelTieringData.DefaultRecords - acpRecordset.Count;
									num = (short)1189871617;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 7:
									goto IL_985;
								case 8:
									goto IL_96D;
								}
								IL_8DE:
								num = (short)927399936;
								num3 = (int)((global::System.IntPtr)num);
								continue;
								IL_862:
								goto IL_8DE;
								IL_96D:
								num = (short)1339752455;
								num3 = (int)((global::System.IntPtr)num);
							}
							IL_883:
							IL_985:
							goto IL_625;
						}
						finally
						{
							num = (short)789970944;
							num3 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::System.Collections.Generic.IEnumerator<global::AcpCommonLib.IAcpRecordset> enumerator;
								switch (num3)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_9BC;
									}
									continue;
								case 1:
									goto IL_9F5;
								case 2:
									enumerator.Dispose();
									num = (short)484900865;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_9BC:
								if (enumerator == null)
								{
									break;
								}
								num = (short)94502914;
								num3 = (int)((global::System.IntPtr)num);
							}
							IL_9F5:;
						}
						goto IL_9F8;
						IL_625:
						int num6;
						num6++;
						num = (short)908328978;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 16:
						if (this.b2.ModelTieringData.DefaultRecords >= 0)
						{
							num = (short)464322594;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_6D3;
					case 17:
					{
						object[] args3;
						A_0.GetType().InvokeMember(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("톍\udd8f욕", a_), global::System.Reflection.BindingFlags.SetField, null, null, args3);
						num = (short)897908744;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 18:
						goto IL_3AB;
					case 19:
						A_0.AddMultipleDefaultRecords(num4);
						num = (short)844169228;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 20:
						if (A_0.GetType().GetMember(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("톍풏첝얟송쮣풥첧쎫\udbad\udeaf욱", a_)).Length != 0)
						{
							num = (short)1836646400;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_6D3;
					case 21:
					{
						int initialize = this.b2.ModelTieringData.Initialize;
						num = (short)1635844129;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 22:
					{
						num = (short)37407631;
						short num7 = num;
						num = (short)921488271;
						switch ((num7 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_4D4;
						default:
							num = (short)787873792;
							if (num != 0)
							{
							}
							if (this.b2.ModelTieringData.MinRecords >= 0)
							{
								num = (short)445448232;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_9F8;
						}
						break;
					}
					case 23:
						if (A_0.GetType().GetMember(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("톍\udd8f욕", a_)).Length != 0)
						{
							num = (short)1605959697;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_4D9;
					case 24:
						num = (short)1113587758;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 25:
					{
						int num6 = 0;
						num = (short)50003978;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 26:
					{
						int initialize;
						if (!initialize.Equals(1))
						{
							num = (short)1424687125;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2F1;
					}
					case 27:
						return;
					case 28:
						goto IL_1C4;
					case 29:
						goto IL_4D4;
					case 30:
						goto IL_1C4;
					case 31:
						if (A_0.IsEmbeddedRecset)
						{
							num = (short)1768554501;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_B62;
					case 32:
						if (A_0.GetType().GetMember(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("톍\udd8f", a_)).Length != 0)
						{
							num = (short)2012676125;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_7CD;
					case 33:
					{
						int initialize;
						if (initialize.Equals(3))
						{
							num = (short)1898512429;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					}
					case 34:
					{
						object[] args = new object[]
						{
							this.b2.ModelTieringData.DefaultRecords
						};
						num = (short)2000224276;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 35:
					{
						int num6;
						if (num6 >= A_0.ParentSection.ParentRecset.Count)
						{
							num = (short)883687451;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::System.Collections.Generic.IEnumerator<global::AcpCommonLib.IAcpRecordset> enumerator = A_0.ParentSection.ParentRecset[num6].EmbeddedRecordsets.GetEnumerator();
						num = (short)998178831;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 36:
						goto IL_7CD;
					case 37:
						num = (short)1872494593;
						if (num != 0)
						{
						}
						if (A_0.IsEmbeddedRecset)
						{
							num = (short)1858142247;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						A_0.HiddenStatic = !this.b2.ModelTieringData.IsVisible;
						num = (short)985071646;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 38:
						A_0.HiddenStatic = A_0.ParentSection.ParentRecset.HiddenStatic;
						num = (short)115212329;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 39:
						num = (short)1692663817;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 40:
					{
						object[] args4 = new object[]
						{
							this.b2.ModelTieringData.MinRecords
						};
						num = (short)371589163;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 41:
						goto IL_1C4;
					case 42:
					{
						int initialize = this.b2.ModelTieringData.Initialize;
						num = (short)1015611418;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 43:
						if (A_0.GetType().GetMember(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("톍\udd8fﮑ望", a_)).Length != 0)
						{
							num = (short)674758670;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_9F8;
					case 44:
						goto IL_6D3;
					case 45:
						goto IL_2F1;
					case 46:
						if (A_0.ParentSection.ParentRecset.HiddenStatic)
						{
							num = (short)274923558;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_A76;
					}
					goto IL_11C;
					IL_1C4:
					num = (short)54853634;
					num3 = (int)((global::System.IntPtr)num);
					continue;
					IL_2F1:
					num = (short)143458335;
					num3 = (int)((global::System.IntPtr)num);
					continue;
					IL_3AB:
					num = (short)1607270435;
					num3 = (int)((global::System.IntPtr)num);
					continue;
					IL_4D4:
					A_0.GetType().InvokeMember(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("톍\udd8f", a_), global::System.Reflection.BindingFlags.SetField, null, null, args2);
					num = (short)1347682340;
					num3 = (int)((global::System.IntPtr)num);
					continue;
					IL_4D9:
					num = (short)126812182;
					num3 = (int)((global::System.IntPtr)num);
					continue;
					IL_6D3:
					num = (short)172884005;
					num3 = (int)((global::System.IntPtr)num);
					continue;
					IL_7CD:
					num = (short)906690561;
					num3 = (int)((global::System.IntPtr)num);
					continue;
					IL_9F8:
					num = (short)1071579152;
					num3 = (int)((global::System.IntPtr)num);
					continue;
					IL_A76:
					A_0.HiddenStatic = !this.b2.ModelTieringData.IsVisible;
					num = (short)691666972;
					num3 = (int)((global::System.IntPtr)num);
					continue;
					IL_B62:
					num4 = this.b2.ModelTieringData.DefaultRecords - A_0.Count;
					num = (short)2076770310;
					num3 = (int)((global::System.IntPtr)num);
				}
				return;
				IL_11C:
				this.b2.GetTieringData(A_0.ToString());
				num = (short)1788805131;
				num3 = (int)((global::System.IntPtr)num);
				goto IL_59;
			}
		}

		// Token: 0x06000BB8 RID: 3000 RVA: 0x000E910C File Offset: 0x000E730C
		private void a(global::AcpCommonLib.IAcpField A_0, bool A_1 = false)
		{
			int a_ = 1;
			short num = (short)206503936;
			int num2 = (int)num;
			switch (num2)
			{
			default:
				switch (0)
				{
				case 0:
					goto IL_1B8;
				}
				for (;;)
				{
					IL_31:
					int num3;
					int num4;
					string[] array;
					int num5;
					string @string;
					int num7;
					global::System.Collections.Generic.IEnumerator<global::AcpCommonLib.IAcpRecordset> enumerator5;
					switch (num2)
					{
					case 0:
						goto IL_1A89;
					case 1:
						if (!A_0.Name.Contains(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("삃ﮇ憎솋ﺏ힓秊鍊풟쮡쮣좥즧용ﾫ쮭\udcafힱힳ습\uddb7\udeb9\udbbd꺿럁跃닅귇Ꟊ뿋重量", a_)))
						{
							num = (short)1296105564;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1622;
					case 2:
						goto IL_18D9;
					case 3:
						if (A_0.Name.Contains(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("삃ﮇ憎솋ﺏ삓캟얡쎥쒧쾩쾫\udaad햯횱靈펵횷쾹쪽ꖿ꿁럃駅觇﷋留", a_)))
						{
							num = (short)1290207267;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1294467100;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						num3 = this.b2.ModelTieringData.Initialize;
						num = (short)583204893;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
					{
						if (num4 >= ((global::AcpBusinessLayer.AcpListField)A_0).Items.Count)
						{
							num = (short)266076209;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						string text = ((global::AcpBusinessLayer.AcpListField)A_0).Items[num4].ItemName;
						num = (short)1083703304;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 6:
					{
						global::AcpBusinessLayer.ListItem item = new global::AcpBusinessLayer.ListItem((global::AcpBusinessLayer.AcpListField)A_0, array[num5]);
						((global::AcpBusinessLayer.AcpListField)A_0).Items.Add(item);
						num = (short)1316356109;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 7:
						A_0.TieredOut = A_0.Parent.ParentRecset.HiddenStatic;
						A_0.Visible = !A_0.Parent.ParentRecset.HiddenStatic;
						num = (short)594673702;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 8:
						if (A_0 is global::AcpBusinessLayer.AcpRecRefField)
						{
							num = (short)702808076;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1846;
					case 9:
						if (@string.StartsWith(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("즃쎅욇\udf89얋\uda8d햏\udf91", a_)))
						{
							num = (short)81854517;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1A89;
					case 10:
						((global::AcpBusinessLayer.AcpListField)A_0).Items[num4].ItemVisibility = false;
						num = (short)180944923;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 11:
						(A_0 as global::AcpCommonLib.IAcpRangeField).Min = int.Parse(this.b2.ModelTieringData.MinValue);
						num = (short)22216706;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 12:
						num = (short)922157087;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 13:
						goto IL_1AFC;
					case 14:
						goto IL_19C1;
					case 15:
						if (num5 >= array.Length)
						{
							num = (short)1690042454;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1494417473;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 16:
					{
						if (A_0.Parent.ParentRecset.IsEmbeddedRecset)
						{
							num = (short)820903978;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::System.Collections.Generic.IEnumerator<global::AcpCommonLib.IAcpField> enumerator = A_0.Parent.ParentRecset.SearchAll(A_0.UIName).GetEnumerator();
						num = (short)1417871437;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 17:
						goto IL_1924;
					case 18:
						if (A_0.Parent.ParentRecset != null)
						{
							num = (short)283312148;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1EED;
					case 19:
						this.a(ref A_0, this.b2.ModelTieringData.DefaultValue, true, false);
						num = (short)2108031000;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 20:
						num = (short)1742471212;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 21:
						goto IL_10EE;
					case 22:
					{
						string[] array2;
						if (num3 >= array2.Length)
						{
							num = (short)1478754389;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1184956475;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 23:
						if (this.b2.ModelTieringData.DefaultValue != null)
						{
							num = (short)1038811218;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1554;
					case 24:
						goto IL_1A89;
					case 25:
						if (this.b2.ModelTieringData.DefaultValuesPerRecords.Count > 0)
						{
							num = (short)602472480;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 26:
						goto IL_1554;
					case 27:
						goto IL_1ADA;
					case 28:
						if (this.b2.ModelTieringData.DefaultValue != null)
						{
							num = (short)430374991;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_389;
					case 29:
						if (num3.Equals(3))
						{
							num = (short)905773131;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 30:
						goto IL_1A89;
					case 31:
						if (!(((global::AcpBusinessLayer.AcpListField)A_0).Items[num4] is global::AcpBusinessLayer.AcpRecRefItem))
						{
							num = (short)1959657550;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1846;
					case 32:
					{
						global::System.Collections.Generic.Dictionary<int, global::System.Collections.Generic.Dictionary<int, string>>.Enumerator enumerator2 = this.b2.ModelTieringData.DefaultValuesPerRecords.GetEnumerator();
						num = (short)1604976707;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 33:
						num = (short)748552210;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 34:
						goto IL_19C1;
					case 35:
						goto IL_1622;
					case 36:
						if (this.b2.ModelTieringData.MinValue != null)
						{
							num = (short)1079967755;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_18D9;
					case 37:
					{
						num = (short)509411328;
						short num6 = num;
						if (A_0.Parent.ParentRecset.Count <= 1)
						{
							num = (short)655818803;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_167E;
					}
					case 38:
						goto IL_1E9B;
					case 39:
						goto IL_1D19;
					case 40:
						num3 = this.b2.ModelTieringData.Initialize;
						num = (short)670433371;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 41:
						goto IL_19BC;
					case 42:
						num7 = 0;
						num = (short)675151886;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 43:
						num4 = 0;
						num = (short)1072365589;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 44:
						if (A_0.Parent.ParentRecset.HiddenStatic)
						{
							num = (short)845152263;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1EED;
					case 45:
						@string = global::CommonResources.AppResources.ResourceManager.GetString(this.b2.ModelTieringData.DefaultValue, global::CommonResources.MTFResources.Culture);
						num = (short)542638128;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 46:
						if (!A_1)
						{
							num = (short)965083169;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1554;
					case 47:
						goto IL_1D19;
					case 48:
						if (@string == null)
						{
							num = (short)1293484073;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_13A6;
					case 49:
						goto IL_2A2;
					case 50:
						goto IL_1846;
					case 51:
						num = (short)991887444;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 52:
					{
						string text;
						if (this.a(this.b2.ModelTieringData.ValueList, text) > -1)
						{
							num = (short)1516568586;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1ADA;
					}
					case 53:
						goto IL_1064;
					case 54:
						goto IL_167E;
					case 55:
						goto IL_116E;
					case 56:
						goto IL_1601;
					case 57:
						goto IL_13F5;
					case 58:
					{
						string[] array2 = global::Motorola.MackinawCPS.CoreFeatures.MenuItems.LOVs.DispMenuTrunkingSelectedMenuItems_A21735LovStrs;
						num3 = 0;
						num = (short)1838743626;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 59:
					{
						string[] array2;
						if (array2[num3].Equals(array[num5]))
						{
							num = (short)2085945350;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1AFC;
					}
					case 60:
						num = (short)641728593;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 61:
					{
						global::AcpBusinessLayer.ListItem item2 = new global::AcpBusinessLayer.ListItem((global::AcpBusinessLayer.AcpListField)A_0, array[num5]);
						((global::AcpBusinessLayer.AcpListField)A_0).Items.Add(item2);
						num = (short)86114360;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 62:
					{
						string[] array2;
						if (num3 >= array2.Length)
						{
							num = (short)635175002;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)769589336;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 63:
						if (A_0.Name.Contains(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("삃ﮇ憎솋ﺏ삓캟얡쎥쒧쾩쾫\udaad햯횱靈펵횷쾹쪽ꖿ꿁럃駅觇﷋留", a_)))
						{
							num = (short)1638400058;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_13F5;
					case 64:
						if (this.b2.ModelTieringData.DefaultValue != null)
						{
							num = (short)802226195;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1A89;
					case 65:
						if (A_0.Name.Contains(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("삃ﮇ憎솋ﺏ힓秊鍊풟쮡쮣좥즧용ﾫ쮭\udcafힱힳ습\uddb7\udeb9\udbbd꺿럁跃닅귇Ꟊ뿋重量", a_)))
						{
							num = (short)1537736773;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1644494911;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 66:
						goto IL_1924;
					case 67:
						try
						{
							num = (short)42467331;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
								{
									global::System.Collections.Generic.Dictionary<int, global::System.Collections.Generic.Dictionary<int, string>>.Enumerator enumerator2;
									if (!enumerator2.MoveNext())
									{
										num = (short)1571553282;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::System.Collections.Generic.KeyValuePair<int, global::System.Collections.Generic.Dictionary<int, string>> keyValuePair = enumerator2.Current;
									int num8 = keyValuePair.Key - 1;
									global::System.Collections.Generic.Dictionary<int, string>.Enumerator enumerator3 = keyValuePair.Value.GetEnumerator();
									num = (short)67502084;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 1:
									goto IL_1051;
								case 2:
									num = (short)1322909697;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 3:
									switch (0)
									{
									case 0:
										goto IL_4D0;
									}
									continue;
								case 4:
									try
									{
										num = (short)47775745;
										num2 = (int)((global::System.IntPtr)num);
										for (;;)
										{
											int num8;
											global::System.Collections.Generic.Dictionary<int, string>.Enumerator enumerator3;
											global::System.Collections.Generic.KeyValuePair<int, string> keyValuePair2;
											bool flag;
											global::System.Collections.Generic.IEnumerator<global::AcpCommonLib.IAcpFeatureSection> enumerator4;
											switch (num2)
											{
											case 0:
												if (!enumerator3.MoveNext())
												{
													num = (short)749600772;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												goto IL_A7F;
											case 1:
												switch (0)
												{
												case 0:
													goto IL_574;
												}
												continue;
											case 2:
											{
												int num9 = keyValuePair2.Key - 1;
												num = (short)1962016778;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											case 3:
												try
												{
													num = (short)797376520;
													num2 = (int)((global::System.IntPtr)num);
													for (;;)
													{
														switch (num2)
														{
														case 0:
															num = (short)363003907;
															num2 = (int)((global::System.IntPtr)num);
															continue;
														case 1:
															num = (short)1048313861;
															num2 = (int)((global::System.IntPtr)num);
															continue;
														case 2:
														{
															global::AcpCommonLib.IAcpFeatureSection acpFeatureSection;
															if (acpFeatureSection.HasEmbeddedRecset)
															{
																num = (short)1029505025;
																num2 = (int)((global::System.IntPtr)num);
																continue;
															}
															break;
														}
														case 3:
														{
															int num9;
															global::AcpCommonLib.IAcpFeatureSection acpFeatureSection;
															if (num9 < acpFeatureSection.EmbeddedRecset.Count)
															{
																num = (short)2012676108;
																num2 = (int)((global::System.IntPtr)num);
																continue;
															}
															break;
														}
														case 4:
															num = (short)1779564550;
															num2 = (int)((global::System.IntPtr)num);
															continue;
														case 5:
														{
															global::AcpCommonLib.IAcpFeatureSection acpFeatureSection;
															if (acpFeatureSection.EmbeddedRecset.RecordsetName == A_0.Parent.ParentRecset.RecordsetName)
															{
																num = (short)1655242752;
																num2 = (int)((global::System.IntPtr)num);
																continue;
															}
															break;
														}
														case 6:
															goto IL_EDD;
														case 7:
															try
															{
																num = (short)1494286337;
																num2 = (int)((global::System.IntPtr)num);
																for (;;)
																{
																	switch (num2)
																	{
																	case 0:
																		goto IL_CC7;
																	case 1:
																		switch (0)
																		{
																		case 0:
																			goto IL_BF4;
																		}
																		continue;
																	case 3:
																	{
																		global::AcpCommonLib.IAcpField acpField2;
																		global::AcpCommonLib.IAcpField acpField = acpField2;
																		this.a(ref acpField, keyValuePair2.Value, true, false);
																		flag = true;
																		num = (short)373424130;
																		num2 = (int)((global::System.IntPtr)num);
																		continue;
																	}
																	case 4:
																		num = (short)1480523776;
																		num2 = (int)((global::System.IntPtr)num);
																		continue;
																	case 5:
																	{
																		global::AcpCommonLib.IAcpField acpField2;
																		if (acpField2.UIName.Equals(A_0.UIName))
																		{
																			num = (short)2038693891;
																			num2 = (int)((global::System.IntPtr)num);
																			continue;
																		}
																		break;
																	}
																	case 6:
																	{
																		global::System.Collections.Generic.IEnumerator<global::AcpCommonLib.IAcpField> enumerator;
																		if (!enumerator.MoveNext())
																		{
																			num = (short)1651965956;
																			num2 = (int)((global::System.IntPtr)num);
																			continue;
																		}
																		global::AcpCommonLib.IAcpField acpField2 = enumerator.Current;
																		num = (short)1283915781;
																		num2 = (int)((global::System.IntPtr)num);
																		continue;
																	}
																	}
																	IL_C40:
																	num = (short)949354502;
																	num2 = (int)((global::System.IntPtr)num);
																	continue;
																	IL_BF4:
																	goto IL_C40;
																}
																IL_CC7:
																goto IL_B7A;
															}
															finally
															{
																num = (short)1413021697;
																num2 = (int)((global::System.IntPtr)num);
																for (;;)
																{
																	global::System.Collections.Generic.IEnumerator<global::AcpCommonLib.IAcpField> enumerator;
																	switch (num2)
																	{
																	case 0:
																		goto IL_D35;
																	case 1:
																		switch (0)
																		{
																		case 0:
																			goto IL_CFE;
																		}
																		continue;
																	case 2:
																		enumerator.Dispose();
																		num = (short)1372651520;
																		num2 = (int)((global::System.IntPtr)num);
																		continue;
																	}
																	IL_CFE:
																	if (enumerator == null)
																	{
																		break;
																	}
																	num = (short)140050434;
																	num2 = (int)((global::System.IntPtr)num);
																}
																IL_D35:;
															}
															goto IL_D38;
															IL_B7A:
															num = (short)978124810;
															num2 = (int)((global::System.IntPtr)num);
															continue;
														case 8:
															switch (0)
															{
															case 0:
																goto IL_B75;
															}
															continue;
														case 9:
															goto IL_D50;
														case 10:
															if (flag)
															{
																num = (short)233242637;
																num2 = (int)((global::System.IntPtr)num);
																continue;
															}
															break;
														case 11:
														{
															if (!enumerator4.MoveNext())
															{
																num = (short)1059913732;
																num2 = (int)((global::System.IntPtr)num);
																continue;
															}
															global::AcpCommonLib.IAcpFeatureSection acpFeatureSection = enumerator4.Current;
															num = (short)898105346;
															num2 = (int)((global::System.IntPtr)num);
															continue;
														}
														case 12:
														{
															int num9;
															global::AcpCommonLib.IAcpFeatureSection acpFeatureSection;
															global::System.Collections.Generic.IEnumerator<global::AcpCommonLib.IAcpField> enumerator = acpFeatureSection.EmbeddedRecset[num9].SearchAll(A_0.UIName).GetEnumerator();
															num = (short)1195769863;
															num2 = (int)((global::System.IntPtr)num);
															continue;
														}
														case 13:
															goto IL_D38;
														}
														goto IL_B75;
														IL_D38:
														num = (short)2124611593;
														num2 = (int)((global::System.IntPtr)num);
														continue;
														IL_DDB:
														num = (short)300023819;
														num2 = (int)((global::System.IntPtr)num);
														continue;
														IL_B75:
														goto IL_DDB;
													}
													IL_D50:
													IL_EDD:
													break;
												}
												finally
												{
													num = (short)560201729;
													num2 = (int)((global::System.IntPtr)num);
													for (;;)
													{
														switch (num2)
														{
														case 0:
															goto IL_F4E;
														case 1:
															switch (0)
															{
															case 0:
																goto IL_F15;
															}
															continue;
														case 2:
															enumerator4.Dispose();
															num = (short)1757020160;
															num2 = (int)((global::System.IntPtr)num);
															continue;
														}
														IL_F15:
														if (enumerator4 == null)
														{
															break;
														}
														num = (short)355926018;
														num2 = (int)((global::System.IntPtr)num);
													}
													IL_F4E:;
												}
												goto IL_F51;
											case 4:
												num = (short)684851207;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											case 5:
												num = (short)4063243;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											case 6:
												if (A_0.Parent.ParentRecset != null)
												{
													num = (short)144900111;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												break;
											case 7:
												goto IL_FEB;
											case 8:
												goto IL_F51;
											case 9:
												if (keyValuePair2.Key >= 0)
												{
													num = (short)259850242;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												break;
											case 10:
												if (keyValuePair2.Key == 0)
												{
													num = (short)1232928773;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												num = (short)573308934;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											case 11:
												if (num8 < A_0.Parent.ParentRecset.Count)
												{
													num = (short)1552285704;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												break;
											case 12:
												try
												{
													num = (short)1042612230;
													num2 = (int)((global::System.IntPtr)num);
													for (;;)
													{
														global::System.Collections.Generic.IEnumerator<global::AcpCommonLib.IAcpField> enumerator;
														global::AcpCommonLib.IAcpFeatureSection acpFeatureSection2;
														global::System.Collections.Generic.IEnumerable<global::AcpCommonLib.IAcpField> enumerable;
														switch (num2)
														{
														case 0:
															enumerable = acpFeatureSection2.SearchAll(A_0.UIName);
															num = (short)1118044167;
															num2 = (int)((global::System.IntPtr)num);
															continue;
														case 1:
															goto IL_70F;
														case 2:
															if (string.IsNullOrEmpty(A_0.NewUIName))
															{
																num = (short)1625489408;
																num2 = (int)((global::System.IntPtr)num);
																continue;
															}
															goto IL_8FD;
														case 3:
															if (flag)
															{
																num = (short)661913604;
																num2 = (int)((global::System.IntPtr)num);
																continue;
															}
															break;
														case 4:
															num = (short)2016608261;
															num2 = (int)((global::System.IntPtr)num);
															continue;
														case 5:
															goto IL_76E;
														case 6:
															switch (0)
															{
															case 0:
																goto IL_70A;
															}
															continue;
														case 7:
															goto IL_70F;
														case 8:
															goto IL_A0E;
														case 9:
															num = (short)263061512;
															num2 = (int)((global::System.IntPtr)num);
															continue;
														case 10:
															if (!enumerator4.MoveNext())
															{
																num = (short)979107849;
																num2 = (int)((global::System.IntPtr)num);
																continue;
															}
															acpFeatureSection2 = enumerator4.Current;
															num = (short)811794434;
															num2 = (int)((global::System.IntPtr)num);
															continue;
														case 11:
															try
															{
																num = (short)1012989955;
																num2 = (int)((global::System.IntPtr)num);
																for (;;)
																{
																	switch (num2)
																	{
																	case 0:
																		num = (short)1030815746;
																		num2 = (int)((global::System.IntPtr)num);
																		continue;
																	case 1:
																	{
																		global::AcpCommonLib.IAcpField acpField4;
																		global::AcpCommonLib.IAcpField acpField3 = acpField4;
																		this.a(ref acpField3, keyValuePair2.Value, true, false);
																		flag = true;
																		num = (short)1210122244;
																		num2 = (int)((global::System.IntPtr)num);
																		continue;
																	}
																	case 2:
																		goto IL_88A;
																	case 3:
																		switch (0)
																		{
																		case 0:
																			goto IL_7B6;
																		}
																		continue;
																	case 5:
																	{
																		global::AcpCommonLib.IAcpField acpField4;
																		if (acpField4.UIName.Equals(A_0.UIName))
																		{
																			num = (short)1469579265;
																			num2 = (int)((global::System.IntPtr)num);
																			continue;
																		}
																		break;
																	}
																	case 6:
																	{
																		if (!enumerator.MoveNext())
																		{
																			num = (short)807600128;
																			num2 = (int)((global::System.IntPtr)num);
																			continue;
																		}
																		global::AcpCommonLib.IAcpField acpField4 = enumerator.Current;
																		num = (short)1622278149;
																		num2 = (int)((global::System.IntPtr)num);
																		continue;
																	}
																	}
																	IL_7B8:
																	num = (short)1217003526;
																	num2 = (int)((global::System.IntPtr)num);
																	continue;
																	IL_7B6:
																	goto IL_7B8;
																}
																IL_88A:
																goto IL_96D;
															}
															finally
															{
																num = (short)2037514242;
																num2 = (int)((global::System.IntPtr)num);
																for (;;)
																{
																	switch (num2)
																	{
																	case 0:
																		goto IL_8FA;
																	case 1:
																		enumerator.Dispose();
																		num = (short)1947467776;
																		num2 = (int)((global::System.IntPtr)num);
																		continue;
																	case 2:
																		switch (0)
																		{
																		case 0:
																			goto IL_8C2;
																		}
																		continue;
																	}
																	IL_8C2:
																	if (enumerator == null)
																	{
																		break;
																	}
																	num = (short)1414397953;
																	num2 = (int)((global::System.IntPtr)num);
																}
																IL_8FA:;
															}
															goto IL_8FD;
															IL_96D:
															num = (short)651231235;
															num2 = (int)((global::System.IntPtr)num);
															continue;
														}
														goto IL_70A;
														IL_70F:
														enumerator = enumerable.GetEnumerator();
														num = (short)728432651;
														num2 = (int)((global::System.IntPtr)num);
														continue;
														IL_8FD:
														enumerable = acpFeatureSection2.SearchAll(A_0.NewUIName);
														num = (short)51838977;
														num2 = (int)((global::System.IntPtr)num);
														continue;
														IL_929:
														num = (short)692912138;
														num2 = (int)((global::System.IntPtr)num);
														continue;
														IL_70A:
														goto IL_929;
													}
													IL_76E:
													IL_A0E:
													break;
												}
												finally
												{
													num = (short)354353154;
													num2 = (int)((global::System.IntPtr)num);
													for (;;)
													{
														switch (num2)
														{
														case 0:
															goto IL_A7C;
														case 1:
															enumerator4.Dispose();
															num = (short)1088749568;
															num2 = (int)((global::System.IntPtr)num);
															continue;
														case 2:
															switch (0)
															{
															case 0:
																goto IL_A45;
															}
															continue;
														}
														IL_A45:
														if (enumerator4 == null)
														{
															break;
														}
														num = (short)421003265;
														num2 = (int)((global::System.IntPtr)num);
													}
													IL_A7C:;
												}
												goto IL_A7F;
											case 13:
												enumerator4 = ((global::AcpBusinessLayer.FeatureNode)A_0.Parent.ParentRecset.ParentSection.Parent.Parent[num8]).FeatureSectionsCollection.GetEnumerator();
												num = (short)1014300675;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											case 14:
												if (num8 < A_0.Parent.ParentRecset.ParentSection.Parent.Parent.Count)
												{
													num = (short)1521156109;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												break;
											case 15:
												num = (short)385744910;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											goto IL_574;
											IL_A7F:
											keyValuePair2 = enumerator3.Current;
											flag = false;
											num = (short)842268681;
											num2 = (int)((global::System.IntPtr)num);
											continue;
											IL_F51:
											enumerator4 = ((global::AcpBusinessLayer.FeatureNode)A_0.Parent.ParentRecset[num8]).FeatureSectionsCollection.GetEnumerator();
											num = (short)1781006348;
											num2 = (int)((global::System.IntPtr)num);
											continue;
											IL_F92:
											num = (short)1777270784;
											num2 = (int)((global::System.IntPtr)num);
											continue;
											IL_574:
											goto IL_F92;
										}
										IL_FEB:;
									}
									finally
									{
										global::System.Collections.Generic.Dictionary<int, string>.Enumerator enumerator3;
										((global::System.IDisposable)enumerator3).Dispose();
									}
									break;
								}
								IL_FFB:
								num = (short)2048589824;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_4D0:
								goto IL_FFB;
							}
							IL_1051:
							return;
						}
						finally
						{
							global::System.Collections.Generic.Dictionary<int, global::System.Collections.Generic.Dictionary<int, string>>.Enumerator enumerator2;
							((global::System.IDisposable)enumerator2).Dispose();
						}
						goto IL_1064;
					case 68:
						if (this.b2.ModelTieringData.MaxValue != null)
						{
							num = (short)559022156;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_116E;
					case 69:
					{
						string[] array2 = global::Motorola.MackinawCPS.CoreFeatures.MenuItems.LOVs.DispMenuConventionalSelectedMenuItems_A21736LovStrs;
						num3 = 0;
						num = (short)55771183;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 70:
						if (this.b2.ModelTieringData.ValueList.Count > 0)
						{
							num = (short)1855193131;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2A2;
					case 71:
						if (this.bs != global::SpecialFeatures.Model_Configuration.ModelTiering.ActionTypes.NEW)
						{
							num = (short)1589248040;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_17F2;
					case 72:
						goto IL_10EE;
					case 73:
						goto IL_1E9B;
					case 74:
						goto IL_1C75;
					case 75:
						goto IL_17F2;
					case 76:
						(A_0 as global::AcpCommonLib.IAcpRangeField).Max = int.Parse(this.b2.ModelTieringData.MaxValue);
						num = (short)1950548023;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 77:
						try
						{
							num = (short)1138884609;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_12DA;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_11FB;
									}
									continue;
								case 2:
									num = (short)1714552832;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 3:
								{
									global::AcpCommonLib.IAcpField acpField5;
									if (acpField5.UIName.Equals(A_0.UIName))
									{
										num = (short)983629830;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 4:
								{
									global::System.Collections.Generic.IEnumerator<global::AcpCommonLib.IAcpField> enumerator;
									if (!enumerator.MoveNext())
									{
										num = (short)35061762;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::AcpCommonLib.IAcpField acpField5 = enumerator.Current;
									num = (short)854327299;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 6:
								{
									global::AcpCommonLib.IAcpField acpField5;
									global::AcpCommonLib.IAcpField acpField6 = acpField5;
									this.a(ref acpField6, this.b2.ModelTieringData.DefaultValue, true, false);
									num = (short)1671495685;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								}
								IL_1286:
								num = (short)561184772;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_11FB:
								goto IL_1286;
							}
							IL_12DA:
							goto IL_1A89;
						}
						finally
						{
							num = (short)726204417;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::System.Collections.Generic.IEnumerator<global::AcpCommonLib.IAcpField> enumerator;
								switch (num2)
								{
								case 0:
									enumerator.Dispose();
									num = (short)386138114;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_1311;
									}
									continue;
								case 2:
									goto IL_1349;
								}
								IL_1311:
								if (enumerator == null)
								{
									break;
								}
								num = (short)1399980032;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_1349:;
						}
						goto IL_134C;
					case 78:
					{
						string text = text.Replace(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("뢃", a_), string.Empty);
						text = text.Replace(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("몃", a_), string.Empty);
						num = (short)630521906;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 79:
						num = (short)1255538781;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 80:
						try
						{
							num = (short)454426629;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::AcpCommonLib.IAcpRecordset acpRecordset;
								switch (num2)
								{
								case 0:
								{
									global::System.Collections.Generic.IEnumerator<global::AcpCommonLib.IAcpField> enumerator = acpRecordset.SearchAll(A_0.UIName).GetEnumerator();
									num = (short)1304559618;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 1:
									num = (short)1715994630;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									try
									{
										num = (short)1797259266;
										num2 = (int)((global::System.IntPtr)num);
										for (;;)
										{
											switch (num2)
											{
											case 0:
												goto IL_211B;
											case 1:
											{
												global::System.Collections.Generic.IEnumerator<global::AcpCommonLib.IAcpField> enumerator;
												if (!enumerator.MoveNext())
												{
													num = (short)1380974598;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												global::AcpCommonLib.IAcpField acpField7 = enumerator.Current;
												num = (short)1397686276;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											case 2:
												switch (0)
												{
												case 0:
													goto IL_203B;
												}
												continue;
											case 4:
											{
												global::AcpCommonLib.IAcpField acpField7;
												if (acpField7.UIName.Equals(A_0.UIName))
												{
													num = (short)715587589;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												break;
											}
											case 5:
											{
												global::AcpCommonLib.IAcpField acpField7;
												global::AcpCommonLib.IAcpField acpField8 = acpField7;
												this.a(ref acpField8, this.b2.ModelTieringData.DefaultValue, true, false);
												num = (short)1897332739;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											case 6:
												num = (short)292290560;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											IL_20C2:
											num = (short)934281217;
											num2 = (int)((global::System.IntPtr)num);
											continue;
											IL_203B:
											goto IL_20C2;
										}
										IL_211B:
										goto IL_14A9;
									}
									finally
									{
										num = (short)1542717441;
										num2 = (int)((global::System.IntPtr)num);
										for (;;)
										{
											global::System.Collections.Generic.IEnumerator<global::AcpCommonLib.IAcpField> enumerator;
											switch (num2)
											{
											case 0:
												enumerator.Dispose();
												num = (short)344260610;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											case 1:
												switch (0)
												{
												case 0:
													goto IL_2153;
												}
												continue;
											case 2:
												goto IL_218B;
											}
											IL_2153:
											if (enumerator == null)
											{
												break;
											}
											num = (short)1116340224;
											num2 = (int)((global::System.IntPtr)num);
										}
										IL_218B:;
									}
									break;
								case 3:
									if (!enumerator5.MoveNext())
									{
										num = (short)503316481;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_21CD;
								case 4:
									if (acpRecordset.RecordsetName.Equals(A_0.Parent.ParentRecset.RecordsetName))
									{
										num = (short)683081728;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								case 5:
								{
									num = (short)1397419651;
									short num10 = num;
									num = (short)848293507;
									switch ((num10 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										goto IL_21CD;
									default:
										num = (short)1391132672;
										if (num != 0)
										{
										}
										switch (0)
										{
										case 0:
											goto IL_1FC8;
										}
										continue;
									}
									break;
								}
								case 6:
									goto IL_2243;
								}
								IL_218E:
								num = (short)1395916803;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_1FC8:
								goto IL_218E;
								IL_21CD:
								acpRecordset = enumerator5.Current;
								num = (short)1000603652;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_2243:
							goto IL_14A9;
						}
						finally
						{
							num = (short)448397313;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									enumerator5.Dispose();
									num = (short)575602690;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_227A;
									}
									continue;
								case 2:
									goto IL_22B3;
								}
								IL_227A:
								if (enumerator5 == null)
								{
									break;
								}
								num = (short)605487104;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_22B3:;
						}
						return;
						IL_14A9:
						num7++;
						num = (short)1627783202;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 81:
						if (A_0.Parent.ParentRecset.ParentSection.ParentRecset.Count > 1)
						{
							num = (short)181665846;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_389;
					case 82:
						this.a(ref A_0, this.b2.ModelTieringData.DefaultValue, false, true);
						num = (short)1498415130;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 83:
						goto IL_1C75;
					case 84:
						if (A_0.Parent.ParentRecset.IsEmbeddedRecset)
						{
							num = (short)1753415740;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_389;
					case 85:
						goto IL_13F5;
					case 86:
						num = (short)1723727902;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 87:
						if (num7 >= A_0.Parent.ParentRecset.ParentSection.ParentRecset.Count)
						{
							num = (short)946667609;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_134C;
					case 88:
					{
						num = (short)556204033;
						if (num != 0)
						{
						}
						string[] array2;
						if (array2[num3].Equals(array[num5]))
						{
							num = (short)456785981;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1601;
					}
					case 89:
						num = (short)747634688;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 90:
						num = (short)1428553785;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 91:
						if (!num3.Equals(1))
						{
							num = (short)1444020228;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_17F2;
					case 92:
						num = (short)1594032131;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 93:
						if (A_0.Parent.ParentRecset != null)
						{
							num = (short)311885919;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_389;
					case 94:
						if (@string == null)
						{
							num = (short)1915027501;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_13A6;
					case 95:
						num = (short)1467547685;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1B8;
					IL_2A2:
					num = (short)1928921124;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_389:
					num = (short)1282211904;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1064:
					array = @string.Split(new char[]
					{
						'$'
					});
					((global::AcpBusinessLayer.AcpListField)A_0).Items.Clear();
					num5 = 1;
					num = (short)912850961;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_10EE:
					num = (short)1531314181;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_116E:
					num = (short)1777467415;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_134C:
					enumerator5 = A_0.Parent.ParentRecset.ParentSection.ParentRecset[num7].EmbeddedRecordsets.GetEnumerator();
					num = (short)913178704;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_13A6:
					num = (short)1630273545;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_13F5:
					num5++;
					num = (short)556924994;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1554:
					num = (short)1711407175;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1601:
					num3++;
					num = (short)1413873703;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1622:
					@string = global::CommonResources.MTFResources.ResourceManager.GetString(this.b2.ModelTieringData.DefaultValue, global::CommonResources.MTFResources.Culture);
					num = (short)237371486;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_167E:
					num = (short)1534197776;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_17F2:
					num = (short)1184628737;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1846:
					num = (short)1932853300;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_18D9:
					num = (short)737607748;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1924:
					num = (short)889782287;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_19C1:
					num = (short)303497303;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1A89:
					num = (short)1233256473;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1ADA:
					num4++;
					num = (short)798425160;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1AFC:
					num3++;
					num = (short)1919221843;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1C75:
					num = (short)645464086;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1D19:
					num = (short)1681719358;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1E9B:
					num = (short)1203109958;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1EED:
					A_0.TieredOut = !this.b2.ModelTieringData.IsVisible;
					A_0.Visible = this.b2.ModelTieringData.IsVisible;
					num = (short)78905417;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_19BC:
				throw new global::System.Exception(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("잃ꪉ늑ﾕﺙ벛펝얟첡톣蚥\udea9즫쎭邯솱삳쒵톷풹\udbbb麽늿ꟁ럃꧅뷇룉꿋ꯍꏏ", a_));
				IL_1B8:
				this.b2.GetTieringData(A_0.Name);
				num = (short)933888046;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_31;
			}
		}

		// Token: 0x06000BB9 RID: 3001 RVA: 0x000EB4AC File Offset: 0x000E96AC
		private void a(ref global::AcpCommonLib.IAcpField A_0, string A_1, bool A_2, bool A_3)
		{
			int a_ = 10;
			short num = (short)1645805568;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_1B8;
				}
				global::AcpBusinessLayer.AcpRecRefField acpRecRefField;
				global::System.Type type;
				global::AcpBusinessLayer.AcpRangeField<int, string> acpRangeField;
				global::AcpBusinessLayer.AcpRangeField<int, float> acpRangeField2;
				global::AcpBusinessLayer.AcpSimpleRangeField acpSimpleRangeField;
				global::AcpBusinessLayer.AcpFrequencyField acpFrequencyField;
				global::AcpBusinessLayer.AcpCustomRangeField acpCustomRangeField;
				global::System.Collections.Generic.List<string> list;
				for (;;)
				{
					IL_31:
					global::AcpBusinessLayer.AcpRangeField<int, double> acpRangeField4;
					switch (num2)
					{
					case 0:
						goto IL_C40;
					case 1:
						if (A_2)
						{
							num = (short)107348015;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_126E;
					case 2:
						num = (short)1879769140;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						if (acpRecRefField.Parent.ParentRecset.ParentSection != null)
						{
							num = (short)535560284;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 4:
						goto IL_12A7;
					case 5:
						if (A_2)
						{
							num = (short)961544233;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_7C3;
					case 6:
					{
						int num3 = -1;
						int num4 = 0;
						num = (short)30081110;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 7:
					{
						int num5 = 0;
						global::AcpBusinessLayer.AcpSparseLOVField acpSparseLOVField;
						global::System.Collections.Generic.IEnumerator<int> enumerator = acpSparseLOVField.Values.GetEnumerator();
						num = (short)1419378705;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 8:
						goto IL_1490;
					case 9:
					{
						try
						{
							switch (0)
							{
							case 0:
								goto IL_240;
							}
							string @string;
							for (;;)
							{
								IL_21D:
								switch (num2)
								{
								case 0:
									if (@string == null)
									{
										num = (short)2065956870;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_2D5;
								case 1:
									goto IL_2D5;
								case 2:
									if (@string != null)
									{
										num = (short)1476526084;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_30B;
								case 3:
									goto IL_30B;
								case 4:
									A_1 = @string.Trim();
									num = (short)1178075139;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 5:
									goto IL_323;
								case 6:
									@string = global::CommonResources.AppResources.ResourceManager.GetString(A_1, global::CommonResources.AppResources.Culture);
									num = (short)1292238849;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_240;
								IL_2D5:
								num = (short)879886338;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_30B:
								num = (short)1916207109;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_323:
							goto IL_DFB;
							IL_240:
							@string = global::CommonResources.AcgResources.ResourceManager.GetString(A_1, global::CommonResources.AcgResources.Culture);
							num = (short)1375207424;
							num2 = (int)((global::System.IntPtr)num);
							goto IL_21D;
						}
						catch (global::System.Exception)
						{
							goto IL_DFB;
						}
						goto IL_32E;
						IL_DFB:
						global::AcpBusinessLayer.AcpSparseLOVField acpSparseLOVField = A_0 as global::AcpBusinessLayer.AcpSparseLOVField;
						num = (short)1250951248;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 10:
						acpRecRefField = (A_0 as global::AcpBusinessLayer.AcpRecRefField);
						num = (short)450232339;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 11:
						try
						{
							switch (0)
							{
							case 0:
								goto IL_EEA;
							}
							string string2;
							for (;;)
							{
								IL_EBB:
								switch (num2)
								{
								case 0:
									if (string2 == null)
									{
										num = (short)900268039;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_F59;
								case 1:
									string2 = global::CommonResources.AcgResources.ResourceManager.GetString(A_1, global::CommonResources.AcgResources.Culture);
									num = (short)148570114;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									goto IL_F90;
								case 3:
									if (string2 != null)
									{
										num = (short)4587526;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_1017;
								case 4:
									if (string2 == null)
									{
										num = (short)1181548545;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_F90;
								case 5:
									goto IL_1017;
								case 6:
									A_1 = string2.Trim();
									num = (short)528678917;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 7:
									string2 = global::CommonResources.AppResources.ResourceManager.GetString(A_1, global::CommonResources.AppResources.Culture);
									num = (short)870645769;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 8:
									goto IL_102F;
								case 9:
									goto IL_F59;
								}
								goto IL_EEA;
								IL_F59:
								num = (short)1359544324;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_F90:
								num = (short)2122055683;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_1017:
								num = (short)1611333640;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_102F:
							goto IL_13AD;
							IL_EEA:
							string2 = global::CommonResources.MTFResources.ResourceManager.GetString(A_1, global::CommonResources.MTFResources.Culture);
							num = (short)1518534656;
							num2 = (int)((global::System.IntPtr)num);
							goto IL_EBB;
						}
						catch (global::System.Exception)
						{
							goto IL_13AD;
						}
						goto IL_103A;
						IL_13AD:
						num = (short)1480851484;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 12:
						goto IL_849;
					case 13:
						goto IL_A71;
					case 14:
						goto IL_A6C;
					case 15:
						if (A_3)
						{
							num = (short)1747779620;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 16:
						if (type.Name.Contains(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("첌햒슠\udaa2캦첨잪즬", a_)))
						{
							num = (short)297402446;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)317522007;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 17:
						try
						{
							num = (short)180486144;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								int defaultValue;
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_502;
									}
									continue;
								case 1:
									goto IL_564;
								case 2:
									goto IL_637;
								case 3:
								{
									global::System.Collections.Generic.IEnumerator<int> enumerator;
									if (!enumerator.MoveNext())
									{
										num = (short)1872625669;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									defaultValue = enumerator.Current;
									num = (short)1533345799;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 4:
								{
									num = (short)56660707;
									short num6 = num;
									num = (short)1217106659;
									switch ((num6 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										goto IL_564;
									default:
										goto IL_5C5;
									}
									break;
								}
								case 5:
									num = (short)1471938562;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 7:
								{
									int num3;
									int num5;
									if (num5 == num3)
									{
										num = (short)1297481729;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num5++;
									num = (short)1294532614;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								}
								goto IL_502;
								IL_564:
								global::AcpBusinessLayer.AcpSparseLOVField acpSparseLOVField;
								acpSparseLOVField.DefaultValue = defaultValue;
								acpSparseLOVField.DefaultSetByTiering = true;
								num = (short)1414594564;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_5DF:
								num = (short)860815363;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_502:
								goto IL_5DF;
							}
							IL_5C5:
							num = (short)847446016;
							if (num != 0)
							{
							}
							IL_637:
							return;
						}
						finally
						{
							num = (short)872218626;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::System.Collections.Generic.IEnumerator<int> enumerator;
								switch (num2)
								{
								case 0:
									enumerator.Dispose();
									num = (short)1924136961;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									goto IL_6A8;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_670;
									}
									continue;
								}
								IL_670:
								if (enumerator == null)
								{
									break;
								}
								num = (short)760479744;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_6A8:;
						}
						goto IL_6AB;
					case 18:
						if (A_0 is global::AcpBusinessLayer.AcpRangeField<int, int>)
						{
							num = (short)1571553328;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_C40;
					case 19:
						if (acpRecRefField.RefRecset == null)
						{
							num = (short)2013986845;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)937295873;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 20:
						goto IL_1269;
					case 21:
						acpRangeField = (A_0 as global::AcpBusinessLayer.AcpRangeField<int, string>);
						num = (short)1349320728;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 22:
					{
						int num4;
						global::AcpBusinessLayer.AcpSparseLOVField acpSparseLOVField;
						if (acpSparseLOVField.Items[num4].ItemName.Equals(A_1))
						{
							num = (short)1475412002;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num4++;
						num = (short)623247387;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 23:
						goto IL_103A;
					case 24:
						if (A_2)
						{
							num = (short)1088159833;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_849;
					case 25:
						if (type.Name.Contains(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("첌솒練ﺘﺚ\udb9c쒠쾢솤", a_)))
						{
							num = (short)1546125314;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1312948266;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 26:
						goto IL_C82;
					case 27:
						goto IL_E69;
					case 28:
						if (A_2)
						{
							num = (short)1374879803;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_6AB;
					case 29:
						num = (short)19595357;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 30:
						goto IL_DBD;
					case 31:
						if (A_3)
						{
							num = (short)55443537;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 32:
						acpRangeField2 = (A_0 as global::AcpBusinessLayer.AcpRangeField<int, float>);
						num = (short)759431253;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 33:
						goto IL_A2F;
					case 34:
					{
						int num4;
						int num3 = num4;
						num = (short)1533345875;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 35:
						if (type.Name.Contains(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("첌삒펞캦첨잪즬", a_)))
						{
							num = (short)434962441;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1325989899;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 36:
						A_0.ParseDefaultValueFrom(A_1);
						(A_0 as global::AcpBusinessLayer.AcpFieldBase).DefaultSetByTiering = true;
						num = (short)1661272115;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 37:
						goto IL_7C3;
					case 38:
						if (A_3)
						{
							num = (short)1940127834;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 39:
						goto IL_C40;
					case 40:
						acpRangeField2.Value = global::System.Convert.ToInt32(A_1);
						num = (short)691863601;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 41:
					{
						global::AcpBusinessLayer.AcpRangeField<int, int> acpRangeField3;
						acpRangeField3.Value = global::System.Convert.ToInt32(A_1);
						num = (short)807206949;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 42:
						if (type.Name.Contains(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("첌삒ﲔ殺춞삠춢스슦슪좬쎮햰", a_)))
						{
							num = (short)1483276372;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_32E;
					case 43:
						acpSimpleRangeField.Value = global::System.Convert.ToInt32(A_1);
						num = (short)1289814029;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 44:
						if (A_3)
						{
							num = (short)913571848;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 45:
						if (A_3)
						{
							num = (short)442236998;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_C40;
					case 46:
						if (A_3)
						{
							num = (short)1404043278;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 47:
						acpRecRefField.ParseValueFrom(A_1);
						num = (short)104333388;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 48:
					{
						global::AcpBusinessLayer.AcpRangeField<int, int> acpRangeField3 = A_0 as global::AcpBusinessLayer.AcpRangeField<int, int>;
						num = (short)491454469;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 49:
						goto IL_1459;
					case 50:
						if (A_0 is global::AcpBusinessLayer.AcpRangeField<int, string>)
						{
							num = (short)1894121493;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 51:
						return;
					case 52:
						if (A_0 is global::AcpBusinessLayer.AcpRangeField<int, double>)
						{
							num = (short)936902679;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1150746642;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 53:
						acpFrequencyField.Value = global::System.Convert.ToInt32(A_1);
						num = (short)1380515909;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 54:
						if (A_3)
						{
							num = (short)143720454;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 55:
					{
						int num4;
						global::AcpBusinessLayer.AcpSparseLOVField acpSparseLOVField;
						if (num4 >= acpSparseLOVField.Items.Count)
						{
							num = (short)26214430;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)2139619350;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 56:
						goto IL_6AB;
					case 57:
						if (A_2)
						{
							num = (short)1308295221;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_A34;
					case 58:
						if (A_3)
						{
							num = (short)2052456452;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 59:
						A_0.ParseValueFrom(A_1);
						num = (short)707788856;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 60:
						if (A_3)
						{
							num = (short)352649293;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 61:
						acpRangeField4.Value = global::System.Convert.ToInt32(A_1);
						num = (short)1925513307;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 62:
						acpCustomRangeField.Value = global::System.Convert.ToInt32(A_1);
						num = (short)1403256858;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 63:
						if (A_3)
						{
							num = (short)1207697480;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_C40;
					case 64:
						if (A_2)
						{
							num = (short)924254270;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_C82;
					case 65:
						if (this.bs == global::SpecialFeatures.Model_Configuration.ModelTiering.ActionTypes.OPEN)
						{
							num = (short)2042036318;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_32E;
					case 66:
						if (A_2)
						{
							num = (short)495059005;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_743;
					case 67:
					{
						int num3;
						if (num3 > -1)
						{
							num = (short)887422983;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					}
					case 68:
					{
						global::AcpBusinessLayer.AcpSparseLOVField acpSparseLOVField;
						acpSparseLOVField.UIValue = A_1;
						num = (short)238551135;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 69:
						goto IL_A34;
					case 70:
					{
						global::AcpBusinessLayer.AcpRangeField<int, int> acpRangeField3;
						acpRangeField3.DefaultValue = global::System.Convert.ToInt32(A_1);
						acpRangeField3.DefaultSetByTiering = true;
						num = (short)1215168551;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 71:
						if (acpSimpleRangeField.Converter != null)
						{
							num = (short)1993408587;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						acpSimpleRangeField.DefaultValue = global::System.Convert.ToInt32(A_1);
						num = (short)666894356;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 72:
						acpRangeField4.DefaultValue = global::System.Convert.ToInt32(A_1);
						acpRangeField4.DefaultSetByTiering = true;
						num = (short)924647424;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 73:
						if (type.Name.Contains(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("첌솒쮘ﺚﮜ\ud99e좠욢즤쎦", a_)))
						{
							num = (short)1820000266;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)260767779;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 74:
						if (A_0 is global::AcpBusinessLayer.AcpRangeField<int, float>)
						{
							num = (short)944242720;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)722075698;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 75:
						acpSimpleRangeField.DefaultValue = (int)acpSimpleRangeField.Converter.ConvertBack(A_1, null, acpSimpleRangeField.ConverterParameterObject, null);
						num = (short)1417412641;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 76:
						goto IL_126E;
					case 77:
						goto IL_881;
					case 78:
						acpFrequencyField = (A_0 as global::AcpBusinessLayer.AcpFrequencyField);
						num = (short)14417977;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 79:
						acpCustomRangeField = (A_0 as global::AcpBusinessLayer.AcpCustomRangeField);
						num = (short)1142161472;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 80:
						num = (short)1901068289;
						if (num != 0)
						{
						}
						if (A_2)
						{
							num = (short)1507328068;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1495;
					case 81:
						num = (short)482017351;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 82:
						if (A_2)
						{
							num = (short)1313472555;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_A71;
					case 83:
						goto IL_DBD;
					case 84:
						num = (short)1311965249;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 85:
						if (A_2)
						{
							num = (short)1343488040;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1459;
					case 86:
						goto IL_E69;
					case 87:
					{
						if (type.Name.Contains(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("첌킒춞삠춢스슦슪좬쎮햰", a_)))
						{
							num = (short)1894383695;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)894959616;
						short num7 = num;
						num = (short)1703149593;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 88:
						list = new global::System.Collections.Generic.List<string>();
						list.Add(acpRecRefField.ParentNode.FeatureName);
						this.b3.Add(acpRecRefField.Name, list);
						num = (short)822018051;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 89:
						acpRangeField.Value = global::System.Convert.ToInt32(A_1);
						num = (short)624099340;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 90:
						goto IL_CB9;
					case 91:
						goto IL_743;
					case 92:
						goto IL_10F2;
					case 93:
						if (!this.b3.ContainsKey(acpRecRefField.Name))
						{
							num = (short)155910232;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 94:
						acpSimpleRangeField = (A_0 as global::AcpBusinessLayer.AcpSimpleRangeField);
						num = (short)1993539666;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 95:
						goto IL_1495;
					}
					goto IL_1B8;
					IL_32E:
					num = (short)269811785;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_6AB:
					num = (short)1180303375;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_743:
					num = (short)542375999;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_7C3:
					num = (short)344326189;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_849:
					num = (short)612696124;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_A34:
					num = (short)994181166;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_A71:
					num = (short)2037252127;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_C40:
					num = (short)603258954;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_C82:
					num = (short)1243676710;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_DBD:
					num = (short)1091371075;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_E69:
					num = (short)1864106039;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_103A:
					acpRangeField4 = (A_0 as global::AcpBusinessLayer.AcpRangeField<int, double>);
					num = (short)1660616770;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_126E:
					num = (short)1426980922;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1459:
					num = (short)672530476;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1495:
					num = (short)1148649526;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_881:
				acpRangeField.DefaultValue = global::System.Convert.ToInt32(A_1);
				acpRangeField.DefaultSetByTiering = true;
				return;
				IL_A2F:
				goto IL_13E9;
				IL_A6C:
				acpFrequencyField.DefaultValue = global::System.Convert.ToInt32(A_1);
				acpFrequencyField.DefaultSetByTiering = true;
				return;
				IL_CB9:
				acpCustomRangeField.DefaultValue = global::System.Convert.ToInt32(A_1);
				acpCustomRangeField.DefaultSetByTiering = true;
				return;
				IL_10F2:
				list.Add(acpRecRefField.Parent.ParentRecset.ParentSection.Parent.UIName);
				return;
				IL_1269:
				goto IL_13E9;
				IL_12A7:
				acpRecRefField.ParseDefaultValueFrom(acpRecRefField.ReferencedIndex.ToString());
				acpRecRefField.DefaultSetByTiering = true;
				return;
				IL_13E9:
				acpSimpleRangeField.DefaultSetByTiering = true;
				return;
				IL_1490:
				acpRangeField2.DefaultValue = global::System.Convert.ToInt32(A_1);
				acpRangeField2.DefaultSetByTiering = true;
				return;
				IL_1B8:
				type = A_0.GetType();
				num = (short)34996240;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_31;
			}
			}
		}

		// Token: 0x06000BBA RID: 3002 RVA: 0x000ECA08 File Offset: 0x000EAC08
		private int a(global::System.Collections.Generic.List<string> A_0, string A_1)
		{
			short num = (short)1037959168;
			short num2 = num;
			num = (short)778622813;
			short num3 = num;
			num = (short)1837487965;
			int result;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
				num = (short)1106182144;
				if (num != 0)
				{
				}
				num = (short)463273985;
				if (num != 0)
				{
				}
				num = (short)1183973376;
				switch (num)
				{
				default:
				{
					result = -1;
					int num4 = -1;
					char c = '\t';
					char c2 = '\u00a0';
					char c3 = ' ';
					using (global::System.Collections.Generic.List<string>.Enumerator enumerator = A_0.GetEnumerator())
					{
						num = (short)689766401;
						int num5 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num5)
							{
							case 0:
							{
								if (!enumerator.MoveNext())
								{
									num = (short)1730281476;
									num5 = (int)((global::System.IntPtr)num);
									continue;
								}
								string text = enumerator.Current;
								num = (short)1142226946;
								num5 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 1:
								switch (0)
								{
								case 0:
									goto IL_10D;
								}
								continue;
							case 2:
								try
								{
									switch (0)
									{
									case 0:
										goto IL_1AC;
									}
									string text;
									string @string;
									for (;;)
									{
										IL_179:
										string text2;
										string text3;
										switch (num5)
										{
										case 0:
											if (@string == null)
											{
												num = (short)744620035;
												num5 = (int)((global::System.IntPtr)num);
												continue;
											}
											goto IL_333;
										case 1:
											if (@string != null)
											{
												num = (short)2137260041;
												num5 = (int)((global::System.IntPtr)num);
												continue;
											}
											text2 = text.Trim();
											num = (short)364576770;
											num5 = (int)((global::System.IntPtr)num);
											continue;
										case 2:
											goto IL_268;
										case 3:
											@string = global::CommonResources.AppResources.ResourceManager.GetString(text, global::CommonResources.AppResources.Culture);
											num = (short)2079391750;
											num5 = (int)((global::System.IntPtr)num);
											continue;
										case 4:
											if (text2 == text3)
											{
												num = (short)42074122;
												num5 = (int)((global::System.IntPtr)num);
												continue;
											}
											num = (short)1557135365;
											num5 = (int)((global::System.IntPtr)num);
											continue;
										case 5:
											goto IL_386;
										case 6:
											goto IL_333;
										case 7:
											goto IL_20F;
										case 8:
											goto IL_268;
										case 9:
											text2 = @string.Trim();
											num = (short)1950875656;
											num5 = (int)((global::System.IntPtr)num);
											continue;
										case 10:
											result = num4;
											num = (short)201326599;
											num5 = (int)((global::System.IntPtr)num);
											continue;
										}
										goto IL_1AC;
										IL_268:
										text2 = text2.Replace(c.ToString(), "");
										text2 = text2.Replace(c2.ToString(), c3.ToString());
										text3 = A_1.Trim();
										text3 = text3.Replace(c.ToString(), "");
										text3 = text3.Replace(c2.ToString(), c3.ToString());
										num4++;
										num = (short)314114052;
										num5 = (int)((global::System.IntPtr)num);
										continue;
										IL_333:
										num = (short)214564865;
										num5 = (int)((global::System.IntPtr)num);
									}
									IL_20F:
									return result;
									IL_386:
									break;
									IL_1AC:
									@string = global::CommonResources.AcgResources.ResourceManager.GetString(text, global::CommonResources.AcgResources.Culture);
									num = (short)599523328;
									num5 = (int)((global::System.IntPtr)num);
									goto IL_179;
								}
								catch (global::System.Exception)
								{
									break;
								}
								goto IL_391;
							case 3:
								goto IL_3A9;
							case 4:
								goto IL_391;
							}
							IL_132:
							num = (short)629800960;
							num5 = (int)((global::System.IntPtr)num);
							continue;
							IL_10D:
							goto IL_132;
							IL_391:
							num = (short)1636237315;
							num5 = (int)((global::System.IntPtr)num);
						}
						IL_3A9:;
					}
					break;
				}
				}
				break;
			}
			return result;
		}

		// Token: 0x06000BBB RID: 3003 RVA: 0x000ECE04 File Offset: 0x000EB004
		private void a(ref global::System.Collections.Generic.Dictionary<string, bool> A_0, bool A_1)
		{
			int a_ = 8;
			short num = (short)1947860992;
			short num2 = num;
			num = (short)1633257008;
			short num3 = num;
			num = (short)1965852208;
			bool value;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
				num = (short)1027538944;
				if (num != 0)
				{
				}
				num = (short)270794752;
				switch (num)
				{
				default:
				{
					string text = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\ud98a붌몎", a_);
					string text2 = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\ud98a붌릎", a_);
					string text3 = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\ud98a벌뺎", a_);
					value = false;
					try
					{
						num = (short)801374209;
						int num4 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							object obj;
							bool flag;
							int num5;
							int num6;
							switch (num4)
							{
							case 0:
								obj = (global::AcpCommonLib.AppInfoManager.ComparatorDocument.GetFeature(2049)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation);
								goto IL_693;
							case 1:
								switch (0)
								{
								case 0:
									goto IL_545;
								}
								continue;
							case 2:
								num = (short)1416167433;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							case 3:
								obj = (global::AcpCommonLib.FeatureManager.GetFeature(2049)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation);
								goto IL_693;
							case 4:
								flag = true;
								goto IL_7FD;
							case 5:
								num = (short)50397194;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							case 6:
								num = (short)815529985;
								if (num != 0)
								{
								}
								flag = false;
								goto IL_7FD;
							case 7:
								num = (short)1217396749;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							case 8:
								if (!A_1)
								{
									num = (short)1255669771;
									num4 = (int)((global::System.IntPtr)num);
									continue;
								}
								num = (short)1354760192;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							case 9:
								if (num5 == 14)
								{
									num = (short)2065498119;
									num4 = (int)((global::System.IntPtr)num);
									continue;
								}
								num = (short)1703870470;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							case 10:
								if (this.bs == global::SpecialFeatures.Model_Configuration.ModelTiering.ActionTypes.FLASHPORT)
								{
									num = (short)1269563404;
									num4 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_6E0;
							case 11:
								num = (short)555483139;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							case 12:
								goto IL_614;
							case 13:
								flag = (num6 < 1);
								goto IL_7FD;
							case 14:
								goto IL_6E0;
							case 15:
								if (num5 >= 14)
								{
									num = (short)1121255426;
									num4 = (int)((global::System.IntPtr)num);
									continue;
								}
								num = (short)1384316932;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							case 16:
								goto IL_875;
							}
							IL_545:
							if (this.bs != global::SpecialFeatures.Model_Configuration.ModelTiering.ActionTypes.OPEN)
							{
								num = (short)219873285;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							IL_614:
							num = (short)2003763208;
							num4 = (int)((global::System.IntPtr)num);
							continue;
							IL_693:
							object obj2 = obj;
							text = obj2.General.RadInfoGeneralCodeplugVersion_A7683;
							text2 = obj2.General.RadInfoGeneralCodeplugVersion_A7683;
							text3 = obj2.General.RadInfoGeneralCodeplugVersion_A7683;
							num = (short)1374355470;
							num4 = (int)((global::System.IntPtr)num);
							continue;
							IL_6E0:
							int num7 = int.Parse(text.Substring(1, 2));
							int num8 = int.Parse(text2.Substring(1, 2));
							int num9 = int.Parse(text3.Substring(1, 2));
							num5 = int.Parse(text.Substring(1, 2));
							num6 = int.Parse(text.Substring(4, 2));
							bool value2 = num7 < 5;
							bool value3 = num8 < 6;
							bool value4 = num9 < 11;
							num = (short)209911823;
							num4 = (int)((global::System.IntPtr)num);
							continue;
							IL_7FD:
							bool value5 = flag;
							A_0.Add(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\ud88a슌\uda8e쎐킒킔좖\uda98쮚\uda9c삞ﶰ芶", a_), value2);
							A_0.Add(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\ud88a슌\uda8e쎐킒킔좖\uda98쮚\uda9c삞ﶰ膶", a_), value3);
							A_0.Add(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\ud88a슌\uda8e쎐킒킔좖\uda98쮚\uda9c삞ﶰ蚶袸", a_), value4);
							A_0.Add(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\ud88a슌\uda8e쎐킒킔좖\uda98쮚\uda9c삞ﶰ薶覸誺讼郀雄苆鯈", a_), value5);
							num = (short)1735524368;
							num4 = (int)((global::System.IntPtr)num);
						}
						IL_875:
						break;
					}
					catch
					{
						if (A_0 != null)
						{
							A_0.Add(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\ud88a슌\uda8e쎐킒킔좖\uda98쮚\uda9c삞ﶰ芶", a_), false);
							A_0.Add(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\ud88a슌\uda8e쎐킒킔좖\uda98쮚\uda9c삞ﶰ膶", a_), false);
							A_0.Add(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\ud88a슌\uda8e쎐킒킔좖\uda98쮚\uda9c삞ﶰ蚶袸", a_), false);
							A_0.Add(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\ud88a슌\uda8e쎐킒킔좖\uda98쮚\uda9c삞ﶰ薶覸誺讼郀雄苆鯈", a_), false);
						}
						break;
					}
					return;
				}
				}
				break;
			}
			for (;;)
			{
				try
				{
					num = (short)769982471;
					int num4 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWideRecset radioWideRecset;
						switch (num4)
						{
						case 0:
							num = (short)256704532;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							goto IL_3CF;
						case 2:
							if (radioWideRecset.Count >= 1)
							{
								num = (short)1904345103;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_3CF;
						case 3:
							goto IL_33B;
						case 4:
						{
							string item = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("첊첌뾎ꆐꮒꖔꆖ", a_);
							num = (short)1570308108;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 5:
						{
							global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide radioWide;
							if (radioWide != null)
							{
								num = (short)628228113;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_3CF;
						}
						case 6:
							goto IL_469;
						case 7:
							switch (0)
							{
							case 0:
								goto IL_152;
							}
							continue;
						case 8:
							goto IL_469;
						case 9:
							value = true;
							num = (short)1329332235;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 10:
							if (A_0.ContainsKey(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\ud88a쒌\udd8e풐\udd92쪔\udb96킘\udc9a햜쮞ﲢﮪ", a_)))
							{
								num = (short)197066765;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							A_0.Add(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\ud88a쒌\udd8e풐\udd92쪔\udb96킘\udc9a햜쮞ﲢﮪ", a_), value);
							num = (short)693960710;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 11:
							goto IL_230;
						case 12:
						{
							string item;
							if (this.bv.Contains(item))
							{
								num = (short)1499463689;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_230;
						}
						case 13:
							A_0[global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\ud88a쒌\udd8e풐\udd92쪔\udb96킘\udc9a햜쮞ﲢﮪ", a_)] = value;
							num = (short)1727463432;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 14:
							value = true;
							num = (short)1230831617;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 15:
						{
							global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide radioWide = radioWideRecset[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide;
							num = (short)189136901;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 16:
							if (this.bs == global::SpecialFeatures.Model_Configuration.ModelTiering.ActionTypes.NEW)
							{
								num = (short)2125201412;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_230;
						case 17:
							num = (short)1387397138;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 18:
						{
							global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide radioWide;
							if (radioWide.Labtool.RadWideLabtoolSirenAndLightsKeypadEnable_A41413.Value)
							{
								num = (short)561053710;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_3CF;
						}
						case 19:
							num = (short)1307181058;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 20:
							if (this.bs == global::SpecialFeatures.Model_Configuration.ModelTiering.ActionTypes.FLASHPORT)
							{
								num = (short)872415235;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_3CF;
						case 21:
							if (radioWideRecset != null)
							{
								num = (short)846462995;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_3CF;
						case 22:
							goto IL_481;
						}
						IL_152:
						if (this.bs != global::SpecialFeatures.Model_Configuration.ModelTiering.ActionTypes.OPEN)
						{
							num = (short)1015676928;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_33B;
						IL_230:
						num = (short)1288830986;
						num4 = (int)((global::System.IntPtr)num);
						continue;
						IL_33B:
						radioWideRecset = (global::AcpCommonLib.FeatureManager.GetFeature(2045) as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWideRecset);
						num = (short)378470421;
						num4 = (int)((global::System.IntPtr)num);
						continue;
						IL_3CF:
						num = (short)1357119504;
						num4 = (int)((global::System.IntPtr)num);
						continue;
						IL_469:
						num = (short)1261109270;
						num4 = (int)((global::System.IntPtr)num);
					}
					IL_481:
					break;
				}
				catch
				{
					if (A_0.ContainsKey(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\ud88a쒌\udd8e풐\udd92쪔\udb96킘\udc9a햜쮞ﲢﮪ", a_)))
					{
						A_0[global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\ud88a쒌\udd8e풐\udd92쪔\udb96킘\udc9a햜쮞ﲢﮪ", a_)] = value;
					}
					else
					{
						A_0.Add(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\ud88a쒌\udd8e풐\udd92쪔\udb96킘\udc9a햜쮞ﲢﮪ", a_), value);
					}
					break;
				}
			}
		}

		// Token: 0x06000BBC RID: 3004 RVA: 0x000ED728 File Offset: 0x000EB928
		private bool d(string A_0)
		{
			int a_ = 17;
			short num = (short)1783670270;
			short num2 = num;
			num = (short)304326142;
			int num3;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
				num = (short)127729664;
				if (num != 0)
				{
				}
				num = (short)91226112;
				num3 = (int)((global::System.IntPtr)num);
				break;
			}
			for (;;)
			{
				switch (num3)
				{
				case 0:
					switch (0)
					{
					case 0:
						goto IL_88;
					}
					continue;
				case 1:
					if (A_0.Trim().ToUpper().EndsWith(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udd93", a_)))
					{
						num = (short)1171128323;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					return false;
				case 2:
				{
					num = (short)440532992;
					short num4 = num;
					num = (short)1977024513;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 3:
					return true;
				}
				IL_88:
				if (A_0.Trim().Length != 13)
				{
					return false;
				}
				num = (short)1965817857;
				if (num != 0)
				{
				}
				num = (short)1900216322;
				num3 = (int)((global::System.IntPtr)num);
			}
			return true;
		}

		// Token: 0x06000BBD RID: 3005 RVA: 0x000ED88C File Offset: 0x000EBA8C
		private void ao(ref global::System.Collections.Generic.Dictionary<string, bool> A_0)
		{
			int a_ = 8;
			short num = (short)1712455683;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				string text;
				switch (num2)
				{
				case 0:
					num = (short)1600061448;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					if (this.bs == global::SpecialFeatures.Model_Configuration.ModelTiering.ActionTypes.FLASHPORT)
					{
						num = (short)509935626;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 2:
					if (this.bs != global::SpecialFeatures.Model_Configuration.ModelTiering.ActionTypes.OPEN)
					{
						num = (short)2047475719;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1E1;
				case 3:
					switch (0)
					{
					case 0:
						goto IL_69;
					}
					continue;
				case 4:
				{
					num = (short)1990712653;
					short num3 = num;
					num = (short)1152048461;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_350;
					default:
						num = (short)657522688;
						if (num != 0)
						{
						}
						goto IL_B8;
					}
					break;
				}
				case 5:
					goto IL_B8;
				case 6:
					if (this.bv.Count > 0)
					{
						num = (short)2061041673;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_B8;
				case 7:
					num = (short)630587393;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 8:
					if (this.bv != null)
					{
						num = (short)1627652109;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_B8;
				case 9:
					text = this.bv[0];
					num = (short)567607307;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 10:
					goto IL_1E1;
				case 11:
					if (this.d(text))
					{
						goto IL_350;
					}
					A_0.Add(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("슊쎌\udb8e풐솒\udb94횖춘튚튜톞", a_), false);
					num = (short)818872324;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 12:
					return;
				case 13:
					num = (short)1241579526;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 14:
					A_0.Add(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("슊쎌\udb8e풐솒\udb94횖춘튚튜톞", a_), true);
					this.bv[0] = this.bv[0].Substring(0, 12);
					num = (short)302645253;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_69:
				if (this.bs == global::SpecialFeatures.Model_Configuration.ModelTiering.ActionTypes.NEW)
				{
					num = (short)625475584;
					short num4 = num;
					num = (short)1664155648;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_B8:
				num = (short)1403584513;
				if (num != 0)
				{
				}
				num = (short)750256130;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_1E1:
				global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation radioInformation = global::AcpCommonLib.FeatureManager.GetFeature(2049)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation;
				text = radioInformation.General.RadInfoGeneralModelNumber_A8539.Value;
				int value = radioInformation.Labtool.RadInfoLabtoolProductModelIdentifier_A37178.Value;
				A_0.Add(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("슊쎌\udb8e풐솒\udb94횖춘튚튜톞", a_), global::SpecialFeatures.Model_Configuration.ModelTiering.a(value, text));
				num = (short)1602158604;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_350:
				num = (short)1129775118;
				num2 = (int)((global::System.IntPtr)num);
			}
		}

		// Token: 0x06000BBE RID: 3006 RVA: 0x000EDC08 File Offset: 0x000EBE08
		private static bool a(int A_0, string A_1)
		{
			int a_ = 16;
			switch (0)
			{
			case 0:
				goto IL_61;
			}
			int num;
			short num2;
			bool result;
			for (;;)
			{
				IL_13:
				switch (num)
				{
				case 0:
					num2 = (short)1793523724;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
					if (A_1 != global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udb92겔ꂖ춘\udc9a\ud99cꚞ钤", a_))
					{
						num2 = (short)1033764864;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				case 2:
					goto IL_78;
				case 3:
					if (A_0 == 10)
					{
						num2 = (short)24248331;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				case 4:
					if (A_1 != global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udb92겔ꖖ캘\ud89a\udb9cꚞ鎤", a_))
					{
						num2 = (short)604176393;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_E4;
				case 5:
					if (A_1.StartsWith(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udb92겔ꖖ", a_)))
					{
						num2 = (short)1544159248;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_E4;
				case 6:
					num2 = (short)81133573;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 7:
					return result;
				case 8:
				{
					num2 = (short)979238912;
					short num3 = num2;
					num2 = (short)491388931;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 9:
					num2 = (short)542703630;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 10:
					if (A_0 != 9)
					{
						num2 = (short)1327759368;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_97;
				case 11:
					goto IL_97;
				case 12:
					if (!A_1.StartsWith(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\ude92ꚔꞖ", a_)))
					{
						num2 = (short)688390159;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				case 13:
					return result;
				case 14:
				{
					num2 = (short)2141527072;
					short num4 = num2;
					num2 = (short)410917920;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_78;
					default:
						num2 = (short)945160193;
						if (num2 != 0)
						{
						}
						num2 = (short)1877475328;
						if (num2 != 0)
						{
						}
						if (A_1 != global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udb92겔ꖖ캘\ud89a햜ꚞ銤", a_))
						{
							num2 = (short)237371409;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_E4;
					}
					break;
				}
				case 15:
					result = true;
					num2 = (short)2359309;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 16:
					num2 = (short)1402994692;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 17:
					result = true;
					num2 = (short)286785543;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_61;
				IL_78:
				if (A_0 == 32)
				{
					num2 = (short)1857290246;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_E4;
				IL_97:
				num2 = (short)1847918593;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_E4:
				num2 = (short)503119882;
				num = (int)((global::System.IntPtr)num2);
			}
			return result;
			IL_61:
			result = false;
			num2 = (short)988413954;
			num = (int)((global::System.IntPtr)num2);
			goto IL_13;
		}

		// Token: 0x06000BBF RID: 3007 RVA: 0x000EDF78 File Offset: 0x000EC178
		private void an(ref global::System.Collections.Generic.Dictionary<string, bool> A_0)
		{
			int a_ = 15;
			short num = (short)1895890945;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				num = (short)1222115328;
				short num3 = num;
				switch (num2)
				{
				case 0:
					num = (short)701628421;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
				{
					num = (short)2081345397;
					short num4 = num;
					num = (short)683396981;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_F8;
					default:
						num = (short)985661441;
						if (num != 0)
						{
						}
						num = (short)1705508864;
						if (num != 0)
						{
						}
						switch (0)
						{
						case 0:
							goto IL_EC;
						}
						continue;
					}
					break;
				}
				case 2:
					this.bz.Add(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("솑삓쒕톗풙\udb9b솝殮ﲭ荒ﾻﾽ貿軁鯃鋅跇飉臋蟍黏鏑胓鿕韗铙", a_), this.RadioWideRef.Labtool.RadioWideLabtoolEmergencyCallTermination_43348.Value);
					this.bz.Add(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("솑삓쒕톗풙\udb9b솝殮ﾫﺱ諾龿賁诃迅鯇迉鏋鳍闏雑臓闕賗鏙鏛郝뿟껡ꇣ냥귧ꛩ돫꣭뿯ꃱ꯳럵믷맹맻귽叿䴁嘃伅䴇変", a_), this.RadioWideRef.Labtool.RadioWideLabtoolDisableWindNoiseReductionLevelForAccessories_43548.Value);
					this.bz.Add(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("솑삓쒕톗풙\udb9b솝殮ﺫﺱﲷ", a_), this.RadioWideRef.Labtool.MARVELL_DNP_43591.Value);
					num = (short)1653669896;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					if (this.RadioWideRef != null)
					{
						num = (short)1398734850;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 4:
					num = (short)1111556102;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
					if (this.bs != global::SpecialFeatures.Model_Configuration.ModelTiering.ActionTypes.OPEN)
					{
						num = (short)1227161604;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_112;
				case 6:
					if (this.bs == global::SpecialFeatures.Model_Configuration.ModelTiering.ActionTypes.FLASHPORT)
					{
						num = (short)2073886727;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 7:
					goto IL_112;
				case 8:
					return;
				}
				goto IL_EC;
				IL_F8:
				num = (short)2075983872;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_EC:
				if (this.bs != global::SpecialFeatures.Model_Configuration.ModelTiering.ActionTypes.NEW)
				{
					goto IL_F8;
				}
				break;
				IL_112:
				this.k(ref A_0);
				this.am(ref A_0);
				this.j(ref A_0);
				this.ad(ref A_0);
				this.ac(ref A_0);
				this.al(ref A_0);
				this.ai(ref A_0);
				this.ab(ref A_0);
				this.ak(ref A_0);
				this.aj(ref A_0);
				this.aa(ref A_0);
				this.ah(ref A_0);
				this.ag(ref A_0);
				this.z(ref A_0);
				this.af(ref A_0);
				this.ae(ref A_0);
				this.y(ref A_0);
				this.x(ref A_0);
				this.w(ref A_0);
				this.v(ref A_0);
				this.u(ref A_0);
				this.o(ref A_0);
				this.n(ref A_0);
				this.t(ref A_0);
				this.s(ref A_0);
				this.m(ref A_0);
				this.l(ref A_0);
				this.p(ref A_0);
				this.r(ref A_0);
				this.q(ref A_0);
				this.i(ref A_0);
				this.h(ref A_0);
				this.g(ref A_0);
				this.f(ref A_0);
				this.d(ref A_0);
				this.e(ref A_0);
				this.c(ref A_0);
				this.b(ref A_0);
				num = (short)947191811;
				num2 = (int)((global::System.IntPtr)num);
			}
		}

		// Token: 0x06000BC0 RID: 3008 RVA: 0x000EE2FC File Offset: 0x000EC4FC
		private void am(ref global::System.Collections.Generic.Dictionary<string, bool> A_0)
		{
			int a_ = 10;
			short num = (short)673447936;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_74;
				}
				global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation radioInformation;
				for (;;)
				{
					IL_31:
					bool value;
					bool flag;
					bool flag2;
					switch (num2)
					{
					case 0:
					{
						value = radioInformation.FrequencyRanges.RadInfoFrequencyRangesExtendedUHFR1Capable_A41443.Value;
						int value2 = radioInformation.Labtool.RadInfoLabtoolPrimaryBands_A23987.Value;
						int value3 = radioInformation.Labtool.RadInfoLabtoolSecondaryBands_A23988.Value;
						num = (short)474349580;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 1:
						return;
					case 2:
						flag = true;
						goto IL_149;
					case 3:
						if (radioInformation != null)
						{
							num = (short)799866880;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 4:
						num = (short)742785037;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						num = (short)791740423;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
						goto IL_229;
					case 7:
					{
						int value3;
						if (value3 != 5)
						{
							num = (short)1055522820;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_C2;
					}
					case 8:
						flag2 = radioInformation.Labtool.RadInfoLabtoolQA00571UHFRange1_A42594.Value;
						num = (short)286195718;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 9:
						goto IL_229;
					case 10:
					{
						int value2;
						if (value2 != 4)
						{
							num = (short)275906565;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_C2;
					}
					case 11:
					{
						int value2;
						if (value2 == 5)
						{
							goto IL_C2;
						}
						num = (short)624722147;
						short num3 = num;
						num = (short)1970045155;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_29D;
						default:
						{
							num = (short)1499594752;
							short num4 = num;
							num = (short)277676032;
							if (num != 0)
							{
							}
							num = (short)707067918;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						break;
					}
					case 12:
						if (global::ConstraintHelper.UtilityMack.IsFreonCodeplug(this.bu))
						{
							num = (short)307036168;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_29D;
					case 13:
					{
						int value3;
						flag = (value3 == 4);
						goto IL_149;
					}
					case 14:
						num = (short)427950090;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_74;
					IL_C2:
					num = (short)402980866;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_149:
					flag2 = flag;
					num = (short)1516371969;
					if (num != 0)
					{
					}
					num = (short)249954313;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_229:
					A_0.Add(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udc8c캎ꆐꂒꖔꊖ겘", a_), value && flag2);
					num = (short)1750925313;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_29D:
					num = (short)109248523;
					num2 = (int)((global::System.IntPtr)num);
				}
				return;
				IL_74:
				radioInformation = (global::AcpCommonLib.FeatureManager.GetFeature(2049)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation);
				num = (short)1845624835;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_31;
			}
			}
		}

		// Token: 0x06000BC1 RID: 3009 RVA: 0x000EE658 File Offset: 0x000EC858
		private void al(ref global::System.Collections.Generic.Dictionary<string, bool> A_0)
		{
			int a_ = 17;
			short num = (short)488335361;
			short num2 = num;
			num = (short)1218340865;
			global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide radioWide;
			int num3;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_104:
				A_0.Add(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("톓\udb95\udf97얙캛좝", a_), radioWide.Labtool.RadWideLabtoolEmergencyRevertCapable_A41918.Value);
				num = (short)52625410;
				num3 = (int)((global::System.IntPtr)num);
				break;
			case 1:
				goto IL_66;
			default:
			{
				num = (short)780075008;
				short num4 = num;
				goto IL_66;
			}
			}
			for (;;)
			{
				IL_86:
				switch (num3)
				{
				case 0:
					if (radioWide != null)
					{
						num = (short)361168897;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 1:
					goto IL_102;
				case 2:
					return;
				}
				goto IL_98;
			}
			IL_102:
			goto IL_104;
			IL_66:
			num = (short)2052587520;
			if (num != 0)
			{
			}
			switch (0)
			{
			case 0:
				goto IL_98;
			}
			goto IL_86;
			IL_98:
			num = (short)195690497;
			if (num != 0)
			{
			}
			radioWide = (global::AcpCommonLib.FeatureManager.GetFeature(2045)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide);
			num = (short)980811776;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_86;
		}

		// Token: 0x06000BC2 RID: 3010 RVA: 0x000EE7A8 File Offset: 0x000EC9A8
		private void ak(ref global::System.Collections.Generic.Dictionary<string, bool> A_0)
		{
			int a_ = 6;
			short num = (short)1363164543;
			short num2 = num;
			num = (short)1195916671;
			global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide radioWide;
			int num3;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_E2:
				A_0.Add(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쒈쪊쎌킎햐\udc92슔\ud996욘\ude9a킜\uda9eﲢ", a_), radioWide.Labtool.ManDownPersonalityConfigurableCapable_42082.Value);
				num = (short)1303314434;
				num3 = (int)((global::System.IntPtr)num);
				break;
			case 1:
				goto IL_6A;
			default:
			{
				num = (short)1748041728;
				short num4 = num;
				goto IL_6A;
			}
			}
			for (;;)
			{
				IL_8B:
				switch (num3)
				{
				case 0:
					if (radioWide != null)
					{
						num = (short)1365245953;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_121;
				case 1:
					goto IL_E0;
				case 2:
					goto IL_11F;
				}
				goto IL_9D;
			}
			IL_E0:
			goto IL_E2;
			IL_11F:
			IL_121:
			num = (short)1711472641;
			if (num != 0)
			{
			}
			return;
			IL_6A:
			num = (short)1077346304;
			if (num != 0)
			{
			}
			switch (0)
			{
			case 0:
				goto IL_9D;
			}
			goto IL_8B;
			IL_9D:
			radioWide = (global::AcpCommonLib.FeatureManager.GetFeature(2045)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide);
			num = (short)208732160;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_8B;
		}

		// Token: 0x06000BC3 RID: 3011 RVA: 0x000EE900 File Offset: 0x000ECB00
		private void aj(ref global::System.Collections.Generic.Dictionary<string, bool> A_0)
		{
			int a_ = 1;
			short num = (short)279215006;
			short num2 = num;
			num = (short)1241611166;
			global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide radioWide;
			int num3;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_DB:
				A_0.Add(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("솃쮅춇\ud889펋\uda8d\udf8f\udc91톓즕\udb97\udc99\udb9b", a_), radioWide.Labtool.ToneEmergencyConfigurableCapable_42083.Value);
				num = (short)746389505;
				if (num != 0)
				{
				}
				num = (short)1960050690;
				num3 = (int)((global::System.IntPtr)num);
				break;
			case 1:
				goto IL_67;
			default:
			{
				num = (short)960954368;
				short num4 = num;
				goto IL_67;
			}
			}
			for (;;)
			{
				IL_86:
				switch (num3)
				{
				case 0:
					if (radioWide != null)
					{
						num = (short)1481900033;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 1:
					goto IL_D9;
				case 2:
					return;
				}
				goto IL_98;
			}
			IL_D9:
			goto IL_DB;
			IL_67:
			num = (short)1905655808;
			if (num != 0)
			{
			}
			switch (0)
			{
			case 0:
				goto IL_98;
			}
			goto IL_86;
			IL_98:
			radioWide = (global::AcpCommonLib.FeatureManager.GetFeature(2045)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide);
			num = (short)934215680;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_86;
		}

		// Token: 0x06000BC4 RID: 3012 RVA: 0x000EEA4C File Offset: 0x000ECC4C
		private void ai(ref global::System.Collections.Generic.Dictionary<string, bool> A_0)
		{
			int a_ = 15;
			short num = (short)964860940;
			short num2 = num;
			num = (short)1178573836;
			global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide radioWide;
			int num3;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_106:
				A_0.Add(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("힑\ud993톕잗\ud899\ud99b\udf9d殮盛嶺節羚ﲱ", a_), radioWide.Labtool.RadWideLabtoolAudibleBeaconRoutingCapable_A41974.Value);
				num = (short)874643458;
				num3 = (int)((global::System.IntPtr)num);
				break;
			case 1:
				goto IL_67;
			default:
			{
				num = (short)705888256;
				short num4 = num;
				goto IL_67;
			}
			}
			for (;;)
			{
				IL_AF:
				switch (num3)
				{
				case 0:
					if (radioWide != null)
					{
						num = (short)215089153;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 1:
					goto IL_104;
				case 2:
					return;
				}
				goto IL_C1;
			}
			IL_104:
			goto IL_106;
			IL_67:
			num = (short)231931904;
			if (num != 0)
			{
			}
			num = (short)575733761;
			if (num != 0)
			{
			}
			switch (0)
			{
			case 0:
				goto IL_C1;
			}
			goto IL_AF;
			IL_C1:
			radioWide = (global::AcpCommonLib.FeatureManager.GetFeature(2045)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide);
			num = (short)684916736;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_AF;
		}

		// Token: 0x06000BC5 RID: 3013 RVA: 0x000EEBA0 File Offset: 0x000ECDA0
		private void ah(ref global::System.Collections.Generic.Dictionary<string, bool> A_0)
		{
			int a_ = 0;
			short num = (short)1433645372;
			short num2 = num;
			num = (short)1336979772;
			global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide radioWide;
			int num3;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_DC:
				A_0.Add(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쒂쒄랆뢈뮊뺌벎", a_), radioWide.Labtool.RadWideLabtoolMaritimeRadioSoftware_A42191.Value);
				num = (short)1168310274;
				num3 = (int)((global::System.IntPtr)num);
				break;
			default:
				num = (short)803602432;
				if (num != 0)
				{
				}
				num = (short)490602497;
				if (num != 0)
				{
				}
				switch (0)
				{
				case 0:
					goto IL_98;
				}
				break;
			}
			for (;;)
			{
				IL_86:
				switch (num3)
				{
				case 0:
					if (radioWide != null)
					{
						num = (short)1654849537;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_11B;
				case 1:
					goto IL_DA;
				case 2:
					goto IL_119;
				}
				goto IL_98;
			}
			IL_DA:
			goto IL_DC;
			IL_119:
			IL_11B:
			num = (short)1484062720;
			short num4 = num;
			return;
			IL_98:
			radioWide = (global::AcpCommonLib.FeatureManager.GetFeature(2045)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide);
			num = (short)91357184;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_86;
		}

		// Token: 0x06000BC6 RID: 3014 RVA: 0x000EECF4 File Offset: 0x000ECEF4
		private void ag(ref global::System.Collections.Generic.Dictionary<string, bool> A_0)
		{
			int a_ = 2;
			switch (0)
			{
			case 0:
				goto IL_25;
			}
			short num2;
			global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide radioWide;
			for (;;)
			{
				IL_13:
				int num;
				switch (num)
				{
				case 0:
					goto IL_DF;
				case 1:
					num2 = (short)370802689;
					if (num2 != 0)
					{
					}
					if (radioWide != null)
					{
						num2 = (short)7274496;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_120;
				case 2:
					goto IL_11E;
				}
				goto IL_25;
			}
			IL_DF:
			A_0.Add(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("임욆\uda88슊캌킎튐\udc92\udb94쎖쮘풚톜삞", a_), radioWide.Labtool.RadWideLabtoolMFKEmergencyAccess_A42216.Value);
			goto IL_106;
			IL_11E:
			IL_120:
			num2 = (short)532414464;
			short num3 = num2;
			return;
			IL_25:
			num2 = (short)168586111;
			short num4 = num2;
			num2 = (short)85814143;
			switch ((num4 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
			{
				IL_106:
				num2 = (short)2122448898;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_13;
			}
			default:
			{
				num2 = (short)443482112;
				if (num2 != 0)
				{
				}
				radioWide = (global::AcpCommonLib.FeatureManager.GetFeature(2045)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide);
				num2 = (short)214892545;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_13;
			}
			}
		}

		// Token: 0x06000BC7 RID: 3015 RVA: 0x000EEE4C File Offset: 0x000ED04C
		private void af(ref global::System.Collections.Generic.Dictionary<string, bool> A_0)
		{
			int a_ = 19;
			switch (0)
			{
			case 0:
				goto IL_25;
			}
			global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide radioWide;
			short num2;
			for (;;)
			{
				IL_13:
				int num;
				switch (num)
				{
				case 0:
					goto IL_BA;
				case 1:
					if (radioWide != null)
					{
						num2 = (short)1354498048;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_121;
				case 2:
					goto IL_11F;
				}
				goto IL_25;
			}
			IL_BA:
			A_0.Add(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\ude95힗캙쎛펝", a_), radioWide.Labtool.EmergencyHotAuxMicConfigurability_A42301.Value);
			goto IL_E1;
			IL_11F:
			IL_121:
			num2 = (short)1349058560;
			short num3 = num2;
			return;
			IL_25:
			num2 = (short)1187112938;
			short num4 = num2;
			num2 = (short)767223786;
			switch ((num4 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
			{
				IL_E1:
				num2 = (short)718929921;
				if (num2 != 0)
				{
				}
				num2 = (short)1027145730;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_13;
			}
			default:
			{
				num2 = (short)472907776;
				if (num2 != 0)
				{
				}
				radioWide = (global::AcpCommonLib.FeatureManager.GetFeature(2045)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide);
				num2 = (short)872087553;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_13;
			}
			}
		}

		// Token: 0x06000BC8 RID: 3016 RVA: 0x000EEFA4 File Offset: 0x000ED1A4
		private void ae(ref global::System.Collections.Generic.Dictionary<string, bool> A_0)
		{
			int a_ = 14;
			switch (0)
			{
			case 0:
				goto IL_25;
			}
			short num2;
			global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide radioWide;
			for (;;)
			{
				IL_13:
				int num;
				switch (num)
				{
				case 0:
					goto IL_E4;
				case 1:
					num2 = (short)1013055489;
					if (num2 != 0)
					{
					}
					if (radioWide != null)
					{
						num2 = (short)419102720;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_125;
				case 2:
					goto IL_123;
				}
				goto IL_25;
			}
			IL_E4:
			A_0.Add(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("킐욒톔\ude96\udb98힚\ud89c삞黀藂諄闆雈蛊苌跎飐鿒郔", a_), radioWide.Labtool.TPSCapable_A42312.Value);
			goto IL_10B;
			IL_123:
			IL_125:
			num2 = (short)1052311552;
			short num3 = num2;
			return;
			IL_25:
			num2 = (short)1563203014;
			short num4 = num2;
			num2 = (short)1755813318;
			switch ((num4 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
			{
				IL_10B:
				num2 = (short)406847490;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_13;
			}
			default:
			{
				num2 = (short)920059904;
				if (num2 != 0)
				{
				}
				radioWide = (global::AcpCommonLib.FeatureManager.GetFeature(2045)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide);
				num2 = (short)743768065;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_13;
			}
			}
		}

		// Token: 0x06000BC9 RID: 3017 RVA: 0x000EF100 File Offset: 0x000ED300
		private void ad(ref global::System.Collections.Generic.Dictionary<string, bool> A_0)
		{
			int a_ = 6;
			switch (0)
			{
			case 0:
				goto IL_25;
			}
			global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation radioInformation;
			short num2;
			for (;;)
			{
				IL_13:
				int num;
				switch (num)
				{
				case 0:
					goto IL_B7;
				case 1:
					if (radioInformation != null)
					{
						num2 = (short)588447744;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_FB;
				case 2:
					goto IL_F9;
				}
				goto IL_25;
			}
			IL_B7:
			A_0.Add(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("솈몊몌", a_), radioInformation.General.RadInfoGeneralRegionalGovernance_A36710.Value == 64);
			goto IL_E2;
			IL_F9:
			IL_FB:
			num2 = (short)761724929;
			if (num2 != 0)
			{
			}
			num2 = (short)874381312;
			short num3 = num2;
			return;
			IL_25:
			num2 = (short)949976626;
			short num4 = num2;
			num2 = (short)2029485618;
			switch ((num4 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
			{
				IL_E2:
				num2 = (short)860028930;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_13;
			}
			default:
			{
				num2 = (short)1649672192;
				if (num2 != 0)
				{
				}
				radioInformation = (global::AcpCommonLib.FeatureManager.GetFeature(2049)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation);
				num2 = (short)1699807233;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_13;
			}
			}
		}

		// Token: 0x06000BCA RID: 3018 RVA: 0x000EF25C File Offset: 0x000ED45C
		private void ac(ref global::System.Collections.Generic.Dictionary<string, bool> A_0)
		{
			int a_ = 9;
			switch (0)
			{
			case 0:
				goto IL_25;
			}
			global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation radioInformation;
			short num2;
			for (;;)
			{
				IL_13:
				int num;
				switch (num)
				{
				case 0:
					goto IL_B7;
				case 1:
					if (radioInformation != null)
					{
						num2 = (short)497090560;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_F8;
				case 2:
					goto IL_F6;
				}
				goto IL_25;
			}
			IL_B7:
			A_0.Add(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쮋쾍ꂏꎑꎓ꺕ꂗ", a_), radioInformation.Labtool.RadInfoLabtoolAPX1500EHNO3CH_A44832.Value);
			goto IL_DE;
			IL_F6:
			IL_F8:
			num2 = (short)1608974337;
			if (num2 != 0)
			{
			}
			num2 = (short)2130444288;
			short num3 = num2;
			return;
			IL_25:
			num2 = (short)1432328514;
			short num4 = num2;
			num2 = (short)834050370;
			switch ((num4 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
			{
				IL_DE:
				num2 = (short)1557135362;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_13;
			}
			default:
			{
				num2 = (short)2000224256;
				if (num2 != 0)
				{
				}
				radioInformation = (global::AcpCommonLib.FeatureManager.GetFeature(2049)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation);
				num2 = (short)1842741249;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_13;
			}
			}
		}

		// Token: 0x06000BCB RID: 3019 RVA: 0x000EF3B0 File Offset: 0x000ED5B0
		private void ab(ref global::System.Collections.Generic.Dictionary<string, bool> A_0)
		{
			int a_ = 2;
			switch (0)
			{
			case 0:
				goto IL_25;
			}
			global::Motorola.MackinawCPS.CoreFeatures.ConventionalWide.ConventionalWide conventionalWide;
			short num2;
			for (;;)
			{
				IL_13:
				int num;
				switch (num)
				{
				case 0:
					goto IL_E0;
				case 1:
					if (conventionalWide != null)
					{
						num2 = (short)1062993920;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_121;
				case 2:
					goto IL_11F;
				}
				goto IL_25;
			}
			IL_E0:
			A_0.Add(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("횄좆\udc88\ud98a캌쪎캐쎒횔\ude96욘\ude9a얜쾞ﾸ", a_), conventionalWide.Labtool.CnvWideLabtoolExpandedMDCID_A41790.Value);
			goto IL_107;
			IL_11F:
			IL_121:
			num2 = (short)321847296;
			short num3 = num2;
			return;
			IL_25:
			num2 = (short)1144596193;
			short num4 = num2;
			num2 = (short)1086269153;
			switch ((num4 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
			{
				IL_107:
				num2 = (short)674234370;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_13;
			}
			default:
			{
				num2 = (short)2027618305;
				if (num2 != 0)
				{
				}
				num2 = (short)947716096;
				if (num2 != 0)
				{
				}
				conventionalWide = (global::AcpCommonLib.FeatureManager.GetFeature(2024)[0] as global::Motorola.MackinawCPS.CoreFeatures.ConventionalWide.ConventionalWide);
				num2 = (short)1017839617;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_13;
			}
			}
		}

		// Token: 0x06000BCC RID: 3020 RVA: 0x000EF508 File Offset: 0x000ED708
		private void aa(ref global::System.Collections.Generic.Dictionary<string, bool> A_0)
		{
			int a_ = 5;
			switch (0)
			{
			case 0:
				goto IL_25;
			}
			global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide radioWide;
			short num2;
			for (;;)
			{
				IL_13:
				int num;
				switch (num)
				{
				case 0:
					goto IL_E3;
				case 1:
					if (radioWide != null)
					{
						num2 = (short)1714094080;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_123;
				case 2:
					goto IL_121;
				}
				goto IL_25;
			}
			IL_E3:
			A_0.Add(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udb87얉\ud98b\udc8d펏힑쮓욕\udb97펙쎛\uda9dﶯﶷﾻ龿臁藃諅蓇闉藋胍铏鯑韓韕賗鏙鏛郝돟뷡꟣꟥룧ꯩ껫ꋭ뗯", a_), radioWide.Labtool.RadWideLabtoolSuppressEmergencyCallCapability_A42143.Value);
			goto IL_10A;
			IL_121:
			IL_123:
			num2 = (short)960888832;
			short num3 = num2;
			return;
			IL_25:
			num2 = (short)1828140194;
			short num4 = num2;
			num2 = (short)493565090;
			switch ((num4 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
			{
				IL_10A:
				num2 = (short)110755842;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_13;
			}
			default:
			{
				num2 = (short)1802371072;
				if (num2 != 0)
				{
				}
				radioWide = (global::AcpCommonLib.FeatureManager.GetFeature(2045)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide);
				num2 = (short)1919090689;
				if (num2 != 0)
				{
				}
				num2 = (short)1742733313;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_13;
			}
			}
		}

		// Token: 0x06000BCD RID: 3021 RVA: 0x000EF664 File Offset: 0x000ED864
		private void z(ref global::System.Collections.Generic.Dictionary<string, bool> A_0)
		{
			int a_ = 0;
			switch (0)
			{
			case 0:
				goto IL_25;
			}
			global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide radioWide;
			short num2;
			for (;;)
			{
				IL_13:
				int num;
				switch (num)
				{
				case 0:
					goto IL_B7;
				case 1:
					if (radioWide != null)
					{
						num2 = (short)324730880;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_F7;
				case 2:
					goto IL_F5;
				}
				goto IL_25;
			}
			IL_B7:
			A_0.Add(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("킂쪄튆\udb88좊좌킎손킒\udc94좖즘\uda9a캜첞ﺠﮨﾲﺼﺾ釀苂蟄识賈", a_), radioWide.Labtool.PASSAlarmFilterCapable_A42387.Value);
			goto IL_DE;
			IL_F5:
			IL_F7:
			num2 = (short)2136801281;
			if (num2 != 0)
			{
			}
			num2 = (short)689897472;
			short num3 = num2;
			return;
			IL_25:
			num2 = (short)1853482945;
			short num4 = num2;
			num2 = (short)1026090945;
			switch ((num4 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
			{
				IL_DE:
				num2 = (short)169213954;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_13;
			}
			default:
			{
				num2 = (short)315162624;
				if (num2 != 0)
				{
				}
				radioWide = (global::AcpCommonLib.FeatureManager.GetFeature(2045)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide);
				num2 = (short)2050424833;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_13;
			}
			}
		}

		// Token: 0x06000BCE RID: 3022 RVA: 0x000EF7BC File Offset: 0x000ED9BC
		private void y(ref global::System.Collections.Generic.Dictionary<string, bool> A_0)
		{
			int a_ = 2;
			switch (0)
			{
			case 0:
				goto IL_25;
			}
			global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide radioWide;
			short num2;
			for (;;)
			{
				IL_13:
				int num;
				switch (num)
				{
				case 0:
					goto IL_DF;
				case 1:
					if (radioWide != null)
					{
						num2 = (short)1778384896;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_120;
				case 2:
					goto IL_11E;
				}
				goto IL_25;
			}
			IL_DF:
			A_0.Add(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("풄욆릈뾊떌릎꒐", a_), radioWide.Labtool.RadWideLabtoolAPXDualKnobs_A42537.Value);
			goto IL_106;
			IL_11E:
			IL_120:
			num2 = (short)1136459776;
			short num3 = num2;
			return;
			IL_25:
			num2 = (short)600130703;
			short num4 = num2;
			num2 = (short)1704412303;
			switch ((num4 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
			{
				IL_106:
				num2 = (short)269484034;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_13;
			}
			default:
			{
				num2 = (short)1587150848;
				if (num2 != 0)
				{
				}
				num2 = (short)842596353;
				if (num2 != 0)
				{
				}
				radioWide = (global::AcpCommonLib.FeatureManager.GetFeature(2045)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide);
				num2 = (short)624558081;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_13;
			}
			}
		}

		// Token: 0x06000BCF RID: 3023 RVA: 0x000EF914 File Offset: 0x000EDB14
		private void x(ref global::System.Collections.Generic.Dictionary<string, bool> A_0)
		{
			int a_ = 11;
			switch (0)
			{
			case 0:
				goto IL_25;
			}
			global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide radioWide;
			short num2;
			for (;;)
			{
				IL_13:
				int num;
				switch (num)
				{
				case 0:
					goto IL_E1;
				case 1:
					if (radioWide != null)
					{
						num2 = (short)1131282432;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_121;
				case 2:
					goto IL_11F;
				}
				goto IL_25;
			}
			IL_E1:
			A_0.Add(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쾍얏횑\udd93\ud995잗\udf99튛횝", a_), radioWide.Labtool.RadWideLabtoolAudioEnhancement_A42736.Value);
			goto IL_108;
			IL_11F:
			IL_121:
			num2 = (short)847708160;
			short num3 = num2;
			return;
			IL_25:
			num2 = (short)1368980387;
			short num4 = num2;
			num2 = (short)224918435;
			switch ((num4 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
			{
				IL_108:
				num2 = (short)1323040770;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_13;
			}
			default:
			{
				num2 = (short)2028339200;
				if (num2 != 0)
				{
				}
				num2 = (short)550109185;
				if (num2 != 0)
				{
				}
				radioWide = (global::AcpCommonLib.FeatureManager.GetFeature(2045)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide);
				num2 = (short)445054977;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_13;
			}
			}
		}

		// Token: 0x06000BD0 RID: 3024 RVA: 0x000EFA6C File Offset: 0x000EDC6C
		private void w(ref global::System.Collections.Generic.Dictionary<string, bool> A_0)
		{
			int a_ = 9;
			switch (0)
			{
			case 0:
				goto IL_25;
			}
			global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide radioWide;
			short num2;
			for (;;)
			{
				IL_13:
				int num;
				switch (num)
				{
				case 0:
					goto IL_BA;
				case 1:
					if (radioWide != null)
					{
						num2 = (short)1454440448;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_FB;
				case 2:
					goto IL_F9;
				}
				goto IL_25;
			}
			IL_BA:
			A_0.Add(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udf8b\uda8d슏\udb91\uda93톕잗쪙\udf9b힝ﾟ鶭肯花蒳ﶷﾽ躿臁臃", a_), radioWide.Labtool.RadioWideMOSCADACE3000Capability_A42772.Value);
			goto IL_E1;
			IL_F9:
			IL_FB:
			num2 = (short)1822621697;
			if (num2 != 0)
			{
			}
			num2 = (short)297926656;
			short num3 = num2;
			return;
			IL_25:
			num2 = (short)1886893037;
			short num4 = num2;
			num2 = (short)1231664109;
			switch ((num4 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
			{
				IL_E1:
				num2 = (short)1856438274;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_13;
			}
			default:
			{
				num2 = (short)1998520320;
				if (num2 != 0)
				{
				}
				radioWide = (global::AcpCommonLib.FeatureManager.GetFeature(2045)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide);
				num2 = (short)256835585;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_13;
			}
			}
		}

		// Token: 0x06000BD1 RID: 3025 RVA: 0x000EFBC8 File Offset: 0x000EDDC8
		private void v(ref global::System.Collections.Generic.Dictionary<string, bool> A_0)
		{
			int a_ = 1;
			switch (0)
			{
			case 0:
				goto IL_25;
			}
			global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide radioWide;
			short num2;
			for (;;)
			{
				IL_13:
				int num;
				switch (num)
				{
				case 0:
					goto IL_E0;
				case 1:
					if (radioWide != null)
					{
						num2 = (short)1739128832;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_121;
				case 2:
					goto IL_11F;
				}
				goto IL_25;
			}
			IL_E0:
			A_0.Add(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("힃튅\uda87쎉슋즍쾏슑힓\udf95잗쪙\ud99b첝﮳ﶻﲽ覿軁跃鋅采闉跋苍闏胑胓觕鯗鯙賛鿝ꋟꯡ꣣꿥볧돩", a_), radioWide.Labtool.RadWideLabtoolPAAlertCapability_A42944.Value);
			goto IL_107;
			IL_11F:
			IL_121:
			num2 = (short)218693632;
			short num3 = num2;
			return;
			IL_25:
			num2 = (short)1427823498;
			short num4 = num2;
			num2 = (short)1376705418;
			switch ((num4 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
			{
				IL_107:
				num2 = (short)396427266;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_13;
			}
			default:
			{
				num2 = (short)349700097;
				if (num2 != 0)
				{
				}
				num2 = (short)1819148288;
				if (num2 != 0)
				{
				}
				radioWide = (global::AcpCommonLib.FeatureManager.GetFeature(2045)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide);
				num2 = (short)1890254849;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_13;
			}
			}
		}

		// Token: 0x06000BD2 RID: 3026 RVA: 0x000EFD20 File Offset: 0x000EDF20
		private void u(ref global::System.Collections.Generic.Dictionary<string, bool> A_0)
		{
			int a_ = 0;
			switch (0)
			{
			case 0:
				goto IL_25;
			}
			global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide radioWide;
			short num2;
			for (;;)
			{
				IL_13:
				int num;
				switch (num)
				{
				case 0:
					goto IL_DE;
				case 1:
					if (radioWide != null)
					{
						num2 = (short)63438848;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_11E;
				case 2:
					goto IL_11C;
				}
				goto IL_25;
			}
			IL_DE:
			A_0.Add(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("킂톄햆삈얊쪌킎손킒\udc94좖처좚\ud89c춞ﺠ怜ﾲ諭迀诂蓄视諈車背諎鿐蟒", a_), radioWide.Labtool.RadWideLabtoolUserSelectablePLEnhancement_43031.Value);
			goto IL_105;
			IL_11C:
			IL_11E:
			num2 = (short)756809728;
			short num3 = num2;
			return;
			IL_25:
			num2 = (short)1092943873;
			if (num2 != 0)
			{
			}
			num2 = (short)56978993;
			short num4 = num2;
			num2 = (short)1997041201;
			switch ((num4 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
			{
				IL_105:
				num2 = (short)1205141506;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_13;
			}
			default:
			{
				num2 = (short)291831808;
				if (num2 != 0)
				{
				}
				radioWide = (global::AcpCommonLib.FeatureManager.GetFeature(2045)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide);
				num2 = (short)1740505089;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_13;
			}
			}
		}

		// Token: 0x06000BD3 RID: 3027 RVA: 0x000EFE74 File Offset: 0x000EE074
		private void t(ref global::System.Collections.Generic.Dictionary<string, bool> A_0)
		{
			int a_ = 9;
			switch (0)
			{
			case 0:
				goto IL_25;
			}
			global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide radioWide;
			short num2;
			for (;;)
			{
				IL_13:
				int num;
				switch (num)
				{
				case 0:
					goto IL_E0;
				case 1:
					if (radioWide != null)
					{
						num2 = (short)1720909824;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_122;
				case 2:
					goto IL_120;
				}
				goto IL_25;
			}
			IL_E0:
			A_0.Add(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udf8b\uda8d슏\udb91\uda93톕잗쪙\udf9b힝ﾟﲩﶯﮱﺷ邿雁郃", a_), radioWide.Labtool.RadWideLabtoolActiveMicForBTPTTCapable_43053.Value);
			goto IL_107;
			IL_120:
			IL_122:
			num2 = (short)1010565120;
			short num3 = num2;
			return;
			IL_25:
			num2 = (short)1977286657;
			if (num2 != 0)
			{
			}
			num2 = (short)1841344918;
			short num4 = num2;
			num2 = (short)689090966;
			switch ((num4 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
			{
				IL_107:
				num2 = (short)1166868482;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_13;
			}
			default:
			{
				num2 = (short)1544290304;
				if (num2 != 0)
				{
				}
				radioWide = (global::AcpCommonLib.FeatureManager.GetFeature(2045)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide);
				num2 = (short)461832193;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_13;
			}
			}
		}

		// Token: 0x06000BD4 RID: 3028 RVA: 0x000EFFD0 File Offset: 0x000EE1D0
		private void s(ref global::System.Collections.Generic.Dictionary<string, bool> A_0)
		{
			int a_ = 16;
			switch (0)
			{
			case 0:
				goto IL_25;
			}
			global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide radioWide;
			short num2;
			for (;;)
			{
				IL_13:
				int num;
				switch (num)
				{
				case 0:
					goto IL_BC;
				case 1:
					if (radioWide != null)
					{
						num2 = (short)1393950720;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_125;
				case 2:
					goto IL_123;
				}
				goto IL_25;
			}
			IL_BC:
			A_0.Add(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("삒솔얖킘햚\uda9c삞ﮪ者﮴ﺺ迀蛂髄蓆裈鯊賌跎鷐雒", a_), radioWide.Labtool.RadWideLabtoolAPXSingletoneCapable_43080.Value);
			goto IL_E3;
			IL_123:
			IL_125:
			num2 = (short)1470496768;
			short num3 = num2;
			return;
			IL_25:
			num2 = (short)1565386179;
			short num4 = num2;
			num2 = (short)1214244291;
			switch ((num4 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
			{
				IL_E3:
				num2 = (short)1047789569;
				if (num2 != 0)
				{
				}
				num2 = (short)2139160578;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_13;
			}
			default:
			{
				num2 = (short)430178304;
				if (num2 != 0)
				{
				}
				radioWide = (global::AcpCommonLib.FeatureManager.GetFeature(2045)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide);
				num2 = (short)1813643265;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_13;
			}
			}
		}

		// Token: 0x06000BD5 RID: 3029 RVA: 0x000F012C File Offset: 0x000EE32C
		private void r(ref global::System.Collections.Generic.Dictionary<string, bool> A_0)
		{
			int a_ = 8;
			switch (0)
			{
			case 0:
				goto IL_25;
			}
			global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide radioWide;
			short num2;
			for (;;)
			{
				IL_13:
				int num;
				switch (num)
				{
				case 0:
					goto IL_BA;
				case 1:
					if (radioWide != null)
					{
						num2 = (short)2001862656;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_122;
				case 2:
					goto IL_120;
				}
				goto IL_25;
			}
			IL_BA:
			num2 = (short)819134465;
			if (num2 != 0)
			{
			}
			A_0.Add(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\ud88a\ud98c\udd8e\ud890\udd92튔좖즘\ud89a풜삞ﶬﾲ", a_), radioWide.Labtool.RadWideLabtoolIntelligentPriorityScanCapable_43411.Value);
			goto IL_109;
			IL_120:
			IL_122:
			num2 = (short)695402496;
			short num3 = num2;
			return;
			IL_25:
			num2 = (short)1500244914;
			short num4 = num2;
			num2 = (short)1805249458;
			switch ((num4 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
			{
				IL_109:
				num2 = (short)592445442;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_13;
			}
			default:
			{
				num2 = (short)423034880;
				if (num2 != 0)
				{
				}
				radioWide = (global::AcpCommonLib.FeatureManager.GetFeature(2045)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide);
				num2 = (short)1172635649;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_13;
			}
			}
		}

		// Token: 0x06000BD6 RID: 3030 RVA: 0x000F0284 File Offset: 0x000EE484
		private void q(ref global::System.Collections.Generic.Dictionary<string, bool> A_0)
		{
			int a_ = 14;
			switch (0)
			{
			case 0:
				goto IL_2D;
			}
			short num2;
			for (;;)
			{
				IL_13:
				int num;
				switch (num)
				{
				case 0:
					goto IL_146;
				case 1:
					num2 = (short)2137653250;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
				{
					global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide radioWide;
					if (radioWide.Labtool.TEN_DIGIT_RL_PSWD_capable_43711.Value)
					{
						num2 = (short)398721028;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					A_0.Add(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("슐\udc92삔얖\uda98\ude9a슜쾞瘝ﶰﲲﲶﺺ蓀跂雄軆蛈藊鋌賎郐菒铔闖闘黚", a_), false);
					num2 = (short)342949888;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 3:
				{
					global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide radioWide;
					if (radioWide != null)
					{
						num2 = (short)438108161;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				}
				case 4:
					goto IL_1A0;
				}
				goto IL_2D;
			}
			IL_146:
			return;
			IL_1A0:
			A_0.Add(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("슐\udc92삔얖\uda98\ude9a슜쾞瘝ﶰﲲﲶﺺ蓀跂雄軆蛈藊鋌賎郐菒铔闖闘黚", a_), true);
			return;
			IL_2D:
			num2 = (short)1205172579;
			short num3 = num2;
			num2 = (short)1075345763;
			switch ((num3 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
				return;
			default:
			{
				num2 = (short)711262208;
				if (num2 != 0)
				{
				}
				num2 = (short)563675137;
				if (num2 != 0)
				{
				}
				num2 = (short)300941312;
				short num4 = num2;
				global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide radioWide = global::AcpCommonLib.FeatureManager.GetFeature(2045)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide;
				num2 = (short)1825112067;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_13;
			}
			}
		}

		// Token: 0x06000BD7 RID: 3031 RVA: 0x000F0434 File Offset: 0x000EE634
		private void p(ref global::System.Collections.Generic.Dictionary<string, bool> A_0)
		{
			int a_ = 16;
			switch (0)
			{
			case 0:
				goto IL_25;
			}
			global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide radioWide;
			short num2;
			for (;;)
			{
				IL_13:
				int num;
				switch (num)
				{
				case 0:
					goto IL_BB;
				case 1:
					if (radioWide != null)
					{
						num2 = (short)1729560576;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_122;
				case 2:
					goto IL_120;
				}
				goto IL_25;
			}
			IL_BB:
			A_0.Add(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("삒솔얖킘햚\uda9c삞領ﺺﲾ胀鏂蓄藆藈車", a_), radioWide.Labtool.RadioWideLabtoolZoneCloneCapable_43238.Value);
			goto IL_E2;
			IL_120:
			IL_122:
			num2 = (short)98762752;
			short num3 = num2;
			return;
			IL_25:
			num2 = (short)190272936;
			short num4 = num2;
			num2 = (short)1858557352;
			switch ((num4 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
			{
				IL_E2:
				num2 = (short)1899102209;
				if (num2 != 0)
				{
				}
				num2 = (short)1644363778;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_13;
			}
			default:
			{
				num2 = (short)1660616704;
				if (num2 != 0)
				{
				}
				radioWide = (global::AcpCommonLib.FeatureManager.GetFeature(2045)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide);
				num2 = (short)1669791745;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_13;
			}
			}
		}

		// Token: 0x06000BD8 RID: 3032 RVA: 0x000F0590 File Offset: 0x000EE790
		private void o(ref global::System.Collections.Generic.Dictionary<string, bool> A_0)
		{
			int a_ = 9;
			short num = (short)415498241;
			if (num != 0)
			{
			}
			switch (0)
			{
			case 0:
				goto IL_4C;
			}
			global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide radioWide;
			for (;;)
			{
				IL_3A:
				int num2;
				switch (num2)
				{
				case 0:
					goto IL_DF;
				case 1:
					if (radioWide != null)
					{
						num = (short)1534459904;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_120;
				case 2:
					goto IL_11E;
				}
				goto IL_4C;
			}
			IL_DF:
			A_0.Add(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udf8b\uda8d슏\udb91\uda93톕잗쪙\udf9b힝ﾟﮧﲷﶻﶽ钿证诃装鯇闉觋胍飏鏑髓闕鷗韙駛郝듟", a_), radioWide.Labtool.RadWideLabtoolConsolidatedActionEnhancement_A43036.Value);
			goto IL_106;
			IL_11E:
			IL_120:
			num = (short)1653538816;
			short num3 = num;
			return;
			IL_4C:
			num = (short)88563116;
			short num4 = num;
			num = (short)639589804;
			switch ((num4 == num) ? 1 : 0)
			{
			case 0:
			case 2:
			{
				IL_106:
				num = (short)709296130;
				int num2 = (int)((global::System.IntPtr)num);
				goto IL_3A;
			}
			default:
			{
				num = (short)1589968896;
				if (num != 0)
				{
				}
				radioWide = (global::AcpCommonLib.FeatureManager.GetFeature(2045)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide);
				num = (short)513409025;
				int num2 = (int)((global::System.IntPtr)num);
				goto IL_3A;
			}
			}
		}

		// Token: 0x06000BD9 RID: 3033 RVA: 0x000F06E8 File Offset: 0x000EE8E8
		private void n(ref global::System.Collections.Generic.Dictionary<string, bool> A_0)
		{
			int a_ = 14;
			switch (0)
			{
			case 0:
				goto IL_25;
			}
			global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide radioWide;
			short num2;
			for (;;)
			{
				IL_13:
				int num;
				switch (num)
				{
				case 0:
					goto IL_E1;
				case 1:
					if (radioWide != null)
					{
						num2 = (short)1403256833;
						if (num2 != 0)
						{
						}
						num2 = (short)183894016;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_121;
				case 2:
					goto IL_11F;
				}
				goto IL_25;
			}
			IL_E1:
			A_0.Add(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("슐잒잔\ude96힘\udc9a슜쾞瘝ﮮﺶ藀闂韄铆雈蓊鷌諎菐鋒臔黖雘闚苜鳞ꃠ돢ꓤꗦꗨ껪", a_), radioWide.Labtool.RadWideLabtoolLimitedISSIDVRSOperationCapable_43045.Value);
			goto IL_108;
			IL_11F:
			IL_121:
			num2 = (short)1229258752;
			short num3 = num2;
			return;
			IL_25:
			num2 = (short)1972362927;
			short num4 = num2;
			num2 = (short)1759764143;
			switch ((num4 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
			{
				IL_108:
				num2 = (short)612564994;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_13;
			}
			default:
			{
				num2 = (short)1078067200;
				if (num2 != 0)
				{
				}
				radioWide = (global::AcpCommonLib.FeatureManager.GetFeature(2045)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide);
				num2 = (short)1501495297;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_13;
			}
			}
		}

		// Token: 0x06000BDA RID: 3034 RVA: 0x000F0840 File Offset: 0x000EEA40
		private void m(ref global::System.Collections.Generic.Dictionary<string, bool> A_0)
		{
			int a_ = 1;
			short num = (short)539426817;
			if (num != 0)
			{
			}
			switch (0)
			{
			case 0:
				goto IL_4C;
			}
			global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide radioWide;
			for (;;)
			{
				IL_3A:
				int num2;
				switch (num2)
				{
				case 0:
					goto IL_DF;
				case 1:
					if (radioWide != null)
					{
						num = (short)1825177600;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_11F;
				case 2:
					goto IL_11D;
				}
				goto IL_4C;
			}
			IL_DF:
			A_0.Add(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("힃튅\uda87쎉슋즍쾏슑힓\udf95잗\udf99튛횝ﲭ", a_), radioWide.Labtool.RadWideLabtoolEnhancedARS_A43084.Value);
			goto IL_106;
			IL_11D:
			IL_11F:
			num = (short)1770127360;
			short num3 = num;
			return;
			IL_4C:
			num = (short)8346494;
			short num4 = num;
			num = (short)990206846;
			switch ((num4 == num) ? 1 : 0)
			{
			case 0:
			case 2:
			{
				IL_106:
				num = (short)162332674;
				int num2 = (int)((global::System.IntPtr)num);
				goto IL_3A;
			}
			default:
			{
				num = (short)2143289344;
				if (num != 0)
				{
				}
				radioWide = (global::AcpCommonLib.FeatureManager.GetFeature(2045)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide);
				num = (short)1964900353;
				int num2 = (int)((global::System.IntPtr)num);
				goto IL_3A;
			}
			}
		}

		// Token: 0x06000BDB RID: 3035 RVA: 0x000F0998 File Offset: 0x000EEB98
		private void l(ref global::System.Collections.Generic.Dictionary<string, bool> A_0)
		{
			int a_ = 18;
			short num = (short)1731330049;
			if (num != 0)
			{
			}
			switch (0)
			{
			case 0:
				goto IL_4C;
			}
			global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide radioWide;
			for (;;)
			{
				IL_3A:
				int num2;
				switch (num2)
				{
				case 0:
					goto IL_E0;
				case 1:
					if (radioWide != null)
					{
						num = (short)826408960;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_121;
				case 2:
					goto IL_11F;
				}
				goto IL_4C;
			}
			IL_E0:
			A_0.Add(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("요쎖쮘튚펜\ud89eﺠ禮視ﲾ胀迂规飆蛈藊臌雎軐蓒鳔菖釘蓚關郞뗠볢꣤껦ꫨ듪껬껮ꇰ닲럴믶본", a_), radioWide.Labtool.RadWideLabtoolEmergencyCallOnlywithHotMicCapable_A43162.Value);
			goto IL_107;
			IL_11F:
			IL_121:
			num = (short)1603272704;
			short num3 = num;
			return;
			IL_4C:
			num = (short)434174619;
			short num4 = num;
			num = (short)457702043;
			switch ((num4 == num) ? 1 : 0)
			{
			case 0:
			case 2:
			{
				IL_107:
				num = (short)1512636418;
				int num2 = (int)((global::System.IntPtr)num);
				goto IL_3A;
			}
			default:
			{
				num = (short)950009856;
				if (num != 0)
				{
				}
				radioWide = (global::AcpCommonLib.FeatureManager.GetFeature(2045)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide);
				num = (short)288227329;
				int num2 = (int)((global::System.IntPtr)num);
				goto IL_3A;
			}
			}
		}

		// Token: 0x06000BDC RID: 3036 RVA: 0x000F0AF4 File Offset: 0x000EECF4
		private void k(ref global::System.Collections.Generic.Dictionary<string, bool> A_0)
		{
			int a_ = 13;
			switch (0)
			{
			case 0:
				goto IL_25;
			}
			short num2;
			global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation radioInformation;
			for (;;)
			{
				IL_13:
				int num;
				switch (num)
				{
				case 0:
					goto IL_DF;
				case 1:
					num2 = (short)1714421761;
					if (num2 != 0)
					{
					}
					if (radioInformation != null)
					{
						num2 = (short)2048983040;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_122;
				case 2:
					goto IL_120;
				}
				goto IL_25;
			}
			IL_DF:
			bool value = radioInformation.FrequencyRanges.RadInfoFrequencyRangesExtendRange762Capable_A43555.Value;
			A_0.Add(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("솏펑꒓ꆕ겗겙꒛", a_), value);
			goto IL_108;
			IL_120:
			IL_122:
			num2 = (short)210894848;
			short num3 = num2;
			return;
			IL_25:
			num2 = (short)24995624;
			short num4 = num2;
			num2 = (short)1201891112;
			switch ((num4 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
			{
				IL_108:
				num2 = (short)1580007426;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_13;
			}
			default:
			{
				num2 = (short)773062656;
				if (num2 != 0)
				{
				}
				radioInformation = (global::AcpCommonLib.FeatureManager.GetFeature(2049)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation);
				num2 = (short)607453185;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_13;
			}
			}
		}

		// Token: 0x06000BDD RID: 3037 RVA: 0x000F0C50 File Offset: 0x000EEE50
		private void j(ref global::System.Collections.Generic.Dictionary<string, bool> A_0)
		{
			int a_ = 19;
			short num = (short)1622802433;
			if (num != 0)
			{
			}
			switch (0)
			{
			case 0:
				goto IL_5A;
			}
			global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation radioInformation;
			for (;;)
			{
				IL_3C:
				int num2;
				switch (num2)
				{
				case 0:
					if (radioInformation.FrequencyRanges.RadInfoFrequencyRangesUHFR1480MHzHoptinEnabled_A43575.Value)
					{
						num = (short)116195333;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)2128347139;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					return;
				case 2:
					goto IL_132;
				case 3:
					goto IL_19F;
				case 4:
					if (radioInformation == null)
					{
						num = (short)577372161;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)528678912;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
					num = (short)1375535106;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_5A;
			}
			return;
			IL_132:
			bool flag = radioInformation.FrequencyRanges.RadInfoFrequencyRangesFWCapableUHFR1480MHz_A43576.Value;
			goto IL_1A2;
			IL_5A:
			num = (short)551531622;
			short num3 = num;
			num = (short)1233957990;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_19F:
				flag = false;
				break;
			default:
			{
				num = (short)1811349504;
				if (num != 0)
				{
				}
				num = (short)2122383360;
				short num4 = num;
				radioInformation = (global::AcpCommonLib.FeatureManager.GetFeature(2049)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation);
				num = (short)498139140;
				int num2 = (int)((global::System.IntPtr)num);
				goto IL_3C;
			}
			}
			IL_1A2:
			bool value = flag;
			radioInformation.FrequencyRanges.RadInfoFrequencyRangesExtendedUHFR1480MHzCapable_A43578.Value = value;
			A_0.Add(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("잕\ud997ꪙꮛꮝ銟鎡", a_), value);
		}

		// Token: 0x06000BDE RID: 3038 RVA: 0x000F0E28 File Offset: 0x000EF028
		private void i(ref global::System.Collections.Generic.Dictionary<string, bool> A_0)
		{
			int a_ = 0;
			switch (0)
			{
			case 0:
				goto IL_25;
			}
			global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide radioWide;
			short num2;
			for (;;)
			{
				IL_13:
				int num;
				switch (num)
				{
				case 0:
					goto IL_E0;
				case 1:
					if (radioWide != null)
					{
						num2 = (short)108658688;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_121;
				case 2:
					goto IL_11F;
				}
				goto IL_25;
			}
			IL_E0:
			A_0.Add(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("킂톄햆삈얊쪌킎손킒\udc94좖\udc98쎚즜\uda9eﮪﲲ﮴", a_), radioWide.Labtool.RadioWideLabtoolExtendedPLToneSet_43769.Value);
			goto IL_107;
			IL_11F:
			IL_121:
			num2 = (short)310837248;
			short num3 = num2;
			return;
			IL_25:
			num2 = (short)1399892536;
			short num4 = num2;
			num2 = (short)82815544;
			switch ((num4 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
			{
				IL_107:
				num2 = (short)959840258;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_13;
			}
			default:
			{
				num2 = (short)913637376;
				if (num2 != 0)
				{
				}
				num2 = (short)1824194561;
				if (num2 != 0)
				{
				}
				radioWide = (global::AcpCommonLib.FeatureManager.GetFeature(2045)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide);
				num2 = (short)767688705;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_13;
			}
			}
		}

		// Token: 0x06000BDF RID: 3039 RVA: 0x000F0F80 File Offset: 0x000EF180
		private void h(ref global::System.Collections.Generic.Dictionary<string, bool> A_0)
		{
			int a_ = 11;
			for (;;)
			{
				IL_09:
				switch (0)
				{
				case 0:
					goto IL_25;
				}
				int num;
				global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide radioWide;
				short num2;
				for (;;)
				{
					IL_13:
					switch (num)
					{
					case 0:
						return;
					case 1:
					{
						A_0.Add(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udd8d쒏삑\udd93\ud895\udf97얙첛\udd9dﶡﮫﾹﾻ銿蟁", a_), radioWide.Labtool.AllowPSUSecure_43809.Value);
						num2 = (short)1876580641;
						short num3 = num2;
						num2 = (short)576280865;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_09;
						default:
						{
							num2 = (short)1107951616;
							if (num2 != 0)
							{
							}
							num2 = (short)251396096;
							short num4 = num2;
							num2 = (short)1395785728;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						}
						break;
					}
					case 2:
						if (radioWide != null)
						{
							num2 = (short)1457586177;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						return;
					}
					break;
				}
				IL_25:
				radioWide = (global::AcpCommonLib.FeatureManager.GetFeature(2045)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide);
				num2 = (short)67043329;
				if (num2 != 0)
				{
				}
				num2 = (short)574619650;
				num = (int)((global::System.IntPtr)num2);
				goto IL_13;
			}
		}

		// Token: 0x06000BE0 RID: 3040 RVA: 0x000F10D4 File Offset: 0x000EF2D4
		private void g(ref global::System.Collections.Generic.Dictionary<string, bool> A_0)
		{
			int a_ = 10;
			for (;;)
			{
				IL_09:
				switch (0)
				{
				case 0:
					goto IL_25;
				}
				int num;
				global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide radioWide;
				short num2;
				for (;;)
				{
					IL_13:
					switch (num)
					{
					case 0:
						return;
					case 1:
					{
						A_0.Add(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\ude8c\udb8e쎐\uda92\udb94킖욘쮚\ude9c횞ﺠ賀諂釄蛆鷈苊苌臎軐雒鯔鿖飘闚黜髞고ꛢꯤ돦", a_), radioWide.Labtool.UCLContactsLimitationEnhancement_43811.Value);
						num2 = (short)446315132;
						short num3 = num2;
						num2 = (short)619919996;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_09;
						default:
						{
							num2 = (short)1039204353;
							if (num2 != 0)
							{
							}
							num2 = (short)702939136;
							if (num2 != 0)
							{
							}
							num2 = (short)1186136064;
							short num4 = num2;
							num2 = (short)1271922688;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						}
						break;
					}
					case 2:
						if (radioWide != null)
						{
							num2 = (short)149422081;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						return;
					}
					break;
				}
				IL_25:
				radioWide = (global::AcpCommonLib.FeatureManager.GetFeature(2045)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide);
				num2 = (short)1232601090;
				num = (int)((global::System.IntPtr)num2);
				goto IL_13;
			}
		}

		// Token: 0x06000BE1 RID: 3041 RVA: 0x000F1228 File Offset: 0x000EF428
		private void f(ref global::System.Collections.Generic.Dictionary<string, bool> A_0)
		{
			int a_ = 12;
			for (;;)
			{
				IL_09:
				switch (0)
				{
				case 0:
					goto IL_25;
				}
				int num;
				global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide radioWide;
				short num2;
				for (;;)
				{
					IL_13:
					switch (num)
					{
					case 0:
						return;
					case 1:
					{
						A_0.Add(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udc8e얐솒\udc94\ud996\ude98쒚출\udc9eﲢﮨﶮﶲﺺ", a_), radioWide.Labtool.DVRSRangeExt_44809.Value);
						num2 = (short)1470810210;
						short num3 = num2;
						num2 = (short)1674037346;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_09;
						default:
						{
							num2 = (short)242745344;
							if (num2 != 0)
							{
							}
							num2 = (short)2007695360;
							short num4 = num2;
							num2 = (short)999817216;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						}
						break;
					}
					case 2:
						if (radioWide != null)
						{
							num2 = (short)518258689;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						return;
					}
					break;
				}
				IL_25:
				num2 = (short)310050817;
				if (num2 != 0)
				{
				}
				radioWide = (global::AcpCommonLib.FeatureManager.GetFeature(2045)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide);
				num2 = (short)978845698;
				num = (int)((global::System.IntPtr)num2);
				goto IL_13;
			}
		}

		// Token: 0x06000BE2 RID: 3042 RVA: 0x000F137C File Offset: 0x000EF57C
		private void e(ref global::System.Collections.Generic.Dictionary<string, bool> A_0)
		{
			int a_ = 9;
			for (;;)
			{
				IL_09:
				switch (0)
				{
				case 0:
					goto IL_25;
				}
				int num;
				global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide radioWide;
				short num2;
				for (;;)
				{
					IL_13:
					switch (num)
					{
					case 0:
						return;
					case 1:
					{
						A_0.Add(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udf8b\uda8d슏\udb91\uda93톕잗쪙\udf9b힝ﾟﶻ蒿证诃駅髇藉駋髍駏鳑鏓觕裗駙闛", a_), radioWide.Labtool.RadWideLabtoolIndirectPTTAudioRoutingPCI_44817.Value);
						num2 = (short)1696848178;
						short num3 = num2;
						num2 = (short)572774706;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_09;
						default:
						{
							num2 = (short)1007419393;
							if (num2 != 0)
							{
							}
							num2 = (short)1027932160;
							if (num2 != 0)
							{
							}
							num2 = (short)1019740160;
							short num4 = num2;
							num2 = (short)1735524352;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						}
						break;
					}
					case 2:
						if (radioWide != null)
						{
							num2 = (short)318177281;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						return;
					}
					break;
				}
				IL_25:
				radioWide = (global::AcpCommonLib.FeatureManager.GetFeature(2045)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide);
				num2 = (short)92667906;
				num = (int)((global::System.IntPtr)num2);
				goto IL_13;
			}
		}

		// Token: 0x06000BE3 RID: 3043 RVA: 0x000F14D0 File Offset: 0x000EF6D0
		private void d(ref global::System.Collections.Generic.Dictionary<string, bool> A_0)
		{
			int a_ = 12;
			for (;;)
			{
				IL_09:
				switch (0)
				{
				case 0:
					goto IL_25;
				}
				int num;
				global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide radioWide;
				short num2;
				for (;;)
				{
					IL_13:
					switch (num)
					{
					case 0:
						return;
					case 1:
					{
						A_0.Add(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udf8e튐\uda92쪔횖\udd98쮚슜\ud99e謁", a_), radioWide.Labtool.RadWideLabtoolADPGatingPCIBit_44813.Value);
						num2 = (short)924528129;
						short num3 = num2;
						num2 = (short)1066806785;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_09;
						default:
						{
							num2 = (short)610009089;
							if (num2 != 0)
							{
							}
							num2 = (short)1577451520;
							if (num2 != 0)
							{
							}
							num2 = (short)2074869760;
							short num4 = num2;
							num2 = (short)233242624;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						}
						break;
					}
					case 2:
						if (radioWide != null)
						{
							num2 = (short)405536769;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						return;
					}
					break;
				}
				IL_25:
				radioWide = (global::AcpCommonLib.FeatureManager.GetFeature(2045)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide);
				num2 = (short)135331842;
				num = (int)((global::System.IntPtr)num2);
				goto IL_13;
			}
		}

		// Token: 0x06000BE4 RID: 3044 RVA: 0x000F162C File Offset: 0x000EF82C
		private void c(ref global::System.Collections.Generic.Dictionary<string, bool> A_0)
		{
			int a_ = 0;
			for (;;)
			{
				IL_09:
				switch (0)
				{
				case 0:
					goto IL_25;
				}
				int num;
				global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide radioWide;
				short num2;
				for (;;)
				{
					IL_13:
					switch (num)
					{
					case 0:
						return;
					case 1:
					{
						A_0.Add(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("펂욄캆횈\ud88a\ud88c\udf8e손\udc92잔쎖욘풚꺜삞", a_), radioWide.Labtool.RadWideLabtoolSupportO3ControlHeadPCIBit_44884.Value);
						num2 = (short)1321600573;
						short num3 = num2;
						num2 = (short)2106656317;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_09;
						default:
						{
							num2 = (short)1441792;
							if (num2 != 0)
							{
							}
							num2 = (short)666370049;
							if (num2 != 0)
							{
							}
							num2 = (short)1163067392;
							short num4 = num2;
							num2 = (short)788398080;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						}
						break;
					}
					case 2:
						if (radioWide != null)
						{
							num2 = (short)1108148225;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						return;
					}
					break;
				}
				IL_25:
				radioWide = (global::AcpCommonLib.FeatureManager.GetFeature(2045)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide);
				num2 = (short)1018560514;
				num = (int)((global::System.IntPtr)num2);
				goto IL_13;
			}
		}

		// Token: 0x06000BE5 RID: 3045 RVA: 0x000F177C File Offset: 0x000EF97C
		private void b(ref global::System.Collections.Generic.Dictionary<string, bool> A_0)
		{
			int a_ = 7;
			for (;;)
			{
				IL_09:
				switch (0)
				{
				case 0:
					goto IL_25;
				}
				int num;
				global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide radioWide;
				short num2;
				for (;;)
				{
					IL_13:
					switch (num)
					{
					case 0:
						return;
					case 1:
					{
						A_0.Add(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\uda89쾋잍쾏펑\uda93힕풗햙\udb9b증", a_), radioWide.Labtool.RadWideLabtoolAnalogWideBandDataPCIBit_44885.Value);
						num2 = (short)1049042806;
						short num3 = num2;
						num2 = (short)41361270;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_09;
						default:
						{
							num2 = (short)1559101441;
							if (num2 != 0)
							{
							}
							num2 = (short)926416896;
							if (num2 != 0)
							{
							}
							num2 = (short)1283981312;
							short num4 = num2;
							num2 = (short)245432320;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						}
						break;
					}
					case 2:
						if (radioWide != null)
						{
							num2 = (short)236126209;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						return;
					}
					break;
				}
				IL_25:
				radioWide = (global::AcpCommonLib.FeatureManager.GetFeature(2045)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide);
				num2 = (short)1809776642;
				num = (int)((global::System.IntPtr)num2);
				goto IL_13;
			}
		}

		// Token: 0x06000BE6 RID: 3046 RVA: 0x000F18D0 File Offset: 0x000EFAD0
		private bool a(global::SpecialFeatures.Flashport.FlashRadio.Option A_0, int A_1)
		{
			int a_ = 1;
			short num = (short)1703411712;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_1BD;
				}
				uint num3;
				bool result;
				string name;
				int num4;
				byte b;
				byte b2;
				byte b3;
				byte b4;
				byte b5;
				byte b6;
				for (;;)
				{
					IL_32:
					bool flag;
					bool flag2;
					switch (num2)
					{
					case 0:
						num = (short)1943994418;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						if (num3 != 1971748462U)
						{
							num = (short)1206386719;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)838008901;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						if (num3 != 793602653U)
						{
							num = (short)1994915872;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)43712588;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						goto IL_2A6;
					case 4:
						if (num3 != 1770269939U)
						{
							num = (short)997261367;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1892024356;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						if (num3 <= 1048750891U)
						{
							num = (short)368443479;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)375848983;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
						goto IL_AF9;
					case 7:
						goto IL_A7E;
					case 8:
						num = (short)2110521403;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 9:
						goto IL_A9B;
					case 10:
						goto IL_23F;
					case 11:
						num = (short)982843435;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 12:
						goto IL_643;
					case 13:
						return result;
					case 14:
						if (num3 != 1988526081U)
						{
							num = (short)688390195;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1927807065;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 15:
						if (!(name == global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쎃입뢇몉뾋뺍ꞏ", a_)))
						{
							num = (short)1020854273;
							if (num != 0)
							{
							}
							num = (short)804847644;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num4 &= (int)b;
						result = (num4 != 0);
						num = (short)2004025347;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 16:
						num = (short)1923612737;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 17:
						num = (short)1175388212;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 18:
						num = (short)1637941277;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 19:
					{
						num = (short)559911548;
						short num5 = num;
						num = (short)881169020;
						switch ((num5 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_8B9;
						default:
							goto IL_E65;
						}
						break;
					}
					case 20:
						if (num3 != 2071638597U)
						{
							num = (short)1495138353;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)95486022;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 21:
						goto IL_9C0;
					case 22:
						num = (short)618856461;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 23:
						if (num3 <= 1954970843U)
						{
							num = (short)844496971;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)587333715;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 24:
						num = (short)1122631747;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 25:
						num = (short)1934688303;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 26:
						goto IL_5D3;
					case 27:
						num = (short)1660485703;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 28:
						num = (short)789250067;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 29:
						if (num3 != 1048750891U)
						{
							num = (short)38469720;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)60620815;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 30:
						goto IL_91F;
					case 31:
						num = (short)2070872078;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 32:
						num = (short)373162070;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 33:
						num = (short)870514744;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 34:
						num = (short)17891337;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 35:
						num = (short)1094713348;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 36:
						if (!(name == global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("햃입뢇몉릋뢍ꦏ", a_)))
						{
							num = (short)309395481;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1374683177;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 37:
						flag = false;
						goto IL_903;
					case 38:
						return result;
					case 39:
						flag2 = false;
						goto IL_9A6;
					case 40:
						goto IL_865;
					case 41:
						if ((num4 & (int)b2) != 0)
						{
							num = (short)1357643836;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)477757477;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 42:
						if (num3 != 2379504813U)
						{
							num = (short)2057568337;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)910688335;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 43:
						goto IL_CC1;
					case 44:
						num = (short)1773076492;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 45:
						if (num3 != 1954970843U)
						{
							num = (short)47448064;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1008992313;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 46:
						if (num3 != 1082997677U)
						{
							num = (short)437977123;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)740687920;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 47:
						goto IL_25D;
					case 48:
						if (!(name == global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쎃입뢇몉뾋몍ꖏ", a_)))
						{
							num = (short)1211105333;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num4 &= (int)b3;
						result = (num4 != 0);
						num = (short)605487142;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 49:
						num = (short)1414332458;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 50:
						goto IL_27A;
					case 51:
						num = (short)1724579904;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 52:
						goto IL_8FE;
					case 53:
						num = (short)1758199818;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 54:
						goto IL_8E0;
					case 55:
						num = (short)350355501;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 56:
						flag2 = ((num4 & (int)b4) != 0);
						goto IL_9A6;
					case 57:
						if (!(name == global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("햃입뢇몉릋릍ꊏ", a_)))
						{
							num = (short)1836515350;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num4 &= (int)b3;
						result = (num4 != 0);
						num = (short)2025652315;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 58:
						if (!(name == global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쎃입뢇몉뾋몍ꊏ", a_)))
						{
							num = (short)1532100693;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num4 &= (int)b5;
						result = (num4 != 0);
						num = (short)1492189258;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 59:
						goto IL_CA3;
					case 60:
						num = (short)803471423;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 61:
						if (!(name == global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("햃입뢇뺉뒋붍ꊏ", a_)))
						{
							num = (short)1381367852;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return result;
					case 62:
						num = (short)604766210;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 63:
						flag = ((num4 & (int)b4) != 0);
						goto IL_903;
					case 64:
						goto IL_74B;
					case 65:
						goto IL_B18;
					case 66:
						return result;
					case 67:
						if (num3 != 171604188U)
						{
							num = (short)1777074238;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1642856509;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 68:
						num = (short)1380122719;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 69:
						if (!(name == global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("햃입뢇몉릋릍ꆏ", a_)))
						{
							num = (short)875626513;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num4 &= (int)b5;
						result = (num4 != 0);
						num = (short)1944649754;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 70:
						if (!(name == global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쎃입뢇몉떋뢍ꦏ", a_)))
						{
							num = (short)1684668496;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return result;
					case 71:
						goto IL_660;
					case 72:
						goto IL_67D;
					case 73:
						num = (short)289800193;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 74:
						goto IL_40E;
					case 75:
						num = (short)1148321838;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 76:
						if (!(name == global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쎃입뢇몉뺋몍꒏", a_)))
						{
							num = (short)1433010187;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1579810910;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 77:
						if (!(name == global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쎃입뢇몉뾋몍ꆏ", a_)))
						{
							num = (short)1658060827;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num4 &= (int)b5;
						result = (num4 != 0);
						num = (short)213450818;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 78:
						num = (short)1040449576;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 79:
						if (!(name == global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("햃입뢇릉벋뮍ꚏ", a_)))
						{
							num = (short)861208592;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_8B9;
					case 80:
						num = (short)1318715482;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 81:
						num = (short)1138688072;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 82:
						goto IL_2C3;
					case 83:
						if (num3 <= 1988526081U)
						{
							num = (short)1757347913;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)237633556;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 84:
						if (!(name == global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쎃입뢇몉뾋뺍ꚏ", a_)))
						{
							num = (short)917504078;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num4 &= (int)b;
						result = (num4 != 0);
						num = (short)988545117;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 85:
						num = (short)1775960070;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 86:
						if (num3 != 965554344U)
						{
							num = (short)1197539362;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)63701050;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 87:
						num = (short)283246688;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 88:
						num = (short)171311186;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 89:
						if (!(name == global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("햃입뢇몉릋릍ꂏ", a_)))
						{
							num = (short)334888968;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num4 &= (int)b;
						result = (num4 != 0);
						num = (short)1070333959;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 90:
						goto IL_D22;
					case 91:
						goto IL_B6A;
					case 92:
						if (num3 != 1015887201U)
						{
							num = (short)1407909956;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)217382989;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 93:
						goto IL_6EA;
					case 94:
						if ((num4 & (int)b2) != 0)
						{
							num = (short)1860108321;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)610140199;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 95:
					{
						num = (short)799539200;
						short num6 = num;
						if (num3 != 1031973272U)
						{
							num = (short)390266898;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1123811412;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 96:
						if (num3 <= 965554344U)
						{
							num = (short)1638465560;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)768344156;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1BD;
					IL_8B9:
					num4 &= (int)b6;
					result = (num4 != 0);
					num = (short)440860726;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_903:
					result = flag;
					num = (short)1090584606;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_9A6:
					result = flag2;
					num = (short)1398865941;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_23F:
				IL_25D:
				IL_27A:
				IL_2A6:
				IL_2C3:
				IL_40E:
				IL_5D3:
				IL_643:
				IL_660:
				IL_67D:
				IL_6EA:
				IL_74B:
				IL_865:
				IL_8E0:
				IL_8FE:
				IL_91F:
				IL_9C0:
				IL_A7E:
				IL_A9B:
				IL_AF9:
				IL_B18:
				IL_B6A:
				IL_CA3:
				IL_CC1:
				IL_D22:
				return result;
				IL_E65:
				num = (short)855375872;
				if (num != 0)
				{
				}
				return result;
				IL_1BD:
				b = 1;
				b5 = 2;
				b3 = 4;
				b2 = 8;
				b4 = 16;
				b6 = 32;
				result = false;
				num4 = A_1;
				name = A_0.Name;
				num3 = global::<PrivateImplementationDetails>.ComputeStringHash(name);
				num = (short)1448214533;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_32;
			}
			}
		}

		// Token: 0x06000BE7 RID: 3047 RVA: 0x000F28B0 File Offset: 0x000F0AB0
		private void a(ref global::System.Collections.Generic.Dictionary<string, bool> A_0)
		{
			int a_ = 17;
			short num = (short)223805440;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_70;
				}
				int num3;
				bool value;
				bool flag;
				for (;;)
				{
					IL_31:
					int num4;
					switch (num2)
					{
					case 0:
						goto IL_1BD;
					case 1:
						if (num3 >= 25)
						{
							num = (short)790036491;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num4 = 0;
						num = (short)997195784;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						num3++;
						num = (short)1303248896;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						try
						{
							num = (short)29753373;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								int fieldValue;
								global::SpecialFeatures.Flashport.FlashRadio.Option option;
								switch (num2)
								{
								case 0:
									goto IL_424;
								case 1:
									goto IL_6E5;
								case 2:
									value = true;
									num = (short)1170145280;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 3:
								{
									global::AcpCommonLib.IAcpField dbField;
									if (!(dbField.Name == global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("욓ﲗ펙쾟얣쒥\udca7얩쎫슭삱\uddb3\udbb5\ud9b7좹얻ﲽꆿ곁ꃃ뗅韇诉ﻋ﷍", a_)))
									{
										num = (short)1003552775;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_583;
								}
								case 4:
									goto IL_7C2;
								case 5:
									num = (short)1674051590;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 6:
								{
									num = (short)8818317;
									short num5 = num;
									num = (short)1216646797;
									switch ((num5 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										goto IL_6E5;
									default:
										num = (short)600375296;
										if (num != 0)
										{
										}
										if (fieldValue == 3)
										{
											num = (short)1734279180;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										goto IL_51A;
									}
									break;
								}
								case 7:
									num = (short)120848393;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 8:
									goto IL_51A;
								case 9:
								{
									global::AcpCommonLib.IAcpField dbField;
									if (dbField.Name == global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("욓ﲗ펙쾟얣쒥\udca7얩쎫슭ힱힳ\ud9b5횷\udeb9\uddbb첽릿胁ꗃꣅ곇막鏋迍", a_))
									{
										num = (short)146931730;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)256638996;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 10:
									goto IL_51A;
								case 11:
								{
									int num6;
									if (this.b0.TryGetValue(option.Name, out num6))
									{
										num = (short)997195799;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_51A;
								}
								case 12:
									value = true;
									num = (short)39976975;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 13:
									if (fieldValue == 3)
									{
										num = (short)1757937666;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_424;
								case 14:
									value = true;
									num = (short)1003094024;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 15:
									goto IL_51A;
								case 16:
								{
									global::AcpCommonLib.IAcpField dbField;
									if (dbField.Name == global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("욓ﲗ펙쾟얣쒥\udca7얩쎫슭蒳蚵趷貹薻贈藇苉雋重量", a_))
									{
										num = (short)1242300444;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_424;
								}
								case 17:
								{
									global::AcpCommonLib.IAcpField dbField;
									if (dbField.Name == global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("욓ﲗ펙쾟얣쒥\udca7얩쎫슭蒳芵肷莹躻﯁藇苉雋重量", a_))
									{
										num = (short)929366021;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)50593795;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 18:
									goto IL_583;
								case 19:
									goto IL_51A;
								case 20:
									if (fieldValue == 1)
									{
										num = (short)1244921870;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_51A;
								case 21:
									num = (short)1905655812;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 23:
									num = (short)1089929242;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 24:
									value = true;
									num = (short)944373779;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 25:
								{
									int num6;
									if (fieldValue == num6)
									{
										num = (short)518848536;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_51A;
								}
								case 26:
									if (flag)
									{
										num = (short)108724225;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)1520500761;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 27:
								{
									global::System.Collections.Generic.IEnumerator<global::SpecialFeatures.Flashport.FlashRadio.Option> enumerator;
									if (!enumerator.MoveNext())
									{
										num = (short)1269104661;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									option = enumerator.Current;
									global::AcpCommonLib.IAcpField dbField = option.DbField;
									fieldValue = this.b1.GetFieldValue(dbField);
									num = (short)1358430224;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 28:
									num = (short)667877389;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 29:
									switch (0)
									{
									case 0:
										goto IL_359;
									}
									continue;
								}
								goto IL_359;
								IL_424:
								num = (short)386596881;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_51A:
								A_0.Add(option.Name, value);
								value = false;
								num = (short)1605173270;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_583:
								num = (short)531234827;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_6A2:
								num = (short)1639448603;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_359:
								goto IL_6A2;
								IL_6E5:
								value = this.a(option, fieldValue);
								num = (short)1511325706;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_7C2:
							goto IL_E8;
						}
						finally
						{
							num = (short)1406074882;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::System.Collections.Generic.IEnumerator<global::SpecialFeatures.Flashport.FlashRadio.Option> enumerator;
								switch (num2)
								{
								case 0:
									enumerator.Dispose();
									num = (short)282460161;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									goto IL_831;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_7FA;
									}
									continue;
								}
								IL_7FA:
								if (enumerator == null)
								{
									break;
								}
								num = (short)2097152;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_831:;
						}
						return;
					case 4:
						if (!flag)
						{
							num = (short)1071775754;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 5:
					{
						if (num4 >= 8)
						{
							num = (short)1855782914;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						int position = num3 * 8 + num4 + 1;
						global::System.Collections.Generic.IList<global::SpecialFeatures.Flashport.FlashRadio.Option> optionsByPosition = this.b1.FLASHcode.GetOptionsByPosition(position);
						num = (short)434634758;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 6:
					{
						global::System.Collections.Generic.IList<global::SpecialFeatures.Flashport.FlashRadio.Option> optionsByPosition;
						if (optionsByPosition != null)
						{
							num = (short)529334279;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_E8;
					}
					case 7:
					{
						num = (short)1048379393;
						if (num != 0)
						{
						}
						global::System.Collections.Generic.IList<global::SpecialFeatures.Flashport.FlashRadio.Option> optionsByPosition;
						global::System.Collections.Generic.IEnumerator<global::SpecialFeatures.Flashport.FlashRadio.Option> enumerator = optionsByPosition.GetEnumerator();
						num = (short)1362886659;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 8:
						goto IL_27A;
					case 9:
						return;
					case 10:
						A_0.Add(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("얓힕ꢗꎙ겛꺝隟", a_), false);
						num = (short)162463753;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 11:
						num = (short)545783812;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 12:
						goto IL_27A;
					case 13:
						goto IL_1BD;
					}
					goto IL_70;
					IL_E8:
					num4++;
					num = (short)1112211468;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1BD:
					num = (short)875954177;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_27A:
					num = (short)1256718341;
					num2 = (int)((global::System.IntPtr)num);
				}
				return;
				IL_70:
				value = false;
				flag = global::ConstraintHelper.UtilityMack.IsFreonCodeplug(this.bu);
				num3 = 0;
				num = (short)2086862848;
				short num7 = num;
				num = (short)1036058637;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_31;
			}
			}
		}

		// Token: 0x06000BE8 RID: 3048 RVA: 0x000F3110 File Offset: 0x000F1310
		private void a(bool A_0 = false)
		{
			switch (0)
			{
			case 0:
				goto IL_24;
			}
			int num;
			short num2;
			for (;;)
			{
				IL_0A:
				global::System.Collections.Generic.List<string>.Enumerator enumerator;
				switch (num)
				{
				case 0:
					goto IL_2E6;
				case 1:
				{
					num2 = (short)815398912;
					short num3 = num2;
					if (this.bs == global::SpecialFeatures.Model_Configuration.ModelTiering.ActionTypes.NEW)
					{
						num2 = (short)2015756292;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				}
				case 2:
					try
					{
						num2 = (short)1969487879;
						num = (int)((global::System.IntPtr)num2);
						for (;;)
						{
							switch (num)
							{
							case 0:
							{
								string text;
								string key = text.Trim();
								num2 = (short)1683947529;
								num = (int)((global::System.IntPtr)num2);
								continue;
							}
							case 1:
							{
								string key;
								this.bz.Add(key, true);
								num2 = (short)714276868;
								num = (int)((global::System.IntPtr)num2);
								continue;
							}
							case 2:
							{
								string key;
								if (!this.bz.ContainsKey(key))
								{
									num2 = (short)1940848641;
									num = (int)((global::System.IntPtr)num2);
									continue;
								}
								break;
							}
							case 3:
							{
								string text;
								if (text != null)
								{
									num2 = (short)2126249984;
									num = (int)((global::System.IntPtr)num2);
									continue;
								}
								break;
							}
							case 5:
								goto IL_2D6;
							case 6:
								num2 = (short)542834693;
								num = (int)((global::System.IntPtr)num2);
								continue;
							case 7:
								switch (0)
								{
								case 0:
									goto IL_119;
								}
								continue;
							case 8:
								goto IL_2BA;
							case 9:
							{
								string key;
								if (key != string.Empty)
								{
									num2 = (short)141164552;
									num = (int)((global::System.IntPtr)num2);
									continue;
								}
								break;
							}
							case 10:
							{
								if (enumerator.MoveNext())
								{
									string text = enumerator.Current;
									num2 = (short)1097859075;
									num = (int)((global::System.IntPtr)num2);
									continue;
								}
								num2 = (short)2005340743;
								short num4 = num2;
								num2 = (short)1235161671;
								switch ((num4 == num2) ? 1 : 0)
								{
								case 0:
								case 2:
									goto IL_2BA;
								default:
									num2 = (short)1715732480;
									if (num2 != 0)
									{
									}
									num2 = (short)1937571846;
									num = (int)((global::System.IntPtr)num2);
									continue;
								}
								break;
							}
							}
							IL_179:
							num2 = (short)1859518465;
							if (num2 != 0)
							{
							}
							num2 = (short)392953866;
							num = (int)((global::System.IntPtr)num2);
							continue;
							IL_119:
							goto IL_179;
							IL_2BA:
							num2 = (short)1501757442;
							num = (int)((global::System.IntPtr)num2);
						}
						IL_2D6:
						return;
					}
					finally
					{
						((global::System.IDisposable)enumerator).Dispose();
					}
					goto IL_2E6;
				case 3:
					if (this.bv != null)
					{
						num2 = (short)1914699776;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 4:
					num2 = (short)1265303555;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_24;
				IL_2E6:
				enumerator = this.bv.GetEnumerator();
				num2 = (short)2047803394;
				num = (int)((global::System.IntPtr)num2);
			}
			return;
			IL_24:
			this.b(string.Empty);
			this.a(ref this.bz);
			this.an(ref this.bz);
			this.a(ref this.bz, A_0);
			this.ao(ref this.bz);
			num2 = (short)512360449;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000BE9 RID: 3049 RVA: 0x000F3480 File Offset: 0x000F1680
		private global::System.Collections.Generic.Dictionary<string, int> b()
		{
			int a_ = 17;
			short num = (short)1178468472;
			short num2 = num;
			num = (short)1965883512;
			switch (num2 == num)
			{
			}
			num = (short)1312292864;
			if (num != 0)
			{
			}
			num = (short)1809186817;
			if (num != 0)
			{
			}
			num = (short)1195638784;
			short num3 = num;
			return new global::System.Collections.Generic.Dictionary<string, int>
			{
				{
					global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("얓힕ꢗꦙ겛ꮝ隟", a_),
					6
				},
				{
					global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("펓힕ꢗꪙꖛꢝ馟", a_),
					6
				},
				{
					global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("얓힕ꢗ꺙꒛궝銟", a_),
					7
				},
				{
					global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("얓힕ꢗꪙꦛꦝ銟", a_),
					8
				},
				{
					global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("얓힕ꢗꪙꦛꦝ隟", a_),
					8
				},
				{
					global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("펓힕ꢗꪙ꾛ꪝ閟", a_),
					8
				},
				{
					global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("펓힕ꢗꪙ꾛ꪝ隟", a_),
					8
				},
				{
					global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("펓힕ꢗꪙ꾛ꪝ銟", a_),
					5
				},
				{
					global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("펓힕ꢗꪙ꾛ꪝ醟", a_),
					4
				},
				{
					global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("얓힕ꢗꪙꦛꦝ醟", a_),
					4
				},
				{
					global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("펓힕ꢗꪙ꾛ꪝ钟", a_),
					5
				},
				{
					global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("펓힕ꢗꪙ꾛ꪝ鎟", a_),
					4
				},
				{
					global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("얓힕ꢗꪙꦛꦝ閟", a_),
					4
				},
				{
					global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("펓힕ꢗꪙ꾛꺝鞟", a_),
					3
				},
				{
					global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("펓힕ꢗꪙ꾛꺝隟", a_),
					2
				},
				{
					global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("얓힕ꢗꪙꦛꦝ邟", a_),
					2
				},
				{
					global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("펓힕ꢗꪙ꾛꺝馟", a_),
					3
				},
				{
					global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("펓힕ꢗꪙ꾛꺝颟", a_),
					2
				},
				{
					global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("얓힕ꢗꪙꦛꦝ钟", a_),
					2
				},
				{
					global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("얓힕ꢗꪙꦛꢝ馟", a_),
					1
				},
				{
					global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("펓힕ꢗꪙ꺛ꪝ钟", a_),
					1
				},
				{
					global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("얓힕ꢗꪙꦛꦝ鎟", a_),
					1
				},
				{
					global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("펓힕ꢗꪙ꺛겝閟", a_),
					1
				}
			};
		}

		// Token: 0x06000BEA RID: 3050 RVA: 0x000F371C File Offset: 0x000F191C
		private bool c(string A_0)
		{
			int a_ = 10;
			switch (0)
			{
			case 0:
				goto IL_41;
			}
			int num;
			bool result;
			short num2;
			for (;;)
			{
				IL_13:
				switch (num)
				{
				case 0:
					return result;
				case 1:
					if (A_0.Length < 12)
					{
						num2 = (short)2062024712;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)1385824263;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
					result = false;
					num2 = (short)1422589956;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 3:
					result = false;
					num2 = (short)20381696;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 4:
					return result;
				case 5:
					return result;
				case 6:
				{
					num2 = (short)1221656577;
					if (num2 != 0)
					{
					}
					num2 = (short)2032623408;
					short num3 = num2;
					num2 = (short)2006736688;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_21B;
					default:
					{
						num2 = (short)1447755776;
						if (num2 != 0)
						{
						}
						if (string.IsNullOrEmpty(A_0))
						{
							num2 = (short)649592834;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						A_0 = A_0.Trim();
						A_0 = A_0.ToUpper();
						char[] trimChars = new char[]
						{
							'\0',
							' ',
							'\r',
							'\n'
						};
						A_0 = A_0.TrimEnd(trimChars);
						num2 = (short)720044033;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					}
					break;
				}
				case 7:
					if (new global::System.Text.RegularExpressions.Regex(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("톌캎쪐튒뢔춖쒘겜ﶠ잢\udea4閦풨芮캴蚶쒸閺鞼", a_)).Matches(A_0, 0).Count != 1)
					{
						goto IL_21B;
					}
					this.bu = A_0;
					this.UpdateUtilityMackModelType();
					num2 = (short)135593989;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 8:
					result = false;
					num2 = (short)258408457;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 9:
					return result;
				}
				goto IL_41;
				IL_21B:
				num2 = (short)1803878400;
				short num4 = num2;
				num2 = (short)336723971;
				num = (int)((global::System.IntPtr)num2);
			}
			return result;
			IL_41:
			result = true;
			num2 = (short)2059599878;
			num = (int)((global::System.IntPtr)num2);
			goto IL_13;
		}

		// Token: 0x06000BEB RID: 3051 RVA: 0x000F398C File Offset: 0x000F1B8C
		public void CheckForModelTieringFile()
		{
			int a_ = 19;
			short num = (short)1558249474;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
				{
					num = (short)1396572161;
					if (num != 0)
					{
					}
					num = (short)1997966964;
					short num3 = num;
					num = (short)1512279668;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						return;
					default:
						num = (short)1315176448;
						if (num != 0)
						{
						}
						goto IL_DF;
					}
					break;
				}
				case 1:
					this.a();
					num = (short)962592768;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					switch (0)
					{
					case 0:
						goto IL_46;
					}
					continue;
				case 3:
					if (!global::System.IO.File.Exists(this.bx))
					{
						num = (short)1086652420;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 4:
					global::System.Windows.Forms.MessageBox.Show(global::CommonResources.AppResources.Unable_to_start_APX_CPS_Critical_file_missing, global::CommonResources.AppResources.APX_CPS);
					global::System.Console.WriteLine(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("ꚕ\ud999\uda9b꾝醟", a_));
					global::System.Environment.Exit(53009);
					num = (short)1903886341;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
					return;
				}
				IL_46:
				num = (short)1032388608;
				short num4 = num;
				if (string.IsNullOrEmpty(this.bx))
				{
					num = (short)476577793;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_DF:
				num = (short)1122304003;
				num2 = (int)((global::System.IntPtr)num);
			}
		}

		// Token: 0x06000BEC RID: 3052 RVA: 0x000F3B50 File Offset: 0x000F1D50
		public void LoadAliasList()
		{
			int a_ = 9;
			short num;
			try
			{
				num = (short)509018112;
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
					global::System.Xml.XmlDocument xmlDocument;
					for (;;)
					{
						IL_31:
						global::System.Collections.IEnumerator enumerator;
						switch (num2)
						{
						case 0:
							goto IL_358;
						case 1:
							xmlDocument = new global::AcpCryptoLib.AcpXMLEncryptDecrypt().DecryptXMLFile(this.bx);
							num = (short)1849098243;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
							if (this.bw)
							{
								num = (short)957284353;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							xmlDocument.Load(this.bx);
							num = (short)1323761668;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 3:
							goto IL_263;
						case 4:
							goto IL_263;
						case 5:
						{
							try
							{
								num = (short)1861681155;
								num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									switch (num2)
									{
									case 1:
									{
										if (!enumerator.MoveNext())
										{
											num = (short)7274502;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)enumerator.Current;
										num = (short)933691396;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 2:
										goto IL_1EA;
									case 3:
										switch (0)
										{
										case 0:
											goto IL_D5;
										}
										continue;
									case 4:
									{
										global::System.Xml.XmlNode xmlNode;
										if (xmlNode is global::System.Xml.XmlElement)
										{
											num = (short)954269701;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										break;
									}
									case 5:
									{
										global::System.Xml.XmlNode xmlNode;
										string value = (xmlNode as global::System.Xml.XmlElement).Attributes[global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("ﶏ", a_)].Value;
										string value2 = (xmlNode as global::System.Xml.XmlElement).Attributes[global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("", a_)].Value;
										global::Features.Common.MTFAliasList.Instance.AddAlias(value, value2);
										num = (short)28180480;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 6:
										num = (short)440664066;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									IL_D7:
									num = (short)997064705;
									num2 = (int)((global::System.IntPtr)num);
									continue;
									IL_D5:
									goto IL_D7;
								}
								IL_1EA:
								goto IL_2F5;
							}
							finally
							{
								switch (0)
								{
								case 0:
									goto IL_20C;
								}
								global::System.IDisposable disposable;
								for (;;)
								{
									IL_1F9:
									switch (num2)
									{
									case 0:
										if (disposable != null)
										{
											num = (short)2134835202;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										goto IL_262;
									case 1:
										goto IL_260;
									case 2:
										disposable.Dispose();
										num = (short)1689518081;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_20C;
								}
								IL_260:
								IL_262:
								goto EndFinally_10;
								IL_20C:
								disposable = (enumerator as global::System.IDisposable);
								num = (short)854327296;
								num2 = (int)((global::System.IntPtr)num);
								goto IL_1F9;
								EndFinally_10:;
							}
							goto IL_263;
							IL_2F5:
							num = (short)686829713;
							short num3 = num;
							num = (short)1403662481;
							switch ((num3 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_263;
							default:
								num = (short)1283522560;
								if (num != 0)
								{
								}
								num = (short)1338900480;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						}
						goto IL_50;
						IL_263:
						enumerator = xmlDocument.SelectSingleNode(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("ﺋﾏ뮓\udb95ﺙ鍊쮡솣풥솧쒩쮫\ud9af\udeb1톳馵醴횹햻\udfbd뎿迁ꗃ뛅", a_)).ChildNodes.GetEnumerator();
						num = (short)288030725;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_358:
					break;
					IL_50:
					xmlDocument = new global::System.Xml.XmlDocument();
					num = (short)706609154;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_31;
				}
				}
			}
			catch (global::System.Exception)
			{
				global::System.Environment.Exit(53009);
			}
			num = (short)286982145;
			if (num != 0)
			{
			}
			num = (short)1950613504;
			short num4 = num;
		}

		// Token: 0x06000BED RID: 3053 RVA: 0x000F3F48 File Offset: 0x000F2148
		private void a()
		{
			int a_ = 18;
			short num = (short)161237810;
			short num2 = num;
			num = (short)24202034;
			switch (num2 == num)
			{
			}
			num = (short)467206145;
			if (num != 0)
			{
			}
			num = (short)197656576;
			if (num != 0)
			{
			}
			num = (short)840630272;
			short num3 = num;
			this.bw = true;
			this.bx = global::System.IO.Path.Combine(this.by, global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("풔펚궜놞슠펢횤", a_));
		}

		// Token: 0x06000BEE RID: 3054 RVA: 0x000F4020 File Offset: 0x000F2220
		private void b(string A_0)
		{
			int a_ = 10;
			switch (0)
			{
			case 0:
				goto IL_2D;
			}
			short num2;
			for (;;)
			{
				IL_13:
				int num;
				switch (num)
				{
				case 0:
					goto IL_1CC;
				case 1:
					if (A_0 != string.Empty)
					{
						num2 = (short)1900347396;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_21B;
				case 2:
					goto IL_17C;
				case 3:
					if (!global::SpecialFeatures.Flashport.FlashRadio.FlashcodeValidator.Validate(A_0))
					{
						num2 = (short)1564672000;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					this.a(A_0);
					num2 = (short)1152647170;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 4:
					num2 = (short)88014851;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_2D;
			}
			IL_17C:
			goto IL_21B;
			IL_1CC:
			num2 = (short)658806509;
			short num3 = num2;
			num2 = (short)638424813;
			switch ((num3 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
			{
				IL_2D:
				this.bz.Add(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("첌쎎욐튒첔쒖", a_), true);
				this.bz.Add(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쎌쪎자횒잔", a_), false);
				this.bz.Add(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("즌쪎힐튒삔\udb96춘", a_), true);
				this.bz.Add(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udd8c삎쎐잒풔햖햘\ude9a", a_), !this.IsModelMobile);
				this.bz.Add(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("삌삎펐\uda92\ud994튖", a_), this.IsModelMobile);
				this.bz.Add(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쮌\udf8e슐첒톔튖즘힚튜욞", a_), false);
				this.bz.Add(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("즌쪎손\udc92솔좖\udd98\ude9a출펞甆ﾪ", a_), false);
				this.bz.Add(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\ude8c욎쎐횒\udb94좖햘튚\uda9c힞瘝ﶬ", a_), false);
				this.bz.Add(this.bu, true);
				num2 = (short)17891329;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_13;
			}
			default:
				num2 = (short)618528768;
				if (num2 != 0)
				{
				}
				throw new global::System.Exception(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\ud88c滛ﮞ膠直캬삮햰횲辴鞶ힺ\ud8bc\udebe닀ꛂꇆꛈ맊ꃌ껎ꗐ듔ꓖ律ꏚꗜ꟞駠鯢鷤쫦釨鏪闬韮觰诲\ud8f4迶퓸菺藼蟾礀笂約⨆焈猊甌眎椐欒", a_));
			}
			IL_21B:
			num2 = (short)581173249;
			if (num2 != 0)
			{
			}
			num2 = (short)457572352;
			short num4 = num2;
		}

		// Token: 0x06000BEF RID: 3055 RVA: 0x000F429C File Offset: 0x000F249C
		private void a(string A_0)
		{
			int a_ = 14;
			short num = (short)1716256768;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_81;
				}
				bool flag;
				byte[] array;
				for (;;)
				{
					IL_32:
					global::System.Collections.Generic.IEnumerator<global::SpecialFeatures.Flashport.FlashRadio.Option> enumerator;
					int value;
					int num4;
					int num5;
					global::System.Collections.Generic.IList<global::SpecialFeatures.Flashport.FlashRadio.Option> optionsByPosition;
					switch (num2)
					{
					case 0:
						goto IL_15D;
					case 1:
						goto IL_4E3;
					case 2:
						try
						{
							num = (short)1507131393;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_35D;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_2BD;
									}
									continue;
								case 2:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)609484803;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::SpecialFeatures.Flashport.FlashRadio.Option option = enumerator.Current;
									int num3 = option.Mask.Apply(value, global::Motorola.Acp.PackUnpack.Ish.Layouts.MaskApplication.Unpack);
									this.bz.Add(option.Name, num3 == option.BitsValue);
									num = (short)1161232388;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 3:
									num = (short)1203634176;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_30C:
								num = (short)1861353474;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_2BD:
								goto IL_30C;
							}
							IL_35D:
							goto IL_42F;
						}
						finally
						{
							num = (short)302383104;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_394;
									}
									continue;
								case 1:
									goto IL_3CD;
								case 2:
									enumerator.Dispose();
									num = (short)334168065;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_394:
								if (enumerator == null)
								{
									break;
								}
								num = (short)419102722;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_3CD:;
						}
						goto IL_3D0;
					case 3:
						goto IL_27E;
					case 4:
					{
						if (num4 >= 8)
						{
							num = (short)935985160;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						int position = num5 * 8 + num4 + 1;
						optionsByPosition = this.b1.FLASHcode.GetOptionsByPosition(position);
						num = (short)290652166;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 5:
						num = (short)528285711;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
						if (optionsByPosition != null)
						{
							num = (short)854523920;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_42F;
					case 7:
						goto IL_FF;
					case 8:
						num5++;
						num = (short)1464074240;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 9:
						goto IL_15D;
					case 10:
						if (num5 >= 24)
						{
							num = (short)226033681;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3D0;
					case 11:
						goto IL_FF;
					case 12:
						if (!flag)
						{
							num = (short)1230045197;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 13:
					{
						this.bz.Add(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("삐튒ꖔ꺖ꦘꮚꮜ", a_), false);
						num = (short)94766786;
						short num6 = num;
						num = (short)116393666;
						switch ((num6 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_4E8;
						default:
							num = (short)1653932032;
							if (num != 0)
							{
							}
							num = (short)930742275;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 14:
					{
						num = (short)550567936;
						short num7 = num;
						if (array != null)
						{
							num = (short)1261305861;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1C3;
					}
					case 15:
						if (array.Length != 24)
						{
							num = (short)1943535617;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num5 = 0;
						num = (short)1121452041;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 16:
						goto IL_4E8;
					case 17:
						num = (short)728694785;
						if (num != 0)
						{
						}
						num = (short)2110521356;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_81;
					IL_FF:
					num = (short)1060962308;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_15D:
					num = (short)1632829450;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_3D0:
					value = (int)array[num5];
					num4 = 0;
					num = (short)702480395;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_42F:
					num4++;
					num = (short)648019975;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_4E8:
					enumerator = optionsByPosition.GetEnumerator();
					num = (short)430243842;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_1C3:
				throw new global::System.Exception(A_0 + global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("놐朗랖붜쾠햢쒤쮦삨쾪趬즮\uddb0튲운\udfb6\udab8풺\ud9bc\udabe", a_));
				IL_27E:
				return;
				IL_4E3:
				goto IL_1C3;
				IL_81:
				array = new byte[0];
				global::SpecialFeatures.Flashport.FlashRadio.FlashcodeDecoder.Decode(A_0, ref array);
				flag = global::ConstraintHelper.UtilityMack.IsFreonCodeplug(this.bu);
				num = (short)414646286;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_32;
			}
			}
		}

		// Token: 0x04000534 RID: 1332
		private const int a = 2147483647;

		// Token: 0x04000535 RID: 1333
		private const int b = 1;

		// Token: 0x04000536 RID: 1334
		private const int c = 1;

		// Token: 0x04000537 RID: 1335
		private const int d = 12;

		// Token: 0x04000538 RID: 1336
		private const int e = 6;

		// Token: 0x04000539 RID: 1337
		private const int f = 7;

		// Token: 0x0400053A RID: 1338
		private const int g = 8;

		// Token: 0x0400053B RID: 1339
		private const int h = 5;

		// Token: 0x0400053C RID: 1340
		private const int i = 4;

		// Token: 0x0400053D RID: 1341
		private const int j = 3;

		// Token: 0x0400053E RID: 1342
		private const int k = 2;

		// Token: 0x0400053F RID: 1343
		private const int l = 1;

		// Token: 0x04000540 RID: 1344
		private const int m = 5;

		// Token: 0x04000541 RID: 1345
		private const int n = 6;

		// Token: 0x04000542 RID: 1346
		private const int o = 10;

		// Token: 0x04000543 RID: 1347
		private const int p = 11;

		// Token: 0x04000544 RID: 1348
		private const int q = 14;

		// Token: 0x04000545 RID: 1349
		private const int r = 1;

		// Token: 0x04000546 RID: 1350
		private const int s = 15;

		// Token: 0x04000547 RID: 1351
		private const int t = 3;

		// Token: 0x04000548 RID: 1352
		private const int u = 3;

		// Token: 0x04000549 RID: 1353
		public const string DEFAULT_MODEL = "H97TGD9PW1AN";

		// Token: 0x0400054A RID: 1354
		public const string DEFAULT_MOBILE_MODEL = "M30TSS9PW1AN";

		// Token: 0x0400054B RID: 1355
		private const string v = "MENUITEM";

		// Token: 0x0400054C RID: 1356
		private const string w = "ApxH0.cps";

		// Token: 0x0400054D RID: 1357
		private const string x = "Model_Tiering.g.xml";

		// Token: 0x0400054E RID: 1358
		private const string y = "ALWAYS";

		// Token: 0x0400054F RID: 1359
		private const string z = "NEVER";

		// Token: 0x04000550 RID: 1360
		private const string aa = "DEFAULT";

		// Token: 0x04000551 RID: 1361
		private const string ab = "PORTABLE";

		// Token: 0x04000552 RID: 1362
		private const string ac = "MOBILE";

		// Token: 0x04000553 RID: 1363
		private const string ad = "FPS_DEPLOYMENT";

		// Token: 0x04000554 RID: 1364
		private const string ae = "DEPOT_DEPLOYMENT";

		// Token: 0x04000555 RID: 1365
		private const string af = "SOURCE_CPG_VERSION_LT_5";

		// Token: 0x04000556 RID: 1366
		private const string ag = "SOURCE_CPG_VERSION_LT_6";

		// Token: 0x04000557 RID: 1367
		private const string ah = "SOURCE_CPG_VERSION_LT_11";

		// Token: 0x04000558 RID: 1368
		private const string ai = "SOURCE_CPG_VERSION_LT_2016_Q1SER";

		// Token: 0x04000559 RID: 1369
		private const string aj = "SOURCE_PCI_EXPANDED_MDC_E_F";

		// Token: 0x0400055A RID: 1370
		private const string ak = "SOURCE_PCI_DISABLE_EMERGENCY_CALL_INDICATIONS_CAPABLE";

		// Token: 0x0400055B RID: 1371
		private const string al = "SOURCE_PCI_PASS_ALARM_FILTER_CAPABLE";

		// Token: 0x0400055C RID: 1372
		private const string am = "STRING_PCI_MOSCAD3000_ENHANCE";

		// Token: 0x0400055D RID: 1373
		private const string an = "STRING_PCI_PERSONNEL_ACCOUNTABILITY_ALERT_CAPABILITY";

		// Token: 0x0400055E RID: 1374
		private const string ao = "STRING_PCI_USER_SELECTABLE_PL_ENHANCEMENT";

		// Token: 0x0400055F RID: 1375
		private const string ap = "STRING_PCI_CONSOLIDATED_ACTIONS_ENHANCEMENT";

		// Token: 0x04000560 RID: 1376
		private const string aq = "STRING_PCI_LIMITED_ISSI_DVRS_OPERATION_CAPABLE";

		// Token: 0x04000561 RID: 1377
		private const string ar = "STRING_PCI_ACTIVE_MIC_FOR_PTT";

		// Token: 0x04000562 RID: 1378
		private const string @as = "STRING_PCI_APX_SINGLETONE_CAPABLE";

		// Token: 0x04000563 RID: 1379
		private const string at = "STRING_PCI_ENHANCED_ARS";

		// Token: 0x04000564 RID: 1380
		private const string au = "STRING_PCI_EMERGENCY_CALL_ONLY_WITH_HOT_MIC_CAPABLE";

		// Token: 0x04000565 RID: 1381
		private const string av = "STRING_PCI_ZONE_CLONE_CAPABLE";

		// Token: 0x04000566 RID: 1382
		private const string aw = "STRING_PCI_EMERGENCY_CALL_TERMINATION";

		// Token: 0x04000567 RID: 1383
		private const string ax = "STRING_PCI_IPS_CAPABLE";

		// Token: 0x04000568 RID: 1384
		private const string ay = "STRING_PCI_DISABLE_WIND_NOISE_REDUCTION_LEVEL_FOR_ACCESSORIES";

		// Token: 0x04000569 RID: 1385
		private const string az = "SOURCE_PCI_RADIOLOCK_EXTENSION_CAPABLE";

		// Token: 0x0400056A RID: 1386
		private const string a0 = "STRING_PCI_EXTENDED_PL_TONE_SET";

		// Token: 0x0400056B RID: 1387
		private const string a1 = "STRING_PCI_ALLOW_PSU_SECURE";

		// Token: 0x0400056C RID: 1388
		private const string a2 = "STRING_PCI_UCL_CONTACTS_LIMITATION_ENHANCEMENT";

		// Token: 0x0400056D RID: 1389
		private const string a3 = "STRING_PCI_DVRS_RANGE_EXT";

		// Token: 0x0400056E RID: 1390
		private const string a4 = "PCI_ADP_FLASHCODE_GATING";

		// Token: 0x0400056F RID: 1391
		private const string a5 = "STRING_PCI_INDIRECT_PTT_AUDIO_ROUTING_PCI";

		// Token: 0x04000570 RID: 1392
		private const string a6 = "SIREN_LIGHTS_KEYPAD";

		// Token: 0x04000571 RID: 1393
		private const string a7 = "INTERNATIONAL";

		// Token: 0x04000572 RID: 1394
		private const string a8 = "I";

		// Token: 0x04000573 RID: 1395
		private const string a9 = "QA03055";

		// Token: 0x04000574 RID: 1396
		private const string ba = "EMG_RVT";

		// Token: 0x04000575 RID: 1397
		private const string bb = "EMG_BEACON_ROUTING";

		// Token: 0x04000576 RID: 1398
		private const string bc = "MAN_DOWN_EMER_PRF_CFG";

		// Token: 0x04000577 RID: 1399
		private const string bd = "EMER_TONE_CFG";

		// Token: 0x04000578 RID: 1400
		private const string be = "H17";

		// Token: 0x04000579 RID: 1401
		private const string bf = "GA01033";

		// Token: 0x0400057A RID: 1402
		private const string bg = "BASIC_CONTROL_HEAD";

		// Token: 0x0400057B RID: 1403
		private const string bh = "HOT_MIC";

		// Token: 0x0400057C RID: 1404
		private const string bi = "AUDIBLE_EMERGENCY_BEACON_FOR_MOBILE";

		// Token: 0x0400057D RID: 1405
		private const string bj = "QA04865";

		// Token: 0x0400057E RID: 1406
		private const string bk = "AUDIO_ENH";

		// Token: 0x0400057F RID: 1407
		private const string bl = "QA07468";

		// Token: 0x04000580 RID: 1408
		private const string bm = "QA07521";

		// Token: 0x04000581 RID: 1409
		private const string bn = "STRING_PCI_MARVELL_DNP";

		// Token: 0x04000582 RID: 1410
		private const string bo = "GA01788";

		// Token: 0x04000583 RID: 1411
		private const string bp = "PCI_SUPPORT_O3_CH";

		// Token: 0x04000584 RID: 1412
		private const string bq = "PCI_ANALOGWIDEBANDDATA";

		// Token: 0x04000585 RID: 1413
		private static string[] br;

		// Token: 0x04000586 RID: 1414
		private global::SpecialFeatures.Model_Configuration.ModelTiering.ActionTypes bs;

		// Token: 0x04000587 RID: 1415
		private global::SpecialFeatures.Model_Configuration.ModelTiering.TargetTypes bt;

		// Token: 0x04000588 RID: 1416
		private string bu;

		// Token: 0x04000589 RID: 1417
		private global::System.Collections.Generic.List<string> bv;

		// Token: 0x0400058A RID: 1418
		private bool bw;

		// Token: 0x0400058B RID: 1419
		private string bx;

		// Token: 0x0400058C RID: 1420
		private string by;

		// Token: 0x0400058D RID: 1421
		private global::System.Collections.Generic.Dictionary<string, bool> bz;

		// Token: 0x0400058E RID: 1422
		private global::System.Collections.Generic.Dictionary<string, int> b0;

		// Token: 0x0400058F RID: 1423
		private global::SpecialFeatures.Flashport.FlashRadio.FlashcodeTable b1;

		// Token: 0x04000590 RID: 1424
		private global::AcpModelTieringLib.CModelTieringEngine b2;

		// Token: 0x04000591 RID: 1425
		private global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.List<string>> b3;

		// Token: 0x020000AE RID: 174
		public enum RecsetAttributeTypes
		{
			// Token: 0x04000593 RID: 1427
			MaxRecords,
			// Token: 0x04000594 RID: 1428
			MaxPoolRecords,
			// Token: 0x04000595 RID: 1429
			MinRecords,
			// Token: 0x04000596 RID: 1430
			DefaultRecords,
			// Token: 0x04000597 RID: 1431
			Visibility
		}

		// Token: 0x020000AF RID: 175
		public enum ActionTypes
		{
			// Token: 0x04000599 RID: 1433
			NONE,
			// Token: 0x0400059A RID: 1434
			NEW,
			// Token: 0x0400059B RID: 1435
			OPEN,
			// Token: 0x0400059C RID: 1436
			FLASHPORT,
			// Token: 0x0400059D RID: 1437
			DEPOT
		}

		// Token: 0x020000B0 RID: 176
		public enum TargetTypes
		{
			// Token: 0x0400059F RID: 1439
			NONE,
			// Token: 0x040005A0 RID: 1440
			ALL,
			// Token: 0x040005A1 RID: 1441
			RECORDSETS,
			// Token: 0x040005A2 RID: 1442
			FIELDS
		}
	}
}
