using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Forms;
using System.Windows.Markup;
using System.Windows.Shapes;
using AcpCommonLib;
using CommonResources;
using SpecialFeatures.AcpReportManagerLib;
using SpecialFeatures.FileOperations;

namespace SpecialFeatures.Comms
{
	// Token: 0x0200015B RID: 347
	public partial class LoadTxmCertificateMenu : Window, IDisposable
	{
		// Token: 0x0600119E RID: 4510 RVA: 0x00003674 File Offset: 0x00001874
		public LoadTxmCertificateMenu(string initDir)
		{
			base.WindowStartupLocation = WindowStartupLocation.CenterScreen;
			this.a = null;
			this.b = initDir;
			this.InitializeComponent();
		}

		// Token: 0x0600119F RID: 4511 RVA: 0x00181D40 File Offset: 0x0017FF40
		private void OnButtonClick_Close(object A_0, RoutedEventArgs A_1)
		{
			short num = (short)1965538753;
			short num2 = num;
			num = (short)928955841;
			switch (num2 == num)
			{
			}
			num = (short)1896218624;
			if (num != 0)
			{
			}
			num = (short)258146304;
			short num3 = num;
			num = (short)1644363777;
			if (num != 0)
			{
			}
			base.Close();
		}

		// Token: 0x060011A0 RID: 4512 RVA: 0x00181DF0 File Offset: 0x0017FFF0
		protected virtual void Dispose(bool disposing)
		{
			short num = (short)696451074;
			int num2 = (int)((IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
				{
					num = (short)932708352;
					short num3 = num;
					num = (short)1972539598;
					short num4 = num;
					num = (short)1060671694;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_37;
					default:
						num = (short)2043215872;
						if (num != 0)
						{
						}
						this.c.Dispose();
						num = (short)483131393;
						num2 = (int)((IntPtr)num);
						continue;
					}
					break;
				}
				case 1:
					goto IL_E5;
				case 2:
					switch (0)
					{
					case 0:
						goto IL_31;
					}
					continue;
				}
				goto IL_31;
				IL_37:
				num = (short)592773120;
				num2 = (int)((IntPtr)num);
				continue;
				IL_31:
				if (disposing)
				{
					goto IL_37;
				}
				break;
			}
			IL_E5:
			num = (short)7012353;
			if (num != 0)
			{
			}
		}

		// Token: 0x060011A1 RID: 4513 RVA: 0x00181F0C File Offset: 0x0018010C
		public void Dispose()
		{
			short num = (short)414207908;
			short num2 = num;
			num = (short)746934180;
			switch (num2 == num)
			{
			}
			num = (short)1248264192;
			if (num != 0)
			{
			}
			num = (short)1865023488;
			short num3 = num;
			num = (short)435814401;
			if (num != 0)
			{
			}
			this.Dispose(true);
			GC.SuppressFinalize(this);
		}

		// Token: 0x060011A2 RID: 4514 RVA: 0x00181FC4 File Offset: 0x001801C4
		public void OnButtonClick_BrowseCert(object sender, EventArgs args)
		{
			switch (0)
			{
			case 0:
				goto IL_24;
			}
			int num;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					if (this.a != null)
					{
						num2 = (short)1975123971;
						num = (int)((IntPtr)num2);
						continue;
					}
					return;
				case 1:
					return;
				case 2:
					num2 = (short)957939713;
					if (num2 != 0)
					{
					}
					goto IL_169;
				case 3:
				{
					this.LoadButton.IsEnabled = true;
					this.TxtBoxCertFile.Text = this.a;
					this.c.InitialDirectory = System.IO.Path.GetDirectoryName(this.a);
					num2 = (short)1941631959;
					short num3 = num2;
					num2 = (short)1234564055;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_169;
					default:
						num2 = (short)1265893376;
						if (num2 != 0)
						{
						}
						num2 = (short)1286930433;
						num = (int)((IntPtr)num2);
						continue;
					}
					break;
				}
				case 4:
					if (this.c.ShowDialog() == System.Windows.Forms.DialogResult.OK)
					{
						num2 = (short)1473314818;
						num = (int)((IntPtr)num2);
						continue;
					}
					return;
				}
				goto IL_24;
				IL_169:
				num2 = (short)138739712;
				short num4 = num2;
				this.a = this.c.FileName;
				num2 = (short)1154416640;
				num = (int)((IntPtr)num2);
			}
			return;
			IL_24:
			this.c = new OpenFileDialog();
			this.c.InitialDirectory = this.b;
			this.c.Filter = AppResources.PKCS12_files_Filter;
			this.c.Multiselect = false;
			this.c.RestoreDirectory = true;
			num2 = (short)1277886468;
			num = (int)((IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x060011A3 RID: 4515 RVA: 0x001821B4 File Offset: 0x001803B4
		public void OnButtonClick_LoadCert(object sender, EventArgs args)
		{
			int a_ = 16;
			short num = (short)239796224;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_63;
				}
				string extension;
				string text;
				for (;;)
				{
					IL_30:
					switch (num2)
					{
					case 0:
						if (!(extension == RptMgrErrorHandler.b("붒Ꚗꮘ", a_)))
						{
							num = (short)1671561217;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_281;
					case 1:
						num = (short)1004601348;
						num2 = (int)((IntPtr)num);
						continue;
					case 2:
					{
						num = (short)393805824;
						short num3 = num;
						num = (short)1687355392;
						num2 = (int)((IntPtr)num);
						continue;
					}
					case 3:
						goto IL_207;
					case 4:
						if (extension == RptMgrErrorHandler.b("붒", a_))
						{
							num = (short)1439170568;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_1CF;
					case 5:
					{
						Comms comms = new Comms();
						COMMS_OP writeType = COMMS_OP.USB_READ_WRITE;
						if (comms.LoadTxmCertificate(this.a, writeType, false))
						{
							num = (short)1508769801;
							num2 = (int)((IntPtr)num);
							continue;
						}
						return;
					}
					case 6:
						num = (short)1884356609;
						if (num != 0)
						{
						}
						num = (short)1092747271;
						num2 = (int)((IntPtr)num);
						continue;
					case 7:
						if (text != "")
						{
							goto IL_1B5;
						}
						goto IL_1CF;
					case 8:
						goto IL_281;
					case 9:
						goto IL_2CD;
					case 10:
					{
						if (!File.Exists(text))
						{
							goto IL_1CF;
						}
						num = (short)458139424;
						short num4 = num;
						num = (short)869377824;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_1B5;
						default:
							num = (short)1852178432;
							if (num != 0)
							{
							}
							num = (short)821624838;
							num2 = (int)((IntPtr)num);
							continue;
						}
						break;
					}
					}
					goto IL_63;
					IL_1B5:
					num = (short)519831554;
					num2 = (int)((IntPtr)num);
					continue;
					IL_1CF:
					MessageWindow messageWindow = new MessageWindow(AppResources.Select_Valid_PKCS12_Certificate);
					Window window = Window.GetWindow(this);
					messageWindow.Owner = window;
					messageWindow.ShowDialog();
					num = (short)892993539;
					num2 = (int)((IntPtr)num);
					continue;
					IL_281:
					base.Close();
					num = (short)28573701;
					num2 = (int)((IntPtr)num);
				}
				IL_207:
				return;
				IL_2CD:
				AppInfoManager.StatusMsgReport.Clear();
				StatusMsgType type = StatusMsgType.Info;
				AppInfoManager.StatusMsgReport.RegisterMessage(type, AppResources.Load_Txm_Cert_Success);
				return;
				IL_63:
				text = this.TxtBoxCertFile.Text;
				extension = System.IO.Path.GetExtension(text);
				num = (short)1691942922;
				num2 = (int)((IntPtr)num);
				goto IL_30;
			}
			}
		}

		// Token: 0x04000997 RID: 2455
		public bool bCommSuccess = true;

		// Token: 0x04000998 RID: 2456
		private string a;

		// Token: 0x04000999 RID: 2457
		private string b;

		// Token: 0x0400099A RID: 2458
		private OpenFileDialog c;
	}
}
