using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;
using System.Windows.Shapes;
using AcpUI.Common;
using CommonResources;
using SpecialFeatures.AcpReportManagerLib;
using SpecialFeatures.FileOperations;
using SpecialFeatures.Flashport.FlashRadio;

namespace SpecialFeatures.Comms
{
	// Token: 0x0200015C RID: 348
	public partial class ProgressUpdate : Window, IDisposable
	{
		// Token: 0x060011A6 RID: 4518 RVA: 0x00182770 File Offset: 0x00180970
		public void SetCloseBtnEnable(bool isEnable)
		{
			short num = (short)1819415755;
			short num2 = num;
			num = (short)168105163;
			switch (num2 == num)
			{
			}
			num = (short)979369985;
			if (num != 0)
			{
			}
			num = (short)2050883584;
			short num3 = num;
			num = (short)1308557312;
			if (num != 0)
			{
			}
			this.CloseBtn.IsEnabled = isEnable;
		}

		// Token: 0x060011A7 RID: 4519 RVA: 0x0000369E File Offset: 0x0000189E
		public ProgressUpdate()
		{
			this.InitializeComponent();
			Utility.SetDirection(this);
		}

		// Token: 0x060011A8 RID: 4520 RVA: 0x00182828 File Offset: 0x00180A28
		private void Page_Loaded(object A_0, RoutedEventArgs A_1)
		{
			short num = (short)1037004748;
			short num2 = num;
			num = (short)1214345164;
			switch (num2 == num)
			{
			}
			num = (short)1788411905;
			if (num != 0)
			{
			}
			num = (short)1828388864;
			short num3 = num;
			num = (short)2037055488;
			if (num != 0)
			{
			}
			this.CloseBtn.IsEnabled = false;
			this.progressBar2.Value = 0.0;
		}

		// Token: 0x060011A9 RID: 4521 RVA: 0x001828F0 File Offset: 0x00180AF0
		private void ObButtonClick_Close(object A_0, RoutedEventArgs A_1)
		{
			short num = (short)1067843585;
			if (num != 0)
			{
			}
			num = (short)836658696;
			short num2 = num;
			num = (short)312763912;
			switch (num2 == num)
			{
			}
			num = (short)441843712;
			short num3 = num;
			num = (short)1955921920;
			if (num != 0)
			{
			}
			base.Close();
		}

		// Token: 0x060011AA RID: 4522 RVA: 0x001829A4 File Offset: 0x00180BA4
		protected override void OnClosing(CancelEventArgs e)
		{
			short num = (short)19464194;
			int num2 = (int)((IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
				{
					num = (short)421527552;
					short num3 = num;
					num = (short)1472699211;
					short num4 = num;
					num = (short)1549572939;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_40;
					default:
						num = (short)959709184;
						if (num != 0)
						{
						}
						e.Cancel = true;
						num = (short)1160904705;
						num2 = (int)((IntPtr)num);
						continue;
					}
					break;
				}
				case 1:
					goto IL_E8;
				case 2:
					switch (0)
					{
					case 0:
						goto IL_30;
					}
					continue;
				}
				goto IL_30;
				IL_40:
				num = (short)179699712;
				num2 = (int)((IntPtr)num);
				continue;
				IL_30:
				if (!this.CloseBtn.IsEnabled)
				{
					goto IL_40;
				}
				break;
			}
			IL_E8:
			num = (short)702152705;
			if (num != 0)
			{
			}
		}

		// Token: 0x060011AB RID: 4523 RVA: 0x00182AC4 File Offset: 0x00180CC4
		protected virtual void Dispose(bool disposing)
		{
			short num = (short)764980774;
			short num2 = num;
			num = (short)2037231142;
			switch (num2 == num)
			{
			}
			num = (short)479330305;
			if (num != 0)
			{
			}
			num = (short)1773076480;
			short num3 = num;
			num = (short)207814656;
			if (num != 0)
			{
			}
		}

		// Token: 0x060011AC RID: 4524 RVA: 0x00182B74 File Offset: 0x00180D74
		public void Dispose()
		{
			short num = (short)1796086092;
			short num2 = num;
			num = (short)1397496140;
			switch (num2 == num)
			{
			}
			num = (short)305659904;
			if (num != 0)
			{
			}
			num = (short)1509294080;
			short num3 = num;
			num = (short)1952120833;
			if (num != 0)
			{
			}
			this.Dispose(true);
			GC.SuppressFinalize(this);
		}

		// Token: 0x060011AD RID: 4525 RVA: 0x00182C28 File Offset: 0x00180E28
		public void ProgressUpdat(object sender, ProgressChangedEventArgs e)
		{
			switch (0)
			{
			case 0:
				goto IL_38;
			}
			short num2;
			ProgressUserState progressUserState;
			UserState currentUserState;
			for (;;)
			{
				IL_0A:
				int num;
				switch (num)
				{
				case 0:
					this.VerificationIndicator.Visibility = Visibility.Hidden;
					this.VerificationText.Visibility = Visibility.Hidden;
					this.CodeplugIndicator.Visibility = Visibility.Hidden;
					this.CodeplugText.Visibility = Visibility.Hidden;
					this.CloseBtn.IsEnabled = true;
					num2 = (short)1674051593;
					num = (int)((IntPtr)num2);
					continue;
				case 1:
					goto IL_528;
				case 2:
					goto IL_101;
				case 3:
					return;
				case 4:
				{
					num2 = (short)316211200;
					short num3 = num2;
					if (progressUserState != null)
					{
						num2 = (short)1495465986;
						num = (int)((IntPtr)num2);
						continue;
					}
					return;
				}
				case 5:
					goto IL_2A1;
				case 6:
					if (progressUserState.UserText == AppResources.Radio_Serial_Number_updated)
					{
						num2 = (short)740622337;
						num = (int)((IntPtr)num2);
						continue;
					}
					return;
				case 7:
					switch (currentUserState)
					{
					case UserState.ConnectStart:
						goto IL_16D;
					case UserState.ConnectError:
						goto IL_390;
					case UserState.ConnectDone:
						goto IL_131;
					case UserState.ReadRadInfoStart:
						goto IL_22A;
					case UserState.ReadRadInfoError:
						this.ProgText.Text = progressUserState.UserText;
						this.ReadingRadioInformationIndicator.BusyState = BusyStates.COMPLETE_WITH_ERROR;
						this.CodeplugIndicator.BusyState = BusyStates.NOT_BUSY;
						this.VerificationIndicator.BusyState = BusyStates.NOT_BUSY;
						num2 = (short)379060232;
						num = (int)((IntPtr)num2);
						continue;
					case UserState.ReadRadInfoDone:
						this.ProgText.Text = progressUserState.UserText;
						this.ReadingRadioInformationIndicator.BusyState = BusyStates.COMPLETE_NO_ERROR;
						num2 = (short)1617625094;
						num = (int)((IntPtr)num2);
						continue;
					case UserState.CodeplugStart:
						goto IL_113;
					case UserState.CodeplugError:
						goto IL_52E;
					case UserState.CodeplugDone:
						goto IL_4A8;
					case UserState.FlashingComponentStart:
						goto IL_106;
					case UserState.FlashingComponentError:
						goto IL_197;
					case UserState.FlashingComponentDone:
						goto IL_474;
					case UserState.FinalValidationStart:
						goto IL_14F;
					case UserState.FinalValidationError:
						goto IL_248;
					case UserState.FinalValidationDone:
						goto IL_1C3;
					case UserState.UploadFirmwareStart:
					case UserState.UploadFirmwareDone:
					case UserState.UploadFirmwareError:
					case UserState.FirmwarePackageInvalid:
						return;
					case UserState.None:
						this.ProgText.Text = progressUserState.UserText;
						num2 = (short)1786576901;
						num = (int)((IntPtr)num2);
						continue;
					default:
						num2 = (short)1821048835;
						num = (int)((IntPtr)num2);
						continue;
					}
					break;
				case 8:
					if (progressUserState.UserText == AppResources.Radio_Serial_Number_update_failed)
					{
						num2 = (short)1451556864;
						num = (int)((IntPtr)num2);
						continue;
					}
					goto IL_460;
				case 9:
					goto IL_2F9;
				}
				goto IL_38;
			}
			IL_101:
			currentUserState = progressUserState.CurrentUserState;
			goto IL_305;
			IL_106:
			this.CodeplugIndicator.BusyState = BusyStates.BUSY;
			return;
			IL_113:
			this.ProgText.Text = progressUserState.UserText;
			this.CodeplugIndicator.BusyState = BusyStates.BUSY;
			return;
			IL_131:
			this.ProgText.Text = progressUserState.UserText;
			this.ConnectingToRadioIndicator.BusyState = BusyStates.COMPLETE_NO_ERROR;
			return;
			IL_14F:
			this.ProgText.Text = progressUserState.UserText;
			this.VerificationIndicator.BusyState = BusyStates.BUSY;
			return;
			IL_16D:
			this.ProgText.Text = progressUserState.UserText;
			this.ConnectingToRadioIndicator.BusyState = BusyStates.BUSY;
			this.CloseBtn.IsEnabled = false;
			return;
			IL_197:
			this.CodeplugIndicator.BusyState = BusyStates.COMPLETE_WITH_ERROR;
			this.VerificationIndicator.BusyState = BusyStates.NOT_BUSY;
			this.CloseBtn.IsEnabled = true;
			this.bCommSuccess = false;
			return;
			IL_1C3:
			this.ProgText.Text = progressUserState.UserText;
			this.VerificationIndicator.BusyState = BusyStates.COMPLETE_NO_ERROR;
			this.CloseBtn.IsEnabled = true;
			return;
			IL_22A:
			this.ProgText.Text = progressUserState.UserText;
			this.ReadingRadioInformationIndicator.BusyState = BusyStates.BUSY;
			return;
			IL_248:
			this.ProgText.Text = progressUserState.UserText;
			this.VerificationIndicator.BusyState = BusyStates.COMPLETE_WITH_ERROR;
			this.CloseBtn.IsEnabled = true;
			this.bCommSuccess = false;
			return;
			IL_2A1:
			return;
			IL_2F9:
			goto IL_460;
			IL_390:
			this.ProgText.Text = progressUserState.UserText;
			this.ConnectingToRadioIndicator.BusyState = BusyStates.COMPLETE_WITH_ERROR;
			this.ReadingRadioInformationIndicator.BusyState = BusyStates.NOT_BUSY;
			this.CodeplugIndicator.BusyState = BusyStates.NOT_BUSY;
			this.VerificationIndicator.BusyState = BusyStates.NOT_BUSY;
			this.CloseBtn.IsEnabled = true;
			this.bCommSuccess = false;
			return;
			IL_460:
			this.CloseBtn.IsEnabled = true;
			this.bCommSuccess = false;
			return;
			IL_474:
			num2 = (short)914489345;
			if (num2 != 0)
			{
			}
			this.CodeplugIndicator.BusyState = BusyStates.COMPLETE_NO_ERROR;
			return;
			IL_4A8:
			this.ProgText.Text = progressUserState.UserText;
			this.CodeplugIndicator.BusyState = BusyStates.COMPLETE_NO_ERROR;
			return;
			IL_528:
			this.VerificationIndicator.Visibility = Visibility.Hidden;
			this.VerificationText.Visibility = Visibility.Hidden;
			this.CodeplugIndicator.Visibility = Visibility.Hidden;
			this.CodeplugText.Visibility = Visibility.Hidden;
			this.CloseBtn.IsEnabled = true;
			return;
			IL_52E:
			this.ProgText.Text = progressUserState.UserText;
			this.CodeplugIndicator.BusyState = BusyStates.COMPLETE_WITH_ERROR;
			this.VerificationIndicator.BusyState = BusyStates.NOT_BUSY;
			this.CloseBtn.IsEnabled = true;
			this.bCommSuccess = false;
			return;
			IL_38:
			this.progressBar2.Value = (double)e.ProgressPercentage;
			progressUserState = (ProgressUserState)e.UserState;
			num2 = (short)1424254440;
			short num4 = num2;
			num2 = (short)34760168;
			switch ((num4 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
			{
				IL_305:
				num2 = (short)1474232327;
				int num = (int)((IntPtr)num2);
				goto IL_0A;
			}
			default:
			{
				num2 = (short)1181548544;
				if (num2 != 0)
				{
				}
				num2 = (short)1940979716;
				int num = (int)((IntPtr)num2);
				goto IL_0A;
			}
			}
		}

		// Token: 0x060011AE RID: 4526 RVA: 0x001831A0 File Offset: 0x001813A0
		public void ClearStatus()
		{
			short num = (short)730005504;
			short num2 = num;
			num = (short)962265089;
			if (num != 0)
			{
			}
			num = (short)1187807075;
			short num3 = num;
			num = (short)34570083;
			switch (num3 == num)
			{
			}
			num = (short)363069440;
			if (num != 0)
			{
			}
			this.ConnectingToRadioIndicator.BusyState = BusyStates.NOT_BUSY;
			this.ReadingRadioInformationIndicator.BusyState = BusyStates.NOT_BUSY;
			this.CodeplugIndicator.BusyState = BusyStates.NOT_BUSY;
			this.VerificationIndicator.BusyState = BusyStates.NOT_BUSY;
			this.VerificationText.Visibility = Visibility.Visible;
			this.VerificationIndicator.Visibility = Visibility.Visible;
			this.CodeplugIndicator.Visibility = Visibility.Visible;
			this.CodeplugText.Visibility = Visibility.Visible;
			this.ProgText.Text = "";
			this.CloseBtn.IsEnabled = false;
			this.bCommSuccess = true;
		}

		// Token: 0x040009A5 RID: 2469
		public bool bCommSuccess = true;
	}
}
