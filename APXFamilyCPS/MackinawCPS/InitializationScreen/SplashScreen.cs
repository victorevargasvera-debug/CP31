using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Resources;
using System.Windows.Forms;
using Common;
using CommonResources;
using PreEmptive.SoS.Runtime;

namespace MackinawCPS.InitializationScreen
{
	// Token: 0x0200007A RID: 122
	public partial class SplashScreen : Form
	{
		// Token: 0x0600053B RID: 1339 RVA: 0x000E717C File Offset: 0x000E537C
		public SplashScreen() : this(new TimeSpan(0, 0, 5), new TimeSpan(0, 0, 10), 10, "")
		{
		}

		// Token: 0x0600053C RID: 1340 RVA: 0x000E71A8 File Offset: 0x000E53A8
		public SplashScreen(TimeSpan min, TimeSpan max, int radius, string productVersionText)
		{
			int num = radius * 2;
			this._Min = min;
			this._Max = max;
			this.closeRequested = false;
			this.InitializeComponent();
			base.Opacity = 0.99;
			this.timer1.Tick += this.timer1_Tick;
			if (!this._Min.Equals(TimeSpan.Zero))
			{
				this.timer1.Interval = (int)min.TotalMilliseconds;
				goto IL_2CD;
			}
			IL_2B6:
			if (!this._Max.Equals(TimeSpan.Zero))
			{
				this._Min = this._Max;
				this.timer1.Interval = (int)this._Min.TotalMilliseconds;
			}
			IL_2CD:
			base.Load += this.SplashScreen_Load;
			this.panel1.MouseClick += this.SplashScreen_MouseClick;
			using (IEnumerator enumerator = this.panel1.Controls.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					object obj = enumerator.Current;
					((Control)obj).MouseClick += this.SplashScreen_MouseClick;
				}
				goto IL_174;
			}
			goto IL_2B6;
			for (;;)
			{
				IL_174:
				base.SuspendLayout();
				if (radius <= 0)
				{
					break;
				}
				int x = base.Size.Width - radius;
				int y = base.Size.Height - radius;
				Point location = new Point(0, 0);
				Point location2 = new Point(base.Width - 2 * radius, 0);
				Point location3 = new Point(0, base.Height - 2 * radius);
				Point location4 = new Point(base.Width - 2 * radius, base.Height - 2 * radius);
				GraphicsPath graphicsPath = null;
				try
				{
					graphicsPath = new GraphicsPath();
					graphicsPath.StartFigure();
					graphicsPath.AddArc(new Rectangle(location, new Size(num, num)), 180f, 90f);
					graphicsPath.AddLine(new Point(radius, 0), new Point(x, 0));
					graphicsPath.AddArc(new Rectangle(location2, new Size(num, num)), 270f, 90f);
					graphicsPath.AddLine(new Point(base.Width, radius), new Point(base.Width, y));
					graphicsPath.AddArc(new Rectangle(location4, new Size(num, num)), 0f, 90f);
					graphicsPath.AddLine(new Point(radius, base.Height), new Point(x, base.Height));
					graphicsPath.AddArc(new Rectangle(location3, new Size(num, num)), 90f, 90f);
					graphicsPath.CloseFigure();
					Region region = new Region(graphicsPath);
					base.Region = region;
					break;
				}
				finally
				{
					if (graphicsPath != null)
					{
						graphicsPath.Dispose();
					}
				}
			}
			this.versionLabel.Text = "";
			if (!string.IsNullOrEmpty(productVersionText))
			{
				this.versionLabel.Text = productVersionText;
			}
			base.ResumeLayout(true);
		}

		// Token: 0x0600053D RID: 1341 RVA: 0x000E74E4 File Offset: 0x000E56E4
		public SplashScreen(TimeSpan min, TimeSpan max, int radius, string productVersionText, string Year)
		{
			int a_ = 19;
			this..ctor(min, max, radius, productVersionText);
			this.label2.Text = FixedLengthStream.b("嫲헴", a_) + Year + FixedLengthStream.b("폲룴룶그듺꿼냾䴀䈂┄吆䘈䜊堌嬎堐尒嬔䐖㔘㬚吜儞戠ഢԤܦ礨礪戬笮琰瀲愴父紸ᬺ缼显慀ᙂ歄ᑆ杈歊ౌŎᕐ獒᱔ᥖ൘Ṛཛྷᅞ⁠㝢Ɽ⡦❨⩪Ⅼ佮㉰㱲╴⹶⭸㉺㩼㝾햀ꎂ즄욆\ude88\ud88a", a_);
		}

		// Token: 0x0600053E RID: 1342 RVA: 0x000E7534 File Offset: 0x000E5734
		private bool CheckCloseWindowRequest()
		{
			switch (0)
			{
			case 0:
				goto IL_24;
			}
			int num;
			short num2;
			bool result;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					if (this.closeRequested)
					{
						num2 = (short)798621699;
						num = (int)((IntPtr)num2);
						continue;
					}
					return result;
				case 1:
					result = true;
					num2 = (short)1843003396;
					num = (int)((IntPtr)num2);
					continue;
				case 2:
				{
					if (this.state != SplashWindowStates.SHOWN_MINIMUM_TIME_HIT)
					{
						return result;
					}
					num2 = (short)1698168832;
					short num3 = num2;
					num2 = (short)51371569;
					short num4 = num2;
					num2 = (short)368434737;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_5A;
					default:
						num2 = (short)288882688;
						if (num2 != 0)
						{
						}
						num2 = (short)1711931393;
						num = (int)((IntPtr)num2);
						continue;
					}
					break;
				}
				case 3:
					goto IL_5A;
				case 4:
					goto IL_72;
				}
				goto IL_24;
				IL_5A:
				num2 = (short)1457192962;
				num = (int)((IntPtr)num2);
			}
			IL_72:
			num2 = (short)1857617921;
			if (num2 != 0)
			{
			}
			return result;
			IL_24:
			result = false;
			num2 = (short)1426653184;
			num = (int)((IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x0600053F RID: 1343 RVA: 0x000E7694 File Offset: 0x000E5894
		internal void CloseWindow(bool forceClose)
		{
			short num = (short)199884801;
			int num2 = (int)((IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_100;
				case 1:
					goto IL_14;
				case 2:
				{
					base.Invoke(new SplashScreen.BoolDelegate(this.HandleAppCloseWindowRequest), new object[]
					{
						forceClose
					});
					num = (short)273848363;
					short num3 = num;
					num = (short)1004181547;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_14;
					default:
					{
						num = (short)2110455808;
						short num4 = num;
						num = (short)1814364160;
						if (num != 0)
						{
						}
						num = (short)1025900544;
						num2 = (int)((IntPtr)num);
						continue;
					}
					}
					break;
				}
				}
				goto IL_30;
				IL_14:
				switch (0)
				{
				case 0:
					IL_30:
					if (!base.InvokeRequired)
					{
						return;
					}
					num = (short)1067122690;
					num2 = (int)((IntPtr)num);
					break;
				}
			}
			IL_100:
			num = (short)416677889;
			if (num != 0)
			{
			}
		}

		// Token: 0x06000540 RID: 1344 RVA: 0x000E77CC File Offset: 0x000E59CC
		private void HandleAppCloseWindowRequest(bool forceClose)
		{
			switch (0)
			{
			case 0:
				goto IL_A7;
			}
			short num;
			int num4;
			for (;;)
			{
				IL_0A:
				num = (short)218894047;
				short num2 = num;
				num = (short)289607391;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					return;
				case 1:
					break;
				default:
				{
					num = (short)1907097600;
					short num3 = num;
					break;
				}
				}
				num = (short)1264189440;
				if (num != 0)
				{
				}
				switch (num4)
				{
				case 0:
					if (forceClose)
					{
						num = (short)1930035204;
						num4 = (int)((IntPtr)num);
						continue;
					}
					return;
				case 1:
					if (this.state == SplashWindowStates.SHOWN)
					{
						num = (short)352321538;
						num4 = (int)((IntPtr)num);
						continue;
					}
					num = (short)1818165256;
					num4 = (int)((IntPtr)num);
					continue;
				case 2:
					num = (short)186843136;
					num4 = (int)((IntPtr)num);
					continue;
				case 3:
					goto IL_18F;
				case 4:
					goto IL_1C3;
				case 5:
					return;
				case 6:
					if (this.state == SplashWindowStates.WAIT_FOR_ACTIVATE)
					{
						num = (short)549322759;
						num4 = (int)((IntPtr)num);
						continue;
					}
					return;
				case 7:
					num = (short)1083179009;
					if (num != 0)
					{
					}
					this.state = SplashWindowStates.CLOSED;
					num = (short)1972371461;
					num4 = (int)((IntPtr)num);
					continue;
				case 8:
					if (this.state == SplashWindowStates.SHOWN_MINIMUM_TIME_HIT)
					{
						num = (short)575668227;
						num4 = (int)((IntPtr)num);
						continue;
					}
					num = (short)1480327174;
					num4 = (int)((IntPtr)num);
					continue;
				}
				goto IL_A7;
			}
			IL_18F:
			this.timer1.Stop();
			this.setupFadeOut();
			return;
			IL_1C3:
			this.timer1.Stop();
			this.setupFadeOut();
			return;
			IL_A7:
			this.closeRequested = true;
			num = (short)1519779841;
			num4 = (int)((IntPtr)num);
			goto IL_0A;
		}

		// Token: 0x06000541 RID: 1345 RVA: 0x000E79E4 File Offset: 0x000E5BE4
		private void CloseAndCleanupWindow()
		{
			short num = (short)836960256;
			short num2 = num;
			num = (short)1972731170;
			short num3 = num;
			num = (short)1964145954;
			switch (num3 == num)
			{
			}
			num = (short)1759051777;
			if (num != 0)
			{
			}
			num = (short)806551552;
			if (num != 0)
			{
			}
			this.timer1.Stop();
			this.timer1.Dispose();
			this.state = SplashWindowStates.CLOSED;
			base.Close();
		}

		// Token: 0x06000542 RID: 1346 RVA: 0x000E7AB0 File Offset: 0x000E5CB0
		protected override void OnClosing(CancelEventArgs e)
		{
			short num = (short)1576665088;
			short num2 = num;
			num = (short)675151873;
			if (num != 0)
			{
			}
			num = (short)506463078;
			short num3 = num;
			num = (short)1072104294;
			switch (num3 == num)
			{
			}
			num = (short)2022047744;
			if (num != 0)
			{
			}
			base.OnClosing(e);
		}

		// Token: 0x06000543 RID: 1347 RVA: 0x000E7B60 File Offset: 0x000E5D60
		private void timer1_Tick(object sender, EventArgs e)
		{
			switch (0)
			{
			case 0:
				goto IL_50;
			}
			int num;
			short num2;
			TimeSpan timeSpan;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					if (this.HandleFadeOutTick())
					{
						num2 = (short)1698365445;
						num = (int)((IntPtr)num2);
						continue;
					}
					return;
				case 1:
					if (!this.CheckCloseWindowRequest())
					{
						num2 = (short)148176898;
						num = (int)((IntPtr)num2);
						continue;
					}
					goto IL_447;
				case 2:
					timeSpan = TimeSpan.Zero;
					num2 = (short)527826956;
					num = (int)((IntPtr)num2);
					continue;
				case 3:
					goto IL_FC;
				case 4:
					if (this.state == SplashWindowStates.SHOWN)
					{
						num2 = (short)1069481990;
						num = (int)((IntPtr)num2);
						continue;
					}
					num2 = (short)733609991;
					num = (int)((IntPtr)num2);
					continue;
				case 5:
				{
					num2 = (short)166002688;
					short num3 = num2;
					this.timer1.Start();
					num2 = (short)690946058;
					num = (int)((IntPtr)num2);
					continue;
				}
				case 6:
					this.state = SplashWindowStates.SHOWN_MINIMUM_TIME_HIT;
					num2 = (short)454492161;
					num = (int)((IntPtr)num2);
					continue;
				case 7:
					if (this.state == SplashWindowStates.SHOWN_MINIMUM_TIME_HIT)
					{
						num2 = (short)965738509;
						num = (int)((IntPtr)num2);
						continue;
					}
					num2 = (short)1679818760;
					num = (int)((IntPtr)num2);
					continue;
				case 8:
					num2 = (short)468516865;
					if (num2 != 0)
					{
					}
					if (this.state == SplashWindowStates.CLOSING_FADE_DELAY)
					{
						num2 = (short)2126446595;
						num = (int)((IntPtr)num2);
						continue;
					}
					goto IL_285;
				case 9:
					goto IL_3E4;
				case 10:
					goto IL_339;
				case 11:
					if (!timeSpan.Equals(TimeSpan.Zero))
					{
						num2 = (short)2062024713;
						num = (int)((IntPtr)num2);
						continue;
					}
					goto IL_33E;
				case 12:
					try
					{
						num2 = (short)1111621632;
						num = (int)((IntPtr)num2);
						for (;;)
						{
							switch (num)
							{
							case 0:
								switch (0)
								{
								case 0:
									goto IL_17D;
								}
								continue;
							case 1:
								timeSpan = this._Max.Subtract(this._Min);
								num2 = (short)893124610;
								num = (int)((IntPtr)num2);
								continue;
							case 2:
							{
								num2 = (short)351496613;
								short num4 = num2;
								num2 = (short)479357349;
								switch ((num4 == num2) ? 1 : 0)
								{
								case 0:
								case 2:
									goto IL_1A8;
								default:
									num2 = (short)1873346560;
									if (num2 != 0)
									{
									}
									goto IL_261;
								}
								break;
							}
							case 3:
								goto IL_1A8;
							case 4:
								goto IL_27A;
							case 5:
								if (this._Max > this._Min)
								{
									num2 = (short)1537015809;
									num = (int)((IntPtr)num2);
									continue;
								}
								goto IL_261;
							}
							IL_17D:
							if (this._Min > TimeSpan.Zero)
							{
								num2 = (short)693108739;
								num = (int)((IntPtr)num2);
								continue;
							}
							goto IL_261;
							IL_1A8:
							num2 = (short)357302277;
							num = (int)((IntPtr)num2);
							continue;
							IL_261:
							num2 = (short)940769284;
							num = (int)((IntPtr)num2);
						}
						IL_27A:
						goto IL_3A5;
					}
					catch (Exception)
					{
						goto IL_3A5;
					}
					goto IL_285;
					IL_3A5:
					num2 = (short)2005205003;
					num = (int)((IntPtr)num2);
					continue;
				case 13:
					goto IL_13C;
				case 14:
					if (this.state == SplashWindowStates.CLOSING_WITH_FADE)
					{
						num2 = (short)211025935;
						num = (int)((IntPtr)num2);
						continue;
					}
					return;
				case 15:
					num2 = (short)185073664;
					num = (int)((IntPtr)num2);
					continue;
				}
				goto IL_50;
				IL_285:
				num2 = (short)1653080078;
				num = (int)((IntPtr)num2);
			}
			IL_FC:
			this.timer1.Interval = 30;
			this.state = SplashWindowStates.CLOSING_WITH_FADE;
			this.timer1.Start();
			return;
			IL_13C:
			this.setupFadeOut();
			return;
			IL_339:
			return;
			IL_33E:
			this.setupFadeOut();
			return;
			IL_3E4:
			this.timer1.Interval = (int)timeSpan.TotalMilliseconds;
			this.timer1.Start();
			return;
			IL_447:
			this.setupFadeOut();
			return;
			IL_50:
			this.timer1.Stop();
			num2 = (short)1545469956;
			num = (int)((IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000544 RID: 1348 RVA: 0x000E7FD8 File Offset: 0x000E61D8
		private void setupFadeOut()
		{
			short num = (short)1085014016;
			int num2 = (int)((IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					num = (short)1167654913;
					if (num != 0)
					{
					}
					switch (0)
					{
					case 0:
						goto IL_61;
					}
					continue;
				case 1:
					goto IL_151;
				case 2:
					if (this.state != SplashWindowStates.CLOSING_WITH_FADE)
					{
						num = (short)1087569921;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_156;
				case 3:
				{
					num = (short)457970190;
					short num3 = num;
					num = (short)1756762638;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_151;
					default:
					{
						num = (short)2056519680;
						short num4 = num;
						num = (short)1761935360;
						if (num != 0)
						{
						}
						num = (short)455540738;
						num2 = (int)((IntPtr)num);
						continue;
					}
					}
					break;
				}
				case 4:
					goto IL_9F;
				}
				IL_61:
				if (this.state != SplashWindowStates.CLOSING_FADE_DELAY)
				{
					num = (short)1903034371;
					num2 = (int)((IntPtr)num);
					continue;
				}
				break;
				IL_151:
				this.state = SplashWindowStates.CLOSING_FADE_DELAY;
				num = (short)314638340;
				num2 = (int)((IntPtr)num);
			}
			IL_9F:
			IL_156:
			this.timer1.Interval = 30;
			this.timer1.Start();
		}

		// Token: 0x06000545 RID: 1349 RVA: 0x000E8154 File Offset: 0x000E6354
		private bool HandleFadeOutTick()
		{
			switch (0)
			{
			case 0:
				goto IL_20;
			}
			int num;
			short num2;
			bool result;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					goto IL_7D;
				case 1:
					if (base.Opacity >= 0.1)
					{
						num2 = (short)554500099;
						num = (int)((IntPtr)num2);
						continue;
					}
					this.CloseAndCleanupWindow();
					num2 = (short)339738624;
					num = (int)((IntPtr)num2);
					continue;
				case 2:
					goto IL_121;
				case 3:
					base.Opacity -= 0.05;
					result = true;
					num2 = (short)421068802;
					num = (int)((IntPtr)num2);
					continue;
				}
				goto IL_20;
			}
			IL_7D:
			num2 = (short)1441004230;
			short num3 = num2;
			num2 = (short)1362164422;
			switch ((num3 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_121:
				break;
			default:
			{
				num2 = (short)467730432;
				if (num2 != 0)
				{
				}
				num2 = (short)1357250560;
				short num4 = num2;
				break;
			}
			}
			num2 = (short)1947992065;
			if (num2 != 0)
			{
			}
			return result;
			IL_20:
			result = false;
			num2 = (short)1238040577;
			num = (int)((IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000546 RID: 1350 RVA: 0x000E82B0 File Offset: 0x000E64B0
		protected override void OnShown(EventArgs e)
		{
			short num = (short)1674117120;
			short num2 = num;
			num = (short)858658489;
			short num3 = num;
			num = (short)1639782073;
			switch (num3 == num)
			{
			}
			num = (short)1545994240;
			if (num != 0)
			{
			}
			num = (short)1074069505;
			if (num != 0)
			{
			}
			base.OnShown(e);
		}

		// Token: 0x06000547 RID: 1351 RVA: 0x000E835C File Offset: 0x000E655C
		private void SplashScreen_Load(object sender, EventArgs e)
		{
			int a_ = 12;
			short num = (short)1331232769;
			int num2 = (int)((IntPtr)num);
			for (;;)
			{
				num = (short)1938554881;
				if (num != 0)
				{
				}
				switch (num2)
				{
				case 0:
					return;
				case 1:
					goto IL_1D;
				case 2:
				{
					this.label2.Text = AppResources.Vertex_Standard_LMR_Inc_Protected_By_US_And_International_Copyright_Law;
					this.label2.ForeColor = Color.White;
					this.label2.BackColor = Color.Transparent;
					this.versionLabel.ForeColor = Color.WhiteSmoke;
					ResourceManager resourceManager = new ResourceManager(typeof(SplashScreen));
					this.BackgroundImage = (Image)resourceManager.GetObject(FixedLengthStream.b("뿫黭鳯鏱蟳黵꯷駹軻鯽旿氁䘃朅欇愉欋簍缏朑稓爕䜗䰙礛氝吟䜡尣", a_));
					num = (short)669627417;
					short num3 = num;
					num = (short)1644475417;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_1D;
					case 1:
						break;
					default:
					{
						num = (short)2052259840;
						short num4 = num;
						break;
					}
					}
					num = (short)1245773824;
					if (num != 0)
					{
					}
					num = (short)1635581952;
					num2 = (int)((IntPtr)num);
					continue;
				}
				}
				goto IL_61;
				IL_1D:
				switch (0)
				{
				case 0:
					IL_61:
					if (!Product.IsVertex())
					{
						return;
					}
					num = (short)422707202;
					num2 = (int)((IntPtr)num);
					break;
				}
			}
		}

		// Token: 0x06000548 RID: 1352 RVA: 0x000E84E4 File Offset: 0x000E66E4
		private void SplashScreen_MouseClick(object sender, MouseEventArgs e)
		{
			short num = (short)355074048;
			int num2 = (int)((IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					num = (short)87293953;
					if (num != 0)
					{
					}
					switch (0)
					{
					case 0:
						goto IL_69;
					}
					continue;
				case 1:
				{
					num = (short)656998400;
					short num3 = num;
					goto IL_163;
				}
				case 2:
					num = (short)147456006;
					num2 = (int)((IntPtr)num);
					continue;
				case 3:
				{
					num = (short)606380628;
					short num4 = num;
					num = (short)1233691220;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_163;
					default:
						num = (short)112918528;
						if (num != 0)
						{
						}
						goto IL_B5;
					}
					break;
				}
				case 4:
					if (this.state != SplashWindowStates.SHOWN_MINIMUM_TIME_HIT)
					{
						num = (short)303628290;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_B5;
				case 5:
					return;
				case 6:
					if (this.state == SplashWindowStates.SHOWN_MAXIMUM_TIME_HIT)
					{
						num = (short)1070202883;
						num2 = (int)((IntPtr)num);
						continue;
					}
					return;
				}
				IL_69:
				if (this.state != SplashWindowStates.SHOWN)
				{
					num = (short)2044198913;
					num2 = (int)((IntPtr)num);
					continue;
				}
				IL_B5:
				this.CloseAndCleanupWindow();
				num = (short)1745813509;
				num2 = (int)((IntPtr)num);
				continue;
				IL_163:
				num = (short)1953955844;
				num2 = (int)((IntPtr)num);
			}
		}

		// Token: 0x06000549 RID: 1353 RVA: 0x000E8694 File Offset: 0x000E6894
		protected override void OnActivated(EventArgs e)
		{
			short num;
			for (;;)
			{
				num = (short)1407385600;
				short num2 = num;
				num = (short)1271463937;
				if (num != 0)
				{
				}
				base.OnActivated(e);
				if (this.state != SplashWindowStates.WAIT_FOR_ACTIVATE)
				{
					goto IL_C0;
				}
				num = (short)800616422;
				short num3 = num;
				num = (short)625504230;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					goto IL_98;
				}
			}
			IL_98:
			num = (short)618594304;
			if (num != 0)
			{
			}
			this.state = SplashWindowStates.SHOWN;
			this.timer1.Start();
			return;
			IL_C0:
			SplashWindowStates splashWindowStates = this.state;
		}

		// Token: 0x0400030E RID: 782
		private SplashWindowStates state;

		// Token: 0x0400030F RID: 783
		private TimeSpan _Min;

		// Token: 0x04000310 RID: 784
		private TimeSpan _Max;

		// Token: 0x04000311 RID: 785
		private bool closeRequested;

		// Token: 0x0400031A RID: 794
		[NonSerialized]
		string VafgnaprSvryq = 32;

		// Token: 0x0200007B RID: 123
		private sealed class NoArgsDelegate : MulticastDelegate
		{
			// Token: 0x0600054C RID: 1356
			public extern NoArgsDelegate(object @object, IntPtr method);

			// Token: 0x0600054D RID: 1357
			public extern void Invoke();

			// Token: 0x0600054E RID: 1358
			public extern IAsyncResult BeginInvoke(AsyncCallback callback, object @object);

			// Token: 0x0600054F RID: 1359
			public extern void EndInvoke(IAsyncResult result);

			// Token: 0x0400031B RID: 795
			[NonSerialized]
			string VafgnaprSvryq = 32;
		}

		// Token: 0x0200007C RID: 124
		private sealed class BoolDelegate : MulticastDelegate
		{
			// Token: 0x06000550 RID: 1360
			public extern BoolDelegate(object @object, IntPtr method);

			// Token: 0x06000551 RID: 1361
			public extern void Invoke(bool b);

			// Token: 0x06000552 RID: 1362
			public extern IAsyncResult BeginInvoke(bool b, AsyncCallback callback, object @object);

			// Token: 0x06000553 RID: 1363
			public extern void EndInvoke(IAsyncResult result);

			// Token: 0x0400031C RID: 796
			[NonSerialized]
			string VafgnaprSvryq = 32;
		}

		// Token: 0x0200007D RID: 125
		private sealed class UpdateTextDelegate : MulticastDelegate
		{
			// Token: 0x06000554 RID: 1364
			public extern UpdateTextDelegate(object @object, IntPtr method);

			// Token: 0x06000555 RID: 1365
			public extern void Invoke(string s);

			// Token: 0x06000556 RID: 1366
			public extern IAsyncResult BeginInvoke(string s, AsyncCallback callback, object @object);

			// Token: 0x06000557 RID: 1367
			public extern void EndInvoke(IAsyncResult result);

			// Token: 0x0400031D RID: 797
			[NonSerialized]
			string VafgnaprSvryq = 32;
		}

		// Token: 0x0200007E RID: 126
		private sealed class UpdateProgressDelegate : MulticastDelegate
		{
			// Token: 0x06000558 RID: 1368
			public extern UpdateProgressDelegate(object @object, IntPtr method);

			// Token: 0x06000559 RID: 1369
			public extern void Invoke(int start_value, int stop_value, int current_value);

			// Token: 0x0600055A RID: 1370
			public extern IAsyncResult BeginInvoke(int start_value, int stop_value, int current_value, AsyncCallback callback, object @object);

			// Token: 0x0600055B RID: 1371
			public extern void EndInvoke(IAsyncResult result);

			// Token: 0x0400031E RID: 798
			[NonSerialized]
			string VafgnaprSvryq = 32;
		}
	}
}
