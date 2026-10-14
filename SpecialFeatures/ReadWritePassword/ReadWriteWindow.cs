using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Markup;
using ACPBrowser;
using AcpCommonLib;
using AcpUI.Common;
using CommonResources;
using Motorola.MackinawCPS.CoreFeatures.RadioInformation;
using Motorola.MackinawCPS.CoreFeatures.RadioWide;
using SpecialFeatures.AcpReportManagerLib;
using SpecialFeatures.Comms;
using SpecialFeatures.ReadWriteTlsPsk;

namespace SpecialFeatures.ReadWritePassword
{
	// Token: 0x02000062 RID: 98
	public class ReadWriteWindow : global::System.Windows.Window, global::System.Windows.Markup.IComponentConnector
	{
		// Token: 0x0600088F RID: 2191 RVA: 0x000906F8 File Offset: 0x0008E8F8
		public ReadWriteWindow()
		{
			this.InitializeComponent();
			global::AcpUI.Common.Utility.SetDirection(this);
			this.e();
			this.f = new global::SpecialFeatures.ReadWriteTlsPsk.ReadWriteTlsPskHelper();
			this.g = global::SpecialFeatures.ReadWritePassword.ReadWritePasswordApp.GetInstance();
			this.d();
			this.g();
			this.i();
			this.a();
		}

		// Token: 0x06000890 RID: 2192 RVA: 0x00090758 File Offset: 0x0008E958
		private void i()
		{
			short num = (short)1599930368;
			short num2 = num;
			num = (short)1187398731;
			short num3 = num;
			num = (short)869614667;
			switch (num3 == num)
			{
			}
			num = (short)1106575360;
			if (num != 0)
			{
			}
			num = (short)2046623745;
			if (num != 0)
			{
			}
			this.checkWrite.IsEnabled = false;
			this.checkRead.IsEnabled = false;
			this.checkSave.IsEnabled = false;
		}

		// Token: 0x06000891 RID: 2193 RVA: 0x00090828 File Offset: 0x0008EA28
		private void h()
		{
			short num = (short)1307377664;
			short num2 = num;
			num = (short)1145972715;
			short num3 = num;
			num = (short)736700395;
			switch (num3 == num)
			{
			}
			num = (short)1882652673;
			if (num != 0)
			{
			}
			num = (short)814743552;
			if (num != 0)
			{
			}
			this.checkWrite.IsEnabled = true;
			this.checkRead.IsEnabled = true;
			this.checkSave.IsEnabled = true;
		}

		// Token: 0x06000892 RID: 2194 RVA: 0x000908F8 File Offset: 0x0008EAF8
		private void g()
		{
			short num = (short)1882193920;
			short num2 = num;
			num = (short)142531068;
			short num3 = num;
			num = (short)1854265852;
			switch (num3 == num)
			{
			}
			num = (short)345702400;
			if (num != 0)
			{
			}
			num = (short)960757761;
			if (num != 0)
			{
			}
			this.checkWrite.IsChecked = new bool?(this.b);
			this.checkRead.IsChecked = new bool?(this.a);
			this.checkSave.IsChecked = new bool?(this.c);
		}

		// Token: 0x06000893 RID: 2195 RVA: 0x000909E4 File Offset: 0x0008EBE4
		private void f()
		{
			short num = (short)1445658624;
			short num2 = num;
			num = (short)9701064;
			short num3 = num;
			num = (short)611387080;
			switch (num3 == num)
			{
			}
			num = (short)427229184;
			if (num != 0)
			{
			}
			num = (short)151977985;
			if (num != 0)
			{
			}
			this.b = this.checkWrite.IsChecked.Value;
			this.a = this.checkRead.IsChecked.Value;
			this.c = this.checkSave.IsChecked.Value;
		}

		// Token: 0x06000894 RID: 2196 RVA: 0x00090AD8 File Offset: 0x0008ECD8
		private void e()
		{
			short num = (short)2133196800;
			short num2 = num;
			num = (short)1828724971;
			short num3 = num;
			num = (short)556998891;
			switch (num3 == num)
			{
			}
			num = (short)529530880;
			if (num != 0)
			{
			}
			num = (short)1623523329;
			if (num != 0)
			{
			}
			this.e = new global::SpecialFeatures.ReadWritePassword.ReadWriteUtil();
		}

		// Token: 0x06000895 RID: 2197 RVA: 0x00090B90 File Offset: 0x0008ED90
		private void d()
		{
			short num2;
			try
			{
				for (;;)
				{
					IL_00:
					switch (0)
					{
					case 0:
						goto IL_2C;
					}
					int num;
					global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide radioWide;
					for (;;)
					{
						IL_0A:
						switch (num)
						{
						case 0:
							this.a = radioWide.Labtool.RadWideLabtoolRadioReadPasswordEnable_A8869Value;
							this.b = radioWide.Labtool.RadWideLabtoolRadioWritePasswordEnable_A8889Value;
							this.c = radioWide.Labtool.RadWideLabtoolArchiveReadPasswordEnable_A7462Value;
							num2 = (short)1405812737;
							num = (int)((global::System.IntPtr)num2);
							continue;
						case 1:
							if (radioWide.Labtool.RadWideLabtoolRadioPassword_A8837Value != string.Empty)
							{
								num2 = (short)1801977859;
								num = (int)((global::System.IntPtr)num2);
								continue;
							}
							this.d = string.Empty;
							num2 = (short)75431942;
							num = (int)((global::System.IntPtr)num2);
							continue;
						case 2:
							if (radioWide != null)
							{
								num2 = (short)132055040;
								num = (int)((global::System.IntPtr)num2);
								continue;
							}
							goto IL_19E;
						case 3:
						{
							num2 = (short)546718440;
							short num3 = num2;
							num2 = (short)285557480;
							switch ((num3 == num2) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_00;
							default:
								num2 = (short)1304428544;
								if (num2 != 0)
								{
								}
								this.d = this.e.decryptMesg(radioWide.Labtool.RadWideLabtoolRadioPassword_A8837Value);
								num2 = (short)107544581;
								num = (int)((global::System.IntPtr)num2);
								continue;
							}
							break;
						}
						case 4:
							goto IL_1B6;
						case 5:
							goto IL_19E;
						case 6:
							goto IL_19E;
						}
						break;
						IL_19E:
						num2 = (short)832962564;
						num = (int)((global::System.IntPtr)num2);
					}
					IL_2C:
					radioWide = (global::AcpCommonLib.FeatureManager.GetFeature(2045)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide);
					num2 = (short)1183121410;
					num = (int)((global::System.IntPtr)num2);
					goto IL_0A;
				}
				IL_1B6:;
			}
			catch (global::System.Exception)
			{
			}
			num2 = (short)1431633921;
			if (num2 != 0)
			{
			}
			num2 = (short)580386816;
			short num4 = num2;
		}

		// Token: 0x06000896 RID: 2198 RVA: 0x00090DC8 File Offset: 0x0008EFC8
		private void c()
		{
			short num2;
			try
			{
				switch (0)
				{
				case 0:
					goto IL_30;
				}
				int num;
				global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide radioWide;
				for (;;)
				{
					IL_0A:
					switch (num)
					{
					case 0:
						goto IL_206;
					case 1:
						goto IL_1C6;
					case 2:
						if (radioWide == null)
						{
							num2 = (short)275251203;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						radioWide.Labtool.RadWideLabtoolRadioReadPasswordEnable_A8869.SetValue(this.a);
						radioWide.Labtool.RadWideLabtoolRadioWritePasswordEnable_A8889.SetValue(this.b);
						radioWide.Labtool.RadWideLabtoolArchiveReadPasswordEnable_A7462.SetValue(this.c);
						num2 = (short)2080571398;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 3:
						num2 = (short)636616705;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 4:
					{
						radioWide.Labtool.RadWideLabtoolRadioPassword_A8837.SetValue(this.e.encryptMesg(this.d));
						num2 = (short)855433923;
						short num3 = num2;
						num2 = (short)1747313347;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_206;
						default:
							num2 = (short)1772814337;
							if (num2 != 0)
							{
							}
							num2 = (short)1427636224;
							if (num2 != 0)
							{
							}
							num2 = (short)837353479;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						break;
					}
					case 5:
						goto IL_21D;
					case 6:
						if (!string.IsNullOrEmpty(this.d))
						{
							num2 = (short)1210908676;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						this.d = string.Empty;
						radioWide.Labtool.RadWideLabtoolRadioPassword_A8837.SetValue(string.Empty);
						num2 = (short)1797128192;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 7:
						goto IL_206;
					}
					goto IL_30;
					IL_206:
					num2 = (short)1911422981;
					num = (int)((global::System.IntPtr)num2);
				}
				IL_1C6:
				IL_21D:
				goto IL_222;
				IL_30:
				radioWide = (global::AcpCommonLib.FeatureManager.GetFeature(2045)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide);
				num2 = (short)964755458;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			catch (global::System.Exception)
			{
			}
			IL_222:
			num2 = (short)1388118016;
			short num4 = num2;
		}

		// Token: 0x06000897 RID: 2199 RVA: 0x0009103C File Offset: 0x0008F23C
		private void b()
		{
			int a_ = 10;
			short num;
			try
			{
				num = (short)1923809282;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						this.f.ResetTlsPskFields();
						num = (short)1850081289;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						goto IL_223;
					case 2:
						goto IL_1D;
					case 3:
						if (this.b)
						{
							num = (short)2112618501;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_20C;
					case 4:
						this.f.SetTlsPskHashInCodeplug(this.d);
						num = (short)309526535;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						goto IL_80;
					case 6:
						num = (short)1969553419;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
						goto IL_20C;
					case 8:
						if (!string.IsNullOrEmpty(this.d))
						{
							num = (short)527171588;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_20C;
					case 9:
					{
						num = (short)1422123738;
						short num3 = num;
						num = (short)807068378;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_1D;
						default:
							goto IL_1B9;
						}
						break;
					}
					case 10:
						num = (short)1950154755;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 11:
						if (!this.b)
						{
							num = (short)1050673152;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_BF;
					case 12:
						if (!this.a)
						{
							num = (short)2049835018;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_80;
					}
					goto IL_61;
					IL_1D:
					switch (0)
					{
					case 0:
						IL_61:
						if (this.a)
						{
							goto IL_BF;
						}
						num = (short)779550726;
						num2 = (int)((global::System.IntPtr)num);
						break;
					}
					continue;
					IL_80:
					num = (short)1991507976;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_BF:
					num = (short)1888026636;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_20C:
					num = (short)1339228161;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_1B9:
				num = (short)1471873024;
				if (num != 0)
				{
				}
				IL_223:;
			}
			catch (global::System.Exception ex)
			{
				global::SpecialFeatures.Comms.Logger.LogWithDateTime(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\ude8c뎒솔\udb96쪘뚚출첞莢쎤캦첨잪즬\udcae醰햲풴\udeb6햸\udeba\ud9bc麾蛂뷄꓆곈믊만ꛎ뻐뷒뫖볘꣚껜뻞蛠蛢\udfe4쟦", a_) + ex.Message);
			}
			num = (short)2054029313;
			if (num != 0)
			{
			}
			num = (short)602734592;
			short num4 = num;
		}

		// Token: 0x06000898 RID: 2200 RVA: 0x00091300 File Offset: 0x0008F500
		private void a()
		{
			short num = (short)2020147201;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_B0;
				case 1:
					switch (0)
					{
					case 0:
						goto IL_3E;
					}
					continue;
				case 2:
					if (!this.b)
					{
						num = (short)2050359300;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_EB;
				case 3:
					num = (short)879493122;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					num = (short)1339359237;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
					if (!this.c)
					{
						num = (short)1499136000;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_EB;
				}
				goto IL_3E;
				IL_49:
				num = (short)927989763;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_EB:
				num = (short)1791348630;
				short num3 = num;
				num = (short)622514070;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_49;
				default:
					goto IL_120;
				}
				IL_3E:
				if (!this.a)
				{
					goto IL_49;
				}
				goto IL_EB;
			}
			IL_B0:
			this.ModifyButton.Content = global::CommonResources.AppResources.Initialize_Permissions;
			this.ChangePasswordButton.IsEnabled = false;
			return;
			IL_120:
			num = (short)1496907776;
			short num4 = num;
			num = (short)25362432;
			if (num != 0)
			{
			}
			num = (short)728498177;
			if (num != 0)
			{
			}
			this.ModifyButton.Content = global::CommonResources.AppResources.Modify_Permissions;
			this.ChangePasswordButton.IsEnabled = true;
		}

		// Token: 0x06000899 RID: 2201 RVA: 0x000914B0 File Offset: 0x0008F6B0
		private void OnClickCancel(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num = (short)1015676928;
			short num2 = num;
			num = (short)1966363496;
			short num3 = num;
			num = (short)1464947560;
			switch (num3 == num)
			{
			}
			num = (short)1451687936;
			if (num != 0)
			{
			}
			num = (short)805306369;
			if (num != 0)
			{
			}
			base.Close();
		}

		// Token: 0x0600089A RID: 2202 RVA: 0x00091560 File Offset: 0x0008F760
		private void OnClick_OK(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			switch (0)
			{
			case 0:
				goto IL_3C;
			}
			int num;
			bool? isChecked;
			bool flag;
			short num2;
			global::System.Windows.MessageBoxResult messageBoxResult;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					goto IL_8F;
				case 1:
					if (isChecked.GetValueOrDefault() == flag & isChecked != null)
					{
						num2 = (short)769720323;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_8F;
				case 2:
					if (isChecked.GetValueOrDefault() == flag & isChecked != null)
					{
						num2 = (short)693501959;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_8F;
				case 3:
					messageBoxResult = global::System.Windows.MessageBox.Show(global::CommonResources.AppResources.You_Are_About_To_Disable_All_Read_Write_Protections, global::CommonResources.AppResources.APX_CPS, global::System.Windows.MessageBoxButton.OKCancel, global::System.Windows.MessageBoxImage.Exclamation, global::System.Windows.MessageBoxResult.OK);
					num2 = (short)2120941576;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 4:
					if (isChecked.GetValueOrDefault() == flag & isChecked != null)
					{
						num2 = (short)1181941765;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_8F;
				case 5:
					isChecked = this.checkWrite.IsChecked;
					flag = false;
					num2 = (short)681181186;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 6:
				{
					if (global::System.Windows.MessageBoxResult.OK != messageBoxResult)
					{
						goto IL_2A5;
					}
					num2 = (short)248364456;
					short num3 = num2;
					num2 = (short)1692974504;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						continue;
					default:
						num2 = (short)1172242432;
						if (num2 != 0)
						{
						}
						num2 = (short)77791242;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 7:
				{
					isChecked = this.checkSave.IsChecked;
					flag = false;
					num2 = (short)886702080;
					short num4 = num2;
					num2 = (short)272105473;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 8:
					if (global::System.Windows.MessageBoxResult.OK == messageBoxResult)
					{
						num2 = (short)1875574793;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_8F;
				case 9:
					this.d = string.Empty;
					num2 = (short)764674048;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 10:
					goto IL_111;
				}
				goto IL_3C;
				IL_8F:
				num2 = (short)2039742470;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_111:
			num2 = (short)1363476481;
			if (num2 != 0)
			{
			}
			this.f();
			this.c();
			this.b();
			base.Close();
			return;
			IL_2A5:
			this.g();
			return;
			IL_3C:
			messageBoxResult = global::System.Windows.MessageBoxResult.OK;
			isChecked = this.checkRead.IsChecked;
			flag = false;
			num2 = (short)1029767172;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x0600089B RID: 2203 RVA: 0x00091818 File Offset: 0x0008FA18
		private void OnClickChangePassword(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num = (short)101318658;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				global::SpecialFeatures.ReadWritePassword.ChangePassword changePassword;
				switch (num2)
				{
				case 0:
					if (!this.b)
					{
						num = (short)1924595716;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_B4;
				case 1:
					goto IL_B4;
				case 2:
					goto IL_15;
				case 3:
					if (this.d == string.Empty)
					{
						num = (short)1318322187;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_18C;
				case 4:
				{
					num = (short)1445986509;
					short num3 = num;
					num = (short)861208781;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_15;
					default:
						num = (short)2116747264;
						if (num != 0)
						{
						}
						goto IL_10D;
					}
					break;
				}
				case 5:
				{
					num = (short)546111488;
					short num4 = num;
					num = (short)1220673536;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 6:
					num = (short)1967259649;
					if (num != 0)
					{
					}
					if (string.IsNullOrEmpty(changePassword.UserEnteredPassword))
					{
						num = (short)942342152;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					this.d = changePassword.UserEnteredPassword;
					global::System.Windows.MessageBox.Show(global::CommonResources.AppResources.Password_Accepted_Note, global::CommonResources.AppResources.APX_CPS, global::System.Windows.MessageBoxButton.OK, global::System.Windows.MessageBoxImage.Exclamation, global::System.Windows.MessageBoxResult.OK);
					num = (short)1786380295;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 7:
					try
					{
						(global::AcpCommonLib.FeatureManager.GetFeature(2045)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide).Labtool.RadWideLabtoolRadioPassword_A8837.SetValue(this.e.encryptMesg(this.d));
						goto IL_2BD;
					}
					catch (global::System.Exception)
					{
						goto IL_2BD;
					}
					goto IL_18C;
					IL_2BD:
					num = (short)154206217;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 8:
					return;
				case 9:
					try
					{
						this.b();
						return;
					}
					catch (global::System.Exception)
					{
						return;
					}
					goto IL_10D;
				case 10:
					if (this.c)
					{
						num = (short)1132986369;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 11:
					goto IL_F7;
				}
				goto IL_55;
				IL_15:
				switch (0)
				{
				case 0:
					IL_55:
					if (this.a)
					{
						goto IL_B4;
					}
					num = (short)704839685;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
				continue;
				IL_B4:
				num = (short)1153695747;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_10D:
				num = (short)908394506;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_18C:
				changePassword = new global::SpecialFeatures.ReadWritePassword.ChangePassword(this.d);
				changePassword.ShowDialog();
				num = (short)1778319366;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_F7:;
		}

		// Token: 0x0600089C RID: 2204 RVA: 0x00091B20 File Offset: 0x0008FD20
		private void OnClickModifyPermissions(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num = (short)1087569920;
			switch (num)
			{
			default:
			{
				global::SpecialFeatures.ReadWritePassword.PromptReadWritePassword promptReadWritePassword;
				global::SpecialFeatures.ReadWritePassword.InitReadWritePassword initReadWritePassword;
				for (;;)
				{
					IL_1D:
					num = (short)1555103750;
					int num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						global::SpecialFeatures.ReadWritePassword.ReadWriteUtil readWriteUtil;
						switch (num2)
						{
						case 0:
							if (!promptReadWritePassword.IsCanceled)
							{
								num = (short)1638858768;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							return;
						case 1:
							num = (short)477691935;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
							num = (short)2074148868;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 3:
							goto IL_2FB;
						case 4:
							if (this.g.ReadWritePassword == this.d)
							{
								num = (short)1535705103;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_597;
						case 5:
							goto IL_2FB;
						case 6:
							switch (0)
							{
							case 0:
								goto IL_C7;
							}
							continue;
						case 7:
							if (promptReadWritePassword.UserEnteredPassword == string.Empty)
							{
								num = (short)1254948896;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_2FB;
						case 8:
						{
							bool? isChecked;
							if (isChecked.Value)
							{
								num = (short)1219624979;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_360;
						}
						case 9:
							if (!this.c)
							{
								num = (short)921894929;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_4B6;
						case 10:
							num = (short)1064960007;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 11:
							global::System.Windows.MessageBox.Show(global::CommonResources.AppResources.Incorrect_Password, global::CommonResources.AppResources.APX_CPS, global::System.Windows.MessageBoxButton.OK, global::System.Windows.MessageBoxImage.Exclamation, global::System.Windows.MessageBoxResult.OK);
							num = (short)81592348;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 12:
							goto IL_61B;
						case 13:
							if (!string.IsNullOrEmpty(this.g.ReadWritePassword))
							{
								num = (short)1638793218;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_597;
						case 14:
							this.g.IsPasswordStoredForCurrentSession = true;
							num = (short)1426456596;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 15:
							goto IL_548;
						case 16:
						{
							num = (short)1724907520;
							short num3 = num;
							num = (short)1009057822;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 17:
							this.d = string.Empty;
							initReadWritePassword = new global::SpecialFeatures.ReadWritePassword.InitReadWritePassword();
							initReadWritePassword.ShowDialog();
							num = (short)531234839;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 18:
							num = (short)1893990425;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 19:
							this.g.IsPasswordStoredForCurrentSession = true;
							num = (short)882638849;
							if (num != 0)
							{
							}
							num = (short)338034714;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 20:
							goto IL_595;
						case 21:
							if (!string.IsNullOrEmpty(promptReadWritePassword.UserEnteredPassword))
							{
								num = (short)482869266;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_1B4;
						case 22:
						{
							bool? isChecked;
							if (isChecked.Value)
							{
								num = (short)1754791950;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_54D;
						}
						case 23:
							if (!string.IsNullOrEmpty(initReadWritePassword.UserEnteredPassword))
							{
								num = (short)1241841691;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							return;
						case 24:
							num = (short)76218377;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 25:
							if (readWriteUtil.isHiddenPwd(promptReadWritePassword.UserEnteredPassword, null))
							{
								num = (short)378929164;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)1695088669;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 26:
							goto IL_1AF;
						case 27:
						{
							this.d = initReadWritePassword.UserEnteredPassword;
							this.a = true;
							this.b = true;
							this.c = true;
							this.g();
							this.h();
							this.ModifyButton.IsEnabled = false;
							this.a();
							bool? isChecked = initReadWritePassword.RememberPasswordSession.IsChecked;
							num = (short)1865482248;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 28:
							goto IL_1B4;
						case 29:
						{
							if (!(this.d != promptReadWritePassword.UserEnteredPassword))
							{
								bool? isChecked = promptReadWritePassword.RememberPasswordSession.IsChecked;
								num = (short)1434058774;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)691877907;
							short num4 = num;
							num = (short)187119635;
							switch ((num4 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_1D;
							default:
								num = (short)830013440;
								if (num != 0)
								{
								}
								num = (short)1995505675;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 30:
							if (promptReadWritePassword.UserEnteredPassword != null)
							{
								num = (short)75563018;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_3AF;
						case 31:
							if (!this.b)
							{
								num = (short)1164574744;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_4B6;
						case 32:
							goto IL_3AF;
						}
						IL_C7:
						if (!this.a)
						{
							num = (short)1628241921;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_4B6;
						IL_1B4:
						num = (short)1371471872;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_2FB:
						string radInfoGeneralSerialNumber_A9122Value;
						promptReadWritePassword = new global::SpecialFeatures.ReadWritePassword.PromptReadWritePassword(radInfoGeneralSerialNumber_A9122Value);
						promptReadWritePassword.CodeplugPasswordText.Content = global::CommonResources.AppResources.Please_Enter_Current_Password;
						promptReadWritePassword.ShowDialog();
						num = (short)1883504661;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_3AF:
						global::System.Windows.MessageBox.Show(global::CommonResources.AppResources.Incorrect_Password, global::CommonResources.AppResources.APX_CPS, global::System.Windows.MessageBoxButton.OK, global::System.Windows.MessageBoxImage.Exclamation, global::System.Windows.MessageBoxResult.OK);
						num = (short)357629957;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_4B6:
						num = (short)1290469389;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_597:
						radInfoGeneralSerialNumber_A9122Value = (global::AcpCommonLib.FeatureManager.GetFeature(2049)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation).General.RadInfoGeneralSerialNumber_A9122Value;
						readWriteUtil = new global::SpecialFeatures.ReadWritePassword.ReadWriteUtil();
						num = (short)885063683;
						num2 = (int)((global::System.IntPtr)num);
					}
				}
				IL_1AF:
				IL_360:
				this.g.ReadWritePassword = initReadWritePassword.UserEnteredPassword;
				return;
				IL_548:
				this.h();
				return;
				IL_54D:
				this.g.ReadWritePassword = promptReadWritePassword.UserEnteredPassword;
				this.h();
				this.ModifyButton.IsEnabled = false;
				return;
				IL_595:
				goto IL_54D;
				IL_61B:
				this.g.ReadWritePassword = promptReadWritePassword.UserEnteredPassword;
				this.h();
				this.ModifyButton.IsEnabled = false;
				return;
			}
			}
		}

		// Token: 0x0600089D RID: 2205 RVA: 0x00092228 File Offset: 0x00090428
		private void F1HelpCommandCanExcute(object A_0, global::System.Windows.Input.CanExecuteRoutedEventArgs A_1)
		{
			short num = (short)538434803;
			short num2 = num;
			num = (short)1775164659;
			switch (num2 == num)
			{
			}
			num = (short)506200064;
			short num3 = num;
			num = (short)183369729;
			if (num != 0)
			{
			}
			num = (short)273743872;
			if (num != 0)
			{
			}
			A_1.CanExecute = true;
		}

		// Token: 0x0600089E RID: 2206 RVA: 0x000922D8 File Offset: 0x000904D8
		private void OnHelpButton_Click(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			int a_ = 18;
			short num;
			try
			{
				num = (short)1278116331;
				short num2 = num;
				num = (short)968327659;
				switch (num2 == num)
				{
				}
				num = (short)2075983872;
				if (num != 0)
				{
				}
				global::ACPBrowser.Utility.CloseHelpWindowIfOpen();
				global::ACPBrowser.Utility.DisplayCPSHelpDITA(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("뚔ꊚ궜ﶞ슠잢醤", a_));
			}
			catch (global::System.Exception)
			{
			}
			num = (short)1100808192;
			short num3 = num;
			num = (short)580911105;
			if (num != 0)
			{
			}
		}

		// Token: 0x0600089F RID: 2207 RVA: 0x000923BC File Offset: 0x000905BC
		[global::System.Diagnostics.DebuggerNonUserCode]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "5.0.10.0")]
		public void InitializeComponent()
		{
			int a_ = 14;
			if (!this.h)
			{
				short num = (short)119186195;
				short num2 = num;
				num = (short)1178051347;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)1318125568;
					if (num != 0)
					{
					}
					num = (short)1693581312;
					short num3 = num;
					num = (short)1503395841;
					if (num != 0)
					{
					}
					this.h = true;
					global::System.Uri resourceLocator = new global::System.Uri(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("뺐삒滛ﲜ욢쒤펦\udca8\ud9aa좬\udcae誰킲\udab4\udab6즸풺펼\udabe꿀럂뗆곈꫊꧌룎ꏐ뫒ꇔ닖꧘뫚껜곞雠賢韤菦웨駪裬軮闰蓲蟴黶跸黺跼黾爀瀂爄栆笈漊⌌眎瀐縒礔", a_), global::System.UriKind.Relative);
					global::System.Windows.Application.LoadComponent(this, resourceLocator);
					return;
				}
				}
			}
		}

		// Token: 0x060008A0 RID: 2208 RVA: 0x0009249C File Offset: 0x0009069C
		[global::System.Diagnostics.DebuggerNonUserCode]
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "5.0.10.0")]
		void global::System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
		{
			short num = (short)289931265;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				num = (short)61931520;
				short num3 = num;
				switch (num2)
				{
				case 0:
					num = (short)1900478466;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					goto IL_15;
				case 2:
					goto IL_1EA;
				}
				goto IL_5B;
				IL_15:
				switch (0)
				{
				case 0:
					IL_5B:
					switch (connectionId)
					{
					case 1:
						goto IL_130;
					case 2:
						goto IL_DD;
					case 3:
						goto IL_220;
					case 4:
						goto IL_1C5;
					case 5:
						goto IL_213;
					case 6:
						goto IL_D0;
					case 7:
						goto IL_13D;
					case 8:
						goto IL_AC;
					case 9:
						goto IL_1EF;
					case 10:
						goto IL_10C;
					case 11:
					{
						num = (short)1816066666;
						short num4 = num;
						num = (short)788462186;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_15;
						default:
							goto IL_18B;
						}
						break;
					}
					default:
						num = (short)2107441152;
						num2 = (int)((global::System.IntPtr)num);
						break;
					}
					break;
				}
			}
			IL_AC:
			this.CancelButton = (global::System.Windows.Controls.Button)target;
			this.CancelButton.Click += this.OnClickCancel;
			return;
			IL_D0:
			this.PasswordNote = (global::System.Windows.Controls.TextBlock)target;
			return;
			IL_DD:
			((global::System.Windows.Input.CommandBinding)target).Executed += new global::System.Windows.Input.ExecutedRoutedEventHandler(this.OnHelpButton_Click);
			((global::System.Windows.Input.CommandBinding)target).CanExecute += this.F1HelpCommandCanExcute;
			return;
			IL_10C:
			this.ModifyButton = (global::System.Windows.Controls.Button)target;
			this.ModifyButton.Click += this.OnClickModifyPermissions;
			return;
			IL_130:
			this.ReadWritePassword = (global::SpecialFeatures.ReadWritePassword.ReadWriteWindow)target;
			return;
			IL_13D:
			((global::System.Windows.Controls.Button)target).Click += this.OnClick_OK;
			return;
			IL_18B:
			num = (short)1532428288;
			if (num != 0)
			{
			}
			this.ChangePasswordButton = (global::System.Windows.Controls.Button)target;
			this.ChangePasswordButton.Click += this.OnClickChangePassword;
			return;
			IL_1C5:
			this.checkWrite = (global::System.Windows.Controls.CheckBox)target;
			return;
			IL_1EA:
			this.h = true;
			return;
			IL_1EF:
			this.passwdWindowHelpbutton = (global::System.Windows.Controls.Button)target;
			this.passwdWindowHelpbutton.Click += this.OnHelpButton_Click;
			return;
			IL_213:
			this.checkSave = (global::System.Windows.Controls.CheckBox)target;
			return;
			IL_220:
			num = (short)1035337729;
			if (num != 0)
			{
			}
			this.checkRead = (global::System.Windows.Controls.CheckBox)target;
		}

		// Token: 0x0400036C RID: 876
		private bool a;

		// Token: 0x0400036D RID: 877
		private bool b;

		// Token: 0x0400036E RID: 878
		private bool c;

		// Token: 0x0400036F RID: 879
		private string d = string.Empty;

		// Token: 0x04000370 RID: 880
		private global::SpecialFeatures.ReadWritePassword.ReadWriteUtil e;

		// Token: 0x04000371 RID: 881
		private readonly global::SpecialFeatures.ReadWriteTlsPsk.ReadWriteTlsPskHelper f;

		// Token: 0x04000372 RID: 882
		private readonly global::SpecialFeatures.ReadWritePassword.ReadWritePasswordApp g;

		// Token: 0x04000373 RID: 883
		internal global::SpecialFeatures.ReadWritePassword.ReadWriteWindow ReadWritePassword;

		// Token: 0x04000374 RID: 884
		internal global::System.Windows.Controls.CheckBox checkRead;

		// Token: 0x04000375 RID: 885
		internal global::System.Windows.Controls.CheckBox checkWrite;

		// Token: 0x04000376 RID: 886
		internal global::System.Windows.Controls.CheckBox checkSave;

		// Token: 0x04000377 RID: 887
		internal global::System.Windows.Controls.TextBlock PasswordNote;

		// Token: 0x04000378 RID: 888
		internal global::System.Windows.Controls.Button CancelButton;

		// Token: 0x04000379 RID: 889
		internal global::System.Windows.Controls.Button passwdWindowHelpbutton;

		// Token: 0x0400037A RID: 890
		internal global::System.Windows.Controls.Button ModifyButton;

		// Token: 0x0400037B RID: 891
		internal global::System.Windows.Controls.Button ChangePasswordButton;

		// Token: 0x0400037C RID: 892
		private bool h;
	}
}
