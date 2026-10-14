using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Net;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Markup;
using AcpUI.Common;
using SpecialFeatures.AcpReportManagerLib;

namespace SpecialFeatures.Programming.UI
{
	// Token: 0x02000091 RID: 145
	public class SPF_UI_IPAddressV4_Control : global::System.Windows.Controls.UserControl, global::System.Windows.Markup.IComponentConnector
	{
		// Token: 0x06000A98 RID: 2712 RVA: 0x00002CFD File Offset: 0x00000EFD
		public SPF_UI_IPAddressV4_Control()
		{
			this.InitializeComponent();
			base.Loaded += this.SPF_UI_IPAddressV4_Control_Loaded;
			this.d = false;
			global::AcpUI.Common.Utility.SetDirection(this);
		}

		// Token: 0x1700041E RID: 1054
		// (get) Token: 0x06000A99 RID: 2713 RVA: 0x000C4790 File Offset: 0x000C2990
		// (set) Token: 0x06000A9A RID: 2714 RVA: 0x000C4840 File Offset: 0x000C2A40
		public bool ReadOnly
		{
			get
			{
				short num = (short)172518908;
				short num2 = num;
				num = (short)930639356;
				switch (num2 == num)
				{
				}
				num = (short)1393754112;
				short num3 = num;
				num = (short)656211968;
				if (num != 0)
				{
				}
				num = (short)616562689;
				if (num != 0)
				{
				}
				return this.d;
			}
			set
			{
				short num = (short)1608213577;
				short num2 = num;
				num = (short)1959879753;
				switch (num2 == num)
				{
				}
				num = (short)263192576;
				short num3 = num;
				num = (short)1494876160;
				if (num != 0)
				{
				}
				num = (short)872218625;
				if (num != 0)
				{
				}
				this.d = value;
				this.ip1TextBox.IsEnabled = !this.d;
				this.ip2TextBox.IsEnabled = !this.d;
				this.ip3TextBox.IsEnabled = !this.d;
				this.ip4TextBox.IsEnabled = !this.d;
				this.portTextBox.IsEnabled = !this.d;
			}
		}

		// Token: 0x1700041F RID: 1055
		// (get) Token: 0x06000A9B RID: 2715 RVA: 0x000C4954 File Offset: 0x000C2B54
		// (set) Token: 0x06000A9C RID: 2716 RVA: 0x000C4A78 File Offset: 0x000C2C78
		internal string sIP_Address
		{
			get
			{
				int a_ = 13;
				short num = (short)1743305226;
				short num2 = num;
				num = (short)1325120010;
				switch (num2 == num)
				{
				}
				num = (short)1637089280;
				short num3 = num;
				num = (short)120979457;
				if (num != 0)
				{
				}
				num = (short)1124597760;
				if (num != 0)
				{
				}
				return string.Concat(new string[]
				{
					this.ip1TextBox.Text,
					global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("뺏", a_),
					this.ip2TextBox.Text,
					global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("뺏", a_),
					this.ip3TextBox.Text,
					global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("뺏", a_),
					this.ip4TextBox.Text
				});
			}
			set
			{
				short num = (short)896073729;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						goto IL_52;
					case 1:
						switch (0)
						{
						case 0:
							goto IL_31;
						}
						continue;
					case 2:
						return;
					}
					IL_31:
					if (!string.IsNullOrEmpty(value))
					{
						num = (short)352583680;
						num2 = (int)((global::System.IntPtr)num);
					}
					else
					{
						this.ip1TextBox.Text = "";
						this.ip2TextBox.Text = "";
						this.ip3TextBox.Text = "";
						this.ip4TextBox.Text = "";
						num = (short)1239416832;
						short num3 = num;
						num = (short)2111438849;
						if (num != 0)
						{
						}
						num = (short)1597099851;
						short num4 = num;
						num = (short)1085329227;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_52;
						default:
							num = (short)1994194944;
							if (num != 0)
							{
							}
							num = (short)409075714;
							num2 = (int)((global::System.IntPtr)num);
							break;
						}
					}
				}
				IL_52:
				try
				{
					switch (0)
					{
					case 0:
						goto IL_1B0;
					}
					byte[] addressBytes;
					for (;;)
					{
						IL_15A:
						switch (num2)
						{
						case 0:
							goto IL_4C1;
						case 1:
							num = (short)1016201221;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
							num = (short)1500184582;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 3:
							if ((int)addressBytes[0] <= this.ip4TextBox.Max)
							{
								num = (short)1283063817;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_4AA;
						case 4:
							num = (short)193986579;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 5:
							if ((int)addressBytes[0] <= this.ip3TextBox.Max)
							{
								num = (short)1694957572;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_4AA;
						case 6:
							if ((int)addressBytes[1] >= this.ip2TextBox.Min)
							{
								num = (short)121045000;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_4AA;
						case 7:
							num = (short)24379395;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 8:
							num = (short)729219088;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 9:
							this.ip1TextBox.Text = addressBytes[0].ToString();
							this.ip2TextBox.Text = addressBytes[1].ToString();
							this.ip3TextBox.Text = addressBytes[2].ToString();
							this.ip4TextBox.Text = addressBytes[3].ToString();
							num = (short)1456144397;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 10:
							if ((int)addressBytes[2] >= this.ip3TextBox.Min)
							{
								num = (short)549715969;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_4AA;
						case 11:
							if ((int)addressBytes[0] >= this.ip1TextBox.Min)
							{
								num = (short)587792396;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_4AA;
						case 12:
							num = (short)1872560143;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 13:
							goto IL_4AA;
						case 14:
							num = (short)1574174730;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 15:
							if ((int)addressBytes[0] <= this.ip1TextBox.Max)
							{
								num = (short)1117519874;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_4AA;
						case 16:
							if ((int)addressBytes[0] <= this.ip2TextBox.Max)
							{
								num = (short)806617102;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_4AA;
						case 17:
							num = (short)325582859;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 18:
							if (addressBytes.Length == 4)
							{
								num = (short)2084896785;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_4AA;
						case 19:
							if ((int)addressBytes[3] >= this.ip4TextBox.Min)
							{
								num = (short)534183943;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_4AA;
						}
						goto IL_1B0;
						IL_4AA:
						num = (short)1022033920;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_4C1:
					return;
					IL_1B0:
					addressBytes = global::System.Net.IPAddress.Parse(value).GetAddressBytes();
					num = (short)11337746;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_15A;
				}
				catch
				{
					this.ip1TextBox.Text = "";
					this.ip2TextBox.Text = "";
					this.ip3TextBox.Text = "";
					this.ip4TextBox.Text = "";
				}
			}
		}

		// Token: 0x06000A9D RID: 2717 RVA: 0x000C4FAC File Offset: 0x000C31AC
		private void SPF_UI_IPAddressV4_Control_Loaded(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			int a_ = 6;
			short num = (short)295108608;
			short num2 = num;
			num = (short)73805310;
			short num3 = num;
			num = (short)122695166;
			switch (num3 == num)
			{
			}
			num = (short)760676353;
			if (num != 0)
			{
			}
			num = (short)1691090944;
			if (num != 0)
			{
			}
			string text = this.ip1TextBox.Text;
			string text2 = this.portTextBox.Text;
			this.ip1TextBox.Text = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("뮈뺊뢌", a_);
			this.portTextBox.Text = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("번뺊뢌몎꒐", a_);
			this.ip1TextBox.Measure(new global::System.Windows.Size(1000.0, 1000.0));
			global::System.Windows.Size desiredSize = this.ip1TextBox.DesiredSize;
			this.ip1TextBox.MinWidth = desiredSize.Width;
			this.ip1TextBox.MinHeight = desiredSize.Height;
			this.ip2TextBox.MinWidth = desiredSize.Width;
			this.ip2TextBox.MinHeight = desiredSize.Height;
			this.ip3TextBox.MinWidth = desiredSize.Width;
			this.ip3TextBox.MinHeight = desiredSize.Height;
			this.ip4TextBox.MinWidth = desiredSize.Width;
			this.ip4TextBox.MinHeight = desiredSize.Height;
			this.ip1TextBox.Text = text;
			this.portTextBox.Measure(new global::System.Windows.Size(1000.0, 1000.0));
			desiredSize = this.portTextBox.DesiredSize;
			this.portTextBox.MinWidth = desiredSize.Width;
			this.portTextBox.MinHeight = desiredSize.Height;
			this.portTextBox.Text = text2;
			base.Loaded -= this.SPF_UI_IPAddressV4_Control_Loaded;
		}

		// Token: 0x06000A9E RID: 2718 RVA: 0x000C51E0 File Offset: 0x000C33E0
		protected void TestPropertyChanged(object sender, global::System.EventArgs e)
		{
			short num = (short)1732640768;
			short num2 = num;
			num = (short)180049121;
			short num3 = num;
			num = (short)760042721;
			switch (num3 == num)
			{
			}
			num = (short)217186305;
			if (num != 0)
			{
			}
			num = (short)996212736;
			if (num != 0)
			{
			}
		}

		// Token: 0x06000A9F RID: 2719 RVA: 0x000C5288 File Offset: 0x000C3488
		protected override void OnPropertyChanged(global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			short num = (short)825556996;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					if (e.Property != global::System.Windows.Controls.Control.FontStyleProperty)
					{
						num = (short)1771175943;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_207;
				case 1:
					goto IL_74;
				case 2:
					num = (short)2117533701;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
				{
					num = (short)1835859968;
					short num3 = num;
					num = (short)1246232584;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 4:
					switch (0)
					{
					case 0:
						goto IL_49;
					}
					continue;
				case 5:
				{
					if (e.Property == global::System.Windows.Controls.Control.FontSizeProperty)
					{
						goto IL_207;
					}
					num = (short)1492007359;
					short num4 = num;
					num = (short)1011497407;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_74;
					default:
						num = (short)1091829760;
						if (num != 0)
						{
						}
						num = (short)499712003;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 6:
					goto IL_205;
				case 7:
				{
					global::System.Windows.DependencyProperty property = e.Property;
					global::System.Windows.DependencyProperty fontWeightProperty = global::System.Windows.Controls.Control.FontWeightProperty;
					num = (short)2034827270;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 8:
					num = (short)796852225;
					if (num != 0)
					{
					}
					if (e.Property != global::System.Windows.Controls.Control.FontStretchProperty)
					{
						num = (short)1742733313;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_207;
				}
				IL_49:
				if (e.Property != global::System.Windows.Controls.Control.FontFamilyProperty)
				{
					num = (short)1126301698;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_74:
				num = (short)1690959872;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_205:
			IL_207:
			base.OnPropertyChanged(e);
		}

		// Token: 0x06000AA0 RID: 2720 RVA: 0x000C54A4 File Offset: 0x000C36A4
		private int a(global::System.Windows.Input.Key A_0)
		{
			switch (0)
			{
			case 0:
				goto IL_4C;
			}
			int num;
			short num2;
			int result;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					num2 = (short)1310064641;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
					switch (A_0)
					{
					case global::System.Windows.Input.Key.NumPad0:
						goto IL_15C;
					case global::System.Windows.Input.Key.NumPad1:
						goto IL_2D8;
					case global::System.Windows.Input.Key.NumPad2:
						goto IL_1F5;
					case global::System.Windows.Input.Key.NumPad3:
						goto IL_294;
					case global::System.Windows.Input.Key.NumPad4:
						goto IL_13E;
					case global::System.Windows.Input.Key.NumPad5:
						goto IL_1B6;
					case global::System.Windows.Input.Key.NumPad6:
						goto IL_AF;
					case global::System.Windows.Input.Key.NumPad7:
						goto IL_278;
					case global::System.Windows.Input.Key.NumPad8:
						goto IL_17B;
					case global::System.Windows.Input.Key.NumPad9:
						goto IL_1D5;
					default:
						num2 = (short)396492809;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				case 2:
					return result;
				case 3:
					return result;
				case 4:
					return result;
				case 5:
					return result;
				case 6:
					return result;
				case 7:
					return result;
				case 8:
					return result;
				case 9:
					num2 = (short)1399586821;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 10:
					switch (A_0)
					{
					case global::System.Windows.Input.Key.D0:
						goto IL_15C;
					case global::System.Windows.Input.Key.D1:
						goto IL_2D8;
					case global::System.Windows.Input.Key.D2:
						goto IL_1F5;
					case global::System.Windows.Input.Key.D3:
						goto IL_294;
					case global::System.Windows.Input.Key.D4:
						goto IL_13E;
					case global::System.Windows.Input.Key.D5:
						goto IL_1B6;
					case global::System.Windows.Input.Key.D6:
						goto IL_AF;
					case global::System.Windows.Input.Key.D7:
						goto IL_278;
					case global::System.Windows.Input.Key.D8:
						goto IL_17B;
					case global::System.Windows.Input.Key.D9:
						goto IL_1D5;
					default:
						num2 = (short)277348352;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				case 11:
					return result;
				case 12:
					return result;
				case 13:
					return result;
				case 14:
					return result;
				}
				goto IL_4C;
				IL_AF:
				num2 = (short)2146599123;
				short num3 = num2;
				num2 = (short)126976211;
				switch ((num3 == num2) ? 1 : 0)
				{
				case 0:
				case 2:
					IL_140:
					num2 = (short)1316487176;
					num = (int)((global::System.IntPtr)num2);
					continue;
				default:
					num2 = (short)367656961;
					if (num2 != 0)
					{
					}
					num2 = (short)2118975488;
					if (num2 != 0)
					{
					}
					result = 6;
					num2 = (short)1514668036;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				IL_13E:
				result = 4;
				goto IL_140;
				IL_15C:
				result = 0;
				num2 = (short)1930756099;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_17B:
				result = 8;
				num2 = (short)1749876749;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_1B6:
				result = 5;
				num2 = (short)168493070;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_1D5:
				result = 9;
				num2 = (short)1489305611;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_1F5:
				result = 2;
				num2 = (short)1953693703;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_278:
				result = 7;
				num2 = (short)1875247106;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_294:
				num2 = (short)1964900352;
				short num4 = num2;
				result = 3;
				num2 = (short)222167046;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_2D8:
				result = 1;
				num2 = (short)1049624588;
				num = (int)((global::System.IntPtr)num2);
			}
			return result;
			IL_4C:
			result = -1;
			num2 = (short)103022602;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000AA1 RID: 2721 RVA: 0x000C57A8 File Offset: 0x000C39A8
		private void ipAddressStackPanel_PreviewKeyDown(object A_0, global::System.Windows.Input.KeyEventArgs A_1)
		{
			short num = (short)54526006;
			int num2 = (int)((global::System.IntPtr)num);
			global::System.Windows.Controls.TextBox textBox;
			int value;
			for (;;)
			{
				switch (num2)
				{
				case 0:
					if (this.b == this.portTextBox)
					{
						num = (short)1953431581;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1836318785;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					num = (short)1823735859;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					goto IL_232;
				case 3:
					if (this.b != this.portTextBox)
					{
						num = (short)383975472;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_19E;
				case 4:
					num = (short)65667115;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
					if (!A_1.KeyboardDevice.IsKeyDown(global::System.Windows.Input.Key.LeftShift))
					{
						num = (short)1512374289;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 6:
					if (A_1.Key != global::System.Windows.Input.Key.Left)
					{
						num = (short)182976520;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 7:
					goto IL_4B6;
				case 8:
					A_1.Handled = true;
					num = (short)886636588;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 9:
					if (A_1.Key == global::System.Windows.Input.Key.Down)
					{
						num = (short)704315442;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1056309309;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 10:
					if (!A_1.KeyboardDevice.IsKeyDown(global::System.Windows.Input.Key.RightShift))
					{
						num = (short)1638137880;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 11:
					num = (short)2012545081;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 12:
					goto IL_969;
				case 13:
					if (A_1.Key == global::System.Windows.Input.Key.Oem1)
					{
						num = (short)36765711;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)102170654;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 14:
					if (A_1.Key != global::System.Windows.Input.Key.Back)
					{
						num = (short)887226391;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 15:
					num = (short)1448476707;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 16:
					if (A_1.Key == global::System.Windows.Input.Key.Tab)
					{
						num = (short)1878917187;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1210974248;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 17:
					num = (short)1457389586;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 18:
					if (this.c != null)
					{
						num = (short)1636302860;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 19:
					if (!A_1.KeyboardDevice.IsKeyDown(global::System.Windows.Input.Key.LeftCtrl))
					{
						num = (short)226951179;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_790;
				case 20:
					goto IL_9A1;
				case 21:
					if (A_1.Key >= global::System.Windows.Input.Key.NumPad0)
					{
						num = (short)750780478;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_5F6;
				case 22:
					if (this.c != this.portTextBox)
					{
						num = (short)1989279770;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_74C;
				case 23:
					num = (short)1871970368;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 24:
					num = (short)1910112261;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 25:
					if (textBox.Text.Length == 0)
					{
						num = (short)582746153;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 26:
					num = (short)1684209665;
					if (num != 0)
					{
					}
					this.c.SelectAll();
					this.c.Focus();
					num = (short)455213114;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 27:
				{
					num = (short)1675113608;
					short num3 = num;
					num = (short)1185690760;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_21B;
					default:
						num = (short)1890451456;
						if (num != 0)
						{
						}
						num = (short)309461058;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 28:
					if (A_1.Key <= global::System.Windows.Input.Key.NumPad9)
					{
						num = (short)1456209975;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_5F6;
				case 29:
					num = (short)683474980;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 30:
					if (A_1.Key != global::System.Windows.Input.Key.C)
					{
						num = (short)1924136961;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_9A1;
				case 31:
					goto IL_402;
				case 32:
					num = (short)931004472;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 33:
					if (this.c != null)
					{
						num = (short)1173159981;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_2B8;
				case 34:
					if (A_1.Key != global::System.Windows.Input.Key.Up)
					{
						num = (short)50462766;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_306;
				case 35:
					if (this.c != null)
					{
						num = (short)1366163483;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 36:
					if (this.b.Text.Length >= 6)
					{
						goto IL_21B;
					}
					return;
				case 37:
					num = (short)347144217;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 38:
					num = (short)1055129603;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 39:
					num = (short)1985740814;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 40:
					if (A_1.Key == global::System.Windows.Input.Key.OemPeriod)
					{
						num = (short)632881190;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)888537101;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 41:
					goto IL_5E9;
				case 42:
					goto IL_8AF;
				case 43:
					if (A_1.Key >= global::System.Windows.Input.Key.D0)
					{
						num = (short)325713952;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_8AF;
				case 44:
					goto IL_32D;
				case 45:
					num = (short)568655894;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 46:
					num = (short)1358430217;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 47:
					if (A_1.Key == global::System.Windows.Input.Key.V)
					{
						num = (short)404684820;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1557856290;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 48:
					num = (short)513802273;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 49:
					if (this.c != null)
					{
						num = (short)14549029;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 50:
					goto IL_B5F;
				case 51:
					if (A_1.Key != global::System.Windows.Input.Key.X)
					{
						num = (short)1455358015;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_9A1;
				case 52:
					if (this.b.SelectedText.Length > 0)
					{
						num = (short)163053599;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					textBox = this.c;
					num = (short)1482227761;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 53:
					A_1.Handled = true;
					num = (short)278134836;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 54:
					switch (0)
					{
					case 0:
						goto IL_135;
					}
					continue;
				case 55:
					goto IL_9E7;
				case 56:
					if (A_1.Key > global::System.Windows.Input.Key.D9)
					{
						num = (short)1346764842;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_9E7;
				case 57:
					if (A_1.KeyboardDevice.IsKeyDown(global::System.Windows.Input.Key.RightCtrl))
					{
						num = (short)664338439;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_5EE;
				case 58:
					goto IL_99C;
				case 59:
				{
					num = (short)2065629184;
					short num4 = num;
					num = (short)2037645318;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 60:
					goto IL_55F;
				case 61:
					if (A_1.Key != global::System.Windows.Input.Key.Delete)
					{
						num = (short)1670905895;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 62:
					num = (short)744751132;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 63:
					num = (short)723779631;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 64:
					if (A_1.Key != global::System.Windows.Input.Key.Right)
					{
						num = (short)1064632379;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 65:
					if (this.b.Text.Length >= 3)
					{
						num = (short)89456693;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 66:
					if (this.c == this.portTextBox)
					{
						num = (short)2089156668;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 67:
					num = (short)455606282;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_135:
				if (this.a)
				{
					num = (short)119865348;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				return;
				IL_21B:
				num = (short)1957167106;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_5F6:
				num = (short)941490192;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_8AF:
				num = (short)1443561493;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_9A1:
				num = (short)1783234579;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_9E7:
				value = this.a(A_1.Key);
				num = (short)177274880;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_19E:
			A_1.Handled = true;
			return;
			IL_232:
			A_1.Handled = true;
			return;
			IL_2B8:
			A_1.Handled = true;
			return;
			IL_306:
			A_1.Handled = false;
			return;
			IL_32D:
			return;
			IL_402:
			A_1.Handled = false;
			return;
			IL_4B6:
			goto IL_790;
			IL_55F:
			this.c.SelectAll();
			this.c.Focus();
			A_1.Handled = true;
			return;
			IL_5E9:
			textBox.Text = global::System.Convert.ToString(value);
			textBox.Focus();
			textBox.CaretIndex = textBox.Text.Length;
			return;
			IL_5EE:
			A_1.Handled = true;
			return;
			IL_74C:
			A_1.Handled = true;
			return;
			IL_790:
			A_1.Handled = false;
			return;
			IL_969:
			this.c.SelectAll();
			this.c.Focus();
			A_1.Handled = true;
			return;
			IL_99C:
			goto IL_74C;
			IL_B5F:
			goto IL_306;
		}

		// Token: 0x06000AA2 RID: 2722 RVA: 0x000C631C File Offset: 0x000C451C
		private void ipAddressStackPanel_PreviewGotKeyboardFocus(object A_0, global::System.Windows.Input.KeyboardFocusChangedEventArgs A_1)
		{
			switch (0)
			{
			case 0:
				goto IL_7C;
			}
			int num;
			short num2;
			global::System.Windows.Controls.TextBox textBox;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					num2 = (short)1111752721;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
					goto IL_18A;
				case 2:
					if (textBox == this.ip1TextBox)
					{
						num2 = (short)1272119312;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)1703673860;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 3:
					if (textBox != this.ip4TextBox)
					{
						num2 = (short)1859780622;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_446;
				case 4:
					num2 = (short)1854865409;
					if (num2 != 0)
					{
					}
					if (textBox == this.ip2TextBox)
					{
						num2 = (short)1281163272;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)232783897;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 5:
					num2 = (short)2141913098;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 6:
				{
					if (textBox != null)
					{
						num2 = (short)490864640;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)630784000;
					short num3 = num2;
					this.a = false;
					this.c = null;
					num2 = (short)1313800210;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 7:
					if (textBox != this.ip1TextBox)
					{
						num2 = (short)1808072709;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_446;
				case 8:
					goto IL_3F8;
				case 9:
					num2 = (short)1020788739;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 10:
					if (textBox != this.ip2TextBox)
					{
						num2 = (short)313786387;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_446;
				case 11:
					num2 = (short)85065748;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 12:
					goto IL_20E;
				case 13:
					if (textBox != this.ip3TextBox)
					{
						num2 = (short)1323630601;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_446;
				case 14:
					num2 = (short)1324941333;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 15:
					num2 = (short)158072839;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 16:
					goto IL_490;
				case 17:
					if (textBox != this.b)
					{
						num2 = (short)1332477967;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 18:
					goto IL_2C6;
				case 19:
					num2 = (short)567672845;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 20:
					if (this.portTextBox.Visibility == global::System.Windows.Visibility.Visible)
					{
						goto IL_1F6;
					}
					goto IL_3FD;
				case 21:
					if (textBox == this.portTextBox)
					{
						num2 = (short)2134704152;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_213;
				case 22:
					if (textBox == this.portTextBox)
					{
						num2 = (short)1676804097;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 23:
				{
					num2 = (short)2094657316;
					short num4 = num2;
					num2 = (short)1297149732;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_1F6;
					default:
						goto IL_4CB;
					}
					break;
				}
				case 24:
					goto IL_446;
				case 25:
					if (textBox == this.ip3TextBox)
					{
						num2 = (short)119078935;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)2063204378;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 26:
					if (textBox == this.ip4TextBox)
					{
						num2 = (short)1586233355;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)1429733398;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_7C;
				IL_1F6:
				num2 = (short)1016987660;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_446:
				this.a = true;
				this.b = textBox;
				num2 = (short)202768386;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_18A:
			this.c = null;
			return;
			IL_20E:
			this.c = this.portTextBox;
			return;
			IL_213:
			this.a = false;
			this.c = null;
			return;
			IL_2C6:
			return;
			IL_3F8:
			this.c = this.ip3TextBox;
			return;
			IL_3FD:
			this.c = null;
			return;
			IL_490:
			this.c = this.ip2TextBox;
			return;
			IL_4CB:
			num2 = (short)1367474176;
			if (num2 != 0)
			{
			}
			this.c = this.ip4TextBox;
			return;
			IL_7C:
			textBox = (A_1.NewFocus as global::System.Windows.Controls.TextBox);
			num2 = (short)316866566;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000AA3 RID: 2723 RVA: 0x000C6818 File Offset: 0x000C4A18
		private void ipAddressStackPanel_TextChanged(object A_0, global::System.Windows.Controls.TextChangedEventArgs A_1)
		{
			switch (0)
			{
			case 0:
				goto IL_68;
			}
			int num;
			short num2;
			global::SpecialFeatures.Programming.UI.IPTextBox iptextBox;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					num2 = (short)1238630421;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
					if (iptextBox != null)
					{
						num2 = (short)1868169216;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 2:
					num2 = (short)815005704;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 3:
					goto IL_567;
				case 4:
					if (iptextBox.Text.Length > 0)
					{
						num2 = (short)1023868928;
						short num3 = num2;
						num2 = (short)331087886;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 5:
					if (iptextBox != this.ip2TextBox)
					{
						num2 = (short)1126236177;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_567;
				case 6:
					num2 = (short)1846149135;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 7:
					if (iptextBox != this.ip3TextBox)
					{
						num2 = (short)2056060947;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_567;
				case 8:
					if (iptextBox.Text != null)
					{
						num2 = (short)823459853;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 9:
					goto IL_22A;
				case 10:
					if (iptextBox.Text.Length > 0)
					{
						num2 = (short)883097616;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 11:
					num2 = (short)942014474;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 12:
					if (iptextBox == this.ip4TextBox)
					{
						num2 = (short)896794627;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)666435604;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 13:
					num2 = (short)590217220;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 14:
					num2 = (short)1509359617;
					if (num2 != 0)
					{
					}
					try
					{
						switch (0)
						{
						case 0:
							goto IL_42E;
						}
						int num4;
						for (;;)
						{
							IL_410:
							switch (num)
							{
							case 0:
								num2 = (short)410714115;
								num = (int)((global::System.IntPtr)num2);
								continue;
							case 1:
								goto IL_4C2;
							case 2:
								goto IL_46A;
							case 3:
								if (num4 > 65536)
								{
									num2 = (short)221904898;
									num = (int)((global::System.IntPtr)num2);
									continue;
								}
								goto IL_4C2;
							case 4:
								if (num4 != 0)
								{
									num2 = (short)739377152;
									num = (int)((global::System.IntPtr)num2);
									continue;
								}
								goto IL_46A;
							case 5:
								goto IL_4D9;
							}
							goto IL_42E;
							IL_46A:
							A_1.Handled = true;
							num2 = (short)2075721729;
							num = (int)((global::System.IntPtr)num2);
							continue;
							IL_4C2:
							num2 = (short)1574174725;
							num = (int)((global::System.IntPtr)num2);
						}
						IL_4D9:
						return;
						IL_42E:
						num4 = global::System.Convert.ToInt32(iptextBox.Text);
						num2 = (short)1095827460;
						num = (int)((global::System.IntPtr)num2);
						goto IL_410;
					}
					catch
					{
						A_1.Handled = true;
						return;
					}
					goto IL_4EB;
				case 15:
					if (iptextBox != this.ip1TextBox)
					{
						num2 = (short)1478230025;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_567;
				case 16:
					try
					{
						switch (0)
						{
						case 0:
							goto IL_110;
						}
						for (;;)
						{
							IL_F2:
							switch (num)
							{
							case 0:
								num2 = (short)206962689;
								num = (int)((global::System.IntPtr)num2);
								continue;
							case 1:
							{
								int num5;
								if (num5 >= iptextBox.Max)
								{
									num2 = (short)477036547;
									num = (int)((global::System.IntPtr)num2);
									continue;
								}
								goto IL_1FD;
							}
							case 2:
								goto IL_1FD;
							case 3:
								A_1.Handled = true;
								num2 = (short)1922170882;
								num = (int)((global::System.IntPtr)num2);
								continue;
							case 4:
							{
								int num5;
								if (num5 >= iptextBox.Min)
								{
									num2 = (short)266928128;
									num = (int)((global::System.IntPtr)num2);
									continue;
								}
								goto IL_1FD;
							}
							case 5:
								goto IL_214;
							}
							break;
							IL_1FD:
							num2 = (short)1322516485;
							num = (int)((global::System.IntPtr)num2);
						}
						IL_110:
						num2 = (short)1014203121;
						short num6 = num2;
						num2 = (short)1144292081;
						switch ((num6 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							IL_214:
							return;
						default:
						{
							num2 = (short)727056384;
							if (num2 != 0)
							{
							}
							int num5 = global::System.Convert.ToInt32(iptextBox.Text);
							num2 = (short)604766212;
							num = (int)((global::System.IntPtr)num2);
							goto IL_F2;
						}
						}
					}
					catch
					{
						iptextBox.Text = "";
						return;
					}
					goto IL_22A;
				case 17:
					num2 = (short)82640903;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 18:
					if (iptextBox.Text != null)
					{
						num2 = (short)1844510731;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 19:
					goto IL_4EB;
				case 20:
					if (iptextBox == this.portTextBox)
					{
						num2 = (short)1539571714;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 21:
					if (iptextBox.IsFocused)
					{
						num2 = (short)1637810182;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				}
				goto IL_68;
				IL_22A:
				num2 = (short)180092933;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_4EB:
				num2 = (short)2049245196;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_567:
				num2 = (short)123535378;
				num = (int)((global::System.IntPtr)num2);
			}
			return;
			IL_68:
			iptextBox = (A_0 as global::SpecialFeatures.Programming.UI.IPTextBox);
			num2 = (short)586547201;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x17000420 RID: 1056
		// (get) Token: 0x06000AA4 RID: 2724 RVA: 0x000C6E00 File Offset: 0x000C5000
		public global::System.Net.IPAddress IP_Address
		{
			get
			{
				short num;
				global::System.Net.IPAddress result;
				try
				{
					num = (short)978953666;
					short num2 = num;
					num = (short)1354868162;
					switch (num2 == num)
					{
					}
					num = (short)709492737;
					if (num != 0)
					{
					}
					num = (short)830341120;
					if (num != 0)
					{
					}
					result = global::System.Net.IPAddress.Parse(this.sIP_Address);
				}
				catch
				{
					result = null;
				}
				num = (short)747634688;
				short num3 = num;
				return result;
			}
		}

		// Token: 0x17000421 RID: 1057
		// (get) Token: 0x06000AA5 RID: 2725 RVA: 0x000C6ED0 File Offset: 0x000C50D0
		public int Port
		{
			get
			{
				short num;
				int result;
				try
				{
					num = (short)830141430;
					short num2 = num;
					num = (short)496104438;
					switch (num2 == num)
					{
					}
					num = (short)160694272;
					if (num != 0)
					{
					}
					result = global::System.Convert.ToInt32(this.portTextBox.Text);
				}
				catch
				{
					result = -1;
				}
				num = (short)341573632;
				short num3 = num;
				num = (short)1814429697;
				if (num != 0)
				{
				}
				return result;
			}
		}

		// Token: 0x06000AA6 RID: 2726 RVA: 0x000C6FA4 File Offset: 0x000C51A4
		private void ipAddressStackPanel_PreviewLostKeyboardFocus(object A_0, global::System.Windows.Input.KeyboardFocusChangedEventArgs A_1)
		{
			short num = (short)1520100983;
			short num2 = num;
			num = (short)1319954039;
			int num3;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_AC:
				num = (short)2136735749;
				num3 = (int)((global::System.IntPtr)num);
				break;
			case 1:
				goto IL_5D;
			default:
			{
				num = (short)1202126848;
				short num4 = num;
				goto IL_5D;
			}
			}
			global::System.Windows.Controls.TextBox textBox;
			for (;;)
			{
				IL_7E:
				switch (num3)
				{
				case 0:
					goto IL_FE;
				case 1:
					num = (short)2012217347;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					textBox.Select(0, 0);
					num = (short)1117650944;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					if (textBox.Text.Length > 0)
					{
						num = (short)1973485574;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 4:
					if (textBox.SelectedText.Length > 0)
					{
						num = (short)573243394;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 5:
					if (textBox != null)
					{
						num = (short)256507905;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 6:
					num = (short)1994981380;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_A0;
			}
			IL_FE:
			num = (short)330760193;
			if (num != 0)
			{
			}
			return;
			IL_5D:
			num = (short)1941372928;
			if (num != 0)
			{
			}
			switch (0)
			{
			case 0:
				goto IL_A0;
			}
			goto IL_7E;
			IL_A0:
			textBox = (A_1.OldFocus as global::System.Windows.Controls.TextBox);
			goto IL_AC;
		}

		// Token: 0x06000AA7 RID: 2727 RVA: 0x000C715C File Offset: 0x000C535C
		private void ipAddressStackPanel_PreviewTextInput(object A_0, global::System.Windows.Input.TextCompositionEventArgs A_1)
		{
			short num = (short)1925480485;
			short num2 = num;
			num = (short)1941340197;
			int num3;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_AE:
				num = (short)1933049861;
				num3 = (int)((global::System.IntPtr)num);
				break;
			case 1:
				goto IL_5F;
			default:
			{
				num = (short)444071936;
				short num4 = num;
				goto IL_5F;
			}
			}
			global::SpecialFeatures.Programming.UI.IPTextBox iptextBox2;
			for (;;)
			{
				IL_7F:
				switch (num3)
				{
				case 0:
					return;
				case 1:
					num = (short)1465581571;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
				{
					global::SpecialFeatures.Programming.UI.IPTextBox iptextBox = this.ip4TextBox;
					num = (short)1181548544;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 3:
					num = (short)1490354177;
					if (num != 0)
					{
					}
					if (iptextBox2 != this.ip2TextBox)
					{
						num = (short)653787142;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 4:
					if (iptextBox2 != this.ip3TextBox)
					{
						num = (short)1921646594;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 5:
					if (iptextBox2 != this.ip1TextBox)
					{
						num = (short)1848901633;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 6:
					num = (short)813498372;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_A1;
			}
			return;
			IL_5F:
			num = (short)172228608;
			if (num != 0)
			{
			}
			switch (0)
			{
			case 0:
				goto IL_A1;
			}
			goto IL_7F;
			IL_A1:
			iptextBox2 = (A_0 as global::SpecialFeatures.Programming.UI.IPTextBox);
			new global::System.Text.StringBuilder();
			goto IL_AE;
		}

		// Token: 0x06000AA8 RID: 2728 RVA: 0x000C7318 File Offset: 0x000C5518
		[global::System.Diagnostics.DebuggerNonUserCode]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "5.0.10.0")]
		public void InitializeComponent()
		{
			int a_ = 10;
			if (this.e)
			{
				short num;
				for (;;)
				{
					num = (short)1106378170;
					short num2 = num;
					num = (short)1196490170;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						goto IL_4D;
					}
				}
				IL_4D:
				num = (short)974651392;
				if (num != 0)
				{
				}
				num = (short)1844051968;
				short num3 = num;
				num = (short)132513793;
				if (num != 0)
				{
				}
				return;
			}
			this.e = true;
			global::System.Uri resourceLocator = new global::System.Uri(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("ꊌ\udc8eﺖ\udb9c爵삠힢키햦첨\ud8aa隬첮\udeb0\udeb2어\ud8b6ힸ\udeba펼쮾돂럄꣆껈맊곌ꋎ볐뫒믔냖껚드鋠鏢菤룦鳨苪달蛮臰鋲釴鏶诸黺軼賾眀㜂⬄缆栈昊愌", a_), global::System.UriKind.Relative);
			global::System.Windows.Application.LoadComponent(this, resourceLocator);
		}

		// Token: 0x06000AA9 RID: 2729 RVA: 0x000C73FC File Offset: 0x000C55FC
		[global::System.Diagnostics.DebuggerNonUserCode]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "5.0.10.0")]
		internal global::System.Delegate _CreateDelegate(global::System.Type delegateType, string handler)
		{
			short num = (short)1148587015;
			short num2 = num;
			num = (short)1696599047;
			switch (num2 == num)
			{
			default:
			{
				num = (short)334954496;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)698089473;
			if (num != 0)
			{
			}
			num = (short)1926168576;
			if (num != 0)
			{
			}
			return global::System.Delegate.CreateDelegate(delegateType, this, handler);
		}

		// Token: 0x06000AAA RID: 2730 RVA: 0x000C74B0 File Offset: 0x000C56B0
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "5.0.10.0")]
		[global::System.Diagnostics.DebuggerNonUserCode]
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		void global::System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
		{
			short num = (short)936247296;
			short num2 = num;
			num = (short)1230372865;
			int num3 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num3)
				{
				case 0:
					num = (short)281673730;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					switch (0)
					{
					case 0:
						goto IL_5B;
					}
					continue;
				case 2:
					goto IL_13B;
				}
				IL_5B:
				switch (connectionId)
				{
				case 1:
					goto IL_AE;
				case 2:
					goto IL_1BF;
				case 3:
					goto IL_A1;
				case 4:
					goto IL_94;
				case 5:
					goto IL_18A;
				case 6:
					goto IL_117;
				default:
					num = (short)2007367680;
					num3 = (int)((global::System.IntPtr)num);
					break;
				}
			}
			IL_94:
			this.ip3TextBox = (global::SpecialFeatures.Programming.UI.IPTextBox)target;
			return;
			IL_A1:
			this.ip2TextBox = (global::SpecialFeatures.Programming.UI.IPTextBox)target;
			return;
			IL_AE:
			this.ipAddressStackPanel = (global::System.Windows.Controls.StackPanel)target;
			this.ipAddressStackPanel.PreviewKeyDown += this.ipAddressStackPanel_PreviewKeyDown;
			this.ipAddressStackPanel.PreviewGotKeyboardFocus += this.ipAddressStackPanel_PreviewGotKeyboardFocus;
			this.ipAddressStackPanel.PreviewLostKeyboardFocus += this.ipAddressStackPanel_PreviewLostKeyboardFocus;
			this.ipAddressStackPanel.PreviewTextInput += this.ipAddressStackPanel_PreviewTextInput;
			return;
			IL_117:
			this.portTextBox = (global::SpecialFeatures.Programming.UI.IPTextBox)target;
			return;
			IL_13B:
			num = (short)186814448;
			short num4 = num;
			num = (short)483037168;
			switch ((num4 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				goto IL_A1;
			default:
				num = (short)229507072;
				if (num != 0)
				{
				}
				this.e = true;
				return;
			}
			IL_18A:
			num = (short)1151467521;
			if (num != 0)
			{
			}
			this.ip4TextBox = (global::SpecialFeatures.Programming.UI.IPTextBox)target;
			return;
			IL_1BF:
			this.ip1TextBox = (global::SpecialFeatures.Programming.UI.IPTextBox)target;
		}

		// Token: 0x0400045C RID: 1116
		private bool a;

		// Token: 0x0400045D RID: 1117
		private global::System.Windows.Controls.TextBox b;

		// Token: 0x0400045E RID: 1118
		private global::System.Windows.Controls.TextBox c;

		// Token: 0x0400045F RID: 1119
		private bool d;

		// Token: 0x04000460 RID: 1120
		internal global::System.Windows.Controls.StackPanel ipAddressStackPanel;

		// Token: 0x04000461 RID: 1121
		internal global::SpecialFeatures.Programming.UI.IPTextBox ip1TextBox;

		// Token: 0x04000462 RID: 1122
		internal global::SpecialFeatures.Programming.UI.IPTextBox ip2TextBox;

		// Token: 0x04000463 RID: 1123
		internal global::SpecialFeatures.Programming.UI.IPTextBox ip3TextBox;

		// Token: 0x04000464 RID: 1124
		internal global::SpecialFeatures.Programming.UI.IPTextBox ip4TextBox;

		// Token: 0x04000465 RID: 1125
		internal global::SpecialFeatures.Programming.UI.IPTextBox portTextBox;

		// Token: 0x04000466 RID: 1126
		private bool e;
	}
}
