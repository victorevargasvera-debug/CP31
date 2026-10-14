using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Markup;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using AcpCommonLib;
using AcpUI.Common;
using MackinawCPS.Properties;
using Motorola.Common.Communication.CommonUtil;
using Motorola.CommonCPS.Server.EntityModel;
using PreEmptive.SoS.Runtime;

namespace MackinawCPS
{
	// Token: 0x0200002A RID: 42
	public class PageCustomViewWelcome : global::System.Windows.Controls.Page, global::System.Windows.Markup.IComponentConnector
	{
		// Token: 0x0600009C RID: 156 RVA: 0x000110C0 File Offset: 0x0000F2C0
		public PageCustomViewWelcome()
		{
			this.InitializeComponent();
			global::AcpUI.Common.Utility.SetDirection(this);
		}

		// Token: 0x0600009D RID: 157 RVA: 0x000110F8 File Offset: 0x0000F2F8
		private void OnLoaded(object sender, global::System.Windows.RoutedEventArgs e)
		{
			int a_ = 19;
			short num = (short)585347129;
			short num2 = num;
			num = (short)509063225;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)1570963456;
				if (num != 0)
				{
				}
				num = (short)2009989121;
				if (num != 0)
				{
				}
				this.CustomBackgroudPath = global::MackinawCPS.Properties.Settings.Default.CustomBackgroudPath;
				this.VertexBackgroundPath = global::MackinawCPS.Properties.Settings.Default.VertexBackgroundPath;
				if (!global::Motorola.CommonCPS.Server.EntityModel.VersionInfoHelper.IsDFlagExisted(global::Motorola.Common.Communication.CommonUtil.DFlagType.DASTRO))
				{
					this.SetBackground(this.CustomBackgroudPath);
					return;
				}
				num = (short)1602224128;
				short num3 = num;
				break;
			}
			}
			global::System.Windows.Controls.Image image = new global::System.Windows.Controls.Image();
			global::System.Windows.Media.Imaging.BitmapImage bitmapImage = new global::System.Windows.Media.Imaging.BitmapImage();
			bitmapImage.BeginInit();
			bitmapImage.UriSource = new global::System.Uri(this.VertexBackgroundPath, global::System.UriKind.RelativeOrAbsolute);
			bitmapImage.EndInit();
			image.Source = bitmapImage;
			this.CustomerLogo.Child = image;
			this.image.SetResourceReference(global::System.Windows.Shapes.Shape.FillProperty, global::PreEmptive.SoS.Runtime.FixedLengthStream.b("ꓲ郴鯶髸铺郼髾儀戂戄戆䬈樊挌愎琐愒尔稖砘簚砜崞匠嘢嘤伦缨个弬嬮吰䬲", a_));
			this.backgroundImage.SetResourceReference(global::System.Windows.Shapes.Shape.FillProperty, global::PreEmptive.SoS.Runtime.FixedLengthStream.b("ꓲ郴鯶髸铺郼髾儀戂戄戆䬈樊渌搎瘐愒稔或眘缚吜爞䀠䐢䀤攦嬨帪帬䜮朰嘲䜴䌶尸䌺", a_));
		}

		// Token: 0x0600009E RID: 158 RVA: 0x00011260 File Offset: 0x0000F460
		internal void LoadDefaultLogo()
		{
			short num = (short)1364983808;
			short num2 = num;
			num = (short)1464641272;
			short num3 = num;
			num = (short)297772792;
			switch (num3 == num)
			{
			}
			num = (short)573898753;
			if (num != 0)
			{
			}
			num = (short)74448896;
			if (num != 0)
			{
			}
			this.SetBackground(global::MackinawCPS.WindowMain.DefaultLogoPath);
		}

		// Token: 0x0600009F RID: 159 RVA: 0x00011314 File Offset: 0x0000F514
		internal void SetBackground(string path)
		{
			for (;;)
			{
				IL_00:
				short num = (short)1375404032;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
					{
						num = (short)892297491;
						short num3 = num;
						num = (short)1891459347;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_00;
						default:
						{
							num = (short)1508048896;
							short num4 = num;
							num = (short)1666187265;
							if (num != 0)
							{
							}
							num = (short)1157103616;
							if (num != 0)
							{
							}
							switch (0)
							{
							case 0:
								goto IL_D9;
							}
							continue;
						}
						}
						break;
					}
					case 1:
						goto IL_179;
					case 2:
						this.CustomBackgroudPath = global::MackinawCPS.WindowMain.DefaultLogoPath;
						num = (short)1766850561;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						goto IL_179;
					case 4:
						try
						{
							global::System.Windows.Controls.Image image = new global::System.Windows.Controls.Image();
							global::System.Windows.Media.Imaging.BitmapImage bitmapImage = new global::System.Windows.Media.Imaging.BitmapImage();
							bitmapImage.BeginInit();
							bitmapImage.UriSource = new global::System.Uri(this.CustomBackgroudPath, global::System.UriKind.RelativeOrAbsolute);
							bitmapImage.EndInit();
							image.Source = bitmapImage;
							this.CustomerLogo.Child = image;
							global::MackinawCPS.Properties.Settings.Default.CustomBackgroudPath = this.CustomBackgroudPath;
							global::MackinawCPS.Properties.Settings.Default.Save();
							return;
						}
						catch (global::System.Exception ex)
						{
							this.CustomBackgroudPath = global::MackinawCPS.WindowMain.DefaultLogoPath;
							global::AcpCommonLib.AppInfoManager.StatusMsgReport.RegisterMessage(global::AcpCommonLib.StatusMsgType.Error, ex.Message);
							return;
						}
						goto IL_179;
					}
					IL_D9:
					if (string.IsNullOrEmpty(path))
					{
						num = (short)481427458;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					this.CustomBackgroudPath = path;
					num = (short)889323523;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_179:
					num = (short)958005252;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
		}

		// Token: 0x060000A0 RID: 160 RVA: 0x0001150C File Offset: 0x0000F70C
		private void OnExpanderCollapsed(object sender, global::System.Windows.RoutedEventArgs e)
		{
			short num = (short)1745575365;
			short num2 = num;
			num = (short)1931238853;
			int num3;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_61:
				switch (0)
				{
				case 0:
					goto IL_AF;
				}
				break;
			default:
				num = (short)932708352;
				if (num != 0)
				{
				}
				num = (short)1933180928;
				num3 = (int)((global::System.IntPtr)num);
				break;
			}
			for (;;)
			{
				IL_6B:
				num = (short)907083776;
				short num4 = num;
				switch (num3)
				{
				case 0:
					goto IL_61;
				case 1:
					if (this.Monitor1ClientFrame != null)
					{
						num = (short)873594883;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 2:
					num = (short)555810817;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					this.Monitor1ClientFrame.Visibility = global::System.Windows.Visibility.Collapsed;
					this.CustomerLogo.Visibility = global::System.Windows.Visibility.Visible;
					num = (short)1699545092;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					goto IL_106;
				}
				goto IL_AF;
			}
			IL_106:
			num = (short)216924161;
			if (num != 0)
			{
			}
			return;
			IL_AF:
			if (!this.HowToExp.IsExpanded)
			{
				num = (short)459866114;
				num3 = (int)((global::System.IntPtr)num);
				goto IL_6B;
			}
		}

		// Token: 0x060000A1 RID: 161 RVA: 0x00011688 File Offset: 0x0000F888
		private void OnHowToItemClick(object sender, global::System.Windows.RoutedEventArgs e)
		{
			int a_ = 5;
			switch (0)
			{
			case 0:
				goto IL_BB;
			}
			short num;
			int num4;
			global::System.Windows.Documents.Hyperlink hyperlink;
			string text;
			for (;;)
			{
				IL_13:
				num = (short)1679119953;
				short num2 = num;
				num = (short)1780635217;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_2D8;
				case 1:
					break;
				default:
				{
					num = (short)1307377664;
					short num3 = num;
					break;
				}
				}
				num = (short)2077097984;
				if (num != 0)
				{
				}
				switch (num4)
				{
				case 0:
					if (hyperlink.Name == global::PreEmptive.SoS.Runtime.FixedLengthStream.b("귤裦黨뿪苬냮닰臲郴零跸黺뻼諾爀眂樄樆弈戊栌砎", a_))
					{
						num = (short)1877475333;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1338507267;
					num4 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					goto IL_27A;
				case 2:
					if (hyperlink.Name == global::PreEmptive.SoS.Runtime.FixedLengthStream.b("귤裦黨뿪苬냮듰诲鳴菶뫸軺軼课渀渂匄渆氈簊", a_))
					{
						num = (short)1445396491;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_27A;
				case 3:
					if (hyperlink.Name == global::PreEmptive.SoS.Runtime.FixedLengthStream.b("귤裦黨뿪苬냮볰鳲釴黶鿸苺뻼諾爀眂樄樆弈戊栌砎", a_))
					{
						num = (short)1361903625;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1663631362;
					num4 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					if (text != null)
					{
						num = (short)769130502;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 5:
					text = global::PreEmptive.SoS.Runtime.FixedLengthStream.b("ꛤ鋦髨鿪苬苮꟰髲郴胶ꗸ뗺飼裾䈀瘂瘄猆昈昊嬌明琐搒㬔漖砘瘚焜", a_);
					num = (short)1614479367;
					num4 = (int)((global::System.IntPtr)num);
					continue;
				case 6:
					this.Monitor1ClientFrame.Navigate(new global::System.Uri(text, global::System.UriKind.RelativeOrAbsolute));
					this.Monitor1ClientFrame.Visibility = global::System.Windows.Visibility.Visible;
					this.CustomerLogo.Visibility = global::System.Windows.Visibility.Collapsed;
					num = (short)2078277642;
					num4 = (int)((global::System.IntPtr)num);
					continue;
				case 7:
					goto IL_27A;
				case 8:
					IL_2D8:
					goto IL_27A;
				case 9:
					text = global::PreEmptive.SoS.Runtime.FixedLengthStream.b("ꛤ鋦髨鿪苬苮꟰髲郴胶ꗸ뛺鋼鯾栀攂簄䐆簈砊礌怎簐䔒簔爖渘㔚攜縞䰠伢", a_);
					num = (short)804388872;
					num4 = (int)((global::System.IntPtr)num);
					continue;
				case 10:
					return;
				case 11:
					num = (short)1070989313;
					if (num != 0)
					{
					}
					text = global::PreEmptive.SoS.Runtime.FixedLengthStream.b("ꛤ鋦髨鿪苬苮꟰髲郴胶ꗸ뻺藼雾甀樂欄怆䨈縊縌笎縐縒䌔縖簘氚㌜朞䀠丢䤤", a_);
					num = (short)1794048001;
					num4 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_BB;
				IL_27A:
				num = (short)930217988;
				num4 = (int)((global::System.IntPtr)num);
			}
			return;
			IL_BB:
			hyperlink = (global::System.Windows.Documents.Hyperlink)sender;
			text = null;
			num = (short)162004992;
			num4 = (int)((global::System.IntPtr)num);
			goto IL_13;
		}

		// Token: 0x060000A2 RID: 162 RVA: 0x00011970 File Offset: 0x0000FB70
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "5.0.10.0")]
		[global::System.Diagnostics.DebuggerNonUserCode]
		public void InitializeComponent()
		{
			int a_ = 12;
			short num = (short)1327280789;
			short num2 = num;
			num = (short)945402517;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)329121793;
				if (num != 0)
				{
				}
				num = (short)2125922304;
				if (num != 0)
				{
				}
				if (!this._contentLoaded)
				{
					this._contentLoaded = true;
					global::System.Uri resourceLocator = new global::System.Uri(global::PreEmptive.SoS.Runtime.FixedLengthStream.b("쏫꿭ꃯ꫱닳韵闷鏹郻蟽䏿刁圃㴅欇攉愋縍缏簑焓砕気㔙缛欝匟嘡䬣䬥帧䌩䤫夭Ἧ䈱唳儵崷夹䤻䴽㐿ⵁ⥃ぅⅇ⽉㭋㥍㕏㹑㝓㥕㕗㽙牛♝şཡࡣ", a_), global::System.UriKind.Relative);
					global::System.Windows.Application.LoadComponent(this, resourceLocator);
					return;
				}
				num = (short)957153280;
				short num3 = num;
				break;
			}
			}
		}

		// Token: 0x060000A3 RID: 163 RVA: 0x00011A50 File Offset: 0x0000FC50
		[global::System.Diagnostics.DebuggerNonUserCode]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "5.0.10.0")]
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		void global::System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
		{
			short num = (short)1637941249;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					num = (short)1357840386;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					switch (0)
					{
					case 0:
						goto IL_31;
					}
					continue;
				case 2:
					goto IL_1F3;
				}
				IL_31:
				switch (connectionId)
				{
				case 1:
					goto IL_32D;
				case 2:
					goto IL_306;
				case 3:
					goto IL_105;
				case 4:
					goto IL_205;
				case 5:
					goto IL_1F8;
				case 6:
					goto IL_EB;
				case 7:
					goto IL_150;
				case 8:
					goto IL_296;
				case 9:
					goto IL_212;
				case 10:
					goto IL_289;
				case 11:
					goto IL_2F9;
				case 12:
					goto IL_1A5;
				case 13:
					goto IL_239;
				case 14:
					goto IL_26F;
				case 15:
					goto IL_313;
				case 16:
					goto IL_143;
				case 17:
					goto IL_DE;
				case 18:
					goto IL_352;
				case 19:
					goto IL_27C;
				case 20:
					goto IL_320;
				case 21:
					goto IL_112;
				case 22:
					goto IL_D1;
				case 23:
					goto IL_345;
				case 24:
					goto IL_22C;
				case 25:
					goto IL_2EC;
				case 26:
					goto IL_F8;
				case 27:
					goto IL_21F;
				case 28:
					goto IL_15D;
				case 29:
					goto IL_11F;
				case 30:
					goto IL_35F;
				case 31:
					goto IL_181;
				default:
					num = (short)1406599168;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
			}
			IL_D1:
			this.path14 = (global::System.Windows.Shapes.Path)target;
			return;
			IL_DE:
			this.path10 = (global::System.Windows.Shapes.Path)target;
			return;
			IL_EB:
			this.path = (global::System.Windows.Shapes.Path)target;
			return;
			IL_F8:
			this.CustomerLogo = (global::System.Windows.Controls.Border)target;
			return;
			IL_105:
			this.backgroundImage = (global::System.Windows.Shapes.Rectangle)target;
			return;
			IL_112:
			this.path13 = (global::System.Windows.Shapes.Path)target;
			return;
			IL_11F:
			this.HowTo_CreateCustomView = (global::System.Windows.Documents.Hyperlink)target;
			this.HowTo_CreateCustomView.Click += this.OnHowToItemClick;
			return;
			IL_143:
			this.path9 = (global::System.Windows.Shapes.Path)target;
			return;
			IL_150:
			this.path1 = (global::System.Windows.Shapes.Path)target;
			return;
			IL_15D:
			this.HowToExp = (global::System.Windows.Controls.Expander)target;
			this.HowToExp.Collapsed += this.OnExpanderCollapsed;
			return;
			IL_181:
			this.HowTo_ExitCustomView = (global::System.Windows.Documents.Hyperlink)target;
			this.HowTo_ExitCustomView.Click += this.OnHowToItemClick;
			return;
			IL_1A5:
			num = (short)1709572097;
			if (num != 0)
			{
			}
			this.path6 = (global::System.Windows.Shapes.Path)target;
			return;
			IL_1F3:
			this._contentLoaded = true;
			return;
			IL_1F8:
			this.rectangle1 = (global::System.Windows.Shapes.Rectangle)target;
			return;
			IL_205:
			this.image = (global::System.Windows.Shapes.Rectangle)target;
			return;
			IL_212:
			this.path3 = (global::System.Windows.Shapes.Path)target;
			return;
			IL_21F:
			this.Expanders = (global::System.Windows.Controls.StackPanel)target;
			return;
			IL_22C:
			this.Monitor1 = (global::System.Windows.Controls.Viewbox)target;
			return;
			IL_239:
			num = (short)297664512;
			short num3 = num;
			this.path6_Copy = (global::System.Windows.Shapes.Path)target;
			return;
			IL_26F:
			this.path7 = (global::System.Windows.Shapes.Path)target;
			return;
			IL_27C:
			this.path12 = (global::System.Windows.Shapes.Path)target;
			return;
			IL_289:
			this.path4 = (global::System.Windows.Shapes.Path)target;
			return;
			IL_296:
			num = (short)235489802;
			short num4 = num;
			num = (short)1279085066;
			switch ((num4 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				goto IL_1F8;
			default:
				num = (short)622198784;
				if (num != 0)
				{
				}
				this.path2 = (global::System.Windows.Shapes.Path)target;
				return;
			}
			IL_2EC:
			this.Monitor1ClientFrame = (global::System.Windows.Controls.Frame)target;
			return;
			IL_2F9:
			this.path5 = (global::System.Windows.Shapes.Path)target;
			return;
			IL_306:
			this.LayoutRoot = (global::System.Windows.Controls.Viewbox)target;
			return;
			IL_313:
			this.path8 = (global::System.Windows.Shapes.Path)target;
			return;
			IL_320:
			this.ellipse = (global::System.Windows.Shapes.Ellipse)target;
			return;
			IL_32D:
			((global::MackinawCPS.PageCustomViewWelcome)target).Loaded += this.OnLoaded;
			return;
			IL_345:
			this.Main_Monitor_Art = (global::System.Windows.Controls.Viewbox)target;
			return;
			IL_352:
			this.path11 = (global::System.Windows.Shapes.Path)target;
			return;
			IL_35F:
			this.HowTo_ModifyCustomView = (global::System.Windows.Documents.Hyperlink)target;
			this.HowTo_ModifyCustomView.Click += this.OnHowToItemClick;
		}

		// Token: 0x0400004E RID: 78
		private string CustomBackgroudPath = string.Empty;

		// Token: 0x0400004F RID: 79
		private string VertexBackgroundPath = string.Empty;

		// Token: 0x04000050 RID: 80
		internal global::System.Windows.Controls.Viewbox LayoutRoot;

		// Token: 0x04000051 RID: 81
		internal global::System.Windows.Shapes.Rectangle backgroundImage;

		// Token: 0x04000052 RID: 82
		internal global::System.Windows.Shapes.Rectangle image;

		// Token: 0x04000053 RID: 83
		internal global::System.Windows.Shapes.Rectangle rectangle1;

		// Token: 0x04000054 RID: 84
		internal global::System.Windows.Shapes.Path path;

		// Token: 0x04000055 RID: 85
		internal global::System.Windows.Shapes.Path path1;

		// Token: 0x04000056 RID: 86
		internal global::System.Windows.Shapes.Path path2;

		// Token: 0x04000057 RID: 87
		internal global::System.Windows.Shapes.Path path3;

		// Token: 0x04000058 RID: 88
		internal global::System.Windows.Shapes.Path path4;

		// Token: 0x04000059 RID: 89
		internal global::System.Windows.Shapes.Path path5;

		// Token: 0x0400005A RID: 90
		internal global::System.Windows.Shapes.Path path6;

		// Token: 0x0400005B RID: 91
		internal global::System.Windows.Shapes.Path path6_Copy;

		// Token: 0x0400005C RID: 92
		internal global::System.Windows.Shapes.Path path7;

		// Token: 0x0400005D RID: 93
		internal global::System.Windows.Shapes.Path path8;

		// Token: 0x0400005E RID: 94
		internal global::System.Windows.Shapes.Path path9;

		// Token: 0x0400005F RID: 95
		internal global::System.Windows.Shapes.Path path10;

		// Token: 0x04000060 RID: 96
		internal global::System.Windows.Shapes.Path path11;

		// Token: 0x04000061 RID: 97
		internal global::System.Windows.Shapes.Path path12;

		// Token: 0x04000062 RID: 98
		internal global::System.Windows.Shapes.Ellipse ellipse;

		// Token: 0x04000063 RID: 99
		internal global::System.Windows.Shapes.Path path13;

		// Token: 0x04000064 RID: 100
		internal global::System.Windows.Shapes.Path path14;

		// Token: 0x04000065 RID: 101
		internal global::System.Windows.Controls.Viewbox Main_Monitor_Art;

		// Token: 0x04000066 RID: 102
		internal global::System.Windows.Controls.Viewbox Monitor1;

		// Token: 0x04000067 RID: 103
		internal global::System.Windows.Controls.Frame Monitor1ClientFrame;

		// Token: 0x04000068 RID: 104
		internal global::System.Windows.Controls.Border CustomerLogo;

		// Token: 0x04000069 RID: 105
		internal global::System.Windows.Controls.StackPanel Expanders;

		// Token: 0x0400006A RID: 106
		internal global::System.Windows.Controls.Expander HowToExp;

		// Token: 0x0400006B RID: 107
		internal global::System.Windows.Documents.Hyperlink HowTo_CreateCustomView;

		// Token: 0x0400006C RID: 108
		internal global::System.Windows.Documents.Hyperlink HowTo_ModifyCustomView;

		// Token: 0x0400006D RID: 109
		internal global::System.Windows.Documents.Hyperlink HowTo_ExitCustomView;

		// Token: 0x0400006E RID: 110
		private bool _contentLoaded;

		// Token: 0x0400006F RID: 111
		[global::System.NonSerialized]
		string VafgnaprSvryq = 32;
	}
}
