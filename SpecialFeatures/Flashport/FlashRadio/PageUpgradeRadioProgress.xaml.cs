using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Navigation;
using System.Windows.Shapes;
using ACPBrowser;
using AcpUI.Common;
using CommonResources;
using Motorola.Common.Communication.CommonUtil;
using SpecialFeatures.AcpReportManagerLib;
using SpecialFeatures.Comms.Util;
using SpecialFeatures.FileOperations;
using SpecialFeatures.Flashport.FlashRadio.ApxNext;

namespace SpecialFeatures.Flashport.FlashRadio
{
	// Token: 0x020000E2 RID: 226
	public partial class PageUpgradeRadioProgress : PageFunction<DialogResult>, IDisposable
	{
		// Token: 0x06000D57 RID: 3415 RVA: 0x00118934 File Offset: 0x00116B34
		public PageUpgradeRadioProgress(FileOperationData flashData)
		{
			int a_ = 0;
			base..ctor();
			AcpUI.Common.Utility.SetDirection(this);
			this.c = flashData;
			if (flashData == null)
			{
				throw new ArgumentNullException(RptMgrErrorHandler.b("쪂뎒ﮖ\udb9e삠힢쒤螦쪨쪪쎬솮\udeb0잲閴햶\udcb8鮺펼쪾귀꿂", a_), RptMgrErrorHandler.b("愈즌", a_));
			}
			this.c.CurrentPage = this;
			this.b = this.c.FilePath;
			if (this.d == null)
			{
				this.d = new BackgroundWorker();
			}
			this.d.WorkerReportsProgress = true;
			this.f = new FirmwareFileValidator(new IOCompressionHelper());
			this.InitializeComponent();
			this.a();
			this.a(this.b);
			this.ViewboxTitle.Content = this.c.ProgressDialogTitleContent;
			this.CloseBtn.IsEnabled = false;
			if (Thread.CurrentThread.CurrentCulture.Name.ToLower().StartsWith(RptMgrErrorHandler.b("", a_)))
			{
				this.RadioFlashcodeTextBox.FlowDirection = FlowDirection.LeftToRight;
				this.RadioFlashcodeTextBox.TextAlignment = TextAlignment.Right;
			}
		}

		// Token: 0x06000D58 RID: 3416 RVA: 0x00118A60 File Offset: 0x00116C60
		public void Dispose()
		{
			short num = (short)1829634048;
			short num2 = num;
			num = (short)1844550373;
			short num3 = num;
			num = (short)1315216101;
			switch (num3 == num)
			{
			}
			num = (short)2009399297;
			if (num != 0)
			{
			}
			num = (short)812515328;
			if (num != 0)
			{
			}
			this.Dispose(true);
			GC.SuppressFinalize(this);
		}

		// Token: 0x06000D59 RID: 3417 RVA: 0x00118B14 File Offset: 0x00116D14
		protected virtual void Dispose(bool disposing)
		{
			short num = (short)1165971881;
			short num2 = num;
			num = (short)481317289;
			int num3;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_152:
				this.d.Dispose();
				this.d = null;
				num = (short)236322819;
				num3 = (int)((IntPtr)num);
				break;
			default:
			{
				num = (short)1704067072;
				if (num != 0)
				{
				}
				num = (short)2058223616;
				short num4 = num;
				num = (short)771948544;
				num3 = (int)((IntPtr)num);
				break;
			}
			}
			for (;;)
			{
				switch (num3)
				{
				case 0:
					switch (0)
					{
					case 0:
						goto IL_AF;
					}
					continue;
				case 1:
					num = (short)1272643586;
					num3 = (int)((IntPtr)num);
					continue;
				case 2:
					num = (short)1043660801;
					if (num != 0)
					{
					}
					if (this.d != null)
					{
						num = (short)1849688068;
						num3 = (int)((IntPtr)num);
						continue;
					}
					return;
				case 3:
					return;
				case 4:
					goto IL_152;
				}
				IL_AF:
				if (!disposing)
				{
					break;
				}
				num = (short)1533673473;
				num3 = (int)((IntPtr)num);
			}
		}

		// Token: 0x06000D5A RID: 3418 RVA: 0x00118C78 File Offset: 0x00116E78
		private void a()
		{
			short num = (short)1249640448;
			short num2 = num;
			num = (short)1557247675;
			short num3 = num;
			num = (short)2090120891;
			switch (num3 == num)
			{
			}
			num = (short)1547239424;
			if (num != 0)
			{
			}
			num = (short)14483457;
			if (num != 0)
			{
			}
			this.d.DoWork += this.backgroundWorker1_DoWork;
			this.d.RunWorkerCompleted += this.backgroundWorker1_RunWorkerCompleted;
			this.d.ProgressChanged += this.backgroundWorker1_ProgressChanged;
		}

		// Token: 0x06000D5B RID: 3419 RVA: 0x00118D68 File Offset: 0x00116F68
		private void backgroundWorker1_DoWork(object A_0, DoWorkEventArgs A_1)
		{
			short num = (short)1430650880;
			short num2 = num;
			num = (short)1163880491;
			short num3 = num;
			num = (short)47212587;
			switch (num3 == num)
			{
			}
			num = (short)2025259009;
			if (num != 0)
			{
			}
			num = (short)1913782272;
			if (num != 0)
			{
			}
			BackgroundWorker a_ = A_0 as BackgroundWorker;
			A_1.Result = this.FlashRadio((string)A_1.Argument, a_, A_1);
		}

		// Token: 0x06000D5C RID: 3420 RVA: 0x00118E38 File Offset: 0x00117038
		private void backgroundWorker1_RunWorkerCompleted(object A_0, RunWorkerCompletedEventArgs A_1)
		{
			short num = (short)1842610180;
			int num2 = (int)((IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_300;
				case 1:
					if (this.CodeplugIndicator.BusyState == BusyStates.BUSY)
					{
						num = (short)1974665224;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_300;
				case 2:
					goto IL_155;
				case 3:
					this.myStsParagraph.Inlines.Clear();
					this.myStsParagraph.Inlines.Add(A_1.Error.Message);
					num = (short)512294921;
					num2 = (int)((IntPtr)num);
					continue;
				case 4:
					switch (0)
					{
					case 0:
						goto IL_6C;
					}
					continue;
				case 5:
					num = (short)2078736385;
					if (num != 0)
					{
					}
					goto IL_2BF;
				case 6:
					this.FlashComponentIndicator.BusyState = BusyStates.COMPLETE_WITH_ERROR;
					num = (short)61079565;
					num2 = (int)((IntPtr)num);
					continue;
				case 7:
					this.ValidationIndicator.BusyState = BusyStates.COMPLETE_WITH_ERROR;
					num = (short)702545922;
					num2 = (int)((IntPtr)num);
					continue;
				case 8:
					this.CodeplugIndicator.BusyState = BusyStates.COMPLETE_WITH_ERROR;
					num = (short)1404960768;
					num2 = (int)((IntPtr)num);
					continue;
				case 9:
				{
					num = (short)1106720319;
					short num3 = num;
					num = (short)1559639615;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_210;
					default:
						num = (short)1344012288;
						if (num != 0)
						{
						}
						if (this.ConnectBusyIndicator.BusyState == BusyStates.BUSY)
						{
							num = (short)567083020;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_2BF;
					}
					break;
				}
				case 10:
				{
					num = (short)954990592;
					short num4 = num;
					this.VerifyBusyIndicator.BusyState = BusyStates.COMPLETE_WITH_ERROR;
					num = (short)1544683537;
					num2 = (int)((IntPtr)num);
					continue;
				}
				case 11:
					if (this.VerifyBusyIndicator.BusyState == BusyStates.BUSY)
					{
						num = (short)492568586;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_27E;
				case 12:
					goto IL_210;
				case 13:
					goto IL_215;
				case 14:
					if (this.ValidationIndicator.BusyState == BusyStates.BUSY)
					{
						num = (short)749207559;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_398;
				case 15:
					if (this.FlashComponentIndicator.BusyState == BusyStates.BUSY)
					{
						num = (short)58720262;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_215;
				case 16:
					goto IL_279;
				case 17:
					goto IL_27E;
				}
				IL_6C:
				if (A_1.Error != null)
				{
					num = (short)2115567619;
					num2 = (int)((IntPtr)num);
					continue;
				}
				bool cancelled = A_1.Cancelled;
				num = (short)973799440;
				num2 = (int)((IntPtr)num);
				continue;
				IL_210:
				this.ConnectBusyIndicator.BusyState = BusyStates.COMPLETE_WITH_ERROR;
				num = (short)1722744837;
				num2 = (int)((IntPtr)num);
				continue;
				IL_215:
				num = (short)1262092302;
				num2 = (int)((IntPtr)num);
				continue;
				IL_27E:
				num = (short)309526529;
				num2 = (int)((IntPtr)num);
				continue;
				IL_2BF:
				num = (short)1864302603;
				num2 = (int)((IntPtr)num);
				continue;
				IL_300:
				num = (short)607453199;
				num2 = (int)((IntPtr)num);
			}
			IL_155:
			IL_279:
			IL_398:
			this.CloseBtn.IsEnabled = true;
			this.c.OkToCancel = true;
		}

		// Token: 0x06000D5D RID: 3421 RVA: 0x001191F8 File Offset: 0x001173F8
		private void backgroundWorker1_ProgressChanged(object A_0, ProgressChangedEventArgs A_1)
		{
			short num = (short)2035810304;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_186;
				}
				string text;
				for (;;)
				{
					IL_27:
					UserState userState;
					ProgressUserState progressUserState;
					switch (num2)
					{
					case 0:
						text = AppResources.Flashing_Host;
						num = (short)2042626090;
						num2 = (int)((IntPtr)num);
						continue;
					case 1:
						if (text == ProgressStatus.UpgradePsdt.ToString())
						{
							num = (short)673710128;
							num2 = (int)((IntPtr)num);
							continue;
						}
						num = (short)1862008917;
						num2 = (int)((IntPtr)num);
						continue;
					case 2:
						num = (short)1368129537;
						if (num != 0)
						{
						}
						if (text == ProgressStatus.UpgradeMace.ToString())
						{
							num = (short)336658467;
							num2 = (int)((IntPtr)num);
							continue;
						}
						num = (short)1315110920;
						num2 = (int)((IntPtr)num);
						continue;
					case 3:
						goto IL_B63;
					case 4:
						goto IL_B63;
					case 5:
						if (A_1.UserState is ProgressUserState)
						{
							num = (short)2106785839;
							num2 = (int)((IntPtr)num);
							continue;
						}
						num = (short)2114322511;
						num2 = (int)((IntPtr)num);
						continue;
					case 6:
						num = (short)613810244;
						num2 = (int)((IntPtr)num);
						continue;
					case 7:
						if (text == ProgressStatus.UpgradeHost.ToString())
						{
							num = (short)2081095680;
							num2 = (int)((IntPtr)num);
							continue;
						}
						num = (short)269942835;
						num2 = (int)((IntPtr)num);
						continue;
					case 8:
						if (text == ProgressStatus.UpgradeOptBrd.ToString())
						{
							num = (short)1749155907;
							num2 = (int)((IntPtr)num);
							continue;
						}
						num = (short)915472429;
						num2 = (int)((IntPtr)num);
						continue;
					case 9:
					{
						RadioInfoParams radioInfoParams;
						this.RadioModelTextBox.Text = radioInfoParams.ModelNumber;
						this.RadioSerialNoTextBox.Text = radioInfoParams.SerialNumber;
						this.RadioFlashcodeTextBox.Text = radioInfoParams.Flashcode;
						num = (short)1412694065;
						num2 = (int)((IntPtr)num);
						continue;
					}
					case 10:
						if (A_1.UserState is string)
						{
							num = (short)741081152;
							num2 = (int)((IntPtr)num);
							continue;
						}
						num = (short)1589182469;
						num2 = (int)((IntPtr)num);
						continue;
					case 11:
						goto IL_B63;
					case 12:
						goto IL_B63;
					case 13:
						goto IL_8AB;
					case 14:
					{
						int num3 = 100;
						this.progressBar2.Value = (double)num3;
						num = (short)174129205;
						num2 = (int)((IntPtr)num);
						continue;
					}
					case 15:
						goto IL_B63;
					case 16:
						goto IL_B63;
					case 17:
						text = AppResources.Flashing_AccyBrd;
						num = (short)112984094;
						num2 = (int)((IntPtr)num);
						continue;
					case 18:
						goto IL_112A;
					case 19:
						if (text == ProgressStatus.WriteCPDone.ToString())
						{
							num = (short)147521567;
							num2 = (int)((IntPtr)num);
							continue;
						}
						num = (short)334823470;
						num2 = (int)((IntPtr)num);
						continue;
					case 20:
						goto IL_B63;
					case 21:
						goto IL_112A;
					case 22:
						if (text != ProgressStatus.WriteLanguagesDone.ToString())
						{
							num = (short)1704263753;
							num2 = (int)((IntPtr)num);
							continue;
						}
						return;
					case 23:
						goto IL_112A;
					case 24:
						goto IL_B63;
					case 25:
						if (!(text == ProgressStatus.EraseFlash.ToString()))
						{
							num = (short)173735942;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_712;
					case 26:
						this.FlashComponentIndicator.BusyState = BusyStates.BUSY;
						text = AppResources.Flashing_Radio_Sw;
						num = (short)2049114152;
						num2 = (int)((IntPtr)num);
						continue;
					case 27:
						switch (userState)
						{
						case UserState.ConnectStart:
							goto IL_851;
						case UserState.ConnectError:
							goto IL_1033;
						case UserState.ConnectDone:
							goto IL_984;
						case UserState.ReadRadInfoStart:
							goto IL_568;
						case UserState.ReadRadInfoError:
							goto IL_E39;
						case UserState.ReadRadInfoDone:
							goto IL_282;
						case UserState.CodeplugStart:
							goto IL_662;
						case UserState.CodeplugError:
							goto IL_A55;
						case UserState.CodeplugDone:
							goto IL_A63;
						case UserState.FlashingComponentStart:
							goto IL_8B0;
						case UserState.FlashingComponentError:
							goto IL_364;
						case UserState.FlashingComponentDone:
							goto IL_55B;
						case UserState.FinalValidationStart:
							goto IL_A70;
						case UserState.FinalValidationError:
							goto IL_2DD;
						case UserState.FinalValidationDone:
							goto IL_930;
						case UserState.UploadFirmwareStart:
						case UserState.FirmwarePackageInvalid:
						case UserState.None:
							return;
						case UserState.UploadFirmwareDone:
							goto IL_1026;
						case UserState.UploadFirmwareError:
							goto IL_D52;
						default:
							num = (short)1952579625;
							num2 = (int)((IntPtr)num);
							continue;
						}
						break;
					case 28:
					{
						RadioInfoParams radioInfoParams = (RadioInfoParams)A_1.UserState;
						num = (short)1287323698;
						num2 = (int)((IntPtr)num);
						continue;
					}
					case 29:
						goto IL_112A;
					case 30:
						goto IL_112A;
					case 31:
						this.CodeplugIndicator.BusyState = BusyStates.COMPLETE_NO_ERROR;
						num = (short)1147994167;
						num2 = (int)((IntPtr)num);
						continue;
					case 32:
						goto IL_112A;
					case 33:
						if (text != ProgressStatus.ReadingCP.ToString())
						{
							num = (short)1463025729;
							num2 = (int)((IntPtr)num);
							continue;
						}
						return;
					case 34:
						text = AppResources.Writing_Codeplug;
						num = (short)129302546;
						num2 = (int)((IntPtr)num);
						continue;
					case 35:
						text = AppResources.Flashing_Mace;
						num = (short)1159266379;
						num2 = (int)((IntPtr)num);
						continue;
					case 36:
						goto IL_C21;
					case 37:
						if (text == ProgressStatus.WriteSoftwareDone.ToString())
						{
							num = (short)1363869710;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_112A;
					case 38:
						if (text != ProgressStatus.WriteCPDone.ToString())
						{
							num = (short)1365311501;
							num2 = (int)((IntPtr)num);
							continue;
						}
						return;
					case 39:
						goto IL_B63;
					case 40:
						goto IL_112A;
					case 41:
						return;
					case 42:
						goto IL_112A;
					case 43:
						if (text == ProgressStatus.WritingLanguages.ToString())
						{
							num = (short)132448300;
							num2 = (int)((IntPtr)num);
							continue;
						}
						num = (short)2084700197;
						num2 = (int)((IntPtr)num);
						continue;
					case 44:
						text = AppResources.LP_Begin_Language_Pack_Update;
						num = (short)1618804768;
						num2 = (int)((IntPtr)num);
						continue;
					case 45:
						if (text == ProgressStatus.UpgradeAccBrd.ToString())
						{
							num = (short)1895301137;
							num2 = (int)((IntPtr)num);
							continue;
						}
						num = (short)2119303169;
						num2 = (int)((IntPtr)num);
						continue;
					case 46:
						if (text == ProgressStatus.UpgradeRadio.ToString())
						{
							num = (short)1838546970;
							num2 = (int)((IntPtr)num);
							continue;
						}
						num = (short)669122585;
						num2 = (int)((IntPtr)num);
						continue;
					case 47:
						progressUserState = (ProgressUserState)A_1.UserState;
						num = (short)586612797;
						num2 = (int)((IntPtr)num);
						continue;
					case 48:
						text = AppResources.Flashing_Psdt;
						num = (short)710344733;
						num2 = (int)((IntPtr)num);
						continue;
					case 49:
						return;
					case 50:
					{
						RadioInfoParams radioInfoParams;
						if (radioInfoParams != null)
						{
							num = (short)820183049;
							num2 = (int)((IntPtr)num);
							continue;
						}
						return;
					}
					case 51:
						if (text == ProgressStatus.UpgradeDsp.ToString())
						{
							num = (short)1526595667;
							num2 = (int)((IntPtr)num);
							continue;
						}
						num = (short)668663810;
						num2 = (int)((IntPtr)num);
						continue;
					case 52:
						goto IL_B63;
					case 53:
						goto IL_112A;
					case 54:
						goto IL_712;
					case 55:
						goto IL_112A;
					case 56:
						goto IL_C21;
					case 57:
						switch (userState)
						{
						case UserState.ConnectStart:
							this.ConnectBusyIndicator.BusyState = BusyStates.BUSY;
							num = (short)226361428;
							num2 = (int)((IntPtr)num);
							continue;
						case UserState.ConnectError:
							this.ConnectBusyIndicator.BusyState = BusyStates.COMPLETE_WITH_ERROR;
							num = (short)648347659;
							num2 = (int)((IntPtr)num);
							continue;
						case UserState.ConnectDone:
							this.ConnectBusyIndicator.BusyState = BusyStates.COMPLETE_NO_ERROR;
							num = (short)512425987;
							num2 = (int)((IntPtr)num);
							continue;
						case UserState.ReadRadInfoStart:
							this.VerifyBusyIndicator.BusyState = BusyStates.BUSY;
							num = (short)1429864487;
							num2 = (int)((IntPtr)num);
							continue;
						case UserState.ReadRadInfoError:
							this.VerifyBusyIndicator.BusyState = BusyStates.COMPLETE_WITH_ERROR;
							num = (short)1835073599;
							num2 = (int)((IntPtr)num);
							continue;
						case UserState.ReadRadInfoDone:
							this.VerifyBusyIndicator.BusyState = BusyStates.COMPLETE_NO_ERROR;
							num = (short)1864368180;
							num2 = (int)((IntPtr)num);
							continue;
						case UserState.CodeplugStart:
							this.CodeplugIndicator.BusyState = BusyStates.BUSY;
							num = (short)377880588;
							num2 = (int)((IntPtr)num);
							continue;
						case UserState.CodeplugError:
							this.CodeplugIndicator.BusyState = BusyStates.COMPLETE_WITH_ERROR;
							num = (short)1219428422;
							num2 = (int)((IntPtr)num);
							continue;
						case UserState.CodeplugDone:
							this.CodeplugIndicator.BusyState = BusyStates.COMPLETE_NO_ERROR;
							num = (short)70713359;
							num2 = (int)((IntPtr)num);
							continue;
						case UserState.FlashingComponentStart:
							this.FlashComponentIndicator.BusyState = BusyStates.BUSY;
							num = (short)867762196;
							num2 = (int)((IntPtr)num);
							continue;
						case UserState.FlashingComponentError:
							this.FlashComponentIndicator.BusyState = BusyStates.COMPLETE_WITH_ERROR;
							num = (short)1380778058;
							num2 = (int)((IntPtr)num);
							continue;
						case UserState.FlashingComponentDone:
							this.FlashComponentIndicator.BusyState = BusyStates.COMPLETE_NO_ERROR;
							num = (short)1327104080;
							num2 = (int)((IntPtr)num);
							continue;
						case UserState.FinalValidationStart:
							this.ValidationIndicator.BusyState = BusyStates.BUSY;
							num = (short)156237893;
							num2 = (int)((IntPtr)num);
							continue;
						case UserState.FinalValidationError:
						{
							num = (short)656099083;
							short num4 = num;
							num = (short)2049787659;
							switch ((num4 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								continue;
							default:
								num = (short)1414070272;
								if (num != 0)
								{
								}
								this.ValidationIndicator.BusyState = BusyStates.COMPLETE_WITH_ERROR;
								num = (short)121962512;
								num2 = (int)((IntPtr)num);
								continue;
							}
							break;
						}
						case UserState.FinalValidationDone:
							this.ValidationIndicator.BusyState = BusyStates.COMPLETE_NO_ERROR;
							num = (short)1817378892;
							num2 = (int)((IntPtr)num);
							continue;
						case UserState.UploadFirmwareStart:
						case UserState.None:
							goto IL_B63;
						case UserState.UploadFirmwareDone:
							this.ApxNextFirmwareSentIndicator.BusyState = BusyStates.COMPLETE_NO_ERROR;
							num = (short)1588133966;
							num2 = (int)((IntPtr)num);
							continue;
						case UserState.UploadFirmwareError:
							this.ApxNextFirmwareSentIndicator.BusyState = BusyStates.COMPLETE_WITH_ERROR;
							num = (short)1778974724;
							num2 = (int)((IntPtr)num);
							continue;
						case UserState.FirmwarePackageInvalid:
							this.FlashComponentIndicator.BusyState = BusyStates.COMPLETE_WITH_ERROR;
							num = (short)2022113351;
							num2 = (int)((IntPtr)num);
							continue;
						default:
							num = (short)387055675;
							num2 = (int)((IntPtr)num);
							continue;
						}
						break;
					case 58:
						goto IL_112A;
					case 59:
						num = (short)985923608;
						num2 = (int)((IntPtr)num);
						continue;
					case 60:
						num = (short)1204551702;
						num2 = (int)((IntPtr)num);
						continue;
					case 61:
						if (progressUserState != null)
						{
							num = (short)1402863682;
							num2 = (int)((IntPtr)num);
							continue;
						}
						return;
					case 62:
					{
						if (progressUserState.UserText != AppResources.LP_Write_Radio_After_Flashport_To_Update_Language_Pack)
						{
							num = (short)197197901;
							num2 = (int)((IntPtr)num);
							continue;
						}
						Run run = new Run(progressUserState.UserText);
						run.Foreground = Brushes.Red;
						this.myStsParagraph.Inlines.Add(run);
						num = (short)303366200;
						num2 = (int)((IntPtr)num);
						continue;
					}
					case 63:
						goto IL_B63;
					case 64:
						text = Convert.ToString(A_1.UserState);
						num = (short)1969029127;
						num2 = (int)((IntPtr)num);
						continue;
					case 65:
						num = (short)1000079432;
						num2 = (int)((IntPtr)num);
						continue;
					case 66:
						num = (short)769196094;
						num2 = (int)((IntPtr)num);
						continue;
					case 67:
						text = AppResources.Flashing_OptBrd;
						num = (short)760741946;
						num2 = (int)((IntPtr)num);
						continue;
					case 68:
						if (text == ProgressStatus.ErasingCP.ToString())
						{
							num = (short)1592066102;
							num2 = (int)((IntPtr)num);
							continue;
						}
						num = (short)1484193835;
						num2 = (int)((IntPtr)num);
						continue;
					case 69:
						goto IL_B63;
					case 70:
						goto IL_B63;
					case 71:
						goto IL_B63;
					case 72:
						if (text != ProgressStatus.ReadCPDone.ToString())
						{
							num = (short)922484796;
							num2 = (int)((IntPtr)num);
							continue;
						}
						return;
					case 73:
						num = (short)758841382;
						num2 = (int)((IntPtr)num);
						continue;
					case 74:
						goto IL_B63;
					case 75:
						goto IL_112A;
					case 76:
						goto IL_B63;
					case 77:
						this.myStsParagraph.Inlines.Clear();
						this.myStsParagraph.Inlines.Add(progressUserState.UserText);
						num = (short)608043044;
						num2 = (int)((IntPtr)num);
						continue;
					case 78:
						goto IL_B63;
					case 79:
						if (A_1.UserState is RadioInfoParams)
						{
							num = (short)2118582300;
							num2 = (int)((IntPtr)num);
							continue;
						}
						return;
					case 80:
						goto IL_B63;
					case 81:
						if (text != ProgressStatus.None.ToString())
						{
							num = (short)235995218;
							num2 = (int)((IntPtr)num);
							continue;
						}
						return;
					case 82:
						num = (short)613089313;
						num2 = (int)((IntPtr)num);
						continue;
					case 83:
						text = AppResources.Flashing_Dsp;
						num = (short)545194005;
						num2 = (int)((IntPtr)num);
						continue;
					case 84:
						goto IL_B63;
					case 85:
						if (text == ProgressStatus.WritingCP.ToString())
						{
							num = (short)1258422306;
							num2 = (int)((IntPtr)num);
							continue;
						}
						num = (short)1550123027;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_186;
					IL_712:
					text = AppResources.Erasing;
					num = (short)618004480;
					short num5 = num;
					num = (short)128253975;
					num2 = (int)((IntPtr)num);
					continue;
					IL_B63:
					userState = progressUserState.NewUserState;
					num = (short)1470365723;
					num2 = (int)((IntPtr)num);
					continue;
					IL_C21:
					userState = progressUserState.CurrentUserState;
					num = (short)310247481;
					num2 = (int)((IntPtr)num);
					continue;
					IL_112A:
					num = (short)1846935633;
					num2 = (int)((IntPtr)num);
				}
				IL_282:
				this.VerifyBusyIndicator.BusyState = BusyStates.COMPLETE_NO_ERROR;
				return;
				IL_2DD:
				this.ValidationIndicator.BusyState = BusyStates.COMPLETE_WITH_ERROR;
				return;
				IL_364:
				this.FlashComponentIndicator.BusyState = BusyStates.COMPLETE_WITH_ERROR;
				return;
				IL_55B:
				this.FlashComponentIndicator.BusyState = BusyStates.COMPLETE_NO_ERROR;
				return;
				IL_568:
				this.VerifyBusyIndicator.BusyState = BusyStates.BUSY;
				return;
				IL_662:
				this.CodeplugIndicator.BusyState = BusyStates.BUSY;
				return;
				IL_851:
				this.ConnectBusyIndicator.BusyState = BusyStates.BUSY;
				return;
				IL_8AB:
				this.myStsParagraph.Inlines.Clear();
				this.myStsParagraph.Inlines.Add(text);
				return;
				IL_8B0:
				this.FlashComponentIndicator.BusyState = BusyStates.BUSY;
				return;
				IL_930:
				this.ValidationIndicator.BusyState = BusyStates.COMPLETE_NO_ERROR;
				return;
				IL_984:
				this.ConnectBusyIndicator.BusyState = BusyStates.COMPLETE_NO_ERROR;
				return;
				IL_A55:
				this.CodeplugIndicator.BusyState = BusyStates.COMPLETE_WITH_ERROR;
				return;
				IL_A63:
				this.CodeplugIndicator.BusyState = BusyStates.COMPLETE_NO_ERROR;
				return;
				IL_A70:
				this.ValidationIndicator.BusyState = BusyStates.BUSY;
				return;
				IL_D52:
				this.ApxNextFirmwareSentIndicator.BusyState = BusyStates.COMPLETE_WITH_ERROR;
				return;
				IL_E39:
				this.VerifyBusyIndicator.BusyState = BusyStates.COMPLETE_WITH_ERROR;
				return;
				IL_1026:
				this.ApxNextFirmwareSentIndicator.BusyState = BusyStates.COMPLETE_NO_ERROR;
				return;
				IL_1033:
				this.ConnectBusyIndicator.BusyState = BusyStates.COMPLETE_WITH_ERROR;
				return;
				IL_186:
				this.progressBar2.Value = (double)A_1.ProgressPercentage;
				num = (short)957284362;
				num2 = (int)((IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x06000D5E RID: 3422 RVA: 0x0011A380 File Offset: 0x00118580
		private long FlashRadio(string A_0, BackgroundWorker A_1, DoWorkEventArgs A_2)
		{
			short num = (short)1753022465;
			if (num != 0)
			{
			}
			num = (short)515309571;
			int num2 = (int)((IntPtr)num);
			for (;;)
			{
				num = (short)592379904;
				short num3 = num;
				switch (num2)
				{
				case 0:
					if (!File.Exists(A_0))
					{
						num = (short)942866433;
						num2 = (int)((IntPtr)num);
						continue;
					}
					num = (short)1360068612;
					num2 = (int)((IntPtr)num);
					continue;
				case 1:
					goto IL_162;
				case 2:
					num = (short)6291456;
					num2 = (int)((IntPtr)num);
					continue;
				case 3:
					switch (0)
					{
					case 0:
						goto IL_8A;
					}
					continue;
				case 4:
					goto IL_10E;
				}
				IL_8A:
				num = (short)390766397;
				short num4 = num;
				num = (short)1748737853;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)1775763456;
					if (num != 0)
					{
					}
					if (string.IsNullOrEmpty(A_0))
					{
						goto IL_120;
					}
					num = (short)1721958402;
					num2 = (int)((IntPtr)num);
					break;
				}
			}
			IL_10E:
			long result = 0L;
			if (this.f.IsItApxNextFwFile(A_0))
			{
				new UpgradeRadioApxNext(A_1, this.c.Refresh).FlashRadio(A_0);
				return result;
			}
			new UpgradeRadio(A_1, this.c.Refresh).FlashRadio(A_0);
			return result;
			IL_120:
			throw new ArgumentException(AppResources.Invalid_upgrade_file);
			IL_162:
			goto IL_120;
		}

		// Token: 0x06000D5F RID: 3423 RVA: 0x0011A520 File Offset: 0x00118720
		private void Page_Loaded(object A_0, RoutedEventArgs A_1)
		{
			switch (0)
			{
			case 0:
				goto IL_28;
			}
			int num;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					goto IL_181;
				case 1:
					goto IL_14B;
				case 2:
					num2 = (short)1928069121;
					if (num2 != 0)
					{
					}
					this.d.RunWorkerAsync(this.b);
					num2 = (short)1250164737;
					num = (int)((IntPtr)num2);
					continue;
				case 3:
					goto IL_121;
				case 4:
				{
					num2 = (short)1928038205;
					short num3 = num2;
					num2 = (short)1301251901;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_181;
					default:
						num2 = (short)180355072;
						if (num2 != 0)
						{
						}
						if (!this.d.IsBusy)
						{
							num2 = (short)317194242;
							num = (int)((IntPtr)num2);
							continue;
						}
						goto IL_14B;
					}
					break;
				}
				case 5:
					if (!base.IsKeyboardFocusWithin)
					{
						num2 = (short)1515061248;
						num = (int)((IntPtr)num2);
						continue;
					}
					return;
				}
				goto IL_28;
				IL_14B:
				num2 = (short)1923678213;
				num = (int)((IntPtr)num2);
				continue;
				IL_181:
				Keyboard.Focus(this);
				num2 = (short)620953603;
				num = (int)((IntPtr)num2);
			}
			IL_121:
			num2 = (short)2068643840;
			short num4 = num2;
			return;
			IL_28:
			this.myStsParagraph.Inlines.Clear();
			base.NavigationService.Navigating += this.NavigationService_Navigating;
			num2 = (short)1485766660;
			num = (int)((IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000D60 RID: 3424 RVA: 0x0011A6DC File Offset: 0x001188DC
		private void NavigationService_Navigating(object A_0, NavigatingCancelEventArgs A_1)
		{
			short num = (short)573321176;
			short num2 = num;
			num = (short)148516824;
			switch (num2 == num)
			{
			}
			num = (short)2135818240;
			if (num != 0)
			{
			}
			num = (short)2024996864;
			short num3 = num;
			num = (short)1330642945;
			if (num != 0)
			{
			}
			A_1.Cancel = true;
		}

		// Token: 0x1700049B RID: 1179
		// (get) Token: 0x06000D61 RID: 3425 RVA: 0x0011A78C File Offset: 0x0011898C
		// (set) Token: 0x06000D62 RID: 3426 RVA: 0x0011A838 File Offset: 0x00118A38
		public string ProgressText
		{
			get
			{
				short num = (short)1804656603;
				short num2 = num;
				num = (short)894361563;
				switch (num2 == num)
				{
				}
				num = (short)124321792;
				if (num != 0)
				{
				}
				num = (short)100270080;
				short num3 = num;
				num = (short)1821769729;
				if (num != 0)
				{
				}
				return this.a;
			}
			set
			{
				short num = (short)1520188731;
				short num2 = num;
				num = (short)661732667;
				switch (num2 == num)
				{
				}
				num = (short)687603713;
				if (num != 0)
				{
				}
				num = (short)1188888576;
				short num3 = num;
				num = (short)2125463552;
				if (num != 0)
				{
				}
				this.a = value;
			}
		}

		// Token: 0x06000D63 RID: 3427 RVA: 0x0011A8EC File Offset: 0x00118AEC
		private void ObButtonClick_Close(object A_0, RoutedEventArgs A_1)
		{
			short num = (short)1209528246;
			short num2 = num;
			num = (short)1773858742;
			switch (num2 == num)
			{
			}
			num = (short)37158913;
			if (num != 0)
			{
			}
			num = (short)682033152;
			short num3 = num;
			num = (short)475922432;
			if (num != 0)
			{
			}
			this.OnReturn(new ReturnEventArgs<DialogResult>(DialogResult.Finished));
		}

		// Token: 0x06000D64 RID: 3428 RVA: 0x0011A9A4 File Offset: 0x00118BA4
		private void F1HelpCommandCanExcute(object A_0, CanExecuteRoutedEventArgs A_1)
		{
			short num = (short)1757146154;
			short num2 = num;
			num = (short)1392307242;
			switch (num2 == num)
			{
			}
			num = (short)995819521;
			if (num != 0)
			{
			}
			num = (short)1425670144;
			short num3 = num;
			num = (short)1663107072;
			if (num != 0)
			{
			}
			A_1.CanExecute = true;
		}

		// Token: 0x06000D65 RID: 3429 RVA: 0x0011AA54 File Offset: 0x00118C54
		private void buttonHelp_Click(object A_0, RoutedEventArgs A_1)
		{
			short num;
			try
			{
				num = (short)822354169;
				short num2 = num;
				num = (short)1086398713;
				switch (num2 == num)
				{
				}
				num = (short)81395712;
				if (num != 0)
				{
				}
				ACPBrowser.Utility.CloseHelpWindowIfOpen();
				ACPBrowser.Utility.DisplayCPSHelpDITA(this.c.ProgressDialogHelpTopicId);
			}
			catch (Exception)
			{
			}
			num = (short)735772672;
			short num3 = num;
			num = (short)318111745;
			if (num != 0)
			{
			}
		}

		// Token: 0x06000D66 RID: 3430 RVA: 0x0011AB2C File Offset: 0x00118D2C
		public void FlashportPage_Return(object sender, ReturnEventArgs<DialogResult> e)
		{
			short num = (short)2006548747;
			short num2 = num;
			num = (short)1209893131;
			switch (num2 == num)
			{
			}
			num = (short)1623261185;
			if (num != 0)
			{
			}
			num = (short)97517568;
			short num3 = num;
			num = (short)576651264;
			if (num != 0)
			{
			}
			this.OnReturn(e);
		}

		// Token: 0x06000D67 RID: 3431 RVA: 0x0011ABDC File Offset: 0x00118DDC
		private void a(string A_0)
		{
			if (!this.f.IsItApxNextFwFile(A_0))
			{
				short num = (short)199816005;
				short num2 = num;
				num = (short)716567365;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)1718222849;
					if (num != 0)
					{
					}
					num = (short)1444872192;
					if (num != 0)
					{
					}
					num = (short)1055850496;
					short num3 = num;
					this.ApxNextFirmwareSentIndicator.Visibility = Visibility.Collapsed;
					this.ApxNextFirmwareSentText.Visibility = Visibility.Collapsed;
					this.ValidationIndicator.Visibility = Visibility.Visible;
					this.ValidationIndicatorText.Visibility = Visibility.Visible;
					return;
				}
				}
			}
			this.ApxNextFirmwareSentIndicator.Visibility = Visibility.Collapsed;
			this.ApxNextFirmwareSentText.Visibility = Visibility.Collapsed;
			this.ValidationIndicator.Visibility = Visibility.Collapsed;
			this.ValidationIndicatorText.Visibility = Visibility.Collapsed;
		}

		// Token: 0x040006C3 RID: 1731
		private string a;

		// Token: 0x040006C4 RID: 1732
		private string b;

		// Token: 0x040006C5 RID: 1733
		private FileOperationData c;

		// Token: 0x040006C6 RID: 1734
		private BackgroundWorker d;

		// Token: 0x040006C7 RID: 1735
		private string e;

		// Token: 0x040006C8 RID: 1736
		private FirmwareFileValidator f;
	}
}
