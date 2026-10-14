using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Markup;
using AcpASKLib;
using AcpCommonLib;
using AcpSecurityLib;
using AcpUI;
using AcpUtility;
using ASK.Interface;
using Common;
using CommonASK;
using commonLicensing;
using CommonResources;
using CommonUtility;
using ConstraintHelper;
using Features.Common;
using Motorola.Common.CommonLib;
using Motorola.Common.Communication.CommonUtil;
using Motorola.Common.Communication.Pba;
using Motorola.Common.CustomException;
using Motorola.CommonCPS.RadioManagement.CommonBase;
using Motorola.CommonCPS.RadioManagement.Core;
using Motorola.CommonCPS.RadioManagement.Global;
using Motorola.CommonCPS.RadioManagement.Infrastructure.Services.RMCExportToCPS;
using Motorola.CommonCPS.RadioManagement.SharedServices;
using Motorola.CommonCPS.ResourceRepository;
using Motorola.CommonCPS.Server.CommonDBConstants;
using Motorola.CommonCPS.Server.EntityModel;
using Motorola.MackinawCPS.CoreFeatures.DisplayAndMenu;
using Motorola.MackinawCPS.CoreFeatures.RadioInformation;
using PreEmptive.SoS.Runtime;
using SpecialFeatures;
using SpecialFeatures.Clone_Configuration.Common;
using SpecialFeatures.Comms;
using SpecialFeatures.Comms.Util;
using SpecialFeatures.DVRSFiles;
using SpecialFeatures.Flashport;
using SpecialFeatures.Flashport.FlashRadio;
using SpecialFeatures.Flashport.FlashRadio.ApxNext;
using SpecialFeatures.Model_Configuration;
using SpecialFeatures.RadioLanguagePack;
using SpecialFeatures.Security;
using SpecialFeatures.SystemCertificates;
using SpecialFeatures.VoiceAnnouncements;

namespace MackinawCPS
{
	// Token: 0x0200003F RID: 63
	public partial class RMCWnd : Window
	{
		// Token: 0x060001B5 RID: 437 RVA: 0x00057164 File Offset: 0x00055364
		public RMCWnd() : this(false)
		{
		}

		// Token: 0x060001B6 RID: 438 RVA: 0x00057178 File Offset: 0x00055378
		public RMCWnd(bool isMockVersion)
		{
			this.InitializeComponent();
			this._isMockVersion = isMockVersion;
			RMCExportInterface.GetInstance().ImportDeviceEvtHandler += this.ExportInterfaceForCPS_ImportDeviceEvtHandler;
			RMCExportInterface.GetInstance().ParseAchiveEvtHandler += this.ExportInterfaceForCPS_ParseAchiveEvtHandler;
			RMCExportInterface.GetInstance().EditTemplateEvtHandler += this.ExportInterfaceForCPS_ExportEditCodeplugEvtHandler;
			RMCExportInterface.GetInstance().ImportTemplateEvtHandler += this.RMCWnd_ImportTemplateEvtHandler;
			RMCExportInterface.GetInstance().ExportDeviceEvtHandler += this.RMCWnd_ExportDeviceEvtHandler;
			RMCExportInterface.GetInstance().ExportDVRSEvtHandler += this.RMCWnd_ExportDVRSEvtHandler;
			RMCExportInterface.GetInstance().AstroUpgradeCodeplugEvtHandler += this.RMCWnd_AstroUpgradeCodeplugEvtHandler;
			RMCExportInterface.GetInstance().AstroCheckHoptionEnableEvtHandler += this.RMCWnd_AstroCheckHoptionEnableEvtHandler;
			RMCExportInterface.GetInstance().AstroCheckIsConvOnlyEvtHandler += this.RMCWnd_AstroCheckIsConvOnlyEvtHandler;
			RMCExportInterface.GetInstance().AnalysisPackageEvtHandler += this.RMCWnd_AnalysisPackageEvtHandler;
			RMCExportInterface.GetInstance().LanguagePackInfosEvtHandler += this.RMCWnd_LanguagePackInfosEvtHandler;
			RMCExportInterface.GetInstance().AstroDecodeLangageIndexToLpIDEvtHandler += this.RMCWnd_AstroDecodeLangageIndexToLpIDEvtHandler;
			RMCExportInterface.GetInstance().AstroLanguagePackCompatibleCheckEvtHandler += this.RMCWnd_AstroLanguagePackCompatibleCheckEvtHandler;
			RMCExportInterface.GetInstance().AstroUpgradeWithLanugagePackIsSupportedCheckEvtHandler += this.RMCWnd_AstroUpgradeWithLanugagePackIsSupportedCheckEvtHandler;
			RMCExportInterface.GetInstance().AstroUpgradeFWVerCompatibleCheckEvtHandler += this.RMCWnd_AstroUpgradeFWVerCompatibleCheckEvtHandler;
			RMCExportInterface.GetInstance().AstroDecodeFlashCodeEvtHandler += this.RMCWnd_AstroDecodeFlashCodeEvtHandler;
			RMCExportInterface.GetInstance().AstroReadFlashKeyEvtHandler += this.RMCWnd_AstroReadFlashKeyEvtHandler;
			RMCExportInterface.GetInstance().AstroDecraseFlashKeyEvtHandler += this.RMCWnd_AstroDecraseFlashKeyEvtHandler;
			RMCExportInterface.GetInstance().AstroPINPasswordConvertEventHandler += this.RMCWnd_AstroPINPasswordConvertEventHandler;
			RMCExportInterface.GetInstance().AstroValidateFlashKeyEvtHandler += this.RMCWnd_AstroValidateFlashKeyEvtHandler;
			RMCExportInterface.GetInstance().AstroReleaseFlashKeyEvtHandler += this.RMCWnd_AstroReleaseFlashKeyEvtHandler;
			RMCExportInterface.GetInstance().AstroASKRequirementEditingCheckEvtHandler += this.ExportInterfaceForCPS_AstroASKRequirementEditingCheckEvtHandler;
			RMCExportInterface.GetInstance().ASTROIndividualIdEditingCheckEvtHandler += this.ExportInterfaceForCPS_AstroIndividualIdEditingCheckEvtHandler;
			RMCExportInterface.GetInstance().AstroWritingCheckEvtHandler += this.ExportInterfaceForCPS_AstroWritingCheckEvtHandler;
			RMCExportInterface.GetInstance().AstroCompatibilityCheckEvtHandler += this.ExportInterfaceForCPS_AstroCompatibilityCheckEvtHandler;
			RMCExportInterface.GetInstance().AstroPop25EnabledEvtHandler += this.AstroPOP25EnabledCheckEvtHandler;
			RMCExportInterface.GetInstance().AstroEncodeFlashCodeEvtHandler += this.RMCWnd_AstroEncodeFlashCodeEvtHandler;
			RMCExportInterface.GetInstance().ParseFeatureCodeEvtHandler += this.RMCWnd_ParseFeatureCodeEvtHandler;
			RMCExportInterface.GetInstance().AstroParseFlashCodeEvtHandler += this.RMCWnd_AstroParseFlashCodeEvtHandler;
			RMCExportInterface.GetInstance().ParseFeatureStatusEvtHandler += this.RMCWnd_ParseFeatureStatusEvtHandler;
			RMCExportInterface.GetInstance().PopulateRadioFeaturesFromCodeplugEvtHandler += this.RMCWnd_PopulateRadioFeaturesFromCodeplugEvtHandler;
			RMCExportInterface.GetInstance().PopulateRadioFeaturesFromFlashCodeEvtHandler += this.RMCWnd_PopulateRadioFeaturesFromFlashCodeEvtHandler;
			RMCExportInterface.GetInstance().QueryUpdateRadioEvtHandler += this.RMCWnd_QueryUpdateRadioEvtHandler;
			RMCExportInterface.GetInstance().AstroCheckIsConvOnlyEvtHandler += this.RMCWnd_RadioIsConvOnlyEvtHandler;
			RMCExportInterface.GetInstance().BindingServerLanguagePackEvtHandler += this.RMCWnd_BindingServerLanguagePackEvtHandler;
			RMCExportInterface.GetInstance().IsFreonEvtHandler += this.RMCWnd_IsFreonEvtHandler;
			RMCExportInterface.GetInstance().AstroGetLoadedSysKeysEvtHandler += this.RMCWnd_AstroGetLoadedSysKeysEvtHandlerEvtHandler;
			this._firmwareFileValidator = new FirmwareFileValidator(new IOCompressionHelper());
			if (Thread.CurrentThread.CurrentUICulture.TextInfo.IsRightToLeft)
			{
				base.FlowDirection = FlowDirection.RightToLeft;
				return;
			}
			base.FlowDirection = FlowDirection.LeftToRight;
		}

		// Token: 0x060001B7 RID: 439 RVA: 0x00057500 File Offset: 0x00055700
		private void RMCWnd_IsFreonEvtHandler(object sender, IsFreonEventArgs e)
		{
			short num = (short)225640448;
			int num2 = (int)((IntPtr)num);
			for (;;)
			{
				List<string>.Enumerator enumerator;
				string b;
				switch (num2)
				{
				case 0:
					switch (0)
					{
					case 0:
						goto IL_30;
					}
					continue;
				case 1:
					try
					{
						num = (short)1462829059;
						num2 = (int)((IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								if (!enumerator.MoveNext())
								{
									num = (short)929103878;
									num2 = (int)((IntPtr)num);
									continue;
								}
								num = (short)1805451265;
								num2 = (int)((IntPtr)num);
								continue;
							case 1:
								if (enumerator.Current == b)
								{
									num = (short)1207435266;
									num2 = (int)((IntPtr)num);
									continue;
								}
								break;
							case 2:
								e.IsFreon = true;
								num = (short)1108934660;
								num2 = (int)((IntPtr)num);
								continue;
							case 3:
								switch (0)
								{
								case 0:
									goto IL_113;
								}
								continue;
							case 4:
								goto IL_1A7;
							case 5:
								goto IL_1C4;
							case 6:
								num = (short)683671557;
								num2 = (int)((IntPtr)num);
								continue;
							}
							IL_150:
							num = (short)1588199424;
							num2 = (int)((IntPtr)num);
							continue;
							IL_113:
							goto IL_150;
						}
						IL_1A7:
						IL_1C4:
						return;
					}
					finally
					{
						num = (short)797048833;
						if (num != 0)
						{
						}
						((IDisposable)enumerator).Dispose();
					}
					goto IL_1FB;
				case 2:
					goto IL_CE;
				}
				IL_30:
				if (string.IsNullOrEmpty(e.ModelNumber))
				{
					num = (short)1619897618;
					short num3 = num;
					num = (short)1137618194;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_238;
					default:
					{
						num = (short)1350500352;
						short num4 = num;
						num = (short)1745682432;
						if (num != 0)
						{
						}
						num = (short)1473773570;
						num2 = (int)((IntPtr)num);
						continue;
					}
					}
				}
				IL_1FB:
				b = e.ModelNumber.ToUpper().Trim();
				enumerator = MTFAliasList.Instance.GetFreonModelNumber().GetEnumerator();
				num = (short)158400513;
				num2 = (int)((IntPtr)num);
			}
			IL_CE:
			IL_238:
			e.IsFreon = false;
		}

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x060001B8 RID: 440 RVA: 0x00057760 File Offset: 0x00055960
		internal RadioManagementControl RadioManagementControl
		{
			get
			{
				short num = (short)1333436737;
				short num2 = num;
				num = (short)1859428673;
				switch (num2 == num)
				{
				default:
				{
					num = (short)65929216;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)886374400;
				if (num != 0)
				{
				}
				num = (short)1881735169;
				if (num != 0)
				{
				}
				return this.ctcRadioManagementControl.Content as RadioManagementControl;
			}
		}

		// Token: 0x060001B9 RID: 441 RVA: 0x00057818 File Offset: 0x00055A18
		private void RMCWnd_ImportTemplateEvtHandler(object sender, OpenFileEventArgs e)
		{
			int a_ = 14;
			short num = (short)1300103168;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_54;
				}
				ApplicationMode CPSMode;
				for (;;)
				{
					IL_31:
					switch (num2)
					{
					case 0:
					{
						WindowMain windowMain;
						if (windowMain.CanOpenCpgFlag)
						{
							num = (short)1994129414;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_E1;
					}
					case 1:
						goto IL_B7;
					case 2:
						try
						{
							switch (0)
							{
							case 0:
								goto IL_1BC;
							}
							string text;
							for (;;)
							{
								IL_185:
								string password;
								switch (num2)
								{
								case 0:
									text = text.Remove(250) + FixedLengthStream.b("샭鷯釱", a_);
									num = (short)2041774085;
									num2 = (int)((IntPtr)num);
									continue;
								case 1:
								{
									WindowMain windowMain;
									if (windowMain.OpenCodeplugNonGUI(text, password, true, e.IgnorePassword))
									{
										num = (short)240451595;
										num2 = (int)((IntPtr)num);
										continue;
									}
									goto IL_3C4;
								}
								case 2:
									goto IL_3C4;
								case 3:
									File.SetAttributes(text, FileAttributes.Normal);
									File.Delete(text);
									num = (short)1254359044;
									num2 = (int)((IntPtr)num);
									continue;
								case 4:
									goto IL_2CC;
								case 5:
									goto IL_28D;
								case 6:
									if (File.Exists(text))
									{
										num = (short)668729347;
										num2 = (int)((IntPtr)num);
										continue;
									}
									goto IL_2CC;
								case 7:
									goto IL_3DE;
								case 8:
									if (text.Length >= 260)
									{
										num = (short)387186688;
										num2 = (int)((IntPtr)num);
										continue;
									}
									goto IL_28D;
								case 9:
								{
									WindowMain windowMain;
									windowMain.OnAppMenuSaveAsNonGUI(this, null, text);
									APXTemplate apxtemplate;
									CommonUtility.PopulateTemplateColumnsFromDatabaseLayer(apxtemplate);
									VAHelper.AttachVoiceAnnouncemnetReference(apxtemplate);
									CACertificatesHelper.AttachCACertificateReference(apxtemplate);
									DVRSFilesHelper.AttachDVRSFileReference(apxtemplate);
									LanguagePackHelper.AttachLanguagePackagesReference(apxtemplate);
									e.ImportingTemplate = apxtemplate;
									num = (short)1669267458;
									num2 = (int)((IntPtr)num);
									continue;
								}
								case 10:
								{
									WindowMain windowMain;
									if (!windowMain.PromptQuitOnInvalids().Result)
									{
										num = (short)378798089;
										num2 = (int)((IntPtr)num);
										continue;
									}
									goto IL_219;
								}
								case 11:
									num = (short)1733230602;
									num2 = (int)((IntPtr)num);
									continue;
								}
								goto IL_1BC;
								IL_28D:
								num = (short)1281294342;
								num2 = (int)((IntPtr)num);
								continue;
								IL_2CC:
								File.Copy(e.FilePath, text);
								File.SetAttributes(text, FileAttributes.Normal);
								string empty = string.Empty;
								password = e.Password;
								num = (short)923271169;
								num2 = (int)((IntPtr)num);
								continue;
								IL_3C4:
								num = (short)1297874951;
								num2 = (int)((IntPtr)num);
							}
							IL_219:
							throw new CommonException(new CommonExceptionData(CommonErrorCode.RMC_The_codeplug_contains_invalid_fields));
							IL_3DE:
							return;
							IL_1BC:
							this._isOpenCodeplug = true;
							text = Path.GetTempPath() + Path.GetFileName(e.FilePath);
							num = (short)59047944;
							num2 = (int)((IntPtr)num);
							goto IL_185;
						}
						catch (PathTooLongException)
						{
							throw new CommonException(CommonErrorCode.RMC_FilePathTooLong_Error);
						}
						catch (IOException)
						{
							throw new CommonException(new CommonExceptionData(CommonErrorCode.RMC_UnableToReadTheFollowingArchive, new string[]
							{
								e.FilePath
							}));
						}
						catch (CommonException)
						{
							throw;
						}
						catch (Exception)
						{
							throw new CommonException(new CommonExceptionData(CommonErrorCode.RMC_ImportCodeplug_Error));
						}
						finally
						{
							num = (short)1144651777;
							num2 = (int)((IntPtr)num);
							for (;;)
							{
								WindowMain windowMain;
								switch (num2)
								{
								case 0:
								{
									num = (short)1291114734;
									short num3 = num;
									num = (short)2545902;
									switch ((num3 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										goto IL_478;
									default:
										goto IL_4C3;
									}
									break;
								}
								case 1:
									switch (0)
									{
									case 0:
										goto IL_459;
									}
									continue;
								case 2:
									windowMain.CloseFileNonGUI(false);
									num = (short)766902275;
									num2 = (int)((IntPtr)num);
									continue;
								case 3:
									goto IL_478;
								}
								IL_459:
								if (windowMain.CanOpenCpgFlag)
								{
									num = (short)1212350466;
									num2 = (int)((IntPtr)num);
									continue;
								}
								IL_478:
								num = (short)1487470592;
								num2 = (int)((IntPtr)num);
							}
							IL_4C3:
							num = (short)2019229696;
							if (num != 0)
							{
							}
							try
							{
								num = (short)1665728513;
								num2 = (int)((IntPtr)num);
								for (;;)
								{
									string text;
									switch (num2)
									{
									case 0:
										goto IL_57E;
									case 1:
										switch (0)
										{
										case 0:
											goto IL_536;
										}
										continue;
									case 2:
										File.SetAttributes(text, FileAttributes.Normal);
										File.Delete(text);
										num = (short)1279852544;
										num2 = (int)((IntPtr)num);
										continue;
									case 3:
										goto IL_593;
									}
									IL_536:
									if (File.Exists(text))
									{
										num = (short)242417666;
										num2 = (int)((IntPtr)num);
										continue;
									}
									IL_57E:
									num = (short)2686979;
									num2 = (int)((IntPtr)num);
								}
								IL_593:;
							}
							catch
							{
							}
							base.Dispatcher.Invoke(delegate()
							{
								short num5 = (short)1487273984;
								short num6 = num5;
								num5 = (short)261324303;
								short num7 = num5;
								num5 = (short)255622671;
								switch (num7 == num5)
								{
								}
								num5 = (short)389349376;
								if (num5 != 0)
								{
								}
								num5 = (short)1737162753;
								if (num5 != 0)
								{
								}
								AppInfoManager.AppMode = CPSMode;
							});
							this._isOpenCodeplug = false;
						}
						goto IL_5B7;
					case 3:
					{
						if (this._isOpenCodeplug)
						{
							num = (short)448921601;
							num2 = (int)((IntPtr)num);
							continue;
						}
						CPSMode = AppInfoManager.AppMode;
						APXTemplate apxtemplate = new APXTemplate();
						WindowMain windowMain = this.GetWindowMain();
						num = (short)2121531392;
						num2 = (int)((IntPtr)num);
						continue;
					}
					case 4:
					{
						WindowMain windowMain;
						if (windowMain.ReadWriteInProgress)
						{
							num = (short)727384069;
							num2 = (int)((IntPtr)num);
							continue;
						}
						string text = string.Empty;
						num = (short)1492058114;
						num2 = (int)((IntPtr)num);
						continue;
					}
					case 5:
						goto IL_5F5;
					case 6:
					{
						num = (short)1854865408;
						short num4 = num;
						goto IL_5B7;
					}
					}
					goto IL_54;
					IL_5B7:
					num = (short)1506148356;
					num2 = (int)((IntPtr)num);
				}
				IL_B7:
				throw new CommonException(CommonErrorCode.RMC_HasCodeplugOpened);
				IL_E1:
				throw new CommonException(new CommonExceptionData(CommonErrorCode.RMC_HasCodeplugOpened));
				IL_5F5:
				goto IL_E1;
				IL_54:
				num = (short)1442119681;
				if (num != 0)
				{
				}
				num = (short)540868611;
				num2 = (int)((IntPtr)num);
				goto IL_31;
			}
			}
		}

		// Token: 0x060001BA RID: 442 RVA: 0x00057EB4 File Offset: 0x000560B4
		public bool Connect()
		{
			int a_ = 5;
			switch (0)
			{
			case 0:
				goto IL_45;
			}
			int num;
			short num2;
			RadioManagementControl radioManagementControl;
			for (;;)
			{
				IL_13:
				switch (num)
				{
				case 0:
				{
					if (this.ctcRadioManagementControl.Content != null)
					{
						num2 = (short)1654390790;
						num = (int)((IntPtr)num2);
						continue;
					}
					new WindowInteropHelper(this);
					string logOutputDir = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData), FixedLengthStream.b("꣤裦鷨蓪鿬胮鷰鋲꧴듶雸雺郼郾漀䀂唄吆唈夊䀌䰎䴐弒稔瀖", a_));
					CommonLicenseInterface.InitializeLicensing(HostID.getNewHostID(FixedLengthStream.b("럤ꫦꫨ", a_)), commonLicensing.ApplicationType.RMC, logOutputDir, false);
					num2 = (short)1312096263;
					num = (int)((IntPtr)num2);
					continue;
				}
				case 1:
					if (!base.IsVisible)
					{
						num2 = (short)680525832;
						num = (int)((IntPtr)num2);
						continue;
					}
					goto IL_315;
				case 2:
				{
					num2 = (short)516093822;
					short num3 = num2;
					num2 = (short)1237645182;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_25D;
					default:
						num2 = (short)1194721280;
						if (num2 != 0)
						{
						}
						if (RuntimeInfo.IsConnected)
						{
							num2 = (short)1912340485;
							num = (int)((IntPtr)num2);
							continue;
						}
						return false;
					}
					break;
				}
				case 3:
				{
					base.Show();
					Cursor overrideCursor = Mouse.OverrideCursor;
					Mouse.OverrideCursor = Cursors.Wait;
					num2 = (short)1182662665;
					num = (int)((IntPtr)num2);
					continue;
				}
				case 4:
					if (RuntimeInfo.IsConnected)
					{
						num2 = (short)354025475;
						num = (int)((IntPtr)num2);
						continue;
					}
					radioManagementControl.HandleConnectResults();
					num2 = (short)1415446530;
					num = (int)((IntPtr)num2);
					continue;
				case 5:
					goto IL_139;
				case 6:
					goto IL_25D;
				case 7:
					if (RadioManagementBootstrapper.Launch(this.ctcRadioManagementControl, FixedLengthStream.b("ꓤ듦뷨맪ꋬ곮ꇰꃲꫴꗶ듸꣺룼귾圀䘂圄堆嬈䘊", a_)))
					{
						num2 = (short)1144193034;
						num = (int)((IntPtr)num2);
						continue;
					}
					return false;
				case 8:
					num2 = (short)961740801;
					if (num2 != 0)
					{
					}
					RuntimeInfo.ConnectionFailureReason = ConnectionFailureReasonID.None;
					RadioManagementBootstrapper.Connect();
					num2 = (short)1573584896;
					num = (int)((IntPtr)num2);
					continue;
				case 9:
					goto IL_193;
				case 10:
					goto IL_2EB;
				}
				goto IL_45;
				IL_25D:
				radioManagementControl = (this.ctcRadioManagementControl.Content as RadioManagementControl);
				num2 = (short)1473839108;
				num = (int)((IntPtr)num2);
			}
			return false;
			IL_139:
			num2 = (short)1372651520;
			short num4 = num2;
			base.Show();
			base.Activate();
			radioManagementControl.Refresh();
			return true;
			IL_193:
			try
			{
				Motorola.CommonCPS.RadioManagement.CommonBase.Global.RMCWindow = this;
				base.Activate();
				base.Focus();
				radioManagementControl.Refresh();
				return true;
			}
			finally
			{
				Cursor overrideCursor;
				Mouse.OverrideCursor = overrideCursor;
			}
			goto IL_315;
			IL_2EB:
			Motorola.CommonCPS.RadioManagement.CommonBase.Global.RMCWindow = this;
			base.Show();
			base.Activate();
			return true;
			IL_315:
			base.Activate();
			base.Focus();
			return true;
			IL_45:
			RuntimeInfo.ModeIdentifier = ModeIdentifier.Template;
			RuntimeInfo.ProductFamily = Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily.APX;
			num2 = (short)646447105;
			num = (int)((IntPtr)num2);
			goto IL_13;
		}

		// Token: 0x060001BB RID: 443 RVA: 0x000581F8 File Offset: 0x000563F8
		private void RMCWnd_ExportDeviceEvtHandler(object sender, ExportDeviceEventArgs e)
		{
			short num;
			for (;;)
			{
				IL_00:
				num = (short)416808960;
				short num2 = num;
				num = (short)790364161;
				int num3 = (int)((IntPtr)num);
				for (;;)
				{
					switch (num3)
					{
					case 0:
						goto IL_7A;
					case 1:
						switch (0)
						{
						case 0:
							goto IL_5A;
						}
						continue;
					case 2:
						try
						{
							switch (0)
							{
							case 0:
								goto IL_EC;
							}
							for (;;)
							{
								IL_B2:
								switch (num3)
								{
								case 0:
									if (e.ExportFileType == FileType.PbaFile)
									{
										num = (short)1047330823;
										num3 = (int)((IntPtr)num);
										continue;
									}
									num = (short)1334837249;
									num3 = (int)((IntPtr)num);
									continue;
								case 1:
									if (e.ExportFileType == FileType.CpdFile)
									{
										num = (short)1373437958;
										num3 = (int)((IntPtr)num);
										continue;
									}
									goto IL_292;
								case 2:
									goto IL_18D;
								case 3:
								{
									if (AppInfoManager.AppMode == ApplicationMode.CustomViewConfigurationMode)
									{
										num = (short)1547108362;
										num3 = (int)((IntPtr)num);
										continue;
									}
									WindowMain windowMain = this.GetWindowMain();
									num = (short)2089615365;
									num3 = (int)((IntPtr)num);
									continue;
								}
								case 4:
									num = (short)1255342088;
									num3 = (int)((IntPtr)num);
									continue;
								case 5:
								{
									WindowMain windowMain;
									if (!windowMain.ReadWriteInProgress)
									{
										num = (short)1865089028;
										num3 = (int)((IntPtr)num);
										continue;
									}
									goto IL_1B6;
								}
								case 6:
								{
									WindowMain windowMain;
									this.ExportCpsFile(e, windowMain);
									num = (short)71041035;
									num3 = (int)((IntPtr)num);
									continue;
								}
								case 7:
								{
									WindowMain windowMain;
									this.ExportPbaFile(e, windowMain);
									num = (short)1263599618;
									num3 = (int)((IntPtr)num);
									continue;
								}
								case 8:
								{
									WindowMain windowMain;
									if (windowMain.CpgOpenFlag)
									{
										num = (short)1605828617;
										num3 = (int)((IntPtr)num);
										continue;
									}
									num = (short)198311936;
									num3 = (int)((IntPtr)num);
									continue;
								}
								case 9:
									goto IL_28D;
								case 10:
									goto IL_125;
								case 11:
									goto IL_292;
								case 12:
									goto IL_2AA;
								}
								goto IL_EC;
								IL_292:
								num = (short)244383756;
								num3 = (int)((IntPtr)num);
							}
							IL_125:
							throw CommonExceptionHelper.CreateCommonException(CommonErrorCode.RMC_HasCustomViewSelected, Motorola.CommonCPS.ResourceRepository.Resources.RMC_HasCustomViewSelected, null);
							IL_18D:
							return;
							IL_1B6:
							throw CommonExceptionHelper.CreateCommonException(CommonErrorCode.RMC_HasCodeplugOpened, Motorola.CommonCPS.ResourceRepository.Resources.RMC_HasCodeplugOpened, null);
							IL_28D:
							goto IL_1B6;
							IL_2AA:
							return;
							IL_EC:
							this._isOpenCodeplug = true;
							num = (short)915734531;
							num3 = (int)((IntPtr)num);
							goto IL_B2;
						}
						finally
						{
							this._isOpenCodeplug = false;
						}
						goto IL_2B4;
					}
					IL_5A:
					if (this._isOpenCodeplug)
					{
						num = (short)657719296;
						num3 = (int)((IntPtr)num);
						continue;
					}
					IL_2B4:
					num = (short)2094287027;
					short num4 = num;
					num = (short)1898072243;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_00;
					default:
						num = (short)691798016;
						if (num != 0)
						{
						}
						num = (short)2109472770;
						num3 = (int)((IntPtr)num);
						break;
					}
				}
			}
			IL_7A:
			num = (short)865009665;
			if (num != 0)
			{
			}
			throw new CommonException(CommonErrorCode.RMC_HasCodeplugOpened);
		}

		// Token: 0x060001BC RID: 444 RVA: 0x0005854C File Offset: 0x0005674C
		private void ExportPbaFile(ExportDeviceEventArgs e, WindowMain winMain)
		{
			int a_ = 19;
			short num;
			for (;;)
			{
				num = (short)1252524032;
				switch (num)
				{
				default:
				{
					num = (short)620478023;
					short num2 = num;
					num = (short)2009382471;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						goto IL_5D;
					}
					break;
				}
				}
			}
			IL_5D:
			num = (short)991756288;
			short num3 = num;
			num = (short)769458177;
			if (num != 0)
			{
			}
			num = (short)1481113600;
			if (num != 0)
			{
			}
			try
			{
				num = (short)546373635;
				int num4 = (int)((IntPtr)num);
				for (;;)
				{
					AstroDeviceInfo deviceInfo;
					switch (num4)
					{
					case 0:
						this.UpdateDeviceInfo(deviceInfo, e.FirmwareVersion);
						num = (short)1385234436;
						num4 = (int)((IntPtr)num);
						continue;
					case 1:
						if (!e.IsForRestore)
						{
							num = (short)524419072;
							num4 = (int)((IntPtr)num);
							continue;
						}
						goto IL_1EA;
					case 2:
						goto IL_148;
					case 3:
						switch (0)
						{
						case 0:
							goto IL_121;
						}
						continue;
					case 4:
						goto IL_1EA;
					case 5:
						goto IL_230;
					}
					IL_121:
					if (!CombineTool.IsPbaPlus_enhanced(e.FileContent))
					{
						num = (short)1175322626;
						num4 = (int)((IntPtr)num);
						continue;
					}
					List<byte[]> list = CombineTool.Decode(e.FileContent);
					deviceInfo = (AstroDeviceInfo)CombineTool.ByteArrayToObject(list[1]);
					num = (short)1493696513;
					num4 = (int)((IntPtr)num);
					continue;
					IL_1EA:
					this.RunActionOnTempFile(FixedLengthStream.b("诲藴闶飸", a_), list[0], winMain, delegate
					{
						short num5 = (short)760152064;
						short num6 = num5;
						num5 = (short)1854524412;
						short num7 = num5;
						num5 = (short)1185467388;
						switch (num7 == num5)
						{
						}
						num5 = (short)1784414209;
						if (num5 != 0)
						{
						}
						num5 = (short)1646329856;
						if (num5 != 0)
						{
						}
						winMain.OnAppMenuSaveAsNonGUI(this, null, e.FilePathName);
					}, deviceInfo);
					num = (short)993787909;
					num4 = (int)((IntPtr)num);
				}
				IL_148:
				throw CommonExceptionHelper.CreateCommonException(CommonErrorCode.RMC_ExportCodeplug_Error, Motorola.CommonCPS.ResourceRepository.Resources.RMC_ExportCodeplug_Error, null);
				IL_230:;
			}
			catch (Exception ex)
			{
				throw CommonExceptionHelper.CreateCommonException(CommonErrorCode.GenericError, Motorola.CommonCPS.ResourceRepository.Resources.GenericError, ex);
			}
		}

		// Token: 0x060001BD RID: 445 RVA: 0x000587B8 File Offset: 0x000569B8
		private void ExportCpsFile(ExportDeviceEventArgs e, WindowMain winMain)
		{
			short num = (short)248085016;
			short num2 = num;
			num = (short)1120369176;
			switch (num2 == num)
			{
			}
			num = (short)355467264;
			short num3 = num;
			num = (short)192086016;
			if (num != 0)
			{
			}
			num = (short)1589837825;
			if (num != 0)
			{
			}
			this.RunActionOnSavedFile(e.FilePathName, e.FileContent, winMain, delegate
			{
				short num4 = (short)1722941440;
				short num5 = num4;
				num4 = (short)1923175036;
				short num6 = num4;
				num4 = (short)258888316;
				switch (num6 == num4)
				{
				}
				num4 = (short)1598816257;
				if (num4 != 0)
				{
				}
				num4 = (short)1425604608;
				if (num4 != 0)
				{
				}
				winMain.UpdateFieldsWithServerValues((APXRadio)e.ExportRadio, true);
				winMain.OnAppMenuSaveAsNonGUI(this, null, e.FilePathName);
			}, null);
		}

		// Token: 0x060001BE RID: 446 RVA: 0x000588AC File Offset: 0x00056AAC
		private void UpdateDeviceInfo(AstroDeviceInfo deviceInfo, string firmwareVersion)
		{
			short num = (short)213581825;
			int num2 = (int)((IntPtr)num);
			for (;;)
			{
				num = (short)1443037184;
				short num3 = num;
				switch (num2)
				{
				case 0:
				{
					num = (short)111368047;
					short num4 = num;
					num = (short)187914095;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						continue;
					default:
						num = (short)2061697024;
						if (num != 0)
						{
						}
						this.ResetSoftwareVersionInDeviceInfo(deviceInfo, firmwareVersion);
						num = (short)355074049;
						if (num != 0)
						{
						}
						num = (short)39649282;
						num2 = (int)((IntPtr)num);
						continue;
					}
					break;
				}
				case 1:
					switch (0)
					{
					case 0:
						goto IL_5B;
					}
					continue;
				case 2:
					return;
				}
				IL_5B:
				if (deviceInfo.SoftwareVersion.Equals(firmwareVersion))
				{
					break;
				}
				num = (short)1118830592;
				num2 = (int)((IntPtr)num);
			}
		}

		// Token: 0x060001BF RID: 447 RVA: 0x000589D4 File Offset: 0x00056BD4
		private void ResetSoftwareVersionInDeviceInfo(AstroDeviceInfo deviceInfo, string softwareVersion)
		{
			short num = (short)1305361296;
			short num2 = num;
			num = (short)757218192;
			switch (num2 == num)
			{
			}
			num = (short)1895366656;
			short num3 = num;
			num = (short)1450442753;
			if (num != 0)
			{
			}
			num = (short)983695360;
			if (num != 0)
			{
			}
			deviceInfo.SoftwareVersion = softwareVersion;
			deviceInfo.DspVersion = AcgResources.ID_NA;
			deviceInfo.PsdtVersion = AcgResources.ID_NA;
			deviceInfo.TuneVersion = AcgResources.ID_NA;
			deviceInfo.BootloaderVersion = AcgResources.ID_NA;
			deviceInfo.MaceFlashVersion = this.ResetDeviceInfoField(deviceInfo.MaceFlashVersion);
			deviceInfo.MaceSecureHardwareVersion = this.ResetDeviceInfoField(deviceInfo.MaceSecureHardwareVersion);
			deviceInfo.MaceSecureHardwareType = this.ResetDeviceInfoField(deviceInfo.MaceSecureHardwareType);
			deviceInfo.OptionBoardHardwareHostVersion = this.ResetDeviceInfoField(deviceInfo.OptionBoardHardwareHostVersion);
			deviceInfo.OptionBoardHardwareType = this.ResetDeviceInfoField(deviceInfo.OptionBoardHardwareType);
			deviceInfo.OptionBoardName = this.ResetDeviceInfoField(deviceInfo.OptionBoardName);
		}

		// Token: 0x060001C0 RID: 448 RVA: 0x00058B1C File Offset: 0x00056D1C
		private string ResetDeviceInfoField(string value)
		{
			while (string.IsNullOrEmpty(value))
			{
				short num = (short)1361586120;
				short num2 = num;
				num = (short)1260464072;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)1295187969;
					if (num != 0)
					{
					}
					num = (short)1817772032;
					if (num != 0)
					{
					}
					num = (short)2098462720;
					short num3 = num;
					return value;
				}
				}
			}
			return AcgResources.ID_NA;
		}

		// Token: 0x060001C1 RID: 449 RVA: 0x00058BDC File Offset: 0x00056DDC
		private void RMCWnd_ExportDVRSEvtHandler(object sender, ExportDVRSEventArgs e)
		{
			int a_ = 6;
			short num = (short)23578342;
			short num2 = num;
			num = (short)582862566;
			int num3;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_E3:
				num = (short)906821639;
				num3 = (int)((IntPtr)num);
				break;
			default:
				num = (short)1317797888;
				if (num != 0)
				{
				}
				switch (0)
				{
				case 0:
					goto IL_B5;
				}
				break;
			}
			WindowMain winMain;
			string archiveFileName;
			for (;;)
			{
				IL_5F:
				num = (short)47841281;
				if (num != 0)
				{
				}
				switch (num3)
				{
				case 0:
					if (!winMain.ReadWriteInProgress)
					{
						num = (short)472514564;
						num3 = (int)((IntPtr)num);
						continue;
					}
					goto IL_2F8;
				case 1:
					goto IL_161;
				case 2:
				{
					num = (short)367984640;
					short num4 = num;
					goto IL_FF;
				}
				case 3:
					if (winMain.CpgOpenFlag)
					{
						num = (short)800522249;
						num3 = (int)((IntPtr)num);
						continue;
					}
					num = (short)1989541894;
					num3 = (int)((IntPtr)num);
					continue;
				case 4:
					num = (short)49545219;
					num3 = (int)((IntPtr)num);
					continue;
				case 5:
					if (AppInfoManager.AppMode == ApplicationMode.CustomViewConfigurationMode)
					{
						goto IL_E3;
					}
					winMain = this.GetWindowMain();
					num = (short)680787968;
					num3 = (int)((IntPtr)num);
					continue;
				case 6:
					if (File.Exists(e.FilePathName))
					{
						num = (short)1155596296;
						num3 = (int)((IntPtr)num);
						continue;
					}
					goto IL_FF;
				case 7:
					goto IL_FA;
				case 8:
					File.Delete(e.FilePathName);
					num = (short)311492610;
					num3 = (int)((IntPtr)num);
					continue;
				case 9:
					goto IL_34B;
				}
				goto IL_B5;
				IL_FF:
				archiveFileName = e.FilePathName.Replace(FixedLengthStream.b("죥郧蟩胫", a_), FixedLengthStream.b("맥郧蟩胫샭鷯釱", a_));
				this.SaveCpsFile(archiveFileName, e.FileContent);
				num = (short)547487745;
				num3 = (int)((IntPtr)num);
			}
			IL_FA:
			goto IL_291;
			IL_161:
			try
			{
				base.Dispatcher.Invoke(delegate()
				{
					short num5 = (short)660013056;
					short num6 = num5;
					num5 = (short)2093281869;
					short num7 = num5;
					num5 = (short)1208939085;
					switch (num7 == num5)
					{
					}
					num5 = (short)407764993;
					if (num5 != 0)
					{
					}
					num5 = (short)420806656;
					if (num5 != 0)
					{
					}
					winMain.ExportDVRSFromRMC(archiveFileName, e.FilePathName);
				});
				return;
			}
			finally
			{
				num = (short)231669761;
				num3 = (int)((IntPtr)num);
				for (;;)
				{
					switch (num3)
					{
					case 0:
						File.Delete(archiveFileName);
						num = (short)295829506;
						num3 = (int)((IntPtr)num);
						continue;
					case 1:
						switch (0)
						{
						case 0:
							goto IL_24B;
						}
						continue;
					case 2:
						goto IL_28E;
					}
					IL_24B:
					if (!File.Exists(archiveFileName))
					{
						break;
					}
					num = (short)1644888064;
					num3 = (int)((IntPtr)num);
				}
				IL_28E:;
			}
			IL_291:
			throw CommonExceptionHelper.CreateCommonException(CommonErrorCode.RMC_HasCustomViewSelected, Motorola.CommonCPS.ResourceRepository.Resources.RMC_HasCustomViewSelected, null);
			IL_2F8:
			throw CommonExceptionHelper.CreateCommonException(CommonErrorCode.RMC_HasCodeplugOpened, Motorola.CommonCPS.ResourceRepository.Resources.RMC_HasCodeplugOpened, null);
			IL_34B:
			goto IL_2F8;
			IL_B5:
			num = (short)1474691077;
			num3 = (int)((IntPtr)num);
			goto IL_5F;
		}

		// Token: 0x060001C2 RID: 450 RVA: 0x00058F48 File Offset: 0x00057148
		private void RMCWindow_Loaded(object sender, RoutedEventArgs e)
		{
			short num = (short)2061771366;
			short num2 = num;
			num = (short)240853606;
			switch (num2 == num)
			{
			}
			num = (short)1350500352;
			short num3 = num;
			num = (short)491388929;
			if (num != 0)
			{
			}
			num = (short)530317312;
			if (num != 0)
			{
			}
		}

		// Token: 0x060001C3 RID: 451 RVA: 0x00058FF4 File Offset: 0x000571F4
		private void ExportInterfaceForCPS_AstroASKRequirementEditingCheckEvtHandler(object sender, AstroASKRequirementEventArgs e)
		{
			short num = (short)507835621;
			short num2 = num;
			num = (short)609678565;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)1910243328;
				short num3 = num;
				num = (short)547487744;
				if (num != 0)
				{
				}
				string message = null;
				try
				{
					num = (short)2047475713;
					int num4 = (int)((IntPtr)num);
					for (;;)
					{
						switch (num4)
						{
						case 0:
							goto IL_D4;
						case 1:
							switch (0)
							{
							case 0:
								goto IL_AA;
							}
							continue;
						case 2:
							goto IL_11C;
						}
						IL_AA:
						if (!RMCRadioAccessValidator.AstroASKRequirementEventHandler(e.Codeplug, e.TargetModelNumber, out message))
						{
							num = (short)1713766400;
							num4 = (int)((IntPtr)num);
						}
						else
						{
							num = (short)1095565313;
							if (num != 0)
							{
							}
							num = (short)427556866;
							num4 = (int)((IntPtr)num);
						}
					}
					IL_D4:
					throw CommonExceptionHelper.CreateDirectMessageCommonException(message);
					IL_11C:;
				}
				catch (CommonException)
				{
					throw;
				}
				catch (Exception ex)
				{
					throw CommonExceptionHelper.CreateCommonException(CommonErrorCode.GenericError, Motorola.CommonCPS.ResourceRepository.Resources.GenericError, ex);
				}
				break;
			}
			}
		}

		// Token: 0x060001C4 RID: 452 RVA: 0x0005914C File Offset: 0x0005734C
		private void AstroPOP25EnabledCheckEvtHandler(object sender, AstroPop25EnabledEventArgs e)
		{
			short num = (short)693633025;
			if (num != 0)
			{
			}
			num = (short)91588024;
			short num2 = num;
			num = (short)2057340344;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1404370944;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1984036864;
			if (num != 0)
			{
			}
			WindowMain windowMain = this.GetWindowMain();
			e.Pop25Enabled = (windowMain != null && windowMain.Pop25Enabled);
		}

		// Token: 0x060001C5 RID: 453 RVA: 0x00059210 File Offset: 0x00057410
		private void RMCWnd_AstroEncodeFlashCodeEvtHandler(object sender, AstroEncodeFlashCodeEventArgs e)
		{
			switch (0)
			{
			case 0:
				goto IL_38;
			}
			short num2;
			byte[] encodeFlashCode;
			for (;;)
			{
				IL_0A:
				int num;
				switch (num)
				{
				case 0:
					if (FlashcodeValidator.Validate(e.FlashCode))
					{
						num2 = (short)814678020;
						num = (int)((IntPtr)num2);
						continue;
					}
					goto IL_120;
				case 1:
					goto IL_11B;
				case 2:
					goto IL_213;
				case 3:
					if (FlashcodeValidator.ValidateOldFlashcode(e.FlashCode))
					{
						num2 = (short)155844617;
						num = (int)((IntPtr)num2);
						continue;
					}
					goto IL_1CF;
				case 4:
					SpecialFeatures.Flashport.FlashRadio.FlashcodeDecoder.Decode(e.FlashCode, ref encodeFlashCode);
					num2 = (short)1946615810;
					num = (int)((IntPtr)num2);
					continue;
				case 5:
					if (e.FlashCode.Length > 15)
					{
						num2 = (short)2126381063;
						num = (int)((IntPtr)num2);
						continue;
					}
					goto IL_120;
				case 6:
					if (e.FlashCode.Length <= 15)
					{
						num2 = (short)243859457;
						if (num2 != 0)
						{
						}
						num2 = (short)1884487688;
						num = (int)((IntPtr)num2);
						continue;
					}
					goto IL_1CF;
				case 7:
					goto IL_F1;
				case 8:
					num2 = (short)1960771587;
					num = (int)((IntPtr)num2);
					continue;
				case 9:
					SpecialFeatures.Flashport.FlashRadio.FlashcodeDecoder.DecodeOldFlashcode(e.FlashCode, ref encodeFlashCode);
					num2 = (short)1371602945;
					num = (int)((IntPtr)num2);
					continue;
				}
				goto IL_38;
				IL_120:
				num2 = (short)1629421574;
				num = (int)((IntPtr)num2);
			}
			IL_F1:
			goto IL_18E;
			IL_11B:
			goto IL_256;
			IL_1CF:
			throw CommonExceptionHelper.CreateDirectMessageCommonException(AppResources.is_an_invalid_flashcode.AcpStringFormat(new object[]
			{
				e.FlashCode
			}));
			IL_213:
			IL_256:
			e.EncodeFlashCode = encodeFlashCode;
			return;
			IL_38:
			num2 = (short)1721871839;
			short num3 = num2;
			num2 = (short)935177695;
			switch ((num3 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
			{
				IL_18E:
				num2 = (short)757989376;
				int num = (int)((IntPtr)num2);
				goto IL_0A;
			}
			default:
			{
				num2 = (short)32833536;
				if (num2 != 0)
				{
				}
				encodeFlashCode = new byte[25];
				num2 = (short)382861312;
				short num4 = num2;
				num2 = (short)943259653;
				int num = (int)((IntPtr)num2);
				goto IL_0A;
			}
			}
		}

		// Token: 0x060001C6 RID: 454 RVA: 0x0005947C File Offset: 0x0005767C
		private void RMCWnd_ParseFeatureCodeEvtHandler(object sender, ParseFeatureCodeEventArgs e)
		{
			short num;
			try
			{
				num = (short)928251904;
				int num2 = (int)num;
				switch (num2)
				{
				default:
				{
					switch (0)
					{
					case 0:
						goto IL_5E;
					}
					OptionIDs featureCode;
					bool flag2;
					for (;;)
					{
						IL_27:
						string featureNameTag;
						bool flag;
						switch (num2)
						{
						case 0:
							goto IL_620;
						case 1:
							if (string.IsNullOrEmpty(e.ModelNumber))
							{
								num = (short)20250630;
								num2 = (int)((IntPtr)num);
								continue;
							}
							goto IL_19A;
						case 2:
							goto IL_1D1;
						case 3:
							goto IL_164;
						case 4:
							if (!string.IsNullOrEmpty(e.ModelNumber))
							{
								num = (short)193200128;
								num2 = (int)((IntPtr)num);
								continue;
							}
							goto IL_164;
						case 5:
							try
							{
								FlashcodeTable flashcodeTable;
								flashcodeTable.InitTable(false, e.ModelNumber, false);
								IEnumerator<Option> enumerator = flashcodeTable.FLASHcode.GetEnumerator();
								try
								{
									num = (short)1097662464;
									num2 = (int)((IntPtr)num);
									for (;;)
									{
										switch (num2)
										{
										case 0:
											switch (0)
											{
											case 0:
												goto IL_237;
											}
											continue;
										case 1:
										{
											if (!enumerator.MoveNext())
											{
												num = (short)1072627715;
												num2 = (int)((IntPtr)num);
												continue;
											}
											Option option = enumerator.Current;
											num = (short)1761411076;
											num2 = (int)((IntPtr)num);
											continue;
										}
										case 2:
										{
											Option option;
											featureNameTag = option.Description;
											flag = true;
											num = (short)7405574;
											num2 = (int)((IntPtr)num);
											continue;
										}
										case 3:
											goto IL_2D6;
										case 4:
										{
											Option option;
											if (option.OptionID == featureCode)
											{
												num = (short)1799684098;
												num2 = (int)((IntPtr)num);
												continue;
											}
											break;
										}
										case 5:
											goto IL_2F0;
										case 6:
											goto IL_2D6;
										}
										IL_239:
										num = (short)522125313;
										num2 = (int)((IntPtr)num);
										continue;
										IL_237:
										goto IL_239;
										IL_2D6:
										num = (short)285278213;
										num2 = (int)((IntPtr)num);
									}
									IL_2F0:;
								}
								finally
								{
									num = (short)1690501120;
									num2 = (int)((IntPtr)num);
									for (;;)
									{
										switch (num2)
										{
										case 0:
											goto IL_30B;
										case 1:
										{
											enumerator.Dispose();
											num = (short)267282904;
											short num3 = num;
											num = (short)5859800;
											switch ((num3 == num) ? 1 : 0)
											{
											case 0:
											case 2:
												goto IL_30B;
											default:
												num = (short)169017344;
												if (num != 0)
												{
												}
												num = (short)1463353346;
												num2 = (int)((IntPtr)num);
												continue;
											}
											break;
										}
										case 2:
											goto IL_3B0;
										}
										goto IL_328;
										IL_30B:
										switch (0)
										{
										case 0:
											IL_328:
											if (enumerator == null)
											{
												goto IL_3B2;
											}
											num = (short)983433217;
											num2 = (int)((IntPtr)num);
											break;
										}
									}
									IL_3B0:
									IL_3B2:;
								}
								goto IL_19A;
							}
							finally
							{
								num = (short)929300480;
								num2 = (int)((IntPtr)num);
								for (;;)
								{
									FlashcodeTable flashcodeTable;
									switch (num2)
									{
									case 0:
										switch (0)
										{
										case 0:
											goto IL_3EA;
										}
										continue;
									case 1:
										((IDisposable)flashcodeTable).Dispose();
										num = (short)89980930;
										num2 = (int)((IntPtr)num);
										continue;
									case 2:
										goto IL_421;
									}
									IL_3EA:
									if (flashcodeTable == null)
									{
										break;
									}
									num = (short)2022047745;
									num2 = (int)((IntPtr)num);
								}
								IL_421:;
							}
							goto Block_6;
						case 6:
							goto IL_658;
						case 7:
							if (!flag)
							{
								num = (short)2061041666;
								num2 = (int)((IntPtr)num);
								continue;
							}
							e.FeatureNameTag = featureNameTag;
							num = (short)617021450;
							num2 = (int)((IntPtr)num);
							continue;
						case 8:
						{
							num = (short)1758986241;
							if (num != 0)
							{
							}
							FlashcodeTable flashcodeTable = new FlashcodeTable(!flag2, true);
							num = (short)1686700037;
							num2 = (int)((IntPtr)num);
							continue;
						}
						case 9:
							goto IL_424;
						case 10:
							goto IL_6DA;
						case 11:
							if (!flag)
							{
								num = (short)1957888008;
								num2 = (int)((IntPtr)num);
								continue;
							}
							goto IL_19A;
						}
						goto IL_5E;
						Block_7:
						try
						{
							IL_620:
							new ModelTiering(e.ModelNumber, ModelTiering.ActionTypes.NONE, ModelTiering.TargetTypes.ALL, false).UpdateUtilityMackModelType();
							goto IL_A3;
						}
						catch (Exception)
						{
							throw CommonExceptionHelper.CreateDirectMessageCommonException(AppResources.Invalid_radio_model_number.AcpStringFormat(new object[]
							{
								e.ModelNumber
							}));
						}
						goto IL_658;
						IL_A3:
						flag2 = UtilityMack.IsPortablePro;
						num = (short)319029251;
						num2 = (int)((IntPtr)num);
						continue;
						Block_6:
						FlashcodeTable flashcodeTable2;
						try
						{
							IL_424:
							flashcodeTable2.InitTable(false, e.ModelNumber, false);
							IEnumerator<Option> enumerator = flashcodeTable2.FLASHcode.GetEnumerator();
							try
							{
								num = (short)417923072;
								num2 = (int)((IntPtr)num);
								for (;;)
								{
									switch (num2)
									{
									case 0:
										switch (0)
										{
										case 0:
											goto IL_485;
										}
										continue;
									case 1:
									{
										Option option2;
										if (option2.OptionID == featureCode)
										{
											num = (short)592117763;
											num2 = (int)((IntPtr)num);
											continue;
										}
										break;
									}
									case 2:
										goto IL_527;
									case 3:
									{
										Option option2;
										featureNameTag = option2.Description;
										flag = true;
										num = (short)761397254;
										num2 = (int)((IntPtr)num);
										continue;
									}
									case 4:
									{
										if (!enumerator.MoveNext())
										{
											num = (short)1659437058;
											num2 = (int)((IntPtr)num);
											continue;
										}
										Option option2 = enumerator.Current;
										num = (short)855638017;
										num2 = (int)((IntPtr)num);
										continue;
									}
									case 5:
										goto IL_540;
									case 6:
										goto IL_527;
									}
									IL_4C9:
									num = (short)1875902468;
									num2 = (int)((IntPtr)num);
									continue;
									IL_485:
									goto IL_4C9;
									IL_527:
									num = (short)1117192197;
									num2 = (int)((IntPtr)num);
								}
								IL_540:;
							}
							finally
							{
								num = (short)907739136;
								num2 = (int)((IntPtr)num);
								for (;;)
								{
									switch (num2)
									{
									case 0:
										switch (0)
										{
										case 0:
											goto IL_574;
										}
										continue;
									case 1:
										enumerator.Dispose();
										num = (short)383320066;
										num2 = (int)((IntPtr)num);
										continue;
									case 2:
										goto IL_5AC;
									}
									IL_574:
									if (enumerator == null)
									{
										break;
									}
									num = (short)373817345;
									num2 = (int)((IntPtr)num);
								}
								IL_5AC:;
							}
							goto IL_120;
						}
						finally
						{
							num = (short)204800000;
							num2 = (int)((IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_5E6;
									}
									continue;
								case 1:
									((IDisposable)flashcodeTable2).Dispose();
									num = (short)1071054850;
									num2 = (int)((IntPtr)num);
									continue;
								case 2:
									goto IL_61D;
								}
								IL_5E6:
								if (flashcodeTable2 == null)
								{
									break;
								}
								num = (short)1579286529;
								num2 = (int)((IntPtr)num);
							}
							IL_61D:;
						}
						goto Block_7;
						IL_120:
						num = (short)495255553;
						num2 = (int)((IntPtr)num);
						continue;
						IL_164:
						featureCode = (OptionIDs)e.FeatureCode;
						featureNameTag = string.Empty;
						flag = false;
						flashcodeTable2 = new FlashcodeTable(flag2, true);
						num = (short)190054409;
						num2 = (int)((IntPtr)num);
						continue;
						IL_19A:
						num = (short)1667170311;
						num2 = (int)((IntPtr)num);
						continue;
						IL_658:
						num = (short)1939537931;
						num2 = (int)((IntPtr)num);
					}
					IL_1D1:
					throw CommonExceptionHelper.CreateDirectMessageCommonException(AppResources.Not_a_Valid_Option_for_Model.AcpStringFormat(new object[]
					{
						featureCode.ToString(),
						e.ModelNumber
					}));
					IL_6DA:
					break;
					IL_5E:
					flag2 = false;
					num = (short)954269700;
					num2 = (int)((IntPtr)num);
					goto IL_27;
				}
				}
			}
			catch (CommonException)
			{
				throw;
			}
			catch (Exception ex)
			{
				throw CommonExceptionHelper.CreateCommonException(CommonErrorCode.GenericError, Motorola.CommonCPS.ResourceRepository.Resources.GenericError, ex);
			}
			num = (short)610861056;
			short num4 = num;
		}

		// Token: 0x060001C7 RID: 455 RVA: 0x00059C4C File Offset: 0x00057E4C
		private void RMCWnd_ParseFeatureStatusEvtHandler(object sender, ParseFeatureStatusEventArgs e)
		{
			switch (0)
			{
			case 0:
				goto IL_24;
			}
			int num;
			FeatureStatus featureStatus;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					if (featureStatus != FeatureStatus.Active)
					{
						num2 = (short)1349124098;
						num = (int)((IntPtr)num2);
						continue;
					}
					goto IL_B0;
				case 1:
					goto IL_FC;
				case 2:
				{
					num2 = (short)729522279;
					short num3 = num2;
					num2 = (short)449421415;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_B0;
					default:
						num2 = (short)498663424;
						if (num2 != 0)
						{
						}
						num2 = (short)1736900611;
						num = (int)((IntPtr)num2);
						continue;
					}
					break;
				}
				case 3:
					if (featureStatus != FeatureStatus.PendingActive)
					{
						num2 = (short)409862148;
						num = (int)((IntPtr)num2);
						continue;
					}
					goto IL_159;
				case 4:
					num2 = (short)552206337;
					num = (int)((IntPtr)num2);
					continue;
				}
				goto IL_24;
			}
			IL_B0:
			num2 = (short)639565824;
			short num4 = num2;
			e.FeatureStatusDescription = AppResources.Purchased;
			return;
			IL_FC:
			num2 = (short)1511849985;
			if (num2 != 0)
			{
			}
			throw CommonExceptionHelper.CreateCommonException(CommonErrorCode.GenericError, Motorola.CommonCPS.ResourceRepository.Resources.GenericError, null);
			IL_159:
			e.FeatureStatusDescription = AppResources.Pending;
			return;
			IL_24:
			e.FeatureStatusDescription = "";
			featureStatus = e.FeatureStatus;
			num2 = (short)2070609920;
			num = (int)((IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x060001C8 RID: 456 RVA: 0x00059DCC File Offset: 0x00057FCC
		private void RMCWnd_AstroParseFlashCodeEvtHandler(object sender, AstroParseFlashCodeEventArgs e)
		{
			short num;
			try
			{
				num = (short)1398210560;
				int num2 = (int)num;
				switch (num2)
				{
				default:
				{
					num = (short)2034502000;
					short num3 = num;
					num = (short)202574192;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						IL_B7:
						num = (short)1144651776;
						num2 = (int)((IntPtr)num);
						break;
					default:
						num = (short)1484914689;
						if (num != 0)
						{
						}
						num = (short)1466826752;
						if (num != 0)
						{
						}
						switch (0)
						{
						case 0:
							goto IL_AF;
						}
						break;
					}
					bool isPortable;
					Dictionary<int, string> dictionary;
					for (;;)
					{
						switch (num2)
						{
						case 0:
							try
							{
								isPortable = !ModelTiering.IsModelMobileByModelNumber(e.ModelNumber);
								goto IL_30C;
							}
							catch (Exception)
							{
								throw CommonExceptionHelper.CreateDirectMessageCommonException(AppResources.Invalid_radio_model_number.AcpStringFormat(new object[]
								{
									e.ModelNumber
								}));
							}
							goto Block_3;
						case 1:
							goto IL_102;
						case 2:
							goto IL_352;
						}
						goto IL_AF;
						IL_30C:
						FlashcodeTable flashcodeTable = new FlashcodeTable(isPortable, true);
						num = (short)260898817;
						num2 = (int)((IntPtr)num);
						continue;
						Block_3:
						try
						{
							IL_102:
							flashcodeTable.InitTable(false, e.ModelNumber, false);
							IEnumerator<Option> enumerator = flashcodeTable.FLASHcode.GetEnumerator();
							try
							{
								num = (short)425656320;
								num2 = (int)((IntPtr)num);
								for (;;)
								{
									switch (num2)
									{
									case 0:
										switch (0)
										{
										case 0:
											goto IL_160;
										}
										continue;
									case 1:
									{
										if (!enumerator.MoveNext())
										{
											num = (short)2103640067;
											num2 = (int)((IntPtr)num);
											continue;
										}
										Option option = enumerator.Current;
										num = (short)1880162306;
										num2 = (int)((IntPtr)num);
										continue;
									}
									case 2:
									{
										Option option;
										if (flashcodeTable.IsOptionEnabledInFlashcode(option, e.FlashCode))
										{
											num = (short)645464070;
											num2 = (int)((IntPtr)num);
											continue;
										}
										break;
									}
									case 3:
										num = (short)36700165;
										num2 = (int)((IntPtr)num);
										continue;
									case 5:
										goto IL_22C;
									case 6:
									{
										Option option;
										dictionary.Add((int)option.OptionID, option.Description);
										num = (short)1492254724;
										num2 = (int)((IntPtr)num);
										continue;
									}
									}
									IL_162:
									num = (short)1021640705;
									num2 = (int)((IntPtr)num);
									continue;
									IL_160:
									goto IL_162;
								}
								IL_22C:;
							}
							finally
							{
								num = (short)114163712;
								num2 = (int)((IntPtr)num);
								for (;;)
								{
									switch (num2)
									{
									case 0:
										switch (0)
										{
										case 0:
											goto IL_260;
										}
										continue;
									case 1:
										enumerator.Dispose();
										num = (short)1104674818;
										num2 = (int)((IntPtr)num);
										continue;
									case 2:
										goto IL_297;
									}
									IL_260:
									if (enumerator == null)
									{
										break;
									}
									num = (short)998440961;
									num2 = (int)((IntPtr)num);
								}
								IL_297:;
							}
							goto IL_331;
						}
						finally
						{
							num = (short)747175936;
							num2 = (int)((IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_2D1;
									}
									continue;
								case 1:
									((IDisposable)flashcodeTable).Dispose();
									num = (short)673644546;
									num2 = (int)((IntPtr)num);
									continue;
								case 2:
									goto IL_309;
								}
								IL_2D1:
								if (flashcodeTable == null)
								{
									break;
								}
								num = (short)15204353;
								num2 = (int)((IntPtr)num);
							}
							IL_309:;
						}
						goto IL_30C;
						IL_331:
						e.FeatureTagNameList = dictionary;
						num = (short)652083202;
						num2 = (int)((IntPtr)num);
					}
					IL_352:
					break;
					IL_AF:
					dictionary = new Dictionary<int, string>();
					isPortable = false;
					goto IL_B7;
				}
				}
			}
			catch (CommonException)
			{
				throw;
			}
			catch (Exception)
			{
				throw CommonExceptionHelper.CreateDirectMessageCommonException(AppResources.is_an_invalid_flashcode.AcpStringFormat(new object[]
				{
					e.FlashCode
				}));
			}
			num = (short)2067005440;
			short num4 = num;
		}

		// Token: 0x060001C9 RID: 457 RVA: 0x0005A1F8 File Offset: 0x000583F8
		private void ExportInterfaceForCPS_AstroCompatibilityCheckEvtHandler(object sender, AstroCompatibilityEventArgs e)
		{
			short num;
			try
			{
				num = (short)1454637056;
				int num2 = (int)((IntPtr)num);
				string empty;
				for (;;)
				{
					num = (short)1847699177;
					short num3 = num;
					num = (short)705799913;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_101;
					default:
					{
						num = (short)299892736;
						if (num != 0)
						{
						}
						switch (num2)
						{
						case 0:
							switch (0)
							{
							case 0:
								goto IL_83;
							}
							continue;
						case 1:
							if (empty.Contains(AppResources.Unable_to_clone_due_to_the_incompatibility_between_source_and_models))
							{
								num = (short)110493699;
								num2 = (int)((IntPtr)num);
								continue;
							}
							goto IL_101;
						case 2:
							num = (short)1014366209;
							num2 = (int)((IntPtr)num);
							continue;
						case 3:
							goto IL_FF;
						case 4:
							goto IL_12D;
						}
						IL_83:
						CompatibilityChecks compatibilityChecks = new CompatibilityChecks(e.TemplateCodeplug, e.DeviceCodeplug, e.TargetModelnumber);
						empty = string.Empty;
						if (!compatibilityChecks.PerfomChecks(ref empty))
						{
							num = (short)1655308290;
							num2 = (int)((IntPtr)num);
						}
						else
						{
							num = (short)669057028;
							num2 = (int)((IntPtr)num);
						}
						break;
					}
					}
				}
				IL_FF:
				throw CommonExceptionHelper.CreateDirectMessageCommonException(empty);
				IL_101:
				throw CommonExceptionHelper.CreateCommonException(CommonErrorCode.Failure_due_to_mismatch_of_Codeplug_Used_FLASHcode_and_Radio_FLASHcode, empty, null);
				IL_12D:;
			}
			catch (CommonException)
			{
				throw;
			}
			catch (Exception ex)
			{
				throw CommonExceptionHelper.CreateCommonException(CommonErrorCode.GenericError, Motorola.CommonCPS.ResourceRepository.Resources.GenericError, ex);
			}
			num = (short)661520384;
			short num4 = num;
			num = (short)1485373441;
			if (num != 0)
			{
			}
		}

		// Token: 0x060001CA RID: 458 RVA: 0x0005A3C8 File Offset: 0x000585C8
		private void ExportInterfaceForCPS_AstroIndividualIdEditingCheckEvtHandler(object sender, ASTROIndividualIdEditingEventArgs e)
		{
			short num = (short)1254359040;
			short num2 = num;
			num = (short)329200827;
			short num3 = num;
			num = (short)181744827;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)1133182976;
				if (num != 0)
				{
				}
				string message = null;
				try
				{
					num = (short)117637120;
					int num4 = (int)((IntPtr)num);
					for (;;)
					{
						switch (num4)
						{
						case 0:
							switch (0)
							{
							case 0:
								goto IL_A9;
							}
							continue;
						case 1:
							goto IL_FF;
						case 2:
							goto IL_120;
						}
						IL_A9:
						num = (short)630718465;
						if (num != 0)
						{
						}
						if (!RMCRadioAccessValidator.AstroIndividualIdEditingEventHandler(e.ASTRORadioSystem, e.CodeplugObject, out message, e.TargetModelNumber))
						{
							num = (short)1506410497;
							num4 = (int)((IntPtr)num);
						}
						else
						{
							num = (short)1006436354;
							num4 = (int)((IntPtr)num);
						}
					}
					IL_FF:
					throw CommonExceptionHelper.CreateDirectMessageCommonException(message);
					IL_120:;
				}
				catch (CommonException)
				{
					throw;
				}
				catch (Exception ex)
				{
					throw CommonExceptionHelper.CreateCommonException(CommonErrorCode.GenericError, Motorola.CommonCPS.ResourceRepository.Resources.GenericError, ex);
				}
				break;
			}
			}
		}

		// Token: 0x060001CB RID: 459 RVA: 0x0005A524 File Offset: 0x00058724
		private void ExportInterfaceForCPS_AstroWritingCheckEvtHandler(object sender, AstroWritingEventArgs e)
		{
			short num = (short)1246756864;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_3F;
				}
				Collection<AcpASKLib.SystemKeyData> collection;
				bool? isSpecialKeyAttached2;
				string message;
				bool isUpdated;
				for (;;)
				{
					IL_28:
					IEnumerator<ISystemKeyData> enumerator;
					switch (num2)
					{
					case 0:
					{
						num = (short)967180288;
						short num3 = num;
						try
						{
							num = (short)907804676;
							num2 = (int)((IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 1:
									goto IL_4C9;
								case 2:
									num = (short)2107441153;
									num2 = (int)((IntPtr)num);
									continue;
								case 3:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)1407385602;
										num2 = (int)((IntPtr)num);
										continue;
									}
									AcpASKLib.SystemKeyData item = RMCWnd.ConvertACPKeyDataToSystemKeyData(enumerator.Current);
									collection.Add(item);
									num = (short)2058878976;
									num2 = (int)((IntPtr)num);
									continue;
								}
								case 4:
									switch (0)
									{
									case 0:
										goto IL_44B;
									}
									continue;
								}
								IL_47C:
								num = (short)980353027;
								num2 = (int)((IntPtr)num);
								continue;
								IL_44B:
								goto IL_47C;
							}
							IL_4C9:
							goto IL_3F3;
						}
						finally
						{
							num = (short)982188034;
							num2 = (int)((IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_58A;
								case 1:
									enumerator.Dispose();
									num = (short)1486946304;
									num2 = (int)((IntPtr)num);
									continue;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_500;
									}
									continue;
								}
								IL_500:
								if (enumerator == null)
								{
									break;
								}
								num = (short)703096500;
								short num4 = num;
								num = (short)1777559220;
								switch ((num4 == num) ? 1 : 0)
								{
								case 0:
								case 2:
									goto IL_58C;
								default:
									num = (short)1732837376;
									if (num != 0)
									{
									}
									num = (short)835190785;
									num2 = (int)((IntPtr)num);
									break;
								}
							}
							IL_58A:
							IL_58C:;
						}
						goto IL_58D;
					}
					case 1:
						try
						{
							switch (0)
							{
							case 0:
								goto IL_C8;
							}
							bool? isSpecialKeyAttached;
							bool flag;
							for (;;)
							{
								IL_91:
								switch (num2)
								{
								case 0:
									num = (short)1590231049;
									num2 = (int)((IntPtr)num);
									continue;
								case 1:
									goto IL_1AE;
								case 2:
									goto IL_143;
								case 3:
									goto IL_3DB;
								case 4:
									if (isSpecialKeyAttached == null)
									{
										num = (short)1225981960;
										num2 = (int)((IntPtr)num);
										continue;
									}
									goto IL_143;
								case 5:
									if (!flag)
									{
										num = (short)345243654;
										num2 = (int)((IntPtr)num);
										continue;
									}
									num = (short)1828847619;
									num2 = (int)((IntPtr)num);
									continue;
								case 6:
									goto IL_1E5;
								case 7:
								{
									ObservableCollection<ISystemKeyData> observableCollection = new ObservableCollection<ISystemKeyData>();
									IEnumerator<AcpASKLib.SystemKeyData> enumerator2 = collection.GetEnumerator();
									num = (short)528809994;
									num2 = (int)((IntPtr)num);
									continue;
								}
								case 8:
									e.IsSpecialKeyAttached = isSpecialKeyAttached2;
									num = (short)88997890;
									num2 = (int)((IntPtr)num);
									continue;
								case 9:
									if (collection != null)
									{
										num = (short)750583815;
										num2 = (int)((IntPtr)num);
										continue;
									}
									goto IL_1AE;
								case 10:
								{
									ObservableCollection<ISystemKeyData> observableCollection;
									try
									{
										num = (short)500301828;
										num2 = (int)((IntPtr)num);
										for (;;)
										{
											switch (num2)
											{
											case 0:
											{
												IEnumerator<AcpASKLib.SystemKeyData> enumerator2;
												if (!enumerator2.MoveNext())
												{
													num = (short)1245446147;
													num2 = (int)((IntPtr)num);
													continue;
												}
												ISystemKeyData item2 = RMCWnd.ACPKeyDataConvertToSystemKeyData(enumerator2.Current);
												observableCollection.Add(item2);
												num = (short)14155778;
												num2 = (int)((IntPtr)num);
												continue;
											}
											case 1:
												goto IL_32C;
											case 3:
												num = (short)1194196993;
												num2 = (int)((IntPtr)num);
												continue;
											case 4:
												switch (0)
												{
												case 0:
													goto IL_2AE;
												}
												continue;
											}
											IL_2B0:
											num = (short)1005518848;
											num2 = (int)((IntPtr)num);
											continue;
											IL_2AE:
											goto IL_2B0;
										}
										IL_32C:;
									}
									finally
									{
										num = (short)1736638466;
										num2 = (int)((IntPtr)num);
										for (;;)
										{
											IEnumerator<AcpASKLib.SystemKeyData> enumerator2;
											switch (num2)
											{
											case 0:
												goto IL_39A;
											case 1:
												enumerator2.Dispose();
												num = (short)1698889728;
												num2 = (int)((IntPtr)num);
												continue;
											case 2:
												switch (0)
												{
												case 0:
													goto IL_362;
												}
												continue;
											}
											IL_362:
											if (enumerator2 == null)
											{
												break;
											}
											num = (short)1260978177;
											num2 = (int)((IntPtr)num);
										}
										IL_39A:;
									}
									e.AttachedASKs = observableCollection;
									num = (short)1081278465;
									num2 = (int)((IntPtr)num);
									continue;
								}
								case 11:
									if (e.AttachedASKs == null)
									{
										num = (short)958988289;
										if (num != 0)
										{
										}
										num = (short)84410368;
										num2 = (int)((IntPtr)num);
										continue;
									}
									goto IL_1AE;
								}
								goto IL_C8;
								IL_143:
								num = (short)1107427339;
								num2 = (int)((IntPtr)num);
								continue;
								IL_1AE:
								num = (short)424935429;
								num2 = (int)((IntPtr)num);
							}
							IL_1E5:
							throw CommonExceptionHelper.CreateDirectMessageCommonException(message);
							IL_3DB:
							return;
							IL_C8:
							flag = RMCRadioAccessValidator.AstroWritingEventHandler(e.Device, e.TransportPreference, out isUpdated, out message, e.IsBatch, e.IsWritingProtect, e.IsRestoreJob, ref collection, ref isSpecialKeyAttached2);
							e.IsUpdated = isUpdated;
							isSpecialKeyAttached = e.IsSpecialKeyAttached;
							num = (short)1357185028;
							num2 = (int)((IntPtr)num);
							goto IL_91;
						}
						catch (CommonException)
						{
							throw;
						}
						catch (Exception ex)
						{
							throw CommonExceptionHelper.CreateCommonException(CommonErrorCode.GenericError, Motorola.CommonCPS.ResourceRepository.Resources.GenericError, ex);
						}
						goto IL_3F3;
					case 2:
						goto IL_58D;
					case 3:
						if (e.AttachedASKs != null)
						{
							num = (short)1190002690;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_3F3;
					}
					goto IL_3F;
					IL_3F3:
					num = (short)1375469569;
					num2 = (int)((IntPtr)num);
					continue;
					IL_58D:
					collection = new ObservableCollection<AcpASKLib.SystemKeyData>();
					enumerator = e.AttachedASKs.GetEnumerator();
					num = (short)1723596800;
					num2 = (int)((IntPtr)num);
				}
				return;
				IL_3F:
				isUpdated = false;
				message = null;
				collection = null;
				isSpecialKeyAttached2 = e.IsSpecialKeyAttached;
				num = (short)1905393667;
				num2 = (int)((IntPtr)num);
				goto IL_28;
			}
			}
		}

		// Token: 0x060001CC RID: 460 RVA: 0x0005AB7C File Offset: 0x00058D7C
		private void ExportInterfaceForCPS_ExportEditCodeplugEvtHandler(object sender, Motorola.CommonCPS.RadioManagement.SharedServices.DeviceEventArgs e)
		{
			int a_ = 11;
			short num = (short)1777729536;
			switch (num)
			{
			default:
			{
				num = (short)917372928;
				short num2 = num;
				num = (short)876675074;
				int num3 = (int)((IntPtr)num);
				for (;;)
				{
					switch (num3)
					{
					case 0:
						try
						{
							switch (0)
							{
							case 0:
								goto IL_15C;
							}
							for (;;)
							{
								IL_B1:
								WindowMain windowMain;
								bool flag;
								string text;
								switch (num3)
								{
								case 0:
									if (windowMain.CpgOpenFlag)
									{
										num = (short)702677002;
										num3 = (int)((IntPtr)num);
										continue;
									}
									num = (short)21102614;
									num3 = (int)((IntPtr)num);
									continue;
								case 1:
									goto IL_606;
								case 2:
									goto IL_899;
								case 3:
									flag = false;
									goto IL_64C;
								case 4:
									if (!windowMain.ReadWriteInProgress)
									{
										num = (short)143261711;
										num3 = (int)((IntPtr)num);
										continue;
									}
									goto IL_50F;
								case 5:
									goto IL_60B;
								case 6:
								{
									Guid? workingCodeplugUuid;
									if (workingCodeplugUuid == null)
									{
										num = (short)963837991;
										num3 = (int)((IntPtr)num);
										continue;
									}
									goto IL_4CD;
								}
								case 7:
									text += string.Format(FixedLengthStream.b("郪\uddec鋮\udff0裲쓴諶", a_), e.TempalteObj.ModelNumber, e.TempalteObj.FileUuid);
									num = (short)382533670;
									num3 = (int)((IntPtr)num);
									continue;
								case 8:
									(FeatureManager.GetFeature(2010)[0] as DisplayAndMenu).Advanced.DispMenuAdvancedLanguageSelection_A8386Value = (e.DeviceObj.WorkingCodeplug.Template as APXTemplate).LanguageIndex.Value;
									num = (short)343212041;
									num3 = (int)((IntPtr)num);
									continue;
								case 9:
									goto IL_5C7;
								case 10:
									goto IL_50F;
								case 11:
									goto IL_841;
								case 12:
									if (e.DeviceObj != null)
									{
										num = (short)1494876197;
										num3 = (int)((IntPtr)num);
										continue;
									}
									goto IL_60B;
								case 13:
									AppInfoManager.ComparatorFieldsReport.Clear();
									num = (short)1630208002;
									num3 = (int)((IntPtr)num);
									continue;
								case 14:
									(FeatureManager.GetFeature(2010)[0] as DisplayAndMenu).Advanced.DispMenuAdvancedLanguageSelection_A8386Value = (e.TempalteObj as APXTemplate).LanguageIndex.Value;
									num = (short)916979729;
									num3 = (int)((IntPtr)num);
									continue;
								case 15:
									num = (short)1518272512;
									num3 = (int)((IntPtr)num);
									continue;
								case 16:
									if (e.TempalteObj != null)
									{
										num = (short)1565982727;
										num3 = (int)((IntPtr)num);
										continue;
									}
									text += string.Format(FixedLengthStream.b("郪\uddec鋮\udff0裲쓴諶", a_), e.DeviceObj.SerialNumber, e.DeviceObj.WorkingCodeplug.Template.FileUuid);
									num = (short)1632174114;
									num3 = (int)((IntPtr)num);
									continue;
								case 17:
									goto IL_5C7;
								case 18:
								{
									Guid? workingCodeplugUuid;
									Guid? currentCodeplugUuid;
									flag = (workingCodeplugUuid.GetValueOrDefault() == currentCodeplugUuid.GetValueOrDefault());
									goto IL_64C;
								}
								case 19:
									windowMain.WindowState = WindowState.Normal;
									num = (short)1873346584;
									num3 = (int)((IntPtr)num);
									continue;
								case 20:
									num = (short)1549598760;
									num3 = (int)((IntPtr)num);
									continue;
								case 21:
									num = (short)1873215491;
									num3 = (int)((IntPtr)num);
									continue;
								case 22:
									try
									{
										switch (0)
										{
										case 0:
											goto IL_344;
										}
										for (;;)
										{
											IL_321:
											switch (num3)
											{
											case 0:
												goto IL_3A9;
											case 1:
												goto IL_45C;
											case 2:
												goto IL_416;
											case 3:
												if (windowMain.WindowState == WindowState.Minimized)
												{
													num = (short)939720710;
													num3 = (int)((IntPtr)num);
													continue;
												}
												goto IL_3A9;
											case 4:
												this._lastCPModifiedTimestamp = e.DeviceObj.WorkingCodeplug.Timestamp;
												num = (short)599326722;
												num3 = (int)((IntPtr)num);
												continue;
											case 5:
												if (e.DeviceObj != null)
												{
													num = (short)977993732;
													num3 = (int)((IntPtr)num);
													continue;
												}
												goto IL_416;
											case 6:
												windowMain.WindowState = WindowState.Normal;
												num = (short)1192886272;
												num3 = (int)((IntPtr)num);
												continue;
											}
											goto IL_344;
											IL_3A9:
											num = (short)1889861637;
											num3 = (int)((IntPtr)num);
											continue;
											IL_416:
											windowMain.Activate();
											windowMain.OpenCodeplug(text, (APXRadio)e.DeviceObj, (APXTemplate)e.TempalteObj);
											windowMain.OnAppMenuSave(this, null);
											num = (short)1049165825;
											num3 = (int)((IntPtr)num);
										}
										IL_45C:
										return;
										IL_344:
										this.SaveCpsFile(text, e.FileContent);
										num = (short)1626341379;
										num3 = (int)((IntPtr)num);
										goto IL_321;
									}
									catch (Exception ex)
									{
										if (!File.Exists(text))
										{
											goto IL_475;
										}
										IL_46D:
										File.Delete(text);
										IL_475:
										num = (short)1750295780;
										short num4 = num;
										num = (short)1318675684;
										switch ((num4 == num) ? 1 : 0)
										{
										case 0:
										case 2:
											goto IL_46D;
										default:
											num = (short)594149376;
											if (num != 0)
											{
											}
											throw CommonExceptionHelper.CreateCommonException(CommonErrorCode.GenericError, Motorola.CommonCPS.ResourceRepository.Resources.GenericError, ex);
										}
									}
									goto IL_4CD;
								case 23:
									if (text == ((App)Application.Current).TheDocument.docFilePath)
									{
										num = (short)1842610196;
										num3 = (int)((IntPtr)num);
										continue;
									}
									goto IL_246;
								case 24:
									goto IL_1FF;
								case 25:
								{
									Guid? workingCodeplugUuid = e.DeviceObj.WorkingCodeplugUuid;
									Guid? currentCodeplugUuid = e.DeviceObj.CurrentCodeplugUuid;
									num = (short)885850139;
									num3 = (int)((IntPtr)num);
									continue;
								}
								case 26:
									if (e.DeviceObj != null)
									{
										num = (short)709165064;
										num3 = (int)((IntPtr)num);
										continue;
									}
									num = (short)195624995;
									num3 = (int)((IntPtr)num);
									continue;
								case 27:
								{
									Guid? workingCodeplugUuid;
									Guid? currentCodeplugUuid;
									if (workingCodeplugUuid != null != (currentCodeplugUuid != null))
									{
										num = (short)716374037;
										num3 = (int)((IntPtr)num);
										continue;
									}
									num = (short)1649147910;
									num3 = (int)((IntPtr)num);
									continue;
								}
								case 28:
									if (!this.IsEquals(this._lastCPModifiedTimestamp, e.DeviceObj.WorkingCodeplug.Timestamp))
									{
										num = (short)2106327051;
										num3 = (int)((IntPtr)num);
										continue;
									}
									goto IL_976;
								case 29:
									flag = true;
									goto IL_64C;
								case 30:
									goto IL_1A0;
								case 31:
									if (windowMain.WindowState == WindowState.Minimized)
									{
										num = (short)699269139;
										num3 = (int)((IntPtr)num);
										continue;
									}
									goto IL_1FF;
								case 32:
									num = (short)1877082140;
									num3 = (int)((IntPtr)num);
									continue;
								case 33:
								{
									if (AppInfoManager.AppMode == ApplicationMode.CustomViewConfigurationMode)
									{
										num = (short)618856478;
										num3 = (int)((IntPtr)num);
										continue;
									}
									windowMain = (WindowMain)Application.Current.MainWindow;
									byte[] fileContent = e.FileContent;
									text = FixedLengthStream.b("룪裬鷮蟰雲蟴ퟶ룸觺黼韾栀甂怄✆␈⬊", a_);
									num = (short)1373503504;
									num3 = (int)((IntPtr)num);
									continue;
								}
								case 34:
									goto IL_1A5;
								case 35:
									if (e.TempalteObj != null)
									{
										num = (short)1498021902;
										num3 = (int)((IntPtr)num);
										continue;
									}
									goto IL_5C7;
								case 36:
									if (windowMain.CurrentAppMode == ApplicationMode.CodeplugComparisonMode)
									{
										num = (short)47644685;
										num3 = (int)((IntPtr)num);
										continue;
									}
									goto IL_899;
								case 37:
									windowMain.UpdateFieldsWithServerValues((APXRadio)e.DeviceObj);
									num = (short)1155530757;
									num3 = (int)((IntPtr)num);
									continue;
								case 38:
									goto IL_1A5;
								case 39:
									num = (short)1531576349;
									num3 = (int)((IntPtr)num);
									continue;
								case 40:
									if (e.TempalteObj == null)
									{
										num = (short)538771481;
										num3 = (int)((IntPtr)num);
										continue;
									}
									goto IL_976;
								}
								goto IL_15C;
								IL_1A5:
								text = Path.GetTempPath() + text + FixedLengthStream.b("엪胬賮", a_);
								num = (short)231538692;
								num3 = (int)((IntPtr)num);
								continue;
								IL_1FF:
								windowMain.Activate();
								num = (short)139853836;
								num3 = (int)((IntPtr)num);
								continue;
								IL_4CD:
								num = (short)1554448402;
								num3 = (int)((IntPtr)num);
								continue;
								IL_50F:
								num = (short)1608646679;
								num3 = (int)((IntPtr)num);
								continue;
								IL_5C7:
								LanguagePackHelper.BindingLanguageSections();
								RadioInformation radioInformation = FeatureManager.GetFeature(2049)[0] as RadioInformation;
								windowMain.LaunchSection(radioInformation.General);
								num = (short)1142947841;
								num3 = (int)((IntPtr)num);
								continue;
								IL_60B:
								num = (short)964689946;
								num3 = (int)((IntPtr)num);
								continue;
								IL_64C:
								if (flag)
								{
									num = (short)1763508256;
									num3 = (int)((IntPtr)num);
									continue;
								}
								goto IL_976;
								IL_899:
								AppInfoManager.AppMode = ApplicationMode.CodeplugConfigurationMode;
								num = (short)1438187551;
								num3 = (int)((IntPtr)num);
								continue;
								IL_976:
								num = (short)48758820;
								num3 = (int)((IntPtr)num);
							}
							IL_1A0:
							throw CommonExceptionHelper.CreateCommonException(CommonErrorCode.RMC_HasCustomViewSelected, Motorola.CommonCPS.ResourceRepository.Resources.RMC_HasCustomViewSelected, null);
							IL_246:
							throw CommonExceptionHelper.CreateCommonException(CommonErrorCode.RMC_HasCodeplugOpened, Motorola.CommonCPS.ResourceRepository.Resources.RMC_HasCodeplugOpened, null);
							IL_606:
							return;
							IL_841:
							throw CommonExceptionHelper.CreateCommonException(CommonErrorCode.RMC_HasCodeplugOpened, Motorola.CommonCPS.ResourceRepository.Resources.RMC_HasCodeplugOpened, null);
							IL_15C:
							this._isOpenCodeplug = true;
							num = (short)920518689;
							num3 = (int)((IntPtr)num);
							goto IL_B1;
						}
						finally
						{
							this._isOpenCodeplug = false;
						}
						goto IL_A4E;
					case 1:
						goto IL_A2;
					case 2:
						switch (0)
						{
						case 0:
							goto IL_81;
						}
						continue;
					}
					IL_81:
					if (this._isOpenCodeplug)
					{
						num = (short)1596653569;
						num3 = (int)((IntPtr)num);
						continue;
					}
					IL_A4E:
					num = (short)984023041;
					if (num != 0)
					{
					}
					num = (short)1198981120;
					num3 = (int)((IntPtr)num);
				}
				IL_A2:
				throw new CommonException(CommonErrorCode.RMC_HasCodeplugOpened);
			}
			}
		}

		// Token: 0x060001CD RID: 461 RVA: 0x0005B65C File Offset: 0x0005985C
		private bool IsEquals(byte[] b1, byte[] b2)
		{
			short num = (short)1860763653;
			int num2 = (int)((IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_164;
				case 1:
					goto IL_6B;
				case 2:
					return false;
				case 3:
					num = (short)338231300;
					num2 = (int)((IntPtr)num);
					continue;
				case 4:
				{
					num = (short)1139408896;
					short num3 = num;
					num = (short)2080818814;
					short num4 = num;
					num = (short)1561380478;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_6B;
					default:
						num = (short)988479489;
						if (num != 0)
						{
						}
						num = (short)537722880;
						if (num != 0)
						{
						}
						if (b2 == null)
						{
							num = (short)2121334784;
							num2 = (int)((IntPtr)num);
							continue;
						}
						num = (short)255197185;
						num2 = (int)((IntPtr)num);
						continue;
					}
					break;
				}
				case 5:
					switch (0)
					{
					case 0:
						goto IL_3D;
					}
					continue;
				}
				IL_3D:
				if (b1 != null)
				{
					num = (short)1798766595;
					num2 = (int)((IntPtr)num);
					continue;
				}
				return false;
				IL_6B:
				if (b1.Length == b2.Length)
				{
					goto IL_16B;
				}
				num = (short)153681922;
				num2 = (int)((IntPtr)num);
			}
			return false;
			IL_164:
			return false;
			IL_16B:
			return b1.SequenceEqual(b2);
		}

		// Token: 0x060001CE RID: 462 RVA: 0x0005B7DC File Offset: 0x000599DC
		public void ExportInterfaceForCPS_ParseAchiveEvtHandler(object sender, OpenFileEventArgs e)
		{
			int a_ = 14;
			short num = (short)930938880;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_55;
				}
				WindowMain windowMain;
				string filePath;
				for (;;)
				{
					IL_32:
					switch (num2)
					{
					case 0:
						goto IL_5D6;
					case 1:
						num = (short)26607619;
						num2 = (int)((IntPtr)num);
						continue;
					case 2:
					{
						num = (short)44040192;
						short num3 = num;
						if (windowMain.CanOpenCpgFlag)
						{
							num = (short)1103822849;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_4FE;
					}
					case 3:
						if (windowMain.ReadWriteInProgress)
						{
							num = (short)277282821;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_5AF;
					case 4:
						num = (short)1445330946;
						num2 = (int)((IntPtr)num);
						continue;
					case 5:
						goto IL_5AA;
					case 6:
						num = (short)2108424193;
						if (num != 0)
						{
						}
						if (!string.IsNullOrEmpty(filePath))
						{
							num = (short)1000931332;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_5AF;
					}
					goto IL_55;
					IL_5AF:
					string text = string.Empty;
					string text2 = string.Empty;
					num = (short)1735786496;
					num2 = (int)((IntPtr)num);
				}
				IL_4FE:
				throw new CommonException(new CommonExceptionData(CommonErrorCode.RMC_HasCodeplugOpened));
				IL_5AA:
				goto IL_4FE;
				IL_5D6:
				string password;
				ApplicationMode CPSMode;
				try
				{
					switch (0)
					{
					case 0:
						goto IL_11E;
					}
					string text;
					for (;;)
					{
						IL_F3:
						switch (num2)
						{
						case 0:
							goto IL_2BE;
						case 1:
							goto IL_16B;
						case 2:
							File.SetAttributes(text, FileAttributes.Normal);
							File.Delete(text);
							num = (short)1768816641;
							num2 = (int)((IntPtr)num);
							continue;
						case 3:
							num = (short)1483145221;
							num2 = (int)((IntPtr)num);
							continue;
						case 4:
							goto IL_2A5;
						case 5:
							if (!windowMain.PromptQuitOnInvalids().Result)
							{
								num = (short)1250951175;
								num2 = (int)((IntPtr)num);
								continue;
							}
							goto IL_1C5;
						case 6:
							if (windowMain.OpenCodeplugNonGUI(text, password, true, false))
							{
								num = (short)512294915;
								num2 = (int)((IntPtr)num);
								continue;
							}
							goto IL_2A5;
						case 7:
						{
							string text2 = Path.ChangeExtension(text, FixedLengthStream.b("샭裯英雳韵", a_));
							windowMain.SavePBAFileNonGUI(this, null, text2);
							PbaObject pbaobject = PbaObject.DeserializeFrom(text2);
							e.PBAObject = pbaobject;
							num = (short)1708589060;
							num2 = (int)((IntPtr)num);
							continue;
						}
						case 8:
							if (File.Exists(text))
							{
								num = (short)1654390786;
								num2 = (int)((IntPtr)num);
								continue;
							}
							goto IL_16B;
						}
						goto IL_11E;
						IL_16B:
						File.Copy(filePath, text);
						File.SetAttributes(text, FileAttributes.Normal);
						num = (short)2115108870;
						num2 = (int)((IntPtr)num);
						continue;
						IL_2A5:
						num = (short)1361117184;
						num2 = (int)((IntPtr)num);
					}
					IL_1C5:
					AppInfoManager.InvalidFieldsReport.Clear();
					throw new CommonException(new CommonExceptionData(CommonErrorCode.RMC_The_codeplug_contains_invalid_fields));
					IL_2BE:
					return;
					IL_11E:
					text = Path.GetTempPath() + Path.GetFileName(filePath);
					num = (short)341508104;
					num2 = (int)((IntPtr)num);
					goto IL_F3;
				}
				catch (IOException)
				{
					throw new CommonException(new CommonExceptionData(CommonErrorCode.RMC_UnableToReadTheFollowingArchive, new string[]
					{
						filePath
					}));
				}
				catch (CommonException)
				{
					throw;
				}
				catch (Exception)
				{
					throw new CommonException(new CommonExceptionData(CommonErrorCode.RMC_ImportCodeplug_Error));
				}
				finally
				{
					num = (short)798490625;
					num2 = (int)((IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
							goto IL_37E;
						case 1:
							switch (0)
							{
							case 0:
								goto IL_32A;
							}
							continue;
						case 2:
							goto IL_368;
						case 3:
							windowMain.CloseFileNonGUI(false);
							num = (short)2120024066;
							num2 = (int)((IntPtr)num);
							continue;
						}
						IL_32A:
						if (windowMain.CanOpenCpgFlag)
						{
							num = (short)1921318915;
							num2 = (int)((IntPtr)num);
							continue;
						}
						IL_368:
						num = (short)1744502784;
						num2 = (int)((IntPtr)num);
					}
					IL_37E:
					try
					{
						num = (short)973340674;
						num2 = (int)((IntPtr)num);
						for (;;)
						{
							string text;
							switch (num2)
							{
							case 0:
							{
								string text2;
								File.SetAttributes(text2, FileAttributes.Normal);
								File.Delete(text2);
								num = (short)97386502;
								num2 = (int)((IntPtr)num);
								continue;
							}
							case 1:
							{
								num = (short)1904243343;
								short num4 = num;
								num = (short)1146712719;
								switch ((num4 == num) ? 1 : 0)
								{
								case 0:
								case 2:
									break;
								default:
									num = (short)769720320;
									if (num != 0)
									{
									}
									File.SetAttributes(text, FileAttributes.Normal);
									File.Delete(text);
									num = (short)2090729475;
									num2 = (int)((IntPtr)num);
									continue;
								}
								break;
							}
							case 2:
								switch (0)
								{
								case 0:
									goto IL_3C2;
								}
								continue;
							case 3:
								goto IL_48A;
							case 4:
								goto IL_4E1;
							case 5:
							{
								string text2;
								if (File.Exists(text2))
								{
									num = (short)723451904;
									num2 = (int)((IntPtr)num);
									continue;
								}
								goto IL_4C8;
							}
							case 6:
								goto IL_4C8;
							}
							IL_3C2:
							if (File.Exists(text))
							{
								num = (short)1819607041;
								num2 = (int)((IntPtr)num);
								continue;
							}
							IL_48A:
							num = (short)1400897541;
							num2 = (int)((IntPtr)num);
							continue;
							IL_4C8:
							num = (short)285081604;
							num2 = (int)((IntPtr)num);
						}
						IL_4E1:;
					}
					catch
					{
					}
					base.Dispatcher.Invoke(delegate()
					{
						short num5 = (short)56164352;
						short num6 = num5;
						num5 = (short)1284239360;
						short num7 = num5;
						num5 = (short)2122772480;
						switch (num7 == num5)
						{
						}
						num5 = (short)1041170433;
						if (num5 != 0)
						{
						}
						num5 = (short)304414720;
						if (num5 != 0)
						{
						}
						AppInfoManager.AppMode = CPSMode;
					});
				}
				goto IL_4FE;
				IL_55:
				CPSMode = AppInfoManager.AppMode;
				new APXRadio();
				windowMain = this.GetWindowMain();
				filePath = e.FilePath;
				password = e.Password;
				num = (short)1396375558;
				num2 = (int)((IntPtr)num);
				goto IL_32;
			}
			}
		}

		// Token: 0x060001CF RID: 463 RVA: 0x0005BE40 File Offset: 0x0005A040
		private void ExportInterfaceForCPS_ImportDeviceEvtHandler(object sender, OpenFileEventArgs e)
		{
			int a_ = 9;
			short num = (short)1495728128;
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
				WindowMain windowMain;
				APXRadio apxradio;
				string password;
				bool ignorePassword;
				string filePath;
				ApplicationMode CPSMode;
				for (;;)
				{
					IL_31:
					switch (num2)
					{
					case 0:
					{
						if (this._isOpenCodeplug)
						{
							num = (short)1164705798;
							num2 = (int)((IntPtr)num);
							continue;
						}
						string text = string.Empty;
						num = (short)1067581441;
						num2 = (int)((IntPtr)num);
						continue;
					}
					case 1:
						try
						{
							switch (0)
							{
							case 0:
								goto IL_212;
							}
							string text;
							for (;;)
							{
								IL_1DB:
								switch (num2)
								{
								case 0:
									windowMain.OnAppMenuSaveAsNonGUI(this, null, text);
									this.PrepareDevice(apxradio);
									CommonUtility.SetFeatureSet(apxradio, apxradio.Uuid);
									e.ImportingRadio = apxradio;
									num = (short)892862467;
									num2 = (int)((IntPtr)num);
									continue;
								case 1:
									if (!windowMain.PromptQuitOnInvalids().Result)
									{
										num = (short)870121472;
										num2 = (int)((IntPtr)num);
										continue;
									}
									goto IL_3B5;
								case 2:
									if (text.Length >= 260)
									{
										num = (short)1059454983;
										num2 = (int)((IntPtr)num);
										continue;
									}
									goto IL_305;
								case 3:
									goto IL_40F;
								case 4:
									if (windowMain.OpenCodeplugNonGUI(text, password, true, ignorePassword))
									{
										num = (short)2084372485;
										num2 = (int)((IntPtr)num);
										continue;
									}
									goto IL_40F;
								case 5:
									num = (short)1575682049;
									num2 = (int)((IntPtr)num);
									continue;
								case 6:
									if (File.Exists(text))
									{
										num = (short)1516961800;
										num2 = (int)((IntPtr)num);
										continue;
									}
									goto IL_26E;
								case 7:
									text = text.Remove(250) + FixedLengthStream.b("쟨蛪軬", a_);
									num = (short)797376523;
									num2 = (int)((IntPtr)num);
									continue;
								case 8:
									File.SetAttributes(text, FileAttributes.Normal);
									File.Delete(text);
									num = (short)18415626;
									num2 = (int)((IntPtr)num);
									continue;
								case 9:
									goto IL_428;
								case 10:
									goto IL_26E;
								case 11:
									goto IL_305;
								}
								goto IL_212;
								IL_26E:
								File.Copy(filePath, text);
								File.SetAttributes(text, FileAttributes.Normal);
								num = (short)1261371396;
								num2 = (int)((IntPtr)num);
								continue;
								IL_305:
								num = (short)161677318;
								num2 = (int)((IntPtr)num);
								continue;
								IL_40F:
								num = (short)1713373193;
								num2 = (int)((IntPtr)num);
							}
							IL_3B5:
							AppInfoManager.InvalidFieldsReport.Clear();
							throw new CommonException(new CommonExceptionData(CommonErrorCode.RMC_The_codeplug_contains_invalid_fields));
							IL_428:
							return;
							IL_212:
							this._isOpenCodeplug = true;
							text = Path.GetTempPath() + Path.GetFileName(filePath);
							num = (short)1246625794;
							num2 = (int)((IntPtr)num);
							goto IL_1DB;
						}
						catch (PathTooLongException)
						{
							throw new CommonException(CommonErrorCode.RMC_FilePathTooLong_Error);
						}
						catch (IOException)
						{
							throw new CommonException(new CommonExceptionData(CommonErrorCode.RMC_UnableToReadTheFollowingArchive, new string[]
							{
								filePath
							}));
						}
						catch (CommonException)
						{
							throw;
						}
						catch (Exception)
						{
							throw new CommonException(new CommonExceptionData(CommonErrorCode.RMC_ImportCodeplug_Error));
						}
						finally
						{
							num = (short)577372161;
							num2 = (int)((IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_4C0;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_49E;
									}
									continue;
								case 2:
									goto IL_4D8;
									try
									{
										for (;;)
										{
											IL_4D8:
											num = (short)896794625;
											num2 = (int)((IntPtr)num);
											for (;;)
											{
												string text;
												switch (num2)
												{
												case 0:
													goto IL_5BF;
												case 1:
													switch (0)
													{
													case 0:
														goto IL_50F;
													}
													continue;
												case 2:
													goto IL_5A7;
												case 3:
													File.SetAttributes(text, FileAttributes.Normal);
													File.Delete(text);
													num = (short)71303170;
													num2 = (int)((IntPtr)num);
													continue;
												}
												IL_50F:
												num = (short)634602672;
												short num3 = num;
												num = (short)283264176;
												switch ((num3 == num) ? 1 : 0)
												{
												case 0:
												case 2:
													goto IL_4D8;
												default:
													num = (short)1997340672;
													if (num != 0)
													{
													}
													if (File.Exists(text))
													{
														num = (short)1538916355;
														num2 = (int)((IntPtr)num);
														continue;
													}
													break;
												}
												IL_5A7:
												num = (short)773390336;
												num2 = (int)((IntPtr)num);
											}
										}
										IL_5BF:
										goto IL_5E9;
									}
									catch
									{
										goto IL_5E9;
									}
									goto IL_5C4;
								case 3:
									goto IL_5C4;
								}
								IL_49E:
								if (windowMain.CanOpenCpgFlag)
								{
									num = (short)1406205955;
									num2 = (int)((IntPtr)num);
									continue;
								}
								IL_4C0:
								num = (short)324861954;
								num2 = (int)((IntPtr)num);
								continue;
								IL_5C4:
								windowMain.CloseFileNonGUI(false);
								num = (short)1458307072;
								num2 = (int)((IntPtr)num);
							}
							IL_5E9:
							base.Dispatcher.Invoke(delegate()
							{
								short num5 = (short)1687552000;
								short num6 = num5;
								num5 = (short)725739095;
								short num7 = num5;
								num5 = (short)1370941015;
								switch (num7 == num5)
								{
								}
								num5 = (short)1191510016;
								if (num5 != 0)
								{
								}
								num5 = (short)884277249;
								if (num5 != 0)
								{
								}
								AppInfoManager.AppMode = CPSMode;
							});
							this._isOpenCodeplug = false;
						}
						goto IL_608;
					case 2:
						num = (short)1863516167;
						num2 = (int)((IntPtr)num);
						continue;
					case 3:
						num = (short)1940652040;
						num2 = (int)((IntPtr)num);
						continue;
					case 4:
						if (!string.IsNullOrEmpty(filePath))
						{
							num = (short)1893924866;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_608;
					case 5:
						goto IL_18E;
					case 6:
						goto IL_644;
					case 7:
						if (windowMain.CanOpenCpgFlag)
						{
							num = (short)2135818243;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_649;
					case 8:
						if (windowMain.ReadWriteInProgress)
						{
							num = (short)1029570565;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_608;
					}
					goto IL_5C;
					IL_608:
					num = (short)328794112;
					num2 = (int)((IntPtr)num);
				}
				IL_18E:
				goto IL_649;
				IL_644:
				throw new CommonException(CommonErrorCode.RMC_HasCodeplugOpened);
				IL_649:
				throw new CommonException(new CommonExceptionData(CommonErrorCode.RMC_HasCodeplugOpened));
				IL_5C:
				num = (short)571867137;
				if (num != 0)
				{
				}
				CPSMode = AppInfoManager.AppMode;
				apxradio = new APXRadio();
				windowMain = this.GetWindowMain();
				filePath = e.FilePath;
				password = e.Password;
				ignorePassword = e.IgnorePassword;
				num = (short)719585280;
				short num4 = num;
				num = (short)1037172740;
				num2 = (int)((IntPtr)num);
				goto IL_31;
			}
			}
		}

		// Token: 0x060001D0 RID: 464 RVA: 0x0005C53C File Offset: 0x0005A73C
		private void PrepareDevice(APXRadio device)
		{
			short num = (short)2002190336;
			short num2 = num;
			num = (short)281960278;
			short num3 = num;
			num = (short)718626646;
			switch (num3 == num)
			{
			}
			num = (short)354549761;
			if (num != 0)
			{
			}
			num = (short)2092630016;
			if (num != 0)
			{
			}
			APXCodeplug apxcodeplug = new APXCodeplug();
			APXTemplate template = new APXTemplate();
			apxcodeplug.Template = template;
			CommonUtility.PopulatecpAndDeviceColumnsFromDatabaseLayer(apxcodeplug, device, PopulateOpeartion.Import);
			VAHelper.AttachVoiceAnnouncemnetReference(template);
			CACertificatesHelper.AttachCACertificateReference(template);
			DVRSFilesHelper.AttachDVRSFileReference(template);
			this.AddLanguagePackInformation(apxcodeplug, template);
			this.CopyVaFromTemplateToCp(apxcodeplug, template);
			this.CopyCACertsFromTemplateToCp(apxcodeplug, template);
			this.CopyDVRSFilesFromTemplateToCp(apxcodeplug, template);
			device.WorkingCodeplug = apxcodeplug;
			device.ProductFamily = new int?(UtilityMack.IsAPXNextOrAloha ? 4096 : 1);
			apxcodeplug.Template.ProductFamily = new int?(UtilityMack.IsAPXNextOrAloha ? 4096 : 1);
		}

		// Token: 0x060001D1 RID: 465 RVA: 0x0005C67C File Offset: 0x0005A87C
		private void CopyVaFromTemplateToCp(APXCodeplug codeplug, APXTemplate template)
		{
			short num = (short)1106051072;
			short num2 = num;
			num = (short)1826315147;
			short num3 = num;
			num = (short)1898929035;
			switch (num3 == num)
			{
			}
			num = (short)187957248;
			if (num != 0)
			{
			}
			num = (short)246939649;
			if (num != 0)
			{
			}
			codeplug.ASTROVoiceAnnouncements = template.ASTROVoiceAnnouncements;
		}

		// Token: 0x060001D2 RID: 466 RVA: 0x0005C730 File Offset: 0x0005A930
		private void CopyCACertsFromTemplateToCp(APXCodeplug codeplug, APXTemplate template)
		{
			short num = (short)739573760;
			short num2 = num;
			num = (short)1693606395;
			short num3 = num;
			num = (short)1612603899;
			switch (num3 == num)
			{
			}
			num = (short)1546518529;
			if (num != 0)
			{
			}
			num = (short)1760165888;
			if (num != 0)
			{
			}
			codeplug.ASTROCACertificates = template.ASTROCACertificates;
		}

		// Token: 0x060001D3 RID: 467 RVA: 0x0005C7E8 File Offset: 0x0005A9E8
		private void CopyDVRSFilesFromTemplateToCp(APXCodeplug codeplug, APXTemplate template)
		{
			short num = (short)1015873536;
			short num2 = num;
			num = (short)15172060;
			short num3 = num;
			num = (short)1542095324;
			switch (num3 == num)
			{
			}
			num = (short)659619840;
			if (num != 0)
			{
			}
			num = (short)1652555777;
			if (num != 0)
			{
			}
			codeplug.ASTRODVRSFiles = template.ASTRODVRSFiles;
		}

		// Token: 0x060001D4 RID: 468 RVA: 0x0005C8A0 File Offset: 0x0005AAA0
		private void AddLanguagePackInformation(APXCodeplug codeplug, APXTemplate template)
		{
			for (;;)
			{
				switch (0)
				{
				case 0:
					goto IL_1C;
				}
				int? languageIndex;
				int num2;
				short num3;
				for (;;)
				{
					IL_0A:
					int num;
					switch (num)
					{
					case 0:
						if (!(languageIndex.GetValueOrDefault() == num2 & languageIndex != null))
						{
							num3 = (short)215220225;
							if (num3 != 0)
							{
							}
							num3 = (short)1400111106;
							num = (int)((IntPtr)num3);
							continue;
						}
						goto IL_14D;
					case 1:
						goto IL_14B;
					case 2:
					{
						num3 = (short)415825920;
						short num4 = num3;
						ASTROLanguageUtility instance = ASTROLanguageUtility.Instance;
						languageIndex = template.LanguageIndex;
						ASTROLanguagePack astrolanguagePack = instance.CreateFakeLanguagePackage(languageIndex.ToString());
						codeplug.ASTROLanguagePack = astrolanguagePack;
						template.ASTROLanguagePack = astrolanguagePack;
						num3 = (short)873922561;
						num = (int)((IntPtr)num3);
						continue;
					}
					}
					break;
				}
				IL_1C:
				languageIndex = template.LanguageIndex;
				num2 = 0;
				num3 = (short)1153159087;
				short num5 = num3;
				num3 = (short)497668015;
				switch ((num5 == num3) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num3 = (short)1611792384;
					if (num3 != 0)
					{
					}
					num3 = (short)1823604736;
					int num = (int)((IntPtr)num3);
					goto IL_0A;
				}
				}
			}
			IL_14B:
			IL_14D:
			codeplug.LanguageSetting = ASTROLanguageUtility.Instance.GetLanguageSettingInfoForRadio(template);
		}

		// Token: 0x060001D5 RID: 469 RVA: 0x0005CA0C File Offset: 0x0005AC0C
		private void Window_Closing(object sender, CancelEventArgs e)
		{
			switch (0)
			{
			case 0:
				goto IL_38;
			}
			int num;
			short num2;
			WindowMain windowMain;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					goto IL_1C7;
				case 1:
					goto IL_1EB;
				case 2:
				{
					num2 = (short)1510899512;
					short num3 = num2;
					num2 = (short)1683849016;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_1C9;
					default:
						num2 = (short)981270528;
						if (num2 != 0)
						{
						}
						num2 = (short)217382920;
						num = (int)((IntPtr)num2);
						continue;
					}
					break;
				}
				case 3:
					if (RuntimeInfo.WorkingSecurePassword != null)
					{
						num2 = (short)898695177;
						num = (int)((IntPtr)num2);
						continue;
					}
					goto IL_249;
				case 4:
					if (RuntimeInfo.SecurePassword != null)
					{
						num2 = (short)1528102918;
						num = (int)((IntPtr)num2);
						continue;
					}
					goto IL_77;
				case 5:
					if (windowMain != null)
					{
						num2 = (short)998834178;
						num = (int)((IntPtr)num2);
						continue;
					}
					goto IL_C0;
				case 6:
					RuntimeInfo.SecurePassword.Clear();
					num2 = (short)1856897031;
					num = (int)((IntPtr)num2);
					continue;
				case 7:
				{
					num2 = (short)2023489536;
					short num4 = num2;
					goto IL_77;
				}
				case 8:
					num2 = (short)1595080705;
					if (num2 != 0)
					{
					}
					if (windowMain.InRMCEditSession)
					{
						num2 = (short)249167872;
						num = (int)((IntPtr)num2);
						continue;
					}
					goto IL_C0;
				case 9:
					goto IL_1C9;
				}
				goto IL_38;
				IL_77:
				RuntimeInfo.WorkingUserName = string.Empty;
				num2 = (short)942669827;
				num = (int)((IntPtr)num2);
				continue;
				IL_C0:
				RadioManagementBootstrapper.Disconnect();
				RuntimeInfo.IsConnected = false;
				RuntimeInfo.IsCurrentSessionConnected = false;
				RuntimeInfo.UserName = string.Empty;
				num2 = (short)1158414340;
				num = (int)((IntPtr)num2);
				continue;
				IL_1C9:
				RuntimeInfo.WorkingSecurePassword.Clear();
				num2 = (short)761659393;
				num = (int)((IntPtr)num2);
			}
			IL_1C7:
			MessageBox.Show(Motorola.CommonCPS.ResourceRepository.Resources.RMC_HasCodeplugOpened);
			return;
			IL_1EB:
			IL_249:
			base.Hide();
			return;
			IL_38:
			windowMain = this.GetWindowMain();
			e.Cancel = true;
			num2 = (short)793575429;
			num = (int)((IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x060001D6 RID: 470 RVA: 0x0005CC68 File Offset: 0x0005AE68
		private void RMCWnd_AstroCheckHoptionEnableEvtHandler(object sender, ASTROHoptionEnableEventArgs e)
		{
			short num = (short)1901789184;
			short num2 = num;
			num = (short)1263945350;
			short num3 = num;
			num = (short)2036287110;
			switch (num3 == num)
			{
			}
			num = (short)861011969;
			if (num != 0)
			{
			}
			num = (short)1222508544;
			if (num != 0)
			{
			}
			e.IsEnable = RMCRadioAccessValidator.AstroHoptionEnableEventHandler(e.Flashcode, e.Hoption, e.Modelnumber);
		}

		// Token: 0x060001D7 RID: 471 RVA: 0x0005CD34 File Offset: 0x0005AF34
		private void RMCWnd_AstroCheckIsConvOnlyEvtHandler(object sender, ASTROHoptionEnableEventArgs e)
		{
			short num = (short)2090336256;
			short num2 = num;
			num = (short)1573781610;
			short num3 = num;
			num = (short)1690959978;
			switch (num3 == num)
			{
			}
			num = (short)1880358912;
			if (num != 0)
			{
			}
			num = (short)767098881;
			if (num != 0)
			{
			}
			e.IsEnable = RMCRadioAccessValidator.AstrCheckIsConvOnlyEvtHandler(e.Flashcode, e.Modelnumber);
		}

		// Token: 0x060001D8 RID: 472 RVA: 0x0005CDF4 File Offset: 0x0005AFF4
		private void RMCWnd_AstroUpgradeCodeplugEvtHandler(object sender, AstroUpgradeCodeplugEventArgs e)
		{
			int a_ = 13;
			short num = (short)1612840960;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_44;
				}
				ApplicationMode CPSMode;
				for (;;)
				{
					IL_31:
					string text2;
					ResultStatus resultStatus;
					switch (num2)
					{
					case 0:
						goto IL_7F;
					case 1:
						if (this._isOpenCodeplug)
						{
							num = (short)1230503936;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_4E7;
					case 2:
						try
						{
							switch (0)
							{
							case 0:
								goto IL_B5;
							}
							HOptionAdvancedKeyIDS hOptionAdvancedKeyIDS;
							string text;
							OwnerSystemData systemID;
							for (;;)
							{
								IL_8E:
								switch (num2)
								{
								case 0:
									num = (short)1881276417;
									num2 = (int)((IntPtr)num);
									continue;
								case 1:
									goto IL_3B3;
								case 2:
								{
									byte[] cpFileContent;
									try
									{
										FileStream fileStream;
										BinaryReader binaryReader = new BinaryReader(fileStream);
										try
										{
											cpFileContent = binaryReader.ReadBytes(Convert.ToInt32(fileStream.Length));
										}
										finally
										{
											num = (short)264962049;
											num2 = (int)((IntPtr)num);
											for (;;)
											{
												switch (num2)
												{
												case 0:
													((IDisposable)binaryReader).Dispose();
													num = (short)169607170;
													num2 = (int)((IntPtr)num);
													continue;
												case 1:
													switch (0)
													{
													case 0:
														goto IL_196;
													}
													continue;
												case 2:
													goto IL_1CD;
												}
												IL_196:
												if (binaryReader == null)
												{
													break;
												}
												num = (short)1881931776;
												num2 = (int)((IntPtr)num);
											}
											IL_1CD:;
										}
										goto IL_2E0;
									}
									finally
									{
										num = (short)224722945;
										num2 = (int)((IntPtr)num);
										for (;;)
										{
											FileStream fileStream;
											switch (num2)
											{
											case 0:
												((IDisposable)fileStream).Dispose();
												num = (short)1545142274;
												num2 = (int)((IntPtr)num);
												continue;
											case 1:
												switch (0)
												{
												case 0:
													goto IL_209;
												}
												continue;
											case 2:
												goto IL_241;
											}
											IL_209:
											if (fileStream == null)
											{
												break;
											}
											num = (short)1892548608;
											num2 = (int)((IntPtr)num);
										}
										IL_241:;
									}
									goto IL_244;
									IL_2E0:
									e.Syncdata.CpFileContent = cpFileContent;
									e.Syncdata.hOptionAdvancedKeyIDS = hOptionAdvancedKeyIDS;
									e.Syncdata.RadioFeaturesRequest = this.ListFeatureSet(text, e.Syncdata.ModelNumber);
									num = (short)114622464;
									num2 = (int)((IntPtr)num);
									continue;
								}
								case 3:
									systemID = new OwnerSystemData(e.SelectedSystemID.SystemID, this.ConvertASKInterfaceKeyType2AcpASKLibKeyType(e.SelectedSystemID.Type));
									num = (short)1916338183;
									num2 = (int)((IntPtr)num);
									continue;
								case 4:
									if (e.SelectedSystemID != null)
									{
										num = (short)619577347;
										num2 = (int)((IntPtr)num);
										continue;
									}
									goto IL_244;
								case 5:
								{
									FileStream fileStream = new FileStream(text2, FileMode.Open, FileAccess.Read);
									num = (short)1935278082;
									num2 = (int)((IntPtr)num);
									continue;
								}
								case 6:
									if (resultStatus.Result)
									{
										num = (short)1322319877;
										num2 = (int)((IntPtr)num);
										continue;
									}
									goto IL_130;
								case 7:
									goto IL_244;
								}
								goto IL_B5;
								IL_244:
								resultStatus = this.UpdateCodeplug(e.Syncdata.SourceTemplate, text2, text, e.Syncdata.ModelNumber, e.Syncdata.IButtonSerialNumber, e.Syncdata.RadioHostVersion, e.Syncdata.FirmwareVersion, e.Syncdata.bRefresh, systemID, out hOptionAdvancedKeyIDS, e.Syncdata.Firmware);
								num = (short)448790534;
								num2 = (int)((IntPtr)num);
							}
							IL_130:
							throw CommonExceptionHelper.CreateCommonException(CommonErrorCode.RMC_PM_UpgradeCodeplugFailed, resultStatus.ResultMessage, null);
							IL_3B3:
							return;
							IL_B5:
							this._isOpenCodeplug = true;
							this.SaveCpsFile(text2, e.Syncdata.CpFileContent);
							hOptionAdvancedKeyIDS = null;
							text = SpecialFeatures.Flashport.FlashRadio.FlashcodeFormatter.FormatFlashcodeString(e.Syncdata.FlashCode, e.Syncdata.FlashCode.Length);
							systemID = null;
							num = (short)1184563204;
							num2 = (int)((IntPtr)num);
							goto IL_8E;
						}
						catch (IOException)
						{
							throw new CommonException(new CommonExceptionData(CommonErrorCode.RMC_UnableToReadTheFollowingArchive, new string[]
							{
								text2
							}));
						}
						catch (CommonException)
						{
							throw;
						}
						catch (Exception)
						{
							throw CommonExceptionHelper.CreateCommonException(CommonErrorCode.RMC_PM_UpgradeCodeplugFailed, Motorola.CommonCPS.ResourceRepository.Resources.RMC_PM_UpgradeCodeplugFailed, null);
						}
						finally
						{
							num = (short)609449685;
							short num3 = num;
							num = (short)1204123349;
							switch ((num3 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								break;
							default:
								num = (short)1238368256;
								if (num != 0)
								{
								}
								switch (0)
								{
								case 0:
									goto IL_450;
								}
								for (;;)
								{
									IL_43D:
									switch (num2)
									{
									case 0:
										File.Delete(text2);
										num = (short)1641676802;
										num2 = (int)((IntPtr)num);
										continue;
									case 1:
										if (File.Exists(text2))
										{
											num = (short)1798045696;
											num2 = (int)((IntPtr)num);
											continue;
										}
										goto IL_4B9;
									case 2:
										goto IL_4B7;
									}
									goto IL_450;
								}
								IL_4B7:
								break;
								IL_450:
								base.Dispatcher.Invoke(delegate()
								{
									short num5 = (short)2122842112;
									short num6 = num5;
									num5 = (short)1298594503;
									short num7 = num5;
									num5 = (short)656669383;
									switch (num7 == num5)
									{
									}
									num5 = (short)1619460097;
									if (num5 != 0)
									{
									}
									num5 = (short)404881408;
									if (num5 != 0)
									{
									}
									AppInfoManager.AppMode = CPSMode;
								});
								num = (short)1067384833;
								num2 = (int)((IntPtr)num);
								goto IL_43D;
							}
							IL_4B9:
							num = (short)2082471937;
							if (num != 0)
							{
							}
							this._isOpenCodeplug = false;
						}
						goto IL_4E7;
					}
					goto IL_44;
					IL_4E7:
					resultStatus = new ResultStatus();
					text2 = Path.GetTempPath() + Guid.NewGuid().ToString() + FixedLengthStream.b("쏬苮鋰", a_);
					CPSMode = AppInfoManager.AppMode;
					num = (short)1103691778;
					num2 = (int)((IntPtr)num);
				}
				IL_7F:
				num = (short)954531840;
				short num4 = num;
				throw new CommonException(CommonErrorCode.RMC_HasCodeplugOpened);
				IL_44:
				num = (short)1292042241;
				num2 = (int)((IntPtr)num);
				goto IL_31;
			}
			}
		}

		// Token: 0x060001D9 RID: 473 RVA: 0x0005D40C File Offset: 0x0005B60C
		private void RMCWnd_AnalysisPackageEvtHandler(object sender, AnalysisPackageEventArgs e)
		{
			int a_ = 19;
			short num;
			try
			{
				num = (short)607256583;
				int num2 = (int)((IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						e.AstroFWPackageInfos = this.AnaysisListFirmwarePackage(e.filePath).Select(delegate(ASTROFirmware x)
						{
							short num5 = (short)112918528;
							short num6 = num5;
							num5 = (short)1836405895;
							short num7 = num5;
							num5 = (short)1735742599;
							switch (num7 == num5)
							{
							}
							num5 = (short)1656815617;
							if (num5 != 0)
							{
							}
							num5 = (short)2016215040;
							if (num5 != 0)
							{
							}
							return x;
						}).ToList<Package>();
						e.PackageInfo = e.AstroFWPackageInfos.FirstOrDefault<Package>();
						num = (short)650444812;
						num2 = (int)((IntPtr)num);
						continue;
					case 1:
						goto IL_406;
					case 2:
						num = (short)1888747523;
						num2 = (int)((IntPtr)num);
						continue;
					case 3:
					{
						if (BundleNameUtility.IsCVNFile(e.filePath))
						{
							goto IL_254;
						}
						num = (short)251378107;
						short num3 = num;
						num = (short)345487803;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_2EB;
						default:
							num = (short)940441600;
							if (num != 0)
							{
							}
							num = (short)257556494;
							num2 = (int)((IntPtr)num);
							continue;
						}
						break;
					}
					case 4:
						goto IL_181;
					case 5:
						goto IL_3EE;
					case 6:
						goto IL_3EE;
					case 7:
						switch (0)
						{
						case 0:
							goto IL_7D;
						}
						continue;
					case 8:
						goto IL_254;
					case 9:
						if (!BundleNameUtility.IsBBFFile(e.filePath))
						{
							num = (short)938344466;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_254;
					case 10:
						goto IL_3EE;
					case 11:
						if (e.filePath.EndsWith(FixedLengthStream.b("\uddf2釴银鷸", a_), StringComparison.CurrentCultureIgnoreCase))
						{
							num = (short)794951695;
							num2 = (int)((IntPtr)num);
							continue;
						}
						e.PackageInfo = CACertificatesHelper.AnalysisCACertificatePackageInfo(e.filePath);
						num = (short)1940324357;
						num2 = (int)((IntPtr)num);
						continue;
					case 12:
						goto IL_3EE;
					case 13:
						num = (short)1793851393;
						if (num != 0)
						{
						}
						if (!e.filePath.EndsWith(FixedLengthStream.b("\uddf2苴零迸", a_)))
						{
							num = (short)396034065;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_181;
					case 14:
						num = (short)1685192713;
						num2 = (int)((IntPtr)num);
						continue;
					case 15:
						e.PackageInfo = DVRSFilesHelper.AnalysisDVRSFilePackageInfo(e.filePath);
						num = (short)1403387914;
						num2 = (int)((IntPtr)num);
						continue;
					case 16:
						if (BundleNameUtility.IsZIPFile(e.filePath))
						{
							num = (short)386203656;
							num2 = (int)((IntPtr)num);
							continue;
						}
						num = (short)797900813;
						num2 = (int)((IntPtr)num);
						continue;
					case 17:
						num = (short)56295443;
						num2 = (int)((IntPtr)num);
						continue;
					case 18:
						num = (short)2006646800;
						num2 = (int)((IntPtr)num);
						continue;
					case 19:
						if (e.filePath.EndsWith(FixedLengthStream.b("\uddf2飴臶飸", a_)))
						{
							goto IL_2EB;
						}
						num = (short)2090336267;
						num2 = (int)((IntPtr)num);
						continue;
					}
					IL_7D:
					if (File.Exists(e.filePath))
					{
						num = (short)778567682;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_3EE;
					IL_181:
					e.PackageInfo = VAHelper.AnaysisVAPackageInfo(e.filePath);
					num = (short)1861943302;
					num2 = (int)((IntPtr)num);
					continue;
					IL_254:
					num = (short)2066350080;
					num2 = (int)((IntPtr)num);
					continue;
					IL_2EB:
					num = (short)1926365188;
					num2 = (int)((IntPtr)num);
					continue;
					IL_3EE:
					num = (short)1737687041;
					num2 = (int)((IntPtr)num);
				}
				IL_406:;
			}
			catch (CommonException)
			{
				throw;
			}
			catch (Exception)
			{
				throw CommonExceptionHelper.CreateDirectMessageCommonException(Motorola.CommonCPS.ResourceRepository.Resources.AnaysisPackageFailed);
			}
			num = (short)1725759488;
			short num4 = num;
		}

		// Token: 0x060001DA RID: 474 RVA: 0x0005D890 File Offset: 0x0005BA90
		private void RMCWnd_LanguagePackInfosEvtHandler(object sender, ListLpPackageEventArgs e)
		{
			int a_ = 11;
			short num;
			try
			{
				num = (short)1405091845;
				int num2 = (int)((IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
					{
						int num3;
						string[] array;
						if (num3 >= array.Length)
						{
							num = (short)1937965064;
							num2 = (int)((IntPtr)num);
							continue;
						}
						string packagePath = array[num3];
						num = (short)875823106;
						num2 = (int)((IntPtr)num);
						continue;
					}
					case 1:
						goto IL_1FC;
					case 2:
					{
						try
						{
							string packagePath;
							e.LanguagePacks.Add(LanguagePackHelper.ParseLanguagePackage(packagePath));
						}
						catch (Exception)
						{
						}
						int num3;
						num3++;
						num = (short)1253769219;
						num2 = (int)((IntPtr)num);
						continue;
					}
					case 3:
						goto IL_F2;
					case 4:
					{
						string[] files = Directory.GetFiles(LanguagePackHelper.LanguagePackFolderPath, FixedLengthStream.b("쇪쏬菮臰飲", a_));
						e.LanguagePacks = new List<Package>();
						string[] array = files;
						int num3 = 0;
						num = (short)1781792774;
						num2 = (int)((IntPtr)num);
						continue;
					}
					case 5:
						switch (0)
						{
						case 0:
							goto IL_52;
						}
						continue;
					case 6:
						goto IL_F2;
					case 7:
					{
						num = (short)1239941121;
						if (num != 0)
						{
						}
						num = (short)106978146;
						short num4 = num;
						num = (short)21846882;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							continue;
						default:
							num = (short)1826881536;
							if (num != 0)
							{
							}
							num = (short)2112028673;
							num2 = (int)((IntPtr)num);
							continue;
						}
						break;
					}
					case 8:
						num = (short)1128005639;
						num2 = (int)((IntPtr)num);
						continue;
					}
					IL_52:
					if (Directory.Exists(LanguagePackHelper.LanguagePackFolderPath))
					{
						num = (short)726663172;
						num2 = (int)((IntPtr)num);
						continue;
					}
					break;
					IL_F2:
					num = (short)1155989504;
					num2 = (int)((IntPtr)num);
				}
				throw CommonExceptionHelper.CreateDirectMessageCommonException(Motorola.CommonCPS.ResourceRepository.Resources.Astro_CPS_LP_NotFound);
				IL_1FC:;
			}
			catch (CommonException)
			{
				throw;
			}
			catch (Exception)
			{
				throw CommonExceptionHelper.CreateDirectMessageCommonException(Motorola.CommonCPS.ResourceRepository.Resources.AnaysisPackageFailed);
			}
			num = (short)1970274304;
			short num5 = num;
		}

		// Token: 0x060001DB RID: 475 RVA: 0x0005DB20 File Offset: 0x0005BD20
		private void RMCWnd_AstroDecodeLangageIndexToLpIDEvtHandler(object sender, AstroDecodeLanguageIndexToLPIDEventArgs e)
		{
			short num = (short)1423966209;
			if (num != 0)
			{
			}
			num = (short)882407306;
			short num2 = num;
			num = (short)1161787274;
			switch (num2 == num)
			{
			default:
			{
				num = (short)27721728;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)754974720;
			if (num != 0)
			{
			}
			e.LanguagePackageID = LanguagePackHelper.GetAstroLanugagePackID(e.LanguageIndex);
		}

		// Token: 0x060001DC RID: 476 RVA: 0x0005DBDC File Offset: 0x0005BDDC
		private void RMCWnd_AstroLanguagePackCompatibleCheckEvtHandler(object sender, AstroLanguageCompatibleCheckEventArgs e)
		{
			short num;
			try
			{
				for (;;)
				{
					IL_00:
					num = (short)762445825;
					int num2 = (int)((IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
							goto IL_10D;
						case 1:
							switch (0)
							{
							case 0:
								goto IL_38;
							}
							continue;
						case 2:
							goto IL_124;
						case 3:
						{
							num = (short)854437990;
							short num3 = num;
							num = (short)124170342;
							switch ((num3 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_00;
							default:
								num = (short)1014431744;
								if (num != 0)
								{
								}
								e.IsCompatible = LanguagePackHelper.IsFirmwareLPCompatible(e.FirmwareVersion, e.LanguageIndex);
								num = (short)1288175620;
								num2 = (int)((IntPtr)num);
								continue;
							}
							break;
						}
						case 4:
							goto IL_10D;
						}
						IL_38:
						if (!e.Detailed)
						{
							num = (short)953090051;
							num2 = (int)((IntPtr)num);
							continue;
						}
						string stat = null;
						e.IsCompatible = LanguagePackHelper.IsFirmwareLPCompatible(e.FirmwareVersion, ref stat, e.LanguageIndex, UtilityMack.IsPortablePro);
						e.Stat = stat;
						num = (short)1764950016;
						num2 = (int)((IntPtr)num);
						continue;
						IL_10D:
						num = (short)216662018;
						num2 = (int)((IntPtr)num);
					}
				}
				IL_124:;
			}
			catch
			{
				e.IsCompatible = false;
			}
			num = (short)1049624576;
			short num4 = num;
			num = (short)864288769;
			if (num != 0)
			{
			}
		}

		// Token: 0x060001DD RID: 477 RVA: 0x0005DD88 File Offset: 0x0005BF88
		private void RMCWnd_BindingServerLanguagePackEvtHandler(object sender, BindingServerLanguagePackEventArgs e)
		{
			short num;
			try
			{
				num = (short)1691951897;
				short num2 = num;
				num = (short)2029069081;
				switch (num2 == num)
				{
				}
				num = (short)1232338944;
				if (num != 0)
				{
				}
				e.IsNeedBinding = LanguagePackHelper.IsNeedBindingServerLanguagePack(e.FirmwareVersion);
			}
			catch
			{
				e.IsNeedBinding = false;
			}
			num = (short)2016542720;
			short num3 = num;
			num = (short)2022244353;
			if (num != 0)
			{
			}
		}

		// Token: 0x060001DE RID: 478 RVA: 0x0005DE60 File Offset: 0x0005C060
		private void RMCWnd_AstroUpgradeWithLanugagePackIsSupportedCheckEvtHandler(object sender, AstroUpgradeWithLanugagePackIsSupportedCheckEventArgs e)
		{
			short num;
			try
			{
				num = (short)215395361;
				short num2 = num;
				num = (short)229551137;
				switch (num2 == num)
				{
				}
				num = (short)1104150528;
				if (num != 0)
				{
				}
				e.IsSupported = LanguagePackHelper.IsRadioUpgradeHostGreaterThan_7_12(e.RadioFirmwareVersion, e.CVNFirmwareVersion);
			}
			catch
			{
				e.IsSupported = false;
			}
			num = (short)1626079232;
			short num3 = num;
			num = (short)1997733889;
			if (num != 0)
			{
			}
		}

		// Token: 0x060001DF RID: 479 RVA: 0x0005DF40 File Offset: 0x0005C140
		private void RMCWnd_AstroUpgradeFWVerCompatibleCheckEvtHandler(object sender, AstroUpgradeFWCompatibleCheckEventArgs e)
		{
			short num;
			try
			{
				num = (short)828879837;
				short num2 = num;
				num = (short)2075833309;
				switch (num2 == num)
				{
				}
				num = (short)1292435456;
				if (num != 0)
				{
				}
				e.IsCompatible = !UpgradeRadioValidator.IsCPSVersionLowerThanFirmwareUpgradeVersion(e.CVNHostVersion, AppInfoManager.AppVersion);
			}
			catch
			{
				e.IsCompatible = false;
			}
			num = (short)301203456;
			short num3 = num;
			num = (short)34340865;
			if (num != 0)
			{
			}
		}

		// Token: 0x060001E0 RID: 480 RVA: 0x0005E020 File Offset: 0x0005C220
		private void RMCWnd_AstroReadFlashKeyEvtHandler(object sender, AstroFlashKeyEventArgs e)
		{
			short num = (short)1835143725;
			short num2 = num;
			num = (short)456528429;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)674627584;
				if (num != 0)
				{
				}
				num = (short)1144324097;
				if (num != 0)
				{
				}
				RMCFlashkey rmcflashkey = new RMCFlashkey();
				try
				{
					num = (short)1281032193;
					int num3 = (int)((IntPtr)num);
					for (;;)
					{
						switch (num3)
						{
						case 0:
							goto IL_1BC;
						case 1:
							switch (0)
							{
							case 0:
								goto IL_B3;
							}
							continue;
						case 2:
							goto IL_1D3;
						case 3:
						{
							e.KeyInfo.NewModelNumber = rmcflashkey.NewModelNumber;
							byte[] newFlashCode = new byte[0];
							SpecialFeatures.Flashport.FlashRadio.FlashcodeDecoder.Decode(rmcflashkey.NewFlashcode, ref newFlashCode);
							e.KeyInfo.NewFlashCode = newFlashCode;
							e.KeyInfo.iButtonSerialNumber = rmcflashkey.SerialNumber;
							e.KeyInfo.DateCode = rmcflashkey.DateCode;
							e.KeyInfo.FactoryOrderNumber = rmcflashkey.FactoryOrderNumber;
							e.KeyInfo.UpgradesPurchased = rmcflashkey.UpgradesPurchased;
							e.KeyInfo.UpgradesRemaining = rmcflashkey.UpgradesRemaining;
							num = (short)806092800;
							num3 = (int)((IntPtr)num);
							continue;
						}
						case 4:
							goto IL_1BC;
						}
						IL_B3:
						if (rmcflashkey.Open(e.KeyInfo.OldModelNumber, SpecialFeatures.Flashport.FlashRadio.FlashcodeFormatter.FormatFlashcodeString(e.KeyInfo.OldFlashCode, e.KeyInfo.OldFlashCode.Length)))
						{
							num = (short)323158019;
							num3 = (int)((IntPtr)num);
							continue;
						}
						e.KeyInfo = null;
						num = (short)8781828;
						num3 = (int)((IntPtr)num);
						continue;
						IL_1BC:
						num = (short)118685698;
						num3 = (int)((IntPtr)num);
					}
					IL_1D3:;
				}
				catch (CommonException)
				{
					throw;
				}
				catch (Exception ex)
				{
					throw CommonExceptionHelper.CreateCommonException(CommonErrorCode.GenericError, Motorola.CommonCPS.ResourceRepository.Resources.GenericError, ex);
				}
				finally
				{
					rmcflashkey.Close();
				}
				break;
			}
			}
			num = (short)1547894784;
			short num4 = num;
		}

		// Token: 0x060001E1 RID: 481 RVA: 0x0005E290 File Offset: 0x0005C490
		private void RMCWnd_AstroDecraseFlashKeyEvtHandler(object sender, AstroDecreaseKeyCountEventArgs e)
		{
			short num = (short)700002245;
			short num2 = num;
			num = (short)1690382277;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)1584791552;
				short num3 = num;
				num = (short)1667104768;
				if (num != 0)
				{
				}
				RMCFlashkey rmcflashkey = new RMCFlashkey();
				try
				{
					num = (short)1296171010;
					int num4 = (int)((IntPtr)num);
					for (;;)
					{
						switch (num4)
						{
						case 0:
							goto IL_18E;
						case 1:
							rmcflashkey.DecrementFlashkeyCounter(e.DecreaseKeyCount);
							num = (short)1712324613;
							num4 = (int)((IntPtr)num);
							continue;
						case 2:
							switch (0)
							{
							case 0:
								goto IL_B7;
							}
							continue;
						case 3:
							if (rmcflashkey.UpgradesRemaining >= e.DecreaseKeyCount)
							{
								num = (short)814284801;
								num4 = (int)((IntPtr)num);
								continue;
							}
							goto IL_100;
						case 4:
							goto IL_ED;
						case 5:
							num = (short)791937024;
							num4 = (int)((IntPtr)num);
							continue;
						}
						IL_B7:
						if (!rmcflashkey.Open(e.OldModelNumber, SpecialFeatures.Flashport.FlashRadio.FlashcodeFormatter.FormatFlashcodeString(e.OldFlashCode, e.OldFlashCode.Length)))
						{
							num = (short)215154692;
							num4 = (int)((IntPtr)num);
						}
						else
						{
							num = (short)1005715459;
							num4 = (int)((IntPtr)num);
						}
					}
					IL_ED:
					throw CommonExceptionHelper.CreateCommonException(CommonErrorCode.RMC_FlashKey_NotFound, Motorola.CommonCPS.ResourceRepository.Resources.RMC_FlashKey_NotFound, null);
					IL_100:
					throw CommonExceptionHelper.CreateCommonException(CommonErrorCode.RMC_FlashKeyReminingCountNotEnough, Motorola.CommonCPS.ResourceRepository.Resources.RMC_FlashKeyReminingCountNotEnough, null);
					IL_18E:
					num = (short)339083265;
					if (num != 0)
					{
					}
				}
				catch (CommonException)
				{
					throw;
				}
				catch (Exception ex)
				{
					throw CommonExceptionHelper.CreateCommonException(CommonErrorCode.RMC_FlashKeyDecraseFailed, Motorola.CommonCPS.ResourceRepository.Resources.GenericError, ex);
				}
				finally
				{
					rmcflashkey.Close();
				}
				break;
			}
			}
		}

		// Token: 0x060001E2 RID: 482 RVA: 0x0005E4BC File Offset: 0x0005C6BC
		private void RMCWnd_AstroValidateFlashKeyEvtHandler(object sender, AstroFlashKeyEventArgs e)
		{
			short num = (short)1105499560;
			short num2 = num;
			num = (short)1902613928;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1431830528;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1081999361;
			if (num != 0)
			{
			}
			num = (short)136773632;
			if (num != 0)
			{
			}
			RMCFlashkey rmcflashkey = new RMCFlashkey();
			e.IsValid = rmcflashkey.ValidateFlashKey();
		}

		// Token: 0x060001E3 RID: 483 RVA: 0x0005E578 File Offset: 0x0005C778
		private void RMCWnd_AstroReleaseFlashKeyEvtHandler(object sender, EventArgs e)
		{
			short num = (short)346091589;
			short num2 = num;
			num = (short)808513605;
			switch (num2 == num)
			{
			default:
			{
				num = (short)214761472;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)947912704;
			if (num != 0)
			{
			}
			num = (short)943063041;
			if (num != 0)
			{
			}
			FlashKeyManagerSingleTon.ReleaseFlashKeyManager();
		}

		// Token: 0x060001E4 RID: 484 RVA: 0x0005E628 File Offset: 0x0005C828
		private void RMCWnd_AstroDecodeFlashCodeEvtHandler(object sender, AstroDecodeFlashCodeEventArgs e)
		{
			short num = (short)1617690625;
			if (num != 0)
			{
			}
			num = (short)1413939200;
			short num2 = num;
			num = (short)1155190225;
			short num3 = num;
			num = (short)1190645201;
			switch (num3 == num)
			{
			}
			num = (short)1812004864;
			if (num != 0)
			{
			}
			e.DecodeFlashCode = SpecialFeatures.Flashport.FlashRadio.FlashcodeFormatter.FormatFlashcodeString(e.FlashCode, e.FlashCode.Length);
		}

		// Token: 0x060001E5 RID: 485 RVA: 0x0005E6E8 File Offset: 0x0005C8E8
		private void RMCWnd_AstroPINPasswordConvertEventHandler(object sender, AstroPINPasswordConvertEventArgs e)
		{
			short num;
			while (e.IsEncrypt)
			{
				num = (short)1590054548;
				short num2 = num;
				num = (short)109203092;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)652673025;
					if (num != 0)
					{
					}
					num = (short)1376059392;
					if (num != 0)
					{
					}
					e.Target = AESCryptoUtil.AESEncryptWithDefKey(e.Source);
					return;
				}
			}
			num = (short)954793984;
			short num3 = num;
			e.Target = AESCryptoUtil.AESDecryptWithDefKey(e.Source);
		}

		// Token: 0x060001E6 RID: 486 RVA: 0x0005E7C4 File Offset: 0x0005C9C4
		private void RMCWnd_AstroGetLoadedSysKeysEvtHandlerEvtHandler(object sender, AstroSystemKeyDataEventArgs e)
		{
			short num = (short)657653760;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_7A;
				}
				ObservableCollection<ISystemKeyData> observableCollection;
				ObservableCollection<AcpASKLib.SystemKeyData> observableCollection2;
				for (;;)
				{
					IL_27:
					num = (short)114491393;
					if (num != 0)
					{
					}
					Collection<AcpASKLib.SystemKeyData> sysKeysFromLoadedAndAttachedASKs;
					IEnumerator<AcpASKLib.SystemKeyData> enumerator;
					switch (num2)
					{
					case 0:
						goto IL_130;
					case 1:
						if (sysKeysFromLoadedAndAttachedASKs.Count > 0)
						{
							num = (short)1708326920;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_130;
					case 2:
						sysKeysFromLoadedAndAttachedASKs = SecurityManager.GetSysKeysFromLoadedAndAttachedASKs();
						num = (short)631504903;
						num2 = (int)((IntPtr)num);
						continue;
					case 3:
						goto IL_179;
					case 4:
						num = (short)2094596097;
						num2 = (int)((IntPtr)num);
						continue;
					case 5:
						try
						{
							num = (short)1500643330;
							num2 = (int)((IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)118554628;
										num2 = (int)((IntPtr)num);
										continue;
									}
									ISystemKeyData item = RMCWnd.ACPKeyDataConvertToSystemKeyData(enumerator.Current);
									observableCollection.Add(item);
									num = (short)2000945155;
									num2 = (int)((IntPtr)num);
									continue;
								}
								case 1:
									goto IL_2B4;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_236;
									}
									continue;
								case 4:
									num = (short)1492189185;
									num2 = (int)((IntPtr)num);
									continue;
								}
								IL_238:
								num = (short)1252130816;
								num2 = (int)((IntPtr)num);
								continue;
								IL_236:
								goto IL_238;
							}
							IL_2B4:
							goto IL_349;
						}
						finally
						{
							num = (short)12320768;
							num2 = (int)((IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_2EC;
									}
									continue;
								case 1:
									goto IL_322;
								case 2:
									enumerator.Dispose();
									num = (short)1608777729;
									num2 = (int)((IntPtr)num);
									continue;
								}
								IL_2EC:
								if (enumerator == null)
								{
									break;
								}
								num = (short)1175781378;
								num2 = (int)((IntPtr)num);
							}
							IL_322:;
						}
						goto IL_325;
					case 6:
					{
						if (!e.IsAttached)
						{
							observableCollection2 = SecurityManager.LoadedASKs;
							num = (short)2043215875;
							num2 = (int)((IntPtr)num);
							continue;
						}
						num = (short)722923965;
						short num3 = num;
						num = (short)1866723773;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_179;
						default:
						{
							num = (short)1481310208;
							short num4 = num;
							num = (short)1847328768;
							if (num != 0)
							{
							}
							num = (short)577175554;
							num2 = (int)((IntPtr)num);
							continue;
						}
						}
						break;
					}
					case 7:
						if (sysKeysFromLoadedAndAttachedASKs != null)
						{
							num = (short)236912644;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_130;
					case 8:
						goto IL_325;
					}
					goto IL_7A;
					IL_130:
					observableCollection = new ObservableCollection<ISystemKeyData>();
					enumerator = observableCollection2.GetEnumerator();
					num = (short)1369243653;
					num2 = (int)((IntPtr)num);
					continue;
					IL_179:
					goto IL_130;
					IL_325:
					observableCollection2 = new ObservableCollection<AcpASKLib.SystemKeyData>(sysKeysFromLoadedAndAttachedASKs);
					num = (short)209387520;
					num2 = (int)((IntPtr)num);
				}
				IL_349:
				e.LoadedSysKeys = observableCollection;
				return;
				IL_7A:
				observableCollection2 = new ObservableCollection<AcpASKLib.SystemKeyData>();
				num = (short)659357702;
				num2 = (int)((IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x060001E7 RID: 487 RVA: 0x0005EB34 File Offset: 0x0005CD34
		public static void AnalysisFirmwarePackage(string upgradeFilePath, ref ASTROFirmware packageInfo)
		{
			int a_ = 7;
			short num = (short)1568236184;
			short num2 = num;
			num = (short)345924248;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)1167458304;
				short num3 = num;
				num = (short)395051008;
				if (num != 0)
				{
				}
				num = (short)1271398400;
				switch (num)
				{
				default:
				{
					num = (short)1952841729;
					if (num != 0)
					{
					}
					FlashportUpgradeFile flashportUpgradeFile = new FlashportUpgradeFile(upgradeFilePath);
					try
					{
						num = (short)2046885903;
						int num4 = (int)((IntPtr)num);
						for (;;)
						{
							switch (num4)
							{
							case 0:
								num = (short)658178060;
								num4 = (int)((IntPtr)num);
								continue;
							case 1:
								if (string.IsNullOrEmpty(packageInfo.DspVersion))
								{
									num = (short)1442971654;
									num4 = (int)((IntPtr)num);
									continue;
								}
								goto IL_1B7;
							case 2:
								goto IL_79E;
							case 3:
								goto IL_6FF;
							case 4:
							{
								string fileTargetModelNumberForBBF;
								if (BundleNameUtility.IsOMAPBundle(fileTargetModelNumberForBBF))
								{
									num = (short)1640235017;
									num4 = (int)((IntPtr)num);
									continue;
								}
								num = (short)1135018010;
								num4 = (int)((IntPtr)num);
								continue;
							}
							case 5:
								goto IL_7D1;
							case 6:
								packageInfo.DspVersion = packageInfo.SoftwareVersion;
								num = (short)1119092747;
								num4 = (int)((IntPtr)num);
								continue;
							case 7:
								goto IL_79E;
							case 8:
								if (BundleNameUtility.IsCVNFile(upgradeFilePath))
								{
									num = (short)816971795;
									num4 = (int)((IntPtr)num);
									continue;
								}
								num = (short)2109145113;
								num4 = (int)((IntPtr)num);
								continue;
							case 9:
								packageInfo.IsOMAPFirmwareUpgradeFile = new bool?(true);
								packageInfo.IsFreonFirmwareUpgradeFile = new bool?(false);
								num = (short)714211335;
								num4 = (int)((IntPtr)num);
								continue;
							case 10:
								if (flashportUpgradeFile.OpenUpgradeFile())
								{
									num = (short)1770782737;
									num4 = (int)((IntPtr)num);
									continue;
								}
								goto IL_3D8;
							case 11:
								goto IL_1B7;
							case 12:
							{
								bool flag;
								if (!flag)
								{
									num = (short)1286209539;
									num4 = (int)((IntPtr)num);
									continue;
								}
								RMFile rmfile = new RMFile
								{
									Url = upgradeFilePath
								};
								packageInfo.RMFile = rmfile;
								packageInfo.PackageVersion = packageInfo.SoftwareVersion;
								packageInfo.PackageName = Path.GetFileName(upgradeFilePath);
								string fileTargetModelNumberForBBF;
								packageInfo.TargetModel = fileTargetModelNumberForBBF;
								packageInfo.IsVirtualSummaryFirmware = new bool?(false);
								num = (short)697237508;
								num4 = (int)((IntPtr)num);
								continue;
							}
							case 13:
								packageInfo.SoftwareVersion = flashportUpgradeFile.GetFileComponentVersion(FixedLengthStream.b("꿦꿨볪뻬", a_), false);
								packageInfo.DspVersion = flashportUpgradeFile.GetFileComponentVersion(FixedLengthStream.b("ꏦ꿨볪ꧬ", a_), false);
								num = (short)1483014145;
								num4 = (int)((IntPtr)num);
								continue;
							case 14:
								goto IL_79E;
							case 15:
								switch (0)
								{
								case 0:
									goto IL_16D;
								}
								continue;
							case 16:
							{
								string fileTargetModelNumberForBBF;
								if (!BundleNameUtility.IsBBFBundle(fileTargetModelNumberForBBF))
								{
									num = (short)624885781;
									num4 = (int)((IntPtr)num);
									continue;
								}
								num = (short)377815068;
								num4 = (int)((IntPtr)num);
								continue;
							}
							case 17:
								num = (short)754712599;
								num4 = (int)((IntPtr)num);
								continue;
							case 18:
								goto IL_18D;
							case 19:
								num = (short)635371530;
								num4 = (int)((IntPtr)num);
								continue;
							case 20:
								packageInfo.IsOMAPFirmwareUpgradeFile = new bool?(false);
								packageInfo.IsFreonFirmwareUpgradeFile = new bool?(true);
								num = (short)1344077838;
								num4 = (int)((IntPtr)num);
								continue;
							case 21:
								goto IL_260;
							case 22:
								goto IL_718;
							case 23:
								if (flashportUpgradeFile.ComponentPresent(FixedLengthStream.b("꿦꿨볪뻬", a_)))
								{
									num = (short)1100611597;
									num4 = (int)((IntPtr)num);
									continue;
								}
								packageInfo.HfwsFlag = new int?(0);
								packageInfo.SoftwareVersion = flashportUpgradeFile.GetFileComponentVersion(FixedLengthStream.b("꿦꿨볪곬", a_), false);
								packageInfo.DspVersion = flashportUpgradeFile.GetFileComponentVersion(FixedLengthStream.b("ꏦ꿨볪곬", a_), true);
								packageInfo.PsdtVersion = flashportUpgradeFile.GetFileComponentVersion(FixedLengthStream.b("럦귨뿪곬", a_), true);
								num = (short)1826881565;
								num4 = (int)((IntPtr)num);
								continue;
							case 24:
							{
								bool flag = false;
								string fileTargetModelNumberForBBF = flashportUpgradeFile.GetFileTargetModelNumberForBBF();
								num = (short)156696592;
								num4 = (int)((IntPtr)num);
								continue;
							}
							case 25:
								if (BundleNameUtility.IsBBFFile(upgradeFilePath))
								{
									num = (short)1601765400;
									num4 = (int)((IntPtr)num);
									continue;
								}
								goto IL_6E0;
							case 26:
							{
								string fileTargetModelNumberForBBF;
								if (BundleNameUtility.IsFreonBundle(fileTargetModelNumberForBBF))
								{
									num = (short)655949844;
									num4 = (int)((IntPtr)num);
									continue;
								}
								goto IL_79E;
							}
							case 27:
								goto IL_262;
							case 28:
							{
								bool flag2 = flashportUpgradeFile.verifyBBFMagicNumber();
								if (flag2)
								{
									bool flag = flashportUpgradeFile.verifyChecksum();
								}
								packageInfo.SoftwareVersion = flashportUpgradeFile.GetBBFSuiteVersion();
								if (flag2)
								{
									num = (short)1389232128;
									num4 = (int)((IntPtr)num);
									continue;
								}
								goto IL_6FF;
							}
							case 29:
								goto IL_262;
							}
							IL_16D:
							if (flashportUpgradeFile == null)
							{
								num = (short)999555090;
								num4 = (int)((IntPtr)num);
								continue;
							}
							num = (short)2052849672;
							num4 = (int)((IntPtr)num);
							continue;
							IL_1B7:
							packageInfo.HfwsFlag = new int?(1);
							num = (short)1943863323;
							num4 = (int)((IntPtr)num);
							continue;
							IL_262:
							RMFile rmfile2 = new RMFile
							{
								Url = upgradeFilePath
							};
							packageInfo.RMFile = rmfile2;
							packageInfo.MaceFlashVersion = flashportUpgradeFile.GetFileComponentVersion(FixedLengthStream.b("ꓦ꿨볪ꓬ", a_), false);
							packageInfo.PackageVersion = packageInfo.SoftwareVersion;
							packageInfo.PackageName = Path.GetFileName(upgradeFilePath);
							packageInfo.ConBrdHwHostVersion = flashportUpgradeFile.GetFileComponentVersion(FixedLengthStream.b("ꓦꛨꗪ\udcec", a_), false);
							packageInfo.OptBrdHwHostVersion = flashportUpgradeFile.GetFileComponentVersion(FixedLengthStream.b("꣦ꯨ\udbea\udcec", a_), false);
							packageInfo.TargetModel = flashportUpgradeFile.GetFileTargetModelNumber();
							packageInfo.LTEOptBrdHwHostVersion = flashportUpgradeFile.GetFileComponentVersion(FixedLengthStream.b("꣦ꯨ\udbea\udfec", a_), false);
							packageInfo.IsFreonFirmwareUpgradeFile = new bool?(false);
							packageInfo.IsOMAPFirmwareUpgradeFile = new bool?(false);
							packageInfo.IsVirtualSummaryFirmware = new bool?(false);
							num = (short)1615003650;
							num4 = (int)((IntPtr)num);
							continue;
							IL_6FF:
							num = (short)46923798;
							num4 = (int)((IntPtr)num);
							continue;
							IL_79E:
							packageInfo.IsCompatible = !UpgradeRadioValidator.IsCPSVersionLowerThanFirmwareUpgradeVersion(packageInfo.PackageVersion, AppInfoManager.AppVersion);
							num = (short)229703685;
							num4 = (int)((IntPtr)num);
						}
						IL_18D:
						throw CommonExceptionHelper.CreateDirectMessageCommonException(AppResources.Failed_to_open.AcpStringFormat(new object[]
						{
							flashportUpgradeFile.UpgradeFilePath
						}));
						IL_260:
						throw CommonExceptionHelper.CreateDirectMessageCommonException(AppResources.UpgradeRadio_UFcanv.AcpStringFormat(new object[]
						{
							flashportUpgradeFile
						}));
						IL_3D8:
						throw CommonExceptionHelper.CreateDirectMessageCommonException(AppResources.Failed_to_open.AcpStringFormat(new object[]
						{
							flashportUpgradeFile.UpgradeFilePath
						}));
						IL_6E0:
						throw CommonExceptionHelper.CreateDirectMessageCommonException(AppResources.Failed_to_open.AcpStringFormat(new object[]
						{
							flashportUpgradeFile.UpgradeFilePath
						}));
						IL_718:
						throw CommonExceptionHelper.CreateDirectMessageCommonException(AppResources.UpgradeRadio_UFcanv.AcpStringFormat(new object[]
						{
							flashportUpgradeFile
						}));
						IL_7D1:;
					}
					catch (Exception)
					{
						throw CommonExceptionHelper.CreateDirectMessageCommonException(AppResources.Failed_to_open.AcpStringFormat(new object[]
						{
							flashportUpgradeFile.UpgradeFilePath
						}));
					}
					finally
					{
						GC.Collect();
					}
					break;
				}
				}
				break;
			}
			}
		}

		// Token: 0x060001E8 RID: 488 RVA: 0x0005F370 File Offset: 0x0005D570
		public void AnalyzeZipFirmwarePackage(string upgradeFilePath, ref ASTROFirmware packageInfo)
		{
			int a_ = 13;
			short num = (short)194969600;
			short num2 = num;
			num = (short)504126458;
			short num3 = num;
			num = (short)1150770170;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
				num = (short)1309212673;
				if (num != 0)
				{
				}
				num = (short)1241251840;
				if (num != 0)
				{
				}
				num = (short)1398996992;
				switch (num)
				{
				default:
				{
					FlashportUpgradeFile flashportUpgradeFile = new FlashportUpgradeFile(upgradeFilePath);
					try
					{
						num = (short)541720580;
						int num4 = (int)((IntPtr)num);
						for (;;)
						{
							string text;
							MetadataFile metadataFile;
							string metadata;
							string cvnHostVersion;
							switch (num4)
							{
							case 0:
								text = FixedLengthStream.b("뿬\udfee쇰\uddf2열쟶ퟸ쯺췼쿾", a_);
								goto IL_2C4;
							case 1:
								if (MetadataFileValidator.VerifyIsTargetDevice(metadataFile, FixedLengthStream.b("賬菮黰鯲铴", a_)))
								{
									num = (short)403898379;
									num4 = (int)((IntPtr)num);
									continue;
								}
								num = (short)2029977610;
								num4 = (int)((IntPtr)num);
								continue;
							case 2:
								goto IL_405;
							case 3:
								goto IL_405;
							case 4:
								switch (0)
								{
								case 0:
									goto IL_122;
								}
								continue;
							case 5:
							{
								long value;
								packageInfo.BuildTimestamp = (long.TryParse(metadataFile.PostTimestamp, out value) ? new long?(value) : null);
								packageInfo.PackageName = Path.GetFileName(upgradeFilePath);
								packageInfo.TargetModel = metadataFile.TargetDevice;
								packageInfo.IsFreonFirmwareUpgradeFile = new bool?(true);
								packageInfo.IsOMAPFirmwareUpgradeFile = new bool?(false);
								packageInfo.IsVirtualSummaryFirmware = new bool?(false);
								packageInfo.TargetRelease = metadataFile.TargetRelease;
								packageInfo.MaxCodeplugVersion = ReleaseToCodeplugMapper.GetMaxSupportedCodeplug(metadataFile.TargetRelease);
								packageInfo.Metadata = metadata;
								num = (short)1629880328;
								num4 = (int)((IntPtr)num);
								continue;
							}
							case 6:
								goto IL_41E;
							case 7:
								MetadataFileValidator.VerifyAllowedTargetDevice(metadataFile, FixedLengthStream.b("賬苮臰", a_));
								packageInfo.IsCompatible = !UpgradeRadioValidator.IsCPSVersionLowerThanFirmwareUpgradeVersion(cvnHostVersion, AppInfoManager.AppVersion);
								num = (short)917110786;
								num4 = (int)((IntPtr)num);
								continue;
							case 8:
								if ((text = packageInfo.MaxCodeplugVersion) == null)
								{
									num = (short)95420416;
									num4 = (int)((IntPtr)num);
									continue;
								}
								goto IL_2C4;
							case 9:
								goto IL_13B;
							case 10:
								if (MetadataFileValidator.VerifyIsTargetDevice(metadataFile, FixedLengthStream.b("賬苮臰", a_)))
								{
									num = (short)1126498311;
									num4 = (int)((IntPtr)num);
									continue;
								}
								goto IL_3E6;
							case 11:
								MetadataFileValidator.VerifyAllowedTargetDevice(metadataFile, FixedLengthStream.b("賬菮黰鯲铴", a_));
								packageInfo.IsCompatible = !UpgradeRadioValidator.IsCPSVersionLowerThanFirmwareUpgradeVersion(cvnHostVersion, AppInfoManager.AppVersion);
								num = (short)923664387;
								num4 = (int)((IntPtr)num);
								continue;
							}
							IL_122:
							if (flashportUpgradeFile == null)
							{
								num = (short)1918107657;
								num4 = (int)((IntPtr)num);
								continue;
							}
							this._firmwareFileValidator.VerifyFirmwareContent(upgradeFilePath);
							metadata = MetadataFileParser.ExtractMetadata(upgradeFilePath);
							metadataFile = MetadataFileParser.ParseMetadata(metadata);
							MetadataFileValidator.VerifyMetadataFileContent(metadataFile);
							RMFile rmfile = new RMFile
							{
								Url = upgradeFilePath
							};
							packageInfo.RMFile = rmfile;
							packageInfo.PackageVersion = metadataFile.PostBuildIncremental;
							packageInfo.SoftwareVersion = metadataFile.PostBuildIncremental;
							packageInfo.BPSoftwareVersion = metadataFile.BpFirmware;
							packageInfo.BaseSoftwareVersion = metadataFile.PreBuildIncremental;
							num = (short)38928389;
							num4 = (int)((IntPtr)num);
							continue;
							IL_2C4:
							cvnHostVersion = text;
							num = (short)266207233;
							num4 = (int)((IntPtr)num);
							continue;
							IL_405:
							num = (short)1495400454;
							num4 = (int)((IntPtr)num);
						}
						IL_13B:
						throw CommonExceptionHelper.CreateDirectMessageCommonException(AppResources.Failed_to_open.AcpStringFormat(new object[]
						{
							flashportUpgradeFile.UpgradeFilePath
						}));
						IL_3E6:
						throw CommonExceptionHelper.CreateDirectMessageCommonException(AppResources.Failed_to_open.AcpStringFormat(new object[]
						{
							flashportUpgradeFile.UpgradeFilePath
						}));
						IL_41E:;
					}
					catch (Exception)
					{
						throw CommonExceptionHelper.CreateDirectMessageCommonException(AppResources.Failed_to_open.AcpStringFormat(new object[]
						{
							flashportUpgradeFile.UpgradeFilePath
						}));
					}
					break;
				}
				}
				break;
			}
		}

		// Token: 0x060001E9 RID: 489 RVA: 0x0005F7DC File Offset: 0x0005D9DC
		public IList<ASTROFirmware> AnaysisListFirmwarePackage(string upgradeFilePath)
		{
			int a_ = 11;
			short num = (short)1966735361;
			if (num != 0)
			{
			}
			num = (short)1049755648;
			switch (num)
			{
			default:
			{
				num = (short)2065432576;
				short num2 = num;
				IList<ASTROFirmware> list = new List<ASTROFirmware>();
				FlashportUpgradeFile flashportUpgradeFile = new FlashportUpgradeFile(upgradeFilePath);
				try
				{
					num = (short)114360327;
					int num3 = (int)((IntPtr)num);
					for (;;)
					{
						IList<string> list2;
						IEnumerator<string> enumerator;
						switch (num3)
						{
						case 0:
							goto IL_125;
						case 1:
							if (list2.Count > 0)
							{
								num = (short)712769557;
								num3 = (int)((IntPtr)num);
								continue;
							}
							goto IL_3BD;
						case 2:
						{
							ASTROFirmware item = new ASTROFirmware();
							this.AnalyzeZipFirmwarePackage(upgradeFilePath, ref item);
							list.Add(item);
							num = (short)587857933;
							num3 = (int)((IntPtr)num);
							continue;
						}
						case 3:
							if (BundleNameUtility.IsZIPFile(upgradeFilePath))
							{
								num = (short)1355022338;
								num3 = (int)((IntPtr)num);
								continue;
							}
							goto IL_273;
						case 4:
							num = (short)947322881;
							num3 = (int)((IntPtr)num);
							continue;
						case 5:
							if (BundleNameUtility.IsBBFFile(upgradeFilePath))
							{
								num = (short)1810432011;
								num3 = (int)((IntPtr)num);
								continue;
							}
							num = (short)495452163;
							num3 = (int)((IntPtr)num);
							continue;
						case 6:
							goto IL_7F1;
						case 7:
							switch (0)
							{
							case 0:
								goto IL_108;
							}
							continue;
						case 8:
						{
							try
							{
								num = (short)860422146;
								num3 = (int)((IntPtr)num);
								for (;;)
								{
									switch (num3)
									{
									case 0:
									{
										if (!enumerator.MoveNext())
										{
											num = (short)1845690369;
											num3 = (int)((IntPtr)num);
											continue;
										}
										string upgradeFilePath2 = enumerator.Current;
										ASTROFirmware astrofirmware = new ASTROFirmware();
										RMCWnd.AnalysisFirmwarePackage(upgradeFilePath2, ref astrofirmware);
										astrofirmware.IsSubFirmware = new bool?(true);
										list.Add(astrofirmware);
										num = (short)1428750339;
										num3 = (int)((IntPtr)num);
										continue;
									}
									case 1:
										num = (short)171507716;
										num3 = (int)((IntPtr)num);
										continue;
									case 2:
										switch (0)
										{
										case 0:
											goto IL_5F0;
										}
										continue;
									case 4:
										goto IL_685;
									}
									IL_633:
									num = (short)210829312;
									num3 = (int)((IntPtr)num);
									continue;
									IL_5F0:
									goto IL_633;
								}
								IL_685:;
							}
							finally
							{
								num = (short)1027342337;
								num3 = (int)((IntPtr)num);
								for (;;)
								{
									switch (num3)
									{
									case 0:
										enumerator.Dispose();
										num = (short)454950914;
										num3 = (int)((IntPtr)num);
										continue;
									case 1:
										switch (0)
										{
										case 0:
											goto IL_6B9;
										}
										continue;
									case 2:
										goto IL_6F2;
									}
									IL_6B9:
									if (enumerator == null)
									{
										break;
									}
									num = (short)1388642304;
									num3 = (int)((IntPtr)num);
								}
								IL_6F2:;
							}
							IEnumerator<ASTROFirmware> enumerator2 = list.GetEnumerator();
							num = (short)1596588044;
							num3 = (int)((IntPtr)num);
							continue;
						}
						case 9:
						{
							string fileTargetModelNumberForBBF;
							if (BundleNameUtility.IsMegaBundle(fileTargetModelNumberForBBF))
							{
								num = (short)919666698;
								num3 = (int)((IntPtr)num);
								continue;
							}
							goto IL_179;
						}
						case 10:
							list2 = RMCWnd.SeparateMegaBBF(upgradeFilePath);
							num = (short)1170669587;
							num3 = (int)((IntPtr)num);
							continue;
						case 11:
						{
							string fileTargetModelNumberForBBF = flashportUpgradeFile.GetFileTargetModelNumberForBBF();
							string bbfsuiteVersion = flashportUpgradeFile.GetBBFSuiteVersion();
							num = (short)1194983439;
							num3 = (int)((IntPtr)num);
							continue;
						}
						case 12:
						{
							string bbfsuiteVersion;
							try
							{
								num = (short)65208321;
								num3 = (int)((IntPtr)num);
								for (;;)
								{
									switch (num3)
									{
									case 0:
									{
										ASTROFirmware astrofirmware2;
										if (!bbfsuiteVersion.Equals(astrofirmware2.PackageVersion))
										{
											num = (short)324075522;
											num3 = (int)((IntPtr)num);
											continue;
										}
										break;
									}
									case 1:
										switch (0)
										{
										case 0:
											goto IL_41A;
										}
										continue;
									case 2:
										goto IL_49A;
									case 3:
									{
										IEnumerator<ASTROFirmware> enumerator2;
										if (!enumerator2.MoveNext())
										{
											num = (short)990904324;
											num3 = (int)((IntPtr)num);
											continue;
										}
										ASTROFirmware astrofirmware2 = enumerator2.Current;
										num = (short)98107392;
										num3 = (int)((IntPtr)num);
										continue;
									}
									case 4:
										num = (short)589561861;
										num3 = (int)((IntPtr)num);
										continue;
									case 5:
										goto IL_4D3;
									}
									IL_41C:
									num = (short)916062211;
									num3 = (int)((IntPtr)num);
									continue;
									IL_41A:
									goto IL_41C;
								}
								IL_49A:
								throw new Exception(FixedLengthStream.b("꣪苬苮鳰鳲鯴ꗶ뿸ꧺ飼賾渀瘂眄搆氈砊⌌䤎瀐稒礔爖紘䐚検瀞縠䰢唤䈦䜨ᄪബ", a_) + flashportUpgradeFile.UpgradeFilePath);
								IL_4D3:
								goto IL_75B;
							}
							finally
							{
								num = (short)2100625409;
								num3 = (int)((IntPtr)num);
								for (;;)
								{
									IEnumerator<ASTROFirmware> enumerator2;
									switch (num3)
									{
									case 0:
										enumerator2.Dispose();
										num = (short)219217922;
										num3 = (int)((IntPtr)num);
										continue;
									case 1:
									{
										num = (short)1490857925;
										short num4 = num;
										num = (short)946646981;
										switch ((num4 == num) ? 1 : 0)
										{
										case 0:
										case 2:
											break;
										default:
											num = (short)1921515520;
											if (num != 0)
											{
											}
											switch (0)
											{
											case 0:
												goto IL_557;
											}
											continue;
										}
										break;
									}
									case 2:
										goto IL_58F;
									}
									IL_557:
									if (enumerator2 == null)
									{
										break;
									}
									num = (short)281346048;
									num3 = (int)((IntPtr)num);
								}
								IL_58F:;
							}
							goto IL_592;
							IL_75B:
							ASTROFirmware astrofirmware3 = new ASTROFirmware();
							astrofirmware3.SoftwareVersion = bbfsuiteVersion;
							astrofirmware3.PackageVersion = astrofirmware3.SoftwareVersion;
							astrofirmware3.PackageName = Path.GetFileName(upgradeFilePath);
							astrofirmware3.TargetModel = FixedLengthStream.b("諪鷬韮껰郲藴蓶", a_);
							astrofirmware3.IsOMAPFirmwareUpgradeFile = new bool?(true);
							astrofirmware3.IsFreonFirmwareUpgradeFile = new bool?(true);
							astrofirmware3.IsVirtualSummaryFirmware = new bool?(true);
							astrofirmware3.IsSubFirmware = new bool?(false);
							list.Add(astrofirmware3);
							num = (short)950140950;
							num3 = (int)((IntPtr)num);
							continue;
						}
						case 13:
							goto IL_7F1;
						case 14:
						{
							ASTROFirmware item2 = new ASTROFirmware();
							RMCWnd.AnalysisFirmwarePackage(upgradeFilePath, ref item2);
							list.Add(item2);
							num = (short)230752276;
							num3 = (int)((IntPtr)num);
							continue;
						}
						case 15:
						{
							string fileTargetModelNumberForBBF;
							if (BundleNameUtility.IsBBFBundle(fileTargetModelNumberForBBF))
							{
								num = (short)1533018126;
								num3 = (int)((IntPtr)num);
								continue;
							}
							num = (short)1082982409;
							num3 = (int)((IntPtr)num);
							continue;
						}
						case 16:
							goto IL_809;
						case 17:
							if (BundleNameUtility.IsCVNFile(upgradeFilePath))
							{
								num = (short)456589330;
								num3 = (int)((IntPtr)num);
								continue;
							}
							num = (short)5111813;
							num3 = (int)((IntPtr)num);
							continue;
						case 18:
						{
							ASTROFirmware item3 = new ASTROFirmware();
							RMCWnd.AnalysisFirmwarePackage(upgradeFilePath, ref item3);
							list.Add(item3);
							num = (short)546242566;
							num3 = (int)((IntPtr)num);
							continue;
						}
						case 19:
							if (list2 != null)
							{
								num = (short)196608004;
								num3 = (int)((IntPtr)num);
								continue;
							}
							goto IL_3BD;
						case 20:
							goto IL_7F1;
						case 21:
							goto IL_592;
						case 22:
							goto IL_7F1;
						}
						IL_108:
						if (flashportUpgradeFile == null)
						{
							num = (short)1343946752;
							num3 = (int)((IntPtr)num);
							continue;
						}
						num = (short)1355153425;
						num3 = (int)((IntPtr)num);
						continue;
						IL_592:
						enumerator = list2.GetEnumerator();
						num = (short)790233096;
						num3 = (int)((IntPtr)num);
						continue;
						IL_7F1:
						num = (short)2055405584;
						num3 = (int)((IntPtr)num);
					}
					IL_125:
					throw CommonExceptionHelper.CreateDirectMessageCommonException(AppResources.Failed_to_open.AcpStringFormat(new object[]
					{
						flashportUpgradeFile.UpgradeFilePath
					}));
					IL_179:
					throw CommonExceptionHelper.CreateDirectMessageCommonException(AppResources.Failed_to_open.AcpStringFormat(new object[]
					{
						flashportUpgradeFile.UpgradeFilePath
					}));
					IL_273:
					throw CommonExceptionHelper.CreateDirectMessageCommonException(AppResources.Failed_to_open.AcpStringFormat(new object[]
					{
						flashportUpgradeFile.UpgradeFilePath
					}));
					IL_3BD:
					throw CommonExceptionHelper.CreateDirectMessageCommonException(AppResources.Failed_to_open.AcpStringFormat(new object[]
					{
						flashportUpgradeFile.UpgradeFilePath
					}));
					IL_809:;
				}
				catch (Exception)
				{
					throw CommonExceptionHelper.CreateDirectMessageCommonException(AppResources.Failed_to_open.AcpStringFormat(new object[]
					{
						flashportUpgradeFile.UpgradeFilePath
					}));
				}
				return list;
			}
			}
		}

		// Token: 0x060001EA RID: 490 RVA: 0x00060064 File Offset: 0x0005E264
		private static IList<string> SeparateMegaBBF(string upgradeFilePath)
		{
			int a_ = 12;
			short num = (short)1263534080;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_A5;
				}
				FlashportUpgradeFile flashportUpgradeFile;
				bool flag2;
				IList<string> list;
				for (;;)
				{
					IL_30:
					num = (short)75730474;
					short num3 = num;
					num = (short)953585194;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num = (short)1076494336;
						if (num != 0)
						{
						}
						switch (num2)
						{
						case 0:
							goto IL_432;
						case 1:
						{
							bool flag = flashportUpgradeFile.verifyBBFMagicNumber();
							if (flag)
							{
								flag2 = flashportUpgradeFile.verifyChecksum();
							}
							if (flag)
							{
								num = (short)150536199;
								num2 = (int)((IntPtr)num);
								continue;
							}
							goto IL_3DE;
						}
						case 2:
						{
							if (!flag2)
							{
								num = (short)1612775424;
								num2 = (int)((IntPtr)num);
								continue;
							}
							Dictionary<string, byte[]> allSectionsData = flashportUpgradeFile.GetAllSectionsData();
							num = (short)1189740547;
							num2 = (int)((IntPtr)num);
							continue;
						}
						case 3:
						{
							Dictionary<string, byte[]> allSectionsData;
							if (allSectionsData != null)
							{
								num = (short)2131492872;
								num2 = (int)((IntPtr)num);
								continue;
							}
							goto IL_3BF;
						}
						case 4:
						{
							Dictionary<string, byte[]> allSectionsData;
							if (allSectionsData.Keys.Count > 0)
							{
								num = (short)914948102;
								num2 = (int)((IntPtr)num);
								continue;
							}
							goto IL_3BF;
						}
						case 5:
							try
							{
								num = (short)523829251;
								num2 = (int)((IntPtr)num);
								for (;;)
								{
									string text;
									string text2;
									switch (num2)
									{
									case 0:
									{
										Dictionary<string, byte[]>.KeyCollection.Enumerator enumerator;
										if (!enumerator.MoveNext())
										{
											num = (short)653131784;
											num2 = (int)((IntPtr)num);
											continue;
										}
										text = enumerator.Current;
										string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData), FixedLengthStream.b("ꇫ臭蓯鷱蛳駵铷鯹ꃻ뷽濿漁椃椅昇䤉尋崍䰏弑焓焕礗", a_));
										text2 = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData), FixedLengthStream.b("ꇫ臭蓯鷱蛳駵铷鯹ꃻ뷽濿漁椃椅昇䤉尋崍䰏弑焓焕礗", a_), text);
										num = (short)730857477;
										num2 = (int)((IntPtr)num);
										continue;
									}
									case 1:
										goto IL_16D;
									case 3:
										switch (0)
										{
										case 0:
											goto IL_131;
										}
										continue;
									case 4:
										if (File.Exists(text2))
										{
											num = (short)2133393417;
											num2 = (int)((IntPtr)num);
											continue;
										}
										goto IL_29D;
									case 5:
									{
										string path;
										if (!Directory.Exists(path))
										{
											num = (short)754778119;
											num2 = (int)((IntPtr)num);
											continue;
										}
										goto IL_16D;
									}
									case 6:
										num = (short)2090074113;
										if (num != 0)
										{
										}
										goto IL_29D;
									case 7:
									{
										string path;
										Directory.CreateDirectory(path);
										num = (short)1758658561;
										num2 = (int)((IntPtr)num);
										continue;
									}
									case 8:
										num = (short)953745418;
										num2 = (int)((IntPtr)num);
										continue;
									case 9:
										File.Delete(text2);
										num = (short)812187654;
										num2 = (int)((IntPtr)num);
										continue;
									case 10:
										goto IL_2EA;
									}
									IL_133:
									num = (short)505151488;
									num2 = (int)((IntPtr)num);
									continue;
									IL_131:
									goto IL_133;
									IL_16D:
									num = (short)45154308;
									num2 = (int)((IntPtr)num);
									continue;
									IL_29D:
									Dictionary<string, byte[]> allSectionsData;
									File.WriteAllBytes(text2, allSectionsData[text]);
									list.Add(text2);
									num = (short)1373372418;
									num2 = (int)((IntPtr)num);
								}
								IL_2EA:
								return list;
							}
							finally
							{
								Dictionary<string, byte[]>.KeyCollection.Enumerator enumerator;
								((IDisposable)enumerator).Dispose();
							}
							goto IL_2FD;
						case 6:
						{
							Dictionary<string, byte[]> allSectionsData;
							Dictionary<string, byte[]>.KeyCollection.Enumerator enumerator = allSectionsData.Keys.GetEnumerator();
							num = (short)1685979141;
							num2 = (int)((IntPtr)num);
							continue;
						}
						case 7:
							goto IL_360;
						case 8:
							goto IL_2FD;
						}
						goto IL_A5;
						IL_2FD:
						num = (short)455999492;
						num2 = (int)((IntPtr)num);
						continue;
					}
					IL_360:
					num = (short)437190656;
					short num4 = num;
					num = (short)1039859714;
					num2 = (int)((IntPtr)num);
				}
				IL_3BF:
				throw CommonExceptionHelper.CreateDirectMessageCommonException(AppResources.Failed_to_open.AcpStringFormat(new object[]
				{
					flashportUpgradeFile.UpgradeFilePath
				}));
				IL_3DE:
				throw CommonExceptionHelper.CreateDirectMessageCommonException(AppResources.Failed_to_open.AcpStringFormat(new object[]
				{
					flashportUpgradeFile.UpgradeFilePath
				}));
				IL_432:
				goto IL_3DE;
				IL_A5:
				list = new List<string>();
				flashportUpgradeFile = new FlashportUpgradeFile(upgradeFilePath);
				flag2 = false;
				num = (short)173342721;
				num2 = (int)((IntPtr)num);
				goto IL_30;
			}
			}
		}

		// Token: 0x060001EB RID: 491 RVA: 0x00060508 File Offset: 0x0005E708
		private ResultStatus UpdateCodeplug(APXTemplate targetTemplate, string sFileName, string flashcode, string modelNumber, string iButtonSerialNumber, string radioHostVersion, string cvnHostVersion, bool bRefresh, OwnerSystemData systemID, out HOptionAdvancedKeyIDS keyIDS, ASTROFirmware astroFirmware)
		{
			short num = (short)543424512;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_42;
				}
				ResultStatus resultStatus;
				WindowMain windowMain;
				ApplicationMode CPSMode;
				for (;;)
				{
					IL_27:
					switch (num2)
					{
					case 0:
						try
						{
							num = (short)293404680;
							num2 = (int)((IntPtr)num);
							for (;;)
							{
								FlashCodeplug flashCodeplug;
								UpgradeRadio upgradeRadio;
								switch (num2)
								{
								case 0:
									goto IL_190;
								case 1:
									CommonUtility.PopulateTemplateColumnsFromDatabaseLayer(targetTemplate);
									num = (short)1935867923;
									num2 = (int)((IntPtr)num);
									continue;
								case 2:
									goto IL_451;
								case 3:
									UtilityMack.bOpenFromRMC = true;
									flashCodeplug = new FlashCodeplug();
									flashCodeplug.postCodeplugInitialization();
									upgradeRadio = new UpgradeRadio(null, bRefresh, modelNumber, radioHostVersion, cvnHostVersion, astroFirmware);
									upgradeRadio.PreUpgradeCodeplugHandler();
									upgradeRadio.SetDeviceInfoField();
									num = (short)50003973;
									num2 = (int)((IntPtr)num);
									continue;
								case 4:
									resultStatus.Result = flashCodeplug.UpgradeCodeplug(modelNumber, flashcode, false, true, systemID);
									keyIDS = flashCodeplug.keyIDS;
									num = (short)448462861;
									num2 = (int)((IntPtr)num);
									continue;
								case 5:
									if (!bRefresh)
									{
										num = (short)597032964;
										num2 = (int)((IntPtr)num);
										continue;
									}
									resultStatus.Result = true;
									num = (short)703201292;
									num2 = (int)((IntPtr)num);
									continue;
								case 6:
									goto IL_306;
								case 7:
									resultStatus = windowMain.PromptQuitOnInvalids();
									resultStatus.Result = !resultStatus.Result;
									num = (short)802357263;
									num2 = (int)((IntPtr)num);
									continue;
								case 8:
									switch (0)
									{
									case 0:
										goto IL_142;
									}
									continue;
								case 9:
									upgradeRadio.PostUpgradeCodeplugHandler(flashcode);
									upgradeRadio.ApplyModelTiering();
									ConstraintManager.Suspend();
									num = (short)1697251338;
									num2 = (int)((IntPtr)num);
									continue;
								case 10:
									goto IL_306;
								case 11:
									goto IL_190;
								case 12:
									goto IL_28C;
								case 13:
									goto IL_28C;
								case 14:
									if (resultStatus.Result)
									{
										num = (short)1259536391;
										num2 = (int)((IntPtr)num);
										continue;
									}
									goto IL_190;
								case 15:
									if (resultStatus.Result)
									{
										num = (short)1028522000;
										num2 = (int)((IntPtr)num);
										continue;
									}
									MessageBox.Show(resultStatus.ResultMessage, Motorola.CommonCPS.ResourceRepository.Resources.RMC_PM_UpgradeCodeplugFailed, MessageBoxButton.OK);
									num = (short)567803915;
									num2 = (int)((IntPtr)num);
									continue;
								case 16:
									windowMain.OnAppMenuSaveAsNonGUI(this, null, sFileName);
									num = (short)1356464128;
									num2 = (int)((IntPtr)num);
									continue;
								case 17:
									if (!string.IsNullOrEmpty(cvnHostVersion))
									{
										num = (short)1647116297;
										num2 = (int)((IntPtr)num);
										continue;
									}
									upgradeRadio.SetActionTypeAfterUpgrade();
									upgradeRadio.SyncActiveMicForBTPTT();
									upgradeRadio.RefreshAESFields();
									num = (short)2115239942;
									num2 = (int)((IntPtr)num);
									continue;
								case 18:
									if (!bRefresh)
									{
										num = (short)739835905;
										num2 = (int)((IntPtr)num);
										continue;
									}
									goto IL_437;
								case 19:
									goto IL_437;
								}
								IL_142:
								if (windowMain.OpenCodeplugNonGUI(sFileName, null, true, true))
								{
									num = (short)1139998723;
									num2 = (int)((IntPtr)num);
									continue;
								}
								goto IL_437;
								IL_190:
								num = (short)1691877394;
								num2 = (int)((IntPtr)num);
								continue;
								IL_28C:
								num = (short)956104721;
								num2 = (int)((IntPtr)num);
								continue;
								IL_306:
								upgradeRadio.ApplyModelTiering();
								flashCodeplug.SetPostFlashCodeplugFields(iButtonSerialNumber);
								num = (short)1560018958;
								num2 = (int)((IntPtr)num);
								continue;
								IL_437:
								num = (short)716111874;
								num2 = (int)((IntPtr)num);
							}
							IL_451:
							return resultStatus;
						}
						catch (IOException)
						{
							throw new CommonException(new CommonExceptionData(CommonErrorCode.RMC_UnableToReadTheFollowingArchive, new string[]
							{
								sFileName
							}));
						}
						catch (CommonException)
						{
							throw;
						}
						catch (UpgradeRadioException ex)
						{
							if (ex.Message.Contains(string.Format(AppResources.is_an_invalid_flashcode, flashcode)))
							{
								throw new CommonException(new CommonExceptionData(CommonErrorCode.RMC_invalid_flashcode, new string[]
								{
									flashcode
								}));
							}
							throw CommonExceptionHelper.CreateCommonException(CommonErrorCode.RMC_PM_UpgradeCodeplugFailed, Motorola.CommonCPS.ResourceRepository.Resources.RMC_PM_UpgradeCodeplugFailed, null);
						}
						catch (Exception)
						{
							throw CommonExceptionHelper.CreateCommonException(CommonErrorCode.RMC_PM_UpgradeCodeplugFailed, Motorola.CommonCPS.ResourceRepository.Resources.RMC_PM_UpgradeCodeplugFailed, null);
						}
						finally
						{
							num = (short)31816168;
							short num3 = num;
							num = (short)166885864;
							switch ((num3 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								IL_566:
								windowMain.CloseFileNonGUI(true);
								num = (short)2052063233;
								num2 = (int)((IntPtr)num);
								break;
							default:
								num = (short)734134272;
								if (num != 0)
								{
								}
								num = (short)2116681730;
								num2 = (int)((IntPtr)num);
								break;
							}
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_564;
								case 1:
									goto IL_582;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_547;
									}
									continue;
								}
								IL_547:
								if (!windowMain.CanOpenCpgFlag)
								{
									goto IL_584;
								}
								num = (short)847052800;
								num2 = (int)((IntPtr)num);
							}
							IL_564:
							goto IL_566;
							IL_582:
							IL_584:
							base.Dispatcher.Invoke(delegate()
							{
								short num5 = (short)2120351744;
								short num6 = num5;
								num5 = (short)536229150;
								short num7 = num5;
								num5 = (short)332739870;
								switch (num7 == num5)
								{
								}
								num5 = (short)792395776;
								if (num5 != 0)
								{
								}
								num5 = (short)2111700993;
								if (num5 != 0)
								{
								}
								AppInfoManager.AppMode = CPSMode;
							});
						}
						goto IL_59C;
					case 1:
						if (windowMain.ReadWriteInProgress)
						{
							num = (short)724566016;
							short num4 = num;
							num = (short)877068290;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_59C;
					case 2:
						goto IL_620;
					case 3:
						if (windowMain.CanOpenCpgFlag)
						{
							num = (short)1845952513;
							if (num != 0)
							{
							}
							num = (short)537329668;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_622;
					case 4:
						num = (short)554958849;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_42;
					IL_59C:
					num = (short)461176832;
					num2 = (int)((IntPtr)num);
				}
				IL_620:
				IL_622:
				throw CommonExceptionHelper.CreateCommonException(CommonErrorCode.RMC_HasCodeplugOpened, Motorola.CommonCPS.ResourceRepository.Resources.RMC_HasCodeplugOpened, null);
				IL_42:
				resultStatus = new ResultStatus();
				keyIDS = null;
				CPSMode = AppInfoManager.AppMode;
				windowMain = this.GetWindowMain();
				num = (short)1068826627;
				num2 = (int)((IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x060001EC RID: 492 RVA: 0x00060BC8 File Offset: 0x0005EDC8
		private void RMCWnd_PopulateRadioFeaturesFromCodeplugEvtHandler(object sender, PopulateRadioFeaturesFromCodeplugEventArgs e)
		{
			short num;
			for (;;)
			{
				string text = "";
				try
				{
					num = (short)1098907649;
					if (num != 0)
					{
					}
					text = SpecialFeatures.Flashport.FlashRadio.FlashcodeFormatter.FormatFlashcodeString(e.AstroPurchasedFlashCode, e.AstroPurchasedFlashCode.Length);
					List<RadioFeatureRequest> featuresRequest = this.ListFeatureSet(text, e.ModelNumber);
					e.featuresRequest = featuresRequest;
				}
				catch (CommonException)
				{
					throw;
				}
				catch (Exception)
				{
					throw CommonExceptionHelper.CreateDirectMessageCommonException(AppResources.is_an_invalid_flashcode.AcpStringFormat(new object[]
					{
						text
					}));
				}
				num = (short)903275432;
				short num2 = num;
				num = (short)74703784;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					goto IL_AF;
				}
			}
			IL_AF:
			num = (short)1532166144;
			if (num != 0)
			{
			}
			num = (short)554369024;
			short num3 = num;
		}

		// Token: 0x060001ED RID: 493 RVA: 0x00060CE0 File Offset: 0x0005EEE0
		private void RMCWnd_PopulateRadioFeaturesFromFlashCodeEvtHandler(object sender, PopulateRadioFeaturesFromFlashCodeEventArgs e)
		{
			short num;
			for (;;)
			{
				string text = "";
				try
				{
					text = SpecialFeatures.Flashport.FlashRadio.FlashcodeFormatter.FormatFlashcodeString(e.FlashCode, e.FlashCode.Length);
					e.RadioFeaturesRequest = this.ListFeatureSet(text, e.ModelNumber);
				}
				catch (CommonException)
				{
					throw;
				}
				catch (Exception)
				{
					throw CommonExceptionHelper.CreateDirectMessageCommonException(AppResources.is_an_invalid_flashcode.AcpStringFormat(new object[]
					{
						text
					}));
				}
				num = (short)1397278194;
				short num2 = num;
				num = (short)276415986;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					goto IL_84;
				}
			}
			IL_84:
			num = (short)1705050113;
			if (num != 0)
			{
			}
			num = (short)864026624;
			if (num != 0)
			{
			}
			num = (short)1774518272;
			short num3 = num;
		}

		// Token: 0x060001EE RID: 494 RVA: 0x00060DF4 File Offset: 0x0005EFF4
		private List<RadioFeatureRequest> ListFeatureSet(string flashCode, string modelNumber)
		{
			short num;
			try
			{
				num = (short)346226688;
				switch (num)
				{
				default:
					new ModelTiering(modelNumber, ModelTiering.ActionTypes.NONE, ModelTiering.TargetTypes.ALL, false).UpdateUtilityMackModelType();
					goto IL_255;
				}
			}
			catch (Exception)
			{
				throw CommonExceptionHelper.CreateDirectMessageCommonException(AppResources.Invalid_radio_model_number.AcpStringFormat(new object[]
				{
					modelNumber
				}));
			}
			List<RadioFeatureRequest> list;
			try
			{
				IL_4C:
				FlashcodeTable flashcodeTable;
				flashcodeTable.InitTable(false, modelNumber, false);
				IEnumerator<Option> enumerator = flashcodeTable.FLASHcode.GetEnumerator();
				try
				{
					num = (short)1734082562;
					int num2 = (int)((IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 1:
						{
							Option option;
							if (flashcodeTable.IsOptionEnabledInFlashcode(option, flashCode))
							{
								num = (short)137822212;
								num2 = (int)((IntPtr)num);
								continue;
							}
							break;
						}
						case 2:
							switch (0)
							{
							case 0:
								goto IL_A5;
							}
							continue;
						case 3:
							goto IL_179;
						case 4:
						{
							Option option;
							RadioFeatureRequest item = new RadioFeatureRequest((int)option.OptionID, FeatureStatus.Active, null, null, "", true);
							list.Add(item);
							num = (short)1024131072;
							num2 = (int)((IntPtr)num);
							continue;
						}
						case 5:
						{
							if (!enumerator.MoveNext())
							{
								num = (short)734724102;
								num2 = (int)((IntPtr)num);
								continue;
							}
							Option option = enumerator.Current;
							num = (short)1288699905;
							num2 = (int)((IntPtr)num);
							continue;
						}
						case 6:
							num = (short)897712131;
							num2 = (int)((IntPtr)num);
							continue;
						}
						IL_E6:
						num = (short)551485445;
						num2 = (int)((IntPtr)num);
						continue;
						IL_A5:
						goto IL_E6;
					}
					IL_179:
					goto IL_2DD;
				}
				finally
				{
					num = (short)444792832;
					int num2 = (int)((IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
							switch (0)
							{
							case 0:
								goto IL_1B2;
							}
							continue;
						case 1:
							enumerator.Dispose();
							num = (short)473825282;
							num2 = (int)((IntPtr)num);
							continue;
						case 2:
							goto IL_1E8;
						}
						IL_1B2:
						if (enumerator == null)
						{
							break;
						}
						num = (short)819396609;
						num2 = (int)((IntPtr)num);
					}
					IL_1E8:;
				}
			}
			finally
			{
				num = (short)797638656;
				int num2 = (int)((IntPtr)num);
				for (;;)
				{
					FlashcodeTable flashcodeTable;
					switch (num2)
					{
					case 0:
						switch (0)
						{
						case 0:
							goto IL_21D;
						}
						continue;
					case 1:
						((IDisposable)flashcodeTable).Dispose();
						num = (short)134807554;
						num2 = (int)((IntPtr)num);
						continue;
					case 2:
						goto IL_252;
					}
					IL_21D:
					if (flashcodeTable == null)
					{
						break;
					}
					num = (short)82378753;
					num2 = (int)((IntPtr)num);
				}
				IL_252:;
			}
			IL_255:
			num = (short)40435713;
			if (num != 0)
			{
			}
			num = (short)1121536046;
			short num3 = num;
			num = (short)1790461998;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
			{
				IL_2DD:
				num = (short)2091843584;
				short num4 = num;
				return list;
			}
			default:
			{
				num = (short)1003421696;
				if (num != 0)
				{
				}
				bool isPortablePro = UtilityMack.IsPortablePro;
				list = new List<RadioFeatureRequest>();
				FlashcodeTable flashcodeTable = new FlashcodeTable(isPortablePro, true);
				goto IL_4C;
			}
			}
		}

		// Token: 0x060001EF RID: 495 RVA: 0x00061154 File Offset: 0x0005F354
		private void RMCWnd_QueryUpdateRadioEvtHandler(object sender, QueryUpdateRadioEventArgs e)
		{
			short num = (short)869335040;
			short num2 = num;
			num = (short)17947330;
			short num3 = num;
			num = (short)955505346;
			switch (num3 == num)
			{
			}
			num = (short)520028160;
			if (num != 0)
			{
			}
			num = (short)76283905;
			if (num != 0)
			{
			}
			WindowMain windowMain = this.GetWindowMain();
			UtilityMack.bOpenFromRMC = true;
			AcpUIDialogWindow<string> acpUIDialogWindow = new AcpUIDialogWindow<string>(new WriteProtect(windowMain, SecurityManager.LoadedASKs, true, e.Devices, e.IsOwnerSystemIDSupported), null);
			acpUIDialogWindow.ShowInTaskbar = false;
			acpUIDialogWindow.Owner = this;
			acpUIDialogWindow.ResizeMode = ResizeMode.NoResize;
			acpUIDialogWindow.Show();
			acpUIDialogWindow.Focus();
			acpUIDialogWindow.Hide();
			acpUIDialogWindow.ShowDialog();
		}

		// Token: 0x060001F0 RID: 496 RVA: 0x00061254 File Offset: 0x0005F454
		private void RMCWnd_RadioIsConvOnlyEvtHandler(object sender, ASTROHoptionEnableEventArgs e)
		{
			short num = (short)327090176;
			short num2 = num;
			num = (short)1510041183;
			short num3 = num;
			num = (short)47081055;
			switch (num3 == num)
			{
			}
			num = (short)1553793025;
			if (num != 0)
			{
			}
			num = (short)876085248;
			if (num != 0)
			{
			}
			e.IsEnable = RadioOperationValidator.IsRadioConvOnly(e.Modelnumber, e.Flashcode, false);
		}

		// Token: 0x060001F1 RID: 497 RVA: 0x00061314 File Offset: 0x0005F514
		private AcpASKLib.KeyType ConvertASKInterfaceKeyType2AcpASKLibKeyType(ASK.Interface.KeyType keytype)
		{
			switch (0)
			{
			case 0:
				goto IL_40;
			}
			AcpASKLib.KeyType result;
			short num2;
			for (;;)
			{
				IL_0A:
				int num;
				switch (num)
				{
				case 0:
					result = AcpASKLib.KeyType.ADVANCED_CONV_SYSTEM_KEY;
					num2 = (short)1671364619;
					num = (int)((IntPtr)num2);
					continue;
				case 1:
				{
					num2 = (short)147718144;
					short num3 = num2;
					goto IL_1E4;
				}
				case 2:
					return result;
				case 3:
					if (keytype == ASK.Interface.KeyType.ADVANCED_WACN_KEY)
					{
						num2 = (short)909770761;
						num = (int)((IntPtr)num2);
						continue;
					}
					goto IL_1E4;
				case 4:
					if (keytype == ASK.Interface.KeyType.NONE)
					{
						num2 = (short)478543877;
						num = (int)((IntPtr)num2);
						continue;
					}
					return result;
				case 5:
					result = AcpASKLib.KeyType.NONE;
					num2 = (short)2124546050;
					num = (int)((IntPtr)num2);
					continue;
				case 6:
					goto IL_139;
				case 7:
					if (keytype == ASK.Interface.KeyType.ADVANCED_CONV_SYSTEM_KEY)
					{
						num2 = (short)1831665664;
						num = (int)((IntPtr)num2);
						continue;
					}
					goto IL_175;
				case 8:
					if (keytype == ASK.Interface.KeyType.ADVANCED_SYSTEM_KEY)
					{
						num2 = (short)1581842442;
						num = (int)((IntPtr)num2);
						continue;
					}
					goto IL_139;
				case 9:
					goto IL_170;
				case 10:
					result = AcpASKLib.KeyType.ADVANCED_SYSTEM_KEY;
					num2 = (short)552402950;
					num = (int)((IntPtr)num2);
					continue;
				case 11:
					goto IL_175;
				}
				goto IL_40;
				IL_139:
				num2 = (short)1881997315;
				num = (int)((IntPtr)num2);
				continue;
				IL_175:
				num2 = (short)2100887560;
				num = (int)((IntPtr)num2);
				continue;
				IL_1E4:
				num2 = (short)40370180;
				num = (int)((IntPtr)num2);
			}
			IL_170:
			result = AcpASKLib.KeyType.ADVANCED_WACN_KEY;
			goto IL_F3;
			IL_40:
			result = AcpASKLib.KeyType.UNDEFINED_KEY;
			num2 = (short)1630712525;
			short num4 = num2;
			num2 = (short)696562381;
			switch ((num4 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
			{
				IL_F3:
				num2 = (short)1037959169;
				int num = (int)((IntPtr)num2);
				goto IL_0A;
			}
			default:
			{
				num2 = (short)843448320;
				if (num2 != 0)
				{
				}
				num2 = (short)497352705;
				if (num2 != 0)
				{
				}
				num2 = (short)1928003591;
				int num = (int)((IntPtr)num2);
				goto IL_0A;
			}
			}
		}

		// Token: 0x060001F2 RID: 498 RVA: 0x00061560 File Offset: 0x0005F760
		private static ISystemKeyData ACPKeyDataConvertToSystemKeyData(AcpASKLib.SystemKeyData ACPKeyData)
		{
			short num = (short)795410432;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_A6;
				}
				ASK.Interface.KeyType type;
				ASK.Interface.KeySource src;
				ASK.Interface.KeyAccessLevelType aclvl;
				for (;;)
				{
					IL_27:
					switch (num2)
					{
					case 0:
						if (ACPKeyData.Type == AcpASKLib.KeyType.UNDEFINED_KEY)
						{
							num = (short)27656206;
							num2 = (int)((IntPtr)num);
							continue;
						}
						num = (short)1090650113;
						num2 = (int)((IntPtr)num);
						continue;
					case 1:
						if (ACPKeyData.Type == AcpASKLib.KeyType.NONE)
						{
							num = (short)637534217;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_520;
					case 2:
						goto IL_301;
					case 3:
						if (ACPKeyData.Source == AcpASKLib.KeySource.LEGACY_KEY_FILE)
						{
							num = (short)448856075;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_280;
					case 4:
						goto IL_148;
					case 5:
						goto IL_366;
					case 6:
						goto IL_491;
					case 7:
						goto IL_280;
					case 8:
						type = ASK.Interface.KeyType.ADVANCED_WACN_KEY;
						num = (short)889716742;
						num2 = (int)((IntPtr)num);
						continue;
					case 9:
						num = (short)1243283457;
						if (num != 0)
						{
						}
						type = ASK.Interface.KeyType.NONE;
						num = (short)827326492;
						num2 = (int)((IntPtr)num);
						continue;
					case 10:
						if (ACPKeyData.AccessLevelType == AcpASKLib.KeyAccessLevelType.UNLM_ACC_WITHOUT_WP)
						{
							num = (short)482607119;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_366;
					case 11:
						src = ASK.Interface.KeySource.LEGACY_KEY_FILE;
						num = (short)980484115;
						num2 = (int)((IntPtr)num);
						continue;
					case 12:
						goto IL_366;
					case 13:
						goto IL_20E;
					case 14:
						type = ASK.Interface.KeyType.UNDEFINED_KEY;
						num = (short)636092418;
						num2 = (int)((IntPtr)num);
						continue;
					case 15:
						aclvl = ASK.Interface.KeyAccessLevelType.UNLM_ACC_WITHOUT_WP;
						num = (short)181534725;
						num2 = (int)((IntPtr)num);
						continue;
					case 16:
						if (ACPKeyData.Type == AcpASKLib.KeyType.ADVANCED_WACN_KEY)
						{
							num = (short)749469704;
							num2 = (int)((IntPtr)num);
							continue;
						}
						num = (short)1007616000;
						num2 = (int)((IntPtr)num);
						continue;
					case 17:
						if (ACPKeyData.Type == AcpASKLib.KeyType.ADVANCED_SYSTEM_KEY)
						{
							num = (short)1991442458;
							num2 = (int)((IntPtr)num);
							continue;
						}
						num = (short)1886978064;
						num2 = (int)((IntPtr)num);
						continue;
					case 18:
						type = ASK.Interface.KeyType.ADVANCED_CONV_SYSTEM_KEY;
						num = (short)251592708;
						num2 = (int)((IntPtr)num);
						continue;
					case 19:
						goto IL_280;
					case 20:
						if (ACPKeyData.AccessLevelType == AcpASKLib.KeyAccessLevelType.LIMITED_ACC)
						{
							num = (short)179306521;
							num2 = (int)((IntPtr)num);
							continue;
						}
						num = (short)1880948757;
						num2 = (int)((IntPtr)num);
						continue;
					case 21:
						if (ACPKeyData.AccessLevelType == AcpASKLib.KeyAccessLevelType.UNLM_ACC)
						{
							num = (short)833617942;
							num2 = (int)((IntPtr)num);
							continue;
						}
						num = (short)1113980938;
						num2 = (int)((IntPtr)num);
						continue;
					case 22:
						aclvl = ASK.Interface.KeyAccessLevelType.UNLM_ACC;
						num = (short)688390156;
						num2 = (int)((IntPtr)num);
						continue;
					case 23:
					{
						num = (short)253159772;
						short num3 = num;
						num = (short)1252125020;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_32D;
						default:
							num = (short)1247739904;
							if (num != 0)
							{
							}
							if (ACPKeyData.Source == AcpASKLib.KeySource.HARDWARE)
							{
								num = (short)1962410013;
								num2 = (int)((IntPtr)num);
								continue;
							}
							num = (short)2099249155;
							num2 = (int)((IntPtr)num);
							continue;
						}
						break;
					}
					case 24:
						goto IL_366;
					case 25:
						aclvl = ASK.Interface.KeyAccessLevelType.LIMITED_ACC;
						num = (short)737673240;
						num2 = (int)((IntPtr)num);
						continue;
					case 26:
						type = ASK.Interface.KeyType.ADVANCED_SYSTEM_KEY;
						num = (short)2016149517;
						num2 = (int)((IntPtr)num);
						continue;
					case 27:
					{
						if (ACPKeyData.Type == AcpASKLib.KeyType.ADVANCED_CONV_SYSTEM_KEY)
						{
							num = (short)482476050;
							num2 = (int)((IntPtr)num);
							continue;
						}
						num = (short)1683947520;
						short num4 = num;
						num = (short)9764881;
						num2 = (int)((IntPtr)num);
						continue;
					}
					case 28:
						goto IL_326;
					case 29:
						src = ASK.Interface.KeySource.HARDWARE;
						goto IL_32D;
					}
					goto IL_A6;
					IL_280:
					type = ASK.Interface.KeyType.ADVANCED_CONV_SYSTEM_KEY;
					num = (short)2123038747;
					num2 = (int)((IntPtr)num);
					continue;
					IL_32D:
					num = (short)1198653447;
					num2 = (int)((IntPtr)num);
					continue;
					IL_366:
					src = ASK.Interface.KeySource.HARDWARE;
					num = (short)571605015;
					num2 = (int)((IntPtr)num);
				}
				IL_148:
				IL_20E:
				IL_301:
				IL_326:
				IL_491:
				IL_520:
				string iBtnSerialNum = ACPKeyData.iBtnSerialNum;
				bool otapEnabled = ACPKeyData.OtapEnabled;
				int systemID = ACPKeyData.SystemID;
				string systemIDHex = ACPKeyData.SystemIDHex;
				string empty = string.Empty;
				bool writeProtectEnabled = ACPKeyData.WriteProtectEnabled;
				return new CommonASK.SystemKeyData(aclvl, iBtnSerialNum, otapEnabled, src, systemID, type, empty, writeProtectEnabled);
				IL_A6:
				aclvl = ASK.Interface.KeyAccessLevelType.LIMITED_ACC;
				num = (short)1406468116;
				num2 = (int)((IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x060001F3 RID: 499 RVA: 0x00061ACC File Offset: 0x0005FCCC
		private static AcpASKLib.SystemKeyData ConvertACPKeyDataToSystemKeyData(ISystemKeyData keyData)
		{
			short num = (short)1728118784;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_82;
				}
				AcpASKLib.KeyType keyType;
				AcpASKLib.KeySource src;
				for (;;)
				{
					IL_27:
					switch (num2)
					{
					case 0:
						goto IL_120;
					case 1:
					{
						keyType = AcpASKLib.KeyType.ADVANCED_WACN_KEY;
						num = (short)491545276;
						short num3 = num;
						num = (short)372204220;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_E7;
						default:
							num = (short)1756495873;
							if (num != 0)
							{
							}
							num = (short)125829120;
							if (num != 0)
							{
							}
							num = (short)1434910722;
							num2 = (int)((IntPtr)num);
							continue;
						}
						break;
					}
					case 2:
						goto IL_257;
					case 3:
						if (keyData.Source == ASK.Interface.KeySource.LEGACY_KEY_FILE)
						{
							num = (short)1751580690;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_2C2;
					case 4:
						goto IL_2C2;
					case 5:
						keyType = AcpASKLib.KeyType.UNDEFINED_KEY;
						num = (short)1712717831;
						num2 = (int)((IntPtr)num);
						continue;
					case 6:
						if (keyData.Type == ASK.Interface.KeyType.UNDEFINED_KEY)
						{
							goto IL_E7;
						}
						num = (short)362283016;
						num2 = (int)((IntPtr)num);
						continue;
					case 7:
						goto IL_34A;
					case 8:
						if (keyData.Type == ASK.Interface.KeyType.NONE)
						{
							num = (short)1597767689;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_3D1;
					case 9:
						keyType = AcpASKLib.KeyType.NONE;
						num = (short)1852571667;
						num2 = (int)((IntPtr)num);
						continue;
					case 10:
						if (keyData.Type == ASK.Interface.KeyType.ADVANCED_WACN_KEY)
						{
							num = (short)1412890625;
							num2 = (int)((IntPtr)num);
							continue;
						}
						num = (short)87687174;
						num2 = (int)((IntPtr)num);
						continue;
					case 11:
						if (keyData.Source == ASK.Interface.KeySource.HARDWARE)
						{
							num = (short)179109904;
							num2 = (int)((IntPtr)num);
							continue;
						}
						num = (short)28901379;
						num2 = (int)((IntPtr)num);
						continue;
					case 12:
						keyType = AcpASKLib.KeyType.ADVANCED_SYSTEM_KEY;
						num = (short)942931968;
						num2 = (int)((IntPtr)num);
						continue;
					case 13:
						goto IL_3CF;
					case 14:
					{
						num = (short)354287616;
						short num4 = num;
						keyType = AcpASKLib.KeyType.ADVANCED_CONV_SYSTEM_KEY;
						num = (short)1043726349;
						num2 = (int)((IntPtr)num);
						continue;
					}
					case 15:
						if (keyData.Type == ASK.Interface.KeyType.ADVANCED_SYSTEM_KEY)
						{
							num = (short)1341325324;
							num2 = (int)((IntPtr)num);
							continue;
						}
						num = (short)1503330314;
						num2 = (int)((IntPtr)num);
						continue;
					case 16:
						src = AcpASKLib.KeySource.HARDWARE;
						num = (short)1385234449;
						num2 = (int)((IntPtr)num);
						continue;
					case 17:
						goto IL_2C2;
					case 18:
						src = AcpASKLib.KeySource.LEGACY_KEY_FILE;
						num = (short)897515524;
						num2 = (int)((IntPtr)num);
						continue;
					case 19:
						goto IL_27B;
					case 20:
						if (keyData.Type == ASK.Interface.KeyType.ADVANCED_CONV_SYSTEM_KEY)
						{
							num = (short)1379074062;
							num2 = (int)((IntPtr)num);
							continue;
						}
						num = (short)804192271;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_82;
					IL_E7:
					num = (short)478674949;
					num2 = (int)((IntPtr)num);
					continue;
					IL_2C2:
					keyType = AcpASKLib.KeyType.ADVANCED_CONV_SYSTEM_KEY;
					num = (short)232128532;
					num2 = (int)((IntPtr)num);
				}
				IL_120:
				IL_257:
				IL_27B:
				IL_34A:
				IL_3CF:
				IL_3D1:
				string iBtnSerialNum = keyData.iBtnSerialNum;
				bool otapEnabled = keyData.OtapEnabled;
				int systemID = keyData.SystemID;
				bool writeProtectEnabled = keyData.WriteProtectEnabled;
				AccessRecord systemAccessLevel = SecurityManager.GetSystemAccessLevel(systemID, keyType);
				return new AcpASKLib.SystemKeyData(src, iBtnSerialNum, systemID, keyType, otapEnabled, writeProtectEnabled, systemAccessLevel);
				IL_82:
				src = AcpASKLib.KeySource.HARDWARE;
				num = (short)1095893003;
				num2 = (int)((IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x060001F4 RID: 500 RVA: 0x00061EE4 File Offset: 0x000600E4
		private WindowMain GetWindowMain()
		{
			short num = (short)131792896;
			short num2 = num;
			num = (short)139264001;
			if (num != 0)
			{
			}
			num = (short)1110579228;
			short num3 = num;
			num = (short)2146572316;
			switch (num3 == num)
			{
			}
			num = (short)331677696;
			if (num != 0)
			{
			}
			WindowMain winMain = null;
			base.Dispatcher.Invoke(delegate()
			{
				short num4 = (short)1006829568;
				short num5 = num4;
				num4 = (short)957362389;
				short num6 = num4;
				num4 = (short)860303573;
				switch (num6 == num4)
				{
				}
				num4 = (short)1774125057;
				if (num4 != 0)
				{
				}
				num4 = (short)1482096640;
				if (num4 != 0)
				{
				}
				winMain = (WindowMain)Application.Current.MainWindow;
			});
			return winMain;
		}

		// Token: 0x060001F5 RID: 501 RVA: 0x00061FB4 File Offset: 0x000601B4
		private void SaveCpsFile(string filePath, byte[] fileContent)
		{
			short num = (short)484966401;
			int num2 = (int)((IntPtr)num);
			for (;;)
			{
				num = (short)1588974994;
				short num3 = num;
				num = (short)1943000466;
				FileStream fileStream;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)491126784;
					if (num != 0)
					{
					}
					num = (short)846266368;
					short num4 = num;
					switch (num2)
					{
					case 0:
						goto IL_14A;
					case 1:
						goto IL_14;
					case 2:
						File.Delete(filePath);
						num = (short)1123745793;
						if (num != 0)
						{
						}
						num = (short)1626341376;
						num2 = (int)((IntPtr)num);
						continue;
					case 3:
						try
						{
							fileStream.Write(fileContent, 0, fileContent.Length);
							return;
						}
						finally
						{
							num = (short)1933115392;
							num2 = (int)((IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_112;
									}
									continue;
								case 1:
									((IDisposable)fileStream).Dispose();
									num = (short)831848450;
									num2 = (int)((IntPtr)num);
									continue;
								case 2:
									goto IL_147;
								}
								IL_112:
								if (fileStream == null)
								{
									break;
								}
								num = (short)1656684545;
								num2 = (int)((IntPtr)num);
							}
							IL_147:;
						}
						goto IL_14A;
					}
					goto IL_A9;
				}
				}
				IL_14:
				switch (0)
				{
				case 0:
					IL_A9:
					if (!File.Exists(filePath))
					{
						goto IL_14A;
					}
					num = (short)847380482;
					num2 = (int)((IntPtr)num);
					break;
				}
				continue;
				IL_14A:
				fileStream = File.Create(filePath);
				num = (short)1222311939;
				num2 = (int)((IntPtr)num);
			}
		}

		// Token: 0x060001F6 RID: 502 RVA: 0x00062188 File Offset: 0x00060388
		private void RunActionOnSavedFile(string filePath, byte[] fileContent, WindowMain winMain, Action action, AstroDeviceInfo deviceInfo = null)
		{
			string empty;
			short num;
			for (;;)
			{
				this.SaveCpsFile(filePath, fileContent);
				empty = string.Empty;
				if (winMain.OpenCodeplugNonGUI(filePath, ref empty, true, deviceInfo))
				{
					break;
				}
				num = (short)1427177473;
				if (num != 0)
				{
				}
				num = (short)1939631072;
				short num2 = num;
				num = (short)866348000;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					goto IL_87;
				}
			}
			action();
			winMain.CloseFileNonGUI(true);
			return;
			IL_87:
			num = (short)289865728;
			short num3 = num;
			num = (short)1700593664;
			if (num != 0)
			{
			}
			throw CommonExceptionHelper.CreateDirectMessageCommonException(empty);
		}

		// Token: 0x060001F7 RID: 503 RVA: 0x00062260 File Offset: 0x00060460
		private void RunActionOnTempFile(string fileExt, byte[] fileContent, WindowMain winMain, Action action, AstroDeviceInfo deviceInfo = null)
		{
			int a_ = 9;
			short num = (short)505151488;
			short num2 = num;
			num = (short)1277470863;
			short num3 = num;
			num = (short)929802383;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)1279655936;
				if (num != 0)
				{
				}
				string text = Path.GetTempPath() + Guid.NewGuid().ToString(FixedLengthStream.b("귨", a_)) + FixedLengthStream.b("쟨", a_) + fileExt;
				try
				{
					num = (short)248971265;
					if (num != 0)
					{
					}
					this.RunActionOnSavedFile(text, fileContent, winMain, action, deviceInfo);
				}
				finally
				{
					num = (short)163774464;
					int num4 = (int)((IntPtr)num);
					for (;;)
					{
						switch (num4)
						{
						case 0:
							switch (0)
							{
							case 0:
								goto IL_116;
							}
							continue;
						case 1:
							File.Delete(text);
							num = (short)1463091202;
							num4 = (int)((IntPtr)num);
							continue;
						case 2:
							goto IL_14E;
						}
						IL_116:
						if (!File.Exists(text))
						{
							break;
						}
						num = (short)1250230273;
						num4 = (int)((IntPtr)num);
					}
					IL_14E:;
				}
				break;
			}
			}
		}

		// Token: 0x04000155 RID: 341
		private bool _isMockVersion;

		// Token: 0x04000156 RID: 342
		private byte[] _lastCPModifiedTimestamp;

		// Token: 0x04000157 RID: 343
		private bool _isOpenCodeplug;

		// Token: 0x04000158 RID: 344
		private readonly FirmwareFileValidator _firmwareFileValidator;

		// Token: 0x0400015C RID: 348
		[NonSerialized]
		string VafgnaprSvryq = 32;
	}
}
