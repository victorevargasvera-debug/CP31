using System;
using Infragistics.Windows.DataPresenter;
using Motorola.CommonCPS.RadioManagement.UIModels;
using Motorola.CommonCPS.UI.CellRangeFill;

namespace Motorola.CommonCPS.RadioManagement.Radio
{
	// Token: 0x02000006 RID: 6
	public class AstroCellEditabilityResolver : global::Motorola.CommonCPS.UI.CellRangeFill.ICellEditabilityResolver
	{
		// Token: 0x06000016 RID: 22 RVA: 0x000030CC File Offset: 0x000012CC
		public bool CanEdit(global::Infragistics.Windows.DataPresenter.Cell cell)
		{
			int a_ = 1;
			short num = (short)1119027200;
			switch (num)
			{
			default:
			{
				num = (short)1752956945;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					bool result;
					uint num3;
					string name;
					global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadio astroradio;
					switch (num2)
					{
					case 0:
						return result;
					case 1:
						goto IL_13F2;
					case 2:
						num = (short)1972961386;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						return result;
					case 4:
						num = (short)1286864961;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						if (num3 != 505833392U)
						{
							num = (short)1137311837;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)625344547;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
						if (!(name == global::Motorola.CommonCPS.RadioManagement.Radio.WiFiPasswordValidationViewModel.c("쒶트\ud8bc캾듀ꫂ럄ꋆ귈", a_)))
						{
							num = (short)1074200674;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						result = astroradio.IsAskRequiredEditable;
						num = (short)1287323740;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
						num = (short)1754136687;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 8:
						if (num3 != 3942800474U)
						{
							num = (short)188219441;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)725287017;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 9:
						goto IL_13F2;
					case 10:
						num = (short)903413880;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 11:
						if (num3 != 1381509879U)
						{
							num = (short)691994628;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)758972440;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 12:
						if (num3 != 633542544U)
						{
							num = (short)1845428321;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)540999782;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 13:
						num = (short)413335597;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 14:
						if (num3 != 2557910859U)
						{
							num = (short)1590493291;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1947926534;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 15:
						num = (short)1621688397;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 16:
						if (!(name == global::Motorola.CommonCPS.RadioManagement.Radio.WiFiPasswordValidationViewModel.c("튶쮸튺\udcbc펾迀뛂꣄ꗆ곈맊", a_)))
						{
							num = (short)348782717;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						result = astroradio.IsSerialNumberEditable;
						num = (short)1472200799;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 17:
						switch (0)
						{
						case 0:
							goto IL_24A;
						}
						continue;
					case 18:
						goto IL_269;
					case 19:
						if (num3 <= 2620727545U)
						{
							num = (short)1523974194;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)526778424;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 20:
						if (num3 != 3701754928U)
						{
							num = (short)2110062705;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1326252140;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 21:
						goto IL_13F2;
					case 22:
						num = (short)1789788235;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 23:
						goto IL_13F2;
					case 24:
						if (!(name == global::Motorola.CommonCPS.RadioManagement.Radio.WiFiPasswordValidationViewModel.c("\ud8b6풸횺\ud8bc톾뗀냂", a_)))
						{
							num = (short)2134442055;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						result = true;
						goto IL_13D8;
					case 25:
						return result;
					case 26:
						return result;
					case 27:
						goto IL_13F2;
					case 28:
						if (num3 != 1157191835U)
						{
							num = (short)632815658;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)57933924;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 29:
						return result;
					case 30:
						num = (short)1229783054;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 31:
						num = (short)562430041;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 32:
						return result;
					case 33:
						if (!(name == global::Motorola.CommonCPS.RadioManagement.Radio.WiFiPasswordValidationViewModel.c("얶횸캺춼ꃀ껂ꃄ", a_)))
						{
							num = (short)513867844;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						result = astroradio.IsGroupNameEditable;
						num = (short)1464467482;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 34:
						num = (short)330301539;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 35:
						if (!(name == global::Motorola.CommonCPS.RadioManagement.Radio.WiFiPasswordValidationViewModel.c("횶\uddb8튺튼ﺾ귀ꫂ꓄듆", a_)))
						{
							num = (short)1745223794;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						result = astroradio.IsRadioAliasEditable;
						num = (short)1282932761;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 36:
						return result;
					case 37:
						num = (short)301924406;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 38:
						num = (short)1770520642;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 39:
						num = (short)1452146693;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 40:
						if (!(name == global::Motorola.CommonCPS.RadioManagement.Radio.WiFiPasswordValidationViewModel.c("슶\udbb8좺\udebc춾ꣀꇂꃄ뗆胈鯊", a_)))
						{
							num = (short)1201668118;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						result = astroradio.IsSubscriberIPEditable;
						num = (short)1626210425;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 41:
						num = (short)1230176257;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 42:
						num = (short)1525153855;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 43:
						if (num3 != 2733624436U)
						{
							num = (short)268697724;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)2143813684;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 44:
						return result;
					case 45:
						goto IL_13F2;
					case 46:
						if (!(name == global::Motorola.CommonCPS.RadioManagement.Radio.WiFiPasswordValidationViewModel.c("\udbb6첸\udeba즼킾껀럂귄臆믈ꋊ꣌ꇎ뗐뿒곔駖룘뛚룜", a_)))
						{
							num = (short)1451950082;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						result = astroradio.IsBluetoothFriendlyNameEditable;
						num = (short)1330511990;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 47:
						num = (short)790888491;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 48:
						if (num3 != 1834575210U)
						{
							num = (short)537854025;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1981743144;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 49:
						num = (short)872677499;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 50:
						num = (short)1338769511;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 51:
						num = (short)623575102;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 52:
					{
						num = (short)334748299;
						short num4 = num;
						num = (short)167107211;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_13D8;
						default:
							num = (short)1570504704;
							if (num != 0)
							{
							}
							if (!(name == global::Motorola.CommonCPS.RadioManagement.Radio.WiFiPasswordValidationViewModel.c("ﾺ", a_)))
							{
								num = (short)1835073608;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							result = astroradio.IsVRIDEditable;
							num = (short)1797062659;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 53:
						return result;
					case 54:
						goto IL_13F2;
					case 55:
						if (num3 != 2565758308U)
						{
							num = (short)1129709638;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1227096080;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 56:
						if (num3 <= 3134841045U)
						{
							num = (short)1069613103;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)110821435;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 57:
						if (num3 != 1967662407U)
						{
							num = (short)2024341542;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)599654433;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 58:
						if (!(name == global::Motorola.CommonCPS.RadioManagement.Radio.WiFiPasswordValidationViewModel.c("쒶\udcb8즺迀", a_)))
						{
							num = (short)1490026533;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						result = astroradio.IsUserPINEditable;
						num = (short)1973944349;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 59:
						if (num3 != 3180538576U)
						{
							num = (short)576520271;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)839712849;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 60:
						if (num3 <= 1967662407U)
						{
							num = (short)1761214465;
							if (num != 0)
							{
							}
							num = (short)258211959;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)408289299;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 61:
						num = (short)1088290827;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 62:
						if (num3 != 2231345737U)
						{
							num = (short)1871052830;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1675165754;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 63:
						if (num3 != 1216208513U)
						{
							num = (short)1830813811;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1771896899;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 64:
						goto IL_13F2;
					case 65:
						if (num3 != 1560111736U)
						{
							num = (short)1648230441;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)2113798234;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 66:
						goto IL_13F2;
					case 67:
						if (!(name == global::Motorola.CommonCPS.RadioManagement.Radio.WiFiPasswordValidationViewModel.c("\udbb6첸\udeba즼킾껀럂귄菆鳈藊鷌꫎듐ꇒ鳔蟖", a_)))
						{
							num = (short)1504182382;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						result = astroradio.IsBluetoothDUNPeerIPEditable;
						num = (short)1947926581;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 68:
						num = (short)2048983152;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 69:
						if (num3 != 3134841045U)
						{
							num = (short)1710227532;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1089470510;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 70:
						num = (short)2090729546;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 71:
						num = (short)1057816677;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 72:
						num = (short)1601699936;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 73:
						num = (short)512294969;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 74:
						if (num3 != 2620727545U)
						{
							num = (short)796852231;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1082654829;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 75:
						goto IL_13F2;
					case 76:
						num = (short)564723739;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 77:
						goto IL_13F2;
					case 78:
						num = (short)658505811;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 79:
						num = (short)151846932;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 80:
						if (num3 <= 1216208513U)
						{
							num = (short)1008861262;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1280442484;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 81:
						if (!(name == global::Motorola.CommonCPS.RadioManagement.Radio.WiFiPasswordValidationViewModel.c("쒶\udcb8즺킾ꛀꫂꯄ鋆ꟈꋊ만蛎闐", a_)))
						{
							num = (short)1446510602;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						result = astroradio.IsUserLoginUnitIDEditable;
						num = (short)799408160;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 82:
						return result;
					case 83:
						if (num3 <= 633542544U)
						{
							num = (short)552861735;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1584332828;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 84:
						goto IL_13F2;
					case 85:
						return result;
					case 86:
						return result;
					case 87:
						return result;
					case 88:
						goto IL_13F2;
					case 89:
						goto IL_13F2;
					case 90:
						if (!(name == global::Motorola.CommonCPS.RadioManagement.Radio.WiFiPasswordValidationViewModel.c("華쎶\ud8b8즺﮾", a_)))
						{
							num = (short)999489662;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						result = astroradio.IsOtarIDEditable;
						num = (short)1904082944;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 91:
						return result;
					case 92:
						return result;
					case 93:
						num = (short)1689845772;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 94:
						goto IL_13F2;
					case 95:
						return result;
					case 96:
						goto IL_13F2;
					case 97:
						num = (short)1296433236;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 98:
						num = (short)1736310888;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 99:
						goto IL_13F2;
					case 100:
						if (!(name == global::Motorola.CommonCPS.RadioManagement.Radio.WiFiPasswordValidationViewModel.c("\udbb6첸\udeba즼킾껀럂귄菆鳈藊黌뫎돐ꃒ뛔ꗖ냘맚룜귞꣠돢", a_)))
						{
							num = (short)1128398879;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						result = astroradio.IsBluetoothDUNSubscriberIPEditable;
						num = (short)22610006;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 101:
						goto IL_13F2;
					case 102:
						if (!(name == global::Motorola.CommonCPS.RadioManagement.Radio.WiFiPasswordValidationViewModel.c("튶\udcb8즺", a_)))
						{
							num = (short)1102184482;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						result = astroradio.IsPeerIPEditable;
						num = (short)1386217557;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 103:
						if (num3 <= 2557910859U)
						{
							num = (short)759758899;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)713031735;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 104:
						goto IL_13F2;
					case 105:
						if (!(name == global::Motorola.CommonCPS.RadioManagement.Radio.WiFiPasswordValidationViewModel.c("\ud8b6쮸\udeba풼\ud8be꿀諂闄", a_)))
						{
							num = (short)2009530383;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						result = astroradio.IsForeignIPEditable;
						num = (short)1183580251;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 106:
						goto IL_13F2;
					case 107:
						num = (short)698286202;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 108:
						if (!(name == global::Motorola.CommonCPS.RadioManagement.Radio.WiFiPasswordValidationViewModel.c("튶풸쮺톼\udebe뗀ꛂ评ꛆ꓈껊", a_)))
						{
							num = (short)1147011085;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						result = false;
						num = (short)366739492;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 109:
						if (!(name == global::Motorola.CommonCPS.RadioManagement.Radio.WiFiPasswordValidationViewModel.c("쒶\udcb8즺\udebe곀ꛂ", a_)))
						{
							num = (short)1016987765;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						result = astroradio.IsUserNameEditable;
						num = (short)219283543;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 110:
						num = (short)286064728;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 111:
						goto IL_13F2;
					case 112:
						goto IL_13F2;
					case 113:
						num = (short)1431633928;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 114:
					{
						num = (short)402915328;
						short num5 = num;
						num = (short)1049165888;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 115:
						num = (short)1214644247;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 116:
						if (num3 <= 1560111736U)
						{
							num = (short)2083979325;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)137429040;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 117:
						num = (short)709427294;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 118:
						return result;
					case 119:
						num = (short)168427600;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 120:
						goto IL_13F2;
					case 121:
						return result;
					case 122:
						goto IL_13F2;
					case 123:
						goto IL_13F2;
					case 124:
						num = (short)345964613;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 125:
						num = (short)1458962453;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 126:
						num = (short)676069385;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_24A:
					if (cell == null)
					{
						num = (short)1702559762;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					astroradio = (cell.Record.DataItem as global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadio);
					name = cell.Field.Name;
					num3 = global::d.a(name);
					num = (short)680853564;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_13D8:
					num = (short)790298706;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_13F2:
					result = false;
					num = (short)1842544684;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_269:
				throw new global::System.ArgumentNullException(global::Motorola.CommonCPS.RadioManagement.Radio.WiFiPasswordValidationViewModel.c("횴튶햸ힺ", a_));
			}
			}
		}
	}
}
