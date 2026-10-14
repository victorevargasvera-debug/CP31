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

namespace Motorola.MackinawCPS.CoreFeatures.DVRSProfiles
{
	// Token: 0x020004B4 RID: 1204
	public class PageDVRSProfiles : global::AcpUI.AcpPageFeature, global::System.Windows.Markup.IComponentConnector
	{
		// Token: 0x06009E4E RID: 40526 RVA: 0x0093C980 File Offset: 0x0093AB80
		public PageDVRSProfiles()
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

		// Token: 0x06009E4F RID: 40527 RVA: 0x0093C9B8 File Offset: 0x0093ABB8
		public override void OnLoaded(object sender, global::System.Windows.RoutedEventArgs e)
		{
			for (;;)
			{
				IL_00:
				short num = (short)654180352;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					global::AcpUI.AcpExpander acpExpander;
					global::System.Collections.IEnumerator enumerator;
					switch (num2)
					{
					case 0:
					{
						num = (short)82771969;
						if (num != 0)
						{
						}
						num = (short)1294467072;
						short num3 = num;
						switch (0)
						{
						case 0:
							goto IL_86;
						}
						continue;
					}
					case 1:
						goto IL_2B6;
					case 2:
						try
						{
							num = (short)1150091266;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									base.Expanders.Add(acpExpander);
									num = (short)1071972357;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									goto IL_1EE;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_139;
									}
									continue;
								case 3:
									if (acpExpander != null)
									{
										num = (short)344784896;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								case 4:
									num = (short)1842675713;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 6:
									if (!enumerator.MoveNext())
									{
										num = (short)734003204;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									acpExpander = (((global::System.Windows.UIElement)enumerator.Current) as global::AcpUI.AcpExpander);
									num = (short)1777401859;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_17A:
								num = (short)1311965190;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_139:
								goto IL_17A;
							}
							IL_1EE:
							goto IL_28F;
						}
						finally
						{
							switch (0)
							{
							case 0:
								goto IL_20F;
							}
							global::System.IDisposable disposable;
							for (;;)
							{
								IL_1FD:
								switch (num2)
								{
								case 0:
									if (disposable != null)
									{
										num = (short)1449328642;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_25F;
								case 1:
									goto IL_25D;
								case 2:
									disposable.Dispose();
									num = (short)354222081;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_20F;
							}
							IL_25D:
							IL_25F:
							goto EndFinally_6;
							IL_20F:
							disposable = (enumerator as global::System.IDisposable);
							num = (short)1492910080;
							num2 = (int)((global::System.IntPtr)num);
							goto IL_1FD;
							EndFinally_6:;
						}
						goto IL_260;
						IL_28F:
						base.OnLoaded(sender, e);
						this.a = true;
						num = (short)1298268161;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						goto IL_260;
					}
					IL_86:
					if (this.a)
					{
						goto IL_2B8;
					}
					num = (short)263540026;
					short num4 = num;
					num = (short)1410223418;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_00;
					default:
						num = (short)1138425856;
						if (num != 0)
						{
						}
						num = (short)1230766083;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_260:
					acpExpander = null;
					enumerator = this.MyStackPanel.Children.GetEnumerator();
					num = (short)884604930;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
			IL_2B6:
			IL_2B8:
			this.MyStackPanel.Children[0].Focus();
		}

		// Token: 0x06009E50 RID: 40528 RVA: 0x0093CCA4 File Offset: 0x0093AEA4
		public override void OnUnloaded(object sender, global::System.Windows.RoutedEventArgs e)
		{
			short num = (short)901251072;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				num = (short)409076571;
				short num3 = num;
				num = (short)59769691;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					return;
				default:
				{
					num = (short)1470824448;
					if (num != 0)
					{
					}
					num = (short)1449525248;
					short num4 = num;
					switch (num2)
					{
					case 0:
						switch (0)
						{
						case 0:
							goto IL_A3;
						}
						continue;
					case 1:
						return;
					case 2:
						num = (short)716177409;
						if (num != 0)
						{
						}
						base.OnUnloaded(sender, e);
						this.a = false;
						num = (short)163381249;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_A3:
					if (!this.a)
					{
						return;
					}
					num = (short)728694786;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
				}
			}
		}

		// Token: 0x06009E51 RID: 40529 RVA: 0x0093CDC4 File Offset: 0x0093AFC4
		public override void SetDataContext()
		{
			short num = (short)1428291586;
			int num2 = (int)((global::System.IntPtr)num);
			object feature;
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_233;
				case 1:
					num = (short)955121665;
					if (num != 0)
					{
					}
					if (global::AcpCommonLib.AppInfoManager.AppMode == global::AcpCommonLib.ApplicationMode.CodeplugComparisonMode)
					{
						num = (short)1043333123;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					((global::AcpUILib.IAcpRecNavToolbar)this.RecNavToolbarPageDVRSProfiles).MySecondaryRecordsetDataSource = null;
					num = (short)2046296068;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					switch (0)
					{
					case 0:
						goto IL_49;
					}
					continue;
				case 3:
					feature = global::AcpCommonLib.AppInfoManager.ComparatorDocument.GetFeature(4143);
					num = (short)457900038;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					goto IL_1C3;
				case 5:
					base.DataContext = global::AcpCommonLib.AppInfoManager.DefaultDocument.GetFeature(4143);
					num = (short)2018377736;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 6:
					if (feature != null)
					{
						num = (short)1746862080;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 7:
					goto IL_A8;
				case 8:
					goto IL_A8;
				}
				IL_49:
				num = (short)1280507904;
				short num3 = num;
				if (global::AcpCommonLib.AppInfoManager.AppMode == global::AcpCommonLib.ApplicationMode.CustomViewConfigurationMode)
				{
					num = (short)240779269;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				base.DataContext = global::AcpCommonLib.FeatureManager.GetFeature(4143);
				num = (short)1731395591;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_A8:
				this.RecNavToolbarPageDVRSProfiles.DataContext = (global::AcpCommonLib.IAcpRecordset)base.DataContext;
				num = (short)1049074279;
				short num4 = num;
				num = (short)678468199;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_233;
				default:
					num = (short)999948288;
					if (num != 0)
					{
					}
					num = (short)1003683841;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
			}
			IL_1C3:
			return;
			IL_233:
			((global::AcpUILib.IAcpRecNavToolbar)this.RecNavToolbarPageDVRSProfiles).MySecondaryRecordsetDataSource = (global::AcpCommonLib.IAcpRecordset)feature;
		}

		// Token: 0x06009E52 RID: 40530 RVA: 0x0093D00C File Offset: 0x0093B20C
		private void OnModeClick(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			int a_ = 8;
			short num = (short)245497858;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_183;
				case 1:
				{
					num = (short)796327937;
					if (num != 0)
					{
					}
					global::AcpCommonLib.IAcpRecordset myRecordsetDataSource = this.RecNavToolbarPageDVRSProfiles.MyRecordsetDataSource;
					num = (short)1905131526;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 2:
				{
					num = (short)645726208;
					short num3 = num;
					switch (0)
					{
					case 0:
						goto IL_72;
					}
					continue;
				}
				case 3:
					num = (short)2072510469;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
				{
					global::AcpCommonLib.IAcpRecordset myRecordsetDataSource;
					base.NavigationService.Navigate(new global::System.Uri(myRecordsetDataSource.UIPagePath, global::System.UriKind.RelativeOrAbsolute));
					num = (short)886112256;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 5:
					if (((global::AcpUI.AcpRecNavToolbar)A_0).Name == global::AllFeatures.CodeplugGuid.b("鯈껊껌臎냐ꗒ臔룖뛘럚뿜뻞鏠돢蓤胦賨꿪믬뷮ꋰꏲ蟴飶鿸鋺釼髾爀", a_))
					{
						num = (short)1302986753;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_183;
				case 6:
				{
					global::AcpCommonLib.IAcpRecordset myRecordsetDataSource;
					if (myRecordsetDataSource != null)
					{
						num = (short)1765015556;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_183;
				}
				}
				IL_72:
				if (A_0 is global::AcpUI.AcpRecNavToolbar)
				{
					num = (short)1343488003;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_183:
				num = (short)247350095;
				short num4 = num;
				num = (short)285098831;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_72;
				default:
					goto IL_1B8;
				}
			}
			IL_1B8:
			num = (short)2141192192;
			if (num != 0)
			{
			}
		}

		// Token: 0x06009E53 RID: 40531 RVA: 0x0093D1E8 File Offset: 0x0093B3E8
		private void HLinkClick(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num = (short)1840816926;
			short num2 = num;
			num = (short)228827934;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1067515904;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1346174977;
			if (num != 0)
			{
			}
			num = (short)26017792;
			if (num != 0)
			{
			}
			base.OnHLinkClick(A_0);
		}

		// Token: 0x06009E54 RID: 40532 RVA: 0x0093D298 File Offset: 0x0093B498
		private void OnFieldNameDoubleClick(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num = (short)2068487935;
			short num2 = num;
			num = (short)943955711;
			switch (num2 == num)
			{
			default:
			{
				num = (short)792920064;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)806158336;
			if (num != 0)
			{
			}
			num = (short)1579745281;
			if (num != 0)
			{
			}
			global::AcpUI.Common.Utility.GetFieldHelpText(A_0);
		}

		// Token: 0x06009E55 RID: 40533 RVA: 0x0093D348 File Offset: 0x0093B548
		[global::System.Diagnostics.DebuggerNonUserCode]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "5.0.10.0")]
		public void InitializeComponent()
		{
			int a_ = 8;
			short num = (short)2035026433;
			short num2 = num;
			num = (short)887163393;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
				num = (short)2080374784;
				if (num != 0)
				{
				}
				if (this.b)
				{
					num = (short)661258241;
					if (num != 0)
					{
					}
					return;
				}
				break;
			}
			num = (short)2098987008;
			short num3 = num;
			this.b = true;
			global::System.Uri resourceLocator = new global::System.Uri(global::AllFeatures.CodeplugGuid.b("諊ꇌꏎ韐뛒듔ꏖ곘꧚룜곞\udae0胢諤諦駨蓪菬諮鿰蟲\udaf4鏶迸觺軼\udafe㌀㌂昄栆月洊搌栎搐愒琔挖瀘琚猜〞䔠唢圤否నᤪᴬ弮䌰尲匴帶唸帺丼ှ╀㕂㝄㑆㥈㥊≌⥎㡐㽒ご⑖睘⍚㱜㉞ൠ", a_), global::System.UriKind.Relative);
			global::System.Windows.Application.LoadComponent(this, resourceLocator);
		}

		// Token: 0x06009E56 RID: 40534 RVA: 0x0093D42C File Offset: 0x0093B62C
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "5.0.10.0")]
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::System.Diagnostics.DebuggerNonUserCode]
		void global::System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
		{
			short num = (short)1842544640;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					num = (short)345047041;
					if (num != 0)
					{
					}
					switch (0)
					{
					case 0:
						goto IL_56;
					}
					continue;
				case 1:
					goto IL_2BA;
				case 2:
					num = (short)1080885249;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_56:
				switch (connectionId)
				{
				case 1:
					goto IL_7B3;
				case 2:
					goto IL_440;
				case 3:
					goto IL_4E0;
				case 4:
					goto IL_8A8;
				case 5:
					goto IL_8CC;
				case 6:
					goto IL_782;
				case 7:
					goto IL_54F;
				case 8:
					goto IL_A02;
				case 9:
					goto IL_78F;
				case 10:
					goto IL_687;
				case 11:
					goto IL_51E;
				case 12:
					goto IL_224;
				case 13:
					goto IL_4D3;
				case 14:
					goto IL_2CC;
				case 15:
					goto IL_75E;
				case 16:
					goto IL_55C;
				case 17:
					goto IL_2BF;
				case 18:
					goto IL_625;
				case 19:
					goto IL_20A;
				case 20:
					goto IL_362;
				case 21:
					goto IL_7E4;
				case 22:
					goto IL_26F;
				case 23:
					goto IL_2F0;
				case 24:
					goto IL_426;
				case 25:
					goto IL_419;
				case 26:
					goto IL_4FA;
				case 27:
					goto IL_3AA;
				case 28:
					goto IL_58D;
				case 29:
					goto IL_355;
				case 30:
					goto IL_948;
				case 31:
					goto IL_9AA;
				case 32:
					goto IL_917;
				case 33:
					goto IL_488;
				case 34:
					goto IL_86A;
				case 35:
					goto IL_4B9;
				case 36:
					goto IL_33B;
				case 37:
					goto IL_32E;
				case 38:
					goto IL_63F;
				case 39:
					goto IL_808;
				case 40:
					goto IL_296;
				case 41:
					goto IL_6D2;
				case 42:
					goto IL_72A;
				case 43:
					goto IL_6C5;
				case 44:
					goto IL_6DF;
				case 45:
					goto IL_464;
				case 46:
					goto IL_9D1;
				case 47:
					goto IL_71D;
				case 48:
					goto IL_433;
				case 49:
					goto IL_8FD;
				case 50:
					goto IL_90A;
				case 51:
					goto IL_6EC;
				case 52:
					goto IL_663;
				case 53:
					goto IL_1FD;
				case 54:
					goto IL_6B8;
				case 55:
					goto IL_262;
				case 56:
					goto IL_751;
				case 57:
					goto IL_632;
				case 58:
					goto IL_569;
				case 59:
					goto IL_877;
				case 60:
					goto IL_348;
				case 61:
					goto IL_737;
				case 62:
					goto IL_93B;
				case 63:
					goto IL_85D;
				case 64:
					goto IL_231;
				case 65:
					goto IL_8D9;
				case 66:
					goto IL_1F0;
				case 67:
					goto IL_850;
				case 68:
					goto IL_6AB;
				case 69:
					goto IL_5A7;
				case 70:
					goto IL_4AC;
				case 71:
					goto IL_82C;
				case 72:
					goto IL_52B;
				case 73:
					goto IL_9C4;
				case 74:
					goto IL_321;
				case 75:
					goto IL_744;
				case 76:
					goto IL_217;
				case 77:
					goto IL_386;
				case 78:
					goto IL_5B4;
				case 79:
					goto IL_59A;
				case 80:
					goto IL_89B;
				case 81:
					goto IL_4C6;
				case 82:
					goto IL_27C;
				case 83:
					goto IL_5D8;
				case 84:
					goto IL_2FD;
				case 85:
					goto IL_255;
				case 86:
					goto IL_979;
				case 87:
					goto IL_4ED;
				case 88:
					goto IL_710;
				case 89:
					goto IL_986;
				case 90:
					goto IL_955;
				case 91:
					goto IL_289;
				case 92:
					goto IL_9B7;
				case 93:
					goto IL_9F5;
				default:
					num = (short)278396930;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
			}
			IL_1F0:
			this.RTDBtnDVRSProfGeneralLocalTxFallback_A41806 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_1FD:
			this.RTDBtnDVRSProfGeneralMSUSysPTTInLocalMode_A41803 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_20A:
			this.CVBtnDVRSProfGeneralGenStsOnDVRSModChg_A41801 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_217:
			this.CVBtnDVRSProfGeneralProxyLimitPatienceTimer_A41808 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_224:
			this.DVRSProfGeneralDVRSProfName_A41809Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_231:
			this.LblDVRSProfGeneralLocalTxFallback_A41806 = (global::AcpUI.AcpLabel)target;
			this.LblDVRSProfGeneralLocalTxFallback_A41806.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_255:
			this.RTDBtnDVRSProfGeneralProxyRFSSReponseTimer_A41810 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_262:
			this.DVRSProfGeneralMSUSysPTTInLocalMode_A41803Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_26F:
			this.RTDBtnDVRSProfGeneralGenStsOnDVRSModChg_A41801 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_27C:
			this.CVBtnDVRSProfGeneralProxyRFSSReponseTimer_A41810 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_289:
			this.RTDBtnDVRSProfGeneralSuspendScanOnDVRSActive_42782 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_296:
			this.RTDBtnDVRSProfGeneralICMAllowed_A41802 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_2BA:
			this.b = true;
			return;
			IL_2BF:
			this.CpyBtnDVRSProfGeneralDVRSRemoteActivation_A41800 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_2CC:
			this.LblDVRSProfGeneralDVRSRemoteActivation_A41800 = (global::AcpUI.AcpLabel)target;
			this.LblDVRSProfGeneralDVRSRemoteActivation_A41800.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_2F0:
			this.CpyBtnDVRSProfGeneralGenStsOnDVRSModChg_A41801 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_2FD:
			this.DVRSProfGeneralProxyRFSSReponseTimer_A41810 = (global::AcpUI.AcpTextBoxSpinner)target;
			this.DVRSProfGeneralProxyRFSSReponseTimer_A41810.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_321:
			this.CpyBtnDVRSProfGeneralProxyTimeOutTimer_A41807 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_32E:
			this.CVBtnDVRSProfGeneralICMAllowed_A41802 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_33B:
			this.DVRSProfGeneralGenStsLegacyModeComp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_348:
			this.RTDBtnDVRSProfGeneralRouteMSUPTTMicAudToDVR_A41805 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_355:
			this.CpyBtnDVRSProfGeneralGenStsOnDVRSModChgHoldoff_A41869 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_362:
			this.LblDVRSProfGeneralGenStsOnDVRSModChg_A41801 = (global::AcpUI.AcpLabel)target;
			this.LblDVRSProfGeneralGenStsOnDVRSModChg_A41801.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_386:
			this.LblDVRSProfGeneralProxyLimitPatienceTimer_A41808 = (global::AcpUI.AcpLabel)target;
			this.LblDVRSProfGeneralProxyLimitPatienceTimer_A41808.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_3AA:
			num = (short)692221594;
			short num3 = num;
			num = (short)483161754;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_85D:
				this.CVBtnDVRSProfGeneralLocalTxFallback_A41806 = (global::AcpUI.AcpCustomViewCheckBox)target;
				return;
			default:
				num = (short)93126656;
				if (num != 0)
				{
				}
				this.DVRSProfGeneralGenStsOnDVRSModChgHoldoff_A41869 = (global::AcpUI.AcpTextBoxSpinner)target;
				this.DVRSProfGeneralGenStsOnDVRSModChgHoldoff_A41869.GotFocus += this.OnFieldNameDoubleClick;
				return;
			}
			IL_419:
			this.CVBtnDVRSProfGeneralGenStsOnDVRSModChgHoldoff_A41869 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_426:
			this.DVRSProfGeneralGenStsOnDVRSModChg_A41801Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_433:
			this.CpyBtnDVRSProfGeneralOutSysRepLocalMode_A41804 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_440:
			this.RecNavToolbarPageDVRSProfiles = (global::AcpUI.AcpParentRecNavToolbar)target;
			this.RecNavToolbarPageDVRSProfiles.ModeClick += this.OnModeClick;
			return;
			IL_464:
			this.LblDVRSProfGeneralOutSysRepLocalMode_A41804 = (global::AcpUI.AcpLabel)target;
			this.LblDVRSProfGeneralOutSysRepLocalMode_A41804.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_488:
			this.DVRSProfGeneralGenStsLegacyMode = (global::AcpUI.AcpCheckBox)target;
			this.DVRSProfGeneralGenStsLegacyMode.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_4AC:
			this.CVBtnDVRSProfGeneralProxyTimeOutTimer_A41807 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_4B9:
			this.CpyBtnDVRSProfGeneralGenStsLegacyMode = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_4C6:
			this.DVRSProfGeneralProxyLimitPatienceTimer_A41808Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_4D3:
			this.CVBtnDVRSProfGeneralDVRSRemoteActivation_A41800 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_4E0:
			this.ThemeBaseObj = (global::AcpUI.Common.AcpThemeBase)target;
			return;
			IL_4ED:
			this.DVRSProfGeneralProxyRFSSReponseTimer_A41810Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_4FA:
			this.LblDVRSProfGeneralGenStsOnDVRSModChgHoldoff_A41869 = (global::AcpUI.AcpLabel)target;
			this.LblDVRSProfGeneralGenStsOnDVRSModChgHoldoff_A41869.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_51E:
			this.CpyBtnDVRSProfGeneralDVRSProfName_A41809 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_52B:
			this.DVRSProfGeneralProxyTimeOutTimer_A41807 = (global::AcpUI.AcpTextBoxSpinner)target;
			this.DVRSProfGeneralProxyTimeOutTimer_A41807.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_54F:
			this.GrpBoxExpanderDVRSProfilesGeneralPseudo0 = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_55C:
			this.RTDBtnDVRSProfGeneralDVRSRemoteActivation_A41800 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_569:
			this.LblDVRSProfGeneralRouteMSUPTTMicAudToDVR_A41805 = (global::AcpUI.AcpLabel)target;
			this.LblDVRSProfGeneralRouteMSUPTTMicAudToDVR_A41805.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_58D:
			this.RTDBtnDVRSProfGeneralGenStsOnDVRSModChgHoldoff_A41869 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_59A:
			this.RTDBtnDVRSProfGeneralProxyLimitPatienceTimer_A41808 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_5A7:
			this.GrpBoxExpanderDVRSProfilesGeneralPseudo2 = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_5B4:
			this.DVRSProfGeneralProxyLimitPatienceTimer_A41808 = (global::AcpUI.AcpTextBoxSpinner)target;
			this.DVRSProfGeneralProxyLimitPatienceTimer_A41808.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_5D8:
			num = (short)2037252096;
			short num4 = num;
			this.LblDVRSProfGeneralProxyRFSSReponseTimer_A41810 = (global::AcpUI.AcpLabel)target;
			this.LblDVRSProfGeneralProxyRFSSReponseTimer_A41810.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_625:
			this.DVRSProfGeneralDVRSRemoteActivation_A41800Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_632:
			this.CVBtnDVRSProfGeneralRouteMSUPTTMicAudToDVR_A41805 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_63F:
			this.LblDVRSProfGeneralICMAllowed_A41802 = (global::AcpUI.AcpLabel)target;
			this.LblDVRSProfGeneralICMAllowed_A41802.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_663:
			this.DVRSProfGeneralMSUSysPTTInLocalMode_A41803 = (global::AcpUI.AcpCheckBox)target;
			this.DVRSProfGeneralMSUSysPTTInLocalMode_A41803.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_687:
			this.DVRSProfGeneralDVRSProfName_A41809 = (global::AcpUI.AcpTextBox)target;
			this.DVRSProfGeneralDVRSProfName_A41809.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_6AB:
			this.DVRSProfGeneralLocalTxFallback_A41806Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_6B8:
			this.CpyBtnDVRSProfGeneralMSUSysPTTInLocalMode_A41803 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_6C5:
			this.GrpBoxExpanderDVRSProfilesGeneralLocalMode = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_6D2:
			this.CpyBtnDVRSProfGeneralICMAllowed_A41802 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_6DF:
			this.CVBtnDVRSProfGeneralOutSysRepLocalMode_A41804 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_6EC:
			this.LblDVRSProfGeneralMSUSysPTTInLocalMode_A41803 = (global::AcpUI.AcpLabel)target;
			this.LblDVRSProfGeneralMSUSysPTTInLocalMode_A41803.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_710:
			this.CVBtnDVRSProfGeneralSuspendScanOnDVRSActive_42782 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_71D:
			this.RTDBtnDVRSProfGeneralOutSysRepLocalMode_A41804 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_72A:
			this.DVRSProfGeneralICMAllowed_A41802Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_737:
			this.CpyBtnDVRSProfGeneralRouteMSUPTTMicAudToDVR_A41805 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_744:
			this.DVRSProfGeneralProxyTimeOutTimer_A41807Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_751:
			this.GrpBoxExpanderDVRSProfilesGeneralSystemMode = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_75E:
			this.DVRSProfGeneralDVRSRemoteActivation_A41800 = (global::AcpUI.AcpComboBox)target;
			this.DVRSProfGeneralDVRSRemoteActivation_A41800.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_782:
			this.ExpanderDVRSProfilesGeneral = (global::AcpUI.AcpExpander)target;
			return;
			IL_78F:
			this.LblDVRSProfGeneralDVRSProfName_A41809 = (global::AcpUI.AcpLabel)target;
			this.LblDVRSProfGeneralDVRSProfName_A41809.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_7B3:
			((global::Motorola.MackinawCPS.CoreFeatures.DVRSProfiles.PageDVRSProfiles)target).Loaded += this.OnLoaded;
			((global::Motorola.MackinawCPS.CoreFeatures.DVRSProfiles.PageDVRSProfiles)target).Unloaded += this.OnUnloaded;
			return;
			IL_7E4:
			this.DVRSProfGeneralGenStsOnDVRSModChg_A41801 = (global::AcpUI.AcpCheckBox)target;
			this.DVRSProfGeneralGenStsOnDVRSModChg_A41801.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_808:
			this.DVRSProfGeneralICMAllowed_A41802 = (global::AcpUI.AcpCheckBox)target;
			this.DVRSProfGeneralICMAllowed_A41802.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_82C:
			this.LblDVRSProfGeneralProxyTimeOutTimer_A41807 = (global::AcpUI.AcpLabel)target;
			this.LblDVRSProfGeneralProxyTimeOutTimer_A41807.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_850:
			this.CpyBtnDVRSProfGeneralLocalTxFallback_A41806 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_86A:
			this.RTDBtnDVRSProfGeneralGenStsLegacyMode = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_877:
			this.DVRSProfGeneralRouteMSUPTTMicAudToDVR_A41805 = (global::AcpUI.AcpCheckBox)target;
			this.DVRSProfGeneralRouteMSUPTTMicAudToDVR_A41805.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_89B:
			this.CpyBtnDVRSProfGeneralProxyLimitPatienceTimer_A41808 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_8A8:
			this.HLinkGeneral = (global::System.Windows.Documents.Hyperlink)target;
			this.HLinkGeneral.Click += this.HLinkClick;
			return;
			IL_8CC:
			this.MyStackPanel = (global::System.Windows.Controls.StackPanel)target;
			return;
			IL_8D9:
			this.DVRSProfGeneralLocalTxFallback_A41806 = (global::AcpUI.AcpCheckBox)target;
			this.DVRSProfGeneralLocalTxFallback_A41806.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_8FD:
			this.DVRSProfGeneralOutSysRepLocalMode_A41804Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_90A:
			this.CVBtnDVRSProfGeneralMSUSysPTTInLocalMode_A41803 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_917:
			this.LblDVRSProfGeneralGenStsLegacyMode = (global::AcpUI.AcpLabel)target;
			this.LblDVRSProfGeneralGenStsLegacyMode.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_93B:
			this.DVRSProfGeneralRouteMSUPTTMicAudToDVR_A41805Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_948:
			this.DVRSProfGeneralGenStsOnDVRSModChgHoldoff_A41869Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_955:
			this.DVRSProfGeneralSuspendScanOnDVRSActive_42782 = (global::AcpUI.AcpCheckBox)target;
			this.DVRSProfGeneralSuspendScanOnDVRSActive_42782.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_979:
			this.CpyBtnDVRSProfGeneralProxyRFSSReponseTimer_A41810 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_986:
			this.LblDVRSProfGeneralSuspendScanOnDVRSActive_42782 = (global::AcpUI.AcpLabel)target;
			this.LblDVRSProfGeneralSuspendScanOnDVRSActive_42782.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_9AA:
			this.CVBtnDVRSProfGeneralGenStsLegacyMode = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_9B7:
			this.CpyBtnDVRSProfGeneralSuspendScanOnDVRSActive_42782 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_9C4:
			this.RTDBtnDVRSProfGeneralProxyTimeOutTimer_A41807 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_9D1:
			this.DVRSProfGeneralOutSysRepLocalMode_A41804 = (global::AcpUI.AcpCheckBox)target;
			this.DVRSProfGeneralOutSysRepLocalMode_A41804.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_9F5:
			this.DVRSProfGeneralSuspendScanOnDVRSActive_42782Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_A02:
			this.CVBtnDVRSProfGeneralDVRSProfName_A41809 = (global::AcpUI.AcpCustomViewCheckBox)target;
		}

		// Token: 0x04004D56 RID: 19798
		private bool a;

		// Token: 0x04004D57 RID: 19799
		internal global::AcpUI.AcpParentRecNavToolbar RecNavToolbarPageDVRSProfiles;

		// Token: 0x04004D58 RID: 19800
		internal global::AcpUI.Common.AcpThemeBase ThemeBaseObj;

		// Token: 0x04004D59 RID: 19801
		internal global::System.Windows.Documents.Hyperlink HLinkGeneral;

		// Token: 0x04004D5A RID: 19802
		internal global::System.Windows.Controls.StackPanel MyStackPanel;

		// Token: 0x04004D5B RID: 19803
		internal global::AcpUI.AcpExpander ExpanderDVRSProfilesGeneral;

		// Token: 0x04004D5C RID: 19804
		internal global::AcpUI.AcpGroupBox GrpBoxExpanderDVRSProfilesGeneralPseudo0;

		// Token: 0x04004D5D RID: 19805
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnDVRSProfGeneralDVRSProfName_A41809;

		// Token: 0x04004D5E RID: 19806
		internal global::AcpUI.AcpLabel LblDVRSProfGeneralDVRSProfName_A41809;

		// Token: 0x04004D5F RID: 19807
		internal global::AcpUI.AcpTextBox DVRSProfGeneralDVRSProfName_A41809;

		// Token: 0x04004D60 RID: 19808
		internal global::AcpUI.AcpCopyButton CpyBtnDVRSProfGeneralDVRSProfName_A41809;

		// Token: 0x04004D61 RID: 19809
		internal global::AcpUI.AcpLabel DVRSProfGeneralDVRSProfName_A41809Comp;

		// Token: 0x04004D62 RID: 19810
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnDVRSProfGeneralDVRSRemoteActivation_A41800;

		// Token: 0x04004D63 RID: 19811
		internal global::AcpUI.AcpLabel LblDVRSProfGeneralDVRSRemoteActivation_A41800;

		// Token: 0x04004D64 RID: 19812
		internal global::AcpUI.AcpComboBox DVRSProfGeneralDVRSRemoteActivation_A41800;

		// Token: 0x04004D65 RID: 19813
		internal global::AcpUI.AcpRtdButton RTDBtnDVRSProfGeneralDVRSRemoteActivation_A41800;

		// Token: 0x04004D66 RID: 19814
		internal global::AcpUI.AcpCopyButton CpyBtnDVRSProfGeneralDVRSRemoteActivation_A41800;

		// Token: 0x04004D67 RID: 19815
		internal global::AcpUI.AcpLabel DVRSProfGeneralDVRSRemoteActivation_A41800Comp;

		// Token: 0x04004D68 RID: 19816
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnDVRSProfGeneralGenStsOnDVRSModChg_A41801;

		// Token: 0x04004D69 RID: 19817
		internal global::AcpUI.AcpLabel LblDVRSProfGeneralGenStsOnDVRSModChg_A41801;

		// Token: 0x04004D6A RID: 19818
		internal global::AcpUI.AcpCheckBox DVRSProfGeneralGenStsOnDVRSModChg_A41801;

		// Token: 0x04004D6B RID: 19819
		internal global::AcpUI.AcpRtdButton RTDBtnDVRSProfGeneralGenStsOnDVRSModChg_A41801;

		// Token: 0x04004D6C RID: 19820
		internal global::AcpUI.AcpCopyButton CpyBtnDVRSProfGeneralGenStsOnDVRSModChg_A41801;

		// Token: 0x04004D6D RID: 19821
		internal global::AcpUI.AcpCheckBox DVRSProfGeneralGenStsOnDVRSModChg_A41801Comp;

		// Token: 0x04004D6E RID: 19822
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnDVRSProfGeneralGenStsOnDVRSModChgHoldoff_A41869;

		// Token: 0x04004D6F RID: 19823
		internal global::AcpUI.AcpLabel LblDVRSProfGeneralGenStsOnDVRSModChgHoldoff_A41869;

		// Token: 0x04004D70 RID: 19824
		internal global::AcpUI.AcpTextBoxSpinner DVRSProfGeneralGenStsOnDVRSModChgHoldoff_A41869;

		// Token: 0x04004D71 RID: 19825
		internal global::AcpUI.AcpRtdButton RTDBtnDVRSProfGeneralGenStsOnDVRSModChgHoldoff_A41869;

		// Token: 0x04004D72 RID: 19826
		internal global::AcpUI.AcpCopyButton CpyBtnDVRSProfGeneralGenStsOnDVRSModChgHoldoff_A41869;

		// Token: 0x04004D73 RID: 19827
		internal global::AcpUI.AcpLabel DVRSProfGeneralGenStsOnDVRSModChgHoldoff_A41869Comp;

		// Token: 0x04004D74 RID: 19828
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnDVRSProfGeneralGenStsLegacyMode;

		// Token: 0x04004D75 RID: 19829
		internal global::AcpUI.AcpLabel LblDVRSProfGeneralGenStsLegacyMode;

		// Token: 0x04004D76 RID: 19830
		internal global::AcpUI.AcpCheckBox DVRSProfGeneralGenStsLegacyMode;

		// Token: 0x04004D77 RID: 19831
		internal global::AcpUI.AcpRtdButton RTDBtnDVRSProfGeneralGenStsLegacyMode;

		// Token: 0x04004D78 RID: 19832
		internal global::AcpUI.AcpCopyButton CpyBtnDVRSProfGeneralGenStsLegacyMode;

		// Token: 0x04004D79 RID: 19833
		internal global::AcpUI.AcpCheckBox DVRSProfGeneralGenStsLegacyModeComp;

		// Token: 0x04004D7A RID: 19834
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnDVRSProfGeneralICMAllowed_A41802;

		// Token: 0x04004D7B RID: 19835
		internal global::AcpUI.AcpLabel LblDVRSProfGeneralICMAllowed_A41802;

		// Token: 0x04004D7C RID: 19836
		internal global::AcpUI.AcpCheckBox DVRSProfGeneralICMAllowed_A41802;

		// Token: 0x04004D7D RID: 19837
		internal global::AcpUI.AcpRtdButton RTDBtnDVRSProfGeneralICMAllowed_A41802;

		// Token: 0x04004D7E RID: 19838
		internal global::AcpUI.AcpCopyButton CpyBtnDVRSProfGeneralICMAllowed_A41802;

		// Token: 0x04004D7F RID: 19839
		internal global::AcpUI.AcpCheckBox DVRSProfGeneralICMAllowed_A41802Comp;

		// Token: 0x04004D80 RID: 19840
		internal global::AcpUI.AcpGroupBox GrpBoxExpanderDVRSProfilesGeneralLocalMode;

		// Token: 0x04004D81 RID: 19841
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnDVRSProfGeneralOutSysRepLocalMode_A41804;

		// Token: 0x04004D82 RID: 19842
		internal global::AcpUI.AcpLabel LblDVRSProfGeneralOutSysRepLocalMode_A41804;

		// Token: 0x04004D83 RID: 19843
		internal global::AcpUI.AcpCheckBox DVRSProfGeneralOutSysRepLocalMode_A41804;

		// Token: 0x04004D84 RID: 19844
		internal global::AcpUI.AcpRtdButton RTDBtnDVRSProfGeneralOutSysRepLocalMode_A41804;

		// Token: 0x04004D85 RID: 19845
		internal global::AcpUI.AcpCopyButton CpyBtnDVRSProfGeneralOutSysRepLocalMode_A41804;

		// Token: 0x04004D86 RID: 19846
		internal global::AcpUI.AcpCheckBox DVRSProfGeneralOutSysRepLocalMode_A41804Comp;

		// Token: 0x04004D87 RID: 19847
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnDVRSProfGeneralMSUSysPTTInLocalMode_A41803;

		// Token: 0x04004D88 RID: 19848
		internal global::AcpUI.AcpLabel LblDVRSProfGeneralMSUSysPTTInLocalMode_A41803;

		// Token: 0x04004D89 RID: 19849
		internal global::AcpUI.AcpCheckBox DVRSProfGeneralMSUSysPTTInLocalMode_A41803;

		// Token: 0x04004D8A RID: 19850
		internal global::AcpUI.AcpRtdButton RTDBtnDVRSProfGeneralMSUSysPTTInLocalMode_A41803;

		// Token: 0x04004D8B RID: 19851
		internal global::AcpUI.AcpCopyButton CpyBtnDVRSProfGeneralMSUSysPTTInLocalMode_A41803;

		// Token: 0x04004D8C RID: 19852
		internal global::AcpUI.AcpCheckBox DVRSProfGeneralMSUSysPTTInLocalMode_A41803Comp;

		// Token: 0x04004D8D RID: 19853
		internal global::AcpUI.AcpGroupBox GrpBoxExpanderDVRSProfilesGeneralSystemMode;

		// Token: 0x04004D8E RID: 19854
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnDVRSProfGeneralRouteMSUPTTMicAudToDVR_A41805;

		// Token: 0x04004D8F RID: 19855
		internal global::AcpUI.AcpLabel LblDVRSProfGeneralRouteMSUPTTMicAudToDVR_A41805;

		// Token: 0x04004D90 RID: 19856
		internal global::AcpUI.AcpCheckBox DVRSProfGeneralRouteMSUPTTMicAudToDVR_A41805;

		// Token: 0x04004D91 RID: 19857
		internal global::AcpUI.AcpRtdButton RTDBtnDVRSProfGeneralRouteMSUPTTMicAudToDVR_A41805;

		// Token: 0x04004D92 RID: 19858
		internal global::AcpUI.AcpCopyButton CpyBtnDVRSProfGeneralRouteMSUPTTMicAudToDVR_A41805;

		// Token: 0x04004D93 RID: 19859
		internal global::AcpUI.AcpCheckBox DVRSProfGeneralRouteMSUPTTMicAudToDVR_A41805Comp;

		// Token: 0x04004D94 RID: 19860
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnDVRSProfGeneralLocalTxFallback_A41806;

		// Token: 0x04004D95 RID: 19861
		internal global::AcpUI.AcpLabel LblDVRSProfGeneralLocalTxFallback_A41806;

		// Token: 0x04004D96 RID: 19862
		internal global::AcpUI.AcpCheckBox DVRSProfGeneralLocalTxFallback_A41806;

		// Token: 0x04004D97 RID: 19863
		internal global::AcpUI.AcpRtdButton RTDBtnDVRSProfGeneralLocalTxFallback_A41806;

		// Token: 0x04004D98 RID: 19864
		internal global::AcpUI.AcpCopyButton CpyBtnDVRSProfGeneralLocalTxFallback_A41806;

		// Token: 0x04004D99 RID: 19865
		internal global::AcpUI.AcpCheckBox DVRSProfGeneralLocalTxFallback_A41806Comp;

		// Token: 0x04004D9A RID: 19866
		internal global::AcpUI.AcpGroupBox GrpBoxExpanderDVRSProfilesGeneralPseudo2;

		// Token: 0x04004D9B RID: 19867
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnDVRSProfGeneralProxyTimeOutTimer_A41807;

		// Token: 0x04004D9C RID: 19868
		internal global::AcpUI.AcpLabel LblDVRSProfGeneralProxyTimeOutTimer_A41807;

		// Token: 0x04004D9D RID: 19869
		internal global::AcpUI.AcpTextBoxSpinner DVRSProfGeneralProxyTimeOutTimer_A41807;

		// Token: 0x04004D9E RID: 19870
		internal global::AcpUI.AcpRtdButton RTDBtnDVRSProfGeneralProxyTimeOutTimer_A41807;

		// Token: 0x04004D9F RID: 19871
		internal global::AcpUI.AcpCopyButton CpyBtnDVRSProfGeneralProxyTimeOutTimer_A41807;

		// Token: 0x04004DA0 RID: 19872
		internal global::AcpUI.AcpLabel DVRSProfGeneralProxyTimeOutTimer_A41807Comp;

		// Token: 0x04004DA1 RID: 19873
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnDVRSProfGeneralProxyLimitPatienceTimer_A41808;

		// Token: 0x04004DA2 RID: 19874
		internal global::AcpUI.AcpLabel LblDVRSProfGeneralProxyLimitPatienceTimer_A41808;

		// Token: 0x04004DA3 RID: 19875
		internal global::AcpUI.AcpTextBoxSpinner DVRSProfGeneralProxyLimitPatienceTimer_A41808;

		// Token: 0x04004DA4 RID: 19876
		internal global::AcpUI.AcpRtdButton RTDBtnDVRSProfGeneralProxyLimitPatienceTimer_A41808;

		// Token: 0x04004DA5 RID: 19877
		internal global::AcpUI.AcpCopyButton CpyBtnDVRSProfGeneralProxyLimitPatienceTimer_A41808;

		// Token: 0x04004DA6 RID: 19878
		internal global::AcpUI.AcpLabel DVRSProfGeneralProxyLimitPatienceTimer_A41808Comp;

		// Token: 0x04004DA7 RID: 19879
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnDVRSProfGeneralProxyRFSSReponseTimer_A41810;

		// Token: 0x04004DA8 RID: 19880
		internal global::AcpUI.AcpLabel LblDVRSProfGeneralProxyRFSSReponseTimer_A41810;

		// Token: 0x04004DA9 RID: 19881
		internal global::AcpUI.AcpTextBoxSpinner DVRSProfGeneralProxyRFSSReponseTimer_A41810;

		// Token: 0x04004DAA RID: 19882
		internal global::AcpUI.AcpRtdButton RTDBtnDVRSProfGeneralProxyRFSSReponseTimer_A41810;

		// Token: 0x04004DAB RID: 19883
		internal global::AcpUI.AcpCopyButton CpyBtnDVRSProfGeneralProxyRFSSReponseTimer_A41810;

		// Token: 0x04004DAC RID: 19884
		internal global::AcpUI.AcpLabel DVRSProfGeneralProxyRFSSReponseTimer_A41810Comp;

		// Token: 0x04004DAD RID: 19885
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnDVRSProfGeneralSuspendScanOnDVRSActive_42782;

		// Token: 0x04004DAE RID: 19886
		internal global::AcpUI.AcpLabel LblDVRSProfGeneralSuspendScanOnDVRSActive_42782;

		// Token: 0x04004DAF RID: 19887
		internal global::AcpUI.AcpCheckBox DVRSProfGeneralSuspendScanOnDVRSActive_42782;

		// Token: 0x04004DB0 RID: 19888
		internal global::AcpUI.AcpRtdButton RTDBtnDVRSProfGeneralSuspendScanOnDVRSActive_42782;

		// Token: 0x04004DB1 RID: 19889
		internal global::AcpUI.AcpCopyButton CpyBtnDVRSProfGeneralSuspendScanOnDVRSActive_42782;

		// Token: 0x04004DB2 RID: 19890
		internal global::AcpUI.AcpCheckBox DVRSProfGeneralSuspendScanOnDVRSActive_42782Comp;

		// Token: 0x04004DB3 RID: 19891
		private bool b;
	}
}
