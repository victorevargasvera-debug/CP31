using System;
using System.Net;
using System.Runtime.CompilerServices;
using System.Security;
using System.Threading;
using System.Windows;
using System.Windows.Threading;
using CommonResources;
using SpecialFeatures.AcpReportManagerLib;
using SpecialFeatures.Comms;

namespace SpecialFeatures.ReadWritePassword
{
	// Token: 0x02000063 RID: 99
	public class ReadWritePasswordApp : global::System.IDisposable
	{
		// Token: 0x060008A1 RID: 2209 RVA: 0x00002A0F File Offset: 0x00000C0F
		private ReadWritePasswordApp()
		{
			this.e = new global::System.Security.SecureString();
			this.b = new global::SpecialFeatures.ReadWritePassword.ReadWriteUtil();
		}

		// Token: 0x170003A3 RID: 931
		// (get) Token: 0x060008A2 RID: 2210 RVA: 0x00092704 File Offset: 0x00090904
		// (set) Token: 0x060008A3 RID: 2211 RVA: 0x000927B0 File Offset: 0x000909B0
		public bool IsPasswordStoredForCurrentSession
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1252065281;
				if (num != 0)
				{
				}
				num = (short)453779557;
				short num2 = num;
				num = (short)1332027493;
				switch (num2 == num)
				{
				default:
				{
					num = (short)929234944;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1848377344;
				if (num != 0)
				{
				}
				return this.f;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1972599450;
				short num2 = num;
				num = (short)270498458;
				switch (num2 == num)
				{
				}
				num = (short)772603904;
				short num3 = num;
				num = (short)2011234305;
				if (num != 0)
				{
				}
				num = (short)827523072;
				if (num != 0)
				{
				}
				this.f = value;
			}
		}

		// Token: 0x170003A4 RID: 932
		// (get) Token: 0x060008A4 RID: 2212 RVA: 0x00092860 File Offset: 0x00090A60
		// (set) Token: 0x060008A5 RID: 2213 RVA: 0x00092920 File Offset: 0x00090B20
		public string ReadWritePassword
		{
			get
			{
				short num = (short)1069900106;
				short num2 = num;
				num = (short)1062035786;
				switch (num2 == num)
				{
				}
				num = (short)1465843712;
				short num3 = num;
				num = (short)1014693889;
				if (num != 0)
				{
				}
				num = (short)871235584;
				if (num != 0)
				{
				}
				return new global::System.Net.NetworkCredential("", this.e).Password;
			}
			set
			{
				short num = (short)526444452;
				short num2 = num;
				num = (short)1322903460;
				switch (num2 == num)
				{
				}
				num = (short)1229914112;
				short num3 = num;
				num = (short)1562181633;
				if (num != 0)
				{
				}
				num = (short)1910505472;
				if (num != 0)
				{
				}
				this.e = new global::System.Net.NetworkCredential("", value).SecurePassword;
			}
		}

		// Token: 0x170003A5 RID: 933
		// (get) Token: 0x060008A6 RID: 2214 RVA: 0x000929E0 File Offset: 0x00090BE0
		// (set) Token: 0x060008A7 RID: 2215 RVA: 0x00092A94 File Offset: 0x00090C94
		internal bool IsPasswordValidatedForCurrentInteraction
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)451149825;
				if (num != 0)
				{
				}
				num = (short)1988989896;
				short num2 = num;
				num = (short)699896776;
				switch (num2 == num)
				{
				default:
				{
					num = (short)882966528;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)9437184;
				if (num != 0)
				{
				}
				return this.g;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1359310298;
				short num2 = num;
				num = (short)305688026;
				switch (num2 == num)
				{
				}
				num = (short)707133440;
				short num3 = num;
				num = (short)1747124224;
				if (num != 0)
				{
				}
				num = (short)1653866497;
				if (num != 0)
				{
				}
				this.g = value;
			}
		}

		// Token: 0x060008A8 RID: 2216 RVA: 0x00092B48 File Offset: 0x00090D48
		public static global::SpecialFeatures.ReadWritePassword.ReadWritePasswordApp GetInstance()
		{
			short num = (short)1962536298;
			short num2 = num;
			num = (short)368504170;
			int num3;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_EA:
				global::SpecialFeatures.ReadWritePassword.ReadWritePasswordApp.a = new global::SpecialFeatures.ReadWritePassword.ReadWritePasswordApp();
				num = (short)1060306946;
				num3 = (int)((global::System.IntPtr)num);
				break;
			default:
				num = (short)43384832;
				if (num != 0)
				{
				}
				num = (short)451346433;
				num3 = (int)((global::System.IntPtr)num);
				break;
			}
			for (;;)
			{
				switch (num3)
				{
				case 0:
					goto IL_BD;
				case 1:
					switch (0)
					{
					case 0:
						goto IL_7B;
					}
					continue;
				case 2:
					goto IL_10B;
				}
				IL_7B:
				num = (short)626720769;
				if (num != 0)
				{
				}
				if (global::SpecialFeatures.ReadWritePassword.ReadWritePasswordApp.a != null)
				{
					goto IL_10D;
				}
				num = (short)1005584384;
				num3 = (int)((global::System.IntPtr)num);
			}
			IL_BD:
			num = (short)1833304064;
			short num4 = num;
			goto IL_EA;
			IL_10B:
			IL_10D:
			return global::SpecialFeatures.ReadWritePassword.ReadWritePasswordApp.a;
		}

		// Token: 0x060008A9 RID: 2217 RVA: 0x00092C68 File Offset: 0x00090E68
		public bool ValidateOKToArchiveFile(string codeplugPassword)
		{
			short num = (short)948237051;
			short num2 = num;
			num = (short)1655108347;
			switch (num2 == num)
			{
			}
			num = (short)107413504;
			short num3 = num;
			num = (short)897581057;
			if (num != 0)
			{
			}
			num = (short)126484480;
			if (num != 0)
			{
			}
			string a_ = this.b.decryptMesg(codeplugPassword);
			return this.a(a_, null, global::SpecialFeatures.ReadWritePassword.ReadWritePasswordApp.ValidType.File);
		}

		// Token: 0x060008AA RID: 2218 RVA: 0x00092D28 File Offset: 0x00090F28
		public bool ValidateOKToReadWrite(global::System.Windows.Window win, string codeplugPassword, string serialNumber, global::SpecialFeatures.ReadWritePassword.ReadWritePasswordApp.ValidType validType)
		{
			switch (0)
			{
			case 0:
				goto IL_6B;
			}
			short num;
			int num3;
			for (;;)
			{
				IL_0A:
				num = (short)1829954501;
				short num2 = num;
				num = (short)1538319301;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_128;
				default:
					num = (short)13631488;
					if (num != 0)
					{
					}
					switch (num3)
					{
					case 0:
						goto IL_CA;
					case 1:
					{
						num = (short)1755316225;
						if (num != 0)
						{
						}
						if (!this.c)
						{
							num = (short)1008926723;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)396623872;
						short num4 = num;
						global::System.Threading.Thread.Sleep(1000);
						num = (short)1978925056;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
						goto IL_CA;
					case 3:
						goto IL_128;
					}
					goto IL_6B;
					IL_CA:
					num = (short)321323009;
					num3 = (int)((global::System.IntPtr)num);
					break;
				}
			}
			IL_128:
			return this.d;
			IL_6B:
			string text = this.b.decryptMesg(codeplugPassword);
			this.c = true;
			win.Dispatcher.BeginInvoke(new global::SpecialFeatures.ReadWritePassword.ReadWritePasswordApp.ValidateOKDelegate(this.b), global::System.Windows.Threading.DispatcherPriority.Normal, new object[]
			{
				text,
				serialNumber,
				validType
			});
			num = (short)1486487554;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_0A;
		}

		// Token: 0x060008AB RID: 2219 RVA: 0x00092EB8 File Offset: 0x000910B8
		public bool ValidateOKToUserPassword(string userPassword, string codeplugPassword, string serialNumber)
		{
			switch (0)
			{
			case 0:
				goto IL_24;
			}
			int num;
			short num2;
			string text;
			bool result;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					goto IL_B3;
				case 1:
					goto IL_9A;
				case 2:
					num2 = (short)134283268;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 3:
					if (!this.b.isHiddenPwd(userPassword, serialNumber))
					{
						num2 = (short)2080636930;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_9A;
				case 4:
				{
					if (!(text == userPassword))
					{
						return result;
					}
					num2 = (short)1217523419;
					short num3 = num2;
					num2 = (short)213839579;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_9A;
					default:
						num2 = (short)832962560;
						if (num2 != 0)
						{
						}
						num2 = (short)382009345;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				}
				goto IL_24;
				IL_9A:
				result = true;
				num2 = (short)534577152;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_B3:
			num2 = (short)1948188673;
			if (num2 != 0)
			{
			}
			return result;
			IL_24:
			text = this.b.decryptMesg(codeplugPassword);
			result = false;
			num2 = (short)1813315584;
			short num4 = num2;
			num2 = (short)400162819;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x060008AC RID: 2220 RVA: 0x0009302C File Offset: 0x0009122C
		public void ClearCachedPasswordValidation()
		{
			short num2;
			for (;;)
			{
				IL_00:
				switch (0)
				{
				case 0:
					goto IL_1C;
				}
				int num;
				for (;;)
				{
					IL_0A:
					switch (num)
					{
					case 0:
					{
						num2 = (short)1969395987;
						short num3 = num2;
						num2 = (short)1612159251;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_00;
						default:
							num2 = (short)376700928;
							if (num2 != 0)
							{
							}
							this.ReadWritePassword = string.Empty;
							num2 = (short)1555038210;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						break;
					}
					case 1:
						if (!this.IsPasswordStoredForCurrentSession)
						{
							num2 = (short)1303838720;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						return;
					case 2:
						goto IL_C9;
					}
					break;
				}
				IL_1C:
				this.IsPasswordValidatedForCurrentInteraction = false;
				num2 = (short)687865857;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			IL_C9:
			num2 = (short)740556800;
			short num4 = num2;
			num2 = (short)368115713;
			if (num2 != 0)
			{
			}
		}

		// Token: 0x060008AD RID: 2221 RVA: 0x00093158 File Offset: 0x00091358
		public void ShowReadWritePasswordWindow()
		{
			short num = (short)64258281;
			short num2 = num;
			num = (short)97485033;
			switch (num2 == num)
			{
			}
			num = (short)651296768;
			short num3 = num;
			num = (short)141950977;
			if (num != 0)
			{
			}
			num = (short)316932096;
			if (num != 0)
			{
			}
			global::SpecialFeatures.ReadWritePassword.ReadWriteWindow readWriteWindow = new global::SpecialFeatures.ReadWritePassword.ReadWriteWindow();
			readWriteWindow.Show();
			readWriteWindow.Focus();
			readWriteWindow.Hide();
			readWriteWindow.ShowDialog();
		}

		// Token: 0x060008AE RID: 2222 RVA: 0x00093224 File Offset: 0x00091424
		internal global::SpecialFeatures.ReadWritePassword.PromptReadWritePassword ShowPopup(string radioIdentifier, string dialogMessage)
		{
			int a_ = 8;
			short num = (short)629097330;
			short num2 = num;
			num = (short)1871659890;
			switch (num2 == num)
			{
			}
			num = (short)49152000;
			short num3 = num;
			num = (short)819527681;
			if (num != 0)
			{
			}
			num = (short)28442624;
			if (num != 0)
			{
			}
			global::SpecialFeatures.Comms.Logger.LogWithDateTime(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("슊年ﺐ랖漢횠첢힤쎦覨\udbaa\udfac삮\udcb0쎲솴", a_));
			global::SpecialFeatures.ReadWritePassword.PromptReadWritePassword promptPassword = null;
			global::System.Windows.Application.Current.Dispatcher.Invoke(delegate()
			{
				short num4 = (short)464496016;
				short num5 = num4;
				num4 = (short)305178000;
				switch (num5 == num4)
				{
				}
				num4 = (short)525008897;
				if (num4 != 0)
				{
				}
				num4 = (short)633077760;
				if (num4 != 0)
				{
				}
				num4 = (short)503775232;
				short num6 = num4;
				promptPassword = new global::SpecialFeatures.ReadWritePassword.PromptReadWritePassword(radioIdentifier);
				promptPassword.CodeplugPasswordText.Content = dialogMessage;
				promptPassword.Show();
				promptPassword.Focus();
				promptPassword.Hide();
				promptPassword.ShowDialog();
			});
			global::SpecialFeatures.Comms.Logger.LogWithDateTime(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("캊놐ﲒ랖漢횠첢힤쎦覨\udbaa\udfac삮\udcb0쎲솴", a_));
			return promptPassword;
		}

		// Token: 0x060008AF RID: 2223 RVA: 0x00093338 File Offset: 0x00091538
		private bool b(string A_0, string A_1, global::SpecialFeatures.ReadWritePassword.ReadWritePasswordApp.ValidType A_2)
		{
			short num = (short)1255840464;
			short num2 = num;
			num = (short)1395497680;
			switch (num2 == num)
			{
			}
			num = (short)165806080;
			short num3 = num;
			num = (short)1731526657;
			if (num != 0)
			{
			}
			num = (short)1121648640;
			if (num != 0)
			{
			}
			this.d = this.a(A_0, A_1, A_2);
			this.c = false;
			return this.d;
		}

		// Token: 0x060008B0 RID: 2224 RVA: 0x000933FC File Offset: 0x000915FC
		private bool a(string A_0, string A_1, global::SpecialFeatures.ReadWritePassword.ReadWritePasswordApp.ValidType A_2)
		{
			short num = (short)1576796160;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_AE;
				}
				bool flag;
				for (;;)
				{
					IL_27:
					global::SpecialFeatures.ReadWritePassword.PromptReadWritePassword promptReadWritePassword;
					string text;
					switch (num2)
					{
					case 0:
						return true;
					case 1:
						if (A_0 == this.ReadWritePassword)
						{
							num = (short)1627258880;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_453;
					case 2:
						goto IL_279;
					case 3:
						if (A_0 != promptReadWritePassword.UserEnteredPassword)
						{
							num = (short)1316880406;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						this.IsPasswordStoredForCurrentSession = promptReadWritePassword.RememberPasswordSession.IsChecked.Value;
						this.ReadWritePassword = promptReadWritePassword.UserEnteredPassword;
						this.IsPasswordValidatedForCurrentInteraction = true;
						flag = true;
						num = (short)49152020;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						text = global::CommonResources.AppResources.Please_enter_password_for_radio_to_which_you_are_writing;
						goto IL_493;
					case 5:
						if (this.b.isHiddenPwd(promptReadWritePassword.UserEnteredPassword, A_1))
						{
							num = (short)1841561621;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)611581955;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
						if (promptReadWritePassword.UserEnteredPassword == string.Empty)
						{
							num = (short)1767571466;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_279;
					case 7:
						if (A_0 == this.ReadWritePassword)
						{
							num = (short)388300827;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1F0;
					case 8:
						if (!promptReadWritePassword.IsCanceled)
						{
							num = (short)190906393;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return flag;
					case 9:
						num = (short)603914246;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 10:
						num = (short)1011351578;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 11:
						if (this.IsPasswordStoredForCurrentSession)
						{
							num = (short)747175954;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1F0;
					case 12:
						goto IL_162;
					case 13:
						goto IL_373;
					case 14:
						if (!string.IsNullOrEmpty(promptReadWritePassword.UserEnteredPassword))
						{
							num = (short)918683677;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)695336991;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 15:
						text = global::CommonResources.AppResources.Please_enter_password_for_codeplug_you_are_attempting_to_read;
						goto IL_493;
					case 16:
						num = (short)57016321;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 17:
					{
						if (A_2 != global::SpecialFeatures.ReadWritePassword.ReadWritePasswordApp.ValidType.Write)
						{
							num = (short)1074331676;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1223879087;
						short num3 = num;
						num = (short)1416554927;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_30A;
						default:
						{
							num = (short)1935933440;
							short num4 = num;
							num = (short)871497728;
							if (num != 0)
							{
							}
							num = (short)1105854468;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						break;
					}
					case 18:
						num = (short)1989869575;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 19:
						goto IL_30A;
					case 20:
						goto IL_279;
					case 21:
						this.ReadWritePassword = promptReadWritePassword.UserEnteredPassword;
						this.IsPasswordValidatedForCurrentInteraction = true;
						flag = true;
						num = (short)1196163084;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 22:
						global::System.Windows.MessageBox.Show(global::CommonResources.AppResources.Incorrect_Password, global::CommonResources.AppResources.APX_CPS, global::System.Windows.MessageBoxButton.OK, global::System.Windows.MessageBoxImage.Exclamation, global::System.Windows.MessageBoxResult.OK);
						num = (short)1850474526;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 23:
						if (flag)
						{
							num = (short)1176895501;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_453;
					case 24:
						if (this.IsPasswordValidatedForCurrentInteraction)
						{
							num = (short)2081292304;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_453;
					case 25:
						num = (short)1157103639;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 26:
						if (!promptReadWritePassword.IsCanceled)
						{
							num = (short)568328211;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_279;
					case 27:
						return true;
					case 28:
						num = (short)1355874319;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 29:
						num = (short)824508417;
						if (num != 0)
						{
						}
						num = (short)1558773765;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 30:
						goto IL_279;
					case 31:
						if (promptReadWritePassword.UserEnteredPassword != null)
						{
							num = (short)971702281;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_279;
					}
					goto IL_AE;
					IL_1F0:
					num = (short)265289752;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_279:
					num = (short)1873149960;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_30A:
					global::System.Windows.MessageBox.Show(global::CommonResources.AppResources.Please_enter_a_valid_password, global::CommonResources.AppResources.APX_CPS, global::System.Windows.MessageBoxButton.OK, global::System.Windows.MessageBoxImage.Exclamation, global::System.Windows.MessageBoxResult.OK);
					num = (short)562298882;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_453:
					num = (short)872284177;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_493:
					string dialogMessage = text;
					promptReadWritePassword = this.ShowPopup(A_1, dialogMessage);
					num = (short)1851260942;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_162:
				return flag;
				IL_373:
				return flag;
				IL_AE:
				flag = false;
				num = (short)1600847883;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x060008B1 RID: 2225 RVA: 0x000939FC File Offset: 0x00091BFC
		public void Dispose()
		{
			short num = (short)85567902;
			short num2 = num;
			num = (short)1524148638;
			switch (num2 == num)
			{
			}
			num = (short)112132096;
			if (num != 0)
			{
			}
			num = (short)1709637633;
			if (num != 0)
			{
			}
			num = (short)978190336;
			short num3 = num;
			global::System.GC.SuppressFinalize(this);
		}

		// Token: 0x0400037D RID: 893
		private static global::SpecialFeatures.ReadWritePassword.ReadWritePasswordApp a;

		// Token: 0x0400037E RID: 894
		private readonly global::SpecialFeatures.ReadWritePassword.ReadWriteUtil b;

		// Token: 0x0400037F RID: 895
		private bool c;

		// Token: 0x04000380 RID: 896
		private bool d;

		// Token: 0x04000381 RID: 897
		private global::System.Security.SecureString e;

		// Token: 0x04000382 RID: 898
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private bool f;

		// Token: 0x04000383 RID: 899
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private bool g;

		// Token: 0x02000064 RID: 100
		// (Invoke) Token: 0x060008B3 RID: 2227
		private delegate bool ValidateOKDelegate(string codeplugPassword, string serialNumber, global::SpecialFeatures.ReadWritePassword.ReadWritePasswordApp.ValidType validType);

		// Token: 0x02000065 RID: 101
		public enum ValidType
		{
			// Token: 0x04000385 RID: 901
			Read,
			// Token: 0x04000386 RID: 902
			Write,
			// Token: 0x04000387 RID: 903
			File
		}
	}
}
