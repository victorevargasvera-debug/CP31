using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Shapes;
using AcpCommonLib;
using AcpUI;
using AcpUI.Common;
using CommonResources;
using Motorola.Common.Communication.CommonUtil;
using Motorola.CommonCPS.Server.EntityModel;
using Motorola.MackinawCPS.CoreFeatures.RadioInformation;
using PreEmptive.SoS.Runtime;

namespace MackinawCPS.HomeBase
{
	// Token: 0x02000080 RID: 128
	public partial class PageWelcomeTreeView : Page
	{
		// Token: 0x0600056A RID: 1386 RVA: 0x000EA0C4 File Offset: 0x000E82C4
		public PageWelcomeTreeView()
		{
			int a_ = 14;
			base..ctor();
			this.InitializeComponent();
			AcpUI.Common.Utility.SetDirection(this);
			this.winMain = (WindowMain)Application.Current.MainWindow;
			this.dpd = DependencyPropertyDescriptor.FromProperty(WindowMain.ReadWriteTransportProperty, typeof(WindowMain));
			if (this.dpd != null)
			{
				this.dpd.AddValueChanged(this.winMain, new EventHandler(this.ReadWriteTransportPropertyHandler));
			}
			this.dpdclone = DependencyPropertyDescriptor.FromProperty(WindowMain.CloneTransportProperty, typeof(WindowMain));
			if (this.dpdclone != null)
			{
				this.dpdclone.AddValueChanged(this.winMain, new EventHandler(this.CloneTransportPropertyHandler));
			}
			base.DataContext = this.winMain;
			if (Thread.CurrentThread.CurrentCulture.Name.ToLower().StartsWith(FixedLengthStream.b("迭苯", a_)))
			{
				this.AppMruListHomeBase.FlowDirection = FlowDirection.LeftToRight;
			}
			if (VersionInfoHelper.IsDFlagExisted(DFlagType.DASTRO))
			{
				this.ButtonRMC.Visibility = Visibility.Collapsed;
				this.Rectangle_GetingStarted.Fill = Brushes.Orange;
				Style style = (Style)base.FindResource(FixedLengthStream.b("鳭釯雱鷳駵\ud8f7飹觻諽瓿洁樃★渇攉縋⸍䘏眑易戕紗戙", a_));
				Style style2 = (Style)base.FindResource(FixedLengthStream.b("귭鳯鷱髳鏵ꟷ믹ꏻ곽懿昁洃椅圇䠉礋稍搏紑稓䤕帗甙減䄝瘟䜡嘣別䴧利", a_));
				Style style3 = (Style)base.FindResource(FixedLengthStream.b("꣭鳯鏱蟳黵\ud8f7鯹\udcfb賽懿昁洃椅⠇栉礋稍搏紑稓㘕縗甙減㸝瘟䜡嘣別䴧利", a_));
				Style style4 = (Style)base.FindResource(FixedLengthStream.b("곭苯鷱菳藵鷷\udaf9髻釽狿∁攃★欇攉栋欍怏縑愓焕㠗簙猛氝\u001f琡䄣吥尧伩含", a_));
				this.ButtonBrowseForCpg.Style = style4;
				this.ButtonReadRadio.Style = style;
				this.ButtonFlashRadio.Style = style3;
				this.ButtonCloneRadio.Style = style2;
			}
			if (CpsVersionResolver.Instance.IsItCpsWithoutAnRm)
			{
				this.ButtonRMC.Visibility = Visibility.Collapsed;
			}
		}

		// Token: 0x0600056B RID: 1387 RVA: 0x000EA2C0 File Offset: 0x000E84C0
		internal void OnButtonClick(object sender, RoutedEventArgs e)
		{
			switch (0)
			{
			case 0:
				goto IL_38;
			}
			int num;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					goto IL_C9;
				case 1:
				{
					if (sender == this.ButtonCloneRadio)
					{
						num2 = (short)216203268;
						num = (int)((IntPtr)num2);
						continue;
					}
					num2 = (short)1100218368;
					short num3 = num2;
					num2 = (short)343080967;
					num = (int)((IntPtr)num2);
					continue;
				}
				case 2:
					goto IL_235;
				case 3:
				{
					if (sender == this.ButtonBrowseForCpg)
					{
						num2 = (short)69926912;
						num = (int)((IntPtr)num2);
						continue;
					}
					num2 = (short)704841575;
					short num4 = num2;
					num2 = (short)1572996967;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_13F;
					default:
						num2 = (short)18612224;
						if (num2 != 0)
						{
						}
						num2 = (short)97058825;
						num = (int)((IntPtr)num2);
						continue;
					}
					break;
				}
				case 4:
					goto IL_1A1;
				case 5:
					goto IL_134;
				case 6:
					if (sender == this.ButtonReadRadio)
					{
						num2 = (short)1547436040;
						num = (int)((IntPtr)num2);
						continue;
					}
					num2 = (short)1430781955;
					num = (int)((IntPtr)num2);
					continue;
				case 7:
					if (sender == this.ButtonRMC)
					{
						num2 = (short)26738693;
						num = (int)((IntPtr)num2);
						continue;
					}
					goto IL_243;
				case 8:
					goto IL_7A;
				case 9:
					if (sender == this.ButtonFlashRadio)
					{
						num2 = (short)954466306;
						num = (int)((IntPtr)num2);
						continue;
					}
					goto IL_13F;
				}
				goto IL_38;
				IL_13F:
				num2 = (short)663748609;
				if (num2 != 0)
				{
				}
				num2 = (short)525795329;
				num = (int)((IntPtr)num2);
			}
			IL_7A:
			WindowMain windowMain;
			windowMain.OnRibbonBarReadRadio(null, null);
			return;
			IL_C9:
			windowMain.OnAppMenuOpen(sender, e);
			return;
			IL_134:
			windowMain.OnAppMenuRadioManagement(sender, e);
			return;
			IL_1A1:
			windowMain.CloneRadio();
			return;
			IL_235:
			windowMain.FlashRadio(true);
			return;
			IL_243:
			string pageWelcomeTreeView_OnButtonClick_Not_implemented_yet = AppResources.PageWelcomeTreeView_OnButtonClick_Not_implemented_yet;
			AppInfoManager.StatusMsgReport.RegisterMessage(StatusMsgType.Error, pageWelcomeTreeView_OnButtonClick_Not_implemented_yet);
			return;
			IL_38:
			windowMain = (WindowMain)Application.Current.MainWindow;
			num2 = (short)268500998;
			num = (int)((IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x0600056C RID: 1388 RVA: 0x000EA524 File Offset: 0x000E8724
		private void ReadWriteTransportPropertyHandler(object sender, EventArgs args)
		{
			int a_ = 16;
			switch (0)
			{
			case 0:
				goto IL_64;
			}
			short num;
			int num2;
			Label label;
			for (;;)
			{
				IL_13:
				num = (short)1758920705;
				if (num != 0)
				{
				}
				switch (num2)
				{
				case 0:
					num = (short)1318191108;
					num2 = (int)((IntPtr)num);
					continue;
				case 1:
					goto IL_195;
				case 2:
				{
					if (this.winMain.ReadWriteTransport != 2)
					{
						return;
					}
					num = (short)2076365066;
					short num3 = num;
					num = (short)740282634;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_1AF;
					default:
						num = (short)304545792;
						if (num != 0)
						{
						}
						num = (short)552009731;
						num2 = (int)((IntPtr)num);
						continue;
					}
					break;
				}
				case 3:
					label.Content = AppResources.Bluetooth_Id;
					num = (short)1107230725;
					num2 = (int)((IntPtr)num);
					continue;
				case 4:
					goto IL_1AF;
				case 5:
					return;
				case 6:
					if (this.winMain.ReadWriteTransport == 1)
					{
						num = (short)2043412481;
						num2 = (int)((IntPtr)num);
						continue;
					}
					num = (short)1411645442;
					num2 = (int)((IntPtr)num);
					continue;
				case 7:
					if (label != null)
					{
						num = (short)892534784;
						num2 = (int)((IntPtr)num);
						continue;
					}
					return;
				case 8:
					goto IL_1D5;
				}
				goto IL_64;
				IL_1AF:
				if (this.winMain.ReadWriteTransport == 0)
				{
					num = (short)890372104;
					num2 = (int)((IntPtr)num);
				}
				else
				{
					num = (short)1239482374;
					num2 = (int)((IntPtr)num);
				}
			}
			IL_195:
			num = (short)1487994880;
			short num4 = num;
			label.Content = AppResources.POP25_Id;
			return;
			IL_1D5:
			label.Content = AppResources.USB_ID;
			return;
			IL_64:
			label = (this.ButtonReadRadio.Template.FindName(FixedLengthStream.b("ꗯꇱ뛳苵釷軹郻鯽㗿", a_), this.ButtonReadRadio) as Label);
			num = (short)917438471;
			num2 = (int)((IntPtr)num);
			goto IL_13;
		}

		// Token: 0x0600056D RID: 1389 RVA: 0x000EA770 File Offset: 0x000E8970
		private void CloneTransportPropertyHandler(object sender, EventArgs args)
		{
			int a_ = 18;
			switch (0)
			{
			case 0:
				goto IL_3D;
			}
			int num;
			short num2;
			Label label;
			for (;;)
			{
				IL_13:
				switch (num)
				{
				case 0:
					if (this.winMain.CloneTransport != 0)
					{
						num2 = (short)840034413;
						short num3 = num2;
						num2 = (short)851175533;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							num2 = (short)501088256;
							if (num2 != 0)
							{
							}
							num2 = (short)1204748295;
							num = (int)((IntPtr)num2);
							continue;
						}
					}
					num2 = (short)259850243;
					num = (int)((IntPtr)num2);
					continue;
				case 1:
					if (this.winMain.CloneTransport == 2)
					{
						num2 = (short)1036451844;
						num = (int)((IntPtr)num2);
						continue;
					}
					return;
				case 2:
					return;
				case 3:
					goto IL_1B4;
				case 4:
					num2 = (short)1494417409;
					if (num2 != 0)
					{
					}
					label.Content = AppResources.Bluetooth_Id;
					num2 = (short)484048898;
					num = (int)((IntPtr)num2);
					continue;
				case 5:
					num2 = (short)776470528;
					num = (int)((IntPtr)num2);
					continue;
				case 6:
					if (label != null)
					{
						num2 = (short)548667397;
						num = (int)((IntPtr)num2);
						continue;
					}
					return;
				case 7:
					if (this.winMain.CloneTransport == 1)
					{
						num2 = (short)627179528;
						num = (int)((IntPtr)num2);
						continue;
					}
					num2 = (short)1306001409;
					num = (int)((IntPtr)num2);
					continue;
				case 8:
					goto IL_16F;
				}
				goto IL_3D;
			}
			IL_16F:
			num2 = (short)1037238272;
			short num4 = num2;
			label.Content = AppResources.POP25_Id;
			return;
			IL_1B4:
			label.Content = AppResources.USB_ID;
			return;
			IL_3D:
			label = (this.ButtonCloneRadio.Template.FindName(FixedLengthStream.b("꟱ꟳ듵賷鏹裻鋽旿㘁", a_), this.ButtonCloneRadio) as Label);
			num2 = (short)330170374;
			num = (int)((IntPtr)num2);
			goto IL_13;
		}

		// Token: 0x0600056E RID: 1390 RVA: 0x000EA9C0 File Offset: 0x000E8BC0
		private void OnMruFileOpen(object sender, RoutedEventArgs e)
		{
			short num = (short)44892160;
			switch (num)
			{
			default:
			{
				num = (short)424476677;
				int num2 = (int)((IntPtr)num);
				for (;;)
				{
					bool flag;
					string filePath;
					switch (num2)
					{
					case 0:
					{
						WindowMain windowMain;
						if (windowMain.CpgOpenFlag)
						{
							num = (short)1982726161;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_119;
					}
					case 1:
						goto IL_309;
					case 2:
					{
						num = (short)514056006;
						short num3 = num;
						num = (short)726720326;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_149;
						default:
							num = (short)415498240;
							if (num != 0)
							{
							}
							goto IL_119;
						}
						break;
					}
					case 3:
						num = (short)644677638;
						num2 = (int)((IntPtr)num);
						continue;
					case 4:
						return;
					case 5:
						switch (0)
						{
						case 0:
							goto IL_8B;
						}
						continue;
					case 6:
					{
						WindowMain windowMain;
						if (!windowMain.CanOpenCpgFlag)
						{
							num = (short)1886519300;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_34A;
					}
					case 7:
						if (flag)
						{
							num = (short)1633484809;
							num2 = (int)((IntPtr)num);
							continue;
						}
						return;
					case 8:
					{
						WindowMain windowMain;
						if (windowMain.CpgOpenFlag)
						{
							num = (short)906690563;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_34A;
					}
					case 9:
					{
						PageNavPaneButtons pageNavPaneButtons;
						pageNavPaneButtons.FrameCodeplug.NavigationService.Refresh();
						num = (short)1710948368;
						num2 = (int)((IntPtr)num);
						continue;
					}
					case 10:
						num = (short)18087943;
						num2 = (int)((IntPtr)num);
						continue;
					case 11:
						num = (short)1263468556;
						num2 = (int)((IntPtr)num);
						continue;
					case 12:
					{
						WindowMain windowMain;
						if (windowMain.OpenCodeplug(filePath, null, null))
						{
							num = (short)342622218;
							num2 = (int)((IntPtr)num);
							continue;
						}
						return;
					}
					case 13:
					{
						WindowMain windowMain;
						windowMain.FrameCenterTop.NavigationService.Refresh();
						num = (short)277676033;
						num2 = (int)((IntPtr)num);
						continue;
					}
					case 14:
						if (!string.IsNullOrEmpty(filePath))
						{
							goto IL_149;
						}
						return;
					case 15:
					{
						WindowMain windowMain = (WindowMain)Application.Current.MainWindow;
						PageNavPaneButtons pageNavPaneButtons = (PageNavPaneButtons)windowMain.FrameLeft.Content;
						flag = false;
						num = (short)721354752;
						num2 = (int)((IntPtr)num);
						continue;
					}
					case 16:
					{
						WindowMain windowMain;
						if (windowMain.FrameCenterTop.Content is PageRadioInformation)
						{
							num = (short)1163919373;
							num2 = (int)((IntPtr)num);
							continue;
						}
						return;
					}
					case 17:
					{
						WindowMain windowMain;
						windowMain.OnAppMenuClose(sender, e);
						num = (short)305004544;
						short num4 = num;
						num = (short)1146486792;
						num2 = (int)((IntPtr)num);
						continue;
					}
					}
					IL_8B:
					num = (short)1123811329;
					if (num != 0)
					{
					}
					if (sender is AcpListBoxMruFiles)
					{
						num = (short)72220687;
						num2 = (int)((IntPtr)num);
						continue;
					}
					break;
					IL_119:
					filePath = ((SelectedMruFileEventArgs)e).FilePath;
					num = (short)2070806542;
					num2 = (int)((IntPtr)num);
					continue;
					IL_149:
					num = (short)277676043;
					num2 = (int)((IntPtr)num);
					continue;
					IL_34A:
					flag = true;
					num = (short)332988418;
					num2 = (int)((IntPtr)num);
				}
				IL_309:
				return;
			}
			}
		}

		// Token: 0x04000346 RID: 838
		private WindowMain winMain;

		// Token: 0x04000347 RID: 839
		private DependencyPropertyDescriptor dpd;

		// Token: 0x04000348 RID: 840
		private DependencyPropertyDescriptor dpdclone;

		// Token: 0x04000353 RID: 851
		[NonSerialized]
		string VafgnaprSvryq = 32;
	}
}
