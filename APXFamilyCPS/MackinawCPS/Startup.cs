using System;
using System.Collections;
using System.Configuration;
using System.Reflection;
using System.Security.Cryptography;
using System.Security.Principal;
using System.ServiceModel;
using System.ServiceModel.Configuration;
using System.Threading;
using System.Windows;
using System.Windows.Forms;
using CommonResources;
using MackinawCPS.InitializationScreen;
using MackinawCPS.WcfServiceForRmcTemplateTest;
using Motorola.CommonCPS.RadioManagement.CommonBase;
using PreEmptive.SoS.Runtime;
using SpecialFeatures.FCCExceptionHandler;
using SpecialFeatures.Utilities;

namespace MackinawCPS
{
	// Token: 0x0200004B RID: 75
	internal class Startup
	{
		// Token: 0x0600021D RID: 541 RVA: 0x00064FA8 File Offset: 0x000631A8
		[global::System.STAThread]
		public static void Main(string[] args)
		{
			int a_ = 16;
			short num = (short)1488781312;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_AC;
				}
				bool flag;
				bool flag2;
				for (;;)
				{
					IL_31:
					string text;
					global::System.Security.Cryptography.SHA256 sha;
					global::MackinawCPS.App app;
					switch (num2)
					{
					case 0:
						if (text.Length > 0)
						{
							num = (short)1613889542;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2FD;
					case 1:
						if (flag)
						{
							num = (short)1797718030;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_39D;
					case 2:
						try
						{
							switch (0)
							{
							case 0:
								goto IL_59A;
							}
							global::System.Security.Principal.WindowsPrincipal windowsPrincipal;
							for (;;)
							{
								IL_583:
								switch (num2)
								{
								case 0:
									goto IL_619;
								case 1:
									global::MackinawCPS.Startup.IsGuest = windowsPrincipal.IsInRole(global::System.Security.Principal.WindowsBuiltInRole.Guest);
									num = (short)1776943107;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									if (flag)
									{
										num = (short)410451969;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_5FE;
								case 3:
									goto IL_5FE;
								}
								goto IL_59A;
								IL_5FE:
								windowsPrincipal = null;
								num = (short)1477574656;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_619:
							goto IL_51D;
							IL_59A:
							windowsPrincipal = new global::System.Security.Principal.WindowsPrincipal(global::System.Security.Principal.WindowsIdentity.GetCurrent());
							num = (short)1216282626;
							num2 = (int)((global::System.IntPtr)num);
							goto IL_583;
						}
						catch (global::System.Exception)
						{
							goto IL_51D;
						}
						goto IL_624;
					case 3:
						try
						{
							sha = new global::System.Security.Cryptography.SHA256CryptoServiceProvider();
							goto IL_691;
						}
						catch (global::System.Exception)
						{
							goto IL_691;
						}
						goto IL_3FC;
						IL_691:
						num = (short)735379465;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						goto IL_624;
					case 5:
						goto IL_48F;
					case 6:
						num = (short)158007323;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
						try
						{
							num = (short)1187512322;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_1D3;
								case 1:
									global::System.Windows.MessageBox.Show(global::CommonResources.AppResources.Unable_to_start_the_APX_CPS, global::CommonResources.AppResources.APX_CPS);
									num = (short)890306563;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_123;
									}
									continue;
								case 3:
									goto IL_169;
								}
								IL_123:
								if (global::MackinawCPS.Startup.ValidateDeviceCommunicationServiceHost())
								{
									num = (short)1094324523;
									short num3 = num;
									num = (short)583668011;
									switch ((num3 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										break;
									default:
										num = (short)1749417984;
										if (num != 0)
										{
										}
										num = (short)681508864;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
								}
								num = (short)214368257;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_169:
							return;
							IL_1D3:
							goto IL_673;
						}
						catch (global::System.Exception)
						{
							goto IL_673;
						}
						return;
						IL_673:
						num = (short)1127743516;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 8:
						sha.Dispose();
						num = (short)1750073368;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 9:
						if (sha == null)
						{
							num = (short)1583874071;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1051000858;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 10:
						goto IL_2D0;
					case 11:
						if (flag)
						{
							num = (short)1985478666;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 12:
						if (args.Length != 0)
						{
							num = (short)147521551;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2FD;
					case 13:
						global::MackinawCPS.Startup._cpsRmcServiceForTests = new global::System.ServiceModel.ServiceHost(typeof(global::MackinawCPS.WcfServiceForRmcTemplateTest.MackinawOperationContract), global::System.Array.Empty<global::System.Uri>());
						global::MackinawCPS.Startup._cpsRmcServiceForTests.Open();
						flag2 = true;
						num = (short)231735316;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 14:
						try
						{
							global::MackinawCPS.Startup.threadWait = new global::System.Threading.AutoResetEvent(false);
							global::System.Threading.Thread thread = new global::System.Threading.Thread(new global::System.Threading.ThreadStart(global::MackinawCPS.Startup.ShowSplashScreen));
							thread.SetApartmentState(global::System.Threading.ApartmentState.STA);
							thread.Start();
							global::MackinawCPS.Startup.threadWait.WaitOne();
							app.Properties[global::PreEmptive.SoS.Runtime.FixedLengthStream.b("華英飳韵请鋹꿻鷽狿朁愃栅", a_)] = global::MackinawCPS.Startup.splash;
							global::MackinawCPS.Startup.splash = null;
							goto IL_39D;
						}
						catch
						{
							goto IL_39D;
						}
						goto IL_2D0;
					case 15:
						goto IL_3FC;
					case 16:
						goto IL_2F8;
					case 17:
						num = (short)35913746;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 18:
						if (text.CompareTo(global::PreEmptive.SoS.Runtime.FixedLengthStream.b("\uddef鯱髳鿵賷", a_)) != 0)
						{
							num = (short)884670468;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_22F;
					case 19:
						if (text.CompareTo(global::PreEmptive.SoS.Runtime.FixedLengthStream.b("\udfef釱蛳菵雷駹铻鯽狿", a_)) == 0)
						{
							num = (short)1368522773;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_48F;
					case 20:
						goto IL_2FD;
					case 21:
						goto IL_22F;
					case 22:
						goto IL_3BC;
					case 23:
						num = (short)1656160267;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 24:
						goto IL_24E;
					case 25:
						if (text.Length > 0)
						{
							num = (short)455802897;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_48F;
					case 26:
						if (sha != null)
						{
							num = (short)1019215880;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_24E;
					case 27:
						if (text.CompareTo(global::PreEmptive.SoS.Runtime.FixedLengthStream.b("\udfef胱至飵雷鏹鋻駽忿瀁椃攅圇縉椋挍怏縑甓戕紗䔙栛笝匟嘡圣", a_)) == 0)
						{
							num = (short)1430519821;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2FD;
					case 28:
						try
						{
							global::SpecialFeatures.FCCExceptionHandler.FCCExceptionHandler.Instance.InitExceptionList();
							goto IL_31B;
						}
						catch (global::System.Exception)
						{
							global::System.Windows.MessageBox.Show(global::CommonResources.AppResources.Unable_to_start_APX_CPS_Critical_file_missing, global::CommonResources.AppResources.APX_CPS);
							return;
						}
						goto IL_51D;
						IL_31B:
						global::Motorola.CommonCPS.RadioManagement.CommonBase.Global.RMClientVersion = global::SpecialFeatures.Utilities.RMVersioningUtilities.GetClientVersion();
						app = new global::MackinawCPS.App();
						app.Properties[global::PreEmptive.SoS.Runtime.FixedLengthStream.b("뇯蟱胳駵곷鿹迻諽䷿洁怃挅", a_)] = flag2;
						app.Properties[global::PreEmptive.SoS.Runtime.FixedLengthStream.b("華英飳韵请鋹꿻鷽狿朁愃栅", a_)] = null;
						num = (short)1697579009;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_AC;
					IL_22F:
					flag = false;
					num = (short)830668805;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_24E:
					sha = null;
					num = (short)643497991;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2D0:
					global::MackinawCPS.Startup.ShowStartupErrorDialog(global::CommonResources.AppResources.Unable_to_start_the_APX_CPS, global::CommonResources.AppResources.APX_CPS);
					num = (short)894894096;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2FD:
					num = (short)1886715906;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_39D:
					app.Run();
					num = (short)959119382;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_3FC:
					text = args[0].Trim().ToLower();
					num = (short)971505689;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_48F:
					num = (short)3342337;
					if (num != 0)
					{
					}
					num = (short)1966604288;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_51D:
					sha = null;
					num = (short)1161035779;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_624:
					num = (short)1389494291;
					num2 = (int)((global::System.IntPtr)num);
				}
				return;
				IL_2F8:
				return;
				IL_3BC:
				num = (short)255131648;
				short num4 = num;
				return;
				IL_AC:
				flag = true;
				flag2 = false;
				num = (short)1731395596;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_31;
			}
			}
		}

		// Token: 0x0600021E RID: 542 RVA: 0x00065770 File Offset: 0x00063970
		private static void ShowStartupErrorDialog(string error_message, string dialog_title)
		{
			short num = (short)444726680;
			short num2 = num;
			num = (short)508820888;
			switch (num2 == num)
			{
			}
			num = (short)954204160;
			short num3 = num;
			num = (short)1587281921;
			if (num != 0)
			{
			}
			num = (short)563216384;
			if (num != 0)
			{
			}
			global::System.Windows.MessageBox.Show(error_message, dialog_title, global::System.Windows.MessageBoxButton.OK, global::System.Windows.MessageBoxImage.Hand);
		}

		// Token: 0x0600021F RID: 543 RVA: 0x00065824 File Offset: 0x00063A24
		private static void ShowSplashScreen()
		{
			int a_ = 19;
			short num;
			for (;;)
			{
				num = (short)1431240704;
				int num2 = (int)num;
				switch (num2)
				{
				default:
				{
					num = (short)1246247356;
					short num3 = num;
					num = (short)1862220220;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						goto IL_5B;
					}
					break;
				}
				}
			}
			IL_5B:
			num = (short)951123968;
			if (num != 0)
			{
			}
			string productVersionText = "";
			try
			{
				switch (0)
				{
				case 0:
					goto IL_BA;
				}
				int num2;
				object[] customAttributes;
				global::System.Reflection.AssemblyDescriptionAttribute assemblyDescriptionAttribute;
				for (;;)
				{
					IL_83:
					switch (num2)
					{
					case 0:
						num = (short)2023292934;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						num = (short)1523515395;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						num = (short)1177354247;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						if (customAttributes.Length != 0)
						{
							num = (short)227541001;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_23E;
					case 4:
						goto IL_256;
					case 5:
						if (assemblyDescriptionAttribute != null)
						{
							num = (short)1357774850;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_23E;
					case 6:
						if (assemblyDescriptionAttribute.Description.Length > 0)
						{
							num = (short)723255307;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_23E;
					case 7:
						if (assemblyDescriptionAttribute.Description != null)
						{
							num = (short)1196687360;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_23E;
					case 8:
						goto IL_23E;
					case 9:
						assemblyDescriptionAttribute = (customAttributes[0] as global::System.Reflection.AssemblyDescriptionAttribute);
						num = (short)474808325;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 10:
						if (customAttributes != null)
						{
							num = (short)211484673;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_23E;
					case 11:
						productVersionText = assemblyDescriptionAttribute.Description;
						num = (short)1999437832;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_BA;
					IL_23E:
					num = (short)978780164;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_256:
				goto IL_25B;
				IL_BA:
				productVersionText = global::PreEmptive.SoS.Runtime.FixedLengthStream.b("ꇲ웴웶ퟸ쯺췼퇾㄀㈂", a_);
				customAttributes = global::System.Reflection.Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(global::System.Reflection.AssemblyDescriptionAttribute), false);
				assemblyDescriptionAttribute = null;
				num = (short)496041994;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_83;
			}
			catch (global::System.Exception)
			{
			}
			IL_25B:
			num = (short)1514602497;
			if (num != 0)
			{
			}
			num = (short)1551237120;
			short num4 = num;
			global::System.Windows.Forms.Form form = global::MackinawCPS.Startup.splash = new global::MackinawCPS.InitializationScreen.SplashScreen(new global::System.TimeSpan(0, 0, 5), new global::System.TimeSpan(0, 0, 45), 5, productVersionText, global::System.DateTime.Now.Year.ToString());
			global::MackinawCPS.Startup.threadWait.Set();
			form.ShowDialog();
		}

		// Token: 0x06000220 RID: 544 RVA: 0x00065B40 File Offset: 0x00063D40
		private static bool ValidateDeviceCommunicationServiceHost()
		{
			int a_ = 6;
			short num;
			try
			{
				num = (short)1896611840;
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
					global::System.ServiceModel.Configuration.ClientSection clientSection;
					for (;;)
					{
						IL_31:
						switch (num2)
						{
						case 0:
							goto IL_3F5;
						case 1:
						{
							global::System.ServiceModel.Configuration.ChannelEndpointElementCollection endpoints;
							global::System.Collections.IEnumerator enumerator = endpoints.GetEnumerator();
							num = (short)1408106501;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 2:
						{
							global::System.ServiceModel.Configuration.ChannelEndpointElementCollection endpoints = clientSection.Endpoints;
							num = (short)1940324355;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 3:
						{
							global::System.ServiceModel.Configuration.ChannelEndpointElementCollection endpoints;
							if (endpoints != null)
							{
								num = (short)1896873985;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_3DD;
						}
						case 4:
							if (clientSection != null)
							{
								num = (short)507314178;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_3DD;
						case 5:
							try
							{
								num = (short)1615790080;
								num2 = (int)((global::System.IntPtr)num);
								bool result;
								for (;;)
								{
									switch (num2)
									{
									case 0:
										switch (0)
										{
										case 0:
											goto IL_159;
										}
										continue;
									case 1:
										goto IL_193;
									case 2:
										num = (short)1571225603;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 3:
										goto IL_313;
									case 4:
										num = (short)403701768;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 5:
									{
										global::System.ServiceModel.Configuration.ChannelEndpointElement channelEndpointElement;
										if (!(channelEndpointElement.Contract == global::PreEmptive.SoS.Runtime.FixedLengthStream.b("ꋥ跧鳩藫跭闯ꇱ釳蓵軷鏹鿻鯽⻿䬁䀃挅縇按漋欍䌏眑易怕焗礙礛", a_)))
										{
											num = (short)1175191556;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										goto IL_193;
									}
									case 6:
									{
										global::System.ServiceModel.Configuration.ChannelEndpointElement channelEndpointElement;
										if (channelEndpointElement.Address != null)
										{
											num = (short)1902051337;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										break;
									}
									case 7:
									{
										global::System.ServiceModel.Configuration.ChannelEndpointElement channelEndpointElement;
										if (string.Compare(channelEndpointElement.Address.Host, global::PreEmptive.SoS.Runtime.FixedLengthStream.b("諥蟧觩跫苭飯鷱蟳苵", a_), true) != 0)
										{
											num = (short)747438092;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										break;
									}
									case 8:
									{
										global::System.ServiceModel.Configuration.ChannelEndpointElement channelEndpointElement;
										if (channelEndpointElement.Contract == global::PreEmptive.SoS.Runtime.FixedLengthStream.b("ꋥ跧鳩藫跭闯뛱鷳藵鯷闹諻鯽狿笁⨃伅䰇漉程服猏眑倓缕欗礙猛栝䔟倡崣", a_))
										{
											num = (short)1036189697;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										break;
									}
									case 9:
										num = (short)528875527;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 10:
										goto IL_249;
									case 11:
									{
										global::System.Collections.IEnumerator enumerator;
										if (!enumerator.MoveNext())
										{
											num = (short)888471554;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										global::System.ServiceModel.Configuration.ChannelEndpointElement channelEndpointElement = (global::System.ServiceModel.Configuration.ChannelEndpointElement)enumerator.Current;
										num = (short)548667397;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 12:
										result = false;
										num = (short)582877194;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									IL_15B:
									num = (short)1526595595;
									num2 = (int)((global::System.IntPtr)num);
									continue;
									IL_159:
									goto IL_15B;
									IL_193:
									num = (short)1026752518;
									num2 = (int)((global::System.IntPtr)num);
								}
								IL_249:
								return result;
								IL_313:;
							}
							finally
							{
								switch (0)
								{
								case 0:
									goto IL_335;
								}
								global::System.IDisposable disposable;
								for (;;)
								{
									IL_322:
									switch (num2)
									{
									case 0:
										disposable.Dispose();
										num = (short)1048051714;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 1:
										goto IL_352;
									case 2:
									{
										num = (short)43862372;
										short num3 = num;
										num = (short)24004964;
										switch ((num3 == num) ? 1 : 0)
										{
										case 0:
										case 2:
											goto IL_352;
										default:
											goto IL_3C4;
										}
										break;
									}
									}
									goto IL_335;
									IL_352:
									if (disposable == null)
									{
										goto IL_3DC;
									}
									num = (short)517406720;
									num2 = (int)((global::System.IntPtr)num);
								}
								IL_3C4:
								num = (short)1796079616;
								if (num != 0)
								{
								}
								IL_3DC:
								goto EndFinally_14;
								IL_335:
								global::System.Collections.IEnumerator enumerator;
								disposable = (enumerator as global::System.IDisposable);
								num = (short)1578369025;
								num2 = (int)((global::System.IntPtr)num);
								goto IL_322;
								EndFinally_14:;
							}
							goto IL_3DD;
						}
						goto IL_50;
						IL_3DD:
						num = (short)1742864384;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_3F5:
					break;
					IL_50:
					clientSection = (global::System.Configuration.ConfigurationManager.GetSection(global::PreEmptive.SoS.Runtime.FixedLengthStream.b("闥釧駩飫语鷯\udcf1蟳鏵諷賹闻鷽旿企欃戅洇昉⌋洍簏笑焓砕気", a_)) as global::System.ServiceModel.Configuration.ClientSection);
					num = (short)1515257860;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_31;
				}
				}
			}
			catch (global::System.Configuration.ConfigurationErrorsException)
			{
				return false;
			}
			num = (short)1115947009;
			if (num != 0)
			{
			}
			num = (short)920977408;
			short num4 = num;
			return true;
		}

		// Token: 0x0400017B RID: 379
		private static global::MackinawCPS.InitializationScreen.SplashScreen splash;

		// Token: 0x0400017C RID: 380
		private static global::System.Threading.AutoResetEvent threadWait;

		// Token: 0x0400017D RID: 381
		internal static bool IsGuest;

		// Token: 0x0400017E RID: 382
		private static global::System.ServiceModel.ServiceHost _cpsRmcServiceForTests;

		// Token: 0x0400017F RID: 383
		[global::System.NonSerialized]
		private string VafgnaprSvryq = 32;
	}
}
