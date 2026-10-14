using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;
using System.Windows.Media;
using AcpFileHandlerLib;
using AcpUI.Common;
using AcpUtility;
using CommonResources;
using CommonUtility;
using SpecialFeatures.AcpReportManagerLib;
using SpecialFeatures.Flashport.FlashRadio;

namespace SpecialFeatures.DepotLabtool
{
	// Token: 0x0200013E RID: 318
	public partial class DepotUpgradeRadioWnd : Window
	{
		// Token: 0x0600107A RID: 4218 RVA: 0x00003544 File Offset: 0x00001744
		public DepotUpgradeRadioWnd()
		{
			this.InitializeComponent();
			this.upgradeFile = "";
			Utility.SetDirection(this);
		}

		// Token: 0x17000557 RID: 1367
		// (get) Token: 0x0600107C RID: 4220 RVA: 0x00170188 File Offset: 0x0016E388
		// (set) Token: 0x0600107B RID: 4219 RVA: 0x001700D4 File Offset: 0x0016E2D4
		public string ModelNumber
		{
			get
			{
				short num = (short)1198784513;
				if (num != 0)
				{
				}
				num = (short)215482841;
				short num2 = num;
				num = (short)1410007513;
				switch (num2 == num)
				{
				}
				num = (short)73531392;
				if (num != 0)
				{
				}
				num = (short)331415552;
				short num3 = num;
				return this.txtModelNumber.Text.ToString();
			}
			set
			{
				short num = (short)1295312638;
				short num2 = num;
				num = (short)261416702;
				switch (num2 == num)
				{
				}
				num = (short)1614741505;
				if (num != 0)
				{
				}
				num = (short)1941635072;
				if (num != 0)
				{
				}
				num = (short)1199898624;
				short num3 = num;
				this.txtModelNumber.Text = value;
			}
		}

		// Token: 0x17000558 RID: 1368
		// (set) Token: 0x0600107D RID: 4221 RVA: 0x00170244 File Offset: 0x0016E444
		public string FlashCode
		{
			set
			{
				short num = (short)1110749094;
				short num2 = num;
				num = (short)1180676006;
				switch (num2 == num)
				{
				}
				num = (short)293011457;
				if (num != 0)
				{
				}
				num = (short)1787428864;
				if (num != 0)
				{
				}
				num = (short)1161297920;
				short num3 = num;
				string[] array = DepotUpgradeRadioWnd.a(value);
				this.txtFlashCode1.Text = array[0];
				this.txtFlashCode2.Text = array[1];
				this.txtFlashCodeCheckSum.Text = array[2];
			}
		}

		// Token: 0x0600107E RID: 4222 RVA: 0x0017031C File Offset: 0x0016E51C
		private static string[] a(string A_0)
		{
			short num = (short)1874369274;
			short num2 = num;
			num = (short)220830458;
			switch (num2 == num)
			{
			}
			num = (short)1842937856;
			if (num != 0)
			{
			}
			num = (short)1387462657;
			if (num != 0)
			{
			}
			num = (short)2096562176;
			short num3 = num;
			return A_0.Trim().Split(new char[]
			{
				'-'
			});
		}

		// Token: 0x0600107F RID: 4223 RVA: 0x001703DC File Offset: 0x0016E5DC
		private static string a(string[] A_0)
		{
			int a_ = 15;
			short num = (short)1996554241;
			if (num != 0)
			{
			}
			num = (short)677696986;
			short num2 = num;
			num = (short)1999558106;
			switch (num2 == num)
			{
			}
			num = (short)1208352768;
			if (num != 0)
			{
			}
			num = (short)696844288;
			short num3 = num;
			return string.Concat(new string[]
			{
				A_0[0],
				RptMgrErrorHandler.b("뾑", a_),
				A_0[1],
				RptMgrErrorHandler.b("뾑", a_),
				A_0[2]
			});
		}

		// Token: 0x17000559 RID: 1369
		// (get) Token: 0x06001080 RID: 4224 RVA: 0x001704D4 File Offset: 0x0016E6D4
		// (set) Token: 0x06001081 RID: 4225 RVA: 0x001705B0 File Offset: 0x0016E7B0
		public string NewFlashCode
		{
			get
			{
				short num = (short)635565373;
				short num2 = num;
				num = (short)1292694845;
				switch (num2 == num)
				{
				}
				num = (short)1233453057;
				if (num != 0)
				{
				}
				num = (short)423034880;
				if (num != 0)
				{
				}
				num = (short)901316608;
				short num3 = num;
				return DepotUpgradeRadioWnd.a(new string[]
				{
					this.txtNewFlashCode1.Text,
					this.txtNewFlashCode2.Text,
					this.txtNewFlashCodeCheckSum.Text
				});
			}
			set
			{
				short num = (short)2125451807;
				short num2 = num;
				num = (short)811782687;
				switch (num2 == num)
				{
				}
				num = (short)782434305;
				if (num != 0)
				{
				}
				num = (short)1286275072;
				if (num != 0)
				{
				}
				num = (short)1610022912;
				short num3 = num;
				string[] array = DepotUpgradeRadioWnd.a(value);
				this.txtNewFlashCode1.Text = array[0];
				this.txtNewFlashCode2.Text = array[1];
				this.txtNewFlashCodeCheckSum.Text = array[2];
			}
		}

		// Token: 0x1700055A RID: 1370
		// (get) Token: 0x06001082 RID: 4226 RVA: 0x0017068C File Offset: 0x0016E88C
		// (set) Token: 0x06001083 RID: 4227 RVA: 0x00170740 File Offset: 0x0016E940
		public string upgradeFile
		{
			get
			{
				short num = (short)1513410385;
				short num2 = num;
				num = (short)728354641;
				switch (num2 == num)
				{
				}
				num = (short)1169358848;
				if (num != 0)
				{
				}
				num = (short)1395064833;
				if (num != 0)
				{
				}
				num = (short)1097662464;
				short num3 = num;
				return this.txtFlashUpgradeFile.Text;
			}
			set
			{
				short num = (short)663289857;
				if (num != 0)
				{
				}
				num = (short)1858036788;
				short num2 = num;
				num = (short)1465410612;
				switch (num2 == num)
				{
				}
				num = (short)1146355712;
				if (num != 0)
				{
				}
				num = (short)99942400;
				short num3 = num;
				this.txtFlashUpgradeFile.Text = value;
			}
		}

		// Token: 0x06001084 RID: 4228 RVA: 0x001707F4 File Offset: 0x0016E9F4
		private void btnOK_Click(object A_0, RoutedEventArgs A_1)
		{
			int a_ = 7;
			short num = (short)1092747270;
			int num2 = (int)((IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_EB;
				case 1:
					num = (short)1327955969;
					if (num != 0)
					{
					}
					if (File.Exists(this.upgradeFile))
					{
						num = (short)1028521989;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_1DF;
				case 2:
				{
					string text = this.txtNewFlashCode1.Text;
					this.txtNewFlashCode1.Text = text;
					num = (short)1389363200;
					num2 = (int)((IntPtr)num);
					continue;
				}
				case 3:
					goto IL_BC;
				case 4:
					IL_95:
					if (!string.IsNullOrEmpty(this.upgradeFile))
					{
						num = (short)799473667;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_1DF;
				case 5:
					num = (short)534577156;
					num2 = (int)((IntPtr)num);
					continue;
				case 6:
					switch (0)
					{
					case 0:
						goto IL_4A;
					}
					continue;
				}
				IL_4A:
				if (this.ModelNumber == RptMgrErrorHandler.b("쮉\udc8b획ꢏꊑ꒓ꚕ", a_))
				{
					num = (short)866058242;
					num2 = (int)((IntPtr)num);
					continue;
				}
				goto IL_EB;
				IL_1DF:
				num = (short)749280041;
				short num3 = num;
				num = (short)970988329;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_95;
				default:
					goto IL_215;
				}
				IL_EB:
				num = (short)475267073;
				num2 = (int)((IntPtr)num);
			}
			IL_BC:
			num = (short)526057472;
			short num4 = num;
			this.c.UpgradeFile = this.upgradeFile;
			this.c.NewFlashCode = this.NewFlashCode;
			base.Hide();
			new DepotPageUpgradeRadioProgressWnd(this.c)
			{
				Owner = this,
				progressBar2 = 
				{
					Value = 0.0
				}
			}.ShowDialog();
			return;
			IL_215:
			num = (short)378667008;
			if (num != 0)
			{
			}
			MessageWindow messageWindow = new MessageWindow(AppResources.Select_Valid_Upgrade_File);
			Window window = Window.GetWindow(this);
			messageWindow.Owner = window;
			messageWindow.ShowDialog();
		}

		// Token: 0x06001085 RID: 4229 RVA: 0x00170A4C File Offset: 0x0016EC4C
		private void btnBrowse_Click(object A_0, RoutedEventArgs A_1)
		{
			int a_ = 5;
			switch (0)
			{
			case 0:
				goto IL_25;
			}
			int num;
			bool? flag;
			bool flag2;
			short num2;
			AcpOpenFileDialog acpOpenFileDialog;
			for (;;)
			{
				IL_13:
				switch (num)
				{
				case 0:
					goto IL_D4;
				case 1:
					goto IL_AF;
				case 2:
					if (flag.GetValueOrDefault() == flag2 & flag != null)
					{
						num2 = (short)1839661057;
						num = (int)((IntPtr)num2);
						continue;
					}
					goto IL_D4;
				}
				goto IL_25;
				IL_AF:
				this.upgradeFile = acpOpenFileDialog.FileName;
				num2 = (short)304676864;
				num = (int)((IntPtr)num2);
				continue;
				IL_D4:
				num2 = (short)1041513258;
				short num3 = num2;
				num2 = (short)742603562;
				switch ((num3 == num2) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_AF;
				default:
					goto IL_108;
				}
			}
			IL_108:
			num2 = (short)710672385;
			if (num2 != 0)
			{
			}
			num2 = (short)814743552;
			if (num2 != 0)
			{
			}
			num2 = (short)2020933632;
			short num4 = num2;
			return;
			IL_25:
			acpOpenFileDialog = new AcpOpenFileDialog();
			acpOpenFileDialog.Filter = AppResources.FLASHport_Upgrade_Files.AcpStringFormat(new object[]
			{
				RptMgrErrorHandler.b("ꢇꊉꚋꂍ뾕낙늛ﲝ슟쒡\ud8a3ﾫ삯\uddb1욳습颷첻\ud9bd늿ꏁꃃꏅ賉ꗋꋍ뗏ꇑﻕ뿛꣝軟쯡飣쳥웧觩髫胭賯돱飳髵\ud8f7鳹闻鋽旿焁␃⸅∇␉☋✍氏㠑㨓㰕", a_)
			});
			acpOpenFileDialog.MultiSelect = false;
			acpOpenFileDialog.FileName = this.upgradeFile;
			flag = acpOpenFileDialog.ShowDialog();
			flag2 = true;
			num2 = (short)1852375042;
			num = (int)((IntPtr)num2);
			goto IL_13;
		}

		// Token: 0x06001086 RID: 4230 RVA: 0x00170BC8 File Offset: 0x0016EDC8
		private void txtNewFlashCode_TextChanged(object A_0, TextChangedEventArgs A_1)
		{
			short num = (short)1946353673;
			int num2 = (int)((IntPtr)num);
			for (;;)
			{
				num = (short)1650524161;
				if (num != 0)
				{
				}
				num = (short)273350656;
				short num3 = num;
				switch (num2)
				{
				case 0:
					num = (short)140443652;
					num2 = (int)((IntPtr)num);
					continue;
				case 1:
				{
					byte b;
					this.txtNewFlashCodeCheckSum.Text = b.ToString();
					this.b = FlashcodeValidator.Validate(this.NewFlashCode);
					num = (short)1430257667;
					num2 = (int)((IntPtr)num);
					continue;
				}
				case 2:
					num = (short)225902599;
					num2 = (int)((IntPtr)num);
					continue;
				case 3:
					goto IL_142;
				case 4:
				{
					if (this.txtNewFlashCodeCheckSum == null)
					{
						num = (short)1639514120;
						num2 = (int)((IntPtr)num);
						continue;
					}
					byte b = FlashcodeValidator.CalculateFlashCodeCheckDigit(this.txtNewFlashCode1.Text + this.txtNewFlashCode2.Text);
					num = (short)1162805253;
					num2 = (int)((IntPtr)num);
					continue;
				}
				case 5:
				{
					byte b;
					if (b != 255)
					{
						num = (short)1198915585;
						num2 = (int)((IntPtr)num);
						continue;
					}
					this.txtNewFlashCodeCheckSum.Text = ' '.ToString();
					this.b = false;
					num = (short)55377926;
					num2 = (int)((IntPtr)num);
					continue;
				}
				case 6:
					goto IL_1B4;
				case 7:
					if (this.txtNewFlashCode2 != null)
					{
						num = (short)64487424;
						num2 = (int)((IntPtr)num);
						continue;
					}
					return;
				case 8:
					goto IL_1F0;
				case 9:
				{
					num = (short)428180889;
					short num4 = num;
					num = (short)1421837721;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						return;
					default:
						num = (short)787087360;
						if (num != 0)
						{
						}
						switch (0)
						{
						case 0:
							goto IL_E6;
						}
						continue;
					}
					break;
				}
				}
				IL_E6:
				if (this.txtNewFlashCode1 == null)
				{
					return;
				}
				num = (short)1648492546;
				num2 = (int)((IntPtr)num);
			}
			IL_142:
			IL_1B4:
			goto IL_254;
			IL_1F0:
			return;
			IL_254:
			this.a();
		}

		// Token: 0x06001087 RID: 4231 RVA: 0x00170E30 File Offset: 0x0016F030
		private void txtFlashUpgradeFile_TextChanged(object A_0, TextChangedEventArgs A_1)
		{
			short num = (short)1190854657;
			if (num != 0)
			{
			}
			num = (short)1073681290;
			short num2 = num;
			num = (short)2078741386;
			switch (num2 == num)
			{
			}
			num = (short)1090519040;
			if (num != 0)
			{
			}
			num = (short)2011824128;
			short num3 = num;
			this.a = (File.Exists(this.upgradeFile) && (BundleNameUtility.IsCVNFile(this.upgradeFile.Trim()) || BundleNameUtility.IsBBFFile(this.upgradeFile.Trim())));
			this.a();
		}

		// Token: 0x06001088 RID: 4232 RVA: 0x00170F20 File Offset: 0x0016F120
		private void a()
		{
			short num = (short)953679880;
			int num2 = (int)((IntPtr)num);
			for (;;)
			{
				Brush borderBrush;
				Brush borderBrush2;
				switch (num2)
				{
				case 0:
					num = (short)1303183361;
					if (num != 0)
					{
					}
					borderBrush = this.txtModelNumber.BorderBrush;
					num = (short)1083441159;
					num2 = (int)((IntPtr)num);
					continue;
				case 1:
					if (this.a)
					{
						num = (short)547684352;
						num2 = (int)((IntPtr)num);
						continue;
					}
					borderBrush = Brushes.Red;
					num = (short)1867382790;
					num2 = (int)((IntPtr)num);
					continue;
				case 2:
				{
					num = (short)758665858;
					short num3 = num;
					num = (short)1534218882;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_204;
					default:
					{
						num = (short)1851457536;
						if (num != 0)
						{
						}
						num = (short)271777792;
						short num4 = num;
						borderBrush2 = this.txtModelNumber.BorderBrush;
						num = (short)1708982275;
						num2 = (int)((IntPtr)num);
						continue;
					}
					}
					break;
				}
				case 3:
					goto IL_204;
				case 4:
					goto IL_B4;
				case 5:
					goto IL_204;
				case 6:
					goto IL_6D;
				case 7:
					goto IL_6D;
				case 8:
					switch (0)
					{
					case 0:
						goto IL_49;
					}
					continue;
				}
				IL_49:
				if (this.b)
				{
					num = (short)1967783938;
					num2 = (int)((IntPtr)num);
					continue;
				}
				borderBrush2 = Brushes.Red;
				num = (short)412155909;
				num2 = (int)((IntPtr)num);
				continue;
				IL_6D:
				this.txtNewFlashCode1.BorderBrush = borderBrush2;
				this.txtNewFlashCode2.BorderBrush = borderBrush2;
				this.txtNewFlashCodeCheckSum.BorderBrush = borderBrush2;
				this.txtFlashUpgradeFile.BorderBrush = borderBrush;
				num = (short)163053572;
				num2 = (int)((IntPtr)num);
				continue;
				IL_204:
				num = (short)800456705;
				num2 = (int)((IntPtr)num);
			}
			IL_B4:
			this.btnOK.IsEnabled = (this.a && this.b);
		}

		// Token: 0x0400088E RID: 2190
		private bool a;

		// Token: 0x0400088F RID: 2191
		private bool b;

		// Token: 0x04000890 RID: 2192
		private UpgradeRadioData c = new UpgradeRadioData();
	}
}
