using System;
using System.IO;
using System.Security;
using System.Windows;
using AcpCommonLib;
using CodeplugExchangeLibrary;
using CommonResources;
using ConstraintHelper;
using Motorola.Acp.PackUnpack.Ish;
using Motorola.Common.Communication.CommonFile;
using Motorola.Common.Communication.CommonUtil;
using Motorola.MackinawCPS.CoreFeatures.PackExec;
using MotorolaSolutions.RadioCentral.CodeplugExchangeLibrary.Extensions;
using SpecialFeatures.AcpReportManagerLib;
using SpecialFeatures.CxfFilePassword.Helpers;
using SpecialFeatures.CxfFilePassword.Models;
using SpecialFeatures.CxfFilePassword.View;
using SpecialFeatures.CxfFilePassword.ViewModel;

namespace SpecialFeatures.CxfFilePassword
{
	// Token: 0x02000147 RID: 327
	public static class CxfFileHandler
	{
		// Token: 0x060010CB RID: 4299 RVA: 0x001776E8 File Offset: 0x001758E8
		public static global::CodeplugExchangeLibrary.CodeplugExchangeFile OpenFileAndValidatePassword(string filePath)
		{
			short num = (short)141557774;
			int num2 = (int)((global::System.IntPtr)num);
			global::CodeplugExchangeLibrary.CodeplugExchangeFile codeplugExchangeFile2;
			for (;;)
			{
				global::System.Security.SecureString secureString;
				global::CodeplugExchangeLibrary.CodeplugExchangeFile codeplugExchangeFile;
				global::SpecialFeatures.CxfFilePassword.Models.CxfFilePasswordPromptResult cxfFilePasswordPromptResult;
				switch (num2)
				{
				case 0:
					secureString = null;
					goto IL_1C3;
				case 1:
					return codeplugExchangeFile;
				case 2:
					goto IL_227;
				case 3:
					codeplugExchangeFile2 = global::CodeplugExchangeLibrary.CodeplugExchangeFileFactory.Open(filePath, global::SpecialFeatures.CxfFilePassword.CxfFileHandler.a);
					num = (short)395575304;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					goto IL_17A;
				case 5:
					if (!cxfFilePasswordPromptResult.RememberCxfFilePassword)
					{
						num = (short)390529030;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1461780489;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 6:
					num = (short)438173696;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 7:
					num = (short)323944449;
					if (num != 0)
					{
					}
					codeplugExchangeFile = global::CodeplugExchangeLibrary.CodeplugExchangeFileFactory.Open(filePath, cxfFilePasswordPromptResult.ProvidedPassword);
					num = (short)977928204;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 8:
					if (codeplugExchangeFile2 != null)
					{
						num = (short)1520304143;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_296;
				case 9:
				{
					num = (short)13083081;
					short num3 = num;
					num = (short)86417865;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_2DB;
					default:
						num = (short)814940160;
						if (num != 0)
						{
						}
						secureString = cxfFilePasswordPromptResult.ProvidedPassword;
						goto IL_1C3;
					}
					break;
				}
				case 10:
				{
					num = (short)603324416;
					short num4 = num;
					if (codeplugExchangeFile != null)
					{
						num = (short)1261240321;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_227;
				}
				case 11:
					global::SpecialFeatures.CxfFilePassword.CxfFileHandler.a(cxfFilePasswordPromptResult);
					num = (short)757399556;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 12:
					goto IL_2DB;
				case 13:
					if (!cxfFilePasswordPromptResult.Cancelled)
					{
						num = (short)10027015;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return codeplugExchangeFile;
				case 14:
					switch (0)
					{
					case 0:
						goto IL_64;
					}
					continue;
				case 15:
					return codeplugExchangeFile2;
				}
				IL_64:
				if (global::SpecialFeatures.CxfFilePassword.CxfFileHandler.a != null)
				{
					num = (short)1368850435;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_296;
				IL_17A:
				global::SpecialFeatures.CxfFilePassword.CxfFileHandler.currentlyOpenedCxfFilePass = cxfFilePasswordPromptResult.ProvidedPassword;
				num = (short)290979845;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_2DB:
				if (codeplugExchangeFile == null)
				{
					num = (short)1890385931;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_17A;
				IL_1C3:
				global::SpecialFeatures.CxfFilePassword.CxfFileHandler.a = secureString;
				num = (short)2056126474;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_227:
				cxfFilePasswordPromptResult = global::SpecialFeatures.CxfFilePassword.CxfFileHandler.a(global::System.IO.Path.GetFileName(filePath));
				num = (short)1888747533;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_296:
				codeplugExchangeFile = null;
				num = (short)1607270402;
				num2 = (int)((global::System.IntPtr)num);
			}
			return codeplugExchangeFile2;
		}

		// Token: 0x060010CC RID: 4300 RVA: 0x001779F4 File Offset: 0x00175BF4
		public static global::System.Security.SecureString InitializePassword(bool isCxfEditingMode)
		{
			switch (0)
			{
			case 0:
				goto IL_40;
			}
			int num;
			short num2;
			global::System.Security.SecureString result;
			bool flag;
			for (;;)
			{
				IL_0A:
				global::SpecialFeatures.CxfFilePassword.Models.CxfFileInitializePasswordPromptResult cxfFileInitializePasswordPromptResult;
				global::System.Security.SecureString secureString;
				switch (num)
				{
				case 0:
					secureString = cxfFileInitializePasswordPromptResult.ProvidedPassword;
					goto IL_1CB;
				case 1:
					if (!cxfFileInitializePasswordPromptResult.Cancelled)
					{
						num2 = (short)1412694025;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				case 2:
					return result;
				case 3:
					goto IL_102;
				case 4:
					if (flag)
					{
						num2 = (short)173801483;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_102;
				case 5:
					secureString = null;
					goto IL_1CB;
				case 6:
					if (flag)
					{
						num2 = (short)364773378;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_13A;
				case 7:
					num2 = (short)1838088197;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 8:
					if (!cxfFileInitializePasswordPromptResult.RememberCxfFilePassword)
					{
						num2 = (short)2108686343;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)1520828416;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 9:
				{
					num2 = (short)1952712375;
					short num3 = num2;
					num2 = (short)125175479;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_141;
					default:
						num2 = (short)2031222784;
						if (num2 != 0)
						{
						}
						flag = global::SpecialFeatures.CxfFilePassword.CxfFileHandler.a(cxfFileInitializePasswordPromptResult);
						num2 = (short)351731716;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 10:
					goto IL_13A;
				case 11:
				{
					num2 = (short)1620049920;
					short num4 = num2;
					result = cxfFileInitializePasswordPromptResult.ProvidedPassword;
					num2 = (short)630194184;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				}
				goto IL_40;
				IL_102:
				num2 = (short)111738886;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_141:
				num2 = (short)1368129537;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_13A:
				cxfFileInitializePasswordPromptResult = global::SpecialFeatures.CxfFilePassword.CxfFileHandler.a(isCxfEditingMode);
				goto IL_141;
				IL_1CB:
				global::SpecialFeatures.CxfFilePassword.CxfFileHandler.a = secureString;
				num2 = (short)1901461507;
				num = (int)((global::System.IntPtr)num2);
			}
			return result;
			IL_40:
			num2 = (short)1910833153;
			if (num2 != 0)
			{
			}
			result = null;
			flag = false;
			num2 = (short)552337418;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x060010CD RID: 4301 RVA: 0x00177C5C File Offset: 0x00175E5C
		public static bool OpenCodeplugFile(byte[] codeplugBytes)
		{
			switch (0)
			{
			case 0:
				goto IL_8E;
			}
			short num;
			int num4;
			string modelNumber;
			for (;;)
			{
				IL_0A:
				num = (short)2122606702;
				short num2 = num;
				num = (short)357787758;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)1280114688;
					short num3 = num;
					num = (short)705822720;
					if (num != 0)
					{
					}
					switch (num4)
					{
					case 0:
						if (string.IsNullOrEmpty(modelNumber))
						{
							goto IL_C6;
						}
						num = (short)1707933698;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						return false;
					case 2:
						goto IL_135;
					}
					goto IL_8E;
				}
				}
				IL_C6:
				num = (short)732692481;
				num4 = (int)((global::System.IntPtr)num);
			}
			return false;
			IL_135:
			num = (short)1963720705;
			if (num != 0)
			{
			}
			global::Motorola.Common.Communication.CommonUtil.IshItemCollection codeplugInIshItemCollection;
			try
			{
				new global::Motorola.MackinawCPS.CoreFeatures.PackExec.PackUnpackExecutor().Unpack(global::SpecialFeatures.CxfFilePassword.Helpers.CmpToRawPartitionsConversionHelper.ConvertIshItemCollectionToRawPartitions(codeplugInIshItemCollection), modelNumber);
				return true;
			}
			catch (global::System.Exception)
			{
				global::System.Windows.MessageBox.Show(global::CommonResources.AppResources.Unable_to_unpack_codeplug_image, global::CommonResources.AppResources.Open_Byte_Array_File, global::System.Windows.MessageBoxButton.OK);
				global::AcpCommonLib.AppInfoManager.StatusMsgReport.RegisterMessage(global::AcpCommonLib.StatusMsgType.Error, global::CommonResources.AppResources.Unable_to_unpack_codeplug_image);
				return false;
			}
			return false;
			IL_8E:
			codeplugInIshItemCollection = new global::Motorola.Common.Communication.CommonFile.PartitionCommonFile(true).Deserialize(codeplugBytes).GetCodeplugInIshItemCollection();
			modelNumber = global::SpecialFeatures.CxfFilePassword.Helpers.CmpToRawPartitionsConversionHelper.GetModelNumber(codeplugInIshItemCollection);
			num = (short)1232076800;
			num4 = (int)((global::System.IntPtr)num);
			goto IL_0A;
		}

		// Token: 0x060010CE RID: 4302 RVA: 0x00177DE0 File Offset: 0x00175FE0
		public static bool SaveCodeplugFile(string filePath, global::System.Security.SecureString filePassword, string modelNumber, string codeplugVersion)
		{
			int a_ = 0;
			short num;
			bool result;
			try
			{
				num = (short)824639488;
				int num2 = (int)num;
				switch (num2)
				{
				default:
				{
					num = (short)1995478936;
					short num3 = num;
					num = (short)1253480344;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num = (short)1739849728;
						if (num != 0)
						{
						}
						switch (0)
						{
						case 0:
							goto IL_96;
						}
						break;
					}
					global::Motorola.Acp.PackUnpack.Ish.Codeplug codeplug;
					for (;;)
					{
						IL_7B:
						switch (num2)
						{
						case 0:
							num = (short)513277953;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
						{
							byte[] cmpCodeplugBytes = global::SpecialFeatures.CxfFilePassword.Helpers.CpsCodeplugToCmpBytesConversionHelper.ConvertCpsCodeplugToCmpBytes(codeplug);
							global::CodeplugExchangeLibrary.CodeplugExchageFileMetadata metadata = new global::CodeplugExchangeLibrary.CodeplugExchageFileMetadata(codeplugVersion, (global::ConstraintHelper.UtilityMack.IsAPXNextOrAloha || global::ConstraintHelper.UtilityMack.IsAlohaRadio) ? global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("슂좄힆", a_) : global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("슂햄\udf86", a_));
							global::CodeplugExchangeLibrary.CodeplugExchangeFile codeplugExchangeFile = global::CodeplugExchangeLibrary.CodeplugExchangeFileFactory.Create(cmpCodeplugBytes, filePassword, metadata);
							num = (short)483328004;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 2:
							if (codeplug != null)
							{
								num = (short)1849556992;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_1CF;
						case 3:
							goto IL_1E7;
						case 4:
							try
							{
								global::CodeplugExchangeLibrary.CodeplugExchangeFile codeplugExchangeFile;
								codeplugExchangeFile.SaveAs(filePath);
								result = true;
								goto IL_264;
							}
							finally
							{
								num = (short)725745664;
								num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									global::CodeplugExchangeLibrary.CodeplugExchangeFile codeplugExchangeFile;
									switch (num2)
									{
									case 0:
										switch (0)
										{
										case 0:
											goto IL_194;
										}
										continue;
									case 1:
										((global::System.IDisposable)codeplugExchangeFile).Dispose();
										num = (short)1068367874;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 2:
										goto IL_1CC;
									}
									IL_194:
									if (codeplugExchangeFile == null)
									{
										break;
									}
									num = (short)827523073;
									num2 = (int)((global::System.IntPtr)num);
								}
								IL_1CC:;
							}
							goto IL_1CF;
						}
						goto IL_96;
						IL_1CF:
						num = (short)1840840707;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_1E7:
					break;
					IL_96:
					global::Motorola.MackinawCPS.CoreFeatures.PackExec.PackUnpackExecutor packUnpackExecutor = new global::Motorola.MackinawCPS.CoreFeatures.PackExec.PackUnpackExecutor();
					packUnpackExecutor.PrePackHandler();
					codeplug = packUnpackExecutor.Pack(modelNumber);
					num = (short)1839661058;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_7B;
				}
				}
			}
			catch (global::System.Exception ex)
			{
				if (ex.Message == global::CommonResources.AppResources.Codeplug_Exceeds_Size_Limit_On_Write)
				{
					global::AcpCommonLib.AppInfoManager.StatusMsgReport.RegisterMessage(global::AcpCommonLib.StatusMsgType.Error, ex.Message);
				}
				global::System.Windows.MessageBox.Show(global::CommonResources.AppResources.Unable_to_pack_codeplug_image, global::CommonResources.AppResources.Save_Codeplug_as_ByteArray, global::System.Windows.MessageBoxButton.OK);
				global::AcpCommonLib.AppInfoManager.StatusMsgReport.RegisterMessage(global::AcpCommonLib.StatusMsgType.Error, global::CommonResources.AppResources.Unable_to_pack_codeplug_image);
				result = false;
				goto IL_264;
			}
			num = (short)53870592;
			short num4 = num;
			return false;
			IL_264:
			num = (short)2001928193;
			if (num != 0)
			{
			}
			return result;
		}

		// Token: 0x060010CF RID: 4303 RVA: 0x001780B0 File Offset: 0x001762B0
		private static global::SpecialFeatures.CxfFilePassword.Models.CxfFilePasswordPromptResult a(string A_0)
		{
			short num = (short)771774571;
			short num2 = num;
			num = (short)1826052203;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1229258752;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1726349312;
			if (num != 0)
			{
			}
			num = (short)292683777;
			if (num != 0)
			{
			}
			global::SpecialFeatures.CxfFilePassword.ViewModel.CxfFilePasswordPromptViewModel cxfFilePasswordPromptViewModel = new global::SpecialFeatures.CxfFilePassword.ViewModel.CxfFilePasswordPromptViewModel
			{
				CxfFileName = A_0
			};
			global::SpecialFeatures.CxfFilePassword.View.CxfFilePasswordPrompt prompt = new global::SpecialFeatures.CxfFilePassword.View.CxfFilePasswordPrompt
			{
				DataContext = cxfFilePasswordPromptViewModel
			};
			cxfFilePasswordPromptViewModel.OnClose += delegate(object _, global::System.EventArgs _)
			{
				short num4 = (short)1532110870;
				short num5 = num4;
				num4 = (short)1783375894;
				switch (num5 == num4)
				{
				default:
				{
					num4 = (short)576258048;
					short num6 = num4;
					break;
				}
				case true:
					break;
				}
				num4 = (short)250150912;
				if (num4 != 0)
				{
				}
				num4 = (short)234094593;
				if (num4 != 0)
				{
				}
				prompt.Close();
			};
			global::System.Windows.Application.Current.Dispatcher.Invoke(delegate()
			{
				short num4 = (short)1402947157;
				short num5 = num4;
				num4 = (short)1718634069;
				switch (num5 == num4)
				{
				default:
				{
					num4 = (short)1699414016;
					short num6 = num4;
					break;
				}
				case true:
					break;
				}
				num4 = (short)1478361089;
				if (num4 != 0)
				{
				}
				num4 = (short)319356928;
				if (num4 != 0)
				{
				}
				prompt.Show();
				prompt.Focus();
				prompt.Hide();
				prompt.ShowDialog();
			});
			return new global::SpecialFeatures.CxfFilePassword.Models.CxfFilePasswordPromptResult
			{
				ProvidedPassword = cxfFilePasswordPromptViewModel.ProvidedPassword,
				Cancelled = cxfFilePasswordPromptViewModel.IsCancelled,
				RememberCxfFilePassword = cxfFilePasswordPromptViewModel.RemeberCxfFilePassword
			};
		}

		// Token: 0x060010D0 RID: 4304 RVA: 0x001781D8 File Offset: 0x001763D8
		private static global::SpecialFeatures.CxfFilePassword.Models.CxfFileInitializePasswordPromptResult a(bool A_0)
		{
			short num = (short)18125414;
			short num2 = num;
			num = (short)353014374;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1003945984;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1022820353;
			if (num != 0)
			{
			}
			num = (short)1481703424;
			if (num != 0)
			{
			}
			global::SpecialFeatures.CxfFilePassword.ViewModel.CxfFileInitializePasswordPromptViewModel cxfFileInitializePasswordPromptViewModel = new global::SpecialFeatures.CxfFilePassword.ViewModel.CxfFileInitializePasswordPromptViewModel
			{
				DataLostInfoVisibility = (A_0 ? global::System.Windows.Visibility.Collapsed : global::System.Windows.Visibility.Visible)
			};
			global::SpecialFeatures.CxfFilePassword.View.CxfFileInitializePasswordPrompt prompt = new global::SpecialFeatures.CxfFilePassword.View.CxfFileInitializePasswordPrompt
			{
				DataContext = cxfFileInitializePasswordPromptViewModel
			};
			cxfFileInitializePasswordPromptViewModel.OnClose += delegate(object _, global::System.EventArgs _)
			{
				short num4 = (short)1055140799;
				short num5 = num4;
				num4 = (short)1066216383;
				switch (num5 == num4)
				{
				default:
				{
					num4 = (short)1801584640;
					short num6 = num4;
					break;
				}
				case true:
					break;
				}
				num4 = (short)2132803585;
				if (num4 != 0)
				{
				}
				num4 = (short)698286080;
				if (num4 != 0)
				{
				}
				prompt.Close();
			};
			global::System.Windows.Application.Current.Dispatcher.Invoke(delegate()
			{
				short num4 = (short)1216798279;
				short num5 = num4;
				num4 = (short)2003754567;
				switch (num5 == num4)
				{
				default:
				{
					num4 = (short)1260847104;
					short num6 = num4;
					break;
				}
				case true:
					break;
				}
				num4 = (short)898039809;
				if (num4 != 0)
				{
				}
				num4 = (short)1984167936;
				if (num4 != 0)
				{
				}
				prompt.Show();
				prompt.Focus();
				prompt.Hide();
				prompt.ShowDialog();
			});
			return new global::SpecialFeatures.CxfFilePassword.Models.CxfFileInitializePasswordPromptResult
			{
				ProvidedPassword = cxfFileInitializePasswordPromptViewModel.ProvidedPassword,
				ConfirmedProvidedPassword = cxfFileInitializePasswordPromptViewModel.ConfirmProvidedPassword,
				Cancelled = cxfFileInitializePasswordPromptViewModel.IsCancelled,
				RememberCxfFilePassword = cxfFileInitializePasswordPromptViewModel.RemeberCxfFilePassword
			};
		}

		// Token: 0x060010D1 RID: 4305 RVA: 0x00178314 File Offset: 0x00176514
		private static bool a(global::SpecialFeatures.CxfFilePassword.Models.CxfFileInitializePasswordPromptResult A_0)
		{
			short num = (short)1378877445;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_106;
				case 1:
					num = (short)953155586;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					if (global::SpecialFeatures.CxfFilePassword.CxfFileHandler.a(A_0.ProvidedPassword))
					{
						num = (short)489160710;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_106;
				case 3:
					goto IL_101;
				case 4:
					if (!A_0.ProvidedPassword.Compare(A_0.ConfirmedProvidedPassword))
					{
						num = (short)1153499136;
						short num3 = num;
						num = (short)2029715459;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return true;
				case 5:
					switch (0)
					{
					case 0:
						goto IL_44;
					}
					continue;
				case 6:
					IL_1A7:
					num = (short)1140195335;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 7:
					if (!global::SpecialFeatures.CxfFilePassword.CxfFileHandler.a(A_0.ConfirmedProvidedPassword))
					{
						num = (short)327548928;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)281739268;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_44:
				num = (short)792788993;
				if (num != 0)
				{
				}
				if (!A_0.Cancelled)
				{
					num = (short)1610022913;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_106:
				num = (short)1943379716;
				short num4 = num;
				num = (short)936681220;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_1A7;
				default:
					goto IL_13D;
				}
			}
			IL_101:
			global::System.Windows.MessageBox.Show(global::CommonResources.AppResources.New_Passwords_Do_Not_Match, global::CommonResources.AppResources.APX_CPS, global::System.Windows.MessageBoxButton.OK, global::System.Windows.MessageBoxImage.Exclamation, global::System.Windows.MessageBoxResult.OK);
			return false;
			IL_13D:
			num = (short)1453850624;
			if (num != 0)
			{
			}
			global::System.Windows.MessageBox.Show(global::CommonResources.AppResources.Password_Must_Contain_10_to_32_Characters, global::CommonResources.AppResources.APX_CPS, global::System.Windows.MessageBoxButton.OK, global::System.Windows.MessageBoxImage.Exclamation, global::System.Windows.MessageBoxResult.OK);
			return false;
		}

		// Token: 0x060010D2 RID: 4306 RVA: 0x00178528 File Offset: 0x00176728
		private static bool a(global::System.Security.SecureString A_0)
		{
			short num = (short)19464193;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					num = (short)1234239490;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					switch (0)
					{
					case 0:
						goto IL_34;
					}
					continue;
				case 2:
					num = (short)1251016705;
					if (num != 0)
					{
					}
					if (A_0.Length <= 32)
					{
						num = (short)1722875904;
						short num3 = num;
						num = (short)825950211;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return false;
				case 3:
				{
					num = (short)1911046668;
					short num4 = num;
					num = (short)778912268;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						continue;
					default:
						goto IL_123;
					}
					break;
				}
				}
				IL_34:
				if (A_0 == null)
				{
					return false;
				}
				num = (short)1999372288;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_123:
			num = (short)485621760;
			if (num != 0)
			{
			}
			return A_0.Length >= 10;
		}

		// Token: 0x060010D3 RID: 4307 RVA: 0x00178674 File Offset: 0x00176874
		private static void a(global::SpecialFeatures.CxfFilePassword.Models.CxfFilePasswordPromptResult A_0)
		{
			short num = (short)1947729921;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					num = (short)303562754;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					num = (short)278134785;
					if (num != 0)
					{
					}
					switch (0)
					{
					case 0:
						goto IL_5D;
					}
					continue;
				case 2:
					if (!A_0.Cancelled)
					{
						num = (short)1150943232;
						short num3 = num;
						num = (short)1835859971;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_142;
				case 3:
				{
					num = (short)1418322754;
					short num4 = num;
					num = (short)533259074;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						continue;
					default:
						goto IL_128;
					}
					break;
				}
				}
				IL_5D:
				if (A_0.ProvidedPassword != null)
				{
					goto IL_142;
				}
				num = (short)26279936;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_128:
			num = (short)26017792;
			if (num != 0)
			{
			}
			global::System.Windows.MessageBox.Show(global::CommonResources.AppResources.Please_enter_a_valid_password, global::CommonResources.AppResources.APX_CPS, global::System.Windows.MessageBoxButton.OK, global::System.Windows.MessageBoxImage.Exclamation, global::System.Windows.MessageBoxResult.OK);
			return;
			IL_142:
			global::System.Windows.MessageBox.Show(global::CommonResources.AppResources.Incorrect_Password, global::CommonResources.AppResources.APX_CPS, global::System.Windows.MessageBoxButton.OK, global::System.Windows.MessageBoxImage.Exclamation, global::System.Windows.MessageBoxResult.OK);
		}

		// Token: 0x04000913 RID: 2323
		public static global::System.Security.SecureString currentlyOpenedCxfFilePass;

		// Token: 0x04000914 RID: 2324
		private static global::System.Security.SecureString a;
	}
}
