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
using AcpUILib;
using AllFeatures;

namespace Motorola.MackinawCPS.CoreFeatures.InternalMicNoiseReductionProfile
{
	// Token: 0x02000253 RID: 595
	public class PageInternalMicNoiseReductionProfile : global::AcpUI.AcpPageFeature, global::System.Windows.Markup.IComponentConnector
	{
		// Token: 0x06006AFD RID: 27389 RVA: 0x005F7938 File Offset: 0x005F5B38
		public PageInternalMicNoiseReductionProfile()
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

		// Token: 0x06006AFE RID: 27390 RVA: 0x005F7970 File Offset: 0x005F5B70
		public override void OnLoaded(object sender, global::System.Windows.RoutedEventArgs e)
		{
			short num = (short)1266679808;
			short num2 = num;
			num = (short)42467331;
			int num3 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				global::System.Collections.IEnumerator enumerator;
				global::AcpUI.AcpExpander acpExpander;
				switch (num3)
				{
				case 0:
					try
					{
						num = (short)1595179496;
						short num4 = num;
						num = (short)1393983976;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							IL_1B1:
							num = (short)916127748;
							num3 = (int)((global::System.IntPtr)num);
							break;
						default:
							num = (short)1677262848;
							if (num != 0)
							{
							}
							num = (short)1237254145;
							num3 = (int)((global::System.IntPtr)num);
							break;
						}
						for (;;)
						{
							switch (num3)
							{
							case 0:
								goto IL_1B1;
							case 1:
								switch (0)
								{
								case 0:
									goto IL_13B;
								}
								continue;
							case 3:
								if (!enumerator.MoveNext())
								{
									num = (short)1126301696;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								acpExpander = (((global::System.Windows.UIElement)enumerator.Current) as global::AcpUI.AcpExpander);
								num = (short)1394868230;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							case 4:
								goto IL_1F0;
							case 5:
								base.Expanders.Add(acpExpander);
								num = (short)539230210;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							case 6:
								if (acpExpander != null)
								{
									num = (short)1385299973;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							}
							IL_17C:
							num = (short)838336515;
							num3 = (int)((global::System.IntPtr)num);
							continue;
							IL_13B:
							goto IL_17C;
						}
						IL_1F0:
						goto IL_293;
					}
					finally
					{
						switch (0)
						{
						case 0:
							goto IL_211;
						}
						global::System.IDisposable disposable;
						for (;;)
						{
							IL_1FF:
							switch (num3)
							{
							case 0:
								disposable.Dispose();
								num = (short)2057175041;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							case 1:
								goto IL_261;
							case 2:
								if (disposable != null)
								{
									num = (short)154664960;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_263;
							}
							goto IL_211;
						}
						IL_261:
						IL_263:
						goto EndFinally_7;
						IL_211:
						disposable = (enumerator as global::System.IDisposable);
						num = (short)315424770;
						num3 = (int)((global::System.IntPtr)num);
						goto IL_1FF;
						EndFinally_7:;
					}
					goto IL_264;
					IL_293:
					base.OnLoaded(sender, e);
					this.a = true;
					num = (short)808910849;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					goto IL_2B9;
				case 2:
					goto IL_264;
				case 3:
					switch (0)
					{
					case 0:
						goto IL_60;
					}
					continue;
				}
				IL_60:
				if (!this.a)
				{
					num = (short)256442369;
					if (num != 0)
					{
					}
					num = (short)177602562;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_264:
				acpExpander = null;
				enumerator = this.MyStackPanel.Children.GetEnumerator();
				num = (short)460980224;
				num3 = (int)((global::System.IntPtr)num);
			}
			IL_2B9:
			this.MyStackPanel.Children[0].Focus();
		}

		// Token: 0x06006AFF RID: 27391 RVA: 0x005F7C6C File Offset: 0x005F5E6C
		public override void OnUnloaded(object sender, global::System.Windows.RoutedEventArgs e)
		{
			short num = (short)1696071680;
			short num2 = num;
			num = (short)243990530;
			int num3 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num3)
				{
				case 0:
				{
					num = (short)1687957786;
					short num4 = num;
					num = (short)1517564186;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						return;
					default:
						num = (short)725549056;
						if (num != 0)
						{
						}
						base.OnUnloaded(sender, e);
						this.a = false;
						num = (short)1610153985;
						if (num != 0)
						{
						}
						num = (short)1452539905;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 1:
					return;
				case 2:
					switch (0)
					{
					case 0:
						goto IL_5A;
					}
					continue;
				}
				IL_5A:
				if (!this.a)
				{
					break;
				}
				num = (short)1845166080;
				num3 = (int)((global::System.IntPtr)num);
			}
		}

		// Token: 0x06006B00 RID: 27392 RVA: 0x005F7D94 File Offset: 0x005F5F94
		public override void SetDataContext()
		{
			short num = (short)341639169;
			int num2 = (int)((global::System.IntPtr)num);
			object feature;
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_19C;
				case 1:
					switch (0)
					{
					case 0:
						goto IL_48;
					}
					continue;
				case 2:
				{
					if (global::AcpCommonLib.AppInfoManager.AppMode != global::AcpCommonLib.ApplicationMode.CodeplugComparisonMode)
					{
						((global::AcpUILib.IAcpRecNavToolbar)this.RecNavToolbarPageInternalMicNoiseReductionProfile).MySecondaryRecordsetDataSource = null;
						num = (short)1502281728;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1289553538;
					short num3 = num;
					num = (short)252839554;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_220;
					default:
						num = (short)649461760;
						if (num != 0)
						{
						}
						num = (short)1055588359;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 3:
					num = (short)1091239937;
					if (num != 0)
					{
					}
					goto IL_A7;
				case 4:
					goto IL_220;
				case 5:
					goto IL_A7;
				case 6:
					goto IL_23B;
				case 7:
					feature = global::AcpCommonLib.AppInfoManager.ComparatorDocument.GetFeature(2086);
					num = (short)441057284;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 8:
					base.DataContext = global::AcpCommonLib.AppInfoManager.DefaultDocument.GetFeature(2086);
					num = (short)1132199941;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_48:
				if (global::AcpCommonLib.AppInfoManager.AppMode == global::AcpCommonLib.ApplicationMode.CustomViewConfigurationMode)
				{
					num = (short)1931411456;
					short num4 = num;
					num = (short)2117009416;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				base.DataContext = global::AcpCommonLib.FeatureManager.GetFeature(2086);
				num = (short)1485373443;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_A7:
				this.RecNavToolbarPageInternalMicNoiseReductionProfile.DataContext = (global::AcpCommonLib.IAcpRecordset)base.DataContext;
				num = (short)506527746;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_220:
				if (feature == null)
				{
					break;
				}
				num = (short)1419051014;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_19C:
			return;
			IL_23B:
			((global::AcpUILib.IAcpRecNavToolbar)this.RecNavToolbarPageInternalMicNoiseReductionProfile).MySecondaryRecordsetDataSource = (global::AcpCommonLib.IAcpRecordset)feature;
		}

		// Token: 0x06006B01 RID: 27393 RVA: 0x005F7FE4 File Offset: 0x005F61E4
		private void OnModeClick(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			int a_ = 13;
			for (;;)
			{
				IL_09:
				short num = (short)522649601;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
					{
						num = (short)406202223;
						short num3 = num;
						num = (short)270411631;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_09;
						default:
						{
							num = (short)1574174721;
							if (num != 0)
							{
							}
							num = (short)670892032;
							if (num != 0)
							{
							}
							global::AcpCommonLib.IAcpRecordset myRecordsetDataSource;
							base.NavigationService.Navigate(new global::System.Uri(myRecordsetDataSource.UIPagePath, global::System.UriKind.RelativeOrAbsolute));
							num = (short)1719533573;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						break;
					}
					case 1:
						switch (0)
						{
						case 0:
							goto IL_49;
						}
						continue;
					case 2:
					{
						num = (short)237174784;
						short num4 = num;
						if (((global::AcpUI.AcpRecNavToolbar)A_0).Name == global::AllFeatures.CodeplugGuid.b("鳍뗏뇑髓럕껗軙돛뇝賟胡藣铥룧诩诫语맯鳱胳鏵諷铹鷻鋽䷿欁會䠅朇按缋欍䈏眑瀓挕笗渙甛焝丟爡嘣䤥丧䌩䀫䬭", a_))
						{
							num = (short)1580204036;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					}
					case 3:
					{
						global::AcpCommonLib.IAcpRecordset myRecordsetDataSource;
						if (myRecordsetDataSource != null)
						{
							num = (short)1304363008;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					}
					case 4:
					{
						global::AcpCommonLib.IAcpRecordset myRecordsetDataSource = this.RecNavToolbarPageInternalMicNoiseReductionProfile.MyRecordsetDataSource;
						num = (short)61603843;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 5:
						return;
					case 6:
						num = (short)291241986;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_49:
					if (!(A_0 is global::AcpUI.AcpRecNavToolbar))
					{
						return;
					}
					num = (short)550109190;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
		}

		// Token: 0x06006B02 RID: 27394 RVA: 0x005F81C4 File Offset: 0x005F63C4
		private void HLinkClick(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num = (short)898891777;
			if (num != 0)
			{
			}
			num = (short)1006312760;
			short num2 = num;
			num = (short)333454648;
			switch (num2 == num)
			{
			default:
			{
				num = (short)2106916864;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)2064842752;
			if (num != 0)
			{
			}
			base.OnHLinkClick(A_0);
		}

		// Token: 0x06006B03 RID: 27395 RVA: 0x005F8278 File Offset: 0x005F6478
		private void OnFieldNameDoubleClick(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num = (short)623924888;
			short num2 = num;
			num = (short)419518104;
			switch (num2 == num)
			{
			}
			num = (short)971571200;
			short num3 = num;
			num = (short)1453719553;
			if (num != 0)
			{
			}
			num = (short)1862664192;
			if (num != 0)
			{
			}
			global::AcpUI.Common.Utility.GetFieldHelpText(A_0);
		}

		// Token: 0x06006B04 RID: 27396 RVA: 0x005F832C File Offset: 0x005F652C
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "5.0.10.0")]
		[global::System.Diagnostics.DebuggerNonUserCode]
		public void InitializeComponent()
		{
			int a_ = 4;
			short num = (short)1092943872;
			short num2 = num;
			if (this.b)
			{
				num = (short)119692614;
				short num3 = num;
				num = (short)195452230;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)2027094017;
					if (num != 0)
					{
					}
					num = (short)1971650560;
					if (num != 0)
					{
					}
					return;
				}
			}
			this.b = true;
			global::System.Uri resourceLocator = new global::System.Uri(global::AllFeatures.CodeplugGuid.b("蛆ꗈꟊ诌꫎냐꟒ꃔꗖ볘꣚볞軠転闤裦蟨軪菬鯮\udef0臲铴鏶郸铺\ud8fc췾㄀昂眄怆昈攊戌戎砐瀒昔㈖⬘⬚縜瀞传䔢䰤䀦尨太䰬嬮堰尲嬴ᠶ圸吺吼䰾⑀時睄睆㭈⹊⥌㩎㉐❒㱔㡖㝘繚潜潞ɠౢ୤Ŧh౪ᡬᵮၰݲᱴᡶ᝸呺ᑼᅾꢌ붎ꆐﺒﲔ벘ꦚ궜캠쪢횤슦貨馪鶬\uddae풰ힲ살풶춸튺튼톾럆믈꓊ꯌꛎ뷐뛒䀹뻖럘꿚룜귞迠苢觤諦胨裪菬胮飰胲郴藶鳸鿺裼鳾甀樂樄椆礈礊戌椎砐缒瀔㤖愘稚瀜猞", a_), global::System.UriKind.Relative);
			global::System.Windows.Application.LoadComponent(this, resourceLocator);
		}

		// Token: 0x06006B05 RID: 27397 RVA: 0x005F840C File Offset: 0x005F660C
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::System.Diagnostics.DebuggerNonUserCode]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "5.0.10.0")]
		void global::System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
		{
			short num = (short)482148354;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_405;
				case 1:
					num = (short)1429733376;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					switch (0)
					{
					case 0:
						goto IL_30;
					}
					continue;
				}
				IL_30:
				switch (connectionId)
				{
				case 1:
					goto IL_8FF;
				case 2:
					goto IL_930;
				case 3:
					goto IL_5F7;
				case 4:
					goto IL_557;
				case 5:
					goto IL_82E;
				case 6:
					goto IL_E8C;
				case 7:
					goto IL_B73;
				case 8:
					goto IL_EE1;
				case 9:
					goto IL_C82;
				case 10:
					goto IL_BD8;
				case 11:
					goto IL_666;
				case 12:
					goto IL_E4E;
				case 13:
					goto IL_814;
				case 14:
					goto IL_CA6;
				case 15:
					goto IL_E99;
				case 16:
					goto IL_E2A;
				case 17:
					goto IL_83B;
				case 18:
					goto IL_821;
				case 19:
					goto IL_730;
				case 20:
					goto IL_32E;
				case 21:
					goto IL_61E;
				case 22:
					goto IL_CB3;
				case 23:
					goto IL_5EA;
				case 24:
					goto IL_42E;
				case 25:
					goto IL_9AC;
				case 26:
					goto IL_673;
				case 27:
					goto IL_6FC;
				case 28:
					goto IL_F12;
				case 29:
					goto IL_40A;
				case 30:
					goto IL_D87;
				case 31:
					goto IL_D2F;
				case 32:
					goto IL_2FD;
				case 33:
					goto IL_4F2;
				case 34:
					goto IL_807;
				case 35:
					goto IL_43B;
				case 36:
					goto IL_38A;
				case 37:
					goto IL_6A4;
				case 38:
					goto IL_611;
				case 39:
					goto IL_53D;
				case 40:
					goto IL_530;
				case 41:
					goto IL_EBD;
				case 42:
					goto IL_B80;
				case 43:
					goto IL_DBB;
				case 44:
					goto IL_523;
				case 45:
					goto IL_A90;
				case 46:
					goto IL_D7A;
				case 47:
					goto IL_9F7;
				case 48:
					goto IL_4CE;
				case 49:
					goto IL_C20;
				case 50:
					goto IL_F81;
				case 51:
					goto IL_588;
				case 52:
					goto IL_97B;
				case 53:
					goto IL_8C1;
				case 54:
					goto IL_716;
				case 55:
					goto IL_5A2;
				case 56:
					goto IL_848;
				case 57:
					goto IL_A9D;
				case 58:
					goto IL_C44;
				case 59:
					goto IL_764;
				case 60:
					goto IL_490;
				case 61:
					goto IL_49D;
				case 62:
					goto IL_DC8;
				case 63:
					goto IL_BCB;
				case 64:
					goto IL_96E;
				case 65:
					goto IL_757;
				case 66:
					goto IL_771;
				case 67:
					goto IL_3DF;
				case 68:
					goto IL_7A5;
				case 69:
					goto IL_E5B;
				case 70:
					goto IL_D3C;
				case 71:
					goto IL_961;
				case 72:
					goto IL_57B;
				case 73:
					goto IL_798;
				case 74:
					goto IL_C5E;
				case 75:
					goto IL_988;
				case 76:
					goto IL_E1D;
				case 77:
					goto IL_BBE;
				case 78:
					goto IL_54A;
				case 79:
					goto IL_D15;
				case 80:
					goto IL_8CE;
				case 81:
					goto IL_EEE;
				case 82:
					goto IL_A5F;
				case 83:
					goto IL_77E;
				case 84:
					goto IL_723;
				case 85:
					goto IL_F50;
				case 86:
					goto IL_7E3;
				case 87:
					goto IL_2D9;
				case 88:
					goto IL_74A;
				case 89:
					goto IL_954;
				case 90:
					goto IL_37D;
				case 91:
					goto IL_7C9;
				case 92:
					goto IL_709;
				case 93:
					goto IL_680;
				case 94:
					goto IL_F5D;
				case 95:
					goto IL_ADE;
				case 96:
					goto IL_D94;
				case 97:
					goto IL_AB7;
				case 98:
					goto IL_4C1;
				case 99:
					goto IL_9D3;
				case 100:
					goto IL_89D;
				case 101:
					goto IL_9C6;
				case 102:
					goto IL_D08;
				case 103:
					goto IL_890;
				case 104:
					goto IL_33B;
				case 105:
					goto IL_B35;
				case 106:
					goto IL_86C;
				case 107:
					goto IL_2B5;
				case 108:
					goto IL_BA4;
				case 109:
					goto IL_AD1;
				case 110:
					goto IL_A52;
				case 111:
					goto IL_AAA;
				case 112:
					goto IL_BFC;
				case 113:
					goto IL_6BE;
				case 114:
					goto IL_595;
				case 115:
					goto IL_73D;
				case 116:
					goto IL_8F2;
				case 117:
					goto IL_B42;
				case 118:
					goto IL_A6C;
				case 119:
					goto IL_642;
				case 120:
					goto IL_7D6;
				case 121:
					goto IL_483;
				case 122:
					goto IL_CD7;
				case 123:
					goto IL_E10;
				case 124:
					goto IL_30A;
				case 125:
					goto IL_4FF;
				case 126:
					goto IL_F8E;
				case 127:
					goto IL_6B1;
				case 128:
					goto IL_6E2;
				case 129:
					goto IL_9B9;
				case 130:
					goto IL_A2E;
				case 131:
					goto IL_5C6;
				case 132:
					goto IL_6EF;
				case 133:
					goto IL_3AE;
				case 134:
					goto IL_F36;
				case 135:
					goto IL_E7F;
				case 136:
					goto IL_45F;
				case 137:
					goto IL_CE4;
				case 138:
					goto IL_348;
				case 139:
					goto IL_AC4;
				case 140:
					goto IL_604;
				case 141:
					goto IL_78B;
				case 142:
					goto IL_D49;
				case 143:
					goto IL_B4F;
				case 144:
					goto IL_DAE;
				case 145:
					goto IL_D22;
				case 146:
					goto IL_BB1;
				case 147:
					goto IL_DA1;
				case 148:
					goto IL_DEC;
				case 149:
					goto IL_3BB;
				case 150:
					goto IL_D6D;
				case 151:
					goto IL_F43;
				case 152:
					goto IL_C51;
				default:
					num = (short)853082113;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
			}
			IL_2B5:
			this.IntMicNsRdGenRADIOAUTONOISEBOUNDSDBQ8_42676 = (global::AcpUI.AcpTextBox)target;
			this.IntMicNsRdGenRADIOAUTONOISEBOUNDSDBQ8_42676.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_2D9:
			this.RadErgoCfgGeneralRTHRESHDBQ8_A21572 = (global::AcpUI.AcpTextBoxSpinnerDecHex)target;
			this.RadErgoCfgGeneralRTHRESHDBQ8_A21572.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_2FD:
			this.RadErgoCfgGeneralDINCABFSS_A21564Comp = (global::AcpUI.AcpTextBoxDecHex)target;
			return;
			IL_30A:
			this.LblIntMicNsRdGenRADIOPASSFILTERSTART_42679 = (global::AcpUI.AcpLabel)target;
			this.LblIntMicNsRdGenRADIOPASSFILTERSTART_42679.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_32E:
			this.CVBtnRadErgoCfgGeneralNBANDS_A21573 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_33B:
			this.GrpBoxExpanderInternalMicNoiseReductionProfileGeneralAdaptiveNoiseSuppression = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_348:
			num = (short)424280065;
			if (num != 0)
			{
			}
			this.RTDBtnIntMicNsRdGenRADIOSAMCUTOVERFREQUENCY_42681 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_37D:
			this.RadErgoCfgGeneralRTHRESHDBQ8_A21572Comp = (global::AcpUI.AcpTextBoxDecHex)target;
			return;
			IL_38A:
			this.RadErgoCfgGeneralMINGAIN_A21562 = (global::AcpUI.AcpTextBoxSpinnerDecHex)target;
			this.RadErgoCfgGeneralMINGAIN_A21562.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_3AE:
			this.CpyBtnIntMicNsRdGenRADIOSAMMIXMODE_42680 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_3BB:
			this.IntMicNsRdGenRADIOHOTBEAMMAXATTENUATIONDBQ8_42683 = (global::AcpUI.AcpTextBoxSpinner)target;
			this.IntMicNsRdGenRADIOHOTBEAMMAXATTENUATIONDBQ8_42683.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_3DF:
			this.CVBtnRadErgoCfgGeneralINACTIVETHRESHDBQ8_A21569 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_405:
			this.b = true;
			return;
			IL_40A:
			this.RadErgoCfgGeneralDINCABFSS_A21564 = (global::AcpUI.AcpTextBoxSpinnerDecHex)target;
			this.RadErgoCfgGeneralDINCABFSS_A21564.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_42E:
			this.CpyBtnRadErgoCfgGeneralNBANDS_A21573 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_43B:
			this.LblRadErgoCfgGeneralMINGAIN_A21562 = (global::AcpUI.AcpLabel)target;
			this.LblRadErgoCfgGeneralMINGAIN_A21562.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_45F:
			this.LblIntMicNsRdGenRADIOSAMCUTOVERFREQUENCY_42681 = (global::AcpUI.AcpLabel)target;
			this.LblIntMicNsRdGenRADIOSAMCUTOVERFREQUENCY_42681.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_483:
			this.CpyBtnIntMicNsRdGenRADIOAUTORELAXTIONBOUNDS_42678 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_490:
			this.CVBtnRadErgoCfgGeneralVADDETCOUNT_A21568 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_49D:
			this.LblRadErgoCfgGeneralVADDETCOUNT_A21568 = (global::AcpUI.AcpLabel)target;
			this.LblRadErgoCfgGeneralVADDETCOUNT_A21568.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_4C1:
			this.CVBtnIntMicNsRdGenDINCEPVECTOR_A37719 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_4CE:
			this.LblRadErgoCfgGeneralHOTBEAMDETTHRESHDBQ8_A21566 = (global::AcpUI.AcpLabel)target;
			this.LblRadErgoCfgGeneralHOTBEAMDETTHRESHDBQ8_A21566.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_4F2:
			this.GrpBoxExpanderInternalMicNoiseReductionProfileGeneralDWF = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_4FF:
			this.IntMicNsRdGenRADIOPASSFILTERSTART_42679 = (global::AcpUI.AcpTextBoxSpinner)target;
			this.IntMicNsRdGenRADIOPASSFILTERSTART_42679.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_523:
			this.CpyBtnRadErgoCfgGeneralEXPANSIONDEGREE_A21563 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_530:
			this.CVBtnRadErgoCfgGeneralEXPANSIONDEGREE_A21563 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_53D:
			this.RadErgoCfgGeneralMINGAIN_A21562Comp = (global::AcpUI.AcpTextBoxDecHex)target;
			return;
			IL_54A:
			this.RadErgoCfgGeneralSDIFFTHRESHDBQ8_A21570Comp = (global::AcpUI.AcpTextBoxDecHex)target;
			return;
			IL_557:
			this.HLinkGeneral = (global::System.Windows.Documents.Hyperlink)target;
			this.HLinkGeneral.Click += this.HLinkClick;
			return;
			IL_57B:
			this.RadErgoCfgGeneralINACTIVETHRESHDBQ8_A21569Comp = (global::AcpUI.AcpTextBoxDecHex)target;
			return;
			IL_588:
			this.CpyBtnRadErgoCfgGeneralHOTBEAMDETTHRESHDBQ8_A21566 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_595:
			this.RTDBtnIntMicNsRdGenRADIOAUTOMINGAINVECTOR_42677 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_5A2:
			this.LblRadErgoCfgGeneralVADDETTHRESHDBQ8_A21567 = (global::AcpUI.AcpLabel)target;
			this.LblRadErgoCfgGeneralVADDETTHRESHDBQ8_A21567.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_5C6:
			this.IntMicNsRdGenRADIOSAMMIXMODE_42680 = (global::AcpUI.AcpTextBoxSpinner)target;
			this.IntMicNsRdGenRADIOSAMMIXMODE_42680.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_5EA:
			this.RTDBtnRadErgoCfgGeneralNBANDS_A21573 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_5F7:
			this.ThemeBaseObj = (global::AcpUI.Common.AcpThemeBase)target;
			return;
			IL_604:
			this.IntMicNsRdGenRADIOSAMCUTOVERFREQUENCY_42681Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_611:
			this.CpyBtnRadErgoCfgGeneralMINGAIN_A21562 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_61E:
			this.LblRadErgoCfgGeneralNBANDS_A21573 = (global::AcpUI.AcpLabel)target;
			this.LblRadErgoCfgGeneralNBANDS_A21573.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_642:
			this.IntMicNsRdGenRADIOAUTORELAXTIONBOUNDS_42678 = (global::AcpUI.AcpTextBox)target;
			this.IntMicNsRdGenRADIOAUTORELAXTIONBOUNDS_42678.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_666:
			this.CpyBtnInternalMicNoiseReductionProfileName_A22535 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_673:
			this.GrpBoxExpanderInternalMicNoiseReductionProfileGeneralPseudo1 = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_680:
			this.LblIntMicNsRdGenDINCOUTPUTEQVECTOR_A37718 = (global::AcpUI.AcpLabel)target;
			this.LblIntMicNsRdGenDINCOUTPUTEQVECTOR_A37718.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_6A4:
			this.RTDBtnRadErgoCfgGeneralMINGAIN_A21562 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_6B1:
			this.CpyBtnIntMicNsRdGenRADIOPASSFILTERSTART_42679 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_6BE:
			this.IntMicNsRdGenRADIOAUTOMINGAINVECTOR_42677 = (global::AcpUI.AcpTextBox)target;
			this.IntMicNsRdGenRADIOAUTOMINGAINVECTOR_42677.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_6E2:
			this.IntMicNsRdGenRADIOPASSFILTERSTART_42679Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_6EF:
			this.RTDBtnIntMicNsRdGenRADIOSAMMIXMODE_42680 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_6FC:
			this.CVBtnRadErgoCfgGeneralDINCABFSS_A21564 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_709:
			this.CVBtnIntMicNsRdGenDINCOUTPUTEQVECTOR_A37718 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_716:
			this.CVBtnRadErgoCfgGeneralVADDETTHRESHDBQ8_A21567 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_723:
			this.RadErgoCfgGeneralNDIFFTHRESHDBQ8_A21571Comp = (global::AcpUI.AcpTextBoxDecHex)target;
			return;
			IL_730:
			this.RadErgoCfgGeneralMAXSVECTOR_A21565Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_73D:
			this.CpyBtnIntMicNsRdGenRADIOAUTOMINGAINVECTOR_42677 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_74A:
			this.RTDBtnRadErgoCfgGeneralRTHRESHDBQ8_A21572 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_757:
			this.RadErgoCfgGeneralVADDETCOUNT_A21568Comp = (global::AcpUI.AcpTextBoxDecHex)target;
			return;
			IL_764:
			this.RadErgoCfgGeneralVADDETTHRESHDBQ8_A21567Comp = (global::AcpUI.AcpTextBoxDecHex)target;
			return;
			IL_771:
			this.GrpBoxExpanderInternalMicNoiseReductionProfileGeneralBadMic = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_77E:
			this.CpyBtnRadErgoCfgGeneralNDIFFTHRESHDBQ8_A21571 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_78B:
			this.CVBtnIntMicNsRdGenRADIOHOTBEAMMIXRATE_42682 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_798:
			this.CVBtnRadErgoCfgGeneralSDIFFTHRESHDBQ8_A21570 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_7A5:
			this.LblRadErgoCfgGeneralINACTIVETHRESHDBQ8_A21569 = (global::AcpUI.AcpLabel)target;
			this.LblRadErgoCfgGeneralINACTIVETHRESHDBQ8_A21569.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_7C9:
			this.GrpBoxExpanderInternalMicNoiseReductionProfileGeneralPseudo4 = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_7D6:
			this.RTDBtnIntMicNsRdGenRADIOAUTORELAXTIONBOUNDS_42678 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_7E3:
			this.LblRadErgoCfgGeneralRTHRESHDBQ8_A21572 = (global::AcpUI.AcpLabel)target;
			this.LblRadErgoCfgGeneralRTHRESHDBQ8_A21572.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_807:
			this.CVBtnRadErgoCfgGeneralMINGAIN_A21562 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_814:
			this.GrpBoxExpanderInternalMicNoiseReductionProfileGeneralEWind = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_821:
			this.CpyBtnRadErgoCfgGeneralMAXSVECTOR_A21565 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_82E:
			this.MyStackPanel = (global::System.Windows.Controls.StackPanel)target;
			return;
			IL_83B:
			this.RTDBtnRadErgoCfgGeneralMAXSVECTOR_A21565 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_848:
			this.RadErgoCfgGeneralVADDETTHRESHDBQ8_A21567 = (global::AcpUI.AcpTextBoxSpinnerDecHex)target;
			this.RadErgoCfgGeneralVADDETTHRESHDBQ8_A21567.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_86C:
			this.LblIntMicNsRdGenRADIOAUTONOISEBOUNDSDBQ8_42676 = (global::AcpUI.AcpLabel)target;
			this.LblIntMicNsRdGenRADIOAUTONOISEBOUNDSDBQ8_42676.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_890:
			this.IntMicNsRdGenDINCEPVECTOR_A37719Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_89D:
			this.IntMicNsRdGenDINCEPVECTOR_A37719 = (global::AcpUI.AcpTextBox)target;
			this.IntMicNsRdGenDINCEPVECTOR_A37719.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_8C1:
			this.GrpBoxExpanderInternalMicNoiseReductionProfileGeneralStatus = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_8CE:
			this.LblRadErgoCfgGeneralNDIFFTHRESHDBQ8_A21571 = (global::AcpUI.AcpLabel)target;
			this.LblRadErgoCfgGeneralNDIFFTHRESHDBQ8_A21571.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_8F2:
			this.IntMicNsRdGenRADIOAUTOMINGAINVECTOR_42677Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_8FF:
			((global::Motorola.MackinawCPS.CoreFeatures.InternalMicNoiseReductionProfile.PageInternalMicNoiseReductionProfile)target).Loaded += this.OnLoaded;
			((global::Motorola.MackinawCPS.CoreFeatures.InternalMicNoiseReductionProfile.PageInternalMicNoiseReductionProfile)target).Unloaded += this.OnUnloaded;
			return;
			IL_930:
			this.RecNavToolbarPageInternalMicNoiseReductionProfile = (global::AcpUI.AcpParentRecNavToolbar)target;
			this.RecNavToolbarPageInternalMicNoiseReductionProfile.ModeClick += this.OnModeClick;
			return;
			IL_954:
			this.CpyBtnRadErgoCfgGeneralRTHRESHDBQ8_A21572 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_961:
			this.CpyBtnRadErgoCfgGeneralINACTIVETHRESHDBQ8_A21569 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_96E:
			this.CpyBtnRadErgoCfgGeneralVADDETCOUNT_A21568 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_97B:
			this.RadErgoCfgGeneralHOTBEAMDETTHRESHDBQ8_A21566Comp = (global::AcpUI.AcpTextBoxDecHex)target;
			return;
			IL_988:
			this.RadErgoCfgGeneralSDIFFTHRESHDBQ8_A21570 = (global::AcpUI.AcpTextBoxSpinnerDecHex)target;
			this.RadErgoCfgGeneralSDIFFTHRESHDBQ8_A21570.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_9AC:
			this.RadErgoCfgGeneralNBANDS_A21573Comp = (global::AcpUI.AcpTextBoxDecHex)target;
			return;
			IL_9B9:
			this.CVBtnIntMicNsRdGenRADIOSAMMIXMODE_42680 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_9C6:
			this.RTDBtnIntMicNsRdGenDINCEPVECTOR_A37719 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_9D3:
			this.LblIntMicNsRdGenDINCEPVECTOR_A37719 = (global::AcpUI.AcpLabel)target;
			this.LblIntMicNsRdGenDINCEPVECTOR_A37719.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_9F7:
			num = (short)419299328;
			short num3 = num;
			this.CVBtnRadErgoCfgGeneralHOTBEAMDETTHRESHDBQ8_A21566 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_A2E:
			this.LblIntMicNsRdGenRADIOSAMMIXMODE_42680 = (global::AcpUI.AcpLabel)target;
			this.LblIntMicNsRdGenRADIOSAMMIXMODE_42680.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_A52:
			this.IntMicNsRdGenRADIOAUTONOISEBOUNDSDBQ8_42676Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_A5F:
			this.RTDBtnRadErgoCfgGeneralNDIFFTHRESHDBQ8_A21571 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_A6C:
			this.LblIntMicNsRdGenRADIOAUTORELAXTIONBOUNDS_42678 = (global::AcpUI.AcpLabel)target;
			this.LblIntMicNsRdGenRADIOAUTORELAXTIONBOUNDS_42678.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_A90:
			this.RadErgoCfgGeneralEXPANSIONDEGREE_A21563Comp = (global::AcpUI.AcpTextBoxDecHex)target;
			return;
			IL_A9D:
			this.RTDBtnRadErgoCfgGeneralVADDETTHRESHDBQ8_A21567 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_AAA:
			this.CVBtnIntMicNsRdGenRADIOAUTOMINGAINVECTOR_42677 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_AB7:
			this.IntMicNsRdGenDINCOUTPUTEQVECTOR_A37718Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_AC4:
			this.CpyBtnIntMicNsRdGenRADIOSAMCUTOVERFREQUENCY_42681 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_AD1:
			this.CpyBtnIntMicNsRdGenRADIOAUTONOISEBOUNDSDBQ8_42676 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_ADE:
			num = (short)198675511;
			short num4 = num;
			num = (short)375163959;
			switch ((num4 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_F5D:
				this.IntMicNsRdGenDINCOUTPUTEQVECTOR_A37718 = (global::AcpUI.AcpTextBox)target;
				this.IntMicNsRdGenDINCOUTPUTEQVECTOR_A37718.GotFocus += this.OnFieldNameDoubleClick;
				return;
			default:
				num = (short)1490812928;
				if (num != 0)
				{
				}
				this.RTDBtnIntMicNsRdGenDINCOUTPUTEQVECTOR_A37718 = (global::AcpUI.AcpRtdButton)target;
				return;
			}
			IL_B35:
			this.CVBtnIntMicNsRdGenRADIOAUTONOISEBOUNDSDBQ8_42676 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_B42:
			this.CVBtnIntMicNsRdGenRADIOAUTORELAXTIONBOUNDS_42678 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_B4F:
			this.IntMicNsRdGenRADIOHOTBEAMMIXRATE_42682 = (global::AcpUI.AcpTextBoxSpinner)target;
			this.IntMicNsRdGenRADIOHOTBEAMMIXRATE_42682.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_B73:
			this.GrpBoxExpanderInternalMicNoiseReductionProfileGeneralPseudo0 = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_B80:
			this.RadErgoCfgGeneralEXPANSIONDEGREE_A21563 = (global::AcpUI.AcpTextBoxSpinnerDecHex)target;
			this.RadErgoCfgGeneralEXPANSIONDEGREE_A21563.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_BA4:
			this.RTDBtnIntMicNsRdGenRADIOAUTONOISEBOUNDSDBQ8_42676 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_BB1:
			this.IntMicNsRdGenRADIOHOTBEAMMIXRATE_42682Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_BBE:
			this.CpyBtnRadErgoCfgGeneralSDIFFTHRESHDBQ8_A21570 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_BCB:
			this.RTDBtnRadErgoCfgGeneralVADDETCOUNT_A21568 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_BD8:
			this.InternalMicNoiseReductionProfileName_A22535 = (global::AcpUI.AcpTextBox)target;
			this.InternalMicNoiseReductionProfileName_A22535.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_BFC:
			this.LblIntMicNsRdGenRADIOAUTOMINGAINVECTOR_42677 = (global::AcpUI.AcpLabel)target;
			this.LblIntMicNsRdGenRADIOAUTOMINGAINVECTOR_42677.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_C20:
			this.RadErgoCfgGeneralHOTBEAMDETTHRESHDBQ8_A21566 = (global::AcpUI.AcpTextBoxSpinnerDecHex)target;
			this.RadErgoCfgGeneralHOTBEAMDETTHRESHDBQ8_A21566.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_C44:
			this.CpyBtnRadErgoCfgGeneralVADDETTHRESHDBQ8_A21567 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_C51:
			this.IntMicNsRdGenRADIOHOTBEAMMAXATTENUATIONDBQ8_42683Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_C5E:
			this.LblRadErgoCfgGeneralSDIFFTHRESHDBQ8_A21570 = (global::AcpUI.AcpLabel)target;
			this.LblRadErgoCfgGeneralSDIFFTHRESHDBQ8_A21570.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_C82:
			this.LblInternalMicNoiseReductionProfileName_A22535 = (global::AcpUI.AcpLabel)target;
			this.LblInternalMicNoiseReductionProfileName_A22535.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_CA6:
			this.CVBtnRadErgoCfgGeneralMAXSVECTOR_A21565 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_CB3:
			this.RadErgoCfgGeneralNBANDS_A21573 = (global::AcpUI.AcpTextBoxSpinnerDecHex)target;
			this.RadErgoCfgGeneralNBANDS_A21573.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_CD7:
			this.IntMicNsRdGenRADIOAUTORELAXTIONBOUNDS_42678Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_CE4:
			this.IntMicNsRdGenRADIOSAMCUTOVERFREQUENCY_42681 = (global::AcpUI.AcpTextBoxSpinner)target;
			this.IntMicNsRdGenRADIOSAMCUTOVERFREQUENCY_42681.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_D08:
			this.CpyBtnIntMicNsRdGenDINCEPVECTOR_A37719 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_D15:
			this.CVBtnRadErgoCfgGeneralNDIFFTHRESHDBQ8_A21571 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_D22:
			this.CpyBtnIntMicNsRdGenRADIOHOTBEAMMIXRATE_42682 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_D2F:
			this.CpyBtnRadErgoCfgGeneralDINCABFSS_A21564 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_D3C:
			this.RTDBtnRadErgoCfgGeneralINACTIVETHRESHDBQ8_A21569 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_D49:
			this.LblIntMicNsRdGenRADIOHOTBEAMMIXRATE_42682 = (global::AcpUI.AcpLabel)target;
			this.LblIntMicNsRdGenRADIOHOTBEAMMIXRATE_42682.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_D6D:
			this.RTDBtnIntMicNsRdGenRADIOHOTBEAMMAXATTENUATIONDBQ8_42683 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_D7A:
			this.GrpBoxExpanderInternalMicNoiseReductionProfileGeneralPseudo2 = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_D87:
			this.RTDBtnRadErgoCfgGeneralDINCABFSS_A21564 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_D94:
			this.CpyBtnIntMicNsRdGenDINCOUTPUTEQVECTOR_A37718 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_DA1:
			this.CVBtnIntMicNsRdGenRADIOHOTBEAMMAXATTENUATIONDBQ8_42683 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_DAE:
			this.RTDBtnIntMicNsRdGenRADIOHOTBEAMMIXRATE_42682 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_DBB:
			this.RTDBtnRadErgoCfgGeneralEXPANSIONDEGREE_A21563 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_DC8:
			this.RadErgoCfgGeneralVADDETCOUNT_A21568 = (global::AcpUI.AcpTextBoxSpinnerDecHex)target;
			this.RadErgoCfgGeneralVADDETCOUNT_A21568.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_DEC:
			this.LblIntMicNsRdGenRADIOHOTBEAMMAXATTENUATIONDBQ8_42683 = (global::AcpUI.AcpLabel)target;
			this.LblIntMicNsRdGenRADIOHOTBEAMMAXATTENUATIONDBQ8_42683.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_E10:
			this.CVBtnIntMicNsRdGenRADIOPASSFILTERSTART_42679 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_E1D:
			this.RTDBtnRadErgoCfgGeneralSDIFFTHRESHDBQ8_A21570 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_E2A:
			this.RadErgoCfgGeneralMAXSVECTOR_A21565 = (global::AcpUI.AcpTextBox)target;
			this.RadErgoCfgGeneralMAXSVECTOR_A21565.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_E4E:
			this.InternalMicNoiseReductionProfileName_A22535Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_E5B:
			this.RadErgoCfgGeneralINACTIVETHRESHDBQ8_A21569 = (global::AcpUI.AcpTextBoxSpinnerDecHex)target;
			this.RadErgoCfgGeneralINACTIVETHRESHDBQ8_A21569.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_E7F:
			this.CVBtnIntMicNsRdGenRADIOSAMCUTOVERFREQUENCY_42681 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_E8C:
			this.ExpanderInternalMicNoiseReductionProfileGeneral = (global::AcpUI.AcpExpander)target;
			return;
			IL_E99:
			this.LblRadErgoCfgGeneralMAXSVECTOR_A21565 = (global::AcpUI.AcpLabel)target;
			this.LblRadErgoCfgGeneralMAXSVECTOR_A21565.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_EBD:
			this.LblRadErgoCfgGeneralEXPANSIONDEGREE_A21563 = (global::AcpUI.AcpLabel)target;
			this.LblRadErgoCfgGeneralEXPANSIONDEGREE_A21563.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_EE1:
			this.CVBtnInternalMicNoiseReductionProfileName_A22535 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_EEE:
			this.RadErgoCfgGeneralNDIFFTHRESHDBQ8_A21571 = (global::AcpUI.AcpTextBoxSpinnerDecHex)target;
			this.RadErgoCfgGeneralNDIFFTHRESHDBQ8_A21571.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_F12:
			this.LblRadErgoCfgGeneralDINCABFSS_A21564 = (global::AcpUI.AcpLabel)target;
			this.LblRadErgoCfgGeneralDINCABFSS_A21564.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_F36:
			this.IntMicNsRdGenRADIOSAMMIXMODE_42680Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_F43:
			this.CpyBtnIntMicNsRdGenRADIOHOTBEAMMAXATTENUATIONDBQ8_42683 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_F50:
			this.CVBtnRadErgoCfgGeneralRTHRESHDBQ8_A21572 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_F81:
			this.RTDBtnRadErgoCfgGeneralHOTBEAMDETTHRESHDBQ8_A21566 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_F8E:
			this.RTDBtnIntMicNsRdGenRADIOPASSFILTERSTART_42679 = (global::AcpUI.AcpRtdButton)target;
		}

		// Token: 0x04002954 RID: 10580
		private bool a;

		// Token: 0x04002955 RID: 10581
		internal global::AcpUI.AcpParentRecNavToolbar RecNavToolbarPageInternalMicNoiseReductionProfile;

		// Token: 0x04002956 RID: 10582
		internal global::AcpUI.Common.AcpThemeBase ThemeBaseObj;

		// Token: 0x04002957 RID: 10583
		internal global::System.Windows.Documents.Hyperlink HLinkGeneral;

		// Token: 0x04002958 RID: 10584
		internal global::System.Windows.Controls.StackPanel MyStackPanel;

		// Token: 0x04002959 RID: 10585
		internal global::AcpUI.AcpExpander ExpanderInternalMicNoiseReductionProfileGeneral;

		// Token: 0x0400295A RID: 10586
		internal global::AcpUI.AcpGroupBox GrpBoxExpanderInternalMicNoiseReductionProfileGeneralPseudo0;

		// Token: 0x0400295B RID: 10587
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnInternalMicNoiseReductionProfileName_A22535;

		// Token: 0x0400295C RID: 10588
		internal global::AcpUI.AcpLabel LblInternalMicNoiseReductionProfileName_A22535;

		// Token: 0x0400295D RID: 10589
		internal global::AcpUI.AcpTextBox InternalMicNoiseReductionProfileName_A22535;

		// Token: 0x0400295E RID: 10590
		internal global::AcpUI.AcpCopyButton CpyBtnInternalMicNoiseReductionProfileName_A22535;

		// Token: 0x0400295F RID: 10591
		internal global::AcpUI.AcpLabel InternalMicNoiseReductionProfileName_A22535Comp;

		// Token: 0x04002960 RID: 10592
		internal global::AcpUI.AcpGroupBox GrpBoxExpanderInternalMicNoiseReductionProfileGeneralEWind;

		// Token: 0x04002961 RID: 10593
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadErgoCfgGeneralMAXSVECTOR_A21565;

		// Token: 0x04002962 RID: 10594
		internal global::AcpUI.AcpLabel LblRadErgoCfgGeneralMAXSVECTOR_A21565;

		// Token: 0x04002963 RID: 10595
		internal global::AcpUI.AcpTextBox RadErgoCfgGeneralMAXSVECTOR_A21565;

		// Token: 0x04002964 RID: 10596
		internal global::AcpUI.AcpRtdButton RTDBtnRadErgoCfgGeneralMAXSVECTOR_A21565;

		// Token: 0x04002965 RID: 10597
		internal global::AcpUI.AcpCopyButton CpyBtnRadErgoCfgGeneralMAXSVECTOR_A21565;

		// Token: 0x04002966 RID: 10598
		internal global::AcpUI.AcpLabel RadErgoCfgGeneralMAXSVECTOR_A21565Comp;

		// Token: 0x04002967 RID: 10599
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadErgoCfgGeneralNBANDS_A21573;

		// Token: 0x04002968 RID: 10600
		internal global::AcpUI.AcpLabel LblRadErgoCfgGeneralNBANDS_A21573;

		// Token: 0x04002969 RID: 10601
		internal global::AcpUI.AcpTextBoxSpinnerDecHex RadErgoCfgGeneralNBANDS_A21573;

		// Token: 0x0400296A RID: 10602
		internal global::AcpUI.AcpRtdButton RTDBtnRadErgoCfgGeneralNBANDS_A21573;

		// Token: 0x0400296B RID: 10603
		internal global::AcpUI.AcpCopyButton CpyBtnRadErgoCfgGeneralNBANDS_A21573;

		// Token: 0x0400296C RID: 10604
		internal global::AcpUI.AcpTextBoxDecHex RadErgoCfgGeneralNBANDS_A21573Comp;

		// Token: 0x0400296D RID: 10605
		internal global::AcpUI.AcpGroupBox GrpBoxExpanderInternalMicNoiseReductionProfileGeneralPseudo1;

		// Token: 0x0400296E RID: 10606
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadErgoCfgGeneralDINCABFSS_A21564;

		// Token: 0x0400296F RID: 10607
		internal global::AcpUI.AcpLabel LblRadErgoCfgGeneralDINCABFSS_A21564;

		// Token: 0x04002970 RID: 10608
		internal global::AcpUI.AcpTextBoxSpinnerDecHex RadErgoCfgGeneralDINCABFSS_A21564;

		// Token: 0x04002971 RID: 10609
		internal global::AcpUI.AcpRtdButton RTDBtnRadErgoCfgGeneralDINCABFSS_A21564;

		// Token: 0x04002972 RID: 10610
		internal global::AcpUI.AcpCopyButton CpyBtnRadErgoCfgGeneralDINCABFSS_A21564;

		// Token: 0x04002973 RID: 10611
		internal global::AcpUI.AcpTextBoxDecHex RadErgoCfgGeneralDINCABFSS_A21564Comp;

		// Token: 0x04002974 RID: 10612
		internal global::AcpUI.AcpGroupBox GrpBoxExpanderInternalMicNoiseReductionProfileGeneralDWF;

		// Token: 0x04002975 RID: 10613
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadErgoCfgGeneralMINGAIN_A21562;

		// Token: 0x04002976 RID: 10614
		internal global::AcpUI.AcpLabel LblRadErgoCfgGeneralMINGAIN_A21562;

		// Token: 0x04002977 RID: 10615
		internal global::AcpUI.AcpTextBoxSpinnerDecHex RadErgoCfgGeneralMINGAIN_A21562;

		// Token: 0x04002978 RID: 10616
		internal global::AcpUI.AcpRtdButton RTDBtnRadErgoCfgGeneralMINGAIN_A21562;

		// Token: 0x04002979 RID: 10617
		internal global::AcpUI.AcpCopyButton CpyBtnRadErgoCfgGeneralMINGAIN_A21562;

		// Token: 0x0400297A RID: 10618
		internal global::AcpUI.AcpTextBoxDecHex RadErgoCfgGeneralMINGAIN_A21562Comp;

		// Token: 0x0400297B RID: 10619
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadErgoCfgGeneralEXPANSIONDEGREE_A21563;

		// Token: 0x0400297C RID: 10620
		internal global::AcpUI.AcpLabel LblRadErgoCfgGeneralEXPANSIONDEGREE_A21563;

		// Token: 0x0400297D RID: 10621
		internal global::AcpUI.AcpTextBoxSpinnerDecHex RadErgoCfgGeneralEXPANSIONDEGREE_A21563;

		// Token: 0x0400297E RID: 10622
		internal global::AcpUI.AcpRtdButton RTDBtnRadErgoCfgGeneralEXPANSIONDEGREE_A21563;

		// Token: 0x0400297F RID: 10623
		internal global::AcpUI.AcpCopyButton CpyBtnRadErgoCfgGeneralEXPANSIONDEGREE_A21563;

		// Token: 0x04002980 RID: 10624
		internal global::AcpUI.AcpTextBoxDecHex RadErgoCfgGeneralEXPANSIONDEGREE_A21563Comp;

		// Token: 0x04002981 RID: 10625
		internal global::AcpUI.AcpGroupBox GrpBoxExpanderInternalMicNoiseReductionProfileGeneralPseudo2;

		// Token: 0x04002982 RID: 10626
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadErgoCfgGeneralHOTBEAMDETTHRESHDBQ8_A21566;

		// Token: 0x04002983 RID: 10627
		internal global::AcpUI.AcpLabel LblRadErgoCfgGeneralHOTBEAMDETTHRESHDBQ8_A21566;

		// Token: 0x04002984 RID: 10628
		internal global::AcpUI.AcpTextBoxSpinnerDecHex RadErgoCfgGeneralHOTBEAMDETTHRESHDBQ8_A21566;

		// Token: 0x04002985 RID: 10629
		internal global::AcpUI.AcpRtdButton RTDBtnRadErgoCfgGeneralHOTBEAMDETTHRESHDBQ8_A21566;

		// Token: 0x04002986 RID: 10630
		internal global::AcpUI.AcpCopyButton CpyBtnRadErgoCfgGeneralHOTBEAMDETTHRESHDBQ8_A21566;

		// Token: 0x04002987 RID: 10631
		internal global::AcpUI.AcpTextBoxDecHex RadErgoCfgGeneralHOTBEAMDETTHRESHDBQ8_A21566Comp;

		// Token: 0x04002988 RID: 10632
		internal global::AcpUI.AcpGroupBox GrpBoxExpanderInternalMicNoiseReductionProfileGeneralStatus;

		// Token: 0x04002989 RID: 10633
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadErgoCfgGeneralVADDETTHRESHDBQ8_A21567;

		// Token: 0x0400298A RID: 10634
		internal global::AcpUI.AcpLabel LblRadErgoCfgGeneralVADDETTHRESHDBQ8_A21567;

		// Token: 0x0400298B RID: 10635
		internal global::AcpUI.AcpTextBoxSpinnerDecHex RadErgoCfgGeneralVADDETTHRESHDBQ8_A21567;

		// Token: 0x0400298C RID: 10636
		internal global::AcpUI.AcpRtdButton RTDBtnRadErgoCfgGeneralVADDETTHRESHDBQ8_A21567;

		// Token: 0x0400298D RID: 10637
		internal global::AcpUI.AcpCopyButton CpyBtnRadErgoCfgGeneralVADDETTHRESHDBQ8_A21567;

		// Token: 0x0400298E RID: 10638
		internal global::AcpUI.AcpTextBoxDecHex RadErgoCfgGeneralVADDETTHRESHDBQ8_A21567Comp;

		// Token: 0x0400298F RID: 10639
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadErgoCfgGeneralVADDETCOUNT_A21568;

		// Token: 0x04002990 RID: 10640
		internal global::AcpUI.AcpLabel LblRadErgoCfgGeneralVADDETCOUNT_A21568;

		// Token: 0x04002991 RID: 10641
		internal global::AcpUI.AcpTextBoxSpinnerDecHex RadErgoCfgGeneralVADDETCOUNT_A21568;

		// Token: 0x04002992 RID: 10642
		internal global::AcpUI.AcpRtdButton RTDBtnRadErgoCfgGeneralVADDETCOUNT_A21568;

		// Token: 0x04002993 RID: 10643
		internal global::AcpUI.AcpCopyButton CpyBtnRadErgoCfgGeneralVADDETCOUNT_A21568;

		// Token: 0x04002994 RID: 10644
		internal global::AcpUI.AcpTextBoxDecHex RadErgoCfgGeneralVADDETCOUNT_A21568Comp;

		// Token: 0x04002995 RID: 10645
		internal global::AcpUI.AcpGroupBox GrpBoxExpanderInternalMicNoiseReductionProfileGeneralBadMic;

		// Token: 0x04002996 RID: 10646
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadErgoCfgGeneralINACTIVETHRESHDBQ8_A21569;

		// Token: 0x04002997 RID: 10647
		internal global::AcpUI.AcpLabel LblRadErgoCfgGeneralINACTIVETHRESHDBQ8_A21569;

		// Token: 0x04002998 RID: 10648
		internal global::AcpUI.AcpTextBoxSpinnerDecHex RadErgoCfgGeneralINACTIVETHRESHDBQ8_A21569;

		// Token: 0x04002999 RID: 10649
		internal global::AcpUI.AcpRtdButton RTDBtnRadErgoCfgGeneralINACTIVETHRESHDBQ8_A21569;

		// Token: 0x0400299A RID: 10650
		internal global::AcpUI.AcpCopyButton CpyBtnRadErgoCfgGeneralINACTIVETHRESHDBQ8_A21569;

		// Token: 0x0400299B RID: 10651
		internal global::AcpUI.AcpTextBoxDecHex RadErgoCfgGeneralINACTIVETHRESHDBQ8_A21569Comp;

		// Token: 0x0400299C RID: 10652
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadErgoCfgGeneralSDIFFTHRESHDBQ8_A21570;

		// Token: 0x0400299D RID: 10653
		internal global::AcpUI.AcpLabel LblRadErgoCfgGeneralSDIFFTHRESHDBQ8_A21570;

		// Token: 0x0400299E RID: 10654
		internal global::AcpUI.AcpTextBoxSpinnerDecHex RadErgoCfgGeneralSDIFFTHRESHDBQ8_A21570;

		// Token: 0x0400299F RID: 10655
		internal global::AcpUI.AcpRtdButton RTDBtnRadErgoCfgGeneralSDIFFTHRESHDBQ8_A21570;

		// Token: 0x040029A0 RID: 10656
		internal global::AcpUI.AcpCopyButton CpyBtnRadErgoCfgGeneralSDIFFTHRESHDBQ8_A21570;

		// Token: 0x040029A1 RID: 10657
		internal global::AcpUI.AcpTextBoxDecHex RadErgoCfgGeneralSDIFFTHRESHDBQ8_A21570Comp;

		// Token: 0x040029A2 RID: 10658
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadErgoCfgGeneralNDIFFTHRESHDBQ8_A21571;

		// Token: 0x040029A3 RID: 10659
		internal global::AcpUI.AcpLabel LblRadErgoCfgGeneralNDIFFTHRESHDBQ8_A21571;

		// Token: 0x040029A4 RID: 10660
		internal global::AcpUI.AcpTextBoxSpinnerDecHex RadErgoCfgGeneralNDIFFTHRESHDBQ8_A21571;

		// Token: 0x040029A5 RID: 10661
		internal global::AcpUI.AcpRtdButton RTDBtnRadErgoCfgGeneralNDIFFTHRESHDBQ8_A21571;

		// Token: 0x040029A6 RID: 10662
		internal global::AcpUI.AcpCopyButton CpyBtnRadErgoCfgGeneralNDIFFTHRESHDBQ8_A21571;

		// Token: 0x040029A7 RID: 10663
		internal global::AcpUI.AcpTextBoxDecHex RadErgoCfgGeneralNDIFFTHRESHDBQ8_A21571Comp;

		// Token: 0x040029A8 RID: 10664
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadErgoCfgGeneralRTHRESHDBQ8_A21572;

		// Token: 0x040029A9 RID: 10665
		internal global::AcpUI.AcpLabel LblRadErgoCfgGeneralRTHRESHDBQ8_A21572;

		// Token: 0x040029AA RID: 10666
		internal global::AcpUI.AcpTextBoxSpinnerDecHex RadErgoCfgGeneralRTHRESHDBQ8_A21572;

		// Token: 0x040029AB RID: 10667
		internal global::AcpUI.AcpRtdButton RTDBtnRadErgoCfgGeneralRTHRESHDBQ8_A21572;

		// Token: 0x040029AC RID: 10668
		internal global::AcpUI.AcpCopyButton CpyBtnRadErgoCfgGeneralRTHRESHDBQ8_A21572;

		// Token: 0x040029AD RID: 10669
		internal global::AcpUI.AcpTextBoxDecHex RadErgoCfgGeneralRTHRESHDBQ8_A21572Comp;

		// Token: 0x040029AE RID: 10670
		internal global::AcpUI.AcpGroupBox GrpBoxExpanderInternalMicNoiseReductionProfileGeneralPseudo4;

		// Token: 0x040029AF RID: 10671
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnIntMicNsRdGenDINCOUTPUTEQVECTOR_A37718;

		// Token: 0x040029B0 RID: 10672
		internal global::AcpUI.AcpLabel LblIntMicNsRdGenDINCOUTPUTEQVECTOR_A37718;

		// Token: 0x040029B1 RID: 10673
		internal global::AcpUI.AcpTextBox IntMicNsRdGenDINCOUTPUTEQVECTOR_A37718;

		// Token: 0x040029B2 RID: 10674
		internal global::AcpUI.AcpRtdButton RTDBtnIntMicNsRdGenDINCOUTPUTEQVECTOR_A37718;

		// Token: 0x040029B3 RID: 10675
		internal global::AcpUI.AcpCopyButton CpyBtnIntMicNsRdGenDINCOUTPUTEQVECTOR_A37718;

		// Token: 0x040029B4 RID: 10676
		internal global::AcpUI.AcpLabel IntMicNsRdGenDINCOUTPUTEQVECTOR_A37718Comp;

		// Token: 0x040029B5 RID: 10677
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnIntMicNsRdGenDINCEPVECTOR_A37719;

		// Token: 0x040029B6 RID: 10678
		internal global::AcpUI.AcpLabel LblIntMicNsRdGenDINCEPVECTOR_A37719;

		// Token: 0x040029B7 RID: 10679
		internal global::AcpUI.AcpTextBox IntMicNsRdGenDINCEPVECTOR_A37719;

		// Token: 0x040029B8 RID: 10680
		internal global::AcpUI.AcpRtdButton RTDBtnIntMicNsRdGenDINCEPVECTOR_A37719;

		// Token: 0x040029B9 RID: 10681
		internal global::AcpUI.AcpCopyButton CpyBtnIntMicNsRdGenDINCEPVECTOR_A37719;

		// Token: 0x040029BA RID: 10682
		internal global::AcpUI.AcpLabel IntMicNsRdGenDINCEPVECTOR_A37719Comp;

		// Token: 0x040029BB RID: 10683
		internal global::AcpUI.AcpGroupBox GrpBoxExpanderInternalMicNoiseReductionProfileGeneralAdaptiveNoiseSuppression;

		// Token: 0x040029BC RID: 10684
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnIntMicNsRdGenRADIOAUTONOISEBOUNDSDBQ8_42676;

		// Token: 0x040029BD RID: 10685
		internal global::AcpUI.AcpLabel LblIntMicNsRdGenRADIOAUTONOISEBOUNDSDBQ8_42676;

		// Token: 0x040029BE RID: 10686
		internal global::AcpUI.AcpTextBox IntMicNsRdGenRADIOAUTONOISEBOUNDSDBQ8_42676;

		// Token: 0x040029BF RID: 10687
		internal global::AcpUI.AcpRtdButton RTDBtnIntMicNsRdGenRADIOAUTONOISEBOUNDSDBQ8_42676;

		// Token: 0x040029C0 RID: 10688
		internal global::AcpUI.AcpCopyButton CpyBtnIntMicNsRdGenRADIOAUTONOISEBOUNDSDBQ8_42676;

		// Token: 0x040029C1 RID: 10689
		internal global::AcpUI.AcpLabel IntMicNsRdGenRADIOAUTONOISEBOUNDSDBQ8_42676Comp;

		// Token: 0x040029C2 RID: 10690
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnIntMicNsRdGenRADIOAUTOMINGAINVECTOR_42677;

		// Token: 0x040029C3 RID: 10691
		internal global::AcpUI.AcpLabel LblIntMicNsRdGenRADIOAUTOMINGAINVECTOR_42677;

		// Token: 0x040029C4 RID: 10692
		internal global::AcpUI.AcpTextBox IntMicNsRdGenRADIOAUTOMINGAINVECTOR_42677;

		// Token: 0x040029C5 RID: 10693
		internal global::AcpUI.AcpRtdButton RTDBtnIntMicNsRdGenRADIOAUTOMINGAINVECTOR_42677;

		// Token: 0x040029C6 RID: 10694
		internal global::AcpUI.AcpCopyButton CpyBtnIntMicNsRdGenRADIOAUTOMINGAINVECTOR_42677;

		// Token: 0x040029C7 RID: 10695
		internal global::AcpUI.AcpLabel IntMicNsRdGenRADIOAUTOMINGAINVECTOR_42677Comp;

		// Token: 0x040029C8 RID: 10696
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnIntMicNsRdGenRADIOAUTORELAXTIONBOUNDS_42678;

		// Token: 0x040029C9 RID: 10697
		internal global::AcpUI.AcpLabel LblIntMicNsRdGenRADIOAUTORELAXTIONBOUNDS_42678;

		// Token: 0x040029CA RID: 10698
		internal global::AcpUI.AcpTextBox IntMicNsRdGenRADIOAUTORELAXTIONBOUNDS_42678;

		// Token: 0x040029CB RID: 10699
		internal global::AcpUI.AcpRtdButton RTDBtnIntMicNsRdGenRADIOAUTORELAXTIONBOUNDS_42678;

		// Token: 0x040029CC RID: 10700
		internal global::AcpUI.AcpCopyButton CpyBtnIntMicNsRdGenRADIOAUTORELAXTIONBOUNDS_42678;

		// Token: 0x040029CD RID: 10701
		internal global::AcpUI.AcpLabel IntMicNsRdGenRADIOAUTORELAXTIONBOUNDS_42678Comp;

		// Token: 0x040029CE RID: 10702
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnIntMicNsRdGenRADIOPASSFILTERSTART_42679;

		// Token: 0x040029CF RID: 10703
		internal global::AcpUI.AcpLabel LblIntMicNsRdGenRADIOPASSFILTERSTART_42679;

		// Token: 0x040029D0 RID: 10704
		internal global::AcpUI.AcpTextBoxSpinner IntMicNsRdGenRADIOPASSFILTERSTART_42679;

		// Token: 0x040029D1 RID: 10705
		internal global::AcpUI.AcpRtdButton RTDBtnIntMicNsRdGenRADIOPASSFILTERSTART_42679;

		// Token: 0x040029D2 RID: 10706
		internal global::AcpUI.AcpCopyButton CpyBtnIntMicNsRdGenRADIOPASSFILTERSTART_42679;

		// Token: 0x040029D3 RID: 10707
		internal global::AcpUI.AcpLabel IntMicNsRdGenRADIOPASSFILTERSTART_42679Comp;

		// Token: 0x040029D4 RID: 10708
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnIntMicNsRdGenRADIOSAMMIXMODE_42680;

		// Token: 0x040029D5 RID: 10709
		internal global::AcpUI.AcpLabel LblIntMicNsRdGenRADIOSAMMIXMODE_42680;

		// Token: 0x040029D6 RID: 10710
		internal global::AcpUI.AcpTextBoxSpinner IntMicNsRdGenRADIOSAMMIXMODE_42680;

		// Token: 0x040029D7 RID: 10711
		internal global::AcpUI.AcpRtdButton RTDBtnIntMicNsRdGenRADIOSAMMIXMODE_42680;

		// Token: 0x040029D8 RID: 10712
		internal global::AcpUI.AcpCopyButton CpyBtnIntMicNsRdGenRADIOSAMMIXMODE_42680;

		// Token: 0x040029D9 RID: 10713
		internal global::AcpUI.AcpLabel IntMicNsRdGenRADIOSAMMIXMODE_42680Comp;

		// Token: 0x040029DA RID: 10714
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnIntMicNsRdGenRADIOSAMCUTOVERFREQUENCY_42681;

		// Token: 0x040029DB RID: 10715
		internal global::AcpUI.AcpLabel LblIntMicNsRdGenRADIOSAMCUTOVERFREQUENCY_42681;

		// Token: 0x040029DC RID: 10716
		internal global::AcpUI.AcpTextBoxSpinner IntMicNsRdGenRADIOSAMCUTOVERFREQUENCY_42681;

		// Token: 0x040029DD RID: 10717
		internal global::AcpUI.AcpRtdButton RTDBtnIntMicNsRdGenRADIOSAMCUTOVERFREQUENCY_42681;

		// Token: 0x040029DE RID: 10718
		internal global::AcpUI.AcpCopyButton CpyBtnIntMicNsRdGenRADIOSAMCUTOVERFREQUENCY_42681;

		// Token: 0x040029DF RID: 10719
		internal global::AcpUI.AcpLabel IntMicNsRdGenRADIOSAMCUTOVERFREQUENCY_42681Comp;

		// Token: 0x040029E0 RID: 10720
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnIntMicNsRdGenRADIOHOTBEAMMIXRATE_42682;

		// Token: 0x040029E1 RID: 10721
		internal global::AcpUI.AcpLabel LblIntMicNsRdGenRADIOHOTBEAMMIXRATE_42682;

		// Token: 0x040029E2 RID: 10722
		internal global::AcpUI.AcpTextBoxSpinner IntMicNsRdGenRADIOHOTBEAMMIXRATE_42682;

		// Token: 0x040029E3 RID: 10723
		internal global::AcpUI.AcpRtdButton RTDBtnIntMicNsRdGenRADIOHOTBEAMMIXRATE_42682;

		// Token: 0x040029E4 RID: 10724
		internal global::AcpUI.AcpCopyButton CpyBtnIntMicNsRdGenRADIOHOTBEAMMIXRATE_42682;

		// Token: 0x040029E5 RID: 10725
		internal global::AcpUI.AcpLabel IntMicNsRdGenRADIOHOTBEAMMIXRATE_42682Comp;

		// Token: 0x040029E6 RID: 10726
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnIntMicNsRdGenRADIOHOTBEAMMAXATTENUATIONDBQ8_42683;

		// Token: 0x040029E7 RID: 10727
		internal global::AcpUI.AcpLabel LblIntMicNsRdGenRADIOHOTBEAMMAXATTENUATIONDBQ8_42683;

		// Token: 0x040029E8 RID: 10728
		internal global::AcpUI.AcpTextBoxSpinner IntMicNsRdGenRADIOHOTBEAMMAXATTENUATIONDBQ8_42683;

		// Token: 0x040029E9 RID: 10729
		internal global::AcpUI.AcpRtdButton RTDBtnIntMicNsRdGenRADIOHOTBEAMMAXATTENUATIONDBQ8_42683;

		// Token: 0x040029EA RID: 10730
		internal global::AcpUI.AcpCopyButton CpyBtnIntMicNsRdGenRADIOHOTBEAMMAXATTENUATIONDBQ8_42683;

		// Token: 0x040029EB RID: 10731
		internal global::AcpUI.AcpLabel IntMicNsRdGenRADIOHOTBEAMMAXATTENUATIONDBQ8_42683Comp;

		// Token: 0x040029EC RID: 10732
		private bool b;
	}
}
