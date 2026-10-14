using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Markup;
using AcpCommonLib;
using AcpUI;
using AcpUI.Common;
using AllFeatures;

namespace Motorola.MackinawCPS.CoreFeatures.EmergencyWide
{
	// Token: 0x0200048D RID: 1165
	public class PageEmergencyWide : global::AcpUI.AcpPageFeature, global::System.Windows.Markup.IComponentConnector
	{
		// Token: 0x0600989B RID: 39067 RVA: 0x008F284C File Offset: 0x008F0A4C
		public PageEmergencyWide()
		{
			try
			{
				this.InitializeComponent();
				global::AcpUI.Common.Utility.SetDirection(this);
			}
			catch (global::System.Exception)
			{
			}
		}

		// Token: 0x0600989C RID: 39068 RVA: 0x008F2884 File Offset: 0x008F0A84
		public override void OnLoaded(object sender, global::System.Windows.RoutedEventArgs e)
		{
			short num = (short)1248264193;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				num = (short)1713569771;
				short num3 = num;
				num = (short)76414955;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_2A4;
				case 1:
					break;
				default:
				{
					num = (short)778174464;
					short num4 = num;
					break;
				}
				}
				num = (short)2130706432;
				if (num != 0)
				{
				}
				global::AcpUI.AcpExpander acpExpander;
				global::System.Collections.IEnumerator enumerator;
				switch (num2)
				{
				case 0:
					try
					{
						num = (short)1144324098;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								num = (short)1120141318;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 2:
								switch (0)
								{
								case 0:
									goto IL_13B;
								}
								continue;
							case 3:
								if (acpExpander != null)
								{
									num = (short)2037645316;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							case 4:
								base.Expanders.Add(acpExpander);
								num = (short)851116033;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 5:
								if (!enumerator.MoveNext())
								{
									num = (short)2051145728;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								acpExpander = (((global::System.Windows.UIElement)enumerator.Current) as global::AcpUI.AcpExpander);
								num = (short)685047811;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 6:
								goto IL_1F2;
							}
							IL_17C:
							num = (short)369295365;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_13B:
							goto IL_17C;
						}
						IL_1F2:
						goto IL_295;
					}
					finally
					{
						switch (0)
						{
						case 0:
							goto IL_213;
						}
						global::System.IDisposable disposable;
						for (;;)
						{
							IL_201:
							switch (num2)
							{
							case 0:
								if (disposable != null)
								{
									num = (short)781778945;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_264;
							case 1:
								disposable.Dispose();
								num = (short)1206124546;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 2:
								goto IL_262;
							}
							goto IL_213;
						}
						IL_262:
						IL_264:
						goto EndFinally_8;
						IL_213:
						disposable = (enumerator as global::System.IDisposable);
						num = (short)285605888;
						num2 = (int)((global::System.IntPtr)num);
						goto IL_201;
						EndFinally_8:;
					}
					goto IL_265;
					IL_295:
					base.OnLoaded(sender, e);
					this.a = true;
					goto IL_2A4;
				case 1:
					switch (0)
					{
					case 0:
						goto IL_AB;
					}
					continue;
				case 2:
					goto IL_265;
				case 3:
					goto IL_2BC;
				}
				IL_AB:
				num = (short)1097859073;
				if (num != 0)
				{
				}
				if (!this.a)
				{
					num = (short)1834549250;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_265:
				acpExpander = null;
				enumerator = this.MyStackPanel.Children.GetEnumerator();
				num = (short)1184432128;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_2A4:
				num = (short)2070216707;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_2BC:
			this.MyStackPanel.Children[0].Focus();
		}

		// Token: 0x0600989D RID: 39069 RVA: 0x008F2B78 File Offset: 0x008F0D78
		public override void OnUnloaded(object sender, global::System.Windows.RoutedEventArgs e)
		{
			short num = (short)212205568;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_16;
				case 1:
					base.OnUnloaded(sender, e);
					this.a = false;
					num = (short)2028535810;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
				{
					num = (short)1916818591;
					short num3 = num;
					num = (short)1922847903;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_16;
					default:
						goto IL_D4;
					}
					break;
				}
				}
				goto IL_59;
				IL_16:
				num = (short)867237889;
				if (num != 0)
				{
				}
				switch (0)
				{
				case 0:
					IL_59:
					if (!this.a)
					{
						return;
					}
					num = (short)692453377;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
			}
			IL_D4:
			num = (short)990117888;
			short num4 = num;
			num = (short)1464074240;
			if (num != 0)
			{
			}
		}

		// Token: 0x0600989E RID: 39070 RVA: 0x008F2C9C File Offset: 0x008F0E9C
		public override void SetDataContext()
		{
			short num = (short)575864834;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_EC;
				case 1:
					goto IL_63;
				case 2:
					switch (0)
					{
					case 0:
						goto IL_42;
					}
					continue;
				case 3:
				{
					num = (short)1827405824;
					short num3 = num;
					base.DataContext = global::AcpCommonLib.AppInfoManager.DefaultDocument.GetFeature(2032);
					num = (short)907876497;
					short num4 = num;
					num = (short)1868109969;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_EC;
					default:
						num = (short)1275133952;
						if (num != 0)
						{
						}
						num = (short)140181505;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 4:
					if (global::AcpCommonLib.AppInfoManager.AppMode == global::AcpCommonLib.ApplicationMode.CodeplugComparisonMode)
					{
						num = (short)199622661;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 5:
					num = (short)679870465;
					if (num != 0)
					{
					}
					global::AcpCommonLib.AppInfoManager.ComparatorDocument.GetFeature(2032);
					num = (short)1643053062;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 6:
					return;
				}
				IL_42:
				if (global::AcpCommonLib.AppInfoManager.AppMode == global::AcpCommonLib.ApplicationMode.CustomViewConfigurationMode)
				{
					num = (short)836567043;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				base.DataContext = global::AcpCommonLib.FeatureManager.GetFeature(2032);
				num = (short)1792933888;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_63:
				num = (short)686555140;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_EC:
				goto IL_63;
			}
		}

		// Token: 0x0600989F RID: 39071 RVA: 0x008F2E6C File Offset: 0x008F106C
		private void HLinkClick(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num = (short)231679095;
			short num2 = num;
			num = (short)1710105719;
			switch (num2 == num)
			{
			}
			num = (short)1058668545;
			if (num != 0)
			{
			}
			num = (short)1056374784;
			short num3 = num;
			num = (short)915472384;
			if (num != 0)
			{
			}
			base.OnHLinkClick(A_0);
		}

		// Token: 0x060098A0 RID: 39072 RVA: 0x008F2F1C File Offset: 0x008F111C
		private void OnFieldNameDoubleClick(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num = (short)687521445;
			short num2 = num;
			num = (short)2028519077;
			switch (num2 == num)
			{
			}
			num = (short)1150615553;
			if (num != 0)
			{
			}
			num = (short)890699776;
			short num3 = num;
			num = (short)1765474304;
			if (num != 0)
			{
			}
			global::AcpUI.Common.Utility.GetFieldHelpText(A_0);
		}

		// Token: 0x060098A1 RID: 39073 RVA: 0x008F2FCC File Offset: 0x008F11CC
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "5.0.10.0")]
		[global::System.Diagnostics.DebuggerNonUserCode]
		public void InitializeComponent()
		{
			int a_ = 11;
			while (this.b)
			{
				short num = (short)1172317056;
				short num2 = num;
				num = (short)1816929152;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)2081161216;
					short num3 = num;
					num = (short)1911291905;
					if (num != 0)
					{
					}
					num = (short)535363584;
					if (num != 0)
					{
					}
					return;
				}
				}
			}
			this.b = true;
			global::System.Uri resourceLocator = new global::System.Uri(global::AllFeatures.CodeplugGuid.b("迍볏뻑鋓돕맗껙꧛곝藟釡\udfe3藥蟧蟩鳫臭黯韱髳苵ퟷ鿹釻鯽狿攁愃栅欇猉⤋㰍‏焑笓砕縗猙笛欝刟䌡倣伥䜧䐩̫䬭崯圱䘳儵崷吹弻䜽政灁瑃ㅅⅇ⹉⥋慍㕏㽑ㅓ⑕㽗㽙㉛㵝ᥟᕡൣɥ൧䑩ᑫ཭ᵯṱ", a_), global::System.UriKind.Relative);
			global::System.Windows.Application.LoadComponent(this, resourceLocator);
		}

		// Token: 0x060098A2 RID: 39074 RVA: 0x008F30B0 File Offset: 0x008F12B0
		[global::System.Diagnostics.DebuggerNonUserCode]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "5.0.10.0")]
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		void global::System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
		{
			short num = (short)1921318914;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					num = (short)542900225;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					goto IL_9CF;
				case 2:
					switch (0)
					{
					case 0:
						goto IL_31;
					}
					continue;
				}
				IL_31:
				switch (connectionId)
				{
				case 1:
					goto IL_3C9;
				case 2:
					goto IL_9D4;
				case 3:
					goto IL_654;
				case 4:
					goto IL_586;
				case 5:
					goto IL_8B9;
				case 6:
					goto IL_ED3;
				case 7:
					goto IL_F42;
				case 8:
					goto IL_BED;
				case 9:
					goto IL_CF7;
				case 10:
					goto IL_C92;
				case 11:
					goto IL_6C3;
				case 12:
					goto IL_E7E;
				case 13:
					goto IL_888;
				case 14:
					goto IL_D04;
				case 15:
					goto IL_EF7;
				case 16:
					goto IL_E71;
				case 17:
					goto IL_8DD;
				case 18:
					goto IL_895;
				case 19:
					goto IL_7A4;
				case 20:
					goto IL_305;
				case 21:
					goto IL_D11;
				case 22:
					goto IL_692;
				case 23:
					goto IL_630;
				case 24:
					goto IL_41E;
				case 25:
					goto IL_A83;
				case 26:
					goto IL_6E7;
				case 27:
					goto IL_F28;
				case 28:
					goto IL_759;
				case 29:
					goto IL_3FA;
				case 30:
					goto IL_F04;
				case 31:
					goto IL_D76;
				case 32:
					goto IL_2D4;
				case 33:
					goto IL_521;
				case 34:
					goto IL_87B;
				case 35:
					goto IL_442;
				case 36:
					goto IL_701;
				case 37:
					goto IL_367;
				case 38:
					goto IL_685;
				case 39:
					goto IL_56C;
				case 40:
					goto IL_55F;
				case 41:
					goto IL_DCE;
				case 42:
					goto IL_BFA;
				case 43:
					goto IL_E30;
				case 44:
					goto IL_552;
				case 45:
					goto IL_B3D;
				case 46:
					goto IL_FBE;
				case 47:
					goto IL_AB7;
				case 48:
					goto IL_4FD;
				case 49:
					goto IL_DC1;
				case 50:
					goto IL_CAC;
				case 51:
					goto IL_E3D;
				case 52:
					goto IL_5CE;
				case 53:
					goto IL_94C;
				case 54:
					goto IL_773;
				case 55:
					goto IL_A69;
				case 56:
					goto IL_5FF;
				case 57:
					goto IL_901;
				case 58:
					goto IL_B4A;
				case 59:
					goto IL_CB9;
				case 60:
					goto IL_4CC;
				case 61:
					goto IL_4BF;
				case 62:
					goto IL_7D8;
				case 63:
					goto IL_C85;
				case 64:
					goto IL_F35;
				case 65:
					goto IL_7CB;
				case 66:
					goto IL_7E5;
				case 67:
					goto IL_819;
				case 68:
					goto IL_3A5;
				case 69:
					goto IL_A12;
				case 70:
					goto IL_EA2;
				case 71:
					goto IL_CEA;
				case 72:
					goto IL_80C;
				case 73:
					goto IL_5AA;
				case 74:
					goto IL_9EE;
				case 75:
					goto IL_D83;
				case 76:
					goto IL_A76;
				case 77:
					goto IL_E64;
				case 78:
					goto IL_579;
				case 79:
					goto IL_C61;
				case 80:
					goto IL_970;
				case 81:
					goto IL_D5C;
				case 82:
					goto IL_B0C;
				case 83:
					goto IL_7F2;
				case 84:
					goto IL_797;
				case 85:
					goto IL_F69;
				case 86:
					goto IL_F9A;
				case 87:
					goto IL_2C7;
				case 88:
					goto IL_7BE;
				case 89:
					goto IL_86E;
				case 90:
					goto IL_9E1;
				case 91:
					goto IL_343;
				case 92:
					goto IL_83D;
				case 93:
					goto IL_766;
				case 94:
					goto IL_6F4;
				case 95:
					goto IL_F8D;
				case 96:
					goto IL_BA2;
				case 97:
					goto IL_DF2;
				case 98:
					goto IL_B64;
				case 99:
					goto IL_4F0;
				case 100:
					goto IL_A9D;
				case 101:
					goto IL_93F;
				case 102:
					goto IL_AAA;
				case 103:
					goto IL_C1E;
				case 104:
					goto IL_932;
				case 105:
					goto IL_312;
				case 106:
					goto IL_90E;
				case 107:
					goto IL_BAF;
				case 108:
					goto IL_2BA;
				case 109:
					goto IL_B95;
				case 110:
					goto IL_D1E;
				case 111:
					goto IL_AFF;
				case 112:
					goto IL_B57;
				case 113:
					goto IL_994;
				case 114:
					goto IL_5DB;
				case 115:
					goto IL_732;
				case 116:
					goto IL_7B1;
				case 117:
					goto IL_BBC;
				case 118:
					goto IL_C9F;
				case 119:
					goto IL_69F;
				case 120:
					goto IL_B19;
				case 121:
					goto IL_861;
				case 122:
					goto IL_48A;
				case 123:
					goto IL_D4F;
				case 124:
					goto IL_E57;
				case 125:
					goto IL_2E1;
				case 126:
					goto IL_52E;
				case 127:
					goto IL_F5C;
				case 128:
					goto IL_725;
				case 129:
					goto IL_73F;
				case 130:
					goto IL_A90;
				case 131:
					goto IL_ADB;
				case 132:
					goto IL_60C;
				case 133:
					goto IL_74C;
				case 134:
					goto IL_374;
				case 135:
					goto IL_F4F;
				case 136:
					goto IL_E4A;
				case 137:
					goto IL_466;
				case 138:
					goto IL_D2B;
				case 139:
					goto IL_336;
				case 140:
					goto IL_678;
				case 141:
					goto IL_7FF;
				case 142:
					goto IL_B88;
				case 143:
					goto IL_D90;
				case 144:
					goto IL_BC9;
				case 145:
					goto IL_E23;
				case 146:
					goto IL_D69;
				case 147:
					goto IL_C2B;
				case 148:
					goto IL_E16;
				case 149:
					goto IL_381;
				case 150:
					goto IL_EAF;
				case 151:
					goto IL_DB4;
				case 152:
					goto IL_FCB;
				case 153:
					goto IL_CDD;
				default:
					num = (short)1504575488;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
			}
			IL_2BA:
			this.CpyBtnTriggedByManDown_42135 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_2C7:
			this.RTDBtnEmerWideManDownPostAlertTimer_A40004 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_2D4:
			this.CpyBtnEmerWideGeneralSuppressEmergencyCall_A42142 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_2E1:
			this.LblEmerWideImpactDetectionPreAlertTimer_A43381 = (global::AcpUI.AcpLabel)target;
			this.LblEmerWideImpactDetectionPreAlertTimer_A43381.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_305:
			this.CpyBtnEmerWideGeneralKeepAlive_A8360 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_312:
			this.LblTriggedByManDown_42135 = (global::AcpUI.AcpLabel)target;
			this.LblTriggedByManDown_42135.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_336:
			this.RTDBtnEmerWideImpactDetectionPreAlertTone_A43383 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_343:
			this.LblEmerWidePostAlertTone_A41191 = (global::AcpUI.AcpLabel)target;
			this.LblEmerWidePostAlertTone_A41191.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_367:
			this.RTDBtnEmerWideGeneralUnmuteOption_A9598 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_374:
			this.CpyBtnEmerWideImpactDetectionPostAlertTimer_A43382 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_381:
			this.LblEmerWideImpactDetectionEventForce_A43428 = (global::AcpUI.AcpLabel)target;
			this.LblEmerWideImpactDetectionEventForce_A43428.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_3A5:
			this.EmerWideManDownTrigger_A40001 = (global::AcpUI.AcpComboBox)target;
			this.EmerWideManDownTrigger_A40001.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_3C9:
			((global::Motorola.MackinawCPS.CoreFeatures.EmergencyWide.PageEmergencyWide)target).Loaded += this.OnLoaded;
			((global::Motorola.MackinawCPS.CoreFeatures.EmergencyWide.PageEmergencyWide)target).Unloaded += this.OnUnloaded;
			return;
			IL_3FA:
			this.LblEmerWideGeneralSuppressEmergencyCall_A42142 = (global::AcpUI.AcpLabel)target;
			this.LblEmerWideGeneralSuppressEmergencyCall_A42142.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_41E:
			this.EmerWideGeneralSilentAlarm_A9130 = (global::AcpUI.AcpCheckBox)target;
			this.EmerWideGeneralSilentAlarm_A9130.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_442:
			this.LblEmerWideGeneralUnmuteOption_A9598 = (global::AcpUI.AcpLabel)target;
			this.LblEmerWideGeneralUnmuteOption_A9598.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_466:
			this.LblEmerWideImpactDetectionPreAlertTone_A43383 = (global::AcpUI.AcpLabel)target;
			this.LblEmerWideImpactDetectionPreAlertTone_A43383.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_48A:
			num = (short)1692729345;
			if (num != 0)
			{
			}
			this.CpyBtnEmerWideImpDectToneTrigger_A43386 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_4BF:
			this.RTDBtnEmerWideGeneralDistinguishEmergencyType_43546 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_4CC:
			this.EmerWideGeneralDistinguishEmergencyType_43546 = (global::AcpUI.AcpCheckBox)target;
			this.EmerWideGeneralDistinguishEmergencyType_43546.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_4F0:
			this.RTDBtnManDownConfigurabilityGranularityLevel_42057 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_4FD:
			this.EmerWideGeneralEmergencyPowerUp_A7942 = (global::AcpUI.AcpCheckBox)target;
			this.EmerWideGeneralEmergencyPowerUp_A7942.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_521:
			this.EmerWideGeneralSuppressEmergencyCall_A42142Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_52E:
			this.EmerWideImpactDetectionPreAlertTimer_A43381 = (global::AcpUI.AcpTextBoxSpinner)target;
			this.EmerWideImpactDetectionPreAlertTimer_A43381.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_552:
			this.CpyBtnEmerWideGeneralChannelDelaysec_A7657 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_55F:
			this.CVBtnEmerWideGeneralChannelDelaysec_A7657 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_56C:
			this.EmerWideGeneralUnmuteOption_A9598Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_579:
			this.CVBtnEmerWideManDownPreAlertTimer_A40003 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_586:
			this.HLinkManDown = (global::System.Windows.Documents.Hyperlink)target;
			this.HLinkManDown.Click += this.HLinkClick;
			return;
			IL_5AA:
			this.LblEmerWideManDownMotionlessSensitivity_A40002 = (global::AcpUI.AcpLabel)target;
			this.LblEmerWideManDownMotionlessSensitivity_A40002.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_5CE:
			this.CVBtnEmerWideGeneralEmergencyCallReceive_A7937 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_5DB:
			this.EmerWideImpactDetectionConfigLevel_A43384 = (global::AcpUI.AcpComboBox)target;
			this.EmerWideImpactDetectionConfigLevel_A43384.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_5FF:
			this.CpyBtnEmerWideGeneralEmergencyCallReceive_A7937 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_60C:
			this.EmerWideImpactDetectionPostAlertTimer_A43382 = (global::AcpUI.AcpTextBoxSpinner)target;
			this.EmerWideImpactDetectionPostAlertTimer_A43382.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_630:
			this.LblEmerWideGeneralSilentAlarm_A9130 = (global::AcpUI.AcpLabel)target;
			this.LblEmerWideGeneralSilentAlarm_A9130.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_654:
			this.HLinkGeneral = (global::System.Windows.Documents.Hyperlink)target;
			this.HLinkGeneral.Click += this.HLinkClick;
			return;
			IL_678:
			this.CpyBtnEmerWideImpactDetectionPreAlertTone_A43383 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_685:
			this.CpyBtnEmerWideGeneralUnmuteOption_A9598 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_692:
			this.CVBtnEmerWideGeneralSilentAlarm_A9130 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_69F:
			this.LblEmerWideImpDectToneTrigger_A43386 = (global::AcpUI.AcpLabel)target;
			this.LblEmerWideImpDectToneTrigger_A43386.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_6C3:
			this.LblEmerWideGeneralEmergencyAlarmRxIndicatorType_A7933 = (global::AcpUI.AcpLabel)target;
			this.LblEmerWideGeneralEmergencyAlarmRxIndicatorType_A7933.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_6E7:
			this.CpyBtnEmerWideGeneralSilentAlarm_A9130 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_6F4:
			this.CpyBtnEmerWidePostAlertTone_A41191 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_701:
			this.EmerWideGeneralUnmuteOption_A9598 = (global::AcpUI.AcpCheckBox)target;
			this.EmerWideGeneralUnmuteOption_A9598.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_725:
			this.CpyBtnEmerWideImpactDetectionPreAlertTimer_A43381 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_732:
			this.RTDBtnEmerWideImpactDetectionConfigLevel_A43384 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_73F:
			this.EmerWideImpactDetectionPreAlertTimer_A43381Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_74C:
			this.RTDBtnEmerWideImpactDetectionPostAlertTimer_A43382 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_759:
			this.CVBtnEmerWideGeneralSuppressEmergencyCall_A42142 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_766:
			this.RTDBtnEmerWidePostAlertTone_A41191 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_773:
			this.EmerWideGeneralEmergencyCallReceive_A7937 = (global::AcpUI.AcpCheckBox)target;
			this.EmerWideGeneralEmergencyCallReceive_A7937.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_797:
			this.CVBtnEmerWideManDownPostAlertTimer_A40004 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_7A4:
			this.RTDBtnEmerWideGeneralKeepAlive_A8360 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_7B1:
			this.CpyBtnEmerWideImpactDetectionConfigLevel_A43384 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_7BE:
			this.CpyBtnEmerWideManDownPostAlertTimer_A40004 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_7CB:
			this.GrpBoxExpanderEmergencyWideManDownPseudo0 = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_7D8:
			this.CpyBtnEmerWideGeneralDistinguishEmergencyType_43546 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_7E5:
			this.CVBtnEmerWideManDownTrigger_A40001 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_7F2:
			this.EmerWideManDownPreAlertTimer_A40003Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_7FF:
			this.EmerWideImpactDetectionPreAlertTone_A43383Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_80C:
			this.CVBtnEmerWideManDownMotionlessSensitivity_A40002 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_819:
			this.LblEmerWideManDownTrigger_A40001 = (global::AcpUI.AcpLabel)target;
			this.LblEmerWideManDownTrigger_A40001.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_83D:
			this.EmerWidePostAlertTone_A41191 = (global::AcpUI.AcpComboBox)target;
			this.EmerWidePostAlertTone_A41191.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_861:
			this.RTDBtnEmerWideImpDectToneTrigger_A43386 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_86E:
			this.EmerWideManDownPostAlertTimer_A40004Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_87B:
			this.CVBtnEmerWideGeneralUnmuteOption_A9598 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_888:
			this.RTDBtnEmerWideGeneralEmergencyAlarmRxIndicatorType_A7933 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_895:
			this.EmerWideGeneralKeepAlive_A8360 = (global::AcpUI.AcpCheckBox)target;
			this.EmerWideGeneralKeepAlive_A8360.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_8B9:
			this.HLinkEmergencyToneTrigger = (global::System.Windows.Documents.Hyperlink)target;
			this.HLinkEmergencyToneTrigger.Click += this.HLinkClick;
			return;
			IL_8DD:
			this.LblEmerWideGeneralKeepAlive_A8360 = (global::AcpUI.AcpLabel)target;
			this.LblEmerWideGeneralKeepAlive_A8360.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_901:
			this.EmerWideGeneralEmergencyCallReceive_A7937Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_90E:
			this.TriggedByManDown_42135 = (global::AcpUI.AcpCheckBox)target;
			this.TriggedByManDown_42135.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_932:
			this.CVBtnTriggedByManDown_42135 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_93F:
			this.ManDownConfigurabilityGranularityLevel_42057Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_94C:
			this.LblEmerWideGeneralEmergencyCallReceive_A7937 = (global::AcpUI.AcpLabel)target;
			this.LblEmerWideGeneralEmergencyCallReceive_A7937.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_970:
			this.EmerWideManDownPreAlertTimer_A40003 = (global::AcpUI.AcpTextBoxSpinner)target;
			this.EmerWideManDownPreAlertTimer_A40003.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_994:
			this.LblEmerWideImpactDetectionConfigLevel_A43384 = (global::AcpUI.AcpLabel)target;
			this.LblEmerWideImpactDetectionConfigLevel_A43384.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_9CF:
			this.b = true;
			return;
			IL_9D4:
			this.ThemeBaseObj = (global::AcpUI.Common.AcpThemeBase)target;
			return;
			IL_9E1:
			this.CVBtnEmerWidePostAlertTone_A41191 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_9EE:
			this.EmerWideManDownMotionlessSensitivity_A40002 = (global::AcpUI.AcpComboBox)target;
			this.EmerWideManDownMotionlessSensitivity_A40002.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_A12:
			num = (short)98529049;
			short num3 = num;
			num = (short)587558681;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_CF7:
				this.GrpBoxExpanderEmergencyWideGeneralPseudo0 = (global::AcpUI.AcpGroupBox)target;
				return;
			default:
				num = (short)1272446976;
				if (num != 0)
				{
				}
				this.RTDBtnEmerWideManDownTrigger_A40001 = (global::AcpUI.AcpRtdButton)target;
				return;
			}
			IL_A69:
			this.RTDBtnEmerWideGeneralEmergencyCallReceive_A7937 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_A76:
			this.CpyBtnEmerWideManDownMotionlessSensitivity_A40002 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_A83:
			this.RTDBtnEmerWideGeneralSilentAlarm_A9130 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_A90:
			this.CVBtnEmerWideImpactDetectionPostAlertTimer_A43382 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_A9D:
			this.CpyBtnManDownConfigurabilityGranularityLevel_42057 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_AAA:
			this.ExpanderEmergencyWideEmergencyToneTrigger = (global::AcpUI.AcpExpander)target;
			return;
			IL_AB7:
			this.LblEmerWideGeneralEmergencyPowerUp_A7942 = (global::AcpUI.AcpLabel)target;
			this.LblEmerWideGeneralEmergencyPowerUp_A7942.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_ADB:
			this.LblEmerWideImpactDetectionPostAlertTimer_A43382 = (global::AcpUI.AcpLabel)target;
			this.LblEmerWideImpactDetectionPostAlertTimer_A43382.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_AFF:
			this.GrpBoxExpanderEmergencyWideEmergencyWideImpactDetectionPseudo0 = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_B0C:
			this.CpyBtnEmerWideManDownPreAlertTimer_A40003 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_B19:
			this.EmerWideImpDectToneTrigger_A43386 = (global::AcpUI.AcpCheckBox)target;
			this.EmerWideImpDectToneTrigger_A43386.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_B3D:
			this.EmerWideGeneralChannelDelaysec_A7657Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_B4A:
			this.CVBtnEmerWideGeneralDistinguishEmergencyType_43546 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_B57:
			this.CVBtnEmerWideImpactDetectionConfigLevel_A43384 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_B64:
			this.ManDownConfigurabilityGranularityLevel_42057 = (global::AcpUI.AcpComboBox)target;
			this.ManDownConfigurabilityGranularityLevel_42057.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_B88:
			this.CVBtnEmerWideImpactDetectionEventDuration_A43427 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_B95:
			this.TriggedByManDown_42135Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_BA2:
			this.CVBtnManDownConfigurabilityGranularityLevel_42057 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_BAF:
			this.RTDBtnTriggedByManDown_42135 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_BBC:
			this.EmerWideImpactDetectionConfigLevel_A43384Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_BC9:
			this.EmerWideImpactDetectionEventDuration_A43427 = (global::AcpUI.AcpTextBoxSpinner)target;
			this.EmerWideImpactDetectionEventDuration_A43427.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_BED:
			this.ExpanderEmergencyWideGeneral = (global::AcpUI.AcpExpander)target;
			return;
			IL_BFA:
			this.EmerWideGeneralChannelDelaysec_A7657 = (global::AcpUI.AcpTextBoxSpinner)target;
			this.EmerWideGeneralChannelDelaysec_A7657.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_C1E:
			this.GrpBoxExpanderEmergencyWideEmergencyToneTriggerCustomizableTonesPerEmergencyProfile = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_C2B:
			num = (short)849412096;
			short num4 = num;
			this.EmerWideImpactDetectionEventDuration_A43427Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_C61:
			this.LblEmerWideManDownPreAlertTimer_A40003 = (global::AcpUI.AcpLabel)target;
			this.LblEmerWideManDownPreAlertTimer_A40003.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_C85:
			this.EmerWideGeneralDistinguishEmergencyType_43546Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_C92:
			this.CVBtnEmerWideGeneralEmergencyAlarmRxIndicatorType_A7933 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_C9F:
			this.CVBtnEmerWideImpDectToneTrigger_A43386 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_CAC:
			this.CpyBtnEmerWideGeneralEmergencyPowerUp_A7942 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_CB9:
			this.LblEmerWideGeneralDistinguishEmergencyType_43546 = (global::AcpUI.AcpLabel)target;
			this.LblEmerWideGeneralDistinguishEmergencyType_43546.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_CDD:
			this.EmerWideImpactDetectionEventForce_A43428Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_CEA:
			this.EmerWideManDownTrigger_A40001Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_D04:
			this.CpyBtnEmerWideGeneralEmergencyAlarmRxIndicatorType_A7933 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_D11:
			this.EmerWideGeneralKeepAlive_A8360Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_D1E:
			this.ExpanderEmergencyWideEmergencyWideImpactDetection = (global::AcpUI.AcpExpander)target;
			return;
			IL_D2B:
			this.EmerWideImpactDetectionPreAlertTone_A43383 = (global::AcpUI.AcpComboBox)target;
			this.EmerWideImpactDetectionPreAlertTone_A43383.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_D4F:
			this.EmerWideImpDectToneTrigger_A43386Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_D5C:
			this.RTDBtnEmerWideManDownPreAlertTimer_A40003 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_D69:
			this.CpyBtnEmerWideImpactDetectionEventDuration_A43427 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_D76:
			this.RTDBtnEmerWideGeneralSuppressEmergencyCall_A42142 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_D83:
			this.RTDBtnEmerWideManDownMotionlessSensitivity_A40002 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_D90:
			this.LblEmerWideImpactDetectionEventDuration_A43427 = (global::AcpUI.AcpLabel)target;
			this.LblEmerWideImpactDetectionEventDuration_A43427.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_DB4:
			this.RTDBtnEmerWideImpactDetectionEventForce_A43428 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_DC1:
			this.RTDBtnEmerWideGeneralEmergencyPowerUp_A7942 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_DCE:
			this.LblEmerWideGeneralChannelDelaysec_A7657 = (global::AcpUI.AcpLabel)target;
			this.LblEmerWideGeneralChannelDelaysec_A7657.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_DF2:
			this.LblManDownConfigurabilityGranularityLevel_42057 = (global::AcpUI.AcpLabel)target;
			this.LblManDownConfigurabilityGranularityLevel_42057.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_E16:
			this.CVBtnEmerWideImpactDetectionEventForce_A43428 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_E23:
			this.RTDBtnEmerWideImpactDetectionEventDuration_A43427 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_E30:
			this.RTDBtnEmerWideGeneralChannelDelaysec_A7657 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_E3D:
			this.EmerWideGeneralEmergencyPowerUp_A7942Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_E4A:
			this.CVBtnEmerWideImpactDetectionPreAlertTone_A43383 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_E57:
			this.CVBtnEmerWideImpactDetectionPreAlertTimer_A43381 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_E64:
			this.EmerWideManDownMotionlessSensitivity_A40002Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_E71:
			this.CVBtnEmerWideGeneralKeepAlive_A8360 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_E7E:
			this.EmerWideGeneralEmergencyAlarmRxIndicatorType_A7933 = (global::AcpUI.AcpComboBox)target;
			this.EmerWideGeneralEmergencyAlarmRxIndicatorType_A7933.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_EA2:
			this.CpyBtnEmerWideManDownTrigger_A40001 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_EAF:
			this.EmerWideImpactDetectionEventForce_A43428 = (global::AcpUI.AcpTextBoxSpinner)target;
			this.EmerWideImpactDetectionEventForce_A43428.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_ED3:
			this.HLinkEmergencyWideImpactDetection = (global::System.Windows.Documents.Hyperlink)target;
			this.HLinkEmergencyWideImpactDetection.Click += this.HLinkClick;
			return;
			IL_EF7:
			this.EmerWideGeneralEmergencyAlarmRxIndicatorType_A7933Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_F04:
			this.EmerWideGeneralSuppressEmergencyCall_A42142 = (global::AcpUI.AcpCheckBox)target;
			this.EmerWideGeneralSuppressEmergencyCall_A42142.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_F28:
			this.EmerWideGeneralSilentAlarm_A9130Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_F35:
			this.ExpanderEmergencyWideManDown = (global::AcpUI.AcpExpander)target;
			return;
			IL_F42:
			this.MyStackPanel = (global::System.Windows.Controls.StackPanel)target;
			return;
			IL_F4F:
			this.EmerWideImpactDetectionPostAlertTimer_A43382Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_F5C:
			this.RTDBtnEmerWideImpactDetectionPreAlertTimer_A43381 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_F69:
			this.LblEmerWideManDownPostAlertTimer_A40004 = (global::AcpUI.AcpLabel)target;
			this.LblEmerWideManDownPostAlertTimer_A40004.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_F8D:
			this.EmerWidePostAlertTone_A41191Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_F9A:
			this.EmerWideManDownPostAlertTimer_A40004 = (global::AcpUI.AcpTextBoxSpinner)target;
			this.EmerWideManDownPostAlertTimer_A40004.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_FBE:
			this.CVBtnEmerWideGeneralEmergencyPowerUp_A7942 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_FCB:
			this.CpyBtnEmerWideImpactDetectionEventForce_A43428 = (global::AcpUI.AcpCopyButton)target;
		}

		// Token: 0x04004B34 RID: 19252
		private bool a;

		// Token: 0x04004B35 RID: 19253
		internal global::AcpUI.Common.AcpThemeBase ThemeBaseObj;

		// Token: 0x04004B36 RID: 19254
		internal global::System.Windows.Documents.Hyperlink HLinkGeneral;

		// Token: 0x04004B37 RID: 19255
		internal global::System.Windows.Documents.Hyperlink HLinkManDown;

		// Token: 0x04004B38 RID: 19256
		internal global::System.Windows.Documents.Hyperlink HLinkEmergencyToneTrigger;

		// Token: 0x04004B39 RID: 19257
		internal global::System.Windows.Documents.Hyperlink HLinkEmergencyWideImpactDetection;

		// Token: 0x04004B3A RID: 19258
		internal global::System.Windows.Controls.StackPanel MyStackPanel;

		// Token: 0x04004B3B RID: 19259
		internal global::AcpUI.AcpExpander ExpanderEmergencyWideGeneral;

		// Token: 0x04004B3C RID: 19260
		internal global::AcpUI.AcpGroupBox GrpBoxExpanderEmergencyWideGeneralPseudo0;

		// Token: 0x04004B3D RID: 19261
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnEmerWideGeneralEmergencyAlarmRxIndicatorType_A7933;

		// Token: 0x04004B3E RID: 19262
		internal global::AcpUI.AcpLabel LblEmerWideGeneralEmergencyAlarmRxIndicatorType_A7933;

		// Token: 0x04004B3F RID: 19263
		internal global::AcpUI.AcpComboBox EmerWideGeneralEmergencyAlarmRxIndicatorType_A7933;

		// Token: 0x04004B40 RID: 19264
		internal global::AcpUI.AcpRtdButton RTDBtnEmerWideGeneralEmergencyAlarmRxIndicatorType_A7933;

		// Token: 0x04004B41 RID: 19265
		internal global::AcpUI.AcpCopyButton CpyBtnEmerWideGeneralEmergencyAlarmRxIndicatorType_A7933;

		// Token: 0x04004B42 RID: 19266
		internal global::AcpUI.AcpLabel EmerWideGeneralEmergencyAlarmRxIndicatorType_A7933Comp;

		// Token: 0x04004B43 RID: 19267
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnEmerWideGeneralKeepAlive_A8360;

		// Token: 0x04004B44 RID: 19268
		internal global::AcpUI.AcpLabel LblEmerWideGeneralKeepAlive_A8360;

		// Token: 0x04004B45 RID: 19269
		internal global::AcpUI.AcpCheckBox EmerWideGeneralKeepAlive_A8360;

		// Token: 0x04004B46 RID: 19270
		internal global::AcpUI.AcpRtdButton RTDBtnEmerWideGeneralKeepAlive_A8360;

		// Token: 0x04004B47 RID: 19271
		internal global::AcpUI.AcpCopyButton CpyBtnEmerWideGeneralKeepAlive_A8360;

		// Token: 0x04004B48 RID: 19272
		internal global::AcpUI.AcpCheckBox EmerWideGeneralKeepAlive_A8360Comp;

		// Token: 0x04004B49 RID: 19273
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnEmerWideGeneralSilentAlarm_A9130;

		// Token: 0x04004B4A RID: 19274
		internal global::AcpUI.AcpLabel LblEmerWideGeneralSilentAlarm_A9130;

		// Token: 0x04004B4B RID: 19275
		internal global::AcpUI.AcpCheckBox EmerWideGeneralSilentAlarm_A9130;

		// Token: 0x04004B4C RID: 19276
		internal global::AcpUI.AcpRtdButton RTDBtnEmerWideGeneralSilentAlarm_A9130;

		// Token: 0x04004B4D RID: 19277
		internal global::AcpUI.AcpCopyButton CpyBtnEmerWideGeneralSilentAlarm_A9130;

		// Token: 0x04004B4E RID: 19278
		internal global::AcpUI.AcpCheckBox EmerWideGeneralSilentAlarm_A9130Comp;

		// Token: 0x04004B4F RID: 19279
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnEmerWideGeneralSuppressEmergencyCall_A42142;

		// Token: 0x04004B50 RID: 19280
		internal global::AcpUI.AcpLabel LblEmerWideGeneralSuppressEmergencyCall_A42142;

		// Token: 0x04004B51 RID: 19281
		internal global::AcpUI.AcpCheckBox EmerWideGeneralSuppressEmergencyCall_A42142;

		// Token: 0x04004B52 RID: 19282
		internal global::AcpUI.AcpRtdButton RTDBtnEmerWideGeneralSuppressEmergencyCall_A42142;

		// Token: 0x04004B53 RID: 19283
		internal global::AcpUI.AcpCopyButton CpyBtnEmerWideGeneralSuppressEmergencyCall_A42142;

		// Token: 0x04004B54 RID: 19284
		internal global::AcpUI.AcpCheckBox EmerWideGeneralSuppressEmergencyCall_A42142Comp;

		// Token: 0x04004B55 RID: 19285
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnEmerWideGeneralUnmuteOption_A9598;

		// Token: 0x04004B56 RID: 19286
		internal global::AcpUI.AcpLabel LblEmerWideGeneralUnmuteOption_A9598;

		// Token: 0x04004B57 RID: 19287
		internal global::AcpUI.AcpCheckBox EmerWideGeneralUnmuteOption_A9598;

		// Token: 0x04004B58 RID: 19288
		internal global::AcpUI.AcpRtdButton RTDBtnEmerWideGeneralUnmuteOption_A9598;

		// Token: 0x04004B59 RID: 19289
		internal global::AcpUI.AcpCopyButton CpyBtnEmerWideGeneralUnmuteOption_A9598;

		// Token: 0x04004B5A RID: 19290
		internal global::AcpUI.AcpCheckBox EmerWideGeneralUnmuteOption_A9598Comp;

		// Token: 0x04004B5B RID: 19291
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnEmerWideGeneralChannelDelaysec_A7657;

		// Token: 0x04004B5C RID: 19292
		internal global::AcpUI.AcpLabel LblEmerWideGeneralChannelDelaysec_A7657;

		// Token: 0x04004B5D RID: 19293
		internal global::AcpUI.AcpTextBoxSpinner EmerWideGeneralChannelDelaysec_A7657;

		// Token: 0x04004B5E RID: 19294
		internal global::AcpUI.AcpRtdButton RTDBtnEmerWideGeneralChannelDelaysec_A7657;

		// Token: 0x04004B5F RID: 19295
		internal global::AcpUI.AcpCopyButton CpyBtnEmerWideGeneralChannelDelaysec_A7657;

		// Token: 0x04004B60 RID: 19296
		internal global::AcpUI.AcpLabel EmerWideGeneralChannelDelaysec_A7657Comp;

		// Token: 0x04004B61 RID: 19297
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnEmerWideGeneralEmergencyPowerUp_A7942;

		// Token: 0x04004B62 RID: 19298
		internal global::AcpUI.AcpLabel LblEmerWideGeneralEmergencyPowerUp_A7942;

		// Token: 0x04004B63 RID: 19299
		internal global::AcpUI.AcpCheckBox EmerWideGeneralEmergencyPowerUp_A7942;

		// Token: 0x04004B64 RID: 19300
		internal global::AcpUI.AcpRtdButton RTDBtnEmerWideGeneralEmergencyPowerUp_A7942;

		// Token: 0x04004B65 RID: 19301
		internal global::AcpUI.AcpCopyButton CpyBtnEmerWideGeneralEmergencyPowerUp_A7942;

		// Token: 0x04004B66 RID: 19302
		internal global::AcpUI.AcpCheckBox EmerWideGeneralEmergencyPowerUp_A7942Comp;

		// Token: 0x04004B67 RID: 19303
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnEmerWideGeneralEmergencyCallReceive_A7937;

		// Token: 0x04004B68 RID: 19304
		internal global::AcpUI.AcpLabel LblEmerWideGeneralEmergencyCallReceive_A7937;

		// Token: 0x04004B69 RID: 19305
		internal global::AcpUI.AcpCheckBox EmerWideGeneralEmergencyCallReceive_A7937;

		// Token: 0x04004B6A RID: 19306
		internal global::AcpUI.AcpRtdButton RTDBtnEmerWideGeneralEmergencyCallReceive_A7937;

		// Token: 0x04004B6B RID: 19307
		internal global::AcpUI.AcpCopyButton CpyBtnEmerWideGeneralEmergencyCallReceive_A7937;

		// Token: 0x04004B6C RID: 19308
		internal global::AcpUI.AcpCheckBox EmerWideGeneralEmergencyCallReceive_A7937Comp;

		// Token: 0x04004B6D RID: 19309
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnEmerWideGeneralDistinguishEmergencyType_43546;

		// Token: 0x04004B6E RID: 19310
		internal global::AcpUI.AcpLabel LblEmerWideGeneralDistinguishEmergencyType_43546;

		// Token: 0x04004B6F RID: 19311
		internal global::AcpUI.AcpCheckBox EmerWideGeneralDistinguishEmergencyType_43546;

		// Token: 0x04004B70 RID: 19312
		internal global::AcpUI.AcpRtdButton RTDBtnEmerWideGeneralDistinguishEmergencyType_43546;

		// Token: 0x04004B71 RID: 19313
		internal global::AcpUI.AcpCopyButton CpyBtnEmerWideGeneralDistinguishEmergencyType_43546;

		// Token: 0x04004B72 RID: 19314
		internal global::AcpUI.AcpCheckBox EmerWideGeneralDistinguishEmergencyType_43546Comp;

		// Token: 0x04004B73 RID: 19315
		internal global::AcpUI.AcpExpander ExpanderEmergencyWideManDown;

		// Token: 0x04004B74 RID: 19316
		internal global::AcpUI.AcpGroupBox GrpBoxExpanderEmergencyWideManDownPseudo0;

		// Token: 0x04004B75 RID: 19317
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnEmerWideManDownTrigger_A40001;

		// Token: 0x04004B76 RID: 19318
		internal global::AcpUI.AcpLabel LblEmerWideManDownTrigger_A40001;

		// Token: 0x04004B77 RID: 19319
		internal global::AcpUI.AcpComboBox EmerWideManDownTrigger_A40001;

		// Token: 0x04004B78 RID: 19320
		internal global::AcpUI.AcpRtdButton RTDBtnEmerWideManDownTrigger_A40001;

		// Token: 0x04004B79 RID: 19321
		internal global::AcpUI.AcpCopyButton CpyBtnEmerWideManDownTrigger_A40001;

		// Token: 0x04004B7A RID: 19322
		internal global::AcpUI.AcpLabel EmerWideManDownTrigger_A40001Comp;

		// Token: 0x04004B7B RID: 19323
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnEmerWideManDownMotionlessSensitivity_A40002;

		// Token: 0x04004B7C RID: 19324
		internal global::AcpUI.AcpLabel LblEmerWideManDownMotionlessSensitivity_A40002;

		// Token: 0x04004B7D RID: 19325
		internal global::AcpUI.AcpComboBox EmerWideManDownMotionlessSensitivity_A40002;

		// Token: 0x04004B7E RID: 19326
		internal global::AcpUI.AcpRtdButton RTDBtnEmerWideManDownMotionlessSensitivity_A40002;

		// Token: 0x04004B7F RID: 19327
		internal global::AcpUI.AcpCopyButton CpyBtnEmerWideManDownMotionlessSensitivity_A40002;

		// Token: 0x04004B80 RID: 19328
		internal global::AcpUI.AcpLabel EmerWideManDownMotionlessSensitivity_A40002Comp;

		// Token: 0x04004B81 RID: 19329
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnEmerWideManDownPreAlertTimer_A40003;

		// Token: 0x04004B82 RID: 19330
		internal global::AcpUI.AcpLabel LblEmerWideManDownPreAlertTimer_A40003;

		// Token: 0x04004B83 RID: 19331
		internal global::AcpUI.AcpTextBoxSpinner EmerWideManDownPreAlertTimer_A40003;

		// Token: 0x04004B84 RID: 19332
		internal global::AcpUI.AcpRtdButton RTDBtnEmerWideManDownPreAlertTimer_A40003;

		// Token: 0x04004B85 RID: 19333
		internal global::AcpUI.AcpCopyButton CpyBtnEmerWideManDownPreAlertTimer_A40003;

		// Token: 0x04004B86 RID: 19334
		internal global::AcpUI.AcpLabel EmerWideManDownPreAlertTimer_A40003Comp;

		// Token: 0x04004B87 RID: 19335
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnEmerWideManDownPostAlertTimer_A40004;

		// Token: 0x04004B88 RID: 19336
		internal global::AcpUI.AcpLabel LblEmerWideManDownPostAlertTimer_A40004;

		// Token: 0x04004B89 RID: 19337
		internal global::AcpUI.AcpTextBoxSpinner EmerWideManDownPostAlertTimer_A40004;

		// Token: 0x04004B8A RID: 19338
		internal global::AcpUI.AcpRtdButton RTDBtnEmerWideManDownPostAlertTimer_A40004;

		// Token: 0x04004B8B RID: 19339
		internal global::AcpUI.AcpCopyButton CpyBtnEmerWideManDownPostAlertTimer_A40004;

		// Token: 0x04004B8C RID: 19340
		internal global::AcpUI.AcpLabel EmerWideManDownPostAlertTimer_A40004Comp;

		// Token: 0x04004B8D RID: 19341
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnEmerWidePostAlertTone_A41191;

		// Token: 0x04004B8E RID: 19342
		internal global::AcpUI.AcpLabel LblEmerWidePostAlertTone_A41191;

		// Token: 0x04004B8F RID: 19343
		internal global::AcpUI.AcpComboBox EmerWidePostAlertTone_A41191;

		// Token: 0x04004B90 RID: 19344
		internal global::AcpUI.AcpRtdButton RTDBtnEmerWidePostAlertTone_A41191;

		// Token: 0x04004B91 RID: 19345
		internal global::AcpUI.AcpCopyButton CpyBtnEmerWidePostAlertTone_A41191;

		// Token: 0x04004B92 RID: 19346
		internal global::AcpUI.AcpLabel EmerWidePostAlertTone_A41191Comp;

		// Token: 0x04004B93 RID: 19347
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnManDownConfigurabilityGranularityLevel_42057;

		// Token: 0x04004B94 RID: 19348
		internal global::AcpUI.AcpLabel LblManDownConfigurabilityGranularityLevel_42057;

		// Token: 0x04004B95 RID: 19349
		internal global::AcpUI.AcpComboBox ManDownConfigurabilityGranularityLevel_42057;

		// Token: 0x04004B96 RID: 19350
		internal global::AcpUI.AcpRtdButton RTDBtnManDownConfigurabilityGranularityLevel_42057;

		// Token: 0x04004B97 RID: 19351
		internal global::AcpUI.AcpCopyButton CpyBtnManDownConfigurabilityGranularityLevel_42057;

		// Token: 0x04004B98 RID: 19352
		internal global::AcpUI.AcpLabel ManDownConfigurabilityGranularityLevel_42057Comp;

		// Token: 0x04004B99 RID: 19353
		internal global::AcpUI.AcpExpander ExpanderEmergencyWideEmergencyToneTrigger;

		// Token: 0x04004B9A RID: 19354
		internal global::AcpUI.AcpGroupBox GrpBoxExpanderEmergencyWideEmergencyToneTriggerCustomizableTonesPerEmergencyProfile;

		// Token: 0x04004B9B RID: 19355
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnTriggedByManDown_42135;

		// Token: 0x04004B9C RID: 19356
		internal global::AcpUI.AcpLabel LblTriggedByManDown_42135;

		// Token: 0x04004B9D RID: 19357
		internal global::AcpUI.AcpCheckBox TriggedByManDown_42135;

		// Token: 0x04004B9E RID: 19358
		internal global::AcpUI.AcpRtdButton RTDBtnTriggedByManDown_42135;

		// Token: 0x04004B9F RID: 19359
		internal global::AcpUI.AcpCopyButton CpyBtnTriggedByManDown_42135;

		// Token: 0x04004BA0 RID: 19360
		internal global::AcpUI.AcpCheckBox TriggedByManDown_42135Comp;

		// Token: 0x04004BA1 RID: 19361
		internal global::AcpUI.AcpExpander ExpanderEmergencyWideEmergencyWideImpactDetection;

		// Token: 0x04004BA2 RID: 19362
		internal global::AcpUI.AcpGroupBox GrpBoxExpanderEmergencyWideEmergencyWideImpactDetectionPseudo0;

		// Token: 0x04004BA3 RID: 19363
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnEmerWideImpactDetectionConfigLevel_A43384;

		// Token: 0x04004BA4 RID: 19364
		internal global::AcpUI.AcpLabel LblEmerWideImpactDetectionConfigLevel_A43384;

		// Token: 0x04004BA5 RID: 19365
		internal global::AcpUI.AcpComboBox EmerWideImpactDetectionConfigLevel_A43384;

		// Token: 0x04004BA6 RID: 19366
		internal global::AcpUI.AcpRtdButton RTDBtnEmerWideImpactDetectionConfigLevel_A43384;

		// Token: 0x04004BA7 RID: 19367
		internal global::AcpUI.AcpCopyButton CpyBtnEmerWideImpactDetectionConfigLevel_A43384;

		// Token: 0x04004BA8 RID: 19368
		internal global::AcpUI.AcpLabel EmerWideImpactDetectionConfigLevel_A43384Comp;

		// Token: 0x04004BA9 RID: 19369
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnEmerWideImpDectToneTrigger_A43386;

		// Token: 0x04004BAA RID: 19370
		internal global::AcpUI.AcpLabel LblEmerWideImpDectToneTrigger_A43386;

		// Token: 0x04004BAB RID: 19371
		internal global::AcpUI.AcpCheckBox EmerWideImpDectToneTrigger_A43386;

		// Token: 0x04004BAC RID: 19372
		internal global::AcpUI.AcpRtdButton RTDBtnEmerWideImpDectToneTrigger_A43386;

		// Token: 0x04004BAD RID: 19373
		internal global::AcpUI.AcpCopyButton CpyBtnEmerWideImpDectToneTrigger_A43386;

		// Token: 0x04004BAE RID: 19374
		internal global::AcpUI.AcpCheckBox EmerWideImpDectToneTrigger_A43386Comp;

		// Token: 0x04004BAF RID: 19375
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnEmerWideImpactDetectionPreAlertTimer_A43381;

		// Token: 0x04004BB0 RID: 19376
		internal global::AcpUI.AcpLabel LblEmerWideImpactDetectionPreAlertTimer_A43381;

		// Token: 0x04004BB1 RID: 19377
		internal global::AcpUI.AcpTextBoxSpinner EmerWideImpactDetectionPreAlertTimer_A43381;

		// Token: 0x04004BB2 RID: 19378
		internal global::AcpUI.AcpRtdButton RTDBtnEmerWideImpactDetectionPreAlertTimer_A43381;

		// Token: 0x04004BB3 RID: 19379
		internal global::AcpUI.AcpCopyButton CpyBtnEmerWideImpactDetectionPreAlertTimer_A43381;

		// Token: 0x04004BB4 RID: 19380
		internal global::AcpUI.AcpLabel EmerWideImpactDetectionPreAlertTimer_A43381Comp;

		// Token: 0x04004BB5 RID: 19381
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnEmerWideImpactDetectionPostAlertTimer_A43382;

		// Token: 0x04004BB6 RID: 19382
		internal global::AcpUI.AcpLabel LblEmerWideImpactDetectionPostAlertTimer_A43382;

		// Token: 0x04004BB7 RID: 19383
		internal global::AcpUI.AcpTextBoxSpinner EmerWideImpactDetectionPostAlertTimer_A43382;

		// Token: 0x04004BB8 RID: 19384
		internal global::AcpUI.AcpRtdButton RTDBtnEmerWideImpactDetectionPostAlertTimer_A43382;

		// Token: 0x04004BB9 RID: 19385
		internal global::AcpUI.AcpCopyButton CpyBtnEmerWideImpactDetectionPostAlertTimer_A43382;

		// Token: 0x04004BBA RID: 19386
		internal global::AcpUI.AcpLabel EmerWideImpactDetectionPostAlertTimer_A43382Comp;

		// Token: 0x04004BBB RID: 19387
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnEmerWideImpactDetectionPreAlertTone_A43383;

		// Token: 0x04004BBC RID: 19388
		internal global::AcpUI.AcpLabel LblEmerWideImpactDetectionPreAlertTone_A43383;

		// Token: 0x04004BBD RID: 19389
		internal global::AcpUI.AcpComboBox EmerWideImpactDetectionPreAlertTone_A43383;

		// Token: 0x04004BBE RID: 19390
		internal global::AcpUI.AcpRtdButton RTDBtnEmerWideImpactDetectionPreAlertTone_A43383;

		// Token: 0x04004BBF RID: 19391
		internal global::AcpUI.AcpCopyButton CpyBtnEmerWideImpactDetectionPreAlertTone_A43383;

		// Token: 0x04004BC0 RID: 19392
		internal global::AcpUI.AcpLabel EmerWideImpactDetectionPreAlertTone_A43383Comp;

		// Token: 0x04004BC1 RID: 19393
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnEmerWideImpactDetectionEventDuration_A43427;

		// Token: 0x04004BC2 RID: 19394
		internal global::AcpUI.AcpLabel LblEmerWideImpactDetectionEventDuration_A43427;

		// Token: 0x04004BC3 RID: 19395
		internal global::AcpUI.AcpTextBoxSpinner EmerWideImpactDetectionEventDuration_A43427;

		// Token: 0x04004BC4 RID: 19396
		internal global::AcpUI.AcpRtdButton RTDBtnEmerWideImpactDetectionEventDuration_A43427;

		// Token: 0x04004BC5 RID: 19397
		internal global::AcpUI.AcpCopyButton CpyBtnEmerWideImpactDetectionEventDuration_A43427;

		// Token: 0x04004BC6 RID: 19398
		internal global::AcpUI.AcpLabel EmerWideImpactDetectionEventDuration_A43427Comp;

		// Token: 0x04004BC7 RID: 19399
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnEmerWideImpactDetectionEventForce_A43428;

		// Token: 0x04004BC8 RID: 19400
		internal global::AcpUI.AcpLabel LblEmerWideImpactDetectionEventForce_A43428;

		// Token: 0x04004BC9 RID: 19401
		internal global::AcpUI.AcpTextBoxSpinner EmerWideImpactDetectionEventForce_A43428;

		// Token: 0x04004BCA RID: 19402
		internal global::AcpUI.AcpRtdButton RTDBtnEmerWideImpactDetectionEventForce_A43428;

		// Token: 0x04004BCB RID: 19403
		internal global::AcpUI.AcpCopyButton CpyBtnEmerWideImpactDetectionEventForce_A43428;

		// Token: 0x04004BCC RID: 19404
		internal global::AcpUI.AcpLabel EmerWideImpactDetectionEventForce_A43428Comp;

		// Token: 0x04004BCD RID: 19405
		private bool b;
	}
}
