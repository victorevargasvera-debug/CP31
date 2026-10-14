using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using CommonResources;
using SpecialFeatures.AcpReportManagerLib;

namespace SpecialFeatures.Flashport.FlashRadio.ApxNext
{
	// Token: 0x020000F9 RID: 249
	public class ProgressUpdater
	{
		// Token: 0x170004A9 RID: 1193
		// (get) Token: 0x06000DFD RID: 3581 RVA: 0x00135F34 File Offset: 0x00134134
		// (set) Token: 0x06000DFE RID: 3582 RVA: 0x00135FE4 File Offset: 0x001341E4
		public int MaxSteps
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)792953193;
				short num2 = num;
				num = (short)1114538345;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1086521344;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1762852865;
				if (num != 0)
				{
				}
				num = (short)1797652480;
				if (num != 0)
				{
				}
				return this.b;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)2020119441;
				short num2 = num;
				num = (short)1270387601;
				switch (num2 == num)
				{
				default:
				{
					num = (short)332267520;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)981598208;
				if (num != 0)
				{
				}
				num = (short)2063073281;
				if (num != 0)
				{
				}
				this.b = value;
			}
		}

		// Token: 0x170004AA RID: 1194
		// (get) Token: 0x06000DFF RID: 3583 RVA: 0x00136098 File Offset: 0x00134298
		// (set) Token: 0x06000E00 RID: 3584 RVA: 0x00136148 File Offset: 0x00134348
		public int CurrentStep
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)279542375;
				short num2 = num;
				num = (short)372865639;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1445003264;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)993984513;
				if (num != 0)
				{
				}
				num = (short)1575288832;
				if (num != 0)
				{
				}
				return this.c;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1203625549;
				short num2 = num;
				num = (short)1754652237;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2051014656;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1961885696;
				if (num != 0)
				{
				}
				num = (short)1806303233;
				if (num != 0)
				{
				}
				this.c = value;
			}
		}

		// Token: 0x06000E01 RID: 3585 RVA: 0x00003159 File Offset: 0x00001359
		public ProgressUpdater(global::System.ComponentModel.BackgroundWorker backgroundWorker)
		{
			this.a = backgroundWorker;
			this.CurrentStep = 1;
		}

		// Token: 0x06000E02 RID: 3586 RVA: 0x001361FC File Offset: 0x001343FC
		public void UpdateWorker(global::SpecialFeatures.Flashport.FlashRadio.ApxNext.ProgressStage progressStage, object objectToShow = null)
		{
			int a_ = 3;
			short num = (short)1406271489;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					return;
				case 1:
					switch (0)
					{
					case 0:
						goto IL_3D;
					}
					continue;
				case 2:
					goto IL_5D;
				case 3:
					switch (progressStage)
					{
					case global::SpecialFeatures.Flashport.FlashRadio.ApxNext.ProgressStage.BasicProgress:
						goto IL_1C9;
					case global::SpecialFeatures.Flashport.FlashRadio.ApxNext.ProgressStage.FindValidDevice:
						goto IL_260;
					case global::SpecialFeatures.Flashport.FlashRadio.ApxNext.ProgressStage.ConnectDone:
					{
						num = (short)2115563302;
						short num3 = num;
						num = (short)1442377510;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_48;
						default:
							goto IL_2B6;
						}
						break;
					}
					case global::SpecialFeatures.Flashport.FlashRadio.ApxNext.ProgressStage.ValidateUserParams:
						goto IL_19D;
					case global::SpecialFeatures.Flashport.FlashRadio.ApxNext.ProgressStage.RadioSerialValidated:
						goto IL_AF;
					case global::SpecialFeatures.Flashport.FlashRadio.ApxNext.ProgressStage.ReadTheCodeplugStart:
						goto IL_234;
					case global::SpecialFeatures.Flashport.FlashRadio.ApxNext.ProgressStage.UnpackTheCodeplug:
						goto IL_8D;
					case global::SpecialFeatures.Flashport.FlashRadio.ApxNext.ProgressStage.FlashingRadio:
						goto IL_C3;
					case global::SpecialFeatures.Flashport.FlashRadio.ApxNext.ProgressStage.FlashingRadioError:
						goto IL_150;
					case global::SpecialFeatures.Flashport.FlashRadio.ApxNext.ProgressStage.UploadFirmware:
						goto IL_1E6;
					case global::SpecialFeatures.Flashport.FlashRadio.ApxNext.ProgressStage.UploadFirmwareDone:
						goto IL_172;
					case global::SpecialFeatures.Flashport.FlashRadio.ApxNext.ProgressStage.FirmwarePackageInvalid:
						goto IL_2F7;
					default:
						num = (short)1094320128;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				goto IL_3D;
				IL_48:
				num = (short)1768620034;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_3D:
				if (this.a == null)
				{
					goto IL_48;
				}
				num = (short)675414019;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_5D:
			num = (short)1651834880;
			short num4 = num;
			return;
			IL_8D:
			global::System.ComponentModel.BackgroundWorker backgroundWorker = this.a;
			int currentStep = this.CurrentStep;
			this.CurrentStep = currentStep + 1;
			backgroundWorker.ReportProgress(currentStep, global::CommonResources.AppResources.Unpacking_the_radio_codeplug);
			return;
			IL_AF:
			this.a.ReportProgress(this.CurrentStep, objectToShow);
			return;
			IL_C3:
			global::SpecialFeatures.Flashport.FlashRadio.ProgressUserState userState = new global::SpecialFeatures.Flashport.FlashRadio.ProgressUserState(global::SpecialFeatures.Flashport.FlashRadio.UserState.CodeplugDone, global::SpecialFeatures.Flashport.FlashRadio.UserState.FlashingComponentStart, global::CommonResources.AppResources.Flashing_radio_software);
			this.a.ReportProgress(this.CurrentStep, userState);
			return;
			IL_150:
			userState = new global::SpecialFeatures.Flashport.FlashRadio.ProgressUserState(global::SpecialFeatures.Flashport.FlashRadio.UserState.FlashingComponentError, global::SpecialFeatures.Flashport.FlashRadio.UserState.None, global::CommonResources.AppResources.Flashing_radio_software);
			this.a.ReportProgress(this.CurrentStep, userState);
			return;
			IL_172:
			userState = new global::SpecialFeatures.Flashport.FlashRadio.ProgressUserState(global::SpecialFeatures.Flashport.FlashRadio.UserState.UploadFirmwareDone, global::SpecialFeatures.Flashport.FlashRadio.UserState.None, global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("햅ﶇ뺝튡좣즥즧캩즫쪭邯\uddb3쒵햷춹\uddbb첽ꖿ郃꧅飉귋꫍맏뷑", a_));
			this.a.ReportProgress(this.CurrentStep, userState);
			return;
			IL_19D:
			userState = new global::SpecialFeatures.Flashport.FlashRadio.ProgressUserState(global::SpecialFeatures.Flashport.FlashRadio.UserState.ReadRadInfoDone, global::SpecialFeatures.Flashport.FlashRadio.UserState.None, global::CommonResources.AppResources.Validating_user_parameters);
			global::System.ComponentModel.BackgroundWorker backgroundWorker2 = this.a;
			currentStep = this.CurrentStep;
			this.CurrentStep = currentStep + 1;
			backgroundWorker2.ReportProgress(currentStep, userState);
			return;
			IL_1C9:
			global::System.ComponentModel.BackgroundWorker backgroundWorker3 = this.a;
			currentStep = this.CurrentStep;
			this.CurrentStep = currentStep + 1;
			backgroundWorker3.ReportProgress(currentStep);
			return;
			IL_1E6:
			num = (short)2023358465;
			if (num != 0)
			{
			}
			userState = new global::SpecialFeatures.Flashport.FlashRadio.ProgressUserState(global::SpecialFeatures.Flashport.FlashRadio.UserState.FlashingComponentDone, global::SpecialFeatures.Flashport.FlashRadio.UserState.None, global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("햅ﶇ뺝튡좣즥즧캩즫쪭邯\uddb3쒵햷춹\uddbb첽ꖿ郃꧅飉귋꫍맏뷑", a_));
			this.a.ReportProgress(100, userState);
			return;
			IL_234:
			userState = new global::SpecialFeatures.Flashport.FlashRadio.ProgressUserState(global::SpecialFeatures.Flashport.FlashRadio.UserState.CodeplugStart, global::SpecialFeatures.Flashport.FlashRadio.UserState.None, global::CommonResources.AppResources.Reading_the_radio_codeplug_);
			global::System.ComponentModel.BackgroundWorker backgroundWorker4 = this.a;
			currentStep = this.CurrentStep;
			this.CurrentStep = currentStep + 1;
			backgroundWorker4.ReportProgress(currentStep, userState);
			return;
			IL_260:
			userState = new global::SpecialFeatures.Flashport.FlashRadio.ProgressUserState(global::SpecialFeatures.Flashport.FlashRadio.UserState.ConnectStart, global::SpecialFeatures.Flashport.FlashRadio.UserState.None, global::CommonResources.AppResources.Find_valid_device);
			this.a.ReportProgress(this.CurrentStep, userState);
			return;
			IL_2B6:
			num = (short)1501954048;
			if (num != 0)
			{
			}
			userState = new global::SpecialFeatures.Flashport.FlashRadio.ProgressUserState(global::SpecialFeatures.Flashport.FlashRadio.UserState.ConnectDone, global::SpecialFeatures.Flashport.FlashRadio.UserState.ReadRadInfoStart, global::CommonResources.AppResources.Reading_and_validating_radio_parameters);
			global::System.ComponentModel.BackgroundWorker backgroundWorker5 = this.a;
			currentStep = this.CurrentStep;
			this.CurrentStep = currentStep + 1;
			backgroundWorker5.ReportProgress(currentStep, userState);
			return;
			IL_2F7:
			userState = new global::SpecialFeatures.Flashport.FlashRadio.ProgressUserState(global::SpecialFeatures.Flashport.FlashRadio.UserState.FlashingComponentStart, global::SpecialFeatures.Flashport.FlashRadio.UserState.FlashingComponentError, "");
			this.a.ReportProgress(this.CurrentStep, userState);
		}

		// Token: 0x06000E03 RID: 3587 RVA: 0x00136524 File Offset: 0x00134724
		public void UpdateRadioProgress(object sender, global::System.ComponentModel.ProgressChangedEventArgs e)
		{
			short num = (short)1225392133;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				num = (short)72594735;
				short num3 = num;
				num = (short)874165551;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)760086528;
					if (num != 0)
					{
					}
					int num4;
					switch (num2)
					{
					case 0:
						num4 /= this.MaxSteps;
						goto IL_111;
					case 1:
						goto IL_D2;
					case 2:
						return;
					case 3:
						if (num4 >= this.MaxSteps)
						{
							num = (short)1839464448;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_D2;
					case 4:
					{
						num = (short)477167616;
						short num5 = num;
						num4 = e.ProgressPercentage;
						num = (short)1665007619;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 5:
						switch (0)
						{
						case 0:
							goto IL_87;
						}
						continue;
					}
					IL_87:
					num = (short)941555713;
					if (num != 0)
					{
					}
					if (this.a != null)
					{
						num = (short)1796079620;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
					IL_D2:
					this.a.ReportProgress(this.CurrentStep + num4, e.UserState);
					num = (short)804388866;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				}
				IL_111:
				num = (short)1627652097;
				num2 = (int)((global::System.IntPtr)num);
			}
		}

		// Token: 0x04000754 RID: 1876
		private global::System.ComponentModel.BackgroundWorker a;

		// Token: 0x04000755 RID: 1877
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private int b;

		// Token: 0x04000756 RID: 1878
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private int c;
	}
}
