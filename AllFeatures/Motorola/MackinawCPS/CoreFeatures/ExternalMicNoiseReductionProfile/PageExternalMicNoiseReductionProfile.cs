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

namespace Motorola.MackinawCPS.CoreFeatures.ExternalMicNoiseReductionProfile
{
	// Token: 0x02000260 RID: 608
	public class PageExternalMicNoiseReductionProfile : global::AcpUI.AcpPageFeature, global::System.Windows.Markup.IComponentConnector
	{
		// Token: 0x06006C12 RID: 27666 RVA: 0x006079AC File Offset: 0x00605BAC
		public PageExternalMicNoiseReductionProfile()
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

		// Token: 0x06006C13 RID: 27667 RVA: 0x006079E4 File Offset: 0x00605BE4
		public override void OnLoaded(object sender, global::System.Windows.RoutedEventArgs e)
		{
			short num = (short)1479999489;
			if (num != 0)
			{
			}
			num = (short)1133466223;
			short num2 = num;
			num = (short)916214383;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			case 1:
				goto IL_87;
			default:
			{
				num = (short)709099520;
				short num3 = num;
				goto IL_87;
			}
			}
			int num4;
			for (;;)
			{
				IL_BC:
				global::AcpUI.AcpExpander acpExpander;
				global::System.Collections.IEnumerator enumerator;
				switch (num4)
				{
				case 0:
					switch (0)
					{
					case 0:
						goto IL_D2;
					}
					continue;
				case 1:
					goto IL_2B0;
				case 2:
					try
					{
						num = (short)312344578;
						num4 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num4)
							{
							case 0:
								base.Expanders.Add(acpExpander);
								num = (short)270008323;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							case 1:
								if (acpExpander != null)
								{
									num = (short)471597056;
									num4 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							case 2:
								switch (0)
								{
								case 0:
									goto IL_136;
								}
								continue;
							case 4:
								goto IL_1E9;
							case 5:
								num = (short)1128267780;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							case 6:
								if (!enumerator.MoveNext())
								{
									num = (short)262144005;
									num4 = (int)((global::System.IntPtr)num);
									continue;
								}
								acpExpander = (((global::System.Windows.UIElement)enumerator.Current) as global::AcpUI.AcpExpander);
								num = (short)532086785;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							IL_177:
							num = (short)697499654;
							num4 = (int)((global::System.IntPtr)num);
							continue;
							IL_136:
							goto IL_177;
						}
						IL_1E9:
						goto IL_28A;
					}
					finally
					{
						switch (0)
						{
						case 0:
							goto IL_20A;
						}
						global::System.IDisposable disposable;
						for (;;)
						{
							IL_1F8:
							switch (num4)
							{
							case 0:
								if (disposable != null)
								{
									num = (short)1720057858;
									num4 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_25A;
							case 1:
								goto IL_258;
							case 2:
								disposable.Dispose();
								num = (short)842137601;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_20A;
						}
						IL_258:
						IL_25A:
						goto EndFinally_8;
						IL_20A:
						disposable = (enumerator as global::System.IDisposable);
						num = (short)1054736384;
						num4 = (int)((global::System.IntPtr)num);
						goto IL_1F8;
						EndFinally_8:;
					}
					goto IL_25B;
					IL_28A:
					base.OnLoaded(sender, e);
					this.a = true;
					num = (short)1609498625;
					num4 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					goto IL_25B;
				}
				IL_D2:
				if (!this.a)
				{
					num = (short)249495555;
					num4 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_25B:
				acpExpander = null;
				enumerator = this.MyStackPanel.Children.GetEnumerator();
				num = (short)1759182850;
				num4 = (int)((global::System.IntPtr)num);
			}
			IL_2B0:
			this.MyStackPanel.Children[0].Focus();
			return;
			IL_87:
			num = (short)887554048;
			if (num != 0)
			{
			}
			num = (short)1439170560;
			num4 = (int)((global::System.IntPtr)num);
			goto IL_BC;
		}

		// Token: 0x06006C14 RID: 27668 RVA: 0x00607CCC File Offset: 0x00605ECC
		public override void OnUnloaded(object sender, global::System.Windows.RoutedEventArgs e)
		{
			short num = (short)745078784;
			short num2 = num;
			num = (short)954662912;
			int num3 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num3)
				{
				case 0:
					goto IL_3E;
				case 1:
				{
					num = (short)1076882227;
					short num4 = num;
					num = (short)589622067;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_3E;
					default:
						goto IL_D3;
					}
					break;
				}
				case 2:
					base.OnUnloaded(sender, e);
					this.a = false;
					num = (short)774307841;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_5A;
				IL_3E:
				switch (0)
				{
				case 0:
					IL_5A:
					if (!this.a)
					{
						return;
					}
					num = (short)1794048002;
					num3 = (int)((global::System.IntPtr)num);
					break;
				}
			}
			IL_D3:
			num = (short)965476353;
			if (num != 0)
			{
			}
			num = (short)295174144;
			if (num != 0)
			{
			}
		}

		// Token: 0x06006C15 RID: 27669 RVA: 0x00607DEC File Offset: 0x00605FEC
		public override void SetDataContext()
		{
			object feature;
			for (;;)
			{
				IL_00:
				short num = (short)159776772;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
					{
						num = (short)1395392512;
						short num3 = num;
						if (feature != null)
						{
							num = (short)1126825987;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					}
					case 1:
						base.DataContext = global::AcpCommonLib.AppInfoManager.DefaultDocument.GetFeature(2087);
						num = (short)311164934;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						if (global::AcpCommonLib.AppInfoManager.AppMode == global::AcpCommonLib.ApplicationMode.CodeplugComparisonMode)
						{
							num = (short)1624244232;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						((global::AcpUILib.IAcpRecNavToolbar)this.RecNavToolbarPageExternalMicNoiseReductionProfile).MySecondaryRecordsetDataSource = null;
						num = (short)531628039;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						goto IL_238;
					case 4:
						switch (0)
						{
						case 0:
							goto IL_4A;
						}
						continue;
					case 5:
						goto IL_7E;
					case 6:
					{
						num = (short)342798254;
						short num4 = num;
						num = (short)341487534;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_00;
						default:
							num = (short)1293484032;
							if (num != 0)
							{
							}
							goto IL_7E;
						}
						break;
					}
					case 7:
						goto IL_173;
					case 8:
						feature = global::AcpCommonLib.AppInfoManager.ComparatorDocument.GetFeature(2087);
						num = (short)1380384769;
						if (num != 0)
						{
						}
						num = (short)1212809216;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_4A:
					if (global::AcpCommonLib.AppInfoManager.AppMode == global::AcpCommonLib.ApplicationMode.CustomViewConfigurationMode)
					{
						num = (short)1442512897;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					base.DataContext = global::AcpCommonLib.FeatureManager.GetFeature(2087);
					num = (short)411566085;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_7E:
					this.RecNavToolbarPageExternalMicNoiseReductionProfile.DataContext = (global::AcpCommonLib.IAcpRecordset)base.DataContext;
					num = (short)1573519362;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
			IL_173:
			return;
			IL_238:
			((global::AcpUILib.IAcpRecNavToolbar)this.RecNavToolbarPageExternalMicNoiseReductionProfile).MySecondaryRecordsetDataSource = (global::AcpCommonLib.IAcpRecordset)feature;
		}

		// Token: 0x06006C16 RID: 27670 RVA: 0x00608038 File Offset: 0x00606238
		private void OnModeClick(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			int a_ = 3;
			short num = (short)1761542149;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
				{
					global::AcpCommonLib.IAcpRecordset myRecordsetDataSource;
					if (myRecordsetDataSource != null)
					{
						num = (short)647102467;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				}
				case 1:
				{
					num = (short)837484544;
					short num3 = num;
					global::AcpCommonLib.IAcpRecordset myRecordsetDataSource = this.RecNavToolbarPageExternalMicNoiseReductionProfile.MyRecordsetDataSource;
					num = (short)1809121280;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 2:
					return;
				case 3:
				{
					num = (short)1126891521;
					if (num != 0)
					{
					}
					global::AcpCommonLib.IAcpRecordset myRecordsetDataSource;
					base.NavigationService.Navigate(new global::System.Uri(myRecordsetDataSource.UIPagePath, global::System.UriKind.RelativeOrAbsolute));
					goto IL_AE;
				}
				case 4:
				{
					if (!(((global::AcpUI.AcpRecNavToolbar)A_0).Name == global::AllFeatures.CodeplugGuid.b("雃ꏅꯇ蓉귋룍蓏뷑믓뫕뫗믙껛軝臟藡臣ꏥ郧黩觫鳭黯鏱飳믵釷駹닻釽槿焁愃吅洇渉礋洍搏笑笓砕䠗栙猛砝䤟両䄣", a_)))
					{
						return;
					}
					num = (short)211172646;
					short num4 = num;
					num = (short)1735671078;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_AE;
					default:
						num = (short)1247215616;
						if (num != 0)
						{
						}
						num = (short)1157758977;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 5:
					switch (0)
					{
					case 0:
						goto IL_49;
					}
					continue;
				case 6:
					num = (short)1076953092;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_49:
				if (A_0 is global::AcpUI.AcpRecNavToolbar)
				{
					num = (short)202702854;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_AE:
				num = (short)317128706;
				num2 = (int)((global::System.IntPtr)num);
			}
		}

		// Token: 0x06006C17 RID: 27671 RVA: 0x00608220 File Offset: 0x00606420
		private void HLinkClick(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num = (short)505088235;
			short num2 = num;
			num = (short)382732523;
			switch (num2 == num)
			{
			}
			num = (short)851969;
			if (num != 0)
			{
			}
			num = (short)1848180736;
			if (num != 0)
			{
			}
			num = (short)6356992;
			short num3 = num;
			base.OnHLinkClick(A_0);
		}

		// Token: 0x06006C18 RID: 27672 RVA: 0x006082D4 File Offset: 0x006064D4
		private void OnFieldNameDoubleClick(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num = (short)1271781415;
			short num2 = num;
			num = (short)349820967;
			switch (num2 == num)
			{
			}
			num = (short)359399425;
			if (num != 0)
			{
			}
			num = (short)697565184;
			if (num != 0)
			{
			}
			num = (short)1884749824;
			short num3 = num;
			global::AcpUI.Common.Utility.GetFieldHelpText(A_0);
		}

		// Token: 0x06006C19 RID: 27673 RVA: 0x00608384 File Offset: 0x00606584
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "5.0.10.0")]
		[global::System.Diagnostics.DebuggerNonUserCode]
		public void InitializeComponent()
		{
			int a_ = 10;
			if (!this.b)
			{
				short num = (short)1240137729;
				if (num != 0)
				{
				}
				num = (short)1849622528;
				short num2 = num;
				num = (short)271735935;
				short num3 = num;
				num = (short)1759927423;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)1850146816;
					if (num != 0)
					{
					}
					this.b = true;
					global::System.Uri resourceLocator = new global::System.Uri(global::AllFeatures.CodeplugGuid.b("賌ꏎ뷐闒냔뛖귘껚꿜뫞鋠\ud8e2蛤裦蓨鯪苬臮铰鷲致\ud8f6诸髺駼雾渀☂㜄㜆氈礊樌怎缐簒研縖稘栚㠜ⴞᄠ䀢䨤䤦伨䈪䨬娮䌰刲䄴帶嘸唺ሼ儾⹀⩂㙄≆汈祊経㵎㑐㝒⁔㑖ⵘ㉚㉜ㅞ䑠兢啤Ѧ٨ժ୬ٮᙰٲݴᙶ൸ቺቼᅾ꺀ﶄ力﶐뚒ꞔꞖﺜ몞鎠鎢쮤좦삨\ud8aa좬誮莰莲잴튶\uddb8캺\udebc쮾ꣀ곂ꯄ﯈﯊뷌뷎뻐뗒볔믖볘룜꟞闠蛢韤触裨蟪胬蛮鋰鷲髴黶諸黺迼髾攀瘂昄猆怈搊挌缎挐簒猔縖甘縚㌜朞䀠丢䤤", a_), global::System.UriKind.Relative);
					global::System.Windows.Application.LoadComponent(this, resourceLocator);
					return;
				}
				}
			}
		}

		// Token: 0x06006C1A RID: 27674 RVA: 0x00608468 File Offset: 0x00606668
		[global::System.Diagnostics.DebuggerNonUserCode]
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "5.0.10.0")]
		void global::System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
		{
			short num = (short)1532887042;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					num = (short)1183580161;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					goto IL_367;
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
					goto IL_8F5;
				case 2:
					goto IL_4F6;
				case 3:
					goto IL_484;
				case 4:
					goto IL_824;
				case 5:
					goto IL_926;
				case 6:
					goto IL_C38;
				case 7:
					goto IL_B23;
				case 8:
					goto IL_BD3;
				case 9:
					goto IL_57C;
				case 10:
					goto IL_D02;
				case 11:
					goto IL_80A;
				case 12:
					goto IL_C45;
				case 13:
					goto IL_C52;
				case 14:
					goto IL_817;
				case 15:
					goto IL_68B;
				case 16:
					goto IL_28A;
				case 17:
					goto IL_848;
				case 18:
					goto IL_54B;
				case 19:
					goto IL_4E9;
				case 20:
					goto IL_3A0;
				case 21:
					goto IL_98B;
				case 22:
					goto IL_5A0;
				case 23:
					goto IL_657;
				case 24:
					goto IL_393;
				case 25:
					goto IL_CB7;
				case 26:
					goto IL_7FD;
				case 27:
					goto IL_270;
				case 28:
					goto IL_408;
				case 29:
					goto IL_B7B;
				case 30:
					goto IL_3AD;
				case 31:
					goto IL_2D5;
				case 32:
					goto IL_53E;
				case 33:
					goto IL_46A;
				case 34:
					goto IL_45D;
				case 35:
					goto IL_5D1;
				case 36:
					goto IL_D26;
				case 37:
					goto IL_450;
				case 38:
					goto IL_A73;
				case 39:
					goto IL_BED;
				case 40:
					goto IL_3FB;
				case 41:
					goto IL_A04;
				case 42:
					goto IL_BFA;
				case 43:
					goto IL_A80;
				case 44:
					goto IL_4B5;
				case 45:
					goto IL_8A0;
				case 46:
					goto IL_671;
				case 47:
					goto IL_4CF;
				case 48:
					goto IL_95A;
				case 49:
					goto IL_855;
				case 50:
					goto IL_3E1;
				case 51:
					goto IL_3D4;
				case 52:
					goto IL_BC6;
				case 53:
					goto IL_72C;
				case 54:
					goto IL_C2B;
				case 55:
					goto IL_708;
				case 56:
					goto IL_32A;
				case 57:
					goto IL_79B;
				case 58:
					goto IL_739;
				case 59:
					goto IL_94D;
				case 60:
					goto IL_BB9;
				case 61:
					goto IL_491;
				case 62:
					goto IL_777;
				case 63:
					goto IL_940;
				case 64:
					goto IL_CC4;
				case 65:
					goto IL_97E;
				case 66:
					goto IL_477;
				case 67:
					goto IL_C9D;
				case 68:
					goto IL_8AD;
				case 69:
					goto IL_C79;
				case 70:
					goto IL_746;
				case 71:
					goto IL_67E;
				case 72:
					goto IL_A59;
				case 73:
					goto IL_263;
				case 74:
					goto IL_6E4;
				case 75:
					goto IL_7D9;
				case 76:
					goto IL_2C8;
				case 77:
					goto IL_933;
				case 78:
					goto IL_664;
				case 79:
					goto IL_5C4;
				case 80:
					goto IL_7A8;
				case 81:
					goto IL_AD8;
				case 82:
					goto IL_3EE;
				case 83:
					goto IL_B9F;
				case 84:
					goto IL_A9A;
				case 85:
					goto IL_893;
				case 86:
					goto IL_9E0;
				case 87:
					goto IL_9BC;
				case 88:
					goto IL_2AE;
				case 89:
					goto IL_886;
				case 90:
					goto IL_256;
				case 91:
					goto IL_879;
				case 92:
					goto IL_AFC;
				case 93:
					goto IL_AB4;
				case 94:
					goto IL_A35;
				case 95:
					goto IL_619;
				case 96:
					goto IL_4C2;
				case 97:
					goto IL_6AF;
				case 98:
					goto IL_A8D;
				case 99:
					goto IL_8D1;
				case 100:
					goto IL_558;
				case 101:
					goto IL_7CC;
				case 102:
					goto IL_3C7;
				case 103:
					goto IL_BE0;
				case 104:
					goto IL_A66;
				case 105:
					goto IL_27D;
				case 106:
					goto IL_42C;
				case 107:
					goto IL_5F5;
				case 108:
					goto IL_626;
				case 109:
					goto IL_B09;
				case 110:
					goto IL_C5F;
				case 111:
					goto IL_4DC;
				case 112:
					goto IL_2E2;
				case 113:
					goto IL_633;
				case 114:
					goto IL_9AF;
				case 115:
					goto IL_3BA;
				case 116:
					goto IL_A28;
				case 117:
					goto IL_2BB;
				case 118:
					goto IL_51A;
				case 119:
					goto IL_753;
				case 120:
					goto IL_CF5;
				case 121:
					goto IL_AA7;
				case 122:
					goto IL_C6C;
				case 123:
					goto IL_B16;
				case 124:
					goto IL_CD1;
				case 125:
					goto IL_306;
				case 126:
					goto IL_BAC;
				case 127:
					goto IL_CAA;
				case 128:
					goto IL_C1E;
				default:
					num = (short)1418067968;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
			}
			IL_256:
			this.RadErgoCfgGeneralRTHRESHDBQ8_A22308Comp = (global::AcpUI.AcpTextBoxDecHex)target;
			return;
			IL_263:
			this.CVBtnRadErgoCfgGeneralSDIFFTHRESHDBQ8_A22306 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_270:
			this.CVBtnRadErgoCfgGeneralDINCABFSS_A22300 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_27D:
			this.CVBtnExtMicNsRdGenACCESSORYAUTONOISEBOUNDSDBQ8_42686 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_28A:
			this.RadErgoCfgGeneralDINCEWINDNBANDS_A22301 = (global::AcpUI.AcpTextBoxSpinnerDecHex)target;
			this.RadErgoCfgGeneralDINCEWINDNBANDS_A22301.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_2AE:
			this.RTDBtnRadErgoCfgGeneralRTHRESHDBQ8_A22308 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_2BB:
			this.CVBtnExtMicNsRdGenACCESSORYAUTORELAXTIONBOUNDS_42688 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_2C8:
			this.RTDBtnRadErgoCfgGeneralSDIFFTHRESHDBQ8_A22306 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_2D5:
			this.CpyBtnRadErgoCfgGeneralDINCABFSS_A22300 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_2E2:
			this.LblExtMicNsRdGenACCESSORYAUTOMINGAINVECTOR_42687 = (global::AcpUI.AcpLabel)target;
			this.LblExtMicNsRdGenACCESSORYAUTOMINGAINVECTOR_42687.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_306:
			this.ExtMicNsRdGenACCESSORYPASSFILTERSTART_42689 = (global::AcpUI.AcpTextBoxSpinner)target;
			this.ExtMicNsRdGenACCESSORYPASSFILTERSTART_42689.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_32A:
			this.RadErgoCfgGeneralVADDETTHRESHDBQ8_A22303 = (global::AcpUI.AcpTextBoxSpinnerDecHex)target;
			this.RadErgoCfgGeneralVADDETTHRESHDBQ8_A22303.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_367:
			num = (short)1477181441;
			if (num != 0)
			{
			}
			this.b = true;
			return;
			IL_393:
			this.CpyBtnRadErgoCfgGeneralMAXSVECTOR_A22297 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_3A0:
			this.CVBtnRadErgoCfgGeneralMAXSVECTOR_A22297 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_3AD:
			this.RTDBtnRadErgoCfgGeneralDINCABFSS_A22300 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_3BA:
			this.CpyBtnExtMicNsRdGenACCESSORYAUTOMINGAINVECTOR_42687 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_3C7:
			this.CpyBtnExtMicNsRdGenDINCEPVECTOR_A37721 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_3D4:
			this.CpyBtnRadErgoCfgGeneralHOTBEAMDETTHRESHDBQ8_A22302 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_3E1:
			this.RTDBtnRadErgoCfgGeneralHOTBEAMDETTHRESHDBQ8_A22302 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_3EE:
			this.RTDBtnRadErgoCfgGeneralNDIFFTHRESHDBQ8_A22307 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_3FB:
			this.CVBtnRadErgoCfgGeneralEXPANSIONDEGREE_A22299 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_408:
			this.LblRadErgoCfgGeneralDINCABFSS_A22300 = (global::AcpUI.AcpLabel)target;
			this.LblRadErgoCfgGeneralDINCABFSS_A22300.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_42C:
			this.LblExtMicNsRdGenACCESSORYAUTONOISEBOUNDSDBQ8_42686 = (global::AcpUI.AcpLabel)target;
			this.LblExtMicNsRdGenACCESSORYAUTONOISEBOUNDSDBQ8_42686.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_450:
			this.RTDBtnRadErgoCfgGeneralMINGAIN_A22298 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_45D:
			this.CVBtnRadErgoCfgGeneralMINGAIN_A22298 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_46A:
			this.GrpBoxExpanderExternalMicNoiseReductionProfileGeneralDWF = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_477:
			this.GrpBoxExpanderExternalMicNoiseReductionProfileGeneralBadMic = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_484:
			this.ThemeBaseObj = (global::AcpUI.Common.AcpThemeBase)target;
			return;
			IL_491:
			this.LblRadErgoCfgGeneralVADDETCOUNT_A22304 = (global::AcpUI.AcpLabel)target;
			this.LblRadErgoCfgGeneralVADDETCOUNT_A22304.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_4B5:
			this.CpyBtnRadErgoCfgGeneralEXPANSIONDEGREE_A22299 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_4C2:
			this.CpyBtnExtMicNsRdGenDINCOUTPUTEQVECTOR_A37720 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_4CF:
			this.CVBtnRadErgoCfgGeneralHOTBEAMDETTHRESHDBQ8_A22302 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_4DC:
			this.CVBtnExtMicNsRdGenACCESSORYAUTOMINGAINVECTOR_42687 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_4E9:
			this.RadErgoCfgGeneralDINCEWINDNBANDS_A22301Comp = (global::AcpUI.AcpTextBoxDecHex)target;
			return;
			IL_4F6:
			this.RecNavToolbarPageExternalMicNoiseReductionProfile = (global::AcpUI.AcpParentRecNavToolbar)target;
			this.RecNavToolbarPageExternalMicNoiseReductionProfile.ModeClick += this.OnModeClick;
			return;
			IL_51A:
			this.LblExtMicNsRdGenACCESSORYAUTORELAXTIONBOUNDS_42688 = (global::AcpUI.AcpLabel)target;
			this.LblExtMicNsRdGenACCESSORYAUTORELAXTIONBOUNDS_42688.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_53E:
			this.RadErgoCfgGeneralDINCABFSS_A22300Comp = (global::AcpUI.AcpTextBoxDecHex)target;
			return;
			IL_54B:
			this.CpyBtnRadErgoCfgGeneralDINCEWINDNBANDS_A22301 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_558:
			this.ExtMicNsRdGenDINCEPVECTOR_A37721 = (global::AcpUI.AcpTextBox)target;
			this.ExtMicNsRdGenDINCEPVECTOR_A37721.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_57C:
			this.LblExternalMicNoiseReductionProfileName_A22536 = (global::AcpUI.AcpLabel)target;
			this.LblExternalMicNoiseReductionProfileName_A22536.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_5A0:
			this.RadErgoCfgGeneralMAXSVECTOR_A22297 = (global::AcpUI.AcpTextBox)target;
			this.RadErgoCfgGeneralMAXSVECTOR_A22297.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_5C4:
			this.CVBtnRadErgoCfgGeneralNDIFFTHRESHDBQ8_A22307 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_5D1:
			this.LblRadErgoCfgGeneralMINGAIN_A22298 = (global::AcpUI.AcpLabel)target;
			this.LblRadErgoCfgGeneralMINGAIN_A22298.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_5F5:
			this.ExtMicNsRdGenACCESSORYAUTONOISEBOUNDSDBQ8_42686 = (global::AcpUI.AcpTextBox)target;
			this.ExtMicNsRdGenACCESSORYAUTONOISEBOUNDSDBQ8_42686.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_619:
			this.RTDBtnExtMicNsRdGenDINCOUTPUTEQVECTOR_A37720 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_626:
			this.RTDBtnExtMicNsRdGenACCESSORYAUTONOISEBOUNDSDBQ8_42686 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_633:
			this.ExtMicNsRdGenACCESSORYAUTOMINGAINVECTOR_42687 = (global::AcpUI.AcpTextBox)target;
			this.ExtMicNsRdGenACCESSORYAUTOMINGAINVECTOR_42687.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_657:
			this.RTDBtnRadErgoCfgGeneralMAXSVECTOR_A22297 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_664:
			this.RadErgoCfgGeneralSDIFFTHRESHDBQ8_A22306Comp = (global::AcpUI.AcpTextBoxDecHex)target;
			return;
			IL_671:
			this.GrpBoxExpanderExternalMicNoiseReductionProfileGeneralPseudo2 = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_67E:
			this.CpyBtnRadErgoCfgGeneralINACTIVETHRESHDBQ8_A22305 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_68B:
			this.LblRadErgoCfgGeneralDINCEWINDNBANDS_A22301 = (global::AcpUI.AcpLabel)target;
			this.LblRadErgoCfgGeneralDINCEWINDNBANDS_A22301.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_6AF:
			num = (short)406257664;
			short num3 = num;
			this.ExtMicNsRdGenDINCOUTPUTEQVECTOR_A37720Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_6E4:
			this.LblRadErgoCfgGeneralSDIFFTHRESHDBQ8_A22306 = (global::AcpUI.AcpLabel)target;
			this.LblRadErgoCfgGeneralSDIFFTHRESHDBQ8_A22306.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_708:
			this.LblRadErgoCfgGeneralVADDETTHRESHDBQ8_A22303 = (global::AcpUI.AcpLabel)target;
			this.LblRadErgoCfgGeneralVADDETTHRESHDBQ8_A22303.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_72C:
			this.GrpBoxExpanderExternalMicNoiseReductionProfileGeneralStatus = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_739:
			this.CpyBtnRadErgoCfgGeneralVADDETTHRESHDBQ8_A22303 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_746:
			this.RTDBtnRadErgoCfgGeneralINACTIVETHRESHDBQ8_A22305 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_753:
			this.ExtMicNsRdGenACCESSORYAUTORELAXTIONBOUNDS_42688 = (global::AcpUI.AcpTextBox)target;
			this.ExtMicNsRdGenACCESSORYAUTORELAXTIONBOUNDS_42688.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_777:
			this.RadErgoCfgGeneralVADDETCOUNT_A22304 = (global::AcpUI.AcpTextBoxSpinnerDecHex)target;
			this.RadErgoCfgGeneralVADDETCOUNT_A22304.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_79B:
			this.RTDBtnRadErgoCfgGeneralVADDETTHRESHDBQ8_A22303 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_7A8:
			this.LblRadErgoCfgGeneralNDIFFTHRESHDBQ8_A22307 = (global::AcpUI.AcpLabel)target;
			this.LblRadErgoCfgGeneralNDIFFTHRESHDBQ8_A22307.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_7CC:
			this.RTDBtnExtMicNsRdGenDINCEPVECTOR_A37721 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_7D9:
			this.RadErgoCfgGeneralSDIFFTHRESHDBQ8_A22306 = (global::AcpUI.AcpTextBoxSpinnerDecHex)target;
			this.RadErgoCfgGeneralSDIFFTHRESHDBQ8_A22306.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_7FD:
			this.GrpBoxExpanderExternalMicNoiseReductionProfileGeneralPseudo1 = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_80A:
			this.CpyBtnExternalMicNoiseReductionProfileName_A22536 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_817:
			this.CVBtnRadErgoCfgGeneralDINCEWINDNBANDS_A22301 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_824:
			this.HLinkGeneral = (global::System.Windows.Documents.Hyperlink)target;
			this.HLinkGeneral.Click += this.HLinkClick;
			return;
			IL_848:
			this.RTDBtnRadErgoCfgGeneralDINCEWINDNBANDS_A22301 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_855:
			this.RadErgoCfgGeneralHOTBEAMDETTHRESHDBQ8_A22302 = (global::AcpUI.AcpTextBoxSpinnerDecHex)target;
			this.RadErgoCfgGeneralHOTBEAMDETTHRESHDBQ8_A22302.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_879:
			this.GrpBoxExpanderExternalMicNoiseReductionProfileGeneralPseudo4 = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_886:
			this.CpyBtnRadErgoCfgGeneralRTHRESHDBQ8_A22308 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_893:
			this.CVBtnRadErgoCfgGeneralRTHRESHDBQ8_A22308 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_8A0:
			this.RadErgoCfgGeneralEXPANSIONDEGREE_A22299Comp = (global::AcpUI.AcpTextBoxDecHex)target;
			return;
			IL_8AD:
			this.LblRadErgoCfgGeneralINACTIVETHRESHDBQ8_A22305 = (global::AcpUI.AcpLabel)target;
			this.LblRadErgoCfgGeneralINACTIVETHRESHDBQ8_A22305.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_8D1:
			this.LblExtMicNsRdGenDINCEPVECTOR_A37721 = (global::AcpUI.AcpLabel)target;
			this.LblExtMicNsRdGenDINCEPVECTOR_A37721.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_8F5:
			((global::Motorola.MackinawCPS.CoreFeatures.ExternalMicNoiseReductionProfile.PageExternalMicNoiseReductionProfile)target).Loaded += this.OnLoaded;
			((global::Motorola.MackinawCPS.CoreFeatures.ExternalMicNoiseReductionProfile.PageExternalMicNoiseReductionProfile)target).Unloaded += this.OnUnloaded;
			return;
			IL_926:
			this.MyStackPanel = (global::System.Windows.Controls.StackPanel)target;
			return;
			IL_933:
			this.CpyBtnRadErgoCfgGeneralSDIFFTHRESHDBQ8_A22306 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_940:
			this.RTDBtnRadErgoCfgGeneralVADDETCOUNT_A22304 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_94D:
			this.RadErgoCfgGeneralVADDETTHRESHDBQ8_A22303Comp = (global::AcpUI.AcpTextBoxDecHex)target;
			return;
			IL_95A:
			this.LblRadErgoCfgGeneralHOTBEAMDETTHRESHDBQ8_A22302 = (global::AcpUI.AcpLabel)target;
			this.LblRadErgoCfgGeneralHOTBEAMDETTHRESHDBQ8_A22302.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_97E:
			this.RadErgoCfgGeneralVADDETCOUNT_A22304Comp = (global::AcpUI.AcpTextBoxDecHex)target;
			return;
			IL_98B:
			this.LblRadErgoCfgGeneralMAXSVECTOR_A22297 = (global::AcpUI.AcpLabel)target;
			this.LblRadErgoCfgGeneralMAXSVECTOR_A22297.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_9AF:
			this.RTDBtnExtMicNsRdGenACCESSORYAUTOMINGAINVECTOR_42687 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_9BC:
			this.RadErgoCfgGeneralRTHRESHDBQ8_A22308 = (global::AcpUI.AcpTextBoxSpinnerDecHex)target;
			this.RadErgoCfgGeneralRTHRESHDBQ8_A22308.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_9E0:
			this.LblRadErgoCfgGeneralRTHRESHDBQ8_A22308 = (global::AcpUI.AcpLabel)target;
			this.LblRadErgoCfgGeneralRTHRESHDBQ8_A22308.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_A04:
			this.LblRadErgoCfgGeneralEXPANSIONDEGREE_A22299 = (global::AcpUI.AcpLabel)target;
			this.LblRadErgoCfgGeneralEXPANSIONDEGREE_A22299.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_A28:
			this.ExtMicNsRdGenACCESSORYAUTOMINGAINVECTOR_42687Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_A35:
			this.ExtMicNsRdGenDINCOUTPUTEQVECTOR_A37720 = (global::AcpUI.AcpTextBox)target;
			this.ExtMicNsRdGenDINCOUTPUTEQVECTOR_A37720.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_A59:
			this.RadErgoCfgGeneralINACTIVETHRESHDBQ8_A22305Comp = (global::AcpUI.AcpTextBoxDecHex)target;
			return;
			IL_A66:
			this.GrpBoxExpanderExternalMicNoiseReductionProfileGeneralAdaptiveNoiseSuppression = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_A73:
			this.CpyBtnRadErgoCfgGeneralMINGAIN_A22298 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_A80:
			this.RTDBtnRadErgoCfgGeneralEXPANSIONDEGREE_A22299 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_A8D:
			this.CVBtnExtMicNsRdGenDINCEPVECTOR_A37721 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_A9A:
			this.RadErgoCfgGeneralNDIFFTHRESHDBQ8_A22307Comp = (global::AcpUI.AcpTextBoxDecHex)target;
			return;
			IL_AA7:
			this.CpyBtnExtMicNsRdGenACCESSORYAUTORELAXTIONBOUNDS_42688 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_AB4:
			this.LblExtMicNsRdGenDINCOUTPUTEQVECTOR_A37720 = (global::AcpUI.AcpLabel)target;
			this.LblExtMicNsRdGenDINCOUTPUTEQVECTOR_A37720.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_AD8:
			this.RadErgoCfgGeneralNDIFFTHRESHDBQ8_A22307 = (global::AcpUI.AcpTextBoxSpinnerDecHex)target;
			this.RadErgoCfgGeneralNDIFFTHRESHDBQ8_A22307.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_AFC:
			this.CVBtnExtMicNsRdGenDINCOUTPUTEQVECTOR_A37720 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_B09:
			this.CpyBtnExtMicNsRdGenACCESSORYAUTONOISEBOUNDSDBQ8_42686 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_B16:
			this.CVBtnExtMicNsRdGenACCESSORYPASSFILTERSTART_42689 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_B23:
			num = (short)943125450;
			short num4 = num;
			num = (short)1857352650;
			switch ((num4 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				goto IL_3C7;
			default:
				num = (short)474611712;
				if (num != 0)
				{
				}
				this.GrpBoxExpanderExternalMicNoiseReductionProfileGeneralPseudo0 = (global::AcpUI.AcpGroupBox)target;
				return;
			}
			IL_B7B:
			this.RadErgoCfgGeneralDINCABFSS_A22300 = (global::AcpUI.AcpTextBoxSpinnerDecHex)target;
			this.RadErgoCfgGeneralDINCABFSS_A22300.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_B9F:
			this.CpyBtnRadErgoCfgGeneralNDIFFTHRESHDBQ8_A22307 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_BAC:
			this.RTDBtnExtMicNsRdGenACCESSORYPASSFILTERSTART_42689 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_BB9:
			this.CVBtnRadErgoCfgGeneralVADDETCOUNT_A22304 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_BC6:
			this.RadErgoCfgGeneralHOTBEAMDETTHRESHDBQ8_A22302Comp = (global::AcpUI.AcpTextBoxDecHex)target;
			return;
			IL_BD3:
			this.CVBtnExternalMicNoiseReductionProfileName_A22536 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_BE0:
			this.ExtMicNsRdGenDINCEPVECTOR_A37721Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_BED:
			this.RadErgoCfgGeneralMINGAIN_A22298Comp = (global::AcpUI.AcpTextBoxDecHex)target;
			return;
			IL_BFA:
			this.RadErgoCfgGeneralEXPANSIONDEGREE_A22299 = (global::AcpUI.AcpTextBoxSpinnerDecHex)target;
			this.RadErgoCfgGeneralEXPANSIONDEGREE_A22299.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_C1E:
			this.ExtMicNsRdGenACCESSORYPASSFILTERSTART_42689Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_C2B:
			this.CVBtnRadErgoCfgGeneralVADDETTHRESHDBQ8_A22303 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_C38:
			this.ExpanderExternalMicNoiseReductionProfileGeneral = (global::AcpUI.AcpExpander)target;
			return;
			IL_C45:
			this.ExternalMicNoiseReductionProfileName_A22536Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_C52:
			this.GrpBoxExpanderExternalMicNoiseReductionProfileGeneralEWind = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_C5F:
			this.ExtMicNsRdGenACCESSORYAUTONOISEBOUNDSDBQ8_42686Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_C6C:
			this.ExtMicNsRdGenACCESSORYAUTORELAXTIONBOUNDS_42688Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_C79:
			this.RadErgoCfgGeneralINACTIVETHRESHDBQ8_A22305 = (global::AcpUI.AcpTextBoxSpinnerDecHex)target;
			this.RadErgoCfgGeneralINACTIVETHRESHDBQ8_A22305.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_C9D:
			this.CVBtnRadErgoCfgGeneralINACTIVETHRESHDBQ8_A22305 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_CAA:
			this.CpyBtnExtMicNsRdGenACCESSORYPASSFILTERSTART_42689 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_CB7:
			this.RadErgoCfgGeneralMAXSVECTOR_A22297Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_CC4:
			this.CpyBtnRadErgoCfgGeneralVADDETCOUNT_A22304 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_CD1:
			this.LblExtMicNsRdGenACCESSORYPASSFILTERSTART_42689 = (global::AcpUI.AcpLabel)target;
			this.LblExtMicNsRdGenACCESSORYPASSFILTERSTART_42689.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_CF5:
			this.RTDBtnExtMicNsRdGenACCESSORYAUTORELAXTIONBOUNDS_42688 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_D02:
			this.ExternalMicNoiseReductionProfileName_A22536 = (global::AcpUI.AcpTextBox)target;
			this.ExternalMicNoiseReductionProfileName_A22536.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_D26:
			this.RadErgoCfgGeneralMINGAIN_A22298 = (global::AcpUI.AcpTextBoxSpinnerDecHex)target;
			this.RadErgoCfgGeneralMINGAIN_A22298.GotFocus += this.OnFieldNameDoubleClick;
		}

		// Token: 0x04002A47 RID: 10823
		private bool a;

		// Token: 0x04002A48 RID: 10824
		internal global::AcpUI.AcpParentRecNavToolbar RecNavToolbarPageExternalMicNoiseReductionProfile;

		// Token: 0x04002A49 RID: 10825
		internal global::AcpUI.Common.AcpThemeBase ThemeBaseObj;

		// Token: 0x04002A4A RID: 10826
		internal global::System.Windows.Documents.Hyperlink HLinkGeneral;

		// Token: 0x04002A4B RID: 10827
		internal global::System.Windows.Controls.StackPanel MyStackPanel;

		// Token: 0x04002A4C RID: 10828
		internal global::AcpUI.AcpExpander ExpanderExternalMicNoiseReductionProfileGeneral;

		// Token: 0x04002A4D RID: 10829
		internal global::AcpUI.AcpGroupBox GrpBoxExpanderExternalMicNoiseReductionProfileGeneralPseudo0;

		// Token: 0x04002A4E RID: 10830
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnExternalMicNoiseReductionProfileName_A22536;

		// Token: 0x04002A4F RID: 10831
		internal global::AcpUI.AcpLabel LblExternalMicNoiseReductionProfileName_A22536;

		// Token: 0x04002A50 RID: 10832
		internal global::AcpUI.AcpTextBox ExternalMicNoiseReductionProfileName_A22536;

		// Token: 0x04002A51 RID: 10833
		internal global::AcpUI.AcpCopyButton CpyBtnExternalMicNoiseReductionProfileName_A22536;

		// Token: 0x04002A52 RID: 10834
		internal global::AcpUI.AcpLabel ExternalMicNoiseReductionProfileName_A22536Comp;

		// Token: 0x04002A53 RID: 10835
		internal global::AcpUI.AcpGroupBox GrpBoxExpanderExternalMicNoiseReductionProfileGeneralEWind;

		// Token: 0x04002A54 RID: 10836
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadErgoCfgGeneralDINCEWINDNBANDS_A22301;

		// Token: 0x04002A55 RID: 10837
		internal global::AcpUI.AcpLabel LblRadErgoCfgGeneralDINCEWINDNBANDS_A22301;

		// Token: 0x04002A56 RID: 10838
		internal global::AcpUI.AcpTextBoxSpinnerDecHex RadErgoCfgGeneralDINCEWINDNBANDS_A22301;

		// Token: 0x04002A57 RID: 10839
		internal global::AcpUI.AcpRtdButton RTDBtnRadErgoCfgGeneralDINCEWINDNBANDS_A22301;

		// Token: 0x04002A58 RID: 10840
		internal global::AcpUI.AcpCopyButton CpyBtnRadErgoCfgGeneralDINCEWINDNBANDS_A22301;

		// Token: 0x04002A59 RID: 10841
		internal global::AcpUI.AcpTextBoxDecHex RadErgoCfgGeneralDINCEWINDNBANDS_A22301Comp;

		// Token: 0x04002A5A RID: 10842
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadErgoCfgGeneralMAXSVECTOR_A22297;

		// Token: 0x04002A5B RID: 10843
		internal global::AcpUI.AcpLabel LblRadErgoCfgGeneralMAXSVECTOR_A22297;

		// Token: 0x04002A5C RID: 10844
		internal global::AcpUI.AcpTextBox RadErgoCfgGeneralMAXSVECTOR_A22297;

		// Token: 0x04002A5D RID: 10845
		internal global::AcpUI.AcpRtdButton RTDBtnRadErgoCfgGeneralMAXSVECTOR_A22297;

		// Token: 0x04002A5E RID: 10846
		internal global::AcpUI.AcpCopyButton CpyBtnRadErgoCfgGeneralMAXSVECTOR_A22297;

		// Token: 0x04002A5F RID: 10847
		internal global::AcpUI.AcpLabel RadErgoCfgGeneralMAXSVECTOR_A22297Comp;

		// Token: 0x04002A60 RID: 10848
		internal global::AcpUI.AcpGroupBox GrpBoxExpanderExternalMicNoiseReductionProfileGeneralPseudo1;

		// Token: 0x04002A61 RID: 10849
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadErgoCfgGeneralDINCABFSS_A22300;

		// Token: 0x04002A62 RID: 10850
		internal global::AcpUI.AcpLabel LblRadErgoCfgGeneralDINCABFSS_A22300;

		// Token: 0x04002A63 RID: 10851
		internal global::AcpUI.AcpTextBoxSpinnerDecHex RadErgoCfgGeneralDINCABFSS_A22300;

		// Token: 0x04002A64 RID: 10852
		internal global::AcpUI.AcpRtdButton RTDBtnRadErgoCfgGeneralDINCABFSS_A22300;

		// Token: 0x04002A65 RID: 10853
		internal global::AcpUI.AcpCopyButton CpyBtnRadErgoCfgGeneralDINCABFSS_A22300;

		// Token: 0x04002A66 RID: 10854
		internal global::AcpUI.AcpTextBoxDecHex RadErgoCfgGeneralDINCABFSS_A22300Comp;

		// Token: 0x04002A67 RID: 10855
		internal global::AcpUI.AcpGroupBox GrpBoxExpanderExternalMicNoiseReductionProfileGeneralDWF;

		// Token: 0x04002A68 RID: 10856
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadErgoCfgGeneralMINGAIN_A22298;

		// Token: 0x04002A69 RID: 10857
		internal global::AcpUI.AcpLabel LblRadErgoCfgGeneralMINGAIN_A22298;

		// Token: 0x04002A6A RID: 10858
		internal global::AcpUI.AcpTextBoxSpinnerDecHex RadErgoCfgGeneralMINGAIN_A22298;

		// Token: 0x04002A6B RID: 10859
		internal global::AcpUI.AcpRtdButton RTDBtnRadErgoCfgGeneralMINGAIN_A22298;

		// Token: 0x04002A6C RID: 10860
		internal global::AcpUI.AcpCopyButton CpyBtnRadErgoCfgGeneralMINGAIN_A22298;

		// Token: 0x04002A6D RID: 10861
		internal global::AcpUI.AcpTextBoxDecHex RadErgoCfgGeneralMINGAIN_A22298Comp;

		// Token: 0x04002A6E RID: 10862
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadErgoCfgGeneralEXPANSIONDEGREE_A22299;

		// Token: 0x04002A6F RID: 10863
		internal global::AcpUI.AcpLabel LblRadErgoCfgGeneralEXPANSIONDEGREE_A22299;

		// Token: 0x04002A70 RID: 10864
		internal global::AcpUI.AcpTextBoxSpinnerDecHex RadErgoCfgGeneralEXPANSIONDEGREE_A22299;

		// Token: 0x04002A71 RID: 10865
		internal global::AcpUI.AcpRtdButton RTDBtnRadErgoCfgGeneralEXPANSIONDEGREE_A22299;

		// Token: 0x04002A72 RID: 10866
		internal global::AcpUI.AcpCopyButton CpyBtnRadErgoCfgGeneralEXPANSIONDEGREE_A22299;

		// Token: 0x04002A73 RID: 10867
		internal global::AcpUI.AcpTextBoxDecHex RadErgoCfgGeneralEXPANSIONDEGREE_A22299Comp;

		// Token: 0x04002A74 RID: 10868
		internal global::AcpUI.AcpGroupBox GrpBoxExpanderExternalMicNoiseReductionProfileGeneralPseudo2;

		// Token: 0x04002A75 RID: 10869
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadErgoCfgGeneralHOTBEAMDETTHRESHDBQ8_A22302;

		// Token: 0x04002A76 RID: 10870
		internal global::AcpUI.AcpLabel LblRadErgoCfgGeneralHOTBEAMDETTHRESHDBQ8_A22302;

		// Token: 0x04002A77 RID: 10871
		internal global::AcpUI.AcpTextBoxSpinnerDecHex RadErgoCfgGeneralHOTBEAMDETTHRESHDBQ8_A22302;

		// Token: 0x04002A78 RID: 10872
		internal global::AcpUI.AcpRtdButton RTDBtnRadErgoCfgGeneralHOTBEAMDETTHRESHDBQ8_A22302;

		// Token: 0x04002A79 RID: 10873
		internal global::AcpUI.AcpCopyButton CpyBtnRadErgoCfgGeneralHOTBEAMDETTHRESHDBQ8_A22302;

		// Token: 0x04002A7A RID: 10874
		internal global::AcpUI.AcpTextBoxDecHex RadErgoCfgGeneralHOTBEAMDETTHRESHDBQ8_A22302Comp;

		// Token: 0x04002A7B RID: 10875
		internal global::AcpUI.AcpGroupBox GrpBoxExpanderExternalMicNoiseReductionProfileGeneralStatus;

		// Token: 0x04002A7C RID: 10876
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadErgoCfgGeneralVADDETTHRESHDBQ8_A22303;

		// Token: 0x04002A7D RID: 10877
		internal global::AcpUI.AcpLabel LblRadErgoCfgGeneralVADDETTHRESHDBQ8_A22303;

		// Token: 0x04002A7E RID: 10878
		internal global::AcpUI.AcpTextBoxSpinnerDecHex RadErgoCfgGeneralVADDETTHRESHDBQ8_A22303;

		// Token: 0x04002A7F RID: 10879
		internal global::AcpUI.AcpRtdButton RTDBtnRadErgoCfgGeneralVADDETTHRESHDBQ8_A22303;

		// Token: 0x04002A80 RID: 10880
		internal global::AcpUI.AcpCopyButton CpyBtnRadErgoCfgGeneralVADDETTHRESHDBQ8_A22303;

		// Token: 0x04002A81 RID: 10881
		internal global::AcpUI.AcpTextBoxDecHex RadErgoCfgGeneralVADDETTHRESHDBQ8_A22303Comp;

		// Token: 0x04002A82 RID: 10882
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadErgoCfgGeneralVADDETCOUNT_A22304;

		// Token: 0x04002A83 RID: 10883
		internal global::AcpUI.AcpLabel LblRadErgoCfgGeneralVADDETCOUNT_A22304;

		// Token: 0x04002A84 RID: 10884
		internal global::AcpUI.AcpTextBoxSpinnerDecHex RadErgoCfgGeneralVADDETCOUNT_A22304;

		// Token: 0x04002A85 RID: 10885
		internal global::AcpUI.AcpRtdButton RTDBtnRadErgoCfgGeneralVADDETCOUNT_A22304;

		// Token: 0x04002A86 RID: 10886
		internal global::AcpUI.AcpCopyButton CpyBtnRadErgoCfgGeneralVADDETCOUNT_A22304;

		// Token: 0x04002A87 RID: 10887
		internal global::AcpUI.AcpTextBoxDecHex RadErgoCfgGeneralVADDETCOUNT_A22304Comp;

		// Token: 0x04002A88 RID: 10888
		internal global::AcpUI.AcpGroupBox GrpBoxExpanderExternalMicNoiseReductionProfileGeneralBadMic;

		// Token: 0x04002A89 RID: 10889
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadErgoCfgGeneralINACTIVETHRESHDBQ8_A22305;

		// Token: 0x04002A8A RID: 10890
		internal global::AcpUI.AcpLabel LblRadErgoCfgGeneralINACTIVETHRESHDBQ8_A22305;

		// Token: 0x04002A8B RID: 10891
		internal global::AcpUI.AcpTextBoxSpinnerDecHex RadErgoCfgGeneralINACTIVETHRESHDBQ8_A22305;

		// Token: 0x04002A8C RID: 10892
		internal global::AcpUI.AcpRtdButton RTDBtnRadErgoCfgGeneralINACTIVETHRESHDBQ8_A22305;

		// Token: 0x04002A8D RID: 10893
		internal global::AcpUI.AcpCopyButton CpyBtnRadErgoCfgGeneralINACTIVETHRESHDBQ8_A22305;

		// Token: 0x04002A8E RID: 10894
		internal global::AcpUI.AcpTextBoxDecHex RadErgoCfgGeneralINACTIVETHRESHDBQ8_A22305Comp;

		// Token: 0x04002A8F RID: 10895
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadErgoCfgGeneralSDIFFTHRESHDBQ8_A22306;

		// Token: 0x04002A90 RID: 10896
		internal global::AcpUI.AcpLabel LblRadErgoCfgGeneralSDIFFTHRESHDBQ8_A22306;

		// Token: 0x04002A91 RID: 10897
		internal global::AcpUI.AcpTextBoxSpinnerDecHex RadErgoCfgGeneralSDIFFTHRESHDBQ8_A22306;

		// Token: 0x04002A92 RID: 10898
		internal global::AcpUI.AcpRtdButton RTDBtnRadErgoCfgGeneralSDIFFTHRESHDBQ8_A22306;

		// Token: 0x04002A93 RID: 10899
		internal global::AcpUI.AcpCopyButton CpyBtnRadErgoCfgGeneralSDIFFTHRESHDBQ8_A22306;

		// Token: 0x04002A94 RID: 10900
		internal global::AcpUI.AcpTextBoxDecHex RadErgoCfgGeneralSDIFFTHRESHDBQ8_A22306Comp;

		// Token: 0x04002A95 RID: 10901
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadErgoCfgGeneralNDIFFTHRESHDBQ8_A22307;

		// Token: 0x04002A96 RID: 10902
		internal global::AcpUI.AcpLabel LblRadErgoCfgGeneralNDIFFTHRESHDBQ8_A22307;

		// Token: 0x04002A97 RID: 10903
		internal global::AcpUI.AcpTextBoxSpinnerDecHex RadErgoCfgGeneralNDIFFTHRESHDBQ8_A22307;

		// Token: 0x04002A98 RID: 10904
		internal global::AcpUI.AcpRtdButton RTDBtnRadErgoCfgGeneralNDIFFTHRESHDBQ8_A22307;

		// Token: 0x04002A99 RID: 10905
		internal global::AcpUI.AcpCopyButton CpyBtnRadErgoCfgGeneralNDIFFTHRESHDBQ8_A22307;

		// Token: 0x04002A9A RID: 10906
		internal global::AcpUI.AcpTextBoxDecHex RadErgoCfgGeneralNDIFFTHRESHDBQ8_A22307Comp;

		// Token: 0x04002A9B RID: 10907
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadErgoCfgGeneralRTHRESHDBQ8_A22308;

		// Token: 0x04002A9C RID: 10908
		internal global::AcpUI.AcpLabel LblRadErgoCfgGeneralRTHRESHDBQ8_A22308;

		// Token: 0x04002A9D RID: 10909
		internal global::AcpUI.AcpTextBoxSpinnerDecHex RadErgoCfgGeneralRTHRESHDBQ8_A22308;

		// Token: 0x04002A9E RID: 10910
		internal global::AcpUI.AcpRtdButton RTDBtnRadErgoCfgGeneralRTHRESHDBQ8_A22308;

		// Token: 0x04002A9F RID: 10911
		internal global::AcpUI.AcpCopyButton CpyBtnRadErgoCfgGeneralRTHRESHDBQ8_A22308;

		// Token: 0x04002AA0 RID: 10912
		internal global::AcpUI.AcpTextBoxDecHex RadErgoCfgGeneralRTHRESHDBQ8_A22308Comp;

		// Token: 0x04002AA1 RID: 10913
		internal global::AcpUI.AcpGroupBox GrpBoxExpanderExternalMicNoiseReductionProfileGeneralPseudo4;

		// Token: 0x04002AA2 RID: 10914
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnExtMicNsRdGenDINCOUTPUTEQVECTOR_A37720;

		// Token: 0x04002AA3 RID: 10915
		internal global::AcpUI.AcpLabel LblExtMicNsRdGenDINCOUTPUTEQVECTOR_A37720;

		// Token: 0x04002AA4 RID: 10916
		internal global::AcpUI.AcpTextBox ExtMicNsRdGenDINCOUTPUTEQVECTOR_A37720;

		// Token: 0x04002AA5 RID: 10917
		internal global::AcpUI.AcpRtdButton RTDBtnExtMicNsRdGenDINCOUTPUTEQVECTOR_A37720;

		// Token: 0x04002AA6 RID: 10918
		internal global::AcpUI.AcpCopyButton CpyBtnExtMicNsRdGenDINCOUTPUTEQVECTOR_A37720;

		// Token: 0x04002AA7 RID: 10919
		internal global::AcpUI.AcpLabel ExtMicNsRdGenDINCOUTPUTEQVECTOR_A37720Comp;

		// Token: 0x04002AA8 RID: 10920
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnExtMicNsRdGenDINCEPVECTOR_A37721;

		// Token: 0x04002AA9 RID: 10921
		internal global::AcpUI.AcpLabel LblExtMicNsRdGenDINCEPVECTOR_A37721;

		// Token: 0x04002AAA RID: 10922
		internal global::AcpUI.AcpTextBox ExtMicNsRdGenDINCEPVECTOR_A37721;

		// Token: 0x04002AAB RID: 10923
		internal global::AcpUI.AcpRtdButton RTDBtnExtMicNsRdGenDINCEPVECTOR_A37721;

		// Token: 0x04002AAC RID: 10924
		internal global::AcpUI.AcpCopyButton CpyBtnExtMicNsRdGenDINCEPVECTOR_A37721;

		// Token: 0x04002AAD RID: 10925
		internal global::AcpUI.AcpLabel ExtMicNsRdGenDINCEPVECTOR_A37721Comp;

		// Token: 0x04002AAE RID: 10926
		internal global::AcpUI.AcpGroupBox GrpBoxExpanderExternalMicNoiseReductionProfileGeneralAdaptiveNoiseSuppression;

		// Token: 0x04002AAF RID: 10927
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnExtMicNsRdGenACCESSORYAUTONOISEBOUNDSDBQ8_42686;

		// Token: 0x04002AB0 RID: 10928
		internal global::AcpUI.AcpLabel LblExtMicNsRdGenACCESSORYAUTONOISEBOUNDSDBQ8_42686;

		// Token: 0x04002AB1 RID: 10929
		internal global::AcpUI.AcpTextBox ExtMicNsRdGenACCESSORYAUTONOISEBOUNDSDBQ8_42686;

		// Token: 0x04002AB2 RID: 10930
		internal global::AcpUI.AcpRtdButton RTDBtnExtMicNsRdGenACCESSORYAUTONOISEBOUNDSDBQ8_42686;

		// Token: 0x04002AB3 RID: 10931
		internal global::AcpUI.AcpCopyButton CpyBtnExtMicNsRdGenACCESSORYAUTONOISEBOUNDSDBQ8_42686;

		// Token: 0x04002AB4 RID: 10932
		internal global::AcpUI.AcpLabel ExtMicNsRdGenACCESSORYAUTONOISEBOUNDSDBQ8_42686Comp;

		// Token: 0x04002AB5 RID: 10933
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnExtMicNsRdGenACCESSORYAUTOMINGAINVECTOR_42687;

		// Token: 0x04002AB6 RID: 10934
		internal global::AcpUI.AcpLabel LblExtMicNsRdGenACCESSORYAUTOMINGAINVECTOR_42687;

		// Token: 0x04002AB7 RID: 10935
		internal global::AcpUI.AcpTextBox ExtMicNsRdGenACCESSORYAUTOMINGAINVECTOR_42687;

		// Token: 0x04002AB8 RID: 10936
		internal global::AcpUI.AcpRtdButton RTDBtnExtMicNsRdGenACCESSORYAUTOMINGAINVECTOR_42687;

		// Token: 0x04002AB9 RID: 10937
		internal global::AcpUI.AcpCopyButton CpyBtnExtMicNsRdGenACCESSORYAUTOMINGAINVECTOR_42687;

		// Token: 0x04002ABA RID: 10938
		internal global::AcpUI.AcpLabel ExtMicNsRdGenACCESSORYAUTOMINGAINVECTOR_42687Comp;

		// Token: 0x04002ABB RID: 10939
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnExtMicNsRdGenACCESSORYAUTORELAXTIONBOUNDS_42688;

		// Token: 0x04002ABC RID: 10940
		internal global::AcpUI.AcpLabel LblExtMicNsRdGenACCESSORYAUTORELAXTIONBOUNDS_42688;

		// Token: 0x04002ABD RID: 10941
		internal global::AcpUI.AcpTextBox ExtMicNsRdGenACCESSORYAUTORELAXTIONBOUNDS_42688;

		// Token: 0x04002ABE RID: 10942
		internal global::AcpUI.AcpRtdButton RTDBtnExtMicNsRdGenACCESSORYAUTORELAXTIONBOUNDS_42688;

		// Token: 0x04002ABF RID: 10943
		internal global::AcpUI.AcpCopyButton CpyBtnExtMicNsRdGenACCESSORYAUTORELAXTIONBOUNDS_42688;

		// Token: 0x04002AC0 RID: 10944
		internal global::AcpUI.AcpLabel ExtMicNsRdGenACCESSORYAUTORELAXTIONBOUNDS_42688Comp;

		// Token: 0x04002AC1 RID: 10945
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnExtMicNsRdGenACCESSORYPASSFILTERSTART_42689;

		// Token: 0x04002AC2 RID: 10946
		internal global::AcpUI.AcpLabel LblExtMicNsRdGenACCESSORYPASSFILTERSTART_42689;

		// Token: 0x04002AC3 RID: 10947
		internal global::AcpUI.AcpTextBoxSpinner ExtMicNsRdGenACCESSORYPASSFILTERSTART_42689;

		// Token: 0x04002AC4 RID: 10948
		internal global::AcpUI.AcpRtdButton RTDBtnExtMicNsRdGenACCESSORYPASSFILTERSTART_42689;

		// Token: 0x04002AC5 RID: 10949
		internal global::AcpUI.AcpCopyButton CpyBtnExtMicNsRdGenACCESSORYPASSFILTERSTART_42689;

		// Token: 0x04002AC6 RID: 10950
		internal global::AcpUI.AcpLabel ExtMicNsRdGenACCESSORYPASSFILTERSTART_42689Comp;

		// Token: 0x04002AC7 RID: 10951
		private bool b;
	}
}
