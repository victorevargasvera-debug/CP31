using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Windows;
using CommonResources;
using PreEmptive.SoS.Runtime;

namespace MackinawCPS.Log
{
	// Token: 0x02000077 RID: 119
	internal class UpdateLogSettingViewModel
	{
		// Token: 0x06000531 RID: 1329 RVA: 0x000E6770 File Offset: 0x000E4970
		internal UpdateLogSettingViewModel(global::MackinawCPS.Log.UpdateLogSettingView view, global::MackinawCPS.Log.LogSetting logSetting)
		{
			this._view = view;
			this.<LogSetting>k__BackingField = logSetting;
			this.<UpdateLogSettingCommand>k__BackingField = new global::MackinawCPS.CpsCommand(new global::System.Action<object>(this.UpdateLogSetting), new global::System.Func<object, bool>(this.CanUpdateLogSetting));
		}

		// Token: 0x17000090 RID: 144
		// (get) Token: 0x06000532 RID: 1330 RVA: 0x000E67B4 File Offset: 0x000E49B4
		public global::MackinawCPS.Log.LogSetting LogSetting
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1363214337;
				if (num != 0)
				{
				}
				num = (short)2067726336;
				short num2 = num;
				num = (short)1296377875;
				short num3 = num;
				num = (short)1262495763;
				switch (num3 == num)
				{
				}
				num = (short)2120286208;
				if (num != 0)
				{
				}
				return this.<LogSetting>k__BackingField;
			}
		}

		// Token: 0x17000091 RID: 145
		// (get) Token: 0x06000533 RID: 1331 RVA: 0x000E6864 File Offset: 0x000E4A64
		public global::MackinawCPS.CpsCommand UpdateLogSettingCommand
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1614575762;
				short num2 = num;
				num = (short)342259858;
				switch (num2 == num)
				{
				default:
				{
					num = (short)139526144;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)112459776;
				if (num != 0)
				{
				}
				num = (short)351141889;
				if (num != 0)
				{
				}
				return this.<UpdateLogSettingCommand>k__BackingField;
			}
		}

		// Token: 0x06000534 RID: 1332 RVA: 0x000E6914 File Offset: 0x000E4B14
		private void UpdateLogSetting(object logSetting)
		{
			int a_ = 9;
			short num;
			try
			{
				num = (short)148111360;
				int num2 = (int)num;
				switch (num2)
				{
				default:
				{
					switch (0)
					{
					case 0:
						goto IL_60;
					}
					global::MackinawCPS.WindowMain windowMain;
					bool hideLogUploadDialog;
					for (;;)
					{
						IL_31:
						bool flag;
						bool uploadToServer;
						switch (num2)
						{
						case 0:
							this.LogSetting.UploadToServer = flag;
							windowMain.settingsSavedOnAppExit.UploadToServer = flag;
							windowMain.settingsSavedOnAppExit.Save();
							num = (short)460521478;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							goto IL_175;
						case 2:
							goto IL_22E;
						case 3:
						{
							string fileName = global::System.Diagnostics.Process.GetCurrentProcess().MainModule.FileName;
							global::System.Diagnostics.Process.Start(new global::System.Diagnostics.ProcessStartInfo(global::System.IO.Path.Combine(global::System.Reflection.Assembly.GetEntryAssembly().Location, fileName)));
							global::System.Environment.Exit(0);
							num = (short)711393282;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 4:
							goto IL_293;
						case 5:
							goto IL_1DD;
						case 6:
							if (this.LogSetting.RestartOption == global::MackinawCPS.Log.RestartOptions.Now)
							{
								num = (short)535363587;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::System.Windows.MessageBox.Show(global::CommonResources.AppResources.APXCPS_Logging_Change_Notification, global::CommonResources.AppResources.APXCPS_Log);
							num = (short)2036006921;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 7:
							if (flag != uploadToServer)
							{
								num = (short)1517813760;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_22E;
						case 8:
							if (this.LogSetting.HideDialogChecked != hideLogUploadDialog)
							{
								num = (short)242286593;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_1DD;
						case 9:
							goto IL_22E;
						}
						goto IL_60;
						IL_175:
						windowMain.settingsSavedOnAppExit.HideLogUploadDialog = this.LogSetting.HideDialogChecked;
						windowMain.settingsSavedOnAppExit.Save();
						num = (short)896073733;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_22E:
						num = (short)615300426;
						short num3 = num;
						num = (short)638434634;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_175;
						default:
							num = (short)1774452736;
							if (num != 0)
							{
							}
							num = (short)1598029828;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_1DD:
						flag = bool.Parse((string)logSetting);
						uploadToServer = windowMain.settingsSavedOnAppExit.UploadToServer;
						num = (short)1815871495;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_293:
					break;
					IL_60:
					windowMain = (global::MackinawCPS.WindowMain)global::System.Windows.Application.Current.MainWindow;
					hideLogUploadDialog = windowMain.settingsSavedOnAppExit.HideLogUploadDialog;
					num = (short)914620424;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_31;
				}
				}
			}
			catch (global::System.Exception ex)
			{
				global::System.Windows.MessageBox.Show(global::PreEmptive.SoS.Runtime.FixedLengthStream.b("골駪鿬胮菰폲ꃴ蟶鷸髺觼雾漀搂┄䬆昈氊堌缎紐簒琔猖㤘䠚砜欞唠䨢䬤䀦娨ପ,༮", a_) + ex.Message);
			}
			num = (short)1445658624;
			short num4 = num;
			num = (short)1085865985;
			if (num != 0)
			{
			}
			((global::System.Windows.Window)this._view.Parent).Close();
		}

		// Token: 0x06000535 RID: 1333 RVA: 0x000E6C5C File Offset: 0x000E4E5C
		private bool CanUpdateLogSetting(object parameter)
		{
			short num = (short)174260225;
			if (num != 0)
			{
			}
			num = (short)16056320;
			short num2 = num;
			num = (short)377187237;
			short num3 = num;
			num = (short)282946469;
			switch (num3 == num)
			{
			}
			num = (short)1414397952;
			if (num != 0)
			{
			}
			return true;
		}

		// Token: 0x04000300 RID: 768
		private global::MackinawCPS.Log.UpdateLogSettingView _view;

		// Token: 0x04000303 RID: 771
		[global::System.NonSerialized]
		private string VafgnaprSvryq = 32;
	}
}
