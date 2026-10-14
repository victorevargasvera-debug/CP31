using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using ACPBrowser;
using AcpCommonLib;
using AcpUI.Common;
using MackinawCPS.Properties;
using Motorola.Common.Communication.CommonUtil;
using Motorola.CommonCPS.Server.EntityModel;
using PreEmptive.SoS.Runtime;

namespace MackinawCPS.HomeBase
{
	// Token: 0x0200007F RID: 127
	public partial class PageWelcome : Page
	{
		// Token: 0x0600055C RID: 1372 RVA: 0x000E8F70 File Offset: 0x000E7170
		public PageWelcome()
		{
			this.InitializeComponent();
			AcpUI.Common.Utility.SetDirection(this);
		}

		// Token: 0x0600055D RID: 1373 RVA: 0x000E8FA8 File Offset: 0x000E71A8
		private void OnLoaded(object sender, RoutedEventArgs e)
		{
			int a_ = 5;
			this.WhatsNewExp.IsExpanded = false;
			this.GettingStartedExp.IsExpanded = false;
			this.RMExp.IsExpanded = false;
			this.ASKExp.IsExpanded = false;
			this.CPSNavExp.IsExpanded = false;
			this.RadioFeatExp.IsExpanded = false;
			this.MoreExp.IsExpanded = false;
			this.CustomBackgroudPath = Settings.Default.CustomBackgroudPath;
			this.VertexBackgroundPath = Settings.Default.VertexBackgroundPath;
			if (VersionInfoHelper.IsDFlagExisted(DFlagType.DASTRO))
			{
				short num;
				for (;;)
				{
					num = (short)790504782;
					short num2 = num;
					num = (short)1459299662;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						goto IL_BE;
					}
				}
				IL_BE:
				num = (short)407896064;
				short num3 = num;
				num = (short)1185808385;
				if (num != 0)
				{
				}
				num = (short)81526784;
				if (num != 0)
				{
				}
				Image image = new Image();
				BitmapImage bitmapImage = new BitmapImage();
				bitmapImage.BeginInit();
				bitmapImage.UriSource = new Uri(this.VertexBackgroundPath, UriKind.RelativeOrAbsolute);
				bitmapImage.EndInit();
				image.Source = bitmapImage;
				this.CustomerLogo.Child = image;
				this.image.SetResourceReference(Shape.FillProperty, FixedLengthStream.b("다苦藨裪苬苮铰ꏲ铴郶鳸맺鳼釾漀昂眄丆搈樊樌樎匐愒怔搖焘䴚砜洞唠䘢崤", a_));
				this.backgroundImage.SetResourceReference(Shape.FillProperty, FixedLengthStream.b("다苦藨裪苬苮铰ꏲ铴郶鳸맺鳼鳾樀搂眄栆簈攊椌䘎簐爒爔爖嬘椚栜氞䤠產䀤唦崨个唬", a_));
				this.RMExp.Visibility = Visibility.Collapsed;
				this.WhatsNewExp.Visibility = Visibility.Hidden;
				this.Tutorials.Visibility = Visibility.Hidden;
				this.GettingStartedExp.Visibility = Visibility.Hidden;
				this.CPSNavExp.Visibility = Visibility.Hidden;
				this.ASKExp.Visibility = Visibility.Hidden;
				this.RadioFeatExp.Visibility = Visibility.Hidden;
				this.MoreExp.Visibility = Visibility.Hidden;
				return;
			}
			this.SetBackground(this.CustomBackgroudPath);
		}

		// Token: 0x0600055E RID: 1374 RVA: 0x000E91C0 File Offset: 0x000E73C0
		internal void LoadDefaultLogo()
		{
			short num = (short)670957569;
			if (num != 0)
			{
			}
			num = (short)792432339;
			short num2 = num;
			num = (short)563777235;
			switch (num2 == num)
			{
			default:
			{
				num = (short)337117184;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)880869376;
			if (num != 0)
			{
			}
			this.SetBackground(WindowMain.DefaultLogoPath);
		}

		// Token: 0x0600055F RID: 1375 RVA: 0x000E9274 File Offset: 0x000E7474
		internal void SetBackground(string path)
		{
			short num = (short)837484547;
			int num2 = (int)((IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					try
					{
						Image image = new Image();
						BitmapImage bitmapImage = new BitmapImage();
						bitmapImage.BeginInit();
						bitmapImage.UriSource = new Uri(this.CustomBackgroudPath, UriKind.RelativeOrAbsolute);
						bitmapImage.EndInit();
						image.Source = bitmapImage;
						this.CustomerLogo.Child = image;
						Settings.Default.CustomBackgroudPath = this.CustomBackgroudPath;
						Settings.Default.Save();
						return;
					}
					catch (Exception ex)
					{
						this.CustomBackgroudPath = WindowMain.DefaultLogoPath;
						AppInfoManager.StatusMsgReport.RegisterMessage(StatusMsgType.Error, ex.Message);
						return;
					}
					goto IL_128;
				case 1:
					goto IL_128;
				case 2:
					this.CustomBackgroudPath = WindowMain.DefaultLogoPath;
					num = (short)1731854337;
					num2 = (int)((IntPtr)num);
					continue;
				case 3:
					switch (0)
					{
					case 0:
						goto IL_38;
					}
					continue;
				case 4:
					goto IL_128;
				}
				IL_38:
				if (!string.IsNullOrEmpty(path))
				{
					this.CustomBackgroudPath = path;
					num = (short)214630404;
					num2 = (int)((IntPtr)num);
					continue;
				}
				num = (short)364174146;
				short num3 = num;
				num = (short)1439882050;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)1893007360;
					if (num != 0)
					{
					}
					num = (short)633470978;
					num2 = (int)((IntPtr)num);
					continue;
				}
				IL_128:
				num = (short)1089077249;
				if (num != 0)
				{
				}
				num = (short)238354432;
				short num4 = num;
				num = (short)1246756864;
				num2 = (int)((IntPtr)num);
			}
		}

		// Token: 0x06000560 RID: 1376 RVA: 0x000E9478 File Offset: 0x000E7678
		private void OnExpanderWhatsNewCollapsed(object sender, RoutedEventArgs e)
		{
			short num;
			try
			{
				num = (short)443848783;
				short num2 = num;
				num = (short)1929812047;
				switch (num2 == num)
				{
				}
				num = (short)1594294272;
				if (num != 0)
				{
				}
				ACPBrowser.Utility.CloseHelpWindowIfOpen();
				ACPBrowser.Utility.DisplayCPSHelpDITA(null);
			}
			catch (Exception)
			{
			}
			num = (short)1949106176;
			short num3 = num;
			num = (short)811991041;
			if (num != 0)
			{
			}
		}

		// Token: 0x06000561 RID: 1377 RVA: 0x000E9540 File Offset: 0x000E7740
		private void OnExpanderGettingStartedCollapsed(object sender, RoutedEventArgs e)
		{
			short num;
			try
			{
				num = (short)1898467035;
				short num2 = num;
				num = (short)441798363;
				switch (num2 == num)
				{
				}
				num = (short)1172570112;
				if (num != 0)
				{
				}
				ACPBrowser.Utility.CloseHelpWindowIfOpen();
				ACPBrowser.Utility.DisplayMovie(null);
			}
			catch (Exception)
			{
			}
			num = (short)680656896;
			short num3 = num;
			num = (short)1945698305;
			if (num != 0)
			{
			}
		}

		// Token: 0x06000562 RID: 1378 RVA: 0x000E960C File Offset: 0x000E780C
		private void OnExpanderTutorialsCollapsed(object sender, RoutedEventArgs e)
		{
			short num;
			try
			{
				num = (short)1774015058;
				short num2 = num;
				num = (short)720261714;
				switch (num2 == num)
				{
				}
				num = (short)1390411776;
				if (num != 0)
				{
				}
				ACPBrowser.Utility.CloseHelpWindowIfOpen();
				ACPBrowser.Utility.DisplayCPSHelpDITA(null);
			}
			catch (Exception)
			{
			}
			num = (short)1115422720;
			short num3 = num;
			num = (short)1536098305;
			if (num != 0)
			{
			}
		}

		// Token: 0x06000563 RID: 1379 RVA: 0x000E96D8 File Offset: 0x000E78D8
		private void OnExpanderRMCollapsed(object sender, RoutedEventArgs e)
		{
			short num;
			try
			{
				num = (short)640379914;
				short num2 = num;
				num = (short)1675586570;
				switch (num2 == num)
				{
				}
				num = (short)434307072;
				if (num != 0)
				{
				}
				ACPBrowser.Utility.CloseHelpWindowIfOpen();
				ACPBrowser.Utility.DisplayMovie(null);
			}
			catch (Exception)
			{
			}
			num = (short)346816512;
			short num3 = num;
			num = (short)1604059137;
			if (num != 0)
			{
			}
		}

		// Token: 0x06000564 RID: 1380 RVA: 0x000E97A0 File Offset: 0x000E79A0
		private void OnExpanderASKCollapsed(object sender, RoutedEventArgs e)
		{
			short num;
			try
			{
				num = (short)920224689;
				short num2 = num;
				num = (short)1531478961;
				switch (num2 == num)
				{
				}
				num = (short)72679425;
				if (num != 0)
				{
				}
				num = (short)266731520;
				if (num != 0)
				{
				}
				ACPBrowser.Utility.CloseHelpWindowIfOpen();
				ACPBrowser.Utility.DisplayMovie(null);
			}
			catch (Exception)
			{
			}
			num = (short)1151270912;
			short num3 = num;
		}

		// Token: 0x06000565 RID: 1381 RVA: 0x000E9868 File Offset: 0x000E7A68
		private void OnExpanderCPSNavCollapsed(object sender, RoutedEventArgs e)
		{
			short num;
			try
			{
				num = (short)1677395728;
				short num2 = num;
				num = (short)1543898896;
				switch (num2 == num)
				{
				}
				num = (short)705560576;
				if (num != 0)
				{
				}
				ACPBrowser.Utility.CloseHelpWindowIfOpen();
				ACPBrowser.Utility.DisplayMovie(null);
			}
			catch (Exception)
			{
			}
			num = (short)455737344;
			short num3 = num;
			num = (short)1658060801;
			if (num != 0)
			{
			}
		}

		// Token: 0x06000566 RID: 1382 RVA: 0x000E9930 File Offset: 0x000E7B30
		private void OnExpanderRadioFeatCollapsed(object sender, RoutedEventArgs e)
		{
			int a_ = 19;
			short num;
			try
			{
				num = (short)44551363;
				short num2 = num;
				num = (short)850250947;
				switch (num2 == num)
				{
				}
				num = (short)1174994945;
				if (num != 0)
				{
				}
				num = (short)859963392;
				if (num != 0)
				{
				}
				ACPBrowser.Utility.CloseHelpWindowIfOpen();
				ACPBrowser.Utility.DisplayCPSHelpDITA(FixedLengthStream.b("탲쏴웶째飺鳼죾㜀㘂", a_));
			}
			catch (Exception)
			{
			}
			num = (short)1290731520;
			short num3 = num;
		}

		// Token: 0x06000567 RID: 1383 RVA: 0x000E9A14 File Offset: 0x000E7C14
		private void OnExpanderExpanded(object sender, RoutedEventArgs e)
		{
			short num = (short)406204196;
			short num2 = num;
			num = (short)1996959524;
			switch (num2 == num)
			{
			}
			num = (short)1319043072;
			short num3 = num;
			num = (short)1364590593;
			if (num != 0)
			{
			}
			num = (short)1121910784;
			if (num != 0)
			{
			}
			this.WhatsNewExp.IsExpanded = false;
			this.GettingStartedExp.IsExpanded = false;
			this.RMExp.IsExpanded = false;
			this.ASKExp.IsExpanded = false;
			this.CPSNavExp.IsExpanded = false;
			this.RadioFeatExp.IsExpanded = false;
			this.MoreExp.IsExpanded = false;
		}

		// Token: 0x0400031F RID: 799
		private string CustomBackgroudPath = string.Empty;

		// Token: 0x04000320 RID: 800
		private string VertexBackgroundPath = string.Empty;

		// Token: 0x04000345 RID: 837
		[NonSerialized]
		string VafgnaprSvryq = 32;
	}
}
