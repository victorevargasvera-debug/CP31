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

namespace Motorola.MackinawCPS.CoreFeatures.GlobalNoiseReductionList
{
	// Token: 0x0200025A RID: 602
	public class PageGlobalNoiseReductionList : global::AcpUI.AcpPageFeature, global::System.Windows.Markup.IComponentConnector
	{
		// Token: 0x06006BEC RID: 27628 RVA: 0x006047A0 File Offset: 0x006029A0
		public PageGlobalNoiseReductionList()
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

		// Token: 0x06006BED RID: 27629 RVA: 0x006047D8 File Offset: 0x006029D8
		public override void OnLoaded(object sender, global::System.Windows.RoutedEventArgs e)
		{
			short num = (short)838533123;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				global::System.Collections.IEnumerator enumerator;
				global::AcpUI.AcpExpander acpExpander;
				switch (num2)
				{
				case 0:
					goto IL_235;
				case 1:
					try
					{
						num = (short)600440838;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 1:
								if (!enumerator.MoveNext())
								{
									num = (short)876806146;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								acpExpander = (((global::System.Windows.UIElement)enumerator.Current) as global::AcpUI.AcpExpander);
								num = (short)596377603;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 2:
								num = (short)746520581;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 3:
								if (acpExpander != null)
								{
									num = (short)763691012;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							case 4:
								for (;;)
								{
									num = (short)2137180121;
									short num3 = num;
									num = (short)1032112089;
									switch ((num3 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										break;
									default:
										goto IL_145;
									}
								}
								IL_145:
								num = (short)455737344;
								if (num != 0)
								{
								}
								base.Expanders.Add(acpExpander);
								num = (short)1267138560;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 5:
								goto IL_199;
							case 6:
								switch (0)
								{
								case 0:
									goto IL_9A;
								}
								continue;
							}
							IL_DA:
							num = (short)21233665;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_9A:
							goto IL_DA;
						}
						IL_199:
						goto IL_264;
					}
					finally
					{
						switch (0)
						{
						case 0:
							goto IL_1BA;
						}
						global::System.IDisposable disposable;
						for (;;)
						{
							IL_1A8:
							switch (num2)
							{
							case 0:
								disposable.Dispose();
								num = (short)1379008513;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 1:
								goto IL_232;
							case 2:
								if (disposable != null)
								{
									num = (short)1806303232;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_234;
							}
							goto IL_1BA;
						}
						IL_232:
						IL_234:
						goto EndFinally_7;
						IL_1BA:
						num = (short)477495297;
						if (num != 0)
						{
						}
						disposable = (enumerator as global::System.IDisposable);
						num = (short)1314324482;
						num2 = (int)((global::System.IntPtr)num);
						goto IL_1A8;
						EndFinally_7:;
					}
					goto IL_235;
					IL_264:
					base.OnLoaded(sender, e);
					this.a = true;
					num = (short)116785154;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					goto IL_28B;
				case 3:
					switch (0)
					{
					case 0:
						goto IL_35;
					}
					continue;
				}
				IL_35:
				if (!this.a)
				{
					num = (short)2081751040;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_235:
				acpExpander = null;
				enumerator = this.MyStackPanel.Children.GetEnumerator();
				num = (short)1293877249;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_28B:
			num = (short)1318584320;
			short num4 = num;
			this.MyStackPanel.Children[0].Focus();
		}

		// Token: 0x06006BEE RID: 27630 RVA: 0x00604AD0 File Offset: 0x00602CD0
		public override void OnUnloaded(object sender, global::System.Windows.RoutedEventArgs e)
		{
			short num = (short)565772290;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
				{
					num = (short)409141249;
					if (num != 0)
					{
					}
					base.OnUnloaded(sender, e);
					this.a = false;
					num = (short)975503360;
					short num3 = num;
					num = (short)1993080833;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 1:
				{
					num = (short)1004309751;
					short num4 = num;
					num = (short)1454804215;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_14;
					default:
						goto IL_FA;
					}
					break;
				}
				case 2:
					goto IL_14;
				}
				goto IL_30;
				IL_14:
				switch (0)
				{
				case 0:
					IL_30:
					if (!this.a)
					{
						return;
					}
					num = (short)616824832;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
			}
			IL_FA:
			num = (short)465829888;
			if (num != 0)
			{
			}
		}

		// Token: 0x06006BEF RID: 27631 RVA: 0x00604BF0 File Offset: 0x00602DF0
		public override void SetDataContext()
		{
			short num = (short)701693960;
			int num2 = (int)((global::System.IntPtr)num);
			object feature;
			for (;;)
			{
				switch (num2)
				{
				case 0:
					if (feature != null)
					{
						num = (short)77594631;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1E7;
				case 1:
					goto IL_1E7;
				case 2:
					base.DataContext = global::AcpCommonLib.AppInfoManager.DefaultDocument.GetFeature(2131);
					num = (short)2070020100;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					goto IL_A7;
				case 4:
					goto IL_A7;
				case 5:
					if (global::AcpCommonLib.AppInfoManager.AppMode == global::AcpCommonLib.ApplicationMode.CodeplugComparisonMode)
					{
						num = (short)394330118;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_126;
				case 6:
					feature = global::AcpCommonLib.AppInfoManager.ComparatorDocument.GetFeature(2131);
					num = (short)1434779648;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 7:
					goto IL_1E2;
				case 8:
					switch (0)
					{
					case 0:
						goto IL_48;
					}
					continue;
				}
				IL_48:
				if (global::AcpCommonLib.AppInfoManager.AppMode == global::AcpCommonLib.ApplicationMode.CustomViewConfigurationMode)
				{
					num = (short)1211957248;
					short num3 = num;
					num = (short)1208549378;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				base.DataContext = global::AcpCommonLib.FeatureManager.GetFeature(2131);
				num = (short)1956446211;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_A7:
				this.RecNavToolbarPageGlobalNoiseReductionList.DataContext = (global::AcpCommonLib.IAcpRecordset)base.DataContext;
				num = (short)155910149;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_126:
				num = (short)2121859073;
				if (num != 0)
				{
				}
				((global::AcpUILib.IAcpRecNavToolbar)this.RecNavToolbarPageGlobalNoiseReductionList).MySecondaryRecordsetDataSource = null;
				num = (short)2117533697;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_1E7:
				num = (short)1140345228;
				short num4 = num;
				num = (short)473123212;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_126;
				default:
					goto IL_21C;
				}
			}
			IL_1E2:
			((global::AcpUILib.IAcpRecNavToolbar)this.RecNavToolbarPageGlobalNoiseReductionList).MySecondaryRecordsetDataSource = (global::AcpCommonLib.IAcpRecordset)feature;
			return;
			IL_21C:
			num = (short)682491904;
			if (num != 0)
			{
			}
		}

		// Token: 0x06006BF0 RID: 27632 RVA: 0x00604E30 File Offset: 0x00603030
		private void OnModeClick(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			int a_ = 17;
			short num = (short)105578502;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					num = (short)1511718913;
					if (num != 0)
					{
					}
					if (((global::AcpUI.AcpRecNavToolbar)A_0).Name == global::AllFeatures.CodeplugGuid.b("胑뇓뗕雗믙ꫛ諝迟跡裣蓥觧飩볫迭韯韱돳髵韷飹鷻鋽仿洁洃甅洇堉椋樍攏焑怓缕眗琙倛眝匟嘡", a_))
					{
						num = (short)1862795269;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1AC;
				case 1:
				{
					global::AcpCommonLib.IAcpRecordset myRecordsetDataSource;
					if (myRecordsetDataSource != null)
					{
						num = (short)482344962;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1AC;
				}
				case 2:
				{
					global::AcpCommonLib.IAcpRecordset myRecordsetDataSource;
					base.NavigationService.Navigate(new global::System.Uri(myRecordsetDataSource.UIPagePath, global::System.UriKind.RelativeOrAbsolute));
					num = (short)1770389508;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 3:
					goto IL_131;
				case 4:
					goto IL_9A;
				case 5:
				{
					num = (short)370262763;
					short num3 = num;
					num = (short)1910424299;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_131;
					default:
					{
						num = (short)1871904768;
						if (num != 0)
						{
						}
						global::AcpCommonLib.IAcpRecordset myRecordsetDataSource = this.RecNavToolbarPageGlobalNoiseReductionList.MyRecordsetDataSource;
						num = (short)2068185089;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					break;
				}
				case 6:
					switch (0)
					{
					case 0:
						goto IL_4A;
					}
					continue;
				}
				IL_4A:
				if (A_0 is global::AcpUI.AcpRecNavToolbar)
				{
					num = (short)1898315779;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_131:
				num = (short)732561408;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_9A:
			IL_1AC:
			num = (short)1929183232;
			short num4 = num;
		}

		// Token: 0x06006BF1 RID: 27633 RVA: 0x00605014 File Offset: 0x00603214
		private void HLinkClick(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num = (short)674026440;
			short num2 = num;
			num = (short)686019528;
			switch (num2 == num)
			{
			}
			num = (short)375259136;
			short num3 = num;
			num = (short)734593025;
			if (num != 0)
			{
			}
			num = (short)1496449024;
			if (num != 0)
			{
			}
			base.OnHLinkClick(A_0);
		}

		// Token: 0x06006BF2 RID: 27634 RVA: 0x006050C8 File Offset: 0x006032C8
		private void OnFieldNameDoubleClick(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num = (short)870802861;
			short num2 = num;
			num = (short)1106077101;
			switch (num2 == num)
			{
			}
			num = (short)1499922432;
			short num3 = num;
			num = (short)1111621633;
			if (num != 0)
			{
			}
			num = (short)1851195392;
			if (num != 0)
			{
			}
			global::AcpUI.Common.Utility.GetFieldHelpText(A_0);
		}

		// Token: 0x06006BF3 RID: 27635 RVA: 0x00605178 File Offset: 0x00603378
		[global::System.Diagnostics.DebuggerNonUserCode]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "5.0.10.0")]
		public void InitializeComponent()
		{
			int a_ = 18;
			if (this.b)
			{
				short num = (short)833755933;
				short num2 = num;
				num = (short)1790581533;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)465567745;
					if (num != 0)
					{
					}
					num = (short)1837105152;
					if (num != 0)
					{
					}
					break;
				}
				num = (short)266665984;
				short num3 = num;
				return;
			}
			this.b = true;
			global::System.Uri resourceLocator = new global::System.Uri(global::AllFeatures.CodeplugGuid.b("ﳒ铔믖뗘鷚룜뻞闠離韤苦髨탪軬胮鳰菲髴駶鳸闺觼탾猀戂愄渆昈⸊㼌㼎琐愒爔砖眘琚瀜瘞䈠倢$ᔦᤨ䠪䈬䄮地娲刴䈶䬸娺䤼嘾⹀ⵂ橄⥆♈≊㹌⩎瑐慒敔╖㱘㽚⡜㱞ᕠ੢੤०䱨奪嵬౮Ṱᵲ፴ṶṸ๺ོṾꚈ璉늖ꮘꮚ좠킢삤芦鮨鮪\udfac쪮햰욲횴쎶킸풺펼骾꧄껆뫈뿊꣎뷐볒럔뛖뗘뗚닜뛞鋠蛢韤苦跨黪軬鯮飰鳲鯴鯶郸裺觼퇾礀戂栄欆", a_), global::System.UriKind.Relative);
			global::System.Windows.Application.LoadComponent(this, resourceLocator);
		}

		// Token: 0x06006BF4 RID: 27636 RVA: 0x0060525C File Offset: 0x0060345C
		[global::System.Diagnostics.DebuggerNonUserCode]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "5.0.10.0")]
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		void global::System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
		{
			short num = (short)1371144194;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					num = (short)1489371137;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					goto IL_22D;
				case 2:
					switch (0)
					{
					case 0:
						goto IL_32;
					}
					continue;
				}
				IL_32:
				switch (connectionId)
				{
				case 1:
					goto IL_441;
				case 2:
					goto IL_37A;
				case 3:
					goto IL_6F3;
				case 4:
					goto IL_4BD;
				case 5:
					goto IL_65D;
				case 6:
					goto IL_434;
				case 7:
					goto IL_17E;
				case 8:
					goto IL_4A3;
				case 9:
					goto IL_23F;
				case 10:
					goto IL_612;
				case 11:
					goto IL_232;
				case 12:
					goto IL_164;
				case 13:
					goto IL_315;
				case 14:
					goto IL_360;
				case 15:
					goto IL_1C9;
				case 16:
					goto IL_263;
				case 17:
					goto IL_353;
				case 18:
					goto IL_346;
				case 19:
					goto IL_308;
				case 20:
					goto IL_496;
				case 21:
					goto IL_4E1;
				case 22:
					goto IL_6B5;
				case 23:
					goto IL_3AB;
				case 24:
					goto IL_2A1;
				case 25:
					goto IL_2AE;
				case 26:
					goto IL_207;
				case 27:
					goto IL_403;
				case 28:
					goto IL_529;
				case 29:
					goto IL_643;
				case 30:
					goto IL_684;
				case 31:
					goto IL_39E;
				case 32:
					goto IL_36D;
				case 33:
					goto IL_691;
				case 34:
					goto IL_1A5;
				case 35:
					goto IL_157;
				case 36:
					goto IL_650;
				case 37:
					goto IL_636;
				case 38:
					goto IL_677;
				case 39:
					goto IL_2E4;
				case 40:
					goto IL_505;
				case 41:
					goto IL_700;
				case 42:
					goto IL_18B;
				case 43:
					goto IL_14A;
				case 44:
					goto IL_66A;
				case 45:
					goto IL_571;
				case 46:
					goto IL_3DF;
				case 47:
					goto IL_4B0;
				case 48:
					goto IL_294;
				case 49:
					goto IL_605;
				case 50:
					goto IL_171;
				case 51:
					goto IL_322;
				case 52:
					goto IL_54D;
				case 53:
					goto IL_427;
				case 54:
					goto IL_1ED;
				case 55:
					goto IL_287;
				case 56:
					goto IL_198;
				case 57:
					goto IL_595;
				case 58:
					goto IL_472;
				case 59:
					goto IL_6D9;
				case 60:
					goto IL_1FA;
				case 61:
					goto IL_6E6;
				default:
					num = (short)1807745024;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
			}
			IL_14A:
			this.DINCOUTPUTEQVECTOR_A21558Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_157:
			this.RTDBtnDINCBFEQVECTOR_A21557 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_164:
			this.CpyBtnDINCSPATIALEQ1VECTOR_A21553 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_171:
			this.CVBtnDINCHOTBEAMHYSTERESIS_A21559 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_17E:
			this.GrpBoxExpanderGlobalNoiseReductionListGeneralPseudo0 = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_18B:
			this.CpyBtnDINCOUTPUTEQVECTOR_A21558 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_198:
			this.CVBtnDINCBADMICHYSTERESIS_A21560 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_1A5:
			this.DINCBFEQVECTOR_A21557 = (global::AcpUI.AcpTextBox)target;
			this.DINCBFEQVECTOR_A21557.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_1C9:
			this.LblDINCSPATIALEQ1VECTORCONT_A37716 = (global::AcpUI.AcpLabel)target;
			this.LblDINCSPATIALEQ1VECTORCONT_A37716.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_1ED:
			this.CpyBtnDINCHOTBEAMHYSTERESIS_A21559 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_1FA:
			this.CpyBtnDINCBADMICHYSTERESIS_A21560 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_207:
			this.CVBtnDINCSPATIALEQ2VECTORCONT_A37717 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_22D:
			this.b = true;
			return;
			IL_232:
			this.RTDBtnDINCSPATIALEQ1VECTOR_A21553 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_23F:
			this.LblDINCSPATIALEQ1VECTOR_A21553 = (global::AcpUI.AcpLabel)target;
			this.LblDINCSPATIALEQ1VECTOR_A21553.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_263:
			this.DINCSPATIALEQ1VECTORCONT_A37716 = (global::AcpUI.AcpTextBox)target;
			this.DINCSPATIALEQ1VECTORCONT_A37716.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_287:
			this.DINCHOTBEAMHYSTERESIS_A21559Comp = (global::AcpUI.AcpTextBoxDecHex)target;
			return;
			IL_294:
			this.CpyBtnDINCELKOVECTOR_A21561 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_2A1:
			this.CpyBtnDINCSPATIALEQ2VECTOR_A21556 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_2AE:
			num = (short)444530688;
			short num3 = num;
			this.DINCSPATIALEQ2VECTOR_A21556Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_2E4:
			this.LblDINCOUTPUTEQVECTOR_A21558 = (global::AcpUI.AcpLabel)target;
			this.LblDINCOUTPUTEQVECTOR_A21558.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_308:
			this.DINCSPATIALEQ1VECTORCONT_A37716Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_315:
			this.DINCSPATIALEQ1VECTOR_A21553Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_322:
			this.LblDINCHOTBEAMHYSTERESIS_A21559 = (global::AcpUI.AcpLabel)target;
			this.LblDINCHOTBEAMHYSTERESIS_A21559.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_346:
			this.CpyBtnDINCSPATIALEQ1VECTORCONT_A37716 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_353:
			this.RTDBtnDINCSPATIALEQ1VECTORCONT_A37716 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_360:
			this.CVBtnDINCSPATIALEQ1VECTORCONT_A37716 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_36D:
			this.CVBtnDINCBFEQVECTOR_A21557 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_37A:
			this.RecNavToolbarPageGlobalNoiseReductionList = (global::AcpUI.AcpParentRecNavToolbar)target;
			this.RecNavToolbarPageGlobalNoiseReductionList.ModeClick += this.OnModeClick;
			return;
			IL_39E:
			this.DINCSPATIALEQ2VECTORCONT_A37717Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_3AB:
			num = (short)2052390913;
			if (num != 0)
			{
			}
			this.RTDBtnDINCSPATIALEQ2VECTOR_A21556 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_3DF:
			this.DINCELKOVECTOR_A21561 = (global::AcpUI.AcpTextBox)target;
			this.DINCELKOVECTOR_A21561.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_403:
			this.LblDINCSPATIALEQ2VECTORCONT_A37717 = (global::AcpUI.AcpLabel)target;
			this.LblDINCSPATIALEQ2VECTORCONT_A37717.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_427:
			this.RTDBtnDINCHOTBEAMHYSTERESIS_A21559 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_434:
			this.ExpanderGlobalNoiseReductionListGeneral = (global::AcpUI.AcpExpander)target;
			return;
			IL_441:
			((global::Motorola.MackinawCPS.CoreFeatures.GlobalNoiseReductionList.PageGlobalNoiseReductionList)target).Loaded += this.OnLoaded;
			((global::Motorola.MackinawCPS.CoreFeatures.GlobalNoiseReductionList.PageGlobalNoiseReductionList)target).Unloaded += this.OnUnloaded;
			return;
			IL_472:
			this.DINCBADMICHYSTERESIS_A21560 = (global::AcpUI.AcpTextBoxSpinnerDecHex)target;
			this.DINCBADMICHYSTERESIS_A21560.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_496:
			this.CVBtnDINCSPATIALEQ2VECTOR_A21556 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_4A3:
			this.CVBtnDINCSPATIALEQ1VECTOR_A21553 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_4B0:
			this.RTDBtnDINCELKOVECTOR_A21561 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_4BD:
			this.HLinkGeneral = (global::System.Windows.Documents.Hyperlink)target;
			this.HLinkGeneral.Click += this.HLinkClick;
			return;
			IL_4E1:
			this.LblDINCSPATIALEQ2VECTOR_A21556 = (global::AcpUI.AcpLabel)target;
			this.LblDINCSPATIALEQ2VECTOR_A21556.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_505:
			this.DINCOUTPUTEQVECTOR_A21558 = (global::AcpUI.AcpTextBox)target;
			this.DINCOUTPUTEQVECTOR_A21558.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_529:
			this.DINCSPATIALEQ2VECTORCONT_A37717 = (global::AcpUI.AcpTextBox)target;
			this.DINCSPATIALEQ2VECTORCONT_A37717.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_54D:
			this.DINCHOTBEAMHYSTERESIS_A21559 = (global::AcpUI.AcpTextBoxSpinnerDecHex)target;
			this.DINCHOTBEAMHYSTERESIS_A21559.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_571:
			this.LblDINCELKOVECTOR_A21561 = (global::AcpUI.AcpLabel)target;
			this.LblDINCELKOVECTOR_A21561.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_595:
			num = (short)1164709915;
			short num4 = num;
			num = (short)633016347;
			switch ((num4 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				goto IL_37A;
			default:
				num = (short)780075008;
				if (num != 0)
				{
				}
				this.LblDINCBADMICHYSTERESIS_A21560 = (global::AcpUI.AcpLabel)target;
				this.LblDINCBADMICHYSTERESIS_A21560.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
				return;
			}
			IL_605:
			this.DINCELKOVECTOR_A21561Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_612:
			this.DINCSPATIALEQ1VECTOR_A21553 = (global::AcpUI.AcpTextBox)target;
			this.DINCSPATIALEQ1VECTOR_A21553.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_636:
			this.DINCBFEQVECTOR_A21557Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_643:
			this.RTDBtnDINCSPATIALEQ2VECTORCONT_A37717 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_650:
			this.CpyBtnDINCBFEQVECTOR_A21557 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_65D:
			this.MyStackPanel = (global::System.Windows.Controls.StackPanel)target;
			return;
			IL_66A:
			this.CVBtnDINCELKOVECTOR_A21561 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_677:
			this.CVBtnDINCOUTPUTEQVECTOR_A21558 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_684:
			this.CpyBtnDINCSPATIALEQ2VECTORCONT_A37717 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_691:
			this.LblDINCBFEQVECTOR_A21557 = (global::AcpUI.AcpLabel)target;
			this.LblDINCBFEQVECTOR_A21557.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_6B5:
			this.DINCSPATIALEQ2VECTOR_A21556 = (global::AcpUI.AcpTextBox)target;
			this.DINCSPATIALEQ2VECTOR_A21556.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_6D9:
			this.RTDBtnDINCBADMICHYSTERESIS_A21560 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_6E6:
			this.DINCBADMICHYSTERESIS_A21560Comp = (global::AcpUI.AcpTextBoxDecHex)target;
			return;
			IL_6F3:
			this.ThemeBaseObj = (global::AcpUI.Common.AcpThemeBase)target;
			return;
			IL_700:
			this.RTDBtnDINCOUTPUTEQVECTOR_A21558 = (global::AcpUI.AcpRtdButton)target;
		}

		// Token: 0x040029FF RID: 10751
		private bool a;

		// Token: 0x04002A00 RID: 10752
		internal global::AcpUI.AcpParentRecNavToolbar RecNavToolbarPageGlobalNoiseReductionList;

		// Token: 0x04002A01 RID: 10753
		internal global::AcpUI.Common.AcpThemeBase ThemeBaseObj;

		// Token: 0x04002A02 RID: 10754
		internal global::System.Windows.Documents.Hyperlink HLinkGeneral;

		// Token: 0x04002A03 RID: 10755
		internal global::System.Windows.Controls.StackPanel MyStackPanel;

		// Token: 0x04002A04 RID: 10756
		internal global::AcpUI.AcpExpander ExpanderGlobalNoiseReductionListGeneral;

		// Token: 0x04002A05 RID: 10757
		internal global::AcpUI.AcpGroupBox GrpBoxExpanderGlobalNoiseReductionListGeneralPseudo0;

		// Token: 0x04002A06 RID: 10758
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnDINCSPATIALEQ1VECTOR_A21553;

		// Token: 0x04002A07 RID: 10759
		internal global::AcpUI.AcpLabel LblDINCSPATIALEQ1VECTOR_A21553;

		// Token: 0x04002A08 RID: 10760
		internal global::AcpUI.AcpTextBox DINCSPATIALEQ1VECTOR_A21553;

		// Token: 0x04002A09 RID: 10761
		internal global::AcpUI.AcpRtdButton RTDBtnDINCSPATIALEQ1VECTOR_A21553;

		// Token: 0x04002A0A RID: 10762
		internal global::AcpUI.AcpCopyButton CpyBtnDINCSPATIALEQ1VECTOR_A21553;

		// Token: 0x04002A0B RID: 10763
		internal global::AcpUI.AcpLabel DINCSPATIALEQ1VECTOR_A21553Comp;

		// Token: 0x04002A0C RID: 10764
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnDINCSPATIALEQ1VECTORCONT_A37716;

		// Token: 0x04002A0D RID: 10765
		internal global::AcpUI.AcpLabel LblDINCSPATIALEQ1VECTORCONT_A37716;

		// Token: 0x04002A0E RID: 10766
		internal global::AcpUI.AcpTextBox DINCSPATIALEQ1VECTORCONT_A37716;

		// Token: 0x04002A0F RID: 10767
		internal global::AcpUI.AcpRtdButton RTDBtnDINCSPATIALEQ1VECTORCONT_A37716;

		// Token: 0x04002A10 RID: 10768
		internal global::AcpUI.AcpCopyButton CpyBtnDINCSPATIALEQ1VECTORCONT_A37716;

		// Token: 0x04002A11 RID: 10769
		internal global::AcpUI.AcpLabel DINCSPATIALEQ1VECTORCONT_A37716Comp;

		// Token: 0x04002A12 RID: 10770
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnDINCSPATIALEQ2VECTOR_A21556;

		// Token: 0x04002A13 RID: 10771
		internal global::AcpUI.AcpLabel LblDINCSPATIALEQ2VECTOR_A21556;

		// Token: 0x04002A14 RID: 10772
		internal global::AcpUI.AcpTextBox DINCSPATIALEQ2VECTOR_A21556;

		// Token: 0x04002A15 RID: 10773
		internal global::AcpUI.AcpRtdButton RTDBtnDINCSPATIALEQ2VECTOR_A21556;

		// Token: 0x04002A16 RID: 10774
		internal global::AcpUI.AcpCopyButton CpyBtnDINCSPATIALEQ2VECTOR_A21556;

		// Token: 0x04002A17 RID: 10775
		internal global::AcpUI.AcpLabel DINCSPATIALEQ2VECTOR_A21556Comp;

		// Token: 0x04002A18 RID: 10776
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnDINCSPATIALEQ2VECTORCONT_A37717;

		// Token: 0x04002A19 RID: 10777
		internal global::AcpUI.AcpLabel LblDINCSPATIALEQ2VECTORCONT_A37717;

		// Token: 0x04002A1A RID: 10778
		internal global::AcpUI.AcpTextBox DINCSPATIALEQ2VECTORCONT_A37717;

		// Token: 0x04002A1B RID: 10779
		internal global::AcpUI.AcpRtdButton RTDBtnDINCSPATIALEQ2VECTORCONT_A37717;

		// Token: 0x04002A1C RID: 10780
		internal global::AcpUI.AcpCopyButton CpyBtnDINCSPATIALEQ2VECTORCONT_A37717;

		// Token: 0x04002A1D RID: 10781
		internal global::AcpUI.AcpLabel DINCSPATIALEQ2VECTORCONT_A37717Comp;

		// Token: 0x04002A1E RID: 10782
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnDINCBFEQVECTOR_A21557;

		// Token: 0x04002A1F RID: 10783
		internal global::AcpUI.AcpLabel LblDINCBFEQVECTOR_A21557;

		// Token: 0x04002A20 RID: 10784
		internal global::AcpUI.AcpTextBox DINCBFEQVECTOR_A21557;

		// Token: 0x04002A21 RID: 10785
		internal global::AcpUI.AcpRtdButton RTDBtnDINCBFEQVECTOR_A21557;

		// Token: 0x04002A22 RID: 10786
		internal global::AcpUI.AcpCopyButton CpyBtnDINCBFEQVECTOR_A21557;

		// Token: 0x04002A23 RID: 10787
		internal global::AcpUI.AcpLabel DINCBFEQVECTOR_A21557Comp;

		// Token: 0x04002A24 RID: 10788
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnDINCOUTPUTEQVECTOR_A21558;

		// Token: 0x04002A25 RID: 10789
		internal global::AcpUI.AcpLabel LblDINCOUTPUTEQVECTOR_A21558;

		// Token: 0x04002A26 RID: 10790
		internal global::AcpUI.AcpTextBox DINCOUTPUTEQVECTOR_A21558;

		// Token: 0x04002A27 RID: 10791
		internal global::AcpUI.AcpRtdButton RTDBtnDINCOUTPUTEQVECTOR_A21558;

		// Token: 0x04002A28 RID: 10792
		internal global::AcpUI.AcpCopyButton CpyBtnDINCOUTPUTEQVECTOR_A21558;

		// Token: 0x04002A29 RID: 10793
		internal global::AcpUI.AcpLabel DINCOUTPUTEQVECTOR_A21558Comp;

		// Token: 0x04002A2A RID: 10794
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnDINCELKOVECTOR_A21561;

		// Token: 0x04002A2B RID: 10795
		internal global::AcpUI.AcpLabel LblDINCELKOVECTOR_A21561;

		// Token: 0x04002A2C RID: 10796
		internal global::AcpUI.AcpTextBox DINCELKOVECTOR_A21561;

		// Token: 0x04002A2D RID: 10797
		internal global::AcpUI.AcpRtdButton RTDBtnDINCELKOVECTOR_A21561;

		// Token: 0x04002A2E RID: 10798
		internal global::AcpUI.AcpCopyButton CpyBtnDINCELKOVECTOR_A21561;

		// Token: 0x04002A2F RID: 10799
		internal global::AcpUI.AcpLabel DINCELKOVECTOR_A21561Comp;

		// Token: 0x04002A30 RID: 10800
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnDINCHOTBEAMHYSTERESIS_A21559;

		// Token: 0x04002A31 RID: 10801
		internal global::AcpUI.AcpLabel LblDINCHOTBEAMHYSTERESIS_A21559;

		// Token: 0x04002A32 RID: 10802
		internal global::AcpUI.AcpTextBoxSpinnerDecHex DINCHOTBEAMHYSTERESIS_A21559;

		// Token: 0x04002A33 RID: 10803
		internal global::AcpUI.AcpRtdButton RTDBtnDINCHOTBEAMHYSTERESIS_A21559;

		// Token: 0x04002A34 RID: 10804
		internal global::AcpUI.AcpCopyButton CpyBtnDINCHOTBEAMHYSTERESIS_A21559;

		// Token: 0x04002A35 RID: 10805
		internal global::AcpUI.AcpTextBoxDecHex DINCHOTBEAMHYSTERESIS_A21559Comp;

		// Token: 0x04002A36 RID: 10806
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnDINCBADMICHYSTERESIS_A21560;

		// Token: 0x04002A37 RID: 10807
		internal global::AcpUI.AcpLabel LblDINCBADMICHYSTERESIS_A21560;

		// Token: 0x04002A38 RID: 10808
		internal global::AcpUI.AcpTextBoxSpinnerDecHex DINCBADMICHYSTERESIS_A21560;

		// Token: 0x04002A39 RID: 10809
		internal global::AcpUI.AcpRtdButton RTDBtnDINCBADMICHYSTERESIS_A21560;

		// Token: 0x04002A3A RID: 10810
		internal global::AcpUI.AcpCopyButton CpyBtnDINCBADMICHYSTERESIS_A21560;

		// Token: 0x04002A3B RID: 10811
		internal global::AcpUI.AcpTextBoxDecHex DINCBADMICHYSTERESIS_A21560Comp;

		// Token: 0x04002A3C RID: 10812
		private bool b;
	}
}
