using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;
using System.Windows.Media;
using AcpCommonLib;
using AcpUI.Common;
using Motorola.MackinawCPS.CoreFeatures.RadioInformation;
using Motorola.MackinawCPS.CoreFeatures.RadioWide;
using SpecialFeatures.AcpReportManagerLib;
using SpecialFeatures.Flashport.FlashRadio;

namespace SpecialFeatures.DepotLabtool
{
	// Token: 0x0200013C RID: 316
	public partial class DepotUpgradeCodeplugWnd : Window
	{
		// Token: 0x06001057 RID: 4183 RVA: 0x0016D8E8 File Offset: 0x0016BAE8
		public DepotUpgradeCodeplugWnd()
		{
			this.DepotOptions = new List<string>();
			this.InitializeComponent();
			AcpUI.Common.Utility.SetDirection(this);
		}

		// Token: 0x17000550 RID: 1360
		// (get) Token: 0x06001059 RID: 4185 RVA: 0x0016D9F8 File Offset: 0x0016BBF8
		// (set) Token: 0x06001058 RID: 4184 RVA: 0x0016D944 File Offset: 0x0016BB44
		public string ModelNumber
		{
			get
			{
				short num = (short)372432181;
				short num2 = num;
				num = (short)109370677;
				switch (num2 == num)
				{
				default:
				{
					num = (short)57671680;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1564803073;
				if (num != 0)
				{
				}
				num = (short)1584594944;
				if (num != 0)
				{
				}
				return this.txtModelNumber.Text.ToString();
			}
			set
			{
				short num = (short)449024285;
				short num2 = num;
				num = (short)95719709;
				switch (num2 == num)
				{
				default:
				{
					num = (short)671023104;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)510853121;
				if (num != 0)
				{
				}
				num = (short)1829240832;
				if (num != 0)
				{
				}
				this.txtModelNumber.Text = value;
			}
		}

		// Token: 0x17000551 RID: 1361
		// (get) Token: 0x0600105B RID: 4187 RVA: 0x0016DB68 File Offset: 0x0016BD68
		// (set) Token: 0x0600105A RID: 4186 RVA: 0x0016DAB4 File Offset: 0x0016BCB4
		public string SerialNumber
		{
			get
			{
				short num = (short)1829366853;
				short num2 = num;
				num = (short)1209986117;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1146486784;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1690959873;
				if (num != 0)
				{
				}
				num = (short)114556928;
				if (num != 0)
				{
				}
				return this.txtSerNum.Text.ToString();
			}
			set
			{
				short num = (short)1566750773;
				short num2 = num;
				num = (short)1805039669;
				switch (num2 == num)
				{
				default:
				{
					num = (short)158859264;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)980090881;
				if (num != 0)
				{
				}
				num = (short)548732928;
				if (num != 0)
				{
				}
				this.txtSerNum.Text = value;
			}
		}

		// Token: 0x17000552 RID: 1362
		// (get) Token: 0x0600105D RID: 4189 RVA: 0x0016DD00 File Offset: 0x0016BF00
		// (set) Token: 0x0600105C RID: 4188 RVA: 0x0016DC24 File Offset: 0x0016BE24
		public string FlashCode
		{
			get
			{
				int a_ = 9;
				short num = (short)647722060;
				short num2 = num;
				num = (short)1603761228;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1130364928;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1550647297;
				if (num != 0)
				{
				}
				num = (short)592838656;
				if (num != 0)
				{
				}
				return string.Concat(new string[]
				{
					this.txtFlashCode1.Text,
					RptMgrErrorHandler.b("ꆋ", a_),
					this.txtFlashCode2.Text,
					RptMgrErrorHandler.b("ꆋ", a_),
					this.txtFlashCodeCheckSum.Text
				});
			}
			set
			{
				short num = (short)301122394;
				short num2 = num;
				num = (short)1294123866;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1659109376;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1230503937;
				if (num != 0)
				{
				}
				num = (short)1820196864;
				if (num != 0)
				{
				}
				string[] array = DepotUpgradeCodeplugWnd.a(value);
				this.txtFlashCode1.Text = array[0];
				this.txtFlashCode2.Text = array[1];
				this.txtFlashCodeCheckSum.Text = array[2];
			}
		}

		// Token: 0x17000553 RID: 1363
		// (get) Token: 0x0600105F RID: 4191 RVA: 0x0016DEBC File Offset: 0x0016C0BC
		// (set) Token: 0x0600105E RID: 4190 RVA: 0x0016DE0C File Offset: 0x0016C00C
		public string FwVersion
		{
			get
			{
				short num = (short)1160989791;
				short num2 = num;
				num = (short)1195134047;
				switch (num2 == num)
				{
				default:
				{
					num = (short)799997952;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)473104385;
				if (num != 0)
				{
				}
				num = (short)1449066496;
				if (num != 0)
				{
				}
				return this.c;
			}
			set
			{
				short num = (short)762424502;
				short num2 = num;
				num = (short)1415883958;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1346043904;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)177930240;
				if (num != 0)
				{
				}
				num = (short)2035941377;
				if (num != 0)
				{
				}
				this.c = value;
			}
		}

		// Token: 0x17000554 RID: 1364
		// (get) Token: 0x06001061 RID: 4193 RVA: 0x0016E028 File Offset: 0x0016C228
		// (set) Token: 0x06001060 RID: 4192 RVA: 0x0016DF6C File Offset: 0x0016C16C
		public bool DisableEnc
		{
			get
			{
				short num = (short)1965883392;
				short num2 = num;
				num = (short)1771342811;
				short num3 = num;
				num = (short)965315547;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)2144600064;
					if (num != 0)
					{
					}
					bool? isChecked = this.cbDisableEnc.IsChecked;
					bool flag = true;
					if (!(isChecked.GetValueOrDefault() == flag & isChecked != null))
					{
						num = (short)903806977;
						if (num != 0)
						{
						}
						return false;
					}
					break;
				}
				}
				return true;
			}
			set
			{
				short num = (short)2035041622;
				short num2 = num;
				num = (short)753157462;
				switch (num2 == num)
				{
				default:
				{
					num = (short)8519680;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)535494656;
				if (num != 0)
				{
				}
				num = (short)1454702593;
				if (num != 0)
				{
				}
				this.cbDisableEnc.IsChecked = new bool?(value);
			}
		}

		// Token: 0x06001062 RID: 4194 RVA: 0x0016E0F8 File Offset: 0x0016C2F8
		private static string[] a(string A_0)
		{
			short num = (short)1864451516;
			short num2 = num;
			num = (short)1676559804;
			switch (num2 == num)
			{
			default:
			{
				num = (short)2001207296;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1379205121;
			if (num != 0)
			{
			}
			num = (short)1056636928;
			if (num != 0)
			{
			}
			return A_0.Trim().Split(new char[]
			{
				'-'
			});
		}

		// Token: 0x06001063 RID: 4195 RVA: 0x0016E1B8 File Offset: 0x0016C3B8
		private static string a(string[] A_0)
		{
			int a_ = 14;
			short num = (short)239658823;
			short num2 = num;
			num = (short)789964615;
			switch (num2 == num)
			{
			default:
			{
				num = (short)431226880;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1494679553;
			if (num != 0)
			{
			}
			num = (short)450625536;
			if (num != 0)
			{
			}
			return string.Concat(new string[]
			{
				A_0[0],
				RptMgrErrorHandler.b("벐", a_),
				A_0[1],
				RptMgrErrorHandler.b("벐", a_),
				A_0[2]
			});
		}

		// Token: 0x06001064 RID: 4196 RVA: 0x0016E2AC File Offset: 0x0016C4AC
		private void c()
		{
			int a_ = 5;
			short num = (short)2084241409;
			if (num != 0)
			{
			}
			num = (short)39836895;
			short num2 = num;
			num = (short)1505156319;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)965279744;
				short num3 = num;
				num = (short)208207872;
				if (num != 0)
				{
				}
				num = (short)2025193472;
				int num4 = (int)num;
				switch (num4)
				{
				}
				break;
			}
			}
			this.e.AddPCIOptionsForUpgrade();
			try
			{
				switch (0)
				{
				case 0:
					goto IL_133;
				}
				int num4;
				RadioWide radioWide;
				for (;;)
				{
					IL_D8:
					switch (num4)
					{
					case 0:
					{
						bool? isChecked = this.cbDisableEnc.IsChecked;
						bool flag = false;
						num = (short)890306564;
						num4 = (int)((IntPtr)num);
						continue;
					}
					case 1:
						num = (short)1689059335;
						num4 = (int)((IntPtr)num);
						continue;
					case 2:
						if (this.txtFlashCode2.Text.Length == 6)
						{
							num = (short)1235812370;
							num4 = (int)((IntPtr)num);
							continue;
						}
						goto IL_47B;
					case 3:
						goto IL_2FD;
					case 4:
					{
						bool? isChecked;
						bool flag;
						if (isChecked.GetValueOrDefault() == flag & isChecked != null)
						{
							num = (short)893648916;
							num4 = (int)((IntPtr)num);
							continue;
						}
						radioWide.Labtool.RadWideLabtoolDisableEncryption_43371.SetValue(true);
						num = (short)1412038659;
						num4 = (int)((IntPtr)num);
						continue;
					}
					case 5:
					{
						byte b;
						if ((b & 8) != 0)
						{
							num = (short)1085603849;
							num4 = (int)((IntPtr)num);
							continue;
						}
						radioWide.Labtool.RadWideLabtoolAPX6000P25Radio_A42121.SetValue(false);
						num = (short)678297612;
						num4 = (int)((IntPtr)num);
						continue;
					}
					case 6:
						goto IL_493;
					case 7:
						if (this.txtModelNumber.Text.StartsWith(RptMgrErrorHandler.b("삇뎉뒋", a_)))
						{
							num = (short)1706426387;
							num4 = (int)((IntPtr)num);
							continue;
						}
						goto IL_47B;
					case 8:
						goto IL_2FD;
					case 9:
						radioWide.Labtool.RadWideLabtoolAPX6000P25Radio_A42121.SetValue(true);
						num = (short)1530069009;
						num4 = (int)((IntPtr)num);
						continue;
					case 10:
						num = (short)1405222917;
						num4 = (int)((IntPtr)num);
						continue;
					case 11:
					{
						RadioInformation radioInformation;
						if (radioInformation.Labtool.RadInfoLabtoolProductModelIdentifier_A37178.Value == 3)
						{
							num = (short)967245834;
							num4 = (int)((IntPtr)num);
							continue;
						}
						goto IL_47B;
					}
					case 12:
						goto IL_47B;
					case 13:
						if (radioWide != null)
						{
							num = (short)976093184;
							num4 = (int)((IntPtr)num);
							continue;
						}
						goto IL_47B;
					case 14:
						num = (short)2055995394;
						num4 = (int)((IntPtr)num);
						continue;
					case 15:
					{
						RadioInformation radioInformation;
						if (radioInformation != null)
						{
							num = (short)1709113345;
							num4 = (int)((IntPtr)num);
							continue;
						}
						goto IL_47B;
					}
					case 16:
						if (this.txtFlashCode2 != null)
						{
							num = (short)536150030;
							num4 = (int)((IntPtr)num);
							continue;
						}
						goto IL_47B;
					case 17:
						goto IL_47B;
					case 18:
					{
						byte b = (byte)FlashcodeMapping.GetFlashcodeIntValue(this.txtFlashCode2.Text[5]);
						RadioInformation radioInformation = FeatureManager.GetFeature(2049)[0] as RadioInformation;
						num = (short)1169358863;
						num4 = (int)((IntPtr)num);
						continue;
					}
					case 19:
						num = (short)1282342923;
						num4 = (int)((IntPtr)num);
						continue;
					case 20:
						radioWide.Labtool.RadWideLabtoolDisableEncryption_43371.SetValue(false);
						num = (short)598016008;
						num4 = (int)((IntPtr)num);
						continue;
					}
					goto IL_133;
					IL_2FD:
					num = (short)280428560;
					num4 = (int)((IntPtr)num);
					continue;
					IL_47B:
					num = (short)1337655302;
					num4 = (int)((IntPtr)num);
				}
				IL_493:
				return;
				IL_133:
				radioWide = (FeatureManager.GetFeature(2045)[0] as RadioWide);
				num = (short)615972877;
				num4 = (int)((IntPtr)num);
				goto IL_D8;
			}
			catch (Exception)
			{
			}
		}

		// Token: 0x06001065 RID: 4197 RVA: 0x0016E770 File Offset: 0x0016C970
		private void btnOK_Click(object A_0, RoutedEventArgs A_1)
		{
			int a_ = 13;
			switch (0)
			{
			case 0:
				goto IL_25;
			}
			short num2;
			for (;;)
			{
				IL_13:
				int num;
				switch (num)
				{
				case 0:
					if (this.txtModelNumber.Text == RptMgrErrorHandler.b("톏슑첓꺕ꢗꪙ겛", a_))
					{
						num2 = (short)1287847936;
						short num3 = num2;
						num2 = (short)179372033;
						num = (int)((IntPtr)num2);
						continue;
					}
					goto IL_157;
				case 1:
					goto IL_FB;
				case 2:
					goto IL_155;
				}
				goto IL_25;
			}
			IL_155:
			IL_157:
			base.DialogResult = new bool?(true);
			return;
			IL_25:
			num2 = (short)1790373679;
			short num4 = num2;
			num2 = (short)2045701935;
			switch ((num4 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
			{
				IL_FB:
				num2 = (short)2818049;
				if (num2 != 0)
				{
				}
				string text = this.txtFlashCode1.Text;
				this.txtFlashCode1.Text = text;
				num2 = (short)619642882;
				int num = (int)((IntPtr)num2);
				goto IL_13;
			}
			default:
			{
				num2 = (short)591331328;
				if (num2 != 0)
				{
				}
				this.DepotOptions.Clear();
				this.c();
				num2 = (short)482738176;
				int num = (int)((IntPtr)num2);
				goto IL_13;
			}
			}
		}

		// Token: 0x06001066 RID: 4198 RVA: 0x0016E8E0 File Offset: 0x0016CAE0
		private void txtFlashCode_TextChanged(object A_0, TextChangedEventArgs A_1)
		{
			short num = (short)1413021698;
			int num2 = (int)((IntPtr)num);
			for (;;)
			{
				byte b;
				switch (num2)
				{
				case 0:
					goto IL_1BD;
				case 1:
					goto IL_1FA;
				case 2:
					switch (0)
					{
					case 0:
						goto IL_4D;
					}
					continue;
				case 3:
					num = (short)909377544;
					num2 = (int)((IntPtr)num);
					continue;
				case 4:
					goto IL_120;
				case 5:
					if (this.txtFlashCode2 != null)
					{
						num = (short)2043740163;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_125;
				case 6:
				{
					num = (short)737388313;
					short num3 = num;
					num = (short)2116724505;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_238;
					default:
						num = (short)764608512;
						if (num != 0)
						{
						}
						num = (short)820248581;
						num2 = (int)((IntPtr)num);
						continue;
					}
					break;
				}
				case 7:
					this.txtFlashCodeCheckSum.Text = b.ToString();
					this.a = FlashcodeValidator.Validate(this.FlashCode);
					num = (short)474873860;
					num2 = (int)((IntPtr)num);
					continue;
				case 8:
					if (this.txtFlashCodeCheckSum == null)
					{
						num = (short)77332481;
						num2 = (int)((IntPtr)num);
						continue;
					}
					b = FlashcodeValidator.CalculateFlashCodeCheckDigit(this.txtFlashCode1.Text + this.txtFlashCode2.Text);
					num = (short)376897545;
					num2 = (int)((IntPtr)num);
					continue;
				case 9:
					goto IL_238;
				}
				IL_4D:
				num = (short)1143078912;
				short num4 = num;
				if (this.txtFlashCode1 != null)
				{
					num = (short)472449030;
					num2 = (int)((IntPtr)num);
					continue;
				}
				goto IL_125;
				IL_238:
				if (b != 255)
				{
					num = (short)1832189959;
					num2 = (int)((IntPtr)num);
				}
				else
				{
					this.txtFlashCodeCheckSum.Text = ' '.ToString();
					this.a = false;
					num = (short)312147968;
					num2 = (int)((IntPtr)num);
				}
			}
			IL_120:
			goto IL_25F;
			IL_125:
			num = (short)2002649089;
			if (num != 0)
			{
			}
			return;
			IL_1BD:
			goto IL_25F;
			IL_1FA:
			goto IL_125;
			IL_25F:
			this.a();
		}

		// Token: 0x06001067 RID: 4199 RVA: 0x0016EB54 File Offset: 0x0016CD54
		private void txtSerNum_TextChanged(object A_0, TextChangedEventArgs A_1)
		{
			short num = (short)866352442;
			short num2 = num;
			num = (short)1194425658;
			switch (num2 == num)
			{
			default:
			{
				num = (short)32833536;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1167523841;
			if (num != 0)
			{
			}
			num = (short)1723006976;
			if (num != 0)
			{
			}
			string s = this.txtSerNum.Text.ToString().Trim();
			string serialNumber = Convert.ToBase64String(Encoding.ASCII.GetBytes(s));
			this.b = SerialNumberValidator.ValidateSerialNumber(serialNumber);
			this.a();
		}

		// Token: 0x17000555 RID: 1365
		// (get) Token: 0x06001068 RID: 4200 RVA: 0x0016EC34 File Offset: 0x0016CE34
		private Brush NormalBorder
		{
			get
			{
				short num = (short)326093819;
				short num2 = num;
				num = (short)1011141627;
				switch (num2 == num)
				{
				default:
				{
					num = (short)650706944;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1317797888;
				if (num != 0)
				{
				}
				num = (short)249233409;
				if (num != 0)
				{
				}
				return this.txtModelNumber.BorderBrush;
			}
		}

		// Token: 0x17000556 RID: 1366
		// (get) Token: 0x06001069 RID: 4201 RVA: 0x0016ECE8 File Offset: 0x0016CEE8
		// (set) Token: 0x0600106A RID: 4202 RVA: 0x0016ED94 File Offset: 0x0016CF94
		public List<string> DepotOptions
		{
			[CompilerGenerated]
			get
			{
				short num = (short)752534267;
				short num2 = num;
				num = (short)701612795;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2007040000;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1992622080;
				if (num != 0)
				{
				}
				num = (short)1264386049;
				if (num != 0)
				{
				}
				return this.f;
			}
			[CompilerGenerated]
			internal set
			{
				short num = (short)434104403;
				short num2 = num;
				num = (short)465954899;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1383661568;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1918042113;
				if (num != 0)
				{
				}
				num = (short)49152000;
				if (num != 0)
				{
				}
				this.f = value;
			}
		}

		// Token: 0x0600106B RID: 4203 RVA: 0x0016EE44 File Offset: 0x0016D044
		private void a()
		{
			short num = (short)281542657;
			int num2 = (int)((IntPtr)num);
			for (;;)
			{
				num = (short)1320026113;
				if (num != 0)
				{
				}
				Brush brush;
				Brush brush2;
				switch (num2)
				{
				case 0:
					goto IL_207;
				case 1:
					switch (0)
					{
					case 0:
						goto IL_71;
					}
					continue;
				case 2:
					brush = this.NormalBorder;
					goto IL_11B;
				case 3:
					brush = Brushes.Red;
					goto IL_11B;
				case 4:
					brush2 = this.NormalBorder;
					goto IL_1BE;
				case 5:
				{
					num = (short)1595015168;
					short num3 = num;
					num = (short)537788419;
					num2 = (int)((IntPtr)num);
					continue;
				}
				case 6:
					if (!this.b)
					{
						num = (short)152698887;
						num2 = (int)((IntPtr)num);
						continue;
					}
					num = (short)1221853188;
					num2 = (int)((IntPtr)num);
					continue;
				case 7:
					goto IL_155;
				case 8:
				{
					num = (short)1504008688;
					short num4 = num;
					num = (short)690772464;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_155;
					default:
						num = (short)950599680;
						if (num != 0)
						{
						}
						brush2 = Brushes.Red;
						goto IL_1BE;
					}
					break;
				}
				}
				IL_71:
				if (!this.a)
				{
					num = (short)341835781;
					num2 = (int)((IntPtr)num);
					continue;
				}
				num = (short)40894466;
				num2 = (int)((IntPtr)num);
				continue;
				IL_11B:
				Brush borderBrush = brush;
				num = (short)1178075142;
				num2 = (int)((IntPtr)num);
				continue;
				IL_155:
				num = (short)1199898632;
				num2 = (int)((IntPtr)num);
				continue;
				IL_1BE:
				Brush borderBrush2 = brush2;
				this.txtFlashCode1.BorderBrush = borderBrush;
				this.txtFlashCode2.BorderBrush = borderBrush;
				this.txtFlashCodeCheckSum.BorderBrush = borderBrush;
				this.txtSerNum.BorderBrush = borderBrush2;
				num = (short)1928003584;
				num2 = (int)((IntPtr)num);
			}
			IL_207:
			this.btnOK.IsEnabled = (this.a && this.b);
		}

		// Token: 0x0400086D RID: 2157
		private bool a = true;

		// Token: 0x0400086E RID: 2158
		private bool b = true;

		// Token: 0x0400086F RID: 2159
		private string c = "";

		// Token: 0x04000870 RID: 2160
		private UpgradeRadioData d = new UpgradeRadioData();

		// Token: 0x04000871 RID: 2161
		private PCIHandler e = new PCIHandler();

		// Token: 0x04000872 RID: 2162
		[CompilerGenerated]
		private List<string> f;
	}
}
