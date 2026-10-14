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

namespace Motorola.MackinawCPS.CoreFeatures.DVRSWide
{
	// Token: 0x020004AD RID: 1197
	public class PageDVRSWide : global::AcpUI.AcpPageFeature, global::System.Windows.Markup.IComponentConnector
	{
		// Token: 0x06009DA7 RID: 40359 RVA: 0x00934350 File Offset: 0x00932550
		public PageDVRSWide()
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

		// Token: 0x06009DA8 RID: 40360 RVA: 0x00934388 File Offset: 0x00932588
		public override void OnLoaded(object sender, global::System.Windows.RoutedEventArgs e)
		{
			for (;;)
			{
				IL_00:
				short num = (short)169607169;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					num = (short)851574785;
					if (num != 0)
					{
					}
					global::AcpUI.AcpExpander acpExpander;
					global::System.Collections.IEnumerator enumerator;
					switch (num2)
					{
					case 0:
						goto IL_2B8;
					case 1:
						switch (0)
						{
						case 0:
							goto IL_5C;
						}
						continue;
					case 2:
					{
						num = (short)543621120;
						short num3 = num;
						try
						{
							num = (short)78905348;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 1:
									if (acpExpander != null)
									{
										num = (short)1914109958;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								case 2:
									if (!enumerator.MoveNext())
									{
										num = (short)897384453;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									acpExpander = (((global::System.Windows.UIElement)enumerator.Current) as global::AcpUI.AcpExpander);
									num = (short)304545793;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 3:
									goto IL_176;
								case 4:
									switch (0)
									{
									case 0:
										goto IL_C1;
									}
									continue;
								case 5:
									num = (short)183238659;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 6:
									base.Expanders.Add(acpExpander);
									num = (short)1604124672;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_102:
								num = (short)977272834;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_C1:
								goto IL_102;
							}
							IL_176:
							goto IL_246;
						}
						finally
						{
							switch (0)
							{
							case 0:
								goto IL_197;
							}
							global::System.IDisposable disposable;
							for (;;)
							{
								IL_185:
								switch (num2)
								{
								case 0:
									if (disposable != null)
									{
										num = (short)2003697666;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_1EA;
								case 1:
									goto IL_1E8;
								case 2:
									disposable.Dispose();
									num = (short)272957441;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_197;
							}
							IL_1E8:
							IL_1EA:
							goto EndFinally_6;
							IL_197:
							disposable = (enumerator as global::System.IDisposable);
							num = (short)1259208704;
							num2 = (int)((global::System.IntPtr)num);
							goto IL_185;
							EndFinally_6:;
						}
						goto IL_1EB;
						IL_246:
						num = (short)1293676412;
						short num4 = num;
						num = (short)2104487804;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_00;
						default:
							num = (short)1221918720;
							if (num != 0)
							{
							}
							base.OnLoaded(sender, e);
							this.a = true;
							num = (short)1685520384;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 3:
						goto IL_1EB;
					}
					IL_5C:
					if (!this.a)
					{
						num = (short)1232666627;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_2BA;
					IL_1EB:
					acpExpander = null;
					enumerator = this.MyStackPanel.Children.GetEnumerator();
					num = (short)1262616578;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
			IL_2B8:
			IL_2BA:
			this.MyStackPanel.Children[0].Focus();
		}

		// Token: 0x06009DA9 RID: 40361 RVA: 0x00934678 File Offset: 0x00932878
		public override void OnUnloaded(object sender, global::System.Windows.RoutedEventArgs e)
		{
			short num = (short)1476447531;
			short num2 = num;
			num = (short)1657720107;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)741015552;
				if (num != 0)
				{
				}
				num = (short)168230912;
				int num3 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num3)
					{
					case 0:
						switch (0)
						{
						case 0:
							goto IL_7A;
						}
						continue;
					case 1:
						goto IL_110;
					case 2:
					{
						base.OnUnloaded(sender, e);
						this.a = false;
						num = (short)858456064;
						short num4 = num;
						num = (short)1939668993;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					IL_7A:
					if (!this.a)
					{
						break;
					}
					num = (short)1441267713;
					if (num != 0)
					{
					}
					num = (short)730202114;
					num3 = (int)((global::System.IntPtr)num);
				}
				IL_110:
				break;
			}
			}
		}

		// Token: 0x06009DAA RID: 40362 RVA: 0x00934798 File Offset: 0x00932998
		public override void SetDataContext()
		{
			short num = (short)604504068;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_B4;
				case 1:
					base.DataContext = global::AcpCommonLib.AppInfoManager.DefaultDocument.GetFeature(4142);
					num = (short)1067122688;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
				{
					num = (short)428539905;
					if (num != 0)
					{
					}
					num = (short)1833697280;
					short num3 = num;
					global::AcpCommonLib.AppInfoManager.ComparatorDocument.GetFeature(4142);
					num = (short)185466883;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 3:
					return;
				case 4:
					goto IL_15;
				case 5:
					goto IL_B4;
				case 6:
					if (global::AcpCommonLib.AppInfoManager.AppMode == global::AcpCommonLib.ApplicationMode.CodeplugComparisonMode)
					{
						num = (short)1211039746;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				}
				goto IL_41;
				IL_15:
				switch (0)
				{
				case 0:
					IL_41:
					if (global::AcpCommonLib.AppInfoManager.AppMode == global::AcpCommonLib.ApplicationMode.CustomViewConfigurationMode)
					{
						num = (short)2025684221;
						short num4 = num;
						num = (short)821853437;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_15;
						default:
							num = (short)1970995200;
							if (num != 0)
							{
							}
							num = (short)1949564929;
							num2 = (int)((global::System.IntPtr)num);
							break;
						}
					}
					else
					{
						base.DataContext = global::AcpCommonLib.FeatureManager.GetFeature(4142);
						num = (short)1327693829;
						num2 = (int)((global::System.IntPtr)num);
					}
					break;
				}
				continue;
				IL_B4:
				num = (short)11403270;
				num2 = (int)((global::System.IntPtr)num);
			}
		}

		// Token: 0x06009DAB RID: 40363 RVA: 0x00934970 File Offset: 0x00932B70
		private void HLinkClick(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num = (short)635502593;
			if (num != 0)
			{
			}
			num = (short)524533544;
			short num2 = num;
			num = (short)56475432;
			switch (num2 == num)
			{
			}
			num = (short)284426240;
			short num3 = num;
			num = (short)282656768;
			if (num != 0)
			{
			}
			base.OnHLinkClick(A_0);
		}

		// Token: 0x06009DAC RID: 40364 RVA: 0x00934A20 File Offset: 0x00932C20
		private void OnFieldNameDoubleClick(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num = (short)1773375541;
			short num2 = num;
			num = (short)1446219829;
			switch (num2 == num)
			{
			}
			num = (short)596967424;
			if (num != 0)
			{
			}
			num = (short)1444347904;
			short num3 = num;
			num = (short)323289089;
			if (num != 0)
			{
			}
			global::AcpUI.Common.Utility.GetFieldHelpText(A_0);
		}

		// Token: 0x06009DAD RID: 40365 RVA: 0x00934AD0 File Offset: 0x00932CD0
		[global::System.Diagnostics.DebuggerNonUserCode]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "5.0.10.0")]
		public void InitializeComponent()
		{
			int a_ = 6;
			short num;
			while (!this.b)
			{
				num = (short)707145691;
				short num2 = num;
				num = (short)45559771;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)867106816;
					if (num != 0)
					{
					}
					num = (short)573702145;
					if (num != 0)
					{
					}
					this.b = true;
					global::System.Uri resourceLocator = new global::System.Uri(global::AllFeatures.CodeplugGuid.b("裈ꟊꇌ觎듐닒ꇔꋖꯘ뻚껜苠賢裤韦蛨藪裬臮藰\udcf2釴臶诸裺\ud8fc췾㄀怂樄椆漈戊樌税挐爒愔縖瘘甚㈜笞圠儢嘤Ȧᬨᬪ娬䘮唰嘲ᨴ匶伸䤺丼䠾⡀❂⁄楆ㅈ⩊⁌⍎", a_), global::System.UriKind.Relative);
					global::System.Windows.Application.LoadComponent(this, resourceLocator);
					return;
				}
				}
			}
			num = (short)1767571456;
			short num3 = num;
		}

		// Token: 0x06009DAE RID: 40366 RVA: 0x00934BB0 File Offset: 0x00932DB0
		[global::System.Diagnostics.DebuggerNonUserCode]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "5.0.10.0")]
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		void global::System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
		{
			short num = (short)238288896;
			int num2 = (int)((global::System.IntPtr)num);
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
					goto IL_270;
				case 2:
					num = (short)1691680769;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_30:
				switch (connectionId)
				{
				case 1:
					goto IL_3E9;
				case 2:
					goto IL_4D7;
				case 3:
					goto IL_518;
				case 4:
					goto IL_4A0;
				case 5:
					goto IL_4FE;
				case 6:
					goto IL_1AB;
				case 7:
					goto IL_299;
				case 8:
					goto IL_33F;
				case 9:
					goto IL_275;
				case 10:
					goto IL_147;
				case 11:
					goto IL_20D;
				case 12:
					goto IL_3B8;
				case 13:
					goto IL_2A6;
				case 14:
					goto IL_394;
				case 15:
					goto IL_31B;
				case 16:
					goto IL_387;
				case 17:
					goto IL_4F1;
				case 18:
					goto IL_301;
				case 19:
					goto IL_2F4;
				case 20:
					goto IL_234;
				case 21:
					goto IL_427;
				case 22:
					goto IL_46F;
				case 23:
					goto IL_5AE;
				case 24:
					goto IL_53C;
				case 25:
					goto IL_41A;
				case 26:
					goto IL_3C5;
				case 27:
					goto IL_123;
				case 28:
					goto IL_200;
				case 29:
					goto IL_556;
				case 30:
					goto IL_30E;
				case 31:
					goto IL_5A1;
				case 32:
					goto IL_570;
				case 33:
					goto IL_1B8;
				case 34:
					goto IL_116;
				case 35:
					goto IL_549;
				case 36:
					goto IL_50B;
				case 37:
					goto IL_2E7;
				case 38:
					goto IL_44B;
				case 39:
					goto IL_363;
				case 40:
					goto IL_154;
				case 41:
					goto IL_594;
				case 42:
					goto IL_21A;
				case 43:
					goto IL_2DA;
				case 44:
					goto IL_1DC;
				case 45:
					goto IL_47C;
				case 46:
					goto IL_4E4;
				case 47:
					goto IL_227;
				case 48:
					goto IL_563;
				default:
					num = (short)1030881282;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
			}
			IL_116:
			this.RTDBtnRadWideLabtoolDVRSFatalError_A7910 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_123:
			this.DVRSWideLabtoolDVRSSyncFieldsHash_A41811 = (global::AcpUI.AcpTextBox)target;
			this.DVRSWideLabtoolDVRSSyncFieldsHash_A41811.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_147:
			this.RTDBtnRadErgoWideDigitalVehicularRepeaterSystemDVRSHardwareEnable_A7911 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_154:
			num = (short)1539261653;
			short num3 = num;
			num = (short)780027093;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_21A:
				this.DVRSWideLabtoolVrId_A43727Comp = (global::AcpUI.AcpTextBoxDecHex)target;
				return;
			default:
				num = (short)2133852160;
				if (num != 0)
				{
				}
				this.RTDBtnDVRSWideLabtoolVrId_A43727 = (global::AcpUI.AcpRtdButton)target;
				return;
			}
			IL_1AB:
			this.GrpBoxExpanderDVRSWideGeneralPseudo0 = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_1B8:
			this.RadWideLabtoolDVRSFatalError_A7910 = (global::AcpUI.AcpLabel)target;
			this.RadWideLabtoolDVRSFatalError_A7910.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_1DC:
			this.LblDVRSWideGeneralChannelOnlyDisplay_A41811 = (global::AcpUI.AcpLabel)target;
			this.LblDVRSWideGeneralChannelOnlyDisplay_A41811.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_200:
			this.RTDBtnDVRSWideLabtoolDVRSSyncFieldsHash_A41811 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_20D:
			this.CpyBtnRadErgoWideDigitalVehicularRepeaterSystemDVRSHardwareEnable_A7911 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_227:
			this.CpyBtnDVRSWideGeneralChannelOnlyDisplay_A41811 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_234:
			this.LblDVRSWideGeneralInCarMonitor_A41799 = (global::AcpUI.AcpLabel)target;
			this.LblDVRSWideGeneralInCarMonitor_A41799.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_270:
			this.b = true;
			return;
			IL_275:
			this.RadErgoWideDigitalVehicularRepeaterSystemDVRSHardwareEnable_A7911 = (global::AcpUI.AcpCheckBox)target;
			this.RadErgoWideDigitalVehicularRepeaterSystemDVRSHardwareEnable_A7911.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_299:
			this.CVBtnRadErgoWideDigitalVehicularRepeaterSystemDVRSHardwareEnable_A7911 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_2A6:
			num = (short)604045313;
			if (num != 0)
			{
			}
			this.CVBtnDVRSWideGeneralVIPCtrlofDVRS_A41798 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_2DA:
			this.CVBtnDVRSWideGeneralChannelOnlyDisplay_A41811 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_2E7:
			this.CVBtnDVRSWideLabtoolVrId_A43727 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_2F4:
			this.CVBtnDVRSWideGeneralInCarMonitor_A41799 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_301:
			this.DVRSWideGeneralVIPCtrlofDVRS_A41798Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_30E:
			this.DVRSWideLabtoolDVRSSyncFieldsHash_A41811Comp = (global::AcpUI.AcpTextBox)target;
			return;
			IL_31B:
			this.DVRSWideGeneralVIPCtrlofDVRS_A41798 = (global::AcpUI.AcpComboBox)target;
			this.DVRSWideGeneralVIPCtrlofDVRS_A41798.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_33F:
			this.LblRadErgoWideDigitalVehicularRepeaterSystemDVRSHardwareEnable_A7911 = (global::AcpUI.AcpLabel)target;
			this.LblRadErgoWideDigitalVehicularRepeaterSystemDVRSHardwareEnable_A7911.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_363:
			this.DVRSWideLabtoolVrId_A43727 = (global::AcpUI.AcpTextBoxSpinnerDecHex)target;
			this.DVRSWideLabtoolVrId_A43727.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_387:
			this.RTDBtnDVRSWideGeneralVIPCtrlofDVRS_A41798 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_394:
			this.LblDVRSWideGeneralVIPCtrlofDVRS_A41798 = (global::AcpUI.AcpLabel)target;
			this.LblDVRSWideGeneralVIPCtrlofDVRS_A41798.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_3B8:
			this.RadErgoWideDigitalVehicularRepeaterSystemDVRSHardwareEnable_A7911Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_3C5:
			this.LblDVRSWideLabtoolDVRSSyncFieldsHash_A41811 = (global::AcpUI.AcpLabel)target;
			this.LblDVRSWideLabtoolDVRSSyncFieldsHash_A41811.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_3E9:
			((global::Motorola.MackinawCPS.CoreFeatures.DVRSWide.PageDVRSWide)target).Loaded += this.OnLoaded;
			((global::Motorola.MackinawCPS.CoreFeatures.DVRSWide.PageDVRSWide)target).Unloaded += this.OnUnloaded;
			return;
			IL_41A:
			this.CVBtnDVRSWideLabtoolDVRSSyncFieldsHash_A41811 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_427:
			this.DVRSWideGeneralInCarMonitor_A41799 = (global::AcpUI.AcpComboBox)target;
			this.DVRSWideGeneralInCarMonitor_A41799.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_44B:
			this.LblDVRSWideLabtoolVrId_A43727 = (global::AcpUI.AcpLabel)target;
			this.LblDVRSWideLabtoolVrId_A43727.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_46F:
			this.RTDBtnDVRSWideGeneralInCarMonitor_A41799 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_47C:
			this.DVRSWideGeneralChannelOnlyDisplay_A41811 = (global::AcpUI.AcpCheckBox)target;
			this.DVRSWideGeneralChannelOnlyDisplay_A41811.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_4A0:
			num = (short)1863712768;
			short num4 = num;
			this.MyStackPanel = (global::System.Windows.Controls.StackPanel)target;
			return;
			IL_4D7:
			this.ThemeBaseObj = (global::AcpUI.Common.AcpThemeBase)target;
			return;
			IL_4E4:
			this.RTDBtnDVRSWideGeneralChannelOnlyDisplay_A41811 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_4F1:
			this.CpyBtnDVRSWideGeneralVIPCtrlofDVRS_A41798 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_4FE:
			this.ExpanderDVRSWideGeneral = (global::AcpUI.AcpExpander)target;
			return;
			IL_50B:
			this.RadWideLabtoolDVRSFatalError_A7910Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_518:
			this.HLinkGeneral = (global::System.Windows.Documents.Hyperlink)target;
			this.HLinkGeneral.Click += this.HLinkClick;
			return;
			IL_53C:
			this.DVRSWideGeneralInCarMonitor_A41799Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_549:
			this.CpyBtnRadWideLabtoolDVRSFatalError_A7910 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_556:
			this.CpyBtnDVRSWideLabtoolDVRSSyncFieldsHash_A41811 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_563:
			this.DVRSWideGeneralChannelOnlyDisplay_A41811Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_570:
			this.LblRadWideLabtoolDVRSFatalError_A7910 = (global::AcpUI.AcpLabel)target;
			this.LblRadWideLabtoolDVRSFatalError_A7910.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_594:
			this.CpyBtnDVRSWideLabtoolVrId_A43727 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_5A1:
			this.CVBtnRadWideLabtoolDVRSFatalError_A7910 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_5AE:
			this.CpyBtnDVRSWideGeneralInCarMonitor_A41799 = (global::AcpUI.AcpCopyButton)target;
		}

		// Token: 0x04004D1B RID: 19739
		private bool a;

		// Token: 0x04004D1C RID: 19740
		internal global::AcpUI.Common.AcpThemeBase ThemeBaseObj;

		// Token: 0x04004D1D RID: 19741
		internal global::System.Windows.Documents.Hyperlink HLinkGeneral;

		// Token: 0x04004D1E RID: 19742
		internal global::System.Windows.Controls.StackPanel MyStackPanel;

		// Token: 0x04004D1F RID: 19743
		internal global::AcpUI.AcpExpander ExpanderDVRSWideGeneral;

		// Token: 0x04004D20 RID: 19744
		internal global::AcpUI.AcpGroupBox GrpBoxExpanderDVRSWideGeneralPseudo0;

		// Token: 0x04004D21 RID: 19745
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadErgoWideDigitalVehicularRepeaterSystemDVRSHardwareEnable_A7911;

		// Token: 0x04004D22 RID: 19746
		internal global::AcpUI.AcpLabel LblRadErgoWideDigitalVehicularRepeaterSystemDVRSHardwareEnable_A7911;

		// Token: 0x04004D23 RID: 19747
		internal global::AcpUI.AcpCheckBox RadErgoWideDigitalVehicularRepeaterSystemDVRSHardwareEnable_A7911;

		// Token: 0x04004D24 RID: 19748
		internal global::AcpUI.AcpRtdButton RTDBtnRadErgoWideDigitalVehicularRepeaterSystemDVRSHardwareEnable_A7911;

		// Token: 0x04004D25 RID: 19749
		internal global::AcpUI.AcpCopyButton CpyBtnRadErgoWideDigitalVehicularRepeaterSystemDVRSHardwareEnable_A7911;

		// Token: 0x04004D26 RID: 19750
		internal global::AcpUI.AcpCheckBox RadErgoWideDigitalVehicularRepeaterSystemDVRSHardwareEnable_A7911Comp;

		// Token: 0x04004D27 RID: 19751
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnDVRSWideGeneralVIPCtrlofDVRS_A41798;

		// Token: 0x04004D28 RID: 19752
		internal global::AcpUI.AcpLabel LblDVRSWideGeneralVIPCtrlofDVRS_A41798;

		// Token: 0x04004D29 RID: 19753
		internal global::AcpUI.AcpComboBox DVRSWideGeneralVIPCtrlofDVRS_A41798;

		// Token: 0x04004D2A RID: 19754
		internal global::AcpUI.AcpRtdButton RTDBtnDVRSWideGeneralVIPCtrlofDVRS_A41798;

		// Token: 0x04004D2B RID: 19755
		internal global::AcpUI.AcpCopyButton CpyBtnDVRSWideGeneralVIPCtrlofDVRS_A41798;

		// Token: 0x04004D2C RID: 19756
		internal global::AcpUI.AcpLabel DVRSWideGeneralVIPCtrlofDVRS_A41798Comp;

		// Token: 0x04004D2D RID: 19757
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnDVRSWideGeneralInCarMonitor_A41799;

		// Token: 0x04004D2E RID: 19758
		internal global::AcpUI.AcpLabel LblDVRSWideGeneralInCarMonitor_A41799;

		// Token: 0x04004D2F RID: 19759
		internal global::AcpUI.AcpComboBox DVRSWideGeneralInCarMonitor_A41799;

		// Token: 0x04004D30 RID: 19760
		internal global::AcpUI.AcpRtdButton RTDBtnDVRSWideGeneralInCarMonitor_A41799;

		// Token: 0x04004D31 RID: 19761
		internal global::AcpUI.AcpCopyButton CpyBtnDVRSWideGeneralInCarMonitor_A41799;

		// Token: 0x04004D32 RID: 19762
		internal global::AcpUI.AcpLabel DVRSWideGeneralInCarMonitor_A41799Comp;

		// Token: 0x04004D33 RID: 19763
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnDVRSWideLabtoolDVRSSyncFieldsHash_A41811;

		// Token: 0x04004D34 RID: 19764
		internal global::AcpUI.AcpLabel LblDVRSWideLabtoolDVRSSyncFieldsHash_A41811;

		// Token: 0x04004D35 RID: 19765
		internal global::AcpUI.AcpTextBox DVRSWideLabtoolDVRSSyncFieldsHash_A41811;

		// Token: 0x04004D36 RID: 19766
		internal global::AcpUI.AcpRtdButton RTDBtnDVRSWideLabtoolDVRSSyncFieldsHash_A41811;

		// Token: 0x04004D37 RID: 19767
		internal global::AcpUI.AcpCopyButton CpyBtnDVRSWideLabtoolDVRSSyncFieldsHash_A41811;

		// Token: 0x04004D38 RID: 19768
		internal global::AcpUI.AcpTextBox DVRSWideLabtoolDVRSSyncFieldsHash_A41811Comp;

		// Token: 0x04004D39 RID: 19769
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadWideLabtoolDVRSFatalError_A7910;

		// Token: 0x04004D3A RID: 19770
		internal global::AcpUI.AcpLabel LblRadWideLabtoolDVRSFatalError_A7910;

		// Token: 0x04004D3B RID: 19771
		internal global::AcpUI.AcpLabel RadWideLabtoolDVRSFatalError_A7910;

		// Token: 0x04004D3C RID: 19772
		internal global::AcpUI.AcpRtdButton RTDBtnRadWideLabtoolDVRSFatalError_A7910;

		// Token: 0x04004D3D RID: 19773
		internal global::AcpUI.AcpCopyButton CpyBtnRadWideLabtoolDVRSFatalError_A7910;

		// Token: 0x04004D3E RID: 19774
		internal global::AcpUI.AcpLabel RadWideLabtoolDVRSFatalError_A7910Comp;

		// Token: 0x04004D3F RID: 19775
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnDVRSWideLabtoolVrId_A43727;

		// Token: 0x04004D40 RID: 19776
		internal global::AcpUI.AcpLabel LblDVRSWideLabtoolVrId_A43727;

		// Token: 0x04004D41 RID: 19777
		internal global::AcpUI.AcpTextBoxSpinnerDecHex DVRSWideLabtoolVrId_A43727;

		// Token: 0x04004D42 RID: 19778
		internal global::AcpUI.AcpRtdButton RTDBtnDVRSWideLabtoolVrId_A43727;

		// Token: 0x04004D43 RID: 19779
		internal global::AcpUI.AcpCopyButton CpyBtnDVRSWideLabtoolVrId_A43727;

		// Token: 0x04004D44 RID: 19780
		internal global::AcpUI.AcpTextBoxDecHex DVRSWideLabtoolVrId_A43727Comp;

		// Token: 0x04004D45 RID: 19781
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnDVRSWideGeneralChannelOnlyDisplay_A41811;

		// Token: 0x04004D46 RID: 19782
		internal global::AcpUI.AcpLabel LblDVRSWideGeneralChannelOnlyDisplay_A41811;

		// Token: 0x04004D47 RID: 19783
		internal global::AcpUI.AcpCheckBox DVRSWideGeneralChannelOnlyDisplay_A41811;

		// Token: 0x04004D48 RID: 19784
		internal global::AcpUI.AcpRtdButton RTDBtnDVRSWideGeneralChannelOnlyDisplay_A41811;

		// Token: 0x04004D49 RID: 19785
		internal global::AcpUI.AcpCopyButton CpyBtnDVRSWideGeneralChannelOnlyDisplay_A41811;

		// Token: 0x04004D4A RID: 19786
		internal global::AcpUI.AcpCheckBox DVRSWideGeneralChannelOnlyDisplay_A41811Comp;

		// Token: 0x04004D4B RID: 19787
		private bool b;
	}
}
