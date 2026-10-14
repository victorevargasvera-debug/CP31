using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
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
	// Token: 0x0200000E RID: 14
	public partial class SmartKeyFobGraphicView : UserControl
	{
		// Token: 0x06000C81 RID: 3201 RVA: 0x000BAF74 File Offset: 0x000B9174
		public SmartKeyFobGraphicView()
		{
			base.FlowDirection = FlowDirection.LeftToRight;
			this.InitializeComponent();
			base.DataContext = this;
		}

		// Token: 0x06000C82 RID: 3202 RVA: 0x000BAF9C File Offset: 0x000B919C
		private void OnFieldNameDoubleClick(object sender, RoutedEventArgs e)
		{
			short num = (short)1111883776;
			short num2 = num;
			num = (short)880193440;
			short num3 = num;
			num = (short)1701818272;
			switch (num3 == num)
			{
			}
			num = (short)302710785;
			if (num != 0)
			{
			}
			num = (short)590610432;
			if (num != 0)
			{
			}
			Utility.GetFieldHelpText(sender);
		}

		// Token: 0x06000C83 RID: 3203 RVA: 0x000BB04C File Offset: 0x000B924C
		public void OnLoaded(object sender, RoutedEventArgs e)
		{
			short num = (short)1677459456;
			short num2 = num;
			num = (short)1149042689;
			if (num != 0)
			{
			}
			num = (short)1160950081;
			short num3 = num;
			num = (short)240169281;
			switch (num3 == num)
			{
			}
			num = (short)1255669760;
			if (num != 0)
			{
			}
			this.CanvasLockUpButtonCnvValue.Width = 191.0 - 4.24 * (double)this.LblLockUpButtonCnvTitle.Value.Length;
			this.CanvasLockUpButtonTrkValue.Width = 191.0 - 4.24 * (double)this.LblLockUpButtonTrkTitle.Value.Length;
			this.CanvasLockDownButtonCnvValue.Width = 191.0 - 4.24 * (double)this.LblLockDownButtonCnvTitle.Value.Length;
			this.CanvasLockDownButtonTrkValue.Width = 191.0 - 4.24 * (double)this.LblLockDownButtonTrkTitle.Value.Length;
			this.CanvasUnlockUpButtonCnvValue.Width = 191.0 - 4.24 * (double)this.LblUnlockDownButtonCnvTitle.Value.Length;
			this.CanvasUnlockUpButtonTrkValue.Width = 191.0 - 4.24 * (double)this.LblUnlockDownButtonTrkTitle.Value.Length;
			this.CanvasUnlockDownButtonCnvValue.Width = 191.0 - 4.24 * (double)this.LblUnlockDownButtonCnvTitle.Value.Length;
			this.CanvasUnlockDownButtonTrkValue.Width = 191.0 - 4.24 * (double)this.LblUnlockDownButtonTrkTitle.Value.Length;
			this.CanvasUnlockTrunkButtonCnvValue.Width = 191.0 - 4.24 * (double)this.LblUnlockTrunkButtonCnvTitle.Value.Length;
			this.CanvasUnlockTrunkButtonTrkValue.Width = 191.0 - 4.24 * (double)this.LblUnlockTrunkButtonTrkTitle.Value.Length;
			this.CanvasAlarmButtonCnvValue.Width = 191.0 - 4.24 * (double)this.LblAlarmButtonCnvTitle.Value.Length;
			this.CanvasAlarmButtonTrkValue.Width = 191.0 - 4.24 * (double)this.LblAlarmButtonTrkTitle.Value.Length;
		}

		// Token: 0x06000C84 RID: 3204 RVA: 0x000BB334 File Offset: 0x000B9534
		private void StartScrollingAcpLabel(AcpLabel label, ref bool isAnimating, TranslateTransform translateTransform)
		{
			int a_ = 12;
			short num = (short)1824653342;
			int num2 = (int)((IntPtr)num);
			DoubleAnimation doubleAnimation;
			for (;;)
			{
				uint num3;
				string name;
				switch (num2)
				{
				case 0:
					num = (short)2107506735;
					num2 = (int)((IntPtr)num);
					continue;
				case 1:
					num = (short)1494417413;
					num2 = (int)((IntPtr)num);
					continue;
				case 2:
					goto IL_B01;
				case 3:
					goto IL_1B8;
				case 4:
					goto IL_BA7;
				case 5:
					if (num3 != 1171574752U)
					{
						num = (short)1061683277;
						num2 = (int)((IntPtr)num);
						continue;
					}
					num = (short)1644822596;
					num2 = (int)((IntPtr)num);
					continue;
				case 6:
					if (!(name == O9GraphicviewMenuItemsVisibilityConverter.b("笶嬸场格儾ⵀⱂ♄ⱆ᱈㭊ཌ㩎═❒㩔㥖ᩘ㕚⭜फ़`རၤɦ", a_)))
					{
						num = (short)1911160913;
						num2 = (int)((IntPtr)num);
						continue;
					}
					doubleAnimation.Completed += this.LblUnlockUpButtonCnvValue_AnimationCompleted;
					num = (short)945684530;
					num2 = (int)((IntPtr)num);
					continue;
				case 7:
					num = (short)2110521416;
					num2 = (int)((IntPtr)num);
					continue;
				case 8:
					num = (short)1343422478;
					num2 = (int)((IntPtr)num);
					continue;
				case 9:
					goto IL_A56;
				case 10:
					goto IL_93F;
				case 11:
					goto IL_507;
				case 12:
					if (!(name == O9GraphicviewMenuItemsVisibilityConverter.b("笶嬸场格儾ⵀⱂ♄ⱆൈ⑊㩌ⅎፐ♒⅔⍖㙘㕚ड़ⵞ੠㕢Ѥ୦ᱨ๪", a_)))
					{
						num = (short)293011456;
						num2 = (int)((IntPtr)num);
						continue;
					}
					doubleAnimation.Completed += this.LblUnlockDownButtonTrkValue_AnimationCompleted;
					num = (short)400228384;
					num2 = (int)((IntPtr)num);
					continue;
				case 13:
					num = (short)521076803;
					num2 = (int)((IntPtr)num);
					continue;
				case 14:
					if (num3 <= 1512900554U)
					{
						num = (short)558956606;
						num2 = (int)((IntPtr)num);
						continue;
					}
					num = (short)1591148575;
					num2 = (int)((IntPtr)num);
					continue;
				case 15:
					if (!(name == O9GraphicviewMenuItemsVisibilityConverter.b("笶嬸场焼倾≀⡂၄㝆ୈ㹊㥌㭎㹐㵒Ŕ╖㉘൚㱜㍞ᑠ٢", a_)))
					{
						num = (short)1521745936;
						num2 = (int)((IntPtr)num);
						continue;
					}
					doubleAnimation.Completed += this.LblLockUpButtonTrkValue_AnimationCompleted;
					num = (short)1616511058;
					num2 = (int)((IntPtr)num);
					continue;
				case 16:
					num = (short)1976827931;
					num2 = (int)((IntPtr)num);
					continue;
				case 17:
					num = (short)1924005891;
					num2 = (int)((IntPtr)num);
					continue;
				case 18:
					num = (short)908263479;
					num2 = (int)((IntPtr)num);
					continue;
				case 19:
					goto IL_47D;
				case 20:
					goto IL_28E;
				case 21:
					goto IL_D74;
				case 22:
					num = (short)1022885911;
					num2 = (int)((IntPtr)num);
					continue;
				case 23:
					goto IL_CE8;
				case 24:
					if (num3 != 3921634439U)
					{
						num = (short)1454243853;
						num2 = (int)((IntPtr)num);
						continue;
					}
					num = (short)421462031;
					num2 = (int)((IntPtr)num);
					continue;
				case 25:
					num = (short)1273036859;
					num2 = (int)((IntPtr)num);
					continue;
				case 26:
					num = (short)467533893;
					num2 = (int)((IntPtr)num);
					continue;
				case 27:
					goto IL_451;
				case 28:
					if (!(name == O9GraphicviewMenuItemsVisibilityConverter.b("笶嬸场簼匾⁀ㅂ⡄Ն㱈㽊㥌⁎㽐ݒ❔㱖མ㩚ㅜ⩞Ѡ", a_)))
					{
						num = (short)97714183;
						num2 = (int)((IntPtr)num);
						continue;
					}
					doubleAnimation.Completed += this.LblAlarmButtonTrkValue_AnimationCompleted;
					goto IL_D5C;
				case 29:
					num = (short)1145241633;
					num2 = (int)((IntPtr)num);
					continue;
				case 30:
					switch (0)
					{
					case 0:
						goto IL_17D;
					}
					continue;
				case 31:
					if (num3 != 1602047757U)
					{
						num = (short)479592518;
						num2 = (int)((IntPtr)num);
						continue;
					}
					num = (short)1844903948;
					num2 = (int)((IntPtr)num);
					continue;
				case 32:
					goto IL_34C;
				case 33:
					goto IL_BC3;
				case 34:
					num = (short)1913192467;
					num2 = (int)((IntPtr)num);
					continue;
				case 35:
					goto IL_D05;
				case 36:
					if (!(name == O9GraphicviewMenuItemsVisibilityConverter.b("笶嬸场格儾ⵀⱂ♄ⱆൈ⑊㩌ⅎፐ♒⅔⍖㙘㕚Ṝㅞᝠ㕢Ѥ୦ᱨ๪", a_)))
					{
						num = (short)221052984;
						num2 = (int)((IntPtr)num);
						continue;
					}
					doubleAnimation.Completed += this.LblUnlockDownButtonCnvValue_AnimationCompleted;
					num = (short)1479147530;
					num2 = (int)((IntPtr)num);
					continue;
				case 37:
					if (!(name == O9GraphicviewMenuItemsVisibilityConverter.b("笶嬸场格儾ⵀⱂ♄ⱆᵈ㥊㡌ⅎ㩐ᅒ⁔⍖ⵘ㑚㍜ᱞའᕢ㍤٦ըṪ࡬", a_)))
					{
						num = (short)1619918912;
						num2 = (int)((IntPtr)num);
						continue;
					}
					doubleAnimation.Completed += this.LblUnlockTrunkButtonCnvValue_AnimationCompleted;
					num = (short)1740439627;
					num2 = (int)((IntPtr)num);
					continue;
				case 38:
					num = (short)91553846;
					num2 = (int)((IntPtr)num);
					continue;
				case 39:
					goto IL_19C;
				case 40:
					num = (short)1677393991;
					num2 = (int)((IntPtr)num);
					continue;
				case 41:
					num = (short)809107457;
					if (num != 0)
					{
					}
					num = (short)295501848;
					num2 = (int)((IntPtr)num);
					continue;
				case 42:
					if (num3 <= 1875177097U)
					{
						num = (short)1539964936;
						num2 = (int)((IntPtr)num);
						continue;
					}
					num = (short)1906835499;
					num2 = (int)((IntPtr)num);
					continue;
				case 43:
				{
					if (num3 > 3481077230U)
					{
						num = (short)2031681612;
						num2 = (int)((IntPtr)num);
						continue;
					}
					num = (short)2008345067;
					short num4 = num;
					num = (short)1486940651;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_D5C;
					default:
						num = (short)2060124160;
						if (num != 0)
						{
						}
						num = (short)1483538490;
						num2 = (int)((IntPtr)num);
						continue;
					}
					break;
				}
				case 44:
					if (!(name == O9GraphicviewMenuItemsVisibilityConverter.b("笶嬸场簼匾⁀ㅂ⡄Ն㱈㽊㥌⁎㽐ၒ㭔⅖མ㩚ㅜ⩞Ѡ", a_)))
					{
						num = (short)1572274205;
						num2 = (int)((IntPtr)num);
						continue;
					}
					doubleAnimation.Completed += this.LblAlarmButtonCnvValue_AnimationCompleted;
					num = (short)978124852;
					num2 = (int)((IntPtr)num);
					continue;
				case 45:
					num = (short)1087504457;
					num2 = (int)((IntPtr)num);
					continue;
				case 46:
					if (!(name == O9GraphicviewMenuItemsVisibilityConverter.b("笶嬸场格儾ⵀⱂ♄ⱆ᱈㭊ཌ㩎═❒㩔㥖൘⥚㙜फ़`རၤɦ", a_)))
					{
						num = (short)1442119720;
						num2 = (int)((IntPtr)num);
						continue;
					}
					doubleAnimation.Completed += this.LblUnlockUpButtonTrkValue_AnimationCompleted;
					num = (short)836698123;
					num2 = (int)((IntPtr)num);
					continue;
				case 47:
					goto IL_5AE;
				case 48:
					if (num3 != 2375434731U)
					{
						num = (short)2024603673;
						num2 = (int)((IntPtr)num);
						continue;
					}
					num = (short)581107749;
					num2 = (int)((IntPtr)num);
					continue;
				case 49:
					if (num3 != 1865590197U)
					{
						num = (short)337903690;
						num2 = (int)((IntPtr)num);
						continue;
					}
					num = (short)743702591;
					num2 = (int)((IntPtr)num);
					continue;
				case 50:
					goto IL_406;
				case 51:
					goto IL_759;
				case 52:
					goto IL_434;
				case 53:
					num = (short)2018574401;
					num2 = (int)((IntPtr)num);
					continue;
				case 54:
					goto IL_4D9;
				case 55:
					goto IL_911;
				case 56:
					num = (short)398393379;
					num2 = (int)((IntPtr)num);
					continue;
				case 57:
					if (!(name == O9GraphicviewMenuItemsVisibilityConverter.b("笶嬸场焼倾≀⡂၄㝆ୈ㹊㥌㭎㹐㵒ᙔ㥖⽘൚㱜㍞ᑠ٢", a_)))
					{
						num = (short)1322188826;
						num2 = (int)((IntPtr)num);
						continue;
					}
					doubleAnimation.Completed += this.LblLockUpButtonCnvValue_AnimationCompleted;
					num = (short)937164809;
					num2 = (int)((IntPtr)num);
					continue;
				case 58:
					num = (short)2062483504;
					num2 = (int)((IntPtr)num);
					continue;
				case 59:
					if (num3 != 2882014572U)
					{
						num = (short)1657667637;
						num2 = (int)((IntPtr)num);
						continue;
					}
					num = (short)46858286;
					num2 = (int)((IntPtr)num);
					continue;
				case 60:
				{
					if (!(name == O9GraphicviewMenuItemsVisibilityConverter.b("笶嬸场焼倾≀⡂ń⡆㹈╊ཌ㩎═❒㩔㥖൘⥚㙜फ़`རၤɦ", a_)))
					{
						num = (short)418381846;
						num2 = (int)((IntPtr)num);
						continue;
					}
					doubleAnimation.Completed += this.LblLockDownButtonTrkValue_AnimationCompleted;
					num = (short)1986134016;
					short num5 = num;
					num = (short)2075131908;
					num2 = (int)((IntPtr)num);
					continue;
				}
				case 61:
					goto IL_BF2;
				case 62:
					num = (short)2068971586;
					num2 = (int)((IntPtr)num);
					continue;
				case 63:
					if (!(name == O9GraphicviewMenuItemsVisibilityConverter.b("笶嬸场格儾ⵀⱂ♄ⱆᵈ㥊㡌ⅎ㩐ᅒ⁔⍖ⵘ㑚㍜୞፠ࡢ㍤٦ըṪ࡬", a_)))
					{
						num = (short)418119697;
						num2 = (int)((IntPtr)num);
						continue;
					}
					doubleAnimation.Completed += this.LblUnlockTrunkButtonTrkValue_AnimationCompleted;
					num = (short)995426365;
					num2 = (int)((IntPtr)num);
					continue;
				case 64:
					num = (short)1873477634;
					num2 = (int)((IntPtr)num);
					continue;
				case 65:
					if (num3 != 3481077230U)
					{
						num = (short)1110442022;
						num2 = (int)((IntPtr)num);
						continue;
					}
					num = (short)656408636;
					num2 = (int)((IntPtr)num);
					continue;
				case 66:
					if (num3 != 398535680U)
					{
						num = (short)530513921;
						num2 = (int)((IntPtr)num);
						continue;
					}
					num = (short)912064556;
					num2 = (int)((IntPtr)num);
					continue;
				case 67:
					if (num3 != 4157545102U)
					{
						num = (short)92340303;
						num2 = (int)((IntPtr)num);
						continue;
					}
					num = (short)963772444;
					num2 = (int)((IntPtr)num);
					continue;
				case 68:
					if (!(name == O9GraphicviewMenuItemsVisibilityConverter.b("笶嬸场焼倾≀⡂ń⡆㹈╊ཌ㩎═❒㩔㥖ᩘ㕚⭜फ़`རၤɦ", a_)))
					{
						num = (short)946667538;
						num2 = (int)((IntPtr)num);
						continue;
					}
					doubleAnimation.Completed += this.LblLockDownButtonCnvValue_AnimationCompleted;
					num = (short)1108606996;
					num2 = (int)((IntPtr)num);
					continue;
				case 69:
					goto IL_591;
				case 70:
					num = (short)1244463153;
					num2 = (int)((IntPtr)num);
					continue;
				case 71:
					goto IL_1D5;
				case 72:
					goto IL_524;
				case 73:
					goto IL_A27;
				case 74:
					num = (short)1869414483;
					num2 = (int)((IntPtr)num);
					continue;
				case 75:
					goto IL_9EE;
				case 76:
					if (num3 != 3667722787U)
					{
						num = (short)1838022697;
						num2 = (int)((IntPtr)num);
						continue;
					}
					num = (short)1900806180;
					num2 = (int)((IntPtr)num);
					continue;
				case 77:
					num = (short)63176782;
					num2 = (int)((IntPtr)num);
					continue;
				case 78:
					if (num3 != 1512900554U)
					{
						num = (short)135790637;
						num2 = (int)((IntPtr)num);
						continue;
					}
					num = (short)656867334;
					num2 = (int)((IntPtr)num);
					continue;
				case 79:
					num = (short)1964245072;
					num2 = (int)((IntPtr)num);
					continue;
				case 80:
					goto IL_A0B;
				case 81:
					num = (short)796852275;
					num2 = (int)((IntPtr)num);
					continue;
				case 82:
					goto IL_657;
				case 83:
					if (num3 != 1875177097U)
					{
						num = (short)1949630498;
						num2 = (int)((IntPtr)num);
						continue;
					}
					num = (short)6946873;
					num2 = (int)((IntPtr)num);
					continue;
				}
				IL_17D:
				if (isAnimating)
				{
					num = (short)124256295;
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
				num3 = <PrivateImplementationDetails>.ComputeStringHash(name);
				num = (short)1583284266;
				num2 = (int)((IntPtr)num);
				continue;
				IL_D5C:
				num = (short)395116565;
				num2 = (int)((IntPtr)num);
			}
			IL_19C:
			translateTransform.BeginAnimation(TranslateTransform.XProperty, null);
			isAnimating = false;
			return;
			IL_1B8:
			IL_1D5:
			IL_28E:
			IL_34C:
			IL_406:
			IL_434:
			IL_451:
			IL_47D:
			IL_4D9:
			IL_507:
			IL_524:
			IL_591:
			IL_5AE:
			IL_657:
			IL_759:
			IL_911:
			IL_93F:
			IL_9EE:
			IL_A0B:
			IL_A27:
			IL_A56:
			IL_B01:
			IL_BA7:
			IL_BC3:
			IL_BF2:
			IL_CE8:
			IL_D05:
			IL_D74:
			translateTransform.BeginAnimation(TranslateTransform.XProperty, doubleAnimation);
		}

		// Token: 0x06000C85 RID: 3205 RVA: 0x000BC164 File Offset: 0x000BA364
		private void LblLockUpButtonCnvValue_AnimationCompleted(object sender, EventArgs e)
		{
			short num = (short)2099249153;
			if (num != 0)
			{
			}
			num = (short)1084011302;
			short num2 = num;
			num = (short)1694151462;
			switch (num2 == num)
			{
			}
			num = (short)1725431808;
			if (num != 0)
			{
			}
			num = (short)786235392;
			short num3 = num;
			this.isLblLockUpButtonCnvValueAnimating = false;
		}

		// Token: 0x06000C86 RID: 3206 RVA: 0x000BC218 File Offset: 0x000BA418
		private void ScrollingLblLockUpButtonCnvValue(object sender, MouseButtonEventArgs e)
		{
			short num = (short)1768226818;
			int num2 = (int)((IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
				{
					num = (short)1910409072;
					short num3 = num;
					num = (short)1602783088;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						return;
					default:
					{
						num = (short)1483472896;
						if (num != 0)
						{
						}
						num = (short)1448148992;
						short num4 = num;
						this.StartScrollingAcpLabel(this.LblLockUpButtonCnvValue, ref this.isLblLockUpButtonCnvValueAnimating, this.RenderTransformLblLockUpButtonCnvValue);
						num = (short)1298923521;
						num2 = (int)((IntPtr)num);
						continue;
					}
					}
					break;
				}
				case 1:
					return;
				case 2:
					switch (0)
					{
					case 0:
						goto IL_30;
					}
					continue;
				}
				IL_30:
				if ((sender as AcpLabel).ActualWidth <= this.CanvasLockUpButtonCnvValue.Width)
				{
					break;
				}
				num = (short)98631681;
				if (num != 0)
				{
				}
				num = (short)1873543168;
				num2 = (int)((IntPtr)num);
			}
		}

		// Token: 0x06000C87 RID: 3207 RVA: 0x000BC358 File Offset: 0x000BA558
		private void MouseEnterLblLockUpButtonCnvValue(object sender, MouseEventArgs e)
		{
			AcpLabel acpLabel = sender as AcpLabel;
			if (acpLabel.ActualWidth > this.CanvasLockUpButtonCnvValue.Width)
			{
				short num;
				for (;;)
				{
					num = (short)1487943309;
					short num2 = num;
					num = (short)1684027021;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						goto IL_55;
					}
				}
				IL_55:
				num = (short)690683905;
				if (num != 0)
				{
				}
				num = (short)628424704;
				short num3 = num;
				num = (short)975699968;
				if (num != 0)
				{
				}
				acpLabel.Cursor = Cursors.Hand;
				return;
			}
			acpLabel.Cursor = Cursors.Arrow;
		}

		// Token: 0x06000C88 RID: 3208 RVA: 0x000BC43C File Offset: 0x000BA63C
		private void LblLockUpButtonTrkValue_AnimationCompleted(object sender, EventArgs e)
		{
			short num = (short)2122640603;
			short num2 = num;
			num = (short)561900763;
			switch (num2 == num)
			{
			}
			num = (short)1023344640;
			if (num != 0)
			{
			}
			num = (short)385024001;
			if (num != 0)
			{
			}
			num = (short)1951531008;
			short num3 = num;
			this.isLblLockUpButtonTrkValueAnimating = false;
		}

		// Token: 0x06000C89 RID: 3209 RVA: 0x000BC4EC File Offset: 0x000BA6EC
		private void ScrollingLblLockUpButtonTrkValue(object sender, MouseButtonEventArgs e)
		{
			short num = (short)1541603330;
			int num2 = (int)((IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
				{
					num = (short)1402271314;
					short num3 = num;
					num = (short)1848768082;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						return;
					default:
					{
						num = (short)147718144;
						if (num != 0)
						{
						}
						num = (short)1252786176;
						short num4 = num;
						this.StartScrollingAcpLabel(this.LblLockUpButtonTrkValue, ref this.isLblLockUpButtonTrkValueAnimating, this.RenderTransformLblLockUpButtonTrkValue);
						num = (short)723451905;
						num2 = (int)((IntPtr)num);
						continue;
					}
					}
					break;
				}
				case 1:
					return;
				case 2:
					switch (0)
					{
					case 0:
						goto IL_31;
					}
					continue;
				}
				IL_31:
				num = (short)35127297;
				if (num != 0)
				{
				}
				if ((sender as AcpLabel).ActualWidth <= this.CanvasLockUpButtonTrkValue.Width)
				{
					break;
				}
				num = (short)1448738816;
				num2 = (int)((IntPtr)num);
			}
		}

		// Token: 0x06000C8A RID: 3210 RVA: 0x000BC628 File Offset: 0x000BA828
		private void MouseEnterLblLockUpButtonTrkValue(object sender, MouseEventArgs e)
		{
			AcpLabel acpLabel = sender as AcpLabel;
			if (acpLabel.ActualWidth > this.CanvasLockUpButtonTrkValue.Width)
			{
				short num;
				for (;;)
				{
					num = (short)1638354463;
					short num2 = num;
					num = (short)1037717023;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						goto IL_54;
					}
				}
				IL_54:
				num = (short)2070282241;
				if (num != 0)
				{
				}
				num = (short)1409810432;
				short num3 = num;
				num = (short)1466368000;
				if (num != 0)
				{
				}
				acpLabel.Cursor = Cursors.Hand;
				return;
			}
			acpLabel.Cursor = Cursors.Arrow;
		}

		// Token: 0x06000C8B RID: 3211 RVA: 0x000BC704 File Offset: 0x000BA904
		private void LblLockDownButtonCnvValue_AnimationCompleted(object sender, EventArgs e)
		{
			short num = (short)581929168;
			short num2 = num;
			num = (short)2065795280;
			switch (num2 == num)
			{
			}
			num = (short)231800833;
			if (num != 0)
			{
			}
			num = (short)1546059776;
			if (num != 0)
			{
			}
			num = (short)1071775744;
			short num3 = num;
			this.isLblLockDownButtonCnvValueAnimating = false;
		}

		// Token: 0x06000C8C RID: 3212 RVA: 0x000BC7B8 File Offset: 0x000BA9B8
		private void ScrollingLblLockDownButtonCnvValue(object sender, MouseButtonEventArgs e)
		{
			short num = (short)1624506370;
			int num2 = (int)((IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
				{
					num = (short)146669569;
					if (num != 0)
					{
					}
					num = (short)349003152;
					short num3 = num;
					num = (short)922574224;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						return;
					default:
					{
						num = (short)846528512;
						if (num != 0)
						{
						}
						num = (short)2013200384;
						short num4 = num;
						this.StartScrollingAcpLabel(this.LblLockDownButtonCnvValue, ref this.isLblLockDownButtonCnvValueAnimating, this.RenderTransformLblLockDownButtonCnvValue);
						num = (short)320012289;
						num2 = (int)((IntPtr)num);
						continue;
					}
					}
					break;
				}
				case 1:
					return;
				case 2:
					switch (0)
					{
					case 0:
						goto IL_30;
					}
					continue;
				}
				IL_30:
				if ((sender as AcpLabel).ActualWidth <= this.CanvasLockDownButtonCnvValue.Width)
				{
					break;
				}
				num = (short)1554382848;
				num2 = (int)((IntPtr)num);
			}
		}

		// Token: 0x06000C8D RID: 3213 RVA: 0x000BC8F0 File Offset: 0x000BAAF0
		private void MouseEnterLblLockDownButtonCnvValue(object sender, MouseEventArgs e)
		{
			AcpLabel acpLabel = sender as AcpLabel;
			if (acpLabel.ActualWidth > this.CanvasLockDownButtonCnvValue.Width)
			{
				short num;
				for (;;)
				{
					num = (short)560857089;
					if (num != 0)
					{
					}
					num = (short)583570308;
					short num2 = num;
					num = (short)1499632516;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						goto IL_7E;
					}
				}
				IL_7E:
				num = (short)456196096;
				short num3 = num;
				num = (short)1533804544;
				if (num != 0)
				{
				}
				acpLabel.Cursor = Cursors.Hand;
				return;
			}
			acpLabel.Cursor = Cursors.Arrow;
		}

		// Token: 0x06000C8E RID: 3214 RVA: 0x000BC9D0 File Offset: 0x000BABD0
		private void LblLockDownButtonTrkValue_AnimationCompleted(object sender, EventArgs e)
		{
			short num = (short)1840272310;
			short num2 = num;
			num = (short)857691062;
			switch (num2 == num)
			{
			}
			num = (short)752287744;
			if (num != 0)
			{
			}
			num = (short)889323521;
			if (num != 0)
			{
			}
			num = (short)1142816768;
			short num3 = num;
			this.isLblLockDownButtonTrkValueAnimating = false;
		}

		// Token: 0x06000C8F RID: 3215 RVA: 0x000BCA80 File Offset: 0x000BAC80
		private void ScrollingLblLockDownButtonTrkValue(object sender, MouseButtonEventArgs e)
		{
			short num = (short)1535770626;
			int num2 = (int)((IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
				{
					num = (short)1004897120;
					short num3 = num;
					num = (short)1892189024;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						return;
					default:
					{
						num = (short)527695872;
						if (num != 0)
						{
						}
						num = (short)1630797824;
						short num4 = num;
						this.StartScrollingAcpLabel(this.LblLockDownButtonTrkValue, ref this.isLblLockDownButtonTrkValueAnimating, this.RenderTransformLblLockDownButtonTrkValue);
						num = (short)377552897;
						num2 = (int)((IntPtr)num);
						continue;
					}
					}
					break;
				}
				case 1:
					return;
				case 2:
					switch (0)
					{
					case 0:
						goto IL_31;
					}
					continue;
				}
				IL_31:
				if ((sender as AcpLabel).ActualWidth <= this.CanvasLockDownButtonTrkValue.Width)
				{
					break;
				}
				num = (short)1020395521;
				if (num != 0)
				{
				}
				num = (short)63045632;
				num2 = (int)((IntPtr)num);
			}
		}

		// Token: 0x06000C90 RID: 3216 RVA: 0x000BCBC0 File Offset: 0x000BADC0
		private void MouseEnterLblLockDownButtonTrkValue(object sender, MouseEventArgs e)
		{
			short num = (short)1170751950;
			short num2 = num;
			num = (short)1104429518;
			AcpLabel acpLabel;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
				num = (short)184614913;
				if (num != 0)
				{
				}
				num = (short)252444672;
				if (num != 0)
				{
				}
				acpLabel = (sender as AcpLabel);
				if (acpLabel.ActualWidth <= this.CanvasLockDownButtonTrkValue.Width)
				{
					num = (short)1848901632;
					short num3 = num;
					acpLabel.Cursor = Cursors.Arrow;
					return;
				}
				break;
			}
			acpLabel.Cursor = Cursors.Hand;
		}

		// Token: 0x06000C91 RID: 3217 RVA: 0x000BCC9C File Offset: 0x000BAE9C
		private void LblUnlockUpButtonCnvValue_AnimationCompleted(object sender, EventArgs e)
		{
			short num = (short)1185742848;
			short num2 = num;
			num = (short)775590245;
			short num3 = num;
			num = (short)1725010277;
			switch (num3 == num)
			{
			}
			num = (short)1278148609;
			if (num != 0)
			{
			}
			num = (short)1376845824;
			if (num != 0)
			{
			}
			this.isLblUnlockUpButtonCnvValueAnimating = false;
		}

		// Token: 0x06000C92 RID: 3218 RVA: 0x000BCD4C File Offset: 0x000BAF4C
		private void ScrollingLblUnlockUpButtonCnvValue(object sender, MouseButtonEventArgs e)
		{
			short num = (short)946536448;
			int num2 = (int)((IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					switch (0)
					{
					case 0:
						goto IL_31;
					}
					continue;
				case 1:
					return;
				case 2:
					num = (short)1415577601;
					if (num != 0)
					{
					}
					this.StartScrollingAcpLabel(this.LblUnlockUpButtonCnvValue, ref this.isLblUnlockUpButtonCnvValueAnimating, this.RenderTransformLblUnlockUpButtonCnvValue);
					num = (short)953876481;
					num2 = (int)((IntPtr)num);
					continue;
				}
				IL_31:
				if ((sender as AcpLabel).ActualWidth <= this.CanvasUnlockUpButtonCnvValue.Width)
				{
					break;
				}
				num = (short)2119392236;
				short num3 = num;
				num = (short)537811948;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)1837105152;
					short num4 = num;
					num = (short)1570570240;
					if (num != 0)
					{
					}
					num = (short)401866754;
					num2 = (int)((IntPtr)num);
					break;
				}
				}
			}
		}

		// Token: 0x06000C93 RID: 3219 RVA: 0x000BCE90 File Offset: 0x000BB090
		private void MouseEnterLblUnlockUpButtonCnvValue(object sender, MouseEventArgs e)
		{
			short num = (short)618320927;
			short num2 = num;
			num = (short)1571083295;
			AcpLabel acpLabel;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
				num = (short)1812267008;
				if (num != 0)
				{
				}
				num = (short)187760641;
				if (num != 0)
				{
				}
				acpLabel = (sender as AcpLabel);
				if (acpLabel.ActualWidth <= this.CanvasUnlockUpButtonCnvValue.Width)
				{
					num = (short)90177536;
					short num3 = num;
					acpLabel.Cursor = Cursors.Arrow;
					return;
				}
				break;
			}
			acpLabel.Cursor = Cursors.Hand;
		}

		// Token: 0x06000C94 RID: 3220 RVA: 0x000BCF6C File Offset: 0x000BB16C
		private void LblUnlockUpButtonTrkValue_AnimationCompleted(object sender, EventArgs e)
		{
			short num = (short)832569344;
			short num2 = num;
			num = (short)1990873383;
			short num3 = num;
			num = (short)1885884711;
			switch (num3 == num)
			{
			}
			num = (short)984940545;
			if (num != 0)
			{
			}
			num = (short)764280832;
			if (num != 0)
			{
			}
			this.isLblUnlockUpButtonTrkValueAnimating = false;
		}

		// Token: 0x06000C95 RID: 3221 RVA: 0x000BD01C File Offset: 0x000BB21C
		private void ScrollingLblUnlockUpButtonTrkValue(object sender, MouseButtonEventArgs e)
		{
			short num = (short)1676279808;
			int num2 = (int)((IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					switch (0)
					{
					case 0:
						goto IL_31;
					}
					continue;
				case 1:
					return;
				case 2:
					this.StartScrollingAcpLabel(this.LblUnlockUpButtonTrkValue, ref this.isLblUnlockUpButtonTrkValueAnimating, this.RenderTransformLblUnlockUpButtonTrkValue);
					num = (short)702087169;
					num2 = (int)((IntPtr)num);
					continue;
				}
				IL_31:
				num = (short)1929510913;
				if (num != 0)
				{
				}
				if ((sender as AcpLabel).ActualWidth <= this.CanvasUnlockUpButtonTrkValue.Width)
				{
					break;
				}
				num = (short)432679212;
				short num3 = num;
				num = (short)512502060;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					continue;
				case 1:
					break;
				default:
				{
					num = (short)24969216;
					short num4 = num;
					break;
				}
				}
				num = (short)523698176;
				if (num != 0)
				{
				}
				num = (short)1734606850;
				num2 = (int)((IntPtr)num);
			}
		}

		// Token: 0x06000C96 RID: 3222 RVA: 0x000BD15C File Offset: 0x000BB35C
		private void MouseEnterLblUnlockUpButtonTrkValue(object sender, MouseEventArgs e)
		{
			short num = (short)294844814;
			short num2 = num;
			num = (short)2114386318;
			AcpLabel acpLabel;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
				num = (short)15532032;
				if (num != 0)
				{
				}
				acpLabel = (sender as AcpLabel);
				if (acpLabel.ActualWidth <= this.CanvasUnlockUpButtonTrkValue.Width)
				{
					num = (short)1350238209;
					if (num != 0)
					{
					}
					num = (short)1876557824;
					short num3 = num;
					acpLabel.Cursor = Cursors.Arrow;
					return;
				}
				break;
			}
			acpLabel.Cursor = Cursors.Hand;
		}

		// Token: 0x06000C97 RID: 3223 RVA: 0x000BD238 File Offset: 0x000BB438
		private void LblUnlockDownButtonCnvValue_AnimationCompleted(object sender, EventArgs e)
		{
			short num = (short)1383137280;
			short num2 = num;
			num = (short)1470507725;
			short num3 = num;
			num = (short)2076846797;
			switch (num3 == num)
			{
			}
			num = (short)1918500864;
			if (num != 0)
			{
			}
			num = (short)2027880449;
			if (num != 0)
			{
			}
			this.isLblUnlockDownButtonCnvValueAnimating = false;
		}

		// Token: 0x06000C98 RID: 3224 RVA: 0x000BD2E8 File Offset: 0x000BB4E8
		private void ScrollingLblUnlockDownButtonCnvValue(object sender, MouseButtonEventArgs e)
		{
			short num = (short)1234698240;
			int num2 = (int)((IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					switch (0)
					{
					case 0:
						goto IL_30;
					}
					continue;
				case 1:
					return;
				case 2:
					this.StartScrollingAcpLabel(this.LblUnlockDownButtonCnvValue, ref this.isLblUnlockDownButtonCnvValueAnimating, this.RenderTransformLblUnlockDownButtonCnvValue);
					num = (short)1523122177;
					num2 = (int)((IntPtr)num);
					continue;
				}
				IL_30:
				num = (short)1799880705;
				if (num != 0)
				{
				}
				if ((sender as AcpLabel).ActualWidth <= this.CanvasUnlockDownButtonCnvValue.Width)
				{
					break;
				}
				num = (short)1916001565;
				short num3 = num;
				num = (short)497933597;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					continue;
				case 1:
					break;
				default:
				{
					num = (short)1959657472;
					short num4 = num;
					break;
				}
				}
				num = (short)829227008;
				if (num != 0)
				{
				}
				num = (short)1256325122;
				num2 = (int)((IntPtr)num);
			}
		}

		// Token: 0x06000C99 RID: 3225 RVA: 0x000BD42C File Offset: 0x000BB62C
		private void MouseEnterLblUnlockDownButtonCnvValue(object sender, MouseEventArgs e)
		{
			short num = (short)1210262342;
			short num2 = num;
			num = (short)659039046;
			AcpLabel acpLabel;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
				num = (short)1262419968;
				if (num != 0)
				{
				}
				acpLabel = (sender as AcpLabel);
				if (acpLabel.ActualWidth <= this.CanvasUnlockDownButtonCnvValue.Width)
				{
					num = (short)623902720;
					short num3 = num;
					acpLabel.Cursor = Cursors.Arrow;
					return;
				}
				break;
			}
			num = (short)82771969;
			if (num != 0)
			{
			}
			acpLabel.Cursor = Cursors.Hand;
		}

		// Token: 0x06000C9A RID: 3226 RVA: 0x000BD508 File Offset: 0x000BB708
		private void LblUnlockDownButtonTrkValue_AnimationCompleted(object sender, EventArgs e)
		{
			short num = (short)324206592;
			short num2 = num;
			num = (short)1691948386;
			short num3 = num;
			num = (short)369038690;
			switch (num3 == num)
			{
			}
			num = (short)653721600;
			if (num != 0)
			{
			}
			num = (short)425000961;
			if (num != 0)
			{
			}
			this.isLblUnlockDownButtonTrkValueAnimating = false;
		}

		// Token: 0x06000C9B RID: 3227 RVA: 0x000BD5BC File Offset: 0x000BB7BC
		private void ScrollingLblUnlockDownButtonTrkValue(object sender, MouseButtonEventArgs e)
		{
			short num = (short)643694592;
			int num2 = (int)((IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					switch (0)
					{
					case 0:
						goto IL_31;
					}
					continue;
				case 1:
					return;
				case 2:
					num = (short)1399980033;
					if (num != 0)
					{
					}
					this.StartScrollingAcpLabel(this.LblUnlockDownButtonTrkValue, ref this.isLblUnlockDownButtonTrkValueAnimating, this.RenderTransformLblUnlockDownButtonTrkValue);
					num = (short)2104950785;
					num2 = (int)((IntPtr)num);
					continue;
				}
				IL_31:
				if ((sender as AcpLabel).ActualWidth <= this.CanvasUnlockDownButtonTrkValue.Width)
				{
					break;
				}
				num = (short)777410952;
				short num3 = num;
				num = (short)1202149768;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)123797504;
					short num4 = num;
					num = (short)1709899776;
					if (num != 0)
					{
					}
					num = (short)131006466;
					num2 = (int)((IntPtr)num);
					break;
				}
				}
			}
		}

		// Token: 0x06000C9C RID: 3228 RVA: 0x000BD6FC File Offset: 0x000BB8FC
		private void MouseEnterLblUnlockDownButtonTrkValue(object sender, MouseEventArgs e)
		{
			short num = (short)1732837763;
			short num2 = num;
			num = (short)637075843;
			AcpLabel acpLabel;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
				num = (short)1213202433;
				if (num != 0)
				{
				}
				num = (short)2078212096;
				if (num != 0)
				{
				}
				acpLabel = (sender as AcpLabel);
				if (acpLabel.ActualWidth <= this.CanvasUnlockDownButtonTrkValue.Width)
				{
					num = (short)1176502272;
					short num3 = num;
					acpLabel.Cursor = Cursors.Arrow;
					return;
				}
				break;
			}
			acpLabel.Cursor = Cursors.Hand;
		}

		// Token: 0x06000C9D RID: 3229 RVA: 0x000BD7DC File Offset: 0x000BB9DC
		private void LblUnlockTrunkButtonCnvValue_AnimationCompleted(object sender, EventArgs e)
		{
			short num = (short)1957494784;
			short num2 = num;
			num = (short)989141934;
			short num3 = num;
			num = (short)2075335598;
			switch (num3 == num)
			{
			}
			num = (short)612958209;
			if (num != 0)
			{
			}
			num = (short)623509504;
			if (num != 0)
			{
			}
			this.isLblUnlockTrunkButtonCnvValueAnimating = false;
		}

		// Token: 0x06000C9E RID: 3230 RVA: 0x000BD88C File Offset: 0x000BBA8C
		private void ScrollingLblUnlockTrunkButtonCnvValue(object sender, MouseButtonEventArgs e)
		{
			short num = (short)1101660160;
			int num2 = (int)((IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					switch (0)
					{
					case 0:
						goto IL_31;
					}
					continue;
				case 1:
					return;
				case 2:
					num = (short)1908277249;
					if (num != 0)
					{
					}
					this.StartScrollingAcpLabel(this.LblUnlockTrunkButtonCnvValue, ref this.isLblUnlockTrunkButtonCnvValueAnimating, this.RenderTransformLblUnlockTrunkButtonCnvValue);
					num = (short)1826226177;
					num2 = (int)((IntPtr)num);
					continue;
				}
				IL_31:
				if ((sender as AcpLabel).ActualWidth <= this.CanvasUnlockTrunkButtonCnvValue.Width)
				{
					break;
				}
				num = (short)1980256176;
				short num3 = num;
				num = (short)388911024;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)1636761600;
					short num4 = num;
					num = (short)1778712576;
					if (num != 0)
					{
					}
					num = (short)513212418;
					num2 = (int)((IntPtr)num);
					break;
				}
				}
			}
		}

		// Token: 0x06000C9F RID: 3231 RVA: 0x000BD9D0 File Offset: 0x000BBBD0
		private void MouseEnterLblUnlockTrunkButtonCnvValue(object sender, MouseEventArgs e)
		{
			short num = (short)1288932532;
			short num2 = num;
			num = (short)1246661812;
			AcpLabel acpLabel;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
				num = (short)1517748224;
				if (num != 0)
				{
				}
				acpLabel = (sender as AcpLabel);
				if (acpLabel.ActualWidth <= this.CanvasUnlockTrunkButtonCnvValue.Width)
				{
					num = (short)270925825;
					if (num != 0)
					{
					}
					num = (short)1813577728;
					short num3 = num;
					acpLabel.Cursor = Cursors.Arrow;
					return;
				}
				break;
			}
			acpLabel.Cursor = Cursors.Hand;
		}

		// Token: 0x06000CA0 RID: 3232 RVA: 0x000BDAA8 File Offset: 0x000BBCA8
		private void LblUnlockTrunkButtonTrkValue_AnimationCompleted(object sender, EventArgs e)
		{
			short num = (short)678756352;
			short num2 = num;
			num = (short)815445797;
			short num3 = num;
			num = (short)1664595749;
			switch (num3 == num)
			{
			}
			num = (short)1238499329;
			if (num != 0)
			{
			}
			num = (short)1951924224;
			if (num != 0)
			{
			}
			this.isLblUnlockTrunkButtonTrkValueAnimating = false;
		}

		// Token: 0x06000CA1 RID: 3233 RVA: 0x000BDB58 File Offset: 0x000BBD58
		private void ScrollingLblUnlockTrunkButtonTrkValue(object sender, MouseButtonEventArgs e)
		{
			short num = (short)1516371968;
			int num2 = (int)((IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					switch (0)
					{
					case 0:
						goto IL_30;
					}
					continue;
				case 1:
					return;
				case 2:
					this.StartScrollingAcpLabel(this.LblUnlockTrunkButtonTrkValue, ref this.isLblUnlockTrunkButtonTrkValueAnimating, this.RenderTransformLblUnlockTrunkButtonTrkValue);
					num = (short)2034827265;
					num2 = (int)((IntPtr)num);
					continue;
				}
				IL_30:
				num = (short)541196289;
				if (num != 0)
				{
				}
				if ((sender as AcpLabel).ActualWidth <= this.CanvasUnlockTrunkButtonTrkValue.Width)
				{
					break;
				}
				num = (short)848004008;
				short num3 = num;
				num = (short)418743208;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					continue;
				case 1:
					break;
				default:
				{
					num = (short)2024275968;
					short num4 = num;
					break;
				}
				}
				num = (short)19464192;
				if (num != 0)
				{
				}
				num = (short)721682434;
				num2 = (int)((IntPtr)num);
			}
		}

		// Token: 0x06000CA2 RID: 3234 RVA: 0x000BDC9C File Offset: 0x000BBE9C
		private void MouseEnterLblUnlockTrunkButtonTrkValue(object sender, MouseEventArgs e)
		{
			short num = (short)147172589;
			short num2 = num;
			num = (short)1317317869;
			AcpLabel acpLabel;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
				num = (short)693764096;
				if (num != 0)
				{
				}
				acpLabel = (sender as AcpLabel);
				if (acpLabel.ActualWidth <= this.CanvasUnlockTrunkButtonTrkValue.Width)
				{
					num = (short)164757504;
					short num3 = num;
					acpLabel.Cursor = Cursors.Arrow;
					return;
				}
				break;
			}
			num = (short)1034027009;
			if (num != 0)
			{
			}
			acpLabel.Cursor = Cursors.Hand;
		}

		// Token: 0x06000CA3 RID: 3235 RVA: 0x000BDD74 File Offset: 0x000BBF74
		private void LblAlarmButtonCnvValue_AnimationCompleted(object sender, EventArgs e)
		{
			short num = (short)1295908864;
			short num2 = num;
			num = (short)1958346753;
			if (num != 0)
			{
			}
			num = (short)1649737514;
			short num3 = num;
			num = (short)1452998442;
			switch (num3 == num)
			{
			}
			num = (short)701169664;
			if (num != 0)
			{
			}
			this.isLblAlarmButtonCnvValueAnimating = false;
		}

		// Token: 0x06000CA4 RID: 3236 RVA: 0x000BDE24 File Offset: 0x000BC024
		private void ScrollingLblAlarmButtonCnvValue(object sender, MouseButtonEventArgs e)
		{
			short num = (short)1264844800;
			int num2 = (int)((IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					switch (0)
					{
					case 0:
						goto IL_31;
					}
					continue;
				case 1:
					return;
				case 2:
					this.StartScrollingAcpLabel(this.LblAlarmButtonCnvValue, ref this.isLblAlarmButtonCnvValueAnimating, this.RenderTransformLblAlarmButtonCnvValue);
					num = (short)1767768065;
					num2 = (int)((IntPtr)num);
					continue;
				}
				IL_31:
				if ((sender as AcpLabel).ActualWidth <= this.CanvasAlarmButtonCnvValue.Width)
				{
					break;
				}
				num = (short)937659978;
				short num3 = num;
				num = (short)638815818;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)553320448;
					short num4 = num;
					num = (short)423297025;
					if (num != 0)
					{
					}
					num = (short)1295253504;
					if (num != 0)
					{
					}
					num = (short)1779499010;
					num2 = (int)((IntPtr)num);
					break;
				}
				}
			}
		}

		// Token: 0x06000CA5 RID: 3237 RVA: 0x000BDF64 File Offset: 0x000BC164
		private void MouseEnterLblAlarmButtonCnvValue(object sender, MouseEventArgs e)
		{
			short num = (short)2012282880;
			short num2 = num;
			AcpLabel acpLabel = sender as AcpLabel;
			if (acpLabel.ActualWidth <= this.CanvasAlarmButtonCnvValue.Width)
			{
				num = (short)129261451;
				short num3 = num;
				num = (short)692412299;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)1132331009;
					if (num != 0)
					{
					}
					num = (short)688455680;
					if (num != 0)
					{
					}
					acpLabel.Cursor = Cursors.Arrow;
					return;
				}
			}
			acpLabel.Cursor = Cursors.Hand;
		}

		// Token: 0x06000CA6 RID: 3238 RVA: 0x000BE040 File Offset: 0x000BC240
		private void LblAlarmButtonTrkValue_AnimationCompleted(object sender, EventArgs e)
		{
			short num = (short)163950784;
			short num2 = num;
			num = (short)992850112;
			switch (num2 == num)
			{
			}
			num = (short)1629880320;
			if (num != 0)
			{
			}
			num = (short)651558912;
			short num3 = num;
			num = (short)1943273473;
			if (num != 0)
			{
			}
			this.isLblAlarmButtonTrkValueAnimating = false;
		}

		// Token: 0x06000CA7 RID: 3239 RVA: 0x000BE0F0 File Offset: 0x000BC2F0
		private void ScrollingLblAlarmButtonTrkValue(object sender, MouseButtonEventArgs e)
		{
			short num = (short)2043543553;
			int num2 = (int)((IntPtr)num);
			for (;;)
			{
				num = (short)242719603;
				short num3 = num;
				num = (short)785881971;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					return;
				default:
					num = (short)1964244992;
					if (num != 0)
					{
					}
					switch (num2)
					{
					case 0:
						return;
					case 1:
						switch (0)
						{
						case 0:
							goto IL_7D;
						}
						continue;
					case 2:
					{
						this.StartScrollingAcpLabel(this.LblAlarmButtonTrkValue, ref this.isLblAlarmButtonTrkValueAnimating, this.RenderTransformLblAlarmButtonTrkValue);
						num = (short)1330642944;
						short num4 = num;
						num = (short)694353920;
						num2 = (int)((IntPtr)num);
						continue;
					}
					}
					IL_7D:
					num = (short)1615265793;
					if (num != 0)
					{
					}
					if ((sender as AcpLabel).ActualWidth <= this.CanvasAlarmButtonTrkValue.Width)
					{
						return;
					}
					num = (short)342491138;
					num2 = (int)((IntPtr)num);
					break;
				}
			}
		}

		// Token: 0x06000CA8 RID: 3240 RVA: 0x000BE234 File Offset: 0x000BC434
		private void MouseEnterLblAlarmButtonTrkValue(object sender, MouseEventArgs e)
		{
			short num = (short)348585984;
			short num2 = num;
			AcpLabel acpLabel = sender as AcpLabel;
			if (acpLabel.ActualWidth <= this.CanvasAlarmButtonTrkValue.Width)
			{
				num = (short)713621505;
				if (num != 0)
				{
				}
				num = (short)1662938982;
				short num3 = num;
				num = (short)1895133030;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)735051776;
					if (num != 0)
					{
					}
					acpLabel.Cursor = Cursors.Arrow;
					return;
				}
			}
			acpLabel.Cursor = Cursors.Hand;
		}

		// Token: 0x170005D3 RID: 1491
		// (get) Token: 0x06000CA9 RID: 3241 RVA: 0x000BE310 File Offset: 0x000BC510
		// (set) Token: 0x06000CAA RID: 3242 RVA: 0x000BE3C8 File Offset: 0x000BC5C8
		public bool LockUpButtonCnvIsAcpValid
		{
			get
			{
				short num = (short)1151003896;
				short num2 = num;
				num = (short)2039868664;
				switch (num2 == num)
				{
				}
				num = (short)1640628224;
				short num3 = num;
				num = (short)1147338753;
				if (num != 0)
				{
				}
				num = (short)683671552;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(SmartKeyFobGraphicView.LockUpButtonCnvIsAcpValidProperty);
			}
			set
			{
				short num = (short)146900285;
				short num2 = num;
				num = (short)1002603837;
				switch (num2 == num)
				{
				}
				num = (short)1103364096;
				short num3 = num;
				num = (short)559939584;
				if (num != 0)
				{
				}
				num = (short)1134034945;
				if (num != 0)
				{
				}
				base.SetValue(SmartKeyFobGraphicView.LockUpButtonCnvIsAcpValidProperty, value);
			}
		}

		// Token: 0x170005D4 RID: 1492
		// (get) Token: 0x06000CAB RID: 3243 RVA: 0x000BE484 File Offset: 0x000BC684
		// (set) Token: 0x06000CAC RID: 3244 RVA: 0x000BE53C File Offset: 0x000BC73C
		public bool LockUpButtonCnvIsAcpApplicable
		{
			get
			{
				short num = (short)900143526;
				short num2 = num;
				num = (short)640817574;
				switch (num2 == num)
				{
				}
				num = (short)743243776;
				short num3 = num;
				num = (short)307494913;
				if (num != 0)
				{
				}
				num = (short)1082261504;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(SmartKeyFobGraphicView.LockUpButtonCnvIsAcpApplicableProperty);
			}
			set
			{
				short num = (short)244999313;
				short num2 = num;
				num = (short)1836672145;
				switch (num2 == num)
				{
				}
				num = (short)175898624;
				short num3 = num;
				num = (short)431489025;
				if (num != 0)
				{
				}
				num = (short)1223098368;
				if (num != 0)
				{
				}
				base.SetValue(SmartKeyFobGraphicView.LockUpButtonCnvIsAcpApplicableProperty, value);
			}
		}

		// Token: 0x170005D5 RID: 1493
		// (get) Token: 0x06000CAD RID: 3245 RVA: 0x000BE5F8 File Offset: 0x000BC7F8
		// (set) Token: 0x06000CAE RID: 3246 RVA: 0x000BE6B4 File Offset: 0x000BC8B4
		public bool LockUpButtonCnvIsAcpVisible
		{
			get
			{
				short num = (short)714934620;
				short num2 = num;
				num = (short)765397340;
				switch (num2 == num)
				{
				}
				num = (short)2027880448;
				short num3 = num;
				num = (short)685375489;
				if (num != 0)
				{
				}
				num = (short)219676672;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(SmartKeyFobGraphicView.LockUpButtonCnvIsAcpVisibleProperty);
			}
			set
			{
				short num = (short)110083309;
				short num2 = num;
				num = (short)1872739565;
				switch (num2 == num)
				{
				}
				num = (short)1199767552;
				short num3 = num;
				num = (short)1420820480;
				if (num != 0)
				{
				}
				num = (short)1293221889;
				if (num != 0)
				{
				}
				base.SetValue(SmartKeyFobGraphicView.LockUpButtonCnvIsAcpVisibleProperty, value);
			}
		}

		// Token: 0x170005D6 RID: 1494
		// (get) Token: 0x06000CAF RID: 3247 RVA: 0x000BE76C File Offset: 0x000BC96C
		// (set) Token: 0x06000CB0 RID: 3248 RVA: 0x000BE828 File Offset: 0x000BCA28
		public bool LockUpButtonCnvIsAcpEditable
		{
			get
			{
				short num = (short)1018628960;
				short num2 = num;
				num = (short)271977312;
				switch (num2 == num)
				{
				}
				num = (short)706609152;
				short num3 = num;
				num = (short)341442561;
				if (num != 0)
				{
				}
				num = (short)1117257728;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(SmartKeyFobGraphicView.LockUpButtonCnvIsAcpEditableProperty);
			}
			set
			{
				short num = (short)285586769;
				short num2 = num;
				num = (short)1202894161;
				switch (num2 == num)
				{
				}
				num = (short)1027145728;
				short num3 = num;
				num = (short)1898577920;
				if (num != 0)
				{
				}
				num = (short)603127809;
				if (num != 0)
				{
				}
				base.SetValue(SmartKeyFobGraphicView.LockUpButtonCnvIsAcpEditableProperty, value);
			}
		}

		// Token: 0x170005D7 RID: 1495
		// (get) Token: 0x06000CB1 RID: 3249 RVA: 0x000BE8E0 File Offset: 0x000BCAE0
		// (set) Token: 0x06000CB2 RID: 3250 RVA: 0x000BE99C File Offset: 0x000BCB9C
		public string LockUpButtonCnvUIValue
		{
			get
			{
				short num = (short)679214572;
				short num2 = num;
				num = (short)2051341804;
				switch (num2 == num)
				{
				}
				num = (short)1203503104;
				short num3 = num;
				num = (short)1139277825;
				if (num != 0)
				{
				}
				num = (short)63438848;
				if (num != 0)
				{
				}
				return (string)base.GetValue(SmartKeyFobGraphicView.LockUpButtonCnvUIValueProperty);
			}
			set
			{
				short num = (short)31966098;
				short num2 = num;
				num = (short)83542930;
				switch (num2 == num)
				{
				}
				num = (short)284164096;
				short num3 = num;
				num = (short)1837694977;
				if (num != 0)
				{
				}
				num = (short)947519488;
				if (num != 0)
				{
				}
				base.SetValue(SmartKeyFobGraphicView.LockUpButtonCnvUIValueProperty, value);
			}
		}

		// Token: 0x170005D8 RID: 1496
		// (get) Token: 0x06000CB3 RID: 3251 RVA: 0x000BEA54 File Offset: 0x000BCC54
		// (set) Token: 0x06000CB4 RID: 3252 RVA: 0x000BEB10 File Offset: 0x000BCD10
		public AcpListField LockUpButtonCnvList
		{
			get
			{
				short num = (short)586566298;
				short num2 = num;
				num = (short)1417038490;
				switch (num2 == num)
				{
				}
				num = (short)805437440;
				short num3 = num;
				num = (short)461504513;
				if (num != 0)
				{
				}
				num = (short)19791872;
				if (num != 0)
				{
				}
				return (AcpListField)base.GetValue(SmartKeyFobGraphicView.LockUpButtonCnvListProperty);
			}
			set
			{
				short num = (short)193540127;
				short num2 = num;
				num = (short)153694239;
				switch (num2 == num)
				{
				}
				num = (short)1045823488;
				short num3 = num;
				num = (short)1409155072;
				if (num != 0)
				{
				}
				num = (short)318373889;
				if (num != 0)
				{
				}
				base.SetValue(SmartKeyFobGraphicView.LockUpButtonCnvListProperty, value);
			}
		}

		// Token: 0x170005D9 RID: 1497
		// (get) Token: 0x06000CB5 RID: 3253 RVA: 0x000BEBC8 File Offset: 0x000BCDC8
		// (set) Token: 0x06000CB6 RID: 3254 RVA: 0x000BEC80 File Offset: 0x000BCE80
		public bool LockUpButtonTrkIsAcpValid
		{
			get
			{
				short num = (short)1290356532;
				short num2 = num;
				num = (short)2029078324;
				switch (num2 == num)
				{
				}
				num = (short)256507904;
				short num3 = num;
				num = (short)1073020929;
				if (num != 0)
				{
				}
				num = (short)133693440;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(SmartKeyFobGraphicView.LockUpButtonTrkIsAcpValidProperty);
			}
			set
			{
				short num = (short)1971285913;
				short num2 = num;
				num = (short)1363701657;
				switch (num2 == num)
				{
				}
				num = (short)1967915008;
				short num3 = num;
				num = (short)1217462273;
				if (num != 0)
				{
				}
				num = (short)1507328;
				if (num != 0)
				{
				}
				base.SetValue(SmartKeyFobGraphicView.LockUpButtonTrkIsAcpValidProperty, value);
			}
		}

		// Token: 0x170005DA RID: 1498
		// (get) Token: 0x06000CB7 RID: 3255 RVA: 0x000BED3C File Offset: 0x000BCF3C
		// (set) Token: 0x06000CB8 RID: 3256 RVA: 0x000BEDF4 File Offset: 0x000BCFF4
		public bool LockUpButtonTrkIsAcpApplicable
		{
			get
			{
				short num = (short)566441994;
				short num2 = num;
				num = (short)775895050;
				switch (num2 == num)
				{
				}
				num = (short)733872128;
				short num3 = num;
				num = (short)260964352;
				if (num != 0)
				{
				}
				num = (short)1057423361;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(SmartKeyFobGraphicView.LockUpButtonTrkIsAcpApplicableProperty);
			}
			set
			{
				short num = (short)1404108801;
				if (num != 0)
				{
				}
				num = (short)299507498;
				short num2 = num;
				num = (short)546250538;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1768882176;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1428750336;
				if (num != 0)
				{
				}
				base.SetValue(SmartKeyFobGraphicView.LockUpButtonTrkIsAcpApplicableProperty, value);
			}
		}

		// Token: 0x170005DB RID: 1499
		// (get) Token: 0x06000CB9 RID: 3257 RVA: 0x000BEEB0 File Offset: 0x000BD0B0
		// (set) Token: 0x06000CBA RID: 3258 RVA: 0x000BEF68 File Offset: 0x000BD168
		public bool LockUpButtonTrkIsAcpVisible
		{
			get
			{
				short num = (short)361465042;
				short num2 = num;
				num = (short)534283474;
				switch (num2 == num)
				{
				}
				num = (short)1535180800;
				short num3 = num;
				num = (short)1994588160;
				if (num != 0)
				{
				}
				num = (short)2129854465;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(SmartKeyFobGraphicView.LockUpButtonTrkIsAcpVisibleProperty);
			}
			set
			{
				short num = (short)70243364;
				short num2 = num;
				num = (short)288609316;
				switch (num2 == num)
				{
				}
				num = (short)1543503872;
				short num3 = num;
				num = (short)558301184;
				if (num != 0)
				{
				}
				num = (short)1515978753;
				if (num != 0)
				{
				}
				base.SetValue(SmartKeyFobGraphicView.LockUpButtonTrkIsAcpVisibleProperty, value);
			}
		}

		// Token: 0x170005DC RID: 1500
		// (get) Token: 0x06000CBB RID: 3259 RVA: 0x000BF024 File Offset: 0x000BD224
		// (set) Token: 0x06000CBC RID: 3260 RVA: 0x000BF0DC File Offset: 0x000BD2DC
		public bool LockUpButtonTrkIsAcpEditable
		{
			get
			{
				short num = (short)262129317;
				short num2 = num;
				num = (short)1907213989;
				switch (num2 == num)
				{
				}
				num = (short)725680128;
				short num3 = num;
				num = (short)1621884928;
				if (num != 0)
				{
				}
				num = (short)855834625;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(SmartKeyFobGraphicView.LockUpButtonTrkIsAcpEditableProperty);
			}
			set
			{
				short num = (short)1892785604;
				short num2 = num;
				num = (short)946445764;
				switch (num2 == num)
				{
				}
				num = (short)1192427520;
				short num3 = num;
				num = (short)740425729;
				if (num != 0)
				{
				}
				num = (short)1375010816;
				if (num != 0)
				{
				}
				base.SetValue(SmartKeyFobGraphicView.LockUpButtonTrkIsAcpEditableProperty, value);
			}
		}

		// Token: 0x170005DD RID: 1501
		// (get) Token: 0x06000CBD RID: 3261 RVA: 0x000BF198 File Offset: 0x000BD398
		// (set) Token: 0x06000CBE RID: 3262 RVA: 0x000BF250 File Offset: 0x000BD450
		public string LockUpButtonTrkUIValue
		{
			get
			{
				short num = (short)279391720;
				short num2 = num;
				num = (short)970272232;
				switch (num2 == num)
				{
				}
				num = (short)952762368;
				short num3 = num;
				num = (short)1459224577;
				if (num != 0)
				{
				}
				num = (short)570818560;
				if (num != 0)
				{
				}
				return (string)base.GetValue(SmartKeyFobGraphicView.LockUpButtonTrkUIValueProperty);
			}
			set
			{
				short num = (short)1251947786;
				short num2 = num;
				num = (short)1914057994;
				switch (num2 == num)
				{
				}
				num = (short)2143551488;
				short num3 = num;
				num = (short)548929536;
				if (num != 0)
				{
				}
				num = (short)46137345;
				if (num != 0)
				{
				}
				base.SetValue(SmartKeyFobGraphicView.LockUpButtonTrkUIValueProperty, value);
			}
		}

		// Token: 0x170005DE RID: 1502
		// (get) Token: 0x06000CBF RID: 3263 RVA: 0x000BF308 File Offset: 0x000BD508
		// (set) Token: 0x06000CC0 RID: 3264 RVA: 0x000BF3C0 File Offset: 0x000BD5C0
		public AcpListField LockUpButtonTrkList
		{
			get
			{
				short num = (short)318755116;
				short num2 = num;
				num = (short)1103745324;
				switch (num2 == num)
				{
				}
				num = (short)323878912;
				short num3 = num;
				num = (short)558891009;
				if (num != 0)
				{
				}
				num = (short)771686400;
				if (num != 0)
				{
				}
				return (AcpListField)base.GetValue(SmartKeyFobGraphicView.LockUpButtonTrkListProperty);
			}
			set
			{
				short num = (short)1574545058;
				short num2 = num;
				num = (short)1575724706;
				switch (num2 == num)
				{
				}
				num = (short)739115008;
				short num3 = num;
				num = (short)400490497;
				if (num != 0)
				{
				}
				num = (short)1267007488;
				if (num != 0)
				{
				}
				base.SetValue(SmartKeyFobGraphicView.LockUpButtonTrkListProperty, value);
			}
		}

		// Token: 0x170005DF RID: 1503
		// (get) Token: 0x06000CC1 RID: 3265 RVA: 0x000BF474 File Offset: 0x000BD674
		// (set) Token: 0x06000CC2 RID: 3266 RVA: 0x000BF530 File Offset: 0x000BD730
		public bool LockDownButtonCnvIsAcpValid
		{
			get
			{
				short num = (short)1201258859;
				short num2 = num;
				num = (short)814268779;
				switch (num2 == num)
				{
				}
				num = (short)1839136768;
				short num3 = num;
				num = (short)1639710721;
				if (num != 0)
				{
				}
				num = (short)1890451456;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(SmartKeyFobGraphicView.LockDownButtonCnvIsAcpValidProperty);
			}
			set
			{
				short num = (short)358928811;
				short num2 = num;
				num = (short)1194512811;
				switch (num2 == num)
				{
				}
				num = (short)617938944;
				short num3 = num;
				num = (short)1118109696;
				if (num != 0)
				{
				}
				num = (short)1471873025;
				if (num != 0)
				{
				}
				base.SetValue(SmartKeyFobGraphicView.LockDownButtonCnvIsAcpValidProperty, value);
			}
		}

		// Token: 0x170005E0 RID: 1504
		// (get) Token: 0x06000CC3 RID: 3267 RVA: 0x000BF5EC File Offset: 0x000BD7EC
		// (set) Token: 0x06000CC4 RID: 3268 RVA: 0x000BF6A8 File Offset: 0x000BD8A8
		public bool LockDownButtonCnvIsAcpApplicable
		{
			get
			{
				short num = (short)623968257;
				if (num != 0)
				{
				}
				num = (short)1412422119;
				short num2 = num;
				num = (short)417978855;
				switch (num2 == num)
				{
				default:
				{
					num = (short)58327040;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1074003968;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(SmartKeyFobGraphicView.LockDownButtonCnvIsAcpApplicableProperty);
			}
			set
			{
				short num = (short)878896790;
				short num2 = num;
				num = (short)685368982;
				switch (num2 == num)
				{
				}
				num = (short)1293877248;
				short num3 = num;
				num = (short)2006843393;
				if (num != 0)
				{
				}
				num = (short)1592131584;
				if (num != 0)
				{
				}
				base.SetValue(SmartKeyFobGraphicView.LockDownButtonCnvIsAcpApplicableProperty, value);
			}
		}

		// Token: 0x170005E1 RID: 1505
		// (get) Token: 0x06000CC5 RID: 3269 RVA: 0x000BF760 File Offset: 0x000BD960
		// (set) Token: 0x06000CC6 RID: 3270 RVA: 0x000BF818 File Offset: 0x000BDA18
		public bool LockDownButtonCnvIsAcpVisible
		{
			get
			{
				short num = (short)1963349131;
				short num2 = num;
				num = (short)1469600907;
				switch (num2 == num)
				{
				}
				num = (short)1182203904;
				short num3 = num;
				num = (short)286326784;
				if (num != 0)
				{
				}
				num = (short)770113537;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(SmartKeyFobGraphicView.LockDownButtonCnvIsAcpVisibleProperty);
			}
			set
			{
				short num = (short)765719830;
				short num2 = num;
				num = (short)1988293910;
				switch (num2 == num)
				{
				}
				num = (short)1258881024;
				short num3 = num;
				num = (short)1708064768;
				if (num != 0)
				{
				}
				num = (short)1312030721;
				if (num != 0)
				{
				}
				base.SetValue(SmartKeyFobGraphicView.LockDownButtonCnvIsAcpVisibleProperty, value);
			}
		}

		// Token: 0x170005E2 RID: 1506
		// (get) Token: 0x06000CC7 RID: 3271 RVA: 0x000BF8D4 File Offset: 0x000BDAD4
		// (set) Token: 0x06000CC8 RID: 3272 RVA: 0x000BF98C File Offset: 0x000BDB8C
		public bool LockDownButtonCnvIsAcpEditable
		{
			get
			{
				short num = (short)806609474;
				short num2 = num;
				num = (short)512352834;
				switch (num2 == num)
				{
				}
				num = (short)1953234944;
				short num3 = num;
				num = (short)427098113;
				if (num != 0)
				{
				}
				num = (short)1191444480;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(SmartKeyFobGraphicView.LockDownButtonCnvIsAcpEditableProperty);
			}
			set
			{
				short num = (short)2060705957;
				short num2 = num;
				num = (short)1966923941;
				switch (num2 == num)
				{
				}
				num = (short)1708130304;
				short num3 = num;
				num = (short)1760493569;
				if (num != 0)
				{
				}
				num = (short)468779008;
				if (num != 0)
				{
				}
				base.SetValue(SmartKeyFobGraphicView.LockDownButtonCnvIsAcpEditableProperty, value);
			}
		}

		// Token: 0x170005E3 RID: 1507
		// (get) Token: 0x06000CC9 RID: 3273 RVA: 0x000BFA48 File Offset: 0x000BDC48
		// (set) Token: 0x06000CCA RID: 3274 RVA: 0x000BFB08 File Offset: 0x000BDD08
		public string LockDownButtonCnvUIValue
		{
			get
			{
				short num = (short)222740600;
				short num2 = num;
				num = (short)1824112760;
				switch (num2 == num)
				{
				}
				num = (short)1102643200;
				short num3 = num;
				num = (short)1291452417;
				if (num != 0)
				{
				}
				num = (short)1556480000;
				if (num != 0)
				{
				}
				return (string)base.GetValue(SmartKeyFobGraphicView.LockDownButtonCnvUIValueProperty);
			}
			set
			{
				short num = (short)1839817913;
				short num2 = num;
				num = (short)1699374265;
				switch (num2 == num)
				{
				}
				num = (short)57278464;
				short num3 = num;
				num = (short)2147024897;
				if (num != 0)
				{
				}
				num = (short)877395968;
				if (num != 0)
				{
				}
				base.SetValue(SmartKeyFobGraphicView.LockDownButtonCnvUIValueProperty, value);
			}
		}

		// Token: 0x170005E4 RID: 1508
		// (get) Token: 0x06000CCB RID: 3275 RVA: 0x000BFBC0 File Offset: 0x000BDDC0
		// (set) Token: 0x06000CCC RID: 3276 RVA: 0x000BFC78 File Offset: 0x000BDE78
		public AcpListField LockDownButtonCnvList
		{
			get
			{
				short num = (short)1202847745;
				if (num != 0)
				{
				}
				num = (short)1469670446;
				short num2 = num;
				num = (short)448750638;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1161887744;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1217200128;
				if (num != 0)
				{
				}
				return (AcpListField)base.GetValue(SmartKeyFobGraphicView.LockDownButtonCnvListProperty);
			}
			set
			{
				short num = (short)1668457455;
				short num2 = num;
				num = (short)78226415;
				switch (num2 == num)
				{
				}
				num = (short)1786642432;
				short num3 = num;
				num = (short)1542848513;
				if (num != 0)
				{
				}
				num = (short)1735655424;
				if (num != 0)
				{
				}
				base.SetValue(SmartKeyFobGraphicView.LockDownButtonCnvListProperty, value);
			}
		}

		// Token: 0x170005E5 RID: 1509
		// (get) Token: 0x06000CCD RID: 3277 RVA: 0x000BFD30 File Offset: 0x000BDF30
		// (set) Token: 0x06000CCE RID: 3278 RVA: 0x000BFDEC File Offset: 0x000BDFEC
		public bool LockDownButtonTrkIsAcpValid
		{
			get
			{
				short num = (short)879222760;
				short num2 = num;
				num = (short)295624680;
				switch (num2 == num)
				{
				}
				num = (short)1098973184;
				short num3 = num;
				num = (short)2088304641;
				if (num != 0)
				{
				}
				num = (short)1993342976;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(SmartKeyFobGraphicView.LockDownButtonTrkIsAcpValidProperty);
			}
			set
			{
				short num = (short)1814677052;
				short num2 = num;
				num = (short)1776076348;
				switch (num2 == num)
				{
				}
				num = (short)538968064;
				short num3 = num;
				num = (short)1524957185;
				if (num != 0)
				{
				}
				num = (short)1490026496;
				if (num != 0)
				{
				}
				base.SetValue(SmartKeyFobGraphicView.LockDownButtonTrkIsAcpValidProperty, value);
			}
		}

		// Token: 0x170005E6 RID: 1510
		// (get) Token: 0x06000CCF RID: 3279 RVA: 0x000BFEA4 File Offset: 0x000BE0A4
		// (set) Token: 0x06000CD0 RID: 3280 RVA: 0x000BFF5C File Offset: 0x000BE15C
		public bool LockDownButtonTrkIsAcpApplicable
		{
			get
			{
				short num = (short)2093208512;
				short num2 = num;
				num = (short)342348736;
				switch (num2 == num)
				{
				}
				num = (short)210042880;
				short num3 = num;
				num = (short)1498218496;
				if (num != 0)
				{
				}
				num = (short)520224769;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(SmartKeyFobGraphicView.LockDownButtonTrkIsAcpApplicableProperty);
			}
			set
			{
				short num = (short)867133017;
				short num2 = num;
				num = (short)472802905;
				switch (num2 == num)
				{
				}
				num = (short)960495616;
				if (num != 0)
				{
				}
				num = (short)867827712;
				short num3 = num;
				num = (short)1624309761;
				if (num != 0)
				{
				}
				base.SetValue(SmartKeyFobGraphicView.LockDownButtonTrkIsAcpApplicableProperty, value);
			}
		}

		// Token: 0x170005E7 RID: 1511
		// (get) Token: 0x06000CD1 RID: 3281 RVA: 0x000C0018 File Offset: 0x000BE218
		// (set) Token: 0x06000CD2 RID: 3282 RVA: 0x000C00D4 File Offset: 0x000BE2D4
		public bool LockDownButtonTrkIsAcpVisible
		{
			get
			{
				short num = (short)2100890113;
				short num2 = num;
				num = (short)46139905;
				switch (num2 == num)
				{
				}
				num = (short)958791681;
				if (num != 0)
				{
				}
				num = (short)110034944;
				short num3 = num;
				num = (short)513474560;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(SmartKeyFobGraphicView.LockDownButtonTrkIsAcpVisibleProperty);
			}
			set
			{
				short num = (short)1884660791;
				short num2 = num;
				num = (short)436970551;
				switch (num2 == num)
				{
				}
				num = (short)1443561472;
				if (num != 0)
				{
				}
				num = (short)1588002816;
				short num3 = num;
				num = (short)714014721;
				if (num != 0)
				{
				}
				base.SetValue(SmartKeyFobGraphicView.LockDownButtonTrkIsAcpVisibleProperty, value);
			}
		}

		// Token: 0x170005E8 RID: 1512
		// (get) Token: 0x06000CD3 RID: 3283 RVA: 0x000C0190 File Offset: 0x000BE390
		// (set) Token: 0x06000CD4 RID: 3284 RVA: 0x000C0248 File Offset: 0x000BE448
		public bool LockDownButtonTrkIsAcpEditable
		{
			get
			{
				short num = (short)1978336150;
				short num2 = num;
				num = (short)2093745046;
				switch (num2 == num)
				{
				}
				num = (short)751304704;
				if (num != 0)
				{
				}
				num = (short)578682880;
				short num3 = num;
				num = (short)2129330177;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(SmartKeyFobGraphicView.LockDownButtonTrkIsAcpEditableProperty);
			}
			set
			{
				short num = (short)1029242881;
				if (num != 0)
				{
				}
				num = (short)1449482268;
				short num2 = num;
				num = (short)83646492;
				switch (num2 == num)
				{
				}
				num = (short)2037186560;
				short num3 = num;
				num = (short)2020605952;
				if (num != 0)
				{
				}
				base.SetValue(SmartKeyFobGraphicView.LockDownButtonTrkIsAcpEditableProperty, value);
			}
		}

		// Token: 0x170005E9 RID: 1513
		// (get) Token: 0x06000CD5 RID: 3285 RVA: 0x000C0304 File Offset: 0x000BE504
		// (set) Token: 0x06000CD6 RID: 3286 RVA: 0x000C03BC File Offset: 0x000BE5BC
		public string LockDownButtonTrkUIValue
		{
			get
			{
				short num = (short)820184342;
				short num2 = num;
				num = (short)1009845526;
				switch (num2 == num)
				{
				}
				num = (short)1421541377;
				if (num != 0)
				{
				}
				num = (short)1900871680;
				short num3 = num;
				num = (short)1748566016;
				if (num != 0)
				{
				}
				return (string)base.GetValue(SmartKeyFobGraphicView.LockDownButtonTrkUIValueProperty);
			}
			set
			{
				short num = (short)1411448833;
				if (num != 0)
				{
				}
				num = (short)1186487444;
				short num2 = num;
				num = (short)1630952596;
				switch (num2 == num)
				{
				}
				num = (short)860291072;
				short num3 = num;
				num = (short)1538850816;
				if (num != 0)
				{
				}
				base.SetValue(SmartKeyFobGraphicView.LockDownButtonTrkUIValueProperty, value);
			}
		}

		// Token: 0x170005EA RID: 1514
		// (get) Token: 0x06000CD7 RID: 3287 RVA: 0x000C0474 File Offset: 0x000BE674
		// (set) Token: 0x06000CD8 RID: 3288 RVA: 0x000C052C File Offset: 0x000BE72C
		public AcpListField LockDownButtonTrkList
		{
			get
			{
				short num = (short)1516531696;
				short num2 = num;
				num = (short)996175856;
				switch (num2 == num)
				{
				}
				num = (short)1982267393;
				if (num != 0)
				{
				}
				num = (short)1282932736;
				short num3 = num;
				num = (short)2132475904;
				if (num != 0)
				{
				}
				return (AcpListField)base.GetValue(SmartKeyFobGraphicView.LockDownButtonTrkListProperty);
			}
			set
			{
				short num = (short)2061112335;
				short num2 = num;
				num = (short)1463030799;
				switch (num2 == num)
				{
				}
				num = (short)1754464257;
				if (num != 0)
				{
				}
				num = (short)390135808;
				short num3 = num;
				num = (short)1364000768;
				if (num != 0)
				{
				}
				base.SetValue(SmartKeyFobGraphicView.LockDownButtonTrkListProperty, value);
			}
		}

		// Token: 0x170005EB RID: 1515
		// (get) Token: 0x06000CD9 RID: 3289 RVA: 0x000C05DC File Offset: 0x000BE7DC
		// (set) Token: 0x06000CDA RID: 3290 RVA: 0x000C0698 File Offset: 0x000BE898
		public bool UnlockUpButtonCnvIsAcpValid
		{
			get
			{
				short num = (short)154468353;
				if (num != 0)
				{
				}
				num = (short)1876391139;
				short num2 = num;
				num = (short)1188590819;
				switch (num2 == num)
				{
				}
				num = (short)952762368;
				short num3 = num;
				num = (short)1315504128;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(SmartKeyFobGraphicView.UnlockUpButtonCnvIsAcpValidProperty);
			}
			set
			{
				short num = (short)1966923776;
				short num2 = num;
				num = (short)1891950592;
				switch (num2 == num)
				{
				}
				num = (short)2113732608;
				if (num != 0)
				{
				}
				num = (short)998113280;
				short num3 = num;
				num = (short)1619197953;
				if (num != 0)
				{
				}
				base.SetValue(SmartKeyFobGraphicView.UnlockUpButtonCnvIsAcpValidProperty, value);
			}
		}

		// Token: 0x170005EC RID: 1516
		// (get) Token: 0x06000CDB RID: 3291 RVA: 0x000C0754 File Offset: 0x000BE954
		// (set) Token: 0x06000CDC RID: 3292 RVA: 0x000C0810 File Offset: 0x000BEA10
		public bool UnlockUpButtonCnvIsAcpApplicable
		{
			get
			{
				short num = (short)433717248;
				short num2 = num;
				num = (short)94833015;
				short num3 = num;
				num = (short)225315191;
				switch (num3 == num)
				{
				}
				num = (short)1416626176;
				if (num != 0)
				{
				}
				num = (short)168099841;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(SmartKeyFobGraphicView.UnlockUpButtonCnvIsAcpApplicableProperty);
			}
			set
			{
				short num = (short)1778974720;
				short num2 = num;
				num = (short)1872595815;
				short num3 = num;
				num = (short)1028492135;
				switch (num3 == num)
				{
				}
				num = (short)1262616576;
				if (num != 0)
				{
				}
				num = (short)1822359553;
				if (num != 0)
				{
				}
				base.SetValue(SmartKeyFobGraphicView.UnlockUpButtonCnvIsAcpApplicableProperty, value);
			}
		}

		// Token: 0x170005ED RID: 1517
		// (get) Token: 0x06000CDD RID: 3293 RVA: 0x000C08CC File Offset: 0x000BEACC
		// (set) Token: 0x06000CDE RID: 3294 RVA: 0x000C0988 File Offset: 0x000BEB88
		public bool UnlockUpButtonCnvIsAcpVisible
		{
			get
			{
				short num = (short)1012989952;
				short num2 = num;
				num = (short)351922714;
				short num3 = num;
				num = (short)1929767450;
				switch (num3 == num)
				{
				}
				num = (short)427556865;
				if (num != 0)
				{
				}
				num = (short)106037248;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(SmartKeyFobGraphicView.UnlockUpButtonCnvIsAcpVisibleProperty);
			}
			set
			{
				short num = (short)1665400832;
				short num2 = num;
				num = (short)1498086831;
				short num3 = num;
				num = (short)1976040879;
				switch (num3 == num)
				{
				}
				num = (short)705232897;
				if (num != 0)
				{
				}
				num = (short)1664876544;
				if (num != 0)
				{
				}
				base.SetValue(SmartKeyFobGraphicView.UnlockUpButtonCnvIsAcpVisibleProperty, value);
			}
		}

		// Token: 0x170005EE RID: 1518
		// (get) Token: 0x06000CDF RID: 3295 RVA: 0x000C0A44 File Offset: 0x000BEC44
		// (set) Token: 0x06000CE0 RID: 3296 RVA: 0x000C0AFC File Offset: 0x000BECFC
		public bool UnlockUpButtonCnvIsAcpEditable
		{
			get
			{
				short num = (short)421199872;
				short num2 = num;
				num = (short)742277502;
				short num3 = num;
				num = (short)160383358;
				switch (num3 == num)
				{
				}
				num = (short)647954432;
				if (num != 0)
				{
				}
				num = (short)1066991617;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(SmartKeyFobGraphicView.UnlockUpButtonCnvIsAcpEditableProperty);
			}
			set
			{
				short num = (short)76742656;
				short num2 = num;
				num = (short)403552237;
				short num3 = num;
				num = (short)787265517;
				switch (num3 == num)
				{
				}
				num = (short)1786707969;
				if (num != 0)
				{
				}
				num = (short)563412992;
				if (num != 0)
				{
				}
				base.SetValue(SmartKeyFobGraphicView.UnlockUpButtonCnvIsAcpEditableProperty, value);
			}
		}

		// Token: 0x170005EF RID: 1519
		// (get) Token: 0x06000CE1 RID: 3297 RVA: 0x000C0BB4 File Offset: 0x000BEDB4
		// (set) Token: 0x06000CE2 RID: 3298 RVA: 0x000C0C6C File Offset: 0x000BEE6C
		public string UnlockUpButtonCnvUIValue
		{
			get
			{
				short num = (short)614531072;
				short num2 = num;
				num = (short)443134992;
				short num3 = num;
				num = (short)438219792;
				switch (num3 == num)
				{
				}
				num = (short)1843396608;
				if (num != 0)
				{
				}
				num = (short)1117388801;
				if (num != 0)
				{
				}
				return (string)base.GetValue(SmartKeyFobGraphicView.UnlockUpButtonCnvUIValueProperty);
			}
			set
			{
				short num = (short)1878851584;
				short num2 = num;
				num = (short)479228675;
				short num3 = num;
				num = (short)1466856195;
				switch (num3 == num)
				{
				}
				num = (short)757006336;
				if (num != 0)
				{
				}
				num = (short)698548225;
				if (num != 0)
				{
				}
				base.SetValue(SmartKeyFobGraphicView.UnlockUpButtonCnvUIValueProperty, value);
			}
		}

		// Token: 0x170005F0 RID: 1520
		// (get) Token: 0x06000CE3 RID: 3299 RVA: 0x000C0D24 File Offset: 0x000BEF24
		// (set) Token: 0x06000CE4 RID: 3300 RVA: 0x000C0DE0 File Offset: 0x000BEFE0
		public AcpListField UnlockUpButtonCnvList
		{
			get
			{
				short num = (short)497680384;
				short num2 = num;
				num = (short)968032257;
				if (num != 0)
				{
				}
				num = (short)1551672102;
				short num3 = num;
				num = (short)603038502;
				switch (num3 == num)
				{
				}
				num = (short)301662208;
				if (num != 0)
				{
				}
				return (AcpListField)base.GetValue(SmartKeyFobGraphicView.UnlockUpButtonCnvListProperty);
			}
			set
			{
				short num = (short)1758789632;
				short num2 = num;
				num = (short)940586929;
				short num3 = num;
				num = (short)409221041;
				switch (num3 == num)
				{
				}
				num = (short)1569587201;
				if (num != 0)
				{
				}
				num = (short)1342963712;
				if (num != 0)
				{
				}
				base.SetValue(SmartKeyFobGraphicView.UnlockUpButtonCnvListProperty, value);
			}
		}

		// Token: 0x170005F1 RID: 1521
		// (get) Token: 0x06000CE5 RID: 3301 RVA: 0x000C0E94 File Offset: 0x000BF094
		// (set) Token: 0x06000CE6 RID: 3302 RVA: 0x000C0F4C File Offset: 0x000BF14C
		public bool UnlockUpButtonTrkIsAcpValid
		{
			get
			{
				short num = (short)40304640;
				short num2 = num;
				num = (short)1314448133;
				short num3 = num;
				num = (short)403038981;
				switch (num3 == num)
				{
				}
				num = (short)1396637696;
				if (num != 0)
				{
				}
				num = (short)1972764673;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(SmartKeyFobGraphicView.UnlockUpButtonTrkIsAcpValidProperty);
			}
			set
			{
				short num = (short)22085632;
				short num2 = num;
				num = (short)871441609;
				short num3 = num;
				num = (short)1329145033;
				switch (num3 == num)
				{
				}
				num = (short)1812856833;
				if (num != 0)
				{
				}
				num = (short)977666048;
				if (num != 0)
				{
				}
				base.SetValue(SmartKeyFobGraphicView.UnlockUpButtonTrkIsAcpValidProperty, value);
			}
		}

		// Token: 0x170005F2 RID: 1522
		// (get) Token: 0x06000CE7 RID: 3303 RVA: 0x000C100C File Offset: 0x000BF20C
		// (set) Token: 0x06000CE8 RID: 3304 RVA: 0x000C10C4 File Offset: 0x000BF2C4
		public bool UnlockUpButtonTrkIsAcpApplicable
		{
			get
			{
				short num = (short)2142568448;
				short num2 = num;
				num = (short)1415249921;
				if (num != 0)
				{
				}
				num = (short)708862150;
				short num3 = num;
				num = (short)1102012614;
				switch (num3 == num)
				{
				}
				num = (short)166002688;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(SmartKeyFobGraphicView.UnlockUpButtonTrkIsAcpApplicableProperty);
			}
			set
			{
				short num = (short)862519296;
				short num2 = num;
				num = (short)931530965;
				short num3 = num;
				num = (short)2075134165;
				switch (num3 == num)
				{
				}
				num = (short)634388480;
				if (num != 0)
				{
				}
				num = (short)1171783681;
				if (num != 0)
				{
				}
				base.SetValue(SmartKeyFobGraphicView.UnlockUpButtonTrkIsAcpApplicableProperty, value);
			}
		}

		// Token: 0x170005F3 RID: 1523
		// (get) Token: 0x06000CE9 RID: 3305 RVA: 0x000C1180 File Offset: 0x000BF380
		// (set) Token: 0x06000CEA RID: 3306 RVA: 0x000C1238 File Offset: 0x000BF438
		public bool UnlockUpButtonTrkIsAcpVisible
		{
			get
			{
				short num = (short)34144256;
				short num2 = num;
				num = (short)142467407;
				short num3 = num;
				num = (short)896917839;
				switch (num3 == num)
				{
				}
				num = (short)102563840;
				if (num != 0)
				{
				}
				num = (short)1470889985;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(SmartKeyFobGraphicView.UnlockUpButtonTrkIsAcpVisibleProperty);
			}
			set
			{
				short num = (short)2015166464;
				short num2 = num;
				num = (short)589299713;
				if (num != 0)
				{
				}
				num = (short)1328835060;
				short num3 = num;
				num = (short)83519988;
				switch (num3 == num)
				{
				}
				num = (short)1398538240;
				if (num != 0)
				{
				}
				base.SetValue(SmartKeyFobGraphicView.UnlockUpButtonTrkIsAcpVisibleProperty, value);
			}
		}

		// Token: 0x170005F4 RID: 1524
		// (get) Token: 0x06000CEB RID: 3307 RVA: 0x000C12F0 File Offset: 0x000BF4F0
		// (set) Token: 0x06000CEC RID: 3308 RVA: 0x000C13A8 File Offset: 0x000BF5A8
		public bool UnlockUpButtonTrkIsAcpEditable
		{
			get
			{
				short num = (short)1297743872;
				short num2 = num;
				num = (short)248606630;
				short num3 = num;
				num = (short)344158118;
				switch (num3 == num)
				{
				}
				num = (short)2005663744;
				if (num != 0)
				{
				}
				num = (short)1584660481;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(SmartKeyFobGraphicView.UnlockUpButtonTrkIsAcpEditableProperty);
			}
			set
			{
				short num = (short)336330752;
				short num2 = num;
				num = (short)1442505338;
				short num3 = num;
				num = (short)296739450;
				switch (num3 == num)
				{
				}
				num = (short)109510656;
				if (num != 0)
				{
				}
				num = (short)1653735425;
				if (num != 0)
				{
				}
				base.SetValue(SmartKeyFobGraphicView.UnlockUpButtonTrkIsAcpEditableProperty, value);
			}
		}

		// Token: 0x170005F5 RID: 1525
		// (get) Token: 0x06000CED RID: 3309 RVA: 0x000C1460 File Offset: 0x000BF660
		// (set) Token: 0x06000CEE RID: 3310 RVA: 0x000C151C File Offset: 0x000BF71C
		public string UnlockUpButtonTrkUIValue
		{
			get
			{
				short num = (short)1328414720;
				short num2 = num;
				num = (short)351931243;
				short num3 = num;
				num = (short)263654251;
				switch (num3 == num)
				{
				}
				num = (short)449183745;
				if (num != 0)
				{
				}
				num = (short)825556992;
				if (num != 0)
				{
				}
				return (string)base.GetValue(SmartKeyFobGraphicView.UnlockUpButtonTrkUIValueProperty);
			}
			set
			{
				short num = (short)924123136;
				short num2 = num;
				num = (short)219911195;
				short num3 = num;
				num = (short)1838388251;
				switch (num3 == num)
				{
				}
				num = (short)1341390849;
				if (num != 0)
				{
				}
				num = (short)1497104384;
				if (num != 0)
				{
				}
				base.SetValue(SmartKeyFobGraphicView.UnlockUpButtonTrkUIValueProperty, value);
			}
		}

		// Token: 0x170005F6 RID: 1526
		// (get) Token: 0x06000CEF RID: 3311 RVA: 0x000C15D0 File Offset: 0x000BF7D0
		// (set) Token: 0x06000CF0 RID: 3312 RVA: 0x000C1688 File Offset: 0x000BF888
		public AcpListField UnlockUpButtonTrkList
		{
			get
			{
				short num = (short)1568342016;
				short num2 = num;
				num = (short)2072592194;
				short num3 = num;
				num = (short)1288912706;
				switch (num3 == num)
				{
				}
				num = (short)2052259841;
				if (num != 0)
				{
				}
				num = (short)1164443648;
				if (num != 0)
				{
				}
				return (AcpListField)base.GetValue(SmartKeyFobGraphicView.UnlockUpButtonTrkListProperty);
			}
			set
			{
				short num = (short)463339520;
				short num2 = num;
				num = (short)2071051926;
				short num3 = num;
				num = (short)1616297622;
				switch (num3 == num)
				{
				}
				num = (short)1029439489;
				if (num != 0)
				{
				}
				num = (short)867368960;
				if (num != 0)
				{
				}
				base.SetValue(SmartKeyFobGraphicView.UnlockUpButtonTrkListProperty, value);
			}
		}

		// Token: 0x170005F7 RID: 1527
		// (get) Token: 0x06000CF1 RID: 3313 RVA: 0x000C1740 File Offset: 0x000BF940
		// (set) Token: 0x06000CF2 RID: 3314 RVA: 0x000C17F8 File Offset: 0x000BF9F8
		public bool UnlockDownButtonCnvIsAcpValid
		{
			get
			{
				short num = (short)145031168;
				short num2 = num;
				num = (short)2064449635;
				short num3 = num;
				num = (short)773324899;
				switch (num3 == num)
				{
				}
				num = (short)478216192;
				if (num != 0)
				{
				}
				num = (short)2076049409;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(SmartKeyFobGraphicView.UnlockDownButtonCnvIsAcpValidProperty);
			}
			set
			{
				short num = (short)565575680;
				short num2 = num;
				num = (short)1863016524;
				short num3 = num;
				num = (short)1146183756;
				switch (num3 == num)
				{
				}
				num = (short)74776576;
				if (num != 0)
				{
				}
				num = (short)862715905;
				if (num != 0)
				{
				}
				base.SetValue(SmartKeyFobGraphicView.UnlockDownButtonCnvIsAcpValidProperty, value);
			}
		}

		// Token: 0x170005F8 RID: 1528
		// (get) Token: 0x06000CF3 RID: 3315 RVA: 0x000C18B8 File Offset: 0x000BFAB8
		// (set) Token: 0x06000CF4 RID: 3316 RVA: 0x000C1970 File Offset: 0x000BFB70
		public bool UnlockDownButtonCnvIsAcpApplicable
		{
			get
			{
				short num = (short)1577882562;
				short num2 = num;
				num = (short)384865218;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1157955584;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)258473984;
				if (num != 0)
				{
				}
				num = (short)1800142849;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(SmartKeyFobGraphicView.UnlockDownButtonCnvIsAcpApplicableProperty);
			}
			set
			{
				short num = (short)682068401;
				short num2 = num;
				num = (short)681740721;
				switch (num2 == num)
				{
				default:
				{
					num = (short)339083264;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1178075136;
				if (num != 0)
				{
				}
				num = (short)116785153;
				if (num != 0)
				{
				}
				base.SetValue(SmartKeyFobGraphicView.UnlockDownButtonCnvIsAcpApplicableProperty, value);
			}
		}

		// Token: 0x170005F9 RID: 1529
		// (get) Token: 0x06000CF5 RID: 3317 RVA: 0x000C1A28 File Offset: 0x000BFC28
		// (set) Token: 0x06000CF6 RID: 3318 RVA: 0x000C1AE0 File Offset: 0x000BFCE0
		public bool UnlockDownButtonCnvIsAcpVisible
		{
			get
			{
				short num = (short)767426561;
				if (num != 0)
				{
				}
				num = (short)243335168;
				short num2 = num;
				num = (short)933245299;
				short num3 = num;
				num = (short)1567175027;
				switch (num3 == num)
				{
				}
				num = (short)527761408;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(SmartKeyFobGraphicView.UnlockDownButtonCnvIsAcpVisibleProperty);
			}
			set
			{
				short num = (short)93454337;
				if (num != 0)
				{
				}
				num = (short)1863122944;
				short num2 = num;
				num = (short)1588558096;
				short num3 = num;
				num = (short)1010399504;
				switch (num3 == num)
				{
				}
				num = (short)635305984;
				if (num != 0)
				{
				}
				base.SetValue(SmartKeyFobGraphicView.UnlockDownButtonCnvIsAcpVisibleProperty, value);
			}
		}

		// Token: 0x170005FA RID: 1530
		// (get) Token: 0x06000CF7 RID: 3319 RVA: 0x000C1B98 File Offset: 0x000BFD98
		// (set) Token: 0x06000CF8 RID: 3320 RVA: 0x000C1C50 File Offset: 0x000BFE50
		public bool UnlockDownButtonCnvIsAcpEditable
		{
			get
			{
				short num = (short)26845580;
				short num2 = num;
				num = (short)1539744140;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1568145408;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)55508993;
				if (num != 0)
				{
				}
				num = (short)1577713664;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(SmartKeyFobGraphicView.UnlockDownButtonCnvIsAcpEditableProperty);
			}
			set
			{
				short num = (short)1941267670;
				short num2 = num;
				num = (short)22897878;
				switch (num2 == num)
				{
				default:
				{
					num = (short)102039552;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1926561793;
				if (num != 0)
				{
				}
				num = (short)323682304;
				if (num != 0)
				{
				}
				base.SetValue(SmartKeyFobGraphicView.UnlockDownButtonCnvIsAcpEditableProperty, value);
			}
		}

		// Token: 0x170005FB RID: 1531
		// (get) Token: 0x06000CF9 RID: 3321 RVA: 0x000C1D08 File Offset: 0x000BFF08
		// (set) Token: 0x06000CFA RID: 3322 RVA: 0x000C1DC4 File Offset: 0x000BFFC4
		public string UnlockDownButtonCnvUIValue
		{
			get
			{
				short num = (short)1723097530;
				short num2 = num;
				num = (short)685072826;
				switch (num2 == num)
				{
				default:
				{
					num = (short)268107776;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1015676929;
				if (num != 0)
				{
				}
				num = (short)810876928;
				if (num != 0)
				{
				}
				return (string)base.GetValue(SmartKeyFobGraphicView.UnlockDownButtonCnvUIValueProperty);
			}
			set
			{
				short num = (short)414238167;
				short num2 = num;
				num = (short)51365335;
				switch (num2 == num)
				{
				default:
				{
					num = (short)980549632;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)270139393;
				if (num != 0)
				{
				}
				num = (short)1257635840;
				if (num != 0)
				{
				}
				base.SetValue(SmartKeyFobGraphicView.UnlockDownButtonCnvUIValueProperty, value);
			}
		}

		// Token: 0x170005FC RID: 1532
		// (get) Token: 0x06000CFB RID: 3323 RVA: 0x000C1E7C File Offset: 0x000C007C
		// (set) Token: 0x06000CFC RID: 3324 RVA: 0x000C1F38 File Offset: 0x000C0138
		public AcpListField UnlockDownButtonCnvList
		{
			get
			{
				short num = (short)2021880243;
				short num2 = num;
				num = (short)2092528051;
				switch (num2 == num)
				{
				default:
				{
					num = (short)901775360;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)35258369;
				if (num != 0)
				{
				}
				num = (short)16777216;
				if (num != 0)
				{
				}
				return (AcpListField)base.GetValue(SmartKeyFobGraphicView.UnlockDownButtonCnvListProperty);
			}
			set
			{
				short num = (short)1169817601;
				if (num != 0)
				{
				}
				num = (short)1794506752;
				short num2 = num;
				num = (short)1185969290;
				short num3 = num;
				num = (short)1410430090;
				switch (num3 == num)
				{
				}
				num = (short)880738304;
				if (num != 0)
				{
				}
				base.SetValue(SmartKeyFobGraphicView.UnlockDownButtonCnvListProperty, value);
			}
		}

		// Token: 0x170005FD RID: 1533
		// (get) Token: 0x06000CFD RID: 3325 RVA: 0x000C1FEC File Offset: 0x000C01EC
		// (set) Token: 0x06000CFE RID: 3326 RVA: 0x000C20A8 File Offset: 0x000C02A8
		public bool UnlockDownButtonTrkIsAcpValid
		{
			get
			{
				short num = (short)1351024641;
				if (num != 0)
				{
				}
				num = (short)1615659008;
				short num2 = num;
				num = (short)1980820382;
				short num3 = num;
				num = (short)1816193950;
				switch (num3 == num)
				{
				}
				num = (short)710475776;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(SmartKeyFobGraphicView.UnlockDownButtonTrkIsAcpValidProperty);
			}
			set
			{
				short num = (short)1750816475;
				short num2 = num;
				num = (short)1922389723;
				switch (num2 == num)
				{
				default:
				{
					num = (short)264175616;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)288489472;
				if (num != 0)
				{
				}
				num = (short)1806696449;
				if (num != 0)
				{
				}
				base.SetValue(SmartKeyFobGraphicView.UnlockDownButtonTrkIsAcpValidProperty, value);
			}
		}

		// Token: 0x170005FE RID: 1534
		// (get) Token: 0x06000CFF RID: 3327 RVA: 0x000C2164 File Offset: 0x000C0364
		// (set) Token: 0x06000D00 RID: 3328 RVA: 0x000C2220 File Offset: 0x000C0420
		public bool UnlockDownButtonTrkIsAcpApplicable
		{
			get
			{
				short num = (short)1694365323;
				short num2 = num;
				num = (short)1057945227;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1046413312;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2040791041;
				if (num != 0)
				{
				}
				num = (short)1021444096;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(SmartKeyFobGraphicView.UnlockDownButtonTrkIsAcpApplicableProperty);
			}
			set
			{
				short num = (short)1046725321;
				short num2 = num;
				num = (short)1707459273;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1201799168;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1047396352;
				if (num != 0)
				{
				}
				num = (short)1106706433;
				if (num != 0)
				{
				}
				base.SetValue(SmartKeyFobGraphicView.UnlockDownButtonTrkIsAcpApplicableProperty, value);
			}
		}

		// Token: 0x170005FF RID: 1535
		// (get) Token: 0x06000D01 RID: 3329 RVA: 0x000C22E0 File Offset: 0x000C04E0
		// (set) Token: 0x06000D02 RID: 3330 RVA: 0x000C2398 File Offset: 0x000C0598
		public bool UnlockDownButtonTrkIsAcpVisible
		{
			get
			{
				short num = (short)1821582139;
				short num2 = num;
				num = (short)418980667;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2019557376;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)753664001;
				if (num != 0)
				{
				}
				num = (short)1174732800;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(SmartKeyFobGraphicView.UnlockDownButtonTrkIsAcpVisibleProperty);
			}
			set
			{
				short num = (short)1757850688;
				short num2 = num;
				num = (short)2015472704;
				switch (num2 == num)
				{
				default:
				{
					num = (short)687341568;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1234042881;
				if (num != 0)
				{
				}
				num = (short)189464576;
				if (num != 0)
				{
				}
				base.SetValue(SmartKeyFobGraphicView.UnlockDownButtonTrkIsAcpVisibleProperty, value);
			}
		}

		// Token: 0x17000600 RID: 1536
		// (get) Token: 0x06000D03 RID: 3331 RVA: 0x000C2454 File Offset: 0x000C0654
		// (set) Token: 0x06000D04 RID: 3332 RVA: 0x000C2510 File Offset: 0x000C0710
		public bool UnlockDownButtonTrkIsAcpEditable
		{
			get
			{
				short num = (short)947843038;
				short num2 = num;
				num = (short)2123755486;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1270415360;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1402601473;
				if (num != 0)
				{
				}
				num = (short)1532231680;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(SmartKeyFobGraphicView.UnlockDownButtonTrkIsAcpEditableProperty);
			}
			set
			{
				short num = (short)133852388;
				short num2 = num;
				num = (short)1884777700;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1798045696;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1160839169;
				if (num != 0)
				{
				}
				num = (short)1083572224;
				if (num != 0)
				{
				}
				base.SetValue(SmartKeyFobGraphicView.UnlockDownButtonTrkIsAcpEditableProperty, value);
			}
		}

		// Token: 0x17000601 RID: 1537
		// (get) Token: 0x06000D05 RID: 3333 RVA: 0x000C25CC File Offset: 0x000C07CC
		// (set) Token: 0x06000D06 RID: 3334 RVA: 0x000C2688 File Offset: 0x000C0888
		public string UnlockDownButtonTrkUIValue
		{
			get
			{
				short num = (short)423174933;
				short num2 = num;
				num = (short)303637269;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1116274688;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1900019713;
				if (num != 0)
				{
				}
				num = (short)1231159296;
				if (num != 0)
				{
				}
				return (string)base.GetValue(SmartKeyFobGraphicView.UnlockDownButtonTrkUIValueProperty);
			}
			set
			{
				short num = (short)560307215;
				short num2 = num;
				num = (short)1101437967;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1831337984;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1447690241;
				if (num != 0)
				{
				}
				num = (short)1918042112;
				if (num != 0)
				{
				}
				base.SetValue(SmartKeyFobGraphicView.UnlockDownButtonTrkUIValueProperty, value);
			}
		}

		// Token: 0x17000602 RID: 1538
		// (get) Token: 0x06000D07 RID: 3335 RVA: 0x000C273C File Offset: 0x000C093C
		// (set) Token: 0x06000D08 RID: 3336 RVA: 0x000C27F8 File Offset: 0x000C09F8
		public AcpListField UnlockDownButtonTrkList
		{
			get
			{
				short num = (short)1472037715;
				short num2 = num;
				num = (short)494109523;
				switch (num2 == num)
				{
				default:
				{
					num = (short)685834240;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)635502592;
				if (num != 0)
				{
				}
				num = (short)1041170433;
				if (num != 0)
				{
				}
				return (AcpListField)base.GetValue(SmartKeyFobGraphicView.UnlockDownButtonTrkListProperty);
			}
			set
			{
				short num = (short)859759928;
				short num2 = num;
				num = (short)1634526520;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1066926080;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2031157248;
				if (num != 0)
				{
				}
				num = (short)2048393217;
				if (num != 0)
				{
				}
				base.SetValue(SmartKeyFobGraphicView.UnlockDownButtonTrkListProperty, value);
			}
		}

		// Token: 0x17000603 RID: 1539
		// (get) Token: 0x06000D09 RID: 3337 RVA: 0x000C28B0 File Offset: 0x000C0AB0
		// (set) Token: 0x06000D0A RID: 3338 RVA: 0x000C296C File Offset: 0x000C0B6C
		public bool UnlockTrunkButtonCnvIsAcpValid
		{
			get
			{
				short num = (short)2128692080;
				short num2 = num;
				num = (short)1321419632;
				switch (num2 == num)
				{
				default:
				{
					num = (short)766640128;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1290797057;
				if (num != 0)
				{
				}
				num = (short)11206656;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(SmartKeyFobGraphicView.UnlockTrunkButtonCnvIsAcpValidProperty);
			}
			set
			{
				short num = (short)253231105;
				if (num != 0)
				{
				}
				num = (short)1252196352;
				short num2 = num;
				num = (short)1162541761;
				short num3 = num;
				num = (short)2085944001;
				switch (num3 == num)
				{
				}
				num = (short)1638465536;
				if (num != 0)
				{
				}
				base.SetValue(SmartKeyFobGraphicView.UnlockTrunkButtonCnvIsAcpValidProperty, value);
			}
		}

		// Token: 0x17000604 RID: 1540
		// (get) Token: 0x06000D0B RID: 3339 RVA: 0x000C2A28 File Offset: 0x000C0C28
		// (set) Token: 0x06000D0C RID: 3340 RVA: 0x000C2AE0 File Offset: 0x000C0CE0
		public bool UnlockTrunkButtonCnvIsAcpApplicable
		{
			get
			{
				short num = (short)621281281;
				if (num != 0)
				{
				}
				num = (short)2006908928;
				short num2 = num;
				num = (short)603813581;
				short num3 = num;
				num = (short)188118733;
				switch (num3 == num)
				{
				}
				num = (short)1977483264;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(SmartKeyFobGraphicView.UnlockTrunkButtonCnvIsAcpApplicableProperty);
			}
			set
			{
				short num = (short)1748605729;
				short num2 = num;
				num = (short)608213793;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1165754368;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)641662977;
				if (num != 0)
				{
				}
				num = (short)1823539200;
				if (num != 0)
				{
				}
				base.SetValue(SmartKeyFobGraphicView.UnlockTrunkButtonCnvIsAcpApplicableProperty, value);
			}
		}

		// Token: 0x17000605 RID: 1541
		// (get) Token: 0x06000D0D RID: 3341 RVA: 0x000C2B9C File Offset: 0x000C0D9C
		// (set) Token: 0x06000D0E RID: 3342 RVA: 0x000C2C54 File Offset: 0x000C0E54
		public bool UnlockTrunkButtonCnvIsAcpVisible
		{
			get
			{
				short num = (short)1212148973;
				short num2 = num;
				num = (short)1957031149;
				switch (num2 == num)
				{
				default:
				{
					num = (short)485883904;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)588251137;
				if (num != 0)
				{
				}
				num = (short)112721920;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(SmartKeyFobGraphicView.UnlockTrunkButtonCnvIsAcpVisibleProperty);
			}
			set
			{
				short num = (short)1019252086;
				short num2 = num;
				num = (short)558206326;
				switch (num2 == num)
				{
				default:
				{
					num = (short)232652800;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1801453569;
				if (num != 0)
				{
				}
				num = (short)1032454144;
				if (num != 0)
				{
				}
				base.SetValue(SmartKeyFobGraphicView.UnlockTrunkButtonCnvIsAcpVisibleProperty, value);
			}
		}

		// Token: 0x17000606 RID: 1542
		// (get) Token: 0x06000D0F RID: 3343 RVA: 0x000C2D0C File Offset: 0x000C0F0C
		// (set) Token: 0x06000D10 RID: 3344 RVA: 0x000C2DC8 File Offset: 0x000C0FC8
		public bool UnlockTrunkButtonCnvIsAcpEditable
		{
			get
			{
				short num = (short)843579393;
				if (num != 0)
				{
				}
				num = (short)1924399104;
				short num2 = num;
				num = (short)1523779748;
				short num3 = num;
				num = (short)174393508;
				switch (num3 == num)
				{
				}
				num = (short)1217855488;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(SmartKeyFobGraphicView.UnlockTrunkButtonCnvIsAcpEditableProperty);
			}
			set
			{
				short num = (short)387776512;
				short num2 = num;
				num = (short)1077665991;
				short num3 = num;
				num = (short)197124295;
				switch (num3 == num)
				{
				}
				num = (short)914358273;
				if (num != 0)
				{
				}
				num = (short)1646329856;
				if (num != 0)
				{
				}
				base.SetValue(SmartKeyFobGraphicView.UnlockTrunkButtonCnvIsAcpEditableProperty, value);
			}
		}

		// Token: 0x17000607 RID: 1543
		// (get) Token: 0x06000D11 RID: 3345 RVA: 0x000C2E88 File Offset: 0x000C1088
		// (set) Token: 0x06000D12 RID: 3346 RVA: 0x000C2F40 File Offset: 0x000C1140
		public string UnlockTrunkButtonCnvUIValue
		{
			get
			{
				short num = (short)719323136;
				short num2 = num;
				num = (short)1982636222;
				short num3 = num;
				num = (short)2093785278;
				switch (num3 == num)
				{
				}
				num = (short)798687233;
				if (num != 0)
				{
				}
				num = (short)828899328;
				if (num != 0)
				{
				}
				return (string)base.GetValue(SmartKeyFobGraphicView.UnlockTrunkButtonCnvUIValueProperty);
			}
			set
			{
				short num = (short)590348288;
				short num2 = num;
				num = (short)2039696096;
				short num3 = num;
				num = (short)618416864;
				switch (num3 == num)
				{
				}
				num = (short)2027552769;
				if (num != 0)
				{
				}
				num = (short)2127888384;
				if (num != 0)
				{
				}
				base.SetValue(SmartKeyFobGraphicView.UnlockTrunkButtonCnvUIValueProperty, value);
			}
		}

		// Token: 0x17000608 RID: 1544
		// (get) Token: 0x06000D13 RID: 3347 RVA: 0x000C2FF4 File Offset: 0x000C11F4
		// (set) Token: 0x06000D14 RID: 3348 RVA: 0x000C30B0 File Offset: 0x000C12B0
		public AcpListField UnlockTrunkButtonCnvList
		{
			get
			{
				short num = (short)1494417408;
				short num2 = num;
				num = (short)1335134979;
				short num3 = num;
				num = (short)711035651;
				switch (num3 == num)
				{
				}
				num = (short)1657274368;
				if (num != 0)
				{
				}
				num = (short)87687169;
				if (num != 0)
				{
				}
				return (AcpListField)base.GetValue(SmartKeyFobGraphicView.UnlockTrunkButtonCnvListProperty);
			}
			set
			{
				short num = (short)601620480;
				short num2 = num;
				num = (short)1730513357;
				short num3 = num;
				num = (short)1771211213;
				switch (num3 == num)
				{
				}
				num = (short)1159331841;
				if (num != 0)
				{
				}
				num = (short)539099136;
				if (num != 0)
				{
				}
				base.SetValue(SmartKeyFobGraphicView.UnlockTrunkButtonCnvListProperty, value);
			}
		}

		// Token: 0x17000609 RID: 1545
		// (get) Token: 0x06000D15 RID: 3349 RVA: 0x000C316C File Offset: 0x000C136C
		// (set) Token: 0x06000D16 RID: 3350 RVA: 0x000C3224 File Offset: 0x000C1424
		public bool UnlockTrunkButtonTrkIsAcpValid
		{
			get
			{
				short num = (short)115015680;
				short num2 = num;
				num = (short)224356844;
				short num3 = num;
				num = (short)891775468;
				switch (num3 == num)
				{
				}
				num = (short)875364353;
				if (num != 0)
				{
				}
				num = (short)66125824;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(SmartKeyFobGraphicView.UnlockTrunkButtonTrkIsAcpValidProperty);
			}
			set
			{
				short num = (short)165609472;
				short num2 = num;
				num = (short)1532952577;
				if (num != 0)
				{
				}
				num = (short)26195916;
				short num3 = num;
				num = (short)601536460;
				switch (num3 == num)
				{
				}
				num = (short)2058485760;
				if (num != 0)
				{
				}
				base.SetValue(SmartKeyFobGraphicView.UnlockTrunkButtonTrkIsAcpValidProperty, value);
			}
		}

		// Token: 0x1700060A RID: 1546
		// (get) Token: 0x06000D17 RID: 3351 RVA: 0x000C32E0 File Offset: 0x000C14E0
		// (set) Token: 0x06000D18 RID: 3352 RVA: 0x000C339C File Offset: 0x000C159C
		public bool UnlockTrunkButtonTrkIsAcpApplicable
		{
			get
			{
				short num = (short)905248768;
				short num2 = num;
				num = (short)732071545;
				short num3 = num;
				num = (short)1693288057;
				switch (num3 == num)
				{
				}
				num = (short)1806303233;
				if (num != 0)
				{
				}
				num = (short)1840381952;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(SmartKeyFobGraphicView.UnlockTrunkButtonTrkIsAcpApplicableProperty);
			}
			set
			{
				short num = (short)1692663808;
				short num2 = num;
				num = (short)2106407680;
				short num3 = num;
				num = (short)1909996288;
				switch (num3 == num)
				{
				}
				num = (short)1207107585;
				if (num != 0)
				{
				}
				num = (short)359727104;
				if (num != 0)
				{
				}
				base.SetValue(SmartKeyFobGraphicView.UnlockTrunkButtonTrkIsAcpApplicableProperty, value);
			}
		}

		// Token: 0x1700060B RID: 1547
		// (get) Token: 0x06000D19 RID: 3353 RVA: 0x000C3458 File Offset: 0x000C1658
		// (set) Token: 0x06000D1A RID: 3354 RVA: 0x000C3514 File Offset: 0x000C1714
		public bool UnlockTrunkButtonTrkIsAcpVisible
		{
			get
			{
				short num = (short)1082851328;
				short num2 = num;
				num = (short)827969911;
				short num3 = num;
				num = (short)672977271;
				switch (num3 == num)
				{
				}
				num = (short)1475084288;
				if (num != 0)
				{
				}
				num = (short)1615790081;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(SmartKeyFobGraphicView.UnlockTrunkButtonTrkIsAcpVisibleProperty);
			}
			set
			{
				short num = (short)2084306944;
				short num2 = num;
				num = (short)1198538319;
				short num3 = num;
				num = (short)922238543;
				switch (num3 == num)
				{
				}
				num = (short)1543045120;
				if (num != 0)
				{
				}
				num = (short)243597313;
				if (num != 0)
				{
				}
				base.SetValue(SmartKeyFobGraphicView.UnlockTrunkButtonTrkIsAcpVisibleProperty, value);
			}
		}

		// Token: 0x1700060C RID: 1548
		// (get) Token: 0x06000D1B RID: 3355 RVA: 0x000C35CC File Offset: 0x000C17CC
		// (set) Token: 0x06000D1C RID: 3356 RVA: 0x000C3684 File Offset: 0x000C1884
		public bool UnlockTrunkButtonTrkIsAcpEditable
		{
			get
			{
				short num = (short)356122624;
				short num2 = num;
				num = (short)1163318774;
				short num3 = num;
				num = (short)1651365366;
				switch (num3 == num)
				{
				}
				num = (short)326565889;
				if (num != 0)
				{
				}
				num = (short)1681129472;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(SmartKeyFobGraphicView.UnlockTrunkButtonTrkIsAcpEditableProperty);
			}
			set
			{
				short num = (short)1236729856;
				short num2 = num;
				num = (short)2002132269;
				short num3 = num;
				num = (short)37690669;
				switch (num3 == num)
				{
				}
				num = (short)491454465;
				if (num != 0)
				{
				}
				num = (short)1187577856;
				if (num != 0)
				{
				}
				base.SetValue(SmartKeyFobGraphicView.UnlockTrunkButtonTrkIsAcpEditableProperty, value);
			}
		}

		// Token: 0x1700060D RID: 1549
		// (get) Token: 0x06000D1D RID: 3357 RVA: 0x000C373C File Offset: 0x000C193C
		// (set) Token: 0x06000D1E RID: 3358 RVA: 0x000C37F4 File Offset: 0x000C19F4
		public string UnlockTrunkButtonTrkUIValue
		{
			get
			{
				short num = (short)1978466304;
				short num2 = num;
				num = (short)474349569;
				if (num != 0)
				{
				}
				num = (short)1914417941;
				short num3 = num;
				num = (short)1658499861;
				switch (num3 == num)
				{
				}
				num = (short)491716608;
				if (num != 0)
				{
				}
				return (string)base.GetValue(SmartKeyFobGraphicView.UnlockTrunkButtonTrkUIValueProperty);
			}
			set
			{
				short num = (short)571342848;
				short num2 = num;
				num = (short)51838977;
				if (num != 0)
				{
				}
				num = (short)1788341307;
				short num3 = num;
				num = (short)1370811451;
				switch (num3 == num)
				{
				}
				num = (short)84803584;
				if (num != 0)
				{
				}
				base.SetValue(SmartKeyFobGraphicView.UnlockTrunkButtonTrkUIValueProperty, value);
			}
		}

		// Token: 0x1700060E RID: 1550
		// (get) Token: 0x06000D1F RID: 3359 RVA: 0x000C38A8 File Offset: 0x000C1AA8
		// (set) Token: 0x06000D20 RID: 3360 RVA: 0x000C3960 File Offset: 0x000C1B60
		public AcpListField UnlockTrunkButtonTrkList
		{
			get
			{
				short num = (short)462553088;
				short num2 = num;
				num = (short)977149239;
				short num3 = num;
				num = (short)586030391;
				switch (num3 == num)
				{
				}
				num = (short)1687552001;
				if (num != 0)
				{
				}
				num = (short)347144192;
				if (num != 0)
				{
				}
				return (AcpListField)base.GetValue(SmartKeyFobGraphicView.UnlockTrunkButtonTrkListProperty);
			}
			set
			{
				short num = (short)1467875328;
				short num2 = num;
				num = (short)415992436;
				short num3 = num;
				num = (short)127961716;
				switch (num3 == num)
				{
				}
				num = (short)1883504641;
				if (num != 0)
				{
				}
				num = (short)379322368;
				if (num != 0)
				{
				}
				base.SetValue(SmartKeyFobGraphicView.UnlockTrunkButtonTrkListProperty, value);
			}
		}

		// Token: 0x1700060F RID: 1551
		// (get) Token: 0x06000D21 RID: 3361 RVA: 0x000C3A18 File Offset: 0x000C1C18
		// (set) Token: 0x06000D22 RID: 3362 RVA: 0x000C3AD4 File Offset: 0x000C1CD4
		public bool AlarmButtonCnvIsAcpValid
		{
			get
			{
				short num = (short)1083047936;
				short num2 = num;
				num = (short)210269033;
				short num3 = num;
				num = (short)2026795881;
				switch (num3 == num)
				{
				}
				num = (short)1597046785;
				if (num != 0)
				{
				}
				num = (short)2116222976;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(SmartKeyFobGraphicView.AlarmButtonCnvIsAcpValidProperty);
			}
			set
			{
				short num = (short)1673396224;
				short num2 = num;
				num = (short)41943041;
				if (num != 0)
				{
				}
				num = (short)1266199773;
				short num3 = num;
				num = (short)1145744605;
				switch (num3 == num)
				{
				}
				num = (short)502398976;
				if (num != 0)
				{
				}
				base.SetValue(SmartKeyFobGraphicView.AlarmButtonCnvIsAcpValidProperty, value);
			}
		}

		// Token: 0x17000610 RID: 1552
		// (get) Token: 0x06000D23 RID: 3363 RVA: 0x000C3B90 File Offset: 0x000C1D90
		// (set) Token: 0x06000D24 RID: 3364 RVA: 0x000C3C48 File Offset: 0x000C1E48
		public bool AlarmButtonCnvIsAcpApplicable
		{
			get
			{
				short num = (short)1902837760;
				short num2 = num;
				num = (short)1884864319;
				short num3 = num;
				num = (short)1586544447;
				switch (num3 == num)
				{
				}
				num = (short)675545089;
				if (num != 0)
				{
				}
				num = (short)2021982208;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(SmartKeyFobGraphicView.AlarmButtonCnvIsAcpApplicableProperty);
			}
			set
			{
				short num = (short)1109590016;
				short num2 = num;
				num = (short)1011286017;
				if (num != 0)
				{
				}
				num = (short)1205034794;
				short num3 = num;
				num = (short)1336434474;
				switch (num3 == num)
				{
				}
				num = (short)773390336;
				if (num != 0)
				{
				}
				base.SetValue(SmartKeyFobGraphicView.AlarmButtonCnvIsAcpApplicableProperty, value);
			}
		}

		// Token: 0x17000611 RID: 1553
		// (get) Token: 0x06000D25 RID: 3365 RVA: 0x000C3D04 File Offset: 0x000C1F04
		// (set) Token: 0x06000D26 RID: 3366 RVA: 0x000C3DBC File Offset: 0x000C1FBC
		public bool AlarmButtonCnvIsAcpVisible
		{
			get
			{
				short num = (short)1526398976;
				short num2 = num;
				num = (short)672375868;
				short num3 = num;
				num = (short)556311612;
				switch (num3 == num)
				{
				}
				num = (short)1425539072;
				if (num != 0)
				{
				}
				num = (short)1740701697;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(SmartKeyFobGraphicView.AlarmButtonCnvIsAcpVisibleProperty);
			}
			set
			{
				short num = (short)1513750528;
				short num2 = num;
				num = (short)1958138461;
				short num3 = num;
				num = (short)1163907677;
				switch (num3 == num)
				{
				}
				num = (short)1015087105;
				if (num != 0)
				{
				}
				num = (short)595591168;
				if (num != 0)
				{
				}
				base.SetValue(SmartKeyFobGraphicView.AlarmButtonCnvIsAcpVisibleProperty, value);
			}
		}

		// Token: 0x17000612 RID: 1554
		// (get) Token: 0x06000D27 RID: 3367 RVA: 0x000C3E74 File Offset: 0x000C2074
		// (set) Token: 0x06000D28 RID: 3368 RVA: 0x000C3F30 File Offset: 0x000C2130
		public bool AlarmButtonCnvIsAcpEditable
		{
			get
			{
				short num = (short)2090926080;
				short num2 = num;
				num = (short)700029824;
				short num3 = num;
				num = (short)602971008;
				switch (num3 == num)
				{
				}
				num = (short)1429078016;
				if (num != 0)
				{
				}
				num = (short)166395905;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(SmartKeyFobGraphicView.AlarmButtonCnvIsAcpEditableProperty);
			}
			set
			{
				short num = (short)1552285696;
				short num2 = num;
				num = (short)1411736659;
				short num3 = num;
				num = (short)507077715;
				switch (num3 == num)
				{
				}
				num = (short)1712979969;
				if (num != 0)
				{
				}
				num = (short)61865984;
				if (num != 0)
				{
				}
				base.SetValue(SmartKeyFobGraphicView.AlarmButtonCnvIsAcpEditableProperty, value);
			}
		}

		// Token: 0x17000613 RID: 1555
		// (get) Token: 0x06000D29 RID: 3369 RVA: 0x000C3FEC File Offset: 0x000C21EC
		// (set) Token: 0x06000D2A RID: 3370 RVA: 0x000C40A4 File Offset: 0x000C22A4
		public string AlarmButtonCnvUIValue
		{
			get
			{
				short num = (short)17432576;
				short num2 = num;
				num = (short)750977025;
				if (num != 0)
				{
				}
				num = (short)1728175353;
				short num3 = num;
				num = (short)1763958009;
				switch (num3 == num)
				{
				}
				num = (short)414973952;
				if (num != 0)
				{
				}
				return (string)base.GetValue(SmartKeyFobGraphicView.AlarmButtonCnvUIValueProperty);
			}
			set
			{
				short num = (short)1153171456;
				short num2 = num;
				num = (short)1425014785;
				if (num != 0)
				{
				}
				num = (short)1537257098;
				short num3 = num;
				num = (short)2140778122;
				switch (num3 == num)
				{
				}
				num = (short)257622016;
				if (num != 0)
				{
				}
				base.SetValue(SmartKeyFobGraphicView.AlarmButtonCnvUIValueProperty, value);
			}
		}

		// Token: 0x17000614 RID: 1556
		// (get) Token: 0x06000D2B RID: 3371 RVA: 0x000C415C File Offset: 0x000C235C
		// (set) Token: 0x06000D2C RID: 3372 RVA: 0x000C4218 File Offset: 0x000C2418
		public AcpListField AlarmButtonCnvList
		{
			get
			{
				short num = (short)113770496;
				short num2 = num;
				num = (short)992280577;
				if (num != 0)
				{
				}
				num = (short)970278464;
				short num3 = num;
				num = (short)1964262976;
				switch (num3 == num)
				{
				}
				num = (short)256638976;
				if (num != 0)
				{
				}
				return (AcpListField)base.GetValue(SmartKeyFobGraphicView.AlarmButtonCnvListProperty);
			}
			set
			{
				short num = (short)1340538880;
				short num2 = num;
				num = (short)1755971585;
				if (num != 0)
				{
				}
				num = (short)465712818;
				short num3 = num;
				num = (short)1312569010;
				switch (num3 == num)
				{
				}
				num = (short)615120896;
				if (num != 0)
				{
				}
				base.SetValue(SmartKeyFobGraphicView.AlarmButtonCnvListProperty, value);
			}
		}

		// Token: 0x17000615 RID: 1557
		// (get) Token: 0x06000D2D RID: 3373 RVA: 0x000C42D0 File Offset: 0x000C24D0
		// (set) Token: 0x06000D2E RID: 3374 RVA: 0x000C4388 File Offset: 0x000C2588
		public bool AlarmButtonTrkIsAcpValid
		{
			get
			{
				short num = (short)505413632;
				short num2 = num;
				num = (short)123077186;
				short num3 = num;
				num = (short)950600258;
				switch (num3 == num)
				{
				}
				num = (short)305790976;
				if (num != 0)
				{
				}
				num = (short)2074673153;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(SmartKeyFobGraphicView.AlarmButtonTrkIsAcpValidProperty);
			}
			set
			{
				short num = (short)1727070208;
				short num2 = num;
				num = (short)1657669226;
				short num3 = num;
				num = (short)1909524074;
				switch (num3 == num)
				{
				}
				num = (short)2025324544;
				if (num != 0)
				{
				}
				num = (short)1776025601;
				if (num != 0)
				{
				}
				base.SetValue(SmartKeyFobGraphicView.AlarmButtonTrkIsAcpValidProperty, value);
			}
		}

		// Token: 0x17000616 RID: 1558
		// (get) Token: 0x06000D2F RID: 3375 RVA: 0x000C4440 File Offset: 0x000C2640
		// (set) Token: 0x06000D30 RID: 3376 RVA: 0x000C44F8 File Offset: 0x000C26F8
		public bool AlarmButtonTrkIsAcpApplicable
		{
			get
			{
				short num = (short)565248000;
				short num2 = num;
				num = (short)1984888833;
				if (num != 0)
				{
				}
				num = (short)1398765545;
				short num3 = num;
				num = (short)461141993;
				switch (num3 == num)
				{
				}
				num = (short)1448935424;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(SmartKeyFobGraphicView.AlarmButtonTrkIsAcpApplicableProperty);
			}
			set
			{
				short num = (short)415301632;
				short num2 = num;
				num = (short)138859588;
				short num3 = num;
				num = (short)349426756;
				switch (num3 == num)
				{
				}
				num = (short)316669952;
				if (num != 0)
				{
				}
				num = (short)1381761025;
				if (num != 0)
				{
				}
				base.SetValue(SmartKeyFobGraphicView.AlarmButtonTrkIsAcpApplicableProperty, value);
			}
		}

		// Token: 0x17000617 RID: 1559
		// (get) Token: 0x06000D31 RID: 3377 RVA: 0x000C45B4 File Offset: 0x000C27B4
		// (set) Token: 0x06000D32 RID: 3378 RVA: 0x000C466C File Offset: 0x000C286C
		public bool AlarmButtonTrkIsAcpVisible
		{
			get
			{
				short num = (short)948436992;
				short num2 = num;
				num = (short)1858714931;
				short num3 = num;
				num = (short)1714011443;
				switch (num3 == num)
				{
				}
				num = (short)653721601;
				if (num != 0)
				{
				}
				num = (short)1493565440;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(SmartKeyFobGraphicView.AlarmButtonTrkIsAcpVisibleProperty);
			}
			set
			{
				short num = (short)1814822912;
				short num2 = num;
				num = (short)1634504939;
				short num3 = num;
				num = (short)1018925291;
				switch (num3 == num)
				{
				}
				num = (short)1242431489;
				if (num != 0)
				{
				}
				num = (short)973340672;
				if (num != 0)
				{
				}
				base.SetValue(SmartKeyFobGraphicView.AlarmButtonTrkIsAcpVisibleProperty, value);
			}
		}

		// Token: 0x17000618 RID: 1560
		// (get) Token: 0x06000D33 RID: 3379 RVA: 0x000C4728 File Offset: 0x000C2928
		// (set) Token: 0x06000D34 RID: 3380 RVA: 0x000C47E0 File Offset: 0x000C29E0
		public bool AlarmButtonTrkIsAcpEditable
		{
			get
			{
				short num = (short)1409744896;
				short num2 = num;
				num = (short)1756025804;
				short num3 = num;
				num = (short)921686988;
				switch (num3 == num)
				{
				}
				num = (short)998375424;
				if (num != 0)
				{
				}
				num = (short)1065680897;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(SmartKeyFobGraphicView.AlarmButtonTrkIsAcpEditableProperty);
			}
			set
			{
				short num = (short)1497235456;
				short num2 = num;
				num = (short)396206270;
				short num3 = num;
				num = (short)1874567358;
				switch (num3 == num)
				{
				}
				num = (short)367853569;
				if (num != 0)
				{
				}
				num = (short)1970733056;
				if (num != 0)
				{
				}
				base.SetValue(SmartKeyFobGraphicView.AlarmButtonTrkIsAcpEditableProperty, value);
			}
		}

		// Token: 0x17000619 RID: 1561
		// (get) Token: 0x06000D35 RID: 3381 RVA: 0x000C489C File Offset: 0x000C2A9C
		// (set) Token: 0x06000D36 RID: 3382 RVA: 0x000C4954 File Offset: 0x000C2B54
		public string AlarmButtonTrkUIValue
		{
			get
			{
				short num = (short)467075072;
				short num2 = num;
				num = (short)1128057815;
				short num3 = num;
				num = (short)781306839;
				switch (num3 == num)
				{
				}
				num = (short)777256960;
				if (num != 0)
				{
				}
				num = (short)1340801025;
				if (num != 0)
				{
				}
				return (string)base.GetValue(SmartKeyFobGraphicView.AlarmButtonTrkUIValueProperty);
			}
			set
			{
				short num = (short)1072365568;
				short num2 = num;
				num = (short)341339325;
				short num3 = num;
				num = (short)1278373053;
				switch (num3 == num)
				{
				}
				num = (short)1112604673;
				if (num != 0)
				{
				}
				num = (short)1380450304;
				if (num != 0)
				{
				}
				base.SetValue(SmartKeyFobGraphicView.AlarmButtonTrkUIValueProperty, value);
			}
		}

		// Token: 0x1700061A RID: 1562
		// (get) Token: 0x06000D37 RID: 3383 RVA: 0x000C4A0C File Offset: 0x000C2C0C
		// (set) Token: 0x06000D38 RID: 3384 RVA: 0x000C4AC8 File Offset: 0x000C2CC8
		public AcpListField AlarmButtonTrkList
		{
			get
			{
				short num = (short)516292608;
				short num2 = num;
				num = (short)608655580;
				short num3 = num;
				num = (short)1923963100;
				switch (num3 == num)
				{
				}
				num = (short)945750017;
				if (num != 0)
				{
				}
				num = (short)1808334848;
				if (num != 0)
				{
				}
				return (AcpListField)base.GetValue(SmartKeyFobGraphicView.AlarmButtonTrkListProperty);
			}
			set
			{
				short num = (short)208994304;
				short num2 = num;
				num = (short)1379036014;
				short num3 = num;
				num = (short)901868398;
				switch (num3 == num)
				{
				}
				num = (short)868155393;
				if (num != 0)
				{
				}
				num = (short)1858207744;
				if (num != 0)
				{
				}
				base.SetValue(SmartKeyFobGraphicView.AlarmButtonTrkListProperty, value);
			}
		}

		// Token: 0x06000D3B RID: 3387 RVA: 0x000C5A9C File Offset: 0x000C3C9C
		// Note: this type is marked as 'beforefieldinit'.
		static SmartKeyFobGraphicView()
		{
			int a_ = 7;
			short num = (short)1082064896;
			short num2 = num;
			num = (short)796171116;
			short num3 = num;
			num = (short)1021025132;
			switch (num3 == num)
			{
			}
			num = (short)1366360065;
			if (num != 0)
			{
			}
			num = (short)1159528448;
			if (num != 0)
			{
			}
			SmartKeyFobGraphicView.LockUpButtonCnvIsAcpValidProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("縱嬳唵匷漹䰻簽㔿㙁ぃ⥅♇ॉ≋㡍᥏⅑ᕓ㕕⡗ౙ㵛㉝य़١", a_), typeof(bool), typeof(SmartKeyFobGraphicView));
			SmartKeyFobGraphicView.LockUpButtonCnvIsAcpApplicableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("縱嬳唵匷漹䰻簽㔿㙁ぃ⥅♇ॉ≋㡍᥏⅑ᕓ㕕⡗᭙ⱛ⹝౟ୡݣݥ੧٩५", a_), typeof(bool), typeof(SmartKeyFobGraphicView));
			SmartKeyFobGraphicView.LockUpButtonCnvIsAcpVisibleProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("縱嬳唵匷漹䰻簽㔿㙁ぃ⥅♇ॉ≋㡍᥏⅑ᕓ㕕⡗ౙ㕛ⵝय़aࡣͥ", a_), typeof(bool), typeof(SmartKeyFobGraphicView));
			SmartKeyFobGraphicView.LockUpButtonCnvIsAcpEditableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("縱嬳唵匷漹䰻簽㔿㙁ぃ⥅♇ॉ≋㡍᥏⅑ᕓ㕕⡗Ὑ㡛㝝ᑟ͡٣੥൧", a_), typeof(bool), typeof(SmartKeyFobGraphicView));
			SmartKeyFobGraphicView.LockUpButtonCnvUIValueProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("縱嬳唵匷漹䰻簽㔿㙁ぃ⥅♇ॉ≋㡍Տ᭑ɓ㝕㑗⽙㥛", a_), typeof(string), typeof(SmartKeyFobGraphicView));
			SmartKeyFobGraphicView.LockUpButtonCnvListProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("縱嬳唵匷漹䰻簽㔿㙁ぃ⥅♇ॉ≋㡍ᱏ㭑❓≕", a_), typeof(AcpListField), typeof(SmartKeyFobGraphicView));
			SmartKeyFobGraphicView.LockUpButtonTrkIsAcpValidProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("縱嬳唵匷漹䰻簽㔿㙁ぃ⥅♇ṉ㹋╍᥏⅑ᕓ㕕⡗ౙ㵛㉝य़١", a_), typeof(bool), typeof(SmartKeyFobGraphicView));
			SmartKeyFobGraphicView.LockUpButtonTrkIsAcpApplicableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("縱嬳唵匷漹䰻簽㔿㙁ぃ⥅♇ṉ㹋╍᥏⅑ᕓ㕕⡗᭙ⱛ⹝౟ୡݣݥ੧٩५", a_), typeof(bool), typeof(SmartKeyFobGraphicView));
			SmartKeyFobGraphicView.LockUpButtonTrkIsAcpVisibleProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("縱嬳唵匷漹䰻簽㔿㙁ぃ⥅♇ṉ㹋╍᥏⅑ᕓ㕕⡗ౙ㕛ⵝय़aࡣͥ", a_), typeof(bool), typeof(SmartKeyFobGraphicView));
			SmartKeyFobGraphicView.LockUpButtonTrkIsAcpEditableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("縱嬳唵匷漹䰻簽㔿㙁ぃ⥅♇ṉ㹋╍᥏⅑ᕓ㕕⡗Ὑ㡛㝝ᑟ͡٣੥൧", a_), typeof(bool), typeof(SmartKeyFobGraphicView));
			SmartKeyFobGraphicView.LockUpButtonTrkUIValueProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("縱嬳唵匷漹䰻簽㔿㙁ぃ⥅♇ṉ㹋╍Տ᭑ɓ㝕㑗⽙㥛", a_), typeof(string), typeof(SmartKeyFobGraphicView));
			SmartKeyFobGraphicView.LockUpButtonTrkListProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("縱嬳唵匷漹䰻簽㔿㙁ぃ⥅♇ṉ㹋╍ᱏ㭑❓≕", a_), typeof(AcpListField), typeof(SmartKeyFobGraphicView));
			SmartKeyFobGraphicView.LockDownButtonCnvIsAcpValidProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("縱嬳唵匷縹医䤽⸿Aㅃ㉅㱇╉≋്㹏⑑ᵓ╕ᥗ㥙ⱛ࡝ş๡ൣɥ", a_), typeof(bool), typeof(SmartKeyFobGraphicView));
			SmartKeyFobGraphicView.LockDownButtonCnvIsAcpApplicableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("縱嬳唵匷縹医䤽⸿Aㅃ㉅㱇╉≋്㹏⑑ᵓ╕ᥗ㥙ⱛὝၟቡࡣཥ୧୩๫ɭᕯ", a_), typeof(bool), typeof(SmartKeyFobGraphicView));
			SmartKeyFobGraphicView.LockDownButtonCnvIsAcpVisibleProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("縱嬳唵匷縹医䤽⸿Aㅃ㉅㱇╉≋്㹏⑑ᵓ╕ᥗ㥙ⱛ࡝य़ᅡൣѥѧཀྵ", a_), typeof(bool), typeof(SmartKeyFobGraphicView));
			SmartKeyFobGraphicView.LockDownButtonCnvIsAcpEditableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("縱嬳唵匷縹医䤽⸿Aㅃ㉅㱇╉≋്㹏⑑ᵓ╕ᥗ㥙ⱛ᭝џୡၣݥ੧٩५", a_), typeof(bool), typeof(SmartKeyFobGraphicView));
			SmartKeyFobGraphicView.LockDownButtonCnvUIValueProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("縱嬳唵匷縹医䤽⸿Aㅃ㉅㱇╉≋്㹏⑑œὕ๗㭙せ⭝՟", a_), typeof(string), typeof(SmartKeyFobGraphicView));
			SmartKeyFobGraphicView.LockDownButtonCnvListProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("縱嬳唵匷縹医䤽⸿Aㅃ㉅㱇╉≋്㹏⑑ᡓ㽕⭗⹙", a_), typeof(AcpListField), typeof(SmartKeyFobGraphicView));
			SmartKeyFobGraphicView.LockDownButtonTrkIsAcpValidProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("縱嬳唵匷縹医䤽⸿Aㅃ㉅㱇╉≋ᩍ≏㥑ᵓ╕ᥗ㥙ⱛ࡝ş๡ൣɥ", a_), typeof(bool), typeof(SmartKeyFobGraphicView));
			SmartKeyFobGraphicView.LockDownButtonTrkIsAcpApplicableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("縱嬳唵匷縹医䤽⸿Aㅃ㉅㱇╉≋ᩍ≏㥑ᵓ╕ᥗ㥙ⱛὝၟቡࡣཥ୧୩๫ɭᕯ", a_), typeof(bool), typeof(SmartKeyFobGraphicView));
			SmartKeyFobGraphicView.LockDownButtonTrkIsAcpVisibleProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("縱嬳唵匷縹医䤽⸿Aㅃ㉅㱇╉≋ᩍ≏㥑ᵓ╕ᥗ㥙ⱛ࡝य़ᅡൣѥѧཀྵ", a_), typeof(bool), typeof(SmartKeyFobGraphicView));
			SmartKeyFobGraphicView.LockDownButtonTrkIsAcpEditableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("縱嬳唵匷縹医䤽⸿Aㅃ㉅㱇╉≋ᩍ≏㥑ᵓ╕ᥗ㥙ⱛ᭝џୡၣݥ੧٩५", a_), typeof(bool), typeof(SmartKeyFobGraphicView));
			SmartKeyFobGraphicView.LockDownButtonTrkUIValueProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("縱嬳唵匷縹医䤽⸿Aㅃ㉅㱇╉≋ᩍ≏㥑œὕ๗㭙せ⭝՟", a_), typeof(string), typeof(SmartKeyFobGraphicView));
			SmartKeyFobGraphicView.LockDownButtonTrkListProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("縱嬳唵匷縹医䤽⸿Aㅃ㉅㱇╉≋ᩍ≏㥑ᡓ㽕⭗⹙", a_), typeof(AcpListField), typeof(SmartKeyFobGraphicView));
			SmartKeyFobGraphicView.UnlockUpButtonCnvIsAcpValidProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("朱娳娵圷夹圻欽〿Aㅃ㉅㱇╉≋്㹏⑑ᵓ╕ᥗ㥙ⱛ࡝ş๡ൣɥ", a_), typeof(bool), typeof(SmartKeyFobGraphicView));
			SmartKeyFobGraphicView.UnlockUpButtonCnvIsAcpApplicableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("朱娳娵圷夹圻欽〿Aㅃ㉅㱇╉≋്㹏⑑ᵓ╕ᥗ㥙ⱛὝၟቡࡣཥ୧୩๫ɭᕯ", a_), typeof(bool), typeof(SmartKeyFobGraphicView));
			SmartKeyFobGraphicView.UnlockUpButtonCnvIsAcpVisibleProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("朱娳娵圷夹圻欽〿Aㅃ㉅㱇╉≋്㹏⑑ᵓ╕ᥗ㥙ⱛ࡝य़ᅡൣѥѧཀྵ", a_), typeof(bool), typeof(SmartKeyFobGraphicView));
			SmartKeyFobGraphicView.UnlockUpButtonCnvIsAcpEditableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("朱娳娵圷夹圻欽〿Aㅃ㉅㱇╉≋്㹏⑑ᵓ╕ᥗ㥙ⱛ᭝џୡၣݥ੧٩५", a_), typeof(bool), typeof(SmartKeyFobGraphicView));
			SmartKeyFobGraphicView.UnlockUpButtonCnvUIValueProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("朱娳娵圷夹圻欽〿Aㅃ㉅㱇╉≋്㹏⑑œὕ๗㭙せ⭝՟", a_), typeof(string), typeof(SmartKeyFobGraphicView));
			SmartKeyFobGraphicView.UnlockUpButtonCnvListProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("朱娳娵圷夹圻欽〿Aㅃ㉅㱇╉≋്㹏⑑ᡓ㽕⭗⹙", a_), typeof(AcpListField), typeof(SmartKeyFobGraphicView));
			SmartKeyFobGraphicView.UnlockUpButtonTrkIsAcpValidProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("朱娳娵圷夹圻欽〿Aㅃ㉅㱇╉≋ᩍ≏㥑ᵓ╕ᥗ㥙ⱛ࡝ş๡ൣɥ", a_), typeof(bool), typeof(SmartKeyFobGraphicView));
			SmartKeyFobGraphicView.UnlockUpButtonTrkIsAcpApplicableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("朱娳娵圷夹圻欽〿Aㅃ㉅㱇╉≋ᩍ≏㥑ᵓ╕ᥗ㥙ⱛὝၟቡࡣཥ୧୩๫ɭᕯ", a_), typeof(bool), typeof(SmartKeyFobGraphicView));
			SmartKeyFobGraphicView.UnlockUpButtonTrkIsAcpVisibleProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("朱娳娵圷夹圻欽〿Aㅃ㉅㱇╉≋ᩍ≏㥑ᵓ╕ᥗ㥙ⱛ࡝य़ᅡൣѥѧཀྵ", a_), typeof(bool), typeof(SmartKeyFobGraphicView));
			SmartKeyFobGraphicView.UnlockUpButtonTrkIsAcpEditableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("朱娳娵圷夹圻欽〿Aㅃ㉅㱇╉≋ᩍ≏㥑ᵓ╕ᥗ㥙ⱛ᭝џୡၣݥ੧٩५", a_), typeof(bool), typeof(SmartKeyFobGraphicView));
			SmartKeyFobGraphicView.UnlockUpButtonTrkUIValueProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("朱娳娵圷夹圻欽〿Aㅃ㉅㱇╉≋ᩍ≏㥑œὕ๗㭙せ⭝՟", a_), typeof(string), typeof(SmartKeyFobGraphicView));
			SmartKeyFobGraphicView.UnlockUpButtonTrkListProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("朱娳娵圷夹圻欽〿Aㅃ㉅㱇╉≋ᩍ≏㥑ᡓ㽕⭗⹙", a_), typeof(AcpListField), typeof(SmartKeyFobGraphicView));
			SmartKeyFobGraphicView.UnlockDownButtonCnvIsAcpValidProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("朱娳娵圷夹圻稽⼿㕁⩃х㵇㹉㡋⅍㹏ᅑ㩓⁕ᅗ⥙ᵛ㵝ၟ㑡գ੥ŧ๩", a_), typeof(bool), typeof(SmartKeyFobGraphicView));
			SmartKeyFobGraphicView.UnlockDownButtonCnvIsAcpApplicableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("朱娳娵圷夹圻稽⼿㕁⩃х㵇㹉㡋⅍㹏ᅑ㩓⁕ᅗ⥙ᵛ㵝ၟ⍡ᑣᙥѧͩཫ཭ቯṱᅳ", a_), typeof(bool), typeof(SmartKeyFobGraphicView));
			SmartKeyFobGraphicView.UnlockDownButtonCnvIsAcpVisibleProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("朱娳娵圷夹圻稽⼿㕁⩃х㵇㹉㡋⅍㹏ᅑ㩓⁕ᅗ⥙ᵛ㵝ၟ㑡ൣᕥŧࡩk୭", a_), typeof(bool), typeof(SmartKeyFobGraphicView));
			SmartKeyFobGraphicView.UnlockDownButtonCnvIsAcpEditableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("朱娳娵圷夹圻稽⼿㕁⩃х㵇㹉㡋⅍㹏ᅑ㩓⁕ᅗ⥙ᵛ㵝ၟ❡cཥᱧ୩๫ɭᕯ", a_), typeof(bool), typeof(SmartKeyFobGraphicView));
			SmartKeyFobGraphicView.UnlockDownButtonCnvUIValueProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("朱娳娵圷夹圻稽⼿㕁⩃х㵇㹉㡋⅍㹏ᅑ㩓⁕ൗፙਜ਼㽝౟ᝡţ", a_), typeof(string), typeof(SmartKeyFobGraphicView));
			SmartKeyFobGraphicView.UnlockDownButtonCnvListProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("朱娳娵圷夹圻稽⼿㕁⩃х㵇㹉㡋⅍㹏ᅑ㩓⁕ᑗ㍙⽛⩝", a_), typeof(AcpListField), typeof(SmartKeyFobGraphicView));
			SmartKeyFobGraphicView.UnlockDownButtonTrkIsAcpValidProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("朱娳娵圷夹圻稽⼿㕁⩃х㵇㹉㡋⅍㹏ّ♓㵕ᅗ⥙ᵛ㵝ၟ㑡գ੥ŧ๩", a_), typeof(bool), typeof(SmartKeyFobGraphicView));
			SmartKeyFobGraphicView.UnlockDownButtonTrkIsAcpApplicableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("朱娳娵圷夹圻稽⼿㕁⩃х㵇㹉㡋⅍㹏ّ♓㵕ᅗ⥙ᵛ㵝ၟ⍡ᑣᙥѧͩཫ཭ቯṱᅳ", a_), typeof(bool), typeof(SmartKeyFobGraphicView));
			SmartKeyFobGraphicView.UnlockDownButtonTrkIsAcpVisibleProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("朱娳娵圷夹圻稽⼿㕁⩃х㵇㹉㡋⅍㹏ّ♓㵕ᅗ⥙ᵛ㵝ၟ㑡ൣᕥŧࡩk୭", a_), typeof(bool), typeof(SmartKeyFobGraphicView));
			SmartKeyFobGraphicView.UnlockDownButtonTrkIsAcpEditableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("朱娳娵圷夹圻稽⼿㕁⩃х㵇㹉㡋⅍㹏ّ♓㵕ᅗ⥙ᵛ㵝ၟ❡cཥᱧ୩๫ɭᕯ", a_), typeof(bool), typeof(SmartKeyFobGraphicView));
			SmartKeyFobGraphicView.UnlockDownButtonTrkUIValueProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("朱娳娵圷夹圻稽⼿㕁⩃х㵇㹉㡋⅍㹏ّ♓㵕ൗፙਜ਼㽝౟ᝡţ", a_), typeof(string), typeof(SmartKeyFobGraphicView));
			SmartKeyFobGraphicView.UnlockDownButtonTrkListProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("朱娳娵圷夹圻稽⼿㕁⩃х㵇㹉㡋⅍㹏ّ♓㵕ᑗ㍙⽛⩝", a_), typeof(AcpListField), typeof(SmartKeyFobGraphicView));
			SmartKeyFobGraphicView.UnlockTrunkButtonCnvIsAcpValidProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("朱娳娵圷夹圻樽㈿㝁⩃ⵅੇ㽉㡋㩍㽏㱑ᝓ㡕⹗ፙ⽛Ὕ͟ቡ㉣ݥѧͩ࡫", a_), typeof(bool), typeof(SmartKeyFobGraphicView));
			SmartKeyFobGraphicView.UnlockTrunkButtonCnvIsAcpApplicableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("朱娳娵圷夹圻樽㈿㝁⩃ⵅੇ㽉㡋㩍㽏㱑ᝓ㡕⹗ፙ⽛Ὕ͟ቡ╣ᙥᡧ٩ի൭ᅯၱᡳ፵", a_), typeof(bool), typeof(SmartKeyFobGraphicView));
			SmartKeyFobGraphicView.UnlockTrunkButtonCnvIsAcpVisibleProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("朱娳娵圷夹圻樽㈿㝁⩃ⵅੇ㽉㡋㩍㽏㱑ᝓ㡕⹗ፙ⽛Ὕ͟ቡ㉣ཥ᭧ͩ๫ɭᕯ", a_), typeof(bool), typeof(SmartKeyFobGraphicView));
			SmartKeyFobGraphicView.UnlockTrunkButtonCnvIsAcpEditableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("朱娳娵圷夹圻樽㈿㝁⩃ⵅੇ㽉㡋㩍㽏㱑ᝓ㡕⹗ፙ⽛Ὕ͟ቡⅣɥŧṩ൫౭ᱯ᝱", a_), typeof(bool), typeof(SmartKeyFobGraphicView));
			SmartKeyFobGraphicView.UnlockTrunkButtonCnvUIValueProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("朱娳娵圷夹圻樽㈿㝁⩃ⵅੇ㽉㡋㩍㽏㱑ᝓ㡕⹗ཙᕛ࡝ş๡ᅣͥ", a_), typeof(string), typeof(SmartKeyFobGraphicView));
			SmartKeyFobGraphicView.UnlockTrunkButtonCnvListProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("朱娳娵圷夹圻樽㈿㝁⩃ⵅੇ㽉㡋㩍㽏㱑ᝓ㡕⹗ᙙ㕛ⵝᑟ", a_), typeof(AcpListField), typeof(SmartKeyFobGraphicView));
			SmartKeyFobGraphicView.UnlockTrunkButtonTrkIsAcpValidProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("朱娳娵圷夹圻樽㈿㝁⩃ⵅੇ㽉㡋㩍㽏㱑S⑕㍗ፙ⽛Ὕ͟ቡ㉣ݥѧͩ࡫", a_), typeof(bool), typeof(SmartKeyFobGraphicView));
			SmartKeyFobGraphicView.UnlockTrunkButtonTrkIsAcpApplicableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("朱娳娵圷夹圻樽㈿㝁⩃ⵅੇ㽉㡋㩍㽏㱑S⑕㍗ፙ⽛Ὕ͟ቡ╣ᙥᡧ٩ի൭ᅯၱᡳ፵", a_), typeof(bool), typeof(SmartKeyFobGraphicView));
			SmartKeyFobGraphicView.UnlockTrunkButtonTrkIsAcpVisibleProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("朱娳娵圷夹圻樽㈿㝁⩃ⵅੇ㽉㡋㩍㽏㱑S⑕㍗ፙ⽛Ὕ͟ቡ㉣ཥ᭧ͩ๫ɭᕯ", a_), typeof(bool), typeof(SmartKeyFobGraphicView));
			SmartKeyFobGraphicView.UnlockTrunkButtonTrkIsAcpEditableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("朱娳娵圷夹圻樽㈿㝁⩃ⵅੇ㽉㡋㩍㽏㱑S⑕㍗ፙ⽛Ὕ͟ቡⅣɥŧṩ൫౭ᱯ᝱", a_), typeof(bool), typeof(SmartKeyFobGraphicView));
			SmartKeyFobGraphicView.UnlockTrunkButtonTrkUIValueProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("朱娳娵圷夹圻樽㈿㝁⩃ⵅੇ㽉㡋㩍㽏㱑S⑕㍗ཙᕛ࡝ş๡ᅣͥ", a_), typeof(string), typeof(SmartKeyFobGraphicView));
			SmartKeyFobGraphicView.UnlockTrunkButtonTrkListProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("朱娳娵圷夹圻樽㈿㝁⩃ⵅੇ㽉㡋㩍㽏㱑S⑕㍗ᙙ㕛ⵝᑟ", a_), typeof(AcpListField), typeof(SmartKeyFobGraphicView));
			SmartKeyFobGraphicView.AlarmButtonCnvIsAcpValidProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("猱堳圵䨷圹縻䬽㐿㙁⭃⡅େ⑉㩋ݍ⍏ፑ㝓♕๗㭙せ㝝џ", a_), typeof(bool), typeof(SmartKeyFobGraphicView));
			SmartKeyFobGraphicView.AlarmButtonCnvIsAcpApplicableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("猱堳圵䨷圹縻䬽㐿㙁⭃⡅େ⑉㩋ݍ⍏ፑ㝓♕ᥗ⩙ⱛ㉝य़šգѥѧཀྵ", a_), typeof(bool), typeof(SmartKeyFobGraphicView));
			SmartKeyFobGraphicView.AlarmButtonCnvIsAcpVisibleProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("猱堳圵䨷圹縻䬽㐿㙁⭃⡅େ⑉㩋ݍ⍏ፑ㝓♕๗㍙⽛㝝ɟ๡ţ", a_), typeof(bool), typeof(SmartKeyFobGraphicView));
			SmartKeyFobGraphicView.AlarmButtonCnvIsAcpEditableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("猱堳圵䨷圹縻䬽㐿㙁⭃⡅େ⑉㩋ݍ⍏ፑ㝓♕ᵗ㹙㕛⩝şaࡣͥ", a_), typeof(bool), typeof(SmartKeyFobGraphicView));
			SmartKeyFobGraphicView.AlarmButtonCnvUIValueProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("猱堳圵䨷圹縻䬽㐿㙁⭃⡅େ⑉㩋᭍᥏ё㕓㩕ⵗ㽙", a_), typeof(string), typeof(SmartKeyFobGraphicView));
			SmartKeyFobGraphicView.AlarmButtonCnvListProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("猱堳圵䨷圹縻䬽㐿㙁⭃⡅େ⑉㩋ɍ㥏⅑⁓", a_), typeof(AcpListField), typeof(SmartKeyFobGraphicView));
			SmartKeyFobGraphicView.AlarmButtonTrkIsAcpValidProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("猱堳圵䨷圹縻䬽㐿㙁⭃⡅᱇㡉❋ݍ⍏ፑ㝓♕๗㭙せ㝝џ", a_), typeof(bool), typeof(SmartKeyFobGraphicView));
			SmartKeyFobGraphicView.AlarmButtonTrkIsAcpApplicableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("猱堳圵䨷圹縻䬽㐿㙁⭃⡅᱇㡉❋ݍ⍏ፑ㝓♕ᥗ⩙ⱛ㉝य़šգѥѧཀྵ", a_), typeof(bool), typeof(SmartKeyFobGraphicView));
			SmartKeyFobGraphicView.AlarmButtonTrkIsAcpVisibleProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("猱堳圵䨷圹縻䬽㐿㙁⭃⡅᱇㡉❋ݍ⍏ፑ㝓♕๗㍙⽛㝝ɟ๡ţ", a_), typeof(bool), typeof(SmartKeyFobGraphicView));
			SmartKeyFobGraphicView.AlarmButtonTrkIsAcpEditableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("猱堳圵䨷圹縻䬽㐿㙁⭃⡅᱇㡉❋ݍ⍏ፑ㝓♕ᵗ㹙㕛⩝şaࡣͥ", a_), typeof(bool), typeof(SmartKeyFobGraphicView));
			SmartKeyFobGraphicView.AlarmButtonTrkUIValueProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("猱堳圵䨷圹縻䬽㐿㙁⭃⡅᱇㡉❋᭍᥏ё㕓㩕ⵗ㽙", a_), typeof(string), typeof(SmartKeyFobGraphicView));
			SmartKeyFobGraphicView.AlarmButtonTrkListProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("猱堳圵䨷圹縻䬽㐿㙁⭃⡅᱇㡉❋ɍ㥏⅑⁓", a_), typeof(AcpListField), typeof(SmartKeyFobGraphicView));
		}

		// Token: 0x04000E3C RID: 3644
		private bool isLblLockUpButtonCnvValueAnimating;

		// Token: 0x04000E3D RID: 3645
		private bool isLblLockUpButtonTrkValueAnimating;

		// Token: 0x04000E3E RID: 3646
		private bool isLblLockDownButtonCnvValueAnimating;

		// Token: 0x04000E3F RID: 3647
		private bool isLblLockDownButtonTrkValueAnimating;

		// Token: 0x04000E40 RID: 3648
		private bool isLblUnlockUpButtonCnvValueAnimating;

		// Token: 0x04000E41 RID: 3649
		private bool isLblUnlockUpButtonTrkValueAnimating;

		// Token: 0x04000E42 RID: 3650
		private bool isLblUnlockDownButtonCnvValueAnimating;

		// Token: 0x04000E43 RID: 3651
		private bool isLblUnlockDownButtonTrkValueAnimating;

		// Token: 0x04000E44 RID: 3652
		private bool isLblUnlockTrunkButtonCnvValueAnimating;

		// Token: 0x04000E45 RID: 3653
		private bool isLblUnlockTrunkButtonTrkValueAnimating;

		// Token: 0x04000E46 RID: 3654
		private bool isLblAlarmButtonCnvValueAnimating;

		// Token: 0x04000E47 RID: 3655
		private bool isLblAlarmButtonTrkValueAnimating;

		// Token: 0x04000E48 RID: 3656
		public static DependencyProperty LockUpButtonCnvIsAcpValidProperty;

		// Token: 0x04000E49 RID: 3657
		public static DependencyProperty LockUpButtonCnvIsAcpApplicableProperty;

		// Token: 0x04000E4A RID: 3658
		public static DependencyProperty LockUpButtonCnvIsAcpVisibleProperty;

		// Token: 0x04000E4B RID: 3659
		public static DependencyProperty LockUpButtonCnvIsAcpEditableProperty;

		// Token: 0x04000E4C RID: 3660
		public static DependencyProperty LockUpButtonCnvUIValueProperty;

		// Token: 0x04000E4D RID: 3661
		public static DependencyProperty LockUpButtonCnvListProperty;

		// Token: 0x04000E4E RID: 3662
		public static DependencyProperty LockUpButtonTrkIsAcpValidProperty;

		// Token: 0x04000E4F RID: 3663
		public static DependencyProperty LockUpButtonTrkIsAcpApplicableProperty;

		// Token: 0x04000E50 RID: 3664
		public static DependencyProperty LockUpButtonTrkIsAcpVisibleProperty;

		// Token: 0x04000E51 RID: 3665
		public static DependencyProperty LockUpButtonTrkIsAcpEditableProperty;

		// Token: 0x04000E52 RID: 3666
		public static DependencyProperty LockUpButtonTrkUIValueProperty;

		// Token: 0x04000E53 RID: 3667
		public static DependencyProperty LockUpButtonTrkListProperty;

		// Token: 0x04000E54 RID: 3668
		public static DependencyProperty LockDownButtonCnvIsAcpValidProperty;

		// Token: 0x04000E55 RID: 3669
		public static DependencyProperty LockDownButtonCnvIsAcpApplicableProperty;

		// Token: 0x04000E56 RID: 3670
		public static DependencyProperty LockDownButtonCnvIsAcpVisibleProperty;

		// Token: 0x04000E57 RID: 3671
		public static DependencyProperty LockDownButtonCnvIsAcpEditableProperty;

		// Token: 0x04000E58 RID: 3672
		public static DependencyProperty LockDownButtonCnvUIValueProperty;

		// Token: 0x04000E59 RID: 3673
		public static DependencyProperty LockDownButtonCnvListProperty;

		// Token: 0x04000E5A RID: 3674
		public static DependencyProperty LockDownButtonTrkIsAcpValidProperty;

		// Token: 0x04000E5B RID: 3675
		public static DependencyProperty LockDownButtonTrkIsAcpApplicableProperty;

		// Token: 0x04000E5C RID: 3676
		public static DependencyProperty LockDownButtonTrkIsAcpVisibleProperty;

		// Token: 0x04000E5D RID: 3677
		public static DependencyProperty LockDownButtonTrkIsAcpEditableProperty;

		// Token: 0x04000E5E RID: 3678
		public static DependencyProperty LockDownButtonTrkUIValueProperty;

		// Token: 0x04000E5F RID: 3679
		public static DependencyProperty LockDownButtonTrkListProperty;

		// Token: 0x04000E60 RID: 3680
		public static DependencyProperty UnlockUpButtonCnvIsAcpValidProperty;

		// Token: 0x04000E61 RID: 3681
		public static DependencyProperty UnlockUpButtonCnvIsAcpApplicableProperty;

		// Token: 0x04000E62 RID: 3682
		public static DependencyProperty UnlockUpButtonCnvIsAcpVisibleProperty;

		// Token: 0x04000E63 RID: 3683
		public static DependencyProperty UnlockUpButtonCnvIsAcpEditableProperty;

		// Token: 0x04000E64 RID: 3684
		public static DependencyProperty UnlockUpButtonCnvUIValueProperty;

		// Token: 0x04000E65 RID: 3685
		public static DependencyProperty UnlockUpButtonCnvListProperty;

		// Token: 0x04000E66 RID: 3686
		public static DependencyProperty UnlockUpButtonTrkIsAcpValidProperty;

		// Token: 0x04000E67 RID: 3687
		public static DependencyProperty UnlockUpButtonTrkIsAcpApplicableProperty;

		// Token: 0x04000E68 RID: 3688
		public static DependencyProperty UnlockUpButtonTrkIsAcpVisibleProperty;

		// Token: 0x04000E69 RID: 3689
		public static DependencyProperty UnlockUpButtonTrkIsAcpEditableProperty;

		// Token: 0x04000E6A RID: 3690
		public static DependencyProperty UnlockUpButtonTrkUIValueProperty;

		// Token: 0x04000E6B RID: 3691
		public static DependencyProperty UnlockUpButtonTrkListProperty;

		// Token: 0x04000E6C RID: 3692
		public static DependencyProperty UnlockDownButtonCnvIsAcpValidProperty;

		// Token: 0x04000E6D RID: 3693
		public static DependencyProperty UnlockDownButtonCnvIsAcpApplicableProperty;

		// Token: 0x04000E6E RID: 3694
		public static DependencyProperty UnlockDownButtonCnvIsAcpVisibleProperty;

		// Token: 0x04000E6F RID: 3695
		public static DependencyProperty UnlockDownButtonCnvIsAcpEditableProperty;

		// Token: 0x04000E70 RID: 3696
		public static DependencyProperty UnlockDownButtonCnvUIValueProperty;

		// Token: 0x04000E71 RID: 3697
		public static DependencyProperty UnlockDownButtonCnvListProperty;

		// Token: 0x04000E72 RID: 3698
		public static DependencyProperty UnlockDownButtonTrkIsAcpValidProperty;

		// Token: 0x04000E73 RID: 3699
		public static DependencyProperty UnlockDownButtonTrkIsAcpApplicableProperty;

		// Token: 0x04000E74 RID: 3700
		public static DependencyProperty UnlockDownButtonTrkIsAcpVisibleProperty;

		// Token: 0x04000E75 RID: 3701
		public static DependencyProperty UnlockDownButtonTrkIsAcpEditableProperty;

		// Token: 0x04000E76 RID: 3702
		public static DependencyProperty UnlockDownButtonTrkUIValueProperty;

		// Token: 0x04000E77 RID: 3703
		public static DependencyProperty UnlockDownButtonTrkListProperty;

		// Token: 0x04000E78 RID: 3704
		public static DependencyProperty UnlockTrunkButtonCnvIsAcpValidProperty;

		// Token: 0x04000E79 RID: 3705
		public static DependencyProperty UnlockTrunkButtonCnvIsAcpApplicableProperty;

		// Token: 0x04000E7A RID: 3706
		public static DependencyProperty UnlockTrunkButtonCnvIsAcpVisibleProperty;

		// Token: 0x04000E7B RID: 3707
		public static DependencyProperty UnlockTrunkButtonCnvIsAcpEditableProperty;

		// Token: 0x04000E7C RID: 3708
		public static DependencyProperty UnlockTrunkButtonCnvUIValueProperty;

		// Token: 0x04000E7D RID: 3709
		public static DependencyProperty UnlockTrunkButtonCnvListProperty;

		// Token: 0x04000E7E RID: 3710
		public static DependencyProperty UnlockTrunkButtonTrkIsAcpValidProperty;

		// Token: 0x04000E7F RID: 3711
		public static DependencyProperty UnlockTrunkButtonTrkIsAcpApplicableProperty;

		// Token: 0x04000E80 RID: 3712
		public static DependencyProperty UnlockTrunkButtonTrkIsAcpVisibleProperty;

		// Token: 0x04000E81 RID: 3713
		public static DependencyProperty UnlockTrunkButtonTrkIsAcpEditableProperty;

		// Token: 0x04000E82 RID: 3714
		public static DependencyProperty UnlockTrunkButtonTrkUIValueProperty;

		// Token: 0x04000E83 RID: 3715
		public static DependencyProperty UnlockTrunkButtonTrkListProperty;

		// Token: 0x04000E84 RID: 3716
		public static DependencyProperty AlarmButtonCnvIsAcpValidProperty;

		// Token: 0x04000E85 RID: 3717
		public static DependencyProperty AlarmButtonCnvIsAcpApplicableProperty;

		// Token: 0x04000E86 RID: 3718
		public static DependencyProperty AlarmButtonCnvIsAcpVisibleProperty;

		// Token: 0x04000E87 RID: 3719
		public static DependencyProperty AlarmButtonCnvIsAcpEditableProperty;

		// Token: 0x04000E88 RID: 3720
		public static DependencyProperty AlarmButtonCnvUIValueProperty;

		// Token: 0x04000E89 RID: 3721
		public static DependencyProperty AlarmButtonCnvListProperty;

		// Token: 0x04000E8A RID: 3722
		public static DependencyProperty AlarmButtonTrkIsAcpValidProperty;

		// Token: 0x04000E8B RID: 3723
		public static DependencyProperty AlarmButtonTrkIsAcpApplicableProperty;

		// Token: 0x04000E8C RID: 3724
		public static DependencyProperty AlarmButtonTrkIsAcpVisibleProperty;

		// Token: 0x04000E8D RID: 3725
		public static DependencyProperty AlarmButtonTrkIsAcpEditableProperty;

		// Token: 0x04000E8E RID: 3726
		public static DependencyProperty AlarmButtonTrkUIValueProperty;

		// Token: 0x04000E8F RID: 3727
		public static DependencyProperty AlarmButtonTrkListProperty;
	}
}
