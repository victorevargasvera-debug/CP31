using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
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
	// Token: 0x0200005F RID: 95
	public partial class ChangePassword : Window
	{
		// Token: 0x1700039E RID: 926
		// (get) Token: 0x06000870 RID: 2160 RVA: 0x0008E6B4 File Offset: 0x0008C8B4
		// (set) Token: 0x06000871 RID: 2161 RVA: 0x0008E764 File Offset: 0x0008C964
		public bool IsCancelButtonClicked
		{
			[CompilerGenerated]
			get
			{
				short num = (short)2141150261;
				short num2 = num;
				num = (short)430726197;
				switch (num2 == num)
				{
				default:
				{
					num = (short)188678144;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1624637440;
				if (num != 0)
				{
				}
				num = (short)1527906305;
				if (num != 0)
				{
				}
				return this.c;
			}
			[CompilerGenerated]
			set
			{
				short num = (short)357104242;
				short num2 = num;
				num = (short)1607793266;
				switch (num2 == num)
				{
				default:
				{
					num = (short)115933184;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)667942913;
				if (num != 0)
				{
				}
				num = (short)1881538560;
				if (num != 0)
				{
				}
				this.c = value;
			}
		}

		// Token: 0x06000872 RID: 2162 RVA: 0x00002979 File Offset: 0x00000B79
		internal ChangePassword(string codeplugPassword)
		{
			this.InitializeComponent();
			AcpUI.Common.Utility.SetDirection(this);
			this.a = string.Empty;
			this.b = codeplugPassword;
			this.IsCancelButtonClicked = true;
			this.CurrentPasswordBox.Focus();
		}

		// Token: 0x1700039F RID: 927
		// (get) Token: 0x06000873 RID: 2163 RVA: 0x0008E818 File Offset: 0x0008CA18
		// (set) Token: 0x06000874 RID: 2164 RVA: 0x0008E8C8 File Offset: 0x0008CAC8
		internal string UserEnteredPassword
		{
			get
			{
				short num = (short)860517391;
				short num2 = num;
				num = (short)1027568655;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1455882240;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)105447424;
				if (num != 0)
				{
				}
				num = (short)691077121;
				if (num != 0)
				{
				}
				return this.a;
			}
			set
			{
				short num = (short)1877999617;
				if (num != 0)
				{
				}
				num = (short)1840513024;
				short num2 = num;
				num = (short)370091570;
				short num3 = num;
				num = (short)1072244274;
				switch (num3 == num)
				{
				}
				num = (short)807469056;
				if (num != 0)
				{
				}
				this.a = value;
			}
		}

		// Token: 0x06000875 RID: 2165 RVA: 0x0008E978 File Offset: 0x0008CB78
		private void OnClickOK(object A_0, RoutedEventArgs A_1)
		{
			short num = (short)1025310720;
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
				string password;
				string text;
				char[] array;
				int num3;
				ReadWriteUtil readWriteUtil;
				bool flag;
				string password2;
				string password3;
				for (;;)
				{
					IL_27:
					switch (num2)
					{
					case 0:
						if (password != text)
						{
							num = (short)763822100;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_124;
					case 1:
						num = (short)314703887;
						num2 = (int)((IntPtr)num);
						continue;
					case 2:
						if (array[num3] >= '\u0080')
						{
							num = (short)1297940489;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_190;
					case 3:
						num = (short)1746206732;
						num2 = (int)((IntPtr)num);
						continue;
					case 4:
						if (num3 >= array.Length)
						{
							num = (short)1900740624;
							num2 = (int)((IntPtr)num);
							continue;
						}
						num = (short)1658191874;
						num2 = (int)((IntPtr)num);
						continue;
					case 5:
						num = (short)649592846;
						num2 = (int)((IntPtr)num);
						continue;
					case 6:
						if (!readWriteUtil.isHiddenPwd(password, null))
						{
							num = (short)50266123;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_124;
					case 7:
						goto IL_367;
					case 8:
						goto IL_190;
					case 9:
						flag = true;
						num = (short)1871708168;
						num2 = (int)((IntPtr)num);
						continue;
					case 10:
						goto IL_2F0;
					case 11:
						num = (short)1133314048;
						num2 = (int)((IntPtr)num);
						continue;
					case 12:
						if (!flag)
						{
							num = (short)1047265287;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_44E;
					case 13:
						goto IL_2F0;
					case 14:
						if (password2.Length <= 16)
						{
							num = (short)1018036227;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_44E;
					case 15:
						if (password2.Length >= 6)
						{
							num = (short)687800325;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_44E;
					case 16:
						num = (short)1535049734;
						num2 = (int)((IntPtr)num);
						continue;
					case 17:
						if (password2 != null)
						{
							num = (short)1240530945;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_44E;
					case 18:
						goto IL_18B;
					case 19:
						if (password2 != password3)
						{
							num = (short)1026555922;
							num2 = (int)((IntPtr)num);
							continue;
						}
						num = (short)207880209;
						num2 = (int)((IntPtr)num);
						continue;
					case 20:
						goto IL_449;
					}
					goto IL_82;
					IL_124:
					num = (short)77725696;
					short num4 = num;
					num = (short)660275219;
					num2 = (int)((IntPtr)num);
					continue;
					IL_190:
					num = (short)1309405826;
					short num5 = num;
					num = (short)270987906;
					switch ((num5 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num = (short)77987840;
						if (num != 0)
						{
						}
						num3++;
						break;
					}
					num = (short)157810689;
					if (num != 0)
					{
					}
					num = (short)659357709;
					num2 = (int)((IntPtr)num);
					continue;
					IL_2F0:
					num = (short)1538850820;
					num2 = (int)((IntPtr)num);
				}
				IL_18B:
				MessageBox.Show(AppResources.New_Passwords_Do_Not_Match, AppResources.APX_CPS, MessageBoxButton.OK, MessageBoxImage.Exclamation, MessageBoxResult.OK);
				return;
				IL_367:
				this.a = password2;
				base.Close();
				return;
				IL_449:
				MessageBox.Show(AppResources.Incorrect_Password, AppResources.APX_CPS, MessageBoxButton.OK, MessageBoxImage.Exclamation, MessageBoxResult.OK);
				return;
				IL_44E:
				MessageBox.Show(AppResources.Must_Contain_6_to_16_Characters, AppResources.APX_CPS, MessageBoxButton.OK, MessageBoxImage.Exclamation, MessageBoxResult.OK);
				return;
				IL_82:
				password = this.CurrentPasswordBox.Password;
				password2 = this.NewPasswordBox.Password;
				password3 = this.ConfirmPasswordBox.Password;
				readWriteUtil = new ReadWriteUtil();
				text = this.b;
				flag = false;
				char[] array2 = password2.ToCharArray();
				this.IsCancelButtonClicked = false;
				array = array2;
				num3 = 0;
				num = (short)1204158474;
				num2 = (int)((IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x06000876 RID: 2166 RVA: 0x0008EDE8 File Offset: 0x0008CFE8
		private void OnClickCancel(object A_0, RoutedEventArgs A_1)
		{
			short num = (short)681828022;
			short num2 = num;
			num = (short)974315190;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1500446720;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1254817793;
			if (num != 0)
			{
			}
			num = (short)1514274816;
			if (num != 0)
			{
			}
			this.a = string.Empty;
			this.IsCancelButtonClicked = true;
			base.Close();
		}

		// Token: 0x06000877 RID: 2167 RVA: 0x0008EEAC File Offset: 0x0008D0AC
		private void F1HelpCommandCanExcute(object A_0, CanExecuteRoutedEventArgs A_1)
		{
			short num = (short)1305572959;
			short num2 = num;
			num = (short)510293599;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1920794624;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1084162048;
			if (num != 0)
			{
			}
			num = (short)230162433;
			if (num != 0)
			{
			}
			A_1.CanExecute = true;
		}

		// Token: 0x06000878 RID: 2168 RVA: 0x0008EF5C File Offset: 0x0008D15C
		private void OnHelpButton_Click(object A_0, RoutedEventArgs A_1)
		{
			int a_ = 4;
			short num;
			try
			{
				num = (short)1422710552;
				short num2 = num;
				num = (short)23844632;
				switch (num2 == num)
				{
				}
				num = (short)1463222272;
				if (num != 0)
				{
				}
				ACPBrowser.Utility.CloseHelpWindowIfOpen();
				ACPBrowser.Utility.DisplayCPSHelpDITA(RptMgrErrorHandler.b("ꒆ몈", a_));
			}
			catch (Exception)
			{
			}
			num = (short)748027905;
			if (num != 0)
			{
			}
			num = (short)629669888;
			short num3 = num;
		}

		// Token: 0x04000346 RID: 838
		private string a;

		// Token: 0x04000347 RID: 839
		private string b;

		// Token: 0x04000348 RID: 840
		[CompilerGenerated]
		private bool c;
	}
}
