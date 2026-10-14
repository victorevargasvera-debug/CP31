using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Markup;
using ACPBrowser;
using AcpUI.Common;
using CommonResources;
using SpecialFeatures.AcpReportManagerLib;

namespace SpecialFeatures.ReadWritePassword
{
	// Token: 0x02000060 RID: 96
	public partial class InitReadWritePassword : Window
	{
		// Token: 0x0600087B RID: 2171 RVA: 0x000029B2 File Offset: 0x00000BB2
		public InitReadWritePassword()
		{
			this.InitializeComponent();
			AcpUI.Common.Utility.SetDirection(this);
			this.EnterPasswordBox.Focus();
		}

		// Token: 0x170003A0 RID: 928
		// (get) Token: 0x0600087C RID: 2172 RVA: 0x0008F36C File Offset: 0x0008D56C
		// (set) Token: 0x0600087D RID: 2173 RVA: 0x0008F418 File Offset: 0x0008D618
		internal string UserEnteredPassword
		{
			get
			{
				short num = (short)2106618954;
				short num2 = num;
				num = (short)1017607242;
				switch (num2 == num)
				{
				}
				num = (short)676593665;
				if (num != 0)
				{
				}
				num = (short)2017329152;
				short num3 = num;
				num = (short)476119040;
				if (num != 0)
				{
				}
				return this.a;
			}
			set
			{
				short num = (short)2008032961;
				short num2 = num;
				num = (short)81012417;
				switch (num2 == num)
				{
				}
				num = (short)1153695744;
				if (num != 0)
				{
				}
				num = (short)506462208;
				short num3 = num;
				num = (short)2062942209;
				if (num != 0)
				{
				}
				this.a = value;
			}
		}

		// Token: 0x0600087E RID: 2174 RVA: 0x0008F4C8 File Offset: 0x0008D6C8
		private void OnClickCancel(object A_0, RoutedEventArgs A_1)
		{
			short num = (short)910948120;
			short num2 = num;
			num = (short)1563490072;
			switch (num2 == num)
			{
			}
			num = (short)1297874945;
			if (num != 0)
			{
			}
			num = (short)334823424;
			short num3 = num;
			num = (short)914161664;
			if (num != 0)
			{
			}
			base.Close();
		}

		// Token: 0x0600087F RID: 2175 RVA: 0x0008F578 File Offset: 0x0008D778
		private void OnClickOK(object A_0, RoutedEventArgs A_1)
		{
			short num;
			try
			{
				num = (short)7536640;
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
					bool flag;
					string password;
					int num3;
					char[] array;
					string password2;
					for (;;)
					{
						IL_27:
						switch (num2)
						{
						case 0:
							num = (short)1497038868;
							num2 = (int)((IntPtr)num);
							continue;
						case 1:
							num = (short)1949368325;
							num2 = (int)((IntPtr)num);
							continue;
						case 2:
							flag = true;
							num = (short)2086928387;
							num2 = (int)((IntPtr)num);
							continue;
						case 3:
							goto IL_141;
						case 4:
							if (password != null)
							{
								num = (short)1431568384;
								num2 = (int)((IntPtr)num);
								continue;
							}
							goto IL_165;
						case 5:
							if (!flag)
							{
								num = (short)1749942279;
								num2 = (int)((IntPtr)num);
								continue;
							}
							goto IL_165;
						case 6:
							num = (short)1765277708;
							num2 = (int)((IntPtr)num);
							continue;
						case 7:
							this.a = password;
							base.Close();
							num = (short)300679186;
							num2 = (int)((IntPtr)num);
							continue;
						case 8:
							goto IL_35D;
						case 9:
							num = (short)1862336516;
							num2 = (int)((IntPtr)num);
							continue;
						case 10:
							if (num3 >= array.Length)
							{
								num = (short)1035337734;
								num2 = (int)((IntPtr)num);
								continue;
							}
							num = (short)1538588683;
							num2 = (int)((IntPtr)num);
							continue;
						case 11:
							if (array[num3] >= '\u0080')
							{
								num = (short)1203044354;
								num2 = (int)((IntPtr)num);
								continue;
							}
							goto IL_141;
						case 12:
							if (password == password2)
							{
								goto IL_299;
							}
							MessageBox.Show(AppResources.New_Passwords_Do_Not_Match, AppResources.APX_CPS, MessageBoxButton.OK, MessageBoxImage.Exclamation, MessageBoxResult.OK);
							num = (short)31784973;
							num2 = (int)((IntPtr)num);
							continue;
						case 13:
							goto IL_39C;
						case 14:
							num = (short)748421139;
							num2 = (int)((IntPtr)num);
							continue;
						case 15:
							goto IL_3B4;
						case 16:
							goto IL_35D;
						case 17:
							goto IL_39C;
						case 18:
							goto IL_39C;
						case 19:
							if (password.Length <= 16)
							{
								num = (short)2091778049;
								num2 = (int)((IntPtr)num);
								continue;
							}
							goto IL_165;
						case 20:
							if (password.Length >= 6)
							{
								num = (short)1676476430;
								num2 = (int)((IntPtr)num);
								continue;
							}
							goto IL_165;
						}
						goto IL_82;
						IL_141:
						num3++;
						num = (short)847052816;
						num2 = (int)((IntPtr)num);
						continue;
						IL_165:
						num = (short)790049222;
						short num4 = num;
						num = (short)1314664902;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							IL_299:
							num = (short)621412361;
							num2 = (int)((IntPtr)num);
							continue;
						default:
							num = (short)2104557568;
							if (num != 0)
							{
							}
							MessageBox.Show(AppResources.Must_Contain_6_to_16_Characters, AppResources.APX_CPS, MessageBoxButton.OK, MessageBoxImage.Exclamation, MessageBoxResult.OK);
							num = (short)64946193;
							num2 = (int)((IntPtr)num);
							continue;
						}
						IL_35D:
						num = (short)489881610;
						num2 = (int)((IntPtr)num);
						continue;
						IL_39C:
						num = (short)1006239759;
						num2 = (int)((IntPtr)num);
					}
					IL_3B4:
					break;
					IL_82:
					password = this.EnterPasswordBox.Password;
					password2 = this.ConfirmpasswordBox.Password;
					flag = false;
					array = password2.ToCharArray();
					num3 = 0;
					num = (short)1894383624;
					num2 = (int)((IntPtr)num);
					goto IL_27;
				}
				}
			}
			catch (Exception)
			{
			}
			num = (short)722075648;
			short num5 = num;
			num = (short)1440219137;
			if (num != 0)
			{
			}
		}

		// Token: 0x06000880 RID: 2176 RVA: 0x0008F9AC File Offset: 0x0008DBAC
		private void F1HelpCommandCanExcute(object A_0, CanExecuteRoutedEventArgs A_1)
		{
			short num = (short)2144228779;
			short num2 = num;
			num = (short)623728043;
			switch (num2 == num)
			{
			}
			num = (short)595525632;
			if (num != 0)
			{
			}
			num = (short)335216640;
			short num3 = num;
			num = (short)786956289;
			if (num != 0)
			{
			}
			A_1.CanExecute = true;
		}

		// Token: 0x06000881 RID: 2177 RVA: 0x0008FA60 File Offset: 0x0008DC60
		private void OnHelpButton_Click(object A_0, RoutedEventArgs A_1)
		{
			int a_ = 1;
			short num;
			try
			{
				num = (short)1485872219;
				short num2 = num;
				num = (short)1806212187;
				switch (num2 == num)
				{
				}
				num = (short)1890385920;
				if (num != 0)
				{
				}
				ACPBrowser.Utility.CloseHelpWindowIfOpen();
				ACPBrowser.Utility.DisplayCPSHelpDITA(RptMgrErrorHandler.b("ꞃ뾅릇릉벋ꎑꎓ", a_));
			}
			catch (Exception)
			{
			}
			num = (short)1220411392;
			short num3 = num;
			num = (short)1633812481;
			if (num != 0)
			{
			}
		}

		// Token: 0x04000355 RID: 853
		private string a = string.Empty;
	}
}
