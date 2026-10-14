using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using AcpBusinessLayer;
using AcpUI;
using AcpUI.Common;
using ControlHeadGraphicView.converters;

namespace ControlHeadGraphicView
{
	// Token: 0x0200000A RID: 10
	public partial class O3GraphicView : UserControl
	{
		// Token: 0x060006F6 RID: 1782 RVA: 0x00063040 File Offset: 0x00061240
		public O3GraphicView()
		{
			int a_ = 7;
			base..ctor();
			this.InitializeComponent();
			base.DataContext = this;
			base.FlowDirection = FlowDirection.LeftToRight;
			if (Thread.CurrentThread.CurrentUICulture.Name == O9GraphicviewMenuItemsVisibilityConverter.b("䀱䄳", a_))
			{
				this.TopRightButtonCnvFeatureCanvas.Width = 28.0;
				this.TopRightButtonTrkFeatureCanvas.Width = 43.0;
				this.TopMiddleButtonCnvFeatureCanvas.Width = 28.0;
				this.TopMiddleButtonTrkFeatureCanvas.Width = 43.0;
				this.SideTopButtonCnvFeatureCanvas.Width = 28.0;
				this.SideTopButtonTrkFeatureCanvas.Width = 43.0;
				this.SideMiddleButtonCnvFeatureCanvas.Width = 28.0;
				this.SideMiddleButtonTrkFeatureCanvas.Width = 43.0;
				this.SideBottomButtonCnvFeatureCanvas.Width = 28.0;
				this.SideBottomButtonTrkFeatureCanvas.Width = 43.0;
			}
		}

		// Token: 0x17000366 RID: 870
		// (get) Token: 0x060006F7 RID: 1783 RVA: 0x00063164 File Offset: 0x00061364
		public static FlowDirection UIFlowDirection
		{
			get
			{
				if (Thread.CurrentThread.CurrentUICulture.TextInfo.IsRightToLeft)
				{
					short num;
					for (;;)
					{
						num = (short)1627914240;
						short num2 = num;
						num = (short)809714957;
						short num3 = num;
						num = (short)1352287501;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							goto IL_78;
						}
					}
					IL_78:
					num = (short)663683072;
					if (num != 0)
					{
					}
					num = (short)1564147713;
					if (num != 0)
					{
					}
					return FlowDirection.RightToLeft;
				}
				return FlowDirection.LeftToRight;
			}
		}

		// Token: 0x060006F8 RID: 1784 RVA: 0x00063228 File Offset: 0x00061428
		private void ShowAll(object sender, MouseButtonEventArgs e)
		{
			short num = (short)826428214;
			short num2 = num;
			num = (short)1581271862;
			switch (num2 == num)
			{
			}
			num = (short)1464336385;
			if (num != 0)
			{
			}
			num = (short)1810956288;
			if (num != 0)
			{
			}
			num = (short)366804992;
			short num3 = num;
			this.ShowAllButton.IsChecked = !this.ShowAllButton.IsChecked;
		}

		// Token: 0x060006F9 RID: 1785 RVA: 0x0006330C File Offset: 0x0006150C
		private void OnFieldNameDoubleClick(object sender, RoutedEventArgs e)
		{
			short num = (short)1777200335;
			short num2 = num;
			num = (short)1354099919;
			switch (num2 == num)
			{
			}
			num = (short)713359361;
			if (num != 0)
			{
			}
			num = (short)283246592;
			if (num != 0)
			{
			}
			num = (short)2064449536;
			short num3 = num;
			Utility.GetFieldHelpText(sender);
		}

		// Token: 0x060006FA RID: 1786 RVA: 0x000633BC File Offset: 0x000615BC
		private void StartScrollingAcpLabel(AcpLabel label, Canvas canvas, ref bool isAnimating, TranslateTransform translateTransform)
		{
			int a_ = 19;
			short num = (short)454492191;
			int num2 = (int)((IntPtr)num);
			DoubleAnimation doubleAnimation;
			for (;;)
			{
				string name;
				uint num5;
				switch (num2)
				{
				case 0:
					goto IL_288;
				case 1:
					num = (short)438698022;
					num2 = (int)((IntPtr)num);
					continue;
				case 2:
					if (!(name == O9GraphicviewMenuItemsVisibilityConverter.b("爽∿⹁ᝃ⽅ⱇ⽉ŋ❍㑏㙑㡓㍕ᩗ⽙⡛⩝ཟౡっ╥٧ᱩ㩫ݭᕯձᙳ᥵wⱹᵻች", a_)))
					{
						num = (short)248315925;
						num2 = (int)((IntPtr)num);
						continue;
					}
					doubleAnimation.Completed += this.SideMiddleButtonCnvFeature_AnimationCompleted;
					num = (short)1939603472;
					num2 = (int)((IntPtr)num);
					continue;
				case 3:
					num = (short)1153630226;
					num2 = (int)((IntPtr)num);
					continue;
				case 4:
					goto IL_43A;
				case 5:
				{
					if (!(name == O9GraphicviewMenuItemsVisibilityConverter.b("爽∿⹁ᝃ⽅ⱇ⽉ŋ❍㑏㙑㡓㍕ᩗ⽙⡛⩝ཟౡっᑥͧ㱩ի୭ݯၱ᭳๵⹷᭹ၻ୽", a_)))
					{
						num = (short)982908979;
						num2 = (int)((IntPtr)num);
						continue;
					}
					num = (short)1220608000;
					short num3 = num;
					doubleAnimation.Completed += this.SideMiddleButtonTrkFeature_AnimationCompleted;
					num = (short)1659895831;
					num2 = (int)((IntPtr)num);
					continue;
				}
				case 6:
				{
					num = (short)98536328;
					short num4 = num;
					num = (short)288787336;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_270;
					default:
						num = (short)1737293824;
						if (num != 0)
						{
						}
						if (num5 != 185994387U)
						{
							num = (short)1024720908;
							num2 = (int)((IntPtr)num);
							continue;
						}
						num = (short)541065252;
						num2 = (int)((IntPtr)num);
						continue;
					}
					break;
				}
				case 7:
					num = (short)594477124;
					num2 = (int)((IntPtr)num);
					continue;
				case 8:
					num = (short)946339874;
					num2 = (int)((IntPtr)num);
					continue;
				case 9:
					num = (short)865468446;
					num2 = (int)((IntPtr)num);
					continue;
				case 10:
					if (!(name == O9GraphicviewMenuItemsVisibilityConverter.b("爽∿⹁၃⥅㡇ᡉ╋⥍㡏♑ᙓ⍕ⱗ⹙㍛そ㑟ၡལづŧཀྵ᭫౭Ὧੱ≳᝵ᑷཹ᥻", a_)))
					{
						num = (short)1300824109;
						num2 = (int)((IntPtr)num);
						continue;
					}
					doubleAnimation.Completed += this.TopRightButtonTrkFeature_AnimationCompleted;
					num = (short)1042612241;
					num2 = (int)((IntPtr)num);
					continue;
				case 11:
					if (num5 != 2657655685U)
					{
						num = (short)732561447;
						num2 = (int)((IntPtr)num);
						continue;
					}
					num = (short)1453981745;
					num2 = (int)((IntPtr)num);
					continue;
				case 12:
					num = (short)102760510;
					num2 = (int)((IntPtr)num);
					continue;
				case 13:
					goto IL_C0A;
				case 14:
					if (num5 != 1042306767U)
					{
						num = (short)4587527;
						num2 = (int)((IntPtr)num);
						continue;
					}
					num = (short)2101674044;
					num2 = (int)((IntPtr)num);
					continue;
				case 15:
					if (num5 <= 1042306767U)
					{
						num = (short)1394933761;
						num2 = (int)((IntPtr)num);
						continue;
					}
					num = (short)942407705;
					num2 = (int)((IntPtr)num);
					continue;
				case 16:
					goto IL_90A;
				case 17:
					goto IL_1F0;
				case 18:
					goto IL_74A;
				case 19:
					goto IL_391;
				case 20:
					num = (short)285016135;
					num2 = (int)((IntPtr)num);
					continue;
				case 21:
					num = (short)1217789965;
					num2 = (int)((IntPtr)num);
					continue;
				case 22:
					num = (short)929693710;
					num2 = (int)((IntPtr)num);
					continue;
				case 23:
					goto IL_A2B;
				case 24:
					goto IL_C26;
				case 25:
					if (num5 <= 2207581327U)
					{
						num = (short)451477556;
						num2 = (int)((IntPtr)num);
						continue;
					}
					num = (short)564199435;
					num2 = (int)((IntPtr)num);
					continue;
				case 26:
					goto IL_343;
				case 27:
					if (num5 != 2886340297U)
					{
						num = (short)644546568;
						num2 = (int)((IntPtr)num);
						continue;
					}
					num = (short)426049538;
					num2 = (int)((IntPtr)num);
					continue;
				case 28:
					if (num5 != 1360389820U)
					{
						num = (short)892272649;
						num2 = (int)((IntPtr)num);
						continue;
					}
					num = (short)1482620971;
					num2 = (int)((IntPtr)num);
					continue;
				case 29:
					goto IL_86E;
				case 30:
					if (num5 != 2207581327U)
					{
						num = (short)483196987;
						num2 = (int)((IntPtr)num);
						continue;
					}
					num = (short)509083712;
					num2 = (int)((IntPtr)num);
					continue;
				case 31:
					switch (0)
					{
					case 0:
						goto IL_14E;
					}
					continue;
				case 32:
					goto IL_671;
				case 33:
					if (num5 != 2884153726U)
					{
						num = (short)450953285;
						num2 = (int)((IntPtr)num);
						continue;
					}
					num = (short)85262346;
					num2 = (int)((IntPtr)num);
					continue;
				case 34:
					goto IL_A48;
				case 35:
					num = (short)54460472;
					num2 = (int)((IntPtr)num);
					continue;
				case 36:
					if (!(name == O9GraphicviewMenuItemsVisibilityConverter.b("爽∿⹁ᝃ⽅ⱇ⽉๋⅍⑏♑㭓㭕ᩗ⽙⡛⩝ཟౡっᑥͧ㱩ի୭ݯၱ᭳๵⹷᭹ၻ୽", a_)))
					{
						num = (short)1106706473;
						num2 = (int)((IntPtr)num);
						continue;
					}
					doubleAnimation.Completed += this.SideBottomButtonTrkFeature_AnimationCompleted;
					num = (short)748879914;
					num2 = (int)((IntPtr)num);
					continue;
				case 37:
					goto IL_AB7;
				case 38:
					if (num5 <= 185994387U)
					{
						num = (short)1495793684;
						num2 = (int)((IntPtr)num);
						continue;
					}
					num = (short)1442971702;
					num2 = (int)((IntPtr)num);
					continue;
				case 39:
					num = (short)1076690945;
					if (num != 0)
					{
					}
					num = (short)233177121;
					num2 = (int)((IntPtr)num);
					continue;
				case 40:
					num = (short)1952251952;
					num2 = (int)((IntPtr)num);
					continue;
				case 41:
					num = (short)2105671750;
					num2 = (int)((IntPtr)num);
					continue;
				case 42:
					goto IL_BD5;
				case 43:
					if (!(name == O9GraphicviewMenuItemsVisibilityConverter.b("爽∿⹁၃⥅㡇ᡉ╋⥍㡏♑ᝓ㡕⹗ౙ㕛㭝᝟aୣṥ㹧୩k᭭ᕯ", a_)))
					{
						num = (short)260046905;
						num2 = (int)((IntPtr)num);
						continue;
					}
					doubleAnimation.Completed += this.TopRightButtonCnvFeature_AnimationCompleted;
					num = (short)947519520;
					num2 = (int)((IntPtr)num);
					continue;
				case 44:
					if (!(name == O9GraphicviewMenuItemsVisibilityConverter.b("爽∿⹁၃⥅㡇݉╋⩍㑏㹑ㅓᑕⵗ⹙⡛ㅝ๟Ⅱ੣ၥ㹧ͩ५ᥭቯᵱ౳⁵᥷ᙹॻ᭽", a_)))
					{
						num = (short)2040135747;
						num2 = (int)((IntPtr)num);
						continue;
					}
					doubleAnimation.Completed += this.TopMiddleButtonCnvFeature_AnimationCompleted;
					num = (short)597098533;
					num2 = (int)((IntPtr)num);
					continue;
				case 45:
					num = (short)671809565;
					num2 = (int)((IntPtr)num);
					continue;
				case 46:
					if (!(name == O9GraphicviewMenuItemsVisibilityConverter.b("爽∿⹁ᝃ⽅ⱇ⽉ᡋ⅍⁏ၑ⅓≕ⱗ㕙㉛ᵝ๟ᑡ㉣ཥ൧ᵩ๫ŭ࡯⑱ᕳ᩵൷ό", a_)))
					{
						num = (short)1243676712;
						num2 = (int)((IntPtr)num);
						continue;
					}
					doubleAnimation.Completed += this.SideTopButtonCnvFeature_AnimationCompleted;
					num = (short)1209991234;
					num2 = (int)((IntPtr)num);
					continue;
				case 47:
					num = (short)1533280306;
					num2 = (int)((IntPtr)num);
					continue;
				case 48:
					goto IL_1A5;
				case 49:
					if (!(name == O9GraphicviewMenuItemsVisibilityConverter.b("爽∿⹁ᝃ⽅ⱇ⽉๋⅍⑏♑㭓㭕ᩗ⽙⡛⩝ཟౡっ╥٧ᱩ㩫ݭᕯձᙳ᥵wⱹᵻችꒃ", a_)))
					{
						num = (short)1533018165;
						num2 = (int)((IntPtr)num);
						continue;
					}
					doubleAnimation.Completed += this.SideBottomButtonCnvFeature_AnimationCompleted;
					num = (short)624230463;
					num2 = (int)((IntPtr)num);
					continue;
				case 50:
					if (num5 != 311839953U)
					{
						num = (short)1117192214;
						num2 = (int)((IntPtr)num);
						continue;
					}
					num = (short)748748846;
					num2 = (int)((IntPtr)num);
					continue;
				case 51:
					num = (short)735313978;
					num2 = (int)((IntPtr)num);
					continue;
				case 52:
					num = (short)1338376220;
					num2 = (int)((IntPtr)num);
					continue;
				case 53:
					num = (short)847904833;
					num2 = (int)((IntPtr)num);
					continue;
				case 54:
					if (num5 != 283265277U)
					{
						num = (short)770441263;
						num2 = (int)((IntPtr)num);
						continue;
					}
					num = (short)1380777989;
					num2 = (int)((IntPtr)num);
					continue;
				case 55:
					num = (short)1054998534;
					num2 = (int)((IntPtr)num);
					continue;
				case 56:
					goto IL_BA6;
				case 57:
					num = (short)2068447251;
					num2 = (int)((IntPtr)num);
					continue;
				case 58:
					goto IL_189;
				case 59:
					num = (short)125370372;
					num2 = (int)((IntPtr)num);
					continue;
				case 60:
					if (!(name == O9GraphicviewMenuItemsVisibilityConverter.b("爽∿⹁၃⥅㡇݉╋⩍㑏㹑ㅓᑕⵗ⹙⡛ㅝ๟㙡ᙣ൥㹧ͩ५ᥭቯᵱ౳⁵᥷ᙹॻ᭽", a_)))
					{
						num = (short)526254083;
						num2 = (int)((IntPtr)num);
						continue;
					}
					doubleAnimation.Completed += this.TopMiddleButtonTrkFeature_AnimationCompleted;
					num = (short)1364983834;
					num2 = (int)((IntPtr)num);
					continue;
				case 61:
					goto IL_16D;
				case 62:
					goto IL_20D;
				case 63:
					goto IL_373;
				case 64:
					if (!(name == O9GraphicviewMenuItemsVisibilityConverter.b("爽∿⹁ᝃ⽅ⱇ⽉ᡋ⅍⁏ၑ⅓≕ⱗ㕙㉛੝቟ॡ㉣ཥ൧ᵩ๫ŭ࡯⑱ᕳ᩵൷ό", a_)))
					{
						num = (short)448987171;
						num2 = (int)((IntPtr)num);
						continue;
					}
					doubleAnimation.Completed += this.SideTopButtonTrkFeature_AnimationCompleted;
					goto IL_270;
				case 65:
					goto IL_BEE;
				case 66:
					goto IL_469;
				case 67:
					num = (short)1830420504;
					num2 = (int)((IntPtr)num);
					continue;
				case 68:
					goto IL_1C1;
				case 69:
					num = (short)748355611;
					num2 = (int)((IntPtr)num);
					continue;
				case 70:
					goto IL_88C;
				case 71:
					if (num5 != 38910225U)
					{
						num = (short)1903296567;
						num2 = (int)((IntPtr)num);
						continue;
					}
					num = (short)297533484;
					num2 = (int)((IntPtr)num);
					continue;
				}
				IL_14E:
				if (isAnimating)
				{
					num = (short)1426915389;
					num2 = (int)((IntPtr)num);
					continue;
				}
				isAnimating = true;
				doubleAnimation = new DoubleAnimation();
				doubleAnimation.From = new double?(0.0);
				doubleAnimation.To = new double?(0.0 - label.ActualWidth);
				doubleAnimation.Duration = new Duration(TimeSpan.FromSeconds(label.ActualWidth / 45.0));
				doubleAnimation.FillBehavior = FillBehavior.Stop;
				translateTransform.BeginAnimation(TranslateTransform.XProperty, doubleAnimation);
				name = label.Name;
				num5 = <PrivateImplementationDetails>.ComputeStringHash(name);
				num = (short)1218838543;
				num2 = (int)((IntPtr)num);
				continue;
				IL_270:
				num = (short)958332928;
				num2 = (int)((IntPtr)num);
			}
			IL_16D:
			translateTransform.BeginAnimation(TranslateTransform.XProperty, null);
			isAnimating = false;
			return;
			IL_189:
			IL_1A5:
			IL_1C1:
			IL_1F0:
			IL_20D:
			IL_288:
			IL_343:
			IL_373:
			IL_391:
			IL_43A:
			IL_469:
			IL_671:
			IL_74A:
			IL_86E:
			IL_88C:
			IL_90A:
			IL_A2B:
			IL_A48:
			IL_AB7:
			IL_BA6:
			IL_BD5:
			IL_BEE:
			IL_C0A:
			IL_C26:
			translateTransform.BeginAnimation(TranslateTransform.XProperty, doubleAnimation);
		}

		// Token: 0x060006FB RID: 1787 RVA: 0x00064004 File Offset: 0x00062204
		private void MouseEnterHHCHButtonCnvFeatureLabel(object sender, MouseEventArgs e)
		{
			int a_ = 16;
			switch (0)
			{
			case 0:
				goto IL_31;
			}
			int num;
			AcpLabel acpLabel;
			short num2;
			for (;;)
			{
				IL_13:
				switch (num)
				{
				case 0:
				{
					if (acpLabel.ActualWidth <= 65.0)
					{
						goto IL_1AC;
					}
					num2 = (short)1697850188;
					short num3 = num2;
					num2 = (short)1214063436;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_1A0;
					default:
						num2 = (short)1841561600;
						if (num2 != 0)
						{
						}
						num2 = (short)1369899012;
						num = (int)((IntPtr)num2);
						continue;
					}
					break;
				}
				case 1:
					if (acpLabel.ActualWidth > 28.0)
					{
						num2 = (short)1851916293;
						num = (int)((IntPtr)num2);
						continue;
					}
					goto IL_145;
				case 2:
					if (Thread.CurrentThread.CurrentUICulture.Name == O9GraphicviewMenuItemsVisibilityConverter.b("䤺䠼", a_))
					{
						num2 = (short)1791623171;
						num = (int)((IntPtr)num2);
						continue;
					}
					num2 = (short)1246822400;
					num = (int)((IntPtr)num2);
					continue;
				case 3:
					num2 = (short)251789313;
					num = (int)((IntPtr)num2);
					continue;
				case 4:
					goto IL_119;
				case 5:
					goto IL_192;
				}
				goto IL_31;
			}
			IL_119:
			num2 = (short)437256192;
			short num4 = num2;
			acpLabel.Cursor = Cursors.Hand;
			return;
			IL_145:
			acpLabel.Cursor = Cursors.Arrow;
			return;
			IL_192:
			IL_1A0:
			acpLabel.Cursor = Cursors.Hand;
			return;
			IL_1AC:
			num2 = (short)1849032705;
			if (num2 != 0)
			{
			}
			acpLabel.Cursor = Cursors.Arrow;
			return;
			IL_31:
			acpLabel = (sender as AcpLabel);
			num2 = (short)704184322;
			num = (int)((IntPtr)num2);
			goto IL_13;
		}

		// Token: 0x060006FC RID: 1788 RVA: 0x000641F0 File Offset: 0x000623F0
		private void MouseEnterHHCHButtonTrkFeatureLabel(object sender, MouseEventArgs e)
		{
			int a_ = 5;
			switch (0)
			{
			case 0:
				goto IL_31;
			}
			int num;
			AcpLabel acpLabel;
			short num2;
			for (;;)
			{
				IL_13:
				switch (num)
				{
				case 0:
				{
					if (acpLabel.ActualWidth <= 65.0)
					{
						goto IL_1CE;
					}
					num2 = (short)1970636507;
					short num3 = num2;
					num2 = (short)535922395;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_1C2;
					default:
					{
						num2 = (short)794296320;
						if (num2 != 0)
						{
						}
						num2 = (short)653524992;
						short num4 = num2;
						num2 = (short)1533018116;
						num = (int)((IntPtr)num2);
						continue;
					}
					}
					break;
				}
				case 1:
					if (acpLabel.ActualWidth > 43.0)
					{
						num2 = (short)1362755589;
						num = (int)((IntPtr)num2);
						continue;
					}
					goto IL_168;
				case 2:
					if (Thread.CurrentThread.CurrentUICulture.Name == O9GraphicviewMenuItemsVisibilityConverter.b("䈯䜱", a_))
					{
						num2 = (short)325124099;
						num = (int)((IntPtr)num2);
						continue;
					}
					num2 = (short)1797324800;
					num = (int)((IntPtr)num2);
					continue;
				case 3:
					num2 = (short)1168048129;
					if (num2 != 0)
					{
					}
					num2 = (short)634257409;
					num = (int)((IntPtr)num2);
					continue;
				case 4:
					goto IL_166;
				case 5:
					goto IL_1B4;
				}
				goto IL_31;
			}
			IL_166:
			acpLabel.Cursor = Cursors.Hand;
			return;
			IL_168:
			acpLabel.Cursor = Cursors.Arrow;
			return;
			IL_1B4:
			IL_1C2:
			acpLabel.Cursor = Cursors.Hand;
			return;
			IL_1CE:
			acpLabel.Cursor = Cursors.Arrow;
			return;
			IL_31:
			acpLabel = (sender as AcpLabel);
			num2 = (short)953942018;
			num = (int)((IntPtr)num2);
			goto IL_13;
		}

		// Token: 0x060006FD RID: 1789 RVA: 0x000643D8 File Offset: 0x000625D8
		private void HHCHButtonLabelChanged(object sender, SizeChangedEventArgs e)
		{
			int a_ = 10;
			switch (0)
			{
			case 0:
				goto IL_29;
			}
			int num;
			short num2;
			AcpLabel acpLabel;
			for (;;)
			{
				IL_13:
				switch (num)
				{
				case 0:
					goto IL_7C;
				case 1:
					if (Thread.CurrentThread.CurrentUICulture.Name == O9GraphicviewMenuItemsVisibilityConverter.b("䜴䈶", a_))
					{
						num2 = (short)994902016;
						num = (int)((IntPtr)num2);
						continue;
					}
					num2 = (short)159842306;
					num = (int)((IntPtr)num2);
					continue;
				case 2:
				{
					num2 = (short)658240115;
					short num3 = num2;
					num2 = (short)731443827;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_180;
					default:
						num2 = (short)391839744;
						if (num2 != 0)
						{
						}
						if (acpLabel.ActualWidth < 50.0)
						{
							num2 = (short)275906563;
							num = (int)((IntPtr)num2);
							continue;
						}
						goto IL_180;
					}
					break;
				}
				case 3:
					goto IL_16B;
				}
				goto IL_29;
			}
			IL_7C:
			num2 = (short)351338496;
			short num4 = num2;
			num2 = (short)546111489;
			if (num2 != 0)
			{
			}
			Canvas.SetLeft(acpLabel, 7.0);
			return;
			IL_16B:
			Canvas.SetLeft(acpLabel, 10.0);
			return;
			IL_180:
			Canvas.SetLeft(acpLabel, 8.0);
			return;
			IL_29:
			acpLabel = (sender as AcpLabel);
			num2 = (short)151715841;
			num = (int)((IntPtr)num2);
			goto IL_13;
		}

		// Token: 0x060006FE RID: 1790 RVA: 0x00064574 File Offset: 0x00062774
		private void TopRightButtonCnvFeature_AnimationCompleted(object sender, EventArgs e)
		{
			short num = (short)1847261119;
			short num2 = num;
			num = (short)1799485375;
			switch (num2 == num)
			{
			}
			num = (short)1531707393;
			if (num != 0)
			{
			}
			num = (short)1619329024;
			short num3 = num;
			num = (short)384040960;
			if (num != 0)
			{
			}
			this.isTopRightButtonCnvFeatureAnimating = false;
		}

		// Token: 0x060006FF RID: 1791 RVA: 0x00064624 File Offset: 0x00062824
		private void TopRightButtonTrkFeature_AnimationCompleted(object sender, EventArgs e)
		{
			short num = (short)423523033;
			short num2 = num;
			num = (short)321614553;
			switch (num2 == num)
			{
			}
			num = (short)1824129025;
			if (num != 0)
			{
			}
			num = (short)2114715648;
			short num3 = num;
			num = (short)1871511552;
			if (num != 0)
			{
			}
			this.isTopRightButtonTrkFeatureAnimating = false;
		}

		// Token: 0x06000700 RID: 1792 RVA: 0x000646D4 File Offset: 0x000628D4
		private void ScrollingTopRightButtonCnvFeatureLabel(object sender, MouseButtonEventArgs e)
		{
			int a_ = 8;
			short num = (short)1860894721;
			int num2 = (int)((IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_19E;
				case 1:
				{
					num = (short)2052325376;
					short num3 = num;
					switch (0)
					{
					case 0:
						goto IL_72;
					}
					continue;
				}
				case 2:
					goto IL_1CB;
				case 3:
					return;
				case 4:
				{
					num = (short)1926365185;
					if (num != 0)
					{
					}
					num = (short)1089526739;
					short num4 = num;
					num = (short)121811;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_19E;
					default:
						num = (short)1693450240;
						if (num != 0)
						{
						}
						this.StartScrollingAcpLabel(this.LblTopRightCnvViewboxValue, this.TopRightButtonCnvFeatureCanvas, ref this.isTopRightButtonCnvFeatureAnimating, this.RenderTransformTopRightButtonCnvFeatureViewbox);
						num = (short)1075445763;
						num2 = (int)((IntPtr)num);
						continue;
					}
					break;
				}
				case 5:
					if ((sender as AcpLabel).ActualWidth > 65.0)
					{
						num = (short)463536132;
						num2 = (int)((IntPtr)num);
						continue;
					}
					return;
				case 6:
					num = (short)1253376000;
					num2 = (int)((IntPtr)num);
					continue;
				}
				IL_72:
				if (Thread.CurrentThread.CurrentUICulture.Name == O9GraphicviewMenuItemsVisibilityConverter.b("䄲䀴", a_))
				{
					num = (short)1858863110;
					num2 = (int)((IntPtr)num);
					continue;
				}
				num = (short)2002780165;
				num2 = (int)((IntPtr)num);
				continue;
				IL_19E:
				if ((sender as AcpLabel).ActualWidth <= 28.0)
				{
					return;
				}
				num = (short)600506370;
				num2 = (int)((IntPtr)num);
			}
			IL_1CB:
			this.StartScrollingAcpLabel(this.LblTopRightCnvViewboxValue, this.TopRightButtonCnvFeatureCanvas, ref this.isTopRightButtonCnvFeatureAnimating, this.RenderTransformTopRightButtonCnvFeatureViewbox);
		}

		// Token: 0x06000701 RID: 1793 RVA: 0x000648E8 File Offset: 0x00062AE8
		private void ScrollingTopRightButtonTrkFeatureLabel(object sender, MouseButtonEventArgs e)
		{
			int a_ = 10;
			switch (0)
			{
			case 0:
				goto IL_35;
			}
			int num;
			AcpLabel acpLabel;
			short num2;
			for (;;)
			{
				IL_13:
				switch (num)
				{
				case 0:
					if (acpLabel.ActualWidth > 43.0)
					{
						num2 = (short)1194786818;
						num = (int)((IntPtr)num2);
						continue;
					}
					return;
				case 1:
					if (Thread.CurrentThread.CurrentUICulture.Name == O9GraphicviewMenuItemsVisibilityConverter.b("䜴䈶", a_))
					{
						num2 = (short)1889075206;
						num = (int)((IntPtr)num2);
						continue;
					}
					num2 = (short)1489305605;
					num = (int)((IntPtr)num2);
					continue;
				case 2:
					goto IL_1CC;
				case 3:
					return;
				case 4:
				{
					num2 = (short)235601921;
					if (num2 != 0)
					{
					}
					num2 = (short)1402527410;
					short num3 = num2;
					num2 = (short)1889918642;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						continue;
					case 1:
						break;
					default:
					{
						num2 = (short)856031232;
						short num4 = num2;
						break;
					}
					}
					num2 = (short)1253572608;
					if (num2 != 0)
					{
					}
					this.StartScrollingAcpLabel(this.LblTopRightButtonTrkViewboxValue, this.TopRightButtonTrkFeatureCanvas, ref this.isTopRightButtonTrkFeatureAnimating, this.RenderTransformTopRightButtonTrkFeatureViewbox);
					num2 = (short)2121269251;
					num = (int)((IntPtr)num2);
					continue;
				}
				case 5:
					if (acpLabel.ActualWidth > 65.0)
					{
						num2 = (short)1949892612;
						num = (int)((IntPtr)num2);
						continue;
					}
					return;
				case 6:
					num2 = (short)366018560;
					num = (int)((IntPtr)num2);
					continue;
				}
				goto IL_35;
			}
			IL_1CC:
			this.StartScrollingAcpLabel(this.LblTopRightButtonTrkViewboxValue, this.TopRightButtonTrkFeatureCanvas, ref this.isTopRightButtonTrkFeatureAnimating, this.RenderTransformTopRightButtonTrkFeatureViewbox);
			return;
			IL_35:
			acpLabel = (sender as AcpLabel);
			num2 = (short)1655111681;
			num = (int)((IntPtr)num2);
			goto IL_13;
		}

		// Token: 0x06000702 RID: 1794 RVA: 0x00064AFC File Offset: 0x00062CFC
		private void TopMiddleButtonCnvFeature_AnimationCompleted(object sender, EventArgs e)
		{
			short num = (short)1584587258;
			short num2 = num;
			num = (short)48947706;
			switch (num2 == num)
			{
			}
			num = (short)1867120640;
			short num3 = num;
			num = (short)1989017600;
			if (num != 0)
			{
			}
			num = (short)662044673;
			if (num != 0)
			{
			}
			this.isTopMiddleButtonCnvFeatureAnimating = false;
		}

		// Token: 0x06000703 RID: 1795 RVA: 0x00064BB0 File Offset: 0x00062DB0
		private void TopMiddleButtonTrkFeature_AnimationCompleted(object sender, EventArgs e)
		{
			short num = (short)753442565;
			short num2 = num;
			num = (short)2051186437;
			switch (num2 == num)
			{
			}
			num = (short)1807482880;
			short num3 = num;
			num = (short)99942400;
			if (num != 0)
			{
			}
			num = (short)554893313;
			if (num != 0)
			{
			}
			this.isTopMiddleButtonTrkFeatureAnimating = false;
		}

		// Token: 0x06000704 RID: 1796 RVA: 0x00064C64 File Offset: 0x00062E64
		private void ScrollingTopMiddleButtonCnvFeatureLabel(object sender, MouseButtonEventArgs e)
		{
			int a_ = 16;
			switch (0)
			{
			case 0:
				goto IL_35;
			}
			int num;
			AcpLabel acpLabel;
			short num2;
			for (;;)
			{
				IL_13:
				switch (num)
				{
				case 0:
					if (acpLabel.ActualWidth > 28.0)
					{
						num2 = (short)1316880386;
						num = (int)((IntPtr)num2);
						continue;
					}
					return;
				case 1:
					if (Thread.CurrentThread.CurrentUICulture.Name == O9GraphicviewMenuItemsVisibilityConverter.b("䤺䠼", a_))
					{
						num2 = (short)1901658118;
						num = (int)((IntPtr)num2);
						continue;
					}
					num2 = (short)1937113093;
					num = (int)((IntPtr)num2);
					continue;
				case 2:
					goto IL_1CD;
				case 3:
					return;
				case 4:
				{
					num2 = (short)1240556386;
					short num3 = num2;
					num2 = (short)447636322;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						continue;
					default:
					{
						num2 = (short)1445462016;
						short num4 = num2;
						num2 = (short)398000129;
						if (num2 != 0)
						{
						}
						num2 = (short)1111359488;
						if (num2 != 0)
						{
						}
						this.StartScrollingAcpLabel(this.LblTopMiddleButtonCnvViewboxValue, this.TopMiddleButtonCnvFeatureCanvas, ref this.isTopMiddleButtonCnvFeatureAnimating, this.RenderTransformTopMiddleButtonCnvFeatureViewbox);
						num2 = (short)1768357891;
						num = (int)((IntPtr)num2);
						continue;
					}
					}
					break;
				}
				case 5:
					if (acpLabel.ActualWidth > 65.0)
					{
						num2 = (short)901382148;
						num = (int)((IntPtr)num2);
						continue;
					}
					return;
				case 6:
					num2 = (short)225705984;
					num = (int)((IntPtr)num2);
					continue;
				}
				goto IL_35;
			}
			IL_1CD:
			this.StartScrollingAcpLabel(this.LblTopMiddleButtonCnvViewboxValue, this.TopMiddleButtonCnvFeatureCanvas, ref this.isTopMiddleButtonCnvFeatureAnimating, this.RenderTransformTopMiddleButtonCnvFeatureViewbox);
			return;
			IL_35:
			acpLabel = (sender as AcpLabel);
			num2 = (short)1247477761;
			num = (int)((IntPtr)num2);
			goto IL_13;
		}

		// Token: 0x06000705 RID: 1797 RVA: 0x00064E78 File Offset: 0x00063078
		private void ScrollingTopMiddleButtonTrkFeatureLabel(object sender, MouseButtonEventArgs e)
		{
			int a_ = 19;
			switch (0)
			{
			case 0:
				goto IL_35;
			}
			int num;
			AcpLabel acpLabel;
			short num2;
			for (;;)
			{
				IL_13:
				switch (num)
				{
				case 0:
					if (acpLabel.ActualWidth > 43.0)
					{
						num2 = (short)1189937154;
						num = (int)((IntPtr)num2);
						continue;
					}
					return;
				case 1:
					if (Thread.CurrentThread.CurrentUICulture.Name == O9GraphicviewMenuItemsVisibilityConverter.b("䰽㔿", a_))
					{
						num2 = (short)2095841286;
						num = (int)((IntPtr)num2);
						continue;
					}
					num2 = (short)502202373;
					num = (int)((IntPtr)num2);
					continue;
				case 2:
					goto IL_1CE;
				case 3:
					return;
				case 4:
				{
					num2 = (short)476964047;
					short num3 = num2;
					num2 = (short)1534846159;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						continue;
					case 1:
						break;
					default:
					{
						num2 = (short)85458944;
						short num4 = num2;
						break;
					}
					}
					num2 = (short)576913408;
					if (num2 != 0)
					{
					}
					this.StartScrollingAcpLabel(this.LblTopMiddleButtonTrkViewboxValue, this.TopMiddleButtonTrkFeatureCanvas, ref this.isTopMiddleButtonTrkFeatureAnimating, this.RenderTransformTopMiddleButtonTrkFeatureViewbox);
					num2 = (short)1559166979;
					num = (int)((IntPtr)num2);
					continue;
				}
				case 5:
					if (acpLabel.ActualWidth > 65.0)
					{
						num2 = (short)97583108;
						num = (int)((IntPtr)num2);
						continue;
					}
					return;
				case 6:
					num2 = (short)692715520;
					num = (int)((IntPtr)num2);
					continue;
				}
				goto IL_35;
			}
			IL_1CE:
			this.StartScrollingAcpLabel(this.LblTopMiddleButtonTrkViewboxValue, this.TopMiddleButtonTrkFeatureCanvas, ref this.isTopMiddleButtonTrkFeatureAnimating, this.RenderTransformTopMiddleButtonTrkFeatureViewbox);
			return;
			IL_35:
			num2 = (short)1882652673;
			if (num2 != 0)
			{
			}
			acpLabel = (sender as AcpLabel);
			num2 = (short)617152513;
			num = (int)((IntPtr)num2);
			goto IL_13;
		}

		// Token: 0x06000706 RID: 1798 RVA: 0x00065090 File Offset: 0x00063290
		private void SideTopButtonCnvFeature_AnimationCompleted(object sender, EventArgs e)
		{
			short num = (short)608260938;
			short num2 = num;
			num = (short)511988554;
			switch (num2 == num)
			{
			}
			num = (short)1271070720;
			short num3 = num;
			num = (short)943849473;
			if (num != 0)
			{
			}
			num = (short)547160064;
			if (num != 0)
			{
			}
			this.isSideTopButtonCnvFeatureAnimating = false;
		}

		// Token: 0x06000707 RID: 1799 RVA: 0x00065140 File Offset: 0x00063340
		private void SideTopButtonTrkFeature_AnimationCompleted(object sender, EventArgs e)
		{
			short num = (short)49833920;
			short num2 = num;
			num = (short)38168512;
			switch (num2 == num)
			{
			}
			num = (short)655818752;
			short num3 = num;
			num = (short)1963786240;
			if (num != 0)
			{
			}
			num = (short)2010775553;
			if (num != 0)
			{
			}
			this.isSideTopButtonTrkFeatureAnimating = false;
		}

		// Token: 0x06000708 RID: 1800 RVA: 0x000651F0 File Offset: 0x000633F0
		private void ScrollingSideTopButtonCnvFeatureLabel(object sender, MouseButtonEventArgs e)
		{
			int a_ = 13;
			switch (0)
			{
			case 0:
				goto IL_35;
			}
			int num;
			AcpLabel acpLabel;
			short num2;
			for (;;)
			{
				IL_13:
				switch (num)
				{
				case 0:
					if (acpLabel.ActualWidth > 28.0)
					{
						num2 = (short)791740418;
						num = (int)((IntPtr)num2);
						continue;
					}
					return;
				case 1:
					if (Thread.CurrentThread.CurrentUICulture.Name == O9GraphicviewMenuItemsVisibilityConverter.b("䨷伹", a_))
					{
						num2 = (short)1528823809;
						if (num2 != 0)
						{
						}
						num2 = (short)1381040134;
						num = (int)((IntPtr)num2);
						continue;
					}
					num2 = (short)1749745669;
					num = (int)((IntPtr)num2);
					continue;
				case 2:
					goto IL_1D3;
				case 3:
					return;
				case 4:
				{
					num2 = (short)516950287;
					short num3 = num2;
					num2 = (short)159975695;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						continue;
					case 1:
						break;
					default:
					{
						num2 = (short)1761345536;
						short num4 = num2;
						break;
					}
					}
					num2 = (short)1216413696;
					if (num2 != 0)
					{
					}
					this.StartScrollingAcpLabel(this.LblSideTopButtonCnvViewboxValue, this.SideTopButtonCnvFeatureCanvas, ref this.isSideTopButtonCnvFeatureAnimating, this.RenderTransformSideTopButtonCnvFeatureViewbox);
					num2 = (short)73728003;
					num = (int)((IntPtr)num2);
					continue;
				}
				case 5:
					if (acpLabel.ActualWidth > 65.0)
					{
						num2 = (short)2054946820;
						num = (int)((IntPtr)num2);
						continue;
					}
					return;
				case 6:
					num2 = (short)951517184;
					num = (int)((IntPtr)num2);
					continue;
				}
				goto IL_35;
			}
			IL_1D3:
			this.StartScrollingAcpLabel(this.LblSideTopButtonCnvViewboxValue, this.SideTopButtonCnvFeatureCanvas, ref this.isSideTopButtonCnvFeatureAnimating, this.RenderTransformSideTopButtonCnvFeatureViewbox);
			return;
			IL_35:
			acpLabel = (sender as AcpLabel);
			num2 = (short)545783809;
			num = (int)((IntPtr)num2);
			goto IL_13;
		}

		// Token: 0x06000709 RID: 1801 RVA: 0x0006540C File Offset: 0x0006360C
		private void ScrollingSideTopButtonTrkFeatureLabel(object sender, MouseButtonEventArgs e)
		{
			int a_ = 14;
			switch (0)
			{
			case 0:
				goto IL_35;
			}
			int num;
			AcpLabel acpLabel;
			short num2;
			for (;;)
			{
				IL_13:
				switch (num)
				{
				case 0:
					if (acpLabel.ActualWidth > 43.0)
					{
						num2 = (short)1500250114;
						num = (int)((IntPtr)num2);
						continue;
					}
					return;
				case 1:
					if (Thread.CurrentThread.CurrentUICulture.Name == O9GraphicviewMenuItemsVisibilityConverter.b("䬸为", a_))
					{
						num2 = (short)108855302;
						num = (int)((IntPtr)num2);
						continue;
					}
					num2 = (short)517537797;
					num = (int)((IntPtr)num2);
					continue;
				case 2:
					goto IL_1A7;
				case 3:
					return;
				case 4:
				{
					num2 = (short)1556134349;
					short num3 = num2;
					num2 = (short)1630583245;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						continue;
					default:
					{
						num2 = (short)2100690944;
						short num4 = num2;
						num2 = (short)168296448;
						if (num2 != 0)
						{
						}
						this.StartScrollingAcpLabel(this.LblSideTopButtonTrkViewboxValue, this.SideTopButtonTrkFeatureCanvas, ref this.isSideTopButtonTrkFeatureAnimating, this.RenderTransformSideTopButtonTrkFeatureViewbox);
						num2 = (short)1722810369;
						if (num2 != 0)
						{
						}
						num2 = (short)1386676227;
						num = (int)((IntPtr)num2);
						continue;
					}
					}
					break;
				}
				case 5:
					if (acpLabel.ActualWidth > 65.0)
					{
						num2 = (short)1772486660;
						num = (int)((IntPtr)num2);
						continue;
					}
					return;
				case 6:
					num2 = (short)1394147328;
					num = (int)((IntPtr)num2);
					continue;
				}
				goto IL_35;
			}
			IL_1A7:
			this.StartScrollingAcpLabel(this.LblSideTopButtonTrkViewboxValue, this.SideTopButtonTrkFeatureCanvas, ref this.isSideTopButtonTrkFeatureAnimating, this.RenderTransformSideTopButtonTrkFeatureViewbox);
			return;
			IL_35:
			acpLabel = (sender as AcpLabel);
			num2 = (short)427163649;
			num = (int)((IntPtr)num2);
			goto IL_13;
		}

		// Token: 0x0600070A RID: 1802 RVA: 0x00065624 File Offset: 0x00063824
		private void SideMiddleButtonCnvFeature_AnimationCompleted(object sender, EventArgs e)
		{
			short num = (short)1808924673;
			if (num != 0)
			{
			}
			num = (short)1934169445;
			short num2 = num;
			num = (short)1229591909;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1255735296;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)771162112;
			if (num != 0)
			{
			}
			this.isSideMiddleButtonCnvFeatureAnimating = false;
		}

		// Token: 0x0600070B RID: 1803 RVA: 0x000656D4 File Offset: 0x000638D4
		private void SideMiddleButtonTrkFeature_AnimationCompleted(object sender, EventArgs e)
		{
			short num = (short)1910531923;
			short num2 = num;
			num = (short)1308845907;
			switch (num2 == num)
			{
			}
			num = (short)832700416;
			short num3 = num;
			num = (short)1295056897;
			if (num != 0)
			{
			}
			num = (short)1990852608;
			if (num != 0)
			{
			}
			this.isSideMiddleButtonTrkFeatureAnimating = false;
		}

		// Token: 0x0600070C RID: 1804 RVA: 0x00065784 File Offset: 0x00063984
		private void ScrollingSideMiddleButtonCnvFeatureLabel(object sender, MouseButtonEventArgs e)
		{
			int a_ = 14;
			switch (0)
			{
			case 0:
				goto IL_35;
			}
			int num;
			AcpLabel acpLabel;
			short num2;
			for (;;)
			{
				IL_13:
				switch (num)
				{
				case 0:
					if (acpLabel.ActualWidth > 28.0)
					{
						num2 = (short)828899330;
						num = (int)((IntPtr)num2);
						continue;
					}
					return;
				case 1:
					if (Thread.CurrentThread.CurrentUICulture.Name == O9GraphicviewMenuItemsVisibilityConverter.b("䬸为", a_))
					{
						num2 = (short)15138822;
						num = (int)((IntPtr)num2);
						continue;
					}
					num2 = (short)1057292293;
					num = (int)((IntPtr)num2);
					continue;
				case 2:
					goto IL_1D3;
				case 3:
					return;
				case 4:
				{
					num2 = (short)1218733258;
					short num3 = num2;
					num2 = (short)13722826;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						continue;
					default:
					{
						num2 = (short)2062811136;
						short num4 = num2;
						num2 = (short)6291457;
						if (num2 != 0)
						{
						}
						num2 = (short)1426849792;
						if (num2 != 0)
						{
						}
						this.StartScrollingAcpLabel(this.LblSideMiddleButtonTCnvViewboxValue, this.SideMiddleButtonCnvFeatureCanvas, ref this.isSideMiddleButtonCnvFeatureAnimating, this.RenderTransformSideMiddleButtonCnvFeatureViewbox);
						num2 = (short)1436221443;
						num = (int)((IntPtr)num2);
						continue;
					}
					}
					break;
				}
				case 5:
					if (acpLabel.ActualWidth > 65.0)
					{
						num2 = (short)474087428;
						num = (int)((IntPtr)num2);
						continue;
					}
					return;
				case 6:
					num2 = (short)1358626816;
					num = (int)((IntPtr)num2);
					continue;
				}
				goto IL_35;
			}
			IL_1D3:
			this.StartScrollingAcpLabel(this.LblSideMiddleButtonTCnvViewboxValue, this.SideMiddleButtonCnvFeatureCanvas, ref this.isSideMiddleButtonCnvFeatureAnimating, this.RenderTransformSideMiddleButtonCnvFeatureViewbox);
			return;
			IL_35:
			acpLabel = (sender as AcpLabel);
			num2 = (short)197132289;
			num = (int)((IntPtr)num2);
			goto IL_13;
		}

		// Token: 0x0600070D RID: 1805 RVA: 0x000659A0 File Offset: 0x00063BA0
		private void ScrollingSideMiddleButtonTrkFeatureLabel(object sender, MouseButtonEventArgs e)
		{
			int a_ = 4;
			switch (0)
			{
			case 0:
				goto IL_35;
			}
			int num;
			AcpLabel acpLabel;
			short num2;
			for (;;)
			{
				IL_13:
				switch (num)
				{
				case 0:
					if (acpLabel.ActualWidth > 65.0)
					{
						goto IL_10B;
					}
					return;
				case 1:
				{
					if (Thread.CurrentThread.CurrentUICulture.Name == O9GraphicviewMenuItemsVisibilityConverter.b("崮䐰", a_))
					{
						num2 = (short)833617923;
						num = (int)((IntPtr)num2);
						continue;
					}
					num2 = (short)2126905344;
					short num3 = num2;
					num2 = (short)1467023361;
					if (num2 != 0)
					{
					}
					num2 = (short)1248329728;
					num = (int)((IntPtr)num2);
					continue;
				}
				case 2:
				{
					num2 = (short)65440679;
					short num4 = num2;
					num2 = (short)1265404839;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_10B;
					default:
						goto IL_1F4;
					}
					break;
				}
				case 3:
					num2 = (short)760938501;
					num = (int)((IntPtr)num2);
					continue;
				case 4:
					goto IL_188;
				case 5:
					if (acpLabel.ActualWidth > 43.0)
					{
						num2 = (short)227737604;
						num = (int)((IntPtr)num2);
						continue;
					}
					return;
				case 6:
					this.StartScrollingAcpLabel(this.LblSideMiddleButtonTrkViewboxValue, this.SideMiddleButtonTrkFeatureCanvas, ref this.isSideMiddleButtonTrkFeatureAnimating, this.RenderTransformSideMiddleButtonTrkFeatureViewbox);
					num2 = (short)2083520514;
					num = (int)((IntPtr)num2);
					continue;
				}
				goto IL_35;
				IL_10B:
				num2 = (short)2028732422;
				num = (int)((IntPtr)num2);
			}
			IL_188:
			this.StartScrollingAcpLabel(this.LblSideMiddleButtonTrkViewboxValue, this.SideMiddleButtonTrkFeatureCanvas, ref this.isSideMiddleButtonTrkFeatureAnimating, this.RenderTransformSideMiddleButtonTrkFeatureViewbox);
			return;
			IL_1F4:
			num2 = (short)1273954304;
			if (num2 != 0)
			{
			}
			return;
			IL_35:
			acpLabel = (sender as AcpLabel);
			num2 = (short)1809973249;
			num = (int)((IntPtr)num2);
			goto IL_13;
		}

		// Token: 0x0600070E RID: 1806 RVA: 0x00065BB8 File Offset: 0x00063DB8
		private void SideBottomButtonCnvFeature_AnimationCompleted(object sender, EventArgs e)
		{
			short num = (short)1681630968;
			short num2 = num;
			num = (short)1776527096;
			switch (num2 == num)
			{
			default:
			{
				num = (short)2074017792;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1129316352;
			if (num != 0)
			{
			}
			num = (short)1363673089;
			if (num != 0)
			{
			}
			this.isSideBottomButtonCnvFeatureAnimating = false;
		}

		// Token: 0x0600070F RID: 1807 RVA: 0x00065C68 File Offset: 0x00063E68
		private void SideBottomButtonTrkFeature_AnimationCompleted(object sender, EventArgs e)
		{
			short num = (short)705585738;
			short num2 = num;
			num = (short)1868849738;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1567686656;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1753939969;
			if (num != 0)
			{
			}
			num = (short)1408040960;
			if (num != 0)
			{
			}
			this.isSideBottomButtonTrkFeatureAnimating = false;
		}

		// Token: 0x06000710 RID: 1808 RVA: 0x00065D18 File Offset: 0x00063F18
		private void ScrollingSideBottomButtonCnvFeatureLabel(object sender, MouseButtonEventArgs e)
		{
			int a_ = 13;
			switch (0)
			{
			case 0:
				goto IL_35;
			}
			int num;
			AcpLabel acpLabel;
			short num2;
			for (;;)
			{
				IL_13:
				switch (num)
				{
				case 0:
					if (acpLabel.ActualWidth > 65.0)
					{
						goto IL_108;
					}
					return;
				case 1:
					if (Thread.CurrentThread.CurrentUICulture.Name == O9GraphicviewMenuItemsVisibilityConverter.b("䨷伹", a_))
					{
						num2 = (short)1410400259;
						num = (int)((IntPtr)num2);
						continue;
					}
					num2 = (short)993918976;
					num = (int)((IntPtr)num2);
					continue;
				case 2:
				{
					num2 = (short)1077030697;
					short num3 = num2;
					num2 = (short)1462906665;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_108;
					default:
						goto IL_1F1;
					}
					break;
				}
				case 3:
				{
					num2 = (short)675741697;
					if (num2 != 0)
					{
					}
					num2 = (short)1757282304;
					short num4 = num2;
					num2 = (short)1310654469;
					num = (int)((IntPtr)num2);
					continue;
				}
				case 4:
					goto IL_183;
				case 5:
					if (acpLabel.ActualWidth > 28.0)
					{
						num2 = (short)1136459780;
						num = (int)((IntPtr)num2);
						continue;
					}
					return;
				case 6:
					this.StartScrollingAcpLabel(this.LblSideBottomButtonTCnvViewboxValue, this.SideBottomButtonCnvFeatureCanvas, ref this.isSideBottomButtonCnvFeatureAnimating, this.RenderTransformSideBottomButtonCnvFeatureViewbox);
					num2 = (short)1706622978;
					num = (int)((IntPtr)num2);
					continue;
				}
				goto IL_35;
				IL_108:
				num2 = (short)750125062;
				num = (int)((IntPtr)num2);
			}
			IL_183:
			this.StartScrollingAcpLabel(this.LblSideBottomButtonTCnvViewboxValue, this.SideBottomButtonCnvFeatureCanvas, ref this.isSideBottomButtonCnvFeatureAnimating, this.RenderTransformSideBottomButtonCnvFeatureViewbox);
			return;
			IL_1F1:
			num2 = (short)1664483328;
			if (num2 != 0)
			{
			}
			return;
			IL_35:
			acpLabel = (sender as AcpLabel);
			num2 = (short)932904961;
			num = (int)((IntPtr)num2);
			goto IL_13;
		}

		// Token: 0x06000711 RID: 1809 RVA: 0x00065F30 File Offset: 0x00064130
		private void ScrollingSideBottomButtonTrkFeatureLabel(object sender, MouseButtonEventArgs e)
		{
			int a_ = 11;
			switch (0)
			{
			case 0:
				goto IL_35;
			}
			int num;
			AcpLabel acpLabel;
			short num2;
			for (;;)
			{
				IL_13:
				switch (num)
				{
				case 0:
					if (acpLabel.ActualWidth > 65.0)
					{
						goto IL_E3;
					}
					return;
				case 1:
				{
					if (Thread.CurrentThread.CurrentUICulture.Name == O9GraphicviewMenuItemsVisibilityConverter.b("䐵䴷", a_))
					{
						num2 = (short)667746307;
						num = (int)((IntPtr)num2);
						continue;
					}
					num2 = (short)1680867328;
					short num3 = num2;
					num2 = (short)240123904;
					num = (int)((IntPtr)num2);
					continue;
				}
				case 2:
				{
					num2 = (short)592126040;
					short num4 = num2;
					num2 = (short)487006296;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_E3;
					default:
						goto IL_1FB;
					}
					break;
				}
				case 3:
					num2 = (short)1883766785;
					if (num2 != 0)
					{
					}
					num2 = (short)1623982085;
					num = (int)((IntPtr)num2);
					continue;
				case 4:
					goto IL_189;
				case 5:
					if (acpLabel.ActualWidth > 43.0)
					{
						num2 = (short)265224196;
						num = (int)((IntPtr)num2);
						continue;
					}
					return;
				case 6:
					this.StartScrollingAcpLabel(this.LblSideBottomButtonTrkViewboxValue, this.SideBottomButtonTrkFeatureCanvas, ref this.isSideBottomButtonTrkFeatureAnimating, this.RenderTransformSideBottomButtonTrkFeatureViewbox);
					num2 = (short)190185474;
					num = (int)((IntPtr)num2);
					continue;
				}
				goto IL_35;
				IL_E3:
				num2 = (short)167641094;
				num = (int)((IntPtr)num2);
			}
			IL_189:
			this.StartScrollingAcpLabel(this.LblSideBottomButtonTrkViewboxValue, this.SideBottomButtonTrkFeatureCanvas, ref this.isSideBottomButtonTrkFeatureAnimating, this.RenderTransformSideBottomButtonTrkFeatureViewbox);
			return;
			IL_1FB:
			num2 = (short)1626406912;
			if (num2 != 0)
			{
			}
			return;
			IL_35:
			acpLabel = (sender as AcpLabel);
			num2 = (short)471990273;
			num = (int)((IntPtr)num2);
			goto IL_13;
		}

		// Token: 0x17000367 RID: 871
		// (get) Token: 0x06000712 RID: 1810 RVA: 0x00066150 File Offset: 0x00064350
		// (set) Token: 0x06000713 RID: 1811 RVA: 0x0006620C File Offset: 0x0006440C
		public bool TopRightButtonCnvIsAcpValid
		{
			get
			{
				short num = (short)27328513;
				if (num != 0)
				{
				}
				num = (short)196214784;
				short num2 = num;
				num = (short)487887942;
				short num3 = num;
				num = (short)1418499142;
				switch (num3 == num)
				{
				}
				num = (short)1561133056;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(O3GraphicView.TopRightButtonCnvIsAcpValidProperty);
			}
			set
			{
				short num = (short)1034449536;
				short num2 = num;
				num = (short)987001472;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1276903424;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)955121664;
				if (num != 0)
				{
				}
				num = (short)656474113;
				if (num != 0)
				{
				}
				base.SetValue(O3GraphicView.TopRightButtonCnvIsAcpValidProperty, value);
			}
		}

		// Token: 0x17000368 RID: 872
		// (get) Token: 0x06000714 RID: 1812 RVA: 0x000662C4 File Offset: 0x000644C4
		// (set) Token: 0x06000715 RID: 1813 RVA: 0x0006637C File Offset: 0x0006457C
		public bool TopRightButtonCnvIsAcpApplicable
		{
			get
			{
				short num = (short)2057559288;
				short num2 = num;
				num = (short)1127472376;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1978925056;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1253310465;
				if (num != 0)
				{
				}
				num = (short)345505792;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(O3GraphicView.TopRightButtonCnvIsAcpApplicableProperty);
			}
			set
			{
				short num = (short)1893515144;
				short num2 = num;
				num = (short)752664456;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1660944384;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1737818112;
				if (num != 0)
				{
				}
				num = (short)386007041;
				if (num != 0)
				{
				}
				base.SetValue(O3GraphicView.TopRightButtonCnvIsAcpApplicableProperty, value);
			}
		}

		// Token: 0x17000369 RID: 873
		// (get) Token: 0x06000716 RID: 1814 RVA: 0x00066438 File Offset: 0x00064638
		// (set) Token: 0x06000717 RID: 1815 RVA: 0x000664F0 File Offset: 0x000646F0
		public bool TopRightButtonCnvIsAcpVisible
		{
			get
			{
				short num = (short)724655907;
				short num2 = num;
				num = (short)26304291;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1890975744;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1742143489;
				if (num != 0)
				{
				}
				num = (short)132251648;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(O3GraphicView.TopRightButtonCnvIsAcpVisibleProperty);
			}
			set
			{
				short num = (short)866806009;
				short num2 = num;
				num = (short)1868392697;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1134493696;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1079574528;
				if (num != 0)
				{
				}
				num = (short)348520449;
				if (num != 0)
				{
				}
				base.SetValue(O3GraphicView.TopRightButtonCnvIsAcpVisibleProperty, value);
			}
		}

		// Token: 0x1700036A RID: 874
		// (get) Token: 0x06000718 RID: 1816 RVA: 0x000665A8 File Offset: 0x000647A8
		// (set) Token: 0x06000719 RID: 1817 RVA: 0x00066664 File Offset: 0x00064864
		public bool TopRightButtonCnvIsAcpEditable
		{
			get
			{
				short num = (short)1679541926;
				short num2 = num;
				num = (short)1743308454;
				switch (num2 == num)
				{
				}
				num = (short)1532493824;
				if (num != 0)
				{
				}
				num = (short)1684537344;
				short num3 = num;
				num = (short)640417793;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(O3GraphicView.TopRightButtonCnvIsAcpEditableProperty);
			}
			set
			{
				short num = (short)1816257296;
				short num2 = num;
				num = (short)1509155600;
				switch (num2 == num)
				{
				}
				num = (short)24379393;
				if (num != 0)
				{
				}
				num = (short)447414272;
				short num3 = num;
				num = (short)2049835008;
				if (num != 0)
				{
				}
				base.SetValue(O3GraphicView.TopRightButtonCnvIsAcpEditableProperty, value);
			}
		}

		// Token: 0x1700036B RID: 875
		// (get) Token: 0x0600071A RID: 1818 RVA: 0x0006671C File Offset: 0x0006491C
		// (set) Token: 0x0600071B RID: 1819 RVA: 0x000667D8 File Offset: 0x000649D8
		public string TopRightButtonCnvUIValue
		{
			get
			{
				short num = (short)759610625;
				short num2 = num;
				num = (short)135052545;
				switch (num2 == num)
				{
				}
				num = (short)828440577;
				if (num != 0)
				{
				}
				num = (short)1182662656;
				short num3 = num;
				num = (short)1046872064;
				if (num != 0)
				{
				}
				return (string)base.GetValue(O3GraphicView.TopRightButtonCnvUIValueProperty);
			}
			set
			{
				short num = (short)840623161;
				short num2 = num;
				num = (short)1026614329;
				switch (num2 == num)
				{
				}
				num = (short)869662721;
				if (num != 0)
				{
				}
				num = (short)1501757440;
				short num3 = num;
				num = (short)30670848;
				if (num != 0)
				{
				}
				base.SetValue(O3GraphicView.TopRightButtonCnvUIValueProperty, value);
			}
		}

		// Token: 0x1700036C RID: 876
		// (get) Token: 0x0600071C RID: 1820 RVA: 0x00066890 File Offset: 0x00064A90
		// (set) Token: 0x0600071D RID: 1821 RVA: 0x0006694C File Offset: 0x00064B4C
		public AcpListField TopRightButtonCnvList
		{
			get
			{
				short num = (short)2132939132;
				short num2 = num;
				num = (short)1547899260;
				switch (num2 == num)
				{
				}
				num = (short)190251009;
				if (num != 0)
				{
				}
				num = (short)1130627072;
				short num3 = num;
				num = (short)768344064;
				if (num != 0)
				{
				}
				return (AcpListField)base.GetValue(O3GraphicView.TopRightButtonCnvListProperty);
			}
			set
			{
				short num = (short)795045680;
				short num2 = num;
				num = (short)1948938032;
				switch (num2 == num)
				{
				}
				num = (short)1294860289;
				if (num != 0)
				{
				}
				num = (short)884801536;
				short num3 = num;
				num = (short)1579745280;
				if (num != 0)
				{
				}
				base.SetValue(O3GraphicView.TopRightButtonCnvListProperty, value);
			}
		}

		// Token: 0x1700036D RID: 877
		// (get) Token: 0x0600071E RID: 1822 RVA: 0x00066A00 File Offset: 0x00064C00
		// (set) Token: 0x0600071F RID: 1823 RVA: 0x00066AB8 File Offset: 0x00064CB8
		public bool TopRightButtonTrkIsAcpValid
		{
			get
			{
				short num = (short)1355847102;
				short num2 = num;
				num = (short)1889703358;
				switch (num2 == num)
				{
				}
				num = (short)1071972353;
				if (num != 0)
				{
				}
				num = (short)1873608704;
				short num3 = num;
				num = (short)831913984;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(O3GraphicView.TopRightButtonTrkIsAcpValidProperty);
			}
			set
			{
				short num = (short)2115750624;
				short num2 = num;
				num = (short)896125664;
				switch (num2 == num)
				{
				}
				num = (short)1466368001;
				if (num != 0)
				{
				}
				num = (short)1536425984;
				short num3 = num;
				num = (short)1240924160;
				if (num != 0)
				{
				}
				base.SetValue(O3GraphicView.TopRightButtonTrkIsAcpValidProperty, value);
			}
		}

		// Token: 0x1700036E RID: 878
		// (get) Token: 0x06000720 RID: 1824 RVA: 0x00066B70 File Offset: 0x00064D70
		// (set) Token: 0x06000721 RID: 1825 RVA: 0x00066C28 File Offset: 0x00064E28
		public bool TopRightButtonTrkIsAcpApplicable
		{
			get
			{
				short num = (short)660329351;
				short num2 = num;
				num = (short)35378055;
				switch (num2 == num)
				{
				}
				num = (short)2136080385;
				if (num != 0)
				{
				}
				num = (short)1156513792;
				short num3 = num;
				num = (short)1728512000;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(O3GraphicView.TopRightButtonTrkIsAcpApplicableProperty);
			}
			set
			{
				short num = (short)512223399;
				short num2 = num;
				num = (short)2054351015;
				switch (num2 == num)
				{
				}
				num = (short)1684471808;
				if (num != 0)
				{
				}
				num = (short)1535246336;
				short num3 = num;
				num = (short)995885057;
				if (num != 0)
				{
				}
				base.SetValue(O3GraphicView.TopRightButtonTrkIsAcpApplicableProperty, value);
			}
		}

		// Token: 0x1700036F RID: 879
		// (get) Token: 0x06000722 RID: 1826 RVA: 0x00066CE0 File Offset: 0x00064EE0
		// (set) Token: 0x06000723 RID: 1827 RVA: 0x00066D98 File Offset: 0x00064F98
		public bool TopRightButtonTrkIsAcpVisible
		{
			get
			{
				short num = (short)697880929;
				short num2 = num;
				num = (short)836555105;
				switch (num2 == num)
				{
				}
				num = (short)121044993;
				if (num != 0)
				{
				}
				num = (short)2111897600;
				short num3 = num;
				num = (short)1252851712;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(O3GraphicView.TopRightButtonTrkIsAcpVisibleProperty);
			}
			set
			{
				short num = (short)1113806020;
				short num2 = num;
				num = (short)2108970180;
				switch (num2 == num)
				{
				}
				num = (short)994050048;
				if (num != 0)
				{
				}
				num = (short)578486272;
				short num3 = num;
				num = (short)1353383937;
				if (num != 0)
				{
				}
				base.SetValue(O3GraphicView.TopRightButtonTrkIsAcpVisibleProperty, value);
			}
		}

		// Token: 0x17000370 RID: 880
		// (get) Token: 0x06000724 RID: 1828 RVA: 0x00066E54 File Offset: 0x00065054
		// (set) Token: 0x06000725 RID: 1829 RVA: 0x00066F0C File Offset: 0x0006510C
		public bool TopRightButtonTrkIsAcpEditable
		{
			get
			{
				short num = (short)1361537111;
				short num2 = num;
				num = (short)1004431447;
				switch (num2 == num)
				{
				}
				num = (short)443219969;
				if (num != 0)
				{
				}
				num = (short)2014707712;
				short num3 = num;
				num = (short)357040128;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(O3GraphicView.TopRightButtonTrkIsAcpEditableProperty);
			}
			set
			{
				short num = (short)705724311;
				short num2 = num;
				num = (short)1054179223;
				switch (num2 == num)
				{
				}
				num = (short)1093599232;
				if (num != 0)
				{
				}
				num = (short)1914830848;
				short num3 = num;
				num = (short)1334837249;
				if (num != 0)
				{
				}
				base.SetValue(O3GraphicView.TopRightButtonTrkIsAcpEditableProperty, value);
			}
		}

		// Token: 0x17000371 RID: 881
		// (get) Token: 0x06000726 RID: 1830 RVA: 0x00066FC4 File Offset: 0x000651C4
		// (set) Token: 0x06000727 RID: 1831 RVA: 0x0006707C File Offset: 0x0006527C
		public string TopRightButtonTrkUIValue
		{
			get
			{
				short num = (short)912912289;
				short num2 = num;
				num = (short)481685409;
				switch (num2 == num)
				{
				}
				num = (short)1604190209;
				if (num != 0)
				{
				}
				num = (short)1750794240;
				short num3 = num;
				num = (short)1605173248;
				if (num != 0)
				{
				}
				return (string)base.GetValue(O3GraphicView.TopRightButtonTrkUIValueProperty);
			}
			set
			{
				short num = (short)2065649235;
				short num2 = num;
				num = (short)1175408211;
				switch (num2 == num)
				{
				}
				num = (short)669188097;
				if (num != 0)
				{
				}
				num = (short)969932800;
				short num3 = num;
				num = (short)2028470272;
				if (num != 0)
				{
				}
				base.SetValue(O3GraphicView.TopRightButtonTrkUIValueProperty, value);
			}
		}

		// Token: 0x17000372 RID: 882
		// (get) Token: 0x06000728 RID: 1832 RVA: 0x00067130 File Offset: 0x00065330
		// (set) Token: 0x06000729 RID: 1833 RVA: 0x000671E8 File Offset: 0x000653E8
		public AcpListField TopRightButtonTrkList
		{
			get
			{
				short num = (short)157231398;
				short num2 = num;
				num = (short)1269115174;
				switch (num2 == num)
				{
				}
				num = (short)976879617;
				if (num != 0)
				{
				}
				num = (short)2034958336;
				short num3 = num;
				num = (short)471203840;
				if (num != 0)
				{
				}
				return (AcpListField)base.GetValue(O3GraphicView.TopRightButtonTrkListProperty);
			}
			set
			{
				short num = (short)584056833;
				if (num != 0)
				{
				}
				num = (short)593314352;
				short num2 = num;
				num = (short)1674986032;
				switch (num2 == num)
				{
				}
				num = (short)1962409984;
				short num3 = num;
				num = (short)36503552;
				if (num != 0)
				{
				}
				base.SetValue(O3GraphicView.TopRightButtonTrkListProperty, value);
			}
		}

		// Token: 0x17000373 RID: 883
		// (get) Token: 0x0600072A RID: 1834 RVA: 0x0006729C File Offset: 0x0006549C
		// (set) Token: 0x0600072B RID: 1835 RVA: 0x00067354 File Offset: 0x00065554
		public bool TopMiddleButtonCnvIsAcpValid
		{
			get
			{
				short num = (short)2119204005;
				short num2 = num;
				num = (short)135101605;
				switch (num2 == num)
				{
				}
				num = (short)1659305985;
				if (num != 0)
				{
				}
				num = (short)764608512;
				short num3 = num;
				num = (short)804323328;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(O3GraphicView.TopMiddleButtonCnvIsAcpValidProperty);
			}
			set
			{
				short num = (short)983826433;
				if (num != 0)
				{
				}
				num = (short)754876263;
				short num2 = num;
				num = (short)1972797287;
				switch (num2 == num)
				{
				}
				num = (short)1761083392;
				short num3 = num;
				num = (short)1892220928;
				if (num != 0)
				{
				}
				base.SetValue(O3GraphicView.TopMiddleButtonCnvIsAcpValidProperty, value);
			}
		}

		// Token: 0x17000374 RID: 884
		// (get) Token: 0x0600072C RID: 1836 RVA: 0x00067414 File Offset: 0x00065614
		// (set) Token: 0x0600072D RID: 1837 RVA: 0x000674CC File Offset: 0x000656CC
		public bool TopMiddleButtonCnvIsAcpApplicable
		{
			get
			{
				short num = (short)2089979863;
				short num2 = num;
				num = (short)1138593751;
				switch (num2 == num)
				{
				}
				num = (short)1144455168;
				if (num != 0)
				{
				}
				num = (short)417202176;
				short num3 = num;
				num = (short)1442381825;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(O3GraphicView.TopMiddleButtonCnvIsAcpApplicableProperty);
			}
			set
			{
				short num = (short)496762881;
				if (num != 0)
				{
				}
				num = (short)2041496721;
				short num2 = num;
				num = (short)359253137;
				switch (num2 == num)
				{
				}
				num = (short)552992768;
				short num3 = num;
				num = (short)1105264640;
				if (num != 0)
				{
				}
				base.SetValue(O3GraphicView.TopMiddleButtonCnvIsAcpApplicableProperty, value);
			}
		}

		// Token: 0x17000375 RID: 885
		// (get) Token: 0x0600072E RID: 1838 RVA: 0x00067588 File Offset: 0x00065788
		// (set) Token: 0x0600072F RID: 1839 RVA: 0x00067640 File Offset: 0x00065840
		public bool TopMiddleButtonCnvIsAcpVisible
		{
			get
			{
				short num = (short)1448796227;
				short num2 = num;
				num = (short)304144451;
				switch (num2 == num)
				{
				}
				num = (short)330366977;
				if (num != 0)
				{
				}
				num = (short)12713984;
				short num3 = num;
				num = (short)2137194496;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(O3GraphicView.TopMiddleButtonCnvIsAcpVisibleProperty);
			}
			set
			{
				short num = (short)294567823;
				short num2 = num;
				num = (short)1566949263;
				switch (num2 == num)
				{
				}
				num = (short)1451425792;
				if (num != 0)
				{
				}
				num = (short)1811611648;
				short num3 = num;
				num = (short)1921581057;
				if (num != 0)
				{
				}
				base.SetValue(O3GraphicView.TopMiddleButtonCnvIsAcpVisibleProperty, value);
			}
		}

		// Token: 0x17000376 RID: 886
		// (get) Token: 0x06000730 RID: 1840 RVA: 0x000676F8 File Offset: 0x000658F8
		// (set) Token: 0x06000731 RID: 1841 RVA: 0x000677B4 File Offset: 0x000659B4
		public bool TopMiddleButtonCnvIsAcpEditable
		{
			get
			{
				short num = (short)1509901783;
				short num2 = num;
				num = (short)1508853207;
				switch (num2 == num)
				{
				}
				num = (short)1797718016;
				if (num != 0)
				{
				}
				num = (short)1241186304;
				short num3 = num;
				num = (short)847118337;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(O3GraphicView.TopMiddleButtonCnvIsAcpEditableProperty);
			}
			set
			{
				short num = (short)1386283009;
				if (num != 0)
				{
				}
				num = (short)979511613;
				short num2 = num;
				num = (short)577448253;
				switch (num2 == num)
				{
				}
				num = (short)1313275904;
				short num3 = num;
				num = (short)1054736384;
				if (num != 0)
				{
				}
				base.SetValue(O3GraphicView.TopMiddleButtonCnvIsAcpEditableProperty, value);
			}
		}

		// Token: 0x17000377 RID: 887
		// (get) Token: 0x06000732 RID: 1842 RVA: 0x0006786C File Offset: 0x00065A6C
		// (set) Token: 0x06000733 RID: 1843 RVA: 0x00067924 File Offset: 0x00065B24
		public string TopMiddleButtonCnvUIValue
		{
			get
			{
				short num = (short)1586754594;
				short num2 = num;
				num = (short)1882518562;
				switch (num2 == num)
				{
				}
				num = (short)1201143808;
				if (num != 0)
				{
				}
				num = (short)1986330624;
				short num3 = num;
				num = (short)1178206209;
				if (num != 0)
				{
				}
				return (string)base.GetValue(O3GraphicView.TopMiddleButtonCnvUIValueProperty);
			}
			set
			{
				short num = (short)76310146;
				short num2 = num;
				num = (short)728917634;
				switch (num2 == num)
				{
				}
				num = (short)1919090688;
				if (num != 0)
				{
				}
				num = (short)1656094720;
				short num3 = num;
				num = (short)425787393;
				if (num != 0)
				{
				}
				base.SetValue(O3GraphicView.TopMiddleButtonCnvUIValueProperty, value);
			}
		}

		// Token: 0x17000378 RID: 888
		// (get) Token: 0x06000734 RID: 1844 RVA: 0x000679D8 File Offset: 0x00065BD8
		// (set) Token: 0x06000735 RID: 1845 RVA: 0x00067A90 File Offset: 0x00065C90
		public AcpListField TopMiddleButtonCnvList
		{
			get
			{
				short num = (short)796876332;
				short num2 = num;
				num = (short)468999724;
				switch (num2 == num)
				{
				}
				num = (short)253362177;
				if (num != 0)
				{
				}
				num = (short)1515192320;
				short num3 = num;
				num = (short)174260224;
				if (num != 0)
				{
				}
				return (AcpListField)base.GetValue(O3GraphicView.TopMiddleButtonCnvListProperty);
			}
			set
			{
				short num = (short)966165822;
				short num2 = num;
				num = (short)1268221246;
				switch (num2 == num)
				{
				}
				num = (short)1729888257;
				if (num != 0)
				{
				}
				num = (short)666959872;
				short num3 = num;
				num = (short)1881800704;
				if (num != 0)
				{
				}
				base.SetValue(O3GraphicView.TopMiddleButtonCnvListProperty, value);
			}
		}

		// Token: 0x17000379 RID: 889
		// (get) Token: 0x06000736 RID: 1846 RVA: 0x00067B44 File Offset: 0x00065D44
		// (set) Token: 0x06000737 RID: 1847 RVA: 0x00067C00 File Offset: 0x00065E00
		public bool TopMiddleButtonTrkIsAcpValid
		{
			get
			{
				short num = (short)523867617;
				short num2 = num;
				num = (short)698783201;
				switch (num2 == num)
				{
				}
				num = (short)480313345;
				if (num != 0)
				{
				}
				num = (short)1747845120;
				short num3 = num;
				num = (short)2093744128;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(O3GraphicView.TopMiddleButtonTrkIsAcpValidProperty);
			}
			set
			{
				short num = (short)90119242;
				short num2 = num;
				num = (short)1325734986;
				switch (num2 == num)
				{
				}
				num = (short)1702690817;
				if (num != 0)
				{
				}
				num = (short)1777074176;
				short num3 = num;
				num = (short)538509312;
				if (num != 0)
				{
				}
				base.SetValue(O3GraphicView.TopMiddleButtonTrkIsAcpValidProperty, value);
			}
		}

		// Token: 0x1700037A RID: 890
		// (get) Token: 0x06000738 RID: 1848 RVA: 0x00067CBC File Offset: 0x00065EBC
		// (set) Token: 0x06000739 RID: 1849 RVA: 0x00067D78 File Offset: 0x00065F78
		public bool TopMiddleButtonTrkIsAcpApplicable
		{
			get
			{
				short num = (short)1537409025;
				if (num != 0)
				{
				}
				num = (short)1037205390;
				short num2 = num;
				num = (short)1246527374;
				switch (num2 == num)
				{
				}
				num = (short)516816896;
				short num3 = num;
				num = (short)987103232;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(O3GraphicView.TopMiddleButtonTrkIsAcpApplicableProperty);
			}
			set
			{
				short num = (short)1586626561;
				if (num != 0)
				{
				}
				num = (short)950302976;
				short num2 = num;
				num = (short)1420916992;
				switch (num2 == num)
				{
				}
				num = (short)2065432576;
				short num3 = num;
				num = (short)605290496;
				if (num != 0)
				{
				}
				base.SetValue(O3GraphicView.TopMiddleButtonTrkIsAcpApplicableProperty, value);
			}
		}

		// Token: 0x1700037B RID: 891
		// (get) Token: 0x0600073A RID: 1850 RVA: 0x00067E30 File Offset: 0x00066030
		// (set) Token: 0x0600073B RID: 1851 RVA: 0x00067EE8 File Offset: 0x000660E8
		public bool TopMiddleButtonTrkIsAcpVisible
		{
			get
			{
				short num = (short)1569193985;
				if (num != 0)
				{
				}
				num = (short)1139660894;
				short num2 = num;
				num = (short)1688721502;
				switch (num2 == num)
				{
				}
				num = (short)1428488192;
				short num3 = num;
				num = (short)76873728;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(O3GraphicView.TopMiddleButtonTrkIsAcpVisibleProperty);
			}
			set
			{
				short num = (short)2132770897;
				short num2 = num;
				num = (short)1553891409;
				switch (num2 == num)
				{
				}
				num = (short)1262944257;
				if (num != 0)
				{
				}
				num = (short)718864384;
				short num3 = num;
				num = (short)331284480;
				if (num != 0)
				{
				}
				base.SetValue(O3GraphicView.TopMiddleButtonTrkIsAcpVisibleProperty, value);
			}
		}

		// Token: 0x1700037C RID: 892
		// (get) Token: 0x0600073C RID: 1852 RVA: 0x00067FA4 File Offset: 0x000661A4
		// (set) Token: 0x0600073D RID: 1853 RVA: 0x00068060 File Offset: 0x00066260
		public bool TopMiddleButtonTrkIsAcpEditable
		{
			get
			{
				short num = (short)696788942;
				short num2 = num;
				num = (short)2011047886;
				switch (num2 == num)
				{
				}
				num = (short)1673461760;
				if (num != 0)
				{
				}
				num = (short)1335689216;
				short num3 = num;
				num = (short)1808859137;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(O3GraphicView.TopMiddleButtonTrkIsAcpEditableProperty);
			}
			set
			{
				short num = (short)1124560657;
				short num2 = num;
				num = (short)586182417;
				switch (num2 == num)
				{
				}
				num = (short)210894848;
				if (num != 0)
				{
				}
				num = (short)893255680;
				short num3 = num;
				num = (short)959381505;
				if (num != 0)
				{
				}
				base.SetValue(O3GraphicView.TopMiddleButtonTrkIsAcpEditableProperty, value);
			}
		}

		// Token: 0x1700037D RID: 893
		// (get) Token: 0x0600073E RID: 1854 RVA: 0x0006811C File Offset: 0x0006631C
		// (set) Token: 0x0600073F RID: 1855 RVA: 0x000681D4 File Offset: 0x000663D4
		public string TopMiddleButtonTrkUIValue
		{
			get
			{
				short num = (short)1005213252;
				short num2 = num;
				num = (short)123819588;
				switch (num2 == num)
				{
				}
				num = (short)580321281;
				if (num != 0)
				{
				}
				num = (short)1391067136;
				short num3 = num;
				num = (short)1089994752;
				if (num != 0)
				{
				}
				return (string)base.GetValue(O3GraphicView.TopMiddleButtonTrkUIValueProperty);
			}
			set
			{
				short num = (short)728078814;
				short num2 = num;
				num = (short)1552259550;
				switch (num2 == num)
				{
				}
				num = (short)344784896;
				if (num != 0)
				{
				}
				num = (short)1732378624;
				short num3 = num;
				num = (short)1128988673;
				if (num != 0)
				{
				}
				base.SetValue(O3GraphicView.TopMiddleButtonTrkUIValueProperty, value);
			}
		}

		// Token: 0x1700037E RID: 894
		// (get) Token: 0x06000740 RID: 1856 RVA: 0x0006828C File Offset: 0x0006648C
		// (set) Token: 0x06000741 RID: 1857 RVA: 0x00068348 File Offset: 0x00066548
		public AcpListField TopMiddleButtonTrkList
		{
			get
			{
				short num = (short)775758863;
				short num2 = num;
				num = (short)435823631;
				switch (num2 == num)
				{
				}
				num = (short)1173291009;
				if (num != 0)
				{
				}
				num = (short)835846144;
				short num3 = num;
				num = (short)139853824;
				if (num != 0)
				{
				}
				return (AcpListField)base.GetValue(O3GraphicView.TopMiddleButtonTrkListProperty);
			}
			set
			{
				short num = (short)1466780292;
				short num2 = num;
				num = (short)234244740;
				switch (num2 == num)
				{
				}
				num = (short)1874329601;
				if (num != 0)
				{
				}
				num = (short)1711341568;
				short num3 = num;
				num = (short)957939712;
				if (num != 0)
				{
				}
				base.SetValue(O3GraphicView.TopMiddleButtonTrkListProperty, value);
			}
		}

		// Token: 0x1700037F RID: 895
		// (get) Token: 0x06000742 RID: 1858 RVA: 0x00068400 File Offset: 0x00066600
		// (set) Token: 0x06000743 RID: 1859 RVA: 0x000684B8 File Offset: 0x000666B8
		public bool SideTopButtonCnvIsAcpValid
		{
			get
			{
				short num = (short)341114881;
				if (num != 0)
				{
				}
				num = (short)829461452;
				short num2 = num;
				num = (short)569742284;
				switch (num2 == num)
				{
				}
				num = (short)1883242496;
				short num3 = num;
				num = (short)1729822720;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(O3GraphicView.SideTopButtonCnvIsAcpValidProperty);
			}
			set
			{
				short num = (short)373128226;
				short num2 = num;
				num = (short)1176992802;
				switch (num2 == num)
				{
				}
				num = (short)151977985;
				if (num != 0)
				{
				}
				num = (short)1980366848;
				short num3 = num;
				num = (short)1859125248;
				if (num != 0)
				{
				}
				base.SetValue(O3GraphicView.SideTopButtonCnvIsAcpValidProperty, value);
			}
		}

		// Token: 0x17000380 RID: 896
		// (get) Token: 0x06000744 RID: 1860 RVA: 0x00068570 File Offset: 0x00066770
		// (set) Token: 0x06000745 RID: 1861 RVA: 0x00068628 File Offset: 0x00066828
		public bool SideTopButtonCnvIsAcpApplicable
		{
			get
			{
				short num = (short)273874945;
				if (num != 0)
				{
				}
				num = (short)898021957;
				short num2 = num;
				num = (short)348633669;
				switch (num2 == num)
				{
				}
				num = (short)1364262912;
				short num3 = num;
				num = (short)40894464;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(O3GraphicView.SideTopButtonCnvIsAcpApplicableProperty);
			}
			set
			{
				short num = (short)2144096820;
				short num2 = num;
				num = (short)1472483892;
				switch (num2 == num)
				{
				}
				num = (short)1809252352;
				if (num != 0)
				{
				}
				num = (short)813760512;
				short num3 = num;
				num = (short)1253638145;
				if (num != 0)
				{
				}
				base.SetValue(O3GraphicView.SideTopButtonCnvIsAcpApplicableProperty, value);
			}
		}

		// Token: 0x17000381 RID: 897
		// (get) Token: 0x06000746 RID: 1862 RVA: 0x000686E4 File Offset: 0x000668E4
		// (set) Token: 0x06000747 RID: 1863 RVA: 0x000687A0 File Offset: 0x000669A0
		public bool SideTopButtonCnvIsAcpVisible
		{
			get
			{
				short num = (short)1924069874;
				short num2 = num;
				num = (short)643299826;
				switch (num2 == num)
				{
				}
				num = (short)1729757184;
				if (num != 0)
				{
				}
				num = (short)875888640;
				short num3 = num;
				num = (short)1723531265;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(O3GraphicView.SideTopButtonCnvIsAcpVisibleProperty);
			}
			set
			{
				short num = (short)715829138;
				short num2 = num;
				num = (short)470396818;
				switch (num2 == num)
				{
				}
				num = (short)1884094465;
				if (num != 0)
				{
				}
				num = (short)343015424;
				short num3 = num;
				num = (short)1237319680;
				if (num != 0)
				{
				}
				base.SetValue(O3GraphicView.SideTopButtonCnvIsAcpVisibleProperty, value);
			}
		}

		// Token: 0x17000382 RID: 898
		// (get) Token: 0x06000748 RID: 1864 RVA: 0x0006885C File Offset: 0x00066A5C
		// (set) Token: 0x06000749 RID: 1865 RVA: 0x00068918 File Offset: 0x00066B18
		public bool SideTopButtonCnvIsAcpEditable
		{
			get
			{
				short num = (short)1995964416;
				short num2 = num;
				num = (short)139473079;
				short num3 = num;
				num = (short)717566135;
				switch (num3 == num)
				{
				}
				num = (short)88276992;
				if (num != 0)
				{
				}
				num = (short)1422852097;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(O3GraphicView.SideTopButtonCnvIsAcpEditableProperty);
			}
			set
			{
				short num = (short)696254464;
				short num2 = num;
				num = (short)1995064818;
				short num3 = num;
				num = (short)749159922;
				switch (num3 == num)
				{
				}
				num = (short)980549633;
				if (num != 0)
				{
				}
				num = (short)1957494784;
				if (num != 0)
				{
				}
				base.SetValue(O3GraphicView.SideTopButtonCnvIsAcpEditableProperty, value);
			}
		}

		// Token: 0x17000383 RID: 899
		// (get) Token: 0x0600074A RID: 1866 RVA: 0x000689D4 File Offset: 0x00066BD4
		// (set) Token: 0x0600074B RID: 1867 RVA: 0x00068A8C File Offset: 0x00066C8C
		public string SideTopButtonCnvUIValue
		{
			get
			{
				short num = (short)2025586688;
				short num2 = num;
				num = (short)1886388225;
				if (num != 0)
				{
				}
				num = (short)1793083738;
				short num3 = num;
				num = (short)1239370074;
				switch (num3 == num)
				{
				}
				num = (short)325844992;
				if (num != 0)
				{
				}
				return (string)base.GetValue(O3GraphicView.SideTopButtonCnvUIValueProperty);
			}
			set
			{
				short num = (short)1736769536;
				short num2 = num;
				num = (short)361274055;
				short num3 = num;
				num = (short)1319541447;
				switch (num3 == num)
				{
				}
				num = (short)1186791425;
				if (num != 0)
				{
				}
				num = (short)1994326016;
				if (num != 0)
				{
				}
				base.SetValue(O3GraphicView.SideTopButtonCnvUIValueProperty, value);
			}
		}

		// Token: 0x17000384 RID: 900
		// (get) Token: 0x0600074C RID: 1868 RVA: 0x00068B40 File Offset: 0x00066D40
		// (set) Token: 0x0600074D RID: 1869 RVA: 0x00068BFC File Offset: 0x00066DFC
		public AcpListField SideTopButtonCnvList
		{
			get
			{
				short num = (short)1019150336;
				short num2 = num;
				num = (short)1413825251;
				short num3 = num;
				num = (short)1036731107;
				switch (num3 == num)
				{
				}
				num = (short)1070989313;
				if (num != 0)
				{
				}
				num = (short)47775744;
				if (num != 0)
				{
				}
				return (AcpListField)base.GetValue(O3GraphicView.SideTopButtonCnvListProperty);
			}
			set
			{
				short num = (short)1708523520;
				short num2 = num;
				num = (short)1388502971;
				short num3 = num;
				num = (short)64020411;
				switch (num3 == num)
				{
				}
				num = (short)1961164801;
				if (num != 0)
				{
				}
				num = (short)1011548160;
				if (num != 0)
				{
				}
				base.SetValue(O3GraphicView.SideTopButtonCnvListProperty, value);
			}
		}

		// Token: 0x17000385 RID: 901
		// (get) Token: 0x0600074E RID: 1870 RVA: 0x00068CB4 File Offset: 0x00066EB4
		// (set) Token: 0x0600074F RID: 1871 RVA: 0x00068D70 File Offset: 0x00066F70
		public bool SideTopButtonTrkIsAcpValid
		{
			get
			{
				short num = (short)1608384512;
				short num2 = num;
				num = (short)1251662114;
				short num3 = num;
				num = (short)360503586;
				switch (num3 == num)
				{
				}
				num = (short)1220018176;
				if (num != 0)
				{
				}
				num = (short)1788215297;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(O3GraphicView.SideTopButtonTrkIsAcpValidProperty);
			}
			set
			{
				short num = (short)1603665920;
				short num2 = num;
				num = (short)935461397;
				short num3 = num;
				num = (short)979632661;
				switch (num3 == num)
				{
				}
				num = (short)1373437952;
				if (num != 0)
				{
				}
				num = (short)252116993;
				if (num != 0)
				{
				}
				base.SetValue(O3GraphicView.SideTopButtonTrkIsAcpValidProperty, value);
			}
		}

		// Token: 0x17000386 RID: 902
		// (get) Token: 0x06000750 RID: 1872 RVA: 0x00068E30 File Offset: 0x00067030
		// (set) Token: 0x06000751 RID: 1873 RVA: 0x00068EEC File Offset: 0x000670EC
		public bool SideTopButtonTrkIsAcpApplicable
		{
			get
			{
				short num = (short)2052587520;
				short num2 = num;
				num = (short)2133917697;
				if (num != 0)
				{
				}
				num = (short)1707803341;
				short num3 = num;
				num = (short)666895053;
				switch (num3 == num)
				{
				}
				num = (short)522125312;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(O3GraphicView.SideTopButtonTrkIsAcpApplicableProperty);
			}
			set
			{
				short num = (short)1459683328;
				short num2 = num;
				num = (short)279444849;
				short num3 = num;
				num = (short)268893553;
				switch (num3 == num)
				{
				}
				num = (short)1954545665;
				if (num != 0)
				{
				}
				num = (short)1126825984;
				if (num != 0)
				{
				}
				base.SetValue(O3GraphicView.SideTopButtonTrkIsAcpApplicableProperty, value);
			}
		}

		// Token: 0x17000387 RID: 903
		// (get) Token: 0x06000752 RID: 1874 RVA: 0x00068FA8 File Offset: 0x000671A8
		// (set) Token: 0x06000753 RID: 1875 RVA: 0x00069064 File Offset: 0x00067264
		public bool SideTopButtonTrkIsAcpVisible
		{
			get
			{
				short num = (short)1783037952;
				short num2 = num;
				num = (short)1847107169;
				short num3 = num;
				num = (short)1449631329;
				switch (num3 == num)
				{
				}
				num = (short)1608253441;
				if (num != 0)
				{
				}
				num = (short)728956928;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(O3GraphicView.SideTopButtonTrkIsAcpVisibleProperty);
			}
			set
			{
				short num = (short)652935168;
				short num2 = num;
				num = (short)1422583870;
				short num3 = num;
				num = (short)306243646;
				switch (num3 == num)
				{
				}
				num = (short)1960771585;
				if (num != 0)
				{
				}
				num = (short)2061631488;
				if (num != 0)
				{
				}
				base.SetValue(O3GraphicView.SideTopButtonTrkIsAcpVisibleProperty, value);
			}
		}

		// Token: 0x17000388 RID: 904
		// (get) Token: 0x06000754 RID: 1876 RVA: 0x00069120 File Offset: 0x00067320
		// (set) Token: 0x06000755 RID: 1877 RVA: 0x000691D8 File Offset: 0x000673D8
		public bool SideTopButtonTrkIsAcpEditable
		{
			get
			{
				short num = (short)402587648;
				short num2 = num;
				num = (short)1862171405;
				short num3 = num;
				num = (short)1149270797;
				switch (num3 == num)
				{
				}
				num = (short)218300417;
				if (num != 0)
				{
				}
				num = (short)1967063040;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(O3GraphicView.SideTopButtonTrkIsAcpEditableProperty);
			}
			set
			{
				short num = (short)110886912;
				short num2 = num;
				num = (short)612446012;
				short num3 = num;
				num = (short)1974611772;
				switch (num3 == num)
				{
				}
				num = (short)166461441;
				if (num != 0)
				{
				}
				num = (short)725614592;
				if (num != 0)
				{
				}
				base.SetValue(O3GraphicView.SideTopButtonTrkIsAcpEditableProperty, value);
			}
		}

		// Token: 0x17000389 RID: 905
		// (get) Token: 0x06000756 RID: 1878 RVA: 0x00069294 File Offset: 0x00067494
		// (set) Token: 0x06000757 RID: 1879 RVA: 0x00069350 File Offset: 0x00067550
		public string SideTopButtonTrkUIValue
		{
			get
			{
				short num = (short)2123300864;
				short num2 = num;
				num = (short)2075852801;
				if (num != 0)
				{
				}
				num = (short)384068788;
				short num3 = num;
				num = (short)1598778548;
				switch (num3 == num)
				{
				}
				num = (short)63963136;
				if (num != 0)
				{
				}
				return (string)base.GetValue(O3GraphicView.SideTopButtonTrkUIValueProperty);
			}
			set
			{
				short num = (short)1164312576;
				short num2 = num;
				num = (short)1318145608;
				short num3 = num;
				num = (short)1777552968;
				switch (num3 == num)
				{
				}
				num = (short)92536832;
				if (num != 0)
				{
				}
				num = (short)89260033;
				if (num != 0)
				{
				}
				base.SetValue(O3GraphicView.SideTopButtonTrkUIValueProperty, value);
			}
		}

		// Token: 0x1700038A RID: 906
		// (get) Token: 0x06000758 RID: 1880 RVA: 0x00069408 File Offset: 0x00067608
		// (set) Token: 0x06000759 RID: 1881 RVA: 0x000694C0 File Offset: 0x000676C0
		public AcpListField SideTopButtonTrkList
		{
			get
			{
				short num = (short)1617231872;
				short num2 = num;
				num = (short)483152581;
				short num3 = num;
				num = (short)1201361605;
				switch (num3 == num)
				{
				}
				num = (short)508624897;
				if (num != 0)
				{
				}
				num = (short)1317142528;
				if (num != 0)
				{
				}
				return (AcpListField)base.GetValue(O3GraphicView.SideTopButtonTrkListProperty);
			}
			set
			{
				short num = (short)1549074432;
				short num2 = num;
				num = (short)445363478;
				short num3 = num;
				num = (short)1281013014;
				switch (num3 == num)
				{
				}
				num = (short)1515847681;
				if (num != 0)
				{
				}
				num = (short)1385758720;
				if (num != 0)
				{
				}
				base.SetValue(O3GraphicView.SideTopButtonTrkListProperty, value);
			}
		}

		// Token: 0x1700038B RID: 907
		// (get) Token: 0x0600075A RID: 1882 RVA: 0x00069574 File Offset: 0x00067774
		// (set) Token: 0x0600075B RID: 1883 RVA: 0x00069630 File Offset: 0x00067830
		public bool SideMiddleButtonCnvIsAcpValid
		{
			get
			{
				short num = (short)225050624;
				short num2 = num;
				num = (short)859362613;
				short num3 = num;
				num = (short)1788269877;
				switch (num3 == num)
				{
				}
				num = (short)166658048;
				if (num != 0)
				{
				}
				num = (short)398852097;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(O3GraphicView.SideMiddleButtonCnvIsAcpValidProperty);
			}
			set
			{
				short num = (short)1615200256;
				short num2 = num;
				num = (short)1624829783;
				short num3 = num;
				num = (short)1716711255;
				switch (num3 == num)
				{
				}
				num = (short)1843527681;
				if (num != 0)
				{
				}
				num = (short)1019150336;
				if (num != 0)
				{
				}
				base.SetValue(O3GraphicView.SideMiddleButtonCnvIsAcpValidProperty, value);
			}
		}

		// Token: 0x1700038C RID: 908
		// (get) Token: 0x0600075C RID: 1884 RVA: 0x000696EC File Offset: 0x000678EC
		// (set) Token: 0x0600075D RID: 1885 RVA: 0x000697A8 File Offset: 0x000679A8
		public bool SideMiddleButtonCnvIsAcpApplicable
		{
			get
			{
				short num = (short)1047134208;
				short num2 = num;
				num = (short)379037496;
				short num3 = num;
				num = (short)789489464;
				switch (num3 == num)
				{
				}
				num = (short)443351041;
				if (num != 0)
				{
				}
				num = (short)411828224;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(O3GraphicView.SideMiddleButtonCnvIsAcpApplicableProperty);
			}
			set
			{
				short num = (short)1115029504;
				short num2 = num;
				num = (short)1622110031;
				short num3 = num;
				num = (short)691171151;
				switch (num3 == num)
				{
				}
				num = (short)2075197441;
				if (num != 0)
				{
				}
				num = (short)1744961536;
				if (num != 0)
				{
				}
				base.SetValue(O3GraphicView.SideMiddleButtonCnvIsAcpApplicableProperty, value);
			}
		}

		// Token: 0x1700038D RID: 909
		// (get) Token: 0x0600075E RID: 1886 RVA: 0x00069864 File Offset: 0x00067A64
		// (set) Token: 0x0600075F RID: 1887 RVA: 0x0006991C File Offset: 0x00067B1C
		public bool SideMiddleButtonCnvIsAcpVisible
		{
			get
			{
				short num = (short)1559953408;
				short num2 = num;
				num = (short)1188112005;
				short num3 = num;
				num = (short)927409797;
				switch (num3 == num)
				{
				}
				num = (short)1023279105;
				if (num != 0)
				{
				}
				num = (short)813694976;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(O3GraphicView.SideMiddleButtonCnvIsAcpVisibleProperty);
			}
			set
			{
				short num = (short)872677376;
				short num2 = num;
				num = (short)224049685;
				short num3 = num;
				num = (short)831896085;
				switch (num3 == num)
				{
				}
				num = (short)1073676288;
				if (num != 0)
				{
				}
				num = (short)1321795585;
				if (num != 0)
				{
				}
				base.SetValue(O3GraphicView.SideMiddleButtonCnvIsAcpVisibleProperty, value);
			}
		}

		// Token: 0x1700038E RID: 910
		// (get) Token: 0x06000760 RID: 1888 RVA: 0x000699D8 File Offset: 0x00067BD8
		// (set) Token: 0x06000761 RID: 1889 RVA: 0x00069A90 File Offset: 0x00067C90
		public bool SideMiddleButtonCnvIsAcpEditable
		{
			get
			{
				short num = (short)493486080;
				short num2 = num;
				num = (short)2115693547;
				short num3 = num;
				num = (short)745008107;
				switch (num3 == num)
				{
				}
				num = (short)470482944;
				if (num != 0)
				{
				}
				num = (short)605224961;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(O3GraphicView.SideMiddleButtonCnvIsAcpEditableProperty);
			}
			set
			{
				short num = (short)1783234560;
				short num2 = num;
				num = (short)1180820166;
				short num3 = num;
				num = (short)756277958;
				switch (num3 == num)
				{
				}
				num = (short)1409155073;
				if (num != 0)
				{
				}
				num = (short)1034420224;
				if (num != 0)
				{
				}
				base.SetValue(O3GraphicView.SideMiddleButtonCnvIsAcpEditableProperty, value);
			}
		}

		// Token: 0x1700038F RID: 911
		// (get) Token: 0x06000762 RID: 1890 RVA: 0x00069B4C File Offset: 0x00067D4C
		// (set) Token: 0x06000763 RID: 1891 RVA: 0x00069C08 File Offset: 0x00067E08
		public string SideMiddleButtonCnvUIValue
		{
			get
			{
				short num = (short)638844928;
				short num2 = num;
				num = (short)1796299608;
				short num3 = num;
				num = (short)241064792;
				switch (num3 == num)
				{
				}
				num = (short)1460011009;
				if (num != 0)
				{
				}
				num = (short)1599143936;
				if (num != 0)
				{
				}
				return (string)base.GetValue(O3GraphicView.SideMiddleButtonCnvUIValueProperty);
			}
			set
			{
				short num = (short)375652352;
				short num2 = num;
				num = (short)275054593;
				if (num != 0)
				{
				}
				num = (short)1841907027;
				short num3 = num;
				num = (short)1565607251;
				switch (num3 == num)
				{
				}
				num = (short)244908032;
				if (num != 0)
				{
				}
				base.SetValue(O3GraphicView.SideMiddleButtonCnvUIValueProperty, value);
			}
		}

		// Token: 0x17000390 RID: 912
		// (get) Token: 0x06000764 RID: 1892 RVA: 0x00069CC0 File Offset: 0x00067EC0
		// (set) Token: 0x06000765 RID: 1893 RVA: 0x00069D7C File Offset: 0x00067F7C
		public AcpListField SideMiddleButtonCnvList
		{
			get
			{
				short num = (short)842530816;
				short num2 = num;
				num = (short)1931817156;
				short num3 = num;
				num = (short)1636643012;
				switch (num3 == num)
				{
				}
				num = (short)1507655680;
				if (num != 0)
				{
				}
				num = (short)1143078913;
				if (num != 0)
				{
				}
				return (AcpListField)base.GetValue(O3GraphicView.SideMiddleButtonCnvListProperty);
			}
			set
			{
				short num = (short)1216544768;
				short num2 = num;
				num = (short)576873504;
				short num3 = num;
				num = (short)261317664;
				switch (num3 == num)
				{
				}
				num = (short)811270145;
				if (num != 0)
				{
				}
				num = (short)1914830848;
				if (num != 0)
				{
				}
				base.SetValue(O3GraphicView.SideMiddleButtonCnvListProperty, value);
			}
		}

		// Token: 0x17000391 RID: 913
		// (get) Token: 0x06000766 RID: 1894 RVA: 0x00069E30 File Offset: 0x00068030
		// (set) Token: 0x06000767 RID: 1895 RVA: 0x00069EEC File Offset: 0x000680EC
		public bool SideMiddleButtonTrkIsAcpValid
		{
			get
			{
				short num = (short)766115840;
				short num2 = num;
				num = (short)62784842;
				short num3 = num;
				num = (short)766313802;
				switch (num3 == num)
				{
				}
				num = (short)267583489;
				if (num != 0)
				{
				}
				num = (short)1634926592;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(O3GraphicView.SideMiddleButtonTrkIsAcpValidProperty);
			}
			set
			{
				short num = (short)2028535808;
				short num2 = num;
				num = (short)1357509539;
				short num3 = num;
				num = (short)957412259;
				switch (num3 == num)
				{
				}
				num = (short)582483968;
				if (num != 0)
				{
				}
				num = (short)1582563329;
				if (num != 0)
				{
				}
				base.SetValue(O3GraphicView.SideMiddleButtonTrkIsAcpValidProperty, value);
			}
		}

		// Token: 0x17000392 RID: 914
		// (get) Token: 0x06000768 RID: 1896 RVA: 0x00069FA4 File Offset: 0x000681A4
		// (set) Token: 0x06000769 RID: 1897 RVA: 0x0006A060 File Offset: 0x00068260
		public bool SideMiddleButtonTrkIsAcpApplicable
		{
			get
			{
				short num = (short)1247477760;
				short num2 = num;
				num = (short)1025388363;
				short num3 = num;
				num = (short)945958731;
				switch (num3 == num)
				{
				}
				num = (short)2043084801;
				if (num != 0)
				{
				}
				num = (short)795738112;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(O3GraphicView.SideMiddleButtonTrkIsAcpApplicableProperty);
			}
			set
			{
				short num = (short)2080374784;
				short num2 = num;
				num = (short)1730954384;
				short num3 = num;
				num = (short)1032275088;
				switch (num3 == num)
				{
				}
				num = (short)62783489;
				if (num != 0)
				{
				}
				num = (short)1693908992;
				if (num != 0)
				{
				}
				base.SetValue(O3GraphicView.SideMiddleButtonTrkIsAcpApplicableProperty, value);
			}
		}

		// Token: 0x17000393 RID: 915
		// (get) Token: 0x0600076A RID: 1898 RVA: 0x0006A11C File Offset: 0x0006831C
		// (set) Token: 0x0600076B RID: 1899 RVA: 0x0006A1D4 File Offset: 0x000683D4
		public bool SideMiddleButtonTrkIsAcpVisible
		{
			get
			{
				short num = (short)426049536;
				short num2 = num;
				num = (short)1864119755;
				short num3 = num;
				num = (short)1901737419;
				switch (num3 == num)
				{
				}
				num = (short)1513029632;
				if (num != 0)
				{
				}
				num = (short)1767571457;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(O3GraphicView.SideMiddleButtonTrkIsAcpVisibleProperty);
			}
			set
			{
				short num = (short)1561001984;
				short num2 = num;
				num = (short)1494423609;
				short num3 = num;
				num = (short)1966348345;
				switch (num3 == num)
				{
				}
				num = (short)92602369;
				if (num != 0)
				{
				}
				num = (short)1584463872;
				if (num != 0)
				{
				}
				base.SetValue(O3GraphicView.SideMiddleButtonTrkIsAcpVisibleProperty, value);
			}
		}

		// Token: 0x17000394 RID: 916
		// (get) Token: 0x0600076C RID: 1900 RVA: 0x0006A290 File Offset: 0x00068490
		// (set) Token: 0x0600076D RID: 1901 RVA: 0x0006A348 File Offset: 0x00068548
		public bool SideMiddleButtonTrkIsAcpEditable
		{
			get
			{
				short num = (short)478806016;
				short num2 = num;
				num = (short)1858616292;
				short num3 = num;
				num = (short)318520292;
				switch (num3 == num)
				{
				}
				num = (short)1646854145;
				if (num != 0)
				{
				}
				num = (short)2039021568;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(O3GraphicView.SideMiddleButtonTrkIsAcpEditableProperty);
			}
			set
			{
				short num = (short)2038824960;
				short num2 = num;
				num = (short)1373175809;
				if (num != 0)
				{
				}
				num = (short)740883225;
				short num3 = num;
				num = (short)766114585;
				switch (num3 == num)
				{
				}
				num = (short)131137536;
				if (num != 0)
				{
				}
				base.SetValue(O3GraphicView.SideMiddleButtonTrkIsAcpEditableProperty, value);
			}
		}

		// Token: 0x17000395 RID: 917
		// (get) Token: 0x0600076E RID: 1902 RVA: 0x0006A400 File Offset: 0x00068600
		// (set) Token: 0x0600076F RID: 1903 RVA: 0x0006A4B8 File Offset: 0x000686B8
		public string SideMiddleButtonTrkUIValue
		{
			get
			{
				short num = (short)1729495040;
				short num2 = num;
				num = (short)97583105;
				if (num != 0)
				{
				}
				num = (short)1799346535;
				short num3 = num;
				num = (short)1882773863;
				switch (num3 == num)
				{
				}
				num = (short)1345126400;
				if (num != 0)
				{
				}
				return (string)base.GetValue(O3GraphicView.SideMiddleButtonTrkUIValueProperty);
			}
			set
			{
				short num = (short)1222180864;
				short num2 = num;
				num = (short)560308178;
				short num3 = num;
				num = (short)43360210;
				switch (num3 == num)
				{
				}
				num = (short)1755250688;
				if (num != 0)
				{
				}
				num = (short)1876819969;
				if (num != 0)
				{
				}
				base.SetValue(O3GraphicView.SideMiddleButtonTrkUIValueProperty, value);
			}
		}

		// Token: 0x17000396 RID: 918
		// (get) Token: 0x06000770 RID: 1904 RVA: 0x0006A56C File Offset: 0x0006876C
		// (set) Token: 0x06000771 RID: 1905 RVA: 0x0006A620 File Offset: 0x00068820
		public AcpListField SideMiddleButtonTrkList
		{
			get
			{
				short num = (short)1663041536;
				short num2 = num;
				num = (short)808714241;
				if (num != 0)
				{
				}
				num = (short)1865850845;
				short num3 = num;
				num = (short)884907997;
				switch (num3 == num)
				{
				}
				num = (short)310181888;
				if (num != 0)
				{
				}
				return (AcpListField)base.GetValue(O3GraphicView.SideMiddleButtonTrkListProperty);
			}
			set
			{
				short num = (short)900726784;
				short num2 = num;
				num = (short)1797838409;
				short num3 = num;
				num = (short)98948681;
				switch (num3 == num)
				{
				}
				num = (short)1984102401;
				if (num != 0)
				{
				}
				num = (short)600702976;
				if (num != 0)
				{
				}
				base.SetValue(O3GraphicView.SideMiddleButtonTrkListProperty, value);
			}
		}

		// Token: 0x17000397 RID: 919
		// (get) Token: 0x06000772 RID: 1906 RVA: 0x0006A6D8 File Offset: 0x000688D8
		// (set) Token: 0x06000773 RID: 1907 RVA: 0x0006A790 File Offset: 0x00068990
		public bool SideBottomButtonCnvIsAcpValid
		{
			get
			{
				short num = (short)1041563648;
				short num2 = num;
				num = (short)1386872833;
				if (num != 0)
				{
				}
				num = (short)1804959108;
				short num3 = num;
				num = (short)495025540;
				switch (num3 == num)
				{
				}
				num = (short)1921646592;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(O3GraphicView.SideBottomButtonCnvIsAcpValidProperty);
			}
			set
			{
				short num = (short)246349824;
				short num2 = num;
				num = (short)2049845852;
				short num3 = num;
				num = (short)1784818268;
				switch (num3 == num)
				{
				}
				num = (short)226230273;
				if (num != 0)
				{
				}
				num = (short)84738048;
				if (num != 0)
				{
				}
				base.SetValue(O3GraphicView.SideBottomButtonCnvIsAcpValidProperty, value);
			}
		}

		// Token: 0x17000398 RID: 920
		// (get) Token: 0x06000774 RID: 1908 RVA: 0x0006A84C File Offset: 0x00068A4C
		// (set) Token: 0x06000775 RID: 1909 RVA: 0x0006A904 File Offset: 0x00068B04
		public bool SideBottomButtonCnvIsAcpApplicable
		{
			get
			{
				short num = (short)1790050304;
				short num2 = num;
				num = (short)370790575;
				short num3 = num;
				num = (short)1172033711;
				switch (num3 == num)
				{
				}
				num = (short)209649665;
				if (num != 0)
				{
				}
				num = (short)1397882880;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(O3GraphicView.SideBottomButtonCnvIsAcpApplicableProperty);
			}
			set
			{
				short num = (short)147259392;
				short num2 = num;
				num = (short)823029254;
				short num3 = num;
				num = (short)2074177030;
				switch (num3 == num)
				{
				}
				num = (short)1255276544;
				if (num != 0)
				{
				}
				num = (short)93192193;
				if (num != 0)
				{
				}
				base.SetValue(O3GraphicView.SideBottomButtonCnvIsAcpApplicableProperty, value);
			}
		}

		// Token: 0x17000399 RID: 921
		// (get) Token: 0x06000776 RID: 1910 RVA: 0x0006A9C0 File Offset: 0x00068BC0
		// (set) Token: 0x06000777 RID: 1911 RVA: 0x0006AA78 File Offset: 0x00068C78
		public bool SideBottomButtonCnvIsAcpVisible
		{
			get
			{
				short num = (short)1504641024;
				short num2 = num;
				num = (short)28450513;
				short num3 = num;
				num = (short)664870609;
				switch (num3 == num)
				{
				}
				num = (short)1716977665;
				if (num != 0)
				{
				}
				num = (short)357761024;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(O3GraphicView.SideBottomButtonCnvIsAcpVisibleProperty);
			}
			set
			{
				short num = (short)2042822656;
				short num2 = num;
				num = (short)980179;
				short num3 = num;
				num = (short)1359475923;
				switch (num3 == num)
				{
				}
				num = (short)2090008576;
				if (num != 0)
				{
				}
				num = (short)1999699969;
				if (num != 0)
				{
				}
				base.SetValue(O3GraphicView.SideBottomButtonCnvIsAcpVisibleProperty, value);
			}
		}

		// Token: 0x1700039A RID: 922
		// (get) Token: 0x06000778 RID: 1912 RVA: 0x0006AB34 File Offset: 0x00068D34
		// (set) Token: 0x06000779 RID: 1913 RVA: 0x0006ABF0 File Offset: 0x00068DF0
		public bool SideBottomButtonCnvIsAcpEditable
		{
			get
			{
				short num = (short)1374289920;
				short num2 = num;
				num = (short)953998799;
				short num3 = num;
				num = (short)2019941839;
				switch (num3 == num)
				{
				}
				num = (short)1256456193;
				if (num != 0)
				{
				}
				num = (short)180027392;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(O3GraphicView.SideBottomButtonCnvIsAcpEditableProperty);
			}
			set
			{
				short num = (short)374210560;
				short num2 = num;
				num = (short)95044996;
				short num3 = num;
				num = (short)535446916;
				switch (num3 == num)
				{
				}
				num = (short)184287233;
				if (num != 0)
				{
				}
				num = (short)95485952;
				if (num != 0)
				{
				}
				base.SetValue(O3GraphicView.SideBottomButtonCnvIsAcpEditableProperty, value);
			}
		}

		// Token: 0x1700039B RID: 923
		// (get) Token: 0x0600077A RID: 1914 RVA: 0x0006ACAC File Offset: 0x00068EAC
		// (set) Token: 0x0600077B RID: 1915 RVA: 0x0006AD68 File Offset: 0x00068F68
		public string SideBottomButtonCnvUIValue
		{
			get
			{
				short num = (short)1725693952;
				short num2 = num;
				num = (short)148449628;
				short num3 = num;
				num = (short)908142940;
				switch (num3 == num)
				{
				}
				num = (short)1377566720;
				if (num != 0)
				{
				}
				num = (short)13238273;
				if (num != 0)
				{
				}
				return (string)base.GetValue(O3GraphicView.SideBottomButtonCnvUIValueProperty);
			}
			set
			{
				short num = (short)864093486;
				short num2 = num;
				num = (short)1469318446;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1548943360;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)130416641;
				if (num != 0)
				{
				}
				num = (short)745734144;
				if (num != 0)
				{
				}
				base.SetValue(O3GraphicView.SideBottomButtonCnvUIValueProperty, value);
			}
		}

		// Token: 0x1700039C RID: 924
		// (get) Token: 0x0600077C RID: 1916 RVA: 0x0006AE1C File Offset: 0x0006901C
		// (set) Token: 0x0600077D RID: 1917 RVA: 0x0006AED4 File Offset: 0x000690D4
		public AcpListField SideBottomButtonCnvList
		{
			get
			{
				short num = (short)528121086;
				short num2 = num;
				num = (short)400063742;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1417216000;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)257687553;
				if (num != 0)
				{
				}
				num = (short)2110193664;
				if (num != 0)
				{
				}
				return (AcpListField)base.GetValue(O3GraphicView.SideBottomButtonCnvListProperty);
			}
			set
			{
				short num = (short)1087441563;
				short num2 = num;
				num = (short)1456016027;
				switch (num2 == num)
				{
				default:
				{
					num = (short)776732672;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)630325249;
				if (num != 0)
				{
				}
				num = (short)650379264;
				if (num != 0)
				{
				}
				base.SetValue(O3GraphicView.SideBottomButtonCnvListProperty, value);
			}
		}

		// Token: 0x1700039D RID: 925
		// (get) Token: 0x0600077E RID: 1918 RVA: 0x0006AF8C File Offset: 0x0006918C
		// (set) Token: 0x0600077F RID: 1919 RVA: 0x0006B048 File Offset: 0x00069248
		public bool SideBottomButtonTrkIsAcpValid
		{
			get
			{
				short num = (short)218302553;
				short num2 = num;
				num = (short)2016872537;
				switch (num2 == num)
				{
				default:
				{
					num = (short)322895872;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)341377024;
				if (num != 0)
				{
				}
				num = (short)1605107713;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(O3GraphicView.SideBottomButtonTrkIsAcpValidProperty);
			}
			set
			{
				short num = (short)390840679;
				short num2 = num;
				num = (short)1783284071;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1546452992;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)800980993;
				if (num != 0)
				{
				}
				num = (short)1188233216;
				if (num != 0)
				{
				}
				base.SetValue(O3GraphicView.SideBottomButtonTrkIsAcpValidProperty, value);
			}
		}

		// Token: 0x1700039E RID: 926
		// (get) Token: 0x06000780 RID: 1920 RVA: 0x0006B104 File Offset: 0x00069304
		// (set) Token: 0x06000781 RID: 1921 RVA: 0x0006B1BC File Offset: 0x000693BC
		public bool SideBottomButtonTrkIsAcpApplicable
		{
			get
			{
				short num = (short)1905598317;
				short num2 = num;
				num = (short)1615601517;
				switch (num2 == num)
				{
				default:
				{
					num = (short)654901248;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1097072640;
				if (num != 0)
				{
				}
				num = (short)195690497;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(O3GraphicView.SideBottomButtonTrkIsAcpApplicableProperty);
			}
			set
			{
				short num = (short)79662916;
				short num2 = num;
				num = (short)1111592772;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1628307456;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)358219777;
				if (num != 0)
				{
				}
				num = (short)1119485952;
				if (num != 0)
				{
				}
				base.SetValue(O3GraphicView.SideBottomButtonTrkIsAcpApplicableProperty, value);
			}
		}

		// Token: 0x1700039F RID: 927
		// (get) Token: 0x06000782 RID: 1922 RVA: 0x0006B274 File Offset: 0x00069474
		// (set) Token: 0x06000783 RID: 1923 RVA: 0x0006B32C File Offset: 0x0006952C
		public bool SideBottomButtonTrkIsAcpVisible
		{
			get
			{
				short num = (short)985771739;
				short num2 = num;
				num = (short)1448062683;
				switch (num2 == num)
				{
				default:
				{
					num = (short)498728960;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)609157121;
				if (num != 0)
				{
				}
				num = (short)946274304;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(O3GraphicView.SideBottomButtonTrkIsAcpVisibleProperty);
			}
			set
			{
				short num = (short)943218716;
				short num2 = num;
				num = (short)1823563804;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1113128960;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)357105664;
				if (num != 0)
				{
				}
				num = (short)1737818113;
				if (num != 0)
				{
				}
				base.SetValue(O3GraphicView.SideBottomButtonTrkIsAcpVisibleProperty, value);
			}
		}

		// Token: 0x170003A0 RID: 928
		// (get) Token: 0x06000784 RID: 1924 RVA: 0x0006B3E8 File Offset: 0x000695E8
		// (set) Token: 0x06000785 RID: 1925 RVA: 0x0006B49C File Offset: 0x0006969C
		public bool SideBottomButtonTrkIsAcpEditable
		{
			get
			{
				short num = (short)1828160611;
				short num2 = num;
				num = (short)573604963;
				switch (num2 == num)
				{
				default:
				{
					num = (short)995688448;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1851457537;
				if (num != 0)
				{
				}
				num = (short)2022309888;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(O3GraphicView.SideBottomButtonTrkIsAcpEditableProperty);
			}
			set
			{
				short num = (short)75469775;
				short num2 = num;
				num = (short)1691521999;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1176240128;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1411973120;
				if (num != 0)
				{
				}
				num = (short)1475411969;
				if (num != 0)
				{
				}
				base.SetValue(O3GraphicView.SideBottomButtonTrkIsAcpEditableProperty, value);
			}
		}

		// Token: 0x170003A1 RID: 929
		// (get) Token: 0x06000786 RID: 1926 RVA: 0x0006B554 File Offset: 0x00069754
		// (set) Token: 0x06000787 RID: 1927 RVA: 0x0006B610 File Offset: 0x00069810
		public string SideBottomButtonTrkUIValue
		{
			get
			{
				short num = (short)1819267408;
				short num2 = num;
				num = (short)598397264;
				switch (num2 == num)
				{
				default:
				{
					num = (short)677576704;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1173815296;
				if (num != 0)
				{
				}
				num = (short)2144337921;
				if (num != 0)
				{
				}
				return (string)base.GetValue(O3GraphicView.SideBottomButtonTrkUIValueProperty);
			}
			set
			{
				short num = (short)537108140;
				short num2 = num;
				num = (short)1078238892;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1571028992;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2125266945;
				if (num != 0)
				{
				}
				num = (short)685572096;
				if (num != 0)
				{
				}
				base.SetValue(O3GraphicView.SideBottomButtonTrkUIValueProperty, value);
			}
		}

		// Token: 0x170003A2 RID: 930
		// (get) Token: 0x06000788 RID: 1928 RVA: 0x0006B6C4 File Offset: 0x000698C4
		// (set) Token: 0x06000789 RID: 1929 RVA: 0x0006B780 File Offset: 0x00069980
		public AcpListField SideBottomButtonTrkList
		{
			get
			{
				short num = (short)428210215;
				short num2 = num;
				num = (short)1721628711;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1296826368;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2105671680;
				if (num != 0)
				{
				}
				num = (short)594673665;
				if (num != 0)
				{
				}
				return (AcpListField)base.GetValue(O3GraphicView.SideBottomButtonTrkListProperty);
			}
			set
			{
				short num = (short)1684974270;
				short num2 = num;
				num = (short)724413118;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2043740160;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)468385793;
				if (num != 0)
				{
				}
				num = (short)1862008832;
				if (num != 0)
				{
				}
				base.SetValue(O3GraphicView.SideBottomButtonTrkListProperty, value);
			}
		}

		// Token: 0x170003A3 RID: 931
		// (get) Token: 0x0600078A RID: 1930 RVA: 0x0006B834 File Offset: 0x00069A34
		// (set) Token: 0x0600078B RID: 1931 RVA: 0x0006B8F0 File Offset: 0x00069AF0
		public bool DataButtonCnvIsAcpValid
		{
			get
			{
				short num = (short)1565767922;
				short num2 = num;
				num = (short)618641650;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1541079040;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)324403201;
				if (num != 0)
				{
				}
				num = (short)1951989760;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(O3GraphicView.DataButtonCnvIsAcpValidProperty);
			}
			set
			{
				short num = (short)640366205;
				short num2 = num;
				num = (short)876951165;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1527119872;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1936523265;
				if (num != 0)
				{
				}
				num = (short)1940652032;
				if (num != 0)
				{
				}
				base.SetValue(O3GraphicView.DataButtonCnvIsAcpValidProperty, value);
			}
		}

		// Token: 0x170003A4 RID: 932
		// (get) Token: 0x0600078C RID: 1932 RVA: 0x0006B9AC File Offset: 0x00069BAC
		// (set) Token: 0x0600078D RID: 1933 RVA: 0x0006BA64 File Offset: 0x00069C64
		public bool DataButtonCnvIsAcpApplicable
		{
			get
			{
				short num = (short)2048522608;
				short num2 = num;
				num = (short)2103310704;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1817706496;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1647837184;
				if (num != 0)
				{
				}
				num = (short)1924464641;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(O3GraphicView.DataButtonCnvIsAcpApplicableProperty);
			}
			set
			{
				short num = (short)217076858;
				short num2 = num;
				num = (short)577918074;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1097531392;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)703135745;
				if (num != 0)
				{
				}
				num = (short)1371078656;
				if (num != 0)
				{
				}
				base.SetValue(O3GraphicView.DataButtonCnvIsAcpApplicableProperty, value);
			}
		}

		// Token: 0x170003A5 RID: 933
		// (get) Token: 0x0600078E RID: 1934 RVA: 0x0006BB1C File Offset: 0x00069D1C
		// (set) Token: 0x0600078F RID: 1935 RVA: 0x0006BBD4 File Offset: 0x00069DD4
		public bool DataButtonCnvIsAcpVisible
		{
			get
			{
				short num = (short)1100943971;
				short num2 = num;
				num = (short)2113933923;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1284767744;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1111883777;
				if (num != 0)
				{
				}
				num = (short)1832386560;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(O3GraphicView.DataButtonCnvIsAcpVisibleProperty);
			}
			set
			{
				short num = (short)476862380;
				short num2 = num;
				num = (short)1728010156;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1666908160;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1919811585;
				if (num != 0)
				{
				}
				num = (short)814219264;
				if (num != 0)
				{
				}
				base.SetValue(O3GraphicView.DataButtonCnvIsAcpVisibleProperty, value);
			}
		}

		// Token: 0x170003A6 RID: 934
		// (get) Token: 0x06000790 RID: 1936 RVA: 0x0006BC90 File Offset: 0x00069E90
		// (set) Token: 0x06000791 RID: 1937 RVA: 0x0006BD4C File Offset: 0x00069F4C
		public bool DataButtonCnvIsAcpEditable
		{
			get
			{
				short num = (short)2098584495;
				short num2 = num;
				num = (short)1528028079;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2102394880;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)808058881;
				if (num != 0)
				{
				}
				num = (short)1640300544;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(O3GraphicView.DataButtonCnvIsAcpEditableProperty);
			}
			set
			{
				short num = (short)1055864162;
				short num2 = num;
				num = (short)594228578;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1705115648;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1289945088;
				if (num != 0)
				{
				}
				num = (short)413663233;
				if (num != 0)
				{
				}
				base.SetValue(O3GraphicView.DataButtonCnvIsAcpEditableProperty, value);
			}
		}

		// Token: 0x170003A7 RID: 935
		// (get) Token: 0x06000792 RID: 1938 RVA: 0x0006BE08 File Offset: 0x0006A008
		// (set) Token: 0x06000793 RID: 1939 RVA: 0x0006BEC4 File Offset: 0x0006A0C4
		public string DataButtonCnvUIValue
		{
			get
			{
				short num = (short)1624985465;
				short num2 = num;
				num = (short)605048697;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1895890944;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1490616321;
				if (num != 0)
				{
				}
				num = (short)643497984;
				if (num != 0)
				{
				}
				return (string)base.GetValue(O3GraphicView.DataButtonCnvUIValueProperty);
			}
			set
			{
				short num = (short)1796395247;
				short num2 = num;
				num = (short)537317615;
				switch (num2 == num)
				{
				default:
				{
					num = (short)282394624;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1233584129;
				if (num != 0)
				{
				}
				num = (short)868483072;
				if (num != 0)
				{
				}
				base.SetValue(O3GraphicView.DataButtonCnvUIValueProperty, value);
			}
		}

		// Token: 0x170003A8 RID: 936
		// (get) Token: 0x06000794 RID: 1940 RVA: 0x0006BF7C File Offset: 0x0006A17C
		// (set) Token: 0x06000795 RID: 1941 RVA: 0x0006C034 File Offset: 0x0006A234
		public AcpListField DataButtonCnvList
		{
			get
			{
				short num = (short)1884090826;
				short num2 = num;
				num = (short)2077225418;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1462173696;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)735248385;
				if (num != 0)
				{
				}
				num = (short)797507584;
				if (num != 0)
				{
				}
				return (AcpListField)base.GetValue(O3GraphicView.DataButtonCnvListProperty);
			}
			set
			{
				short num = (short)518847528;
				short num2 = num;
				num = (short)1322843176;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1435762688;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1323565057;
				if (num != 0)
				{
				}
				num = (short)1869283328;
				if (num != 0)
				{
				}
				base.SetValue(O3GraphicView.DataButtonCnvListProperty, value);
			}
		}

		// Token: 0x170003A9 RID: 937
		// (get) Token: 0x06000796 RID: 1942 RVA: 0x0006C0E8 File Offset: 0x0006A2E8
		// (set) Token: 0x06000797 RID: 1943 RVA: 0x0006C1A4 File Offset: 0x0006A3A4
		public bool DataButtonCnvIndexIsAcpValid
		{
			get
			{
				short num = (short)444459366;
				short num2 = num;
				num = (short)1829222;
				switch (num2 == num)
				{
				default:
				{
					num = (short)462487552;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)629538817;
				if (num != 0)
				{
				}
				num = (short)1033437184;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(O3GraphicView.DataButtonCnvIndexIsAcpValidProperty);
			}
			set
			{
				short num = (short)465993189;
				short num2 = num;
				num = (short)1926069733;
				switch (num2 == num)
				{
				default:
				{
					num = (short)155516928;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)933232640;
				if (num != 0)
				{
				}
				num = (short)970260481;
				if (num != 0)
				{
				}
				base.SetValue(O3GraphicView.DataButtonCnvIndexIsAcpValidProperty, value);
			}
		}

		// Token: 0x170003AA RID: 938
		// (get) Token: 0x06000798 RID: 1944 RVA: 0x0006C260 File Offset: 0x0006A460
		// (set) Token: 0x06000799 RID: 1945 RVA: 0x0006C31C File Offset: 0x0006A51C
		public bool DataButtonCnvIndexIsAcpApplicable
		{
			get
			{
				short num = (short)1067697140;
				short num2 = num;
				num = (short)1861731316;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1654718464;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1754202113;
				if (num != 0)
				{
				}
				num = (short)296550400;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(O3GraphicView.DataButtonCnvIndexIsAcpApplicableProperty);
			}
			set
			{
				short num = (short)1367631493;
				short num2 = num;
				num = (short)924214917;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1567817728;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)884080640;
				if (num != 0)
				{
				}
				num = (short)1205207041;
				if (num != 0)
				{
				}
				base.SetValue(O3GraphicView.DataButtonCnvIndexIsAcpApplicableProperty, value);
			}
		}

		// Token: 0x170003AB RID: 939
		// (get) Token: 0x0600079A RID: 1946 RVA: 0x0006C3D4 File Offset: 0x0006A5D4
		// (set) Token: 0x0600079B RID: 1947 RVA: 0x0006C48C File Offset: 0x0006A68C
		public bool DataButtonCnvIndexIsAcpVisible
		{
			get
			{
				short num = (short)1327458179;
				short num2 = num;
				num = (short)1234331523;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1193607168;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1338441729;
				if (num != 0)
				{
				}
				num = (short)1628700672;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(O3GraphicView.DataButtonCnvIndexIsAcpVisibleProperty);
			}
			set
			{
				short num = (short)1113123648;
				short num2 = num;
				num = (short)114486080;
				switch (num2 == num)
				{
				default:
				{
					num = (short)776470528;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1758593024;
				if (num != 0)
				{
				}
				num = (short)1352204289;
				if (num != 0)
				{
				}
				base.SetValue(O3GraphicView.DataButtonCnvIndexIsAcpVisibleProperty, value);
			}
		}

		// Token: 0x170003AC RID: 940
		// (get) Token: 0x0600079C RID: 1948 RVA: 0x0006C544 File Offset: 0x0006A744
		// (set) Token: 0x0600079D RID: 1949 RVA: 0x0006C5FC File Offset: 0x0006A7FC
		public bool DataButtonCnvIndexIsAcpEditable
		{
			get
			{
				short num = (short)1461402307;
				short num2 = num;
				num = (short)1186544323;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1646526464;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1277689857;
				if (num != 0)
				{
				}
				num = (short)1638596608;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(O3GraphicView.DataButtonCnvIndexIsAcpEditableProperty);
			}
			set
			{
				short num = (short)1703149595;
				short num2 = num;
				num = (short)976879643;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1961426944;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1709899777;
				if (num != 0)
				{
				}
				num = (short)951713792;
				if (num != 0)
				{
				}
				base.SetValue(O3GraphicView.DataButtonCnvIndexIsAcpEditableProperty, value);
			}
		}

		// Token: 0x170003AD RID: 941
		// (get) Token: 0x0600079E RID: 1950 RVA: 0x0006C6B8 File Offset: 0x0006A8B8
		// (set) Token: 0x0600079F RID: 1951 RVA: 0x0006C774 File Offset: 0x0006A974
		public string DataButtonCnvIndexUIValue
		{
			get
			{
				short num = (short)1865578148;
				short num2 = num;
				num = (short)1259828900;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1763508224;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1575223296;
				if (num != 0)
				{
				}
				num = (short)870252545;
				if (num != 0)
				{
				}
				return (string)base.GetValue(O3GraphicView.DataButtonCnvIndexUIValueProperty);
			}
			set
			{
				short num = (short)1757357231;
				short num2 = num;
				num = (short)1610622127;
				switch (num2 == num)
				{
				default:
				{
					num = (short)319094784;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)134807552;
				if (num != 0)
				{
				}
				num = (short)1553661953;
				if (num != 0)
				{
				}
				base.SetValue(O3GraphicView.DataButtonCnvIndexUIValueProperty, value);
			}
		}

		// Token: 0x170003AE RID: 942
		// (get) Token: 0x060007A0 RID: 1952 RVA: 0x0006C82C File Offset: 0x0006AA2C
		// (set) Token: 0x060007A1 RID: 1953 RVA: 0x0006C8E8 File Offset: 0x0006AAE8
		public AcpListField DataButtonCnvIndexList
		{
			get
			{
				short num = (short)352009270;
				short num2 = num;
				num = (short)1167473718;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1369178112;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1595801601;
				if (num != 0)
				{
				}
				num = (short)1719336960;
				if (num != 0)
				{
				}
				return (AcpListField)base.GetValue(O3GraphicView.DataButtonCnvIndexListProperty);
			}
			set
			{
				short num = (short)812545123;
				short num2 = num;
				num = (short)134116451;
				switch (num2 == num)
				{
				default:
				{
					num = (short)383975424;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)240386049;
				if (num != 0)
				{
				}
				num = (short)855703552;
				if (num != 0)
				{
				}
				base.SetValue(O3GraphicView.DataButtonCnvIndexListProperty, value);
			}
		}

		// Token: 0x170003AF RID: 943
		// (get) Token: 0x060007A2 RID: 1954 RVA: 0x0006C9A0 File Offset: 0x0006ABA0
		// (set) Token: 0x060007A3 RID: 1955 RVA: 0x0006CA5C File Offset: 0x0006AC5C
		public bool DataButtonTrkIsAcpValid
		{
			get
			{
				short num = (short)615905483;
				short num2 = num;
				num = (short)1317927115;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1159266304;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)654049280;
				if (num != 0)
				{
				}
				num = (short)2007826433;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(O3GraphicView.DataButtonTrkIsAcpValidProperty);
			}
			set
			{
				short num = (short)1158152193;
				if (num != 0)
				{
				}
				num = (short)1748107264;
				short num2 = num;
				num = (short)33270944;
				short num3 = num;
				num = (short)1804643488;
				switch (num3 == num)
				{
				}
				num = (short)328466432;
				if (num != 0)
				{
				}
				base.SetValue(O3GraphicView.DataButtonTrkIsAcpValidProperty, value);
			}
		}

		// Token: 0x170003B0 RID: 944
		// (get) Token: 0x060007A4 RID: 1956 RVA: 0x0006CB14 File Offset: 0x0006AD14
		// (set) Token: 0x060007A5 RID: 1957 RVA: 0x0006CBCC File Offset: 0x0006ADCC
		public bool DataButtonTrkIsAcpApplicable
		{
			get
			{
				short num = (short)1492012093;
				short num2 = num;
				num = (short)2014006333;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1196621824;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1962409985;
				if (num != 0)
				{
				}
				num = (short)491585536;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(O3GraphicView.DataButtonTrkIsAcpApplicableProperty);
			}
			set
			{
				short num = (short)1147959626;
				short num2 = num;
				num = (short)385841482;
				switch (num2 == num)
				{
				default:
				{
					num = (short)234094592;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1103691777;
				if (num != 0)
				{
				}
				num = (short)2057699328;
				if (num != 0)
				{
				}
				base.SetValue(O3GraphicView.DataButtonTrkIsAcpApplicableProperty, value);
			}
		}

		// Token: 0x170003B1 RID: 945
		// (get) Token: 0x060007A6 RID: 1958 RVA: 0x0006CC88 File Offset: 0x0006AE88
		// (set) Token: 0x060007A7 RID: 1959 RVA: 0x0006CD44 File Offset: 0x0006AF44
		public bool DataButtonTrkIsAcpVisible
		{
			get
			{
				short num = (short)1954225007;
				short num2 = num;
				num = (short)1521032047;
				switch (num2 == num)
				{
				default:
				{
					num = (short)723976192;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)387710977;
				if (num != 0)
				{
				}
				num = (short)1442250752;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(O3GraphicView.DataButtonTrkIsAcpVisibleProperty);
			}
			set
			{
				short num = (short)351341582;
				short num2 = num;
				num = (short)278793230;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1697841152;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)770441217;
				if (num != 0)
				{
				}
				num = (short)962134016;
				if (num != 0)
				{
				}
				base.SetValue(O3GraphicView.DataButtonTrkIsAcpVisibleProperty, value);
			}
		}

		// Token: 0x170003B2 RID: 946
		// (get) Token: 0x060007A8 RID: 1960 RVA: 0x0006CDFC File Offset: 0x0006AFFC
		// (set) Token: 0x060007A9 RID: 1961 RVA: 0x0006CEB4 File Offset: 0x0006B0B4
		public bool DataButtonTrkIsAcpEditable
		{
			get
			{
				short num = (short)60818681;
				short num2 = num;
				num = (short)2017133817;
				switch (num2 == num)
				{
				default:
				{
					num = (short)582156288;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)733020161;
				if (num != 0)
				{
				}
				num = (short)129302528;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(O3GraphicView.DataButtonTrkIsAcpEditableProperty);
			}
			set
			{
				short num = (short)749657816;
				short num2 = num;
				num = (short)1893850840;
				switch (num2 == num)
				{
				default:
				{
					num = (short)927465472;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1350238209;
				if (num != 0)
				{
				}
				num = (short)259588096;
				if (num != 0)
				{
				}
				base.SetValue(O3GraphicView.DataButtonTrkIsAcpEditableProperty, value);
			}
		}

		// Token: 0x170003B3 RID: 947
		// (get) Token: 0x060007AA RID: 1962 RVA: 0x0006CF70 File Offset: 0x0006B170
		// (set) Token: 0x060007AB RID: 1963 RVA: 0x0006D02C File Offset: 0x0006B22C
		public string DataButtonTrkUIValue
		{
			get
			{
				short num = (short)1549939253;
				short num2 = num;
				num = (short)831926837;
				switch (num2 == num)
				{
				default:
				{
					num = (short)173277184;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1267728385;
				if (num != 0)
				{
				}
				num = (short)608894976;
				if (num != 0)
				{
				}
				return (string)base.GetValue(O3GraphicView.DataButtonTrkUIValueProperty);
			}
			set
			{
				short num = (short)1197811184;
				short num2 = num;
				num = (short)922691056;
				switch (num2 == num)
				{
				}
				num = (short)1729691648;
				short num3 = num;
				num = (short)145358848;
				if (num != 0)
				{
				}
				num = (short)513998849;
				if (num != 0)
				{
				}
				base.SetValue(O3GraphicView.DataButtonTrkUIValueProperty, value);
			}
		}

		// Token: 0x170003B4 RID: 948
		// (get) Token: 0x060007AC RID: 1964 RVA: 0x0006D0E0 File Offset: 0x0006B2E0
		// (set) Token: 0x060007AD RID: 1965 RVA: 0x0006D198 File Offset: 0x0006B398
		public AcpListField DataButtonTrkList
		{
			get
			{
				short num = (short)1417262355;
				short num2 = num;
				num = (short)411088147;
				switch (num2 == num)
				{
				}
				num = (short)704970752;
				short num3 = num;
				num = (short)1641218049;
				if (num != 0)
				{
				}
				num = (short)1931542528;
				if (num != 0)
				{
				}
				return (AcpListField)base.GetValue(O3GraphicView.DataButtonTrkListProperty);
			}
			set
			{
				short num = (short)1207429204;
				short num2 = num;
				num = (short)2037704788;
				switch (num2 == num)
				{
				}
				num = (short)1851981824;
				short num3 = num;
				num = (short)1238368256;
				if (num != 0)
				{
				}
				num = (short)399310849;
				if (num != 0)
				{
				}
				base.SetValue(O3GraphicView.DataButtonTrkListProperty, value);
			}
		}

		// Token: 0x170003B5 RID: 949
		// (get) Token: 0x060007AE RID: 1966 RVA: 0x0006D24C File Offset: 0x0006B44C
		// (set) Token: 0x060007AF RID: 1967 RVA: 0x0006D308 File Offset: 0x0006B508
		public bool DataButtonTrkIndexIsAcpValid
		{
			get
			{
				short num = (short)2097020929;
				if (num != 0)
				{
				}
				num = (short)472906594;
				short num2 = num;
				num = (short)1435040610;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1804533760;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1363607552;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(O3GraphicView.DataButtonTrkIndexIsAcpValidProperty);
			}
			set
			{
				short num = (short)72321365;
				short num2 = num;
				num = (short)1884653909;
				switch (num2 == num)
				{
				}
				num = (short)1103495168;
				short num3 = num;
				num = (short)1087504385;
				if (num != 0)
				{
				}
				num = (short)1879703552;
				if (num != 0)
				{
				}
				base.SetValue(O3GraphicView.DataButtonTrkIndexIsAcpValidProperty, value);
			}
		}

		// Token: 0x170003B6 RID: 950
		// (get) Token: 0x060007B0 RID: 1968 RVA: 0x0006D3C4 File Offset: 0x0006B5C4
		// (set) Token: 0x060007B1 RID: 1969 RVA: 0x0006D480 File Offset: 0x0006B680
		public bool DataButtonTrkIndexIsAcpApplicable
		{
			get
			{
				short num = (short)2018194208;
				short num2 = num;
				num = (short)559559456;
				switch (num2 == num)
				{
				}
				num = (short)1318977536;
				short num3 = num;
				num = (short)232062976;
				if (num != 0)
				{
				}
				num = (short)776077313;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(O3GraphicView.DataButtonTrkIndexIsAcpApplicableProperty);
			}
			set
			{
				short num = (short)1354092976;
				short num2 = num;
				num = (short)402313648;
				switch (num2 == num)
				{
				}
				num = (short)2086535168;
				short num3 = num;
				num = (short)1203109889;
				if (num != 0)
				{
				}
				num = (short)1673527296;
				if (num != 0)
				{
				}
				base.SetValue(O3GraphicView.DataButtonTrkIndexIsAcpApplicableProperty, value);
			}
		}

		// Token: 0x170003B7 RID: 951
		// (get) Token: 0x060007B2 RID: 1970 RVA: 0x0006D53C File Offset: 0x0006B73C
		// (set) Token: 0x060007B3 RID: 1971 RVA: 0x0006D5F8 File Offset: 0x0006B7F8
		public bool DataButtonTrkIndexIsAcpVisible
		{
			get
			{
				short num = (short)457648511;
				short num2 = num;
				num = (short)528951679;
				switch (num2 == num)
				{
				}
				num = (short)133038080;
				short num3 = num;
				num = (short)1366556672;
				if (num != 0)
				{
				}
				num = (short)2015559681;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(O3GraphicView.DataButtonTrkIndexIsAcpVisibleProperty);
			}
			set
			{
				short num = (short)310527899;
				short num2 = num;
				num = (short)235292571;
				switch (num2 == num)
				{
				}
				num = (short)1148649472;
				short num3 = num;
				num = (short)1888223233;
				if (num != 0)
				{
				}
				num = (short)1756889088;
				if (num != 0)
				{
				}
				base.SetValue(O3GraphicView.DataButtonTrkIndexIsAcpVisibleProperty, value);
			}
		}

		// Token: 0x170003B8 RID: 952
		// (get) Token: 0x060007B4 RID: 1972 RVA: 0x0006D6B4 File Offset: 0x0006B8B4
		// (set) Token: 0x060007B5 RID: 1973 RVA: 0x0006D76C File Offset: 0x0006B96C
		public bool DataButtonTrkIndexIsAcpEditable
		{
			get
			{
				short num = (short)1746844449;
				short num2 = num;
				num = (short)1120647969;
				switch (num2 == num)
				{
				}
				num = (short)1981087744;
				short num3 = num;
				num = (short)1482752000;
				if (num != 0)
				{
				}
				num = (short)1912209409;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(O3GraphicView.DataButtonTrkIndexIsAcpEditableProperty);
			}
			set
			{
				short num = (short)1830696810;
				short num2 = num;
				num = (short)1215575914;
				switch (num2 == num)
				{
				}
				num = (short)499384320;
				short num3 = num;
				num = (short)680591361;
				if (num != 0)
				{
				}
				num = (short)1945698304;
				if (num != 0)
				{
				}
				base.SetValue(O3GraphicView.DataButtonTrkIndexIsAcpEditableProperty, value);
			}
		}

		// Token: 0x170003B9 RID: 953
		// (get) Token: 0x060007B6 RID: 1974 RVA: 0x0006D824 File Offset: 0x0006BA24
		// (set) Token: 0x060007B7 RID: 1975 RVA: 0x0006D8DC File Offset: 0x0006BADC
		public string DataButtonTrkIndexUIValue
		{
			get
			{
				short num = (short)1866256285;
				short num2 = num;
				num = (short)1573441437;
				switch (num2 == num)
				{
				}
				num = (short)722206720;
				short num3 = num;
				num = (short)1581842432;
				if (num != 0)
				{
				}
				num = (short)1417478145;
				if (num != 0)
				{
				}
				return (string)base.GetValue(O3GraphicView.DataButtonTrkIndexUIValueProperty);
			}
			set
			{
				short num = (short)1052779333;
				short num2 = num;
				num = (short)449782597;
				switch (num2 == num)
				{
				}
				num = (short)1536557056;
				short num3 = num;
				num = (short)200867841;
				if (num != 0)
				{
				}
				num = (short)918224896;
				if (num != 0)
				{
				}
				base.SetValue(O3GraphicView.DataButtonTrkIndexUIValueProperty, value);
			}
		}

		// Token: 0x170003BA RID: 954
		// (get) Token: 0x060007B8 RID: 1976 RVA: 0x0006D994 File Offset: 0x0006BB94
		// (set) Token: 0x060007B9 RID: 1977 RVA: 0x0006DA50 File Offset: 0x0006BC50
		public AcpListField DataButtonTrkIndexList
		{
			get
			{
				short num = (short)840541661;
				short num2 = num;
				num = (short)319595997;
				switch (num2 == num)
				{
				}
				num = (short)726728704;
				short num3 = num;
				num = (short)1092812800;
				if (num != 0)
				{
				}
				num = (short)986644481;
				if (num != 0)
				{
				}
				return (AcpListField)base.GetValue(O3GraphicView.DataButtonTrkIndexListProperty);
			}
			set
			{
				short num = (short)224866550;
				short num2 = num;
				num = (short)1911238902;
				switch (num2 == num)
				{
				}
				num = (short)1936326656;
				short num3 = num;
				num = (short)1666842625;
				if (num != 0)
				{
				}
				num = (short)547291136;
				if (num != 0)
				{
				}
				base.SetValue(O3GraphicView.DataButtonTrkIndexListProperty, value);
			}
		}

		// Token: 0x170003BB RID: 955
		// (get) Token: 0x060007BA RID: 1978 RVA: 0x0006DB08 File Offset: 0x0006BD08
		// (set) Token: 0x060007BB RID: 1979 RVA: 0x0006DBC0 File Offset: 0x0006BDC0
		public bool UpButtonIsAcpValid
		{
			get
			{
				short num = (short)1454087207;
				short num2 = num;
				num = (short)2082446375;
				switch (num2 == num)
				{
				}
				num = (short)686686208;
				short num3 = num;
				num = (short)51970049;
				if (num != 0)
				{
				}
				num = (short)1693188096;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(O3GraphicView.UpButtonIsAcpValidProperty);
			}
			set
			{
				short num = (short)1076633053;
				short num2 = num;
				num = (short)708124125;
				switch (num2 == num)
				{
				}
				num = (short)1643708416;
				short num3 = num;
				num = (short)1924071425;
				if (num != 0)
				{
				}
				num = (short)2072641536;
				if (num != 0)
				{
				}
				base.SetValue(O3GraphicView.UpButtonIsAcpValidProperty, value);
			}
		}

		// Token: 0x170003BC RID: 956
		// (get) Token: 0x060007BC RID: 1980 RVA: 0x0006DC7C File Offset: 0x0006BE7C
		// (set) Token: 0x060007BD RID: 1981 RVA: 0x0006DD34 File Offset: 0x0006BF34
		public bool UpButtonIsAcpApplicable
		{
			get
			{
				short num = (short)1053764684;
				short num2 = num;
				num = (short)274738252;
				switch (num2 == num)
				{
				}
				num = (short)452001792;
				short num3 = num;
				num = (short)371851265;
				if (num != 0)
				{
				}
				num = (short)1637416960;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(O3GraphicView.UpButtonIsAcpApplicableProperty);
			}
			set
			{
				short num = (short)73786896;
				short num2 = num;
				num = (short)1230104080;
				switch (num2 == num)
				{
				}
				num = (short)229834752;
				short num3 = num;
				num = (short)1936261120;
				if (num != 0)
				{
				}
				num = (short)1468399617;
				if (num != 0)
				{
				}
				base.SetValue(O3GraphicView.UpButtonIsAcpApplicableProperty, value);
			}
		}

		// Token: 0x170003BD RID: 957
		// (get) Token: 0x060007BE RID: 1982 RVA: 0x0006DDEC File Offset: 0x0006BFEC
		// (set) Token: 0x060007BF RID: 1983 RVA: 0x0006DEA8 File Offset: 0x0006C0A8
		public bool UpButtonIsAcpVisible
		{
			get
			{
				short num = (short)241984488;
				short num2 = num;
				num = (short)352543720;
				switch (num2 == num)
				{
				}
				num = (short)1089208320;
				short num3 = num;
				num = (short)1835335680;
				if (num != 0)
				{
				}
				num = (short)1051197441;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(O3GraphicView.UpButtonIsAcpVisibleProperty);
			}
			set
			{
				short num = (short)2011625483;
				short num2 = num;
				num = (short)1611003915;
				switch (num2 == num)
				{
				}
				num = (short)1663827968;
				short num3 = num;
				num = (short)1113587713;
				if (num != 0)
				{
				}
				num = (short)1312686080;
				if (num != 0)
				{
				}
				base.SetValue(O3GraphicView.UpButtonIsAcpVisibleProperty, value);
			}
		}

		// Token: 0x170003BE RID: 958
		// (get) Token: 0x060007C0 RID: 1984 RVA: 0x0006DF64 File Offset: 0x0006C164
		// (set) Token: 0x060007C1 RID: 1985 RVA: 0x0006E020 File Offset: 0x0006C220
		public bool UpButtonIsAcpEditable
		{
			get
			{
				short num = (short)1923560474;
				short num2 = num;
				num = (short)2078749722;
				switch (num2 == num)
				{
				}
				num = (short)838598656;
				short num3 = num;
				num = (short)984547328;
				if (num != 0)
				{
				}
				num = (short)172163073;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(O3GraphicView.UpButtonIsAcpEditableProperty);
			}
			set
			{
				short num = (short)496473155;
				short num2 = num;
				num = (short)760583235;
				switch (num2 == num)
				{
				}
				num = (short)86900736;
				short num3 = num;
				num = (short)2004156417;
				if (num != 0)
				{
				}
				num = (short)226885632;
				if (num != 0)
				{
				}
				base.SetValue(O3GraphicView.UpButtonIsAcpEditableProperty, value);
			}
		}

		// Token: 0x170003BF RID: 959
		// (get) Token: 0x060007C2 RID: 1986 RVA: 0x0006E0D8 File Offset: 0x0006C2D8
		// (set) Token: 0x060007C3 RID: 1987 RVA: 0x0006E190 File Offset: 0x0006C390
		public string UpButtonUIValue
		{
			get
			{
				short num = (short)1203960390;
				short num2 = num;
				num = (short)494467654;
				switch (num2 == num)
				{
				}
				num = (short)1480392704;
				short num3 = num;
				num = (short)1285488640;
				if (num != 0)
				{
				}
				num = (short)1603010561;
				if (num != 0)
				{
				}
				return (string)base.GetValue(O3GraphicView.UpButtonUIValueProperty);
			}
			set
			{
				short num = (short)1824097549;
				short num2 = num;
				num = (short)1566737677;
				switch (num2 == num)
				{
				}
				num = (short)1655832576;
				short num3 = num;
				num = (short)1267138561;
				if (num != 0)
				{
				}
				num = (short)1139933184;
				if (num != 0)
				{
				}
				base.SetValue(O3GraphicView.UpButtonUIValueProperty, value);
			}
		}

		// Token: 0x170003C0 RID: 960
		// (get) Token: 0x060007C4 RID: 1988 RVA: 0x0006E244 File Offset: 0x0006C444
		// (set) Token: 0x060007C5 RID: 1989 RVA: 0x0006E2FC File Offset: 0x0006C4FC
		public AcpListField UpButtonList
		{
			get
			{
				short num = (short)2084264878;
				short num2 = num;
				num = (short)33971118;
				switch (num2 == num)
				{
				}
				num = (short)1438187520;
				short num3 = num;
				num = (short)698482689;
				if (num != 0)
				{
				}
				num = (short)1577517056;
				if (num != 0)
				{
				}
				return (AcpListField)base.GetValue(O3GraphicView.UpButtonListProperty);
			}
			set
			{
				short num = (short)469394883;
				short num2 = num;
				num = (short)1494967747;
				switch (num2 == num)
				{
				}
				num = (short)1979645952;
				short num3 = num;
				num = (short)2119106561;
				if (num != 0)
				{
				}
				num = (short)236978176;
				if (num != 0)
				{
				}
				base.SetValue(O3GraphicView.UpButtonListProperty, value);
			}
		}

		// Token: 0x170003C1 RID: 961
		// (get) Token: 0x060007C6 RID: 1990 RVA: 0x0006E3B0 File Offset: 0x0006C5B0
		// (set) Token: 0x060007C7 RID: 1991 RVA: 0x0006E468 File Offset: 0x0006C668
		public bool DownButtonIsAcpValid
		{
			get
			{
				short num = (short)53873518;
				short num2 = num;
				num = (short)1372588910;
				switch (num2 == num)
				{
				}
				num = (short)1724973056;
				short num3 = num;
				num = (short)1463418880;
				if (num != 0)
				{
				}
				num = (short)2089680897;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(O3GraphicView.DownButtonIsAcpValidProperty);
			}
			set
			{
				short num = (short)1007313508;
				short num2 = num;
				num = (short)27746916;
				switch (num2 == num)
				{
				}
				num = (short)746979328;
				short num3 = num;
				num = (short)1479475201;
				if (num != 0)
				{
				}
				num = (short)409075712;
				if (num != 0)
				{
				}
				base.SetValue(O3GraphicView.DownButtonIsAcpValidProperty, value);
			}
		}

		// Token: 0x170003C2 RID: 962
		// (get) Token: 0x060007C8 RID: 1992 RVA: 0x0006E528 File Offset: 0x0006C728
		// (set) Token: 0x060007C9 RID: 1993 RVA: 0x0006E5E0 File Offset: 0x0006C7E0
		public bool DownButtonIsAcpApplicable
		{
			get
			{
				short num = (short)253106674;
				short num2 = num;
				num = (short)1369577970;
				switch (num2 == num)
				{
				}
				num = (short)1238302720;
				short num3 = num;
				num = (short)1276051457;
				if (num != 0)
				{
				}
				num = (short)891944960;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(O3GraphicView.DownButtonIsAcpApplicableProperty);
			}
			set
			{
				short num = (short)137249643;
				short num2 = num;
				num = (short)1875788651;
				switch (num2 == num)
				{
				}
				num = (short)502988800;
				short num3 = num;
				num = (short)547684353;
				if (num != 0)
				{
				}
				num = (short)325058560;
				if (num != 0)
				{
				}
				base.SetValue(O3GraphicView.DownButtonIsAcpApplicableProperty, value);
			}
		}

		// Token: 0x170003C3 RID: 963
		// (get) Token: 0x060007CA RID: 1994 RVA: 0x0006E698 File Offset: 0x0006C898
		// (set) Token: 0x060007CB RID: 1995 RVA: 0x0006E754 File Offset: 0x0006C954
		public bool DownButtonIsAcpVisible
		{
			get
			{
				short num = (short)671730677;
				short num2 = num;
				num = (short)803064821;
				switch (num2 == num)
				{
				}
				num = (short)1710948352;
				short num3 = num;
				num = (short)713555969;
				if (num != 0)
				{
				}
				num = (short)1440219136;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(O3GraphicView.DownButtonIsAcpVisibleProperty);
			}
			set
			{
				short num = (short)1060442865;
				short num2 = num;
				num = (short)1298535153;
				switch (num2 == num)
				{
				}
				num = (short)519503872;
				short num3 = num;
				num = (short)458424320;
				if (num != 0)
				{
				}
				num = (short)1901789185;
				if (num != 0)
				{
				}
				base.SetValue(O3GraphicView.DownButtonIsAcpVisibleProperty, value);
			}
		}

		// Token: 0x170003C4 RID: 964
		// (get) Token: 0x060007CC RID: 1996 RVA: 0x0006E810 File Offset: 0x0006CA10
		// (set) Token: 0x060007CD RID: 1997 RVA: 0x0006E8C8 File Offset: 0x0006CAC8
		public bool DownButtonIsAcpEditable
		{
			get
			{
				short num = (short)1305266675;
				short num2 = num;
				num = (short)1561250291;
				switch (num2 == num)
				{
				}
				num = (short)526516224;
				short num3 = num;
				num = (short)408616961;
				if (num != 0)
				{
				}
				num = (short)114032640;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(O3GraphicView.DownButtonIsAcpEditableProperty);
			}
			set
			{
				short num = (short)110478198;
				short num2 = num;
				num = (short)1872348022;
				switch (num2 == num)
				{
				}
				num = (short)44957696;
				short num3 = num;
				num = (short)1286799361;
				if (num != 0)
				{
				}
				num = (short)933888000;
				if (num != 0)
				{
				}
				base.SetValue(O3GraphicView.DownButtonIsAcpEditableProperty, value);
			}
		}

		// Token: 0x170003C5 RID: 965
		// (get) Token: 0x060007CE RID: 1998 RVA: 0x0006E980 File Offset: 0x0006CB80
		// (set) Token: 0x060007CF RID: 1999 RVA: 0x0006EA38 File Offset: 0x0006CC38
		public string DownButtonUIValue
		{
			get
			{
				short num = (short)1284819154;
				short num2 = num;
				num = (short)1237043410;
				switch (num2 == num)
				{
				}
				num = (short)898170880;
				short num3 = num;
				num = (short)227672065;
				if (num != 0)
				{
				}
				num = (short)1520107520;
				if (num != 0)
				{
				}
				return (string)base.GetValue(O3GraphicView.DownButtonUIValueProperty);
			}
			set
			{
				short num = (short)362666912;
				short num2 = num;
				num = (short)1641143200;
				switch (num2 == num)
				{
				}
				num = (short)1128857600;
				short num3 = num;
				num = (short)980680705;
				if (num != 0)
				{
				}
				num = (short)754122752;
				if (num != 0)
				{
				}
				base.SetValue(O3GraphicView.DownButtonUIValueProperty, value);
			}
		}

		// Token: 0x170003C6 RID: 966
		// (get) Token: 0x060007D0 RID: 2000 RVA: 0x0006EAF0 File Offset: 0x0006CCF0
		// (set) Token: 0x060007D1 RID: 2001 RVA: 0x0006EBA8 File Offset: 0x0006CDA8
		public AcpListField DownButtonList
		{
			get
			{
				short num = (short)1639017250;
				short num2 = num;
				num = (short)874408738;
				switch (num2 == num)
				{
				}
				num = (short)139067392;
				short num3 = num;
				num = (short)712245248;
				if (num != 0)
				{
				}
				num = (short)683868161;
				if (num != 0)
				{
				}
				return (AcpListField)base.GetValue(O3GraphicView.DownButtonListProperty);
			}
			set
			{
				short num = (short)799006254;
				short num2 = num;
				num = (short)1599594030;
				switch (num2 == num)
				{
				}
				num = (short)1719861249;
				if (num != 0)
				{
				}
				num = (short)2132541440;
				if (num != 0)
				{
				}
				num = (short)393347072;
				short num3 = num;
				base.SetValue(O3GraphicView.DownButtonListProperty, value);
			}
		}

		// Token: 0x060007D4 RID: 2004 RVA: 0x0006FEFC File Offset: 0x0006E0FC
		// Note: this type is marked as 'beforefieldinit'.
		static O3GraphicView()
		{
			int a_ = 18;
			short num = (short)606918300;
			short num2 = num;
			num = (short)2010044060;
			switch (num2 == num)
			{
			default:
			{
				num = (short)2134376448;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1551761409;
			if (num != 0)
			{
			}
			num = (short)925302784;
			if (num != 0)
			{
			}
			O3GraphicView.TopRightButtonCnvIsAcpValidProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("椼倾ㅀᅂⱄ⁆ⅈ㽊ཌ㩎═❒㩔㥖ᩘ㕚⭜ᙞበ≢٤ᝦ㽨੪Ŭٮᕰ", a_), typeof(bool), typeof(O3GraphicView));
			O3GraphicView.TopRightButtonCnvIsAcpApplicableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("椼倾ㅀᅂⱄ⁆ⅈ㽊ཌ㩎═❒㩔㥖ᩘ㕚⭜ᙞበ≢٤ᝦ⡨᭪ᵬͮᡰၲᑴᕶᕸṺ", a_), typeof(bool), typeof(O3GraphicView));
			O3GraphicView.TopRightButtonCnvIsAcpVisibleProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("椼倾ㅀᅂⱄ⁆ⅈ㽊ཌ㩎═❒㩔㥖ᩘ㕚⭜ᙞበ≢٤ᝦ㽨ɪṬٮ፰ὲၴ", a_), typeof(bool), typeof(O3GraphicView));
			O3GraphicView.TopRightButtonCnvIsAcpEditableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("椼倾ㅀᅂⱄ⁆ⅈ㽊ཌ㩎═❒㩔㥖ᩘ㕚⭜ᙞበ≢٤ᝦⱨཪѬ᭮ၰᅲᥴቶ", a_), typeof(bool), typeof(O3GraphicView));
			O3GraphicView.TopRightButtonCnvUIValueProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("椼倾ㅀᅂⱄ⁆ⅈ㽊ཌ㩎═❒㩔㥖ᩘ㕚⭜ਫ਼⡠㕢Ѥ୦ᱨ๪", a_), typeof(string), typeof(O3GraphicView));
			O3GraphicView.TopRightButtonCnvListProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("椼倾ㅀᅂⱄ⁆ⅈ㽊ཌ㩎═❒㩔㥖ᩘ㕚⭜፞ࡠၢᅤ", a_), typeof(AcpListField), typeof(O3GraphicView));
			O3GraphicView.TopRightButtonTrkIsAcpValidProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("椼倾ㅀᅂⱄ⁆ⅈ㽊ཌ㩎═❒㩔㥖൘⥚㙜ᙞበ≢٤ᝦ㽨੪Ŭٮᕰ", a_), typeof(bool), typeof(O3GraphicView));
			O3GraphicView.TopRightButtonTrkIsAcpApplicableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("椼倾ㅀᅂⱄ⁆ⅈ㽊ཌ㩎═❒㩔㥖൘⥚㙜ᙞበ≢٤ᝦ⡨᭪ᵬͮᡰၲᑴᕶᕸṺ", a_), typeof(bool), typeof(O3GraphicView));
			O3GraphicView.TopRightButtonTrkIsAcpVisibleProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("椼倾ㅀᅂⱄ⁆ⅈ㽊ཌ㩎═❒㩔㥖൘⥚㙜ᙞበ≢٤ᝦ㽨ɪṬٮ፰ὲၴ", a_), typeof(bool), typeof(O3GraphicView));
			O3GraphicView.TopRightButtonTrkIsAcpEditableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("椼倾ㅀᅂⱄ⁆ⅈ㽊ཌ㩎═❒㩔㥖൘⥚㙜ᙞበ≢٤ᝦⱨཪѬ᭮ၰᅲᥴቶ", a_), typeof(bool), typeof(O3GraphicView));
			O3GraphicView.TopRightButtonTrkUIValueProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("椼倾ㅀᅂⱄ⁆ⅈ㽊ཌ㩎═❒㩔㥖൘⥚㙜ਫ਼⡠㕢Ѥ୦ᱨ๪", a_), typeof(string), typeof(O3GraphicView));
			O3GraphicView.TopRightButtonTrkListProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("椼倾ㅀᅂⱄ⁆ⅈ㽊ཌ㩎═❒㩔㥖൘⥚㙜፞ࡠၢᅤ", a_), typeof(AcpListField), typeof(O3GraphicView));
			O3GraphicView.TopMiddleButtonCnvIsAcpValidProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("椼倾ㅀโⱄ⍆ⵈ❊⡌ൎ⑐❒⅔㡖㝘ᡚ㍜⥞⡠ၢ⑤Ѧᥨ㵪౬ͮᡰᝲ", a_), typeof(bool), typeof(O3GraphicView));
			O3GraphicView.TopMiddleButtonCnvIsAcpApplicableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("椼倾ㅀโⱄ⍆ⵈ❊⡌ൎ⑐❒⅔㡖㝘ᡚ㍜⥞⡠ၢ⑤Ѧᥨ⩪ᵬὮᵰᩲᙴᙶ᭸᝺᡼", a_), typeof(bool), typeof(O3GraphicView));
			O3GraphicView.TopMiddleButtonCnvIsAcpVisibleProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("椼倾ㅀโⱄ⍆ⵈ❊⡌ൎ⑐❒⅔㡖㝘ᡚ㍜⥞⡠ၢ⑤Ѧᥨ㵪Ѭᱮᡰᅲᥴቶ", a_), typeof(bool), typeof(O3GraphicView));
			O3GraphicView.TopMiddleButtonCnvIsAcpEditableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("椼倾ㅀโⱄ⍆ⵈ❊⡌ൎ⑐❒⅔㡖㝘ᡚ㍜⥞⡠ၢ⑤Ѧᥨ⹪६ٮհቲ᝴᭶ᱸ", a_), typeof(bool), typeof(O3GraphicView));
			O3GraphicView.TopMiddleButtonCnvUIValueProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("椼倾ㅀโⱄ⍆ⵈ❊⡌ൎ⑐❒⅔㡖㝘ᡚ㍜⥞㑠⩢㍤٦ըṪ࡬", a_), typeof(string), typeof(O3GraphicView));
			O3GraphicView.TopMiddleButtonCnvListProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("椼倾ㅀโⱄ⍆ⵈ❊⡌ൎ⑐❒⅔㡖㝘ᡚ㍜⥞ⵠ੢ᙤ፦", a_), typeof(AcpListField), typeof(O3GraphicView));
			O3GraphicView.TopMiddleButtonTrkIsAcpValidProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("椼倾ㅀโⱄ⍆ⵈ❊⡌ൎ⑐❒⅔㡖㝘ཚ⽜㑞⡠ၢ⑤Ѧᥨ㵪౬ͮᡰᝲ", a_), typeof(bool), typeof(O3GraphicView));
			O3GraphicView.TopMiddleButtonTrkIsAcpApplicableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("椼倾ㅀโⱄ⍆ⵈ❊⡌ൎ⑐❒⅔㡖㝘ཚ⽜㑞⡠ၢ⑤Ѧᥨ⩪ᵬὮᵰᩲᙴᙶ᭸᝺᡼", a_), typeof(bool), typeof(O3GraphicView));
			O3GraphicView.TopMiddleButtonTrkIsAcpVisibleProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("椼倾ㅀโⱄ⍆ⵈ❊⡌ൎ⑐❒⅔㡖㝘ཚ⽜㑞⡠ၢ⑤Ѧᥨ㵪Ѭᱮᡰᅲᥴቶ", a_), typeof(bool), typeof(O3GraphicView));
			O3GraphicView.TopMiddleButtonTrkIsAcpEditableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("椼倾ㅀโⱄ⍆ⵈ❊⡌ൎ⑐❒⅔㡖㝘ཚ⽜㑞⡠ၢ⑤Ѧᥨ⹪६ٮհቲ᝴᭶ᱸ", a_), typeof(bool), typeof(O3GraphicView));
			O3GraphicView.TopMiddleButtonTrkUIValueProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("椼倾ㅀโⱄ⍆ⵈ❊⡌ൎ⑐❒⅔㡖㝘ཚ⽜㑞㑠⩢㍤٦ըṪ࡬", a_), typeof(string), typeof(O3GraphicView));
			O3GraphicView.TopMiddleButtonTrkListProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("椼倾ㅀโⱄ⍆ⵈ❊⡌ൎ⑐❒⅔㡖㝘ཚ⽜㑞ⵠ੢ᙤ፦", a_), typeof(AcpListField), typeof(O3GraphicView));
			O3GraphicView.SideTopButtonCnvIsAcpValidProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("渼嘾╀♂ᅄ⡆㥈ॊ㡌㭎═㱒㭔ᑖ㝘ⵚᑜⱞ⁠bᕤㅦࡨݪѬ୮", a_), typeof(bool), typeof(O3GraphicView));
			O3GraphicView.SideTopButtonCnvIsAcpApplicableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("渼嘾╀♂ᅄ⡆㥈ॊ㡌㭎═㱒㭔ᑖ㝘ⵚᑜⱞ⁠bᕤ♦ᥨ᭪Ŭٮተቲ᝴᭶ᱸ", a_), typeof(bool), typeof(O3GraphicView));
			O3GraphicView.SideTopButtonCnvIsAcpVisibleProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("渼嘾╀♂ᅄ⡆㥈ॊ㡌㭎═㱒㭔ᑖ㝘ⵚᑜⱞ⁠bᕤㅦhᡪѬ൮ᵰᙲ", a_), typeof(bool), typeof(O3GraphicView));
			O3GraphicView.SideTopButtonCnvIsAcpEditableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("渼嘾╀♂ᅄ⡆㥈ॊ㡌㭎═㱒㭔ᑖ㝘ⵚᑜⱞ⁠bᕤ≦൨ɪᥬ๮፰ὲၴ", a_), typeof(bool), typeof(O3GraphicView));
			O3GraphicView.SideTopButtonCnvUIValueProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("渼嘾╀♂ᅄ⡆㥈ॊ㡌㭎═㱒㭔ᑖ㝘ⵚ࡜ᙞ㝠ɢ।ቦ౨", a_), typeof(string), typeof(O3GraphicView));
			O3GraphicView.SideTopButtonCnvListProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("渼嘾╀♂ᅄ⡆㥈ॊ㡌㭎═㱒㭔ᑖ㝘ⵚᅜ㙞በᝢ", a_), typeof(AcpListField), typeof(O3GraphicView));
			O3GraphicView.SideTopButtonTrkIsAcpValidProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("渼嘾╀♂ᅄ⡆㥈ॊ㡌㭎═㱒㭔͖⭘ずᑜⱞ⁠bᕤㅦࡨݪѬ୮", a_), typeof(bool), typeof(O3GraphicView));
			O3GraphicView.SideTopButtonTrkIsAcpApplicableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("渼嘾╀♂ᅄ⡆㥈ॊ㡌㭎═㱒㭔͖⭘ずᑜⱞ⁠bᕤ♦ᥨ᭪Ŭٮተቲ᝴᭶ᱸ", a_), typeof(bool), typeof(O3GraphicView));
			O3GraphicView.SideTopButtonTrkIsAcpVisibleProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("渼嘾╀♂ᅄ⡆㥈ॊ㡌㭎═㱒㭔͖⭘ずᑜⱞ⁠bᕤㅦhᡪѬ൮ᵰᙲ", a_), typeof(bool), typeof(O3GraphicView));
			O3GraphicView.SideTopButtonTrkIsAcpEditableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("渼嘾╀♂ᅄ⡆㥈ॊ㡌㭎═㱒㭔͖⭘ずᑜⱞ⁠bᕤ≦൨ɪᥬ๮፰ὲၴ", a_), typeof(bool), typeof(O3GraphicView));
			O3GraphicView.SideTopButtonTrkUIValueProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("渼嘾╀♂ᅄ⡆㥈ॊ㡌㭎═㱒㭔͖⭘ず࡜ᙞ㝠ɢ।ቦ౨", a_), typeof(string), typeof(O3GraphicView));
			O3GraphicView.SideTopButtonTrkListProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("渼嘾╀♂ᅄ⡆㥈ॊ㡌㭎═㱒㭔͖⭘ずᅜ㙞በᝢ", a_), typeof(AcpListField), typeof(O3GraphicView));
			O3GraphicView.SideMiddleButtonCnvIsAcpValidProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("渼嘾╀♂ࡄ⹆ⵈ⽊⅌⩎ፐ♒⅔⍖㙘㕚Ṝㅞᝠ⩢ᙤ♦੨᭪㭬๮ᵰᩲᅴ", a_), typeof(bool), typeof(O3GraphicView));
			O3GraphicView.SideMiddleButtonCnvIsAcpApplicableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("渼嘾╀♂ࡄ⹆ⵈ⽊⅌⩎ፐ♒⅔⍖㙘㕚Ṝㅞᝠ⩢ᙤ♦੨᭪ⱬὮŰὲᱴᑶᡸ᥺ᅼ᩾", a_), typeof(bool), typeof(O3GraphicView));
			O3GraphicView.SideMiddleButtonCnvIsAcpVisibleProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("渼嘾╀♂ࡄ⹆ⵈ⽊⅌⩎ፐ♒⅔⍖㙘㕚Ṝㅞᝠ⩢ᙤ♦੨᭪㭬ٮɰᩲ᝴᭶ᱸ", a_), typeof(bool), typeof(O3GraphicView));
			O3GraphicView.SideMiddleButtonCnvIsAcpEditableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("渼嘾╀♂ࡄ⹆ⵈ⽊⅌⩎ፐ♒⅔⍖㙘㕚Ṝㅞᝠ⩢ᙤ♦੨᭪⡬୮ᡰݲᑴᕶᕸṺ", a_), typeof(bool), typeof(O3GraphicView));
			O3GraphicView.SideMiddleButtonCnvUIValueProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("渼嘾╀♂ࡄ⹆ⵈ⽊⅌⩎ፐ♒⅔⍖㙘㕚Ṝㅞᝠ㙢Ɽㅦࡨݪᡬ੮", a_), typeof(string), typeof(O3GraphicView));
			O3GraphicView.SideMiddleButtonCnvListProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("渼嘾╀♂ࡄ⹆ⵈ⽊⅌⩎ፐ♒⅔⍖㙘㕚Ṝㅞᝠ⽢౤ᑦᵨ", a_), typeof(AcpListField), typeof(O3GraphicView));
			O3GraphicView.SideMiddleButtonTrkIsAcpValidProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("渼嘾╀♂ࡄ⹆ⵈ⽊⅌⩎ፐ♒⅔⍖㙘㕚ड़ⵞ੠⩢ᙤ♦੨᭪㭬๮ᵰᩲᅴ", a_), typeof(bool), typeof(O3GraphicView));
			O3GraphicView.SideMiddleButtonTrkIsAcpApplicableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("渼嘾╀♂ࡄ⹆ⵈ⽊⅌⩎ፐ♒⅔⍖㙘㕚ड़ⵞ੠⩢ᙤ♦੨᭪ⱬὮŰὲᱴᑶᡸ᥺ᅼ᩾", a_), typeof(bool), typeof(O3GraphicView));
			O3GraphicView.SideMiddleButtonTrkIsAcpVisibleProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("渼嘾╀♂ࡄ⹆ⵈ⽊⅌⩎ፐ♒⅔⍖㙘㕚ड़ⵞ੠⩢ᙤ♦੨᭪㭬ٮɰᩲ᝴᭶ᱸ", a_), typeof(bool), typeof(O3GraphicView));
			O3GraphicView.SideMiddleButtonTrkIsAcpEditableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("渼嘾╀♂ࡄ⹆ⵈ⽊⅌⩎ፐ♒⅔⍖㙘㕚ड़ⵞ੠⩢ᙤ♦੨᭪⡬୮ᡰݲᑴᕶᕸṺ", a_), typeof(bool), typeof(O3GraphicView));
			O3GraphicView.SideMiddleButtonTrkUIValueProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("渼嘾╀♂ࡄ⹆ⵈ⽊⅌⩎ፐ♒⅔⍖㙘㕚ड़ⵞ੠㙢Ɽㅦࡨݪᡬ੮", a_), typeof(string), typeof(O3GraphicView));
			O3GraphicView.SideMiddleButtonTrkListProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("渼嘾╀♂ࡄ⹆ⵈ⽊⅌⩎ፐ♒⅔⍖㙘㕚ड़ⵞ੠⽢౤ᑦᵨ", a_), typeof(AcpListField), typeof(O3GraphicView));
			O3GraphicView.SideBottomButtonCnvIsAcpValidProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("渼嘾╀♂݄⡆㵈㽊≌≎ፐ♒⅔⍖㙘㕚Ṝㅞᝠ⩢ᙤ♦੨᭪㭬๮ᵰᩲᅴ", a_), typeof(bool), typeof(O3GraphicView));
			O3GraphicView.SideBottomButtonCnvIsAcpApplicableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("渼嘾╀♂݄⡆㵈㽊≌≎ፐ♒⅔⍖㙘㕚Ṝㅞᝠ⩢ᙤ♦੨᭪ⱬὮŰὲᱴᑶᡸ᥺ᅼ᩾", a_), typeof(bool), typeof(O3GraphicView));
			O3GraphicView.SideBottomButtonCnvIsAcpVisibleProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("渼嘾╀♂݄⡆㵈㽊≌≎ፐ♒⅔⍖㙘㕚Ṝㅞᝠ⩢ᙤ♦੨᭪㭬ٮɰᩲ᝴᭶ᱸ", a_), typeof(bool), typeof(O3GraphicView));
			O3GraphicView.SideBottomButtonCnvIsAcpEditableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("渼嘾╀♂݄⡆㵈㽊≌≎ፐ♒⅔⍖㙘㕚Ṝㅞᝠ⩢ᙤ♦੨᭪⡬୮ᡰݲᑴᕶᕸṺ", a_), typeof(bool), typeof(O3GraphicView));
			O3GraphicView.SideBottomButtonCnvUIValueProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("渼嘾╀♂݄⡆㵈㽊≌≎ፐ♒⅔⍖㙘㕚Ṝㅞᝠ㙢Ɽㅦࡨݪᡬ੮", a_), typeof(string), typeof(O3GraphicView));
			O3GraphicView.SideBottomButtonCnvListProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("渼嘾╀♂݄⡆㵈㽊≌≎ፐ♒⅔⍖㙘㕚Ṝㅞᝠ⽢౤ᑦᵨ", a_), typeof(AcpListField), typeof(O3GraphicView));
			O3GraphicView.SideBottomButtonTrkIsAcpValidProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("渼嘾╀♂݄⡆㵈㽊≌≎ፐ♒⅔⍖㙘㕚ड़ⵞ੠⩢ᙤ♦੨᭪㭬๮ᵰᩲᅴ", a_), typeof(bool), typeof(O3GraphicView));
			O3GraphicView.SideBottomButtonTrkIsAcpApplicableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("渼嘾╀♂݄⡆㵈㽊≌≎ፐ♒⅔⍖㙘㕚ड़ⵞ੠⩢ᙤ♦੨᭪ⱬὮŰὲᱴᑶᡸ᥺ᅼ᩾", a_), typeof(bool), typeof(O3GraphicView));
			O3GraphicView.SideBottomButtonTrkIsAcpVisibleProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("渼嘾╀♂݄⡆㵈㽊≌≎ፐ♒⅔⍖㙘㕚ड़ⵞ੠⩢ᙤ♦੨᭪㭬ٮɰᩲ᝴᭶ᱸ", a_), typeof(bool), typeof(O3GraphicView));
			O3GraphicView.SideBottomButtonTrkIsAcpEditableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("渼嘾╀♂݄⡆㵈㽊≌≎ፐ♒⅔⍖㙘㕚ड़ⵞ੠⩢ᙤ♦੨᭪⡬୮ᡰݲᑴᕶᕸṺ", a_), typeof(bool), typeof(O3GraphicView));
			O3GraphicView.SideBottomButtonTrkUIValueProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("渼嘾╀♂݄⡆㵈㽊≌≎ፐ♒⅔⍖㙘㕚ड़ⵞ੠㙢Ɽㅦࡨݪᡬ੮", a_), typeof(string), typeof(O3GraphicView));
			O3GraphicView.SideBottomButtonTrkListProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("渼嘾╀♂݄⡆㵈㽊≌≎ፐ♒⅔⍖㙘㕚ड़ⵞ੠⽢౤ᑦᵨ", a_), typeof(AcpListField), typeof(O3GraphicView));
			O3GraphicView.DataButtonCnvIsAcpValidProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("礼帾㕀≂݄㉆㵈㽊≌ⅎቐ㵒⍔Ṗ⩘ᩚ㹜⽞㝠ɢ।๦൨", a_), typeof(bool), typeof(O3GraphicView));
			O3GraphicView.DataButtonCnvIsAcpApplicableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("礼帾㕀≂݄㉆㵈㽊≌ⅎቐ㵒⍔Ṗ⩘ᩚ㹜⽞⁠።ᕤ୦hࡪ౬൮ᵰᙲ", a_), typeof(bool), typeof(O3GraphicView));
			O3GraphicView.DataButtonCnvIsAcpVisibleProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("礼帾㕀≂݄㉆㵈㽊≌ⅎቐ㵒⍔Ṗ⩘ᩚ㹜⽞㝠੢ᙤ๦୨ݪ࡬", a_), typeof(bool), typeof(O3GraphicView));
			O3GraphicView.DataButtonCnvIsAcpEditableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("礼帾㕀≂݄㉆㵈㽊≌ⅎቐ㵒⍔Ṗ⩘ᩚ㹜⽞①ݢ౤፦ࡨ४Ŭ੮", a_), typeof(bool), typeof(O3GraphicView));
			O3GraphicView.DataButtonCnvUIValueProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("礼帾㕀≂݄㉆㵈㽊≌ⅎቐ㵒⍔ɖၘ൚㱜㍞ᑠ٢", a_), typeof(string), typeof(O3GraphicView));
			O3GraphicView.DataButtonCnvListProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("礼帾㕀≂݄㉆㵈㽊≌ⅎቐ㵒⍔᭖じ⡚⥜", a_), typeof(AcpListField), typeof(O3GraphicView));
			O3GraphicView.DataButtonCnvIndexIsAcpValidProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("礼帾㕀≂݄㉆㵈㽊≌ⅎቐ㵒⍔Ṗ㝘㽚㡜❞⡠ၢ⑤Ѧᥨ㵪౬ͮᡰᝲ", a_), typeof(bool), typeof(O3GraphicView));
			O3GraphicView.DataButtonCnvIndexIsAcpApplicableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("礼帾㕀≂݄㉆㵈㽊≌ⅎቐ㵒⍔Ṗ㝘㽚㡜❞⡠ၢ⑤Ѧᥨ⩪ᵬὮᵰᩲᙴᙶ᭸᝺᡼", a_), typeof(bool), typeof(O3GraphicView));
			O3GraphicView.DataButtonCnvIndexIsAcpVisibleProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("礼帾㕀≂݄㉆㵈㽊≌ⅎቐ㵒⍔Ṗ㝘㽚㡜❞⡠ၢ⑤Ѧᥨ㵪Ѭᱮᡰᅲᥴቶ", a_), typeof(bool), typeof(O3GraphicView));
			O3GraphicView.DataButtonCnvIndexIsAcpEditableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("礼帾㕀≂݄㉆㵈㽊≌ⅎቐ㵒⍔Ṗ㝘㽚㡜❞⡠ၢ⑤Ѧᥨ⹪६ٮհቲ᝴᭶ᱸ", a_), typeof(bool), typeof(O3GraphicView));
			O3GraphicView.DataButtonCnvIndexUIValueProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("礼帾㕀≂݄㉆㵈㽊≌ⅎቐ㵒⍔Ṗ㝘㽚㡜❞㑠⩢㍤٦ըṪ࡬", a_), typeof(string), typeof(O3GraphicView));
			O3GraphicView.DataButtonCnvIndexListProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("礼帾㕀≂݄㉆㵈㽊≌ⅎቐ㵒⍔Ṗ㝘㽚㡜❞ⵠ੢ᙤ፦", a_), typeof(AcpListField), typeof(O3GraphicView));
			O3GraphicView.DataButtonTrkIsAcpValidProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("礼帾㕀≂݄㉆㵈㽊≌ⅎՐ⅒㹔Ṗ⩘ᩚ㹜⽞㝠ɢ।๦൨", a_), typeof(bool), typeof(O3GraphicView));
			O3GraphicView.DataButtonTrkIsAcpApplicableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("礼帾㕀≂݄㉆㵈㽊≌ⅎՐ⅒㹔Ṗ⩘ᩚ㹜⽞⁠።ᕤ୦hࡪ౬൮ᵰᙲ", a_), typeof(bool), typeof(O3GraphicView));
			O3GraphicView.DataButtonTrkIsAcpVisibleProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("礼帾㕀≂݄㉆㵈㽊≌ⅎՐ⅒㹔Ṗ⩘ᩚ㹜⽞㝠੢ᙤ๦୨ݪ࡬", a_), typeof(bool), typeof(O3GraphicView));
			O3GraphicView.DataButtonTrkIsAcpEditableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("礼帾㕀≂݄㉆㵈㽊≌ⅎՐ⅒㹔Ṗ⩘ᩚ㹜⽞①ݢ౤፦ࡨ४Ŭ੮", a_), typeof(bool), typeof(O3GraphicView));
			O3GraphicView.DataButtonTrkUIValueProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("礼帾㕀≂݄㉆㵈㽊≌ⅎՐ⅒㹔ɖၘ൚㱜㍞ᑠ٢", a_), typeof(string), typeof(O3GraphicView));
			O3GraphicView.DataButtonTrkListProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("礼帾㕀≂݄㉆㵈㽊≌ⅎՐ⅒㹔᭖じ⡚⥜", a_), typeof(AcpListField), typeof(O3GraphicView));
			O3GraphicView.DataButtonTrkIndexIsAcpValidProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("礼帾㕀≂݄㉆㵈㽊≌ⅎՐ⅒㹔Ṗ㝘㽚㡜❞⡠ၢ⑤Ѧᥨ㵪౬ͮᡰᝲ", a_), typeof(bool), typeof(O3GraphicView));
			O3GraphicView.DataButtonTrkIndexIsAcpApplicableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("礼帾㕀≂݄㉆㵈㽊≌ⅎՐ⅒㹔Ṗ㝘㽚㡜❞⡠ၢ⑤Ѧᥨ⩪ᵬὮᵰᩲᙴᙶ᭸᝺᡼", a_), typeof(bool), typeof(O3GraphicView));
			O3GraphicView.DataButtonTrkIndexIsAcpVisibleProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("礼帾㕀≂݄㉆㵈㽊≌ⅎՐ⅒㹔Ṗ㝘㽚㡜❞⡠ၢ⑤Ѧᥨ㵪Ѭᱮᡰᅲᥴቶ", a_), typeof(bool), typeof(O3GraphicView));
			O3GraphicView.DataButtonTrkIndexIsAcpEditableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("礼帾㕀≂݄㉆㵈㽊≌ⅎՐ⅒㹔Ṗ㝘㽚㡜❞⡠ၢ⑤Ѧᥨ⹪६ٮհቲ᝴᭶ᱸ", a_), typeof(bool), typeof(O3GraphicView));
			O3GraphicView.DataButtonTrkIndexUIValueProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("礼帾㕀≂݄㉆㵈㽊≌ⅎՐ⅒㹔Ṗ㝘㽚㡜❞㑠⩢㍤٦ըṪ࡬", a_), typeof(string), typeof(O3GraphicView));
			O3GraphicView.DataButtonTrkIndexListProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("礼帾㕀≂݄㉆㵈㽊≌ⅎՐ⅒㹔Ṗ㝘㽚㡜❞ⵠ੢ᙤ፦", a_), typeof(AcpListField), typeof(O3GraphicView));
			O3GraphicView.UpButtonIsAcpValidProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("格伾̀㙂ㅄ㍆♈╊ь㱎ၐげ╔Ŗ㡘㝚㑜㭞", a_), typeof(bool), typeof(O3GraphicView));
			O3GraphicView.UpButtonIsAcpApplicableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("格伾̀㙂ㅄ㍆♈╊ь㱎ၐげ╔ᙖ⥘⭚ㅜ㙞ɠɢݤ୦౨", a_), typeof(bool), typeof(O3GraphicView));
			O3GraphicView.UpButtonIsAcpVisibleProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("格伾̀㙂ㅄ㍆♈╊ь㱎ၐげ╔Ŗじ⡚㑜㵞ൠ٢", a_), typeof(bool), typeof(O3GraphicView));
			O3GraphicView.UpButtonIsAcpEditableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("格伾̀㙂ㅄ㍆♈╊ь㱎ၐげ╔ቖ㵘㉚⥜㹞͠རd", a_), typeof(bool), typeof(O3GraphicView));
			O3GraphicView.UpButtonUIValueProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("格伾̀㙂ㅄ㍆♈╊ᡌَݐ㉒㥔≖㱘", a_), typeof(string), typeof(O3GraphicView));
			O3GraphicView.UpButtonListProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("格伾̀㙂ㅄ㍆♈╊Ō♎≐❒", a_), typeof(AcpListField), typeof(O3GraphicView));
			O3GraphicView.DownButtonIsAcpValidProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("礼倾㙀ⵂ݄㉆㵈㽊≌ⅎᡐ⁒ᑔ㑖⥘൚㱜㍞ࡠݢ", a_), typeof(bool), typeof(O3GraphicView));
			O3GraphicView.DownButtonIsAcpApplicableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("礼倾㙀ⵂ݄㉆㵈㽊≌ⅎᡐ⁒ᑔ㑖⥘ᩚⵜ⽞ൠ੢٤٦୨ݪ࡬", a_), typeof(bool), typeof(O3GraphicView));
			O3GraphicView.DownButtonIsAcpVisibleProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("礼倾㙀ⵂ݄㉆㵈㽊≌ⅎᡐ⁒ᑔ㑖⥘൚㑜ⱞࡠŢ।ɦ", a_), typeof(bool), typeof(O3GraphicView));
			O3GraphicView.DownButtonIsAcpEditableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("礼倾㙀ⵂ݄㉆㵈㽊≌ⅎᡐ⁒ᑔ㑖⥘Ṛ㥜㙞ᕠɢݤ୦౨", a_), typeof(bool), typeof(O3GraphicView));
			O3GraphicView.DownButtonUIValueProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("礼倾㙀ⵂ݄㉆㵈㽊≌ⅎѐᩒ͔㙖㕘⹚㡜", a_), typeof(string), typeof(O3GraphicView));
			O3GraphicView.DownButtonListProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("礼倾㙀ⵂ݄㉆㵈㽊≌ⅎᵐ㩒♔⍖", a_), typeof(AcpListField), typeof(O3GraphicView));
		}

		// Token: 0x040007CA RID: 1994
		private bool isTopRightButtonCnvFeatureAnimating;

		// Token: 0x040007CB RID: 1995
		private bool isTopRightButtonTrkFeatureAnimating;

		// Token: 0x040007CC RID: 1996
		private bool isTopMiddleButtonCnvFeatureAnimating;

		// Token: 0x040007CD RID: 1997
		private bool isTopMiddleButtonTrkFeatureAnimating;

		// Token: 0x040007CE RID: 1998
		private bool isSideTopButtonCnvFeatureAnimating;

		// Token: 0x040007CF RID: 1999
		private bool isSideTopButtonTrkFeatureAnimating;

		// Token: 0x040007D0 RID: 2000
		private bool isSideMiddleButtonCnvFeatureAnimating;

		// Token: 0x040007D1 RID: 2001
		private bool isSideMiddleButtonTrkFeatureAnimating;

		// Token: 0x040007D2 RID: 2002
		private bool isSideBottomButtonCnvFeatureAnimating;

		// Token: 0x040007D3 RID: 2003
		private bool isSideBottomButtonTrkFeatureAnimating;

		// Token: 0x040007D4 RID: 2004
		public static DependencyProperty TopRightButtonCnvIsAcpValidProperty;

		// Token: 0x040007D5 RID: 2005
		public static DependencyProperty TopRightButtonCnvIsAcpApplicableProperty;

		// Token: 0x040007D6 RID: 2006
		public static DependencyProperty TopRightButtonCnvIsAcpVisibleProperty;

		// Token: 0x040007D7 RID: 2007
		public static DependencyProperty TopRightButtonCnvIsAcpEditableProperty;

		// Token: 0x040007D8 RID: 2008
		public static DependencyProperty TopRightButtonCnvUIValueProperty;

		// Token: 0x040007D9 RID: 2009
		public static DependencyProperty TopRightButtonCnvListProperty;

		// Token: 0x040007DA RID: 2010
		public static DependencyProperty TopRightButtonTrkIsAcpValidProperty;

		// Token: 0x040007DB RID: 2011
		public static DependencyProperty TopRightButtonTrkIsAcpApplicableProperty;

		// Token: 0x040007DC RID: 2012
		public static DependencyProperty TopRightButtonTrkIsAcpVisibleProperty;

		// Token: 0x040007DD RID: 2013
		public static DependencyProperty TopRightButtonTrkIsAcpEditableProperty;

		// Token: 0x040007DE RID: 2014
		public static DependencyProperty TopRightButtonTrkUIValueProperty;

		// Token: 0x040007DF RID: 2015
		public static DependencyProperty TopRightButtonTrkListProperty;

		// Token: 0x040007E0 RID: 2016
		public static DependencyProperty TopMiddleButtonCnvIsAcpValidProperty;

		// Token: 0x040007E1 RID: 2017
		public static DependencyProperty TopMiddleButtonCnvIsAcpApplicableProperty;

		// Token: 0x040007E2 RID: 2018
		public static DependencyProperty TopMiddleButtonCnvIsAcpVisibleProperty;

		// Token: 0x040007E3 RID: 2019
		public static DependencyProperty TopMiddleButtonCnvIsAcpEditableProperty;

		// Token: 0x040007E4 RID: 2020
		public static DependencyProperty TopMiddleButtonCnvUIValueProperty;

		// Token: 0x040007E5 RID: 2021
		public static DependencyProperty TopMiddleButtonCnvListProperty;

		// Token: 0x040007E6 RID: 2022
		public static DependencyProperty TopMiddleButtonTrkIsAcpValidProperty;

		// Token: 0x040007E7 RID: 2023
		public static DependencyProperty TopMiddleButtonTrkIsAcpApplicableProperty;

		// Token: 0x040007E8 RID: 2024
		public static DependencyProperty TopMiddleButtonTrkIsAcpVisibleProperty;

		// Token: 0x040007E9 RID: 2025
		public static DependencyProperty TopMiddleButtonTrkIsAcpEditableProperty;

		// Token: 0x040007EA RID: 2026
		public static DependencyProperty TopMiddleButtonTrkUIValueProperty;

		// Token: 0x040007EB RID: 2027
		public static DependencyProperty TopMiddleButtonTrkListProperty;

		// Token: 0x040007EC RID: 2028
		public static DependencyProperty SideTopButtonCnvIsAcpValidProperty;

		// Token: 0x040007ED RID: 2029
		public static DependencyProperty SideTopButtonCnvIsAcpApplicableProperty;

		// Token: 0x040007EE RID: 2030
		public static DependencyProperty SideTopButtonCnvIsAcpVisibleProperty;

		// Token: 0x040007EF RID: 2031
		public static DependencyProperty SideTopButtonCnvIsAcpEditableProperty;

		// Token: 0x040007F0 RID: 2032
		public static DependencyProperty SideTopButtonCnvUIValueProperty;

		// Token: 0x040007F1 RID: 2033
		public static DependencyProperty SideTopButtonCnvListProperty;

		// Token: 0x040007F2 RID: 2034
		public static DependencyProperty SideTopButtonTrkIsAcpValidProperty;

		// Token: 0x040007F3 RID: 2035
		public static DependencyProperty SideTopButtonTrkIsAcpApplicableProperty;

		// Token: 0x040007F4 RID: 2036
		public static DependencyProperty SideTopButtonTrkIsAcpVisibleProperty;

		// Token: 0x040007F5 RID: 2037
		public static DependencyProperty SideTopButtonTrkIsAcpEditableProperty;

		// Token: 0x040007F6 RID: 2038
		public static DependencyProperty SideTopButtonTrkUIValueProperty;

		// Token: 0x040007F7 RID: 2039
		public static DependencyProperty SideTopButtonTrkListProperty;

		// Token: 0x040007F8 RID: 2040
		public static DependencyProperty SideMiddleButtonCnvIsAcpValidProperty;

		// Token: 0x040007F9 RID: 2041
		public static DependencyProperty SideMiddleButtonCnvIsAcpApplicableProperty;

		// Token: 0x040007FA RID: 2042
		public static DependencyProperty SideMiddleButtonCnvIsAcpVisibleProperty;

		// Token: 0x040007FB RID: 2043
		public static DependencyProperty SideMiddleButtonCnvIsAcpEditableProperty;

		// Token: 0x040007FC RID: 2044
		public static DependencyProperty SideMiddleButtonCnvUIValueProperty;

		// Token: 0x040007FD RID: 2045
		public static DependencyProperty SideMiddleButtonCnvListProperty;

		// Token: 0x040007FE RID: 2046
		public static DependencyProperty SideMiddleButtonTrkIsAcpValidProperty;

		// Token: 0x040007FF RID: 2047
		public static DependencyProperty SideMiddleButtonTrkIsAcpApplicableProperty;

		// Token: 0x04000800 RID: 2048
		public static DependencyProperty SideMiddleButtonTrkIsAcpVisibleProperty;

		// Token: 0x04000801 RID: 2049
		public static DependencyProperty SideMiddleButtonTrkIsAcpEditableProperty;

		// Token: 0x04000802 RID: 2050
		public static DependencyProperty SideMiddleButtonTrkUIValueProperty;

		// Token: 0x04000803 RID: 2051
		public static DependencyProperty SideMiddleButtonTrkListProperty;

		// Token: 0x04000804 RID: 2052
		public static DependencyProperty SideBottomButtonCnvIsAcpValidProperty;

		// Token: 0x04000805 RID: 2053
		public static DependencyProperty SideBottomButtonCnvIsAcpApplicableProperty;

		// Token: 0x04000806 RID: 2054
		public static DependencyProperty SideBottomButtonCnvIsAcpVisibleProperty;

		// Token: 0x04000807 RID: 2055
		public static DependencyProperty SideBottomButtonCnvIsAcpEditableProperty;

		// Token: 0x04000808 RID: 2056
		public static DependencyProperty SideBottomButtonCnvUIValueProperty;

		// Token: 0x04000809 RID: 2057
		public static DependencyProperty SideBottomButtonCnvListProperty;

		// Token: 0x0400080A RID: 2058
		public static DependencyProperty SideBottomButtonTrkIsAcpValidProperty;

		// Token: 0x0400080B RID: 2059
		public static DependencyProperty SideBottomButtonTrkIsAcpApplicableProperty;

		// Token: 0x0400080C RID: 2060
		public static DependencyProperty SideBottomButtonTrkIsAcpVisibleProperty;

		// Token: 0x0400080D RID: 2061
		public static DependencyProperty SideBottomButtonTrkIsAcpEditableProperty;

		// Token: 0x0400080E RID: 2062
		public static DependencyProperty SideBottomButtonTrkUIValueProperty;

		// Token: 0x0400080F RID: 2063
		public static DependencyProperty SideBottomButtonTrkListProperty;

		// Token: 0x04000810 RID: 2064
		public static DependencyProperty DataButtonCnvIsAcpValidProperty;

		// Token: 0x04000811 RID: 2065
		public static DependencyProperty DataButtonCnvIsAcpApplicableProperty;

		// Token: 0x04000812 RID: 2066
		public static DependencyProperty DataButtonCnvIsAcpVisibleProperty;

		// Token: 0x04000813 RID: 2067
		public static DependencyProperty DataButtonCnvIsAcpEditableProperty;

		// Token: 0x04000814 RID: 2068
		public static DependencyProperty DataButtonCnvUIValueProperty;

		// Token: 0x04000815 RID: 2069
		public static DependencyProperty DataButtonCnvListProperty;

		// Token: 0x04000816 RID: 2070
		public static DependencyProperty DataButtonCnvIndexIsAcpValidProperty;

		// Token: 0x04000817 RID: 2071
		public static DependencyProperty DataButtonCnvIndexIsAcpApplicableProperty;

		// Token: 0x04000818 RID: 2072
		public static DependencyProperty DataButtonCnvIndexIsAcpVisibleProperty;

		// Token: 0x04000819 RID: 2073
		public static DependencyProperty DataButtonCnvIndexIsAcpEditableProperty;

		// Token: 0x0400081A RID: 2074
		public static DependencyProperty DataButtonCnvIndexUIValueProperty;

		// Token: 0x0400081B RID: 2075
		public static DependencyProperty DataButtonCnvIndexListProperty;

		// Token: 0x0400081C RID: 2076
		public static DependencyProperty DataButtonTrkIsAcpValidProperty;

		// Token: 0x0400081D RID: 2077
		public static DependencyProperty DataButtonTrkIsAcpApplicableProperty;

		// Token: 0x0400081E RID: 2078
		public static DependencyProperty DataButtonTrkIsAcpVisibleProperty;

		// Token: 0x0400081F RID: 2079
		public static DependencyProperty DataButtonTrkIsAcpEditableProperty;

		// Token: 0x04000820 RID: 2080
		public static DependencyProperty DataButtonTrkUIValueProperty;

		// Token: 0x04000821 RID: 2081
		public static DependencyProperty DataButtonTrkListProperty;

		// Token: 0x04000822 RID: 2082
		public static DependencyProperty DataButtonTrkIndexIsAcpValidProperty;

		// Token: 0x04000823 RID: 2083
		public static DependencyProperty DataButtonTrkIndexIsAcpApplicableProperty;

		// Token: 0x04000824 RID: 2084
		public static DependencyProperty DataButtonTrkIndexIsAcpVisibleProperty;

		// Token: 0x04000825 RID: 2085
		public static DependencyProperty DataButtonTrkIndexIsAcpEditableProperty;

		// Token: 0x04000826 RID: 2086
		public static DependencyProperty DataButtonTrkIndexUIValueProperty;

		// Token: 0x04000827 RID: 2087
		public static DependencyProperty DataButtonTrkIndexListProperty;

		// Token: 0x04000828 RID: 2088
		public static DependencyProperty UpButtonIsAcpValidProperty;

		// Token: 0x04000829 RID: 2089
		public static DependencyProperty UpButtonIsAcpApplicableProperty;

		// Token: 0x0400082A RID: 2090
		public static DependencyProperty UpButtonIsAcpVisibleProperty;

		// Token: 0x0400082B RID: 2091
		public static DependencyProperty UpButtonIsAcpEditableProperty;

		// Token: 0x0400082C RID: 2092
		public static DependencyProperty UpButtonUIValueProperty;

		// Token: 0x0400082D RID: 2093
		public static DependencyProperty UpButtonListProperty;

		// Token: 0x0400082E RID: 2094
		public static DependencyProperty DownButtonIsAcpValidProperty;

		// Token: 0x0400082F RID: 2095
		public static DependencyProperty DownButtonIsAcpApplicableProperty;

		// Token: 0x04000830 RID: 2096
		public static DependencyProperty DownButtonIsAcpVisibleProperty;

		// Token: 0x04000831 RID: 2097
		public static DependencyProperty DownButtonIsAcpEditableProperty;

		// Token: 0x04000832 RID: 2098
		public static DependencyProperty DownButtonUIValueProperty;

		// Token: 0x04000833 RID: 2099
		public static DependencyProperty DownButtonListProperty;
	}
}
