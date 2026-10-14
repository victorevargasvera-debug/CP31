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

namespace Motorola.MackinawCPS.CoreFeatures.ScanWide
{
	// Token: 0x0200010C RID: 268
	public class PageScanWide : global::AcpUI.AcpPageFeature, global::System.Windows.Markup.IComponentConnector
	{
		// Token: 0x0600279C RID: 10140 RVA: 0x0026710C File Offset: 0x0026530C
		public PageScanWide()
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

		// Token: 0x0600279D RID: 10141 RVA: 0x00267144 File Offset: 0x00265344
		public override void OnLoaded(object sender, global::System.Windows.RoutedEventArgs e)
		{
			short num = (short)937820160;
			short num2 = num;
			num = (short)1271136257;
			int num3 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				global::System.Collections.IEnumerator enumerator;
				global::AcpUI.AcpExpander acpExpander;
				switch (num3)
				{
				case 0:
					goto IL_231;
				case 1:
				{
					num = (short)485368540;
					short num4 = num;
					num = (short)493691612;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_2B1;
					default:
						num = (short)702218240;
						if (num != 0)
						{
						}
						switch (0)
						{
						case 0:
							goto IL_A6;
						}
						continue;
					}
					break;
				}
				case 2:
					goto IL_2AF;
				case 3:
					try
					{
						num = (short)1553989633;
						num3 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num3)
							{
							case 0:
								if (!enumerator.MoveNext())
								{
									num = (short)2088632323;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								acpExpander = (((global::System.Windows.UIElement)enumerator.Current) as global::AcpUI.AcpExpander);
								num = (short)143785988;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							case 1:
								switch (0)
								{
								case 0:
									goto IL_10B;
								}
								continue;
							case 2:
								base.Expanders.Add(acpExpander);
								num = (short)1530986502;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							case 3:
								num = (short)226164741;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							case 4:
								if (acpExpander != null)
								{
									num = (short)339279874;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							case 5:
								goto IL_1BE;
							}
							IL_14C:
							num = (short)533921792;
							num3 = (int)((global::System.IntPtr)num);
							continue;
							IL_10B:
							goto IL_14C;
						}
						IL_1BE:
						goto IL_261;
					}
					finally
					{
						switch (0)
						{
						case 0:
							goto IL_1DF;
						}
						global::System.IDisposable disposable;
						for (;;)
						{
							IL_1CD:
							switch (num3)
							{
							case 0:
								if (disposable != null)
								{
									num = (short)1639776257;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_230;
							case 1:
								disposable.Dispose();
								num = (short)1623130114;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							case 2:
								goto IL_22E;
							}
							goto IL_1DF;
						}
						IL_22E:
						IL_230:
						goto EndFinally_7;
						IL_1DF:
						disposable = (enumerator as global::System.IDisposable);
						num = (short)1823604736;
						num3 = (int)((global::System.IntPtr)num);
						goto IL_1CD;
						EndFinally_7:;
					}
					goto IL_231;
					IL_261:
					num = (short)1910439937;
					if (num != 0)
					{
					}
					base.OnLoaded(sender, e);
					this.a = true;
					num = (short)2074804226;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_A6:
				if (!this.a)
				{
					num = (short)1067450368;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_231:
				acpExpander = null;
				enumerator = this.MyStackPanel.Children.GetEnumerator();
				num = (short)877789187;
				num3 = (int)((global::System.IntPtr)num);
			}
			IL_2AF:
			IL_2B1:
			this.MyStackPanel.Children[0].Focus();
		}

		// Token: 0x0600279E RID: 10142 RVA: 0x0026742C File Offset: 0x0026562C
		public override void OnUnloaded(object sender, global::System.Windows.RoutedEventArgs e)
		{
			short num = (short)2087366078;
			short num2 = num;
			num = (short)510569918;
			int num3;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_C5:
				base.OnUnloaded(sender, e);
				this.a = false;
				num = (short)588644354;
				num3 = (int)((global::System.IntPtr)num);
				break;
			default:
				num = (short)1480785921;
				if (num != 0)
				{
				}
				num = (short)1994784768;
				if (num != 0)
				{
				}
				num = (short)1061617664;
				num3 = (int)((global::System.IntPtr)num);
				break;
			}
			for (;;)
			{
				switch (num3)
				{
				case 0:
					switch (0)
					{
					case 0:
						goto IL_A7;
					}
					continue;
				case 1:
					goto IL_C5;
				case 2:
					goto IL_EA;
				}
				IL_A7:
				if (!this.a)
				{
					break;
				}
				num = (short)1142489089;
				num3 = (int)((global::System.IntPtr)num);
			}
			IL_EA:
			num = (short)1661337600;
			short num4 = num;
		}

		// Token: 0x0600279F RID: 10143 RVA: 0x00267550 File Offset: 0x00265750
		public override void SetDataContext()
		{
			short num = (short)1260847110;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					base.DataContext = global::AcpCommonLib.AppInfoManager.DefaultDocument.GetFeature(2023);
					num = (short)1139212290;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					return;
				case 2:
					goto IL_8E;
				case 3:
					goto IL_8E;
				case 4:
					if (global::AcpCommonLib.AppInfoManager.AppMode == global::AcpCommonLib.ApplicationMode.CodeplugComparisonMode)
					{
						num = (short)467664901;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 5:
					global::AcpCommonLib.AppInfoManager.ComparatorDocument.GetFeature(2023);
					num = (short)60620801;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 6:
					switch (0)
					{
					case 0:
						goto IL_40;
					}
					continue;
				}
				IL_40:
				if (global::AcpCommonLib.AppInfoManager.AppMode != global::AcpCommonLib.ApplicationMode.CustomViewConfigurationMode)
				{
					num = (short)631362311;
					short num3 = num;
					num = (short)128373511;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num = (short)1594687488;
						if (num != 0)
						{
						}
						base.DataContext = global::AcpCommonLib.FeatureManager.GetFeature(2023);
						num = (short)1338638337;
						if (num != 0)
						{
						}
						num = (short)549519363;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
				}
				num = (short)1010171904;
				short num4 = num;
				num = (short)997457920;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_8E:
				num = (short)769589252;
				num2 = (int)((global::System.IntPtr)num);
			}
		}

		// Token: 0x060027A0 RID: 10144 RVA: 0x00267724 File Offset: 0x00265924
		private void HLinkClick(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num = (short)58741033;
			short num2 = num;
			num = (short)1836798249;
			switch (num2 == num)
			{
			}
			num = (short)330563584;
			if (num != 0)
			{
			}
			num = (short)2110914561;
			if (num != 0)
			{
			}
			num = (short)147062784;
			short num3 = num;
			base.OnHLinkClick(A_0);
		}

		// Token: 0x060027A1 RID: 10145 RVA: 0x002677D8 File Offset: 0x002659D8
		private void OnFieldNameDoubleClick(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num = (short)221516210;
			short num2 = num;
			num = (short)1293029810;
			switch (num2 == num)
			{
			}
			num = (short)180748289;
			if (num != 0)
			{
			}
			num = (short)590348288;
			if (num != 0)
			{
			}
			num = (short)1192427520;
			short num3 = num;
			global::AcpUI.Common.Utility.GetFieldHelpText(A_0);
		}

		// Token: 0x060027A2 RID: 10146 RVA: 0x00267888 File Offset: 0x00265A88
		[global::System.Diagnostics.DebuggerNonUserCode]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "5.0.10.0")]
		public void InitializeComponent()
		{
			int a_ = 17;
			short num;
			if (this.b)
			{
				num = (short)1248019384;
				short num2 = num;
				num = (short)495010744;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)983760896;
					if (num != 0)
					{
					}
					return;
				}
			}
			num = (short)984350721;
			if (num != 0)
			{
			}
			num = (short)1655832576;
			short num3 = num;
			this.b = true;
			global::System.Uri resourceLocator = new global::System.Uri(global::AllFeatures.CodeplugGuid.b("﷑闓뫕듗鳙맛뿝铟韡難菥鯧퇩迫臭鷯英鯳飵鷷铹裻퇽珿愁攃栅ⴇ㠉㰋洍缏簑爓缕缗漙減缝吟䬡䬣䠥ܧ天伫伭帯ᜱسص伷匹堻嬽漿ㅁ❃❅♇㵉╋⩍㕏籑ⱓ㝕㕗㙙", a_), global::System.UriKind.Relative);
			global::System.Windows.Application.LoadComponent(this, resourceLocator);
		}

		// Token: 0x060027A3 RID: 10147 RVA: 0x00267968 File Offset: 0x00265B68
		[global::System.Diagnostics.DebuggerNonUserCode]
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "5.0.10.0")]
		void global::System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
		{
			short num = (short)1125253122;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_2D9;
				case 1:
					num = (short)1185153024;
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
					goto IL_845;
				case 2:
					goto IL_4CA;
				case 3:
					goto IL_3CF;
				case 4:
					goto IL_75D;
				case 5:
					goto IL_876;
				case 6:
					goto IL_ADE;
				case 7:
					goto IL_539;
				case 8:
					goto IL_743;
				case 9:
					goto IL_B02;
				case 10:
					goto IL_750;
				case 11:
					goto IL_B0F;
				case 12:
					goto IL_61A;
				case 13:
					goto IL_22C;
				case 14:
					goto IL_508;
				case 15:
					goto IL_4BD;
				case 16:
					goto IL_2EB;
				case 17:
					goto IL_781;
				case 18:
					goto IL_546;
				case 19:
					goto IL_5E6;
				case 20:
					goto IL_2DE;
				case 21:
					goto IL_736;
				case 22:
					goto IL_212;
				case 23:
					goto IL_36A;
				case 24:
					goto IL_909;
				case 25:
					goto IL_28E;
				case 26:
					goto IL_2F8;
				case 27:
					goto IL_3B5;
				case 28:
					goto IL_3A8;
				case 29:
					goto IL_4E4;
				case 30:
					goto IL_577;
				case 31:
					goto IL_39B;
				case 32:
					goto IL_A08;
				case 33:
					goto IL_35D;
				case 34:
					goto IL_AA0;
				case 35:
					goto IL_96B;
				case 36:
					goto IL_472;
				case 37:
					goto IL_8D8;
				case 38:
					goto IL_81E;
				case 39:
					goto IL_4A3;
				case 40:
					goto IL_600;
				case 41:
					goto IL_32C;
				case 42:
					goto IL_31F;
				case 43:
					goto IL_7A5;
				case 44:
					goto IL_67C;
				case 45:
					goto IL_A15;
				case 46:
					goto IL_2B5;
				case 47:
					goto IL_66F;
				case 48:
					goto IL_6EB;
				case 49:
					goto IL_6A0;
				case 50:
					goto IL_8B4;
				case 51:
					goto IL_465;
				case 52:
					goto IL_6DE;
				case 53:
					goto IL_8A7;
				case 54:
					goto IL_3C2;
				case 55:
					goto IL_A7C;
				case 56:
					goto IL_8E5;
				case 57:
					goto IL_82B;
				case 58:
					goto IL_60D;
				case 59:
					goto IL_6C4;
				case 60:
					goto IL_205;
				case 61:
					goto IL_64B;
				case 62:
					goto IL_26A;
				case 63:
					goto IL_729;
				case 64:
					goto IL_5F3;
				case 65:
					goto IL_9D7;
				case 66:
					goto IL_56A;
				case 67:
					goto IL_339;
				case 68:
					goto IL_6F8;
				case 69:
					goto IL_89A;
				case 70:
					goto IL_A2F;
				case 71:
					goto IL_811;
				case 72:
					goto IL_239;
				case 73:
					goto IL_A49;
				case 74:
					goto IL_1F8;
				case 75:
					goto IL_7ED;
				case 76:
					goto IL_7C9;
				case 77:
					goto IL_93A;
				case 78:
					goto IL_5A8;
				case 79:
					goto IL_496;
				case 80:
					goto IL_63E;
				case 81:
					goto IL_947;
				case 82:
					goto IL_515;
				case 83:
					goto IL_312;
				case 84:
					goto IL_71C;
				case 85:
					goto IL_838;
				case 86:
					goto IL_21F;
				case 87:
					goto IL_38E;
				case 88:
					goto IL_59B;
				case 89:
					goto IL_5B5;
				case 90:
					goto IL_9B3;
				case 91:
					goto IL_4B0;
				case 92:
					goto IL_29B;
				case 93:
					goto IL_5D9;
				case 94:
					goto IL_305;
				case 95:
					goto IL_9E4;
				case 96:
					goto IL_246;
				case 97:
					goto IL_4D7;
				case 98:
					goto IL_A22;
				case 99:
					goto IL_6D1;
				case 100:
					goto IL_92D;
				case 101:
					goto IL_98F;
				case 102:
					goto IL_AAD;
				case 103:
					goto IL_2A8;
				case 104:
					goto IL_A3C;
				case 105:
					goto IL_AD1;
				default:
					num = (short)2122776577;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
			}
			IL_1F8:
			this.CVBtnScanWideTrunkingFailsoftHoldTimesec_A8009 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_205:
			this.CVBtnScanWideConventionalTimeBetweenPrioritySamplesms_A9376 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_212:
			this.CVBtnScanWideRadioWideSuspendAllScan_A9232 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_21F:
			this.ExpanderScanWideLabtool = (global::AcpUI.AcpExpander)target;
			return;
			IL_22C:
			this.RTDBtnScanWideRadioWidePriorityScanAlert_A8752 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_239:
			this.ExpanderScanWideTrunking = (global::AcpUI.AcpExpander)target;
			return;
			IL_246:
			this.ScanWideLabtoolScanDetectTimeForCarrierSquelch_A9048 = (global::AcpUI.AcpTextBoxSpinner)target;
			this.ScanWideLabtoolScanDetectTimeForCarrierSquelch_A9048.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_26A:
			this.ScanWideConventionalTimeBetweenPrioritySamplesms_A9376 = (global::AcpUI.AcpTextBoxSpinner)target;
			this.ScanWideConventionalTimeBetweenPrioritySamplesms_A9376.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_28E:
			this.RTDBtnScanWideRadioWideSuspendAllScan_A9232 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_29B:
			this.CpyBtnScanWideLabtoolScanDetectTimeForPL_A9049 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_2A8:
			this.RTDBtnScanWideLabtoolLookbackTime_A8454 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_2B5:
			this.CpyBtnScanWideConventionalCarrierDetectRequired_A7611 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_2D9:
			this.b = true;
			return;
			IL_2DE:
			this.CpyBtnScanWideRadioWideHUBSuspendsScan_A8216 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_2EB:
			this.CVBtnScanWideRadioWideHUBSuspendsScan_A8216 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_2F8:
			this.CpyBtnScanWideRadioWideSuspendAllScan_A9232 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_305:
			this.CVBtnScanWideLabtoolScanDetectTimeForCarrierSquelch_A9048 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_312:
			this.RTDBtnScanWideTrunkingSystemSearchTimesec_A9250 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_31F:
			this.CVBtnScanWideConventionalCarrierDetectRequired_A7611 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_32C:
			this.GrpBoxExpanderScanWideConventionalPseudo0 = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_339:
			this.LblScanWideConventionalRSSIVotingThreshold_A8997 = (global::AcpUI.AcpLabel)target;
			this.LblScanWideConventionalRSSIVotingThreshold_A8997.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_35D:
			this.ScanWideRadioWideVoiceRxTxHoldTimeSec_A9653Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_36A:
			this.LblScanWideRadioWideSuspendAllScan_A9232 = (global::AcpUI.AcpLabel)target;
			this.LblScanWideRadioWideSuspendAllScan_A9232.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_38E:
			this.GrpBoxExpanderScanWideLabtoolPseudo0 = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_39B:
			this.RTDBtnScanWideRadioWideVoiceRxTxHoldTimeSec_A9653 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_3A8:
			this.CVBtnScanWideRadioWideVoiceRxTxHoldTimeSec_A9653 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_3B5:
			this.ScanWideRadioWideSuspendAllScan_A9232Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_3C2:
			this.CVBtnScanWideConventionalMonitorHoldTimesec_A8543 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_3CF:
			num = (short)2043961103;
			short num3 = num;
			num = (short)414015247;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_947:
				this.LblScanWideTrunkingSystemSearchTimesec_A9250 = (global::AcpUI.AcpLabel)target;
				this.LblScanWideTrunkingSystemSearchTimesec_A9250.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
				return;
			default:
			{
				num = (short)1470234624;
				short num4 = num;
				num = (short)1838350336;
				if (num != 0)
				{
				}
				this.HLinkGeneral = (global::System.Windows.Documents.Hyperlink)target;
				this.HLinkGeneral.Click += this.HLinkClick;
				return;
			}
			}
			IL_465:
			this.RTDBtnScanWideConventionalPriorityChannelMarking_A8750 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_472:
			this.ScanWideRadioWideDataRxTxHoldTimesec_A7797 = (global::AcpUI.AcpTextBoxSpinner)target;
			this.ScanWideRadioWideDataRxTxHoldTimesec_A7797.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_496:
			this.ScanWideTrunkingFailsoftHoldTimesec_A8009Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_4A3:
			this.ScanWideRadioWideDataRxTxHoldTimesec_A7797Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_4B0:
			this.RTDBtnScanWideLabtoolScanDetectTimeForPL_A9049 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_4BD:
			this.ScanWideRadioWidePriorityScanAlert_A8752Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_4CA:
			this.ThemeBaseObj = (global::AcpUI.Common.AcpThemeBase)target;
			return;
			IL_4D7:
			this.RTDBtnScanWideLabtoolScanDetectTimeForCarrierSquelch_A9048 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_4E4:
			this.LblScanWideRadioWideVoiceRxTxHoldTimeSec_A9653 = (global::AcpUI.AcpLabel)target;
			this.LblScanWideRadioWideVoiceRxTxHoldTimeSec_A9653.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_508:
			this.CpyBtnScanWideRadioWidePriorityScanAlert_A8752 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_515:
			this.ScanWideTrunkingSystemSearchTimesec_A9250 = (global::AcpUI.AcpTextBoxSpinner)target;
			this.ScanWideTrunkingSystemSearchTimesec_A9250.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_539:
			this.MyStackPanel = (global::System.Windows.Controls.StackPanel)target;
			return;
			IL_546:
			this.ScanWideRadioWideHUBSuspendsScan_A8216 = (global::AcpUI.AcpCheckBox)target;
			this.ScanWideRadioWideHUBSuspendsScan_A8216.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_56A:
			this.CVBtnScanWideConventionalRSSIVotingThreshold_A8997 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_577:
			this.ScanWideRadioWideVoiceRxTxHoldTimeSec_A9653 = (global::AcpUI.AcpTextBoxSpinner)target;
			this.ScanWideRadioWideVoiceRxTxHoldTimeSec_A9653.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_59B:
			this.CVBtnScanWideLabtoolScanDetectTimeForPL_A9049 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_5A8:
			this.CpyBtnScanWideTrunkingFailsoftHoldTimesec_A8009 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_5B5:
			this.LblScanWideLabtoolScanDetectTimeForPL_A9049 = (global::AcpUI.AcpLabel)target;
			this.LblScanWideLabtoolScanDetectTimeForPL_A9049.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_5D9:
			this.ScanWideLabtoolScanDetectTimeForPL_A9049Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_5E6:
			this.RTDBtnScanWideRadioWideHUBSuspendsScan_A8216 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_5F3:
			this.CpyBtnScanWideConventionalTimeBetweenPrioritySamplesms_A9376 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_600:
			this.ExpanderScanWideConventional = (global::AcpUI.AcpExpander)target;
			return;
			IL_60D:
			this.CpyBtnScanWideConventionalMonitorHoldTimesec_A8543 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_61A:
			this.ScanWideRadioWidePriorityScanAlert_A8752 = (global::AcpUI.AcpCheckBox)target;
			this.ScanWideRadioWidePriorityScanAlert_A8752.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_63E:
			this.CVBtnScanWideTrunkingSystemSearchTimesec_A9250 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_64B:
			this.LblScanWideConventionalTimeBetweenPrioritySamplesms_A9376 = (global::AcpUI.AcpLabel)target;
			this.LblScanWideConventionalTimeBetweenPrioritySamplesms_A9376.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_66F:
			this.ScanWideConventionalCarrierDetectRequired_A7611Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_67C:
			this.ScanWideConventionalCarrierDetectRequired_A7611 = (global::AcpUI.AcpCheckBox)target;
			this.ScanWideConventionalCarrierDetectRequired_A7611.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_6A0:
			this.LblScanWideConventionalPriorityChannelMarking_A8750 = (global::AcpUI.AcpLabel)target;
			this.LblScanWideConventionalPriorityChannelMarking_A8750.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_6C4:
			this.ScanWideConventionalMonitorHoldTimesec_A8543Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_6D1:
			this.ScanWideLabtoolScanDetectTimeForCarrierSquelch_A9048Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_6DE:
			this.CpyBtnScanWideConventionalPriorityChannelMarking_A8750 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_6EB:
			this.CVBtnScanWideConventionalPriorityChannelMarking_A8750 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_6F8:
			this.ScanWideConventionalRSSIVotingThreshold_A8997 = (global::AcpUI.AcpTextBoxSpinnerDecHex)target;
			this.ScanWideConventionalRSSIVotingThreshold_A8997.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_71C:
			this.CpyBtnScanWideTrunkingSystemSearchTimesec_A9250 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_729:
			this.RTDBtnScanWideConventionalTimeBetweenPrioritySamplesms_A9376 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_736:
			this.ScanWideRadioWideHUBSuspendsScan_A8216Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_743:
			this.ExpanderScanWideGeneral = (global::AcpUI.AcpExpander)target;
			return;
			IL_750:
			this.CVBtnScanWideRadioWidePriorityScanAlert_A8752 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_75D:
			this.HLinkConventional = (global::System.Windows.Documents.Hyperlink)target;
			this.HLinkConventional.Click += this.HLinkClick;
			return;
			IL_781:
			this.LblScanWideRadioWideHUBSuspendsScan_A8216 = (global::AcpUI.AcpLabel)target;
			this.LblScanWideRadioWideHUBSuspendsScan_A8216.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_7A5:
			this.LblScanWideConventionalCarrierDetectRequired_A7611 = (global::AcpUI.AcpLabel)target;
			this.LblScanWideConventionalCarrierDetectRequired_A7611.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_7C9:
			this.ScanWideTrunkingFailsoftHoldTimesec_A8009 = (global::AcpUI.AcpTextBoxSpinner)target;
			this.ScanWideTrunkingFailsoftHoldTimesec_A8009.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_7ED:
			this.LblScanWideTrunkingFailsoftHoldTimesec_A8009 = (global::AcpUI.AcpLabel)target;
			this.LblScanWideTrunkingFailsoftHoldTimesec_A8009.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_811:
			this.ScanWideConventionalRSSIVotingThreshold_A8997Comp = (global::AcpUI.AcpTextBoxDecHex)target;
			return;
			IL_81E:
			this.CpyBtnScanWideRadioWideDataRxTxHoldTimesec_A7797 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_82B:
			this.RTDBtnScanWideConventionalMonitorHoldTimesec_A8543 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_838:
			this.ScanWideTrunkingSystemSearchTimesec_A9250Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_845:
			((global::Motorola.MackinawCPS.CoreFeatures.ScanWide.PageScanWide)target).Loaded += this.OnLoaded;
			((global::Motorola.MackinawCPS.CoreFeatures.ScanWide.PageScanWide)target).Unloaded += this.OnUnloaded;
			return;
			IL_876:
			this.HLinkTrunking = (global::System.Windows.Documents.Hyperlink)target;
			this.HLinkTrunking.Click += this.HLinkClick;
			return;
			IL_89A:
			this.RTDBtnScanWideConventionalRSSIVotingThreshold_A8997 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_8A7:
			this.ScanWideConventionalPriorityChannelMarking_A8750Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_8B4:
			this.ScanWideConventionalPriorityChannelMarking_A8750 = (global::AcpUI.AcpCheckBox)target;
			this.ScanWideConventionalPriorityChannelMarking_A8750.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_8D8:
			this.RTDBtnScanWideRadioWideDataRxTxHoldTimesec_A7797 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_8E5:
			this.ScanWideConventionalMonitorHoldTimesec_A8543 = (global::AcpUI.AcpTextBoxSpinner)target;
			this.ScanWideConventionalMonitorHoldTimesec_A8543.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_909:
			this.ScanWideRadioWideSuspendAllScan_A9232 = (global::AcpUI.AcpCheckBox)target;
			this.ScanWideRadioWideSuspendAllScan_A9232.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_92D:
			this.CVBtnScanWideLabtoolLookbackTime_A8454 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_93A:
			this.RTDBtnScanWideTrunkingFailsoftHoldTimesec_A8009 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_96B:
			this.LblScanWideRadioWideDataRxTxHoldTimesec_A7797 = (global::AcpUI.AcpLabel)target;
			this.LblScanWideRadioWideDataRxTxHoldTimesec_A7797.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_98F:
			this.LblScanWideLabtoolLookbackTime_A8454 = (global::AcpUI.AcpLabel)target;
			this.LblScanWideLabtoolLookbackTime_A8454.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_9B3:
			this.ScanWideLabtoolScanDetectTimeForPL_A9049 = (global::AcpUI.AcpTextBoxSpinner)target;
			this.ScanWideLabtoolScanDetectTimeForPL_A9049.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_9D7:
			this.ScanWideConventionalTimeBetweenPrioritySamplesms_A9376Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_9E4:
			this.LblScanWideLabtoolScanDetectTimeForCarrierSquelch_A9048 = (global::AcpUI.AcpLabel)target;
			this.LblScanWideLabtoolScanDetectTimeForCarrierSquelch_A9048.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_A08:
			this.CpyBtnScanWideRadioWideVoiceRxTxHoldTimeSec_A9653 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_A15:
			this.RTDBtnScanWideConventionalCarrierDetectRequired_A7611 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_A22:
			this.CpyBtnScanWideLabtoolScanDetectTimeForCarrierSquelch_A9048 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_A2F:
			this.CpyBtnScanWideConventionalRSSIVotingThreshold_A8997 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_A3C:
			this.CpyBtnScanWideLabtoolLookbackTime_A8454 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_A49:
			num = (short)1917321217;
			if (num != 0)
			{
			}
			this.GrpBoxExpanderScanWideTrunkingPseudo0 = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_A7C:
			this.LblScanWideConventionalMonitorHoldTimesec_A8543 = (global::AcpUI.AcpLabel)target;
			this.LblScanWideConventionalMonitorHoldTimesec_A8543.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_AA0:
			this.CVBtnScanWideRadioWideDataRxTxHoldTimesec_A7797 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_AAD:
			this.ScanWideLabtoolLookbackTime_A8454 = (global::AcpUI.AcpTextBoxSpinner)target;
			this.ScanWideLabtoolLookbackTime_A8454.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_AD1:
			this.ScanWideLabtoolLookbackTime_A8454Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_ADE:
			this.HLinkLabtool = (global::System.Windows.Documents.Hyperlink)target;
			this.HLinkLabtool.Click += this.HLinkClick;
			return;
			IL_B02:
			this.GrpBoxExpanderScanWideGeneralPseudo0 = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_B0F:
			this.LblScanWideRadioWidePriorityScanAlert_A8752 = (global::AcpUI.AcpLabel)target;
			this.LblScanWideRadioWidePriorityScanAlert_A8752.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
		}

		// Token: 0x04000E65 RID: 3685
		private bool a;

		// Token: 0x04000E66 RID: 3686
		internal global::AcpUI.Common.AcpThemeBase ThemeBaseObj;

		// Token: 0x04000E67 RID: 3687
		internal global::System.Windows.Documents.Hyperlink HLinkGeneral;

		// Token: 0x04000E68 RID: 3688
		internal global::System.Windows.Documents.Hyperlink HLinkConventional;

		// Token: 0x04000E69 RID: 3689
		internal global::System.Windows.Documents.Hyperlink HLinkTrunking;

		// Token: 0x04000E6A RID: 3690
		internal global::System.Windows.Documents.Hyperlink HLinkLabtool;

		// Token: 0x04000E6B RID: 3691
		internal global::System.Windows.Controls.StackPanel MyStackPanel;

		// Token: 0x04000E6C RID: 3692
		internal global::AcpUI.AcpExpander ExpanderScanWideGeneral;

		// Token: 0x04000E6D RID: 3693
		internal global::AcpUI.AcpGroupBox GrpBoxExpanderScanWideGeneralPseudo0;

		// Token: 0x04000E6E RID: 3694
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnScanWideRadioWidePriorityScanAlert_A8752;

		// Token: 0x04000E6F RID: 3695
		internal global::AcpUI.AcpLabel LblScanWideRadioWidePriorityScanAlert_A8752;

		// Token: 0x04000E70 RID: 3696
		internal global::AcpUI.AcpCheckBox ScanWideRadioWidePriorityScanAlert_A8752;

		// Token: 0x04000E71 RID: 3697
		internal global::AcpUI.AcpRtdButton RTDBtnScanWideRadioWidePriorityScanAlert_A8752;

		// Token: 0x04000E72 RID: 3698
		internal global::AcpUI.AcpCopyButton CpyBtnScanWideRadioWidePriorityScanAlert_A8752;

		// Token: 0x04000E73 RID: 3699
		internal global::AcpUI.AcpCheckBox ScanWideRadioWidePriorityScanAlert_A8752Comp;

		// Token: 0x04000E74 RID: 3700
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnScanWideRadioWideHUBSuspendsScan_A8216;

		// Token: 0x04000E75 RID: 3701
		internal global::AcpUI.AcpLabel LblScanWideRadioWideHUBSuspendsScan_A8216;

		// Token: 0x04000E76 RID: 3702
		internal global::AcpUI.AcpCheckBox ScanWideRadioWideHUBSuspendsScan_A8216;

		// Token: 0x04000E77 RID: 3703
		internal global::AcpUI.AcpRtdButton RTDBtnScanWideRadioWideHUBSuspendsScan_A8216;

		// Token: 0x04000E78 RID: 3704
		internal global::AcpUI.AcpCopyButton CpyBtnScanWideRadioWideHUBSuspendsScan_A8216;

		// Token: 0x04000E79 RID: 3705
		internal global::AcpUI.AcpCheckBox ScanWideRadioWideHUBSuspendsScan_A8216Comp;

		// Token: 0x04000E7A RID: 3706
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnScanWideRadioWideSuspendAllScan_A9232;

		// Token: 0x04000E7B RID: 3707
		internal global::AcpUI.AcpLabel LblScanWideRadioWideSuspendAllScan_A9232;

		// Token: 0x04000E7C RID: 3708
		internal global::AcpUI.AcpCheckBox ScanWideRadioWideSuspendAllScan_A9232;

		// Token: 0x04000E7D RID: 3709
		internal global::AcpUI.AcpRtdButton RTDBtnScanWideRadioWideSuspendAllScan_A9232;

		// Token: 0x04000E7E RID: 3710
		internal global::AcpUI.AcpCopyButton CpyBtnScanWideRadioWideSuspendAllScan_A9232;

		// Token: 0x04000E7F RID: 3711
		internal global::AcpUI.AcpCheckBox ScanWideRadioWideSuspendAllScan_A9232Comp;

		// Token: 0x04000E80 RID: 3712
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnScanWideRadioWideVoiceRxTxHoldTimeSec_A9653;

		// Token: 0x04000E81 RID: 3713
		internal global::AcpUI.AcpLabel LblScanWideRadioWideVoiceRxTxHoldTimeSec_A9653;

		// Token: 0x04000E82 RID: 3714
		internal global::AcpUI.AcpTextBoxSpinner ScanWideRadioWideVoiceRxTxHoldTimeSec_A9653;

		// Token: 0x04000E83 RID: 3715
		internal global::AcpUI.AcpRtdButton RTDBtnScanWideRadioWideVoiceRxTxHoldTimeSec_A9653;

		// Token: 0x04000E84 RID: 3716
		internal global::AcpUI.AcpCopyButton CpyBtnScanWideRadioWideVoiceRxTxHoldTimeSec_A9653;

		// Token: 0x04000E85 RID: 3717
		internal global::AcpUI.AcpLabel ScanWideRadioWideVoiceRxTxHoldTimeSec_A9653Comp;

		// Token: 0x04000E86 RID: 3718
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnScanWideRadioWideDataRxTxHoldTimesec_A7797;

		// Token: 0x04000E87 RID: 3719
		internal global::AcpUI.AcpLabel LblScanWideRadioWideDataRxTxHoldTimesec_A7797;

		// Token: 0x04000E88 RID: 3720
		internal global::AcpUI.AcpTextBoxSpinner ScanWideRadioWideDataRxTxHoldTimesec_A7797;

		// Token: 0x04000E89 RID: 3721
		internal global::AcpUI.AcpRtdButton RTDBtnScanWideRadioWideDataRxTxHoldTimesec_A7797;

		// Token: 0x04000E8A RID: 3722
		internal global::AcpUI.AcpCopyButton CpyBtnScanWideRadioWideDataRxTxHoldTimesec_A7797;

		// Token: 0x04000E8B RID: 3723
		internal global::AcpUI.AcpLabel ScanWideRadioWideDataRxTxHoldTimesec_A7797Comp;

		// Token: 0x04000E8C RID: 3724
		internal global::AcpUI.AcpExpander ExpanderScanWideConventional;

		// Token: 0x04000E8D RID: 3725
		internal global::AcpUI.AcpGroupBox GrpBoxExpanderScanWideConventionalPseudo0;

		// Token: 0x04000E8E RID: 3726
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnScanWideConventionalCarrierDetectRequired_A7611;

		// Token: 0x04000E8F RID: 3727
		internal global::AcpUI.AcpLabel LblScanWideConventionalCarrierDetectRequired_A7611;

		// Token: 0x04000E90 RID: 3728
		internal global::AcpUI.AcpCheckBox ScanWideConventionalCarrierDetectRequired_A7611;

		// Token: 0x04000E91 RID: 3729
		internal global::AcpUI.AcpRtdButton RTDBtnScanWideConventionalCarrierDetectRequired_A7611;

		// Token: 0x04000E92 RID: 3730
		internal global::AcpUI.AcpCopyButton CpyBtnScanWideConventionalCarrierDetectRequired_A7611;

		// Token: 0x04000E93 RID: 3731
		internal global::AcpUI.AcpCheckBox ScanWideConventionalCarrierDetectRequired_A7611Comp;

		// Token: 0x04000E94 RID: 3732
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnScanWideConventionalPriorityChannelMarking_A8750;

		// Token: 0x04000E95 RID: 3733
		internal global::AcpUI.AcpLabel LblScanWideConventionalPriorityChannelMarking_A8750;

		// Token: 0x04000E96 RID: 3734
		internal global::AcpUI.AcpCheckBox ScanWideConventionalPriorityChannelMarking_A8750;

		// Token: 0x04000E97 RID: 3735
		internal global::AcpUI.AcpRtdButton RTDBtnScanWideConventionalPriorityChannelMarking_A8750;

		// Token: 0x04000E98 RID: 3736
		internal global::AcpUI.AcpCopyButton CpyBtnScanWideConventionalPriorityChannelMarking_A8750;

		// Token: 0x04000E99 RID: 3737
		internal global::AcpUI.AcpCheckBox ScanWideConventionalPriorityChannelMarking_A8750Comp;

		// Token: 0x04000E9A RID: 3738
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnScanWideConventionalMonitorHoldTimesec_A8543;

		// Token: 0x04000E9B RID: 3739
		internal global::AcpUI.AcpLabel LblScanWideConventionalMonitorHoldTimesec_A8543;

		// Token: 0x04000E9C RID: 3740
		internal global::AcpUI.AcpTextBoxSpinner ScanWideConventionalMonitorHoldTimesec_A8543;

		// Token: 0x04000E9D RID: 3741
		internal global::AcpUI.AcpRtdButton RTDBtnScanWideConventionalMonitorHoldTimesec_A8543;

		// Token: 0x04000E9E RID: 3742
		internal global::AcpUI.AcpCopyButton CpyBtnScanWideConventionalMonitorHoldTimesec_A8543;

		// Token: 0x04000E9F RID: 3743
		internal global::AcpUI.AcpLabel ScanWideConventionalMonitorHoldTimesec_A8543Comp;

		// Token: 0x04000EA0 RID: 3744
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnScanWideConventionalTimeBetweenPrioritySamplesms_A9376;

		// Token: 0x04000EA1 RID: 3745
		internal global::AcpUI.AcpLabel LblScanWideConventionalTimeBetweenPrioritySamplesms_A9376;

		// Token: 0x04000EA2 RID: 3746
		internal global::AcpUI.AcpTextBoxSpinner ScanWideConventionalTimeBetweenPrioritySamplesms_A9376;

		// Token: 0x04000EA3 RID: 3747
		internal global::AcpUI.AcpRtdButton RTDBtnScanWideConventionalTimeBetweenPrioritySamplesms_A9376;

		// Token: 0x04000EA4 RID: 3748
		internal global::AcpUI.AcpCopyButton CpyBtnScanWideConventionalTimeBetweenPrioritySamplesms_A9376;

		// Token: 0x04000EA5 RID: 3749
		internal global::AcpUI.AcpLabel ScanWideConventionalTimeBetweenPrioritySamplesms_A9376Comp;

		// Token: 0x04000EA6 RID: 3750
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnScanWideConventionalRSSIVotingThreshold_A8997;

		// Token: 0x04000EA7 RID: 3751
		internal global::AcpUI.AcpLabel LblScanWideConventionalRSSIVotingThreshold_A8997;

		// Token: 0x04000EA8 RID: 3752
		internal global::AcpUI.AcpTextBoxSpinnerDecHex ScanWideConventionalRSSIVotingThreshold_A8997;

		// Token: 0x04000EA9 RID: 3753
		internal global::AcpUI.AcpRtdButton RTDBtnScanWideConventionalRSSIVotingThreshold_A8997;

		// Token: 0x04000EAA RID: 3754
		internal global::AcpUI.AcpCopyButton CpyBtnScanWideConventionalRSSIVotingThreshold_A8997;

		// Token: 0x04000EAB RID: 3755
		internal global::AcpUI.AcpTextBoxDecHex ScanWideConventionalRSSIVotingThreshold_A8997Comp;

		// Token: 0x04000EAC RID: 3756
		internal global::AcpUI.AcpExpander ExpanderScanWideTrunking;

		// Token: 0x04000EAD RID: 3757
		internal global::AcpUI.AcpGroupBox GrpBoxExpanderScanWideTrunkingPseudo0;

		// Token: 0x04000EAE RID: 3758
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnScanWideTrunkingFailsoftHoldTimesec_A8009;

		// Token: 0x04000EAF RID: 3759
		internal global::AcpUI.AcpLabel LblScanWideTrunkingFailsoftHoldTimesec_A8009;

		// Token: 0x04000EB0 RID: 3760
		internal global::AcpUI.AcpTextBoxSpinner ScanWideTrunkingFailsoftHoldTimesec_A8009;

		// Token: 0x04000EB1 RID: 3761
		internal global::AcpUI.AcpRtdButton RTDBtnScanWideTrunkingFailsoftHoldTimesec_A8009;

		// Token: 0x04000EB2 RID: 3762
		internal global::AcpUI.AcpCopyButton CpyBtnScanWideTrunkingFailsoftHoldTimesec_A8009;

		// Token: 0x04000EB3 RID: 3763
		internal global::AcpUI.AcpLabel ScanWideTrunkingFailsoftHoldTimesec_A8009Comp;

		// Token: 0x04000EB4 RID: 3764
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnScanWideTrunkingSystemSearchTimesec_A9250;

		// Token: 0x04000EB5 RID: 3765
		internal global::AcpUI.AcpLabel LblScanWideTrunkingSystemSearchTimesec_A9250;

		// Token: 0x04000EB6 RID: 3766
		internal global::AcpUI.AcpTextBoxSpinner ScanWideTrunkingSystemSearchTimesec_A9250;

		// Token: 0x04000EB7 RID: 3767
		internal global::AcpUI.AcpRtdButton RTDBtnScanWideTrunkingSystemSearchTimesec_A9250;

		// Token: 0x04000EB8 RID: 3768
		internal global::AcpUI.AcpCopyButton CpyBtnScanWideTrunkingSystemSearchTimesec_A9250;

		// Token: 0x04000EB9 RID: 3769
		internal global::AcpUI.AcpLabel ScanWideTrunkingSystemSearchTimesec_A9250Comp;

		// Token: 0x04000EBA RID: 3770
		internal global::AcpUI.AcpExpander ExpanderScanWideLabtool;

		// Token: 0x04000EBB RID: 3771
		internal global::AcpUI.AcpGroupBox GrpBoxExpanderScanWideLabtoolPseudo0;

		// Token: 0x04000EBC RID: 3772
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnScanWideLabtoolScanDetectTimeForPL_A9049;

		// Token: 0x04000EBD RID: 3773
		internal global::AcpUI.AcpLabel LblScanWideLabtoolScanDetectTimeForPL_A9049;

		// Token: 0x04000EBE RID: 3774
		internal global::AcpUI.AcpTextBoxSpinner ScanWideLabtoolScanDetectTimeForPL_A9049;

		// Token: 0x04000EBF RID: 3775
		internal global::AcpUI.AcpRtdButton RTDBtnScanWideLabtoolScanDetectTimeForPL_A9049;

		// Token: 0x04000EC0 RID: 3776
		internal global::AcpUI.AcpCopyButton CpyBtnScanWideLabtoolScanDetectTimeForPL_A9049;

		// Token: 0x04000EC1 RID: 3777
		internal global::AcpUI.AcpLabel ScanWideLabtoolScanDetectTimeForPL_A9049Comp;

		// Token: 0x04000EC2 RID: 3778
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnScanWideLabtoolScanDetectTimeForCarrierSquelch_A9048;

		// Token: 0x04000EC3 RID: 3779
		internal global::AcpUI.AcpLabel LblScanWideLabtoolScanDetectTimeForCarrierSquelch_A9048;

		// Token: 0x04000EC4 RID: 3780
		internal global::AcpUI.AcpTextBoxSpinner ScanWideLabtoolScanDetectTimeForCarrierSquelch_A9048;

		// Token: 0x04000EC5 RID: 3781
		internal global::AcpUI.AcpRtdButton RTDBtnScanWideLabtoolScanDetectTimeForCarrierSquelch_A9048;

		// Token: 0x04000EC6 RID: 3782
		internal global::AcpUI.AcpCopyButton CpyBtnScanWideLabtoolScanDetectTimeForCarrierSquelch_A9048;

		// Token: 0x04000EC7 RID: 3783
		internal global::AcpUI.AcpLabel ScanWideLabtoolScanDetectTimeForCarrierSquelch_A9048Comp;

		// Token: 0x04000EC8 RID: 3784
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnScanWideLabtoolLookbackTime_A8454;

		// Token: 0x04000EC9 RID: 3785
		internal global::AcpUI.AcpLabel LblScanWideLabtoolLookbackTime_A8454;

		// Token: 0x04000ECA RID: 3786
		internal global::AcpUI.AcpTextBoxSpinner ScanWideLabtoolLookbackTime_A8454;

		// Token: 0x04000ECB RID: 3787
		internal global::AcpUI.AcpRtdButton RTDBtnScanWideLabtoolLookbackTime_A8454;

		// Token: 0x04000ECC RID: 3788
		internal global::AcpUI.AcpCopyButton CpyBtnScanWideLabtoolLookbackTime_A8454;

		// Token: 0x04000ECD RID: 3789
		internal global::AcpUI.AcpLabel ScanWideLabtoolLookbackTime_A8454Comp;

		// Token: 0x04000ECE RID: 3790
		private bool b;
	}
}
