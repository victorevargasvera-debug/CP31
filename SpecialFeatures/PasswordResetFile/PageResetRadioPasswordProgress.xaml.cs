using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Navigation;
using System.Windows.Shapes;
using ACPBrowser;
using AcpUI.Common;
using CommonResources;
using SpecialFeatures.AcpReportManagerLib;
using SpecialFeatures.FileOperations;
using SpecialFeatures.Flashport.FlashRadio;
using SpecialFeatures.ReadWritePassword;

namespace SpecialFeatures.PasswordResetFile
{
	// Token: 0x020000A6 RID: 166
	public partial class PageResetRadioPasswordProgress : PageFunction<DialogResult>, IDisposable
	{
		// Token: 0x06000B70 RID: 2928 RVA: 0x000DD48C File Offset: 0x000DB68C
		public PageResetRadioPasswordProgress(FileOperationData flashData, ReadWritePasswordApp readWritePasswordApp)
		{
			int a_ = 4;
			base..ctor();
			if (flashData == null)
			{
				throw new ArgumentNullException(RptMgrErrorHandler.b("캆ﶒ랖ﾘﲜ즠쒤펦좨讪캬캮\udfb0\uddb2\udab4쎶馸\ud9ba\ud8bc龾꿀뛂꧄ꯆ", a_), RptMgrErrorHandler.b("ﺌ햐", a_));
			}
			this.b = readWritePasswordApp;
			this.c = new BackgroundWorker
			{
				WorkerReportsProgress = true
			};
			this.a = flashData;
			this.a.CurrentPage = this;
			AcpUI.Common.Utility.SetDirection(this);
			this.InitializeComponent();
			this.a();
			this.ViewboxTitle.Content = this.a.ProgressDialogTitleContent;
			this.CloseBtn.IsEnabled = false;
		}

		// Token: 0x06000B71 RID: 2929 RVA: 0x000DD530 File Offset: 0x000DB730
		public void Dispose()
		{
			short num = (short)766709458;
			short num2 = num;
			num = (short)1622937298;
			switch (num2 == num)
			{
			}
			num = (short)770375681;
			if (num != 0)
			{
			}
			num = (short)1285881856;
			short num3 = num;
			num = (short)154664960;
			if (num != 0)
			{
			}
			this.Dispose(true);
			GC.SuppressFinalize(this);
		}

		// Token: 0x06000B72 RID: 2930 RVA: 0x000DD5E8 File Offset: 0x000DB7E8
		protected virtual void Dispose(bool disposing)
		{
			short num = (short)1356005378;
			int num2 = (int)((IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					if (this.c != null)
					{
						num = (short)1443102721;
						if (num != 0)
						{
						}
						num = (short)1240989697;
						num2 = (int)((IntPtr)num);
						continue;
					}
					return;
				case 1:
					this.c.Dispose();
					this.c = null;
					num = (short)783613956;
					num2 = (int)((IntPtr)num);
					continue;
				case 2:
					switch (0)
					{
					case 0:
						goto IL_38;
					}
					continue;
				case 3:
					num = (short)1114112;
					num2 = (int)((IntPtr)num);
					continue;
				case 4:
					return;
				}
				IL_38:
				num = (short)1828373845;
				short num3 = num;
				num = (short)1693304149;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					return;
				case 1:
					break;
				default:
				{
					num = (short)175177728;
					short num4 = num;
					break;
				}
				}
				num = (short)1458634752;
				if (num != 0)
				{
				}
				if (!disposing)
				{
					break;
				}
				num = (short)623509507;
				num2 = (int)((IntPtr)num);
			}
		}

		// Token: 0x06000B73 RID: 2931 RVA: 0x000DD754 File Offset: 0x000DB954
		private void a()
		{
			short num = (short)1216862991;
			short num2 = num;
			num = (short)817945359;
			switch (num2 == num)
			{
			}
			num = (short)673316865;
			if (num != 0)
			{
			}
			num = (short)2131886080;
			short num3 = num;
			num = (short)1353777152;
			if (num != 0)
			{
			}
			this.c.DoWork += this.OnBackgroundWorkerDoWork;
			this.c.RunWorkerCompleted += this.OnBackgroundWorkerRunWorkerCompleted;
			this.c.ProgressChanged += this.OnBackgroundWorkerProgressChanged;
		}

		// Token: 0x06000B74 RID: 2932 RVA: 0x000DD844 File Offset: 0x000DBA44
		private void OnBackgroundWorkerDoWork(object A_0, DoWorkEventArgs A_1)
		{
			short num = (short)1390870529;
			if (num != 0)
			{
			}
			num = (short)40933764;
			short num2 = num;
			num = (short)2029754756;
			switch (num2 == num)
			{
			}
			num = (short)1166868480;
			short num3 = num;
			num = (short)2146435072;
			if (num != 0)
			{
			}
			this.UploadPasswordResetFile((string)A_1.Argument, A_1);
		}

		// Token: 0x06000B75 RID: 2933 RVA: 0x000DD900 File Offset: 0x000DBB00
		private void OnBackgroundWorkerRunWorkerCompleted(object A_0, RunWorkerCompletedEventArgs A_1)
		{
			short num = (short)605487114;
			int num2 = (int)((IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					if (this.ResetFileValidationIndicator.BusyState == BusyStates.BUSY)
					{
						num = (short)1463156743;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_223;
				case 1:
					this.ConnectBusyIndicator.BusyState = BusyStates.COMPLETE_WITH_ERROR;
					num = (short)861339649;
					if (num != 0)
					{
					}
					num = (short)1096024076;
					num2 = (int)((IntPtr)num);
					continue;
				case 2:
					this.ResetIndicator.BusyState = BusyStates.COMPLETE_WITH_ERROR;
					num = (short)723976197;
					num2 = (int)((IntPtr)num);
					continue;
				case 3:
					goto IL_223;
				case 4:
					this.VerifyBusyIndicator.BusyState = BusyStates.COMPLETE_WITH_ERROR;
					num = (short)1838940169;
					num2 = (int)((IntPtr)num);
					continue;
				case 5:
					goto IL_160;
				case 6:
					if (this.VerifyBusyIndicator.BusyState == BusyStates.BUSY)
					{
						num = (short)1913782276;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_A9;
				case 7:
					this.ResetFileValidationIndicator.BusyState = BusyStates.COMPLETE_WITH_ERROR;
					num = (short)952303619;
					num2 = (int)((IntPtr)num);
					continue;
				case 8:
					if (this.ResetIndicator.BusyState == BusyStates.BUSY)
					{
						num = (short)1822818306;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_2FE;
				case 9:
				{
					num = (short)1112408064;
					short num3 = num;
					goto IL_A9;
				}
				case 10:
					switch (0)
					{
					case 0:
						goto IL_5C;
					}
					continue;
				case 11:
					for (;;)
					{
						this.myStsParagraph.Inlines.Clear();
						this.myStsParagraph.Inlines.Add(A_1.Error.Message);
						num = (short)312340370;
						short num4 = num;
						num = (short)560197522;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							goto IL_1C6;
						}
					}
					IL_1C6:
					num = (short)399704064;
					if (num != 0)
					{
					}
					num = (short)187367437;
					num2 = (int)((IntPtr)num);
					continue;
				case 12:
					goto IL_2B9;
				case 13:
					if (this.ConnectBusyIndicator.BusyState == BusyStates.BUSY)
					{
						num = (short)982515713;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_2B9;
				}
				IL_5C:
				if (A_1.Error != null)
				{
					num = (short)1344667659;
					num2 = (int)((IntPtr)num);
					continue;
				}
				break;
				IL_A9:
				num = (short)1108410368;
				num2 = (int)((IntPtr)num);
				continue;
				IL_223:
				num = (short)1228668936;
				num2 = (int)((IntPtr)num);
				continue;
				IL_2B9:
				num = (short)287244294;
				num2 = (int)((IntPtr)num);
			}
			IL_160:
			IL_2FE:
			this.CloseBtn.IsEnabled = true;
			this.a.OkToCancel = true;
		}

		// Token: 0x06000B76 RID: 2934 RVA: 0x000DDC24 File Offset: 0x000DBE24
		private void OnBackgroundWorkerProgressChanged(object A_0, ProgressChangedEventArgs A_1)
		{
			switch (0)
			{
			case 0:
				goto IL_24;
			}
			RadioInfoParams radioInfoParams;
			short num2;
			ProgressUserState progressUserState;
			for (;;)
			{
				IL_0A:
				int num;
				switch (num)
				{
				case 0:
					if (radioInfoParams != null)
					{
						num2 = (short)288030721;
						num = (int)((IntPtr)num2);
						continue;
					}
					goto IL_1B3;
				case 1:
					this.RadioModelTextBox.Text = radioInfoParams.ModelNumber;
					this.RadioSerialNoTextBox.Text = radioInfoParams.SerialNumber;
					num2 = (short)1591476228;
					num = (int)((IntPtr)num2);
					continue;
				case 2:
					if (progressUserState != null)
					{
						num2 = (short)1031733251;
						num = (int)((IntPtr)num2);
						continue;
					}
					goto IL_105;
				case 3:
					goto IL_C2;
				case 4:
					goto IL_100;
				}
				goto IL_24;
			}
			IL_C2:
			num2 = (short)2030239745;
			if (num2 != 0)
			{
			}
			this.myStsParagraph.Inlines.Clear();
			this.myStsParagraph.Inlines.Add(progressUserState.UserText);
			this.a(progressUserState.CurrentUserState);
			this.a(progressUserState.NewUserState);
			return;
			IL_100:
			goto IL_1B3;
			IL_105:
			radioInfoParams = (A_1.UserState as RadioInfoParams);
			goto IL_111;
			IL_1B3:
			num2 = (short)1106640896;
			short num3 = num2;
			return;
			IL_24:
			this.progressBar2.Value = (double)A_1.ProgressPercentage;
			progressUserState = (A_1.UserState as ProgressUserState);
			num2 = (short)188717064;
			short num4 = num2;
			num2 = (short)497522696;
			switch ((num4 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
			{
				IL_111:
				num2 = (short)686948352;
				int num = (int)((IntPtr)num2);
				goto IL_0A;
			}
			default:
			{
				num2 = (short)2007367680;
				if (num2 != 0)
				{
				}
				num2 = (short)399572994;
				int num = (int)((IntPtr)num2);
				goto IL_0A;
			}
			}
		}

		// Token: 0x06000B77 RID: 2935 RVA: 0x000DDE10 File Offset: 0x000DC010
		private void a(UserState A_0)
		{
			int a_ = 8;
			short num = (short)673579009;
			int num2 = (int)((IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_200;
				case 1:
					num = (short)1639186433;
					if (num != 0)
					{
					}
					switch (0)
					{
					case 0:
						goto IL_60;
					}
					continue;
				case 2:
				{
					num = (short)1685205082;
					short num3 = num;
					num = (short)932917338;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						return;
					default:
						num = (short)319684608;
						if (num != 0)
						{
						}
						num = (short)1923350528;
						num2 = (int)((IntPtr)num);
						continue;
					}
					break;
				}
				}
				IL_60:
				num = (short)1623195648;
				short num4 = num;
				switch (A_0)
				{
				case UserState.ConnectStart:
					goto IL_161;
				case UserState.ConnectError:
					goto IL_147;
				case UserState.ConnectDone:
					goto IL_1B5;
				case UserState.ReadRadInfoStart:
					goto IL_1DC;
				case UserState.ReadRadInfoError:
					goto IL_205;
				case UserState.ReadRadInfoDone:
					goto IL_1A8;
				case UserState.ResetFileValidationStart:
					goto IL_13A;
				case UserState.ResetFileValidationDone:
					goto IL_12D;
				case UserState.ResetFileValidationError:
					goto IL_1CF;
				case UserState.ResetPasswordStart:
					goto IL_16E;
				case UserState.ResetPasswordDone:
					goto IL_1C2;
				case UserState.ResetPasswordError:
					goto IL_154;
				case UserState.None:
					return;
				default:
					num = (short)2001600514;
					num2 = (int)((IntPtr)num);
					break;
				}
			}
			IL_12D:
			this.ResetFileValidationIndicator.BusyState = BusyStates.COMPLETE_NO_ERROR;
			return;
			IL_13A:
			this.ResetFileValidationIndicator.BusyState = BusyStates.BUSY;
			return;
			IL_147:
			this.ConnectBusyIndicator.BusyState = BusyStates.COMPLETE_WITH_ERROR;
			return;
			IL_154:
			this.ResetIndicator.BusyState = BusyStates.COMPLETE_WITH_ERROR;
			return;
			IL_161:
			this.ConnectBusyIndicator.BusyState = BusyStates.BUSY;
			return;
			IL_16E:
			this.ResetIndicator.BusyState = BusyStates.BUSY;
			return;
			IL_1A8:
			this.VerifyBusyIndicator.BusyState = BusyStates.COMPLETE_NO_ERROR;
			return;
			IL_1B5:
			this.ConnectBusyIndicator.BusyState = BusyStates.COMPLETE_NO_ERROR;
			return;
			IL_1C2:
			this.ResetIndicator.BusyState = BusyStates.COMPLETE_NO_ERROR;
			return;
			IL_1CF:
			this.ResetFileValidationIndicator.BusyState = BusyStates.COMPLETE_WITH_ERROR;
			return;
			IL_1DC:
			this.VerifyBusyIndicator.BusyState = BusyStates.BUSY;
			return;
			IL_200:
			throw new ArgumentException(string.Format(RptMgrErrorHandler.b("얊ﮎ놐쒠잢薤슦잨\udeaa사辮잰튲\ud9b4슶\udcb8膺鶼쒾뻂", a_), A_0), RptMgrErrorHandler.b("ﺊﺌ삒ﺚ", a_));
			IL_205:
			this.VerifyBusyIndicator.BusyState = BusyStates.COMPLETE_WITH_ERROR;
		}

		// Token: 0x06000B78 RID: 2936 RVA: 0x000DE030 File Offset: 0x000DC230
		private void UploadPasswordResetFile(string A_0, DoWorkEventArgs A_1)
		{
			short num = (short)443154433;
			int num2 = (int)((IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_132;
				case 1:
					switch (0)
					{
					case 0:
						goto IL_35;
					}
					continue;
				case 2:
				{
					num = (short)103705974;
					short num3 = num;
					num = (short)66940278;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_137;
					default:
						num = (short)49020929;
						if (num != 0)
						{
						}
						num = (short)785842176;
						if (num != 0)
						{
						}
						num = (short)1632370691;
						num2 = (int)((IntPtr)num);
						continue;
					}
					break;
				}
				case 3:
					if (!File.Exists(A_0))
					{
						num = (short)346882048;
						short num4 = num;
						num = (short)481886208;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_137;
				}
				IL_35:
				if (string.IsNullOrEmpty(A_0))
				{
					break;
				}
				num = (short)537853954;
				num2 = (int)((IntPtr)num);
			}
			IL_53:
			throw new ArgumentException(AppResources.Invalid_reset_password_file);
			IL_132:
			goto IL_53;
			IL_137:
			new SendPasswordResetFileExecutor(this.c, this.b).SendPasswordResetFile(A_0);
		}

		// Token: 0x06000B79 RID: 2937 RVA: 0x000DE18C File Offset: 0x000DC38C
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
					goto IL_17C;
				case 1:
					return;
				case 2:
					goto IL_146;
				case 3:
				{
					num2 = (short)1666717374;
					short num3 = num2;
					num2 = (short)752293566;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_17C;
					case 1:
						break;
					default:
					{
						num2 = (short)1175912448;
						short num4 = num2;
						break;
					}
					}
					num2 = (short)1923678208;
					if (num2 != 0)
					{
					}
					num2 = (short)472776705;
					if (num2 != 0)
					{
					}
					if (!this.c.IsBusy)
					{
						num2 = (short)905707524;
						num = (int)((IntPtr)num2);
						continue;
					}
					goto IL_146;
				}
				case 4:
					this.c.RunWorkerAsync(this.a.FilePath);
					num2 = (short)1670578178;
					num = (int)((IntPtr)num2);
					continue;
				case 5:
					if (!base.IsKeyboardFocusWithin)
					{
						num2 = (short)740687872;
						num = (int)((IntPtr)num2);
						continue;
					}
					return;
				}
				goto IL_28;
				IL_146:
				num2 = (short)1970274309;
				num = (int)((IntPtr)num2);
				continue;
				IL_17C:
				Keyboard.Focus(this);
				num2 = (short)979107841;
				num = (int)((IntPtr)num2);
			}
			return;
			IL_28:
			this.myStsParagraph.Inlines.Clear();
			base.NavigationService.Navigating += this.NavigationService_Navigating;
			num2 = (short)1918238723;
			num = (int)((IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000B7A RID: 2938 RVA: 0x000DE348 File Offset: 0x000DC548
		private void NavigationService_Navigating(object A_0, NavigatingCancelEventArgs A_1)
		{
			short num = (short)1169162241;
			if (num != 0)
			{
			}
			num = (short)562615603;
			short num2 = num;
			num = (short)801035571;
			switch (num2 == num)
			{
			}
			num = (short)2023096320;
			short num3 = num;
			num = (short)1598750720;
			if (num != 0)
			{
			}
			A_1.Cancel = true;
		}

		// Token: 0x06000B7B RID: 2939 RVA: 0x000DE3FC File Offset: 0x000DC5FC
		private void ObButtonClick_Close(object A_0, RoutedEventArgs A_1)
		{
			short num = (short)1012269057;
			if (num != 0)
			{
			}
			num = (short)2030219281;
			short num2 = num;
			num = (short)1740419089;
			switch (num2 == num)
			{
			}
			num = (short)1279328256;
			short num3 = num;
			num = (short)813170688;
			if (num != 0)
			{
			}
			this.OnReturn(new ReturnEventArgs<DialogResult>(DialogResult.Finished));
		}

		// Token: 0x06000B7C RID: 2940 RVA: 0x000DE4B4 File Offset: 0x000DC6B4
		private void F1HelpCommandCanExcute(object A_0, CanExecuteRoutedEventArgs A_1)
		{
			short num = (short)1755876168;
			short num2 = num;
			num = (short)184126280;
			switch (num2 == num)
			{
			}
			num = (short)691339265;
			if (num != 0)
			{
			}
			num = (short)259981312;
			short num3 = num;
			num = (short)1011023872;
			if (num != 0)
			{
			}
			A_1.CanExecute = true;
		}

		// Token: 0x06000B7D RID: 2941 RVA: 0x000DE564 File Offset: 0x000DC764
		private void buttonHelp_Click(object A_0, RoutedEventArgs A_1)
		{
			short num;
			try
			{
				num = (short)1609255805;
				short num2 = num;
				num = (short)561793917;
				switch (num2 == num)
				{
				}
				num = (short)1414397952;
				if (num != 0)
				{
				}
				ACPBrowser.Utility.CloseHelpWindowIfOpen();
				ACPBrowser.Utility.DisplayCPSHelpDITA(this.a.ProgressDialogHelpTopicId);
			}
			catch (Exception)
			{
			}
			num = (short)521666560;
			short num3 = num;
			num = (short)2058354689;
			if (num != 0)
			{
			}
		}

		// Token: 0x06000B7E RID: 2942 RVA: 0x000DE638 File Offset: 0x000DC838
		public void FlashportPage_Return(object sender, ReturnEventArgs<DialogResult> e)
		{
			short num = (short)103783835;
			short num2 = num;
			num = (short)1599839643;
			switch (num2 == num)
			{
			default:
			{
				num = (short)623312896;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)699793408;
			if (num != 0)
			{
			}
			num = (short)830078977;
			if (num != 0)
			{
			}
			this.OnReturn(e);
		}

		// Token: 0x040004F9 RID: 1273
		private readonly FileOperationData a;

		// Token: 0x040004FA RID: 1274
		private readonly ReadWritePasswordApp b;

		// Token: 0x040004FB RID: 1275
		private BackgroundWorker c;
	}
}
